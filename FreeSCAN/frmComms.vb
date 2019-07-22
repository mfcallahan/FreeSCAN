Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class Form1
	Inherits System.Windows.Forms.Form
	Dim oktogo As Boolean
	Dim intTx, intRx As Single
    Dim intSystems(MaxSystems) As Integer
    Dim intMemCheckCnt As Integer
    Dim strSQL, strVOL, strBKL As String
    Public intTimer As Integer
	Sub LoadPrefs()
		
		If blnDebug = False Then On Error Resume Next
		Dim strPrefs() As String
		Dim x As String
		x = GetSetting("FreeSCAN", "Settings", "UploadPref", "")
		strPrefs = Split(x, ",")
		If UBound(strPrefs) = 5 Then
            chkUploadCustomSettings.Checked = MakeBoolean(strPrefs(0))
            chkAnalog.Checked = MakeBoolean(strPrefs(1))
            chkGlobalLO.Checked = MakeBoolean(strPrefs(2))
            chkSysQK.Checked = MakeBoolean(strPrefs(3))
            chkResume.Checked = MakeBoolean(strPrefs(4))
		End If
		
    End Sub
    Function MakeDelay(ByVal strDelay As String, ByVal blnXT As Boolean) As String
        'Takes a delay input from the program and confirms that it is compatible with the scanner it is being uploaded to
        If blnXT = True Then
            Select Case strDelay
                Case "3"
                    strDelay = "2"
                Case "4"
                    strDelay = "5"

            End Select
        Else
            If Val(strDelay) < 0 Then
                strDelay = "0"
            ElseIf Val(strDelay) > 5 Then
                strDelay = "5"
            End If
        End If
        If strDelay = "" Then strDelay = "0"
        MakeDelay = strDelay
    End Function
	Sub SavePrefs()
		Dim strArray, C As String
		'build the array
		C = ","
        strArray = chkUploadCustomSettings.Checked & C & chkAnalog.Checked & C & chkGlobalLO.Checked & C & chkSysQK.Checked & C
        strArray &= chkResume.Checked & C & "0" ' 0 is reserv
		SaveSetting("FreeSCAN", "Settings", "UploadPref", strArray)
	End Sub
    Sub QGLUL396(ByRef intIndex As Integer, ByRef intSystem As Integer)
        Dim strBuff, strQGL As String
        Dim cnt As Integer
        Dim strBuff1 As String
        strQGL = Nothing
        strBuff = varSite(intSystem, 0, 0, 8)
        If Len(strBuff) = 10 Then
            For cnt = 1 To 10
                
                strBuff1 = Mid(strBuff, cnt, 1)
                
                If strBuff1 = "1" Then
                    strQGL = strQGL & "1"
                Else
                    strQGL = strQGL & "2"
                End If
            Next cnt
        Else
            strQGL = "1111111111"
        End If
        
        
        strBuff = SendCMD("QGL," & intIndex & "," & strQGL)
    End Sub
    Sub CheckMem(ByRef strMode As String)
        'checks to see how much memory there is left on the scanner
        Dim intMem As Integer
        
        If strMode = "C" Then 'in channel mode, only run every , um, 5 times?
            
            If intMemCheckCnt < 7 Then
                
                intMemCheckCnt = intMemCheckCnt + 1
                Exit Sub
            Else
                
                intMemCheckCnt = 0
            End If
        End If

        If msc.IsOpen = False Then Exit Sub
        Dim strBuff As String

        strBuff = SendCMD("MEM")

        intMem = Val(ParaParse(strBuff, 1))
        With lblMemUsed
            .Text = intMem & "%"
            If intMem < 92 Then
                .ForeColor = System.Drawing.ColorTranslator.FromOle(&H0)
                .Font = VB6.FontChangeBold(.Font, False)
            Else
                .ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                .Font = VB6.FontChangeBold(.Font, True)
            End If
        End With
    End Sub
    Sub Upload396(ByVal strMDL As String)
        If blnDebug = False Then On Error GoTo criticerror
        Dim strCMD(5) As String
        Dim strModMode, strName, strChanName, Response As String
        Dim strQK As String
        Dim intToneLock, intGroup, intChan, intGroupIndex As Integer
        Dim intIndex, intSystem, intChannelIndex As Integer
        Dim intEMG, intDelay, intAtt, intLockout, intDataSkip, intCTCSS As Integer
        Dim intHoldTime, intLO As Integer
        Dim dblFreq As Double
        Dim intPri As Integer
        Dim intAlert, intTrunkChan As Integer
        Dim ResponseCode As String
        Dim intConCh, intEDACSFormat, intStatusBit, intIDMode, intEndCode, intICALL, intFleetMap As Integer
        Dim strCustFleetMap, C As String
        Dim intBase(2) As Double
        Dim intOffset(2) As Double
        Dim intMStep(2) As Double
        Dim strSysType As String
        Dim cnt, x, intSeqIndex, intList, intGPSEnable As Integer
        Dim strStartKey As String
        Dim intSite, intSiteIndex As Integer
        Dim strLong, strLat, strRange As Double
        Dim intEmgAlertLevel, intEmgAlertType As Integer
        Dim strBuff() As String
        Dim strBuff1 As String
        Dim intGrpSite, intStep As Integer
        Dim strbuff2(4) As String
        Dim Bln246, blnBR330T, blnAnalog As Boolean
        Dim strQGL As String
        Dim Bln396, bln230, blnSkipGroup, blnSysOK As Boolean
        Dim intDigCode As Integer
        Dim MemErrCount As Integer = 0
        strCurOp = ""
        strLog = ""
        Call initForm()

        C = ","
        blnBR330T = False
        bln230 = False
        Bln246 = False
        'load programming onto radio

        frmQKEdit.Visible = False

        ResponseCode = strMDL
        strName = strMDL
        If ResponseCode = "-1" Or ResponseCode = "" Then
            Response = CStr(MsgBox("Unable to establish communications with scanner. Please review your COM port settings."))
            mnuScannerCOMPort_Click(mnuScannerCOMPort, New System.EventArgs())
            Exit Sub
        ElseIf InStr(SupportedScanners, ResponseCode) = 0 Then
            Response = CStr(MsgBox("This version of FreeSCAN is only compatible with the " & SupportedScanners & " scanners.It will not work with other types. Code Received: " & ResponseCode, MsgBoxStyle.Exclamation))

            Response = SendCMD("EPG")
            msc.Close()
            Exit Sub
        End If

        'set whether to upload digital channels to an analog scanner
        If chkAnalog.CheckState = 1 And InStr(ResponseCode, "396") = 0 Then
            blnAnalog = True
        Else
            blnAnalog = False
        End If

        'erase radio
        If msc.IsOpen = False Then msc.Open()
        strLog &= strProgTitle & vbNewLine


        ResponseCode = SendCMD("PRG")
        If ResponseCode <> "OK" Then
            MsgBox("Unable to enter programming mode. Please exit menu mode or correct other scanner problem before attempting to program.")
            msc.Close()
            Exit Sub
        End If

        SetWriteMode()
        If InStr(strName, "246") <> 0 Then
            Bln246 = True
        ElseIf InStr(strName, "230") <> 0 Then
            Bln246 = True
            bln230 = True
        ElseIf InStr(strName, "396") <> 0 Then
            Bln396 = True
        End If
        If strName = "UBR330T" Or strName = "BR330T" Or strName = "UBC3500XLT" Then
            blnBR330T = True
        End If
        If Bln396 Or blnBR330T Then
            Call SaveVolSql(strMDL)
        End If

        'insert radio settings.
        Call CheckMem("")
        If chkUploadCustomSettings.CheckState = 1 Then
            strCurOp = "Sending scanner settings..."
            If RadioSetting(85) <> "" Then

                Response = SendCMD("BLT," & UCase(RadioSetting(85))) 'backlight
            End If
            strBuff1 = RadioSetting(3)
            If Bln246 = True And strBuff1 = "2" Then strBuff1 = "1"
            Response = SendCMD("PRI," & strBuff1) 'priority mode
            Response = SendCMD("BSV," & MakeBinary(RadioSetting(86))) 'battery save
            strBuff = Split(RadioSetting(71), Chr(9))

            If Bln246 = False And bln230 = False Then
                CommonWX(strName)
            Else
                Send246WX()
            End If
            If Bln246 = False Then
                Response = SendCMD("AGV," & RadioSetting(25) & C & RadioSetting(26)) 'auto gain  setting
                Response = SendCMD("KBP," & RadioSetting(4)) 'key beep
                ToneUL396()
                Response = SendCMD("CNT," & RadioSetting(29)) 'lcd contrast
                Response = SendCMD("OMS," & RadioSetting(5) & "," & RadioSetting(6) & C & RadioSetting(22) & C & RadioSetting(23)) 'opening message
            Else
                strBuff1 = RadioSetting(4)
                If strBuff1 = "99" Then
                    strBuff1 = "0" 'off
                Else
                    strBuff1 = "1" 'on
                End If
                Response = SendCMD("KBP," & strBuff1) 'key beep
                Response = SendCMD("OMS," & RadioSetting(5) & "," & RadioSetting(6))
            End If
            'AGC
            If blnBR330T = False And Bln246 = False Then
                CommonAGC() 'send advanced agc settings
            End If
            'Search/Close Call Settings
            intDelay = Val(MakeDelay(RadioSetting(21), False))
            If Bln246 = False Then
                strCMD(0) = "SCO," & StepSize(Val(RadioSetting(17)), 1) & C & RadioSetting(18) & C & RadioSetting(33) & C
                strCMD(1) = intDelay & "," & RadioSetting(40) & C & RadioSetting(24) & C & RadioSetting(43) & C
                If blnBR330T = False Then
                    strCMD(2) = RadioSetting(41) & C & "AUTO,8," & RadioSetting(32)
                Else
                    strCMD(2) = RadioSetting(41) & C & C & C & RadioSetting(32)
                End If
                Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2)) 'close call settings
            Else
                strbuff2(0) = VB.Left(RadioSetting(43), 1)
                'modmode
                strbuff2(1) = RadioSetting(18)
                If strbuff2(1) = "WFM" Then strbuff2(1) = "FM"
                strCMD(0) = "SCO," & StepSize(Val(RadioSetting(17)), 1) & C & strbuff2(1) & C & RadioSetting(33) & C
                strCMD(1) = intDelay & "," & RadioSetting(40) & C & RadioSetting(24) & C & strbuff2(2) & C
                strCMD(2) = RadioSetting(41) & C & RadioSetting(32)
                Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2)) 'close call settings
            End If
            If Response = "ERR" Then
                sngErr = sngErr + 1
                GenLog(("SCO CMD Error"))
            End If
            'even more close call settings
            If Bln246 = False Then
                strCMD(0) = "CLC," & RadioSetting(7) & C & RadioSetting(8) & C & RadioSetting(27) & C & RadioSetting(13) & C & RadioSetting(15) & C
                strCMD(1) = RadioSetting(11) & C & RadioSetting(14)
                Response = SendCMD(strCMD(0) & strCMD(1))
                If Response = "ERR" Then
                    sngErr = sngErr + 1
                    GenLog(("Close Call setting error"))
                End If
            Else
                strBuff1 = ""
                strBuff1 = CStr(Val(VB.Left(RadioSetting(14), 1))) 'vhf
                strBuff1 = strBuff1 & Val(Mid(RadioSetting(14), 3, 1)) 'air band
                strBuff1 = strBuff1 & Val(Mid(RadioSetting(14), 4, 1)) 'vhf
                strBuff1 = strBuff1 & Val(Mid(RadioSetting(14), 6, 1)) 'uhf
                strBuff1 = strBuff1 & Val(Mid(RadioSetting(14), 7, 1)) '800mhz+
                'cc mode
                strbuff2(0) = RadioSetting(7)
                'If strbuff2(0) = "2" Then strbuff2(0) = 1'this was to the old firmware

                strCMD(0) = "CLC," & strbuff2(0) & C & RadioSetting(8) & C & RadioSetting(27) & C & strBuff1

                Response = SendCMD(strCMD(0))
                If Response = "ERR" Then
                    sngErr = sngErr + 1
                    GenLog(("Can't set Close Call - May need to upgrade firmware"))
                End If
            End If

            lstSystems.Enabled = True
            'broadcast screen settings
            If Bln246 = False Then
                x = 0
                For cnt = 0 To 19 Step 2
                    x = x + 1
                    If x = 10 Then x = 0

                    strCMD(0) = "BBS," & x & C & (Val(RadioSetting(51 + cnt)) * 10000) & C & Val(RadioSetting(52 + cnt)) * 10000

                    Response = SendCMD(strCMD(0))
                Next cnt
                'service search settings
                For x = 1 To 12
                    strCMD(0) = "SSP," & x & C & MakeDelay(strSS(x, 2), False) & C & strSS(x, 3) & C & strSS(x, 4) & C & strSS(x, 8)
                    Response = SendCMD(strCMD(0))
                Next x
            End If


            'custom search ranges
            strCurOp = "Sending custom search range settings..."
            For x = 1 To 10
                strCMD(5) = strCMD(5) & FlipIt(CustSearch(x, 8))
            Next x
            Response = SendCMD("CSG," & strCMD(5))
            For x = 1 To 10
                intChan = x
                If intChan = 10 Then intChan = 0
                intDelay = Val(MakeDelay(CustSearch(x, 6), False))
                If Bln246 = False Then
                    strCMD(0) = "CSP," & intChan & C & CustSearch(x, 0) & C & (Val(CStr(CDbl(CustSearch(x, 1)) * 10000))) & C & (Val(CStr(CDbl(CustSearch(x, 2)) * 10000))) & C
                    strCMD(1) = StepSize(Val(CustSearch(x, 3)), 1) & C & CustSearch(x, 4) & C & CustSearch(x, 5) & C
                    strCMD(2) = intDelay & C & CustSearch(x, 7) & C & CustSearch(x, 9) & C & CustSearch(x, 15) & C
                    If blnBR330T = False Then
                        strCMD(3) = CustSearch(x, 10) & C & APCOMode & C & APCOThreshold
                    Else
                        strCMD(3) = CustSearch(x, 10) & C & C
                    End If
                    Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3))
                Else
                    strbuff2(1) = CustSearch(x, 4)
                    If strbuff2(1) = "WFM" Then strbuff2(1) = "FM"
                    strCMD(0) = "CSP," & intChan & C & CustSearch(x, 0) & C & (Val(CStr(CDbl(CustSearch(x, 1)) * 10000))) & C & (Val(CStr(CDbl(CustSearch(x, 2)) * 10000))) & C
                    strCMD(1) = StepSize(Val(CustSearch(x, 3)), 1) & C & strbuff2(1) & C & CustSearch(x, 5) & C
                    strCMD(2) = intDelay & C & CustSearch(x, 7)
                    Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2))
                End If
            Next x
        End If 'send custom scanner settings


        If chkGlobalLO.CheckState = 1 Then
            'locked out frequency ranges
            strCurOp = "Sending Global Frequency Lockouts..."
            For x = 1 To MaxSearchLockout

                If strSearchLockout(x) <> "" And strSearchLockout(x) <> 0 Then


                    Response = SendCMD("LOF," & (Val(CStr(strSearchLockout(x) * 10000))))
                    Call CheckMem("C")
                End If
            Next x
        End If
        'find out which sites we are doing
        For intList = 0 To lstSystems.Items.Count - 1
            blnSysOK = True
            lstSystems.SelectedIndex = intList
            If lstSystems.GetItemChecked(intList) = True Then
                'Approve this site for this scanner
                If varSite(intSystem, 0, 0, 3) = "8" Then
                    blnSysOK = False
                    Call GenLog("System " & varSite(intSystem, 0, 0, 1) & " is a P25 Single Frequency Trunk system and is only supported by the BCD396XT, BCD325P2, BCD996P2 and the BCD996XT. As a result, it will not get uploaded.")
                    sngErr = sngErr + 1
                ElseIf varSite(intSystem, 0, 0, 3) = "7" And blnAnalog Then
                    blnSysOK = False
                    Call GenLog("System " & varSite(intSystem, 0, 0, 1) & " is a P25 system and is only supported by the digital scanners. As a result, it will not get uploaded.")
                    sngErr = sngErr + 1
                End If
                intSystem = intSystems(intList)
                If varSite(intSystem, 0, 0, 3) = "1" Then
                    'create system, store
                    strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1))
                    intIndex = Val(SendCMD("CSY,CNV"))
                    'Begin applying site setting
                    'begin translating
                    intSitesFound = intSitesFound + 1
                    strName = varSite(intSystem, 0, 0, 1)
                    strQK = varSite(intSystem, 0, 0, 4)
                    intHoldTime = Val(varSite(intSystem, 0, 0, 5))
                    intLockout = Val(varSite(intSystem, 0, 0, 2))
                    intDelay = Val(MakeDelay(varSite(intSystem, 0, 0, 6), False))
                    intDataSkip = Val(varSite(intSystem, 0, 0, 9))
                    intEMG = Val(varSite(intSystem, 0, 0, 8))
                    varSite(intSystem, 0, 0, 34) = "0" ' clear sys change flag
                    Call CheckMem("")
                    If Bln246 = False Then
                        strCMD(0) = "SIN," & intIndex & "," & strName & "," & strQK & "," & intHoldTime & "," & intLockout & C & intDelay & C
                        If blnBR330T = False Then
                            strCMD(1) = intDataSkip & C & C & C & "AUTO,8"
                        Else
                            strCMD(1) = intDataSkip & C & C & C & C
                        End If
                    Else
                        strCMD(0) = "SIN," & intIndex & "," & strName & "," & Make246QK(strQK) & "," & intHoldTime & "," & intLockout & C & C & intDelay & C
                        strCMD(1) = intDataSkip & C
                    End If

                    Response = SendCMD(strCMD(0) & strCMD(1))
                    'START GROUP LOOP
                    If Val(varSite(intSystem, 0, 0, 10)) > 0 Then 'are there any groups in this system?
                        For intGroup = 1 To MaxGroups
                            If varSite(intSystem, intGroup, 0, 2) <> "" Then 'is this a valid group?
                                'begin programming group
                                strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intGroup, 0, 1))
                                intGroupsFound = intGroupsFound + 1
                                intGroupIndex = Val(SendCMD("AGC," & intIndex))
                                If Bln246 = False Then
                                    strCMD(0) = "GIN," & intGroupIndex & "," & varSite(intSystem, intGroup, 0, 1) & "," & varSite(intSystem, intGroup, 0, 2) & "," & varSite(intSystem, intGroup, 0, 3)
                                Else
                                    strCMD(0) = "GIN," & intGroupIndex & "," & varSite(intSystem, intGroup, 0, 1) & "," & Make246QK(varSite(intSystem, intGroup, 0, 2)) & "," & varSite(intSystem, intGroup, 0, 3)
                                End If
                                Call CheckMem("")
                                Response = SendCMD(strCMD(0))
                                If Response = "-1" Then
                                    MsgBox("Insufficient scanner resources to continue. Aborting.")
                                    ResponseCode = SendCMD("EPG")
                                    sngErr = sngErr + 1
                                    msc.Close()
                                    Exit Sub
                                End If

                                'BEGIN CHANNEL LOOP
                                For intChan = 1 To MaxChan
                                    If ChanInfo(intChan, 10) = varSite(intSystem, intGroup, 0, 10) Then
                                        'valid channel
                                        If blnAnalog = True And ChanInfo(intChan, 12) = "2" Then
                                            'skip it
                                            intChnSkip = intChnSkip + 1
                                            strCurOp = Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intGroup, 0, 1)) & "\"
                                            strCurOp = strCurOp & ChanInfo(intChan, 1) & " " & Val(ChanInfo(intChan, 2)).ToString("###0.0000") & "MHz is digital, skipped."
                                        Else
                                            intChannelsFound = intChannelsFound + 1
                                            strChanName = ChanInfo(intChan, 1)
                                            dblFreq = (Val(ChanInfo(intChan, 2)) * 10000)
                                            strModMode = ModMode(Val(ChanInfo(intChan, 4)))
                                            If strModMode = "WFM" And Bln246 = True Then strModMode = "FM" 'CHECK FOR COMPATIBLE MODE
                                            intCTCSS = Val(ChanInfo(intChan, 9))
                                            intToneLock = Val(ChanInfo(intChan, 11))
                                            intLockout = Val(ChanInfo(intChan, 5))
                                            intPri = Val(ChanInfo(intChan, 7))
                                            intAtt = Val(ChanInfo(intChan, 6))
                                            intAlert = Val(ChanInfo(intChan, 8))
                                            If dblFreq > 0 Then
                                                intChannelIndex = Val(SendCMD("ACC," & intGroupIndex))
                                            Else
                                                intChannelsFound = intChannelsFound - 1
                                                intChnSkip = intChnSkip + 1
                                                strCurOp = Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intGroup, 0, 1)) & "\"
                                                strCurOp = strCurOp & ChanInfo(intChan, 1) & " is 0Mhz, skipped."
                                            End If
                                            If intChannelIndex = 0 Or intChannelIndex = -1 Then
                                                If dblFreq > 0 Then
                                                    sngErr = sngErr + 1
                                                    MsgBox("Critical error, invalid response code or insufficient resources, aborting present system")
                                                    intChan = MaxChan
                                                    intGroup = MaxGroups
                                                End If
                                            End If
                                            If Bln246 = False Then
                                                strCMD(0) = "CIN," & intChannelIndex & "," & strChanName & "," & dblFreq & "," & strModMode
                                                strCMD(1) = "," & intCTCSS & "," & intToneLock & "," & intLockout & "," & intPri & "," & intAtt
                                                strCMD(2) = "," & intAlert & C & ChanInfo(intChan, 13)
                                            Else
                                                strBuff1 = StepSize(Val(ChanInfo(intChan, 19)), 1)
                                                strCMD(0) = "CIN," & intChannelIndex & "," & strChanName & C & dblFreq & C & strBuff1 & C & strModMode
                                                strCMD(1) = "," & intCTCSS & "," & intToneLock & "," & intLockout & "," & intPri & "," & intAtt
                                                strCMD(2) = "," & intAlert
                                            End If
                                            If dblFreq > 0 Then

                                                ResponseCode = SendCMD(strCMD(0) & strCMD(1) & strCMD(2))
                                                Call CheckMem("C")
                                            End If
                                        End If 'is this a digital channel?
                                    End If 'channel loop
                                Next intChan
                            End If 'is this a valid group
                        Next intGroup
                    End If 'are there any groups in this site?
                    If Bln246 = False Then
                        Call QGLUL396(intIndex, intSystem) 'upload group qk settings
                    Else
                        Call QGLUL246(intIndex, intSystem)
                    End If
                ElseIf Val(varSite(intSystem, 0, 0, 3)) > 1 And bln230 = False And blnSysOK Then
                    '                                                  ****************** start trunk system
                    intGrpSite = 0
                    For intSite = 1 To MaxGroups
                        If varSite(intSystem, intSite, 0, 5) = "3" Then ' is this a valid site to upload?
                            'this will be a trunking system
                            'first create the system
                            '
                            strSysType = SiteType(CInt(varSite(intSystem, intSite, 0, 9)), 1)
                            blnSkipGroup = False
                            If strSysType = "P25S" Or strSysType = "P25F" Then
                                strSysType = "MP25"
                            End If

                            If strSysType = "MP25" And blnBR330T = True Then
                                'do nothing
                                intIndex = -1
                                intChnSkip = intChnSkip + 1
                                blnSkipGroup = True
                                MsgBox("FreeSCAN can not upload a P25 system to an analog scanner", MsgBoxStyle.Exclamation)
                            ElseIf strSysType = "MP25" And Bln246 = True Then
                                intIndex = -1
                                intChnSkip = intChnSkip + 1
                                blnSkipGroup = True
                                MsgBox("FreeSCAN can not upload a P25 system to an analog scanner", MsgBoxStyle.Exclamation)
                            Else

                                intIndex = Val(SendCMD("CSY," & strSysType))
                            End If
                            If intIndex = 0 And strSysType = "M82C" Then
                                'if a custom 800mhz system was attempted and failed then
                                strCMD(3) = "Cannot create a 800Mhz Custom/Rebanded site. This is likely due to your scanner not being loaded with rev 3.0 firmware required to support this site. Other possible cause is scanner is out of memory. As a result, this site will be skipped."
                                cnt = MsgBox(strCMD(3), MsgBoxStyle.Critical, varSite(intSystem, intSite, 0, 1))
                                sngErr = +1
                            End If
                            If intGrpSite = 0 And intIndex > 0 Then intGrpSite = intIndex
                            'Begin applying site setting
                            'begin translating
                            strCurOp = "Sending system " & Trim(varSite(intSystem, intSite, 0, 1))
                            intSitesFound = intSitesFound + 1
                            strName = varSite(intSystem, intSite, 0, 1)
                            strQK = varSite(intSystem, intSite, 0, 2)
                            intHoldTime = Val(varSite(intSystem, intSite, 0, 4))
                            intLockout = Val(varSite(intSystem, intSite, 0, 3))
                            intDelay = Val(MakeDelay(varSite(intSystem, 0, 0, 6), False))
                            intDataSkip = Val(varSite(intSystem, 0, 0, 9))
                            intAtt = Val(varSite(intSystem, intSite, 0, 7))
                            intEmgAlertLevel = Val(varSite(intSystem, 0, 0, 26))
                            varSite(intSystem, 0, 0, 34) = "0" ' clear sys change flag
                            strCMD(0) = "SIN," & intIndex & "," & strName & C & strQK & C & intHoldTime & C & intLockout & C & intDelay & C & intDataSkip & C
                            If blnBR330T = False And Bln246 = False Then '396 mode
                                strCMD(1) = varSite(intSystem, intSite, 0, 6) & C & intAtt & C & varSite(intSystem, intSite, 0, 26) & C & varSite(intSystem, intSite, 0, 27)
                            ElseIf blnBR330T = True Then  '330 mode
                                strCMD(1) = varSite(intSystem, intSite, 0, 6) & C & intAtt & C & C
                            ElseIf Bln246 = True Then
                                If intEmgAlertLevel > 0 Then intEMG = 1
                                strCMD(0) = "SIN," & intIndex & "," & strName & C & Make246QK(strQK) & C & intHoldTime & C & intLockout & C & intAtt & C
                                strCMD(1) = intDelay & C & intDataSkip & C & intEmgAlertLevel
                            End If

                            If strSysType = "MP25" And blnBR330T = True Then
                                Response = "" 'do not upload a MP25 system to the 330
                            ElseIf strSysType = "MP25" And Bln246 = True Then
                                Response = ""
                            Else
                                Response = SendCMD(strCMD(0) & strCMD(1))
                                Call CheckMem("")
                            End If
                            'If this is a rebanded system, send band plan
                            If varSite(intSystem, intSite, 0, 9) = "13" And Val(CStr(intIndex)) > -1 Or varSite(intSystem, intSite, 0, 9) = "16" And Val(CStr(intIndex)) > -1 Then
                                Call CommonSendReband(Val(CStr(intSystem)), intSite, Val(CStr(intIndex)))
                            End If
                            'send TGID Lockout list
                            UploadLOI(varSite(intSystem, 0, 0, 23), CStr(intIndex))
                            'begin trunk settings
                            intIDMode = MakeBinary(varSite(intSystem, 0, 0, 11)) 'id search
                            intEDACSFormat = MakeBinary(varSite(intSystem, 0, 0, 14))
                            intStatusBit = Val(varSite(intSystem, 0, 0, 12))
                            intEndCode = Val(varSite(intSystem, 0, 0, 13))
                            intICALL = Val(varSite(intSystem, 0, 0, 15))
                            intConCh = Val(varSite(intSystem, intSite, 0, 8))
                            intFleetMap = Val(varSite(intSystem, 0, 0, 16))
                            strCustFleetMap = MakeFleetMap(varSite(intSystem, 0, 0, 17))
                            intEmgAlertType = Val(varSite(intSystem, 0, 0, 25))
                            'setup for MBP
                            intBase(0) = GetBPParam(intSystem, intSite, 0, 0)
                            intBase(1) = GetBPParam(intSystem, intSite, 0, 1)
                            intBase(2) = GetBPParam(intSystem, intSite, 0, 2)
                            intMStep(0) = GetBPParam(intSystem, intSite, 2, 0)
                            intMStep(1) = GetBPParam(intSystem, intSite, 2, 1)
                            intMStep(2) = GetBPParam(intSystem, intSite, 2, 2)
                            intOffset(0) = GetBPParam(intSystem, intSite, 3, 0)
                            intOffset(1) = GetBPParam(intSystem, intSite, 3, 1)
                            intOffset(2) = GetBPParam(intSystem, intSite, 3, 2)
                            If varSite(intSystem, 0, 0, 3) <> "2" Then
                                strCustFleetMap = ""
                            End If
                            intDigCode = Val(varSite(intSystem, 0, 0, 27))
                            If Bln246 = False Then 'use trn command for 330/396
                                If strSysType = "M82S" Or strSysType = "M82P" Or strSysType = "M82C" Then
                                    strCMD(0) = "TRN," & intIndex & "," & intIDMode & "," & intStatusBit & "," & intEndCode & "," & intEDACSFormat & C
                                    strCMD(1) = intICALL & C & intConCh & C & intEmgAlertType & C & intEmgAlertLevel & C & C & C
                                    strCMD(2) = intBase(0) & C & intMStep(0) & C & intOffset(0) & C & intBase(1) & C & intMStep(1) & C
                                    strCMD(3) = intOffset(1) & C & intBase(2) & C & intMStep(2) & C & intOffset(2) & C & intDigCode
                                ElseIf intIndex > -1 Then  'dont send the fleetmap
                                    strCMD(0) = "TRN," & intIndex & "," & intIDMode & "," & intStatusBit & "," & intEndCode & "," & intEDACSFormat & C
                                    strCMD(1) = intICALL & C & intConCh & C & intEmgAlertType & C & intEmgAlertLevel & C & intFleetMap & C & strCustFleetMap & C
                                    strCMD(2) = intBase(0) & C & intMStep(0) & C & intOffset(0) & C & intBase(1) & C & intMStep(1) & C
                                    strCMD(3) = intOffset(1) & C & intBase(2) & C & intMStep(2) & C & intOffset(2) & C & intDigCode
                                End If
                            Else 'this TRN command is for the 246
                                If strSysType = "M82S" Or strSysType = "M82P" Or strSysType = "M82C" Then
                                    strCMD(0) = "TRN," & intIndex & "," & intIDMode & "," & intStatusBit & "," & intEndCode & "," & intEDACSFormat & C
                                    strCMD(1) = intICALL & C & intConCh & C & C & C
                                    strCMD(2) = intBase(0) & C & intMStep(0) & C & intOffset(0) & C & intBase(1) & C & intMStep(1) & C
                                    strCMD(3) = intOffset(1) & C & intBase(2) & C & intMStep(2) & C & intOffset(2)
                                Else
                                    strCMD(0) = "TRN," & intIndex & "," & intIDMode & "," & intStatusBit & "," & intEndCode & "," & intEDACSFormat & C
                                    strCMD(1) = intICALL & C & intConCh & C & intFleetMap & C & strCustFleetMap & C
                                    strCMD(2) = intBase(0) & C & intMStep(0) & C & intOffset(0) & C & intBase(1) & C & intMStep(1) & C
                                    strCMD(3) = intOffset(1) & C & intBase(2) & C & intMStep(2) & C & intOffset(2)
                                End If
                            End If
                            If intIndex > 0 Then
                                Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3))
                            End If

                            'Retrieves the site index
                            If intIndex > -1 Then 'dont perform this step if we skipped a mp25 system
                                Response = SendCMD("SIN," & intIndex)
                                If Bln246 = False Then
                                    intSiteIndex = Val(ParaParse(Response, 14))
                                Else
                                    intSiteIndex = Val(ParaParse(Response, 12))
                                End If
                            Else
                                intSiteIndex = -1
                            End If
                            'while the system index is available, upload frequencies

                            intSeqIndex = intSiteIndex 'EQUALS THE INDEX NUMBER FOR THE SITE
                            If intSeqIndex > 0 Then ' is this a valid site?
                                intTrunkChan = 0
                                strCurOp = "Sending system " & Trim(varSite(intSystem, intSite, 0, 1)) & "\Trunk Frequencies"
                                For intChan = 1 To MaxTrunkFreq 'search through every trunk freq, if applicable then upload to scanner
                                    If strTrunkFreq(intChan, 2) = varSite(intSystem, intSite, 0, 10) And strTrunkFreq(intChan, 2) <> "" Then 'is this a valid trunk frequency? Then upload!
                                        Response = SendCMD("ACC," & intSeqIndex)
                                        If Response = "-1" Then
                                            sngErr = sngErr + 1

                                            intChan = MaxTrunkFreq

                                            intGroup = MaxGroups
                                            intList = lstSystems.Items.Count - 1
                                            MsgBox("The scanner has insufficient memory to continue. Aborting")
                                        End If
                                        If Response <> "ERR" Then
                                            If IsNumeric(Response) Then intChannelIndex = CInt(Response)
                                            intTrunkChan = intTrunkChan + 1
                                            intChannelsFound = intChannelsFound + 1

                                            If Val(strTrunkFreq(intChan, 1)) <> 0 Then 'preserve LCN

                                                intTrunkChan = Val(strTrunkFreq(intChan, 1))
                                            End If
                                            If Bln246 = False Then
                                                Response = SendCMD("TFQ," & intChannelIndex & "," & (Val(strTrunkFreq(intChan, 0)) * 10000) & "," & intTrunkChan & C & MakeBinary(strTrunkFreq(intChan, 3)))
                                            Else
                                                Response = SendCMD("TFQ," & intChannelIndex & "," & (Val(strTrunkFreq(intChan, 0)) * 10000) & "," & intTrunkChan)
                                            End If
                                            Call CheckMem("C")
                                        Else
                                            sngErr = sngErr + 1
                                            Call GenLog("Cannot add trunk frequency " & strTrunkFreq(intChan, 0))
                                        End If
                                    End If
                                Next intChan

                                If varSite(intSystem, intSite, 0, 9) = "6" And blnBR330T = False And Bln246 = False And bln230 = False Then 'this is a P25 system on a 396
                                    Call CommonABP(intSystem, intSite, intIndex)

                                End If
                            End If 'intseqindex>0


                            'That was fun, now add channel groups
                            'intIndex = intSiteIndex
                            For intGroup = 1 To MaxGroups
                                If Val(varSite(intSystem, intGroup, 0, 5)) = 2 Then 'is this a valid group?
                                    'begin programming group
                                    intGroupIndex = Val(SendCMD("AGT," & intIndex))
                                    strCMD(0) = "GIN," & intGroupIndex & "," & varSite(intSystem, intGroup, 0, 1) & "," & varSite(intSystem, intGroup, 0, 2) & "," & varSite(intSystem, intGroup, 0, 3)
                                    Response = SendCMD(strCMD(0))
                                    strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intGroup, 0, 1))
                                    intGroupsFound = intGroupsFound + 1
                                    If Response <> "OK" Then
                                        MsgBox("Failed adding group " & varSite(intSystem, intGroup, 0, 1) & ". Scanner may be out of memory")
                                        intGroup = MaxGroups
                                        MemErrCount += 1
                                        sngErr = sngErr + 1
                                    End If

                                    If MemErrCount = 5 Then
                                        'Way too many errors, abort upload
                                        MsgBox("Too many error uploading - scanner may be out of memory. Aborting")
                                        intList = 9999
                                    End If
                                    Call CheckMem("")
                                    'BEGIN CHANNEL LOOP
                                    For intChan = 1 To MaxChan
                                        If ChanInfo(intChan, 10) = varSite(intSystem, intGroup, 0, 10) Then
                                            'valid channel
                                            If blnAnalog = True And ChanInfo(intChan, 6) = "2" Then 'skip uploading a digital channel to analog scanner
                                            Else
                                                intChannelIndex = Val(SendCMD("ACT," & intGroupIndex)) 'append channel
                                                If intChannelIndex < 1 Then
                                                    intChan = MaxChan
                                                    intGroup = MaxGroups
                                                    GenLog("ERROR: Scanner max channel or MAX TGID limit reached.")
                                                    sngErr += 1
                                                    strLog &= "out of TGID memory"
                                                    lblOp.Text = strCurOp
                                                Else
                                                    strbuff2(0) = Trim(ChanInfo(intChan, 2))
                                                    If ChanInfo(intChan, 1) <> "" Then
                                                        strName = ChanInfo(intChan, 1)
                                                    Else
                                                        strName = "ID: " & strbuff2(0)
                                                    End If
                                                    If Bln246 = False Then 'THIS IS FOR 396!!!
                                                        strCMD(0) = ("TIN," & intChannelIndex & C & strName & C)
                                                        strCMD(1) = strbuff2(0) & C & ChanInfo(intChan, 3) & C
                                                        strCMD(2) = MakeBinary(ChanInfo(intChan, 8)) & C & ChanInfo(intChan, 4) & C & ChanInfo(intChan, 5) 'alert
                                                    Else 'THIS IS 246
                                                        strCMD(0) = ("TIN," & intChannelIndex & C & strName & C)
                                                        strCMD(1) = strbuff2(0) & C & ChanInfo(intChan, 3) & C
                                                        strCMD(2) = MakeBinary(ChanInfo(intChan, 5))
                                                    End If
                                                    Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2))
                                                    Call CheckMem("C")
                                                    intChannelsFound += 1
                                                End If
                                            End If 'blnanalog=true
                                        End If 'channel loop
                                    Next intChan 'channel loop
                                End If 'is this a valid group?
                            Next intGroup 'top loop of this section
                        End If ' is this a valid site to upload?
                    Next intSite
                    '                                                                  *******************************end trunk system

                    If Bln246 = False Then
                        Call QGLUL396(intIndex, intSystem) 'upload group qk settings
                    Else
                        Call QGLUL246(intIndex, intSystem)
                    End If
                End If 'end the big system? loop
            End If
        Next intList

        'upload system quick key on/off settings
        If chkSysQK.CheckState = 1 Then
            If Bln246 = False Then
                UploadQSL()

            Else
                strQGL = ""
                strBuff1 = RadioSetting(12)
                If Len(strBuff1) = 100 Then
                    For intIndex = 1 To 10
                        If Mid(strBuff1, intIndex, 1) = "1" Then
                            strQGL = strQGL & "1"
                        Else
                            strQGL = strQGL & "0"
                        End If
                    Next intIndex
                Else
                    strQGL = "111111111"
                End If

                ResponseCode = SendCMD("QSL," & strQGL)
            End If
        End If

        strCurOp = "Finished uploading. Click on 'Close' to continue"
        If Bln396 Or blnBR330T Then
            Call RestoreVolSql(strMDL)
        End If
        ResponseCode = SendCMD("EPG")
        CheckResume()
        SetFinishGraphic()
        msc.Close()
        If Me.Visible = True Then
            cmdClose.Focus()
        Else
            With lblSiteNote
                If sngErr = 0 Then
                    .DispStat("Upload complete with no errors")
                Else
                    .DispStat("Errors during upload")
                    Me.Visible = True
                End If
            End With
        End If
        Exit Sub

