Public Class FreqJump

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub cmdJump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdJump.Click
        If Not blnDebug Then On Error Resume Next
        Dim dblFreq As Double
        Dim strBuff As String
        Dim CodeSearch As String
        Dim sStepSize As String
        strBuff = txtFreq.Text
        dblFreq = Val(strBuff)
        sStepSize = StepSize(cmbStep.SelectedIndex, 1)
        If RadioButton1.Checked Then
            CodeSearch = "0"
        ElseIf RadioButton2.Checked Then
            CodeSearch = "1"
        Else
            CodeSearch = "2"
        End If
        If strBuff <> "" And IsNumeric(dblFreq) = True Then

            dblFreq = Val(MakeItKosherFreqSilent(strBuff))         
            If frmCtlSetup.IsXTScanner(ScannerModel) = False Then
                strUserCMD = "QSH," & (dblFreq * 10000) & "," & sStepSize & "," & CStr(cmbModMode.SelectedItem) & ","
                strUserCMD &= chkAtt.CheckState & "," & CStr(cmbDelayTime.SelectedItem) & "," & chkDataSkip.CheckState & ","
                strUserCMD &= CodeSearch & ",,"
            Else
                strUserCMD = "QSH," & (dblFreq * 10000) & "," & sStepSize & "," & CStr(cmbModMode.SelectedItem) & "," & chkAtt.CheckState
                strUserCMD &= "," & CStr(cmbDelayTime.SelectedItem) & ",," & CodeSearch & ",,,,,,"
            End If
        Else
            MsgBox("You have entered an invalid frequency. Please try again.", MsgBoxStyle.Exclamation)
            txtFreq.Show()
        End If
    End Sub

    Private Sub FreqJump_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim x As Integer, EndofList As Boolean
        If cmbModMode.Items.Count = 0 Then
            'initialize form
            With cmbDelayTime
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
            End With
            EndofList = False : x = 0
            Do Until EndofList = True
                cmbModMode.Items.Add((ModMode(x)))
                x = x + 1
                If Len(ModMode(x)) = 0 Then EndofList = True
            Loop
            EndofList = False : x = 0
            For x = 0 To UBound(StepSize)
                cmbStep.Items.Add((StepSize(x, 0)))

                If Len(StepSize(x, 0)) = 0 Then EndofList = True
            Next x
            RadioButton1.Checked = True
            cmbStep.SelectedIndex = 0
            cmbModMode.SelectedIndex = 0
            cmbDelayTime.SelectedIndex = 5
        End If
    End Sub

    Private Sub txtFreq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFreq.KeyPress
        If e.KeyChar = Chr(13) Then
            Call cmdJump_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtFreq_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFreq.TextChanged

    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Visible = False
    End Sub
End Class