Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmImport
	Inherits System.Windows.Forms.Form
    Dim strFilename As String
    Dim blnBusy As Boolean = False
	Dim strFileType As String
	
	Private Sub cmdChooseFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdChooseFile.Click
        If blnDebug = False Then On Error GoTo abort
		Dim strBuff As String
        Dim strFileVer As String, blnFileOpen As Boolean = False
        strBuff = ""
		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        'CommonDialog.CancelError = True
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        With openfiledialog1
            'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
            'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog.Flags was upgraded to CommonDialogOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
            'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
            .ShowReadOnly = False
            'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog.Flags was upgraded to CommonDialogOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
            .CheckFileExists = True
            .CheckPathExists = True
            .FileName = "*.996"
            'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            .Filter = "FreeSCAN (*.996)|*.996|All Files (*.*)|*.*"
            .Title = "Open File"
            .FilterIndex = 0
            .Title = "Open File"
            .ShowDialog()
            '-- Did the user select a file name?
            If .FileName = "" Then
                MsgBox("Please enter a file name")
                Exit Sub
            Else
                '-- Put some code here to save the file
                strFilename = .FileName
            End If
        End With
		
		If strFilename = "" Or strFilename = "*.996" Then Exit Sub
		If FileExists(strFilename) = False Then
			MsgBox("Cannot find the file " & strFilename & vbNewLine & "Please try again.")
			Exit Sub
		End If
		lblFileName.Text = strFilename
		'now that we have what we want, import it and display the list
		'determine if its a compatible file type
		FileOpen(1, strFilename, OpenMode.Input)
		Input(1, strBuff)
		FileClose(1)
		strFileType = strBuff
		Select Case strBuff
            '		Case ".03BCD996T"               'old versions not supported anymore
            '			LoadSysList99603()
            '			Exit Sub
            '	Case ".08BCD996T"
            ' LoadSysList99603()
            ' Exit Sub
			Case ".7BCD996T"
				LoadSysList99607()
				Exit Sub
			Case Else
				MsgBox("Sorry, but the file type " & strBuff & " is not compatible with this version of FreeSCAN. Please check the website for future updates and compatbility with file type " & strBuff)
				Exit Sub
		End Select
		
		Exit Sub
abort: 
		MsgBox("Critical error on import, unable to continue.")
		If blnFileOpen = True Then FileClose(1)
	End Sub
	
	
	Sub LoadSysList99603()
		'loads a system list of of file type .03 BC996 for the user selecting which
		'systems they want to import
		If blnDebug = False Then On Error GoTo abort
		Dim sngPos As Single
		Dim strBuff1, strBuff, strTreeKey As String
		Dim cnt, intSys As Integer
        Dim intNumSys As Integer
		Dim Systems(700, 257, 5) As String
		Dim intNumGroup, intGroup As Integer
		Dim GroupNodeIndex, TreeKey As String
        Dim noditem As TreeNode, intGroupNodeIndex As Integer = -1
        Dim intNodeIndex As Integer = -1
		Dim blnFileOpen As Boolean
		Dim Marker As String
		FileOpen(1, strFilename, OpenMode.Input)
        blnFileOpen = True
        strBuff = ""
		TreeView.Nodes.Clear()
		For cnt = 1 To 271 'radiosetting and custom search range, don't care
			sngPos = sngPos + 1
			Input(1, strBuff)
		Next cnt
		Input(1, strBuff)
		
		intNumSys = Val(strBuff)
		sngPos = sngPos + 1
		
		If intNumSys = 0 Then
			MsgBox("No systems were found in the selected file.")
		End If
		
		For intSys = 1 To intNumSys
			'download the first system
			sngPos = sngPos + 1
			Input(1, Systems(intSys, 0, 1)) 'system name
			Systems(intSys, 0, 0) = CStr(sngPos) 'where to find it in the file
			Input(1, strBuff) 'skip l/o status
			Input(1, Systems(intSys, 0, 3)) ' sys type
			sngPos = sngPos + 2
			For cnt = 1 To 59 'skip everything else, since we don't care
				sngPos = sngPos + 1
				Input(1, strBuff)
			Next cnt
			
			'*******************GROUP LEVEL
			sngPos = sngPos + 1
			Input(1, strBuff)
			intNumGroup = Val(strBuff)
			For intGroup = 1 To intNumGroup
				'group information
				sngPos = sngPos + 1
				Input(1, strBuff) 'group name
				Systems(intSys, intGroup, 1) = strBuff 'group name
				Systems(intSys, intGroup, 0) = CStr(sngPos) 'position
				'dont care about the rest of the details
				For cnt = 1 To 61
					Input(1, strBuff)
					sngPos = sngPos + 1
				Next cnt
			Next intGroup
		Next intSys
		FileClose(1)
		blnFileOpen = False
		
		For intSys = 1 To intNumSys
			'populate the tree
			If Systems(intSys, 0, 3) = "1" Then
				Marker = "C"
			Else
				Marker = "T"
			End If
			'Tree key will be the position in the file
            TreeKey = "S" & Format(Val(Systems(intSys, 0, 0)), "0000000")
            intNodeIndex += 1
            noditem = treeview.Nodes.Add(Systems(intSys, 0, 1) & "     " & Marker)
            treeview.Nodes.Item(intNodeIndex).Checked = True
            treeview.Nodes.Item(intNodeIndex).Tag = Systems(intSys, 0, 0)
            'if there are any groups, show them
            intGroupNodeIndex = -1
			For intGroup = 1 To 257
                If Val(Systems(intSys, intGroup, 0)) <> 0 Then 'is this a valid group?
                    intGroupNodeIndex += 1
                    GroupNodeIndex = TreeKey & "G" & Format(Val(Systems(intSys, intGroup, 0)), "0000000")
                    noditem = treeview.Nodes(intNodeIndex).Nodes.Add(Systems(intSys, intGroup, 1))
                    treeview.Nodes(intNodeIndex).Nodes(intGroupNodeIndex).Tag = Systems(intSys, intGroup, 0)
                    treeview.Nodes(intNodeIndex).Nodes(intGroupNodeIndex).Checked = True
                    'UPGRADE_WARNING: Add method behavior has changed Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
                    '  noditem = treeview.Nodes.Find(TreeKey, True)(0).Nodes.Add(GroupNodeIndex, Systems(intSys, intGroup, 1))
                    ' treeview.Nodes.Item(GroupNodeIndex).Checked = True
                    'treeview.Nodes.Item(TreeKey).Tag = Systems(intSys, intGroup, 0)
                End If
			Next intGroup
		Next intSys
		cmdImportSys.Enabled = True
        'ConvLegacyBP()
		Exit Sub
