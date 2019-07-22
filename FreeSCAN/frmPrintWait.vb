Option Strict Off
Option Explicit On
Friend Class frmPrintWait
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdAbort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAbort.Click
		blnAbortOp = True
	End Sub
End Class