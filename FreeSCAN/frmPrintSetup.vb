Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.IO
Friend Class frmPrintSetup
	Inherits System.Windows.Forms.Form
    Dim strColDatType(20, 1) As String 'this stores each field assignment for each column, 0=conv
    Dim intNumConvCol, intNumTGIDCol As Integer
	Dim strFontName As String
	Dim intFontSize As Integer
	Dim blnFontItalic As Boolean
	Dim blnFontBold, blnFontUl As Boolean
    Dim strKillFile As String
    Dim SkipChildSelect As Boolean
    'Printing Variables

    'Control Tracking
    Dim strSummary As String


	
    Sub cmdCheckAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCheckAll.Click
        Dim lngNode As Integer, ParentNode, ChildNode As TreeNode
        Dim intChildNode As Integer
        For lngNode = 0 To treeSystems.Nodes.Count - 1
            ParentNode = treeSystems.Nodes.Item(lngNode)
            If ParentNode.Checked = False Then
                ParentNode.Checked = True
            End If
            For intChildNode = 0 To ParentNode.Nodes.Count - 1
                ChildNode = ParentNode.Nodes.Item(intChildNode)
                If ChildNode.Checked = False Then
                    ChildNode.Checked = True
                End If
            Next
        Next lngNode
    End Sub
	
	Private Sub cmdClearAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearAll.Click
        Dim lngNode As Integer, ParentNode, ChildNode As TreeNode
        Dim intChildNode As Integer
        For lngNode = 0 To treeSystems.Nodes.Count - 1
            ParentNode = treeSystems.Nodes.Item(lngNode)
            If ParentNode.Checked = True Then
                ParentNode.Checked = False
            End If
            For intChildNode = 0 To ParentNode.Nodes.Count - 1
                ChildNode = ParentNode.Nodes.Item(intChildNode)
                If ChildNode.Checked = True Then
                    ChildNode.Checked = False
                End If
            Next
        Next lngNode
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
        lblSiteNote.Visible = True
        Me.Visible = False
        Try
            If FileExists(strKillFile) And strKillFile <> "" Then
                My.Computer.FileSystem.DeleteFile(strKillFile)
            End If
        Catch
            'meh thats just too bad
        End Try
        strKillFile = ""
    End Sub
    Sub initForm()
        'initialize the form prior to display to user
        If blnDebug = False Then On Error Resume Next
        Dim cnt As Integer, strPrnName As String
        Dim cnt1 As Integer

        cmdRecallDEfault_Click(cmdRecallDEfault, New System.EventArgs())
        UpdateList()
        UpdateFieldSelection()

    End Sub


    Private Sub cmdFontChoose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFontChoose.Click
        With FontDialog1
            .Font = VB6.FontChangeName(.Font, strFontName)
            .Font = VB6.FontChangeBold(.Font, blnFontBold)
            .Font = VB6.FontChangeItalic(.Font, blnFontItalic)
            .Font = VB6.FontChangeUnderline(.Font, blnFontUl)
            .Font = VB6.FontChangeSize(.Font, intFontSize)
            .ShowDialog()
            strFontName = .Font.Name
            blnFontBold = .Font.Bold
            blnFontItalic = .Font.Italic
            blnFontUl = .Font.Underline
            intFontSize = .Font.Size
        End With

    End Sub
    Sub GenPrintBuff()
        If Not blnDebug Then On Error Resume Next
        Dim intSystem, intSysCnt, intGrpCnt, intGroup As Integer
        Dim intNodeCnt As Integer
        Dim strBuff, strBuff1 As String
        Dim intCnt, intCnt1 As Integer
        Dim intNode, intChildNode As Integer
        Dim strNodeKey As String
        Dim blnFirstPage As Boolean
        Dim intStart, intEnd As Integer
        Dim blnDone As Boolean
        Dim intChanDone, intChanPerPage As Integer()
        Dim intNumLine, intLineDone As Integer
        Dim strPage As String
        Dim strExtraTags As String = Nothing
        Dim WebFontSize As Integer
        Dim TempDir As String
        Dim intFile As Integer
        Dim objStreamWriter As StreamWriter
        Dim ShellCode As String
        blnAbortOp = False
        Me.UseWaitCursor = True
        Call UpdateFieldSelection()
        prerender.DocumentText = Nothing
        intNodeCnt = treeSystems.Nodes.Count

        'Now begin the primary loop to start adding things to the buffer
        strPage = "<html><head><meta http-equiv=$QUOTE$Content-Type$QUOTE$ content=$QUOTE$text/html; charset=windows-1252$QUOTE$><title>"
        strPage &= StripName(strCurrFile) & "</title></head><body>" & FontTag() & vbCr

        If blnFontItalic Then
            strPage &= "<i>"
            strExtraTags = "</i>"
        End If
        If blnFontUl Then
            strPage &= "<u>"
            strExtraTags = "</u>"
        End If
        If chkPrintQKSummary.Checked Then
            strPage &= GenCard()
        End If
        If chkPrintSummary.Checked Then
            strPage &= "<br><b><p align=$QUOTE$center$QUOTE$><i>System Summary<br><br></b></i></p>"
            For intNode = 0 To intNodeCnt - 1
                If treeSystems.Nodes(intNode).Checked Then
                    'this node will be going to the printer
                    'what kind of node is this?
                    strNodeKey = treeSystems.Nodes(intNode).Tag
                    strPage &= "<br>"
                    If Len(strNodeKey) = 5 Then
                        'a system node
                        intSystem = Val(Strings.Right(strNodeKey, 4))
                        If varSite(intSystem, 0, 0, 4) <> "" And varSite(intSystem, 0, 0, 4) <> "." Then 'add quickey
                            strPage &= "[" & varSite(intSystem, 0, 0, 4) & "] "
                        End If
                        strPage &= Trim(varSite(intSystem, 0, 0, 1))
                        strPage &= "<br>"
                        For intChildNode = 0 To treeSystems.Nodes.Item(intNode).Nodes.Count - 1
                            strNodeKey = treeSystems.Nodes.Item(intNode).Nodes.Item(intChildNode).Tag
                            'either a site or a group, dont matter  which kind
                            'get sys num
                            strBuff = Strings.Left(strNodeKey, 5)
                            strBuff = Strings.Right(strBuff, 4)
                            intSystem = Val(strBuff)
                            'get group num
                            strBuff = Strings.Right(strNodeKey, 4)
                            intGroup = Val(strBuff)
                            strPage &= Chr(9)
                            If varSite(intSystem, intGroup, 0, 2) <> "" And varSite(intSystem, intGroup, 0, 2) <> "." Then 'add quickkey
                                strPage &= "[" & varSite(intSystem, intGroup, 0, 2) & "] "
                            End If
                            strPage &= Trim(varSite(intSystem, intGroup, 0, 1))
                            strPage &= "<br>"
                        Next intChildNode
                    End If

                End If
                If blnAbortOp = True Then
                    intNode = intNodeCnt
                End If
            Next intNode
        End If


        If chkPrintSys.Checked Then
            For intNode = 0 To intNodeCnt - 1
                If treeSystems.Nodes.Item(intNode).Checked Then
                    'this node will be going to the printer
                    'what kind of node is this?
                    strNodeKey = treeSystems.Nodes.Item(intNode).Tag
                    'a system node
                    'either conventional or trunked, find out which one
                    intSystem = Val(VB.Right(strNodeKey, 4))
                    intCnt = CInt(varSite(intSystem, 0, 0, 3))
                    If intCnt = 1 Then 'a conventional system
                        strPage &= PrintConvSys((intSystem))
                    ElseIf intCnt > 1 Then
                        strPage &= PrintTrunkSys((intSystem))
                    End If
                    For intChildNode = 0 To treeSystems.Nodes.Item(intNode).Nodes.Count - 1
                        strNodeKey = treeSystems.Nodes.Item(intNode).Nodes.Item(intChildNode).Tag
                        'either a site or a group, find out which kind
                        'get sys num
                        If treeSystems.Nodes.Item(intNode).Nodes.Item(intChildNode).Checked Then
                            strBuff = VB.Left(strNodeKey, 5)
                            strBuff = VB.Right(strBuff, 4)
                            intSystem = Val(strBuff)
                            'get group num
                            strBuff = VB.Right(strNodeKey, 4)
                            intGroup = Val(strBuff)
                            If intSystem > 0 And intGroup > 0 Then
                                Select Case Val(varSite(intSystem, intGroup, 0, 5))
                                    Case 1 'conv group
                                        strPage &= PrintConvGroup(intSystem, intGroup)
                                    Case 2 'trunk group
                                        strPage &= PrintTGIDGroup(intSystem, intGroup)
                                    Case 3 'trunk site
                                        strPage &= PrintTrunkSite(intSystem, intGroup)
                                End Select
                            End If
                        End If
                    Next
                End If
                If blnAbortOp = True Then
                    intNode = intNodeCnt
                    Exit For
                End If
            Next intNode
        End If
        strPage &= strExtraTags
        strPage &= "</f></head></body>"
        strPage = Replace(strPage, "$QUOTE$", Chr(34))
        strPage = Replace(strPage, Chr(9), "&nbsp;&nbsp;&nbsp;")


        'DUMP CONTENTS TO HTML
        TempDir = GetTempFileName() & ".html"
        'prerender.DocumentText = strPage
        intFile = FreeFile()
        objStreamWriter = New StreamWriter(TempDir)
        objStreamWriter.WriteLine(strPage)
        objStreamWriter.Close()
        '
        prerender.Url = New Uri("file://" & TempDir)
        prerender.ResumeLayout()
        strKillFile = TempDir
        ' If FileExists(TempDir) Then My.Computer.FileSystem.DeleteFile(TempDir)

        '
        My.Application.DoEvents()

