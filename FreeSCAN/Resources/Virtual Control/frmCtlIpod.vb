Option Strict Off
Option Explicit On
Friend Class frmCtlIpod
	Inherits System.Windows.Forms.Form
	
	Dim strFontName As String
	Dim intFontSize As Integer
	Dim blnFontItalic As Boolean
	Dim blnFontBold, blnFontUl As Boolean
	Dim strGrd As String
	Dim dblFontColour As Double
	Dim intKeyHold(100) As Integer
	Dim blnBusy As Boolean
	Dim intLastMode As Integer
	Dim intCycle As Integer
	Dim intKeyID As Integer
	Dim dblLastJump As Double ' last frequnecy jumped to
	
	Sub LetCMDFinish()
		Dim intVal As Single
		Do Until strUserCMD = "" Or intVal = 300000
			intVal = intVal + 1
			System.Windows.Forms.Application.DoEvents()
		Loop 
	End Sub
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Visible = False
		frmCtlSetup.Visible = True
		Call cmdStopCom_Click(cmdStopCom, New System.EventArgs())
	End Sub
	
	
	Private Sub cmdLink_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLink.Click
		Call frmCtlSetup.StartCOMMS()
		DrawWin()
	End Sub
	
	Private Sub cmdStopCom_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStopCom.Click
		
		Call frmCtlSetup.StopCOMMS()
		DrawWin()
	End Sub
	
	Private Sub Timer1_Timer()
		
	End Sub
	Sub DrawWin()
		'begin label
		Dim intCtl, intCnt As Integer
        Dim strBuff As String
		Dim blnTGID As Boolean
		blnBusy = True
		If strRxSta(19) = "1" Then
			If picLowBatt.Visible = True Then
				picLowBatt.Visible = False
			Else
				picLowBatt.Visible = False
			End If
		Else
			picLowBatt.Visible = False
		End If
		If intCycle = 100 Then
			intCycle = 0
		Else
			intCycle = intCycle + 1
		End If
		For intCtl = 0 To 5
            If strDisplay(32) = "1" And intCtl = 1 And instr(strDisplay(1), "PRI") = 0 Then 'global pri mode on
                strDisplay(1) = strDisplay(1) & "PRI "
            End If
            If intCtl = 4 And strDisplay(30) = "1" Then 'channel pri mode
                strDisplay(4) = strDisplay(4) & " PRI"
            End If
            lblDisp(intCtl).Text = strDisplay(intCtl + 1)
            If instr(strDisplay(intCtl + 9), "*") Then
                lblDisp(intCtl).Font = VB6.FontChangeBold(lblDisp(intCtl).Font, True)
            Else
                lblDisp(intCtl).Font = VB6.FontChangeBold(lblDisp(intCtl).Font, False)
            End If
			
			If intCtl < 3 Then
				
				strBuff = ""
				'    For intCtl1 = 1 To 16
				'        If Mid(strDisplay(10 + intCtl), intCtl1, 1) = "*" Then
				'            strBuff = strBuff & "-"
				'        Else
				'            strBuff = strBuff & " "
				'        End If
				'    Next intCtl1
				'    lblCursor(intCtl) = strBuff
				
				strBuff = ""
			End If
		Next intCtl
		
		lblDisp(7).Text = strDisplay(31)
		picPause.Visible = Val(strDisplay(21))
		lblLO.Visible = Val(strDisplay(27))
		If strDisplay(25) = "1" Then
			picUpArrow.Visible = True
		Else
			picUpArrow.Visible = False
		End If
		If strDisplay(26) = "1" Then
			picDownArrow.Visible = True
		Else
			picDownArrow.Visible = False
		End If
		
		strBuff = strRxSta(1)
		If Len(strBuff) = 8 Then
			For intCnt = 1 To 8
				
				If IsNumeric(Mid(strBuff, intCnt, 1)) = False Then
					blnTGID = True
				End If
			Next intCnt
		Else
			blnTGID = True
		End If
		If blnTGID = False Then
			
			strBuff = Val(strBuff) / 10000
			
            strBuff = Format(strBuff, "###0.0000") & " MHz"
			
			lblDisp(6).Text = strBuff
			
		ElseIf strBuff <> "" Then 
			
			lblDisp(6).Text = "ID: " & strBuff
		Else
			lblDisp(6).Text = ""
		End If
		'setup squelch
		Select Case Val(strRxSta(8))
            Case 0
                PicLEDON.Visible = True
            Case Else
                PicLEDON.Visible = False
        End Select
		
		'If strRxSta(7) <> "" Then
		'    If frmCtlIpod.Caption <> strRxSta(7) Then
		'        frmCtlIpod.Caption = strRxSta(7)
		'    End If
		'ElseIf Len(strRxSta(1)) > 1 Then
		'    strBuff = strRxSta(1)
		'    strBuff = Val(strBuff) / 10000
		'    strBuff = Format(strBuff, "###0.0000") & "MHz"
		'    If frmCtlIpod.Caption <> strBuff Then
		'        frmCtlIpod.Caption = strBuff
		'    End If
		'Else
		'    If frmCtlIpod.Caption <> "iSCAN" Then
		'        frmCtlIpod.Caption = "iSCAN"
		'   End If
		'End If
		
		'Function
		If strDisplay(28) = "1" Then
			If lblDisp(8).Text <> "FUNC" Then
				lblDisp(8).Text = "FUNC"
			End If
			lblDisp(8).Visible = True
		Else
			lblDisp(8).Visible = False
		End If
		
		'Close Call
		If strDisplay(22) = "1" Then
			PicCC.Visible = True
		Else
			PicCC.Visible = False
		End If
		'Volume Level
		'If intCycle = 1 Then
		'    sldVol.Value = Val(strDisplay(42))
		'    sldSql.Value = Val(strDisplay(43))
		'End If
		blnBusy = False
		'battery
		picLowBatt.Visible = Val(strDisplay(19))
		If picLowBatt.Visible = False Then
			If Val(strDisplay(39)) >= 90 Then '100% full
				picBatt(3).Visible = True
				picBatt(0).Visible = False
				picBatt(1).Visible = False
				picBatt(2).Visible = False
			ElseIf Val(strDisplay(39)) >= 60 Then  '75% full
				picBatt(2).Visible = True
				picBatt(0).Visible = False
				picBatt(1).Visible = False
				picBatt(3).Visible = False
			ElseIf Val(strDisplay(39)) > 30 Then  '50% full
				picBatt(1).Visible = True
				picBatt(0).Visible = False
				picBatt(3).Visible = False
				picBatt(2).Visible = False
			ElseIf Val(strDisplay(39)) <= 30 Then  'less than 50% full
				picBatt(0).Visible = True
				picBatt(3).Visible = False
				picBatt(1).Visible = False
				picBatt(2).Visible = False
			End If
		Else 'flash low bat warning
			For intCtl = 0 To 3
				picBatt(intCtl).Visible = False
			Next intCtl
		End If
		'setup for signal level
		
		strBuff = Val(strDisplay(29))
		
		If Val(strBuff) = 0 Then
			For intCtl = 0 To picSigLvl.Count - 1
				picSigLvl(intCtl).Visible = False
			Next intCtl
			
		ElseIf Val(strBuff) = 1 Then 
			picSigLvl(0).Visible = True
			picSigLvl(1).Visible = False
			picSigLvl(2).Visible = False
			picSigLvl(3).Visible = False
			picSigLvl(4).Visible = False
			
		ElseIf Val(strBuff) = 2 Then 
			picSigLvl(1).Visible = True
			picSigLvl(0).Visible = False
			picSigLvl(2).Visible = False
			picSigLvl(3).Visible = False
			picSigLvl(4).Visible = False
			
		ElseIf Val(strBuff) = 3 Then 
			picSigLvl(2).Visible = True
			picSigLvl(1).Visible = False
			picSigLvl(0).Visible = False
			picSigLvl(3).Visible = False
			picSigLvl(4).Visible = False
			
		ElseIf Val(strBuff) = 4 Then 
			picSigLvl(3).Visible = True
			picSigLvl(1).Visible = False
			picSigLvl(2).Visible = False
			picSigLvl(0).Visible = False
			picSigLvl(4).Visible = False
			
		ElseIf Val(strBuff) = 5 Then 
			picSigLvl(4).Visible = True
			picSigLvl(1).Visible = False
			picSigLvl(2).Visible = False
			picSigLvl(3).Visible = False
			picSigLvl(0).Visible = False
		End If
	End Sub
	Private Sub frmCtlIpod_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If blnDebug = False Then On Error Resume Next
		Dim intCnt As Integer
		blnFontBold = CBool(GetSetting("FreeSCAN", "Settings", "CON1FontBold", "False"))
		strFontName = GetSetting("FreeSCAN", "Settings", "CON1Font", "Fixedsys")
		intFontSize = Val(GetSetting("FreeSCAN", "Settings", "CON1FontSize", "12"))
		blnFontUl = CBool(GetSetting("FreeSCAN", "Settings", "CON1FontUL", "False"))
		blnFontItalic = CBool(GetSetting("FreeSCAN", "Settings", "CON1FontItalic", "False"))
		dblFontColour = CDbl(GetSetting("FreeSCAN", "Settings", "CON1FontColour", CStr(&H0)))
		ApplyFontStyle()
		'    For intCnt = 0 To imgKey.Count - 1
		'        imgKey(intCnt) = PicKeyUp(intCnt)
		'    Next intCnt
	End Sub
	
	'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_WARNING: frmCtlIpod event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Form_Terminate_Renamed()
		Call cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub
	
	Private Sub frmCtlIpod_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Call cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub
	
	Private Sub imgKey_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles imgKey.Click
		Dim index As Short = imgKey.GetIndex(eventSender)
		'process a button pushed by the user
		Dim strKey As String
        strkey=""
		intKeyID = index
		'imgKey(Index).Enabled = False
		If index < 10 Then 'numbers are sent directly
			strKey = index & ",P"
		Else
			Select Case index
				Case 19 'menu
					strKey = "M,P"
				Case 28 'func
					strKey = "F,L"
				Case 10 'hold
					strKey = "H,P"
				Case 11 'scan
					strKey = "S,P"
				Case 12 'lo
					strKey = "L,P"
				Case 13 'power
					strKey = "P,P"
				Case 14 '.no
					strKey = ".,P"
				Case 15 '.yes
					strKey = "E,P"
				Case 16 ' +vol
					strKey = ">,P"
				Case 17 ' push vol
					strKey = "^,P"
					'       If intKeyHold(17) = 1 Then 'unpush volume
					'           strKey = "^,R"
					'           intKeyHold(17) = 0
					'       Else
					'           strKey = "^,H"
					'           intKeyHold(17) = 1
					'       End If
				Case 18 '-vol
					strKey = "<,P"
				Case 20 ' hold function key
					If intKeyHold(20) = 1 Then 'unpush
						strKey = "F,R"
						intKeyHold(20) = 0
					Else
						strKey = "F,H"
						intKeyHold(20) = 1
					End If
				Case 21 'cc on
					strUserCMD = "KEY,F,H"
					LetCMDFinish()
					strUserCMD = "KEY,H,P"
					LetCMDFinish()
					strUserCMD = "KEY,F,R"
					LetCMDFinish()
				Case 22 'pri on
					strUserCMD = "KEY,F,H"
					LetCMDFinish()
					strUserCMD = "KEY,1,P"
					LetCMDFinish()
					strUserCMD = "KEY,F,R"
					LetCMDFinish()
				Case 23 'wx
					strUserCMD = "KEY,F,H"
					LetCMDFinish()
					strUserCMD = "KEY,2,P"
					LetCMDFinish()
					strUserCMD = "KEY,F,R"
					LetCMDFinish()
				Case 24 'srch
					strUserCMD = "KEY,F,H"
					LetCMDFinish()
					strUserCMD = "KEY,S,P"
					LetCMDFinish()
					strUserCMD = "KEY,F,R"
					LetCMDFinish()
				Case 25 ' recall
					strUserCMD = "KEY,F,H"
					LetCMDFinish()
					strUserCMD = "KEY,7,P"
					LetCMDFinish()
					strUserCMD = "KEY,F,R"
					LetCMDFinish()
				Case 26 ' rev
					strUserCMD = "KEY,F,H"
					LetCMDFinish()
					strUserCMD = "KEY,.,P"
					LetCMDFinish()
					strUserCMD = "KEY,F,R"
					LetCMDFinish()
				Case 27 'att
					strUserCMD = "KEY,F,H"
					LetCMDFinish()
					strUserCMD = "KEY,E,P"
					LetCMDFinish()
					strUserCMD = "KEY,F,R"
					LetCMDFinish()
					
			End Select
		End If
		strUserCMD = "KEY," & strKey
		'imgKey(Index).Enabled = True
	End Sub
	
	Private Sub imgKey_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgKey.MouseDown
		Dim button As Short = eventArgs.Button \ &H100000
		Dim shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim index As Short = imgKey.GetIndex(eventSender)
		'imgKey(Index).Picture = picKeyDown(Index).Picture
	End Sub
	
	Private Sub imgKey_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgKey.MouseUp
		Dim button As Short = eventArgs.Button \ &H100000
		Dim shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim index As Short = imgKey.GetIndex(eventSender)
		'imgKey(Index).Picture = PicKeyUp(Index).Picture
	End Sub
	

	
	Public Sub mnuEditExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditExit.Click
		Call cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub
	

	Sub ApplyFontStyle()
		If blnDebug = False Then On Error Resume Next
		Dim intCnt As Integer
		For intCnt = 0 To lblDisp.Count - 1
			With lblDisp(intCnt)
				.Font = VB6.FontChangeName(.Font, strFontName)
				.Font = VB6.FontChangeBold(.Font, blnFontBold)
				.Font = VB6.FontChangeItalic(.Font, blnFontItalic)
				.Font = VB6.FontChangeUnderline(.Font, blnFontUl)
				.Font = VB6.FontChangeSize(.Font, intFontSize)
				.ForeColor = System.Drawing.ColorTranslator.FromOle(dblFontColour)
			End With
			If intCnt < 3 Then
				' With lblCursor(intCnt)
				'     .Font = strFontName
				'     .FontSize = intFontSize
				' End With
			End If
		Next intCnt
		
		
		lblDisp(8).Font = VB6.FontChangeSize(lblDisp(8).Font, MakePositive(intFontSize - 4))
		
		
		lblDisp(4).Font = VB6.FontChangeSize(lblDisp(4).Font, MakePositive(intFontSize - 2))
		
		
		lblDisp(5).Font = VB6.FontChangeSize(lblDisp(5).Font, MakePositive(intFontSize - 2))
		
		
		lblDisp(6).Font = VB6.FontChangeSize(lblDisp(6).Font, MakePositive(intFontSize - 2))
		
		' For intCnt = 0 To 2
		'     lblCursor(intCnt).Top = lblDisp(intCnt + 1).Top + lblDisp(intCnt).Height + 10
		' Next intCnt
	End Sub
	



	Public Sub mnuQK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQK.Click
		Dim index As Short = mnuQK.GetIndex(eventSender)
		Call imgKey_Click(imgKey.Item(index), New System.EventArgs())
	End Sub
	

    Private Sub JumpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JumpToolStripMenuItem.Click
        FreqJump.Visible = True
    End Sub

    Private Sub EnableLoggingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableLoggingToolStripMenuItem.Click
        If blnEnableLog = False Then
            EnableLoggingToolStripMenuItem.Checked = True
            blnEnableLog = True
        Else
            EnableLoggingToolStripMenuItem.Checked = False
            blnEnableLog = False
        End If
    End Sub

    Private Sub OpenLogWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLogWindowToolStripMenuItem.Click
        frmLog.Visible = True
    End Sub

    Private Sub LockoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockoutToolStripMenuItem.Click
        strUserCMD = "KEY,L,P"
    End Sub

    Private Sub EstablishLinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstablishLinkToolStripMenuItem.Click
        Call cmdLink_Click(cmdLink, New System.EventArgs())
    End Sub

    Private Sub DisableLinkToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DisableLinkToolStripMenuItem.Click
        Call cmdStopCom_Click(cmdStopCom, New System.EventArgs())
    End Sub

    Private Sub ChooseFontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseFontToolStripMenuItem.Click
        If blnDebug = False Then On Error Resume Next
        frmCtlSetup.Timer_Renamed.Enabled = False
        Dim intCnt As Integer
        'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        With FontDialog1
            .Font = VB6.FontChangeName(.Font, strFontName)
            .Font = VB6.FontChangeBold(.Font, blnFontBold)
            .Font = VB6.FontChangeItalic(.Font, blnFontItalic)
            .Font = VB6.FontChangeUnderline(.Font, blnFontUl)
            .Font = VB6.FontChangeSize(.Font, intFontSize)
            .ShowDialog()
            strFontName = .Font.Name
            frmCtlWin.CheckFont()
            blnFontBold = .Font.Bold
            blnFontItalic = .Font.Italic
            blnFontUl = .Font.Underline
            intFontSize = .Font.Size
        End With

        SaveSetting("FreeSCAN", "Settings", "CON1FontBold", CStr(blnFontBold))
        SaveSetting("FreeSCAN", "Settings", "CON1Font", strFontName)
        SaveSetting("FreeSCAN", "Settings", "CON1FontSize", CStr(intFontSize))
        SaveSetting("FreeSCAN", "Settings", "CON1FontUL", CStr(blnFontUl))
        SaveSetting("FreeSCAN", "Settings", "CON1FontItalic", CStr(blnFontItalic))

        ApplyFontStyle()
        frmCtlSetup.Timer_Renamed.Enabled = True
    End Sub

    Private Sub FontColourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontColourToolStripMenuItem.Click
        frmCtlSetup.Timer_Renamed.Enabled = False

        With CommonDialogColor
            .Color = System.Drawing.ColorTranslator.FromOle(dblFontColour)
            .ShowDialog()
            dblFontColour = System.Drawing.ColorTranslator.ToOle(.Color)
        End With
        SaveSetting("FreeSCAN", "Settings", "CON1FontColour", CStr(dblFontColour))
        ApplyFontStyle()
        frmCtlSetup.Timer_Renamed.Enabled = True
    End Sub

    Private Sub QK0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QK0.Click
        strUserCMD = "KEY,0,P"
    End Sub

    Private Sub QK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QK1.Click
        strUserCMD = "KEY,1,P"
    End Sub

    Private Sub QK2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QK2.Click
        strUserCMD = "KEY,2,P"
    End Sub

    Private Sub QK3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QK3.Click
        strUserCMD = "KEY,3,P"
    End Sub

    Private Sub QK4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QK4.Click
        strUserCMD = "KEY,4,P"
    End Sub

    Private Sub Qk5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qk5.Click
        strUserCMD = "KEY,5,P"
    End Sub

    Private Sub QK6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QK6.Click
        strUserCMD = "KEY,6,P"
    End Sub

    Private Sub QK7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QK7.Click
        strUserCMD = "KEY,7,P"
    End Sub

    Private Sub QK8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QK8.Click
        strUserCMD = "KEY,8,P"
    End Sub

    Private Sub QK9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QK9.Click
        strUserCMD = "KEY,9,P"
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Opacity = 1
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Opacity = 0.75
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Opacity = 0.5
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Me.Opacity = 0.3
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        With AlwaysOnTopToolStripMenuItem
            If .Checked = True Then
                .Checked = False
                Me.TopMost = False
            Else
                .Checked = True
                Me.TopMost = True
            End If
        End With
    End Sub

    Private Sub MainMenu1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MainMenu1.ItemClicked

    End Sub

    Private Sub SetupAudioRecordingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupAudioRecordingToolStripMenuItem.Click
        frmRecord.Visible = True
    End Sub
End Class