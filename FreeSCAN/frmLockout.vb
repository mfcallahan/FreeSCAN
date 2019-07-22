Option Strict Off
Option Explicit On
Friend Class frmLockout
	Inherits System.Windows.Forms.Form
	
    Function BuildGridArray() As Integer()
        'Build up the intGridSel variable, which is an array
        'of all currently selected rows, depending on the grid
        Dim intRowSelCount As Integer
        Dim intCnt As Integer
        Dim varGrid As DataGridView
        Dim intGridSel() As Integer
        If Not blnDebug Then On Error Resume Next
        varGrid = Me.grdLO

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
    Sub UpdateSysEditor()
        With lblSiteNote
            If .grdConvChan.Visible = True Then
                .LoadConvChanGrid()
            ElseIf .grdtGID.Visible = True Then
                .LoadTrunkChanGrid()
            End If
        End With

    End Sub

    Private Sub frmLockout_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        grdLO.Height = VB6.TwipsToPixelsY(MakePositive(VB6.PixelsToTwipsY(Me.Height) - (VB6.PixelsToTwipsY(Frame1.Height) + 650)))
        Frame1.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(grdLO.Height) + 120)
    End Sub


    Private Sub grdLO_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'This jumps the system editor to the correct system/channel
        Dim ChanIndex, intChan As Integer
        Dim band As DataGridViewBand
        If blnDebug = False Then On Error Resume Next
        '        intChan = CInt(ChanShadow(grdLO.Row, 1))
        'if this is a deleted channel, exit now
        If ChanInfo(intChan, 10) = "" Then
            MsgBox("Channel no longer exists.")
            Exit Sub

        End If
        GetOwner((intChan))
        If lngChanSys > 0 Then
            intCurrentSys = lngChanSys
            intCurrentGroup = lngChanGroup

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
                'UPGRADE_WARNING: Lower bound of collection frmSystemEditor.StatusBar.Panels has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                lblSiteNote.StatusBar.Items.Item(2).Text = varSite(intCurrentSys, 0, 0, 1) & " - " & varSite(intCurrentSys, intCurrentGroup, 0, 1)
            Else
                'UPGRADE_WARNING: Lower bound of collection frmSystemEditor.StatusBar.Panels has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                lblSiteNote.StatusBar.Items.Item(2).Text = varSite(intCurrentSys, 0, 0, 1)
            End If
            UpdateTreeSelection()
        Else
            'can't determine channe
            MsgBox("Can't jump to this channel.")
        End If
        Me.Activate()

    End Sub

    Private Sub grdLO_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLO.CellClick

        If blnDebug = False Then On Error Resume Next
        Dim intLock, intChan As Integer
        Dim SelCol As Integer = e.ColumnIndex
        Dim SelRow As Integer = e.RowIndex
        With grdLO
            If SelCol = 5 Then 'l/o column
                'is this channel locked or unlock?
                If grdLO(SelCol, SelRow).Value = "L/O" Then
                    intLock = 0
                    grdLO(SelCol, SelRow).Value = Nothing
                Else
                    intLock = 1
                    grdLO(SelCol, SelRow).Value = "L/O"
                End If
                intChan = CInt(ChanShadow(SelRow + 1, 1))
                If optMode(0).Checked = True Then 'conventional channel mode
                    ChanInfo(intChan, 5) = CStr(intLock)
                Else
                    ChanInfo(intChan, 3) = CStr(intLock)
                End If

                Call UpdateSysEditor()
                blnChgSaved = False
            End If


        End With

    End Sub

    Sub cmdRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        If blnDebug = False Then On Error Resume Next
        'Generates a list of locked out channels
        Dim lngSys, lngCnt, lngGroup As Integer
        Dim j, lngNumChan, i, intParam As Integer
        Dim intDupes As Integer
        Dim strGroup(MaxGroups) As String
        Dim blnConv As Boolean
        blnConv = optMode(0).Checked 'should this be in conv or trunked mode?
        grdLO.RowCount = 0
        lngNumChan = 0
        'count the number of channel that need to be done
        For lngCnt = 1 To MaxChan
            If ChanInfo(lngCnt, 9) <> "" And blnConv And ChanInfo(lngCnt, 5) = "1" Then
                lngNumChan = lngNumChan + 1
            ElseIf ChanInfo(lngCnt, 9) = "" And ChanInfo(lngCnt, 10) <> "" And blnConv = False And ChanInfo(lngCnt, 3) = "1" Then
                lngNumChan = lngNumChan + 1
            End If
        Next lngCnt
        ReDim ChanShadow(lngNumChan * 2, MaxChanSetting + 1)
        'Copy all the channels we are interested in into the buffer
        intDupes = 0
        For lngCnt = 1 To MaxChan
            If blnConv = False Then
                If ChanInfo(lngCnt, 9) = "" And ChanInfo(lngCnt, 10) <> "" And ChanInfo(lngCnt, 3) = "1" Then 'TGID
                    'Copy channel to buffer, add origanol as index
                    intDupes = intDupes + 1
                    ChanShadow(intDupes, 2) = ChanInfo(lngCnt, 2) 'freq/tgid
                    ChanShadow(intDupes, 1) = CStr(lngCnt) 'store origanol position
                    GetOwner((lngCnt))
                    ChanShadow(intDupes, 3) = varSite(lngChanSys, 0, 0, 1)
                    ChanShadow(intDupes, 4) = varSite(lngChanSys, lngChanGroup, 0, 1)
                    ChanShadow(intDupes, 5) = ChanInfo(lngCnt, 1) 'tag
                    'need to save system and group name as well
                    'ChanShadow(intDupes, 9) = "" 'save tone
                End If
            Else
                If ChanInfo(lngCnt, 9) <> "" And ChanInfo(lngCnt, 5) = "1" Then 'conventional
                    'Copy channel to buffer, add origanol as index
                    intDupes = intDupes + 1
                    ChanShadow(intDupes, 2) = CStr(Val(ChanInfo(lngCnt, 2)))
                    ChanShadow(intDupes, 1) = CStr(lngCnt) 'store origanol position
                    ChanShadow(intDupes, 9) = ChanInfo(lngCnt, 9) 'save tone
                    GetOwner((lngCnt))
                    ChanShadow(intDupes, 3) = varSite(lngChanSys, 0, 0, 1)
                    ChanShadow(intDupes, 4) = varSite(lngChanSys, lngChanGroup, 0, 1)
                    ChanShadow(intDupes, 5) = ChanInfo(lngCnt, 1) 'tag
                End If
            End If
        Next lngCnt
        Dim best_value(9) As String
        Dim best_j As Single
        For i = 1 To lngNumChan - 1
            For intParam = 0 To 9

                best_value(intParam) = ChanShadow(i, intParam)
            Next intParam
            best_j = i
            For j = i + 1 To lngNumChan
                'sort by system, then group, then freq or TGID

                If ChanShadow(j, 3) < best_value(3) Then
                    For intParam = 0 To 9

                        best_value(intParam) = ChanShadow(j, intParam)
                    Next intParam
                    best_j = j
                ElseIf ChanShadow(j, 3) = best_value(3) And ChanShadow(j, 4) < best_value(4) Then
                    For intParam = 0 To 9
                        best_value(intParam) = ChanShadow(j, intParam)
                    Next intParam
                    best_j = j
                ElseIf ChanShadow(j, 3) = best_value(3) And ChanShadow(j, 4) = best_value(4) And ChanShadow(j, 1) < best_value(1) Then
                    For intParam = 0 To 9
                        best_value(intParam) = ChanShadow(j, intParam)
                    Next intParam
                    best_j = j
                End If
            Next j
            For intParam = 0 To 9
                ChanShadow(best_j, intParam) = ChanShadow(i, intParam)

                ChanShadow(i, intParam) = best_value(intParam)
            Next intParam
        Next i

        With grdLO
            .Rows.Clear()
            If intDupes = 0 Then
                Exit Sub
            End If
            .RowCount = intDupes

            lngSys = 0
            lngGroup = 0
            For lngCnt = 1 To lngNumChan
                'strbuff = ChanInfo(ChanDup(lngCnt), 10)
                'look up the system and group that this belongs to
                'GetOwner (ChanDup(lngCnt))
                grdLO(0, lngCnt - 1).Value = Str(lngCnt)

                grdLO(1, lngCnt - 1).Value = ChanShadow(lngCnt, 3) 'sys name
                grdLO(2, lngCnt - 1).Value = ChanShadow(lngCnt, 4) 'grp name
                grdLO(3, lngCnt - 1).Value = ChanShadow(lngCnt, 5) 'tag

                If blnConv Then
                    grdLO(4, lngCnt - 1).Value = FormatFreq(Val(ChanShadow(lngCnt, 2))) 'freq                 
                Else
                    grdLO(4, lngCnt - 1).Value = ChanShadow(lngCnt, 2)

                End If
                grdLO(5, lngCnt - 1).Value = "L/O"
            Next lngCnt
        End With
    End Sub

    Private Sub cmdBulkClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBulkClear.Click
        Dim Response As Integer
        Dim intRow, intchan As Integer


        Response = MsgBox("Are you sure you want to unlock all channels?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Unlock All?")
        If Response <> 6 Then Exit Sub
        'build an array of channels that need to be nuked

        For intRow = 1 To grdLO.RowCount
            intchan = Val(ChanShadow(intRow, 1))
            'is it trunked?
            If ChanInfo(intchan, 9) = "" Then
                ChanInfo(intchan, 3) = "0"
            Else
                ChanInfo(intchan, 5) = "0"
            End If
            grdLO(5, intRow - 1).Value = Nothing
        Next intRow
        blnChgSaved = False
        Call UpdateSysEditor()
    End Sub

    Private Sub cmdUnlock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnlock.Click
        Dim Response As Integer
        Dim strMsg As String
        Dim intParam, intRow, intChan, intBuff As Integer

        Dim iSelGrid() As Integer = BuildGridArray()
        If blnDebug = False Then On Error Resume Next
        If Not IsArray(iSelGrid) Then Exit Sub

        'do multi channel unlock, otherwise single channel
        intBuff = 0
        'build an array of channels that need to be nuked
        For intRow = 0 To UBound(iSelGrid)
            intChan = Val(ChanShadow(iSelGrid(intRow) + 1, 1))
            'is it trunked?
            If ChanInfo(intChan, 9) = "" Then
                ChanInfo(intChan, 3) = "0"
            Else
                ChanInfo(intChan, 5) = "0"
            End If
            grdLO(5, iSelGrid(intRow)).Value = Nothing

        Next intRow
        'Exit Sub

        Call UpdateSysEditor()
        blnChgSaved = False
        grdLO.Focus()
    End Sub

    Private Sub cmdNuke_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuke.Click
        Dim Response As Integer = 6
        Dim strMsg As String
        Dim intParam, intRow, intChan, intBuff As Integer
        Dim NukeArray(1000) As Single
        Dim iSelGrid() As Integer = BuildGridArray()
        If Not IsArray(iSelGrid) Then Exit Sub
        strMsg = "Are you sure you want to delete the selected channels?"

        If ChkConf.CheckState = 1 Then
            Response = MsgBox(strMsg, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete channel(s)?")
        End If
        intBuff = 0
        'build an array of channels that need to be nuked
        For intRow = 0 To UBound(iSelGrid)
            intChan = Val(ChanShadow(iSelGrid(intRow) + 1, 1))
            For intParam = 0 To MaxChanSetting
                ChanInfo(intChan, intParam) = Nothing
            Next intParam
        Next intRow
        Call UpdateSysEditor()
        Call cmdRefresh_Click_1(cmdRefresh, New System.EventArgs())
        blnChgSaved = False
    End Sub
End Class