criticerror:
        lblOp.Text = "ERROR " & Err.Number
        IOGraphic(("F"))
        Call ErrorHandler(Err.Number, strLog)
        If msc.IsOpen = True Then msc.Close()


    End Sub
    Function Make246QK(ByRef strQK As String) As String
        'this converts QKs to be compatible with the 246

        If Val(strQK) > 9 Then

            strQK = "."
        End If


        Make246QK = strQK
    End Function
    Sub QGLUL246(ByRef intIndex As Integer, ByRef intSite As Integer)
        'upload quick key group selection setting

        intIndex = Val(intIndex)
        Dim ResponseCode, strQGL As String
        strQGL = Nothing

        If Val(intIndex) > 0 And Val(intSite) > 0 Then

            strQGL = varSite(intSite, 0, 0, 8)
        End If
        If Len(strQGL) <> 10 Or IsNumeric(strQGL) = False Then
            strQGL = "1111111111"
        End If


        ResponseCode = SendCMD("QGL," & intIndex & "," & strQGL)
    End Sub
    Sub UploadQSL()
        If blnDebug = False Then On Error Resume Next
        'uploads the quick key system status to the 396
        Dim strBuff1, strBuff, strQSL As String
        Dim cnt As Integer
        strQSL = RadioSetting(12)
        'if there is bad data then just enable everything
        If Len(strQSL) <> 100 Or IsNumeric(strQSL) = False Then
            strQSL = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111"
        End If
        'Now take that string and insert commas
        strBuff = ""
        For cnt = 1 To 10
            strBuff = strBuff & VB.Left(strQSL, 10)
            strQSL = VB.Right(strQSL, Len(strQSL) - 10)
            strBuff = strBuff & ","
        Next cnt
        strBuff = VB.Left(strBuff, 109)

        strBuff1 = SendCMD("QSL," & strBuff)
    End Sub
    Sub CheckResume()
        Dim Response As String
        'automatically resume scanning
        If chkResume.CheckState = 1 Then

            Response = SendCMD("KEY,S,P")
        End If
    End Sub
    Function MakeFleetMap(ByRef strMap As String) As String
        'This takes the custom fleet map paramaters saved in file
        'and converts them to a format uploadable directly to scanner

        Dim strFleet As String
        Dim strSizeCode, strMap1 As String
        Dim intPos As Integer
        strMap1 = Nothing
        For intPos = 0 To 7
            strFleet = strMap
            If Len(strFleet) = 24 Then
                strSizeCode = Mid(strFleet, (3 * intPos) + 2, 2)
                If Val(strSizeCode) <= 9 Then
                    strMap1 = strMap1 & Val(strSizeCode)
                Else
                    strMap1 = strMap1 & Chr(55 + CDbl(strSizeCode))
                End If
            End If
        Next intPos
        If Len(strMap1) <> 8 Then
            strMap1 = "00000000"
        End If

        MakeFleetMap = strMap1
    End Function
    Sub LoadList()
        lstSystems.Items.Clear()

        Dim strSysArray(MaxSystems, 2) As String
        Dim x As Integer
        Dim best_value(2) As String

        Dim GrpOrder(MaxGroups, 4) As String  ' 0=Index, 1=Name, 2=QK, 3=Type (short string MOT2)'4=how many groups/sites
        Dim intGrpIndex As Integer = 0
        Dim SortMode As String
        Dim intsyscnt As Integer
        Dim SysOrder(MaxSystems, 4) As String ' 0=Index, 1=Name, 2=QK, 3=Type (short string MOT2)
        'loads all sites into the list for user picking
        'determine how many systems need to be drawn
        SortMode = GetSetting("FreeSCAN", "Settings", "SortOrder", "0")
        SysOrder = lblSiteNote.GetSysArray(SortMode)
        intSysCnt = Val(SysOrder(0, 4))
        System.Array.Clear(intSystems, 0, intSystems.Length)
        SysOrder = lblSiteNote.GetSysArray(SortMode)
        For x = 0 To intsyscnt
            'Begin drawing the tree for that site
            lstSystems.Items.Add(SysOrder(x, 1))
            intSystems(x) = Val(SysOrder(x, 0))
        Next x
        Call cmdChkChange_Click(Nothing, Nothing)
        If lstSystems.Items.Count > 0 Then
            lstSystems.SelectedIndex = 0
        End If
    End Sub



    Private Sub chkAnalog_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAnalog.CheckStateChanged
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub


    Private Sub chkGlobalLO_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkGlobalLO.CheckStateChanged
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub


    Private Sub cmdAbort_Click()
        If msc.IsOpen = True Then msc.Close()

    End Sub


    Private Sub chkResume_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkResume.CheckStateChanged
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub


    Private Sub chkSysQK_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSysQK.CheckStateChanged
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub


    Private Sub chkUploadCustomSettings_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkUploadCustomSettings.CheckStateChanged
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub

    Private Sub cmdChkAllSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdChkAllSys.Click
        'checks all  items in list box
        Dim x As Integer
        For x = 0 To lstSystems.Items.Count - 1
            lstSystems.SelectedIndex = x
            lstSystems.SetItemChecked(x, True)
        Next x

    End Sub

    Private Sub cmdClearAllSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearAllSys.Click
        'checks all  items in list box
        Dim x As Integer
        For x = 0 To lstSystems.Items.Count - 1
            lstSystems.SelectedIndex = x
            lstSystems.SetItemChecked(x, False)
        Next x

    End Sub

    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
        Me.Visible = False
        lblSiteNote.Visible = True
        lblSiteNote.Enabled = True
        lblSiteNote.Activate()
        lblSiteNote.UpdateViewMode()
        Call GenLog("CLEARALL")
    End Sub

    Private Sub cmdComSetup_Click()
        Me.Enabled = False
        frmCOMPort.Visible = True
        frmCOMPort.Activate()

    End Sub

    Private Sub cmdCopyDownload_Click()
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(strLog)
        MsgBox(Len(strLog) & " bytes copied to clipboard.")
    End Sub

    Sub SetWriteMode()
        If blnDebug = False Then On Error GoTo criticerror
        Dim Response As String
        Dim intNukeEm(1000) As String
        Dim intSysIndex, intScanSys, intSite As Integer
        Dim intCnt, intLocalSys, intPos As Integer
        Dim intOldTimer As Integer
        Dim blnHH As Boolean
        Dim strSysname, sLocalSys, sScannerSys As String
        Dim ChkItem As ListView.CheckedIndexCollection
        If optWriteMode(0).Checked Then
            'wipe all systems
            strCurOp = "Clearing scanner memory - Please Wait..."
            Response = SendCMD("CLR")
        ElseIf optWriteMode(1).Checked Then
            'replace systems.......
            'grab a list of systems already on the scanner
            With frmCommsDownload
                msc.Close()
                Call frmCommsDownload.cmdQueueSystems_Click(Nothing, New System.EventArgs())
                Do Until msc.IsOpen = False
                    System.Windows.Forms.Application.DoEvents()
                Loop
                msc.Open()
                Response = SendCMD("PRG")
                'is this a handheld scanner?
                blnHH = False

                Response = SendCMD("MDL")
                If InStr(Response, "330") <> 0 Or InStr(Response, "396T") <> 0 Or InStr(Response, "246") <> 0 Then
                    blnHH = True
                End If
                'if there are any systems on the list to upload that have the same name as the ones to upload, erase them

                For intScanSys = 0 To .lstSystems.Items.Count - 1 'scan the remote list
                    For intLocalSys = 0 To Me.lstSystems.CheckedItems.Count - 1 'scan the local list, only care about checked items
                        sLocalSys = Trim(RemoveType(Me.lstSystems.GetItemText(Me.lstSystems.CheckedItems.Item(intLocalSys))))
                        sScannerSys = .lstSystems.GetItemText(.lstSystems.Items.Item(intScanSys))
                        sScannerSys = Trim(RemoveType(sScannerSys))
                        If String.Equals(sLocalSys, sScannerSys, StringComparison.CurrentCultureIgnoreCase) Then
                            'This is an existing system on the scanner, scheduale to nuke it
                            intSysIndex += 1
                            intNukeEm(intSysIndex) = Val(lstArray(intScanSys, 0))
                        End If

                    Next intLocalSys
                Next intScanSys
            End With
            'need to insert site search code here??
            'on one site only scanners, search through each site of each checked system to see if it exists
            If blnHH = True Then
                For intLocalSys = 0 To lstSystems.Items.Count - 1 'go through each item on the upload selection list
                    If lstSystems.GetItemChecked(intLocalSys) Then 'is it selected
                        'go through every site belonging to this system and find out if its in the scanner already
                        For intSite = 1 To MaxGroups
                            For intScanSys = 0 To frmCommsDownload.lstSystems.Items.Count - 1

                                strSysname = Trim(RemoveType((frmCommsDownload.lstSystems.Items.Item(intScanSys).ToString)))

                                If varSite(intSystems(intLocalSys), intSite, 0, 5) = "3" And Trim(varSite(intSystems(intLocalSys), intSite, 0, 1)) = strSysname Then
                                    intSysIndex = intSysIndex + 1

                                    intNukeEm(intSysIndex) = Val(lstArray(intScanSys, 0))
                                End If
                            Next intScanSys
                        Next intSite
                    End If
                Next intLocalSys
            End If
            If intSysIndex >= 1 Then
                'if there are systems to delete, delete them now
                For intCnt = 1 To intSysIndex
                    strCurOp = "Deleting system " & intCnt & " of " & intSysIndex & ". Please wait..."
                    Call CheckMem("")


                    Response = SendCMD("DSY," & intNukeEm(intCnt))
                    Call CheckMem("")
                Next intCnt
            End If

        Else 'only add
            'do nothing
        End If
        Exit Sub
