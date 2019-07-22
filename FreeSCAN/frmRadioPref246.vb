Option Strict Off
Option Explicit On
Friend Class frmRadioPref246
	Inherits System.Windows.Forms.Form


	Sub LoadData()
        If blnDebug = False Then On Error Resume Next
		'loads all data into the preferences form, from memory
		'general setting
		Dim strBuff() As String
        Dim cnt, cnt1, introw, introwcnt As Integer


        CheckBox1.Checked = GetSetting("FreeSCAN", "Settings", "CustAdv", False)
        Dim optbacklight1(10) As RadioButton
        optbacklight1(0) = _optBackLight1_0
        optbacklight1(1) = _optBackLight1_1
        optbacklight1(2) = _optBackLight1_2
        optbacklight1(3) = _optBackLight1_3
        optbacklight1(4) = _optBackLight1_4
        optbacklight1(5) = _optBackLight1_5
        optbacklight1(6) = _optBackLight1_6
        optbacklight1(7) = _optBackLight1_7
        optbacklight1(8) = _optBackLight1_8
        optbacklight1(9) = _optBackLight1_9
        optbacklight1(10) = _optBackLight1_10

		Select Case RadioSetting(1)
			Case "LOW"
				optBackLight1(1).Checked = True
			Case "MIDL"
				optBackLight1(2).Checked = True
			Case "HIGH"
				optBackLight1(3).Checked = True
			Case "+POL"
				optBackLight1(4).Checked = True
			Case "-POL"
				optBackLight1(5).Checked = True
			Case Else
				optBackLight1(0).Checked = True
		End Select

		'backlight colour
		Select Case RadioSetting(2)
			Case "GREEN"
				optBacklightGreen.Checked = True
            Case "BLUE"
                optBacklightBlue.Checked = True
            Case "RED"
                optBacklightRed.Checked = True
            Case "MAGENTA"
                optBacklightMagenta.Checked = True
            Case "CYAN"
                optBacklightCyan.Checked = True
            Case "YELLOW"
                optBacklightYellow.Checked = True
            Case "WHITE"
                optBacklightWhite.Checked = True
        End Select
        'default state
        cmbState.SelectedIndex = Val(RadioSetting(109)) - 1
        'xt brightness
        cnt = Val(RadioSetting(95))
        If cnt >= 1 And cnt <= 3 Then
            sldXTBright.Value = cnt
        Else
            RadioSetting(95) = "2"
            sldXTBright.Value = 2
        End If
        'xt channel logging
        Select Case RadioSetting(96)
            Case "0"
                optXTChanLog0.Checked = True
            Case "1"
                optXTChanLog1.Checked = True
            Case "2"
                optXTChanLog2.Checked = True
            Case Else
                optXTChanLog0.Checked = True
                RadioSetting(96) = "0"
        End Select
        'xt p25 low pass
        chkXTP25LP.Checked = MakeBoolean(RadioSetting(106))
        'xt global att                                        
        chkXTGlobalAtt.Checked = MakeBoolean(RadioSetting(97))
        'xt key safe and key lock
        chkXTKeySafe.Checked = MakeBoolean(RadioSetting(105))
        chkXTKeyLock.Checked = MakeBoolean(RadioSetting(104))
        'xt battery charge time
        If Val(RadioSetting(107)) > 0 And Val(RadioSetting(107)) <= 16 Then
            cmbBatChg.Text = RadioSetting(107)
        Else
            cmbBatChg.Text = "5"
            RadioSetting(107) = "5"
        End If
        'xt unit ID
        chkUnitID.CheckState = MakeBinary(RadioSetting(108))
        'XT Global IF Exchange
        intRowCnt = 0
        With grdGIF
            .Rows.Clear()
            .RowCount = 1
            If IsArray(strIFEX) Then
                For intRow = 1 To UBound(strIFEX)
                    If Val(strIFEX(intRow)) > 0 Then
                        intRowCnt += 1
                    End If
                Next
                .RowCount = intRowCnt + 1
                intRowCnt = 0
                For introw = 1 To UBound(strIFEX)

                    If Val(strIFEX(introw)) > 0 Then
                        grdGIF(0, introwcnt).Value = FormatFreq(strIFEX(introw))
                        introwcnt += 1
                    End If
                Next
            End If
        End With

        'battery save

        chkBatSave.CheckState = MakeBinary(RadioSetting(86))
        Select Case RadioSetting(85) 'handheld backlight mode
            Case "10"
                optBackLight1(7).Checked = True
            Case "30"
                optBackLight1(8).Checked = True
            Case "KY"
                optBackLight1(9).Checked = True
            Case "SQ"
                optBackLight1(10).Checked = True
            Case Else
                optBackLight1(6).Checked = True
        End Select
        'lcd settings
        Select Case RadioSetting(28)
            Case "1"
                optMode1.Checked = True
            Case "2"
                optMode2.Checked = True
            Case Else
                OptMode3.Checked = True
        End Select
        chkActChanDisp.CheckState = Val(RadioSetting(30))
        chkLCDFlip.CheckState = Val(RadioSetting(31))
        sldLCDContrast.Value = Val(RadioSetting(29))

        txtStartupMsg1.Text = RadioSetting(5)
        txtStartUpMsg2.Text = RadioSetting(6)
        txtStartUpMsg3.Text = RadioSetting(22)
        txtStartUpMsg4.Text = RadioSetting(23)

        Select Case RadioSetting(4) 'key beep off/level/auto
            Case CStr(99)
                sldKeyBeep.Value = 16
            Case Else
                sldKeyBeep.Value = Val(RadioSetting(4))
        End Select
        'AGC stuff

        chkAnalogAGC.CheckState = MakePositive(RadioSetting(25))

        chkDigitalAGC.CheckState = MakePositive(RadioSetting(26))
        Erase strBuff
        strBuff = Split(RadioSetting(87), ",")
        Dim cmbAGc(5) As ComboBox
        cmbAGc(0) = _cmbAGC_0
        cmbAGc(1) = _cmbAGC_1
        cmbAGc(2) = _cmbAGC_2
        cmbAGc(3) = _cmbAGC_3
        cmbAGc(4) = _cmbAGC_4
        cmbAGc(5) = _cmbAGC_5
        If UBound(strBuff) = 5 Then 'good data
            For cnt = 0 To 5
                cmbAGC(cnt).Text = CStr(Val(strBuff(cnt)))
            Next cnt
        Else
            'load defaults
            cmbAGC(0).SelectedIndex = 4
            cmbAGC(1).SelectedIndex = 5
            cmbAGC(2).SelectedIndex = 6
            cmbAGC(3).SelectedIndex = 8
            cmbAGC(4).SelectedIndex = 5
            cmbAGC(5).SelectedIndex = 6
        End If
        'p25 wait time
        cmbP25Wait.Text = CStr(Val(RadioSetting(88)))
        Dim optprimode(2) As RadioButton
        optprimode(0) = _optPriMode_0
        optprimode(1) = _optPriMode_1
        optprimode(2) = _optPriMode_2
        Select Case RadioSetting(3)
            Case "0"
                optPriMode(0).Checked = True
            Case "1"
                optPriMode(1).Checked = True
            Case Else
                optPriMode(2).Checked = True
                RadioSetting(3) = "2"
        End Select
        If Val(RadioSetting(89)) > 0 Then
            MaxPriChan.Text = RadioSetting(89)
        Else
            MaxPriChan.Text = "100"
            RadioSetting(89) = "100"
        End If
        If Val(RadioSetting(93)) > 0 Then
            PriIntTime.Text = RadioSetting(93)
        Else
            PriIntTime.Text = "1"
            RadioSetting(93) = "1"
        End If

        'gps settings
        'gps setting
        Dim optGPSDispMode(4) As RadioButton
        optGPSDispMode(0) = _optGPSDispMode_0
        optGPSDispMode(1) = _optGPSDispMode_1
        optGPSDispMode(2) = _optGPSDispMode_2
        optGPSDispMode(3) = _optGPSDispMode_3
        optGPSDispMode(4) = _optGPSDispMode_4
        optGPSDispMode(Val(RadioSetting(46))).Checked = True 'gps display mode
        chkGPSKM.CheckState = Val(RadioSetting(47)) 'use km instead of miles
        If RadioSetting(49) = "DMS" Then
            chkGPSDMS.Checked = True 'use dms instead of deg
        Else
            chkGPSDMS.Checked = False
        End If
        chkGPSTimeFormat.CheckState = Val(RadioSetting(48)) 'use 24 hour format
        If RadioSetting(50) <> "" Then 'GMT offset
            cmbGPSTimeZone.Text = CStr(Val(RadioSetting(50)))
        Else
            cmbGPSTimeZone.Text = "0"
        End If
        Dim optCCMode(2) As RadioButton

        optCCMode(0) = _optCCMode_0
        optCCMode(1) = _optCCMode_1
        optCCMode(2) = _optCCMode_2
        'close call setting
        Select Case RadioSetting(7) 'close call mode
            Case "2"
                optCCMode(2).Checked = True
            Case CStr(1)
                optCCMode(1).Checked = True
            Case Else
                optCCMode(0).Checked = True
        End Select

        'close call bands
        Dim chkCCBand(6) As CheckBox
        chkCCBand(0) = _chkCCBand_0
        chkCCBand(1) = _chkCCBand_1
        chkCCBand(2) = _chkCCBand_2
        chkCCBand(3) = _chkCCBand_3
        chkCCBand(4) = _chkCCBand_4
        chkCCBand(5) = _chkCCBand_5
        chkCCBand(6) = _chkCCBand_6
        For cnt = 1 To 7
            If Mid(RadioSetting(14), cnt, 1) = "1" Then
                chkCCBand(cnt - 1).CheckState = System.Windows.Forms.CheckState.Checked
            Else
                chkCCBand(cnt - 1).CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        Next cnt
        'close call xt alert light and pat
        If RadioSetting(99) <> Nothing Then
            cmbCCAltCol.Text = RadioSetting(99)
        Else
            cmbCCAltCol.Text = "Off"
            RadioSetting(99) = "OFF"
        End If
        Select Case RadioSetting(100)
            Case "0"
                cmbCCAltPat.Text = "On"
            Case "1" 'slow
                cmbCCAltPat.Text = "Slow"
            Case "2" ' fast
                cmbCCAltPat.Text = "Fast"
        End Select
        'alert mode
        Dim optalertmode(3) As RadioButton
        optalertmode(0) = _optAlertMode_0
        optalertmode(1) = _optAlertMode_1
        optalertmode(2) = _optAlertMode_2
        optalertmode(3) = _optAlertMode_3
        Select Case RadioSetting(27)
            Case "B"
                optAlertMode(1).Checked = True
            Case "L"
                optAlertMode(2).Checked = True
            Case "A"
                optAlertMode(3).Checked = True
            Case Else
                optAlertMode(0).Checked = True
                RadioSetting(27) = "N"
        End Select

        'cc alert
        cmbCloseCallAlertType.Text = RadioSetting(13)
        sldCCVol.Value = Val(RadioSetting(15))

        'cc general options
        cmbCCPauseTime.Text = RadioSetting(11)
        cmbMaxAutoStore.Text = Val(RadioSetting(32)) - 1 'i can see this crashing!
        cmbCCQuickKey.Text = RadioSetting(9)
        chkCCHits.CheckState = Val(RadioSetting(10))
        chkCloseCallOverride.Checked = MakeBoolean(RadioSetting(8))
        Select Case RadioSetting(24)
            Case "0"
                optCCCodeSearch0.Checked = True
            Case "1"
                optCCCodeSearch1.Checked = True
            Case Else
                optCCCodeSearch2.Checked = True
        End Select

        chkCCAGCA.Checked = MakeBoolean(RadioSetting(101))
        chkCCAGCD.Checked = MakeBoolean(RadioSetting(102))
        'load custom search variables
        'setup up the grid
        LoadCustGrid()
        'load custom lockout frequencies
        Call LoadgrdFreqLO()

        'search key
        Dim cmbSearchKey(5) As ComboBox
        cmbSearchKey(0) = _cmbSearchKey_0
        cmbSearchKey(1) = _cmbSearchKey_1
        cmbSearchKey(2) = _cmbSearchKey_2
        cmbSearchKey(3) = _cmbSearchKey_3
        cmbSearchKey(4) = _cmbSearchKey_4
        cmbSearchKey(5) = _cmbSearchKey_5
        For cnt = 0 To 5
            cmbSearchKey(cnt).Text = RadioSetting(34 + cnt)
        Next cnt
        cmbSSsystem.SelectedIndex = 1

        LoadServSearchFrame()
        'searching tab


        cmbSSStep.Text = StepSize(Val(RadioSetting(17)), 0)
        cmbSSModMode.Text = RadioSetting(18)
        cmbSSDelay.Text = RadioSetting(21)
        cmbSSHold.Text = CStr(Val(RadioSetting(24)))
        cmbMaxAutoStore.Text = RadioSetting(32)
        chkSSAtt.CheckState = Val(RadioSetting(33))
        chkSSDataSkip.CheckState = Val(RadioSetting(40))
        chkSSRepeater.CheckState = Val(RadioSetting(41))
        chkCCTapeOut.CheckState = Val(RadioSetting(42))
        Dim chkbsc(15) As CheckBox
        chkbsc(0) = _chkBSC_0
        chkbsc(1) = _chkBSC_1
        chkbsc(2) = _chkBSC_2
        chkbsc(3) = _chkBSC_3
        chkbsc(4) = _chkBSC_4
        chkbsc(5) = _chkBSC_5
        chkbsc(6) = _chkBSC_6
        chkbsc(7) = _chkBSC_7
        chkbsc(8) = _chkBSC_8
        chkbsc(9) = _chkBSC_9
        chkbsc(10) = _chkBSC_10
        chkbsc(11) = _chkBSC_11
        chkbsc(12) = _chkBSC_12
        chkbsc(13) = _chkBSC_13
        chkbsc(14) = _chkBSC_14
        chkbsc(15) = _chkBSC_15

        For cnt = 0 To 15
            chkBSC(cnt).CheckState = Val(Mid(RadioSetting(43), cnt + 1, 1))
        Next cnt
        Dim txtBBS(19) As TextBox
        txtBBS(0) = _txtBBS_0
        txtBBS(1) = _txtBBS_1
        txtBBS(2) = _txtBBS_2
        txtBBS(3) = _txtBBS_3
        txtBBS(4) = _txtBBS_4
        txtBBS(5) = _txtBBS_5
        txtBBS(6) = _txtBBS_6
        txtBBS(7) = _txtBBS_7
        txtBBS(8) = _txtBBS_8
        txtBBS(9) = _txtBBS_9
        txtBBS(10) = _txtBBS_10
        txtBBS(11) = _txtBBS_11
        txtBBS(12) = _txtBBS_12
        txtBBS(13) = _txtBBS_13
        txtBBS(14) = _txtBBS_14
        txtBBS(15) = _txtBBS_15
        txtBBS(16) = _txtBBS_16
        txtBBS(17) = _txtBBS_17
        txtBBS(18) = _txtBBS_18
        txtBBS(19) = _txtBBS_19
        'broadcast band screening
        For cnt = 0 To 19
            txtBBS(cnt).Text = Format(Val(RadioSetting(51 + cnt)), "###0.0000")
        Next cnt
        'lcd contrast
        sldLCDContrast.Value = CInt(RadioSetting(29))

        'weather alert
        'checkboxes
        Erase strBuff
        strBuff = Split(RadioSetting(71), Chr(9))
        Dim chkWX(3) As CheckBox
        chkWX(0) = _chkWX_0
        chkWX(1) = _chkWX_1
        chkWX(2) = _chkWX_2
        For cnt = 0 To UBound(strBuff)
            If cnt < 3 Then
                chkWX(cnt).CheckState = Val(strBuff(cnt))
            End If
        Next cnt
        Erase strBuff
        'text boxes
        Dim txtwx(45) As TextBox
        txtwx(0) = _txtWX_0
        txtwx(1) = _txtWX_1
        txtwx(2) = _txtWX_2
        txtwx(3) = _txtWX_3
        txtwx(4) = _txtWX_4
        txtwx(5) = _txtWX_5
        txtwx(6) = _txtWX_6
        txtwx(7) = _txtWX_7
        txtwx(8) = _txtWX_8
        txtwx(9) = _txtWX_9
        txtwx(10) = _txtWX_10
        txtwx(11) = _txtWX_11
        txtwx(12) = _txtWX_12
        txtwx(13) = _txtWX_13
        txtwx(14) = _txtWX_14
        txtwx(15) = _txtWX_15
        txtwx(16) = _txtWX_16
        txtwx(17) = _txtWX_17
        txtwx(18) = _txtWX_18
        txtwx(19) = _txtWX_19
        txtwx(20) = _txtWX_20
        txtwx(21) = _txtWX_21
        txtwx(22) = _txtWX_22
        txtwx(23) = _txtWX_23
        txtwx(24) = _txtWX_24
        txtwx(25) = _txtWX_25
        txtwx(26) = _txtWX_26
        txtwx(27) = _txtWX_27
        txtwx(28) = _txtWX_28
        txtwx(29) = _txtWX_29

        txtwx(30) = _txtWX_30
        txtwx(31) = _txtWX_31
        txtwx(32) = _txtWX_32
        txtwx(33) = _txtWX_33
        txtwx(34) = _txtWX_34
        txtwx(35) = _txtWX_35
        txtwx(36) = _txtWX_36
        txtwx(37) = _txtWX_37
        txtwx(38) = _txtWX_38
        txtwx(39) = _txtWX_39
        txtwx(40) = _txtWX_40
        txtwx(41) = _txtWX_41
        txtwx(42) = _txtWX_42
        txtwx(43) = _txtWX_43
        txtwx(44) = _txtWX_44

        

        If RadioSetting(72) <> "" Then
            strBuff = Split(RadioSetting(72), Chr(9))
            For cnt = 0 To UBound(strBuff)
                If cnt < 45 Then
                    txtWX(cnt).Text = strBuff(cnt)
                End If
            Next cnt
        Else
            For cnt = 1 To 44
                txtWX(cnt).Text = ""
            Next
            txtWX(0).Text = "SAME 1"
            txtWX(9).Text = "SAME 2"
            txtWX(18).Text = "SAME 3"
            txtWX(27).Text = "SAME 4"
            txtWX(36).Text = "SAME 5"
        End If
        'delay
        cmbWXDelay.SelectedIndex = Val(RadioSetting(73))

        '***********************fire tone out**********************************
        Erase strBuff
        grdToneOut.Rows.Clear()
        grdToneOut.RowCount = 10

        'names

        strBuff = Split(RadioSetting(74), Chr(9))

        If UBound(strBuff) = 45 Then
            For cnt = 0 To 9
                grdToneOut(0, cnt).Value = strBuff(cnt)

            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(0, cnt).Value = "Tone Out " & cnt + 1
            Next cnt
        End If

        'base freq
        cnt1 = 0
        Erase strBuff
        strBuff = Split(RadioSetting(75), Chr(9))
        If UBound(strBuff) = 45 Then
            For cnt = 1 To 37 Step 4
                grdToneOut(1, cnt1).Value = FormatFreq((CDbl(Val(strBuff(cnt1)))))
                cnt1 += 1
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(1, cnt1).Value = "0.0000"
                cnt1 += 1
            Next cnt
        End If

        'Tones A & B
        Erase strBuff
        cnt1 = 0
        strBuff = Split(RadioSetting(76), Chr(9))
        If UBound(strBuff) = 20 Then
            For cnt = 0 To 18 Step 2
                grdToneOut(2, cnt1).Value = strBuff(cnt)
                grdToneOut(3, cnt1).Value = (strBuff(cnt + 1))
                cnt1 += 1
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(2, cnt).Value = "0"
                grdToneOut(3, cnt).Value = "0"     
            Next cnt
        End If

        'modulation
        Erase strBuff
        cnt1 = 0
        strBuff = Split(RadioSetting(81), ",")
        If UBound(strBuff) = 9 Then
            For cnt = 0 To 9
                Select Case strBuff(cnt)
                    Case "AUTO"
                        grdToneOut(5, cnt).Value = "AUTO"
                    Case "FM"
                        grdToneOut(5, cnt).Value = "FM"
                    Case "NFM"
                        grdToneOut(5, cnt).Value = "NFM"
                End Select
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(5, cnt).Value = "AUTO"
            Next cnt
        End If

        'alert tone type
        Erase strBuff
        cnt1 = 0
        strBuff = Split(RadioSetting(77), Chr(9))
        If UBound(strBuff) = 45 Then
            For cnt = 0 To 9
                grdToneOut(6, cnt).Value = CStr(Val(strBuff(cnt)))
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(6, cnt).Value = "0"
            Next cnt
        End If
        'alert tone level
        Erase strBuff
        cnt1 = 0
        strBuff = Split(RadioSetting(78), Chr(9))
        If UBound(strBuff) = 45 Then
            For cnt = 0 To 9
                grdToneOut(7, cnt).Value = CStr(Val(strBuff(cnt)))
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(7, cnt).Value = "0"
            Next cnt
        End If
        'delay
        Erase strBuff
        cnt1 = 0
        strBuff = Split(RadioSetting(79), Chr(9))
        If UBound(strBuff) = 45 Then
            For cnt = 0 To 9
                If strBuff(cnt) <> "" Then
                    grdToneOut(4, cnt).Value = strBuff(cnt)
                Else
                    grdToneOut(4, cnt).Value = "2"
                End If
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(4, cnt).Value = "2"
            Next cnt
        End If
        'record
        Erase strBuff
        cnt1 = 0
        strBuff = Split(RadioSetting(80), Chr(9))
        If UBound(strBuff) = 45 Then
            For cnt = 0 To 9
                grdToneOut(12, cnt).Value = MakeBoolean(strBuff(cnt))
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(12, cnt).Value = System.Windows.Forms.CheckState.Checked
            Next cnt
        End If
        'alert colour
        Erase strBuff
        strBuff = Split(RadioSetting(90), ",")
        If UBound(strBuff) = 9 Then
            For cnt = 0 To 9
                If Len(strBuff(cnt)) > 2 Then
                    grdToneOut(8, cnt).Value = TCase(strBuff(cnt))
                Else
                    grdToneOut(8, cnt).Value = "Off"
                End If
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(8, cnt).Value = "Off"
            Next cnt
        End If
        'alert pattern
        Erase strBuff
        cnt1 = 0
        strBuff = Split(RadioSetting(91), ",")
        If UBound(strBuff) = 9 Then
            For cnt = 0 To 9
                Select Case strBuff(cnt)
                    Case "0"  'on
                        grdToneOut(9, cnt).Value = "On"
                    Case "1"  'slow
                        grdToneOut(9, cnt).Value = "Slow"
                    Case "2"
                        grdToneOut(9, cnt).Value = "Fast"
                End Select

            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(10, cnt).Value = "On"
            Next cnt
        End If
        'TON AGC
        Erase strBuff
        cnt1 = 0
        strBuff = Split(RadioSetting(92), ",")
        If UBound(strBuff) = 45 Then
            For cnt = 0 To 9
                grdToneOut(11, cnt).Value = MakeBoolean(strBuff(cnt))
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(11, cnt).Value = System.Windows.Forms.CheckState.Checked
            Next cnt
        End If
        'TON MODULATION

        'TON ATT
        Erase strBuff
        cnt1 = 0
        strBuff = Split(RadioSetting(82), ",")
        If UBound(strBuff) = 9 Then
            For cnt = 0 To 9
                grdToneOut(10, cnt).Value = MakeBoolean(strBuff(cnt))
            Next cnt
        Else
            For cnt = 0 To 9
                grdToneOut(10, cnt).Value = System.Windows.Forms.CheckState.Unchecked
            Next cnt
        End If
    End Sub
	Sub LoadCustGrid()
        Dim intRow As Integer
        Dim AGCAnalog, AGCDIgital, P25Wait As Integer
        Dim strBuff As String = Nothing
        AGCAnalog = 0
        AGCDIgital = 0
        P25Wait = 0
        With grdCust
            .Rows.Clear()
            .RowCount = 10

            For intRow = 0 To 9
                strBuff = CustSearch(intRow + 1, 16)
                If Len(strBuff) = 6 Then
                    AGCAnalog = MakeBinary(OldMid(strBuff, 1, 1))
                    AGCDIgital = MakeBinary(OldMid(strBuff, 2, 1))
                    P25Wait = Val(OldMid(strBuff, 4, 4))
                Else
                    AGCAnalog = 1
                    AGCDIgital = 1
                    P25Wait = 0
                    CustSearch(intRow + 1, 16) = "110000"
                End If
                'name
                grdCust(0, intRow).Value = CustSearch(intRow + 1, 0)
                'lo limit
                grdCust(1, intRow).Value = FormatFreq(CustSearch(intRow + 1, 1))
                'hi limit
                grdCust(2, intRow).Value = FormatFreq(CustSearch(intRow + 1, 2))
                'delay time
                grdCust(3, intRow).Value = CStr(Val(CustSearch(intRow + 1, 6)))
                'lockout
                grdCust(4, intRow).Value = MakeBoolean(CustSearch(intRow + 1, 15))
                'enabled
                grdCust(5, intRow).Value = MakeBoolean((CustSearch(intRow + 1, 8)))
                'hold time
                grdCust(6, intRow).Value = CStr(Val(CustSearch(intRow + 1, 9)))
                'step size
                grdCust(7, intRow).Value = StepSize(Val(CustSearch(intRow + 1, 3)), 0)
                'att
                grdCust(8, intRow).Value = MakeBoolean(CustSearch(intRow + 1, 5))
                'data(skip)
                grdCust(9, intRow).Value = MakeBoolean(CustSearch(intRow + 1, 7))
                'Control(chan)
                grdCust(10, intRow).Value = MakeBoolean(CustSearch(intRow + 1, 10))
                'quick(key)
                grdCust(11, intRow).Value = MakeItKosherQK(CustSearch(intRow + 1, 12))
                'startup(key)
                grdCust(12, intRow).Value = MakeItKosherQK(CustSearch(intRow + 1, 13))
                'modul()
                Try
                    grdCust(13, intRow).Value = CustSearch(intRow + 1, 4)
                Catch ex As Exception
                    grdCust(13, intRow).Value = "AUTO"
                    CustSearch(intRow + 1, 4) = "AUTO"
                End Try

                'num(Tag)
                grdCust(14, intRow).Value = MakeItKosherNumTag(CustSearch(intRow + 1, 11))
                'analog(agc)
                grdCust(15, intRow).Value = MakeBoolean(AGCAnalog)
                'digital(agc)
                grdCust(16, intRow).Value = MakeBoolean(AGCDIgital)
                'p25 ait time 
                grdCust(17, intRow).Value = CStr(P25Wait)
                '               rec(out)
                grdCust(18, intRow).Value = MakeBoolean(CustSearch(intRow + 1, 14))
            Next intRow
        End With
		
    End Sub
    Sub SaveCustGrid()
        Dim intRow As Integer
        Dim AGCAnalog, AGCDIgital, P25Wait As Integer
        Dim strBuff As String = Nothing
        AGCAnalog = 0
        AGCDIgital = 0
        P25Wait = 0

        With grdCust
            For intRow = 0 To 9
                'name
                CustSearch(intRow + 1, 0) = MakeItKosherSilent(grdCust(0, intRow).Value, 0)
                'lo limit
                CustSearch(intRow + 1, 1) = MakeItKosherFreqSilent(grdCust(1, intRow).Value)
                'hi limit
                CustSearch(intRow + 1, 2) = MakeItKosherFreqSilent(grdCust(2, intRow).Value)
                'delay time
                CustSearch(intRow + 1, 6) = grdCust(3, intRow).Value
                'lockout
                CustSearch(intRow + 1, 15) = MakeBinary(CStr(grdCust(4, intRow).Value))
                'enabled
                CustSearch(intRow + 1, 8) = (MakeBinary(grdCust(5, intRow).Value))
                'hold time
                CustSearch(intRow + 1, 9) = grdCust(6, intRow).Value
                'step size
                CustSearch(intRow + 1, 3) = MakeItKosherSearchStep(grdCust(7, intRow).Value)
                'att
                CustSearch(intRow + 1, 5) = MakeBinary(CStr(grdCust(8, intRow).Value))
                'data(skip)
                CustSearch(intRow + 1, 7) = MakeBinary(CStr(grdCust(9, intRow).Value))
                'Control(chan)
                CustSearch(intRow + 1, 10) = MakeBinary(CStr(grdCust(10, intRow).Value))
                'quick(key)
                CustSearch(intRow + 1, 12) = grdCust(11, intRow).Value
                'startup(key)
                CustSearch(intRow + 1, 13) = grdCust(12, intRow).Value
                'modul()
                CustSearch(intRow + 1, 4) = grdCust(13, intRow).Value
                'num(Tag)
                CustSearch(intRow + 1, 11) = MakeItKosherNumTag(grdCust(14, intRow).Value)
                'analog(agc)
                AGCAnalog = MakeBinary(CStr(grdCust(15, intRow).Value))
                'digital(agc)
                AGCDIgital = MakeBinary(CStr(grdCust(16, intRow).Value))
                'p25 ait time 
                P25Wait = CInt(grdCust(17, intRow).Value)
                strBuff = CStr(AGCAnalog) & CStr(AGCDIgital) & Format(P25Wait, "0000")
                CustSearch(intRow + 1, 16) = strBuff
                ' '               rec(out)
                CustSearch(intRow + 1, 14) = MakeBoolean(CStr(grdCust(18, intRow).Value))
            Next intRow
        End With

    End Sub
	Sub LoadServSearchFrame()
		'loads the frame for service search
        Dim intSS As Integer
        If Not blnDebug Then On Error Resume Next
		intSS = cmbSSsystem.SelectedIndex + 1
		If intSS > 0 Then
			cmbSSDelayTime.Text = CStr(Val(strSS(intSS, 2)))
			cmbSSQuickKey.Text = strSS(intSS, 5)
			cmbSSHoldTime.Text = CStr(Val(strSS(intSS, 4)))
			cmbSSStartupKey.Text = strSS(intSS, 6)
			chkSrchLO.CheckState = Val(strSS(intSS, 8))
			chkSSAtt.CheckState = Val(strSS(intSS, 3))
            chkSSTapeOut.CheckState = Val(strSS(intSS, 7))
            If strSSXT(intSS, 1) = "1" Then
                chkSSPAnalogAGC.Checked = True
            Else
                chkSSPAnalogAGC.Checked = False
            End If
            If strSSXT(intSS, 2) = "1" Then
                chkSSPDigitalAGC.Checked = True
            Else
                chkSSPDigitalAGC.Checked = False
            End If
            txtSSPNumTag.Text = MakeItKosherNumTag(strSSXT(intSS, 4))
            cmbSSPP25Wait.Text = CStr(Val(strSSXT(intSS, 3)))
		End If
	End Sub
	
    Private Sub chkSrchLO_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSrchLO.CheckStateChanged
        strSS(cmbSSsystem.SelectedIndex + 1, 8) = MakeBinary((chkSrchLO.CheckState))
    End Sub
    Private Sub chkSSAtt_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSSAtt.CheckStateChanged
        strSS(cmbSSsystem.SelectedIndex + 1, 3) = MakeBinary((chkSSAtt.CheckState))
    End Sub

	Private Sub chkSSTapeOut_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSSTapeOut.CheckStateChanged
        strSS(cmbSSsystem.SelectedIndex + 1, 7) = MakeBinary((chkSSTapeOut.CheckState))
	End Sub
	

    'UPGRADE_WARNING: ComboBox event cmbSSDelayTime.Change was upgraded to cmbSSDelayTime.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
    Private Sub cmbSSDelayTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSDelayTime.TextChanged
        'save setting
        strSS(cmbSSsystem.SelectedIndex + 1, 2) = CStr(Val(cmbSSDelayTime.Text))
    End Sub

    Private Sub cmbSSDelayTime_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSDelayTime.Leave
        'save setting
        strSS(cmbSSsystem.SelectedIndex + 1, 2) = CStr(Val(cmbSSDelayTime.Text))

    End Sub


    'UPGRADE_WARNING: ComboBox event cmbSSHoldTime.Change was upgraded to cmbSSHoldTime.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
    Private Sub cmbSSHoldTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSHoldTime.TextChanged
        'save setting
        strSS(cmbSSsystem.SelectedIndex + 1, 4) = CStr(Val(cmbSSHoldTime.Text))
    End Sub

    Private Sub cmbSSHoldTime_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSHoldTime.Leave
        'save setting
        Call cmbSSHoldTime_TextChanged(cmbSSHoldTime, New System.EventArgs())
    End Sub


    'UPGRADE_WARNING: ComboBox event cmbSSQuickKey.Change was upgraded to cmbSSQuickKey.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
    Private Sub cmbSSQuickKey_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSQuickKey.TextChanged
        'save setting
        strSS(cmbSSsystem.SelectedIndex + 1, 5) = cmbSSQuickKey.Text
    End Sub

    Private Sub cmbSSQuickKey_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSQuickKey.Leave
        Call cmbSSQuickKey_TextChanged(cmbSSQuickKey, New System.EventArgs())
    End Sub

    Private Sub cmbSSStartupKey_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSStartupKey.TextChanged
        'save setting
        strSS(cmbSSsystem.SelectedIndex + 1, 6) = cmbSSStartupKey.Text
    End Sub

    Private Sub cmbSSStartupKey_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSStartupKey.Leave
        Call cmbSSStartupKey_TextChanged(cmbSSStartupKey, New System.EventArgs())
    End Sub


    Private Sub cmbSSsystem_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSsystem.TextChanged
        Call LoadServSearchFrame()
    End Sub


	Private Sub cmbSSsystem_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSsystem.SelectedIndexChanged
		Call LoadServSearchFrame()
	End Sub
	
	Private Sub cmbSSsystem_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSSsystem.Leave
		Call LoadServSearchFrame()
	End Sub
	
	'UPGRADE_ISSUE: ComboBox event cmbSSsystem.Scroll was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub cmbSSsystem_Scroll()
		Call LoadServSearchFrame()
	End Sub
	
	Private Sub cmbSSsystem_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles cmbSSsystem.Validating
		Dim Cancel As Boolean = eventArgs.Cancel
		Call LoadServSearchFrame()
		eventArgs.Cancel = Cancel
	End Sub
	
    Private Sub cmdAddLockoutFreq_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)


    End Sub
	
	Private Sub cmdApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdApply.Click
		SaveData()
		Me.Visible = False
        lblSiteNote.Visible = True
        lblSiteNote.Activate()

    End Sub

    Private Sub cmdBlank_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBlank.Click
        txtStartupMsg1.Text = ""
        txtStartUpMsg2.Text = ""
        txtStartUpMsg3.Text = ""
        txtStartUpMsg4.Text = ""

    End Sub

    Private Sub cmdCanuckKodes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCanuckKodes.Click
        Dim ShellCode As String
        ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", "http://ec.gc.ca/meteo-weather/default.asp?lang=En&n=1CD5BDF2-1", "", "", 1))
    End Sub

    Private Sub cmdClearLOFreq_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearLOFreq.Click
        Dim Response As Integer
        Response = MsgBox("Are you sure you want to delete all global LO frequencies?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Delete all?")
        Select Case Response
            Case 7
                'no
            Case 6
                'yes delete all
                grdFreqLO.Rows.Clear()

                grdFreqLO.RowCount = 1

        End Select
    End Sub



    Private Sub cmdCSDefault_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCSDefault.Click
        Dim x, Response As Integer


        Response = MsgBox("Are you sure you want to reset custom search bands to default?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Reset to default?")
        Select Case Response
            Case 6 'yes?
                'custom search
                For x = 1 To 10
                    CustSearch(x, 3) = CStr(0) ' search step=auto
                    CustSearch(x, 4) = "AUTO" ' auto modulation
                    CustSearch(x, 5) = CStr(0) ' attenuation off
                    CustSearch(x, 6) = CStr(2) 'search delay
                    CustSearch(x, 7) = CStr(1) 'data skip on\
                    CustSearch(x, 8) = CStr(1) 'turn on by default
                    CustSearch(x, 0) = "Custom " & x 'default name
                    CustSearch(x, 9) = CStr(0) 'hold time
                    CustSearch(x, 10) = CStr(0) 'c-ch only
                    CustSearch(x, 11) = "NONE"
                    CustSearch(x, 12) = "." 'QK
                    CustSearch(x, 13) = "." 'startup key
                    CustSearch(x, 14) = CStr(0) 'tape out
                    CustSearch(x, 15) = CStr(1) 'lockout
                Next x
                CustSearch(1, 1) = CStr(25.0#)
                CustSearch(1, 2) = CStr(27.995)
                CustSearch(2, 1) = CStr(28.0#)
                CustSearch(2, 2) = CStr(29.68)
                CustSearch(3, 1) = CStr(29.7)
                CustSearch(3, 2) = CStr(49.99)
                CustSearch(4, 1) = CStr(50.0#)
                CustSearch(4, 2) = CStr(54.0#)
                CustSearch(5, 1) = CStr(137.0#)
                CustSearch(5, 2) = CStr(143.9875)
                CustSearch(6, 1) = CStr(144.0#)
                CustSearch(6, 2) = CStr(147.995)
                CustSearch(7, 1) = CStr(406.0#)
                CustSearch(7, 2) = CStr(419.9875)
                CustSearch(8, 1) = CStr(420.0#)
                CustSearch(8, 2) = CStr(449.9875)
                CustSearch(9, 1) = CStr(450.0#)
                CustSearch(9, 2) = CStr(469.9875)
                CustSearch(10, 1) = CStr(806.0#)
                CustSearch(10, 2) = CStr(956.0#)
                LoadCustGrid()
            Case Else
                'user has made the safe choice
                'breath easy and do nothing
        End Select


    End Sub


    Private Sub cmdUSCodes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUSCodes.Click
        Dim ShellCode As String
        ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", "http://www.nws.noaa.gov/nwr/coverage/county_coverage.html", "", "", 1))
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Me.Visible = False
        lblSiteNote.Visible = True
        lblSiteNote.Activate()
    End Sub

    'UPGRADE_WARNING: Form event frmRadioPref246.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmRadioPref246_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated

    End Sub

    'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Form_Initialize_Renamed()
        Dim EndofList As Boolean
        Dim x As Single
        Dim cnt As Integer

        'initialize listboxes
        If grdCustSS.Items.Count = 0 Then
            For x = 0 To UBound(StepSize)
                grdCustSS.Items.Add((StepSize(x, 0)))
                cmbSSStep.Items.Add((StepSize(x, 0)))
            Next x

            With cmbCCPauseTime
                .Items.Add("-10")
                .Items.Add("-5")
                .Items.Add("-2")
                .Items.Add("0")
                .Items.Add("1")
                .Items.Add("2")
                .Items.Add(("3"))
                .Items.Add("4")
                .Items.Add(("5"))
                .Items.Add(("10"))
                .Items.Add(("15"))
                .Items.Add(("30"))
                .Items.Add(("45"))
                .Items.Add(("60"))
                '.Items.Add(("INF")) 'does not appear valid

            End With
            cmbGPSTimeZone.Items.Clear()
            For x = 0 To 1000 Step 100
                grdCustP25Wait.Items.Add(CStr(x))
            Next
            For x = -14 To 14 Step 0.5
                cmbGPSTimeZone.Items.Add(CStr(x))

            Next x
            'quick key for 0-99 plus none
            cmbCCQuickKey.Items.Add(("."))
            grdCustQK.Items.Add(("."))
            cmbSSQuickKey.Items.Add(("."))
            For x = 0 To 99
                cmbCCQuickKey.Items.Add(CStr(x))
                grdCustQK.Items.Add(CStr(x))
                cmbSSQuickKey.Items.Add(CStr(x))
            Next x
            grdCustStartupKey.Items.Add(("."))
            cmbSSStartupKey.Items.Add(("."))
            'cc alert beep & startup configuration key
            cmbTonAltTone.Items.Clear()

            For x = 0 To 9
                cmbCloseCallAlertType.Items.Add(CStr(x))
                grdCustStartupKey.Items.Add(CStr(x))
                cmbSSStartupKey.Items.Add(CStr(x))
                cmbTonAltTone.Items.Add(CStr(x))
            Next x
            'tone out alert level
            cmbTonAltToneLevel.Items.Clear()
            For x = 0 To 15
                cmbTonAltToneLevel.Items.Add(CStr(x))
            Next x

            'standard delay time 0-5

            cmbTonDelay.Items.Clear()

            With grdCustDelay.Items
                .Add("-10")
                .Add("-5")
                .Add("-2")
            End With
            With cmbSSDelayTime.Items
                .Add("-10")
                .Add("-5")
                .Add("-2")
            End With
            With cmbSSDelay.Items
                .Add("-10")
                .Add("-5")
                .Add("-2")
            End With
            For x = 0 To 5
                grdCustDelay.Items.Add(CStr(x))
                cmbSSDelayTime.Items.Add(CStr(x))
                cmbSSDelay.Items.Add(CStr(x))
                cmbWXDelay.Items.Add(CStr(x))

                cmbTonDelay.Items.Add(CStr(x))

            Next x
            With grdCustDelay.Items
                .Add("10")
                .Add("30")
            End With
            With cmbSSDelayTime.Items
                .Add("10")
                .Add("30")
            End With
            With cmbSSDelay.Items
                .Add("10")
                .Add("30")
            End With
            'tone out delay


            With cmbTonDelay
                .Items.Add(("10"))
                .Items.Add(("30"))
                .Items.Add(("INF"))
            End With


            'tone out colours
            With cmbTonAlertColor
                .Items.Add(("Off"))
                .Items.Add(("Blue"))
                .Items.Add(("Red"))
                .Items.Add(("Magenta"))
                .Items.Add(("Green"))
                .Items.Add(("Cyan"))
                .Items.Add(("Yellow"))
                .Items.Add(("White"))
            End With
            'close call combo boxes
            With cmbCCAltCol.Items
                .Add(("Off"))
                .Add(("Blue"))
                .Add(("Red"))
                .Add(("Magenta"))
                .Add(("Green"))
                .Add(("Cyan"))
                .Add(("Yellow"))
                .Add(("White"))
            End With
            With cmbCCAltPat.Items

                .Add("On")
                .Add("Slow")
                .Add("Fast")
            End With

            'Tone out flash pattern
            With cmbAlertFlash
                .Items.Add(("On"))
                .Items.Add(("Slow"))
                .Items.Add(("Fast"))
            End With
            With cmbTonMod
                .Items.Clear()
                .Items.Add("AUTO")
                .Items.Add("FM")
                .Items.Add("NFM")
            End With
            'hold time 0-255 & max auto store
            For x = 0 To 255
                grdCustHoldTime.Items.Add(CStr(x))
                cmbSSHoldTime.Items.Add(CStr(x))
                cmbSSHold.Items.Add(CStr(x))
                cmbMaxAutoStore.Items.Add(CStr(x))
            Next x
            'priority
            For x = 1 To 100
                MaxPriChan.Items.Add(x)
            Next
            For x = 1 To 10
                PriIntTime.Items.Add(x)
            Next
            'custom service search
            Dim cmbSearchKey(5) As ComboBox
            cmbSearchKey(0) = _cmbSearchKey_0
            cmbSearchKey(1) = _cmbSearchKey_1
            cmbSearchKey(2) = _cmbSearchKey_2
            cmbSearchKey(3) = _cmbSearchKey_3
            cmbSearchKey(4) = _cmbSearchKey_4
            cmbSearchKey(5) = _cmbSearchKey_5
            For x = 0 To 25
                For cnt = 0 To 5
                    cmbSearchKey(cnt).Items.Add((strServiceSearch(x)))
                Next cnt
            Next x
            'service search settings
            For x = 1 To 13
                cmbSSsystem.Items.Add((strSS(x, 1)))
            Next x
            EndofList = False : x = 0
            Do Until EndofList = True
                grdCustModulation.Items.Add((ModMode(x)))
                cmbSSModMode.Items.Add((ModMode(x)))
                x = x + 1
                If Len(ModMode(x)) = 0 Then EndofList = True
            Loop

        End If
        'gps time zone
        For x = -14 To 14
            cmbGPSTimeZone.Items.Add(CStr(Val(CStr(x))))
        Next x
        'agc advanced settings
        Dim CMBAGC(5) As ComboBox
        CMBAGC(0) = _cmbAGC_0
        CMBAGC(1) = _cmbAGC_1
        CMBAGC(2) = _cmbAGC_2
        CMBAGC(3) = _cmbAGC_3
        CMBAGC(4) = _cmbAGC_4
        CMBAGC(5) = _cmbAGC_5
        For x = -4 To 6
            cmbAGC(0).Items.Add(CStr(x))
        Next x
        For x = -5 To 5
            cmbAGC(1).Items.Add(CStr(x))
            cmbAGC(4).Items.Add(CStr(x))
        Next x
        For x = 0 To 15
            cmbAGC(2).Items.Add(CStr(x))
        Next x
        For x = -8 To 8
            cmbAGC(3).Items.Add(CStr(x))
        Next x
        For x = 0 To 6
            cmbAGC(5).Items.Add(CStr(x))
        Next x
        'p25 wait time
        For x = 0 To 1000 Step 100
            cmbP25Wait.Items.Add(CStr(x))
            cmbSSPP25Wait.Items.Add(CStr(x))
        Next x
        With cmbBatChg
            .Items.Clear()
            For x = 1 To 16
                .Items.Add(x)
            Next
        End With

        'Default state
        With cmbState
            .Items.Clear()
            For x = 1 To 67
                .Items.Add(varState(x, 1))
            Next
            .SelectedIndex = 0
        End With
    End Sub


    Sub SaveData()
        Dim optbacklight1(10) As RadioButton
        optbacklight1(0) = _optBackLight1_0
        optbacklight1(1) = _optBackLight1_1
        optbacklight1(2) = _optBackLight1_2
        optbacklight1(3) = _optBackLight1_3
        optbacklight1(4) = _optBackLight1_4
        optbacklight1(5) = _optBackLight1_5
        optbacklight1(6) = _optBackLight1_6
        optbacklight1(7) = _optBackLight1_7
        optbacklight1(8) = _optBackLight1_8
        optbacklight1(9) = _optBackLight1_9
        optbacklight1(10) = _optBackLight1_10

        Dim cmbAGc(5) As ComboBox
        cmbAGc(0) = _cmbAGC_0
        cmbAGc(1) = _cmbAGC_1
        cmbAGc(2) = _cmbAGC_2
        cmbAGc(3) = _cmbAGC_3
        cmbAGc(4) = _cmbAGC_4
        cmbAGc(5) = _cmbAGC_5
        Dim optprimode(2) As RadioButton
        optprimode(0) = _optPriMode_0
        optprimode(1) = _optPriMode_1
        optprimode(2) = _optPriMode_2
        Dim optGPSDispMode(4) As RadioButton
        optGPSDispMode(0) = _optGPSDispMode_0
        optGPSDispMode(1) = _optGPSDispMode_1
        optGPSDispMode(2) = _optGPSDispMode_2
        optGPSDispMode(3) = _optGPSDispMode_3
        optGPSDispMode(4) = _optGPSDispMode_4

        Dim optCCMode(2) As RadioButton

        optCCMode(0) = _optCCMode_0
        optCCMode(1) = _optCCMode_1
        optCCMode(2) = _optCCMode_2

        Dim chkCCBand(6) As CheckBox
        chkCCBand(0) = _chkCCBand_0
        chkCCBand(1) = _chkCCBand_1
        chkCCBand(2) = _chkCCBand_2
        chkCCBand(3) = _chkCCBand_3
        chkCCBand(4) = _chkCCBand_4
        chkCCBand(5) = _chkCCBand_5
        chkCCBand(6) = _chkCCBand_6
        Dim optalertmode(3) As RadioButton
        optalertmode(0) = _optAlertMode_0
        optalertmode(1) = _optAlertMode_1
        optalertmode(2) = _optAlertMode_2
        optalertmode(3) = _optAlertMode_3

        Dim cmbSearchKey(5) As ComboBox
        cmbSearchKey(0) = _cmbSearchKey_0
        cmbSearchKey(1) = _cmbSearchKey_1
        cmbSearchKey(2) = _cmbSearchKey_2
        cmbSearchKey(3) = _cmbSearchKey_3
        cmbSearchKey(4) = _cmbSearchKey_4
        cmbSearchKey(5) = _cmbSearchKey_5

        Dim chkbsc(15) As CheckBox
        chkbsc(0) = _chkBSC_0
        chkbsc(1) = _chkBSC_1
        chkbsc(2) = _chkBSC_2
        chkbsc(3) = _chkBSC_3
        chkbsc(4) = _chkBSC_4
        chkbsc(5) = _chkBSC_5
        chkbsc(6) = _chkBSC_6
        chkbsc(7) = _chkBSC_7
        chkbsc(8) = _chkBSC_8
        chkbsc(9) = _chkBSC_9
        chkbsc(10) = _chkBSC_10
        chkbsc(11) = _chkBSC_11
        chkbsc(12) = _chkBSC_12
        chkbsc(13) = _chkBSC_13
        chkbsc(14) = _chkBSC_14
        chkbsc(15) = _chkBSC_15
        Dim txtBBS(19) As TextBox
        txtBBS(0) = _txtBBS_0
        txtBBS(1) = _txtBBS_1
        txtBBS(2) = _txtBBS_2
        txtBBS(3) = _txtBBS_3
        txtBBS(4) = _txtBBS_4
        txtBBS(5) = _txtBBS_5
        txtBBS(6) = _txtBBS_6
        txtBBS(7) = _txtBBS_7
        txtBBS(8) = _txtBBS_8
        txtBBS(9) = _txtBBS_9
        txtBBS(10) = _txtBBS_10
        txtBBS(11) = _txtBBS_11
        txtBBS(12) = _txtBBS_12
        txtBBS(13) = _txtBBS_13
        txtBBS(14) = _txtBBS_14
        txtBBS(15) = _txtBBS_15
        txtBBS(16) = _txtBBS_16
        txtBBS(17) = _txtBBS_17
        txtBBS(18) = _txtBBS_18
        txtBBS(19) = _txtBBS_19
        Dim txtwx(45) As TextBox
        txtwx(0) = _txtWX_0
        txtwx(1) = _txtWX_1
        txtwx(2) = _txtWX_2
        txtwx(3) = _txtWX_3
        txtwx(4) = _txtWX_4
        txtwx(5) = _txtWX_5
        txtwx(6) = _txtWX_6
        txtwx(7) = _txtWX_7
        txtwx(8) = _txtWX_8
        txtwx(9) = _txtWX_9
        txtwx(10) = _txtWX_10
        txtwx(11) = _txtWX_11
        txtwx(12) = _txtWX_12
        txtwx(13) = _txtWX_13
        txtwx(14) = _txtWX_14
        txtwx(15) = _txtWX_15
        txtwx(16) = _txtWX_16
        txtwx(17) = _txtWX_17
        txtwx(18) = _txtWX_18
        txtwx(19) = _txtWX_19
        txtwx(20) = _txtWX_20
        txtwx(21) = _txtWX_21
        txtwx(22) = _txtWX_22
        txtwx(23) = _txtWX_23
        txtwx(24) = _txtWX_24
        txtwx(25) = _txtWX_25
        txtwx(26) = _txtWX_26
        txtwx(27) = _txtWX_27
        txtwx(28) = _txtWX_28
        txtwx(29) = _txtWX_29

        txtwx(30) = _txtWX_30
        txtwx(31) = _txtWX_31
        txtwx(32) = _txtWX_32
        txtwx(33) = _txtWX_33
        txtwx(34) = _txtWX_34
        txtwx(35) = _txtWX_35
        txtwx(36) = _txtWX_36
        txtwx(37) = _txtWX_37
        txtwx(38) = _txtWX_38
        txtwx(39) = _txtWX_39
        txtwx(40) = _txtWX_40
        txtwx(41) = _txtWX_41
        txtwx(42) = _txtWX_42
        txtwx(43) = _txtWX_43
        txtwx(44) = _txtWX_44
        Dim chkWX(3) As CheckBox
        chkWX(0) = _chkWX_0
        chkWX(1) = _chkWX_1
        chkWX(2) = _chkWX_2
        If blnDebug = False Then On Error GoTo criticerror
        Dim var As String, cnt, cnt1 As Integer
        Dim strBuff(45) As String
        Dim strBuff1(9) As String
        'do the exact opposite of loaddata
        var = "0"
        For cnt = 0 To 5
            If optBackLight1(cnt).Checked = True Then
                var = cnt
            End If
        Next cnt
        'general setting
        Select Case var
            Case 1
                RadioSetting(1) = "LOW"
            Case 2
                RadioSetting(1) = "MIDL"
            Case 3
                RadioSetting(1) = "HIGH"
            Case 4
                RadioSetting(1) = "+POL"
            Case 5
                RadioSetting(1) = "-POL"
            Case Else
                RadioSetting(1) = "OFF"
        End Select
        'keylock/keysafe
        RadioSetting(104) = CStr(chkXTKeyLock.CheckState)
        RadioSetting(105) = CStr(chkXTKeySafe.CheckState)
        'battery save
        RadioSetting(86) = CStr(chkBatSave.CheckState)

        If optBackLight1(6).Checked Then
            RadioSetting(85) = "IF"
        ElseIf optBackLight1(7).Checked Then
            RadioSetting(85) = "10"
        ElseIf optBackLight1(8).Checked Then
            RadioSetting(85) = "30"
        ElseIf optBackLight1(9).Checked Then
            RadioSetting(85) = "KY"

        Else
            RadioSetting(85) = "SQ"
        End If
        'backlight colour
        If optBacklightGreen.Checked Then
            RadioSetting(2) = "GREEN"
        ElseIf optBacklightBlue.Checked Then
            RadioSetting(2) = "BLUE"
        ElseIf optBacklightRed.Checked Then
            RadioSetting(2) = "RED"
        ElseIf optBacklightMagenta.Checked Then
            RadioSetting(2) = "MAGENTA"
        ElseIf optBacklightCyan.Checked Then
            RadioSetting(2) = "CYAN"
        ElseIf optBacklightYellow.Checked Then
            RadioSetting(2) = "YELLOW"
        ElseIf optBacklightWhite.Checked Then
            RadioSetting(2) = "WHITE"
        End If
        'default state
        RadioSetting(109) = CStr(cmbState.SelectedIndex + 1)
        'backlight brightness (XT)
        RadioSetting(95) = sldXTBright.Value
        'xt control channel logging
        If optXTChanLog0.Checked Then
            RadioSetting(96) = "0"
        ElseIf optXTChanLog1.Checked Then
            RadioSetting(96) = "1"
        Else
            RadioSetting(96) = "2"
        End If
        'xt p25 lowpass
        RadioSetting(106) = MakeBinary(chkXTP25LP.CheckState)
        'xt global att
        RadioSetting(97) = MakeBinary(chkXTGlobalAtt.CheckState)
        'xt bat chg time
        RadioSetting(107) = cmbBatChg.Text
        'keysafe/lock
        RadioSetting(105) = MakeBinary(chkXTKeySafe.CheckState)
        RadioSetting(104) = MakeBinary(chkXTKeyLock.CheckState)
        'lcd settings

        If optMode1.Checked Then
            RadioSetting(28) = CStr(1)
        ElseIf optMode2.Checked Then
            RadioSetting(28) = CStr(2)
        Else
            RadioSetting(28) = "3"
        End If
        'xt unit id
        RadioSetting(108) = chkUnitID.CheckState

        RadioSetting(30) = MakeBinary((chkActChanDisp.CheckState))

        RadioSetting(31) = MakeBinary((chkLCDFlip.CheckState))

        RadioSetting(29) = MakeBinary((sldLCDContrast.Value))
        'startup msg

        RadioSetting(5) = MakeItKosher((txtStartupMsg1.Text))
        RadioSetting(6) = MakeItKosher((txtStartUpMsg2.Text))
        RadioSetting(22) = MakeItKosher((txtStartUpMsg3.Text))
        RadioSetting(23) = MakeItKosher((txtStartUpMsg4.Text))
        Select Case sldKeyBeep.Value
            Case 16
                RadioSetting(4) = CStr(99)
            Case Else
                RadioSetting(4) = CStr(Val(CStr(sldKeyBeep.Value)))
        End Select
        RadioSetting(25) = MakeBinary((chkAnalogAGC.CheckState))
        RadioSetting(26) = MakeBinary((chkDigitalAGC.CheckState))
        System.Array.Clear(strBuff, 0, strBuff.Length)
        For cnt = 0 To 5
            strBuff(0) = strBuff(0) & cmbAGC(cnt).Text
            If cnt <> 5 Then
                strBuff(0) = strBuff(0) & ","
            End If
        Next cnt

        RadioSetting(87) = strBuff(0)
        'p25 wait time
        RadioSetting(88) = cmbP25Wait.Text
        'priority mode
        If optPriMode(0).Checked = True Then RadioSetting(3) = CStr(0)
        If optPriMode(1).Checked = True Then RadioSetting(3) = CStr(1)
        If optPriMode(2).Checked = True Then RadioSetting(3) = CStr(2)
        RadioSetting(89) = MaxPriChan.Text
        RadioSetting(93) = PriIntTime.Text

        If optCCMode(0).Checked = True Then RadioSetting(7) = CStr(0)
        If optCCMode(1).Checked = True Then RadioSetting(7) = CStr(1)
        If optCCMode(2).Checked = True Then RadioSetting(7) = CStr(2)


        'close call setting
        'xt alert pat and light
        RadioSetting(99) = UCase(cmbCCAltCol.Text)
        Select Case cmbCCAltPat.Text
            Case "On"
                RadioSetting(100) = "0"
            Case "Slow"
                RadioSetting(100) = "1"
            Case "Fast"
                RadioSetting(100) = "2"
        End Select

        'gps setting
        For cnt = 0 To 5 'display mode
            If optGPSDispMode(cnt).Checked = True Then
                RadioSetting(46) = cnt
                cnt = 5
            End If
        Next cnt
        RadioSetting(47) = MakeBinary((chkGPSKM.CheckState)) 'use metric measurement
        RadioSetting(48) = MakeBinary((chkGPSTimeFormat.CheckState)) ' use 24 hour format
        ' use DMS format
        If chkGPSDMS.Checked Then
            RadioSetting(49) = "DMS"
        Else
            RadioSetting(49) = "DEG"
        End If
        RadioSetting(50) = cmbGPSTimeZone.Text 'time zone
        'alert mode
        If optAlertMode(0).Checked = True Then RadioSetting(27) = "N"
        If optAlertMode(1).Checked = True Then RadioSetting(27) = "B"
        If optAlertMode(2).Checked = True Then RadioSetting(27) = "L"
        If optAlertMode(3).Checked = True Then RadioSetting(27) = "A"


        'close call bands
        RadioSetting(14) = ""
        For cnt = 0 To 6

            RadioSetting(14) = RadioSetting(14) & MakeBinary(chkCCBand(cnt).CheckState)
        Next cnt

        'cc alert
        RadioSetting(13) = cmbCloseCallAlertType.Text
        RadioSetting(15) = CStr(sldCCVol.Value)

        'cc general options
        RadioSetting(11) = cmbCCPauseTime.Text
        RadioSetting(32) = cmbMaxAutoStore.Text
        RadioSetting(9) = cmbCCQuickKey.Text
        RadioSetting(8) = chkCloseCallOverride.CheckState
        RadioSetting(10) = MakeBinary((chkCCHits.CheckState))
        If optCCCodeSearch0.Checked Then
            RadioSetting(24) = "0"
        ElseIf optCCCodeSearch1.Checked Then
            RadioSetting(24) = "1"
        Else
            RadioSetting(24) = "2"
        End If
        RadioSetting(101) = CStr(chkCCAGCA.CheckState)
        RadioSetting(102) = CStr(chkCCAGCD.CheckState)

        'save global IF exchange grid
        SaveGrdGlobalIFEX()
        'frequency lockouts
        'first clear existing list in memory

        Call SavegrdFreqLO()


        'search key
        For cnt = 0 To 5

            RadioSetting(34 + cnt) = cmbSearchKey(cnt).Text
        Next cnt

        'searching tab
        RadioSetting(17) = MakeItKosherSearchStep((cmbSSStep.Text))

        RadioSetting(17) = MakeItKosherSearchStep((cmbSSStep.Text))
        RadioSetting(18) = cmbSSModMode.Text 'look ma no input checking
        RadioSetting(21) = cmbSSDelay.Text
        ' RadioSetting(24) = cmbSSHold.Text 'this is stored in strSS
        RadioSetting(32) = cmbMaxAutoStore.Text
        RadioSetting(33) = MakeBinary((chkSSAtt.CheckState))
        RadioSetting(40) = MakeBinary((chkSSDataSkip.CheckState))
        RadioSetting(41) = MakeBinary((chkSSRepeater.CheckState))
        RadioSetting(42) = MakeBinary((chkCCTapeOut.CheckState))
        'broadcast screen settings
        RadioSetting(43) = ""
        For cnt = 0 To 15
            RadioSetting(43) = RadioSetting(43) & MakeBinary(chkBSC(cnt).CheckState)
        Next cnt
        For cnt = 0 To 19
            RadioSetting(51 + cnt) = MakeItKosherFrequency(txtBBS(cnt).Text)
        Next cnt

        'lcd contrast
        RadioSetting(29) = CStr(sldLCDContrast.Value)
        'custom search settings
        Call SaveCustGrid()
        'weather alert
        'checkboxes

        For cnt = 0 To 2
            strBuff(cnt) = chkWX(cnt).CheckState
        Next cnt
        RadioSetting(71) = Join(strBuff, Chr(9))
        System.Array.Clear(strBuff, 0, strBuff.Length)
        'text boxes
        For cnt = 0 To 44
            If cnt = 0 Or cnt = 9 Or cnt = 18 Or cnt = 27 Or cnt = 36 Then
                strBuff(cnt) = MakeItKosher(txtWX(cnt).Text)
            Else
                If Len(txtWX(cnt).Text) > 0 And IsNumeric(txtWX(cnt).Text) = True Then
                    strBuff(cnt) = Format(Val(txtwx(cnt).Text), "000000")
                Else
                    strBuff(cnt) = "------"
                End If
            End If
        Next cnt
        RadioSetting(72) = Join(strBuff, Chr(9))
        'delay
        RadioSetting(73) = CStr(cmbWXDelay.SelectedIndex)
        '***************************fire tone out
        'name

        System.Array.Clear(strBuff, 0, strBuff.Length)

        For cnt = 0 To 9
            strBuff(cnt) = MakeItKosher(grdToneOut(0, cnt).Value)
        Next cnt
        RadioSetting(74) = Join(strBuff, Chr(9))
        'base freqs

        System.Array.Clear(strBuff, 0, strBuff.Length)
        For cnt = 0 To 9
            strBuff(cnt) = MakeItKosherFreqSilent(grdToneOut(1, cnt).Value)
        Next cnt
        RadioSetting(75) = Join(strBuff, Chr(9))
        'tone frequencies

        System.Array.Clear(strBuff, 0, strBuff.Length)

        cnt1 = 0
        'tone values and modulation
        RadioSetting(76) = Nothing
        RadioSetting(81) = Nothing
        RadioSetting(82) = Nothing
        RadioSetting(92) = Nothing ' agc on off
        For cnt = 0 To 9
            RadioSetting(76) &= grdToneOut(2, cnt).Value & Chr(9) & grdToneOut(3, cnt).Value & Chr(9)
            RadioSetting(81) &= grdToneOut(5, cnt).Value
            RadioSetting(82) &= grdToneOut(10, cnt).Value
            RadioSetting(92) &= grdToneOut(11, cnt).Value
            If cnt <> 9 Then
                RadioSetting(81) &= ","
                RadioSetting(82) &= ","
                RadioSetting(92) &= ","
            End If
        Next cnt

        'alert type
        System.Array.Clear(strBuff, 0, strBuff.Length)


        For cnt = 0 To 9
            strBuff(cnt) = grdToneOut(6, cnt).Value
        Next cnt
        RadioSetting(77) = Join(strBuff, Chr(9))

        'alert level

        System.Array.Clear(strBuff, 0, strBuff.Length)
        For cnt = 0 To 9
            strBuff(cnt) = grdToneOut(7, cnt).Value
        Next cnt
        RadioSetting(78) = Join(strBuff, Chr(9))

        'delay time

        System.Array.Clear(strBuff, 0, strBuff.Length)
        For cnt = 0 To 9
            strBuff(cnt) = grdToneOut(4, cnt).Value
        Next cnt
        RadioSetting(79) = Join(strBuff, Chr(9))

        'record on off

        System.Array.Clear(strBuff, 0, strBuff.Length)
        For cnt = 0 To 9
            strBuff(cnt) = MakeBinary(grdToneOut(12, cnt).Value)
        Next cnt
        RadioSetting(80) = Join(strBuff, Chr(9))
        'alert light colour

        System.Array.Clear(strBuff1, 0, strBuff1.Length)
        For cnt = 0 To 9
            strBuff1(cnt) = UCase(grdToneOut(8, cnt).Value)
        Next cnt
        RadioSetting(90) = Join(strBuff1, ",")
        'alert light pattern

        System.Array.Clear(strBuff1, 0, strBuff1.Length)
        For cnt = 0 To 9
            Select Case grdToneOut(9, cnt).Value
                Case "On" 'on
                    strBuff1(cnt) = "0"
                Case "Slow" 'slow
                    strBuff1(cnt) = "1"
                Case Else 'fast
                    strBuff1(cnt) = "2"
            End Select
        Next cnt
        RadioSetting(91) = Join(strBuff1, ",")
        blnChgSaved = False
        Exit Sub

criticerror:
        MsgBox("Error trying to save settings. Error code " & Err.Number)
        Resume Next

    End Sub



    Private Sub grdFreqLO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFreqLO.CellContentClick

    End Sub
    Sub LoadgrdFreqLO()
        'loads all the locked out frequencies to the grid for editing
        If blnDebug = False Then On Error Resume Next
        Dim intRow, intRowCnt As Integer
        intRowCnt = 0
        With grdFreqLO
            .Rows.Clear()
            .RowCount = 1
            For intRow = 1 To UBound(strSearchLockout)
                If Val(strSearchLockout(intRow)) > 0 Then
                    intRowCnt += 1
                End If
            Next
            If intRowCnt > 0 Then

            End If
            .RowCount = intRowCnt + 1
            intRowCnt = 0
            For intRow = 1 To UBound(strSearchLockout)

                If Val(strSearchLockout(intRow)) > 0 Then
                    grdFreqLO(0, intRowCnt).Value = FormatFreq(strSearchLockout(intRow))
                    intRowCnt += 1
                End If
            Next
        End With
    End Sub
    Sub SavegrdFreqLO()
        'saves all the frequency in the grid to memory
        If blnDebug = False Then On Error Resume Next
        Dim intRow As Integer
        Dim dblFreq As Double
        Dim strBuff As String
        System.Array.Clear(strSearchLockout, 0, strSearchLockout.Length)
        Dim intRowCnt As Integer = 0
        For intRow = 1 To grdFreqLO.RowCount
            strBuff = grdFreqLO(0, intRow - 1).Value
            dblFreq = Val(strBuff)
            If dblFreq > 0 Then
                strBuff = MakeItKosherFreqSilent(strBuff)
                intRowCnt += 1
                strSearchLockout(intRowCnt) = strBuff
            End If
        Next
        strSearchLockout(0) = CStr(intRowCnt)
    End Sub

    Sub SaveGrdGlobalIFEX()
        'saves all the frequency in the global if exchange grid to memory
        If blnDebug = False Then On Error Resume Next
        Dim intRow As Integer
        Dim dblFreq As Double
        Dim strBuff As String
        Dim intRowCnt As Integer = 0
        If IsArray(strIFEX) Then System.Array.Clear(strIFEX, 0, strIFEX.Length)
        ReDim strIFEX(grdGIF.RowCount)
        For intRow = 0 To grdGIF.RowCount - 1
            strBuff = grdGIF(0, intRow).Value
            dblFreq = Val(strBuff)
            If dblFreq > 0 Then
                strBuff = MakeItKosherFreqSilent(strBuff)
                intRowCnt += 1
                strIFEX(intRowCnt) = strBuff
            End If
        Next

    End Sub

    Private Sub grdFreqLO_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFreqLO.CellEndEdit
        Dim strFreq As String
        Try
            strFreq = grdFreqLO.CurrentCell.Value
            strFreq = MakeItKosherFrequency(strFreq)
            grdFreqLO.CurrentCell.Value = strFreq
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim intMde As Boolean
        intMde = CheckBox1.Checked
        SaveSetting("FreeSCAN", "Settings", "CustAdv", intMde)
        grdCustAGCA.Visible = intMde
        grdCustAGCD.Visible = intMde
        grdCustP25Wait.Visible = intMde
        grdCustTapeOut.Visible = intMde
        grdCustCtlChn.Visible = intMde
        grdCustStartupKey.Visible = intMde
        grdCustEnabled.Visible = intMde


    End Sub

    Private Sub frmRadioPref246_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call CheckBox1_CheckedChanged(Nothing, Nothing) 'SETS up simple mode view for custom search setting

    End Sub

    Private Sub cmdClearGIF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearGIF.Click
        Dim Response As Integer
        Response = MsgBox("Are you sure you want to delete all global IF Exchange frequencies?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Delete all?")
        Select Case Response
            Case 7
                'no
            Case 6
                'yes delete all
                grdGIF.Rows.Clear()
                grdGIF.RowCount = 1
        End Select
    End Sub

    Private Sub chkSSPAnalogAGC_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSSPAnalogAGC.CheckStateChanged
        strSSXT(cmbSSsystem.SelectedIndex + 1, 1) = MakeBinary((chkSSPAnalogAGC.CheckState))
    End Sub

    Private Sub chkSSPDigitalAGC_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSSPDigitalAGC.CheckStateChanged
        strSSXT(cmbSSsystem.SelectedIndex + 1, 2) = MakeBinary((chkSSPDigitalAGC.CheckState))
    End Sub

    Private Sub cmbP25Wait_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbP25Wait.DropDownClosed
        strSSXT(cmbSSsystem.SelectedIndex + 1, 3) = cmbP25Wait.Text
    End Sub

    Private Sub txtSSPNumTag_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSPNumTag.TextChanged
        strSSXT(cmbSSsystem.SelectedIndex + 1, 4) = MakeItKosherNumTag(txtSSPNumTag.Text)
    End Sub

   
End Class