<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLockout
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
	Public WithEvents cmdNuke As System.Windows.Forms.Button
	Public WithEvents _optMode_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optMode_0 As System.Windows.Forms.RadioButton
	Public WithEvents ChkConf As System.Windows.Forms.CheckBox
	Public WithEvents cmdUnlock As System.Windows.Forms.Button
	Public WithEvents cmdBulkClear As System.Windows.Forms.Button
	Public WithEvents cmdRefresh As System.Windows.Forms.Button
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
'    Public WithEvents grdLO As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents optMode As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLockout))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdNuke = New System.Windows.Forms.Button()
        Me._optMode_1 = New System.Windows.Forms.RadioButton()
        Me._optMode_0 = New System.Windows.Forms.RadioButton()
        Me.ChkConf = New System.Windows.Forms.CheckBox()
        Me.cmdUnlock = New System.Windows.Forms.Button()
        Me.cmdBulkClear = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optMode = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.grdLO = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frame1.SuspendLayout()
        CType(Me.optMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdLO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdNuke)
        Me.Frame1.Controls.Add(Me._optMode_1)
        Me.Frame1.Controls.Add(Me._optMode_0)
        Me.Frame1.Controls.Add(Me.ChkConf)
        Me.Frame1.Controls.Add(Me.cmdUnlock)
        Me.Frame1.Controls.Add(Me.cmdBulkClear)
        Me.Frame1.Controls.Add(Me.cmdRefresh)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(9, 414)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(541, 100)
        Me.Frame1.TabIndex = 8
        Me.Frame1.TabStop = False
        '
        'cmdNuke
        '
        Me.cmdNuke.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNuke.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNuke.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuke.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNuke.Location = New System.Drawing.Point(429, 63)
        Me.cmdNuke.Name = "cmdNuke"
        Me.cmdNuke.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNuke.Size = New System.Drawing.Size(105, 25)
        Me.cmdNuke.TabIndex = 7
        Me.cmdNuke.Text = "&Delete Selected..."
        Me.cmdNuke.UseVisualStyleBackColor = True
        '
        '_optMode_1
        '
        Me._optMode_1.BackColor = System.Drawing.SystemColors.Control
        Me._optMode_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optMode_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optMode_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMode.SetIndex(Me._optMode_1, CType(1, Short))
        Me._optMode_1.Location = New System.Drawing.Point(22, 53)
        Me._optMode_1.Name = "_optMode_1"
        Me._optMode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optMode_1.Size = New System.Drawing.Size(129, 19)
        Me._optMode_1.TabIndex = 2
        Me._optMode_1.TabStop = True
        Me._optMode_1.Text = "&Trunked Systems"
        Me._optMode_1.UseVisualStyleBackColor = True
        '
        '_optMode_0
        '
        Me._optMode_0.BackColor = System.Drawing.SystemColors.Control
        Me._optMode_0.Checked = True
        Me._optMode_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optMode_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optMode_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMode.SetIndex(Me._optMode_0, CType(0, Short))
        Me._optMode_0.Location = New System.Drawing.Point(23, 33)
        Me._optMode_0.Name = "_optMode_0"
        Me._optMode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optMode_0.Size = New System.Drawing.Size(129, 17)
        Me._optMode_0.TabIndex = 1
        Me._optMode_0.TabStop = True
        Me._optMode_0.Text = "&Conventional Channels"
        Me._optMode_0.UseVisualStyleBackColor = True
        '
        'ChkConf
        '
        Me.ChkConf.BackColor = System.Drawing.SystemColors.Control
        Me.ChkConf.Checked = True
        Me.ChkConf.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkConf.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkConf.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkConf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkConf.Location = New System.Drawing.Point(21, 76)
        Me.ChkConf.Name = "ChkConf"
        Me.ChkConf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkConf.Size = New System.Drawing.Size(133, 17)
        Me.ChkConf.TabIndex = 3
        Me.ChkConf.Text = "Delete &Confirmation"
        Me.ChkConf.UseVisualStyleBackColor = True
        '
        'cmdUnlock
        '
        Me.cmdUnlock.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUnlock.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUnlock.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUnlock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUnlock.Location = New System.Drawing.Point(429, 39)
        Me.cmdUnlock.Name = "cmdUnlock"
        Me.cmdUnlock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUnlock.Size = New System.Drawing.Size(105, 25)
        Me.cmdUnlock.TabIndex = 6
        Me.cmdUnlock.Text = "&Unlock"
        Me.cmdUnlock.UseVisualStyleBackColor = True
        '
        'cmdBulkClear
        '
        Me.cmdBulkClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBulkClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBulkClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBulkClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBulkClear.Location = New System.Drawing.Point(429, 15)
        Me.cmdBulkClear.Name = "cmdBulkClear"
        Me.cmdBulkClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBulkClear.Size = New System.Drawing.Size(105, 25)
        Me.cmdBulkClear.TabIndex = 5
        Me.cmdBulkClear.Text = "Unlock &All..."
        Me.cmdBulkClear.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(325, 15)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(105, 25)
        Me.cmdRefresh.TabIndex = 4
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(181, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Search Mode:"
        '
        'grdLO
        '
        Me.grdLO.AccessibleDescription = ""
        Me.grdLO.AllowUserToAddRows = False
        Me.grdLO.AllowUserToOrderColumns = True
        Me.grdLO.AllowUserToResizeColumns = False
        Me.grdLO.AllowUserToResizeRows = False
        Me.grdLO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdLO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdLO.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.grdLO.Location = New System.Drawing.Point(11, 10)
        Me.grdLO.Name = "grdLO"
        Me.grdLO.ReadOnly = True
        Me.grdLO.RowHeadersVisible = False
        Me.grdLO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLO.ShowCellErrors = False
        Me.grdLO.ShowCellToolTips = False
        Me.grdLO.ShowEditingIcon = False
        Me.grdLO.ShowRowErrors = False
        Me.grdLO.Size = New System.Drawing.Size(536, 404)
        Me.grdLO.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 40
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Systen"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Group"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 43
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 30
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Channel"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 52
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.HeaderText = "L/O"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmLockout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(560, 522)
        Me.Controls.Add(Me.grdLO)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmLockout"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Channel Lockout Manager"
        Me.Frame1.ResumeLayout(False)
        CType(Me.optMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdLO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdLO As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class