abort: 
		MsgBox("A critical error occured trying to import the file. Cannot continue.")
		If blnFileOpen = True Then FileClose(1)
		
	End Sub
	Sub LoadSysList99607()
		'loads a system list of of file type .7 BC996 for the user selecting which
		'systems they want to import
        'If blnDebug = False Then On Error GoTo abort
		Dim sngPos As Single
        Dim strBuff As String
		Dim cnt, intSys As Integer
        Dim intNumSys As Integer
		Dim Systems(700, 257, 5) As String
		Dim intNumGroup, intGroup As Integer
		Dim GroupNodeIndex, TreeKey As String

        Dim noditem As TreeNode, intGroupNodeIndex As Integer = -1
        Dim intNodeIndex As Integer = -1
		Dim blnFileOpen As Boolean
		Dim Marker As String
		FileOpen(1, strFilename, OpenMode.Input)
		blnFileOpen = True
        treeview.Nodes.Clear()
        strBuff = ""
		For cnt = 1 To 371 'radiosetting and custom search range, don't care
			sngPos = sngPos + 1
			Input(1, strBuff)
		Next cnt
		Input(1, strBuff)
		
		intNumSys = Val(strBuff)
        sngPos += 1
		
		If intNumSys = 0 Then
			MsgBox("No systems were found in the selected file.")
		End If
		
		For intSys = 1 To intNumSys
			'download the first system
			sngPos = sngPos + 1
			Input(1, Systems(intSys, 0, 1)) 'system name
			Systems(intSys, 0, 0) = CStr(sngPos) 'where to find it in the file
			Input(1, strBuff) 'skip l/o status
			Input(1, Systems(intSys, 0, 3)) ' sys type
			sngPos = sngPos + 2
			For cnt = 1 To 59 'skip everything else, since we don't care
				sngPos = sngPos + 1
				Input(1, strBuff)
			Next cnt
			
			'*******************GROUP LEVEL
			sngPos = sngPos + 1
			Input(1, strBuff)
			intNumGroup = Val(strBuff)
			For intGroup = 1 To intNumGroup
				'group information
				sngPos = sngPos + 1
				Input(1, strBuff) 'group name
				Systems(intSys, intGroup, 1) = strBuff 'group name
				Systems(intSys, intGroup, 0) = CStr(sngPos) 'position
				'dont care about the rest of the details
				For cnt = 1 To 61
					Input(1, strBuff)
					sngPos = sngPos + 1
				Next cnt
			Next intGroup
		Next intSys

        FileClose(1)
        blnFileOpen = False

        For intSys = 1 To intNumSys
            'populate the tree
            If Systems(intSys, 0, 3) = "1" Then
                Marker = "C"
            Else
                Marker = "T"
            End If
            'Tree key will be the position in the file
            TreeKey = "S" & Format(Val(Systems(intSys, 0, 0)), "0000000")
            intNodeIndex += 1
            noditem = treeview.Nodes.Add(Systems(intSys, 0, 1) & "     " & Marker)
            noditem.Name = TreeKey
            treeview.Nodes.Item(intNodeIndex).Checked = True
            treeview.Nodes.Item(intNodeIndex).Tag = Systems(intSys, 0, 0)
            'if there are any groups, show them
            intGroupNodeIndex = -1
            For intGroup = 1 To 257
                If Val(Systems(intSys, intGroup, 0)) <> 0 Then 'is this a valid group?
                    intGroupNodeIndex += 1
                    GroupNodeIndex = TreeKey & "G" & Format(Val(Systems(intSys, intGroup, 0)), "0000000")
                    noditem = treeview.Nodes(intNodeIndex).Nodes.Add(Systems(intSys, intGroup, 1))
                    noditem.Tag = Systems(intSys, intGroup, 0)
                    noditem.Checked = True
                    noditem.Name = GroupNodeIndex
                End If
            Next intGroup
        Next intSys
        cmdImportSys.Enabled = True
        'ConvLegacyBP()
        Exit Sub
