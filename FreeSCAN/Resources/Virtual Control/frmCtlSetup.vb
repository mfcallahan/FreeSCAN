Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports System.Speech
Imports System.Speech.Synthesis

Friend Class frmCtlSetup
    Inherits System.Windows.Forms.Form

    Dim intCycle As Integer 'cycle count, for updating things that happen every once in a while
    Dim sngLastBAV As Single
    Dim intLastRecID As Integer
    Public strIdent As String ' unique identifier for this scanner
    'negative delay
    Public blnNegDelay As Boolean
    Public blnCommsUp As Boolean 'this simply indicate whether there is good communication with the scanner
    Public NumHits As Long = 0 'How many hits received in virtual control
    Public sngMaxScanTime As Single 'Max amount of seconds for channel activety before autoscan (negative delay)
    Public bRecTimeout As Boolean = False 'Has the last recording timed out? if so dont start a new one
    Dim CycleCntRst As Integer 'How many cycles before the last recording was stopped
    Public sngScanTime As Single 'How many seconds the current channel has been active for
    Dim strTGIDidx(1, 1) As String '0,0=boundry limit, x,0=Sys&Grp Name,1=TGID,2=TGID Name, 3 +4 =rsv
    Dim GotID As Boolean
    Dim LastSqlState As Boolean = False 'Last state of the squelch, used for hit tracking
    Public strColour As String 'background colour for window
    Dim blnRSSI As Boolean 'is RSSi available
    Dim LastActiveTrans As Boolean 'Last state of receive when run through the timer cycle
    Dim sLogSaveDate As String = Nothing
    Dim DefaultLogExt As String = ".fslog"
    Public VCTitle As String = "Virtual Control"

    Dim LastCTCSSFound As String
    '////// VOICE SYNTEHSIS STUFF
    Dim VoiceOutput As SpeechSynthesizer = New SpeechSynthesizer
    Dim LastTag As String


    Sub ClearLog()
        'clear the log
        Erase strRecLog
        ReDim strRecLog(100, MaxRecLogFields)
        intLogPos = 0
        With frmLog
            .grdSum.Rows.Clear()
            .grdID.Rows.Clear()
            .grdLog.Rows.Clear()
            .DrawDisplayLog()
        End With

    End Sub
    Sub GenTGIDIndex()
        'this subroutine generates the variable strTGIDidx
        If blnDebug = False Then On Error Resume Next
        Dim intGrp, intSys, intTGID As Integer
        Dim strMemName As String
        Dim strBuff1, strBuff, strbuff2 As String
        Dim blnFound As Boolean
        Dim strGroupID As String
        Dim intCnt As Integer
        Dim intGrpCnt As Integer

        'figure out how much memory we need to allocate
        For intSys = 1 To MaxSystems
            If Val(varSite(intSys, 0, 0, 3)) > 1 Then 'this is a trunked system, go hunting
                For intGrp = 1 To MaxGroups
                    If varSite(intSys, intGrp, 0, 5) = "2" Then 'this is a group, save the ID

                        intTGID = intTGID + Val(lblSiteNote.GetNumChan(intSys, intGrp))
                    End If
                Next intGrp
            End If
        Next intSys
        Erase strTGIDidx

        ReDim strTGIDidx(intTGID, 4)

        strTGIDidx(0, 0) = CStr(intTGID)
        If intTGID = 0 Then Exit Sub
        'finally build the index
        intTGID = 0
        For intSys = 1 To MaxSystems
            If Val(varSite(intSys, 0, 0, 3)) > 1 Then 'this is a trunked system, go hunting
                For intGrp = 1 To MaxGroups
                    strGroupID = varSite(intSys, intGrp, 0, 10)
                    If strGroupID <> "" Then
                        For intCnt = 1 To MaxChan
                            If ChanInfo(intCnt, 10) = strGroupID Then 'this is a tgid
                                intTGID = intTGID + 1
                                strTGIDidx(intTGID, 0) = Trim(varSite(intSys, 0, 0, 1))
                                strTGIDidx(intTGID, 1) = ChanInfo(intCnt, 2) 'tgid
                                strTGIDidx(intTGID, 2) = ChanInfo(intCnt, 1) 'name
                                'other two paramrs are rsv
                            End If
                        Next intCnt
                    End If 'strgroupid<>""
                Next intGrp
            End If
        Next intSys
        strDisplay(5) = "SmartScan Ready"
        strDisplay(6) = intTGID & " TGIDs loaded."
    End Sub


    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        lblSiteNote.Visible = True
        Me.Visible = False
        Timer_Renamed.Enabled = False
    End Sub

    Private Sub cmdComSetup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdComSetup.Click
        Me.Enabled = False
        frmCOMPort.Visible = True
        frmCOMPort.Activate()
    End Sub
    Sub ShowComSettings()
        'displays current com port settings
        lblComSetting.Text = "COM: " & RadioSetting(44) & " SPEED: " & RadioSetting(45)
    End Sub



    Sub cmdOpenControl_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOpenControl.Click
        Dim sBuff As String = Nothing

        If blnDebug = False Then On Error Resume Next

        System.Array.Clear(strDisplay, 0, strDisplay.Length)

        System.Array.Clear(strRxSta, 0, strRxSta.Length)
        If chkHideMain.CheckState = 1 Then
            lblSiteNote.Visible = False
        End If

        sngMaxScanTime = MakePositive(Val(GetSetting("FreeSCAN", "Settings", "MaxScanTime", CStr(8))))
        If CBool(GetSetting("FreeSCAN", "Settings", "EnableNegDelay", CStr(False))) = True Then
            blnNegDelay = True
        Else
            blnNegDelay = False
        End If
        blnEnableLog = chkLog.CheckState
        If intLogPos = 0 Then 'get the log ready if its not ready
            ClearLog()
            ReDim strRecLog(150, 15)
        End If
        If chkLog.CheckState = 1 Then
            frmLog.Visible = True
        Else
            frmLog.Visible = False
        End If

        'now that we have good comms, launch the interface
        If optInterface(0).Checked Then
            frmCtlIpod.DrawWin()
            Me.Visible = False
            frmCtlIpod.EnableLoggingToolStripMenuItem.Checked = blnEnableLog
            frmCtlIpod.Visible = True
        ElseIf optInterface(1).Checked Then
            Me.Visible = False
            frmCtlWin.Visible = True
            frmCtlWin.mnuToolsNegDlyEnable.Checked = blnNegDelay
            frmCtlWin.UpdateMenuCaption()
            tmrNegDelay.Enabled = blnNegDelay
        ElseIf optInterface(2).Checked Then
            frmCtlLCARS.Visible = True
            Me.Visible = False
            frmCtlLCARS.mnuToolsNegDlyEnable.Checked = blnNegDelay
            frmCtlLCARS.UpdateMenuCaption()
            tmrNegDelay.Enabled = blnNegDelay
        End If
        If chkReduceCPU.Checked Then
            Timer_Renamed.Interval = 550
        Else
            Timer_Renamed.Interval = 250
        End If
        'Save virtual control preferences
        sBuff = 0
        If chkLog.Checked Then
            sBuff = 1
        End If
        SaveSetting("FreeSCAN", "Settings", "Autolog", sBuff)
        sBuff = 0
        If chkHideMain.Checked Then
            sBuff = 1
        End If
        SaveSetting("FreeSCAN", "Settings", "HideMain", sBuff)
        sBuff = 0
        If chkReduceCPU.Checked Then
            sBuff = 1
        End If
        SaveSetting("FreeSCAN", "Settings", "ReduceCPU", sBuff)
      
        StartCOMMS()
    End Sub
    Sub StartCOMMS()
        'start virtual scanner control
        Dim strBuff As String
        blnRmtCtlMode = True
        If blnDebug = False Then On Error GoTo criticerror
        strUserCMD = ""

        System.Array.Clear(strDisplay, 0, strDisplay.Length)
        strDisplay(1) = "Establishing..."
        'generate a tgid index for the expander to handle
        GenTGIDIndex()
        DrawDisplay()
        blnCommsUp = False
        If Form1.msc.IsOpen = True Then Form1.msc.Close()
        Dim Response As String
        Timer_Renamed.Enabled = False
        'find the scanner model, if any
        If Not lblSiteNote.blnVirtControlStartup Then
            InitCOMPort()
        End If
        blnSendBusy = False
        Form1.msc.PortName = "COM" & RadioSetting(44)
        Form1.msc.BaudRate = (RadioSetting(45))
        If COMPortExists() = False Then
            strDisplay(1) = "Check settings"
            DrawDisplay()
            Exit Sub
        End If
        frmRecord.FinalMP3Name = Nothing
        Module1.intErrors = 0

        If Not Form1.msc.IsOpen Then Form1.msc.Open()
        Form1.msc.DiscardOutBuffer()
        Form1.msc.DiscardInBuffer()
        strMDL = SendCMD("MDL")



        VCTitle = strMDL

        If strMDL = "UBC800XLT" Then
            strMDL = "BCT15"
        ElseIf strMDL = "UBC3500XLT" Then
            strMDL = "BR330T"
        End If
        If Strings.Left(strMDL, 1) = "U" Then
            strMDL = Strings.Right(strMDL, Len(strMDL) - 1)
        End If

        If InStr(SupportedScanners, strMDL) = 0 And strMDL <> "" Then
            strDisplay(1) = "CANNOT ESTABLISH"
            strDisplay(2) = "Bad data or incompatible"
            strDisplay(3) = strMDL
            DrawDisplay()
            Form1.msc.Close()
            Exit Sub
        ElseIf strMDL = "" Or strMDL = "-1" Then
            strDisplay(1) = "CANNOT ESTABLISH"
            strDisplay(2) = "Check Com Settings"
            strDisplay(3) = "No response from"
            strDisplay(4) = "scanner."
            DrawDisplay()
            Form1.msc.Close()
            Exit Sub
        End If
        ScannerModel = strMDL

        'Add in scanner serial number, if possible
        strBuff = SendCMD("ESN")
        If strBuff <> "ERR" And Len(strBuff) > 14 Then
            VCTitle &= "-" & OldMid(strBuff, 12, 3)
        End If
        DisableCCO(strMDL, False) 'Disable control output
        strBuff = ""
        'check for RSSI indicator capability
        If Form1.msc.IsOpen = True Then

            strBuff = SendCMD("PWR")
        Else
            blnRSSI = True
        End If
        strIdent = ""

        strIdent = strMDL & SendCMD("ESN")

        If Len(strBuff) > 9 Then
            blnRSSI = True
            frmCtlWin.mnuJump.Enabled = True
        Else
            blnRSSI = False
            frmCtlWin.mnuJump.Enabled = False
        End If


        intCycle = 0
        blnSendBusy = False
        Timer_Renamed.Enabled = True
        frmRecord.blnRecFault = False
        If Form1.msc.IsOpen = False Then
            strDisplay(1) = "Cannot establish"
            DrawDisplay()
        End If
        Exit Sub
