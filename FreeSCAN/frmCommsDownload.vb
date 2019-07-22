Option Strict Off
Option Explicit On
Friend Class frmCommsDownload
	Inherits System.Windows.Forms.Form
	Dim oktogo As Boolean
	Dim intTx, intRx As Single
    Dim blnQueue, blnNagged As Boolean
    Dim bAbortPressed As Boolean = False
	Sub CommonAGC(ByRef strCMD As String)
		'gets advanced AGC setttings
		If blnDebug = False Then On Error Resume Next
		Dim strBuff() As String
		Dim strBuff1, Response As String
		
		Response = SendCMD(strCMD)
		strBuff = Split(Response, ",")
		
		If UBound(strBuff) = 5 Then 'downloaded properly
			RadioSetting(87) = Response
		End If
		
		'get P25 wait time, if possible
		
		Response = SendCMD("PWT")
		If IsNumeric(Response) = True Then
			RadioSetting(88) = CStr(Val(Response))
		Else
			RadioSetting(88) = CStr(0)
		End If
	End Sub
	
	
	Sub DownloadMCP(ByRef intSys As Integer, ByRef intSite As Integer, ByRef intIndex As Integer)
		'Downloads the MCP band plan
		Dim Response, strBuff As String
		Dim intCnt As Integer
		Dim strMcp() As String
		If blnDebug = False Then On Error Resume Next
		strbuff=""

		Response = SendCMD("MCP," & intIndex)
		If Response = "ERR" Then Exit Sub
		strMcp = Split(Response, ",")
		If UBound(strMcp) <> 23 Then
			sngErr = sngErr + 1
			GenLog(("Can't download Motorola Custom Band Plan, error"))
			Exit Sub
		End If
		For intCnt = 0 To 23
			strBuff = strBuff & strMcp(intCnt)
			If intCnt <> 23 And intCnt <> 3 And intCnt <> 7 And intCnt <> 11 And intCnt <> 15 And intCnt <> 19 Then
				strBuff = strBuff & ","
			ElseIf intCnt <> 23 Then 
				strBuff = strBuff & "@"
			End If
		Next intCnt
		varSite(intSys, intSite, 0, 62) = strBuff
	End Sub
	Sub LoadPrefs()
		
		If blnDebug = False Then On Error Resume Next
		Dim strPrefs() As String
		Dim x As String
		x = GetSetting("FreeSCAN", "Settings", "DownloadPref", "")
		strPrefs = Split(x, ",")
		If UBound(strPrefs) = 5 Then
            'chkClearMemory.CheckState = CShort(strPrefs(0))
			chkResume.CheckState = CShort(strPrefs(1))
			chkSysQK.CheckState = CShort(strPrefs(2))
			chkDownloadCustomSearch.CheckState = CShort(strPrefs(3))
        End If
        chkClearMemory.CheckState = False
        x = GetSetting("FreeSCAN", "Settings", "SortDL", "1")
        If x = "0" Then
            AutoSortSystemListToolStripMenuItem.Checked = False
        Else
            AutoSortSystemListToolStripMenuItem.Checked = True

        End If
	End Sub
	Sub SavePrefs()
		Dim strArray, C As String
		'build the array
		C = ","
		strArray = chkClearMemory.CheckState & C & chkResume.CheckState & C & chkSysQK.CheckState & C & chkDownloadCustomSearch.CheckState & C
        strArray = strArray & "0" & C & "0"
		SaveSetting("FreeSCAN", "Settings", "DownloadPref", strArray)
	End Sub
	Sub CheckResume()
		Dim Response As String
		'automatically resume scanning
		If chkResume.CheckState = 1 Then
			
			Response = SendCMD("KEY,S,P")
		End If
	End Sub
	Sub DownloadQSL()
		'downloads QSL settings from the 396/15/996
		If blnDebug = False Then On Error Resume Next
		Dim strBuff, strBuff1 As String
		Dim cnt, cnt1 As Integer
        Dim strbuff3 As String
		strbuff1=""
		strBuff = SendCMD("QSL")
		If Len(strBuff) = 109 Then
			'encode it onto the radiosetting(12)
			For cnt = 1 To 109
				
				strbuff3 = Mid(strBuff, cnt, 1)
				
				If strbuff3 = "1" Or strbuff3 = "2" Then
					
					strBuff1 = strBuff1 & strbuff3
					
				ElseIf strbuff3 = "0" Then 
					strBuff1 = strBuff1 & "2"
				End If
			Next cnt
			cnt = Len(strBuff)
			RadioSetting(12) = strBuff1
		Else
			'insert default string
			RadioSetting(12) = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111"
		End If
	End Sub
    Sub Download396(ByVal strMDL As String)
        If blnDebug = False Then On Error GoTo criticerror
        Dim strCMD(5) As String
        Dim strName, Response As String
        Dim strChanName, strQK, strModMode As String
        Dim intIndex, intGroup, intGroupIndex As Integer
        Dim intToneLock, intSystem, intChannelIndex As Integer
        Dim intChan As Single
        Dim intTrunkIndex As Single
        Dim strABP As String
        Dim intABP As Integer
        Dim ResponseCode, strQGL As String
        Dim blnDone As Boolean
        Dim cnt As Integer
        Dim strBuff As String

        Dim strCustFleetMap As String
        Dim strSysType As String
        Dim x, intSeqIndex, intList As Integer
        Dim strGroup As String
        Dim intSin As Integer
        Dim strSIN, CResponseCode As String
        Dim blnLastGroup As Boolean
        Dim intChannel As Single
        Dim blnLastChan As Boolean
        Dim strChan, strTrunk As String
        Dim intTGIDGroupIndex, intSiteLimit As Integer
        Dim strCustSearchEnable, strSIF As String
        Dim blnLastSite As Boolean
        Dim intSiteIndex, intSite, intSysNum As Integer
        Dim strMBP As String
        Dim intCurrTrn As Integer
        Dim blnNoMoreMem As Boolean
        Dim bln230, blnBR330T, Bln246, Bln396 As Boolean

        strQGL = Nothing
        strSIF = Nothing
        strLog = ""
        intChannelsFound = 0
        intGroupsFound = 0
        sngErr = 0
        blnBR330T = False
        Bln246 = False
        Bln396 = False
        'load programming from radio

        Common_CheckQueue() 'checks to make sure the user queued systems first
        'should we erase everything in memory before downloading?
        If chkClearMemory.CheckState = 1 Then
            lblSiteNote.BulkMemoryErase()
            lblSiteNote.InitMemoryArray()
            blnChgSaved = False
        End If

        blnChgSaved = False
        intSitesFound = intGroupsFound = intChannelsFound = 0
        intSiteLimit = lstSystems.Items.Count
        If intSiteLimit < lstSystems.Items.Count Then
            Response = CStr(MsgBox("You cannot download more than " & MaxSystems & " systems. Only the first " & MaxSystems & " will be downloaded.", , "Memory Limit"))
            intSiteLimit = MaxSystems
        End If

        strSIN = strMDL

        If strSIN = "UBR330T" Or strSIN = "BR330T" Or strSIN = "UBC3500XLT" Then
            blnBR330T = True
        ElseIf InStr(strSIN, "246") <> 0 Then
            Bln246 = True
        ElseIf InStr(strSIN, "230") <> 0 Then
            bln230 = True
            Bln246 = True
        ElseIf InStr(strSIN, "396") <> 0 Then
            Bln396 = True
        End If
        bAbortPressed = False
        cmdAbortDownload.Enabled = True
        strBuff = SendCMD("PRG")
        If Bln246 = False And chkSysQK.CheckState = 1 Then
            DownloadQSL()
        ElseIf chkSysQK.CheckState = 1 Then

            strQGL = SendCMD("QSL")
            If Len(strQGL) = 10 Then 'valid response
                RadioSetting(12) = strQGL & "000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"
            Else
                RadioSetting(12) = "111111111000000000000000000000000000000000000000000000000000000000000000000000000000000000"
            End If
        End If

        For intSystem = 1 To intSiteLimit
            'begin downloading systems to memory
            lstSystems.SelectedIndex = intSystem - 1
            intSin = Val(lstArray(intSystem - 1, 0))
            If lstSystems.GetItemChecked(intSystem - 1) = True And Not bAbortPressed Then 'yes we want to download this specific system

                strSIN = SendCMD("SIN," & intSin)
                If strSIN <> "ERR" And strSIN <> "-1" Then 'if everything is good, make a new system
                    'grab the group quick key status
                    RadioSetting(19) = CStr(Val(RadioSetting(19)) + 1)
                    'what kind of system is this?

                    strBuff = ParaParse(strSIN, 1)
                    If strBuff = "RACE" Then strBuff = "CNV" 'convert to CNV for sc230

                    If ParaParse(strSIN, 1) = "CNV" Then
                        intSitesFound = intSitesFound + 1
                        lblSiteNote.MakeNewConvSystem()
                        intSysNum = intCurrentSys
                        intCurrentGroup = 0
                        varSite(intSysNum, 0, 0, 1) = ParaParse(strSIN, 2) 'name
                        varSite(intSysNum, 0, 0, 4) = ParaParse(strSIN, 3) 'quick key
                        varSite(intSysNum, 0, 0, 5) = ParaParse(strSIN, 4) 'hold time
                        varSite(intSysNum, 0, 0, 2) = ParaParse(strSIN, 5) 'lockout
                        varSite(intSysNum, 0, 0, 34) = "0" ' No changes have been made to this system
                        If Bln246 = False Then
                            varSite(intSysNum, 0, 0, 6) = ParaParse(strSIN, 6) 'delay
                        Else
                            varSite(intSysNum, 0, 0, 6) = ParaParse(strSIN, 7)
                        End If

                        varSite(intSysNum, 0, 0, 8) = strQGL 'quick key status
                        If Bln246 = False Then
                            varSite(intSysNum, 0, 0, 9) = ParaParse(strSIN, 7) 'data skip
                        Else
                            varSite(intSysNum, 0, 0, 9) = ParaParse(strSIN, 8) 'data skip
                        End If
                        'apco settings
                        If Bln396 = True Then

                            strBuff = ParaParse(strSIN, 10) 'apco mode
                            If strBuff = "AUTO" Or strBuff = "MAN" Or strBuff = "DFLT" Then
                                varSite(intSysNum, 0, 0, 48) = strBuff
                                varSite(intSysNum, 0, 0, 49) = ParaParse(strSIN, 11)
                            End If
                        Else
                            varSite(intSysNum, 0, 0, 48) = APCOMode
                            varSite(intSysNum, 0, 0, 49) = APCOThreshold
                        End If

                        'now begin group loop
                        'get the next group id, if any
                        If Bln246 = False Then
                            intGroupIndex = Val(ParaParse(strSIN, 14))
                        Else
                            intGroupIndex = Val(ParaParse(strSIN, 12))
                        End If
                        Call DownloadQGL(intSin, intSysNum)
                        'is there a group here? if so start GROUP LOOP**************************
                        blnLastGroup = False
                        intGroup = 1
                        If intGroupIndex > 0 Then
                            Do Until blnLastGroup = True Or bAbortPressed
                                'download group info
                                strGroup = SendCMD("GIN," & intGroupIndex)
                                intGroupsFound = intGroupsFound + 1
                                'save group settings
                                If strGroup = "ERR" Then
                                    sngErr = sngErr + 1
                                    strLog = strLog & "Error: Bad Group Data"
                                    Call GenLog("Cannot download group information")
                                End If
                                If strGroup <> "ERR" Then
                                    varSite(intSysNum, intGroup, 0, 1) = ParaParse(strGroup, 2) 'GROUP NAME
                                    varSite(intSysNum, intGroup, 0, 2) = ParaParse(strGroup, 3) 'quickkey
                                    varSite(intSysNum, intGroup, 0, 3) = ParaParse(strGroup, 4) 'l/o status
                                    varSite(intSysNum, intGroup, 0, 5) = CStr(1) 'group type conv
                                    varSite(intSysNum, intGroup, 0, 10) = CreateGroupID()
                                    strCurOp = "Downloading " & Trim(varSite(intSysNum, 0, 0, 1)) & "\" & Trim(varSite(intSysNum, intGroup, 0, 1))
                                    'are there any channels available
                                    blnLastChan = False
                                    intChannelIndex = Val(ParaParse(strGroup, 8))
                                    If intChannelIndex > 0 Then
                                        'begin CHANNEL LOOP***************
                                        strChan = SendCMD("CIN," & intChannelIndex)
                                        Do Until blnLastChan = True Or bAbortPressed
                                            intChannelsFound = intChannelsFound + 1
                                            intChannel = InsertChan(varSite(intSysNum, intGroup, 0, 10), True)
                                            If intChannel > 0 Then
                                                ChanInfo(intChannel, 1) = ParaParse(strChan, 1) 'channel name
                                                ChanInfo(intChannel, 1) = MakeItKosherSilent(ChanInfo(intChannel, 1), 0)
                                                ChanInfo(intChannel, 2) = CStr(Val(CStr((Val(ParaParse(strChan, 2))) / 10000))) 'frequency
                                                If Bln246 = False Then
                                                    ChanInfo(intChannel, 4) = RevModModeLookup(ParaParse(strChan, 3)) 'modmode
                                                    ChanInfo(intChannel, 9) = ParaParse(strChan, 4) 'ctcss
                                                    ChanInfo(intChannel, 11) = ParaParse(strChan, 5) 'TONE lockout
                                                    ChanInfo(intChannel, 5) = ParaParse(strChan, 6) 'lockout
                                                    ChanInfo(intChannel, 7) = ParaParse(strChan, 7) 'priority
                                                    ChanInfo(intChannel, 6) = ParaParse(strChan, 8) 'attenuation
                                                    ChanInfo(intChannel, 8) = ParaParse(strChan, 9) 'alert  tone type
                                                    ChanInfo(intChannel, 13) = ParaParse(strChan, 10) 'alert level
                                                Else
                                                    ChanInfo(intChannel, 4) = RevModModeLookup(ParaParse(strChan, 4)) 'modmode
                                                    ChanInfo(intChannel, 9) = ParaParse(strChan, 5) 'ctcss
                                                    ChanInfo(intChannel, 11) = ParaParse(strChan, 6) 'TONE lockout
                                                    ChanInfo(intChannel, 5) = ParaParse(strChan, 7) 'lockout
                                                    ChanInfo(intChannel, 7) = ParaParse(strChan, 8) 'priority
                                                    ChanInfo(intChannel, 6) = ParaParse(strChan, 9) 'attenuation
                                                    ChanInfo(intChannel, 8) = ParaParse(strChan, 10) 'alert  tone type
                                                    ChanInfo(intChannel, 13) = CStr(0) 'alert level

                                                    ChanInfo(intChannel, 19) = RevStepLookup(ParaParse(strChan, 3)) 'stepsize
                                                End If
                                                If ChanInfo(intChannel, 9) = "0" Or ChanInfo(intChannel, 9) = "" Then
                                                    ChanInfo(intChannel, 12) = "0" ' audiotype=all
                                                Else
                                                    ChanInfo(intChannel, 12) = "1" 'audiotype=analog
                                                End If
                                            Else
                                                blnLastGroup = True
                                                intSystem = intSiteLimit
                                                sngErr = sngErr + 1
                                                MsgBox("Sorry, but FreeSCAN has insufficient channel memory to continue downloading.")
                                            End If

                                            'is there another channel after this?

                                            If Val(ParaParse(strChan, 12)) > 0 Then
                                                'get the info for the next loop

                                                intChannelIndex = Val(ParaParse(strChan, 12))

                                                strChan = SendCMD("CIN," & intChannelIndex)
                                            Else
                                                blnLastChan = True
                                            End If
                                        Loop  'END CHANNEL LOOP
                                    End If 'channel loop if
                                End If 'strgrp<>ERR if

                                'is there another group to download after this one?

                                If Val(ParaParse(strGroup, 6)) > 0 Then
                                    intGroupIndex = Val(ParaParse(strGroup, 6))
                                    strGroup = SendCMD("GIN," & intGroupIndex)
                                    intGroup = intGroup + 1
                                Else
                                    blnLastGroup = True
                                End If
                            Loop  'END GROUP LOOP
                        End If
                    ElseIf Not bAbortPressed Then 'actions for a trunked system
                        'this is handled, similarly but different to conv systems
                        intSitesFound = intSitesFound + 1
                        RadioSetting(20) = CStr(CDbl(RadioSetting(20)) + 1)
                        lblSiteNote.blnSkipGroup = True
                        lblSiteNote.MakeNewTrunkSystem(3)
                        intSysNum = intCurrentSys
                        lblSiteNote.blnSkipGroup = False

                        If intSysNum = -1 Or intSysNum = 0 Then
                            intSysNum = 1
                            sngErr += 1
                            intGroup = SendCMD("EPG")
                            MsgBox("Sorry, but the maximum number of systems has been reached. No more can be downloaded")
                            Form1.msc.Close()
                            Exit Sub
                        End If

                        strBuff = ParaParse(strSIN, 1)

                        'convert site type to sin type
                        If strBuff = "M81S" Or strBuff = "M81P" Then
                            varSite(intSysNum, 0, 0, 3) = CStr(2)
                        ElseIf strBuff = "M82S" Or strBuff = "M82P" Or strBuff = "M92" Or strBuff = "MV2" Or strBuff = "MU2" Or strBuff = "MP25" Then
                            varSite(intSysNum, 0, 0, 3) = CStr(3)
                        ElseIf strBuff = "EDN" Or strBuff = "EDW" Then
                            varSite(intSysNum, 0, 0, 3) = CStr(4)
                        ElseIf strBuff = "EDS" Then
                            varSite(intSysNum, 0, 0, 3) = CStr(5)
                        ElseIf strBuff = "LTR" Then
                            varSite(intSysNum, 0, 0, 3) = CStr(6)
                        ElseIf strBuff = "M82C" Then
                            varSite(intSysNum, 0, 0, 3) = CStr(3)
                        ElseIf strBuff = "M81C" Then
                            varSite(intSysNum, 0, 0, 3) = CStr(2)
                        Else
                            sngErr = sngErr + 1
                            Call GenLog("Invalid system type [" & strBuff & "]")
                            strLog = strLog & "INVALID SYSTEM TYPE"
                        End If
                        If strBuff = "M82C" Or strBuff = "M81C" Then 'download custom band plan
                            Call DownloadMCP(Val(CStr(intSysNum)), 1, Val(CStr(intSin)))
                        End If
                        varSite(intSysNum, 1, 0, 9) = RevSiteTypeLookup(strBuff)
                        varSite(intSysNum, 0, 0, 1) = ParaParse(strSIN, 2) 'name
                        varSite(intSysNum, 1, 0, 1) = ParaParse(strSIN, 2) 'name
                        varSite(intSysNum, 1, 0, 12) = "." 'startup key
                        varSite(intSysNum, 0, 0, 34) = "0" ' No changes have been made to this system
                        If Bln396 = True Then
                            strBuff = ParaParse(strSIN, 10) 'apco mode
                            If strBuff = "AUTO" Or strBuff = "MAN" Or strBuff = "DFLT" Then
                                varSite(intSysNum, 1, 0, 26) = strBuff
                                varSite(intSysNum, 1, 0, 27) = ParaParse(strSIN, 11)
                            End If
                        Else
                            varSite(intSysNum, 1, 0, 26) = APCOMode
                            varSite(intSysNum, 1, 0, 27) = APCOThreshold
                        End If

                        If Bln246 = False Then
                            varSite(intSysNum, 0, 0, 6) = ParaParse(strSIN, 6) 'delay
                        Else
                            varSite(intSysNum, 0, 0, 6) = ParaParse(strSIN, 7)
                        End If

                        varSite(intSysNum, 0, 0, 8) = strQGL 'quick key status
                        varSite(intSysNum, 0, 0, 24) = CStr(1) 'Tape out
                        Call DownloadQGL(intSin, intSysNum)
                        'download TGID lockout list
                        Call DownloadGLI(varSite(intSysNum, 0, 0, 23), CStr(intSin))
                        'download all the trunking paramaters

                        strTrunk = SendCMD("TRN," & intSin)
                        If strTrunk = "ERR" Then
                            sngErr = sngErr + 1
                            strLog = strLog & "ERROR: Unable to download trunk site settings"
                            Call GenLog("Cannot download trunk settings " & varSite(intSysNum, 0, 0, 1))
                        End If
                        If strTrunk <> "ERR" Then
                            varSite(intSysNum, 1, 0, 10) = CreateGroupID()
                            varSite(intSysNum, 0, 0, 18) = APCOMode
                            varSite(intSysNum, 1, 0, 3) = CStr(Val(ParaParse(strSIN, 5))) 'lockout
                            varSite(intSysNum, 1, 0, 4) = CStr(Val(ParaParse(strSIN, 4))) 'hold time
                            varSite(intSysNum, 1, 0, 2) = ParaParse(strSIN, 3) 'quickkey
                            varSite(intSysNum, 1, 0, 6) = ParaParse(strSIN, 8) 'modmode
                            If varSite(intSysNum, 1, 0, 6) = "" Then varSite(intSysNum, 1, 0, 6) = "AUTO"
                            varSite(intSysNum, 1, 0, 7) = CStr(Val(ParaParse(strSIN, 9))) 'att

                            intCurrentGroup = intSite
                            intTGIDGroupIndex = Val(ParaParse(strTrunk, 21)) 'save index of first TGID group
                            'begin extracting all the trunking information
                            varSite(intSysNum, 0, 0, 11) = CStr(Val(ParaParse(strTrunk, 1))) 'id search on/off
                            varSite(intSysNum, 0, 0, 12) = CStr(Val(ParaParse(strTrunk, 2))) 'motorola status bit
                            varSite(intSysNum, 0, 0, 13) = CStr(Val(ParaParse(strTrunk, 3))) 'end code
                            varSite(intSysNum, 0, 0, 14) = CStr(Val(ParaParse(strTrunk, 4))) 'AFS mode
                            varSite(intSysNum, 0, 0, 15) = CStr(Val(ParaParse(strTrunk, 5))) 'i call
                            varSite(intSysNum, 1, 0, 8) = CStr(Val(ParaParse(strTrunk, 6))) 'c-ch only
                            varSite(intSysNum, 1, 0, 5) = CStr(3) 'type=3 special
                            If Bln246 = False Then
                                varSite(intSysNum, 0, 0, 25) = ParaParse(strTrunk, 7) 'emerg alert type
                                varSite(intSysNum, 0, 0, 26) = ParaParse(strTrunk, 8) 'emerg alert level
                                varSite(intSysNum, 0, 0, 16) = CStr(Val(ParaParse(strTrunk, 9))) 'Fleet Map
                                varSite(intSysNum, 0, 0, 17) = RevFleetMap(ParaParse(strTrunk, 10)) 'Custom Fleet Map
                                varSite(intSysNum, 0, 0, 27) = CStr(Val(ParaParse(strTrunk, 20)))

                                'motorola band plan
                                If varSite(intSysNum, 1, 0, 9) <> "13" Then
                                    'download band plan as long as its not a custom 800mhz site
                                    Call SaveBPParam(intSysNum, 1, 0, 0, CStr(Val(ParaParse(strTrunk, 11)))) 'base 1
                                    Call SaveBPParam(intSysNum, 1, 2, 0, CStr(Val(ParaParse(strTrunk, 12)))) 'step 1
                                    Call SaveBPParam(intSysNum, 1, 3, 0, CStr(Val(ParaParse(strTrunk, 13)))) 'offset 1
                                    Call SaveBPParam(intSysNum, 1, 0, 1, CStr(Val(ParaParse(strTrunk, 14)))) 'base 1
                                    Call SaveBPParam(intSysNum, 1, 2, 1, CStr(Val(ParaParse(strTrunk, 15)))) 'step 1
                                    Call SaveBPParam(intSysNum, 1, 3, 1, CStr(Val(ParaParse(strTrunk, 16)))) 'offset 1
                                    Call SaveBPParam(intSysNum, 1, 0, 2, CStr(Val(ParaParse(strTrunk, 17)))) 'base 1
                                    Call SaveBPParam(intSysNum, 1, 2, 2, CStr(Val(ParaParse(strTrunk, 18)))) 'step 1
                                    Call SaveBPParam(intSysNum, 1, 3, 2, CStr(Val(ParaParse(strTrunk, 19)))) 'offset 1
                                End If
                                varSite(intSysNum, 0, 0, 27) = CStr(Val(ParaParse(strTrunk, 20))) 'digital end code
                            Else
                                varSite(intSysNum, 0, 0, 26) = CStr(0) 'emerg alert level
                                varSite(intSysNum, 0, 0, 16) = CStr(Val(ParaParse(strTrunk, 7))) 'Fleet Map
                                varSite(intSysNum, 0, 0, 17) = RevFleetMap(ParaParse(strTrunk, 8)) 'Custom Fleet Map

                                'motorola band plan
                                If varSite(intSysNum, 1, 0, 9) <> "13" Then
                                    Call SaveBPParam(intSysNum, 1, 0, 0, CStr(Val(ParaParse(strTrunk, 9)))) 'base 1
                                    Call SaveBPParam(intSysNum, 1, 2, 0, CStr(Val(ParaParse(strTrunk, 10)))) 'step 1
                                    Call SaveBPParam(intSysNum, 1, 3, 0, CStr(Val(ParaParse(strTrunk, 11)))) 'offset 1
                                    Call SaveBPParam(intSysNum, 1, 0, 1, CStr(Val(ParaParse(strTrunk, 12)))) 'base 1
                                    Call SaveBPParam(intSysNum, 1, 2, 1, CStr(Val(ParaParse(strTrunk, 13)))) 'step 1
                                    Call SaveBPParam(intSysNum, 1, 3, 1, CStr(Val(ParaParse(strTrunk, 14)))) 'offset 1
                                    Call SaveBPParam(intSysNum, 1, 0, 2, CStr(Val(ParaParse(strTrunk, 15)))) 'base 1
                                    Call SaveBPParam(intSysNum, 1, 2, 2, CStr(Val(ParaParse(strTrunk, 16)))) 'step 1
                                    Call SaveBPParam(intSysNum, 1, 3, 2, CStr(Val(ParaParse(strTrunk, 17)))) 'offset 1
                                End If
                                varSite(intSysNum, 0, 0, 27) = "0" 'digital end code off
                            End If
                            '****************APCO band plan

                            If Val(varSite(intSysNum, 1, 0, 3)) = 6 Then 'this is a P25 site, download apco band plan
                                CommonABP(intSysNum, 1, intSin)
                            End If

                            varSite(intSysNum, 0, 0, 10) = CStr(Val(varSite(intSysNum, 0, 0, 10)) + 1)
                            If Bln246 = False Then

                                If Val(ParaParse(strSIN, 14)) > 0 Then 'is there a group of trunk frequencies?
                                    strSIF = SendCMD("GIN," & ParaParse(strSIN, 14))
                                End If
                            Else
                                If Val(ParaParse(strSIN, 13)) > 0 Then 'is there a group of trunk frequencies?
                                    strSIF = SendCMD("GIN," & ParaParse(strSIN, 13))
                                End If
                            End If

                            intTrunkIndex = Val(ParaParse(strSIF, 8)) 'this gets the first memory location for the trunk frequencies
                            If intTrunkIndex = 0 Then
                                sngErr = sngErr + 1
                                Call GenLog("Invalid trunk index")
                                strLog = strLog & "ERROR: Invalid trunk index"
                            End If
                            If intTrunkIndex > 0 And Not bAbortPressed Then
                                '*************************START TRUNKING FREQUENCY LOOP
                                blnLastChan = False
                                intChan = 1

                                ResponseCode = SendCMD("TFQ," & intTrunkIndex) 'get the first TFQ
                                Do Until blnLastChan = True Or blnNoMoreMem = True Or bAbortPressed
                                    'advance to next
                                    strCurOp = "Downloading trunk frequencies - " & intChan & " channels found so far."
                                    intChannelsFound = intChannelsFound + 1
                                    If Bln246 = False Then

                                        intTrunkIndex = Val(ParaParse(ResponseCode, 5))
                                    Else

                                        intTrunkIndex = Val(ParaParse(ResponseCode, 4))
                                    End If

                                    intCurrTrn = InsertTrunkFreq(varSite(intSysNum, 1, 0, 10))
                                    If intCurrTrn = -1 Then
                                        MsgBox("Reached maximum amount of trunk frequencies that can be stored. Remaining will be ignored.")
                                        blnLastChan = True
                                        sngErr = sngErr + 1
                                        blnNoMoreMem = True
                                    ElseIf intCurrTrn >= 0 Then
                                        strTrunkFreq(intCurrTrn, 0) = CStr(Val(ParaParse(ResponseCode, 1)) / 10000) 'freq
                                        strTrunkFreq(intCurrTrn, 1) = CStr(Val(ParaParse(ResponseCode, 2))) 'lcn
                                        If Bln246 = False Then '246 does not support locking out trunk frequencies

                                            strTrunkFreq(intCurrTrn, 3) = CStr(Val(ParaParse(ResponseCode, 3))) 'lockout
                                        Else
                                            strTrunkFreq(intCurrTrn, 3) = "0"
                                        End If
                                    End If
                                    If intTrunkIndex > 0 Then 'is there another frequency to follow this one?
                                        'grab it and get ready for the next loop
                                        intChan = intChan + 1
                                        If Bln246 = False Then
                                            ResponseCode = SendCMD("TFQ," & ParaParse(ResponseCode, 5))
                                        Else
                                            ResponseCode = SendCMD("TFQ," & ParaParse(ResponseCode, 4))
                                        End If
                                    Else
                                        blnLastChan = True
                                    End If
                                Loop  'trunk frequencies loop
                            End If 'are there any trunking frequencies?
                            'START TGID LOOP**********************

                            intGroup = 2
                            If Bln246 = False Then
                                intTGIDGroupIndex = Val(ParaParse(SendCMD("TRN," & intSin), 21))
                            Else
                                intTGIDGroupIndex = Val(ParaParse(SendCMD("TRN," & intSin), 18))
                            End If
                            If intTGIDGroupIndex > 0 Then 'are there any TGID groups to download?
                                Do Until intTGIDGroupIndex < 1 Or bAbortPressed
                                    intGroupsFound = intGroupsFound + 1

                                    ResponseCode = SendCMD("GIN," & intTGIDGroupIndex) 'get the basic group info
                                    'save basic group info
                                    varSite(intSysNum, intGroup, 0, 1) = ParaParse(ResponseCode, 2) 'group name
                                    varSite(intSysNum, intGroup, 0, 2) = ParaParse(ResponseCode, 3) 'quick key name
                                    varSite(intSysNum, intGroup, 0, 3) = ParaParse(ResponseCode, 4) 'l/o status name
                                    varSite(intSysNum, intGroup, 0, 5) = CStr(2) 'group type trunk
                                    varSite(intSysNum, intGroup, 0, 10) = CreateGroupID()
                                    If intGroup = MaxGroups Then intTGIDGroupIndex = -1

                                    strCurOp = "Downloading " & Trim(varSite(intSysNum, 0, 0, 1)) & "\" & Trim(varSite(intSysNum, intGroup, 0, 1))
                                    intChannelIndex = Val(ParaParse(ResponseCode, 8)) ' get channel index
                                    If intChannelIndex > 0 Then 'are there any channel present? if so start another loop
                                        Do Until intChannelIndex < 1 Or bAbortPressed
                                            intChan = InsertChan(varSite(intSysNum, intGroup, 0, 10), False)
                                            CResponseCode = SendCMD("TIN," & intChannelIndex)
                                            If intChan = -1 Then
                                                sngErr = sngErr + 1
                                                intChannelIndex = -1 : MsgBox("The number of channels in this group has exceeded memory capacity. Remaining channels ignored.")
                                            Else
                                                'save basic channel info
                                                ChanInfo(intChan, 1) = ParaParse(CResponseCode, 1) 'name
                                                ChanInfo(intChan, 1) = MakeItKosherSilent(ChanInfo(intChan, 1), 0)
                                                ChanInfo(intChan, 2) = ParaParse(CResponseCode, 2) 'TGID
                                                ChanInfo(intChan, 3) = CStr(Val(ParaParse(CResponseCode, 3))) 'lockout status
                                                ChanInfo(intChan, 6) = CStr(0) 'audio type = all
                                                If Bln246 = False Then
                                                    ChanInfo(intChan, 4) = CStr(Val(ParaParse(CResponseCode, 5))) 'alert type
                                                    ChanInfo(intChan, 5) = CStr(Val(ParaParse(CResponseCode, 6))) 'alert level
                                                    ChanInfo(intChan, 7) = CStr(Val(ParaParse(CResponseCode, 4))) 'PRIORITY
                                                Else

                                                    ChanInfo(intChan, 4) = ParaParse(CResponseCode, 4) 'alert type
                                                    ChanInfo(intChan, 5) = CStr(0) 'alert level
                                                    ChanInfo(intChan, 7) = CStr(0) 'PRIORITY
                                                End If
                                                intChannelsFound = intChannelsFound + 1
                                                If Bln246 = False Then
                                                    intChannelIndex = Val(ParaParse(CResponseCode, 8))
                                                Else
                                                    intChannelIndex = Val(ParaParse(CResponseCode, 6))
                                                End If
                                            End If 'is there any memory left?
                                        Loop  'end channel loop
                                    End If

                                    intGroup = intGroup + 1
                                    varSite(intSysNum, 0, 0, 10) = CStr(Val(varSite(intSysNum, 0, 0, 10)) + 1)
                                    'grab the next group, if there is one

                                    intTGIDGroupIndex = Val(ParaParse(ResponseCode, 6))
                                Loop  'end group loop
                            End If ' end main tgid group if
                        End If
                    End If
                End If
            End If
            If bAbortPressed Then
                intSystem = intSiteLimit
            End If
        Next intSystem
        'need to do something about QSL list for the 246, possibly?
        If chkDownloadCustomSettings.CheckState = 1 And Not bAbortPressed Then 'download custom radio settings to memory
            strCurOp = "Downloading scanner settings..."
            strSIN = SendCMD("BLT")
            RadioSetting(85) = ParaParse(strSIN, 1)
            RadioSetting(3) = SendCMD("PRI")
            Response = SendCMD("KBP")
            RadioSetting(4) = ParaParse(Response, 1)
            RadioSetting(104) = "0"
            RadioSetting(105) = "0"
            RadioSetting(86) = CStr(Val(SendCMD("BSV"))) ' battery save
            RadioSetting(107) = "5" 'charge time default
            'lcd setting
            If Bln246 Or bln230 Then
                RadioSetting(29) = CStr(6)
            Else
                Response = SendCMD("CNT")
                If Val(Response) > 0 And Val(Response) < 16 Then
                    RadioSetting(29) = Response
                Else
                    RadioSetting(29) = CStr(6)
                End If
            End If


            strSIN = SendCMD("OMS")
            CommonWX()
            If Bln246 = False Then
                ToneDL396()
            End If
            RadioSetting(5) = ParaParse(strSIN, 1)
            RadioSetting(6) = ParaParse(strSIN, 2)
            If Bln246 = False Then
                RadioSetting(22) = ParaParse(strSIN, 3)
                RadioSetting(23) = ParaParse(strSIN, 4)
            Else
                RadioSetting(22) = ""
                RadioSetting(23) = ""
            End If

            strSIN = SendCMD("CLC") 'close call setting

            RadioSetting(7) = ParaParse(strSIN, 1) 'close call mode

            RadioSetting(8) = ParaParse(strSIN, 2) 'cc override

            RadioSetting(27) = ParaParse(strSIN, 3) 'cc alert mode
            RadioSetting(9) = "." 'CC Hits with scan quick key
            If Bln246 = False Then
                RadioSetting(13) = ParaParse(strSIN, 4) 'cc alert beep type
                RadioSetting(15) = ParaParse(strSIN, 5) 'alert level
                RadioSetting(11) = ParaParse(strSIN, 6) 'cc pause
                RadioSetting(14) = ParaParse(strSIN, 7) 'cc bands
            Else
                strBuff = ParaParse(strSIN, 4) 'cc bands
                RadioSetting(14) = Mid(strBuff, 1, 1) & Mid(strBuff, 1, 1) & Mid(strBuff, 2, 1) & Mid(strBuff, 3, 1) & Mid(strBuff, 3, 1) & Mid(strBuff, 4, 1) & Mid(strBuff, 5, 1)
                RadioSetting(13) = "0" 'cc alert beep type
                RadioSetting(15) = "0" 'alert level
                RadioSetting(11) = "3" 'cc pause
            End If
            strSIN = SendCMD("SCO")
            RadioSetting(17) = RevStepLookup(ParaParse(strSIN, 1)) 'search step
            RadioSetting(18) = ParaParse(strSIN, 2) 'mod type
            RadioSetting(33) = ParaParse(strSIN, 3) 'atten
            RadioSetting(21) = ParaParse(strSIN, 4) 'delay
            RadioSetting(40) = ParaParse(strSIN, 5) 'data skip
            RadioSetting(24) = ParaParse(strSIN, 6) 'code search
            RadioSetting(43) = ParaParse(strSIN, 7) 'pager screen
            RadioSetting(41) = ParaParse(strSIN, 8) 'repeater find
            RadioSetting(16) = APCOMode 'apco stuff

            If Bln246 = False Then

                RadioSetting(32) = ParaParse(strSIN, 11) 'max auto store
            Else

                RadioSetting(32) = ParaParse(strSIN, 9) 'max auto store
            End If
            lstSystems.Enabled = True

            'AGC control
            If Bln246 = False Then
                Response = SendCMD("AGV")
                RadioSetting(25) = CStr(Val(ParaParse(Response, 1))) 'analog agc
                RadioSetting(26) = CStr(Val(ParaParse(Response, 2))) 'digital agc
            Else
                RadioSetting(25) = "0" 'analog agc
                RadioSetting(26) = "0" 'digital agc
            End If
            If blnBR330T = False And Bln246 = False And bln230 = False Then
                'try to get advanced agc and p25 settings
                CommonAGC(("AGS"))

            End If
            'broadcast screen settings
            x = 0
            For cnt = 0 To 19 Step 2
                x = x + 1
                If x = 10 Then x = 0
                If Bln246 = False And bln230 = False Then
                    strCMD(0) = "BBS," & x
                    Response = SendCMD(strCMD(0))
                    RadioSetting(51 + cnt) = CStr(Val(ParaParse(Response, 1)) / 10000)
                    RadioSetting(52 + cnt) = CStr(Val(ParaParse(Response, 2)) / 10000)
                Else
                    RadioSetting(51 + cnt) = CStr(0)
                    RadioSetting(52 + cnt) = CStr(0)
                End If
            Next cnt


            'GLOBAL FREQ LOCKOUT
            blnDone = False

            System.Array.Clear(strSearchLockout, 0, strSearchLockout.Length)
            intChan = 0
            Do Until blnDone = True Or bAbortPressed


                strSIN = SendCMD("GLF")
                Select Case strSIN
                    Case "-1"
                        blnDone = True
                    Case "ERR"
                        blnDone = True
                        sngErr = sngErr + 1
                        strLog = strLog & "ERROR: INVALID GLF RESPONSE"
                    Case "FAI"
                        blnDone = True
                        sngErr = sngErr + 1
                        strLog = strLog & "ERROR, GENERAL COMMUNICATIONS"
                    Case Else
                        intChan = intChan + 1
                        If intChan <= MaxSearchLockout Then

                            strSearchLockout(intChan) = Val(strSIN) / 10000
                        Else
                            blnDone = True
                        End If
                End Select
            Loop
            'service search setting
            For intChan = 1 To 12
                strSS(intChan, 5) = "." 'qk
                strSS(intChan, 6) = "." 'startup key
                strSS(intChan, 7) = CStr(1) 'record out
                Response = SendCMD("SSP," & intChan)
                strSSXT(intChan, 1) = "1"
                strSSXT(intChan, 2) = "1"
                strSSXT(intChan, 3) = "0" 'p25 wait time
                strSSXT(intChan, 4) = "NONE" 'num tag
                If Bln246 = False Then
                    If Response <> "ERR" Then
                        strSS(intChan, 2) = ParaParse(Response, 2)
                        strSS(intChan, 3) = ParaParse(Response, 3)
                        strSS(intChan, 4) = ParaParse(Response, 4)
                        strSS(intChan, 8) = ParaParse(Response, 5)
                    Else
                        sngErr += 1
                        Call GenLog("Invalid service search request")
                    End If
                Else
                    strSS(intChan, 2) = "2" 'delay
                    strSS(intChan, 3) = "0" 'att
                    strSS(intChan, 4) = "2" 'hold time
                    strSS(intChan, 8) = "1" 'l/o
                End If
            Next intChan
        End If

        'custom search ranges
        If chkDownloadCustomSearch.CheckState = 1 And Not bAbortPressed Then

            strCustSearchEnable = SendCMD("CSG")
            For x = 0 To 9
                intChan = x
                strChan = SendCMD("CSP," & x)
                If x = 0 Then intChan = 10
                CustSearch(intChan, 0) = ParaParse(strChan, 1) 'name
                CustSearch(intChan, 1) = CStr(Val(ParaParse(strChan, 2)) / 10000) 'low limit
                CustSearch(intChan, 2) = CStr(Val(ParaParse(strChan, 3)) / 10000) 'high limit
                CustSearch(intChan, 3) = IndexSearchStep(ParaParse(strChan, 4)) 'search step
                CustSearch(intChan, 4) = ParaParse(strChan, 5) 'modulation
                CustSearch(intChan, 5) = ParaParse(strChan, 6) 'attenuation
                CustSearch(intChan, 6) = ParaParse(strChan, 7) 'delay time
                CustSearch(intChan, 7) = ParaParse(strChan, 8) 'data skip
                CustSearch(intChan, 11) = "NONE"        'xt num tag
                CustSearch(intChan, 16) = "110000"      'xt other settings
                If Bln246 = False Then
                    CustSearch(x + 1, 8) = BinaryFlip(Val(Mid(strCustSearchEnable, x + 1, 1))) 'enabled/disabled
                    CustSearch(intChan, 9) = ParaParse(strChan, 9) 'hold time
                    CustSearch(intChan, 15) = ParaParse(strChan, 10) 'l/o
                    CustSearch(intChan, 10) = ParaParse(strChan, 11) 'c-ch only
                Else
                    CustSearch(x + 1, 8) = "1" 'enabled/disabled
                    CustSearch(intChan, 9) = "2" 'hold time
                    CustSearch(intChan, 15) = "1" 'l/o
                    CustSearch(intChan, 10) = "0" 'c-ch only
                End If

            Next x
        End If
        Me.Enabled = True
        If bAbortPressed Then
            strCurOp = "Download aborted"
        Else
            strCurOp = "Finished downloading systems. Click 'Close' to continue."
        End If


        bAbortPressed = False
        cmdAbortDownload.Enabled = False
        ResponseCode = SendCMD("EPG")
        SetFinishGraphic()
        CheckResume()
        If Form1.msc.IsOpen = True Then Form1.msc.Close()
        lblSiteNote.SetFormCaption()
        If Me.Visible = True Then
            cmdClose.Focus()
        Else
            With lblSiteNote
                .DrawSystemTree()
                If sngErr = 0 Then
                    .DispStat("Download complete with no errors")
                Else
                    .DispStat("Errors during download")
                    Me.Visible = True
                End If
            End With
        End If
        Exit Sub
