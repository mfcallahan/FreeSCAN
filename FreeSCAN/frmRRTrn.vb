Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmRRTrn
    Inherits System.Windows.Forms.Form
    Dim strCountry(300, 3) As String '0=coid,  1=full name, 2=country code
    Dim strProvince(100, 4) As String '0=stid, 1=prov name, 2=state_code
    Dim strCounty(400, 4) As String '0=county ctid, 1=name, 2=type, 0=normal 1=independentent
    Dim strCntAgency(200, 5) As String '0=sid 1=name 2=type 3=flavour 4=full name
    Dim strFleetMap As String
    Dim lngSec As Single 'one second for timer
    Dim strTime As Integer
    Dim blnBusy As Boolean
    Dim TrnSite As String 'entire contents of trunked system
    Dim strSystem(50) As String 'basic system paramters
    Dim strvarSite(1, 29) As String '0=desc/name 1=lat   2=long 3=range 4=mod, 5=groupid, 6=original index,7=1 for splinter, 2=rebanded, 8=notes, 10+=bandplans
    Dim strGroup(1, 4) As String '0=lat,1=lon,2=range,3=name, 4=cid
    Dim strFreq(1, 4) As String ' site num,freq,reserve
    Dim strBandPlan(10, 2) As String
    Dim HybridSys As Boolean
    Dim strPrAgency(1, 5) As String '0=sid, 1=name, 2=flavour, 3=voice, 4=lastupdated, 5=type.
    Dim intSysID As Integer 'system id of new system created
    Dim intDownloadSystemID As Integer
    Dim WebServ As New RRWsdl
    Dim ActiveServ As Object = WebServ
    Dim H1Menu(5) As ToolStripMenuItem
    Function SetSysType(ByVal intType As Integer, ByVal intFlavor As Integer, ByVal intVoice As Integer) As Boolean
        'Sets the system and site type, based on type and flavour from RR
        SetSysType = False
        HybridSys = False
        Dim DispCaution As Boolean = False
        If blnDebug Then
            Console.WriteLine("Type " & intType & "Flavour " & intFlavor)
        End If
        Select Case intType 'system type
            Case "1" 'motorola
                Select Case intFlavor
                    Case "1" 'type 1
                        strSystem(1) = CStr(2)
                        strSystem(2) = CStr(7)
                    Case "2" 'type 2 standard
                        strSystem(1) = CStr(3)
                        strSystem(2) = CStr(1)
                    Case "3" 'type 2i hybrid standard
                        strSystem(1) = CStr(2) 'now handled as a type 2 system??
                        strSystem(2) = CStr(7)
                        HybridSys = True 'hybrids get custom zereod fleetmaps
                        SetSysType = True
                    Case "4" 'type 2 smartzone STANDARD 'vhf uhf, i think
                        strSystem(1) = CStr(3)
                        strSystem(2) = CStr(1)
                    Case "5" 'type 2 analog, sometimes MP25 but sVoice picks that up
                        strSystem(1) = "3"
                        strSystem(2) = "1"
                    Case "20" 'motorola(P25)
                        strSystem(1) = CStr(3)
                        strSystem(2) = CStr(6)
                    Case "23" 'type II VOC standard?
                        strSystem(1) = CStr(3)
                        strSystem(2) = CStr(1)
                    Case "24" 'type 2 smartnet SPLINTER, mabye not?
                        strSystem(1) = CStr(3)
                        strSystem(2) = CStr(1)
                    Case Else 'type 2 smartzone omnlink =STANDARD
                        strSystem(1) = CStr(3)
                        strSystem(2) = CStr(1)
                End Select
            Case "2" 'edacs
                Select Case intFlavor
                    Case "6" 'edacs standard/wide
                        strSystem(1) = CStr(4)
                        strSystem(2) = CStr(10)
                    Case "7" 'standard w/esk???
                        strSystem(1) = CStr(4)
                        strSystem(2) = CStr(10)
                    Case "8" 'edacs networked/narrow
                        strSystem(1) = CStr(4)
                        strSystem(2) = CStr(10)
                    Case "9" 'edacs stan net w/esk (wide)
                        strSystem(1) = CStr(4)
                        strSystem(2) = CStr(10)
                    Case "10" 'edacs narrow"
                        strSystem(1) = CStr(4)
                        strSystem(2) = CStr(9)
                    Case "11" 'edacs narrow
                        strSystem(1) = CStr(4)
                        strSystem(2) = CStr(9)
                    Case "22" 'edacs scat
                        strSystem(1) = CStr(4)
                        strSystem(2) = CStr(11)
                    Case Else 'edacs standard
                        strSystem(1) = CStr(4)
                        strSystem(2) = CStr(10)
                End Select
            Case "3" 'ltr
                'only one type available, dont care about flavour
                strSystem(1) = CStr(6)
                strSystem(2) = CStr(12)
                If intFlavor <> 12 Then
                    DispCaution = True
                End If
            Case "8" 'p25?
                'set type to motorola type II
                strSystem(1) = CStr(3)
                strSystem(2) = CStr(6)
                'intflavor = 30 means Phase 2
                If intFlavor = 30 Then
                    DispCaution = True
                End If
                'set site type to mot P25
            Case Else 'motorola
                'set sys type to M82S
                strSystem(1) = CStr(3)
                strSystem(2) = CStr(1)
                DispCaution = True
        End Select
        lblCaution.Visible = DispCaution
    End Function
    Sub initForm()
        Dim cnt As Integer

        'gets the form ready
        cmbCountry.Items.Clear()
        cmbProvince.Items.Clear()
        cmbCounty.Items.Clear()

        cmbTrnSys.Items.Clear()
        cmbCountry.Enabled = False
        cmbProvince.Enabled = False
        cmbCounty.Enabled = False
        H1Menu(0) = H1
        H1Menu(1) = H2
        H1Menu(2) = H3
        H1Menu(3) = H4
        H1Menu(4) = H5
        cmbTrnSys.Enabled = False '
        lstSite.Items.Clear()
        lstGroup.Items.Clear()
        'grdTGID.Rows.
        txtSysName.Text = ""
        System.Array.Clear(strCountry, 0, strCountry.Length)
        System.Array.Clear(strProvince, 0, strProvince.Length)
        System.Array.Clear(strCounty, 0, strCounty.Length)
        System.Array.Clear(strCntAgency, 0, strCntAgency.Length)
        TrnSite = ""
        Erase strvarSite
        Erase strGroup
        UpdateCount()
        cmdImport.Enabled = False
        'recall username and password
        cnt = CInt(GetSetting("FreeSCAN", "Settings", "Saveinfo", "0"))
        If cnt = CDbl("0") Then
            txtpassword.Text = ""
            chkSavepw.CheckState = System.Windows.Forms.CheckState.Unchecked
        Else
            txtUserName.Text = GetSetting("FreeSCAN", "Settings", "UserName", "")
            txtpassword.Text = GetSetting("FreeSCAN", "Settings", "UserPW", "")
            chkSavepw.CheckState = System.Windows.Forms.CheckState.Checked
        End If

    End Sub
    Sub UpdateCount()
        'draws counts for each category
        _lblCnt_0.Text = ""
        _lblCnt_1.Text = ""
        _lblCnt_2.Text = ""
        lblNumSys.Text = ""
        With cmbCountry
            If .Items.Count > 0 Then
                _lblCnt_0.Text = "[" & .Items.Count & "]"
            Else
                _lblCnt_0.Text = ""
            End If
        End With
        With cmbProvince
            If .Items.Count > 0 Then
                _lblCnt_1.Text = "[" & .Items.Count & "]"
            Else
                _lblCnt_1.Text = ""
            End If
        End With
        With cmbCounty
            If .Items.Count > 0 Then
                _lblCnt_2.Text = "[" & .Items.Count & "]"
            Else
                _lblCnt_2.Text = ""
            End If
        End With
        With cmbTrnSys
            If .Items.Count > 0 Then
                lblNumSys.Text = "[" & .Items.Count & "]"
            Else
                lblNumSys.Text = ""
            End If
        End With
        If cmbTrnSys.SelectedIndex = -1 Then
            lblCaution.Visible = False
            lblGrpSel.Text = Nothing
            lblSiteSel.Text = Nothing
        End If

    End Sub
    Function CountString(ByRef strMain As String, ByRef strSrch As String) As Integer
        'returns how often a string occurs in another string
        If blnDebug = False Then On Error Resume Next
        Dim lngCnt, lngPos, lngNewPos As Integer
        Dim blnEnd As Boolean
        lngPos = 1

        Do Until blnEnd = True


            lngNewPos = InStr(lngPos, strMain, strSrch)
            If lngNewPos = 0 Then
                blnEnd = True
            Else
                lngPos = lngNewPos + 1
                lngCnt = lngCnt + 1
            End If
        Loop

        CountString = lngCnt
    End Function


    Private Sub chkSavepw_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSavepw.CheckStateChanged
        Select Case chkSavepw.CheckState
            Case 0
                SaveSetting("FreeSCAN", "Settings", "SaveInfo", CStr(0))
                SaveSetting("FreeSCAN", "Settings", "UserName", "")
                SaveSetting("FreeSCAN", "Settings", "UserPW", "")
            Case 1
                SaveSetting("FreeSCAN", "Settings", "SaveInfo", CStr(1))
        End Select
    End Sub


    Private Sub cmbTrnSys_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbTrnSys.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        cmdImport.Enabled = False
        lblLastUpdate.Visible = False
        Dim SysName As String
        Dim DashPos As Integer
        With cmbTrnSys
            If .SelectedIndex > -1 Then
                Call DownloadSys("sid", strPrAgency(.SelectedIndex, 0))
            End If
            SysName = strPrAgency(MakePositive(cmbTrnSys.SelectedIndex), 1)
            DashPos = InStr(SysName, "[")
            If DashPos <> 0 Then
                SysName = Strings.Left(SysName, DashPos - 1)
            End If
            If chkCompress.CheckState = 0 Then
                txtSysName.Text = MakeItKosherSilent(SysName, 0)
            Else
                txtSysName.Text = Kompressor(SysName)
            End If

            If strPrAgency(MakePositive(cmbTrnSys.SelectedIndex), 4) <> Nothing Then
                lblLastUpdate.Text = "Last Updated: " & strPrAgency(MakePositive(cmbTrnSys.SelectedIndex), 4)
                lblLastUpdate.Visible = True
            Else
                lblLastUpdate.Visible = False
            End If
        End With

    End Sub


    Private Sub cmbCountry_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCountry.SelectedIndexChanged

        Dim intNumStid, intResponse, intCnt As Integer
        Dim intSL As Integer
        'check for valid logon information
        Dim CInfo As CountryInfo
        If CheckValid() = 0 Then Exit Sub
        If blnBusy = True Then Exit Sub
        If cmbCountry.SelectedIndex = -1 Then Exit Sub
        intSL = Val(strCountry(cmbCountry.SelectedIndex, 0))
        'attempt to grab the list of provinces
        cmbProvince.Items.Clear()
        cmbCounty.Items.Clear()

        cmbTrnSys.Items.Clear()
        lstSite.Items.Clear()
        lstGroup.Items.Clear()
        cmbProvince.Enabled = False
        cmbCounty.Enabled = False
        cmdImport.Enabled = False
        cmbTrnSys.Enabled = False


        Disp("Downloading country list...")
        'assuming that all worked, load everything into the state variable
        Try
            Disp("Getting list of states...")
            CInfo = ActiveServ.getCountryInfo(intSL, varAuthInfo)
            Disp("")
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        System.Array.Clear(strProvince, 0, strProvince.Length)

        intNumStid = SafeUBound(CInfo.stateList)
        If intNumStid = -1 Then
            intResponse = MsgBox("Invalid data returned from RadioReference. Verify you have entered the correct username & password and that your internet connection is available.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            cmbCountry.ResetText()
            Exit Sub
        End If


        If intNumStid > 300 Then intNumStid = 300
        For intCnt = 0 To intNumStid
            'Dump data from the strNet variable into the country variable
            strProvince(intCnt, 0) = CInfo.stateList(intCnt).stid 'state stid
            strProvince(intCnt, 1) = CInfo.stateList(intCnt).stateName  'state name
            strProvince(intCnt, 2) = CInfo.stateList(intCnt).stateCode 'state code
            cmbProvince.Items.Add((lblSiteNote.NoNull(strProvince(intCnt, 1))))
        Next intCnt
        UpdateCount()
        cmbProvince.Enabled = True
        Disp("")
    End Sub


    Private Sub cmbCounty_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCounty.SelectedIndexChanged
        'do two things
        'load up all county agencies
        'load up all county groups
        Dim intNumStid, intCnt As Integer

        Dim intSL As Integer
        Dim strCountyInfo As CountyInfo
        Dim strAgencyList() As TrsListDef

        If blnBusy = True Then Exit Sub
        'check for valid logon information
        Dim i As Integer, intParam As Integer, best_value(10) As String, best_j As Integer, j As Integer

        If CheckValid() = 0 Then Exit Sub
        If cmbCounty.SelectedIndex = -1 Then Exit Sub
        intSL = Val(strCounty(cmbCounty.SelectedIndex, 0))
        cmdImport.Enabled = False
        'attempt to grab the list of counties and province-wide agencies
        cmbTrnSys.Items.Clear()
        lstSite.Items.Clear()
        lstGroup.Items.Clear()
        cmbTrnSys.Enabled = False
        'Grab all the counties first

        'assuming that all worked, load everything into the county variable

        System.Array.Clear(strCntAgency, 0, strCntAgency.Length)
        Try
            strCountyInfo = activeserv.getCountyInfo(intSL, varAuthInfo)
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        strAgencyList = strCountyInfo.trsList

        If IsArray(strAgencyList) = True Then
            intNumStid = UBound(strAgencyList)
        Else
            intNumStid = -1
        End If
        ReDim strPrAgency(intNumStid + 1, 7)
        'assuming that all worked, load everything into the county variable

        System.Array.Clear(strPrAgency, 0, strPrAgency.Length)
        For intCnt = 0 To intNumStid
            'Dump data from the strNet variable into the country variable
            strPrAgency(intCnt, 0) = strAgencyList(intCnt).sid ' sid
            strPrAgency(intCnt, 2) = strAgencyList(intCnt).sFlavor
            strPrAgency(intCnt, 3) = strAgencyList(intCnt).sVoice
            strPrAgency(intCnt, 4) = strAgencyList(intCnt).lastUpdated
            strPrAgency(intCnt, 5) = strAgencyList(intCnt).sType
            strPrAgency(intCnt, 1) = strAgencyList(intCnt).sName & " [" & FindSysDesc(Val(strPrAgency(intCnt, 5)), Val(strPrAgency(intCnt, 2))) & "]" 'name
        Next intCnt

        'sort the list
        For i = 0 To intNumStid - 1
            For intParam = 0 To 5
                best_value(intParam) = strPrAgency(i, intParam)
                best_j = i
            Next intParam
            For j = i + 1 To intNumStid - 2

                If UCase(strPrAgency(j, 1)) < UCase(best_value(1)) Then
                    For intParam = 0 To 5

                        best_value(intParam) = strPrAgency(j, intParam)
                    Next intParam
                    best_j = j
                End If
            Next j
            For intParam = 0 To 5
                strPrAgency(best_j, intParam) = strPrAgency(i, intParam)
                strPrAgency(i, intParam) = best_value(intParam)
            Next intParam
        Next i
        For intCnt = 0 To intNumStid
            cmbTrnSys.Items.Add((lblSiteNote.NoNull(strPrAgency(intCnt, 1))))
        Next intCnt
        cmbTrnSys.Enabled = True
        UpdateCount()
        Disp("")
    End Sub
    Function GetParam(ByVal a As String, ByVal b As String, ByVal d As String, ByVal c As String) As String
        GetParam = Nothing
    End Function
    Function FindSysDesc(ByRef intType As Integer, ByRef intFlav As Integer) As String
        Dim strDesc As String
        strDesc = "Unknown"

        'takes a RR trunk system type number and returns a description
        Select Case intType
            Case "1" 'motorola
                Select Case intFlav
                    Case "1"
                        strDesc = "Mot Type I"
                    Case "3"
                        strDesc = "Mot Type IIi Hybrid"
                    Case Else
                        strDesc = "Mot Type II"
                End Select
            Case "2"
                Select Case intFlav
                    Case "6"
                        strDesc = "EDACS Wide"
                    Case "7"
                        strDesc = "EDACS Wide"
                    Case "8"
                        strDesc = "EDACS Wide"
                    Case "9"
                        strDesc = "EDACS Wide"
                    Case "10"
                        strDesc = "EDACS Narrow"
                    Case Else
                        strDesc = "EDACS Narrow"
                End Select

            Case "3"
                strDesc = "LTR"
            Case "4"
                strDesc = "MPT-1327"
            Case "5"
                strDesc = "TETRA"
            Case "6"
                strDesc = "Midland CMS"
            Case "7"
                strDesc = "OpenSky"
            Case "8"
                strDesc = "APCO P25"
                If intFlav = 30 Then
                    strDesc = "APCO P25 Phase 2 (Untrackable)"
                End If
            Case "9"
                strDesc = "iDEN"
            Case "90"
                strDesc = "Other"
            Case "10"
                strDesc = "SmarTrunk"
            Case Else
                strDesc = "Unknown"
        End Select

        FindSysDesc = strDesc
    End Function
    Sub SortAgencyArray(ByRef intNumStid As Integer)
        If blnDebug = False Then On Error Resume Next
        'Sorts the entire TGID group array by group
        Dim j, i, intParam, best_j As Integer
        Dim best_value(5) As String


        For i = 0 To intNumStid - 1
            For intParam = 0 To 5

                best_value(intParam) = strCntAgency(i, intParam)
                best_j = i
            Next intParam

            For j = i + 1 To intNumStid - 2

                If UCase(strCntAgency(j, 1)) < UCase(best_value(1)) Then
                    For intParam = 0 To 5

                        best_value(intParam) = strCntAgency(j, intParam)
                    Next intParam
                    best_j = j
                End If
            Next j
            For intParam = 0 To 5
                strCntAgency(best_j, intParam) = strCntAgency(i, intParam)

                strCntAgency(i, intParam) = best_value(intParam)
            Next intParam
        Next i




    End Sub
    Sub SortSiteArray()

        If blnDebug = False Then On Error Resume Next
        'Sorts the entire TGID group array by group
        Dim j, i, intParam, best_j As Integer
        Dim best_value(29) As String
        Dim intNumStid As Integer
        intNumStid = Val(strvarSite(0, 0))

        For i = 1 To intNumStid
            For intParam = 0 To 29

                best_value(intParam) = strvarSite(i, intParam)
                best_j = i
            Next intParam
            For j = i + 1 To intNumStid

                If UCase(strvarSite(j, 0)) < UCase(best_value(0)) Then
                    For intParam = 0 To 29

                        best_value(intParam) = strvarSite(j, intParam)
                    Next intParam
                    best_j = j
                End If
            Next j
            For intParam = 0 To 29
                strvarSite(best_j, intParam) = strvarSite(i, intParam)
                strvarSite(i, intParam) = best_value(intParam)
            Next intParam
        Next i
    End Sub


    Private Sub cmbProvince_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbProvince.SelectedIndexChanged

        Dim intNumStid, intResponse, intCnt As Integer

        'check for valid logon information
        Dim intSL As Integer, intCountyCnt As Integer
        Dim j, i, intParam, best_j As Integer
        Dim best_value(5) As String
        Dim strStateInfo As StateInfo, strCountyList() As County
        Dim strAgencyList() As TrsListDef
        If CheckValid() = 0 Then Exit Sub
        If cmbProvince.SelectedIndex = -1 Then Exit Sub
        If blnBusy = True Then Exit Sub
        intSL = Val(strProvince(cmbProvince.SelectedIndex, 0))
        'attempt to grab the list of counties and province-wide agencies
        cmbCounty.Items.Clear()

        cmbTrnSys.Items.Clear()
        lstSite.Items.Clear()
        lstGroup.Items.Clear()
        cmbCounty.Enabled = False
        cmdImport.Enabled = False
        cmbTrnSys.Enabled = False
        'Grab all the counties first
        Disp("Downloading information...")
        Try

            strStateInfo = activeserv.getStateInfo(intSL, varAuthInfo)
            strCountyList = strStateInfo.countyList
            intCountyCnt = UBound(strCountyList)

        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try

        If intCountyCnt = -1 Then
            intResponse = MsgBox("Cannot connect to RadioReference. Verify you have entered the correct username & password and that your internet connection is available.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            Exit Sub
        End If
        'assuming that all worked, load everything into the county variable

        System.Array.Clear(strCounty, 0, strCounty.Length)
        ReDim strCounty(MakePositive(intCountyCnt) + 1, 4)
        For intCnt = 0 To intCountyCnt
            strCounty(intCnt, 0) = strCountyList(intCnt).ctid 'ctid
            strCounty(intCnt, 1) = strCountyList(intCnt).countyName 'name
            strCounty(intCnt, 2) = strCountyList(intCnt).countyHeader 'header??
        Next

        'sort the county
        For i = 0 To intCountyCnt - 1
            For intParam = 0 To 4

                best_value(intParam) = strCounty(i, intParam)
                best_j = i
            Next intParam
            For j = i + 1 To intNumStid - 2
                If UCase(strCounty(j, 1)) < UCase(best_value(1)) Then
                    For intParam = 0 To 4
                        best_value(intParam) = strCounty(j, intParam)
                    Next intParam
                    best_j = j
                End If
            Next j
            For intParam = 0 To 4
                strCounty(best_j, intParam) = strCounty(i, intParam)
                strCounty(i, intParam) = best_value(intParam)
            Next intParam
        Next
        For intCnt = 0 To intCountyCnt
            cmbCounty.Items.Add(lblSiteNote.NoNull((strCounty(intCnt, 1))))
        Next intCnt

        cmbCounty.Enabled = True
        UpdateCount()
        '************************Next grab the province-wide trunk systems
        strAgencyList = strStateInfo.trsList
        If IsArray(strAgencyList) = True Then
            intNumStid = UBound(strAgencyList)
        Else
            intNumStid = -1
        End If
        ReDim strPrAgency(intNumStid + 1, 7)
        'assuming that all worked, load everything into the county variable

        System.Array.Clear(strPrAgency, 0, strPrAgency.Length)
        For intCnt = 0 To intNumStid
            'Dump data from the strNet variable into the country variable
            strPrAgency(intCnt, 0) = strAgencyList(intCnt).sid ' sid
            strPrAgency(intCnt, 2) = strAgencyList(intCnt).sFlavor
            strPrAgency(intCnt, 3) = strAgencyList(intCnt).sVoice
            strPrAgency(intCnt, 4) = strAgencyList(intCnt).lastUpdated
            strPrAgency(intCnt, 5) = strAgencyList(intCnt).sType
            strPrAgency(intCnt, 1) = strAgencyList(intCnt).sName & " [" & FindSysDesc(Val(strPrAgency(intCnt, 5)), Val(strPrAgency(intCnt, 2))) & "]" 'name
        Next intCnt

        'sort the list
        For i = 0 To intNumStid - 1
            For intParam = 0 To 5
                best_value(intParam) = strPrAgency(i, intParam)
                best_j = i
            Next intParam
            For j = i + 1 To intNumStid - 2
                If UCase(strPrAgency(j, 1)) < UCase(best_value(1)) Then
                    For intParam = 0 To 5
                        best_value(intParam) = strPrAgency(j, intParam)
                    Next intParam
                    best_j = j
                End If
            Next j
            For intParam = 0 To 5
                strPrAgency(best_j, intParam) = strPrAgency(i, intParam)
                strPrAgency(i, intParam) = best_value(intParam)
            Next intParam
        Next i
        For intCnt = 0 To intNumStid
            cmbTrnSys.Items.Add(lblSiteNote.NoNull((strPrAgency(intCnt, 1))))
        Next intCnt
        cmbTrnSys.Enabled = True
        UpdateCount()
        Disp("")

    End Sub


    Private Sub cmdCanada_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCanada.Click
        If cmbCountry.Items.Count > 2 Then cmbCountry.SelectedIndex = 37

    End Sub

    Private Sub cmdConnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConnect.Click
        ActiveServ = WebServ
        Dim intNumCoid, intCnt As Integer
        Dim strBuff As String
        'check for valid logon information
        Dim strCountryList() As Country
        varAuthInfo.username = Nothing
        varAuthInfo.password = Nothing
        If CheckValid() = 0 Then Exit Sub
        'save info to registry
        If chkSavepw.CheckState = 1 Then
            SaveSetting("FreeSCAN", "Settings", "UserName", txtUserName.Text)
            SaveSetting("FreeSCAN", "Settings", "UserPW", txtpassword.Text)
        Else
            SaveSetting("FreeSCAN", "Settings", "UserName", "")
            SaveSetting("FreeSCAN", "Settings", "UserPW", "")
        End If
        'attempt to grab the list of countries

        cmbCountry.Items.Clear()
        cmbProvince.Items.Clear()
        cmbCounty.Items.Clear()

        cmbTrnSys.Items.Clear()
        cmbCountry.Enabled = False
        cmbProvince.Enabled = False
        cmbCounty.Enabled = False

        cmbTrnSys.Enabled = False
        Disp("Connecting...")
        'assuming that all worked, load everything into the country variable
        varAuthInfo.username = txtUserName.Text
        varAuthInfo.password = txtpassword.Text
        varAuthInfo.version = "9" 'change this to 8 eventually but will need extensive testing
        varAuthInfo.style = "RPC"
        varAuthInfo.appKey = "" 'Apply for an API key and put it here
        Try
            strBuff = ActiveServ.getUserData(varAuthInfo).subExpireDate
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        If IsDate(strBuff) = False Then
            '   MsgBox("Subscription appears to be invalid or expired. Check your RR account and try again.")
            '   Exit Sub
            '  Disp("Subscription appears to be expired or invalid.")
        Else
            Disp("Subscription expires on " & strBuff)

        End If
        System.Array.Clear(strCountry, 0, strCountry.Length)
        System.Array.Clear(strCountry, 0, strCountry.Length)

        Try
            strCountryList = ActiveServ.getCountryList

        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        intNumCoid = UBound(strCountryList)

        If intNumCoid > 400 Then intNumCoid = 300
        For intCnt = 0 To intNumCoid
            'Dump data from the strNet variable into the country variable
            strCountry(intCnt, 0) = strCountryList(intCnt).coid 'coid
            strCountry(intCnt, 1) = strCountryList(intCnt).countryName 'name
            strCountry(intCnt, 2) = strCountryList(intCnt).countryCode 'country code
            cmbCountry.Items.Add(lblSiteNote.NoNull((strCountry(intCnt, 1))))
        Next intCnt
        UpdateCount()
        cmbCountry.Enabled = True
        If intCnt > 1 Then
            If UseCdnBias Then 'use canadian bias
                cmbCountry.SelectedIndex = RRCANIndex
            Else
                cmbCountry.SelectedIndex = RRUSAIndex
            End If
        End If
        Disp("")
        cmbCountry.Enabled = True
        If lstTag.Items.Count = 0 Or blnDebug Then
            Call PopulateTagList()
        End If
    End Sub
    Sub Disp(ByVal strMsg As String)
        'displays a text onthe bottom to inform the user

        ToolStripStatusLabel1.Text = strMsg
        'displays a text onthe bottom to inform the user
        Dim LogTxt As String
        LogTxt = Format(Now(), "T")
        LogTxt &= " " & strMsg & vbCrLf
        If strMsg <> "" Then
            txtLog.AppendText(LogTxt)
        End If
        My.Application.DoEvents()

    End Sub
    Function CheckValid() As Integer
        'check to see if the login info is valid

        CheckValid = 1 'valid state
        'get out of here if we are just importing from cd
        If varAuthInfo.username = "user" And varAuthInfo.password = "password" Then
            Exit Function
        End If
        Dim intRes As Integer


            If txtUserName.Text = "" Then

                CheckValid = 0
                intRes = MsgBox("Please enter a user name.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            ElseIf txtpassword.Text = "" Then

                CheckValid = 0
                intRes = MsgBox("Please enter a valid password", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            End If

    End Function


    Sub DownloadSys(ByRef strGroupType As String, ByRef strID As String)
        'retrieves sites & TGID groups from a specific system
        'sid=trunked system        Dim strNet As String
        Dim intCnt As Integer
        Dim intCnt1 As Integer
        Dim intSite As Integer
        Dim intFreq As Integer
        Dim strBuff1 As String
        Dim dblCtlChn(1000) As Double
        Dim intBP As Integer
        Dim blnZeroMap As Boolean, intNumGroup As Integer
        'check for valid logon information
        Dim varSiteList() As TrsSite
        Dim varTGCat() As TalkgroupCat
        Dim varSiteBandPlan As Trs
        Dim varSysInfo As Trs
        Dim LastReband As Integer = -1
        If CheckValid() = 0 Then Exit Sub
        'attempt to grab the list of countries
        lstSite.Items.Clear()
        lstGroup.Items.Clear()
        Erase strGroup
        Erase strvarSite
        intDownloadSystemID = Val(strID)
        System.Array.Clear(strBandPlan, 0, strBandPlan.Length)
        TrnSite = ""
        strFleetMap = ""
        If strID = "" Then
            MsgBox("FreeSCAN cannot download information on this system.")
            Exit Sub
        End If
        Try
            Disp("Downloading site list...")
            varSiteList = ActiveServ.getTrsSites(intDownloadSystemID, varAuthInfo)
            Disp("")
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        If IsArray(varSiteList) = False Then
            MsgBox("No sites are available for this system.")
            Exit Sub
        End If
        'setup system type
        Try

            varSysInfo = ActiveServ.getTrsDetails(intDownloadSystemID, varAuthInfo)

            blnZeroMap = SetSysType(varSysInfo.sType, varSysInfo.sFlavor, Nothing)
            'Begin downloading site information
            If IsArray(varSiteList) = False Then ' no sites present
                intSite = -1
            Else
                intSite = UBound(varSiteList)
            End If

        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        ReDim strvarSite(intSite + 2, 29)
        ReDim strFreq(4000, 4)
        For intCnt = 0 To intSite
            strvarSite(intCnt + 1, 0) = varSiteList(intCnt).siteDescr 'name
            strvarSite(intCnt + 1, 8) = varSiteList(intCnt).siteNotes 'site notes
            'BANDPLAN INFO GOES HERE
            If strvarSite(intCnt + 1, 0) = "" Then
                strvarSite(intCnt + 1, 0) = "Site " & intCnt
            End If
            strvarSite(intCnt + 1, 1) = StripDMSDOT(DecToDMS(varSiteList(intCnt).lat, True)) 'latitude
            strvarSite(intCnt + 1, 2) = StripDMSDOT(DecToDMS(varSiteList(intCnt).lon, False)) ' longtitude
            strvarSite(intCnt + 1, 3) = MakeItKosherGPSRange(varSiteList(intCnt).range) 'range
            strvarSite(intCnt + 1, 4) = varSiteList(intCnt).siteModulation

            strvarSite(intCnt + 1, 5) = CreateGroupID()
            strvarSite(intCnt + 1, 6) = intCnt ' original index,m to remain intact after sorting

            'Bandplan, NEW for version 6
            If IsArray(varSiteList(intCnt).bandplan) = True Then
                intBP = 10
                For intCnt1 = 0 To UBound(varSiteList(intCnt).bandplan)
                    strvarSite(intCnt + 1, intBP) = MakeItKosherFreqSilent(varSiteList(intCnt).bandplan(intCnt1).base) 'base
                    strvarSite(intCnt + 1, intBP + 1) = Val(varSiteList(intCnt).bandplan(intCnt1).offset) 'offset
                    strvarSite(intCnt + 1, intBP + 2) = varSiteList(intCnt).bandplan(intCnt1).spacing 'spacing/step
                    intBP += 3
                Next intCnt1
            End If
            If varSiteList(intCnt).splinter <> Nothing Or varSiteList(intCnt).rebanded <> Nothing Then
                intCnt = intCnt
            End If
            If varSiteList(intCnt).rebanded = "1" Then
                strvarSite(intCnt + 1, 7) = "2" 'set site to rebanded
                LastReband = intCnt
            ElseIf varSiteList(intCnt).splinter = "1" Then
                strvarSite(intCnt + 1, 7) = "1" 'set site to splinter mode
            Else
                strvarSite(intCnt + 1, 7) = "0"  'neither
            End If
        Next intCnt
        If intSite >= 0 Then
            Try
                Disp("Downloading trunk radio information...")
                varSiteBandPlan = ActiveServ.getTrsDetails(intDownloadSystemID, varAuthInfo)
                Disp("")
            Catch ex As Exception
                Call RRException(ex.Message)
                Exit Sub
            End Try
            intBP = 0
            intCnt = varSiteBandPlan.sVoice

            If IsArray(varSiteBandPlan.bandplan) = True Then
                For intCnt1 = 0 To UBound(varSiteBandPlan.bandplan)
                    strBandPlan(intBP, 0) = MakeItKosherFreqSilent(varSiteBandPlan.bandplan(intCnt1).base) 'base
                    strBandPlan(intBP, 1) = Val(varSiteBandPlan.bandplan(intCnt1).offset) 'offset
                    strBandPlan(intBP, 2) = varSiteBandPlan.bandplan(intCnt1).spacing 'spacing/step
                    intBP = intBP + 1
                Next intCnt1
            ElseIf LastReband <> -1 Then 'if there is a rebanded system, and no band plan is available, use a default one
                strBandPlan(0, 0) = "REBAND"
            End If
            '************ FLEET MAP IF TYPE I
            If strSystem(1) = "2" And Not HybridSys Then
                strBuff1 = Nothing
                Try
                    With varSiteBandPlan.fleetmap
                        strBuff1 = ConvFleetMap(.b0)
                        strBuff1 &= ConvFleetMap(.b1)
                        strBuff1 &= ConvFleetMap(.b2)
                        strBuff1 &= ConvFleetMap(.b3)
                        strBuff1 &= ConvFleetMap(.b4)
                        strBuff1 &= ConvFleetMap(.b5)
                        strBuff1 &= ConvFleetMap(.b6)
                        strBuff1 &= ConvFleetMap(.b7)
                    End With
                    strFleetMap = strBuff1
                Catch
                    strFleetMap = Nothing
                    strBuff1 = MsgBox("Fleetmap information is not available for this system. As a result, the scanner may not be able to track it properly.", MsgBoxStyle.Exclamation)
                End Try
            ElseIf strSystem(1) = "2" And HybridSys Then
                strFleetMap = "00000000"
            End If
        End If



        '**************************Download TGID groups
        Try
            Disp("Downloading talk group information...")
            varTGCat = ActiveServ.getTrsTalkgroupCats(intDownloadSystemID, varAuthInfo)
            Disp("")
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        If IsArray(varTGCat) = True Then
            intNumGroup = UBound(varTGCat)
            ReDim strGroup(intNumGroup, 4)
            For intCnt = 0 To intNumGroup
                strGroup(intCnt, 0) = StripDMSDOT(DecToDMS(varTGCat(intCnt).lat, True))
                strGroup(intCnt, 1) = StripDMSDOT(DecToDMS(varTGCat(intCnt).lon, False))
                strGroup(intCnt, 2) = MakeItKosherGPSRange(varTGCat(intCnt).range)
                strGroup(intCnt, 3) = varTGCat(intCnt).tgCname
                strGroup(intCnt, 4) = varTGCat(intCnt).tgCid

            Next intCnt

        End If


        strvarSite(0, 0) = CStr(intSite + 1)
        strFreq(0, 0) = CStr(intFreq + 1)
        'strGroup(0, 0) = CStr(intMaxTGID + 1)
        SortGroupArray()
        SortSiteArray()
        ListDownloads()


    End Sub

    Sub SortGroupArray()
        If blnDebug = False Then On Error Resume Next
        'Sorts the entire TGID group array by group
        Dim j, intBuff, i, intParam, best_j As Integer
        Dim best_value(4) As String
        If IsArray(strGroup) = False Then Exit Sub
        If UBound(strGroup) < 2 Then Exit Sub

        For i = 0 To UBound(strGroup)
            For intParam = 0 To 4
                best_value(intParam) = strGroup(i, intParam)
                best_j = i
            Next intParam
            For j = i + 1 To UBound(strGroup) - 1
                If UCase(strGroup(j, 3)) < UCase(best_value(3)) Then
                    For intParam = 0 To 4
                        best_value(intParam) = strGroup(j, intParam)
                    Next intParam
                    best_j = j
                End If
            Next j
            For intParam = 0 To 4
                strGroup(best_j, intParam) = strGroup(i, intParam)
                strGroup(i, intParam) = best_value(intParam)
            Next intParam
        Next i
    End Sub
    Sub ListDownloads()
        'populates listboxes and tgid preview grid with available groups and sites
        Dim intCnt, intSite As Integer
        Dim strBuff As String
        Dim intGrpCnt As Integer
        Dim strGrpName(2000, 1) As String
        Dim SiteNote As String
        If Not blnDebug Then On Error Resume Next
        lstSite.Items.Clear()
        lstGroup.Items.Clear()

        'populate site list
        intCnt = Val(strvarSite(0, 0))
        strBuff = ""
        If intCnt = 0 Then
            'intCnt = MsgBox("No sites could be found in this system. Possible error?", MsgBoxStyle.OkOnly + MsgBoxStyle.Question)
        Else
            For intSite = 1 To intCnt
                strBuff = strvarSite(intSite, 6)
                If strvarSite(intSite, 8) <> Nothing Then
                    SiteNote = "*"
                Else
                    SiteNote = Nothing
                End If
                If strvarSite(intSite, 0) <> "" Then
                    lstSite.Items.Add(lblSiteNote.NoNull(strvarSite(intSite, 0) & SiteNote))
                Else
                    lstSite.Items.Add("Unnamed Site" & SiteNote)
                    strvarSite(intSite, 0) = "Unnamed Site"
                End If
                lstSite.SetItemChecked(intSite - 1, True)
            Next intSite
        End If
        Call lstSite_SelectedIndexChanged(Nothing, Nothing)
        'populate group list
        lstGroup.Items.Clear()
        If IsArray(strGroup) = True Then
            intGrpCnt = UBound(strGroup)
            For intCnt = 0 To intGrpCnt
                If strGroup(intCnt, 3) <> "" Then
                    lstGroup.Items.Add(strGroup(intCnt, 3), True)
                Else
                    lstGroup.Items.Add("Unnamed Group", True)
                End If
            Next intCnt
        End If
        Call lstGroup_SelectedIndexChanged1(lstSite, New System.EventArgs())
        cmdImport.Enabled = True
    End Sub


    Function RRToneLookUp(ByRef strTone As String) As Integer
        'gets an RR tone and returns a tone index for storage
        Dim strBuff As String
        Dim intTone, cnt As Integer
        intTone = 0

        If strTone = "CSQ" Then

            RRToneLookUp = 0
            Exit Function
        End If

        strBuff = CStr(Val(strTone))



        If InStr(strTone, "DPL") > 0 Then
            For cnt = 128 To 231
                If InStr(CTCSS(cnt), strBuff) <> 0 Then 'found the tone
                    intTone = cnt
                    cnt = 231
                End If
            Next cnt
        Else
            For cnt = 64 To 127
                If InStr(CTCSS(cnt), strBuff) <> 0 Then 'found the tone
                    intTone = cnt
                    cnt = 127
                End If
            Next cnt
        End If

        RRToneLookUp = intTone
    End Function

    Function RRModLookup(ByRef strMod As String) As Integer
        'gets an RR mod code and converts to a freesan mode index

        strMod = Val(strMod)
        Select Case strMod
            Case "1" 'fm

                RRModLookup = 1
            Case "3" 'am

                RRModLookup = 3
            Case "4" 'fmn

                RRModLookup = 2
            Case Else

                RRModLookup = 0
        End Select
    End Function




    Sub CreateImportSys()
        'creates a default system for importing groups

        lblSiteNote.blnSkipGroup = True

        intSysID = GetFreeSysNum()
        If intSysID = -1 Then

            Exit Sub
        End If
        intCurrentSys = intSysID
        lblSiteNote.MakeNewTrunkSystem(("2"))
        lblSiteNote.blnSkipGroup = False

        varSite(intSysID, 0, 0, 1) = MakeItKosher((txtSysName.Text))
    End Sub




    Private Sub H1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles H1.Click
        Call RecallHist("0")
    End Sub

    Private Sub H2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H2.Click
        Call RecallHist("1")
    End Sub

    Private Sub H3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3.Click
        Call RecallHist("2")
    End Sub

    Private Sub H4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H4.Click
        Call RecallHist("3")
    End Sub

    Private Sub H5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H5.Click
        Call RecallHist("4")
    End Sub
    Sub RecallHist(ByVal strID As String)
        'Loads an item references in history
        If Not blnDebug Then On Error Resume Next
        Dim strKey As String
        Dim KeyArray() As String
        Dim x As Integer
        strKey = GetSetting("FreeSCAN", "Settings", "Key" & strID, "-1,-1,-1")
        If cmbCountry.Items.Count = 0 Then
            cmdConnect_Click(cmdConnect, New System.EventArgs())
        End If
        KeyArray = Split(strKey, ",")
        If IsArray(KeyArray) Then
            If UBound(KeyArray) = 2 Then
                If cmbCountry.Items.Count >= Val(KeyArray(0)) Then
                    cmbCountry.SelectedIndex = Val(KeyArray(0))
                End If
                If cmbProvince.Items.Count >= Val(KeyArray(1)) Then
                    cmbProvince.SelectedIndex = Val(KeyArray(1))
                End If
                If cmbCounty.Items.Count >= Val(KeyArray(2)) Then
                    cmbCounty.SelectedIndex = Val(KeyArray(2))
                End If
            End If
        End If

    End Sub
    Private Sub cmdJumpHome_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdJumpHome.Click
        If blnDebug = False Then On Error Resume Next
        'retrieves home settings and applies them
        Dim intProv, intCntry, intCnty As Integer
        intCntry = Val(GetSetting("FreeSCAN", "Settings", "HomeCountry", CStr(cmbCountry.SelectedIndex)))
        intProv = Val(GetSetting("FreeSCAN", "Settings", "HomeProvince", CStr(cmbProvince.SelectedIndex)))
        intCnty = Val(GetSetting("FreeSCAN", "Settings", "HomeCounty", CStr(cmbCounty.SelectedIndex)))
        If cmbCountry.Items.Count = 0 Then
            cmdConnect_Click(cmdConnect, New System.EventArgs())
        End If
        If cmbCountry.Items.Count >= intCntry Then
            cmbCountry.SelectedIndex = intCntry
        End If
        If cmbProvince.Items.Count >= intProv Then
            cmbProvince.SelectedIndex = intProv
        End If
        If cmbCounty.Items.Count >= intCnty Then
            cmbCounty.SelectedIndex = intCnty
        End If
    End Sub

    Private Sub cmdSaveHome_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSaveHome.Click
        'SAVES THE CURRENT location as the home location
        If blnDebug = False Then On Error Resume Next '
        SaveSetting("FreeSCAN", "Settings", "HomeCountry", CStr(cmbCountry.SelectedIndex))
        SaveSetting("FreeSCAN", "Settings", "HomeProvince", CStr(cmbProvince.SelectedIndex))
        SaveSetting("FreeSCAN", "Settings", "HomeCounty", CStr(cmbCounty.SelectedIndex))
        Dim xt As String
        xt = "Home is where the heart is"
        xt = CStr(MsgBox("Home location saved.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Settings Saved"))
    End Sub

    Private Sub cmdSignUp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSignUp.Click
        Dim ShellCode As String
        ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", "http://www.radioreference.com/apps/register/", "", "", 1))

        frmRRCon.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub cmdSiteChkAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) ' Handles cmdSiteChkAll.Click

        Dim intitem As Integer
        With lstSite
            For intitem = 0 To .Items.Count - 1
                .SetItemChecked(intitem, True)
            Next intitem
        End With

    End Sub

    Private Sub cmdViewBrowse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdViewBrowse.Click
        'loads the current select system in the browser
        Dim intSysID As Integer
        Dim ShellCode, strSite As String
        Dim SrcRoot As String
        strSite = Nothing
        If varAuthInfo.version = "3" Then
            SrcRoot = "http://127.0.0.1:9000/"
        Else
            SrcRoot = "http://www.radioreference.com/apps/db/"
        End If
        If cmbTrnSys.SelectedIndex >= 0 Then 'province wide agency
            intSysID = CInt(strPrAgency(cmbTrnSys.SelectedIndex, 0))

            If intSysID < 1 Then
                MsgBox("Sorry, but no system is currently available for viewing.")
                Exit Sub
            End If
            strSite = SrcRoot & "?sid=" & intSysID
        End If
        If strSite <> "" Then
            ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", strSite, "", "", 1))
        End If
    End Sub

    Private Sub frmRRTrn_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ReDim strFreq(0, 0)
        ReDim strvarSite(0, 0)
        ReDim strGroup(0, 0)
        cmbQK.Items.Clear()
        Dim cnt As Integer
        cmbQK.Items.Add(("."))
        For cnt = 0 To 99
            cmbQK.Items.Add(CStr(cnt))
        Next cnt
        cmbQK.SelectedIndex = 0
        LoadHistory()
    End Sub



    Private Sub cmdChkNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChkNone.Click
        Dim intitem As Integer
        With lstSite
            For intitem = 0 To .Items.Count - 1
                .SetItemChecked(intitem, False)
            Next intitem
        End With
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGroupChkAll.Click
        Dim intitem As Integer
        With lstGroup
            For intitem = 0 To .Items.Count - 1
                .SetItemChecked(intitem, True)
            Next intitem
        End With
        Call lstGroup_SelectedIndexChanged1(Nothing, Nothing)
    End Sub

    Private Sub cmdGroupChkNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGroupChkNone.Click
        Dim intitem As Integer
        With lstGroup
            For intitem = 0 To .Items.Count - 1
                .SetItemChecked(intitem, False)
            Next intitem
        End With
        Call lstGroup_SelectedIndexChanged1(Nothing, Nothing)
    End Sub

    Private Sub cmdFindFree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindFree.Click
        If blnDebug = False Then On Error Resume Next

        cmbQK.Text = FindFreeQK()
    End Sub

    Private Sub lstGroup_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstGroup.SelectedIndexChanged
        If blnDebug = False Then On Error Resume Next
        Dim intCnt, intTGID, intNonSel As Integer
        intCnt = lstGroup.CheckedItems.Count
        lblGrpSel.Text = intCnt & " out of 20 (max) groups selected."
        If intCnt > 20 Then
            lblGrpSel.ForeColor = Color.Red
        Else
            lblGrpSel.ForeColor = Color.Black
        End If
    End Sub
    Function ConvFleetMap(ByVal strBuff As String) As String
        ConvFleetMap = "!00"
        If strBuff = "2" Then
            ConvFleetMap = "!00"
        ElseIf strBuff = "O" Then
            ConvFleetMap = "!14"
        ElseIf Asc(strBuff) >= 65 And Asc(strBuff) <= 79 Then
            ConvFleetMap = "!" & Format(Asc(strBuff) - 64, "00")
        ElseIf strBuff = "Q" Then
            ConvFleetMap = "!14"
        End If
    End Function

    Private Sub lstSite_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstSite.MouseMove
        If Not blnDebug Then On Error Resume Next
        Dim MousePositionInClientCoords As Point = Me.lstSite.PointToClient(Control.MousePosition)
        Dim indexUnderTheMouse As Integer = Me.lstSite.IndexFromPoint(MousePositionInClientCoords)
        If indexUnderTheMouse > -1 Then
            Call Disp(strvarSite(indexUnderTheMouse + 1, 8))


        End If
    End Sub

    Private Sub lstSite_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSite.SelectedIndexChanged
        lblSiteSel.Text = lstSite.CheckedItems.Count & " selected."
    End Sub

    Private Sub ClearAllHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllHistoryToolStripMenuItem.Click
        'Erases history
        If Not blnDebug Then On Error Resume Next
        Dim x As Integer
        x = MsgBox("Are you sure you want to delete the history?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete history?")
        If x = 6 Then
            'erase all history
            For x = 0 To 4
                SaveSetting("FreeSCAN", "Settings", "Hist" & CStr(x), "")
                SaveSetting("FreeSCAN", "Settings", "Key" & CStr(x), "")
            Next
            'Reload the history menu
            LoadHistory()
        End If
    End Sub
    Sub LoadHistory()
        'loads the recent file list
        Dim strBuff(4) As String
        Dim intCnt As Integer
        strBuff(0) = GetSetting("FreeSCAN", "Settings", "Hist0", "")
        strBuff(1) = GetSetting("FreeSCAN", "Settings", "Hist1", "")
        strBuff(2) = GetSetting("FreeSCAN", "Settings", "Hist2", "")
        strBuff(3) = GetSetting("FreeSCAN", "Settings", "Hist3", "")
        strBuff(4) = GetSetting("FreeSCAN", "Settings", "Hist4", "")
        For intCnt = 0 To 4
            H1Menu(intCnt).Visible = False
            If strBuff(intCnt) <> "" Then
                H1Menu(intCnt).Text = "&" & (intCnt + 1) & "  " & strBuff(intCnt)
                H1Menu(intCnt).Visible = True
            End If
        Next intCnt

    End Sub
    Sub PopulateTagList()
        'This downloads the tag list, and saves to the registery and the lstTag
        'list box
        '  Dim cnt As Integer
        Dim TagList() As tag
        Dim MaxTag As Integer
        Dim TagCnt As Integer
        Dim strbuff As String

        blnBusy = True
        Try
            If varAuthInfo.version = "3" Then
                Exit Try
            End If
            Disp("Downloading channel tag list...")
            TagList = ActiveServ.getTag(Nothing, varAuthInfo)
            If IsArray(TagList) Then
                TagCnt = UBound(TagList)
                lstTag.Items.Clear()
                If TagCnt <> 0 Then
                    ReDim SkipTag(TagCnt, 3)
                    strbuff = GetSetting("FreeSCAN", "Settings", "SkipTag", Nothing)
                    For MaxTag = 0 To TagCnt
                        SkipTag(MaxTag, 0) = MakeItKosherSilent(TagList(MaxTag).tagDescr, 2)
                        SkipTag(MaxTag, 2) = TagList(MaxTag).tagId
                        If InStr(strbuff, "!" & SkipTag(MaxTag, 0) & "!", CompareMethod.Binary) <> 0 Then
                            SkipTag(MaxTag, 1) = "1" 'Is  selected
                        Else
                            SkipTag(MaxTag, 1) = "0" 'Is not selected
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        Disp("")
        'Sort the tag array
        SortSkipTagArray()

        'Next, select the ones we already skipped
        lstTag.Items.Clear()
        frmRRCon.lstTag.Items.Clear()
        blnBusy = False
        If TagCnt = 0 Then
            Exit Sub
        End If
        For MaxTag = 0 To TagCnt
            lstTag.Items.Add(SkipTag(MaxTag, 0))
            frmRRCon.lstTag.Items.Add(SkipTag(MaxTag, 0))
            If SkipTag(MaxTag, 1) = "1" Then
                lstTag.SetItemChecked(MaxTag, True)
                frmRRCon.lstTag.SetItemChecked(MaxTag, True)
            End If
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cnt As Integer
        Dim TagList() As tag
        Dim MaxTag As Integer
        Dim strbuff As String
        ' For cnt = 0 To 50
        TagList = activeserv.getTag(Nothing, varAuthInfo)
        strbuff = Nothing
        If IsArray(TagList) Then

            For MaxTag = 0 To UBound(TagList)
                strbuff &= TagList(MaxTag).tagDescr
            Next
            Disp(strbuff)

        End If
        ' Next cnt
        cnt = cnt

    End Sub
    Sub SortSkipTagArray()

        If blnDebug = False Then On Error Resume Next
        'Sorts the entire TGID group array by group
        Dim j, i, intParam, best_j As Integer
        Dim best_value(3) As String
        Dim intNumStid As Integer
        intNumStid = UBound(SkipTag)

        For i = 1 To intNumStid
            For intParam = 0 To 3
                best_value(intParam) = SkipTag(i, intParam)
                best_j = i
            Next intParam
            For j = i + 1 To intNumStid

                If UCase(SkipTag(j, 0)) < UCase(best_value(0)) Then
                    For intParam = 0 To 3

                        best_value(intParam) = SkipTag(j, intParam)
                    Next intParam
                    best_j = j
                End If
            Next j
            For intParam = 0 To 3
                SkipTag(best_j, intParam) = SkipTag(i, intParam)
                SkipTag(i, intParam) = best_value(intParam)
            Next intParam
        Next i
    End Sub

    'Private Sub lstTag_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lstTag.ItemCheck

    '    End Sub
    Sub SaveSkipTagSelection()
        'After the user makes a change to what tags they want to skip
        'save it to the registry
        'and update the SkipTag variable

        Dim Cnt As Integer, sBuff As String
        If blnBusy Then Exit Sub
        sBuff = " "
        If lstTag.Items.Count = 0 Then
            Exit Sub
        Else
            For Cnt = 0 To lstTag.Items.Count - 1
                If lstTag.GetItemCheckState(Cnt) = CheckState.Checked Then
                    SkipTag(Cnt, 1) = "1"
                    sBuff &= "!" & SkipTag(Cnt, 0) & "!"
                Else
                    SkipTag(Cnt, 1) = "0"
                End If
            Next
        End If
        SaveSetting("FreeSCAN", "Settings", "SkipTag", sBuff)

    End Sub

    Private Sub lstTag_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstTag.KeyUp
        Call SaveSkipTagSelection()
    End Sub

    Private Sub lstTag_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstTag.MouseUp
        Call SaveSkipTagSelection()
    End Sub

    Private Sub lstTag_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTag.SelectedValueChanged

    End Sub
    Function TagSkip(ByVal sTag() As FreeSCAN.tag) As Boolean
        'Checks the TAG information for a channel
        'Return true if this is a tag that the user doesn't want
        If Not blnDebug Then On Error Resume Next
        Dim cnt, TagCnt As Integer
        TagSkip = False
        If IsArray(sTag) = False Then Exit Function
        For TagCnt = 0 To UBound(sTag)
            For cnt = 0 To UBound(SkipTag)
                If SkipTag(cnt, 2) = sTag(TagCnt).tagId And SkipTag(cnt, 1) = "1" Then
                    TagSkip = True
                End If
            Next
        Next TagCnt
    End Function


    Private Sub cmdImport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        'import frequencies into freescan

        cmdImport.Enabled = False
        Dim varSiteList() As TrsSite
        Dim strBuff(5) As String
        Dim intChan, intGrp, intSite As Integer
        Dim blnDone, blnMemFault As Boolean
        ' Dim intTFreq, intMaxFreq As Integer
        Dim intTGIDGrp, intMaxObj, intTGIDcnt As Integer
        ' Dim blnMemFull As Boolean
        Dim intGrpCnt As Integer, dblSampFreq As Double
        Dim intBP As Short, intRRIndex As Integer
        Dim intNumFreq As Integer, intCnt1, intFreq As Integer
        Dim varTGID() As Talkgroup, intLastGrp As Integer
        Dim blnCtlChan As Boolean
        Dim intCtlCnt As Integer = 0
        Dim dblCtlChn(1000) As Double
        Dim iSkipDigital, iSkipEnc, iSkipTag As Integer
        iSkipDigital = 0
        iSkipEnc = 0
        iSkipTag = 0
        intCurrentSys = 0
        intCurrentGroup = 0
        intCurrentChannel = 0
        CreateImportSys()
        If intSysID = -1 Then Exit Sub
        'insert code here for maximum memory
        'generate system
        If chkCompress.CheckState = 1 Then
            varSite(intSysID, 0, 0, 1) = MakeItKosherSilent(Kompressor((txtSysName.Text)), 0)
        Else
            varSite(intSysID, 0, 0, 1) = MakeItKosherSilent((txtSysName.Text), 0)
        End If
        'system type
        varSite(intSysID, 0, 0, 3) = strSystem(1)

        'generate sites
        intMaxObj = lstSite.Items.Count
        intGrpCnt = 0
        For intGrp = 0 To lstSite.Items.Count - 1
            If lstSite.GetItemChecked(intGrp) = True Then
                intGrpCnt = intGrpCnt + 1
            End If
        Next intGrp
        If intGrpCnt > 256 Then
            MsgBox("This scanner cannot handle more than 256 sites per system. As a result, only the first 256 chosen sites will be imported")
        End If
        If intGrpCnt = 0 Then
            MsgBox("Select at least one site before importing.")
            cmdImport.Enabled = True
            Exit Sub
        End If
        intGrpCnt = 0
        Try
            Disp("Please wait... Downloading site information")
            varSiteList = ActiveServ.getTrsSites(intDownloadSystemID, varAuthInfo)
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        'Save to history
        strBuff(0) = cmbProvince.Text & " - " & cmbCounty.Text
        strBuff(1) = cmbCountry.SelectedIndex & "," & cmbProvince.SelectedIndex & "," & cmbCounty.SelectedIndex
        frmRRCon.SaveHistory(strBuff(0), strBuff(1))
        For intGrp = 1 To lstSite.Items.Count
            If lstSite.GetItemChecked(intGrp - 1) = True And blnMemFault = False And intGrpCnt <= 256 Then
                'create the site
                With lblSiteNote
                    .blnSkipGroup = True
                    .CreateNewSite()
                    .blnSkipGroup = False
                End With
                intSite = intCurrentGroup
                intGrpCnt = intGrpCnt + 1

                'set site paramters
                blnDone = False
                If chkCompress.CheckState = 1 Then 'site name
                    varSite(intSysID, intSite, 0, 1) = MakeItKosherSilent(Kompressor(strvarSite(intGrp, 0)), 0)
                Else
                    varSite(intSysID, intSite, 0, 1) = MakeItKosherSilent(strvarSite(intGrp, 0), 0)
                End If

                'quickkey
                If OptQK0.Checked = True Then 'do not assign a QK
                    varSite(intSysID, intSite, 0, 2) = "."
                ElseIf OptQK1.Checked = True Then  'assign a manual quick key
                    varSite(intSysID, intSite, 0, 2) = cmbQK.Text
                ElseIf OptQK2.Checked = True Then  'automatically assign a free QK

                    varSite(intSysID, intSite, 0, 2) = FindFreeQK()
                End If
                varSite(intSysID, intSite, 0, 8) = CStr(chkConCh.CheckState) 'control channel by default
                'is this a combined control channel site? if so turn on control channel only mode
                If strvarSite(intGrp, 0) = "*COMBINED CC" Then
                    varSite(intSysID, intSite, 0, 8) = "1"
                End If
                'site band plan
                If strBandPlan(0, 0) <> "REBAND" And strvarSite(intGrp, 10) = Nothing Then
                    'This site doesn't have its own band plan, so use the general system one
                    For intBP = 0 To 6
                        Call SaveBPParam(intSysID, intSite, 0, intBP, CStr(Val(strBandPlan(intBP, 0)) * 10000)) 'base
                        Call SaveBPParam(intSysID, intSite, 2, intBP, CStr(Val(strBandPlan(intBP, 2)) * 100)) 'step
                        Call SaveBPParam(intSysID, intSite, 3, intBP, CStr(Val(strBandPlan(intBP, 1)))) 'offset
                    Next intBP
                    Call AutoCalcUpper(intSysID, intSite, True) 'calculate upper frequencies
                ElseIf strvarSite(intGrp, 10) <> 0 Then
                    'This site has its own bandplan, so import that instead
                    intCnt1 = 0
                    For intBP = 10 To 25 Step 3
                        Call SaveBPParam(intSysID, intSite, 0, intCnt1, CStr(Val(strvarSite(intGrp, intBP)) * 10000)) 'base
                        Call SaveBPParam(intSysID, intSite, 3, intCnt1, CStr(Val(strvarSite(intGrp, intBP + 1)))) 'offset
                        Call SaveBPParam(intSysID, intSite, 2, intCnt1, CStr(Val(strvarSite(intGrp, intBP + 2)) * 100)) 'step
                        intCnt1 += 1
                    Next intBP
                    Call AutoCalcUpper(intSysID, intSite, True) 'calculate upper frequencies
                ElseIf strBandPlan(0, 0) = "REBAND" Then
                    Call SaveBPParam(intSysID, intSite, 0, 0, "8510250") 'base
                    Call SaveBPParam(intSysID, intSite, 1, 0, "8540000") 'base
                    Call SaveBPParam(intSysID, intSite, 2, 0, "2500") 'step
                    Call SaveBPParam(intSysID, intSite, 3, 0, "440") 'offset
                    Call SaveBPParam(intSysID, intSite, 0, 1, "8510125") 'base
                    Call SaveBPParam(intSysID, intSite, 1, 1, "8689875") 'base
                    Call SaveBPParam(intSysID, intSite, 2, 1, "2500") 'step
                    Call SaveBPParam(intSysID, intSite, 3, 1, "0") 'offset
                End If


                'GPS Stuff
                varSite(intSysID, intSite, 0, 13) = strvarSite(intGrp, 1) 'latitude
                varSite(intSysID, intSite, 0, 14) = strvarSite(intGrp, 2) 'longtitude
                varSite(intSysID, intSite, 0, 15) = strvarSite(intGrp, 3) 'range
                'GPS Enable
                'Enable GPS by default if desired
                If chkGPSDefault.Checked And Val(strvarSite(intGrp, 1)) <> 0 And Val(strvarSite(intGrp, 1)) <> 0 Then
                    varSite(intSysID, intSite, 0, 16) = "1"
                End If
                'site frequencies

                intRRIndex = strvarSite(intGrp, 6)
                If IsArray(varSiteList(intRRIndex).siteFreqs) Then
                    intNumFreq = UBound(varSiteList(intRRIndex).siteFreqs)
                Else
                    intNumFreq = -1
                End If
                'Site notes
                varSite(intSysID, intSite, 0, 28) = MakeItKosherSilent(strvarSite(intGrp, 8), 3)
                For intCnt1 = 0 To intNumFreq
                    If intChan < 0 Then
                        blnMemFault = True
                        intCnt1 = intNumFreq
                    ElseIf Val(varSiteList(intRRIndex).siteFreqs(intCnt1).freq) > 0 Then
                        strBuff(0) = varSiteList(intRRIndex).siteFreqs(intCnt1).use
                        If strBuff(0) = "a" Or strBuff(0) = "d" Then
                            blnCtlChan = True
                        ElseIf strSystem(1) <> "2" And strSystem(1) <> "3" Then ' bypass cc only mode for non mot systems
                            blnCtlChan = True
                        Else
                            blnCtlChan = False
                        End If

                        If chkCtlOnly.Checked = False Or chkCtlOnly.Checked = True And blnCtlChan Then
                            intChan = InsertTrunkFreq(varSite(intSysID, intSite, 0, 10))
                            If intChan > -1 Then
                                strTrunkFreq(intChan, 0) = MakeItKosherFreqSilent(varSiteList(intRRIndex).siteFreqs(intCnt1).freq) 'set frequency
                                If dblSampFreq = 0 Then
                                    dblSampFreq = Val(strTrunkFreq(intChan, 0))
                                End If
                                strTrunkFreq(intChan, 1) = MakePositive(varSiteList(intRRIndex).siteFreqs(intCnt1).lcn) 'LCN
                                intFreq = intFreq + 1
                            ElseIf blnDebug Then
                                MsgBox("Invalid trunk frequency intChan. FrmTRn - cmdImport")

                            End If

                        Else
                            'wipe out the inserted trunk frequency
                            ' strTrunkFreq(intChan, 2) = Nothing
                        End If
                        '**CC COMBINED 

                        '                        If blnCtlChan Then 'is this a control channel
                        ' If intCtlCnt < 1000 Then
                        ' dblCtlChn(intCtlCnt) = CDbl(strFreq(intFreq, 1))
                        ' intCtlCnt = intCtlCnt + 1
                        'End If
                        'End If

                        End If
                Next intCnt1
                'set site type
                If intFreq > 0 And strSystem(1) = "3" And strSystem(2) <> "13" And strSystem(2) <> "6" And strSystem(2) <> "2" Then 'if this is a type II vhf system reconsider
                    If dblSampFreq < 300 Then 'vhf band
                        strSystem(2) = CStr(4)
                    ElseIf CDbl(dblSampFreq) < 600 Then  'uhf band
                        strSystem(2) = CStr(5)
                    ElseIf CDbl(dblSampFreq) < 900 Then
                        strSystem(2) = CStr(1) ' 800Mhz band
                    Else
                        strSystem(2) = CStr(3) '900Mhz band
                    End If
                End If
                'set reband/splinter flags
                If strSystem(1) = "3" And strSystem(2) <> "6" Then 'motorola type II
                    If strvarSite(1, 7) = "1" Then 'splinter sys
                        strSystem(2) = "2"
                    ElseIf strvarSite(1, 7) = "2" Then 'rebanded sys
                        strSystem(2) = "13"
                        If strBandPlan(0, 0) <> "REBAND" Then
                            AutoCalcUpper(intSysID, intSite, True)
                        End If
                    End If
                ElseIf strSystem(1) = "2" Then 'mot type i
                    If strvarSite(1, 7) = "1" Then 'splinter sys
                        strSystem(2) = "8"
                    ElseIf strvarSite(1, 7) = "2" Then 'rebanded sys
                        strSystem(2) = "16"
                        If strBandPlan(0, 0) <> "REBAND" Then
                            AutoCalcUpper(intSysID, intSite, True)
                        End If
                    End If
                End If
                varSite(intSysID, intSite, 0, 9) = strSystem(2)
            End If
            'always reset this to zero incase two different sites have different ranges (400mhz & 800mhz in one sys)
            dblSampFreq = 0

        Next intGrp '*************************** END SITE LOOP


        'generate groups
        intMaxObj = lstGroup.Items.Count
        intGrpCnt = lstGroup.CheckedItems.Count
        strBuff(2) = Nothing
        If intGrpCnt > 20 Then
            strBuff(3) = "You have selected more than 20 groups, which is the maximum this scanner can support. Would you like FreeSCAN to try and compress all the selected groups within the 20 groups? Answering No here would cause groups after 20 to not get imported."
            strBuff(2) = MsgBox(strBuff(3), MsgBoxStyle.YesNoCancel) 'yes=6 no=7
        End If

        If strBuff(2) = "2" Then
            cmdImport.Enabled = True
            Exit Sub 'user has selected cancel
        End If
        intGrpCnt = 0

        For intGrp = 1 To lstGroup.Items.Count
            If lstGroup.GetItemChecked(intGrp - 1) = True Then
                If intGrpCnt >= 20 Then 'at the 20 group limit, either abort or pack on
                    If strBuff(2) = "6" Then 'compress all t he groups
                        intSite = intLastGrp 'set the current group to the last good known group
                    Else
                        intSite = 0 'do not import this group
                    End If
                Else
                    intSite = GetFreeGroupNum(intSysID)
                    intLastGrp = intSite
                    strBuff(0) = strGroup(intGrp - 1, 3)

                    If chkCompress.CheckState = 1 Then
                        varSite(intSysID, intSite, 0, 1) = MakeItKosher(Kompressor(strBuff(0)))
                    Else
                        varSite(intSysID, intSite, 0, 1) = MakeItKosher(strBuff(0))
                    End If
                End If
                If intSite > 0 Then
                    intGrpCnt = intGrpCnt + 1
                    strBuff(5) = (strGroup(intGrp - 1, 4))
                    Try
                        Disp("Downloading information for " & strBuff(0))
                        varTGID = ActiveServ.getTrsTalkgroups(intSysID, Val(strBuff(5)), 0, 0, varAuthInfo)
                        'Disp("")
                    Catch ex As Exception
                        Call RRException(ex.Message)
                        Exit Sub
                    End Try
                    'create trunk group
                    varSite(intSysID, intSite, 0, 2) = "." 'quick key
                    varSite(intSysID, intSite, 0, 3) = CStr(0) 'no lockout
                    If varSite(intSysID, intSite, 0, 10) = "" Then

                        varSite(intSysID, intSite, 0, 10) = CreateGroupID()
                    End If
                    varSite(intSysID, intSite, 0, 5) = CStr(2)
                    'download gps stuff
                    varSite(intSysID, intSite, 0, 6) = strGroup(intGrp - 1, 0) 'latitude
                    varSite(intSysID, intSite, 0, 7) = strGroup(intGrp - 1, 1) 'longtitude
                    varSite(intSysID, intSite, 0, 8) = strGroup(intGrp - 1, 2) 'range
                    'GPS Enable
                    'Enable GPS by default if desired
                    If chkGPSDefault.Checked And Val(strGroup(intGrp - 1, 0)) <> 0 And Val(strGroup(intGrp - 1, 1)) <> 0 Then
                        varSite(intSysID, intSite, 0, 9) = "1"
                    End If
                    'find all the channels with this group and import them
                    intTGIDGrp = 0

                    For intChan = 0 To UBound(varTGID)
                        'decide if the channel needs to be skipped or not
                        strBuff(1) = "-1"
                        If varTGID(intChan).tgMode = "D" And chkSkipDig.CheckState = 1 Then
                            'skip importing
                            iSkipDigital += 1
                        ElseIf varTGID(intChan).tgMode = "E" And chkSkipENc.CheckState = 1 Then
                            'skip importing an encrypted channel
                            iSkipEnc += 1
                        ElseIf varTGID(intChan).tgMode = "E" And chkSkipDig.CheckState = 1 Then
                            'again skip importing it
                            iSkipDigital += 1
                        ElseIf TagSkip(varTGID(intChan).tags) = True Then
                            'belongs to a skip tag
                            iSkipTag += 1
                        Else
                            strBuff(1) = InsertChan(varSite(intSysID, intSite, 0, 10), False)
                        End If

                        If strBuff(1) <> "-1" Then
                            intTGIDcnt = intTGIDcnt + 1
                            'chkdisp=use disp rather than desc
                            'chkdesccomm.value = save longer channel names
                            'chkcompress compress long names
                            If chkDisp.CheckState = 1 And varTGID(intChan).tgAlpha <> "" Then 'import display rather than description
                                ChanInfo(Val(strBuff(1)), 1) = varTGID(intChan).tgAlpha 'display
                                ChanInfo(Val(strBuff(1)), 14) = MakeItKosherSilent(varTGID(intChan).tgDescr, 3) 'put desc in comment
                            Else
                                ChanInfo(Val(strBuff(1)), 1) = varTGID(intChan).tgDescr
                            End If
                            If chkDescComm.CheckState = 1 And Len(ChanInfo(Val(strBuff(1)), 1)) > 16 Then 'copy channel name into desc
                                ChanInfo(Val(strBuff(1)), 14) = MakeItKosherSilent(ChanInfo(Val(strBuff(1)), 1), 3)
                            End If
                            If chkCompress.CheckState = 1 Then
                                ChanInfo(Val(strBuff(1)), 1) = Kompressor(ChanInfo(Val(strBuff(1)), 1))
                            Else
                                ChanInfo(Val(strBuff(1)), 1) = MakeItKosher(ChanInfo(Val(strBuff(1)), 1))
                            End If
                            'if we are importing alpha tags, and there is no comment, but a long desc, then put the long desc in the comment lol
                            If chkDisp.CheckState = 1 And ChanInfo(Val(strBuff(1)), 14) = Nothing Then
                                ChanInfo(Val(strBuff(1)), 14) = MakeItKosherSilent(varTGID(intChan).tgDescr, 3)
                                'but if its the same bloody thing then just forget about it and blank it out
                                If ChanInfo(Val(strBuff(1)), 14) = ChanInfo(Val(strBuff(1)), 1) Then
                                    ChanInfo(Val(strBuff(1)), 14) = Nothing
                                End If
                            End If
                            If strSystem(2) <> 12 Then
                                ChanInfo(Val(strBuff(1)), 2) = MakeItKosherSilent(varTGID(intChan).tgDec, 0) 'save tgid
                                If ChanInfo(Val(strBuff(1)), 2) = "0" And varTGID(intChan).tgSubfleet <> "0" And varTGID(intChan).tgSubfleet <> Nothing Then
                                    ChanInfo(Val(strBuff(1)), 2) = MakeItKosherSilent(varTGID(intChan).tgSubfleet, 0)
                                End If
                            Else
                                'format for LTR
                                strBuff(0) = MakeItKosherSilent(varTGID(intChan).tgDec, 0)
                                strBuff(0) = Format(Val(strBuff(0)), "0-00-000")
                                ChanInfo(Val(strBuff(1)), 2) = strBuff(0)
                            End If
                            'set mode
                            Select Case UCase(varTGID(intChan).tgMode)
                                Case "D" 'set it to digital only
                                    ChanInfo(Val(strBuff(1)), 6) = CStr(2)
                                Case "E"
                                    ChanInfo(Val(strBuff(1)), 6) = CStr(2)
                                Case "A" 'set to analog only
                                    ChanInfo(Val(strBuff(1)), 6) = CStr(1)
                                Case Else
                                    ChanInfo(Val(strBuff(1)), 6) = CStr(0)
                            End Select
                            'set alert tones and junk
                            ChanInfo(Val(strBuff(1)), 4) = "0"
                            ChanInfo(Val(strBuff(1)), 5) = "0"
                            ChanInfo(Val(strBuff(1)), 8) = "0" 'priority
                            ChanInfo(Val(strBuff(1)), 19) = "NONE"  '# tag
                            ChanInfo(Val(strBuff(1)), 20) = "OFF"   'alert col
                            ChanInfo(Val(strBuff(1)), 21) = "ON"  'light patern
                            ChanInfo(Val(strBuff(1)), 22) = "0"
                        End If 'strbuff>-1
                        'set the group name
                        'End If 'is this the group we want
                    Next intChan '******BREAK CHANNEL LOOP

                Else
                    intSite = 0
                    intGrp = intMaxObj
                End If
            End If
        Next intGrp

        cmdImport.Enabled = True
        lblSiteNote.DrawSystemTree()
        lblSiteNote.UpdateViewMode()
        If iSkipDigital > 0 Then
            Disp(iSkipDigital & " digital channels automatically skipped")
        End If
        If iSkipEnc > 0 Then
            Disp(iSkipEnc & " encrypted channels automatically skipped")
        End If
        If iSkipTag > 0 Then
            Disp(iSkipTag & " channels with unwanted tags automatically skipped")
        End If
        intChan = iSkipDigital + iSkipEnc + iSkipTag
        Disp("Download complete (" & intChan & " channels skipped)")
        'import fleetmap
        If strFleetMap <> "" Then
            varSite(intSysID, 0, 0, 16) = CStr(16) 'set mode to custom
            varSite(intSysID, 0, 0, 17) = strFleetMap
        Else
            varSite(intSysID, 0, 0, 16) = CStr(16) 'always set to custom
        End If
        MarkChange()

    End Sub

    Private Sub cmdAmerica_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAmerica.Click
        If cmbCountry.Items.Count > 2 And varAuthInfo.version <> "3" Then
            cmbCountry.SelectedIndex = RRUSAIndex
        ElseIf cmbCountry.Items.Count > 222 Then
            cmbCountry.SelectedIndex = 223
        End If
    End Sub

    Private Sub cmdSiteCHkAll_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiteCHkAll.Click

        Dim intitem As Integer
        With lstSite
            For intitem = 0 To .Items.Count - 1
                .SetItemChecked(intitem, True)
            Next intitem
        End With
        Call lstSite_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub lstSite_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSite.TextChanged
        Call lstSite_SelectedIndexChanged(Nothing, Nothing)
    End Sub


    Private Sub cmbQK_GotFocus(sender As Object, e As System.EventArgs) Handles cmbQK.GotFocus
        OptQK1.Checked = True

    End Sub

End Class
