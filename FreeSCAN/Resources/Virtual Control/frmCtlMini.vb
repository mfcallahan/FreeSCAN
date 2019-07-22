Option Strict Off
Option Explicit On
Friend Class frmCtlMini
	Inherits System.Windows.Forms.Form
	
	Dim strFontName As String
	Dim intFontSize As Integer
	Dim blnFontItalic As Boolean
	Dim blnFontBold, blnFontUl As Boolean
	Dim strGrd As String
	Dim dblFontColour As Double
	Dim intKeyHold(100) As Integer
	Dim blnBusy As Boolean
	Dim intCycle As Integer
	Dim intKeyID As Integer
	Dim dblLastJump As Double ' last frequnecy jumped to
    Dim strTimeoutTitle As String
	
	Sub DrawWin()
		'begin label
		
		If blnDebug = False Then On Error Resume Next
		Dim intCtl1, intCtl, intCnt As Integer
        Dim strBuff As String
		Dim blnTGID As Boolean
		
		For intCtl = 1 To 4
            If strDisplay(32) = "1" And intCtl = 1 And instr(strDisplay(1), "PRI") = 0 Then 'global pri mode on
                strDisplay(1) = strDisplay(1) & "PRI "
            End If
            If intCtl = 4 And strDisplay(30) = "1" Then 'channel pri mode
                strDisplay(4) = strDisplay(4) & " PRI"
            End If
            lblDisp(intCtl).Text = strDisplay(intCtl + 1)
            If instr(strDisplay(intCtl + 9), "*") Then
                lblDisp(intCtl).Font = VB6.FontChangeBold(lblDisp(intCtl).Font, True)
            Else
                lblDisp(intCtl).Font = VB6.FontChangeBold(lblDisp(intCtl).Font, False)
            End If
			
			
		Next intCtl
		
		'lblDisp(7).Caption = strDisplay(31)
		
		strBuff = strRxSta(1)
		If Len(strBuff) = 8 Then
			For intCnt = 1 To 8
				
				If IsNumeric(Mid(strBuff, intCnt, 1)) = False Then
					blnTGID = True
				End If
			Next intCnt
		Else
			blnTGID = True
		End If
		
		If strRxSta(7) <> "" Then
			If Me.Text <> strRxSta(7) Then
				Me.Text = strRxSta(7)
			End If
		ElseIf Len(strRxSta(1)) > 1 Then 
			
			strBuff = strRxSta(1)
			
			strBuff = Val(strBuff) / 10000
			
            strBuff = Format(strBuff, "###0.0000") & "MHz"
			
			If Me.Text <> strBuff Then
				
				Me.Text = strBuff
			End If
		Else
			If Me.Text <> "FreeSCAN" Then
				Me.Text = "FreeSCAN"
			End If
		End If
		
	End Sub
	Private Sub Timer1_Timer()
		
	End Sub
	
	Private Sub frmCtlMini_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If blnDebug = False Then On Error Resume Next
		Dim intCnt As Integer
		lblDisp(1).ForeColor = cmdNothing.BackColor
		lblDisp(2).ForeColor = cmdNothing.BackColor
		lblDisp(3).ForeColor = cmdNothing.BackColor
		lblDisp(4).ForeColor = cmdNothing.BackColor
		
	End Sub
	
	'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	'UPGRADE_WARNING: frmCtlMini event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Form_Terminate_Renamed()
		'Call cmdClose_Click
	End Sub
End Class