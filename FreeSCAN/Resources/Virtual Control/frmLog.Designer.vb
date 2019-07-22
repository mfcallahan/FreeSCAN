<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLog
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
    'Public CommonDialogSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents mnuLogClear As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLogExport As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLog As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mnuLinear = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PlaybackFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToIsolationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoscrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveClearAtMidnightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tabLog = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grdLog = New System.Windows.Forms.DataGridView()
        Me._tabLog_TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdSum = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdID = New System.Windows.Forms.DataGridView()
        Me.grdRadID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdID_TGID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdID_AlphaTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdID_Sys = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdID_Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdID_Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.grdSearch = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenLogFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdPlayAll = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlayAudio = New System.Windows.Forms.ToolStripButton()
        Me.cmdPauseAudio = New System.Windows.Forms.ToolStripButton()
        Me.cmdStopAudio = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRewind = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonFastForward = New System.Windows.Forms.ToolStripButton()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuLinear.SuspendLayout()
        Me.MainMenu1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.tabLog.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._tabLog_TabPage1.SuspendLayout()
        CType(Me.grdSum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.grdID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.grdSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuLinear
        '
        Me.mnuLinear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaybackFileToolStripMenuItem, Me.CopyToIsolationToolStripMenuItem, Me.ShowInExplorerToolStripMenuItem, Me.DeleteSelectedFilesToolStripMenuItem})
        Me.mnuLinear.Name = "mnuLinear"
        Me.mnuLinear.Size = New System.Drawing.Size(190, 114)
        '
        'PlaybackFileToolStripMenuItem
        '
        Me.PlaybackFileToolStripMenuItem.Image = CType(resources.GetObject("PlaybackFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlaybackFileToolStripMenuItem.Name = "PlaybackFileToolStripMenuItem"
        Me.PlaybackFileToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.PlaybackFileToolStripMenuItem.Text = "Playback Selection"
        '
        'CopyToIsolationToolStripMenuItem
        '
        Me.CopyToIsolationToolStripMenuItem.Name = "CopyToIsolationToolStripMenuItem"
        Me.CopyToIsolationToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CopyToIsolationToolStripMenuItem.Text = "Copy To Isolation"
        '
        'ShowInExplorerToolStripMenuItem
        '
        Me.ShowInExplorerToolStripMenuItem.Name = "ShowInExplorerToolStripMenuItem"
        Me.ShowInExplorerToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ShowInExplorerToolStripMenuItem.Text = "Show in Explorer"
        '
        'DeleteSelectedFilesToolStripMenuItem
        '
        Me.DeleteSelectedFilesToolStripMenuItem.Image = CType(resources.GetObject("DeleteSelectedFilesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteSelectedFilesToolStripMenuItem.Name = "DeleteSelectedFilesToolStripMenuItem"
        Me.DeleteSelectedFilesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.DeleteSelectedFilesToolStripMenuItem.Text = "Delete Selected Files..."
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLog})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.MainMenu1.Size = New System.Drawing.Size(885, 24)
        Me.MainMenu1.TabIndex = 2
        '
        'mnuLog
        '
        Me.mnuLog.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogOpen, Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem, Me.mnuLogExport, Me.AutoscrollToolStripMenuItem, Me.CopyToClipboardToolStripMenuItem, Me.SaveClearAtMidnightToolStripMenuItem, Me.mnuLogClear})
        Me.mnuLog.Name = "mnuLog"
        Me.mnuLog.Size = New System.Drawing.Size(39, 24)
        Me.mnuLog.Text = "&Log"
        '
        'mnuLogOpen
        '
        Me.mnuLogOpen.Name = "mnuLogOpen"
        Me.mnuLogOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuLogOpen.Size = New System.Drawing.Size(239, 22)
        Me.mnuLogOpen.Text = "&Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.OpenToolStripMenuItem.Text = "Save As..."
        '
        'mnuLogExport
        '
        Me.mnuLogExport.Name = "mnuLogExport"
        Me.mnuLogExport.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuLogExport.Size = New System.Drawing.Size(239, 22)
        Me.mnuLogExport.Text = "E&xport to CSV..."
        '
        'AutoscrollToolStripMenuItem
        '
        Me.AutoscrollToolStripMenuItem.Checked = True
        Me.AutoscrollToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoscrollToolStripMenuItem.Name = "AutoscrollToolStripMenuItem"
        Me.AutoscrollToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AutoscrollToolStripMenuItem.Text = "Autoscroll"
        '
        'CopyToClipboardToolStripMenuItem
        '
        Me.CopyToClipboardToolStripMenuItem.Name = "CopyToClipboardToolStripMenuItem"
        Me.CopyToClipboardToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.CopyToClipboardToolStripMenuItem.Text = "Copy to Clipboard"
        '
        'SaveClearAtMidnightToolStripMenuItem
        '
        Me.SaveClearAtMidnightToolStripMenuItem.Name = "SaveClearAtMidnightToolStripMenuItem"
        Me.SaveClearAtMidnightToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SaveClearAtMidnightToolStripMenuItem.Text = "Auto-Save && &Clear At Midnight"
        '
        'mnuLogClear
        '
        Me.mnuLogClear.Name = "mnuLogClear"
        Me.mnuLogClear.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuLogClear.Size = New System.Drawing.Size(239, 22)
        Me.mnuLogClear.Text = "C&lear..."
        '
        'SaveFileDialog1
        '
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label})
        Me.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip.Location = New System.Drawing.Point(0, 459)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(885, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'Label
        '
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(0, 17)
        '
        'tabLog
        '
        Me.tabLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabLog.Controls.Add(Me.TabPage2)
        Me.tabLog.Controls.Add(Me._tabLog_TabPage1)
        Me.tabLog.Controls.Add(Me.TabPage1)
        Me.tabLog.Controls.Add(Me.TabPage3)
        Me.tabLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabLog.ItemSize = New System.Drawing.Size(42, 18)
        Me.tabLog.Location = New System.Drawing.Point(3, 52)
        Me.tabLog.Multiline = True
        Me.tabLog.Name = "tabLog"
        Me.tabLog.SelectedIndex = 0
        Me.tabLog.Size = New System.Drawing.Size(879, 405)
        Me.tabLog.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdLog)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(871, 379)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Linear"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grdLog
        '
        Me.grdLog.AccessibleDescription = "Log View - Traditional"
        Me.grdLog.AllowUserToAddRows = False
        Me.grdLog.AllowUserToOrderColumns = True
        Me.grdLog.AllowUserToResizeRows = False
        Me.grdLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdLog.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Col1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column10})
        Me.grdLog.ContextMenuStrip = Me.mnuLinear
        Me.grdLog.Location = New System.Drawing.Point(0, 3)
        Me.grdLog.Name = "grdLog"
        Me.grdLog.ReadOnly = True
        Me.grdLog.RowHeadersVisible = False
        Me.grdLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLog.ShowCellErrors = False
        Me.grdLog.ShowCellToolTips = False
        Me.grdLog.ShowEditingIcon = False
        Me.grdLog.ShowRowErrors = False
        Me.grdLog.Size = New System.Drawing.Size(868, 374)
        Me.grdLog.TabIndex = 0
        '
        '_tabLog_TabPage1
        '
        Me._tabLog_TabPage1.Controls.Add(Me.grdSum)
        Me._tabLog_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._tabLog_TabPage1.Name = "_tabLog_TabPage1"
        Me._tabLog_TabPage1.Size = New System.Drawing.Size(871, 379)
        Me._tabLog_TabPage1.TabIndex = 1
        Me._tabLog_TabPage1.Text = "Review"
        Me._tabLog_TabPage1.UseVisualStyleBackColor = True
        '
        'grdSum
        '
        Me.grdSum.AccessibleDescription = "Log View - Summary"
        Me.grdSum.AllowUserToAddRows = False
        Me.grdSum.AllowUserToOrderColumns = True
        Me.grdSum.AllowUserToResizeRows = False
        Me.grdSum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdSum.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSum.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Count, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.grdSum.Location = New System.Drawing.Point(0, 3)
        Me.grdSum.Name = "grdSum"
        Me.grdSum.ReadOnly = True
        Me.grdSum.RowHeadersVisible = False
        Me.grdSum.ShowCellErrors = False
        Me.grdSum.ShowCellToolTips = False
        Me.grdSum.ShowEditingIcon = False
        Me.grdSum.ShowRowErrors = False
        Me.grdSum.Size = New System.Drawing.Size(870, 400)
        Me.grdSum.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 40
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Freq/TGID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tone/NAC"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'Count
        '
        Me.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Count.HeaderText = "Count"
        Me.Count.Name = "Count"
        Me.Count.ReadOnly = True
        Me.Count.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Avg RSSI"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 78
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 72
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "System"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 68
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.HeaderText = "Group"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grdID)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(871, 379)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Unit IDs"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grdID
        '
        Me.grdID.AccessibleDescription = ""
        Me.grdID.AccessibleName = "Conventional Channels"
        Me.grdID.AllowUserToAddRows = False
        Me.grdID.AllowUserToDeleteRows = False
        Me.grdID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grdID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdID.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdRadID, Me.grdID_TGID, Me.grdID_AlphaTag, Me.grdID_Sys, Me.grdID_Count, Me.grdID_Remark})
        Me.grdID.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdID.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.grdID.Location = New System.Drawing.Point(0, 3)
        Me.grdID.Name = "grdID"
        Me.grdID.RowHeadersVisible = False
        Me.grdID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdID.ShowCellToolTips = False
        Me.grdID.ShowEditingIcon = False
        Me.grdID.Size = New System.Drawing.Size(870, 398)
        Me.grdID.TabIndex = 268
        '
        'grdRadID
        '
        Me.grdRadID.HeaderText = "Radio ID"
        Me.grdRadID.MaxInputLength = 30
        Me.grdRadID.Name = "grdRadID"
        Me.grdRadID.ReadOnly = True
        Me.grdRadID.Width = 140
        '
        'grdID_TGID
        '
        Me.grdID_TGID.HeaderText = "TGID"
        Me.grdID_TGID.MaxInputLength = 30
        Me.grdID_TGID.Name = "grdID_TGID"
        Me.grdID_TGID.ReadOnly = True
        Me.grdID_TGID.Width = 80
        '
        'grdID_AlphaTag
        '
        Me.grdID_AlphaTag.HeaderText = "Alpha Tag"
        Me.grdID_AlphaTag.Name = "grdID_AlphaTag"
        Me.grdID_AlphaTag.ReadOnly = True
        Me.grdID_AlphaTag.Width = 140
        '
        'grdID_Sys
        '
        Me.grdID_Sys.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.grdID_Sys.HeaderText = "System / Group"
        Me.grdID_Sys.Name = "grdID_Sys"
        Me.grdID_Sys.ReadOnly = True
        Me.grdID_Sys.Width = 107
        '
        'grdID_Count
        '
        Me.grdID_Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.grdID_Count.HeaderText = "Count"
        Me.grdID_Count.Name = "grdID_Count"
        Me.grdID_Count.ReadOnly = True
        Me.grdID_Count.Width = 60
        '
        'grdID_Remark
        '
        Me.grdID_Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.grdID_Remark.HeaderText = "Remark"
        Me.grdID_Remark.MaxInputLength = 300
        Me.grdID_Remark.Name = "grdID_Remark"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmdSearch)
        Me.TabPage3.Controls.Add(Me.txtSearch)
        Me.TabPage3.Controls.Add(Me.grdSearch)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(871, 379)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Search"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(191, 10)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(81, 21)
        Me.cmdSearch.TabIndex = 3
        Me.cmdSearch.Text = "&Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.AccessibleDescription = "Enter text you wish to search for"
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearch.Location = New System.Drawing.Point(16, 11)
        Me.txtSearch.MaxLength = 32
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(168, 20)
        Me.txtSearch.TabIndex = 2
        '
        'grdSearch
        '
        Me.grdSearch.AccessibleDescription = "Log View - Traditional"
        Me.grdSearch.AllowUserToAddRows = False
        Me.grdSearch.AllowUserToOrderColumns = True
        Me.grdSearch.AllowUserToResizeRows = False
        Me.grdSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdSearch.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.grdSearch.ContextMenuStrip = Me.mnuLinear
        Me.grdSearch.Location = New System.Drawing.Point(2, 38)
        Me.grdSearch.Name = "grdSearch"
        Me.grdSearch.ReadOnly = True
        Me.grdSearch.RowHeadersVisible = False
        Me.grdSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSearch.ShowCellErrors = False
        Me.grdSearch.ShowCellToolTips = False
        Me.grdSearch.ShowEditingIcon = False
        Me.grdSearch.ShowRowErrors = False
        Me.grdSearch.Size = New System.Drawing.Size(867, 361)
        Me.grdSearch.TabIndex = 1
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.HeaderText = ""
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 40
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn11.HeaderText = "Freq/TGID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 80
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn12.HeaderText = "Tone/NAC"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 80
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn13.HeaderText = "RSSI"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 55
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn14.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 54
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn15.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 72
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn16.HeaderText = "System"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 68
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Group"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn17.Width = 62
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Unit ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 62
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.HeaderText = "Recorded File"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'SaveFileDialog2
        '
        '
        'OpenLogFileDialog1
        '
        Me.OpenLogFileDialog1.DefaultExt = "fslog"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPlayAll, Me.cmdPlayAudio, Me.cmdPauseAudio, Me.cmdStopAudio, Me.ToolStripButtonRewind, Me.ToolStripButtonFastForward})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(885, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdPlayAll
        '
        Me.cmdPlayAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPlayAll.Image = CType(resources.GetObject("cmdPlayAll.Image"), System.Drawing.Image)
        Me.cmdPlayAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPlayAll.Name = "cmdPlayAll"
        Me.cmdPlayAll.Size = New System.Drawing.Size(23, 22)
        Me.cmdPlayAll.Text = "Start playing at current position and play each file until the end is reached"
        '
        'cmdPlayAudio
        '
        Me.cmdPlayAudio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPlayAudio.Image = CType(resources.GetObject("cmdPlayAudio.Image"), System.Drawing.Image)
        Me.cmdPlayAudio.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.cmdPlayAudio.Name = "cmdPlayAudio"
        Me.cmdPlayAudio.Size = New System.Drawing.Size(23, 22)
        Me.cmdPlayAudio.Text = "Play the currently selected or paused file(s) only"
        '
        'cmdPauseAudio
        '
        Me.cmdPauseAudio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPauseAudio.Image = CType(resources.GetObject("cmdPauseAudio.Image"), System.Drawing.Image)
        Me.cmdPauseAudio.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.cmdPauseAudio.Name = "cmdPauseAudio"
        Me.cmdPauseAudio.Size = New System.Drawing.Size(23, 22)
        Me.cmdPauseAudio.Text = "Pause Playback"
        '
        'cmdStopAudio
        '
        Me.cmdStopAudio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdStopAudio.Image = CType(resources.GetObject("cmdStopAudio.Image"), System.Drawing.Image)
        Me.cmdStopAudio.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.cmdStopAudio.Name = "cmdStopAudio"
        Me.cmdStopAudio.Size = New System.Drawing.Size(23, 22)
        Me.cmdStopAudio.Text = "Stop Playback"
        '
        'ToolStripButtonRewind
        '
        Me.ToolStripButtonRewind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRewind.Image = CType(resources.GetObject("ToolStripButtonRewind.Image"), System.Drawing.Image)
        Me.ToolStripButtonRewind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRewind.Name = "ToolStripButtonRewind"
        Me.ToolStripButtonRewind.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonRewind.Text = "Replay current recording"
        '
        'ToolStripButtonFastForward
        '
        Me.ToolStripButtonFastForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFastForward.Image = CType(resources.GetObject("ToolStripButtonFastForward.Image"), System.Drawing.Image)
        Me.ToolStripButtonFastForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonFastForward.Name = "ToolStripButtonFastForward"
        Me.ToolStripButtonFastForward.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonFastForward.Text = "Skip to end of recording"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column8.HeaderText = ""
        Me.Column8.MinimumWidth = 40
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 40
        '
        'Col1
        '
        Me.Col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Col1.HeaderText = "Tag"
        Me.Col1.MinimumWidth = 150
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        Me.Col1.Width = 150
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.HeaderText = "Freq/TGID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "Tone/NAC"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column3.HeaderText = "RSSI"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 55
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.HeaderText = "Time"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 54
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.HeaderText = "Duration"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 72
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column6.HeaderText = "System"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 68
        '
        'Column7
        '
        Me.Column7.FillWeight = 250.0!
        Me.Column7.HeaderText = "Group"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column7.Width = 62
        '
        'Column9
        '
        Me.Column9.FillWeight = 150.0!
        Me.Column9.HeaderText = "Unit ID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 62
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Recorded File"
        Me.Column10.MinimumWidth = 300
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 300
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(885, 481)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.tabLog)
        Me.Controls.Add(Me.StatusStrip)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 57)
        Me.Name = "frmLog"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Log Viewer"
        Me.mnuLinear.ResumeLayout(False)
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.tabLog.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me._tabLog_TabPage1.ResumeLayout(False)
        CType(Me.grdSum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grdID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.grdSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CopyToClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLinear As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PlaybackFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Label As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents tabLog As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grdLog As System.Windows.Forms.DataGridView
    Public WithEvents _tabLog_TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grdSum As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grdID As System.Windows.Forms.DataGridView
    Friend WithEvents grdRadID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdID_TGID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdID_AlphaTag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdID_Sys As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdID_Count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdID_Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeleteSelectedFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToIsolationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoscrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents grdSearch As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenLogFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveClearAtMidnightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPlayAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPlayAudio As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPauseAudio As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdStopAudio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRewind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonFastForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents ShowInExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class