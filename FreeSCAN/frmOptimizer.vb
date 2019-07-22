Option Strict Off
Option Explicit On
Friend Class frmOptimizer
	Inherits System.Windows.Forms.Form
	Dim blnAutoMode As Boolean
	Sub GenStats()
		'this generates the statistics seen in the automatic optimizer screen
		If blnDebug = False Then On Error Resume Next
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Dim intChan, intCnt As Integer
		Dim strBuff As String
		Dim strDir As String
		Dim intTGID As Integer
		Dim dblLastFreq As Double
		Dim intDirChg, intFreqCnt As Integer
		Dim dblFreq As Double
		Dim strBuff1 As String
		Dim intSys, intSite As Integer
        Dim intSysCnt As Integer
        Dim shpStat(3) As Label
        shpStat(0) = _shpStat_0
        shpStat(1) = _shpStat_1
        shpStat(2) = _shpStat_2
        shpStat(3) = _shpStat_3
		For intCnt = 0 To 3
            shpStat(intCnt).BackColor = Color.Beige
        Next intCnt
        '*******************************count how many duplicate frequencies there are

        intCnt = GetDupeCount()
        lblDupFreq.Text = intCnt & " duplicate frequencies are present."
        If intCnt < 15 Then 'green

            shpStat(0).BackColor = Color.SpringGreen
        ElseIf intCnt < 50 Then  'yel

            shpStat(0).BackColor = Color.Yellow
        Else 'red

            shpStat(0).BackColor = Color.Red
        End If
        System.Windows.Forms.Application.DoEvents()
        '*******************************determine sorting efficient
        intCnt = 0
        'this is done by measure the sorting efficiency in main memory
        strDir = "U"
        For intChan = 1 To MaxChan
            'is this a conventional frequency?
            If ChanInfo(intChan, 9) <> "" And InStr(ChanInfo(intChan, 2), ".") <> 0 Then
                'compare to last frequency, bigger or smaller
                dblFreq = Val(ChanInfo(intChan, 2))
                intFreqCnt = intFreqCnt + 1
                If dblFreq > dblLastFreq Then
                    If strDir = "D" Then 'we changed direction since last time, so this is inefficient
                        strDir = "U"
                        intDirChg = intDirChg + 1
                    End If
                ElseIf dblFreq < dblLastFreq And Val(ChanInfo(intChan, 2)) <> 0 Then
                    'frequency is less then previous
                    If strDir = "U" Then 'changed direction, how inefficient
                        strDir = "D"
                        intDirChg = intDirChg + 1
                    End If
                End If
                dblLastFreq = dblFreq
            End If
        Next intChan
        'calculate efficiency
        If intFreqCnt > 0 Then
            strBuff = CStr(intDirChg / intFreqCnt)
            strBuff = CStr(((CDbl(strBuff) * 100) - 100) * -1)
            strBuff1 = "Frequencies are sorted at " & Str(Int(CDbl(strBuff))) & "% efficiency"
            'choose a colour
            If CDbl(strBuff) > 88 Then 'acceptabile efficiency, green
                shpStat(1).BackColor = Color.SpringGreen
            ElseIf CDbl(strBuff) > 75 Then  'mediocre efficient, yellow
                shpStat(1).BackColor = Color.Yellow
            Else 'highly inefficient, red
                shpStat(1).BackColor = Color.Red
            End If
        Else
            strBuff1 = "No conventional frequencies are present."

            shpStat(1).BackColor = Color.SpringGreen
        End If
        lblFreqSort.Text = strBuff1
        '********************************caculate long hold times
        intCnt = 0
        strBuff = ""
        strBuff1 = ""
        intSysCnt = 0
        'go through every system and site and assess the hold time
        For intSys = 1 To MaxSystems
            'what kind of system is this?
            If varSite(intSys, 0, 0, 3) = "1" Then 'conventional system
                intSysCnt = intSysCnt + 1
                If Val(varSite(intSys, 0, 0, 5)) > 0 Then 'hold time larger then 0, inefficient
                    intCnt = intCnt + 1
                End If
            ElseIf Val(varSite(intSys, 0, 0, 3)) > 1 Then  'trunked system
                'go through every bloody site and check the hold time
                For intSite = 1 To MaxGroups
                    If Val(varSite(intSys, intSite, 0, 5)) = CDbl("3") Then 'is this a site?
                        intSysCnt = intSysCnt + 1
                        If Val(varSite(intSys, intSite, 0, 4)) > 2 Then 'is the hold time long?
                            intCnt = intCnt + 1
                        End If
                    End If
                Next intSite
            End If
        Next intSys
        'how many sites/systems are inefficient?
        lblHoldTime.Text = intCnt & " inefficient systems && sites found."
        If intCnt < 3 Then 'green
            shpStat(2).BackColor = Color.SpringGreen
        ElseIf intCnt < 6 Then  'yel
            shpStat(2).BackColor = Color.Yellow
        Else 'red
            shpStat(2).BackColor = Color.Red
        End If


        '********************detect invalid TGIDs
        intCnt = 0
        'setup grid
        With frmViewInvalids.grdChan
            .Rows.Clear()

            .RowCount = 1

            For intChan = 1 To MaxChan
                strBuff = ""
                If ChanInfo(intChan, 10) <> "" Then 'is this a channel?
                    'is this a valid TGID?

                    If IsValidChan(ChanInfo(intChan, 2)) = False Then
                        intCnt = intCnt + 1
                        'add it to the grd
                        .RowCount = .RowCount + 1
                        GetOwner((intChan))
                        SetGrid(.RowCount - 1, 0, varSite(lngChanSys, 0, 0, 1)) 'system name
                        SetGrid(.RowCount - 1, 1, varSite(lngChanSys, lngChanGroup, 0, 1)) 'group name
                        SetGrid(.RowCount - 1, 2, ChanInfo(intChan, 1)) 'channel name
                        SetGrid(.RowCount - 1, 3, ChanInfo(intChan, 2)) 'frequency or tgid or whatever
                    End If
                End If
            Next intChan
        End With
        If intCnt < 5 Then 'green
            shpStat(3).BackColor = Color.SpringGreen
        ElseIf intCnt < 15 Then  'yel
            shpStat(3).BackColor = Color.Yellow
        Else 'red
            shpStat(3).BackColor = Color.Red
        End If
		lblTGID.Text = intCnt & " invalid channels found."
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub

    Sub SetGrid(ByVal intRow As Integer, ByVal intCol As Integer, ByVal sData As String)
        frmViewInvalids.grdChan(intCol, intRow).Value = sData
    End Sub
    Function ReturnBadTGID(ByRef intChan As Integer) As Boolean
        If blnDebug = False Then On Error Resume Next
        Dim intCnt, intChr As Integer
        Dim strBuff As String
        
        If ChanInfo(intChan, 9) = "" And ChanInfo(intChan, 10) <> "" Then 'is this a TGID?
            'is this a valid TGID?
            
            If Val(ChanInfo(intChan, 2)) < 1 Then 'zero, negative, empty or non numeric TGID
                
                ReturnBadTGID = True
            Else
                'is there an invalid char in the TGID
                

            End If
        End If
    End Function
    Function GetDupeCount() As Integer
        'finds duplicate frequencies
        Dim lngCnt, lngCnt1 As Integer
        Dim strBuff As String
        Dim j, lngNumChan, i, intParam As Integer
        Dim blnFound As Boolean
        Dim sngBuff, sngBuff1 As Single
        Dim intIndexCnt, intDupes As Integer
        Dim strGroup(MaxGroups) As String
        Dim intGroupCnt, intCnt As Integer
        If blnDebug = False Then On Error Resume Next
        'count number of channels that need to be done
        For lngCnt = 1 To MaxChan
            If ChanInfo(lngCnt, 9) <> "" Then
                lngNumChan = lngNumChan + 1
            End If
        Next lngCnt
        If lngNumChan < 1 Then
            
            GetDupeCount = 0
            Exit Function
        End If
        ReDim ChanShadow(lngNumChan, MaxChanSetting + 1)
        ReDim ChanDup(lngNumChan)
        'Copy all the channels we are interested in into the buffer
        intDupes = 0
        For lngCnt = 1 To MaxChan
            If ChanInfo(lngCnt, 9) <> "" Then
                'Copy channel to buffer, add origanol as index
                intDupes = intDupes + 1
                ChanShadow(intDupes, 2) = CStr(Val(ChanInfo(lngCnt, 2)))
                ChanShadow(intDupes, 1) = CStr(lngCnt) 'store origanol position
                ChanShadow(intDupes, 9) = ChanInfo(lngCnt, 9) 'save tone
            End If
        Next
        intDupes = 0

        'Next, sort the array
        'sort channel by frequency, ascending
        Dim best_value(9) As String
        Dim best_j As Single
        For i = 1 To lngNumChan - 1
            
            best_value(1) = ChanShadow(i, 1)
            
            best_value(2) = ChanShadow(i, 2)
            
            best_value(9) = ChanShadow(i, 9)
            best_j = i
            For j = i + 1 To lngNumChan
                
                If Val(ChanShadow(j, 2)) < Val(best_value(2)) Then
                    
                    best_value(1) = ChanShadow(j, 1)
                    
                    best_value(2) = ChanShadow(j, 2)
                    
                    best_value(9) = ChanShadow(j, 9)
                    best_j = j
                End If
            Next j
            ChanShadow(best_j, 9) = ChanShadow(i, 9)
            ChanShadow(best_j, 2) = ChanShadow(i, 2)
            ChanShadow(best_j, 1) = ChanShadow(i, 1)
            
            ChanShadow(i, 2) = best_value(2)
            
            ChanShadow(i, 1) = best_value(1)
            
            ChanShadow(i, 9) = best_value(9)
        Next i

        'Finally, begin building an index of channels that are dupicated
        For lngCnt = 1 To lngNumChan - 1 'last channel will be skipped, if its a dup then too bad
            sngBuff = Val(ChanShadow(lngCnt, 2))
            sngBuff1 = Val(ChanShadow(lngCnt + 1, 2))
            If sngBuff = sngBuff1 And ChanShadow(lngCnt, 9) = ChanShadow(lngCnt + 1, 9) Then
                'a duplicate frequency and PL tone is found
                'add the current to the index
                intIndexCnt = intIndexCnt + 1
                ChanDup(intIndexCnt) = CInt(ChanShadow(lngCnt, 1))
                blnFound = True 'mark this as a known duplicate
                intDupes = intDupes + 1
            Else
                'not a duplicate, but if the last one
                'was a duplicate then add it to the index
                If blnFound = True And lngCnt > 1 Then
                    intIndexCnt = intIndexCnt + 1
                    ChanDup(intIndexCnt) = CInt(ChanShadow(lngCnt, 1))
                    blnFound = False
                    intDupes = intDupes + 1
                End If
            End If
        Next lngCnt
        
        GetDupeCount = intDupes
    End Function
	
	
	
	Private Sub cmdAutoSort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAutoSort.Click
		'sort everyconventional channel in memory'somehow
		'ummm
		'store all trunked freqs in temporary array
		'sort all conventioanl
		'move tgids back to the end
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		blnChgSaved = False
		Dim intTGIDcnt, intChan, intCnt As Integer
        Dim strBuff As String = Nothing
        Dim strTempChan(1, 1) As String
		Dim intParam As Integer
        Dim intTmpChan As Integer
		ReDim strTempChan(MaxChan, MaxChanSetting)
        Dim i, intBuff As Integer
		Dim j, intNew As Integer
		Dim ChanSort(1,1) As String
		ReDim ChanSort(MaxChan, MaxChanSetting)
		Dim best_value(MaxChanSetting) As String
        Dim best_j As Integer
        Dim Sanity As Double
		intCnt = 0
		For intChan = 1 To MaxChan

            If ChanInfo(intChan, 9) = Nothing And ChanInfo(intChan, 10) <> Nothing And InStr(ChanInfo(intChan, 2), ".") = 0 Then 'is this a TGID?
                'move it on over

                intTmpChan = intTmpChan + 1
                For intParam = 0 To MaxChanSetting

                    strTempChan(intTmpChan, intParam) = ChanInfo(intChan, intParam)
                    ChanInfo(intChan, intParam) = Nothing
                Next intParam
            End If
		Next intChan
		'next, sort the entire chaninfo array by frequency
		
		intTGIDcnt = intTmpChan
		intBuff = 0
		
		'Dump the info from chaninfo to chandata so its nice and linear
		For intChan = 1 To MaxChan
            If ChanInfo(intChan, 10) <> "" Or ChanInfo(intChan, 10) <> Nothing Then
                intBuff = intBuff + 1
                For intParam = 0 To MaxChanSetting
                    ChanSort(intBuff, intParam) = ChanInfo(intChan, intParam)
                    'wipe out the old info, while at it
                    ChanInfo(intChan, intParam) = Nothing
                Next intParam
                ChanSort(intBuff, 2) = Trim(ChanSort(intBuff, 2))
            End If
		Next intChan
		'sort channel by frequency, ascending
		For i = 1 To intBuff - 1
            For intParam = 0 To MaxChanSetting
                best_value(intParam) = ChanSort(i, intParam)
                best_j = i
            Next intParam
            For j = i + 1 To intBuff
                If Val(ChanSort(j, 2)) < Val(best_value(2)) Then
                    'Console.WriteLine(Val(ChanSort(j, 2)) & " < " & Val(best_value(2)))
                    For intParam = 0 To MaxChanSetting
                        best_value(intParam) = ChanSort(j, intParam)
                    Next intParam
                    best_j = j
                End If
            Next j
            For intParam = 0 To MaxChanSetting
                ChanSort(best_j, intParam) = ChanSort(i, intParam)
                ChanSort(i, intParam) = best_value(intParam)
            Next intParam
			
		Next i
		intNew = 0
		'reinsert chansort back into memory
		Erase ChanInfo
        ReDim ChanInfo(MaxChan, MaxChanSetting)
        For intChan = 1 To intBuff
            If Val(ChanSort(intChan, 2)) >= Sanity Then
                Sanity = Val(ChanSort(intChan, 2))
            Else
                Console.WriteLine(Sanity & "   -  " & Val(ChanSort(intChan, 2)))
            End If
        Next
        For intChan = 1 To intBuff
            intNew = intNew + 1
            For intParam = 0 To MaxChanSetting
                ChanInfo(intNew, intParam) = ChanSort(intChan, intParam)
            Next intParam
        Next intChan
        'reinsert trunked channels back into memory
        For intChan = 1 To intTGIDcnt
            intNew = intNew + 1
            For intParam = 0 To MaxChanSetting
                ChanInfo(intNew, intParam) = strTempChan(intChan, intParam)
            Next intParam
        Next intChan
        Erase ChanSort
        Erase strTempChan
        If blnAutoMode <> True Then
            GenStats()
            lblSiteNote.UpdateViewMode()
        End If
        Me.Activate()
    End Sub

    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
        Call FormShutDown()
    End Sub

    Private Sub cmdHoldTimeReset_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHoldTimeReset.Click
        blnChgSaved = False
        If blnDebug = False Then On Error Resume Next
        Dim intSys, intSite As Integer
        Dim strBuff As String
        For intSys = 1 To MaxSystems
            'what kind of system is this?
            If varSite(intSys, 0, 0, 3) = "1" Then 'conventional system
                varSite(intSys, 0, 0, 5) = "0" 'hold time  0, efficient
            ElseIf Val(varSite(intSys, 0, 0, 3)) > 1 Then  'trunked system
                'go through every bloody site and check the hold time
                For intSite = 1 To MaxGroups
                    If Val(varSite(intSys, intSite, 0, 5)) = CDbl("3") Then 'is this a site?
                        If Val(varSite(intSys, intSite, 0, 4)) > 2 Then 'is the hold time long?
                            varSite(intSys, intSite, 0, 4) = "2"
                        End If
                    End If
                Next intSite
            End If
        Next intSys
        If blnAutoMode <> True Then
            GenStats()
            lblSiteNote.UpdateViewMode()
            Me.Activate()
        End If
    End Sub

    Private Sub cmdOpenDup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOpenDup.Click
        Call lblSiteNote.FindDupe("GLOBAL", "CONV")

    End Sub

    Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
        GenStats()
    End Sub

    Private Sub cmdRemTGID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRemTGID.Click
        blnChgSaved = False
        'removes invalid channels
        Dim intParam, intChan As Integer
        Dim strBuff As String
        For intChan = 1 To MaxChan
            strBuff = ""
            If ChanInfo(intChan, 10) <> "" Then 'is this a channel?
                'is this a valid channel?

                If IsValidChan(ChanInfo(intChan, 2)) = False Then
                    'Nuke it
                    For intParam = 0 To MaxChanSetting
                        ChanInfo(intChan, intParam) = ""
                    Next intParam
                End If
            End If
        Next intChan
        If blnAutoMode <> True Then
            GenStats()
            lblSiteNote.UpdateViewMode()
        End If
        Me.Activate()
    End Sub
	
	Private Sub cmdViewBadChan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdViewBadChan.Click
		frmViewInvalids.Visible = True
	End Sub
	
	'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_WARNING: frmOptimizer event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Form_Terminate_Renamed()
		Call FormShutDown()
	End Sub
	
	Sub FormShutDown()
		Me.Visible = False
		frmViewInvalids.Visible = False
	End Sub
	
	Private Sub frmOptimizer_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Call FormShutDown()
	End Sub
End Class