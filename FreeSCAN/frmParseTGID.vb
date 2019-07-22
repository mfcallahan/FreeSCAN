Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmParse
	Inherits System.Windows.Forms.Form
    Dim strCTCSS(255) As String
    'FORM FOR CONVENTIONAL CHANNELS
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        grdField.Rows.Clear()
	End Sub
    Function GridData(ByVal intRow As Integer, ByVal intCol As Integer) As String
        GridData = grdField(intCol, intRow).Value
    End Function
	Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Visible = False
        lblSiteNote.Visible = True

    End Sub

    Private Sub cmdEZGrab_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEZGrab.Click
        Dim strDelimit As String
        Dim ChanInfo(1000, 15) As String
        Dim blnEnd As Boolean
        Dim intLW, intIndex, intField, intChan As Integer
        Dim strBuff1, strBuff As String
        Dim intRow As Integer
        Dim intCol, intLastRow As Integer
        Dim strEntry(), PreFilter() As String
        Dim optDelimit(4) As RadioButton
        Dim FullAuto As Boolean = False
        If Not blnDebug Then On Error Resume Next
        optDelimit(0) = _optDelimit_0
        optDelimit(1) = _optDelimit_1
        optDelimit(2) = _optDelimit_2
        optDelimit(3) = _optDelimit_3
        optDelimit(4) = _optDelimit_4


        '1 frequency/tgid
        '2 tgid name
        '3 tone
        '4 modmode
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
            ' optDelimit(3).Checked = True
            txtDelimit.Text = "  "
            FullAuto = True
            strDelimit = Chr(32)
        End If
        Do Until blnEnd = True
            'Take the strbuff variable, and break it up into pieces by line
            intIndex = intIndex + 1
            intLW = instr(strBuff, Chr(13))
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

        ChanInfo(intIndex, 0) = strBuff
        'setup for custom delimiter
        If optDelimit(0).Checked And Not FullAuto Then

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
            'first, see if space is the delimiter
            'if so kill the spaces in between words but not numbers
            strBuff1 = strDelimit
            If strDelimit = Chr(32) And FullAuto Then
                PreFilter = Split(ChanInfo(intChan, 0), strDelimit)
                If IsNumeric(PreFilter(0)) Then 'is the first one a number
                    'if it is, seperate the number, and dump everything else into one field

                    ChanInfo(intChan, 0) = Strings.Left(PreFilter(0), Len(PreFilter(0)) - 1) & Replace(ChanInfo(intChan, 0), " ", "_", Len(PreFilter(0)), 1)
                    strDelimit = "_"
                End If
            End If


            strEntry = Split(ChanInfo(intChan, 0), strDelimit)
            strBuff = CStr(UBound(strEntry))
            If CDbl(strBuff) > 8 Then strBuff = CStr(8)

            For intField = 0 To CInt(strBuff)

                ChanInfo(intChan, intField + 1) = MakeItKosherSilent(strEntry(intField), 3)
            Next intField
            strDelimit = strBuff1
        Next intChan
        'setup grid
        With grdField
            If chkDelete.CheckState = 1 Then
                .Rows.Clear()
                If intChan <= 0 Then
                    .RowCount = 0
                ElseIf intChan = 1 Then
                    .RowCount = 1
                ElseIf intChan > 1 Then
                    .RowCount = intChan - 1
                End If
                For intRow = 1 To intChan - 1
                    For intCol = 1 To 9

                        strBuff = ChanInfo(intRow, intCol)
                        If strBuff = "&" Then strBuff = ""
                        'uniden frequency import
                        If Val(strBuff) >= 25000 Then
                            strBuff = CStr(Val(strBuff) / 10000)
                        End If
                        'uniden tone import
                        If Len(strBuff) = 5 Then
                            If VB.Left(strBuff, 1) = "C" Then
                                strBuff1 = VB.Right(strBuff, 4)
                                If IsNumeric(strBuff1) = True Then
                                    strBuff = CStr(Val(strBuff1) / 10)
                                End If
                            End If
                        End If

                        SetGrid(intRow - 1, intCol - 1, strBuff)
                    Next intCol
                Next intRow
            Else 'add on to existing grid
                intLastRow = .RowCount
                If .RowCount = 0 Then
                    .RowCount = intChan - 1
                    intLastRow = 0
                Else
                    .RowCount = .RowCount + intChan - 1
                End If
                strBuff = CStr(0)
                Dim cellText As String
                For intRow = intLastRow To (intChan + intLastRow) - 2
                    strBuff = CStr(CDbl(strBuff) + 1)
                    For intCol = 1 To 8
                        cellText = ChanInfo(CInt(strBuff), intCol)
                        grdField(intCol - 1, intRow).Value = cellText

                        If Not IsNothing(cellText) Then
                            If cellText.Length > 8 Then
                                grdField(intCol - 1, intRow).ToolTipText = ChanInfo(CInt(strBuff), intCol)
                            End If 'if the length > 8 
                        End If 'if not is nothing
                    Next intCol
                Next intRow

            End If
            'is the last row blank? then nuke it
            If .RowCount > 0 Then
                strBuff = "0"
                For intCol = 0 To 8
                    If GridData(.RowCount - 1, intCol) <> Nothing Then
                        strBuff = "1"
                        Exit For
                    End If
                Next
                If strBuff = "0" Then 'nothing in last line? then get rid of it
                    .RowCount = .RowCount - 1
                End If
            End If

        End With

        GuessCombo()
    End Sub
    Sub SetGrid(ByVal intRow As Integer, ByVal intCol As Integer, ByVal sData As String)
        grdField(intCol, intRow).Value = sData
        If Strings.Len(sData) > 8 Then
            grdField(intCol, intRow).ToolTipText = sData
        End If
    End Sub
    Sub GuessCombo()
        'This subroutine guesses what what be in each
        'combo box by using analysis

        'CTCSS Variable
        If chkAutoField.CheckState = 0 Then Exit Sub
        Dim intField As Integer
        Dim intRow As Integer
        Dim strBuff As String
        Dim intGuess(4, 8) As String 'guess type, field number, 1=freq, 2=name,3=tone,4=mod
        Dim intCnt As Integer
        Dim intBest(4) As String
        Dim intBestGuess(4) As String
        For intField = 0 To 8
            For intRow = 0 To grdField.RowCount - 1


                strBuff = Trim(UCase(griddata(intRow, intField)))
                If strBuff <> "" Then
                    'frequencies

                    'intGuess(1, intField) = intGuess(1, intField) + 1
                    If InStr(strBuff, ".") > 0 Then
                        intGuess(1, intField) = intGuess(1, intField) + 1
                    End If
                    If Len(strBuff) = 7 And Mid(strBuff, 4, 1) = "." Then
                        intGuess(1, intField) = intGuess(1, intField) + 3
                    End If
                    If Len(strBuff) = 8 And Mid(strBuff, 4, 1) = "." Then
                        intGuess(1, intField) = intGuess(1, intField) + 3
                    End If
                    If Len(strBuff) = 9 And Mid(strBuff, 4, 1) = "." Then
                        intGuess(1, intField) = intGuess(1, intField) + 3
                    End If
                    If InStr(strBuff, "-") > 0 Then
                        intGuess(1, intField) = intGuess(1, intField) - 1
                    End If
                    If Val(strBuff) > 300 And Val(strBuff) < 1400 Then
                        intGuess(1, intField) += 1
                    End If
                    If Val(strBuff) >= 2000 Then
                        intGuess(1, intField) -= 1
                    End If

                    'mod mode
                    If Len(strBuff) < 4 And InStr(strBuff, "AM") > 0 Then
                        intGuess(4, intField) = intGuess(4, intField) + 1
                    End If
                    If Len(strBuff) < 4 And InStr(strBuff, "FM") > 0 Then
                        intGuess(4, intField) = intGuess(4, intField) + 1
                    End If
                    If Len(strBuff) < 4 And InStr(strBuff, "P25") > 0 Then
                        intGuess(4, intField) = intGuess(4, intField) + 1
                    End If
                    'name
                    If Len(strBuff) > 4 Then
                        If CheckForNum(strBuff) = False Then
                            intGuess(2, intField) = intGuess(2, intField) + 1
                        End If
                    End If

                    'subtract point for the name if it contains typical RR function tags

                    If strBuff = "Emergency Ops" Or strBuff = "Fire Dispatch" Or strBuff = "Multi-Dispatch" Or strBuff = "Law Dispatch" _
                        Or strBuff = "Interop" Or strBuff = "Law Tac" Or strBuff = "Public Works" Or strBuff = "Fire-Tac" Then
                        intGuess(2, intField) = intGuess(2, intField) - 2
                    End If

                    'is it really long
                    If Len(strBuff) >= 9 And Len(strBuff) <= 16 Then
                        intGuess(2, intField) = intGuess(2, intField) + 1
                    End If
                    'tone
                    'Does it contain any of the tones?
                    For intCnt = 67 To 230
                        If strCTCSS(intCnt) <> "" And Len(strBuff) > 3 Then
                            If InStr(strBuff, strCTCSS(intCnt)) > 0 Then
                                intGuess(3, intField) = intGuess(3, intField) + 1
                                intCnt = 230
                            End If
                            If Val(strBuff) = Val(strCTCSS(intCnt)) And Val(strBuff) > 0 Then
                                intGuess(3, intField) = intGuess(3, intField) + 1
                            End If
                        End If
                    Next intCnt

                    'Does it contain DCS or PL
                    If InStr(strBuff, "DCS") > 0 Then
                        intGuess(3, intField) = intGuess(3, intField) + 5
                    ElseIf InStr(strBuff, " PL") > 0 Then
                        intGuess(3, intField) = intGuess(3, intField) + 5
                    ElseIf InStr(strBuff, "HZ") > 0 And InStr(strBuff, "MHZ") = 0 Then
                        intGuess(3, intField) = intGuess(3, intField) + 3
                    ElseIf InStr(strBuff, "CSQ") > 0 Then
                        intGuess(3, intField) = intGuess(3, intField) + 3
                    ElseIf InStr(strBuff, "NAC") > 0 Then
                        intGuess(3, intField) += 3
                    ElseIf Len(strBuff) > 8 Then 'Too long?
                        intGuess(3, intField) -= 1
                    End If

                End If 'strbuff <> ""
            Next intRow
        Next intField
        'Now guess which is field by collecting the highest one of each

        Dim intBG As Integer
        Dim FieldAlloc(8) As Integer
        For intCnt = 1 To 4

            intBestGuess(intCnt) = -1
            intBG = 0
            For intField = 0 To 8


                If intGuess(intCnt, intField) > intBG Then 'this field holds the highest param
                    'does it already have a voting for another paramater, with more points?


                    If FieldAlloc(intField) > intGuess(intCnt, intField) Then
                        'it's already voted more so for another paramater, forget it
                    Else


                        intBG = intGuess(intCnt, intField)


                        intBestGuess(intCnt) = intField

                        FieldAlloc(intField) = intBG
                    End If
                End If
            Next intField
        Next intCnt
        'Apply best guess to listboxes
        For intField = 0 To 8
            cmbField(intField).SelectedIndex = 0
        Next intField
        For intField = 1 To 4


            strBuff = intBestGuess(intField)
            If CDbl(strBuff) >= 0 Then

                cmbField(strBuff).SelectedIndex = intField
            End If
        Next intField
    End Sub
   
    Private Sub cmdImportToSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImportToSys.Click
        Dim intField, intField1 As Integer
        Dim blnSame, blnDone As Boolean
        Dim intRow, blnFreq, Response As Integer
        Dim intModCol, intFreqCol, intNameCol, intToneCol As Integer
        Dim strBuff As String = Nothing
        Dim intToneIndex, intChan As Integer
        Dim intCommentCol, intNameCommCol, intNACDecCol, intNACHexCol As Integer
        Dim cmbField(8) As ComboBox

        cmbField(0) = _cmbField_0
        cmbField(1) = _cmbField_1
        cmbField(2) = _cmbField_2
        cmbField(3) = _cmbField_3
        cmbField(4) = _cmbField_4
        cmbField(5) = _cmbField_5
        cmbField(6) = _cmbField_6
        cmbField(7) = _cmbField_7
        cmbField(8) = _cmbField_8
        'import data from the grid into freescan
        If grdField.Rowcount = 0 Then
            MsgBox("Please choose Copy From Clipboard first to import the channels.")
            Exit Sub
        End If
        'First confirm that no two listboxes have the same field other than ignore
        For intField = 0 To 8
            For intField1 = 0 To 8
                If cmbField(intField).SelectedIndex = cmbField(intField1).SelectedIndex And cmbField(intField).SelectedIndex <> 0 And intField <> intField1 Then
                    blnSame = True
                End If
            Next intField1

            If cmbField(intField).SelectedIndex = 1 Then blnFreq = True
        Next intField
        If blnSame = True Then
            MsgBox("Sorry, but two field names have the same designation. Each field name must be either set to a unique setting (such as frequency) or set to 'Ignore'")
            Exit Sub
        End If

        If blnFreq = False Then

            Response = MsgBox("You haven't designated any fields as containing a frequency. Are you sure you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "No frequency information")
            Select Case Response
                Case 7 'no?
                    Exit Sub
                Case 6
                    'yes, continue anyways
            End Select
        End If
        intFreqCol = -1
        intNameCol = -1
        intToneCol = -1
        intModCol = -1
        intCommentCol = -1
        intNameCommCol = -1
        intNACHexCol = -1
        intNACDecCol = -1
        For intField = 0 To 8
            If cmbField(intField).SelectedIndex = 1 Then intFreqCol = intField
            If cmbField(intField).SelectedIndex = 2 Then intNameCol = intField
            If cmbField(intField).SelectedIndex = 3 Then intToneCol = intField
            If cmbField(intField).SelectedIndex = 4 Then intModCol = intField
            If cmbField(intField).SelectedIndex = 5 Then intCommentCol = intField 'comment
            If cmbField(intField).SelectedIndex = 6 Then intNameCommCOl = intField 'name + comment4
            If cmbField(intField).SelectedIndex = 7 Then intNACDecCol = intField
            If cmbField(intField).SelectedIndex = 8 Then intNACHexCol = intField
        Next intField
        'finally begin importing stuff
        Do Until blnDone = True
            'insert chan

            intChan = InsertChan(varSite(intCurrentSys, intCurrentGroup, 0, 10), True)
            If intChan = -1 Then
                MsgBox("Sorry, but there is insuffcient memory to import any more channels.")
                Exit Sub
            End If
            'frequency

            If intFreqCol <> -1 Then
                strBuff = GridData(intRow, intFreqCol)
                strBuff = MakeItKosherFreqSilent(strBuff)
                ChanInfo(intChan, 2) = strBuff
            End If
            'NAME

            If intNameCol <> -1 Then
                If chkKompress.CheckState = 0 Then
                    ChanInfo(intChan, 1) = MakeItKosherSilent(griddata(intRow, intNameCol), Val(CStr(chkNoChop.CheckState)))
                Else
                    ChanInfo(intChan, 1) = Kompressor(griddata(intRow, intNameCol))
                End If
            Else
                ChanInfo(intChan, 1) = ""
            End If
            'CTCSS
            If intToneCol <> -1 Then
                'find the right tone for this
                strBuff = UCase(Trim(griddata(intRow, intToneCol)))
                For intToneIndex = 1 To 233
                    If instr(strBuff, strCTCSS(intToneIndex)) > 0 And CTCSS(intToneIndex) <> "" Then
                        ChanInfo(intChan, 9) = CStr(intToneIndex)
                        ChanInfo(intChan, 12) = CStr(1) 'set audio type to analog so squelch would work
                        Exit For
                    End If
                Next intToneIndex
                If strBuff = "CSQ" Then 'carrier squelch operation
                    ChanInfo(intChan, 9) = CStr(0) 'set tone to none
                    ChanInfo(intChan, 12) = CStr(0) 'audio type to all
                    ChanInfo(intChan, 4) = CStr(0) 'modulation=auto
                End If
                If InStr(strBuff, "NAC") <> 0 Then
                    strBuff = Replace(strBuff, "-", "")
                    If Strings.Left(strBuff, 3) = "NAC" Then
                        strBuff = OldMid(strBuff, 4, 4)
                    ElseIf Strings.Right(strBuff, 3) = "NAC" Then
                        strBuff = Strings.Left(strBuff, InStr(strBuff, "NAC"))

                    End If
                    strBuff = MakeItKosherNAC(strBuff)
                    ChanInfo(intChan, 12) = "2"
                    ChanInfo(intChan, 9) = "0"
                    ChanInfo(intChan, 15) = strBuff
                    ChanInfo(intChan, 12) = CStr(2) 'set to digital if you set it to NAC
                End If
                If strBuff = "P25" Or strBuff = "DIGITAL" Then
                    ChanInfo(intChan, 4) = CStr(0) 'set modulation to auto
                    ChanInfo(intChan, 9) = CStr(0) 'no tone
                    ChanInfo(intChan, 12) = CStr(2) 'set audio type to digital
                End If
            End If
            If ChanInfo(intChan, 9) = "" Then ChanInfo(intChan, 9) = "0" : ChanInfo(intChan, 12) = CStr(0) 'if nothing found set tone to NONE
            'MOD MODE

            If intModCol <> -1 Then
                strBuff = UCase(Trim(griddata(intRow, intModCol)))
                For intToneIndex = 5 To 0 Step -1
                    If instr(strBuff, ModMode(intToneIndex)) > 0 Then
                        ChanInfo(intChan, 4) = CStr(intToneIndex)
                        intToneIndex = 0
                    End If
                Next intToneIndex
                'check for digital modulation
                If strBuff = "P25" Or strBuff = "DIGITAL" Then
                    ChanInfo(intChan, 4) = CStr(0) 'set modulation to auto
                    ChanInfo(intChan, 9) = CStr(0) 'no tone
                    ChanInfo(intChan, 12) = CStr(2) 'set audio type to digital
                End If
                If strBuff = "FMN" Or strBuff = "NFM" Then
                    ChanInfo(intChan, 4) = "2" 'set modulation to NFM"
                    ChanInfo(intChan, 12) = CStr(1) 'set audio type to analog
                End If
            End If
            'COMMENT
            If ChanInfo(intChan, 4) = "" Then ChanInfo(intChan, 4) = CStr(0)
            If intCommentCol <> -1 Then 'import it into the comment field
                ChanInfo(intChan, 14) = MakeItKosherSilent(griddata(intRow, intCommentCol), 3)
            End If

            'NAME+COmment
            If intNameCommCOl <> -1 Then
                If chkKompress.CheckState = 0 Then
                    ChanInfo(intChan, 1) = MakeItKosherSilent(griddata(intRow, intNameCommCOl), Val(CStr(chkNoChop.CheckState)))
                Else
                    ChanInfo(intChan, 1) = Kompressor(griddata(intRow, intNameCommCOl))
                End If
                ChanInfo(intChan, 14) = MakeItKosherSilent(griddata(intRow, intNameCommCOl), 3)
            End If

            'NAC DEC
            If intNACDecCol <> -1 Then 'import it into the comment field
                strBuff = griddata(intRow, intNACDecCol)
                strBuff = UCase(Trim(strBuff))
                strBuff = MakeItKosherSilent((strBuff), 0)
                If strBuff <> "" Then
                    ChanInfo(intChan, 12) = CStr(2)
                End If
                If IsNumeric(strBuff) = True Then
                    strBuff = MakeItKosherNAC(Hex(strBuff))
                Else
                    strBuff = "SRCH"
                End If
                ChanInfo(intChan, 15) = strBuff

            End If
            'NAC HEX
            If intNACHexCol <> -1 Then 'import it into the comment field
                strBuff = griddata(intRow, intNACHexCol)
                strBuff = UCase(Trim(strBuff))
                If strBuff <> "" Then
                    ChanInfo(intChan, 12) = CStr(2)
                End If
                If HexToDec(strBuff, True) > 0 Then
                    strBuff = MakeItKosherNAC(strBuff)
                    ChanInfo(intChan, 15) = strBuff
                Else
                    ChanInfo(intChan, 15) = "SRCH"
                End If
            End If
            intRow += 1
            If intRow = grdField.Rowcount Then blnDone = True
        Loop


        Response = MsgBox(intRow & " channels have been imported.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information)
        lblSiteNote.LoadConvChanGrid()
    End Sub


    Private Sub frmParse_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'grdField.Clear()
        'grdField.Rowcount = 0
    End Sub
	
	Private Sub frmParse_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'initialize combo boxes
		'CTCSS Variable
		
		strCTCSS(64) = "67.0"
		strCTCSS(65) = "69.3"
		strCTCSS(66) = "71.9"
		strCTCSS(67) = "74.4"
		strCTCSS(68) = "77.0"
		strCTCSS(69) = "79.7"
		strCTCSS(70) = "82.5"
		strCTCSS(71) = "85.4"
		strCTCSS(72) = "88.5"
		strCTCSS(73) = "91.5"
        strCTCSS(74) = "94.8"
		strCTCSS(75) = "97.4"
		strCTCSS(76) = "100.0"
		strCTCSS(77) = "103.5"
		strCTCSS(78) = "107.2"
		strCTCSS(79) = "110.9"
		strCTCSS(80) = "114.8"
		strCTCSS(81) = "118.8"
		strCTCSS(82) = "123.0"
		strCTCSS(83) = "127.3"
		strCTCSS(84) = "131.8"
		strCTCSS(85) = "136.5"
		strCTCSS(86) = "141.3"
		strCTCSS(87) = "146.2"
		strCTCSS(88) = "151.4"
		strCTCSS(89) = "156.7"
		strCTCSS(90) = "159.8"
		strCTCSS(91) = "162.2"
		strCTCSS(92) = "165.5"
		strCTCSS(93) = "167.9"
		strCTCSS(94) = "171.3"
		strCTCSS(95) = "173.8"
		strCTCSS(96) = "177.3"
		strCTCSS(97) = "179.9"
		strCTCSS(98) = "183.5"
		strCTCSS(99) = "186.2"
		strCTCSS(100) = "189.9"
		strCTCSS(101) = "192.8"
		strCTCSS(102) = "196.6"
		strCTCSS(103) = "199.5"
		strCTCSS(104) = "203.5"
		strCTCSS(105) = "206.5"
		strCTCSS(106) = "210.7"
		strCTCSS(107) = "218.1"
		strCTCSS(108) = "225.7"
		strCTCSS(109) = "229.1"
		strCTCSS(110) = "233.6"
		strCTCSS(111) = "241.8"
		strCTCSS(112) = "250.3"
		strCTCSS(113) = "254.1"
		strCTCSS(127) = "SEARCH"
		strCTCSS(128) = "023"
		strCTCSS(129) = "025"
		strCTCSS(130) = "026"
		strCTCSS(131) = "031"
		strCTCSS(132) = "032"
		strCTCSS(133) = "036"
		strCTCSS(134) = "043"
		strCTCSS(135) = "047"
		strCTCSS(136) = "051"
		strCTCSS(137) = "053"
		strCTCSS(138) = "054"
		strCTCSS(139) = "065"
		strCTCSS(140) = "071"
		strCTCSS(141) = "072"
		strCTCSS(142) = "073"
		strCTCSS(143) = "074"
		strCTCSS(144) = "114"
		strCTCSS(145) = "115"
		strCTCSS(146) = "116"
		strCTCSS(147) = "122"
		strCTCSS(148) = "125"
		strCTCSS(149) = "131"
		strCTCSS(150) = "132"
		strCTCSS(151) = "134"
		strCTCSS(152) = "143"
		strCTCSS(153) = "145"
		strCTCSS(154) = "152"
		strCTCSS(155) = "155"
		strCTCSS(156) = "156"
		strCTCSS(157) = "162"
		strCTCSS(158) = "165"
		strCTCSS(159) = "172"
		strCTCSS(160) = "174"
		strCTCSS(161) = "205"
		strCTCSS(162) = "212"
		strCTCSS(163) = "223"
		strCTCSS(164) = "225"
		strCTCSS(165) = "226"
		strCTCSS(166) = "243"
		strCTCSS(167) = "244"
		strCTCSS(168) = "245"
		strCTCSS(169) = "246"
		strCTCSS(170) = "251"
		strCTCSS(171) = "252"
		strCTCSS(172) = "255"
		strCTCSS(173) = "261"
		strCTCSS(174) = "263"
		strCTCSS(175) = "265"
		strCTCSS(176) = "266"
		strCTCSS(177) = "271"
		strCTCSS(178) = "274"
		strCTCSS(179) = "306"
		strCTCSS(180) = "311"
		strCTCSS(181) = "315"
		strCTCSS(182) = "325"
		strCTCSS(183) = "331"
		strCTCSS(184) = "332"
		strCTCSS(185) = "343"
		strCTCSS(186) = "346"
		strCTCSS(187) = "351"
		strCTCSS(188) = "356"
		strCTCSS(189) = "364"
		strCTCSS(190) = "365"
		strCTCSS(191) = "371"
		strCTCSS(192) = "411"
		strCTCSS(193) = "412"
		strCTCSS(194) = "413"
		strCTCSS(195) = "423"
		strCTCSS(196) = "431"
		strCTCSS(197) = "432"
		strCTCSS(198) = "445"
		strCTCSS(199) = "446"
		strCTCSS(200) = "452"
		strCTCSS(201) = "454"
		strCTCSS(202) = "455"
		strCTCSS(203) = "462"
		strCTCSS(204) = "464"
		strCTCSS(205) = "465"
		strCTCSS(206) = "466"
		strCTCSS(207) = "503"
		strCTCSS(208) = "506"
		strCTCSS(209) = "516"
		strCTCSS(210) = "523"
		strCTCSS(211) = "526"
		strCTCSS(212) = "532"
		strCTCSS(213) = "546"
		strCTCSS(214) = "565"
		strCTCSS(215) = "606"
		strCTCSS(216) = "612"
		strCTCSS(217) = "624"
		strCTCSS(218) = "627"
		strCTCSS(219) = "631"
		strCTCSS(220) = "632"
		strCTCSS(221) = "654"
		strCTCSS(222) = "662"
		strCTCSS(223) = "664"
		strCTCSS(224) = "703"
		strCTCSS(225) = "712"
		strCTCSS(226) = "723"
		strCTCSS(227) = "731"
		strCTCSS(228) = "732"
		strCTCSS(229) = "734"
		strCTCSS(230) = "743"
		strCTCSS(231) = "754"
		Dim cmb As Integer

		For cmb = 0 To 8
			
			cmbField(cmb).Items.Clear()
			cmbField(cmb).Items.Add("Ignore")
            cmbField(cmb).Items.Add("Frequency")
			cmbField(cmb).Items.Add("Name")
			cmbField(cmb).Items.Add("Tone")
			cmbField(cmb).Items.Add("Modulation")
            cmbField(cmb).Items.Add("Comment")
            cmbField(cmb).Items.Add("Name+Comment")
            cmbField(cmb).Items.Add("NAC(Dec)")
            cmbField(cmb).Items.Add("NAC(Hex)")
			cmbField(cmb).SelectedIndex = 0
		Next cmb

	End Sub
	
    Private Sub Form_Terminate_Renamed()
        cmdClose_Click(cmdClose, New System.EventArgs())
    End Sub
	
	Private Sub frmParse_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub
End Class