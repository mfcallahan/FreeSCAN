Option Strict Off
Option Explicit On
Friend Class frmCtlLCARS
	Inherits System.Windows.Forms.Form
	
	Dim strFontName As String
	Dim intFontSize As Integer
	Dim blnFontItalic As Boolean
	Dim blnFontBold, blnFontUl As Boolean
	Dim strGrd As String
	Dim dblFontColour As Double
	Dim intKeyHold(100) As Integer
	Dim blnBusy As Boolean
	
	Dim intKeyID As Integer
	Dim dblLastJump As Double ' last frequnecy jumped to
    Dim strTimeoutTitle As String
	Sub LetCMDFinish()
		Dim intVal As Single
		Do Until strUserCMD = "" Or intVal = 300000
			intVal = intVal + 1
			System.Windows.Forms.Application.DoEvents()
		Loop 
	End Sub
	Sub InsertSig(ByRef dblFreq As Double, ByRef intRSSI As Short)
		'This creates a little graphic circle
		'showing what frequency and signal strength were
		If blnDebug = False Then On Error Resume Next
		Dim intMaxRight, intMaxLeft, intTop As Integer
		Dim intBottom, intIdx As Integer
        intMaxLeft = 399
        intMaxRight = 530
        intTop = 46
        intBottom = 109
		intIdx = shpSig.UBound
		If intRSSI < 6 Then
			intRSSI = intRSSI * 200
        End If

		If intIdx > 600 Then 'too many shapes, clear them
			Call ClearShapes()
			intIdx = shpSig.UBound
		End If
		intIdx = intIdx + 1
		shpSig.Load(intIdx)
		With shpSig(intIdx)
            .Left = intMaxLeft + (((dblFreq - 27) / 929) * (intMaxRight - intMaxLeft))
            .Top = (intBottom - ((intRSSI / 1024) * (intBottom - intTop)))
			.Visible = True
		End With
		
	End Sub
	Sub ClearShapes()
		'wipes out all the little sig indicator
		Do Until shpSig.UBound = 0
			shpSig.Unload(shpSig.UBound)
		Loop 
	End Sub
	Private Sub cmdClose_Click()
		Call cmdStopCom_Click()
		
		Me.Visible = False
		frmCtlSetup.Visible = True
	End Sub
	
	Private Sub cmdLink_Click()
		Call frmCtlSetup.StartCOMMS()
		Refresh()
	End Sub
	
	Private Sub cmdStopCom_Click()
		
		Call frmCtlSetup.StopCOMMS()
		Refresh()
	End Sub

	
	Sub DrawWin()
		'begin label
		
		If blnDebug = False Then On Error Resume Next
		Dim intCtl1, intCtl, intCnt As Integer
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

        'max 5
        'signal strength
        If strDisplay(49) = "0" Then
            shpIndicate(0).Width = VB6.TwipsToPixelsX(Val(strDisplay(29)) * 303)
        Else
            '1530 max


            shpIndicate(0).Width = VB6.TwipsToPixelsX(MakePositive(Val(strDisplay(49)) * 1.49))
        End If
        lblDisp(7).Text = strDisplay(31)
        picHOld.Visible = Val(strDisplay(21))
        PicLO.Visible = Val(strDisplay(27))
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

            strBuff = Format(Val(strBuff), "###0.0000") & " MHz"

            lblDisp(6).Text = strBuff

        ElseIf strBuff <> "" Then

            lblDisp(6).Text = "ID: " & strBuff
        Else
            lblDisp(6).Text = ""
        End If

        'setup squelch
        Select Case Val(strRxSta(8))
            Case 0
                PicOnline1.Visible = True
                PicOnline2.Visible = True
            Case Else
                PicOnline1.Visible = False
                PicOnline2.Visible = False
        End Select
        'signal strength
        If Val(strDisplay(49)) > 0 Then
            lblDisp(9).Text = strDisplay(49)
        Else
            lblDisp(9).Text = strDisplay(28)
        End If
        If strRxSta(7) <> "" Then
            If Me.Text <> strRxSta(7) Then
                Me.Text = strRxSta(7)
            End If
        ElseIf Len(strRxSta(1)) > 1 Then

            strBuff = strRxSta(1)

            If Val(strBuff) > 1200 Then

                strBuff = Val(strBuff) / 10000
            End If

            If Val(strBuff) > 0 And Val(strBuff) < 1 Then

                strBuff = Val(strBuff) * 10000
            End If

            strBuff = Format(Val(strBuff), "###0.0000") & "MHz"

            If Me.Text <> strBuff Then

                Me.Text = strBuff
            End If
        Else
            If Me.Text <> "LCARS Control" Then
                Me.Text = "LCARS Control"
            End If
        End If
        shpIndicate(2).Width = VB6.TwipsToPixelsX(Val(strDisplay(39)) * 15.15)

        lblBat.Text = Format(Val(strDisplay(38)), "#0.0") & " V"
        'apco

        shpIndicate(1).Width = VB6.TwipsToPixelsX(Val(strDisplay(41)) * 15.3)
        'Function
        If strDisplay(28) = "1" Then
            If lblDisp(8).Text <> "FUNC" Then
                lblDisp(8).Text = "FUNC"
            End If
            lblDisp(8).Visible = True
        Else
            lblDisp(8).Visible = False
        End If
        'Need to implenet 22 Close Call ICON
        'Close Call
        If strDisplay(45) = "1" Then
            PicCC.Visible = True
        Else
            PicCC.Visible = False
        End If
        'Alert
        If strDisplay(46) = "1" Then
            picAlertLED.Visible = True
        Else
            picAlertLED.Visible = False
        End If
        'Volume Level
        shpIndicate(3).Width = VB6.TwipsToPixelsX(Val(strDisplay(42)) * 52.24)
        shpIndicate(4).Width = VB6.TwipsToPixelsX(Val(strDisplay(43)) * 81.63)
        If strDisplay(22) = "1" Then 'close call active
            picCloseCallACt.Visible = True
        Else
            picCloseCallACt.Visible = False
        End If
        'Weather alert
        If strDisplay(20) = "1" Then
            picWX.Visible = True
        Else
            picWX.Visible = False
        End If
        'crypto alarm
        If strDisplay(44) = "1" Then
            picENC.Visible = True
        Else
            picENC.Visible = False
        End If

        blnBusy = False
        picLowBatt.Visible = Val(strDisplay(19))

    End Sub


    Private Sub frmCtlLCARS_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        mnuEnableLog.Checked = blnEnableLog
    End Sub

    Private Sub frmCtlLCARS_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If blnDebug = False Then On Error Resume Next
        Dim intCnt As Integer
        blnFontBold = CBool(GetSetting("FreeSCAN", "Settings", "CONFont1Bold", "False"))
        strFontName = GetSetting("FreeSCAN", "Settings", "CONFont1", "MS Sans Serif")
        intFontSize = Val(GetSetting("FreeSCAN", "Settings", "CONFont1Size", "12"))
        blnFontUl = CBool(GetSetting("FreeSCAN", "Settings", "CONFont1UL", "False"))
        blnFontItalic = CBool(GetSetting("FreeSCAN", "Settings", "CONFont1Italic", "False"))
        dblFontColour = CDbl(GetSetting("FreeSCAN", "Settings", "CONFont1Colour", CStr(&H99FF)))
        ApplyFontStyle()
        'For intCnt = 0 To imgKey.Count - 1
        '    imgKey(intCnt) = PicKeyUp(intCnt)
        'Next intCnt

    End Sub
    Private Sub Form_Terminate_Renamed()
        Call cmdClose_Click()
    End Sub

    Private Sub frmCtlLCARS_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call cmdClose_Click()
    End Sub



    Private Sub imgClearALl_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles imgClearALl.Click
        Call ClearShapes()
    End Sub

    Private Sub imgKey_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles imgKey.Click
        Dim index As Short = imgKey.GetIndex(eventSender)
        'process a button pushed by the user
        Dim strKey As String
        strKey = Nothing
        intKeyID = index
        'imgKey(Index).Enabled = False
        If frmCtlSetup.blnCommsUp = False And index <> 30 Then Exit Sub
        If index < 10 Then 'numbers are sent directly
            strKey = index & ",P"
        Else
            Select Case index
                Case 19 'menu
                    strKey = "M,P"
                Case 25 'menu on torpedo
                    strKey = "M,P"
                Case 28 'func
                    strKey = "F,L"
                Case 10 'hold
                    strKey = "H,P"
                Case 31 'scan,bottom
                    strKey = "S,P"
                Case 11 'scan
                    strKey = "S,P"
                Case 31 'scan, bottom
                    strKey = "S,P"
                Case 32 'hold, bottom
                    strKey = "H,P"
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
                Case 21 '+Vol
                    strUserCMD = "+VOL"
                Case 22 '-Vol
                    strUserCMD = "-VOL"
                Case 23 '-Sql
                    strUserCMD = "-SQL"
                Case 24 '+Sql
                    strUserCMD = "+SQL"
                Case 29 'stop comms
                    Call cmdStopCom_Click()
                Case 30 'start comm
                    Call cmdLink_Click()
                Case 33 'push backlight
                    strUserCMD = "KEY,!,P"
                    LetCMDFinish()
                Case 34 'jump to freq
                    Call mnuEditJump_Click(mnuEditJump, New System.EventArgs())
                Case 35 'power of
                    strUserCMD = "POF"
                    LetCMDFinish()
                    Call cmdStopCom_Click()
                Case 26 'close call
                    strUserCMD = "JPM,CC_MODE,"
                    '  LetCMDFinish
                Case 27 'custom search
                    strUserCMD = "JPM,CTM_MODE"
                    'LetCMDFinish
                Case 36 'PUBLIC SAFETY
                    strUserCMD = "JPM,SVC_MODE"
                    ' LetCMDFinish
                Case 37 'cWX
                    strUserCMD = "JPM,WX_MODE,NORMAL"
                    'LetCMDFinish
                Case 38 'ham
                    strUserCMD = "JPM,SVC_MODE,HAM"
                    'LetCMDFinish
                Case 39 'MARINE
                    strUserCMD = "JPM,SVC_MODE,Marine"
                    'LetCMDFinish
                Case 40 'CB
                    strUserCMD = "JPM,SVC_MODE,CB"
                    'LetCMDFinish
                Case 41 'FRS
                    strUserCMD = "JPM,SVC_MODE,FRS/GMRS"
                    ' LetCMDFinish
                Case 42 'AIR
                    strUserCMD = "JPM,SVC_MODE,Air"
                    ' LetCMDFinish
                Case 43 'MIL
                    strUserCMD = "JPM,SVC_MODE,Military"
                    '  LetCMDFinish
                Case 44 'MIL
                    strUserCMD = "JPM,SVC_MODE,Military"
                    '  LetCMDFinish
                Case 45 'MIL
                    strUserCMD = "JPM,SVC_MODE,Military"
                    ' LetCMDFinish
                Case 46 'FTO
                    strUserCMD = "JPM,FTO_MODE"
                    ' LetCMDFinish
            End Select
        End If
        If strKey <> "" Then
            strUserCMD = "KEY," & strKey
        End If
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
        Call cmdClose_Click()
    End Sub

    Public Sub mnuEditFont_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditFont.Click
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
            CheckFont()
            blnFontBold = .Font.Bold
            blnFontItalic = .Font.Italic
            blnFontUl = .Font.Underline
            intFontSize = .Font.Size
        End With

        SaveSetting("FreeSCAN", "Settings", "CONFont1Bold", CStr(blnFontBold))
        SaveSetting("FreeSCAN", "Settings", "CONFont1", strFontName)
        SaveSetting("FreeSCAN", "Settings", "CONFont1Size", CStr(intFontSize))
        SaveSetting("FreeSCAN", "Settings", "CONFont1UL", CStr(blnFontUl))
        SaveSetting("FreeSCAN", "Settings", "CONFont1Italic", CStr(blnFontItalic))

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
		
		
		lblDisp(8).Font = VB6.FontChangeSize(lblDisp(8).Font, MakePositive(intFontSize - 4))
		
		
		lblDisp(4).Font = VB6.FontChangeSize(lblDisp(4).Font, MakePositive(intFontSize - 2))
		
		
		lblDisp(5).Font = VB6.FontChangeSize(lblDisp(5).Font, MakePositive(intFontSize - 2))
		
		
		lblDisp(6).Font = VB6.FontChangeSize(lblDisp(6).Font, MakePositive(intFontSize - 2))
		'   lblHold.ForeColor = dblFontColour
		For intCnt = 0 To 2
			lblCursor(intCnt).Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(lblDisp(intCnt + 1).Top) + VB6.PixelsToTwipsY(lblDisp(intCnt).Height) + 10)
		Next intCnt
	End Sub
	
	Public Sub mnuEditFontColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditFontColor.Click
		frmCtlSetup.Timer_Renamed.Enabled = False
        If blnDebug = False Then On Error Resume Next
        With ColorDialog1
            .Color = System.Drawing.ColorTranslator.FromOle(dblFontColour)
            .ShowDialog()
            dblFontColour = System.Drawing.ColorTranslator.ToOle(.Color)
        End With
		SaveSetting("FreeSCAN", "Settings", "CONFont1Colour", CStr(dblFontColour))
		ApplyFontStyle()
		frmCtlSetup.Timer_Renamed.Enabled = True
	End Sub
	
	Private Sub TmrGraphics_Timer()
		'flash low battery on/off
		
	End Sub
	
	Public Sub mnuEditJump_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditJump.Click
		Dim dblFreq As Double
		Dim strBuff As String
		strBuff = InputBox("Please enter the frequency you would like to jump to", "Jump To Frequency", CStr(dblLastJump))
		dblFreq = Val(strBuff)
		If strBuff <> "" And IsNumeric(dblFreq) = True Then
			
			dblFreq = Val(MakeItKosherFreqSilent(dblFreq))
			dblLastJump = dblFreq
			strUserCMD = "QSH," & (dblFreq * 10000) & ",,,,,,,,"
		End If
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
	
	Private Sub sldSql_Change()
		Dim intVal As Single
		' strDisplay(43) = sldSql.Value
		If blnBusy = True Then
			Do Until blnBusy = False Or intVal >= 125000
				intVal = intVal + 1
				System.Windows.Forms.Application.DoEvents()
			Loop 
		End If
		
		If frmCtlSetup.BaseStation(strMDL) = False Then
			intVal = Int(intVal / 1.26)
		End If
		'intVal = sldSql.Value
		strUserCMD = "SQL," & intVal
		strDisplay(43) = CStr(intVal)
		
	End Sub
	
	Private Sub sldVol_Change()
		Dim intVal As Single
		'strDisplay(42) = sldVol.Value
		If blnBusy = True Then
			Do Until blnBusy = False Or intVal >= 125000
				intVal = intVal + 1
				System.Windows.Forms.Application.DoEvents()
			Loop 
		End If
		
		'intVal = sldVol.Value
		
		If frmCtlSetup.BaseStation(strMDL) = False Then
			intVal = Int(intVal / 2)
		End If
		
		'strUserCMD = "VOL," & sldVol.Value
		'strDisplay(42) = sldVol.Value
		
		
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


    Private Sub _mnuJServ_1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_1.Click
        strUserCMD = "JPM,SVC_MODE,PublicSafety"
    End Sub

    Private Sub _mnuJServ_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_2.Click
        strUserCMD = "JPM,SVC_MODE,News"
    End Sub

    Private Sub _mnuJServ_3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_3.Click
        strUserCMD = "JPM,SVC_MODE,HAM"
    End Sub

    Private Sub _mnuJServ_4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_4.Click
        strUserCMD = "JPM,SVC_MODE,Marine"
    End Sub

    Private Sub _mnuJServ_5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_5.Click
        strUserCMD = "JPM,SVC_MODE,Railroad"
    End Sub

    Private Sub _mnuJServ_6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_6.Click
        strUserCMD = "JPM,SVC_MODE,Air"
    End Sub

    Private Sub _mnuJServ_7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_7.Click
        strUserCMD = "JPM,SVC_MODE,CB"
    End Sub

    Private Sub _mnuJServ_8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_8.Click
        strUserCMD = "JPM,SVC_MODE,FRS/GMRS"
    End Sub

    Private Sub _mnuJServ_9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_9.Click
        strUserCMD = "JPM,SVC_MODE,Racing"
    End Sub

    Private Sub _mnuJServ_10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_10.Click
        strUserCMD = "JPM,SVC_MODE,TV"
    End Sub

    Private Sub _mnuJServ_11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_11.Click
        strUserCMD = "JPM,SVC_MODE,FM"
    End Sub

    Private Sub _mnuJServ_12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_12.Click
        strUserCMD = "JPM,SVC_MODE,Special"
    End Sub

    Private Sub _mnuJServ_13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuJServ_13.Click
        strUserCMD = "JPM,SVC_MODE,Military"

    End Sub

    Private Sub sldOpacity_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldOpacity.Scroll
        Me.Opacity = sldOpacity.Value / 10
    End Sub

    Private Sub chkTopMost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTopMost.CheckedChanged
        Me.TopMost = chkTopMost.Checked
    End Sub

    Private Sub _mnuWX_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _mnuWX_0.Click
        strUserCMD = "JPM,WX_MODE,NORMAL"
    End Sub

    Private Sub _mnuWX_1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuWX_1.Click
        strUserCMD = "JPM,WX_MODE,A_ONLY"
    End Sub

    Private Sub _mnuWX_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuWX_2.Click
        strUserCMD = "JPM,WX_MODE,SAME_1"
    End Sub

    Private Sub _mnuWX_3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuWX_3.Click
        strUserCMD = "JPM,WX_MODE,SAME_2"
    End Sub

    Private Sub _mnuWX_4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuWX_4.Click
        strUserCMD = "JPM,WX_MODE,SAME_3"
    End Sub

    Private Sub _mnuWX_5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuWX_5.Click
        strUserCMD = "JPM,WX_MODE,SAME_4"
    End Sub

    Private Sub _mnuWX_6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuWX_6.Click
        strUserCMD = "JPM,WX_MODE,SAME_5"
    End Sub

    Private Sub _mnuWX_7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _mnuWX_7.Click
        strUserCMD = "JPM,WX_MODE,ALL_FIPS"
    End Sub

    Private Sub _imgKey_33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _imgKey_33.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        FreqJump.Visible = True
    End Sub

    Private Sub ShowHideMainWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowHideMainWindowToolStripMenuItem.Click
        If lblSiteNote.Visible Then
            lblSiteNote.Visible = False
        Else
            lblSiteNote.Visible = True
        End If
    End Sub

    Private Sub SetupAudioRecordingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupAudioRecordingToolStripMenuItem.Click
        frmRecord.Visible = True
    End Sub
End Class