criticerror:
        MsgBox("Critical error, unable to replace systems. Some systems may appear twice on your scanner.")
        If msc.IsOpen = False Then msc.Open()
    End Sub
    Sub CommonToneOut(ByRef blnXT As Boolean, ByVal strMDL As String)
        'upload toneout settings to radio
        Dim strBuff() As String
        Dim strBuff1() As String
        Dim strbuff2() As String
        Dim strbuff3() As String
        Dim strBuff4() As String
        Dim strBuff5() As String
        Dim strBuff6() As String
        Dim strCMD, Response, ALT_COLOR, ALT_PATTERN As String
        Dim cnt, intTonIndex As Integer
        Dim sngTone1, sngTone2 As Single
        Dim strBuff7() As String
        Dim strBuff8() As String
        Dim strBuff9() As String
        Dim ATT() As String
        Dim MODMode() As String
        Dim AGC() As String

        'get settings into buffer
        If Not blnDebug Then On Error GoTo criticerror
        strBuff = Split(RadioSetting(74), Chr(9)) 'name
        strBuff1 = Split(RadioSetting(75), Chr(9)) 'frequency
        strbuff2 = Split(RadioSetting(76), Chr(9)) 'tone out freqs
        strbuff3 = Split(RadioSetting(77), Chr(9)) 'alert type
        strBuff5 = Split(RadioSetting(78), Chr(9)) 'alert level
        strBuff6 = Split(RadioSetting(79), Chr(9)) 'delay time
        strBuff7 = Split(RadioSetting(80), Chr(9)) 'record on/off
        strBuff8 = Split(RadioSetting(90), ",") 'alert colour
        strBuff9 = Split(RadioSetting(91), ",") 'alert pattern
        ATT = Split(RadioSetting(82), ",") 'attenuation
        AGC = Split(RadioSetting(92), ",") 'agc
        MODMode = Split(RadioSetting(81), ",")

        If UBound(strBuff1) = 45 And UBound(MODMode) = 9 And UBound(AGC) = 9 And UBound(ATT) = 9 Then
            For cnt = 1 To 10
                intTonIndex = cnt
                If cnt = 10 Then intTonIndex = 0 'make up for uniden weirdness
                'set defaults
                If strBuff6(cnt - 1) = "" Then strBuff6(cnt - 1) = "2" 'delay time
                sngTone1 = Val(strbuff2((cnt - 1) * 2)) * 10
                sngTone2 = Val(strbuff2(((cnt - 1) * 2) + 1)) * 10
                ALT_COLOR = strBuff8(cnt - 1)
                ALT_PATTERN = strBuff9(cnt - 1)
                ALT_PATTERN = ChgAlertCode(ALT_PATTERN, ALT_COLOR, strMDL)
                strCMD = "TON," & intTonIndex & "," & MakeItKosher(strBuff(cnt - 1)) & "," & (Val(strBuff1(cnt - 1)) * 10000) & "," & MODMode(cnt - 1) & "," & MakeBinary(ATT(cnt - 1)) & ","
                strCMD = strCMD & strBuff6(cnt - 1) & "," & Val(strbuff3(cnt - 1)) & "," & Val(strBuff5(cnt - 1)) & ","
                If blnXT = False Then
                    strCMD = strCMD & sngTone1 & ",," & sngTone2 & ",,," & Val(strBuff7(cnt - 1))
                Else
                    strCMD = strCMD & sngTone1 & ",," & sngTone2 & ",,,," & ALT_COLOR & "," & ALT_PATTERN & "," & AGC(cnt - 1) & ",,"
                End If

                Response = SendCMD(strCMD)
                If Response <> "OK" Then
                    sngErr += 1
                    GenLog("Fire Tone Out Error - Line " & cnt)
                End If
            Next cnt
        Else
            sngErr += 1
            GenLog("Fire Tone Out settings are invalid - cannot upload")
        End If
        Exit Sub
