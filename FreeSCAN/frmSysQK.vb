Option Strict Off
Option Explicit On
Friend Class frmSysQK
	Inherits System.Windows.Forms.Form
	Dim strQKArray(100) As String
	
	Private Sub chkQK_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkQK.MouseMove
		Dim button As Short = eventArgs.Button \ &H100000
		Dim shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim index As Short = chkQK.GetIndex(eventSender)
        Dim cnt As Integer
		'display any systems assigned to this qk
		If blnDebug = False Then On Error Resume Next
		Dim ListArray() As String
		If Val(lblQK.Text) = index Then
			Exit Sub
		End If
		lstQK.Items.Clear()
		
		lblQK.Text = CStr(index)
		If strQKArray(index) <> "" Then
			ListArray = Split(strQKArray(index), Chr(255))
			For cnt = 0 To UBound(ListArray)
				
				lstQK.Items.Add((ListArray(cnt)))
			Next cnt
		End If
	End Sub
	
	Private Sub cmdAllOff_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAllOff.Click
		Dim cnt As Integer
		For cnt = 0 To 99
			chkQK(cnt).CheckState = System.Windows.Forms.CheckState.Unchecked
		Next cnt
	End Sub
	
	Private Sub cmdAllOn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAllOn.Click
		Dim cnt As Integer
		For cnt = 0 To 99
			chkQK(cnt).CheckState = System.Windows.Forms.CheckState.Checked
		Next cnt
	End Sub
	
	Private Sub cmdAutoSel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAutoSel.Click
		If blnDebug = False Then On Error Resume Next
		Dim cnt As Integer
		For cnt = 0 To 99
			If chkQK(cnt).Font.Bold = True Then
				chkQK(cnt).CheckState = System.Windows.Forms.CheckState.Checked
			Else
				chkQK(cnt).CheckState = System.Windows.Forms.CheckState.Unchecked
			End If
		Next cnt
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		If blnDebug = False Then On Error Resume Next
		Me.Visible = False
        If lblSiteNote.Visible = True Then
            lblSiteNote.Activate()
        End If
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        'write settings to memory
        If blnDebug = False Then On Error Resume Next
        Dim strBuff As String
        Dim cnt, intSite As Integer
        Dim CtlID As Integer
        strBuff = Nothing
        'reencodes QK status in uniden order
        For cnt = 1 To 100
            CtlID = cnt
            If cnt / 10 = Int(cnt / 10) Then
                CtlID = CtlID - 10
            End If
            If chkQK(CtlID).CheckState = 1 Then
                strBuff = strBuff & "1"
            Else
                strBuff = strBuff & "2"
            End If
        Next cnt
        RadioSetting(12) = strBuff
        Call cmdCancel_Click(cmdCancel, New System.EventArgs())
        strBuff = "LCIS!"
        lblSiteNote.DispStat("New system quick key settings saved.")
    End Sub
	
	Sub initForm()
        Dim intSite As Integer
		Dim cnt, intPos As Integer
		Dim strBuff, strQSL As String
        Dim strBuff1 As String
		Dim CtlID, cnt1, intQK As Integer
		Dim strName As String
		If blnDebug = False Then On Error Resume Next
		'loads all the quickkeys from memory in the checkboxes
		If Len(RadioSetting(12)) <> 100 Or IsNumeric(RadioSetting(12)) = False Then
			RadioSetting(12) = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111"
		End If
		strQSL = RadioSetting(12)
		'rearrange the bits on the variable because the scanner stores them all screwed up
		
		
		For cnt = 0 To 100
			If cnt / 10 <> Int(cnt / 10) Then
				strBuff = CStr(Val(Mid(strQSL, cnt, 1)))
				If strBuff = "1" Then 'system on
					chkQK(cnt).CheckState = System.Windows.Forms.CheckState.Checked
				Else
					chkQK(cnt).CheckState = System.Windows.Forms.CheckState.Unchecked
				End If
			End If
		Next cnt
		For cnt = 10 To 100 Step 10
			strBuff = CStr(Val(Mid(strQSL, cnt, 1)))
			If strBuff = "1" Then 'system on
				chkQK(cnt - 10).CheckState = System.Windows.Forms.CheckState.Checked
			Else
				chkQK(cnt - 10).CheckState = System.Windows.Forms.CheckState.Unchecked
			End If
		Next cnt
		'setup the qk preview array

		System.Array.Clear(strQKArray, 0, strQKArray.Length)
		For cnt = 1 To MaxSystems
			If varSite(cnt, 0, 0, 3) = "1" Then
				If IsNumeric(varSite(cnt, 0, 0, 4)) = True Then
					strName = varSite(cnt, 0, 0, 1) & " [CNV]"
					If strQKArray(Val(varSite(cnt, 0, 0, 4))) = "" Then
						strQKArray(Val(varSite(cnt, 0, 0, 4))) = strName
					Else
						strQKArray(Val(varSite(cnt, 0, 0, 4))) = strQKArray(Val(varSite(cnt, 0, 0, 4))) & Chr(255) & strName
					End If
				End If
			ElseIf Val(varSite(cnt, 0, 0, 3)) > 1 Then  'actions for a trunked ssytem
				'search for any sites within that system and add to the array
				For intSite = 1 To MaxGroups
					
					If IsNumeric(varSite(cnt, intSite, 0, 2)) = True And varSite(cnt, intSite, 0, 5) = "3" Then
						
						intQK = CInt(varSite(cnt, intSite, 0, 2))
						
						strName = varSite(cnt, intSite, 0, 1) & " " & "[" & SiteType(Val(varSite(cnt, intSite, 0, 9)), 1) & "] "
						If strQKArray(intQK) = "" Then
							strQKArray(intQK) = strName
						Else
							strQKArray(intQK) = strQKArray(intQK) & Chr(255) & strName
						End If
					End If
				Next intSite
			End If
		Next cnt
		'setup up checkboxes
		For cnt = 0 To 99
			chkQK(cnt).Text = CStr(cnt)
			If strQKArray(cnt) = "" Then
				chkQK(cnt).Font = VB6.FontChangeBold(chkQK(cnt).Font, False)
			Else
				chkQK(cnt).Font = VB6.FontChangeBold(chkQK(cnt).Font, True)
			End If
		Next cnt
		
		
	End Sub
	
	'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_WARNING: frmSysQK event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Form_Terminate_Renamed()
		Call cmdCancel_Click(cmdCancel, New System.EventArgs())
	End Sub
End Class