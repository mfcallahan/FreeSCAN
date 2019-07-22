Option Strict Off
Option Explicit On
Friend Class frmQKEdit

    Inherits System.Windows.Forms.Form
    Dim lstIndex(5000) As Integer
    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
        Me.Visible = False
    End Sub

    Private Sub cmdeNuke_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdeNuke.Click
        Dim intSin, intLstCnt As Integer
        Dim strBuff As String
        If lstSystems.Items.Count = 0 Then
            intSin = MsgBox("No systems selected for deletion. Please clikc on Read Systems to download list.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If RemoteMode() = True Then Exit Sub

        If ReadyCOM() = False Then Exit Sub
        SendCMD("PRG")
        With Form1
            For intLstCnt = 0 To lstSystems.Items.Count - 1
                Call FormWait(intLstCnt, lstSystems.Items.Count - 1, 1)
                If lstSystems.GetItemChecked(intLstCnt) = True Then 'nuke this system
                    strBuff = SendCMD("DSY," & lstIndex(intLstCnt))
                End If
            Next intLstCnt
        End With
        SendCMD("EPG")
        Form1.msc.Close()

        Call cmdReadScan_Click(cmdReadScan, New System.EventArgs())
    End Sub
    Function ReadyCOM() As Boolean
        'readies COM Port

        ReadyCOM = False
        If Form1.msc.IsOpen = True Then
            MsgBox("FreeSCAN is currently busy. Please wait until the current operation is complete or restart the program.")
            Call FormWait(0, 0, 0)
            Exit Function
        End If
        'download system
        'check com port settings
        If Val(RadioSetting(44)) = 0 Then 'nocomport num
            MsgBox("Please choose a COM port before continuing.")
            Call FormWait(0, 0, 0)
            Exit Function
        End If
        If Val(RadioSetting(45)) = 0 Then 'baud rate
            MsgBox("Please set COM Port speed before continuing.")
            Call FormWait(0, 0, 0)
            Exit Function
        End If
        Try
            Form1.msc.PortName = "COM" & RadioSetting(44)
            Form1.msc.BaudRate = (RadioSetting(45))
            Form1.msc.Open()
            Form1.msc.Close()
        Catch ex As Exception
            MsgBox("FreeSCAN has detected an invalid COM port. Please select another COM port and try again.")
            Call FormWait(0, 0, 0)
            Exit Function
        End Try

        With Form1
            .msc.Open()
        End With

        ReadyCOM = True

    End Function
    Private Sub cmdReadScan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReadScan.Click
        If blnDebug = False Then On Error GoTo criticalerror
        Dim strBuff As String
        Dim strMDL As String
        Dim intMem As Integer
        Dim intSysCnt, intPos As Integer
        If RemoteMode() = True Then Exit Sub

        If ReadyCOM() = False Then Exit Sub
        Call FormWait(1, 5, 1)
        Call GenSysList()
        intPos = 13
        Call FormWait(3, 5, 1)
        With Form1
            strMDL = SendCMD("MDL")
            If InStr(strMDL, "246") <> 0 Or InStr(strMDL, "230") <> 0 Then
                strMDL = "246"
                intPos = 11
            ElseIf InStr(strMDL, "330") <> 0 Then
                strMDL = "330"
            ElseIf InStr(strMDL, "15") <> 0 Then
                strMDL = "15"
            ElseIf InStr(strMDL, "996") <> 0 Then
                strMDL = "996"
            ElseIf InStr(strMDL, "396") <> 0 Then
                strMDL = "396"
            ElseIf InStr(strMDL, "346") <> 0 Then
                strMDL = "346"
            Else
                Form1.msc.Close()
                strMDL = CStr(MsgBox("Incompatible model or other error. Check your serial port settings. Cannot continue. Code Received: " & strMDL, MsgBoxStyle.Critical))
                lstSystems.Items.Clear()
                Call FormWait(0, 0, 0)
                Exit Sub
            End If
            strBuff = (SendCMD("PRG"))
            intMem = Val(SendCMD("MEM"))
            Call FormWait(5, 5, 1)
            intSysCnt = Val(SendCMD("SCT"))
            strBuff = (SendCMD("EPG"))
            If intMem < 0 Or intMem > 100 Then

                intMem = 0
                strMDL = CStr(MsgBox("Bad data received from scanner. Try lowering the baud rate and try again."))
                Call FormWait(0, 0, 0)
                Exit Sub
            End If

            prgMem.Value = intMem

            lblMem.Text = intMem & "% Full"

            If strMDL = "246" Or strMDL = "330" Then

                intMem = 200 - intSysCnt
            ElseIf strMDL = "396" Then

                intMem = 400 - intSysCnt
            ElseIf strMDL = "996" Then

                intMem = 500 - intSysCnt
            ElseIf strMDL = "15" Then

                intMem = 500 - intSysCnt
            ElseIf strMDL = "246" Then

                intMem = 1000 - intSysCnt
            End If

            lblFreeSys.Text = intMem & " Free Systems"
        End With
        SendCMD("EPG")
        frmCommsDownload.CheckResume()
        Form1.msc.Close()
        Call FormWait(0, 0, 0)
        Exit Sub
CriticalError:
        MsgBox("Critical Comms Error detected, confirm you have selected a valid COM Port and that is not used by any other application. ")
        Exit Sub
    End Sub

    Sub initForm()
        lstSystems.Items.Clear()
        prgMem.Value = 0
        lblMem.Text = ""
        lblFreeSys.Text = ""
    End Sub
    Sub GenSysList()
        On Error GoTo CriticalError
        Dim strCMD(5) As String
        Dim strChanName, strName, strMDL, strModMode As String
        Dim Response As String
        Dim intEMG, intDelay, intAtt, intLockout, intDataSkip, intCTCSS As Integer
        Dim intHoldTime As Integer

        Dim ResponseCode As String
        Dim intPos As Integer
        Dim strCustFleetMap As String
        Dim strSysType As String
        Dim blnLastSys As Boolean
        Dim intSin, x, intSeqIndex, intList, intSIH As Integer
        Dim strSIN As String
        ReDim lstIndex(5000)
        Dim lstCount As Integer = 0
        'build a list of systems on the scanner
        If Me.Visible = True Then

            ResponseCode = SendCMD("PRG")
            If ResponseCode = "NG" Then
                MsgBox("Please exit menu mode before attempting to download.")
                Exit Sub
            End If
        End If
        intPos = 13


        strMDL = SendCMD("MDL")

        If InStr(strMDL, "246") <> 0 Then
            intPos = 11
        End If
        'begin download
        lstSystems.Items.Clear()

        intSIH = Val(SendCMD("SIH"))
        intSin = intSIH
        If intSIH = -1 Then
            'no systems loaded in radio
            MsgBox("No systems can be found in scanner.")
            blnLastSys = True
        Else
            Do Until blnLastSys = True
                'start system loop
                If intSin = -1 Then
                    'no more sites to download
                    blnLastSys = True
                Else
                    'download basic site paramaters

                    strSIN = SendCMD("SIN," & intSin)
                    'add the name to the site list


                    lstSystems.Items.Add(("[" & ParaParse(strSIN, 1) & "] " & ParaParse(strSIN, 2)))
                    'create an index of lstSystems index array versus system index array
                    lstIndex(lstCount) = intSin
                    lstCount += 1
                    'log the memory entry for the site after this

                    intSin = Val(ParaParse(strSIN, intPos))
                    If intSin = -1 Then blnLastSys = True
                End If
            Loop
        End If
        lstSystems.Enabled = True
        Exit Sub
CriticalError:
        MsgBox("Critical Comms Error detected, confirm you have selected a valid COM Port and that is not used by any other application.")
        Exit Sub

    End Sub

    Private Sub cmdReset_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReset.Click
        Dim intSin As Integer
        intSin = MsgBox("Are you sure you want to reset? This will delete all programming and settings on the scanner.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
        If RemoteMode() = True Then Exit Sub
        If intSin = 6 Then

            If ReadyCOM() = False Then Exit Sub
            Call FormWait(50, 100, 1)
            SendCMD("PRG")
            SendCMD("CLR")
            Call FormWait(100, 100, 1)
            SendCMD("EPG")
            Form1.msc.Close()
            lstSystems.Items.Clear()
            prgMem.Value = 0
            lblMem.Text = "0% Used"
            lblFreeSys.Text = ""
        Else
            Exit Sub
        End If
        Call FormWait(0, 0, 0)
        intSin = MsgBox("All programming has been cleared.", MsgBoxStyle.Information)
    End Sub
End Class