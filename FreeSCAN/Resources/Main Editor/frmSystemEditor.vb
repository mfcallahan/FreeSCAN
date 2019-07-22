Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class lblSiteNote
	Inherits System.Windows.Forms.Form
	Dim blnSuccess As Boolean
	Public blnBusy As Boolean
    Public WarnDelete As Boolean = MakeBoolean(GetSetting("FreeSCAN", "Settings", "DeleteWarn", "1"))
    Dim blnUserCancel As Boolean
	Dim blnStartup As Boolean
	Dim blnLoadCmdLine As Boolean
    Dim blnSplashed As Boolean
    Public blnVirtControlStartup As Boolean = False
    Dim intCancel As Integer
    Dim intDraggedSysNum, intDraggedSiteNum As Integer, intTargetSys As Integer, blnDragRightClick As Boolean
    Public intGridSel(1) As Integer
	Public intTimer As Integer
	Public strMode As String
    Public blnSkipGroup As Boolean 'skip making courtesy groups if this is true
    Public blnSkipRedraw As Boolean = False
    Public blnCheckUpdateStartup As Boolean = MakeBoolean(GetSetting("FreeSCAN", "Settings", "CheckUpdateStartup", 0))
    Public blnSplash As Boolean = MakeBoolean(GetSetting("FreeSCAN", "Settings", "Splash", 1))
    Public blnWarnInvalidFreq As Boolean = MakeBoolean(GetSetting("FreeSCAN", "Settings", "WarnInvalidFreq", 1))
    Sub BuildGridArray()
        'Build up the intGridSel variable, which is an array
        'of all currently selected rows, depending on the grid
        Dim intRowSelCount As Integer
        Dim intCnt As Integer
        Dim varGrid As DataGridView
        If Not blnDebug Then On Error Resume Next
        varGrid = Nothing
        If grdTGID.Visible = True Then
            varGrid = Me.grdTGID
        ElseIf grdConvChan.Visible = True Then
            varGrid = Me.grdConvChan
        ElseIf grdTrunkFreq.Visible Then
            varGrid = Me.grdTrunkFreq
        Else
            ReDim intGridSel(0)
            System.Array.Clear(intGridSel, 0, intGridSel.Length)
            Exit Sub
        End If
        Erase intGridSel
        intRowSelCount = varGrid.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If intRowSelCount = 0 Then Exit Sub
        'build an array of all selected rows
        ReDim intGridSel(intRowSelCount - 1)
        For intCnt = 0 To intRowSelCount - 1
            intGridSel(intCnt) = Val(varGrid.SelectedRows(intCnt).Index.ToString)
        Next intCnt
        Array.Sort(intGridSel)
    End Sub

    Sub ImoprtUASD(ByVal strFilename As String)
        If blnDebug = False Then On Error GoTo criticerror
        Dim intTotalTrunkFreq, ChanNum, intNumSites As Integer
        Dim NumSites As Integer
        Dim intFF, cnt As Integer
        Dim strBuff As String
        Dim strUSD() As String
        Dim strFileType As String
        Dim intLines, intLine As Integer
        Dim blnMemFull As Boolean
        Dim strLine() As String
        Dim intChan, intLastSite As Integer
        Dim intABP As Integer
        'next read the file into memory
        intFF = FreeFile()
        FileOpen(intFF, strFilename, OpenMode.Binary)
        strBuff = Space(LOF(intFF))

        FileGet(intFF, strBuff)
        FileClose(intFF)
        strUSD = Split(strBuff, Chr(13))
        intLines = UBound(strUSD)
        blnSkipGroup = True
        'begin importing
        If intLines > 0 Then
            intLine = 0 'set current line
            blnMemFull = False
            intCurrentSys = 0
            intCurrentGroup = 0
            intCurrentChannel = 0
            Do Until intLine = intLines Or blnMemFull = True
                Erase strLine
                strLine = Split(strUSD(intLine), ",")
                'identify paramaters

                strLine(0) = MakeItKosherSilent(strLine(0), 0)
                Select Case strLine(0)
                    Case "SystemCT" 'a system
                        'get the system type
                        If strLine(1) = "CNV" Then 'create conv system

                            strBuff = GetFreeSysNum()
                            If strBuff <> "-1" Then
                                Me.MakeNewConvSystem()
                                intCurrentGroup = 0
                                varSite(intCurrentSys, 0, 0, 2) = MakeBinary(strLine(5)) 'lockout
                                varSite(intCurrentSys, 0, 0, 4) = MakeItKosherQK(strLine(3)) 'quickkey
                                varSite(intCurrentSys, 0, 0, 5) = CStr(Val(strLine(4))) 'hold time
                                varSite(intCurrentSys, 0, 0, 9) = MakeBinary(strLine(8)) 'data skip
                                varSite(intCurrentSys, 0, 0, 10) = CStr(0) 'num groups=0
                                If UBound(strLine) > 13 Then

                                    varSite(intCurrentSys, 0, 0, 7) = MakeItKosherQK(strLine(13)) 'startup key
                                    Select Case UCase(strLine(14)) 'record mode
                                        Case "ALL"
                                            varSite(intCurrentSys, 0, 0, 24) = CStr(2)
                                        Case "MARKED"
                                            varSite(intCurrentSys, 0, 0, 24) = CStr(1)
                                        Case Else
                                            varSite(intCurrentSys, 0, 0, 24) = CStr(0)
                                    End Select
                                Else
                                    varSite(intCurrentSys, 0, 0, 24) = CStr(2) 'record all
                                    varSite(intCurrentSys, 0, 0, 7) = "." 'startup key
                                End If
                                'P25 mode not implemented
                            Else
                                blnMemFull = True
                            End If
                        Else 'create trunk sys

                            strBuff = GetFreeSysNum()
                            If strBuff <> "-1" Then
                                blnSkipGroup = True
                                'set system type
                                MakeNewTrunkSystem((ConvSiteToSys(strLine(1))))
                                blnSkipGroup = False
                                varSite(intCurrentSys, 0, 0, 25) = CStr(Val(strLine(9))) 'emergency alert type
                                Call CreateGenericSite()
                                varSite(intCurrentSys, intCurrentGroup, 0, 2) = MakeBinary(strLine(5)) 'lockout
                                varSite(intCurrentSys, intCurrentGroup, 0, 4) = CStr(Val(strLine(4))) 'hold time
                                varSite(intCurrentSys, intCurrentGroup, 0, 7) = MakeBinary(strLine(6)) 'atten
                                varSite(intCurrentSys, intCurrentGroup, 0, 9) = RevSiteTypeLookup(strLine(1)) 'site type
                                varSite(intCurrentSys, intCurrentGroup, 0, 2) = MakeItKosherQK(strLine(3)) 'quickkey
                                intLastSite = intCurrentGroup
                                'for 15/996
                                If UBound(strLine) > 14 Then
                                    Select Case UCase(strLine(14)) 'record mode
                                        Case "ALL"
                                            varSite(intCurrentSys, 0, 0, 24) = CStr(2)
                                        Case "MARKED"
                                            varSite(intCurrentSys, 0, 0, 24) = CStr(1)
                                        Case Else
                                            varSite(intCurrentSys, 0, 0, 24) = CStr(0)
                                    End Select
                                    varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosherSilent(StripQuote(strLine(15)), 0) 'site name
                                    varSite(intCurrentSys, 0, 0, 26) = CStr(Val(strLine(10))) 'emerg alert level
                                Else 'import for a 246
                                    varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosherSilent(StripQuote(strLine(2)), 0) 'set name
                                    varSite(intCurrentSys, 0, 0, 24) = CStr(2) 'rec all
                                    varSite(intCurrentSys, 0, 0, 26) = CStr(0) 'emg alert level=auto
                                End If
                            Else
                                blnMemFull = True
                            End If
                        End If
                        'common to both
                        If blnMemFull = False Then

                            varSite(intCurrentSys, 0, 0, 1) = MakeItKosherSilent(StripQuote(strLine(2)), 0) 'system name
                            varSite(intCurrentSys, 0, 0, 6) = CStr(Val(strLine(7))) 'delay time
                        End If
                    Case "SystemT" ' Trunk system paramaters
                        varSite(intCurrentSys, 0, 0, 11) = MakeBinary(strLine(1)) 'search/scan mode
                        varSite(intCurrentSys, 0, 0, 12) = MakeBinary(strLine(2)) 'ignore mot status bit
                        varSite(intCurrentSys, 0, 0, 13) = MakeBinary(strLine(3)) 'mot end code
                        varSite(intCurrentSys, 0, 0, 14) = MakeBinary(strLine(4)) 'afs or decimal mode
                        varSite(intCurrentSys, 0, 0, 15) = MakeBinary(strLine(5)) 'i-call on/off
                        varSite(intCurrentSys, intCurrentGroup, 0, 8) = MakeBinary(strLine(6)) 'cont chan
                        If UBound(strLine) > 6 Then
                            varSite(intCurrentSys, intCurrentGroup, 0, 6) = strLine(7) 'modmode
                        Else
                            varSite(intCurrentSys, intCurrentGroup, 0, 6) = "Auto" 'default for 246
                        End If
                    Case "Band-Plan" 'Motorola VHF Bandplan
                        For cnt = 0 To 2
                            varSite(intCurrentSys, intLastSite, 0, 17 + (cnt * 3)) = CStr(Val(strLine(1 + (cnt * 3))) / 10000) 'base 1
                            varSite(intCurrentSys, intLastSite, 0, 18 + (cnt * 3)) = CStr(Val(strLine(2 + (cnt * 3))) / 100) 'step 1
                            varSite(intCurrentSys, intLastSite, 0, 19 + (cnt * 3)) = CStr(Val(strLine(3 + (cnt * 3)))) 'offset 1
                        Next cnt
                    Case "Band-Plan-P25"
                        For intABP = 30 To 60 Step 2
                            'freq
                            varSite(intCurrentSys, intLastSite, 0, intABP) = CStr((Val(CStr(HexToDec(strLine(intABP - 29)))) / 1000000) * 5) 'freq
                            'base
                            varSite(intCurrentSys, intLastSite, 0, intABP + 1) = CStr((Val(CStr(HexToDec(strLine(intABP - 28)))) / 1000) * 125) 'base
                        Next intABP
                    Case "LCN" 'actual trunk frequencies
                        If intLastSite = 0 Or varSite(intCurrentSys, intCurrentGroup, 0, 5) <> "3" Then 'create a default if there is none already
                            CreateGenericSite()
                            intLastSite = intCurrentGroup
                        End If

                        intChan = InsertTrunkFreq(varSite(intCurrentSys, intCurrentGroup, 0, 10))
                        If intChan <> -1 Then
                            strTrunkFreq(intChan, 0) = CStr(Val(strLine(2)) / 10000)
                            strTrunkFreq(intChan, 1) = Val(strLine(1))
                        Else
                            blnMemFull = True
                        End If

                    Case "TGroup" ' tgid group info
                        If intCurrentSys > 0 Then

                            strBuff = GetFreeGroupNum(intCurrentSys)
                            If strBuff <> "-1" Then
                                blnSkipGroup = True
                                MakeNewGroup()
                                blnSkipGroup = False
                                'set group paramters
                                varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosherSilent(StripQuote(strLine(1)), 0) 'name
                                varSite(intCurrentSys, intCurrentGroup, 0, 2) = MakeItKosherQK(strLine(2)) 'qk
                                varSite(intCurrentSys, intCurrentGroup, 0, 3) = MakeBinary(strLine(3)) 'lo status
                            End If
                        End If
                    Case "CGroup" 'conv group
                        If intCurrentSys > 0 Then

                            strBuff = GetFreeGroupNum(intCurrentSys)
                            If strBuff <> "-1" Then
                                blnSkipGroup = True
                                MakeNewGroup()
                                blnSkipGroup = False
                                'set group paramters
                                varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosherSilent(StripQuote(strLine(1)), 0) 'name
                                varSite(intCurrentSys, intCurrentGroup, 0, 2) = MakeItKosherQK(strLine(2)) 'qk
                                varSite(intCurrentSys, intCurrentGroup, 0, 3) = MakeBinary(strLine(3)) 'lo status
                            End If
                        End If
                    Case "TGID" ' individual TGID
                        If intCurrentGroup > 0 Then

                            strBuff = InsertChan(intCurrentGroup, False)
                            If strBuff <> "-1" Then
                                ChanInfo(CInt(strBuff), 1) = MakeItKosherSilent(StripQuote(strLine(1)), 0) 'channel name
                                ChanInfo(CInt(strBuff), 2) = MakeItKosherSilent(strLine(2), 0) 'tgid
                                ChanInfo(CInt(strBuff), 3) = MakeBinary(strLine(3)) 'lockout
                                ChanInfo(CInt(strBuff), 4) = CStr(Val(strLine(4))) 'alert tone type
                                ChanInfo(CInt(strBuff), 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10)
                                If UBound(strLine) > 7 Then 'import from uasd 996
                                    ChanInfo(CInt(strBuff), 7) = MakeBinary(strLine(7)) 'record on/off
                                    ChanInfo(CInt(strBuff), 5) = CStr(Val(strLine(5))) 'alert level
                                    Select Case strLine(8) 'audio type
                                        Case "ANALOG"
                                            ChanInfo(CInt(strBuff), 6) = CStr(1)
                                        Case "DIGITAL"
                                            ChanInfo(CInt(strBuff), 6) = CStr(2)
                                        Case Else
                                            ChanInfo(CInt(strBuff), 6) = CStr(0)
                                    End Select
                                End If
                            Else
                                blnMemFull = True
                            End If
                        End If
                    Case "Point" ' GPS Coordinates
                        If varSite(intCurrentSys, 0, 0, 3) = "1" Then 'conv system

                            varSite(intCurrentSys, 0, 0, 22) = MakeBinary(strLine(1)) 'gps enable
                            If Len(strLine(3)) = 9 Then 'lat
                                varSite(intCurrentSys, 0, 0, 19) = strLine(3)
                            End If
                            If Len(strLine(4)) = 10 Then 'long
                                varSite(intCurrentSys, 0, 0, 20) = strLine(4)
                            End If
                            varSite(intCurrentSys, 0, 0, 21) = CStr(Val(strLine(5)) / 100) 'range in miles
                        Else 'trunked sys

                            varSite(intCurrentSys, intLastSite, 0, 16) = MakeBinary(strLine(1)) 'gps enable
                            If Len(strLine(3)) = 9 Then 'lat
                                varSite(intCurrentSys, intLastSite, 0, 13) = strLine(3)
                            End If
                            If Len(strLine(4)) = 10 Then 'long
                                varSite(intCurrentSys, intLastSite, 0, 14) = strLine(4)
                            End If
                            varSite(intCurrentSys, intLastSite, 0, 15) = CStr(Val(strLine(5)) / 100) 'range in miles
                        End If
                    Case "SiteCT" 'trunked site
                        CreateGenericSite()

                        varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosherSilent(StripQuote(strLine(2)), 0) 'site name
                        varSite(intCurrentSys, intCurrentGroup, 0, 3) = MakeBinary(strLine(5)) 'lockout
                        varSite(intCurrentSys, intCurrentGroup, 0, 4) = CStr(Val(strLine(4))) 'hold time
                        varSite(intCurrentSys, intCurrentGroup, 0, 7) = MakeBinary(strLine(6)) 'atten
                        varSite(intCurrentSys, intCurrentGroup, 0, 9) = RevSiteTypeLookup(strLine(1)) 'site type
                        varSite(intCurrentSys, intCurrentGroup, 0, 2) = MakeItKosherQK(strLine(3)) 'quickkey
                        varSite(intCurrentSys, intCurrentGroup, 0, 12) = MakeItKosherQK(strLine(13)) 'startup key
                        intLastSite = intCurrentGroup
                    Case "SiteT" 'trunk site settings
                        varSite(intCurrentSys, intCurrentGroup, 0, 8) = MakeBinary(strLine(6)) 'c-ch only
                        varSite(intCurrentSys, intCurrentGroup, 0, 6) = strLine(7) 'modmode
                    Case "Channel" ' conv channel
                        If intCurrentGroup > 0 Then

                            strBuff = InsertChan(intCurrentGroup, True)
                            If strBuff <> "-1" Then
                                ChanInfo(CInt(strBuff), 1) = MakeItKosherSilent(StripQuote(strLine(1)), 0) 'channel name
                                ChanInfo(CInt(strBuff), 2) = MakeItKosherFreqSilent(Val(strLine(2)) / 10000) 'frequency
                                ChanInfo(CInt(strBuff), 4) = RevModModeLookup(strLine(4)) 'modmode
                                ChanInfo(CInt(strBuff), 9) = USDToneLookUp(strLine(5)) 'tone
                                ChanInfo(CInt(strBuff), 11) = MakeBinary(strLine(6)) 'tone lockout
                                ChanInfo(CInt(strBuff), 5) = MakeBinary(strLine(7)) 'lockout
                                ChanInfo(CInt(strBuff), 7) = MakeBinary(strLine(8)) 'pri
                                ChanInfo(CInt(strBuff), 6) = MakeBinary(strLine(9)) 'atten
                                ChanInfo(CInt(strBuff), 8) = CStr(Val(strLine(10))) 'alert tone type
                                ChanInfo(CInt(strBuff), 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10)
                                If UBound(strLine) > 12 Then
                                    ChanInfo(CInt(strBuff), 13) = CStr(Val(strLine(11))) 'alert level
                                    'audio type
                                    If UBound(strLine) >= 13 Then
                                        Select Case UCase(strLine(13))
                                            Case "DIGITAL"
                                                ChanInfo(CInt(strBuff), 12) = CStr(2)
                                            Case "ANALOG"
                                                ChanInfo(CInt(strBuff), 12) = CStr(1)
                                            Case Else
                                                If UCase(strLine(5)) <> "NONE" Then
                                                    ChanInfo(CInt(strBuff), 12) = CStr(1)
                                                Else
                                                    ChanInfo(CInt(strBuff), 12) = "0"
                                                End If
                                        End Select
                                    Else
                                        ChanInfo(CInt(strBuff), 12) = "0"
                                    End If

                                Else
                                    ChanInfo(CInt(strBuff), 13) = CStr(0)
                                    If ChanInfo(CInt(strBuff), 9) <> "0" Then
                                        ChanInfo(CInt(strBuff), 12) = CStr(1) 'audiotype=analog
                                    Else
                                        ChanInfo(CInt(strBuff), 12) = CStr(0) 'audiotype=all

                                    End If
                                End If
                                End If
                        Else
                            blnMemFull = True
                        End If
                End Select

                intLine = intLine + 1
            Loop
        Else
            MsgBox("Invalid file, cannot import.")
        End If
        If blnMemFull = True Then
            strBuff = "FreeSCAN has insufficient memory to continue importing this file. As a result, not all of the file has been imported. Delete systems and/or channels and try again."
            intLine = MsgBox(strBuff, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Out of Memory")
        End If
        intCurrentGroup = 0

        blnSkipGroup = False
        Exit Sub
criticerror:
        If Err.Number <> 32755 Then
            MsgBox("Critical error, cannot continue. Error code " & Err.Number)
        End If
        If FreeFile() <> 1 Then FileClose(intFF)
        blnSkipGroup = False
        Exit Sub
    End Sub
    Sub LoadFileList()
        'loads the recent file list
        Dim strBuff(3) As String
        Dim intCnt As Integer
        strBuff(0) = GetSetting("FreeSCAN", "Settings", "File0", "")
        strBuff(1) = GetSetting("FreeSCAN", "Settings", "File1", "")
        strBuff(2) = GetSetting("FreeSCAN", "Settings", "File2", "")
        strBuff(3) = GetSetting("FreeSCAN", "Settings", "File3", "")
        For intCnt = 0 To 3
            mnuLastFile(intCnt).Visible = False
            If strBuff(intCnt) <> "" Then

                mnuLastFile(intCnt).Text = "&" & (intCnt + 1) & "  " & StripName(strBuff(intCnt))
                mnuLastFile(intCnt).Visible = True
            End If
        Next intCnt

    End Sub
    Sub ArrangeFileList(ByRef strFile As String)
        'whenever a file is accessed, this updates the recent file used list in the menu
        Dim strBuff(5) As String
        Dim intCnt As Integer
        Dim strSw(5) As String
        Dim blnFound As Boolean
        strBuff(0) = GetSetting("FreeSCAN", "Settings", "File0", "")
        strBuff(1) = GetSetting("FreeSCAN", "Settings", "File1", "")
        strBuff(2) = GetSetting("FreeSCAN", "Settings", "File2", "")
        strBuff(3) = GetSetting("FreeSCAN", "Settings", "File3", "")

        'is the file in the list already?
        For intCnt = 0 To 3
            
            If UCase(strFile) = UCase(strBuff(intCnt)) Then 'yes it is
                'is it in pos 1?
                If intCnt = 0 Then
                    'do nothing, exit loop
                    intCnt = 3
                    blnFound = True
                Else
                    'was it in the last position
                    If intCnt = 3 Then
                        blnFound = True
                    ElseIf intCnt = 1 Then  'second  position
                        '    strBuff(1) = strBuff(0)
                        '    strBuff(0) = strFile
                        intCnt = 3
                        blnFound = True
                    ElseIf intCnt = 2 Then  'third  position
                        strSw(0) = strBuff(0)
                        strSw(1) = strBuff(1)
                        strSw(2) = strBuff(2)
                        strSw(3) = strBuff(3)
                        intCnt = 3
                        blnFound = True
                    End If
                End If
            End If
        Next intCnt
        If blnFound <> True Then
            strSw(1) = strBuff(0)
            strSw(2) = strBuff(1)
            strSw(3) = strBuff(2)
            
            strBuff(0) = strFile
            strBuff(1) = strSw(1)
            strBuff(2) = strSw(2)
            strBuff(3) = strSw(3)
            intCnt = 3
        End If
        Call SaveFileList(strBuff(0), strBuff(1), strBuff(2), strBuff(3))
        LoadFileList()
    End Sub
    Sub SaveFileList(ByRef F1 As String, ByRef F2 As String, ByRef F3 As String, ByRef F4 As String)
        'saves file list to registery

        
        SaveSetting("FreeSCAN", "Settings", "File0", F1)
        
        SaveSetting("FreeSCAN", "Settings", "File1", F2)
        
        SaveSetting("FreeSCAN", "Settings", "File2", F3)
        
        SaveSetting("FreeSCAN", "Settings", "File3", F4)
    End Sub
	Sub SetFormCaption()
		If blnDebug = True Then
			Me.Text = "FreeSCAN (Debug Mode) - " & strCurrFile
		Else
			If strCurrFile = "" Then
				Me.Text = strProgTitle
			Else
				Me.Text = "FreeSCAN - " & strCurrFile
			End If
		End If
	End Sub

	
	Sub BulkMemoryErase()
		'clear all radio related data from memory
		System.Windows.Forms.Application.DoEvents()

        System.Array.Clear(RadioSetting, 0, RadioSetting.Length)

        System.Array.Clear(varSite, 0, varSite.Length)
        Erase ChanInfo
        MaxChan = 4000
        ReDim ChanInfo(MaxChan, MaxChanSetting)

        System.Array.Clear(strSearchLockout, 0, strSearchLockout.Length)

        If IsArray(strIFEX) Then
            System.Array.Clear(strIFEX, 0, strIFEX.Length)
        End If
        System.Array.Clear(strTrunkFreq, 0, strTrunkFreq.Length)
        System.Array.Clear(strSSXT, 0, strSSXT.Length)
        System.Array.Clear(strFavs, 0, strFavs.Length) 'favourites, deprecated
        System.Array.Clear(GliDX, 0, GliDX.Length) 'global tgid lockouts
        System.Array.Clear(CBPData, 0, CBPData.Length) 'Custom Band Plan data for custom search
        Call Me.DrawFavMenu()
        InitCOMPort()
        If Me.Visible = True And frmCommsDownload.Visible = False Then Me.Activate()
        If frmGPSSummary.Visible Then
            Call frmGPSSummary.cmdLoadSystemList_Click(Nothing, Nothing)
        End If
    End Sub


    Sub InitMemoryArray()
        'clear all memory settings and start a new
        Dim x As Integer

        BulkMemoryErase()
        strCurrFile = ""
        'load default values into all variable
        RadioSetting(1) = "HIGH" ' backlight brightness
        RadioSetting(2) = "GREEN" 'backlight color
        RadioSetting(3) = CStr(0) 'priority mode off
        RadioSetting(4) = CStr(0) 'beep on keypress
        RadioSetting(5) = "" 'startup message
        RadioSetting(6) = "" 'startup message
        RadioSetting(7) = CStr(0) 'close call mode disable
        RadioSetting(8) = CStr(0) 'close call override
        RadioSetting(9) = "." 'close call QK
        RadioSetting(10) = CStr(0) ' disable CC hits
        RadioSetting(11) = CStr(3) 'close call pause time
        'default system quickkeys
        RadioSetting(12) = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111"
        RadioSetting(13) = "1" 'close call alert,
        RadioSetting(14) = "1111111" '- cc namds
        RadioSetting(15) = CStr(0) 'cc alert vol auto
        'RadioSetting(16) = "AUTO" 'p25 threshold
        RadioSetting(17) = "0" 'search step
        RadioSetting(18) = "AUTO" 'searching mod mode
        'RadioSetting(19) = "BCD996T" 'rad type'deprecated
        RadioSetting(20) = CStr(0) 'number of systems
        RadioSetting(21) = CStr(3) 'searching delay time
        RadioSetting(22) = "" 'STARTUP MSG
        RadioSetting(23) = "" 'STARTUP MSG
        RadioSetting(24) = CStr(1) 'cc code search on
        RadioSetting(25) = CStr(1) 'AGC analog
        RadioSetting(26) = CStr(1) 'AGC Digital
        RadioSetting(27) = "B" 'Handheld model close call alert mode
        RadioSetting(28) = CStr(2) 'LCD Mode
        RadioSetting(29) = CStr(7) 'contrast
        RadioSetting(30) = CStr(1) 'enable act chan disp mode
        RadioSetting(31) = CStr(0) 'flip display
        RadioSetting(32) = "100" ' max autostore
        RadioSetting(33) = CStr(0) 'srching att
        RadioSetting(34) = "."
        RadioSetting(35) = "."
        RadioSetting(36) = "."
        RadioSetting(37) = "."
        RadioSetting(38) = "."
        RadioSetting(39) = "."
        RadioSetting(40) = CStr(1) 'data skip on for close call
        RadioSetting(41) = CStr(0) 'repeater find
        RadioSetting(42) = CStr(1) 'tape out
        RadioSetting(43) = "1111110000000000" 'searching screen bands
        WarnDelete = Val(GetSetting("FreeSCAN", "Settings", "DeleteWarn", "1"))
        RadioSetting(74) = "Tone Out 1	Tone Out 2	Tone Out 3	Tone Out 4	Tone Out 5	Tone Out 6	Tone Out 7	Tone Out 8	Tone Out 9	Tone Out 10																																				"
        RadioSetting(75) = "0	0	0	0	0	0	0	0	0	0																																				"
        RadioSetting(76) = "0	0	0	0	0	0	0	0	0	0	0	0	0	0	0	0	0	0	0	0	"
        RadioSetting(77) = "0	0	0	0	0	0	0	0	0	0																																				" 'tone out alert type
        RadioSetting(78) = "0	0	0	0	0	0	0	0	0	0																																				"  'tone out alert level
        RadioSetting(79) = "2	2	2	2	2	2	2	2	2	2																																				" 'tone out delay time
        RadioSetting(80) = "1,1,1,1,1,1,1,1,1,1" 'tone out record enabled
        RadioSetting(81) = "AUTO,AUTO,AUTO,AUTO,AUTO,AUTO,AUTO,AUTO,AUTO,AUTO" 'tone out modulation
        RadioSetting(82) = "0,0,0,0,0,0,0,0,0,0" 'tone out att

        RadioSetting(87) = "0,0,6,0,0,6" 'default agc gain setting
        RadioSetting(88) = "0" 'P25 wait time
        RadioSetting(90) = "OFF,OFF,OFF,OFF,OFF,OFF,OFF,OFF,OFF,OFF" 'ALERT COLOR
        RadioSetting(91) = "0,0,0,0,0,0,0,0,0,0"
        RadioSetting(92) = "0,0,0,0,0,0,0,0,0,0" 'xt analog agc tone out
        RadioSetting(93) = "1" ' xt interval 1-10
        RadioSetting(94) = "1" ' xt agc analog agc
        RadioSetting(95) = "3" ' backlight brightness xt
        RadioSetting(96) = "0" ' xt control channel logging
        RadioSetting(97) = "0" ' xt global att
        RadioSetting(98) = "NONE" ' xt close call num tag
        RadioSetting(99) = "OFF" ' xt cc alert color
        RadioSetting(100) = "0" ' xt cc alert pat
        RadioSetting(101) = "1" 'xt cc analog agc
        RadioSetting(102) = "1" 'xt cc digital agc
        RadioSetting(103) = "0" 'xt cc p25 wait time
        RadioSetting(104) = "0" 'xt key lock
        RadioSetting(105) = "0" 'xt key safe
        RadioSetting(106) = "0" 'P25 low pass filter
        RadioSetting(107) = "5" 'battery charge time
        RadioSetting(108) = "0" ' Unit ID enabled/disable
        RadioSetting(109) = "1" ' Default State - defaults to ALABAMA
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
            CustSearch(x, 12) = "." 'QK
            CustSearch(x, 13) = "." 'startup key
            CustSearch(x, 14) = CStr(0) 'tape out
            CustSearch(x, 15) = CStr(1) 'lockout
            CustSearch(x, 11) = "NONE"
            CustSearch(x, 16) = "110000"
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

        'service search settings
        strSS(1, 1) = "PublicSafety"
        strSS(2, 1) = "News"
        strSS(3, 1) = "HAM"
        strSS(4, 1) = "Marine"
        strSS(5, 1) = "Railroad"
        strSS(6, 1) = "Air"
        strSS(7, 1) = "CB"
        strSS(8, 1) = "FRS/GMRS"
        strSS(9, 1) = "Racing"
        strSS(10, 1) = "TV"
        strSS(11, 1) = "FM"
        strSS(12, 1) = "Special"
        strSS(13, 1) = "Military Air"

        For x = 1 To 13
            strSS(x, 2) = CStr(2) 'delay
            strSS(x, 5) = "."
            strSS(x, 6) = "."
            strSS(x, 3) = CStr(0)
            strSS(x, 4) = CStr(0)
            strSS(x, 7) = CStr(0)
            strSS(x, 8) = CStr(1) 'lockout/record/att/hold
            strSSXT(x, 1) = "1"  'agc analog
            strSSXT(x, 2) = "1"  'agc digital
            strSSXT(x, 3) = "000"  'p25 wait time
            strSSXT(x, 4) = "NONE" 'number tag

        Next x
        'band plan setting
        For x = 0 To 30
            BandSet(x, 0) = BandData(x, 3) 'default step
            BandSet(x, 1) = BandData(x, 2) 'default mod
        Next
        blnChgSaved = True
        SetFormCaption()
    End Sub

    Sub LoadSystem(ByRef strPreFile As String)
        'load a system from disk into memory
        If Not blnDebug Then On Error GoTo abort
        Dim intTotalTrunkFreq, ChanNum, intNumSites As Integer
        Dim NumSites As Integer
        Dim strFileVer, strFilename, strBuff, strBuff1 As String
        Dim intParam As Integer
        Dim intGroup, intRadSet, intSite, SiteSetting As Integer
        Dim x, y As Integer
        Dim GroupSetting, NumGroups, intChan As Integer
        Dim strMsg As String
        Dim intNumChan, cnt As Integer
        Dim blnLegacy As Boolean
        Dim intMaxRadioSet, intMaxSystemSet As Integer

        strFilename = Nothing
        strFileVer = Nothing
        strMsg = Nothing

        If strPreFile = "" Then
            'UPGRADE_WARNING: CommonDlg variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
            With OpenFileDialog1

                Select Case blnLoadCmdLine
                    Case False
                  .ShowReadOnly = False
                        .Multiselect = False
                         .CheckFileExists = True
                        .CheckPathExists = True
                        .FileName = "*.996"
                        .Filter = "FreeSCAN (*.996)|*.996|FreeSCAN Log File (*.fslog)|*.fslog|All Files (*.*)|*.*"
                        .FilterIndex = 0
                        .Title = "Open File"
                        .ShowDialog()
                        '-- Did the user select a file name?
                        If .FileName = "" Then
                            MsgBox("Please enter a file name")
                            Call LoadSystem("")
                            Exit Sub
                        Else
                            '-- Put some code here to save the file
                            strFilename = .FileName
                        End If
                    Case True
                        strFilename = RemoveQuotes(VB.Command())
                        blnLoadCmdLine = False
                End Select
            End With
        Else

            strFilename = strPreFile
        End If
        If Strings.Right(strFilename, 6) = ".fslog" Then
            'Load it up in the log viewer
            frmLog.Visible = True
            frmLog.OpenLogFileDialog1.FileName = strFilename
            Call frmLog.OpenLogFileDialog1_FileOk(Nothing, Nothing)
            Exit Sub
        End If

        If strFilename = "" Or strFilename = "*.996" Then Exit Sub
        If FileExists(strFilename) = False Then
            strFilename = CStr(MsgBox("FreeSCAN is unable to find the file " & strFilename, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "FreeSCAN"))
            Exit Sub
        End If
        Dim FF As Integer
        'wipe  memory
        ArrangeFileList((strFilename))
        FileOpen(1, strFilename, OpenMode.Input)
        Input(1, strFileVer)

        If strFileVer <> strCurrVer And strFileVer <> ".08BCD996T" Then
            FileClose(1)
            MsgBox("This file indicates version " & strFileVer & " and is not compatible with this version of FreeSCAN.")
            Exit Sub
        End If

        If strFileVer = ".08BCD996T" Then
            intMaxRadioSet = 100
            blnLegacy = True
        Else
            intMaxRadioSet = 200
            blnLegacy = False
        End If
        InitMemoryArray()
        'load radio settings
        For intRadSet = 1 To intMaxRadioSet
            Input(1, RadioSetting(intRadSet))
        Next intRadSet
        InitCOMPort()
        'load custom search range
        For x = 1 To 10
            For y = 0 To 16
                Input(1, CustSearch(x, y))
            Next y
        Next x
        strBuff = "0"
        'get number of sites to follow
        Input(1, strbuff)
        NumSites = Val(strbuff)
        Call FormWait(1, NumSites + 10, 1)
        Dim inputBuffer As String = Nothing
        If NumSites <> 0 Then
            For intSite = 1 To NumSites '***** TOP LEVEL Number of SYSTEMS
                For SiteSetting = 1 To MaxSetting
                    Input(1, varSite(intSite, 0, 0, SiteSetting))
                Next SiteSetting


                If varSite(intSite, 0, 0, 23) = "" Then varSite(intSite, 0, 0, 23) = CreateGroupID() 'insert id if  there is none
                'add QGL Lockout
                If Len(varSite(intSite, 0, 0, 8)) <> 10 Then
                    varSite(intSite, 0, 0, 8) = "111111111"
                End If
                Input(1, strBuff)
                NumGroups = Val(strBuff)
                If NumGroups > 0 Then
                    '********SECOND LEVEL, NUmber of Groups
                    For intGroup = 1 To NumGroups
                        For GroupSetting = 1 To MaxSetting
                            Input(1, inputBuffer)
                            '    Console.WriteLine("LoadSysteM:Reading value " & inputBuffer & " for setting #" & GroupSetting)
                            varSite(intSite, intGroup, 0, GroupSetting) = inputBuffer
                        Next GroupSetting
                        'this is done to compensate for a bug that stored system paramters in space reserved for ABP
                        If InStr(varSite(intSite, intGroup, 0, 62), "@") = 0 Then 'move some stuff around
                            Console.WriteLine("LoadSystem:Override")
                            varSite(intSite, intGroup, 0, 61) = "0"
                            varSite(intSite, intGroup, 0, 62) = varSite(intSite, intGroup, 0, 50)
                            varSite(intSite, intGroup, 0, 26) = varSite(intSite, intGroup, 0, 48)
                            varSite(intSite, intGroup, 0, 27) = varSite(intSite, intGroup, 0, 49)
                            varSite(intSite, intGroup, 0, 50) = Nothing
                            varSite(intSite, intGroup, 0, 48) = Nothing
                            varSite(intSite, intGroup, 0, 49) = Nothing
                        End If
                        'Set state
                        If varSite(intSite, intGroup, 0, 5) = "3" Then ' is this a site
                            'check state is set right
                            strBuff = varSite(intSite, intGroup, 0, 32)
                            If Not IsNumeric(strBuff) Then
                                varSite(intSite, intGroup, 0, 32) = "0"
                            ElseIf Val(strBuff) > 0 Or Val(strBuff) > 66 Then
                                varSite(intSite, intGroup, 0, 32) = "0"
                            End If
                        End If
                        '  Console.WriteLine("LoadSysteM:Reading value " & varSite(intSite, intGroup, 0, 26) & " for setting #")
                    Next intGroup '********END OF SECOND LEVEL
                End If
                Call FormWait(intSite, NumSites + 10, 1)
            Next intSite

        End If

        Call FormWait(intSite + 2, NumSites + 10, 1)
        'now start importing trunk frequencies
        Input(1, strMsg)
        If strMsg <> "TrunkSection" Then MsgBox("Incorrect position error, failed loading trunk frequencies") ': GoTo CriticError
        Input(1, intNumSites) 'number of sites with trunk frequencies
        For intChan = 1 To intNumSites
            Input(1, strTrunkFreq(intChan, 0)) 'freq
            Input(1, strTrunkFreq(intChan, 1)) 'lcn ! lockout
            Input(1, strTrunkFreq(intChan, 2)) 'groupid
            If blnLegacy = False Then
                For intParam = 3 To 10
                    Input(1, strTrunkFreq(intChan, intParam))
                Next intParam
            End If
            'process the lockout bit
            intParam = instr(strTrunkFreq(intChan, 1), "!")
            If intParam <> 0 Then 'seperate lockout status
                strTrunkFreq(intChan, 3) = CStr(Val(VB.Right(strTrunkFreq(intChan, 1), 1)))
                strTrunkFreq(intChan, 1) = CStr(Val(strTrunkFreq(intChan, 1)))
            Else
                strTrunkFreq(intChan, 3) = "0" 'no lockout is available so set to off
            End If
        Next intChan
        If Not EOF(1) Then
            'load search lockouts
            Input(1, strMsg)
            If strMsg <> "SEARCHLOCKOUTS" Then MsgBox("Out of position at search lockouts.")
            Input(1, intNumChan)
            For intChan = 1 To Val(CStr(intNumChan))
                Input(1, strMsg)
                strSearchLockout(intChan) = strMsg
            Next intChan
        End If
        If Not EOF(1) Then
            Input(1, strMsg)
            If strMsg <> "CHANDATA" Then
                MsgBox("Wrong header information found. File may be corrupt. Aborting.")
            Else
                Input(1, intNumChan)
                Do Until MaxChan >= intNumChan
                    ExpandChanArray()
                Loop
                For intChan = 1 To Val(CStr(intNumChan))
                    For intParam = 1 To 30
                        Input(1, ChanInfo(intChan, intParam))
                        If ChanInfo(intChan, intParam) = "123456789012345678901234567890" Or EOF(1) Then
                            MsgBox("Unexpected EOF. Aborting.")
                            Me.Text = strProgTitle & strCurrFile
                            SetFormCaption()
                            MarkChange()
                            intChan = intNumChan
                            intParam = 30
                            Exit For

                        End If
                        If intParam = 10 And blnDebug And Len(ChanInfo(intChan, intParam)) <> 16 Then
                            strBuff = strBuff
                        End If
                    Next intParam
                Next intChan
            End If
        End If
        Call FormWait(98, 100, 1)
        '************************************************SERVICE SEARCH SETTINGS
        If Not EOF(1) Then
            Input(1, strMsg)
            If strMsg <> "SERVSEARCH" Then
                MsgBox("Wrong header information found for service search. File may be corrupt. Aborting.")
            Else
                For ChanNum = 0 To 15
                    For cnt = 1 To 8
                        Input(1, strSS(ChanNum, cnt))
                    Next cnt
                Next ChanNum
            End If
        End If
        '**************FAVOURITES
        If Not EOF(1) Then
            Input(1, strMsg)
            If strMsg <> "FAV" Then
                MsgBox("Wrong header information for Favourites. File may be corrupt. ABorting")
            Else
                Input(1, strMsg) 'number of favourites
                intNumChan = Val(strMsg)
                If intNumChan > MaxFavs Then intNumChan = MaxFavs
                For intChan = 1 To intNumChan
                    For intParam = 1 To 10
                        Input(1, strMsg)

                        strFavs(intChan, intParam) = strMsg
                    Next intParam
                Next intChan
            End If
        End If

        If Not EOF(1) Then
            Input(1, strMsg)
            If strMsg = "IFEX" Then
                'global IF data available, load it
                Input(1, strMsg)
                intParam = Val(strMsg)
                If intParam >= 0 Then
                    ReDim strIFEX(intParam)
                    For intChan = 0 To intParam
                        Input(1, strMsg)
                        strIFEX(intChan) = strMsg
                    Next
                End If
            End If
        End If
        '***********************EXTENDED SERVICE SEARCH SETTINGS
        If Not EOF(1) Then
            Input(1, strMsg)
            If strMsg = "SSPXT" Then
                For x = 0 To 15
                    For y = 0 To 8
                        Input(1, strMsg)
                        strSSXT(x, y) = strMsg
                    Next
                Next

            End If
        Else
            For x = 0 To 15
                strSSXT(x, 1) = "1" 'agc
                strSSXT(x, 2) = "1" 'agc
                strSSXT(x, 3) = "0" 'p25 wait time
                strSSXT(x, 4) = "NONE" 'num tag
            Next
        End If
        '***********************BAND PLAN SETTING
        If Not EOF(1) Then
            Input(1, strMsg)
            If strMsg = "BANDSET" Then
                For x = 0 To 1
                    For y = 0 To 30
                        Input(1, strMsg)
                        BandSet(y, x) = strMsg
                    Next
                Next
            End If
        End If
        '***********************TGID LOCKOUT LIST
        If Not EOF(1) Then
            strBuff = Nothing
            strBuff1 = Nothing
            Input(1, strMsg)
            If strMsg = "GLIDFX" Then
                Input(1, strMsg)
                intChan = Val(strMsg)
                ReDim GliDX(intChan, 1)
                For x = 0 To intChan
                    Input(1, strBuff) 'sysID
                    Input(1, strBuff1) 'TGID
                    GliDX(x, 0) = strBuff
                    GliDX(x, 1) = strBuff1
                Next
            End If
        End If
        '*****************CUSTOM BAND PLAN SEARCH DATA
        If Not EOF(1) Then
            Input(1, strMsg)
            If strMsg = "CBPDATA" Then
                For x = 0 To 9
                    Input(1, CBPData(x))
                Next
            End If
        End If
        FileClose(1)
        'fix radiosetting(27), changed during different versions
        If Len(RadioSetting(27)) <> 1 Then
            RadioSetting(27) = "A"
        End If
        If RadioSetting(85) = "" Then 'insert default backlight mode if not present
            RadioSetting(85) = "KY"
        End If
        If RadioSetting(109) = "" Then 'set default state
            RadioSetting(109) = "1"
        End If
        'insert APCO settings if they are not already present
        For intSite = 1 To MaxSystems
            If varSite(intSite, 0, 0, 3) = "1" And varSite(intSite, 0, 0, 48) = "" Then
                varSite(intSite, 0, 0, 48) = APCOMode
                varSite(intSite, 0, 0, 49) = APCOThreshold
            ElseIf Val(varSite(intSite, 0, 0, 3)) > 3 Then
                For intGroup = 1 To MaxGroups
                    If varSite(intSite, intGroup, 0, 5) <> "" And varSite(intSite, intGroup, 0, 26) = "" Then
                        varSite(intSite, intGroup, 0, 26) = APCOMode
                        varSite(intSite, intGroup, 0, 27) = APCOThreshold
                    End If
                Next intGroup
            End If
        Next intSite
        Call FormWait(0, 1, 0)
        strCurrFile = strFilename
        Call ConvLegacyBP() 'convert the old style motorola bandplan to new
        'do some touching up
        If RadioSetting(90) = "" Then
            RadioSetting(90) = "OFF,OFF,OFF,OFF,OFF,OFF,OFF,OFF,OFF,OFF" 'ALERT COLOR
            RadioSetting(91) = "0,0,0,0,0,0,0,0,0,0" 'light pattern
        End If
        SetFormCaption()
        Me.DrawFavMenu()
        DrawSystemTree()
        UpdateViewMode()
        If frmGPSSummary.Visible Then
            Call frmGPSSummary.cmdLoadSystemList_Click(Nothing, Nothing)
        End If
        blnChgSaved = True
        Exit Sub
abort:
        Call FormWait(0, 1, 0)
        If Err.Number <> 32755 Then 'if the user didnt click cancel
            strBuff = Err.Description
            If Err.Number = 62 Then
                strBuff = "(File is truncated)"
            End If
            strMsg = CStr(MsgBox("Serious error occured while trying to load this file", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error " & Err.Number & strBuff))
        End If
        If FreeFile() <> 1 Then
            FileClose(1)
        End If
        Exit Sub
    End Sub
    Function GetNumChan(ByRef intSite As Integer, ByRef intGroup As Integer) As Integer
        'returns number of valid channels in a conventional group
        Dim x As Integer
        Dim y As Integer
        y = 0
        For x = 1 To MaxChan
            If ChanInfo(x, 10) = varSite(intSite, intGroup, 0, 10) Then
                y = y + 1
            End If
        Next x

        GetNumChan = y
    End Function
    Sub MakeBrandNewConfig()
        strCurrFile = "New Profile"
        InitMemoryArray()
        If frmCommsDownload.Visible = False And Form1.Visible = False Then
            Me.Visible = True
        End If
        Me.ReadyForm()
        blnChgSaved = True
        SetFormCaption()
        'Call frmSystemEditor.mnuCreateNewSystem_Click
    End Sub
    Sub LoadConvChanGrid()
        'loads all of the relevant frequencies for a conventional system
        'into a grid.
        Dim intChannel, intRow, NumFreq As Integer

        NumFreq = GetNumChan(intCurrentSys, intCurrentGroup)
        With grdConvChan
            .Rows.Clear()
            If GetSetting("FreeSCAN", "Settings", "AltColour", "0") = "1" Then
                'figure it out
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
            Else
                .AlternatingRowsDefaultCellStyle.BackColor = grdAPCO.AlternatingRowsDefaultCellStyle.BackColor
            End If
            If NumFreq = 0 Then Exit Sub
            .RowCount = NumFreq
            intRow = 0
        End With
        For intChannel = 1 To MaxChan
            If ChanInfo(intChannel, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then 'is this a valid channel?
                Call LoadGridRow(intRow, intChannel)
                intRow += 1
            End If
        Next intChannel

        Try
            If grdConvChan.RowCount > 1 And intCurrentChannel < grdConvChan.RowCount And intCurrentChannel > 0 Then
                Me.grdConvChan.CurrentCell = grdConvChan(0, intCurrentChannel - 1)
            Else
                Me.grdConvChan.CurrentCell = grdConvChan(0, 0)
            End If
        Catch
            'meh
        End Try
    End Sub

    Sub LoadGridRow(ByRef intRow As Integer, ByVal intChannel As Integer)
        If blnDebug = False Then On Error Resume Next

        Dim intMode As Integer
        'loads only one row in the grid
        blnBusy = True
        grdConvChan(0, intRow).Value = ChanInfo(intChannel, 1) 'name
        grdConvChan(1, intRow).Value = FormatFreq(Val(ChanInfo(intChannel, 2))) 'freq
        If Val(ChanInfo(intChannel, 5)) = 1 Then 'LO
            grdConvChan(2, intRow).Value = 1
        Else
            grdConvChan(2, intRow).Value = 0
        End If

        'cts/dtcss mode
        intMode = Val(ChanInfo(intChannel, 9))
        grdConvChan(3, intRow).Value = CTCSS(intMode)


        'TOne LO
        If Val(ChanInfo(intChannel, 11)) = 1 Then
            grdConvChan(4, intRow).Value = 1
        Else
            grdConvChan(4, intRow).Value = 0
        End If
        'attenution
        If Val(ChanInfo(intChannel, 6)) = 1 Then
            grdConvChan(5, intRow).Value = 1
        Else
            grdConvChan(5, intRow).Value = 0
        End If
        'pri
        If Val(ChanInfo(intChannel, 7)) = 1 Then
            grdConvChan(6, intRow).Value = 1
        Else
            grdConvChan(6, intRow).Value = 0
        End If

        'step size
        grdConvChan(7, intRow).Value = StepSize(Val(ChanInfo(intChannel, 19)), 0)
        'modulation mode
        grdConvChan(8, intRow).Value = ModMode(Val(ChanInfo(intChannel, 4)))
        'NAC
        grdConvChan(9, intRow).Value = ChanInfo(intChannel, 15)
        'Audio Type
        Select Case ChanInfo(intChannel, 12) 'Audio Type
            Case CStr(0)
                grdConvChan(10, intRow).Value = "All"
            Case CStr(1)
                grdConvChan(10, intRow).Value = "Analog Only"
            Case CStr(2)
                grdConvChan(10, intRow).Value = "Digital Only"
        End Select

        'Alert Tone Type  
        Select Case Val(ChanInfo(intChannel, 8))
            Case 0
                grdConvChan(11, intRow).Value = "0"
            Case Else
                grdConvChan(11, intRow).Value = ChanInfo(intChannel, 8)
        End Select
        'Alert Level

        Select Case Val(ChanInfo(intChannel, 13))
            Case 0
                grdConvChan(12, intRow).Value = "0"
            Case Else
                If IsNumeric(ChanInfo(intChannel, 13)) = True Then
                    grdConvChan(12, intRow).Value = ChanInfo(intChannel, 13)
                Else
                    grdConvChan(12, intRow).Value = "0"
                    ChanInfo(intChannel, 13) = "0"
                End If
        End Select

        'Alert COlor
        If ChanInfo(intChannel, 17) <> "" And IsNumeric(ChanInfo(intChannel, 17)) = False Then
            grdConvChan(13, intRow).Value = TCase(ChanInfo(intChannel, 17))
        Else
            grdConvChan(13, intRow).Value = "Off"
            ChanInfo(intChannel, 17) = "OFF"
        End If

        'alert light pattern
        Select Case ChanInfo(intChannel, 18)
            Case "0"
                'on
                grdConvChan(14, intRow).Value = "On"
            Case "1" 'SLOW
                grdConvChan(14, intRow).Value = "Slow"
            Case "2" 'FAST
                grdConvChan(14, intRow).Value = "Fast"
            Case Else
                grdConvChan(14, intRow).Value = "On"
                ChanInfo(intChannel, 18) = "0"
        End Select

        'volume offset
        If Val(ChanInfo(intChannel, 20)) >= -3 And Val(ChanInfo(intChannel, 20)) <= 3 Then
            grdConvChan(15, intRow).Value = CStr(Val(ChanInfo(intChannel, 20)))
        Else
            grdConvChan(15, intRow).Value = "0"
            ChanInfo(intChannel, 20) = "0"
        End If
        'number tag
        If ChanInfo(intChannel, 16) <> "" Then
            grdConvChan(16, intRow).Value = ChanInfo(intChannel, 16)
        Else
            grdConvChan(16, intRow).Value = "None"
            ChanInfo(intChannel, 16) = "NONE"
        End If
        'tape out
        If ChanInfo(intChannel, 3) = "1" Then
            grdConvChan(17, intRow).Value = True 'tapeout
        Else
            grdConvChan(17, intRow).Value = False
        End If
        grdConvChan(18, intRow).Value = ChanInfo(intChannel, 14) 'comment
        blnBusy = False
    End Sub



    Sub ReadyForm()
        'this prepares the form, assuming it was just loaded up
        intCurrentGroup = 0
        intCurrentSys = 0
        DrawSystemTree()
        ViewMode("OFF")


    End Sub
    Sub DrawSystemTree()
        If blnDebug = False Then On Error Resume Next
        'Draws a map of the system on the tree
        Dim CSite, CGroup As Integer
        Dim x, Gname As Integer
        Dim GroupNodeIndex, TreeKey As String
        Dim strMySite, strMyGroup As String
        Dim noditem As TreeNode, intUpdate As Integer
        Dim blnQuickDraw As Boolean
        Dim intSysCnt, intSysDrawn As Integer
        Dim intSysIndex As Integer = 0
        Dim intNodeIndex, intGrp As Integer
        Dim intGroupNodeIndex As Integer
        Dim SysOrder(MaxSystems, 4) As String ' 0=Index, 1=Name, 2=QK, 3=Type (short string MOT2)
        Dim SortMode As String
        Dim GrpOrder(MaxGroups, 4) As String  ' 0=Index, 1=Name, 2=QK, 3=Type (short string MOT2)'4=how many groups/sites
        Dim intGrpIndex As Integer = 0
        Dim intGrpCnt As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'Preserve existing state of systems
        Dim OldNodeCount As Integer = treeSystems.GetNodeCount(False)
        Dim ExpandedSys(OldNodeCount) As String
        Dim ExpandedCount As Integer = 0
        'Go through every node. If its expanded, remember its unique identifier
        For x = 0 To OldNodeCount - 1
            If treeSystems.Nodes.Item(x).IsExpanded = True Then
                ExpandedSys(ExpandedCount) = treeSystems.Nodes.Item(x).Tag
                ExpandedCount += 1
            End If
        Next

        treeSystems.Nodes.Clear()
        treeSystems.Sorted = False
        intNodeIndex = -1
        intSysCnt = -1
        treeSystems.BeginUpdate()
        DispStat("")
        If Val(RadioSetting(20)) = 0 Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Call FormWait(0, 1, 0)
            DispStat("Right click on left pane to create a new system")
        End If

        'otherwise display systems
        'search entire memory
        'setup for quickdraw
        If mnuQuickDrawAUto.Checked = True Then
            'are there more than 30 systems? if so then turn quick draw off
            blnQuickDraw = False
            For x = 1 To MaxSystems
                If Val(varSite(x, 0, 0, 3)) > 0 Then
                    intUpdate += 1
                End If

                If intUpdate = 40 Then
                    blnQuickDraw = True
                    Exit For
                End If
            Next x
            intUpdate = 0
        ElseIf mnuQuickDrawOff.Checked = True Then
            blnQuickDraw = False
        Else
            blnQuickDraw = True
        End If
        'determine how many systems need to be drawn
        SortMode = GetSetting("FreeSCAN", "Settings", "SortOrder", "0")
        SysOrder = GetSysArray(SortMode)
        intSysCnt = Val(SysOrder(0, 4))



        'INITIAL DRAW AND DESTROY - WORK AROUND FOR BUG IN MS TREE
        If intSysCnt > 0 Then
            noditem = treeSystems.Nodes.Add("INIT")
            noditem = treeSystems.Nodes(0).Nodes.Add("INIT")
            treeSystems.EndUpdate()
            My.Application.DoEvents()
            treeSystems.Nodes.Clear()
            treeSystems.BeginUpdate()
        End If

        For x = 0 To intSysCnt
            'Begin drawing the tree for that site
            intSysIndex = Val(SysOrder(x, 0))
            TreeKey = "S" & intSysIndex.ToString("D4") 'Key for first site would be S0001
            intNodeIndex += 1

            noditem = treeSystems.Nodes.Add(SysKey(intSysIndex))
            treeSystems.Nodes(intNodeIndex).Tag = TreeKey
            'HIGHLIGHT l/o systems
            If Val(varSite(intSysIndex, 0, 0, 2)) = 1 Then
                treeSystems.Nodes(intNodeIndex).ForeColor = Color.Red
            End If
            'trunk system highlighting
            If mnuHighlightTrunkSys.Checked Then
                If varSite(intSysIndex, 0, 0, 3) <> "1" Then
                    treeSystems.Nodes(intNodeIndex).BackColor = Color.LightBlue
                End If
            End If
            intSysDrawn += 1
            'expand root
            'find out if there are any groups inside
            intGroupNodeIndex = -1
            GrpOrder = GetGroupArray(intSysIndex, SortMode)
            For intGrp = 0 To Val(GrpOrder(0, 4)) 'loop through all possible groups and display them onscreen
                CGroup = GrpOrder(intGrp, 0) 'mem index for the group/site
                If intCurrentSys = intSysIndex Then
                    strMySite = TreeKey
                End If

                GroupNodeIndex = TreeKey & "G" & CGroup.ToString("D4")  ' group keys will be S0001G0001
                If intCurrentSys = intSysIndex And intCurrentGroup = CGroup Then
                    strMyGroup = GroupNodeIndex
                End If
                treeSystems.Nodes(intNodeIndex).Nodes.Add(SiteKey(intSysIndex, CGroup))
                intGroupNodeIndex += 1
                treeSystems.Nodes(intNodeIndex).Nodes(intGroupNodeIndex).Tag = GroupNodeIndex
                With treeSystems.Nodes(intNodeIndex).Nodes(intGroupNodeIndex)

                    'site highlighting
                    If mnuHighlightSite.Checked Then
                        If Val(varSite(intSysIndex, CGroup, 0, 5)) = 3 Then
                            .BackColor = Color.Yellow
                        End If
                    End If
                    'group highlighting
                    If mnuGroupHighlight.Checked Then
                        If Val(varSite(intSysIndex, 0, 0, 3)) > 1 And Val(varSite(intSysIndex, CGroup, 0, 5)) = 2 Then
                            .BackColor = Color.LightGreen
                        End If
                    End If
                    'lockout highlighting
                    If Val(varSite(intSysIndex, CGroup, 0, 3)) = 1 Then
                        .ForeColor = Color.Red
                    End If
                End With
            Next intGrp



        Next x

        If blnQuickDraw = False Then
            treeSystems.ExpandAll()
        ElseIf ExpandedCount > 0 Then
            'Go through and expand previous systems that were expanded
            Dim CurrentNode As Integer
            'Go through every node
            For CurrentNode = 0 To treeSystems.GetNodeCount(False) - 1
                For x = 0 To ExpandedCount 'Is this one of our nodes that was noted as being expanded? then expand it
                    If treeSystems.Nodes.Item(CurrentNode).Tag = ExpandedSys(x) Then
                        treeSystems.Nodes.Item(CurrentNode).ExpandAll()
                        x = ExpandedCount
                    End If
                Next
            Next
        End If

        If intSysCnt = 0 Or intCurrentSys = 0 Then
            ViewMode("OFF")
        End If
        treeSystems.EndUpdate()
        'this automatically select current group/systems
        UpdateTreeSelection()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        treeSystems.EndUpdate()

    End Sub

    Function SysKey(ByRef intSystem As Integer) As String
        Dim strKey As String
        strKey = Nothing
        'system type
        If mnuShowSysType.Checked = True Then
            strKey = "[" & SysType(Val(varSite(intSystem, 0, 0, 3)), 1) & "] "
        End If


        strKey = strKey & varSite(intSystem, 0, 0, 1)
        'Adds the quicklockout key to a system
        If mnuShowQK.Checked = True Then
            If varSite(intSystem, 0, 0, 4) <> "" And varSite(intSystem, 0, 0, 4) <> "." Then
                strKey &= " [" & varSite(intSystem, 0, 0, 4) & "] "
            End If
        End If
        SysKey = strKey
    End Function
    Function SiteKey(ByRef intSystem As Integer, ByRef intSite As Integer) As String
        Dim strKey As String
        strKey = Nothing
        'Adds the quicklockout key to a site


        If mnuShowSysType.Checked = True And Val(varSite(intSystem, intSite, 0, 5)) = 3 Then
            strKey = "[" & SiteType(Val(varSite(intSystem, intSite, 0, 9)), 1) & "] "
        ElseIf mnuShowSysType.Checked = True Then
            strKey = "[GRP] "
        End If

        strKey = strKey & varSite(intSystem, intSite, 0, 1)
        If mnuShowQK.Checked = True Then
            If varSite(intSystem, intSite, 0, 2) <> "" And varSite(intSystem, intSite, 0, 2) <> "." Then
                strKey &= " [" & varSite(intSystem, intSite, 0, 2) & "] "
            End If
        End If
        SiteKey = strKey
    End Function








    Private Sub chkControlChanOnly_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkControlChanOnly.CheckStateChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, intCurrentGroup, 0, 8) = MakeBinary((chkControlChanOnly.CheckState))
        MarkChange()
    End Sub






    Private Sub chkConvGroupLockout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkConvGroupLockout.CheckStateChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 3) = CStr(chkConvGroupLockout.CheckState)
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
        MarkChange()
    End Sub


    Private Sub chkDataSkip_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDataSkip.CheckStateChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, 0, 0, 9) = MakeBinary((chkDataSkip.CheckState))
        MarkChange()

    End Sub


    Private Sub chkICall_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkICall.CheckStateChanged
        MarkChange()

        varSite(intCurrentSys, 0, 0, 15) = MakeBinary((chkICall.CheckState))
    End Sub


    Private Sub chkMotDigEndCode_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkMotDigEndCode.CheckStateChanged
        MarkChange()

        varSite(intCurrentSys, 0, 0, 27) = MakeBinary((chkMotDigEndCode.CheckState))
    End Sub


    Private Sub chkMotStatusBit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkMotStatusBit.CheckStateChanged
        If blnBusy Then Exit Sub
        MarkChange()

        varSite(intCurrentSys, 0, 0, 12) = MakeBinary((chkMotStatusBit.CheckState))
    End Sub


    Private Sub chkQGLCnv_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkQGLCnv.CheckStateChanged
        Dim index As Short = chkQGLCnv.GetIndex(eventSender)
        'save the entire QK array
        If blnDebug = False Then On Error Resume Next
        If blnBusy = True Then Exit Sub

        Dim strQGL As String = Nothing
        Dim cnt As Integer
        For cnt = 1 To 10
            strQGL = strQGL & Val(CStr(chkQGLCnv(cnt).CheckState))
        Next cnt
        varSite(intCurrentSys, 0, 0, 8) = strQGL
        MarkChange()
        DispStat("Quick key " & index & " state saved.")
    End Sub


    Private Sub chkQGLTrn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkQGLTrn.CheckStateChanged
        Dim index As Short = chkQGLTrn.GetIndex(eventSender)
        'save the entire QK array
        If blnDebug = False Then On Error Resume Next

        If blnBusy = True Then Exit Sub
        Dim strQGL As String = Nothing
        Dim cnt As Integer
        For cnt = 1 To 10
            strQGL = strQGL & Val(CStr(chkQGLTrn(cnt).CheckState))
        Next cnt
        varSite(intCurrentSys, 0, 0, 8) = strQGL
        MarkChange()
        DispStat("Quick key " & index & " state saved.")
    End Sub


    Private Sub chkSiteLockedOut_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSiteLockedOut.CheckStateChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, 0, 0, 2) = MakeBinary((chkSiteLockedOut.CheckState))
        MarkChange()
        Call UpdateDisplayNode(intCurrentSys, 0)
    End Sub


    Private Sub chkSysGPSEnable_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSysGPSEnable.CheckStateChanged
        If blnBusy Then Exit Sub
        varSite(intCurrentSys, 0, 0, 22) = MakeBinary((chkSysGPSEnable.CheckState))
        MarkChange()
    End Sub


    Private Sub chkTGIDGroupLockout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkTGIDGroupLockout.CheckStateChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 3) = CStr(chkTGIDGroupLockout.CheckState)
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
        MarkChange()
    End Sub



    Private Sub chkTrnGPSEnable_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkTrnGPSEnable.CheckStateChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, intCurrentGroup, 0, 16) = MakeBinary((chkTrnGPSEnable.CheckState))
        MarkChange()
    End Sub


    Private Sub chkTrnSiteAtt_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkTrnSiteAtt.CheckStateChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, intCurrentGroup, 0, 7) = MakeBinary((chkTrnSiteAtt.CheckState))
        MarkChange()
    End Sub


    Private Sub chkTrnSiteLO_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkTrnSiteLO.CheckStateChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, intCurrentGroup, 0, 3) = MakeBinary((chkTrnSiteLO.CheckState))
        MarkChange()
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
    End Sub


    Private Sub chkUseMotEndCode_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkUseMotEndCode.CheckStateChanged
        If blnBusy Then Exit Sub
        MarkChange()
        varSite(intCurrentSys, 0, 0, 13) = MakeBinary((chkUseMotEndCode.CheckState))
    End Sub



    Private Sub cmbAPCO_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAPCO.SelectedIndexChanged
        Dim index As Short = cmbAPCO.GetIndex(eventSender)
        If blnBusy = True Then Exit Sub
        MarkChange()
        'saves apco settings
        Select Case index
            Case 0 'conv
                varSite(intCurrentSys, 0, 0, 48) = cmbAPCO(0).Text
            Case 1
                varSite(intCurrentSys, 0, 0, 49) = cmbAPCO(1).Text
            Case 2 'trunked
                varSite(intCurrentSys, intCurrentGroup, 0, 26) = cmbAPCO(2).Text
            Case 3
                varSite(intCurrentSys, intCurrentGroup, 0, 27) = cmbAPCO(3).Text
        End Select
    End Sub






    Private Sub cmbConvDelayTime_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbConvDelayTime.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 6) = cmbConvDelayTime.Text
        MarkChange()
    End Sub


    Private Sub cmbConvGroupQuickKey_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbConvGroupQuickKey.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 2) = cmbConvGroupQuickKey.Text
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
        MarkChange()
    End Sub



    Private Sub cmbConvHoldTime_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbConvHoldTime.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 5) = cmbConvHoldTime.Text
        MarkChange()
    End Sub


    Private Sub cmbConvStartupKey_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbConvStartupKey.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 7) = cmbConvStartupKey.Text
        MarkChange()
    End Sub




    Private Sub cmbQuickKey_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbQuickKey.SelectedIndexChanged

        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 4) = cmbQuickKey.Text
        MarkChange()
        Call UpdateDisplayNode(intCurrentSys, 0)

    End Sub






    Private Sub cmbSiteQK_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSiteQK.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 2) = cmbSiteQK.Text
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
        MarkChange()
    End Sub



    Private Sub cmbTGIDGroupQuickkey_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTGIDGroupQuickkey.SelectedIndexChanged
        If blnBusy Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 2) = cmbTGIDGroupQuickkey.Text
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
        MarkChange()
    End Sub

    Private Sub cmbTrnEmergAlertLevel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTrnEmergAlertLevel.SelectedIndexChanged
        If blnBusy Then Exit Sub
        MarkChange()
        varSite(intCurrentSys, 0, 0, 26) = cmbTrnEmergAlertLevel.Text
    End Sub


    Private Sub cmbTrnEmergAlertType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTrnEmergAlertType.SelectedIndexChanged
        If blnBusy Then Exit Sub
        MarkChange()
        varSite(intCurrentSys, 0, 0, 25) = cmbTrnEmergAlertType.Text
    End Sub



    Private Sub cmbTrnModMode_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTrnModMode.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 6) = cmbTrnModMode.Text
        MarkChange()
    End Sub


    Private Sub cmbTrnSiteHoldTime_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTrnSiteHoldTime.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 4) = cmbTrnSiteHoldTime.Text
        MarkChange()
    End Sub


    Private Sub cmbTrnSiteStartupKey_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTrnSiteStartupKey.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 12) = cmbTrnSiteStartupKey.Text
        MarkChange()
    End Sub


    Private Sub cmbTrnSiteType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTrnSiteType.SelectedIndexChanged

        'enable disable tabs first
        'enable APCO band plan tab
        Frame9.Visible = False
        tabTrunkSite.TabPages.Item(2).Enabled = False
        Dim cnt As Integer
        Dim strBuff As String
        strBuff = cmbTrnSiteType.Text
        If strBuff = SiteType(4, 0) Or strBuff = SiteType(5, 0) Or strBuff = (SiteType(13, 0)) Then
            Frame9.Visible = True
        End If
        If strBuff = SiteType(6, 0) Or strBuff = SiteType(15, 0) Or strBuff = SiteType(14, 0) Then
            tabTrunkSite.TabPages.Item(2).Enabled = True
        End If
        If strBuff = SiteType(9, 0) Or strBuff = SiteType(10, 0) Or strBuff = SiteType(11, 0) Or strBuff = SiteType(12, 0) Then
            chkControlChanOnly.Enabled = False
        Else
            chkControlChanOnly.Enabled = True
        End If

        If blnBusy = True Then Exit Sub

        For cnt = 0 To 16
            If cmbTrnSiteType.Text = SiteType(cnt, 0) Then
                varSite(intCurrentSys, intCurrentGroup, 0, 9) = CStr(cnt)
                Exit For
            End If
        Next cnt
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
        MarkChange()

    End Sub

    Sub UpdateDisplayNode(ByRef intSys As Integer, ByRef intGroup As Integer)

        'updates one display node rather than redrawing the entire tree
        Dim intCnt As Integer
        Dim strKey As String, strBuff As String
        Dim intSysNode, intGrpNode, intGrpNodeCnt, intSysNodeCnt As Integer
        Dim varNode As TreeNode
        If blnDebug = False Then On Error Resume Next

        If intGroup = 0 Then  'iterate through all system nodes
            For Each varNode In treeSystems.Nodes
                strKey = varNode.Tag
                strBuff = (VB.Left(strKey, 5))
                intSysNode = Val(VB.Right(strBuff, 4))
                If intSysNode = intSys Then 'update system name
                    varNode.Text = SysKey(intSys)
                    'color
                    If varSite(intSys, 0, 0, 2) = "1" Then
                        varNode.ForeColor = Color.Red
                    Else
                        varNode.ForeColor = Color.Black
                    End If
                    Exit Sub
                End If
            Next
        ElseIf intGroup > 0 Then 'iterate through all group/site nodes
            With treeSystems
                For intSysNodeCnt = 0 To .Nodes.Count  'loop through every parent node
                    If Val(OldMid(.Nodes(intSysNodeCnt).Tag, 2, 4)) = intSys Then  'is this the right parent node?
                        For intGrpNodeCnt = 0 To .Nodes(intSysNodeCnt).Nodes.Count        'loop through every sub node
                            'get the site & group numbers
                            strKey = .Nodes(intSysNodeCnt).Nodes(intGrpNodeCnt).Tag
                            strBuff = (VB.Left(strKey, 5))
                            intSysNode = Val(VB.Right(strBuff, 4))
                            intGrpNode = Val(VB.Right(strKey, 4))
                            'is this the one we are interested in??
                            If intGrpNode = intGroup Then
                                varNode = .Nodes(intSysNodeCnt).Nodes(intGrpNodeCnt)
                                varNode.Text = SiteKey(intSys, intGroup)
                                If varSite(intSys, intGroup, 0, 3) = "1" Then
                                    varNode.ForeColor = Color.Red
                                Else
                                    varNode.ForeColor = Color.Black
                                End If
                                Exit Sub
                            End If
                        Next
                    End If
                Next intSysNodeCnt
            End With
        End If
    End Sub

    Function MakeItKosherCTCSS(ByRef intMode As String) As String
        Dim x, intNewMode As Integer
        'takes a ctcss from user mode and translater
        'to radio code
        For x = 1 To 231
            If Trim(UCase(intMode)) = UCase(CTCSS(x)) And CTCSS(x) <> "" Then
                intNewMode = x
                x = 231
            End If
        Next x

        MakeItKosherCTCSS = intNewMode
    End Function
    Function DispStat(ByRef intMessage As String) As String
        'writes information to the status bar
        DispStat = Nothing
        StatusBar.Items.Item(0).Text = intMessage
    End Function



    'UPGRADE_WARNING: ComboBox event cmbTrnSysType.Change was upgraded to cmbTrnSysType.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
    Private Sub cmbTrnSysType_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTrnSysType.TextChanged
        If cmbTrnSysType.Text = SysType(2, 0) Then
            cmdEditFleetMap.Enabled = True
        Else
            cmdEditFleetMap.Enabled = False
        End If
    End Sub


    Private Sub cmbTrnSysType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTrnSysType.SelectedIndexChanged
        If cmbTrnSysType.Text = SysType(2, 0) Then
            cmdEditFleetMap.Enabled = True
        Else
            cmdEditFleetMap.Enabled = False
        End If

        If blnBusy = True Then Exit Sub
        'change the system type, and the sites below it
        Dim intSite, intSysType, intSiteType As Integer

        'has the system type changed?
        intSysType = Val(varSite(intCurrentSys, 0, 0, 3))
        If cmbTrnSysType.SelectedIndex + 2 = intSysType Then
            'system type has stayed the same, dont do anything
            Exit Sub
        End If

        'reset site types for every site, mabey there should be a warning?
        intSiteType = MsgBox("Caution: Changing the system type will change all the site types within that system. Are you sure you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Caution")
        If intSiteType = 7 Then 'user backed out
            Exit Sub
        End If
        'reset system type
        varSite(intCurrentSys, 0, 0, 3) = CStr(cmbTrnSysType.SelectedIndex + 2)

        Select Case varSite(intCurrentSys, 0, 0, 3)
            Case CStr(2) 'mot type i
                intSiteType = 7
            Case CStr(3) 'mot type 2
                intSiteType = 1
            Case CStr(4) 'edacs , wide
                intSiteType = 10
            Case CStr(5) 'edacs scat
                intSiteType = 11
            Case CStr(6) 'ltr
                intSiteType = 12
            Case CStr(7)
                intSiteType = 14
            Case CStr(8)
                intSiteType = 15
            Case CStr(9) ' mototrbo
                intSiteType = 17
            Case CStr(10) 'dmr
                intSiteType = 18
        End Select
        For intSite = 1 To MaxGroups
            If varSite(intCurrentSys, intSite, 0, 5) = "3" Then 'this is a site, change it
                varSite(intCurrentSys, intSite, 0, 9) = CStr(intSiteType)
            End If
        Next intSite
        DrawSystemTree()
    End Sub


    Private Sub cmbTrunkSysDelay_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTrunkSysDelay.SelectedIndexChanged
        'delay time
        If blnBusy = True Then Exit Sub
        MarkChange()
        varSite(intCurrentSys, 0, 0, 6) = cmbTrunkSysDelay.Text
    End Sub



    Private Sub cmdAutoCalcBP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAutoCalcBP.Click
        Call AutoCalcUpper(intCurrentSys, intCurrentGroup, False)
        MarkChange()
        Call LoadData("TRUNKSITESETUP")
    End Sub


    Private Sub cmdConvChanMoveUp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConvChanMoveUp.Click
        'moved a channel up in memory and display
        Dim tempchan(MaxChanSetting) As String
        Dim intParam, intCurrChan As Integer
        Dim intPrevChan As Integer

        If intCurrentChannel <= 1 Then

        Else
            intCurrChan = GetRealChan(intCurrentSys, intCurrentGroup, intCurrentChannel)
            intPrevChan = GetRealChan(intCurrentSys, intCurrentGroup, intCurrentChannel - 1)
            'swap it with the channel above and redraw
            For intParam = 0 To MaxChanSetting
                'copy the existing into a buffer
                tempchan(intParam) = ChanInfo(intCurrChan, intParam)
                '        'now copy the one above it into its space
                ChanInfo(intCurrChan, intParam) = ChanInfo(intPrevChan, intParam)
                'now copy the temp one into the previous used slot
                ChanInfo(intPrevChan, intParam) = tempchan(intParam)
            Next intParam

            intCurrentChannel = intCurrentChannel - 1

            If frmGroupTrunk.Visible = True Then
                LoadTrunkChanGrid()
                Me.grdTGID.CurrentCell = Me.grdTGID(0, intCurrentChannel - 1)
            Else
                LoadConvChanGrid()
                Me.grdConvChan.CurrentCell = Me.grdConvChan(0, intCurrentChannel - 1)
            End If

        End If
        MarkChange()
    End Sub

    Private Sub cmdConvChannelMoveDown_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConvChannelMoveDown.Click
        'moved a channel down in memory and display
        Dim tempchan(MaxChanSetting) As String
        Dim intParam, intCurrChan As Integer
        Dim intNextChan As Integer
        Dim RowCount As Integer
        If Not blnDebug Then On Error Resume Next
        If frmGroupTrunk.Visible = False Then
            RowCount = grdConvChan.RowCount
        Else
            RowCount = grdTGID.RowCount
        End If
        If intCurrentChannel = RowCount Then
            Exit Sub
        End If
        'swap it with the channel below and redraw
        intCurrChan = GetRealChan(intCurrentSys, intCurrentGroup, intCurrentChannel)
        intNextChan = GetRealChan(intCurrentSys, intCurrentGroup, intCurrentChannel + 1)
        'swap it with the channel above and redraw
        For intParam = 0 To MaxChanSetting
            'copy the current one into a buffer
            tempchan(intParam) = ChanInfo(intCurrChan, intParam)
            '        'now copy the destination it into the current one
            ChanInfo(intCurrChan, intParam) = ChanInfo(intNextChan, intParam)
            'now copy the temp one into the destination slot
            ChanInfo(intNextChan, intParam) = tempchan(intParam)
        Next intParam

        If intCurrentChannel < RowCount Then
            intCurrentChannel += 1
        End If
        If frmGroupTrunk.Visible = True Then
            LoadTrunkChanGrid()
            Me.grdTGID.CurrentCell = Me.grdTGID(0, intCurrentChannel - 1)
        Else
            LoadConvChanGrid()
            Me.grdConvChan.CurrentCell = Me.grdConvChan(0, intCurrentChannel - 1)
        End If
        MarkChange()
    End Sub

    Private Sub cmdConvGrab_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConvGrab.Click
        Me.Visible = False
        'If frmDupesN_N.Visible = True Then frmDupesN_N.Visible = False
        frmParse.Visible = True

    End Sub

    Private Sub cmdDeleteConvChan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteConvChan.Click
        'delete the highlighted channel from memory
        Dim Response As Integer
        Dim strMsg As String
        Dim intChan As Integer
        Dim NumChan As Integer
        Dim intParam As Integer
        BuildGridArray()

        If IsArray(intGridSel) Then 'do multi channel delete, otherwise single channel
            If WarnDelete Then
                strMsg = "Are you sure you want to delete? " & UBound(intGridSel) + 1 & " channel(s) selected."
                Response = MsgBox(strMsg, MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Delete Channels?")
            Else
                Response = 1
            End If

            Select Case Response
                Case 2 'cancel
                    Exit Sub
                Case 1 'delete
                    'nuke the channels
                    NumChan = UBound(intGridSel)
                    Dim NukeArray(NumChan) As Integer
                    For intChan = 0 To NumChan
                        NukeArray(intChan) = GetRealChan(intCurrentSys, intCurrentGroup, intGridSel(intChan) + 1)
                    Next
                    For intChan = 0 To NumChan
                        For intParam = 0 To MaxChanSetting
                            ChanInfo(NukeArray(intChan), intParam) = Nothing
                        Next
                        strMsg = ""
                    Next intChan
                    DispStat(NumChan + 1 & " channels deleted.")
                    intCurrentChannel = 1
                    LoadConvChanGrid()
                    MarkChange()
            End Select
            Exit Sub
        End If

    End Sub

    Sub WipeConvChan(ByRef intsite As Integer, ByRef intgroup As Integer, ByRef intChan As Integer)
        'wipes a channel from memory, by moving everything in memory up one spot
        Dim x As Integer
        Dim intChanNum As Integer
        intChanNum = GetRealChan(intsite, intgroup, intChan)
        For x = 0 To MaxChanSetting
            ChanInfo(intChanNum, x) = Nothing
        Next x
        intCurrentChannel = 1
        varSite(intsite, intgroup, 0, 34) = "1"
        blnChgSaved = False
    End Sub



    Private Sub cmdDelTGID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelTGID.Click
        'delete the highlighted channel from memory
        Dim Response As Integer
        Dim strMsg As String
        Dim intChan As Integer
        Dim NumChan As Integer
        Dim intParam As Integer
        BuildGridArray()

        If IsArray(intGridSel) Then 'do multi channel delete, otherwise single channel
            If WarnDelete Then
                strMsg = "Are you sure you want to delete? " & UBound(intGridSel) + 1 & " channel(s) selected."
                Response = MsgBox(strMsg, MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Delete Channels?")
            Else
                Response = 1
            End If

            Select Case Response
                Case 2 'cancel
                    Exit Sub
                Case 1 'delete
                    'nuke the channels
                    NumChan = UBound(intGridSel)
                    Dim NukeArray(NumChan) As Integer
                    For intChan = 0 To NumChan
                        NukeArray(intChan) = GetRealChan(intCurrentSys, intCurrentGroup, intGridSel(intChan) + 1)
                    Next
                    For intChan = 0 To NumChan
                        For intParam = 0 To MaxChanSetting
                            ChanInfo(NukeArray(intChan), intParam) = Nothing
                        Next
                        strMsg = ""
                    Next intChan
                    DispStat(NumChan + 1 & " channels deleted.")
                    intCurrentChannel = 1
                    LoadTrunkChanGrid()
                    MarkChange()
            End Select
            Exit Sub
        End If
    End Sub


    Private Sub cmdEditFleetMap_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEditFleetMap.Click
        ViewMode("FleetMap")

    End Sub



    Private Sub cmdEZGrabTGID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEZGrabTGID.Click
        Me.Visible = False
        If frmDupeN_N.Visible = True Then frmDupeN_N.Visible = False
        frmParseTGID.Visible = True

    End Sub

    Private Sub cmdEZGrabTrunk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEZGrabTrunk.Click
        Me.Visible = False
        If frmDupeN_N.Visible = True Then frmDupeN_N.Visible = False
        frmParseTrunk.Visible = True

    End Sub

    Private Sub cmdFreegQK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFreeGQK.Click
        Dim index As Short = cmdFreeGQK.GetIndex(eventSender)
        'finds an unused groups QK
        Dim intGrp, intQK As Integer
        Dim blnFound As Boolean
        Dim intQKFound, intSite As Integer
        If blnDebug = False Then On Error Resume Next
        If index < 2 Then 'use group quick key mode
            For intQK = 0 To 9
                blnFound = True
                For intGrp = 1 To MaxGroups
                    If Val(varSite(intCurrentSys, intGrp, 0, 2)) = intQK And varSite(intCurrentSys, intGrp, 0, 2) <> "." Then
                        If varSite(intCurrentSys, intGrp, 0, 5) = "1" Or varSite(intCurrentSys, intGrp, 0, 5) = "2" Then
                            blnFound = False
                            intGrp = MaxGroups
                        End If
                    End If
                Next intGrp
                If blnFound = True Then
                    intQKFound = intQK
                    intQK = 9
                End If
            Next intQK
            If blnFound = True Then
                varSite(intCurrentSys, intCurrentGroup, 0, 2) = CStr(intQKFound)
                If index = 0 Then
                    cmbConvGroupQuickKey.SelectedIndex = intQKFound + 1
                Else
                    cmbTGIDGroupQuickkey.SelectedIndex = intQKFound + 1
                End If
            Else
                MsgBox("Sorry, but there are no unused group Quick Keys available.")
            End If
        ElseIf index = 2 Or index = 4 Then  'use system/site quick key mode
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
            If blnFound = True And varSite(intCurrentSys, 0, 0, 3) = "1" Then 'a free qk available, assign to conv site
                varSite(intCurrentSys, 0, 0, 4) = CStr(intQKFound)
                cmbQuickKey.SelectedIndex = intQKFound + 1
                Call UpdateDisplayNode(intCurrentSys, 0)
            ElseIf blnFound = True Then  'assign to trunked system
                varSite(intCurrentSys, intCurrentGroup, 0, 2) = CStr(intQKFound)
                cmbSiteQK.SelectedIndex = intQKFound + 1
                Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
            Else 'no free system/site key was found
                MsgBox("Sorry, but there are no free system/site quick keys available.")
            End If
        End If
    End Sub

    Private Sub cmdJust_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdJust.Click
        Dim index As Short = cmdJust.GetIndex(eventSender)
        If blnBusy = True Then Exit Sub
        If blnDebug = False Then On Error Resume Next
        Dim Response As Integer
        Dim strMsg As String
        Dim intParam, intRow, intStartrow, intEndRow, intChan, intBuff As Integer
        Dim NukeArray(1000) As Single
        Dim strDir As String
        BuildGridArray()
        If IsArray(intGridSel) = False Then Exit Sub

        'build an array of channels that need to be done
        For intRow = 0 To UBound(intGridSel)
            NukeArray(intRow) = GetRealChan(intCurrentSys, intCurrentGroup, intGridSel(intRow) + 1)
        Next intRow
        'select direction to justify channels
        Select Case index
            Case 0
                strDir = "L"
            Case 1
                strDir = "C"
            Case Else
                strDir = "R"
        End Select

        For intChan = 0 To UBound(intGridSel)
            'perform ACTIO HERE

            ChanInfo(NukeArray(intChan), 1) = frmJust.Justify(ChanInfo(NukeArray(intChan), 1), strDir)
            LoadGridRow((intGridSel(intChan)), NukeArray(intChan))
        Next intChan

        Me.grdConvChan.CurrentCell = grdConvChan(0, intGridSel(0))
        MarkChange()
    End Sub

    Private Sub cmdJustCnvGrp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdJustCnvGrp.Click
        Dim index As Short = cmdJustCnvGrp.GetIndex(eventSender)
        Dim strDir As String
        Select Case index
            Case 0
                strDir = "L"
            Case 1
                strDir = "C"
            Case Else
                strDir = "R"
        End Select
        With txtConvGroupName

            .Text = frmJust.Justify(.Text, strDir)
        End With
    End Sub

    Private Sub cmdJustCnvSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdJustCnvSys.Click
        Dim index As Short = cmdJustCnvSys.GetIndex(eventSender)
        Dim strDir As String
        Select Case index
            Case 0
                strDir = "L"
            Case 1
                strDir = "C"
            Case Else
                strDir = "R"
        End Select
        With txtSiteName

            .Text = frmJust.Justify(.Text, strDir)
        End With
    End Sub

    Private Sub cmdJustTGID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdJustTGID.Click
        Dim index As Short = cmdJustTGID.GetIndex(eventSender)
        Dim strDir As String
        Select Case index
            Case 0
                strDir = "L"
            Case 1
                strDir = "C"
            Case Else
                strDir = "R"
        End Select
        With txtTGIDGroupName

            .Text = frmJust.Justify(.Text, strDir)
        End With
    End Sub

    Private Sub cmdJustTGIDChan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdJustTGIDChan.Click
        Dim index As Short = cmdJustTGIDChan.GetIndex(eventSender)
        If blnBusy = True Then Exit Sub
        If blnDebug = False Then On Error Resume Next
        Dim Response As Integer
        Dim strMsg As String
        Dim intParam, intRow, intStartrow, intEndRow, intChan, intBuff As Integer
        Dim NukeArray(1000) As Single
        Dim strDir As String
        BuildGridArray()
        If IsArray(intGridSel) = False Then Exit Sub
        intBuff = -1
        'build an array of channels that need to be done
        For intRow = 0 To UBound(intGridSel)
            intBuff = intBuff + 1
            NukeArray(intRow) = GetRealChan(intCurrentSys, intCurrentGroup, intGridSel(intRow) + 1)
        Next intRow


        'select direction to justify channels
        Select Case index
            Case 0
                strDir = "L"
            Case 1
                strDir = "C"
            Case Else
                strDir = "R"
        End Select
        blnBusy = True
        For intChan = 0 To UBound(intGridSel)
            'perform ACTIO HERE
            ChanInfo(NukeArray(intChan), 1) = frmJust.Justify(ChanInfo(NukeArray(intChan), 1), strDir)

            LoadTrunkChanGridRow((intGridSel(intChan)), NukeArray(intChan))
        Next intChan
        blnBusy = False
        grdTGID.CurrentCell = grdTGID(0, intGridSel(0))
        MarkChange()

    End Sub

    Private Sub cmdJustTrnSite_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdJustTrnSite.Click
        Dim index As Short = cmdJustTrnSite.GetIndex(eventSender)
        Dim strDir As String
        Select Case index
            Case 0
                strDir = "L"
            Case 1
                strDir = "C"
            Case Else
                strDir = "R"
        End Select
        With txtTrunkSiteName

            .Text = frmJust.Justify(.Text, strDir)
        End With
    End Sub

    Private Sub cmdJustTrnSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdJustTrnSys.Click
        Dim index As Short = cmdJustTrnSys.GetIndex(eventSender)
        Dim strDir As String
        Select Case index
            Case 0
                strDir = "L"
            Case 1
                strDir = "C"
            Case Else
                strDir = "R"
        End Select
        With txtTrunkSysName

            .Text = frmJust.Justify(.Text, strDir)
        End With
    End Sub

    Private Sub cmdMoveDownTGID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMoveDownTGID.Click
        'moved a channel down in memory and display
        Call cmdConvChannelMoveDown_Click(cmdConvChannelMoveDown, New System.EventArgs())

    End Sub

    Private Sub cmdMoveUpTGID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMoveUpTGID.Click
        'moved a channel up in memory and display
        Call cmdConvChanMoveUp_Click(cmdConvChanMoveUp, New System.EventArgs())


    End Sub


    Private Sub cmdNewConvChannel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNewConvChannel.Click
        'create a new conventional channel, ready it for editing
        'first check for max
        If blnDebug = False Then On Error Resume Next
        'find a free space for a channel
        intCurrentChannel = InsertChanTop(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
        If intCurrentChannel = -1 Then
            MsgBox("There is no more memory available for additional channels. Delete some and try again.")
            'intCurrentChannel = 1
            Exit Sub
        End If
        'setup basic channel settings
        ChanInfo(intCurrentChannel, 1) = ""
        ChanInfo(intCurrentChannel, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) 'associate GID
        intCurrentChannel = FindChanNum(intCurrentChannel)

        'update grid display
        LoadConvChanGrid()
        Me.grdConvChan.CurrentCell = grdConvChan(0, ((intCurrentChannel - 1)))

        MarkChange()
    End Sub



    Private Sub cmdNewSite_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'Dim CreateNewSite As Object
        Call CreateNewSite()
    End Sub

    Private Sub cmdNewSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Call mnuCreateNewSystem_Click()

    End Sub

    Private Sub cmdNewTGID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNewTGID.Click
        'create a new tgid channel, ready it for editing
        'first check for max
        If blnDebug = False Then On Error Resume Next
        'find a free space for a channel
        intCurrentChannel = InsertChanTop(varSite(intCurrentSys, intCurrentGroup, 0, 10), False)
        If intCurrentChannel = -1 Then
            MsgBox("There is no more memory available for additional channels. Delete some and try again.")
            Exit Sub
        End If
        'setup basic channel settings
        ChanInfo(intCurrentChannel, 1) = ""
        ChanInfo(intCurrentChannel, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) 'associate GID
        intCurrentChannel = FindChanNum(intCurrentChannel)
        'update grid display
        LoadTrunkChanGrid()
        Me.grdTGID.CurrentCell = grdTGID(0, ((intCurrentChannel - 1)))
        MarkChange()
    End Sub
    Sub FormReSize()
        'resizes controls on form to take advantage of screen size
        Dim StanHeight As Integer
        Dim StanWidth, StanLeft As Integer
        Dim StanTop As Integer
        StanHeight = MakePositive(SplitContainer1.Height - 20)
        SplitContainer1.Width = MakePositive(Me.Width - 20)
        treeSystems.Height = StanHeight
        StanWidth = MakePositive(SplitContainer1.Panel2.Width - 10)
        'setup frames in right places
        If blnBusy = True Then Exit Sub
        StanLeft = 10
      
        StanTop = treeSystems.Top + 3
        With frmGroupConv
            .Height = StanHeight
            .Left = StanLeft
            .Top = StanTop
            .Width = StanWidth
        End With
        'TRUNKED TGID EDITING
        With frmGroupTrunk
            .Height = treeSystems.Height
            .Left = StanLeft
            .Top = StanTop
            .Width = StanWidth
        End With

        With frmTrunkSys
            .Height = treeSystems.Height
            .Left = StanLeft
            .Top = StanTop
            .Width = StanWidth
        End With

        With frmFleetMap
            .Height = treeSystems.Height
            .Left = (StanLeft)
            .Width = (StanWidth)
            .Top = StanTop
        End With

        With frmSiteOptConv(0)
            .Height = treeSystems.Height
            .Left = StanLeft
            .Top = StanTop
            .Width = StanWidth
        End With
        With tabTrunkSite
            .Height = treeSystems.Height 'dont touch
            .Left = StanLeft
            .Top = StanTop
            .Width = StanWidth
        End With
        With grdTrunkFreq
            .Height = treeSystems.Height - 70
        End With
        

    End Sub

    Private Sub cmdNewTrunkFreq_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNewTrunkFreq.Click
        'add another trunking frequency
        If grdTrunkFreq.RowCount = MaxTrunkFreq Then
            MsgBox("You are at the maximum number of " & MaxTrunkFreq & " frequencies. No more can be added.")
            Exit Sub
        Else
            Call InsertTrunkFreq(varSite(intCurrentSys, intCurrentGroup, 0, 10))
            Call LoadData("TRUNKFREQ")
            grdTrunkFreq.CurrentCell = grdTrunkFreq(0, grdTrunkFreq.RowCount - 1)
        End If
        MarkChange()
    End Sub

    Private Sub cmdSaveAPCOBP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub cmdSaveFleetMap_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSaveFleetMap.Click
        'saves settings to memory with silent but deadly input checking
        Dim x As Integer
        Dim strCustom As String = Nothing
        If UCase(cmbFleetMap.Text) = Trim("CUSTOM") Then
            varSite(intCurrentSys, 0, 0, 16) = CStr(16)
        Else
            varSite(intCurrentSys, 0, 0, 16) = CStr(Val(cmbFleetMap.Text) - 1)
        End If

        'run through the block codes and encode them
        For x = 0 To 7
            strCustom = strCustom & "!" & Val(cmbSizeCode(x).Text).ToString("00")
        Next x
        varSite(intCurrentSys, 0, 0, 17) = strCustom
        ViewMode("TrunkSysSetup")
        DispStat("New fleet mapping saved.")
        MarkChange()
    End Sub


    Sub ApplyTrunkFreq()
        'save the data from the grid to site array
        Dim intRow, cnt As Integer
        'first wipe out all existing frequencies for this system
        For cnt = 1 To MaxTrunkFreq
            If strTrunkFreq(cnt, 2) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then
                'wipe it out
                strTrunkFreq(cnt, 0) = Nothing 'frequency
                strTrunkFreq(cnt, 1) = Nothing 'LCN
                strTrunkFreq(cnt, 2) = Nothing 'group id
                strTrunkFreq(cnt, 3) = Nothing 'lockout status
                strTrunkFreq(cnt, 4) = Nothing
                strTrunkFreq(cnt, 5) = Nothing
            End If
        Next cnt
        If grdTrunkFreq.RowCount <> 0 Then 'is there data present in the grid?
            'varSite(intCurrentSys, 0, 0, 29) = CStr(grdTrunkFreq.RowCount)
            For intRow = 0 To grdTrunkFreq.RowCount - 1
                'find a free spot in memory and save it there
                For cnt = 1 To MaxTrunkFreq
                    If strTrunkFreq(cnt, 2) = "" Then
                        strTrunkFreq(cnt, 0) = grdTrunkFreq(0, intRow).Value 'freq
                        strTrunkFreq(cnt, 1) = grdTrunkFreq(1, intRow).Value 'lcn
                        strTrunkFreq(cnt, 2) = varSite(intCurrentSys, intCurrentGroup, 0, 10)
                        'lo status
                        strTrunkFreq(cnt, 3) = MakeBinary(grdTrunkFreq(2, intRow).Value)
                        strTrunkFreq(cnt, 4) = grdTrunkFreq(4, intRow).Value ' Number Tag
                        strTrunkFreq(cnt, 5) = grdTrunkFreq(3, intRow).Value ' volume adjust
                        Exit For
                    End If
                Next cnt
            Next intRow
        End If
        MarkChange()
    End Sub
    Private Sub cmdSysGPS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSysGPS.Click
        Me.Enabled = False
        Call LoadGPS(varSite(intCurrentSys, 0, 0, 19), varSite(intCurrentSys, 0, 0, 20), varSite(intCurrentSys, 0, 0, 21))
        frmGPS.Visible = True
        frmGPS.Activate()
    End Sub

    Private Sub cmdToolBar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdToolBar.Click
        Dim index As Short = cmdToolBar.GetIndex(eventSender)
        Select Case index
            Case 0 'new file
                Call mnuFileNew_Click(mnuFileNew, New System.EventArgs())
            Case 1 'load file

            Case 2 'save file

            Case 3 'print

            Case 4 'download
                Call mnuToolsDL_Click(mnuToolsDL, New System.EventArgs())
            Case 5 'upload
                Call mnuToolsUL_Click(mnuToolsUL, New System.EventArgs())
            Case 6 'control
                Call mnuToolsControl_Click(mnuToolsControl, New System.EventArgs())
        End Select
    End Sub

    Private Sub cmdTrnMoveDown_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim strOld, strNew As String
        Dim intCol As Integer
        If blnDebug = False Then On Error Resume Next
        With grdTrunkFreq


        End With

    End Sub

    Private Sub cmdTrnMoveUp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim strOld, strNew As String
        Dim intCol As Integer
        If blnDebug = False Then On Error Resume Next
        With grdTrunkFreq

        End With
    End Sub

    Private Sub cmdTrnSiteEditGPS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTrnSiteEditGPS.Click
        Me.Enabled = False
        Call LoadGPS(varSite(intCurrentSys, intCurrentGroup, 0, 13), varSite(intCurrentSys, intCurrentGroup, 0, 14), varSite(intCurrentSys, intCurrentGroup, 0, 15))
        frmGPS.Visible = True
        frmGPS.Activate()

    End Sub


    Private Sub frmSystemEditor_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Call FormReSize()
        If frmSplash.Visible = True And Not blnSplashed Then
            'If blnBusy <> True Then
            frmSplash.Activate()
            blnSplashed = True

            '  frmSplash.ShowDialog()
            'blnBusy = True
            ' End If
        End If
        If Val(GetSetting("FreeSCAN", "Settings", "Blind", "0")) = 1 Then
            ActionToolStripMenuItem.Visible = True
        Else
            ActionToolStripMenuItem.Visible = False
        End If
        If treeSystems.Nodes.Count = 0 Then
            ViewMode("OFF")
        End If
        If blnVirtControlStartup = True Then
            blnVirtControlStartup = False
            Me.Visible = False
        End If
    End Sub


    Private Sub frmSystemEditor_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim y As Integer
        Dim x As Single
        Dim SortMode As String = Nothing
        Dim DecimalSeparator As String = Nothing
        Dim sCMDLine As String = VB.Command()
        Dim strCMD() As String
        Dim strBuff As String = Nothing
        Dim blnBadCmd As Boolean = False
        Dim iCOMPort, iSpeed, iLog, iInt As Integer
        'program init
        blnStartup = True

        blnLoadCmdLine = True
        LoadFileList()
        InitVariables()
        InitCOMPort()

        blnStartup = False
        blnChgSaved = True
        AddHandler mnuPopUpCon_NewSys.Click, AddressOf cmdNewSys_Click
        AddHandler mnuPopUpCon_NewSite.Click, AddressOf cmdNewSite_Click
        AddHandler mnuPopUpCon_NewGroup.Click, AddressOf mnuCreateGroup_Click
        Me.Text = strProgTitle
        Randomize()
        'splash screen
        If blnSplash Then
            frmSplash.Visible = True
            frmSplash.Activate()
        Else
            Me.Visible = True
        End If

        'check for update
        If blnCheckUpdateStartup Then
            blnNoWarn = True
            Dim t As New System.Threading.Thread(AddressOf CheckForUpdate)
            t.Start()
        End If

        'Check for decimal seperator and bitch
        DecimalSeparator = Mid$(1 / 2, 2, 1)
        If DecimalSeparator <> "." Then
            MsgBox("Caution: This system is not using a standard decimal seperator. As a result, frequencies will not process properly. You must set the decimal point to a decimal in Control Panel and restart the program.", MsgBoxStyle.Critical, "Incompatible Regional Setting")
        End If

        'form init
        cmbTrnSysType.Items.Clear()
        For x = 2 To 10  ' magic number
            cmbTrnSysType.Items.Add((SysType(x, 0)))
        Next x
        mnuShowSysType.Checked = MakeBoolean(GetSetting("FreeSCAN", "Settings", "ShowSysType", True))
        mnuShowQK.Checked = MakeBoolean(GetSetting("FreeSCAN", "Settings", "mnuShowQK", True))
        mnuHighlightSite.Checked = MakeBoolean(GetSetting("FreeSCAN", "Settings", "mnuHighlightSite", False))
        mnuGroupHighlight.Checked = MakeBoolean(GetSetting("FreeSCAN", "Settings", "mnuGroupHighlight", False))
        mnuHighlightTrunkSys.Checked = MakeBoolean(GetSetting("FreeSCAN", "Settings", "mnuHighlightTrunkSys", False))
        'sorting
        SortMode = GetSetting("FreeSCAN", "Settings", "SortOrder", "3")
        Select Case SortMode
            Case "3"
                mnuTreeSortNone.Checked = True
            Case "0"
                mnuTreeSortName.Checked = True
            Case "1"
                mnuTreeSortQK.Checked = True
            Case "2"
                mnuTreeSortType.Checked = True
        End Select
        Call DrawFavMenu()
        x = Val(GetSetting("FreeSCAN", "Settings", "QuickDraw", CStr(1)))
        Select Case x
            Case 1 'on
                mnuQuickDrawOn.Checked = True
            Case 2
                mnuQuickDrawAUto.Checked = True
            Case Else
                mnuQuickDrawOff.Checked = True
        End Select

        ReDim ChanCopy(1, 1)

        ' Me.Width = VB6.TwipsToPixelsX(14175)
        ' Me.Height = VB6.TwipsToPixelsY(9915)
        'setup column widths
        With frmGPS
            'initialize combo boxes
            .cmbLat.Items.Clear()
            .cmbLong.Items.Clear()
            .cmbRange.Items.Clear()
            .cmbLat.Items.Add("N")
            .cmbLat.Items.Add("S")
            .cmbLong.Items.Add("W")
            .cmbLong.Items.Add("E")

            .cmbLat.Text = "N"
            .cmbLong.Text = "W"
            .cmbRange.Items.Add("0.5")
            .cmbRange.Text = "0.5"
            For x = 1 To 125 Step 0.5
                .cmbRange.Items.Add(x.ToString("###.0"))
            Next
        End With

        'Load combo drop down boxes with appropiate options
        'start with quickeys
        cmbConvGroupQuickKey.Items.Clear() '
        cmbTGIDGroupQuickkey.Items.Clear() '
        cmbQuickKey.Items.Clear() '

        grdCOnvChan_MOD.Items.Clear() '
        grdConvChan_AltLevel.Items.Clear() '
        grdConvChan_AltTone.Items.Clear() '
        grdConvChan_AudioType.Items.Clear() '

        cmbConvDelayTime.Items.Clear() '
        cmbConvHoldTime.Items.Clear() '
        cmbConvStartupKey.Items.Clear() '
        grdConvChan_Tone.Items.Clear() '
        cmbSiteQK.Items.Clear() '
        cmbTGIDAlertLevel.Items.Clear() '
        cmbTGIDAlertTone.Items.Clear() '
        cmbTGIDAudioType.Items.Clear() '
        cmbTGIDGroupQuickkey.Items.Clear() '
        cmbTrnModMode.Items.Clear() '
        cmbTrnSiteHoldTime.Items.Clear() '
        cmbTrnSiteStartupKey.Items.Clear() '
        cmbTrnSiteType.Items.Clear()
        cmbTrnEmergAlertType.Items.Clear()
        cmbTrnEmergAlertLevel.Items.Clear()
        grdConvChan_Step.Items.Clear()
        grdTGID_AltColor.Items.Clear()
        cmbTrnSysQK.Items.Clear()
        'step size
        x = 0
        Do Until x = 9

            strMode = StepSize(x, 0)
            x += 1
            grdConvChan_Step.Items.Add((strMode))
        Loop
        'step size for reband grid
        For x = 0 To 31
            strMode = CStr(Val(strMcpStep(x) / 100))
            grdReband_Step.Items.Add(strMode)
        Next
        'delay time
        With cmbConvDelayTime.Items
            .Add("-10")
            .Add("-5")
            .Add("-2")
        End With
        With cmbTrunkSysDelay.Items
            .Add("-10")
            .Add("-5")
            .Add("-2")
        End With
        For x = 0 To 5
            cmbConvDelayTime.Items.Add(CStr(x))
            cmbTrunkSysDelay.Items.Add(CStr(x))
        Next x
        With cmbConvDelayTime.Items
            .Add("10")
            .Add("30")
        End With
        With cmbTrunkSysDelay.Items
            .Add("10")
            .Add("30")
        End With
        'hold time

        For x = 0 To 255
            cmbConvHoldTime.Items.Add(CStr(x))
            cmbTrnSiteHoldTime.Items.Add(CStr(x))
        Next x
        'alert level
        For x = 0 To 15
            grdConvChan_AltLevel.Items.Add(CStr(x))
            cmbTGIDAlertLevel.Items.Add(CStr(x))
            cmbTrnEmergAlertLevel.Items.Add(CStr(x))
        Next x
        'alert tone
        For x = 0 To 9
            grdConvChan_AltTone.Items.Add(CStr(x))
            cmbTrnEmergAlertType.Items.Add(CStr(x))
            cmbTGIDAlertTone.Items.Add(CStr(x))
        Next x

        'audio type
        With grdConvChan_AudioType
            .Items.Add(("All"))
            .Items.Add(("Analog Only"))
            .Items.Add(("Digital Only"))
        End With
        With cmbTGIDAudioType
            .Items.Add(("All"))
            .Items.Add(("Analog Only"))
            .Items.Add(("Digital Only"))
        End With
        'quick keys
        cmbTrnSysQK.Items.Add("[By Site]")
        cmbTrnSysQK.Items.Add(".")
        cmbConvGroupQuickKey.Items.Add(".")
        cmbTGIDGroupQuickkey.Items.Add(".")
        cmbQuickKey.Items.Add(".")
        cmbSiteQK.Items.Add(("."))
        cmbTrnSiteStartupKey.Items.Add(("."))
        cmbConvStartupKey.Items.Add(("."))
        For x = 0 To 99
            cmbSiteQK.Items.Add(CStr(x))
            cmbQuickKey.Items.Add(CStr(x))
            cmbTrnSysQK.Items.Add(CStr(x))
        Next x

        'startupkeys/limited quick keys
        For x = 0 To 9
            cmbConvStartupKey.Items.Add(CStr(x))
            cmbConvGroupQuickKey.Items.Add(CStr(x))
            cmbTGIDGroupQuickkey.Items.Add(CStr(x))
            cmbTrnSiteStartupKey.Items.Add(CStr(x))
        Next x
        'modulation mode
        x = 0
        Do Until ModMode(x) = ""
            strMode = ModMode(x)
            x = x + 1
            grdCOnvChan_MOD.Items.Add((strMode))

        Loop
        cmbTrnModMode.Items.Add("Auto")
        cmbTrnModMode.Items.Add("FM")
        cmbTrnModMode.Items.Add("NFM")

        x = 0
        Do Until x = 9
            strMode = StepSize(x, 0)
            x = x + 1
        Loop

        x = 0
        Do Until x = 232
            strMode = CTCSS(x)
            x = x + 1
            If strMode <> "" Then grdConvChan_Tone.Items.Add((strMode))
        Loop
        'APCO Mode
        For x = 0 To 3
            cmbAPCO(x).Items.Clear()
        Next x
        'refine this later
        cmbAPCO(0).Items.Add(("MAN"))
        cmbAPCO(0).Items.Add(("AUTO"))
        cmbAPCO(0).Items.Add(("DFLT"))
        cmbAPCO(2).Items.Add(("MAN"))
        cmbAPCO(2).Items.Add(("AUTO"))
        cmbAPCO(2).Items.Add(("DFLT"))
        For x = 0 To 63
            cmbAPCO(1).Items.Add(CStr(x))
            cmbAPCO(3).Items.Add(CStr(x))
        Next x
        'setup for fleet map frame
        cmbFleetMap.Items.Clear()
        cmbFleetMap.Items.Add(("Custom"))
        For x = 1 To 16
            cmbFleetMap.Items.Add(CStr(x))
        Next x
        For x = 0 To 7
            cmbSizeCode(x).Items.Clear()
            For y = 0 To 14
                cmbSizeCode(x).Items.Add(CStr(y))
            Next y
        Next x
        'reband
        grdReband_Step.Items.Clear()
        For x = 0 To UBound(strMcpStep)
            grdReband_Step.Items.Add((Val(strMcpStep(x)) / 100).ToString("###0.0##"))
        Next x
        MakeBrandNewConfig()

        'Trunked editing stuff OFF,BLUE,RED,MAGENTA,GREEN,CYAN,YELLOW,WHITE
        With grdTGID_AltColor
            .Items.Add("Off")
            .Items.Add("Blue")
            .Items.Add("Red")
            .Items.Add("Magenta")
            .Items.Add("Green")
            .Items.Add("Cyan")
            .Items.Add("Yellow")
            .Items.Add("White")
        End With

        With grdTGID_AltPat
            .Items.Add("On")
            .Items.Add("Slow")
            .Items.Add("Fast")
        End With
        With cmbTrnAltCol
            .Items.Add("Off")
            .Items.Add("Blue")
            .Items.Add("Red")
            .Items.Add("Magenta")
            .Items.Add("Green")
            .Items.Add("Cyan")
            .Items.Add("Yellow")
            .Items.Add("White")
        End With

        With cmbTrnAltPat
            .Items.Add("On")
            .Items.Add("Slow")
            .Items.Add("Fast")
        End With
        For x = -3 To 3
            grdTGID_VolOffset.Items.Add(CStr(x))
            grdConvChan_VolOffset.Items.Add(CStr(x))
            grdTrunkFreq_VolOffset.Items.Add(CStr(x))
        Next x

        'Site List
        For x = 0 To UBound(varState)
            cmbSiteState.Items.Add(varState(x, 1))
            cmbConvState.Items.Add(varState(x, 1))
        Next
        'COnventional Grid Initialization
        With grdConvChan_AltColor
            .Items.Add("Off")
            .Items.Add("Blue")
            .Items.Add("Red")
            .Items.Add("Magenta")
            .Items.Add("Green")
            .Items.Add("Cyan")
            .Items.Add("Yellow")
            .Items.Add("White")
        End With
        With grdConvChan_AltPattern
            .Items.Add("On")
            .Items.Add("Slow")
            .Items.Add("Fast")
        End With
        'setup p25 wait time
        cmbTrnP25Wait.Items.Clear()
        cmbCnvP25Wait.Items.Clear()
        For x = 0 To 1000 Step 100
            cmbTrnP25Wait.Items.Add(CStr(x))
            cmbCnvP25Wait.Items.Add(CStr(x))
        Next
        chkSimpleView.Checked = GetSetting("FreeSCAN", "Settings", "ConvSimple", False)
        chkTGIDSimpleView.Checked = GetSetting("FreeSCAN", "Settings", "TGIDSimple", False)
        Call chkTGIDSimpleView_Click(Me, Nothing)
        Call chkSimpleView_CheckedChanged(Me, Nothing)


        'Process startup commands
        sCMDLine = UCase(sCMDLine)
        sCMDLine = Trim(sCMDLine)

        If InStr(sCMDLine, ".996") <> 0 Then
            blnLoadCmdLine = True
            Call LoadSystem("")
        ElseIf sCMDLine = "/?" Then
            MsgBox("Usage Example to load virtual control on startup: freescan.exe /com1,115200,loggingon,int0 .'int0' specifies virtual control interface type ", MsgBoxStyle.Information)
        ElseIf InStr(sCMDLine, "/COM") <> 0 Then
            strCMD = Split(sCMDLine, ",")
            If UBound(strCMD) <> 3 Then
                blnBadCmd = True
            Else
                iCOMPort = Val(OldMid(strCMD(0), 5, 2))
                If iCOMPort < 1 Or iCOMPort > 24 Then
                    blnBadCmd = True
                End If
                iSpeed = Val(strCMD(1))
                If iSpeed < 4800 Or iSpeed > 115200 Then
                    blnBadCmd = True
                End If

                If strCMD(2) = "LOGGINGON" Then
                    iLog = 1
                Else
                    iLog = 0
                End If

                If strCMD(3) = "INT1" Then
                    iInt = 1
                ElseIf strCMD(3) = "INT2" Then
                    iInt = 2
                Else
                    iInt = 0
                End If
            End If
            If blnBadCmd Then
                MsgBox("Usage Example to load virtual control on startup: freescan.exe /com1,115200,loggingon,int0 .'int0' specifies virtual control interface type ", MsgBoxStyle.Information)
            Else
                'Setup and start the virtual control interface
                Me.Visible = False
                If iInt = 1 Then 'ipod interface
                    frmCtlSetup._optInterface_0.Checked = True
                ElseIf iInt = 2 Then 'lcars interface
                    frmCtlSetup._optInterface_2.Checked = True
                Else
                    frmCtlSetup._optInterface_1.Checked = True
                End If
                RadioSetting(44) = CStr(iCOMPort)
                RadioSetting(45) = CStr(iSpeed)
                frmCtlSetup.chkLog.CheckState = iLog
                blnVirtControlStartup = True
                frmCtlSetup.cmdOpenControl_click(Nothing, Nothing)
            End If
        ElseIf sCMDLine = "/DEBUG" Then
            blnDebug = True
            SetFormCaption()

        End If
        Dim pState As String
        pState = GetSetting("FreeSCAN", "Settings", "Stage", "3")

        'If state is not 3 (status OK), abort with error'
        If pState = "3" Then
            Call frmRecord.SetupRec()
        End If
        'setup panel width
        Dim pWidth As Integer
        pWidth = Int(Val(GetSetting("FreeSCAN", "Settings", "PanelWidth", 167)))
        If pWidth < 25 Then
            pWidth = 25
        ElseIf pWidth > 500 Then
            pWidth = 500
        End If
        SplitContainer1.SplitterDistance = pWidth
        blnChgSaved = True
        If blnDebug = False Then Button1.Visible = False

    End Sub


    Sub MakeNewTrunkSystem(ByRef SysType As Integer)

        'first find the total number of existing sites
        If blnDebug = False Then On Error Resume Next
        Dim intSite As Integer
        Dim SiteFound As Boolean

        'loop through and find the first available memory spot for the site
        intSite = 1
        Do Until SiteFound = True Or intSite = MaxSystems
            If Val(varSite(intSite, 0, 0, 3)) = 0 Then
                SiteFound = True
                intSite = intSite - 1
            End If
            intSite = intSite + 1
        Loop
        If intSite = MaxSystems Then
            MsgBox("CRITICAL ERROR: " & MaxSystems & " System Limit Reached.")
            Exit Sub
        End If


        intCurrentGroup = 0
        intCurrentChannel = 0
        intCurrentSys = intSite
        'now initialize default values
        If strSysname = "" Then
            varSite(intCurrentSys, 0, 0, 1) = "System " & intCurrentSys
        Else
            varSite(intCurrentSys, 0, 0, 1) = strSysname
        End If
        strSysname = ""
        varSite(intCurrentSys, 0, 0, 2) = CStr(0) 'L/O

        varSite(intCurrentSys, 0, 0, 3) = SysType
        varSite(intCurrentSys, 0, 0, 4) = "" 'no quickkey
        varSite(intCurrentSys, 0, 0, 5) = "0" 'hold time
        varSite(intCurrentSys, 0, 0, 6) = "2" 'delay time
        varSite(intCurrentSys, 0, 0, 7) = "." 'startup key
        varSite(intCurrentSys, 0, 0, 8) = "1111111111" 'quick keys enable
        varSite(intCurrentSys, 0, 0, 9) = CStr(1) 'data skip
        varSite(intCurrentSys, 0, 0, 10) = CStr(0) 'number of groups
        varSite(intCurrentSys, 0, 0, 24) = CStr(2) 'record everything
        varSite(intCurrentSys, 0, 0, 11) = "1" 'id search mode
        varSite(intCurrentSys, 0, 0, 12) = "0" 'ignore mot status bit
        varSite(intCurrentSys, 0, 0, 13) = "1" 'use mot end code
        varSite(intCurrentSys, 0, 0, 14) = "0"  'decimal mode
        varSite(intCurrentSys, 0, 0, 15) = "0" 'enable i call
        varSite(intCurrentSys, 0, 0, 16) = "16" 'fleetmap number
        RadioSetting(20) = CStr(CDbl(RadioSetting(20)) + 1)

        varSite(intCurrentSys, 0, 0, 23) = CreateGroupID() 'SITE ID
        varSite(intCurrentSys, 0, 0, 28) = "NONE"   'number tag
        varSite(intCurrentSys, 0, 0, 27) = "1"        'mot digital end code
        varSite(intCurrentSys, 0, 0, 29) = "1"        'analog agc
        varSite(intCurrentSys, 0, 0, 30) = "1"     'digital agc
        varSite(intCurrentSys, 0, 0, 32) = "0"     'protect bit
        varSite(intCurrentSys, 0, 0, 50) = "0"
        varSite(intCurrentSys, 0, 0, 51) = "OFF"
        varSite(intCurrentSys, 0, 0, 52) = "0"
        varSite(intCurrentSys, 0, 0, 53) = "SRCH" 'P25 nac search
        varSite(intCurrentSys, 0, 0, 54) = "0"
        'create a courtesy site and a courtesy group
        If blnSkipGroup = False Then
            blnSkipGroup = True
            CreateNewSite()
            blnSkipGroup = False
            mnuCreateGroup_Click()
            UpdateTreeSelection()
            MarkChange()
        End If

    End Sub



    Public Sub mnuAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAbout.Click
        Dim strMsg As String
        strMsg = strProgTitle & " "
        strMsg = strMsg & "Written by Assaf Shool" & vbNewLine
        strMsg = strMsg & "This program is Freeware. If you enjoy using this program, please consider a donation to"
        strMsg = strMsg & " help with development efforts." & vbNewLine

        strMsg = strMsg & "This version supports the " & supportedscanners & " scanners." & vbNewLine
        strMsg = strMsg & "Thanks goes out to all of you who donated your time and through PayPal, with which without your help this program would not have been possible." & vbNewLine
        strMsg = strMsg & "Use at your own risk. (This program contains proprietery Uniden control codes.)" & vbNewLine
        strMsg = strMsg & "See http://www.sixspotsoftware.com for updates and information."
        frmAbout.Text1.Text = strMsg
        frmAbout.Visible = True

    End Sub




    Public Sub mnuCheckUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCheckUpdate.Click
        Call CheckForUpdate()
    End Sub
    Sub CheckForUpdate()
        'check the internet to see if there is an update available
        DispStat("Please wait, attempting to connect to scannow.org")
        Dim strVer, strMsg As String
        Dim bWarn As Boolean = blnNoWarn
        strVer = SendNetCMD("http://scannow.org/version.txt")
        DispStat("")
        Dim ShellCode As String
        If strVer = "ERROR" Then
            If bWarn = False Then strVer = CStr(MsgBox("FreeSCAN was unable to connect to scannow.org. Check your connection.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical))
        ElseIf Val(strVer) = BuildNum And Me.Visible = True And Not bWarn Then
            strVer = CStr(MsgBox("You are using the most current version of FreeSCAN.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information))
        ElseIf Val(strVer) > BuildNum Then 'get a good path, if not then open the website
            'a direct download path is available
            strVer = CStr(MsgBox("A newer version of FreeSCAN is available. Would you like to download it now?", MsgBoxStyle.YesNo + MsgBoxStyle.Question))

            If strVer = "6" Then 'yes, i think?
                strMsg = SendNetCMD("http://scannow.org/goupdate.txt")
                ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", strMsg, "", "", 2))
            End If
        ElseIf Val(strVer) = BuildNum Then
            DispStat("You are using the most current version of FreeSCAN")
        End If

        blnNoWarn = False

    End Sub
    Public Sub mnuFileSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileSave.Click
        If strCurrFile = "" Then
            'no file name set, save as
            Call mnuFileSaveas_Click(mnuFileSaveAs, New System.EventArgs())
        Else
            Call SaveMyFile(strCurrFile)
        End If

    End Sub

    Public Sub mnuFindDupGlobalTGID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFindDupGlobalTGID.Click
        Call FindDupe("GLOBAL", "TGID")
    End Sub

    Public Sub mnuHelpOnline_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpOnline.Click
        Dim ShellCode, strSite As String
        strSite = "http://wiki.radioreference.com/index.php/FreeScan_User_Guide"
        ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", strSite, "", "", 1))

        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Public Sub mnuImportMEM_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuImportMEM.Click
        If blnDebug = False Then On Error GoTo criticerror
        Dim intTotalTrunkFreq, ChanNum, intNumSites As Integer
        Dim NumSites As Integer
        Dim intFF, intParam, cnt As Integer
        Dim strBuff As String
        Dim strUSD() As String
        Dim strFilename, strFileType As String
        Dim intLines, intLine As Integer
        Dim blnMemFull As Boolean
        Dim strLine() As String
        Dim intChan, intLastSite As Integer
        Dim intABP As Integer
        Dim intFile As Integer

        'UPGRADE_WARNING: The CommonDlg CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        'CommonDlg.CancelError = True

        'UPGRADE_WARNING: CommonDlg variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        With OpenFileDialog1
            .ShowReadOnly = False
            .Multiselect = True
            'UPGRADE_WARNING: MSComDlg.CommonDlg property CommonDlg.Flags was upgraded to CommonDlgOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
            .CheckFileExists = True
            .CheckPathExists = True
            .FileName = "*.mem"
            .Filter = "MEM File (*.mem)|*.mem| m96 File (*.m96)|*.m96|  All Files (*.*)|*.*"
            .Title = "Select file to import"
            .FilterIndex = 0
            .ShowDialog()
        End With
        For intFile = 0 To UBound(OpenFileDialog1.FileNames)
            strFilename = OpenFileDialog1.FileNames(intFile)
            If FileExists(strFilename) Then
                'next read the file into memory
                intFF = FreeFile()
                FileOpen(intFF, strFilename, OpenMode.Binary)
                strBuff = Space(LOF(intFF))
                'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                FileGet(intFF, strBuff)
                FileClose(intFF)
                strUSD = Split(strBuff, Chr(13))
                intLines = UBound(strUSD)
                strUSD(0) = UCase(strUSD(0))
                If instr(strUSD(0), "ARC246 MEM V1.0") <> 0 Then
                    Call ImportMEM246(strFilename)
                ElseIf instr(strUSD(0), "ARC15 MEM V1.") <> 0 Or instr(strUSD(0), "ARC996 MEM") <> 0 Then
                    Call ImportMEM996(strFilename)
                ElseIf instr(strUSD(0), "ARC780 MEM V1.") <> 0 Or instr(strUSD(0), "ARC250 MEM V1.") <> 0 Or instr(strUSD(0), "ARC245 MEM V1.") <> 0 Then
                    Call ImportMEM780(strFilename)
                ElseIf instr(strUSD(0), "ARC230 MEM") <> 0 Or instr(strUSD(0), "ARC330R MEM") <> 0 Then
                    'Call importMEM330(strFilename)
                    MsgBox("Sorry, but format " & VB.Left(strUSD(0), 6) & " is not yet supported.")
                Else
                    MsgBox("Unrecognized file format. Supported file formats are 780/246T/230/15T/396T/996T.")
                End If
                'begin importing
            End If
        Next intFile
        intCurrentGroup = 0
        ConvLegacyBP()
        DrawSystemTree()
        UpdateViewMode()
        blnSkipGroup = False
        Exit Sub
criticerror:
        If Err.Number <> 32755 Then
            MsgBox("Critical error, cannot continue. Error code " & Err.Number)
        End If
        If FreeFile() <> 1 Then FileClose(1)
        DrawSystemTree()
        UpdateViewMode()
        blnSkipGroup = False
        Exit Sub
    End Sub
    Sub ImportMEM996(ByRef strFilename As String)
        'Dim CreateNewSite As Object
        'import an arc246 system
        If blnDebug = False Then On Error GoTo criticerror
        Dim intNumSites, ChanNum, intTotalTrunkFreq, intSite As Integer
        Dim intFF, cnt As Integer
        Dim strBuff As String
        Dim strUSD() As String
        Dim strFileType As String
        Dim intLine, intLines, intCnt As Integer
        Dim blnMemFull As Boolean
        Dim strLine() As String
        Dim intChan, intLastSite As Integer
        Dim intABP, intGroupCnt As Integer
        Dim blnTrunk As Boolean
        Dim intChanID(1000) As Integer
        Dim intSysType, intChanCnt, intSiteType As Integer 'number of channels in a given group
        Dim dblFreq As Double
        Dim intGrpChnCnt(20) As Integer
        Dim intGrpCnt As Integer
        intFF = FreeFile()
        FileOpen(intFF, strFilename, OpenMode.Binary)
        strBuff = Space(LOF(intFF))
        'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        FileGet(1, strBuff)
        FileClose(intFF)
        strUSD = Split(strBuff, Chr(13))
        intLines = UBound(strUSD)
        blnSkipGroup = True
        If intLines < 24 Then
            intLines = MsgBox("File does not appear to be valid", MsgBoxStyle.Critical, "Error")
            blnSkipGroup = False
            Exit Sub
        End If

        If Mid(strUSD(24), 2, 1) = "T" Then
            blnTrunk = True
        ElseIf Mid(strUSD(24), 2, 1) = "C" Then
            blnTrunk = False
        Else
            intLines = MsgBox("Error reading file on line 24", MsgBoxStyle.Critical, "Error")
            blnSkipGroup = False
            Exit Sub
        End If


        'begin importing
        If intLines > 0 Then
            intLine = 0 'set current line
            blnMemFull = False
            intCurrentSys = 0
            intCurrentGroup = 0
            intCurrentChannel = 0
            intGroupCnt = 0
            intChanCnt = 0
            intChan = 0

            System.Array.Clear(intChanID, 0, intChanID.Length)
            'Preallocate which channels are going in which group
            Erase strLine
            strBuff = Replace(strUSD(24), Chr(10), "", 1, , CompareMethod.Binary)
            strLine = Split(strBuff, ",")
            intGrpCnt = 0
            For intChan = 1 To 20

                strBuff = CStr(Val(RemoveQuotes(strLine(intChan)))) '# channels in this group
                intGrpChnCnt(intChan) = Val(strBuff)
                If Val(strBuff) > 0 Then
                    intGrpCnt = intGrpCnt + 1

                    For intCnt = 1 To Val(strBuff)
                        intChanID(intChanCnt) = intGrpCnt '  channel# intchancnt will be assigned to group#intchan
                        intChanCnt = intChanCnt + 1
                    Next intCnt
                End If
            Next intChan
            intChan = 0
            intGrpCnt = 0

            Do Until intLine = intLines Or blnMemFull = True
                Erase strLine
                strUSD(intLine) = Replace(strUSD(intLine), Chr(10), "", 1, , CompareMethod.Binary)
                strUSD(intLine) = Replace(strUSD(intLine), Chr(34), "", 1, , CompareMethod.Binary)
                strLine = Split(strUSD(intLine), ",")
                'identify paramaters
                'strLine(0) = MakeItKosherSilent(strLine(0), 0)
                Select Case VB.Left(strLine(0), 6)
                    Case "SYSDAT"
                        'create the new system
                        If blnTrunk = False Then
                            intCurrentSys = 0
                            MakeNewConvSystem()

                            If intCurrentSys = 0 Then
                                blnMemFull = True
                            End If
                            'begin setting system paramters

                            strBuff = MakeItKosherSilent(strLine(1), 0)
                            If strBuff = "" Then
                                strBuff = MakeItKosherSilent(StripName(strFilename), 0)
                            End If
                            varSite(intCurrentSys, 0, 0, 1) = strBuff
                            'system qk
                            strBuff = CStr(Val(strLine(2)))
                            If strBuff = "0" Then
                                strBuff = "."
                            Else
                                strBuff = CStr(Val(strBuff) - 1)
                            End If


                            varSite(intCurrentSys, 0, 0, 4) = MakeItKosherQK(strBuff)
                            'hold time
                            strBuff = CStr(Val(strLine(4)))
                            If Val(strBuff) < 6 Then
                                varSite(intCurrentSys, 0, 0, 5) = strBuff
                            End If
                        Else 'create a new trunk system
                            intCurrentSys = 0
                            Select Case Val(strLine(10)) 'convert to compatible system type
                                Case 1 ' type 1 stan
                                    intSysType = 2
                                Case 3 ' type 2 stan
                                    intSysType = 3
                                Case 8 'edacs narrow'OK
                                    intSysType = 4
                                Case 10 'scat
                                    intSysType = 5
                                Case 11 'ltr
                                    intSysType = 5
                            End Select
                            Call MakeNewTrunkSystem(intSysType)
                            If intCurrentSys = 0 Then
                                blnMemFull = True
                            End If
                            'begin setting system paramters

                            strBuff = MakeItKosherSilent(strLine(1), 0)
                            varSite(intCurrentSys, 0, 0, 1) = strBuff
                            varSite(intCurrentSys, intSite, 0, 1) = strBuff
                            'system qk
                            ' strBuff = Val(strLine(2))
                            ' varSite(intCurrentSys, 0, 0, 4) = MakeItKosherQK(strBuff)
                            'hold time
                            strBuff = CStr(Val(strLine(4)))
                            If Val(strBuff) < 6 Then
                                varSite(intCurrentSys, 0, 0, 5) = strBuff
                            End If
                        End If
                    Case "GROUPD"

                        'is this group valid?\

                        strLine(1) = Trim(RemoveQuotes(strLine(1))) 'trim has to be there to prevent false pos

                        strLine(2) = Trim(RemoveQuotes(strLine(2)))
                        intGroupCnt = intGroupCnt + 1
                        If intGrpChnCnt(intGroupCnt) > 0 Then

                            MakeNewGroup()
                            'assign group name

                            varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosherSilent(strLine(1), 0)
                            'quick key
                            strBuff = strLine(3)
                            If strBuff = "0" Then
                                strBuff = "."
                            Else
                                strBuff = CStr(Val(strBuff) - 1)
                            End If

                            varSite(intCurrentSys, intCurrentGroup, 0, 4) = MakeItKosherQK(strBuff)
                            'preassign memory to channels

                        End If
                    Case "CHN"
                        'channel data
                        If blnTrunk = False Then 'import conventional channel
                            'get the GID
                            strBuff = varSite(intCurrentSys, intChanID(intChan), 0, 10)

                            intCnt = InsertChan(strBuff, True)
                            If intCnt = -1 Then
                                blnMemFull = True
                                intCnt = 0
                            End If
                            ChanInfo(intCnt, 2) = MakeItKosherFreqSilent(strLine(1)) 'freq
                            ChanInfo(intCnt, 1) = MakeItKosherSilent(strLine(2), 0) 'name
                            ChanInfo(intCnt, 5) = MakeBinary(strLine(3)) 'lockout
                            ChanInfo(intCnt, 6) = MakeBinary(strLine(6)) 'attenuation
                            ChanInfo(intCnt, 11) = MakeBinary(strLine(5)) 'toneLO
                            ChanInfo(intCnt, 14) = MakeItKosherSilent(strLine(11), 14) 'comment
                            'tone frequency
                            ChanInfo(intCnt, 9) = RRToneLookUp(strLine(4))
                            Select Case strLine(13) 'set audio type
                                Case "Analog"
                                    ChanInfo(intCnt, 12) = "1"
                                Case "Digital"
                                    ChanInfo(intCnt, 12) = "2"
                                Case Else
                                    If ChanInfo(intCnt, 9) <> "0" Then
                                        ChanInfo(intCnt, 12) = "1"
                                    Else
                                        ChanInfo(intCnt, 12) = "0"
                                    End If
                            End Select
                            If strLine(11) = "PRI" Then
                                ChanInfo(intCnt, 7) = "1" 'priority
                            Else
                                ChanInfo(intCnt, 7) = "0"
                            End If
                            intChan = intChan + 1
                        Else
                            'get the GID
                            strBuff = varSite(intCurrentSys, intChanID(intChan), 0, 10)

                            intCnt = InsertChan(strBuff, False)
                            If intCnt = -1 Then
                                blnMemFull = True
                                intCnt = 0
                            End If
                            ChanInfo(intCnt, 2) = MakeItKosherSilent(strLine(1), 0) 'TGID
                            ChanInfo(intCnt, 1) = MakeItKosherSilent(strLine(2), 0) 'name
                            ChanInfo(intCnt, 3) = MakeBinary(strLine(3)) 'lockout
                            ChanInfo(intCnt, 14) = MakeItKosherSilent(strLine(9), 3) 'comment
                            If strLine(8) = "Analog" Then
                                ChanInfo(intCnt, 6) = "1"
                            ElseIf strLine(8) = "Digital" Then
                                ChanInfo(intCnt, 6) = "2"
                            Else
                                ChanInfo(intCnt, 6) = "0"
                            End If
                            intChan = intChan + 1
                        End If
                    Case "SITEFR"
                        'trunk frequency
                        If blnTrunk = True And intSite > 0 Then

                            intCnt = InsertTrunkFreq(varSite(intCurrentSys, intSite, 0, 10))
                            If intCnt < 1 Then
                                blnMemFull = True
                                intCnt = 0
                            Else
                                strTrunkFreq(intCnt, 0) = MakeItKosherFreqSilent(Val(strLine(1)) / 10000) 'frequency
                                strTrunkFreq(intCnt, 1) = MakePositive(Val(strLine(2))) 'LCN
                                strTrunkFreq(intCnt, 3) = MakeBinary(Val(strLine(3))) 'L/O
                            End If
                        End If

                    Case "TRSDAT" 'trunk settings
                        If blnTrunk Then
                            varSite(intCurrentSys, 0, 0, 11) = MakeBinary(strLine(1)) 'id search
                            varSite(intCurrentSys, 0, 0, 12) = MakeBinary(strLine(2)) 'status flag CHECK THIS
                            varSite(intCurrentSys, 0, 0, 13) = MakeBinary(strLine(3)) 'mot end code
                            varSite(intCurrentSys, 0, 0, 14) = MakeBinary(strLine(4)) 'afs
                            varSite(intCurrentSys, 0, 0, 15) = MakeBinary(strLine(5)) 'i-call
                            varSite(intCurrentSys, intSite, 0, 8) = MakeBinary(strLine(6)) 'cconly
                            varSite(intCurrentSys, 0, 0, 16) = CStr(Val(strLine(7))) 'fleetmap number
                        End If
                    Case "SBP#" 'site band plan
                        If blnTrunk And intSite > 0 And UBound(strLine) >= 8 Then
                            'band plan
                            dblFreq = Val(strLine(2)) * 10000

                            Call SaveBPParam(intCurrentSys, intSite, 0, 0, Str(dblFreq)) 'base 1
                            Call SaveBPParam(intCurrentSys, intSite, 2, 0, CStr(Val(strLine(3)) * 100)) 'step 1
                            Call SaveBPParam(intCurrentSys, intSite, 3, 0, CStr(Val(strLine(4)))) 'offset 1
                            dblFreq = Val(strLine(5)) * 10000

                            Call SaveBPParam(intCurrentSys, intSite, 0, 1, Str(dblFreq)) 'base 1
                            Call SaveBPParam(intCurrentSys, intSite, 2, 1, CStr(Val(strLine(6)) * 100)) 'step 1
                            Call SaveBPParam(intCurrentSys, intSite, 3, 1, CStr(Val(strLine(7)))) 'offset 1
                            dblFreq = Val(strLine(8)) * 10000

                            Call SaveBPParam(intCurrentSys, intSite, 0, 2, Str(dblFreq)) 'base 3
                            Call SaveBPParam(intCurrentSys, intSite, 2, 2, CStr(Val(strLine(9)) * 100)) 'step 3
                            Call SaveBPParam(intCurrentSys, intSite, 3, 2, CStr(Val(strLine(10)))) 'offset 3
                            Call AutoCalcUpper(intCurrentSys, intSite, True)
                        End If
                    Case "SITESE" 'site
                        CreateNewSite()
                        intSite = intCurrentGroup
                        Select Case varSite(intCurrentSys, 0, 0, 3)
                            Case "2" 'type I
                                Select Case strLine(10)
                                    Case "1"
                                        intSiteType = 7
                                    Case Else
                                        intSiteType = 8
                                End Select
                            Case "3" 'type II
                                Select Case strLine(10)
                                    Case "3"
                                        intSiteType = 1
                                    Case "4"
                                        intSiteType = 2
                                    Case "5"
                                        intSiteType = 3
                                    Case "6"
                                        intSiteType = 4
                                    Case "7"
                                        intSiteType = 5
                                    Case Else
                                        intSiteType = 6
                                End Select

                            Case "4" 'edacs nar/wide
                                Select Case strLine(10)
                                    Case "8"
                                        intSiteType = CInt("9")
                                    Case Else
                                        intSiteType = CInt("10")
                                End Select
                            Case "5" 'edacs scat
                                intSiteType = 11
                            Case "6" 'LTR
                                intSiteType = 12
                            Case Else
                                varSite(intCurrentSys, 0, 0, 3) = CStr(3)
                                intSiteType = 1
                        End Select
                        'type
                        varSite(intCurrentSys, intSite, 0, 9) = CStr(intSiteType)
                        'name

                        varSite(intCurrentSys, intSite, 0, 1) = MakeItKosherSilent(strLine(1), 0)
                        'qk
                        strBuff = strLine(2)
                        If strBuff = "0" Then
                            strBuff = "."
                        Else
                            strBuff = CStr(Val(strBuff) - 1)
                        End If

                        varSite(intCurrentSys, intSite, 0, 2) = MakeItKosherQK(strBuff)
                End Select

                intLine = intLine + 1
            Loop
        Else
            MsgBox("Invalid file, cannot import.")
        End If
        If blnMemFull = True Then
            strBuff = "FreeSCAN has insufficient memory to continue importing this file. As a result, not all of the file has been imported. Delete systems and/or channels and try again."
            intLine = MsgBox(strBuff, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Out of Memory")
        End If
        ConvLegacyBP()

        Exit Sub
criticerror:
        If Err.Number <> 32755 Then
            MsgBox("Critical error, cannot continue. Error code " & Err.Number)
        End If
        If FreeFile() <> 1 Then FileClose(1)
        blnSkipGroup = False
        Exit Sub
    End Sub
    Sub ImportMEM246(ByRef strFilename As String)
        'Dim CreateNewSite As Object
        'import an arc246 system
        If blnDebug = False Then On Error GoTo criticerror
        Dim intNumSites, ChanNum, intTotalTrunkFreq, intSite As Integer
        Dim intFF, intParam, cnt As Integer
        Dim strBuff As String
        Dim strUSD() As String
        Dim strFileType As String
        Dim intLine, intLines, intCnt As Integer
        Dim blnMemFull As Boolean
        Dim strLine() As String
        Dim intChan, intLastSite As Integer
        Dim intABP, intGroupCnt As Integer
        Dim blnTrunk As Boolean
        Dim intChanID(1000) As Integer
        Dim intSysType, intChanCnt, intSiteType As Integer 'number of channels in a given group
        Dim dblFreq As Double
        intFF = FreeFile()
        FileOpen(intFF, strFilename, OpenMode.Binary)
        strBuff = Space(LOF(intFF))
        'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        FileGet(1, strBuff)
        FileClose(intFF)
        strUSD = Split(strBuff, Chr(13))
        intLines = UBound(strUSD)
        blnSkipGroup = True
        If intLines < 24 Then
            intLines = MsgBox("File does not appear to be valid", MsgBoxStyle.Critical, "Error")
            blnSkipGroup = False
            Exit Sub
        End If

        If Mid(strUSD(24), 2, 1) = "T" Then
            blnTrunk = True
        ElseIf Mid(strUSD(24), 2, 1) = "C" Then
            blnTrunk = False
        Else
            intLines = MsgBox("Error reading file on line 24", MsgBoxStyle.Critical, "Error")
            blnSkipGroup = False
            Exit Sub
        End If


        'begin importing
        If intLines > 0 Then
            intLine = 0 'set current line
            blnMemFull = False
            intCurrentSys = 0
            intCurrentGroup = 0
            intCurrentChannel = 0
            intGroupCnt = 0
            intChanCnt = 0
            intChan = 0

            System.Array.Clear(intChanID, 0, intChanID.Length)
            'Preallocate which channels are going in which group
            Erase strLine
            strBuff = Replace(strUSD(24), Chr(10), "", 1, , CompareMethod.Binary)
            strLine = Split(strBuff, ",")
            For intChan = 1 To 20

                strBuff = CStr(Val(RemoveQuotes(strLine(intChan))))
                For intCnt = 1 To Val(strBuff)
                    intChanID(intChanCnt) = intChan '  channel# intchancnt will be assigned to group#intchan
                    intChanCnt = intChanCnt + 1
                Next intCnt
            Next intChan
            intChan = 0

            Do Until intLine = intLines Or blnMemFull = True
                Erase strLine
                strUSD(intLine) = Replace(strUSD(intLine), Chr(10), "", 1, , CompareMethod.Binary)
                strUSD(intLine) = Replace(strUSD(intLine), Chr(34), "", 1, , CompareMethod.Binary)
                strLine = Split(strUSD(intLine), ",")
                'identify paramaters
                'strLine(0) = MakeItKosherSilent(strLine(0), 0)
                Select Case VB.Left(strLine(0), 6)
                    Case "SYSDAT"
                        'create the new system
                        If blnTrunk = False Then
                            intCurrentSys = 0
                            MakeNewConvSystem()

                            If intCurrentSys = 0 Then
                                blnMemFull = True
                            End If
                            'begin setting system paramters

                            strBuff = MakeItKosherSilent(strLine(1), 0)
                            If strBuff = "" Then
                                strBuff = MakeItKosherSilent(StripName(strFilename), 0)
                            End If
                            varSite(intCurrentSys, 0, 0, 1) = strBuff

                            'system qk
                            strBuff = CStr(Val(strLine(2)) - 1)

                            varSite(intCurrentSys, 0, 0, 4) = MakeItKosherQK(strBuff)
                            'hold time
                            strBuff = CStr(Val(strLine(4)))
                            If Val(strBuff) < 6 Then
                                varSite(intCurrentSys, 0, 0, 5) = strBuff
                            End If
                        Else 'create a new trunk system
                            intCurrentSys = 0
                            Select Case Val(strLine(10)) 'convert to compatible system type
                                Case 1 ' type 1 stan
                                    intSysType = 2
                                    intSiteType = 7
                                Case 2 'type i spl
                                    intSysType = 2
                                    intSiteType = 8
                                Case 3 ' type 2 stan
                                    intSysType = 3
                                    intSiteType = 1
                                Case 4 ' type ii splin
                                    intSysType = 3
                                    intSiteType = 2
                                Case 5 ' type ii 900mhz
                                    intSysType = 3
                                    intSiteType = 3
                                Case 6 ' type ii vhf
                                    intSysType = 3
                                    intSiteType = 4
                                Case 7 ' type ii uhf
                                    intSysType = 3
                                    intSiteType = 5
                                Case 8 'edacs narrow
                                    intSysType = 4
                                    intSiteType = 9
                                Case 9 'edacs wide
                                    intSysType = 4
                                    intSiteType = 9
                                Case 10 'scat
                                    intSysType = 5
                                    intSiteType = 11
                                Case 11 'ltr
                                    intSysType = 6
                                    intSiteType = 12
                                Case 12 'P25
                                    intSysType = 4
                                    intSiteType = 6
                                Case Else 'motorola reband
                                    intSysType = 3
                                    intSiteType = 13
                            End Select
                            Call MakeNewTrunkSystem(intSysType)
                            For intCnt = 1 To 20 'this is done so the new site is always created at position 21
                                varSite(intCurrentSys, intCnt, 0, 10) = "XXXXXXXXXXXXXX"
                            Next intCnt
                            CreateNewSite()
                            For intCnt = 1 To 20
                                varSite(intCurrentSys, intCnt, 0, 10) = ""
                            Next intCnt
                            intSite = intCurrentGroup
                            varSite(intCurrentSys, intSite, 0, 9) = CStr(intSiteType)

                            If intCurrentSys = 0 Then
                                blnMemFull = True
                            End If
                            'begin setting system paramters

                            strBuff = MakeItKosherSilent(strLine(1), 0)
                            varSite(intCurrentSys, 0, 0, 1) = strBuff
                            varSite(intCurrentSys, intSite, 0, 1) = strBuff
                            'system qk
                            strBuff = CStr(Val(strLine(2)))

                            varSite(intCurrentSys, intSite, 0, 2) = MakeItKosherQK(strBuff)
                            'hold time
                            strBuff = CStr(Val(strLine(4)))
                            If Val(strBuff) < 6 Then
                                varSite(intCurrentSys, 0, 0, 5) = strBuff
                            End If
                        End If
                    Case "GROUPD"

                        'is this group valid?\

                        strLine(1) = Trim(RemoveQuotes(strLine(1))) 'trim has to be there to prevent false pos

                        strLine(2) = Trim(RemoveQuotes(strLine(1)))
                        If strLine(1) <> "" Or strLine(2) <> "" Then
                            intGroupCnt = intGroupCnt + 1
                            MakeNewGroup()
                            'assign group name

                            varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosherSilent(strLine(1), 0)
                            'quick key

                            strBuff = MakeItKosherQK(strLine(3))
                            varSite(intCurrentSys, intCurrentGroup, 0, 2) = strBuff
                            'preassign memory to channels

                        End If
                    Case "CHN"
                        'channel data
                        If blnTrunk = False Then 'import conventional channel
                            'get the GID
                            strBuff = varSite(intCurrentSys, intChanID(intChan), 0, 10)

                            intCnt = InsertChan(strBuff, True)
                            If intCnt = -1 Then
                                blnMemFull = True
                                intCnt = 0
                            End If
                            ChanInfo(intCnt, 2) = MakeItKosherFreqSilent(strLine(1)) 'freq
                            ChanInfo(intCnt, 1) = MakeItKosherSilent(strLine(2), 0) 'name
                            ChanInfo(intCnt, 5) = CStr(MakeBinary(strLine(3))) 'lockout
                            ChanInfo(intCnt, 6) = CStr(MakeBinary(strLine(7))) 'attenuation
                            ChanInfo(intCnt, 11) = CStr(MakeBinary(strLine(6))) 'toneLO
                            ChanInfo(intCnt, 14) = MakeItKosherSilent(strLine(11), 3) 'comment
                            'tone frequency

                            ChanInfo(intCnt, 9) = RRToneLookUp(strLine(4))
                            If ChanInfo(intCnt, 9) <> "0" Then 'set audio type
                                ChanInfo(intCnt, 12) = "1"
                            Else
                                ChanInfo(intCnt, 12) = "0"
                            End If

                            ChanInfo(intCnt, 7) = CStr(MakeBinary(strLine(11))) 'priority
                            intChan = intChan + 1
                        Else
                            'get the GID
                            strBuff = varSite(intCurrentSys, intChanID(intChan), 0, 10)

                            intCnt = InsertChan(strBuff, False)
                            If intCnt = -1 Then
                                blnMemFull = True
                                intCnt = 0
                            End If
                            ChanInfo(intCnt, 2) = MakeItKosherSilent(strLine(1), 0) 'TGID
                            ChanInfo(intCnt, 1) = MakeItKosherSilent(strLine(2), 0) 'name
                            ChanInfo(intCnt, 3) = CStr(MakeBinary(strLine(3))) 'lockout
                            ChanInfo(intCnt, 14) = MakeItKosherSilent(strLine(5), 3) 'comment
                            ChanInfo(intCnt, 12) = "0" 'set audio type
                            ChanInfo(intCnt, 19) = "NONE" 'number tag
                            ChanInfo(intCnt, 20) = "OFF" 'alert colour
                            ChanInfo(intCnt, 21) = "0" 'alert patt
                            ChanInfo(intCnt, 22) = "0" 'vol offset
                            ChanInfo(intCnt, 4) = "0"
                            ChanInfo(intCnt, 5) = "0"
                            intChan += 1
                        End If
                    Case "TRKFR#"
                        'trunk frequency
                        If blnTrunk = True Then

                            If strLine(1) <> "" Or strLine(3) <> "" Then

                                intCnt = InsertTrunkFreq(varSite(intCurrentSys, intSite, 0, 10))
                                If intCnt < 1 Then
                                    blnMemFull = True
                                    intCnt = 0
                                Else
                                    strTrunkFreq(intCnt, 0) = MakeItKosherFreqSilent(strLine(1)) 'frequency
                                    strTrunkFreq(intCnt, 1) = MakePositive(Val(strLine(3))) 'LCN
                                    'strTrunkFreq(intCnt, 3) = MakeBinary(strLine(4))'L/O not supported?
                                End If
                            End If
                        End If
                    Case "TRSDAT" 'trunk settings
                        If blnTrunk = True Then
                            varSite(intCurrentSys, 0, 0, 11) = MakeBinary(strLine(1)) 'id search
                            varSite(intCurrentSys, 0, 0, 12) = MakeBinary(strLine(2)) 'status flag CHECK THIS
                            varSite(intCurrentSys, 0, 0, 13) = MakeBinary(strLine(3)) 'mot end code
                            varSite(intCurrentSys, 0, 0, 14) = MakeBinary(strLine(4)) 'afs
                            varSite(intCurrentSys, 0, 0, 15) = MakeBinary(strLine(5)) 'i-call
                            varSite(intCurrentSys, intSite, 0, 8) = MakeBinary(strLine(6)) 'cconly
                            varSite(intCurrentSys, 0, 0, 16) = CStr(Val(strLine(7))) 'fleetmap number
                            'band plan
                            dblFreq = Val(strLine(9)) * 10000

                            Call SaveBPParam(intCurrentSys, intSite, 0, 0, Str(dblFreq)) 'base 1
                            Call SaveBPParam(intCurrentSys, intSite, 2, 0, CStr(Val(strLine(10)) * 100)) 'step 1
                            Call SaveBPParam(intCurrentSys, intSite, 3, 0, CStr(Val(strLine(11)))) 'offset 1
                            dblFreq = Val(strLine(12)) * 10000

                            Call SaveBPParam(intCurrentSys, intSite, 0, 1, Str(dblFreq)) 'base 1
                            Call SaveBPParam(intCurrentSys, intSite, 2, 1, CStr(Val(strLine(13)) * 100)) 'step 1
                            Call SaveBPParam(intCurrentSys, intSite, 3, 1, CStr(Val(strLine(14)))) 'offset 1
                            dblFreq = Val(strLine(15)) * 10000

                            Call SaveBPParam(intCurrentSys, intSite, 0, 2, Str(dblFreq)) 'base 3
                            Call SaveBPParam(intCurrentSys, intSite, 2, 2, CStr(Val(strLine(16)) * 100)) 'step 3
                            Call SaveBPParam(intCurrentSys, intSite, 3, 2, CStr(Val(strLine(17)))) 'offset 3
                            Call AutoCalcUpper(intCurrentSys, intSite, True)
                        End If
                End Select

                intLine = intLine + 1
            Loop
        Else
            MsgBox("Invalid file, cannot import.")
        End If
        If blnMemFull = True Then
            strBuff = "FreeSCAN has insufficient memory to continue importing this file. As a result, not all of the file has been imported. Delete systems and/or channels and try again."
            intLine = MsgBox(strBuff, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Out of Memory")
        End If

        Exit Sub
criticerror:
        If Err.Number <> 32755 Then
            MsgBox("Critical error, cannot continue. Error code " & Err.Number)
        End If
        If FreeFile() <> 1 Then FileClose(1)
        blnSkipGroup = False
        Exit Sub
    End Sub
    Sub ImportMEM780(ByRef strFilename As String)
        'import an arc780 system
        If blnDebug = False Then On Error GoTo criticerror
        Dim ChanNum, intSite As Integer
        Dim strBuff As String
        Dim strUSD() As String
        Dim cnt As Integer
        Dim strFileType As String
        Dim intLine, intLines, intCnt As Integer
        Dim blnMemFull As Boolean
        Dim strLine() As String
        Dim intChan As Integer
        Dim intChanCnt, intFF As Integer
        Dim dblFreq As Double
        intFF = FreeFile()
        FileOpen(intFF, strFilename, OpenMode.Binary)
        strBuff = Space(LOF(intFF))
        'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        FileGet(1, strBuff)
        FileClose(intFF)
        strUSD = Split(strBuff, Chr(13))
        intLines = UBound(strUSD)
        blnSkipGroup = True
        If intLines < 24 Then
            intLines = MsgBox("File does not appear to be valid", MsgBoxStyle.Critical, "Error")
            blnSkipGroup = False
            Exit Sub
        End If



        'begin importing
        If intLines > 0 Then
            intLine = 0 'set current line
            blnMemFull = False
            intCurrentSys = 0
            intCurrentGroup = 0
            intCurrentChannel = 0
            intChanCnt = 0
            intChan = 0
            'create the new system
            intCurrentSys = 0
            MakeNewConvSystem()
            If intCurrentSys = 0 Then
                blnMemFull = True
            End If
            'begin setting system paramters


            strBuff = MakeItKosherSilent(StripName(strFilename), 0)
            varSite(intCurrentSys, 0, 0, 1) = strBuff
            'system qk
            varSite(intCurrentSys, 0, 0, 4) = "."
            'create a group to hold the systems
            MakeNewGroup()
            'assign group name
            varSite(intCurrentSys, intCurrentGroup, 0, 1) = "Banked Group"

            Do Until intLine = intLines Or blnMemFull = True
                Erase strLine
                strUSD(intLine) = Replace(strUSD(intLine), Chr(10), "", 1, , CompareMethod.Binary)
                strUSD(intLine) = Replace(strUSD(intLine), Chr(34), "", 1, , CompareMethod.Binary)
                strLine = Split(strUSD(intLine), ",")
                If UBound(strLine) > 0 Then
                    dblFreq = Val(strLine(1))
                End If
                If IsNumeric(strLine(0)) = True And dblFreq > 0 Then
                    'channel data
                    'get the GID

                    intCnt = InsertChan(varSite(intCurrentSys, 1, 0, 10), True)
                    If intCnt = -1 Then
                        blnMemFull = True
                        intCnt = 0
                    End If
                    ChanInfo(intCnt, 2) = MakeItKosherFreqSilent(strLine(1)) 'freq
                    ChanInfo(intCnt, 1) = MakeItKosherSilent(strLine(2), 0) 'name
                    intChan = intChan + 1
                    dblFreq = 0
                End If

                intLine = intLine + 1
            Loop
        Else
            MsgBox("Invalid file, cannot import.")
        End If
        If blnMemFull = True Then
            strBuff = "FreeSCAN has insufficient memory to continue importing this file. As a result, not all of the file has been imported. Delete systems and/or channels and try again."
            intLine = MsgBox(strBuff, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Out of Memory")
        End If

        Exit Sub
criticerror:
        If Err.Number <> 32755 Then
            MsgBox("Critical error, cannot continue. Error code " & Err.Number)
        End If
        If FreeFile() <> 1 Then FileClose(1)
        blnSkipGroup = False
        Exit Sub
    End Sub
    Public Sub mnuLastFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLastFile.Click
        Dim index As Short = mnuLastFile.GetIndex(eventSender)
        Dim strBuff As String
        strBuff = GetSetting("FreeSCAN", "Settings", "File" & index, "")
        Dim Response As Integer
        blnLoadCmdLine = False
        If Not blnChgSaved Then
            'warn user changes are going to be lost
            Response = MsgBox("Do you wish to save changes to " & strCurrFile, MsgBoxStyle.YesNoCancel, "Save changes?")
            Select Case Response
                Case 6 'save changes
                    Call mnuFileSave_Click(mnuFileSave, New System.EventArgs())
                    Call LoadSystem(strBuff)
                Case 7 ' dont save
                    Call LoadSystem(strBuff)
                Case 2 'cancel action
                    Exit Sub
            End Select
        Else
            Call LoadSystem(strBuff)
        End If
        DrawSystemTree()

    End Sub

    Public Sub mnuToolsAutoOpt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsAutoOpt.Click
        '    frmSystemEditor.Visible = False
        frmOptimizer.Visible = True
        frmOptimizer.GenStats()
    End Sub





    Sub MakeNewConvSystem()
        'This is the first part of creating a conventional system
        'this subroutine just sets up the variable so they are ready to accept
        'input from the user

        'first find the total number of existing sites
        If blnDebug = False Then On Error Resume Next
        Dim intSite As Integer
        Dim SiteFound As Boolean

        If Val(RadioSetting(20)) = 0 Then 'no existing sites
            RadioSetting(20) = CStr(1)
            intCurrentSys = 1
            intSite = 1
            intCurrentGroup = 0
            intCurrentChannel = 0
        Else
            'loop through and find the first available memory spot for the site
            intSite = 1
            Do Until SiteFound = True Or intSite = MaxSystems
                If Val(varSite(intSite, 0, 0, 3)) = 0 Then
                    SiteFound = True
                    intSite = intSite - 1
                End If
                intSite = intSite + 1
            Loop
            If intSite = MaxSystems Then
                MsgBox("CRITICAL ERROR: " & MaxSystems & " Site Limit Reached. Just what the hell are you scanning anyways???")
                Exit Sub

            End If
            RadioSetting(20) = CStr(CDbl(RadioSetting(20)) + 1)
        End If
        intCurrentSys = intSite
        intCurrentGroup = 0
        intCurrentChannel = 0

        'basic variable array is setup, now apply default settings
        If strSysname = "" Then
            varSite(intCurrentSys, 0, 0, 1) = "System " & intCurrentSys
        Else
            varSite(intCurrentSys, 0, 0, 1) = strSysname
        End If
        strSysname = ""
        varSite(intCurrentSys, 0, 0, 2) = CStr(0) 'l/o off
        varSite(intCurrentSys, 0, 0, 3) = CStr(1) 'conventional site, see systype variable for more
        varSite(intCurrentSys, 0, 0, 4) = "." 'no quick key
        varSite(intCurrentSys, 0, 0, 5) = "0" 'hold time
        varSite(intCurrentSys, 0, 0, 6) = "2" 'delay time
        varSite(intCurrentSys, 0, 0, 7) = "." 'startupkey
        varSite(intCurrentSys, 0, 0, 9) = CStr(0) 'data skip
        varSite(intCurrentSys, 0, 0, 10) = CStr(Val(varSite(intCurrentSys, 0, 0, 10)) + 1) 'number of groups
        varSite(intCurrentSys, 0, 0, 8) = "1111111111" 'quick keys enable
        varSite(intCurrentSys, 0, 0, 18) = APCOMode 'for conv sys only apco mode\
        varSite(intCurrentSys, 0, 0, 19) = DefaultLat 'Default latitude
        varSite(intCurrentSys, 0, 0, 20) = DefaultLong 'Default longtitude
        varSite(intCurrentSys, 0, 0, 22) = "0" 'gps enable
        varSite(intCurrentSys, 0, 0, 24) = "2" 'record out all
        varSite(intCurrentSys, 0, 0, 25) = "0" 'emergy alert type
        varSite(intCurrentSys, 0, 0, 26) = "0" 'emergy alert volume
        varSite(intCurrentSys, 0, 0, 27) = "1" 'mot digital end code
        varSite(intCurrentSys, 0, 0, 28) = "NONE"  'number tag
        varSite(intCurrentSys, 0, 0, 29) = "1" 'analog agc on
        varSite(intCurrentSys, 0, 0, 30) = "1" 'digital agc on
        varSite(intCurrentSys, 0, 0, 31) = "400" 'P25 wait time
        varSite(intCurrentSys, 0, 0, 32) = "0" 'Protect bit
        varSite(intCurrentSys, 0, 0, 33) = "0" 'state
        varSite(intCurrentSys, 0, 0, 23) = CreateGroupID() 'SITE ID
        varSite(intCurrentSys, 0, 0, 48) = APCOMode
        varSite(intCurrentSys, 0, 0, 49) = APCOThreshold
        'create default group
        If Me.Visible = True And blnSkipGroup = False Then MakeNewGroup() 'dont do this while downloadng
        MarkChange()
    End Sub

    Sub MakeNewGroup()
        'create default group
        Dim x, TotGroups As Integer
        Dim NewGroupNum As Integer
        If intCurrentGroup = MaxGroups Then
            MsgBox("The maximum number of groups has been reached. No more can be created.")
            Exit Sub
        End If
        If intCurrentSys = 0 Then
            MsgBox("Please select or create a system before creating a group.")
            Exit Sub
        End If
        'check for edacs and ltr limitations
        If Val(varSite(intCurrentSys, 0, 0, 3)) = 5 Then
            MsgBox("This scanner cannot track group ID's in a EDACS SCAT system. As a result, you cannot create a new group")
            DrawSystemTree()
            Exit Sub
        End If
        'ltr maximum one group limitation
        'Says WHO??
        '  If Val(varSite(intCurrentSys, 0, 0, 3)) = 6 And Val(varSite(intCurrentSys, 1, 0, 5)) <> 3 And blnSkipGroup = False Then 'there is already a tgid group present
        ' MsgBox("LTR systems can only support one group per system.")
        '' Exit Sub
        'End If

        'find a spot in memory for new group
        For x = 1 To MaxGroups
            If varSite(intCurrentSys, x, 0, 10) = "" Then
                NewGroupNum = x
                x = MaxGroups
            End If
            If Val(varSite(intCurrentSys, x, 0, 5)) = 1 Or Val(varSite(intCurrentSys, x, 0, 5)) = 2 Then TotGroups = TotGroups + 1
        Next x

        If TotGroups = 20 Or NewGroupNum = 0 Then
            MsgBox("This scanner only supports 20 groups per system.")
            Exit Sub
        End If
        'ltr one group limitation
   
        intCurrentGroup = NewGroupNum


        varSite(intCurrentSys, 0, 0, 10) = CStr(Val(varSite(intCurrentSys, 0, 0, 10)) + 1)
        varSite(intCurrentSys, intCurrentGroup, 0, 6) = DefaultLat 'Default latitude
        varSite(intCurrentSys, intCurrentGroup, 0, 7) = DefaultLong 'Default longtitude

        If Val(varSite(intCurrentSys, 0, 0, 3)) = 1 Then 'create a conventional group

            varSite(intCurrentSys, intCurrentGroup, 0, 1) = "Group " & TotGroups + 1
            varSite(intCurrentSys, intCurrentGroup, 0, 2) = "." 'quick key
            varSite(intCurrentSys, intCurrentGroup, 0, 3) = CStr(0) 'no lockout

            varSite(intCurrentSys, intCurrentGroup, 0, 10) = CreateGroupID()
            varSite(intCurrentSys, intCurrentGroup, 0, 5) = CStr(1)
            varSite(intCurrentSys, intCurrentGroup, 0, 8) = "1" 'gps  range
            varSite(intCurrentSys, intCurrentGroup, 0, 9) = "0" 'gps enable
        Else
            'create trunk group

            varSite(intCurrentSys, intCurrentGroup, 0, 1) = "TGID Group " & TotGroups + 1
            varSite(intCurrentSys, intCurrentGroup, 0, 2) = "." 'quick key
            varSite(intCurrentSys, intCurrentGroup, 0, 3) = CStr(0) 'no lockout

            varSite(intCurrentSys, intCurrentGroup, 0, 10) = CreateGroupID()
            varSite(intCurrentSys, intCurrentGroup, 0, 5) = CStr(2)
            'gps stuff
            varSite(intCurrentSys, intCurrentGroup, 0, 8) = "1" 'gps  range
            varSite(intCurrentSys, intCurrentGroup, 0, 9) = "0" 'gps enable
        End If
        If blnSkipGroup = False Then
            DrawSystemTree()
        End If
        If Val(varSite(intCurrentSys, 0, 0, 3)) = 6 And NewGroupNum >= 3 And blnSkipGroup = False Then
            '("LTR systems can only support one group per system.")
            DispStat("Caution: Not all scanners support more than 1 group for LTR!")
        End If
    End Sub




    Private Sub frmSystemEditor_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        Call FormReSize()
    End Sub

    Private Sub frmSystemEditor_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        ' Cancel = intCancel
    End Sub



    Public Sub mnuCopyChannel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCopyChannel.Click
        If intCurrentChannel <> 0 Then Call CopyChannel()
        'copy a site, group, or system
        'Determine what is select
        Dim intParam, intCnt, intNumGroups As Integer
        Dim strID(MaxGroups) As String
        Dim intMaxChan, intParam1 As Integer
        Dim strBuff As String
        Dim intNumChan, intCurChan, intChan As Integer
        If intCurrentSys = 0 Then
            Exit Sub 'nothing to do
        ElseIf intCurrentSys <> 0 And intCurrentGroup = 0 Then
            'copy a system
            Erase ChanCopy

            System.Array.Clear(strSysCopy, 0, strSysCopy.Length)
            intCurChan = 0
            intMaxChan = 0
            'Copy the entire system to buffer
            For intCnt = 0 To MaxGroups
                For intParam = 0 To MaxSetting

                    strSysCopy(intCnt, intParam) = varSite(intCurrentSys, intCnt, 0, intParam)
                Next intParam
                'save all groups IDs for later referencing
                If varSite(intCurrentSys, intCnt, 0, 10) <> "" Then
                    intNumGroups = intNumGroups + 1
                    strID(intNumGroups) = varSite(intCurrentSys, intCnt, 0, 10)
                End If
            Next intCnt


            strSysCopy(0, 23) = CreateGroupID()
            'Count how many channels are going to be needed
            For intCnt = 1 To intNumGroups
                strBuff = varSite(intCurrentSys, intCnt, 0, 10)
                For intParam = 0 To MaxChan
                    If ChanInfo(intParam, 10) = strBuff And ChanInfo(intParam, 10) <> "" Then 'does this channel belong to the system being copied?
                        intMaxChan = intMaxChan + 1
                    End If
                Next intParam
                For intParam = 0 To MaxTrunkFreq
                    If strTrunkFreq(intParam, 2) = strBuff And strTrunkFreq(intParam, 2) <> "" Then 'does this channel belong to the system being copied?
                        intMaxChan = intMaxChan + 1
                    End If
                Next intParam
            Next intCnt
            ReDim ChanCopy(intMaxChan + 1, MaxChanSetting)

            'Copy all of the channels over
            For intCnt = 1 To MaxGroups
                strBuff = varSite(intCurrentSys, intCnt, 0, 10)
                If strBuff <> "" Then
                    For intParam = 0 To MaxChan
                        If ChanInfo(intParam, 10) = strBuff Then 'does this channel belong to the system being copied?
                            'copy this channel to the buffer
                            intCurChan = intCurChan + 1
                            For intParam1 = 0 To MaxChanSetting
                                ChanCopy(intCurChan, intParam1) = ChanInfo(intParam, intParam1)
                            Next intParam1
                        End If
                    Next intParam
                    For intParam = 0 To MaxTrunkFreq
                        If strTrunkFreq(intParam, 2) = strBuff Then 'does this channel belong to the system being copied?
                            'copy this frequency to the buffer
                            intCurChan = intCurChan + 1
                            For intParam1 = 0 To 2
                                ChanCopy(intCurChan, intParam1) = strTrunkFreq(intParam, intParam1)
                            Next intParam1
                        End If
                    Next intParam
                End If
            Next intCnt

            'finally, write the chancopy type variable and set other variables
            If varSite(intCurrentSys, 0, 0, 3) = "1" Then
                mnuPasteChannel.Text = "Paste (" & varSite(intCurrentSys, 0, 0, 1) & " Conv System)"
            Else
                mnuPasteChannel.Text = "Paste (" & varSite(intCurrentSys, 0, 0, 1) & " Trunk System)"
            End If
            ChanCopy(0, 0) = "SYSTEM"
            DispStat("System " & varSite(intCurrentSys, 0, 0, 1) & " copied to clipboard")
        ElseIf intCurrentSys <> 0 And intCurrentGroup <> 0 And treeSystems.Focused Then
            'copy a group or site
            'determine what is being copied\
            Erase ChanCopy

            System.Array.Clear(strSysCopy, 0, strSysCopy.Length)
            intCurChan = 0
            intMaxChan = 0
            intNumChan = 0
            strBuff = varSite(intCurrentSys, intCurrentGroup, 0, 10)
            If varSite(intCurrentSys, intCurrentGroup, 0, 5) = "3" Then 'a site
                'Count how many channels are associated with it
                For intChan = 0 To MaxTrunkFreq
                    If strTrunkFreq(intChan, 2) = strBuff Then
                        intNumChan = intNumChan + 1
                    End If
                Next intChan
                ReDim ChanCopy(intNumChan + 2, 10)
                ChanCopy(0, 0) = "TRUNKSITE"
                'copy all the channels to the buffer first
                If intNumChan <> 0 Then
                    For intChan = 1 To MaxTrunkFreq
                        If strTrunkFreq(intChan, 2) = strBuff Then
                            intCurChan = intCurChan + 1
                            ChanCopy(intCurChan, 0) = strTrunkFreq(intChan, 0)
                            ChanCopy(intCurChan, 1) = strTrunkFreq(intChan, 1)
                            ChanCopy(intCurChan, 2) = strTrunkFreq(intChan, 2)
                        End If
                    Next intChan
                End If
                mnuPasteChannel.Text = "Paste (" & varSite(intCurrentSys, intCurrentGroup, 0, 1) & " Trunk Site)"
            Else 'a group
                For intChan = 0 To MaxChan
                    If ChanInfo(intChan, 10) = strBuff Then
                        intNumChan = intNumChan + 1
                    End If
                Next intChan
                ReDim ChanCopy(intNumChan + 2, MaxChanSetting)
                If intNumChan <> 0 Then
                    For intChan = 1 To MaxChan
                        If ChanInfo(intChan, 10) = strBuff Then
                            intCurChan = intCurChan + 1
                            For intParam = 0 To MaxChanSetting
                                ChanCopy(intCurChan, intParam) = ChanInfo(intChan, intParam)
                            Next intParam
                        End If
                    Next intChan
                End If
                Select Case varSite(intCurrentSys, intCurrentGroup, 0, 5)
                    Case "1"
                        ChanCopy(0, 0) = "CONVGROUP"
                    Case "2"
                        ChanCopy(0, 0) = "TRUNKGROUP"
                End Select
                mnuPasteChannel.Text = "Paste (" & varSite(intCurrentSys, intCurrentGroup, 0, 1) & " Group)"
            End If
            'now copy the rest of the group information
            For intParam = 0 To MaxSetting

                strSysCopy(0, intParam) = varSite(intCurrentSys, intCurrentGroup, 0, intParam)
            Next intParam
            DispStat(varSite(intCurrentSys, intCurrentGroup, 0, 1) & " copied to clipboard.")
        ElseIf intCurrentSys <> 0 And intCurrentGroup <> 0 And intCurrentChannel <> 0 Then
            Call CopyChannel()
        End If
    End Sub
    Sub CopyChannel()
        If blnDebug = False Then On Error Resume Next
        'copies channels to buffer
        Dim intStartrow, intEndRow As Integer, intNumRow As Integer
        Dim intParam, intRow, intChan, intBuff As Integer
        Dim strBuffer As String
        Dim intCol, intColSel As Integer
        If frmGroupConv.Visible = True Then
            'copy trunked channels
            BuildGridArray()
            If IsArray(intGridSel) = False Then Exit Sub
            intNumRow = UBound(intGridSel)
            ReDim ChanCopy((intNumRow) + 2, MaxChanSetting)
            ChanCopy(0, 0) = "CONV"

            For intRow = 0 To intNumRow
                intBuff = intBuff + 1
                intChan = GetRealChan(intCurrentSys, intCurrentGroup, intGridSel(intRow) + 1)
                For intParam = 0 To MaxChanSetting
                    ChanCopy(intBuff, intParam) = ChanInfo(intChan, intParam)
                Next intParam
            Next intRow
            'Copy channels to the actual clipboard
            mnuPasteChannel.Text = "Paste (" & intBuff & " Conventional Channels)"
            DispStat(intBuff & " channel(s) copied to buffer.")
            blnSuccess = True
            Me.grdConvChan.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            strBuffer = grdConvChan.GetClipboardContent.GetText()
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(strBuffer)
        ElseIf frmGroupTrunk.Visible = True Then
            'copy trunked channels
            BuildGridArray()
            If IsArray(intGridSel) = False Then Exit Sub
            intNumRow = UBound(intGridSel)
            ReDim ChanCopy((intNumRow) + 2, MaxChanSetting)
            ChanCopy(0, 0) = "TGID"
            For intRow = 0 To intNumRow
                intBuff = intBuff + 1
                intChan = GetRealChan(intCurrentSys, intCurrentGroup, intGridSel(intRow) + 1)
                For intparam = 0 To MaxChanSetting
                    ChanCopy(intBuff, intParam) = ChanInfo(intChan, intParam)
                Next intParam
            Next intRow
            'Copy channels to the actual clipboard


            mnuPasteChannel.Text = "Paste (" & intBuff & " TGID)"
            DispStat(intBuff & " channel(s) copied to buffer.")
            blnSuccess = True
            Me.grdTGID.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            strBuffer = grdTGID.GetClipboardContent.GetText()
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(strBuffer)
        ElseIf grdTrunkFreq.Visible = True And tabTrunkSite.SelectedIndex = 1 Then
            'copy trunked channels
            strBuffer = ""
            BuildGridArray()
            If IsArray(intGridSel) = False Then Exit Sub
            intNumRow = UBound(intGridSel)
            ReDim ChanCopy(intNumRow + 2, 5)
            ChanCopy(0, 0) = "TRN"

            For intRow = 0 To intNumRow
                intBuff = intGridSel(intRow)
                ChanCopy(intRow + 1, 1) = grdTrunkFreq(0, intBuff).Value 'freq
                ChanCopy(intRow + 1, 2) = grdTrunkFreq(1, intBuff).Value 'lcn
                ChanCopy(intRow + 1, 3) = MakeBinary(grdTrunkFreq(2, intBuff).Value) 'l/o status
                ChanCopy(intRow + 1, 5) = grdTrunkFreq(3, intBuff).Value 'vol adjust
                ChanCopy(intRow + 1, 4) = grdTrunkFreq(4, intBuff).Value 'num tag
            Next intRow
            mnuPasteChannel.Text = "Paste (" & intBuff & " Trunk Frequencies)"
            Me.grdTrunkFreq.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            strBuffer = grdTrunkFreq.GetClipboardContent.GetText()
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText((strBuffer))
            blnSuccess = True
        Else
            MsgBox("Please select a conventional group, TGID group, or the trunk frequencies you wish to copy.")
        End If
    End Sub
    Private Sub mnuCreateGroup_Click()
        MakeNewGroup()
        UpdateTreeSelection()
        UpdateViewMode()
        'automatic highlighting of default group name
        If txtConvGroupName.Visible = True Then
            txtConvGroupName.Focus()
            txtConvGroupName.SelectionStart = 0
            txtConvGroupName.SelectionLength = Len(txtConvGroupName.Text)
        ElseIf txtTGIDGroupName.Visible = True Then
            With txtTGIDGroupName
                .Focus()
                .SelectionStart = 0
                .SelectionLength = Len(.Text)
            End With
        End If
    End Sub

    Sub mnuCreateNewSystem_Click()
        'create a new site
        'first, find out what type of site
        'brings up a dialog box to ask the user for the site type
        Me.Enabled = False
        frmNewSite.Enabled = True
        frmNewSite.Visible = True
        frmNewSite.cmdSelectSysType.Focus()
        '  MarkChange()
    End Sub

    Sub CreateNewSystem()
        'called from the frmNewSite dialog box
        If ChosenSysType = 0 Then
            Exit Sub 'user abort or invalid input
        ElseIf ChosenSysType = 1 Then  'conventional
            'setup for conventional system
            'first setup variable array
            MakeNewConvSystem()
            'DrawSystemTree
            ViewMode("SystemEdit") 'Turns on right screen for user editing
        Else
            MakeNewTrunkSystem((ChosenSysType))
            'DrawSystemTree
            ViewMode("TrunkSysSetup")
        End If
        UpdateTreeSelection()
        UpdateViewMode()
        'Call treeSystems_Click(treeSystems, New System.EventArgs())
        MarkChange()
    End Sub
    Function ViewMode(ByRef Mode As String) As String
        ViewMode = Nothing
        'this function turns various frames on/off to suit the current desired view mode
        frmSiteOptConv(0).Visible = False
        frmGroupConv.Visible = False
        frmGroupTrunk.Visible = False

        frmFleetMap.Visible = False
        frmTrunkSys.Visible = False
        tabTrunkSite.Visible = False
        mnuSort.Enabled = False
        NewSiteToolStripButton2.Enabled = False
        mnuEditJustChan.Enabled = False
        mnuEditFreqFill.Enabled = False

        Select Case UCase(Mode)
            Case "SYSTEMEDIT"
                frmSiteOptConv(0).Visible = True
                LoadData(Mode)
            Case "CONVSYSGROUP"
                frmGroupConv.Visible = True
                mnuSort.Enabled = True
                intCurrentChannel = 1
                LoadData(Mode)
                mnuEditJustChan.Enabled = True
                mnuEditFreqFill.Enabled = True
            Case "TRUNKSYSSETUP"
                frmTrunkSys.Visible = True
                LoadData(Mode)
                NewSiteToolStripButton2.Enabled = True
            Case "TRUNKSITESETUP"
                tabTrunkSite.Visible = True
                ' tabTrunkSite.Tab = 0
                LoadData(Mode)
                LoadData("TRUNKFREQ")
                NewSiteToolStripButton2.Enabled = True
            Case "APCOBP"
                LoadData(Mode)
                NewSiteToolStripButton2.Enabled = True
            Case "TRUNKFREQ"
                LoadData(Mode)
                NewSiteToolStripButton2.Enabled = True
            Case "GROUPTRUNK"
                frmGroupTrunk.Visible = True
                mnuSort.Enabled = True
                intCurrentChannel = 1
                LoadData(Mode)
                NewSiteToolStripButton2.Enabled = True
                mnuEditJustChan.Enabled = True
            Case "FLEETMAP"
                frmFleetMap.Visible = True
                LoadData(Mode)
                NewSiteToolStripButton2.Enabled = True
            Case Else
                'everything stays off
        End Select
    End Function
    Function LoadData(ByRef Dest As String) As String
        'this function loads data from the memory array
        'and into checkboxes, text boxes etc for editing
        'Exit Function
        LoadData = Nothing
        Dim x, cnt As Integer
        Dim intNumFreqs As Integer
        Dim strQGL, strBuff As String
        Dim strVars() As String
        Dim strSet() As String

        If blnDebug = False Then On Error Resume Next
        blnBusy = True

        Dim intnumFreq As Integer
        Dim intLCN As Integer

        Select Case UCase(Dest)
            Case "SYSTEMEDIT" 'conventional system edit
                txtSiteName.Text = varSite(intCurrentSys, 0, 0, 1)
                chkSiteLockedOut.CheckState = Val(varSite(intCurrentSys, 0, 0, 2))
                cmbQuickKey.Text = varSite(intCurrentSys, 0, 0, 4)
                cmbConvStartupKey.Text = varSite(intCurrentSys, 0, 0, 7)
                cmbConvHoldTime.Text = varSite(intCurrentSys, 0, 0, 5)
                cmbConvDelayTime.Text = varSite(intCurrentSys, 0, 0, 6)
                chkDataSkip.CheckState = Val(varSite(intCurrentSys, 0, 0, 9))
                optConvTapeOut(Val(varSite(intCurrentSys, 0, 0, 24))).Checked = 1
                chkSysGPSEnable.CheckState = Val(varSite(intCurrentSys, 0, 0, 22))
                lblSysLong.Text = FormatDMS(varSite(intCurrentSys, 0, 0, 20))
                lblSysLat.Text = FormatDMS(varSite(intCurrentSys, 0, 0, 19))
                lblSysRange.Text = Val(varSite(intCurrentSys, 0, 0, 21)) & " Miles / " & Val(varSite(intCurrentSys, 0, 0, 21)) * 1.60934 & " KMs"
                'load quick keys
                If Len(varSite(intCurrentSys, 0, 0, 8)) <> 10 Then 'valid quick key data is not present
                    strQGL = "1111111111"
                Else
                    strQGL = varSite(intCurrentSys, 0, 0, 8)
                End If
                For cnt = 1 To 10

                    chkQGLCnv(cnt).CheckState = Val(Mid(strQGL, cnt, 1))
                Next cnt
                '396xt options
                chkCnvAGCA.CheckState = MakeBinary(varSite(intCurrentSys, 0, 0, 29))
                chkCnvAGCD.CheckState = MakeBinary(varSite(intCurrentSys, 0, 0, 30))
                txtCnvNumTag.Text = MakeItKosherNumTag(varSite(intCurrentSys, 0, 0, 28))
                cmbCnvP25Wait.Text = CStr(Val(varSite(intCurrentSys, 0, 0, 31)))
                'system protect
                chkCnvSysProtect.Checked = MakeBoolean(varSite(intCurrentSys, 0, 0, 32))
                'apco settings
                If varSite(intCurrentSys, 0, 0, 48) <> "" Then
                    cmbAPCO(0).Text = varSite(intCurrentSys, 0, 0, 48)
                    cmbAPCO(1).Text = CStr(Val(varSite(intCurrentSys, 0, 0, 49)))
                Else
                    cmbAPCO(0).Text = APCOMode
                    cmbAPCO(1).Text = APCOThreshold
                    varSite(intCurrentSys, 0, 0, 48) = APCOMode
                    varSite(intCurrentSys, 0, 0, 49) = APCOThreshold
                End If
                'State
                strBuff = varSite(intCurrentSys, 0, 0, 33)
                If Not IsNumeric(strBuff) Then
                    varSite(intCurrentSys, 0, 0, 33) = "0"
                End If
                cmbConvState.Text = varState(Val(strBuff), 1)
            Case "CONVSYSGROUP"
                txtConvGroupName.Text = varSite(intCurrentSys, intCurrentGroup, 0, 1)
                cmbConvGroupQuickKey.Text = varSite(intCurrentSys, intCurrentGroup, 0, 2)
                chkConvGroupLockout.CheckState = Val(varSite(intCurrentSys, intCurrentGroup, 0, 3))
                'GPS PARAMETERS
                chkCnvGrpGPS.CheckState = MakeBinary(varSite(intCurrentSys, intCurrentGroup, 0, 9))
                lblCnvGrpLat.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 6))
                lblCnvGrpLong.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 7))
                lblCnvGrpRange.Text = Val(varSite(intCurrentSys, intCurrentGroup, 0, 8)) & " Miles / " & Val(varSite(intCurrentSys, intCurrentGroup, 0, 8)) * 1.60934 & " KMs"

                LoadConvChanGrid()
            Case "TRUNKSITESETUP"

                Call LoadAPCOBP()
                blnBusy = True
                txtTrunkSiteName.Text = varSite(intCurrentSys, intCurrentGroup, 0, 1)
                cmbSiteQK.Text = varSite(intCurrentSys, intCurrentGroup, 0, 2)
                cmbTrnSiteStartupKey.Text = varSite(intCurrentSys, intCurrentGroup, 0, 12)
                cmbTrnSiteHoldTime.Text = CStr(Val(varSite(intCurrentSys, intCurrentGroup, 0, 4)))
                If varSite(intCurrentSys, intCurrentGroup, 0, 6) <> "" Then
                    cmbTrnModMode.Text = varSite(intCurrentSys, intCurrentGroup, 0, 6)
                End If
                'site type stuff, gets more complicated
                cmbTrnSiteType.Items.Clear()
                Select Case varSite(intCurrentSys, 0, 0, 3)
                    Case CStr(2) 'motorola type 1
                        cmbTrnSiteType.Items.Add(SiteType(7, 0)) 'standard
                        cmbTrnSiteType.Items.Add(SiteType(8, 0)) 'splinter
                        cmbTrnSiteType.Items.Add(SiteType(16, 0)) 'custom
                        Select Case Val(varSite(intCurrentSys, intCurrentGroup, 0, 9))
                            Case 7
                                cmbTrnSiteType.SelectedIndex = 0
                            Case 8
                                cmbTrnSiteType.SelectedIndex = 1
                            Case Else
                                cmbTrnSiteType.SelectedIndex = 2
                        End Select
                    Case CStr(3) 'motorola type II
                        cmbTrnSiteType.Items.Add(SiteType(1, 0))
                        cmbTrnSiteType.Items.Add(SiteType(2, 0))
                        cmbTrnSiteType.Items.Add(SiteType(3, 0))
                        cmbTrnSiteType.Items.Add(SiteType(4, 0))
                        cmbTrnSiteType.Items.Add(SiteType(5, 0))
                        cmbTrnSiteType.Items.Add(SiteType(6, 0))
                        cmbTrnSiteType.Items.Add(SiteType(13, 0))

                        cnt = Val(varSite(intCurrentSys, intCurrentGroup, 0, 9))

                        If cnt > 0 And cnt < 7 Then
                            cmbTrnSiteType.SelectedIndex = Val(CStr(CDbl(varSite(intCurrentSys, intCurrentGroup, 0, 9)) - 1))

                        ElseIf cnt = 13 Then  'Mot type II Custom
                            cmbTrnSiteType.SelectedIndex = 6
                        Else
                            cmbTrnSiteType.SelectedIndex = 0
                        End If
                    Case CStr(4) 'edacs narrow/wide
                        cmbTrnSiteType.Items.Add(SiteType(9, 0))
                        cmbTrnSiteType.Items.Add(SiteType(10, 0))
                        If Val(varSite(intCurrentSys, intCurrentGroup, 0, 9)) = 10 Then
                            cmbTrnSiteType.SelectedIndex = 1
                        Else
                            cmbTrnSiteType.SelectedIndex = 0
                        End If
                    Case CStr(5) 'edacs SCAT
                        cmbTrnSiteType.Items.Add((SiteType(11, 0)))
                        cmbTrnSiteType.SelectedIndex = 0
                    Case CStr(6) 'LTR
                        cmbTrnSiteType.Items.Add(SiteType(12, 0))
                        cmbTrnSiteType.SelectedIndex = 0
                    Case CStr(7) 'p25 standard
                        cmbTrnSiteType.Items.Add(SiteType(14, 0))
                        cmbTrnSiteType.SelectedIndex = 0
                    Case CStr(8) 'p25 one freq trunk
                        cmbTrnSiteType.Items.Add(SiteType(15, 0))
                        cmbTrnSiteType.SelectedIndex = 0
                    Case CStr(9) 'MotoTurbo
                        cmbTrnSiteType.Items.Add(SiteType(17, 0))
                        cmbTrnSiteType.SelectedIndex = 0
                    Case CStr(10) 'DMR
                        cmbTrnSiteType.Items.Add(SiteType(18, 0))
                        cmbTrnSiteType.SelectedIndex = 0
                End Select

                'GPS Stuff
                chkTrnGPSEnable.CheckState = Val(varSite(intCurrentSys, intCurrentGroup, 0, 16))

                lblTrnLong.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 14))

                lblTrnLat.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 13))
                lblTrnRange.Text = Val(varSite(intCurrentSys, intCurrentGroup, 0, 15)) & " Miles / " & Val(varSite(intCurrentSys, intCurrentGroup, 0, 15)) *  1.60934 & " KMs"

                'control channel only
                If varSite(intCurrentSys, intCurrentGroup, 0, 9) = "14" Or varSite(intCurrentSys, intCurrentGroup, 0, 9) = "6" Then
                    'P25 site, CCO mode enforce on
                    varSite(intCurrentSys, intCurrentGroup, 0, 8) = "1"
                    chkControlChanOnly.Enabled = False
                Else
                    chkControlChanOnly.Enabled = True
                End If
                chkControlChanOnly.CheckState = Val(varSite(intCurrentSys, intCurrentGroup, 0, 8))
                'LO
                chkTrnSiteLO.CheckState = Val(varSite(intCurrentSys, intCurrentGroup, 0, 3))
                chkTrnSiteAtt.CheckState = Val(varSite(intCurrentSys, intCurrentGroup, 0, 7))
                'APCO Setting
                If varSite(intCurrentSys, intCurrentGroup, 0, 26) <> "" Then
                    cmbAPCO(2).Text = varSite(intCurrentSys, intCurrentGroup, 0, 26)
                    cmbAPCO(3).Text = CStr(Val(varSite(intCurrentSys, intCurrentGroup, 0, 27)))
                Else
                    cmbAPCO(2).Text = APCOMode
                    cmbAPCO(3).Text = APCOThreshold
                    varSite(intCurrentSys, intCurrentGroup, 0, 26) = APCOMode
                    varSite(intCurrentSys, intCurrentGroup, 0, 27) = APCOThreshold
                End If


                'xt p25 wait time
                cmbTrnP25Wait.Text = CStr(Val(varSite(intCurrentSys, intCurrentGroup, 0, 61)))
                'Load the Band Plan
                With grdReband
                    .Rows.Clear()
                    .RowCount = 6

                    strBuff = varSite(intCurrentSys, intCurrentGroup, 0, 62)
                    If Len(strBuff) > 10 Then
                        strVars = Split(strBuff, "@")
                        If UBound(strVars) = 5 Then
                            For x = 0 To 5
                                Erase strSet
                                strSet = Split(strVars(x), ",")
                                If UBound(strSet) = 3 Then

                                    grdReband(0, x).Value = FormatFreq(Val(strSet(0)) / 10000) 'low freq
                                    grdReband(1, x).Value = FormatFreq(Val(strSet(1)) / 10000) 'upper freq
                                    'step
                                    For cnt = 0 To 31
                                        If strSet(2) = strMcpStep(cnt) Then
                                            grdReband(2, x).Value = Val(strMcpStep(cnt) / 100).ToString("###0.0#")
                                            cnt = 31
                                        End If
                                    Next
                                    grdReband(3, x).Value = strSet(3) 'offset
                                End If
                            Next x
                        End If
                    Else
                        'no data, leave it blank?
                    End If
                End With
                'Site note
                lblSiteNote1.Text = varSite(intCurrentSys, intCurrentGroup, 0, 28)
                'State
                strBuff = varSite(intCurrentSys, intCurrentGroup, 0, 32)
                If IsNumeric(strBuff) Then
                    cmbSiteState.Text = varState(Val(strBuff), 1)
                Else
                    cmbSiteState.Text = "Off"
                    varSite(intCurrentSys, intCurrentGroup, 0, 32) = "0"
                End If

            Case "TRUNKSYSSETUP"

                'id/scan or search mode
                txtTrunkSysName.Text = varSite(intCurrentSys, 0, 0, 1)
                Select Case varSite(intCurrentSys, 0, 0, 11)
                    Case CStr(1)
                        optIDSearch.Checked = 1
                    Case Else
                        optIDScan.Checked = 1
                End Select
                Select Case varSite(intCurrentSys, 0, 0, 14)
                    Case CStr(1)
                        optEDACSIDAFS.Checked = True
                    Case Else
                        optEDACSIDDec.Checked = True
                End Select
                cmbTrunkSysDelay.Text = CStr(Val(varSite(intCurrentSys, 0, 0, 6)))
                'motorola status bit
                chkMotStatusBit.CheckState = Val(varSite(intCurrentSys, 0, 0, 12))
                'i-call
                chkICall.CheckState = Val(varSite(intCurrentSys, 0, 0, 15))
                'mot end code
                chkUseMotEndCode.CheckState = Val(varSite(intCurrentSys, 0, 0, 13))
                chkMotDigEndCode.CheckState = Val(varSite(intCurrentSys, 0, 0, 27))
                cmbTrnEmergAlertType.Text = CStr(Val(varSite(intCurrentSys, 0, 0, 25)))
                cmbTrnEmergAlertLevel.Text = CStr(Val(varSite(intCurrentSys, 0, 0, 26)))

                'quick key
                cmbTrnSysQK.SelectedIndex = 0 'always at non set since systems cant have qks

                x = Val(varSite(intCurrentSys, 0, 0, 3))
                '       If x = 9 Or x = 10 Then ' if this is a mototrbo or dmr system, only one site type avail
                'cmbTrnSysType.SelectedIndex = 0

                If Val(x) > 1 Then
                    cmbTrnSysType.SelectedIndex = x - 2
                End If
                '396xt options
                chkTrnAGCA.CheckState = MakeBinary(varSite(intCurrentSys, 0, 0, 29))
                chkTrnAGCD.CheckState = MakeBinary(varSite(intCurrentSys, 0, 0, 30))
                txtTrnNumTag.Text = MakeItKosherNumTag(varSite(intCurrentSys, 0, 0, 28))
                Select Case varSite(intCurrentSys, 0, 0, 52)
                    Case 0
                        cmbTrnAltPat.Text = "On"
                    Case 1
                        cmbTrnAltPat.Text = "Slow"
                    Case 2
                        cmbTrnAltPat.Text = "Fast"
                End Select
                If varSite(intCurrentSys, 0, 0, 51) <> "" Then
                    cmbTrnAltCol.Text = varSite(intCurrentSys, 0, 0, 51)
                Else
                    cmbTrnAltCol.Text = "Off"
                    varSite(intCurrentSys, 0, 0, 51) = "OFF"
                End If
                optTrnRecord(Val(varSite(intCurrentSys, 0, 0, 24))).Checked = 1
                'priority ID scan
                chkTrnPriScan.Checked = MakeBoolean(varSite(intCurrentSys, 0, 0, 54))
                'P25 NAC Search
                txtP25NacSearch.Text = varSite(intCurrentSys, 0, 0, 53)
                If varSite(intCurrentSys, 0, 0, 3) = "8" Then
                    txtP25NacSearch.Enabled = True
                Else
                    txtP25NacSearch.Enabled = False
                End If
                'load quick keys
                If Len(varSite(intCurrentSys, 0, 0, 8)) <> 10 Then 'valid quick key data is not present
                    strQGL = "1111111111"
                Else
                    strQGL = varSite(intCurrentSys, 0, 0, 8)
                End If
                For cnt = 1 To 10

                    chkQGLTrn(cnt).CheckState = Val(Mid(strQGL, cnt, 1))
                Next cnt
                'number of tgid
                intNumFreqs = 0
                For cnt = 1 To MaxGroups

                    If varSite(intCurrentSys, cnt, 0, 5) = "2" Then 'this is a tgid group

                        intNumFreqs = intNumFreqs + GetNumChan(intCurrentSys, cnt)
                    End If
                Next cnt
                If intNumFreqs > 500 Then
                    strQGL = intNumFreqs & " TGIDs in this system (Over maximum TGID Limit!)"
                    lblTGIDStat.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                ElseIf intNumFreqs > 250 Then
                    strQGL = intNumFreqs & " TGIDs in this system (Over limit for all except XT scanners)"
                    lblTGIDStat.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
                ElseIf intNumFreqs > 200 Then
                    strQGL = intNumFreqs & " TGIDs in this system (Over limit for 246/330/396T)"
                    lblTGIDStat.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
                Else
                    strQGL = intNumFreqs & " TGIDs in this system."
                    lblTGIDStat.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
                End If
                lblTGIDStat.Text = strQGL
                'system protect
                chkTrnSysProtect.Checked = MakeBoolean(varSite(intCurrentSys, 0, 0, 32))
            Case "TRUNKFREQ"
                'load all current trunk frequencies for the current site
                With grdTrunkFreq
                    intnumFreq = 0
                    intLCN = 0
                    'if there are anyfrequencies, proceed to load them
                    .EndEdit()
                    .ClearSelection()
                    .Refresh()
                    .RowCount = 0
                    intnumFreq = 0
                    For x = 1 To MaxTrunkFreq
                        'does this belong to the current group?
                        If strTrunkFreq(x, 2) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then
                            .RowCount = .RowCount + 1
                            grdTrunkFreq(0, intnumFreq).Value = FormatFreq(CDbl(Val(strTrunkFreq(x, 0)))) 'freq
                            grdTrunkFreq(1, intnumFreq).Value = strTrunkFreq(x, 1) 'cln
                            If strTrunkFreq(x, 3) = "1" Then
                                grdTrunkFreq(2, intnumFreq).Value = True 'lo
                            Else
                                grdTrunkFreq(2, intnumFreq).Value = False
                            End If
                            cnt = Val(strTrunkFreq(x, 5))
                            If cnt >= -3 And cnt <= 3 Then
                                grdTrunkFreq(3, intnumFreq).Value = CStr(cnt) 'vol
                            Else
                                grdTrunkFreq(3, intnumFreq).Value = "0"
                                strTrunkFreq(x, 5) = "0"
                            End If
                            grdTrunkFreq(4, intnumFreq).Value = strTrunkFreq(x, 4) 'Number tag
                            intnumFreq = intnumFreq + 1
                        End If
                    Next x
                End With
            Case "GROUPTRUNK"
                'loads TGID information for the current group
                'start with group setting
                If intCurrentGroup = 0 Then
                    'should never be the case
                    frmGroupTrunk.Visible = False
                Else
                    frmGroupTrunk.Visible = True
                    txtTGIDGroupName.Text = varSite(intCurrentSys, intCurrentGroup, 0, 1)
                    cmbTGIDGroupQuickkey.Text = varSite(intCurrentSys, intCurrentGroup, 0, 2)
                    chkTGIDGroupLockout.CheckState = Val(varSite(intCurrentSys, intCurrentGroup, 0, 3))
                    'GPS PARAMETERS
                    chkTGIDGpsEnabled.CheckState = MakeBinary(varSite(intCurrentSys, intCurrentGroup, 0, 9))
                    lblTGIDLat.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 6))
                    lblTGIDLong.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 7))
                    lblTGIDRange.Text = Val(varSite(intCurrentSys, intCurrentGroup, 0, 8)) & " Miles / " & Val(varSite(intCurrentSys, intCurrentGroup, 0, 8)) * 1.60934 & " KMs"

                    LoadTrunkChanGrid()
                End If
            Case "FLEETMAP"
                'loads fleet map information
                For x = 0 To 7
                    cmbSizeCode(x).Text = CStr(Val(GetSizeCode(intCurrentSys, 0, x)))
                Next x
                If Val(varSite(intCurrentSys, 0, 0, 16)) = 16 Then
                    cmbFleetMap.Text = "Custom"
                Else
                    cmbFleetMap.Text = CStr(Val(CStr(CDbl(varSite(intCurrentSys, 0, 0, 16)) + 1)))
                End If
            Case "APCOBP"
                Call LoadAPCOBP()
        End Select
        blnBusy = False
    End Function
    Sub LoadAPCOBP()
        'APCO BAND PLAN
        Dim strFreq() As String, strSpacing() As String
        Dim cnt As Integer
        grdAPCO.ClearSelection()
        grdAPCO.RowCount = 16
        strFreq = Split(varSite(intCurrentSys, intCurrentGroup, 0, 30), ",")
        strSpacing = Split(varSite(intCurrentSys, intCurrentGroup, 0, 31), ",")
        If UBound(strFreq) <> 15 Then
            strFreq = Split("0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0", ",")
            strSpacing = Split("0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0", ",")
        End If

        For cnt = 0 To 15
            grdAPCO(0, cnt).Value = Hex(cnt) 'pos numb
            grdAPCO(1, cnt).Value = FormatFreq(strFreq(cnt))
            grdAPCO(2, cnt).Value = Val(strSpacing(cnt)).ToString("##0.000")
        Next
    End Sub
    Function GetSizeCode(ByRef intsite As Integer, ByRef intgroup As Integer, ByRef intPos As Integer) As String
        'returns the size code from memory for a custom fleet map
        Dim strFleet As String
        Dim strSizeCode As String




        strFleet = varSite(intsite, intgroup, 0, 17)
        If Len(strFleet) = 24 Then


            strSizeCode = Mid(strFleet, (3 * intPos) + 2, 2)

            GetSizeCode = strSizeCode
        Else

            GetSizeCode = 0
        End If
    End Function

    Sub LoadTrunkChanGrid()
        'loads all of the relevant frequencies for a TGID system
        'into a grid.
        If blnDebug = False Then On Error Resume Next
        Dim intRow, x, intChannel As Integer
        Dim intCol As Integer
        intRow = 0
        With grdTGID
            .Rows.Clear()
            .RowCount = GetNumChan(intCurrentSys, intCurrentGroup)
            If GetSetting("FreeSCAN", "Settings", "AltColour", "0") = "1" Then
                'figure it out
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
            Else
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End If
        End With
        'now load data into remaining cell
        blnBusy = True
        If GetNumChan(intCurrentSys, intCurrentGroup) = 0 Then
            'no freqs loaded
        Else
            'cycle through and find and display all the channels
            For intChannel = 1 To MaxChan
                If ChanInfo(intChannel, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then 'is this a valid channel?
                    LoadTrunkChanGridRow(intRow, intChannel)
                    intRow += 1
                End If
            Next intChannel
        End If
        blnBusy = False

        With grdTGID
            If .RowCount > 1 And intCurrentChannel < .RowCount And intCurrentChannel > 0 Then
                Me.grdTGID.CurrentCell = grdTGID(0, intCurrentChannel - 1)
            ElseIf .RowCount <> 0 Then
                Me.grdTGID.CurrentCell = grdTGID(0, 0)
            End If
        End With

    End Sub
    Sub LoadTrunkChanGridRow(ByVal intRow As Integer, ByVal intChannel As Integer)

        If blnDebug = False Then On Error Resume Next
        grdTGID(0, intRow).Value = ChanInfo(intChannel, 1) 'name
        grdTGID(1, intRow).Value = ChanInfo(intChannel, 2) 'TGID
        If ChanInfo(intChannel, 3) = "1" Then 'LO
            grdTGID(2, intRow).Value = 1
        Else
            grdTGID(2, intRow).Value = 0
        End If
        If ChanInfo(intChannel, 8) = "1" Then 'PRI
            grdTGID(3, intRow).Value = 1
        Else
            grdTGID(3, intRow).Value = 0
        End If
        'alert tone
        If IsNumeric(ChanInfo(intChannel, 4)) = True And Val(ChanInfo(intChannel, 4)) >= 0 And Val(ChanInfo(intChannel, 4)) <= 9 Then
            grdTGID(4, intRow).Value = ChanInfo(intChannel, 4)
        Else
            grdTGID(4, intRow).Value = "0"
            ChanInfo(intChannel, 4) = "0"
        End If
        'alert level
        If IsNumeric(ChanInfo(intChannel, 5)) = True And Val(ChanInfo(intChannel, 5)) >= 0 And Val(ChanInfo(intChannel, 5)) <= 15 Then
            grdTGID(5, intRow).Value = ChanInfo(intChannel, 5)

        Else
            grdTGID(5, intRow).Value = "0"
            ChanInfo(intChannel, 5) = "0"
        End If
        'alert colour
        If ChanInfo(intChannel, 20) <> "" And IsNumeric(ChanInfo(intChannel, 20)) = False Then
            grdTGID(6, intRow).Value = TCase(ChanInfo(intChannel, 20))
        Else
            grdTGID(6, intRow).Value = "Off"
            ChanInfo(intChannel, 20) = "OFF"
        End If
        'alert light pattern0
        Select Case ChanInfo(intChannel, 21)
            Case "0" 'on
                grdTGID(7, intRow).Value = "On"
            Case "1" 'slow
                grdTGID(7, intRow).Value = "Slow"
            Case "2" ' fast
                grdTGID(7, intRow).Value = "Fast"
            Case Else
                grdTGID(7, intRow).Value = "On"
                ChanInfo(intChannel, 21) = "0"
        End Select

        'volume offset
        If Val(ChanInfo(intChannel, 22)) >= -3 And Val(ChanInfo(intChannel, 22)) <= 3 Then
            grdTGID(8, intRow).Value = CStr(Val(ChanInfo(intChannel, 22)))
        Else
            grdTGID(8, intRow).Value = "0"
            ChanInfo(intChannel, 22) = "0"
        End If
        'audio type
        Select Case Val(ChanInfo(intChannel, 6))
            Case 0
                grdTGID(9, intRow).Value = "All"
            Case 1
                grdTGID(9, intRow).Value = "Analog Only"
            Case Else
                grdTGID(9, intRow).Value = "Digital Only"
        End Select

        'numer tag
        If ChanInfo(intChannel, 19) <> "" Then
            grdTGID(10, intRow).Value = ChanInfo(intChannel, 19)
        Else
            grdTGID(10, intRow).Value = "None"
            ChanInfo(intChannel, 19) = "NONE"
        End If

        If ChanInfo(intChannel, 7) = "1" Then
            grdTGID(11, intRow).Value = True 'tapeout
        Else
            grdTGID(11, intRow).Value = False
        End If
        grdTGID(12, intRow).Value = ChanInfo(intChannel, 14) 'comment
    End Sub

    Sub UpdateViewMode()
        'this subroutine turns frames on/off, depending on what kind of branch is clicking on
        Dim strKey As String
        Try
            If Nothing = treeSystems.SelectedNode.Tag Then Exit Sub
        Catch ex As Exception
            Exit Sub
        End Try
        Try
            'first get the key from the tree
            strKey = (treeSystems.SelectedNode.Tag)
            'update currently selected system in memory


            'turning view modes on/off
            If treeSystems.Nodes.Count = 0 Or Len(strKey) = 0 Then
                'click everything off
                ViewMode("OFF")
                intCurrentSys = 0
                intCurrentGroup = 0
                intCurrentChannel = 0
            ElseIf Len(strKey) = 5 Then  'a system has been selected, determine if its trunked or conventional
                'set current site paramaters to this one
                intCurrentSys = Val(VB.Right(strKey, 4))
                intCurrentGroup = 0
                intCurrentChannel = 0
                If varSite(intCurrentSys, 0, 0, 3) = "1" Then
                    ViewMode("SystemEdit")
                Else 'assume its trunked
                    ViewMode("TrunkSyssetup")
                End If
            ElseIf Len(strKey) = 10 Then  'A group has been selected
                'is this a trunk site or an actual group?
                'set current site/groups to this one
                intCurrentSys = Val(VB.Right(VB.Left(strKey, 5), 4))
                intCurrentGroup = Val(VB.Right(strKey, 4))
                intCurrentChannel = 0
                'find out if it belongs to a conv or trunked site and turn on appropiate view

                If varSite(intCurrentSys, intCurrentGroup, 0, 5) = "1" Then
                    ViewMode("ConvSysGroup")
                    Call FormReSize()
                ElseIf varSite(intCurrentSys, intCurrentGroup, 0, 5) = "2" Then
                    ViewMode("GroupTrunk")
                    Call FormReSize()
                ElseIf varSite(intCurrentSys, Val(VB.Right(strKey, 4)), 0, 5) = "3" Then
                    ViewMode("TrunkSiteSetup")
                End If
            Else 'something weird and unexpected, turn all views off
                ViewMode("OFF")
                If blnDebug Then
                    Console.WriteLine("frmSystemEdtitor-UpdateViewMode-Unknown view mode key " & strKey)
                End If
            End If
        Catch ex As Exception
            If blnDebug Then
                MsgBox("Exception in UpdateViewMode:" & ex.Message)
            End If
        End Try


    End Sub

    Function GetSysType(ByRef SysNum As String) As String
        'receives Sxxxx in and spits out system type back

        If Val(varSite(CInt(VB.Right(SysNum, 4)), 0, 0, 3)) = 1 Then

            GetSysType = "CNV"
        Else

            GetSysType = "Trunk"
        End If
    End Function




    Sub CreateNewSite()
        'creates a new trunk site within a system
        'make sure its a trunk system to begin with
        Dim intTotSites, intParam, cnt, intGroup As Integer
        Dim blnBad As Boolean, Response As Integer
        If Val(varSite(intCurrentSys, 0, 0, 3)) = 1 Or Val(varSite(intCurrentSys, 0, 0, 3)) = 0 Then
            MsgBox("You need to select a trunk system to add an additional site.")
            Exit Sub
        End If
        'find a spot in memory for the new group
        For cnt = 1 To MaxGroups
            If varSite(intCurrentSys, cnt, 0, 10) = "" Then
                intGroup = cnt
                cnt = MaxGroups
            End If
            If Val(varSite(intCurrentSys, cnt, 0, 5)) = 3 Then intTotSites = intTotSites + 1
        Next cnt

        If intGroup = 0 Or intTotSites = 256 Then
            MsgBox("You have reached the maximum number of sites that can be created in this system.")
            Exit Sub
        End If
        If varSite(intCurrentSys, 0, 0, 3) = "6" And Not blnSkipGroup Then 'ltr system, maximum 1 group 
            If intGroup = 1 Then
                'this is the first addition to this system, which is OK
            ElseIf intGroup = 2 Then  'the second addition, it can be either a group or site but not both
                If CDbl(varSite(intCurrentSys, 1, 0, 5)) <> 2 And Not blnSkipGroup Then
                    DispStat("LTR systems can have a maximum of one site per system on non-XT scanners.")
                    'blnBad = True
                End If
            End If
        End If

        'edacs scat also one site per system and no groups
        If varSite(intCurrentSys, 0, 0, 3) = "5" And blnSkipGroup = False Then 'edacs scat

            If intGroup <> 1 Then
                MsgBox("EDACS SCAT systems can only support one site per system and cannot support groups.")
                blnBad = True
            End If
        End If

        If blnBad = True Then

            intGroup = 0
            DrawSystemTree()
            Exit Sub
        End If
        'maximum 256 sites per system

        If intTotSites = 256 Then

            Response = MsgBox("This scanner supports a maximum of 256 sites per system.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End If
        'now begin applying settings
        varSite(intCurrentSys, 0, 0, 10) = CStr(Val(varSite(intCurrentSys, 0, 0, 10)) + 1)
        varSite(intCurrentSys, intGroup, 0, 1) = "Site " & intTotSites + 1
        varSite(intCurrentSys, intGroup, 0, 2) = "." 'quickkey
        varSite(intCurrentSys, intGroup, 0, 3) = CStr(0) 'LO
        varSite(intCurrentSys, intGroup, 0, 4) = CStr(0) 'Hold Time
        varSite(intCurrentSys, intGroup, 0, 5) = "3" 'group type
        varSite(intCurrentSys, intGroup, 0, 6) = "AUTO" 'modulation
        varSite(intCurrentSys, intGroup, 0, 7) = CStr(0) 'att
        varSite(intCurrentSys, intGroup, 0, 8) = CStr(1) 'C-ch only
        varSite(intCurrentSys, intGroup, 0, 13) = DefaultLat 'Default latitude
        varSite(intCurrentSys, intGroup, 0, 14) = DefaultLong 'Default longtitude
        varSite(intCurrentSys, intGroup, 0, 32) = "0" 'state, set to off
        varSite(intCurrentSys, intGroup, 0, 62) = "@0@0@5000@0@0@0@5000@0@0@0@5000@0@0@0@5000@0@0@0@5000@0@0@0@5000@0" 'state, set to off
        'site type - this will have to get worked out
        'site type
        Select Case Val(varSite(intCurrentSys, 0, 0, 3))
            Case 2
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(7)
            Case 3
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(1)
            Case 4
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(9)
            Case 5
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(11)
            Case 6
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(12)
            Case 7
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(14)
            Case 8
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(15)
        End Select

        'varSite(intCurrentSys, intGroup, 0, 9) = 1 'fleet map, for mot type I systems only
        varSite(intCurrentSys, intGroup, 0, 10) = CreateGroupID()
        varSite(intCurrentSys, intGroup, 0, 26) = APCOMode
        varSite(intCurrentSys, intGroup, 0, 27) = APCOThreshold
        varSite(intCurrentSys, intGroup, 0, 12) = "."
        For intParam = 17 To 25
            varSite(intCurrentSys, intGroup, 0, intParam) = CStr(0) 'mot frequencies
        Next intParam

        intCurrentGroup = intGroup
        If blnSkipGroup = False Then
            DrawSystemTree()
            UpdateViewMode()
        End If
        'create a default group
        'MakeNewGroup

    End Sub
    Sub CreateGenericSite()
        'find a spot in memory for the new group
        'This is used for internal functions such as RR import which
        'may need to create sites
        Dim intTotSites, intGroup, cnt, intParam As Integer
        For cnt = 1 To MaxGroups
            If varSite(intCurrentSys, cnt, 0, 10) = "" Then
                intGroup = cnt
                cnt = MaxGroups
            End If
            If Val(varSite(intCurrentSys, intGroup, 0, 5)) = 3 Then intTotSites += 1
        Next cnt
        varSite(intCurrentSys, 0, 0, 10) = CStr(Val(varSite(intCurrentSys, 0, 0, 10)) + 1)
        varSite(intCurrentSys, intGroup, 0, 1) = "Site " & intTotSites + 1
        varSite(intCurrentSys, intGroup, 0, 2) = "." 'quickkey
        varSite(intCurrentSys, intGroup, 0, 3) = CStr(0) 'LO
        varSite(intCurrentSys, intGroup, 0, 4) = CStr(0) 'Hold Time
        varSite(intCurrentSys, intGroup, 0, 5) = CStr(3) 'group type
        varSite(intCurrentSys, intGroup, 0, 6) = "AUTO" 'modmode
        varSite(intCurrentSys, intGroup, 0, 7) = CStr(0) 'att
        varSite(intCurrentSys, intGroup, 0, 8) = CStr(0) 'C-ch only
        varSite(intCurrentSys, intGroup, 0, 13) = DefaultLat 'Default latitude
        varSite(intCurrentSys, intGroup, 0, 14) = DefaultLong 'Default longtitude
        'site type - this will have to get worked out
        'site type
        Select Case Val(varSite(intCurrentSys, 0, 0, 3))

            Case 2
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(7)
            Case 3
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(1)
            Case 4
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(9)
            Case 5
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(11)
            Case 6
                varSite(intCurrentSys, intGroup, 0, 9) = CStr(12)
        End Select


        varSite(intCurrentSys, intGroup, 0, 10) = CreateGroupID()

        varSite(intCurrentSys, intGroup, 0, 12) = "."
        varSite(intCurrentSys, intGroup, 0, 26) = APCOMode
        varSite(intCurrentSys, intGroup, 0, 27) = APCOThreshold
        varSite(intCurrentSys, intGroup, 0, 32) = "0" 'state, set to off
        For intParam = 17 To 25
            varSite(intCurrentSys, intGroup, 0, intParam) = CStr(0) 'mot frequencies
        Next intParam
        intCurrentGroup = intGroup
    End Sub
    Public Sub mnuCutChannel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCutChannel.Click
        'CUTS CHANNELS
        Dim intNukeIndex(MaxChanCopy) As Integer
        Dim intNumRows As Integer, blnSaver As Boolean
        blnSuccess = False
        blnSaver = WarnDelete
        WarnDelete = False
        mnuCopyChannel_Click(mnuCopyChannel, New System.EventArgs()) 'copy them to buffer
        Dim strTrn(MaxTrunkFreq + 1, 2) As String
        If intCurrentSys <> 0 And intCurrentGroup = 0 Then 'cut a system
            Call mnuDeleteSystem_Click(mnuDeleteSystem, New System.EventArgs())
        ElseIf intCurrentSys <> 0 And intCurrentGroup <> 0 And treeSystems.Focused Then  'cut a group/site/whatever
            Call mnuDeleteSystem_Click(mnuDeleteSystem, New System.EventArgs())
        ElseIf Not treeSystems.Focused Then
            If blnSuccess = True Then 'did it work?
                'wipe out channels selected
                If frmGroupConv.Visible Then
                    'copy conv channel
                    BuildGridArray()
                    If IsArray(intGridSel) = False Then
                        WarnDelete = blnSaver
                        Exit Sub
                    End If
                    intNumRows = UBound(intGridSel) + 1
                    Call cmdDeleteConvChan_Click(mnuDeleteSystem, New System.EventArgs())

                    DispStat(intNumRows & " channel(s) cut to buffer.")
                    intCurrentChannel = 1
                    LoadConvChanGrid()

                ElseIf frmGroupTrunk.Visible = True Then
                    'copy trunked channels
                    'copy conv channel
                    BuildGridArray()
                    If IsArray(intGridSel) = False Then
                        WarnDelete = blnSaver
                        Exit Sub
                    End If
                    intNumRows = UBound(intGridSel) + 1
                    Call cmdDelTGID_Click(mnuDeleteSystem, New System.EventArgs())
                    DispStat(intNumRows & " channel(s) cut to buffer.")
                    intCurrentChannel = 1
                    LoadTrunkChanGrid()
                ElseIf grdTrunkFreq.Visible = True Then
                    'delete all selected rows
                    Call cmdDeleteTrunkFreq_Click(Nothing, Nothing)
                    DispStat(UBound(intGridSel) + 1 & " channel(s) cut to buffer.")
                End If 'type of action requested
            End If 'boolean success

        End If
        WarnDelete = blnSaver
    End Sub

    Sub mnuDeleteGroup_Click()
        If blnDebug = False Then On Error Resume Next
        Dim y As Integer, strGID As String, Response As Integer, strName As String
        Dim intParam As Integer
        If intCurrentGroup = 0 Or intCurrentSys = 0 Then
            MsgBox("Please select the group you wish to delete.")
            Exit Sub
        End If


        Response = MsgBox("Are you sure you want to delete the group/site " & varSite(intCurrentSys, intCurrentGroup, 0, 1), MsgBoxStyle.YesNo, "Confirm Delete")
        'yes is 6 no is 7

        If Response = 7 Then 'dont delete
            Exit Sub
        Else 'delete
            strName = varSite(intCurrentSys, intCurrentGroup, 0, 1)
            'save the group id
            strGID = varSite(intCurrentSys, intCurrentGroup, 0, 10)
            'delete all related channels
            If CDbl(varSite(intCurrentSys, intCurrentGroup, 0, 5)) < 3 Then
                For y = 1 To MaxChan
                    If ChanInfo(y, 10) = strGID Then
                        For intParam = 0 To MaxChanSetting
                            ChanInfo(y, intParam) = ""
                        Next intParam
                    End If
                Next y
            End If
            'delete any trunking frequencies, if applicable
            If CDbl(varSite(intCurrentSys, intCurrentGroup, 0, 5)) = 3 Then
                For y = 1 To MaxTrunkFreq
                    If strTrunkFreq(y, 2) = strGID Then
                        strTrunkFreq(y, 0) = ""
                        strTrunkFreq(y, 1) = ""
                        strTrunkFreq(y, 2) = ""
                    End If
                Next y
            End If
            'decimate the group
            For y = 0 To MaxSetting
                varSite(intCurrentSys, intCurrentGroup, 0, y) = ""
            Next y

            DispStat(strName & " has been decimated.")

        End If
        intCurrentGroup = 0
        DrawSystemTree()
        UpdateViewMode()
        MarkChange()
    End Sub

    Public Sub mnuDeleteSystem_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDeleteSystem.Click
        Dim y, intSetting, intGroup, x, intParam, Response As Integer
        Dim strGID As String
        Dim strName As String
        'wipe out  system from memory
        If intCurrentSys = 0 Then
            MsgBox("Please click on the object you wish to delete.")
            Exit Sub
        End If
        If intCurrentSys <> 0 And intCurrentGroup = 0 Then
            If WarnDelete Then
                Response = MsgBox("Are you sure you want to delete the system " & varSite(intCurrentSys, 0, 0, 1), MsgBoxStyle.YesNo, "Confirm Delete")
            Else
                Response = 6
            End If
            'yes is 6 no is 7

            If Response = 7 Then 'dont delete
                Exit Sub
            Else 'delete
                'wipe all system information
                For x = 0 To MaxSetting

                    varSite(intCurrentSys, 0, 0, x) = ""
                Next x
                'wipe all group information
                For intGroup = 0 To MaxGroups

                    If varSite(intCurrentSys, intGroup, 0, 10) <> "" Then
                        'its a real group, wipe out any associated channels
                        strGID = varSite(intCurrentSys, intGroup, 0, 10)
                        For y = 1 To MaxChan
                            If ChanInfo(y, 10) = strGID Then
                                For intParam = 0 To 30
                                    ChanInfo(y, intParam) = ""
                                Next intParam
                            End If
                        Next y

                        If varSite(intCurrentSys, intGroup, 0, 5) = "3" Then ' a trunked site
                            'wipe out any associated trunking frequencies
                            For y = 1 To MaxTrunkFreq
                                If strTrunkFreq(y, 2) = strGID Then
                                    strTrunkFreq(y, 0) = ""
                                    strTrunkFreq(y, 1) = ""
                                    strTrunkFreq(y, 2) = ""
                                End If
                            Next y
                        End If 'trunked site
                    End If 'is this site/group valid?
                    For intSetting = 0 To MaxSetting


                        varSite(intCurrentSys, intGroup, 0, intSetting) = ""
                    Next intSetting
                Next intGroup
                'need to move to a different site after this one has been desicated
                intCurrentSys = 0
                UpdateViewMode()
            End If
        ElseIf intCurrentSys <> 0 And intCurrentGroup <> 0 Then  'Delete a group
            If WarnDelete Then
                Response = MsgBox("Are you sure you want to delete the group/site " & varSite(intCurrentSys, intCurrentGroup, 0, 1), MsgBoxStyle.YesNo, "Confirm Delete")
            Else
                Response = 6
            End If
            'yes is 6 no is 7

            If Response = 7 Then 'dont delete
                Exit Sub
            Else 'delete
                strName = varSite(intCurrentSys, intCurrentGroup, 0, 1)
                'save the group id
                strGID = varSite(intCurrentSys, intCurrentGroup, 0, 10)
                'delete all related channels
                If CDbl(varSite(intCurrentSys, intCurrentGroup, 0, 5)) < 3 Then
                    For y = 1 To MaxChan
                        If ChanInfo(y, 10) = strGID Then
                            For intParam = 0 To MaxChanSetting
                                ChanInfo(y, intParam) = ""
                            Next intParam
                        End If
                    Next y
                End If
                'delete any trunking frequencies, if applicable
                If CDbl(varSite(intCurrentSys, intCurrentGroup, 0, 5)) = 3 Then
                    For y = 1 To MaxTrunkFreq
                        If strTrunkFreq(y, 2) = strGID Then
                            strTrunkFreq(y, 0) = ""
                            strTrunkFreq(y, 1) = ""
                            strTrunkFreq(y, 2) = ""
                        End If
                    Next y
                End If
                'decimate the group
                For y = 0 To MaxSetting
                    varSite(intCurrentSys, intCurrentGroup, 0, y) = ""
                Next y
                intCurrentGroup = 0
                DispStat(strName & " has been decimated.")
                UpdateTreeSelection()
                UpdateViewMode()
            End If
        End If


        If Not blnSkipRedraw Then DrawSystemTree()
        'blnNoWarn = False
        MarkChange()
    End Sub

    Public Sub mnuEditFreqFill_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditFreqFill.Click
        Me.Enabled = False
        frmFill.Visible = True
        frmFill.Activate()
    End Sub

    Public Sub mnuEditJustChan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditJustChan.Click
        Me.Enabled = False
        frmJust.Visible = True
        frmJust.Activate()
    End Sub

    Public Sub mnuEditSysQK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditSysQK.Click
        frmSysQK.initForm()
        frmSysQK.Visible = True
        frmSysQK.Activate()
    End Sub

    Public Sub mnuExitSaveChanges_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExitSaveChanges.Click
        Dim Response As Integer
        intCancel = 0
        If Not blnChgSaved Then
            'warn user changes are going to be lost
            Response = MsgBox("Do you wish to save changes to " & strCurrFile, MsgBoxStyle.YesNoCancel, "Save changes?")
            Select Case Response
                Case 6 'save changes
                    Call mnuFileSave_Click(mnuFileSave, New System.EventArgs())
                    End
                Case 7 ' dont save
                    End
                Case 2 'cancel action
                    intCancel = 1
                    Exit Sub
            End Select
        Else
            End
        End If
    End Sub

    Public Sub mnuExportAllSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExportAllSys.Click
        'exports the currently selected system as a CSV file
        If blnDebug = False Then On Error Resume Next

        Dim intSys, intCnt, intFileNum, intSysCnt As Integer
        Dim strBuff As String

        'open the file

        intFileNum = csvFileChooser(strCurrFile & ".csv")
        If intFileNum = -1 Then
            Exit Sub
        End If
        PrintLine(intFileNum, "Name,Freq/ID,Lockout,Tone/NAC,Modulation,Comment,Group,System")
        For intSys = 1 To MaxSystems
            If varSite(intSys, 0, 0, 3) <> "" Then

                strBuff = GenCSV(intSys)
                PrintLine(intFileNum, strBuff)
                intSysCnt = intSysCnt + 1
            End If
            Call FormWait(intSys, MaxSystems, 1)
        Next intSys
        FileClose(intFileNum)
        Call FormWait(0, 0, 0)
        DispStat(intSysCnt & " systems have been exported.")
    End Sub
    Function GenCSV(ByRef intSys As Integer) As String
        'takes the system # given and generates a CSV export of it
        Dim strLine As String
        Dim strCR, C As String
        Dim intChan, intGrp As Integer
        Dim Tone As String
        strCR = Chr(13)
        C = ","
        GenCSV = Nothing
        If intSys = 0 Then
            Exit Function
        End If
        strLine = Nothing
        If varSite(intSys, 0, 0, 3) = "1" Then 'conventional system
            'print headings
            strLine &= "Quick Key:" & C & varSite(intSys, 0, 0, 4) & strCR
            strLine &= "Startup Key:" & C & varSite(intSys, 0, 0, 7) & strCR
            strLine &= "Latitude:" & C & varSite(intSys, 0, 0, 19) & strCR
            strLine &= "Longtitude:" & C & varSite(intSys, 0, 0, 20) & strCR
            strLine &= "RR D/L Time:" & C & varSite(intSys, 0, 0, 55) & strCR
            strLine &= "Range (Miles):" & C & varSite(intSys, 0, 0, 21) & strCR & strCR
            'now search the system for every channel present
            For intGrp = 1 To MaxGroups
                If varSite(intSys, intGrp, 0, 10) <> "" Then 'valid group, export channels
                    strLine &= "Quick Key:" & C & varSite(intSys, intGrp, 0, 2) & strCR
                    strLine &= "Latitude:" & C & varSite(intSys, intGrp, 0, 6) & strCR
                    strLine &= "Longtitude:" & C & varSite(intSys, intGrp, 0, 7) & strCR
                    strLine &= "Range (Miles):" & C & varSite(intSys, intGrp, 0, 8) & strCR & strCR
                    For intChan = 1 To MaxChan
                        If ChanInfo(intChan, 10) = varSite(intSys, intGrp, 0, 10) Then 'export this channel
                            If ChanInfo(intChan, 12) = "2" And ChanInfo(intChan, 15) <> Nothing Then
                                Tone = ChanInfo(intChan, 15)
                            Else
                                Tone = CTCSS(Val(ChanInfo(intChan, 9)))
                            End If
                            strLine &= ChanInfo(intChan, 1) & C & FormatFreq(CDbl(ChanInfo(intChan, 2))) & C & MakeOnOff(ChanInfo(intChan, 5)) & C
                            strLine &= Tone & C & ModMode(Val(ChanInfo(intChan, 4))) & C & ChanInfo(intChan, 14) & C
                            'NAc status, nuymber tag, alert lights, alert pattern
                            strLine &= ChanInfo(intChan, 15) & C & ChanInfo(intChan, 16) & C & ChanInfo(intChan, 17) & C & ChanInfo(intChan, 1) & C
                            strLine &= varSite(intSys, intGrp, 0, 1) & C & varSite(intSys, 0, 0, 1) & strCR

                        End If
                    Next intChan
                End If
            Next intGrp

        ElseIf Val(varSite(intSys, 0, 0, 3)) <> 0 Then  'export trunked sys
            'strbuff = strbuff & "Name,TGID,Lockout,,,Comment,Group" & strCR
            'now search the system for every channel present
            For intGrp = 1 To MaxGroups


                If varSite(intSys, intGrp, 0, 5) = "2" Then 'valid tgid group, export channels
                    strLine &= "Quick Key:" & C & varSite(intSys, intGrp, 0, 2) & strCR
                    strLine &= "Latitude:" & C & varSite(intSys, intGrp, 0, 6) & strCR
                    strLine &= "Longtitude:" & C & varSite(intSys, intGrp, 0, 7) & strCR
                    strLine &= "Range (Miles):" & C & varSite(intSys, intGrp, 0, 8) & strCR & strCR
                    For intChan = 1 To MaxChan
                        If ChanInfo(intChan, 10) = varSite(intSys, intGrp, 0, 10) Then 'export this channel
                            strLine &= ChanInfo(intChan, 1) & C & ChanInfo(intChan, 2) & C & MakeOnOff(ChanInfo(intChan, 3)) & ChanInfo(intChan, 19) & ChanInfo(intChan, 20) & ChanInfo(intChan, 21) & C & ChanInfo(intChan, 22) & C & C
                            strLine &= ChanInfo(intChan, 14) & C
                            strLine &= varSite(intSys, intGrp, 0, 1) & C & varSite(intSys, 0, 0, 1) & strCR

                        End If
                    Next intChan
                ElseIf varSite(intSys, intGrp, 0, 5) = "3" Then 'site information
                    strLine &= "Quick Key:" & C & varSite(intSys, intGrp, 0, 2) & strCR
                    strLine &= "Latitude:" & C & varSite(intSys, intGrp, 0, 13) & strCR
                    strLine &= "Longtitude:" & C & varSite(intSys, intGrp, 0, 14) & strCR
                    strLine &= "Range (Miles):" & C & varSite(intSys, intGrp, 0, 15) & strCR & strCR
                    For intChan = 1 To MaxTrunkFreq
                        If strTrunkFreq(intChan, 2) = varSite(intSys, intGrp, 0, 10) Then 'export this channel
                            strLine &= strTrunkFreq(intChan, 0) & C & strTrunkFreq(intChan, 1) & C & strTrunkFreq(intChan, 4) & strCR
                        End If
                    Next intChan
                End If
            Next intGrp
        End If

        GenCSV = strLine
    End Function

    Function csvFileChooser(ByRef strFName As String) As Integer
        'opens a dialog box for exporting a CSV file and returns the file number
        Dim strFilename As String
        Dim Response, intFileNum As Integer
        On Error GoTo criticerror
        strFilename = Nothing
        csvFileChooser = -1
        'UPGRADE_WARNING: CommonDlg variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        With ExportFileDlg
            .Filter = "CSV File (*.csv)|*.csv| All Files (*.*)|*.*"
            .DefaultExt = "CSV"
            .FilterIndex = 0
            .Title = "Save As..."
            .FileName = strFName
            blnUserCancel = True
            .ShowDialog()
            strFilename = .FileName
        End With

        If strFilename = "" Or strFilename = "*.CSV" Then Exit Function
        If blnUserCancel = True Then
            csvFileChooser = -1
            Exit Function
        End If
        intFileNum = FreeFile()
        FileOpen(intFileNum, strFilename, OpenMode.Output)

        csvFileChooser = intFileNum
        Exit Function
criticerror:
        If Err.Number = 70 Then
            MsgBox("This file is presentley in use or access is denied. Correct and try again.")
        ElseIf Err.Number <> 32755 Then
            MsgBox("Unknown error. Code " & Err.Number)
        End If

    End Function
    Public Sub mnuExportSngSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExportSngSys.Click
        'exports the currently selected system as a CSV file
        If blnDebug = False Then On Error Resume Next
        Dim intCnt, intFileNum As Integer
        Dim strBuff As String

        If intCurrentSys = 0 Then
            intCnt = MsgBox("Please select the system you would like to export.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'open the file

        intFileNum = csvFileChooser(varSite(intCurrentSys, 0, 0, 1))
        If intFileNum = -1 Then
            Exit Sub
        End If

        strBuff = GenCSV(intCurrentSys)
        PrintLine(intFileNum, "Name,Freq/ID,Lockout,Tone,Modulation,Comment,Group,System")
        PrintLine(intFileNum, strBuff)
        FileClose(intFileNum)
        DispStat("System " & varSite(intCurrentSys, 0, 0, 1) & " export complete")
    End Sub

    Public Sub mnuFavAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFavAdd.Click
        'Add the currently select system/site/group to favourites
        Dim intCnt, intFavNum As Integer
        Dim strBuff As String
        'check there is space in memory
        For intCnt = 1 To MaxFavs

            If strFavs(intCnt, 1) = "" Then 'found an empty spot
                intFavNum = intCnt
                intCnt = MaxFavs
            End If
        Next intCnt
        If intFavNum = 0 Then 'if nothing could be found
            intCnt = MsgBox("Sorry, but you can only have up to " & MaxFavs & " favourites.", MsgBoxStyle.Critical, "Cannot add")
            Exit Sub
        End If
        'Determine what we are saving
        If intCurrentSys = 0 Then 'Nothing selected to add
            intCnt = MsgBox("Please select the system, site, or group you would like to add to favourites.", MsgBoxStyle.Critical, "Cannot add")
            Exit Sub
        End If
        If intCurrentSys <> 0 And intCurrentGroup = 0 Then ' Add a system

            strFavs(intFavNum, 1) = varSite(intCurrentSys, 0, 0, 23) 'add group id

            strFavs(intFavNum, 2) = "" 'No image ID by default
            strBuff = "[SYS]     "
            strBuff = strBuff & varSite(intCurrentSys, 0, 0, 1)

            strFavs(intFavNum, 3) = strBuff ' Name

            strFavs(intFavNum, 4) = "0" 'Type = System
        End If
        If intCurrentSys <> 0 And intCurrentGroup <> 0 Then 'Add a site or group

            strFavs(intFavNum, 1) = varSite(intCurrentSys, intCurrentGroup, 0, 10) 'add group id

            strFavs(intFavNum, 2) = "" 'No image ID by default

            If varSite(intCurrentSys, intCurrentGroup, 0, 5) = "3" Then ' a site
                strBuff = "[SITE]    "
            Else
                strBuff = "[GRP]     "
            End If
            strBuff = strBuff & varSite(intCurrentSys, intCurrentGroup, 0, 1)

            strFavs(intFavNum, 3) = strBuff 'Name

            strFavs(intFavNum, 4) = "1" 'Type = Group/Site    End If
        End If
        DrawFavMenu()
    End Sub
    Sub DrawFavMenu()
        'redraws favourites menu
        If blnDebug = False Then On Error Resume Next
        Dim intCnt, intNumMenu As Integer
        intNumMenu = mnuFavArray.Count - 1
        'If there are any existing controls, destroy them
        If intNumMenu <> 0 Then
            For intCnt = 1 To intNumMenu
                mnuFavArray.Unload(intCnt)
            Next intCnt
        End If
        intNumMenu = 0

        'Next, go through the entire memory array and add everything to the menu
        For intCnt = 1 To MaxFavs
            If Len(strFavs(intCnt, 1)) > 2 Then
                intNumMenu = intNumMenu + 1
                mnuFavArray.Load(intNumMenu)
                With mnuFavArray(intNumMenu)

                    .Text = strFavs(intCnt, 3)
                    .Visible = True
                End With

                strFavs(intCnt, 5) = intNumMenu
            End If
        Next intCnt
    End Sub

    Public Sub mnuFavArray_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFavArray.Click
        Dim index As Short = mnuFavArray.GetIndex(eventSender)
        'Recall the associated system/group of this site
        Dim intGroup, intSite, intCnt As Integer
        Dim intFavID, intGroupCnt As Integer
        'First, look up and check which favourite this is
        For intCnt = 1 To MaxFavs

            If strFavs(intCnt, 5) = Val(CStr(index)) Then
                intFavID = intCnt
                intCnt = MaxFavs
            End If
        Next intCnt
        'find out if we are looking for a system or group

        If strFavs(intFavID, 4) = "0" Then 'search for a site of this ID
            For intCnt = 1 To MaxSystems

                If varSite(intCnt, 0, 0, 23) = strFavs(intFavID, 1) Then ' found a ID match between the shortcut and owner
                    intSite = intCnt
                    intCnt = MaxSystems
                End If
            Next intCnt
            intCurrentSys = intSite
            intCurrentGroup = 0
            If intCurrentSys = 0 Then
                intCnt = MsgBox("This system no longer exists.", MsgBoxStyle.Exclamation, "Can't find")
            End If
        Else 'search for a group with this ID
            For intCnt = 1 To MaxSystems
                For intGroupCnt = 1 To MaxGroups

                    If varSite(intCnt, intGroupCnt, 0, 10) = strFavs(intFavID, 1) Then
                        intSite = intCnt
                        intGroup = intGroupCnt
                        intCnt = MaxSystems
                        intGroupCnt = MaxGroups
                    End If
                Next intGroupCnt
            Next intCnt
            intCurrentSys = intSite
            intCurrentGroup = intGroup
            If intCurrentGroup = 0 Then
                intCnt = MsgBox("This group or site no longer exists.", MsgBoxStyle.Exclamation, "Can't find")
            End If
        End If

        'Now set the display mode to the object
        intCurrentChannel = 0
        UpdateTreeSelection()
        UpdateViewMode()

    End Sub

    Public Sub mnuFavOrg_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFavOrg.Click
        Me.Enabled = False
        Exit Sub
        If frmDupeN_N.Visible = True Then frmDupeN_N.Visible = False
        frmFav.initForm()
        frmFav.Visible = True
        frmFav.Activate()
    End Sub

    Public Sub mnuFileNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileNew.Click
        Dim Response As Integer
        'this needs some work
        If blnChgSaved = True Then
            'Create a brand new configuration
            MakeBrandNewConfig()

        Else
            If Not blnChgSaved Then
                'warn user changes are going to be lost
                Response = MsgBox("Do you wish to save changes to " & strCurrFile, MsgBoxStyle.YesNoCancel, "Save changes?")
                Select Case Response
                    Case 6 'save changes
                        Call mnuFileSave_Click(mnuFileSave, New System.EventArgs())
                        MakeBrandNewConfig()
                    Case 7 ' dont save
                        MakeBrandNewConfig()
                    Case 2 'cancel action
                        Exit Sub
                End Select
            Else
                MakeBrandNewConfig()
            End If
        End If
    End Sub

    Public Sub mnuFileOpen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileOpen.Click
        Dim Response As Integer
        blnLoadCmdLine = False
        If Not blnChgSaved Then
            'warn user changes are going to be lost
            Response = MsgBox("Do you wish to save changes to " & strCurrFile, MsgBoxStyle.YesNoCancel, "Save changes?")
            Select Case Response
                Case 6 'save changes
                    Call mnuFileSave_Click(mnuFileSave, New System.EventArgs())
                    Call LoadSystem("")
                Case 7 ' dont save
                    Call LoadSystem("")
                Case 2 'cancel action
                    Exit Sub
            End Select
        Else
            Call LoadSystem("")
        End If
        DrawSystemTree()
    End Sub

    Public Sub mnuFilePrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFilePrint.Click
        Me.Visible = False
        If frmDupeN_N.Visible = True Then frmDupeN_N.Visible = False
        frmPrintSetup.UpdateList()
        frmPrintSetup.cmdCheckAll_click(Nothing, Nothing)

        frmPrintSetup.Visible = True
    End Sub

    Public Sub mnuFileSaveas_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileSaveAs.Click
        If blnDebug = False Then On Error Resume Next
        Dim ChanNum, intTotalTrunkFreq, intNumSites, intCurrSite, intNumChan As Integer
        Dim blnFileOpen As Boolean
        Dim strFilename As String
        Dim x, Response, y As Integer
        Dim intParam, GroupNum, intNumGroups, z, cnt As Integer

        strFilename = Nothing

        'saves everything from memory to disk
        'first confirm there is something loaded

        'bring up save as dialog box
        'UPGRADE_WARNING: CommonDlg variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        With ProfileFileSaveDlg
            'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            .DefaultExt = "996"
            .Filter = "FreeSCAN (*.996)|*.996| All Files (*.*)|*.*"
            .FilterIndex = 0
            .FileName = strCurrFile
            .Title = "Save As..."
            .ShowDialog()
        End With

    End Sub
    Sub SaveMyFile(ByRef strFilename As String)
        If blnDebug = False Then On Error GoTo criticerror
        Dim ChanNum, intTotalTrunkFreq, intNumSites, intCurrSite, intNumChan As Integer
        Dim x, Response, y As Integer
        Dim intParam, GroupNum, intNumGroups, z, cnt As Integer
        Dim sFileContents As String
        If blnDebug Then
            Console.WriteLine("SaveMyFile: File ended at ")
            Console.WriteLine(DateTime.Now.Second)
        End If
 
        SetFormCaption()
        ArrangeFileList((strFilename))

        'version info
        Call FormWait(0, 100, 1)
        '  WriteLine(1, strCurrVer)
        '   sFileContents = strCurrVer )
        AppendData(strCurrVer, True)
        'radio settings
        For x = 1 To MaxRadioSetting
            '  WriteLine(1, NoNull(RadioSetting(x)))
            AppendData(NoNull(RadioSetting(x)))
        Next x
        'Dump Custom search setting

        For x = 1 To 10
            For y = 0 To 16
                'WriteLine(1, NoNull(CustSearch(x, y)))
                AppendData(NoNull(CustSearch(x, y)))
            Next y
        Next x
        'write site information
        'find out how many sites there are
        For x = 1 To MaxSystems
            If Val(varSite(x, 0, 0, 3)) > 0 Then 'this is a valid site, count  it
                intNumSites = intNumSites + 1

            End If
        Next x
        ' WriteLine(1, intNumSites)
        AppendData(Str(intNumSites), , , True)
        For intCurrSite = 1 To MaxSystems
            '******* TOP LEVEL,  SITE LEVEL LOOP
            Call FormWait(intCurrSite, MaxSystems + 10, 1)
            If Val(varSite(intCurrSite, 0, 0, 3)) > 0 Then 'this is a valid site, write it
                intNumGroups = 0
                intNumChan = 0
                For y = 1 To MaxSetting
                    ' WriteLine(1, NoNull(varSite(intCurrSite, 0, 0, y)))
                    AppendData(varSite(intCurrSite, 0, 0, y))
                Next y

                For GroupNum = 1 To MaxGroups
                    If Val(varSite(intCurrSite, GroupNum, 0, 5)) > 0 Then
                        intNumGroups = intNumGroups + 1
                    End If
                Next GroupNum
                '  WriteLine(1, intNumGroups) 'write number of groups to follow
                AppendData(Str(intNumGroups), , , True)
                '********** SECOND LEVEL, GROUP/SITE LEVEL
                For GroupNum = 1 To MaxGroups
                    If Val(varSite(intCurrSite, GroupNum, 0, 5)) > 0 Then 'is this a valid group?
                        'write group setting, x40
                        For z = 1 To MaxSetting
                            '   WriteLine(1, NoNull(varSite(intCurrSite, GroupNum, 0, z)))
                            AppendData(varSite(intCurrSite, GroupNum, 0, z))
                        Next z
                    End If
                Next GroupNum
                'finish group level

            End If
        Next intCurrSite
        'finish site level
        ' WriteLine(1, "TrunkSection")
        AppendData("TrunkSection")
        'write trunk frequencies
        'find out how many sites there are stored in there
        intNumSites = 0
        intTotalTrunkFreq = 0
        '**********************************************begin trunk loop
        For ChanNum = 1 To MaxTrunkFreq
            If strTrunkFreq(ChanNum, 2) <> "" Then
                intTotalTrunkFreq = intTotalTrunkFreq + 1
            End If
        Next ChanNum
        'write how many trunk frequencies there are

        'WriteLine(1, intTotalTrunkFreq)
        AppendData(Str(intTotalTrunkFreq), , , True)

        Dim tLockout As String = Nothing
        For ChanNum = 1 To MaxTrunkFreq
            If strTrunkFreq(ChanNum, 2) <> "" Then
                'WriteLine(1, NoNull(strTrunkFreq(ChanNum, 0))) 'frequency
                'WriteLine(1, strTrunkFreq(ChanNum, 1) & "!" & Val(strTrunkFreq(ChanNum, 3))) 'LCN & trunk lockout
                'WriteLine(1, NoNull(strTrunkFreq(ChanNum, 2))) 'group ID
                tLockout = strTrunkFreq(ChanNum, 3)
                If tLockout.Length = 0 Then
                    tLockout = "0"
                End If
                AppendData(strTrunkFreq(ChanNum, 0))
                AppendData(strTrunkFreq(ChanNum, 1) & "!" & tLockout)
                AppendData(strTrunkFreq(ChanNum, 2))
                For intParam = 3 To 10
                    ' WriteLine(1, NoNull(strTrunkFreq(ChanNum, intParam)))
                    AppendData(NoNull(strTrunkFreq(ChanNum, intParam)))
                Next intParam
            End If
        Next ChanNum
        Call FormWait(intCurrSite, MaxSystems + 5, 1)
        intNumChan = 0
        '********************************************Search frequency lockouts
        'find out how many there are
        For ChanNum = 1 To MaxSearchLockout

            If Val(strSearchLockout(ChanNum)) > 0 Then
                intNumChan = intNumChan + 1
            End If
        Next ChanNum
        ' WriteLine(1, "SEARCHLOCKOUTS")
        ' WriteLine(1, intNumChan)
        AppendData("SEARCHLOCKOUTS")
        AppendData(Str(intNumChan), , , True)
        For ChanNum = 1 To intNumChan
            ' WriteLine(1, NoNull(strSearchLockout(ChanNum)))
            AppendData(NoNull(strSearchLockout(ChanNum)))
        Next ChanNum
        intNumChan = 0
        '******************************************************CHANNEL DATA
        'WriteLine(1, "CHANDATA")
        AppendData("CHANDATA")
        For ChanNum = 1 To MaxChan
            'is this a valid channel?
            If ChanInfo(ChanNum, 10) <> "" Then intNumChan = intNumChan + 1
        Next ChanNum
        'WriteLine(1, intNumChan)
        AppendData(Str(intNumChan), , , True)
        For ChanNum = 1 To MaxChan
            'is this a valid channel?
            If ChanInfo(ChanNum, 10) <> "" Then
                For intParam = 1 To 30
                    ' WriteLine(1, NoNull(ChanInfo(ChanNum, intParam)))
                    AppendData(NoNull(ChanInfo(ChanNum, intParam)))
                Next intParam
            End If
        Next ChanNum
        Call FormWait(intCurrSite, MaxSystems + 2, 1)
        '************************************************SERVICE SEARCH SETTINGS
        'WriteLine(1, "SERVSEARCH")
        AppendData("SERVSEARCH")
        For ChanNum = 0 To 15
            For cnt = 1 To 8
                'WriteLine(1, NoNull(strSS(ChanNum, cnt)))
                AppendData(NoNull(strSS(ChanNum, cnt)))
            Next cnt
        Next ChanNum
        '******************************FAVOURITES
        '  WriteLine(1, "FAV")
        AppendData("FAV")
        ' WriteLine(1, MaxFavs)
        AppendData(Str(MaxFavs), , , True)
        For ChanNum = 1 To MaxFavs
            For intParam = 1 To 10
                '  WriteLine(1, NoNull(strFavs(ChanNum, intParam)))
                AppendData(NoNull(strFavs(ChanNum, intParam)))
            Next intParam
        Next ChanNum
        '********************************* GLOBAL IF EXCHANGE
        '   WriteLine(1, "IFEX")
        AppendData("IFEX")
        If Not IsArray(strIFEX) Then
            ' WriteLine(1, "-1")
            AppendData("-1")
        Else
            '  WriteLine(1, UBound(strIFEX))
            AppendData(Str(UBound(strIFEX)), , , True)
            For ChanNum = 0 To UBound(strIFEX)
                ' WriteLine(1, NoNull(strIFEX(ChanNum)))
                AppendData(NoNull(strIFEX(ChanNum)))
            Next
        End If
        '******************************EXTENDED SERVICE SEARCH SETTING
        ' WriteLine(1, "SSPXT")
        AppendData("SSPXT")
        For ChanNum = 0 To 15
            For x = 0 To 8
                '   WriteLine(1, NoNull(strSSXT(ChanNum, x)))
                AppendData(NoNull(strSSXT(ChanNum, x)))
            Next
        Next
        '******************************BAND PLAN SETTINGS
        '  WriteLine(1, "BANDSET")
        AppendData("BANDSET")
        For ChanNum = 0 To 1
            For x = 0 To 30
                ' WriteLine(1, NoNull(BandSet(x, ChanNum)))
                AppendData(NoNull(BandSet(x, ChanNum)))
            Next
        Next
        '******************************SYSTEM TGID LOCKOUT
        '   WriteLine(1, "GLIDFX")
        AppendData("GLIDFX")
        '  WriteLine(1, NoNull(UBound(GliDX)))
        AppendData(NoNull(UBound(GliDX)))
        For ChanNum = 0 To UBound(GliDX)

            '    WriteLine(1, NoNull(GliDX(ChanNum, 0)))
            '   WriteLine(1, NoNull(GliDX(ChanNum, 1)))
            AppendData(NoNull(GliDX(ChanNum, 0)))
            AppendData(NoNull(GliDX(ChanNum, 1)))

        Next
        'WriteLine(1, "CBPDATA")
        AppendData("CBPDATA")
        For ChanNum = 0 To 9
            '   WriteLine(1, CBPData(ChanNum))
            AppendData(CBPData(ChanNum))
        Next
        '    WriteLine(1, "123456789012345678901234567890") 'eof termination index

        Call FormWait(0, 10, 0)
        '    WriteLine(1, sFileContents)
        ' FileClose(1)
        'blnFileOpen = False
        sFileContents = AppendData("123456789012345678901234567890", False, True)
        My.Computer.FileSystem.WriteAllText(strFilename, sFileContents, False, System.Text.Encoding.ASCII)
        blnChgSaved = True
        SetFormCaption()
        If blnDebug Then
            Console.WriteLine("SaveMyFile: File ended at ")
            Console.WriteLine(DateTime.Now.Second)
        End If
        DispStat("Saved file " & strFilename)
        Exit Sub
criticerror:
        If Err.Number <> 32755 Then 'if the user didnt click cancel
            MsgBox("An error has occured while attempting to save the file. File may be corrupt. Sorry.")
        End If
        Call FormWait(0, 10, 0)

    End Sub
    Function AppendData(sData As String, Optional clearPrevious As Boolean = False, Optional returnOldData As Boolean = False, Optional treatAsInt As Boolean = False) As String
        Static sFileContents As String
        Static lineBuffer As String
        If clearPrevious Or IsNothing(sFileContents) Then
            sFileContents = ""
            lineBuffer = ""
        End If
        If treatAsInt Then
            lineBuffer += Trim(sData) + vbCrLf
        Else
            Dim sBuff As String = Chr(34) + sData + Chr(34) + vbCrLf
            lineBuffer += sBuff
            ' sFileContents = sFileContents.Insert(sFileContents.Length, Chr(34) + sData + Chr(34) + vbCrLf)
        End If
        If lineBuffer.Length > 16384 Then
            sFileContents += lineBuffer
            lineBuffer = Nothing
        End If
        If returnOldData Then
            sFileContents += lineBuffer
            lineBuffer = Nothing
            Return sFileContents
        End If
        Return Nothing
    End Function

    Function NoNull(ByVal strInp As String) As String
        'makes sure a null value isn't written to disk corrupting everything
        If strInp = Nothing Then
            strInp = ""
        End If
        NoNull = strInp
    End Function

    Public Sub mnuFind_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFind.Click
        frmFind.Visible = True


    End Sub

    Public Sub mnuFindDupGlobal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFindDupGlobal.Click
        Call FindDupe("GLOBAL", "CONV")
    End Sub
    Sub FindDupe(ByRef strMode As String, ByRef strType As String) 'strMode=Global/system, strType = CONV or TGID
        'finds duplicate frequencies/tgid
        Dim lngSys, lngCnt, lngCnt1, lngGroup As Integer
        Dim strBuff As String
        Dim j, lngNumChan, i, intParam As Integer
        Dim blnFound As Boolean
        Dim sngBuff, sngBuff1 As String
        Dim intIndexCnt, intDupes As Integer
        Dim strGroup(MaxGroups) As String
        Dim intGroupCnt, intCnt As Integer
        If blnDebug = False Then On Error Resume Next
        With frmDupeN_N
            .strMode = strMode
            .strType = strType
            .DupeGrid.Rows.Clear()
        End With
        If strMode = "GLOBAL" Then
            'count number of channels that need to be done
            For lngCnt = 1 To MaxChan
                If ChanInfo(lngCnt, 9) <> "" And strType = "CONV" Then
                    lngNumChan = lngNumChan + 1
                ElseIf ChanInfo(lngCnt, 9) = "" And ChanInfo(lngCnt, 10) <> "" And strType = "TGID" Then
                    lngNumChan = lngNumChan + 1
                End If
            Next lngCnt
            If lngNumChan < 1 Then
                MsgBox("No duplicate channels found. (Out of < 1 channels)")
                Exit Sub
            End If
            ReDim ChanShadow(lngNumChan, MaxChanSetting + 1)
            ReDim ChanDup(lngNumChan)
            'Copy all the channels we are interested in into the buffer
            intDupes = 0
            For lngCnt = 1 To MaxChan
                If strType = "TGID" Then
                    If ChanInfo(lngCnt, 9) = "" And ChanInfo(lngCnt, 10) <> "" Then
                        'Copy channel to buffer, add origanol as index
                        intDupes = intDupes + 1
                        ChanShadow(intDupes, 2) = ChanInfo(lngCnt, 2)
                        ChanShadow(intDupes, 1) = CStr(lngCnt) 'store origanol position
                        ChanShadow(intDupes, 9) = "" 'save tone
                    End If
                Else
                    If ChanInfo(lngCnt, 9) <> "" Then
                        'Copy channel to buffer, add origanol as index
                        intDupes = intDupes + 1
                        ChanShadow(intDupes, 2) = CStr(Val(ChanInfo(lngCnt, 2)))
                        ChanShadow(intDupes, 1) = CStr(lngCnt) 'store origanol position
                        ChanShadow(intDupes, 9) = ChanInfo(lngCnt, 9) 'save tone
                        ChanShadow(intDupes, 15) = ChanInfo(lngCnt, 15) 'save nac
                    End If
                End If
            Next
            intDupes = 0
        Else
            ' round up all the conventional group ids belonging to that system
            For intCnt = 1 To MaxGroups
                strBuff = varSite(intCurrentSys, intCnt, 0, 10)
                If strBuff <> "" Then
                    strGroup(intGroupCnt) = strBuff
                    intGroupCnt = intGroupCnt + 1
                End If
            Next intCnt
            lngNumChan = 0
            'now go through all those groups and check to see how many channels there are
            For intCnt = 0 To intGroupCnt - 1
                strBuff = strGroup(intCnt)
                For lngCnt = 1 To MaxChan
                    If ChanInfo(lngCnt, 10) = strBuff Then
                        lngNumChan = lngNumChan + 1
                    End If
                Next lngCnt
            Next intCnt
            'check to make sure SOMETHING was found
            If lngNumChan < 1 Then
                MsgBox("No duplicate frequencies found. (Out of < 1 channels)")
                Exit Sub
            End If
            'add found channels to the array
            ReDim ChanShadow(lngNumChan, MaxChanSetting + 1)
            ReDim ChanDup(lngNumChan)
            'Copy all the channels we are interested in into the buffer
            intDupes = 0
            For intCnt = 0 To intGroupCnt - 1
                For lngCnt = 1 To MaxChan
                    If ChanInfo(lngCnt, 10) = strGroup(intCnt) Then
                        'Copy channel to buffer, add origanol as index
                        intDupes = intDupes + 1
                        If strType = "CONV" Then
                            ChanShadow(intDupes, 2) = CStr(Val(ChanInfo(lngCnt, 2)))
                        Else
                            ChanShadow(intDupes, 2) = ChanInfo(lngCnt, 2)
                        End If
                        ChanShadow(intDupes, 1) = CStr(lngCnt) 'store origanol position
                        ChanShadow(intDupes, 9) = ChanInfo(lngCnt, 9) 'save tone
                        ChanShadow(intDupes, 15) = ChanInfo(lngCnt, 15) 'save nac
                        If ChanShadow(intDupes, 15) = "" Then ChanShadow(intDupes, 15) = Nothing
                    End If
                Next lngCnt
            Next intCnt
            intDupes = 0
        End If

        'Next, sort the array
        'sort channel by frequency/tgid, ascending
        Dim best_value(15) As String
        Dim best_j As Single
        For i = 1 To lngNumChan - 1
            best_value(1) = ChanShadow(i, 1)
            best_value(2) = ChanShadow(i, 2)
            best_value(9) = ChanShadow(i, 9)
            best_value(15) = ChanShadow(i, 15)
            best_j = i
            For j = i + 1 To lngNumChan
                If (ChanShadow(j, 2)) < (best_value(2)) Then
                    best_value(1) = ChanShadow(j, 1)
                    best_value(2) = ChanShadow(j, 2)
                    best_value(9) = ChanShadow(j, 9)
                    best_value(15) = ChanShadow(j, 15)
                    best_j = j
                End If
            Next j
            ChanShadow(best_j, 15) = ChanShadow(i, 15)
            ChanShadow(best_j, 9) = ChanShadow(i, 9)
            ChanShadow(best_j, 2) = ChanShadow(i, 2)
            ChanShadow(best_j, 1) = ChanShadow(i, 1)
            ChanShadow(i, 2) = best_value(2)
            ChanShadow(i, 1) = best_value(1)
            ChanShadow(i, 9) = best_value(9)
            ChanShadow(i, 15) = best_value(15)
        Next i

        'Finally, begin building an index of channels that are dupicated
        For lngCnt = 1 To lngNumChan - 1 'last channel will be skipped, if its a dup then too bad
            If strType = "CONV" Then
                sngBuff = CStr(Val(ChanShadow(lngCnt, 2)))
                sngBuff1 = CStr(Val(ChanShadow(lngCnt + 1, 2)))
            Else
                sngBuff = ChanShadow(lngCnt, 2)
                sngBuff1 = ChanShadow(lngCnt + 1, 2)
            End If
            If sngBuff = sngBuff1 And frmDupeN_N.chkPL.CheckState = 0 Then '
                'a duplicate frequency is found
                'add the current to the index
                intIndexCnt = intIndexCnt + 1
                ChanDup(intIndexCnt) = CInt(ChanShadow(lngCnt, 1))
                blnFound = True 'mark this as a known duplicate
                intDupes = intDupes + 1
            ElseIf sngBuff = sngBuff1 And frmDupeN_N.chkPL.CheckState = 1 And ChanShadow(lngCnt, 9) = ChanShadow(lngCnt + 1, 9) Then
                If ChanShadow(lngCnt, 15) = ChanShadow(lngCnt + 1, 15) Then
                    'a duplicate frequency and PL tone is found
                    'add the current to the index
                    intIndexCnt = intIndexCnt + 1
                    ChanDup(intIndexCnt) = CInt(ChanShadow(lngCnt, 1))
                    blnFound = True 'mark this as a known duplicate
                    intDupes = intDupes + 1
                End If
            Else
                'not a duplicate, but if the last one
                'was a duplicate then add it to the index
                If blnFound = True And lngCnt > 1 Then
                    intIndexCnt = intIndexCnt + 1
                    ChanDup(intIndexCnt) = CInt(ChanShadow(lngCnt, 1))
                    blnFound = False
                    intDupes = intDupes + 1
                End If
            End If
        Next lngCnt
        If intIndexCnt = 0 Then
            lngCnt = MsgBox("No duplicates were found. " & lngNumChan & " channels searched.", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Prepare the grid

        Dim blnFlip As Boolean
        Dim intCol As Integer
        With frmDupeN_N
            .DupeGrid.Rows.Clear()
            .DupeGrid.RowCount = intDupes

            lngSys = 0
            lngGroup = 0
            For lngCnt = 1 To intDupes
                'strbuff = ChanInfo(ChanDup(lngCnt), 10)
                'look up the system and group that this belongs to
                GetOwner((ChanDup(lngCnt)))
                .DupeGrid(0, lngCnt - 1).Value = CStr(lngCnt)
                .DupeGrid(1, lngCnt - 1).Value = ChanInfo(ChanDup(lngCnt), 1) 'name
                If strType = "CONV" Then

                    .DupeGrid(2, lngCnt - 1).Value = FormatFreq(Val(ChanInfo(ChanDup(lngCnt), 2))) 'freq
                    .DupeGrid(3, lngCnt - 1).Value = CTCSS(Val(ChanInfo(ChanDup(lngCnt), 9))) 'ctcss
                Else
                    .DupeGrid(2, lngCnt - 1).Value = ChanInfo(ChanDup(lngCnt), 2)
                End If
                .DupeGrid(4, lngCnt - 1).Value = varSite(lngChanSys, 0, 0, 1)
                .DupeGrid(5, lngCnt - 1).Value = varSite(lngChanSys, lngChanGroup, 0, 1)

                If lngCnt > 1 Then
                    If ChanInfo(ChanDup(lngCnt), 2) <> ChanInfo(ChanDup(lngCnt - 1), 2) Then
                        If blnFlip = False Then
                            blnFlip = True
                        Else
                            blnFlip = False
                        End If
                    End If
                End If

            Next lngCnt
            .Visible = True
        End With
    End Sub


    Public Sub mnuFindDupSystem_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFindDupSystem.Click
        If varSite(intCurrentSys, 0, 0, 3) = "1" Then
            Call FindDupe("SYSTEM", "CONV")
        ElseIf Val(varSite(intCurrentSys, 0, 0, 3)) > 1 Then
            Call FindDupe("SYSTEM", "TGID")
        Else
            MsgBox("Please select a valid system before continuing.")
        End If
    End Sub

    Public Sub mnuGroupHighlight_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGroupHighlight.Click
        With mnuGroupHighlight
            If .Checked = False Then
                .Checked = True
            Else
                .Checked = False
            End If
            SaveSetting("FreeSCAN", "Settings", "mnuGroupHighlight", CStr(.Checked))
        End With
        DrawSystemTree()
    End Sub



    Public Sub mnuHighlightSite_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHighlightSite.Click
        With mnuHighlightSite
            If .Checked = False Then
                .Checked = True
            Else
                .Checked = False
            End If
            SaveSetting("FreeSCAN", "Settings", "mnuHighlightSite", CStr(.Checked))
        End With
        DrawSystemTree()
    End Sub

    Public Sub mnuImportFreeSCAN_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuImportFreeSCAN.Click
        frmImport.Visible = True
        Me.Enabled = False
    End Sub

    Public Sub mnuImportRadRefConv_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuImportRadRefConv.Click
        frmRRCon.initForm()
        frmRRCon.Visible = True
        frmRRCon.Activate()
    End Sub

    Public Sub mnuImportRadRefTrunk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuImportRadRefTrunk.Click
        frmRRTrn.initForm()
        frmRRTrn.Visible = True
    End Sub

    Public Sub mnuImportUASD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuImportUASD.Click
        'Dim CreateGenericSite As Object
        'import a UASD file
        If blnDebug = False Then On Error Resume Next
        Dim intTotalTrunkFreq, ChanNum, intNumSites As Integer
        Dim NumSites As Integer
        Dim intFF, intParam, cnt As Integer
        Dim strFilename As String
        With OpenFileDialog1
            .ShowReadOnly = False
            .CheckFileExists = True
            .CheckPathExists = True
            .FileName = "*.usd"
            .Multiselect = True
            .Filter = "UASD 246/396/996/15 Files (*.usd)|*.usd| All Files (*.*)|*.*"
            .Title = "Open File"
            .FilterIndex = 0
            .ShowDialog()
            '-- Did the user select a file name?
            If .FileName = "" Then
                MsgBox("Please enter a file name")
                Exit Sub
            Else
                '-- Put some code here to save the file
                strFilename = .FileName
            End If
        End With

        If strFilename = "" Or strFilename = "*.usd" Then Exit Sub
        Call DispStat("Please wait... Importing")

        For cnt = 0 To UBound(OpenFileDialog1.FileNames)
            strFilename = OpenFileDialog1.FileNames(cnt)
            If FileExists(strFilename) Then
                Call ImoprtUASD(strFilename)
            End If

        Next
        Call DispStat("Import complete.")
        ConvLegacyBP()
        DrawSystemTree()
        UpdateViewMode()

    End Sub
    Function USDToneLookUp(ByRef strTone As String) As Integer
        'takes a USD tone and returns an index number for that tone
        'used for uasd file import
        'If blnDebug = False Then On Error Resume Next
        Dim intCode, intPos As Integer
        Dim strBuff As String
        intCode = 0

        strBuff = strTone
        If Len(strTone) > 2 Then
            If strTone = "NONE" Then
                intCode = 0
            ElseIf strTone = "SEARCH" Then
                intCode = 127
            ElseIf VB.Left(strTone, 1) = "D" Then  'perform dcs lookup
                strBuff = VB.Right(strTone, Len(strTone) - 1)
                For intPos = 127 To 231
                    If InStr(CTCSS(intPos), strBuff) > 0 Then
                        intCode = intPos
                        intPos = 231
                    End If
                Next intPos
            ElseIf VB.Left(strTone, 1) = "C" Then  'perform CTCSS lookup
                strBuff = VB.Right(strTone, Len(strTone) - 1)
                strBuff = CStr(Val(strBuff) / 10)
                For intPos = 0 To 127
                    If InStr(CTCSS(intPos), strBuff) > 0 Then
                        intCode = intPos
                        intPos = 127
                    End If
                Next intPos
            End If
        End If

        USDToneLookUp = intCode
    End Function
    Public Sub mnuLockoutAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLockoutAll.Click
        'lockout everything
        ModAllLO((1))
    End Sub

    Sub ModAllLO(ByRef intLO As Integer)
        Dim intSys, intGroup As Integer
        intSys = intCurrentSys
        If Val(varSite(intSys, 0, 0, 3)) <> 0 Then 'valid site
            If Val(varSite(intSys, 0, 0, 3)) = 1 Then 'conventional site
                varSite(intSys, 0, 0, 2) = intLO 'set lockout
            End If
            For intGroup = 1 To MaxGroups
                If Val(varSite(intSys, intGroup, 0, 5)) = 3 Then

                    varSite(intSys, intGroup, 0, 3) = intLO 'set lockout
                End If
            Next intGroup
        End If

        UpdateViewMode()
        DrawSystemTree()
    End Sub

    Public Sub mnuPasteChannel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPasteChannel.Click
        'pastes channels to buffer
        Dim blnEndChan As Boolean
        Dim intParam, intChan, intBuff As Integer
        Dim strGID As String
        Dim intCnt, intSite, intGroup As Integer
        Dim strBuff As String
        If UBound(ChanCopy) = 0 Then ReDim ChanCopy(1, 1)
        Dim intPos As Integer 'no existing sites
        Dim SiteFound As Boolean
        Dim strOldGrpID(MaxGroups) As String
        If frmGroupConv.Visible = True And ChanCopy(0, 0) = "CONV" Then
            strGID = varSite(intCurrentSys, intCurrentGroup, 0, 10)
            Do Until blnEndChan = True
                intBuff = intBuff + 1

                intChan = InsertChanTop(strGID, True)
                If intChan = -1 Then
                    MsgBox("Insufficient memory resources to create any more channels. Delete some and try again.")
                    blnEndChan = True
                Else
                    For intParam = 0 To MaxChanSetting
                        ChanInfo(intChan, intParam) = ChanCopy(intBuff, intParam)
                    Next intParam
                    ChanInfo(intChan, 10) = strGID
                    If ChanCopy(intBuff + 1, 10) = "" Then
                        blnEndChan = True
                    End If
                End If
            Loop
            LoadConvChanGrid()

            'begin past channels from buffer
            DispStat(intBuff & " channel(s) pasted from buffer.")
        ElseIf frmGroupTrunk.Visible = True And ChanCopy(0, 0) = "TGID" Then
            strGID = varSite(intCurrentSys, intCurrentGroup, 0, 10)
            intBuff = UBound(ChanCopy) - 1
            ' intLimit = CheckTGIDSpace(intCurrentSys)
            ' If intLimit < intBuff Then
            '     intBuff = MsgBox("This scanner can only contain " & MaxTgidChan & " TGIDs per system, and there is not sufficient room in this system for any more channels. Delete some and try again. No channels have been pasted.", vbExclamation)
            '     Exit Sub
            ' End If
            intBuff = 0
            Do Until blnEndChan = True
                intBuff = intBuff + 1

                intChan = InsertChanTop(strGID, False)
                If intChan = -1 Then
                    MsgBox("Insufficient memory resources to create any more channels. Delete some and try again.")
                    blnEndChan = True
                Else
                    For intParam = 0 To MaxChanSetting
                        ChanInfo(intChan, intParam) = ChanCopy(intBuff, intParam)
                    Next intParam
                    ChanInfo(intChan, 10) = strGID 'mark this channel as belonging to the current group
                    If ChanCopy(intBuff + 1, 10) = "" Then
                        blnEndChan = True
                    End If
                End If
            Loop
            LoadTrunkChanGrid()
            'begin past channels from buffer
            DispStat(intBuff & " channel(s) pasted from buffer.")
        ElseIf grdTrunkFreq.Visible = True And ChanCopy(0, 0) = "TRN" Then
            strGID = varSite(intCurrentSys, intCurrentGroup, 0, 10)
            Do Until blnEndChan = True
                intBuff = intBuff + 1
                intChan = InsertTrunkFreq(strGID)
                If intChan = -1 Then
                    MsgBox("Insufficient memory resources to create any more channels. Delete some and try again.")
                    blnEndChan = True
                Else
                    strTrunkFreq(intChan, 0) = ChanCopy(intBuff, 1) 'freq
                    strTrunkFreq(intChan, 1) = ChanCopy(intBuff, 2) 'lcn
                    strTrunkFreq(intChan, 2) = strGID
                    strTrunkFreq(intChan, 3) = ChanCopy(intBuff, 3) 'LO
                    strTrunkFreq(intChan, 4) = ChanCopy(intBuff, 4) 'num tag
                    strTrunkFreq(intChan, 5) = ChanCopy(intBuff, 5) 'vol adj
                    If ChanCopy(intBuff + 1, 1) = "" Then
                        blnEndChan = True
                    End If
                End If
            Loop
            Call LoadData("TrunkFreq")
            'begin past channels from buffer
            DispStat(intBuff & " trunk frequencies pasted from buffer.")
        ElseIf ChanCopy(0, 0) = "SYSTEM" Then  'paste a trunk system
            If Val(RadioSetting(20)) = 0 Then
                RadioSetting(20) = CStr(1)
                intCurrentSys = 1
                intSite = 1
                intCurrentGroup = 0
                intCurrentChannel = 0
            Else
                'loop through and find the first available memory spot for the site
                intSite = 1
                Do Until SiteFound = True Or intSite = MaxSystems
                    If Val(varSite(intSite, 0, 0, 3)) = 0 Then
                        SiteFound = True
                        intSite = intSite - 1
                    End If
                    intSite = intSite + 1
                Loop
                If intSite = MaxSystems Then
                    MsgBox("CRITICAL ERROR: " & MaxSystems & " system limit reached. No more systems can be created.")
                    Exit Sub
                End If
                RadioSetting(20) = CStr(Val(RadioSetting(20)) + 1)
            End If
            intCurrentSys = intSite
            intCurrentGroup = 0
            intCurrentChannel = 0
            'begin copying over all system paramaters
            For intParam = 0 To MaxSetting

                varSite(intCurrentSys, 0, 0, intParam) = strSysCopy(0, intParam)
            Next intParam
            For intSite = 1 To MaxGroups
                If Len(strSysCopy(intSite, 10)) = 16 Then ' if this is a valid site then paste it
                    For intParam = 0 To MaxSetting

                        varSite(intCurrentSys, intSite, 0, intParam) = strSysCopy(intSite, intParam)
                    Next intParam
                    'Note the OLD id and assign a new one
                    strOldGrpID(intSite) = varSite(intCurrentSys, intSite, 0, 10)

                    varSite(intCurrentSys, intSite, 0, 10) = CreateGroupID()
                    'CHANNELS
                    If intPos <> -1 Then
                        'is this a trunk site?
                        If varSite(intCurrentSys, intSite, 0, 5) = "3" Then
                            'find if there are any trunk frequencies that belong to it in memory
                            strBuff = strOldGrpID(intSite)
                            For intChan = 1 To UBound(ChanCopy)
                                If ChanCopy(intChan, 2) = strBuff Then 'insert this a trunk frequency

                                    intPos = InsertTrunkFreq(strBuff)
                                    If intPos > 0 Then
                                        strTrunkFreq(intPos, 0) = ChanCopy(intChan, 0)
                                        strTrunkFreq(intPos, 1) = ChanCopy(intChan, 1)
                                        strTrunkFreq(intPos, 2) = varSite(intCurrentSys, intSite, 0, 10)
                                    End If
                                End If
                            Next intChan
                        ElseIf varSite(intCurrentSys, intSite, 0, 5) <> "" Then  ' a regular group
                            'find if there are any regular channels that belong to it in memory, if so copy them
                            strBuff = strOldGrpID(intSite)
                            For intChan = 1 To UBound(ChanCopy)
                                If ChanCopy(intChan, 10) = strBuff Then 'insert this a trunk frequency
                                    If varSite(intCurrentSys, intSite, 0, 5) = "1" Then 'conv group
                                        intPos = InsertChan(strBuff, True)
                                    Else
                                        intPos = InsertChan(strBuff, False)
                                    End If
                                    If intPos > 0 Then
                                        For intParam = 0 To MaxChanSetting
                                            ChanInfo(intPos, intParam) = ChanCopy(intChan, intParam)
                                        Next intParam
                                        ChanInfo(intPos, 10) = varSite(intCurrentSys, intSite, 0, 10)
                                    End If
                                End If
                            Next intChan
                        End If
                    End If
                End If
            Next intSite
            If intPos = -1 Then 'out of memory
                intPos = MsgBox("Insufficient memory available to copy all channels and/or trunked frequencies. As a result, some may be lost.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Out of memory")
            End If
            'Assign new ID to this system

            varSite(intCurrentSys, 0, 0, 23) = CreateGroupID()


            MarkChange()
            Call DrawSystemTree()
        ElseIf ChanCopy(0, 0) = "TRUNKSITE" Or ChanCopy(0, 0) = "TRUNKGROUP" Or ChanCopy(0, 0) = "CONVGROUP" Then
            'Verify it is being pasted into an appropiate destination
            If ChanCopy(0, 0) = "CONVGROUP" And varSite(intCurrentSys, 0, 0, 3) <> "1" Then
                MsgBox("Please select a conventional system prior to pasting this group.")
                Exit Sub
            End If
            If varSite(intCurrentSys, 0, 0, 3) = "1" And ChanCopy(0, 0) <> "CONVGROUP" Then
                MsgBox("You cannot paste a trunk group or site into a conventional system.")
                Exit Sub
            End If
            'Verify there is room
            intPos = -1
            For intCnt = 1 To MaxGroups
                If varSite(intCurrentSys, intCnt, 0, 10) = "" Then
                    intPos = intCnt
                    intCnt = MaxGroups
                End If
            Next intCnt
            If intPos = -1 Then
                MsgBox("This system cannot hold any more groups or sites.")
                Exit Sub
            End If
            intCurrentGroup = intPos
            intSite = intPos
            intGroup = intPos
            'paste in settings
            For intCnt = 0 To MaxSetting

                varSite(intCurrentSys, intSite, 0, intCnt) = strSysCopy(0, intCnt)
            Next intCnt
            'assign new ID
            strBuff = varSite(intCurrentSys, intGroup, 0, 10)

            varSite(intCurrentSys, intGroup, 0, 10) = CreateGroupID()
            'paste in channels
            intPos = 0
            'find if there are any trunk frequencies that belong to it in memory
            If varSite(intCurrentSys, intSite, 0, 5) = "3" Then
                For intChan = 1 To UBound(ChanCopy)
                    If ChanCopy(intChan, 2) = strBuff Then 'insert this a trunk frequency

                        intPos = InsertTrunkFreq(strBuff)
                        If intPos > 0 Then
                            strTrunkFreq(intPos, 0) = ChanCopy(intChan, 0)
                            strTrunkFreq(intPos, 1) = ChanCopy(intChan, 1)
                            strTrunkFreq(intPos, 2) = varSite(intCurrentSys, intSite, 0, 10)
                        End If
                    End If
                Next intChan
            ElseIf varSite(intCurrentSys, intSite, 0, 5) <> "" Then  ' a regular group
                'find if there are any regular channels that belong to it in memory, if so copy them
                For intChan = 1 To UBound(ChanCopy)
                    If ChanCopy(intChan, 10) = strBuff Then 'insert this a trunk frequency
                        If ChanCopy(0, 0) = "TRUNKGROUP" Then
                            intPos = InsertChan(strBuff, False)
                        Else
                            intPos = InsertChan(strBuff, True)
                        End If
                        If intPos > 0 Then
                            For intParam = 0 To MaxChanSetting
                                ChanInfo(intPos, intParam) = ChanCopy(intChan, intParam)
                            Next intParam
                            ChanInfo(intPos, 10) = varSite(intCurrentSys, intSite, 0, 10)
                        End If
                    End If
                Next intChan
            End If
            If intPos = -1 Then 'out of memory
                intPos = MsgBox("Insufficient memory available to copy all channels and/or trunked frequencies. As a result, some may be lost.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Out of memory")
            End If
            MarkChange()
            If Not blnSkipRedraw Then Call DrawSystemTree()
        ElseIf ChanCopy(0, 0) = "" Then
            intBuff = MsgBox("Nothing in clipboard", MsgBoxStyle.Exclamation, "Cannot Paste")
            Exit Sub
        End If
        UpdateViewMode()
        If ChanCopy(0, 0) = "TRN" Then
            tabTrunkSite.SelectedIndex = 1
        End If
    End Sub

    Public Sub mnuPopSel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopSel.Click
        Dim index As Short = mnuPopSel.GetIndex(eventSender)
        'Dim CreateNewSite As Object
        'this is actions for the context menu showen in the object tree
        Select Case index
            Case 2 'new system
                Call mnuCreateNewSystem_Click()
            Case 3 'new site
                Call CreateNewSite()
            Case 4 'new group
                Call mnuCreateGroup_Click()
            Case 6 'cut
                Call mnuCutChannel_Click(mnuCutChannel, New System.EventArgs())
            Case 7 'copy
                Call mnuCopyChannel_Click(mnuCopyChannel, New System.EventArgs())
            Case 8 'paste
                Call mnuPasteChannel_Click(mnuPasteChannel, New System.EventArgs())
            Case 9 'delete
                Call mnuDeleteSystem_Click(mnuDeleteSystem, New System.EventArgs())
        End Select
    End Sub

    Public Sub mnuQuickDrawAUto_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQuickDrawAUto.Click
        With mnuQuickDrawAUto
            If .Checked = False Then
                .Checked = True
                mnuQuickDrawOn.Checked = False
                mnuQuickDrawOff.Checked = False
            Else
                .Checked = False
            End If
            SaveSetting("FreeSCAN", "Settings", "QuickDraw", "2")
        End With
    End Sub

    Public Sub mnuQuickDrawOff_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQuickDrawOff.Click
        With mnuQuickDrawOff
            If .Checked = False Then
                .Checked = True
                mnuQuickDrawOn.Checked = False
                mnuQuickDrawAUto.Checked = False
            Else
                .Checked = False
            End If
            SaveSetting("FreeSCAN", "Settings", "QuickDraw", "0")
        End With
    End Sub

    Public Sub mnuQuickDrawOn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQuickDrawOn.Click
        With mnuQuickDrawOn
            If .Checked = False Then
                .Checked = True
                mnuQuickDrawOff.Checked = False
                mnuQuickDrawAUto.Checked = False
            Else
                .Checked = False
            End If
            SaveSetting("FreeSCAN", "Settings", "QuickDraw", "1")
        End With
    End Sub

    Public Sub mnuShowQK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuShowQK.Click
        With mnuShowQK
            If .Checked = False Then
                .Checked = True
            Else
                .Checked = False
            End If
            SaveSetting("FreeSCAN", "Settings", "mnuShowQK", CStr(.Checked))
        End With
        DrawSystemTree()
    End Sub

    Public Sub mnuShowStat_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuShowStat.Click
        frmStats.Visible = True
        frmStats.MakeStats()
    End Sub

    Public Sub mnuShowSysType_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuShowSysType.Click
        With mnuShowSysType
            If .Checked = False Then
                .Checked = True
            Else
                .Checked = False
            End If
            SaveSetting("FreeSCAN", "Settings", "ShowSysType", CStr(.Checked))
        End With
        DrawSystemTree()
    End Sub

    Public Sub mnuSortByFreqAscending_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSortByFreqAscending.Click
        Dim intNumChan As Integer
        If grdConvChan.Visible = True Then 'sort by conventional frequency, ascending

            intNumChan = grdConvChan.RowCount

            If intNumChan > 1 Then
                'begin sorting
                Call SortIt("FREQ", "ASC")
                LoadConvChanGrid()
            End If
        ElseIf grdTGID.Visible = True Then
            intNumChan = grdTGID.RowCount
            If intNumChan > 1 Then
                'begin sorting
                Call SortIt("TGID", "ASC")
                LoadTrunkChanGrid()
            End If
        End If
    End Sub

    Sub SortIt(ByRef strWhich As String, ByRef strDir As String)
        Dim intChan, i, intNumChan, intBuff As Integer
        Dim intParam As Integer
        Dim j, intNew As Integer
        Dim ChanSort(2000, MaxChanSetting) As String
        Dim best_value(MaxChanSetting) As String
        Dim best_j As Integer
        'using SelectionSort

        If strWhich = "FREQ" Then 'conventional channel frequency
            'first find how manu
            intNumChan = grdConvChan.RowCount - 1
            If intNumChan > 2000 Then
                MsgBox("FreeSCAN can only sort groups up to 2000 channels.")
                Exit Sub
            End If
            'Dump the info from chaninfo to chandata so its nice and linear
            For intChan = 1 To MaxChan
                If ChanInfo(intChan, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then
                    intBuff = intBuff + 1
                    For intParam = 0 To MaxChanSetting

                        ChanSort(intBuff, intParam) = ChanInfo(intChan, intParam)
                        'wipe out the old info, while at it

                        ChanInfo(intChan, intParam) = ""
                    Next intParam
                End If
            Next intChan

            If strDir = "ASC" Then
                'sort channel by frequency, ascending
                For i = 1 To intBuff - 1
                    For intParam = 0 To MaxChanSetting
                        best_value(intParam) = ChanSort(i, intParam)
                        best_j = i
                    Next intParam
                    For j = i + 1 To intBuff
                        If Val(ChanSort(j, 2)) < Val(best_value(2)) Then
                            For intParam = 0 To MaxChanSetting
                                best_value(intParam) = ChanSort(j, intParam)
                            Next intParam
                            best_j = j
                        End If
                    Next j
                    For intParam = 0 To MaxChanSetting
                        ChanSort(best_j, intParam) = ChanSort(i, intParam)
                        ChanSort(i, intParam) = best_value(intParam)
                    Next intParam
                Next i

                'reinsert chansort back into memory
                For intChan = 1 To intBuff
                    intNew = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
                    For intParam = 0 To MaxChanSetting
                        ChanInfo(intNew, intParam) = ChanSort(intChan, intParam)
                    Next intParam
                Next intChan

            Else 'descending
                For i = 1 To intBuff - 1
                    For intParam = 0 To MaxChanSetting
                        best_value(intParam) = ChanSort(i, intParam)
                        best_j = i
                    Next intParam
                    For j = i + 1 To intBuff
                        If Val(ChanSort(j, 2)) > Val(best_value(2)) Then
                            For intParam = 0 To MaxChanSetting
                                best_value(intParam) = ChanSort(j, intParam)
                            Next intParam
                            best_j = j
                        End If
                    Next j
                    For intParam = 0 To MaxChanSetting
                        ChanSort(best_j, intParam) = ChanSort(i, intParam)
                        ChanSort(i, intParam) = best_value(intParam)
                    Next intParam
                Next i

                'reinsert chansort back into memory
                For intChan = 1 To intBuff
                    intNew = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
                    For intParam = 0 To MaxChanSetting
                        ChanInfo(intNew, intParam) = ChanSort(intChan, intParam)
                    Next intParam
                Next intChan
            End If


        ElseIf strWhich = "CONVNAME" Then  'sort by name
            'first find how manu
            intNumChan = grdConvChan.RowCount - 1
            If intNumChan > 2000 Then
                MsgBox("FreeSCAN can only sort group up to 2000 channels.")
                Exit Sub
            End If
            'Dump the info from chaninfo to chandata so its nice and linear
            For intChan = 1 To MaxChan
                If ChanInfo(intChan, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then
                    intBuff = intBuff + 1
                    For intParam = 0 To MaxChanSetting
                        ChanSort(intBuff, intParam) = ChanInfo(intChan, intParam)
                        'wipe out the old info, while at it
                        ChanInfo(intChan, intParam) = Nothing
                    Next intParam
                End If
            Next intChan

            If strDir = "ASC" Then
                'sort channel by name, ascending
                For i = 1 To intBuff - 1
                    For intParam = 0 To MaxChanSetting

                        best_value(intParam) = ChanSort(i, intParam)
                        best_j = i
                    Next intParam
                    For j = i + 1 To intBuff
                        If UCase(ChanSort(j, 1)) < UCase(best_value(1)) Then
                            For intParam = 0 To MaxChanSetting

                                best_value(intParam) = ChanSort(j, intParam)
                            Next intParam
                            best_j = j
                        End If
                    Next j
                    For intParam = 0 To MaxChanSetting
                        ChanSort(best_j, intParam) = ChanSort(i, intParam)
                        ChanSort(i, intParam) = best_value(intParam)
                    Next intParam
                Next i

                'reinsert chansort back into memory
                For intChan = 1 To intBuff
                    intNew = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
                    For intParam = 0 To MaxChanSetting
                        ChanInfo(intNew, intParam) = ChanSort(intChan, intParam)
                    Next intParam
                Next intChan

            Else 'descending
                'sort channel by name, descending
                For i = 1 To intBuff - 1
                    For intParam = 0 To MaxChanSetting

                        best_value(intParam) = ChanSort(i, intParam)
                        best_j = i
                    Next intParam
                    For j = i + 1 To intBuff
                        If UCase(ChanSort(j, 1)) > UCase(best_value(1)) Then
                            For intParam = 0 To MaxChanSetting
                                best_value(intParam) = ChanSort(j, intParam)
                            Next intParam
                            best_j = j
                        End If
                    Next j
                    For intParam = 0 To MaxChanSetting
                        ChanSort(best_j, intParam) = ChanSort(i, intParam)
                        ChanSort(i, intParam) = best_value(intParam)
                    Next intParam
                Next i

                'reinsert chansort back into memory
                For intChan = 1 To intBuff
                    intNew = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
                    For intParam = 0 To MaxChanSetting
                        ChanInfo(intNew, intParam) = ChanSort(intChan, intParam)
                    Next intParam
                Next intChan
            End If

        ElseIf strWhich = "TGIDNAME" Then
            'first find how manu
            intNumChan = grdTGID.RowCount - 1
            If intNumChan > 2000 Then
                MsgBox("FreeSCAN can only sort groups up to 2000 channels.")
                Exit Sub
            End If
            'Dump the info from chaninfo to chandata so its nice and linear
            For intChan = 1 To MaxChan
                If ChanInfo(intChan, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then
                    intBuff = intBuff + 1
                    For intParam = 0 To MaxChanSetting

                        ChanSort(intBuff, intParam) = ChanInfo(intChan, intParam)
                        'wipe out the old info, while at it

                        ChanInfo(intChan, intParam) = Nothing
                    Next intParam
                End If
            Next intChan

            If strDir = "ASC" Then
                'sort channel by name, ascending
                For i = 1 To intBuff - 1
                    For intParam = 0 To MaxChanSetting

                        best_value(intParam) = ChanSort(i, intParam)
                        best_j = i
                    Next intParam
                    For j = i + 1 To intBuff
                        If UCase(ChanSort(j, 1)) < UCase(best_value(1)) Then
                            For intParam = 0 To MaxChanSetting

                                best_value(intParam) = ChanSort(j, intParam)
                            Next intParam
                            best_j = j
                        End If
                    Next j
                    For intParam = 0 To MaxChanSetting

                        ChanSort(best_j, intParam) = ChanSort(i, intParam)

                        ChanSort(i, intParam) = best_value(intParam)
                    Next intParam
                Next i

                'reinsert chansort back into memory
                For intChan = 1 To intBuff

                    intNew = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
                    For intParam = 0 To MaxChanSetting

                        ChanInfo(intNew, intParam) = ChanSort(intChan, intParam)
                    Next intParam
                Next intChan
            Else 'descending
                'sort channel by name, descending
                For i = 1 To intBuff - 1
                    For intParam = 0 To MaxChanSetting

                        best_value(intParam) = ChanSort(i, intParam)
                        best_j = i
                    Next intParam
                    For j = i + 1 To intBuff
                        If UCase(ChanSort(j, 1)) > UCase(best_value(1)) Then
                            For intParam = 0 To MaxChanSetting
                                best_value(intParam) = ChanSort(j, intParam)
                            Next intParam
                            best_j = j
                        End If
                    Next j
                    For intParam = 0 To MaxChanSetting
                        ChanSort(best_j, intParam) = ChanSort(i, intParam)
                        ChanSort(i, intParam) = best_value(intParam)
                    Next intParam
                Next i
                'reinsert chansort back into memory
                For intChan = 1 To intBuff
                    intNew = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
                    For intParam = 0 To MaxChanSetting
                        ChanInfo(intNew, intParam) = ChanSort(intChan, intParam)
                    Next intParam
                Next intChan
            End If

        ElseIf strWhich = "TGID" Then
            'first find how manu
            intNumChan = grdTGID.RowCount - 1
            If intNumChan > 2000 Then
                MsgBox("FreeSCAN can only sort groups up to 2000 channels.")
                Exit Sub
            End If
            'Dump the info from chaninfo to chandata so its nice and linear
            For intChan = 1 To MaxChan
                If ChanInfo(intChan, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then
                    intBuff = intBuff + 1
                    For intParam = 0 To MaxChanSetting

                        ChanSort(intBuff, intParam) = ChanInfo(intChan, intParam)
                        'wipe out the old info, while at it

                        ChanInfo(intChan, intParam) = ""
                    Next intParam
                End If
            Next intChan

            If strDir = "ASC" Then
                'sort tgid by name, ascending
                For i = 1 To intBuff - 1
                    For intParam = 0 To MaxChanSetting

                        best_value(intParam) = ChanSort(i, intParam)
                        best_j = i
                    Next intParam
                    For j = i + 1 To intBuff
                        If IsNumeric(ChanSort(j, 2)) = True And IsNumeric(best_value(2)) = True Then
                            If Val(ChanSort(j, 2)) < Val(best_value(2)) Then
                                For intParam = 0 To MaxChanSetting

                                    best_value(intParam) = ChanSort(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                        Else
                            If ChanSort(j, 2) < best_value(2) Then
                                For intParam = 0 To MaxChanSetting

                                    best_value(intParam) = ChanSort(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                        End If
                    Next j
                    For intParam = 0 To MaxChanSetting

                        ChanSort(best_j, intParam) = ChanSort(i, intParam)

                        ChanSort(i, intParam) = best_value(intParam)
                    Next intParam
                Next i

                'reinsert chansort back into memory
                For intChan = 1 To intBuff
                    intNew = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
                    For intParam = 0 To MaxChanSetting
                        ChanInfo(intNew, intParam) = ChanSort(intChan, intParam)
                    Next intParam
                Next intChan
            Else 'descending
                'sort tgid by name, ascending
                For i = 1 To intBuff - 1
                    For intParam = 0 To MaxChanSetting

                        best_value(intParam) = ChanSort(i, intParam)
                        best_j = i
                    Next intParam
                    For j = i + 1 To intBuff
                        If IsNumeric(ChanSort(j, 2)) = True And IsNumeric(best_value(2)) = True Then 'sort TGID numerically
                            If Val(ChanSort(j, 2)) > Val(best_value(2)) Then
                                For intParam = 0 To MaxChanSetting

                                    best_value(intParam) = ChanSort(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                        Else
                            If ChanSort(j, 2) > best_value(2) Then
                                For intParam = 0 To MaxChanSetting

                                    best_value(intParam) = ChanSort(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                        End If
                    Next j
                    For intParam = 0 To MaxChanSetting

                        ChanSort(best_j, intParam) = ChanSort(i, intParam)

                        ChanSort(i, intParam) = best_value(intParam)
                    Next intParam
                Next i

                'reinsert chansort back into memory
                For intChan = 1 To intBuff

                    intNew = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
                    For intParam = 0 To MaxChanSetting

                        ChanInfo(intNew, intParam) = ChanSort(intChan, intParam)
                    Next intParam
                Next intChan
            End If
        End If 'which
    End Sub

    Public Sub mnuSortByFreqDescending_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSortByFreqDescending.Click
        Dim intNumChan As Integer
        If grdConvChan.Visible = True Then 'sort by conventional frequency, ascending

            intNumChan = grdConvChan.RowCount - 1

            If intNumChan > 1 Then
                'begin sorting
                Call SortIt("FREQ", "DESC")
                LoadConvChanGrid()

            End If
        ElseIf grdTGID.Visible = True Then

            intNumChan = grdTGID.RowCount - 1

            If intNumChan > 1 Then
                'begin sorting
                Call SortIt("TGID", "DESC")
                LoadTrunkChanGrid()
            End If
        End If

    End Sub

    Public Sub mnuSortByNameAscending_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSortByNameAscending.Click
        Dim intNumChan As Integer
        If grdConvChan.Visible = True Then 'sort by conventional frequency, ascending

            intNumChan = grdConvChan.RowCount - 1

            If intNumChan > 1 Then
                'begin sorting
                Call SortIt("CONVNAME", "ASC")
                LoadConvChanGrid()

            End If
        ElseIf grdTGID.Visible = True Then

            intNumChan = grdTGID.RowCount - 1

            If intNumChan > 1 Then
                'begin sorting
                Call SortIt("TGIDNAME", "ASC")
                LoadTrunkChanGrid()
            End If
        End If

    End Sub

    Public Sub mnuSortByNameDescending_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSortByNameDescending.Click
        Dim intNumChan As Integer
        If grdConvChan.Visible = True Then 'sort by conventional frequency, ascending

            intNumChan = grdConvChan.RowCount - 1

            If intNumChan > 1 Then
                'begin sorting
                Call SortIt("CONVNAME", "DESC")
                LoadConvChanGrid()

            End If
        ElseIf grdTGID.Visible = True Then

            intNumChan = grdTGID.RowCount - 1

            If intNumChan > 1 Then
                'begin sorting
                Call SortIt("TGIDNAME", "DESC")
                LoadTrunkChanGrid()
            End If
        End If
    End Sub



    Public Sub mnuToolsChanLockout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsChanLockout.Click
        frmLockout.Visible = True
        Call frmLockout.cmdRefresh_Click_1(Nothing, New System.EventArgs())
    End Sub

    Public Sub mnuToolsControl_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsControl.Click
        If blnDebug = False Then On Error Resume Next
        frmCtlSetup.Visible = True
        frmCtlSetup.Enabled = True
        frmCtlSetup.Activate()
    End Sub

    Public Sub mnuToolsDL_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsDL.Click
        If blnRmtCtlMode = True Then
            MsgBox("You currently have a remote control window open. Please close this window before proceeding.")
            Exit Sub
        End If
        Me.Visible = False
        frmCommsDownload.Visible = True
    End Sub

    Public Sub mnuToolsSetup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsSetup.Click
        Me.Visible = False
        frmRadioPref246.LoadData()
        frmRadioPref246.Visible = True
        frmRadioPref246.Activate()
    End Sub

    Public Sub mnuToolsUL_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsUL.Click
        If Form1.optWriteMode(0).Checked Then
            Form1.optWriteMode(1).Checked = True
        End If
        Form1.Visible = True
        Me.Visible = False
        If Not Form1.msc.IsOpen Then
            Form1.initForm()
            Form1.LoadList()
        End If
    End Sub


    Public Sub mnuUnlockAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuUnlockAll.Click
        ModAllLO((0))
    End Sub



    Private Sub optConvTapeOut_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optConvTapeOut.CheckedChanged
        If eventSender.Checked Then
            Dim index As Short = optConvTapeOut.GetIndex(eventSender)
            If blnBusy = True Then Exit Sub
            Dim cnt As Integer
            For cnt = 0 To 2
                If optConvTapeOut(cnt).Checked = True Then
                    varSite(intCurrentSys, 0, 0, 24) = CStr(cnt)
                    cnt = 2
                End If
            Next cnt
            MarkChange()
        End If
    End Sub


    Private Sub optEDACSIDAFS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optEDACSIDAFS.CheckedChanged
        If blnBusy Then Exit Sub
        If eventSender.Checked Then

            varSite(intCurrentSys, 0, 0, 14) = MakeBinary((optEDACSIDAFS.Checked))
            MarkChange()
        End If
    End Sub


    Private Sub optEDACSIDDec_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optEDACSIDDec.CheckedChanged
        If blnBusy Then Exit Sub
        If eventSender.Checked Then

            varSite(intCurrentSys, 0, 0, 14) = MakeBinary((optEDACSIDAFS.Checked))
            MarkChange()
        End If
    End Sub


    Private Sub optIDScan_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optIDScan.CheckedChanged
        If blnBusy Then Exit Sub
        If eventSender.Checked Then

            varSite(intCurrentSys, 0, 0, 11) = MakeBinary((optIDSearch.Checked))
            MarkChange()
        End If
    End Sub


    Private Sub optIDSearch_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optIDSearch.CheckedChanged
        If blnBusy Then Exit Sub
        If eventSender.Checked Then

            varSite(intCurrentSys, 0, 0, 11) = MakeBinary((optIDSearch.Checked))
            MarkChange()
        End If
    End Sub


    Private Sub optTrnRecord_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTrnRecord.CheckedChanged
        If eventSender.Checked Then
            Dim index As Short = optTrnRecord.GetIndex(eventSender)
            varSite(intCurrentSys, 0, 0, 24) = CStr(index)
            MarkChange()
        End If
    End Sub





    Private Sub tabTrunkSite_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabTrunkSite.SelectedIndexChanged
        Static PreviousTab As Short = tabTrunkSite.SelectedIndex()
        Select Case tabTrunkSite.SelectedIndex
            Case 0 'main trunk site setup
                LoadData("TRUNKSITESETUP")
            Case 1 'load trunk frequencies
                LoadData("TrunkFreq")
            Case 2 'apco band plan
                LoadData("APCOBP")
            Case 3
                LoadData("REBAND")
        End Select


        PreviousTab = tabTrunkSite.SelectedIndex()
    End Sub

    Private Sub treeSystems_AfterLabelEdit(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.NodeLabelEditEventArgs) Handles treeSystems.AfterLabelEdit
        Dim Cancel As Boolean = eventArgs.CancelEdit
        Dim strNewName As String = eventArgs.Label
        'This subroutine updates memory when the user edits the name of a site/group in treeview
        Dim strKey, intTargetNum As String
        Dim intSiteTargetNum As Integer
        Dim intGroupTargetNum As Integer

        strKey = treeSystems.SelectedNode.Name
        If strKey = "Root" Then
            'you can't do that
            treeSystems.SelectedNode.Text = RadioSetting(19)
            MsgBox("This paramater cannot be changed.")
        ElseIf Len(strKey) = 5 Then
            'a system name was changed, clean it up and apply changes
            strNewName = MakeItKosher(strNewName)
            intTargetNum = VB.Right(strKey, 4)
            varSite(CInt(intTargetNum), 0, 0, 1) = strNewName
            txtSiteName.Text = strNewName
        ElseIf Len(strKey) = 10 Then  'update a group name
            strNewName = MakeItKosher(strNewName)
            intGroupTargetNum = CInt(VB.Right(strKey, 4))
            intSiteTargetNum = VB.Right(VB.Left(strKey, 5), 4)
            varSite(intSiteTargetNum, intGroupTargetNum, 0, 1) = strNewName
            txtTGIDGroupName.Text = strNewName
            txtConvGroupName.Text = strNewName
        End If
        MarkChange()

        StatusBar.Items.Item(1).Text = varSite(intCurrentSys, 0, 0, 1) & " - " & varSite(intCurrentSys, intCurrentGroup, 0, 1)
    End Sub

    Private Sub treeSystems_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeSystems.AfterSelect

        UpdateViewMode()
        If intCurrentGroup > 0 Then
            StatusBar.Items.Item(1).Text = varSite(intCurrentSys, 0, 0, 1) & " - " & varSite(intCurrentSys, intCurrentGroup, 0, 1)
        Else
            StatusBar.Items.Item(1).Text = varSite(intCurrentSys, 0, 0, 1)
        End If
    End Sub



    Private Sub treeSystems_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles treeSystems.DragDrop
        'Primary event when a user drops off an object
        Dim pt As Point
        Dim DestinationNode As TreeNode, strTag, strSrcSysType, strTrgSysType As String
        pt = CType(sender, TreeView).PointToClient(New Point(e.X, e.Y))
        DestinationNode = CType(sender, TreeView).GetNodeAt(pt)
        strTag = DestinationNode.Tag
        intTargetSys = Val(OldMid(strTag, 2, 4))
        'validate the operation as being possible
        strSrcSysType = varSite(intDraggedSysNum, 0, 0, 3)
        strTrgSysType = varSite(intTargetSys, 0, 0, 3)
        If strSrcSysType = "1" And strTrgSysType = "1" Then
            'Conventional move, OK
            'Perform a move operation
        ElseIf strSrcSysType = "1" And strTrgSysType <> "1" Then
            'cannot move a conventional group to a trunk system
            MsgBox("You cannot move a conventional group into a trunked system", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf strTrgSysType = "1" And strSrcSysType <> "1" Then
            'cannot move a trunked site/group to a conventional system
            MsgBox("You cannot move a trunked site/group into a conventional system.", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf intTargetSys = intDraggedSysNum Then
            'cannot move within the same system
            Exit Sub
        Else
            'trunk to trunk operation, OK
        End If
        If blnDragRightClick Then
            Me.ContextMenuStrip = mnuCutCopy
            Me.ContextMenuStrip.Show(Me, pt)
            Exit Sub
        End If
        intCurrentSys = intDraggedSysNum
        intCurrentGroup = intDraggedSiteNum
        intCurrentChannel = 0
        blnSkipRedraw = True
        Call mnuCutChannel_Click(Nothing, Nothing)
        intCurrentSys = intTargetSys
        intCurrentGroup = 0
        blnSkipRedraw = False
        Call mnuPasteChannel_Click(Nothing, Nothing)

    End Sub

    Private Sub treeSystems_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles treeSystems.DragEnter
        'User has clicked on an object an wants to drag it off somewhere
        If Not blnDebug Then On Error Resume Next
        Dim strKey As String
        If blnDebug Then On Error Resume Next
        Select Case e.KeyState
            Case 2 'right button, bring up context menu to cut/copy/paste
                blnDragRightClick = True
            Case Else 'just to a normal move operation
                blnDragRightClick = False
        End Select

        If Nothing = treeSystems.SelectedNode.Tag Then Exit Sub
        'first get the key from the tree
        strKey = (treeSystems.SelectedNode.Tag)
        'update currently selected system in memory
        'turning view modes on/off
        If treeSystems.Nodes.Count = 0 Or Len(strKey) = 0 Then
            'nothing to do

        ElseIf Len(strKey) = 5 Then  'a system has been selected, determine if its trunked or conventional
            'a system cannot be moved

        ElseIf Len(strKey) = 10 Then  'A group has been selected
            'is this a trunk site or an actual group?
            'set current site/groups to this one
            'find out if it belongs to a conv or trunked site and turn on appropiate view
            intDraggedSysNum = Val(VB.Right(VB.Left(strKey, 5), 4))
            intDraggedSiteNum = Val(VB.Right(strKey, 4))
            e.Effect = DragDropEffects.Move
        Else 'something weird and unexpected
            If blnDebug Then
                MsgBox("Unknown mystery value - treesystems-Dragenter-" & strKey)

                Exit Sub
            End If
        End If
    End Sub

    Private Sub treeSystems_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles treeSystems.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Move)

    End Sub

    Private Sub treeSystems_MouseClick(ByVal sender As Object, ByVal eventargs As System.Windows.Forms.MouseEventArgs) Handles treeSystems.MouseClick
        Dim button As Short = eventargs.Button \ &H100000
        Dim shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Exit Sub
        'Popup menu for the object tree
        If button <> 2 Or Not treeSystems.Focused Then Exit Sub
        '   Call treeSystems_AfterSelect(Nothing, Nothing)
        'set the object to be operated on name

        '  Exit Sub
        My.Application.DoEvents()
        UpdateViewMode()
        If intCurrentSys = 0 And intCurrentGroup = 0 Then

            'determine if it is a conventional or trunked system that was selected
            mnuPopUpCon_NewSite.Enabled = False
            mnuPopUpCon_ObjName.Text = "(No System Selected)"
        ElseIf intCurrentSys <> 0 And intCurrentGroup = 0 Then
            'determine if it is a conventional or trunked system that was selected
            If varSite(intCurrentSys, 0, 0, 3) = "1" Then 'conventional system, disable new site
                mnuPopUpCon_NewSite.Enabled = False
            Else
                mnuPopUpCon_NewSite.Enabled = True
            End If
            mnuPopUpCon_ObjName.Text = " --    " & varSite(intCurrentSys, 0, 0, 1) & "    -- "
        ElseIf intCurrentSys <> 0 And intCurrentGroup <> 0 Then
            'determine ifthey  it is a conventional or trunked system that was selected
            If varSite(intCurrentSys, 0, 0, 3) = "1" Then 'conventional system, disable new site
                mnuPopUpCon_NewSite.Enabled = False
            Else
                mnuPopUpCon_NewSite.Enabled = True
            End If
            mnuPopUpCon_ObjName.Text = " --    " & varSite(intCurrentSys, intCurrentGroup, 0, 1) & "    -- "
        End If

        If eventargs.Button = Windows.Forms.MouseButtons.Right Then
            Me.ContextMenuStrip = mnuPopUpCon
        End If
        If eventargs.Button = Windows.Forms.MouseButtons.Right Then
            Me.ContextMenuStrip = mnuPopUpCon
        End If
    End Sub


    Private Sub treeSystems_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles treeSystems.MouseDown
        Dim button As Short = eventArgs.Button \ &H100000
        Dim shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000

        'Popup menu for the object tree
        If button <> 2 Or Not treeSystems.Focused Then Exit Sub
        '   Call treeSystems_AfterSelect(Nothing, Nothing)
        'set the object to be operated on name

        '  Exit Sub
        ' UpdateViewMode()
        If intCurrentSys = 0 And intCurrentGroup = 0 Then

            'determine if it is a conventional or trunked system that was selected
            mnuPopUpCon_NewSite.Enabled = False
            mnuPopUpCon_ObjName.Text = "(No System Selected)"
        ElseIf intCurrentSys <> 0 And intCurrentGroup = 0 Then
            'determine if it is a conventional or trunked system that was selected
            If varSite(intCurrentSys, 0, 0, 3) = "1" Then 'conventional system, disable new site
                mnuPopUpCon_NewSite.Enabled = False
            Else
                mnuPopUpCon_NewSite.Enabled = True
            End If
            mnuPopUpCon_ObjName.Text = " --    " & varSite(intCurrentSys, 0, 0, 1) & "    -- "
        ElseIf intCurrentSys <> 0 And intCurrentGroup <> 0 Then
            'determine ifthey  it is a conventional or trunked system that was selected
            If varSite(intCurrentSys, 0, 0, 3) = "1" Then 'conventional system, disable new site
                mnuPopUpCon_NewSite.Enabled = False
            Else
                mnuPopUpCon_NewSite.Enabled = True
            End If
            mnuPopUpCon_ObjName.Text = " --    " & varSite(intCurrentSys, intCurrentGroup, 0, 1) & "    -- "
        End If

        If eventArgs.Button = Windows.Forms.MouseButtons.Right Then
            Me.ContextMenuStrip = mnuPopUpCon
        End If
    End Sub
    Sub ShowTreeContextMenu()

    End Sub



    Private Sub txtConvGroupName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtConvGroupName.TextChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosher((txtConvGroupName.Text))
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
    End Sub



    Private Sub txtConvGroupName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtConvGroupName.Leave
        If blnBusy Then Exit Sub
        MarkChange()
    End Sub


    Private Sub txtSiteName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSiteName.TextChanged

        If blnBusy Then Exit Sub
        varSite(intCurrentSys, 0, 0, 1) = MakeItKosher((txtSiteName.Text))
        MarkChange()
        Call UpdateDisplayNode(intCurrentSys, 0)
    End Sub




    Private Sub txtTGIDGroupName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTGIDGroupName.TextChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosher((txtTGIDGroupName.Text))
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
        MarkChange()
    End Sub





    Private Sub txtTrunkSiteName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTrunkSiteName.TextChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, intCurrentGroup, 0, 1) = MakeItKosher((txtTrunkSiteName.Text))
        Call UpdateDisplayNode(intCurrentSys, intCurrentGroup)
        MarkChange()
    End Sub


    Private Sub txtTrunkSysName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTrunkSysName.TextChanged
        If blnBusy = True Then Exit Sub

        varSite(intCurrentSys, 0, 0, 1) = MakeItKosher(txtTrunkSysName.Text)
        Call UpdateDisplayNode(intCurrentSys, 0)
        MarkChange()
    End Sub

    Sub EncodeRebandGrid()
        'Takes all the text from the reband grid
        'and it saves it to the rebanding variable in the current system
        If blnDebug = False Then On Error Resume Next
        If blnBusy Then Exit Sub

        Dim intRow, intCol As Integer
        Dim strBuff As String
        Dim strRow, strReband As String
        strReband = Nothing
        With grdReband
            If .RowCount <> 6 Then Exit Sub
            For intRow = 0 To 5
                strRow = ""
                'lower freq

                strBuff = MakeItKosherFreqSilent(grdReband(0, intRow).Value)
                If Val(strBuff) > 1300 Then strBuff = CStr(1300)
                strBuff = CStr(Val(strBuff) * 10000)
                strRow = strBuff & ","

                'upper freq

                strBuff = MakeItKosherFreqSilent(grdReband(1, intRow).Value)
                If CDbl(strBuff) > 1300 Then strBuff = CStr(1300)
                strBuff = CStr(Val(strBuff) * 10000)
                strRow = strRow & strBuff & ","
                'step
                strBuff = grdReband(2, intRow).Value
                strBuff = CStr(Val(strBuff) * 100)
                strRow = strRow & strBuff & ","
                'offset
                strBuff = CStr(Val(grdReband(3, intRow).Value))
                If Val(strBuff) >= -1023 And Val(strBuff) <= 1023 Then
                    strRow = strRow & strBuff
                Else
                    strRow = strRow & "0"
                End If
                strReband = strReband & strRow
                If intRow <> 5 Then
                    strReband = strReband & "@"
                End If
            Next intRow


        End With
        varSite(intCurrentSys, intCurrentGroup, 0, 62) = strReband
    End Sub



    Private Sub mnuPopUpCon_Cut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPopUpCon_Cut.Click
        Call mnuCutChannel_Click(Me, Nothing)
    End Sub

    Private Sub mnuPopUpCon_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPopUpCon_Delete.Click
        Call mnuDeleteSystem_Click(Me, Nothing)
    End Sub

    Private Sub mnuPopUpCon_Paste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPopUpCon_Paste.Click
        Call mnuPasteChannel_Click(Me, Nothing)
    End Sub

    Private Sub mnuPopUpCon_Copy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPopUpCon_Copy.Click
        Call mnuCopyChannel_Click(Me, Nothing)
    End Sub

    Private Sub grdTGID_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTGID.CellClick
        If grdTGID.RowCount = 0 Then Exit Sub
        intCurrentChannel = grdTGID.CurrentRow.Index + 1

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t As Integer
        t = 0

    End Sub



    Private Sub grdConvChan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdConvChan.CellClick
        If grdConvChan.RowCount > 0 Then
            intCurrentChannel = grdConvChan.CurrentRow.Index + 1
        End If
    End Sub



    Private Sub chkSimpleView_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSimpleView.CheckedChanged
        'This hides various columns in the conventional grid
        'to avoid blowing the user's mind
        Dim intMde As Boolean
        intMde = chkSimpleView.Checked
        SaveSetting("FreeSCAN", "Settings", "ConvSimple", intMde)
        If intMde = True Then
            intMde = False
        Else
            intMde = True
        End If
        grdConvChan_NAC.Visible = intMde
        grdConvChan_AltTone.Visible = intMde
        grdConvChan_AltLevel.Visible = intMde
        grdConvChan_AltColor.Visible = intMde
        grdConvChan_AltPattern.Visible = intMde
        grdConvChan_VolOffset.Visible = intMde
        grdConvChan_NumTag.Visible = intMde
        grdConvChan_RecOut.Visible = intMde
        grdConvChan_Step.Visible = intMde
        'save setting

    End Sub

    Private Sub chkTGIDSimpleView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTGIDSimpleView.Click
        'This hides various columns in the conventional grid
        'to avoid blowing the user's mind
        Dim intMde As Boolean
        intMde = chkTGIDSimpleView.Checked
        SaveSetting("FreeSCAN", "Settings", "TGIDSimple", intMde)
        If intMde = True Then
            intMde = False
        Else
            intMde = True
        End If
        cmbTGIDAlertTone.Visible = intMde
        cmbTGIDAlertLevel.Visible = intMde
        grdTGID_AltColor.Visible = intMde
        grdTGID_AltPat.Visible = intMde
        grdTGID_VolOffset.Visible = intMde
        grdTGID_NumTag.Visible = intMde
        colTapeOut.Visible = intMde
        'save setting

    End Sub

    Private Sub grdTrunkFreq_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTrunkFreq.CellEndEdit
        If blnBusy = True Then Exit Sub
        If blnDebug = False Then On Error Resume Next
        Dim strMsg As String
        Dim objCell As DataGridViewCell
        Dim intParam, intRow, intChan, intBuff As Integer
        intRow = grdTrunkFreq.CurrentCell.RowIndex + 1
        intBuff = 0

        objCell = grdTrunkFreq.CurrentCell
        strMsg = objCell.Value
        Select Case grdTrunkFreq.CurrentCell.ColumnIndex
            Case 0 'freq
                objCell.Value = MakeItKosherFrequency(strMsg)
            Case 1 'LCN
                objCell.Value = MakePositive(Val(strMsg))
            Case 2 'LO
                'doesnt need to be validated
            Case 3 'num tag
                objCell.Value = MakeItKosherNumTag(strMsg)
            Case 4 ' Vol Adj
                'validation not needed
        End Select
        Call ApplyTrunkFreq()
        objCell = Nothing
        'Call LoadData("TRUNKFREQ")
    End Sub

    Private Sub grdTrunkFreq_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles grdTrunkFreq.UserDeletedRow
        Call ApplyTrunkFreq()
        MarkChange()
    End Sub

    Private Sub cmdDeleteTrunkFreq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteTrunkFreq.Click
        Dim intCnt As Integer
        BuildGridArray()
        If IsArray(intGridSel) = False Then Exit Sub
        If WarnDelete Then
            intCnt = MsgBox("Are you sure you want to delete the selected rows?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
            If intCnt = 7 Then Exit Sub 'user selected no
        End If

        For intCnt = UBound(intGridSel) To 0 Step -1
            grdTrunkFreq.Rows.RemoveAt(intGridSel(intCnt))
        Next
        ApplyTrunkFreq()
    End Sub

    Private Sub grdTrunkFreq_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTrunkFreq.CellContentClick

    End Sub

    Private Sub grdTrunkFreq_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTrunkFreq.Click
        If grdTrunkFreq.RowCount > 0 Then
            intCurrentChannel = grdTrunkFreq.CurrentCell.RowIndex + 1
        End If
    End Sub

    Private Sub grdTGID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTGID.Click
        If grdTGID.RowCount > 0 Then
            intCurrentChannel = grdTGID.CurrentCell.RowIndex + 1
        End If
    End Sub




    Private Sub ProfileFileSaveDlg_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ProfileFileSaveDlg.FileOk
        Dim strFIlename As String = ProfileFileSaveDlg.FileName

        If strFIlename = "" Or strFIlename = "*.996" Then Exit Sub

        strCurrFile = strFIlename
        SaveMyFile((strFIlename))
        SetFormCaption()
    End Sub

    Private Sub ExportFileDlg_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ExportFileDlg.FileOk
        blnUserCancel = False
    End Sub

    Private Sub chkTrnAGCA_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTrnAGCA.CheckStateChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 29) = chkTrnAGCA.CheckState
    End Sub

    Private Sub chkTrnAGCD_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTrnAGCD.CheckStateChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 30) = chkTrnAGCD.CheckState
    End Sub

    Private Sub txtTrnNumTag_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTrnNumTag.LostFocus
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 28) = MakeItKosherNumTag(txtTrnNumTag.Text)
        txtTrnNumTag.Text = varSite(intCurrentSys, 0, 0, 28)
    End Sub


    Private Sub txtCnvNumTag_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCnvNumTag.LostFocus
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 28) = MakeItKosherNumTag(txtCnvNumTag.Text)
        txtCnvNumTag.Text = varSite(intCurrentSys, 0, 0, 28)
    End Sub

    Private Sub chkCnvAGCA_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCnvAGCA.CheckStateChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 29) = chkCnvAGCA.CheckState
    End Sub

    Private Sub chkCnvAGCD_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCnvAGCD.CheckStateChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 30) = chkCnvAGCD.CheckState
    End Sub

    Private Sub frmSystemEditor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call mnuExitSaveChanges_Click(mnuExitSaveChanges, New System.EventArgs())

        e.Cancel = True
    End Sub

    Private Sub cmbTrnAltPat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrnAltPat.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        Select Case cmbTrnAltPat.Text
            Case "On"
                varSite(intCurrentSys, 0, 0, 52) = "0"
            Case "Slow"
                varSite(intCurrentSys, 0, 0, 52) = "1"
            Case "Fast"
                varSite(intCurrentSys, 0, 0, 52) = "2"

        End Select

        MarkChange()
    End Sub

    Private Sub cmbTrnAltCol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrnAltCol.SelectedIndexChanged
        If blnBusy Then Exit Sub
        varSite(intCurrentSys, 0, 0, 51) = UCase(cmbTrnAltCol.Text)
        MarkChange()
    End Sub

    Private Sub cmbTrnP25Wait_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrnP25Wait.SelectedIndexChanged
        If blnBusy Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 61) = cmbTrnP25Wait.Text
        MarkChange()
    End Sub

    Private Sub cmbCnvP25Wait_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCnvP25Wait.SelectedIndexChanged
        If blnBusy Then Exit Sub
        varSite(intCurrentSys, 0, 0, 31) = cmbCnvP25Wait.Text
        MarkChange()
    End Sub

    Private Sub grdTGID_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTGID.CurrentCellChanged
        If blnBusy Then Exit Sub
        '  Call grdTGID_CellEndEdit(Nothing, Nothing)'should this be needed?
    End Sub


    Private Sub grdTGID_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTGID.CellValueChanged


        If blnBusy Then Exit Sub


        If blnDebug = False Then On Error Resume Next
        Dim strMsg As String
        Dim intParam, intRow, intChan, intBuff As Integer
        Dim ArrayIndex As Integer
        BuildGridArray()
        If IsArray(intGridSel) = False Then Exit Sub

        For ArrayIndex = 0 To UBound(intGridSel)

            intRow = intGridSel(ArrayIndex) + 1
            intBuff = 0
            intChan = GetRealChan(intCurrentSys, intCurrentGroup, intRow)
            strMsg = grdTGID(grdTGID.CurrentCell.ColumnIndex, grdTGID.CurrentCell.RowIndex).Value

            Select Case grdTGID.CurrentCell.ColumnIndex
                Case 0 'display
                    ChanInfo(intChan, 1) = MakeItKosher(strMsg)
                    strMsg = ChanInfo(intChan, 1)
                Case 1 'TGID
                    If strMsg = ".0" Then strMsg = "i0"
                    ChanInfo(intChan, 2) = MakeItKosher(strMsg)
                    strMsg = ChanInfo(intChan, 2)
                Case 2 ' L/O
                    ChanInfo(intChan, 3) = MakeBinary((strMsg))
                Case 3 'priority
                    ChanInfo(intChan, 8) = MakeBinary(strMsg)
                Case 4 'alert tone
                    ChanInfo(intChan, 4) = strMsg
                Case 5 'alert level
                    ChanInfo(intChan, 5) = strMsg
                Case 6 ' alert colour
                    ChanInfo(intChan, 20) = UCase(strMsg)
                Case 7 ' alert light pattern
                    Select Case strMsg
                        Case "On"
                            ChanInfo(intChan, 21) = "0"
                        Case "Slow"
                            ChanInfo(intChan, 21) = "1"
                        Case "Fast"
                            ChanInfo(intChan, 21) = "2"
                    End Select

                Case 8 'volume offset
                    ChanInfo(intChan, 22) = strMsg
                Case 9 'audio type
                    Select Case strMsg
                        Case "All"
                            ChanInfo(intChan, 6) = "0"
                        Case "Analog Only"
                            ChanInfo(intChan, 6) = "1"
                        Case Else
                            ChanInfo(intChan, 6) = "2"
                    End Select
                Case 10 'number tag
                    If IsNumeric(strMsg) = False Or Len(strMsg) = 0 Then
                        ChanInfo(intChan, 19) = "NONE"
                    Else
                        intBuff = MakePositive(Val(strMsg))
                        If intBuff > 999 Then
                            intBuff = 999
                        End If
                        ChanInfo(intChan, 19) = intBuff
                    End If
                Case 11 'tape out
                    ChanInfo(intChan, 7) = MakeBinary(strMsg)
                Case 12 'comment
                    ChanInfo(intChan, 14) = MakeItKosherSilent(strMsg, 3)
            End Select
            Call LoadTrunkChanGridRow(intRow - 1, intChan)
        Next ArrayIndex
        MarkChange()

    End Sub

    Private Sub grdConvChan_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdConvChan.CellValueChanged

        If blnBusy = True Then Exit Sub
        If blnDebug = False Then On Error Resume Next
        Dim strMsg As String
        Dim intParam, intRow, intChan, intBuff As Integer
        Dim ArrayIndex As Integer
        BuildGridArray()
        If Not IsArray(intGridSel) Then Exit Sub

        For ArrayIndex = 0 To UBound(intGridSel)

            intRow = intGridSel(ArrayIndex) + 1
            intBuff = 0
            intChan = GetRealChan(intCurrentSys, intCurrentGroup, intRow)
            strMsg = grdConvChan(grdConvChan.CurrentCell.ColumnIndex, grdConvChan.CurrentCell.RowIndex).Value
            Select Case grdConvChan.CurrentCell.ColumnIndex
                Case 0 'display
                    ChanInfo(intChan, 1) = MakeItKosher(strMsg)
                    strMsg = ChanInfo(intChan, 1)
                Case 1 'TGID
                    ChanInfo(intChan, 2) = MakeItKosherFrequency(strMsg)
                    strMsg = ChanInfo(intChan, 2)
                Case 2 ' L/O
                    ChanInfo(intChan, 5) = MakeBinary(strMsg)
                Case 3 'ctcss tone
                    ChanInfo(intChan, 9) = MakeItKosherCTCSS(strMsg)
                    ChanInfo(intChan, 12) = "1"
                Case 4 ' TONE LO
                    ChanInfo(intChan, 11) = MakeBinary(strMsg)
                Case 5 'ATT
                    ChanInfo(intChan, 6) = MakeBinary(strMsg)
                Case 6 ' PRI
                    ChanInfo(intChan, 7) = MakeBinary(strMsg)
                Case 7 'step size
                    ChanInfo(intChan, 19) = RevStepLookup(CStr(Val(strMsg) * 100))
                Case 8 'MOD MODE
                    ChanInfo(intChan, 4) = MakeItKosherModMode(strMsg)
                Case 9 'NAC
                    If UCase(strMsg) = "SEAR" Then strMsg = "SRCH"
                    ChanInfo(intChan, 15) = MakeItKosherNAC(strMsg)
                    'change audio type to digital only if nac is specificied
                    If ChanInfo(intChan, 15) <> "" Then
                        ChanInfo(intChan, 12) = "2"
                        ChanInfo(intChan, 9) = "0"
                    End If
                Case 10 'audio type
                    Select Case strMsg
                        Case "All"
                            ChanInfo(intChan, 12) = "0"
                            ChanInfo(intChan, 9) = "0"
                        Case "Analog Only"
                            ChanInfo(intChan, 12) = "1"
                        Case Else                   'digital only
                            ChanInfo(intChan, 12) = "2"
                            ChanInfo(intChan, 9) = "0"
                    End Select

                Case 11 'alert tone
                    ChanInfo(intChan, 8) = strMsg
                Case 12 'alert level
                    ChanInfo(intChan, 13) = strMsg
                Case 13 ' alert colour
                    ChanInfo(intChan, 17) = UCase(strMsg)
                Case 14 ' alert light pattern
                    Select Case strMsg
                        Case "On"
                            ChanInfo(intChan, 18) = "0"
                        Case "Slow"
                            ChanInfo(intChan, 18) = "1"
                        Case "Fast"
                            ChanInfo(intChan, 18) = "2"
                    End Select
                Case 15 'volume offset
                    ChanInfo(intChan, 20) = strMsg
                Case 16 'number tag
                    ChanInfo(intChan, 16) = MakeItKosherNumTag(strMsg)
                Case 17 'tape out
                    ChanInfo(intChan, 3) = MakeBinary(strMsg)
                Case 18 'comment
                    ChanInfo(intChan, 14) = MakeItKosherSilent(strMsg, 3)
            End Select
            Call LoadGridRow(intRow - 1, intChan)
        Next ArrayIndex
        MarkChange()

    End Sub


    Private Sub grdAPCO_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAPCO.CellEndEdit
        'commit all settings to memory
        Dim strFreq(15) As String, strSpacing(15) As String
        Dim lngSpace As Double
        If Not blnDebug Then On Error Resume Next
        Dim cnt As Integer
        For cnt = 0 To 15
            strFreq(cnt) = MakeItKosherFrequency(grdAPCO(1, cnt).Value)
            strSpacing(cnt) = grdAPCO(2, cnt).Value
            lngSpace = Val(strSpacing(cnt)) / 0.125
            If lngSpace >= 1 And lngSpace <= 1024 And lngSpace = Int(lngSpace) Then
                'were ok, do nothing
            Else
                strSpacing(cnt) = "1.00"
            End If
        Next
        varSite(intCurrentSys, intCurrentGroup, 0, 30) = Join(strFreq, ",")
        varSite(intCurrentSys, intCurrentGroup, 0, 31) = Join(strSpacing, ",")
        Call LoadData("APCOBP")
        DispStat("APCO Band Plan saved.")
        MarkChange()
    End Sub


    Private Sub cmdTGIDGpsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTGIDGpsEdit.Click
        Me.Enabled = False
        Call LoadGPS(varSite(intCurrentSys, intCurrentGroup, 0, 6), varSite(intCurrentSys, intCurrentGroup, 0, 7), varSite(intCurrentSys, intCurrentGroup, 0, 8))
        frmGPS.Visible = True
        frmGPS.Activate()
    End Sub

    Private Sub chkTGIDGpsEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTGIDGpsEnabled.CheckedChanged
        If blnBusy Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 9) = chkTGIDGpsEnabled.CheckState
    End Sub

    Private Sub chkCnvGrpGPS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCnvGrpGPS.CheckedChanged
        If blnBusy Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 9) = chkCnvGrpGPS.CheckState
    End Sub

    Private Sub cmdCnvGrpGPSEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCnvGrpGPSEdit.Click
        Call cmdTGIDGpsEdit_Click(Nothing, Nothing)
    End Sub

    Private Sub cmbTrnSysQK_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrnSysQK.SelectedIndexChanged
        If blnBusy Then Exit Sub
        If blnDebug Then On Error Resume Next
        Dim intSite As Integer, strQK As String
        Dim intResponse As String
        strQK = cmbTrnSysQK.Text
        If cmbTrnSysQK.SelectedIndex <> 0 Then
            intResponse = MsgBox("Changing this will affect the Quick Key of all sites under this system. Do you wish to continue?", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Change all site QKs?")
            If intResponse = 1 Then 'go ahead
                For intSite = 1 To MaxGroups
                    If varSite(intCurrentSys, intSite, 0, 5) = "3" Then 'this is a trunk site
                        varSite(intCurrentSys, intSite, 0, 2) = strQK
                    End If
                Next
                If mnuShowQK.Checked Then
                    DrawSystemTree()
                End If
            End If
        End If
    End Sub

    Private Sub mnuMoveCut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuMoveCut.Click

        intCurrentSys = intDraggedSysNum
        intCurrentGroup = intDraggedSiteNum
        intCurrentChannel = 0
        blnSkipRedraw = True
        Call mnuCutChannel_Click(Nothing, Nothing)
        intCurrentSys = intTargetSys
        intCurrentGroup = 0
        blnSkipRedraw = False
        Call mnuPasteChannel_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuMoveCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuMoveCopy.Click

        intCurrentSys = intDraggedSysNum
        intCurrentGroup = intDraggedSiteNum
        intCurrentChannel = 0
        blnSkipRedraw = True
        Call mnuCopyChannel_Click(Nothing, Nothing)
        intCurrentSys = intTargetSys
        intCurrentGroup = 0
        blnSkipRedraw = False
        Call mnuPasteChannel_Click(Nothing, Nothing)
    End Sub

    Private Sub _cmdToolBar_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call mnuFilePrint_Click(Nothing, Nothing)
    End Sub



    Private Sub chkTrnSysProtect_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTrnSysProtect.CheckStateChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 32) = chkTrnSysProtect.CheckState
    End Sub



    Private Sub chkCnvSysProtect_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCnvSysProtect.CheckStateChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 32) = chkCnvSysProtect.CheckState
    End Sub

    Private Sub mnuPopUpCon_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles mnuPopUpCon.Closed
        Me.ContextMenuStrip = Nothing
    End Sub


    Private Sub chkTrnPriScan_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTrnPriScan.CheckStateChanged
        If blnBusy = True Then Exit Sub
        varSite(intCurrentSys, 0, 0, 54) = chkTrnPriScan.CheckState
    End Sub

    Private Sub mnuTreeSortName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTreeSortName.Click
        'sort by name
        Dim ThisMenu As Object
        ThisMenu = mnuTreeSortName
        If ThisMenu.Checked Then Exit Sub
        ThisMenu.Checked = True
        mnuTreeSortQK.Checked = False
        mnuTreeSortType.Checked = False
        mnuTreeSortNone.Checked = False
        SaveSetting("FreeSCAN", "Settings", "SortOrder", "0") '0=name.1=QK,2=TYPE,3=NONE
        DrawSystemTree()
    End Sub

    Private Sub mnuTreeSortQK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTreeSortQK.Click
        'sort by QK
        Dim ThisMenu As Object
        ThisMenu = mnuTreeSortQK
        If ThisMenu.Checked Then Exit Sub
        ThisMenu.Checked = True
        mnuTreeSortName.Checked = False
        mnuTreeSortType.Checked = False
        mnuTreeSortNone.Checked = False
        SaveSetting("FreeSCAN", "Settings", "SortOrder", "1") '0=name.1=QK,2=TYPE,3=NONE
        DrawSystemTree()
    End Sub

    Private Sub mnuTreeSortType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTreeSortType.Click
        'sort by QK
        Dim ThisMenu As Object
        ThisMenu = mnuTreeSortType
        If ThisMenu.Checked Then Exit Sub
        ThisMenu.Checked = True
        mnuTreeSortName.Checked = False
        mnuTreeSortQK.Checked = False
        mnuTreeSortNone.Checked = False
        SaveSetting("FreeSCAN", "Settings", "SortOrder", "2") '0=name.1=QK,2=TYPE,3=NONE
        DrawSystemTree()
    End Sub

    Private Sub mnuTreeSortNone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTreeSortNone.Click
        'sort by QK
        Dim ThisMenu As Object
        ThisMenu = mnuTreeSortNone
        If ThisMenu.Checked Then Exit Sub
        ThisMenu.Checked = True
        mnuTreeSortName.Checked = False
        mnuTreeSortType.Checked = False
        mnuTreeSortQK.Checked = False
        SaveSetting("FreeSCAN", "Settings", "SortOrder", "3") '0=name.1=QK,2=TYPE,3=NONE
        DrawSystemTree()
    End Sub
    Function GetGroupArray(ByVal intSys As Integer, ByVal SortMode As String) As Object
        'Returns an array of groups, sorted for drawing the system tree
        If Not blnDebug Then On Error Resume Next
        Dim j, i, intParam, best_j As Integer
        Dim GrpOrder(MaxGroups, 4) As String  ' 0=Index, 1=Name, 2=QK, 3=Type (short string MOT2)
        Dim intGrpIndex As Integer = 0
        Dim intGrpCnt As Integer = -1
        Dim best_value(5) As String
        Dim intGrp As Integer
        For intGrp = 1 To MaxGroups
            If varSite(intSys, intGrp, 0, 5) = "1" Or varSite(intSys, intGrp, 0, 5) = "2" Then 'Normal groups
                intGrpCnt += 1
                GrpOrder(intGrpCnt, 0) = intGrp
                GrpOrder(intGrpCnt, 1) = varSite(intSys, intGrp, 0, 1)
                GrpOrder(intGrpCnt, 2) = varSite(intSys, intGrp, 0, 2) 'qk
                If GrpOrder(intGrpCnt, 2) = "." Or GrpOrder(intGrpCnt, 2) = Nothing Then GrpOrder(intGrpCnt, 2) = CStr((1 + intGrpCnt) * -1)
                GrpOrder(intGrpCnt, 3) = "ZZZ"
            ElseIf varSite(intSys, intGrp, 0, 5) = "3" Then
                intGrpCnt += 1
                GrpOrder(intGrpCnt, 0) = intGrp
                GrpOrder(intGrpCnt, 1) = varSite(intSys, intGrp, 0, 1)
                GrpOrder(intGrpCnt, 2) = varSite(intSys, intGrp, 0, 2) 'qk
                If GrpOrder(intGrpCnt, 2) = "." Then GrpOrder(intGrpCnt, 2) = CStr((1 + intGrpCnt) * -1)
                GrpOrder(intGrpCnt, 3) = SiteType(Val(varSite(intSys, intGrp, 0, 9)), 1)

            End If
        Next
        'Next, sort the array
        'Sorting algorithem
        If SortMode <> "3" And intGrpCnt > 0 Then 'sort the grporder array
            For i = 0 To intGrpCnt
                For intParam = 0 To 4
                    best_value(intParam) = GrpOrder(i, intParam)
                    best_j = i
                Next intParam
                For j = i + 1 To intGrpCnt
                    Select Case SortMode
                        Case "0" 'name
                            If Trim(UCase(GrpOrder(j, 1))) < Trim(UCase(best_value(1))) Then
                                For intParam = 0 To 4
                                    best_value(intParam) = GrpOrder(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                        Case "1" 'QK
                            If Val(GrpOrder(j, 2)) < Val(best_value(2)) Then
                                For intParam = 0 To 4
                                    best_value(intParam) = GrpOrder(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                        Case "2" 'TYPE
                            If GrpOrder(j, 3) < best_value(3) Then
                                For intParam = 0 To 4
                                    best_value(intParam) = GrpOrder(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                    End Select
                Next j
                For intParam = 0 To 4
                    GrpOrder(best_j, intParam) = GrpOrder(i, intParam)
                    GrpOrder(i, intParam) = best_value(intParam)
                Next intParam
            Next i
        End If
        GrpOrder(0, 4) = CStr(intGrpCnt) 'how many groups/sites will we need?
        GetGroupArray = GrpOrder
    End Function
    Function GetSysArray(ByVal SortMode As String) As Object
        'returns an object showing what order the
        'systems need to be drawn in the tree in
        Dim SysOrder(MaxSystems, 4) As String ' 0=Index, 1=Name, 2=QK, 3=Type (short string MOT2)
        Dim intSysCnt, x As Integer
        Dim intSysIndex As Integer = 0
        Dim intGroup As Integer
        Dim Sys1Name, Sys2Name As String
        Dim j, i, intParam, best_j As Integer
        Dim best_value(5) As String
        intSysCnt = -1
        For x = 1 To MaxSystems
            If varSite(x, 0, 0, 3) <> "" Then
                'build the array for sorting
                intSysCnt += 1
                SysOrder(intSysCnt, 0) = x
                SysOrder(intSysCnt, 1) = varSite(x, 0, 0, 1) 'name
                If varSite(x, 0, 0, 3) = "1" Then
                    SysOrder(intSysCnt, 2) = varSite(x, 0, 0, 4) 'conventional system qk
                Else
                    'for trunked system, grab the lowest available site QK
                    SysOrder(intSysCnt, 2) = "100"
                    For intGroup = 1 To MaxGroups
                        If varSite(x, intGroup, 0, 5) = "3" Then
                            If Val(varSite(x, intGroup, 0, 2)) < Val(SysOrder(intSysCnt, 2)) And varSite(x, intGroup, 0, 2) <> "." Then

                                SysOrder(intSysCnt, 2) = varSite(x, intGroup, 0, 2)
                            End If
                        End If
                    Next
                    If SysOrder(intSysCnt, 2) = "0" Then SysOrder(intSysCnt, 2) = "-1"
                End If
                SysOrder(intSysCnt, 3) = SysType(Val(varSite(x, 0, 0, 3)), 1) 'type
            End If
        Next x

        'Sorting algorithem
        If SortMode <> "3" And intSysCnt > 0 Then 'sort the sysorder array
            For i = 0 To intSysCnt
                For intParam = 0 To 3
                    best_value(intParam) = SysOrder(i, intParam)
                    best_j = i
                Next intParam
                For j = i + 1 To intSysCnt
                    Select Case SortMode
                        Case 0 'name
                            Sys1Name = Trim(UCase(SysOrder(j, 1)))
                            Sys2Name = Trim(UCase(best_value(1)))
                            If Sys1Name < Sys2Name Then
                                For intParam = 0 To 3
                                    best_value(intParam) = SysOrder(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                        Case 1 'QK
                            If Val(SysOrder(j, 2)) < Val(best_value(2)) Then
                                For intParam = 0 To 3
                                    best_value(intParam) = SysOrder(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                        Case 2 'TYPE
                            If SysOrder(j, 3) < best_value(3) Then
                                For intParam = 0 To 3
                                    best_value(intParam) = SysOrder(j, intParam)
                                Next intParam
                                best_j = j
                            End If
                    End Select
                Next j
                For intParam = 0 To 3
                    SysOrder(best_j, intParam) = SysOrder(i, intParam)
                    SysOrder(i, intParam) = best_value(intParam)
                Next intParam
            Next i
        End If
        SysOrder(0, 4) = CStr(intSysCnt)
        GetSysArray = SysOrder

    End Function

    Private Sub mnuHighlightTrunkSys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHighlightTrunkSys.Click
        With mnuHighlightTrunkSys
            If .Checked = False Then
                .Checked = True
            Else
                .Checked = False
            End If
            SaveSetting("FreeSCAN", "Settings", "mnuHighlightTrunkSys", .CheckState)
        End With
        DrawSystemTree()
    End Sub

    Private Sub BandplanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BandplanToolStripMenuItem.Click
        frmBandPlan.LoadGrid()
        frmBandPlan.Visible = True
    End Sub

    Private Sub frmSystemEditor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If frmSplash.Visible Then
            frmSplash.Visible = False
        End If
    End Sub

    Private Sub grdReband_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdReband.CellValueChanged
        Call EncodeRebandGrid()
    End Sub

    Private Sub cmbSiteState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSiteState.SelectedIndexChanged
        'State changed
        If blnBusy Then Exit Sub
        varSite(intCurrentSys, intCurrentGroup, 0, 32) = cmbSiteState.SelectedIndex
        MarkChange()
    End Sub

    Private Sub cmbConvState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConvState.SelectedIndexChanged
        'State changed
        If blnBusy Then Exit Sub
        varSite(intCurrentSys, 0, 0, 33) = cmbConvState.SelectedIndex
        MarkChange()
    End Sub


    Private Sub NewSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSystemToolStripMenuItem.Click
        Call mnuCreateNewSystem_Click()
    End Sub

    Private Sub NewSiteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewSiteToolStripMenuItem.Click
        If NewSiteToolStripButton2.Enabled Then
            Call CreateNewSite()
        Else
            MsgBox("Unable to create a new site. You may be attempting to add a site to a conventional system.")
        End If
    End Sub

    Private Sub NewGroupToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewGroupToolStripMenuItem.Click
        Call mnuCreateGroup_Click()
    End Sub

    Private Sub InsertChannelToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles InsertChannelToolStripMenuItem.Click
        If grdTGID.Visible Then
            Call cmdNewTGID_Click(Nothing, Nothing)
        ElseIf grdConvChan.Visible Then
            Call cmdNewConvChannel_Click(Nothing, Nothing)
        ElseIf grdTrunkFreq.Visible Then
            Call cmdNewTrunkFreq_Click(Nothing, Nothing)
        Else
            MsgBox("Please select a group before trying to insert a channel.")
        End If
    End Sub

    Private Sub DeleteChannelToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteChannelToolStripMenuItem.Click
        If grdTGID.Visible Then
            Call cmdDelTGID_Click(Nothing, Nothing)
        ElseIf grdConvChan.Visible Then
            Call cmdDeleteConvChan_Click(Nothing, Nothing)
        ElseIf grdTrunkFreq.Visible Then
            Call cmdDeleteTrunkFreq_Click(Nothing, Nothing)
        Else
            MsgBox("Please select a group before trying to insert a channel.")
        End If
    End Sub



    Private Sub PreferencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreferencesToolStripMenuItem.Click
        frmFSSetup.LoadData()
        frmFSSetup.Visible = True
    End Sub

    Private Sub txtP25NacSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtP25NacSearch.KeyPress
        If e.KeyChar = vbCr Then
            txtTrnNumTag.SelectNextControl(txtTrnNumTag, True, False, False, False)
        End If
    End Sub

    Private Sub txtP25NacSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtP25NacSearch.LostFocus
        'Validate the data and exit
        'For P25 Nac search, valid for P25 One Freq Trunk systems only
        Dim sP25 As String = txtP25NacSearch.Text
        sP25 = UCase(sP25)
        If sP25 <> varSite(intCurrentSys, 0, 0, 53) Then
            MarkChange()
        End If
        If sP25 = "SRCH" Then
            varSite(intCurrentSys, 0, 0, 53) = sP25

        ElseIf sP25 = "0" Or sP25 = "000" Then
            varSite(intCurrentSys, 0, 0, 53) = sP25

        ElseIf sP25 = "" Then
            varSite(intCurrentSys, 0, 0, 53) = "SRCH"

        ElseIf HexToDec(sP25) = 0 Then 'BAD USER!
            sP25 = "SRCH"
            varSite(intCurrentSys, 0, 0, 53) = sP25
            MsgBox("Invalid input. Enter P25 search option in hex (from 0-FFF) or enter SRCH.", vbCritical)

        ElseIf HexToDec(sP25) > 4095 Then
            MsgBox("Invalid input. Enter P25 search option in hex (from 0-FFF) or enter SRCH.", vbCritical)
            sP25 = "SRCH"
            varSite(intCurrentSys, 0, 0, 53) = sP25
        Else

            varSite(intCurrentSys, 0, 0, 53) = MakeItKosherNAC(sP25)
        End If
        txtP25NacSearch.Text = varSite(intCurrentSys, 0, 0, 53)
    End Sub




    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Call mnuFilePrint_Click(mnuFilePrint, New System.EventArgs())
    End Sub



    Private Sub NewToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton1.Click
        Call mnuFileNew_Click(mnuFileNew, New System.EventArgs())
    End Sub

    Private Sub OpenToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton1.Click
        Call mnuFileOpen_Click(mnuFileOpen, New System.EventArgs())
    End Sub

    Private Sub SaveToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton1.Click
        Call mnuFileSave_Click(mnuFileSave, New System.EventArgs())
    End Sub

    Private Sub PrintToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton1.Click
        Call mnuFilePrint_Click(mnuFilePrint, New System.EventArgs())
    End Sub

    Private Sub UploadScannerToolStripButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UploadScannerToolStripButton4.Click
        Call mnuToolsUL_Click(Nothing, Nothing)
    End Sub



    Private Sub CopyToolStripButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyToolStripButton1.Click
        Call mnuCopyChannel_Click(Nothing, Nothing)
    End Sub

    Private Sub CutToolStripButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CutToolStripButton1.Click
        Call mnuCutChannel_Click(Nothing, Nothing)
    End Sub

    Private Sub DownloadScannerToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadScannerToolStripButton5.Click
        Call mnuToolsDL_Click(Nothing, Nothing)
    End Sub

    Private Sub ControlScannerToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlScannerToolStripButton6.Click
        Call mnuToolsControl_Click(Nothing, Nothing)
    End Sub


    Private Sub NewSysToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSysToolStripButton1.Click
        Call mnuCreateNewSystem_Click()
    End Sub

    Private Sub NewSiteToolStripButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewSiteToolStripButton2.Click
        Call CreateNewSite()
    End Sub

    Private Sub NewGroupToolStripButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewGroupToolStripButton3.Click
        Call mnuCreateGroup_Click()
    End Sub

    Private Sub PasteToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton1.Click
        Call mnuPasteChannel_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuEditSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditSelectAll.Click
        'Selects all in a grid
        Dim VisGrid As DataGridView
        If grdConvChan.Visible Then
            VisGrid = grdConvChan
        ElseIf grdTrunkFreq.Visible Then
            VisGrid = grdTrunkFreq
        ElseIf grdTGID.Visible Then
            VisGrid = grdTGID
        Else
            DispStat("Nothing to select")
            Exit Sub
        End If

        With VisGrid
            .SelectAll()
        End With
    End Sub

    Private Sub LetsDoItToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LetsDoItToolStripMenuItem.Click
        frmGPSSummary.Visible = True
        frmGPSSummary.ReadyForm()
        frmGPSSummary.Focus()
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved

        If Me.Visible Then
            SaveSetting("FreeSCAN", "Settings", "PanelWidth", Str(SplitContainer1.SplitterDistance))
        End If
    End Sub
End Class