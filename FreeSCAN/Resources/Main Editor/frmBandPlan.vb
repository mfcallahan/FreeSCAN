Public Class frmBandPlan
    Public Sub LoadGrid()
        Dim intRow As Integer
        Dim intCol As Integer
        Dim strBuff As String = Nothing
        If Not blnDebug Then On Error Resume Next
        With grdBP
            .Rows.Clear()
            .RowCount = 31
            'load data
            For intRow = 0 To 30
                'lower edge
                grdBP(0, intRow).Value = FormatFreq(Val(BandData(intRow, 0)))
                'upper edge
                grdBP(1, intRow).Value = FormatFreq(Val(BandData(intRow, 1)))
                'modulation
                grdBP(2, intRow).Value = BandSet(intRow, 1)
                'step size
                strBuff = BandSet(intRow, 0)
                strBuff = CStr(Val(strBuff) / 100)
                grdBP(3, intRow).Value = strBuff
                'remark
                grdBP(4, intRow).Value = BandData(intRow, 4)
            Next
        End With
    End Sub

    Private Sub frmBandPlan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Ready the combo boxes
        Dim x As Integer = 0
        Dim strBuff As String
        With colMod
            .Items.Clear()
            For x = 1 To 5
                .Items.Add(ModMode(x))
            Next
        End With
        With colStep
            .Items.Clear()
            For x = 1 To 11
                strBuff = StepSizeFull(x, 1)
                strBuff = CStr(Val(strBuff) / 100)
                .Items.Add(strBuff)
            Next
        End With
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        'Apply changes
        If Not blnDebug Then On Error Resume Next
        Dim RowNum As Integer
        Dim strBuff As String
        For RowNum = 0 To 30
            'Save step size, direct format
            strBuff = CStr(grdBP(3, RowNum).Value)
            strBuff = CStr(Val(strBuff) * 100) 'lose then k
            BandSet(RowNum, 0) = strBuff
            'modulation
            BandSet(RowNum, 1) = CStr(grdBP(2, RowNum).Value)
        Next
        blnChgSaved = False
        Me.Visible = False
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Visible = False
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        'Load default band plan
        If Not blnDebug Then On Error Resume Next
        Dim x As Integer = 0
        Dim intRow As Integer
        Dim intCol As Integer
        Dim strBuff As String = Nothing

        With grdBP
            .Rows.Clear()
            .RowCount = 31
            'load data
            For intRow = 0 To 30
                'lower edge
                grdBP(0, intRow).Value = FormatFreq(Val(BandData(intRow, 0)))
                'upper edge
                grdBP(1, intRow).Value = FormatFreq(Val(BandData(intRow, 1)))
                'modulation
                grdBP(2, intRow).Value = BandData(intRow, 2)
                'step size
                strBuff = BandData(intRow, 3)
                strBuff = CStr(Val(strBuff) / 100)
                grdBP(3, intRow).Value = strBuff
                'remark
                grdBP(4, intRow).Value = BandData(intRow, 4)
            Next
        End With
    End Sub
End Class