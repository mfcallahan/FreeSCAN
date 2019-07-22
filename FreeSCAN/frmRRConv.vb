Option Strict Off
Option Explicit On
Friend Class frmRRCon
	Inherits System.Windows.Forms.Form
	Dim strCountry(300, 3) As String '0=coid,  1=full name, 2=country code
    Dim strProvince(300, 4) As String '0=stid, 1=prov name, 2=state_code
    Dim strCounty(1, 4) As String '0=county ctid, 1=name, 2=type, 0=normal 1=independentent
    Dim strPrAgency(1, 5) As String
    Dim strCntAgency(1, 5) As String
    Dim strGroupList(800, 5) As String 'group list, 0=ID, 1=name 2=range, 3=type  4=lat in DMS 5=long in DMS(aid/ctid agency or ctid for county group)
	Dim strCatID As String 'category ID
    Dim strFreqData(1, 1) As String
    Dim NationWideAgencyList() As Agency
	Dim lngSec As Single 'one second for timer
	Dim strTime As Integer
    Dim blnBusy As Boolean
    Dim iMiscGroupIDX As Integer = -1
    Dim bRecycleGroup As Boolean = False 'if true, forget about the new group we just made because we reused the misc group
    Dim strSysInfo(10) As String '0=latitude DMS, 1=long, 2=range all cleaned
    Dim WebServ As New RRWsdl
    ' Dim CDServ As New RRCDService
    Dim ActiveServ As Object = WebServ
    Dim H1Menu(5) As ToolStripMenuItem

    Sub initForm()
        Dim cnt As Integer
        'gets the form ready
        cmbCountry.Items.Clear()
        cmbProvince.Items.Clear()
        cmbCounty.Items.Clear()
        cmbProvAgency.Items.Clear()
        cmbCntAgency.Items.Clear()
        cmbNumMisc.Items.Clear()
        cmbCountry.Enabled = False
        cmbProvince.Enabled = False
        cmbCounty.Enabled = False
        cmbProvAgency.Enabled = False
        cmbCntAgency.Enabled = False '
        lstGroup.Items.Clear()

        txtSysName.Text = ""

        System.Array.Clear(strCountry, 0, strCountry.Length)
        System.Array.Clear(strProvince, 0, strProvince.Length)
        System.Array.Clear(strCounty, 0, strCounty.Length)
        System.Array.Clear(strPrAgency, 0, strPrAgency.Length)
        System.Array.Clear(strCntAgency, 0, strCntAgency.Length)
        UpdateCount()
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

        For cnt = 1 To 99
            cmbNumMisc.Items.Add(cnt)
        Next
        H1Menu(0) = H1
        H1Menu(1) = H2
        H1Menu(2) = H3
        H1Menu(3) = H4
        H1Menu(4) = H5
    End Sub
    Sub UpdateCount()
        'draws counts for each category
        Dim cnt As Integer
        For cnt = 0 To 4
            lblCnt(cnt).Text = ""
        Next cnt
        With cmbCountry
            If .Items.Count > 0 Then
                lblCnt(0).Text = "[" & .Items.Count & "]"
            Else
                lblCnt(0).Text = ""
            End If
        End With
        With cmbProvince
            If .Items.Count > 0 Then
                lblCnt(1).Text = "[" & .Items.Count & "]"
            Else
                lblCnt(1).Text = ""
            End If
        End With
        With cmbCounty
            If .Items.Count > 0 Then
                lblCnt(2).Text = "[" & .Items.Count & "]"
            Else
                lblCnt(2).Text = ""
            End If
        End With
        With cmbProvAgency
            If .Items.Count > 0 Then
                lblCnt(3).Text = "[" & .Items.Count & "]"
            Else
                lblCnt(3).Text = ""
            End If
        End With
        With cmbCntAgency
            If .Items.Count > 0 Then
                lblCnt(4).Text = "[" & .Items.Count & "]"
            Else
                lblCnt(4).Text = ""
            End If
        End With

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


    Private Sub cmbCntAgency_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCntAgency.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        With cmbCntAgency
            If .SelectedIndex > -1 Then
                Call GetGroup("aid", strCntAgency(.SelectedIndex, 0))
            End If
            If chkCompress.CheckState = 0 Then
                txtSysName.Text = MakeItKosherSilent(.Text, 0)
            Else
                txtSysName.Text = Kompressor(.Text)
            End If
        End With
        cmbProvAgency.SelectedIndex = -1
        If chkCompress.CheckState = 0 Then

            txtSysName.Text = MakeItKosherSilent((cmbCntAgency.Text), 0)
        Else

            txtSysName.Text = Kompressor((cmbCntAgency.Text))
        End If
    End Sub


    Private Sub cmbCountry_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCountry.SelectedIndexChanged
        If cmbCountry.Enabled = False Then Exit Sub

        Dim intNumStid, intResponse, intCnt As Integer
        Dim intSL As Integer ' StateList() As State
        'check for valid logon information
        Dim CInfo As CountryInfo
        If CheckValid() = 0 Then Exit Sub
        If blnBusy = True Then Exit Sub
        If cmbCountry.SelectedIndex = -1 Then Exit Sub
        intSL = Val(strCountry(cmbCountry.SelectedIndex, 0))
        'attempt to grab the list of provinces
        cmbProvince.Items.Clear()
        cmbCounty.Items.Clear()
        cmbProvAgency.Items.Clear()
        cmbCntAgency.Items.Clear()
        lstGroup.Items.Clear()
        cmbProvince.Enabled = False
        cmbCounty.Enabled = False
        cmbProvAgency.Enabled = False
        cmbCntAgency.Enabled = False
        Disp("Downloading country list...")
        Erase NationWideAgencyList
        'assuming that all worked, load everything into the state variable
        Try
            CInfo = ActiveServ.getCountryInfo(intSL, varAuthInfo)
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
        ''Add the nationwide information
        cmbProvince.Items.Add("Nationwide")
        NationWideAgencyList = CInfo.agencyList

        For intCnt = 0 To intNumStid
            'Dump data from the strNet variable into the country variable
            strProvince(intCnt, 0) = CInfo.stateList(intCnt).stid 'state stid
            strProvince(intCnt, 1) = CInfo.stateList(intCnt).stateName  'state name
            strProvince(intCnt, 2) = CInfo.stateList(intCnt).stateCode 'state code
            cmbProvince.Items.Add(lblSiteNote.NoNull((strProvince(intCnt, 1))))
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
        Dim j, intSL, i, intParam As Integer
        Dim best_value(1000) As String
        Dim best_j As Integer
        Dim arrCounty() As cat
        Dim intNumCats As Integer, intCat As Integer, intSubCat As Integer, intGroupNum As Integer
        Dim arrAgency() As Agency, strLat, strLong, strRange As String
        If blnBusy = True Then Exit Sub
        'check for valid logon information

        If CheckValid() = 0 And Not RRCDMode Then Exit Sub
        If cmbCounty.SelectedIndex = -1 Then Exit Sub
        intSL = Val(strCounty(cmbCounty.SelectedIndex, 0))
        cmbProvAgency.SelectedIndex = -1
        'attempt to grab the list of counties and province-wide agencies
        cmbCntAgency.Items.Clear()
        lstGroup.Items.Clear()
        My.Application.DoEvents()
        cmbCntAgency.Enabled = False
        'Grab all the counties first
        'assuming that all worked, load everything into the county variable
        Disp("Downloading information...")
        System.Array.Clear(strCntAgency, 0, strCntAgency.Length)
        Try
            arrCounty = ActiveServ.getCountyInfo(intSL, varAuthInfo).cats
            arrAgency = ActiveServ.getCountyInfo(intSL, varAuthInfo).agencyList
            strLat = StripDMSDOT(DecToDMS(ActiveServ.getCountyInfo(intSL, varAuthInfo).lat, True))
            strLong = StripDMSDOT(DecToDMS(ActiveServ.getCountyInfo(intSL, varAuthInfo).lon, False))
            strRange = MakeItKosherGPSRange(ActiveServ.getCountyInfo(intSL, varAuthInfo).range)
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        strSysInfo(0) = strLat
        strSysInfo(1) = strLong
        strSysInfo(2) = strRange
        If IsDBNull(arrCounty) = False And IsArray(arrCounty) = True Then
            intNumCats = UBound(arrCounty)
        Else
            intNumCats = -1
        End If
        intCat = 0
        intSubCat = 0
        intGroupNum = 0
        System.Array.Clear(strGroupList, 0, strGroupList.Length)
        If intNumCats > -1 Then
            Do Until intCat > intNumCats
                If IsArray(arrCounty(intCat).subcats) Then
                    For intSubCat = 0 To UBound(arrCounty(intCat).subcats)
                        strGroupList(intGroupNum, 0) = arrCounty(intCat).subcats(intSubCat).scid 'subcat scid
                        strGroupList(intGroupNum, 1) = arrCounty(intCat).subcats(intSubCat).scName 'subcat name
                        strGroupList(intGroupNum, 4) = StripDMSDOT(DecToDMS(arrCounty(intCat).subcats(intSubCat).lat, True))
                        strGroupList(intGroupNum, 5) = StripDMSDOT(DecToDMS(arrCounty(intCat).subcats(intSubCat).lon, False))
                        strGroupList(intGroupNum, 2) = MakeItKosherGPSRange(arrCounty(intCat).subcats(intSubCat).range)
                        strGroupList(intGroupNum, 3) = "stid" 'command to retrieve frequencies
                        intGroupNum = intGroupNum + 1
                    Next
                End If
                intCat += 1

            Loop
            Disp("Found " & CStr(intGroupNum) & " groups.")
            'sort the group array
            For i = 0 To intGroupNum - 1
                For intParam = 0 To 5
                    best_value(intParam) = strGroupList(i, intParam)
                    best_j = i
                Next intParam
                For j = i + 1 To intGroupNum - 2
                    If UCase(strGroupList(j, 1)) < UCase(best_value(1)) Then
                        For intParam = 0 To 5
                            best_value(intParam) = strGroupList(j, intParam)
                        Next intParam
                        best_j = j
                    End If
                Next j
                For intParam = 0 To 5
                    strGroupList(best_j, intParam) = strGroupList(i, intParam)
                    strGroupList(i, intParam) = best_value(intParam)
                Next intParam
            Next i
        Else
            Disp("Finished downloading. No groups available to download.")
        End If

        lstGroup.Items.Clear()



        For intCnt = 0 To intGroupNum - 1
            lstGroup.Items.Add(lblSiteNote.NoNull(strGroupList(intCnt, 1)))
        Next intCnt
        For intCnt = 1 To lstGroup.Items.Count
            lstGroup.SetItemChecked(intCnt - 1, True)
        Next intCnt
        tabImport.SelectedIndex = 0


        'download the county agencies
        If IsDBNull(arrAgency) = False And IsArray(arrAgency) = True Then
            intNumStid = UBound(arrAgency)
        Else
            intNumStid = -1
        End If
        ReDim strCntAgency(intNumStid + 1, 5)
        For intCnt = 0 To intNumStid
            'Dump data from the strNet variable into the country variable
            strCntAgency(intCnt, 0) = arrAgency(intCnt).aid 'agency id
            strCntAgency(intCnt, 1) = arrAgency(intCnt).aName 'agency name
        Next intCnt
        'sort the list
        For i = 0 To intNumStid
            For intParam = 0 To 5
                best_value(intParam) = strCntAgency(i, intParam)
                best_j = i
            Next intParam
            For j = i + 1 To intNumStid - 1
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
        For intCnt = 0 To intNumStid
            cmbCntAgency.Items.Add(lblSiteNote.NoNull(strCntAgency(intCnt, 1)))
        Next intCnt
        UpdateCount()
        cmbCntAgency.Enabled = True
        If chkCompress.CheckState = 0 Then
            txtSysName.Text = MakeItKosherSilent((cmbCounty.Text), 0)
        Else

            txtSysName.Text = Kompressor((cmbCounty.Text))
        End If

    End Sub


    Private Sub cmbProvAgency_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbProvAgency.SelectedIndexChanged
        If blnBusy = True Then Exit Sub
        With cmbProvAgency
            If .SelectedIndex > -1 Then
                Call GetGroup("aid", strPrAgency(.SelectedIndex, 0))
                cmbCounty.SelectedIndex = -1
                If chkCompress.CheckState = 0 Then

                    txtSysName.Text = MakeItKosherSilent(.Text, 0)
                Else

                    txtSysName.Text = Kompressor(.Text)
                End If
            End If

        End With


        cmbCntAgency.SelectedIndex = -1
        cmbCntAgency.Items.Clear()
    End Sub


    Private Sub cmbProvince_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbProvince.SelectedIndexChanged
        If cmbProvince.Enabled = False Then Exit Sub
        Dim intNumStid, intResponse, intCnt As Integer
        Dim intSL As Integer, intCountyCnt As Integer
        Dim j, i, intParam, best_j As Integer
        Dim best_value(5) As String
        Dim strStateInfo As StateInfo, strCountyList() As County
        Dim strAgencyList() As Agency
        'check for valid logon information
        Dim NationWide As Boolean = False
        If CheckValid() = 0 Then Exit Sub
        If cmbProvince.SelectedIndex = -1 Then Exit Sub
        If blnBusy = True Then Exit Sub
        If cmbProvince.Enabled = False Then Exit Sub

        'attempt to grab the list of counties and province-wide agencies
        cmbCounty.Items.Clear()
        cmbProvAgency.Items.Clear()
        cmbCntAgency.Items.Clear()
        lstGroup.Items.Clear()
        cmbCounty.Enabled = False
        cmbProvAgency.Enabled = False
        cmbCntAgency.Enabled = False
        'Grab all the counties first
        Disp("Downloading information...")
        'Try to figure out if we want nationwide frequencies
        If cmbProvince.SelectedIndex = 0 Then 'yes, get nationwide information loaded
            NationWide = True
        Else
            intSL = Val(strProvince(cmbProvince.SelectedIndex - 1, 0))
        End If

        If Not NationWide Then
            Try

                strStateInfo = ActiveServ.getStateInfo(intSL, varAuthInfo)

            Catch ex As Exception
                Call RRException(ex.Message)
                Exit Sub
            End Try
            strCountyList = strStateInfo.countyList
            intCountyCnt = UBound(strCountyList)
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
                For intParam = 0 To 3

                    best_value(intParam) = strCounty(i, intParam)
                    best_j = i
                Next intParam
                For j = i + 1 To intNumStid - 2

                    If UCase(strCounty(j, 1)) < UCase(best_value(1)) Then
                        For intParam = 0 To 3

                            best_value(intParam) = strCounty(j, intParam)
                        Next intParam
                        best_j = j
                    End If
                Next j
                For intParam = 0 To 3
                    strCounty(best_j, intParam) = strCounty(i, intParam)

                    strCounty(i, intParam) = best_value(intParam)
                Next intParam
            Next
            For intCnt = 0 To intCountyCnt
                cmbCounty.Items.Add(lblSiteNote.NoNull((strCounty(intCnt, 1))))
            Next intCnt

            cmbCounty.Enabled = True
            UpdateCount()
            'Next grab the province-wide agencies
            strAgencyList = strStateInfo.agencyList
        Else
            strAgencyList = NationWideAgencyList
        End If

        If IsArray(strAgencyList) = True Then
            intNumStid = UBound(strAgencyList)
        Else
            intNumStid = -1
        End If
        ReDim strPrAgency(intNumStid + 1, 5)
        'assuming that all worked, load everything into the county variable

        System.Array.Clear(strPrAgency, 0, strPrAgency.Length)
        For intCnt = 0 To intNumStid
            'Dump data from the strNet variable into the country variable
            strPrAgency(intCnt, 0) = strAgencyList(intCnt).aid 'aid
            strPrAgency(intCnt, 1) = strAgencyList(intCnt).aName 'name
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
            cmbProvAgency.Items.Add((lblSiteNote.NoNull(strPrAgency(intCnt, 1))))
        Next intCnt
        cmbProvAgency.Enabled = True
        UpdateCount()
        Disp("")
    End Sub

    Private Sub cmdAmerica_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAmerica.Click
        If cmbCountry.Items.Count > 2 And varAuthInfo.version <> "3" Then
            cmbCountry.SelectedIndex = RRUSAIndex
        ElseIf cmbCountry.Items.Count > 2 Then
            cmbCountry.SelectedIndex = 223
        End If

    End Sub

    Private Sub cmdCanada_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCanada.Click
        If cmbCountry.Items.Count > 2 Then cmbCountry.SelectedIndex = 37

    End Sub

    Private Sub cmdConnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConnect.Click

        Dim intNumCoid, intCnt As Integer
        Dim strBuff As String
        Dim strCountryList() As Country
        'check for valid logon information

        If CheckValid() = 0 Then Exit Sub
        'save info to registry
        If chkSavepw.CheckState = 1 Then
            SaveSetting("FreeSCAN", "Settings", "UserName", txtUserName.Text)
            SaveSetting("FreeSCAN", "Settings", "UserPW", txtpassword.Text)
        Else
            SaveSetting("FreeSCAN", "Settings", "UserName", "")
            SaveSetting("FreeSCAN", "Settings", "UserPW", "")
        End If
        Disp("Connecting...")
        ActiveServ = WebServ
        'attempt to grab the list of countries
        cmbCountry.Items.Clear()
        cmbProvince.Items.Clear()
        cmbCounty.Items.Clear()
        cmbProvAgency.Items.Clear()
        cmbCntAgency.Items.Clear()
        cmbCountry.Enabled = False
        cmbProvince.Enabled = False
        cmbCounty.Enabled = False
        cmbProvAgency.Enabled = False
        cmbCntAgency.Enabled = False
        varAuthInfo.username = txtUserName.Text
        varAuthInfo.password = txtpassword.Text
        varAuthInfo.version = "9"
        varAuthInfo.style = "RPC"
        varAuthInfo.appKey = "" 'Apply for an API key and put it here
        Try
            strBuff = ActiveServ.getUserData(varAuthInfo).subExpireDate
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try



        Disp("Subscription expires on " & strBuff)

        'assuming that all worked, load everything into the country variable

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
        'If lstTag.Items.Count = 0 Or blnDebug Then
        Call frmRRTrn.PopulateTagList()
        ' End If
        Disp("")

    End Sub

    Function CheckValid() As Integer
        'check to see if the login info is valid

        CheckValid = 1 'valid state
        If RRCDMode Then Exit Function
        Dim intRes As Integer
        If txtUserName.Text = "" Then

            CheckValid = 0
            intRes = MsgBox("Please enter a user name.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        ElseIf txtpassword.Text = "" Then

            CheckValid = 0
            intRes = MsgBox("Please enter a valid password", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End If

    End Function

    Sub Disp(ByVal strMsg As String)
        'displays a text onthe bottom to inform the user
        Dim LogTxt As String
        LogTxt = Format(Now(), "T")
        LogTxt &= " " & strMsg & vbCrLf
        _StatusBar_Panel1.Text = strMsg
        If Len(strMsg) <> 0 Then
            txtLog.AppendText(LogTxt)
        End If
        My.Application.DoEvents()
    End Sub
    Sub GetGroup(ByRef strGroupType As String, ByRef strID As String)
        'retrieves data from groups within a system
        'ctid=[county id] county related groups
        'aid=[agency num] all groups belonging to a agency
        Dim intNumCoid, intCnt, intStid As Integer
        Dim strCatFIeld() As cat
        Dim j, i, intParam As Integer
        Dim best_value(1000) As String
        Dim best_j As Integer, strAgency As AgencyInfo
        Dim strCounty As CountyInfo, intNumCats As Integer, intCat As Integer, intGroupNum As Integer
        'check for valid logon information

        If CheckValid() = 0 Then Exit Sub
        'attempt to grab the list of countries
        lstGroup.Items.Clear()
        System.Array.Clear(strGroupList, 0, strGroupList.Length)
        If strGroupType = "aid" Then 'download an agency
            Try
                strAgency = ActiveServ.getAgencyInfo(Val(strID), varAuthInfo)
            Catch ex As Exception
                Call RRException(ex.Message)
                Exit Sub
            End Try
            'do some error checking here
            'Download basically conventional group information
            intStid = strAgency.stid
            strCatFIeld = strAgency.cats
            strSysInfo(0) = StripDMSDOT(DecToDMS(strAgency.lat, True))
            strSysInfo(1) = StripDMSDOT(DecToDMS(strAgency.lon, False))
            strSysInfo(2) = MakeItKosherGPSRange(strAgency.range)
            intNumCoid = 0
            If IsArray(strAgency.cats) Then
                intNumCats = UBound(strCatFIeld)
            Else
                intNumCats = -1
                Disp("Nothing to download - no groups listed for this agency.")
            End If
            intCat = 0
            intGroupNum = 0
            Try
                Do Until intCat > intNumCats
                    intNumCoid = UBound(strAgency.cats(intCat).subcats)
                    For intCnt = 0 To intNumCoid
                        'Dump data from the strNet variable into the country variable
                        strGroupList(intGroupNum, 0) = strAgency.cats(intCat).subcats(intCnt).scid 'subcat scid
                        strGroupList(intGroupNum, 1) = strAgency.cats(intCat).subcats(intCnt).scName 'subcat name
                        strGroupList(intGroupNum, 4) = StripDMSDOT(DecToDMS(strAgency.cats(intCat).subcats(intCnt).lat, True))
                        strGroupList(intGroupNum, 5) = StripDMSDOT(DecToDMS(strAgency.cats(intCat).subcats(intCnt).lon, False))
                        strGroupList(intGroupNum, 2) = MakeItKosherGPSRange(strAgency.cats(intCat).subcats(intCnt).range)
                        strGroupList(intGroupNum, 3) = strGroupType 'huh?
                        intGroupNum = intGroupNum + 1
                    Next intCnt
                    intCat = intCat + 1
                Loop
            Catch ex As Exception
                Call RRException(ex.Message)
                Exit Sub
            End Try
        ElseIf strGroupType = "ctid" Then
            Try
                strCounty = ActiveServ.getCountyInfo(Val(strID), varAuthInfo)
                intNumCoid = 0
                strSysInfo(0) = StripDMSDOT(DecToDMS(strCounty.lat, True))
                strSysInfo(1) = StripDMSDOT(DecToDMS(strCounty.lon, False))
                strSysInfo(2) = MakeItKosherGPSRange(strCounty.range)
            Catch ex As Exception
                Call RRException(ex.Message)
                Exit Sub
            End Try
            '
            'sort the list
        End If

        Try

            For i = 0 To intGroupNum - 1
                For intParam = 0 To 5
                    best_value(intParam) = strGroupList(i, intParam)
                    best_j = i
                Next intParam
                For j = i + 1 To intGroupNum - 2
                    If UCase(strGroupList(j, 1)) < UCase(best_value(1)) Then
                        For intParam = 0 To 5
                            best_value(intParam) = strGroupList(j, intParam)
                        Next intParam
                        best_j = j
                    End If
                Next j
                For intParam = 0 To 5
                    strGroupList(best_j, intParam) = strGroupList(i, intParam)
                    strGroupList(i, intParam) = best_value(intParam)
                Next intParam
            Next i
            For intCnt = 0 To intGroupNum - 1
                lstGroup.Items.Add(lblSiteNote.NoNull(strGroupList(intCnt, 1)))
            Next intCnt



            UpdateCount()
            'check all items by default
            For intCnt = 1 To lstGroup.Items.Count
                lstGroup.SetItemChecked(intCnt - 1, True)
            Next intCnt
            tabImport.SelectedIndex = 0

        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
    End Sub
    Sub LoadFreqData(ByRef intSCID As Integer, ByVal strGroupName As String, ByVal strTip As String)
        'loads the frequency data for an agency
        Dim intNumCoid, intChan, intChanCnt As Integer
        Dim strMode, strBuff As String
        Dim arrFreqs() As freq
        Dim iSkipTag As Integer = 0
        'check for valid logon information

        If CheckValid() = 0 Then Exit Sub
        'attempt to grab the list of countries


        '  Disp("Downloading frequency info...")
        Array.Clear(strFreqData, 0, strFreqData.Length)
        Try
            arrFreqs = ActiveServ.getSubcatFreqs(intSCID, varAuthInfo)
        Catch ex As Exception
            Call RRException(ex.Message)
            Exit Sub
        End Try
        'assuming that all worked, load everything into the country variable

        If IsArray(arrFreqs) = False Then
            Disp(strTip & "No frequencies to import for " & strGroupName & ", skipping group.")
            Exit Sub
        End If
        intNumCoid = UBound(arrFreqs)
        intChanCnt = 0
        ReDim strFreqData(intNumCoid + 1, 15) 'frequency data will be stored in native format

        Disp(strTip & "Downloaded " & (intNumCoid + 1) & " frequencies for " & strGroupName)
        For intChan = 1 To intNumCoid + 1
            If frmRRTrn.TagSkip(arrFreqs(intChan - 1).tags) Then
                'This frequency has a skip tag, so it won't be imported
                iSkipTag += 1
            ElseIf arrFreqs(intChan - 1).out < 25 Then
                Disp("Frequency " & arrFreqs(intChan - 1).descr & " skipped, frequency is below 25MHz")
            ElseIf arrFreqs(intChan - 1).out > 1300 Then
                Disp("Frequency " & arrFreqs(intChan - 1).descr & " skipped, frequency is above 1300MHz")
            Else
                intChanCnt += 1
                strMode = arrFreqs(intChan - 1).mode 'valid modes are 1, 3, or 4
                strFreqData(intChanCnt, 1) = arrFreqs(intChan - 1).descr
                strFreqData(intChanCnt, 2) = MakeItKosherFreqSilent(CStr(arrFreqs(intChan - 1).out))
                'Tone and NAC
                strBuff = arrFreqs(intChan - 1).tone
                If InStr(strBuff, "NAC") <> 0 Then
                    strBuff = strBuff.Replace("NAC", "")
                    strBuff = strBuff.Trim
                    strFreqData(intChanCnt, 15) = strBuff
                    strFreqData(intChanCnt, 9) = "0"


                Else
                    strFreqData(intChanCnt, 9) = RRToneLookUp(arrFreqs(intChan - 1).tone) 'tone
                    strFreqData(intChanCnt, 15) = "SRCH"
                End If


                strFreqData(intChanCnt, 10) = arrFreqs(intChan - 1).alpha 'display
                strFreqData(intChanCnt, 4) = RRModLookup(strMode)
                strFreqData(intChanCnt, 14) = strMode 'raw mode
                Console.WriteLine("frmRRConv:LoadFreqData:raw modulation mode is " & strMode & " for " & arrFreqs(intChan - 1).alpha)
                strFreqData(intChanCnt, 3) = CStr(1) 'tape out on
                strFreqData(intChanCnt, 5) = CStr(0) 'l/o off
                strFreqData(intChanCnt, 6) = CStr(0) 'atten off
                strFreqData(intChanCnt, 7) = CStr(0) 'pri off
                strFreqData(intChanCnt, 8) = CStr(0) 'alert tone type
                strFreqData(intChanCnt, 11) = CStr(0) 'tone lockout
                strFreqData(intChanCnt, 13) = CStr(0) 'alert level
                If strMode = "2" Then 'set mod mode
                    strFreqData(intChanCnt, 12) = CStr(2) 'set to digital modulation
                ElseIf strFreqData(intChanCnt, 4) <> "0" Then  'coded squelch, set to analog only
                    strFreqData(intChanCnt, 12) = CStr(1)
                Else
                    strFreqData(intChanCnt, 12) = CStr(0) 'all audio
                End If
            End If
        Next intChan
        strFreqData(0, 0) = CStr(intChanCnt)
        If iSkipTag > 0 Then
            Disp(iSkipTag & " channels skipped through tag selection")
        End If

    End Sub




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

    Private Sub cmdImport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImport.Click
        'import frequencies into freescan
        Dim intSysNum As Integer
        If blnDebug = False Then On Error Resume Next
        cmdImport.Enabled = False

        Dim strBuff(5), strTip, MasterQK As String
        Dim intSys, intGrp, intList As Integer
        Dim blnMemFull As Boolean
        intCurrentSys = 0
        intCurrentGroup = 0
        intCurrentChannel = 0
        iMiscGroupIDX = -1
        CreateImportSys((0))
        intSysNum = 1
        intSys = intCurrentSys
        'insert code here for maximum memory
        'Save to history
        'assign a QK
        If radAutoQK.Checked Then
            MasterQK = CStr(FindFreeQK())
        ElseIf radManQK.Checked Then
            MasterQK = cmbQK.Text
        Else
            MasterQK = "."
        End If
        intSys = intCurrentSys
        varSite(intSys, 0, 0, 4) = MasterQK
        strBuff(0) = cmbProvince.Text & " - " & cmbCounty.Text
        strBuff(1) = cmbCountry.SelectedIndex & "," & cmbProvince.SelectedIndex & "," & cmbCounty.SelectedIndex
        Call SaveHistory(strBuff(0), strBuff(1))
        For intList = 0 To lstGroup.Items.Count - 1

            If lstGroup.GetItemChecked(intList) = True Then 'download this group
                intGrp = intGrp + 1
                If intGrp = 21 Then
                    intSysNum = intSysNum + 1
                    iMiscGroupIDX = -1
                    CreateImportSys((intSysNum))
                    intSys = intCurrentSys
                    varSite(intSys, 0, 0, 4) = MasterQK
                    If intCurrentSys = 0 Then
                        blnMemFull = True
                        intList = lstGroup.Items.Count - 1
                    End If
                    intGrp = 1
                End If
                strTip = "(" & CStr(Int((intList / lstGroup.Items.Count) * 100)) & "% Complete) "
                'download the group to memory
                Call LoadFreqData(strGroupList(intList, 0), strGroupList(intList, 1), strTip)
                My.Application.DoEvents()
                'import that group into memory
                If strFreqData(0, 0) <> 0 Then
                    Call ImportCurrentGroup(intSys, intGrp, intList)
                    If bRecycleGroup Then 'The old misc group was used to import these channels, so forget about the new one we made
                        intGrp -= 1
                    End If
                Else 'This group has no frequencies in, not getting imported, so back off the group counter
                    intGrp -= 1

                End If

            End If
        Next intList
        'assign a QK

        Disp("Finished importing of frequencies.")
        intCurrentGroup = 0
        cmdImport.Enabled = True

        lblSiteNote.DrawSystemTree()
        lblSiteNote.UpdateViewMode()

        Disp("Import complete")

    End Sub

    Sub CreateImportSys(ByRef intSysNum As Short)
        'creates a default system for importing groups
        Dim strBuff As String
        lblSiteNote.blnSkipGroup = True

        strBuff = GetFreeSysNum()
        If strBuff = "-1" Then
            intCurrentSys = 0
            Exit Sub
        End If
        lblSiteNote.MakeNewConvSystem()
        lblSiteNote.blnSkipGroup = False
        strBuff = txtSysName.Text

        'If more than one system is being imported, append a system number
        If intSysNum > 1 Then
            If Len(strBuff) >= 16 Then
                strBuff = Kompressor(strBuff)
            End If
            If Len(strBuff) >= 16 Then
                strBuff = Strings.Left(strBuff, 15)
            End If
            strBuff = strBuff & intSysNum
        End If
        varSite(intCurrentSys, 0, 0, 1) = Kompressor((strBuff))
        varSite(intCurrentSys, 0, 0, 19) = strSysInfo(0)
        varSite(intCurrentSys, 0, 0, 20) = strSysInfo(1)
        varSite(intCurrentSys, 0, 0, 21) = strSysInfo(2)
        'Enable GPS by default if desired
        If chkGPSDefault.Checked And Val(strSysInfo(1)) <> 0 And Val(strSysInfo(0)) <> 0 Then
            varSite(intCurrentSys, 0, 0, 22) = "1"
        End If
    End Sub
    Sub ImportCurrentGroup(ByRef intSys As Integer, ByVal intGrp As Integer, ByRef intGrp2 As Integer)
        'takes the currently loaded group in strgrouplist and dumps into the current system
        If blnDebug = False Then On Error Resume Next

        If intSys = 0 Then Exit Sub
        Dim intChan, intParam, intCnt As Integer
        Dim intTotChan As Integer
        Dim strDesc, strBuff, strDisp As String
        Dim Buff(2) As String
        Dim bChanSel As Boolean = True
        strBuff = Nothing
        intTotChan = Val(strFreqData(0, 0))
        bRecycleGroup = False
        'SHould we compress a group with few channels into a misc group?
        If chkMiscGroup.Checked And Val(cmbNumMisc.Text) >= intTotChan Then
            Disp("Placing " & intTotChan & " channels from subcategory " & strGroupList(intGrp2, 1) & " into the Misc group")
            If iMiscGroupIDX = -1 Then 'create a misc group
                iMiscGroupIDX = intGrp
                varSite(intSys, intGrp, 0, 1) = "Misc"

                varSite(intSys, intGrp, 0, 10) = CreateGroupID()
            Else 'put channels in the existing misc group
                intGrp = iMiscGroupIDX
                bRecycleGroup = True 'group was reused so backoff the index variable

            End If
        Else 'make a regular group

            varSite(intSys, intGrp, 0, 10) = CreateGroupID()
            If chkCompress.CheckState = 0 Then
                varSite(intSys, intGrp, 0, 1) = MakeItKosherSilent(strGroupList(intGrp2, 1), 0)
            Else
                varSite(intSys, intGrp, 0, 1) = MakeItKosher(Kompressor((strGroupList(intGrp2, 1))))
            End If
        End If
        varSite(intSys, intGrp, 0, 2) = "." 'qk
        varSite(intSys, intGrp, 0, 3) = CStr(0) 'l/o
        varSite(intSys, intGrp, 0, 5) = CStr(1) 'grouptype

        If strGroupList(intGrp2, 2) <> "" Then
            'import GPS parameters
            varSite(intSys, intGrp, 0, 6) = strGroupList(intGrp2, 4)  'lat
            varSite(intSys, intGrp, 0, 7) = strGroupList(intGrp2, 5)   'long
            If Val(strGroupList(intGrp2, 4)) = 0 And Val(strGroupList(intGrp2, 5)) = 0 And Val(strSysInfo(0)) <> 0 Then
                Disp("No GPS info available for group " & varSite(intSys, intGrp, 0, 1) & " - importing info from main system.")
                varSite(intSys, intGrp, 0, 6) = strSysInfo(0)
                varSite(intSys, intGrp, 0, 7) = strSysInfo(1)
     
                strGroupList(intGrp2, 2) = strSysInfo(2)
            End If
            If Val(strGroupList(intGrp2, 2)) > 125 Then
                strGroupList(intGrp2, 2) = "125"
            ElseIf Val(strGroupList(intGrp2, 2)) < 1 Then
                strGroupList(intGrp2, 2) = "1"
            End If
            'Enable GPS by default if desired
            If chkGPSDefault.Checked And Val(varSite(intSys, intGrp, 0, 6)) <> 0 And Val(varSite(intSys, intGrp, 0, 7)) <> 0 Then
                varSite(intSys, intGrp, 0, 9) = "1"
            End If
            varSite(intSys, intGrp, 0, 8) = MakeItKosherGPSRange(strGroupList(intGrp2, 2)) 'range
        End If

        intCurrentGroup = intGrp
        For intCnt = 1 To intTotChan
            'skip digital channels if told to do so
            bChanSel = True
            If chkSkipDig.CheckState = 1 And strFreqData(intCnt, 14) = "2" Then 'skip digital channels if not wanted
                bChanSel = False
            ElseIf chkSkipMode.Checked Then 'skip channels with incompatible modulation if not wanted
                If strFreqData(intCnt, 14) <> "1" And strFreqData(intCnt, 14) <> "3" And strFreqData(intCnt, 14) <> "4" Then
                    bChanSel = False
                End If

            End If

            If bChanSel Then
                intChan = InsertChan(strBuff, True)
                strBuff = varSite(intSys, intGrp, 0, 10)
                If intChan > 0 Then
                    For intParam = 2 To 15
                        ChanInfo(intChan, intParam) = strFreqData(intCnt, intParam)
                        If ChanInfo(intChan, 9) = "0" And ChanInfo(intChan, 12) <> "2" Then 'set audio type
                            ChanInfo(intChan, 12) = "0" 'no ctcss but mode still on analog=all
                        End If
                    Next intParam

                    'manipulate name
                    strDesc = strFreqData(intCnt, 1) 'orig name
                    strDisp = strFreqData(intCnt, 10) 'display name
                    If chkDisp.CheckState = 1 And strDisp <> "" Then
                        ChanInfo(intChan, 1) = strDisp
                        ChanInfo(intChan, 14) = strDesc
                    Else
                        ChanInfo(intChan, 1) = strDesc
                        ChanInfo(intChan, 14) = ""
                    End If
                    If chkCompress.CheckState = 1 Then

                        ChanInfo(intChan, 1) = Kompressor(ChanInfo(intChan, 1))
                    Else

                        ChanInfo(intChan, 1) = MakeItKosherSilent(ChanInfo(intChan, 1), 0)
                    End If
                    If chkDescComm.CheckState = 1 And Len(strDesc) > 16 Then
                        ChanInfo(intChan, 14) = ChanInfo(intChan, 14) & " " & strDesc
                    End If
                    ChanInfo(intChan, 14) = MakeItKosherSilent(ChanInfo(intChan, 14), 3)
                    ChanInfo(intChan, 10) = strBuff 'reset group id
                    ChanInfo(intChan, 3) = "1" ' tape out on

                Else
                    MsgBox("Insufficient memory is available to import any more channels. Aborting")
                    intCnt = intTotChan
                End If 'intchan>0
            End If 'skip channel
        Next intCnt

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
        xt = CStr(MsgBox("Home location saved.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "Settings Saved"))
    End Sub

    Private Sub cmdSignUp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSignUp.Click
        Dim ShellCode As String
        ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", "http://www.radioreference.com/apps/register/", "", "", 1))

        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub cmdSiteChkAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSiteChkAll.Click
        Dim index As Short = cmdSiteChkAll.GetIndex(eventSender)
        Dim intitem, intCnt As Integer
        Select Case index
            Case 2
                With lstGroup
                    intCnt = .Items.Count - 1
                    For intitem = 0 To intCnt
                        .SetItemChecked(intitem, True)
                    Next intitem
                End With
            Case Else
                With lstGroup
                    intCnt = .Items.Count - 1
                    For intitem = 0 To intCnt
                        .SetItemChecked(intitem, False)
                    Next intitem
                End With
        End Select
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
        If cmbProvAgency.SelectedIndex >= 0 Then 'province wide agency
            intSysID = CInt(strPrAgency(cmbProvAgency.SelectedIndex, 0))

            If intSysID < 1 Then
                MsgBox("Sorry, but no system is currently available for viewing.")
                Exit Sub
            End If
            strSite = SrcRoot & "?aid=" & intSysID
        ElseIf cmbCntAgency.SelectedIndex >= 0 Then  'a county level agency
            intSysID = CInt(strCntAgency(cmbCntAgency.SelectedIndex, 0))

            If intSysID < 1 Then
                MsgBox("Sorry, but no system is currently available for viewing.")
                Exit Sub
            End If
            strSite = SrcRoot & "?aid=" & intSysID
        ElseIf cmbCounty.SelectedIndex >= 0 Then  'an entire county
            intSysID = CInt(strCounty(cmbCounty.SelectedIndex, 0))

            If intSysID < 1 Then
                MsgBox("Sorry, but no system is currently available for viewing.")
                Exit Sub
            End If
            strSite = SrcRoot & "?ctid=" & intSysID

        End If
        If strSite <> "" Then
            ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", strSite, "", "", 1))
            'frmSystemEditor.WindowState = System.Windows.Forms.FormWindowState.Minimized
        End If
    End Sub



    Private Sub cmdChkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChkAll.Click
        Dim intitem As Integer
        With lstGroup
            For intitem = 0 To .Items.Count - 1
                .SetItemChecked(intitem, True)
            Next intitem
        End With
    End Sub

    Private Sub cmdChkNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChkNone.Click
        Dim intitem As Integer
        With lstGroup
            For intitem = 0 To .Items.Count - 1
                .SetItemChecked(intitem, False)
            Next intitem
        End With
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
    Sub SaveHistory(ByVal strDesc As String, ByVal strKey As String)
        'Once a country/place is selected, add it to the history already if it isn't there
        If Not blnDebug Then On Error Resume Next
        Dim NameArray(4) As String
        Dim KeyArray(4) As String
        Dim intCnt As Integer
        Dim blnFound As Boolean = False
        Dim intPos As Integer = 0
        NameArray(0) = GetSetting("FreeSCAN", "Settings", "Hist0", "")
        NameArray(1) = GetSetting("FreeSCAN", "Settings", "Hist1", "")
        NameArray(2) = GetSetting("FreeSCAN", "Settings", "Hist2", "")
        NameArray(3) = GetSetting("FreeSCAN", "Settings", "Hist3", "")
        NameArray(4) = GetSetting("FreeSCAN", "Settings", "Hist4", "")
        KeyArray(0) = GetSetting("FreeSCAN", "Settings", "Key0", "")
        KeyArray(1) = GetSetting("FreeSCAN", "Settings", "Key1", "")
        KeyArray(2) = GetSetting("FreeSCAN", "Settings", "Key2", "")
        KeyArray(3) = GetSetting("FreeSCAN", "Settings", "Key3", "")
        KeyArray(4) = GetSetting("FreeSCAN", "Settings", "Key4", "")
        'is this already in history? then exity
        For intCnt = 0 To 4
            If strDesc = NameArray(intCnt) Then
                Exit Sub
            End If
        Next intCnt
        'its not in the history, so push everything down by one then overwrite the last entry
        For intCnt = 4 To 1 Step -1
            KeyArray(intCnt) = KeyArray(intCnt - 1)
            NameArray(intCnt) = NameArray(intCnt - 1)
        Next
        NameArray(0) = strDesc
        KeyArray(0) = strKey

        'Save to registry
        For intCnt = 0 To 4
            SaveSetting("FreeSCAN", "Settings", "Hist" & CStr(intCnt), NameArray(intCnt))
            SaveSetting("FreeSCAN", "Settings", "Key" & CStr(intCnt), KeyArray(intCnt))
        Next
        'Reload the history menu
        If Me.Visible Then
            LoadHistory()
        ElseIf frmRRTrn.Visible Then
            frmRRTrn.LoadHistory()
        End If

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

    Private Sub frmRRCon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim iBuff As String, cnt As Integer
        'Load the history menu
   
        Try
            LoadHistory()
            iBuff = GetSetting("FreeSCAN", "Settings", "MiscGroup", "0")
            If iBuff = "0" Then
                chkMiscGroup.Checked = False
            Else
                chkMiscGroup.Checked = True
            End If

            iBuff = GetSetting("FreeSCAN", "Settings", "MiscGroupIDX", "1")
            If Val(iBuff) > -1 And Val(iBuff) <= cmbNumMisc.Items.Count Then
                cmbNumMisc.SelectedIndex = Val(iBuff)
            End If
            cmbQK.Items.Clear()
            cmbQK.Items.Add(".")
            For cnt = 0 To 99
                cmbQK.Items.Add(CStr(cnt))
            Next
            cmbQK.SelectedIndex = 0
        Catch ex As Exception
            Console.WriteLine("RRConLoadEvent: " & ex.Message)
        End Try
    End Sub

    Private Sub _StatusBar_Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _StatusBar_Panel1.Click

    End Sub
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
    Sub SaveSkipTagSelectionConv()
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
        Call SaveSkipTagSelectionConv()

    End Sub

    Private Sub lstTag_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstTag.MouseUp
        Call SaveSkipTagSelectionConv()

    End Sub

    Private Sub chkMiscGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMiscGroup.CheckedChanged
        'Save to registry
        SaveSetting("FreeSCAN", "Settings", "MiscGroup", chkMiscGroup.CheckState)
    End Sub

    Private Sub cmbNumMisc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNumMisc.SelectedIndexChanged
        'Save setting
        SaveSetting("FreeSCAN", "Settings", "MiscGroupIDX", cmbNumMisc.SelectedIndex)
    End Sub

    Private Sub cmdPrevFreq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdFindQK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindQK.Click
        Try
            cmbQK.Text = CStr(FindFreeQK())
        Catch ex As Exception
            Console.WriteLine("RRCONV:CMDFINDQK: " & ex.Message)
        End Try
    End Sub
End Class
