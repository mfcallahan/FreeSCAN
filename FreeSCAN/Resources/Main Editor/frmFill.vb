Option Strict Off
Option Explicit On
Friend Class frmFill
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Visible = False
        lblSiteNote.Visible = True
        lblSiteNote.Enabled = True
        lblSiteNote.Activate()
    End Sub

    Private Sub cmdFill_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFill.Click
        If blnDebug = False Then On Error Resume Next
        'Adds a series of channels to the current system
        Dim dblStartFreq, dblEndFreq As Double
        Dim sngStepSize As Single
        Dim intStep As Integer
        Dim intRepeat, intCnt As Single
        Dim Response, intChanNum As Integer
        Dim strGID, strName As String
        Dim dblPrevFreq, dblFreq As Double
        Dim intSanity As Integer
        Dim sngBuff As Single
        strGID = varSite(intCurrentSys, intCurrentGroup, 0, 10)
        'sanity checking
        'check to make sure a conventional system is active
        If varSite(intCurrentSys, intCurrentGroup, 0, 5) <> "1" Then
            Response = MsgBox("Please close out and select a conventional system before proceeding.", MsgBoxStyle.OKCancel + MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'check start frequency is sane
        dblStartFreq = Val(txtStartFreq.Text)
        dblEndFreq = Val(txtEndFreq.Text)
        intRepeat = Val(txtNumFreq.Text)

        sngStepSize = Val(cmbStepSize.Text)
        If dblStartFreq > 1300 Or dblStartFreq < 25 Then
            Response = MsgBox("You have entered a start frequency beyond the scanner's range. Change the start frequency and try again.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'check end freq
        '1000 Is the maximum number of freqs in a conventional system
        If optEnd(1).Checked = True Then
            If intRepeat < 1 Or intRepeat > 1000 Then
                Response = MsgBox("You have entered a repeat value either too small or too big. A conventional system can contain up to 1000 frequencies. Change it and try again.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        ElseIf optEnd(0).Checked = True Then
            If dblEndFreq > 1300 Or dblEndFreq < 25 Then
                Response = MsgBox("You have entered an end frequency beyond the scanner's range. Change the end frequency and try again.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If
        'step size
        If sngStepSize = 0 And optEnd(0).Checked = True Then
            Response = MsgBox("You have specified a step size of 0. Change this to a larger number or change the fill mode to a pre-set number of frequencies.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'FINALLY begin filling
        Select Case optEnd(0).Checked
            Case True 'fill up to a frequency
                'find out how many times it needs to be repeater
                If dblStartFreq <= dblEndFreq Then
                    sngBuff = (dblEndFreq - dblStartFreq) / (sngStepSize / 1000)
                Else
                    sngBuff = (dblStartFreq - dblEndFreq) / (sngStepSize / 1000)
                End If
                intRepeat = sngBuff
                If Int(sngBuff) <> sngBuff Then 'always round up
                    intRepeat = intRepeat + 1
                End If
            Case Else 'fill a certain number of times
                intRepeat = intRepeat - 1
        End Select
        For intCnt = 1 To intRepeat + 1

            intChanNum = InsertChan(strGID, True)
            intSanity += 1
            If intSanity = 2500 Then
                MsgBox("FreeSCAN has created the maximum number of channels.")
                Exit For
            End If
            If intChanNum = -1 Then 'is there enough memory?
                Response = MsgBox("There is insufficient memory remaining to insert any more channels. Delete some and try again.", MsgBoxStyle.Critical)
                intCnt = intRepeat + 1
            Else
                'insert the frequency
                If dblPrevFreq = 0 Then
                    dblPrevFreq = dblStartFreq
                    dblFreq = dblStartFreq
                Else
                    If dblEndFreq < dblStartFreq And optEnd(0).Checked = True Then 'reverse order
                        dblFreq = dblPrevFreq - (sngStepSize / 1000)
                        dblPrevFreq = dblFreq
                    Else
                        dblFreq = dblPrevFreq + (sngStepSize / 1000)
                        dblPrevFreq = dblFreq
                    End If
                End If
                strName = txtName.Text
                If chkNameNum.CheckState = 1 Then
                    strName = strName & " " & intCnt
                End If
                If chkNameFreq.CheckState = 1 Then

                    strName = strName & " " & FormatFreq(MakeItKosherFreqSilent(dblFreq))
                End If

                strName = MakeItKosher(strName)
                ChanInfo(intChanNum, 1) = strName

                ChanInfo(intChanNum, 2) = MakeItKosherFreqSilent(dblFreq)
                ChanInfo(intChanNum, 2) = FormatFreq(ChanInfo(intChanNum, 2))
                ChanInfo(intChanNum, 4) = CStr(0) 'modmode
                ChanInfo(intChanNum, 5) = CStr(0) 'l/o
                ChanInfo(intChanNum, 6) = CStr(0) 'att
                ChanInfo(intChanNum, 7) = CStr(0) 'pri
                ChanInfo(intChanNum, 8) = CStr(0) 'alert
                ChanInfo(intChanNum, 9) = CStr(127) 'ctcss
                ChanInfo(intChanNum, 11) = CStr(0) 'tone lockout
                ChanInfo(intChanNum, 12) = CStr(0) 'audio type=all
                ChanInfo(intChanNum, 13) = CStr(0) 'alert level
            End If
        Next intCnt
        lblSiteNote.LoadConvChanGrid()
        With lblSiteNote.grdConvChan 'make sure freshly created rows are visible
            If .Visible = True Then
                'If .get_RowIsVisible(.Rows - 1) = False Then
                '.Row = .Rows - 1
                'End If
            End If
        End With
        blnChgSaved = False
        lblSiteNote.DispStat(intCnt - 1 & " frequencies created.")
    End Sub
	
	Private Sub frmFill_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'initialize everything
        Dim x, strMode As String
		cmbStepSize.Items.Clear()
		
		x = 1
		
		Do Until x = 9
            strMode = Val(CStr(StepSize(x, 1) / 100))
            x = x + 1
            cmbStepSize.Items.Add((strMode))
        Loop
		cmbStepSize.SelectedIndex = 4
		txtStartFreq.Text = "25"
		txtNumFreq.Text = "10"
	End Sub
	
	'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_WARNING: frmFill event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Form_Terminate_Renamed()
		Call cmdCancel_Click(cmdCancel, New System.EventArgs())
    End Sub

    Private Sub txtNumFreq_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumFreq.GotFocus
        _optEnd_1.Checked = True
    End Sub

    Private Sub txtNumFreq_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumFreq.TextChanged

    End Sub

    Private Sub txtEndFreq_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndFreq.GotFocus
        _optEnd_0.Checked = True
    End Sub
End Class