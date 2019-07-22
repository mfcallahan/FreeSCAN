Imports System.IO
Public Class frmGPSSummary
    Dim ComplainedAboutIt As Boolean = False
    Sub ReadyForm()
        Call cmdLoadSystemList_Click(Nothing, Nothing)
        ' If cmbSysName.Items.Count >= 2 Then
        ' cmbSysName.SelectedIndex = 1
        ' End If
        LoadMap()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Function RetCode(ByRef Lat As String, ByRef Longitude As String, ByRef Range As String, ByRef Title As String, ByRef Type As String, ByVal index As Integer) As String
        Dim Code As String = Nothing
        Dim BaseCode As String
        Dim LineColor, FillColor As String

        'Generate HTML code for drawing circles and markers
        'on google maps
        Select Case Type
            Case "0" 'conv system
                LineColor = "#000080"
                FillColor = "#0000FF"
            Case "1" 'conv group, green
                LineColor = "#06F400"
                FillColor = "#06F400"
            Case "2" 'site
                LineColor = "#E20005"
                FillColor = "#E20005"
            Case Else 'tgid group
                LineColor = "#F4A600"
                FillColor = "#F4A600"
        End Select
        Dim CircleName As String = "circle" & CStr(index)
        Dim MarkerName As String = "marker" & CStr(index)

        BaseCode = "    var MARKERNAME = new google.maps.Marker({draggable: false,title: 'TITLEBARSPEC',position:  new google.maps.LatLng(LATSPEC, LONGSPEC)});"
        BaseCode &= "  MARKERNAME.bindTo('map', this);"
        BaseCode &= "var CIRCLENAME = new google.maps.Circle({ strokeWeight: 1,center:new google.maps.LatLng(LATSPEC, LONGSPEC),"
        BaseCode &= "radius:RADIUS_MILES,strokeColor:DBLQUOTEFillColorDBLQUOTE,fillColor:DBLQUOTELineColorDBLQUOTE,map:map});"



        If Val(Range) > 250 Then
            Range = "250"
        End If
        BaseCode = Replace(BaseCode, "CIRCLENAME", CircleName)
        BaseCode = Replace(BaseCode, "MARKERNAME", MarkerName)
        BaseCode = Replace(BaseCode, "DBLQUOTE", Chr(34))
        BaseCode = Replace(BaseCode, "LATSPEC", Lat)
        BaseCode = Replace(BaseCode, "LONGSPEC", Longitude)
        If radKM.Checked Then 'Strangely RADIUS_MILES is apparently in kilometers
            BaseCode = Replace(BaseCode, "RADIUS_MILES", Str(Val(Range)) * 1000)
        Else
            BaseCode = Replace(BaseCode, "RADIUS_MILES", Str((Val(Range) * 1.60934)) * 1000)
        End If

        BaseCode = Replace(BaseCode, "TITLEBARSPEC", Title)
        BaseCode = Replace(BaseCode, "FillColor", FillColor)
        BaseCode = Replace(BaseCode, "LineColor", LineColor)
        Return BaseCode
    End Function

    Private Sub cmbSysName_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        Call LoadMap()
    End Sub
    Sub LoadMap()
        'draws a summary of all coordinates loaded on the database
        Dim Point(2000, 4) As String
        '0=LAT, LONG, 2=RANGE, 3=TITLE, 4=TYPE 
        'TYPES:0=CONV SYS, 1=CONV GROUP, 2=SITE, 3=TGID GROUP
        Dim Idx, PointIDX As Integer
        Dim DocSTART As String
        Dim DocEND As String
        Dim TempDir As String = GetTempFileName() & ".html"
        Dim BaseCode As String
        Dim intFile, MaxSysToDraw As Integer
        Dim CodeHold As String
        Dim SysType As String
        Dim objStreamWriter As StreamWriter
        Dim StartIndex, EndIndex As Integer
        Dim mapX As Integer = WebSee.Width
        Dim mapY As Integer = WebSee.Height
        Dim Response As Integer, CentreX, CentreY As String
        Dim SingleSite As Boolean = False
        Dim MapHeight As String
        Dim PointSet As Boolean = False
        BaseCode = My.Resources.SystemPlotter.ToString

        '0=lat, 1=lon, 2=range miles, 3=text label
        'So now go through every system, etc

        If blnDebug = False Then On Error Resume Next
        'Draws a map of the system on the tree
        Dim intSysIndex, CGroup As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        PointIDX = -1
        CentreX = "44.00000000"
        CentreY = "-76.0000000"
        MapHeight = Str(Me.Height)
        For intSysIndex = 1 To chkSysList.Items.Count
            'find out if there are valid coords for this, if so add to database
            SysType = varSite(intSysIndex, 0, 0, 3)
            If SysType = "1" And chkSysList.GetItemChecked(intSysIndex - 1) Then 'conv system
                'does it have good gps coords? if so add it to the database
                If Val(varSite(intSysIndex, 0, 0, 19)) <> 0 Or SingleSite Then
                    PointIDX += 1
                    Point(PointIDX, 0) = varSite(intSysIndex, 0, 0, 19)
                    Point(PointIDX, 1) = varSite(intSysIndex, 0, 0, 20)
                    Point(PointIDX, 2) = varSite(intSysIndex, 0, 0, 21)
                    Point(PointIDX, 3) = "[CONVSYS] " & varSite(intSysIndex, 0, 0, 1)
                    Point(PointIDX, 4) = "0"
                End If
            End If
            If SysType <> "" And chkSysList.GetItemChecked(intSysIndex - 1) Then
                For CGroup = 1 To MaxGroups 'loop through all possible groups and display them onscreen
                    If varSite(intSysIndex, CGroup, 0, 5) = "1" Then ' is this a conv group?
                        If Val(varSite(intSysIndex, CGroup, 0, 6)) <> 0 Then 'gps coords good?
                            PointIDX += 1
                            Point(PointIDX, 0) = varSite(intSysIndex, CGroup, 0, 6)
                            Point(PointIDX, 1) = varSite(intSysIndex, CGroup, 0, 7)
                            Point(PointIDX, 2) = varSite(intSysIndex, CGroup, 0, 8)
                            Point(PointIDX, 3) = "[CONVGRP] " & varSite(intSysIndex, 0, 0, 1) & "/" & varSite(intSysIndex, CGroup, 0, 1)
                            Point(PointIDX, 4) = "1"
                            'PointIDX += 1
                        End If
                    ElseIf varSite(intSysIndex, CGroup, 0, 5) = "2" Then 'tgid group
                        If Val(varSite(intSysIndex, CGroup, 0, 6)) <> 0 Then 'gps coords good?
                            PointIDX += 1
                            Point(PointIDX, 0) = varSite(intSysIndex, CGroup, 0, 6)
                            Point(PointIDX, 1) = varSite(intSysIndex, CGroup, 0, 7)
                            Point(PointIDX, 2) = varSite(intSysIndex, CGroup, 0, 8)
                            Point(PointIDX, 3) = "[TGID GRP] " & varSite(intSysIndex, 0, 0, 1) & "/" & varSite(intSysIndex, CGroup, 0, 1)
                            '  PointIDX += 1
                            Point(PointIDX, 4) = "3"
                        End If
                    ElseIf varSite(intSysIndex, CGroup, 0, 5) = "3" Then 'A site
                        If Val(varSite(intSysIndex, CGroup, 0, 13)) <> 0 Or SingleSite Then 'gps coords good?
                            PointIDX += 1
                            Point(PointIDX, 0) = varSite(intSysIndex, CGroup, 0, 13)
                            Point(PointIDX, 1) = varSite(intSysIndex, CGroup, 0, 14)
                            Point(PointIDX, 2) = varSite(intSysIndex, CGroup, 0, 15)
                            Point(PointIDX, 3) = "[SITE] " & varSite(intSysIndex, 0, 0, 1) & "/" & varSite(intSysIndex, CGroup, 0, 1)
                            '
                            'PointIDX += 1
                            Point(PointIDX, 4) = "2"
                        End If
                    End If

                Next CGroup
            End If
            If PointIDX = 2000 Then Exit For
        Next intSysIndex
        If PointIDX > 300 And Not ComplainedAboutIt Then
            Response = MsgBox("You have selected a large number of points. As a result, drawing may be very slow. Do you " & _
                "wish to continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Draw all points?")
            Select Case Response
                Case 7 ' no
                    Exit Sub
                Case 6 ' yes, quit bitching
                    ComplainedAboutIt = True
            End Select
        End If

        'Now that we have out information, build the HTML code
        Dim JavaBuff As String
        For Idx = 0 To PointIDX
            Point(Idx, 0) = DMSToDec(Point(Idx, 0))
            Point(Idx, 1) = DMSToDec(Point(Idx, 1))
            Point(Idx, 3) = Replace(Point(Idx, 3), "'", " ")

            CodeHold = RetCode(Point(Idx, 0), Point(Idx, 1), Point(Idx, 2), Point(Idx, 3), Point(Idx, 4), Idx)

            JavaBuff &= CodeHold & vbCrLf
            'calculate middle spot in map, at least for the first hit
            If Val(Point(Idx, 0)) <> 0 And Not PointSet Then
                ' CentreX = ((CentreX * (Idx + 1)) + Val(Point(Idx, 0))) / (Idx + 2)
                ' CentreY = ((CentreY * (Idx + 1)) + Val(Point(Idx, 1))) / (Idx + 2)
                CentreX = Point(Idx, 0)
                CentreY = Point(Idx, 1)
                PointSet = True
            End If
        Next
        BaseCode = Replace(BaseCode, "JAVASCRIPTREPLACE", JavaBuff)
     

        BaseCode = Replace(BaseCode, "DBLQUOTE", Chr(34))
        'Dim CenString As String = Strings.Left(Str(CentreX), 7)

        BaseCode = Replace(BaseCode, "Map_Centre_X", Strings.Left(Str(CentreX), 11))
        BaseCode = Replace(BaseCode, "Map_Centre_Y", Strings.Left(Str(CentreY), 11))
        BaseCode = Replace(BaseCode, "GPSMAPHEIGHT", MapHeight)
        intFile = FreeFile()
        objStreamWriter = New StreamWriter(TempDir)
        objStreamWriter.WriteLine(BaseCode)
        objStreamWriter.Close()

        WebSee.Url = New Uri(TempDir)
        WebSee.Select()
        Me.Cursor = Cursors.Default
    End Sub

    Sub cmdLoadSystemList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadSystemList.Click
        'Prepares combo box
        chkSysList.Items.Clear()

        Dim sysIdx As Integer
        Dim SysNum As Integer
        For SysNum = 1 To MaxSystems
            If varSite(SysNum, 0, 0, 3) <> "" Then
                sysIdx = chkSysList.Items.Add(varSite(SysNum, 0, 0, 1))
                If varSite(SysNum, 0, 0, 56) = "1" Then 'auto enable this system
                    chkSysList.SetItemChecked(sysIdx, True)
                End If

            End If
        Next
        'chkSysList.SelectedIndex = 0


    End Sub

    Private Sub cmdReloadMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReloadMap.Click
        Call LoadMap()
    End Sub

    Private Sub frmGPSSummary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkSysList_ItemCheck(sender As Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles chkSysList.ItemCheck
        Try
            'User has checked or unchecked an item so update the system
            Dim sysIdx As Integer
            For sysIdx = 1 To UBound(varSite)
                If sysIdx > chkSysList.Items.Count Then
                    Exit For
                End If
                If chkSysList.GetItemChecked(sysIdx - 1) Then
                    varSite(sysIdx, 0, 0, 56) = "1"
                Else
                    varSite(sysIdx, 0, 0, 56) = "0"
                End If
            Next
        Catch ex As Exception
            If blnDebug Then
                MsgBox("GPSSummary - SysListItemCheck - Fault - " & ex.InnerException.ToString)
            End If
        End Try
    End Sub

    Private Sub chkSysList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles chkSysList.SelectedIndexChanged

    End Sub

    Private Sub AutoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AutoToolStripMenuItem.Click
        'Put checkmarks below any system that has a group or site enabled

        Dim x As Integer, GroupIdx, bState As CheckState, SysType As String
        'Sanity check
        If chkSysList.Items.Count > UBound(varSite) Then
            Exit Sub
        End If
        For x = 1 To chkSysList.Items.Count
            bState = CheckState.Unchecked
            SysType = varSite(x, 0, 0, 3)

            'is the system enabled? 
            If SysType = "1" And varSite(x, 0, 0, 22) = "1" Then
                bState = CheckState.Checked
            ElseIf SysType <> "" Then 'System not enabled? Then go deeper and check
                For GroupIdx = 1 To MaxGroups
                    'check for conventional group
                    If varSite(x, GroupIdx, 0, 5) = "1" And varSite(x, GroupIdx, 0, 9) = "1" Then
                        bState = CheckState.Checked
                        Exit For
                    End If
                    'check for trunk group
                    If varSite(x, GroupIdx, 0, 5) = "2" And varSite(x, GroupIdx, 0, 9) = "1" Then
                        bState = CheckState.Checked
                        Exit For
                    End If
                    'check for trunk site
                    If varSite(x, GroupIdx, 0, 5) = "3" And varSite(x, GroupIdx, 0, 16) = "1" Then
                        bState = CheckState.Checked
                        Exit For
                    End If

                Next
            End If

            chkSysList.SetItemCheckState(x - 1, bState)
        Next
    End Sub

    Private Sub AllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllToolStripMenuItem.Click
        'Select all systems
        Dim x As Integer
        For x = 0 To chkSysList.Items.Count - 1
            chkSysList.SetItemCheckState(x, CheckState.Checked)
        Next
    End Sub

    Private Sub NoneToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NoneToolStripMenuItem.Click
        'Select all systems
        Dim x As Integer
        For x = 0 To chkSysList.Items.Count - 1
            chkSysList.SetItemCheckState(x, CheckState.Unchecked)
        Next
    End Sub
End Class