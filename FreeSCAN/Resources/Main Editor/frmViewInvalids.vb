Option Strict Off
Option Explicit On
Friend Class frmViewInvalids
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Visible = False
	End Sub
End Class