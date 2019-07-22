<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFind
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
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents chkCase As System.Windows.Forms.CheckBox
	Public WithEvents _optDirection_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optDirection_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancelFind As System.Windows.Forms.Button
	Public WithEvents cmdFind As System.Windows.Forms.Button
	Public WithEvents txtSearchString As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents optDirection As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFind))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkCase = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._optDirection_1 = New System.Windows.Forms.RadioButton
        Me._optDirection_0 = New System.Windows.Forms.RadioButton
        Me.cmdCancelFind = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.txtSearchString = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.optDirection = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Frame1.SuspendLayout()
        CType(Me.optDirection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'chkCase
        '
        Me.chkCase.BackColor = System.Drawing.SystemColors.Control
        Me.chkCase.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCase.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCase.Location = New System.Drawing.Point(8, 72)
        Me.chkCase.Name = "chkCase"
        Me.chkCase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCase.Size = New System.Drawing.Size(113, 17)
        Me.chkCase.TabIndex = 7
        Me.chkCase.Text = "&Match Case"
        Me.chkCase.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._optDirection_1)
        Me.Frame1.Controls.Add(Me._optDirection_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(184, 72)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(145, 57)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Direction"
        Me.Frame1.Visible = False
        '
        '_optDirection_1
        '
        Me._optDirection_1.BackColor = System.Drawing.SystemColors.Control
        Me._optDirection_1.Checked = True
        Me._optDirection_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDirection_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDirection_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDirection.SetIndex(Me._optDirection_1, CType(1, Short))
        Me._optDirection_1.Location = New System.Drawing.Point(72, 24)
        Me._optDirection_1.Name = "_optDirection_1"
        Me._optDirection_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDirection_1.Size = New System.Drawing.Size(57, 17)
        Me._optDirection_1.TabIndex = 6
        Me._optDirection_1.TabStop = True
        Me._optDirection_1.Text = "&Down"
        Me._optDirection_1.UseVisualStyleBackColor = False
        '
        '_optDirection_0
        '
        Me._optDirection_0.BackColor = System.Drawing.SystemColors.Control
        Me._optDirection_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDirection_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDirection_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDirection.SetIndex(Me._optDirection_0, CType(0, Short))
        Me._optDirection_0.Location = New System.Drawing.Point(16, 24)
        Me._optDirection_0.Name = "_optDirection_0"
        Me._optDirection_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDirection_0.Size = New System.Drawing.Size(41, 17)
        Me._optDirection_0.TabIndex = 5
        Me._optDirection_0.TabStop = True
        Me._optDirection_0.Text = "&Up"
        Me._optDirection_0.UseVisualStyleBackColor = False
        '
        'cmdCancelFind
        '
        Me.cmdCancelFind.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelFind.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelFind.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelFind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelFind.Location = New System.Drawing.Point(336, 48)
        Me.cmdCancelFind.Name = "cmdCancelFind"
        Me.cmdCancelFind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelFind.Size = New System.Drawing.Size(89, 25)
        Me.cmdCancelFind.TabIndex = 3
        Me.cmdCancelFind.Text = "C&ancel"
        Me.cmdCancelFind.UseVisualStyleBackColor = True
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFind.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFind.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFind.Location = New System.Drawing.Point(336, 16)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFind.Size = New System.Drawing.Size(89, 25)
        Me.cmdFind.TabIndex = 2
        Me.cmdFind.Text = "&Find Next"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'txtSearchString
        '
        Me.txtSearchString.AcceptsReturn = True
        Me.txtSearchString.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearchString.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchString.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchString.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSearchString.Location = New System.Drawing.Point(8, 48)
        Me.txtSearchString.MaxLength = 255
        Me.txtSearchString.Name = "txtSearchString"
        Me.txtSearchString.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchString.Size = New System.Drawing.Size(305, 19)
        Me.txtSearchString.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(307, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the string you are looking for: (Channel name, frequency, TGID name, TGID o" & _
            "r comment)"
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(442, 149)
        Me.Controls.Add(Me.chkCase)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancelFind)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.txtSearchString)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFind"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find"
        Me.Frame1.ResumeLayout(False)
        CType(Me.optDirection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class