criticerror:
        sngErr += 1
        GenLog("FTO Error, may need to reinitalize settings. FTO Upload aborted.")
    End Sub


    Sub CommonAGC()
        'sets up AGC gain paramters
        Dim strBuff() As String
        Dim strBuff1, Response As String
        strBuff = Split(RadioSetting(87), ",")
        If UBound(strBuff) = 5 Then
            strBuff1 = "AGS," & RadioSetting(87)

            strBuff(0) = SendCMD(strBuff1)
            If strBuff(0) <> "OK" Then
                sngErr += 1
                GenLog("Error setting AGC")
            End If
        End If
        If RadioSetting(88) <> "" And IsNumeric(RadioSetting(88)) = True Then
            'send P25 wait time

            Response = SendCMD("PWT," & RadioSetting(88))
            If Response <> "OK" Then
                sngErr += 1
                GenLog("Error setting Global P25 wait time.")
            End If
        End If
    End Sub

    Private Sub cmdFlash_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFlash.Click

        If blnDebug = False Then On Error GoTo criticerror
        Dim strCMD(5) As String
        Dim strChanName, strName, strQK, strModMode As String
        Dim Response As String
        Dim intSystem, intGroup, lngChannelIndex As Integer
        Dim intIndex, intChan, intToneLock, intGroupIndex As Integer
        Dim intEMG, intDelay, intAtt, intLockout, intRecord, intDataSkip, intCTCSS As Integer
        Dim intHoldTime, intLO As Integer
        Dim dblFreq As Double
        Dim intPri As Integer
        Dim intAlert, intTrunkChan As Integer
        Dim ResponseCode, strNAC As String
        Dim I_CALL, End_Code, ID_Search, S_Bit, AFS, intConCh As Integer
        Dim AGC_ANALOG As String, AGC_DIGITAL As String, P25WAITING As String
        Dim FMAP As String
        Dim strCustFleetMap, C As String
        Dim intBase(2) As Double
        Dim intOffset(2) As Double
        Dim intMStep(2) As Double
        Dim strSysType, strAGV() As String
        Dim cnt, x, intSeqIndex, intList, intGPSEnable As Integer
        Dim strStartKey As String
        Dim intSite, intSiteIndex As Integer
        Dim strLong As String, strLat As String
        Dim EMG, EMGL, intDigCode As Integer
        Dim Bln396XT, Bln996, bln346, bln15XT, bln996XT, bln325P2, blnXT, DMRCapable As Boolean
        Dim blnAnalog, blnBC15, blnSysOK As Boolean
        Dim NumTag As String
        Dim strSIN As String, strRange, Vol_Offset, CODE_SRCH, Audio_Type As String
        Dim ALT_PATTERN, ALT_COLOR, BAND_NO, STP, strMOD, DISP_UID, STATE As String
        Dim strBuff As String
        strLog = ""

        C = ","
        blnBC15 = False
        DMRCapable = False
        Call GenLog("CLEARALL")
        If RemoteMode() = True Then Exit Sub
        If msc.IsOpen = True Then msc.Close()


        Call initForm()
        SetDLMode()
        'load programming onto radio
        'check com port settings
        If Val(RadioSetting(44)) = 0 Then 'nocomport num
            MsgBox("Please choose a COM port before continuing.")
            Exit Sub
        End If
        If Val(RadioSetting(45)) = 0 Then 'baud rate
            MsgBox("Please set COM Port speed before continuing.")
            Exit Sub
        End If

        msc.PortName = "COM" & RadioSetting(44)
        msc.BaudRate = Val(RadioSetting(45))
        If COMPortExists() = False Then
            Exit Sub
        End If
        msc.Open()
        blnRmtCtlMode = False

        strMDL = SendCMD("MDL")

        If strMDL = "UBC800XLT" Then
            strMDL = "BCT15"
        End If
        Response = SendCMD("EPG")
        If Strings.Left(strMDL, 1) = "U" Then
            strMDL = Strings.Right(strMDL, Len(strMDL) - 1)
        End If

        If strMDL = "-1" Then
            Me.msc.Close()
            lblOp.Text = "Serial port error"
            MsgBox("FreeSCAN is unable to establish communications with the scanner. Check your COM port settings.")
            IOGraphic(("F"))
            Call mnuScannerCOMPort_Click(mnuScannerCOMPort, New System.EventArgs())
            Exit Sub
        ElseIf strMDL = "BCD996XT" Or strMDL = "BCD996P2" Then
            bln996XT = True
            blnXT = True
            DMRCapable = True
        ElseIf strMDL = "BCT15X" Then
            bln15XT = True
            blnXT = True
            blnAnalog = True
        ElseIf InStr(SupportedScanners, strMDL) = 0 Then  'lecture user

            Response = SendCMD("EPG")
            Me.msc.Close()
            lblOp.Text = "Incompatible scanner."
            MsgBox("This version of FreeSCAN is only designed for the " & SupportedScanners & ".It will not work with other types. If you are using one of these scanners, then you need to recheck your COM port settings.")
            IOGraphic(("F"))
            Exit Sub
        ElseIf InStr(strMDL, "BCT15") <> 0 Then
            blnBC15 = True
            blnAnalog = True
        ElseIf InStr(strMDL, "996T") <> 0 Then
            Bln996 = True
        ElseIf InStr(strMDL, "BC346XT") <> 0 Then
            bln346 = True
            blnAnalog = True
            blnXT = True
        ElseIf InStr(strMDL, "BCD396XT") <> 0 Then
            Bln396XT = True
            blnXT = True
        ElseIf InStr(strMDL, "BCD325P2") <> 0 Then
            Bln396XT = True
            bln325P2 = True
            blnXT = True
            DMRCapable = True
        ElseIf InStr(strMDL, "246") <> 0 Or InStr(strMDL, "330") <> 0 Or InStr(strMDL, "396") <> 0 Or InStr(strMDL, "230") <> 0 Or InStr(strMDL, "3500") <> 0 Then
            Upload396(strMDL)
            Exit Sub
        End If
        DisableCCO(strMDL, True)

        'erase radio
        If msc.IsOpen = False Then msc.Open()
        strLog = strLog & strProgTitle & vbNewLine


        ResponseCode = SendCMD("PRG")
        If ResponseCode = "NG" Then
            MsgBox("Please exit menu mode before attempting to program.")
            msc.Close()
            Exit Sub
        End If
        If ResponseCode = "ERR" Or ResponseCode = "FAI" Then
            MsgBox("Unexpected error, aborting.")
            msc.Close()
            Exit Sub
        End If
        'Save the volume and sql settings, for the whiners
        If Bln396XT Or bln346 Or bln325P2 Then
            Call SaveVolSql(strMDL)
        End If
        Call CheckMem("")
        SetWriteMode()
        Call CheckMem("")

        'insert radio settings.
        If chkUploadCustomSettings.CheckState = 1 Then
            strCurOp = "Sending scanner settings..."
            If Bln996 Then
                Response = SendCMD("BKL," & UCase(RadioSetting(1) & "," & UCase(RadioSetting(2)))) 'backlight
            ElseIf blnBC15 Then
                Response = SendCMD("BKL," & UCase(RadioSetting(1) & ",RED"))
            ElseIf bln346 Then
                Response = SendCMD("BLT," & RadioSetting(85) & C & C & RadioSetting(95))
            ElseIf bln325P2 Then
                Response = SendCMD("BLT," & RadioSetting(85) & C & C & RadioSetting(95))
            ElseIf Bln396XT Then
                Response = SendCMD("BLT," & RadioSetting(85) & C & RadioSetting(2) & C & RadioSetting(95))
            ElseIf bln996XT Then
                Response = SendCMD("BKL," & UCase(RadioSetting(1) & "," & UCase(RadioSetting(2)))) 'backlight
            ElseIf bln15XT Then
                Response = SendCMD("BKL," & UCase(RadioSetting(1) & ",RED")) 'backlight
            End If
            If Response <> "OK" Then
                sngErr += 1
                GenLog("Error setting backlight")
            End If
            If Not blnXT Then
                Response = SendCMD("PRI," & RadioSetting(3)) 'priority mode
            Else
                Response = SendCMD("PRI," & RadioSetting(3) & C & RadioSetting(89) & C & RadioSetting(93)) 'priority mode
            End If
            If Response <> "OK" Then
                sngErr += 1
                GenLog("Error setting priority")
            End If
            Response = SendCMD("CNT," & RadioSetting(29)) 'lcd contrast
            If Not Bln396XT And Not bln346 Then
                Response = SendCMD("DUD," & RadioSetting(31)) 'lcd orientation
                If Response <> "OK" Then
                    sngErr += 1
                    GenLog("Error on DUD")
                End If
            End If
            If blnXT Then 'send band plan setting
                SendDBC(blnAnalog, strMDL)
            End If
            'display mode & act chan disp on/off
            strBuff = RadioSetting(28)
            If strBuff = "3" And blnXT = False Then
                strBuff = "2"
            End If
            RadioSetting(106) = CStr(Val(RadioSetting(106)))
            DISP_UID = CStr(MakeBinary(RadioSetting(108)))
            If Not blnXT Then
                strCMD(0) = "SCN," & strBuff & C & RadioSetting(30) & C & C & C & C & C & C & C & C & C & C & C & C & C & C & C & C & C & C
            Else
                strCMD(0) = "SCN," & strBuff & C & C & RadioSetting(96) & C & RadioSetting(97) & C & C & RadioSetting(106) & C & DISP_UID & ",,,,,,,,,,,,,,"
            End If

            Response = SendCMD(strCMD(0))
            CommonWX(strMDL)
            CommonToneOut(blnXT, strMDL)

            If Bln996 Then
                Response = SendCMD("AGV," & RadioSetting(25) & C & RadioSetting(26)) 'auto gain  setting
            ElseIf blnBC15 Then
                Response = SendCMD("AGV," & RadioSetting(25) & C) 'auto gain  setting
            ElseIf Bln396XT Or bln996XT Then
                strAGV = Split(RadioSetting(87), ",")
                If UBound(strAGV) = 5 Then
                    Response = SendCMD("AGV,,," & strAGV(0) & C & strAGV(1) & C & strAGV(2) & C & strAGV(3) & C & strAGV(4))
                    'command n/a on 346
                End If
            End If
            If blnBC15 Or bln15XT Then 'set default beartracker state
                x = Val(RadioSetting(109))
                If x > 0 And x <= 67 Then
                    Response = SendCMD("STT," & varState(x, 0))
                    If Response <> "OK" Then
                        sngErr += 1
                        GenLog("Cannot set BT State")
                    End If
                End If
            End If
            If Response <> "OK" Then
                sngErr += 1
                GenLog("Error setting AGC")
            End If
            If blnXT = False Then
                CommonAGC()
                Response = SendCMD("KBP," & RadioSetting(4)) 'key beep
            ElseIf bln346 Or Bln396XT Then 'send  KBP for XTs 
                Response = SendCMD("KBP," & RadioSetting(4) & C & MakeBinary(RadioSetting(104)) & C & MakeBinary(RadioSetting(105)))
                'battery settings
                If Val(RadioSetting(107)) < 1 Then
                    RadioSetting(107) = "5"
                End If
                If strMDL <> "BC346XTC" Then
                    Response = SendCMD("BSV," & MakeBinary(RadioSetting(86)) & C & RadioSetting(107)) 'battery save
                End If
            ElseIf blnXT Then
                Response = SendCMD("KBP," & RadioSetting(4) & C & C & MakeBinary(RadioSetting(105)))
            End If
            If Response <> "OK" Then
                sngErr += "1"
                GenLog("Error setting keybeep or BSV")
            End If

            Response = SendCMD("OMS," & RadioSetting(5) & "," & RadioSetting(6) & C & RadioSetting(22) & C & RadioSetting(23)) 'opening message
            If Response <> "OK" Then
                sngErr += 1
                GenLog("Error setting opening text")
            End If
            'Search/Close Call Settings
            intDelay = Val(MakeDelay(RadioSetting(21), blnXT))
            CODE_SRCH = RadioSetting(24)
            If CODE_SRCH = "2" And blnXT = False Or CODE_SRCH = "2" And blnAnalog Then
                CODE_SRCH = "1" 'P25 NAC not supported on all scanners
            End If
            If Bln996 = True Then
                strCMD(0) = "SCO," & StepSize(Val(RadioSetting(17)), 1) & C & RadioSetting(18) & C & RadioSetting(33) & C
                strCMD(1) = intDelay & "," & RadioSetting(40) & C & CODE_SRCH & C & RadioSetting(43) & C
                strCMD(2) = RadioSetting(41) & C & "AUTO,8" & C & RadioSetting(32)
                strCMD(3) = C & RadioSetting(42)
            ElseIf blnBC15 = True Then
                strCMD(0) = "SCO," & StepSize(Val(RadioSetting(17)), 1) & C & RadioSetting(18) & C & RadioSetting(33) & C
                strCMD(1) = intDelay & "," & RadioSetting(40) & C & CODE_SRCH & C & RadioSetting(43) & C
                strCMD(2) = RadioSetting(41) & C & C & C & RadioSetting(32)
                strCMD(3) = C & RadioSetting(42)
            ElseIf Bln396XT = True Then
                strCMD(0) = "SCO," & C & RadioSetting(18) & C & RadioSetting(33) & C
                strCMD(1) = intDelay & ",," & CODE_SRCH & C & RadioSetting(43) & C
                strCMD(2) = RadioSetting(41) & ",,," & RadioSetting(32) & C & C & RadioSetting(101) & C
                strCMD(3) = RadioSetting(102) & C & RadioSetting(103)
            ElseIf bln346 = True Then
                strCMD(0) = "SCO," & C & RadioSetting(18) & C & RadioSetting(33) & C
                strCMD(1) = intDelay & ",," & CODE_SRCH & C & RadioSetting(43) & C
                strCMD(2) = RadioSetting(41) & ",,," & RadioSetting(32) & C & C & C
                strCMD(3) = C
            ElseIf bln996XT Then
                strCMD(0) = "SCO," & C & RadioSetting(18) & C & RadioSetting(33) & C
                strCMD(1) = intDelay & ",," & CODE_SRCH & C & RadioSetting(43) & C
                strCMD(2) = RadioSetting(41) & ",,," & RadioSetting(32) & C & RadioSetting(42) & C & RadioSetting(101) & C
                strCMD(3) = RadioSetting(102) & C & RadioSetting(103)
            ElseIf bln15XT Then 'UPDATE WHEN I HAVE THE 15XT PROTOCOL
                strCMD(0) = "SCO," & C & RadioSetting(18) & C & RadioSetting(33) & C
                strCMD(1) = intDelay & ",," & CODE_SRCH & C & RadioSetting(43) & C
                strCMD(2) = RadioSetting(41) & ",,," & RadioSetting(32) & C & RadioSetting(42) & C & RadioSetting(101) & C
                strCMD(3) = RadioSetting(102) & C & RadioSetting(103)
            End If

            Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3)) 'close call settings
            'even more close call settings

            strCMD(0) = "CLC," & RadioSetting(7) & C & RadioSetting(8) & C & C & RadioSetting(13) & C & RadioSetting(15) & C
            strCMD(1) = RadioSetting(11) & C & RadioSetting(14) & C & RadioSetting(10) & C & RadioSetting(21) & C & RadioSetting(9)
            If RadioSetting(98) = "" Then
                RadioSetting(98) = "NONE"
                RadioSetting(99) = "OFF"
                RadioSetting(100) = "0"
            End If
            ALT_COLOR = RadioSetting(99)
            If bln325P2 And ALT_COLOR <> "OFF" Then
                ALT_COLOR = "RED"
            End If
            ALT_PATTERN = RadioSetting(100)
            ALT_PATTERN = ChgAlertCode(ALT_PATTERN, ALT_COLOR, strMDL)
            If Bln396XT Or bln996XT Then
                strCMD(1) &= C & RadioSetting(98) & C & ALT_COLOR & C & ALT_PATTERN
            ElseIf bln346 Or bln15XT Then
                strCMD(1) &= C & RadioSetting(98) & C & C & ALT_PATTERN
            End If
            Response = SendCMD(strCMD(0) & strCMD(1))
            If Response <> "OK" Then
                sngErr += 1
                GenLog("Error setting Close Call")
            End If
            'global IF Exchange

            If blnXT Then
                ' Response = SendCMD("CIE")
                If Response = "ERR" Then
                    sngErr += 1
                    GenLog("Error clearing Global IF")
                End If
                intChan = 0
                If IsArray(strIFEX) Then
                    For intChan = 0 To UBound(strIFEX)
                        If Val(strIFEX(intChan)) > 0 Then
                            Response = SendCMD("RIE," & Val(strIFEX(intChan)) * 10000)
                            If Response <> "OK" Then
                                sngErr += 1
                                GenLog("RIE ERROR " & Response & " " & strIFEX(intChan))
                            End If
                        End If
                    Next
                End If
            End If
            'search key assignments
            strCMD(0) = "SHK,"
            If Bln996 = True Then
                For x = 1 To 6
                    strCMD(0) = strCMD(0) & RadioSetting(33 + x)

                    If x <> 6 Then strCMD(0) = strCMD(0) & C
                Next x
            Else
                strCMD(1) = RadioSetting(34)
                strCMD(2) = RadioSetting(35)
                strCMD(3) = RadioSetting(36)
                For x = 1 To 3
                    If blnXT And strCMD(x) = "FRS/GMRS" Then
                        strCMD(x) = "FRS/GMRS/MURS"
                    End If
                Next x
                strCMD(0) &= strCMD(1) & C & strCMD(2) & C & strCMD(3) & ",,,"
            End If

            Response = SendCMD(strCMD(0))
            lstSystems.Enabled = True
            'broadcast screen settings
            x = 0
            'i dont freakin understand how this works
            For cnt = 0 To 19 Step 2
                x = x + 1
                If x = 10 Then x = 0
                strCMD(0) = "BBS," & x & C & (Val(RadioSetting(51 + cnt)) * 10000) & C & (Val(RadioSetting(52 + cnt)) * 10000)
                Response = SendCMD(strCMD(0))
            Next cnt
            'service search settings
            For x = 1 To 13
                cnt = x
                AGC_ANALOG = strSSXT(x, 1)
                AGC_DIGITAL = strSSXT(x, 2)
                P25WAITING = strSSXT(x, 3)
                If cnt = 13 Then cnt = 15 'adjust for weird uniden gap
                strCMD(0) = Nothing

                If blnXT = False Then

                    strCMD(0) = "SSP," & cnt & C & MakeDelay(strSS(x, 2), blnXT) & C & strSS(x, 3) & C & strSS(x, 4) & C & strSS(x, 8) & C
                    strCMD(1) = strSS(x, 5) & C & strSS(x, 6) & C & strSS(x, 7)
                ElseIf Bln396XT = True Then
                    strCMD(0) = "SSP," & cnt & C & MakeDelay(strSS(x, 2), blnXT) & C & strSS(x, 3) & C & strSS(x, 4) & C & strSS(x, 8) & C
                    strCMD(1) = strSS(x, 5) & C & strSS(x, 6) & C & C & MakeItKosherNumTag(strSSXT(x, 4)) & C & AGC_ANALOG & C & AGC_DIGITAL & C & P25WAITING
                ElseIf bln346 = True And cnt <> 15 And cnt <> 10 Then
                    strCMD(0) = "SSP," & cnt & C & MakeDelay(strSS(x, 2), blnXT) & C & strSS(x, 3) & C & strSS(x, 4) & C & strSS(x, 8) & C
                    strCMD(1) = strSS(x, 5) & C & strSS(x, 6) & C & C & MakeItKosherNumTag(strSSXT(x, 4)) & ",,,"
                ElseIf bln996XT Then
                    strCMD(0) = "SSP," & cnt & C & MakeDelay(strSS(x, 2), blnXT) & C & strSS(x, 3) & C & strSS(x, 4) & C & strSS(x, 8) & C
                    strCMD(1) = strSS(x, 5) & C & strSS(x, 6) & C & strSS(x, 7) & C & MakeItKosherNumTag(strSSXT(x, 4)) & C & AGC_ANALOG & C & AGC_DIGITAL & C & P25WAITING
                ElseIf bln15XT Then
                    strCMD(0) = "SSP," & cnt & C & MakeDelay(strSS(x, 2), blnXT) & C & strSS(x, 3) & C & strSS(x, 4) & C & strSS(x, 8) & C
                    strCMD(1) = strSS(x, 5) & C & strSS(x, 6) & C & strSS(x, 7) & C & MakeItKosherNumTag(strSSXT(x, 4)) & ",,,"

                End If
                If strCMD(0) <> Nothing Then
                    Response = SendCMD(strCMD(0) & strCMD(1))
                End If
            Next x

            uploadGDO() 'gps settings


            'custom search ranges
            For x = 1 To 10
                strCMD(5) = strCMD(5) & FlipIt(CustSearch(x, 8))
            Next x

            Response = SendCMD("CSG," & strCMD(5))
            For x = 1 To 10
                intChan = x
                If intChan = 10 Then intChan = 0
                strCMD(0) = "CSP," & intChan & C & CustSearch(x, 0) & C & (Val(CStr(CDbl(CustSearch(x, 1)) * 10000))) & C & (Val(CStr(CDbl(CustSearch(x, 2)) * 10000))) & C
                strCMD(1) = StepSize(Val(CustSearch(x, 3)), 1) & C & CustSearch(x, 4) & C & CustSearch(x, 5) & C
                strCMD(2) = MakeDelay(CustSearch(x, 6), blnXT) & C & CustSearch(x, 7) & C & CustSearch(x, 9) & C & CustSearch(x, 15) & C
                If Bln996 = True Then
                    strCMD(3) = CustSearch(x, 10) & C & APCOMode & C & APCOThreshold & C
                ElseIf blnBC15 = True Then
                    strCMD(3) = CustSearch(x, 10) & C & C & C
                End If
                strCMD(4) = CustSearch(x, 12) & C & CustSearch(x, 13) & C & CustSearch(x, 14)
                If CustSearch(x, 11) = "" Then CustSearch(x, 11) = "NONE"
                If Bln396XT = True Then
                    strBuff = OldMid(CustSearch(x, 16), 2, 1)
                    strCMD(3) = CustSearch(x, 10) & ",,," & CustSearch(x, 12) & C & CustSearch(x, 13) & C & C
                    strCMD(4) = CustSearch(x, 11) & C & OldMid(CustSearch(x, 16), 1, 1) & C & strBuff & C
                    strCMD(4) &= Mid(CustSearch(x, 16), 3)
                ElseIf bln346 = True Then
                    strCMD(3) = CustSearch(x, 10) & ",,," & CustSearch(x, 12) & C & CustSearch(x, 13) & C & C
                    strCMD(4) = CustSearch(x, 11) & C & C & C
                ElseIf bln996XT Then
                    strBuff = OldMid(CustSearch(x, 16), 2, 1)
                    strCMD(3) = CustSearch(x, 10) & ",,," & CustSearch(x, 12) & C & CustSearch(x, 13) & C & CustSearch(x, 14) & C
                    strCMD(4) = CustSearch(x, 11) & C & OldMid(CustSearch(x, 16), 1, 1) & C & strBuff & C
                    strCMD(4) &= Mid(CustSearch(x, 16), 3)
                ElseIf bln15XT Then
                    strCMD(3) = CustSearch(x, 10) & ",,," & CustSearch(x, 12) & C & CustSearch(x, 13) & C & CustSearch(x, 14) & C
                    strCMD(4) = CustSearch(x, 11) & C & C & C
                End If
                Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3) & strCMD(4))
            Next x
            'cUSTOM BAND PLAN
            If blnXT Then
                UploadCBP()
            End If
        End If 'send custom settings



        If chkGlobalLO.CheckState = 1 Then
            'locked out frequency ranges
            strCurOp = "Sending Global Frequency Lockouts..."
            For x = 1 To MaxSearchLockout
                If strSearchLockout(x) <> "" And strSearchLockout(x) <> 0 Then
                    Response = SendCMD("LOF," & (CStr(Val(strSearchLockout(x)) * 10000)))
                    Call CheckMem("C")
                End If
            Next x
        End If
        'find out which sites we are doing
        For intList = 0 To lstSystems.Items.Count - 1
            lstSystems.SelectedIndex = intList
            If lstSystems.GetItemChecked(intList) = True Then

                intSystem = Val(intSystems(intList))
                blnSysOK = True
            End If
            'Approve this system for this scanner
            If varSite(intSystem, 0, 0, 3) = "8" And Bln396XT = False And bln996XT = False Then
                blnSysOK = False
                Call GenLog("System " & varSite(intSystem, 0, 0, 1) & " is a P25 Single Frequency Trunk system and is only supported by the BCD396XT and the BCD996XT. As a result, it will not get uploaded.")
                sngErr = sngErr + 1
            ElseIf varSite(intSystem, 0, 0, 3) = "7" And blnAnalog Then
                blnSysOK = False
                Call GenLog("System " & varSite(intSystem, 0, 0, 1) & " is a P25 system and is only supported by the digital scanners. As a result, it will not get uploaded.")
                sngErr = sngErr + 1
            ElseIf varSite(intSystem, 0, 0, 3) = "9" And Not DMRCapable Then 'Dont upload a DMR or MOTOTRBO system to an incapable scanner
                blnSysOK = False
                Call GenLog("System " & varSite(intSystem, 0, 0, 1) & " is a MotoTRBO system and not supported on this scanner. It will not be uploaded")
                sngErr = sngErr + 1
            ElseIf varSite(intSystem, 0, 0, 3) = "10" And Not DMRCapable Then 'Dont upload a DMR or MOTOTRBO system to an incapable scanner
                blnSysOK = False
                Call GenLog("System " & varSite(intSystem, 0, 0, 1) & " is a DMR system and not supported on this scanner. It will not be uploaded")
                sngErr = sngErr + 1
            End If

            strSysType = SysType(CInt(varSite(intSystem, 0, 0, 3)), 1)
            'are there any P25 sites and this is analog? THen abort
            If strSysType = "MOT2" Then
                For intSite = 1 To MaxGroups
                    If varSite(intSystem, intSite, 0, 9) = "6" And blnAnalog Then
                        blnSysOK = False
                        Call GenLog("System " & varSite(intSystem, 0, 0, 1) & " is a P25 system and is only supported by the digital scanners. As a result, it will not get uploaded.")
                        sngErr = sngErr + 1
                    End If
                Next
            End If


            If varSite(intSystem, 0, 0, 3) = "1" Then
                'create system, store

                System.Array.Clear(strCMD, 0, strCMD.Length)
                If blnXT = True Then
                    strCMD(0) = "," & MakeBinary(varSite(intSystem, 0, 0, 32)) ' system protect on/off
                End If
                intIndex = Val(SendCMD("CSY,CNV" & strCMD(0)))
                If intIndex = -1 Then
                    sngErr += 1
                    blnSysOK = False
                    Call GenLog("Unable to generate system " & varSite(intSystem, 0, 0, 1))
                    'Exit if?
                    'Exit if?
                End If
                Call CheckMem("")
                'Begin applying site setting
                'begin translating
                strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1))
                intSitesFound = intSitesFound + 1
                strName = varSite(intSystem, 0, 0, 1)
                strQK = varSite(intSystem, 0, 0, 4)
                intHoldTime = Val(varSite(intSystem, 0, 0, 5))
                intLockout = Val(varSite(intSystem, 0, 0, 2))
                intDelay = Val(MakeDelay(varSite(intSystem, 0, 0, 6), blnXT))
                intDataSkip = Val(varSite(intSystem, 0, 0, 9))
                System.Array.Clear(strCMD, 0, strCMD.Length)
                strRange = MakeGPS((varSite(intSystem, 0, 0, 21)), blnXT)
                varSite(intSystem, 0, 0, 34) = "0" 'Clear change flag after upload
                strCMD(0) = "SIN," & intIndex & "," & strName & "," & strQK & C & intHoldTime & C & intLockout & C & MakeDelay(CStr(intDelay), blnXT) & C
                STATE = varState(Val(varSite(intSystem, 0, 0, 33)), 0)

                'CONVENTIONAL SYSTEM ONLY!!!!!!!!!!!!
                If Bln996 = True Then
                    strCMD(1) = intDataSkip & C & C & C & varSite(intSystem, 0, 0, 48) & C & varSite(intSystem, 0, 0, 49) & C
                    strCMD(2) = varSite(intSystem, 0, 0, 7) & C & varSite(intSystem, 0, 0, 24) & C & varSite(intSystem, 0, 0, 19) & C
                    strCMD(3) = varSite(intSystem, 0, 0, 20) & C & strRange & C & varSite(intSystem, 0, 0, 22) & C
                ElseIf blnBC15 = True Then
                    strCMD(1) = intDataSkip & C & C & C & C & C
                    strCMD(2) = varSite(intSystem, 0, 0, 7) & C & varSite(intSystem, 0, 0, 24) & C & varSite(intSystem, 0, 0, 19) & C
                    strCMD(3) = varSite(intSystem, 0, 0, 20) & C & strRange & C & varSite(intSystem, 0, 0, 22) & C & STATE
                ElseIf Bln396XT = True Then
                    strCMD(1) = C & C & C & C & C
                    strCMD(2) = varSite(intSystem, 0, 0, 7) & ",,,,,,," & varSite(intSystem, 0, 0, 28) & C & Val(varSite(intSystem, 0, 0, 29)) & C
                    strCMD(3) = Val(varSite(intSystem, 0, 0, 30)) & C & Val(varSite(intSystem, 0, 0, 31))
                ElseIf bln346 = True Then
                    strCMD(1) = C & C & C & C & C
                    strCMD(2) = varSite(intSystem, 0, 0, 7) & ",,,,,,," & varSite(intSystem, 0, 0, 28) & ",,,"
                ElseIf bln996XT Then
                    strCMD(1) = C & C & C & C & C
                    strCMD(2) = varSite(intSystem, 0, 0, 7) & C & varSite(intSystem, 0, 0, 24) & ",,,,,," & varSite(intSystem, 0, 0, 28) & C & Val(varSite(intSystem, 0, 0, 29)) & C
                    strCMD(3) = Val(varSite(intSystem, 0, 0, 30)) & C & Val(varSite(intSystem, 0, 0, 31))
                ElseIf bln15XT Then
                    strCMD(1) = C & C & C & C & C
                    strCMD(2) = varSite(intSystem, 0, 0, 7) & C & varSite(intSystem, 0, 0, 24) & ",,,,," & STATE & C & varSite(intSystem, 0, 0, 28) & ",,,"
                End If

                Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3))
                If Response = "ERR" Or Response = "-1" Then
                    sngErr = sngErr + 1
                    Call GenLog("Error creating system " & varSite(intSystem, 0, 0, 1))
                End If
                'START GROUP LOOP
                If Val(varSite(intSystem, 0, 0, 10)) > 0 Then 'are there any groups in this site?
                    For intGroup = 1 To MaxGroups
                        If varSite(intSystem, intGroup, 0, 2) <> "" Then 'is this a valid group?
                            'begin programming group
                            intGroupIndex = Val(SendCMD("AGC," & intIndex))
                            strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intGroup, 0, 1))
                            intGroupsFound += 1
                            strRange = MakeGPS((varSite(intSystem, intGroup, 0, 8)), blnXT)
                            strCMD(0) = "GIN," & intGroupIndex & "," & varSite(intSystem, intGroup, 0, 1) & "," & varSite(intSystem, intGroup, 0, 2) & "," & varSite(intSystem, intGroup, 0, 3)
                            If blnXT = True Then
                                strRange = MakeGPS(varSite(intSystem, intGroup, 0, 8), blnXT)
                                strCMD(1) = C & varSite(intSystem, intGroup, 0, 6) & C & varSite(intSystem, intGroup, 0, 7) & C & strRange
                                strCMD(1) &= C & Val(varSite(intSystem, intGroup, 0, 9))
                            Else
                                strCMD(1) = ""
                            End If

                            Response = SendCMD(strCMD(0) & strCMD(1))
                            If Response = "-1" Then
                                MsgBox("Insufficient scanner resources to continue. Aborting.")
                                ResponseCode = SendCMD("EPG")
                                msc.Close()
                                sngErr = sngErr + 1
                                Exit Sub
                            End If

                            'BEGIN CHANNEL LOOP
                            For intChan = 1 To MaxChan
                                If ChanInfo(intChan, 10) = varSite(intSystem, intGroup, 0, 10) Then
                                    'valid channel
                                    If blnAnalog = True And ChanInfo(intChan, 12) = "2" And chkAnalog.Checked Then 'skip digital channels
                                        'do nothing
                                        intChnSkip = intChnSkip + 1
                                        strCurOp = Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intGroup, 0, 1)) & "\"
                                        strCurOp = strCurOp & ChanInfo(intChan, 1) & " " & Val(ChanInfo(intChan, 2)).ToString("###0.0000") & "MHz is digital, skipped."
                                        GenLog(strCurOp)
                                    Else
                                        strChanName = ChanInfo(intChan, 1)
                                        dblFreq = (Val(ChanInfo(intChan, 2)) * 10000)
                                        strModMode = ModMode(Val(ChanInfo(intChan, 4)))
                                        intCTCSS = Val(ChanInfo(intChan, 9))
                                        intToneLock = Val(ChanInfo(intChan, 11))
                                        intLockout = Val(ChanInfo(intChan, 5))
                                        intPri = Val(ChanInfo(intChan, 7))
                                        intAtt = Val(ChanInfo(intChan, 6))
                                        intAlert = Val(ChanInfo(intChan, 8))
                                        intRecord = Val(ChanInfo(intChan, 3))
                                        ALT_PATTERN = ChanInfo(intChan, 18)
                                        ALT_COLOR = ChanInfo(intChan, 17)
                                        ALT_PATTERN = ChgAlertCode(ALT_PATTERN, ALT_COLOR, strMDL)
                                        If dblFreq > 0 Then
                                            lngChannelIndex = Val(SendCMD("ACC," & intGroupIndex))
                                        Else
                                            intChannelsFound = intChannelsFound - 1
                                            intChnSkip = intChnSkip + 1
                                            strCurOp = Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intGroup, 0, 1)) & "\"
                                            strCurOp &= ChanInfo(intChan, 1) & " is 0Mhz, skipped."
                                            Call GenLog(strCurOp)
                                        End If
                                        If lngChannelIndex = 0 Or lngChannelIndex = -1 Then
                                            sngErr = sngErr + 1
                                            If dblFreq > 0 Then
                                                MsgBox("Critical error, invalid response code or insufficient resources, aborting channel programming")

                                                intChan = MaxChan
                                                intGroup = MaxGroups
                                                intList = lstSystems.Items.Count - 1
                                            End If
                                        End If
                                        strNAC = MakeItKosherNAC(ChanInfo(intChan, 15))

                                        intChannelsFound += 1
                                        strCMD(0) = "CIN," & lngChannelIndex & "," & strChanName & C & dblFreq & C & strModMode
                                        strCMD(1) = "," & intCTCSS & "," & intToneLock & "," & intLockout & "," & intPri & "," & intAtt
                                        strCMD(3) = Nothing

                                        If Bln996 Then
                                            strCMD(2) = "," & intAlert & C & ChanInfo(intChan, 13) & C & intRecord & C & ChanInfo(intChan, 12)
                                        ElseIf blnBC15 Then
                                            strCMD(2) = "," & intAlert & C & ChanInfo(intChan, 13) & C & intRecord & C
                                        ElseIf bln346 Then

                                            strCMD(2) = C & intAlert & C & ChanInfo(intChan, 13) & ",,,,"
                                            strCMD(3) = ChanInfo(intChan, 16) & ",," & ALT_PATTERN & C & ChanInfo(intChan, 20)
                                        ElseIf bln325P2 Then
                                            strCMD(2) = C & intAlert & C & ChanInfo(intChan, 13) & ",," & ChanInfo(intChan, 12) & C & strNAC & C
                                            strCMD(3) = ChanInfo(intChan, 16) & C & C & ALT_PATTERN & C & ChanInfo(intChan, 20)
                                        ElseIf Bln396XT Then
                                            strCMD(2) = C & intAlert & C & ChanInfo(intChan, 13) & ",," & ChanInfo(intChan, 12) & C & strNAC & C
                                            strCMD(3) = ChanInfo(intChan, 16) & C & ALT_COLOR & C & ALT_PATTERN & C & ChanInfo(intChan, 20)
                                        ElseIf bln996XT Then
                                            strCMD(2) = C & intAlert & C & ChanInfo(intChan, 13) & C & intRecord & C & ChanInfo(intChan, 12) & C & strNAC & C
                                            strCMD(3) = ChanInfo(intChan, 16) & C & ALT_COLOR & C & ALT_PATTERN & C & ChanInfo(intChan, 20)
                                        ElseIf bln15XT Then
                                            strCMD(2) = C & intAlert & C & ChanInfo(intChan, 13) & C & intRecord & ",,,"
                                            strCMD(3) = ChanInfo(intChan, 16) & ",," & ALT_PATTERN & C & ChanInfo(intChan, 20)
                                        End If
                                        If dblFreq > 0 Then
                                            ResponseCode = SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3))
                                            If ResponseCode = "ERR" Then
                                                sngErr += 1
                                                Call GenLog("Error creating channel " & strChanName & C & ChanInfo(intChan, 2))
                                            End If
                                            Call CheckMem("C")

                                        Else
                                            'ADD COMMAND FOR SKIPIG CHANNELS
                                            '+= 1

                                        End If
                                    End If 'is this a digital channel?
                                End If 'channel loop
                            Next intChan
                        End If 'is this a valid group
                    Next intGroup
                    Call QGLUL396(intIndex, intSystem)
                End If 'are there any groups in this site?

            ElseIf Val(varSite(intSystem, 0, 0, 3)) > 0 And blnSysOK Then
                'this will be a trunking system
                'first create the system

                strSysType = SysType(CInt(varSite(intSystem, 0, 0, 3)), 1)
                If blnXT = True And strSysType = "MOT1" Then 'convert to XT compatibility
                    strSysType = "MOT"
                ElseIf blnXT = True And strSysType = "MOT2" Then
                    strSysType = "MOT"
                End If
                If blnXT = False And strSysType = "P25S" Then
                    strSysType = "MOT2"
                End If
                If blnXT = True Then
                    strCMD(0) = "," & MakeBinary(varSite(intSystem, 0, 0, 32))  'turn off system protect
                Else
                    strCMD(0) = ""
                End If

                strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1))

                'are there any P25 sites and this is an XT? Then change to P25
                If strSysType = "MOT" And blnXT Then
                    For intSite = 1 To MaxGroups
                        If varSite(intSystem, intSite, 0, 9) = "6" Then
                            strSysType = "P25S"
                        End If
                    Next
                End If
                intIndex = Val(SendCMD("CSY," & strSysType & strCMD(0)))
                Call CheckMem("")
                'Begin applying site setting
                'begin translatin
                strName = varSite(intSystem, 0, 0, 1)
                intDelay = Val(MakeDelay(varSite(intSystem, 0, 0, 6), blnXT))
                System.Array.Clear(strCMD, 0, strCMD.Length)
                'TRUNKED SYSTEM***********************************
                If varSite(intSystem, 0, 0, 28) = "" Then varSite(intSystem, 0, 0, 28) = "NONE"
                varSite(intSystem, 0, 0, 34) = "0" ' clear system has changed flag
                intRecord = varSite(intSystem, 0, 0, 24)
                If blnXT = False Then
                    strCMD(0) = "SIN," & intIndex & "," & strName & C & C & C & C & intDelay & C & C & C & C
                    strCMD(1) = C & C & C & intRecord & C & C & C & C & C
                ElseIf Bln396XT = True Then
                    strCMD(0) = "SIN," & intIndex & "," & strName & ",,,," & intDelay
                    strCMD(1) = ",,,,,,,,,,,,,"
                    strCMD(2) = varSite(intSystem, 0, 0, 28) & C & Val(varSite(intSystem, 0, 0, 29)) & C & Val(varSite(intSystem, 0, 0, 30))
                    strCMD(3) = C
                ElseIf bln346 = True Then
                    strCMD(0) = "SIN," & intIndex & "," & strName & ",,,," & intDelay
                    strCMD(1) = ",,,,,,,,,,,,,"
                    strCMD(2) = varSite(intSystem, 0, 0, 28) & ",,,"
                ElseIf bln996XT = True Then
                    strCMD(0) = "SIN," & intIndex & "," & strName & ",,,," & intDelay
                    strCMD(1) = ",,,,,,," & intRecord & ",,,,,,"
                    strCMD(2) = varSite(intSystem, 0, 0, 28) & C & Val(varSite(intSystem, 0, 0, 29)) & C & Val(varSite(intSystem, 0, 0, 30))
                    strCMD(3) = C
                ElseIf bln15XT = True Then
                    strCMD(0) = "SIN," & intIndex & "," & strName & ",,,," & intDelay
                    strCMD(1) = ",,,,,,," & intRecord & ",,,,,,"
                    strCMD(2) = varSite(intSystem, 0, 0, 28) & ",,,"
                End If
                Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3))
                'send TGID Lockout list
                UploadLOI(varSite(intSystem, 0, 0, 23), CStr(intIndex))
                'begin trunk settings
                ID_Search = MakeBinary(varSite(intSystem, 0, 0, 11))
                AFS = MakeBinary(varSite(intSystem, 0, 0, 14))
                S_Bit = Val(varSite(intSystem, 0, 0, 12))
                End_Code = Val(varSite(intSystem, 0, 0, 13))
                I_CALL = Val(varSite(intSystem, 0, 0, 15))
                FMAP = CStr(Val(varSite(intSystem, 0, 0, 16)))
                strCustFleetMap = MakeFleetMap(varSite(intSystem, 0, 0, 17))
                EMGL = Val(varSite(intSystem, 0, 0, 26))
                EMG = Val(varSite(intSystem, 0, 0, 25))
                intDigCode = Val(varSite(intSystem, 0, 0, 27))

                System.Array.Clear(strCMD, 0, strCMD.Length)
                If varSite(intSystem, 0, 0, 3) <> "2" Then

                    strCustFleetMap = ""
                    FMAP = ""
                End If
                If blnXT = False Then
                    strCMD(0) = "TRN," & intIndex & "," & ID_Search & "," & S_Bit & "," & End_Code & "," & AFS & C
                    strCMD(1) = I_CALL & C & C & EMG & C & EMGL & C & FMAP & C & strCustFleetMap & ",,,,,,,,,," & intDigCode
                ElseIf Bln396XT Or bln996XT Or bln325P2 Then
                    If varSite(intSystem, 0, 0, 27) = "1" Then
                        End_Code = 2
                    End If

                    ALT_COLOR = varSite(intSystem, 0, 0, 51)
                    If bln325P2 And ALT_COLOR <> "OFF" Then
                        ALT_COLOR = "RED"
                    End If
                    strCMD(0) = "TRN," & intIndex & C & ID_Search & C & S_Bit & C & End_Code & C & AFS & ",,,"
                    strCMD(1) = EMG & C & EMGL & C & FMAP & C & strCustFleetMap & ",,,,,,,,,,," & Val(varSite(intSystem, 0, 0, 50))
                    strCMD(2) = C & ALT_COLOR & C & Val(varSite(intSystem, 0, 0, 52)) & C & varSite(intSystem, 0, 0, 53) & C
                    strCMD(3) = MakeBinary(varSite(intSystem, 0, 0, 54)) 'SHOULD THERE BE AN EXTRA , HERE ????
                ElseIf bln346 Or bln15XT Then
                    strCMD(0) = "TRN," & intIndex & C & ID_Search & C & S_Bit & C & End_Code & C & AFS & ",,,"
                    strCMD(1) = EMG & C & EMGL & C & FMAP & C & strCustFleetMap & ",,,,,,,,,,," & Val(varSite(intSystem, 0, 0, 50))
                    strCMD(2) = ",," & Val(varSite(intSystem, 0, 0, 52)) & C & C
                    strCMD(3) = MakeBinary(varSite(intSystem, 0, 0, 54))
                End If


                Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3))
                If Response = "ERR" Then
                    sngErr += 1
                    Call GenLog("Error sending trunk paramters, system " & varSite(intSystem, 0, 0, 1))
                End If



                '*************************************************BEGIN SITE LOOP
                For intSite = 1 To MaxGroups

                    'is this an edacs scat system? if so than this is special
                    '*******EDACS/LTR DISASTER CODE STARTS HERE ***************************************************
                    If Val(varSite(intSystem, 0, 0, 3)) = 5 Or Val(varSite(intSystem, intSite, 0, 9)) = 12 And blnXT = False Then ' this is a scat /ltrsystem, treat it different
                        Response = SendCMD("SIN," & intIndex)
                        strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intSite, 0, 1)) & "\Trunk Frequencies"
                        intSiteIndex = Val(ParaParse(Response, 14)) ' all trunk frequencies will be appended to system index, not the site index
                        If intSiteIndex > 0 Then ' is this a valid site?
                            intSeqIndex = intSiteIndex
                            intTrunkChan = 0
                            For intChan = 1 To MaxTrunkFreq 'search through every trunk freq, if applicable then upload to scanner
                                If strTrunkFreq(intChan, 2) = varSite(intSystem, intSite, 0, 10) And strTrunkFreq(intChan, 2) <> "" Then 'is this a valid trunk frequency? Then upload!
                                    Response = SendCMD("ACC," & intSeqIndex)
                                    If Response <> "ERR" Then
                                        If IsNumeric(Response) Then lngChannelIndex = CInt(Response)
                                        intTrunkChan += 1
                                        intChannelsFound += 1
                                        If Val(strTrunkFreq(intChan, 1)) <> 0 Then 'preserve LCN
                                            intTrunkChan = Val(strTrunkFreq(intChan, 1))
                                        End If
                                        intRecord = MakeBinary(strTrunkFreq(intChan, 6))
                                        NumTag = strTrunkFreq(intChan, 4)
                                        Vol_Offset = CStr(Val(strTrunkFreq(intChan, 5)))
                                        If NumTag = "" Then NumTag = "NONE"
                                        If blnXT = False Then
                                            Response = SendCMD("TFQ," & lngChannelIndex & "," & (Val(strTrunkFreq(intChan, 0)) * 10000) & C & intTrunkChan & C & Val(strTrunkFreq(intChan, 3)) & C)
                                        ElseIf Bln396XT Or bln346 Then
                                            Response = SendCMD("TFQ," & lngChannelIndex & "," & (Val(strTrunkFreq(intChan, 0)) * 10000) & C & intTrunkChan & C & Val(strTrunkFreq(intChan, 3)) & ",," & NumTag & C & Vol_Offset & C)
                                        ElseIf bln15XT Or bln996XT Then
                                            Response = SendCMD("TFQ," & lngChannelIndex & "," & (Val(strTrunkFreq(intChan, 0)) * 10000) & C & intTrunkChan & C & Val(strTrunkFreq(intChan, 3)) & C & intRecord & C & NumTag & C & Vol_Offset & C)
                                        End If
                                        Call CheckMem("C")
                                    Else
                                        sngErr += 1
                                        Call GenLog("Error adding trunk frequency " & Val(strTrunkFreq(intChan, 0)))
                                    End If ' response=err
                                End If ' valid trunk frequency
                            Next intChan
                            'UPLOAD SITE PARAMETERS

                            strQK = varSite(intSystem, intSite, 0, 2)
                            intHoldTime = Val(varSite(intSystem, intSite, 0, 4))
                            intLO = Val(varSite(intSystem, intSite, 0, 3))
                            intAtt = Val(varSite(intSystem, intSite, 0, 7))
                            intConCh = Val(varSite(intSystem, intSite, 0, 8))
                            strStartKey = varSite(intSystem, intSite, 0, 12)
                            strLat = varSite(intSystem, intSite, 0, 13)
                            strLong = varSite(intSystem, intSite, 0, 14)
                            strRange = MakeGPS(varSite(intSystem, intSite, 0, 15), blnXT)
                            intGPSEnable = Val(varSite(intSystem, intSite, 0, 16))
                            strModMode = varSite(intSystem, intSite, 0, 6)
                            STATE = varState(Val(varSite(intSystem, intSite, 0, 32)), 0)

                            System.Array.Clear(strCMD, 0, strCMD.Length)
                            If Bln996 = True Then
                                strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C & strModMode
                                strCMD(1) = C & intAtt & C & intConCh & C & varSite(intSystem, intSite, 0, 26) & C & varSite(intSystem, intSite, 0, 27)
                                strCMD(2) = C & strStartKey & C
                                strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & C
                            ElseIf blnBC15 = True Then
                                strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C & strModMode
                                strCMD(1) = C & intAtt & C & intConCh & C & C
                                strCMD(2) = C & strStartKey & C
                                strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & C & STATE
                            ElseIf Bln396XT Or bln996XT Then
                                strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C
                                strCMD(1) = strModMode & C & intAtt & C & varSite(intSystem, intSite, 0, 8) & C & C
                                strCMD(2) = C & strStartKey & C
                                strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & ",,,,"
                                strCMD(4) = varSite(intSystem, intSite, 0, 61) & C
                            ElseIf bln346 Then
                                strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C
                                strCMD(1) = strModMode & C & intAtt & C & varSite(intSystem, intSite, 0, 8) & C & C
                                strCMD(2) = C & strStartKey & C
                                strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & ",,,,,"
                                strCMD(4) = Nothing
                            ElseIf bln15XT Then
                                strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C
                                strCMD(1) = strModMode & C & intAtt & C & varSite(intSystem, intSite, 0, 8) & C & C
                                strCMD(2) = C & strStartKey & C
                                strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & C & STATE & ",,,,"
                                strCMD(4) = Nothing
                            End If
                            SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3) & strCMD(4))
                            Call CheckMem("")

                        End If
                        intSite = MaxGroups 'do not continue further with a SCAT system
                        'EDACS SCAT /LTR BREAKS POINT END ******************************************************************
                    ElseIf Val(varSite(intSystem, intSite, 0, 5)) = 3 Then  'a trunk site is present, upload it
                        'create a site first
                        'if this is a mp25 motorola going to an XT, then change it for the user
                        'since they never read the instructions anyway
                        strSysType = SiteType(Val(varSite(intSystem, intSite, 0, 9)), 1)
                        If strSysType = "MP25" And blnXT Then
                            strSysType = "P25S"
                        ElseIf strSysType = "P25S" And Not blnXT Then
                            strSysType = "MP25"
                        End If
                        intSiteIndex = Val(SendCMD("AST," & intIndex & C & strSysType))
                        If intSiteIndex = -1 And varSite(intSystem, intSite, 0, 9) = "13" Then
                            'if a custom 800mhz system was attempted and failed then
                            strCMD(3) = "Cannot create a 800Mhz Custom/Rebanded site. This is likely due to your scanner not being loaded with latest firmware required to support this site. Other possible cause is scanner is out of memory. As a result, this site will be skipped."
                            cnt = MsgBox(strCMD(3), MsgBoxStyle.Critical, varSite(intSystem, intSite, 0, 1))
                        End If
                        If intSiteIndex > -1 Then
                            If Val(varSite(intSystem, intSite, 0, 9)) = 6 And blnAnalog Or varSite(intSystem, intSite, 0, 9) = "14" And blnAnalog Then 'Do not upload a P25 site to a 15
                                strLog = strLog & "SITE " & varSite(intSystem, intSite, 0, 1) & " is a P25-only site. It will not be uploaded." & vbNewLine
                            Else
                                intSitesFound += 1
                                strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intSite, 0, 1)) & ""
                                strName = varSite(intSystem, intSite, 0, 1)
                                strQK = varSite(intSystem, intSite, 0, 2)
                                intHoldTime = Val(varSite(intSystem, intSite, 0, 4))
                                intLO = Val(varSite(intSystem, intSite, 0, 3))
                                strModMode = varSite(intSystem, intSite, 0, 6)
                                intAtt = Val(varSite(intSystem, intSite, 0, 7))
                                intConCh = Val(varSite(intSystem, intSite, 0, 8))
                                strStartKey = varSite(intSystem, intSite, 0, 12)
                                strLat = varSite(intSystem, intSite, 0, 13)
                                strLong = varSite(intSystem, intSite, 0, 14)
                                strRange = MakeGPS(varSite(intSystem, intSite, 0, 15), blnXT)
                                intGPSEnable = Val(varSite(intSystem, intSite, 0, 16))
                                Select Case varSite(intSystem, intSite, 0, 9) 'set system paramters for XT series, base on site type
                                    Case "1" 'mot standard
                                        strSysType = "STD,,"
                                    Case "2" 'mot splint
                                        strSysType = "SPL,,"
                                    Case "3" 'mot 900mhz
                                        strSysType = "STD,,"
                                    Case "4" 'mot vhf
                                        strSysType = "CUSTOM,,"
                                    Case "5" 'mot uhf
                                        strSysType = "CUSTOM,,"
                                    Case "6" 'mot P25
                                        strSysType = "STD,,"
                                    Case "7" 'mot standar
                                        strSysType = "STD,,"
                                    Case "8" 'mot splint
                                        strSysType = "SPL,,"
                                    Case "9" 'edacs narrow
                                        strSysType = ",NARROW,"

                                    Case "10" 'edacs wide
                                        strSysType = ",,"
                                    Case "11" 'scat
                                        strSysType = ",,"
                                    Case "12" 'ltr
                                        strSysType = ",,"
                                    Case "13" 'reband
                                        strSysType = "CUSTOM,,"
                                    Case Else
                                        strSysType = ",,"
                                End Select
                                'SEND SITE INFO

                                System.Array.Clear(strCMD, 0, strCMD.Length)
                                STATE = varState(Val(varSite(intSystem, intSite, 0, 32)), 0)
                                If Bln996 = True Then
                                    strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C & strModMode
                                    strCMD(1) = C & intAtt & C & intConCh & C & varSite(intSystem, intSite, 0, 26) & C & varSite(intSystem, intSite, 0, 27)
                                    strCMD(2) = C & strStartKey & C
                                    strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & C
                                ElseIf blnBC15 = True Then
                                    strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C & strModMode
                                    strCMD(1) = C & intAtt & C & intConCh & C & C
                                    strCMD(2) = C & strStartKey & C
                                    strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & C & STATE
                                ElseIf Bln396XT Or bln996XT Then
                                    strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C
                                    strCMD(1) = strModMode & C & intAtt & C & varSite(intSystem, intSite, 0, 8) & C & C
                                    strCMD(2) = C & strStartKey & C
                                    strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & C & C
                                    strCMD(4) = strSysType & varSite(intSystem, intSite, 0, 61) & C
                                ElseIf bln346 Then
                                    strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C
                                    strCMD(1) = strModMode & C & intAtt & C & varSite(intSystem, intSite, 0, 8) & C & C
                                    strCMD(2) = C & strStartKey & C
                                    strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & C & C
                                    strCMD(4) = strSysType & C
                                ElseIf bln15XT Then
                                    strCMD(0) = "SIF," & intSiteIndex & C & strName & C & strQK & C & intHoldTime & C & intLO & C
                                    strCMD(1) = strModMode & C & intAtt & C & varSite(intSystem, intSite, 0, 8) & C & C
                                    strCMD(2) = C & strStartKey & C
                                    strCMD(3) = strLat & C & strLong & C & strRange & C & intGPSEnable & C & STATE & C
                                    strCMD(4) = strSysType & C
                                End If
                                SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3) & strCMD(4))
                                If Response = "ERR" Then
                                    sngErr = sngErr + 1
                                    GenLog(("Error sending site parameters, scanner may be out of resources. Site " & varSite(intSystem, intGroup, 0, 1)))
                                End If
                                'If this is a rebanded system, send band plan
                                If varSite(intSystem, intSite, 0, 9) = "13" And intSiteIndex >= 0 Then
                                    Call CommonSendReband(Val(CStr(intSystem)), intSite, Val(CStr(intSiteIndex))) 'MCP
                                ElseIf varSite(intSystem, intSite, 0, 9) = "13" And intSiteIndex < 0 Then
                                    sngErr = sngErr + 1
                                    GenLog(("Can't send Motorola Custom Bandplan - Update your scanner's firmware"))
                                End If
                                Call CheckMem("")
                                If varSite(intSystem, intSite, 0, 9) = "4" And blnXT = False Or varSite(intSystem, intSite, 0, 9) = "5" And blnXT = False Then
                                    'setup for MBP
                                    intBase(0) = GetBPParam(intSystem, intSite, 0, 0)
                                    intBase(1) = GetBPParam(intSystem, intSite, 0, 1)
                                    intBase(2) = GetBPParam(intSystem, intSite, 0, 2)
                                    intMStep(0) = GetBPParam(intSystem, intSite, 2, 0)
                                    intMStep(1) = GetBPParam(intSystem, intSite, 2, 1)
                                    intMStep(2) = GetBPParam(intSystem, intSite, 2, 2)
                                    intOffset(0) = GetBPParam(intSystem, intSite, 3, 0)
                                    intOffset(1) = GetBPParam(intSystem, intSite, 3, 1)
                                    intOffset(2) = GetBPParam(intSystem, intSite, 3, 2)
                                    'send motorola band plan
                                    strCMD(0) = "MBP," & intSiteIndex & C & intBase(0) & C & intMStep(0) & C & intOffset(0) & C
                                    strCMD(1) = intBase(1) & C & intMStep(1) & C & intOffset(1) & C
                                    strCMD(2) = intBase(2) & C & intMStep(2) & C & intOffset(2)
                                    SendCMD(strCMD(0) & strCMD(1) & strCMD(2))
                                ElseIf varSite(intSystem, intSite, 0, 9) = "4" And blnXT = True Or varSite(intSystem, intSite, 0, 9) = "5" And blnXT = True Then
                                    Call AutoCalcUpper(intSystem, intSite, True)
                                    Call CommonSendReband(intSystem, intSite, intSiteIndex)

                                End If

                                '*****************************************apco band plan
                                If varSite(intSystem, intSite, 0, 9) = "6" And Not blnAnalog Or varSite(intSystem, intSite, 0, 9) = "14" And blnAnalog = False Then 'this is a P25 system
                                    Call CommonABP(intSystem, intSite, intSiteIndex)
                                End If
                                'while the system index is available, upload frequencies
                                'grab the sequence index
                                intSeqIndex = intSiteIndex 'EQUALS THE INDEX NUMBER FOR THE SITE
                                If intSeqIndex > 0 Then ' is this a valid site?
                                    intTrunkChan = 0
                                    strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intSite, 0, 1)) & "\Trunk Frequencies"

                                    For intChan = 1 To MaxTrunkFreq 'search through every trunk freq, if applicable then upload to scanner
                                        If strTrunkFreq(intChan, 2) = varSite(intSystem, intSite, 0, 10) And strTrunkFreq(intChan, 2) <> "" Then 'is this a valid trunk frequency? Then upload!
                                            Response = SendCMD("ACC," & intSeqIndex)
                                            If Response <> "ERR" And Response <> "-1" Then
                                                If IsNumeric(Response) Then lngChannelIndex = CInt(Response)
                                                intTrunkChan = intTrunkChan + 1
                                                intChannelsFound = intChannelsFound + 1
                                                If Val(strTrunkFreq(intChan, 1)) <> 0 Then 'preserve LCN

                                                    intTrunkChan = Val(strTrunkFreq(intChan, 1))
                                                End If
                                                intRecord = MakeBinary(strTrunkFreq(intChan, 6))
                                                NumTag = strTrunkFreq(intChan, 4)
                                                Vol_Offset = CStr(Val(strTrunkFreq(intChan, 5)))
                                                If NumTag = "" Then NumTag = "NONE"
                                                If blnXT = False Then
                                                    Response = SendCMD("TFQ," & lngChannelIndex & "," & (Val(strTrunkFreq(intChan, 0)) * 10000) & C & intTrunkChan & C & Val(strTrunkFreq(intChan, 3)) & C)
                                                ElseIf Bln396XT Or bln346 Then
                                                    Response = SendCMD("TFQ," & lngChannelIndex & "," & (Val(strTrunkFreq(intChan, 0)) * 10000) & C & intTrunkChan & C & Val(strTrunkFreq(intChan, 3)) & ",," & NumTag & C & Vol_Offset & C)
                                                ElseIf bln15XT Or bln996XT Then
                                                    Response = SendCMD("TFQ," & lngChannelIndex & "," & (Val(strTrunkFreq(intChan, 0)) * 10000) & C & intTrunkChan & C & Val(strTrunkFreq(intChan, 3)) & C & intRecord & C & NumTag & C & Vol_Offset & C)
                                                End If
                                                Call CheckMem("C")
                                            Else
                                                sngErr += 1
                                                Call GenLog("Error adding trunk frequency " & Val(strTrunkFreq(intChan, 0)))
                                            End If
                                            If Response = "-1" Then
                                                GenLog("Scanner out of resources or other error - skipping remainder trunk frequencies")
                                                intChan = MaxTrunkFreq
                                            End If
                                        End If
                                    Next intChan
                                End If ' is the site valid?
                            End If 'is this a mp25 system?
                        Else
                            sngErr += 1
                            GenLog("Unable to add site - scanner may be out of resources")
                        End If 'end if valid site
                    End If 'is site index positive?
                Next intSite
                'That was fun, now add channel groups

                For intGroup = 1 To MaxGroups
                    If Val(varSite(intSystem, intGroup, 0, 5)) = 2 Then 'is this a valid group?
                        'begin programming group
                        intGroupIndex = Val(SendCMD("AGT," & intIndex))
                        strCurOp = "Sending system " & Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intGroup, 0, 1))
                        intGroupsFound = intGroupsFound + 1
                        System.Array.Clear(strCMD, 0, strCMD.Length)
                        strRange = MakeGPS(varSite(intSystem, intGroup, 0, 8), blnXT)
                        If blnXT = False Then
                            strCMD(0) = "GIN," & intGroupIndex & "," & varSite(intSystem, intGroup, 0, 1) & "," & varSite(intSystem, intGroup, 0, 2) & "," & varSite(intSystem, intGroup, 0, 3)
                        Else
                            strCMD(0) = "GIN," & intGroupIndex & "," & varSite(intSystem, intGroup, 0, 1) & "," & varSite(intSystem, intGroup, 0, 2) & "," & varSite(intSystem, intGroup, 0, 3)
                            strCMD(1) = C & varSite(intSystem, intGroup, 0, 6) & C & varSite(intSystem, intGroup, 0, 7) & C & strRange
                            strCMD(1) &= C & Val(varSite(intSystem, intGroup, 0, 9))
                        End If
                        Response = SendCMD(strCMD(0) & strCMD(1))
                        If Response <> "OK" Then
                            GenLog("Failed adding group " & varSite(intSystem, intGroup, 0, 1) & ". Please report this to the FreeSCAN yahoo group.")
                            sngErr += 1
                        End If
                        'BEGIN CHANNEL LOOP
                        For intChan = 1 To MaxChan
                            If ChanInfo(intChan, 10) = varSite(intSystem, intGroup, 0, 10) Then
                                'valid channel
                                If blnAnalog = True And ChanInfo(intChan, 6) = "2" And chkAnalog.Checked Then 'skip uploading a digital channel to analog scanner
                                    intChnSkip += 1
                                    strCurOp = Trim(varSite(intSystem, 0, 0, 1)) & "\" & Trim(varSite(intSystem, intGroup, 0, 1)) & "\"
                                    strCurOp &= ChanInfo(intChan, 1) & " " & ChanInfo(intChan, 2) & " is digital, skipped."
                                    GenLog(strCurOp)
                                Else
                                    intChannelsFound += 1
                                    strBuff = SendCMD("ACT," & intGroupIndex)
                                    lngChannelIndex = Val(strBuff) 'append channel
                                    If lngChannelIndex = 0 Then 'error
                                        lngChannelIndex = MsgBox("Critical error, possibly caused by insufficient scanner resources. Aborting", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                                        intGroup = MaxGroups
                                        intChan = MaxChan
                                        intList = lstSystems.Items.Count - 1
                                        sngErr += 1
                                    End If
                                    System.Array.Clear(strCMD, 0, strCMD.Length)
                                    If ChanInfo(intChan, 19) = "" Then ChanInfo(intChan, 19) = "NONE"
                                    If ChanInfo(intChan, 20) = "" Then ChanInfo(intChan, 20) = "OFF"
                                    strBuff = Trim(ChanInfo(intChan, 2))
                                    If ChanInfo(intChan, 1) <> "" Then
                                        strName = ChanInfo(intChan, 1)
                                    Else
                                        strName = "ID: " & strBuff
                                    End If
                                    intRecord = Val(ChanInfo(intChan, 7))
                                    Vol_Offset = ChanInfo(intChan, 22)
                                    Audio_Type = ChanInfo(intChan, 6)
                                    ALT_PATTERN = ChanInfo(intChan, 21)
                                    ALT_COLOR = ChanInfo(intChan, 20)
                                    ALT_PATTERN = ChgAlertCode(ALT_PATTERN, ALT_COLOR, strMDL)

                                    If bln325P2 And ALT_COLOR <> "OFF" Then
                                        ALT_COLOR = "RED"
                                    End If
                                    If Bln996 = True Then
                                        strCMD(0) = ("TIN," & lngChannelIndex & C & strName & C)
                                        strCMD(1) = strBuff & C & ChanInfo(intChan, 3) & C & C
                                        strCMD(2) = ChanInfo(intChan, 4) & C & ChanInfo(intChan, 5) & C & ChanInfo(intChan, 7) & C
                                        strCMD(3) = Audio_Type
                                    ElseIf blnBC15 = True Then
                                        strCMD(0) = ("TIN," & lngChannelIndex & C & strName & C)
                                        strCMD(1) = strBuff & C & ChanInfo(intChan, 3) & C & C
                                        strCMD(2) = ChanInfo(intChan, 4) & C & ChanInfo(intChan, 5) & C & ChanInfo(intChan, 7) & C
                                        strCMD(3) = ""
                                    ElseIf Bln396XT = True Or bln325P2 Then
                                        strCMD(0) = ("TIN," & lngChannelIndex & C & strName & C)
                                        strCMD(1) = strBuff & C & ChanInfo(intChan, 3) & C & ChanInfo(intChan, 8) & C
                                        strCMD(2) = ChanInfo(intChan, 4) & C & ChanInfo(intChan, 5) & C
                                        strCMD(3) = C & Audio_Type & C & ChanInfo(intChan, 19) & C & ALT_COLOR
                                        strCMD(4) = C & ALT_PATTERN & C & Vol_Offset
                                    ElseIf bln346 = True Then
                                        strCMD(0) = ("TIN," & lngChannelIndex & C & strName & C)
                                        strCMD(1) = strBuff & C & ChanInfo(intChan, 3) & C & Val(ChanInfo(intChan, 8)) & C
                                        strCMD(2) = ChanInfo(intChan, 4) & C & ChanInfo(intChan, 5) & ",,,"
                                        strCMD(3) = ChanInfo(intChan, 19) & C
                                        strCMD(4) = C & ALT_PATTERN & C & Vol_Offset
                                    ElseIf bln996XT = True Then
                                        strCMD(0) = ("TIN," & lngChannelIndex & C & strName & C)
                                        strCMD(1) = strBuff & C & ChanInfo(intChan, 3) & C & ChanInfo(intChan, 8) & C
                                        strCMD(2) = ChanInfo(intChan, 4) & C & ChanInfo(intChan, 5) & C & CStr(intRecord)
                                        strCMD(3) = C & Audio_Type & C & ChanInfo(intChan, 19) & C & ALT_COLOR
                                        strCMD(4) = C & ALT_PATTERN & C & Vol_Offset
                                    ElseIf bln15XT = True Then
                                        strCMD(0) = ("TIN," & lngChannelIndex & C & strName & C)
                                        strCMD(1) = strBuff & C & ChanInfo(intChan, 3) & C & Val(ChanInfo(intChan, 8)) & C
                                        strCMD(2) = ChanInfo(intChan, 4) & C & ChanInfo(intChan, 5) & ",," & CStr(intRecord) & C
                                        strCMD(3) = ChanInfo(intChan, 19) & C
                                        strCMD(4) = C & ALT_PATTERN & C & Vol_Offset
                                    End If

                                    Response = SendCMD(strCMD(0) & strCMD(1) & strCMD(2) & strCMD(3) & strCMD(4))
                                    If Response = "ERR" Then
                                        sngErr += 1
                                        GenLog("Unable to store TGID, COMMS error or scanner out of memory " & varSite(intSystem, intGroup, 0, 1))
                                    End If
                                    If Response = "ERR" And sngErr > 25 Then
                                        intChan = MaxChan
                                        intGroup = MaxGroups
                                        GenLog("Too many errors, aborting remainder of system " & varSite(intSystem, 0, 0, 1))
                                    End If
                                    Call CheckMem("C")
                                End If 'is this a digital channel?
                            End If 'channel loop
                        Next intChan 'channel loop
                    End If
                Next intGroup 'top loop of this section
                Call QGLUL396(intIndex, intSystem) 'send group quickkey status
            ElseIf blnSysOK Then
                sngErr += 1
                If intGroup > 257 Then intGroup = 258
                GenLog("Skipped site " & varSite(intSystem, intGroup, 0, 1) & " - insufficient scanner memory")
            End If  'site index>0
            '  End If     'end the big system? loop
        Next intList
        Call CheckMem("")
        If chkSysQK.CheckState = 1 Then Call UploadQSL() 'SEND SYSTEM quick key state
        If Bln396XT Or bln346 Then
            Call RestoreVolSql(strMDL)
        End If
        strCurOp = "Finished uploading systems. Click on 'Close' to continue."
        'If a BCT15 or BCT15X and a full reset was done, kill beartracker
        If optWriteMode(0).Checked And InStr(strMDL, "BCT15") <> 0 Then
            ResponseCode = SendCMD("BTL,1,1,1,1")
            If ResponseCode <> "OK" Then
                sngErr += 1
                GenLog("Error disabling Bear Tracker")
            End If
        End If
        ResponseCode = SendCMD("EPG")
        CheckResume() 'go back to normal scanning
        msc.Close()

        If Me.Visible = True Then
            cmdClose.Focus()
        Else
            With lblSiteNote
                If sngErr = 0 Then
                    .DispStat("Upload complete with no errors")
                Else
                    .DispStat("Errors during upload")
                    Me.Visible = True
                End If
            End With
        End If


        SetFinishGraphic()
        Exit Sub
criticerror:
            IOGraphic(("F"))

            Call ErrorHandler(Err.Number, strLog)
            If msc.IsOpen = True Then msc.Close()


    End Sub
    Sub SetFinishGraphic()
        If lblErr.Text = "0" Then
            IOGraphic(("D"))
        End If
    End Sub



    Sub ShowComSettings()
        'displays current com port settings
        cmdSetupCom.Text = "COM" & RadioSetting(44) & " " & RadioSetting(45) & "..."
    End Sub
    Function MakeItKosher(ByRef strItem As String) As String
        Dim strKosher, strChar As String
        Dim intCharPos As Integer
        strKosher = Nothing
        'cleans up a name for a group/system so it can be accepted
        'remove/replace evil characters, such as quotations or commas
        For intCharPos = 1 To Len(strItem)
            strChar = Mid(strItem, intCharPos, 1)
            If Asc(strChar) <= 31 Or Asc(strChar) >= 127 Then
                'replace with null
                strChar = ""
            End If
            strKosher = strKosher & strChar
        Next intCharPos
        MakeItKosher = strKosher

    End Function





    'UPGRADE_WARNING: Form event Form1.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub Form1_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        ShowComSettings()
        'LoadPrefs()
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        ShowComSettings()
        LoadPrefs()
        InitCOMPort()

    End Sub


    'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    'UPGRADE_WARNING: Form1 event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub Form_Terminate_Renamed()
        Call cmdClose_Click(cmdClose, New System.EventArgs())
    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call cmdClose_Click(cmdClose, New System.EventArgs())
    End Sub

    Sub initForm()
        strLog = ""
        intChannelsFound = 0
        intGroupsFound = 0
        intSitesFound = 0
        sngErr = 0
        intChnSkip = 0
        WriteStats()
        lblOp.Text = "Click on 'Start Upload' to upload"
    End Sub
    Sub WriteStats()
        'displays a total count for all sites,channels,groups found
        lblSystemsFound.Text = CStr(intSitesFound)
        lblGroupsFound.Text = CStr(intGroupsFound)
        lblChannelsFound.Text = CStr(intChannelsFound)
        lblErr.Text = CStr(sngErr)
        lblChnSkip.Text = CStr(intChnSkip)
    End Sub

    Private Sub lblErr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblErr.Click
        frmConsole.Visible = True
    End Sub

    Public Sub mnuAbort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAbort.Click
        Call frmCommsDownload.mnuAbort_Click(Nothing, New System.EventArgs())
    End Sub

    Public Sub mnuCopyClipbaord_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCopyClipbaord.Click
        Call frmCommsDownload.mnuCopyLog_Click(Nothing, New System.EventArgs())
    End Sub

    Public Sub mnuScannerCOMPort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuScannerCOMPort.Click
        Me.Enabled = False
        frmCOMPort.Visible = True
        frmCOMPort.Activate()
    End Sub

    Public Sub mnuScannerQKEdit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuScannerQKEdit.Click
        frmQKEdit.initForm()
        frmQKEdit.Visible = True
    End Sub

    Private Sub msc_OnComm(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        intTimer = intTimer + 1
        If intTimer = 10 Then intTimer = 0
        If lblSiteNote.Visible = False And frmDupeN_N.Visible = True Then
            frmDupeN_N.Visible = False
        End If
    End Sub
    Sub uploadGDO()
        'upload gps setting
        Dim strCMD As String
        strCMD = "GDO," & RadioSetting(46) & "," & RadioSetting(47) & "," & RadioSetting(48) & "," & Val(RadioSetting(50)).ToString("##.0") & "," & RadioSetting(49)
        SendCMD(strCMD)
    End Sub
    Sub UploadCBP()
        'upload custom search band plan for custom search
        'verify data is good
        Dim Srch_Index As Integer, Response As String
        For Srch_Index = 0 To 9
            If Len(CBPData(Srch_Index)) > 8 Then
                Response = SendCMD("CBP," & Trim(Str(Srch_Index)) & "," & CBPData(Srch_Index))
                If Response <> "OK" Then
                    sngErr += 1
                    GenLog("Caution:Trouble settings Band Plan on custom search range #" & Srch_Index)
                End If
            End If
        Next
    End Sub
    Sub CommonWX(ByVal strMDL As String)
        If Not blnDebug Then On Error GoTo criticerror
        'upload weather setting
        Dim strBuff() As String
        Dim Response As String = Nothing
        Dim strCMD As String
        Dim cnt, cnt1 As Integer, blnXT As Boolean, strDelay As String
        If InStr(strMDL, "XT") <> 0 Or strMDL = "BCT15X" Then
            blnXT = True
        Else
            blnXT = False
        End If
        'eventually need to add support for record output
        strDelay = MakeDelay(RadioSetting(73), blnXT)
        strBuff = Split(RadioSetting(71), Chr(9))
        If UBound(strBuff) >= 2 And blnXT = False Then

            strCMD = "WXS," & strDelay & "," & strBuff(1) & "," & strBuff(0)
            If strMDL = "BCD996T" Or strMDL = "BC15T" Then
                strCMD &= ",1"
            End If
            Response = SendCMD(strCMD)
        ElseIf UBound(strBuff) >= 2 And blnXT Then
            strCMD = "WXS," & strDelay & "," & strBuff(1) & "," & strBuff(0) & ",," & MakeBinary(RadioSetting(94)) & ","
            Response = SendCMD(strCMD)
        End If
        If Response <> "OK" Then
            sngErr += 1
            GenLog("Unable to set WX")
        End If
        Erase strBuff
        strCMD = ""
        cnt1 = 0
        strBuff = Split(RadioSetting(72), Chr(9))
        If UBound(strBuff) = 45 Then
            For cnt = 0 To 4
                cnt1 = cnt * 9
                strCMD = "SGP," & cnt + 1 & "," & strBuff(cnt1) & "," & strBuff(cnt1 + 1) & "," & strBuff(cnt1 + 2) & "," & strBuff(cnt1 + 3) & ","
                strCMD = strCMD & strBuff(cnt1 + 4) & "," & strBuff(cnt1 + 5) & "," & strBuff(cnt1 + 6) & "," & strBuff(cnt1 + 7) & "," & strBuff(cnt1 + 8)

                Response = SendCMD(strCMD)
            Next cnt
        End If
        Exit Sub
criticerror:
        MsgBox("Critical error occured , cannot upload Weather settings.")
        Exit Sub
    End Sub
    Sub Send246WX()
        On Error GoTo criticerror
        'upload weather setting
        Dim strBuff() As String
        Dim Response, strCMD As String
        Dim cnt, cnt1 As Integer
        strBuff = Split(RadioSetting(71), Chr(9))
        If UBound(strBuff) >= 2 Then
            strCMD = "WPR," & strBuff(0)

            Response = SendCMD(strCMD)
        End If
        Erase strBuff
        strCMD = ""
        cnt1 = 0
        strBuff = Split(RadioSetting(72), Chr(9))
        If UBound(strBuff) = 45 Then
            For cnt = 0 To 4
                cnt1 = cnt * 9
                strCMD = "SGP," & cnt + 1 & "," & strBuff(cnt1) & "," & strBuff(cnt1 + 1) & "," & strBuff(cnt1 + 2) & "," & strBuff(cnt1 + 3) & ","
                strCMD = strCMD & strBuff(cnt1 + 4) & "," & strBuff(cnt1 + 5) & "," & strBuff(cnt1 + 6) & "," & strBuff(cnt1 + 7) & "," & strBuff(cnt1 + 8)

                Response = SendCMD(strCMD)
            Next cnt
        End If
        Exit Sub
criticerror:
        MsgBox("Critical error occured , cannot upload Weather settings.")
        Exit Sub
    End Sub
    Sub ToneUL396()
        'upload toneout settings to radio
        If Not blnDebug Then On Error GoTo Oops
        Dim strBuff() As String
        Dim strBuff1() As String
        Dim strbuff2() As String
        Dim strbuff3() As String
        Dim strBuff5() As String
        Dim strBuff6() As String
        Dim strCMD, Response As String
        Dim cnt, intTonIndex As Integer
        Dim sngTone1, sngTone2 As Single
        'get settings into buffer

        strBuff = Split(RadioSetting(74), Chr(9)) 'name
        strBuff1 = Split(RadioSetting(75), Chr(9)) 'frequency
        strbuff2 = Split(RadioSetting(76), Chr(9)) 'tone out freqs
        If InStr(RadioSetting(77), Chr(9)) = 0 Then
            strbuff3 = Split(RadioSetting(77), ",") 'alert type
        Else
            strbuff3 = Split(RadioSetting(77), Chr(9)) 'alert type
        End If
        strBuff5 = Split(RadioSetting(78), Chr(9)) 'alert level
        strBuff6 = Split(RadioSetting(79), Chr(9)) 'delay time
        If UBound(strBuff1) = 45 And UBound(strbuff3) = 45 Then
            For cnt = 1 To 10
                intTonIndex = cnt
                If cnt = 10 Then intTonIndex = 0 'make up for uniden weirdness
                'set defaults
                If strBuff6(cnt - 1) = "" Then strBuff6(cnt - 1) = "2" 'delay time
                sngTone1 = Val(strbuff2((cnt - 1) * 2)) * 10
                sngTone2 = Val(strbuff2(((cnt - 1) * 2) + 1)) * 10

                strCMD = "TON," & intTonIndex & "," & MakeItKosher(strBuff(cnt - 1)) & "," & (Val(strBuff1(cnt - 1)) * 10000) & ",AUTO,0,"
                strCMD = strCMD & strBuff6(cnt - 1) & "," & Val(strbuff3(cnt - 1)) & "," & Val(strBuff5(cnt - 1)) & ","
                strCMD = strCMD & sngTone1 & ",," & sngTone2 & ",,"

                Response = SendCMD(strCMD)
            Next cnt
        End If
        Exit Sub
Oops:
        sngErr += 1
        GenLog("Error uploading Fire Tone Out")
    End Sub

    Sub CommonSendReband(ByRef intSys As Integer, ByRef intSite As Integer, ByRef intSiteIndex As Integer)
        'sends the MCP band plan to the scanner
        Dim strBuff, Response As String
        'Is there a valid band plan avail
        strBuff = varSite(intSys, intSite, 0, 62)
        If Len(strBuff) < 10 Then Exit Sub
        'reformat it for the scanner
        strBuff = Replace(strBuff, "@", ",")
        'send it away

        Response = SendCMD("MCP," & intSiteIndex & "," & strBuff)
        If Response <> "OK" Then
            sngErr = sngErr + 1
            Call GenLog("Error attempting to send Motorola Custom Band Plan")
        End If
    End Sub
    Function RemoveType(ByRef strSysname As String) As String
        'removes the type of system from the name
        If blnDebug = False Then On Error Resume Next
        Dim intPos As Integer
        intPos = InStr(strSysname, "]")
        strSysname = VB.Right(strSysname, Len(strSysname) - intPos)
        RemoveType = strSysname
    End Function

    Sub CommonABP(ByVal intSystem As Integer, ByVal intSite As Integer, ByVal intSiteIndex As Integer)
        Dim strCMD As String, cnt As Integer, Response As String, intChan As Integer
        Dim strFreq() As String, strSpacing() As String
        If blnDebug Then On Error GoTo criticerror
        strCMD = "ABP," & intSiteIndex
        strFreq = Split(varSite(intSystem, intSite, 0, 30), ",")
        strSpacing = Split(varSite(intSystem, intSite, 0, 31), ",")
        If UBound(strFreq) = 15 Then
            For intChan = 0 To 15
                strCMD &= "," & Hex((Val(strFreq(intChan)) * 1000000) / 5) 'freq
                strCMD &= "," & Hex((Val(strSpacing(intChan)) * 1000) / 125) 'spacing
            Next intChan
            Response = SendCMD(strCMD)
            If Response = "ERR" Then GoTo criticerror
        Else
            GenLog("No APCO band plan available for " & varSite(intSystem, intSite, 0, 1))
        End If

        Exit Sub
criticerror:
        GenLog("APCO Upload error " & varSite(intSystem, intSite, 0, 1))
        sngErr += 1
    End Sub

    Function ChgAlertCode(ByVal ALT_PATTERN As String, ByVal ALT_COLOR As String, ByVal strMdl As String) As String
        ChgAlertCode = ALT_PATTERN
        'Takes a 346XT alert pattern mode and converts it to a color XT alert pattern mode to 
        'because the codes are different across scanners
        If strMdl = "BC346XT" Or strMdl = "BCT15X" Or strMdl = "BC346XTC" Then
            If ALT_COLOR = "OFF" And ALT_PATTERN = "0" Then
                ChgAlertCode = "0"
            ElseIf ALT_PATTERN = "0" Then
                ChgAlertCode = "1"
            ElseIf ALT_PATTERN = "1" Then
                ChgAlertCode = "2"
            ElseIf ALT_PATTERN = "2" Then
                ChgAlertCode = "3"
            End If
        End If

    End Function
    Sub SendDBC(ByVal blnAnalog As Boolean, ByVal strMDL As String)
        'Send custom bandplan to XT
        Dim cnt As Integer
        Dim STp, strMOD, strBuff As String
        Dim strCMD As String
        Dim Response As String
        Dim C As String = ","
        If Not blnDebug Then On Error GoTo Critic
        If strMDL <> "BC346XT" Or strMDL <> "BC346XTC" Then
            For cnt = 0 To 30
                STp = BandSet(cnt, 0)
                strMOD = BandSet(cnt, 1)
                strCMD = "DBC," & CStr(cnt + 1) & C & STp & C & strMOD
                Response = SendCMD(strCMD)
                If Response <> "OK" Then
                    GenLog("Caution: Possible issue sending bandplan")
                End If
            Next
        Else
            For cnt = 0 To 17
                STp = BandSet(cnt, 0)
                strMOD = BandSet(cnt, 1)
                strCMD = "DBC," & CStr(cnt + 1) & C & STp & C & strMOD
                Response = SendCMD(strCMD)
                If Response <> "OK" Then
                    GenLog("Caution: Possible issue sending bandplan")
                End If
            Next
            For cnt = 20 To 24
                STp = BandSet(cnt, 0)
                strMOD = BandSet(cnt, 1)
                strCMD = "DBC," & CStr(cnt - 1) & C & STp & C & strMOD
                Response = SendCMD(strCMD)
                If Response <> "OK" Then
                    GenLog("Caution: Possible issue sending bandplan")
                End If
            Next
            For cnt = 27 To 30
                STp = BandSet(cnt, 0)
                strMOD = BandSet(cnt, 1)
                strCMD = "DBC," & CStr(cnt - 3) & C & STp & C & strMOD
                Response = SendCMD(strCMD)
                If Response <> "OK" Then

                    GenLog("Caution: Possible issue sending bandplan")
                End If
            Next
        End If
        Exit Sub
critic:
        MsgBox("Critical error attempting to set band plan.Uploading will continue but bandplan settings may not be complete.")
        GenLog("Critic BP")
    End Sub
    Sub SaveVolSql(ByVal strMDL As String)
        'saves volume, backlight state, and squelch settings
        'for the whiners

        strVOL = SendCMD("VOL")
        strSQL = SendCMD("SQL")
        'get back to this'strBKL = ParaParse(SendCMD("BKL"), )
    End Sub
    Sub RestoreVolSql(ByVal strMDL As String)
        Dim response As String
        response = SendCMD("VOL," & strVOL)
        response = SendCMD("SQL," & strSQL)
    End Sub

    Private Sub cmdChkChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChkChange.Click
        'checks all  items in list box that have the changed flag\
        If Not blnDebug Then On Error Resume Next
        Dim x As Integer
        Dim SortMode As String
        Dim SysOrder(MaxSystems, 4) As String ' 0=Index, 1=Name, 2=QK, 3=Type (short string MOT2)
        SortMode = GetSetting("FreeSCAN", "Settings", "SortOrder", "0")
        SysOrder = lblSiteNote.GetSysArray(SortMode)
        '  System.Array.Clear(intSystems, 0, intSystems.Length)
        '   SysOrder = lblSiteNote.GetSysArray(SortMode)
        For x = 0 To lstSystems.Items.Count - 1
            lstSystems.SelectedIndex = x
            If varSite(Val(SysOrder(x, 0)), 0, 0, 34) = "1" Then
                lstSystems.SetItemChecked(x, True)
            Else
                lstSystems.SetItemChecked(x, False)
            End If
        Next x
    End Sub
    Sub UploadLOI(ByVal SysID As String, ByVal SysIndex As String)
        'Sends all the TGID lockouts to a system
        If Not blnDebug Then On Error GoTo LOIError
        Dim iPos As Integer = 0
        Dim iMax As Integer = UBound(GliDX)
        Dim sBuff As String = Nothing
        For iPos = 0 To iMax
            If GliDX(iPos, 0) = SysID Then
                sBuff = SendCMD("LOI," & SysIndex & "," & GliDX(iPos, 1))
                If sBuff <> "OK" Then
                    sngErr += 1
                    GenLog("Error sending system TGID lockouts - out of resources?")
                    Exit Sub
                End If
            End If
        Next
        Exit Sub
LOIError:
        sngErr += 1
        GenLog("Critical Error sending system TGID lockouts")
    End Sub

    Private Sub cmdSetupCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetupCom.Click
        Call mnuScannerCOMPort_Click(Nothing, Nothing)
    End Sub
End Class
