Option Strict Off
Option Explicit On
Friend Class frmFav
	Inherits System.Windows.Forms.Form
	
	Sub initForm()
		'initialize the form for user edit
		lstFavs.Items.Clear()
		
		Dim intCnt As Integer
		'populate the list
		For intCnt = 1 To MaxFavs
            If strFavs(intCnt, 1) <> "" Then
                lstFavs.Items.Add((strFavs(intCnt, 3)))
            End If
        Next intCnt
		
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Visible = False
        lblSiteNote.Enabled = True
        lblSiteNote.DrawFavMenu()
        lblSiteNote.Activate()
	End Sub
	
	Private Sub cmdDeleteConvChan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteConvChan.Click
		If lstFavs.Items.Count = 0 Then Exit Sub
		If lstFavs.SelectedIndex = -1 Then
			MsgBox("Please select the favourite you would like to delete.")
			Exit Sub
		End If
		Dim intCnt, intFavID, intPos As Integer
		Dim strBuff As String
		'find the favourite that this ID belongs to
		For intCnt = 1 To MaxFavs
			
			If strFavs(intCnt, 1) <> "" Then
				intPos = intPos + 1
				If intPos = lstFavs.SelectedIndex + 1 Then
					intFavID = intCnt
					intCnt = MaxFavs
				End If
			End If
		Next intCnt
		
		strBuff = "Are you sure you want to delete " & strFavs(intFavID, 3) & " from your favourites?"
		intCnt = MsgBox(strBuff, MsgBoxStyle.YesNo + MsgBoxStyle.Question)
		'yes is 6
		If intCnt <> 6 Then Exit Sub
		'delete it
		For intCnt = 0 To 10
			
			strFavs(intFavID, intCnt) = ""
		Next intCnt
		Call initForm()
	End Sub
	
	Private Sub Command3_Click()
		
	End Sub
	
	Private Sub cmdMoveDown_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMoveDown.Click
		'moves a favourite up in the list
		If blnDebug = False Then On Error Resume Next
		If lstFavs.Items.Count = 0 Then Exit Sub
		If lstFavs.SelectedIndex = -1 Then
			MsgBox("Please select the favourite you would like to move.")
			Exit Sub
		End If
		Dim intParam, intCnt, intRow As Integer
        Dim intFavID(2) As Integer
        Dim intIndex(2) As Integer
        Dim x As Integer
		intRow = lstFavs.SelectedIndex + 1
		If intRow = lstFavs.Items.Count Then Exit Sub ' cant move bottom position bottom anymore
		'identify the owners of each ID
		For intCnt = 1 To MaxFavs
			
			If strFavs(intCnt, 1) <> "" Then
				
				x = x + 1
				
				If x = intRow Then
					
					intFavID(1) = intCnt
					intCnt = MaxFavs
				End If
			End If
		Next intCnt
		
		x = 0
		For intCnt = 1 To MaxFavs
			
			If strFavs(intCnt, 1) <> "" Then
				
				x = x + 1
				
				If x = intRow + 1 Then
					
					intFavID(2) = intCnt
				End If
			End If
		Next intCnt
		Call SwitchID(intFavID(2), intFavID(1))
		Call initForm()
		lstFavs.SelectedIndex = intRow
	End Sub
	
	Private Sub cmdMoveUp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMoveUp.Click
		'moves a favourite up in the list
		If blnDebug = False Then On Error Resume Next
		If lstFavs.Items.Count = 0 Then Exit Sub
		If lstFavs.SelectedIndex = -1 Then
			MsgBox("Please select the favourite you would like to move.")
			Exit Sub
		End If
		Dim intParam, intCnt, intRow As Integer
        Dim intFavID(2) As Integer
        Dim intIndex(2) As Integer
        Dim x As Integer
		intRow = lstFavs.SelectedIndex + 1
		If intRow = 1 Then Exit Sub ' cant move top position up anymore
		'identify the owners of each ID
		For intCnt = 1 To MaxFavs
			
			If strFavs(intCnt, 1) <> "" Then
				
				x = x + 1
				
				If x = intRow Then
					
					intFavID(1) = intCnt
					intCnt = MaxFavs
				End If
			End If
		Next intCnt
		
		x = 0
		For intCnt = 1 To MaxFavs
			
			If strFavs(intCnt, 1) <> "" Then
				
				x = x + 1
				
				If x = intRow - 1 Then
					
					intFavID(2) = intCnt
				End If
			End If
		Next intCnt
		Call SwitchID(intFavID(2), intFavID(1))
		Call initForm()
		lstFavs.SelectedIndex = intRow - 2
	End Sub
    Sub SwitchID(ByRef intID1 As Integer, ByRef intID2 As Integer)
        'switches two id's around
        Dim strBuff(10) As String
        Dim intCnt As Integer
        For intCnt = 0 To 10
            
            
            strBuff(intCnt) = strFavs(intID1, intCnt)
            
            
            
            
            strFavs(intID1, intCnt) = strFavs(intID2, intCnt)
            
            
            strFavs(intID2, intCnt) = strBuff(intCnt)
        Next intCnt


    End Sub
	
	Private Sub cmdRenameFav_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRenameFav.Click
		If lstFavs.Items.Count = 0 Then
			Exit Sub
		End If
		If lstFavs.SelectedIndex = -1 Then
			MsgBox("Please select the item you would like to rename.")
		End If
		Dim x, intRow, intFavID, intCnt As Integer
		Dim strBuff, strBuff1 As String
		intRow = lstFavs.SelectedIndex + 1
		'finds the owner
		x = 0
		For intCnt = 1 To MaxFavs
			
			If strFavs(intCnt, 1) <> "" Then
				x = x + 1
				If x = intRow Then
					intFavID = intCnt
				End If
			End If
		Next intCnt
		
		strBuff = strFavs(intFavID, 3) 'name
		strBuff1 = InputBox("Enter the new name", "Rename Favourite", strBuff)
		
		strBuff = MakeItKosherSilent(strBuff1, 3)
		If Len(strBuff) <> 0 Then
			
			strFavs(intFavID, 3) = strBuff
			strBuff = CStr(lstFavs.SelectedIndex)
			Call initForm()
			lstFavs.SelectedIndex = Val(strBuff)
		End If
		
	End Sub
	
	Private Sub cmdSort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSort.Click
		'sort the favourite list A-Z
        Dim i As Integer
        Dim intParam As Integer
        Dim j As Integer
		Dim best_value(10) As String
		Dim best_j As Integer
		'sort channel by frequency, ascending
		For i = 1 To MaxFavs - 1
			For intParam = 0 To 10
				
				
				best_value(intParam) = strFavs(i, intParam)
				best_j = i
			Next intParam
			For j = i + 1 To MaxFavs
				
				If strFavs(j, 3) < best_value(3) Then
                    For intParam = 0 To 10


                        best_value(intParam) = strFavs(j, intParam)
                    Next intParam
					best_j = j
				End If
			Next j
			For intParam = 0 To 10
				
				
				
				strFavs(best_j, intParam) = strFavs(i, intParam)
				
				
				strFavs(i, intParam) = best_value(intParam)
			Next intParam
			
		Next i
		Call initForm()
	End Sub
	
	'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_WARNING: frmFav event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Form_Terminate_Renamed()
		Call cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub
	
	Private Sub frmFav_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Call cmdClose_Click(cmdClose, New System.EventArgs())
	End Sub
End Class