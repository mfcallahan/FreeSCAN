<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCtlWin
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
    Public WithEvents prgSignal As System.Windows.Forms.ProgressBar
	Public WithEvents prgBat As System.Windows.Forms.ProgressBar
	Public WithEvents prgP25 As System.Windows.Forms.ProgressBar
    Public WithEvents lblBat As System.Windows.Forms.Label
    Public WithEvents picLowBatt As System.Windows.Forms.PictureBox
	Public WithEvents picLEDOff As System.Windows.Forms.PictureBox
	Public WithEvents PicLEDON As System.Windows.Forms.PictureBox
	Public WithEvents picUpArrow As System.Windows.Forms.PictureBox
	Public WithEvents picDownArrow As System.Windows.Forms.PictureBox
	Public WithEvents PicCC As System.Windows.Forms.PictureBox
    Public WithEvents cmdLink As System.Windows.Forms.Button
	Public WithEvents cmdStopCom As System.Windows.Forms.Button
	Public CommonDialogOpen As System.Windows.Forms.OpenFileDialog
	Public CommonDialogFont As System.Windows.Forms.FontDialog
	Public CommonDialogColor As System.Windows.Forms.ColorDialog
    Public WithEvents _lblDisp_7 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_6 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_0 As System.Windows.Forms.Label
	Public WithEvents _lblCursor_2 As System.Windows.Forms.Label
	Public WithEvents _lblCursor_1 As System.Windows.Forms.Label
	Public WithEvents _lblCursor_0 As System.Windows.Forms.Label
	Public WithEvents lblLO As System.Windows.Forms.Label
	Public WithEvents lblHold As System.Windows.Forms.Label
	Public WithEvents _lblDisp_5 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_4 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_2 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_1 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_3 As System.Windows.Forms.Label
    Public WithEvents _lblDisp_8 As System.Windows.Forms.Label
	Public WithEvents Shape1 As System.Windows.Forms.Label
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents PicKeyUp As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Public WithEvents imgKeyOld As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents lblCursor As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblDisp As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents mnuJServ As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents mnuJServMain As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents mnuWX As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents picKeyDown As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents mnuEnableLog As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditViewLog As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditFont As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditFontColor As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditF As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuToolsNegDlyEnable As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuToolsNegDlyTime As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuToolsNegDelay As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuEditExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuJScan As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_1 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_2 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_3 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_4 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_5 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_6 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_7 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_8 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_9 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_10 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_11 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_12 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServ_13 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuJServMain_0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuJCust As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuJCC As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuWX_0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuWX_1 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuWX_2 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuWX_3 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuWX_4 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuWX_5 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuWX_6 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuWX_7 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuJWX As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuJFTO As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuJump As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim _Label1_1 As System.Windows.Forms.Label
        Dim _Label1_0 As System.Windows.Forms.Label
        Dim _Label1_2 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtlWin))
        Me.BLO = New System.Windows.Forms.Button()
        Me.BMENU = New System.Windows.Forms.Button()
        Me.BGPS = New System.Windows.Forms.Button()
        Me.BWX = New System.Windows.Forms.Button()
        Me.BPRI = New System.Windows.Forms.Button()
        Me.BYES = New System.Windows.Forms.Button()
        Me.B0 = New System.Windows.Forms.Button()
        Me.BNO = New System.Windows.Forms.Button()
        Me.B9 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.B7 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.chkTopMost = New System.Windows.Forms.CheckBox()
        Me.sldSql = New System.Windows.Forms.TrackBar()
        Me.sldVol = New System.Windows.Forms.TrackBar()
        Me._lblDisp_4 = New System.Windows.Forms.Label()
        Me.prgSignal = New System.Windows.Forms.ProgressBar()
        Me.sldOpacity = New System.Windows.Forms.TrackBar()
        Me.prgBat = New System.Windows.Forms.ProgressBar()
        Me._lblDisp_3 = New System.Windows.Forms.Label()
        Me.prgP25 = New System.Windows.Forms.ProgressBar()
        Me._lblCursor_2 = New System.Windows.Forms.Label()
        Me.lblBat = New System.Windows.Forms.Label()
        Me._lblDisp_1 = New System.Windows.Forms.Label()
        Me._lblDisp_2 = New System.Windows.Forms.Label()
        Me._lblDisp_8 = New System.Windows.Forms.Label()
        Me._lblDisp_5 = New System.Windows.Forms.Label()
        Me.picLowBatt = New System.Windows.Forms.PictureBox()
        Me.lblHold = New System.Windows.Forms.Label()
        Me.lblLO = New System.Windows.Forms.Label()
        Me.picLEDOff = New System.Windows.Forms.PictureBox()
        Me._lblCursor_0 = New System.Windows.Forms.Label()
        Me._lblCursor_1 = New System.Windows.Forms.Label()
        Me.PicLEDON = New System.Windows.Forms.PictureBox()
        Me._lblDisp_0 = New System.Windows.Forms.Label()
        Me._lblDisp_6 = New System.Windows.Forms.Label()
        Me.picUpArrow = New System.Windows.Forms.PictureBox()
        Me._lblDisp_7 = New System.Windows.Forms.Label()
        Me.cmdStopCom = New System.Windows.Forms.Button()
        Me.picDownArrow = New System.Windows.Forms.PictureBox()
        Me.cmdLink = New System.Windows.Forms.Button()
        Me.PicCC = New System.Windows.Forms.PictureBox()
        Me.Shape1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CommonDialogOpen = New System.Windows.Forms.OpenFileDialog()
        Me.CommonDialogFont = New System.Windows.Forms.FontDialog()
        Me.CommonDialogColor = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.PicKeyUp = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.imgKeyOld = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.lblCursor = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblDisp = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.mnuJServ = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me._mnuJServ_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_9 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_10 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_11 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_12 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuJServ_13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJServMain = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me._mnuJServMain_0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWX = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me._mnuWX_0 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuWX_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuWX_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuWX_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuWX_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuWX_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuWX_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuWX_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.picKeyDown = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.JumpToFrequencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupAudioRecordingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnableLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditViewLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditFontColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsNegDelay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsNegDlyEnable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsNegDlyTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHideMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJump = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJScan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJCust = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJCC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJWX = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJFTO = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BVOL = New System.Windows.Forms.Button()
        Me.BSQL = New System.Windows.Forms.Button()
        Me.BLEFT = New System.Windows.Forms.Button()
        Me.BFUNC = New System.Windows.Forms.Button()
        Me.BRIGHT = New System.Windows.Forms.Button()
        Me.BSCAN = New System.Windows.Forms.Button()
        Me.BHOLD = New System.Windows.Forms.Button()
        Me.BPWR = New System.Windows.Forms.Button()
        Me.PicRecord = New System.Windows.Forms.PictureBox()
        Me.PicRecordOff = New System.Windows.Forms.PictureBox()
        Me.lblNegDelay = New System.Windows.Forms.Label()
        _Label1_1 = New System.Windows.Forms.Label()
        _Label1_0 = New System.Windows.Forms.Label()
        _Label1_2 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.sldSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldVol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLowBatt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLEDOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLEDON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDownArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicKeyUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgKeyOld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDisp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuJServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuJServMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuWX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu1.SuspendLayout()
        CType(Me.PicRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRecordOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Label1_1
        '
        _Label1_1.AutoSize = True
        _Label1_1.BackColor = System.Drawing.Color.Transparent
        _Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        _Label1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(_Label1_1, CType(1, Short))
        _Label1_1.Location = New System.Drawing.Point(586, 185)
        _Label1_1.Name = "_Label1_1"
        _Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label1_1.Size = New System.Drawing.Size(71, 14)
        _Label1_1.TabIndex = 91
        _Label1_1.Text = "Battery Level"
        '
        '_Label1_0
        '
        _Label1_0.AutoSize = True
        _Label1_0.BackColor = System.Drawing.Color.Transparent
        _Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        _Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label1_0.ForeColor = System.Drawing.Color.Black
        Me.Label1.SetIndex(_Label1_0, CType(0, Short))
        _Label1_0.Location = New System.Drawing.Point(386, 185)
        _Label1_0.Name = "_Label1_0"
        _Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label1_0.Size = New System.Drawing.Size(80, 14)
        _Label1_0.TabIndex = 90
        _Label1_0.Text = "Signal Strength"
        '
        '_Label1_2
        '
        _Label1_2.AutoSize = True
        _Label1_2.BackColor = System.Drawing.Color.Transparent
        _Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        _Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(_Label1_2, CType(2, Short))
        _Label1_2.Location = New System.Drawing.Point(493, 185)
        _Label1_2.Name = "_Label1_2"
        _Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label1_2.Size = New System.Drawing.Size(67, 14)
        _Label1_2.TabIndex = 88
        _Label1_2.Text = "P25 Err Rate"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Cursor = System.Windows.Forms.Cursors.Default
        Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Label2.Location = New System.Drawing.Point(23, 172)
        Label2.Name = "Label2"
        Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label2.Size = New System.Drawing.Size(44, 14)
        Label2.TabIndex = 92
        Label2.Text = "Opacity"
        '
        'BLO
        '
        Me.BLO.BackColor = System.Drawing.Color.DarkGray
        Me.BLO.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BLO.ForeColor = System.Drawing.Color.DarkRed
        Me.BLO.Location = New System.Drawing.Point(387, 140)
        Me.BLO.Name = "BLO"
        Me.BLO.Size = New System.Drawing.Size(44, 21)
        Me.BLO.TabIndex = 111
        Me.BLO.Text = "&L/O"
        Me.BLO.UseVisualStyleBackColor = True
        '
        'BMENU
        '
        Me.BMENU.BackColor = System.Drawing.Color.DarkGray
        Me.BMENU.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BMENU.ForeColor = System.Drawing.Color.Black
        Me.BMENU.Location = New System.Drawing.Point(387, 115)
        Me.BMENU.Name = "BMENU"
        Me.BMENU.Size = New System.Drawing.Size(44, 21)
        Me.BMENU.TabIndex = 110
        Me.BMENU.Text = "&MENU"
        Me.BMENU.UseVisualStyleBackColor = True
        '
        'BGPS
        '
        Me.BGPS.BackColor = System.Drawing.Color.DarkGray
        Me.BGPS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BGPS.ForeColor = System.Drawing.Color.Black
        Me.BGPS.Location = New System.Drawing.Point(387, 90)
        Me.BGPS.Name = "BGPS"
        Me.BGPS.Size = New System.Drawing.Size(44, 21)
        Me.BGPS.TabIndex = 109
        Me.BGPS.Text = "&GPS"
        Me.BGPS.UseVisualStyleBackColor = True
        '
        'BWX
        '
        Me.BWX.BackColor = System.Drawing.Color.DarkGray
        Me.BWX.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BWX.ForeColor = System.Drawing.Color.Black
        Me.BWX.Location = New System.Drawing.Point(387, 65)
        Me.BWX.Name = "BWX"
        Me.BWX.Size = New System.Drawing.Size(44, 21)
        Me.BWX.TabIndex = 108
        Me.BWX.Text = "&WX"
        Me.BWX.UseVisualStyleBackColor = True
        '
        'BPRI
        '
        Me.BPRI.BackColor = System.Drawing.Color.DarkGray
        Me.BPRI.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BPRI.ForeColor = System.Drawing.Color.Black
        Me.BPRI.Location = New System.Drawing.Point(387, 40)
        Me.BPRI.Name = "BPRI"
        Me.BPRI.Size = New System.Drawing.Size(44, 21)
        Me.BPRI.TabIndex = 107
        Me.BPRI.Text = "&PRI"
        Me.BPRI.UseVisualStyleBackColor = True
        '
        'BYES
        '
        Me.BYES.BackColor = System.Drawing.Color.Silver
        Me.BYES.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BYES.ForeColor = System.Drawing.Color.Black
        Me.BYES.Location = New System.Drawing.Point(527, 123)
        Me.BYES.Name = "BYES"
        Me.BYES.Size = New System.Drawing.Size(35, 21)
        Me.BYES.TabIndex = 106
        Me.BYES.Text = "&Yes"
        Me.BYES.UseVisualStyleBackColor = True
        '
        'B0
        '
        Me.B0.BackColor = System.Drawing.Color.Silver
        Me.B0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B0.ForeColor = System.Drawing.Color.Black
        Me.B0.Location = New System.Drawing.Point(484, 123)
        Me.B0.Name = "B0"
        Me.B0.Size = New System.Drawing.Size(35, 21)
        Me.B0.TabIndex = 105
        Me.B0.Text = "&0"
        Me.B0.UseVisualStyleBackColor = True
        '
        'BNO
        '
        Me.BNO.BackColor = System.Drawing.Color.Silver
        Me.BNO.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BNO.ForeColor = System.Drawing.Color.Black
        Me.BNO.Location = New System.Drawing.Point(441, 123)
        Me.BNO.Name = "BNO"
        Me.BNO.Size = New System.Drawing.Size(35, 21)
        Me.BNO.TabIndex = 104
        Me.BNO.Text = "&. No"
        Me.BNO.UseVisualStyleBackColor = True
        '
        'B9
        '
        Me.B9.BackColor = System.Drawing.Color.Silver
        Me.B9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B9.ForeColor = System.Drawing.Color.Black
        Me.B9.Location = New System.Drawing.Point(527, 96)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(35, 21)
        Me.B9.TabIndex = 103
        Me.B9.Text = "&9"
        Me.B9.UseVisualStyleBackColor = True
        '
        'B8
        '
        Me.B8.BackColor = System.Drawing.Color.Silver
        Me.B8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B8.ForeColor = System.Drawing.Color.Black
        Me.B8.Location = New System.Drawing.Point(484, 96)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(35, 21)
        Me.B8.TabIndex = 102
        Me.B8.Text = "&8"
        Me.B8.UseVisualStyleBackColor = True
        '
        'B7
        '
        Me.B7.BackColor = System.Drawing.Color.Silver
        Me.B7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B7.ForeColor = System.Drawing.Color.Black
        Me.B7.Location = New System.Drawing.Point(441, 96)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(35, 21)
        Me.B7.TabIndex = 101
        Me.B7.Text = "&7"
        Me.B7.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.BackColor = System.Drawing.Color.Silver
        Me.B6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B6.ForeColor = System.Drawing.Color.Black
        Me.B6.Location = New System.Drawing.Point(527, 67)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(35, 21)
        Me.B6.TabIndex = 100
        Me.B6.Text = "&6"
        Me.B6.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.BackColor = System.Drawing.Color.Silver
        Me.B5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B5.ForeColor = System.Drawing.Color.Black
        Me.B5.Location = New System.Drawing.Point(484, 67)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(35, 21)
        Me.B5.TabIndex = 99
        Me.B5.Text = "&5"
        Me.B5.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.BackColor = System.Drawing.Color.Silver
        Me.B4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B4.ForeColor = System.Drawing.Color.Black
        Me.B4.Location = New System.Drawing.Point(441, 67)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(35, 21)
        Me.B4.TabIndex = 98
        Me.B4.Text = "&4"
        Me.B4.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.BackColor = System.Drawing.Color.Silver
        Me.B3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B3.ForeColor = System.Drawing.Color.Black
        Me.B3.Location = New System.Drawing.Point(527, 40)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(35, 21)
        Me.B3.TabIndex = 97
        Me.B3.Text = "&3"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.Silver
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B2.ForeColor = System.Drawing.Color.Black
        Me.B2.Location = New System.Drawing.Point(484, 40)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(35, 21)
        Me.B2.TabIndex = 96
        Me.B2.Text = "&2"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.Silver
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B1.ForeColor = System.Drawing.Color.Black
        Me.B1.Location = New System.Drawing.Point(441, 40)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(35, 21)
        Me.B1.TabIndex = 95
        Me.B1.Text = "&1"
        Me.B1.UseVisualStyleBackColor = True
        '
        'chkTopMost
        '
        Me.chkTopMost.AutoSize = True
        Me.chkTopMost.ForeColor = System.Drawing.Color.Black
        Me.chkTopMost.Location = New System.Drawing.Point(86, 169)
        Me.chkTopMost.Name = "chkTopMost"
        Me.chkTopMost.Size = New System.Drawing.Size(43, 18)
        Me.chkTopMost.TabIndex = 94
        Me.chkTopMost.Text = "&Top"
        Me.chkTopMost.UseVisualStyleBackColor = True
        '
        'sldSql
        '
        Me.sldSql.Location = New System.Drawing.Point(9, 49)
        Me.sldSql.Maximum = 19
        Me.sldSql.Name = "sldSql"
        Me.sldSql.Size = New System.Drawing.Size(124, 45)
        Me.sldSql.TabIndex = 93
        Me.sldSql.Value = 1
        '
        'sldVol
        '
        Me.sldVol.Location = New System.Drawing.Point(11, 123)
        Me.sldVol.Maximum = 29
        Me.sldVol.Name = "sldVol"
        Me.sldVol.Size = New System.Drawing.Size(124, 45)
        Me.sldVol.TabIndex = 92
        Me.sldVol.Value = 1
        '
        '_lblDisp_4
        '
        Me._lblDisp_4.AutoSize = True
        Me._lblDisp_4.BackColor = System.Drawing.Color.Black
        Me._lblDisp_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_4, CType(4, Short))
        Me._lblDisp_4.Location = New System.Drawing.Point(163, 150)
        Me._lblDisp_4.Name = "_lblDisp_4"
        Me._lblDisp_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_4.Size = New System.Drawing.Size(47, 16)
        Me._lblDisp_4.TabIndex = 71
        Me._lblDisp_4.Text = "LINE 4"
        '
        'prgSignal
        '
        Me.prgSignal.Location = New System.Drawing.Point(387, 204)
        Me.prgSignal.MarqueeAnimationSpeed = 5
        Me.prgSignal.Maximum = 1025
        Me.prgSignal.Name = "prgSignal"
        Me.prgSignal.Size = New System.Drawing.Size(89, 21)
        Me.prgSignal.TabIndex = 84
        '
        'sldOpacity
        '
        Me.sldOpacity.AutoSize = False
        Me.sldOpacity.Location = New System.Drawing.Point(15, 189)
        Me.sldOpacity.Minimum = 2
        Me.sldOpacity.Name = "sldOpacity"
        Me.sldOpacity.Size = New System.Drawing.Size(118, 49)
        Me.sldOpacity.TabIndex = 89
        Me.sldOpacity.Value = 10
        '
        'prgBat
        '
        Me.prgBat.Location = New System.Drawing.Point(583, 204)
        Me.prgBat.Name = "prgBat"
        Me.prgBat.Size = New System.Drawing.Size(89, 21)
        Me.prgBat.TabIndex = 85
        '
        '_lblDisp_3
        '
        Me._lblDisp_3.AutoSize = True
        Me._lblDisp_3.BackColor = System.Drawing.Color.Black
        Me._lblDisp_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_3, CType(3, Short))
        Me._lblDisp_3.Location = New System.Drawing.Point(163, 129)
        Me._lblDisp_3.Name = "_lblDisp_3"
        Me._lblDisp_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_3.Size = New System.Drawing.Size(47, 16)
        Me._lblDisp_3.TabIndex = 68
        Me._lblDisp_3.Text = "LINE 3"
        '
        'prgP25
        '
        Me.prgP25.Location = New System.Drawing.Point(485, 204)
        Me.prgP25.Maximum = 99
        Me.prgP25.Name = "prgP25"
        Me.prgP25.Size = New System.Drawing.Size(89, 21)
        Me.prgP25.TabIndex = 86
        '
        '_lblCursor_2
        '
        Me._lblCursor_2.BackColor = System.Drawing.Color.Black
        Me._lblCursor_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCursor_2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCursor_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCursor.SetIndex(Me._lblCursor_2, CType(2, Short))
        Me._lblCursor_2.Location = New System.Drawing.Point(165, 180)
        Me._lblCursor_2.Name = "_lblCursor_2"
        Me._lblCursor_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCursor_2.Size = New System.Drawing.Size(153, 14)
        Me._lblCursor_2.TabIndex = 77
        Me._lblCursor_2.Text = "-----------"
        Me._lblCursor_2.Visible = False
        '
        'lblBat
        '
        Me.lblBat.AutoSize = True
        Me.lblBat.BackColor = System.Drawing.Color.Transparent
        Me.lblBat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBat.Location = New System.Drawing.Point(606, 228)
        Me.lblBat.Name = "lblBat"
        Me.lblBat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBat.Size = New System.Drawing.Size(39, 14)
        Me.lblBat.TabIndex = 89
        Me.lblBat.Text = "0.00 V"
        '
        '_lblDisp_1
        '
        Me._lblDisp_1.AutoSize = True
        Me._lblDisp_1.BackColor = System.Drawing.Color.Black
        Me._lblDisp_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_1, CType(1, Short))
        Me._lblDisp_1.Location = New System.Drawing.Point(163, 87)
        Me._lblDisp_1.Name = "_lblDisp_1"
        Me._lblDisp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_1.Size = New System.Drawing.Size(47, 16)
        Me._lblDisp_1.TabIndex = 69
        Me._lblDisp_1.Text = "LINE 1"
        '
        '_lblDisp_2
        '
        Me._lblDisp_2.AutoSize = True
        Me._lblDisp_2.BackColor = System.Drawing.Color.Black
        Me._lblDisp_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_2, CType(2, Short))
        Me._lblDisp_2.Location = New System.Drawing.Point(163, 108)
        Me._lblDisp_2.Name = "_lblDisp_2"
        Me._lblDisp_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_2.Size = New System.Drawing.Size(47, 16)
        Me._lblDisp_2.TabIndex = 70
        Me._lblDisp_2.Text = "LINE 2"
        '
        '_lblDisp_8
        '
        Me._lblDisp_8.AutoSize = True
        Me._lblDisp_8.BackColor = System.Drawing.Color.Black
        Me._lblDisp_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_8, CType(8, Short))
        Me._lblDisp_8.Location = New System.Drawing.Point(163, 43)
        Me._lblDisp_8.Name = "_lblDisp_8"
        Me._lblDisp_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_8.Size = New System.Drawing.Size(45, 16)
        Me._lblDisp_8.TabIndex = 67
        Me._lblDisp_8.Text = "LBL08"
        '
        '_lblDisp_5
        '
        Me._lblDisp_5.AutoSize = True
        Me._lblDisp_5.BackColor = System.Drawing.Color.Black
        Me._lblDisp_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_5, CType(5, Short))
        Me._lblDisp_5.Location = New System.Drawing.Point(163, 171)
        Me._lblDisp_5.Name = "_lblDisp_5"
        Me._lblDisp_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_5.Size = New System.Drawing.Size(47, 16)
        Me._lblDisp_5.TabIndex = 72
        Me._lblDisp_5.Text = "LINE 5"
        '
        'picLowBatt
        '
        Me.picLowBatt.BackColor = System.Drawing.Color.Black
        Me.picLowBatt.Cursor = System.Windows.Forms.Cursors.Default
        Me.picLowBatt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picLowBatt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picLowBatt.Image = CType(resources.GetObject("picLowBatt.Image"), System.Drawing.Image)
        Me.picLowBatt.Location = New System.Drawing.Point(307, 199)
        Me.picLowBatt.Name = "picLowBatt"
        Me.picLowBatt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picLowBatt.Size = New System.Drawing.Size(40, 37)
        Me.picLowBatt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLowBatt.TabIndex = 66
        Me.picLowBatt.TabStop = False
        Me.picLowBatt.Visible = False
        '
        'lblHold
        '
        Me.lblHold.AutoSize = True
        Me.lblHold.BackColor = System.Drawing.Color.Black
        Me.lblHold.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHold.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHold.Location = New System.Drawing.Point(166, 73)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHold.Size = New System.Drawing.Size(35, 14)
        Me.lblHold.TabIndex = 73
        Me.lblHold.Text = "HOLD"
        '
        'lblLO
        '
        Me.lblLO.AutoSize = True
        Me.lblLO.BackColor = System.Drawing.Color.Black
        Me.lblLO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLO.ForeColor = System.Drawing.Color.Red
        Me.lblLO.Location = New System.Drawing.Point(207, 73)
        Me.lblLO.Name = "lblLO"
        Me.lblLO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLO.Size = New System.Drawing.Size(24, 14)
        Me.lblLO.TabIndex = 74
        Me.lblLO.Text = "L/O"
        '
        'picLEDOff
        '
        Me.picLEDOff.BackColor = System.Drawing.Color.Black
        Me.picLEDOff.Cursor = System.Windows.Forms.Cursors.Default
        Me.picLEDOff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picLEDOff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picLEDOff.Image = CType(resources.GetObject("picLEDOff.Image"), System.Drawing.Image)
        Me.picLEDOff.Location = New System.Drawing.Point(295, 39)
        Me.picLEDOff.Name = "picLEDOff"
        Me.picLEDOff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picLEDOff.Size = New System.Drawing.Size(70, 16)
        Me.picLEDOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLEDOff.TabIndex = 65
        Me.picLEDOff.TabStop = False
        '
        '_lblCursor_0
        '
        Me._lblCursor_0.BackColor = System.Drawing.Color.Black
        Me._lblCursor_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCursor_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCursor_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCursor.SetIndex(Me._lblCursor_0, CType(0, Short))
        Me._lblCursor_0.Location = New System.Drawing.Point(229, 168)
        Me._lblCursor_0.Name = "_lblCursor_0"
        Me._lblCursor_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCursor_0.Size = New System.Drawing.Size(137, 22)
        Me._lblCursor_0.TabIndex = 75
        Me._lblCursor_0.Text = "_____________________"
        Me._lblCursor_0.Visible = False
        '
        '_lblCursor_1
        '
        Me._lblCursor_1.BackColor = System.Drawing.Color.Black
        Me._lblCursor_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCursor_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCursor_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCursor.SetIndex(Me._lblCursor_1, CType(1, Short))
        Me._lblCursor_1.Location = New System.Drawing.Point(245, 191)
        Me._lblCursor_1.Name = "_lblCursor_1"
        Me._lblCursor_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCursor_1.Size = New System.Drawing.Size(153, 17)
        Me._lblCursor_1.TabIndex = 76
        Me._lblCursor_1.Text = "___________"
        Me._lblCursor_1.Visible = False
        '
        'PicLEDON
        '
        Me.PicLEDON.BackColor = System.Drawing.Color.Black
        Me.PicLEDON.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicLEDON.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicLEDON.ForeColor = System.Drawing.Color.Black
        Me.PicLEDON.Image = CType(resources.GetObject("PicLEDON.Image"), System.Drawing.Image)
        Me.PicLEDON.Location = New System.Drawing.Point(295, 39)
        Me.PicLEDON.Name = "PicLEDON"
        Me.PicLEDON.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicLEDON.Size = New System.Drawing.Size(70, 16)
        Me.PicLEDON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicLEDON.TabIndex = 64
        Me.PicLEDON.TabStop = False
        '
        '_lblDisp_0
        '
        Me._lblDisp_0.BackColor = System.Drawing.Color.Black
        Me._lblDisp_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_0, CType(0, Short))
        Me._lblDisp_0.Location = New System.Drawing.Point(153, 59)
        Me._lblDisp_0.Name = "_lblDisp_0"
        Me._lblDisp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_0.Size = New System.Drawing.Size(204, 16)
        Me._lblDisp_0.TabIndex = 78
        Me._lblDisp_0.Text = "Label3"
        Me._lblDisp_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lblDisp_6
        '
        Me._lblDisp_6.AutoSize = True
        Me._lblDisp_6.BackColor = System.Drawing.Color.Black
        Me._lblDisp_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_6, CType(6, Short))
        Me._lblDisp_6.Location = New System.Drawing.Point(165, 218)
        Me._lblDisp_6.Name = "_lblDisp_6"
        Me._lblDisp_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_6.Size = New System.Drawing.Size(50, 16)
        Me._lblDisp_6.TabIndex = 79
        Me._lblDisp_6.Text = "LBLID6"
        '
        'picUpArrow
        '
        Me.picUpArrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picUpArrow.Cursor = System.Windows.Forms.Cursors.Default
        Me.picUpArrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picUpArrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picUpArrow.Image = CType(resources.GetObject("picUpArrow.Image"), System.Drawing.Image)
        Me.picUpArrow.Location = New System.Drawing.Point(143, 107)
        Me.picUpArrow.Name = "picUpArrow"
        Me.picUpArrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picUpArrow.Size = New System.Drawing.Size(15, 19)
        Me.picUpArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picUpArrow.TabIndex = 63
        Me.picUpArrow.TabStop = False
        Me.picUpArrow.Visible = False
        '
        '_lblDisp_7
        '
        Me._lblDisp_7.AutoSize = True
        Me._lblDisp_7.BackColor = System.Drawing.Color.Black
        Me._lblDisp_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_7, CType(7, Short))
        Me._lblDisp_7.Location = New System.Drawing.Point(271, 119)
        Me._lblDisp_7.Name = "_lblDisp_7"
        Me._lblDisp_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_7.Size = New System.Drawing.Size(79, 16)
        Me._lblDisp_7.TabIndex = 80
        Me._lblDisp_7.Text = "LBLMOD 07"
        '
        'cmdStopCom
        '
        Me.cmdStopCom.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStopCom.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStopCom.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStopCom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStopCom.Location = New System.Drawing.Point(68, 237)
        Me.cmdStopCom.Name = "cmdStopCom"
        Me.cmdStopCom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStopCom.Size = New System.Drawing.Size(61, 25)
        Me.cmdStopCom.TabIndex = 0
        Me.cmdStopCom.Text = "Link Off"
        Me.cmdStopCom.UseVisualStyleBackColor = True
        '
        'picDownArrow
        '
        Me.picDownArrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picDownArrow.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDownArrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picDownArrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picDownArrow.Image = CType(resources.GetObject("picDownArrow.Image"), System.Drawing.Image)
        Me.picDownArrow.Location = New System.Drawing.Point(143, 127)
        Me.picDownArrow.Name = "picDownArrow"
        Me.picDownArrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picDownArrow.Size = New System.Drawing.Size(15, 19)
        Me.picDownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDownArrow.TabIndex = 62
        Me.picDownArrow.TabStop = False
        Me.picDownArrow.Visible = False
        '
        'cmdLink
        '
        Me.cmdLink.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLink.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLink.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLink.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLink.Location = New System.Drawing.Point(8, 237)
        Me.cmdLink.Name = "cmdLink"
        Me.cmdLink.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLink.Size = New System.Drawing.Size(61, 25)
        Me.cmdLink.TabIndex = 1
        Me.cmdLink.Text = "Link On"
        Me.cmdLink.UseVisualStyleBackColor = True
        '
        'PicCC
        '
        Me.PicCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PicCC.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicCC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicCC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicCC.Image = CType(resources.GetObject("PicCC.Image"), System.Drawing.Image)
        Me.PicCC.Location = New System.Drawing.Point(325, 161)
        Me.PicCC.Name = "PicCC"
        Me.PicCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicCC.Size = New System.Drawing.Size(40, 37)
        Me.PicCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicCC.TabIndex = 61
        Me.PicCC.TabStop = False
        Me.PicCC.Visible = False
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.Black
        Me.Shape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Shape1.Location = New System.Drawing.Point(138, 33)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(236, 205)
        Me.Shape1.TabIndex = 86
        '
        'mnuJServ
        '
        '
        '_mnuJServ_1
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_1, CType(1, Short))
        Me._mnuJServ_1.Name = "_mnuJServ_1"
        Me._mnuJServ_1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me._mnuJServ_1.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_1.Text = "Public Safety"
        '
        '_mnuJServ_2
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_2, CType(2, Short))
        Me._mnuJServ_2.Name = "_mnuJServ_2"
        Me._mnuJServ_2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me._mnuJServ_2.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_2.Text = "News"
        '
        '_mnuJServ_3
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_3, CType(3, Short))
        Me._mnuJServ_3.Name = "_mnuJServ_3"
        Me._mnuJServ_3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me._mnuJServ_3.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_3.Text = "Amateur Radio"
        '
        '_mnuJServ_4
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_4, CType(4, Short))
        Me._mnuJServ_4.Name = "_mnuJServ_4"
        Me._mnuJServ_4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me._mnuJServ_4.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_4.Text = "Marine"
        '
        '_mnuJServ_5
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_5, CType(5, Short))
        Me._mnuJServ_5.Name = "_mnuJServ_5"
        Me._mnuJServ_5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me._mnuJServ_5.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_5.Text = "Rail Road"
        '
        '_mnuJServ_6
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_6, CType(6, Short))
        Me._mnuJServ_6.Name = "_mnuJServ_6"
        Me._mnuJServ_6.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me._mnuJServ_6.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_6.Text = "Aircraft"
        '
        '_mnuJServ_7
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_7, CType(7, Short))
        Me._mnuJServ_7.Name = "_mnuJServ_7"
        Me._mnuJServ_7.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me._mnuJServ_7.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_7.Text = "CB Radio"
        '
        '_mnuJServ_8
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_8, CType(8, Short))
        Me._mnuJServ_8.Name = "_mnuJServ_8"
        Me._mnuJServ_8.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me._mnuJServ_8.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_8.Text = "FRS/GMRS"
        '
        '_mnuJServ_9
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_9, CType(9, Short))
        Me._mnuJServ_9.Name = "_mnuJServ_9"
        Me._mnuJServ_9.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me._mnuJServ_9.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_9.Text = "Racing"
        '
        '_mnuJServ_10
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_10, CType(10, Short))
        Me._mnuJServ_10.Name = "_mnuJServ_10"
        Me._mnuJServ_10.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me._mnuJServ_10.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_10.Text = "TV"
        '
        '_mnuJServ_11
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_11, CType(11, Short))
        Me._mnuJServ_11.Name = "_mnuJServ_11"
        Me._mnuJServ_11.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me._mnuJServ_11.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_11.Text = "Broadcast FM"
        '
        '_mnuJServ_12
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_12, CType(12, Short))
        Me._mnuJServ_12.Name = "_mnuJServ_12"
        Me._mnuJServ_12.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me._mnuJServ_12.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_12.Text = "Special"
        '
        '_mnuJServ_13
        '
        Me.mnuJServ.SetIndex(Me._mnuJServ_13, CType(13, Short))
        Me._mnuJServ_13.Name = "_mnuJServ_13"
        Me._mnuJServ_13.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me._mnuJServ_13.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_13.Text = "Military"
        '
        '_mnuJServMain_0
        '
        Me._mnuJServMain_0.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnuJServ_1, Me._mnuJServ_2, Me._mnuJServ_3, Me._mnuJServ_4, Me._mnuJServ_5, Me._mnuJServ_6, Me._mnuJServ_7, Me._mnuJServ_8, Me._mnuJServ_9, Me._mnuJServ_10, Me._mnuJServ_11, Me._mnuJServ_12, Me._mnuJServ_13})
        Me.mnuJServMain.SetIndex(Me._mnuJServMain_0, CType(0, Short))
        Me._mnuJServMain_0.Name = "_mnuJServMain_0"
        Me._mnuJServMain_0.Size = New System.Drawing.Size(173, 22)
        Me._mnuJServMain_0.Text = "&Service Scan"
        '
        'mnuWX
        '
        '
        '_mnuWX_0
        '
        Me.mnuWX.SetIndex(Me._mnuWX_0, CType(0, Short))
        Me._mnuWX_0.Name = "_mnuWX_0"
        Me._mnuWX_0.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me._mnuWX_0.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_0.Text = "Normal Search"
        '
        '_mnuWX_1
        '
        Me.mnuWX.SetIndex(Me._mnuWX_1, CType(1, Short))
        Me._mnuWX_1.Name = "_mnuWX_1"
        Me._mnuWX_1.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_1.Text = "Alert Only"
        '
        '_mnuWX_2
        '
        Me.mnuWX.SetIndex(Me._mnuWX_2, CType(2, Short))
        Me._mnuWX_2.Name = "_mnuWX_2"
        Me._mnuWX_2.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_2.Text = "SAME 1"
        '
        '_mnuWX_3
        '
        Me.mnuWX.SetIndex(Me._mnuWX_3, CType(3, Short))
        Me._mnuWX_3.Name = "_mnuWX_3"
        Me._mnuWX_3.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_3.Text = "SAME 2"
        '
        '_mnuWX_4
        '
        Me.mnuWX.SetIndex(Me._mnuWX_4, CType(4, Short))
        Me._mnuWX_4.Name = "_mnuWX_4"
        Me._mnuWX_4.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_4.Text = "SAME 3"
        '
        '_mnuWX_5
        '
        Me.mnuWX.SetIndex(Me._mnuWX_5, CType(5, Short))
        Me._mnuWX_5.Name = "_mnuWX_5"
        Me._mnuWX_5.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_5.Text = "SAME 4"
        '
        '_mnuWX_6
        '
        Me.mnuWX.SetIndex(Me._mnuWX_6, CType(6, Short))
        Me._mnuWX_6.Name = "_mnuWX_6"
        Me._mnuWX_6.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_6.Text = "SAME 5"
        '
        '_mnuWX_7
        '
        Me.mnuWX.SetIndex(Me._mnuWX_7, CType(7, Short))
        Me._mnuWX_7.Name = "_mnuWX_7"
        Me._mnuWX_7.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_7.Text = "FIPS Search"
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit, Me.mnuJump, Me.RemoteControlToolStripMenuItem})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(684, 24)
        Me.MainMenu1.TabIndex = 88
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JumpToFrequencyToolStripMenuItem, Me.SetupAudioRecordingToolStripMenuItem, Me.mnuEnableLog, Me.mnuEditViewLog, Me.mnuEditF, Me.mnuToolsNegDelay, Me.ShowHideMainWindowToolStripMenuItem, Me.mnuEditExit})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(61, 20)
        Me.mnuEdit.Text = "&Options"
        '
        'JumpToFrequencyToolStripMenuItem
        '
        Me.JumpToFrequencyToolStripMenuItem.Name = "JumpToFrequencyToolStripMenuItem"
        Me.JumpToFrequencyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.JumpToFrequencyToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.JumpToFrequencyToolStripMenuItem.Text = "Jump To Frequency..."
        '
        'SetupAudioRecordingToolStripMenuItem
        '
        Me.SetupAudioRecordingToolStripMenuItem.Name = "SetupAudioRecordingToolStripMenuItem"
        Me.SetupAudioRecordingToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SetupAudioRecordingToolStripMenuItem.Text = "Setup Audio Recording..."
        '
        'mnuEnableLog
        '
        Me.mnuEnableLog.Name = "mnuEnableLog"
        Me.mnuEnableLog.Size = New System.Drawing.Size(225, 22)
        Me.mnuEnableLog.Text = "E&nable Logging"
        '
        'mnuEditViewLog
        '
        Me.mnuEditViewLog.Name = "mnuEditViewLog"
        Me.mnuEditViewLog.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditViewLog.Text = "O&pen Log Window..."
        '
        'mnuEditF
        '
        Me.mnuEditF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditFont, Me.mnuEditFontColor})
        Me.mnuEditF.Name = "mnuEditF"
        Me.mnuEditF.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditF.Text = "&Font"
        '
        'mnuEditFont
        '
        Me.mnuEditFont.Name = "mnuEditFont"
        Me.mnuEditFont.Size = New System.Drawing.Size(150, 22)
        Me.mnuEditFont.Text = "&Choose Font..."
        '
        'mnuEditFontColor
        '
        Me.mnuEditFontColor.Name = "mnuEditFontColor"
        Me.mnuEditFontColor.Size = New System.Drawing.Size(150, 22)
        Me.mnuEditFontColor.Text = "Font &Colour..."
        '
        'mnuToolsNegDelay
        '
        Me.mnuToolsNegDelay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsNegDlyEnable, Me.mnuToolsNegDlyTime})
        Me.mnuToolsNegDelay.Name = "mnuToolsNegDelay"
        Me.mnuToolsNegDelay.Size = New System.Drawing.Size(225, 22)
        Me.mnuToolsNegDelay.Text = "Negati&ve Delay"
        '
        'mnuToolsNegDlyEnable
        '
        Me.mnuToolsNegDlyEnable.Name = "mnuToolsNegDlyEnable"
        Me.mnuToolsNegDlyEnable.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mnuToolsNegDlyEnable.Size = New System.Drawing.Size(193, 22)
        Me.mnuToolsNegDlyEnable.Text = "E&nabled"
        '
        'mnuToolsNegDlyTime
        '
        Me.mnuToolsNegDlyTime.Name = "mnuToolsNegDlyTime"
        Me.mnuToolsNegDlyTime.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.mnuToolsNegDlyTime.Size = New System.Drawing.Size(193, 22)
        Me.mnuToolsNegDlyTime.Text = "Set Timeout..."
        '
        'ShowHideMainWindowToolStripMenuItem
        '
        Me.ShowHideMainWindowToolStripMenuItem.Name = "ShowHideMainWindowToolStripMenuItem"
        Me.ShowHideMainWindowToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ShowHideMainWindowToolStripMenuItem.Text = "Show/Hide Main Window"
        '
        'mnuEditExit
        '
        Me.mnuEditExit.Name = "mnuEditExit"
        Me.mnuEditExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditExit.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditExit.Text = "E&xit"
        '
        'mnuJump
        '
        Me.mnuJump.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuJScan, Me._mnuJServMain_0, Me.mnuJCust, Me.mnuJCC, Me.mnuJWX, Me.mnuJFTO})
        Me.mnuJump.Name = "mnuJump"
        Me.mnuJump.Size = New System.Drawing.Size(48, 20)
        Me.mnuJump.Text = "&Jump"
        '
        'mnuJScan
        '
        Me.mnuJScan.Name = "mnuJScan"
        Me.mnuJScan.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuJScan.Size = New System.Drawing.Size(173, 22)
        Me.mnuJScan.Text = "Scan Mode"
        '
        'mnuJCust
        '
        Me.mnuJCust.Name = "mnuJCust"
        Me.mnuJCust.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuJCust.Size = New System.Drawing.Size(173, 22)
        Me.mnuJCust.Text = "Custom Search"
        '
        'mnuJCC
        '
        Me.mnuJCC.Name = "mnuJCC"
        Me.mnuJCC.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuJCC.Size = New System.Drawing.Size(173, 22)
        Me.mnuJCC.Text = "Close Call Only"
        '
        'mnuJWX
        '
        Me.mnuJWX.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnuWX_0, Me._mnuWX_1, Me._mnuWX_2, Me._mnuWX_3, Me._mnuWX_4, Me._mnuWX_5, Me._mnuWX_6, Me._mnuWX_7})
        Me.mnuJWX.Name = "mnuJWX"
        Me.mnuJWX.Size = New System.Drawing.Size(173, 22)
        Me.mnuJWX.Text = "Weather"
        '
        'mnuJFTO
        '
        Me.mnuJFTO.Name = "mnuJFTO"
        Me.mnuJFTO.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuJFTO.Size = New System.Drawing.Size(173, 22)
        Me.mnuJFTO.Text = "Fire Tone Out"
        '
        'RemoteControlToolStripMenuItem
        '
        Me.RemoteControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem})
        Me.RemoteControlToolStripMenuItem.Name = "RemoteControlToolStripMenuItem"
        Me.RemoteControlToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.RemoteControlToolStripMenuItem.Text = "&Remote Control"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SetupToolStripMenuItem.Text = "Setup..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BVOL
        '
        Me.BVOL.BackColor = System.Drawing.Color.Silver
        Me.BVOL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BVOL.ForeColor = System.Drawing.Color.Black
        Me.BVOL.Location = New System.Drawing.Point(54, 99)
        Me.BVOL.Name = "BVOL"
        Me.BVOL.Size = New System.Drawing.Size(35, 21)
        Me.BVOL.TabIndex = 112
        Me.BVOL.Text = "&Vol"
        Me.BVOL.UseVisualStyleBackColor = True
        '
        'BSQL
        '
        Me.BSQL.BackColor = System.Drawing.Color.Silver
        Me.BSQL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BSQL.ForeColor = System.Drawing.Color.Black
        Me.BSQL.Location = New System.Drawing.Point(54, 27)
        Me.BSQL.Name = "BSQL"
        Me.BSQL.Size = New System.Drawing.Size(35, 21)
        Me.BSQL.TabIndex = 113
        Me.BSQL.Text = "S&ql"
        Me.BSQL.UseVisualStyleBackColor = True
        '
        'BLEFT
        '
        Me.BLEFT.BackColor = System.Drawing.Color.Silver
        Me.BLEFT.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BLEFT.ForeColor = System.Drawing.Color.Black
        Me.BLEFT.Location = New System.Drawing.Point(573, 100)
        Me.BLEFT.Name = "BLEFT"
        Me.BLEFT.Size = New System.Drawing.Size(35, 21)
        Me.BLEFT.TabIndex = 114
        Me.BLEFT.Text = "&<<"
        Me.BLEFT.UseVisualStyleBackColor = True
        '
        'BFUNC
        '
        Me.BFUNC.BackColor = System.Drawing.Color.Silver
        Me.BFUNC.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BFUNC.ForeColor = System.Drawing.Color.Black
        Me.BFUNC.Location = New System.Drawing.Point(598, 125)
        Me.BFUNC.Name = "BFUNC"
        Me.BFUNC.Size = New System.Drawing.Size(43, 21)
        Me.BFUNC.TabIndex = 115
        Me.BFUNC.Text = "&Func"
        Me.BFUNC.UseVisualStyleBackColor = True
        '
        'BRIGHT
        '
        Me.BRIGHT.BackColor = System.Drawing.Color.Silver
        Me.BRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BRIGHT.ForeColor = System.Drawing.Color.Black
        Me.BRIGHT.Location = New System.Drawing.Point(632, 100)
        Me.BRIGHT.Name = "BRIGHT"
        Me.BRIGHT.Size = New System.Drawing.Size(35, 21)
        Me.BRIGHT.TabIndex = 116
        Me.BRIGHT.Text = ">&>"
        Me.BRIGHT.UseVisualStyleBackColor = True
        '
        'BSCAN
        '
        Me.BSCAN.BackColor = System.Drawing.Color.Silver
        Me.BSCAN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BSCAN.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSCAN.ForeColor = System.Drawing.Color.Black
        Me.BSCAN.Location = New System.Drawing.Point(573, 43)
        Me.BSCAN.Name = "BSCAN"
        Me.BSCAN.Size = New System.Drawing.Size(94, 21)
        Me.BSCAN.TabIndex = 117
        Me.BSCAN.Text = "&Scan/Srch"
        Me.BSCAN.UseVisualStyleBackColor = True
        '
        'BHOLD
        '
        Me.BHOLD.BackColor = System.Drawing.Color.Silver
        Me.BHOLD.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BHOLD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHOLD.ForeColor = System.Drawing.Color.Black
        Me.BHOLD.Location = New System.Drawing.Point(573, 70)
        Me.BHOLD.Name = "BHOLD"
        Me.BHOLD.Size = New System.Drawing.Size(94, 21)
        Me.BHOLD.TabIndex = 118
        Me.BHOLD.Text = "&Hold/Resume"
        Me.BHOLD.UseVisualStyleBackColor = True
        '
        'BPWR
        '
        Me.BPWR.BackColor = System.Drawing.Color.Silver
        Me.BPWR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BPWR.ForeColor = System.Drawing.Color.Black
        Me.BPWR.Location = New System.Drawing.Point(441, 150)
        Me.BPWR.Name = "BPWR"
        Me.BPWR.Size = New System.Drawing.Size(35, 21)
        Me.BPWR.TabIndex = 119
        Me.BPWR.Text = "P&wr"
        Me.BPWR.UseVisualStyleBackColor = True
        '
        'PicRecord
        '
        Me.PicRecord.BackColor = System.Drawing.Color.Black
        Me.PicRecord.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicRecord.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicRecord.ForeColor = System.Drawing.Color.Black
        Me.PicRecord.Image = CType(resources.GetObject("PicRecord.Image"), System.Drawing.Image)
        Me.PicRecord.Location = New System.Drawing.Point(245, 39)
        Me.PicRecord.Name = "PicRecord"
        Me.PicRecord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicRecord.Size = New System.Drawing.Size(44, 16)
        Me.PicRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicRecord.TabIndex = 120
        Me.PicRecord.TabStop = False
        Me.PicRecord.Visible = False
        '
        'PicRecordOff
        '
        Me.PicRecordOff.BackColor = System.Drawing.Color.Black
        Me.PicRecordOff.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicRecordOff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicRecordOff.ForeColor = System.Drawing.Color.Black
        Me.PicRecordOff.Image = CType(resources.GetObject("PicRecordOff.Image"), System.Drawing.Image)
        Me.PicRecordOff.Location = New System.Drawing.Point(245, 39)
        Me.PicRecordOff.Name = "PicRecordOff"
        Me.PicRecordOff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicRecordOff.Size = New System.Drawing.Size(44, 16)
        Me.PicRecordOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicRecordOff.TabIndex = 121
        Me.PicRecordOff.TabStop = False
        Me.PicRecordOff.Visible = False
        '
        'lblNegDelay
        '
        Me.lblNegDelay.AutoSize = True
        Me.lblNegDelay.BackColor = System.Drawing.Color.Black
        Me.lblNegDelay.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNegDelay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNegDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNegDelay.Location = New System.Drawing.Point(342, 218)
        Me.lblNegDelay.Name = "lblNegDelay"
        Me.lblNegDelay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNegDelay.Size = New System.Drawing.Size(29, 16)
        Me.lblNegDelay.TabIndex = 122
        Me.lblNegDelay.Text = "120"
        Me.lblNegDelay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmCtlWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(684, 270)
        Me.Controls.Add(Me.lblNegDelay)
        Me.Controls.Add(Me.PicRecordOff)
        Me.Controls.Add(Me.PicRecord)
        Me.Controls.Add(Me.BPWR)
        Me.Controls.Add(Me.BHOLD)
        Me.Controls.Add(Me.BSCAN)
        Me.Controls.Add(Me.BRIGHT)
        Me.Controls.Add(Me.BFUNC)
        Me.Controls.Add(Me.BLEFT)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.lblBat)
        Me.Controls.Add(Me.BVOL)
        Me.Controls.Add(_Label1_2)
        Me.Controls.Add(_Label1_1)
        Me.Controls.Add(Me.PicCC)
        Me.Controls.Add(Me.prgSignal)
        Me.Controls.Add(Me.cmdLink)
        Me.Controls.Add(Me.prgBat)
        Me.Controls.Add(Me.picDownArrow)
        Me.Controls.Add(Me.BSQL)
        Me.Controls.Add(Me.cmdStopCom)
        Me.Controls.Add(Me._lblDisp_7)
        Me.Controls.Add(Me.prgP25)
        Me.Controls.Add(Me.picUpArrow)
        Me.Controls.Add(_Label1_0)
        Me.Controls.Add(Me._lblDisp_6)
        Me.Controls.Add(Me.BLO)
        Me.Controls.Add(Me._lblDisp_0)
        Me.Controls.Add(Me.BMENU)
        Me.Controls.Add(Me.PicLEDON)
        Me.Controls.Add(Me.BGPS)
        Me.Controls.Add(Me._lblCursor_1)
        Me.Controls.Add(Me.BWX)
        Me.Controls.Add(Me._lblCursor_0)
        Me.Controls.Add(Me.BPRI)
        Me.Controls.Add(Me.picLEDOff)
        Me.Controls.Add(Me.BYES)
        Me.Controls.Add(Me.lblLO)
        Me.Controls.Add(Me.B0)
        Me.Controls.Add(Me.lblHold)
        Me.Controls.Add(Me.BNO)
        Me.Controls.Add(Me.picLowBatt)
        Me.Controls.Add(Me.B9)
        Me.Controls.Add(Me._lblDisp_5)
        Me.Controls.Add(Me.B8)
        Me.Controls.Add(Me._lblDisp_8)
        Me.Controls.Add(Me.B7)
        Me.Controls.Add(Me._lblDisp_2)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me._lblDisp_1)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me._lblCursor_2)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me._lblDisp_3)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.sldOpacity)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me._lblDisp_4)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.sldVol)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.sldSql)
        Me.Controls.Add(Me.chkTopMost)
        Me.Controls.Add(Me.Shape1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(11, 57)
        Me.MainMenuStrip = Me.MainMenu1
        Me.MaximizeBox = False
        Me.Name = "frmCtlWin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Virtual Scanner"
        CType(Me.sldSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldVol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLowBatt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLEDOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLEDON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDownArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicKeyUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgKeyOld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDisp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuJServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuJServMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuWX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        CType(Me.PicRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRecordOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sldSql As System.Windows.Forms.TrackBar
    Friend WithEvents sldVol As System.Windows.Forms.TrackBar
    Friend WithEvents sldOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents chkTopMost As System.Windows.Forms.CheckBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents BLO As System.Windows.Forms.Button
    Friend WithEvents BMENU As System.Windows.Forms.Button
    Friend WithEvents BGPS As System.Windows.Forms.Button
    Friend WithEvents BWX As System.Windows.Forms.Button
    Friend WithEvents BPRI As System.Windows.Forms.Button
    Friend WithEvents BYES As System.Windows.Forms.Button
    Friend WithEvents B0 As System.Windows.Forms.Button
    Friend WithEvents BNO As System.Windows.Forms.Button
    Friend WithEvents B9 As System.Windows.Forms.Button
    Friend WithEvents B8 As System.Windows.Forms.Button
    Friend WithEvents B7 As System.Windows.Forms.Button
    Friend WithEvents B6 As System.Windows.Forms.Button
    Friend WithEvents B5 As System.Windows.Forms.Button
    Friend WithEvents B4 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents BVOL As System.Windows.Forms.Button
    Friend WithEvents BSQL As System.Windows.Forms.Button
    Friend WithEvents BLEFT As System.Windows.Forms.Button
    Friend WithEvents BFUNC As System.Windows.Forms.Button
    Friend WithEvents BRIGHT As System.Windows.Forms.Button
    Friend WithEvents BSCAN As System.Windows.Forms.Button
    Friend WithEvents BHOLD As System.Windows.Forms.Button
    Friend WithEvents BPWR As System.Windows.Forms.Button
    Friend WithEvents ShowHideMainWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JumpToFrequencyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupAudioRecordingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents PicRecord As System.Windows.Forms.PictureBox
    Public WithEvents PicRecordOff As System.Windows.Forms.PictureBox
    Public WithEvents lblNegDelay As System.Windows.Forms.Label
    Friend WithEvents RemoteControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
#End Region
End Class