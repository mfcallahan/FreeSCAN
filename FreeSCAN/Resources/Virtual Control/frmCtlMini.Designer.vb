<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCtlMini
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			Static fTerminateCalled As Boolean
			If Not fTerminateCalled Then
				Form_Terminate_renamed()
				fTerminateCalled = True
			End If
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdNothing As System.Windows.Forms.Button
	Public WithEvents _lblDisp_4 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_2 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_1 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_3 As System.Windows.Forms.Label
	Public WithEvents lblDisp As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCtlMini))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdNothing = New System.Windows.Forms.Button
		Me._lblDisp_4 = New System.Windows.Forms.Label
		Me._lblDisp_2 = New System.Windows.Forms.Label
		Me._lblDisp_1 = New System.Windows.Forms.Label
		Me._lblDisp_3 = New System.Windows.Forms.Label
		Me.lblDisp = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.lblDisp, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Text = "Mini Status"
		Me.ClientSize = New System.Drawing.Size(114, 86)
		Me.Location = New System.Drawing.Point(4, 22)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmCtlMini"
		Me.cmdNothing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNothing.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNothing.Text = "Command1"
		Me.cmdNothing.Size = New System.Drawing.Size(13, 16)
		Me.cmdNothing.Location = New System.Drawing.Point(9, 117)
		Me.cmdNothing.TabIndex = 4
		Me.cmdNothing.Visible = False
		Me.cmdNothing.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNothing.CausesValidation = True
		Me.cmdNothing.Enabled = True
		Me.cmdNothing.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNothing.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNothing.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNothing.TabStop = True
		Me.cmdNothing.Name = "cmdNothing"
		Me._lblDisp_4.Text = "Label3"
		Me._lblDisp_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblDisp_4.ForeColor = System.Drawing.Color.Black
		Me._lblDisp_4.Size = New System.Drawing.Size(32, 14)
		Me._lblDisp_4.Location = New System.Drawing.Point(3, 54)
		Me._lblDisp_4.TabIndex = 3
		Me._lblDisp_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblDisp_4.BackColor = System.Drawing.Color.Transparent
		Me._lblDisp_4.Enabled = True
		Me._lblDisp_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblDisp_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblDisp_4.UseMnemonic = True
		Me._lblDisp_4.Visible = True
		Me._lblDisp_4.AutoSize = True
		Me._lblDisp_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblDisp_4.Name = "_lblDisp_4"
		Me._lblDisp_2.Text = "Label3"
		Me._lblDisp_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblDisp_2.ForeColor = System.Drawing.Color.Black
		Me._lblDisp_2.Size = New System.Drawing.Size(32, 14)
		Me._lblDisp_2.Location = New System.Drawing.Point(3, 24)
		Me._lblDisp_2.TabIndex = 2
		Me._lblDisp_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblDisp_2.BackColor = System.Drawing.Color.Transparent
		Me._lblDisp_2.Enabled = True
		Me._lblDisp_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblDisp_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblDisp_2.UseMnemonic = True
		Me._lblDisp_2.Visible = True
		Me._lblDisp_2.AutoSize = True
		Me._lblDisp_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblDisp_2.Name = "_lblDisp_2"
		Me._lblDisp_1.Text = "Label3"
		Me._lblDisp_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblDisp_1.ForeColor = System.Drawing.Color.Black
		Me._lblDisp_1.Size = New System.Drawing.Size(32, 14)
		Me._lblDisp_1.Location = New System.Drawing.Point(3, 6)
		Me._lblDisp_1.TabIndex = 1
		Me._lblDisp_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblDisp_1.BackColor = System.Drawing.Color.Transparent
		Me._lblDisp_1.Enabled = True
		Me._lblDisp_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblDisp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblDisp_1.UseMnemonic = True
		Me._lblDisp_1.Visible = True
		Me._lblDisp_1.AutoSize = True
		Me._lblDisp_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblDisp_1.Name = "_lblDisp_1"
		Me._lblDisp_3.Text = "Label3"
		Me._lblDisp_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblDisp_3.ForeColor = System.Drawing.Color.Black
		Me._lblDisp_3.Size = New System.Drawing.Size(32, 14)
		Me._lblDisp_3.Location = New System.Drawing.Point(3, 39)
		Me._lblDisp_3.TabIndex = 0
		Me._lblDisp_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblDisp_3.BackColor = System.Drawing.Color.Transparent
		Me._lblDisp_3.Enabled = True
		Me._lblDisp_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblDisp_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblDisp_3.UseMnemonic = True
		Me._lblDisp_3.Visible = True
		Me._lblDisp_3.AutoSize = True
		Me._lblDisp_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblDisp_3.Name = "_lblDisp_3"
		Me.Controls.Add(cmdNothing)
		Me.Controls.Add(_lblDisp_4)
		Me.Controls.Add(_lblDisp_2)
		Me.Controls.Add(_lblDisp_1)
		Me.Controls.Add(_lblDisp_3)
		Me.lblDisp.SetIndex(_lblDisp_4, CType(4, Short))
		Me.lblDisp.SetIndex(_lblDisp_2, CType(2, Short))
		Me.lblDisp.SetIndex(_lblDisp_1, CType(1, Short))
		Me.lblDisp.SetIndex(_lblDisp_3, CType(3, Short))
		CType(Me.lblDisp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class