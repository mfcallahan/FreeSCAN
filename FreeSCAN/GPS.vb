Imports System.IO
Module GPS
    Public Const DefaultLat As String = "00000000N"
    Public Const DefaultLong As String = "00000000E"
    Function DecToDMS(ByVal Decimal_Deg As Single, ByVal blnLat As Boolean) As String
        Dim Degrees As Integer, Minutes As Single, Seconds As Single, MiliSecond As Single, strDir As String
        'accepts an angle formatted as a decimal value and converts it to a text value displayed in degrees, minutes, and seconds.
        'Set degree to Integer of Argument Passed
        If Decimal_Deg < 0 And blnLat = True Then
            strDir = "S"
        ElseIf Decimal_Deg >= 0 And blnLat = True Then
            strDir = "N"
        ElseIf Decimal_Deg <= 0 And Not blnLat Then
            strDir = "W"
        Else
            strDir = "E"
        End If
        If Decimal_Deg < 0 Then Decimal_Deg = Decimal_Deg * -1
        Degrees = CInt(Int(Decimal_Deg))   'double conversion because Cint rounds UP

        'Set minutes to 60 times the number to the right
        'of the decimal for the variable Decimal_Deg
        Minutes = (Decimal_Deg - CInt(Int(Degrees))) * 60
        'Set seconds to 60 times the number to the right of the
        'decimal for the variable Minute

        Seconds = ((Minutes - Int(Minutes)) * 60)
        MiliSecond = (Seconds - Int(Seconds)) * 100

        If MiliSecond >= 100 Then
            Seconds += 1
            MiliSecond -= 100
        End If

        If Seconds >= 60 Then
            Seconds -= 60
            Minutes += 1
        End If
        If Minutes >= 60 Then
            Minutes -= 60
            Degrees += 1
        End If
        'Returns the Result of degree conversion
        '(for example, 10.46 = 10~ 27  ' 36")

        DecToDMS = Format(Degrees, "000") & "." & Format(Int(Minutes), "00") & Format(Int(Seconds), "00") & Format(Int(MiliSecond), "00") & strDir

    End Function
    Function DMSToDec(ByVal Degree_Deg As String) As String
        ' Declare the variables to be double precision floating-point.
        Dim degrees As Double
        Dim minutes As Double
        Dim seconds As Double
        Dim strDir As String
        Dim intPrecision As Integer
        Dim miliSeconds As Double
        Dim intMult As Integer = 0
        If blnDebug = False Then On Error Resume Next
        strDir = Right(Degree_Deg, 1)
        If strDir = "S" Then 'returns a negative number
            intMult = -1
        ElseIf strDir = "W" Then
            intMult = -1
        ElseIf strDir = "N" Or strDir = "E" Then
            intMult = 1
        End If
        If intMult <> 0 Then  'chop off the last letter
            Degree_Deg = Left(Degree_Deg, Len(Degree_Deg) - 1)
        End If
        If Val(Degree_Deg) > 10000 Then
            Degree_Deg = CStr(Val(Degree_Deg) / 1000000)
        End If
        Degree_Deg = Format(Val(Degree_Deg), "00.00\'0000")
        ' Set degree to value before "°" of Argument Passed.
        If InStr(Degree_Deg, "'") = 0 Then
            'garbage input? abort
            DMSToDec = "0.00000000"
            Exit Function
        End If
        degrees = CDbl(Left(Degree_Deg, InStr(Degree_Deg, ".") - 1))
        ' Set minutes to the value between the "°" and the "'"
        ' of the text string for the variable Degree_Deg divided by
        ' 60. The Val function converts the text string to a number.
        minutes = CInt(OldMid(Degree_Deg, InStr(Degree_Deg, ".") + 1, 2))
        minutes = minutes / 60
        'minutes = OldMid(Degree_Deg, InStr(Degree_Deg, ".") + 2, 2)
        ' Set seconds to the number to the right of "'" that is
        ' converted to a value and then divided by 3600.

        seconds = CInt(OldMid(Degree_Deg, InStr(Degree_Deg, "'") + 1, 4))
        seconds = seconds / 3600
        seconds = seconds / 100



        DMSToDec = CStr(degrees + minutes + seconds)
        If intMult = -1 Then
            DMSToDec = CStr(CDbl(DMSToDec) * -1)
        End If
    End Function
    Sub GoogleViewDEG(ByVal strLat As String, ByVal strLong As String, ByVal strRange As String)
        'Opens a new thingy in google
        Dim strPage As String
        Dim TempDir As String
        Dim intFile As Integer
        Dim objStreamWriter As StreamWriter
        Dim ShellCode As String
        Dim strTitle As String
        Dim ZoomLevel As Integer
        If blnDebug = False Then On Error Resume Next
        If intCurrentGroup <> 0 Then
            strTitle = lblSiteNote.SiteKey(intCurrentSys, intCurrentGroup)
        Else
            strTitle = lblSiteNote.SysKey(intCurrentSys)

        End If
        frmGPS.TmrOpen.Enabled = True
        My.Application.DoEvents()
        ' frmGPS.lblLoc.Text = strTitle
        strTitle &= " - Google Maps provided by FreeSCAN"
        'TempDir = System.Environment.CurrentDirectory & "\fs-234683723-12332.htm"
        TempDir = GetTempFileName() & ".html"
           Dim C As String = Chr(13)
        strPage = My.Resources.GPSView.ToString

         'setup zoom level, depending on range
        If Val(strRange) = 0 Then
            ZoomLevel = 15
        ElseIf Val(strRange) < 6 Then
            ZoomLevel = 11
        ElseIf Val(strRange) <= 15 Then
            ZoomLevel = 10
        ElseIf Val(strRange) <= 30 Then
            ZoomLevel = 8
        ElseIf Val(strRange) < 50 Then
            ZoomLevel = 7
        ElseIf Val(strRange) <= 70 Then
            ZoomLevel = 6
        Else
            ZoomLevel = 5
        End If

        strPage = Replace(strPage, "DBLQUOTE", Chr(34))
        strPage = Replace(strPage, "LATSPEC", strLat)
        strPage = Replace(strPage, "LONGSPEC", strLong)
        strPage = Replace(strPage, "RADIUS_MILES", CStr(Val(strRange) * 1.60934))
        strPage = Replace(strPage, "TITLEBARSPEC", strTitle)
        strPage = Replace(strPage, "GPSZOOMLEVEL", CStr(ZoomLevel))
        objStreamWriter = New StreamWriter(TempDir)
        objStreamWriter.WriteLine(strPage)
        Console.WriteLine("GPs.VB:GoogleViewDeg:Saved file to " & TempDir)
        objStreamWriter.Close()

        frmGPS.WebSee.Url = New Uri(TempDir)


    End Sub

    Sub LoadGPS(ByRef strLat As String, ByRef strLong As String, ByRef strRange As String)
        'Loads the appropiate dimension into the GPS box for editing
        'start with lat


        Dim dblLoc As Double
        Dim sbuff As String
        Dim sText As String
        If blnDebug = False Then On Error Resume Next

        sbuff = DMSToDec(CStr(strLat))

        sText = Format(Val(sbuff), "00.000000") & ", "

        sbuff = DMSToDec(CStr(strLong))

        sText &= Format(Val(sbuff), "00.000000")
        frmGPS.txtGPS.Text = sText
        frmGPS.cmbRange.Text = Format(Val(strRange), "##0.0")
    End Sub
    Function FormatDMS(ByRef strCO As String) As String
        'this function takes co-ordinates stored in rad format and converts them to something more presentable
        Dim dblLoc As Double
        '     Dim strLat As String, strRet As String
        '     Dim strMinutes As String
        '     Dim strSeconds As String
        '     Dim intOffset As Integer
        If blnDebug = False Then On Error Resume Next
        FormatDMS = ""
        'If Len(strCO) = 10 Then
        'NORMAL FORMATTING
        'strMinutes = Strings.Left(strCO, 3)
        'strSeconds = OldMid(strCO, 4, 6)
        'FormatDMS = strMinutes & "." & strSeconds & Right(strCO, 1)
        dblLoc = Val(strCO)
        If Len(dblLoc) = 10 Then
            dblLoc = dblLoc / 10000000
        Else
            dblLoc = dblLoc / 1000000
        End If
        FormatDMS = Format(dblLoc, "#00.000000") & Right(strCO, 1)
        '      ElseIf Len(strCO) = 9 Then
        '      dblLoc = CDbl(Val(strCO))
        '      strLat = CStr(dblLoc)
        '      strMinutes = Strings.Left(strCO, 2)
        '      strSeconds = OldMid(strLat, 3, 6)
        '      FormatDMS = strMinutes & "." & strSeconds & Right(strCO, 1)
        '      End If
    End Function
   
    Function MakeItKosherGPS(ByRef strCO As String, ByRef strMode As String) As String
        'Takes GPS input from the user and verifies
        'silent but deadly input checking
        'could probably be done much more efficiently but who cares
        Dim strGPS(4) As String
        Dim blnFailed As Boolean

        Select Case UCase(strMode)
            Case "LAT"
                'validate coordinates
                strCO = Format(Val(strCO), "000.000000")
                strGPS(1) = ValidateGPSRange(CStr(Int(Val(strCO))), 90)
                strGPS(2) = ValidateGPSRange(Mid(strCO, 5, 2), 59)
                strGPS(3) = ValidateGPSRange(Mid(strCO, 7, 2), 59)
                strGPS(4) = ValidateGPSRange(Mid(strCO, 9, 2), 99)
            Case Else 'validate longtitude
                strCO = Format(Val(strCO), "000.000000")
                strGPS(1) = ValidateGPSRange(CStr(Int(Val(strCO))), 180)
                strGPS(2) = ValidateGPSRange(Mid(strCO, 5, 2), 59)
                strGPS(3) = ValidateGPSRange(Mid(strCO, 7, 2), 59)
                strGPS(4) = ValidateGPSRange(Mid(strCO, 9, 2), 99)
        End Select
        If blnFailed = True Then
            MakeItKosherGPS = ""
        Else
            MakeItKosherGPS = strGPS(1) & strGPS(2) & strGPS(3) & strGPS(4)
        End If
    End Function
    Function ValidateGPSRange(ByRef strCO As String, ByRef intMaxRange As Integer) As String
        strCO = CStr(Val(strCO))
        If Val(strCO) < 0 Then strCO = "0"
        If Val(strCO) > intMaxRange Then strCO = CStr(intMaxRange)

        If intMaxRange < 100 Then
            strCO = Format(Val(strCO), "00")
        Else
            strCO = Format(Val(strCO), "000")
        End If
        ValidateGPSRange = strCO
    End Function
    Function StripDMSDOT(ByVal strDMS As String) As String
        'converts a DMS like 23.231322W to a scanner uploadable version
        Dim strDir As String
        strDir = Strings.Right(strDMS, 1)
        strDMS = Format(Val(strDMS) + 1000, "000.000000")
        strDMS = Strings.Right(strDMS, Len(strDMS) - 1)
        strDMS = Replace(strDMS, ".", "") & strDir
        StripDMSDOT = strDMS
    End Function
    Function MakeItKosherGPSRange(ByVal strRange As String) As String
        Dim sngRange As Integer
        sngRange = CInt(strRange)
        If sngRange < 1 Then
            sngRange = 1
        ElseIf sngRange > 125 Then
            sngRange = 125
        End If
        MakeItKosherGPSRange = CStr(sngRange)

    End Function
    Function MakeGPS(ByVal strRange As String, ByVal blnXT As Boolean) As String
        'Converts a Mile range figure into something uploadable to the scanner
        On Error GoTo CriticStop
        Dim intRange As Single
        intRange = CSng(Val(strRange))
        MakeGPS = "1"
        If Val(strRange) = 0 Then strRange = "1"
        If blnXT Then
            strRange = CStr(Val(strRange) * 2)
        Else
            If intRange <= 0.5 Then
                intRange = 0.5
            ElseIf intRange <= 1 Then
                intRange = 1
            ElseIf intRange <= 3 Then
                intRange = 3
            ElseIf intRange <= 5 Then
                intRange = 5
            ElseIf intRange <= 10 Then
                intRange = 10
            ElseIf intRange <= 20 Then
                intRange = 20
            ElseIf intRange <= 30 Then
                intRange = 30
            ElseIf intRange > 30 Then
                intRange = 50
            End If
            strRange = CStr(intRange * 100)
        End If
        MakeGPS = strRange
        Exit Function
criticstop:
        sngErr += 1
        GenLog("Error in GPS range")
        MakeGPS = "1"

    End Function
End Module

