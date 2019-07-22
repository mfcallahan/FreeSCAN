Option Strict Off
Option Explicit On
Friend Class frmGPS
	Inherits System.Windows.Forms.Form
    Dim Coords(1) As String '0=latitude, 1=longitude
    Const SmallSize As Integer = 341 'size of window when map invisible
    Public Const LargeSize As Integer = 800 ' size of window when map visible
    Sub LoadCoords()
        'Retrieves user entered coordinates
        'sanitizes, validates and saves
        'lat long to coords array
        Coords(0) = Nothing
        Coords(1) = Nothing
        Dim sBuff As String
        Dim sPoint() As String
        Dim Validate As Boolean = True
        Dim DVal As Double
        sBuff = txtGPS.Text
        If Len(sBuff) < 3 Then
            Validate = False
        End If
        If InStr(sBuff, ",") = 0 Then
            Validate = False
        End If
        sPoint = Split(sBuff, ",")
        If safeubound(sPoint) <> 1 Then
            Validate = False
        End If
        If Not Validate Then
            MsgBox("Invalid coordinates entered. Try again following the example. Use decimal format only.", MsgBoxStyle.Exclamation, "Invalid Input")
            Exit Sub
        End If
        sPoint(0) = CStr(Val(sPoint(0)))
        sPoint(1) = CStr(Val(sPoint(1)))

        'Validate ranges
        'Longitude
        DVal = CDbl(sPoint(1))
        If DVal > 180 Or DVal < -180 Then
            Validate = False
        End If
        DVal = CDbl(sPoint(0)) 'latitude
        If DVal > 90 Or DVal < -90 Then
            Validate = False
        End If


        'save the cleaned up coordinates
        Coords(0) = sPoint(0)
        Coords(1) = sPoint(1)
    End Sub

	Private Sub cmdApplyGPS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdApplyGPS.Click
        LoadCoords()
        If Coords(0) = Nothing Then Exit Sub
        Coords(0) = Val(Coords(0)) ' * 1000000
        Coords(1) = Val(Coords(1)) '* 1000000
        Dim Lat, Lon As String
        Lat = DecToDMS(Coords(0), True)
        Lon = DecToDMS(Coords(1), False)
        Lat = Replace(Lat, ".", Nothing)
        Lon = Replace(Lon, ".", Nothing)
        Me.Visible = False
        If lblSiteNote.Enabled = False And lblSiteNote.frmSiteOptConv(0).Visible = True Then
            lblSiteNote.Enabled = True
            lblSiteNote.Activate()
            'save coordinates to memory			
            varSite(intCurrentSys, 0, 0, 19) = Lat
            varSite(intCurrentSys, 0, 0, 20) = Lon
            varSite(intCurrentSys, 0, 0, 21) = cmbRange.Text
            With lblSiteNote
                .lblSysLong.Text = FormatDMS(varSite(intCurrentSys, 0, 0, 20))
                .lblSysLat.Text = FormatDMS(varSite(intCurrentSys, 0, 0, 19))
                .lblSysRange.Text = Val(varSite(intCurrentSys, 0, 0, 21)) & " Miles"
                .DispStat("GPS Coordinates updated.")
            End With
        ElseIf lblSiteNote.Enabled = False And lblSiteNote.tabTrunkSite.Visible Then
            'edit for a trunk site
            lblSiteNote.Enabled = True
            lblSiteNote.Activate()
            'save coordinates to memory			
            varSite(intCurrentSys, intCurrentGroup, 0, 13) = Lat
            varSite(intCurrentSys, intCurrentGroup, 0, 14) = Lon
            varSite(intCurrentSys, intCurrentGroup, 0, 15) = cmbRange.Text
            With lblSiteNote
                .lblTrnLong.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 14))
                .lblTrnLat.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 13))
                .lblTrnRange.Text = Val(varSite(intCurrentSys, intCurrentGroup, 0, 15)) & " Miles"
                .DispStat("GPS Coordinates updated.")
            End With
        ElseIf lblSiteNote.grdTGID.Visible Then
            'edit for a trunk site
            lblSiteNote.Enabled = True
            lblSiteNote.Activate()
            'save coordinates to memory
            varSite(intCurrentSys, intCurrentGroup, 0, 6) = Lat
            varSite(intCurrentSys, intCurrentGroup, 0, 7) = Lon
            varSite(intCurrentSys, intCurrentGroup, 0, 8) = cmbRange.Text
            With lblSiteNote
                .lblTGIDLong.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 7))
                .lblTGIDLat.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 6))
                .lblTGIDRange.Text = Val(varSite(intCurrentSys, intCurrentGroup, 0, 8)) & " Miles"
                .DispStat("GPS Coordinates updated.")
            End With
        ElseIf lblSiteNote.grdConvChan.Visible Then
            'edit for a conventional group
            lblSiteNote.Enabled = True
            lblSiteNote.Activate()
            'save coordinates to memory
            varSite(intCurrentSys, intCurrentGroup, 0, 6) = Lat
            varSite(intCurrentSys, intCurrentGroup, 0, 7) = Lon
            varSite(intCurrentSys, intCurrentGroup, 0, 8) = cmbRange.Text
            With lblSiteNote
                .lblCnvGrpLong.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 7))
                .lblCnvGrpLat.Text = FormatDMS(varSite(intCurrentSys, intCurrentGroup, 0, 6))
                .lblCnvGrpRange.Text = Val(varSite(intCurrentSys, intCurrentGroup, 0, 8)) & " Miles"
                .DispStat("GPS Coordinates updated.")
            End With
        End If
        lblSiteNote.Enabled = True
        MarkChange()
    End Sub

    Private Sub cmdCancelGPS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelGPS.Click
        Me.Visible = False
        If lblSiteNote.Enabled = False And lblSiteNote.Visible = True Then
            lblSiteNote.Enabled = True
            lblSiteNote.Activate()
        End If
    End Sub

    Private Sub cmdViewStreet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewStreet.Click
        Dim strLat, strLong As String
        strLat = lblZIPLat.Text
        strLong = lblZIPLong.Text
        If IsNumeric(strLat) And IsNumeric(strLong) Then
            Call GoogleViewDEG(strLat, strLong, 0)
        Else
            MsgBox("FreeSCAN does not have a valid Lat/Long address to lookup")
        End If
    End Sub

    Private Sub cmdViewDMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewDMS.Click
        'Views the current location in google maps

        LoadCoords()
        If Coords(0) = Nothing Then
            Exit Sub
        End If

        Call GoogleViewDEG(Coords(0), Coords(1), cmbRange.Text)

    End Sub

    Private Sub cmdLookUpStreet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLookUpStreet.Click

        Dim strBody As String
        Dim strAdd(5) As String
        Dim strGAddress As String = Nothing
        Dim strTarget As String
        Dim strLat As String = Nothing
        Dim strLong As String = Nothing
        Dim strline(), strBuff As String
        Dim intLine As Integer
        Dim blnValidated As Boolean
        strTarget = Trim(txtAdd0.Text)
        strAdd(5) = "http://maps.googleapis.com/maps/api/geocode/xml?address=STRADD&sensor=false"
        lblGoogleAddress.Text = "Working..."
        cmdLookUpStreet.Enabled = False
        'if a zip code was used, we use that only
        MiniWeb.Url = New Uri("about:blank")
        strTarget = MakeItKosherSilent(strTarget, 2)
        strTarget = Replace(strTarget, Chr(13), ",")
        strTarget = Replace(strTarget, " ", "+")
        strAdd(5) = Replace(strAdd(5), "STRADD", strTarget) 'build the google web address

        Try
            MiniWeb.Url = New Uri(strAdd(5))
            'MiniWeb.Url = New Uri(strAdd(5))
            MiniWeb.Refresh()

            My.Application.DoEvents()
            System.Threading.Thread.Sleep(2000)
            My.Application.DoEvents()
            If MiniWeb.ReadyState = WebBrowserReadyState.Loading Or MiniWeb.IsBusy Then
                System.Threading.Thread.Sleep(3000)
                lblGoogleAddress.Text = "Working...Working..."
            End If
            If MiniWeb.ReadyState = WebBrowserReadyState.Loading Then
                System.Threading.Thread.Sleep(3000)
                lblGoogleAddress.Text = "Working...Working...Working..."
            End If
            My.Application.DoEvents()
            strBody = Nothing
            For intLine = 0 To 20
                My.Application.DoEvents()
                'wait up to 5 seconds
                If Not MiniWeb.IsBusy Then
                    strBody = MiniWeb.Document.Body.InnerText
                End If
                If strBody <> Nothing Then
                    Exit For
                Else
                    System.Threading.Thread.Sleep(500)
                End If
            Next
            My.Application.DoEvents()
            If strBody = Nothing Then
                strBody = MiniWeb.Document.Body.InnerText
            End If
            'If blnDebug Then txtAdd0.Text = strBody
        Catch ex As Exception
            MsgBox("FreeSCAN was unable to download from Google. Check your Internet connection, address, and try again. (" & ex.Message & ")")
            cmdLookUpStreet.Enabled = True
            Exit Sub
        End Try
        'Parse the stuff we want     
        cmdLookUpStreet.Enabled = True
        strline = Split(strBody, Chr(13))
        Dim LatOK As Boolean = False
        Dim LongOK As Boolean = False
        Dim AddrOK As Boolean = False
        For intLine = 0 To UBound(strline)
            strBuff = strline(intLine)
            If InStr(strBuff, "<lat>") <> 0 And Not LatOK Then
                strLat = MakeItKosherSilent(strBuff, 2)
                strLat = Replace(strLat, "<lat>", "")
                strLat = Replace(strLat, "</lat>", "")
                strLat = Trim(strLat)
                LatOK = True
            ElseIf InStr(strBuff, "<lng>") <> 0 And Not LongOK Then
                strLong = MakeItKosherSilent(strBuff, 2)
                strLong = Replace(strLong, "<lng>", "")
                strLong = Replace(strLong, "</lng>", "")
                strLong = Trim(strLong)
                LongOK = True
            ElseIf InStr(strBuff, "<formatted_address>") <> 0 Then
                'get the google address
                strGAddress = Trim(strBuff)
                strGAddress = MakeItKosherSilent(strGAddress, 2)
                strGAddress = Replace(strGAddress, "<formatted_address>", "")
                strGAddress = Replace(strGAddress, "</formatted_address>", "")
                AddrOK = True
            End If
            If LatOK And LongOK And AddrOK Then
                intLine = UBound(strline)
            End If
        Next

        'validate the information as correct
        blnValidated = True
        If Len(strGAddress) < 3 Or Len(strLat) < 5 Or Len(strLong) < 5 Then
            blnValidated = False
        End If
        If IsNumeric(strLat) = False Or IsNumeric(strLong) = False Then
            blnValidated = False
        End If
        If blnValidated Then
            'strLat = strLat
            'strLong = (strLong)
            lblZIPLat.Text = strLat
            lblZIPLong.Text = strLong
            lblGoogleAddress.Text = strGAddress
        Else
            lblZIPLat.Text = "?"
            lblZIPLong.Text = "?"
            lblGoogleAddress.Text = "Could not locate address"
        End If


    End Sub

    Private Sub cmdConvertToDMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvertToDMS.Click
        If Not blnDebug Then On Error Resume Next
        If txtLongDEC.Text = "" Or txtLatDEC.Text = "" Then
            MsgBox("Please specify both latitude and longtitude before converting")
        End If
        lblDMSLong.Text = DecToDMS(CDbl(Val(txtLongDEC.Text)), False)
        lblDMSLat.Text = DecToDMS(CDbl(Val(txtLatDEC.Text)), True)
    End Sub

    Private Sub cmdViewDeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewDeg.Click
        If txtLatDEC.Text = "" Or txtLongDEC.Text = "" Then
            MsgBox("Please enter the Latitude & Longtitude you wish to view.")
            txtLatDEC.Focus()
            Exit Sub
        End If
        Call GoogleViewDEG(txtLatDEC.Text, txtLongDEC.Text, cmbRange.Text)
    End Sub

    Private Sub cmdImportStreet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportStreet.Click
        Dim strLat As String
        Dim strLong As String
        strLong = CDbl(Val(lblZIPLong.Text))
        strLat = CDbl(Val(lblZIPLat.Text))
        ' cmbLat.Text = Strings.Right(strLat, 1)
        ' cmbLong.Text = Strings.Right(strLong, 1)
        txtGPS.Text = strLat & ", " & strLong
        'txtLongDMS.Text = Strings.Left(strLong, Len(strLong) - 1)
        'txtLatDMS.Text = Strings.Left(strLat, Len(strLat) - 1)
    End Sub

    Private Sub cmdImportDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportDec.Click
        Dim strLat As String
        Dim strLong As String
        If Not blnDebug Then On Error Resume Next
        strLong = DecToDMS(CDbl(Val(txtLongDEC.Text)), False)
        strLat = DecToDMS(CDbl(Val(txtLatDEC.Text)), True)
        cmbLat.Text = Strings.Right(strLat, 1)
        cmbLong.Text = Strings.Right(strLong, 1)

        txtLongDMS.Text = Strings.Left(strLong, Len(strLong) - 1)
        txtLatDMS.Text = Strings.Left(strLat, Len(strLat) - 1)
    End Sub

    Private Sub frmGPS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        lblSiteNote.Enabled = True
        Me.Width = SmallSize
    End Sub



    Private Sub frmGPS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub frmGPS_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        Me.Width = SmallSize
        cmdShrink.Visible = False
    End Sub

    Private Sub cmdShrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShrink.Click
        If Me.Width > SmallSize Then
            TmrClose.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrClose.Tick
        If Not blnDebug Then On Error Resume Next

        'Shrinks the Window down by 10% every time
        Dim iCycle, iSize, iStep As Integer
        iSize = Me.Width
        iStep = Int((Me.Width - SmallSize) * 0.85)
        iStep = SmallSize + iStep
        Me.Width = iStep
        If Me.Width = SmallSize Or Me.Width - SmallSize < 15 Then
            Me.Width = SmallSize
            TmrClose.Enabled = False
            cmdShrink.Visible = False
            WebSee.Visible = False
        End If
    End Sub

    Private Sub TmrOpen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrOpen.Tick
        If Not blnDebug Then On Error Resume Next

        If Me.Width = LargeSize Then
            TmrOpen.Enabled = False
            WebSee.Visible = True
            Exit Sub
        End If
        'Inceases the Window up by 10% every time
        Dim iCycle, iSize, iStep As Integer
        iSize = Me.Width
        iStep = Int((LargeSize - Me.Width) * 0.22)
        If iStep < 5 Then iStep = 5
        iStep = Me.Width + iStep
        If iStep > LargeSize Then iStep = LargeSize
        Me.Width = iStep
        cmdShrink.Visible = True
        If Me.Width >= LargeSize Or LargeSize - Me.Width < 10 Then
            Me.Width = LargeSize
            TmrOpen.Enabled = False

            WebSee.Visible = True
        End If
        My.Application.DoEvents()
    End Sub
End Class