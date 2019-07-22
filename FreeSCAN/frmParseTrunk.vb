Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmParseTrunk
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        grdField.Rows.Clear()
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Visible = False
        lblSiteNote.Visible = True
        lblSiteNote.BringToFront()

    End Sub
    Function GridData(ByVal intRow As Integer, ByVal intCol As Integer) As String
        GridData = grdField(intCol, intRow).Value
    End Function
    Sub SetGrid(ByVal intRow As Integer, ByVal intCol As Integer, ByVal sData As String)
        grdField(intCol, intRow).Value = sData
    End Sub
    Private Sub cmdEZGrab_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEZGrab.Click
        Dim strDelimit As String
        Dim ChanInfo(1000, 2) As String
        Dim intChan As Integer
        Dim strBuff1, strBuff, strbuff2 As String
        Dim intPos, intPos1 As Integer
        Dim intRow As Integer
        Dim intPos2 As Integer
        Dim strEntry() As String
        strDelimit = Nothing
        Dim optDelimit(4) As RadioButton

        optDelimit(0) = _optDelimit_0
        optDelimit(1) = _optDelimit_1
        optDelimit(2) = _optDelimit_2
        optDelimit(3) = _optDelimit_3
        optDelimit(4) = _optDelimit_4
        If My.Computer.Clipboard.ContainsText() = False Then
            MsgBox("The clipboard does not have any text in it.")
            Exit Sub
        End If
        strBuff = My.Computer.Clipboard.GetText
        If Len(strBuff) < 5 Then
            MsgBox("The clipboard does not have anything useful in it.")
            Exit Sub
        End If
        If Len(strBuff) > 10 And InStr(strBuff, Chr(9)) = 0 And optDelimit(0).Checked Then 'internet explorer mode since there are no tabs present
            optDelimit(3).Checked = True
            txtDelimit.Text = "  "
        End If

        'setup for custom delimiter
        If optDelimit(0).Checked = True Then

            strDelimit = Chr(9) 'tab
        ElseIf optDelimit(1).Checked = True Then

            strDelimit = ","
        ElseIf optDelimit(2).Checked = True Then

            strDelimit = " "
        ElseIf optDelimit(3).Checked = True Then
            If Len(txtDelimit.Text) = 0 Then
                MsgBox("You have selected a custom delimiter, but have not specified one. Please try again.")
                Exit Sub
            Else

                strDelimit = txtDelimit.Text
            End If
        ElseIf optDelimit(4).Checked = True Then

            strDelimit = Chr(13)
        End If

        strEntry = Split(strBuff, strDelimit, -1)
        Do While intPos <= UBound(strEntry)
            If Trim(strEntry(intPos)) <> "" Then
                intChan = intChan + 1
                ChanInfo(intChan, 0) = Trim(strEntry(intPos))

            End If
            intPos = intPos + 1
        Loop
        'Now go through each one and remove garbage
        'it must be a number, or a space, or its getting nuked
        For intPos = 1 To intChan
            strBuff = ""
            intPos2 = 0
            For intPos1 = 1 To Len(ChanInfo(intPos, 0))
                strBuff1 = Mid(ChanInfo(intPos, 0), intPos1, 1)
                If strBuff1 = " " Then 'if theres a space, then delete the reference channel number
                    intPos2 = intPos1
                    intPos1 = Len(ChanInfo(intPos, 0))
                End If
            Next intPos1
            'remove control channel number, if it was detected above
            If intPos2 > 0 Then
                strBuff = VB.Right(ChanInfo(intPos, 0), Len(ChanInfo(intPos, 0)) - intPos2)
                ChanInfo(intPos, 0) = strBuff
            End If
            strbuff2 = ""
            'next, go through and remove anything that doesn't belong in a number
            strBuff = ChanInfo(intPos, 0)
            For intPos1 = 1 To Len(strBuff)
                strBuff1 = Mid(strBuff, intPos1, 1)

                If IsNumeric(strBuff1) = True Then
                    strbuff2 = strbuff2 & strBuff1
                ElseIf strBuff1 = "." Then
                    strbuff2 = strbuff2 & "."
                End If
            Next intPos1
            ChanInfo(intPos, 1) = strbuff2
        Next intPos



        'setup grid
        With grdField
            If chkDelete.CheckState = 1 Then
                .Rows.Clear()
                .Rowcount = 0
                intPos = 0
                For intRow = 1 To intChan

                    strBuff = ChanInfo(intRow, 1)
                    If Val(strBuff) > 32 Then 'val>32 to avoid including any loose LCN numbers in the table
                        .Rowcount = .Rowcount + 1
                        SetGrid(intPos, 1, strBuff)
                        SetGrid(intPos, 0, .RowCount)
                        intPos = intPos + 1
                    End If
                Next intRow
            Else 'add on to existing grid
                intPos = 0
                For intRow = 1 To intChan
                    strBuff = ChanInfo(intRow, 1)
                    If Val(strBuff) > 32 Then
                        .Rowcount = .Rowcount + 1
                        intPos = .RowCount - 1
                        SetGrid(intPos, 1, strBuff)
                        SetGrid(intPos, 0, .RowCount)
                    End If
                Next intRow
            End If
        End With

    End Sub



    Private Sub cmdImportToSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImportToSys.Click
        Dim intRow As Integer
        Dim strBuff As String
        Dim intChan As Integer
        Dim intLCN As Integer
        'import data from the grid into freescan
        If grdField.Rowcount = 0 Then
            MsgBox("Please choose Copy From Clipboard first to import the trunking frequencies.")
            Exit Sub
        End If
        intLCN = 0
        With grdField
            For intRow = 0 To .Rowcount - 1
                intChan = InsertTrunkFreq(varSite(intCurrentSys, intCurrentGroup, 0, 10))
                If intChan = -1 Then
                    MsgBox("Sorry, but there is insufficient memory available to import any additional channels. " & intRow + 1 & " channels imported.")
                    Exit Sub
                Else
                    intLCN = intLCN + 1
                    strTrunkFreq(intChan, 0) = MakeItKosherFreqSilent(GridData(intRow, 1))
                    strTrunkFreq(intChan, 1) = CStr(intLCN)
                    strTrunkFreq(intChan, 3) = "0" 'lockout status
                End If
            Next intRow
        End With
        strBuff = CStr(MsgBox(grdField.Rowcount & " trunk frequencies have been imported successfully.", MsgBoxStyle.Information))
        lblSiteNote.LoadData("TrunkFreq")
    End Sub
	
	Private Sub frmParseTrunk_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'initialize combo boxes
        grdField.Rows.Clear()
	End Sub
	
	Private Sub frmParseTrunk_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub
End Class