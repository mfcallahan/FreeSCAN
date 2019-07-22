<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmJust
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
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents _optJustSel_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optJustSel_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optJustSel_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optJustSel_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _optJust_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optJust_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optJust_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents optJust As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optJustSel As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJust))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me._optJustSel_3 = New System.Windows.Forms.RadioButton()
        Me._optJustSel_2 = New System.Windows.Forms.RadioButton()
        Me._optJustSel_1 = New System.Windows.Forms.RadioButton()
        Me._optJustSel_0 = New System.Windows.Forms.RadioButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._optJust_2 = New System.Windows.Forms.RadioButton()
        Me._optJust_1 = New System.Windows.Forms.RadioButton()
        Me._optJust_0 = New System.Windows.Forms.RadioButton()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.optJust = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optJustSel = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.optJust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optJustSel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(8, 232)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me._optJustSel_3)
        Me.Frame2.Controls.Add(Me._optJustSel_2)
        Me.Frame2.Controls.Add(Me._optJustSel_1)
        Me.Frame2.Controls.Add(Me._optJustSel_0)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 112)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(185, 101)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "What To Justify"
        '
        '_optJustSel_3
        '
        Me._optJustSel_3.BackColor = System.Drawing.SystemColors.Control
        Me._optJustSel_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._optJustSel_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optJustSel_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optJustSel.SetIndex(Me._optJustSel_3, CType(3, Short))
        Me._optJustSel_3.Location = New System.Drawing.Point(12, 72)
        Me._optJustSel_3.Name = "_optJustSel_3"
        Me._optJustSel_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optJustSel_3.Size = New System.Drawing.Size(145, 17)
        Me._optJustSel_3.TabIndex = 9
        Me._optJustSel_3.TabStop = True
        Me._optJustSel_3.Text = "&All Systems && Groups"
        Me._optJustSel_3.UseVisualStyleBackColor = False
        '
        '_optJustSel_2
        '
        Me._optJustSel_2.BackColor = System.Drawing.SystemColors.Control
        Me._optJustSel_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optJustSel_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optJustSel_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optJustSel.SetIndex(Me._optJustSel_2, CType(2, Short))
        Me._optJustSel_2.Location = New System.Drawing.Point(12, 50)
        Me._optJustSel_2.Name = "_optJustSel_2"
        Me._optJustSel_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optJustSel_2.Size = New System.Drawing.Size(109, 18)
        Me._optJustSel_2.TabIndex = 8
        Me._optJustSel_2.TabStop = True
        Me._optJustSel_2.Text = "This S&ystem"
        Me._optJustSel_2.UseVisualStyleBackColor = False
        '
        '_optJustSel_1
        '
        Me._optJustSel_1.BackColor = System.Drawing.SystemColors.Control
        Me._optJustSel_1.Checked = True
        Me._optJustSel_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optJustSel_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optJustSel_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optJustSel.SetIndex(Me._optJustSel_1, CType(1, Short))
        Me._optJustSel_1.Location = New System.Drawing.Point(12, 28)
        Me._optJustSel_1.Name = "_optJustSel_1"
        Me._optJustSel_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optJustSel_1.Size = New System.Drawing.Size(109, 19)
        Me._optJustSel_1.TabIndex = 7
        Me._optJustSel_1.TabStop = True
        Me._optJustSel_1.Text = "&This Group"
        Me._optJustSel_1.UseVisualStyleBackColor = False
        '
        '_optJustSel_0
        '
        Me._optJustSel_0.BackColor = System.Drawing.SystemColors.Control
        Me._optJustSel_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optJustSel_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optJustSel_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optJustSel.SetIndex(Me._optJustSel_0, CType(0, Short))
        Me._optJustSel_0.Location = New System.Drawing.Point(32, 108)
        Me._optJustSel_0.Name = "_optJustSel_0"
        Me._optJustSel_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optJustSel_0.Size = New System.Drawing.Size(109, 13)
        Me._optJustSel_0.TabIndex = 6
        Me._optJustSel_0.TabStop = True
        Me._optJustSel_0.Text = "&Selected Channels"
        Me._optJustSel_0.UseVisualStyleBackColor = False
        Me._optJustSel_0.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._optJust_2)
        Me.Frame1.Controls.Add(Me._optJust_1)
        Me.Frame1.Controls.Add(Me._optJust_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 4)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(185, 101)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Justify"
        '
        '_optJust_2
        '
        Me._optJust_2.BackColor = System.Drawing.SystemColors.Control
        Me._optJust_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optJust_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optJust_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optJust.SetIndex(Me._optJust_2, CType(2, Short))
        Me._optJust_2.Location = New System.Drawing.Point(12, 68)
        Me._optJust_2.Name = "_optJust_2"
        Me._optJust_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optJust_2.Size = New System.Drawing.Size(65, 17)
        Me._optJust_2.TabIndex = 4
        Me._optJust_2.TabStop = True
        Me._optJust_2.Text = "&Right"
        Me._optJust_2.UseVisualStyleBackColor = False
        '
        '_optJust_1
        '
        Me._optJust_1.BackColor = System.Drawing.SystemColors.Control
        Me._optJust_1.Checked = True
        Me._optJust_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optJust_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optJust_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optJust.SetIndex(Me._optJust_1, CType(1, Short))
        Me._optJust_1.Location = New System.Drawing.Point(12, 46)
        Me._optJust_1.Name = "_optJust_1"
        Me._optJust_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optJust_1.Size = New System.Drawing.Size(65, 17)
        Me._optJust_1.TabIndex = 3
        Me._optJust_1.TabStop = True
        Me._optJust_1.Text = "&Center"
        Me._optJust_1.UseVisualStyleBackColor = False
        '
        '_optJust_0
        '
        Me._optJust_0.BackColor = System.Drawing.SystemColors.Control
        Me._optJust_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optJust_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optJust_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optJust.SetIndex(Me._optJust_0, CType(0, Short))
        Me._optJust_0.Location = New System.Drawing.Point(12, 24)
        Me._optJust_0.Name = "_optJust_0"
        Me._optJust_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optJust_0.Size = New System.Drawing.Size(65, 17)
        Me._optJust_0.TabIndex = 2
        Me._optJust_0.TabStop = True
        Me._optJust_0.Text = "&Left"
        Me._optJust_0.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(112, 232)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(81, 25)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "&OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'frmJust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(204, 269)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdOK)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(184, 250)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJust"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Justify Channels"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.optJust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optJustSel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class