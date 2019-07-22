<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintWait
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdAbort As System.Windows.Forms.Button
	Public WithEvents lblPage As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintWait))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdAbort = New System.Windows.Forms.Button
		Me.lblPage = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Please Wait..."
		Me.ClientSize = New System.Drawing.Size(174, 74)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.Icon = CType(resources.GetObject("frmPrintWait.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmPrintWait"
		Me.cmdAbort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAbort.Text = "A&bort"
		Me.cmdAbort.Size = New System.Drawing.Size(69, 21)
		Me.cmdAbort.Location = New System.Drawing.Point(96, 40)
		Me.cmdAbort.TabIndex = 2
		Me.cmdAbort.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAbort.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAbort.CausesValidation = True
		Me.cmdAbort.Enabled = True
		Me.cmdAbort.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAbort.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAbort.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAbort.TabStop = True
		Me.cmdAbort.Name = "cmdAbort"
		Me.lblPage.Text = "lblPage"
		Me.lblPage.Size = New System.Drawing.Size(35, 13)
		Me.lblPage.Location = New System.Drawing.Point(84, 12)
		Me.lblPage.TabIndex = 1
		Me.lblPage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPage.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPage.BackColor = System.Drawing.SystemColors.Control
		Me.lblPage.Enabled = True
		Me.lblPage.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPage.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPage.UseMnemonic = True
		Me.lblPage.Visible = True
		Me.lblPage.AutoSize = True
		Me.lblPage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPage.Name = "lblPage"
		Me.Label1.Text = "Printing Page:"
		Me.Label1.Size = New System.Drawing.Size(97, 17)
		Me.Label1.Location = New System.Drawing.Point(12, 12)
		Me.Label1.TabIndex = 0
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(cmdAbort)
		Me.Controls.Add(lblPage)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class