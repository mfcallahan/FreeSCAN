<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
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
	Public WithEvents lblErr As System.Windows.Forms.Label
	Public WithEvents lblMemUsed As System.Windows.Forms.Label
	Public WithEvents lblChnSkip As System.Windows.Forms.Label
	Public WithEvents lblChannelsFound As System.Windows.Forms.Label
	Public WithEvents lblGroupsFound As System.Windows.Forms.Label
	Public WithEvents lblSystemsFound As System.Windows.Forms.Label
	Public WithEvents _Label9_2 As System.Windows.Forms.Label
	Public WithEvents _Label9_1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents lblOp As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents _Label9_0 As System.Windows.Forms.Label
	Public WithEvents imgIOState As System.Windows.Forms.PictureBox
    Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdFlash As System.Windows.Forms.Button
	Public WithEvents chkSysQK As System.Windows.Forms.CheckBox
    Public WithEvents chkResume As System.Windows.Forms.CheckBox
	Public WithEvents _optWriteMode_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optWriteMode_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optWriteMode_2 As System.Windows.Forms.RadioButton
	Public WithEvents chkGlobalLO As System.Windows.Forms.CheckBox
	Public WithEvents chkAnalog As System.Windows.Forms.CheckBox
	Public WithEvents chkUploadCustomSettings As System.Windows.Forms.CheckBox
	Public WithEvents cmdClearAllSys As System.Windows.Forms.Button
	Public WithEvents cmdChkAllSys As System.Windows.Forms.Button
	Public WithEvents lstSystems As System.Windows.Forms.CheckedListBox
    Public WithEvents lblSystemsUpload As System.Windows.Forms.Label
    Public WithEvents frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Frame3 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents Label9 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents optWriteMode As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents mnuScannerQKEdit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuScannerCOMPort As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAbort As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCopyClipbaord As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuScanner As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim _Frame3_0 As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblErr = New System.Windows.Forms.Label()
        Me.lblMemUsed = New System.Windows.Forms.Label()
        Me.lblChnSkip = New System.Windows.Forms.Label()
        Me.lblChannelsFound = New System.Windows.Forms.Label()
        Me.lblGroupsFound = New System.Windows.Forms.Label()
        Me.lblSystemsFound = New System.Windows.Forms.Label()
        Me._Label9_2 = New System.Windows.Forms.Label()
        Me._Label9_1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._Label9_0 = New System.Windows.Forms.Label()
        Me.imgIOState = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkResume = New System.Windows.Forms.CheckBox()
        Me.cmdChkChange = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.frame2 = New System.Windows.Forms.GroupBox()
        Me.cmdSetupCom = New System.Windows.Forms.Button()
        Me.cmdFlash = New System.Windows.Forms.Button()
        Me.chkSysQK = New System.Windows.Forms.CheckBox()
        Me._optWriteMode_0 = New System.Windows.Forms.RadioButton()
        Me._optWriteMode_1 = New System.Windows.Forms.RadioButton()
        Me._optWriteMode_2 = New System.Windows.Forms.RadioButton()
        Me.chkGlobalLO = New System.Windows.Forms.CheckBox()
        Me.chkAnalog = New System.Windows.Forms.CheckBox()
        Me.chkUploadCustomSettings = New System.Windows.Forms.CheckBox()
        Me.cmdClearAllSys = New System.Windows.Forms.Button()
        Me.cmdChkAllSys = New System.Windows.Forms.Button()
        Me.lstSystems = New System.Windows.Forms.CheckedListBox()
        Me.lblSystemsUpload = New System.Windows.Forms.Label()
        Me.Frame3 = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Label9 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.optWriteMode = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuScanner = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScannerQKEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScannerCOMPort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyClipbaord = New System.Windows.Forms.ToolStripMenuItem()
        Me.msc = New System.IO.Ports.SerialPort(Me.components)
        _Frame3_0 = New System.Windows.Forms.GroupBox()
        _Frame3_0.SuspendLayout()
        CType(Me.imgIOState, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frame2.SuspendLayout()
        CType(Me.Frame3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optWriteMode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame3_0
        '
        _Frame3_0.BackColor = System.Drawing.SystemColors.Control
        _Frame3_0.Controls.Add(Me.lblErr)
        _Frame3_0.Controls.Add(Me.lblMemUsed)
        _Frame3_0.Controls.Add(Me.lblChnSkip)
        _Frame3_0.Controls.Add(Me.lblChannelsFound)
        _Frame3_0.Controls.Add(Me.lblGroupsFound)
        _Frame3_0.Controls.Add(Me.lblSystemsFound)
        _Frame3_0.Controls.Add(Me._Label9_2)
        _Frame3_0.Controls.Add(Me._Label9_1)
        _Frame3_0.Controls.Add(Me.Label3)
        _Frame3_0.Controls.Add(Me.lblOp)
        _Frame3_0.Controls.Add(Me.Label2)
        _Frame3_0.Controls.Add(Me.Label6)
        _Frame3_0.Controls.Add(Me._Label9_0)
        _Frame3_0.Controls.Add(Me.imgIOState)
        _Frame3_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Frame3_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.SetIndex(_Frame3_0, CType(0, Short))
        _Frame3_0.Location = New System.Drawing.Point(8, 268)
        _Frame3_0.Name = "_Frame3_0"
        _Frame3_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Frame3_0.Size = New System.Drawing.Size(522, 98)
        _Frame3_0.TabIndex = 18
        _Frame3_0.TabStop = False
        _Frame3_0.Text = "Upload Status"
        '
        'lblErr
        '
        Me.lblErr.AutoSize = True
        Me.lblErr.BackColor = System.Drawing.SystemColors.Control
        Me.lblErr.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblErr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErr.ForeColor = System.Drawing.Color.Blue
        Me.lblErr.Location = New System.Drawing.Point(321, 33)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblErr.Size = New System.Drawing.Size(13, 14)
        Me.lblErr.TabIndex = 31
        Me.lblErr.Text = "0"
        '
        'lblMemUsed
        '
        Me.lblMemUsed.AutoSize = True
        Me.lblMemUsed.BackColor = System.Drawing.SystemColors.Control
        Me.lblMemUsed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMemUsed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemUsed.ForeColor = System.Drawing.Color.Black
        Me.lblMemUsed.Location = New System.Drawing.Point(321, 18)
        Me.lblMemUsed.Name = "lblMemUsed"
        Me.lblMemUsed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMemUsed.Size = New System.Drawing.Size(13, 14)
        Me.lblMemUsed.TabIndex = 30
        Me.lblMemUsed.Text = "0"
        '
        'lblChnSkip
        '
        Me.lblChnSkip.AutoSize = True
        Me.lblChnSkip.BackColor = System.Drawing.SystemColors.Control
        Me.lblChnSkip.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChnSkip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChnSkip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChnSkip.Location = New System.Drawing.Point(321, 48)
        Me.lblChnSkip.Name = "lblChnSkip"
        Me.lblChnSkip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChnSkip.Size = New System.Drawing.Size(13, 14)
        Me.lblChnSkip.TabIndex = 29
        Me.lblChnSkip.Text = "0"
        '
        'lblChannelsFound
        '
        Me.lblChannelsFound.AutoSize = True
        Me.lblChannelsFound.BackColor = System.Drawing.SystemColors.Control
        Me.lblChannelsFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChannelsFound.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChannelsFound.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChannelsFound.Location = New System.Drawing.Point(129, 48)
        Me.lblChannelsFound.Name = "lblChannelsFound"
        Me.lblChannelsFound.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChannelsFound.Size = New System.Drawing.Size(13, 14)
        Me.lblChannelsFound.TabIndex = 28
        Me.lblChannelsFound.Text = "0"
        '
        'lblGroupsFound
        '
        Me.lblGroupsFound.AutoSize = True
        Me.lblGroupsFound.BackColor = System.Drawing.SystemColors.Control
        Me.lblGroupsFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGroupsFound.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupsFound.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGroupsFound.Location = New System.Drawing.Point(129, 33)
        Me.lblGroupsFound.Name = "lblGroupsFound"
        Me.lblGroupsFound.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGroupsFound.Size = New System.Drawing.Size(13, 14)
        Me.lblGroupsFound.TabIndex = 27
        Me.lblGroupsFound.Text = "0"
        '
        'lblSystemsFound
        '
        Me.lblSystemsFound.AutoSize = True
        Me.lblSystemsFound.BackColor = System.Drawing.SystemColors.Control
        Me.lblSystemsFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSystemsFound.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemsFound.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSystemsFound.Location = New System.Drawing.Point(129, 18)
        Me.lblSystemsFound.Name = "lblSystemsFound"
        Me.lblSystemsFound.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSystemsFound.Size = New System.Drawing.Size(13, 14)
        Me.lblSystemsFound.TabIndex = 26
        Me.lblSystemsFound.Text = "0"
        '
        '_Label9_2
        '
        Me._Label9_2.AutoSize = True
        Me._Label9_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label9_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label9_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label9_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.SetIndex(Me._Label9_2, CType(2, Short))
        Me._Label9_2.Location = New System.Drawing.Point(267, 33)
        Me._Label9_2.Name = "_Label9_2"
        Me._Label9_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label9_2.Size = New System.Drawing.Size(37, 14)
        Me._Label9_2.TabIndex = 25
        Me._Label9_2.Text = "Errors"
        '
        '_Label9_1
        '
        Me._Label9_1.AutoSize = True
        Me._Label9_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label9_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label9_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label9_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.SetIndex(Me._Label9_1, CType(1, Short))
        Me._Label9_1.Location = New System.Drawing.Point(267, 48)
        Me._Label9_1.Name = "_Label9_1"
        Me._Label9_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label9_1.Size = New System.Drawing.Size(45, 14)
        Me._Label9_1.TabIndex = 24
        Me._Label9_1.Text = "Skipped"
        Me.ToolTip1.SetToolTip(Me._Label9_1, "Channels will be skipped when they are 0Mhz, or are marked digital for an analog " & _
                "radio")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(267, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(48, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Mem Full"
        '
        'lblOp
        '
        Me.lblOp.AutoSize = True
        Me.lblOp.BackColor = System.Drawing.SystemColors.Control
        Me.lblOp.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOp.Location = New System.Drawing.Point(12, 72)
        Me.lblOp.Name = "lblOp"
        Me.lblOp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOp.Size = New System.Drawing.Size(76, 14)
        Me.lblOp.TabIndex = 22
        Me.lblOp.Text = "Standing By...."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(72, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Systems"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(72, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(43, 14)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Groups"
        '
        '_Label9_0
        '
        Me._Label9_0.AutoSize = True
        Me._Label9_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label9_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label9_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label9_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.SetIndex(Me._Label9_0, CType(0, Short))
        Me._Label9_0.Location = New System.Drawing.Point(72, 48)
        Me._Label9_0.Name = "_Label9_0"
        Me._Label9_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label9_0.Size = New System.Drawing.Size(52, 14)
        Me._Label9_0.TabIndex = 19
        Me._Label9_0.Text = "Channels"
        '
        'imgIOState
        '
        Me.imgIOState.BackColor = System.Drawing.Color.Transparent
        Me.imgIOState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.imgIOState.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgIOState.Image = CType(resources.GetObject("imgIOState.Image"), System.Drawing.Image)
        Me.imgIOState.Location = New System.Drawing.Point(383, 18)
        Me.imgIOState.Name = "imgIOState"
        Me.imgIOState.Size = New System.Drawing.Size(110, 67)
        Me.imgIOState.TabIndex = 32
        Me.imgIOState.TabStop = False
        '
        'chkResume
        '
        Me.chkResume.BackColor = System.Drawing.SystemColors.Control
        Me.chkResume.Checked = True
        Me.chkResume.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkResume.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkResume.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResume.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkResume.Location = New System.Drawing.Point(256, 161)
        Me.chkResume.Name = "chkResume"
        Me.chkResume.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkResume.Size = New System.Drawing.Size(197, 17)
        Me.chkResume.TabIndex = 14
        Me.chkResume.Text = "A&utomatically resume scanning"
        Me.ToolTip1.SetToolTip(Me.chkResume, "Leave this unchecked if you want the scanner to be left in Hold mode")
        Me.chkResume.UseVisualStyleBackColor = True
        '
        'cmdChkChange
        '
        Me.cmdChkChange.BackColor = System.Drawing.SystemColors.Control
        Me.cmdChkChange.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdChkChange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChkChange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdChkChange.Location = New System.Drawing.Point(168, 194)
        Me.cmdChkChange.Name = "cmdChkChange"
        Me.cmdChkChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdChkChange.Size = New System.Drawing.Size(65, 25)
        Me.cmdChkChange.TabIndex = 18
        Me.cmdChkChange.Text = "A&uto"
        Me.ToolTip1.SetToolTip(Me.cmdChkChange, "Selects only systems that are newly created or changed")
        Me.cmdChkChange.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(419, 372)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(105, 25)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "Clo&se"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frame2
        '
        Me.frame2.BackColor = System.Drawing.SystemColors.Control
        Me.frame2.Controls.Add(Me.cmdSetupCom)
        Me.frame2.Controls.Add(Me.cmdChkChange)
        Me.frame2.Controls.Add(Me.cmdFlash)
        Me.frame2.Controls.Add(Me.chkSysQK)
        Me.frame2.Controls.Add(Me.chkResume)
        Me.frame2.Controls.Add(Me._optWriteMode_0)
        Me.frame2.Controls.Add(Me._optWriteMode_1)
        Me.frame2.Controls.Add(Me._optWriteMode_2)
        Me.frame2.Controls.Add(Me.chkGlobalLO)
        Me.frame2.Controls.Add(Me.chkAnalog)
        Me.frame2.Controls.Add(Me.chkUploadCustomSettings)
        Me.frame2.Controls.Add(Me.cmdClearAllSys)
        Me.frame2.Controls.Add(Me.cmdChkAllSys)
        Me.frame2.Controls.Add(Me.lstSystems)
        Me.frame2.Controls.Add(Me.lblSystemsUpload)
        Me.frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frame2.Location = New System.Drawing.Point(12, 27)
        Me.frame2.Name = "frame2"
        Me.frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame2.Size = New System.Drawing.Size(518, 241)
        Me.frame2.TabIndex = 10
        Me.frame2.TabStop = False
        Me.frame2.Text = "Upload Settings"
        '
        'cmdSetupCom
        '
        Me.cmdSetupCom.Location = New System.Drawing.Point(256, 194)
        Me.cmdSetupCom.Name = "cmdSetupCom"
        Me.cmdSetupCom.Size = New System.Drawing.Size(100, 25)
        Me.cmdSetupCom.TabIndex = 19
        Me.cmdSetupCom.Text = "Setup COM Port"
        Me.cmdSetupCom.UseVisualStyleBackColor = True
        '
        'cmdFlash
        '
        Me.cmdFlash.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFlash.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFlash.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFlash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFlash.Location = New System.Drawing.Point(407, 194)
        Me.cmdFlash.Name = "cmdFlash"
        Me.cmdFlash.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFlash.Size = New System.Drawing.Size(105, 25)
        Me.cmdFlash.TabIndex = 17
        Me.cmdFlash.Text = "Start Uploa&d"
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
        Me.chkSysQK.Location = New System.Drawing.Point(256, 144)
        Me.chkSysQK.Name = "chkSysQK"
        Me.chkSysQK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSysQK.Size = New System.Drawing.Size(177, 17)
        Me.chkSysQK.TabIndex = 16
        Me.chkSysQK.Text = "Send S&ystem Quick Key Status"
        Me.chkSysQK.UseVisualStyleBackColor = True
        '
        '_optWriteMode_0
        '
        Me._optWriteMode_0.BackColor = System.Drawing.SystemColors.Control
        Me._optWriteMode_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optWriteMode_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optWriteMode_0.ForeColor = System.Drawing.Color.Red
        Me.optWriteMode.SetIndex(Me._optWriteMode_0, CType(0, Short))
        Me._optWriteMode_0.Location = New System.Drawing.Point(256, 19)
        Me._optWriteMode_0.Name = "_optWriteMode_0"
        Me._optWriteMode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optWriteMode_0.Size = New System.Drawing.Size(177, 17)
        Me._optWriteMode_0.TabIndex = 1
        Me._optWriteMode_0.TabStop = True
        Me._optWriteMode_0.Text = "&Erase All Systems && Settings first"
        Me._optWriteMode_0.UseVisualStyleBackColor = False
        '
        '_optWriteMode_1
        '
        Me._optWriteMode_1.BackColor = System.Drawing.SystemColors.Control
        Me._optWriteMode_1.Checked = True
        Me._optWriteMode_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optWriteMode_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optWriteMode_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optWriteMode.SetIndex(Me._optWriteMode_1, CType(1, Short))
        Me._optWriteMode_1.Location = New System.Drawing.Point(256, 33)
        Me._optWriteMode_1.Name = "_optWriteMode_1"
        Me._optWriteMode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optWriteMode_1.Size = New System.Drawing.Size(193, 39)
        Me._optWriteMode_1.TabIndex = 2
        Me._optWriteMode_1.TabStop = True
        Me._optWriteMode_1.Text = "&Replace any existing system by the same name, add remaining"
        Me._optWriteMode_1.UseVisualStyleBackColor = False
        '
        '_optWriteMode_2
        '
        Me._optWriteMode_2.BackColor = System.Drawing.SystemColors.Control
        Me._optWriteMode_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optWriteMode_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optWriteMode_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optWriteMode.SetIndex(Me._optWriteMode_2, CType(2, Short))
        Me._optWriteMode_2.Location = New System.Drawing.Point(256, 70)
        Me._optWriteMode_2.Name = "_optWriteMode_2"
        Me._optWriteMode_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optWriteMode_2.Size = New System.Drawing.Size(177, 17)
        Me._optWriteMode_2.TabIndex = 3
        Me._optWriteMode_2.TabStop = True
        Me._optWriteMode_2.Text = "&Add only, do not overwrite"
        Me._optWriteMode_2.UseVisualStyleBackColor = False
        '
        'chkGlobalLO
        '
        Me.chkGlobalLO.BackColor = System.Drawing.SystemColors.Control
        Me.chkGlobalLO.Checked = True
        Me.chkGlobalLO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGlobalLO.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkGlobalLO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGlobalLO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGlobalLO.Location = New System.Drawing.Point(256, 127)
        Me.chkGlobalLO.Name = "chkGlobalLO"
        Me.chkGlobalLO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGlobalLO.Size = New System.Drawing.Size(233, 17)
        Me.chkGlobalLO.TabIndex = 6
        Me.chkGlobalLO.Text = "Send Global Frequency lockouts"
        Me.chkGlobalLO.UseVisualStyleBackColor = True
        '
        'chkAnalog
        '
        Me.chkAnalog.AutoSize = True
        Me.chkAnalog.BackColor = System.Drawing.SystemColors.Control
        Me.chkAnalog.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAnalog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnalog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAnalog.Location = New System.Drawing.Point(256, 110)
        Me.chkAnalog.Name = "chkAnalog"
        Me.chkAnalog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAnalog.Size = New System.Drawing.Size(259, 18)
        Me.chkAnalog.TabIndex = 5
        Me.chkAnalog.Text = "Don't send &digital channels to an analog scanner"
        Me.chkAnalog.UseVisualStyleBackColor = True
        '
        'chkUploadCustomSettings
        '
        Me.chkUploadCustomSettings.BackColor = System.Drawing.SystemColors.Control
        Me.chkUploadCustomSettings.Checked = True
        Me.chkUploadCustomSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUploadCustomSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUploadCustomSettings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUploadCustomSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUploadCustomSettings.Location = New System.Drawing.Point(256, 93)
        Me.chkUploadCustomSettings.Name = "chkUploadCustomSettings"
        Me.chkUploadCustomSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUploadCustomSettings.Size = New System.Drawing.Size(233, 17)
        Me.chkUploadCustomSettings.TabIndex = 4
        Me.chkUploadCustomSettings.Text = "&Send custom radio settings"
        Me.chkUploadCustomSettings.UseVisualStyleBackColor = True
        '
        'cmdClearAllSys
        '
        Me.cmdClearAllSys.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearAllSys.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearAllSys.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAllSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearAllSys.Location = New System.Drawing.Point(92, 194)
        Me.cmdClearAllSys.Name = "cmdClearAllSys"
        Me.cmdClearAllSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearAllSys.Size = New System.Drawing.Size(65, 25)
        Me.cmdClearAllSys.TabIndex = 8
        Me.cmdClearAllSys.Text = "&None"
        Me.cmdClearAllSys.UseVisualStyleBackColor = True
        '
        'cmdChkAllSys
        '
        Me.cmdChkAllSys.BackColor = System.Drawing.SystemColors.Control
        Me.cmdChkAllSys.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdChkAllSys.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChkAllSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdChkAllSys.Location = New System.Drawing.Point(16, 194)
        Me.cmdChkAllSys.Name = "cmdChkAllSys"
        Me.cmdChkAllSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdChkAllSys.Size = New System.Drawing.Size(65, 25)
        Me.cmdChkAllSys.TabIndex = 7
        Me.cmdChkAllSys.Text = "A&ll"
        Me.cmdChkAllSys.UseVisualStyleBackColor = True
        '
        'lstSystems
        '
        Me.lstSystems.BackColor = System.Drawing.SystemColors.Window
        Me.lstSystems.CheckOnClick = True
        Me.lstSystems.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstSystems.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSystems.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstSystems.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        Me.lblSystemsUpload.TabIndex = 12
        Me.lblSystemsUpload.Text = "Systems to Upload:"
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuScanner})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(537, 24)
        Me.MainMenu1.TabIndex = 20
        '
        'mnuScanner
        '
        Me.mnuScanner.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuScannerQKEdit, Me.mnuScannerCOMPort, Me.mnuAbort, Me.mnuCopyClipbaord})
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
        'mnuScannerCOMPort
        '
        Me.mnuScannerCOMPort.Name = "mnuScannerCOMPort"
        Me.mnuScannerCOMPort.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuScannerCOMPort.Size = New System.Drawing.Size(264, 22)
        Me.mnuScannerCOMPort.Text = "Setup COM Port..."
        '
        'mnuAbort
        '
        Me.mnuAbort.Name = "mnuAbort"
        Me.mnuAbort.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAbort.Size = New System.Drawing.Size(264, 22)
        Me.mnuAbort.Text = "Abort &Current Operation"
        '
        'mnuCopyClipbaord
        '
        Me.mnuCopyClipbaord.Name = "mnuCopyClipbaord"
        Me.mnuCopyClipbaord.Size = New System.Drawing.Size(264, 22)
        Me.mnuCopyClipbaord.Text = "Copy &IO Log To Clipboard"
        '
        'msc
        '
        Me.msc.BaudRate = 57600
        Me.msc.DiscardNull = True
        Me.msc.ParityReplace = CType(33, Byte)
        Me.msc.ReadBufferSize = 512
        Me.msc.ReadTimeout = 4000
        Me.msc.ReceivedBytesThreshold = 3
        Me.msc.WriteBufferSize = 512
        Me.msc.WriteTimeout = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(537, 405)
        Me.Controls.Add(_Frame3_0)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.frame2)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 56)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Send To Scanner"
        _Frame3_0.ResumeLayout(False)
        _Frame3_0.PerformLayout()
        CType(Me.imgIOState, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frame2.ResumeLayout(False)
        Me.frame2.PerformLayout()
        CType(Me.Frame3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optWriteMode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents msc As System.IO.Ports.SerialPort
    Public WithEvents cmdChkChange As System.Windows.Forms.Button
    Friend WithEvents cmdSetupCom As System.Windows.Forms.Button
#End Region
End Class