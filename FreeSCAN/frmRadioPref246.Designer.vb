<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRadioPref246
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		Form_Initialize_renamed()
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents cmdApply As System.Windows.Forms.Button
    Public WithEvents Frame22 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label17 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label42 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label45 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label46 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label47 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Line1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Line2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents chkBSC As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents chkCCBand As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents chkPref As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents chkWX As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents cmbAGC As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents cmbSearchKey As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
    Public WithEvents optAlertMode As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optBackLight1 As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optCCMode As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optGPSDispMode As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optPriMode As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents txtBBS As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents txtWX As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label53 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label33 As System.Windows.Forms.Label
        Dim Label44 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label52 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label34 As System.Windows.Forms.Label
        Dim Label48 As System.Windows.Forms.Label
        Dim Label51 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim Label32 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRadioPref246))
        Dim Label31 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Label54 As System.Windows.Forms.Label
        Me.chkUnitID = New System.Windows.Forms.CheckBox()
        Me.PriIntTime = New System.Windows.Forms.ComboBox()
        Me.MaxPriChan = New System.Windows.Forms.ComboBox()
        Me.cmbBatChg = New System.Windows.Forms.ComboBox()
        Me.chkXTGlobalAtt = New System.Windows.Forms.CheckBox()
        Me.optXTChanLog2 = New System.Windows.Forms.RadioButton()
        Me.optXTChanLog1 = New System.Windows.Forms.RadioButton()
        Me.optXTChanLog0 = New System.Windows.Forms.RadioButton()
        Me.chkXTP25LP = New System.Windows.Forms.CheckBox()
        Me.chkXTKeySafe = New System.Windows.Forms.CheckBox()
        Me.chkXTKeyLock = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAnalogAGC = New System.Windows.Forms.CheckBox()
        Me.chkDigitalAGC = New System.Windows.Forms.CheckBox()
        Me.chkCloseCallOverride = New System.Windows.Forms.CheckBox()
        Me.chkCCHits = New System.Windows.Forms.CheckBox()
        Me.optCCCodeSearch2 = New System.Windows.Forms.RadioButton()
        Me.chkLCDFlip = New System.Windows.Forms.CheckBox()
        Me.chkActChanDisp = New System.Windows.Forms.CheckBox()
        Me.optMode1 = New System.Windows.Forms.RadioButton()
        Me.optMode2 = New System.Windows.Forms.RadioButton()
        Me.OptMode3 = New System.Windows.Forms.RadioButton()
        Me._optPriMode_1 = New System.Windows.Forms.RadioButton()
        Me._optPriMode_2 = New System.Windows.Forms.RadioButton()
        Me.chkBatSave = New System.Windows.Forms.CheckBox()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.Frame22 = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label17 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label42 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label45 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label46 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label47 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Line1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Line2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.chkBSC = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.chkCCBand = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.chkPref = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.chkWX = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.cmbAGC = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.cmbSearchKey = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.optAlertMode = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optBackLight1 = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optCCMode = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optGPSDispMode = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optPriMode = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.txtBBS = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.txtWX = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me._optDispMode_TabPage9 = New System.Windows.Forms.TabPage()
        Me._Frame22_1 = New System.Windows.Forms.GroupBox()
        Me.cmbP25Wait = New System.Windows.Forms.ComboBox()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me._Label1_9 = New System.Windows.Forms.Label()
        Me._Frame22_0 = New System.Windows.Forms.GroupBox()
        Me._cmbAGC_5 = New System.Windows.Forms.ComboBox()
        Me._cmbAGC_4 = New System.Windows.Forms.ComboBox()
        Me._cmbAGC_3 = New System.Windows.Forms.ComboBox()
        Me._cmbAGC_2 = New System.Windows.Forms.ComboBox()
        Me._cmbAGC_1 = New System.Windows.Forms.ComboBox()
        Me._cmbAGC_0 = New System.Windows.Forms.ComboBox()
        Me._Label1_4 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.Frame16 = New System.Windows.Forms.GroupBox()
        Me.Frame17 = New System.Windows.Forms.Panel()
        Me._optGPSDispMode_0 = New System.Windows.Forms.RadioButton()
        Me._optGPSDispMode_1 = New System.Windows.Forms.RadioButton()
        Me._optGPSDispMode_2 = New System.Windows.Forms.RadioButton()
        Me._optGPSDispMode_3 = New System.Windows.Forms.RadioButton()
        Me._optGPSDispMode_4 = New System.Windows.Forms.RadioButton()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.chkGPSKM = New System.Windows.Forms.CheckBox()
        Me.chkGPSTimeFormat = New System.Windows.Forms.CheckBox()
        Me.chkGPSDMS = New System.Windows.Forms.CheckBox()
        Me.cmbGPSTimeZone = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me._optDispMode_TabPage8 = New System.Windows.Forms.TabPage()
        Me.grdToneOut = New System.Windows.Forms.DataGridView()
        Me.txtTonName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTonFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTonLowLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtToneHiLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbTonDelay = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbTonMod = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbTonAltTone = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbTonAltToneLevel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbTonAlertColor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbAlertFlash = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbToneAtt = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmbTonAGC = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmbTonRecOut = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me._optDispMode_TabPage7 = New System.Windows.Forms.TabPage()
        Me.Frame15 = New System.Windows.Forms.GroupBox()
        Me.Frame20 = New System.Windows.Forms.GroupBox()
        Me.cmdUSCodes = New System.Windows.Forms.Button()
        Me.cmdCanuckKodes = New System.Windows.Forms.Button()
        Me.cmdResetWX = New System.Windows.Forms.Button()
        Me._txtWX_44 = New System.Windows.Forms.TextBox()
        Me._txtWX_43 = New System.Windows.Forms.TextBox()
        Me._txtWX_42 = New System.Windows.Forms.TextBox()
        Me._txtWX_41 = New System.Windows.Forms.TextBox()
        Me._txtWX_40 = New System.Windows.Forms.TextBox()
        Me._txtWX_39 = New System.Windows.Forms.TextBox()
        Me._txtWX_38 = New System.Windows.Forms.TextBox()
        Me._txtWX_37 = New System.Windows.Forms.TextBox()
        Me._txtWX_36 = New System.Windows.Forms.TextBox()
        Me._txtWX_35 = New System.Windows.Forms.TextBox()
        Me._txtWX_34 = New System.Windows.Forms.TextBox()
        Me._txtWX_33 = New System.Windows.Forms.TextBox()
        Me._txtWX_32 = New System.Windows.Forms.TextBox()
        Me._txtWX_31 = New System.Windows.Forms.TextBox()
        Me._txtWX_30 = New System.Windows.Forms.TextBox()
        Me._txtWX_29 = New System.Windows.Forms.TextBox()
        Me._txtWX_28 = New System.Windows.Forms.TextBox()
        Me._txtWX_27 = New System.Windows.Forms.TextBox()
        Me._txtWX_26 = New System.Windows.Forms.TextBox()
        Me._txtWX_25 = New System.Windows.Forms.TextBox()
        Me._txtWX_24 = New System.Windows.Forms.TextBox()
        Me._txtWX_23 = New System.Windows.Forms.TextBox()
        Me._txtWX_22 = New System.Windows.Forms.TextBox()
        Me._txtWX_21 = New System.Windows.Forms.TextBox()
        Me._txtWX_20 = New System.Windows.Forms.TextBox()
        Me._txtWX_19 = New System.Windows.Forms.TextBox()
        Me._txtWX_18 = New System.Windows.Forms.TextBox()
        Me._txtWX_17 = New System.Windows.Forms.TextBox()
        Me._txtWX_16 = New System.Windows.Forms.TextBox()
        Me._txtWX_15 = New System.Windows.Forms.TextBox()
        Me._txtWX_14 = New System.Windows.Forms.TextBox()
        Me._txtWX_13 = New System.Windows.Forms.TextBox()
        Me._txtWX_12 = New System.Windows.Forms.TextBox()
        Me._txtWX_11 = New System.Windows.Forms.TextBox()
        Me._txtWX_10 = New System.Windows.Forms.TextBox()
        Me._txtWX_9 = New System.Windows.Forms.TextBox()
        Me._txtWX_8 = New System.Windows.Forms.TextBox()
        Me._txtWX_7 = New System.Windows.Forms.TextBox()
        Me._txtWX_6 = New System.Windows.Forms.TextBox()
        Me._txtWX_5 = New System.Windows.Forms.TextBox()
        Me._txtWX_4 = New System.Windows.Forms.TextBox()
        Me._txtWX_3 = New System.Windows.Forms.TextBox()
        Me._txtWX_2 = New System.Windows.Forms.TextBox()
        Me._txtWX_1 = New System.Windows.Forms.TextBox()
        Me._txtWX_0 = New System.Windows.Forms.TextBox()
        Me.cmbWXDelay = New System.Windows.Forms.ComboBox()
        Me._chkWX_2 = New System.Windows.Forms.CheckBox()
        Me._chkWX_1 = New System.Windows.Forms.CheckBox()
        Me._chkWX_0 = New System.Windows.Forms.CheckBox()
        Me._Label47_4 = New System.Windows.Forms.Label()
        Me._Label47_3 = New System.Windows.Forms.Label()
        Me._Label47_2 = New System.Windows.Forms.Label()
        Me._Label47_1 = New System.Windows.Forms.Label()
        Me._Label47_0 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Delay = New System.Windows.Forms.Label()
        Me._optDispMode_TabPage6 = New System.Windows.Forms.TabPage()
        Me.Frame18 = New System.Windows.Forms.GroupBox()
        Me._chkBSC_6 = New System.Windows.Forms.CheckBox()
        Me._chkBSC_7 = New System.Windows.Forms.CheckBox()
        Me._txtBBS_19 = New System.Windows.Forms.TextBox()
        Me._chkBSC_8 = New System.Windows.Forms.CheckBox()
        Me._txtBBS_18 = New System.Windows.Forms.TextBox()
        Me._chkBSC_9 = New System.Windows.Forms.CheckBox()
        Me._txtBBS_17 = New System.Windows.Forms.TextBox()
        Me._chkBSC_10 = New System.Windows.Forms.CheckBox()
        Me._txtBBS_16 = New System.Windows.Forms.TextBox()
        Me._chkBSC_11 = New System.Windows.Forms.CheckBox()
        Me._txtBBS_15 = New System.Windows.Forms.TextBox()
        Me._chkBSC_12 = New System.Windows.Forms.CheckBox()
        Me._txtBBS_14 = New System.Windows.Forms.TextBox()
        Me._chkBSC_13 = New System.Windows.Forms.CheckBox()
        Me._txtBBS_13 = New System.Windows.Forms.TextBox()
        Me._chkBSC_14 = New System.Windows.Forms.CheckBox()
        Me._txtBBS_12 = New System.Windows.Forms.TextBox()
        Me._chkBSC_15 = New System.Windows.Forms.CheckBox()
        Me._txtBBS_11 = New System.Windows.Forms.TextBox()
        Me._txtBBS_10 = New System.Windows.Forms.TextBox()
        Me._txtBBS_9 = New System.Windows.Forms.TextBox()
        Me._txtBBS_8 = New System.Windows.Forms.TextBox()
        Me._txtBBS_7 = New System.Windows.Forms.TextBox()
        Me._txtBBS_6 = New System.Windows.Forms.TextBox()
        Me._txtBBS_5 = New System.Windows.Forms.TextBox()
        Me._txtBBS_4 = New System.Windows.Forms.TextBox()
        Me._txtBBS_3 = New System.Windows.Forms.TextBox()
        Me._txtBBS_2 = New System.Windows.Forms.TextBox()
        Me._txtBBS_1 = New System.Windows.Forms.TextBox()
        Me._txtBBS_0 = New System.Windows.Forms.TextBox()
        Me._Label42_9 = New System.Windows.Forms.Label()
        Me._Label42_8 = New System.Windows.Forms.Label()
        Me._Label42_7 = New System.Windows.Forms.Label()
        Me._Label42_6 = New System.Windows.Forms.Label()
        Me._Label42_5 = New System.Windows.Forms.Label()
        Me._Label42_4 = New System.Windows.Forms.Label()
        Me._Label42_3 = New System.Windows.Forms.Label()
        Me._Label42_2 = New System.Windows.Forms.Label()
        Me._Label42_1 = New System.Windows.Forms.Label()
        Me._Label42_0 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me._optDispMode_TabPage5 = New System.Windows.Forms.TabPage()
        Me.Frame14 = New System.Windows.Forms.GroupBox()
        Me._chkBSC_5 = New System.Windows.Forms.CheckBox()
        Me._chkBSC_0 = New System.Windows.Forms.CheckBox()
        Me._chkBSC_1 = New System.Windows.Forms.CheckBox()
        Me._chkBSC_2 = New System.Windows.Forms.CheckBox()
        Me._chkBSC_3 = New System.Windows.Forms.CheckBox()
        Me._chkBSC_4 = New System.Windows.Forms.CheckBox()
        Me.cmbSSHold = New System.Windows.Forms.ComboBox()
        Me.cmbSSModMode = New System.Windows.Forms.ComboBox()
        Me.cmbSSStep = New System.Windows.Forms.ComboBox()
        Me.chkCCTapeOut = New System.Windows.Forms.CheckBox()
        Me.cmbMaxAutoStore = New System.Windows.Forms.ComboBox()
        Me.chkSSRepeater = New System.Windows.Forms.CheckBox()
        Me.chkSSDataSkip = New System.Windows.Forms.CheckBox()
        Me.cmbSSAtt = New System.Windows.Forms.CheckBox()
        Me.cmbSSDelay = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me._optDispMode_TabPage4 = New System.Windows.Forms.TabPage()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.cmbSSHoldTime = New System.Windows.Forms.ComboBox()
        Me.cmbSSsystem = New System.Windows.Forms.ComboBox()
        Me.cmbSSDelayTime = New System.Windows.Forms.ComboBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.txtSSPNumTag = New System.Windows.Forms.TextBox()
        Me.cmbSSPP25Wait = New System.Windows.Forms.ComboBox()
        Me.chkSSPDigitalAGC = New System.Windows.Forms.CheckBox()
        Me.chkSSPAnalogAGC = New System.Windows.Forms.CheckBox()
        Me.cmbSSStartupKey = New System.Windows.Forms.ComboBox()
        Me.cmbSSQuickKey = New System.Windows.Forms.ComboBox()
        Me.chkSSTapeOut = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkSSAtt = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkSrchLO = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me._cmbSearchKey_5 = New System.Windows.Forms.ComboBox()
        Me._cmbSearchKey_4 = New System.Windows.Forms.ComboBox()
        Me._cmbSearchKey_3 = New System.Windows.Forms.ComboBox()
        Me._cmbSearchKey_2 = New System.Windows.Forms.ComboBox()
        Me._cmbSearchKey_1 = New System.Windows.Forms.ComboBox()
        Me._cmbSearchKey_0 = New System.Windows.Forms.ComboBox()
        Me._Label17_6 = New System.Windows.Forms.Label()
        Me._Label17_5 = New System.Windows.Forms.Label()
        Me._Label17_4 = New System.Windows.Forms.Label()
        Me._Label17_3 = New System.Windows.Forms.Label()
        Me._Label17_2 = New System.Windows.Forms.Label()
        Me._Label17_0 = New System.Windows.Forms.Label()
        Me._optDispMode_TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdGIF = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdClearGIF = New System.Windows.Forms.Button()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.grdFreqLO = New System.Windows.Forms.DataGridView()
        Me.txtFreqLO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdClearLOFreq = New System.Windows.Forms.Button()
        Me.cmdClearLOFreqDup = New System.Windows.Forms.Button()
        Me._optDispMode_TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.grdCust = New System.Windows.Forms.DataGridView()
        Me.grdCustName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdCustLowLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdCustHiLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdCustDelay = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdCustLO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdCustEnabled = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdCustHoldTime = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdCustSS = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdCustAtt = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdCustDataSkip = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdCustCtlChn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdCustQK = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdCustStartupKey = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdCustModulation = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdCustNumTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdCustAGCA = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdCustAGCD = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdCustP25Wait = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdCustTapeOut = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmdCSDefault = New System.Windows.Forms.Button()
        Me._optDispMode_TabPage1 = New System.Windows.Forms.TabPage()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Frame12 = New System.Windows.Forms.GroupBox()
        Me.optCCCodeSearch1 = New System.Windows.Forms.RadioButton()
        Me.optCCCodeSearch0 = New System.Windows.Forms.RadioButton()
        Me.chkCCAGCD = New System.Windows.Forms.CheckBox()
        Me.chkCCAGCA = New System.Windows.Forms.CheckBox()
        Me.cmbCCPauseTime = New System.Windows.Forms.ComboBox()
        Me.cmbCCQuickKey = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Frame11 = New System.Windows.Forms.GroupBox()
        Me.cmbCCAltCol = New System.Windows.Forms.ComboBox()
        Me.cmbCCAltPat = New System.Windows.Forms.ComboBox()
        Me.sldCCVol = New System.Windows.Forms.TrackBar()
        Me._optAlertMode_0 = New System.Windows.Forms.RadioButton()
        Me._optAlertMode_1 = New System.Windows.Forms.RadioButton()
        Me._optAlertMode_2 = New System.Windows.Forms.RadioButton()
        Me._optAlertMode_3 = New System.Windows.Forms.RadioButton()
        Me.cmbCloseCallAlertType = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame10 = New System.Windows.Forms.GroupBox()
        Me._optCCMode_2 = New System.Windows.Forms.RadioButton()
        Me._optCCMode_1 = New System.Windows.Forms.RadioButton()
        Me._optCCMode_0 = New System.Windows.Forms.RadioButton()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me._chkCCBand_6 = New System.Windows.Forms.CheckBox()
        Me._chkCCBand_5 = New System.Windows.Forms.CheckBox()
        Me._chkCCBand_4 = New System.Windows.Forms.CheckBox()
        Me._chkCCBand_3 = New System.Windows.Forms.CheckBox()
        Me._chkCCBand_2 = New System.Windows.Forms.CheckBox()
        Me._chkCCBand_1 = New System.Windows.Forms.CheckBox()
        Me._chkCCBand_0 = New System.Windows.Forms.CheckBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me._optDispMode_TabPage0 = New System.Windows.Forms.TabPage()
        Me.fraBackLight = New System.Windows.Forms.GroupBox()
        Me._optBackLight1_5 = New System.Windows.Forms.RadioButton()
        Me._optBackLight1_4 = New System.Windows.Forms.RadioButton()
        Me._optBackLight1_3 = New System.Windows.Forms.RadioButton()
        Me._optBackLight1_2 = New System.Windows.Forms.RadioButton()
        Me._optBackLight1_1 = New System.Windows.Forms.RadioButton()
        Me._optBackLight1_0 = New System.Windows.Forms.RadioButton()
        Me.frmGeneral = New System.Windows.Forms.GroupBox()
        Me._optPriMode_0 = New System.Windows.Forms.RadioButton()
        Me.sldKeyBeep = New System.Windows.Forms.TrackBar()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtStartupMsg1 = New System.Windows.Forms.TextBox()
        Me.txtStartUpMsg2 = New System.Windows.Forms.TextBox()
        Me.txtStartUpMsg4 = New System.Windows.Forms.TextBox()
        Me.txtStartUpMsg3 = New System.Windows.Forms.TextBox()
        Me.cmdBlank = New System.Windows.Forms.Button()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.optBacklightWhite = New System.Windows.Forms.RadioButton()
        Me.optBacklightYellow = New System.Windows.Forms.RadioButton()
        Me.optBacklightMagenta = New System.Windows.Forms.RadioButton()
        Me.optBacklightBlue = New System.Windows.Forms.RadioButton()
        Me.optBacklightCyan = New System.Windows.Forms.RadioButton()
        Me.optBacklightRed = New System.Windows.Forms.RadioButton()
        Me.optBacklightGreen = New System.Windows.Forms.RadioButton()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.sldLCDContrast = New System.Windows.Forms.TrackBar()
        Me.Frame21 = New System.Windows.Forms.GroupBox()
        Me.sldXTBright = New System.Windows.Forms.TrackBar()
        Me._optBackLight1_10 = New System.Windows.Forms.RadioButton()
        Me._optBackLight1_9 = New System.Windows.Forms.RadioButton()
        Me._optBackLight1_8 = New System.Windows.Forms.RadioButton()
        Me._optBackLight1_7 = New System.Windows.Forms.RadioButton()
        Me._optBackLight1_6 = New System.Windows.Forms.RadioButton()
        Me.optDispMode = New System.Windows.Forms.TabControl()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Label53 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label33 = New System.Windows.Forms.Label()
        Label44 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label52 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label34 = New System.Windows.Forms.Label()
        Label48 = New System.Windows.Forms.Label()
        Label51 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        Label32 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label54 = New System.Windows.Forms.Label()
        GroupBox1.SuspendLayout()
        CType(Me.Frame22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBSC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCCBand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkWX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAGC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSearchKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optAlertMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optBackLight1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optCCMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optGPSDispMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optPriMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._optDispMode_TabPage9.SuspendLayout()
        Me._Frame22_1.SuspendLayout()
        Me._Frame22_0.SuspendLayout()
        Me.Frame16.SuspendLayout()
        Me.Frame17.SuspendLayout()
        Me._optDispMode_TabPage8.SuspendLayout()
        CType(Me.grdToneOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._optDispMode_TabPage7.SuspendLayout()
        Me.Frame15.SuspendLayout()
        Me.Frame20.SuspendLayout()
        Me._optDispMode_TabPage6.SuspendLayout()
        Me.Frame18.SuspendLayout()
        Me._optDispMode_TabPage5.SuspendLayout()
        Me.Frame14.SuspendLayout()
        Me._optDispMode_TabPage4.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me._optDispMode_TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdGIF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame7.SuspendLayout()
        CType(Me.grdFreqLO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._optDispMode_TabPage2.SuspendLayout()
        CType(Me.grdCust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._optDispMode_TabPage1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame12.SuspendLayout()
        Me.Frame11.SuspendLayout()
        CType(Me.sldCCVol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame10.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me._optDispMode_TabPage0.SuspendLayout()
        Me.fraBackLight.SuspendLayout()
        Me.frmGeneral.SuspendLayout()
        CType(Me.sldKeyBeep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame6.SuspendLayout()
        CType(Me.sldLCDContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame21.SuspendLayout()
        CType(Me.sldXTBright, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.optDispMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label53
        '
        Label53.AutoSize = True
        Label53.Location = New System.Drawing.Point(4, 245)
        Label53.Name = "Label53"
        Label53.Size = New System.Drawing.Size(239, 14)
        Label53.TabIndex = 133
        Label53.Text = "Search keys 4-6 are valid for the BCD996T only."
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.BackColor = System.Drawing.SystemColors.Control
        Label22.Cursor = System.Windows.Forms.Cursors.Default
        Label22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Label22.Location = New System.Drawing.Point(10, 103)
        Label22.Name = "Label22"
        Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label22.Size = New System.Drawing.Size(56, 14)
        Label22.TabIndex = 138
        Label22.Text = "Quick Key"
        '
        'Label33
        '
        Label33.AutoSize = True
        Label33.BackColor = System.Drawing.SystemColors.Control
        Label33.Cursor = System.Windows.Forms.Cursors.Default
        Label33.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Label33.Location = New System.Drawing.Point(125, 20)
        Label33.Name = "Label33"
        Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label33.Size = New System.Drawing.Size(64, 14)
        Label33.TabIndex = 139
        Label33.Text = "Number Tag"
        Me.ToolTip1.SetToolTip(Label33, "Enter 1-999 or NONE")
        '
        'Label44
        '
        Label44.AutoSize = True
        Label44.BackColor = System.Drawing.SystemColors.Control
        Label44.Cursor = System.Windows.Forms.Cursors.Default
        Label44.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Label44.Location = New System.Drawing.Point(116, 47)
        Label44.Name = "Label44"
        Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label44.Size = New System.Drawing.Size(74, 14)
        Label44.TabIndex = 140
        Label44.Text = "P25 Wait Time"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.BackColor = System.Drawing.SystemColors.Control
        Label15.Cursor = System.Windows.Forms.Cursors.Default
        Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Label15.Location = New System.Drawing.Point(44, 115)
        Label15.Name = "Label15"
        Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label15.Size = New System.Drawing.Size(86, 14)
        Label15.TabIndex = 367
        Label15.Text = "Handhelds Only:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.SystemColors.Control
        Label6.Cursor = System.Windows.Forms.Cursors.Default
        Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Label6.Location = New System.Drawing.Point(48, 229)
        Label6.Name = "Label6"
        Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label6.Size = New System.Drawing.Size(98, 14)
        Label6.TabIndex = 374
        Label6.Text = "XT Scanners Only:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.BackColor = System.Drawing.SystemColors.Control
        Label16.Cursor = System.Windows.Forms.Cursors.Default
        Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Label16.Location = New System.Drawing.Point(7, 283)
        Label16.Name = "Label16"
        Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label16.Size = New System.Drawing.Size(64, 14)
        Label16.TabIndex = 377
        Label16.Text = "Light Colour"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.BackColor = System.Drawing.SystemColors.Control
        Label27.Cursor = System.Windows.Forms.Cursors.Default
        Label27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Label27.Location = New System.Drawing.Point(8, 257)
        Label27.Name = "Label27"
        Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label27.Size = New System.Drawing.Size(59, 14)
        Label27.TabIndex = 378
        Label27.Text = "Light Flash"
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.SystemColors.Control
        Label3.Cursor = System.Windows.Forms.Cursors.Default
        Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Label3.Location = New System.Drawing.Point(8, 17)
        Label3.Name = "Label3"
        Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label3.Size = New System.Drawing.Size(73, 17)
        Label3.TabIndex = 152
        Label3.Text = "CC Delay Time"
        '
        'Label52
        '
        Label52.AutoSize = True
        Label52.BackColor = System.Drawing.SystemColors.Control
        Label52.Cursor = System.Windows.Forms.Cursors.Default
        Label52.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label52.ForeColor = System.Drawing.SystemColors.ControlText
        Label52.Location = New System.Drawing.Point(62, 159)
        Label52.Name = "Label52"
        Label52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label52.Size = New System.Drawing.Size(79, 14)
        Label52.TabIndex = 368
        Label52.Text = "Digital XT Only:"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.BackColor = System.Drawing.SystemColors.Control
        Label30.Cursor = System.Windows.Forms.Cursors.Default
        Label30.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Label30.Location = New System.Drawing.Point(49, 92)
        Label30.Name = "Label30"
        Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label30.Size = New System.Drawing.Size(90, 14)
        Label30.TabIndex = 369
        Label30.Text = "CC Code Search:"
        '
        'Label34
        '
        Label34.AutoSize = True
        Label34.BackColor = System.Drawing.SystemColors.Control
        Label34.Cursor = System.Windows.Forms.Cursors.Default
        Label34.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Label34.Location = New System.Drawing.Point(103, 19)
        Label34.Name = "Label34"
        Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label34.Size = New System.Drawing.Size(108, 14)
        Label34.TabIndex = 368
        Label34.Text = "Brightness (XT Only)"
        '
        'Label48
        '
        Label48.AutoSize = True
        Label48.BackColor = System.Drawing.SystemColors.Control
        Label48.Cursor = System.Windows.Forms.Cursors.Default
        Label48.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Label48.Location = New System.Drawing.Point(108, 42)
        Label48.Name = "Label48"
        Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label48.Size = New System.Drawing.Size(29, 14)
        Label48.TabIndex = 369
        Label48.Text = "Low"
        '
        'Label51
        '
        Label51.AutoSize = True
        Label51.BackColor = System.Drawing.SystemColors.Control
        Label51.Cursor = System.Windows.Forms.Cursors.Default
        Label51.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label51.ForeColor = System.Drawing.SystemColors.ControlText
        Label51.Location = New System.Drawing.Point(185, 42)
        Label51.Name = "Label51"
        Label51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label51.Size = New System.Drawing.Size(28, 14)
        Label51.TabIndex = 370
        Label51.Text = "High"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.BackColor = System.Drawing.SystemColors.Control
        Label12.Cursor = System.Windows.Forms.Cursors.Default
        Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Label12.Location = New System.Drawing.Point(82, 26)
        Label12.Name = "Label12"
        Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label12.Size = New System.Drawing.Size(71, 14)
        Label12.TabIndex = 123
        Label12.Text = "LCD Contrast"
        '
        'Label8
        '
        Label8.BackColor = System.Drawing.SystemColors.Control
        Label8.Cursor = System.Windows.Forms.Cursors.Default
        Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Label8.Location = New System.Drawing.Point(60, 24)
        Label8.Name = "Label8"
        Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label8.Size = New System.Drawing.Size(89, 17)
        Label8.TabIndex = 117
        Label8.Text = "Key Beep Level"
        '
        'Label9
        '
        Label9.BackColor = System.Drawing.SystemColors.Control
        Label9.Cursor = System.Windows.Forms.Cursors.Default
        Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Label9.Location = New System.Drawing.Point(12, 44)
        Label9.Name = "Label9"
        Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label9.Size = New System.Drawing.Size(31, 17)
        Label9.TabIndex = 118
        Label9.Text = "Auto"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.BackColor = System.Drawing.SystemColors.Control
        Label10.Cursor = System.Windows.Forms.Cursors.Default
        Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Label10.Location = New System.Drawing.Point(152, 40)
        Label10.Name = "Label10"
        Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label10.Size = New System.Drawing.Size(23, 14)
        Label10.TabIndex = 119
        Label10.Text = "Off"
        '
        'Label11
        '
        Label11.BackColor = System.Drawing.SystemColors.Control
        Label11.Cursor = System.Windows.Forms.Cursors.Default
        Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Label11.Location = New System.Drawing.Point(75, 66)
        Label11.Name = "Label11"
        Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label11.Size = New System.Drawing.Size(56, 17)
        Label11.TabIndex = 120
        Label11.Text = "Medium"
        '
        'GroupBox1
        '
        GroupBox1.Controls.Add(Me.chkUnitID)
        GroupBox1.Controls.Add(Me.PriIntTime)
        GroupBox1.Controls.Add(Label32)
        GroupBox1.Controls.Add(Me.MaxPriChan)
        GroupBox1.Controls.Add(Label31)
        GroupBox1.Controls.Add(Me.cmbBatChg)
        GroupBox1.Controls.Add(Label29)
        GroupBox1.Controls.Add(Me.chkXTGlobalAtt)
        GroupBox1.Controls.Add(Label28)
        GroupBox1.Controls.Add(Me.optXTChanLog2)
        GroupBox1.Controls.Add(Me.optXTChanLog1)
        GroupBox1.Controls.Add(Me.optXTChanLog0)
        GroupBox1.Controls.Add(Me.chkXTP25LP)
        GroupBox1.Controls.Add(Me.chkXTKeySafe)
        GroupBox1.Controls.Add(Me.chkXTKeyLock)
        GroupBox1.ForeColor = System.Drawing.Color.Black
        GroupBox1.Location = New System.Drawing.Point(194, 134)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(302, 226)
        GroupBox1.TabIndex = 362
        GroupBox1.TabStop = False
        GroupBox1.Text = "XT Specific"
        '
        'chkUnitID
        '
        Me.chkUnitID.AutoSize = True
        Me.chkUnitID.Location = New System.Drawing.Point(7, 90)
        Me.chkUnitID.Name = "chkUnitID"
        Me.chkUnitID.Size = New System.Drawing.Size(91, 18)
        Me.chkUnitID.TabIndex = 139
        Me.chkUnitID.Text = "Enable Unit ID"
        Me.chkUnitID.UseVisualStyleBackColor = True
        '
        'PriIntTime
        '
        Me.PriIntTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PriIntTime.FormattingEnabled = True
        Me.PriIntTime.Location = New System.Drawing.Point(210, 147)
        Me.PriIntTime.Name = "PriIntTime"
        Me.PriIntTime.Size = New System.Drawing.Size(52, 22)
        Me.PriIntTime.TabIndex = 138
        '
        'Label32
        '
        Label32.AutoSize = True
        Label32.BackColor = System.Drawing.SystemColors.Control
        Label32.Cursor = System.Windows.Forms.Cursors.Default
        Label32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Label32.Location = New System.Drawing.Point(181, 130)
        Label32.Name = "Label32"
        Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label32.Size = New System.Drawing.Size(103, 14)
        Label32.TabIndex = 137
        Label32.Text = "Priority Interval Time"
        '
        'MaxPriChan
        '
        Me.MaxPriChan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaxPriChan.FormattingEnabled = True
        Me.MaxPriChan.Location = New System.Drawing.Point(210, 90)
        Me.MaxPriChan.Name = "MaxPriChan"
        Me.MaxPriChan.Size = New System.Drawing.Size(52, 22)
        Me.MaxPriChan.TabIndex = 136
        Me.ToolTip1.SetToolTip(Me.MaxPriChan, resources.GetString("MaxPriChan.ToolTip"))
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.BackColor = System.Drawing.SystemColors.Control
        Label31.Cursor = System.Windows.Forms.Cursors.Default
        Label31.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Label31.Location = New System.Drawing.Point(165, 72)
        Label31.Name = "Label31"
        Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label31.Size = New System.Drawing.Size(135, 14)
        Label31.TabIndex = 135
        Label31.Text = "Maximum Priority Channels"
        '
        'cmbBatChg
        '
        Me.cmbBatChg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatChg.FormattingEnabled = True
        Me.cmbBatChg.Location = New System.Drawing.Point(210, 32)
        Me.cmbBatChg.Name = "cmbBatChg"
        Me.cmbBatChg.Size = New System.Drawing.Size(52, 22)
        Me.cmbBatChg.TabIndex = 134
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.BackColor = System.Drawing.SystemColors.Control
        Label29.Cursor = System.Windows.Forms.Cursors.Default
        Label29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Label29.Location = New System.Drawing.Point(178, 15)
        Label29.Name = "Label29"
        Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label29.Size = New System.Drawing.Size(105, 14)
        Label29.TabIndex = 133
        Label29.Text = "Battery Charge Time"
        '
        'chkXTGlobalAtt
        '
        Me.chkXTGlobalAtt.AutoSize = True
        Me.chkXTGlobalAtt.Location = New System.Drawing.Point(7, 70)
        Me.chkXTGlobalAtt.Name = "chkXTGlobalAtt"
        Me.chkXTGlobalAtt.Size = New System.Drawing.Size(135, 18)
        Me.chkXTGlobalAtt.TabIndex = 132
        Me.chkXTGlobalAtt.Text = "Use &Global Attenuation"
        Me.ToolTip1.SetToolTip(Me.chkXTGlobalAtt, "Attenuate all signals by 20dB")
        Me.chkXTGlobalAtt.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.BackColor = System.Drawing.SystemColors.Control
        Label28.Cursor = System.Windows.Forms.Cursors.Default
        Label28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Label28.Location = New System.Drawing.Point(6, 116)
        Label28.Name = "Label28"
        Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label28.Size = New System.Drawing.Size(72, 14)
        Label28.TabIndex = 131
        Label28.Text = "C-Ch Logging"
        '
        'optXTChanLog2
        '
        Me.optXTChanLog2.BackColor = System.Drawing.SystemColors.Control
        Me.optXTChanLog2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optXTChanLog2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optXTChanLog2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optXTChanLog2.Location = New System.Drawing.Point(6, 164)
        Me.optXTChanLog2.Name = "optXTChanLog2"
        Me.optXTChanLog2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optXTChanLog2.Size = New System.Drawing.Size(86, 17)
        Me.optXTChanLog2.TabIndex = 130
        Me.optXTChanLog2.TabStop = True
        Me.optXTChanLog2.Text = "Extended"
        Me.ToolTip1.SetToolTip(Me.optXTChanLog2, "When data stream output function is set to extend, the scanner will output the da" & _
                "ta stream in the following format: <Msg Type>,<CC data>.,<decoded description>.")
        Me.optXTChanLog2.UseVisualStyleBackColor = False
        '
        'optXTChanLog1
        '
        Me.optXTChanLog1.BackColor = System.Drawing.SystemColors.Control
        Me.optXTChanLog1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optXTChanLog1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optXTChanLog1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optXTChanLog1.Location = New System.Drawing.Point(6, 147)
        Me.optXTChanLog1.Name = "optXTChanLog1"
        Me.optXTChanLog1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optXTChanLog1.Size = New System.Drawing.Size(86, 17)
        Me.optXTChanLog1.TabIndex = 129
        Me.optXTChanLog1.TabStop = True
        Me.optXTChanLog1.Text = "On"
        Me.ToolTip1.SetToolTip(Me.optXTChanLog1, "When data stream output is set to on, the scanner will output the data stream in " & _
                "the following format: <Msg Type>,<CC data>.")
        Me.optXTChanLog1.UseVisualStyleBackColor = False
        '
        'optXTChanLog0
        '
        Me.optXTChanLog0.BackColor = System.Drawing.SystemColors.Control
        Me.optXTChanLog0.Cursor = System.Windows.Forms.Cursors.Default
        Me.optXTChanLog0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optXTChanLog0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optXTChanLog0.Location = New System.Drawing.Point(6, 130)
        Me.optXTChanLog0.Name = "optXTChanLog0"
        Me.optXTChanLog0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optXTChanLog0.Size = New System.Drawing.Size(86, 17)
        Me.optXTChanLog0.TabIndex = 128
        Me.optXTChanLog0.TabStop = True
        Me.optXTChanLog0.Text = "Off"
        Me.ToolTip1.SetToolTip(Me.optXTChanLog0, "data stream is not outputted")
        Me.optXTChanLog0.UseVisualStyleBackColor = False
        '
        'chkXTP25LP
        '
        Me.chkXTP25LP.AutoSize = True
        Me.chkXTP25LP.Location = New System.Drawing.Point(7, 52)
        Me.chkXTP25LP.Name = "chkXTP25LP"
        Me.chkXTP25LP.Size = New System.Drawing.Size(145, 18)
        Me.chkXTP25LP.TabIndex = 127
        Me.chkXTP25LP.Text = "Use P25 Low-Pass Filter"
        Me.ToolTip1.SetToolTip(Me.chkXTP25LP, "Helps with P25 reception. Digital XT scanners only.")
        Me.chkXTP25LP.UseVisualStyleBackColor = True
        '
        'chkXTKeySafe
        '
        Me.chkXTKeySafe.AutoSize = True
        Me.chkXTKeySafe.Location = New System.Drawing.Point(7, 34)
        Me.chkXTKeySafe.Name = "chkXTKeySafe"
        Me.chkXTKeySafe.Size = New System.Drawing.Size(71, 18)
        Me.chkXTKeySafe.TabIndex = 126
        Me.chkXTKeySafe.Text = "Key Safe"
        Me.ToolTip1.SetToolTip(Me.chkXTKeySafe, "This mode helps keep novice users from accidentally changing parameters or modes." & _
                "Some keys don't work in this mode. XT Scanners only.")
        Me.chkXTKeySafe.UseVisualStyleBackColor = True
        '
        'chkXTKeyLock
        '
        Me.chkXTKeyLock.AutoSize = True
        Me.chkXTKeyLock.Location = New System.Drawing.Point(7, 16)
        Me.chkXTKeyLock.Name = "chkXTKeyLock"
        Me.chkXTKeyLock.Size = New System.Drawing.Size(71, 18)
        Me.chkXTKeyLock.TabIndex = 125
        Me.chkXTKeyLock.Text = "Key Lock"
        Me.ToolTip1.SetToolTip(Me.chkXTKeyLock, "This feature disables the keypad and scroll to prevent any accidental input. Hand" & _
                "held XT scanners only.")
        Me.chkXTKeyLock.UseVisualStyleBackColor = True
        '
        'chkAnalogAGC
        '
        Me.chkAnalogAGC.BackColor = System.Drawing.SystemColors.Control
        Me.chkAnalogAGC.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAnalogAGC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnalogAGC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAnalogAGC.Location = New System.Drawing.Point(31, 155)
        Me.chkAnalogAGC.Name = "chkAnalogAGC"
        Me.chkAnalogAGC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAnalogAGC.Size = New System.Drawing.Size(129, 17)
        Me.chkAnalogAGC.TabIndex = 392
        Me.chkAnalogAGC.Text = "Enable A&nalog AGC"
        Me.ToolTip1.SetToolTip(Me.chkAnalogAGC, "Not applicable to XT scanners")
        Me.chkAnalogAGC.UseVisualStyleBackColor = False
        '
        'chkDigitalAGC
        '
        Me.chkDigitalAGC.BackColor = System.Drawing.SystemColors.Control
        Me.chkDigitalAGC.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDigitalAGC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDigitalAGC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDigitalAGC.Location = New System.Drawing.Point(31, 171)
        Me.chkDigitalAGC.Name = "chkDigitalAGC"
        Me.chkDigitalAGC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDigitalAGC.Size = New System.Drawing.Size(121, 17)
        Me.chkDigitalAGC.TabIndex = 393
        Me.chkDigitalAGC.Text = "Enable &Digital AGC"
        Me.ToolTip1.SetToolTip(Me.chkDigitalAGC, "Not applicable to XT scanners")
        Me.chkDigitalAGC.UseVisualStyleBackColor = False
        '
        'chkCloseCallOverride
        '
        Me.chkCloseCallOverride.BackColor = System.Drawing.SystemColors.Control
        Me.chkCloseCallOverride.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCloseCallOverride.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCloseCallOverride.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCloseCallOverride.Location = New System.Drawing.Point(16, 64)
        Me.chkCloseCallOverride.Name = "chkCloseCallOverride"
        Me.chkCloseCallOverride.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCloseCallOverride.Size = New System.Drawing.Size(97, 25)
        Me.chkCloseCallOverride.TabIndex = 21
        Me.chkCloseCallOverride.Text = "O&verride Mode"
        Me.ToolTip1.SetToolTip(Me.chkCloseCallOverride, "Enable this to allow you to automatically tune into a discovered frequency by pus" & _
                "hing any key")
        Me.chkCloseCallOverride.UseVisualStyleBackColor = False
        '
        'chkCCHits
        '
        Me.chkCCHits.BackColor = System.Drawing.SystemColors.Control
        Me.chkCCHits.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCCHits.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCCHits.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCCHits.Location = New System.Drawing.Point(7, 74)
        Me.chkCCHits.Name = "chkCCHits"
        Me.chkCCHits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCCHits.Size = New System.Drawing.Size(166, 17)
        Me.chkCCHits.TabIndex = 33
        Me.chkCCHits.Text = "Disable CC Hits with Scan"
        Me.ToolTip1.SetToolTip(Me.chkCCHits, "Hits With Scan scans recently captured Close Call frequencies for audio.")
        Me.chkCCHits.UseVisualStyleBackColor = False
        '
        'optCCCodeSearch2
        '
        Me.optCCCodeSearch2.AutoSize = True
        Me.optCCCodeSearch2.Location = New System.Drawing.Point(6, 124)
        Me.optCCCodeSearch2.Name = "optCCCodeSearch2"
        Me.optCCCodeSearch2.Size = New System.Drawing.Size(68, 18)
        Me.optCCCodeSearch2.TabIndex = 372
        Me.optCCCodeSearch2.TabStop = True
        Me.optCCCodeSearch2.Text = "P&25 NAC"
        Me.ToolTip1.SetToolTip(Me.optCCCodeSearch2, "Available for digital XT only.")
        Me.optCCCodeSearch2.UseVisualStyleBackColor = True
        '
        'chkLCDFlip
        '
        Me.chkLCDFlip.BackColor = System.Drawing.SystemColors.Control
        Me.chkLCDFlip.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLCDFlip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLCDFlip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLCDFlip.Location = New System.Drawing.Point(8, 144)
        Me.chkLCDFlip.Name = "chkLCDFlip"
        Me.chkLCDFlip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLCDFlip.Size = New System.Drawing.Size(185, 17)
        Me.chkLCDFlip.TabIndex = 47
        Me.chkLCDFlip.Text = "Flip Display Upside-Down"
        Me.ToolTip1.SetToolTip(Me.chkLCDFlip, "15/996 Only")
        Me.chkLCDFlip.UseVisualStyleBackColor = False
        '
        'chkActChanDisp
        '
        Me.chkActChanDisp.BackColor = System.Drawing.SystemColors.Control
        Me.chkActChanDisp.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkActChanDisp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActChanDisp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkActChanDisp.Location = New System.Drawing.Point(8, 128)
        Me.chkActChanDisp.Name = "chkActChanDisp"
        Me.chkActChanDisp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkActChanDisp.Size = New System.Drawing.Size(201, 17)
        Me.chkActChanDisp.TabIndex = 46
        Me.chkActChanDisp.Text = "Enable Active Channel Display Mode"
        Me.ToolTip1.SetToolTip(Me.chkActChanDisp, "Clear this if you wish to have the active frequency displayed in a trunk system")
        Me.chkActChanDisp.UseVisualStyleBackColor = False
        '
        'optMode1
        '
        Me.optMode1.BackColor = System.Drawing.SystemColors.Control
        Me.optMode1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMode1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMode1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMode1.Location = New System.Drawing.Point(8, 75)
        Me.optMode1.Name = "optMode1"
        Me.optMode1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMode1.Size = New System.Drawing.Size(145, 17)
        Me.optMode1.TabIndex = 43
        Me.optMode1.TabStop = True
        Me.optMode1.Text = "Mode 1 (Channel Data)"
        Me.ToolTip1.SetToolTip(Me.optMode1, "Mode1 indicates the channel data under the Channel Name.")
        Me.optMode1.UseVisualStyleBackColor = False
        '
        'optMode2
        '
        Me.optMode2.BackColor = System.Drawing.SystemColors.Control
        Me.optMode2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMode2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMode2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMode2.Location = New System.Drawing.Point(8, 92)
        Me.optMode2.Name = "optMode2"
        Me.optMode2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMode2.Size = New System.Drawing.Size(129, 17)
        Me.optMode2.TabIndex = 44
        Me.optMode2.TabStop = True
        Me.optMode2.Text = "Mode 2 (Frequency)"
        Me.ToolTip1.SetToolTip(Me.optMode2, "Indicates the freq with conv systems and TGID number for trunked")
        Me.optMode2.UseVisualStyleBackColor = False
        '
        'OptMode3
        '
        Me.OptMode3.BackColor = System.Drawing.SystemColors.Control
        Me.OptMode3.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptMode3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptMode3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptMode3.Location = New System.Drawing.Point(8, 109)
        Me.OptMode3.Name = "OptMode3"
        Me.OptMode3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptMode3.Size = New System.Drawing.Size(191, 17)
        Me.OptMode3.TabIndex = 376
        Me.OptMode3.TabStop = True
        Me.OptMode3.Text = "Mode 3 (XT Trunking Indicator)"
        Me.ToolTip1.SetToolTip(Me.OptMode3, " On XT scanners only, the scanner displays the TGID name on the second line and t" & _
                "runking activity indicators under the second line.")
        Me.OptMode3.UseVisualStyleBackColor = False
        '
        '_optPriMode_1
        '
        Me._optPriMode_1.BackColor = System.Drawing.SystemColors.Control
        Me._optPriMode_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optPriMode_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optPriMode_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optPriMode_1.Location = New System.Drawing.Point(7, 113)
        Me._optPriMode_1.Name = "_optPriMode_1"
        Me._optPriMode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optPriMode_1.Size = New System.Drawing.Size(86, 17)
        Me._optPriMode_1.TabIndex = 52
        Me._optPriMode_1.TabStop = True
        Me._optPriMode_1.Text = "Priority ON"
        Me.ToolTip1.SetToolTip(Me._optPriMode_1, "You can set the scanner so it scans only the priority channels.")
        Me._optPriMode_1.UseVisualStyleBackColor = False
        '
        '_optPriMode_2
        '
        Me._optPriMode_2.BackColor = System.Drawing.SystemColors.Control
        Me._optPriMode_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optPriMode_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optPriMode_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optPriMode_2.Location = New System.Drawing.Point(7, 129)
        Me._optPriMode_2.Name = "_optPriMode_2"
        Me._optPriMode_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optPriMode_2.Size = New System.Drawing.Size(86, 17)
        Me._optPriMode_2.TabIndex = 53
        Me._optPriMode_2.TabStop = True
        Me._optPriMode_2.Text = "Priority ON+"
        Me.ToolTip1.SetToolTip(Me._optPriMode_2, "This works in Scan Mode or Scan Hold Mode when the setting of Priority Scan is Pl" & _
                "us On. In this condition, the ""PRI"" icon blinks and the scanner scans only Prior" & _
                "ity Channels.")
        Me._optPriMode_2.UseVisualStyleBackColor = False
        '
        'chkBatSave
        '
        Me.chkBatSave.AutoSize = True
        Me.chkBatSave.BackColor = System.Drawing.SystemColors.Control
        Me.chkBatSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBatSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBatSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBatSave.Location = New System.Drawing.Point(5, 151)
        Me.chkBatSave.Name = "chkBatSave"
        Me.chkBatSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBatSave.Size = New System.Drawing.Size(170, 18)
        Me.chkBatSave.TabIndex = 375
        Me.chkBatSave.Text = "Battery Sa&ve (Handheld Only)"
        Me.ToolTip1.SetToolTip(Me.chkBatSave, "This feature turns off RF power for 1 second and turns on it 300 ms to extend the" & _
                " battery life. It works in scan hold mode of a conventional system or any search" & _
                " hold mode.")
        Me.chkBatSave.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(628, 408)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(97, 25)
        Me.Command1.TabIndex = 111
        Me.Command1.Text = "C&ancel"
        Me.Command1.UseVisualStyleBackColor = True
        '
        'cmdApply
        '
        Me.cmdApply.BackColor = System.Drawing.SystemColors.Control
        Me.cmdApply.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdApply.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdApply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdApply.Location = New System.Drawing.Point(525, 408)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdApply.Size = New System.Drawing.Size(97, 25)
        Me.cmdApply.TabIndex = 112
        Me.cmdApply.Text = "&OK"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        '_optDispMode_TabPage9
        '
        Me._optDispMode_TabPage9.Controls.Add(Me._Frame22_1)
        Me._optDispMode_TabPage9.Controls.Add(Me._Frame22_0)
        Me._optDispMode_TabPage9.Controls.Add(Me.Frame16)
        Me._optDispMode_TabPage9.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage9.Name = "_optDispMode_TabPage9"
        Me._optDispMode_TabPage9.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage9.TabIndex = 9
        Me._optDispMode_TabPage9.Text = "Advanced"
        '
        '_Frame22_1
        '
        Me._Frame22_1.BackColor = System.Drawing.SystemColors.Control
        Me._Frame22_1.Controls.Add(Me.cmbP25Wait)
        Me._Frame22_1.Controls.Add(Me._Label1_5)
        Me._Frame22_1.Controls.Add(Me._Label1_9)
        Me._Frame22_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame22_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame22_1.Location = New System.Drawing.Point(8, 213)
        Me._Frame22_1.Name = "_Frame22_1"
        Me._Frame22_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame22_1.Size = New System.Drawing.Size(619, 145)
        Me._Frame22_1.TabIndex = 392
        Me._Frame22_1.TabStop = False
        Me._Frame22_1.Text = "P25 Wait Time"
        '
        'cmbP25Wait
        '
        Me.cmbP25Wait.BackColor = System.Drawing.SystemColors.Window
        Me.cmbP25Wait.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbP25Wait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbP25Wait.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbP25Wait.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbP25Wait.Location = New System.Drawing.Point(78, 108)
        Me.cmbP25Wait.Name = "cmbP25Wait"
        Me.cmbP25Wait.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbP25Wait.Size = New System.Drawing.Size(64, 22)
        Me.cmbP25Wait.TabIndex = 395
        '
        '_Label1_5
        '
        Me._Label1_5.AutoSize = True
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(21, 113)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(54, 14)
        Me._Label1_5.TabIndex = 394
        Me._Label1_5.Text = "Time (ms)"
        '
        '_Label1_9
        '
        Me._Label1_9.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_9.Location = New System.Drawing.Point(6, 21)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_9.Size = New System.Drawing.Size(594, 89)
        Me._Label1_9.TabIndex = 393
        Me._Label1_9.Text = resources.GetString("_Label1_9.Text")
        '
        '_Frame22_0
        '
        Me._Frame22_0.BackColor = System.Drawing.SystemColors.Control
        Me._Frame22_0.Controls.Add(Me.chkDigitalAGC)
        Me._Frame22_0.Controls.Add(Me.chkAnalogAGC)
        Me._Frame22_0.Controls.Add(Me._cmbAGC_5)
        Me._Frame22_0.Controls.Add(Me._cmbAGC_4)
        Me._Frame22_0.Controls.Add(Me._cmbAGC_3)
        Me._Frame22_0.Controls.Add(Me._cmbAGC_2)
        Me._Frame22_0.Controls.Add(Me._cmbAGC_1)
        Me._Frame22_0.Controls.Add(Me._cmbAGC_0)
        Me._Frame22_0.Controls.Add(Me._Label1_4)
        Me._Frame22_0.Controls.Add(Me._Label1_3)
        Me._Frame22_0.Controls.Add(Me._Label1_2)
        Me._Frame22_0.Controls.Add(Me._Label1_1)
        Me._Frame22_0.Controls.Add(Me._Label1_0)
        Me._Frame22_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame22_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame22_0.Location = New System.Drawing.Point(233, 11)
        Me._Frame22_0.Name = "_Frame22_0"
        Me._Frame22_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame22_0.Size = New System.Drawing.Size(397, 193)
        Me._Frame22_0.TabIndex = 380
        Me._Frame22_0.TabStop = False
        Me._Frame22_0.Text = "AGC Control"
        '
        '_cmbAGC_5
        '
        Me._cmbAGC_5.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAGC_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAGC_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAGC_5.Enabled = False
        Me._cmbAGC_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAGC_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbAGC_5.Location = New System.Drawing.Point(186, 129)
        Me._cmbAGC_5.Name = "_cmbAGC_5"
        Me._cmbAGC_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAGC_5.Size = New System.Drawing.Size(52, 22)
        Me._cmbAGC_5.TabIndex = 391
        '
        '_cmbAGC_4
        '
        Me._cmbAGC_4.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAGC_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAGC_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAGC_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAGC_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbAGC_4.Location = New System.Drawing.Point(186, 102)
        Me._cmbAGC_4.Name = "_cmbAGC_4"
        Me._cmbAGC_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAGC_4.Size = New System.Drawing.Size(52, 22)
        Me._cmbAGC_4.TabIndex = 390
        '
        '_cmbAGC_3
        '
        Me._cmbAGC_3.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAGC_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAGC_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAGC_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAGC_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbAGC_3.Location = New System.Drawing.Point(186, 75)
        Me._cmbAGC_3.Name = "_cmbAGC_3"
        Me._cmbAGC_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAGC_3.Size = New System.Drawing.Size(52, 22)
        Me._cmbAGC_3.TabIndex = 389
        '
        '_cmbAGC_2
        '
        Me._cmbAGC_2.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAGC_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAGC_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAGC_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAGC_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbAGC_2.Location = New System.Drawing.Point(123, 129)
        Me._cmbAGC_2.Name = "_cmbAGC_2"
        Me._cmbAGC_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAGC_2.Size = New System.Drawing.Size(52, 22)
        Me._cmbAGC_2.TabIndex = 388
        '
        '_cmbAGC_1
        '
        Me._cmbAGC_1.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAGC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAGC_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAGC_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAGC_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbAGC_1.Location = New System.Drawing.Point(123, 102)
        Me._cmbAGC_1.Name = "_cmbAGC_1"
        Me._cmbAGC_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAGC_1.Size = New System.Drawing.Size(52, 22)
        Me._cmbAGC_1.TabIndex = 387
        '
        '_cmbAGC_0
        '
        Me._cmbAGC_0.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAGC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAGC_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAGC_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAGC_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbAGC_0.Location = New System.Drawing.Point(123, 75)
        Me._cmbAGC_0.Name = "_cmbAGC_0"
        Me._cmbAGC_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAGC_0.Size = New System.Drawing.Size(52, 22)
        Me._cmbAGC_0.TabIndex = 386
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = True
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(33, 132)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(82, 14)
        Me._Label1_4.TabIndex = 385
        Me._Label1_4.Text = "Dynamic Range"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(33, 102)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(83, 14)
        Me._Label1_3.TabIndex = 384
        Me._Label1_3.Text = "Reference Gain"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = True
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(33, 72)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(81, 14)
        Me._Label1_2.TabIndex = 383
        Me._Label1_2.Text = "Response Time"
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = True
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(129, 57)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(99, 14)
        Me._Label1_1.TabIndex = 382
        Me._Label1_1.Text = "Analog          Digital"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(9, 21)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(384, 31)
        Me._Label1_0.TabIndex = 381
        Me._Label1_0.Text = "Applies to 396(X)T && 996 with rev 3.0 firmware only. Customizing these settings " & _
            "allows more precise control of volume gain. If unsure, leave default."
        '
        'Frame16
        '
        Me.Frame16.BackColor = System.Drawing.SystemColors.Control
        Me.Frame16.Controls.Add(Me.Frame17)
        Me.Frame16.Controls.Add(Me.chkGPSKM)
        Me.Frame16.Controls.Add(Me.chkGPSTimeFormat)
        Me.Frame16.Controls.Add(Me.chkGPSDMS)
        Me.Frame16.Controls.Add(Me.cmbGPSTimeZone)
        Me.Frame16.Controls.Add(Me.Label39)
        Me.Frame16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame16.Location = New System.Drawing.Point(7, 6)
        Me.Frame16.Name = "Frame16"
        Me.Frame16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame16.Size = New System.Drawing.Size(217, 199)
        Me.Frame16.TabIndex = 348
        Me.Frame16.TabStop = False
        Me.Frame16.Text = "GPS Settings"
        '
        'Frame17
        '
        Me.Frame17.BackColor = System.Drawing.SystemColors.Control
        Me.Frame17.Controls.Add(Me._optGPSDispMode_0)
        Me.Frame17.Controls.Add(Me._optGPSDispMode_1)
        Me.Frame17.Controls.Add(Me._optGPSDispMode_2)
        Me.Frame17.Controls.Add(Me._optGPSDispMode_3)
        Me.Frame17.Controls.Add(Me._optGPSDispMode_4)
        Me.Frame17.Controls.Add(Me.Label38)
        Me.Frame17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame17.Location = New System.Drawing.Point(8, 16)
        Me.Frame17.Name = "Frame17"
        Me.Frame17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame17.Size = New System.Drawing.Size(201, 71)
        Me.Frame17.TabIndex = 353
        Me.Frame17.Text = "Display Mode"
        '
        '_optGPSDispMode_0
        '
        Me._optGPSDispMode_0.AutoSize = True
        Me._optGPSDispMode_0.BackColor = System.Drawing.SystemColors.Control
        Me._optGPSDispMode_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optGPSDispMode_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optGPSDispMode_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optGPSDispMode_0.Location = New System.Drawing.Point(8, 24)
        Me._optGPSDispMode_0.Name = "_optGPSDispMode_0"
        Me._optGPSDispMode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optGPSDispMode_0.Size = New System.Drawing.Size(44, 18)
        Me._optGPSDispMode_0.TabIndex = 358
        Me._optGPSDispMode_0.TabStop = True
        Me._optGPSDispMode_0.Text = "ETA"
        Me._optGPSDispMode_0.UseVisualStyleBackColor = False
        '
        '_optGPSDispMode_1
        '
        Me._optGPSDispMode_1.AutoSize = True
        Me._optGPSDispMode_1.BackColor = System.Drawing.SystemColors.Control
        Me._optGPSDispMode_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optGPSDispMode_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optGPSDispMode_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optGPSDispMode_1.Location = New System.Drawing.Point(8, 40)
        Me._optGPSDispMode_1.Name = "_optGPSDispMode_1"
        Me._optGPSDispMode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optGPSDispMode_1.Size = New System.Drawing.Size(51, 18)
        Me._optGPSDispMode_1.TabIndex = 357
        Me._optGPSDispMode_1.TabStop = True
        Me._optGPSDispMode_1.Text = "Clock"
        Me._optGPSDispMode_1.UseVisualStyleBackColor = False
        '
        '_optGPSDispMode_2
        '
        Me._optGPSDispMode_2.AutoSize = True
        Me._optGPSDispMode_2.BackColor = System.Drawing.SystemColors.Control
        Me._optGPSDispMode_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optGPSDispMode_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optGPSDispMode_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optGPSDispMode_2.Location = New System.Drawing.Point(64, 24)
        Me._optGPSDispMode_2.Name = "_optGPSDispMode_2"
        Me._optGPSDispMode_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optGPSDispMode_2.Size = New System.Drawing.Size(68, 18)
        Me._optGPSDispMode_2.TabIndex = 356
        Me._optGPSDispMode_2.TabStop = True
        Me._optGPSDispMode_2.Text = "Elevation"
        Me._optGPSDispMode_2.UseVisualStyleBackColor = False
        '
        '_optGPSDispMode_3
        '
        Me._optGPSDispMode_3.BackColor = System.Drawing.SystemColors.Control
        Me._optGPSDispMode_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._optGPSDispMode_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optGPSDispMode_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optGPSDispMode_3.Location = New System.Drawing.Point(64, 40)
        Me._optGPSDispMode_3.Name = "_optGPSDispMode_3"
        Me._optGPSDispMode_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optGPSDispMode_3.Size = New System.Drawing.Size(57, 17)
        Me._optGPSDispMode_3.TabIndex = 355
        Me._optGPSDispMode_3.TabStop = True
        Me._optGPSDispMode_3.Text = "Speed"
        Me._optGPSDispMode_3.UseVisualStyleBackColor = False
        '
        '_optGPSDispMode_4
        '
        Me._optGPSDispMode_4.AutoSize = True
        Me._optGPSDispMode_4.BackColor = System.Drawing.SystemColors.Control
        Me._optGPSDispMode_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._optGPSDispMode_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optGPSDispMode_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optGPSDispMode_4.Location = New System.Drawing.Point(132, 24)
        Me._optGPSDispMode_4.Name = "_optGPSDispMode_4"
        Me._optGPSDispMode_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optGPSDispMode_4.Size = New System.Drawing.Size(66, 18)
        Me._optGPSDispMode_4.TabIndex = 354
        Me._optGPSDispMode_4.TabStop = True
        Me._optGPSDispMode_4.Text = "Location"
        Me._optGPSDispMode_4.UseVisualStyleBackColor = False
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(8, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(129, 17)
        Me.Label38.TabIndex = 359
        Me.Label38.Text = "GPS Display Mode"
        '
        'chkGPSKM
        '
        Me.chkGPSKM.BackColor = System.Drawing.SystemColors.Control
        Me.chkGPSKM.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkGPSKM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGPSKM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGPSKM.Location = New System.Drawing.Point(17, 93)
        Me.chkGPSKM.Name = "chkGPSKM"
        Me.chkGPSKM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGPSKM.Size = New System.Drawing.Size(169, 17)
        Me.chkGPSKM.TabIndex = 352
        Me.chkGPSKM.Text = "Use &metric measurements"
        Me.chkGPSKM.UseVisualStyleBackColor = False
        '
        'chkGPSTimeFormat
        '
        Me.chkGPSTimeFormat.BackColor = System.Drawing.SystemColors.Control
        Me.chkGPSTimeFormat.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkGPSTimeFormat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGPSTimeFormat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGPSTimeFormat.Location = New System.Drawing.Point(17, 109)
        Me.chkGPSTimeFormat.Name = "chkGPSTimeFormat"
        Me.chkGPSTimeFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGPSTimeFormat.Size = New System.Drawing.Size(177, 17)
        Me.chkGPSTimeFormat.TabIndex = 351
        Me.chkGPSTimeFormat.Text = "&Use 24-hour time format"
        Me.chkGPSTimeFormat.UseVisualStyleBackColor = False
        '
        'chkGPSDMS
        '
        Me.chkGPSDMS.BackColor = System.Drawing.SystemColors.Control
        Me.chkGPSDMS.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkGPSDMS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGPSDMS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGPSDMS.Location = New System.Drawing.Point(17, 125)
        Me.chkGPSDMS.Name = "chkGPSDMS"
        Me.chkGPSDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGPSDMS.Size = New System.Drawing.Size(193, 17)
        Me.chkGPSDMS.TabIndex = 350
        Me.chkGPSDMS.Text = "Use DMS format instead of Degree"
        Me.chkGPSDMS.UseVisualStyleBackColor = False
        '
        'cmbGPSTimeZone
        '
        Me.cmbGPSTimeZone.BackColor = System.Drawing.SystemColors.Window
        Me.cmbGPSTimeZone.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbGPSTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGPSTimeZone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGPSTimeZone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGPSTimeZone.Location = New System.Drawing.Point(73, 165)
        Me.cmbGPSTimeZone.Name = "cmbGPSTimeZone"
        Me.cmbGPSTimeZone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbGPSTimeZone.Size = New System.Drawing.Size(73, 22)
        Me.cmbGPSTimeZone.TabIndex = 349
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.Control
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(9, 149)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(193, 17)
        Me.Label39.TabIndex = 360
        Me.Label39.Text = "Select your time zone relative to GMT:"
        '
        '_optDispMode_TabPage8
        '
        Me._optDispMode_TabPage8.Controls.Add(Me.grdToneOut)
        Me._optDispMode_TabPage8.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage8.Name = "_optDispMode_TabPage8"
        Me._optDispMode_TabPage8.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage8.TabIndex = 8
        Me._optDispMode_TabPage8.Text = "Fire Tone Out"
        '
        'grdToneOut
        '
        Me.grdToneOut.AllowUserToAddRows = False
        Me.grdToneOut.AllowUserToDeleteRows = False
        Me.grdToneOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grdToneOut.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdToneOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdToneOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtTonName, Me.txtTonFreq, Me.txtTonLowLimit, Me.txtToneHiLimit, Me.cmbTonDelay, Me.cmbTonMod, Me.cmbTonAltTone, Me.cmbTonAltToneLevel, Me.cmbTonAlertColor, Me.cmbAlertFlash, Me.cmbToneAtt, Me.cmbTonAGC, Me.cmbTonRecOut})
        Me.grdToneOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdToneOut.Location = New System.Drawing.Point(0, 0)
        Me.grdToneOut.Name = "grdToneOut"
        Me.grdToneOut.RowHeadersVisible = False
        Me.grdToneOut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.grdToneOut.Size = New System.Drawing.Size(723, 367)
        Me.grdToneOut.TabIndex = 425
        '
        'txtTonName
        '
        Me.txtTonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.txtTonName.HeaderText = "Name                       "
        Me.txtTonName.MaxInputLength = 16
        Me.txtTonName.Name = "txtTonName"
        Me.txtTonName.Width = 79
        '
        'txtTonFreq
        '
        Me.txtTonFreq.HeaderText = "Frequency"
        Me.txtTonFreq.Name = "txtTonFreq"
        Me.txtTonFreq.Width = 84
        '
        'txtTonLowLimit
        '
        Me.txtTonLowLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.NullValue = Nothing
        Me.txtTonLowLimit.DefaultCellStyle = DataGridViewCellStyle1
        Me.txtTonLowLimit.HeaderText = "Tone A"
        Me.txtTonLowLimit.MaxInputLength = 9
        Me.txtTonLowLimit.Name = "txtTonLowLimit"
        Me.txtTonLowLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.txtTonLowLimit.Width = 42
        '
        'txtToneHiLimit
        '
        Me.txtToneHiLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.txtToneHiLimit.HeaderText = "Tone B"
        Me.txtToneHiLimit.MaxInputLength = 9
        Me.txtToneHiLimit.Name = "txtToneHiLimit"
        Me.txtToneHiLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.txtToneHiLimit.Width = 42
        '
        'cmbTonDelay
        '
        Me.cmbTonDelay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cmbTonDelay.HeaderText = "Delay"
        Me.cmbTonDelay.Name = "cmbTonDelay"
        Me.cmbTonDelay.ToolTipText = "Non XT selects 0-5 Only"
        Me.cmbTonDelay.Width = 40
        '
        'cmbTonMod
        '
        Me.cmbTonMod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cmbTonMod.HeaderText = "Mod"
        Me.cmbTonMod.Name = "cmbTonMod"
        Me.cmbTonMod.Width = 33
        '
        'cmbTonAltTone
        '
        Me.cmbTonAltTone.HeaderText = "Alert Tone"
        Me.cmbTonAltTone.Name = "cmbTonAltTone"
        Me.cmbTonAltTone.Width = 56
        '
        'cmbTonAltToneLevel
        '
        Me.cmbTonAltToneLevel.HeaderText = "Alert Tone Lvl"
        Me.cmbTonAltToneLevel.Name = "cmbTonAltToneLevel"
        Me.cmbTonAltToneLevel.Width = 59
        '
        'cmbTonAlertColor
        '
        Me.cmbTonAlertColor.HeaderText = "Alert Color"
        Me.cmbTonAlertColor.Name = "cmbTonAlertColor"
        Me.cmbTonAlertColor.Width = 58
        '
        'cmbAlertFlash
        '
        Me.cmbAlertFlash.HeaderText = "Alert Flash"
        Me.cmbAlertFlash.Name = "cmbAlertFlash"
        Me.cmbAlertFlash.Width = 59
        '
        'cmbToneAtt
        '
        Me.cmbToneAtt.HeaderText = "Att"
        Me.cmbToneAtt.Name = "cmbToneAtt"
        Me.cmbToneAtt.Width = 27
        '
        'cmbTonAGC
        '
        Me.cmbTonAGC.HeaderText = "Analog AGC"
        Me.cmbTonAGC.Name = "cmbTonAGC"
        Me.cmbTonAGC.ToolTipText = "396XT Only"
        Me.cmbTonAGC.Width = 65
        '
        'cmbTonRecOut
        '
        Me.cmbTonRecOut.HeaderText = "Rec Out"
        Me.cmbTonRecOut.Name = "cmbTonRecOut"
        Me.cmbTonRecOut.Width = 32
        '
        '_optDispMode_TabPage7
        '
        Me._optDispMode_TabPage7.Controls.Add(Me.Frame15)
        Me._optDispMode_TabPage7.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage7.Name = "_optDispMode_TabPage7"
        Me._optDispMode_TabPage7.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage7.TabIndex = 7
        Me._optDispMode_TabPage7.Text = "WX Alert"
        '
        'Frame15
        '
        Me.Frame15.BackColor = System.Drawing.SystemColors.Control
        Me.Frame15.Controls.Add(Me.Frame20)
        Me.Frame15.Controls.Add(Me.cmdResetWX)
        Me.Frame15.Controls.Add(Me._txtWX_44)
        Me.Frame15.Controls.Add(Me._txtWX_43)
        Me.Frame15.Controls.Add(Me._txtWX_42)
        Me.Frame15.Controls.Add(Me._txtWX_41)
        Me.Frame15.Controls.Add(Me._txtWX_40)
        Me.Frame15.Controls.Add(Me._txtWX_39)
        Me.Frame15.Controls.Add(Me._txtWX_38)
        Me.Frame15.Controls.Add(Me._txtWX_37)
        Me.Frame15.Controls.Add(Me._txtWX_36)
        Me.Frame15.Controls.Add(Me._txtWX_35)
        Me.Frame15.Controls.Add(Me._txtWX_34)
        Me.Frame15.Controls.Add(Me._txtWX_33)
        Me.Frame15.Controls.Add(Me._txtWX_32)
        Me.Frame15.Controls.Add(Me._txtWX_31)
        Me.Frame15.Controls.Add(Me._txtWX_30)
        Me.Frame15.Controls.Add(Me._txtWX_29)
        Me.Frame15.Controls.Add(Me._txtWX_28)
        Me.Frame15.Controls.Add(Me._txtWX_27)
        Me.Frame15.Controls.Add(Me._txtWX_26)
        Me.Frame15.Controls.Add(Me._txtWX_25)
        Me.Frame15.Controls.Add(Me._txtWX_24)
        Me.Frame15.Controls.Add(Me._txtWX_23)
        Me.Frame15.Controls.Add(Me._txtWX_22)
        Me.Frame15.Controls.Add(Me._txtWX_21)
        Me.Frame15.Controls.Add(Me._txtWX_20)
        Me.Frame15.Controls.Add(Me._txtWX_19)
        Me.Frame15.Controls.Add(Me._txtWX_18)
        Me.Frame15.Controls.Add(Me._txtWX_17)
        Me.Frame15.Controls.Add(Me._txtWX_16)
        Me.Frame15.Controls.Add(Me._txtWX_15)
        Me.Frame15.Controls.Add(Me._txtWX_14)
        Me.Frame15.Controls.Add(Me._txtWX_13)
        Me.Frame15.Controls.Add(Me._txtWX_12)
        Me.Frame15.Controls.Add(Me._txtWX_11)
        Me.Frame15.Controls.Add(Me._txtWX_10)
        Me.Frame15.Controls.Add(Me._txtWX_9)
        Me.Frame15.Controls.Add(Me._txtWX_8)
        Me.Frame15.Controls.Add(Me._txtWX_7)
        Me.Frame15.Controls.Add(Me._txtWX_6)
        Me.Frame15.Controls.Add(Me._txtWX_5)
        Me.Frame15.Controls.Add(Me._txtWX_4)
        Me.Frame15.Controls.Add(Me._txtWX_3)
        Me.Frame15.Controls.Add(Me._txtWX_2)
        Me.Frame15.Controls.Add(Me._txtWX_1)
        Me.Frame15.Controls.Add(Me._txtWX_0)
        Me.Frame15.Controls.Add(Me.cmbWXDelay)
        Me.Frame15.Controls.Add(Me._chkWX_2)
        Me.Frame15.Controls.Add(Me._chkWX_1)
        Me.Frame15.Controls.Add(Me._chkWX_0)
        Me.Frame15.Controls.Add(Me._Label47_4)
        Me.Frame15.Controls.Add(Me._Label47_3)
        Me.Frame15.Controls.Add(Me._Label47_2)
        Me.Frame15.Controls.Add(Me._Label47_1)
        Me.Frame15.Controls.Add(Me._Label47_0)
        Me.Frame15.Controls.Add(Me.Label43)
        Me.Frame15.Controls.Add(Me.Delay)
        Me.Frame15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame15.Location = New System.Drawing.Point(5, 6)
        Me.Frame15.Name = "Frame15"
        Me.Frame15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame15.Size = New System.Drawing.Size(681, 329)
        Me.Frame15.TabIndex = 189
        Me.Frame15.TabStop = False
        Me.Frame15.Text = "Specific Area Message Encoding"
        '
        'Frame20
        '
        Me.Frame20.BackColor = System.Drawing.SystemColors.Control
        Me.Frame20.Controls.Add(Me.cmdUSCodes)
        Me.Frame20.Controls.Add(Me.cmdCanuckKodes)
        Me.Frame20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame20.Location = New System.Drawing.Point(24, 248)
        Me.Frame20.Name = "Frame20"
        Me.Frame20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame20.Size = New System.Drawing.Size(273, 73)
        Me.Frame20.TabIndex = 340
        Me.Frame20.TabStop = False
        Me.Frame20.Text = "Internet Lookup"
        '
        'cmdUSCodes
        '
        Me.cmdUSCodes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUSCodes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUSCodes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUSCodes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUSCodes.Location = New System.Drawing.Point(136, 24)
        Me.cmdUSCodes.Name = "cmdUSCodes"
        Me.cmdUSCodes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUSCodes.Size = New System.Drawing.Size(121, 25)
        Me.cmdUSCodes.TabIndex = 342
        Me.cmdUSCodes.Text = "&U.S Codes..."
        Me.cmdUSCodes.UseVisualStyleBackColor = True
        '
        'cmdCanuckKodes
        '
        Me.cmdCanuckKodes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCanuckKodes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCanuckKodes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCanuckKodes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCanuckKodes.Location = New System.Drawing.Point(8, 24)
        Me.cmdCanuckKodes.Name = "cmdCanuckKodes"
        Me.cmdCanuckKodes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCanuckKodes.Size = New System.Drawing.Size(121, 25)
        Me.cmdCanuckKodes.TabIndex = 341
        Me.cmdCanuckKodes.Text = "&Canadian Codes..."
        Me.cmdCanuckKodes.UseVisualStyleBackColor = True
        '
        'cmdResetWX
        '
        Me.cmdResetWX.BackColor = System.Drawing.SystemColors.Control
        Me.cmdResetWX.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdResetWX.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResetWX.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdResetWX.Location = New System.Drawing.Point(568, 288)
        Me.cmdResetWX.Name = "cmdResetWX"
        Me.cmdResetWX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdResetWX.Size = New System.Drawing.Size(97, 25)
        Me.cmdResetWX.TabIndex = 241
        Me.cmdResetWX.Text = "Reset To Default"
        Me.cmdResetWX.UseVisualStyleBackColor = True
        Me.cmdResetWX.Visible = False
        '
        '_txtWX_44
        '
        Me._txtWX_44.AcceptsReturn = True
        Me._txtWX_44.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_44.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_44.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_44.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_44.Location = New System.Drawing.Point(552, 216)
        Me._txtWX_44.MaxLength = 6
        Me._txtWX_44.Name = "_txtWX_44"
        Me._txtWX_44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_44.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_44.TabIndex = 239
        Me._txtWX_44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_43
        '
        Me._txtWX_43.AcceptsReturn = True
        Me._txtWX_43.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_43.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_43.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_43.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_43.Location = New System.Drawing.Point(496, 216)
        Me._txtWX_43.MaxLength = 6
        Me._txtWX_43.Name = "_txtWX_43"
        Me._txtWX_43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_43.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_43.TabIndex = 238
        Me._txtWX_43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_42
        '
        Me._txtWX_42.AcceptsReturn = True
        Me._txtWX_42.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_42.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_42.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_42.Location = New System.Drawing.Point(440, 216)
        Me._txtWX_42.MaxLength = 6
        Me._txtWX_42.Name = "_txtWX_42"
        Me._txtWX_42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_42.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_42.TabIndex = 237
        Me._txtWX_42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_41
        '
        Me._txtWX_41.AcceptsReturn = True
        Me._txtWX_41.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_41.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_41.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_41.Location = New System.Drawing.Point(384, 216)
        Me._txtWX_41.MaxLength = 6
        Me._txtWX_41.Name = "_txtWX_41"
        Me._txtWX_41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_41.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_41.TabIndex = 236
        Me._txtWX_41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_40
        '
        Me._txtWX_40.AcceptsReturn = True
        Me._txtWX_40.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_40.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_40.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_40.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_40.Location = New System.Drawing.Point(328, 216)
        Me._txtWX_40.MaxLength = 6
        Me._txtWX_40.Name = "_txtWX_40"
        Me._txtWX_40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_40.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_40.TabIndex = 235
        Me._txtWX_40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_39
        '
        Me._txtWX_39.AcceptsReturn = True
        Me._txtWX_39.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_39.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_39.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_39.Location = New System.Drawing.Point(272, 216)
        Me._txtWX_39.MaxLength = 6
        Me._txtWX_39.Name = "_txtWX_39"
        Me._txtWX_39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_39.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_39.TabIndex = 234
        Me._txtWX_39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_38
        '
        Me._txtWX_38.AcceptsReturn = True
        Me._txtWX_38.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_38.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_38.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_38.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_38.Location = New System.Drawing.Point(216, 216)
        Me._txtWX_38.MaxLength = 6
        Me._txtWX_38.Name = "_txtWX_38"
        Me._txtWX_38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_38.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_38.TabIndex = 233
        Me._txtWX_38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_37
        '
        Me._txtWX_37.AcceptsReturn = True
        Me._txtWX_37.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_37.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_37.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_37.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_37.Location = New System.Drawing.Point(160, 216)
        Me._txtWX_37.MaxLength = 6
        Me._txtWX_37.Name = "_txtWX_37"
        Me._txtWX_37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_37.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_37.TabIndex = 232
        Me._txtWX_37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_36
        '
        Me._txtWX_36.AcceptsReturn = True
        Me._txtWX_36.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_36.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_36.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_36.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_36.Location = New System.Drawing.Point(32, 216)
        Me._txtWX_36.MaxLength = 16
        Me._txtWX_36.Name = "_txtWX_36"
        Me._txtWX_36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_36.Size = New System.Drawing.Size(121, 20)
        Me._txtWX_36.TabIndex = 231
        '
        '_txtWX_35
        '
        Me._txtWX_35.AcceptsReturn = True
        Me._txtWX_35.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_35.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_35.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_35.Location = New System.Drawing.Point(552, 192)
        Me._txtWX_35.MaxLength = 6
        Me._txtWX_35.Name = "_txtWX_35"
        Me._txtWX_35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_35.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_35.TabIndex = 230
        Me._txtWX_35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_34
        '
        Me._txtWX_34.AcceptsReturn = True
        Me._txtWX_34.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_34.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_34.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_34.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_34.Location = New System.Drawing.Point(496, 192)
        Me._txtWX_34.MaxLength = 6
        Me._txtWX_34.Name = "_txtWX_34"
        Me._txtWX_34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_34.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_34.TabIndex = 229
        Me._txtWX_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_33
        '
        Me._txtWX_33.AcceptsReturn = True
        Me._txtWX_33.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_33.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_33.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_33.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_33.Location = New System.Drawing.Point(440, 192)
        Me._txtWX_33.MaxLength = 6
        Me._txtWX_33.Name = "_txtWX_33"
        Me._txtWX_33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_33.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_33.TabIndex = 228
        Me._txtWX_33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_32
        '
        Me._txtWX_32.AcceptsReturn = True
        Me._txtWX_32.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_32.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_32.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_32.Location = New System.Drawing.Point(384, 192)
        Me._txtWX_32.MaxLength = 6
        Me._txtWX_32.Name = "_txtWX_32"
        Me._txtWX_32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_32.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_32.TabIndex = 227
        Me._txtWX_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_31
        '
        Me._txtWX_31.AcceptsReturn = True
        Me._txtWX_31.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_31.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_31.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_31.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_31.Location = New System.Drawing.Point(328, 192)
        Me._txtWX_31.MaxLength = 6
        Me._txtWX_31.Name = "_txtWX_31"
        Me._txtWX_31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_31.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_31.TabIndex = 226
        Me._txtWX_31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_30
        '
        Me._txtWX_30.AcceptsReturn = True
        Me._txtWX_30.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_30.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_30.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_30.Location = New System.Drawing.Point(272, 192)
        Me._txtWX_30.MaxLength = 6
        Me._txtWX_30.Name = "_txtWX_30"
        Me._txtWX_30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_30.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_30.TabIndex = 225
        Me._txtWX_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_29
        '
        Me._txtWX_29.AcceptsReturn = True
        Me._txtWX_29.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_29.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_29.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_29.Location = New System.Drawing.Point(216, 192)
        Me._txtWX_29.MaxLength = 6
        Me._txtWX_29.Name = "_txtWX_29"
        Me._txtWX_29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_29.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_29.TabIndex = 224
        Me._txtWX_29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_28
        '
        Me._txtWX_28.AcceptsReturn = True
        Me._txtWX_28.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_28.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_28.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_28.Location = New System.Drawing.Point(160, 192)
        Me._txtWX_28.MaxLength = 6
        Me._txtWX_28.Name = "_txtWX_28"
        Me._txtWX_28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_28.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_28.TabIndex = 223
        Me._txtWX_28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_27
        '
        Me._txtWX_27.AcceptsReturn = True
        Me._txtWX_27.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_27.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_27.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_27.Location = New System.Drawing.Point(32, 192)
        Me._txtWX_27.MaxLength = 16
        Me._txtWX_27.Name = "_txtWX_27"
        Me._txtWX_27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_27.Size = New System.Drawing.Size(121, 20)
        Me._txtWX_27.TabIndex = 222
        '
        '_txtWX_26
        '
        Me._txtWX_26.AcceptsReturn = True
        Me._txtWX_26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_26.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_26.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_26.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_26.Location = New System.Drawing.Point(552, 168)
        Me._txtWX_26.MaxLength = 6
        Me._txtWX_26.Name = "_txtWX_26"
        Me._txtWX_26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_26.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_26.TabIndex = 221
        Me._txtWX_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_25
        '
        Me._txtWX_25.AcceptsReturn = True
        Me._txtWX_25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_25.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_25.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_25.Location = New System.Drawing.Point(496, 168)
        Me._txtWX_25.MaxLength = 6
        Me._txtWX_25.Name = "_txtWX_25"
        Me._txtWX_25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_25.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_25.TabIndex = 220
        Me._txtWX_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_24
        '
        Me._txtWX_24.AcceptsReturn = True
        Me._txtWX_24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_24.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_24.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_24.Location = New System.Drawing.Point(440, 168)
        Me._txtWX_24.MaxLength = 6
        Me._txtWX_24.Name = "_txtWX_24"
        Me._txtWX_24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_24.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_24.TabIndex = 219
        Me._txtWX_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_23
        '
        Me._txtWX_23.AcceptsReturn = True
        Me._txtWX_23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_23.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_23.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_23.Location = New System.Drawing.Point(384, 168)
        Me._txtWX_23.MaxLength = 6
        Me._txtWX_23.Name = "_txtWX_23"
        Me._txtWX_23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_23.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_23.TabIndex = 218
        Me._txtWX_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_22
        '
        Me._txtWX_22.AcceptsReturn = True
        Me._txtWX_22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_22.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_22.Location = New System.Drawing.Point(328, 168)
        Me._txtWX_22.MaxLength = 6
        Me._txtWX_22.Name = "_txtWX_22"
        Me._txtWX_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_22.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_22.TabIndex = 217
        Me._txtWX_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_21
        '
        Me._txtWX_21.AcceptsReturn = True
        Me._txtWX_21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_21.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_21.Location = New System.Drawing.Point(272, 168)
        Me._txtWX_21.MaxLength = 6
        Me._txtWX_21.Name = "_txtWX_21"
        Me._txtWX_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_21.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_21.TabIndex = 216
        Me._txtWX_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_20
        '
        Me._txtWX_20.AcceptsReturn = True
        Me._txtWX_20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_20.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_20.Location = New System.Drawing.Point(216, 168)
        Me._txtWX_20.MaxLength = 6
        Me._txtWX_20.Name = "_txtWX_20"
        Me._txtWX_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_20.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_20.TabIndex = 215
        Me._txtWX_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_19
        '
        Me._txtWX_19.AcceptsReturn = True
        Me._txtWX_19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_19.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_19.Location = New System.Drawing.Point(160, 168)
        Me._txtWX_19.MaxLength = 6
        Me._txtWX_19.Name = "_txtWX_19"
        Me._txtWX_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_19.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_19.TabIndex = 214
        Me._txtWX_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_18
        '
        Me._txtWX_18.AcceptsReturn = True
        Me._txtWX_18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_18.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_18.Location = New System.Drawing.Point(32, 168)
        Me._txtWX_18.MaxLength = 16
        Me._txtWX_18.Name = "_txtWX_18"
        Me._txtWX_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_18.Size = New System.Drawing.Size(121, 20)
        Me._txtWX_18.TabIndex = 213
        '
        '_txtWX_17
        '
        Me._txtWX_17.AcceptsReturn = True
        Me._txtWX_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_17.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_17.Location = New System.Drawing.Point(552, 144)
        Me._txtWX_17.MaxLength = 6
        Me._txtWX_17.Name = "_txtWX_17"
        Me._txtWX_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_17.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_17.TabIndex = 212
        Me._txtWX_17.Text = "Text1"
        Me._txtWX_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_16
        '
        Me._txtWX_16.AcceptsReturn = True
        Me._txtWX_16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_16.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_16.Location = New System.Drawing.Point(496, 144)
        Me._txtWX_16.MaxLength = 6
        Me._txtWX_16.Name = "_txtWX_16"
        Me._txtWX_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_16.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_16.TabIndex = 211
        Me._txtWX_16.Text = "Text1"
        Me._txtWX_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_15
        '
        Me._txtWX_15.AcceptsReturn = True
        Me._txtWX_15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_15.Location = New System.Drawing.Point(440, 144)
        Me._txtWX_15.MaxLength = 6
        Me._txtWX_15.Name = "_txtWX_15"
        Me._txtWX_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_15.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_15.TabIndex = 210
        Me._txtWX_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_14
        '
        Me._txtWX_14.AcceptsReturn = True
        Me._txtWX_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_14.Location = New System.Drawing.Point(384, 144)
        Me._txtWX_14.MaxLength = 6
        Me._txtWX_14.Name = "_txtWX_14"
        Me._txtWX_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_14.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_14.TabIndex = 209
        Me._txtWX_14.Text = "Text1"
        Me._txtWX_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_13
        '
        Me._txtWX_13.AcceptsReturn = True
        Me._txtWX_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_13.Location = New System.Drawing.Point(328, 144)
        Me._txtWX_13.MaxLength = 6
        Me._txtWX_13.Name = "_txtWX_13"
        Me._txtWX_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_13.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_13.TabIndex = 208
        Me._txtWX_13.Text = "Text1"
        Me._txtWX_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_12
        '
        Me._txtWX_12.AcceptsReturn = True
        Me._txtWX_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_12.Location = New System.Drawing.Point(272, 144)
        Me._txtWX_12.MaxLength = 6
        Me._txtWX_12.Name = "_txtWX_12"
        Me._txtWX_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_12.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_12.TabIndex = 207
        Me._txtWX_12.Text = "Text1"
        Me._txtWX_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_11
        '
        Me._txtWX_11.AcceptsReturn = True
        Me._txtWX_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_11.Location = New System.Drawing.Point(216, 144)
        Me._txtWX_11.MaxLength = 6
        Me._txtWX_11.Name = "_txtWX_11"
        Me._txtWX_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_11.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_11.TabIndex = 206
        Me._txtWX_11.Text = "Text1"
        Me._txtWX_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_10
        '
        Me._txtWX_10.AcceptsReturn = True
        Me._txtWX_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_10.Location = New System.Drawing.Point(160, 144)
        Me._txtWX_10.MaxLength = 6
        Me._txtWX_10.Name = "_txtWX_10"
        Me._txtWX_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_10.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_10.TabIndex = 205
        Me._txtWX_10.Text = "Text1"
        Me._txtWX_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_9
        '
        Me._txtWX_9.AcceptsReturn = True
        Me._txtWX_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._txtWX_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_9.Location = New System.Drawing.Point(32, 144)
        Me._txtWX_9.MaxLength = 16
        Me._txtWX_9.Name = "_txtWX_9"
        Me._txtWX_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_9.Size = New System.Drawing.Size(121, 20)
        Me._txtWX_9.TabIndex = 204
        Me._txtWX_9.Text = "Text1"
        '
        '_txtWX_8
        '
        Me._txtWX_8.AcceptsReturn = True
        Me._txtWX_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_8.Location = New System.Drawing.Point(552, 120)
        Me._txtWX_8.MaxLength = 6
        Me._txtWX_8.Name = "_txtWX_8"
        Me._txtWX_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_8.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_8.TabIndex = 203
        Me._txtWX_8.Text = "Text1"
        Me._txtWX_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_7
        '
        Me._txtWX_7.AcceptsReturn = True
        Me._txtWX_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_7.Location = New System.Drawing.Point(496, 120)
        Me._txtWX_7.MaxLength = 6
        Me._txtWX_7.Name = "_txtWX_7"
        Me._txtWX_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_7.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_7.TabIndex = 202
        Me._txtWX_7.Text = "Text1"
        Me._txtWX_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_6
        '
        Me._txtWX_6.AcceptsReturn = True
        Me._txtWX_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_6.Location = New System.Drawing.Point(440, 120)
        Me._txtWX_6.MaxLength = 6
        Me._txtWX_6.Name = "_txtWX_6"
        Me._txtWX_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_6.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_6.TabIndex = 201
        Me._txtWX_6.Text = "Text1"
        Me._txtWX_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_5
        '
        Me._txtWX_5.AcceptsReturn = True
        Me._txtWX_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_5.Location = New System.Drawing.Point(384, 120)
        Me._txtWX_5.MaxLength = 6
        Me._txtWX_5.Name = "_txtWX_5"
        Me._txtWX_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_5.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_5.TabIndex = 200
        Me._txtWX_5.Text = "Text1"
        Me._txtWX_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_4
        '
        Me._txtWX_4.AcceptsReturn = True
        Me._txtWX_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_4.Location = New System.Drawing.Point(328, 120)
        Me._txtWX_4.MaxLength = 6
        Me._txtWX_4.Name = "_txtWX_4"
        Me._txtWX_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_4.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_4.TabIndex = 199
        Me._txtWX_4.Text = "Text1"
        Me._txtWX_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_3
        '
        Me._txtWX_3.AcceptsReturn = True
        Me._txtWX_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_3.Location = New System.Drawing.Point(272, 120)
        Me._txtWX_3.MaxLength = 6
        Me._txtWX_3.Name = "_txtWX_3"
        Me._txtWX_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_3.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_3.TabIndex = 198
        Me._txtWX_3.Text = "Text1"
        Me._txtWX_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_2
        '
        Me._txtWX_2.AcceptsReturn = True
        Me._txtWX_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_2.Location = New System.Drawing.Point(216, 120)
        Me._txtWX_2.MaxLength = 6
        Me._txtWX_2.Name = "_txtWX_2"
        Me._txtWX_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_2.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_2.TabIndex = 197
        Me._txtWX_2.Text = "Text1"
        Me._txtWX_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_1
        '
        Me._txtWX_1.AcceptsReturn = True
        Me._txtWX_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_1.Location = New System.Drawing.Point(160, 120)
        Me._txtWX_1.MaxLength = 6
        Me._txtWX_1.Name = "_txtWX_1"
        Me._txtWX_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_1.Size = New System.Drawing.Size(57, 20)
        Me._txtWX_1.TabIndex = 196
        Me._txtWX_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtWX_0
        '
        Me._txtWX_0.AcceptsReturn = True
        Me._txtWX_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtWX_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtWX_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtWX_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtWX_0.Location = New System.Drawing.Point(32, 120)
        Me._txtWX_0.MaxLength = 16
        Me._txtWX_0.Name = "_txtWX_0"
        Me._txtWX_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtWX_0.Size = New System.Drawing.Size(121, 20)
        Me._txtWX_0.TabIndex = 195
        '
        'cmbWXDelay
        '
        Me.cmbWXDelay.BackColor = System.Drawing.SystemColors.Window
        Me.cmbWXDelay.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbWXDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWXDelay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWXDelay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbWXDelay.Location = New System.Drawing.Point(224, 48)
        Me.cmbWXDelay.Name = "cmbWXDelay"
        Me.cmbWXDelay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbWXDelay.Size = New System.Drawing.Size(65, 22)
        Me.cmbWXDelay.TabIndex = 193
        '
        '_chkWX_2
        '
        Me._chkWX_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkWX_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkWX_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkWX_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkWX_2.Location = New System.Drawing.Point(24, 64)
        Me._chkWX_2.Name = "_chkWX_2"
        Me._chkWX_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkWX_2.Size = New System.Drawing.Size(161, 17)
        Me._chkWX_2.TabIndex = 192
        Me._chkWX_2.Text = "&Record"
        Me._chkWX_2.UseVisualStyleBackColor = False
        '
        '_chkWX_1
        '
        Me._chkWX_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkWX_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkWX_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkWX_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkWX_1.Location = New System.Drawing.Point(24, 48)
        Me._chkWX_1.Name = "_chkWX_1"
        Me._chkWX_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkWX_1.Size = New System.Drawing.Size(161, 17)
        Me._chkWX_1.TabIndex = 191
        Me._chkWX_1.Text = "&Attenuater"
        Me._chkWX_1.UseVisualStyleBackColor = False
        '
        '_chkWX_0
        '
        Me._chkWX_0.BackColor = System.Drawing.SystemColors.Control
        Me._chkWX_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkWX_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkWX_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkWX_0.Location = New System.Drawing.Point(24, 32)
        Me._chkWX_0.Name = "_chkWX_0"
        Me._chkWX_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkWX_0.Size = New System.Drawing.Size(161, 17)
        Me._chkWX_0.TabIndex = 190
        Me._chkWX_0.Text = "&Weather Alert Priority"
        Me._chkWX_0.UseVisualStyleBackColor = False
        '
        '_Label47_4
        '
        Me._Label47_4.AutoSize = True
        Me._Label47_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label47_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label47_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label47_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label47_4.Location = New System.Drawing.Point(16, 216)
        Me._Label47_4.Name = "_Label47_4"
        Me._Label47_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label47_4.Size = New System.Drawing.Size(13, 14)
        Me._Label47_4.TabIndex = 339
        Me._Label47_4.Text = "5"
        '
        '_Label47_3
        '
        Me._Label47_3.AutoSize = True
        Me._Label47_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label47_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label47_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label47_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label47_3.Location = New System.Drawing.Point(16, 192)
        Me._Label47_3.Name = "_Label47_3"
        Me._Label47_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label47_3.Size = New System.Drawing.Size(13, 14)
        Me._Label47_3.TabIndex = 338
        Me._Label47_3.Text = "4"
        '
        '_Label47_2
        '
        Me._Label47_2.AutoSize = True
        Me._Label47_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label47_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label47_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label47_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label47_2.Location = New System.Drawing.Point(16, 168)
        Me._Label47_2.Name = "_Label47_2"
        Me._Label47_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label47_2.Size = New System.Drawing.Size(13, 14)
        Me._Label47_2.TabIndex = 337
        Me._Label47_2.Text = "3"
        '
        '_Label47_1
        '
        Me._Label47_1.AutoSize = True
        Me._Label47_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label47_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label47_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label47_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label47_1.Location = New System.Drawing.Point(16, 144)
        Me._Label47_1.Name = "_Label47_1"
        Me._Label47_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label47_1.Size = New System.Drawing.Size(13, 14)
        Me._Label47_1.TabIndex = 336
        Me._Label47_1.Text = "2"
        '
        '_Label47_0
        '
        Me._Label47_0.AutoSize = True
        Me._Label47_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label47_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label47_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label47_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label47_0.Location = New System.Drawing.Point(16, 120)
        Me._Label47_0.Name = "_Label47_0"
        Me._Label47_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label47_0.Size = New System.Drawing.Size(13, 14)
        Me._Label47_0.TabIndex = 335
        Me._Label47_0.Text = "1"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.SystemColors.Control
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(32, 104)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(552, 14)
        Me.Label43.TabIndex = 240
        Me.Label43.Text = "SAME Group Name                FIPS 1        FIPS 2         FIPS 3       FIPS 4  " & _
            "    FIPS 5         FIPS 6        FIPS 7        FIPS 8"
        '
        'Delay
        '
        Me.Delay.BackColor = System.Drawing.SystemColors.Control
        Me.Delay.Cursor = System.Windows.Forms.Cursors.Default
        Me.Delay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Delay.Location = New System.Drawing.Point(225, 30)
        Me.Delay.Name = "Delay"
        Me.Delay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Delay.Size = New System.Drawing.Size(81, 17)
        Me.Delay.TabIndex = 194
        Me.Delay.Text = "Delay (seconds):"
        '
        '_optDispMode_TabPage6
        '
        Me._optDispMode_TabPage6.BackColor = System.Drawing.SystemColors.Control
        Me._optDispMode_TabPage6.Controls.Add(Me.Frame18)
        Me._optDispMode_TabPage6.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage6.Name = "_optDispMode_TabPage6"
        Me._optDispMode_TabPage6.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage6.TabIndex = 6
        Me._optDispMode_TabPage6.Text = "BBS"
        '
        'Frame18
        '
        Me.Frame18.BackColor = System.Drawing.SystemColors.Control
        Me.Frame18.Controls.Add(Me._chkBSC_6)
        Me.Frame18.Controls.Add(Me._chkBSC_7)
        Me.Frame18.Controls.Add(Me._txtBBS_19)
        Me.Frame18.Controls.Add(Me._chkBSC_8)
        Me.Frame18.Controls.Add(Me._txtBBS_18)
        Me.Frame18.Controls.Add(Me._chkBSC_9)
        Me.Frame18.Controls.Add(Me._txtBBS_17)
        Me.Frame18.Controls.Add(Me._chkBSC_10)
        Me.Frame18.Controls.Add(Me._txtBBS_16)
        Me.Frame18.Controls.Add(Me._chkBSC_11)
        Me.Frame18.Controls.Add(Me._txtBBS_15)
        Me.Frame18.Controls.Add(Me._chkBSC_12)
        Me.Frame18.Controls.Add(Me._txtBBS_14)
        Me.Frame18.Controls.Add(Me._chkBSC_13)
        Me.Frame18.Controls.Add(Me._txtBBS_13)
        Me.Frame18.Controls.Add(Me._chkBSC_14)
        Me.Frame18.Controls.Add(Me._txtBBS_12)
        Me.Frame18.Controls.Add(Me._chkBSC_15)
        Me.Frame18.Controls.Add(Me._txtBBS_11)
        Me.Frame18.Controls.Add(Me._txtBBS_10)
        Me.Frame18.Controls.Add(Me._txtBBS_9)
        Me.Frame18.Controls.Add(Me._txtBBS_8)
        Me.Frame18.Controls.Add(Me._txtBBS_7)
        Me.Frame18.Controls.Add(Me._txtBBS_6)
        Me.Frame18.Controls.Add(Me._txtBBS_5)
        Me.Frame18.Controls.Add(Me._txtBBS_4)
        Me.Frame18.Controls.Add(Me._txtBBS_3)
        Me.Frame18.Controls.Add(Me._txtBBS_2)
        Me.Frame18.Controls.Add(Me._txtBBS_1)
        Me.Frame18.Controls.Add(Me._txtBBS_0)
        Me.Frame18.Controls.Add(Me._Label42_9)
        Me.Frame18.Controls.Add(Me._Label42_8)
        Me.Frame18.Controls.Add(Me._Label42_7)
        Me.Frame18.Controls.Add(Me._Label42_6)
        Me.Frame18.Controls.Add(Me._Label42_5)
        Me.Frame18.Controls.Add(Me._Label42_4)
        Me.Frame18.Controls.Add(Me._Label42_3)
        Me.Frame18.Controls.Add(Me._Label42_2)
        Me.Frame18.Controls.Add(Me._Label42_1)
        Me.Frame18.Controls.Add(Me._Label42_0)
        Me.Frame18.Controls.Add(Me.Label41)
        Me.Frame18.Controls.Add(Me.Label40)
        Me.Frame18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame18.Location = New System.Drawing.Point(7, 6)
        Me.Frame18.Name = "Frame18"
        Me.Frame18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame18.Size = New System.Drawing.Size(707, 355)
        Me.Frame18.TabIndex = 156
        Me.Frame18.TabStop = False
        Me.Frame18.Text = "Broadcast Screen"
        '
        '_chkBSC_6
        '
        Me._chkBSC_6.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_6.Location = New System.Drawing.Point(419, 65)
        Me._chkBSC_6.Name = "_chkBSC_6"
        Me._chkBSC_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_6.Size = New System.Drawing.Size(65, 17)
        Me._chkBSC_6.TabIndex = 56
        Me._chkBSC_6.Text = "Enabled"
        Me._chkBSC_6.UseVisualStyleBackColor = False
        '
        '_chkBSC_7
        '
        Me._chkBSC_7.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_7.Location = New System.Drawing.Point(419, 89)
        Me._chkBSC_7.Name = "_chkBSC_7"
        Me._chkBSC_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_7.Size = New System.Drawing.Size(97, 17)
        Me._chkBSC_7.TabIndex = 59
        Me._chkBSC_7.Text = "Enabled"
        Me._chkBSC_7.UseVisualStyleBackColor = False
        '
        '_txtBBS_19
        '
        Me._txtBBS_19.AcceptsReturn = True
        Me._txtBBS_19.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_19.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_19.Location = New System.Drawing.Point(352, 280)
        Me._txtBBS_19.MaxLength = 0
        Me._txtBBS_19.Name = "_txtBBS_19"
        Me._txtBBS_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_19.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_19.TabIndex = 82
        '
        '_chkBSC_8
        '
        Me._chkBSC_8.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_8.Location = New System.Drawing.Point(419, 113)
        Me._chkBSC_8.Name = "_chkBSC_8"
        Me._chkBSC_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_8.Size = New System.Drawing.Size(105, 17)
        Me._chkBSC_8.TabIndex = 62
        Me._chkBSC_8.Text = "Enabled"
        Me._chkBSC_8.UseVisualStyleBackColor = False
        '
        '_txtBBS_18
        '
        Me._txtBBS_18.AcceptsReturn = True
        Me._txtBBS_18.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_18.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_18.Location = New System.Drawing.Point(256, 280)
        Me._txtBBS_18.MaxLength = 0
        Me._txtBBS_18.Name = "_txtBBS_18"
        Me._txtBBS_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_18.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_18.TabIndex = 81
        '
        '_chkBSC_9
        '
        Me._chkBSC_9.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_9.Location = New System.Drawing.Point(419, 137)
        Me._chkBSC_9.Name = "_chkBSC_9"
        Me._chkBSC_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_9.Size = New System.Drawing.Size(129, 17)
        Me._chkBSC_9.TabIndex = 65
        Me._chkBSC_9.Text = "Enabled"
        Me._chkBSC_9.UseVisualStyleBackColor = False
        '
        '_txtBBS_17
        '
        Me._txtBBS_17.AcceptsReturn = True
        Me._txtBBS_17.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_17.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_17.Location = New System.Drawing.Point(352, 256)
        Me._txtBBS_17.MaxLength = 0
        Me._txtBBS_17.Name = "_txtBBS_17"
        Me._txtBBS_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_17.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_17.TabIndex = 79
        '
        '_chkBSC_10
        '
        Me._chkBSC_10.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_10.Location = New System.Drawing.Point(419, 161)
        Me._chkBSC_10.Name = "_chkBSC_10"
        Me._chkBSC_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_10.Size = New System.Drawing.Size(129, 17)
        Me._chkBSC_10.TabIndex = 68
        Me._chkBSC_10.Text = "Enabled"
        Me._chkBSC_10.UseVisualStyleBackColor = False
        '
        '_txtBBS_16
        '
        Me._txtBBS_16.AcceptsReturn = True
        Me._txtBBS_16.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_16.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_16.Location = New System.Drawing.Point(256, 256)
        Me._txtBBS_16.MaxLength = 0
        Me._txtBBS_16.Name = "_txtBBS_16"
        Me._txtBBS_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_16.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_16.TabIndex = 78
        '
        '_chkBSC_11
        '
        Me._chkBSC_11.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_11.Location = New System.Drawing.Point(419, 185)
        Me._chkBSC_11.Name = "_chkBSC_11"
        Me._chkBSC_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_11.Size = New System.Drawing.Size(129, 17)
        Me._chkBSC_11.TabIndex = 71
        Me._chkBSC_11.Text = "Enabled"
        Me._chkBSC_11.UseVisualStyleBackColor = False
        '
        '_txtBBS_15
        '
        Me._txtBBS_15.AcceptsReturn = True
        Me._txtBBS_15.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_15.Location = New System.Drawing.Point(352, 232)
        Me._txtBBS_15.MaxLength = 0
        Me._txtBBS_15.Name = "_txtBBS_15"
        Me._txtBBS_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_15.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_15.TabIndex = 76
        '
        '_chkBSC_12
        '
        Me._chkBSC_12.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_12.Location = New System.Drawing.Point(419, 209)
        Me._chkBSC_12.Name = "_chkBSC_12"
        Me._chkBSC_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_12.Size = New System.Drawing.Size(129, 17)
        Me._chkBSC_12.TabIndex = 74
        Me._chkBSC_12.Text = "Enabled"
        Me._chkBSC_12.UseVisualStyleBackColor = False
        '
        '_txtBBS_14
        '
        Me._txtBBS_14.AcceptsReturn = True
        Me._txtBBS_14.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_14.Location = New System.Drawing.Point(256, 232)
        Me._txtBBS_14.MaxLength = 0
        Me._txtBBS_14.Name = "_txtBBS_14"
        Me._txtBBS_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_14.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_14.TabIndex = 75
        '
        '_chkBSC_13
        '
        Me._chkBSC_13.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_13.Location = New System.Drawing.Point(419, 233)
        Me._chkBSC_13.Name = "_chkBSC_13"
        Me._chkBSC_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_13.Size = New System.Drawing.Size(129, 17)
        Me._chkBSC_13.TabIndex = 77
        Me._chkBSC_13.Text = "Enabled"
        Me._chkBSC_13.UseVisualStyleBackColor = False
        '
        '_txtBBS_13
        '
        Me._txtBBS_13.AcceptsReturn = True
        Me._txtBBS_13.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_13.Location = New System.Drawing.Point(352, 208)
        Me._txtBBS_13.MaxLength = 0
        Me._txtBBS_13.Name = "_txtBBS_13"
        Me._txtBBS_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_13.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_13.TabIndex = 73
        '
        '_chkBSC_14
        '
        Me._chkBSC_14.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_14.Location = New System.Drawing.Point(419, 257)
        Me._chkBSC_14.Name = "_chkBSC_14"
        Me._chkBSC_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_14.Size = New System.Drawing.Size(129, 17)
        Me._chkBSC_14.TabIndex = 80
        Me._chkBSC_14.Text = "Enabled"
        Me._chkBSC_14.UseVisualStyleBackColor = False
        '
        '_txtBBS_12
        '
        Me._txtBBS_12.AcceptsReturn = True
        Me._txtBBS_12.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_12.Location = New System.Drawing.Point(256, 208)
        Me._txtBBS_12.MaxLength = 0
        Me._txtBBS_12.Name = "_txtBBS_12"
        Me._txtBBS_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_12.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_12.TabIndex = 72
        '
        '_chkBSC_15
        '
        Me._chkBSC_15.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_15.Location = New System.Drawing.Point(419, 281)
        Me._chkBSC_15.Name = "_chkBSC_15"
        Me._chkBSC_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_15.Size = New System.Drawing.Size(129, 17)
        Me._chkBSC_15.TabIndex = 83
        Me._chkBSC_15.Text = "Enabled"
        Me._chkBSC_15.UseVisualStyleBackColor = False
        '
        '_txtBBS_11
        '
        Me._txtBBS_11.AcceptsReturn = True
        Me._txtBBS_11.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_11.Location = New System.Drawing.Point(352, 184)
        Me._txtBBS_11.MaxLength = 0
        Me._txtBBS_11.Name = "_txtBBS_11"
        Me._txtBBS_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_11.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_11.TabIndex = 70
        '
        '_txtBBS_10
        '
        Me._txtBBS_10.AcceptsReturn = True
        Me._txtBBS_10.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_10.Location = New System.Drawing.Point(256, 184)
        Me._txtBBS_10.MaxLength = 0
        Me._txtBBS_10.Name = "_txtBBS_10"
        Me._txtBBS_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_10.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_10.TabIndex = 69
        '
        '_txtBBS_9
        '
        Me._txtBBS_9.AcceptsReturn = True
        Me._txtBBS_9.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_9.Location = New System.Drawing.Point(352, 160)
        Me._txtBBS_9.MaxLength = 0
        Me._txtBBS_9.Name = "_txtBBS_9"
        Me._txtBBS_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_9.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_9.TabIndex = 67
        '
        '_txtBBS_8
        '
        Me._txtBBS_8.AcceptsReturn = True
        Me._txtBBS_8.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_8.Location = New System.Drawing.Point(256, 160)
        Me._txtBBS_8.MaxLength = 0
        Me._txtBBS_8.Name = "_txtBBS_8"
        Me._txtBBS_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_8.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_8.TabIndex = 66
        '
        '_txtBBS_7
        '
        Me._txtBBS_7.AcceptsReturn = True
        Me._txtBBS_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_7.Location = New System.Drawing.Point(352, 136)
        Me._txtBBS_7.MaxLength = 0
        Me._txtBBS_7.Name = "_txtBBS_7"
        Me._txtBBS_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_7.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_7.TabIndex = 64
        '
        '_txtBBS_6
        '
        Me._txtBBS_6.AcceptsReturn = True
        Me._txtBBS_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_6.Location = New System.Drawing.Point(256, 136)
        Me._txtBBS_6.MaxLength = 0
        Me._txtBBS_6.Name = "_txtBBS_6"
        Me._txtBBS_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_6.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_6.TabIndex = 63
        '
        '_txtBBS_5
        '
        Me._txtBBS_5.AcceptsReturn = True
        Me._txtBBS_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_5.Location = New System.Drawing.Point(352, 112)
        Me._txtBBS_5.MaxLength = 0
        Me._txtBBS_5.Name = "_txtBBS_5"
        Me._txtBBS_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_5.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_5.TabIndex = 61
        '
        '_txtBBS_4
        '
        Me._txtBBS_4.AcceptsReturn = True
        Me._txtBBS_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_4.Location = New System.Drawing.Point(256, 112)
        Me._txtBBS_4.MaxLength = 0
        Me._txtBBS_4.Name = "_txtBBS_4"
        Me._txtBBS_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_4.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_4.TabIndex = 60
        '
        '_txtBBS_3
        '
        Me._txtBBS_3.AcceptsReturn = True
        Me._txtBBS_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_3.Location = New System.Drawing.Point(352, 88)
        Me._txtBBS_3.MaxLength = 0
        Me._txtBBS_3.Name = "_txtBBS_3"
        Me._txtBBS_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_3.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_3.TabIndex = 58
        '
        '_txtBBS_2
        '
        Me._txtBBS_2.AcceptsReturn = True
        Me._txtBBS_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_2.Location = New System.Drawing.Point(256, 88)
        Me._txtBBS_2.MaxLength = 0
        Me._txtBBS_2.Name = "_txtBBS_2"
        Me._txtBBS_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_2.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_2.TabIndex = 57
        '
        '_txtBBS_1
        '
        Me._txtBBS_1.AcceptsReturn = True
        Me._txtBBS_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_1.Location = New System.Drawing.Point(352, 64)
        Me._txtBBS_1.MaxLength = 0
        Me._txtBBS_1.Name = "_txtBBS_1"
        Me._txtBBS_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_1.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_1.TabIndex = 55
        '
        '_txtBBS_0
        '
        Me._txtBBS_0.AcceptsReturn = True
        Me._txtBBS_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtBBS_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtBBS_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtBBS_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtBBS_0.Location = New System.Drawing.Point(256, 64)
        Me._txtBBS_0.MaxLength = 0
        Me._txtBBS_0.Name = "_txtBBS_0"
        Me._txtBBS_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtBBS_0.Size = New System.Drawing.Size(57, 20)
        Me._txtBBS_0.TabIndex = 54
        '
        '_Label42_9
        '
        Me._Label42_9.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_9.Location = New System.Drawing.Point(208, 280)
        Me._Label42_9.Name = "_Label42_9"
        Me._Label42_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_9.Size = New System.Drawing.Size(47, 17)
        Me._Label42_9.TabIndex = 168
        Me._Label42_9.Text = "Band 10"
        '
        '_Label42_8
        '
        Me._Label42_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_8.Location = New System.Drawing.Point(208, 256)
        Me._Label42_8.Name = "_Label42_8"
        Me._Label42_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_8.Size = New System.Drawing.Size(41, 17)
        Me._Label42_8.TabIndex = 167
        Me._Label42_8.Text = "Band 9"
        '
        '_Label42_7
        '
        Me._Label42_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_7.Location = New System.Drawing.Point(208, 232)
        Me._Label42_7.Name = "_Label42_7"
        Me._Label42_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_7.Size = New System.Drawing.Size(41, 17)
        Me._Label42_7.TabIndex = 166
        Me._Label42_7.Text = "Band 8"
        '
        '_Label42_6
        '
        Me._Label42_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_6.Location = New System.Drawing.Point(208, 208)
        Me._Label42_6.Name = "_Label42_6"
        Me._Label42_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_6.Size = New System.Drawing.Size(41, 17)
        Me._Label42_6.TabIndex = 165
        Me._Label42_6.Text = "Band 7"
        '
        '_Label42_5
        '
        Me._Label42_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_5.Location = New System.Drawing.Point(208, 184)
        Me._Label42_5.Name = "_Label42_5"
        Me._Label42_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_5.Size = New System.Drawing.Size(41, 17)
        Me._Label42_5.TabIndex = 164
        Me._Label42_5.Text = "Band 6"
        '
        '_Label42_4
        '
        Me._Label42_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_4.Location = New System.Drawing.Point(208, 160)
        Me._Label42_4.Name = "_Label42_4"
        Me._Label42_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_4.Size = New System.Drawing.Size(41, 17)
        Me._Label42_4.TabIndex = 163
        Me._Label42_4.Text = "Band 5"
        '
        '_Label42_3
        '
        Me._Label42_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_3.Location = New System.Drawing.Point(208, 136)
        Me._Label42_3.Name = "_Label42_3"
        Me._Label42_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_3.Size = New System.Drawing.Size(41, 17)
        Me._Label42_3.TabIndex = 162
        Me._Label42_3.Text = "Band 4"
        '
        '_Label42_2
        '
        Me._Label42_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_2.Location = New System.Drawing.Point(208, 112)
        Me._Label42_2.Name = "_Label42_2"
        Me._Label42_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_2.Size = New System.Drawing.Size(41, 17)
        Me._Label42_2.TabIndex = 161
        Me._Label42_2.Text = "Band 3"
        '
        '_Label42_1
        '
        Me._Label42_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_1.Location = New System.Drawing.Point(208, 88)
        Me._Label42_1.Name = "_Label42_1"
        Me._Label42_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_1.Size = New System.Drawing.Size(41, 17)
        Me._Label42_1.TabIndex = 160
        Me._Label42_1.Text = "Band 2"
        '
        '_Label42_0
        '
        Me._Label42_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label42_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label42_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label42_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label42_0.Location = New System.Drawing.Point(208, 64)
        Me._Label42_0.Name = "_Label42_0"
        Me._Label42_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label42_0.Size = New System.Drawing.Size(41, 17)
        Me._Label42_0.TabIndex = 159
        Me._Label42_0.Text = "Band 1"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.SystemColors.Control
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(256, 48)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label41.Size = New System.Drawing.Size(161, 14)
        Me.Label41.TabIndex = 158
        Me.Label41.Text = "Lower Limit               Upper Limit"
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.Control
        Me.Label40.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label40.Location = New System.Drawing.Point(16, 16)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label40.Size = New System.Drawing.Size(601, 33)
        Me.Label40.TabIndex = 157
        Me.Label40.Text = "These frequency bands will be ignored for Close Call to avoid nuasance triggering" & _
            " around paging towers or other sources of unwanted noise. Not supported on the B" & _
            "C246T or SC230."
        '
        '_optDispMode_TabPage5
        '
        Me._optDispMode_TabPage5.Controls.Add(Me.Frame14)
        Me._optDispMode_TabPage5.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage5.Name = "_optDispMode_TabPage5"
        Me._optDispMode_TabPage5.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage5.TabIndex = 5
        Me._optDispMode_TabPage5.Text = "Searching"
        '
        'Frame14
        '
        Me.Frame14.BackColor = System.Drawing.SystemColors.Control
        Me.Frame14.Controls.Add(Me._chkBSC_5)
        Me.Frame14.Controls.Add(Me._chkBSC_0)
        Me.Frame14.Controls.Add(Me._chkBSC_1)
        Me.Frame14.Controls.Add(Me._chkBSC_2)
        Me.Frame14.Controls.Add(Me._chkBSC_3)
        Me.Frame14.Controls.Add(Me._chkBSC_4)
        Me.Frame14.Controls.Add(Me.cmbSSHold)
        Me.Frame14.Controls.Add(Me.cmbSSModMode)
        Me.Frame14.Controls.Add(Me.cmbSSStep)
        Me.Frame14.Controls.Add(Me.chkCCTapeOut)
        Me.Frame14.Controls.Add(Me.cmbMaxAutoStore)
        Me.Frame14.Controls.Add(Me.chkSSRepeater)
        Me.Frame14.Controls.Add(Me.chkSSDataSkip)
        Me.Frame14.Controls.Add(Me.cmbSSAtt)
        Me.Frame14.Controls.Add(Me.cmbSSDelay)
        Me.Frame14.Controls.Add(Me.Label37)
        Me.Frame14.Controls.Add(Me.Label2)
        Me.Frame14.Controls.Add(Me.Label35)
        Me.Frame14.Controls.Add(Me.Label36)
        Me.Frame14.Controls.Add(Me.Label4)
        Me.Frame14.Controls.Add(Me.Label7)
        Me.Frame14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame14.Location = New System.Drawing.Point(7, 11)
        Me.Frame14.Name = "Frame14"
        Me.Frame14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame14.Size = New System.Drawing.Size(673, 321)
        Me.Frame14.TabIndex = 153
        Me.Frame14.TabStop = False
        Me.Frame14.Text = "Close Call && Searching Settings"
        '
        '_chkBSC_5
        '
        Me._chkBSC_5.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_5.Checked = True
        Me._chkBSC_5.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkBSC_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_5.Location = New System.Drawing.Point(32, 232)
        Me._chkBSC_5.Name = "_chkBSC_5"
        Me._chkBSC_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_5.Size = New System.Drawing.Size(241, 17)
        Me._chkBSC_5.TabIndex = 181
        Me._chkBSC_5.Text = "Enterprise Hailing Frequency"
        Me._chkBSC_5.UseVisualStyleBackColor = False
        Me._chkBSC_5.Visible = False
        '
        '_chkBSC_0
        '
        Me._chkBSC_0.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_0.Location = New System.Drawing.Point(24, 160)
        Me._chkBSC_0.Name = "_chkBSC_0"
        Me._chkBSC_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_0.Size = New System.Drawing.Size(73, 17)
        Me._chkBSC_0.TabIndex = 180
        Me._chkBSC_0.Text = "Pager"
        Me._chkBSC_0.UseVisualStyleBackColor = False
        '
        '_chkBSC_1
        '
        Me._chkBSC_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_1.Location = New System.Drawing.Point(24, 176)
        Me._chkBSC_1.Name = "_chkBSC_1"
        Me._chkBSC_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_1.Size = New System.Drawing.Size(89, 17)
        Me._chkBSC_1.TabIndex = 179
        Me._chkBSC_1.Text = "Broadcast FM"
        Me._chkBSC_1.UseVisualStyleBackColor = False
        '
        '_chkBSC_2
        '
        Me._chkBSC_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_2.Location = New System.Drawing.Point(24, 192)
        Me._chkBSC_2.Name = "_chkBSC_2"
        Me._chkBSC_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_2.Size = New System.Drawing.Size(89, 17)
        Me._chkBSC_2.TabIndex = 178
        Me._chkBSC_2.Text = "UHF TV"
        Me._chkBSC_2.UseVisualStyleBackColor = False
        '
        '_chkBSC_3
        '
        Me._chkBSC_3.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_3.Location = New System.Drawing.Point(168, 160)
        Me._chkBSC_3.Name = "_chkBSC_3"
        Me._chkBSC_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_3.Size = New System.Drawing.Size(73, 17)
        Me._chkBSC_3.TabIndex = 177
        Me._chkBSC_3.Text = "VHF TV"
        Me._chkBSC_3.UseVisualStyleBackColor = False
        '
        '_chkBSC_4
        '
        Me._chkBSC_4.BackColor = System.Drawing.SystemColors.Control
        Me._chkBSC_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkBSC_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkBSC_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkBSC_4.Location = New System.Drawing.Point(168, 176)
        Me._chkBSC_4.Name = "_chkBSC_4"
        Me._chkBSC_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkBSC_4.Size = New System.Drawing.Size(89, 17)
        Me._chkBSC_4.TabIndex = 176
        Me._chkBSC_4.Text = "NOAA WX"
        Me._chkBSC_4.UseVisualStyleBackColor = False
        '
        'cmbSSHold
        '
        Me.cmbSSHold.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSHold.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSHold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSHold.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSHold.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSHold.Location = New System.Drawing.Point(296, 59)
        Me.cmbSSHold.Name = "cmbSSHold"
        Me.cmbSSHold.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSHold.Size = New System.Drawing.Size(73, 22)
        Me.cmbSSHold.TabIndex = 171
        '
        'cmbSSModMode
        '
        Me.cmbSSModMode.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSModMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSModMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSModMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSModMode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSModMode.Location = New System.Drawing.Point(484, 28)
        Me.cmbSSModMode.Name = "cmbSSModMode"
        Me.cmbSSModMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSModMode.Size = New System.Drawing.Size(73, 22)
        Me.cmbSSModMode.TabIndex = 170
        '
        'cmbSSStep
        '
        Me.cmbSSStep.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSStep.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSStep.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSStep.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSStep.Location = New System.Drawing.Point(96, 60)
        Me.cmbSSStep.Name = "cmbSSStep"
        Me.cmbSSStep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSStep.Size = New System.Drawing.Size(73, 22)
        Me.cmbSSStep.TabIndex = 169
        '
        'chkCCTapeOut
        '
        Me.chkCCTapeOut.BackColor = System.Drawing.SystemColors.Control
        Me.chkCCTapeOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCCTapeOut.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCCTapeOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCCTapeOut.Location = New System.Drawing.Point(168, 96)
        Me.chkCCTapeOut.Name = "chkCCTapeOut"
        Me.chkCCTapeOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCCTapeOut.Size = New System.Drawing.Size(89, 17)
        Me.chkCCTapeOut.TabIndex = 89
        Me.chkCCTapeOut.Text = "Tape Out"
        Me.chkCCTapeOut.UseVisualStyleBackColor = False
        '
        'cmbMaxAutoStore
        '
        Me.cmbMaxAutoStore.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMaxAutoStore.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbMaxAutoStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaxAutoStore.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMaxAutoStore.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMaxAutoStore.Location = New System.Drawing.Point(296, 28)
        Me.cmbMaxAutoStore.Name = "cmbMaxAutoStore"
        Me.cmbMaxAutoStore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbMaxAutoStore.Size = New System.Drawing.Size(73, 22)
        Me.cmbMaxAutoStore.TabIndex = 85
        '
        'chkSSRepeater
        '
        Me.chkSSRepeater.BackColor = System.Drawing.SystemColors.Control
        Me.chkSSRepeater.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSSRepeater.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSRepeater.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSSRepeater.Location = New System.Drawing.Point(24, 112)
        Me.chkSSRepeater.Name = "chkSSRepeater"
        Me.chkSSRepeater.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSSRepeater.Size = New System.Drawing.Size(89, 17)
        Me.chkSSRepeater.TabIndex = 88
        Me.chkSSRepeater.Text = "Repeater Find"
        Me.chkSSRepeater.UseVisualStyleBackColor = False
        '
        'chkSSDataSkip
        '
        Me.chkSSDataSkip.BackColor = System.Drawing.SystemColors.Control
        Me.chkSSDataSkip.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSSDataSkip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSDataSkip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSSDataSkip.Location = New System.Drawing.Point(168, 112)
        Me.chkSSDataSkip.Name = "chkSSDataSkip"
        Me.chkSSDataSkip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSSDataSkip.Size = New System.Drawing.Size(89, 17)
        Me.chkSSDataSkip.TabIndex = 87
        Me.chkSSDataSkip.Text = "Data Skip"
        Me.chkSSDataSkip.UseVisualStyleBackColor = False
        '
        'cmbSSAtt
        '
        Me.cmbSSAtt.BackColor = System.Drawing.SystemColors.Control
        Me.cmbSSAtt.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSAtt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSAtt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbSSAtt.Location = New System.Drawing.Point(24, 96)
        Me.cmbSSAtt.Name = "cmbSSAtt"
        Me.cmbSSAtt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSAtt.Size = New System.Drawing.Size(113, 17)
        Me.cmbSSAtt.TabIndex = 86
        Me.cmbSSAtt.Text = "20dB Attenuation"
        Me.cmbSSAtt.UseVisualStyleBackColor = False
        '
        'cmbSSDelay
        '
        Me.cmbSSDelay.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSDelay.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSDelay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSDelay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSDelay.Location = New System.Drawing.Point(96, 28)
        Me.cmbSSDelay.Name = "cmbSSDelay"
        Me.cmbSSDelay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSDelay.Size = New System.Drawing.Size(73, 22)
        Me.cmbSSDelay.TabIndex = 84
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(16, 136)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(553, 17)
        Me.Label37.TabIndex = 175
        Me.Label37.Text = "Select which bands you want to screen out. Close Call will ignore these bands to " & _
            "avoid nuisance triggering."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(228, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Hold Time"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(416, 31)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(61, 17)
        Me.Label35.TabIndex = 173
        Me.Label35.Text = "Modulation"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(16, 62)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(73, 17)
        Me.Label36.TabIndex = 172
        Me.Label36.Text = "Search Step"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(204, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "&Max Auto Store:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "Delay Time"
        '
        '_optDispMode_TabPage4
        '
        Me._optDispMode_TabPage4.Controls.Add(Me.Frame8)
        Me._optDispMode_TabPage4.Controls.Add(Me.Frame3)
        Me._optDispMode_TabPage4.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage4.Name = "_optDispMode_TabPage4"
        Me._optDispMode_TabPage4.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage4.TabIndex = 4
        Me._optDispMode_TabPage4.Text = "Service Search"
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me.cmbSSHoldTime)
        Me.Frame8.Controls.Add(Me.cmbSSsystem)
        Me.Frame8.Controls.Add(Me.cmbSSDelayTime)
        Me.Frame8.Controls.Add(Me.Frame9)
        Me.Frame8.Controls.Add(Me.cmbSSStartupKey)
        Me.Frame8.Controls.Add(Me.cmbSSQuickKey)
        Me.Frame8.Controls.Add(Me.chkSSTapeOut)
        Me.Frame8.Controls.Add(Me.Label23)
        Me.Frame8.Controls.Add(Me.Label18)
        Me.Frame8.Controls.Add(Label22)
        Me.Frame8.Controls.Add(Me.chkSSAtt)
        Me.Frame8.Controls.Add(Me.Label21)
        Me.Frame8.Controls.Add(Me.chkSrchLO)
        Me.Frame8.Controls.Add(Me.Label20)
        Me.Frame8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(283, 13)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(369, 317)
        Me.Frame8.TabIndex = 133
        Me.Frame8.TabStop = False
        Me.Frame8.Text = "Service Search Settings (changes are applied immediatley)"
        '
        'cmbSSHoldTime
        '
        Me.cmbSSHoldTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSHoldTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSHoldTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSHoldTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSHoldTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSHoldTime.Location = New System.Drawing.Point(262, 76)
        Me.cmbSSHoldTime.Name = "cmbSSHoldTime"
        Me.cmbSSHoldTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSHoldTime.Size = New System.Drawing.Size(57, 22)
        Me.cmbSSHoldTime.TabIndex = 98
        '
        'cmbSSsystem
        '
        Me.cmbSSsystem.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSsystem.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSsystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSsystem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSsystem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSsystem.Location = New System.Drawing.Point(16, 40)
        Me.cmbSSsystem.Name = "cmbSSsystem"
        Me.cmbSSsystem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSsystem.Size = New System.Drawing.Size(153, 22)
        Me.cmbSSsystem.TabIndex = 96
        '
        'cmbSSDelayTime
        '
        Me.cmbSSDelayTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSDelayTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSDelayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSDelayTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSDelayTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSDelayTime.Location = New System.Drawing.Point(70, 76)
        Me.cmbSSDelayTime.Name = "cmbSSDelayTime"
        Me.cmbSSDelayTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSDelayTime.Size = New System.Drawing.Size(65, 22)
        Me.cmbSSDelayTime.TabIndex = 97
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.SystemColors.Control
        Me.Frame9.Controls.Add(Me.txtSSPNumTag)
        Me.Frame9.Controls.Add(Me.cmbSSPP25Wait)
        Me.Frame9.Controls.Add(Label44)
        Me.Frame9.Controls.Add(Label33)
        Me.Frame9.Controls.Add(Me.chkSSPDigitalAGC)
        Me.Frame9.Controls.Add(Me.chkSSPAnalogAGC)
        Me.Frame9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(10, 176)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame9.Size = New System.Drawing.Size(348, 125)
        Me.Frame9.TabIndex = 135
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "XT Options"
        '
        'txtSSPNumTag
        '
        Me.txtSSPNumTag.AcceptsReturn = True
        Me.txtSSPNumTag.BackColor = System.Drawing.SystemColors.Window
        Me.txtSSPNumTag.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSSPNumTag.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSPNumTag.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSSPNumTag.Location = New System.Drawing.Point(193, 19)
        Me.txtSSPNumTag.MaxLength = 0
        Me.txtSSPNumTag.Name = "txtSSPNumTag"
        Me.txtSSPNumTag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSSPNumTag.Size = New System.Drawing.Size(57, 20)
        Me.txtSSPNumTag.TabIndex = 397
        '
        'cmbSSPP25Wait
        '
        Me.cmbSSPP25Wait.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSPP25Wait.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSPP25Wait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSPP25Wait.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSPP25Wait.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSPP25Wait.Location = New System.Drawing.Point(194, 44)
        Me.cmbSSPP25Wait.Name = "cmbSSPP25Wait"
        Me.cmbSSPP25Wait.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSPP25Wait.Size = New System.Drawing.Size(57, 22)
        Me.cmbSSPP25Wait.TabIndex = 396
        '
        'chkSSPDigitalAGC
        '
        Me.chkSSPDigitalAGC.AutoSize = True
        Me.chkSSPDigitalAGC.BackColor = System.Drawing.SystemColors.Control
        Me.chkSSPDigitalAGC.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSSPDigitalAGC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSPDigitalAGC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSSPDigitalAGC.Location = New System.Drawing.Point(12, 43)
        Me.chkSSPDigitalAGC.Name = "chkSSPDigitalAGC"
        Me.chkSSPDigitalAGC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSSPDigitalAGC.Size = New System.Drawing.Size(79, 18)
        Me.chkSSPDigitalAGC.TabIndex = 104
        Me.chkSSPDigitalAGC.Text = "&Digital AGC"
        Me.chkSSPDigitalAGC.UseVisualStyleBackColor = False
        '
        'chkSSPAnalogAGC
        '
        Me.chkSSPAnalogAGC.AutoSize = True
        Me.chkSSPAnalogAGC.BackColor = System.Drawing.SystemColors.Control
        Me.chkSSPAnalogAGC.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSSPAnalogAGC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSPAnalogAGC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSSPAnalogAGC.Location = New System.Drawing.Point(12, 20)
        Me.chkSSPAnalogAGC.Name = "chkSSPAnalogAGC"
        Me.chkSSPAnalogAGC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSSPAnalogAGC.Size = New System.Drawing.Size(85, 18)
        Me.chkSSPAnalogAGC.TabIndex = 103
        Me.chkSSPAnalogAGC.Text = "&Analog AGC"
        Me.chkSSPAnalogAGC.UseVisualStyleBackColor = False
        '
        'cmbSSStartupKey
        '
        Me.cmbSSStartupKey.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSStartupKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSStartupKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSStartupKey.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSStartupKey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSStartupKey.Location = New System.Drawing.Point(262, 100)
        Me.cmbSSStartupKey.Name = "cmbSSStartupKey"
        Me.cmbSSStartupKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSStartupKey.Size = New System.Drawing.Size(57, 22)
        Me.cmbSSStartupKey.TabIndex = 100
        '
        'cmbSSQuickKey
        '
        Me.cmbSSQuickKey.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSSQuickKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSSQuickKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSSQuickKey.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSQuickKey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSSQuickKey.Location = New System.Drawing.Point(70, 100)
        Me.cmbSSQuickKey.Name = "cmbSSQuickKey"
        Me.cmbSSQuickKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSSQuickKey.Size = New System.Drawing.Size(65, 22)
        Me.cmbSSQuickKey.TabIndex = 99
        '
        'chkSSTapeOut
        '
        Me.chkSSTapeOut.BackColor = System.Drawing.SystemColors.Control
        Me.chkSSTapeOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSSTapeOut.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSTapeOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSSTapeOut.Location = New System.Drawing.Point(205, 146)
        Me.chkSSTapeOut.Name = "chkSSTapeOut"
        Me.chkSSTapeOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSSTapeOut.Size = New System.Drawing.Size(121, 25)
        Me.chkSSTapeOut.TabIndex = 103
        Me.chkSSTapeOut.Text = "&Enable Tape Out"
        Me.chkSSTapeOut.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(195, 102)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(65, 17)
        Me.Label23.TabIndex = 139
        Me.Label23.Text = "Startup Key"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(16, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(233, 17)
        Me.Label18.TabIndex = 134
        Me.Label18.Text = "Choose Which Service Search To Set:"
        '
        'chkSSAtt
        '
        Me.chkSSAtt.BackColor = System.Drawing.SystemColors.Control
        Me.chkSSAtt.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSSAtt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSAtt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSSAtt.Location = New System.Drawing.Point(102, 146)
        Me.chkSSAtt.Name = "chkSSAtt"
        Me.chkSSAtt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSSAtt.Size = New System.Drawing.Size(105, 25)
        Me.chkSSAtt.TabIndex = 102
        Me.chkSSAtt.Text = "Atten&uation"
        Me.chkSSAtt.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(203, 79)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(54, 17)
        Me.Label21.TabIndex = 137
        Me.Label21.Text = "Hold Time"
        '
        'chkSrchLO
        '
        Me.chkSrchLO.BackColor = System.Drawing.SystemColors.Control
        Me.chkSrchLO.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSrchLO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSrchLO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSrchLO.Location = New System.Drawing.Point(13, 146)
        Me.chkSrchLO.Name = "chkSrchLO"
        Me.chkSrchLO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSrchLO.Size = New System.Drawing.Size(97, 25)
        Me.chkSrchLO.TabIndex = 101
        Me.chkSrchLO.Text = "Lockout"
        Me.chkSrchLO.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(8, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(59, 14)
        Me.Label20.TabIndex = 136
        Me.Label20.Text = "Delay Time"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Label53)
        Me.Frame3.Controls.Add(Me._cmbSearchKey_5)
        Me.Frame3.Controls.Add(Me._cmbSearchKey_4)
        Me.Frame3.Controls.Add(Me._cmbSearchKey_3)
        Me.Frame3.Controls.Add(Me._cmbSearchKey_2)
        Me.Frame3.Controls.Add(Me._cmbSearchKey_1)
        Me.Frame3.Controls.Add(Me._cmbSearchKey_0)
        Me.Frame3.Controls.Add(Me._Label17_6)
        Me.Frame3.Controls.Add(Me._Label17_5)
        Me.Frame3.Controls.Add(Me._Label17_4)
        Me.Frame3.Controls.Add(Me._Label17_3)
        Me.Frame3.Controls.Add(Me._Label17_2)
        Me.Frame3.Controls.Add(Me._Label17_0)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(14, 12)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(249, 318)
        Me.Frame3.TabIndex = 126
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Search Key Assignments"
        '
        '_cmbSearchKey_5
        '
        Me._cmbSearchKey_5.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSearchKey_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSearchKey_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSearchKey_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSearchKey_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbSearchKey_5.Location = New System.Drawing.Point(96, 204)
        Me._cmbSearchKey_5.Name = "_cmbSearchKey_5"
        Me._cmbSearchKey_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSearchKey_5.Size = New System.Drawing.Size(137, 22)
        Me._cmbSearchKey_5.TabIndex = 95
        '
        '_cmbSearchKey_4
        '
        Me._cmbSearchKey_4.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSearchKey_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSearchKey_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSearchKey_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSearchKey_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbSearchKey_4.Location = New System.Drawing.Point(96, 171)
        Me._cmbSearchKey_4.Name = "_cmbSearchKey_4"
        Me._cmbSearchKey_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSearchKey_4.Size = New System.Drawing.Size(137, 22)
        Me._cmbSearchKey_4.TabIndex = 94
        '
        '_cmbSearchKey_3
        '
        Me._cmbSearchKey_3.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSearchKey_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSearchKey_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSearchKey_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSearchKey_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbSearchKey_3.Location = New System.Drawing.Point(96, 137)
        Me._cmbSearchKey_3.Name = "_cmbSearchKey_3"
        Me._cmbSearchKey_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSearchKey_3.Size = New System.Drawing.Size(137, 22)
        Me._cmbSearchKey_3.TabIndex = 93
        '
        '_cmbSearchKey_2
        '
        Me._cmbSearchKey_2.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSearchKey_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSearchKey_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSearchKey_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSearchKey_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbSearchKey_2.Location = New System.Drawing.Point(96, 104)
        Me._cmbSearchKey_2.Name = "_cmbSearchKey_2"
        Me._cmbSearchKey_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSearchKey_2.Size = New System.Drawing.Size(137, 22)
        Me._cmbSearchKey_2.TabIndex = 92
        '
        '_cmbSearchKey_1
        '
        Me._cmbSearchKey_1.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSearchKey_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSearchKey_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSearchKey_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSearchKey_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbSearchKey_1.Location = New System.Drawing.Point(96, 70)
        Me._cmbSearchKey_1.Name = "_cmbSearchKey_1"
        Me._cmbSearchKey_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSearchKey_1.Size = New System.Drawing.Size(137, 22)
        Me._cmbSearchKey_1.TabIndex = 91
        '
        '_cmbSearchKey_0
        '
        Me._cmbSearchKey_0.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSearchKey_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSearchKey_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSearchKey_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSearchKey_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbSearchKey_0.Location = New System.Drawing.Point(96, 36)
        Me._cmbSearchKey_0.Name = "_cmbSearchKey_0"
        Me._cmbSearchKey_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSearchKey_0.Size = New System.Drawing.Size(137, 22)
        Me._cmbSearchKey_0.TabIndex = 90
        '
        '_Label17_6
        '
        Me._Label17_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label17_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label17_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label17_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label17_6.Location = New System.Drawing.Point(16, 74)
        Me._Label17_6.Name = "_Label17_6"
        Me._Label17_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label17_6.Size = New System.Drawing.Size(73, 17)
        Me._Label17_6.TabIndex = 132
        Me._Label17_6.Text = "Search Key 2"
        '
        '_Label17_5
        '
        Me._Label17_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label17_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label17_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label17_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label17_5.Location = New System.Drawing.Point(16, 108)
        Me._Label17_5.Name = "_Label17_5"
        Me._Label17_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label17_5.Size = New System.Drawing.Size(73, 17)
        Me._Label17_5.TabIndex = 131
        Me._Label17_5.Text = "Search Key 3"
        '
        '_Label17_4
        '
        Me._Label17_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label17_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label17_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label17_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label17_4.Location = New System.Drawing.Point(16, 141)
        Me._Label17_4.Name = "_Label17_4"
        Me._Label17_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label17_4.Size = New System.Drawing.Size(73, 17)
        Me._Label17_4.TabIndex = 130
        Me._Label17_4.Text = "Search Key 4"
        '
        '_Label17_3
        '
        Me._Label17_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label17_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label17_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label17_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label17_3.Location = New System.Drawing.Point(16, 175)
        Me._Label17_3.Name = "_Label17_3"
        Me._Label17_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label17_3.Size = New System.Drawing.Size(73, 17)
        Me._Label17_3.TabIndex = 129
        Me._Label17_3.Text = "Search Key 5"
        '
        '_Label17_2
        '
        Me._Label17_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label17_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label17_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label17_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label17_2.Location = New System.Drawing.Point(16, 208)
        Me._Label17_2.Name = "_Label17_2"
        Me._Label17_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label17_2.Size = New System.Drawing.Size(73, 17)
        Me._Label17_2.TabIndex = 128
        Me._Label17_2.Text = "Search Key 6"
        '
        '_Label17_0
        '
        Me._Label17_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label17_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label17_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label17_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label17_0.Location = New System.Drawing.Point(16, 40)
        Me._Label17_0.Name = "_Label17_0"
        Me._Label17_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label17_0.Size = New System.Drawing.Size(73, 17)
        Me._Label17_0.TabIndex = 127
        Me._Label17_0.Text = "Search Key 1"
        '
        '_optDispMode_TabPage3
        '
        Me._optDispMode_TabPage3.Controls.Add(Me.GroupBox2)
        Me._optDispMode_TabPage3.Controls.Add(Me.Frame7)
        Me._optDispMode_TabPage3.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage3.Name = "_optDispMode_TabPage3"
        Me._optDispMode_TabPage3.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage3.TabIndex = 3
        Me._optDispMode_TabPage3.Text = "Frequencies"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.grdGIF)
        Me.GroupBox2.Controls.Add(Me.cmdClearGIF)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(352, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(328, 353)
        Me.GroupBox2.TabIndex = 151
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Global IF Exchange (XT Scanners only)"
        '
        'grdGIF
        '
        Me.grdGIF.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdGIF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGIF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.grdGIF.Location = New System.Drawing.Point(11, 21)
        Me.grdGIF.Name = "grdGIF"
        Me.grdGIF.Size = New System.Drawing.Size(194, 326)
        Me.grdGIF.TabIndex = 109
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Frequency"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'cmdClearGIF
        '
        Me.cmdClearGIF.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearGIF.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearGIF.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearGIF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearGIF.Location = New System.Drawing.Point(215, 22)
        Me.cmdClearGIF.Name = "cmdClearGIF"
        Me.cmdClearGIF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearGIF.Size = New System.Drawing.Size(105, 25)
        Me.cmdClearGIF.TabIndex = 108
        Me.cmdClearGIF.Text = "Clear &All..."
        Me.cmdClearGIF.UseVisualStyleBackColor = True
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.SystemColors.Control
        Me.Frame7.Controls.Add(Me.grdFreqLO)
        Me.Frame7.Controls.Add(Me.cmdClearLOFreq)
        Me.Frame7.Controls.Add(Me.cmdClearLOFreqDup)
        Me.Frame7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(9, 12)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(328, 353)
        Me.Frame7.TabIndex = 150
        Me.Frame7.TabStop = False
        Me.Frame7.Text = "Global Frequency Lockouts"
        '
        'grdFreqLO
        '
        Me.grdFreqLO.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdFreqLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFreqLO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtFreqLO})
        Me.grdFreqLO.Location = New System.Drawing.Point(11, 21)
        Me.grdFreqLO.Name = "grdFreqLO"
        Me.grdFreqLO.Size = New System.Drawing.Size(194, 326)
        Me.grdFreqLO.TabIndex = 109
        '
        'txtFreqLO
        '
        Me.txtFreqLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtFreqLO.HeaderText = "Frequency"
        Me.txtFreqLO.MaxInputLength = 10
        Me.txtFreqLO.Name = "txtFreqLO"
        '
        'cmdClearLOFreq
        '
        Me.cmdClearLOFreq.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearLOFreq.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearLOFreq.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearLOFreq.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearLOFreq.Location = New System.Drawing.Point(215, 22)
        Me.cmdClearLOFreq.Name = "cmdClearLOFreq"
        Me.cmdClearLOFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearLOFreq.Size = New System.Drawing.Size(105, 25)
        Me.cmdClearLOFreq.TabIndex = 108
        Me.cmdClearLOFreq.Text = "Clea&r All..."
        Me.cmdClearLOFreq.UseVisualStyleBackColor = True
        '
        'cmdClearLOFreqDup
        '
        Me.cmdClearLOFreqDup.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearLOFreqDup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearLOFreqDup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearLOFreqDup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearLOFreqDup.Location = New System.Drawing.Point(215, 50)
        Me.cmdClearLOFreqDup.Name = "cmdClearLOFreqDup"
        Me.cmdClearLOFreqDup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearLOFreqDup.Size = New System.Drawing.Size(105, 25)
        Me.cmdClearLOFreqDup.TabIndex = 107
        Me.cmdClearLOFreqDup.Text = "C&lear Duplicate"
        Me.cmdClearLOFreqDup.UseVisualStyleBackColor = True
        Me.cmdClearLOFreqDup.Visible = False
        '
        '_optDispMode_TabPage2
        '
        Me._optDispMode_TabPage2.Controls.Add(Me.CheckBox1)
        Me._optDispMode_TabPage2.Controls.Add(Me.grdCust)
        Me._optDispMode_TabPage2.Controls.Add(Me.cmdCSDefault)
        Me._optDispMode_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage2.Name = "_optDispMode_TabPage2"
        Me._optDispMode_TabPage2.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage2.TabIndex = 2
        Me._optDispMode_TabPage2.Text = "Custom Search"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(10, 297)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(144, 18)
        Me.CheckBox1.TabIndex = 149
        Me.CheckBox1.Text = "Show &advanced options"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'grdCust
        '
        Me.grdCust.AllowUserToAddRows = False
        Me.grdCust.AllowUserToDeleteRows = False
        Me.grdCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grdCust.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCust.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdCustName, Me.grdCustLowLimit, Me.grdCustHiLimit, Me.grdCustDelay, Me.grdCustLO, Me.grdCustEnabled, Me.grdCustHoldTime, Me.grdCustSS, Me.grdCustAtt, Me.grdCustDataSkip, Me.grdCustCtlChn, Me.grdCustQK, Me.grdCustStartupKey, Me.grdCustModulation, Me.grdCustNumTag, Me.grdCustAGCA, Me.grdCustAGCD, Me.grdCustP25Wait, Me.grdCustTapeOut})
        Me.grdCust.Location = New System.Drawing.Point(4, 6)
        Me.grdCust.Name = "grdCust"
        Me.grdCust.RowHeadersVisible = False
        Me.grdCust.Size = New System.Drawing.Size(696, 275)
        Me.grdCust.TabIndex = 148
        '
        'grdCustName
        '
        Me.grdCustName.HeaderText = "Name                       "
        Me.grdCustName.MaxInputLength = 16
        Me.grdCustName.Name = "grdCustName"
        Me.grdCustName.Width = 79
        '
        'grdCustLowLimit
        '
        Me.grdCustLowLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.NullValue = Nothing
        Me.grdCustLowLimit.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdCustLowLimit.HeaderText = "Low Limit"
        Me.grdCustLowLimit.MaxInputLength = 9
        Me.grdCustLowLimit.Name = "grdCustLowLimit"
        Me.grdCustLowLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdCustLowLimit.Width = 53
        '
        'grdCustHiLimit
        '
        Me.grdCustHiLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.grdCustHiLimit.HeaderText = "Hi Limit"
        Me.grdCustHiLimit.MaxInputLength = 9
        Me.grdCustHiLimit.Name = "grdCustHiLimit"
        Me.grdCustHiLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdCustHiLimit.Width = 42
        '
        'grdCustDelay
        '
        Me.grdCustDelay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.grdCustDelay.HeaderText = "Delay"
        Me.grdCustDelay.Name = "grdCustDelay"
        Me.grdCustDelay.ToolTipText = "Non XT selects 0-5 Only"
        Me.grdCustDelay.Width = 40
        '
        'grdCustLO
        '
        Me.grdCustLO.HeaderText = "Lockout"
        Me.grdCustLO.Name = "grdCustLO"
        Me.grdCustLO.Width = 51
        '
        'grdCustEnabled
        '
        Me.grdCustEnabled.HeaderText = "Enabled"
        Me.grdCustEnabled.Name = "grdCustEnabled"
        Me.grdCustEnabled.Width = 51
        '
        'grdCustHoldTime
        '
        Me.grdCustHoldTime.HeaderText = "Hold Time"
        Me.grdCustHoldTime.Name = "grdCustHoldTime"
        Me.grdCustHoldTime.Width = 53
        '
        'grdCustSS
        '
        Me.grdCustSS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.grdCustSS.DropDownWidth = 50
        Me.grdCustSS.HeaderText = "Step"
        Me.grdCustSS.Name = "grdCustSS"
        Me.grdCustSS.Width = 60
        '
        'grdCustAtt
        '
        Me.grdCustAtt.HeaderText = "Att"
        Me.grdCustAtt.Name = "grdCustAtt"
        Me.grdCustAtt.Width = 27
        '
        'grdCustDataSkip
        '
        Me.grdCustDataSkip.HeaderText = "Data Skip"
        Me.grdCustDataSkip.Name = "grdCustDataSkip"
        Me.grdCustDataSkip.Width = 52
        '
        'grdCustCtlChn
        '
        Me.grdCustCtlChn.HeaderText = "C-Chan"
        Me.grdCustCtlChn.Name = "grdCustCtlChn"
        Me.grdCustCtlChn.Width = 49
        '
        'grdCustQK
        '
        Me.grdCustQK.HeaderText = "Quick Key"
        Me.grdCustQK.Name = "grdCustQK"
        Me.grdCustQK.Width = 56
        '
        'grdCustStartupKey
        '
        Me.grdCustStartupKey.HeaderText = "Startup Key"
        Me.grdCustStartupKey.Name = "grdCustStartupKey"
        Me.grdCustStartupKey.Width = 63
        '
        'grdCustModulation
        '
        Me.grdCustModulation.HeaderText = "Modulation"
        Me.grdCustModulation.Name = "grdCustModulation"
        Me.grdCustModulation.Width = 64
        '
        'grdCustNumTag
        '
        Me.grdCustNumTag.HeaderText = "Num Tag"
        Me.grdCustNumTag.MaxInputLength = 4
        Me.grdCustNumTag.Name = "grdCustNumTag"
        Me.grdCustNumTag.Width = 68
        '
        'grdCustAGCA
        '
        Me.grdCustAGCA.HeaderText = "Analog AGC"
        Me.grdCustAGCA.Name = "grdCustAGCA"
        Me.grdCustAGCA.ToolTipText = "396XT Only"
        Me.grdCustAGCA.Width = 65
        '
        'grdCustAGCD
        '
        Me.grdCustAGCD.HeaderText = "Digital AGC"
        Me.grdCustAGCD.Name = "grdCustAGCD"
        Me.grdCustAGCD.ToolTipText = "396XT Only"
        Me.grdCustAGCD.Width = 60
        '
        'grdCustP25Wait
        '
        Me.grdCustP25Wait.HeaderText = "P25 Wait Time"
        Me.grdCustP25Wait.Name = "grdCustP25Wait"
        Me.grdCustP25Wait.ToolTipText = "396XT Only"
        Me.grdCustP25Wait.Width = 72
        '
        'grdCustTapeOut
        '
        Me.grdCustTapeOut.HeaderText = "Rec Out"
        Me.grdCustTapeOut.Name = "grdCustTapeOut"
        Me.grdCustTapeOut.Width = 32
        '
        'cmdCSDefault
        '
        Me.cmdCSDefault.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCSDefault.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCSDefault.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCSDefault.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCSDefault.Location = New System.Drawing.Point(616, 334)
        Me.cmdCSDefault.Name = "cmdCSDefault"
        Me.cmdCSDefault.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCSDefault.Size = New System.Drawing.Size(81, 25)
        Me.cmdCSDefault.TabIndex = 16
        Me.cmdCSDefault.Text = "&Reset..."
        Me.cmdCSDefault.UseVisualStyleBackColor = True
        '
        '_optDispMode_TabPage1
        '
        Me._optDispMode_TabPage1.Controls.Add(Me.Frame2)
        Me._optDispMode_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage1.Name = "_optDispMode_TabPage1"
        Me._optDispMode_TabPage1.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage1.TabIndex = 1
        Me._optDispMode_TabPage1.Text = "Close Call"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Frame12)
        Me.Frame2.Controls.Add(Me.Frame11)
        Me.Frame2.Controls.Add(Me.Frame10)
        Me.Frame2.Controls.Add(Me.Frame4)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 6)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(673, 337)
        Me.Frame2.TabIndex = 115
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Settings"
        '
        'Frame12
        '
        Me.Frame12.BackColor = System.Drawing.SystemColors.Control
        Me.Frame12.Controls.Add(Me.optCCCodeSearch2)
        Me.Frame12.Controls.Add(Me.optCCCodeSearch1)
        Me.Frame12.Controls.Add(Me.optCCCodeSearch0)
        Me.Frame12.Controls.Add(Label30)
        Me.Frame12.Controls.Add(Label52)
        Me.Frame12.Controls.Add(Me.chkCCAGCD)
        Me.Frame12.Controls.Add(Me.chkCCAGCA)
        Me.Frame12.Controls.Add(Me.cmbCCPauseTime)
        Me.Frame12.Controls.Add(Me.cmbCCQuickKey)
        Me.Frame12.Controls.Add(Me.chkCCHits)
        Me.Frame12.Controls.Add(Label3)
        Me.Frame12.Controls.Add(Me.Label26)
        Me.Frame12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame12.Location = New System.Drawing.Point(8, 120)
        Me.Frame12.Name = "Frame12"
        Me.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame12.Size = New System.Drawing.Size(201, 212)
        Me.Frame12.TabIndex = 146
        Me.Frame12.TabStop = False
        Me.Frame12.Text = "General"
        '
        'optCCCodeSearch1
        '
        Me.optCCCodeSearch1.AutoSize = True
        Me.optCCCodeSearch1.Location = New System.Drawing.Point(6, 106)
        Me.optCCCodeSearch1.Name = "optCCCodeSearch1"
        Me.optCCCodeSearch1.Size = New System.Drawing.Size(83, 18)
        Me.optCCCodeSearch1.TabIndex = 371
        Me.optCCCodeSearch1.TabStop = True
        Me.optCCCodeSearch1.Text = "C&TCSS/DCS"
        Me.optCCCodeSearch1.UseVisualStyleBackColor = True
        '
        'optCCCodeSearch0
        '
        Me.optCCCodeSearch0.AutoSize = True
        Me.optCCCodeSearch0.Location = New System.Drawing.Point(6, 141)
        Me.optCCCodeSearch0.Name = "optCCCodeSearch0"
        Me.optCCCodeSearch0.Size = New System.Drawing.Size(41, 18)
        Me.optCCCodeSearch0.TabIndex = 370
        Me.optCCCodeSearch0.TabStop = True
        Me.optCCCodeSearch0.Text = "&Off"
        Me.optCCCodeSearch0.UseVisualStyleBackColor = True
        '
        'chkCCAGCD
        '
        Me.chkCCAGCD.AutoSize = True
        Me.chkCCAGCD.Location = New System.Drawing.Point(6, 191)
        Me.chkCCAGCD.Name = "chkCCAGCD"
        Me.chkCCAGCD.Size = New System.Drawing.Size(101, 18)
        Me.chkCCAGCD.TabIndex = 154
        Me.chkCCAGCD.Text = "Use Digi&tal AGC"
        Me.chkCCAGCD.UseVisualStyleBackColor = True
        '
        'chkCCAGCA
        '
        Me.chkCCAGCA.AutoSize = True
        Me.chkCCAGCA.Location = New System.Drawing.Point(6, 172)
        Me.chkCCAGCA.Name = "chkCCAGCA"
        Me.chkCCAGCA.Size = New System.Drawing.Size(106, 18)
        Me.chkCCAGCA.TabIndex = 153
        Me.chkCCAGCA.Text = "Use Analo&g AGC"
        Me.chkCCAGCA.UseVisualStyleBackColor = True
        '
        'cmbCCPauseTime
        '
        Me.cmbCCPauseTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCCPauseTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCCPauseTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCCPauseTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCCPauseTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCCPauseTime.Location = New System.Drawing.Point(96, 17)
        Me.cmbCCPauseTime.Name = "cmbCCPauseTime"
        Me.cmbCCPauseTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCCPauseTime.Size = New System.Drawing.Size(58, 22)
        Me.cmbCCPauseTime.TabIndex = 31
        '
        'cmbCCQuickKey
        '
        Me.cmbCCQuickKey.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCCQuickKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCCQuickKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCCQuickKey.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCCQuickKey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCCQuickKey.Location = New System.Drawing.Point(96, 45)
        Me.cmbCCQuickKey.Name = "cmbCCQuickKey"
        Me.cmbCCQuickKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCCQuickKey.Size = New System.Drawing.Size(58, 22)
        Me.cmbCCQuickKey.TabIndex = 32
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(8, 45)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(73, 29)
        Me.Label26.TabIndex = 151
        Me.Label26.Text = "CC Quick Key"
        '
        'Frame11
        '
        Me.Frame11.BackColor = System.Drawing.SystemColors.Control
        Me.Frame11.Controls.Add(Label27)
        Me.Frame11.Controls.Add(Label16)
        Me.Frame11.Controls.Add(Me.cmbCCAltCol)
        Me.Frame11.Controls.Add(Me.cmbCCAltPat)
        Me.Frame11.Controls.Add(Label6)
        Me.Frame11.Controls.Add(Me.sldCCVol)
        Me.Frame11.Controls.Add(Me._optAlertMode_0)
        Me.Frame11.Controls.Add(Me._optAlertMode_1)
        Me.Frame11.Controls.Add(Me._optAlertMode_2)
        Me.Frame11.Controls.Add(Me._optAlertMode_3)
        Me.Frame11.Controls.Add(Me.cmbCloseCallAlertType)
        Me.Frame11.Controls.Add(Me.Label49)
        Me.Frame11.Controls.Add(Label15)
        Me.Frame11.Controls.Add(Me.Label25)
        Me.Frame11.Controls.Add(Me.Label24)
        Me.Frame11.Controls.Add(Me.Label19)
        Me.Frame11.Controls.Add(Me.Label5)
        Me.Frame11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame11.Location = New System.Drawing.Point(216, 16)
        Me.Frame11.Name = "Frame11"
        Me.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame11.Size = New System.Drawing.Size(197, 318)
        Me.Frame11.TabIndex = 141
        Me.Frame11.TabStop = False
        Me.Frame11.Text = "Alert"
        '
        'cmbCCAltCol
        '
        Me.cmbCCAltCol.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCCAltCol.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCCAltCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCCAltCol.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCCAltCol.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCCAltCol.Location = New System.Drawing.Point(76, 279)
        Me.cmbCCAltCol.Name = "cmbCCAltCol"
        Me.cmbCCAltCol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCCAltCol.Size = New System.Drawing.Size(81, 22)
        Me.cmbCCAltCol.TabIndex = 376
        '
        'cmbCCAltPat
        '
        Me.cmbCCAltPat.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCCAltPat.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCCAltPat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCCAltPat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCCAltPat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCCAltPat.Location = New System.Drawing.Point(76, 252)
        Me.cmbCCAltPat.Name = "cmbCCAltPat"
        Me.cmbCCAltPat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCCAltPat.Size = New System.Drawing.Size(81, 22)
        Me.cmbCCAltPat.TabIndex = 375
        '
        'sldCCVol
        '
        Me.sldCCVol.Location = New System.Drawing.Point(37, 62)
        Me.sldCCVol.Maximum = 15
        Me.sldCCVol.Name = "sldCCVol"
        Me.sldCCVol.Size = New System.Drawing.Size(120, 45)
        Me.sldCCVol.TabIndex = 373
        '
        '_optAlertMode_0
        '
        Me._optAlertMode_0.BackColor = System.Drawing.SystemColors.Control
        Me._optAlertMode_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optAlertMode_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optAlertMode_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optAlertMode_0.Location = New System.Drawing.Point(8, 152)
        Me._optAlertMode_0.Name = "_optAlertMode_0"
        Me._optAlertMode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optAlertMode_0.Size = New System.Drawing.Size(61, 21)
        Me._optAlertMode_0.TabIndex = 371
        Me._optAlertMode_0.TabStop = True
        Me._optAlertMode_0.Text = "None"
        Me._optAlertMode_0.UseVisualStyleBackColor = False
        '
        '_optAlertMode_1
        '
        Me._optAlertMode_1.BackColor = System.Drawing.SystemColors.Control
        Me._optAlertMode_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optAlertMode_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optAlertMode_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optAlertMode_1.Location = New System.Drawing.Point(8, 170)
        Me._optAlertMode_1.Name = "_optAlertMode_1"
        Me._optAlertMode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optAlertMode_1.Size = New System.Drawing.Size(50, 21)
        Me._optAlertMode_1.TabIndex = 370
        Me._optAlertMode_1.TabStop = True
        Me._optAlertMode_1.Text = "Tone"
        Me._optAlertMode_1.UseVisualStyleBackColor = False
        '
        '_optAlertMode_2
        '
        Me._optAlertMode_2.BackColor = System.Drawing.SystemColors.Control
        Me._optAlertMode_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optAlertMode_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optAlertMode_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optAlertMode_2.Location = New System.Drawing.Point(69, 153)
        Me._optAlertMode_2.Name = "_optAlertMode_2"
        Me._optAlertMode_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optAlertMode_2.Size = New System.Drawing.Size(53, 21)
        Me._optAlertMode_2.TabIndex = 369
        Me._optAlertMode_2.TabStop = True
        Me._optAlertMode_2.Text = "Light"
        Me._optAlertMode_2.UseVisualStyleBackColor = False
        '
        '_optAlertMode_3
        '
        Me._optAlertMode_3.BackColor = System.Drawing.SystemColors.Control
        Me._optAlertMode_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._optAlertMode_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optAlertMode_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optAlertMode_3.Location = New System.Drawing.Point(69, 170)
        Me._optAlertMode_3.Name = "_optAlertMode_3"
        Me._optAlertMode_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optAlertMode_3.Size = New System.Drawing.Size(93, 21)
        Me._optAlertMode_3.TabIndex = 368
        Me._optAlertMode_3.TabStop = True
        Me._optAlertMode_3.Text = "Tone && Light"
        Me._optAlertMode_3.UseVisualStyleBackColor = False
        '
        'cmbCloseCallAlertType
        '
        Me.cmbCloseCallAlertType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCloseCallAlertType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCloseCallAlertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCloseCallAlertType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCloseCallAlertType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCloseCallAlertType.Location = New System.Drawing.Point(96, 16)
        Me.cmbCloseCallAlertType.Name = "cmbCloseCallAlertType"
        Me.cmbCloseCallAlertType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCloseCallAlertType.Size = New System.Drawing.Size(81, 22)
        Me.cmbCloseCallAlertType.TabIndex = 29
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label49.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(2, 134)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label49.Size = New System.Drawing.Size(59, 14)
        Me.Label49.TabIndex = 372
        Me.Label49.Text = "Alert Mode"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(166, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(27, 14)
        Me.Label25.TabIndex = 145
        Me.Label25.Text = "Max"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(8, 70)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(33, 17)
        Me.Label24.TabIndex = 144
        Me.Label24.Text = "Auto"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(63, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(75, 17)
        Me.Label19.TabIndex = 143
        Me.Label19.Text = "Alert Volume"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(60, 32)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Alert Beep (0=OFF):"
        '
        'Frame10
        '
        Me.Frame10.BackColor = System.Drawing.SystemColors.Control
        Me.Frame10.Controls.Add(Me.chkCloseCallOverride)
        Me.Frame10.Controls.Add(Me._optCCMode_2)
        Me.Frame10.Controls.Add(Me._optCCMode_1)
        Me.Frame10.Controls.Add(Me._optCCMode_0)
        Me.Frame10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame10.Location = New System.Drawing.Point(8, 16)
        Me.Frame10.Name = "Frame10"
        Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame10.Size = New System.Drawing.Size(201, 97)
        Me.Frame10.TabIndex = 140
        Me.Frame10.TabStop = False
        Me.Frame10.Text = "Mode"
        '
        '_optCCMode_2
        '
        Me._optCCMode_2.BackColor = System.Drawing.SystemColors.Control
        Me._optCCMode_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optCCMode_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optCCMode_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optCCMode_2.Location = New System.Drawing.Point(16, 48)
        Me._optCCMode_2.Name = "_optCCMode_2"
        Me._optCCMode_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optCCMode_2.Size = New System.Drawing.Size(127, 17)
        Me._optCCMode_2.TabIndex = 20
        Me._optCCMode_2.TabStop = True
        Me._optCCMode_2.Text = "On - Do not Disturb"
        Me._optCCMode_2.UseVisualStyleBackColor = False
        '
        '_optCCMode_1
        '
        Me._optCCMode_1.BackColor = System.Drawing.SystemColors.Control
        Me._optCCMode_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optCCMode_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optCCMode_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optCCMode_1.Location = New System.Drawing.Point(16, 32)
        Me._optCCMode_1.Name = "_optCCMode_1"
        Me._optCCMode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optCCMode_1.Size = New System.Drawing.Size(81, 17)
        Me._optCCMode_1.TabIndex = 19
        Me._optCCMode_1.TabStop = True
        Me._optCCMode_1.Text = "On - Priority"
        Me._optCCMode_1.UseVisualStyleBackColor = False
        '
        '_optCCMode_0
        '
        Me._optCCMode_0.BackColor = System.Drawing.SystemColors.Control
        Me._optCCMode_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optCCMode_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optCCMode_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optCCMode_0.Location = New System.Drawing.Point(16, 16)
        Me._optCCMode_0.Name = "_optCCMode_0"
        Me._optCCMode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optCCMode_0.Size = New System.Drawing.Size(49, 17)
        Me._optCCMode_0.TabIndex = 18
        Me._optCCMode_0.TabStop = True
        Me._optCCMode_0.Text = "Off"
        Me._optCCMode_0.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me._chkCCBand_6)
        Me.Frame4.Controls.Add(Me._chkCCBand_5)
        Me.Frame4.Controls.Add(Me._chkCCBand_4)
        Me.Frame4.Controls.Add(Me._chkCCBand_3)
        Me.Frame4.Controls.Add(Me._chkCCBand_2)
        Me.Frame4.Controls.Add(Me._chkCCBand_1)
        Me.Frame4.Controls.Add(Me._chkCCBand_0)
        Me.Frame4.Controls.Add(Me.Label50)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(420, 16)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(245, 319)
        Me.Frame4.TabIndex = 116
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Close Call Bands"
        '
        '_chkCCBand_6
        '
        Me._chkCCBand_6.BackColor = System.Drawing.SystemColors.Control
        Me._chkCCBand_6.Checked = True
        Me._chkCCBand_6.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkCCBand_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkCCBand_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkCCBand_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkCCBand_6.Location = New System.Drawing.Point(12, 164)
        Me._chkCCBand_6.Name = "_chkCCBand_6"
        Me._chkCCBand_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkCCBand_6.Size = New System.Drawing.Size(201, 17)
        Me._chkCCBand_6.TabIndex = 27
        Me._chkCCBand_6.Text = "800Mhz+      (764-1300Mhz)"
        Me._chkCCBand_6.UseVisualStyleBackColor = False
        '
        '_chkCCBand_5
        '
        Me._chkCCBand_5.BackColor = System.Drawing.SystemColors.Control
        Me._chkCCBand_5.Checked = True
        Me._chkCCBand_5.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkCCBand_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkCCBand_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkCCBand_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkCCBand_5.Location = New System.Drawing.Point(12, 141)
        Me._chkCCBand_5.Name = "_chkCCBand_5"
        Me._chkCCBand_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkCCBand_5.Size = New System.Drawing.Size(193, 17)
        Me._chkCCBand_5.TabIndex = 24
        Me._chkCCBand_5.Text = "UHF             (320-512Mhz)"
        Me._chkCCBand_5.UseVisualStyleBackColor = False
        '
        '_chkCCBand_4
        '
        Me._chkCCBand_4.BackColor = System.Drawing.SystemColors.Control
        Me._chkCCBand_4.Checked = True
        Me._chkCCBand_4.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkCCBand_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkCCBand_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkCCBand_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkCCBand_4.Location = New System.Drawing.Point(12, 119)
        Me._chkCCBand_4.Name = "_chkCCBand_4"
        Me._chkCCBand_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkCCBand_4.Size = New System.Drawing.Size(197, 17)
        Me._chkCCBand_4.TabIndex = 26
        Me._chkCCBand_4.Text = "VHF High 2  (225-319.95Mhz)"
        Me._chkCCBand_4.UseVisualStyleBackColor = False
        '
        '_chkCCBand_3
        '
        Me._chkCCBand_3.BackColor = System.Drawing.SystemColors.Control
        Me._chkCCBand_3.Checked = True
        Me._chkCCBand_3.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkCCBand_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkCCBand_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkCCBand_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkCCBand_3.Location = New System.Drawing.Point(12, 96)
        Me._chkCCBand_3.Name = "_chkCCBand_3"
        Me._chkCCBand_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkCCBand_3.Size = New System.Drawing.Size(213, 17)
        Me._chkCCBand_3.TabIndex = 23
        Me._chkCCBand_3.Text = "VHF High 1  (137 - 224.98Mhz)"
        Me._chkCCBand_3.UseVisualStyleBackColor = False
        '
        '_chkCCBand_2
        '
        Me._chkCCBand_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkCCBand_2.Checked = True
        Me._chkCCBand_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkCCBand_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkCCBand_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkCCBand_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkCCBand_2.Location = New System.Drawing.Point(12, 73)
        Me._chkCCBand_2.Name = "_chkCCBand_2"
        Me._chkCCBand_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkCCBand_2.Size = New System.Drawing.Size(205, 17)
        Me._chkCCBand_2.TabIndex = 28
        Me._chkCCBand_2.Text = "Air                 (108-136.95Mhz)"
        Me._chkCCBand_2.UseVisualStyleBackColor = False
        '
        '_chkCCBand_1
        '
        Me._chkCCBand_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkCCBand_1.Checked = True
        Me._chkCCBand_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkCCBand_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkCCBand_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkCCBand_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkCCBand_1.Location = New System.Drawing.Point(12, 51)
        Me._chkCCBand_1.Name = "_chkCCBand_1"
        Me._chkCCBand_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkCCBand_1.Size = New System.Drawing.Size(173, 17)
        Me._chkCCBand_1.TabIndex = 25
        Me._chkCCBand_1.Text = "VHF Low 2   (54-107.9MHz)"
        Me._chkCCBand_1.UseVisualStyleBackColor = False
        '
        '_chkCCBand_0
        '
        Me._chkCCBand_0.BackColor = System.Drawing.SystemColors.Control
        Me._chkCCBand_0.Checked = True
        Me._chkCCBand_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkCCBand_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkCCBand_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkCCBand_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkCCBand_0.Location = New System.Drawing.Point(12, 28)
        Me._chkCCBand_0.Name = "_chkCCBand_0"
        Me._chkCCBand_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkCCBand_0.Size = New System.Drawing.Size(177, 17)
        Me._chkCCBand_0.TabIndex = 22
        Me._chkCCBand_0.Text = "VHF Low      (25-53.98Mhz)"
        Me._chkCCBand_0.UseVisualStyleBackColor = False
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.Control
        Me.Label50.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label50.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label50.Location = New System.Drawing.Point(12, 196)
        Me.Label50.Name = "Label50"
        Me.Label50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label50.Size = New System.Drawing.Size(205, 57)
        Me.Label50.TabIndex = 373
        Me.Label50.Text = "*VHF Low 2 and VHF High 2 are not applicable to to the BC246T and SC230.  VHF Hig" & _
            "h 2 not available on BC346XT"
        '
        '_optDispMode_TabPage0
        '
        Me._optDispMode_TabPage0.Controls.Add(GroupBox1)
        Me._optDispMode_TabPage0.Controls.Add(Me.fraBackLight)
        Me._optDispMode_TabPage0.Controls.Add(Me.frmGeneral)
        Me._optDispMode_TabPage0.Controls.Add(Me.Frame1)
        Me._optDispMode_TabPage0.Controls.Add(Me.Frame5)
        Me._optDispMode_TabPage0.Controls.Add(Me.Frame6)
        Me._optDispMode_TabPage0.Controls.Add(Me.Frame21)
        Me._optDispMode_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._optDispMode_TabPage0.Name = "_optDispMode_TabPage0"
        Me._optDispMode_TabPage0.Size = New System.Drawing.Size(723, 367)
        Me._optDispMode_TabPage0.TabIndex = 0
        Me._optDispMode_TabPage0.Text = "General"
        '
        'fraBackLight
        '
        Me.fraBackLight.BackColor = System.Drawing.SystemColors.Control
        Me.fraBackLight.Controls.Add(Me._optBackLight1_5)
        Me.fraBackLight.Controls.Add(Me._optBackLight1_4)
        Me.fraBackLight.Controls.Add(Me._optBackLight1_3)
        Me.fraBackLight.Controls.Add(Me._optBackLight1_2)
        Me.fraBackLight.Controls.Add(Me._optBackLight1_1)
        Me.fraBackLight.Controls.Add(Me._optBackLight1_0)
        Me.fraBackLight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraBackLight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraBackLight.Location = New System.Drawing.Point(6, 5)
        Me.fraBackLight.Name = "fraBackLight"
        Me.fraBackLight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraBackLight.Size = New System.Drawing.Size(137, 121)
        Me.fraBackLight.TabIndex = 109
        Me.fraBackLight.TabStop = False
        Me.fraBackLight.Text = "Backlight Mode (Base)"
        '
        '_optBackLight1_5
        '
        Me._optBackLight1_5.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_5.Checked = True
        Me._optBackLight1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_5.Location = New System.Drawing.Point(16, 96)
        Me._optBackLight1_5.Name = "_optBackLight1_5"
        Me._optBackLight1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_5.Size = New System.Drawing.Size(73, 17)
        Me._optBackLight1_5.TabIndex = 40
        Me._optBackLight1_5.TabStop = True
        Me._optBackLight1_5.Text = "- Polarity"
        Me._optBackLight1_5.UseVisualStyleBackColor = False
        '
        '_optBackLight1_4
        '
        Me._optBackLight1_4.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_4.Location = New System.Drawing.Point(16, 80)
        Me._optBackLight1_4.Name = "_optBackLight1_4"
        Me._optBackLight1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_4.Size = New System.Drawing.Size(73, 17)
        Me._optBackLight1_4.TabIndex = 39
        Me._optBackLight1_4.TabStop = True
        Me._optBackLight1_4.Text = "+ Polarity"
        Me._optBackLight1_4.UseVisualStyleBackColor = False
        '
        '_optBackLight1_3
        '
        Me._optBackLight1_3.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_3.Location = New System.Drawing.Point(16, 64)
        Me._optBackLight1_3.Name = "_optBackLight1_3"
        Me._optBackLight1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_3.Size = New System.Drawing.Size(73, 17)
        Me._optBackLight1_3.TabIndex = 38
        Me._optBackLight1_3.TabStop = True
        Me._optBackLight1_3.Text = "High"
        Me._optBackLight1_3.UseVisualStyleBackColor = False
        '
        '_optBackLight1_2
        '
        Me._optBackLight1_2.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_2.Location = New System.Drawing.Point(16, 48)
        Me._optBackLight1_2.Name = "_optBackLight1_2"
        Me._optBackLight1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_2.Size = New System.Drawing.Size(73, 17)
        Me._optBackLight1_2.TabIndex = 37
        Me._optBackLight1_2.TabStop = True
        Me._optBackLight1_2.Text = "Medium"
        Me._optBackLight1_2.UseVisualStyleBackColor = False
        '
        '_optBackLight1_1
        '
        Me._optBackLight1_1.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_1.Location = New System.Drawing.Point(16, 32)
        Me._optBackLight1_1.Name = "_optBackLight1_1"
        Me._optBackLight1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_1.Size = New System.Drawing.Size(73, 17)
        Me._optBackLight1_1.TabIndex = 36
        Me._optBackLight1_1.TabStop = True
        Me._optBackLight1_1.Text = "Low"
        Me._optBackLight1_1.UseVisualStyleBackColor = False
        '
        '_optBackLight1_0
        '
        Me._optBackLight1_0.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_0.Location = New System.Drawing.Point(16, 16)
        Me._optBackLight1_0.Name = "_optBackLight1_0"
        Me._optBackLight1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_0.Size = New System.Drawing.Size(73, 17)
        Me._optBackLight1_0.TabIndex = 35
        Me._optBackLight1_0.TabStop = True
        Me._optBackLight1_0.Text = "Off"
        Me._optBackLight1_0.UseVisualStyleBackColor = False
        '
        'frmGeneral
        '
        Me.frmGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.frmGeneral.Controls.Add(Label54)
        Me.frmGeneral.Controls.Add(Me.cmbState)
        Me.frmGeneral.Controls.Add(Me.chkBatSave)
        Me.frmGeneral.Controls.Add(Me._optPriMode_2)
        Me.frmGeneral.Controls.Add(Me._optPriMode_1)
        Me.frmGeneral.Controls.Add(Me._optPriMode_0)
        Me.frmGeneral.Controls.Add(Label11)
        Me.frmGeneral.Controls.Add(Label10)
        Me.frmGeneral.Controls.Add(Label9)
        Me.frmGeneral.Controls.Add(Label8)
        Me.frmGeneral.Controls.Add(Me.sldKeyBeep)
        Me.frmGeneral.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmGeneral.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmGeneral.Location = New System.Drawing.Point(8, 134)
        Me.frmGeneral.Name = "frmGeneral"
        Me.frmGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGeneral.Size = New System.Drawing.Size(180, 226)
        Me.frmGeneral.TabIndex = 113
        Me.frmGeneral.TabStop = False
        Me.frmGeneral.Text = "General"
        '
        '_optPriMode_0
        '
        Me._optPriMode_0.BackColor = System.Drawing.SystemColors.Control
        Me._optPriMode_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optPriMode_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optPriMode_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optPriMode_0.Location = New System.Drawing.Point(7, 97)
        Me._optPriMode_0.Name = "_optPriMode_0"
        Me._optPriMode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optPriMode_0.Size = New System.Drawing.Size(86, 17)
        Me._optPriMode_0.TabIndex = 51
        Me._optPriMode_0.TabStop = True
        Me._optPriMode_0.Text = "Priority OFF"
        Me._optPriMode_0.UseVisualStyleBackColor = False
        '
        'sldKeyBeep
        '
        Me.sldKeyBeep.Location = New System.Drawing.Point(36, 33)
        Me.sldKeyBeep.Maximum = 16
        Me.sldKeyBeep.Name = "sldKeyBeep"
        Me.sldKeyBeep.Size = New System.Drawing.Size(121, 45)
        Me.sldKeyBeep.TabIndex = 121
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtStartupMsg1)
        Me.Frame1.Controls.Add(Me.txtStartUpMsg2)
        Me.Frame1.Controls.Add(Me.txtStartUpMsg4)
        Me.Frame1.Controls.Add(Me.txtStartUpMsg3)
        Me.Frame1.Controls.Add(Me.cmdBlank)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(542, 5)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(177, 121)
        Me.Frame1.TabIndex = 114
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Startup Message"
        '
        'txtStartupMsg1
        '
        Me.txtStartupMsg1.AcceptsReturn = True
        Me.txtStartupMsg1.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartupMsg1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartupMsg1.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartupMsg1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartupMsg1.Location = New System.Drawing.Point(12, 16)
        Me.txtStartupMsg1.MaxLength = 16
        Me.txtStartupMsg1.Name = "txtStartupMsg1"
        Me.txtStartupMsg1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartupMsg1.Size = New System.Drawing.Size(147, 20)
        Me.txtStartupMsg1.TabIndex = 347
        Me.txtStartupMsg1.Text = "1234567890123456"
        '
        'txtStartUpMsg2
        '
        Me.txtStartUpMsg2.AcceptsReturn = True
        Me.txtStartUpMsg2.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartUpMsg2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartUpMsg2.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartUpMsg2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartUpMsg2.Location = New System.Drawing.Point(12, 36)
        Me.txtStartUpMsg2.MaxLength = 16
        Me.txtStartUpMsg2.Name = "txtStartUpMsg2"
        Me.txtStartUpMsg2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartUpMsg2.Size = New System.Drawing.Size(147, 20)
        Me.txtStartUpMsg2.TabIndex = 346
        '
        'txtStartUpMsg4
        '
        Me.txtStartUpMsg4.AcceptsReturn = True
        Me.txtStartUpMsg4.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartUpMsg4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartUpMsg4.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartUpMsg4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartUpMsg4.Location = New System.Drawing.Point(12, 76)
        Me.txtStartUpMsg4.MaxLength = 16
        Me.txtStartUpMsg4.Name = "txtStartUpMsg4"
        Me.txtStartUpMsg4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartUpMsg4.Size = New System.Drawing.Size(147, 20)
        Me.txtStartUpMsg4.TabIndex = 345
        '
        'txtStartUpMsg3
        '
        Me.txtStartUpMsg3.AcceptsReturn = True
        Me.txtStartUpMsg3.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartUpMsg3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartUpMsg3.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartUpMsg3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartUpMsg3.Location = New System.Drawing.Point(12, 56)
        Me.txtStartUpMsg3.MaxLength = 16
        Me.txtStartUpMsg3.Name = "txtStartUpMsg3"
        Me.txtStartUpMsg3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartUpMsg3.Size = New System.Drawing.Size(147, 20)
        Me.txtStartUpMsg3.TabIndex = 344
        '
        'cmdBlank
        '
        Me.cmdBlank.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBlank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBlank.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBlank.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBlank.Location = New System.Drawing.Point(50, 96)
        Me.cmdBlank.Name = "cmdBlank"
        Me.cmdBlank.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBlank.Size = New System.Drawing.Size(73, 21)
        Me.cmdBlank.TabIndex = 343
        Me.cmdBlank.Text = "B&lank"
        Me.cmdBlank.UseVisualStyleBackColor = True
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.optBacklightWhite)
        Me.Frame5.Controls.Add(Me.optBacklightYellow)
        Me.Frame5.Controls.Add(Me.optBacklightMagenta)
        Me.Frame5.Controls.Add(Me.optBacklightBlue)
        Me.Frame5.Controls.Add(Me.optBacklightCyan)
        Me.Frame5.Controls.Add(Me.optBacklightRed)
        Me.Frame5.Controls.Add(Me.optBacklightGreen)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(374, 5)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(166, 121)
        Me.Frame5.TabIndex = 121
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Backlight Colour (996/396XT)"
        '
        'optBacklightWhite
        '
        Me.optBacklightWhite.BackColor = System.Drawing.SystemColors.Control
        Me.optBacklightWhite.Cursor = System.Windows.Forms.Cursors.Default
        Me.optBacklightWhite.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBacklightWhite.ForeColor = System.Drawing.Color.Black
        Me.optBacklightWhite.Location = New System.Drawing.Point(11, 62)
        Me.optBacklightWhite.Name = "optBacklightWhite"
        Me.optBacklightWhite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optBacklightWhite.Size = New System.Drawing.Size(66, 25)
        Me.optBacklightWhite.TabIndex = 47
        Me.optBacklightWhite.TabStop = True
        Me.optBacklightWhite.Text = "White"
        Me.optBacklightWhite.UseVisualStyleBackColor = False
        '
        'optBacklightYellow
        '
        Me.optBacklightYellow.BackColor = System.Drawing.SystemColors.Control
        Me.optBacklightYellow.Cursor = System.Windows.Forms.Cursors.Default
        Me.optBacklightYellow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBacklightYellow.ForeColor = System.Drawing.Color.Gold
        Me.optBacklightYellow.Location = New System.Drawing.Point(85, 68)
        Me.optBacklightYellow.Name = "optBacklightYellow"
        Me.optBacklightYellow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optBacklightYellow.Size = New System.Drawing.Size(67, 25)
        Me.optBacklightYellow.TabIndex = 46
        Me.optBacklightYellow.TabStop = True
        Me.optBacklightYellow.Text = "Yellow"
        Me.optBacklightYellow.UseVisualStyleBackColor = False
        '
        'optBacklightMagenta
        '
        Me.optBacklightMagenta.BackColor = System.Drawing.SystemColors.Control
        Me.optBacklightMagenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.optBacklightMagenta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBacklightMagenta.ForeColor = System.Drawing.Color.Magenta
        Me.optBacklightMagenta.Location = New System.Drawing.Point(11, 85)
        Me.optBacklightMagenta.Name = "optBacklightMagenta"
        Me.optBacklightMagenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optBacklightMagenta.Size = New System.Drawing.Size(75, 25)
        Me.optBacklightMagenta.TabIndex = 45
        Me.optBacklightMagenta.TabStop = True
        Me.optBacklightMagenta.Text = "Magenta"
        Me.optBacklightMagenta.UseVisualStyleBackColor = False
        '
        'optBacklightBlue
        '
        Me.optBacklightBlue.BackColor = System.Drawing.SystemColors.Control
        Me.optBacklightBlue.Cursor = System.Windows.Forms.Cursors.Default
        Me.optBacklightBlue.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBacklightBlue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.optBacklightBlue.Location = New System.Drawing.Point(85, 19)
        Me.optBacklightBlue.Name = "optBacklightBlue"
        Me.optBacklightBlue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optBacklightBlue.Size = New System.Drawing.Size(52, 25)
        Me.optBacklightBlue.TabIndex = 44
        Me.optBacklightBlue.TabStop = True
        Me.optBacklightBlue.Text = "Blue"
        Me.optBacklightBlue.UseVisualStyleBackColor = False
        '
        'optBacklightCyan
        '
        Me.optBacklightCyan.BackColor = System.Drawing.SystemColors.Control
        Me.optBacklightCyan.Cursor = System.Windows.Forms.Cursors.Default
        Me.optBacklightCyan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBacklightCyan.ForeColor = System.Drawing.Color.Cyan
        Me.optBacklightCyan.Location = New System.Drawing.Point(85, 44)
        Me.optBacklightCyan.Name = "optBacklightCyan"
        Me.optBacklightCyan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optBacklightCyan.Size = New System.Drawing.Size(56, 25)
        Me.optBacklightCyan.TabIndex = 43
        Me.optBacklightCyan.TabStop = True
        Me.optBacklightCyan.Text = "Cyan"
        Me.optBacklightCyan.UseVisualStyleBackColor = False
        '
        'optBacklightRed
        '
        Me.optBacklightRed.BackColor = System.Drawing.SystemColors.Control
        Me.optBacklightRed.Cursor = System.Windows.Forms.Cursors.Default
        Me.optBacklightRed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBacklightRed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optBacklightRed.Location = New System.Drawing.Point(11, 39)
        Me.optBacklightRed.Name = "optBacklightRed"
        Me.optBacklightRed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optBacklightRed.Size = New System.Drawing.Size(55, 25)
        Me.optBacklightRed.TabIndex = 42
        Me.optBacklightRed.TabStop = True
        Me.optBacklightRed.Text = "Red "
        Me.optBacklightRed.UseVisualStyleBackColor = False
        '
        'optBacklightGreen
        '
        Me.optBacklightGreen.BackColor = System.Drawing.SystemColors.Control
        Me.optBacklightGreen.Cursor = System.Windows.Forms.Cursors.Default
        Me.optBacklightGreen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBacklightGreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optBacklightGreen.Location = New System.Drawing.Point(11, 16)
        Me.optBacklightGreen.Name = "optBacklightGreen"
        Me.optBacklightGreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optBacklightGreen.Size = New System.Drawing.Size(58, 25)
        Me.optBacklightGreen.TabIndex = 41
        Me.optBacklightGreen.TabStop = True
        Me.optBacklightGreen.Text = "Green"
        Me.optBacklightGreen.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.OptMode3)
        Me.Frame6.Controls.Add(Me.optMode2)
        Me.Frame6.Controls.Add(Me.optMode1)
        Me.Frame6.Controls.Add(Me.chkActChanDisp)
        Me.Frame6.Controls.Add(Me.chkLCDFlip)
        Me.Frame6.Controls.Add(Me.Label14)
        Me.Frame6.Controls.Add(Me.Label13)
        Me.Frame6.Controls.Add(Label12)
        Me.Frame6.Controls.Add(Me.sldLCDContrast)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(500, 134)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(217, 226)
        Me.Frame6.TabIndex = 122
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "LCD"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(178, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(34, 17)
        Me.Label14.TabIndex = 125
        Me.Label14.Text = "High"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(16, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(30, 17)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Low"
        '
        'sldLCDContrast
        '
        Me.sldLCDContrast.Location = New System.Drawing.Point(40, 33)
        Me.sldLCDContrast.Maximum = 15
        Me.sldLCDContrast.Minimum = 1
        Me.sldLCDContrast.Name = "sldLCDContrast"
        Me.sldLCDContrast.Size = New System.Drawing.Size(147, 45)
        Me.sldLCDContrast.TabIndex = 375
        Me.sldLCDContrast.Value = 1
        '
        'Frame21
        '
        Me.Frame21.BackColor = System.Drawing.SystemColors.Control
        Me.Frame21.Controls.Add(Label51)
        Me.Frame21.Controls.Add(Label48)
        Me.Frame21.Controls.Add(Label34)
        Me.Frame21.Controls.Add(Me.sldXTBright)
        Me.Frame21.Controls.Add(Me._optBackLight1_10)
        Me.Frame21.Controls.Add(Me._optBackLight1_9)
        Me.Frame21.Controls.Add(Me._optBackLight1_8)
        Me.Frame21.Controls.Add(Me._optBackLight1_7)
        Me.Frame21.Controls.Add(Me._optBackLight1_6)
        Me.Frame21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame21.Location = New System.Drawing.Point(149, 5)
        Me.Frame21.Name = "Frame21"
        Me.Frame21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame21.Size = New System.Drawing.Size(221, 121)
        Me.Frame21.TabIndex = 361
        Me.Frame21.TabStop = False
        Me.Frame21.Text = "Backlight Mode (Handheld Only)"
        '
        'sldXTBright
        '
        Me.sldXTBright.LargeChange = 1
        Me.sldXTBright.Location = New System.Drawing.Point(133, 34)
        Me.sldXTBright.Maximum = 3
        Me.sldXTBright.Minimum = 1
        Me.sldXTBright.Name = "sldXTBright"
        Me.sldXTBright.Size = New System.Drawing.Size(57, 45)
        Me.sldXTBright.TabIndex = 367
        Me.sldXTBright.Value = 1
        '
        '_optBackLight1_10
        '
        Me._optBackLight1_10.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_10.Location = New System.Drawing.Point(12, 93)
        Me._optBackLight1_10.Name = "_optBackLight1_10"
        Me._optBackLight1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_10.Size = New System.Drawing.Size(73, 17)
        Me._optBackLight1_10.TabIndex = 366
        Me._optBackLight1_10.TabStop = True
        Me._optBackLight1_10.Text = "Squelch"
        Me._optBackLight1_10.UseVisualStyleBackColor = False
        '
        '_optBackLight1_9
        '
        Me._optBackLight1_9.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_9.Location = New System.Drawing.Point(12, 74)
        Me._optBackLight1_9.Name = "_optBackLight1_9"
        Me._optBackLight1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_9.Size = New System.Drawing.Size(73, 17)
        Me._optBackLight1_9.TabIndex = 365
        Me._optBackLight1_9.TabStop = True
        Me._optBackLight1_9.Text = "Keypress"
        Me._optBackLight1_9.UseVisualStyleBackColor = False
        '
        '_optBackLight1_8
        '
        Me._optBackLight1_8.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_8.Location = New System.Drawing.Point(13, 55)
        Me._optBackLight1_8.Name = "_optBackLight1_8"
        Me._optBackLight1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_8.Size = New System.Drawing.Size(97, 17)
        Me._optBackLight1_8.TabIndex = 364
        Me._optBackLight1_8.TabStop = True
        Me._optBackLight1_8.Text = "30 Seconds"
        Me._optBackLight1_8.UseVisualStyleBackColor = False
        '
        '_optBackLight1_7
        '
        Me._optBackLight1_7.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_7.Location = New System.Drawing.Point(12, 36)
        Me._optBackLight1_7.Name = "_optBackLight1_7"
        Me._optBackLight1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_7.Size = New System.Drawing.Size(89, 17)
        Me._optBackLight1_7.TabIndex = 363
        Me._optBackLight1_7.TabStop = True
        Me._optBackLight1_7.Text = "10 Seconds"
        Me._optBackLight1_7.UseVisualStyleBackColor = False
        '
        '_optBackLight1_6
        '
        Me._optBackLight1_6.BackColor = System.Drawing.SystemColors.Control
        Me._optBackLight1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._optBackLight1_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optBackLight1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._optBackLight1_6.Location = New System.Drawing.Point(12, 16)
        Me._optBackLight1_6.Name = "_optBackLight1_6"
        Me._optBackLight1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optBackLight1_6.Size = New System.Drawing.Size(73, 17)
        Me._optBackLight1_6.TabIndex = 362
        Me._optBackLight1_6.TabStop = True
        Me._optBackLight1_6.Text = "Infinite"
        Me._optBackLight1_6.UseVisualStyleBackColor = False
        '
        'optDispMode
        '
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage0)
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage1)
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage2)
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage3)
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage4)
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage5)
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage6)
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage7)
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage8)
        Me.optDispMode.Controls.Add(Me._optDispMode_TabPage9)
        Me.optDispMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDispMode.ItemSize = New System.Drawing.Size(42, 18)
        Me.optDispMode.Location = New System.Drawing.Point(3, 7)
        Me.optDispMode.Name = "optDispMode"
        Me.optDispMode.SelectedIndex = 1
        Me.optDispMode.Size = New System.Drawing.Size(731, 393)
        Me.optDispMode.TabIndex = 0
        '
        'cmbState
        '
        Me.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(8, 198)
        Me.cmbState.MaxDropDownItems = 15
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(160, 22)
        Me.cmbState.TabIndex = 376
        '
        'Label54
        '
        Label54.BackColor = System.Drawing.SystemColors.Control
        Label54.Cursor = System.Windows.Forms.Cursors.Default
        Label54.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label54.ForeColor = System.Drawing.SystemColors.ControlText
        Label54.Location = New System.Drawing.Point(6, 176)
        Label54.Name = "Label54"
        Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label54.Size = New System.Drawing.Size(164, 17)
        Label54.TabIndex = 377
        Label54.Text = "Default State (BCT15(X) Only)"
        '
        'frmRadioPref246
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(736, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.optDispMode)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRadioPref246"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set Scanner Options"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(Me.Frame22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBSC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCCBand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkWX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAGC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSearchKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optAlertMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optBackLight1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optCCMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optGPSDispMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optPriMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWX, System.ComponentModel.ISupportInitialize).EndInit()
        Me._optDispMode_TabPage9.ResumeLayout(False)
        Me._Frame22_1.ResumeLayout(False)
        Me._Frame22_1.PerformLayout()
        Me._Frame22_0.ResumeLayout(False)
        Me._Frame22_0.PerformLayout()
        Me.Frame16.ResumeLayout(False)
        Me.Frame17.ResumeLayout(False)
        Me.Frame17.PerformLayout()
        Me._optDispMode_TabPage8.ResumeLayout(False)
        CType(Me.grdToneOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me._optDispMode_TabPage7.ResumeLayout(False)
        Me.Frame15.ResumeLayout(False)
        Me.Frame15.PerformLayout()
        Me.Frame20.ResumeLayout(False)
        Me._optDispMode_TabPage6.ResumeLayout(False)
        Me.Frame18.ResumeLayout(False)
        Me.Frame18.PerformLayout()
        Me._optDispMode_TabPage5.ResumeLayout(False)
        Me.Frame14.ResumeLayout(False)
        Me._optDispMode_TabPage4.ResumeLayout(False)
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame9.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me._optDispMode_TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdGIF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame7.ResumeLayout(False)
        CType(Me.grdFreqLO, System.ComponentModel.ISupportInitialize).EndInit()
        Me._optDispMode_TabPage2.ResumeLayout(False)
        Me._optDispMode_TabPage2.PerformLayout()
        CType(Me.grdCust, System.ComponentModel.ISupportInitialize).EndInit()
        Me._optDispMode_TabPage1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame12.ResumeLayout(False)
        Me.Frame12.PerformLayout()
        Me.Frame11.ResumeLayout(False)
        Me.Frame11.PerformLayout()
        CType(Me.sldCCVol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame10.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me._optDispMode_TabPage0.ResumeLayout(False)
        Me.fraBackLight.ResumeLayout(False)
        Me.frmGeneral.ResumeLayout(False)
        Me.frmGeneral.PerformLayout()
        CType(Me.sldKeyBeep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame5.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame6.PerformLayout()
        CType(Me.sldLCDContrast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame21.ResumeLayout(False)
        Me.Frame21.PerformLayout()
        CType(Me.sldXTBright, System.ComponentModel.ISupportInitialize).EndInit()
        Me.optDispMode.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents _optDispMode_TabPage9 As System.Windows.Forms.TabPage
    Public WithEvents _Frame22_1 As System.Windows.Forms.GroupBox
    Public WithEvents cmbP25Wait As System.Windows.Forms.ComboBox
    Public WithEvents _Label1_5 As System.Windows.Forms.Label
    Public WithEvents _Label1_9 As System.Windows.Forms.Label
    Public WithEvents _Frame22_0 As System.Windows.Forms.GroupBox
    Public WithEvents chkDigitalAGC As System.Windows.Forms.CheckBox
    Public WithEvents chkAnalogAGC As System.Windows.Forms.CheckBox
    Public WithEvents _cmbAGC_5 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbAGC_4 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbAGC_3 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbAGC_2 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbAGC_1 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbAGC_0 As System.Windows.Forms.ComboBox
    Public WithEvents _Label1_4 As System.Windows.Forms.Label
    Public WithEvents _Label1_3 As System.Windows.Forms.Label
    Public WithEvents _Label1_2 As System.Windows.Forms.Label
    Public WithEvents _Label1_1 As System.Windows.Forms.Label
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
    Public WithEvents Frame16 As System.Windows.Forms.GroupBox
    Public WithEvents Frame17 As System.Windows.Forms.Panel
    Public WithEvents _optGPSDispMode_0 As System.Windows.Forms.RadioButton
    Public WithEvents _optGPSDispMode_1 As System.Windows.Forms.RadioButton
    Public WithEvents _optGPSDispMode_2 As System.Windows.Forms.RadioButton
    Public WithEvents _optGPSDispMode_3 As System.Windows.Forms.RadioButton
    Public WithEvents _optGPSDispMode_4 As System.Windows.Forms.RadioButton
    Public WithEvents Label38 As System.Windows.Forms.Label
    Public WithEvents chkGPSKM As System.Windows.Forms.CheckBox
    Public WithEvents chkGPSTimeFormat As System.Windows.Forms.CheckBox
    Public WithEvents chkGPSDMS As System.Windows.Forms.CheckBox
    Public WithEvents cmbGPSTimeZone As System.Windows.Forms.ComboBox
    Public WithEvents Label39 As System.Windows.Forms.Label
    Public WithEvents _optDispMode_TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents grdToneOut As System.Windows.Forms.DataGridView
    Friend WithEvents txtTonName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTonFreq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTonLowLimit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtToneHiLimit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbTonDelay As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbTonMod As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbTonAltTone As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbTonAltToneLevel As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbTonAlertColor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbAlertFlash As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbToneAtt As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmbTonAGC As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmbTonRecOut As System.Windows.Forms.DataGridViewCheckBoxColumn
    Public WithEvents _optDispMode_TabPage7 As System.Windows.Forms.TabPage
    Public WithEvents Frame15 As System.Windows.Forms.GroupBox
    Public WithEvents Frame20 As System.Windows.Forms.GroupBox
    Public WithEvents cmdUSCodes As System.Windows.Forms.Button
    Public WithEvents cmdCanuckKodes As System.Windows.Forms.Button
    Public WithEvents cmdResetWX As System.Windows.Forms.Button
    Public WithEvents _txtWX_44 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_43 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_42 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_41 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_40 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_39 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_38 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_37 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_36 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_35 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_34 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_33 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_32 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_31 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_30 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_29 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_28 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_27 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_26 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_25 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_24 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_23 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_22 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_21 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_20 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_19 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_18 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_17 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_16 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_15 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_14 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_13 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_12 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_11 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_10 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_9 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_8 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_7 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_6 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_5 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_4 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_3 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_2 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_1 As System.Windows.Forms.TextBox
    Public WithEvents _txtWX_0 As System.Windows.Forms.TextBox
    Public WithEvents cmbWXDelay As System.Windows.Forms.ComboBox
    Public WithEvents _chkWX_2 As System.Windows.Forms.CheckBox
    Public WithEvents _chkWX_1 As System.Windows.Forms.CheckBox
    Public WithEvents _chkWX_0 As System.Windows.Forms.CheckBox
    Public WithEvents _Label47_4 As System.Windows.Forms.Label
    Public WithEvents _Label47_3 As System.Windows.Forms.Label
    Public WithEvents _Label47_2 As System.Windows.Forms.Label
    Public WithEvents _Label47_1 As System.Windows.Forms.Label
    Public WithEvents _Label47_0 As System.Windows.Forms.Label
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents Delay As System.Windows.Forms.Label
    Public WithEvents _optDispMode_TabPage6 As System.Windows.Forms.TabPage
    Public WithEvents Frame18 As System.Windows.Forms.GroupBox
    Public WithEvents _chkBSC_6 As System.Windows.Forms.CheckBox
    Public WithEvents _chkBSC_7 As System.Windows.Forms.CheckBox
    Public WithEvents _txtBBS_19 As System.Windows.Forms.TextBox
    Public WithEvents _chkBSC_8 As System.Windows.Forms.CheckBox
    Public WithEvents _txtBBS_18 As System.Windows.Forms.TextBox
    Public WithEvents _chkBSC_9 As System.Windows.Forms.CheckBox
    Public WithEvents _txtBBS_17 As System.Windows.Forms.TextBox
    Public WithEvents _chkBSC_10 As System.Windows.Forms.CheckBox
    Public WithEvents _txtBBS_16 As System.Windows.Forms.TextBox
    Public WithEvents _chkBSC_11 As System.Windows.Forms.CheckBox
    Public WithEvents _txtBBS_15 As System.Windows.Forms.TextBox
    Public WithEvents _chkBSC_12 As System.Windows.Forms.CheckBox
    Public WithEvents _txtBBS_14 As System.Windows.Forms.TextBox
    Public WithEvents _chkBSC_13 As System.Windows.Forms.CheckBox
    Public WithEvents _txtBBS_13 As System.Windows.Forms.TextBox
    Public WithEvents _chkBSC_14 As System.Windows.Forms.CheckBox
    Public WithEvents _txtBBS_12 As System.Windows.Forms.TextBox
    Public WithEvents _chkBSC_15 As System.Windows.Forms.CheckBox
    Public WithEvents _txtBBS_11 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_10 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_9 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_8 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_7 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_6 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_5 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_4 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_3 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_2 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_1 As System.Windows.Forms.TextBox
    Public WithEvents _txtBBS_0 As System.Windows.Forms.TextBox
    Public WithEvents _Label42_9 As System.Windows.Forms.Label
    Public WithEvents _Label42_8 As System.Windows.Forms.Label
    Public WithEvents _Label42_7 As System.Windows.Forms.Label
    Public WithEvents _Label42_6 As System.Windows.Forms.Label
    Public WithEvents _Label42_5 As System.Windows.Forms.Label
    Public WithEvents _Label42_4 As System.Windows.Forms.Label
    Public WithEvents _Label42_3 As System.Windows.Forms.Label
    Public WithEvents _Label42_2 As System.Windows.Forms.Label
    Public WithEvents _Label42_1 As System.Windows.Forms.Label
    Public WithEvents _Label42_0 As System.Windows.Forms.Label
    Public WithEvents Label41 As System.Windows.Forms.Label
    Public WithEvents Label40 As System.Windows.Forms.Label
    Public WithEvents _optDispMode_TabPage5 As System.Windows.Forms.TabPage
    Public WithEvents Frame14 As System.Windows.Forms.GroupBox
    Public WithEvents _chkBSC_5 As System.Windows.Forms.CheckBox
    Public WithEvents _chkBSC_0 As System.Windows.Forms.CheckBox
    Public WithEvents _chkBSC_1 As System.Windows.Forms.CheckBox
    Public WithEvents _chkBSC_2 As System.Windows.Forms.CheckBox
    Public WithEvents _chkBSC_3 As System.Windows.Forms.CheckBox
    Public WithEvents _chkBSC_4 As System.Windows.Forms.CheckBox
    Public WithEvents cmbSSHold As System.Windows.Forms.ComboBox
    Public WithEvents cmbSSModMode As System.Windows.Forms.ComboBox
    Public WithEvents cmbSSStep As System.Windows.Forms.ComboBox
    Public WithEvents chkCCTapeOut As System.Windows.Forms.CheckBox
    Public WithEvents cmbMaxAutoStore As System.Windows.Forms.ComboBox
    Public WithEvents chkSSRepeater As System.Windows.Forms.CheckBox
    Public WithEvents chkSSDataSkip As System.Windows.Forms.CheckBox
    Public WithEvents cmbSSAtt As System.Windows.Forms.CheckBox
    Public WithEvents cmbSSDelay As System.Windows.Forms.ComboBox
    Public WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents _optDispMode_TabPage4 As System.Windows.Forms.TabPage
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents cmbSSHoldTime As System.Windows.Forms.ComboBox
    Public WithEvents cmbSSsystem As System.Windows.Forms.ComboBox
    Public WithEvents cmbSSDelayTime As System.Windows.Forms.ComboBox
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents txtSSPNumTag As System.Windows.Forms.TextBox
    Public WithEvents cmbSSPP25Wait As System.Windows.Forms.ComboBox
    Public WithEvents chkSSPDigitalAGC As System.Windows.Forms.CheckBox
    Public WithEvents chkSSPAnalogAGC As System.Windows.Forms.CheckBox
    Public WithEvents cmbSSStartupKey As System.Windows.Forms.ComboBox
    Public WithEvents cmbSSQuickKey As System.Windows.Forms.ComboBox
    Public WithEvents chkSSTapeOut As System.Windows.Forms.CheckBox
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents chkSSAtt As System.Windows.Forms.CheckBox
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents chkSrchLO As System.Windows.Forms.CheckBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents _cmbSearchKey_5 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSearchKey_4 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSearchKey_3 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSearchKey_2 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSearchKey_1 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSearchKey_0 As System.Windows.Forms.ComboBox
    Public WithEvents _Label17_6 As System.Windows.Forms.Label
    Public WithEvents _Label17_5 As System.Windows.Forms.Label
    Public WithEvents _Label17_4 As System.Windows.Forms.Label
    Public WithEvents _Label17_3 As System.Windows.Forms.Label
    Public WithEvents _Label17_2 As System.Windows.Forms.Label
    Public WithEvents _Label17_0 As System.Windows.Forms.Label
    Public WithEvents _optDispMode_TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdGIF As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents cmdClearGIF As System.Windows.Forms.Button
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Friend WithEvents grdFreqLO As System.Windows.Forms.DataGridView
    Friend WithEvents txtFreqLO As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents cmdClearLOFreq As System.Windows.Forms.Button
    Public WithEvents cmdClearLOFreqDup As System.Windows.Forms.Button
    Public WithEvents _optDispMode_TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents grdCust As System.Windows.Forms.DataGridView
    Friend WithEvents grdCustName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdCustLowLimit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdCustHiLimit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdCustDelay As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdCustLO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdCustEnabled As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdCustHoldTime As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdCustSS As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdCustAtt As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdCustDataSkip As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdCustCtlChn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdCustQK As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdCustStartupKey As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdCustModulation As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdCustNumTag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdCustAGCA As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdCustAGCD As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdCustP25Wait As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdCustTapeOut As System.Windows.Forms.DataGridViewCheckBoxColumn
    Public WithEvents cmdCSDefault As System.Windows.Forms.Button
    Public WithEvents _optDispMode_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Frame12 As System.Windows.Forms.GroupBox
    Friend WithEvents optCCCodeSearch2 As System.Windows.Forms.RadioButton
    Friend WithEvents optCCCodeSearch1 As System.Windows.Forms.RadioButton
    Friend WithEvents optCCCodeSearch0 As System.Windows.Forms.RadioButton
    Friend WithEvents chkCCAGCD As System.Windows.Forms.CheckBox
    Friend WithEvents chkCCAGCA As System.Windows.Forms.CheckBox
    Public WithEvents cmbCCPauseTime As System.Windows.Forms.ComboBox
    Public WithEvents cmbCCQuickKey As System.Windows.Forms.ComboBox
    Public WithEvents chkCCHits As System.Windows.Forms.CheckBox
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Frame11 As System.Windows.Forms.GroupBox
    Public WithEvents cmbCCAltCol As System.Windows.Forms.ComboBox
    Public WithEvents cmbCCAltPat As System.Windows.Forms.ComboBox
    Friend WithEvents sldCCVol As System.Windows.Forms.TrackBar
    Public WithEvents _optAlertMode_0 As System.Windows.Forms.RadioButton
    Public WithEvents _optAlertMode_1 As System.Windows.Forms.RadioButton
    Public WithEvents _optAlertMode_2 As System.Windows.Forms.RadioButton
    Public WithEvents _optAlertMode_3 As System.Windows.Forms.RadioButton
    Public WithEvents cmbCloseCallAlertType As System.Windows.Forms.ComboBox
    Public WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Frame10 As System.Windows.Forms.GroupBox
    Public WithEvents chkCloseCallOverride As System.Windows.Forms.CheckBox
    Public WithEvents _optCCMode_2 As System.Windows.Forms.RadioButton
    Public WithEvents _optCCMode_1 As System.Windows.Forms.RadioButton
    Public WithEvents _optCCMode_0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents _chkCCBand_6 As System.Windows.Forms.CheckBox
    Public WithEvents _chkCCBand_5 As System.Windows.Forms.CheckBox
    Public WithEvents _chkCCBand_4 As System.Windows.Forms.CheckBox
    Public WithEvents _chkCCBand_3 As System.Windows.Forms.CheckBox
    Public WithEvents _chkCCBand_2 As System.Windows.Forms.CheckBox
    Public WithEvents _chkCCBand_1 As System.Windows.Forms.CheckBox
    Public WithEvents _chkCCBand_0 As System.Windows.Forms.CheckBox
    Public WithEvents Label50 As System.Windows.Forms.Label
    Public WithEvents _optDispMode_TabPage0 As System.Windows.Forms.TabPage
    Friend WithEvents chkUnitID As System.Windows.Forms.CheckBox
    Friend WithEvents PriIntTime As System.Windows.Forms.ComboBox
    Friend WithEvents MaxPriChan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBatChg As System.Windows.Forms.ComboBox
    Friend WithEvents chkXTGlobalAtt As System.Windows.Forms.CheckBox
    Public WithEvents optXTChanLog2 As System.Windows.Forms.RadioButton
    Public WithEvents optXTChanLog1 As System.Windows.Forms.RadioButton
    Public WithEvents optXTChanLog0 As System.Windows.Forms.RadioButton
    Friend WithEvents chkXTP25LP As System.Windows.Forms.CheckBox
    Friend WithEvents chkXTKeySafe As System.Windows.Forms.CheckBox
    Friend WithEvents chkXTKeyLock As System.Windows.Forms.CheckBox
    Public WithEvents fraBackLight As System.Windows.Forms.GroupBox
    Public WithEvents _optBackLight1_5 As System.Windows.Forms.RadioButton
    Public WithEvents _optBackLight1_4 As System.Windows.Forms.RadioButton
    Public WithEvents _optBackLight1_3 As System.Windows.Forms.RadioButton
    Public WithEvents _optBackLight1_2 As System.Windows.Forms.RadioButton
    Public WithEvents _optBackLight1_1 As System.Windows.Forms.RadioButton
    Public WithEvents _optBackLight1_0 As System.Windows.Forms.RadioButton
    Public WithEvents frmGeneral As System.Windows.Forms.GroupBox
    Public WithEvents chkBatSave As System.Windows.Forms.CheckBox
    Public WithEvents _optPriMode_2 As System.Windows.Forms.RadioButton
    Public WithEvents _optPriMode_1 As System.Windows.Forms.RadioButton
    Public WithEvents _optPriMode_0 As System.Windows.Forms.RadioButton
    Friend WithEvents sldKeyBeep As System.Windows.Forms.TrackBar
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtStartupMsg1 As System.Windows.Forms.TextBox
    Public WithEvents txtStartUpMsg2 As System.Windows.Forms.TextBox
    Public WithEvents txtStartUpMsg4 As System.Windows.Forms.TextBox
    Public WithEvents txtStartUpMsg3 As System.Windows.Forms.TextBox
    Public WithEvents cmdBlank As System.Windows.Forms.Button
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents optBacklightWhite As System.Windows.Forms.RadioButton
    Public WithEvents optBacklightYellow As System.Windows.Forms.RadioButton
    Public WithEvents optBacklightMagenta As System.Windows.Forms.RadioButton
    Public WithEvents optBacklightBlue As System.Windows.Forms.RadioButton
    Public WithEvents optBacklightCyan As System.Windows.Forms.RadioButton
    Public WithEvents optBacklightRed As System.Windows.Forms.RadioButton
    Public WithEvents optBacklightGreen As System.Windows.Forms.RadioButton
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents OptMode3 As System.Windows.Forms.RadioButton
    Public WithEvents optMode2 As System.Windows.Forms.RadioButton
    Public WithEvents optMode1 As System.Windows.Forms.RadioButton
    Public WithEvents chkActChanDisp As System.Windows.Forms.CheckBox
    Public WithEvents chkLCDFlip As System.Windows.Forms.CheckBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents sldLCDContrast As System.Windows.Forms.TrackBar
    Public WithEvents Frame21 As System.Windows.Forms.GroupBox
    Friend WithEvents sldXTBright As System.Windows.Forms.TrackBar
    Public WithEvents _optBackLight1_10 As System.Windows.Forms.RadioButton
    Public WithEvents _optBackLight1_9 As System.Windows.Forms.RadioButton
    Public WithEvents _optBackLight1_8 As System.Windows.Forms.RadioButton
    Public WithEvents _optBackLight1_7 As System.Windows.Forms.RadioButton
    Public WithEvents _optBackLight1_6 As System.Windows.Forms.RadioButton
    Public WithEvents optDispMode As System.Windows.Forms.TabControl
    Friend WithEvents cmbState As System.Windows.Forms.ComboBox
#End Region
End Class