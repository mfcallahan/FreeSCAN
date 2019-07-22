Option Strict Off
Option Explicit On
Friend Class frmJust
	Inherits System.Windows.Forms.Form
	
	
	Private Sub CancelButton_Click()
		
	End Sub
    Function Justify(ByRef strName As String, ByRef strDir As String) As String
        'justifies a 16-char long string
        Justify = Nothing

        strName = Trim(strName)
        Dim intPos, intLen As Integer
        Dim intCnt As Integer
        Dim strBuff As String
        strBuff = Nothing
        intLen = Len(strName)
        If intLen = 16 Then
            Justify = strName
            Exit Function
        ElseIf intLen = 0 Then
            Justify = ""
            Exit Function
        End If
        Select Case strDir
            Case "L" 'left just
                Justify = strName
            Case "C" 'center just
                intPos = 16 - intLen
                intPos = Int(intPos / 2)
                For intCnt = 1 To intPos
                    strBuff = strBuff & " "
                Next intCnt
                Justify = strBuff & strName
            Case "R" 'right just
                intPos = 16 - intLen
                For intCnt = 1 To intPos
                    strBuff = strBuff & " "
                Next intCnt
                
                Justify = strBuff & strName
        End Select
    End Function
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Visible = False
        lblSiteNote.Visible = True
        lblSiteNote.Enabled = True
        lblSiteNote.Activate()
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        'Justify channel names

        Dim strDir As String
        Dim lngSys, lngChan, lngGroup As Integer
        strDir = Nothing
        If optJust(0).Checked = True Then strDir = "L"
        If optJust(1).Checked = True Then strDir = "C"
        If optJust(2).Checked = True Then strDir = "R"
        If optJustSel(0).Checked = True Then 'justify selected channels

        ElseIf optJustSel(1).Checked = True Then  'justify channels within this group
            For lngChan = 1 To MaxChan
                If ChanInfo(lngChan, 10) = varSite(intCurrentSys, intCurrentGroup, 0, 10) Then 'justify this name

                    ChanInfo(lngChan, 1) = Justify(ChanInfo(lngChan, 1), strDir)
                End If
            Next lngChan
        ElseIf optJustSel(2).Checked = True Then  'justify current system
            For lngGroup = 1 To MaxGroups
                If varSite(intCurrentSys, lngGroup, 0, 5) = "1" Or varSite(intCurrentSys, lngGroup, 0, 5) = "2" Then
                    For lngChan = 1 To MaxChan
                        If ChanInfo(lngChan, 10) = varSite(intCurrentSys, lngGroup, 0, 10) Then 'justify this name

                            ChanInfo(lngChan, 1) = Justify(ChanInfo(lngChan, 1), strDir)
                        End If
                    Next lngChan
                End If
            Next lngGroup
        ElseIf optJustSel(3).Checked = True Then  'global justify
            For lngSys = 1 To MaxSystems
                If varSite(lngSys, 0, 0, 3) <> "" Then
                    For lngGroup = 1 To MaxGroups
                        If varSite(lngSys, lngGroup, 0, 5) = "1" Or varSite(lngSys, lngGroup, 0, 5) = "2" Then
                            For lngChan = 1 To MaxChan
                                If ChanInfo(lngChan, 10) = varSite(lngSys, lngGroup, 0, 10) Then 'justify this name

                                    ChanInfo(lngChan, 1) = Justify(ChanInfo(lngChan, 1), strDir)
                                End If
                            Next lngChan
                        End If
                    Next lngGroup
                End If
            Next lngSys
        End If
        'redraw grids if needed
        If varSite(intCurrentSys, intCurrentGroup, 0, 5) = "1" Then
            'redraw convgroup
            lblSiteNote.LoadConvChanGrid()
        ElseIf varSite(intCurrentSys, intCurrentGroup, 0, 5) = "2" Then
            lblSiteNote.LoadTrunkChanGrid()
        End If
        blnChgSaved = False
        Call cmdCancel_Click(cmdCancel, New System.EventArgs())
    End Sub
End Class