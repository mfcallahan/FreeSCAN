<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConsole
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
	Public WithEvents lstErr As System.Windows.Forms.ListBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsole))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lstErr = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstErr
        '
        Me.lstErr.BackColor = System.Drawing.SystemColors.Window
        Me.lstErr.CausesValidation = False
        Me.lstErr.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstErr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstErr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstErr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstErr.IntegralHeight = False
        Me.lstErr.ItemHeight = 14
        Me.lstErr.Location = New System.Drawing.Point(0, 0)
        Me.lstErr.Name = "lstErr"
        Me.lstErr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstErr.Size = New System.Drawing.Size(336, 194)
        Me.lstErr.TabIndex = 0
        Me.lstErr.TabStop = False
        '
        'frmConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(336, 194)
        Me.Controls.Add(Me.lstErr)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 25)
        Me.Name = "frmConsole"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Comm Log"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class