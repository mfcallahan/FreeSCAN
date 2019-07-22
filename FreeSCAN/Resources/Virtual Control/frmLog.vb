

Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports NAudio.Wave
Imports NAudio
Friend Class frmLog
    Inherits System.Windows.Forms.Form
    Public RadioID(1, 7) As String
    Public sPList() As String
    Const MaxSearchResult As Integer = 2000
    Dim bAbortPlayback As Boolean = True, bSkipPlayFile As Boolean
    Dim sFileHeader As String = "FSLOG0000001-53157bb5d92b819b4cb046798971c50b"
    Public sIsolationDir As String = "\Isolated"
    Dim sLogFileName As String = Nothing 'file name and path of last log file saved by user
    Dim sLogFileDir As String = GetSetting("FreeSCAN", "Settings", "LogFileDir", Nothing) 'default directory for auto save log files
    Public sDefaultCaption As String = "Log Viewer "
    Dim bLoadLogThreadBusy As Boolean = False
    Dim sPlayBackCmd As String = ""
    Dim waveoutDevice As IWavePlayer = New WaveOut
    Dim mainOutputStream As WaveStream
    Dim volumeStream As WaveChannel32

    Sub DrawDisplayLog()
        'updates the grid
        'is there anything to draw at all
        If intLogPos > 0 Then
            DrawGridRow((intLogPos))
        End If
    End Sub

    Sub DrawGridRow(ByRef intRow As Integer)
        If blnDebug = False Then On Error Resume Next
        Dim strChan, strSys, strBuff, strGroup, strTone As String
        Dim strHuh, strFreq, strTime, strDur, strNAC As String
        Dim lngSysKey As Integer, iNumHits As Integer = 0, iRow As Integer = 0
        Dim lngNodeCount, lngGrpKey, lngChnKey, lngCnt, iMaxRow As Integer
        Dim lAvgRSSI As Long = 0
        Dim blnObj As Boolean, bNewChan As Boolean
        Dim blnTrunk As Boolean
        Dim lngSumSysKey, toneidx As Integer
        Dim dteStartTime As TimeSpan
        Dim dteRunTime As TimeSpan, dteAcuTime As Date
        Dim sUID, sRecName As String
        strNAC = Nothing
        strBuff = strRecLog(intRow, 1)
        If IsNumeric(strBuff) = True And Len(strBuff) = 8 Then 'convert to MHZ

            If frmCtlSetup.BaseStation(strMDL) = False And InStr(strBuff, ".") = 0 Then
                strBuff = CStr(Val(strBuff) / 10000)
            End If

            strBuff = FormatFreq(Val(strBuff))
            strRecLog(intRow, 1) = strBuff
        End If

        If InStr(strRecLog(intRow, 1), ".") <> 0 Then 'convetional system
            blnTrunk = False
        Else
            blnTrunk = True
        End If

        ' lngNodeCount = tvwLin.NodeCount
        strSys = strRecLog(intRow, 5) 'system name
        strGroup = strRecLog(intRow, 6) 'group name
        strChan = strRecLog(intRow, 7) 'channel name
        toneidx = Val(strRecLog(intRow, 4))
        If toneidx >= 0 And toneidx < 232 Then
            strTone = CTCSS(toneidx) 'tone
        End If


        strFreq = strBuff 'tgid/freq
        strTime = strRecLog(intRow, 8) 'initial time
        strHuh = strRecLog(intRow, 9) 'date
        strDur = strRecLog(intRow, 10) 'duration
        strNAC = strRecLog(intRow, 13) 'NAC
        sUID = strRecLog(intRow, 14) 'uid
        sRecName = strRecLog(intRow, 15) 'recorded file name
        'does the system already exist
        blnObj = False 'assum it does and a new obj not req
        lngSysKey = 0
        lngGrpKey = 0
        lngChnKey = 0
        'Add to the summary grid first
        With grdSum
            'First look for an existing one, if there is one
            iMaxRow = .Rows.Count - 1

            bNewChan = True 'Might need a new row added to the grid
            If iMaxRow <> -1 Then

                '///////////////////////////////////////////This is just for the summary grid ONLY
                For lngCnt = 0 To iMaxRow
                    If grdSum(7, lngCnt).Value = strSys And grdSum(8, lngCnt).Value = strGroup And grdSum(1, lngCnt).Value = strChan And grdSum(2, lngCnt).Value = strFreq Then
                        'Found a match, so update that one line
                        iNumHits = Val(grdSum(4, lngCnt).Value) + 1
                        strBuff = CStr(iNumHits)
                        strBuff = Format(Val(strBuff), "#0000")
                        grdSum(4, lngCnt).Value = strBuff 'updates sum
                        bNewChan = False
                        strBuff = grdSum(6, lngCnt).Value
                        If Len(strBuff) = 8 Then
                            dteStartTime = New TimeSpan(CInt(OldMid(strBuff, 1, 2)), CInt(OldMid(strBuff, 4, 2)), CInt(OldMid(strBuff, 7, 2)))
                            dteRunTime = New TimeSpan(CInt(OldMid(strDur, 1, 2)), CInt(OldMid(strDur, 4, 2)), CInt(OldMid(strDur, 7, 2)))
                            dteRunTime = dteStartTime.Add(dteRunTime)
                            With dteRunTime
                                strBuff = Format(.Hours, "00") & ":" & Format(.Minutes, "00") & ":" & Format(.Seconds, "00")
                            End With
                            grdSum(6, lngCnt).Value = strBuff 'update duration
                            'update avg rssi
                            lAvgRSSI = CDbl(grdSum(5, lngCnt).Value)
                            lAvgRSSI = lAvgRSSI * iNumHits
                            lAvgRSSI = lAvgRSSI + Val(strRecLog(intRow, 12))
                            lAvgRSSI = lAvgRSSI / (iNumHits + 1)
                            lAvgRSSI = Math.Round(lAvgRSSI)

                            grdSum(5, lngCnt).Value = CStr(lAvgRSSI)
                        End If
                        Exit For
                    End If
                Next
            End If
            '///////////////////STILL ON THE SUMMARY STUFF!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            If bNewChan Then 'add a new row to the grid
                With grdSum
                    iRow = .Rows.Count
                    .Rows.Add()
                    If UCase(strNAC) <> "NONE" And strNAC <> "" Then
                        strBuff = strNAC
                    Else
                        strBuff = strTone
                    End If
                    grdSum(0, iRow).Value = Format(iRow, "#00000") 'counter
                    grdSum(1, iRow).Value = strChan 'tag
                    grdSum(2, iRow).Value = strFreq 'freq
                    grdSum(3, iRow).Value = strBuff 'tone/NAC
                    grdSum(4, iRow).Value = "0001"
                    grdSum(5, iRow).Value = strRecLog(intRow, 12) 'rssi
                    grdSum(6, iRow).Value = strDur 'dur
                    grdSum(7, iRow).Value = strSys 'system
                    grdSum(8, iRow).Value = strGroup 'group
                    If AutoscrollToolStripMenuItem.Checked Then
                        .FirstDisplayedScrollingRowIndex = iRow
                    End If
                End With
            End If
        End With

        If Not blnTrunk Then
            strBuff = CStr(3)
        Else
            strBuff = CStr(6)
        End If


        'Finally, update the traditional log
        With grdLog


            iRow = intRow - 1

            If iRow >= .Rows.Count Then
                .Rows.Add()
                ' iRow = intRow - 1
            End If

            If UCase(strNAC) <> "NONE" And strNAC <> "" Then
                strBuff = strNAC
            Else
                strBuff = strTone
            End If
            grdLog(0, iRow).Value = Format(iRow, "#00000") 'counter
            grdLog(1, iRow).Value = strChan 'tag
            grdLog(2, iRow).Value = strFreq 'freq
            grdLog(3, iRow).Value = strBuff 'tone/NAC
            grdLog(4, iRow).Value = strRecLog(intRow, 12) 'rssi
            grdLog(5, iRow).Value = strTime 'time
            grdLog(6, iRow).Value = strDur 'dur
            grdLog(7, iRow).Value = strSys 'system
            grdLog(8, iRow).Value = strGroup 'group
            grdLog(9, iRow).Value = sUID
            grdLog(10, iRow).Value = sRecName 'filename

            If AutoscrollToolStripMenuItem.Checked Then
                .FirstDisplayedScrollingRowIndex = iRow
            End If
        End With

    End Sub


    Private Sub cmdRefresh_Click()
        Call DrawDisplayLog()
    End Sub


    Public Sub mnuLogClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLogClear.Click
        Dim Response As String
        Response = CStr(MsgBox("Are you sure you want to clear the log?", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Clear log?"))
        If Response = "1" Then
            Call frmCtlSetup.ClearLog()
            ReDim RadioID(1, 7)


        End If
    End Sub

    Public Sub mnuLogExport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLogExport.Click
        On Error GoTo criticerror
        Dim intMaxRow, intRow, intCol, intMaxCol As Integer
        Dim strBuff As String
        Dim blnFileOpen As Boolean
        Dim strFilename As String
        Dim Response As Integer
        strFilename = Nothing
        'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        With SaveFileDialog1
            'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            .Filter = "CSV File (*.csv)|*.csv| All Files (*.*)|*.*"
            .DefaultExt = "CSV"
            .FilterIndex = 1
            .Title = "Save As..."

            .ShowDialog()

            '-- Did the user select a file name?
            If .FileName = "" Then
                MsgBox("Please enter a file name")
            Else
                '-- Put some code here to save the file
                strFilename = .FileName
            End If
        End With
        If strFilename = "" Or strFilename = "*.CSV" Then Exit Sub
        Dim FF As Integer

criticerror:

    End Sub


    Private Sub SaveFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        'Exports grid contents as CSV
        If Not blnDebug Then On Error GoTo criticerror
        Dim intMaxRow, intRow, intCol, intMaxCol As Integer
        Dim strBuff As String
        Dim blnFileOpen As Boolean
        Dim strFilename As String
        Dim Response As Integer
        strFilename = SaveFileDialog1.FileName
        FileOpen(1, strFilename, OpenMode.Output)
        blnFileOpen = True
        If Me.tabLog.SelectedIndex = 0 Then 'save the linear grid log
            For intRow = 0 To grdLog.RowCount - 1
                strBuff = Nothing
                For intCol = 0 To grdLog.ColumnCount - 1
                    strBuff &= grdLog(intCol, intRow).Value
                    If intCol <> (grdLog.ColumnCount - 1) Then strBuff &= ","
                Next intCol
                PrintLine(1, strBuff)
            Next intRow
        ElseIf Me.tabLog.SelectedIndex = 1 Then 'save the review grid log
            For intRow = 0 To grdSum.RowCount - 1
                strBuff = Nothing
                For intCol = 0 To grdSum.ColumnCount - 1
                    strBuff &= grdSum(intCol, intRow).Value
                    If intCol <> (grdSum.ColumnCount - 1) Then strBuff &= ","
                Next intCol
                PrintLine(1, strBuff)
            Next intRow
        ElseIf Me.tabLog.SelectedIndex = 2 Then 'save the radio id log
            For intRow = 0 To grdID.RowCount - 1
                strBuff = Nothing
                For intCol = 0 To grdID.ColumnCount - 1
                    strBuff &= grdID(intCol, intRow).Value
                    If intCol <> (grdID.ColumnCount - 1) Then strBuff &= ","
                Next intCol
                PrintLine(1, strBuff)
            Next intRow
        ElseIf Me.tabLog.SelectedIndex = 3 Then 'save the search grid log
            For intRow = 0 To grdSearch.RowCount - 1
                strBuff = Nothing
                For intCol = 0 To grdSearch.ColumnCount - 1
                    strBuff &= grdSearch(intCol, intRow).Value
                    If intCol <> (grdSearch.ColumnCount - 1) Then strBuff &= ","
                Next intCol
                PrintLine(1, strBuff)
            Next intRow
        End If
        FileClose(1)
        blnFileOpen = False
        Exit Sub
criticerror:
        If Err.Number <> 32755 Then 'if the user didnt click cancel
            MsgBox("An error has occured attempting to save the file. File may be corrupt. Sorry.")
            Call FormWait(0, 10, 0)
        End If
        If blnFileOpen = True Then FileClose(1)
    End Sub
    Sub LogRadioID(ByVal RadID As String, ByVal TGID As String, ByVal Sysname As String, ByVal Groupname As String, ByVal IDName As String)
        'Saves a radio ID to the RadioID variable
        If Not blnDebug Then On Error Resume Next
        RadID = RadID

        'Setup variables
        Dim MaxID, cnt As Integer
        Dim strBuff As String
        Dim IDIndex, DrawLine, FreeIDIndex As Integer
        MaxID = UBound(RadioID)
        IDIndex = -1
        FreeIDIndex = -1
        For cnt = 0 To MaxID
            'Is this a rad ID we have seen before?
            If RadioID(cnt, 1) = RadID And RadioID(cnt, 7) = IDName And IDIndex = -1 Then
                IDIndex = cnt
            End If
            'Just in case it isn't, find a free place in memory for the next one
            If RadioID(cnt, 1) = Nothing And FreeIDIndex = -1 Then
                FreeIDIndex = cnt
                If IDIndex <> -1 Then 'Both if conditions fulfilled, don't need to be in the loop anymore
                    Exit For
                End If
            End If
        Next
        If IDIndex <> -1 Then 'This is an ID we already know about
            'Increment counter by 1
            cnt = Val(RadioID(IDIndex, 5))
            cnt += 1
            RadioID(IDIndex, 5) = CStr(cnt)
            'Redraw the line on the display
            PrintIDLine(IDIndex)
        Else 'This is a new ID, add it to the database
            'Is there enough room or do we need to expand the variable
            If FreeIDIndex = -1 And MaxID <= 32000 Then

                Dim TempID(32762, 7) As String, ArrLen As Long
                ArrLen = RadioID.Length
                System.Array.Copy(RadioID, TempID, ArrLen)
                ReDim RadioID(MaxID + 100, 7)
                FreeIDIndex = MaxID + 1
                System.Array.Copy(TempID, RadioID, ArrLen)
                Erase TempID
            ElseIf FreeIDIndex = -1 Then 'There is no more room for logging IDs
                'Abort, no one will ever have 32,000 radio IDs
                Exit Sub
            End If
            'Finally, setup the radio logging variable
            IDIndex = FreeIDIndex
            RadioID(IDIndex, 1) = RadID
            RadioID(IDIndex, 2) = TGID
            RadioID(IDIndex, 3) = Sysname
            RadioID(IDIndex, 4) = Groupname
            RadioID(IDIndex, 5) = "0001" 'Count
            RadioID(IDIndex, 6) = grdID.RowCount
            RadioID(IDIndex, 7) = IDName
            grdID.RowCount += 1

            PrintIDLine(IDIndex)
        End If
        If IDIndex = 5 Then
            IDIndex = 5
        End If
    End Sub
    Sub PrintIDLog()
        'Prints the Radio ID Log
        If Not blnDebug Then On Error Resume Next
        Dim strBuff As String, cnt As Integer
        Dim MaxID As String, NumLines As Integer
        Dim LineNum As Integer = 0
        'Sort the array

        'Yeah right

        'Print the array
        MaxID = UBound(RadioID)
        For cnt = 0 To MaxID
            If RadioID(cnt, 1) <> Nothing Then
                NumLines += 1
            End If
        Next
        'grdID.Rows.Clear()
        grdID.RowCount = NumLines
        grdID.SuspendLayout()
        For cnt = 0 To MaxID
            If RadioID(cnt, 1) <> Nothing Then
                RadioID(cnt, 6) = CStr(LineNum)
                PrintIDLine(LineNum)
                LineNum += 1

            End If
        Next
        grdID.ResumeLayout()
    End Sub
    Sub PrintIDLine(ByVal IDIndex As Integer)
        'Prints one line of the ID to the log
        If Not blnDebug Then On Error Resume Next
        Dim LineNum As Integer, blnUpdate As Boolean = False

        'update an existing line
        For LineNum = 0 To grdID.RowCount - 1
            If grdID(0, LineNum).Value = RadioID(IDIndex, 1) And grdID(1, LineNum).Value = RadioID(IDIndex, 2) Then
                blnUpdate = True
                Exit For
            End If
        Next
        If blnUpdate = False Then 'add a new line
            LineNum = Val(RadioID(IDIndex, 6))
        End If
        grdID(0, LineNum).Value = RadioID(IDIndex, 1) 'radio id
        grdID(1, LineNum).Value = RadioID(IDIndex, 2) 'TGID
        grdID(2, LineNum).Value = RadioID(IDIndex, 7) 'alpha tag
        grdID(3, LineNum).Value = RadioID(IDIndex, 3) & " / " & RadioID(IDIndex, 4)
        grdID(4, LineNum).Value = Format(Val(RadioID(IDIndex, 5)), "#0000")
    End Sub

    Private Sub CopyToClipboardToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyToClipboardToolStripMenuItem.Click
        If Not blnDebug Then On Error GoTo criticerror
        Dim intMaxRow, intRow, intCol, intMaxCol As Integer
        Dim strBuff As String
        Dim blnFileOpen As Boolean
        Dim strFilename As String
        Dim Response As Integer
        Dim strClip As String = Nothing
        Dim MyGrid As DataGridView
        MyGrid = grdID
        If Me.tabLog.SelectedIndex = 0 Then
            MyGrid = grdLog
        ElseIf Me.tabLog.SelectedIndex = 1 Then 'save the other one
            MyGrid = grdSum
        ElseIf Me.tabLog.SelectedIndex = 2 Then 'save the radio id log
            MyGrid = grdID
        End If
        For intRow = 0 To MyGrid.RowCount - 1
            strBuff = Nothing

            For intCol = 0 To MyGrid.ColumnCount - 1
                strBuff &= MyGrid(intCol, intRow).Value
                If intCol <> (MyGrid.ColumnCount - 1) Then strBuff &= Chr(9)
            Next intCol
            strClip &= strBuff & vbCrLf
        Next intRow
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(strClip)
        Exit Sub
criticerror:
        If Err.Number <> 32755 Then 'if the user didnt click cancel
            MsgBox("An error has occured attempting to copy. Sorry.")
            Call FormWait(0, 10, 0)
        End If
    End Sub

    Private Sub frmLog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LoadLogData()
    End Sub
    Sub LoadLogData()
        'Loads all the data from memory into the log
        If bLoadLogThreadBusy Then Exit Sub

        Try
            If intLogPos > 500 Then
                grdLog.Visible = False
                grdSum.Visible = False
            End If

            Me.UseWaitCursor = True
            grdLog.RowCount = 0
            My.Application.DoEvents()
            grdLog.SuspendLayout()
            grdSum.SuspendLayout()
            bLoadLogThreadBusy = True
            Dim cnt As Integer = 0
            For cnt = 1 To intLogPos
                DrawGridRow(cnt)
            Next
            grdLog.ResumeLayout()
            grdSum.ResumeLayout()
            grdLog.Visible = True
            grdSum.Visible = True

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Error creating log. " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Me.UseWaitCursor = False

    End Sub

    Private Sub PlaybackFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaybackFileToolStripMenuItem.Click
        'Plays back a file(s) selected
        sPList = BuildSelArray()
        Dim t As New System.Threading.Thread(AddressOf Playback)
        t.Start()
    End Sub
    Function BuildSelArray() As String()
        'Build a string array
        'of recorded files selected in the grid
        If Not blnDebug Then On Error Resume Next
        Dim sPlayList() As String
        Dim iFileNum As Integer = 0
        Dim iNumFile As Integer = 0
        Dim intRowSelCount, intCnt As Integer
        Dim iPlaylist() As Integer
        Dim iRow As Integer = 0
        Dim FName As String
        Dim GrdName As DataGridView

        'Determine which grid we clicked on
        If grdLog.Focused Then
            GrdName = grdLog
        Else
            GrdName = grdSearch


        End If
        'First, build a play back list of all the files selected
        intRowSelCount = GrdName.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If intRowSelCount = 0 Then
            ReDim sPlayList(0)
            BuildSelArray = sPlayList
            Exit Function
        End If

        'build an array of all selected rows
        ReDim sPlayList(intRowSelCount - 1)
        ReDim iPlaylist(intRowSelCount - 1)
        For intCnt = 0 To intRowSelCount - 1
            'Store the index
            iPlaylist(intCnt) = Val(GrdName.SelectedRows(intCnt).Index.ToString)
        Next intCnt
        'Sort the index
        Array.Sort(iPlaylist)
        'NEED to compensate for the way the grid organizes selected rows
        'Sometimes its up, sometimes its down, this makes sure that
        'playback always plays down
        For intCnt = 0 To intRowSelCount - 1
            'store the file names
            FName = GrdName(10, iPlaylist(intCnt)).Value
            If FName <> "" And FileExists(FName) Then
                sPlayList(iRow) = FName
                iRow += 1
            End If
        Next intCnt
        BuildSelArray = sPlayList

    End Function
    Sub PrePlayback(ByVal iRow As Integer)
        Dim sFile As String

        Dim sPlayList(0) As String
        If grdLog.Visible Then
            sFile = grdLog(10, iRow).Value
        Else
            sFile = grdSearch(10, iRow).Value
        End If
        Dim t As New System.Threading.Thread(AddressOf Playback)
        If FileExists(sFile) And sFile <> Nothing Then
            sPlayList(0) = sFile
            sPList = sPlayList
            t.Start()
        End If

    End Sub

    Private Function CreateInputStream(ByRef fileName As String) As WaveStream
        Dim inputStream As WaveChannel32
        Dim fReader As WaveStream
        If fileName.EndsWith(".aiff") Then
            fReader = New AiffFileReader(fileName)
        ElseIf fileName.EndsWith(".mp3") Then
            fReader = New Mp3FileReader(fileName)
        Else
            Throw New InvalidOperationException("Invalid file extension")
        End If
        inputStream = New WaveChannel32(fReader)
        Return inputStream
    End Function


    Sub Playback()

        Dim sPlayList() As String = sPList
        Dim iNumFile As Integer = UBound(sPlayList)
        Dim iFileNum As Integer
        Dim sFile As String
        Dim ShortName As String = Nothing
        Dim iFileLen As Single
        Dim iFilePos As Single
        Dim sPlayPos As String
        bAbortPlayback = False

        Try

            For iFileNum = 0 To iNumFile Step 1 'Play backwards since the grid generates row indexes backwards
                'This is just for safety, should the play list be rewritten half way during playback
                If UBound(sPlayList) >= iFileNum Then
                    sFile = sPlayList(iFileNum)
                Else
                    Exit Sub
                End If

                If FileExists(sFile) And sFile <> Nothing Then
                    ShortName = sFile
                    ShortName = StripName(ShortName)
                    StatusStrip.Items.Item(0).Text = "Playing " & CStr(iFileNum + 1) & "/" & CStr(iNumFile + 1) & " " & ShortName

                    My.Application.DoEvents()

                    bAbortPlayback = False
                    'begin playing back the file\
                    mainOutputStream = CreateInputStream(sFile)
                    waveoutDevice.Init(mainOutputStream)
                    waveoutDevice.Play()
                End If
                sPlayBackCmd = Nothing


                Do Until mainOutputStream.Position > mainOutputStream.Length Or waveoutDevice.PlaybackState = PlaybackState.Stopped
                    If waveoutDevice.PlaybackState <> PlaybackState.Playing And sPlayBackCmd = "PLAY" Then
                        waveoutDevice.Play()
                    ElseIf sPlayBackCmd = "PAUSE" And waveoutDevice.PlaybackState = PlaybackState.Playing Then
                        waveoutDevice.Pause()
                        sPlayBackCmd = Nothing
                    ElseIf sPlayBackCmd = "PAUSE" And waveoutDevice.PlaybackState = PlaybackState.Paused Then
                        waveoutDevice.Play()
                        sPlayBackCmd = Nothing
                    ElseIf sPlayBackCmd = "REWIND" And mainOutputStream.CanSeek Then
                        mainOutputStream.Seek(0, SeekOrigin.Begin)
                        sPlayBackCmd = Nothing
                    ElseIf sPlayBackCmd = "FORWARD" And mainOutputStream.CanSeek Then
                        mainOutputStream.Seek(0, SeekOrigin.End)
                        waveoutDevice.Stop()

                        sPlayBackCmd = Nothing
                    ElseIf sPlayBackCmd = "STOP" Then
                        waveoutDevice.Stop()

                    End If

                    System.Threading.Thread.Sleep(100)
                Loop
                mainOutputStream.Close()
                sPlayBackCmd = Nothing
                '      End If
                'sPlayBackCmd = Nothing
                '      iFilePos = (Int(av1.CurrentPosition * 10)) / 10
                'sPlayPos = Format(iFilePos, "###0.0") & "/" & Format(iFileLen, "###0.0") & "   "
                'StatusStrip.Items.Item(0).Text = sPlayPos & ShortName & Chr(32) & "(" & CStr(iFileNum + 1) & " of " & CStr(iNumFile + 1) & ")"
                'My.Application.DoEvents()
                ' If bAbortPlayback Then
                'av1.Stop()
                StatusStrip.Items.Item(0).Text = Nothing
                'bAbortPlayback = False
                ' If Not av1.Disposed Then av1.Dispose()
                'sPList = Nothing
                'Exit Sub
                ''End If
                'If av1.CurrentPosition = av1.Duration Then av1.Dispose()
                ''                        System.Threading.Thread.Sleep(100)
                ' Loop
                '
                '                End If
                '
                '  If Not IsNothing(av1) Then
                '      av1.Dispose()
                '      av1 = Nothing
                '  End If

                If bAbortPlayback Then
                    bAbortPlayback = False
                    Exit For
                End If
            Next
            StatusStrip.Items.Item(0).Text = Nothing
            sPList = Nothing

            Exit Sub
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            sPList = Nothing


            If blnDebug Then
                MsgBox("frmlog:Playback: " & ex.Message)
            End If
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bAbortPlayback = True
    End Sub

    Private Sub StatusStrip_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles StatusStrip.DoubleClick
        bAbortPlayback = True
    End Sub


    Private Sub grdLog_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLog.DoubleClick
        Call PrePlayback(grdLog.CurrentCell.RowIndex)
    End Sub

    Private Sub DeleteSelectedFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedFilesToolStripMenuItem.Click
        'Deletes files
        Dim cnt As Integer
        Dim iResponse As Integer
        Dim KillList() As String
        '1.5 second delay incase the user is having a spaz
        System.Threading.Thread.Sleep(1000)
        iResponse = MsgBox("Are you sure you want to delete the selected recordings?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + vbDefaultButton2, "Delete recording?")
        Select Case iResponse
            Case 6 'Yes?
                Try
                    KillList = BuildSelArray()
                    For cnt = 0 To UBound(KillList)
                        If FileExists(KillList(cnt)) Then
                            FileSystem.Kill(KillList(cnt))
                            StatusStrip.Items.Item(0).Text = "Killing " & StripName(KillList(cnt))
                            My.Application.DoEvents()
                            System.Threading.Thread.Sleep(50)
                        End If
                    Next
                    'StatusStrip.Items.Item(0).Text = Nothing
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case Else

        End Select

    End Sub

    Private Sub CopyToIsolationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToIsolationToolStripMenuItem.Click
        'Copied files to isolation directory
        Dim sFilelist() As String
        Dim Cnt As Integer = 0
        Dim sTargetDir As String
        Dim SourceFile As String
        Dim DestFile As String
        sTargetDir = frmRecord.RecDirName & sIsolationDir

        'Generate list of files that need to be made
        sFilelist = BuildSelArray()
        If Not IsArray(sFilelist) Then Exit Sub

        'Verify the dest directory exists
        If Not Directory.Exists(sTargetDir) Then
            'make it
            Try
                Directory.CreateDirectory(sTargetDir)
            Catch ex As Exception
                MsgBox("Error, unable to create isolation directory " & sTargetDir, vbCritical)
                Exit Sub
            End Try
        End If

        'Begin copying files
        Try
            StatusStrip.Items.Item(0).Text = "Copying..."
            For Cnt = 0 To UBound(sFilelist)
                SourceFile = sFilelist(Cnt)
                DestFile = sTargetDir & "\" & StripName(sFilelist(Cnt))
                If FileExists(SourceFile) Then
                    File.Copy(SourceFile, DestFile, True)
                End If
                StatusStrip.Items.Item(0).Text = "Finished copying files"
            Next
        Catch ex As Exception
            MsgBox("Error, unable to complete file copy operation. " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub AutoscrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoscrollToolStripMenuItem.Click
        If AutoscrollToolStripMenuItem.Checked Then
            AutoscrollToolStripMenuItem.Checked = False
        Else
            AutoscrollToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub TSPrg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        bAbortPlayback = True
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'Searches all log data for strings, and displays them on the grid
        Dim sSearchString As String = txtSearch.Text
        Dim iFoundAry(MaxSearchResult) As Integer
        Dim cnt As Integer = 0
        Dim iNumFound As Integer = -1
        Dim blnMatch As Boolean = False
        If Len(sSearchString) = 0 Then Exit Sub

        'Begin searching the log data for our string
        With grdSearch
            Try
                .Visible = False
                .RowCount = 0
                For cnt = 1 To intLogPos
                    blnMatch = False
                    If InStr(strRecLog(cnt, 5), sSearchString, CompareMethod.Text) <> 0 And Len(strRecLog(cnt, 5)) <> 0 Then 'sys name
                        blnMatch = True 'system name
                    ElseIf InStr(strRecLog(cnt, 6), sSearchString, CompareMethod.Text) <> 0 And Len(strRecLog(cnt, 6)) <> 0 Then
                        blnMatch = True 'group name
                    ElseIf InStr(strRecLog(cnt, 7), sSearchString, CompareMethod.Text) <> 0 And Len(strRecLog(cnt, 7)) <> 0 Then
                        blnMatch = True 'channel name
                    ElseIf InStr(strRecLog(cnt, 1), sSearchString, CompareMethod.Text) <> 0 And Len(strRecLog(cnt, 1)) <> 0 Then
                        blnMatch = True 'channel
                    ElseIf InStr(strRecLog(cnt, 13), sSearchString, CompareMethod.Text) <> 0 And Len(strRecLog(cnt, 13)) <> 0 Then
                        blnMatch = True 'nac
                    ElseIf InStr(strRecLog(cnt, 14), sSearchString, CompareMethod.Text) <> 0 And Len(strRecLog(cnt, 14)) <> 0 Then
                        blnMatch = True 'uid
                    ElseIf InStr(strRecLog(cnt, 15), sSearchString, CompareMethod.Text) <> 0 And Len(strRecLog(cnt, 15)) <> 0 Then
                        blnMatch = True 'filename
                    ElseIf InStr(strRecLog(cnt, 9), sSearchString, CompareMethod.Text) <> 0 And Len(strRecLog(cnt, 9)) <> 0 Then
                        blnMatch = True 'date
                    ElseIf InStr(strRecLog(cnt, 8), sSearchString, CompareMethod.Text) <> 0 And Len(strRecLog(cnt, 8)) <> 0 Then
                        blnMatch = True 'time
                    End If

                    If blnMatch Then
                        iNumFound += 1
                        iFoundAry(iNumFound) = cnt
                    End If
                    If iNumFound = MaxSearchResult Then
                        Exit For
                    End If
                Next

                'Now that an array of found results is available, display it
                For cnt = 0 To iNumFound

                    DrawSearchGridRow(iFoundAry(cnt))
                Next
                grdSearch.Visible = True
                If iNumFound = -1 Then
                    grdSearch.RowCount = 0
                    '   MsgBox("No results found", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End With
    End Sub
    Sub DrawSearchGridRow(ByVal introw As Integer)
        If blnDebug = False Then On Error Resume Next
        Dim strChan, strSys, strBuff, strGroup, strTone As String
        Dim strHuh, strFreq, strTime, strDur, strNAC As String
        Dim lngSysKey As Integer, iNumHits As Integer = 0, iRow As Integer = 0
        Dim lngNodeCount, lngGrpKey, lngChnKey, lngCnt, iMaxRow As Integer
        Dim lAvgRSSI As Long = 0
        Dim blnObj As Boolean, bNewChan As Boolean
        Dim blnTrunk As Boolean
        Dim lngSumSysKey As Integer
        Dim dteStartTime As TimeSpan
        Dim dteRunTime As TimeSpan, dteAcuTime As Date
        Dim sUID, sRecName As String
        strNAC = Nothing
        strBuff = strRecLog(introw, 1)
        If IsNumeric(strBuff) = True And Len(strBuff) = 8 Then 'convert to MHZ

            If frmCtlSetup.BaseStation(strMDL) = False And InStr(strBuff, ".") = 0 Then
                strBuff = CStr(Val(strBuff) / 10000)
            End If

            strBuff = FormatFreq(Val(strBuff))
            strRecLog(introw, 1) = strBuff
        End If

        If InStr(strRecLog(introw, 1), ".") <> 0 Then 'convetional system
            blnTrunk = False
        Else
            blnTrunk = True
        End If

        ' lngNodeCount = tvwLin.NodeCount
        strSys = strRecLog(introw, 5) 'system name
        strGroup = strRecLog(introw, 6) 'group name
        strChan = strRecLog(introw, 7) 'channel name
        strTone = CTCSS(Val(strRecLog(introw, 4))) 'tone
        strFreq = strBuff 'tgid/freq
        strTime = strRecLog(introw, 8) 'initial time
        strHuh = strRecLog(introw, 9) 'date
        strDur = strRecLog(introw, 10) 'duration
        strNAC = strRecLog(introw, 13) 'NAC
        sUID = strRecLog(introw, 14) 'uid
        sRecName = strRecLog(introw, 15) 'recorded file name
        'does the system already exist
        blnObj = False 'assum it does and a new obj not req
        If Not blnTrunk Then
            strBuff = CStr(3)
        Else
            strBuff = CStr(6)
        End If

        With grdSearch
            iRow = .Rows.Count
            .Rows.Add()
            If UCase(strNAC) <> "NONE" And strNAC <> "" Then
                strBuff = strNAC
            Else
                strBuff = strTone
            End If
            grdSearch(0, iRow).Value = Format(introw - 1, "#00000") 'counter
            grdSearch(1, iRow).Value = strChan 'tag
            grdSearch(2, iRow).Value = strFreq 'freq
            grdSearch(3, iRow).Value = strBuff 'tone/NAC
            grdSearch(4, iRow).Value = strRecLog(introw, 12) 'rssi
            grdSearch(5, iRow).Value = strTime 'time
            grdSearch(6, iRow).Value = strDur 'dur
            grdSearch(7, iRow).Value = strSys 'system
            grdSearch(8, iRow).Value = strGroup 'group
            grdSearch(9, iRow).Value = sUID
            grdSearch(10, iRow).Value = sRecName

            If AutoscrollToolStripMenuItem.Checked Then
                .FirstDisplayedScrollingRowIndex = iRow
            End If

        End With
    End Sub



    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            Call cmdSearch_Click(Nothing, Nothing)
        End If
    End Sub



    Private Sub grdSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdSearch.DoubleClick
        Call PrePlayback(grdSearch.CurrentCell.RowIndex)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'Saves the log file to disk
        On Error GoTo criticerror
        Dim intMaxRow, intRow, intCol, intMaxCol As Integer
        Dim strBuff As String
        Dim blnFileOpen As Boolean
        Dim strFilename As String
        Dim Response As Integer
        strFilename = Nothing
        With SaveFileDialog2
            .Filter = "FreeSCAN Log File (*.fslog)|*.fslog| All Files (*.*)|*.*"
            .DefaultExt = "fslog"
            .FilterIndex = 1
            .Title = "Save Log File..."
            .ShowDialog()
        End With


criticerror:
    End Sub

    Sub SaveFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog2.FileOk
        'Saves the entire logging variable to disk

        If Not blnDebug Then On Error GoTo criticerror
        Dim intMaxRow, intRow, intCol, intMaxCol As Integer
        Dim blnFileOpen As Boolean
        Dim strFilename As String
        Dim Response As Integer
        Dim strBuff As String = Nothing
        'Get the wanted file name
        strFilename = SaveFileDialog2.FileName
        'Save it
        sLogFileName = strFilename
        sLogFileDir = strFilename
        'Remember the directory, autosave will go into this dir
        sLogFileDir = StripFileName(sLogFileDir)
        'If FileExists(sLogFileDir) Then
        SaveSetting("FreeSCAN", "Settings", "LogFileDir", sLogFileDir)
        'End If
        FileOpen(1, strFilename, OpenMode.Output)

        'Update caption
        Me.Text = sDefaultCaption & StripName(strFilename)


        blnFileOpen = True
        'Dump the output variable
        PrintLine(1, sFileHeader)
        PrintLine(1, DateTime.Now)
        For intRow = 1 To intLogPos
            strBuff = Nothing
            For intCol = 0 To MaxRecLogFields
                strBuff &= strRecLog(intRow, intCol)
                If intCol <> MaxRecLogFields Then strBuff &= ","
            Next intCol
            PrintLine(1, strBuff)
        Next intRow

        FileClose(1)
        blnFileOpen = False
        Exit Sub
criticerror:
        If Err.Number <> 32755 Then 'if the user didnt click cancel
            MsgBox("An error has occured attempting to save the file. File may be corrupt. Sorry.")
        End If
        If blnFileOpen = True Then FileClose(1)
    End Sub

    Sub OpenLogFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenLogFileDialog1.FileOk
        'Loads a log file from disk and into memory
        If Not blnDebug Then On Error GoTo criticerror
        Dim intMaxRow, intRow, intCol, intMaxCol As Integer
        Dim strFilename As String
        Dim Response As Integer
        Dim sFileReader As String
        Dim sLineArray() As String
        Dim sFieldArray() As String
        Dim strBuff As String = Nothing
        strFilename = OpenLogFileDialog1.FileName
        'abort if file is not valid
        If Not FileExists(strFilename) Then
            Exit Sub
        End If

        sFileReader = My.Computer.FileSystem.ReadAllText(strFilename, System.Text.Encoding.UTF8)

        sLogFileName = strFilename
        SaveFileDialog2.FileName = strFilename
        sLogFileDir = strFilename
        sLogFileDir = StripFileName(sLogFileDir)
        Me.Text = sDefaultCaption & StripName(strFilename)

        sLineArray = Split(sFileReader, Chr(13))
        intMaxRow = UBound(sLineArray)

        If intMaxRow < 3 Then
            Exit Sub
        End If
        If Len(sLineArray(intMaxRow)) < MaxRecLogFields - 1 Then
            intMaxRow -= 1
        End If
        If sLineArray(0) <> sFileHeader Then
            MsgBox("This file does not appear to be a FreeSCAN log file. Aborting.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'Clear the existing log
        Call frmCtlSetup.ClearLog()
        ReDim RadioID(1, 7)
        ReDim strRecLog(intMaxRow + 198, MaxRecLogFields)
        'This loop starts at 2 since the first two lines are header and date
        For intRow = 2 To intMaxRow
            intLogPos += 1
            sFieldArray = Split(sLineArray(intRow), ",")
            If UBound(sFieldArray) = MaxRecLogFields Then 'Data is ok and can be copied to the main logging variable
                For intCol = 0 To MaxRecLogFields
                    strRecLog(intLogPos, intCol) = sFieldArray(intCol)
                Next
            Else
                intLogPos = 0
                MsgBox("This file appears to be corrupt or not a FreeSCAN log file. As a result, loading has been aborted.", MsgBoxStyle.Exclamation)
                Exit For
            End If
        Next

        If intLogPos > 0 Then
            intLogPos -= 1
        End If
        bLoadLogThreadBusy = False
        LoadLogData()
        Exit Sub
criticerror:
        If Err.Number <> 32755 Then 'if the user didnt click cancel
            MsgBox("An error has occured attempting to load the file. File may be corrupt or impossible to access.")
        End If
    End Sub

    Private Sub mnuLogOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuLogOpen.Click
        With OpenLogFileDialog1
            .Filter = "FreeSCAN Log File (*.fslog)|*.fslog| All Files (*.*)|*.*"
            .DefaultExt = "fslog"
            .FileName = Nothing
            .FilterIndex = 1
            .Title = "Open FreeSCAN Log File..."
            .ShowDialog()
        End With
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            'Saves log file
            If sLogFileName = Nothing Then
                'No log file name created, goto Save As
                Call OpenToolStripMenuItem_Click(Nothing, Nothing)
            Else

                SaveFileDialog2.FileName = sLogFileName
                Call SaveFileDialog2_FileOk(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox("Unable to save file. " & ex.Message)
        End Try
    End Sub

    Private Sub frmLog_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        grdSearch.Update()

    End Sub


    Private Sub grdSum_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSum.CellContentDoubleClick
        'Double click on review grid
        'This routine will enter the tag in the search box and hit search on behalf of the user
        Try
            'search by tag, if nothing then search by tgid/freq
            Dim sSearchText As String = grdSum(1, grdSum.CurrentRow.Index).Value
            If sSearchText = "" Then
                sSearchText = grdSum(2, grdSum.CurrentRow.Index).Value
            End If
            If sSearchText <> "" Then
                txtSearch.Text = sSearchText
                tabLog.SelectedIndex = 3
                Call cmdSearch_Click(Nothing, Nothing)

            End If
        Catch ex As Exception
            Console.WriteLine("grdsum_cellcontentDoubleClick:" & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub SaveClearAtMidnightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveClearAtMidnightToolStripMenuItem.Click
        With SaveClearAtMidnightToolStripMenuItem
            If .Checked Then
                .Checked = False
            Else
                .Checked = True
            End If
        End With
    End Sub



    Private Sub cmdPlayAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlayAudio.Click
        If IsArray(sPList) Then
            sPlayBackCmd = "PLAY"
        Else
            Call PlaybackFileToolStripMenuItem_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub cmdPauseAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPauseAudio.Click
        'Pause audio
        sPlayBackCmd = "PAUSE"
    End Sub

    Private Sub cmdStopAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStopAudio.Click
        bAbortPlayback = True
        sPlayBackCmd = "STOP"
    End Sub

    Private Sub cmdPlayAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlayAll.Click

        'Finds out how many files are playable in the current grid starting 
        'from the cursor position
        'builds a playlist and plays then
        Dim sFile As String = Nothing
        Dim iRow, Row As Integer
        Dim SelGrid As DataGridView
        Dim ArrSize As Integer = -1
        Dim ArrIdx As Integer = 0
        'Find out how big the array needs to be
        'First are there any rows?

        If grdSearch.Visible Then
            SelGrid = grdSearch
        Else
            SelGrid = grdLog
        End If


        If SelGrid.Rows.Count = 0 Then
            Exit Sub
        ElseIf SelGrid.SelectedRows.Count = 0 Then
            iRow = 0
        Else
            iRow = SelGrid.CurrentRow.Index
        End If
        bAbortPlayback = True
        For Row = iRow To SelGrid.Rows.Count - 1
            sFile = SelGrid(10, Row).Value
            If sFile <> Nothing Then
                ArrSize += 1
            End If
            sFile = Nothing
        Next

        If ArrSize = -1 Then
            Exit Sub
        End If

        'Build and populate the array
        Dim sPlayList(ArrSize) As String
        For Row = iRow To SelGrid.Rows.Count - 1
            sFile = SelGrid(10, Row).Value
            If sFile <> Nothing Then
                sPlayList(ArrIdx) = sFile
                ArrIdx += 1
            End If
        Next

        Dim t As New System.Threading.Thread(AddressOf Playback)
        If ArrIdx <> -1 Then
            sPList = sPlayList
            t.Start()
        End If
    End Sub

    Private Sub ToolStripButtonRewind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonRewind.Click
        'Rewind current track
        sPlayBackCmd = "REWIND"
    End Sub

    Private Sub ToolStripButtonFastForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonFastForward.Click
        'Fast forward to end of track
        sPlayBackCmd = "FORWARD"
    End Sub

    Private Sub ShowInExplorerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowInExplorerToolStripMenuItem.Click
        'opens the file in explorer
        Dim sFilelist() As String

        'Generate list of files that need to be made
        sFilelist = BuildSelArray()
        If Not IsArray(sFilelist) Then Exit Sub

        Dim TargetFile As String
        Dim x As Integer
        TargetFile = sFilelist(0)
        x = Shell("explorer /select," & TargetFile, AppWinStyle.NormalFocus)

    End Sub

End Class