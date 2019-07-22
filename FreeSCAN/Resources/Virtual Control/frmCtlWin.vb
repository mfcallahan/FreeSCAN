Option Strict Off
Option Explicit On
Friend Class frmCtlWin
	Inherits System.Windows.Forms.Form
	
	Dim strFontName As String
	Dim intFontSize As Integer
	Dim blnFontItalic As Boolean
	Dim blnFontBold, blnFontUl As Boolean
	Dim strGrd As String
	Dim dblFontColour As Double
	Dim intKeyHold(100) As Integer
	Dim blnBusy As Boolean
	Dim intCycle As Integer
	Dim intKeyID As Integer
	Dim dblLastJump As Double ' last frequnecy jumped to
    Dim strTimeoutTitle As String
    Dim blnHaltChange As Boolean
	Private Sub cmdClose_Click()
		
	End Sub
	
	Private Sub cmdLink_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLink.Click
		Call frmCtlSetup.StartCOMMS()
		Refresh()
	End Sub
	
	Private Sub cmdStopCom_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStopCom.Click
		
		Call frmCtlSetup.StopCOMMS()
		Refresh()
	End Sub
	
	Sub DrawWin()

		If blnDebug = False Then On Error Resume Next
		Dim intCtl1, intCtl, intCnt As Integer
        Dim strBuff As String
		Dim blnTGID As Boolean
		blnBusy = True
		
		If frmCtlSetup.BaseStation(strMDL) = True Then
            BGPS.Enabled = True
            BPRI.Enabled = True
            BWX.Enabled = True
            BPWR.Visible = False
		Else
            BGPS.Enabled = False
            BPRI.Enabled = False
            BWX.Enabled = False
            BPWR.Visible = True
		End If
		
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

                lblCursor(intCtl).Text = strBuff

                strBuff = ""
            End If
        Next intCtl
        intCnt = Val(strDisplay(49))
        If intCnt < 1025 And intCnt >= 0 Then
            prgSignal.Value = Val(strDisplay(49))
        Else
            prgSignal.Value = Val(strDisplay(29)) * 204
        End If
        lblDisp(7).Text = strDisplay(31)
        lblHold.Visible = Val(strDisplay(21))
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

        If instr(strBuff, ".") <> 0 Then
            blnTGID = False
        Else
            blnTGID = True
        End If
        If blnTGID = False Then

            If Val(strBuff) > 1200 Then

                strBuff = Val(strBuff) / 10000
            End If

            If Val(strBuff) > 0 And Val(strBuff) < 1 Then

                strBuff = Val(strBuff) * 10000
            End If

            strBuff = (Val(strBuff).ToString("###0.0000")) & " MHz"

            lblDisp(6).Text = strBuff

        ElseIf strBuff <> "" Then

            lblDisp(6).Text = "ID: " & strBuff
        Else
            lblDisp(6).Text = ""
        End If
        'setup squelch
        Select Case strRxSta(8)
            Case "0"
                PicLEDON.Visible = True
                picLEDOff.Visible = False
            Case Else
                picLEDOff.Visible = True
                PicLEDON.Visible = False
        End Select

        If strRxSta(7) <> "" Then
            If Me.Text <> strRxSta(7) Then
                Me.Text = strRxSta(7)
            End If
        ElseIf Len(strRxSta(1)) > 1 Then

            strBuff = strRxSta(1)

            If Val(strBuff) > 1200 Then

                strBuff = Val(strBuff) / 10000
            End If

            strBuff = Val(strBuff).ToString("###0.0000") & "MHz"

            If Me.Text <> strBuff Then

                Me.Text = strBuff
            End If
        Else
            If Me.Text <> frmCtlSetup.VCTitle Then
                Me.Text = frmCtlSetup.VCTitle
            End If
        End If
        prgBat.Value = Val(strDisplay(39))
        lblBat.Text = Val(strDisplay(38)).ToString("#0.0") & " V"
        'apco
        If Val(strDisplay(41)) <= prgP25.Maximum Then
            prgP25.Value = Val(strDisplay(41))
        Else
            prgP25.Value = prgP25.Maximum
        End If
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
        If blnHaltChange = False Then
            intCtl = MakePositive(Val(strDisplay(42)))
            If intCtl >= sldVol.Minimum And intCtl <= sldVol.Maximum Then
                sldVol.Value = intCtl
            End If

            intCtl = MakePositive(Val(strDisplay(43)))
            If intCtl >= sldSql.Minimum And intCtl <= sldSql.Maximum Then
                sldSql.Value = intCtl

            End If
            blnBusy = False
            picLowBatt.Visible = MakeBinary(strDisplay(19))

            'Audio recording
            If GetSetting("FreeSCAN", "Settings", "RecOn") = "0" Then
                'is recording disabled? Then turn off all the graphics
                PicRecord.Visible = False
                PicRecordOff.Visible = False
            ElseIf strDisplay(50) = "1" Then
                PicRecord.Visible = True
                PicRecordOff.Visible = False
            Else
                PicRecordOff.Visible = True
                PicRecord.Visible = False
            End If
        End If
            'Negative delay
            If frmCtlSetup.blnNegDelay And frmCtlSetup.sngScanTime <> 0 Then
                lblNegDelay.Visible = True
                With frmCtlSetup
                    lblNegDelay.Text = .sngScanTime
                    If .sngMaxScanTime - .sngScanTime < 5 Then
                        lblNegDelay.ForeColor = Color.Red
                    Else
                        lblNegDelay.ForeColor = Color.Green
                    End If
                    lblNegDelay.Text = CStr(Int(.sngMaxScanTime - .sngScanTime) + 1)
                End With


            ElseIf lblNegDelay.Visible Then

                lblNegDelay.Visible = False
            End If

    End Sub


    'UPGRADE_WARNING: Form event frmCtlWin.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmCtlWin_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        mnuEnableLog.Checked = blnEnableLog
    End Sub

    Private Sub frmCtlWin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If blnDebug = False Then On Error Resume Next
        Dim intCnt As Integer
        blnFontBold = CBool(GetSetting("FreeSCAN", "Settings", "CONFontBold", "False"))
        strFontName = GetSetting("FreeSCAN", "Settings", "CONFont", "MS Sans Serif")
        intFontSize = Val(GetSetting("FreeSCAN", "Settings", "CONFontSize", "8"))
        blnFontUl = CBool(GetSetting("FreeSCAN", "Settings", "CONFontUL", "False"))
        blnFontItalic = CBool(GetSetting("FreeSCAN", "Settings", "CONFontItalic", "False"))
        dblFontColour = CDbl(GetSetting("FreeSCAN", "Settings", "CONFontColour", CStr(&HC000)))
        ApplyFontStyle()



    End Sub



    'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    'UPGRADE_WARNING: frmCtlWin event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub Form_Terminate_Renamed()
        Call mnuEditExit_Click(mnuEditExit, New System.EventArgs())
    End Sub

    Private Sub frmCtlWin_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call mnuEditExit_Click(mnuEditExit, New System.EventArgs())
    End Sub

    Private Sub imgKey(ByVal SelKey As String)
        Dim index As Integer = 0
        'process a button pushed by the user
        If blnDebug = False Then On Error Resume Next
        Dim strKey As String
        strKey = SelKey

        If index < 10 Then 'numbers are sent directly
            strKey = index & ",P"
        Else
            Select Case index
                Case 19 'menu

                Case 28 'func

                Case 10 'hold

                Case 11 'scan

                Case 12 'lo

                Case 13 'power

                Case 14 '.no

                Case 15 '.yes

                Case 16 ' +vol

                Case 17 ' push vol

                Case 18 '-vol

                Case 20 ' hold function key
 
                Case 22 'pri on

                Case 23 'wx

                Case 24 'GPS

                Case 25 ' push sql
            End Select
        End If
        strUserCMD = "KEY," & strKey

    End Sub



    Public Sub mnuEditExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditExit.Click
        Call cmdStopCom_Click(cmdStopCom, New System.EventArgs())

        Me.Visible = False
        frmCtlSetup.Visible = True
    End Sub

    Public Sub mnuEditFont_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditFont.Click
        If blnDebug = False Then On Error Resume Next
        frmCtlSetup.Timer_Renamed.Enabled = False
        Dim intCnt As Integer
         With FontDialog1
            .AllowScriptChange = True
            .Font = VB6.FontChangeName(.Font, strFontName)
            .Font = VB6.FontChangeBold(.Font, blnFontBold)
            .Font = VB6.FontChangeItalic(.Font, blnFontItalic)
            .Font = VB6.FontChangeUnderline(.Font, blnFontUl)
            .Font = VB6.FontChangeSize(.Font, intFontSize)
            .ShowDialog()
            strFontName = .Font.Name
            CheckFont()
            blnFontBold = .Font.Bold
            blnFontItalic = .Font.Italic
            blnFontUl = .Font.Underline
            intFontSize = .Font.Size
        End With

        SaveSetting("FreeSCAN", "Settings", "CONFontBold", CStr(blnFontBold))
        SaveSetting("FreeSCAN", "Settings", "CONFont", strFontName)
        SaveSetting("FreeSCAN", "Settings", "CONFontSize", CStr(intFontSize))
        SaveSetting("FreeSCAN", "Settings", "CONFontUL", CStr(blnFontUl))
        SaveSetting("FreeSCAN", "Settings", "CONFontItalic", CStr(blnFontItalic))

        ApplyFontStyle()

        frmCtlSetup.Timer_Renamed.Enabled = True
    End Sub
    Public Sub CheckFont()
        'checks to make sure the user didn't pick a silly font like wingdings
        Dim Response As Integer
        If instr(strFontName, "Wingdings") <> 0 Then
            Response = MsgBox("You have selected the Wingdings font, which is a silly and somewhat inappropiate choice. Would you like FreeSCAN to automatically select a more reasonable and average font for you?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Odd font choice")
            If Response = 6 Then 'yes?
                strFontName = "Arial"
            End If
        End If
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
				With lblCursor(intCnt)
					.Font = VB6.FontChangeName(.Font, strFontName)
					.Font = VB6.FontChangeSize(.Font, intFontSize)
				End With
			End If
		Next intCnt
		lblHold.ForeColor = System.Drawing.ColorTranslator.FromOle(dblFontColour)
		For intCnt = 0 To 2
			lblCursor(intCnt).Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(lblDisp(intCnt + 1).Top) + VB6.PixelsToTwipsY(lblDisp(intCnt).Height) + 10)
		Next intCnt
	End Sub
	
	Public Sub mnuEditFontColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditFontColor.Click
		frmCtlSetup.Timer_Renamed.Enabled = False
	   With ColorDialog1
            Try
                .Color = System.Drawing.ColorTranslator.FromOle(dblFontColour)
                .ShowDialog()
                dblFontColour = System.Drawing.ColorTranslator.ToOle(.Color)
            Catch ex As Exception
                MsgBox("Error, unable to set selected color")
            End Try

        End With
		SaveSetting("FreeSCAN", "Settings", "CONFontColour", CStr(dblFontColour))
		ApplyFontStyle()
		frmCtlSetup.Timer_Renamed.Enabled = True
	End Sub
	
	
    Public Sub mnuEditJump_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        FreqJump.Visible = True
    End Sub
	
	Public Sub mnuEditViewLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditViewLog.Click
		frmLog.Visible = True
	End Sub
	
	Public Sub mnuEnableLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEnableLog.Click
		If blnEnableLog = False Then
			mnuEnableLog.Checked = True
			blnEnableLog = True
		Else
			mnuEnableLog.Checked = False
			blnEnableLog = False
		End If
	End Sub
	
	Public Sub mnuJCC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuJCC.Click
		strUserCMD = "JPM,CC_MODE"
	End Sub
	
	Public Sub mnuJCust_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuJCust.Click
		strUserCMD = "JPM,CTM_MODE"
	End Sub
	
	Public Sub mnuJFTO_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuJFTO.Click
		strUserCMD = "JPM,FTO_MODE"
	End Sub
	
	Public Sub mnuJScan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuJScan.Click
		strUserCMD = "JPM,SCN_MODE"
	End Sub
	
	Public Sub mnuJServ_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuJServ.Click
		Dim index As Short = mnuJServ.GetIndex(eventSender)
        Dim strBuff As String
        strBuff = Nothing
		Select Case index
			Case 1
				strBuff = "PublicSafety"
			Case 2
				strBuff = "News"
			Case 3
				strBuff = "HAM"
			Case 4
				strBuff = "Marine"
			Case 5
				strBuff = "Railroad"
			Case 6
				strBuff = "Air"
			Case 7
				strBuff = "CB"
            Case 8
                strBuff = "FRS/GMRS"
			Case 9
				strBuff = "Racing"
			Case 10
				strBuff = "TV"
			Case 11
				strBuff = "FM"
			Case 12
				strBuff = "Special"
			Case 13
				strBuff = "Military"
				
		End Select
		strUserCMD = "JPM,SVC_MODE," & strBuff
	End Sub
	

	
	Public Sub mnuToolsNegDlyEnable_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsNegDlyEnable.Click
		If mnuToolsNegDlyEnable.Checked = True Then
			mnuToolsNegDlyEnable.Checked = False
		Else
			mnuToolsNegDlyEnable.Checked = True
		End If
		frmCtlSetup.blnNegDelay = mnuToolsNegDlyEnable.Checked
		SaveSetting("FreeSCAN", "Settings", "EnableNegDelay", CStr(mnuToolsNegDlyEnable.Checked))
	End Sub
	Sub UpdateMenuCaption()
		
		strTimeoutTitle = "Set Delay Time... ("
		
		mnuToolsNegDlyTime.Text = strTimeoutTitle & Val(CStr(frmCtlSetup.sngMaxScanTime)) & " Seconds)"
	End Sub
	
	Public Sub mnuToolsNegDlyTime_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsNegDlyTime.Click
		Dim sngTime As Single
        Dim strBuff As String
		
		strBuff = (InputBox("Please enter the negative delay timeout. Must be at least 3 seconds for the 246. Enter 0 to disable.", "Enter Delay Time", CStr(frmCtlSetup.sngMaxScanTime)))
		
		If strBuff = "" Then Exit Sub
		
		sngTime = Val(strBuff)
		If sngTime < 1 Then
			sngTime = 0
		End If
		
		frmCtlSetup.sngMaxScanTime = sngTime
		SaveSetting("FreeSCAN", "Settings", "MaxScanTime", CStr(sngTime))
		UpdateMenuCaption()
	End Sub
	

	

	
	Public Sub mnuWX_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWX.Click
		Dim index As Short = mnuWX.GetIndex(eventSender)
        Dim strBuff As String
        strBuff = Nothing
		Select Case index
			Case 0
				strBuff = "NORMAL"
			Case 1
				strBuff = "A_ONLY"
			Case 2
				strBuff = "SAME_1"
				
			Case 3
				strBuff = "SAME_2"
			Case 4
				strBuff = "SAME_3"
			Case 5
				strBuff = "SAME_4"
			Case 6
				strBuff = "SAME_5"
			Case 7
				strBuff = "ALL_FIPS"
		End Select
		strUserCMD = "JPM,WX_MODE," & strBuff
	End Sub
	

	
    Private Sub sldVol_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles sldVol.LostFocus
        blnHaltChange = False
    End Sub

    Private Sub sldVol_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sldVol.MouseDown
        blnHaltChange = True
        strDisplay(42) = CStr(sldVol.Value)
    End Sub

    Private Sub sldVol_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sldVol.MouseUp
        blnHaltChange = False
    End Sub

    Private Sub sldVol_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles sldVol.Scroll
        Dim intVal As Single
        If Not sldVol.Focused Then
            Exit Sub
        End If
        strDisplay(42) = CStr(sldVol.Value)

        If blnBusy = True Then
            Do Until blnBusy = False Or intVal >= 125000
                intVal = intVal + 1
                System.Windows.Forms.Application.DoEvents()
            Loop
        End If

        intVal = sldVol.Value

        If frmCtlSetup.BaseStation(strMDL) = False Then
            intVal = Int(intVal / 2)
        End If

        strUserCMD = "VOL," & sldVol.Value
        strDisplay(42) = CStr(sldVol.Value)
    End Sub

    Private Sub sldSql_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles sldSql.Scroll
        Dim intVal As Single
        If Not sldSql.Focused Then
            Exit Sub
        End If
        strDisplay(43) = CStr(sldSql.Value)
        If blnBusy = True Then
            System.Threading.Thread.Sleep(10)
        End If

        If frmCtlSetup.BaseStation(strMDL) = False Then
            intVal = Int(intVal / 1.26)
        End If
        intVal = sldSql.Value
        strUserCMD = "SQL," & intVal
        strDisplay(43) = CStr(intVal)
    End Sub

    Private Sub sldOpacity_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldOpacity.Scroll
        Me.Opacity = sldOpacity.Value / 10

    End Sub

    Private Sub chkTopMost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTopMost.CheckedChanged
        Me.TopMost = chkTopMost.Checked
    End Sub

    Private Sub _mnuWX_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _mnuWX_0.Click

    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        strUserCMD = "KEY," & "1,P"
    End Sub

    Private Sub BMENU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMENU.Click
        strUserCMD = "KEY," & "M,P"
    End Sub

    Private Sub BHOLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHOLD.Click
        strUserCMD = "KEY," & "H,P"
    End Sub

    Private Sub BSCAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSCAN.Click
        strUserCMD = "KEY," & "S,P"
    End Sub

    Private Sub BLO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLO.Click
        strUserCMD = "KEY," & "L,P"
    End Sub

    Private Sub BNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNO.Click
        strUserCMD = "KEY," & ".,P"
    End Sub

    Private Sub BYES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BYES.Click
        strUserCMD = "KEY," & "E,P"
    End Sub

    Private Sub BRIGHT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRIGHT.Click
        strUserCMD = "KEY," & ">,P"
    End Sub

    Private Sub BLEFT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLEFT.Click
        strUserCMD = "KEY," & "<,P"
    End Sub

    Private Sub BVOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVOL.Click
        If frmCtlSetup.BaseStation(strMDL) = False Then
            strUserCMD = "KEY," & "^,P"
        Else
            strUserCMD = "KEY," & "V,P"
        End If
    End Sub

    Private Sub BFUNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFUNC.Click
        If intKeyHold(20) = 1 Then 'unpush
            strUserCMD = "KEY," & "F,R"
            intKeyHold(20) = 0
        Else
            strUserCMD = "KEY," & "F,H"
            intKeyHold(20) = 1
        End If
    End Sub

    Private Sub BPRI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPRI.Click
        strUserCMD = "KEY,P,P"
        LetCMDFinish()
    End Sub

    Private Sub BWX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BWX.Click
        strUserCMD = "KEY,W,P"
        LetCMDFinish()
    End Sub

    Private Sub BGPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGPS.Click
        strUserCMD = "KEY,G,P"
        LetCMDFinish()
    End Sub

    Private Sub BSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSQL.Click

        If frmCtlSetup.BaseStation(strMDL) = True Then
            strUserCMD = "KEY," & "Q,P"
        End If
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        strUserCMD = "KEY," & "2,P"
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        strUserCMD = "KEY," & "3,P"
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        strUserCMD = "KEY," & "4,P"
    End Sub

    Private Sub B5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5.Click
        strUserCMD = "KEY," & "5,P"
    End Sub

    Private Sub B6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B6.Click
        strUserCMD = "KEY," & "6,P"
    End Sub

    Private Sub B7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B7.Click
        strUserCMD = "KEY," & "7,P"
    End Sub

    Private Sub B8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B8.Click
        strUserCMD = "KEY," & "8,P"
    End Sub

    Private Sub B9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B9.Click
        strUserCMD = "KEY," & "9,P"
    End Sub

    Private Sub B0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B0.Click
        strUserCMD = "KEY," & "0,P"
    End Sub

    Private Sub frmCtlWin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub frmCtlWin_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown

    End Sub

    Private Sub BPWR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPWR.Click
        strUserCMD = "KEY," & "P,P"
    End Sub

    Private Sub ShowHideMainWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowHideMainWindowToolStripMenuItem.Click
        If lblSiteNote.Visible = True Then
            lblSiteNote.Visible = False
        Else
            lblSiteNote.Visible = True
        End If
    End Sub

    Private Sub JumpToFrequencyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JumpToFrequencyToolStripMenuItem.Click
        FreqJump.Visible = True
    End Sub

    Private Sub SetupAudioRecordingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupAudioRecordingToolStripMenuItem.Click
        frmRecord.Visible = True
    End Sub

    Private Sub SetupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetupToolStripMenuItem.Click
        networkserver.Show()

    End Sub
End Class