criticerror:
        MsgBox("Critical Comms Error detected, confirm you have selected a valid COM Port and that is not used by any other application.")
        strDisplay(1) = "Cannot establish"
        strDisplay(2) = "Try Again"
        Timer_Renamed.Enabled = False
        DrawDisplay()
        If Form1.msc.IsOpen = True Then Form1.msc.Close()
        Exit Sub
    End Sub
    Sub StopCOMMS()
        If blnDebug = False Then On Error Resume Next
        Timer_Renamed.Enabled = False
        blnCommsUp = False
        Dim intCnt As Integer
        Call frmRecord.StopRec()
        strUserCMD = ""
        For intCnt = 1 To 300000
            strDisplay(1) = "COMMS Off"
        Next intCnt
        DrawDisplay()
        If Form1.msc.IsOpen Then Form1.msc.Close()

        System.Array.Clear(strDisplay, 0, strDisplay.Length)
        strDisplay(1) = "COMMS Off"
        DrawDisplay()
        blnRmtCtlMode = False
    End Sub

    Private Sub frmCtlSetup_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub
    Private Sub frmCtlSetup_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim sBuff As String = Nothing
        InitCOMPort()
        ShowComSettings()


        optInterface(0).Checked = False
        optInterface(1).Checked = True  'set win interface as the default

        'Load up virtual control preferences
        sBuff = GetSetting("FreeSCAN", "Settings", "Autolog", "1")
        chkLog.Checked = MakeBoolean(sBuff)
        sBuff = GetSetting("FreeSCAN", "Settings", "HideMain", "1")
        chkHideMain.Checked = MakeBoolean(sBuff)
        sBuff = GetSetting("FreeSCAN", "Settings", "ReduceCPU", "0")
        chkReduceCPU.Checked = MakeBoolean(sBuff)
    End Sub

    Private Sub Form_Terminate_Renamed()
        Call cmdCancel_Click(cmdCancel, New System.EventArgs())
    End Sub
    Function AsciiOnly(ByRef strItem As String) As String
        'returns only valid ascii characters
        Dim strKosher, strChar As String
        Dim intCharPos As Integer
        'cleans up a name for a group/system so it can be accepted
        strKosher = Nothing
        strItem = Replace(strItem, Chr(34), "''")
        strItem = Replace(strItem, Chr(44), " ")
        'remove/replace evil characters, such as quotations or commas
        For intCharPos = 1 To Len(strItem)
            strChar = Mid(strItem, intCharPos, 1)
            If Asc(strChar) <= 31 Or Asc(strChar) >= 127 Then
                'replace with ?
                strChar = " "
            End If
            strKosher &= strChar
        Next intCharPos
        AsciiOnly = Replace(strKosher, "&", "&&")
    End Function
    Sub DrawDisplay()
        If frmCtlWin.Visible = True Then
            frmCtlWin.DrawWin()
        ElseIf frmCtlIpod.Visible = True Then
            frmCtlIpod.DrawWin()
        ElseIf frmCtlLCARS.Visible = True Then
            frmCtlLCARS.DrawWin()
        End If

    End Sub
    Function BaseStation(ByRef mdl As String) As Boolean

        If InStr(mdl, "996") <> 0 Or InStr(mdl, "15") <> 0 Then

            BaseStation = True
        Else

            BaseStation = False
        End If
    End Function
    Function IsXTScanner(ByVal strMDL As String) As Boolean
        Select Case strMDL
            Case "BCD396XT"
                IsXTScanner = True
            Case "BC346XT"
                IsXTScanner = True
            Case "BC346XTC"
                IsXTScanner = True
            Case "BCT15X"
                IsXTScanner = True
            Case "BCD996XT"
                IsXTScanner = True
            Case "BCD996P2"
                IsXTScanner = True
            Case "BCD325P2"
                IsXTScanner = True
            Case Else
                IsXTScanner = False
        End Select
    End Function

    Private Sub frmCtlSetup_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call cmdCancel_Click(cmdCancel, New System.EventArgs())
    End Sub

    Private Sub Timer_Renamed_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer_Renamed.Tick
        'loops the scanner through the cycle
        Dim strGLG, strDisp, strBuff As String
        Dim intCnt As Integer
        Dim intVol, intBAV, intSql As Integer
        Dim strAPCO As String = ""
        Dim strWin As String
        Dim intRSSI As Integer
        Dim blnNAC As Boolean = False
        Dim strNAC As String = ""
        Const MuteActive As String = "1" 'somebody is NOT talking
        Const MuteInactive As String = "0" 'Somebody is talking
        Const SqlOpen As String = "1" ' Squelch Open / Talking
        Const SqlClosed As String = "0" 'Squelch Closed / NOT Talking

        Dim ActiveTransmission, RecordingStopped As Boolean
        Dim isXTScanner, isDigitalScanner, isHandHeld, isColor As Boolean




        ActiveTransmission = False
        RecordingStopped = True
        If blnSendBusy = True Then Exit Sub
        strBuff = ""
        strWin = Nothing

        'set scanner properties
        isXTScanner = False
        isDigitalScanner = False
        isHandHeld = False
        isColor = False
        blnNAC = False
        Select Case ScannerModel
            Case "SC230"
                isHandHeld = True
            Case "BC246T"
                isHandHeld = True
            Case "BR330T"
                isHandHeld = True
            Case "BCD396T"
                isHandHeld = True
                isDigitalScanner = True
                '  Case "BCT15"

            Case "BCD996T"
                isDigitalScanner = True
            Case "BCD396XT"
                isDigitalScanner = True
                isHandHeld = True
                isColor = True
                blnNAC = True
                isXTScanner = True
            Case "BC346XT"
                isHandHeld = True
                isXTScanner = True
            Case "BC346XTC"
                isHandHeld = True
                isXTScanner = True
            Case "BCT15X"
                isXTScanner = True
            Case "BCD996XT"
                isDigitalScanner = True
                isColor = True
                blnNAC = True
                isXTScanner = True
            Case "BCD996P2"
                isDigitalScanner = True
                isColor = True
                blnNAC = True
                isXTScanner = True
            Case "BCD325P2"
                isDigitalScanner = True
                isHandHeld = True
                blnNAC = True
                isXTScanner = True
            Case Else
                isXTScanner = False
        End Select


        If strUserCMD = "+VOL" Then 'increase volume

            strBuff = SendCMD("VOL")
            If IsNumeric(strBuff) = True Then 'valid response, increase by one and send back
                SendCMD("VOL," & Val(strBuff) + 1)
                ' LetCMDFinish()
            End If
        ElseIf strUserCMD = "-VOL" Then  'decrease volume

            strBuff = SendCMD("VOL")
            If IsNumeric(strBuff) = True Then 'valid response, increase by one and send back
                SendCMD("VOL," & Val(strBuff) - 1)
                '  LetCMDFinish()
            End If
        ElseIf strUserCMD = "+SQL" Then  'increase squelch

            strBuff = SendCMD("SQL")
            If IsNumeric(strBuff) = True Then 'valid response, increase by one and send back
                SendCMD("SQL," & Val(strBuff) + 1)
                ' LetCMDFinish()
            End If
        ElseIf strUserCMD = "-SQL" Then  'decrease squelch

            strBuff = SendCMD("SQL")
            If IsNumeric(strBuff) = True Then 'valid response, increase by one and send back
                SendCMD("SQL," & Val(strBuff) - 1)
                ' LetCMDFinish()
            End If

        ElseIf strUserCMD = "KEY,!,P" And InStr(strMDL, "396") <> 0 Or InStr(strMDL, "346") <> 0 And strUserCMD = "KEY,!,P" Then
            'change backlight for compatibility with other scanners
            '   strUserCMD = ""
            strBuff = SendCMD("KEY,P,P")
            '  LetCMDFinish()
        ElseIf strUserCMD <> "" Then
            'send the command up
            If strUserCMD = "JPM,SVC_MODE,FRS/GMRS" And isXTScanner And strUserCMD = "JPM,SVC_MODE,FRS/GMRS" Then
                strUserCMD = "JPM,SVC_MODE,FRS/GMRS/MURS"
            End If
            strDisp = SendCMD(strUserCMD)
        End If
        If strUserCMD <> Nothing Then
            strUserCMD = Nothing
            Exit Sub
        End If
        'Dont send out more then one command at a time
        'strMDL = "BCD396T"
        If intCycle = 2 And isHandHeld Then
            intVol = Val(SendCMD("VOL"))
            intSql = Val(SendCMD("SQL"))
        Else
            intVol = Val(strDisplay(42))
            intSql = Val(strDisplay(43))
        End If

        If intCycle = 20 Then
            intCycle = 0
        Else
            intCycle += 1
        End If

        If intCycle = 1 And isHandHeld Then
            intBAV = Val(SendCMD("BAV"))
            sngLastBAV = intBAV
        Else
            intBAV = sngLastBAV
        End If

        If Len(strMDL) > 3 Then
            blnCommsUp = True
        End If

        strDisp = SendCMD("STS")

        If blnRSSI = True Then
            intRSSI = Val(ParaParse(SendCMD("PWR"), 1))
            If intRSSI < 600 Then
                intRSSI = intRSSI * 1.7
            Else
                intRSSI = 1024
            End If
            strDisplay(49) = CStr(intRSSI)
        Else
            strDisplay(49) = CStr(0)
        End If
        intRestartCount = 0
        strRxSta(12) = CStr(intRSSI)

        'if ishandheld and isxt or ishandheld and isdigital or 330
        If isHandHeld And isXTScanner Or isHandHeld And isDigitalScanner Or InStr(strMDL, "BR330") > 0 Then

            strGLG = SendCMD("GLG")
            'break the two variables down

            strDisplay(1) = AsciiOnly(ParaParse(strDisp, 2)) 'l1 display
            strDisplay(2) = AsciiOnly(ParaParse(strDisp, 4)) 'l2 disp
            strDisplay(3) = AsciiOnly(ParaParse(strDisp, 6)) '3
            strDisplay(4) = AsciiOnly(ParaParse(strDisp, 8)) '4
            strDisplay(5) = AsciiOnly(ParaParse(strDisp, 10)) '5
            'detect crypto use
            If InStr(strDisplay(4), "ENC") <> 0 Then 'crypto on
                strDisplay(44) = "1"
            Else
                strDisplay(44) = "0"
            End If

            strDisplay(6) = AsciiOnly(ParaParse(strDisp, 12))
            If Len(strDisplay(6)) = 1 Then strDisplay(6) = ""
            If Len(strDisplay(5)) = 1 Then strDisplay(5) = ""
            strDisplay(7) = AsciiOnly(ParaParse(strDisp, 14))
            strDisplay(8) = AsciiOnly(ParaParse(strDisp, 16)) 'l8 display
            strDisplay(9) = AsciiOnly(ParaParse(strDisp, 3)) 'l1 mode
            strDisplay(10) = ParaParse(strDisp, 5)
            strDisplay(11) = ParaParse(strDisp, 7)
            strDisplay(12) = ParaParse(strDisp, 9)
            strDisplay(13) = ParaParse(strDisp, 11)
            strRxSta(13) = strDisplay(13) 'NAC
            strDisplay(14) = ParaParse(strDisp, 13)
            strDisplay(15) = ParaParse(strDisp, 15) '?
            strDisplay(16) = ParaParse(strDisp, 17) 'l8 mode
            strDisplay(17) = ParaParse(strDisp, 14) 'squelch status
            strDisplay(18) = ParaParse(strDisp, 15) 'mute status
            strDisplay(19) = ParaParse(strDisp, 16) 'battery alert
            strDisplay(24) = ParaParse(strDisp, 1) 'display mode
            strDisplay(20) = ParaParse(strDisp, 17) 'wx alert
            'begin breaking down everything else
            'Line 1 graphics
            strRxSta(8) = strDisplay(18) 'mute status
            strBuff = ParaParse(strDisp, 2)
            If InStr(strBuff, "çéèê") <> 0 Then 'hold icon
                strDisplay(21) = CStr(1)
            Else
                strDisplay(21) = CStr(0)
            End If
            If InStr(strBuff, "¶") <> 0 Then 'SIGNAL STRENTCH
                strDisplay(29) = CStr(1)
            ElseIf InStr(strBuff, "ß") <> 0 Then
                strDisplay(29) = CStr(2)
            ElseIf InStr(strBuff, "®©") <> 0 Then
                strDisplay(29) = CStr(3)
            ElseIf InStr(strBuff, "™´") <> 0 Then
                strDisplay(29) = CStr(4)
            ElseIf InStr(strBuff, "¨≠") <> 0 Then
                strDisplay(29) = CStr(5)
            Else
                strDisplay(29) = CStr(0)
            End If
            If InStr(strBuff, "°¢") <> 0 Then 'PRIORITY GLOBAL
                strDisplay(32) = CStr(1)
            Else
                strDisplay(32) = CStr(0)
            End If
            'function key
            If InStr(strBuff, "ã") <> 0 Then
                strDisplay(28) = CStr(1)
            Else
                strDisplay(28) = CStr(0)
            End If
            If InStr(strBuff, "ïñó") <> 0 Then 'l/O
                strDisplay(27) = CStr(1)
            Else
                strDisplay(27) = CStr(0)
            End If
            'line 3'

            strBuff = ParaParse(strDisp, 6)
            If InStr(strBuff, Chr(129)) <> 0 Then 'up arrow
                strDisplay(25) = CStr(1)
            Else
                strDisplay(25) = CStr(0)
            End If
            If InStr(strBuff, Chr(130)) <> 0 Then 'down arrow
                strDisplay(26) = CStr(1)
            Else
                strDisplay(26) = CStr(0)
            End If
            'line 4'

            strBuff = ParaParse(strDisp, 8)
            If InStr(strBuff, Chr(135) & Chr(136)) <> 0 Then 'close call
                strDisplay(22) = CStr(1)
            Else
                strDisplay(22) = CStr(0)
            End If
            If InStr(strBuff, "£§•") <> 0 Then 'att
                strDisplay(23) = CStr(1)
            Else
                strDisplay(23) = CStr(0)
            End If
            If InStr(strBuff, Chr(161) & Chr(162)) <> 0 Then 'PRIORITY
                strDisplay(30) = CStr(1)
            Else
                strDisplay(30) = CStr(0)
            End If
            If InStr(strBuff, "£§•") <> 0 Then 'att
                strDisplay(23) = CStr(1)
            Else
                strDisplay(23) = CStr(0)
            End If
            If InStr(strBuff, "ùûúö") <> 0 Then 'NFM
                strDisplay(31) = "NFM"
            ElseIf InStr(strBuff, "õúö") <> 0 Then  'FM
                strDisplay(31) = "FM"
            ElseIf InStr(strBuff, "òôö") <> 0 Then  'AM
                strDisplay(31) = "AM"
            ElseIf InStr(strBuff, Chr(159) & Chr(160) & Chr(156) & Chr(154)) <> 0 Then  'WFM
                strDisplay(31) = "WFM"
            Else
                strDisplay(31) = ""
            End If
            If InStr(strBuff, "ëí""") <> 0 Then 'data skip
                strDisplay(36) = CStr(1)
            Else
                strDisplay(36) = CStr(0)
            End If
            'setup GLG status variable
            For intCnt = 1 To 7

                strRxSta(intCnt) = ParaParse(strGLG, intCnt)
            Next intCnt
            strRxSta(9) = ParaParse(strGLG, 9)
            If Len(strRxSta(1)) = 8 And InStr(strRxSta(1), "-") = 0 Then
                If InStr(strRxSta(1), ".") = 0 Then
                    strRxSta(1) = CStr(Val(strRxSta(1)) / 10000)
                End If

                strRxSta(1) = FormatFreq(Val(strRxSta(1)))
            End If
            If blnNAC Then
                strRxSta(10) = ParaParse(strGLG, 12)
            End If
            'should this be commented out??? maybe???
            If Val(strRxSta(9)) = 1 Then
                System.Array.Clear(strRxSta, 0, strRxSta.Length)
            End If


            'battery stuff
            strDisplay(38) = CStr((3.2 * intBAV * 2) / 1023)

            strDisplay(39) = CStr(Int(MakePositive(Val(strDisplay(38)) - 3.2) * 100))
            If Val(strDisplay(39)) > 100 Then strDisplay(39) = CStr(100)
            'apco
            If strMDL = "BCD396T" Or strMDL = "BCD396XT" Or strMDL = "BCD996XT" Then
                strAPCO = SendCMD("P25")
                strDisplay(40) = CStr(Val(ParaParse(strAPCO, 2))) 'apco thres

                strDisplay(41) = CStr(Val(ParaParse(strAPCO, 3))) 'apco err rate
            End If

            'vol and squelch
            strDisplay(42) = CStr(intVol)
            strDisplay(43) = CStr(intSql)
            'TGID expander
            If VB.Left(strDisplay(3), 3) = "ID:" Then
                strBuff = strRxSta(5)
                If strBuff = "" Then 'this is because no system name is reported when the tgid isnt active
                    strBuff = strDisplay(2)
                End If

                strRxSta(7) = XpandTGID(strBuff, strDisplay(3), VB.Right(strDisplay(3), Len(strDisplay(3)) - 3))
                strDisplay(3) = strRxSta(7)
            End If
        ElseIf ScannerModel = "BC246T" Or ScannerModel = "SC230" Then

            strDisplay(18) = (ParaParse(strDisp, 9)) 'mute status

            strRxSta(9) = CStr(Val(ParaParse(strDisp, 8))) 'squelch status
            'setup logging variable
            strRxSta(8) = strDisplay(18)
            strDisplay(3) = AsciiOnly(ParaParse(strDisp, 3))
            'if its muted, then there is no activety to note
            If Val(strRxSta(8)) = 1 Then

                ' System.Array.Clear(strRxSta, 0, strRxSta.Length) 'HUH?????????????????????????
            End If

            'break the two variables down
            strDisplay(1) = ""
            strDisplay(2) = AsciiOnly(ParaParse(strDisp, 1))
            strDisplay(5) = Trans246(ParaParse(strDisp, 5), 0) '5
            strDisplay(4) = ""
            strDisplay(6) = Trans246(ParaParse(strDisp, 6), 1)
            If Len(strDisplay(6)) = 1 Then strDisplay(6) = ""
            If Len(strDisplay(5)) = 1 Then strDisplay(5) = ""
            strDisplay(7) = ""
            strDisplay(8) = "" 'l8 display

            strDisplay(9) = AsciiOnly(ParaParse(strDisp, 2)) 'l1 mode
            strDisplay(10) = ParaParse(strDisp, 4)
            strDisplay(11) = ""
            strDisplay(12) = ""
            strDisplay(13) = ""
            strDisplay(14) = ""
            strDisplay(15) = ""
            strDisplay(16) = "" 'l8 mode
            strDisplay(17) = (ParaParse(strDisp, 8)) 'squelch status
            strDisplay(19) = ParaParse(strDisp, 10) 'battery alert
            strDisplay(24) = "0" 'display mode
            strDisplay(20) = ParaParse(strDisp, 11) 'wx alert
            'begin breaking down everything else
            'Line 1 graphics

            If strDisplay(2) = "Scan Hold       " <> 0 Then 'hold icon
                strDisplay(21) = CStr(1)
            Else
                strDisplay(21) = CStr(0)
            End If
            'SIGNAL STRENTCH
            strDisplay(29) = CStr(0)
            'PRIORITY GLOBAL
            strDisplay(32) = CStr(Val(Mid(ParaParse(strDisp, 5), 13, 1)))
            strDisplay(28) = CStr(Val(Mid(ParaParse(strDisp, 6), 16, 1)))
            strDisplay(27) = CStr(Val(Mid(ParaParse(strDisp, 6), 15, 1)))
            'line 3'

            strBuff = ParaParse(strDisp, 6)
            'up arrow
            strDisplay(22) = CStr(0)
            'down arrow
            strDisplay(26) = CStr(0)
            'line 4'

            strBuff = ParaParse(strDisp, 8)
            'close call
            strDisplay(22) = CStr(Val(Mid(ParaParse(strDisp, 6), 17, 1)))

            'att
            strDisplay(23) = CStr(Val(Mid(ParaParse(strDisp, 5), 12, 1)))

            'PRIORITY
            strDisplay(30) = strDisplay(32)

            If InStr(strBuff, "ùûúö") <> 0 Then 'NFM
                strDisplay(31) = "NFM"
            ElseIf InStr(strBuff, "õúö") <> 0 Then  'FM
                strDisplay(31) = "FM"
            ElseIf InStr(strBuff, "òôö") <> 0 Then  'AM
                strDisplay(31) = "AM"
            ElseIf InStr(strBuff, Chr(159) & Chr(160) & Chr(156) & Chr(154)) <> 0 Then  'WFM
                strDisplay(31) = "WFM"
            Else
                strDisplay(31) = ""
            End If
            If InStr(strBuff, "ëí""") <> 0 Then 'data skip
                strDisplay(36) = CStr(1)
            Else
                strDisplay(36) = CStr(0)
            End If

            'battery stuff

            strDisplay(38) = CStr((5.22 * intBAV) / 255)

            strDisplay(39) = CStr(Int(MakePositive(CDbl(strDisplay(38)) - 2.2) * 100))

            strDisplay(39) = MakePositive(strDisplay(39))
            If Val(strDisplay(39)) > 100 Then strDisplay(39) = CStr(100)
            'apco
            strDisplay(40) = CStr(0) 'apco thres
            strDisplay(41) = CStr(0) 'apco err rate
            'vol and squelch
            strDisplay(42) = CStr(intVol)
            strDisplay(43) = CStr(intSql)
            ' If ActiveTransmission Then 'is there an active channel
            'is it trunked?
            If strMDL = "SC230" Then 'GID command not available on SC230
                strGLG = ",,,,,"
            Else

                strGLG = SendCMD("GID")
            End If
            If strGLG <> ",,,,," Then
                strRxSta(1) = ParaParse(strGLG, 2) 'freq/tgid
                strRxSta(2) = "Auto" 'modmode
                strRxSta(3) = "0" 'att
                strRxSta(4) = "0" 'CTCSS
                strRxSta(5) = ParaParse(strGLG, 4) 'system name
                strRxSta(6) = ParaParse(strGLG, 5) 'group name
                strRxSta(7) = ParaParse(strGLG, 6) 'channel name
                If strRxSta(5) = "" Then strRxSta(5) = strDisplay(2)
                'TGID expansion
                'strRxSta(7) = XpandTGID(strRxSta(5), strRxSta(7), strRxSta(1))
                strDisplay(3) = strRxSta(7)
            Else 'conventional system
                strWin = SendCMD("WIN")
                strRxSta(1) = FormatFreq(Val(ParaParse(strWin, 2)) / 10000) ' & "MHz"
                strRxSta(2) = "Auto" 'modmode
                strRxSta(3) = "0" 'att
                strRxSta(4) = "0" 'CTCSS
                strRxSta(5) = "Conventional" 'system name
                strRxSta(6) = "Group" 'group name
                strRxSta(7) = strDisplay(3) 'freq/tgid 'freq/tgid 'channel name
            End If
            'Else

            ' System.Array.Clear(strRxSta, 0, strRxSta.Length)
            ' End If

            ''//////END 246 / 230
            '        ElseIf strMDL = "BCD996T" Or strMDL = "BCT15" Or strMDL = "UBCD996T" Or strMDL = "UBCT15" Or strMDL = "BCD996XT" Or strMDL = "BCT15X" Then

        ElseIf Not isHandHeld Then
            strDisp = SendCMD("STS")

            strGLG = SendCMD("GLG")
            'break the two variables down
            strDisplay(1) = AsciiOnly(ParaParse(strDisp, 2)) 'l1 display
            strDisplay(2) = AsciiOnly(ParaParse(strDisp, 4)) 'l2 disp
            strDisplay(3) = AsciiOnly(ParaParse(strDisp, 6)) '3
            strDisplay(4) = (ParaParse(strDisp, 8)) '4
            strDisplay(5) = AsciiOnly(ParaParse(strDisp, 10)) '5
            strDisplay(6) = AsciiOnly(ParaParse(strDisp, 12))
            If Len(strDisplay(6)) = 1 Then strDisplay(6) = ""
            If Len(strDisplay(5)) = 1 Then strDisplay(5) = ""

            strDisplay(7) = AsciiOnly(ParaParse(strDisp, 14))

            strDisplay(8) = AsciiOnly(ParaParse(strDisp, 16)) 'l8 display\
            'MAKE SOME PRETTY GRAPHICS FOR TRUNKED SYSTEMS
            If Len(strDisplay(4)) = 16 Then
                strDisplay(4) = Replace(strDisplay(4), Chr(180), "_")
                strDisplay(4) = Replace(strDisplay(4), Chr(174), "+")
                strDisplay(4) = Replace(strDisplay(4), "?", "_")
            End If
            'detect crypto use
            If InStr(strDisplay(4), "ENC") <> 0 Then 'crypto on
                strDisplay(44) = "1"
            Else
                strDisplay(44) = "0"
            End If

            strDisplay(4) = AsciiOnly(strDisplay(4))
            strDisplay(9) = AsciiOnly(ParaParse(strDisp, 3)) 'l1 mode
            strDisplay(10) = ParaParse(strDisp, 5)
            strDisplay(11) = ParaParse(strDisp, 7)
            strDisplay(12) = ParaParse(strDisp, 9)
            strDisplay(13) = ParaParse(strDisp, 11)
            strRxSta(13) = strDisplay(13) 'NAC
            strDisplay(14) = ParaParse(strDisp, 13)
            strDisplay(15) = ParaParse(strDisp, 15) '?
            strDisplay(16) = ParaParse(strDisp, 17) 'l8 mode
            strDisplay(17) = ParaParse(strDisp, 14) 'squelch status
            strDisplay(18) = ParaParse(strDisp, 15) '
            strDisplay(19) = CStr(0) 'battery alert
            strDisplay(24) = ParaParse(strDisp, 1) 'display mode
            strDisplay(20) = ParaParse(strDisp, 17) 'wx alert
            'begin breaking down everything else
            'Line 1 graphics
            strRxSta(8) = strDisplay(18) 'mute status
            strBuff = ParaParse(strDisp, 2)
            If InStr(strBuff, "çéèê") <> 0 Then 'hold icon
                strDisplay(21) = CStr(1)
            Else
                strDisplay(21) = CStr(0)
            End If
            'SIGNAL STRENTCH

            strDisplay(29) = CStr(Val(ParaParse(strDisp, 20)))
            'LEDs

            If ParaParse(strDisp, 19) = "1" Then 'alert LED
                strDisplay(46) = "1"
            Else
                strDisplay(46) = "0"
            End If

            If ParaParse(strDisp, 18) = "1" Then 'Close Call LED
                strDisplay(45) = "1"
            Else
                strDisplay(45) = "0"
            End If
            If InStr(strBuff, "°¢") <> 0 Then 'PRIORITY GLOBAL
                strDisplay(32) = CStr(1)
            Else
                strDisplay(32) = CStr(0)
            End If
            'function key
            If InStr(strBuff, "ã") <> 0 Then
                strDisplay(28) = CStr(1)
            Else
                strDisplay(28) = CStr(0)
            End If
            If InStr(strBuff, "ïñó") <> 0 Then 'l/O
                strDisplay(27) = CStr(1)
            Else
                strDisplay(27) = CStr(0)
            End If
            'line 3'

            strBuff = ParaParse(strDisp, 6)
            If InStr(strBuff, Chr(129)) <> 0 Then 'up arrow
                strDisplay(25) = CStr(1)
            Else
                strDisplay(25) = CStr(0)
            End If
            If InStr(strBuff, Chr(130)) <> 0 Then 'down arrow
                strDisplay(26) = CStr(1)
            Else
                strDisplay(26) = CStr(0)
            End If
            'line 4'

            strBuff = ParaParse(strDisp, 8)
            If InStr(strBuff, Chr(135) & Chr(136)) <> 0 Then 'close call
                strDisplay(22) = CStr(1)
            Else
                strDisplay(22) = CStr(0)
            End If
            If InStr(strBuff, "£§•") <> 0 Then 'att
                strDisplay(23) = CStr(1)
            Else
                strDisplay(23) = CStr(0)
            End If
            If InStr(strBuff, Chr(161) & Chr(162)) <> 0 Then 'PRIORITY
                strDisplay(30) = CStr(1)
            Else
                strDisplay(30) = CStr(0)
            End If
            If InStr(strBuff, "£§•") <> 0 Then 'att
                strDisplay(23) = CStr(1)
            Else
                strDisplay(23) = CStr(0)
            End If
            If InStr(strBuff, "ùûúö") <> 0 Then 'NFM
                strDisplay(31) = "NFM"
            ElseIf InStr(strBuff, "õúö") <> 0 Then  'FM
                strDisplay(31) = "FM"
            ElseIf InStr(strBuff, "òôö") <> 0 Then  'AM
                strDisplay(31) = "AM"
            ElseIf InStr(strBuff, Chr(159) & Chr(160) & Chr(156) & Chr(154)) <> 0 Then  'WFM
                strDisplay(31) = "WFM"
            Else
                strDisplay(31) = ""
            End If
            If InStr(strBuff, "ëí""") <> 0 Then 'data skip
                strDisplay(36) = CStr(1)
            Else
                strDisplay(36) = CStr(0)
            End If
            'setup GLG status variable
            For intCnt = 1 To 7
                strRxSta(intCnt) = ParaParse(strGLG, intCnt)
            Next intCnt

            strRxSta(9) = ParaParse(strGLG, 9)
            'NAC 
            If blnNAC Then
                strRxSta(10) = ParaParse(strGLG, 12)
            End If
            If Val(strRxSta(9)) = 1 Then

                '  System.Array.Clear(strRxSta, 0, strRxSta.Length)
            End If
            If Len(strGLG) > 8 Then
                strWin = strWin
            End If

            'battery stuff
            strDisplay(38) = CStr(12)
            strDisplay(39) = CStr(100)
            'apco
            If InStr(strMDL, "996") <> 0 And strDisplay(18) = "0" Then

                strAPCO = SendCMD("P25")
                strDisplay(40) = CStr(Val(ParaParse(strAPCO, 2))) 'apco thres
                strDisplay(41) = CStr(Val(ParaParse(strAPCO, 3))) 'apco err rate
            Else
                strDisplay(40) = 0
                strDisplay(41) = 0
            End If

            'vol and squelch
            strDisplay(42) = CStr(intVol)
            strDisplay(43) = CStr(intSql)

        End If
        '//////////////// END 996T TEXT PROCESSING ////////////////////////////////
        If strRxSta(8) = MuteInactive And strDisplay(17) = SqlOpen Then
            ActiveTransmission = True
            LastSqlState = True
            'is there a tone active? if there record it for search
            If strRxSta(4) <> "0" And strRxSta(4) <> "" Then
                LastCTCSSFound = strRxSta(4)
            End If
        Else
            ActiveTransmission = False
            'If the squelch has now turned off, then reset the recording timeout/counter
            bRecTimeout = False
            LastSqlState = False
            sngScanTime = 0

        End If

        'TGID expander
        If Val(strRxSta(1)) > 0 And Val(strRxSta(1)) < 1 Then
            strBuff = CStr(Val(strBuff) * 10000)
        End If
        If VB.Left(strDisplay(3), 3) = "ID:" And strRxSta(6) = "" And 1 = 0 Then
            strBuff = strRxSta(5)
            If strBuff = "" Then 'this is because no system name is reported when the tgid isnt active
                strBuff = strDisplay(2)
            End If

            strRxSta(7) = XpandTGID(strBuff, strDisplay(3), VB.Right(strDisplay(3), Len(strDisplay(3)) - 3))
            strDisplay(3) = strRxSta(7)
        End If

        'Negative delay
        tmrNegDelay.Enabled = blnNegDelay

        'Finally all the recording stuff
        'Is there already a recording in progress? should we stop?

        'This is used to add some hang time before ending the file and starting another one
        If Not ActiveTransmission Then
            CycleCntRst += 1
        Else
            CycleCntRst = 0
        End If
        If CycleCntRst = 11 Then CycleCntRst = 0

        'Do some cleanup for unknown ID
        If strRxSta(7) = "" And ActiveTransmission Then
            strRxSta(7) = "ID:" & strRxSta(1)
        End If



        If blnEnableLog = True Then        'Radio logging
            If strRxSta(9) = "" Then
                GotID = False
            End If

            'Hack for CTCSS tone, if nothing then put in a 0, or else the radio puts in a 0 by itself later
            If strRxSta(4) = "" Or strRxSta(4) = Nothing Then
                strRxSta(4) = "0"
            End If
            Dim sName As String
            If InStr(strDisplay(3), "UID:") <> 0 Then

                If InStr(strDisplay(3), "UID:") <> 0 And GotID = False And strRxSta(5) <> "" Then ' a radio ID is found, process it
                    strBuff = Replace(strDisplay(3), "UID:", Nothing)
                    strBuff = Trim(strBuff)
                    strRxSta(11) = strBuff
                    GotID = True
                    Call frmLog.LogRadioID(strBuff, strRxSta(1), strRxSta(5), strRxSta(6), strRxSta(7))
                End If
                sName = strDisplay(3)

            Else

                If InStr(strDisplay(4), "UID:") <> 0 And GotID = False And strRxSta(5) <> "" Then ' a radio ID is found, process it
                    strBuff = Replace(strDisplay(4), "UID:", Nothing)
                    strBuff = Trim(strBuff)
                    strRxSta(11) = strBuff
                    GotID = True
                    Call frmLog.LogRadioID(strBuff, strRxSta(1), strRxSta(5), strRxSta(6), strRxSta(7))

                End If
                sName = strDisplay(3)
            End If


            'make sure transmission is active, state hasnt change, and channel data is available
            Dim VoiceFileName As String = frmRecord.FinalMP3Name
            If ActiveTransmission And Not LastActiveTrans And strRxSta(1) <> "" Then
                'A new transmission has started since last time, so add a new line
                Call UpdateLog(sName, True)
                LastActiveTrans = True
            ElseIf Not ActiveTransmission And LastActiveTrans Then
                'The transmission has ended, so close up the last log entry
                strRxSta(4) = LastCTCSSFound
            LastActiveTrans = False
            LastCTCSSFound = "0"
            End If

        End If


        '''''''''''''''recording FILE CONTROL
        If frmRecord.waveInStream IsNot Nothing And Not ActiveTransmission And CycleCntRst >= frmRecord.iHangTime Then
            'If there is a recording in process,, AND they have stopped talking, and we have exceeded the hang time, end the file
            'End the recording, and start a new file
            Call frmRecord.StopRec()
            strRecLog(intLogPos, 15) = frmRecord.FinalMP3Name
            Call UpdateLog(Nothing, False)
            frmRecord.FinalMP3Name = Nothing
            'Should we start recording a new file?
        ElseIf frmRecord.waveInStream Is Nothing And ActiveTransmission And Not bRecTimeout And GetSetting("FreeSCAN", "Settings", "RecOn") = "1" Then

            'Validate the recording device still exists
            intCnt = frmRecord.GetMaxDevID

            If frmRecord.RecDevID > intCnt Then 'if the device doesn't exist anymore, abort recording
                frmRecord.DisableRec()
                MsgBox("FreeSCAN has disabled recording due to the sound device no longer being available.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            NumHits += 1
            LastWavMade = System.IO.Path.GetTempFileName
            Call frmRecord.StartRec(LastWavMade, frmRecord.RecDevID)
            If IsNothing(frmRecord.FinalMP3Name) Then
                frmRecord.FinalMP3Name = frmRecord.GenFileName
            End If
        End If


            'Automatic logging
            'This automatically clears & writes the log
            'Conditions: 23:59 Local time, log save date not the same, logging auto save selected on
            If frmLog.SaveClearAtMidnightToolStripMenuItem.Checked And Format(DateTime.Now, "HH:m") = "23:59" _
                And sLogSaveDate <> Format(DateTime.Now, "M/d/yy") Then
                'Save the log file and clear it
                sLogSaveDate = Format(DateTime.Now, "M/d/yy")
                frmLog.SaveFileDialog2.FileName = GenLogFileName()

                Call frmLog.SaveFileDialog2_FileOk(Nothing, Nothing)
                Call ClearLog()
                ReDim frmLog.RadioID(1, 7)
                frmLog.SaveFileDialog2.FileName = Nothing
                frmLog.Text = frmLog.sDefaultCaption
            End If



            '///// SPEECH SYNTEHSIS STUFF
            If LastTag <> strRxSta(7) And strRxSta(7) <> Nothing And ActiveTransmission And chkSpeech.Checked Then
                Dim t As New System.Threading.Thread(AddressOf SpeechSynth)
                LastTag = strRxSta(7)
                t.Start()


            End If
            DrawDisplay()

    End Sub
    Sub SpeechSynth(toSay As String)
        If VoiceOutput.State = SynthesizerState.Speaking Then
            Exit Sub
        End If
        VoiceOutput.SetOutputToDefaultAudioDevice()

        VoiceOutput.Rate = 2
        VoiceOutput.Speak(LastTag)

    End Sub
    Function GenLogFileName() As String
        'This generates a log file name ready to be fed back to saving it to disk
        Try
            Dim sBuff1 As String
            Dim intCnt As Integer = 0
            Dim sDirName As String = "\"
            Dim sDate As String = Format(Date.Now, "d")
            Dim bFailDir As Boolean = False
            Dim RecDirName As String = GetSetting("FreeSCAN", "Settings", "LogFileDir", My.Computer.FileSystem.SpecialDirectories.MyDocuments)
            Dim sFileName As String = GetSetting("FreeSCAN", "Settings", "RecFile", frmRecord.RecDefaultName)
            Dim sCleanDate As String = Format(Date.Now, "Short Date")

            sDate = Replace(sDate, "/", "-")
            sDirName &= sDate

            sCleanDate = MakeItKosherFileName(sCleanDate, False)
            'See if the date is specified, otherwise add it
            If InStr(sFileName, "%date%", CompareMethod.Text) = 0 Then
                sFileName &= " " & sCleanDate
            End If


            sFileName = Replace(sFileName, "%system%", Nothing, , , CompareMethod.Text)
            sFileName = Replace(sFileName, "%site%", Nothing, , , CompareMethod.Text)
            sFileName = Replace(sFileName, "%name%", Nothing, , , CompareMethod.Text)
            sFileName = Replace(sFileName, "%chan%", Nothing, , , CompareMethod.Text)
            sFileName = Replace(sFileName, "%date%", sCleanDate, , , CompareMethod.Text)
            sFileName = Replace(sFileName, "%time%", Format(DateTime.Now, "HH-mm"), , , CompareMethod.Text)
            sFileName = Replace(sFileName, "%hit%", Nothing, , , CompareMethod.Text)
            sFileName = Replace(sFileName, "%nac%", Nothing, , , CompareMethod.Text)
            sFileName = Replace(sFileName, "%uid%", Nothing, , , CompareMethod.Text)
            sFileName = Replace(sFileName, "%rssi%", Nothing, , , CompareMethod.Text)

            sFileName = MakeItKosherFileName(sFileName, False)

            sFileName = "FreeSCAN Autosave Log - " & sCleanDate
            sFileName = RecDirName & "\" & sFileName
            'Finally, make sure this file doesn't already exist
            If FileExists(sFileName & DefaultLogExt) Then
                'Add a numerical notation to the file
                sBuff1 = sFileName & " (" & CStr(intCnt) & ")"
                Do Until FileExists(sBuff1 & DefaultLogExt) = False Or intCnt = 9999
                    sBuff1 = sFileName & " (" & CStr(intCnt) & ")"
                    intCnt += 1
                Loop
                sFileName = sBuff1
            End If
            sFileName &= DefaultLogExt
            GenLogFileName = sFileName
        Catch ex As Exception
            frmLog.SaveClearAtMidnightToolStripMenuItem.Checked = False
            GenLogFileName = Nothing
            MsgBox("Unable to autosave log. " & ex.Message, vbCritical)
        End Try
    End Function

    Sub UpdateLog(ByVal RadioID As String, ByRef StartNew As Boolean)
        If blnDebug = False Then On Error Resume Next
        Dim intCnt As Integer

        Dim strBuff As String
        Dim blnDateStamp As Boolean
        Dim datStart, datEnd As Date

        If Not StartNew Then
            'write the termination time/date of the last entry, we have been called to terminate the last one
            If intLogPos <> 0 And intLastRecID <> intLogPos Then
                datEnd = TimeOfDay
                datStart = CDate(strRecLog(intLogPos, 8))
                strBuff = Format(System.DateTime.FromOADate(datEnd.ToOADate - datStart.ToOADate), "HH:mm:ss")
                strRecLog(intLogPos, 10) = strBuff
                'get the ctccss tone as well
                strRecLog(intLogPos, 4) = strRxSta(4)
                intLastRecID = intLogPos
                frmLog.DrawGridRow((intLogPos))


            End If
        ElseIf StartNew Then 'add it to the log
            AddToLog()
            blnDateStamp = False
            frmLog.DrawGridRow((intLogPos))
        End If
    End Sub
    Sub AddToLog()
        Dim intParam, intBuff, intCnt, intNumRec As Integer
        Dim strTemp(1, 1) As String
        If blnDebug = False Then On Error Resume Next
        'adds a new entry to the log
        intLogPos += 1
        If intLogPos >= 31800 Then

            intLogPos = 1
        End If
        intBuff = UBound(strRecLog)
        If intBuff <= intLogPos Then 'expand the variable
            'redim preserve cannot be used on multi dimensional arrays
            ReDim strTemp(intBuff, MaxRecLogFields)
            For intCnt = 0 To intBuff
                For intParam = 0 To MaxRecLogFields
                    strTemp(intCnt, intParam) = strRecLog(intCnt, intParam)
                Next intParam
            Next intCnt
            ReDim strRecLog(intBuff + 1000, MaxRecLogFields)
            For intCnt = 0 To intBuff
                For intParam = 0 To MaxRecLogFields
                    strRecLog(intCnt, intParam) = strTemp(intCnt, intParam)
                Next intParam
            Next intCnt
        End If
        For intBuff = 1 To 7
            strRecLog(intLogPos, intBuff) = strRxSta(intBuff)
        Next intBuff
        strRecLog(intLogPos, 8) = CStr(TimeOfDay)
        strRecLog(intLogPos, 9) = CStr(Today)
        strRecLog(intLogPos, 13) = strRxSta(10) 'nac
        strRecLog(intLogPos, 14) = strRxSta(11) 'Radio ID
        strRxSta(11) = Nothing
        If Val(strDisplay(49)) > 0 Then 'rssi
            strRecLog(intLogPos, 12) = strDisplay(49)
        Else
            strRecLog(intLogPos, 12) = strDisplay(29)
        End If
        strRecLog(intLogPos, 11) = CStr(DateDiff(Microsoft.VisualBasic.DateInterval.Second, DateSerial(1970, 1, 1), Now)) 'save unix time for easy processing

    End Sub

    Function Trans246(ByRef intStr As String, ByRef intMode As String) As String
        'Convert Icon Mode 1 from a 246 into a text string
        Dim strBuff As String
        Dim BlinkOn As Boolean
        Dim intCnt As Integer
        strBuff = Nothing
        If intCycle / 2 = Int(intCycle / 2) Then
            BlinkOn = True
        Else
            BlinkOn = False
        End If
        If Len(intStr) = 15 Then

            If VB.Left(intStr, 1) = "1" Then

                If intMode = 0 Then
                    strBuff = strBuff & "S0:"
                Else
                    strBuff = strBuff & "G0:"
                End If
            End If
            For intCnt = 1 To 10

                If Mid(intStr, intCnt + 1, 1) = "1" Then
                    If intCnt <> 10 Then
                        strBuff = strBuff & intCnt
                    Else
                        strBuff = strBuff & "0"
                    End If

                ElseIf Mid(intStr, intCnt, 1) = "2" Then
                    If BlinkOn = True Then
                        If intCnt <> 10 Then
                            strBuff = strBuff & intCnt
                        Else
                            strBuff = strBuff & "0"
                        End If
                    Else
                        strBuff = strBuff & "-"
                    End If
                Else
                    strBuff = strBuff & "-"
                End If
            Next intCnt
        ElseIf Len(intStr) = 17 Then

            If VB.Left(intStr, 1) = "1" Then
                strBuff = strBuff & "G0:"
            End If
            For intCnt = 1 To 10

                If Mid(intStr, intCnt + 1, 1) = "1" Then
                    If intCnt <> 10 Then
                        strBuff = strBuff & intCnt
                    Else
                        strBuff = strBuff & "0"
                    End If

                ElseIf Mid(intStr, intCnt, 1) = "2" Then
                    If BlinkOn = True Then
                        If intCnt <> 10 Then
                            strBuff = strBuff & intCnt
                        Else
                            strBuff = strBuff & "0"
                        End If
                    Else
                        strBuff = strBuff & "-"
                    End If
                Else
                    strBuff = strBuff & "-"
                End If
            Next intCnt
        Else

            strBuff = ""
        End If

        Trans246 = strBuff
    End Function
    Function XpandTGID(ByRef strSysname As String, ByRef strTGIDName As String, ByRef strTGID As String) As String
        'Takes in current system name, group name, tgid name, and tgid
        'does a lookup in memory of the tgid name and returns whats stored in memory
        'if available
        If blnDebug = False Then On Error Resume Next
        Dim intGrp, intSys, intTGID As Integer
        Dim strMemName As String
        Dim strBuff1, strBuff, strbuff2 As String
        Dim blnFound As Boolean
        Dim intCnt As Integer
        Dim intGrpCnt As Integer

        strSysname = Trim(strSysname)


        strTGIDName = Trim(strTGIDName)

        strTGID = Trim(strTGID)
        blnFound = False
        'now that we have the group ID's , we need to search each one to find the appropiate TGiD, if its there
        intTGID = Val(strTGIDidx(0, 0))

        If intTGID > 0 And strTGID <> "" Then

            For intCnt = 1 To intTGID
                strBuff = UCase(strTGIDidx(intCnt, 0))


                If strBuff = UCase(strSysname) And strTGIDidx(intCnt, 1) = strTGID Then
                    'If strTGIDidx(intCnt, 1) = strTGID Then
                    XpandTGID = strTGIDidx(intCnt, 2)
                    Exit Function
                End If
            Next intCnt
        End If
        'no tgid could be found

        If strTGIDName = "" Then


            XpandTGID = "ID:" & strTGID
        Else


            XpandTGID = strTGIDName
        End If
    End Function


    Private Sub tmrNegDelay_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrNegDelay.Tick
        'this is the time to make negative delay work
        If Timer_Renamed.Enabled = False Then
            tmrNegDelay.Enabled = False
            Exit Sub
        End If
        If Form1.msc.IsOpen = False Then
            Exit Sub
        End If
        'This disable negative delay if we are on hold
        If strDisplay(21) = "1" Then
            sngScanTime = 0
            Exit Sub
        End If
        sngScanTime = sngScanTime + (tmrNegDelay.Interval / 1000)
        If sngScanTime >= sngMaxScanTime And sngScanTime > 1 Then
            sngScanTime = 0
            strUserCMD = "KEY,>,P"
        End If
    End Sub

    Private Sub cmdShowRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowRec.Click
        frmRecord.SetupRec()
        frmRecord.Visible = True
    End Sub

    Private Sub chkServer_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        networkserver.Visible = True
    End Sub
End Class