TerminateSub:
        'Terminal Sub routine gracefully
        Me.UseWaitCursor = False
        Call FormWait(0, 0, 0)
    End Sub

    Private Sub cmdPreview_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPreview.Click
        GenPrintBuff()
        My.Application.DoEvents()
        prerender.ShowPrintPreviewDialog()
    End Sub

    Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        If blnDebug = False Then On Error Resume Next
        'print stuff out
        'this is going to get COMPLICATED
        Dim intSystem, intSysCnt, intGrpCnt, intGroup As Integer
        Dim intNodeCnt As Integer
        Dim strBuff, strBuff1 As String
        Dim intCnt, intCnt1 As Integer
        Dim intNode As Integer
        Dim strNodeKey As String
        Dim blnFirstPage As Boolean
        Dim intStart, intEnd As Integer

        'printer setup
        'first loop through and make sure the user has actually selected something that they wanted to print

        intNodeCnt = treeSystems.Nodes.Count

        If intNodeCnt = 0 Then
            cmdRedrawTree_Click(cmdRedrawTree, New System.EventArgs())

            intNodeCnt = treeSystems.Nodes.Count

            If intNodeCnt = 0 Then
                MsgBox("There is nothing to print.")
                GoTo TerminateSub
            End If
        End If

        For intNode = 0 To intNodeCnt - 1
            System.Windows.Forms.Application.DoEvents()
            If treeSystems.Nodes.Item(intNode).Checked = True Then
                strNodeKey = treeSystems.Nodes.Item(intNode).Tag
                If Len(strNodeKey) = 5 Then
                    intSysCnt = intSysCnt + 1
                ElseIf Len(strNodeKey) = 10 Then
                    intGrpCnt = intGrpCnt + 1
                End If
            End If
        Next intNode
        If intSysCnt = 0 And intGrpCnt = 0 Then
            MsgBox("No systems have been selected for printing. Select some, and try again.")
            GoTo TerminateSub
        End If
        'Generate the print buffer, so there is something to print

        cmdPrint.Enabled = False
        GenPrintBuff()
        My.Application.DoEvents()
        cmdPrint.Enabled = True
        prerender.ShowPrintDialog()
        If blnDebug = False Then
            lblSiteNote.Visible = True
            Me.Visible = False
        Else
            Me.Visible = True
        End If
