Option Strict Off
Option Explicit On
Friend Class frmCOMPort
	Inherits System.Windows.Forms.Form
	Dim blnAbortAuto As Boolean
	
	
	Private Sub cmbApplyComPortSettings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbApplyComPortSettings.Click
        'transfer COM port settings to memory
        If cmbCOMPort.Text.Length = 4 Then
            RadioSetting(44) = Microsoft.VisualBasic.Right(cmbCOMPort.Text, 1)
        Else
            RadioSetting(44) = Microsoft.VisualBasic.Right(cmbCOMPort.Text, 2)
        End If
        RadioSetting(45) = cmbPortSpeed.Text
        'input checking
        If Val(RadioSetting(44)) < 1 Then
            RadioSetting(44) = CStr(1)
        End If
        Select Case RadioSetting(45)
            Case CStr(4800)
                'nothing
            Case CStr(9600)

            Case CStr(19200)

            Case CStr(38400)

            Case CStr(57600)

            Case CStr(115200)

            Case Else
                RadioSetting(45) = CStr(38400)
        End Select
        SaveSetting("FreeSCAN", "Settings", "Port", RadioSetting(44))
        SaveSetting("FreeSCAN", "Settings", "PortSpeed", RadioSetting(45))
        Me.Visible = False
        Select Case Form1.Visible
            Case True
                Form1.Enabled = True
                Form1.Activate()
                Form1.ShowComSettings()
            Case Else
                frmCommsDownload.ShowComSettings()
                If frmCtlSetup.Visible = False Then
                    frmCommsDownload.Visible = True
                    frmCommsDownload.Enabled = True
                    frmCommsDownload.Activate()
                Else
                    frmCtlSetup.Enabled = True
                    frmCtlSetup.Activate()
                End If
        End Select

        SaveSetting("FreeSCAN", "Settings", "Careful", CStr(chkBeCareful.CheckState))
    End Sub
	
	Private Sub cmdAbortAuto_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAbortAuto.Click
		blnAbortAuto = True
	End Sub
	
	Private Sub cmdAutoDetect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAutoDetect.Click
		If blnDebug = False Then On Error Resume Next
		'this subroutine automatically
		'detects com port settings, with any luck:(
        Dim COMIdx, lngSpeed As Long, strPort As String, SpdIDX As Integer
        Dim strResponse As String
        Dim blnSuccess As Boolean = False

        blnAbortAuto = False
        strPort = Nothing
        'generate list of COM ports
        Dim strSetting As String
        Call cmdRefresh_Click(cmdRefresh, New System.EventArgs())
        cmdRefresh.Enabled = False
        cmdAutoDetect.Enabled = False
        'if none found exit sub
        If cmbCOMPort.Items.Count = 0 Then
            cmdRefresh.Enabled = True
            cmdAutoDetect.Enabled = True
            Exit Sub
        End If
        For SpdIDX = cmbPortSpeed.Items.Count To 1 Step -1
            lngSpeed = Val(VB6.GetItemString(cmbPortSpeed, SpdIDX - 1))
            lblSpeed.Text = CStr(lngSpeed)
            For COMIdx = 1 To cmbCOMPort.Items.Count
                strPort = VB6.GetItemString(cmbCOMPort, COMIdx - 1)
                lblPort.Text = strPort


                lblStat.Text = "Trying..."
                My.Application.DoEvents()
                If Form1.msc.IsOpen = True Then Form1.msc.Close()
                With Form1.msc
                    .BaudRate = lngSpeed
                    .PortName = strPort
                    .Open()
                    .DiscardOutBuffer()
                    .DiscardInBuffer()
                    strResponse = SendCMD("MDL")
                    .Close()
                End With
                If strResponse = "-1" Then
                    lblStat.Text = "Fail"

                ElseIf strResponse = "" Then
                    lblStat.Text = "Fail"

                ElseIf InStr(SupportedScanners, strResponse, CompareMethod.Binary) <> 0 Or InStr(strResponse, "ERR") <> 0 Then
                    If strResponse = "ERR" & Chr(13) Then
                        Form1.msc.Open()

                        strResponse = SendCMD("MDL")
                        Form1.msc.Close()
                        lblStat.Text = "Found " & strResponse
                    Else
                        lblStat.Text = "Found " & strResponse
                    End If
                    blnSuccess = True

                    COMIdx = cmbCOMPort.Items.Count
                    SpdIDX = 1
                    strMDL = strResponse
                    Exit For
                End If
                If blnAbortAuto = True Then
                    SpdIDX = 1
                    COMIdx = cmbCOMPort.Items.Count
                    Exit For
                    blnSuccess = False
                End If
            Next
        Next
        If blnSuccess = True Then
            strResponse = CStr(MsgBox("FreeSCAN has detected the scanner and is ready to operate with it. Model Found:" & strMDL, MsgBoxStyle.OkOnly + MsgBoxStyle.Information))
            'save settings
            cmbCOMPort.Text = lblPort.Text
            cmbPortSpeed.Text = lblSpeed.Text
            Call cmbApplyComPortSettings_Click(Nothing, Nothing)

        Else
            strResponse = CStr(MsgBox("FreeSCAN could not establish communication with the scanner.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical))
        End If
		cmdRefresh.Enabled = True
		cmdAutoDetect.Enabled = True
	End Sub
	
	Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
		Call frmCOMPort_Load(Me, New System.EventArgs())
	End Sub
	
	
	Private Sub frmCOMPort_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Short
		On Error Resume Next
		'load default values into drop down boxes
		
		cmbCOMPort.Items.Clear()


        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbCOMPort.Items.Add(sp)
        Next

		cmbCOMPort.Text = RadioSetting(44)
        chkBeCareful.CheckState = CShort(GetSetting("FreeSCAN", "Settings", "Careful", CStr(1)))
		If cmbPortSpeed.Items.Count = 0 Then
			
			With cmbPortSpeed
				.Items.Add("4800")
				.Items.Add("9600")
				.Items.Add("19200")
				.Items.Add("38400")
				.Items.Add("57600")
				.Items.Add("115200")
			End With
			
			'set default values
			
			cmbPortSpeed.Text = RadioSetting(45)
		End If
		If cmbCOMPort.Items.Count > 0 Then
			cmbCOMPort.SelectedIndex = 0
		Else
			i = MsgBox("FreeSCAN was unable to detect any available COM ports. Make sure the port is not in use, it is COM15 or less, and that you have USB-COM Port drivers installed if applicable.", MsgBoxStyle.Critical, "Error")
		End If
		lblPort.Text = ""
		lblSpeed.Text = ""
		lblStat.Text = ""
	End Sub

    Private Sub cmbCOMPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCOMPort.SelectedIndexChanged

    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click

        'If Not blnDebug Then On Error GoTo Aborted
        If cmbCOMPort.SelectedIndex = -1 Then
            MsgBox("FreeSCAN cannot test the COM port until one is selected.", MsgBoxStyle.Critical)
        End If
        If Form1.msc.IsOpen = True Then Form1.msc.Close()
        With Form1.msc
            .BaudRate = cmbPortSpeed.SelectedItem
            .PortName = cmbCOMPort.SelectedItem
            .Open()
            strMDL = SendCMD("MDL")
            .Close()
        End With
        If InStr(SupportedScanners, strMDL) <> 0 And strMDL <> Nothing Then
            MsgBox("FreeSCAN has recognized the scanner and is ready to operate with it. Model found:" & strMDL, MsgBoxStyle.Information)
        Else
            MsgBox("FreeSCAN could not communicate with the scanner, or the scanner is not recognized as being compatible. Response received: " & strMDL, MsgBoxStyle.Critical)
        End If
        Exit Sub
Aborted:
        If Form1.msc.IsOpen = True Then Form1.msc.Close()
        MsgBox("An error has occured and FreeSCAN is unable to communicate with the scanner.", MsgBoxStyle.Critical)
    End Sub
End Class