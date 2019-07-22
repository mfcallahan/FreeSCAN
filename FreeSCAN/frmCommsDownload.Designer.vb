<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCommsDownload
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
	Public WithEvents _Label9_0 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents _Label9_2 As System.Windows.Forms.Label
	Public WithEvents lblSystemsFound As System.Windows.Forms.Label
	Public WithEvents lblGroupsFound As System.Windows.Forms.Label
	Public WithEvents lblChannelsFound As System.Windows.Forms.Label
	Public WithEvents lblErr As System.Windows.Forms.Label
	Public WithEvents imgIOState As System.Windows.Forms.PictureBox
	Public WithEvents lblOp As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdFlash As System.Windows.Forms.Button
	Public WithEvents chkSysQK As System.Windows.Forms.CheckBox
	Public WithEvents chkDownloadCustomSettings As System.Windows.Forms.CheckBox
	Public WithEvents chkDownloadCustomSearch As System.Windows.Forms.CheckBox
	Public WithEvents chkResume As System.Windows.Forms.CheckBox
    Public WithEvents chkClearMemory As System.Windows.Forms.CheckBox
	Public WithEvents cmdQueueSystems As System.Windows.Forms.Button
	Public WithEvents cmdClearAllSys As System.Windows.Forms.Button
	Public WithEvents cmdChkAllSys As System.Windows.Forms.Button
	Public WithEvents lstSystems As System.Windows.Forms.CheckedListBox
    Public WithEvents lblSystemsUpload As System.Windows.Forms.Label
	Public WithEvents frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _imgIO_6 As System.Windows.Forms.PictureBox
	Public WithEvents _imgIO_5 As System.Windows.Forms.PictureBox
	Public WithEvents _imgIO_0 As System.Windows.Forms.PictureBox
	Public WithEvents _imgIO_1 As System.Windows.Forms.PictureBox
	Public WithEvents _imgIO_3 As System.Windows.Forms.PictureBox
	Public WithEvents _imgIO_2 As System.Windows.Forms.PictureBox
	Public WithEvents _imgIO_4 As System.Windows.Forms.PictureBox
	Public WithEvents Label9 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents imgIO As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents mnuScannerQKEdit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuScannerCOMPort As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAbort As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCopyLog As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuScanner As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommsDownload))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkResume = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._Label9_0 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Label9_2 = New System.Windows.Forms.Label()
        Me.lblSystemsFound = New System.Windows.Forms.Label()
        Me.lblGroupsFound = New System.Windows.Forms.Label()
        Me.lblChannelsFound = New System.Windows.Forms.Label()
        Me.lblErr = New System.Windows.Forms.Label()
        Me.imgIOState = New System.Windows.Forms.PictureBox()
        Me.lblOp = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.frame2 = New System.Windows.Forms.GroupBox()
        Me.cmdSetupCom = New System.Windows.Forms.Button()
        Me.cmdFlash = New System.Windows.Forms.Button()
        Me.chkSysQK = New System.Windows.Forms.CheckBox()
        Me.chkDownloadCustomSettings = New System.Windows.Forms.CheckBox()
        Me.chkDownloadCustomSearch = New System.Windows.Forms.CheckBox()
        Me.chkClearMemory = New System.Windows.Forms.CheckBox()
        Me.cmdQueueSystems = New System.Windows.Forms.Button()
        Me.cmdClearAllSys = New System.Windows.Forms.Button()
        Me.cmdChkAllSys = New System.Windows.Forms.Button()
        Me.lstSystems = New System.Windows.Forms.CheckedListBox()
        Me.lblSystemsUpload = New System.Windows.Forms.Label()
        Me._imgIO_6 = New System.Windows.Forms.PictureBox()
        Me._imgIO_5 = New System.Windows.Forms.PictureBox()
        Me._imgIO_0 = New System.Windows.Forms.PictureBox()
        Me._imgIO_1 = New System.Windows.Forms.PictureBox()
        Me._imgIO_3 = New System.Windows.Forms.PictureBox()
        Me._imgIO_2 = New System.Windows.Forms.PictureBox()
        Me._imgIO_4 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.imgIO = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuScanner = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScannerQKEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoSortSystemListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScannerCOMPort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAbortDownload = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        CType(Me.imgIOState, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frame2.SuspendLayout()
        CType(Me._imgIO_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgIO_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgIO_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgIO_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgIO_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgIO_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgIO_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkResume
        '
        Me.chkResume.BackColor = System.Drawing.SystemColors.Control
        Me.chkResume.Checked = True
        Me.chkResume.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkResume.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkResume.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResume.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkResume.Location = New System.Drawing.Point(253, 46)
        Me.chkResume.Name = "chkResume"
        Me.chkResume.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkResume.Size = New System.Drawing.Size(197, 17)
        Me.chkResume.TabIndex = 2
        Me.chkResume.Text = "&Automatically resume scanning"
        Me.ToolTip1.SetToolTip(Me.chkResume, "Leave this unchecked if you want the scanner to be left in Hold mode")
        Me.chkResume.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._Label9_0)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me._Label9_2)
        Me.Frame1.Controls.Add(Me.lblSystemsFound)
        Me.Frame1.Controls.Add(Me.lblGroupsFound)
        Me.Frame1.Controls.Add(Me.lblChannelsFound)
        Me.Frame1.Controls.Add(Me.lblErr)
        Me.Frame1.Controls.Add(Me.imgIOState)
        Me.Frame1.Controls.Add(Me.lblOp)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(10, 270)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(468, 101)
        Me.Frame1.TabIndex = 16
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Download Status"
        '
        '_Label9_0
        '
        Me._Label9_0.AutoSize = True
        Me._Label9_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label9_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label9_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label9_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.SetIndex(Me._Label9_0, CType(0, Short))
        Me._Label9_0.Location = New System.Drawing.Point(36, 48)
        Me._Label9_0.Name = "_Label9_0"
        Me._Label9_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label9_0.Size = New System.Drawing.Size(52, 14)
        Me._Label9_0.TabIndex = 25
        Me._Label9_0.Text = "Channels"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(36, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(43, 14)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Groups"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(36, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Systems"
        '
        '_Label9_2
        '
        Me._Label9_2.AutoSize = True
        Me._Label9_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label9_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label9_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label9_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.SetIndex(Me._Label9_2, CType(2, Short))
        Me._Label9_2.Location = New System.Drawing.Point(207, 21)
        Me._Label9_2.Name = "_Label9_2"
        Me._Label9_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label9_2.Size = New System.Drawing.Size(37, 14)
        Me._Label9_2.TabIndex = 22
        Me._Label9_2.Text = "Errors"
        '
        'lblSystemsFound
        '
        Me.lblSystemsFound.AutoSize = True
        Me.lblSystemsFound.BackColor = System.Drawing.SystemColors.Control
        Me.lblSystemsFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSystemsFound.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemsFound.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSystemsFound.Location = New System.Drawing.Point(93, 18)
        Me.lblSystemsFound.Name = "lblSystemsFound"
        Me.lblSystemsFound.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSystemsFound.Size = New System.Drawing.Size(13, 14)
        Me.lblSystemsFound.TabIndex = 21
        Me.lblSystemsFound.Text = "0"
        '
        'lblGroupsFound
        '
        Me.lblGroupsFound.AutoSize = True
        Me.lblGroupsFound.BackColor = System.Drawing.SystemColors.Control
        Me.lblGroupsFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroupsFound.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupsFound.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGroupsFound.Location = New System.Drawing.Point(93, 33)
        Me.lblGroupsFound.Name = "lblGroupsFound"
        Me.lblGroupsFound.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroupsFound.Size = New System.Drawing.Size(13, 14)
        Me.lblGroupsFound.TabIndex = 20
        Me.lblGroupsFound.Text = "0"
        '
        'lblChannelsFound
        '
        Me.lblChannelsFound.AutoSize = True
        Me.lblChannelsFound.BackColor = System.Drawing.SystemColors.Control
        Me.lblChannelsFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChannelsFound.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChannelsFound.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChannelsFound.Location = New System.Drawing.Point(93, 48)
        Me.lblChannelsFound.Name = "lblChannelsFound"
        Me.lblChannelsFound.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChannelsFound.Size = New System.Drawing.Size(13, 14)
        Me.lblChannelsFound.TabIndex = 19
        Me.lblChannelsFound.Text = "0"
        '
        'lblErr
        '
        Me.lblErr.AutoSize = True
        Me.lblErr.BackColor = System.Drawing.SystemColors.Control
        Me.lblErr.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblErr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErr.ForeColor = System.Drawing.Color.Blue
        Me.lblErr.Location = New System.Drawing.Point(261, 21)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblErr.Size = New System.Drawing.Size(13, 14)
        Me.lblErr.TabIndex = 18
        Me.lblErr.Text = "0"
        '
        'imgIOState
        '
        Me.imgIOState.BackColor = System.Drawing.Color.Transparent
        Me.imgIOState.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgIOState.Image = CType(resources.GetObject("imgIOState.Image"), System.Drawing.Image)
        Me.imgIOState.Location = New System.Drawing.Point(345, 18)
        Me.imgIOState.Name = "imgIOState"
        Me.imgIOState.Size = New System.Drawing.Size(110, 67)
        Me.imgIOState.TabIndex = 26
        Me.imgIOState.TabStop = False
        '
        'lblOp
        '
        Me.lblOp.AutoSize = True
        Me.lblOp.BackColor = System.Drawing.SystemColors.Control
        Me.lblOp.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOp.Location = New System.Drawing.Point(9, 75)
        Me.lblOp.Name = "lblOp"
        Me.lblOp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOp.Size = New System.Drawing.Size(76, 14)
        Me.lblOp.TabIndex = 17
        Me.lblOp.Text = "Standing By...."
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(370, 378)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(105, 25)
        Me.cmdClose.TabIndex = 13
        Me.cmdClose.Text = "Clo&se"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frame2
        '
        Me.frame2.BackColor = System.Drawing.SystemColors.Control
        Me.frame2.Controls.Add(Me.cmdSetupCom)
        Me.frame2.Controls.Add(Me.cmdFlash)
        Me.frame2.Controls.Add(Me.chkSysQK)
        Me.frame2.Controls.Add(Me.chkDownloadCustomSettings)
        Me.frame2.Controls.Add(Me.chkDownloadCustomSearch)
        Me.frame2.Controls.Add(Me.chkResume)
        Me.frame2.Controls.Add(Me.chkClearMemory)
        Me.frame2.Controls.Add(Me.cmdQueueSystems)
        Me.frame2.Controls.Add(Me.cmdClearAllSys)
        Me.frame2.Controls.Add(Me.cmdChkAllSys)
        Me.frame2.Controls.Add(Me.lstSystems)
        Me.frame2.Controls.Add(Me.lblSystemsUpload)
        Me.frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frame2.Location = New System.Drawing.Point(10, 27)
        Me.frame2.Name = "frame2"
        Me.frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame2.Size = New System.Drawing.Size(468, 241)
        Me.frame2.TabIndex = 12
        Me.frame2.TabStop = False
        Me.frame2.Text = "Download Settings"
        '
        'cmdSetupCom
        '
        Me.cmdSetupCom.Location = New System.Drawing.Point(254, 207)
        Me.cmdSetupCom.Name = "cmdSetupCom"
        Me.cmdSetupCom.Size = New System.Drawing.Size(99, 25)
        Me.cmdSetupCom.TabIndex = 20
        Me.cmdSetupCom.Text = "Setup COM Port"
        Me.cmdSetupCom.UseVisualStyleBackColor = True
        '
        'cmdFlash
        '
        Me.cmdFlash.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFlash.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFlash.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFlash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFlash.Location = New System.Drawing.Point(360, 207)
        Me.cmdFlash.Name = "cmdFlash"
        Me.cmdFlash.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFlash.Size = New System.Drawing.Size(105, 25)
        Me.cmdFlash.TabIndex = 11
        Me.cmdFlash.Text = "S&tart Download"
        Me.cmdFlash.UseVisualStyleBackColor = True
        '
        'chkSysQK
        '
        Me.chkSysQK.BackColor = System.Drawing.SystemColors.Control
        Me.chkSysQK.Checked = True
        Me.chkSysQK.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSysQK.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSysQK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSysQK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSysQK.Location = New System.Drawing.Point(253, 64)
        Me.chkSysQK.Name = "chkSysQK"
        Me.chkSysQK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSysQK.Size = New System.Drawing.Size(177, 17)
        Me.chkSysQK.TabIndex = 3
        Me.chkSysQK.Text = "Get S&ystem Quick Key Status"
        Me.chkSysQK.UseVisualStyleBackColor = False
        '
        'chkDownloadCustomSettings
        '
        Me.chkDownloadCustomSettings.BackColor = System.Drawing.SystemColors.Control
        Me.chkDownloadCustomSettings.Checked = True
        Me.chkDownloadCustomSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDownloadCustomSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDownloadCustomSettings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDownloadCustomSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDownloadCustomSettings.Location = New System.Drawing.Point(253, 103)
        Me.chkDownloadCustomSettings.Name = "chkDownloadCustomSettings"
        Me.chkDownloadCustomSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDownloadCustomSettings.Size = New System.Drawing.Size(185, 17)
        Me.chkDownloadCustomSettings.TabIndex = 5
        Me.chkDownloadCustomSettings.Text = "&Get Scanner settings"
        Me.chkDownloadCustomSettings.UseVisualStyleBackColor = False
        '
        'chkDownloadCustomSearch
        '
        Me.chkDownloadCustomSearch.BackColor = System.Drawing.SystemColors.Control
        Me.chkDownloadCustomSearch.Checked = True
        Me.chkDownloadCustomSearch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDownloadCustomSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDownloadCustomSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDownloadCustomSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDownloadCustomSearch.Location = New System.Drawing.Point(253, 83)
        Me.chkDownloadCustomSearch.Name = "chkDownloadCustomSearch"
        Me.chkDownloadCustomSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDownloadCustomSearch.Size = New System.Drawing.Size(157, 17)
        Me.chkDownloadCustomSearch.TabIndex = 4
        Me.chkDownloadCustomSearch.Text = "Get Custom search ranges"
        Me.chkDownloadCustomSearch.UseVisualStyleBackColor = False
        '
        'chkClearMemory
        '
        Me.chkClearMemory.BackColor = System.Drawing.SystemColors.Control
        Me.chkClearMemory.Checked = True
        Me.chkClearMemory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClearMemory.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkClearMemory.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkClearMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkClearMemory.Location = New System.Drawing.Point(254, 16)
        Me.chkClearMemory.Name = "chkClearMemory"
        Me.chkClearMemory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkClearMemory.Size = New System.Drawing.Size(200, 32)
        Me.chkClearMemory.TabIndex = 1
        Me.chkClearMemory.Text = "Erase all systems && settings in FreeSCAN first"
        Me.chkClearMemory.UseVisualStyleBackColor = False
        '
        'cmdQueueSystems
        '
        Me.cmdQueueSystems.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQueueSystems.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQueueSystems.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQueueSystems.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQueueSystems.Location = New System.Drawing.Point(16, 192)
        Me.cmdQueueSystems.Name = "cmdQueueSystems"
        Me.cmdQueueSystems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQueueSystems.Size = New System.Drawing.Size(117, 37)
        Me.cmdQueueSystems.TabIndex = 8
        Me.cmdQueueSystems.Text = "&Queue System List"
        Me.cmdQueueSystems.UseVisualStyleBackColor = True
        '
        'cmdClearAllSys
        '
        Me.cmdClearAllSys.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearAllSys.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearAllSys.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAllSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearAllSys.Location = New System.Drawing.Point(172, 192)
        Me.cmdClearAllSys.Name = "cmdClearAllSys"
        Me.cmdClearAllSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearAllSys.Size = New System.Drawing.Size(69, 20)
        Me.cmdClearAllSys.TabIndex = 9
        Me.cmdClearAllSys.Text = "C&lear All"
        Me.cmdClearAllSys.UseVisualStyleBackColor = True
        '
        'cmdChkAllSys
        '
        Me.cmdChkAllSys.BackColor = System.Drawing.SystemColors.Control
        Me.cmdChkAllSys.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdChkAllSys.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChkAllSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdChkAllSys.Location = New System.Drawing.Point(172, 215)
        Me.cmdChkAllSys.Name = "cmdChkAllSys"
        Me.cmdChkAllSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdChkAllSys.Size = New System.Drawing.Size(69, 20)
        Me.cmdChkAllSys.TabIndex = 10
        Me.cmdChkAllSys.Text = "&Check All"
        Me.cmdChkAllSys.UseVisualStyleBackColor = True
        '
        'lstSystems
        '
        Me.lstSystems.BackColor = System.Drawing.SystemColors.Window
        Me.lstSystems.CheckOnClick = True
        Me.lstSystems.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstSystems.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSystems.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstSystems.Location = New System.Drawing.Point(16, 33)
        Me.lstSystems.Name = "lstSystems"
        Me.lstSystems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstSystems.Size = New System.Drawing.Size(225, 154)
        Me.lstSystems.TabIndex = 0
        '
        'lblSystemsUpload
        '
        Me.lblSystemsUpload.BackColor = System.Drawing.SystemColors.Control
        Me.lblSystemsUpload.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSystemsUpload.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemsUpload.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSystemsUpload.Location = New System.Drawing.Point(16, 16)
        Me.lblSystemsUpload.Name = "lblSystemsUpload"
        Me.lblSystemsUpload.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSystemsUpload.Size = New System.Drawing.Size(217, 17)
        Me.lblSystemsUpload.TabIndex = 14
        Me.lblSystemsUpload.Text = "Systems for download from scanner:"
        '
        '_imgIO_6
        '
        Me._imgIO_6.BackColor = System.Drawing.Color.Transparent
        Me._imgIO_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgIO_6.Image = CType(resources.GetObject("_imgIO_6.Image"), System.Drawing.Image)
        Me.imgIO.SetIndex(Me._imgIO_6, CType(6, Short))
        Me._imgIO_6.Location = New System.Drawing.Point(730, 104)
        Me._imgIO_6.Name = "_imgIO_6"
        Me._imgIO_6.Size = New System.Drawing.Size(110, 67)
        Me._imgIO_6.TabIndex = 17
        Me._imgIO_6.TabStop = False
        Me._imgIO_6.Visible = False
        '
        '_imgIO_5
        '
        Me._imgIO_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgIO_5.Image = CType(resources.GetObject("_imgIO_5.Image"), System.Drawing.Image)
        Me.imgIO.SetIndex(Me._imgIO_5, CType(5, Short))
        Me._imgIO_5.Location = New System.Drawing.Point(728, 32)
        Me._imgIO_5.Name = "_imgIO_5"
        Me._imgIO_5.Size = New System.Drawing.Size(110, 67)
        Me._imgIO_5.TabIndex = 18
        Me._imgIO_5.TabStop = False
        Me._imgIO_5.Visible = False
        '
        '_imgIO_0
        '
        Me._imgIO_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgIO_0.Image = CType(resources.GetObject("_imgIO_0.Image"), System.Drawing.Image)
        Me.imgIO.SetIndex(Me._imgIO_0, CType(0, Short))
        Me._imgIO_0.Location = New System.Drawing.Point(596, 20)
        Me._imgIO_0.Name = "_imgIO_0"
        Me._imgIO_0.Size = New System.Drawing.Size(110, 67)
        Me._imgIO_0.TabIndex = 19
        Me._imgIO_0.TabStop = False
        Me._imgIO_0.Visible = False
        '
        '_imgIO_1
        '
        Me._imgIO_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgIO_1.Image = CType(resources.GetObject("_imgIO_1.Image"), System.Drawing.Image)
        Me.imgIO.SetIndex(Me._imgIO_1, CType(1, Short))
        Me._imgIO_1.Location = New System.Drawing.Point(592, 96)
        Me._imgIO_1.Name = "_imgIO_1"
        Me._imgIO_1.Size = New System.Drawing.Size(110, 67)
        Me._imgIO_1.TabIndex = 20
        Me._imgIO_1.TabStop = False
        Me._imgIO_1.Visible = False
        '
        '_imgIO_3
        '
        Me._imgIO_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgIO_3.Image = CType(resources.GetObject("_imgIO_3.Image"), System.Drawing.Image)
        Me.imgIO.SetIndex(Me._imgIO_3, CType(3, Short))
        Me._imgIO_3.Location = New System.Drawing.Point(596, 240)
        Me._imgIO_3.Name = "_imgIO_3"
        Me._imgIO_3.Size = New System.Drawing.Size(110, 67)
        Me._imgIO_3.TabIndex = 21
        Me._imgIO_3.TabStop = False
        Me._imgIO_3.Visible = False
        '
        '_imgIO_2
        '
        Me._imgIO_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgIO_2.Image = CType(resources.GetObject("_imgIO_2.Image"), System.Drawing.Image)
        Me.imgIO.SetIndex(Me._imgIO_2, CType(2, Short))
        Me._imgIO_2.Location = New System.Drawing.Point(592, 172)
        Me._imgIO_2.Name = "_imgIO_2"
        Me._imgIO_2.Size = New System.Drawing.Size(110, 67)
        Me._imgIO_2.TabIndex = 22
        Me._imgIO_2.TabStop = False
        Me._imgIO_2.Visible = False
        '
        '_imgIO_4
        '
        Me._imgIO_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgIO_4.Image = CType(resources.GetObject("_imgIO_4.Image"), System.Drawing.Image)
        Me.imgIO.SetIndex(Me._imgIO_4, CType(4, Short))
        Me._imgIO_4.Location = New System.Drawing.Point(596, 316)
        Me._imgIO_4.Name = "_imgIO_4"
        Me._imgIO_4.Size = New System.Drawing.Size(110, 67)
        Me._imgIO_4.TabIndex = 23
        Me._imgIO_4.TabStop = False
        Me._imgIO_4.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuScanner})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(501, 24)
        Me.MainMenu1.TabIndex = 24
        '
        'mnuScanner
        '
        Me.mnuScanner.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuScannerQKEdit, Me.AutoSortSystemListToolStripMenuItem, Me.mnuScannerCOMPort, Me.mnuAbort, Me.mnuCopyLog})
        Me.mnuScanner.Name = "mnuScanner"
        Me.mnuScanner.Size = New System.Drawing.Size(121, 20)
        Me.mnuScanner.Text = "&Things You Can Do"
        '
        'mnuScannerQKEdit
        '
        Me.mnuScannerQKEdit.Name = "mnuScannerQKEdit"
        Me.mnuScannerQKEdit.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuScannerQKEdit.Size = New System.Drawing.Size(264, 22)
        Me.mnuScannerQKEdit.Text = "Open My Scanner Quick Editor..."
        '
        'AutoSortSystemListToolStripMenuItem
        '
        Me.AutoSortSystemListToolStripMenuItem.Name = "AutoSortSystemListToolStripMenuItem"
        Me.AutoSortSystemListToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.AutoSortSystemListToolStripMenuItem.Text = "Auto Sort System List"
        '
        'mnuScannerCOMPort
        '
        Me.mnuScannerCOMPort.Name = "mnuScannerCOMPort"
        Me.mnuScannerCOMPort.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuScannerCOMPort.Size = New System.Drawing.Size(264, 22)
        Me.mnuScannerCOMPort.Text = "Setup COM Port...."
        '
        'mnuAbort
        '
        Me.mnuAbort.Name = "mnuAbort"
        Me.mnuAbort.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAbort.Size = New System.Drawing.Size(264, 22)
        Me.mnuAbort.Text = "A&bort Current Operation"
        '
        'mnuCopyLog
        '
        Me.mnuCopyLog.Name = "mnuCopyLog"
        Me.mnuCopyLog.Size = New System.Drawing.Size(264, 22)
        Me.mnuCopyLog.Text = "C&opy IO Log To Clipboard"
        '
        'cmdAbortDownload
        '
        Me.cmdAbortDownload.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAbortDownload.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAbortDownload.Enabled = False
        Me.cmdAbortDownload.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbortDownload.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAbortDownload.Location = New System.Drawing.Point(258, 378)
        Me.cmdAbortDownload.Name = "cmdAbortDownload"
        Me.cmdAbortDownload.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAbortDownload.Size = New System.Drawing.Size(105, 25)
        Me.cmdAbortDownload.TabIndex = 25
        Me.cmdAbortDownload.Text = "Cance&l Download"
        Me.cmdAbortDownload.UseVisualStyleBackColor = True
        '
        'frmCommsDownload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(501, 424)
        Me.Controls.Add(Me.cmdAbortDownload)
        Me.Controls.Add(Me._imgIO_6)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.frame2)
        Me.Controls.Add(Me._imgIO_5)
        Me.Controls.Add(Me._imgIO_0)
        Me.Controls.Add(Me._imgIO_1)
        Me.Controls.Add(Me._imgIO_3)
        Me.Controls.Add(Me._imgIO_2)
        Me.Controls.Add(Me._imgIO_4)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 56)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCommsDownload"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FreeSCAN - Read from scanner"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.imgIOState, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frame2.ResumeLayout(False)
        CType(Me._imgIO_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgIO_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgIO_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgIO_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgIO_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgIO_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgIO_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AutoSortSystemListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSetupCom As System.Windows.Forms.Button
    Public WithEvents cmdAbortDownload As System.Windows.Forms.Button
#End Region 
End Class