abort:
        MsgBox("A critical error occured trying to import the file. Cannot continue.")
        If blnFileOpen = True Then FileClose(1)
		
	End Sub
	Private Sub cmdClearAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearAll.Click
        Dim intNode As Integer
        For intNode = 0 To treeview.Nodes.Count - 1

            treeview.Nodes.Item(intNode).Checked = False
        Next intNode
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Visible = False
        If lblSiteNote.Visible = True Then
            lblSiteNote.Enabled = True
            lblSiteNote.Activate()
            lblSiteNote.DrawSystemTree()
        Else
            lblSiteNote.Visible = True
            lblSiteNote.Enabled = True
            lblSiteNote.Activate()
        End If
	End Sub
	
	Sub cmdImportSys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImportSys.Click
		'load a system from disk into memory
		Select Case strFileType
            '	Case ".03BCD996T"
            '			ImportFrom996()
            '			Case ".08BCD996T"
            '				ImportFrom996()
			Case ".7BCD996T"
				ImportFrom996()
                '			Case ".10BCD396T"
                ' ImportFrom396()
			Case Else
				MsgBox("Cannot import this file, the format is not supported.")
				
		End Select
		
	End Sub
    Sub ShowStat(ByRef intTotSys As Integer, ByRef intSys As Integer, ByRef intSiteCnt As Integer, ByRef intChanCnt As Integer, ByRef intTrnCnt As Integer)
        'displays statistics as to how well the import is going
        
        lblStat(0).Text = intSys
        
        lblStat(1).Text = intSiteCnt
        
        lblStat(2).Text = intChanCnt
        
        lblStat(3).Text = intTrnCnt
        
        If intTotSys > 0 Then
            
            
            barComplete.Value = Int((intSys / intTotSys) * 100)
        Else
            barComplete.Value = 0
        End If
        System.Windows.Forms.Application.DoEvents()
    End Sub
	Private Sub cmdSelectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectAll.Click
        Dim intNode As Integer
        For intNode = 0 To treeview.Nodes.Count - 1

            'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            treeview.Nodes.Item(intNode).Checked = True
        Next intNode
	End Sub
	Sub ImportFrom996()
        If blnDebug = False Then On Error GoTo abort
		Dim intParam, intTotalTrunkFreq, ChanNum, intNumSys, intSys As Integer
		Dim strFileVer As String
		Dim blnFileOpen, blnFailed As Boolean
        Dim intNodeCount As Integer
		Dim sngPos, sngTargetPos As Single
        Dim intNumGroup, intNumChannel As Integer
		Dim strBuff As String
        Dim intGroup, intNode, intIndex, intSubNode As Integer
		Dim strIndex(2000, 1) As String
		'counters
        Dim intGroupCount, intSysCount, intChannelCount As Integer
		Dim strBuff1, strbuff2 As String
		Dim intTrnCnt As Integer
		Dim strBuffA(10) As String
		Dim intCnt, intChan, intChanNum, intTrunkCount As Integer
		Dim ChanBuff(31) As String
		Dim blnTrunkMem, blnLegacy As Boolean
		'strIndex x,y y=0 Old Index, y=1 New Index
		FileOpen(1, strFilename, OpenMode.Input)
		blnFileOpen = True
		blnFailed = False
        strBuff = ""
        strbuff2 = Nothing
        strFileVer = Nothing
		intNodeCount = TreeView.Nodes.Count
		'begin setup
		strBuff1 = "Experience the timeless beauty of being a woman"
		Input(1, strFileVer)
		sngPos = sngPos + 1
        If strFileVer = ".7BCD996T" Then
            blnLegacy = False
        Else
            blnLegacy = True
        End If
		If blnLegacy = False Then
			intCnt = 370
		Else
			intCnt = 270
		End If
        For intParam = 1 To intCnt 'radiosetting and custom search range, don't care
            sngPos += 1
            Input(1, strBuff)
        Next intParam
        sngPos = sngPos + 1
        Input(1, strBuff)

        For intNode = 0 To intNodeCount - 1
            'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Len(treeview.Nodes.Item(intNode).Name) = 8 And treeview.Nodes.Item(intNode).Checked = True Then
                intNumSys += 1
            End If
        Next intNode
        With treeview

            For intNode = 0 To intNodeCount - 1
                Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)
                'are we downloading this system?
                If .Nodes.Item(intNode).Checked = True And blnFailed = False Then
                    'yes we are
                    'grab the position we want
                    'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    sngTargetPos = Val(VB.Right(.Nodes.Item(intNode).Name, 7))
                    sngTargetPos = sngTargetPos - 1
                    'are we already there
                    If sngPos = sngTargetPos Then
                        'ok we are, good
                    ElseIf sngPos < sngTargetPos Then  'advance till we get there
                        Do Until sngPos = sngTargetPos
                            sngPos = sngPos + 1
                            Input(1, strBuff)
                        Loop
                    ElseIf sngPos > sngTargetPos Then  'this should never happen
                        MsgBox("Critical error, target position fault, cannot load systems.")

                        blnFailed = True
                        Exit For
                    End If
                    'is this a site or a group
                    'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    If Len(.Nodes.Item(intNode).Name) = 8 And Not blnFailed Then 'its a system

                        'begin downloading all site information

                        intSys = GetFreeSysNum()

                        intSysCount = intSysCount + 1
                        RadioSetting(20) = CStr(Val(RadioSetting(20)) + 1)
                        Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)
                        If intSys = -1 Then
                            blnFailed = True
                            MsgBox("Insufficient memory to import any more systems. Delete some and try again.")
                            FileClose(1)
                            Exit Sub
                        End If
                        For intParam = 1 To 62
                            sngPos = sngPos + 1
                            Input(1, strBuff)
                            varSite(intSys, 0, 0, intParam) = strBuff
                        Next intParam

                        varSite(intSys, 0, 0, 23) = CreateGroupID() 'insert a new id here
                        sngPos += 1
                        Input(1, strBuff) 'number of groups to follow

                    End If
                    'this checks to see if there are any subnodes
                    For intSubNode = 0 To .Nodes.Item(intNode).Nodes.Count - 1
                        If Len(.Nodes.Item(intNode).Nodes(intSubNode).Name) = 16 And .Nodes.Item(intNode).Nodes(intSubNode).Checked Then  'its a group

                            intGroup = GetFreeGroupNum(intSys)

                            intGroupCount = intGroupCount + 1
                            Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)
                            If intGroup = -1 Then 'fail, insufficient resources
                                MsgBox("Insufficient memory, loading of some groups has failed.")
                            Else
                                'load all the group/site paramaters
                                For intParam = 1 To 62
                                    sngPos = sngPos + 1
                                    Input(1, strBuff)
                                    varSite(intSys, intGroup, 0, intParam) = strBuff
                                    'save the site/group key for later use
                                    If intParam = 10 Then
                                        intIndex = intIndex + 1
                                        'group index is reassigned to avoid major problems
                                        strIndex(intIndex, 0) = varSite(intSys, intGroup, 0, intParam)

                                        varSite(intSys, intGroup, 0, intParam) = CreateGroupID()
                                        strIndex(intIndex, 1) = varSite(intSys, intGroup, 0, intParam)
                                    End If
                                Next intParam

                            End If
                        ElseIf Len(.Nodes.Item(intNode).Nodes(intSubNode).Name) = 16 And Not .Nodes.Item(intNode).Nodes(intSubNode).Checked Then
                            'This is an unchecked node, skip it
                            For intParam = 1 To 62
                                sngPos += 1
                                Input(1, strBuff)
                            Next
                        End If 'what kind of node
                    Next
                End If 'is this a node we want?
            Next intNode
        End With
        'grab the index of the last group
        'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        'strBuff = CStr(Val(VB.Right(treeview.Nodes.Item(treeview.Nodes.Count - 1).Name, 7)) + 62) 'this is the very last position of the last group, before trunking freqs begin
        'now advance till we get at the start of the very last group
        Do Until strBuff1 = "TrunkSection"
            sngPos += 1
            Input(1, strBuff1)
        Loop
        'start downloading channels
        'start with trunk frequencies
        Input(1, strBuff)
        intTrunkCount = Val(strBuff)
        If intTrunkCount > 0 And blnTrunkMem = False Then 'are there any trunk frequencies to download?
            For intParam = 1 To intTrunkCount
                Input(1, strBuff)
                Input(1, strBuff1)
                Input(1, strbuff2)
                If blnLegacy = False Then
                    For intCnt = 3 To 10
                        Input(1, strBuffA(intCnt))
                    Next intCnt
                End If

                'do we care about this particular frequencies
                For intGroup = 1 To intIndex
                    If strIndex(intGroup, 0) = strbuff2 And blnTrunkMem = False Then 'The group ID matches, so download

                        intNode = InsertTrunkFreq(strIndex(intGroup, 1))
                        If intNode = -1 Then 'insuffcient memory
                            MsgBox("Insufficient memory to download any more trunking frequencies. Remaining will be ignored.")
                            blnTrunkMem = True
                        Else
                            Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)
                            'store data
                            intTrnCnt = intTrnCnt + 1
                            strTrunkFreq(intNode, 0) = strBuff 'freq
                            strTrunkFreq(intNode, 1) = strBuff1
                            If blnLegacy = False Then
                                For intCnt = 3 To 10
                                    strTrunkFreq(intNode, intCnt) = strBuffA(intCnt)
                                Next intCnt

                                If InStr(strBuff1, "!") <> 0 Then 'seperate lockout status
                                    'lockout is always off because sometimes its set to 1
                                    'strTrunkFreq(intNode, 3) = CStr(Val(OldMid(strBuff1, 2, 1)))
                                    strTrunkFreq(intNode, 1) = CStr(Val(strBuff1))
                                Else
                                    strTrunkFreq(intNode, 3) = "0" 'no lockout is available so set to off
                                End If
                            Else
                                'set defaults
                                strTrunkFreq(intNode, 3) = "0" 'lockout
                                strTrunkFreq(intNode, 4) = "NONE" 'NUmber tag
                                strTrunkFreq(intNode, 5) = "0" ' volume offset
                            End If
                        End If
                    End If
                Next intGroup
            Next intParam
        End If
        Input(1, strBuff) 'search lockouts
        'dont care about sngPOS any more
        Do Until strBuff = "SEARCHLOCKOUTS" Or EOF(1) = True
            Input(1, strBuff)
        Loop
        If EOF(1) = True Then MsgBox("reached end of file")
        If strBuff <> "SEARCHLOCKOUTS" Then
            MsgBox("Positional error reading search lockouts. Cannot import channels")
        Else
            Input(1, strBuff) 'number of search lockouts to expect
            For intParam = 1 To Val(strBuff)
                Input(1, strBuff1)
            Next intParam 'dont give a damn about lockouts
        End If

        'download channel data
        Input(1, strBuff)
        If strBuff <> "CHANDATA" Then
            MsgBox("Channel data header mismatch, channel information will not be imported.")
        Else
            'import channel input
            Input(1, strBuff)
            intTrunkCount = Val(strBuff)
            'are there any channnels to download?
            blnTrunkMem = False
            If intTrunkCount > 0 Then
                For intChan = 1 To intTrunkCount
                    'load the channel into the buff
                    For intParam = 1 To 30
                        Input(1, strBuff)
                        ChanBuff(intParam) = strBuff
                    Next intParam
                    'is this a channel we want?
                    For intCnt = 1 To intIndex
                        If strIndex(intCnt, 0) = ChanBuff(10) Then 'yes we want this

                            intChannelCount = intChannelCount + 1
                            Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)

                            intChanNum = InsertChan(strIndex(intCnt, 1), True) 'reassign to the new group id
                            If intChanNum = -1 And blnTrunkMem = False Then
                                MsgBox("Sorry, but the channel memory is full. No more channels can be imported.")
                                blnTrunkMem = True
                                intChan = intTrunkCount
                                intCnt = intIndex
                            ElseIf intChanNum > 0 And blnTrunkMem = False Then
                                For intParam = 1 To 30
                                    ChanInfo(intChanNum, intParam) = ChanBuff(intParam)
                                Next intParam
                                ChanInfo(intChanNum, 10) = strIndex(intCnt, 1) 'assign correct group ID
                            End If
                        End If
                    Next intCnt
                Next intChan
            End If
        End If
        FileClose(1)
        blnFileOpen = False
        blnChgSaved = False


        strBuff = CStr(MsgBox("Import complete." & vbNewLine & "Systems: " & intSysCount & vbNewLine & "Sites / Groups: " & intGroupCount & vbNewLine & "Channels: " & intChannelCount, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Import complete"))
        Call ConvLegacyBP()
        Exit Sub
abort:
        MsgBox("Critical error, loading of file failed, aborting. Error code " & Err.Number)
        If blnFileOpen = True Then FileClose(1)
    End Sub
    'UPGRADE_WARNING: Form event frmImport.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmImport_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'Call Form_Load
    End Sub
    Sub ImportFrom396()
        On Error GoTo abort
        Dim intParam, intTotalTrunkFreq, ChanNum, intNumSys, intSys As Integer
        Dim strFileVer As String
        Dim blnFileOpen, blnFailed As Boolean
        Dim intNodeCount As Integer
        Dim sngPos, sngTargetPos As Single
        Dim intNumGroup, intNumChannel As Integer
        Dim strBuff As String
        Dim intGroup, intNode, intIndex As Integer
        Dim strIndex(2000, 1) As String
        'counters
        Dim intChannelCount, intSysCount, intGroupCount, strbuff2 As String
        Dim strBuff1 As String
        Dim intTrnCnt As Integer
        Dim intCnt, intChan, intChanNum, intTrunkCount As Integer
        Dim ChanBuff(31) As String
        Dim blnTrunkMem, blnTrunkSys As Boolean
        strBuff = ""
        'strIndex x,y y=0 Old Index, y=1 New Index
        FileOpen(1, strFilename, OpenMode.Input)
        blnFileOpen = True
        blnFailed = False
        intChannelCount = 0
        intGroupCount = 0
        intSysCount = 0
        strbuff2 = Nothing
        intNodeCount = treeview.Nodes.Count
        'begin setup
        strBuff1 = "Experience the timeless beauty of being a woman"
        For intParam = 1 To 271 'radiosetting and custom search range, don't care
            sngPos = sngPos + 1
            Input(1, strBuff)
        Next intParam
        sngPos = sngPos + 1
        Input(1, strBuff)

        For intNode = 1 To intNodeCount
            'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Len(treeview.Nodes.Item(intNode).Name) = 8 And treeview.Nodes.Item(intNode).Checked = True Then
                intNumSys = intNumSys + 1
            End If
        Next intNode
        With treeview

            For intNode = 1 To intNodeCount

                Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)
                'are we downloading this system?
                'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If .Nodes.Item(intNode).Checked = True And blnFailed = False Then
                    'yes we are
                    'grab the position we want
                    'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    sngTargetPos = Val(VB.Right(.Nodes.Item(intNode).Name, 7))
                    sngTargetPos = sngTargetPos - 1
                    'are we already there
                    If sngPos = sngTargetPos Then
                        'ok we are, good
                    ElseIf sngPos < sngTargetPos Then  'advance till we get there
                        Do Until sngPos = sngTargetPos
                            sngPos = sngPos + 1
                            Input(1, strBuff)
                        Loop
                    ElseIf sngPos > sngTargetPos Then  'this should never happen
                        MsgBox("Critical error, target position fault, cannot load systems.")

                        intNode = intNodeCount
                        blnFailed = True
                    End If
                    'is this a site or a group
                    'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    If Len(.Nodes.Item(intNode).Name) = 8 Then 'its a system
                        If blnFailed = False Then
                            'see if trunk system conversion needs to take place
                            If blnTrunkSys = True Then ImportTrunkSys((intSys)) ' import a trunk system, incase the last one was it
                            'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                            If VB.Right(.Nodes.Item(intNode).Text, 1) = "C" Then
                                blnTrunkSys = False
                                'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                            ElseIf VB.Right(.Nodes.Item(intNode).Text, 1) = "T" Then
                                blnTrunkSys = True
                            End If
                            'begin downloading all site information

                            intSys = GetFreeSysNum()

                            intSysCount = intSysCount + 1
                            RadioSetting(20) = CStr(Val(RadioSetting(20)) + 1)
                            Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)
                            If intSys = -1 Then
                                blnFailed = True
                                MsgBox("Insufficient memory to import any more systems. Delete some and try again.")
                                FileClose(1)
                                Exit Sub
                            End If
                            For intParam = 1 To 62
                                sngPos = sngPos + 1
                                Input(1, strBuff)
                                varSite(intSys, 0, 0, intParam) = strBuff
                            Next intParam

                            varSite(intSys, 0, 0, 23) = CreateGroupID() 'insert a new id here
                            sngPos = sngPos + 1
                            Input(1, strBuff) 'number of groups to follow
                            SetupSysParam((intSys)) 'sets up basic system paramters unset on the 396
                        End If
                        'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    ElseIf Len(.Nodes.Item(intNode).Name) = 16 Then  'its a group

                        intGroup = GetFreeGroupNum(intSys)

                        intGroupCount = intGroupCount + 1
                        Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)
                        If intGroup = -1 Then 'fail, insufficient resources
                            MsgBox("Insufficient memory, loading of some groups has failed.")
                        Else
                            'load all the group/site paramaters
                            For intParam = 1 To 62
                                sngPos = sngPos + 1
                                Input(1, strBuff)
                                varSite(intSys, intGroup, 0, intParam) = strBuff
                                'save the site/group key for later use
                                If intParam = 10 Then
                                    intIndex = intIndex + 1
                                    'group index is reassigned to avoid major problems
                                    strIndex(intIndex, 0) = varSite(intSys, intGroup, 0, intParam)

                                    varSite(intSys, intGroup, 0, intParam) = CreateGroupID()
                                    strIndex(intIndex, 1) = varSite(intSys, intGroup, 0, intParam)
                                End If
                            Next intParam
                        End If 'blnfailed=false
                    End If 'what kind of node
                End If 'is this a node we want?
            Next intNode
            If blnTrunkSys = True Then ImportTrunkSys((intSys)) ' import a trunk system
        End With
        'grab the index of the last group
        'UPGRADE_WARNING: Lower bound of collection TreeView.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        strBuff = CStr(Val(VB.Right(treeview.Nodes.Item(treeview.Nodes.Count).Name, 7)) + 62) 'this is the very last position of the last group, before trunking freqs begin
        'now advance till we get at the start of the very last group
        Do While sngPos < Val(strBuff)
            sngPos = sngPos + 1
            Input(1, strBuff1)
        Loop


        'start downloading channels
        'start with trunk frequencies
        Input(1, strBuff)
        intTrunkCount = Val(strBuff)
        If intTrunkCount > 0 And blnTrunkMem = False Then 'are there any trunk frequencies to download?
            For intParam = 1 To intTrunkCount
                Input(1, strBuff)
                Input(1, strBuff1)
                Input(1, strbuff2)
                'do we care about this particular frequencies
                For intGroup = 1 To intIndex

                    If strIndex(intGroup, 0) = strbuff2 And blnTrunkMem = False Then 'The group ID matches, so download

                        intNode = InsertTrunkFreq(strIndex(intGroup, 1))
                        If intNode = -1 Then 'insuffcient memory
                            MsgBox("Insufficient memory to download any more trunking frequencies. Remaining will be ignored.")
                            blnTrunkMem = True
                        Else
                            Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)
                            'store data
                            intTrnCnt = intTrnCnt + 1
                            strTrunkFreq(intNode, 0) = strBuff 'freq
                            strTrunkFreq(intNode, 1) = strBuff1
                        End If
                    End If
                Next intGroup
            Next intParam
        End If
        Input(1, strBuff) 'search lockouts
        'dont care about sngPOS any more
        Do Until strBuff = "SEARCHLOCKOUTS" Or EOF(1) = True
            Input(1, strBuff)
        Loop
        If EOF(1) = True Then MsgBox("reached end of file")
        If strBuff <> "SEARCHLOCKOUTS" Then
            MsgBox("Positional error reading search lockouts. Cannot import channels")
        Else
            Input(1, strBuff) 'number of search lockouts to expect
            For intParam = 1 To Val(strBuff)
                Input(1, strBuff1)
            Next intParam 'dont give a damn about lockouts
        End If

        'download channel data
        Input(1, strBuff)
        If strBuff <> "CHANDATA" Then
            MsgBox("Channel data header mismatch, channel information will not be imported.")
        Else
            'import channel input
            Input(1, strBuff)
            intTrunkCount = Val(strBuff)
            'are there any channnels to download?
            blnTrunkMem = False
            If intTrunkCount > 0 Then
                For intChan = 1 To intTrunkCount
                    'load the channel into the buff
                    For intParam = 1 To 30
                        Input(1, strBuff)
                        ChanBuff(intParam) = strBuff
                    Next intParam
                    'is this a channel we want?
                    For intCnt = 1 To intIndex
                        If strIndex(intCnt, 0) = ChanBuff(10) Then 'yes we want this

                            intChannelCount = intChannelCount + 1
                            Call ShowStat(intNumSys, intSysCount, intGroupCount, intChannelCount, intTrnCnt)

                            intChanNum = InsertChan(strIndex(intCnt, 1), True) 'reassign to the new group id
                            If intChanNum = -1 And blnTrunkMem = False Then
                                MsgBox("Sorry, but the channel memory is full. No more channels can be imported.")
                                blnTrunkMem = True
                                intChan = intTrunkCount
                                intCnt = intIndex
                            ElseIf intChanNum > 0 And blnTrunkMem = False Then
                                For intParam = 1 To 30
                                    ChanInfo(intChanNum, intParam) = ChanBuff(intParam)
                                Next intParam
                                ChanInfo(intChanNum, 10) = strIndex(intCnt, 1) 'assign correct group ID
                            End If
                        End If
                    Next intCnt
                Next intChan
            End If
        End If
        FileClose(1)
        blnFileOpen = False



        strBuff = CStr(MsgBox("Import complete." & vbNewLine & "Systems: " & intSysCount & vbNewLine & "Sites / Groups: " & intGroupCount & vbNewLine & "Channels: " & intChannelCount, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Import complete"))

        Exit Sub
abort:
        MsgBox("Critical error, loading of file failed, aborting. Error code " & Err.Number)
        If blnFileOpen = True Then FileClose(1)
    End Sub

    Private Sub frmImport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call cmdClose_Click(Nothing, Nothing)

    End Sub
	Sub frmImport_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		cmdImportSys.Enabled = False
		TreeView.Nodes.Clear()
		lblFileName.Text = "(None)"
		strFilename = ""
		Call ShowStat(0, 0, 0, 0, 0)
	End Sub
	
	Private Sub treeview_AfterCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles treeview.AfterCheck
        If blnbusy Then Exit Sub
        blnbusy = True
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        Dim intGroupNode As Integer
        Node = eventArgs.Node
		With TreeView
            'if a group was checked, check its parent as well
            'check to see if a group was checked, make sure the respective system is enabled
            If Node.Checked = True And Len(Node.Name) = 16 Then ' a group was checked
                Node.Parent.Checked = True
            End If
            'a system was cleared, clear all groups
            If Node.Checked = False And Len(Node.Name) = 8 Then
                intGroupNode = Node.Nodes.Count - 1
                For intGroupNode = 0 To intGroupNode
                    Node.Nodes.Item(intGroupNode).Checked = False
                Next

            ElseIf Node.Checked = True And Len(Node.Name) = 8 Then
                'a system was checked, automatically check all the groups below
                intGroupNode = Node.Nodes.Count - 1
                For intGroupNode = 0 To intGroupNode
                    Node.Nodes.Item(intGroupNode).Checked = True
                Next
            End If
        End With
        blnBusy = False
	End Sub
	
    Sub ImportTrunkSys(ByRef intSys As Integer)
        If blnDebug = False Then On Error Resume Next
        'This takes the trunking storage format used in the
        '396 version of freescan and converts it to the 996 version
        Dim intSysType, intSiteType As Integer
        'initialize site paramaters
        
        varSite(intSys, 1, 0, 1) = varSite(intSys, 0, 0, 1) 'name
        
        varSite(intSys, 1, 0, 2) = varSite(intSys, 0, 0, 4) 'qk
        
        varSite(intSys, 1, 0, 3) = varSite(intSys, 0, 0, 2) 'lo
        
        varSite(intSys, 1, 0, 4) = varSite(intSys, 0, 0, 5) 'hold time
        ' varSite(intSys, 1, 0, 9) = Site type, change this
 

        
        varSite(intSys, 1, 0, 12) = "." 'startup key
        
        varSite(intSys, 1, 0, 13) = "" 'gps
        
        varSite(intSys, 1, 0, 14) = "" 'gps
        
        varSite(intSys, 1, 0, 15) = "0" 'gps
        
        varSite(intSys, 1, 0, 16) = "0" 'gps
        'everything else stays the same

        'setup system paramters
        
        varSite(intSys, 0, 0, 5) = ""
        
        varSite(intSys, 0, 0, 2) = ""
        
        varSite(intSys, 0, 0, 4) = ""
        
        varSite(intSys, 0, 0, 18) = Nothing

        'setup system types
        
        Select Case Val(varSite(intSys, 0, 0, 3))
            Case 1
                intSysType = 1
                intSiteType = 1
            Case 2
                intSysType = 3
                intSiteType = 1
            Case 3
                intSysType = 3
                intSiteType = 2
            Case 4
                intSysType = 3
                intSiteType = 3
            Case 5
                intSysType = 3
                intSiteType = 4
            Case 6
                intSysType = 3
                intSiteType = 5
            Case 7
                intSysType = 2
                intSiteType = 7
            Case 8
                intSysType = 2
                intSiteType = 8
            Case 9
                intSysType = 3
                intSiteType = 6
            Case 10
                intSysType = 4
                intSiteType = 9
            Case 11
                intSysType = 4
                intSiteType = 10
            Case 12
                intSysType = 5
                intSiteType = 11
            Case 13
                intSysType = 6
                intSiteType = 12
        End Select
        
        varSite(intSys, 0, 0, 3) = CStr(intSysType)
        
        varSite(intSys, 1, 0, 9) = CStr(intSiteType)

    End Sub
    Sub SetupSysParam(ByRef intSys As Integer)
        
        varSite(intSys, 0, 0, 7) = "."
        
        varSite(intSys, 0, 0, 22) = CStr(0)
        
        varSite(intSys, 0, 0, 24) = "1"

    End Sub
End Class