TerminateSub:

    End Sub


    Function PrintConvSys(ByRef intSystem As Integer) As String
        'prints out conventional system paramters
        Dim strBuff As String = Nothing
        strBuff = "<br><b><u>" & varSite(intSystem, 0, 0, 1) & " (Conventional System) </u><br>"
        strBuff &= "Quick Key: </b>" & MakeItNice(varSite(intSystem, 0, 0, 4), 0) & "<br>" 'quick key                
        strBuff &= "<b>Startup Key: </b>" & MakeItNice(varSite(intSystem, 0, 0, 7), 0) & "<br>" ' 'startup key
        strBuff &= "<b>Lock Out: </b>" & MakeOnOff(varSite(intSystem, 0, 0, 2)) & "<br>" ''l/o
        strBuff &= "<b>Data Skip: </b>" & MakeOnOff(varSite(intSystem, 0, 0, 9)) & "<br><b>" ''data skip
        'tape out
        Select Case Val(varSite(intSystem, 0, 0, 24))
            Case 0
                strBuff &= "Tape Out: </b>Off<br>"
            Case 1
                strBuff &= "Tape Out: </b>Marked Only<br>"
            Case 2
                strBuff &= "Tape Out: </b>All Channels<br>"
        End Select
        strBuff &= "<b>GPS Enabled: </b>" & MakeOnOff(varSite(intSystem, 0, 0, 22)) & "<br>" '
        strBuff &= "<b>GPS Range: </b>" & Val(varSite(intSystem, 0, 0, 21)) & " Miles" & "<br>" '
        strBuff &= "<b>Longtitude: </b>" & FormatDMS(varSite(intSystem, 0, 0, 20)) & "<br>" ' 'longtitude               
        strBuff &= "<b>Latitude: </b>" & FormatDMS(varSite(intSystem, 0, 0, 19)) & "<br><br><br>" ''latitude

        'apco mode? meh
        PrintConvSys = strBuff
    End Function

    Function MakeItNice(ByRef strParam As String, ByRef intType As Integer) As String
        'takes a radio input and makes it look like something presentable
        MakeItNice = ""
        Select Case intType
            Case 0 'Quick Key               
                If strParam = "." Or strParam = "" Then
                    MakeItNice = "None"
                Else
                    MakeItNice = strParam
                End If
            Case 1
                If strParam = "0" Then 'this needs to be double checked
                    MakeItNice = "ID Scan"
                Else
                    MakeItNice = "ID Search"
                End If
            Case 2
                If strParam = "1" Then
                    MakeItNice = "AFS"
                Else
                    MakeItNice = "Decimal"
                End If
            Case 3 'for alert tone type
                If Val(strParam) = 0 Then
                    MakeItNice = "Off"
                Else
                    MakeItNice = strParam
                End If
            Case 4 'alert volume

                If Val(strParam) = 0 Then

                    MakeItNice = "Auto"
                Else
                    MakeItNice = strParam
                End If
        End Select
    End Function
    Function PrintTrunkSys(ByRef intSystem As Integer) As String
        'prints out trunk system paramters
        Dim strSysType As String
        Dim strBuff As String

        strSysType = SysType(Val(varSite(intSystem, 0, 0, 3)), 0)
        strBuff = "<br><b></u>" & varSite(intSystem, 0, 0, 1) & " (" & strSysType & " System)</b></u><br>"
        strBuff &= "<b>Format: </b>" & MakeItNice(varSite(intSystem, 0, 0, 14), 2) & "<br>" 'afs/dec               
        strBuff &= "<b>Startup Key: </b>" & MakeItNice(varSite(intSystem, 0, 0, 7), 0) & "<br>" 'startup key               
        strBuff &= "<b>I-CALL: </b>" & MakeOnOff(varSite(intSystem, 0, 0, 15)) & "<br>" 'i-call               
        strBuff &= "<b>Search/Scan: </b>" & MakeItNice(varSite(intSystem, 0, 0, 11), 1) & "<br>" 'search/scan        
        If Val(varSite(intSystem, 0, 0, 16)) < 16 Then
            strBuff &= "<b>Fleet Map #: </b>" & Val(varSite(intSystem, 0, 0, 16)) + 1 & "<br>"
        Else
            strBuff &= "<b>Fleet Map #: Custom</b>" & "<br>"
        End If
        strBuff &= "<b>Emergency Alert Level:</b> " & Val(varSite(intSystem, 0, 0, 25)) & "<br>"
        strBuff &= "<b>Emergency Alert Type: </b>" & Val(varSite(intSystem, 0, 0, 26)) & "<br>"
        'tape out

        Select Case Val(varSite(intSystem, 0, 0, 24))
            Case 0
                strBuff &= "<b>Tape Out: </b>Off" & "<br>"
            Case 1
                strBuff &= "<b>Tape Out: </b>Marked Only" & "<br>"
            Case 2
                strBuff &= "<b>Tape Out: </b>All Channels" & "<br>" & "<br>"
        End Select
        PrintTrunkSys = strBuff
    End Function
    Function PrintConvGroup(ByRef intSystem As Integer, ByRef intGroup As Integer) As String
        'prints out conventional group paramters
        Dim strBuff As String
        'setup contents of label
        strBuff = "<b><u>" & varSite(intSystem, intGroup, 0, 1) & " (Conventional Group)" & "</u><br>"
        strBuff &= "Quick Key: </b>" & MakeItNice(varSite(intSystem, intGroup, 0, 2), 0) & "<br>" 'quick key
        strBuff &= "<b>Lock Out: </b>" & MakeOnOff(varSite(intSystem, intGroup, 0, 3)) & "<br>"  'l/o
        'eventually add gps stuff
        strBuff &= PrintChannelGrid(intSystem, intGroup)
        PrintConvGroup = strBuff
    End Function

    Function PrintChannelGrid(ByRef intSystem As Integer, ByRef intGroup As Integer) As String
        Dim intChan, intTotChan, intNumCol As Integer
        Dim intCnt As Integer, blnConv As Boolean
        Dim strGID As String, strBuff, strData(1, 1) As String
        Dim intCol, intRow As Integer
        Dim ChanMatrix(3000) As Integer
        strBuff = Nothing
        'how many channels need to be printed?
        PrintChannelGrid = Nothing
        intTotChan = 0
        intNumCol = 0
        If varSite(intSystem, 0, 0, 3) = "1" Then
            blnConv = True
            For intCnt = 0 To 20
                If strColDatType(intCnt, 0) <> "0" And strColDatType(intCnt, 0) <> "" Then
                    intNumCol += 1
                End If
            Next
        Else
            blnConv = False
            For intCnt = 0 To 20
                If strColDatType(intCnt, 1) <> "0" And strColDatType(intCnt, 1) <> "" Then
                    intNumCol += 1
                End If
            Next
        End If


        strGID = varSite(intSystem, intGroup, 0, 10)
        For intCnt = 1 To MaxChan
            If ChanInfo(intCnt, 10) = strGID Then
                ChanMatrix(intTotChan) = intCnt
                intTotChan = intTotChan + 1
            End If
        Next intCnt
        ReDim strData(intTotChan, intNumCol)
        'Fill up the strdata variable with what we want
        For intCol = 0 To intNumCol - 1
            If blnConv Then 'draw headings for conventional group
                strBuff = ""
                Select Case strColDatType(intCol, 0)
                    Case 1 'conv chan name
                        strBuff = "Display"
                    Case 2 'frequency
                        strBuff = "Frequency"
                    Case 3 'record on off
                        strBuff = "Rec"
                    Case 4 ' modmode
                        strBuff = "Modulation"
                    Case 5 'lockout
                        strBuff = "L/O"
                    Case 6 ' attenuation
                        strBuff = "Att"
                    Case 7 ' priority
                        strBuff = "Pri"
                    Case 8 'alert tone type
                        strBuff = "Alt Tone"
                    Case 9 'ctcss/dcs mode
                        strBuff = "Tone"
                    Case 11 'tone lockout
                        strBuff = "Tone L/O"
                    Case 12 'audio type
                        strBuff = "Audio Type"
                    Case 13 'alert level
                        strBuff = "Alt Level"
                    Case 14 'comment
                        strBuff = "Comment"
                    Case 15 'p25 nac
                        strBuff = "NAC"
                    Case 16 'number tag
                        strBuff = "Num Tag"
                    Case 17 'light col
                        strBuff = "Colour"
                    Case 18 'light pat
                        strBuff = "Light Pat"
                    Case 19 'step size
                        strBuff = "Step Size"
                    Case 20 'volume offset
                        strBuff = "Vol Offset"
                End Select
            Else
                'insert code for generating TGID header
                Select Case strColDatType(intCol, 1)
                    Case 1 'conv chan name
                        strBuff = "Display"
                    Case 2 'frequency
                        strBuff = "TGID"
                    Case 3 'lockout
                        strBuff = "L/O"
                    Case 4 'alert tone type
                        strBuff = "Alt Tone"
                    Case 5 'alert level
                        strBuff = "Alt Level"
                    Case 6 'audio type
                        strBuff = "Audio Type"
                    Case 7 'record on off
                        strBuff = "Rec"
                    Case 8 ' priority
                        strBuff = "Pri"
                    Case 14 'comment
                        strBuff = "Comment"
                    Case 19 'number tag
                        strBuff = "Num Tag"
                    Case 20 'light col
                        strBuff = "Colour"
                    Case 21 'light pat
                        strBuff = "Light Pat"
                    Case 22 'volume offset
                        strBuff = "Vol Offset"
                End Select

            End If
            strData(0, intCol) = strBuff
        Next
        'Columns are done, move onto actualy channel data
        For intRow = 1 To intTotChan
            intChan = ChanMatrix(intRow - 1)
            For intCol = 0 To intNumCol - 1
                If blnConv Then
                    Select Case strColDatType(intCol, 0)
                        Case 1 'conv chan name
                            strBuff = ChanInfo(intChan, 1)
                        Case 2 'frequency
                            strBuff = FormatFreq(ChanInfo(intChan, 2))
                        Case 3 'record on off
                            strBuff = MakeOnOff(ChanInfo(intChan, 3))
                        Case 4 ' modmode
                            strBuff = ModMode(Val(ChanInfo(intChan, 4)))
                        Case 5 'lockout
                            strBuff = MakeOnOff(ChanInfo(intChan, 5))
                        Case 6 ' attenuation
                            strBuff = MakeOnOff(ChanInfo(intChan, 6))
                        Case 7 ' priority
                            strBuff = MakeOnOff(ChanInfo(intChan, 7))
                        Case 8 'alert tone type
                            strBuff = MakeItNice(ChanInfo(intChan, 8), 3)
                        Case 9 'ctcss/dcs mode
                            strBuff = CTCSS(Val(ChanInfo(intChan, 9)))
                        Case 11 'tone lockout
                            strBuff = MakeOnOff(ChanInfo(intChan, 11))
                        Case 12 'audio type
                            Select Case Val(ChanInfo(intChan, 12))
                                Case 0
                                    strBuff = "All"
                                Case 1
                                    strBuff = "Analog"
                                Case 2
                                    strBuff = "Digital"
                            End Select
                        Case 13 'alert level
                            strBuff = MakeItNice(ChanInfo(intChan, 13), 4)
                        Case 14 'comment
                            strBuff = ChanInfo(intChan, 14)
                        Case 15 'p25 nac
                            strBuff = ChanInfo(intChan, 15)
                        Case 16 'number tag
                            strBuff = ChanInfo(intChan, 16)
                        Case 17 'light col
                            strBuff = ChanInfo(intChan, 17)
                        Case 18 'light pat
                            Select Case ChanInfo(intChan, 18)
                                Case "0"
                                    strBuff = "On"
                                Case "1"
                                    strBuff = "Slow"
                                Case Else
                                    strBuff = "Fast"
                            End Select
                        Case 19 'step size
                            strBuff = StepSize(Val(ChanInfo(intChan, 19)), 1)

                        Case 20 'volume offset
                            strBuff = ChanInfo(intChan, 20)
                    End Select

                Else 'generate information for a TGID       
                    Select Case strColDatType(intCol, 1)
                        Case CStr(1) 'name
                            strBuff = ChanInfo(intChan, 1)
                        Case CStr(2) 'tgid
                            strBuff = ChanInfo(intChan, 2)
                        Case CStr(3) 'lockout
                            strBuff = MakeOnOff(ChanInfo(intChan, 3))
                        Case CStr(4) 'Alert Tone
                            strBuff = MakeItNice(ChanInfo(intChan, 4), 3)
                        Case CStr(5) 'Alert Level
                            strBuff = MakeItNice(ChanInfo(intChan, 5), 4)
                        Case CStr(6) 'audio type
                            Select Case Val(ChanInfo(intChan, 6))
                                Case 0
                                    strBuff = "All"
                                Case 1
                                    strBuff = "Analog"
                                Case 2
                                    strBuff = "Digital"
                            End Select
                        Case CStr(7) 'tape out
                            strBuff = MakeOnOff(ChanInfo(intChan, 7))
                        Case "8" 'rpi
                            strBuff = MakeOnOff(ChanInfo(intChan, 8))
                        Case "14" 'comment
                            strBuff = ChanInfo(intChan, 14)
                        Case "19" 'num tag
                            strBuff = ChanInfo(intChan, 19)
                        Case "20" 'alert color
                            strBuff = ChanInfo(intChan, 20)
                        Case "21" ' alert pat
                            Select Case ChanInfo(intChan, 21)
                                Case "0"
                                    strBuff = "On"
                                Case "1"
                                    strBuff = "Slow"
                                Case Else
                                    strBuff = "Fast"
                            End Select
                        Case "22" 'vol offset
                            strBuff = ChanInfo(intChan, 22)

                    End Select
                End If
                strData(intRow, intCol) = strBuff
            Next
        Next
        intCnt = (MakePositive((intNumCol - 1) * 50)) + 120 + (intNumCol * intFontSize)
        PrintChannelGrid = GenHTMLTable(intNumCol, intTotChan, strData, intCnt, 1)
    End Function

    Function PrintTGIDGroup(ByRef intSystem As Integer, ByRef intGroup As Integer) As String
        'prints out conventional group paramters

        Dim strBuff As String

        strBuff = "<br><b><u>" & varSite(intSystem, intGroup, 0, 1) & " (TGID Group)<br></b></u>"
        strBuff &= "<b>Quick Key: </b>" & MakeItNice(varSite(intSystem, intGroup, 0, 2), 0) & "<br>" 'quick key
        strBuff &= "<b>Lock Out: </b>" & MakeOnOff(varSite(intSystem, intGroup, 0, 3)) & "<br><br>" 'l/o
        strBuff &= PrintChannelGrid(intSystem, intGroup)
        PrintTGIDGroup = strBuff
    End Function
    Function PrintTrunkSite(ByRef intSystem As Integer, ByRef intSite As Integer) As String
        'prints out trunk site paramters
        Dim sngCnt, sngCnt1 As Single
        Dim strSysType As String
        Dim intNumChan, intCnt, intLine As Integer
        Dim strGID As String
        Dim strBuff As String
        Dim strData(1, 1) As String
        Dim TrunkArray(1, 1) As String
        strSysType = SiteType(Val(varSite(intSystem, intSite, 0, 9)), 0)

        'setup contents of label
        strBuff = "<br><b><u>" & varSite(intSystem, intSite, 0, 1) & " (" & strSysType & " Trunk Site) <br></b></u>"
        strBuff &= "<b>Quick Key: </b>" & MakeItNice(varSite(intSystem, intSite, 0, 2), 0) & "<br>" 'quick key
        strBuff &= "<b>Control Chan Only: </b>" & MakeOnOff(varSite(intSystem, intSite, 0, 8)) & "<br>"  'control chan only
        strBuff &= "<b>Lock Out: </b>" & MakeOnOff(varSite(intSystem, intSite, 0, 3)) & "<br>" 'l/o
        strBuff &= "<b>Attenuation: </b>" & MakeOnOff(varSite(intSystem, intSite, 0, 7)) & "<br>" 'attenuation
        strBuff &= "<b>Hold Time: </b>" & Val(varSite(intSystem, intSite, 0, 4)) & "<br>"
        strBuff &= "<b>Startup Key: </b>" & MakeItNice(varSite(intSystem, intSite, 0, 12), 0) & "<br>" 'startup key
        'tape out

        Select Case Val(varSite(intSystem, 0, 0, 24))
            Case 0
                strBuff &= "<b>Tape Out: </b>Off" & "<br>"
            Case 1
                strBuff &= "<b>Tape Out: </b>Marked Only" & "<br>"
            Case 2
                strBuff &= "<b>Tape Out: </b>All Channels" & "<br>"
        End Select
        strBuff &= "<b>GPS Enabled: </b>" & MakeOnOff(varSite(intSystem, intSite, 0, 16)) & "<br>"
        strBuff &= "<b>GPS Range: </b>" & Val(varSite(intSystem, intSite, 0, 15)) & " Miles / " & Val(varSite(intSystem, intSite, 0, 15)) * 1.60934 & " KMs" & "<br>"
        strBuff &= "<b>Longtitude: </b>" & FormatDMS(varSite(intSystem, intSite, 0, 14)) & "<br>" 'longtitude
        strBuff &= "Latitude: </b>" & FormatDMS(varSite(intSystem, intSite, 0, 13)) & "<br>" 'latitude

        'Motorola band plan
        If varSite(intSystem, intSite, 0, 9) = "4" Then
            'print MBP`
            strBuff &= "<b>Motorola VHF/UHF Band Plan</b>" & "<br>"

        ElseIf varSite(intSystem, intSite, 0, 9) = "6" And chkTrunk.CheckState = 1 Then  'apco 25
            'determine if there is anything to print at all
            sngCnt1 = 0
            For sngCnt = 30 To 62 Step 2


                If Val(varSite(intSystem, intSite, 0, sngCnt)) <> 0 Then
                    sngCnt1 = 1
                End If
            Next sngCnt
            If sngCnt1 = 1 Then
                'create a APCO 25 band plan printout
                strBuff &= "<b>APCO P25 Band Plan</b>" & "<br>"

            End If
        End If

        'find out if there are any trunking frequencies associated with this site


        strGID = varSite(intSystem, intSite, 0, 10)
        intNumChan = 0
        For intCnt = 1 To MaxTrunkFreq
            If strTrunkFreq(intCnt, 2) = strGID Then
                intNumChan = intNumChan + 1
            End If
        Next intCnt

        If intNumChan > 0 And chkTrunk.CheckState = 1 Then
            'print out trunk frequencies
            'how much room is going to be needed?
            If intNumChan / 2 = Int(intNumChan / 2) Then 'determine num of rows needed
                intCnt = intNumChan / 2
            Else
                intCnt = (intNumChan / 2) + 1
            End If
            If intNumChan = 1 Then intCnt = 1
            ReDim TrunkArray(intNumChan + 1, 7)
            strBuff &= "<b>Trunk Frequencies</b>" & "<br>"
            ReDim strData(intNumChan + 1, 7)
            strData(0, 0) = "Freq"
            strData(0, 1) = "LCN"
            strData(0, 2) = "Num Tag"
            strData(0, 3) = "Vol Offset"
            strData(0, 4) = "Freq"
            strData(0, 5) = "LCN"
            strData(0, 6) = "Num Tag"
            strData(0, 7) = "Vol Offset"
            intNumChan = 0
            For intCnt = 1 To MaxTrunkFreq
                If strTrunkFreq(intCnt, 2) = strGID Then
                    intNumChan += 1
                    TrunkArray(intNumChan, 0) = FormatFreq(strTrunkFreq(intCnt, 0))
                    TrunkArray(intNumChan, 1) = strTrunkFreq(intCnt, 1)
                    TrunkArray(intNumChan, 2) = strTrunkFreq(intCnt, 4)
                    TrunkArray(intNumChan, 3) = strTrunkFreq(intCnt, 5)
                End If
            Next intCnt
            intLine = 0
            If intNumChan / 2 <> Int(intNumChan / 2) Then
                intNumChan += 1
            End If
            For intCnt = 1 To intNumChan Step 2
                intLine += 1
                strData(intLine, 0) = FormatFreq(TrunkArray(intCnt, 0))
                strData(intLine, 1) = TrunkArray(intCnt, 1)
                strData(intLine, 2) = TrunkArray(intCnt, 4)
                strData(intLine, 3) = TrunkArray(intCnt, 5)
                If TrunkArray(intCnt + 1, 0) <> "" Then
                    strData(intLine, 4) = FormatFreq(TrunkArray(intCnt + 1, 0))
                    strData(intLine, 5) = TrunkArray(intCnt + 1, 1)
                    strData(intLine, 6) = TrunkArray(intCnt + 1, 4)
                    strData(intLine, 7) = TrunkArray(intCnt + 1, 5)
                End If
            Next intCnt
            strBuff &= GenHTMLTable(8, intNumChan / 2, strData, 600, 1)
            strBuff &= "<br><br>"
        ElseIf chkTrunk.CheckState = 1 Then
            strBuff &= "No trunk frequencies associated with above site" & "<br>"

        End If
        PrintTrunkSite = strBuff & vbCr
        System.Array.Clear(TrunkArray, 0, TrunkArray.Length)
    End Function

    Sub cmdRecallDEfault_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRecallDEfault.Click
        If blnDebug = False Then On Error Resume Next
        'loads layout settings from the registry                     
        Dim strColSet() As String
        Dim intCnt, intColWidth As Integer
        Dim strBuff As String
        Dim intBuff As Integer


        'setup for fonts
        blnFontBold = CBool(GetSetting("FreeSCAN", "Settings", "FontBold", "False"))
        strFontName = GetSetting("FreeSCAN", "Settings", "Font", "MS Sans Serif")
        intFontSize = Val(GetSetting("FreeSCAN", "Settings", "FontSize", "8"))
        blnFontUl = CBool(GetSetting("FreeSCAN", "Settings", "FontUL", "False"))
        blnFontItalic = CBool(GetSetting("FreeSCAN", "Settings", "FontItalic", "False"))

        chkTrunk.CheckState = Val(GetSetting("FreeSCAN", "Settings", "chkTrunk", "1"))



        'conventional settings
        strBuff = CStr(Val(GetSetting("FreeSCAN", "Settings", "ConvColCnt", CStr(6))))

        strBuff = GetSetting("FreeSCAN", "Settings", "ConvField", "1#2#3#5#12#6#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0")
        strColSet = Split(strBuff, "#")
        'apply column field settings
        If UBound(strColSet) = 20 Then
            For intCnt = 0 To 20
                strColDatType(intCnt, 0) = CStr(Val(strColSet(intCnt)))
            Next intCnt
        End If

        'trunk settings
        strBuff = CStr(Val(GetSetting("FreeSCAN", "Settings", "TrunkColCnt", CStr(3))))

        strBuff = GetSetting("FreeSCAN", "Settings", "TrunkField", "1#2#3#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0")
        strColSet = Split(strBuff, "#")
        'apply column field settings
        If UBound(strColSet) = 20 Then
            For intCnt = 0 To 20
                strColDatType(intCnt, 1) = CStr(Val(strColSet(intCnt)))
            Next intCnt
        End If
        ApplyListSelection()

    End Sub

    Private Sub cmdRedrawTree_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRedrawTree.Click
        UpdateList()
    End Sub

    Private Sub cmdResetDefaykt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdResetDefaykt.Click
        If blnDebug = False Then On Error Resume Next
        'automaticly sets layout paramaters
        Dim intCnt As Integer
        'setup font
        blnFontBold = False
        strFontName = "MS Sans Serif"
        intFontSize = 8
        blnFontUl = False
        blnFontItalic = False


        strColDatType(0, 0) = CStr(1) 'name
        strColDatType(1, 0) = CStr(2) 'freq
        strColDatType(2, 0) = CStr(3) 'tone
        strColDatType(3, 0) = CStr(5) 'modulation
        strColDatType(4, 0) = CStr(12) 'audio type
        strColDatType(5, 0) = CStr(6) 'lockout
        strColDatType(0, 1) = CStr(1) 'name
        strColDatType(1, 1) = CStr(2) 'tgid
        strColDatType(2, 1) = CStr(3) 'lockout
        chkTrunk.CheckState = System.Windows.Forms.CheckState.Checked

        ApplyListSelection()
    End Sub

    Private Sub cmdSaveDefaultLayout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSaveDefaultLayout.Click
        If blnDebug = False Then On Error Resume Next
        'save the current settings to the registry
        Call UpdateFieldSelection()
        'font settings
        SaveSetting("FreeSCAN", "Settings", "FontBold", CStr(blnFontBold))
        SaveSetting("FreeSCAN", "Settings", "Font", strFontName)
        SaveSetting("FreeSCAN", "Settings", "FontSize", CStr(intFontSize))
        SaveSetting("FreeSCAN", "Settings", "FontUL", CStr(blnFontUl))
        SaveSetting("FreeSCAN", "Settings", "FontItalic", CStr(blnFontItalic))
        'SaveSetting("FreeSCAN", "Settings", "chkCentre", CStr(chkCentre.CheckState))
        SaveSetting("FreeSCAN", "Settings", "chkTrunk", CStr(chkTrunk.CheckState))
        'SaveSetting("FreeSCAN", "Settings", "chkPageNum", CStr(chkPageNum.CheckState))



        Dim strColSet(20) As String, strBUff As String = ""
        Dim intCnt, intColWidth As Integer

        'conventional settings
        For intCnt = 0 To 20

            strColSet(intCnt) = strColDatType(intCnt, 0)
        Next intCnt
        SaveSetting("FreeSCAN", "Settings", "ConvField", Join(strColSet, "#"))
        'Save the state of the list boxes
        For intCnt = 0 To lstConv.Items.Count - 1
            strBUff &= lstConv.GetItemCheckState(intCnt)
        Next
        SaveSetting("FreeSCAN", "Settings", "ConvFieldList", strBUff)
        strBUff = Nothing
        For intCnt = 0 To lstTGID.Items.Count - 1
            strBUff &= lstTGID.GetItemCheckState(intCnt)
        Next
        SaveSetting("FreeSCAN", "Settings", "TGIDFieldList", strBUff)

        intCnt = MsgBox("Settings saved. These will be loaded by default next time.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information)
        Me.Activate()
    End Sub

    Private Sub cmdSetupPrinter_Click()
        CommonDialogPrint.ShowDialog()
        CommonDialogFont.MaxSize = CommonDialogPrint.PrinterSettings.MaximumPage
        CommonDialogFont.MinSize = CommonDialogPrint.PrinterSettings.MinimumPage
    End Sub

    Sub ApplyListSelection()
        If blnDebug Then On Error Resume Next
        'Applies data from strCOlDat to the two checklists
        Dim intCnt As Integer, blnCheckState As Boolean
        Dim strBuff As String
        strBuff = GetSetting("FreeSCAN", "Settings", "ConvFieldList", "11100000000000000")
        For intCnt = 0 To lstConv.Items.Count - 1
            blnCheckState = MakeBoolean(OldMid(strBuff, intCnt + 1, 1))
            lstConv.SetItemChecked(intCnt, blnCheckState)
        Next
        strBuff = GetSetting("FreeSCAN", "Settings", "TGIDFieldList", "11100000000000000")
        For intCnt = 0 To lstTGID.Items.Count - 1
            blnCheckState = MakeBoolean(OldMid(strBuff, intCnt + 1, 1))
            lstTGID.SetItemChecked(intCnt, blnCheckState)
        Next
    End Sub
    Sub updatelist()
        If blnDebug = False Then On Error Resume Next
        'Draws a map of the system on the tree
        Dim CSite, CGroup As Integer
        Dim x, Gname As Integer
        Dim GroupNodeIndex, TreeKey As String
        Dim strMySite, strMyGroup As String
        Dim noditem As TreeNode, intUpdate As Integer
        Dim blnQuickDraw As Boolean
        Dim intSysCnt, intSysDrawn As Integer
        Dim intSysIndex As Integer = 0
        Dim intNodeIndex, intGrp As Integer
        Dim intGroupNodeIndex As Integer
        Dim SysOrder(MaxSystems, 4) As String ' 0=Index, 1=Name, 2=QK, 3=Type (short string MOT2)
        Dim SortMode As String
        Dim GrpOrder(MaxGroups, 4) As String  ' 0=Index, 1=Name, 2=QK, 3=Type (short string MOT2)'4=how many groups/sites
        Dim intGrpIndex As Integer = 0
        Dim intGrpCnt As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ' Call FormWait(0, 100, 1)
        'treeSystems.Sorted = False
        treeSystems.Nodes.Clear()
        treeSystems.Sorted = False
        intNodeIndex = -1
        intSysCnt = -1
        treeSystems.BeginUpdate()

        'otherwise display systems
        'search entire memory
        'setup for quickdraw
        If lblSiteNote.mnuQuickDrawAUto.Checked = True Then
            'are there more than 30 sites? if so then turn quick draw off
            blnQuickDraw = False
            For x = 1 To MaxSystems
                If Val(varSite(x, 0, 0, 3)) > 0 Then
                    intUpdate += 1
                End If

                If intUpdate = 40 Then
                    blnQuickDraw = True
                    Exit For
                End If
            Next x
            intUpdate = 0
        ElseIf lblSiteNote.mnuQuickDrawOff.Checked = True Then
            blnQuickDraw = False
        Else
            blnQuickDraw = True
        End If
        'determine how many systems need to be drawn
        SortMode = GetSetting("FreeSCAN", "Settings", "SortOrder", "0")
        SysOrder = lblSiteNote.GetSysArray(SortMode)
        intSysCnt = Val(SysOrder(0, 4))
        'INITIAL DRAW AND DESTROY - WORK AROUND FOR BUG IN MS TREE
        If intSysCnt > 0 Then
            noditem = treeSystems.Nodes.Add("INIT")
            noditem = treeSystems.Nodes(0).Nodes.Add("INIT")
            treeSystems.EndUpdate()
            My.Application.DoEvents()
            treeSystems.Nodes.Clear()
            treeSystems.BeginUpdate()
        End If

        For x = 0 To intSysCnt
            'Begin drawing the tree for that site
            intSysIndex = Val(SysOrder(x, 0))
            TreeKey = "S" & Format(intSysIndex, "0000") 'Key for first site would be S0001
            intNodeIndex += 1
            noditem = treeSystems.Nodes.Add(SysKey(intSysIndex))
            treeSystems.Nodes(intNodeIndex).Tag = TreeKey
            'HIGHLIGHT l/o systems
            If Val(varSite(intSysIndex, 0, 0, 2)) = 1 Then
                treeSystems.Nodes(intNodeIndex).ForeColor = Color.Red
            Else
                '    treeSystems.Nodes(intNodeIndex).ForeColor = color.black
            End If
            'trunk system highlighting
            If lblSiteNote.mnuHighlightTrunkSys.Checked Then
                If varSite(intSysIndex, 0, 0, 3) <> "1" Then
                    treeSystems.Nodes(intNodeIndex).BackColor = Color.LightBlue
                End If
            End If
            intSysDrawn += 1
            'expand root
            'find out if there are any groups inside
            intGroupNodeIndex = -1
            GrpOrder = lblSiteNote.GetGroupArray(intSysIndex, SortMode)
            For intGrp = 0 To Val(GrpOrder(0, 4)) 'loop through all possible groups and display them onscreen
                CGroup = GrpOrder(intGrp, 0) 'mem index for the group/site
                If intCurrentSys = intSysIndex Then
                    strMySite = TreeKey
                End If

                GroupNodeIndex = TreeKey & "G" & Format(CGroup, "0000") ' group keys will be S0001G0001
                If intCurrentSys = intSysIndex And intCurrentGroup = CGroup Then
                    strMyGroup = GroupNodeIndex
                End If
                treeSystems.Nodes(intNodeIndex).Nodes.Add(SiteKey(intSysIndex, CGroup))
                intGroupNodeIndex += 1
                treeSystems.Nodes(intNodeIndex).Nodes(intGroupNodeIndex).Tag = GroupNodeIndex
                With treeSystems.Nodes(intNodeIndex).Nodes(intGroupNodeIndex)

                    'site highlighting
                    If lblSiteNote.mnuHighlightSite.Checked Then
                        If Val(varSite(intSysIndex, CGroup, 0, 5)) = 3 Then
                            .BackColor = Color.Yellow
                        End If
                    End If
                    'group highlighting
                    If lblSiteNote.mnuGroupHighlight.Checked Then
                        If Val(varSite(intSysIndex, 0, 0, 3)) > 1 And Val(varSite(intSysIndex, CGroup, 0, 5)) = 2 Then
                            .BackColor = Color.LightGreen
                        End If
                    End If
                    'lockout highlighting
                    If Val(varSite(intSysIndex, CGroup, 0, 3)) = 1 Then
                        .ForeColor = Color.Red
                    End If
                End With
            Next intGrp



        Next x
        If blnQuickDraw = False Then
            treeSystems.ExpandAll()
        End If

        treeSystems.EndUpdate()

        Me.Cursor = System.Windows.Forms.Cursors.Default
        treeSystems.EndUpdate()
        Call cmdCheckAll_Click(Nothing, Nothing)
    End Sub
    Sub UpdateListOLD()
        'draws a list of systems in the tree
        If blnDebug = False Then On Error Resume Next
        'Draws a map of the system on the tree
        Dim CSite, CGroup As Integer
        Dim x, Gname As Integer
        Dim GroupNodeIndex, TreeKey As String
        Dim strMySite, strMyGroup As String
        Dim noditem As TreeNode, intUpdate As Integer
        Dim blnQuickDraw As Boolean
        Dim intSysCnt, intSysDrawn As Integer
        Dim intNodeIndex As Integer
        Dim intGroupNodeIndex As Integer
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ' Call FormWait(0, 100, 1)
        'treeSystems.Sorted = False
        treeSystems.Nodes.Clear()
        treeSystems.Sorted = False
        intNodeIndex = -1
        treeSystems.BeginUpdate()

        If Val(RadioSetting(20)) = 0 Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Call FormWait(0, 1, 0)
        End If

        'otherwise display systems
        'search entire memory
        'setup for quickdraw
        If lblSiteNote.mnuQuickDrawAUto.Checked = True Then
            'are there more than 30 sites? if so then turn quick draw off
            blnQuickDraw = False
            For x = 1 To MaxSystems
                If Val(varSite(x, 0, 0, 3)) > 0 Then
                    intUpdate = intUpdate + 1
                End If

                If intUpdate = 40 Then
                    blnQuickDraw = True
                    x = MaxSystems
                End If
            Next x
            intUpdate = 0
        ElseIf lblSiteNote.mnuQuickDrawOff.Checked = True Then
            blnQuickDraw = False
        Else
            blnQuickDraw = True
        End If
        'determine how many systems need to be drawn
        'this will make for smoother scrolling in the wait dialog
        For x = 1 To MaxSystems
            If Val(varSite(x, 0, 0, 3)) <> 0 Then
                intSysCnt = intSysCnt + 1
            End If
        Next x
        'INITIAL DRAW AND DESTROY - WORK AROUND FOR BUG IN MS TREE
        If intSysCnt > 0 Then
            noditem = treeSystems.Nodes.Add("INIT")
            noditem = treeSystems.Nodes(0).Nodes.Add("INIT")
            treeSystems.EndUpdate()
            My.Application.DoEvents()
            treeSystems.Nodes.Clear()
            treeSystems.BeginUpdate()
        End If

        For x = 1 To MaxSystems
            If Val(varSite(x, 0, 0, 3)) > 0 Then
                'Begin drawing the tree for that site
                TreeKey = "S" & Format(x, "0000") 'Key for first site would be S0001
                intNodeIndex = intNodeIndex + 1
                noditem = treeSystems.Nodes.Add(SysKey(x))
                treeSystems.Nodes(intNodeIndex).Tag = TreeKey
                'HIGHLIGHT l/o systems
                If Val(varSite(x, 0, 0, 2)) = 1 Then
                    treeSystems.Nodes(intNodeIndex).ForeColor = Color.Red
                Else
                    treeSystems.Nodes(intNodeIndex).ForeColor = Color.Black
                End If
                intSysDrawn = intSysDrawn + 1
                If intUpdate = 3 Then
                    'Call FormWait(intSysDrawn, intSysCnt, 1)
                    intUpdate = 0
                End If
                intUpdate = intUpdate + 1
                'expand root
                'find out if there are any groups inside
                intGroupNodeIndex = -1
                For CGroup = 1 To MaxGroups 'loop through all possible groups and display them onscreen
                    Gname = Val(varSite(x, CGroup, 0, 5))
                    If intCurrentSys = x Then
                        strMySite = TreeKey
                    End If
                    If Gname = 1 Or Gname = 2 Or Gname = 3 Then 'is this a valid group type?
                        GroupNodeIndex = TreeKey & "G" & Format(CGroup, "0000") ' group keys will be S0001G0001
                        If intCurrentSys = x And intCurrentGroup = CGroup Then
                            strMyGroup = GroupNodeIndex
                        End If
                        treeSystems.Nodes(intNodeIndex).Nodes.Add(SiteKey(x, CGroup))
                        intGroupNodeIndex = intGroupNodeIndex + 1
                        treeSystems.Nodes(intNodeIndex).Nodes(intGroupNodeIndex).Tag = GroupNodeIndex
                        'site highlighting
                        If lblSiteNote.mnuHighlightSite.Checked = True Then
                            If Val(varSite(x, CGroup, 0, 5)) = 3 Then
                                treeSystems.Nodes(intNodeIndex).Nodes(intGroupNodeIndex).BackColor = Color.Yellow
                            End If
                        End If
                        'group highlighting
                        If lblSiteNote.mnuGroupHighlight.Checked = True Then
                            If Val(varSite(x, 0, 0, 3)) > 1 And Val(varSite(x, CGroup, 0, 5)) = 2 Then
                                treeSystems.Nodes(intNodeIndex).Nodes(intGroupNodeIndex).BackColor = Color.LightGreen
                            End If
                        End If

                        'lockout highlighting

                        If Val(varSite(x, CGroup, 0, 3)) = 1 Then
                            treeSystems.Nodes(intNodeIndex).Nodes(intGroupNodeIndex).ForeColor = Color.Red
                        End If
                    End If
                Next CGroup
            End If
        Next x
        ' treeSystems.Sorted = frmSystemEditor.mnuTreeSort.Checked
        If blnQuickDraw = False Then
            treeSystems.ExpandAll()
        End If
        treeSystems.EndUpdate()
        Me.Cursor = System.Windows.Forms.Cursors.Default

        'Call FormWait(1, 1, 0)
        treeSystems.EndUpdate()
        'select all
        Call cmdCheckAll_Click(Nothing, Nothing)
    End Sub
	
	
	Private Sub frmPrintSetup_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        With lstConv.Items
            .Add("Display")
            .Add("Frequency")
            .Add("Step Size")
            .Add("Lockout")
            .Add("CTCSS/DCS")
            .Add("P25 NAC")
            .Add("Tone Lockout")
            .Add("Attenuation")
            .Add("Number Tag")
            .Add("Priority")
            .Add("Audio Type")
            .Add("Alert Level")
            .Add("Alert Tone Type")
            .Add("Alert Light Colour")
            .Add("Alert Light Pattern")
            .Add("Record Out")
            .Add("Modulation")
            .Add("Volume Offset")
            .Add("Comment")
        End With
        With lstConv

        End With
        With lstTGID.Items
            .Add("Display")
            .Add("TGID")
            .Add("Lockout")
            .Add("Number Tag")
            .Add("Priority")
            .Add("Audio Type")
            .Add("Record Out")
            .Add("Alert Level")
            .Add("Alert Tone Type")
            .Add("Alert Light Colour")
            .Add("Alert Light Pattern")
            .Add("Comment")
        End With
        Call initForm()
    End Sub
    Sub UpdateFieldSelection()
        'update the strCOlDatType field everytime the checkboxes are modified
        Dim intCnt As Integer, intCol As Integer
        intCol = 0
        System.Array.Clear(strColDatType, 0, strColDatType.Length)
        With lstConv
            For intCnt = 0 To .Items.Count - 1
                If .GetItemChecked(intCnt) Then
                    Select Case intCnt
                        Case 0 'display
                            strColDatType(intCol, 0) = "1"
                        Case 1 ' freq
                            strColDatType(intCol, 0) = "2"
                        Case 2 'step size
                            strColDatType(intCol, 0) = "19"
                        Case 3 'lockout
                            strColDatType(intCol, 0) = "5"
                        Case 4 'ctcss/dvs
                            strColDatType(intCol, 0) = "9"
                        Case 5 'nac code
                            strColDatType(intCol, 0) = "15"
                        Case 6 'tone lo
                            strColDatType(intCol, 0) = "11"
                        Case 7 'aattenuation
                            strColDatType(intCol, 0) = "6"
                        Case 8 'num tag
                            strColDatType(intCol, 0) = "16"
                        Case 9 'pri
                            strColDatType(intCol, 0) = "7"
                        Case 10 'audio type
                            strColDatType(intCol, 0) = "12"
                        Case 11 ' alert level
                            strColDatType(intCol, 0) = "13"
                        Case 12 ' alert tone type
                            strColDatType(intCol, 0) = "8"
                        Case 13 'alert ligt colour
                            strColDatType(intCol, 0) = "17"
                        Case 14 'alert light pattern
                            strColDatType(intCol, 0) = "18"
                        Case 15 'recordu
                            strColDatType(intCol, 0) = "3"
                        Case 16 'modulation
                            strColDatType(intCol, 0) = "4"
                        Case 17 'vol offset
                            strColDatType(intCol, 0) = "20"
                        Case 18 'comment
                            strColDatType(intCol, 0) = "14"
                    End Select
                    intCol += 1
                Else
                    strColDatType(intCnt, 0) = ""
                End If

            Next
        End With
        intCol = 0
        With lstTGID
            For intCnt = 0 To .Items.Count - 1
                If .GetItemChecked(intCnt) Then
                    Select Case intCnt
                        Case 5 'audio type
                            strColDatType(intCol, 1) = "6"
                        Case 7 ' alert level
                            strColDatType(intCol, 1) = "5"
                        Case 8 ' alert tone type
                            strColDatType(intCol, 1) = "4"
                        Case 9 'alert ligt colour
                            strColDatType(intCol, 1) = "20"
                        Case 10 'alert light pattern
                            strColDatType(intCol, 1) = "21"
                        Case 11 'comment
                            strColDatType(intCol, 1) = "14"
                        Case 0 'display
                            strColDatType(intCol, 1) = "1"
                        Case 1 'tgid
                            strColDatType(intCol, 1) = "2"
                        Case 2 'lockout
                            strColDatType(intCol, 1) = "3"
                        Case 3 ' number tag
                            strColDatType(intCol, 1) = "19"
                        Case 4 'priority
                            strColDatType(intCol, 1) = "8"
                        Case 6 'record out
                            strColDatType(intCol, 1) = "7"
                    End Select
                    intCol += 1
                Else
                    strColDatType(intCnt, 1) = ""
                End If

            Next
        End With
    End Sub
    Private Sub Form_Terminate_Renamed()
        Call cmdClose_Click(cmdClose, New System.EventArgs())
    End Sub
	
	Private Sub frmPrintSetup_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Call cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub
	
	
	Private Sub TabStrip1_Click()
		
	End Sub
	
	Private Sub treeSystems_AfterCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles treeSystems.AfterCheck
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        Dim ParentNode As System.Windows.Forms.TreeNode = eventArgs.Node
		Dim intNode, intGroupNode As Integer
		Dim blnLastGroup As Boolean
        Dim TreeKey As String
        Dim intSysNode As Integer
		
        If Not blnDebug Then On Error Resume Next

		With treeSystems
            TreeKey = Node.Tag
            If Len(TreeKey) = 5 And Not SkipChildSelect Then
                For intNode = 0 To Node.Nodes.Count - 1
                    Node.Nodes(intNode).Checked = Node.Checked
                Next
            ElseIf Len(TreeKey) = 10 Then
                ParentNode = Node.Parent
                If Node.Checked And Not ParentNode.Checked Then
                    SkipChildSelect = True
                    ParentNode.Checked = True
                    SkipChildSelect = False
                End If
            End If

        End With
		
    End Sub
    Function SysKey(ByRef intSystem As Integer) As String
        Dim strKey As String
        strKey = Nothing
        'Adds the quicklockout key to a system

        If varSite(intSystem, 0, 0, 4) <> "" And varSite(intSystem, 0, 0, 4) <> "." Then
            strKey = "[" & Format(Val(varSite(intSystem, 0, 0, 4)), "00") & "] "
        End If

        'system type

        strKey = strKey & "[" & SysType(Val(varSite(intSystem, 0, 0, 3)), 1) & "] "

        strKey = strKey & varSite(intSystem, 0, 0, 1)
        SysKey = strKey
    End Function
    Function SiteKey(ByRef intSystem As Integer, ByRef intSite As Integer) As String
        Dim strKey As String
        strKey = Nothing
        'Adds the quicklockout key to a site

        If varSite(intSystem, intSite, 0, 2) <> "" And varSite(intSystem, intSite, 0, 2) <> "." Then
            strKey = "[" & Format(Val(varSite(intSystem, intSite, 0, 2)), "00") & "] "
        End If


        If Val(varSite(intSystem, intSite, 0, 5)) = 3 Then
            strKey = strKey & "[" & SiteType(Val(varSite(intSystem, intSite, 0, 9)), 1) & "] "
        Else
            strKey = strKey & "[GRP] "
        End If

        strKey = strKey & varSite(intSystem, intSite, 0, 1)
        SiteKey = strKey
    End Function
    Function FontTag() As String
        'Returns font tag for setup
        Dim WebFontSize As Integer
        Select Case intFontSize
            Case 8
                WebFontSize = 1
            Case 10
                WebFontSize = 2
            Case 12
                WebFontSize = 3
            Case 14
                WebFontSize = 4
            Case 18
                WebFontSize = 5
            Case 24
                WebFontSize = 6
            Case 26
                WebFontSize = 8
            Case 36
                WebFontSize = 9
            Case Else
                WebFontSize = 2
        End Select

        FontTag = "<font face=$QUOTE$" & strFontName & "$QUOTE$ size=$QUOTE$" & CStr(WebFontSize) & "$QUOTE$>"

    End Function
    Function GenHTMLTable(ByVal NumCol As Integer, ByVal NumRow As Integer, ByVal strData As Object, ByVal intTableWidth As Integer, ByVal BorderWidth As Integer) As String
        Dim intCol As Integer, intRow As Integer
        Dim strBuff As String
        GenHTMLTable = Nothing
        If Not blnDebug Then On Error GoTo Endfunction
        If IsArray(strData) = False Then Exit Function
        'Writes out an HTML tables
        strBuff = Nothing
        strBuff = "<br><table border=$QUOTE$" & CStr(BorderWidth) & "$QUOTE$ cellpadding=$QUOTE$0$QUOTE$ cellspacing=$QUOTE$0$QUOTE$ bordercolor=$QUOTE$#000000$QUOTE$ width=$QUOTE$" & CStr(intTableWidth)
        strBuff &= "$QUOTE$ bgcolor=$QUOTE$#FFFFFF$QUOTE$>"
        For intRow = 0 To NumRow
            strBuff &= "<tr>" & vbCr
            For intCol = 0 To NumCol - 1
                strBuff &= "<td>" & FontTag() & "&nbsp;" & strData(intRow, intCol) & "&nbsp;</font></td>" & vbCr
            Next
            strBuff &= "</tr>" & vbCr
        Next
        strBuff &= "</table></div><br>"
EndFunction:
        GenHTMLTable = strBuff
    End Function



    Private Sub cmdPageSetup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPageSetup.Click
        GenPrintBuff()
        prerender.ShowPageSetupDialog()
    End Sub

    Private Sub cmdPrintHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintHTML.Click
        prerender.DocumentText = Nothing
        GenPrintBuff()
        My.Application.DoEvents()
        prerender.ShowSaveAsDialog()

    End Sub
    Function GenCard() As String
        If Not blnDebug Then On Error Resume Next
        Dim intSystem, intSysCnt, intSite As Integer
        Dim intNodeCnt As Integer
        Dim strBuff, strBuff1 As String
        Dim intCnt, intCnt1 As Integer
        Dim intNode, intChildNode As Integer
        Dim strNodeKey As String
        Dim blnFirstPage As Boolean
        Dim intRow, intMaxRow, intCol As Integer
        Dim blnDone As Boolean
        Dim intQK As Integer
        Dim intColSize As Integer = 0
        Dim intLine As Integer = -1
        Dim strPage As String = Nothing
        Dim strExtraTags As String = Nothing
        Dim WebFontSize As Integer
        Dim TempDir As String
        Dim intFile As Integer
        Dim objStreamWriter As StreamWriter
        Dim ShellCode As String
        Dim QKTable(1000, 1) As String
        Dim QKOutput(500, 6) As String
        blnAbortOp = False
        Me.UseWaitCursor = True
        intFontSize = Val(GetSetting("FreeSCAN", "Settings", "FontSize", "8"))
        If intFontSize > 8 Then
            intFontSize = intFontSize - 8
            intColSize = intFontSize * 50
        End If

        'Now begin the primary loop to start adding things to the buffer
        For intQK = 0 To 99
            For intSystem = 0 To MaxSystems
                If varSite(intSystem, 0, 0, 3) = "1" And varSite(intSystem, 0, 0, 4) = CStr(intQK) Then
                    'this is a conventional system with a QK, add it to the list
                    intLine += 1
                    QKTable(intLine, 0) = CStr(intQK)
                    QKTable(intLine, 1) = varSite(intSystem, 0, 0, 1)
                ElseIf varSite(intSystem, 0, 0, 3) <> "" Then
                    'loop through all the sites looking for a QK
                    For intSite = 0 To MaxGroups
                        If varSite(intSystem, intSite, 0, 2) = CStr(intQK) And varSite(intSystem, intSite, 0, 5) = "3" Then
                            intLine += 1
                            QKTable(intLine, 0) = CStr(intQK)
                            QKTable(intLine, 1) = varSite(intSystem, intSite, 0, 1)
                        End If
                        If intLine = 1000 Then Exit For
                    Next
                End If
                If intLine = 1000 Then Exit For
            Next
            If intLine = 1000 Then Exit For
        Next

        'Split the resulting variable into 3 columns
        intMaxRow = CInt(intLine / 3)
        If intLine / 3 <> Int(intLine / 3) Then
            intMaxRow += 1
        End If
        For intCnt = 0 To intLine
            QKOutput(intRow, intCol) = QKTable(intCnt, 0)
            QKOutput(intRow, intCol + 1) = QKTable(intCnt, 1)
            intRow += 1
            If intRow > intMaxRow Then
                intRow = 0
                intCol += 2
            End If
        Next
        strPage &= GenHTMLTable(6, intMaxRow, QKOutput, 400 + intColSize, 0)
        GenCard = strPage
TerminateSub:
        'Terminal Sub routine gracefully
        Me.UseWaitCursor = False
    End Function
End Class

