Option Strict Off
Option Explicit On
Friend Class frmNewSite
	Inherits System.Windows.Forms.Form
	
	Private Sub cmbsystype_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbsystype.DoubleClick
		Call cmdSelectSysType_Click(cmdSelectSysType, New System.EventArgs())
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		
		Me.Visible = False
        lblSiteNote.Enabled = True
        lblSiteNote.Activate()
        lblSiteNote.Activate()


    End Sub

    Private Sub cmdSelectSysType_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectSysType.Click

        ChosenSysType = cmbsystype.SelectedIndex + 1
        If ChosenSysType < 0 Then ChosenSysType = 0

        Me.Visible = False
        lblSiteNote.Enabled = True
        lblSiteNote.Activate()
        If lblSiteNote.WindowState = 1 Then
            lblSiteNote.WindowState = System.Windows.Forms.FormWindowState.Normal
        End If
        lblSiteNote.Activate()

        strSysname = MakeItKosher((txtSysName.Text))
        lblSiteNote.CreateNewSystem()
        ' Call frmSystemEditor.treeSystems_Click
    End Sub
	
	'UPGRADE_NOTE: Form_Initialize was upgraded to Form_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Form_Initialize_Renamed()
		'populate the combo box with system types
		Dim EndofList As Boolean
		Dim x As Integer
		If cmbsystype.Items.Count = 0 Then
			Do Until EndofList = True
				
				With cmbsystype
					If SysType(x, 0) <> "" Then .Items.Add(SysType(x, 0))
				End With
				x = x + 1
				If Len(SysType(x, 0)) = 0 Then EndofList = True
			Loop 
			cmbsystype.SelectedIndex = 0
		End If
        txtSysName.Focus()
	End Sub

    Private Sub txtSysName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSysName.TextChanged

    End Sub

End Class