criticerror:
        Me.Enabled = True
        Call ErrorHandler(Err.Number, strLog)
    End Sub

    Sub Common_CheckQueue()
        'this checks to make sure the user queued systems first
        'so they dont download a lot of nothing
        Dim Response As String
        If blnQueue <> True And blnNagged <> True Then 'yes=6
            blnNagged = True
            Response = CStr(MsgBox("You haven't clicked on Queue Systems to view available systems. This will result in no systems being downloaded. Would you like to Queue Systems now?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "No systems selected for download"))
            Select Case Response
                Case CStr(6) 'yes
                    cmdQueueSystems_Click(cmdQueueSystems, New System.EventArgs())
                    If Form1.msc.IsOpen = False Then Form1.msc.Open()

                    Response = SendCMD("PRG")
            End Select
        End If
    End Sub
    Function RevFleetMap(ByRef strMap As String) As String
        'This function takes the custom fleet map from scanner (strmap)
        'and returns a format that is used to save it onto disk
        Dim x As Integer, strFM As String
        Dim strMode As String
        strFM = ""
        For x = 1 To 8


            strMode = Mid(strMap, x, 1)
            Select Case UCase(strMode)
                Case "A"

                    strFM = strFM & "!10"
                Case "B"

                    strFM = strFM & "!11"
                Case "C"

                    strFM = strFM & "!12"
                Case "D"

                    strFM = strFM & "!13"
                Case "E"

                    strFM = strFM & "!14"
                Case Else

                    strFM = strFM & "!" & Format(strMode, "00")
            End Select
        Next x


        RevFleetMap = strFM
    End Function
    Function MakeFleetMap(ByRef strMap As String) As String
        Dim strFleet As String
        Dim strSizeCode, strMap1 As String
        Dim intPos As Integer
        strMap1 = ""
        For intPos = 0 To 6


            strFleet = strMap
            If Len(strFleet) = 21 Then

                strSizeCode = Mid(strFleet, (3 * intPos) + 2, 2)

                If Val(strSizeCode) <= 9 Then
                    strMap1 = strMap1 & strSizeCode
                Else
                    strMap1 = strMap1 & Chr(55 + CDbl(strSizeCode))
                End If

            End If
        Next intPos
        If Len(strMap1) <> 7 Then
            strMap1 = "0000000"
        End If

        MakeFleetMap = strMap1
    End Function
    Sub WriteStats()
        'displays a total count for all sites,channels,groups found
        lblSystemsFound.Text = CStr(intSitesFound)
        lblGroupsFound.Text = CStr(intGroupsFound)
        lblChannelsFound.Text = CStr(intChannelsFound)
        lblErr.Text = CStr(sngErr)
    End Sub




    Private Sub chkClearMemory_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkClearMemory.CheckStateChanged
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub


    Private Sub chkDownloadCustomSearch_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDownloadCustomSearch.CheckStateChanged
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub


    Private Sub chkDownloadCustomSettings_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDownloadCustomSettings.CheckStateChanged
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub


    Private Sub chkLinux_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub

    Private Sub cmdAbort_Click()
        If Form1.msc.IsOpen = True Then Form1.msc.Close()
        MsgBox("Aborted operation")
        Me.Enabled = True

    End Sub


    Private Sub chkResume_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkResume.CheckStateChanged
        If Me.Visible = False Then Exit Sub
        SavePrefs()
    End Sub


    Private Sub chkSysQK_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSysQK.CheckStateChanged
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
    Sub CommonToneOut(ByRef blnXT As Boolean, ByRef bln346 As Boolean)
        On Error GoTo criticerror
        'download ToneOut settings
        Dim strBuff0(45) As String
        Dim strBuff1(45) As String
        Dim strbuff2(45) As String
        Dim strbuff3(45) As String
        Dim strBuff4(45) As String
        Dim strBuff5(20) As String
        Dim strBuff6(45) As String
        Dim strName As String
        Dim lngTone1, intAlertTone, intAlertLevel, lngTone2 As Integer
        Dim lngFreq, intRecord, cnt As Integer
        Dim strDelay, Response, strMDL As String
        Dim cnt1, intToneIndex As Integer
        Dim strCMD As String
        Dim strBuff7(9) As String
        Dim strBuff8(9) As String
        Dim strBuff9(9) As String
        Dim ATT(9) As String
        Dim ModMode(9) As String
        If bln346 Then
            strMDL = "BC346XT"
        Else
            strMDL = Nothing
        End If

        For cnt = 0 To 9
            intToneIndex = cnt + 1
            If intToneIndex = 10 Then intToneIndex = 0

            Response = SendCMD("TON," & intToneIndex)
            'name
            strBuff0(cnt) = ParaParse(Response, 2)
            'frequency
            strBuff1(cnt) = MakeItKosherFreqSilent(Val(ParaParse(Response, 3)) / 10000)
            'delay time
            strbuff2(cnt) = ParaParse(Response, 6)
            'alert tone type
            strbuff3(cnt) = ParaParse(Response, 7)
            'alert tone level
            strBuff4(cnt) = ParaParse(Response, 8)
            'tone a hrmmm
            strBuff5(cnt * 2) = Val(ParaParse(Response, 9)) / 10
            'tone b
            strBuff5((cnt * 2) + 1) = Val(ParaParse(Response, 11)) / 10
            'attenuation
            ATT(cnt) = MakeBinary(ParaParse(Response, 5))
            'modulation
            ModMode(cnt) = ParaParse(Response, 4)
            If blnXT = False Then
                'record
                strBuff6(cnt) = Val(ParaParse(Response, 14))
                strBuff7(cnt) = CStr(0) 'alert pattern
                strBuff8(cnt) = "OFF" 'colour
                strBuff9(cnt) = CStr(1) 'AGC on /off
            ElseIf bln346 Then
                strBuff7(cnt) = ChgAlertCode(CStr(Val(ParaParse(Response, 16))), strMDL) 'alert pattern
                If ParaParse(Response, 16) <> "0" Then
                    strBuff8(cnt) = "RED" 'colour
                Else
                    strBuff8(cnt) = "OFF" 'colour
                End If
                strBuff9(cnt) = CStr(0) 'AGC on /off
            Else
                strBuff7(cnt) = CStr(Val(ParaParse(Response, 16))) 'alert pattern
                strBuff8(cnt) = ParaParse(Response, 15) ' 'colour
                strBuff9(cnt) = CStr(Val(ParaParse(Response, 17))) ''AGC on /off
            End If
        Next cnt

        'save the new settings to memory
        RadioSetting(74) = Join(strBuff0, Chr(9)) 'name
        RadioSetting(75) = Join(strBuff1, Chr(9)) 'freq
        RadioSetting(76) = Join(strBuff5, Chr(9)) 'tones
        RadioSetting(77) = Join(strbuff3, Chr(9)) 'alert tone
        RadioSetting(78) = Join(strBuff4, Chr(9)) 'alert tone level
        RadioSetting(79) = Join(strbuff2, Chr(9)) 'delay time
        RadioSetting(80) = Join(strBuff6, Chr(9)) 'delay on/off
        RadioSetting(91) = Join(strBuff7, ",") 'pattern
        RadioSetting(90) = Join(strBuff8, ",") 'colour
        RadioSetting(92) = Join(strBuff9, ",") 'agc on/off
        RadioSetting(81) = Join(ModMode, ",") 'modulation
        RadioSetting(82) = Join(ATT, ",") 'attenuation
        Exit Sub
criticerror:
        MsgBox("Critical error processing fire tone outs. Fire tone outs will not be imported.")
        Exit Sub
    End Sub

    Private Sub cmdClearAllSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearAllSys.Click
        'checks all  items in list box
        Dim x As Integer
        For x = 0 To lstSystems.Items.Count - 1
            lstSystems.SelectedIndex = x
            lstSystems.SetItemChecked(x, False)
        Next x

    End Sub

    Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
        Me.Visible = False
        Call GenLog("CLEARALL")
        With lblSiteNote
            .Visible = True
            .Enabled = True
            .Activate()
            .DrawSystemTree()
            .UpdateViewMode()
        End With
    End Sub

    Private Sub cmdComSetup_Click()
        Me.Enabled = False
        frmCOMPort.Visible = True
        frmCOMPort.Activate()

    End Sub

    Private Sub cmdCopyDownload_Click()
        If strLog = Nothing Then
            MsgBox("Nothing to copy to clipboard")
            Exit Sub
        End If
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(strLog)
        MsgBox(Len(strLog) & " bytes copied to clipboard.")
    End Sub

    Private Sub cmdFlash_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFlash.Click
        If blnDebug = False Then On Error GoTo criticerror
        Dim strCMD(5) As String
        Dim strChanName, strName, Response As String
        Dim strQK, strModMode As String
        Dim intIndex, intGroup, intGroupIndex As Integer
        Dim intToneLock, intSystem, intChannelIndex As Integer
        Dim intChan As Single
        Dim intTrunkIndex As Single

        Dim ResponseCode As String
        Dim blnDone As Boolean
        Dim cnt, intSys As Integer
        Dim blnBC15 As Boolean
        Dim strBuff As String
        Dim strCustFleetMap As String
        Dim strSysType As String
        Dim x, intSeqIndex, intList As Integer
        Dim strGroup As String
        Dim intSin As Integer
        Dim strSIN, C, CResponseCode As String
        Dim blnLastGroup As Boolean
        Dim intChannel As Single
        Dim blnLastChan As Boolean
        Dim strChan, strTrunk As String
        Dim intTGIDGroupIndex, intSiteLimit As Integer
        Dim strCustSearchEnable, strSIF As String
        Dim blnLastSite As Boolean
        Dim intSiteIndex, intSite As Integer
        Dim strMBP, sBuff As String
        Dim intCurrTrn As Integer
        Dim blnNoMoreMem, blnAnalog, bln346 As Boolean
        Dim Bln996, Bln396XT, blnXT, Bln325P2, blnNoMemDlg, blnYeah As Boolean
        Dim Bln996XT As Boolean = False
        Dim bln15XT As Boolean = False
        Dim strMDL As String
        Dim ALT_COLOR As String, Alt_Pattern As String
        Dim strPad() As String
        If RemoteMode() = True Then Exit Sub
        ResponseCode = 0

        If Form1.msc.IsOpen = True Then Form1.msc.Close()
  
        blnBC15 = False

        GenLog(("CLEARALL"))
        strLog = ""
        lblOp.Text = ""
        intGroupsFound = 0
        intSitesFound = 0
        intChannelsFound = 0
        sngErr = 0
        C = ","
        WriteStats()
        blnRmtCtlMode = False
        blnAnalog = False
        'load programming from radio
        'check com port settings
        If Val(RadioSetting(44)) = 0 Then 'nocomport num
            MsgBox("Please choose a COM port before continuing.")
            Call mnuScannerCOMPort_Click(mnuScannerCOMPort, New System.EventArgs())
            Exit Sub
        End If
        If Val(RadioSetting(45)) = 0 Then 'baud rate
            MsgBox("Please set COM Port speed before continuing.")
            Call mnuScannerCOMPort_Click(mnuScannerCOMPort, New System.EventArgs())
            Exit Sub
        End If
        SetDLMode()
        Form1.msc.PortName = "COM" & RadioSetting(44)
        Form1.msc.BaudRate = (RadioSetting(45))
        If Not COMPortExists() Then
            Exit Sub
        End If
        If Form1.msc.IsOpen = False Then Form1.msc.Open()
        frmQKEdit.Visible = False
        strMDL = SendCMD("MDL")
        If strMDL = "UBC800XLT" Then
            strMDL = "BCT15"
        End If
        If Strings.Left(strMDL, 1) = "U" Then
            strMDL = Strings.Right(strMDL, Len(strMDL) - 1)
        End If

        If strMDL = "-1" Then
            sngErr += 1
            GenLog(("Serial port error"))

            Response = SendCMD("EPG")
            Form1.msc.Close()
            lblOp.Text = "Serial port error"
            MsgBox("FreeSCAN is unable to establish communication with the scanner. Check your serial port settings.")
            IOGraphic(("F"))
            Call mnuScannerCOMPort_Click(mnuScannerCOMPort, New System.EventArgs())
            Exit Sub
        ElseIf InStr(strMDL, "BCD996XT") <> 0 Or InStr(strMDL, "BCD996P2") <> 0 Then
            Bln996XT = True
            blnXT = True
        ElseIf InStr(strMDL, "BCT15X") <> 0 Then
            bln15XT = True
            blnXT = True
            blnAnalog = True
        ElseIf InStr(SupportedScanners, strMDL) = 0 Then  'lecture user
            Response = SendCMD("EPG")
            Form1.msc.Close()
            lblOp.Text = "Incompatible scanner."
            MsgBox("This version of FreeSCAN is only designed for the " & SupportedScanners & ". It will not work with other types. If you are using one of these scanners, then you need to recheck your COM port settings.")
            IOGraphic(("F"))
            Exit Sub
        ElseIf strMDL = "BC15T" Or strMDL = "UBC15T" Then
            blnBC15 = True
            blnAnalog = True
        ElseIf strMDL = "BCD996T" Or strMDL = "UBCD996T" Then
            Bln996 = True
        ElseIf InStr(strMDL, "246") <> 0 Or InStr(strMDL, "330") <> 0 Or InStr(strMDL, "3500") <> 0 Or InStr(strMDL, "396T") <> 0 Or InStr(strMDL, "230") <> 0 Then

            Download396(strMDL)
            Call GenFileName(strMDL)
            Exit Sub
        ElseIf strMDL = "BC346XT" Or strMDL = "BC346XTC" Then
            bln346 = True
            blnXT = True
            blnAnalog = True
        ElseIf strMDL = "BCD396XT" Then
            Bln396XT = True
            blnXT = True
        ElseIf strMDL = "BCD325P2" Then
            Bln325P2 = True
            Bln396XT = True
            blnXT = True
        End If

        DisableCCO(strMDL, True)
        Response = SendCMD("PRG")
        Common_CheckQueue() 'checks to make sure the user queued systems first
        'should we erase everything in memory before downloading?
        If chkClearMemory.CheckState = 1 Then
            Call lblSiteNote.mnuFileNew_Click(Nothing, Nothing)
            blnChgSaved = False
        End If
        Call GenFileName(strMDL)
        blnChgSaved = False
        intSitesFound = intGroupsFound = intChannelsFound = 0
        intSiteLimit = lstSystems.Items.Count
        If intSiteLimit < lstSystems.Items.Count Then
            Response = CStr(MsgBox("You cannot download more than " & MaxSystems & " systems. Only the first " & MaxSystems & " will be downloaded.", , "Memory Limit"))
            intSiteLimit = MaxSystems
        End If

        cmdAbortDownload.Enabled = True
        bAbortPressed = False
        For intSystem = 1 To intSiteLimit

            'begin downloading systems to memory
            lstSystems.SelectedIndex = intSystem - 1
            intSin = CInt(lstArray(intSystem - 1, 0))
            If lstSystems.GetItemChecked(intSystem - 1) = True Then 'yes we want to download this specific system

                strSIN = SendCMD("SIN," & intSin)
                If strSIN = "ERR" Then
                    sngErr += 1
                    GenLog(("Can't download system, may need to requeue"))
                End If
                If strSIN <> "ERR" And strSIN <> "-1" And Not bAbortPressed Then 'if everything is good, make a new system
                    'what kind of system is this?
                    If ParaParse(strSIN, 1) = "CNV" Then
                        intSitesFound += 1
                        lblSiteNote.MakeNewConvSystem()
                        intSys = intCurrentSys
                        intCurrentGroup = 0
                        DownloadQSL() 'download system quick key status
                        varSite(intSys, 0, 0, 1) = ParaParse(strSIN, 2) 'name
                        varSite(intSys, 0, 0, 4) = ParaParse(strSIN, 3) 'quick key
                        varSite(intSys, 0, 0, 7) = ParaParse(strSIN, 17) 'startup key
                        varSite(intSys, 0, 0, 5) = ParaParse(strSIN, 4) 'hold time
                        varSite(intSys, 0, 0, 2) = ParaParse(strSIN, 5) 'lockout
                        varSite(intSys, 0, 0, 6) = ParaParse(strSIN, 6) 'delay
                        varSite(intSys, 0, 0, 9) = CStr(Val(ParaParse(strSIN, 7))) 'data skip
                        varSite(intSys, 0, 0, 24) = ParaParse(strSIN, 18) 'Tape out
                        varSite(intSys, 0, 0, 34) = "0" ' No changes have been made to this system
                        'State

                        If blnBC15 Then
                            strBuff = ParaParse(strSIN, 23)
                            varSite(intSys, 0, 0, 33) = GetStateIndex(strBuff)
                        ElseIf bln15XT Then
                            strBuff = ParaParse(strSIN, 28)
                            varSite(intSys, 0, 0, 33) = GetStateIndex(strBuff)
                        End If
                        If blnXT = False Then
                            varSite(intSys, 0, 0, 19) = ParaParse(strSIN, 19) 'lat
                            varSite(intSys, 0, 0, 20) = ParaParse(strSIN, 20) 'long
                            varSite(intSys, 0, 0, 21) = CStr(Val(ParaParse(strSIN, 21)) / 100) 'range
                            varSite(intSys, 0, 0, 22) = ParaParse(strSIN, 22) 'gps enable
                        Else
                            varSite(intSys, 0, 0, 28) = MakeItKosherNumTag(ParaParse(strSIN, 23)) 'number tag
                            varSite(intSys, 0, 0, 29) = MakeBinary(ParaParse(strSIN, 24)) 'analog agc
                            varSite(intSys, 0, 0, 30) = MakeBinary(ParaParse(strSIN, 25))  'digital agc
                            varSite(intSys, 0, 0, 32) = MakeBinary(ParaParse(strSIN, 27)) 'system protect bit
                            If Bln396XT Or Bln996XT Then
                                varSite(intSys, 0, 0, 31) = CStr(Val(ParaParse(strSIN, 26))) 'P25 wait time
                            End If
                        End If


                        'apco stuff
                        If blnBC15 = True Or blnXT = True Then
                            varSite(intSys, 0, 0, 48) = APCOMode
                            varSite(intSys, 0, 0, 49) = APCOThreshold
                        ElseIf Bln996 Then 'every other scanner not supported or unsupported

                            strBuff = ParaParse(strSIN, 10) 'apco mode
                            If strBuff = "AUTO" Or strBuff = "MAN" Or strBuff = "DFLT" Then
                                varSite(intSys, 0, 0, 48) = strBuff
                                varSite(intSys, 0, 0, 49) = ParaParse(strSIN, 11)
                            End If
                        End If
                        'now begin group loop
                        strCurOp = "Downloading " & Trim(varSite(intSys, 0, 0, 1))
                        Call DownloadQGL(intSin, intSys)
                        'get the next group id, if any


                        intGroupIndex = Val(ParaParse(strSIN, 14))
                        'is there a group here? if so start GROUP LOOP**************************
                        blnLastGroup = False
                        intGroup = 1

                        If intGroupIndex > 0 Then
                            Do Until blnLastGroup = True Or bAbortPressed
                                'download group info
                                strGroup = SendCMD("GIN," & intGroupIndex)
                                'save group settings
                                If strGroup = "ERR" Or strGroup = "" Then
                                    GenLog(("Error downloading group " & intGroupIndex))
                                    sngErr = sngErr + 1
                                End If
                                If strGroup <> "ERR" Then
                                    intGroupsFound = intGroupsFound + 1
                                    varSite(intSys, intGroup, 0, 1) = ParaParse(strGroup, 2) 'GROUP NAME
                                    varSite(intSys, intGroup, 0, 2) = ParaParse(strGroup, 3) 'quickkey
                                    varSite(intSys, intGroup, 0, 3) = ParaParse(strGroup, 4) 'l/o status
                                    varSite(intSys, intGroup, 0, 5) = CStr(1) 'group type conv
                                    varSite(intSys, intGroup, 0, 10) = CreateGroupID()
                                    'gps stuff
                                    If blnXT = True Then
                                        varSite(intSys, intGroup, 0, 6) = ParaParse(strGroup, 11) 'latitude
                                        varSite(intSys, intGroup, 0, 7) = ParaParse(strGroup, 12) 'longtitude
                                        varSite(intSys, intGroup, 0, 8) = CStr(Val(ParaParse(strGroup, 13)) / 2) 'range
                                        varSite(intSys, intGroup, 0, 9) = ParaParse(strGroup, 14) 'gps enable
                                    Else
                                        varSite(intSys, intGroup, 0, 6) = "" 'latitude
                                        varSite(intSys, intGroup, 0, 7) = "" 'longtitude
                                        varSite(intSys, intGroup, 0, 8) = "1" 'range
                                        varSite(intSys, intGroup, 0, 9) = "0" 'gps enable
                                    End If

                                    strCurOp = "Downloading " & Trim(varSite(intSys, 0, 0, 1)) & "\" & Trim(varSite(intSys, intGroup, 0, 1))
                                    'are there any channels available
                                    blnLastChan = False

                                    intChannelIndex = Val(ParaParse(strGroup, 8))
                                    If intChannelIndex > 0 Then
                                        'begin CHANNEL LOOP***************

                                        strChan = SendCMD("CIN," & intChannelIndex)
                                        Do Until blnLastChan = True Or intChannel = -1 Or bAbortPressed
                                            intChannelsFound += 1
                                            intChannel = InsertChan(varSite(intSys, intGroup, 0, 10), True)
                                            If intChannel = -1 Then
                                                sngErr = sngErr + 1
                                                GenLog(("Insufficient memory to continue adding channels."))
                                                blnLastChan = True
                                                blnLastGroup = True
                                                intChannel = 0
                                                If Not blnNoMemDlg Then MsgBox("The number of channels in this group has exceeded memory capacity. Remaining channels ignored.")
                                                sngErr = sngErr + 1
                                                blnNoMemDlg = True
                                                intChan = 0
                                                intTGIDGroupIndex = 0
                                                blnLastSite = True
                                                intSystem = intSiteLimit
                                            End If

                                            ChanInfo(intChannel, 1) = ParaParse(strChan, 1) 'channel name
                                            ChanInfo(intChannel, 1) = MakeItKosherSilent(ChanInfo(intChannel, 1), 0)
                                            ChanInfo(intChannel, 2) = CStr(Val(ParaParse(strChan, 2)) / 10000) 'frequency
                                            ChanInfo(intChannel, 4) = RevModModeLookup(ParaParse(strChan, 3)) 'modmode
                                            ChanInfo(intChannel, 9) = ParaParse(strChan, 4) 'ctcss
                                            ChanInfo(intChannel, 11) = ParaParse(strChan, 5) 'TONE lockout
                                            ChanInfo(intChannel, 5) = ParaParse(strChan, 6) 'lockout
                                            ChanInfo(intChannel, 7) = ParaParse(strChan, 7) 'priority
                                            ChanInfo(intChannel, 6) = ParaParse(strChan, 8) 'attenuation
                                            ChanInfo(intChannel, 8) = ParaParse(strChan, 9) 'alert  tone type
                                            ChanInfo(intChannel, 13) = ParaParse(strChan, 10) 'alert level
                                            ChanInfo(intChannel, 3) = ParaParse(strChan, 15) 'tape out
                                            If Bln996 Or Bln396XT Or Bln996XT Then
                                                ChanInfo(intChannel, 12) = ParaParse(strChan, 16) 'audio type
                                            Else
                                                If ChanInfo(intChannel, 9) = "0" Then 'is ctcss off?
                                                    ChanInfo(intChannel, 12) = CStr(0) 'set audio type to ALL
                                                Else
                                                    ChanInfo(intChannel, 12) = "1" 'set type to analog
                                                End If
                                            End If
                                            If blnXT Then
                                                ChanInfo(intChannel, 16) = ParaParse(strChan, 18) 'Number Tag
                                                ChanInfo(intChannel, 18) = ChgAlertCode(ParaParse(strChan, 20), strMDL) 'alert pattern
                                                If ParaParse(strChan, 20) <> "0" Then
                                                    ChanInfo(intChannel, 17) = "RED"
                                                End If
                                                ChanInfo(intChannel, 20) = ParaParse(strChan, 21) ' volume offset
                                            End If
                                            If Bln396XT Or Bln996XT Then  'P25 NAC and color
                                                ChanInfo(intChannel, 15) = ParaParse(strChan, 17)
                                                ChanInfo(intChannel, 17) = ParaParse(strChan, 19)  'color
                                            End If
                                            'is there another channel after this?

                                            If Val(ParaParse(strChan, 12)) > 0 Then
                                                'get the info for the next loop
                                                intChannelIndex = Val(ParaParse(strChan, 12))
                                                strChan = SendCMD("CIN," & intChannelIndex)
                                            Else
                                                blnLastChan = True
                                            End If
                                        Loop  'END CHANNEL LOOP
                                    End If 'channel loop if
                                End If 'strgrp<>ERR if

                                'is there another group to download after this one?

                                If Val(ParaParse(strGroup, 6)) > 0 Then
                                    intGroupIndex = Val(ParaParse(strGroup, 6))
                                    strGroup = SendCMD("GIN," & intGroupIndex)
                                    intGroup += 1
                                Else
                                    blnLastGroup = True
                                End If
                            Loop  'END GROUP LOOP
                        End If
                    Else 'actions for a trunked system
                        'this is handled, similarly but different to conv systems

                        RadioSetting(20) = CStr(CInt(RadioSetting(20)) + 1)
                        lblSiteNote.blnSkipGroup = True
                        lblSiteNote.MakeNewTrunkSystem(3)
                        intSys = intCurrentSys
                        lblSiteNote.blnSkipGroup = False

                        If intSys = -1 Or intSys = 0 Then
                            intSys = 1
                            MsgBox("Sorry, but the maximum number of systems has been reached. No more can be downloaded")
                            Form1.msc.Close()
                            sngErr += 1
                            Exit Sub
                        End If
                        varSite(intSys, 0, 0, 3) = RevSysTypeLookup(ParaParse(strSIN, 1)) 'system type
                        varSite(intSys, 0, 0, 1) = ParaParse(strSIN, 2) 'name
                        varSite(intSys, 0, 0, 6) = CStr(Val(ParaParse(strSIN, 6))) 'delay
                        varSite(intSys, 0, 0, 24) = CStr(Val(ParaParse(strSIN, 18))) 'Tape out
                        varSite(intSys, 0, 0, 34) = "0" ' No changes have been made to this system
                        If blnXT Then
                            varSite(intSys, 0, 0, 28) = ParaParse(strSIN, 23) 'number tag
                            varSite(intSys, 0, 0, 29) = ParaParse(strSIN, 24) 'analog agc
                            varSite(intSys, 0, 0, 30) = CStr(Val(ParaParse(strSIN, 25))) 'digital tag
                            varSite(intSys, 0, 0, 31) = CStr(Val(ParaParse(strSIN, 26))) 'p25 wait time
                            varSite(intSys, 0, 0, 32) = CStr(Val(ParaParse(strSIN, 27))) 'system protect on/off
                        Else
                            varSite(intSys, 0, 0, 28) = "NONE" 'number tag
                            varSite(intSys, 0, 0, 29) = "0" 'analog agc
                            varSite(intSys, 0, 0, 30) = "0" 'digital tag
                            varSite(intSys, 0, 0, 31) = "400" 'p25 wait time
                            varSite(intSys, 0, 0, 32) = "0" 'system protect on/off
                        End If
                        strCurOp = "Downloading " & Trim(varSite(intSys, 0, 0, 1))

                        Call DownloadQGL(intSin, intSys)
                        'download TGID lockout list
                        Call DownloadGLI(varSite(intSys, 0, 0, 23), CStr(intSin))
                        'download all the trunking paramaters

                        strTrunk = SendCMD("TRN," & intSin)
                        If Len(strTrunk) < 4 Then
                            sngErr += 1
                            Call GenLog("Invalid response for trunk settings [" & Trim(varSite(intSys, 0, 0, 1)) & "]")
                        End If
                        If Len(strTrunk) > 3 Then

                            intTGIDGroupIndex = Val(ParaParse(strTrunk, 21)) 'save index of first TGID group
                            'begin extracting all the trunking information
                            varSite(intSys, 0, 0, 11) = ParaParse(strTrunk, 1) 'id search on/off
                            varSite(intSys, 0, 0, 12) = ParaParse(strTrunk, 2) 'motorola status bit
                            If blnXT = False Then
                                varSite(intSys, 0, 0, 13) = ParaParse(strTrunk, 3) 'end code
                                varSite(intSys, 0, 0, 27) = CStr(Val(ParaParse(strTrunk, 20))) 'digital end code
                                varSite(intSys, 0, 0, 50) = "0" 'motorola hex/dec format
                                varSite(intSys, 0, 0, 52) = "0" 'emerg ID pattern
                                varSite(intSys, 0, 0, 54) = "0" 'pri ID scan on/off
                                varSite(intSys, 0, 0, 51) = "OFF" 'emerg light colour
                                varSite(intSys, 0, 0, 53) = "0" 'P25 NAC search
                            Else
                                strBuff = ParaParse(strTrunk, 3)
                                If strBuff = "2" Then 'digital and analog end codes on
                                    varSite(intSys, 0, 0, 13) = "1" 'end code
                                    varSite(intSys, 0, 0, 27) = "1" 'digital end code
                                ElseIf strBuff = "1" Then
                                    varSite(intSys, 0, 0, 13) = "1" 'end code
                                    varSite(intSys, 0, 0, 27) = "0" 'digital end code
                                Else
                                    varSite(intSys, 0, 0, 13) = "0" 'end code
                                    varSite(intSys, 0, 0, 27) = "0" 'digital end code

                                End If
                                varSite(intSys, 0, 0, 50) = CStr(Val(ParaParse(strTrunk, 25))) 'motorola hex/dec format
                                varSite(intSys, 0, 0, 52) = ChgAlertCode(CStr(Val(ParaParse(strTrunk, 27))), strMDL) 'emerg ID pattern

                                varSite(intSys, 0, 0, 54) = MakeBinary(ParaParse(strTrunk, 29)) 'pri ID scan on/off
                                If Bln396XT Or Bln996XT Then
                                    varSite(intSys, 0, 0, 51) = ParaParse(strTrunk, 26) 'emerg light colour
                                    varSite(intSys, 0, 0, 53) = CStr(ParaParse(strTrunk, 28)) 'P25 NAC search
                                Else
                                    If blnXT And ParaParse(strTrunk, 26) <> "0" Then
                                        varSite(intSys, 0, 0, 51) = "RED"
                                    Else
                                        varSite(intSys, 0, 0, 51) = "OFF"
                                    End If
                                    varSite(intSys, 0, 0, 51) = "OFF" 'emerg light colour
                                    varSite(intSys, 0, 0, 53) = "0" 'P25 NAC search
                                End If
                                '*******************set this to a type I system if the right conditions are met

                                If varSite(intSys, 0, 0, 3) = "3" And ParaParse(strTrunk, 10) <> "00000000" And blnXT = True Then
                                    'must be a type I system since it has a non standard fleetmap
                                    varSite(intSys, 0, 0, 3) = "2"
                                ElseIf varSite(intSys, 0, 0, 3) = "3" And Val(ParaParse(strTrunk, 9)) <= 15 And ParaParse(strTrunk, 9) <> "" And blnXT = True Then
                                    'a preset fleetmap is in use, set to type I
                                    varSite(intSys, 0, 0, 3) = "2"
                                End If
                            End If
                            varSite(intSys, 0, 0, 14) = ParaParse(strTrunk, 4) 'AFS mode
                            varSite(intSys, 0, 0, 15) = CStr(Val(ParaParse(strTrunk, 5))) 'i call
                            varSite(intSys, 0, 0, 25) = ParaParse(strTrunk, 7) 'emerg alert type
                            varSite(intSys, 0, 0, 26) = ParaParse(strTrunk, 8) 'emerg alert level
                            varSite(intSys, 0, 0, 16) = CStr(Val(ParaParse(strTrunk, 9))) 'Fleet Map #
                            varSite(intSys, 0, 0, 17) = RevFleetMap(ParaParse(strTrunk, 10)) 'Custom Fleet Map
                            '************************START SITE DOWNLOAD LOOP
                            blnLastSite = False
                            intSite = 0
                            intSiteIndex = Val(ParaParse(strSIN, 14))
                            Do Until blnLastSite = True Or bAbortPressed
                                'is there a site to download?
                                If intSiteIndex > 0 Then
                                    'yes, download site
                                    intSite += 1
                                    intSitesFound += 1
                                    intCurrentGroup = intSite
                                    strSIF = SendCMD("SIF," & intSiteIndex)
                                    'create a new site and record paramaters
                                    If blnXT = False Then
                                        varSite(intSys, intSite, 0, 9) = RevSiteTypeLookup(ParaParse(strSIF, 1)) 'site type
                                    Else 'set the site type based on system type
                                        Call SetSiteType(Val(CStr(intSys)), intSite, strSIF)
                                    End If

                                    varSite(intSys, intSite, 0, 1) = ParaParse(strSIF, 2) 'name
                                    If varSite(intSys, intSite, 0, 9) = "13" And blnXT = False Then 'download custom band plan
                                        Call DownloadMCP(Val(CStr(intSys)), intSite, intSiteIndex)
                                    End If

                                    If varSite(intSys, intSite, 0, 9) = "11" Then 'this is an edacs scat site, makeup a name
                                        varSite(intSys, intSite, 0, 1) = "EDACS Site"
                                    ElseIf varSite(intSys, intSite, 0, 9) = "12" And blnXT = False Then
                                        varSite(intSys, intSite, 0, 1) = "LTR Site"
                                    End If
                                    strCurOp = "Downloading " & Trim(varSite(intSys, 0, 0, 1)) & "\" & Trim(varSite(intSys, intSite, 0, 1))
                                    varSite(intSys, intSite, 0, 2) = ParaParse(strSIF, 3) 'quickkey
                                    varSite(intSys, intSite, 0, 4) = ParaParse(strSIF, 4) 'hold time
                                    varSite(intSys, intSite, 0, 3) = ParaParse(strSIF, 5) 'lockout
                                    varSite(intSys, intSite, 0, 6) = ParaParse(strSIF, 6) 'modmode
                                    varSite(intSys, intSite, 0, 7) = ParaParse(strSIF, 7) 'att
                                    varSite(intSys, intSite, 0, 8) = ParaParse(strSIF, 8) 'c-ch only
                                    varSite(intSys, intSite, 0, 12) = ParaParse(strSIF, 17) 'startup key
                                    varSite(intSys, intSite, 0, 13) = ParaParse(strSIF, 18) 'lat
                                    varSite(intSys, intSite, 0, 14) = ParaParse(strSIF, 19) 'long
                                    If blnXT = False Then
                                        varSite(intSys, intSite, 0, 15) = CStr(Val(ParaParse(strSIF, 20)) / 100) 'range
                                    Else
                                        varSite(intSys, intSite, 0, 15) = CStr(Val(ParaParse(strSIF, 20)) / 2) 'range
                                    End If
                                    varSite(intSys, intSite, 0, 16) = ParaParse(strSIF, 21) 'gps enable
                                    varSite(intSys, intSite, 0, 5) = "3"
                                    varSite(intSys, intSite, 0, 10) = CreateGroupID()
                                    'state
                                    If blnBC15 Or bln15XT Then
                                        strBuff = ParaParse(strSIF, 22)
                                        varSite(intSys, intSite, 0, 32) = GetStateIndex(strBuff)
                                    End If
                                    'apco stuff
                                    If Bln396XT Or Bln996XT Then
                                        varSite(intSys, intSite, 0, 61) = CStr(Val(ParaParse(strSIF, 25))) 'p25 wait time
                                    Else
                                        varSite(intSys, intSite, 0, 61) = "0"
                                    End If
                                    If Bln996 = False Then
                                        varSite(intSys, intSite, 0, 26) = APCOMode
                                        varSite(intSys, intSite, 0, 27) = APCOThreshold
                                    Else
                                        strBuff = ParaParse(strSIF, 9) 'apco mode
                                        If strBuff = "AUTO" Or strBuff = "MAN" Or strBuff = "DFLT" Then
                                            varSite(intSys, intSite, 0, 26) = strBuff
                                            varSite(intSys, intSite, 0, 27) = ParaParse(strSIF, 10)
                                        End If
                                    End If
                                    'motorola band plan
                                    If blnXT = False And varSite(intSys, intSite, 0, 9) <> "13" Then
                                        strMBP = SendCMD("MBP," & intSiteIndex)
                                        Call SaveBPParam(intSys, intSite, 0, 0, CStr(Val(ParaParse(strMBP, 1)))) 'base 1
                                        Call SaveBPParam(intSys, intSite, 2, 0, CStr(Val(ParaParse(strMBP, 2)))) 'step 1
                                        Call SaveBPParam(intSys, intSite, 3, 0, CStr(Val(ParaParse(strMBP, 3)))) 'offset 1
                                        Call SaveBPParam(intSys, intSite, 0, 1, CStr(Val(ParaParse(strMBP, 4)))) 'base 1
                                        Call SaveBPParam(intSys, intSite, 2, 1, CStr(Val(ParaParse(strMBP, 5)))) 'step 1
                                        Call SaveBPParam(intSys, intSite, 3, 1, CStr(Val(ParaParse(strMBP, 6)))) 'offset 1
                                        Call SaveBPParam(intSys, intSite, 0, 2, CStr(Val(ParaParse(strMBP, 7)))) 'base 1
                                        Call SaveBPParam(intSys, intSite, 2, 2, CStr(Val(ParaParse(strMBP, 8)))) 'step 1
                                        Call SaveBPParam(intSys, intSite, 3, 2, CStr(Val(ParaParse(strMBP, 9)))) 'offset 1
                                    Else
                                        Call DownloadMCP(Val(CStr(intSys)), intSite, intSiteIndex)
                                    End If
                                    '****************APCO band plan
                                    If Val(varSite(intSys, intSite, 0, 9)) = 6 Or varSite(intSys, intSite, 0, 9) = "14" Then 'this is a P25 site, download apco band plan
                                        Call CommonABP(intSys, intSite, intSiteIndex)
                                    End If
                                    intSiteIndex = Val(ParaParse(strSIF, 12))
                                    varSite(intSys, 0, 0, 10) = CStr(Val(varSite(intSys, 0, 0, 10)) + 1)
                                    intTrunkIndex = Val(ParaParse(strSIF, 14)) 'this gets the first memory location for the trunk frequencies
                                    If intTrunkIndex > 0 Then
                                        '*************************START TRUNKING FREQUENCY LOOP
                                        blnLastChan = False
                                        intChan = 1
                                        ResponseCode = SendCMD("TFQ," & intTrunkIndex) 'get the first TFQ
                                        Do Until blnLastChan = True Or blnNoMoreMem = True Or bAbortPressed
                                            'advance to next
                                            intTrunkIndex = Val(ParaParse(ResponseCode, 5))
                                            intCurrTrn = InsertTrunkFreq(varSite(intSys, intSite, 0, 10))
                                            If intCurrTrn = -1 Then
                                                MsgBox("Reached maximum amount of trunk frequencies that can be stored. Remaining will be ignored.")
                                                blnLastChan = True
                                                sngErr = sngErr + 1
                                                GenLog(("Out of memory"))
                                                blnNoMoreMem = True
                                            ElseIf intCurrTrn >= 0 Then
                                                intChannelsFound += 1
                                                strCurOp = "Downloading " & Trim(varSite(intSys, 0, 0, 1)) & "\" & Trim(varSite(intSys, intSite, 0, 1)) & "\Trunk Frequencies"
                                                strTrunkFreq(intCurrTrn, 0) = CStr(Val(ParaParse(ResponseCode, 1)) / 10000)
                                                strTrunkFreq(intCurrTrn, 1) = CStr(Val(ParaParse(ResponseCode, 2))) 'lcn
                                                strTrunkFreq(intCurrTrn, 3) = CStr(Val(ParaParse(ResponseCode, 3))) 'lockout
                                                If blnXT Then
                                                    strTrunkFreq(intCurrTrn, 4) = CStr(Val(ParaParse(ResponseCode, 9))) 'num tag
                                                    strTrunkFreq(intCurrTrn, 5) = CStr(Val(ParaParse(ResponseCode, 10))) 'volume offset
                                                    'change site type to 900MHz - for greater compatibility for going from XT to non XT scanner
                                                    If varSite(intSys, intSite, 0, 9) = "1" And Val(strTrunkFreq(intCurrTrn, 0)) > 900 Then
                                                        'During an upload to an xt, this will change back to a 800/900 band plan
                                                        varSite(intSys, intSite, 0, 9) = "3"
                                                    End If
                                                End If
                                                If Bln996XT Or bln15XT Then
                                                    strTrunkFreq(intCurrTrn, 6) = CStr(Val(ParaParse(ResponseCode, 8))) 'record on/off
                                                End If
                                            End If
                                            If intTrunkIndex > 0 Then 'is there another frequency to follow this one?
                                                'grab it and get ready for the next loop
                                                intChan += 1
                                                ResponseCode = SendCMD("TFQ," & ParaParse(ResponseCode, 5))
                                            Else
                                                blnLastChan = True
                                            End If
                                        Loop  'trunk frequencies loop
                                    End If 'are there any trunking frequencies?
                                Else 'no more sites to download
                                    blnLastSite = True
                                End If 'is this a valid site?
                            Loop
                            'next, associated trunking frequencies need to be downloaded
                            'START TGID LOOP**********************
                            intGroup = intSite
                            intGroup += 1
                            intTGIDGroupIndex = Val(ParaParse(SendCMD("TRN," & intSin), 21))
                            If intTGIDGroupIndex > 0 Then 'are there any TGID groups to download?

                                Do Until intTGIDGroupIndex < 1 Or bAbortPressed
                                    intGroupsFound += 1
                                    ResponseCode = SendCMD("GIN," & intTGIDGroupIndex) 'get the basic group info
                                    If ResponseCode = "" Then
                                        sngErr = sngErr + 1
                                        Call GenLog("No response to group D/L")
                                    End If
                                    'save basic group info
                                    varSite(intSys, intGroup, 0, 1) = ParaParse(ResponseCode, 2) 'group name
                                    varSite(intSys, intGroup, 0, 2) = ParaParse(ResponseCode, 3) 'quick key name
                                    varSite(intSys, intGroup, 0, 3) = ParaParse(ResponseCode, 4) 'l/o status name
                                    varSite(intSys, intGroup, 0, 5) = CStr(2) 'group type trunk
                                    varSite(intSys, intGroup, 0, 10) = CreateGroupID()
                                    'gps stuff
                                    If blnXT Then
                                        varSite(intSys, intGroup, 0, 6) = ParaParse(ResponseCode, 11) 'latitude
                                        varSite(intSys, intGroup, 0, 7) = ParaParse(ResponseCode, 12) 'longtitude
                                        varSite(intSys, intGroup, 0, 8) = CStr(Val(ParaParse(ResponseCode, 13)) / 2) 'range
                                        varSite(intSys, intGroup, 0, 9) = ParaParse(ResponseCode, 14) 'gps enable
                                    Else
                                        varSite(intSys, intGroup, 0, 6) = "" 'latitude
                                        varSite(intSys, intGroup, 0, 7) = "" 'longtitude
                                        varSite(intSys, intGroup, 0, 8) = "1" 'range
                                        varSite(intSys, intGroup, 0, 9) = "0" 'gps enable
                                    End If

                                    strCurOp = "Downloading " & Trim(varSite(intSys, 0, 0, 1)) & "\" & Trim(varSite(intSys, intGroup, 0, 1))
                                    If intGroup = MaxGroups Then intTGIDGroupIndex = -1
                                    intChannelIndex = Val(ParaParse(ResponseCode, 8)) ' get channel index
                                    If intChannelIndex > 0 Then 'are there any channel present? if so start another loop
                                        Do Until intChannelIndex < 1
                                            intChan = InsertChan(varSite(intSys, intGroup, 0, 10), False)
                                            CResponseCode = SendCMD("TIN," & intChannelIndex)
                                            If intChan = -1 Then
                                                Call GenLog("Out of memory")
                                                intChannelIndex = -1
                                                If Not blnNoMemDlg Then MsgBox("The number of channels in this group has exceeded memory capacity. Remaining channels ignored.")
                                                sngErr += 1
                                                blnNoMemDlg = True
                                                intChan = 0
                                                intTGIDGroupIndex = 0
                                                blnLastSite = True
                                                intSystem = intSiteLimit
                                            Else
                                                'save basic channel info
                                                ChanInfo(intChan, 1) = ParaParse(CResponseCode, 1) 'name
                                                ChanInfo(intChan, 1) = MakeItKosherSilent(ChanInfo(intChan, 1), 0)

                                                ChanInfo(intChan, 2) = ParaParse(CResponseCode, 2) 'TGID
                                                ChanInfo(intChan, 3) = ParaParse(CResponseCode, 3) 'lockout status
                                                ChanInfo(intChan, 4) = ParaParse(CResponseCode, 5) 'alert type
                                                ChanInfo(intChan, 5) = ParaParse(CResponseCode, 6) 'alert level
                                                ChanInfo(intChan, 7) = MakeBinary(ParaParse(CResponseCode, 11)) 'tape out
                                                If blnXT = False Then
                                                    If Bln996 = True Then
                                                        ChanInfo(intChan, 6) = CStr(Val(ParaParse(CResponseCode, 12))) 'audio type
                                                    Else
                                                        ChanInfo(intChan, 6) = "0" 'audio type set to all on BC15
                                                    End If
                                                ElseIf Bln396XT Or Bln996XT Then
                                                    ChanInfo(intChan, 19) = ParaParse(CResponseCode, 13) 'number tag
                                                    ChanInfo(intChan, 20) = ParaParse(CResponseCode, 14) 'alert color
                                                    ChanInfo(intChan, 21) = ParaParse(CResponseCode, 15) 'alert pat
                                                    ChanInfo(intChan, 22) = ParaParse(CResponseCode, 16) 'volume offset
                                                    ChanInfo(intChan, 6) = CStr(Val(ParaParse(CResponseCode, 12)))   'audio type
                                                    ChanInfo(intChan, 8) = MakeBinary(ParaParse(CResponseCode, 4))   'priority
                                                ElseIf bln346 Or bln15XT Then
                                                    ChanInfo(intChan, 19) = ParaParse(CResponseCode, 13) 'number tag
                                                    ChanInfo(intChan, 20) = "OFF" 'alert color
                                                    ChanInfo(intChan, 21) = ChgAlertCode(ParaParse(CResponseCode, 15), strMDL) 'alert pat
                                                    If ParaParse(CResponseCode, 15) <> "0" Then
                                                        ChanInfo(intChan, 20) = "RED"
                                                    End If
                                                    ChanInfo(intChan, 22) = ParaParse(CResponseCode, 16) 'volume offset
                                                    ChanInfo(intChan, 8) = MakeBinary(ParaParse(CResponseCode, 4))   'priority
                                                End If
                                                intChannelsFound += 1
                                                intChannelIndex = Val(ParaParse(CResponseCode, 8))
                                            End If 'is there any memory left?
                                        Loop  'end channel loop
                                    End If
                                    intGroup += 1
                                    varSite(intSys, 0, 0, 10) = CStr(Val(varSite(intSys, 0, 0, 10)) + 1)
                                    'grab the next group, if there is one
                                    intTGIDGroupIndex = Val(ParaParse(ResponseCode, 6))
                                Loop  'end group loop
                            End If ' end main tgid group if
                        End If
                    End If
                End If
            End If
            If bAbortPressed Then
                intSystem = intSiteLimit
            End If
        Next intSystem

        If chkDownloadCustomSettings.CheckState = 1 And Not bAbortPressed Then 'download custom radio settings to memory
            strCurOp = "Downloading scanner settings..."
            Response = SendCMD("PRI")
            If blnXT Then
                RadioSetting(3) = ParaParse(Response, 1) 'mode
                RadioSetting(89) = ParaParse(Response, 2) 'max chan
                RadioSetting(93) = ParaParse(Response, 3) 'interval 
                DownloadDBC(strMDL)
            Else
                RadioSetting(3) = Response
                RadioSetting(89) = "100"
                RadioSetting(93) = "10"
            End If
            'Download Service Search settings
            For intChan = 1 To 13
                strSS(intChan, 5) = "." 'qk
                strSS(intChan, 6) = "." 'startup key
                strSS(intChan, 7) = CStr(1) 'record out 
                If intChan = 13 Then intChan = 15
                Response = SendCMD("SSP," & intChan)
                If intChan = 15 Then intChan = 13
                If Response <> "ERR" Then
                    strSS(intChan, 2) = ParaParse(Response, 2)
                    strSS(intChan, 3) = ParaParse(Response, 3)
                    strSS(intChan, 4) = ParaParse(Response, 4)
                    strSS(intChan, 8) = ParaParse(Response, 5) 'lockout
                    strSS(intChan, 5) = ParaParse(Response, 6) 'quick key
                    strSS(intChan, 6) = ParaParse(Response, 7) 'startup key
                    If blnXT = False Then
                        strSS(intChan, 7) = ParaParse(Response, 8) 'record out
                        strSSXT(intChan, 1) = "1"
                        strSSXT(intChan, 2) = "1"
                        strSSXT(intChan, 3) = "0" 'p25 wait time
                        strSSXT(intChan, 4) = "NONE" 'num tag
                    ElseIf blnXT Then
                        strSS(intChan, 7) = "1" 'record out
                        strSSXT(intChan, 1) = MakeBinary(ParaParse(Response, 10)) 'analog agc
                        strSSXT(intChan, 2) = MakeBinary(ParaParse(Response, 11)) 'digital agc
                        strSSXT(intChan, 3) = CStr(Val(ParaParse(Response, 12)))  'p25 wait time
                        strSSXT(intChan, 4) = ParaParse(Response, 9) 'num tag
                    End If
                End If


            Next intChan
            Response = SendCMD("KBP")
            RadioSetting(4) = ParaParse(Response, 1)
            If blnXT = True Then
                RadioSetting(104) = MakeBinary(ParaParse(Response, 2)) 'key lock
                RadioSetting(105) = MakeBinary(ParaParse(Response, 3)) 'key safe
            Else
                RadioSetting(104) = "0"
                RadioSetting(105) = "0"
            End If
            'battery charge setting
            If Bln396XT Or bln346 Then
                Response = SendCMD("BSV")
                RadioSetting(86) = CStr(Val(ParaParse(Response, 1)))  'battery save on/off
                RadioSetting(107) = CStr(Val(ParaParse(Response, 2))) 'battery charge time
            End If
            DownloadGDO() 'GPS settings
            DownloadSCN(blnXT) 'lcd setting
            strSIN = SendCMD("OMS")
            CommonWX()
            If bln346 Or bln15XT Then
                blnYeah = True
            Else
                blnYeah = False
            End If
            Call CommonToneOut(blnXT, blnYeah)
            RadioSetting(5) = ParaParse(strSIN, 1)
            RadioSetting(6) = ParaParse(strSIN, 2)
            RadioSetting(22) = ParaParse(strSIN, 3)
            RadioSetting(23) = ParaParse(strSIN, 4)
            strSIN = SendCMD("CLC") 'close call setting
            RadioSetting(7) = ParaParse(strSIN, 1) 'close call mode
            RadioSetting(8) = ParaParse(strSIN, 2) 'cc override
            RadioSetting(13) = ParaParse(strSIN, 4) 'calert beep type
            RadioSetting(15) = ParaParse(strSIN, 5) 'alert level
            RadioSetting(11) = ParaParse(strSIN, 6) 'cc pause
            RadioSetting(14) = ParaParse(strSIN, 7) 'cc bands
            RadioSetting(10) = ParaParse(strSIN, 8) 'cc l/o hits with scan
            If blnXT = True Then
                RadioSetting(98) = MakeItKosherNumTag(ParaParse(strSIN, 11)) ' number tag
                ALT_COLOR = ParaParse(strSIN, 12)
                Alt_Pattern = ParaParse(strSIN, 13)
                If bln346 Or bln15XT Then
                    If Alt_Pattern <> "0" Then
                        ALT_COLOR = "RED"
                    Else
                        ALT_COLOR = "OFF"
                    End If
                End If
                RadioSetting(100) = ChgAlertCode(Alt_Pattern, strMDL)
                RadioSetting(99) = ALT_COLOR
            Else
                'make default setting
                RadioSetting(98) = "NONE"
                RadioSetting(99) = "OFF"
                RadioSetting(100) = "0"
            End If
            'RadioSetting() = ParaParse(strSIN, 9) 'hold time cc hits with scan not implemented????
            RadioSetting(9) = ParaParse(strSIN, 10) 'cc quick key
            strSIN = SendCMD("SCO")
            RadioSetting(17) = RevStepLookup(ParaParse(strSIN, 1)) 'search step
            RadioSetting(18) = ParaParse(strSIN, 2) 'mod type
            RadioSetting(33) = ParaParse(strSIN, 3) 'atten
            RadioSetting(21) = ParaParse(strSIN, 4) 'delay
            RadioSetting(40) = ParaParse(strSIN, 5) 'data skip
            RadioSetting(24) = ParaParse(strSIN, 6) 'code search
            RadioSetting(43) = ParaParse(strSIN, 7) 'pager screen
            RadioSetting(41) = ParaParse(strSIN, 8) 'repeater find
            RadioSetting(32) = ParaParse(strSIN, 11) 'max auto store
            If blnXT = False Then
                RadioSetting(42) = ParaParse(strSIN, 12) 'tape out mode
                RadioSetting(101) = "1" 'agc analog
                RadioSetting(102) = "1"  ' agc digital
                RadioSetting(103) = "0" 'p25 wait time
            ElseIf bln346 Then
                RadioSetting(42) = "1" 'tape out mode
                RadioSetting(101) = "1" 'agc analog
                RadioSetting(102) = "1"  ' agc digital
                RadioSetting(103) = "0" 'p25 wait time
            ElseIf Bln396XT Then
                RadioSetting(42) = "1" 'tape out mode
                RadioSetting(101) = ParaParse(strSIN, 13) 'agc analog
                RadioSetting(102) = ParaParse(strSIN, 14)  ' agc digital
                RadioSetting(103) = ParaParse(strSIN, 15)  'p25 wait time
            ElseIf Bln996XT Then
                RadioSetting(42) = ParaParse(strSIN, 12)  'tape out mode
                RadioSetting(101) = ParaParse(strSIN, 13) 'agc analog
                RadioSetting(102) = ParaParse(strSIN, 14)  ' agc digital
                RadioSetting(103) = ParaParse(strSIN, 15)  'p25 wait time
            ElseIf bln15XT Then
                RadioSetting(42) = ParaParse(strSIN, 12)  'tape out mode
                RadioSetting(101) = "1" 'agc analog
                RadioSetting(102) = "1"  ' agc digital
                RadioSetting(103) = "0" 'p25 wait time
            End If
            'search key assignments

            Response = SendCMD("SHK")
            If Bln996 = False Then
                cnt = 3
            Else
                cnt = 6
            End If
            For x = 1 To cnt
                strBuff = ParaParse(Response, x)
                If strBuff = "FRS/GMRS/MURS" Then
                    strBuff = "FRS/GMRS"
                End If
                RadioSetting(33 + x) = strBuff
            Next x
            lstSystems.Enabled = True

            'AGC control - Not set at this level on the XT
            If blnXT = False Then
                Response = SendCMD("AGV")
                RadioSetting(25) = CStr(Val(ParaParse(Response, 1))) 'analog agc
                If Bln996 = True Then
                    RadioSetting(26) = CStr(Val(ParaParse(Response, 2))) 'digital agc
                Else
                    RadioSetting(26) = "0" 'always 0 for 15
                End If
            Else
                RadioSetting(25) = CStr(1)
                RadioSetting(26) = CStr(1)
            End If
            'Default state
            If bln15XT Or blnBC15 Then
                Response = SendCMD("STT")
                For x = 0 To 67
                    If Response = varState(x, 0) Then
                        RadioSetting(109) = CStr(x)
                        Exit For
                    End If
                Next
            End If
            'set BKL defaults

            If blnBC15 Or Bln996 Then
                CommonAGC(("AGS")) 'advanced agc settings
                DownloadDUD()
                strSIN = SendCMD("BKL") 'backlight setting
                RadioSetting(1) = ParaParse(strSIN, 1)
                RadioSetting(2) = ParaParse(strSIN, 2)
                If blnBC15 Then
                    RadioSetting(2) = "RED"
                End If
                RadioSetting(95) = "2"
            ElseIf Bln396XT Then
                'need custom command to download backlight
                strSIN = SendCMD("BLT") 'backlight setting
                If ParaParse(strSIN, 1) <> "ERR" Then
                    RadioSetting(85) = ParaParse(strSIN, 1) 'bk mode
                    RadioSetting(2) = ParaParse(strSIN, 2) 'bk color
                    RadioSetting(95) = CStr(Val(ParaParse(strSIN, 3))) 'bk dimmer
                End If
                If Bln325P2 Then
                    RadioSetting(2) = "RED"
                End If
                'download AGC settings for 396xt
                Response = SendCMD("AGV")
                strPad = Split(Response, ",")
                If UBound(strPad) = 6 Then
                    RadioSetting(87) = Nothing
                    RadioSetting(87) &= strPad(2) & ","
                    RadioSetting(87) &= strPad(3) & ","
                    RadioSetting(87) &= strPad(4) & ","
                    RadioSetting(87) &= strPad(5) & ","
                    RadioSetting(87) &= strPad(6)
                End If
            ElseIf bln346 Then
                strSIN = SendCMD("BLT")
                If ParaParse(strSIN, 1) <> "ERR" Then
                    RadioSetting(85) = ParaParse(strSIN, 1)
                    RadioSetting(2) = "RED"
                    RadioSetting(95) = CStr(Val(ParaParse(strSIN, 3)))
                End If
                RadioSetting(87) = ",,,,"
            ElseIf Bln996XT Then
                'need custom command to download backlight
                strSIN = SendCMD("BKL") 'backlight setting
                If ParaParse(strSIN, 1) <> "ERR" Then
                    RadioSetting(1) = ParaParse(strSIN, 1) 'bk mode
                    RadioSetting(2) = ParaParse(strSIN, 2) 'bk color
                Else
                    sngErr += 1
                    GenLog("Error downloading backlight setting")
                End If
                'download AGC settings for 996xt
                Response = SendCMD("AGV")
                strPad = Split(Response, ",")
                If UBound(strPad) = 6 Then
                    RadioSetting(87) = Nothing
                    RadioSetting(87) &= strPad(2) & ","
                    RadioSetting(87) &= strPad(3) & ","
                    RadioSetting(87) &= strPad(4) & ","
                    RadioSetting(87) &= strPad(5) & ","
                    RadioSetting(87) &= strPad(6)
                End If
            ElseIf bln15XT Then
                strSIN = SendCMD("BKL") 'backlight setting
                If ParaParse(strSIN, 1) <> "ERR" Then
                    RadioSetting(1) = ParaParse(strSIN, 1) 'bk mode
                End If
                RadioSetting(2) = "RED"
                RadioSetting(87) = ",,,,"
            End If

            'broadcast screen settings
            x = 0
            For cnt = 0 To 19 Step 2
                x = x + 1
                If x = 10 Then x = 0
                strCMD(0) = "BBS," & x
                Response = SendCMD(strCMD(0))
                RadioSetting(51 + cnt) = CStr(Val(ParaParse(Response, 1)) / 10000)
                RadioSetting(52 + cnt) = CStr(Val(ParaParse(Response, 2)) / 10000)
            Next cnt
            'GLOBAL FREQ LOCKOUT
            blnDone = False

            System.Array.Clear(strSearchLockout, 0, strSearchLockout.Length)
            intChan = 0
            Do Until blnDone = True
                strSIN = SendCMD("GLF")
                Select Case strSIN
                    Case "-1"
                        blnDone = True
                    Case "ERR"
                        blnDone = True
                    Case "FAI"
                        blnDone = True
                    Case Else
                        intChan = intChan + 1

                        strSearchLockout(intChan) = Val(strSIN) / 10000
                End Select
            Loop
            'Global IF Exchange
            If IsArray(strIFEX) Then
                System.Array.Clear(strIFEX, 0, strIFEX.Length)
            End If
            If blnXT Then
                ReDim strIFEX(2000)
                strCurOp = "Downloading Global IF Exchange list..."
                intChan = 0
                Response = SendCMD("GIE")
                Do While Val(Response) > 0 Or intChan = 2000
                    If Val(Response) > 0 Then
                        strIFEX(intChan) = Val(Response) / 10000
                        intChan += 1
                        Response = SendCMD("GIE")
                        If Response = "ERR" Then
                            sngErr += 1
                            GenLog("Error download global IF")
                        End If
                    End If
                Loop
                ReDim Preserve strIFEX(intChan + 100)
            End If

        End If


        'custom search ranges
        If chkDownloadCustomSearch.CheckState = 1 And Not bAbortPressed Then
            strCustSearchEnable = SendCMD("CSG")
            For x = 0 To 9
                intChan = x
                strChan = SendCMD("CSP," & x)
                If x = 0 Then intChan = 10
                'this is written out instead of a loop to aid in debugging
                CustSearch(intChan, 0) = ParaParse(strChan, 1) 'name
                CustSearch(intChan, 1) = CStr(Val(ParaParse(strChan, 2)) / 10000) 'low limit
                CustSearch(intChan, 2) = CStr(Val(ParaParse(strChan, 3)) / 10000) 'high limit
                CustSearch(intChan, 3) = IndexSearchStep(ParaParse(strChan, 4)) 'search step
                CustSearch(intChan, 4) = ParaParse(strChan, 5) 'modulation
                CustSearch(intChan, 5) = ParaParse(strChan, 6) 'attenuation
                CustSearch(intChan, 6) = ParaParse(strChan, 7) 'delay time
                CustSearch(intChan, 7) = ParaParse(strChan, 8) 'data skip
                CustSearch(x + 1, 8) = BinaryFlip(Val(Mid(strCustSearchEnable, x + 1, 1))) 'enabled/disabled
                CustSearch(intChan, 9) = ParaParse(strChan, 9) 'hold time
                CustSearch(intChan, 15) = ParaParse(strChan, 10) 'l/o
                CustSearch(intChan, 10) = ParaParse(strChan, 11) 'c-ch only

                CustSearch(intChan, 12) = ParaParse(strChan, 14) 'quickkey
                CustSearch(intChan, 13) = ParaParse(strChan, 15) 'startup key
                CustSearch(intChan, 16) = ""
                If blnXT = False Then
                    CustSearch(intChan, 14) = MakeBinary(ParaParse(strChan, 16)) 'tape out
                    CustSearch(intChan, 11) = "NONE"
                    CustSearch(intChan, 16) = "110000"
                ElseIf Bln396XT = True Then
                    CustSearch(intChan, 14) = "1" 'tapeout
                    CustSearch(intChan, 11) = MakeItKosherNumTag(ParaParse(strChan, 17)) 'num tag
                    CustSearch(intChan, 16) = MakeBinary(ParaParse(strChan, 18)) 'agc analog
                    CustSearch(intChan, 16) += MakeBinary(ParaParse(strChan, 19)) ' agc digital
                    CustSearch(intChan, 16) += Val(ParaParse(strChan, 20)).ToString("0000") 'p25 wait time
                ElseIf bln346 = True Then
                    CustSearch(intChan, 14) = "1" 'tapeout
                    CustSearch(intChan, 11) = MakeItKosherNumTag(ParaParse(strChan, 17))
                    CustSearch(intChan, 16) = "110000"
                ElseIf Bln996XT Then
                    CustSearch(intChan, 14) = MakeBinary(ParaParse(strChan, 16)) 'tape out
                    CustSearch(intChan, 11) = MakeItKosherNumTag(ParaParse(strChan, 17)) 'num tag
                    CustSearch(intChan, 16) = MakeBinary(ParaParse(strChan, 18)) 'agc analog
                    CustSearch(intChan, 16) += MakeBinary(ParaParse(strChan, 19)) ' agc digital
                    CustSearch(intChan, 16) += Val(ParaParse(strChan, 20)).ToString("0000") 'p25 wait time
                ElseIf bln15XT Then
                    CustSearch(intChan, 14) = MakeBinary(ParaParse(strChan, 16)) 'tape out
                    CustSearch(intChan, 11) = MakeItKosherNumTag(ParaParse(strChan, 17))
                    CustSearch(intChan, 16) = "110000"
                End If
            Next x
            If blnXT Then 'if its an xt scanner, download the custom search band plan settings
                DownloadCBP()
            End If
        End If
        If chkSysQK.CheckState = 1 Then DownloadQSL() 'download system quick key status
        Me.Enabled = True

        If Not bAbortPressed Then
            strCurOp = "Finished downloading systems. Click on 'Close' to continue"
        Else
            strCurOp = "Download aborted"
        End If
        ResponseCode = SendCMD("EPG")
        CheckResume()
        SetFinishGraphic()
        If Form1.msc.IsOpen = True Then Form1.msc.Close()
        lblSiteNote.SetFormCaption()
        If Me.Visible = True Then
            cmdClose.Focus()
        Else
            With lblSiteNote
                .DrawSystemTree()
                If sngErr = 0 Then
                    .DispStat("Download complete with no errors")
                Else
                    .DispStat("Errors during download")
                    Me.Visible = True
                End If
            End With
        End If
        bAbortPressed = False
        cmdAbortDownload.Enabled = False
        Exit Sub
criticerror:
        lblOp.Text = "ERROR " & Err.Number & " " & Err.Description
        strLog &= Err.Description
        Me.Enabled = True
        Call ErrorHandler(Err.Number, strLog)
    End Sub
    Sub SetFinishGraphic()
        If lblErr.Text = "0" Then
            IOGraphic(("D"))
        End If

    End Sub
    Function BinaryFlip(ByRef intBit As String) As Integer
        'inverts digit

        If Val(intBit) = 0 Then

            BinaryFlip = 1
        Else

            BinaryFlip = 0
        End If
    End Function



    Sub ShowComSettings()
        'displays current com port settings
        cmdSetupCom.Text = "COM" & RadioSetting(44) & " " & RadioSetting(45) & "..."
        frmCtlSetup.lblComSetting.Text = "COM:" & RadioSetting(44) & "SPEED: " & RadioSetting(45)
    End Sub
    Function MakeItKosher(ByRef strItem As String) As String
        Dim strKosher, strChar As String
        Dim intCharPos As Integer
        'cleans up a name for a group/system so it can be accepted

        strItem = Trim(strItem)
        strKosher = ""
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







    Sub cmdQueueSystems_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdQueueSystems.Click
        If blnDebug = False Then On Error GoTo CriticalError
        Dim strCMD(5) As String
        Dim strChanName, strName, strQK, strModMode As String
        Dim Response As String
        Dim dblFreq As Single
        Dim intPri As Integer
        Dim intAlert As Integer
        Dim ResponseCode As String
        Dim intSIH, intPos, i, intSin As Integer
        Dim blnLastSys As Boolean
        Dim strSIN As String
        Dim intSys As Integer
        Dim best_j, j, intParam As Integer
        Dim best_value(1) As String

        'check we aren't already in remote control mode
        If RemoteMode() = True Then
            lblOp.Text = "Cannot queue systems while in remote control mode."
            Exit Sub
        End If

        If Form1.msc.IsOpen = True Then Form1.msc.Close()
        If Val(RadioSetting(44)) = 0 Then 'nocomport num
            MsgBox("Please choose a COM port before continuing.")
            Exit Sub
        End If
        If Val(RadioSetting(45)) = 0 Then 'baud rate
            MsgBox("Please set COM Port speed before continuing.")
            Exit Sub
        End If
        Form1.msc.PortName = "COM" & RadioSetting(44)
        Form1.msc.BaudRate = RadioSetting(45)
        'check com port settings
        If COMPortExists() = False Then
            Exit Sub
        End If
        If Form1.msc.IsOpen = False Then Form1.msc.Open()

        If Me.Visible = True Then
            ResponseCode = SendCMD("EPG")
            ResponseCode = SendCMD("PRG")
        End If

        ResponseCode = SendCMD("MDL")
        If ResponseCode = "BC246T" Or ResponseCode = "UBC246T" Or ResponseCode = "SC230" Or ResponseCode = "USC230" Then
            intPos = 11
        Else
            intPos = 13
        End If
        DisableCCO(ResponseCode, True)

        'begin download
        lstSystems.Items.Clear()
        'clear list array
        System.Array.Clear(lstArray, 0, lstArray.Length)
        intSIH = Val(SendCMD("SIH"))
        intSin = intSIH
        If intSIH = -1 Then
            'no systems loaded in radio
            If Me.Visible = True Then MsgBox("No systems can be found in scanner.")
            blnLastSys = True
        Else
            Do Until blnLastSys = True
                'start system loop
                If intSin = -1 Or intSys > 1 And intSin = 0 Then
                    'no more sites to download
                    blnLastSys = True
                Else
                    strCurOp = "Reading system list..."
                    'download basic site paramaters
                    strSIN = SendCMD("SIN," & intSin)
                    lstArray(intSys, 0) = CStr(intSin)
                    lstArray(intSys, 1) = ("[" & ParaParse(strSIN, 1) & "] " & ParaParse(strSIN, 2))
                    'log the memory entry for the site after this
                    intSin = Val(ParaParse(strSIN, intPos))
                    If intSin = -1 Then blnLastSys = True
                    intSys = intSys + 1
                End If
            Loop
        End If
        intSys = intSys - 1
        If AutoSortSystemListToolStripMenuItem.Checked Then
            'sort the system list
            For i = 0 To intSys
                best_value(0) = lstArray(i, 0)
                best_value(1) = lstArray(i, 1)
                best_j = i
                For j = i + 1 To intSys
                    If lstArray(j, 1) < best_value(1) Then
                        best_value(0) = lstArray(j, 0)
                        best_value(1) = lstArray(j, 1)
                        best_j = j
                    End If
                Next j
                For intParam = 0 To 1
                    lstArray(best_j, intParam) = lstArray(i, intParam)
                    lstArray(i, intParam) = best_value(intParam)
                Next intParam
            Next i
        End If
        For intSin = 0 To intSys
            lstSystems.Items.Add((lstArray(intSin, 1)))
        Next intSin
        If Me.Visible = True Then
            blnQueue = True
            strCurOp = ""
            SendCMD("EPG")
            CheckResume()
            cmdChkAllSys_Click(cmdChkAllSys, New System.EventArgs())
        End If
        Form1.msc.Close()

        SetFinishGraphic()
        lstSystems.Enabled = True

        Exit Sub
CriticalError:
        IOGraphic(("F"))
        lblOp.Text = "QUEUE ERROR " & Err.Number
        If Form1.msc.IsOpen Then Form1.msc.Close()
        MsgBox("Critical Comms Error detected, confirm you have selected a valid COM Port and that is not used by any other application.")
        Exit Sub


    End Sub



    'UPGRADE_WARNING: Form event frmCommsDownload.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmCommsDownload_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        ShowComSettings()

        lstSystems.Enabled = True
        LoadPrefs()
    End Sub

    Private Sub frmCommsDownload_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ShowComSettings()
        LoadPrefs()
        lstSystems.Items.Clear()
    End Sub

    'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    'UPGRADE_WARNING: frmCommsDownload event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub Form_Terminate_Renamed()
        cmdClose_Click(cmdClose, New System.EventArgs())
    End Sub

    Private Sub frmCommsDownload_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call cmdClose_Click(cmdClose, New System.EventArgs())
    End Sub

    Private Sub msc_OnComm()
        'If chkLinux.CheckState = 0 Then strCommchar = strCommchar & Form1.msc.ReadByte
        MsgBox("does this get executed?:")
    End Sub

    Sub DownloadSCN(ByVal blnXT As Boolean)
        Dim strSIN As String
        strSIN = SendCMD("SCN")
        If Not blnXT Then
            RadioSetting(30) = CStr(Val(ParaParse(strSIN, 2)))
            RadioSetting(28) = CStr(Val(ParaParse(strSIN, 1)))
            RadioSetting(96) = "0"
            RadioSetting(97) = "0"
            RadioSetting(106) = "0"
        Else
            RadioSetting(28) = CStr(Val(ParaParse(strSIN, 1)))
            RadioSetting(96) = MakeBinary(ParaParse(strSIN, 3))  'control ch logging
            RadioSetting(97) = MakeBinary(ParaParse(strSIN, 4))     'global att
            RadioSetting(106) = MakeBinary(ParaParse(strSIN, 6))  'p25 lowpass filter
            RadioSetting(108) = CStr(MakeBinary(ParaParse(strSIN, 7))) 'unit id on/off
        End If
        strSIN = SendCMD("CNT")
        RadioSetting(29) = CStr(Val(ParaParse(strSIN, 1)))
    End Sub
    Sub DownloadCBP()
        'Downloads custom search MOT Band Plan Settings
        Dim Srch_Index As Integer
        For Srch_Index = 0 To 9
            CBPData(Srch_Index) = SendCMD("CBP," & Trim(Str(Srch_Index)))

            If blnDebug Then
                Console.WriteLine("frmCommsDownload:DownloadCBP:" & CBPData(Srch_Index))

            End If
        Next
    End Sub
    Sub DownloadGDO()
        'GPS settings
        Dim Response As String
        Response = SendCMD("GDO")
        RadioSetting(46) = ParaParse(Response, 1) 'disp mode
        RadioSetting(47) = ParaParse(Response, 2) 'metric system
        RadioSetting(48) = ParaParse(Response, 3) '24 hour format
        RadioSetting(49) = ParaParse(Response, 5) 'dms
        RadioSetting(50) = ParaParse(Response, 4) 'time zone
    End Sub
    Sub DownloadDUD()
        Dim Response As String
        'lcd upside download setting

        Response = SendCMD("DUD")

        RadioSetting(31) = CStr(Val(ParaParse(Response, 1)))
    End Sub
    Sub CommonWX()
        'download weather settings
        Dim Response As String

        Dim strBuff1(45) As String
        Dim cnt, cnt1 As Integer
        Dim intPos As Integer

        Response = SendCMD("WXS") 'get weather settings
        If Len(Response) > 4 Then

            RadioSetting(73) = CStr(Val(ParaParse(Response, 1)))

            strBuff1(0) = ParaParse(Response, 3)

            strBuff1(1) = ParaParse(Response, 2)
            If Len(Response) > 5 Then
                strBuff1(2) = CStr(Val(ParaParse(Response, 4))) 'record out
            Else
                strBuff1(2) = "1"

            End If
            RadioSetting(71) = Join(strBuff1, Chr(9))
            'same settings
        End If
        System.Array.Clear(strBuff1, 0, strBuff1.Length)
        For cnt = 1 To 5

            Response = SendCMD("SGP," & cnt)
            For cnt1 = 1 To 9

                strBuff1(intPos) = ParaParse(Response, cnt1)
                intPos = intPos + 1
            Next cnt1
        Next cnt
        RadioSetting(72) = Join(strBuff1, Chr(9))
    End Sub
    Sub DownloadQGL(ByRef intIndex As Integer, ByRef intSys As Integer)
        'download quick keys from a 396
        Dim strQGL, strBuff As String
        Dim cnt As Integer
        Dim strBuff1 As String

        strQGL = ""
        strBuff = SendCMD("QGL," & intIndex)
        If Len(strBuff) = 10 Then
            For cnt = 1 To 10

                strBuff1 = Mid(strBuff, cnt, 1)

                If strBuff1 = "1" Then
                    strQGL = strQGL & "1"
                Else
                    strQGL = strQGL & "0"
                End If
            Next cnt
        Else 'invalid data download, assume all on
            strQGL = "111111111"
        End If

        varSite(intSys, 0, 0, 8) = strQGL
    End Sub

    Private Sub lblErr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblErr.Click
        frmConsole.Visible = True
    End Sub

    Public Sub mnuAbort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAbort.Click
        If Form1.msc.IsOpen = True Then Form1.msc.Close()
        MsgBox("Aborted operation")
        If Me.Visible = True Then Me.Enabled = True
        If Form1.Visible = True Then Form1.Enabled = True
    End Sub

    Public Sub mnuCopyLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCopyLog.Click
        If strLog = Nothing Then
            MsgBox("Nothing to copy.")
            Exit Sub
        End If
        My.Computer.Clipboard.Clear()

        My.Computer.Clipboard.SetText(strLog)
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
    Sub ToneDL396()
        If blnDebug = False Then On Error GoTo criticerror
        'download ToneOut settings
        Dim strBuff0(45) As String
        Dim strBuff1(45) As String
        Dim strbuff2(45) As String
        Dim strbuff3(45) As String
        Dim strBuff4(45) As String
        Dim strBuff5(45) As String
        Dim strBuff6(45) As String
        Dim strName As String
        Dim lngTone1, intAlertTone, intAlertLevel, lngTone2 As Integer
        Dim lngFreq, intRecord, cnt As Integer
        Dim strDelay, Response As String
        Dim cnt1, intToneIndex As Integer
        Dim strCMD As String

        For cnt = 0 To 9
            intToneIndex = cnt + 1
            If intToneIndex = 10 Then intToneIndex = 0

            Response = SendCMD("TON," & intToneIndex)
            'name
            strBuff0(cnt) = ParaParse(Response, 2)
            'frequency
            strBuff1(cnt) = MakeItKosherFreqSilent(Val(ParaParse(Response, 3)) / 10000)
            'delay time
            strbuff2(cnt) = ParaParse(Response, 6)
            'alert tone type
            strbuff3(cnt) = ParaParse(Response, 7)
            'alert tone level
            strBuff4(cnt) = ParaParse(Response, 8)
            'tone a hrmmm
            strBuff5(cnt * 2) = Val(ParaParse(Response, 9)) / 10
            'tone b
            strBuff5((cnt * 2) + 1) = Val(ParaParse(Response, 11)) / 10
        Next cnt

        'save the new settings to memory
        RadioSetting(74) = Join(strBuff0, Chr(9)) 'name
        RadioSetting(75) = Join(strBuff1, Chr(9)) 'freq
        RadioSetting(76) = Join(strBuff5, Chr(9)) 'tones
        RadioSetting(77) = Join(strbuff3, Chr(9)) 'alert tone
        RadioSetting(78) = Join(strBuff4, Chr(9)) 'alert tone level
        RadioSetting(79) = Join(strbuff2, Chr(9)) 'delay time
        RadioSetting(80) = Join(strBuff6, Chr(9)) 'delay on/off
        Exit Sub
criticerror:
        MsgBox("Critical error processing fire tone outs. Fire tone outs will not be imported.")
        Exit Sub
    End Sub
    Sub GenFileName(ByRef strMDL As String)
        'generates default file name if there is none
        If strCurrFile = "" Then

            strCurrFile = strMDL & " " & Format(Now, "d") & ".996"
            strCurrFile = Replace(strCurrFile, "/", "-")
            Call lblSiteNote.SetFormCaption()
        End If
    End Sub
    Sub SetSiteType(ByRef intSys As Integer, ByRef intSite As Integer, ByRef strSIF As String)
        Dim strBuff As String
        'Sets the site type when downloading from a 346/396XT
        If blnDebug = False Then On Error GoTo criticfail

        strBuff = ParaParse(strSIF, 23) 'record motorola type standard/split/custom or null?
        If strBuff = "" Then

            strBuff = ParaParse(strSIF, 24)
        End If
        If varSite(intSys, 0, 0, 3) = "2" Then 'Motorola type I
            If strBuff = "STD" Then 'standard mot 1
                varSite(intSys, intSite, 0, 9) = "7"
            ElseIf strBuff = "SPL" Then  'splinter mot 1
                varSite(intSys, intSite, 0, 9) = "8"
            ElseIf strBuff = "CUSTOM" Then
                varSite(intSys, intSite, 0, 9) = "16"
            Else 'huh??
                MsgBox("Error, cannot set site type, please report this bug.")
                varSite(intSys, intSite, 0, 9) = "7"
            End If
        ElseIf varSite(intSys, 0, 0, 3) = "3" Then  'motorola type 2

            If strBuff = "STD" Then 'standard mot 2
                varSite(intSys, intSite, 0, 9) = "1"
            ElseIf strBuff = "SPL" Then  'splinter mot 2
                varSite(intSys, intSite, 0, 9) = "2"
            Else 'custom site
                varSite(intSys, intSite, 0, 9) = "13"
            End If
        ElseIf varSite(intSys, 0, 0, 3) = "4" Then  'EDACS Narrow/Wide

            strBuff = ParaParse(strSIF, 24)
            If strBuff = "NARROW" Then
                varSite(intSys, intSite, 0, 9) = "9"
            Else
                varSite(intSys, intSite, 0, 9) = "10"
            End If
        ElseIf varSite(intSys, 0, 0, 3) = "5" Then  'EDACS SCAT
            varSite(intSys, intSite, 0, 9) = "11"
        ElseIf varSite(intSys, 0, 0, 3) = "6" Then  'LTR
            varSite(intSys, intSite, 0, 9) = "12"
        ElseIf varSite(intSys, 0, 0, 3) = "7" Then  'P25 Standard
            varSite(intSys, intSite, 0, 9) = "14"
        ElseIf varSite(intSys, 0, 0, 3) = "8" Then  'P25 on freq
            varSite(intSys, intSite, 0, 9) = "15"
        End If
        Exit Sub
criticfail:
        sngErr = sngErr + 1
        GenLog(("Fault at SetSiteType, see log"))
        strLog = strLog & intSys & " " & varSite(intSys, 0, 0, 3) & " " & strSIF & Chr(13)
    End Sub
    Sub CommonABP(ByVal intSysNum As Integer, ByVal intSite As Integer, ByVal intSiteIndex As Integer)
        If blnDebug = False Then On Error Resume Next
        Dim strABP As String = Nothing
        Dim intABP As Integer = 0
        Dim strFreq(15) As String, strSpacing(15) As String, strBuff() As String
        strABP = SendCMD("ABP," & intSiteIndex)
        strBuff = Split(strABP, ",")
        If UBound(strBuff) = 31 Then 'assuming there wasnt an error proceed
            For intABP = 0 To 31 Step 2
                strFreq(intABP / 2) = CStr((HexToDec(strBuff(intABP)) / 1000000) * 5)   'frequency
                strSpacing(intABP / 2) = CStr((HexToDec(strBuff(intABP + 1)) / 1000) * 125)
            Next
            varSite(intSysNum, intSite, 0, 30) = Join(strFreq, ",")
            varSite(intSysNum, intSite, 0, 31) = Join(strSpacing, ",")
        Else
            sngErr += 1
            strCurOp = "Invalid response from APCO bandplan"
            Call GenLog(strCurOp)
            strLog = strLog & "ERROR: INVALID APCO BANDPLAN"
        End If
    End Sub
    Function ChgAlertCode(ByVal ALT_PATTERN As String, ByVal strMdl As String) As String
        ChgAlertCode = ALT_PATTERN
        'Takes a 346XT alert pattern mode and converts it to a color XT alert pattern mode to 
        'because the codes are different across scanners
        If strMdl = "BC346XT" Or strMdl = "BCT15X" Or strMdl = "BC346XTC" Then
            Select Case ALT_PATTERN
                Case "1"
                    ChgAlertCode = "0"

                Case "2"
                    ChgAlertCode = "1"
                Case "3"
                    ChgAlertCode = "2"
            End Select
        End If
    End Function
    Sub DownloadDBC(ByVal strMDL As String)
        'Download the master band plan from the scanner
        Dim cnt, Band As Integer
        Dim blnSkip As Boolean, strBuff As String
        If Not blnDebug Then On Error Resume Next
        If strMDL <> "BC346XT" And strMDL <> "BC346XTC" Then  '396XT etc
            For Band = 0 To 30
                strBuff = SendCMD("DBC," & CStr(Band + 1))

                If strBuff <> "ERR" And strBuff <> "-1" Then
                    'set modulation
                    BandSet(Band, 1) = ParaParse(strBuff, 2)
                    BandSet(Band, 0) = ParaParse(strBuff, 1) 'step
                End If
            Next
        Else          'for 346XT only
            For cnt = 0 To 30
                blnSkip = False
                Band = cnt
                If cnt = 18 Or cnt = 19 Or cnt = 25 Or cnt = 26 Then
                    blnSkip = True 'these bands are unsupported
                End If
                If cnt >= 20 And cnt <= 24 Then
                    Band = cnt - 2
                End If
                If cnt >= 27 Then
                    Band = cnt - 4
                End If
                If Not blnSkip Then
                    strBuff = SendCMD("DBC," & CStr(Band + 1))
                    If strBuff <> "ERR" And strBuff <> "-1" Then
                        'set modulation
                        BandSet(cnt, 1) = ParaParse(strBuff, 2)
                        BandSet(cnt, 0) = ParaParse(strBuff, 1) 'step
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub AutoSortSystemListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoSortSystemListToolStripMenuItem.Click
        'sort by QK
        Dim ThisMenu As Object
        ThisMenu = AutoSortSystemListToolStripMenuItem
        If ThisMenu.Checked Then
            ThisMenu.checked = False
        Else
            ThisMenu.Checked = True
        End If
        SaveSetting("FreeSCAN", "Settings", "SortDL", AutoSortSystemListToolStripMenuItem.CheckState)
    End Sub
    Function GetStateIndex(ByVal strState As String) As Integer
        'Takes a state index from the scanner such as AZ and returns
        'an index to the variable varState
        If Not blnDebug Then On Error Resume Next
        Dim x, StateSel As Integer
        StateSel = 0
        For x = 0 To 66
            If strState = varState(x, 0) Then
                StateSel = x
                Exit For
            End If
        Next
        GetStateIndex = StateSel
    End Function
    Sub DownloadGLI(ByVal SysID As String, ByVal SysIndex As String)
        'Downloads all the TGID lockouts
        If Not blnDebug Then On Error GoTo GLiError
        Dim sBuff As String = Nothing
        Dim sTGID As String = Nothing
        Dim iSanityChk As Integer = 0

        Do
            iSanityChk += 1
            sBuff = SendCMD("GLI," & SysIndex)
            If sBuff <> "-1" And Len(sBuff) <> 0 Then
                InsertGliDX(SysID, sBuff)
            End If
        Loop Until sBuff = "-1" Or Not IsNumeric(sBuff) Or iSanityChk > 500

        If iSanityChk > 500 Then
            sngErr += 1
            GenLog("Sanity check fail - TGID Lockout list")
        End If
        Exit Sub
GliError:
        sngErr += 1
        GenLog("Error retrieving TGID Lockout list")
    End Sub

    Private Sub cmdSetupCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetupCom.Click
        Call mnuScannerCOMPort_Click(Nothing, Nothing)
    End Sub

    Private Sub cmdAbortDownload_Click(sender As System.Object, e As System.EventArgs) Handles cmdAbortDownload.Click
        bAbortPressed = True
    End Sub
End Class