<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRRCon
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
	Public WithEvents _StatusBar_Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents StatusBar As System.Windows.Forms.StatusStrip
	Public WithEvents cmdSaveHome As System.Windows.Forms.Button
	Public WithEvents cmdJumpHome As System.Windows.Forms.Button
	Public WithEvents cmdViewBrowse As System.Windows.Forms.Button
	Public WithEvents cmdAmerica As System.Windows.Forms.Button
	Public WithEvents cmdCanada As System.Windows.Forms.Button
    Public WithEvents cmdSignUp As System.Windows.Forms.Button
	Public WithEvents cmdImport As System.Windows.Forms.Button
	Public WithEvents txtSysName As System.Windows.Forms.TextBox
	Public WithEvents lstGroup As System.Windows.Forms.CheckedListBox
	Public WithEvents _cmdSiteChkAll_3 As System.Windows.Forms.Button
	Public WithEvents _cmdSiteChkAll_2 As System.Windows.Forms.Button
	Public WithEvents _tabImport_TabPage0 As System.Windows.Forms.TabPage
    'Public WithEvents grdFreq As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents chkSkipDig As System.Windows.Forms.CheckBox
	Public WithEvents chkDescComm As System.Windows.Forms.CheckBox
	Public WithEvents chkCompress As System.Windows.Forms.CheckBox
	Public WithEvents chkDisp As System.Windows.Forms.CheckBox
	Public WithEvents _tabImport_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents tabImport As System.Windows.Forms.TabControl
	Public WithEvents cmbCntAgency As System.Windows.Forms.ComboBox
	Public WithEvents cmbCounty As System.Windows.Forms.ComboBox
	Public WithEvents cmbProvAgency As System.Windows.Forms.ComboBox
	Public WithEvents cmbProvince As System.Windows.Forms.ComboBox
	Public WithEvents cmdConnect As System.Windows.Forms.Button
	Public WithEvents cmbCountry As System.Windows.Forms.ComboBox
	Public WithEvents chkSavepw As System.Windows.Forms.CheckBox
	Public WithEvents txtpassword As System.Windows.Forms.TextBox
	Public WithEvents txtUserName As System.Windows.Forms.TextBox
    Public WithEvents _lblCnt_4 As System.Windows.Forms.Label
	Public WithEvents _lblCnt_3 As System.Windows.Forms.Label
	Public WithEvents _lblCnt_2 As System.Windows.Forms.Label
	Public WithEvents _lblCnt_1 As System.Windows.Forms.Label
	Public WithEvents _lblCnt_0 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents _Label1_6 As System.Windows.Forms.Label
	Public WithEvents _Label1_5 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents cmdSiteChkAll As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lblCnt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim _Label1_0 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim RadioButton4 As System.Windows.Forms.RadioButton
        Dim cmbQKCantFind As System.Windows.Forms.ComboBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRRCon))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkSkipDig = New System.Windows.Forms.CheckBox()
        Me.cmdSaveHome = New System.Windows.Forms.Button()
        Me.cmdJumpHome = New System.Windows.Forms.Button()
        Me.cmdAmerica = New System.Windows.Forms.Button()
        Me.cmdCanada = New System.Windows.Forms.Button()
        Me.chkMiscGroup = New System.Windows.Forms.CheckBox()
        Me.chkSkipMode = New System.Windows.Forms.CheckBox()
        Me.chkGPSDefault = New System.Windows.Forms.CheckBox()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me._StatusBar_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdViewBrowse = New System.Windows.Forms.Button()
        Me.cmdSignUp = New System.Windows.Forms.Button()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.txtSysName = New System.Windows.Forms.TextBox()
        Me.tabImport = New System.Windows.Forms.TabControl()
        Me._tabImport_TabPage0 = New System.Windows.Forms.TabPage()
        Me.cmdChkNone = New System.Windows.Forms.Button()
        Me.cmdChkAll = New System.Windows.Forms.Button()
        Me.lstGroup = New System.Windows.Forms.CheckedListBox()
        Me._cmdSiteChkAll_3 = New System.Windows.Forms.Button()
        Me._cmdSiteChkAll_2 = New System.Windows.Forms.Button()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.lstTag = New System.Windows.Forms.CheckedListBox()
        Me._tabImport_TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmdFindQK = New System.Windows.Forms.Button()
        Me.cmbQK = New System.Windows.Forms.ComboBox()
        Me.radManQK = New System.Windows.Forms.RadioButton()
        Me.radAutoQK = New System.Windows.Forms.RadioButton()
        Me.cmbNumMisc = New System.Windows.Forms.ComboBox()
        Me.chkDescComm = New System.Windows.Forms.CheckBox()
        Me.chkCompress = New System.Windows.Forms.CheckBox()
        Me.chkDisp = New System.Windows.Forms.CheckBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.cmbCntAgency = New System.Windows.Forms.ComboBox()
        Me.cmbCounty = New System.Windows.Forms.ComboBox()
        Me.cmbProvAgency = New System.Windows.Forms.ComboBox()
        Me.cmbProvince = New System.Windows.Forms.ComboBox()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.chkSavepw = New System.Windows.Forms.CheckBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me._lblCnt_4 = New System.Windows.Forms.Label()
        Me._lblCnt_3 = New System.Windows.Forms.Label()
        Me._lblCnt_2 = New System.Windows.Forms.Label()
        Me._lblCnt_1 = New System.Windows.Forms.Label()
        Me._lblCnt_0 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Label1_6 = New System.Windows.Forms.Label()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me._Label1_4 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdSiteChkAll = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.lblCnt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.H2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.H3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.H4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.H5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblGrpSel = New System.Windows.Forms.Label()
        Me.cmdGroupChkNone = New System.Windows.Forms.Button()
        Me.cmdGroupChkAll = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.lstSite = New System.Windows.Forms.CheckedListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chkCtlOnly = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdFindFree = New System.Windows.Forms.Button()
        Me.OptQK0 = New System.Windows.Forms.RadioButton()
        Me.OptQK2 = New System.Windows.Forms.RadioButton()
        Me.OptQK1 = New System.Windows.Forms.RadioButton()
        Me.chkSkipENc = New System.Windows.Forms.CheckBox()
        Me.chkConCh = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.CheckedListBox4 = New System.Windows.Forms.CheckedListBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        _Label1_0 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        RadioButton4 = New System.Windows.Forms.RadioButton()
        cmbQKCantFind = New System.Windows.Forms.ComboBox()
        Me.StatusBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImport.SuspendLayout()
        Me._tabImport_TabPage0.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me._tabImport_TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSiteChkAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Label1_0
        '
        _Label1_0.BackColor = System.Drawing.SystemColors.Control
        _Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        _Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        _Label1_0.Location = New System.Drawing.Point(23, 31)
        _Label1_0.Name = "_Label1_0"
        _Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label1_0.Size = New System.Drawing.Size(35, 17)
        _Label1_0.TabIndex = 77
        _Label1_0.Text = "Login"
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(3, 9)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(516, 38)
        Label4.TabIndex = 0
        Label4.Text = "You can use this feature to fine tune which channels you want downloaded. Putting" & _
    " a checkmark next to a tag will cause channels with that tag to not be downloade" & _
    "d. "
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(3, 9)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(516, 38)
        Label7.TabIndex = 0
        Label7.Text = "You can use this feature to fine tune which channels you want downloaded. Putting" & _
    " a checkmark next to a tag will cause channels with that tag to not be downloade" & _
    "d. "
        '
        'Label8
        '
        Label8.Location = New System.Drawing.Point(3, 9)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(516, 38)
        Label8.TabIndex = 3
        Label8.Text = "You can use this feature to fine tune which channels you want downloaded. Putting" & _
    " a checkmark next to a tag will cause channels with that tag to not be downloade" & _
    "d. "
        '
        'RadioButton4
        '
        RadioButton4.AutoSize = True
        RadioButton4.Checked = True
        RadioButton4.Location = New System.Drawing.Point(401, 9)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New System.Drawing.Size(149, 18)
        RadioButton4.TabIndex = 39
        RadioButton4.TabStop = True
        RadioButton4.Text = "Don't assign a system QK"
        RadioButton4.UseVisualStyleBackColor = True
        '
        'cmbQKCantFind
        '
        cmbQKCantFind.FormattingEnabled = True
        cmbQKCantFind.Location = New System.Drawing.Point(0, 0)
        cmbQKCantFind.Name = "cmbQKCantFind"
        cmbQKCantFind.Size = New System.Drawing.Size(55, 21)
        cmbQKCantFind.TabIndex = 46
        '
        'chkSkipDig
        '
        Me.chkSkipDig.AutoSize = True
        Me.chkSkipDig.BackColor = System.Drawing.Color.Transparent
        Me.chkSkipDig.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSkipDig.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSkipDig.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSkipDig.Location = New System.Drawing.Point(16, 93)
        Me.chkSkipDig.Name = "chkSkipDig"
        Me.chkSkipDig.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSkipDig.Size = New System.Drawing.Size(176, 18)
        Me.chkSkipDig.TabIndex = 36
        Me.chkSkipDig.Text = "Skip channels marked as &digital"
        Me.ToolTip1.SetToolTip(Me.chkSkipDig, "Selecting this to avoid channels incompatible with an analog-only scanner")
        Me.chkSkipDig.UseVisualStyleBackColor = False
        '
        'cmdSaveHome
        '
        Me.cmdSaveHome.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveHome.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSaveHome.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveHome.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSaveHome.Image = CType(resources.GetObject("cmdSaveHome.Image"), System.Drawing.Image)
        Me.cmdSaveHome.Location = New System.Drawing.Point(136, 145)
        Me.cmdSaveHome.Name = "cmdSaveHome"
        Me.cmdSaveHome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSaveHome.Size = New System.Drawing.Size(40, 37)
        Me.cmdSaveHome.TabIndex = 39
        Me.cmdSaveHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdSaveHome, "Save present location as my home location")
        Me.cmdSaveHome.UseVisualStyleBackColor = False
        '
        'cmdJumpHome
        '
        Me.cmdJumpHome.BackColor = System.Drawing.SystemColors.Control
        Me.cmdJumpHome.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdJumpHome.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJumpHome.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdJumpHome.Image = CType(resources.GetObject("cmdJumpHome.Image"), System.Drawing.Image)
        Me.cmdJumpHome.Location = New System.Drawing.Point(69, 144)
        Me.cmdJumpHome.Name = "cmdJumpHome"
        Me.cmdJumpHome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdJumpHome.Size = New System.Drawing.Size(43, 37)
        Me.cmdJumpHome.TabIndex = 38
        Me.cmdJumpHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdJumpHome, "Recall my home location")
        Me.cmdJumpHome.UseVisualStyleBackColor = False
        '
        'cmdAmerica
        '
        Me.cmdAmerica.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAmerica.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAmerica.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAmerica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAmerica.Image = CType(resources.GetObject("cmdAmerica.Image"), System.Drawing.Image)
        Me.cmdAmerica.Location = New System.Drawing.Point(18, 171)
        Me.cmdAmerica.Name = "cmdAmerica"
        Me.cmdAmerica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAmerica.Size = New System.Drawing.Size(45, 24)
        Me.cmdAmerica.TabIndex = 35
        Me.cmdAmerica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdAmerica, "Jump to US")
        Me.cmdAmerica.UseVisualStyleBackColor = False
        '
        'cmdCanada
        '
        Me.cmdCanada.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCanada.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCanada.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCanada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCanada.Image = CType(resources.GetObject("cmdCanada.Image"), System.Drawing.Image)
        Me.cmdCanada.Location = New System.Drawing.Point(18, 144)
        Me.cmdCanada.Name = "cmdCanada"
        Me.cmdCanada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCanada.Size = New System.Drawing.Size(45, 27)
        Me.cmdCanada.TabIndex = 34
        Me.cmdCanada.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdCanada, "Jump to Canada")
        Me.cmdCanada.UseVisualStyleBackColor = False
        '
        'chkMiscGroup
        '
        Me.chkMiscGroup.BackColor = System.Drawing.Color.Transparent
        Me.chkMiscGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMiscGroup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMiscGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMiscGroup.Location = New System.Drawing.Point(16, 143)
        Me.chkMiscGroup.Name = "chkMiscGroup"
        Me.chkMiscGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMiscGroup.Size = New System.Drawing.Size(304, 37)
        Me.chkMiscGroup.TabIndex = 37
        Me.chkMiscGroup.Text = "Place channels in a 'Misc.' group, if the group being imported has this many chan" & _
    "nels or fewer:"
        Me.ToolTip1.SetToolTip(Me.chkMiscGroup, "Selecting this prevents having many groups that only have one or a few channels i" & _
        "n them by putting them all into one Misc group")
        Me.chkMiscGroup.UseVisualStyleBackColor = False
        '
        'chkSkipMode
        '
        Me.chkSkipMode.AutoSize = True
        Me.chkSkipMode.BackColor = System.Drawing.Color.Transparent
        Me.chkSkipMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSkipMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSkipMode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSkipMode.Location = New System.Drawing.Point(16, 118)
        Me.chkSkipMode.Name = "chkSkipMode"
        Me.chkSkipMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSkipMode.Size = New System.Drawing.Size(287, 18)
        Me.chkSkipMode.TabIndex = 44
        Me.chkSkipMode.Text = "Skip channels with incompatible modulation (eg TRBO)"
        Me.ToolTip1.SetToolTip(Me.chkSkipMode, "Selecting this to avoid channels incompatible with an analog-only scanner")
        Me.chkSkipMode.UseVisualStyleBackColor = False
        '
        'chkGPSDefault
        '
        Me.chkGPSDefault.AutoSize = True
        Me.chkGPSDefault.BackColor = System.Drawing.Color.Transparent
        Me.chkGPSDefault.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkGPSDefault.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGPSDefault.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGPSDefault.Location = New System.Drawing.Point(390, 126)
        Me.chkGPSDefault.Name = "chkGPSDefault"
        Me.chkGPSDefault.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGPSDefault.Size = New System.Drawing.Size(154, 18)
        Me.chkGPSDefault.TabIndex = 45
        Me.chkGPSDefault.Text = "Enable GPS use by default"
        Me.ToolTip1.SetToolTip(Me.chkGPSDefault, "Selecting this would set the ""GPS Enabled"" flag on all systems/groups to ON")
        Me.chkGPSDefault.UseVisualStyleBackColor = False
        '
        'StatusBar
        '
        Me.StatusBar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._StatusBar_Panel1})
        Me.StatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusBar.Location = New System.Drawing.Point(0, 508)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(611, 22)
        Me.StatusBar.TabIndex = 12
        '
        '_StatusBar_Panel1
        '
        Me._StatusBar_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar_Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar_Panel1.Name = "_StatusBar_Panel1"
        Me._StatusBar_Panel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me._StatusBar_Panel1.Size = New System.Drawing.Size(4, 22)
        Me._StatusBar_Panel1.Spring = True
        Me._StatusBar_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(349, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 61)
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'cmdViewBrowse
        '
        Me.cmdViewBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewBrowse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewBrowse.Location = New System.Drawing.Point(362, 472)
        Me.cmdViewBrowse.Name = "cmdViewBrowse"
        Me.cmdViewBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewBrowse.Size = New System.Drawing.Size(121, 25)
        Me.cmdViewBrowse.TabIndex = 37
        Me.cmdViewBrowse.Text = "View in &Browser..."
        Me.cmdViewBrowse.UseVisualStyleBackColor = True
        '
        'cmdSignUp
        '
        Me.cmdSignUp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSignUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSignUp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSignUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSignUp.Location = New System.Drawing.Point(199, 73)
        Me.cmdSignUp.Name = "cmdSignUp"
        Me.cmdSignUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSignUp.Size = New System.Drawing.Size(75, 21)
        Me.cmdSignUp.TabIndex = 23
        Me.cmdSignUp.Text = "S&ign Up"
        Me.cmdSignUp.UseVisualStyleBackColor = True
        '
        'cmdImport
        '
        Me.cmdImport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImport.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImport.Location = New System.Drawing.Point(487, 472)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImport.Size = New System.Drawing.Size(109, 25)
        Me.cmdImport.TabIndex = 21
        Me.cmdImport.Text = "&Import"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'txtSysName
        '
        Me.txtSysName.AcceptsReturn = True
        Me.txtSysName.BackColor = System.Drawing.SystemColors.Window
        Me.txtSysName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSysName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSysName.Location = New System.Drawing.Point(19, 476)
        Me.txtSysName.MaxLength = 16
        Me.txtSysName.Name = "txtSysName"
        Me.txtSysName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSysName.Size = New System.Drawing.Size(157, 20)
        Me.txtSysName.TabIndex = 19
        Me.txtSysName.Text = "txtSysName"
        '
        'tabImport
        '
        Me.tabImport.Controls.Add(Me._tabImport_TabPage0)
        Me.tabImport.Controls.Add(Me.TabPage10)
        Me.tabImport.Controls.Add(Me._tabImport_TabPage2)
        Me.tabImport.Controls.Add(Me.TabPage1)
        Me.tabImport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabImport.ItemSize = New System.Drawing.Size(42, 18)
        Me.tabImport.Location = New System.Drawing.Point(18, 203)
        Me.tabImport.Name = "tabImport"
        Me.tabImport.SelectedIndex = 0
        Me.tabImport.Size = New System.Drawing.Size(577, 254)
        Me.tabImport.TabIndex = 18
        '
        '_tabImport_TabPage0
        '
        Me._tabImport_TabPage0.Controls.Add(Me.cmdChkNone)
        Me._tabImport_TabPage0.Controls.Add(Me.cmdChkAll)
        Me._tabImport_TabPage0.Controls.Add(Me.lstGroup)
        Me._tabImport_TabPage0.Controls.Add(Me._cmdSiteChkAll_3)
        Me._tabImport_TabPage0.Controls.Add(Me._cmdSiteChkAll_2)
        Me._tabImport_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._tabImport_TabPage0.Name = "_tabImport_TabPage0"
        Me._tabImport_TabPage0.Size = New System.Drawing.Size(569, 228)
        Me._tabImport_TabPage0.TabIndex = 0
        Me._tabImport_TabPage0.Text = "Groups"
        Me._tabImport_TabPage0.UseVisualStyleBackColor = True
        '
        'cmdChkNone
        '
        Me.cmdChkNone.Location = New System.Drawing.Point(59, 190)
        Me.cmdChkNone.Name = "cmdChkNone"
        Me.cmdChkNone.Size = New System.Drawing.Size(50, 22)
        Me.cmdChkNone.TabIndex = 43
        Me.cmdChkNone.Text = "&None"
        Me.cmdChkNone.UseVisualStyleBackColor = True
        '
        'cmdChkAll
        '
        Me.cmdChkAll.Location = New System.Drawing.Point(3, 190)
        Me.cmdChkAll.Name = "cmdChkAll"
        Me.cmdChkAll.Size = New System.Drawing.Size(50, 22)
        Me.cmdChkAll.TabIndex = 42
        Me.cmdChkAll.Text = "&All"
        Me.cmdChkAll.UseVisualStyleBackColor = True
        '
        'lstGroup
        '
        Me.lstGroup.BackColor = System.Drawing.SystemColors.Window
        Me.lstGroup.CheckOnClick = True
        Me.lstGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstGroup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGroup.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstGroup.Location = New System.Drawing.Point(3, 0)
        Me.lstGroup.Name = "lstGroup"
        Me.lstGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstGroup.Size = New System.Drawing.Size(549, 184)
        Me.lstGroup.TabIndex = 24
        '
        '_cmdSiteChkAll_3
        '
        Me._cmdSiteChkAll_3.BackColor = System.Drawing.SystemColors.Control
        Me._cmdSiteChkAll_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdSiteChkAll_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdSiteChkAll_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSiteChkAll.SetIndex(Me._cmdSiteChkAll_3, CType(3, Short))
        Me._cmdSiteChkAll_3.Location = New System.Drawing.Point(60, 296)
        Me._cmdSiteChkAll_3.Name = "_cmdSiteChkAll_3"
        Me._cmdSiteChkAll_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdSiteChkAll_3.Size = New System.Drawing.Size(37, 17)
        Me._cmdSiteChkAll_3.TabIndex = 40
        Me._cmdSiteChkAll_3.Text = "&None"
        Me._cmdSiteChkAll_3.UseVisualStyleBackColor = False
        '
        '_cmdSiteChkAll_2
        '
        Me._cmdSiteChkAll_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdSiteChkAll_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdSiteChkAll_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdSiteChkAll_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSiteChkAll.SetIndex(Me._cmdSiteChkAll_2, CType(2, Short))
        Me._cmdSiteChkAll_2.Location = New System.Drawing.Point(16, 296)
        Me._cmdSiteChkAll_2.Name = "_cmdSiteChkAll_2"
        Me._cmdSiteChkAll_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdSiteChkAll_2.Size = New System.Drawing.Size(37, 17)
        Me._cmdSiteChkAll_2.TabIndex = 41
        Me._cmdSiteChkAll_2.Text = "A&ll"
        Me._cmdSiteChkAll_2.UseVisualStyleBackColor = False
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.lstTag)
        Me.TabPage10.Controls.Add(Label8)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(569, 228)
        Me.TabPage10.TabIndex = 4
        Me.TabPage10.Text = "My Skip Tags"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'lstTag
        '
        Me.lstTag.CheckOnClick = True
        Me.lstTag.FormattingEnabled = True
        Me.lstTag.Location = New System.Drawing.Point(6, 50)
        Me.lstTag.MultiColumn = True
        Me.lstTag.Name = "lstTag"
        Me.lstTag.Size = New System.Drawing.Size(546, 169)
        Me.lstTag.TabIndex = 4
        '
        '_tabImport_TabPage2
        '
        Me._tabImport_TabPage2.Controls.Add(Me.chkGPSDefault)
        Me._tabImport_TabPage2.Controls.Add(Me.chkSkipMode)
        Me._tabImport_TabPage2.Controls.Add(Me.cmdFindQK)
        Me._tabImport_TabPage2.Controls.Add(Me.cmbQK)
        Me._tabImport_TabPage2.Controls.Add(Me.radManQK)
        Me._tabImport_TabPage2.Controls.Add(Me.radAutoQK)
        Me._tabImport_TabPage2.Controls.Add(RadioButton4)
        Me._tabImport_TabPage2.Controls.Add(Me.cmbNumMisc)
        Me._tabImport_TabPage2.Controls.Add(Me.chkMiscGroup)
        Me._tabImport_TabPage2.Controls.Add(Me.chkSkipDig)
        Me._tabImport_TabPage2.Controls.Add(Me.chkDescComm)
        Me._tabImport_TabPage2.Controls.Add(Me.chkCompress)
        Me._tabImport_TabPage2.Controls.Add(Me.chkDisp)
        Me._tabImport_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._tabImport_TabPage2.Name = "_tabImport_TabPage2"
        Me._tabImport_TabPage2.Size = New System.Drawing.Size(569, 228)
        Me._tabImport_TabPage2.TabIndex = 2
        Me._tabImport_TabPage2.Text = "Options"
        Me._tabImport_TabPage2.UseVisualStyleBackColor = True
        '
        'cmdFindQK
        '
        Me.cmdFindQK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFindQK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindQK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFindQK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFindQK.Location = New System.Drawing.Point(486, 89)
        Me.cmdFindQK.Name = "cmdFindQK"
        Me.cmdFindQK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFindQK.Size = New System.Drawing.Size(60, 25)
        Me.cmdFindQK.TabIndex = 43
        Me.cmdFindQK.Text = "&Find Free"
        Me.cmdFindQK.UseVisualStyleBackColor = True
        '
        'cmbQK
        '
        Me.cmbQK.DropDownHeight = 200
        Me.cmbQK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQK.FormattingEnabled = True
        Me.cmbQK.IntegralHeight = False
        Me.cmbQK.Location = New System.Drawing.Point(420, 91)
        Me.cmbQK.Name = "cmbQK"
        Me.cmbQK.Size = New System.Drawing.Size(60, 22)
        Me.cmbQK.TabIndex = 42
        '
        'radManQK
        '
        Me.radManQK.AutoSize = True
        Me.radManQK.Location = New System.Drawing.Point(401, 67)
        Me.radManQK.Name = "radManQK"
        Me.radManQK.Size = New System.Drawing.Size(100, 18)
        Me.radManQK.TabIndex = 41
        Me.radManQK.Text = "Assign this QK:"
        Me.radManQK.UseVisualStyleBackColor = True
        '
        'radAutoQK
        '
        Me.radAutoQK.Location = New System.Drawing.Point(401, 26)
        Me.radAutoQK.Name = "radAutoQK"
        Me.radAutoQK.Size = New System.Drawing.Size(153, 40)
        Me.radAutoQK.TabIndex = 40
        Me.radAutoQK.Text = "Automatically find a free QK and assign it"
        Me.radAutoQK.UseVisualStyleBackColor = True
        '
        'cmbNumMisc
        '
        Me.cmbNumMisc.DropDownHeight = 200
        Me.cmbNumMisc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumMisc.FormattingEnabled = True
        Me.cmbNumMisc.IntegralHeight = False
        Me.cmbNumMisc.Location = New System.Drawing.Point(35, 185)
        Me.cmbNumMisc.Name = "cmbNumMisc"
        Me.cmbNumMisc.Size = New System.Drawing.Size(60, 22)
        Me.cmbNumMisc.TabIndex = 38
        '
        'chkDescComm
        '
        Me.chkDescComm.AutoSize = True
        Me.chkDescComm.BackColor = System.Drawing.Color.Transparent
        Me.chkDescComm.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDescComm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDescComm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDescComm.Location = New System.Drawing.Point(16, 68)
        Me.chkDescComm.Name = "chkDescComm"
        Me.chkDescComm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDescComm.Size = New System.Drawing.Size(369, 18)
        Me.chkDescComm.TabIndex = 33
        Me.chkDescComm.Text = "Store any channel name longer than 16 characters in the comment field"
        Me.chkDescComm.UseVisualStyleBackColor = False
        '
        'chkCompress
        '
        Me.chkCompress.BackColor = System.Drawing.Color.Transparent
        Me.chkCompress.Checked = True
        Me.chkCompress.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCompress.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCompress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCompress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCompress.Location = New System.Drawing.Point(16, 35)
        Me.chkCompress.Name = "chkCompress"
        Me.chkCompress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCompress.Size = New System.Drawing.Size(328, 35)
        Me.chkCompress.TabIndex = 32
        Me.chkCompress.Text = "If a channel name exceeds 16 characters, try to compress and abbreviate it automa" & _
    "tically"
        Me.chkCompress.UseVisualStyleBackColor = False
        '
        'chkDisp
        '
        Me.chkDisp.BackColor = System.Drawing.Color.Transparent
        Me.chkDisp.Checked = True
        Me.chkDisp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDisp.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDisp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDisp.Location = New System.Drawing.Point(16, 7)
        Me.chkDisp.Name = "chkDisp"
        Me.chkDisp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDisp.Size = New System.Drawing.Size(328, 33)
        Me.chkDisp.TabIndex = 31
        Me.chkDisp.Text = "If a display field is available (such as 2OPS44), use it in the channel name rath" & _
    "er than the channel description"
        Me.chkDisp.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtLog)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(569, 228)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Log"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(1, 3)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(564, 222)
        Me.txtLog.TabIndex = 0
        '
        'cmbCntAgency
        '
        Me.cmbCntAgency.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCntAgency.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCntAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCntAgency.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCntAgency.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCntAgency.Location = New System.Drawing.Point(395, 173)
        Me.cmbCntAgency.Name = "cmbCntAgency"
        Me.cmbCntAgency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCntAgency.Size = New System.Drawing.Size(193, 22)
        Me.cmbCntAgency.TabIndex = 16
        '
        'cmbCounty
        '
        Me.cmbCounty.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCounty.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCounty.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCounty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCounty.Location = New System.Drawing.Point(395, 117)
        Me.cmbCounty.Name = "cmbCounty"
        Me.cmbCounty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCounty.Size = New System.Drawing.Size(193, 22)
        Me.cmbCounty.TabIndex = 15
        '
        'cmbProvAgency
        '
        Me.cmbProvAgency.BackColor = System.Drawing.SystemColors.Window
        Me.cmbProvAgency.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbProvAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvAgency.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProvAgency.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProvAgency.Location = New System.Drawing.Point(187, 173)
        Me.cmbProvAgency.Name = "cmbProvAgency"
        Me.cmbProvAgency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbProvAgency.Size = New System.Drawing.Size(197, 22)
        Me.cmbProvAgency.TabIndex = 13
        '
        'cmbProvince
        '
        Me.cmbProvince.BackColor = System.Drawing.SystemColors.Window
        Me.cmbProvince.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvince.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProvince.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProvince.Location = New System.Drawing.Point(187, 117)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbProvince.Size = New System.Drawing.Size(197, 22)
        Me.cmbProvince.TabIndex = 10
        '
        'cmdConnect
        '
        Me.cmdConnect.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConnect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConnect.Location = New System.Drawing.Point(199, 50)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConnect.Size = New System.Drawing.Size(75, 21)
        Me.cmdConnect.TabIndex = 9
        Me.cmdConnect.Text = "&Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'cmbCountry
        '
        Me.cmbCountry.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCountry.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCountry.Location = New System.Drawing.Point(19, 117)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCountry.Size = New System.Drawing.Size(157, 22)
        Me.cmbCountry.TabIndex = 8
        '
        'chkSavepw
        '
        Me.chkSavepw.AutoSize = True
        Me.chkSavepw.BackColor = System.Drawing.SystemColors.Control
        Me.chkSavepw.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSavepw.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSavepw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSavepw.Location = New System.Drawing.Point(23, 75)
        Me.chkSavepw.Name = "chkSavepw"
        Me.chkSavepw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSavepw.Size = New System.Drawing.Size(94, 18)
        Me.chkSavepw.TabIndex = 5
        Me.chkSavepw.Text = "&Remember me"
        Me.chkSavepw.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.AcceptsReturn = True
        Me.txtpassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtpassword.Location = New System.Drawing.Point(113, 51)
        Me.txtpassword.MaxLength = 60
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpassword.Size = New System.Drawing.Size(82, 20)
        Me.txtpassword.TabIndex = 4
        '
        'txtUserName
        '
        Me.txtUserName.AcceptsReturn = True
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserName.Location = New System.Drawing.Point(24, 51)
        Me.txtUserName.MaxLength = 25
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserName.Size = New System.Drawing.Size(82, 20)
        Me.txtUserName.TabIndex = 3
        '
        '_lblCnt_4
        '
        Me._lblCnt_4.AutoSize = True
        Me._lblCnt_4.BackColor = System.Drawing.SystemColors.Control
        Me._lblCnt_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCnt_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCnt_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCnt.SetIndex(Me._lblCnt_4, CType(4, Short))
        Me._lblCnt_4.Location = New System.Drawing.Point(559, 157)
        Me._lblCnt_4.Name = "_lblCnt_4"
        Me._lblCnt_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCnt_4.Size = New System.Drawing.Size(33, 14)
        Me._lblCnt_4.TabIndex = 30
        Me._lblCnt_4.Text = "lblCnt"
        Me._lblCnt_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCnt_3
        '
        Me._lblCnt_3.AutoSize = True
        Me._lblCnt_3.BackColor = System.Drawing.SystemColors.Control
        Me._lblCnt_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCnt_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCnt_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCnt.SetIndex(Me._lblCnt_3, CType(3, Short))
        Me._lblCnt_3.Location = New System.Drawing.Point(355, 157)
        Me._lblCnt_3.Name = "_lblCnt_3"
        Me._lblCnt_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCnt_3.Size = New System.Drawing.Size(33, 14)
        Me._lblCnt_3.TabIndex = 29
        Me._lblCnt_3.Text = "lblCnt"
        Me._lblCnt_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCnt_2
        '
        Me._lblCnt_2.AutoSize = True
        Me._lblCnt_2.BackColor = System.Drawing.SystemColors.Control
        Me._lblCnt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCnt_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCnt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCnt.SetIndex(Me._lblCnt_2, CType(2, Short))
        Me._lblCnt_2.Location = New System.Drawing.Point(559, 101)
        Me._lblCnt_2.Name = "_lblCnt_2"
        Me._lblCnt_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCnt_2.Size = New System.Drawing.Size(33, 14)
        Me._lblCnt_2.TabIndex = 28
        Me._lblCnt_2.Text = "lblCnt"
        Me._lblCnt_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCnt_1
        '
        Me._lblCnt_1.AutoSize = True
        Me._lblCnt_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblCnt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCnt_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCnt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCnt.SetIndex(Me._lblCnt_1, CType(1, Short))
        Me._lblCnt_1.Location = New System.Drawing.Point(355, 101)
        Me._lblCnt_1.Name = "_lblCnt_1"
        Me._lblCnt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCnt_1.Size = New System.Drawing.Size(33, 14)
        Me._lblCnt_1.TabIndex = 27
        Me._lblCnt_1.Text = "lblCnt"
        Me._lblCnt_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCnt_0
        '
        Me._lblCnt_0.AutoSize = True
        Me._lblCnt_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblCnt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCnt_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCnt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCnt.SetIndex(Me._lblCnt_0, CType(0, Short))
        Me._lblCnt_0.Location = New System.Drawing.Point(147, 101)
        Me._lblCnt_0.Name = "_lblCnt_0"
        Me._lblCnt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCnt_0.Size = New System.Drawing.Size(33, 14)
        Me._lblCnt_0.TabIndex = 26
        Me._lblCnt_0.Text = "lblCnt"
        Me._lblCnt_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(19, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "System Name"
        '
        '_Label1_6
        '
        Me._Label1_6.AutoSize = True
        Me._Label1_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_6, CType(6, Short))
        Me._Label1_6.Location = New System.Drawing.Point(395, 157)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_6.Size = New System.Drawing.Size(92, 14)
        Me._Label1_6.TabIndex = 17
        Me._Label1_6.Text = "County Agencies:"
        '
        '_Label1_5
        '
        Me._Label1_5.AutoSize = True
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_5, CType(5, Short))
        Me._Label1_5.Location = New System.Drawing.Point(395, 101)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(44, 14)
        Me._Label1_5.TabIndex = 14
        Me._Label1_5.Text = "County:"
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = True
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
        Me._Label1_4.Location = New System.Drawing.Point(187, 157)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(132, 14)
        Me._Label1_4.TabIndex = 11
        Me._Label1_4.Text = "Provincial/State Agencies:"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
        Me._Label1_3.Location = New System.Drawing.Point(187, 101)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(80, 14)
        Me._Label1_3.TabIndex = 7
        Me._Label1_3.Text = "Province/State:"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(21, 98)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(45, 17)
        Me._Label1_2.TabIndex = 6
        Me._Label1_2.Text = "Country:"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(110, 31)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(59, 17)
        Me._Label1_1.TabIndex = 78
        Me._Label1_1.Text = "Password"
        '
        'cmdSiteChkAll
        '
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(611, 24)
        Me.MenuStrip2.TabIndex = 13
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.H1, Me.H2, Me.H3, Me.H4, Me.H5, Me.ClearAllHistoryToolStripMenuItem})
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.HistoryToolStripMenuItem.Text = "&History"
        '
        'H1
        '
        Me.H1.Name = "H1"
        Me.H1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.H1.Size = New System.Drawing.Size(168, 22)
        Me.H1.Text = "H1"
        Me.H1.Visible = False
        '
        'H2
        '
        Me.H2.Name = "H2"
        Me.H2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.H2.Size = New System.Drawing.Size(168, 22)
        Me.H2.Text = "H2"
        Me.H2.Visible = False
        '
        'H3
        '
        Me.H3.Name = "H3"
        Me.H3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.H3.Size = New System.Drawing.Size(168, 22)
        Me.H3.Text = "H3"
        Me.H3.Visible = False
        '
        'H4
        '
        Me.H4.Name = "H4"
        Me.H4.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.H4.Size = New System.Drawing.Size(168, 22)
        Me.H4.Text = "H4"
        Me.H4.Visible = False
        '
        'H5
        '
        Me.H5.Name = "H5"
        Me.H5.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.H5.Size = New System.Drawing.Size(168, 22)
        Me.H5.Text = "H5"
        Me.H5.Visible = False
        '
        'ClearAllHistoryToolStripMenuItem
        '
        Me.ClearAllHistoryToolStripMenuItem.Name = "ClearAllHistoryToolStripMenuItem"
        Me.ClearAllHistoryToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ClearAllHistoryToolStripMenuItem.Text = "Clear All History..."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblGrpSel)
        Me.TabPage2.Controls.Add(Me.cmdGroupChkNone)
        Me.TabPage2.Controls.Add(Me.cmdGroupChkAll)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.CheckedListBox1)
        Me.TabPage2.Controls.Add(Me.lstSite)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(560, 228)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Sites & Groups"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblGrpSel
        '
        Me.lblGrpSel.AutoSize = True
        Me.lblGrpSel.Location = New System.Drawing.Point(281, 197)
        Me.lblGrpSel.Name = "lblGrpSel"
        Me.lblGrpSel.Size = New System.Drawing.Size(139, 13)
        Me.lblGrpSel.TabIndex = 32
        Me.lblGrpSel.Text = "0 out of 20 groups selected."
        '
        'cmdGroupChkNone
        '
        Me.cmdGroupChkNone.Location = New System.Drawing.Point(502, 197)
        Me.cmdGroupChkNone.Name = "cmdGroupChkNone"
        Me.cmdGroupChkNone.Size = New System.Drawing.Size(50, 22)
        Me.cmdGroupChkNone.TabIndex = 31
        Me.cmdGroupChkNone.Text = "&None"
        Me.cmdGroupChkNone.UseVisualStyleBackColor = True
        '
        'cmdGroupChkAll
        '
        Me.cmdGroupChkAll.Location = New System.Drawing.Point(447, 197)
        Me.cmdGroupChkAll.Name = "cmdGroupChkAll"
        Me.cmdGroupChkAll.Size = New System.Drawing.Size(50, 22)
        Me.cmdGroupChkAll.TabIndex = 30
        Me.cmdGroupChkAll.Text = "&All"
        Me.cmdGroupChkAll.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 22)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "&None"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(153, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 22)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "&All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Window
        Me.CheckedListBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckedListBox1.Location = New System.Drawing.Point(277, 7)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckedListBox1.Size = New System.Drawing.Size(258, 184)
        Me.CheckedListBox1.TabIndex = 26
        '
        'lstSite
        '
        Me.lstSite.BackColor = System.Drawing.SystemColors.Window
        Me.lstSite.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstSite.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSite.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstSite.Location = New System.Drawing.Point(3, 6)
        Me.lstSite.Name = "lstSite"
        Me.lstSite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstSite.Size = New System.Drawing.Size(256, 184)
        Me.lstSite.TabIndex = 25
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkCtlOnly)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.cmdFindFree)
        Me.TabPage3.Controls.Add(cmbQKCantFind)
        Me.TabPage3.Controls.Add(Me.OptQK0)
        Me.TabPage3.Controls.Add(Me.OptQK2)
        Me.TabPage3.Controls.Add(Me.OptQK1)
        Me.TabPage3.Controls.Add(Me.chkSkipENc)
        Me.TabPage3.Controls.Add(Me.chkConCh)
        Me.TabPage3.Controls.Add(Me.CheckBox1)
        Me.TabPage3.Controls.Add(Me.CheckBox2)
        Me.TabPage3.Controls.Add(Me.CheckBox3)
        Me.TabPage3.Controls.Add(Me.CheckBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(560, 228)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Options"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkCtlOnly
        '
        Me.chkCtlOnly.BackColor = System.Drawing.Color.Transparent
        Me.chkCtlOnly.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCtlOnly.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCtlOnly.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCtlOnly.Location = New System.Drawing.Point(3, 98)
        Me.chkCtlOnly.Name = "chkCtlOnly"
        Me.chkCtlOnly.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCtlOnly.Size = New System.Drawing.Size(202, 17)
        Me.chkCtlOnly.TabIndex = 48
        Me.chkCtlOnly.Text = "Only download control channels"
        Me.chkCtlOnly.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Site Quickkeys:"
        '
        'cmdFindFree
        '
        Me.cmdFindFree.Location = New System.Drawing.Point(490, 84)
        Me.cmdFindFree.Name = "cmdFindFree"
        Me.cmdFindFree.Size = New System.Drawing.Size(61, 22)
        Me.cmdFindFree.TabIndex = 47
        Me.cmdFindFree.Text = "F&ind Free"
        Me.cmdFindFree.UseVisualStyleBackColor = True
        '
        'OptQK0
        '
        Me.OptQK0.AutoSize = True
        Me.OptQK0.Location = New System.Drawing.Point(305, 93)
        Me.OptQK0.Name = "OptQK0"
        Me.OptQK0.Size = New System.Drawing.Size(136, 17)
        Me.OptQK0.TabIndex = 45
        Me.OptQK0.TabStop = True
        Me.OptQK0.Text = "&Do not assign a site QK"
        Me.OptQK0.UseVisualStyleBackColor = True
        '
        'OptQK2
        '
        Me.OptQK2.AutoSize = True
        Me.OptQK2.Location = New System.Drawing.Point(305, 139)
        Me.OptQK2.Name = "OptQK2"
        Me.OptQK2.Size = New System.Drawing.Size(214, 17)
        Me.OptQK2.TabIndex = 44
        Me.OptQK2.TabStop = True
        Me.OptQK2.Text = "A&utomatically assign each site a free QK"
        Me.OptQK2.UseVisualStyleBackColor = True
        '
        'OptQK1
        '
        Me.OptQK1.AutoSize = True
        Me.OptQK1.Location = New System.Drawing.Point(305, 116)
        Me.OptQK1.Name = "OptQK1"
        Me.OptQK1.Size = New System.Drawing.Size(185, 17)
        Me.OptQK1.TabIndex = 43
        Me.OptQK1.TabStop = True
        Me.OptQK1.Text = "Assign &each site the following QK:"
        Me.OptQK1.UseVisualStyleBackColor = True
        '
        'chkSkipENc
        '
        Me.chkSkipENc.AutoSize = True
        Me.chkSkipENc.Location = New System.Drawing.Point(3, 144)
        Me.chkSkipENc.Name = "chkSkipENc"
        Me.chkSkipENc.Size = New System.Drawing.Size(195, 17)
        Me.chkSkipENc.TabIndex = 42
        Me.chkSkipENc.Text = "Skip channels marked as &encrypted"
        Me.chkSkipENc.UseVisualStyleBackColor = True
        '
        'chkConCh
        '
        Me.chkConCh.AutoSize = True
        Me.chkConCh.Location = New System.Drawing.Point(3, 75)
        Me.chkConCh.Name = "chkConCh"
        Me.chkConCh.Size = New System.Drawing.Size(229, 17)
        Me.chkConCh.TabIndex = 41
        Me.chkConCh.Text = "Enable control-chanel only mode by default"
        Me.chkConCh.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox1.Location = New System.Drawing.Point(3, 121)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox1.Size = New System.Drawing.Size(176, 17)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "Skip channels marked as &digital"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox2.Location = New System.Drawing.Point(3, 52)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox2.Size = New System.Drawing.Size(380, 17)
        Me.CheckBox2.TabIndex = 39
        Me.CheckBox2.Text = "Store any channel name longer than 16 characters in the comment field"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox3.Location = New System.Drawing.Point(3, 29)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox3.Size = New System.Drawing.Size(467, 17)
        Me.CheckBox3.TabIndex = 38
        Me.CheckBox3.Text = "If a channel name exceeds 16 characters, try to compress and abbreviate it automa" & _
    "tically"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox4.Location = New System.Drawing.Point(3, 6)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox4.Size = New System.Drawing.Size(530, 17)
        Me.CheckBox4.TabIndex = 37
        Me.CheckBox4.Text = "If a display field is available (e.g. 2OPS44), use it in the channel name rather " & _
    "than the channel description"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Label4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(560, 228)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "My Skip Tags"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TextBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(560, 228)
        Me.TabPage5.TabIndex = 3
        Me.TabPage5.Text = "Log"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(554, 223)
        Me.TextBox1.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label5)
        Me.TabPage6.Controls.Add(Me.Button3)
        Me.TabPage6.Controls.Add(Me.Button4)
        Me.TabPage6.Controls.Add(Me.Button5)
        Me.TabPage6.Controls.Add(Me.Button6)
        Me.TabPage6.Controls.Add(Me.CheckedListBox2)
        Me.TabPage6.Controls.Add(Me.CheckedListBox3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(560, 228)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Sites & Groups"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "0 out of 20 groups selected."
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(502, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 22)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "&None"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(447, 197)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 22)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "&All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(209, 198)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 22)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "&None"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(153, 198)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 22)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "&All"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.BackColor = System.Drawing.SystemColors.Window
        Me.CheckedListBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBox2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckedListBox2.Location = New System.Drawing.Point(277, 7)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckedListBox2.Size = New System.Drawing.Size(258, 184)
        Me.CheckedListBox2.TabIndex = 26
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.BackColor = System.Drawing.SystemColors.Window
        Me.CheckedListBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBox3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckedListBox3.Location = New System.Drawing.Point(3, 6)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckedListBox3.Size = New System.Drawing.Size(256, 184)
        Me.CheckedListBox3.TabIndex = 25
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.CheckBox5)
        Me.TabPage7.Controls.Add(Me.Label6)
        Me.TabPage7.Controls.Add(Me.Button7)
        Me.TabPage7.Controls.Add(Me.ComboBox1)
        Me.TabPage7.Controls.Add(Me.RadioButton1)
        Me.TabPage7.Controls.Add(Me.RadioButton2)
        Me.TabPage7.Controls.Add(Me.RadioButton3)
        Me.TabPage7.Controls.Add(Me.CheckBox6)
        Me.TabPage7.Controls.Add(Me.CheckBox7)
        Me.TabPage7.Controls.Add(Me.CheckBox8)
        Me.TabPage7.Controls.Add(Me.CheckBox9)
        Me.TabPage7.Controls.Add(Me.CheckBox10)
        Me.TabPage7.Controls.Add(Me.CheckBox11)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(560, 228)
        Me.TabPage7.TabIndex = 2
        Me.TabPage7.Text = "Options"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox5.Location = New System.Drawing.Point(3, 98)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox5.Size = New System.Drawing.Size(202, 17)
        Me.CheckBox5.TabIndex = 48
        Me.CheckBox5.Text = "Only download control channels"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Site Quickkeys:"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(490, 84)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(61, 22)
        Me.Button7.TabIndex = 47
        Me.Button7.Text = "F&ind Free"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(496, 112)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(55, 21)
        Me.ComboBox1.TabIndex = 46
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(305, 93)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(136, 17)
        Me.RadioButton1.TabIndex = 45
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "&Do not assign a site QK"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(305, 139)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(214, 17)
        Me.RadioButton2.TabIndex = 44
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "A&utomatically assign each site a free QK"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(305, 116)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(185, 17)
        Me.RadioButton3.TabIndex = 43
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Assign &each site the following QK:"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(3, 144)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(195, 17)
        Me.CheckBox6.TabIndex = 42
        Me.CheckBox6.Text = "Skip channels marked as &encrypted"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(3, 75)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(229, 17)
        Me.CheckBox7.TabIndex = 41
        Me.CheckBox7.Text = "Enable control-chanel only mode by default"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox8.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox8.Location = New System.Drawing.Point(3, 121)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox8.Size = New System.Drawing.Size(176, 17)
        Me.CheckBox8.TabIndex = 40
        Me.CheckBox8.Text = "Skip channels marked as &digital"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox9.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox9.Location = New System.Drawing.Point(3, 52)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox9.Size = New System.Drawing.Size(380, 17)
        Me.CheckBox9.TabIndex = 39
        Me.CheckBox9.Text = "Store any channel name longer than 16 characters in the comment field"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox10.Checked = True
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox10.Location = New System.Drawing.Point(3, 29)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox10.Size = New System.Drawing.Size(467, 17)
        Me.CheckBox10.TabIndex = 38
        Me.CheckBox10.Text = "If a channel name exceeds 16 characters, try to compress and abbreviate it automa" & _
    "tically"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox11.Checked = True
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox11.Location = New System.Drawing.Point(3, 6)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox11.Size = New System.Drawing.Size(530, 17)
        Me.CheckBox11.TabIndex = 37
        Me.CheckBox11.Text = "If a display field is available (e.g. 2OPS44), use it in the channel name rather " & _
    "than the channel description"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.CheckedListBox4)
        Me.TabPage8.Controls.Add(Label7)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(560, 228)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "My Skip Tags"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'CheckedListBox4
        '
        Me.CheckedListBox4.FormattingEnabled = True
        Me.CheckedListBox4.Location = New System.Drawing.Point(6, 50)
        Me.CheckedListBox4.MultiColumn = True
        Me.CheckedListBox4.Name = "CheckedListBox4"
        Me.CheckedListBox4.Size = New System.Drawing.Size(546, 154)
        Me.CheckedListBox4.TabIndex = 2
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.TextBox2)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(560, 228)
        Me.TabPage9.TabIndex = 3
        Me.TabPage9.Text = "Log"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 5)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(554, 223)
        Me.TextBox2.TabIndex = 1
        '
        'frmRRCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(611, 530)
        Me.Controls.Add(Me.cmdViewBrowse)
        Me.Controls.Add(Me.cmdImport)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.txtSysName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.tabImport)
        Me.Controls.Add(Me.cmdSaveHome)
        Me.Controls.Add(Me.cmdJumpHome)
        Me.Controls.Add(Me.chkSavepw)
        Me.Controls.Add(_Label1_0)
        Me.Controls.Add(Me.cmdAmerica)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me.cmdCanada)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me.cmdSignUp)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me._lblCnt_0)
        Me.Controls.Add(Me.cmbCntAgency)
        Me.Controls.Add(Me._lblCnt_1)
        Me.Controls.Add(Me.cmbCounty)
        Me.Controls.Add(Me._lblCnt_2)
        Me.Controls.Add(Me.cmbProvAgency)
        Me.Controls.Add(Me._lblCnt_3)
        Me.Controls.Add(Me.cmbProvince)
        Me.Controls.Add(Me._lblCnt_4)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.cmbCountry)
        Me.Controls.Add(Me.txtpassword)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRRCon"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RadioReference Import - Conventional System"
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImport.ResumeLayout(False)
        Me._tabImport_TabPage0.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me._tabImport_TabPage2.ResumeLayout(False)
        Me._tabImport_TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSiteChkAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents _Label1_1 As System.Windows.Forms.Label
    Friend WithEvents cmdChkNone As System.Windows.Forms.Button
    Friend WithEvents cmdChkAll As System.Windows.Forms.Button
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblGrpSel As System.Windows.Forms.Label
    Friend WithEvents cmdGroupChkNone As System.Windows.Forms.Button
    Friend WithEvents cmdGroupChkAll As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Public WithEvents lstSite As System.Windows.Forms.CheckedListBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents chkCtlOnly As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdFindFree As System.Windows.Forms.Button
    Friend WithEvents OptQK0 As System.Windows.Forms.RadioButton
    Friend WithEvents OptQK2 As System.Windows.Forms.RadioButton
    Friend WithEvents OptQK1 As System.Windows.Forms.RadioButton
    Friend WithEvents chkSkipENc As System.Windows.Forms.CheckBox
    Friend WithEvents chkConCh As System.Windows.Forms.CheckBox
    Public WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Public WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Public WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Public WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Public WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
    Public WithEvents CheckedListBox3 As System.Windows.Forms.CheckedListBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Public WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Public WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Public WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Public WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Public WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents CheckedListBox4 As System.Windows.Forms.CheckedListBox
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lstTag As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmbNumMisc As System.Windows.Forms.ComboBox
    Public WithEvents chkMiscGroup As System.Windows.Forms.CheckBox
    Friend WithEvents cmbQK As System.Windows.Forms.ComboBox
    Friend WithEvents radManQK As System.Windows.Forms.RadioButton
    Friend WithEvents radAutoQK As System.Windows.Forms.RadioButton
    Public WithEvents cmdFindQK As System.Windows.Forms.Button
    Public WithEvents chkSkipMode As System.Windows.Forms.CheckBox
    Public WithEvents chkGPSDefault As System.Windows.Forms.CheckBox
#End Region
End Class