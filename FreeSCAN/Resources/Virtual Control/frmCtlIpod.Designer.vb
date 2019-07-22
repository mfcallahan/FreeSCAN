<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCtlIpod
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
	Public WithEvents _picBatt_1 As System.Windows.Forms.PictureBox
	Public WithEvents _picSigLvl_4 As System.Windows.Forms.PictureBox
	Public WithEvents _picSigLvl_3 As System.Windows.Forms.PictureBox
	Public WithEvents _picSigLvl_2 As System.Windows.Forms.PictureBox
	Public WithEvents _picSigLvl_1 As System.Windows.Forms.PictureBox
	Public WithEvents _picSigLvl_0 As System.Windows.Forms.PictureBox
	Public WithEvents _picBatt_3 As System.Windows.Forms.PictureBox
	Public WithEvents _picBatt_2 As System.Windows.Forms.PictureBox
	Public WithEvents _picBatt_0 As System.Windows.Forms.PictureBox
	Public WithEvents cmdStopCom As System.Windows.Forms.Button
	Public WithEvents cmdLink As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents DispTimer As System.Windows.Forms.Timer
	Public WithEvents picPause As System.Windows.Forms.PictureBox
	Public WithEvents picDownArrow As System.Windows.Forms.PictureBox
	Public WithEvents picUpArrow As System.Windows.Forms.PictureBox
	Public WithEvents picLowBatt As System.Windows.Forms.PictureBox
	Public WithEvents PicLEDON As System.Windows.Forms.PictureBox
	Public WithEvents PicCC As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_10 As System.Windows.Forms.PictureBox
	Public WithEvents _lblDisp_1 As System.Windows.Forms.Label
	Public WithEvents _imgKey_17 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_18 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_16 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_11 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_19 As System.Windows.Forms.PictureBox
	Public WithEvents _lblDisp_7 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_6 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_0 As System.Windows.Forms.Label
	Public WithEvents lblLO As System.Windows.Forms.Label
	Public WithEvents _lblDisp_5 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_4 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_2 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_3 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_8 As System.Windows.Forms.Label
	Public WithEvents picIpod As System.Windows.Forms.Panel
	Public CommonDialogFont As System.Windows.Forms.FontDialog
	Public CommonDialogColor As System.Windows.Forms.ColorDialog
	Public WithEvents imgKey As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents lblDisp As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents mnuQK As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents picBatt As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents picSigLvl As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents mnuEditJump As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_1 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_2 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_3 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_4 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_5 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_6 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_7 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_8 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuQK_9 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditQK As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEnableLog As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuViewLog As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditLO As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditEstLink As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditStopLink As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditFont As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditFontCOlour As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditF As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtlIpod))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._imgKey_10 = New System.Windows.Forms.PictureBox
        Me._imgKey_11 = New System.Windows.Forms.PictureBox
        Me._picBatt_1 = New System.Windows.Forms.PictureBox
        Me._picSigLvl_4 = New System.Windows.Forms.PictureBox
        Me._picSigLvl_3 = New System.Windows.Forms.PictureBox
        Me._picSigLvl_2 = New System.Windows.Forms.PictureBox
        Me._picSigLvl_1 = New System.Windows.Forms.PictureBox
        Me._picSigLvl_0 = New System.Windows.Forms.PictureBox
        Me._picBatt_3 = New System.Windows.Forms.PictureBox
        Me._picBatt_2 = New System.Windows.Forms.PictureBox
        Me._picBatt_0 = New System.Windows.Forms.PictureBox
        Me.cmdStopCom = New System.Windows.Forms.Button
        Me.cmdLink = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.DispTimer = New System.Windows.Forms.Timer(Me.components)
        Me.picIpod = New System.Windows.Forms.Panel
        Me.mnuCon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.JumpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuickKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QK0 = New System.Windows.Forms.ToolStripMenuItem
        Me.QK1 = New System.Windows.Forms.ToolStripMenuItem
        Me.QK2 = New System.Windows.Forms.ToolStripMenuItem
        Me.QK3 = New System.Windows.Forms.ToolStripMenuItem
        Me.QK4 = New System.Windows.Forms.ToolStripMenuItem
        Me.Qk5 = New System.Windows.Forms.ToolStripMenuItem
        Me.QK6 = New System.Windows.Forms.ToolStripMenuItem
        Me.QK7 = New System.Windows.Forms.ToolStripMenuItem
        Me.QK8 = New System.Windows.Forms.ToolStripMenuItem
        Me.QK9 = New System.Windows.Forms.ToolStripMenuItem
        Me.EnableLoggingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenLogWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LockoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EstablishLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisableLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpacityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChooseFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.picPause = New System.Windows.Forms.PictureBox
        Me.picDownArrow = New System.Windows.Forms.PictureBox
        Me.picUpArrow = New System.Windows.Forms.PictureBox
        Me.picLowBatt = New System.Windows.Forms.PictureBox
        Me.PicLEDON = New System.Windows.Forms.PictureBox
        Me.PicCC = New System.Windows.Forms.PictureBox
        Me._lblDisp_1 = New System.Windows.Forms.Label
        Me._imgKey_17 = New System.Windows.Forms.PictureBox
        Me._imgKey_18 = New System.Windows.Forms.PictureBox
        Me._imgKey_16 = New System.Windows.Forms.PictureBox
        Me._imgKey_19 = New System.Windows.Forms.PictureBox
        Me._lblDisp_7 = New System.Windows.Forms.Label
        Me._lblDisp_6 = New System.Windows.Forms.Label
        Me._lblDisp_0 = New System.Windows.Forms.Label
        Me.lblLO = New System.Windows.Forms.Label
        Me._lblDisp_5 = New System.Windows.Forms.Label
        Me._lblDisp_4 = New System.Windows.Forms.Label
        Me._lblDisp_2 = New System.Windows.Forms.Label
        Me._lblDisp_3 = New System.Windows.Forms.Label
        Me._lblDisp_8 = New System.Windows.Forms.Label
        Me.CommonDialogFont = New System.Windows.Forms.FontDialog
        Me.CommonDialogColor = New System.Windows.Forms.ColorDialog
        Me.imgKey = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.lblDisp = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.mnuQK = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me._mnuQK_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuQK_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuQK_2 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuQK_3 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuQK_4 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuQK_5 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuQK_6 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuQK_7 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuQK_8 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuQK_9 = New System.Windows.Forms.ToolStripMenuItem
        Me.picBatt = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.picSigLvl = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditJump = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditQK = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEnableLog = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuViewLog = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditLO = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditEstLink = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditStopLink = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditF = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditFont = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditFontCOlour = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditExit = New System.Windows.Forms.ToolStripMenuItem
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.SetupAudioRecordingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me._imgKey_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._picBatt_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._picSigLvl_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._picSigLvl_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._picSigLvl_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._picSigLvl_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._picSigLvl_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._picBatt_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._picBatt_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._picBatt_0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picIpod.SuspendLayout()
        Me.mnuCon.SuspendLayout()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDownArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLowBatt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLEDON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDisp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuQK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBatt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSigLvl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_imgKey_10
        '
        Me._imgKey_10.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_10.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_10, CType(10, Short))
        Me._imgKey_10.Location = New System.Drawing.Point(164, 370)
        Me._imgKey_10.Name = "_imgKey_10"
        Me._imgKey_10.Size = New System.Drawing.Size(35, 33)
        Me._imgKey_10.TabIndex = 29
        Me._imgKey_10.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_10, "Hold")
        '
        '_imgKey_11
        '
        Me._imgKey_11.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_11.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_11, CType(11, Short))
        Me._imgKey_11.Location = New System.Drawing.Point(128, 370)
        Me._imgKey_11.Name = "_imgKey_11"
        Me._imgKey_11.Size = New System.Drawing.Size(34, 33)
        Me._imgKey_11.TabIndex = 33
        Me._imgKey_11.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_11, "Scan")
        '
        '_picBatt_1
        '
        Me._picBatt_1.BackColor = System.Drawing.SystemColors.Window
        Me._picBatt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._picBatt_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picBatt_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._picBatt_1.Image = CType(resources.GetObject("_picBatt_1.Image"), System.Drawing.Image)
        Me.picBatt.SetIndex(Me._picBatt_1, CType(1, Short))
        Me._picBatt_1.Location = New System.Drawing.Point(257, 33)
        Me._picBatt_1.Name = "_picBatt_1"
        Me._picBatt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picBatt_1.Size = New System.Drawing.Size(29, 17)
        Me._picBatt_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._picBatt_1.TabIndex = 20
        Me._picBatt_1.TabStop = False
        '
        '_picSigLvl_4
        '
        Me._picSigLvl_4.BackColor = System.Drawing.SystemColors.Window
        Me._picSigLvl_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._picSigLvl_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picSigLvl_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._picSigLvl_4.Image = CType(resources.GetObject("_picSigLvl_4.Image"), System.Drawing.Image)
        Me.picSigLvl.SetIndex(Me._picSigLvl_4, CType(4, Short))
        Me._picSigLvl_4.Location = New System.Drawing.Point(85, 35)
        Me._picSigLvl_4.Name = "_picSigLvl_4"
        Me._picSigLvl_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picSigLvl_4.Size = New System.Drawing.Size(24, 15)
        Me._picSigLvl_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._picSigLvl_4.TabIndex = 27
        Me._picSigLvl_4.TabStop = False
        Me._picSigLvl_4.Visible = False
        '
        '_picSigLvl_3
        '
        Me._picSigLvl_3.BackColor = System.Drawing.SystemColors.Window
        Me._picSigLvl_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._picSigLvl_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picSigLvl_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._picSigLvl_3.Image = CType(resources.GetObject("_picSigLvl_3.Image"), System.Drawing.Image)
        Me.picSigLvl.SetIndex(Me._picSigLvl_3, CType(3, Short))
        Me._picSigLvl_3.Location = New System.Drawing.Point(85, 35)
        Me._picSigLvl_3.Name = "_picSigLvl_3"
        Me._picSigLvl_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picSigLvl_3.Size = New System.Drawing.Size(22, 15)
        Me._picSigLvl_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._picSigLvl_3.TabIndex = 26
        Me._picSigLvl_3.TabStop = False
        '
        '_picSigLvl_2
        '
        Me._picSigLvl_2.BackColor = System.Drawing.SystemColors.Window
        Me._picSigLvl_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._picSigLvl_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picSigLvl_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._picSigLvl_2.Image = CType(resources.GetObject("_picSigLvl_2.Image"), System.Drawing.Image)
        Me.picSigLvl.SetIndex(Me._picSigLvl_2, CType(2, Short))
        Me._picSigLvl_2.Location = New System.Drawing.Point(85, 35)
        Me._picSigLvl_2.Name = "_picSigLvl_2"
        Me._picSigLvl_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picSigLvl_2.Size = New System.Drawing.Size(22, 15)
        Me._picSigLvl_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._picSigLvl_2.TabIndex = 25
        Me._picSigLvl_2.TabStop = False
        '
        '_picSigLvl_1
        '
        Me._picSigLvl_1.BackColor = System.Drawing.SystemColors.Window
        Me._picSigLvl_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._picSigLvl_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picSigLvl_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._picSigLvl_1.Image = CType(resources.GetObject("_picSigLvl_1.Image"), System.Drawing.Image)
        Me.picSigLvl.SetIndex(Me._picSigLvl_1, CType(1, Short))
        Me._picSigLvl_1.Location = New System.Drawing.Point(85, 35)
        Me._picSigLvl_1.Name = "_picSigLvl_1"
        Me._picSigLvl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picSigLvl_1.Size = New System.Drawing.Size(22, 15)
        Me._picSigLvl_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._picSigLvl_1.TabIndex = 24
        Me._picSigLvl_1.TabStop = False
        '
        '_picSigLvl_0
        '
        Me._picSigLvl_0.BackColor = System.Drawing.SystemColors.Window
        Me._picSigLvl_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._picSigLvl_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picSigLvl_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._picSigLvl_0.Image = CType(resources.GetObject("_picSigLvl_0.Image"), System.Drawing.Image)
        Me.picSigLvl.SetIndex(Me._picSigLvl_0, CType(0, Short))
        Me._picSigLvl_0.Location = New System.Drawing.Point(85, 35)
        Me._picSigLvl_0.Name = "_picSigLvl_0"
        Me._picSigLvl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picSigLvl_0.Size = New System.Drawing.Size(22, 15)
        Me._picSigLvl_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._picSigLvl_0.TabIndex = 23
        Me._picSigLvl_0.TabStop = False
        '
        '_picBatt_3
        '
        Me._picBatt_3.BackColor = System.Drawing.SystemColors.Window
        Me._picBatt_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._picBatt_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picBatt_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._picBatt_3.Image = CType(resources.GetObject("_picBatt_3.Image"), System.Drawing.Image)
        Me.picBatt.SetIndex(Me._picBatt_3, CType(3, Short))
        Me._picBatt_3.Location = New System.Drawing.Point(257, 33)
        Me._picBatt_3.Name = "_picBatt_3"
        Me._picBatt_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picBatt_3.Size = New System.Drawing.Size(29, 17)
        Me._picBatt_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._picBatt_3.TabIndex = 22
        Me._picBatt_3.TabStop = False
        '
        '_picBatt_2
        '
        Me._picBatt_2.BackColor = System.Drawing.SystemColors.Window
        Me._picBatt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._picBatt_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picBatt_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._picBatt_2.Image = CType(resources.GetObject("_picBatt_2.Image"), System.Drawing.Image)
        Me.picBatt.SetIndex(Me._picBatt_2, CType(2, Short))
        Me._picBatt_2.Location = New System.Drawing.Point(257, 33)
        Me._picBatt_2.Name = "_picBatt_2"
        Me._picBatt_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picBatt_2.Size = New System.Drawing.Size(29, 17)
        Me._picBatt_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._picBatt_2.TabIndex = 21
        Me._picBatt_2.TabStop = False
        '
        '_picBatt_0
        '
        Me._picBatt_0.BackColor = System.Drawing.SystemColors.Window
        Me._picBatt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._picBatt_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picBatt_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._picBatt_0.Image = CType(resources.GetObject("_picBatt_0.Image"), System.Drawing.Image)
        Me.picBatt.SetIndex(Me._picBatt_0, CType(0, Short))
        Me._picBatt_0.Location = New System.Drawing.Point(257, 33)
        Me._picBatt_0.Name = "_picBatt_0"
        Me._picBatt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picBatt_0.Size = New System.Drawing.Size(29, 17)
        Me._picBatt_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._picBatt_0.TabIndex = 19
        Me._picBatt_0.TabStop = False
        '
        'cmdStopCom
        '
        Me.cmdStopCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdStopCom.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStopCom.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStopCom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStopCom.Location = New System.Drawing.Point(348, 104)
        Me.cmdStopCom.Name = "cmdStopCom"
        Me.cmdStopCom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStopCom.Size = New System.Drawing.Size(69, 25)
        Me.cmdStopCom.TabIndex = 15
        Me.cmdStopCom.Text = "&Stop"
        Me.cmdStopCom.UseVisualStyleBackColor = True
        Me.cmdStopCom.Visible = False
        '
        'cmdLink
        '
        Me.cmdLink.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdLink.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLink.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLink.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLink.Location = New System.Drawing.Point(424, 104)
        Me.cmdLink.Name = "cmdLink"
        Me.cmdLink.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLink.Size = New System.Drawing.Size(69, 25)
        Me.cmdLink.TabIndex = 14
        Me.cmdLink.Text = "Re&Link"
        Me.cmdLink.UseVisualStyleBackColor = True
        Me.cmdLink.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(499, 104)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(69, 25)
        Me.cmdClose.TabIndex = 13
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.Visible = False
        '
        'DispTimer
        '
        Me.DispTimer.Enabled = True
        Me.DispTimer.Interval = 25
        '
        'picIpod
        '
        Me.picIpod.BackColor = System.Drawing.SystemColors.Window
        Me.picIpod.BackgroundImage = CType(resources.GetObject("picIpod.BackgroundImage"), System.Drawing.Image)
        Me.picIpod.ContextMenuStrip = Me.mnuCon
        Me.picIpod.Controls.Add(Me.picPause)
        Me.picIpod.Controls.Add(Me.picDownArrow)
        Me.picIpod.Controls.Add(Me.picUpArrow)
        Me.picIpod.Controls.Add(Me.picLowBatt)
        Me.picIpod.Controls.Add(Me.PicLEDON)
        Me.picIpod.Controls.Add(Me.PicCC)
        Me.picIpod.Controls.Add(Me._imgKey_10)
        Me.picIpod.Controls.Add(Me._lblDisp_1)
        Me.picIpod.Controls.Add(Me._imgKey_17)
        Me.picIpod.Controls.Add(Me._imgKey_18)
        Me.picIpod.Controls.Add(Me._imgKey_16)
        Me.picIpod.Controls.Add(Me._imgKey_11)
        Me.picIpod.Controls.Add(Me._imgKey_19)
        Me.picIpod.Controls.Add(Me._lblDisp_7)
        Me.picIpod.Controls.Add(Me._lblDisp_6)
        Me.picIpod.Controls.Add(Me._lblDisp_0)
        Me.picIpod.Controls.Add(Me.lblLO)
        Me.picIpod.Controls.Add(Me._lblDisp_5)
        Me.picIpod.Controls.Add(Me._lblDisp_4)
        Me.picIpod.Controls.Add(Me._lblDisp_2)
        Me.picIpod.Controls.Add(Me._lblDisp_3)
        Me.picIpod.Controls.Add(Me._lblDisp_8)
        Me.picIpod.Cursor = System.Windows.Forms.Cursors.Default
        Me.picIpod.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picIpod.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picIpod.Location = New System.Drawing.Point(1, 0)
        Me.picIpod.Name = "picIpod"
        Me.picIpod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picIpod.Size = New System.Drawing.Size(325, 440)
        Me.picIpod.TabIndex = 0
        Me.picIpod.TabStop = True
        '
        'mnuCon
        '
        Me.mnuCon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JumpToolStripMenuItem, Me.SetupAudioRecordingToolStripMenuItem, Me.QuickKeyToolStripMenuItem, Me.EnableLoggingToolStripMenuItem, Me.OpenLogWindowToolStripMenuItem, Me.LockoutToolStripMenuItem, Me.EstablishLinkToolStripMenuItem, Me.DisableLinkToolStripMenuItem, Me.OpacityToolStripMenuItem, Me.AlwaysOnTopToolStripMenuItem, Me.FontToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnuCon.Name = "mnuCon"
        Me.mnuCon.Size = New System.Drawing.Size(206, 290)
        '
        'JumpToolStripMenuItem
        '
        Me.JumpToolStripMenuItem.Name = "JumpToolStripMenuItem"
        Me.JumpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.JumpToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.JumpToolStripMenuItem.Text = "&Jump..."
        '
        'QuickKeyToolStripMenuItem
        '
        Me.QuickKeyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.QuickKeyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QK0, Me.QK1, Me.QK2, Me.QK3, Me.QK4, Me.Qk5, Me.QK6, Me.QK7, Me.QK8, Me.QK9})
        Me.QuickKeyToolStripMenuItem.Name = "QuickKeyToolStripMenuItem"
        Me.QuickKeyToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.QuickKeyToolStripMenuItem.Text = "Quick Key"
        '
        'QK0
        '
        Me.QK0.Name = "QK0"
        Me.QK0.Size = New System.Drawing.Size(80, 22)
        Me.QK0.Text = "0"
        '
        'QK1
        '
        Me.QK1.Name = "QK1"
        Me.QK1.Size = New System.Drawing.Size(80, 22)
        Me.QK1.Text = "1"
        '
        'QK2
        '
        Me.QK2.Name = "QK2"
        Me.QK2.Size = New System.Drawing.Size(80, 22)
        Me.QK2.Text = "2"
        '
        'QK3
        '
        Me.QK3.Name = "QK3"
        Me.QK3.Size = New System.Drawing.Size(80, 22)
        Me.QK3.Text = "3"
        '
        'QK4
        '
        Me.QK4.Name = "QK4"
        Me.QK4.Size = New System.Drawing.Size(80, 22)
        Me.QK4.Text = "4"
        '
        'Qk5
        '
        Me.Qk5.Name = "Qk5"
        Me.Qk5.Size = New System.Drawing.Size(80, 22)
        Me.Qk5.Text = "5"
        '
        'QK6
        '
        Me.QK6.Name = "QK6"
        Me.QK6.Size = New System.Drawing.Size(80, 22)
        Me.QK6.Text = "6"
        '
        'QK7
        '
        Me.QK7.Name = "QK7"
        Me.QK7.Size = New System.Drawing.Size(80, 22)
        Me.QK7.Text = "7"
        '
        'QK8
        '
        Me.QK8.Name = "QK8"
        Me.QK8.Size = New System.Drawing.Size(80, 22)
        Me.QK8.Text = "8"
        '
        'QK9
        '
        Me.QK9.Name = "QK9"
        Me.QK9.Size = New System.Drawing.Size(80, 22)
        Me.QK9.Text = "9"
        '
        'EnableLoggingToolStripMenuItem
        '
        Me.EnableLoggingToolStripMenuItem.Name = "EnableLoggingToolStripMenuItem"
        Me.EnableLoggingToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EnableLoggingToolStripMenuItem.Text = "&Enable Logging"
        '
        'OpenLogWindowToolStripMenuItem
        '
        Me.OpenLogWindowToolStripMenuItem.Name = "OpenLogWindowToolStripMenuItem"
        Me.OpenLogWindowToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.OpenLogWindowToolStripMenuItem.Text = "Open Log Window..."
        '
        'LockoutToolStripMenuItem
        '
        Me.LockoutToolStripMenuItem.Name = "LockoutToolStripMenuItem"
        Me.LockoutToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.LockoutToolStripMenuItem.Text = "Lockout"
        '
        'EstablishLinkToolStripMenuItem
        '
        Me.EstablishLinkToolStripMenuItem.Name = "EstablishLinkToolStripMenuItem"
        Me.EstablishLinkToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EstablishLinkToolStripMenuItem.Text = "Establish Link"
        '
        'DisableLinkToolStripMenuItem
        '
        Me.DisableLinkToolStripMenuItem.Name = "DisableLinkToolStripMenuItem"
        Me.DisableLinkToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DisableLinkToolStripMenuItem.Text = "Disable Link"
        '
        'OpacityToolStripMenuItem
        '
        Me.OpacityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.OpacityToolStripMenuItem.Name = "OpacityToolStripMenuItem"
        Me.OpacityToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.OpacityToolStripMenuItem.Text = "Opacity"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripMenuItem2.Text = "100%"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripMenuItem3.Text = "75%"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripMenuItem4.Text = "50%"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripMenuItem5.Text = "25%"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always On Top"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChooseFontToolStripMenuItem, Me.FontColourToolStripMenuItem})
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ChooseFontToolStripMenuItem
        '
        Me.ChooseFontToolStripMenuItem.Name = "ChooseFontToolStripMenuItem"
        Me.ChooseFontToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ChooseFontToolStripMenuItem.Text = "Choose Font..."
        '
        'FontColourToolStripMenuItem
        '
        Me.FontColourToolStripMenuItem.Name = "FontColourToolStripMenuItem"
        Me.FontColourToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.FontColourToolStripMenuItem.Text = "Font Colour..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'picPause
        '
        Me.picPause.BackColor = System.Drawing.SystemColors.Control
        Me.picPause.Cursor = System.Windows.Forms.Cursors.Default
        Me.picPause.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picPause.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picPause.Image = CType(resources.GetObject("picPause.Image"), System.Drawing.Image)
        Me.picPause.Location = New System.Drawing.Point(56, 35)
        Me.picPause.Name = "picPause"
        Me.picPause.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picPause.Size = New System.Drawing.Size(22, 15)
        Me.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPause.TabIndex = 28
        Me.picPause.TabStop = False
        '
        'picDownArrow
        '
        Me.picDownArrow.BackColor = System.Drawing.SystemColors.Window
        Me.picDownArrow.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDownArrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picDownArrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picDownArrow.Image = CType(resources.GetObject("picDownArrow.Image"), System.Drawing.Image)
        Me.picDownArrow.Location = New System.Drawing.Point(233, 57)
        Me.picDownArrow.Name = "picDownArrow"
        Me.picDownArrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picDownArrow.Size = New System.Drawing.Size(13, 18)
        Me.picDownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDownArrow.TabIndex = 17
        Me.picDownArrow.TabStop = False
        Me.picDownArrow.Visible = False
        '
        'picUpArrow
        '
        Me.picUpArrow.BackColor = System.Drawing.SystemColors.Window
        Me.picUpArrow.Cursor = System.Windows.Forms.Cursors.Default
        Me.picUpArrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picUpArrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picUpArrow.Image = CType(resources.GetObject("picUpArrow.Image"), System.Drawing.Image)
        Me.picUpArrow.Location = New System.Drawing.Point(249, 57)
        Me.picUpArrow.Name = "picUpArrow"
        Me.picUpArrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picUpArrow.Size = New System.Drawing.Size(13, 18)
        Me.picUpArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picUpArrow.TabIndex = 16
        Me.picUpArrow.TabStop = False
        Me.picUpArrow.Visible = False
        '
        'picLowBatt
        '
        Me.picLowBatt.BackColor = System.Drawing.SystemColors.Control
        Me.picLowBatt.Cursor = System.Windows.Forms.Cursors.Default
        Me.picLowBatt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picLowBatt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picLowBatt.Image = CType(resources.GetObject("picLowBatt.Image"), System.Drawing.Image)
        Me.picLowBatt.Location = New System.Drawing.Point(253, 33)
        Me.picLowBatt.Name = "picLowBatt"
        Me.picLowBatt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picLowBatt.Size = New System.Drawing.Size(29, 17)
        Me.picLowBatt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLowBatt.TabIndex = 3
        Me.picLowBatt.TabStop = False
        Me.picLowBatt.Visible = False
        '
        'PicLEDON
        '
        Me.PicLEDON.BackColor = System.Drawing.SystemColors.Window
        Me.PicLEDON.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicLEDON.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicLEDON.ForeColor = System.Drawing.Color.Black
        Me.PicLEDON.Image = CType(resources.GetObject("PicLEDON.Image"), System.Drawing.Image)
        Me.PicLEDON.Location = New System.Drawing.Point(42, 35)
        Me.PicLEDON.Name = "PicLEDON"
        Me.PicLEDON.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicLEDON.Size = New System.Drawing.Size(21, 15)
        Me.PicLEDON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicLEDON.TabIndex = 2
        Me.PicLEDON.TabStop = False
        '
        'PicCC
        '
        Me.PicCC.BackColor = System.Drawing.SystemColors.Control
        Me.PicCC.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicCC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicCC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicCC.Image = CType(resources.GetObject("PicCC.Image"), System.Drawing.Image)
        Me.PicCC.Location = New System.Drawing.Point(251, 188)
        Me.PicCC.Name = "PicCC"
        Me.PicCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicCC.Size = New System.Drawing.Size(29, 28)
        Me.PicCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicCC.TabIndex = 1
        Me.PicCC.TabStop = False
        Me.PicCC.Visible = False
        '
        '_lblDisp_1
        '
        Me._lblDisp_1.AutoSize = True
        Me._lblDisp_1.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_1.ForeColor = System.Drawing.Color.Black
        Me.lblDisp.SetIndex(Me._lblDisp_1, CType(1, Short))
        Me._lblDisp_1.Location = New System.Drawing.Point(46, 76)
        Me._lblDisp_1.Name = "_lblDisp_1"
        Me._lblDisp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_1.Size = New System.Drawing.Size(39, 14)
        Me._lblDisp_1.TabIndex = 18
        Me._lblDisp_1.Text = "Label3"
        Me._lblDisp_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_imgKey_17
        '
        Me._imgKey_17.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_17.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_17, CType(17, Short))
        Me._imgKey_17.Location = New System.Drawing.Point(130, 299)
        Me._imgKey_17.Name = "_imgKey_17"
        Me._imgKey_17.Size = New System.Drawing.Size(65, 47)
        Me._imgKey_17.TabIndex = 30
        Me._imgKey_17.TabStop = False
        '
        '_imgKey_18
        '
        Me._imgKey_18.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_18.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_18, CType(18, Short))
        Me._imgKey_18.Location = New System.Drawing.Point(80, 308)
        Me._imgKey_18.Name = "_imgKey_18"
        Me._imgKey_18.Size = New System.Drawing.Size(39, 31)
        Me._imgKey_18.TabIndex = 31
        Me._imgKey_18.TabStop = False
        '
        '_imgKey_16
        '
        Me._imgKey_16.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_16.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_16, CType(16, Short))
        Me._imgKey_16.Location = New System.Drawing.Point(206, 306)
        Me._imgKey_16.Name = "_imgKey_16"
        Me._imgKey_16.Size = New System.Drawing.Size(39, 36)
        Me._imgKey_16.TabIndex = 32
        Me._imgKey_16.TabStop = False
        '
        '_imgKey_19
        '
        Me._imgKey_19.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_19.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_19, CType(19, Short))
        Me._imgKey_19.Location = New System.Drawing.Point(132, 241)
        Me._imgKey_19.Name = "_imgKey_19"
        Me._imgKey_19.Size = New System.Drawing.Size(55, 30)
        Me._imgKey_19.TabIndex = 34
        Me._imgKey_19.TabStop = False
        '
        '_lblDisp_7
        '
        Me._lblDisp_7.AutoSize = True
        Me._lblDisp_7.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_7.ForeColor = System.Drawing.Color.Black
        Me.lblDisp.SetIndex(Me._lblDisp_7, CType(7, Short))
        Me._lblDisp_7.Location = New System.Drawing.Point(46, 136)
        Me._lblDisp_7.Name = "_lblDisp_7"
        Me._lblDisp_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_7.Size = New System.Drawing.Size(64, 14)
        Me._lblDisp_7.TabIndex = 12
        Me._lblDisp_7.Text = "LBLMOD 07"
        Me._lblDisp_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblDisp_6
        '
        Me._lblDisp_6.AutoSize = True
        Me._lblDisp_6.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_6.ForeColor = System.Drawing.Color.Black
        Me.lblDisp.SetIndex(Me._lblDisp_6, CType(6, Short))
        Me._lblDisp_6.Location = New System.Drawing.Point(46, 196)
        Me._lblDisp_6.Name = "_lblDisp_6"
        Me._lblDisp_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_6.Size = New System.Drawing.Size(41, 14)
        Me._lblDisp_6.TabIndex = 11
        Me._lblDisp_6.Text = "LBLID6"
        Me._lblDisp_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblDisp_0
        '
        Me._lblDisp_0.AutoSize = True
        Me._lblDisp_0.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_0.ForeColor = System.Drawing.Color.Black
        Me.lblDisp.SetIndex(Me._lblDisp_0, CType(0, Short))
        Me._lblDisp_0.Location = New System.Drawing.Point(138, 52)
        Me._lblDisp_0.Name = "_lblDisp_0"
        Me._lblDisp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_0.Size = New System.Drawing.Size(39, 14)
        Me._lblDisp_0.TabIndex = 10
        Me._lblDisp_0.Text = "Label3"
        Me._lblDisp_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLO
        '
        Me.lblLO.AutoSize = True
        Me.lblLO.BackColor = System.Drawing.Color.Transparent
        Me.lblLO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLO.ForeColor = System.Drawing.Color.Red
        Me.lblLO.Location = New System.Drawing.Point(112, 64)
        Me.lblLO.Name = "lblLO"
        Me.lblLO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLO.Size = New System.Drawing.Size(24, 14)
        Me.lblLO.TabIndex = 9
        Me.lblLO.Text = "L/O"
        '
        '_lblDisp_5
        '
        Me._lblDisp_5.AutoSize = True
        Me._lblDisp_5.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_5.ForeColor = System.Drawing.Color.Black
        Me.lblDisp.SetIndex(Me._lblDisp_5, CType(5, Short))
        Me._lblDisp_5.Location = New System.Drawing.Point(46, 176)
        Me._lblDisp_5.Name = "_lblDisp_5"
        Me._lblDisp_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_5.Size = New System.Drawing.Size(39, 14)
        Me._lblDisp_5.TabIndex = 8
        Me._lblDisp_5.Text = "Label3"
        Me._lblDisp_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblDisp_4
        '
        Me._lblDisp_4.AutoSize = True
        Me._lblDisp_4.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_4.ForeColor = System.Drawing.Color.Black
        Me.lblDisp.SetIndex(Me._lblDisp_4, CType(4, Short))
        Me._lblDisp_4.Location = New System.Drawing.Point(46, 156)
        Me._lblDisp_4.Name = "_lblDisp_4"
        Me._lblDisp_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_4.Size = New System.Drawing.Size(39, 14)
        Me._lblDisp_4.TabIndex = 7
        Me._lblDisp_4.Text = "Label3"
        Me._lblDisp_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblDisp_2
        '
        Me._lblDisp_2.AutoSize = True
        Me._lblDisp_2.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_2.ForeColor = System.Drawing.Color.Black
        Me.lblDisp.SetIndex(Me._lblDisp_2, CType(2, Short))
        Me._lblDisp_2.Location = New System.Drawing.Point(46, 96)
        Me._lblDisp_2.Name = "_lblDisp_2"
        Me._lblDisp_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_2.Size = New System.Drawing.Size(39, 14)
        Me._lblDisp_2.TabIndex = 6
        Me._lblDisp_2.Text = "Label3"
        Me._lblDisp_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblDisp_3
        '
        Me._lblDisp_3.AutoSize = True
        Me._lblDisp_3.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_3.ForeColor = System.Drawing.Color.Black
        Me.lblDisp.SetIndex(Me._lblDisp_3, CType(3, Short))
        Me._lblDisp_3.Location = New System.Drawing.Point(46, 116)
        Me._lblDisp_3.Name = "_lblDisp_3"
        Me._lblDisp_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_3.Size = New System.Drawing.Size(39, 14)
        Me._lblDisp_3.TabIndex = 5
        Me._lblDisp_3.Text = "Label3"
        Me._lblDisp_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblDisp_8
        '
        Me._lblDisp_8.AutoSize = True
        Me._lblDisp_8.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_8.ForeColor = System.Drawing.Color.Black
        Me.lblDisp.SetIndex(Me._lblDisp_8, CType(8, Short))
        Me._lblDisp_8.Location = New System.Drawing.Point(42, 50)
        Me._lblDisp_8.Name = "_lblDisp_8"
        Me._lblDisp_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_8.Size = New System.Drawing.Size(38, 14)
        Me._lblDisp_8.TabIndex = 4
        Me._lblDisp_8.Text = "LBL08"
        '
        'imgKey
        '
        '
        'mnuQK
        '
        '
        '_mnuQK_0
        '
        Me.mnuQK.SetIndex(Me._mnuQK_0, CType(0, Short))
        Me._mnuQK_0.Name = "_mnuQK_0"
        Me._mnuQK_0.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_0.Text = "0"
        '
        '_mnuQK_1
        '
        Me.mnuQK.SetIndex(Me._mnuQK_1, CType(1, Short))
        Me._mnuQK_1.Name = "_mnuQK_1"
        Me._mnuQK_1.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_1.Text = "1"
        '
        '_mnuQK_2
        '
        Me.mnuQK.SetIndex(Me._mnuQK_2, CType(2, Short))
        Me._mnuQK_2.Name = "_mnuQK_2"
        Me._mnuQK_2.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_2.Text = "2"
        '
        '_mnuQK_3
        '
        Me.mnuQK.SetIndex(Me._mnuQK_3, CType(3, Short))
        Me._mnuQK_3.Name = "_mnuQK_3"
        Me._mnuQK_3.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_3.Text = "3"
        '
        '_mnuQK_4
        '
        Me.mnuQK.SetIndex(Me._mnuQK_4, CType(4, Short))
        Me._mnuQK_4.Name = "_mnuQK_4"
        Me._mnuQK_4.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_4.Text = "4"
        '
        '_mnuQK_5
        '
        Me.mnuQK.SetIndex(Me._mnuQK_5, CType(5, Short))
        Me._mnuQK_5.Name = "_mnuQK_5"
        Me._mnuQK_5.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_5.Text = "5"
        '
        '_mnuQK_6
        '
        Me.mnuQK.SetIndex(Me._mnuQK_6, CType(6, Short))
        Me._mnuQK_6.Name = "_mnuQK_6"
        Me._mnuQK_6.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_6.Text = "6"
        '
        '_mnuQK_7
        '
        Me.mnuQK.SetIndex(Me._mnuQK_7, CType(7, Short))
        Me._mnuQK_7.Name = "_mnuQK_7"
        Me._mnuQK_7.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_7.Text = "7"
        '
        '_mnuQK_8
        '
        Me.mnuQK.SetIndex(Me._mnuQK_8, CType(8, Short))
        Me._mnuQK_8.Name = "_mnuQK_8"
        Me._mnuQK_8.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_8.Text = "8"
        '
        '_mnuQK_9
        '
        Me.mnuQK.SetIndex(Me._mnuQK_9, CType(9, Short))
        Me._mnuQK_9.Name = "_mnuQK_9"
        Me._mnuQK_9.Size = New System.Drawing.Size(80, 22)
        Me._mnuQK_9.Text = "9"
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit})
        Me.MainMenu1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(321, 206)
        Me.MainMenu1.TabIndex = 28
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditJump, Me.mnuEditQK, Me.mnuEnableLog, Me.mnuViewLog, Me.mnuEditLO, Me.mnuEditEstLink, Me.mnuEditStopLink, Me.mnuEditF, Me.mnuEditExit})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(314, 19)
        Me.mnuEdit.Text = "Edit"
        Me.mnuEdit.Visible = False
        '
        'mnuEditJump
        '
        Me.mnuEditJump.Name = "mnuEditJump"
        Me.mnuEditJump.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.mnuEditJump.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditJump.Text = "&Jump To Frequency..."
        '
        'mnuEditQK
        '
        Me.mnuEditQK.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnuQK_0, Me._mnuQK_1, Me._mnuQK_2, Me._mnuQK_3, Me._mnuQK_4, Me._mnuQK_5, Me._mnuQK_6, Me._mnuQK_7, Me._mnuQK_8, Me._mnuQK_9})
        Me.mnuEditQK.Name = "mnuEditQK"
        Me.mnuEditQK.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditQK.Text = "Quick &Key"
        '
        'mnuEnableLog
        '
        Me.mnuEnableLog.Name = "mnuEnableLog"
        Me.mnuEnableLog.Size = New System.Drawing.Size(225, 22)
        Me.mnuEnableLog.Text = "E&nable Logging"
        '
        'mnuViewLog
        '
        Me.mnuViewLog.Name = "mnuViewLog"
        Me.mnuViewLog.Size = New System.Drawing.Size(225, 22)
        Me.mnuViewLog.Text = "O&pen Log Window..."
        '
        'mnuEditLO
        '
        Me.mnuEditLO.Name = "mnuEditLO"
        Me.mnuEditLO.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditLO.Text = "Lockou&t"
        '
        'mnuEditEstLink
        '
        Me.mnuEditEstLink.Name = "mnuEditEstLink"
        Me.mnuEditEstLink.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditEstLink.Text = "&Establish Link"
        '
        'mnuEditStopLink
        '
        Me.mnuEditStopLink.Name = "mnuEditStopLink"
        Me.mnuEditStopLink.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditStopLink.Text = "&Stop Link"
        '
        'mnuEditF
        '
        Me.mnuEditF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditFont, Me.mnuEditFontCOlour})
        Me.mnuEditF.Name = "mnuEditF"
        Me.mnuEditF.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditF.Text = "&Font"
        '
        'mnuEditFont
        '
        Me.mnuEditFont.Name = "mnuEditFont"
        Me.mnuEditFont.Size = New System.Drawing.Size(150, 22)
        Me.mnuEditFont.Text = "C&hoose Font..."
        '
        'mnuEditFontCOlour
        '
        Me.mnuEditFontCOlour.Name = "mnuEditFontCOlour"
        Me.mnuEditFontCOlour.Size = New System.Drawing.Size(150, 22)
        Me.mnuEditFontCOlour.Text = "Font &Colour..."
        '
        'mnuEditExit
        '
        Me.mnuEditExit.Name = "mnuEditExit"
        Me.mnuEditExit.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditExit.Text = "E&xit"
        '
        'SetupAudioRecordingToolStripMenuItem
        '
        Me.SetupAudioRecordingToolStripMenuItem.Name = "SetupAudioRecordingToolStripMenuItem"
        Me.SetupAudioRecordingToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SetupAudioRecordingToolStripMenuItem.Text = "Setup Audio Recording..."
        '
        'frmCtlIpod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(321, 438)
        Me.ContextMenuStrip = Me.mnuCon
        Me.Controls.Add(Me._picBatt_1)
        Me.Controls.Add(Me._picSigLvl_4)
        Me.Controls.Add(Me._picSigLvl_3)
        Me.Controls.Add(Me._picSigLvl_2)
        Me.Controls.Add(Me._picSigLvl_1)
        Me.Controls.Add(Me._picSigLvl_0)
        Me.Controls.Add(Me._picBatt_3)
        Me.Controls.Add(Me._picBatt_2)
        Me.Controls.Add(Me._picBatt_0)
        Me.Controls.Add(Me.cmdStopCom)
        Me.Controls.Add(Me.cmdLink)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.picIpod)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 30)
        Me.MainMenuStrip = Me.MainMenu1
        Me.MaximumSize = New System.Drawing.Size(337, 476)
        Me.Name = "frmCtlIpod"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "FreeSCAN"
        CType(Me._imgKey_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._picBatt_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._picSigLvl_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._picSigLvl_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._picSigLvl_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._picSigLvl_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._picSigLvl_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._picBatt_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._picBatt_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._picBatt_0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picIpod.ResumeLayout(False)
        Me.picIpod.PerformLayout()
        Me.mnuCon.ResumeLayout(False)
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDownArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLowBatt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLEDON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDisp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuQK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBatt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSigLvl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents mnuCon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents JumpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuickKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QK0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QK1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QK2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QK3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QK4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Qk5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QK6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QK7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QK8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QK9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableLoggingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenLogWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstablishLinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableLinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChooseFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontColourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpacityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupAudioRecordingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
#End Region 
End Class