Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmParseTGID
	Inherits System.Windows.Forms.Form
    'CONVENTIONAL CHANNEL
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        grdField.Rows.Clear()
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Visible = False
        lblSiteNote.Visible = True

    End Sub

    Private Sub cmdEZGrab_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEZGrab.Click
        'CONVENTIONAL CHANNEL
        Dim strDelimit As String
        Dim ChanInfo(1000, 15) As String
        Dim blnEnd As Boolean
        Dim intLW, intIndex, intField, intChan As Integer
        Dim strBuff As String
        Dim intRow As Integer
        Dim intCol, intLastRow As Integer
        Dim strEntry() As String
        '1 frequency/tgid
        '2 tgid name
        '3comment
        '4 'name+comment
        Dim optDelimit(4) As RadioButton

        optDelimit(0) = _optDelimit_0
        optDelimit(1) = _optDelimit_1
        optDelimit(2) = _optDelimit_2
        optDelimit(3) = _optDelimit_3
        optDelimit(4) = _optDelimit_4
        strDelimit = Nothing
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
        Do Until blnEnd = True
            'Take the strbuff variable, and break it up into pieces by line
            intIndex = intIndex + 1
            intLW = InStr(strBuff, Chr(13))
            If intLW = 0 Then
                blnEnd = True
            Else
                'grab the first line, dump it into the array at 0
                ChanInfo(intIndex, 0) = VB.Left(strBuff, intLW)
                strBuff = VB.Right(strBuff, Len(strBuff) - intLW)
            End If
            If intIndex = 999 Then
                MsgBox("FreeSCAN has reached the maximum number of items that can be imported in one step. Further items will be ignored.")
                blnEnd = True
            End If
        Loop
        'the last one is done manually
        ChanInfo(intIndex, 0) = strBuff
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
        'next, break up the line into fields
        For intChan = 1 To intIndex
            strEntry = Split(ChanInfo(intChan, 0), strDelimit)
            strBuff = CStr(UBound(strEntry))
            If CDbl(strBuff) > 7 Then strBuff = CStr(7)
            For intField = 0 To CInt(strBuff)
                ChanInfo(intChan, intField + 1) = MakeItKosherSilent(strEntry(intField), 3)
            Next intField
        Next intChan


        'setup grid
        With grdField
            If chkDelete.CheckState = 1 Then
                .Rows.Clear()
                If intChan <= 0 Then

                ElseIf intChan = 1 Then
                    .RowCount = 1
                ElseIf intChan > 1 Then
                    .RowCount = intChan - 1
                End If


                Dim cellText As String

                For intRow = 1 To intChan - 1
                    For intCol = 1 To 8
                        cellText = ChanInfo(intRow, intCol)
                        If IsNothing(cellText) Then cellText = ""
                        grdField(intCol - 1, intRow - 1).Value = cellText ''write the text to the grid
                        If cellText.Length > 8 Then
                            grdField(intCol - 1, intRow - 1).ToolTipText = cellText 'add a tooltip to the cell if needed
                        End If
                    Next intCol
                Next intRow
            Else 'add on to existing grid
                intLastRow = .RowCount
                If .RowCount = 0 Then
                    .RowCount = intChan - 1
                    intLastRow = 0
                Else
                    .RowCount += intChan - 1
                End If

                strBuff = CStr(0)
                For intRow = intLastRow To (intChan + intLastRow) - 2
                    strBuff = CStr(CDbl(strBuff) + 1)
                    'check to make sure this is not just a blank line
                    intLW = 0
                    For intCol = 1 To 8
                        intLW = CInt(Trim(CStr(Len(ChanInfo(CInt(strBuff), intCol)))))
                        If intLW > 0 Then intCol = 8
                    Next intCol
                    Dim cellText As String
                    If intLW > 2 Then
                        For intCol = 1 To 8
                            cellText = ChanInfo(CInt(strBuff), intCol)
                            grdField(intCol - 1, intRow).Value = cellText ''write the text to the grid
                            If IsNothing(cellText) Then cellText = ""
                            If cellText.Length > 8 Then
                                grdField(intCol - 1, intRow).ToolTipText = cellText 'add a tooltip to the cell if needed
                            End If
                        Next intCol
                    End If
                Next intRow
            End If
        End With
        GuessCombo()
    End Sub

    Sub GuessCombo()
        'This subroutine guesses what what be in each
        'combo box by using analysis
        If chkAutoField.CheckState = 0 Then Exit Sub
        Dim intField As Integer
        Dim intRow As Integer
        Dim strBuff As String
        Dim intGuess(4, 8) As String 'guess type, field number: 1=freq, 2=name,3=mode either analog or digital
        Dim intCnt As Integer
        Dim intBest(4) As String
        Dim intBestGuess(4) As String
        Dim cmbField(7) As ComboBox
        cmbField(0) = _cmbField_0
        cmbField(1) = _cmbField_1
        cmbField(2) = _cmbField_2
        cmbField(3) = _cmbField_3
        cmbField(4) = _cmbField_4
        cmbField(5) = _cmbField_5
        cmbField(6) = _cmbField_6
        cmbField(7) = _cmbField_7
        For intField = 0 To 7

            For intRow = 0 To grdField.RowCount - 1
                strBuff = Trim(UCase(grdField(intField, intRow).Value))
                If strBuff <> "" Then
                    'TGID
                    If IsNumeric(strBuff) = True Then
                        intGuess(1, intField) = intGuess(1, intField) + 1
                        If Val(strBuff) > 1000 Then
                            intGuess(1, intField) = intGuess(1, intField) + 2
                        End If
                    End If
                    'name
                    If Len(strBuff) > 4 Then
                        intGuess(2, intField) += 1
                    End If
                        'is it really long
                    If Len(strBuff) > 12 Then
                        intGuess(2, intField) -= 1

                    End If

                    'subtract point for the name if it contains typical RR function tags

                    If strBuff = "Emergency Ops" Or strBuff = "Fire Dispatch" Or strBuff = "Multi-Dispatch" Or strBuff = "Law Dispatch" _
                        Or strBuff = "Interop" Or strBuff = "Law Tac" Or strBuff = "Public Works" Or strBuff = "Fire-Tac" Then
                        intGuess(2, intField) = intGuess(2, intField) - 2
                    End If



                    'Guess mode (analog or digital\

                        If strBuff = "A" Or strBuff = "D" Or strBuff = "E" Then
                            intGuess(3, intField) += 2
                        ElseIf strBuff = "P25" Or strBuff = "ANALOG" Or strBuff = "DIGITAL" Then
                            intGuess(3, intField) += 3
                        ElseIf strBuff = "ENC" Or strBuff = "ENCRYPTED" Then
                            intGuess(3, intField) += 3
                        End If

                    End If
            Next intRow
        Next intField
        'Now guess which is field by collecting the highest one of each

        Dim intBG As Integer
        Dim FieldAlloc(7) As Integer
        For intCnt = 1 To 3
            intBestGuess(intCnt) = 0
            intBG = 0
            For intField = 0 To 7
                'is this field and this paramteres the highest seen so far?
                If intGuess(intCnt, intField) > intBG Then
                    'does it already have a voting for another paramater, with more points?
                    If FieldAlloc(intField) > intGuess(intCnt, intField) Then
                        'it's already voted more so for another paramater, forget it
                    Else 'ok, assign this data type to this column
                        intBG = intGuess(intCnt, intField) 'note that this column has got the highest score so far
                        intBestGuess(intCnt) = intField 'assign the column to that field
                        FieldAlloc(intField) = intBG 'make a note of it
                    End If
                End If
            Next intField
        Next intCnt

        'Apply best guess to listboxes
        For intField = 0 To 7
            cmbField(intField).SelectedIndex = 0
        Next intField
        For intField = 1 To 3
            strBuff = intBestGuess(intField)
            If CDbl(strBuff) >= 0 Then
                cmbField(strBuff).SelectedIndex = intField
            End If
        Next intField
    End Sub
    

    Private Sub cmdImportToSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImportToSys.Click
        Dim intField, intField1 As Integer
        Dim blnFreq, blnSame, blnDone As Boolean
        Dim intRow, Response, intCol As Short
        Dim intFreqCol As Short
        Dim intModCol, intNameCol, intToneCol As Integer
        Dim strBuff As String
        Dim intToneIndex, intChan As Integer
        Dim intNameCommCOl, intCommentCol, intModeCol, intSpace As Integer
        Dim intFreeChan As Integer
        If blnDebug = False Then On Error Resume Next
        Dim cmbField(8) As ComboBox

        cmbField(0) = _cmbField_0
        cmbField(1) = _cmbField_1
        cmbField(2) = _cmbField_2
        cmbField(3) = _cmbField_3
        cmbField(4) = _cmbField_4
        cmbField(5) = _cmbField_5
        cmbField(6) = _cmbField_6
        cmbField(7) = _cmbField_7

        'import data from the grid into freescan
        If grdField.RowCount = 0 Then
            MsgBox("Please choose Copy From Clipboard first to import the channels.")
            Exit Sub
        End If
        'First confirm that no two listboxes have the same field other than ignore
        For intField = 0 To 7
            For intField1 = 0 To 7
                If cmbField(intField).SelectedIndex = cmbField(intField1).SelectedIndex And cmbField(intField).SelectedIndex <> 0 And cmbField(intField).SelectedIndex <> -1 And intField <> intField1 Then
                    blnSame = True
                End If
            Next intField1
            If cmbField(intField).SelectedIndex = 1 Then blnFreq = True
        Next intField
        If blnSame = True Then
            MsgBox("Sorry, but two field names have the same designation. Each field name must be either set to a unique setting (such as TGID) or set to 'Ignore'")
            Exit Sub
        End If
        If blnFreq = False Then
            Response = MsgBox("You haven't designated any fields as containing a TGID. Are you sure you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "No frequency information")
            Select Case Response
                Case 7 'no?
                    Exit Sub
                Case 6
                    'yes, continue anyways
            End Select
        End If
        intFreqCol = -1
        intModeCol = -1
        intNameCol = -1
        intCommentCol = -1
        intNameCommCOl = -1
        For intField = 0 To 7
            If cmbField(intField).SelectedIndex = 1 Then intFreqCol = intField
            If cmbField(intField).SelectedIndex = 2 Then intNameCol = intField
            If cmbField(intField).SelectedIndex = 3 Then intModeCol = intField
            If cmbField(intField).SelectedIndex = 4 Then intCommentCol = intField
            If cmbField(intField).SelectedIndex = 5 Then intNameCommCOl = intField
        Next intField
        'finally begin importing stuff

        intFreeChan = 0
        For intChan = 1 To MaxChan
            If ChanInfo(intChan, 10) = "" Then intFreeChan += 1
        Next intChan

        If intFreeChan < grdField.RowCount And MaxChan = 32766 Then
            strBuff = CStr(MsgBox("FreeSCAN has insufficient channel memory to hold the requested channels. Delete some and try again. No channels have been imported.", MsgBoxStyle.Exclamation))
            Exit Sub
        End If
        Do Until blnDone = True
            'insert chan

            intChan = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), False)
            If intChan = -1 Then
                MsgBox("Sorry, but there is insuffcient memory to import any more channels. Delete some and try again.")
                Response = MsgBox(intRow & " channels have been imported.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information)
                lblSiteNote.LoadTrunkChanGrid()
                Exit Sub
            End If
            'frequency
            If intFreqCol <> -1 Then
                strBuff = grdField(intFreqCol, intRow).Value

                strBuff = MakeItKosherSilent(strBuff, 0) '0=standard chop
                ChanInfo(intChan, 2) = strBuff
            End If
            'Mode (Analog, Digital or encrypted)
            If intModeCol <> -1 Then
                strBuff = grdField(intModeCol, intRow).Value
                strBuff = UCase(strBuff)
                If strBuff = "A" Or strBuff = "ANALOG" Or strBuff = "FM" Then
                    ChanInfo(intChan, 6) = "1" 'analog
                ElseIf strBuff = "D" Or strBuff = "DIGITAL" Or strBuff = "P25" Then
                    ChanInfo(intChan, 6) = "2" 'digital
                ElseIf strBuff = "E" Or strBuff = "ENCRYPTED" Or strBuff = "ENC" Then
                    ChanInfo(intChan, 6) = "2"
                    ChanInfo(intChan, 14) = "Encrypted"
                Else
                    ChanInfo(intChan, 6) = "0" 'Any audio type
                End If
            End If


            'NAME

            If intNameCol <> -1 Then
                If chkKompress.CheckState = 0 Then
                    ChanInfo(intChan, 1) = MakeItKosherSilent(grdField(intNameCol, intRow).Value, Val(CStr(chkNoChop.CheckState)))
                Else
                    ChanInfo(intChan, 1) = Kompressor(GridData(intRow, intNameCol))
                End If
            Else
                ChanInfo(intChan, 1) = "TGID " & ChanInfo(intChan, 2)
            End If

            If ChanInfo(intChan, 4) = "" Then ChanInfo(intChan, 4) = CStr(0)
            If intCommentCol <> -1 Then 'import it into the comment field
                ChanInfo(intChan, 14) = MakeItKosherSilent(GridData(intRow, intCommentCol), 3)
            End If

            'NAME+COmment
            If intNameCommCOl <> -1 Then
                If chkKompress.CheckState = 0 Then
                    ChanInfo(intChan, 1) = MakeItKosherSilent(GridData(intRow, intNameCommCOl), Val(CStr(chkNoChop.CheckState)))
                Else
                    ChanInfo(intChan, 1) = Kompressor(GridData(intRow, intNameCommCOl))
                End If
                ChanInfo(intChan, 14) = MakeItKosherSilent(GridData(intRow, intNameCommCOl), 3)
            End If


            intRow += 1
            If intRow = grdField.RowCount Then blnDone = True
        Loop
        Response = MsgBox(intRow & " channels have been imported.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information)
        lblSiteNote.LoadTrunkChanGrid()
    End Sub
	
    Function GridData(ByVal intRow As Integer, ByVal intCol As Integer) As String
        GridData = grdField(intCol, intRow).Value
    End Function
	
	Private Sub frmParseTGID_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'initialize combo boxes
        Dim cmbField(7) As ComboBox
        Dim cnt As Integer
        cmbField(0) = _cmbField_0
        cmbField(1) = _cmbField_1
        cmbField(2) = _cmbField_2
        cmbField(3) = _cmbField_3
        cmbField(4) = _cmbField_4
        cmbField(5) = _cmbField_5
        cmbField(6) = _cmbField_6
        cmbField(7) = _cmbField_7
        '1 frequency/tgid
        '2 tgid name
        '3comment
        '4 'name+comment
        For cnt = 0 To 7
            cmbField(cnt).Items.Add("Ignore")
            cmbField(cnt).Items.Add("TGID")
            cmbField(cnt).Items.Add("Display")
            cmbField(cnt).Items.Add("Mode")
            cmbField(cnt).Items.Add("Comment")
            cmbField(cnt).Items.Add("Name+Comment")

        Next
	End Sub
	
	'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_WARNING: frmParseTGID event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Form_Terminate_Renamed()
		cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub
	
	Private Sub frmParseTGID_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub

    Private Sub DupeGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdField.CellContentClick

    End Sub
End Class