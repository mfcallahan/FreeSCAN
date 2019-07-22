<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDupeN_N
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDupeN_N))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdJump = New System.Windows.Forms.Button()
        Me.cmdNuke = New System.Windows.Forms.Button()
        Me.cmdCLose = New System.Windows.Forms.Button()
        Me.ChkConf = New System.Windows.Forms.CheckBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.chkPL = New System.Windows.Forms.CheckBox()
        Me.DupeGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frame1.SuspendLayout()
        CType(Me.DupeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdJump)
        Me.Frame1.Controls.Add(Me.cmdNuke)
        Me.Frame1.Controls.Add(Me.cmdCLose)
        Me.Frame1.Controls.Add(Me.ChkConf)
        Me.Frame1.Controls.Add(Me.cmdRefresh)
        Me.Frame1.Controls.Add(Me.chkPL)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 482)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(538, 88)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        '
        'cmdJump
        '
        Me.cmdJump.BackColor = System.Drawing.SystemColors.Control
        Me.cmdJump.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdJump.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJump.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdJump.Location = New System.Drawing.Point(6, 21)
        Me.cmdJump.Name = "cmdJump"
        Me.cmdJump.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdJump.Size = New System.Drawing.Size(105, 25)
        Me.cmdJump.TabIndex = 8
        Me.cmdJump.Text = "&Jump To"
        Me.cmdJump.UseVisualStyleBackColor = True
        '
        'cmdNuke
        '
        Me.cmdNuke.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNuke.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNuke.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuke.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNuke.Location = New System.Drawing.Point(6, 54)
        Me.cmdNuke.Name = "cmdNuke"
        Me.cmdNuke.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNuke.Size = New System.Drawing.Size(105, 25)
        Me.cmdNuke.TabIndex = 7
        Me.cmdNuke.Text = "&Delete Selected..."
        Me.cmdNuke.UseVisualStyleBackColor = True
        '
        'cmdCLose
        '
        Me.cmdCLose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCLose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCLose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCLose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCLose.Location = New System.Drawing.Point(426, 56)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCLose.Size = New System.Drawing.Size(105, 25)
        Me.cmdCLose.TabIndex = 6
        Me.cmdCLose.Text = "C&lose"
        Me.cmdCLose.UseVisualStyleBackColor = True
        '
        'ChkConf
        '
        Me.ChkConf.BackColor = System.Drawing.SystemColors.Control
        Me.ChkConf.Checked = True
        Me.ChkConf.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkConf.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkConf.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkConf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkConf.Location = New System.Drawing.Point(231, 39)
        Me.ChkConf.Name = "ChkConf"
        Me.ChkConf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkConf.Size = New System.Drawing.Size(133, 17)
        Me.ChkConf.TabIndex = 5
        Me.ChkConf.Text = "Delete &Confirmation"
        Me.ChkConf.UseVisualStyleBackColor = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(118, 21)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(105, 25)
        Me.cmdRefresh.TabIndex = 4
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'chkPL
        '
        Me.chkPL.BackColor = System.Drawing.SystemColors.Control
        Me.chkPL.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPL.Location = New System.Drawing.Point(231, 18)
        Me.chkPL.Name = "chkPL"
        Me.chkPL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPL.Size = New System.Drawing.Size(225, 21)
        Me.chkPL.TabIndex = 3
        Me.chkPL.Text = "D&on't count channels with unique PL tones"
        Me.chkPL.UseVisualStyleBackColor = False
        '
        'DupeGrid
        '
        Me.DupeGrid.AccessibleDescription = ""
        Me.DupeGrid.AllowUserToAddRows = False
        Me.DupeGrid.AllowUserToOrderColumns = True
        Me.DupeGrid.AllowUserToResizeColumns = False
        Me.DupeGrid.AllowUserToResizeRows = False
        Me.DupeGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DupeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DupeGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.DupeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DupeGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DupeGrid.Location = New System.Drawing.Point(10, 12)
        Me.DupeGrid.Name = "DupeGrid"
        Me.DupeGrid.ReadOnly = True
        Me.DupeGrid.RowHeadersVisible = False
        Me.DupeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DupeGrid.ShowCellErrors = False
        Me.DupeGrid.ShowCellToolTips = False
        Me.DupeGrid.ShowEditingIcon = False
        Me.DupeGrid.ShowRowErrors = False
        Me.DupeGrid.Size = New System.Drawing.Size(534, 459)
        Me.DupeGrid.TabIndex = 3
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
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Freq/TGID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 65
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 38
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "System"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 47
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.HeaderText = "Group"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmDupeN_N
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 578)
        Me.Controls.Add(Me.DupeGrid)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDupeN_N"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Duplicate Channel Finder"
        Me.Frame1.ResumeLayout(False)
        CType(Me.DupeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdJump As System.Windows.Forms.Button
    Public WithEvents cmdNuke As System.Windows.Forms.Button
    Public WithEvents cmdCLose As System.Windows.Forms.Button
    Public WithEvents ChkConf As System.Windows.Forms.CheckBox
    Public WithEvents cmdRefresh As System.Windows.Forms.Button
    Public WithEvents chkPL As System.Windows.Forms.CheckBox
    Public WithEvents cmdAutoNuke As System.Windows.Forms.Button
    Friend WithEvents DupeGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
