Option Strict Off
Option Explicit On
Friend Class frmFind
	Inherits System.Windows.Forms.Form
    Dim bRestart As Boolean = False ' Is this the second time find has been run?
	Private Sub cmdCancelFind_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelFind.Click
		Me.Visible = False
        lblSiteNote.Enabled = True
        If lblSiteNote.Visible = True Then lblSiteNote.Activate()

    End Sub

    Private Sub cmdFind_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFind.Click
        Dim intSys As Integer, intGroup As Integer
        Dim intChan As Integer
        Dim txtSearch As String



        txtSearch = txtSearchString.Text
        If txtSearch = "" Then
            MsgBox("Please specify the string you are searching for.")
            Exit Sub
        End If
        intSys = intCurrentSys
        intGroup = intCurrentGroup

        'remove case
        txtSearch = CaseSel(txtSearchString.Text)
        '  If optDirection(1).Checked = True Then 'search down
        'first find if its in the current group
        intChan = GetRealChan(intCurrentSys, intCurrentGroup, intCurrentChannel) ' find the channel index for the present system
        If intChan <> 1 Then
            intChan = SearchCurrGroup(intSys, intGroup, intChan + 1, txtSearch, 1) 'tell the subroutine to go looking for it
        Else
            intChan = SearchCurrGroup(intSys, intGroup, intChan, txtSearch, 1)
        End If
        If intChan > 0 Then ' a channel was found, display

            If ChanInfo(intChan, 9) <> Nothing Then ' is this a conventional channel, if so it should have a tone present
                'setup for the right system, group
                'find the system and group this belongs to
                For intSys = 1 To MaxSystems
                    For intGroup = 1 To MaxGroups
                        If Val(varSite(intSys, intGroup, 0, 5)) = 1 Then 'a site is found
                            'is this the one that belongs to the found channel
                            If varSite(intSys, intGroup, 0, 10) = ChanInfo(intChan, 10) Then
                                'yes? then setup for this
                                intCurrentSys = intSys
                                intCurrentGroup = intGroup
                                intGroup = MaxGroups
                                intSys = MaxSystems
                                ' Exit For
                            End If
                        End If
                    Next intGroup
                Next intSys

                intChan = FindChanNum(intChan) 'convert it back into a icc type channel number
                'intCurrentChannel = intChan
                lblSiteNote.ViewMode("CONVSYSGROUP") 'bring up the grid


                If intCurrentGroup > 0 Then
                    lblSiteNote.StatusBar.Items.Item(1).Text = varSite(intCurrentSys, 0, 0, 1) & " - " & varSite(intCurrentSys, intCurrentGroup, 0, 1)
                Else
                    lblSiteNote.StatusBar.Items.Item(1).Text = varSite(intCurrentSys, 0, 0, 1)
                End If
                UpdateTreeSelection()

                lblSiteNote.grdConvChan.CurrentCell = lblSiteNote.grdConvChan(0, CInt(MakePositive(intChan - 1)))
                intCurrentChannel = intChan

                Exit Sub
            Else 'bring up a trunked system for display
                'setup for the right system, group
                'find the system and group this belongs to
                For intSys = 1 To MaxSystems
                    'need to insert an if state ment for speed optimization
                    For intGroup = 1 To MaxGroups
                        If Val(varSite(intSys, intGroup, 0, 5)) = 2 Then 'a site is found
                            'is this the one that belongs to the found channel
                            If varSite(intSys, intGroup, 0, 10) = ChanInfo(intChan, 10) Then
                                'yes? then setup for this
                                intCurrentSys = intSys
                                intCurrentGroup = intGroup
                                intGroup = MaxGroups
                                intSys = MaxSystems
                                Exit For
                            End If
                        End If
                    Next intGroup
                Next intSys

                intChan = FindChanNum(intChan) 'convert it back into a icc type channel number

                lblSiteNote.ViewMode("GROUPTRUNK") 'bring up the grid

                If intCurrentGroup > 0 Then
                    lblSiteNote.StatusBar.Items.Item(1).Text = varSite(intCurrentSys, 0, 0, 1) & " - " & varSite(intCurrentSys, intCurrentGroup, 0, 1)
                Else
                    lblSiteNote.StatusBar.Items.Item(1).Text = varSite(intCurrentSys, 0, 0, 1)
                End If
                UpdateTreeSelection()
                intCurrentChannel = intChan
                If lblSiteNote.grdTGID.RowCount >= intCurrentChannel Then
                    lblSiteNote.grdTGID.CurrentCell = lblSiteNote.grdTGID(0, CInt(MakePositive(intCurrentChannel - 1)))
                End If
                Exit Sub
            End If
        ElseIf bRestart = False Then

            intCurrentSys = 1
            intCurrentGroup = 1
            intCurrentChannel = 0
            bRestart = True
            cmdFind_Click(cmdFind, New System.EventArgs())

            Exit Sub
        ElseIf bRestart = True Then
            MsgBox("Unable to find search term.", vbInformation, "Find")
            bRestart = False
            Exit Sub
        End If
        bRestart = False
    End Sub
    Function CaseSel(ByRef strSearch As String) As String
        'this function sets the case sensitivety for searching
        If chkCase.CheckState = 0 Then

            CaseSel = UCase(strSearch)
        Else


            CaseSel = strSearch
        End If
    End Function

    'UPGRADE_WARNING: Form event frmFind.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmFind_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        txtSearchString.Focus()
        txtSearchString.SelectionStart = 0
        txtSearchString.SelectionLength = Len(txtSearchString.Text)
    End Sub

    Private Sub Form_Terminate_Renamed()
        Call cmdCancelFind_Click(cmdCancelFind, New System.EventArgs())
    End Sub

    Function SearchCurrGroup(ByRef intSite As Integer, ByRef intGroup As Integer, ByRef intStartChan As Integer _
                             , ByRef strSrch As String, ByRef intDir As Integer) As _
                         Integer ' site#,group#, intcurrentchannel equiv start position, search string, direction 1=up
        'searches the current site
        'returns the intcurrentchannel equivelant if found
        'otherwise returns -1
        Dim cnt As Integer
        Dim MatchFound As Boolean = False
        SearchCurrGroup = 0
        If intDir = 1 Then 'search down
            'now begin searching from here down

            For cnt = intStartChan To MaxChan 'search from this position down
                'If IsNumeric(strSrch) = True Then strSrch = Val(strSrch)
                If InStr(CaseSel(ChanInfo(cnt, 1)), strSrch, CompareMethod.Text) <> 0 Or InStr(ChanInfo(cnt, 2), strSrch, CompareMethod.Text) <> 0 _
                    And Val(strSrch) <> 0 Then
                    'we found the match
                    SearchCurrGroup = cnt
                    cnt = MaxChan
                    MatchFound = True
                ElseIf InStr(CaseSel(ChanInfo(cnt, 14)), strSrch) <> 0 Or InStr(CaseSel(ChanInfo(cnt, 15)), strSrch) <> 0 Or _
                    Val(strSrch) = Val(ChanInfo(cnt, 2)) And Val(strSrch) <> 0 Then 'search paramaters
                    'we found the match
                    SearchCurrGroup = cnt
                    cnt = MaxChan
                    MatchFound = True
                End If
            Next cnt
            ' If Not MatchFound Then
            ' 'Try searching the trunk frequencies
            ' For cnt = 1 To UBound(strTrunkFreq) 'search from this position down
            ' 'If IsNumeric(strSrch) = True Then strSrch = Val(strSrch)
            ' If InStr(CaseSel(strTrunkFreq(cnt, 0)), strSrch, CompareMethod.Text) <> 0 Or InStr(ChanInfo(cnt, 4), strSrch, CompareMethod.Text) <> 0 _
            '     And Val(strSrch) <> 0 Then
            ' 'we found the match
            ' SearchCurrGroup = cnt * -1 'returns a negative, referrering to a site
            ' cnt = MaxChan
            ' MatchFound = True
            ' End If
            '     Next cnt
            ' End If
        End If
    End Function

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        If lblSiteNote.Visible = False Then
            If frmDupeN_N.Visible = True Then frmDupeN_N.Visible = False
            Me.Visible = False
        End If
    End Sub
	
	Private Sub txtSearchString_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchString.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			Call cmdFind_Click(cmdFind, New System.EventArgs())
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub

    Private Sub frmFind_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bRestart = False
    End Sub
End Class