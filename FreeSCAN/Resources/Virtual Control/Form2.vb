Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports NAudio.Wave
Imports System.Diagnostics
Imports System.Management
Imports VB = Microsoft.VisualBasic
Public Class frmRecord
    Dim WithEvents _lameShell As New LameShell
    ' Public waveInStream As WaveInStream
    Public waveInStream As WaveIn
    Private writer As WaveFileWriter
    Private outputFilename As String
    Public blnRecFault As Boolean = False
    Const MaxRecDev As Integer = 16
    Public MaxRecTime As Integer = CInt(GetSetting("FreeSCAN", "Settings", "MaxRecTime", "500"))
    Public MinRecTime As Single = 0.5
    Public HangRecTime As Single = 1
    Public RecDevID As Integer = -2
    Public RecDev(MaxRecDev, 6) As String ' 0=Manuf,1=Name,2=PNPDeviceID,3=ProductName
    Public iHangTime As Integer = CInt(GetSetting("FreeSCAN", "Settings", "HangTime", "3"))
    Public LastDirUsed As String = Nothing
    Public DefaultExt As String = ".mp3"
    Public RecDefaultDir As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
    Public RecDefaultName As String = "%hit% %time% %system% %chan% %name%"
    Public RecFileName As String = GetSetting("FreeSCAN", "Settings", "RecFile", RecDefaultName) 'Default format for recorded file name
    Public RecDirName As String = GetSetting("FreeSCAN", "Settings", "RecDir", RecDefaultDir) 'Dir to save files to
    Public FinalMP3Name As String = Nothing
    Public bOneDirPerDay As Boolean = MakeBoolean(GetSetting("FreeSCAN", "Settings", "OneDirPerDay", "1")) 'create a new dir every day
    Public bSysDir As Boolean = MakeBoolean(GetSetting("FreeSCAN", "Settings", "SysDir", "1")) 'create a dir for each system
    Public bWaveDeviceValid As Boolean = False
    Sub SetupRec()
        'Debug  - check where we are
        Dim pState As String
        pState = GetSetting("FreeSCAN", "Settings", "Stage", "3")

        'If state is not 3 (status OK), abort with error'
        If pState <> "3" Then
            Console.WriteLine("frmRecord.SetupRec:Aborting, pstate is bad")
            ' Exit Sub
        End If
        SaveSetting("FreeSCAN", "Settings", "Stage", "0")
        'Sets up recording variables & the dialog box

        Dim bFault As Boolean = False
        Dim DevID As Integer = 0
        Dim sBuff As String = Nothing
        Dim RecOn As Boolean = MakeBoolean(GetSetting("FreeSCAN", "Settings", "RecOn", "0"))
        Dim iSavedDevID As Integer = CInt(GetSetting("FreeSCAN", "Settings", "RecDevID", "-1"))
        'First, get a list of recording devices, if there are any
        Dim sCMDLine As String = VB.Command()

        If RecDirName = Nothing Then
            System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        End If

        txtDefaultDir.Text = RecDirName
        'Setup default record name




        txtFileName.Text = RecFileName

        'Setup option to make a new directory
        chkDayDir.Checked = bOneDirPerDay

        'Number of Seconds to record
        txtMaxRecTime.Text = CStr(MaxRecTime)

        'setup give each system its own directory
        chkSysDir.Checked = bSysDir

        'setup recording enabled by defualt
        chkRecord.Checked = RecOn

        'Setup default record dir
        If RecDirName = Nothing Then
            RecDirName = RecDefaultDir
        End If
        'setup Hang Time
        If iHangTime >= 0 And iHangTime <= 10 Then
            trkHangTime.Value = iHangTime
        End If
        sCMDLine = UCase(sCMDLine)
        If InStr(sCMDLine, "/NOSOUND") <> 0 Then
            Console.WriteLine("NOSOUND - Aborting sound setup")
            SaveSetting("FreeSCAN", "Settings", "Stage", "3")
            Exit Sub

        End If

        Try
            ReDim RecDev(6, MaxRecDev)
            cmbDevList.Items.Clear()
            ' Dim cap As NAudio.Wave.WaveInCapabilities
            If WaveIn.DeviceCount > 0 Then
                For DevID = 0 To WaveIn.DeviceCount - 1
                    RecDev(DevID, 0) = WaveIn.GetCapabilities(DevID).ProductName & "ID:" & DevID
                    Console.WriteLine("frmRecord.SetupRec:Found device " & RecDev(DevID, 0))
                    cmbDevList.Items.Add(RecDev(DevID, 0))
                    If DevID >= MaxRecDev Then
                        SaveSetting("FreeSCAN", "Settings", "Stage", "3")
                        Exit For
                    End If
                Next
            End If
            If cmbDevList.Items.Count = 0 Then
                SaveSetting("FreeSCAN", "Settings", "Stage", "3")
                Exit Sub
            End If

            'if a default recording device is already picked, recall it
            If (cmbDevList.Items.Count - 1) >= iSavedDevID And iSavedDevID > -1 Then

                cmbDevList.SelectedIndex = iSavedDevID
                RecDevID = iSavedDevID
            ElseIf cmbDevList.Items.Count > 0 Then
                cmbDevList.SelectedIndex = 0
                RecDevID = 0
            Else
                RecDevID = -1
            End If

        Catch err As ManagementException
            MessageBox.Show("An error occurred while detecting recording devices: " & err.Message)
            bFault = True
        End Try
        SaveSetting("FreeSCAN", "Settings", "Stage", "3")
    End Sub
    Function GenFileName() As String
        'This generates a recording file name ready to be fed back to the recording

        Dim sBuff1 As String
        Dim intCnt As Integer = 0
        Dim sDate As String = Format(Date.Now, "d")
        sDate = Replace(sDate, "/", "-")
        Dim sDirName As String = "\" & sDate
        Dim bFailDir As Boolean = False

        Dim sFileName As String = RecFileName
        Dim SysName As String = strRxSta(5)
        SysName = MakeItKosherFileName(SysName, False)
        Dim SysDir As String = "\" & SysName
        'See if there is existing data, if so pull it
        If Len(sFileName) < 3 Then
            sFileName = "No ID - %date% %time%" & DateTime.Now
        End If
        sFileName = Replace(sFileName, "%system%", strRxSta(5), , , CompareMethod.Text)
        sFileName = Replace(sFileName, "%site%", strRxSta(6), , , CompareMethod.Text)
        sFileName = Replace(sFileName, "%name%", strRxSta(7), , , CompareMethod.Text)
        sFileName = Replace(sFileName, "%chan%", strRxSta(1), , , CompareMethod.Text)
        sFileName = Replace(sFileName, "%date%", Format(Date.Now, "Short Date"), , , CompareMethod.Text)
        sFileName = Replace(sFileName, "%time%", Format(DateTime.Now, "HH-mm"), , , CompareMethod.Text)
        sFileName = Replace(sFileName, "%hit%", Format(frmCtlSetup.NumHits, "##0000"), , , CompareMethod.Text)
        sFileName = Replace(sFileName, "%nac%", strRxSta(13), , , CompareMethod.Text)
        sFileName = Replace(sFileName, "%uid%", strRxSta(11), , , CompareMethod.Text)
        sFileName = Replace(sFileName, "%rssi%", strRxSta(12), , , CompareMethod.Text)

        sFileName = MakeItKosherFileName(sFileName, False)

        'should one directory be made per day?
        If bOneDirPerDay Then
            'if so, does it already exist?
            If Not Directory.Exists(RecDirName & sDirName) Then
                'make it
                Try
                    Directory.CreateDirectory(RecDirName & sDirName)
                Catch ex As Exception
                    bFailDir = True
                End Try
            End If
            'Have we made it? if so append the path to sfilename
            If bFailDir Then
                sDirName = Nothing
            End If
        Else
            sDirName = Nothing
        End If

        'should one directory per system be made?
        If bSysDir And SysName <> "" Then
            'if so, does it already exist?
            If Not Directory.Exists(RecDirName & sDirName & SysDir) Then
                'make it
                Try
                    Directory.CreateDirectory(RecDirName & sDirName & SysDir)
                Catch ex As Exception
                    bFailDir = True
                End Try
            End If
            'Have we made it? if so append the path to sfilename
            If bFailDir Then
                SysDir = Nothing
            End If
        Else
            SysDir = Nothing
        End If
        ' LastDirUsed = RecDirName & sDirName & SysDir
        sFileName = RecDirName & sDirName & SysDir & "\" & sFileName
        'Finally, make sure this file doesn't already exist
        If FileExists(sFileName & DefaultExt) Then
            'Add a numerical notation to the file
            sBuff1 = sFileName & " (" & CStr(intCnt) & ")"
            Do Until FileExists(sBuff1 & DefaultExt) = False Or intCnt = 9999
                sBuff1 = sFileName & " (" & CStr(intCnt) & ")"
                intCnt += 1
            Loop
            sFileName = sBuff1
        End If
        sFileName &= DefaultExt

        GenFileName = sFileName
        FinalMP3Name = sFileName

    End Function
    Sub StartRec(ByVal sFileName As String, ByVal DevID As Integer)
        bWaveDeviceValid = False
        Try
            If waveInStream IsNot Nothing Then
                waveInStream.Dispose()
            End If
            'If no sound card available, abort
            If DevID < 0 Then
                DisableRec()
                '   Console.WriteLine("FrmRecord:StartRec:Aborting recording on device id" & DevID)
                Exit Sub
            End If

            If WaveIn.DeviceCount = 0 Then
                '    Console.WriteLine(DateTime.Now & " frmRecord:StartRec:Aborting - Device count is 0. Recording stays enabled")
                Exit Sub
            End If

            strDisplay(50) = "1"
            Dim recordingFormat As New WaveFormat(16000, 16, 1)

            writer = New WaveFileWriter(sFileName, recordingFormat)

            waveInStream = New WaveIn()
            waveInStream.DeviceNumber = DevID

            bWaveDeviceValid = True
            'waveInStream.GetMixerLine()
            waveInStream.WaveFormat = recordingFormat
            AddHandler waveInStream.DataAvailable, AddressOf waveInStream_DataAvailable
            waveInStream.StartRecording()

        Catch ex As Exception
            Console.WriteLine("frmRecord:StartRec:" & ex.Message.ToString)
            SaveSetting("FreeSCAN", "Settings", "RecOn", "0")
            DisableRec()
            MsgBox(ex.Message & " Recording has been disabled.")

        End Try

    End Sub

    Sub StopRec()
        'Stops the recording, encodes it as Mp3, deletes originaol temp file
        strDisplay(50) = "0"
        If blnDebug Then
            Console.WriteLine("Form2:StopRec:Entering with bwavedevicevalid in state " & bWaveDeviceValid)
        End If
        If blnRecFault Then Exit Sub
        Try

            If waveInStream IsNot Nothing Then
                waveInStream.StopRecording()
                waveInStream.Dispose()
                waveInStream = Nothing
            End If

            If bWaveDeviceValid And writer IsNot Nothing Then
                '  Console.WriteLine("Form2:StopRec:Closing Writer " & bWaveDeviceValid)
                writer.Close()
                writer = Nothing
            End If

            'attempt to encode as mp3
            If LastWavMade <> Nothing Then
                ' Console.WriteLine("Form2:StopRec:Starting Encoder " & bWaveDeviceValid)
                _lameShell.InFile = LastWavMade
                _lameShell.OutFile = FinalMP3Name
                _lameShell.Options = "-b 32"
                _lameShell.Start()
                prgRecLevel.Value = 0
            End If
            bWaveDeviceValid = False
        Catch ex As Exception
            SaveSetting("FreeSCAN", "Settings", "RecOn", "0")
            If Not blnRecFault Then MsgBox(ex.Message & " Error code #0x006502")
            chkRecord.Checked = False
            blnRecFault = True 'this is to keep a million msgboxes from popping up
        End Try
    End Sub

    Private Sub waveInStream_DataAvailable(ByVal sender As Object, ByVal e As WaveInEventArgs)
        If blnRecFault Then Exit Sub
        writer.Write(e.Buffer, 0, e.BytesRecorded)
        Dim secondsRecorded As Integer = CInt((writer.Length / writer.WaveFormat.AverageBytesPerSecond))
        Dim RecLevel As Double

        If secondsRecorded >= MaxRecTime And Not frmCtlSetup.bRecTimeout Then
            frmCtlSetup.bRecTimeout = True 'Make a note that this is a timeout and not to start recording again
            StopRec()
            Exit Sub
        Else
            ' progressbar1.Value = secondsRecorded
        End If

        'Volume level
        If Me.Visible Then
            Try
                Dim Smp() As Byte = e.Buffer
                Dim BytesRecorded As Integer = e.BytesRecorded
                Dim Cnt As Integer, Sample As Double
                For Cnt = 1 To UBound(Smp) Step 2
                    Sample += Smp(Cnt)
                Next Cnt
                RecLevel = (Sample / (e.BytesRecorded / 1))
                RecLevel = RecLevel * 1.5
                If RecLevel < 0 Then RecLevel = 0
                If RecLevel > 100 Then RecLevel = 100
                prgRecLevel.Value = CInt(RecLevel)
            Catch
                Console.WriteLine("Error setting volume level bar")
            End Try
        End If
        'Kill the recording of the COMport goes down
        If Not Form1.msc.IsOpen Then
            Call StopRec()
        End If
    End Sub

    Private Sub frmRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdApply.Enabled = True
        Call SetupRec()

    End Sub

    Private Sub cmdChooseSaveDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChooseSaveDir.Click
        'Lets the user pick a new default directory
        ChooseDir.ShowDialog()
        If ChooseDir.SelectedPath = Nothing Then Exit Sub
        txtDefaultDir.Text = ChooseDir.SelectedPath
    End Sub



    Private Sub cmbDevList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDevList.SelectedIndexChanged
        RecDevID = cmbDevList.SelectedIndex '- 1
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Visible = False
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        'Save settings
        Dim iTime As Integer
        Dim sBuff As String
        iTime = CInt(Val(txtMaxRecTime.Text))
        If iTime < 0 Or iTime > 999 Then
            MsgBox("Please enter a max recording time of between 1 and 999 seconds.")
            txtMaxRecTime.Text = "500"
            Exit Sub
        End If
        StopRec()
        SaveSetting("FreeSCAN", "Settings", "MaxRecTime", CStr(iTime))
        MaxRecTime = iTime
        sBuff = txtFileName.Text
        sBuff = Trim(sBuff)
        sBuff = MakeItKosherSilent(sBuff, 2)
        If Len(sBuff) < 4 Then
            MsgBox("Default format for file name is too short. It has been adjusted for you.")
            txtFileName.Text = RecDefaultName
            sBuff = RecDefaultName
        End If
        RecFileName = sBuff
        SaveSetting("FreeSCAN", "Settings", "RecFile", sBuff)
        'Save default device
        SaveSetting("FreeSCAN", "Settings", "RecDevID", CStr(RecDevID))

        'Save Default Dir
        RecDirName = txtDefaultDir.Text
        SaveSetting("FreeSCAN", "Settings", "RecDir", RecDirName)


        'Save daydir
        SaveSetting("FreeSCAN", "Settings", "OneDirPerDay", CStr(MakeBinary(CStr(chkDayDir.CheckState))))
        bOneDirPerDay = chkDayDir.Checked

        'should we create one dir per system?
        SaveSetting("FreeSCAN", "Settings", "SysDir", CStr(MakeBinary(CStr(chkSysDir.CheckState))))
        bSysDir = chkSysDir.Checked

        'setup enable/disable recording
        SaveSetting("FreeSCAN", "Settings", "RecOn", CStr(MakeBinary(CStr(chkRecord.CheckState))))

        'hang time
        iHangTime = trkHangTime.Value
        SaveSetting("FreeSCAN", "Settings", "Hangtime", CStr(iHangTime))
    End Sub

    Private Sub cmdClose_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.VisibleChanged
        If Me.Visible Then
            cmdApply.Enabled = True
        End If
    End Sub

    Private Sub cmdResetFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResetFileName.Click
        txtFileName.Text = RecDefaultName
    End Sub

    Private Sub cmdLoadFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadFileName.Click
        txtFileName.Text = RecFileName
    End Sub
    Function GetMaxDevID() As Integer
        Dim DevID As Integer = 0
        'Returns the highest valid device ID possible
        Try
            Dim searcher As New ManagementObjectSearcher( _
                  "root\CIMV2", _
                  "SELECT * FROM Win32_SoundDevice")
            Dim dt As DataTable = Audio.getSoundDeviceStructure

            For Each queryObj As ManagementObject In searcher.Get()
                DevID += 1
                If DevID >= MaxRecDev Then
                    Exit For
                End If
            Next
            searcher.Dispose()
        Catch err As ManagementException
            DevID = -2
            Console.WriteLine("frmRecord:GetMaxDevID:Inner exception:" & err.InnerException.ToString)
        End Try
        GetMaxDevID = DevID
    End Function

    Private Sub frmRecord_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            SetupRec()
        End If
    End Sub

    Private Sub txtDefaultDir_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDefaultDir.DoubleClick
        Dim sDir As String = txtDefaultDir.Text
        Dim ShellCode As String
        If sDir <> Nothing Then
            Try
                ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", sDir, "", "", 1))
            Catch ex As Exception

            End Try
        End If
    End Sub


    Public Sub DisableRec()

        SaveSetting("FreeSCAN", "Settings", "RecOn", "0")

        chkRecord.CheckState = 0
        My.Application.DoEvents()

    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        'Attempt to redetect soundcards...
        SaveSetting("FreeSCAN", "Settings", "Stage", "3")
        SetupRec()
    End Sub
End Class