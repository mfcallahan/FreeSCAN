<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmParseTrunk
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
	Public WithEvents cmdClear As System.Windows.Forms.Button
    Public WithEvents chkDelete As System.Windows.Forms.CheckBox
    Public WithEvents cmdImportToSys As System.Windows.Forms.Button
	Public WithEvents _optDelimit_4 As System.Windows.Forms.RadioButton
	Public WithEvents txtDelimit As System.Windows.Forms.TextBox
	Public WithEvents _optDelimit_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optDelimit_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optDelimit_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optDelimit_0 As System.Windows.Forms.RadioButton
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdEZGrab As System.Windows.Forms.Button
'	Public WithEvents grdField As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents optDelimit As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParseTrunk))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.chkDelete = New System.Windows.Forms.CheckBox()
        Me.cmdImportToSys = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._optDelimit_4 = New System.Windows.Forms.RadioButton()
        Me.txtDelimit = New System.Windows.Forms.TextBox()
        Me._optDelimit_3 = New System.Windows.Forms.RadioButton()
        Me._optDelimit_2 = New System.Windows.Forms.RadioButton()
        Me._optDelimit_1 = New System.Windows.Forms.RadioButton()
        Me._optDelimit_0 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdEZGrab = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.optDelimit = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.grdField = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frame1.SuspendLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optDelimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(166, 248)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(97, 25)
        Me.cmdClear.TabIndex = 18
        Me.cmdClear.Text = "&Clear All"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'chkDelete
        '
        Me.chkDelete.BackColor = System.Drawing.SystemColors.Control
        Me.chkDelete.Checked = True
        Me.chkDelete.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDelete.Location = New System.Drawing.Point(20, 69)
        Me.chkDelete.Name = "chkDelete"
        Me.chkDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDelete.Size = New System.Drawing.Size(281, 17)
        Me.chkDelete.TabIndex = 11
        Me.chkDelete.Text = "Clear the &list every time I click on Copy From Clipboard"
        Me.chkDelete.UseVisualStyleBackColor = False
        '
        'cmdImportToSys
        '
        Me.cmdImportToSys.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImportToSys.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImportToSys.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportToSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImportToSys.Location = New System.Drawing.Point(317, 425)
        Me.cmdImportToSys.Name = "cmdImportToSys"
        Me.cmdImportToSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImportToSys.Size = New System.Drawing.Size(132, 25)
        Me.cmdImportToSys.TabIndex = 9
        Me.cmdImportToSys.Text = "&2. Import Into FreeSCAN"
        Me.cmdImportToSys.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._optDelimit_4)
        Me.Frame1.Controls.Add(Me.txtDelimit)
        Me.Frame1.Controls.Add(Me._optDelimit_3)
        Me.Frame1.Controls.Add(Me._optDelimit_2)
        Me.Frame1.Controls.Add(Me._optDelimit_1)
        Me.Frame1.Controls.Add(Me._optDelimit_0)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(9, 90)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(322, 128)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Delimiter"
        '
        '_optDelimit_4
        '
        Me._optDelimit_4.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_4, CType(4, Short))
        Me._optDelimit_4.Location = New System.Drawing.Point(12, 73)
        Me._optDelimit_4.Name = "_optDelimit_4"
        Me._optDelimit_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_4.Size = New System.Drawing.Size(117, 17)
        Me._optDelimit_4.TabIndex = 19
        Me._optDelimit_4.TabStop = True
        Me._optDelimit_4.Text = "Carriage Return"
        Me._optDelimit_4.UseVisualStyleBackColor = False
        '
        'txtDelimit
        '
        Me.txtDelimit.AcceptsReturn = True
        Me.txtDelimit.BackColor = System.Drawing.SystemColors.Window
        Me.txtDelimit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDelimit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelimit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDelimit.Location = New System.Drawing.Point(76, 92)
        Me.txtDelimit.MaxLength = 9
        Me.txtDelimit.Name = "txtDelimit"
        Me.txtDelimit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDelimit.Size = New System.Drawing.Size(73, 20)
        Me.txtDelimit.TabIndex = 7
        Me.txtDelimit.Text = " "
        '
        '_optDelimit_3
        '
        Me._optDelimit_3.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_3, CType(3, Short))
        Me._optDelimit_3.Location = New System.Drawing.Point(12, 92)
        Me._optDelimit_3.Name = "_optDelimit_3"
        Me._optDelimit_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_3.Size = New System.Drawing.Size(65, 17)
        Me._optDelimit_3.TabIndex = 6
        Me._optDelimit_3.TabStop = True
        Me._optDelimit_3.Text = "Custom"
        Me._optDelimit_3.UseVisualStyleBackColor = False
        '
        '_optDelimit_2
        '
        Me._optDelimit_2.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_2, CType(2, Short))
        Me._optDelimit_2.Location = New System.Drawing.Point(12, 54)
        Me._optDelimit_2.Name = "_optDelimit_2"
        Me._optDelimit_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_2.Size = New System.Drawing.Size(57, 17)
        Me._optDelimit_2.TabIndex = 5
        Me._optDelimit_2.TabStop = True
        Me._optDelimit_2.Text = "Space"
        Me._optDelimit_2.UseVisualStyleBackColor = False
        '
        '_optDelimit_1
        '
        Me._optDelimit_1.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_1, CType(1, Short))
        Me._optDelimit_1.Location = New System.Drawing.Point(12, 35)
        Me._optDelimit_1.Name = "_optDelimit_1"
        Me._optDelimit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_1.Size = New System.Drawing.Size(65, 17)
        Me._optDelimit_1.TabIndex = 4
        Me._optDelimit_1.TabStop = True
        Me._optDelimit_1.Text = "Comma"
        Me._optDelimit_1.UseVisualStyleBackColor = False
        '
        '_optDelimit_0
        '
        Me._optDelimit_0.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_0.Checked = True
        Me._optDelimit_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_0, CType(0, Short))
        Me._optDelimit_0.Location = New System.Drawing.Point(12, 16)
        Me._optDelimit_0.Name = "_optDelimit_0"
        Me._optDelimit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_0.Size = New System.Drawing.Size(89, 17)
        Me._optDelimit_0.TabIndex = 3
        Me._optDelimit_0.TabStop = True
        Me._optDelimit_0.Text = "Auto/Tab*"
        Me._optDelimit_0.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(172, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(118, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "*Recommended for RadioReference.com"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(317, 457)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(132, 25)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "3.           C&lose                "
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdEZGrab
        '
        Me.cmdEZGrab.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEZGrab.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEZGrab.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEZGrab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEZGrab.Location = New System.Drawing.Point(317, 393)
        Me.cmdEZGrab.Name = "cmdEZGrab"
        Me.cmdEZGrab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEZGrab.Size = New System.Drawing.Size(132, 25)
        Me.cmdEZGrab.TabIndex = 0
        Me.cmdEZGrab.Text = "&1. Copy From Clipboard"
        Me.cmdEZGrab.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(409, 33)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "To use it, neatly select a table from a website and copy to the clipboard. Then c" & _
            "lick on Copy From Clip Board, then click on Import Into FreeSCAN."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(116, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Frequencies Detected:"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(16, 16)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(400, 14)
        Me._Label1_0.TabIndex = 15
        Me._Label1_0.Text = "EZ-Grab is designed to import frequencies from a web site quickly and painlessly." & _
            ""
        '
        'grdField
        '
        Me.grdField.AccessibleDescription = ""
        Me.grdField.AllowUserToAddRows = False
        Me.grdField.AllowUserToOrderColumns = True
        Me.grdField.AllowUserToResizeColumns = False
        Me.grdField.AllowUserToResizeRows = False
        Me.grdField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdField.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdField.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1})
        Me.grdField.Location = New System.Drawing.Point(8, 247)
        Me.grdField.Name = "grdField"
        Me.grdField.ReadOnly = True
        Me.grdField.RowHeadersVisible = False
        Me.grdField.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdField.ShowCellErrors = False
        Me.grdField.ShowCellToolTips = False
        Me.grdField.ShowEditingIcon = False
        Me.grdField.ShowRowErrors = False
        Me.grdField.Size = New System.Drawing.Size(149, 238)
        Me.grdField.TabIndex = 41
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "LCN"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 40
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 68
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Freq"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 68
        '
        'frmParseTrunk
        '
        Me.AcceptButton = Me.cmdClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(462, 489)
        Me.Controls.Add(Me.chkDelete)
        Me.Controls.Add(Me.grdField)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdImportToSys)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdEZGrab)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParseTrunk"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EZ-Grab"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optDelimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdField As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region 
End Class