Public Class frmDupeN_N
    Public strMode, strType As String
    Private Sub chkPL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPL.CheckedChanged

    End Sub
    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Me.Visible = False
        Me.Close()
    End Sub

    Private Sub cmdJump_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Private Sub cmdNuke_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
  

    End Sub

    Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    Function BuildGridArray() As Integer()
        'Build up the intGridSel variable, which is an array
        'of all currently selected rows, depending on the grid
        Dim intRowSelCount As Integer
        Dim intCnt As Integer
        Dim varGrid As DataGridView
        Dim intGridSel() As Integer
        If Not blnDebug Then On Error Resume Next
        varGrid = Me.DupeGrid

        Erase intGridSel
        intRowSelCount = varGrid.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If intRowSelCount = 0 Then
            BuildGridArray = Nothing
            Exit Function
        End If

        'build an array of all selected rows
        ReDim intGridSel(intRowSelCount - 1)
        For intCnt = 0 To intRowSelCount - 1
            intGridSel(intCnt) = CInt(varGrid.SelectedRows(intCnt).Index.ToString)
        Next intCnt
        Array.Sort(intGridSel)
        BuildGridArray = intGridSel
    End Function


    Private Sub cmdCLose_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCLose.Click
        Me.Visible = False
    End Sub

    Private Sub cmdJump_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdJump.Click
        'This jumps the system editor to the correct system/channel
        Dim intChan As Integer
        If blnDebug = False Then On Error Resume Next

        intChan = ChanDup(DupeGrid.SelectedRows(0).Index + 1)
        'if this is a deleted channel, exit now
        If ChanInfo(intChan, 10) = Nothing Then
            MsgBox("Channel no longer exists.")
            Exit Sub

        End If
        GetOwner((intChan))
        If lngChanSys > 0 Then
            intCurrentSys = lngChanSys
            intCurrentGroup = lngChanGroup
            UpdateTreeSelection()
            intChan = FindChanNum(intChan) 'convert it back into a icc type channel number
            If varSite(intCurrentSys, 0, 0, 3) = "1" Then
                lblSiteNote.ViewMode("CONVSYSGROUP") 'bring up the grid
                With lblSiteNote.grdConvChan
                    lblSiteNote.blnBusy = True
                    .CurrentCell = lblSiteNote.grdConvChan(0, intChan - 1)
                    lblSiteNote.blnBusy = False
                End With
            Else
                lblSiteNote.ViewMode("GROUPTRUNK") 'bring up the grid
                With lblSiteNote.grdTGID
                    lblSiteNote.blnBusy = True
                    .CurrentCell = lblSiteNote.grdTGID(0, intChan - 1)
                    lblSiteNote.blnBusy = False
                End With
            End If
            If intCurrentGroup > 0 Then
                lblSiteNote.StatusBar.Items.Item(1).Text = varSite(intCurrentSys, 0, 0, 1) & " - " & varSite(intCurrentSys, intCurrentGroup, 0, 1)
            Else
                lblSiteNote.StatusBar.Items.Item(1).Text = varSite(intCurrentSys, 0, 0, 1)
            End If

        Else
            'can't determine channe
            MsgBox("Can't jump to this channel.")
        End If
        Me.Activate()
    End Sub

    Private Sub cmdRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call lblSiteNote.FindDupe(strMode, strType)
    End Sub

    Private Sub cmdNuke_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuke.Click
        'Delete select row
        Dim intCnt, Response As Integer
        Dim ChanIndex, intRow As Integer
        Dim iSelRow() As Integer = BuildGridArray()

        'Put things in right order

        If Not IsArray(iSelRow) Then
            Response = MsgBox("Please select the channel(s) you would like to delete.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        'delete multiple channels
        If ChkConf.CheckState = 1 Then
            Response = MsgBox("Are you sure you wish to delete the selected channels?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        Else
            Response = 6
        End If
        Select Case Response
            Case 6 'proceed with delete
                For intRow = 0 To UBound(iSelRow)
                    ChanIndex = ChanDup(iSelRow(intRow) + 1)
                    'clear the grid
                    DupeGrid.Rows(iSelRow(intRow)).Visible = False
                    'delete the channel
                    For intCnt = 0 To MaxChanSetting
                        ChanInfo(ChanIndex, intCnt) = Nothing
                    Next intCnt
                Next intRow
                blnChgSaved = False
            Case 7
                Exit Sub
        End Select
    End Sub

    Private Sub cmdAutoNuke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class