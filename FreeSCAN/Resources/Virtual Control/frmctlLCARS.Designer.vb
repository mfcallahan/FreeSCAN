<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCtlLCARS
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
	Public WithEvents picCloseCallACt As System.Windows.Forms.PictureBox
	Public WithEvents Graphic As System.Windows.Forms.Timer
	Public WithEvents picAlertLED As System.Windows.Forms.PictureBox
	Public WithEvents picUpArrow As System.Windows.Forms.PictureBox
	Public WithEvents picDownArrow As System.Windows.Forms.PictureBox
	Public WithEvents picWX As System.Windows.Forms.PictureBox
	Public WithEvents picENC As System.Windows.Forms.PictureBox
	Public WithEvents PicOnline2 As System.Windows.Forms.PictureBox
	Public WithEvents PicLO As System.Windows.Forms.PictureBox
	Public WithEvents picHOld As System.Windows.Forms.PictureBox
	Public WithEvents PicOnline1 As System.Windows.Forms.PictureBox
	Public WithEvents picLowBatt As System.Windows.Forms.PictureBox
	Public WithEvents PicCC As System.Windows.Forms.PictureBox
	Public CommonDialogFont As System.Windows.Forms.FontDialog
	Public CommonDialogColor As System.Windows.Forms.ColorDialog
	Public WithEvents _lblDisp_9 As System.Windows.Forms.Label
	Public WithEvents imgClearALl As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_46 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_45 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_44 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_43 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_42 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_41 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_40 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_39 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_38 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_37 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_36 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_27 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_26 As System.Windows.Forms.PictureBox
	Public WithEvents _shpSig_0 As System.Windows.Forms.Label
	Public WithEvents _imgKey_25 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_24 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_23 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_22 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_21 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_32 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_35 As System.Windows.Forms.PictureBox
	Public WithEvents _lblCursor_1 As System.Windows.Forms.Label
	Public WithEvents _lblCursor_2 As System.Windows.Forms.Label
	Public WithEvents _lblCursor_0 As System.Windows.Forms.Label
	Public WithEvents _shpIndicate_4 As System.Windows.Forms.Label
	Public WithEvents _shpIndicate_3 As System.Windows.Forms.Label
	Public WithEvents _shpIndicate_2 As System.Windows.Forms.Label
	Public WithEvents _shpIndicate_1 As System.Windows.Forms.Label
	Public WithEvents _shpIndicate_0 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_7 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_6 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_0 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_5 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_4 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_2 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_1 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_3 As System.Windows.Forms.Label
	Public WithEvents _lblDisp_8 As System.Windows.Forms.Label
	Public WithEvents lblBat As System.Windows.Forms.Label
	Public WithEvents _imgKey_34 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_33 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_31 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_30 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_29 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_16 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_18 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_17 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_15 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_9 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_6 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_3 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_0 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_8 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_5 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_2 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_14 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_7 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_4 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_1 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_13 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_12 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_11 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_10 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_20 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_28 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_19 As System.Windows.Forms.PictureBox
    Public WithEvents imgKey As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents lblCursor As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblDisp As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents shpIndicate As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents shpSig As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents mnuEnableLog As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditViewLog As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditFont As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditFontColor As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditF As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditJump As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuToolsNegDlyEnable As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuToolsNegDlyTime As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuToolsNegDelay As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEditExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtlLCARS))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._imgKey_25 = New System.Windows.Forms.PictureBox
        Me._imgKey_24 = New System.Windows.Forms.PictureBox
        Me._imgKey_23 = New System.Windows.Forms.PictureBox
        Me._imgKey_22 = New System.Windows.Forms.PictureBox
        Me._imgKey_21 = New System.Windows.Forms.PictureBox
        Me._imgKey_32 = New System.Windows.Forms.PictureBox
        Me._imgKey_35 = New System.Windows.Forms.PictureBox
        Me._imgKey_34 = New System.Windows.Forms.PictureBox
        Me._imgKey_33 = New System.Windows.Forms.PictureBox
        Me._imgKey_31 = New System.Windows.Forms.PictureBox
        Me._imgKey_30 = New System.Windows.Forms.PictureBox
        Me._imgKey_29 = New System.Windows.Forms.PictureBox
        Me._imgKey_16 = New System.Windows.Forms.PictureBox
        Me._imgKey_18 = New System.Windows.Forms.PictureBox
        Me._imgKey_17 = New System.Windows.Forms.PictureBox
        Me._imgKey_15 = New System.Windows.Forms.PictureBox
        Me._imgKey_9 = New System.Windows.Forms.PictureBox
        Me._imgKey_6 = New System.Windows.Forms.PictureBox
        Me._imgKey_3 = New System.Windows.Forms.PictureBox
        Me._imgKey_0 = New System.Windows.Forms.PictureBox
        Me._imgKey_8 = New System.Windows.Forms.PictureBox
        Me._imgKey_5 = New System.Windows.Forms.PictureBox
        Me._imgKey_2 = New System.Windows.Forms.PictureBox
        Me._imgKey_14 = New System.Windows.Forms.PictureBox
        Me._imgKey_7 = New System.Windows.Forms.PictureBox
        Me._imgKey_4 = New System.Windows.Forms.PictureBox
        Me._imgKey_1 = New System.Windows.Forms.PictureBox
        Me._imgKey_13 = New System.Windows.Forms.PictureBox
        Me._imgKey_12 = New System.Windows.Forms.PictureBox
        Me._imgKey_11 = New System.Windows.Forms.PictureBox
        Me._imgKey_10 = New System.Windows.Forms.PictureBox
        Me._imgKey_20 = New System.Windows.Forms.PictureBox
        Me._imgKey_28 = New System.Windows.Forms.PictureBox
        Me._imgKey_19 = New System.Windows.Forms.PictureBox
        Me.picCloseCallACt = New System.Windows.Forms.PictureBox
        Me.Graphic = New System.Windows.Forms.Timer(Me.components)
        Me.picAlertLED = New System.Windows.Forms.PictureBox
        Me.picUpArrow = New System.Windows.Forms.PictureBox
        Me.picDownArrow = New System.Windows.Forms.PictureBox
        Me.picWX = New System.Windows.Forms.PictureBox
        Me.picENC = New System.Windows.Forms.PictureBox
        Me.PicOnline2 = New System.Windows.Forms.PictureBox
        Me.PicLO = New System.Windows.Forms.PictureBox
        Me.picHOld = New System.Windows.Forms.PictureBox
        Me.PicOnline1 = New System.Windows.Forms.PictureBox
        Me.picLowBatt = New System.Windows.Forms.PictureBox
        Me.PicCC = New System.Windows.Forms.PictureBox
        Me.CommonDialogFont = New System.Windows.Forms.FontDialog
        Me.CommonDialogColor = New System.Windows.Forms.ColorDialog
        Me._lblDisp_9 = New System.Windows.Forms.Label
        Me.imgClearALl = New System.Windows.Forms.PictureBox
        Me._imgKey_46 = New System.Windows.Forms.PictureBox
        Me._imgKey_45 = New System.Windows.Forms.PictureBox
        Me._imgKey_44 = New System.Windows.Forms.PictureBox
        Me._imgKey_43 = New System.Windows.Forms.PictureBox
        Me._imgKey_42 = New System.Windows.Forms.PictureBox
        Me._imgKey_41 = New System.Windows.Forms.PictureBox
        Me._imgKey_40 = New System.Windows.Forms.PictureBox
        Me._imgKey_39 = New System.Windows.Forms.PictureBox
        Me._imgKey_38 = New System.Windows.Forms.PictureBox
        Me._imgKey_37 = New System.Windows.Forms.PictureBox
        Me._imgKey_36 = New System.Windows.Forms.PictureBox
        Me._imgKey_27 = New System.Windows.Forms.PictureBox
        Me._imgKey_26 = New System.Windows.Forms.PictureBox
        Me._shpSig_0 = New System.Windows.Forms.Label
        Me._lblCursor_1 = New System.Windows.Forms.Label
        Me._lblCursor_2 = New System.Windows.Forms.Label
        Me._lblCursor_0 = New System.Windows.Forms.Label
        Me._shpIndicate_4 = New System.Windows.Forms.Label
        Me._shpIndicate_3 = New System.Windows.Forms.Label
        Me._shpIndicate_2 = New System.Windows.Forms.Label
        Me._shpIndicate_1 = New System.Windows.Forms.Label
        Me._shpIndicate_0 = New System.Windows.Forms.Label
        Me._lblDisp_7 = New System.Windows.Forms.Label
        Me._lblDisp_6 = New System.Windows.Forms.Label
        Me._lblDisp_0 = New System.Windows.Forms.Label
        Me._lblDisp_5 = New System.Windows.Forms.Label
        Me._lblDisp_4 = New System.Windows.Forms.Label
        Me._lblDisp_2 = New System.Windows.Forms.Label
        Me._lblDisp_1 = New System.Windows.Forms.Label
        Me._lblDisp_3 = New System.Windows.Forms.Label
        Me._lblDisp_8 = New System.Windows.Forms.Label
        Me.lblBat = New System.Windows.Forms.Label
        Me.imgKey = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.lblCursor = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblDisp = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.shpIndicate = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.shpSig = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEnableLog = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditViewLog = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditF = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditFont = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditFontColor = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditJump = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuToolsNegDelay = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuToolsNegDlyEnable = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuToolsNegDlyTime = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowHideMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuJump = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuJScan = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServMain_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_2 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_3 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_4 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_5 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_6 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_7 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_8 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_9 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_10 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_11 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_12 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuJServ_13 = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuJCust = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuJCC = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuJWX = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuWX_0 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuWX_1 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuWX_2 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuWX_3 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuWX_4 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuWX_5 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuWX_6 = New System.Windows.Forms.ToolStripMenuItem
        Me._mnuWX_7 = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuJFTO = New System.Windows.Forms.ToolStripMenuItem
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.sldOpacity = New System.Windows.Forms.TrackBar
        Me.chkTopMost = New System.Windows.Forms.CheckBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.SetupAudioRecordingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Label1 = New System.Windows.Forms.Label
        CType(Me._imgKey_25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCloseCallACt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAlertLED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDownArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picENC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOnline2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHOld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOnline1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLowBatt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClearALl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgKey_26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDisp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shpIndicate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shpSig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu1.SuspendLayout()
        CType(Me.sldOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Cursor = System.Windows.Forms.Cursors.Default
        Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Label1.Location = New System.Drawing.Point(589, 61)
        Label1.Name = "Label1"
        Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label1.Size = New System.Drawing.Size(50, 15)
        Label1.TabIndex = 85
        Label1.Text = "Opacity"
        '
        '_imgKey_25
        '
        Me._imgKey_25.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_25.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_25, CType(25, Short))
        Me._imgKey_25.Location = New System.Drawing.Point(662, 233)
        Me._imgKey_25.Name = "_imgKey_25"
        Me._imgKey_25.Size = New System.Drawing.Size(22, 39)
        Me._imgKey_25.TabIndex = 41
        Me._imgKey_25.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_25, "Attempt link with scanner")
        '
        '_imgKey_24
        '
        Me._imgKey_24.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_24.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_24, CType(24, Short))
        Me._imgKey_24.Location = New System.Drawing.Point(508, 385)
        Me._imgKey_24.Name = "_imgKey_24"
        Me._imgKey_24.Size = New System.Drawing.Size(15, 21)
        Me._imgKey_24.TabIndex = 42
        Me._imgKey_24.TabStop = False
        Me._imgKey_24.Tag = "+Sql"
        Me.ToolTip1.SetToolTip(Me._imgKey_24, "Increase squelch")
        '
        '_imgKey_23
        '
        Me._imgKey_23.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_23.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_23, CType(23, Short))
        Me._imgKey_23.Location = New System.Drawing.Point(393, 385)
        Me._imgKey_23.Name = "_imgKey_23"
        Me._imgKey_23.Size = New System.Drawing.Size(15, 21)
        Me._imgKey_23.TabIndex = 43
        Me._imgKey_23.TabStop = False
        Me._imgKey_23.Tag = "-Sql"
        Me.ToolTip1.SetToolTip(Me._imgKey_23, "Decrease Squelch")
        '
        '_imgKey_22
        '
        Me._imgKey_22.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_22.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_22, CType(22, Short))
        Me._imgKey_22.Location = New System.Drawing.Point(392, 341)
        Me._imgKey_22.Name = "_imgKey_22"
        Me._imgKey_22.Size = New System.Drawing.Size(15, 21)
        Me._imgKey_22.TabIndex = 44
        Me._imgKey_22.TabStop = False
        Me._imgKey_22.Tag = "-Vol"
        Me.ToolTip1.SetToolTip(Me._imgKey_22, "Decrease volume")
        '
        '_imgKey_21
        '
        Me._imgKey_21.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_21.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_21, CType(21, Short))
        Me._imgKey_21.Location = New System.Drawing.Point(508, 342)
        Me._imgKey_21.Name = "_imgKey_21"
        Me._imgKey_21.Size = New System.Drawing.Size(15, 21)
        Me._imgKey_21.TabIndex = 45
        Me._imgKey_21.TabStop = False
        Me._imgKey_21.Tag = "+Vol"
        Me.ToolTip1.SetToolTip(Me._imgKey_21, "Increase volume")
        '
        '_imgKey_32
        '
        Me._imgKey_32.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_32.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_32, CType(32, Short))
        Me._imgKey_32.Location = New System.Drawing.Point(686, 238)
        Me._imgKey_32.Name = "_imgKey_32"
        Me._imgKey_32.Size = New System.Drawing.Size(44, 42)
        Me._imgKey_32.TabIndex = 46
        Me._imgKey_32.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_32, "Hold")
        '
        '_imgKey_35
        '
        Me._imgKey_35.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_35.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_35, CType(35, Short))
        Me._imgKey_35.Location = New System.Drawing.Point(542, 353)
        Me._imgKey_35.Name = "_imgKey_35"
        Me._imgKey_35.Size = New System.Drawing.Size(80, 53)
        Me._imgKey_35.TabIndex = 47
        Me._imgKey_35.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_35, "Power Off (Hand Held Only)")
        '
        '_imgKey_34
        '
        Me._imgKey_34.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_34.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_34, CType(34, Short))
        Me._imgKey_34.Location = New System.Drawing.Point(686, 308)
        Me._imgKey_34.Name = "_imgKey_34"
        Me._imgKey_34.Size = New System.Drawing.Size(46, 41)
        Me._imgKey_34.TabIndex = 53
        Me._imgKey_34.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_34, "Jump To Frequency")
        '
        '_imgKey_33
        '
        Me._imgKey_33.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_33.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_33, CType(33, Short))
        Me._imgKey_33.Location = New System.Drawing.Point(614, 308)
        Me._imgKey_33.Name = "_imgKey_33"
        Me._imgKey_33.Size = New System.Drawing.Size(44, 56)
        Me._imgKey_33.TabIndex = 54
        Me._imgKey_33.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_33, "Backlight (Hand Held Only)")
        '
        '_imgKey_31
        '
        Me._imgKey_31.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_31.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_31, CType(31, Short))
        Me._imgKey_31.Location = New System.Drawing.Point(602, 223)
        Me._imgKey_31.Name = "_imgKey_31"
        Me._imgKey_31.Size = New System.Drawing.Size(57, 56)
        Me._imgKey_31.TabIndex = 55
        Me._imgKey_31.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_31, "Scan")
        '
        '_imgKey_30
        '
        Me._imgKey_30.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_30.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_30, CType(30, Short))
        Me._imgKey_30.Location = New System.Drawing.Point(695, 58)
        Me._imgKey_30.Name = "_imgKey_30"
        Me._imgKey_30.Size = New System.Drawing.Size(62, 23)
        Me._imgKey_30.TabIndex = 56
        Me._imgKey_30.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_30, "Attempt link with scanner")
        '
        '_imgKey_29
        '
        Me._imgKey_29.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_29.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_29, CType(29, Short))
        Me._imgKey_29.Location = New System.Drawing.Point(695, 31)
        Me._imgKey_29.Name = "_imgKey_29"
        Me._imgKey_29.Size = New System.Drawing.Size(62, 23)
        Me._imgKey_29.TabIndex = 57
        Me._imgKey_29.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_29, "Stop communicating with scanner")
        '
        '_imgKey_16
        '
        Me._imgKey_16.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_16.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_16, CType(16, Short))
        Me._imgKey_16.Location = New System.Drawing.Point(692, 281)
        Me._imgKey_16.Name = "_imgKey_16"
        Me._imgKey_16.Size = New System.Drawing.Size(53, 23)
        Me._imgKey_16.TabIndex = 58
        Me._imgKey_16.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_16, "Scrol Right")
        '
        '_imgKey_18
        '
        Me._imgKey_18.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_18.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_18, CType(18, Short))
        Me._imgKey_18.Location = New System.Drawing.Point(599, 284)
        Me._imgKey_18.Name = "_imgKey_18"
        Me._imgKey_18.Size = New System.Drawing.Size(53, 21)
        Me._imgKey_18.TabIndex = 59
        Me._imgKey_18.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_18, "Scroll Left")
        '
        '_imgKey_17
        '
        Me._imgKey_17.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_17.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_17, CType(17, Short))
        Me._imgKey_17.Location = New System.Drawing.Point(653, 281)
        Me._imgKey_17.Name = "_imgKey_17"
        Me._imgKey_17.Size = New System.Drawing.Size(38, 26)
        Me._imgKey_17.TabIndex = 60
        Me._imgKey_17.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_17, "Push Selector")
        '
        '_imgKey_15
        '
        Me._imgKey_15.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_15.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_15, CType(15, Short))
        Me._imgKey_15.Location = New System.Drawing.Point(251, 115)
        Me._imgKey_15.Name = "_imgKey_15"
        Me._imgKey_15.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_15.TabIndex = 61
        Me._imgKey_15.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_15, "E yes")
        '
        '_imgKey_9
        '
        Me._imgKey_9.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_9.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_9, CType(9, Short))
        Me._imgKey_9.Location = New System.Drawing.Point(251, 85)
        Me._imgKey_9.Name = "_imgKey_9"
        Me._imgKey_9.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_9.TabIndex = 62
        Me._imgKey_9.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_9, "9")
        '
        '_imgKey_6
        '
        Me._imgKey_6.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_6.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_6, CType(6, Short))
        Me._imgKey_6.Location = New System.Drawing.Point(251, 58)
        Me._imgKey_6.Name = "_imgKey_6"
        Me._imgKey_6.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_6.TabIndex = 63
        Me._imgKey_6.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_6, "6")
        '
        '_imgKey_3
        '
        Me._imgKey_3.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_3.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_3, CType(3, Short))
        Me._imgKey_3.Location = New System.Drawing.Point(251, 31)
        Me._imgKey_3.Name = "_imgKey_3"
        Me._imgKey_3.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_3.TabIndex = 64
        Me._imgKey_3.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_3, "3")
        '
        '_imgKey_0
        '
        Me._imgKey_0.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_0.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_0, CType(0, Short))
        Me._imgKey_0.Location = New System.Drawing.Point(200, 115)
        Me._imgKey_0.Name = "_imgKey_0"
        Me._imgKey_0.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_0.TabIndex = 65
        Me._imgKey_0.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_0, "0")
        '
        '_imgKey_8
        '
        Me._imgKey_8.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_8.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_8, CType(8, Short))
        Me._imgKey_8.Location = New System.Drawing.Point(200, 85)
        Me._imgKey_8.Name = "_imgKey_8"
        Me._imgKey_8.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_8.TabIndex = 66
        Me._imgKey_8.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_8, "8")
        '
        '_imgKey_5
        '
        Me._imgKey_5.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_5.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_5, CType(5, Short))
        Me._imgKey_5.Location = New System.Drawing.Point(200, 58)
        Me._imgKey_5.Name = "_imgKey_5"
        Me._imgKey_5.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_5.TabIndex = 67
        Me._imgKey_5.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_5, "5")
        '
        '_imgKey_2
        '
        Me._imgKey_2.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_2.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_2, CType(2, Short))
        Me._imgKey_2.InitialImage = Nothing
        Me._imgKey_2.Location = New System.Drawing.Point(200, 31)
        Me._imgKey_2.Name = "_imgKey_2"
        Me._imgKey_2.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_2.TabIndex = 68
        Me._imgKey_2.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_2, "2")
        '
        '_imgKey_14
        '
        Me._imgKey_14.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_14.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_14, CType(14, Short))
        Me._imgKey_14.Location = New System.Drawing.Point(149, 115)
        Me._imgKey_14.Name = "_imgKey_14"
        Me._imgKey_14.Size = New System.Drawing.Size(50, 23)
        Me._imgKey_14.TabIndex = 69
        Me._imgKey_14.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_14, ".No")
        '
        '_imgKey_7
        '
        Me._imgKey_7.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_7.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_7, CType(7, Short))
        Me._imgKey_7.Location = New System.Drawing.Point(152, 85)
        Me._imgKey_7.Name = "_imgKey_7"
        Me._imgKey_7.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_7.TabIndex = 70
        Me._imgKey_7.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_7, "7")
        '
        '_imgKey_4
        '
        Me._imgKey_4.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_4.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_4, CType(4, Short))
        Me._imgKey_4.Location = New System.Drawing.Point(152, 58)
        Me._imgKey_4.Name = "_imgKey_4"
        Me._imgKey_4.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_4.TabIndex = 71
        Me._imgKey_4.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_4, "4")
        '
        '_imgKey_1
        '
        Me._imgKey_1.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_1.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_1, CType(1, Short))
        Me._imgKey_1.Location = New System.Drawing.Point(152, 31)
        Me._imgKey_1.Name = "_imgKey_1"
        Me._imgKey_1.Size = New System.Drawing.Size(47, 23)
        Me._imgKey_1.TabIndex = 72
        Me._imgKey_1.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_1, "1")
        '
        '_imgKey_13
        '
        Me._imgKey_13.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_13.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_13, CType(13, Short))
        Me._imgKey_13.Location = New System.Drawing.Point(83, 115)
        Me._imgKey_13.Name = "_imgKey_13"
        Me._imgKey_13.Size = New System.Drawing.Size(62, 23)
        Me._imgKey_13.TabIndex = 73
        Me._imgKey_13.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_13, "Power")
        '
        '_imgKey_12
        '
        Me._imgKey_12.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_12.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_12, CType(12, Short))
        Me._imgKey_12.Location = New System.Drawing.Point(83, 85)
        Me._imgKey_12.Name = "_imgKey_12"
        Me._imgKey_12.Size = New System.Drawing.Size(62, 23)
        Me._imgKey_12.TabIndex = 74
        Me._imgKey_12.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_12, "Lock Out")
        '
        '_imgKey_11
        '
        Me._imgKey_11.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_11.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_11, CType(11, Short))
        Me._imgKey_11.Location = New System.Drawing.Point(83, 58)
        Me._imgKey_11.Name = "_imgKey_11"
        Me._imgKey_11.Size = New System.Drawing.Size(62, 23)
        Me._imgKey_11.TabIndex = 75
        Me._imgKey_11.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_11, "Scan")
        '
        '_imgKey_10
        '
        Me._imgKey_10.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_10.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_10, CType(10, Short))
        Me._imgKey_10.Location = New System.Drawing.Point(86, 28)
        Me._imgKey_10.Name = "_imgKey_10"
        Me._imgKey_10.Size = New System.Drawing.Size(62, 26)
        Me._imgKey_10.TabIndex = 76
        Me._imgKey_10.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_10, "Hold")
        '
        '_imgKey_20
        '
        Me._imgKey_20.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_20.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_20, CType(20, Short))
        Me._imgKey_20.Location = New System.Drawing.Point(302, 85)
        Me._imgKey_20.Name = "_imgKey_20"
        Me._imgKey_20.Size = New System.Drawing.Size(59, 23)
        Me._imgKey_20.TabIndex = 77
        Me._imgKey_20.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_20, "Hold Function Key")
        '
        '_imgKey_28
        '
        Me._imgKey_28.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_28.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_28, CType(28, Short))
        Me._imgKey_28.Location = New System.Drawing.Point(302, 58)
        Me._imgKey_28.Name = "_imgKey_28"
        Me._imgKey_28.Size = New System.Drawing.Size(59, 23)
        Me._imgKey_28.TabIndex = 78
        Me._imgKey_28.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_28, "Function")
        '
        '_imgKey_19
        '
        Me._imgKey_19.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_19.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_19, CType(19, Short))
        Me._imgKey_19.Location = New System.Drawing.Point(302, 31)
        Me._imgKey_19.Name = "_imgKey_19"
        Me._imgKey_19.Size = New System.Drawing.Size(59, 23)
        Me._imgKey_19.TabIndex = 79
        Me._imgKey_19.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgKey_19, "Menu")
        '
        'picCloseCallACt
        '
        Me.picCloseCallACt.BackColor = System.Drawing.SystemColors.Control
        Me.picCloseCallACt.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCloseCallACt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picCloseCallACt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picCloseCallACt.Image = CType(resources.GetObject("picCloseCallACt.Image"), System.Drawing.Image)
        Me.picCloseCallACt.Location = New System.Drawing.Point(222, 161)
        Me.picCloseCallACt.Name = "picCloseCallACt"
        Me.picCloseCallACt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picCloseCallACt.Size = New System.Drawing.Size(186, 16)
        Me.picCloseCallACt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCloseCallACt.TabIndex = 24
        Me.picCloseCallACt.TabStop = False
        Me.picCloseCallACt.Visible = False
        '
        'Graphic
        '
        Me.Graphic.Interval = 30
        '
        'picAlertLED
        '
        Me.picAlertLED.BackColor = System.Drawing.SystemColors.Control
        Me.picAlertLED.Cursor = System.Windows.Forms.Cursors.Default
        Me.picAlertLED.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picAlertLED.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picAlertLED.Image = CType(resources.GetObject("picAlertLED.Image"), System.Drawing.Image)
        Me.picAlertLED.Location = New System.Drawing.Point(408, 162)
        Me.picAlertLED.Name = "picAlertLED"
        Me.picAlertLED.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picAlertLED.Size = New System.Drawing.Size(103, 16)
        Me.picAlertLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picAlertLED.TabIndex = 23
        Me.picAlertLED.TabStop = False
        Me.picAlertLED.Visible = False
        '
        'picUpArrow
        '
        Me.picUpArrow.BackColor = System.Drawing.SystemColors.Window
        Me.picUpArrow.Cursor = System.Windows.Forms.Cursors.Default
        Me.picUpArrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picUpArrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picUpArrow.Image = CType(resources.GetObject("picUpArrow.Image"), System.Drawing.Image)
        Me.picUpArrow.Location = New System.Drawing.Point(77, 252)
        Me.picUpArrow.Name = "picUpArrow"
        Me.picUpArrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picUpArrow.Size = New System.Drawing.Size(15, 19)
        Me.picUpArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picUpArrow.TabIndex = 10
        Me.picUpArrow.TabStop = False
        Me.picUpArrow.Visible = False
        '
        'picDownArrow
        '
        Me.picDownArrow.BackColor = System.Drawing.SystemColors.Window
        Me.picDownArrow.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDownArrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picDownArrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picDownArrow.Image = CType(resources.GetObject("picDownArrow.Image"), System.Drawing.Image)
        Me.picDownArrow.Location = New System.Drawing.Point(77, 272)
        Me.picDownArrow.Name = "picDownArrow"
        Me.picDownArrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picDownArrow.Size = New System.Drawing.Size(15, 19)
        Me.picDownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDownArrow.TabIndex = 9
        Me.picDownArrow.TabStop = False
        Me.picDownArrow.Visible = False
        '
        'picWX
        '
        Me.picWX.BackColor = System.Drawing.SystemColors.Window
        Me.picWX.Cursor = System.Windows.Forms.Cursors.Default
        Me.picWX.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picWX.ForeColor = System.Drawing.Color.Black
        Me.picWX.Image = CType(resources.GetObject("picWX.Image"), System.Drawing.Image)
        Me.picWX.Location = New System.Drawing.Point(8, 33)
        Me.picWX.Name = "picWX"
        Me.picWX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picWX.Size = New System.Drawing.Size(57, 42)
        Me.picWX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picWX.TabIndex = 8
        Me.picWX.TabStop = False
        '
        'picENC
        '
        Me.picENC.BackColor = System.Drawing.SystemColors.Window
        Me.picENC.Cursor = System.Windows.Forms.Cursors.Default
        Me.picENC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picENC.ForeColor = System.Drawing.Color.Black
        Me.picENC.Image = CType(resources.GetObject("picENC.Image"), System.Drawing.Image)
        Me.picENC.Location = New System.Drawing.Point(9, 316)
        Me.picENC.Name = "picENC"
        Me.picENC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picENC.Size = New System.Drawing.Size(57, 90)
        Me.picENC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picENC.TabIndex = 7
        Me.picENC.TabStop = False
        '
        'PicOnline2
        '
        Me.PicOnline2.BackColor = System.Drawing.SystemColors.Window
        Me.PicOnline2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicOnline2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicOnline2.ForeColor = System.Drawing.Color.Black
        Me.PicOnline2.Image = CType(resources.GetObject("PicOnline2.Image"), System.Drawing.Image)
        Me.PicOnline2.Location = New System.Drawing.Point(71, 161)
        Me.PicOnline2.Name = "PicOnline2"
        Me.PicOnline2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicOnline2.Size = New System.Drawing.Size(149, 17)
        Me.PicOnline2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicOnline2.TabIndex = 6
        Me.PicOnline2.TabStop = False
        '
        'PicLO
        '
        Me.PicLO.BackColor = System.Drawing.SystemColors.Control
        Me.PicLO.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicLO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicLO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicLO.Image = CType(resources.GetObject("PicLO.Image"), System.Drawing.Image)
        Me.PicLO.Location = New System.Drawing.Point(666, 144)
        Me.PicLO.Name = "PicLO"
        Me.PicLO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicLO.Size = New System.Drawing.Size(98, 17)
        Me.PicLO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicLO.TabIndex = 4
        Me.PicLO.TabStop = False
        '
        'picHOld
        '
        Me.picHOld.BackColor = System.Drawing.SystemColors.Control
        Me.picHOld.Cursor = System.Windows.Forms.Cursors.Default
        Me.picHOld.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picHOld.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picHOld.Image = CType(resources.GetObject("picHOld.Image"), System.Drawing.Image)
        Me.picHOld.Location = New System.Drawing.Point(514, 145)
        Me.picHOld.Name = "picHOld"
        Me.picHOld.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picHOld.Size = New System.Drawing.Size(151, 16)
        Me.picHOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picHOld.TabIndex = 3
        Me.picHOld.TabStop = False
        '
        'PicOnline1
        '
        Me.PicOnline1.BackColor = System.Drawing.SystemColors.Window
        Me.PicOnline1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicOnline1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicOnline1.ForeColor = System.Drawing.Color.Black
        Me.PicOnline1.Image = CType(resources.GetObject("PicOnline1.Image"), System.Drawing.Image)
        Me.PicOnline1.Location = New System.Drawing.Point(5, 161)
        Me.PicOnline1.Name = "PicOnline1"
        Me.PicOnline1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicOnline1.Size = New System.Drawing.Size(66, 154)
        Me.PicOnline1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicOnline1.TabIndex = 2
        Me.PicOnline1.TabStop = False
        '
        'picLowBatt
        '
        Me.picLowBatt.BackColor = System.Drawing.SystemColors.Control
        Me.picLowBatt.Cursor = System.Windows.Forms.Cursors.Default
        Me.picLowBatt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picLowBatt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picLowBatt.Image = CType(resources.GetObject("picLowBatt.Image"), System.Drawing.Image)
        Me.picLowBatt.Location = New System.Drawing.Point(222, 144)
        Me.picLowBatt.Name = "picLowBatt"
        Me.picLowBatt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picLowBatt.Size = New System.Drawing.Size(188, 18)
        Me.picLowBatt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLowBatt.TabIndex = 1
        Me.picLowBatt.TabStop = False
        Me.picLowBatt.Visible = False
        '
        'PicCC
        '
        Me.PicCC.BackColor = System.Drawing.SystemColors.Control
        Me.PicCC.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicCC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicCC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicCC.Image = CType(resources.GetObject("PicCC.Image"), System.Drawing.Image)
        Me.PicCC.Location = New System.Drawing.Point(408, 145)
        Me.PicCC.Name = "PicCC"
        Me.PicCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicCC.Size = New System.Drawing.Size(105, 17)
        Me.PicCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicCC.TabIndex = 0
        Me.PicCC.TabStop = False
        Me.PicCC.Visible = False
        '
        '_lblDisp_9
        '
        Me._lblDisp_9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._lblDisp_9.AutoSize = True
        Me._lblDisp_9.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_9, CType(9, Short))
        Me._lblDisp_9.Location = New System.Drawing.Point(477, 190)
        Me._lblDisp_9.Name = "_lblDisp_9"
        Me._lblDisp_9.Size = New System.Drawing.Size(27, 16)
        Me._lblDisp_9.TabIndex = 25
        Me._lblDisp_9.Text = "111"
        Me._lblDisp_9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'imgClearALl
        '
        Me.imgClearALl.BackColor = System.Drawing.Color.Transparent
        Me.imgClearALl.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgClearALl.Location = New System.Drawing.Point(582, 29)
        Me.imgClearALl.Name = "imgClearALl"
        Me.imgClearALl.Size = New System.Drawing.Size(67, 25)
        Me.imgClearALl.TabIndex = 26
        Me.imgClearALl.TabStop = False
        '
        '_imgKey_46
        '
        Me._imgKey_46.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_46.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_46, CType(46, Short))
        Me._imgKey_46.Location = New System.Drawing.Point(657, 380)
        Me._imgKey_46.Name = "_imgKey_46"
        Me._imgKey_46.Size = New System.Drawing.Size(30, 28)
        Me._imgKey_46.TabIndex = 27
        Me._imgKey_46.TabStop = False
        '
        '_imgKey_45
        '
        Me._imgKey_45.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_45.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_45, CType(45, Short))
        Me._imgKey_45.Location = New System.Drawing.Point(693, 371)
        Me._imgKey_45.Name = "_imgKey_45"
        Me._imgKey_45.Size = New System.Drawing.Size(30, 28)
        Me._imgKey_45.TabIndex = 28
        Me._imgKey_45.TabStop = False
        '
        '_imgKey_44
        '
        Me._imgKey_44.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_44.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_44.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_44, CType(44, Short))
        Me._imgKey_44.Location = New System.Drawing.Point(723, 351)
        Me._imgKey_44.Name = "_imgKey_44"
        Me._imgKey_44.Size = New System.Drawing.Size(43, 39)
        Me._imgKey_44.TabIndex = 29
        Me._imgKey_44.TabStop = False
        '
        '_imgKey_43
        '
        Me._imgKey_43.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_43.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_43, CType(43, Short))
        Me._imgKey_43.Location = New System.Drawing.Point(743, 312)
        Me._imgKey_43.Name = "_imgKey_43"
        Me._imgKey_43.Size = New System.Drawing.Size(30, 54)
        Me._imgKey_43.TabIndex = 30
        Me._imgKey_43.TabStop = False
        '
        '_imgKey_42
        '
        Me._imgKey_42.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_42.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_42, CType(42, Short))
        Me._imgKey_42.Location = New System.Drawing.Point(750, 282)
        Me._imgKey_42.Name = "_imgKey_42"
        Me._imgKey_42.Size = New System.Drawing.Size(30, 28)
        Me._imgKey_42.TabIndex = 31
        Me._imgKey_42.TabStop = False
        '
        '_imgKey_41
        '
        Me._imgKey_41.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_41.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_41, CType(41, Short))
        Me._imgKey_41.Location = New System.Drawing.Point(750, 251)
        Me._imgKey_41.Name = "_imgKey_41"
        Me._imgKey_41.Size = New System.Drawing.Size(30, 26)
        Me._imgKey_41.TabIndex = 32
        Me._imgKey_41.TabStop = False
        '
        '_imgKey_40
        '
        Me._imgKey_40.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_40.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_40, CType(40, Short))
        Me._imgKey_40.Location = New System.Drawing.Point(734, 229)
        Me._imgKey_40.Name = "_imgKey_40"
        Me._imgKey_40.Size = New System.Drawing.Size(29, 22)
        Me._imgKey_40.TabIndex = 33
        Me._imgKey_40.TabStop = False
        '
        '_imgKey_39
        '
        Me._imgKey_39.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_39.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_39, CType(39, Short))
        Me._imgKey_39.Location = New System.Drawing.Point(714, 207)
        Me._imgKey_39.Name = "_imgKey_39"
        Me._imgKey_39.Size = New System.Drawing.Size(23, 24)
        Me._imgKey_39.TabIndex = 34
        Me._imgKey_39.TabStop = False
        '
        '_imgKey_38
        '
        Me._imgKey_38.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_38.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_38, CType(38, Short))
        Me._imgKey_38.Location = New System.Drawing.Point(688, 189)
        Me._imgKey_38.Name = "_imgKey_38"
        Me._imgKey_38.Size = New System.Drawing.Size(26, 28)
        Me._imgKey_38.TabIndex = 35
        Me._imgKey_38.TabStop = False
        '
        '_imgKey_37
        '
        Me._imgKey_37.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_37.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_37, CType(37, Short))
        Me._imgKey_37.Location = New System.Drawing.Point(658, 186)
        Me._imgKey_37.Name = "_imgKey_37"
        Me._imgKey_37.Size = New System.Drawing.Size(28, 28)
        Me._imgKey_37.TabIndex = 36
        Me._imgKey_37.TabStop = False
        '
        '_imgKey_36
        '
        Me._imgKey_36.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_36.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgKey.SetIndex(Me._imgKey_36, CType(36, Short))
        Me._imgKey_36.InitialImage = Nothing
        Me._imgKey_36.Location = New System.Drawing.Point(627, 194)
        Me._imgKey_36.Name = "_imgKey_36"
        Me._imgKey_36.Size = New System.Drawing.Size(30, 28)
        Me._imgKey_36.TabIndex = 37
        Me._imgKey_36.TabStop = False
        '
        '_imgKey_27
        '
        Me._imgKey_27.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_27.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_27, CType(27, Short))
        Me._imgKey_27.Location = New System.Drawing.Point(567, 250)
        Me._imgKey_27.Name = "_imgKey_27"
        Me._imgKey_27.Size = New System.Drawing.Size(30, 28)
        Me._imgKey_27.TabIndex = 38
        Me._imgKey_27.TabStop = False
        '
        '_imgKey_26
        '
        Me._imgKey_26.BackColor = System.Drawing.Color.Transparent
        Me._imgKey_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgKey_26.ErrorImage = Nothing
        Me.imgKey.SetIndex(Me._imgKey_26, CType(26, Short))
        Me._imgKey_26.Location = New System.Drawing.Point(564, 282)
        Me._imgKey_26.Name = "_imgKey_26"
        Me._imgKey_26.Size = New System.Drawing.Size(30, 28)
        Me._imgKey_26.TabIndex = 39
        Me._imgKey_26.TabStop = False
        '
        '_shpSig_0
        '
        Me._shpSig_0.BackColor = System.Drawing.Color.Red
        Me._shpSig_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._shpSig_0.ForeColor = System.Drawing.Color.Black
        Me.shpSig.SetIndex(Me._shpSig_0, CType(0, Short))
        Me._shpSig_0.Location = New System.Drawing.Point(533, 101)
        Me._shpSig_0.Name = "_shpSig_0"
        Me._shpSig_0.Size = New System.Drawing.Size(7, 11)
        Me._shpSig_0.TabIndex = 40
        Me._shpSig_0.Text = "_shpSig_0"
        Me._shpSig_0.Visible = False
        '
        '_lblCursor_1
        '
        Me._lblCursor_1.BackColor = System.Drawing.Color.Transparent
        Me._lblCursor_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCursor_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCursor_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCursor.SetIndex(Me._lblCursor_1, CType(1, Short))
        Me._lblCursor_1.Location = New System.Drawing.Point(105, 293)
        Me._lblCursor_1.Name = "_lblCursor_1"
        Me._lblCursor_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCursor_1.Size = New System.Drawing.Size(153, 22)
        Me._lblCursor_1.TabIndex = 21
        Me._lblCursor_1.Text = "___________"
        Me._lblCursor_1.Visible = False
        '
        '_lblCursor_2
        '
        Me._lblCursor_2.BackColor = System.Drawing.Color.Transparent
        Me._lblCursor_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCursor_2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCursor_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCursor.SetIndex(Me._lblCursor_2, CType(2, Short))
        Me._lblCursor_2.Location = New System.Drawing.Point(105, 333)
        Me._lblCursor_2.Name = "_lblCursor_2"
        Me._lblCursor_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCursor_2.Size = New System.Drawing.Size(153, 12)
        Me._lblCursor_2.TabIndex = 18
        Me._lblCursor_2.Text = "-----------"
        Me._lblCursor_2.Visible = False
        '
        '_lblCursor_0
        '
        Me._lblCursor_0.BackColor = System.Drawing.Color.Transparent
        Me._lblCursor_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCursor_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCursor_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCursor.SetIndex(Me._lblCursor_0, CType(0, Short))
        Me._lblCursor_0.Location = New System.Drawing.Point(105, 265)
        Me._lblCursor_0.Name = "_lblCursor_0"
        Me._lblCursor_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCursor_0.Size = New System.Drawing.Size(137, 24)
        Me._lblCursor_0.TabIndex = 17
        Me._lblCursor_0.Text = "_____________________"
        '
        '_shpIndicate_4
        '
        Me._shpIndicate_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._shpIndicate_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shpIndicate.SetIndex(Me._shpIndicate_4, CType(4, Short))
        Me._shpIndicate_4.Location = New System.Drawing.Point(407, 387)
        Me._shpIndicate_4.Name = "_shpIndicate_4"
        Me._shpIndicate_4.Size = New System.Drawing.Size(57, 16)
        Me._shpIndicate_4.TabIndex = 48
        '
        '_shpIndicate_3
        '
        Me._shpIndicate_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._shpIndicate_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shpIndicate.SetIndex(Me._shpIndicate_3, CType(3, Short))
        Me._shpIndicate_3.Location = New System.Drawing.Point(406, 344)
        Me._shpIndicate_3.Name = "_shpIndicate_3"
        Me._shpIndicate_3.Size = New System.Drawing.Size(57, 16)
        Me._shpIndicate_3.TabIndex = 49
        '
        '_shpIndicate_2
        '
        Me._shpIndicate_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._shpIndicate_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shpIndicate.SetIndex(Me._shpIndicate_2, CType(2, Short))
        Me._shpIndicate_2.Location = New System.Drawing.Point(407, 298)
        Me._shpIndicate_2.Name = "_shpIndicate_2"
        Me._shpIndicate_2.Size = New System.Drawing.Size(57, 16)
        Me._shpIndicate_2.TabIndex = 50
        '
        '_shpIndicate_1
        '
        Me._shpIndicate_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._shpIndicate_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shpIndicate.SetIndex(Me._shpIndicate_1, CType(1, Short))
        Me._shpIndicate_1.Location = New System.Drawing.Point(406, 255)
        Me._shpIndicate_1.Name = "_shpIndicate_1"
        Me._shpIndicate_1.Size = New System.Drawing.Size(57, 16)
        Me._shpIndicate_1.TabIndex = 51
        '
        '_shpIndicate_0
        '
        Me._shpIndicate_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._shpIndicate_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shpIndicate.SetIndex(Me._shpIndicate_0, CType(0, Short))
        Me._shpIndicate_0.Location = New System.Drawing.Point(405, 210)
        Me._shpIndicate_0.Name = "_shpIndicate_0"
        Me._shpIndicate_0.Size = New System.Drawing.Size(101, 16)
        Me._shpIndicate_0.TabIndex = 52
        '
        '_lblDisp_7
        '
        Me._lblDisp_7.AutoSize = True
        Me._lblDisp_7.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._lblDisp_7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_7, CType(7, Short))
        Me._lblDisp_7.Location = New System.Drawing.Point(265, 306)
        Me._lblDisp_7.Name = "_lblDisp_7"
        Me._lblDisp_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_7.Size = New System.Drawing.Size(79, 16)
        Me._lblDisp_7.TabIndex = 22
        Me._lblDisp_7.Text = "LBLMOD 07"
        '
        '_lblDisp_6
        '
        Me._lblDisp_6.AutoSize = True
        Me._lblDisp_6.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_6, CType(6, Short))
        Me._lblDisp_6.Location = New System.Drawing.Point(102, 379)
        Me._lblDisp_6.Name = "_lblDisp_6"
        Me._lblDisp_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_6.Size = New System.Drawing.Size(50, 16)
        Me._lblDisp_6.TabIndex = 20
        Me._lblDisp_6.Text = "LBLID6"
        '
        '_lblDisp_0
        '
        Me._lblDisp_0.AutoSize = True
        Me._lblDisp_0.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_0, CType(0, Short))
        Me._lblDisp_0.Location = New System.Drawing.Point(171, 210)
        Me._lblDisp_0.Name = "_lblDisp_0"
        Me._lblDisp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_0.Size = New System.Drawing.Size(46, 16)
        Me._lblDisp_0.TabIndex = 19
        Me._lblDisp_0.Text = "Label3"
        Me._lblDisp_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblDisp_5
        '
        Me._lblDisp_5.AutoSize = True
        Me._lblDisp_5.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_5, CType(5, Short))
        Me._lblDisp_5.Location = New System.Drawing.Point(102, 349)
        Me._lblDisp_5.Name = "_lblDisp_5"
        Me._lblDisp_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_5.Size = New System.Drawing.Size(46, 16)
        Me._lblDisp_5.TabIndex = 16
        Me._lblDisp_5.Text = "Label3"
        '
        '_lblDisp_4
        '
        Me._lblDisp_4.AutoSize = True
        Me._lblDisp_4.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_4, CType(4, Short))
        Me._lblDisp_4.Location = New System.Drawing.Point(102, 323)
        Me._lblDisp_4.Name = "_lblDisp_4"
        Me._lblDisp_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_4.Size = New System.Drawing.Size(46, 16)
        Me._lblDisp_4.TabIndex = 15
        Me._lblDisp_4.Text = "Label3"
        '
        '_lblDisp_2
        '
        Me._lblDisp_2.AutoSize = True
        Me._lblDisp_2.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_2, CType(2, Short))
        Me._lblDisp_2.Location = New System.Drawing.Point(102, 262)
        Me._lblDisp_2.Name = "_lblDisp_2"
        Me._lblDisp_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_2.Size = New System.Drawing.Size(46, 16)
        Me._lblDisp_2.TabIndex = 14
        Me._lblDisp_2.Text = "Label3"
        '
        '_lblDisp_1
        '
        Me._lblDisp_1.AutoSize = True
        Me._lblDisp_1.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_1, CType(1, Short))
        Me._lblDisp_1.Location = New System.Drawing.Point(102, 237)
        Me._lblDisp_1.Name = "_lblDisp_1"
        Me._lblDisp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_1.Size = New System.Drawing.Size(46, 16)
        Me._lblDisp_1.TabIndex = 13
        Me._lblDisp_1.Text = "Label3"
        '
        '_lblDisp_3
        '
        Me._lblDisp_3.AutoSize = True
        Me._lblDisp_3.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_3, CType(3, Short))
        Me._lblDisp_3.Location = New System.Drawing.Point(103, 288)
        Me._lblDisp_3.Name = "_lblDisp_3"
        Me._lblDisp_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_3.Size = New System.Drawing.Size(46, 16)
        Me._lblDisp_3.TabIndex = 12
        Me._lblDisp_3.Text = "Label3"
        '
        '_lblDisp_8
        '
        Me._lblDisp_8.AutoSize = True
        Me._lblDisp_8.BackColor = System.Drawing.Color.Transparent
        Me._lblDisp_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDisp_8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDisp_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisp.SetIndex(Me._lblDisp_8, CType(8, Short))
        Me._lblDisp_8.Location = New System.Drawing.Point(102, 189)
        Me._lblDisp_8.Name = "_lblDisp_8"
        Me._lblDisp_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDisp_8.Size = New System.Drawing.Size(45, 16)
        Me._lblDisp_8.TabIndex = 11
        Me._lblDisp_8.Text = "LBL08"
        '
        'lblBat
        '
        Me.lblBat.AutoSize = True
        Me.lblBat.BackColor = System.Drawing.Color.Transparent
        Me.lblBat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBat.Location = New System.Drawing.Point(471, 280)
        Me.lblBat.Name = "lblBat"
        Me.lblBat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBat.Size = New System.Drawing.Size(39, 14)
        Me.lblBat.TabIndex = 5
        Me.lblBat.Text = "0.00 V"
        Me.lblBat.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'imgKey
        '
        '
        'MainMenu1
        '
        Me.MainMenu1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit, Me.mnuJump})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(794, 24)
        Me.MainMenu1.TabIndex = 83
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEnableLog, Me.SetupAudioRecordingToolStripMenuItem, Me.mnuEditViewLog, Me.mnuEditF, Me.mnuEditJump, Me.mnuToolsNegDelay, Me.ShowHideMainWindowToolStripMenuItem, Me.mnuEditExit})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(48, 20)
        Me.mnuEdit.Text = "&Tools"
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
        Me.mnuEditViewLog.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
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
        Me.mnuEditFont.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuEditFont.Size = New System.Drawing.Size(190, 22)
        Me.mnuEditFont.Text = "&Choose Font..."
        '
        'mnuEditFontColor
        '
        Me.mnuEditFontColor.Name = "mnuEditFontColor"
        Me.mnuEditFontColor.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditFontColor.Size = New System.Drawing.Size(190, 22)
        Me.mnuEditFontColor.Text = "Font &Colour..."
        '
        'mnuEditJump
        '
        Me.mnuEditJump.Name = "mnuEditJump"
        Me.mnuEditJump.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.mnuEditJump.Size = New System.Drawing.Size(225, 22)
        Me.mnuEditJump.Text = "&Jump To Frequency..."
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
        Me.mnuToolsNegDlyEnable.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuToolsNegDlyEnable.Size = New System.Drawing.Size(166, 22)
        Me.mnuToolsNegDlyEnable.Text = "E&nabled"
        '
        'mnuToolsNegDlyTime
        '
        Me.mnuToolsNegDlyTime.Name = "mnuToolsNegDlyTime"
        Me.mnuToolsNegDlyTime.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuToolsNegDlyTime.Size = New System.Drawing.Size(166, 22)
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
        Me.mnuJump.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.mnuJScan, Me._mnuJServMain_0, Me.mnuJCust, Me.mnuJCC, Me.mnuJWX, Me.mnuJFTO})
        Me.mnuJump.Name = "mnuJump"
        Me.mnuJump.Size = New System.Drawing.Size(48, 20)
        Me.mnuJump.Text = "&Jump"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(225, 22)
        Me.ToolStripMenuItem1.Text = "&Jump To Frequency..."
        '
        'mnuJScan
        '
        Me.mnuJScan.Name = "mnuJScan"
        Me.mnuJScan.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuJScan.Size = New System.Drawing.Size(225, 22)
        Me.mnuJScan.Text = "Scan Mode"
        '
        '_mnuJServMain_0
        '
        Me._mnuJServMain_0.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnuJServ_1, Me._mnuJServ_2, Me._mnuJServ_3, Me._mnuJServ_4, Me._mnuJServ_5, Me._mnuJServ_6, Me._mnuJServ_7, Me._mnuJServ_8, Me._mnuJServ_9, Me._mnuJServ_10, Me._mnuJServ_11, Me._mnuJServ_12, Me._mnuJServ_13})
        Me._mnuJServMain_0.Name = "_mnuJServMain_0"
        Me._mnuJServMain_0.Size = New System.Drawing.Size(225, 22)
        Me._mnuJServMain_0.Text = "&Service Scan"
        '
        '_mnuJServ_1
        '
        Me._mnuJServ_1.Name = "_mnuJServ_1"
        Me._mnuJServ_1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me._mnuJServ_1.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_1.Text = "Public Safety"
        '
        '_mnuJServ_2
        '
        Me._mnuJServ_2.Name = "_mnuJServ_2"
        Me._mnuJServ_2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me._mnuJServ_2.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_2.Text = "News"
        '
        '_mnuJServ_3
        '
        Me._mnuJServ_3.Name = "_mnuJServ_3"
        Me._mnuJServ_3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me._mnuJServ_3.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_3.Text = "Amateur Radio"
        '
        '_mnuJServ_4
        '
        Me._mnuJServ_4.Name = "_mnuJServ_4"
        Me._mnuJServ_4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me._mnuJServ_4.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_4.Text = "Marine"
        '
        '_mnuJServ_5
        '
        Me._mnuJServ_5.Name = "_mnuJServ_5"
        Me._mnuJServ_5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me._mnuJServ_5.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_5.Text = "Rail Road"
        '
        '_mnuJServ_6
        '
        Me._mnuJServ_6.Name = "_mnuJServ_6"
        Me._mnuJServ_6.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me._mnuJServ_6.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_6.Text = "Aircraft"
        '
        '_mnuJServ_7
        '
        Me._mnuJServ_7.Name = "_mnuJServ_7"
        Me._mnuJServ_7.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me._mnuJServ_7.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_7.Text = "CB Radio"
        '
        '_mnuJServ_8
        '
        Me._mnuJServ_8.Name = "_mnuJServ_8"
        Me._mnuJServ_8.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me._mnuJServ_8.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_8.Text = "FRS/GMRS"
        '
        '_mnuJServ_9
        '
        Me._mnuJServ_9.Name = "_mnuJServ_9"
        Me._mnuJServ_9.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me._mnuJServ_9.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_9.Text = "Racing"
        '
        '_mnuJServ_10
        '
        Me._mnuJServ_10.Name = "_mnuJServ_10"
        Me._mnuJServ_10.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me._mnuJServ_10.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_10.Text = "TV"
        '
        '_mnuJServ_11
        '
        Me._mnuJServ_11.Name = "_mnuJServ_11"
        Me._mnuJServ_11.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me._mnuJServ_11.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_11.Text = "Broadcast FM"
        '
        '_mnuJServ_12
        '
        Me._mnuJServ_12.Name = "_mnuJServ_12"
        Me._mnuJServ_12.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me._mnuJServ_12.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_12.Text = "Special"
        '
        '_mnuJServ_13
        '
        Me._mnuJServ_13.Name = "_mnuJServ_13"
        Me._mnuJServ_13.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me._mnuJServ_13.Size = New System.Drawing.Size(196, 22)
        Me._mnuJServ_13.Text = "Military"
        '
        'mnuJCust
        '
        Me.mnuJCust.Name = "mnuJCust"
        Me.mnuJCust.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuJCust.Size = New System.Drawing.Size(225, 22)
        Me.mnuJCust.Text = "Custom Search"
        '
        'mnuJCC
        '
        Me.mnuJCC.Name = "mnuJCC"
        Me.mnuJCC.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuJCC.Size = New System.Drawing.Size(225, 22)
        Me.mnuJCC.Text = "Close Call Only"
        '
        'mnuJWX
        '
        Me.mnuJWX.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnuWX_0, Me._mnuWX_1, Me._mnuWX_2, Me._mnuWX_3, Me._mnuWX_4, Me._mnuWX_5, Me._mnuWX_6, Me._mnuWX_7})
        Me.mnuJWX.Name = "mnuJWX"
        Me.mnuJWX.Size = New System.Drawing.Size(225, 22)
        Me.mnuJWX.Text = "Weather"
        '
        '_mnuWX_0
        '
        Me._mnuWX_0.Name = "_mnuWX_0"
        Me._mnuWX_0.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me._mnuWX_0.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_0.Text = "Normal Search"
        '
        '_mnuWX_1
        '
        Me._mnuWX_1.Name = "_mnuWX_1"
        Me._mnuWX_1.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_1.Text = "Alert Only"
        '
        '_mnuWX_2
        '
        Me._mnuWX_2.Name = "_mnuWX_2"
        Me._mnuWX_2.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_2.Text = "SAME 1"
        '
        '_mnuWX_3
        '
        Me._mnuWX_3.Name = "_mnuWX_3"
        Me._mnuWX_3.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_3.Text = "SAME 2"
        '
        '_mnuWX_4
        '
        Me._mnuWX_4.Name = "_mnuWX_4"
        Me._mnuWX_4.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_4.Text = "SAME 3"
        '
        '_mnuWX_5
        '
        Me._mnuWX_5.Name = "_mnuWX_5"
        Me._mnuWX_5.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_5.Text = "SAME 4"
        '
        '_mnuWX_6
        '
        Me._mnuWX_6.Name = "_mnuWX_6"
        Me._mnuWX_6.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_6.Text = "SAME 5"
        '
        '_mnuWX_7
        '
        Me._mnuWX_7.Name = "_mnuWX_7"
        Me._mnuWX_7.Size = New System.Drawing.Size(171, 22)
        Me._mnuWX_7.Text = "FIPS Search"
        '
        'mnuJFTO
        '
        Me.mnuJFTO.Name = "mnuJFTO"
        Me.mnuJFTO.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuJFTO.Size = New System.Drawing.Size(225, 22)
        Me.mnuJFTO.Text = "Fire Tone Out"
        '
        'sldOpacity
        '
        Me.sldOpacity.Location = New System.Drawing.Point(577, 74)
        Me.sldOpacity.Minimum = 2
        Me.sldOpacity.Name = "sldOpacity"
        Me.sldOpacity.Size = New System.Drawing.Size(78, 45)
        Me.sldOpacity.TabIndex = 84
        Me.sldOpacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.sldOpacity.Value = 10
        '
        'chkTopMost
        '
        Me.chkTopMost.AutoSize = True
        Me.chkTopMost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkTopMost.Location = New System.Drawing.Point(585, 118)
        Me.chkTopMost.Name = "chkTopMost"
        Me.chkTopMost.Size = New System.Drawing.Size(60, 18)
        Me.chkTopMost.TabIndex = 86
        Me.chkTopMost.Text = "&On Top"
        Me.chkTopMost.UseVisualStyleBackColor = True
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'SetupAudioRecordingToolStripMenuItem
        '
        Me.SetupAudioRecordingToolStripMenuItem.Name = "SetupAudioRecordingToolStripMenuItem"
        Me.SetupAudioRecordingToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SetupAudioRecordingToolStripMenuItem.Text = "Setup Audio Recording..."
        '
        'frmCtlLCARS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(794, 421)
        Me.Controls.Add(Me.chkTopMost)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.sldOpacity)
        Me.Controls.Add(Me._imgKey_19)
        Me.Controls.Add(Me.picCloseCallACt)
        Me.Controls.Add(Me.picAlertLED)
        Me.Controls.Add(Me.picUpArrow)
        Me.Controls.Add(Me.picDownArrow)
        Me.Controls.Add(Me.picWX)
        Me.Controls.Add(Me.picENC)
        Me.Controls.Add(Me.PicOnline2)
        Me.Controls.Add(Me.PicLO)
        Me.Controls.Add(Me.picHOld)
        Me.Controls.Add(Me.PicOnline1)
        Me.Controls.Add(Me.picLowBatt)
        Me.Controls.Add(Me.PicCC)
        Me.Controls.Add(Me._lblDisp_9)
        Me.Controls.Add(Me.imgClearALl)
        Me.Controls.Add(Me._imgKey_46)
        Me.Controls.Add(Me._imgKey_45)
        Me.Controls.Add(Me._imgKey_44)
        Me.Controls.Add(Me._imgKey_43)
        Me.Controls.Add(Me._imgKey_42)
        Me.Controls.Add(Me._imgKey_41)
        Me.Controls.Add(Me._imgKey_40)
        Me.Controls.Add(Me._imgKey_39)
        Me.Controls.Add(Me._imgKey_38)
        Me.Controls.Add(Me._imgKey_37)
        Me.Controls.Add(Me._imgKey_36)
        Me.Controls.Add(Me._imgKey_27)
        Me.Controls.Add(Me._imgKey_26)
        Me.Controls.Add(Me._shpSig_0)
        Me.Controls.Add(Me._imgKey_25)
        Me.Controls.Add(Me._imgKey_24)
        Me.Controls.Add(Me._imgKey_23)
        Me.Controls.Add(Me._imgKey_22)
        Me.Controls.Add(Me._imgKey_21)
        Me.Controls.Add(Me._imgKey_32)
        Me.Controls.Add(Me._imgKey_35)
        Me.Controls.Add(Me._shpIndicate_4)
        Me.Controls.Add(Me._shpIndicate_3)
        Me.Controls.Add(Me._shpIndicate_2)
        Me.Controls.Add(Me._shpIndicate_1)
        Me.Controls.Add(Me._shpIndicate_0)
        Me.Controls.Add(Me._lblDisp_7)
        Me.Controls.Add(Me._lblDisp_6)
        Me.Controls.Add(Me._lblDisp_0)
        Me.Controls.Add(Me._lblDisp_5)
        Me.Controls.Add(Me._lblDisp_4)
        Me.Controls.Add(Me._lblDisp_2)
        Me.Controls.Add(Me._lblDisp_1)
        Me.Controls.Add(Me._lblDisp_3)
        Me.Controls.Add(Me._lblDisp_8)
        Me.Controls.Add(Me.lblBat)
        Me.Controls.Add(Me._imgKey_34)
        Me.Controls.Add(Me._imgKey_33)
        Me.Controls.Add(Me._imgKey_31)
        Me.Controls.Add(Me._imgKey_30)
        Me.Controls.Add(Me._imgKey_29)
        Me.Controls.Add(Me._imgKey_16)
        Me.Controls.Add(Me._imgKey_18)
        Me.Controls.Add(Me._imgKey_17)
        Me.Controls.Add(Me._imgKey_15)
        Me.Controls.Add(Me._imgKey_9)
        Me.Controls.Add(Me._imgKey_6)
        Me.Controls.Add(Me._imgKey_3)
        Me.Controls.Add(Me._imgKey_0)
        Me.Controls.Add(Me._imgKey_8)
        Me.Controls.Add(Me._imgKey_5)
        Me.Controls.Add(Me._imgKey_2)
        Me.Controls.Add(Me._imgKey_14)
        Me.Controls.Add(Me._imgKey_7)
        Me.Controls.Add(Me._imgKey_4)
        Me.Controls.Add(Me._imgKey_1)
        Me.Controls.Add(Me._imgKey_13)
        Me.Controls.Add(Me._imgKey_12)
        Me.Controls.Add(Me._imgKey_11)
        Me.Controls.Add(Me._imgKey_10)
        Me.Controls.Add(Me._imgKey_20)
        Me.Controls.Add(Me._imgKey_28)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me._lblCursor_0)
        Me.Controls.Add(Me._lblCursor_2)
        Me.Controls.Add(Me._lblCursor_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 57)
        Me.Name = "frmCtlLCARS"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "LCARS Control"
        CType(Me._imgKey_25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCloseCallACt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAlertLED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDownArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picENC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOnline2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHOld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOnline1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLowBatt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClearALl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgKey_26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDisp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shpIndicate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shpSig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        CType(Me.sldOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Public WithEvents mnuJump As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuJScan As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuJServMain_0 As System.Windows.Forms.ToolStripMenuItem
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
    Public WithEvents mnuJCust As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuJCC As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuJWX As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuWX_0 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuWX_1 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuWX_2 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuWX_3 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuWX_4 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuWX_5 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuWX_6 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuWX_7 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuJFTO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sldOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents chkTopMost As System.Windows.Forms.CheckBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ShowHideMainWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupAudioRecordingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
#End Region 
End Class