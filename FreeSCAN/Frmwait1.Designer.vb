<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWaitXP
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
	Public WithEvents Pic1 As System.Windows.Forms.PictureBox
	Public WithEvents Pic0 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWaitXP))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Pic1 = New System.Windows.Forms.PictureBox
		Me.Pic0 = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Text = "Please wait..."
		Me.ClientSize = New System.Drawing.Size(194, 84)
		Me.Location = New System.Drawing.Point(3, 19)
		Me.ForeColor = System.Drawing.Color.White
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmWaitXP"
		Me.Pic1.BackColor = System.Drawing.Color.White
		Me.Pic1.ForeColor = System.Drawing.Color.White
		Me.Pic1.Size = New System.Drawing.Size(169, 97)
		Me.Pic1.Location = New System.Drawing.Point(0, 0)
		Me.Pic1.Image = CType(resources.GetObject("Pic1.Image"), System.Drawing.Image)
		Me.Pic1.TabIndex = 1
		Me.Pic1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pic1.Dock = System.Windows.Forms.DockStyle.None
		Me.Pic1.CausesValidation = True
		Me.Pic1.Enabled = True
		Me.Pic1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Pic1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Pic1.TabStop = True
		Me.Pic1.Visible = True
		Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Pic1.Name = "Pic1"
		Me.Pic0.BackColor = System.Drawing.Color.White
		Me.Pic0.ForeColor = System.Drawing.Color.White
		Me.Pic0.Size = New System.Drawing.Size(197, 89)
		Me.Pic0.Location = New System.Drawing.Point(0, 0)
		Me.Pic0.Image = CType(resources.GetObject("Pic0.Image"), System.Drawing.Image)
		Me.Pic0.TabIndex = 0
		Me.Pic0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pic0.Dock = System.Windows.Forms.DockStyle.None
		Me.Pic0.CausesValidation = True
		Me.Pic0.Enabled = True
		Me.Pic0.Cursor = System.Windows.Forms.Cursors.Default
		Me.Pic0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Pic0.TabStop = True
		Me.Pic0.Visible = True
		Me.Pic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Pic0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Pic0.Name = "Pic0"
		Me.Controls.Add(Pic1)
		Me.Controls.Add(Pic0)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class