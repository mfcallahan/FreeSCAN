Option Strict Off
Option Explicit On
Module Mod996
	
	Public Declare Function SendMessage Lib "user32.dll"  Alias "SendMessageA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Short) As Integer


	Public Const WM_PAINT As Short = &HFs
	Public Const WM_PRINT As Short = &H317s
	Public Const PRF_CLIENT As Integer = &H4 ' Draw the window's client area
	Public Const PRF_CHILDREN As Integer = &H10 ' Draw all visible child
	Public Const PRF_OWNED As Integer = &H20 ' Draw all owned windows
	
	

    Sub RRException(Optional ByVal strErr As String = Nothing)
        Dim intUse As Integer
        intUse = MsgBox("Error retrieving data from Radio Reference. Verify your internet connection, account status, and try again." & strErr, MsgBoxStyle.Critical, "Error")

    End Sub
	
	Sub GenLog(ByRef strMsg As string)
		'generates the error log window used when uploading/downloading
		With frmConsole.lstErr
			
			If UCase(strMsg) = "CLEARALL" Or .Items.Count > 200 Then
				.Items.Clear()
				frmConsole.Visible = False
			Else
				.Items.Add((strMsg))
				System.Windows.Forms.Application.DoEvents()
			End If
		End With
	End Sub
	
	Function GetBPParam(ByRef intSys As Integer, ByRef intSite As Integer, ByRef intParamType As Short, ByRef intParamRow As Short) As Double
		'retrieves a paramater from the band plan of the system specified
		If blnDebug = False Then On Error Resume Next
		Dim strBP(6, 6) As String
		Dim strSet() As String
		Dim strBuff, strRet As String
        Dim strVars() As String
        strRet = Nothing
		strBuff = varSite(intSys, intSite, 0, 62)
		If Len(strBuff) > 10 Then
			strVars = Split(strBuff, "@")
			If UBound(strVars) = 5 Then
				Erase strSet
				strSet = Split(strVars(intParamRow), ",")
				If UBound(strSet) = 3 Then
					strRet = strSet(intParamType)
				End If
			End If
		End If
		GetBPParam = Val(strRet)
	End Function
	Sub SaveBPParam(ByRef intSys As Integer, ByRef intSite As Integer, ByRef intParamType As Short, ByRef intParamRow As Short, ByRef strParam As String)
		'saves a given paramater to the system's band plan
		If blnDebug = False Then On Error Resume Next
		Dim strBP(6, 6) As String
		Dim strSet() As String
		Dim intCnt As Integer
		Dim intParam As Integer
		Dim strRet, strBuff, strLine As String
		Dim strVars() As String
		strBuff = varSite(intSys, intSite, 0, 62)
		'Load the data to memory
		If Len(strBuff) > 10 Then
			strVars = Split(strBuff, "@")
			If UBound(strVars) = 5 Then
				For intCnt = 0 To 5
					Erase strSet
					strSet = Split(strVars(intCnt), ",")
					For intParam = 0 To 3
						strBP(intCnt, intParam) = strSet(intParam)
					Next intParam
				Next intCnt
			End If
		End If
		'replace given data
		strBP(intParamRow, intParamType) = strParam
		'reencode and save
		strBuff = ""
		For intCnt = 0 To 5
			strLine = ""
			For intParam = 0 To 3
				strLine = strLine & strBP(intCnt, intParam)
				If intParam <> 3 Then strLine = strLine & ","
			Next intParam
			strBuff = strBuff & strLine
			If intCnt <> 5 Then
				strBuff = strBuff & "@"
			End If
		Next intCnt
		'save changes
		varSite(intSys, intSite, 0, 62) = strBuff
	End Sub
	
	Sub ConvLegacyBP()
		'goes through memory, converts old style bandplan to new style
		If blnDebug = False Then On Error Resume Next
		Dim intSys, intSite As Integer
		Dim intCnt As Short
		For intSys = 1 To MaxSystems
			If Val(varSite(intSys, 0, 0, 3)) > 1 Then
				For intSite = 1 To MaxGroups
					'Does this site have an old style band plan? if so convert it and delete the old
					If Val(varSite(intSys, intSite, 0, 17)) > 0 Then
						'do the conversion
						For intCnt = 0 To 2
							Call SaveBPParam(intSys, intSite, 0, intCnt, CStr(Val(varSite(intSys, intSite, 0, 17 + (intCnt * 3))) * 10000))
							Call SaveBPParam(intSys, intSite, 2, intCnt, CStr(Val(varSite(intSys, intSite, 0, 18 + (intCnt * 3))) * 100))
							Call SaveBPParam(intSys, intSite, 3, intCnt, varSite(intSys, intSite, 0, 19 + (intCnt * 3)))
						Next intCnt
						'clear the old stuff
						For intCnt = 17 To 25
							varSite(intSys, intSite, 0, intCnt) = CStr(Nothing)
						Next intCnt
					End If
				Next intSite
			End If
		Next intSys
	End Sub
	
	
	Sub AutoCalcUpper(ByRef intSys As Integer, ByRef intSite As Integer, ByRef blnSilent As Boolean)
		'automatically calculate upper band frequency
		'for xt scanners or motorola custom band plans
		Dim dblTable(6, 3) As Double
		Dim dblFreq, newFreq As Double
		Dim intOffset1 As Integer
		Dim intRow, intCol As Short
		Dim intOffset As Integer
		Dim dblStep As Double
		For intRow = 0 To 5
			For intCol = 0 To 3
				dblTable(intRow, intCol) = GetBPParam(intSys, intSite, intCol, intRow)
			Next intCol
		Next intRow
		If dblTable(0, 0) < 1 And blnSilent = False Then
			intRow = MsgBox("A base(lower) frequency, offset, and spacing/step value must be specified before upper frequencies can be calculated.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical)
			Exit Sub
		ElseIf dblTable(0, 0) < 1 Then 
			Exit Sub
		End If
		'determine if we are using single band plan mode or multi
		If dblTable(1, 0) = 0 Then 'single band plan calculation mode
			dblFreq = dblTable(0, 0) / 10000
			dblStep = dblTable(0, 2) / 100000
			intOffset = dblTable(0, 3)
			newFreq = dblFreq + ((759 - intOffset) * dblStep)
			newFreq = newFreq * 10000
			Call SaveBPParam(intSys, intSite, 1, 0, Str(newFreq))
		Else 'mutli plan calculation mode
			For intRow = 0 To 5
				dblFreq = dblTable(intRow, 0) / 10000
				dblStep = dblTable(intRow, 2) / 100000
				intOffset = dblTable(intRow, 3)
				If intRow <> 5 Then
					If dblTable(intRow + 1, 0) > 0 Then
						intOffset1 = dblTable(intRow + 1, 3)
					Else
						intOffset1 = 760
					End If
				Else
					intOffset1 = 760
				End If
				If dblFreq > 0 Then
					newFreq = dblFreq + ((intOffset1 - 1 - intOffset) * dblStep)
					newFreq = newFreq * 10000
					Call SaveBPParam(intSys, intSite, 1, intRow, Str(newFreq))
				End If
			Next intRow
		End If
		
	End Sub
	
	Function StripQuote(ByRef strName As String) As String
		'removes quotes from start and end of a string
		StripQuote = Replace(strName, Chr(34), "")
		
	End Function
	
	Function FormatTGID(ByRef strTGID As String) As String
		'reformats a TGID to be compatible with Motorola Type I systems
		Dim intCnt As Integer
		Dim strBuff As String
		strTGID = Trim(strTGID)
        If InStr(strTGID, "-") = 0 And Len(strTGID) <> 4 Then
            strBuff = strTGID
        ElseIf Len(strTGID) = 4 Then
            strBuff = Replace(strTGID, "-", "")
            strBuff = Format(strTGID, "000-0")
        Else
            intCnt = InStr(strTGID, "-")
            If intCnt <> 0 Then
                strBuff = Left(strTGID, intCnt)
                strBuff = strBuff & Val(Right(strTGID, Len(strTGID) - intCnt))
            Else
                strBuff = strTGID
            End If
        End If
		FormatTGID = strBuff
		'   FormatTGID = Format(strTGID, "000-0#")
		
	End Function
	
	Sub GetOwner(ByRef intIndex as Integer)
		
		'Returns the system and group numbers of an individual channel in the CHanInfo array
		
		Dim lngGroup, lngSys As Integer
		Dim strBuff As String
		If varSite(lngChanSys, lngChanGroup, 0, 10) = ChanInfo(intIndex, 10) Then
			'if its already been found, dont go looking for it again
		Else
			
			strBuff = ChanInfo(intIndex, 10)
			For lngSys = 1 To MaxSystems
				For lngGroup = 1 To MaxGroups
					If varSite(lngSys, lngGroup, 0, 10) = strBuff Then
						lngChanSys = lngSys
						lngChanGroup = lngGroup
						lngSys = MaxSystems
						lngGroup = MaxGroups
					End If
				Next lngGroup
			Next lngSys
		End If
	End Sub
	
	Function RRToneLookUp(ByRef strTone As string) As integer
		'gets an RR tone and returns a tone index for storage
		Dim strBuff As String
		Dim intTone, cnt As Integer
		intTone = 0
		
        If strTone = "CSQ" Or strTone = "0" Then

            RRToneLookUp = 0
            Exit Function
        End If
        Console.WriteLine("Mod996:RRToneLookup:REceived raw tone " & strTone)
        strTone = UCase(strTone)
		strBuff = CStr(Val(strTone))
		
        If InStr(strTone, " PL") > 0 Then
            For cnt = 64 To 127
                If InStr(UCase(CTCSS(cnt)), strBuff) <> 0 Then 'found the tone
                    intTone = cnt
                    cnt = 127
                End If
            Next cnt

        ElseIf InStr(strTone, "DPL") > 0 Then
            For cnt = 128 To 231
                If InStr(UCase(CTCSS(cnt)), strBuff) <> 0 Then 'found the tone
                    intTone = cnt
                    cnt = 231
                End If
            Next cnt
        ElseIf strTone <> "" Then
            If strTone = "OFF" Then strTone = "None"
            For cnt = 0 To 231
                If InStr(CTCSS(cnt), UCase(strTone)) <> 0 Then 'found the tone
                    intTone = cnt
                    cnt = 231
                End If
            Next cnt
        End If
		
		RRToneLookUp = intTone
	End Function
    Function TCase(ByVal strMsg As String) As String
        'converts string to title case
        TCase = StrConv(strMsg, VbStrConv.ProperCase)
    End Function
    Function MakeItKosherNAC(ByVal strNAC As String) As String
        Dim intBuff As Integer
        'sanitizes NAC
        If UCase(strNAC) = "SRCH" Then
            'good, do nothing
            strNAC = "SRCH"
        ElseIf HexToDec(strNAC, True) <> 0 Or strNAC = "0" Then
            intBuff = HexToDec(strNAC, True)
            If intBuff < 0 Then
                intBuff = 0
            ElseIf intBuff > 4095 Then
                intBuff = 4095
            End If
            strNAC = Hex(intBuff)
        Else
            strNAC = Nothing
        End If

        makeitkoshernac = strNAC
    End Function
    Function MakeItKosherNumTag(ByVal strNum As String) As String
        If IsNumeric(strNum) = False Or Len(strNum) = 0 Then
            strNum = "NONE"
        Else
            If val(strnum) > 999 Then
                strnum = 999
            ElseIf val(strnum) < 0 Then
                strnum = 0
            End If
        End If
        makeitkoshernumtag = strnum
    End Function
    Function OldMid(ByVal strInp As String, ByVal intStart As Integer, ByVal intLen As Integer) As String
        'Does an old school mid operation
        Dim strBuff As String
        strBuff = Mid(strInp, intStart)
        If intLen < 0 Then intLen = 1
        If intLen < Len(strBuff) Then
            strBuff = Left(strBuff, intLen)
        End If
        OldMid = strBuff
    End Function
End Module

