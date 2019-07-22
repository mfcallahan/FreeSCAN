Option Strict Off
Option Explicit On
Imports System
Imports System.IO
Imports System.Net
Module Module1
    Public lngChanSys, lngChanGroup As Integer
    Public Const SWP_NOMOVE As Short = 2
    Public blnDebug As Boolean = False
    Public Const SWP_NOSIZE As Short = 1
    Public Const HWND_TOPMOST As Short = -1
    Public Const HWND_NOTOPMOST As Short = -2
    Public Const FLOAT As Short = 1
    Public Const SINK As Short = 0
    Public Declare Sub SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cX As Integer, ByVal cY As Integer, ByVal wFlags As Short)
    Public Const MaxChanCopy As Integer = 2000 'maximum number of channels that can be copied into the buffer
    Public Const strCurrVer As String = ".7BCD996T" 'files without this header are considerd incompatible
    Public Const MaxSystems As Integer = 700
    Public lstArray(MaxSystems, 1) As String
    Public Const MaxGroups As Integer = 277

    Public Const SW_SHOW As Short = 1
    Public Const MaxFavs As Short = 100 'Maximum number of favourites
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Short) As Integer
    Public Const MaxTrunkFreq As Integer = 6000
    Public Const MaxSearchLockout As Integer = 500
    Public Const MaxSetting As Integer = 62 'changing this will destroy compatibility with existing files
    Public Const MaxScannerTrnChan As Short = 500 'maximum number of channels in a trunked group
    Public Const MaxTgidChan As Integer = MaxScannerTrnChan
    Public Const MaxChanSetting As Integer = 30  'Do not change!
    Public Const strProgTitle As String = "FreeSCAN 2.19-beta1"
    Public Const MaxRadioSetting As Integer = 200 'Do not change!
    Public Const BuildNum As Integer = 1052 'set for version 2/19 beta1
    Public Const NumPrefs As Integer = 3
    Public Const APCOMode As String = "AUTO"
    Public Const APCOThreshold As String = "8"
    Public Const MaxRecLogFields As Integer = 15
    Public Const SupportedScanners As String = "SC230, BC246T, UBC3500XLT, UBC800XLT, BR330T, BCD396T, BC346XT, BC346XTC, BCD396XT, BCT15X, BCD996XT, BCT15, BCD996P2, BCD325P2, and BCD996T"
    Public Const RRUSAIndex As Integer = 221
    Public Const RRCANIndex As Integer = 37

    Public strPrefs() As String
    'create variable arrays
    Public StepSize(10, 1) As String 'Step size for searching, Text description)
    Public StepSizeFull(20, 1) As String 'Step size for searching, Text description)
    Public CTCSS(240) As String
    Public strFavs(MaxFavs, 10) As String 'Favourites array
    Public ModMode(10) As String
    'these are used for download systems
    Public intGroupsFound, intSitesFound, intChannelsFound As Single
    Public sngErr As Single
    Public intChnSkip As Integer
    Public blnAbortOp As Boolean
    Public BandSet(30, 1) As String ' current band settings, 0=step direct, 1=modulation direct
    Public BandData(30, 4) As String 'default band settings, 0=low edge, 1=up edge, 2=mode, 3=step, 4=remark
    Public ChosenSysType As Integer
    Public SysType(20, 1) As String
    Public intRestartCount As Integer 'how many times comms restarted on its own in a row
    Public strMcpStep(31) As String ' restep for rebanding numeric direct
    'radioreference stuff
    Public varAuthInfo As New authInfo
    'Build Memory Array
    Public RadioSetting(MaxRadioSetting) As String
    Public intLastChan As Integer
    Public CustSearch(10, 16) As String
    Public varSite(MaxSystems, MaxGroups, 0, MaxSetting) As String 'Site#,group#,unused,setting
    Public ChanInfo(1, MaxChanSetting) As String
    Public intCurrentGroup, intCurrentSys, intCurrentChannel As Integer
    Public strTrunkFreq(MaxTrunkFreq, 10) As String '0=freq,1=LCN,2=ChanID,3=L/O on or off
    Public strCurrFile As String 'current file that is open
    Public blnNoWarn As Boolean
    Public blnFileSaved As Boolean
    Public ChanCopy(1, 1) As String 'buffer for copying/pasting channels
    Public strSysCopy(MaxGroups, MaxSetting) As String 'another part of the clipboard
    Public blnChgSaved As Boolean
    Public SiteType(18, 1) As String
    Public strServiceSearch(25) As String
    Public strSearchLockout(MaxSearchLockout) As String
    Public strSS(15, 8) As String 'service search
    Public strSSXT(15, 8) As String 'service search extension variable
    Public ChanDup() As Integer
    Public ChanShadow(1, MaxChanSetting) As String
    Public strCurOp As String 'current operation being done by d/l or u/l routine
    Public intIOState(1) As Integer 'used for IO graphic function
    Public DownloadCarefully As Boolean = True
    Public CBPData(9) As String ' Custom Band Plan data for custom search
    'Virtual control variables
    Public strLog As String
    Public strDisplay(60) As String
    Public strRxSta(20) As String
    Public strUserCMD As String
    Public strMDL As String
    Public blnRmtCtlMode As Boolean
    Public strRecLog(100, MaxRecLogFields) As String 'normal 15,Log Number
    Public intLogPos As Integer 'What was the last position in the logging array that was used
    Public blnEnableLog As Boolean
    Public strCommchar As String 'rx string for sendcmd
    Public blnSendBusy As Boolean
    Public varState(67, 1) As String 'State list, 0=SHor desc, 1=Long Desc
    Public strSysname As String 'used to pass on info from new system dialogue box to subroutine
    Public intErrors As Integer 'count how many errors in a row sendCMD had
    Public strIFEX() As String 'Global IF Exchange list
    Public ScannerModel As String = Nothing ' Used for virtual control
    Public strNameSPace As String
    Public MaxChan As Integer
    Public UseCdnBias As Boolean = GetSetting("FreeSCAN", "Settings", "Canadian", "0")
    Public RRCDMode As Boolean = False ' Is the RR CD being accessed?\
    Public SkipTag(1, 3) As String 'Skip tag list, 0=Tag Alpha, 1=Tag on/off,2=Tag RR ID, 3=RSV
    Public GliDX(25, 1) As String 'Global list of system TGID lockouts 0=sysid 1=TGID
    Public LastWavMade As String = Nothing 'The last wave file written to disk by the recorder
    Function FindFreeQK() As Integer
        'finds an unused groups QK
        Dim intGrp, intQK As Integer
        Dim blnFound As Boolean
        Dim intQKFound, intSite As Integer
        If blnDebug = False Then On Error Resume Next
        For intQK = 0 To 99
            blnFound = True
            'search for site, then groups within those sites for an unused quick key
            For intSite = 1 To MaxSystems
                If varSite(intSite, 0, 0, 3) = "1" Then 'check this conv system
                    If Val(varSite(intSite, 0, 0, 4)) = intQK And varSite(intSite, 0, 0, 4) <> "." Then
                        blnFound = False
                        intSite = MaxSystems
                    End If
                ElseIf Val(varSite(intSite, 0, 0, 3)) > 1 Then  'search trunked site
                    For intGrp = 1 To MaxGroups
                        If varSite(intSite, intGrp, 0, 5) = "3" Then 'this is a trunked site ,check the QK
                            If Val(varSite(intSite, intGrp, 0, 2)) = intQK And varSite(intSite, intGrp, 0, 2) <> "." Then
                                blnFound = False
                                intGrp = MaxGroups
                                intSite = MaxSystems
                            End If
                        End If
                    Next intGrp
                End If
            Next intSite
            If blnFound = True Then
                intQKFound = intQK
                intQK = 99
            End If
        Next intQK
        If blnFound = True Then

            FindFreeQK = intQKFound
        Else

            FindFreeQK = "."
        End If
    End Function
    Sub LetCMDFinish()
        Dim intVal As Single
        Do Until strUserCMD = "" Or intVal = 300000
            intVal = intVal + 1
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Function SafeUBound(ByVal oObject As Object) As Integer
        'This function safely checks the upper boundary without crashing on NULL object
        If IsNothing(oObject) Then
            SafeUBound = -1
            Exit Function
        Else
            SafeUBound = UBound(oObject)
        End If
    End Function
    Sub IOGraphic(ByRef strMode As String)
        Dim intState As Integer
        'select which IO graphic to display

        Select Case strMode
            Case "" 'no activety,
                intState = 0
            Case "A" 'active, are we downllading or uploading
                If frmCommsDownload.Visible = True Then
                    If intIOState(0) = 0 Then
                        intState = 1
                    ElseIf intIOState(0) = 1 Then
                        intState = 2
                    ElseIf intIOState(0) = 2 Then
                        intState = 3
                    ElseIf intIOState(0) = 3 Then
                        intState = 0
                    ElseIf intIOState(0) = 4 Then
                        intState = 1
                    End If
                Else 'on the upload state, icons are draw in reverse order
                    If intIOState(0) = 0 Then
                        intState = 3
                    ElseIf intIOState(0) = 3 Then
                        intState = 2
                    ElseIf intIOState(0) = 2 Then
                        intState = 1
                    ElseIf intIOState(0) = 1 Then
                        intState = 0
                    ElseIf intIOState(0) = 4 Then
                        intState = 3
                    End If
                End If
            Case "E" 'error state
                intState = 4
            Case "D" 'done, happy
                intState = 9
            Case "F" 'total fail
                intState = 10

        End Select
        If intState = 9 Then 'HAPPY
            If frmCommsDownload.Visible = True Then
                frmCommsDownload.imgIOState.Image = frmCommsDownload.imgIO(5).Image
            ElseIf Form1.Visible = True Then
                Form1.imgIOState.Image = frmCommsDownload.imgIO(5).Image
            End If
            Exit Sub

        End If
        If intState = 10 Then ' TOTAL FAIL
            If frmCommsDownload.Visible = True Then
                frmCommsDownload.imgIOState.Image = frmCommsDownload.imgIO(6).Image
            ElseIf Form1.Visible = True Then
                Form1.imgIOState.Image = frmCommsDownload.imgIO(6).Image
            End If
            Exit Sub
        End If
        If intIOState(1) = 6 Then 'sets up a delay for the graphic
            If frmCommsDownload.Visible = True Then
                frmCommsDownload.imgIOState.Image = frmCommsDownload.imgIO(intState).Image
            ElseIf Form1.Visible = True Then
                Form1.imgIOState.Image = frmCommsDownload.imgIO(intState).Image
            End If
            intIOState(1) = 0
            intIOState(0) = intState
        ElseIf intIOState(1) < 6 Then
            intIOState(1) = intIOState(1) + 1
        Else
            intIOState(1) = 0
        End If


    End Sub
    Function MakeFixedLen(ByRef strParam As String, ByRef intLen As Integer) As String
        Dim intCnt As Integer
        Dim strBuff As String
        'Buffers a string with spaces to make at least as big as len
        strBuff = ""
        If Len(strParam) < intLen Then

            For intCnt = 1 To intLen - Len(strParam)
                strBuff = strBuff & " "
            Next intCnt
        End If
        MakeFixedLen = strParam & strBuff
    End Function


    Sub ErrorHandler(ByRef intCode As Integer, ByRef strLog As String)
        Dim Response, strMsg As String


        strMsg = "A communications error has occured. Check that you have selected the right COM port, speed, and that no other program is using the port. Error code " & intCode & vbNewLine & "Would you like to copy the contents of the log to the clipboard?"
        If intCode = 57 Then
            strMsg &= "(Port does not exist or is unavailable)"
        ElseIf intCode = 438 Then
            strMsg &= "(General Port Error)"
        End If
        If Form1.msc.IsOpen = True Then Form1.msc.Close()

        Response = MsgBox(strMsg, MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Critical Error")

        Select Case Response
            Case 6 'yes
                My.Computer.Clipboard.Clear()

                My.Computer.Clipboard.SetText((strLog & vbNewLine & intCode))
            Case Else
                'do nothing
        End Select
    End Sub
    Sub FloatWindow(ByRef x As Single, ByRef action As Short)

        ' When called by a form:
        '
        ' If action <> 0 makes the form float (always on top)
        ' If action = 0 "unfloats" the window.

        Dim wFlags As Integer
        wFlags = SWP_NOMOVE Or SWP_NOSIZE

        If action <> 0 Then ' Float
            Call SetWindowPos(x, HWND_TOPMOST, 0, 0, 0, 0, wFlags)
        Else ' Sink
            Call SetWindowPos(x, HWND_NOTOPMOST, 0, 0, 0, 0, wFlags)
        End If

    End Sub


    Function ParaParse(ByRef strCMD As String, ByRef intParam As Integer) As String
        'takes an input like MV2,TESTSYS,.,3,0,0,0,,1,31,-1,51,51,4
        ' and returns the desired field depending on intParam
        Dim strField() As String
        strField = Split(strCMD, ",")
        ParaParse = Nothing

        If intParam - 1 <= UBound(strField) Then
            ParaParse = strField(intParam - 1)
        ElseIf Not blnRmtCtlMode Then
            sngErr += 1
            GenLog((CStr(intParam) & "Out of bounds Unable to parse string " & strCMD))
        End If

    End Function

    Function GetFreeSysNum() As Integer
        'searches memory for a free spot in memory for a new site
        Dim x As Integer

        GetFreeSysNum = -1
        For x = 1 To MaxSystems
            If Val(varSite(x, 0, 0, 3)) = 0 Then

                GetFreeSysNum = x
                x = MaxSystems
            End If
        Next x

    End Function
    Function GetFreeGroupNum(ByRef intSys As Integer) As Integer
        Dim x As Integer

        GetFreeGroupNum = -1
        For x = 1 To MaxGroups

            If Val(varSite(intSys, x, 0, 5)) = 0 Then

                GetFreeGroupNum = x
                x = MaxGroups
            End If
        Next x
    End Function
    Function CheckForNum(ByRef strCheck As String) As Boolean
        'returns true if input is a number, or something?

        CheckForNum = False
        Dim intPos As Integer
        For intPos = 1 To Len(strCheck)

            If IsNumeric(Mid(strCheck, intPos, 1)) = True Then

                CheckForNum = True
            End If
        Next intPos
    End Function
    Public Function FileExists(ByRef Fname As String) As Boolean


        If Fname = "" Or Right(Fname, 1) = "\" Then
            FileExists = False : Exit Function
        End If


        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        FileExists = (Dir(Fname) <> "")

    End Function

    Function IndexSearchStep(ByRef intStep As String) As Integer
        'takes radio input for search step and saves it in a form that
        'is indexed
        Dim intnewstep As Integer
        Dim x As Integer
        For x = 1 To 10
            If Val(Trim(intStep)) = Val(StepSize(x, 1)) Then
                'we found our step, save it
                intnewstep = x
            End If
        Next x
        IndexSearchStep = intnewstep
    End Function


    Public Function CreateGroupID() As String
        'generates a random group id
        Dim x As Integer, GroupID As String
        GroupID = ""
        For x = 1 To 16
            GroupID = GroupID & Chr(Int((90 - 65 + 1) * Rnd()) + 65)
        Next x
        CreateGroupID = GroupID
    End Function
    Function MakeBinary(ByRef strValue As String) As Integer
        'returns a 0 or a 1 depending on input
        If Val(strValue) > 1 Then strValue = "1"
        Select Case Trim(UCase(strValue))
            Case "ON"
                MakeBinary = 1
            Case "TRUE"
                MakeBinary = 1
            Case "LOCKED"
                MakeBinary = 1
            Case "LOCKOUT"
                MakeBinary = 1
            Case "1"
                MakeBinary = 1
            Case "ENABLED"
                MakeBinary = 1
            Case "SEARCH"
                MakeBinary = 1
            Case "AFS"
                MakeBinary = 1
            Case Else
                MakeBinary = 0
        End Select
    End Function
    Function MakeBoolean(ByRef strValue As String) As Boolean
        'returns a 0 or a 1 depending on input

        Select Case Trim(UCase(strValue))
            Case "ON"
                MakeBoolean = True
            Case "TRUE"
                MakeBoolean = True
            Case "LOCKED"
                MakeBoolean = True
            Case "LOCKOUT"
                MakeBoolean = True
            Case "1"
                MakeBoolean = True
            Case "ENABLED"
                MakeBoolean = True
            Case "SEARCH"
                MakeBoolean = True
            Case "AFS"
                MakeBoolean = True
            Case Else
                MakeBoolean = False
        End Select
    End Function
    Function MakeItKosherQK(ByRef strValue As String) As String

        Select Case Trim(UCase(strValue))
            Case "NONE"
                MakeItKosherQK = "."
            Case ""
                MakeItKosherQK = "."
            Case "."
                MakeItKosherQK = "."
            Case Else
                MakeItKosherQK = strValue
        End Select
    End Function
   
    Function FlipIt(ByRef intBit As String) As Integer

        'inverts digit

        If Val(intBit) = 0 Then

            FlipIt = 1
        Else

            FlipIt = 0
        End If
    End Function
    Function ReadChan(ByRef Setting As Integer) As String
        'for compatibility reasons, takes intCurrentChannel
        'and returns data back as if that channel is stored
        'linearly, ie group 5 channel 2 would be #2
        'where as in reality it may be #546
        ReadChan = Nothing
        Dim intFound, intCurrChan As Integer
        Dim blnDone As Boolean
        For intCurrChan = 1 To MaxChan
            'is this one of the channels we're hunting after?
            If varSite(intCurrentSys, intCurrentGroup, 0, 10) = ChanInfo(intCurrChan, 10) Then
                intFound = intFound + 1
                'is it the specific one we are hunting after?
                If intFound = intCurrentChannel Then
                    'then save the data
                    ReadChan = ChanInfo(intCurrChan, Setting)
                    blnDone = True
                    intCurrChan = MaxChan
                End If
            End If
        Next intCurrChan


    End Function
    Sub UpdateTreeSelection()
        On Error Resume Next
        'this subroutine updates the tree to reflect the currently selected
        'group/site
        Dim strKey As String
        Dim child As TreeNode
        Dim baby As TreeNode
        Dim intCnt As Integer
        If intCurrentSys = 0 Then
            Exit Sub
        ElseIf intCurrentGroup = 0 Then
            'select a system
            strKey = "S" & intCurrentSys.ToString("0000")
        Else
            strKey = "S" & intCurrentSys.ToString("0000") & "G" & intCurrentGroup.ToString("0000")
        End If
        For Each child In lblSiteNote.treeSystems.Nodes
            If child.Tag = strKey Then
                lblSiteNote.treeSystems.SelectedNode = child
                'If Not child.IsVisible Then
                lblSiteNote.treeSystems.SelectedNode.ExpandAll()
                'End If
                Exit For
            ElseIf child.Tag = Left(strKey, 5) And child.Nodes.Count > 0 Then
                child.EnsureVisible()
                For intCnt = 0 To child.Nodes.Count

                    If child.Nodes(intCnt).Tag = strKey Then
                        If Not child.Nodes(intCnt).IsVisible Then
                            child.Nodes(intCnt).EnsureVisible()
                        End If
                        lblSiteNote.treeSystems.SelectedNode = child.Nodes(intCnt)
                        Exit For
                    End If
                Next
            End If
        Next

    End Sub

    Function FindChanNum(ByRef intChan As Integer) As Integer

        'Take an array index for ChanInfo
        'and returns a simple channel number
        'as it purtains to the currently selected group
        'opposite of GetRealChanNum
        Dim cnt As Integer
        Dim intSimpChan As Integer

        For cnt = 1 To intChan

            If ChanInfo(cnt, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then
                intSimpChan = intSimpChan + 1
            End If
        Next cnt

        FindChanNum = intSimpChan
    End Function


    Function InsertChan(ByRef GID As String, ByVal blnConv As Boolean) As Integer
        'this function finds a free spot in memory for a channel
        'returns the ChanInfo array index where data should be written to
        Dim x As Integer

        InsertChan = -1
        For x = 1 To MaxChan
            If ChanInfo(x, 10) = "" Then
                'we found out channel
                InsertChan = x
                x = MaxChan
            End If
        Next x

        If InsertChan = -1 Then
            Call ExpandChanArray()
            For x = 1 To MaxChan
                If ChanInfo(x, 10) = "" Then
                    'we found out channel
                    InsertChan = x
                    x = MaxChan
                End If
            Next x
        End If
        Call SetChannelDefault(InsertChan, blnConv, GID)
    End Function
    Sub SetChannelDefault(ByVal intChan As Integer, ByVal blnConv As Boolean, ByVal GID As String)

        If intChan <> -1 And blnConv = True Then
            ChanInfo(intChan, 2) = CStr(0) 'freq
            ChanInfo(intChan, 3) = CStr(0) 'search step=auto
            ChanInfo(intChan, 4) = CStr(0) 'modmode=auto
            ChanInfo(intChan, 5) = CStr(0) 'lockout=off
            ChanInfo(intChan, 6) = CStr(0) 'att =off
            ChanInfo(intChan, 7) = CStr(0) 'pri=off
            ChanInfo(intChan, 8) = CStr(0) 'alert tone type=off
            ChanInfo(intChan, 12) = "0" 'audio type
            ChanInfo(intChan, 9) = "0" 'ctcss search
            ChanInfo(intChan, 13) = "0" ' alert level
            ChanInfo(intChan, 10) = GID
            ChanInfo(intChan, 14) = ""
            ChanInfo(intChan, 15) = "" 'p25 nac status
            ChanInfo(intChan, 16) = "NONE" 'number tag
            ChanInfo(intChan, 17) = "OFF"
            ChanInfo(intChan, 18) = "0"
            ChanInfo(intChan, 19) = "0"
            ChanInfo(intChan, 20) = "0"
        ElseIf intChan <> -1 Then 'set TGID default
            ChanInfo(intChan, 3) = "0" 'lockout
            ChanInfo(intChan, 4) = "0" 'alert tone
            ChanInfo(intChan, 5) = "0" ' alert level
            ChanInfo(intChan, 14) = ""
            ChanInfo(intChan, 10) = GID
            ChanInfo(intChan, 6) = "0" 'audio type
            ChanInfo(intChan, 7) = "1" 'tape out
            ChanInfo(intChan, 8) = "0" 'priority
            ChanInfo(intChan, 19) = "NONE" 'number tag
            ChanInfo(intChan, 20) = "OFF" 'alert colour
            ChanInfo(intChan, 21) = "0" 'alert pattern
            ChanInfo(intChan, 22) = "0" 'vol offset
        End If
    End Sub
    Function InsertChanTop(ByRef GID As String, ByVal blnConv As Boolean) As Integer
        'this function finds a free spot in memory for a channel
        'returns the ChanInfo array index where data should be written to
        'it does it from the top down, so pasted channels always end up
        'in the end
        Dim x, intLastChan As Integer

        InsertChanTop = -1
        intLastChan = 1
        For x = 1 To MaxChan
            If ChanInfo(x, 10) = GID Then
                intLastChan = x
            End If
        Next x
        For x = intLastChan To MaxChan
            If ChanInfo(x, 10) = "" Then
                'we found out channel
                ChanInfo(x, 10) = GID
                InsertChanTop = x

                x = MaxChan
            End If
        Next x

        'if we can't find a logical next place to put the channel, put it anywhere we can

        If InsertChanTop = 6000 Or InsertChanTop = -1 Then
            For x = 1 To MaxChan
                If ChanInfo(x, 10) = "" Then
                    'we found out channel
                    ChanInfo(x, 10) = GID
                    x = MaxChan
                End If
            Next x
        End If

        'still can't find anywhere? expand memory

        If InsertChanTop = -1 Then
            Call ExpandChanArray()
            For x = MaxChan To 1 Step -1
                If ChanInfo(x, 10) = "" Then
                    'we found out channel
                    ChanInfo(x, 10) = GID
                    InsertChanTop = x
                    x = MaxChan
                End If
            Next x
        End If
        Call SetChannelDefault(InsertChanTop, blnConv, GID)
    End Function

    Function StripName(ByRef strFile As String) As String
        'strips a path from a filename
        Dim intCnt As Integer
        intCnt = 1
        Do Until intCnt = 0
            intCnt = instr(strFile, "\")
            If intCnt <> 0 Then
                strFile = Right(strFile, Len(strFile) - intCnt)
            End If
        Loop
        StripName = strFile
    End Function
    Function StripFileName(ByRef strFile As String) As String
        'strips the file name from the path
        Dim intCnt As Integer
        intCnt = Len(strFile)
        Do Until intCnt <= 1

            If OldMid(strFile, intCnt, 1) <> "\" Then
                strFile = Strings.Left(strFile, Len(strFile) - 1)
            Else
                intCnt = 1
            End If
            intCnt -= 1
        Loop
        StripFileName = strFile
    End Function
    Function InsertTrunkFreq(ByRef GID As String) As Integer
        'this function finds a free spot in memory for a channel
        'returns the ChanInfo array index where data should be written to
        Dim x As Integer

        InsertTrunkFreq = -1
        For x = 1 To MaxTrunkFreq

            If strTrunkFreq(x, 2) = "" Then
                'we found out channel
                strTrunkFreq(x, 2) = GID
                strTrunkFreq(x, 3) = "0"
                strTrunkFreq(x, 4) = "NONE" ' number tag
                strTrunkFreq(x, 5) = "0" 'volume offset
                strTrunkFreq(x, 6) = "1" 'record on/off
                InsertTrunkFreq = x
                x = MaxTrunkFreq
            End If
        Next x
    End Function
    ' convert from hexadecimal to decimal

    Function HexToDec(ByRef HexValue As String, Optional ByRef ToInteger As Boolean = False) As Integer
        If ToInteger Then
            ' convert to an integer value, if possible.
            ' Use CInt() if you want to *always* convert to an Integer
            HexToDec = Val("&H" & HexValue)
        Else
            ' always convert to a Long. You can also use the CLng() function.
            HexToDec = Val("&H" & HexValue & "&")
        End If
    End Function
    Function GetRealChan(ByRef intsite As Integer, ByRef intgroup As Integer, ByRef intChan As Integer) As Integer
        'takes a nice channel number and returns the array index
        Dim GroupID As String, x, intFound As Integer


        intFound = 0

        GroupID = varSite(intsite, intgroup, 0, 10)
        For x = 1 To MaxChan
            If ChanInfo(x, 10) = GroupID Then
                intFound = intFound + 1
                If intFound = intChan Then
                    GetRealChan = x
                    x = MaxChan
                End If
            End If
        Next x
    End Function
    Function MakeItKosherModMode(ByRef intMode As String) As String
        'takes user input for mod mode and saves it in a form that
        'return an index 
        Dim intNewMode As String
        Dim x As Integer
        intNewMode = "0"
        For x = 0 To 5
            If Trim(UCase(intMode)) = ModMode(x) Then
                'we found our step, save it
                intNewMode = CStr(x)
            End If
        Next x
        MakeItKosherModMode = intNewMode
    End Function
    Function RevSysTypeLookup(ByRef strSite As String) As Integer
        'takes the three letter code describing the site in
        'and returns an array index back
        Dim intSite, x As Integer
        For x = 0 To 20
            If strSite = SysType(x, 1) Then
                intSite = x
                x = 20
            End If
        Next x
        If strSite = "MOT" Then
            intSite = 3
        End If
        If strSite = "M82C" Then
            intSite = 3
        End If
        If strSite = "M81C" Then
            intSite = 2
        End If
        If intSite = 0 Then
            'assume a motorola type 2 system
            intSite = 3
        End If
        RevSysTypeLookup = intSite
    End Function
    Function RevSiteTypeLookup(ByRef strSite As String) As Integer
        'takes the three letter code describing the site in
        'and returns an array index back
        Dim intSite, x As Integer

        intSite = 2
        For x = 0 To 16
            If strSite = SiteType(x, 1) Then
                intSite = x
                Exit For
            End If
        Next x
        RevSiteTypeLookup = intSite
    End Function
    Function ConvSiteToSys(ByRef strSite As String) As Integer
        'This takes a site type such as MV2
        'and converts it to the appropiate system type code
        'used for importing uasd files
        Select Case strSite
            Case "M82S"
                ConvSiteToSys = 3
            Case "M82P"
                ConvSiteToSys = 3
            Case "M92"
                ConvSiteToSys = 3
            Case "MV2"
                ConvSiteToSys = 3
            Case "MU2"
                ConvSiteToSys = 3
            Case "MP25"
                ConvSiteToSys = 3
            Case "M81S"
                ConvSiteToSys = 2
            Case "M81P"
                ConvSiteToSys = 2
            Case "EDN"
                ConvSiteToSys = 4
            Case "EDW"
                ConvSiteToSys = 4
            Case "EDS"
                ConvSiteToSys = 5
            Case "LTR"
                ConvSiteToSys = 6
            Case "M82C"
                ConvSiteToSys = 3
            Case "M81C"
                ConvSiteToSys = 2
            Case Else '?

                ConvSiteToSys = 3
        End Select
    End Function
    Function MakeItKosherSearchStep(ByRef intStep As String) As String
        'takes user input for search step and saves it in a form that
        'can be transmitted to radio
        Dim intnewstep As Double
        Dim x As Integer
        For x = 1 To 10
            If Trim(intStep) = StepSize(x, 0) Then
                'we found our step, save it

                intnewstep = x
            End If
        Next x

        MakeItKosherSearchStep = intnewstep

    End Function
    Function RevStepLookup(ByRef intStep As String) As String
        'This function looks at a step index taken from the radio (ie 1500)
        'and translates that to a stepsize() array index
        Dim intnewstep As String
        Dim x As Integer
        intnewstep = "0"
        For x = 0 To 10
            If StepSize(x, 1) = intStep Then
                'we found our step, save it
                intnewstep = x
                x = 9
            End If
        Next x
        RevStepLookup = intnewstep
        If intStep = "AUTO" Then RevStepLookup = "0"
    End Function
    Function RevModModeLookup(ByRef strMode As String) As Integer
        'this takes a str modmode eg NFM and converts
        'it into a modmode array index
        Dim intNewMode As Integer
        Dim x As Integer
        intNewMode = 0
        For x = 0 To 9
            If ModMode(x) = strMode Then
                'we found our step, save it
                intNewMode = x
            End If
        Next x
        RevModModeLookup = intNewMode

    End Function
    Function MakeItKosherFrequency(ByRef inputfreq As String) As String
        'check to make sure the range is valid
        Dim dblFreq As Double
        Dim blnBadRange As Boolean
        Dim Response As String
        If Not blnDebug Then On Error Resume Next
        dblFreq = CDbl(Val(inputfreq))
        If dblFreq = 0 Then
            'do nothing
        ElseIf dblFreq < 25 Then
            blnBadRange = True
        ElseIf dblFreq > 512 And dblFreq < 764 Then
            blnBadRange = True
        ElseIf dblFreq > 775.9875 And dblFreq < 794 Then
            blnBadRange = True
        ElseIf dblFreq > 823.9875 And dblFreq < 849.0125 Then
            blnBadRange = True
        ElseIf dblFreq > 868.9875 And dblFreq < 894.0125 Then
            blnBadRange = True
        ElseIf dblFreq > 956 And dblFreq < 1240 Then
            blnBadRange = True
        ElseIf dblFreq > 1300 Then
            blnBadRange = True
        End If
        If blnBadRange = True And lblSiteNote.blnWarnInvalidFreq Then
            Response = CStr(MsgBox("The frequency " & dblFreq & " is out of band. You have been warned.", MsgBoxStyle.OkOnly, "Frequency Range"))
        End If
        If dblFreq < 0 Then dblFreq = 0
        If dblFreq > 1300 Then dblFreq = 1300

        MakeItKosherFrequency = dblFreq
    End Function
    Function MakeItKosherFreqSilent(ByRef inputfreq As String) As String
        'check to make sure the range is valid
        Dim dblFreq As Double


        dblFreq = Val(inputfreq)

        If dblFreq < 0 Then dblFreq = 0
        If dblFreq > 1300 Then dblFreq = 1300

        MakeItKosherFreqSilent = dblFreq
    End Function



    Sub InitCOMPort()
        'loads comport settings from the registry and saved them to memory

        RadioSetting(44) = CStr(Val(GetSetting("FreeSCAN", "Settings", "Port", CStr(1))))
        RadioSetting(45) = CStr(Val(GetSetting("FreeSCAN", "Settings", "PortSpeed", CStr(57600))))

    End Sub
    Function MakeItKosher(ByRef strItem As String) As String
        Dim strKosher, strChar As String
        Dim intCharPos As Integer
        strKosher = Nothing
        'cleans up a name for a group/system so it can be accepted
        'remove/replace evil characters, such as quotations or commas
        For intCharPos = 1 To Len(strItem)

            strChar = Mid(strItem, intCharPos, 1)
            If Asc(strChar) = 34 Then
                'replace with apostophe
                strChar = "'"
            ElseIf Asc(strChar) = 44 Then
                strChar = "." 'no comma allowed
            ElseIf Asc(strChar) <= 31 Or Asc(strChar) >= 127 Then
                'replace with ?
                strChar = "?"
            End If
            strKosher = strKosher & strChar
        Next intCharPos
        strKosher = Left(strKosher, 16)

        MakeItKosher = strKosher
    End Function



    Sub FormWait(ByRef StartProc As Integer, ByRef EndProc As Integer, ByRef Visible As Integer)
        Dim intDone As Integer

        If EndProc = 0 Then EndProc = 1



        intDone = Int((StartProc / EndProc) * 1070)
        Select Case Visible
            Case 1

                frmWaitXP.Pic1.Width = intDone
                frmWaitXP.Visible = True
                System.Windows.Forms.Application.DoEvents()
            Case Else
                frmWaitXP.Visible = False
        End Select
    End Sub
    'start with step size(text description, numerical)
    Function MakeItKosherFileName(ByVal sFileName As String, ByVal AllowSlashes As Boolean) As String
        Dim strKosher, strChar As String
        Dim intCharPos, intLen As Integer
        'cleans up a name so a file directory with the same name can be safely created
        strKosher = Nothing
        intLen = Len(sFileName)
        sFileName = Replace(sFileName, Chr(34), "'")
        sFileName = Replace(sFileName, ",", ".")

        For intCharPos = 1 To intLen
            strChar = Mid(sFileName, intCharPos, 1)
            If Asc(strChar) <= 31 Or Asc(strChar) >= 127 Then
                'replace with nothing
                strChar = Nothing
            End If
            strKosher = strKosher & strChar
        Next intCharPos

        strKosher = Replace(strKosher, "/", "-")
        strKosher = Replace(strKosher, ":", "-")
        strKosher = Replace(strKosher, "$", "_")
        strKosher = Replace(strKosher, "*", "")
        strKosher = Replace(strKosher, "&", "and")
        strKosher = Replace(strKosher, "%", "_")
        strKosher = Replace(strKosher, ";", "_")
        strKosher = Replace(strKosher, Chr(34), "_")
        strKosher = Replace(strKosher, "+", "_")
        strKosher = Replace(strKosher, "?", "")
        strKosher = Replace(strKosher, "<", "")
        strKosher = Replace(strKosher, ">", "")
        strKosher = Replace(strKosher, "|", "")
        If Not AllowSlashes Then
            strKosher = Replace(strKosher, "\", "_")
        End If
        MakeItKosherFileName = Trim(strKosher)
    End Function
    Function MakeItKosherSilent(ByRef strItem As String, ByRef ChopMode As Integer) As String

        Dim strKosher, strChar As String
        Dim intCharPos, intLen As Integer
        'cleans up a name for a group/system so it can be accepted
        strKosher = Nothing
        intLen = Len(strItem)
        strItem = Replace(strItem, Chr(34), "''")
        strItem = Replace(strItem, ",", ".")

        For intCharPos = 1 To intLen
            strChar = Mid(strItem, intCharPos, 1)
            If Asc(strChar) <= 31 Or Asc(strChar) >= 127 Then
                'replace with nothing
                strChar = ""
            End If
            strKosher = strKosher & strChar
        Next intCharPos

        Select Case ChopMode
            Case 2
                'No chop
            Case 0
                'keep the first 16
                strKosher = Left(strKosher, 16)
            Case 1
                'keep the last 16
                strKosher = Right(Trim(strKosher), 16)
            Case 3
                'keep 275 for comments
                strKosher = Left(Trim(strKosher), 275)
        End Select
        'Chopmode select how long string are handled
        'remove/replace evil characters, such as quotations or commas

        MakeItKosherSilent = strKosher
    End Function


    Sub InitVariables()
        StepSize(0, 0) = "AUTO"
        StepSize(0, 1) = "AUTO"
        StepSize(1, 0) = "5k"
        StepSize(1, 1) = 500
        StepSize(2, 0) = "6.25k"
        StepSize(2, 1) = 625
        StepSize(3, 0) = "7.5k"
        StepSize(3, 1) = 750
        StepSize(4, 0) = "10k"
        StepSize(4, 1) = 1000
        StepSize(5, 0) = "12.5k"
        StepSize(5, 1) = 1250
        StepSize(6, 0) = "15k"
        StepSize(6, 1) = 1500
        StepSize(7, 0) = "20k"
        StepSize(7, 1) = 2000
        StepSize(8, 0) = "25k"
        StepSize(8, 1) = 2500
        StepSize(8, 1) = 2500
        StepSize(9, 0) = "50k"
        StepSize(9, 1) = "5000"
        StepSize(10, 0) = "100k"
        StepSize(10, 1) = "10000"

        StepSizeFull(0, 0) = "AUTO"
        StepSizeFull(0, 1) = "AUTO"
        StepSizeFull(1, 0) = "5k"
        StepSizeFull(1, 1) = 500
        StepSizeFull(2, 0) = "6.25k"
        StepSizeFull(2, 1) = 625
        StepSizeFull(3, 0) = "7.5k"
        StepSizeFull(3, 1) = 750
        StepSizeFull(4, 0) = "8.33k"
        StepSizeFull(4, 1) = 833
        StepSizeFull(5, 0) = "10k"
        StepSizeFull(5, 1) = 1000
        StepSizeFull(6, 0) = "12.5k"
        StepSizeFull(6, 1) = 1250
        StepSizeFull(7, 0) = "15k"
        StepSizeFull(7, 1) = 1500
        StepSizeFull(8, 0) = "20k"
        StepSizeFull(8, 1) = 2000
        StepSizeFull(9, 0) = "25k"
        StepSizeFull(9, 1) = 2500
        StepSizeFull(10, 0) = "50k"
        StepSizeFull(10, 1) = 5000
        StepSizeFull(11, 0) = "100k"
        StepSizeFull(11, 1) = "10000"

        'CTCSS Variable
        CTCSS(0) = "None"
        CTCSS(64) = "67.0Hz"
        CTCSS(65) = "69.3Hz"
        CTCSS(66) = "71.9Hz"
        CTCSS(67) = "74.4Hz"
        CTCSS(68) = "77.0Hz"
        CTCSS(69) = "79.7Hz"
        CTCSS(70) = "82.5Hz"
        CTCSS(71) = "85.4Hz"
        CTCSS(72) = "88.5Hz"
        CTCSS(73) = "91.5Hz"
        CTCSS(74) = "94.8Hz"
        CTCSS(75) = "97.4Hz"
        CTCSS(76) = "100.0Hz"
        CTCSS(77) = "103.5Hz"
        CTCSS(78) = "107.2Hz"
        CTCSS(79) = "110.9Hz"
        CTCSS(80) = "114.8Hz"
        CTCSS(81) = "118.8Hz"
        CTCSS(82) = "123.0Hz"
        CTCSS(83) = "127.3Hz"
        CTCSS(84) = "131.8Hz"
        CTCSS(85) = "136.5Hz"
        CTCSS(86) = "141.3Hz"
        CTCSS(87) = "146.2Hz"
        CTCSS(88) = "151.4Hz"
        CTCSS(89) = "156.7Hz"
        CTCSS(90) = "159.8Hz"
        CTCSS(91) = "162.2Hz"
        CTCSS(92) = "165.5Hz"
        CTCSS(93) = "167.9Hz"
        CTCSS(94) = "171.3Hz"
        CTCSS(95) = "173.8Hz"
        CTCSS(96) = "177.3Hz"
        CTCSS(97) = "179.9Hz"
        CTCSS(98) = "183.5Hz"
        CTCSS(99) = "186.2Hz"
        CTCSS(100) = "189.9Hz"
        CTCSS(101) = "192.8Hz"
        CTCSS(102) = "196.6Hz"
        CTCSS(103) = "199.5Hz"
        CTCSS(104) = "203.5Hz"
        CTCSS(105) = "206.5Hz"
        CTCSS(106) = "210.7Hz"
        CTCSS(107) = "218.1Hz"
        CTCSS(108) = "225.7Hz"
        CTCSS(109) = "229.1Hz"
        CTCSS(110) = "233.6Hz"
        CTCSS(111) = "241.8Hz"
        CTCSS(112) = "250.3Hz"
        CTCSS(113) = "254.1Hz"
        CTCSS(127) = "SEARCH"



        CTCSS(128) = "DCS 023"
        CTCSS(129) = "DCS 025"
        CTCSS(130) = "DCS 026"
        CTCSS(131) = "DCS 031"
        CTCSS(132) = "DCS 032"
        CTCSS(133) = "DCS 036"
        CTCSS(134) = "DCS 043"
        CTCSS(135) = "DCS 047"
        CTCSS(136) = "DCS 051"
        CTCSS(137) = "DCS 053"
        CTCSS(138) = "DCS 054"
        CTCSS(139) = "DCS 065"
        CTCSS(140) = "DCS 071"
        CTCSS(141) = "DCS 072"
        CTCSS(142) = "DCS 073"
        CTCSS(143) = "DCS 074"
        CTCSS(144) = "DCS 114"
        CTCSS(145) = "DCS 115"
        CTCSS(146) = "DCS 116"
        CTCSS(147) = "DCS 122"
        CTCSS(148) = "DCS 125"
        CTCSS(149) = "DCS 131"
        CTCSS(150) = "DCS 132"
        CTCSS(151) = "DCS 134"
        CTCSS(152) = "DCS 143"
        CTCSS(153) = "DCS 145"
        CTCSS(154) = "DCS 152"
        CTCSS(155) = "DCS 155"
        CTCSS(156) = "DCS 156"
        CTCSS(157) = "DCS 162"
        CTCSS(158) = "DCS 165"
        CTCSS(159) = "DCS 172"
        CTCSS(160) = "DCS 174"
        CTCSS(161) = "DCS 205"
        CTCSS(162) = "DCS 212"
        CTCSS(163) = "DCS 223"
        CTCSS(164) = "DCS 225"
        CTCSS(165) = "DCS 226"
        CTCSS(166) = "DCS 243"
        CTCSS(167) = "DCS 244"
        CTCSS(168) = "DCS 245"
        CTCSS(169) = "DCS 246"
        CTCSS(170) = "DCS 251"
        CTCSS(171) = "DCS 252"
        CTCSS(172) = "DCS 255"
        CTCSS(173) = "DCS 261"
        CTCSS(174) = "DCS 263"
        CTCSS(175) = "DCS 265"
        CTCSS(176) = "DCS 266"
        CTCSS(177) = "DCS 271"
        CTCSS(178) = "DCS 274"
        CTCSS(179) = "DCS 306"
        CTCSS(180) = "DCS 311"
        CTCSS(181) = "DCS 315"
        CTCSS(182) = "DCS 325"
        CTCSS(183) = "DCS 331"
        CTCSS(184) = "DCS 332"
        CTCSS(185) = "DCS 343"
        CTCSS(186) = "DCS 346"
        CTCSS(187) = "DCS 351"
        CTCSS(188) = "DCS 356"
        CTCSS(189) = "DCS 364"
        CTCSS(190) = "DCS 365"
        CTCSS(191) = "DCS 371"
        CTCSS(192) = "DCS 411"
        CTCSS(193) = "DCS 412"
        CTCSS(194) = "DCS 413"
        CTCSS(195) = "DCS 423"
        CTCSS(196) = "DCS 431"
        CTCSS(197) = "DCS 432"
        CTCSS(198) = "DCS 445"
        CTCSS(199) = "DCS 446"
        CTCSS(200) = "DCS 452"
        CTCSS(201) = "DCS 454"
        CTCSS(202) = "DCS 455"
        CTCSS(203) = "DCS 462"
        CTCSS(204) = "DCS 464"
        CTCSS(205) = "DCS 465"
        CTCSS(206) = "DCS 466"
        CTCSS(207) = "DCS 503"
        CTCSS(208) = "DCS 506"
        CTCSS(209) = "DCS 516"
        CTCSS(210) = "DCS 523"
        CTCSS(211) = "DCS 526"
        CTCSS(212) = "DCS 532"
        CTCSS(213) = "DCS 546"
        CTCSS(214) = "DCS 565"
        CTCSS(215) = "DCS 606"
        CTCSS(216) = "DCS 612"
        CTCSS(217) = "DCS 624"
        CTCSS(218) = "DCS 627"
        CTCSS(219) = "DCS 631"
        CTCSS(220) = "DCS 632"
        CTCSS(221) = "DCS 654"
        CTCSS(222) = "DCS 662"
        CTCSS(223) = "DCS 664"
        CTCSS(224) = "DCS 703"
        CTCSS(225) = "DCS 712"
        CTCSS(226) = "DCS 723"
        CTCSS(227) = "DCS 731"
        CTCSS(228) = "DCS 732"
        CTCSS(229) = "DCS 734"
        CTCSS(230) = "DCS 743"
        CTCSS(231) = "DCS 754"

        ModMode(0) = "AUTO"
        ModMode(1) = "FM"
        ModMode(2) = "NFM"
        ModMode(3) = "AM"
        ModMode(4) = "FMB"
        ModMode(5) = "WFM"

        SysType(1, 0) = "Conventional"
        SysType(2, 0) = "Mot 800Mhz Type I"
        SysType(3, 0) = "Mot Type II / P25"
        SysType(4, 0) = "EDACS Narrow / Wide"
        SysType(5, 0) = "EDACS SCAT"
        SysType(6, 0) = "LTR"
        SysType(7, 0) = "P25 Standard (Digital XT)"
        SysType(8, 0) = "P25 One Freq Trunk (Digital XT)"
        SysType(9, 0) = "MotoTRBO"
        SysType(10, 0) = "DMR One Freq"

        SysType(1, 1) = "CNV"
        SysType(2, 1) = "MOT1"
        SysType(3, 1) = "MOT2"
        SysType(4, 1) = "EDC"
        SysType(5, 1) = "EDS"
        SysType(6, 1) = "LTR"
        SysType(7, 1) = "P25S"
        SysType(8, 1) = "P25F"
        SysType(9, 1) = "TRBO"
        SysType(10, 1) = "DMR"

        SiteType(1, 0) = "Mot 800MHz Standard (Type II)"
        SiteType(2, 0) = "Mot 800MHz Splinter (Type II)"
        SiteType(3, 0) = "Mot 900MHZ Band"
        SiteType(4, 0) = "Mot VHF Band"
        SiteType(5, 0) = "Mot UHF Band"
        SiteType(6, 0) = "Mot P25/P25 Standard"
        SiteType(7, 0) = "Mot 800MHz Standard (Type I)"
        SiteType(8, 0) = "Mot 800MHz Splinter (Type I)"
        SiteType(9, 0) = "EDACS NARROW"
        SiteType(10, 0) = "EDACS Standard/Wide"
        SiteType(11, 0) = "EDACS SCAT"
        SiteType(12, 0) = "LTR"
        SiteType(13, 0) = "Mot Custom/Reband Type II" ' motorola type 2 custom
        SiteType(14, 0) = "P25 Standard (Digital XT)"
        SiteType(15, 0) = "P25 One Freq Trunk (Digital XT)"
        SiteType(16, 0) = "Mot Custom/Reband Type I" 'motorola type 1 custom
        SiteType(17, 0) = "MotoTRBO"
        SiteType(18, 0) = "DMR One-Freq"

        SiteType(1, 1) = "M82S"
        SiteType(2, 1) = "M82P"
        SiteType(3, 1) = "M92"
        SiteType(4, 1) = "MV2"
        SiteType(5, 1) = "MU2"
        SiteType(6, 1) = "MP25"
        SiteType(7, 1) = "M81S"
        SiteType(8, 1) = "M81P"
        SiteType(9, 1) = "EDN"
        SiteType(10, 1) = "EDW"
        SiteType(11, 1) = "EDS"
        SiteType(12, 1) = "LTR"
        SiteType(13, 1) = "M82C"
        SiteType(14, 1) = "P25S"
        SiteType(15, 1) = "P25F"
        SiteType(16, 1) = "M81C"
        SiteType(17, 1) = "TRB"
        SiteType(18, 1) = "DMR"

        strServiceSearch(0) = "."
        strServiceSearch(1) = "PublicSafety"
        strServiceSearch(2) = "News"
        strServiceSearch(3) = "HAM"
        strServiceSearch(4) = "Marine"
        strServiceSearch(5) = "Railroad"
        strServiceSearch(6) = "Air"
        strServiceSearch(7) = "CB"
        strServiceSearch(8) = "FRS/GMRS"
        strServiceSearch(9) = "Racing"
        strServiceSearch(10) = "TV"
        strServiceSearch(11) = "FM"
        strServiceSearch(12) = "Special"
        strServiceSearch(13) = "Military"
        strServiceSearch(14) = "CUSTOM_1"
        strServiceSearch(15) = "CUSTOM_2"
        strServiceSearch(16) = "CUSTOM_3"
        strServiceSearch(17) = "CUSTOM_4"
        strServiceSearch(18) = "CUSTOM_5"
        strServiceSearch(19) = "CUSTOM_6"
        strServiceSearch(20) = "CUSTOM_7"
        strServiceSearch(21) = "CUSTOM_8"
        strServiceSearch(22) = "CUSTOM_9"
        strServiceSearch(23) = "CUSTOM_10"
        strServiceSearch(24) = "TONE_OUT"
        strServiceSearch(25) = "B_SCOPE"
        'rebanding steps

        strMcpStep(0) = "500"

        strMcpStep(1) = "625"

        strMcpStep(2) = "1000"

        strMcpStep(3) = "1250"

        strMcpStep(4) = "1500"

        strMcpStep(5) = "1875"

        strMcpStep(6) = "2000"

        strMcpStep(7) = "2500"

        strMcpStep(8) = "3000"

        strMcpStep(9) = "3125"

        strMcpStep(10) = "3500"

        strMcpStep(11) = "3750"

        strMcpStep(12) = "4000"

        strMcpStep(13) = "4375"

        strMcpStep(14) = "4500"

        strMcpStep(15) = "5000"

        strMcpStep(16) = "5500"

        strMcpStep(17) = "5625"

        strMcpStep(18) = "6000"

        strMcpStep(19) = "6250"

        strMcpStep(20) = "6500"

        strMcpStep(21) = "6875"

        strMcpStep(22) = "7000"

        strMcpStep(23) = "7500"

        strMcpStep(24) = "8000"

        strMcpStep(25) = "8125"

        strMcpStep(26) = "8500"

        strMcpStep(27) = "8750"

        strMcpStep(28) = "9000"

        strMcpStep(29) = "9375"

        strMcpStep(30) = "9500"

        strMcpStep(31) = "10000"

        BandData(0, 0) = "25"
        BandData(1, 0) = "26.965"
        BandData(2, 0) = "27.41"
        BandData(3, 0) = "28"
        BandData(4, 0) = "29.7"
        BandData(5, 0) = "50"
        BandData(6, 0) = "54"
        BandData(7, 0) = "72"
        BandData(8, 0) = "76"
        BandData(9, 0) = "88"
        BandData(10, 0) = "108"
        BandData(11, 0) = "137"
        BandData(12, 0) = "144"
        BandData(13, 0) = "148"
        BandData(14, 0) = "150.8"
        BandData(15, 0) = "162"
        BandData(16, 0) = "174"
        BandData(17, 0) = "216"
        BandData(18, 0) = "225"
        BandData(19, 0) = "380"
        BandData(20, 0) = "400"
        BandData(21, 0) = "406"
        BandData(22, 0) = "420"
        BandData(23, 0) = "450"
        BandData(24, 0) = "470"
        BandData(25, 0) = "763"
        BandData(26, 0) = "793"
        BandData(27, 0) = "806"
        BandData(28, 0) = "849.0125"
        BandData(29, 0) = "894.0125"
        BandData(30, 0) = "1240"

        BandData(0, 1) = "26.96"
        BandData(1, 1) = "27.405"
        BandData(2, 1) = "27.995"
        BandData(3, 1) = "29.68"
        BandData(4, 1) = "49.99"
        BandData(5, 1) = "53.98"
        BandData(6, 1) = "71.95"
        BandData(7, 1) = "75.995"
        BandData(8, 1) = "87.95"
        BandData(9, 1) = "107.9"
        BandData(10, 1) = "136.9916"
        BandData(11, 1) = "143.9875"
        BandData(12, 1) = "147.995"
        BandData(13, 1) = "150.7875"
        BandData(14, 1) = "161.995"
        BandData(15, 1) = "173.9875"
        BandData(16, 1) = "215.95"
        BandData(17, 1) = "224.98"
        BandData(18, 1) = "379.975"
        BandData(19, 1) = "399.9875"
        BandData(20, 1) = "405.9875"
        BandData(21, 1) = "419.9875"
        BandData(22, 1) = "449.9875"
        BandData(23, 1) = "469.9875"
        BandData(24, 1) = "512"
        BandData(25, 1) = "775.9937"
        BandData(26, 1) = "805.9937"
        BandData(27, 1) = "823.9875"
        BandData(28, 1) = "868.9875"
        BandData(29, 1) = "960"
        BandData(30, 1) = "1300"

        BandData(0, 2) = "AM"
        BandData(1, 2) = "AM"
        BandData(2, 2) = "AM"
        BandData(3, 2) = "NFM"
        BandData(4, 2) = "NFM"
        BandData(5, 2) = "NFM"
        BandData(6, 2) = "WFM"
        BandData(7, 2) = "FM"
        BandData(8, 2) = "WFM"
        BandData(9, 2) = "FMB"
        BandData(10, 2) = "AM"
        BandData(11, 2) = "NFM"
        BandData(12, 2) = "NFM"
        BandData(13, 2) = "NFM"
        BandData(14, 2) = "NFM"
        BandData(15, 2) = "NFM"
        BandData(16, 2) = "WFM"
        BandData(17, 2) = "NFM"
        BandData(18, 2) = "AM"
        BandData(19, 2) = "NFM"
        BandData(20, 2) = "NFM"
        BandData(21, 2) = "NFM"
        BandData(22, 2) = "NFM"
        BandData(23, 2) = "NFM"
        BandData(24, 2) = "NFM"
        BandData(25, 2) = "NFM"
        BandData(26, 2) = "NFM"
        BandData(27, 2) = "NFM"
        BandData(28, 2) = "NFM"
        BandData(29, 2) = "NFM"
        BandData(30, 2) = "NFM"

        BandData(0, 3) = "500"
        BandData(1, 3) = "500"
        BandData(2, 3) = "500"
        BandData(3, 3) = "2000"
        BandData(4, 3) = "1000"
        BandData(5, 3) = "2000"
        BandData(6, 3) = "5000"
        BandData(7, 3) = "500"
        BandData(8, 3) = "5000"
        BandData(9, 3) = "10000"
        BandData(10, 3) = "833"
        BandData(11, 3) = "1250"
        BandData(12, 3) = "500"
        BandData(13, 3) = "1250"
        BandData(14, 3) = "500"
        BandData(15, 3) = "1250"
        BandData(16, 3) = "5000"
        BandData(17, 3) = "2000"
        BandData(18, 3) = "2500"
        BandData(19, 3) = "1250"
        BandData(20, 3) = "1250"
        BandData(21, 3) = "1250"
        BandData(22, 3) = "1250"
        BandData(23, 3) = "1250"
        BandData(24, 3) = "1250"
        BandData(25, 3) = "625"
        BandData(26, 3) = "625"
        BandData(27, 3) = "1250"
        BandData(28, 3) = "1250"
        BandData(29, 3) = "1250"
        BandData(30, 3) = "2500"

        BandData(0, 4) = "Petroleum Products & Broadcast Pickup"
        BandData(1, 4) = "CB Radio"
        BandData(2, 4) = "Business & Forest Products"
        BandData(3, 4) = "10 Meter Amateur Band"
        BandData(4, 4) = "VHF Low Band"
        BandData(5, 4) = "6 Meter Amateur Band"
        BandData(6, 4) = "VHF TV Broadcast 2 – 4"
        BandData(7, 4) = "Intersystem & Astronomy"
        BandData(8, 4) = "VHF TV Broadcast 5 – 6"
        BandData(9, 4) = "FM Broadcast"
        BandData(10, 4) = "Aircraft Band"
        BandData(11, 4) = "Military Land Mobile"
        BandData(12, 4) = "2 Meter Amateur Band"
        BandData(13, 4) = "Military Land Mobile"
        BandData(14, 4) = "VHF High Band"
        BandData(15, 4) = "Federal Government"
        BandData(16, 4) = "TV Broadcast 7 – 13"
        BandData(17, 4) = "1.25 Meter Amateur Band"
        BandData(18, 4) = "UHF Aircraft Band"
        BandData(19, 4) = "Military Band"
        BandData(20, 4) = "Miscellaneous"
        BandData(21, 4) = "Federal Government Land Mobile"
        BandData(22, 4) = "70 cm Amateur Band"
        BandData(23, 4) = "UHF Standard Band"
        BandData(24, 4) = "UHF TV"
        BandData(25, 4) = "Public Service Band"
        BandData(26, 4) = "Public Service Band"
        BandData(27, 4) = "Public Service Band"
        BandData(28, 4) = "Public Service Band"
        BandData(29, 4) = "Public Service Band"
        BandData(30, 4) = "25 cm Amateur Band"

        varState(0, 0) = "00"
        varState(1, 0) = "AL"
        varState(2, 0) = "AK"
        varState(3, 0) = "AZ"
        varState(4, 0) = "AR"
        varState(5, 0) = "CA"
        varState(6, 0) = "CO"
        varState(7, 0) = "CT"
        varState(8, 0) = "DE"
        varState(9, 0) = "DC"
        varState(10, 0) = "FL"
        varState(11, 0) = "GA"
        varState(12, 0) = "GU"
        varState(13, 0) = "HI"
        varState(14, 0) = "ID"
        varState(15, 0) = "IL"
        varState(16, 0) = "IN"
        varState(17, 0) = "IA"
        varState(18, 0) = "KS"
        varState(19, 0) = "KY"
        varState(20, 0) = "LA"
        varState(21, 0) = "ME"
        varState(22, 0) = "MD"
        varState(23, 0) = "MA"
        varState(24, 0) = "MI"
        varState(25, 0) = "MN"
        varState(26, 0) = "MS"
        varState(27, 0) = "MO"
        varState(28, 0) = "MT"
        varState(29, 0) = "NE"
        varState(30, 0) = "NV"
        varState(31, 0) = "NH"
        varState(32, 0) = "NJ"
        varState(33, 0) = "NM"
        varState(34, 0) = "NY"
        varState(35, 0) = "NC"
        varState(36, 0) = "ND"
        varState(37, 0) = "OH"
        varState(38, 0) = "OK"
        varState(39, 0) = "OR"
        varState(40, 0) = "PA"
        varState(41, 0) = "PR"
        varState(42, 0) = "RI"
        varState(43, 0) = "SC"
        varState(44, 0) = "SD"
        varState(45, 0) = "TN"
        varState(46, 0) = "TX"
        varState(47, 0) = "UT"
        varState(48, 0) = "VT"
        varState(49, 0) = "VI"
        varState(50, 0) = "VA"
        varState(51, 0) = "WA"
        varState(52, 0) = "WV"
        varState(53, 0) = "WI"
        varState(54, 0) = "WY"
        varState(55, 0) = "CAN_AB"
        varState(56, 0) = "CAN_BC"
        varState(57, 0) = "CAN_MB"
        varState(58, 0) = "CAN_NF"
        varState(59, 0) = "CAN_NB"
        varState(60, 0) = "CAN_NS"
        varState(61, 0) = "CAN_NU"
        varState(62, 0) = "CAN_NW"
        varState(63, 0) = "CAN_ON"
        varState(64, 0) = "CAN_PE"
        varState(65, 0) = "CAN_QC"
        varState(66, 0) = "CAN_SK"
        varState(67, 0) = "CAN_YU"

        varState(0, 1) = "Off"
        varState(1, 1) = "Alabama"
        varState(2, 1) = "Alaska"
        varState(3, 1) = "Arizona"
        varState(4, 1) = "Arkansas"
        varState(5, 1) = "California"
        varState(6, 1) = "Colorado"
        varState(7, 1) = "Connecticut"
        varState(8, 1) = "Delaware"
        varState(9, 1) = "Dist.of Columbia"
        varState(10, 1) = "Florida"
        varState(11, 1) = "Georga"
        varState(12, 1) = "Guam"
        varState(13, 1) = "Hawaii"
        varState(14, 1) = "Idaho"
        varState(15, 1) = "Illinois"
        varState(16, 1) = "Indiana"
        varState(17, 1) = "Iowa"
        varState(18, 1) = "Kansas"
        varState(19, 1) = "Kentucky"
        varState(20, 1) = "Louisiana"
        varState(21, 1) = "Maine"
        varState(22, 1) = "Maryland"
        varState(23, 1) = "Massachusetts"
        varState(24, 1) = "Michigan"
        varState(25, 1) = "Minnesota"
        varState(26, 1) = "Mississippi"
        varState(27, 1) = "Missouri"
        varState(28, 1) = "Montana"
        varState(29, 1) = "Nebraska"
        varState(30, 1) = "Nevada"
        varState(31, 1) = "New Hampshire"
        varState(32, 1) = "New Jersey"
        varState(33, 1) = "New Mexico"
        varState(34, 1) = "New York"
        varState(35, 1) = "North Carolina"
        varState(36, 1) = "North Dakota"
        varState(37, 1) = "Ohio"
        varState(38, 1) = "Oklahoma"
        varState(39, 1) = "Oregon"
        varState(40, 1) = "Pennsylvania"
        varState(41, 1) = "Puerto Rico"
        varState(42, 1) = "Rhode Island"
        varState(43, 1) = "South Carolina"
        varState(44, 1) = "South Dakota"
        varState(45, 1) = "Tennessee"
        varState(46, 1) = "Texas"
        varState(47, 1) = "Utah"
        varState(48, 1) = "Vermont"
        varState(49, 1) = "Virgin Islands"
        varState(50, 1) = "Virginia"
        varState(51, 1) = "Washington"
        varState(52, 1) = "West Virginia"
        varState(53, 1) = "Wisconsin"
        varState(54, 1) = "Wyoming"
        varState(55, 1) = "Alberta"
        varState(56, 1) = "British Columbia"
        varState(57, 1) = "Manitoba"
        varState(58, 1) = "Newfoundland"
        varState(59, 1) = "New Brunswick"
        varState(60, 1) = "Nova Scotia"
        varState(61, 1) = "Nunavit"
        varState(62, 1) = "NW Territories"
        varState(63, 1) = "ONTARIO"
        varState(64, 1) = "P.E.I"
        varState(65, 1) = "Quebec"
        varState(66, 1) = "Saskachewan"
        varState(67, 1) = "Yukon"

    End Sub
    Function CheckTGIDSpace(ByRef intSys As Integer) As Integer
        'checks to see how many more TGIDs can be entered in a system
        Dim strSYSID As String
        Dim lngChan, lngNumChan As Integer
        Dim intGroup As Integer
        For intGroup = 2 To MaxGroups

            strSYSID = varSite(intSys, intGroup, 0, 10)
            If strSYSID <> "" Then
                For lngChan = 1 To MaxChan
                    If ChanInfo(lngChan, 10) = strSYSID Then
                        lngNumChan = lngNumChan + 1
                    End If
                Next lngChan
            End If
        Next intGroup

        CheckTGIDSpace = MaxScannerTrnChan - lngNumChan
    End Function
    Function MakeOnOff(ByRef strValue As String) As String
        'returns On or Off as a text string

        Select Case UCase(strValue)
            Case "1"

                MakeOnOff = "On"
            Case "TRUE"

                MakeOnOff = "On"
            Case Else

                MakeOnOff = "Off"
        End Select
    End Function
    Function MakePositive(ByRef intPos As Long) As Long
        'always returns a positive number

        intPos = Val(intPos)

        If intPos > 0 Then


            MakePositive = intPos
        Else

            MakePositive = 0
        End If
    End Function

    Function RemoveQuotes(ByRef strInp As String) As String

        RemoveQuotes = Replace(strInp, Chr(34), "", 1, , CompareMethod.Binary)
    End Function

    Function Kompressor(ByRef strInput As String) As String
        'automatically shrinks down long fields to below 16 chars
        Dim strField As String

        strField = Trim(strInput)
        If Len(strField) > 16 Then 'remove spaces
            strField = Replace(strField, " or ", "/", , , CompareMethod.Text)
            strField = Replace(strField, " ", "")
            strField = Replace(strField, ".", "")
        End If
        If Len(strField) > 16 Then 'remove spaces
            strField = Replace(strField, "Police Department", "PD", , , CompareMethod.Text)
            strField = Replace(strField, "Communications", "Comms", , , CompareMethod.Text)
            strField = Replace(strField, "Communication", "Comm", , , CompareMethod.Text)
            strField = Replace(strField, "Fire Department", "FD", , , CompareMethod.Text)
            strField = Replace(strField, "Ambulance", "Amb", , , CompareMethod.Text)
            strField = Replace(strField, "Police Dep", "PD", , , CompareMethod.Text)
            strField = Replace(strField, "Fire Dep", "FD", , , CompareMethod.Text)
            strField = Replace(strField, "Corporation", "Corp", , , CompareMethod.Text)
            strField = Replace(strField, "Business", "Biz", , , CompareMethod.Text)
            strField = Replace(strField, "Hospital", "Hosp", , , CompareMethod.Text)
            strField = Replace(strField, "General", "Gen", , , CompareMethod.Text)
            strField = Replace(strField, "Military", "Mil", , , CompareMethod.Text)
            strField = Replace(strField, "Control", "Ctl", , , CompareMethod.Text)
            strField = Replace(strField, "Emergency", "EMG", , , CompareMethod.Text)
            strField = Replace(strField, "Information", "Info", , , CompareMethod.Text)

            strField = Replace(strField, "Intelligence", "INT", , , CompareMethod.Text)
            strField = Replace(strField, "Investigative", "INV", , , CompareMethod.Text)
            strField = Replace(strField, "Investigations", "Inv", , , CompareMethod.Text)
            strField = Replace(strField, "Investigation", "Inv", , , CompareMethod.Text)
            strField = Replace(strField, "Detective", "Det", , , CompareMethod.Text)
            strField = Replace(strField, "Organized", "Org", , , CompareMethod.Text)
            strField = Replace(strField, "Service", "Svc", , , CompareMethod.Text)
            strField = Replace(strField, "Surveillance", "Surv", , , CompareMethod.Text)
            strField = Replace(strField, "Tactical", "TAC", , , CompareMethod.Text)
            strField = Replace(strField, "Technician", "Tech", , , CompareMethod.Text)
            strField = Replace(strField, "Technical", "Tech", , , CompareMethod.Text)
            strField = Replace(strField, "Operations", "Ops", , , CompareMethod.Text)
            strField = Replace(strField, "Operation", "Op", , , CompareMethod.Text)
            strField = Replace(strField, "Enforcement", "Enf", , , CompareMethod.Text)
            strField = Replace(strField, "Channel", "Chn", , , CompareMethod.Text)
            strField = Replace(strField, "District", "Dst", , , CompareMethod.Text)
            strField = Replace(strField, "Rescue", "Resc", , , CompareMethod.Text)
            strField = Replace(strField, "Vehicle", "Veh", , , CompareMethod.Text)
            strField = Replace(strField, "Canine", "K9", , , CompareMethod.Text)
            strField = Replace(strField, "Repeater", "Rep", , , CompareMethod.Text)
            strField = Replace(strField, "Traffic", "Traf", , , CompareMethod.Text)
            strField = Replace(strField, "Helicopter", "Hel", , , CompareMethod.Text)
            strField = Replace(strField, "Division", "Div", , , CompareMethod.Text)
            strField = Replace(strField, "System", "Sys", , , CompareMethod.Text)
            strField = Replace(strField, "Dispatch", "Disp", , , CompareMethod.Text)
            strField = Replace(strField, "Fireground", "FireGrnd", , , CompareMethod.Text)
            strField = Replace(strField, "Maintenance", "Maint", , , CompareMethod.Text)
            strField = Replace(strField, "Talkgroup", "TG", , , CompareMethod.Text)
            strField = Replace(strField, "Inspector", "Insp", , , CompareMethod.Text)
            strField = Replace(strField, "Electrical", "Elec", , , CompareMethod.Text)
            strField = Replace(strField, "Special", "Spec", , , CompareMethod.Text)
            strField = Replace(strField, "Administration", "Adm", , , CompareMethod.Text)
            strField = Replace(strField, "Department", "Dep", , , CompareMethod.Text)
            strField = Replace(strField, "Police Department", "PD", , , CompareMethod.Text)
            strField = Replace(strField, "Amateur", "HAM", , , CompareMethod.Text)
            strField = Replace(strField, "Sanitation", "San", , , CompareMethod.Text)
            strField = Replace(strField, "Command Post", "CP", , , CompareMethod.Text)
            strField = Replace(strField, "Federal", "Fed", , , CompareMethod.Text)
            strField = Replace(strField, "Medical", "Med", , , CompareMethod.Text)
            strField = Replace(strField, "University", "Univ", , , CompareMethod.Text)
            strField = Replace(strField, "International", "Intl", , , CompareMethod.Text)
            strField = Replace(strField, "Generator", "Gen", , , CompareMethod.Text)
            strField = Replace(strField, "Government", "Govt", , , CompareMethod.Text)
            strField = Replace(strField, "Recreation", "Rec", , , CompareMethod.Text)
            strField = Replace(strField, "County", "Cnty", , , CompareMethod.Text)
            strField = Replace(strField, "Primary", "Pri", , , CompareMethod.Text)
            strField = Replace(strField, "Identified", "Idnt", , , CompareMethod.Text)
            strField = Replace(strField, "Highway", "Hwy", , , CompareMethod.Text)
            strField = Replace(strField, "Townshipof", "TownOf", , , CompareMethod.Text)
            strField = Replace(strField, "Vehicular", "Veh", , , CompareMethod.Text)
        End If
        If Len(strField) > 16 Then 'more aggresive compressing
            strField = Replace(strField, "TownOf", "")
            strField = Replace(strField, "Ground", "Grnd", , , CompareMethod.Text)
            strField = Replace(strField, "California", "CA.", , , CompareMethod.Text)
            strField = Replace(strField, "Southern", "South", , , CompareMethod.Text)
            strField = Replace(strField, "Western", "West", , , CompareMethod.Text)
            strField = Replace(strField, "Northern", "North", , , CompareMethod.Text)
            strField = Replace(strField, "Eastern", "East", , , CompareMethod.Text)
            strField = Replace(strField, "Private", "Pvt", , , CompareMethod.Text)
            strField = Replace(strField, "Govt", "Gov", , , CompareMethod.Text)
            strField = Replace(strField, "Stateof", "", , , CompareMethod.Text)
            strField = Replace(strField, "Systems", "Sys", , , CompareMethod.Text)
            strField = Replace(strField, "System", "Sys", , , CompareMethod.Text)
            strField = Replace(strField, "Network", "Net", , , CompareMethod.Text)
            strField = Replace(strField, "Power", "Pwr", , , CompareMethod.Text)
            strField = Replace(strField, "Automatic", "Auto", , , CompareMethod.Text)
            strField = Replace(strField, "Battalion", "BN", , , CompareMethod.Text)
            strField = Replace(strField, "Terminal", "Trm", , , CompareMethod.Text)
            strField = Replace(strField, "Police", "PD", , , CompareMethod.Text)
            strField = Replace(strField, "Region", "Rgn", , , CompareMethod.Text)
            strField = Replace(strField, "Simplex", "SIM", , , CompareMethod.Text)
            strField = Replace(strField, "Mount", "Mnt", , , CompareMethod.Text)
            strField = Replace(strField, "Ministry", "Min", , , CompareMethod.Text)
            strField = Replace(strField, "Engineering", "Eng", , , CompareMethod.Text)
            strField = Replace(strField, "Television", "TV", , , CompareMethod.Text)
            strField = Replace(strField, "Station", "Stn", , , CompareMethod.Text)
            strField = Replace(strField, "HWY", "HW", , , CompareMethod.Text)
            strField = Replace(strField, "Ranger", "Rng", , , CompareMethod.Text)
            strField = Replace(strField, "Commission", "COMM", , , CompareMethod.Text)
            strField = Replace(strField, "Supervisor", "Sprvsr", , , CompareMethod.Text)
            strField = Replace(strField, "Command", "Cmd", , , CompareMethod.Text)
            strField = Replace(strField, "Weather", "WX", , , CompareMethod.Text)
            strField = Replace(strField, "Search", "Srch", , , CompareMethod.Text)
            strField = Replace(strField, "Center", "Cen", , , CompareMethod.Text)
            strField = Replace(strField, "Centre", "Cen", , , CompareMethod.Text)
            strField = Replace(strField, "Aircraft", "AC", , , CompareMethod.Text)
            strField = Replace(strField, "Flight Level", "FL", , , CompareMethod.Text)
            strField = Replace(strField, "Tech", "Tek", , , CompareMethod.Text)
            strField = Replace(strField, "Conservation", "Cons", , , CompareMethod.Text)
            strField = Replace(strField, "Animal", "Anml", , , CompareMethod.Text)
            strField = Replace(strField, "Wildlife", "WLDLF", , , CompareMethod.Text)
            strField = Replace(strField, "Aircraft", "Plane", , , CompareMethod.Text)
            strField = Replace(strField, "Tower", "Twr", , , CompareMethod.Text)
            strField = Replace(strField, "Runway", "RW", , , CompareMethod.Text)
            strField = Replace(strField, "Airforce", "AF", , , CompareMethod.Text)
            strField = Replace(strField, "Canadian", "Cdn", , , CompareMethod.Text)
            strField = Replace(strField, "Repeater", "Rpt", , , CompareMethod.Text)
            strField = Replace(strField, "Structure", "Strct", , , CompareMethod.Text)

        End If
        If Len(strField) > 16 Then 'more aggresive compressing
            strField = Replace(strField, "Cityof", Nothing, CompareMethod.Text)
            strField = Replace(strField, "Townof", Nothing, CompareMethod.Text)
            strField = Replace(strField, "Downtown", "DwnTwn", CompareMethod.Text, CompareMethod.Text)
            strField = Replace(strField, "(", Nothing, CompareMethod.Text)
            strField = Replace(strField, ")", Nothing, CompareMethod.Text)
            strField = Replace(strField, "Simulcast", Nothing, CompareMethod.Text)
            strField = Replace(strField, "-", Nothing, CompareMethod.Text)
        End If

        Kompressor = MakeItKosherSilent(strField, 0)
    End Function




    Function SendCMD(ByRef strCMD As String) As String

        Dim blnGotResponse As Boolean
        Dim intLoopCount As Integer
        Dim strInp As String, intExtraTime As Integer
        Dim strbuffer As String
        Dim varByte(500) As Byte, intByte, intByteCnt As Integer
        Dim intChkLinux, lngLoopTimeout As Integer
        SendCMD = Nothing
        strbuffer = Nothing
        If blnSendBusy = True Then Exit Function

        'if this is a command that takes a long time, add extra time
        If InStr(strCMD, "DSY") Or InStr(strCMD, "CLR") Then
            intExtraTime = 25000
        ElseIf frmCOMPort.Visible Then
            intExtraTime = -1950
        Else
            intExtraTime = 0
        End If
        'sends and receives a response
        IOGraphic(("A"))
        If blnDebug = False Then On Error GoTo errhandler

        If Form1.msc.IsOpen = False Then

            SendCMD = "-1"
            IOGraphic(("E"))
            strCurOp = "Error, port could not be opened"
            blnSendBusy = False
            intErrors += 1
            sngErr += 1
            blnSendBusy = False
            Exit Function
        End If
        Form1.msc.WriteLine(strCMD & vbCr)
        blnSendBusy = True
        If Form1.Visible = True Then
            With Form1
                .lblOp.Text = strCurOp
            End With
        ElseIf frmCommsDownload.Visible = True Then
            With frmCommsDownload
                .lblOp.Text = strCurOp
            End With
        ElseIf lblSiteNote.Visible = True Then
            lblSiteNote.DispStat(strCurOp)
        End If
        If blnRmtCtlMode = False Then strLog &= "TX: " & strCMD & vbNewLine
        'wait for a response

        lngLoopTimeout = 0
        With Form1
            strbuffer = Nothing
            Do Until InStr(strbuffer, Chr(13)) <> 0 Or blnGotResponse = True Or Form1.msc.IsOpen = False
                System.Windows.Forms.Application.DoEvents()
                'slow down if there are errors in the downlad
                If sngErr <> 0 Then
                    DownloadCarefully = True
                End If
                If DownloadCarefully Then
                    System.Threading.Thread.Sleep(25)
                Else
                    System.Threading.Thread.Sleep(2)
                End If
                If Form1.msc.IsOpen And blnRmtCtlMode Then
                    If Not DownloadCarefully Then System.Threading.Thread.Sleep(5)
                    intByteCnt = Form1.msc.BytesToRead
                    System.Array.Clear(varByte, 0, varByte.Length)
                    Form1.msc.Read(varByte, 0, intByteCnt)
                    For intByte = 0 To intByteCnt
                        strbuffer &= Chr(varByte(intByte))
                    Next intByte
                    strbuffer = Replace(strbuffer, Chr(0), Nothing)
                ElseIf Form1.msc.IsOpen Then

                    strbuffer &= Form1.msc.ReadExisting
                End If


                If lngLoopTimeout >= 2000 + intExtraTime Then
                    blnGotResponse = True
                    strbuffer &= "-1"
                    IOGraphic(("E"))
                    strCurOp = "Timeout error"
                    sngErr += 1
                    GenLog(("Timeout Error"))
                End If
                lngLoopTimeout += 1

                If InStr(strbuffer, Chr(13)) = 0 And blnRmtCtlMode = False Then 'wait a bit if a response hasnt come yet
                    System.Threading.Thread.Sleep(1)
                End If
            Loop
        End With

        blnSendBusy = False
        If Form1.Visible = True And blnRmtCtlMode = False Then
            strLog &= "RX: " & Microsoft.VisualBasic.Left(strbuffer, MakePositive(Len(strbuffer) - 1)) & vbNewLine & vbNewLine
            Form1.WriteStats()
        ElseIf frmCommsDownload.Visible = True And blnRmtCtlMode = False Then
            strLog &= "RX: " & Microsoft.VisualBasic.Left(strbuffer, MakePositive(Len(strbuffer) - 1)) & vbNewLine & vbNewLine
            frmCommsDownload.WriteStats()
        End If
        If Len(strbuffer) > 4 Then
            strbuffer = Microsoft.VisualBasic.Right(strbuffer, Len(strbuffer) - MakePositive(instr(strbuffer, ","))) 'remove first command response
            strbuffer = Replace(strbuffer, Chr(13), Nothing) 'remove CR
        End If
        SendCMD = strbuffer

        If intErrors >= 6 And blnRmtCtlMode = True Then 'abort remote control mode if too many errors
            Call frmCtlSetup.StopCOMMS()
        End If
        Exit Function
errhandler:
        Form1.msc.Close()
        sngErr += 1
        strLog &= "Error " & Err.Number
    End Function

    Function SendNetCMD(ByRef strCMD As String) As String
        'retrieves a document from the INTERNET

        ' Get HTML data
        Dim client As WebClient = New WebClient()


        Dim strResult As String = Nothing
        Try
            Dim data As Stream = client.OpenRead(strCMD)
            Dim reader As StreamReader = New StreamReader(data)
            strResult = reader.ReadLine()

        Catch
            'didnt work
            strResult = "ERROR"
        End Try
        SendNetCMD = strResult
    End Function
    Function RemoteMode() As Boolean
        'nags user and returns true if the program
        'is currently in remote control mode
        If blnRmtCtlMode = True Then
            MsgBox("FreeSCAN currently has a Virtual Control window open. FreeSCAN cannot proceed until this window is closed.")

            RemoteMode = True
        End If
    End Function
    Function FormatFreq(ByRef dblFreq As Double) As String
        FormatFreq = dblFreq.ToString("###0.00000")
    End Function
    Function IsValidChan(ByRef strID As String) As Boolean
        'returns true if a frequency or TGID is numerically valid
        Dim strBuff As String

        IsValidChan = True
        If blnDebug = False Then On Error Resume Next

        strBuff = strID
        strBuff = Replace(strBuff, "-", "")
        'a small i is acceptable as a first letter
        If Strings.Left(strBuff, 1) = "i" Or Strings.Left(strBuff, 1) = "D" Then
            IsValidChan = True
            Exit Function
        End If
        If IsNumeric(strBuff) = False Or Val(strBuff) < 0.5 Then
            'Nuke it

            IsValidChan = False
        End If
    End Function

    Sub ExpandChanArray()
        'Expands memory available to store channels
        If blnDebug = False Then On Error Resume Next
        Dim chanTemp(1, 1) As String
        ReDim chanTemp(MaxChan, MaxChanSetting)
        Dim intChan, intParam, intNewMax As Integer
        If MaxChan < 30766 Then 'expand by 2000 channels
            intNewMax = MaxChan + 2000
        Else
            intNewMax = 32766
        End If
        For intChan = 0 To MaxChan
            For intParam = 0 To MaxChanSetting
                chanTemp(intChan, intParam) = ChanInfo(intChan, intParam)
            Next intParam
        Next intChan
        'Erase ChanInfo
        ReDim ChanInfo(intNewMax, MaxChanSetting)
        'copy the data back
        For intChan = 0 To MaxChan
            For intParam = 0 To MaxChanSetting
                ChanInfo(intChan, intParam) = chanTemp(intChan, intParam)
            Next intParam
        Next intChan


        MaxChan = intNewMax
    End Sub

    Public Function GetTempFileName() As String
        Dim returnValue As String

        returnValue = Path.GetTempFileName()
        GetTempFileName = returnValue
    End Function
    Sub SetDLMode()
        'Sets the flag to download carefully or not depending on prefs
        DownloadCarefully = MakeBoolean(GetSetting("FreeSCAN", "Settings", "Careful", "1"))
    End Sub
    Sub MarkChange()
        'When a file is changed, the current system
        'is flagged to indicate it has been changed
        'and the file saved flag reset
        varSite(intCurrentSys, 0, 0, 34) = "1"
        blnChgSaved = False
    End Sub
    Sub InsertGliDX(ByVal SysID As String, ByVal TGID As String)
        'Inserts another entry in the global TGID system lockout
        Dim iPos, iMax As Integer
        Dim bFound As Boolean = False
        Dim chanTemp(1, 1) As String
        Dim intNewMax As Integer
        iMax = UBound(GliDX)
        For iPos = 0 To iMax
            If GliDX(iPos, 0) = "" Then
                bFound = True
                Exit For
            End If
        Next
        If Not bFound Then 'we may have to expand the array
            If iMax < 32000 Then
                'make a backup copy of orig variable
                ReDim chanTemp(iMax, 1)
                For iPos = 0 To iMax
                    chanTemp(iPos, 0) = GliDX(iPos, 0)
                    chanTemp(iPos, 1) = GliDX(iPos, 1)
                Next iPos

                'expand by 200 channels
                If iMax < 30766 Then
                    intNewMax = iMax + 200
                Else
                    intNewMax = 32766
                End If
                ReDim GliDX(intNewMax, 1)


                'copy the data back
                For iPos = 0 To iMax
                    GliDX(iPos, 0) = chanTemp(iPos, 0)
                    GliDX(iPos, 1) = chanTemp(iPos, 1)
                Next iPos

                iPos = iMax + 1
            Else ' can't find a free spot, just exit this data isnt that important
                Exit Sub
            End If
        End If
        'finally, save the data
        GliDX(iPos, 0) = SysID
        GliDX(iPos, 1) = TGID
    End Sub
    Sub DisableCCO(ByVal sModel As String, ByVal bLeaveInPRGmode As Boolean)
        'Disable control channel output of XT scanners
        Dim sBuff As String
        Dim sCmd() As String
        If Form1.msc.IsOpen = False Then Exit Sub '
        sBuff = GetSetting("FreeSCAN", "Settings", "ForceCCO", "1")
        If sBuff = "0" Then 'user does not want this feature
            Exit Sub
        End If
        Try
            If InStr(sModel, "XT") <> 0 Or sModel = "BCT15X" Then
                'An XT model
                sBuff = SendCMD("PRG")
                sBuff = SendCMD("SCN")
                'Force CCO off
                sCmd = Split(sBuff, ",")
                If UBound(sCmd) = 20 Then
                    'Was it even on? if so disable it
                    If sCmd(2) = "1" Or sCmd(2) = "2" Then
                        GenLog("Forced Control Channel Ouput to OFF")
                        sCmd(2) = "0"
                        sBuff = "SCN," & Join(sCmd, ",")
                        sBuff = SendCMD(sBuff)
                        If sBuff <> "OK" Then
                            MsgBox("Error disabling control channel output. You may receive further error messages or crashes. It is recommended that you disable this via front panel.", MsgBoxStyle.Exclamation)
                        End If
                    End If
                End If
                If Not bLeaveInPRGmode Then sBuff = SendCMD("EPG")
            End If
        Catch ex As Exception
            MsgBox("Error attempting to disable control channel output." & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Function COMPortExists() As Boolean
        COMPortExists = False
        'Verifies that the currently selected COM port still exists before trying to access it

        Dim ComPorts(255) As Integer
        Dim cnt As Integer = 0
        For Each sp As String In My.Computer.Ports.SerialPortNames
            If Form1.msc.PortName = sp Then
                COMPortExists = True
                Exit Function
            End If
        Next
        'Bitch at user
        MsgBox("FreeSCAN is unable to access " & Form1.msc.PortName & ". Check your settings and try again.", MsgBoxStyle.Critical)
    End Function
End Module