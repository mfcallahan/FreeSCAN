<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class lblSiteNote
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        blnBusy = True
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        blnBusy = False
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
    Public WithEvents cmdAutoCalcBP As System.Windows.Forms.Button
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents chkTrnGPSEnable As System.Windows.Forms.CheckBox
    Public WithEvents cmdTrnSiteEditGPS As System.Windows.Forms.Button
    Public WithEvents lblTrnRange As System.Windows.Forms.Label
    Public WithEvents lblTrnLong As System.Windows.Forms.Label
    Public WithEvents lblTrnLat As System.Windows.Forms.Label
    Public WithEvents Frame12 As System.Windows.Forms.GroupBox
    Public WithEvents txtTrunkSiteName As System.Windows.Forms.TextBox
    Public WithEvents cmbSiteQK As System.Windows.Forms.ComboBox
    Public WithEvents chkTrnSiteLO As System.Windows.Forms.CheckBox
    Public WithEvents cmbTrnModMode As System.Windows.Forms.ComboBox
    Public WithEvents chkTrnSiteAtt As System.Windows.Forms.CheckBox
    Public WithEvents chkControlChanOnly As System.Windows.Forms.CheckBox
    Public WithEvents cmbTrnSiteType As System.Windows.Forms.ComboBox
    Public WithEvents cmbTrnSiteHoldTime As System.Windows.Forms.ComboBox
    Public WithEvents cmbTrnSiteStartupKey As System.Windows.Forms.ComboBox
    Public WithEvents _cmdJustTrnSite_2 As System.Windows.Forms.Button
    Public WithEvents _cmdJustTrnSite_1 As System.Windows.Forms.Button
    Public WithEvents _cmdJustTrnSite_0 As System.Windows.Forms.Button
    Public WithEvents _cmdFreeGQK_4 As System.Windows.Forms.Button
    Public WithEvents _cmbAPCO_2 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbAPCO_3 As System.Windows.Forms.ComboBox
    Public WithEvents _tabTrunkSite_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents cmdEZGrabTrunk As System.Windows.Forms.Button
    Public WithEvents cmdDeleteTrunkFreq As System.Windows.Forms.Button
    Public WithEvents cmdNewTrunkFreq As System.Windows.Forms.Button
    Public WithEvents _tabTrunkSite_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents _Label59_16 As System.Windows.Forms.Label
    Public WithEvents _tabTrunkSite_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents tabTrunkSite As System.Windows.Forms.TabControl
    Public WithEvents _cmbSizeCode_7 As System.Windows.Forms.ComboBox
    Public WithEvents cmdSaveFleetMap As System.Windows.Forms.Button
    Public WithEvents cmbFleetMap As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSizeCode_6 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSizeCode_5 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSizeCode_4 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSizeCode_3 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSizeCode_2 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSizeCode_1 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbSizeCode_0 As System.Windows.Forms.ComboBox
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents _Label28_2 As System.Windows.Forms.Label
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents _Label28_13 As System.Windows.Forms.Label
    Public WithEvents _Label28_12 As System.Windows.Forms.Label
    Public WithEvents _Label28_11 As System.Windows.Forms.Label
    Public WithEvents _Label28_10 As System.Windows.Forms.Label
    Public WithEvents _Label28_9 As System.Windows.Forms.Label
    Public WithEvents _Label28_1 As System.Windows.Forms.Label
    Public WithEvents _Label28_0 As System.Windows.Forms.Label
    Public WithEvents frmFleetMap As System.Windows.Forms.GroupBox
    Public WithEvents _cmbAPCO_1 As System.Windows.Forms.ComboBox
    Public WithEvents _cmbAPCO_0 As System.Windows.Forms.ComboBox
    Public WithEvents _cmdFreeGQK_2 As System.Windows.Forms.Button
    Public WithEvents chkDataSkip As System.Windows.Forms.CheckBox
    Public WithEvents chkSiteLockedOut As System.Windows.Forms.CheckBox
    Public WithEvents _cmdJustCnvSys_0 As System.Windows.Forms.Button
    Public WithEvents _cmdJustCnvSys_1 As System.Windows.Forms.Button
    Public WithEvents _cmdJustCnvSys_2 As System.Windows.Forms.Button
    Public WithEvents _chkQGLCnv_1 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLCnv_2 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLCnv_3 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLCnv_4 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLCnv_5 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLCnv_6 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLCnv_7 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLCnv_8 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLCnv_9 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLCnv_10 As System.Windows.Forms.CheckBox
    Public WithEvents _optConvTapeOut_2 As System.Windows.Forms.RadioButton
    Public WithEvents _optConvTapeOut_1 As System.Windows.Forms.RadioButton
    Public WithEvents _optConvTapeOut_0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame13 As System.Windows.Forms.GroupBox
    Public WithEvents cmbConvStartupKey As System.Windows.Forms.ComboBox
    Public WithEvents cmbConvDelayTime As System.Windows.Forms.ComboBox
    Public WithEvents cmbConvHoldTime As System.Windows.Forms.ComboBox
    Public WithEvents cmdSysGPS As System.Windows.Forms.Button
    Public WithEvents chkSysGPSEnable As System.Windows.Forms.CheckBox
    Public WithEvents _Label27_2 As System.Windows.Forms.Label
    Public WithEvents _Label59_18 As System.Windows.Forms.Label
    Public WithEvents _Label59_17 As System.Windows.Forms.Label
    Public WithEvents lblSysLong As System.Windows.Forms.Label
    Public WithEvents lblSysLat As System.Windows.Forms.Label
    Public WithEvents lblSysRange As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cmbQuickKey As System.Windows.Forms.ComboBox
    Public WithEvents txtSiteName As System.Windows.Forms.TextBox
    Public WithEvents _Label28_25 As System.Windows.Forms.Label
    Public WithEvents _Label28_35 As System.Windows.Forms.Label
    Public WithEvents _Label28_34 As System.Windows.Forms.Label
    Public WithEvents _Label28_24 As System.Windows.Forms.Label
    Public WithEvents _frmSiteOptConv_0 As System.Windows.Forms.GroupBox
    Public WithEvents cmbTrnSysType As System.Windows.Forms.ComboBox
    Public WithEvents _cmdJustTrnSys_0 As System.Windows.Forms.Button
    Public WithEvents _cmdJustTrnSys_1 As System.Windows.Forms.Button
    Public WithEvents _cmdJustTrnSys_2 As System.Windows.Forms.Button
    Public WithEvents _chkQGLTrn_10 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLTrn_9 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLTrn_8 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLTrn_7 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLTrn_6 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLTrn_5 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLTrn_4 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLTrn_3 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLTrn_2 As System.Windows.Forms.CheckBox
    Public WithEvents _chkQGLTrn_1 As System.Windows.Forms.CheckBox
    Public WithEvents _optTrnRecord_2 As System.Windows.Forms.RadioButton
    Public WithEvents _optTrnRecord_1 As System.Windows.Forms.RadioButton
    Public WithEvents _optTrnRecord_0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame14 As System.Windows.Forms.GroupBox
    Public WithEvents optIDSearch As System.Windows.Forms.RadioButton
    Public WithEvents optIDScan As System.Windows.Forms.RadioButton
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents cmbTrunkSysDelay As System.Windows.Forms.ComboBox
    Public WithEvents txtTrunkSysName As System.Windows.Forms.TextBox
    Public WithEvents cmdEditFleetMap As System.Windows.Forms.Button
    Public WithEvents optEDACSIDDec As System.Windows.Forms.RadioButton
    Public WithEvents optEDACSIDAFS As System.Windows.Forms.RadioButton
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents chkMotDigEndCode As System.Windows.Forms.CheckBox
    Public WithEvents cmbTrnEmergAlertLevel As System.Windows.Forms.ComboBox
    Public WithEvents cmbTrnEmergAlertType As System.Windows.Forms.ComboBox
    Public WithEvents chkMotStatusBit As System.Windows.Forms.CheckBox
    Public WithEvents chkUseMotEndCode As System.Windows.Forms.CheckBox
    Public WithEvents chkICall As System.Windows.Forms.CheckBox
    Public WithEvents _Label28_23 As System.Windows.Forms.Label
    Public WithEvents _Label28_22 As System.Windows.Forms.Label
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents lblTGIDStat As System.Windows.Forms.Label
    Public WithEvents _Label28_21 As System.Windows.Forms.Label
    Public WithEvents frmTrunkSys As System.Windows.Forms.GroupBox
    Public WithEvents _cmdJustTGIDChan_2 As System.Windows.Forms.Button
    Public WithEvents _cmdJustTGIDChan_1 As System.Windows.Forms.Button
    Public WithEvents _cmdJustTGIDChan_0 As System.Windows.Forms.Button
    Public WithEvents cmdMoveDownTGID As System.Windows.Forms.Button
    Public WithEvents cmdMoveUpTGID As System.Windows.Forms.Button
    Public WithEvents cmdNewTGID As System.Windows.Forms.Button
    Public WithEvents cmdDelTGID As System.Windows.Forms.Button
    Public WithEvents cmdEZGrabTGID As System.Windows.Forms.Button
    Public WithEvents _cmdFreeGQK_1 As System.Windows.Forms.Button
    Public WithEvents _cmdJustTGID_2 As System.Windows.Forms.Button
    Public WithEvents _cmdJustTGID_1 As System.Windows.Forms.Button
    Public WithEvents _cmdJustTGID_0 As System.Windows.Forms.Button
    Public WithEvents cmbTGIDGroupQuickkey As System.Windows.Forms.ComboBox
    Public WithEvents txtTGIDGroupName As System.Windows.Forms.TextBox
    Public WithEvents chkTGIDGroupLockout As System.Windows.Forms.CheckBox
    Public WithEvents _Label28_26 As System.Windows.Forms.Label
    Public WithEvents frmGroupTrunk As System.Windows.Forms.GroupBox
    Public WithEvents cmdDeleteConvChan As System.Windows.Forms.Button
    Public WithEvents cmdNewConvChannel As System.Windows.Forms.Button
    Public WithEvents cmdConvChanMoveUp As System.Windows.Forms.Button
    Public WithEvents cmdConvChannelMoveDown As System.Windows.Forms.Button
    Public WithEvents cmdConvGrab As System.Windows.Forms.Button
    Public WithEvents _cmdJust_0 As System.Windows.Forms.Button
    Public WithEvents _cmdJust_1 As System.Windows.Forms.Button
    Public WithEvents _cmdJust_2 As System.Windows.Forms.Button
    Public WithEvents cmdCnvPicPick As System.Windows.Forms.Button
    Public WithEvents chkCnvPic As System.Windows.Forms.CheckBox
    Public WithEvents _cmdFreeGQK_0 As System.Windows.Forms.Button
    Public WithEvents _cmdJustCnvGrp_2 As System.Windows.Forms.Button
    Public WithEvents _cmdJustCnvGrp_1 As System.Windows.Forms.Button
    Public WithEvents _cmdJustCnvGrp_0 As System.Windows.Forms.Button
    Public WithEvents cmbConvGroupQuickKey As System.Windows.Forms.ComboBox
    Public WithEvents txtConvGroupName As System.Windows.Forms.TextBox
    Public WithEvents chkConvGroupLockout As System.Windows.Forms.CheckBox
    Public WithEvents _Label28_37 As System.Windows.Forms.Label
    Public WithEvents _Label28_41 As System.Windows.Forms.Label
    Public WithEvents frmGroupConv As System.Windows.Forms.GroupBox
    Public WithEvents _StatusBar_Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents _StatusBar_Panel2 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Public WithEvents treeSystems As System.Windows.Forms.TreeView
    'Public CommonDialogOpen As System.Windows.Forms.OpenFileDialog
    'Public CommonDialogSave As System.Windows.Forms.SaveFileDialog
    'Public CommonDialogColor As System.Windows.Forms.ColorDialog
    Public WithEvents imgNull As System.Windows.Forms.PictureBox
    Public WithEvents imgLock As System.Windows.Forms.PictureBox
    Public WithEvents Label27 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label28 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label59 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Sep7 As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
    Public WithEvents chkQGLCnv As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
    Public WithEvents chkQGLTrn As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
    Public WithEvents cmbAPCO As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
    Public WithEvents cmbSizeCode As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
    Public WithEvents cmdFreeGQK As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdJust As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdJustCnvGrp As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdJustCnvSys As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdJustTGID As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdJustTGIDChan As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdJustTrnSite As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdJustTrnSys As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdToolBar As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents frmSiteOptConv As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    Public WithEvents mnuFavArray As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
    Public WithEvents mnuLastFile As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
    Public WithEvents mnuPopSel As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
    Public WithEvents optConvTapeOut As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    Public WithEvents optTrnRecord As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    Public WithEvents txtAPCOBP As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents txtAPCOBPStep As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents mnuFileNew As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuImportFreeSCAN As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuImportMEM As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuImportUASD As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuImportRadRefConv As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuImportRadRefTrunk As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuImport As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuExportSngSys As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuExportAllSys As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuExport As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuShowStat As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Sep11 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuFilePrint As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Sep12 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents _mnuLastFile_0 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuLastFile_1 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuLastFile_2 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _mnuLastFile_3 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSep2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuExitSaveChanges As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuDeleteSystem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _Sep7_0 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuCutChannel As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuCopyChannel As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuPasteChannel As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents sep3 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuEditJustChan As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSortByNameAscending As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSortByNameDescending As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSortByName As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSortByFreqAscending As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSortByFreqDescending As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSortByFreq As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSort As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSep3 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuFind As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuProgramming As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuEditSysQK As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuEditFreqFill As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuToolsAutoOpt As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFindDupSystem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFindDupGlobal As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFindDupGlobalTGID As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuDupFind As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuToolsChanLockout As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuToolsScanner As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuLockoutAll As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuUnlockAll As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuToolsUL As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuToolsDL As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuToolsControl As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuToolsSetup As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuScanner As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHighlightSite As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuGroupHighlight As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHighlight As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuQuickDrawOff As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuQuickDrawOn As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuQuickDrawAUto As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuUseQuickDraw As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuShowSysType As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuShowQK As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuTreeSort As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuTree As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFavAdd As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFavOrg As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFavSep As System.Windows.Forms.ToolStripSeparator
    Public WithEvents _mnuFavArray_0 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFav As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelpOnline As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuCheckUpdate As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnHelp As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim _Label28_17 As System.Windows.Forms.Label
        Dim _Label28_18 As System.Windows.Forms.Label
        Dim _Label28_6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lblSiteNote))
        Dim _Label28_5 As System.Windows.Forms.Label
        Dim _Label28_4 As System.Windows.Forms.Label
        Dim _Label28_3 As System.Windows.Forms.Label
        Dim _Label28_38 As System.Windows.Forms.Label
        Dim _Label28_36 As System.Windows.Forms.Label
        Dim _Label28_19 As System.Windows.Forms.Label
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim Label15 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim GroupBox2 As System.Windows.Forms.GroupBox
        Dim Label6 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtP25NacSearch = New System.Windows.Forms.TextBox()
        Me.chkTrnPriScan = New System.Windows.Forms.CheckBox()
        Me.chkTrnSysProtect = New System.Windows.Forms.CheckBox()
        Me.cmbTrnAltCol = New System.Windows.Forms.ComboBox()
        Me.cmbTrnAltPat = New System.Windows.Forms.ComboBox()
        Me.txtTrnNumTag = New System.Windows.Forms.TextBox()
        Me.chkTrnAGCD = New System.Windows.Forms.CheckBox()
        Me.chkTrnAGCA = New System.Windows.Forms.CheckBox()
        Me.cmbCnvP25Wait = New System.Windows.Forms.ComboBox()
        Me.txtCnvNumTag = New System.Windows.Forms.TextBox()
        Me.chkCnvAGCD = New System.Windows.Forms.CheckBox()
        Me.chkCnvAGCA = New System.Windows.Forms.CheckBox()
        Me.lblSiteNote1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdAutoCalcBP = New System.Windows.Forms.Button()
        Me._cmdJustTrnSite_2 = New System.Windows.Forms.Button()
        Me._cmdJustTrnSite_1 = New System.Windows.Forms.Button()
        Me._cmdJustTrnSite_0 = New System.Windows.Forms.Button()
        Me._cmdJustCnvSys_0 = New System.Windows.Forms.Button()
        Me._cmdJustCnvSys_1 = New System.Windows.Forms.Button()
        Me._cmdJustCnvSys_2 = New System.Windows.Forms.Button()
        Me.cmbConvDelayTime = New System.Windows.Forms.ComboBox()
        Me.cmbConvHoldTime = New System.Windows.Forms.ComboBox()
        Me.chkMotDigEndCode = New System.Windows.Forms.CheckBox()
        Me.cmdMoveDownTGID = New System.Windows.Forms.Button()
        Me.cmdMoveUpTGID = New System.Windows.Forms.Button()
        Me.cmdNewTGID = New System.Windows.Forms.Button()
        Me.cmdDelTGID = New System.Windows.Forms.Button()
        Me.cmdDeleteConvChan = New System.Windows.Forms.Button()
        Me.cmdNewConvChannel = New System.Windows.Forms.Button()
        Me.cmdConvChanMoveUp = New System.Windows.Forms.Button()
        Me.cmdConvChannelMoveDown = New System.Windows.Forms.Button()
        Me.chkCnvPic = New System.Windows.Forms.CheckBox()
        Me.chkCnvSysProtect = New System.Windows.Forms.CheckBox()
        Me.cmbTrnSiteHoldTime = New System.Windows.Forms.ComboBox()
        Me.cmbTrnSysQK = New System.Windows.Forms.ComboBox()
        Me.cmbTrunkSysDelay = New System.Windows.Forms.ComboBox()
        Me.cmbConvState = New System.Windows.Forms.ComboBox()
        Me.cmbConvStartupKey = New System.Windows.Forms.ComboBox()
        Me.cmbQuickKey = New System.Windows.Forms.ComboBox()
        Me._cmdJustTGID_2 = New System.Windows.Forms.Button()
        Me._cmdJustTGID_1 = New System.Windows.Forms.Button()
        Me._cmdJustTGID_0 = New System.Windows.Forms.Button()
        Me._cmdJustTGIDChan_2 = New System.Windows.Forms.Button()
        Me.cmbTGIDGroupQuickkey = New System.Windows.Forms.ComboBox()
        Me._cmdJustTGIDChan_1 = New System.Windows.Forms.Button()
        Me._cmdJustTGIDChan_0 = New System.Windows.Forms.Button()
        Me.chkSimpleView = New System.Windows.Forms.CheckBox()
        Me._cmdJustCnvGrp_2 = New System.Windows.Forms.Button()
        Me._cmdJustCnvGrp_1 = New System.Windows.Forms.Button()
        Me._cmdJustCnvGrp_0 = New System.Windows.Forms.Button()
        Me.cmbConvGroupQuickKey = New System.Windows.Forms.ComboBox()
        Me._cmdJust_0 = New System.Windows.Forms.Button()
        Me._cmdJust_1 = New System.Windows.Forms.Button()
        Me._cmdJust_2 = New System.Windows.Forms.Button()
        Me.tabTrunkSite = New System.Windows.Forms.TabControl()
        Me._tabTrunkSite_TabPage0 = New System.Windows.Forms.TabPage()
        Me.cmbSiteState = New System.Windows.Forms.ComboBox()
        Me.cmbTrnP25Wait = New System.Windows.Forms.ComboBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.grdReband = New System.Windows.Forms.DataGridView()
        Me.grdReband_LowFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReband_UpperFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReband_Step = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdReband_Offset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frame12 = New System.Windows.Forms.GroupBox()
        Me.chkTrnGPSEnable = New System.Windows.Forms.CheckBox()
        Me.cmdTrnSiteEditGPS = New System.Windows.Forms.Button()
        Me.lblTrnRange = New System.Windows.Forms.Label()
        Me.lblTrnLong = New System.Windows.Forms.Label()
        Me.lblTrnLat = New System.Windows.Forms.Label()
        Me.txtTrunkSiteName = New System.Windows.Forms.TextBox()
        Me.cmbSiteQK = New System.Windows.Forms.ComboBox()
        Me.chkTrnSiteLO = New System.Windows.Forms.CheckBox()
        Me.cmbTrnModMode = New System.Windows.Forms.ComboBox()
        Me.chkTrnSiteAtt = New System.Windows.Forms.CheckBox()
        Me.chkControlChanOnly = New System.Windows.Forms.CheckBox()
        Me.cmbTrnSiteType = New System.Windows.Forms.ComboBox()
        Me.cmbTrnSiteStartupKey = New System.Windows.Forms.ComboBox()
        Me._cmdFreeGQK_4 = New System.Windows.Forms.Button()
        Me._cmbAPCO_2 = New System.Windows.Forms.ComboBox()
        Me._cmbAPCO_3 = New System.Windows.Forms.ComboBox()
        Me._tabTrunkSite_TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdTrunkFreq = New System.Windows.Forms.DataGridView()
        Me.grdTrunkFreq_Freq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdTrunkFreq_LCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdTrunkFreq_LO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdTrunkFreq_VolOffset = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdTrunkFreq_NumTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdEZGrabTrunk = New System.Windows.Forms.Button()
        Me.cmdDeleteTrunkFreq = New System.Windows.Forms.Button()
        Me.cmdNewTrunkFreq = New System.Windows.Forms.Button()
        Me._tabTrunkSite_TabPage2 = New System.Windows.Forms.TabPage()
        Me.grdAPCO = New System.Windows.Forms.DataGridView()
        Me.grdAPCO_Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdAPCOFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdAPCO_Step = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Label59_16 = New System.Windows.Forms.Label()
        Me.frmTrunkSys = New System.Windows.Forms.GroupBox()
        Me.cmbTrnSysType = New System.Windows.Forms.ComboBox()
        Me._cmdJustTrnSys_0 = New System.Windows.Forms.Button()
        Me._cmdJustTrnSys_1 = New System.Windows.Forms.Button()
        Me._cmdJustTrnSys_2 = New System.Windows.Forms.Button()
        Me._chkQGLTrn_10 = New System.Windows.Forms.CheckBox()
        Me._chkQGLTrn_9 = New System.Windows.Forms.CheckBox()
        Me._chkQGLTrn_8 = New System.Windows.Forms.CheckBox()
        Me._chkQGLTrn_7 = New System.Windows.Forms.CheckBox()
        Me._chkQGLTrn_6 = New System.Windows.Forms.CheckBox()
        Me._chkQGLTrn_5 = New System.Windows.Forms.CheckBox()
        Me._chkQGLTrn_4 = New System.Windows.Forms.CheckBox()
        Me._chkQGLTrn_3 = New System.Windows.Forms.CheckBox()
        Me._chkQGLTrn_2 = New System.Windows.Forms.CheckBox()
        Me._chkQGLTrn_1 = New System.Windows.Forms.CheckBox()
        Me.Frame14 = New System.Windows.Forms.GroupBox()
        Me._optTrnRecord_2 = New System.Windows.Forms.RadioButton()
        Me._optTrnRecord_1 = New System.Windows.Forms.RadioButton()
        Me._optTrnRecord_0 = New System.Windows.Forms.RadioButton()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.optIDSearch = New System.Windows.Forms.RadioButton()
        Me.optIDScan = New System.Windows.Forms.RadioButton()
        Me.txtTrunkSysName = New System.Windows.Forms.TextBox()
        Me.cmdEditFleetMap = New System.Windows.Forms.Button()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.optEDACSIDDec = New System.Windows.Forms.RadioButton()
        Me.optEDACSIDAFS = New System.Windows.Forms.RadioButton()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmbTrnEmergAlertLevel = New System.Windows.Forms.ComboBox()
        Me.cmbTrnEmergAlertType = New System.Windows.Forms.ComboBox()
        Me.chkMotStatusBit = New System.Windows.Forms.CheckBox()
        Me.chkUseMotEndCode = New System.Windows.Forms.CheckBox()
        Me.chkICall = New System.Windows.Forms.CheckBox()
        Me._Label28_23 = New System.Windows.Forms.Label()
        Me._Label28_22 = New System.Windows.Forms.Label()
        Me.lblTGIDStat = New System.Windows.Forms.Label()
        Me._Label28_21 = New System.Windows.Forms.Label()
        Me._frmSiteOptConv_0 = New System.Windows.Forms.GroupBox()
        Me._cmbAPCO_1 = New System.Windows.Forms.ComboBox()
        Me._cmbAPCO_0 = New System.Windows.Forms.ComboBox()
        Me._cmdFreeGQK_2 = New System.Windows.Forms.Button()
        Me.chkDataSkip = New System.Windows.Forms.CheckBox()
        Me.chkSiteLockedOut = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_1 = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_2 = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_3 = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_4 = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_5 = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_6 = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_7 = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_8 = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_9 = New System.Windows.Forms.CheckBox()
        Me._chkQGLCnv_10 = New System.Windows.Forms.CheckBox()
        Me.Frame13 = New System.Windows.Forms.GroupBox()
        Me._optConvTapeOut_2 = New System.Windows.Forms.RadioButton()
        Me._optConvTapeOut_1 = New System.Windows.Forms.RadioButton()
        Me._optConvTapeOut_0 = New System.Windows.Forms.RadioButton()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.cmdSysGPS = New System.Windows.Forms.Button()
        Me.chkSysGPSEnable = New System.Windows.Forms.CheckBox()
        Me._Label27_2 = New System.Windows.Forms.Label()
        Me._Label59_18 = New System.Windows.Forms.Label()
        Me._Label59_17 = New System.Windows.Forms.Label()
        Me.lblSysLong = New System.Windows.Forms.Label()
        Me.lblSysLat = New System.Windows.Forms.Label()
        Me.lblSysRange = New System.Windows.Forms.Label()
        Me.txtSiteName = New System.Windows.Forms.TextBox()
        Me._Label28_25 = New System.Windows.Forms.Label()
        Me._Label28_35 = New System.Windows.Forms.Label()
        Me._Label28_34 = New System.Windows.Forms.Label()
        Me._Label28_24 = New System.Windows.Forms.Label()
        Me.frmFleetMap = New System.Windows.Forms.GroupBox()
        Me._cmbSizeCode_7 = New System.Windows.Forms.ComboBox()
        Me.cmdSaveFleetMap = New System.Windows.Forms.Button()
        Me.cmbFleetMap = New System.Windows.Forms.ComboBox()
        Me._cmbSizeCode_6 = New System.Windows.Forms.ComboBox()
        Me._cmbSizeCode_5 = New System.Windows.Forms.ComboBox()
        Me._cmbSizeCode_4 = New System.Windows.Forms.ComboBox()
        Me._cmbSizeCode_3 = New System.Windows.Forms.ComboBox()
        Me._cmbSizeCode_2 = New System.Windows.Forms.ComboBox()
        Me._cmbSizeCode_1 = New System.Windows.Forms.ComboBox()
        Me._cmbSizeCode_0 = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me._Label28_2 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me._Label28_13 = New System.Windows.Forms.Label()
        Me._Label28_12 = New System.Windows.Forms.Label()
        Me._Label28_11 = New System.Windows.Forms.Label()
        Me._Label28_10 = New System.Windows.Forms.Label()
        Me._Label28_9 = New System.Windows.Forms.Label()
        Me._Label28_1 = New System.Windows.Forms.Label()
        Me._Label28_0 = New System.Windows.Forms.Label()
        Me.frmGroupTrunk = New System.Windows.Forms.GroupBox()
        Me._cmdFreeGQK_1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdTGIDGpsEdit = New System.Windows.Forms.Button()
        Me.chkTGIDGpsEnabled = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTGIDLong = New System.Windows.Forms.Label()
        Me.lblTGIDLat = New System.Windows.Forms.Label()
        Me.lblTGIDRange = New System.Windows.Forms.Label()
        Me.chkTGIDSimpleView = New System.Windows.Forms.CheckBox()
        Me.grdTGID = New System.Windows.Forms.DataGridView()
        Me.txtTGID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTGID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colTGIDPri = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmbTGIDAlertTone = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbTGIDAlertLevel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdTGID_AltColor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdTGID_AltPat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdTGID_VolOffset = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbTGIDAudioType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdTGID_NumTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTapeOut = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtTGIDComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTGIDGroupName = New System.Windows.Forms.TextBox()
        Me.chkTGIDGroupLockout = New System.Windows.Forms.CheckBox()
        Me._Label28_26 = New System.Windows.Forms.Label()
        Me.cmdEZGrabTGID = New System.Windows.Forms.Button()
        Me.frmGroupConv = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdCnvGrpGPSEdit = New System.Windows.Forms.Button()
        Me.chkCnvGrpGPS = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCnvGrpLong = New System.Windows.Forms.Label()
        Me.lblCnvGrpLat = New System.Windows.Forms.Label()
        Me.lblCnvGrpRange = New System.Windows.Forms.Label()
        Me._cmdFreeGQK_0 = New System.Windows.Forms.Button()
        Me.grdConvChan = New System.Windows.Forms.DataGridView()
        Me.grdConvChan_Display = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdConvChan_Freq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdConvChan_LO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdConvChan_Tone = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdConvChan_ToneLO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdConvChan_Att = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdConvChan_Pri = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdConvChan_Step = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdCOnvChan_MOD = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdConvChan_NAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdConvChan_AudioType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdConvChan_AltTone = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdConvChan_AltLevel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdConvChan_AltColor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdConvChan_AltPattern = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdConvChan_VolOffset = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdConvChan_NumTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdConvChan_RecOut = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdConvChan_Comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtConvGroupName = New System.Windows.Forms.TextBox()
        Me.chkConvGroupLockout = New System.Windows.Forms.CheckBox()
        Me._Label28_37 = New System.Windows.Forms.Label()
        Me.cmdConvGrab = New System.Windows.Forms.Button()
        Me.cmdCnvPicPick = New System.Windows.Forms.Button()
        Me._Label28_41 = New System.Windows.Forms.Label()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me._StatusBar_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me._StatusBar_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.treeSystems = New System.Windows.Forms.TreeView()
        Me.mnuPopUpCon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuPopUpCon_ObjName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopUpCon_Sep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPopUpCon_NewSys = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopUpCon_NewSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopUpCon_NewGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopUpCon_Sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPopUpCon_Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopUpCon_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopUpCon_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopUpCon_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgNull = New System.Windows.Forms.PictureBox()
        Me.imgLock = New System.Windows.Forms.PictureBox()
        Me.Label27 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label28 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label59 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Sep7 = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me.chkQGLCnv = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.chkQGLTrn = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.cmbAPCO = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.cmbSizeCode = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.cmdFreeGQK = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdJust = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdJustCnvGrp = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdJustCnvSys = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdJustTGID = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdJustTGIDChan = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdJustTrnSite = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdJustTrnSys = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdToolBar = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.frmSiteOptConv = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.mnuFavArray = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me._mnuFavArray_0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLastFile = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me._mnuLastFile_0 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuLastFile_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuLastFile_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuLastFile_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopSel = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me.optConvTapeOut = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optTrnRecord = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.txtAPCOBP = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.txtAPCOBPStep = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportFreeSCAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportMEM = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportUASD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportRadRefConv = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportRadRefTrunk = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportSngSys = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportAllSys = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowStat = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sep11 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sep12 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExitSaveChanges = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProgramming = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me._Sep7_0 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCutChannel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPasteChannel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyChannel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditJustChan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortByName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortByNameAscending = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortByNameDescending = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortByFreq = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortByFreqAscending = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortByFreqDescending = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertChannelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteChannelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScanner = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsUL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsDL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.BandplanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSysQK = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditFreqFill = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsAutoOpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDupFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindDupSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindDupGlobal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindDupGlobalTGID = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsChanLockout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsScanner = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLockoutAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnlockAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.LetsDoItToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTree = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHighlight = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHighlightTrunkSys = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHighlightSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGroupHighlight = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUseQuickDraw = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuickDrawOff = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuickDrawOn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuickDrawAUto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowSysType = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowQK = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTreeSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTreeSortName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTreeSortQK = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTreeSortType = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTreeSortNone = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFav = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFavAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFavOrg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFavSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpOnline = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProfileFileSaveDlg = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ExportFileDlg = New System.Windows.Forms.SaveFileDialog()
        Me.mnuCutCopy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuMoveCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoveCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMoveCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewSysToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.NewSiteToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.NewGroupToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UploadScannerToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.DownloadScannerToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ControlScannerToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        _Label28_17 = New System.Windows.Forms.Label()
        _Label28_18 = New System.Windows.Forms.Label()
        _Label28_6 = New System.Windows.Forms.Label()
        _Label28_5 = New System.Windows.Forms.Label()
        _Label28_4 = New System.Windows.Forms.Label()
        _Label28_3 = New System.Windows.Forms.Label()
        _Label28_38 = New System.Windows.Forms.Label()
        _Label28_36 = New System.Windows.Forms.Label()
        _Label28_19 = New System.Windows.Forms.Label()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        Label15 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        GroupBox2 = New System.Windows.Forms.GroupBox()
        Label6 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Me.tabTrunkSite.SuspendLayout()
        Me._tabTrunkSite_TabPage0.SuspendLayout()
        Me.Frame9.SuspendLayout()
        CType(Me.grdReband, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame12.SuspendLayout()
        Me._tabTrunkSite_TabPage1.SuspendLayout()
        CType(Me.grdTrunkFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._tabTrunkSite_TabPage2.SuspendLayout()
        CType(Me.grdAPCO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmTrunkSys.SuspendLayout()
        Me.Frame14.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me._frmSiteOptConv_0.SuspendLayout()
        Me.Frame13.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.frmFleetMap.SuspendLayout()
        Me.frmGroupTrunk.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdTGID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmGroupConv.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdConvChan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusBar.SuspendLayout()
        Me.mnuPopUpCon.SuspendLayout()
        CType(Me.imgNull, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sep7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkQGLCnv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkQGLTrn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAPCO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSizeCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFreeGQK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdJust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdJustCnvGrp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdJustCnvSys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdJustTGID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdJustTGIDChan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdJustTrnSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdJustTrnSys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmSiteOptConv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuFavArray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuLastFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuPopSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optConvTapeOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optTrnRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPCOBP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPCOBPStep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu1.SuspendLayout()
        Me.mnuCutCopy.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Label28_17
        '
        _Label28_17.AutoSize = True
        _Label28_17.BackColor = System.Drawing.SystemColors.Control
        _Label28_17.Cursor = System.Windows.Forms.Cursors.Default
        _Label28_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label28_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(_Label28_17, CType(17, Short))
        _Label28_17.Location = New System.Drawing.Point(12, 13)
        _Label28_17.Name = "_Label28_17"
        _Label28_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label28_17.Size = New System.Drawing.Size(506, 14)
        _Label28_17.TabIndex = 157
        _Label28_17.Text = "Name:                                            Quick Key                       " & _
    "  Startup Key        APCO Mode         Threshold"
        '
        '_Label28_18
        '
        _Label28_18.BackColor = System.Drawing.SystemColors.Control
        _Label28_18.Cursor = System.Windows.Forms.Cursors.Default
        _Label28_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label28_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(_Label28_18, CType(18, Short))
        _Label28_18.Location = New System.Drawing.Point(12, 55)
        _Label28_18.Name = "_Label28_18"
        _Label28_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label28_18.Size = New System.Drawing.Size(431, 13)
        _Label28_18.TabIndex = 211
        _Label28_18.Text = "Site Type                                                                        " & _
    "         Hold Time             Modulation"
        '
        '_Label28_6
        '
        _Label28_6.BackColor = System.Drawing.SystemColors.Control
        _Label28_6.Cursor = System.Windows.Forms.Cursors.Default
        _Label28_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label28_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(_Label28_6, CType(6, Short))
        _Label28_6.Location = New System.Drawing.Point(380, 19)
        _Label28_6.Name = "_Label28_6"
        _Label28_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label28_6.Size = New System.Drawing.Size(162, 119)
        _Label28_6.TabIndex = 276
        _Label28_6.Text = resources.GetString("_Label28_6.Text")
        '
        '_Label28_5
        '
        _Label28_5.AutoSize = True
        _Label28_5.BackColor = System.Drawing.SystemColors.Control
        _Label28_5.Cursor = System.Windows.Forms.Cursors.Default
        _Label28_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label28_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(_Label28_5, CType(5, Short))
        _Label28_5.Location = New System.Drawing.Point(76, 72)
        _Label28_5.Name = "_Label28_5"
        _Label28_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label28_5.Size = New System.Drawing.Size(41, 14)
        _Label28_5.TabIndex = 141
        _Label28_5.Text = "Range:"
        '
        '_Label28_4
        '
        _Label28_4.AutoSize = True
        _Label28_4.BackColor = System.Drawing.SystemColors.Control
        _Label28_4.Cursor = System.Windows.Forms.Cursors.Default
        _Label28_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label28_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(_Label28_4, CType(4, Short))
        _Label28_4.Location = New System.Drawing.Point(56, 56)
        _Label28_4.Name = "_Label28_4"
        _Label28_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label28_4.Size = New System.Drawing.Size(60, 14)
        _Label28_4.TabIndex = 140
        _Label28_4.Text = "Longtitude:"
        '
        '_Label28_3
        '
        _Label28_3.AutoSize = True
        _Label28_3.BackColor = System.Drawing.SystemColors.Control
        _Label28_3.Cursor = System.Windows.Forms.Cursors.Default
        _Label28_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label28_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(_Label28_3, CType(3, Short))
        _Label28_3.Location = New System.Drawing.Point(68, 40)
        _Label28_3.Name = "_Label28_3"
        _Label28_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label28_3.Size = New System.Drawing.Size(48, 14)
        _Label28_3.TabIndex = 139
        _Label28_3.Text = "Latitude:"
        '
        '_Label28_38
        '
        _Label28_38.AutoSize = True
        _Label28_38.BackColor = System.Drawing.SystemColors.Control
        _Label28_38.Cursor = System.Windows.Forms.Cursors.Default
        _Label28_38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label28_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(_Label28_38, CType(38, Short))
        _Label28_38.Location = New System.Drawing.Point(24, 23)
        _Label28_38.Name = "_Label28_38"
        _Label28_38.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label28_38.Size = New System.Drawing.Size(34, 14)
        _Label28_38.TabIndex = 115
        _Label28_38.Text = "Name"
        '
        '_Label28_36
        '
        _Label28_36.AutoSize = True
        _Label28_36.BackColor = System.Drawing.SystemColors.Control
        _Label28_36.Cursor = System.Windows.Forms.Cursors.Default
        _Label28_36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label28_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(_Label28_36, CType(36, Short))
        _Label28_36.Location = New System.Drawing.Point(307, 21)
        _Label28_36.Name = "_Label28_36"
        _Label28_36.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label28_36.Size = New System.Drawing.Size(191, 14)
        _Label28_36.TabIndex = 110
        _Label28_36.Text = "TGID Group Quick Key Enable/Disable:"
        '
        '_Label28_19
        '
        _Label28_19.AutoSize = True
        _Label28_19.BackColor = System.Drawing.SystemColors.Control
        _Label28_19.Cursor = System.Windows.Forms.Cursors.Default
        _Label28_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label28_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(_Label28_19, CType(19, Short))
        _Label28_19.Location = New System.Drawing.Point(179, 22)
        _Label28_19.Name = "_Label28_19"
        _Label28_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label28_19.Size = New System.Drawing.Size(59, 14)
        _Label28_19.TabIndex = 92
        _Label28_19.Text = "Delay Time"
        '
        'GroupBox1
        '
        GroupBox1.Controls.Add(Me.txtP25NacSearch)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Me.chkTrnPriScan)
        GroupBox1.Controls.Add(Me.chkTrnSysProtect)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(Me.cmbTrnAltCol)
        GroupBox1.Controls.Add(Me.cmbTrnAltPat)
        GroupBox1.Controls.Add(Me.txtTrnNumTag)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Me.chkTrnAGCD)
        GroupBox1.Controls.Add(Me.chkTrnAGCA)
        GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        GroupBox1.Location = New System.Drawing.Point(22, 314)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(298, 147)
        GroupBox1.TabIndex = 267
        GroupBox1.TabStop = False
        GroupBox1.Text = "XT  Options"
        '
        'txtP25NacSearch
        '
        Me.txtP25NacSearch.Location = New System.Drawing.Point(6, 120)
        Me.txtP25NacSearch.MaxLength = 4
        Me.txtP25NacSearch.Name = "txtP25NacSearch"
        Me.txtP25NacSearch.Size = New System.Drawing.Size(64, 20)
        Me.txtP25NacSearch.TabIndex = 386
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.BackColor = System.Drawing.SystemColors.Control
        Label15.Cursor = System.Windows.Forms.Cursors.Default
        Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Label15.Location = New System.Drawing.Point(6, 99)
        Label15.Name = "Label15"
        Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label15.Size = New System.Drawing.Size(162, 14)
        Label15.TabIndex = 385
        Label15.Text = "P25 NAC Search (Hex or SRCH)"
        '
        'chkTrnPriScan
        '
        Me.chkTrnPriScan.AutoSize = True
        Me.chkTrnPriScan.Location = New System.Drawing.Point(6, 80)
        Me.chkTrnPriScan.Name = "chkTrnPriScan"
        Me.chkTrnPriScan.Size = New System.Drawing.Size(99, 18)
        Me.chkTrnPriScan.TabIndex = 384
        Me.chkTrnPriScan.Text = "Priority ID Scan"
        Me.ToolTip1.SetToolTip(Me.chkTrnPriScan, resources.GetString("chkTrnPriScan.ToolTip"))
        Me.chkTrnPriScan.UseVisualStyleBackColor = True
        '
        'chkTrnSysProtect
        '
        Me.chkTrnSysProtect.AutoSize = True
        Me.chkTrnSysProtect.ForeColor = System.Drawing.Color.Red
        Me.chkTrnSysProtect.Location = New System.Drawing.Point(6, 61)
        Me.chkTrnSysProtect.Name = "chkTrnSysProtect"
        Me.chkTrnSysProtect.Size = New System.Drawing.Size(147, 18)
        Me.chkTrnSysProtect.TabIndex = 383
        Me.chkTrnSysProtect.Text = "Enable System Protect (!)"
        Me.ToolTip1.SetToolTip(Me.chkTrnSysProtect, "This will prevent users from being able to make any changes to the system. CAUTIO" & _
        "N: Once enabled, this system cannot be accessed by the user or software.")
        Me.chkTrnSysProtect.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.SystemColors.Control
        Label4.Cursor = System.Windows.Forms.Cursors.Default
        Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Label4.Location = New System.Drawing.Point(138, 14)
        Label4.Name = "Label4"
        Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label4.Size = New System.Drawing.Size(149, 14)
        Label4.TabIndex = 382
        Label4.Text = "Emergency Alert Light Pattern"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.BackColor = System.Drawing.SystemColors.Control
        Label16.Cursor = System.Windows.Forms.Cursors.Default
        Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Label16.Location = New System.Drawing.Point(160, 58)
        Label16.Name = "Label16"
        Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label16.Size = New System.Drawing.Size(122, 14)
        Label16.TabIndex = 381
        Label16.Text = "Emerg Alert Light Colour"
        '
        'cmbTrnAltCol
        '
        Me.cmbTrnAltCol.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnAltCol.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnAltCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnAltCol.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnAltCol.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnAltCol.Location = New System.Drawing.Point(177, 76)
        Me.cmbTrnAltCol.Name = "cmbTrnAltCol"
        Me.cmbTrnAltCol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnAltCol.Size = New System.Drawing.Size(81, 22)
        Me.cmbTrnAltCol.TabIndex = 380
        '
        'cmbTrnAltPat
        '
        Me.cmbTrnAltPat.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnAltPat.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnAltPat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnAltPat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnAltPat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnAltPat.Location = New System.Drawing.Point(176, 31)
        Me.cmbTrnAltPat.Name = "cmbTrnAltPat"
        Me.cmbTrnAltPat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnAltPat.Size = New System.Drawing.Size(81, 22)
        Me.cmbTrnAltPat.TabIndex = 379
        '
        'txtTrnNumTag
        '
        Me.txtTrnNumTag.Location = New System.Drawing.Point(186, 117)
        Me.txtTrnNumTag.MaxLength = 4
        Me.txtTrnNumTag.Name = "txtTrnNumTag"
        Me.txtTrnNumTag.Size = New System.Drawing.Size(64, 20)
        Me.txtTrnNumTag.TabIndex = 94
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.SystemColors.Control
        Label2.Cursor = System.Windows.Forms.Cursors.Default
        Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Label2.Location = New System.Drawing.Point(184, 99)
        Label2.Name = "Label2"
        Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label2.Size = New System.Drawing.Size(64, 14)
        Label2.TabIndex = 93
        Label2.Text = "Number Tag"
        '
        'chkTrnAGCD
        '
        Me.chkTrnAGCD.AutoSize = True
        Me.chkTrnAGCD.Location = New System.Drawing.Point(6, 43)
        Me.chkTrnAGCD.Name = "chkTrnAGCD"
        Me.chkTrnAGCD.Size = New System.Drawing.Size(114, 18)
        Me.chkTrnAGCD.TabIndex = 1
        Me.chkTrnAGCD.Text = "Enable D&igital AGC"
        Me.ToolTip1.SetToolTip(Me.chkTrnAGCD, "Digital XT Only")
        Me.chkTrnAGCD.UseVisualStyleBackColor = True
        '
        'chkTrnAGCA
        '
        Me.chkTrnAGCA.AutoSize = True
        Me.chkTrnAGCA.Location = New System.Drawing.Point(6, 24)
        Me.chkTrnAGCA.Name = "chkTrnAGCA"
        Me.chkTrnAGCA.Size = New System.Drawing.Size(119, 18)
        Me.chkTrnAGCA.TabIndex = 0
        Me.chkTrnAGCA.Text = "Enable &Analog AGC"
        Me.ToolTip1.SetToolTip(Me.chkTrnAGCA, "Digital XT Only")
        Me.chkTrnAGCA.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        GroupBox2.Controls.Add(Me.cmbCnvP25Wait)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Me.txtCnvNumTag)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Me.chkCnvAGCD)
        GroupBox2.Controls.Add(Me.chkCnvAGCA)
        GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        GroupBox2.Location = New System.Drawing.Point(385, 139)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New System.Drawing.Size(232, 115)
        GroupBox2.TabIndex = 270
        GroupBox2.TabStop = False
        GroupBox2.Text = "XT  Options"
        '
        'cmbCnvP25Wait
        '
        Me.cmbCnvP25Wait.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCnvP25Wait.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCnvP25Wait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCnvP25Wait.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCnvP25Wait.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCnvP25Wait.Location = New System.Drawing.Point(147, 38)
        Me.cmbCnvP25Wait.Name = "cmbCnvP25Wait"
        Me.cmbCnvP25Wait.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCnvP25Wait.Size = New System.Drawing.Size(73, 22)
        Me.cmbCnvP25Wait.TabIndex = 275
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.SystemColors.Control
        Label6.Cursor = System.Windows.Forms.Cursors.Default
        Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Label6.Location = New System.Drawing.Point(146, 22)
        Label6.Name = "Label6"
        Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label6.Size = New System.Drawing.Size(74, 14)
        Label6.TabIndex = 274
        Label6.Text = "P25 Wait Time"
        '
        'txtCnvNumTag
        '
        Me.txtCnvNumTag.Location = New System.Drawing.Point(9, 81)
        Me.txtCnvNumTag.MaxLength = 4
        Me.txtCnvNumTag.Name = "txtCnvNumTag"
        Me.txtCnvNumTag.Size = New System.Drawing.Size(64, 20)
        Me.txtCnvNumTag.TabIndex = 21
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.SystemColors.Control
        Label3.Cursor = System.Windows.Forms.Cursors.Default
        Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Label3.Location = New System.Drawing.Point(7, 65)
        Label3.Name = "Label3"
        Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label3.Size = New System.Drawing.Size(64, 14)
        Label3.TabIndex = 93
        Label3.Text = "Number Tag"
        '
        'chkCnvAGCD
        '
        Me.chkCnvAGCD.AutoSize = True
        Me.chkCnvAGCD.Location = New System.Drawing.Point(7, 43)
        Me.chkCnvAGCD.Name = "chkCnvAGCD"
        Me.chkCnvAGCD.Size = New System.Drawing.Size(114, 18)
        Me.chkCnvAGCD.TabIndex = 20
        Me.chkCnvAGCD.Text = "Enable D&igital AGC"
        Me.ToolTip1.SetToolTip(Me.chkCnvAGCD, "BCD396XT Only")
        Me.chkCnvAGCD.UseVisualStyleBackColor = True
        '
        'chkCnvAGCA
        '
        Me.chkCnvAGCA.AutoSize = True
        Me.chkCnvAGCA.Location = New System.Drawing.Point(7, 24)
        Me.chkCnvAGCA.Name = "chkCnvAGCA"
        Me.chkCnvAGCA.Size = New System.Drawing.Size(119, 18)
        Me.chkCnvAGCA.TabIndex = 19
        Me.chkCnvAGCA.Text = "Enable &Analog AGC"
        Me.ToolTip1.SetToolTip(Me.chkCnvAGCA, "BCD396XT Only")
        Me.chkCnvAGCA.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.SystemColors.Control
        Label5.Cursor = System.Windows.Forms.Cursors.Default
        Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Label5.Location = New System.Drawing.Point(466, 55)
        Label5.Name = "Label5"
        Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label5.Size = New System.Drawing.Size(154, 14)
        Label5.TabIndex = 272
        Label5.Text = "P25 Wait Time (Digital XT Only)"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.BackColor = System.Drawing.SystemColors.Control
        Label13.Cursor = System.Windows.Forms.Cursors.Default
        Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Label13.Location = New System.Drawing.Point(241, 21)
        Label13.Name = "Label13"
        Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label13.Size = New System.Drawing.Size(56, 14)
        Label13.TabIndex = 269
        Label13.Text = "Quick Key"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.SystemColors.Control
        Label1.Cursor = System.Windows.Forms.Cursors.Default
        Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Label1.Location = New System.Drawing.Point(542, 13)
        Label1.Name = "Label1"
        Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label1.Size = New System.Drawing.Size(32, 14)
        Label1.TabIndex = 275
        Label1.Text = "State"
        Me.ToolTip1.SetToolTip(Label1, "BCT15 / BCT15X Only")
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.BackColor = System.Drawing.SystemColors.Control
        Label14.Cursor = System.Windows.Forms.Cursors.Default
        Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Label14.Location = New System.Drawing.Point(402, 76)
        Label14.Name = "Label14"
        Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label14.Size = New System.Drawing.Size(32, 14)
        Label14.TabIndex = 385
        Label14.Text = "State"
        Me.ToolTip1.SetToolTip(Label14, "BCT15 / BCT15X Only")
        '
        'lblSiteNote1
        '
        Me.lblSiteNote1.AutoEllipsis = True
        Me.lblSiteNote1.BackColor = System.Drawing.SystemColors.Control
        Me.lblSiteNote1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSiteNote1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSiteNote1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSiteNote1.Location = New System.Drawing.Point(155, 101)
        Me.lblSiteNote1.Name = "lblSiteNote1"
        Me.lblSiteNote1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSiteNote1.Size = New System.Drawing.Size(404, 50)
        Me.lblSiteNote1.TabIndex = 274
        Me.lblSiteNote1.Text = "SIteNotes"
        '
        'cmdAutoCalcBP
        '
        Me.cmdAutoCalcBP.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAutoCalcBP.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAutoCalcBP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAutoCalcBP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAutoCalcBP.Location = New System.Drawing.Point(416, 142)
        Me.cmdAutoCalcBP.Name = "cmdAutoCalcBP"
        Me.cmdAutoCalcBP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAutoCalcBP.Size = New System.Drawing.Size(84, 27)
        Me.cmdAutoCalcBP.TabIndex = 275
        Me.cmdAutoCalcBP.Text = "A&uto Upper"
        Me.ToolTip1.SetToolTip(Me.cmdAutoCalcBP, "Click here to automatically calculate the upper frequency")
        Me.cmdAutoCalcBP.UseVisualStyleBackColor = True
        '
        '_cmdJustTrnSite_2
        '
        Me._cmdJustTrnSite_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTrnSite_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTrnSite_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTrnSite_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTrnSite_2.Image = CType(resources.GetObject("_cmdJustTrnSite_2.Image"), System.Drawing.Image)
        Me.cmdJustTrnSite.SetIndex(Me._cmdJustTrnSite_2, CType(2, Short))
        Me._cmdJustTrnSite_2.Location = New System.Drawing.Point(140, 8)
        Me._cmdJustTrnSite_2.Name = "_cmdJustTrnSite_2"
        Me._cmdJustTrnSite_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTrnSite_2.Size = New System.Drawing.Size(19, 20)
        Me._cmdJustTrnSite_2.TabIndex = 151
        Me._cmdJustTrnSite_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustTrnSite_2, "Right Justify")
        Me._cmdJustTrnSite_2.UseVisualStyleBackColor = True
        '
        '_cmdJustTrnSite_1
        '
        Me._cmdJustTrnSite_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTrnSite_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTrnSite_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTrnSite_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTrnSite_1.Image = CType(resources.GetObject("_cmdJustTrnSite_1.Image"), System.Drawing.Image)
        Me.cmdJustTrnSite.SetIndex(Me._cmdJustTrnSite_1, CType(1, Short))
        Me._cmdJustTrnSite_1.Location = New System.Drawing.Point(120, 8)
        Me._cmdJustTrnSite_1.Name = "_cmdJustTrnSite_1"
        Me._cmdJustTrnSite_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTrnSite_1.Size = New System.Drawing.Size(19, 20)
        Me._cmdJustTrnSite_1.TabIndex = 152
        Me._cmdJustTrnSite_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustTrnSite_1, "Center Justify")
        Me._cmdJustTrnSite_1.UseVisualStyleBackColor = True
        '
        '_cmdJustTrnSite_0
        '
        Me._cmdJustTrnSite_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTrnSite_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTrnSite_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTrnSite_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTrnSite_0.Image = CType(resources.GetObject("_cmdJustTrnSite_0.Image"), System.Drawing.Image)
        Me.cmdJustTrnSite.SetIndex(Me._cmdJustTrnSite_0, CType(0, Short))
        Me._cmdJustTrnSite_0.Location = New System.Drawing.Point(100, 8)
        Me._cmdJustTrnSite_0.Name = "_cmdJustTrnSite_0"
        Me._cmdJustTrnSite_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTrnSite_0.Size = New System.Drawing.Size(19, 20)
        Me._cmdJustTrnSite_0.TabIndex = 153
        Me._cmdJustTrnSite_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustTrnSite_0, "Left Justify")
        Me._cmdJustTrnSite_0.UseVisualStyleBackColor = True
        '
        '_cmdJustCnvSys_0
        '
        Me._cmdJustCnvSys_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustCnvSys_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustCnvSys_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustCnvSys_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustCnvSys_0.Image = CType(resources.GetObject("_cmdJustCnvSys_0.Image"), System.Drawing.Image)
        Me.cmdJustCnvSys.SetIndex(Me._cmdJustCnvSys_0, CType(0, Short))
        Me._cmdJustCnvSys_0.Location = New System.Drawing.Point(104, 19)
        Me._cmdJustCnvSys_0.Name = "_cmdJustCnvSys_0"
        Me._cmdJustCnvSys_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustCnvSys_0.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustCnvSys_0.TabIndex = 2
        Me._cmdJustCnvSys_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustCnvSys_0, "Justify Left")
        Me._cmdJustCnvSys_0.UseVisualStyleBackColor = True
        '
        '_cmdJustCnvSys_1
        '
        Me._cmdJustCnvSys_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustCnvSys_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustCnvSys_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustCnvSys_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustCnvSys_1.Image = CType(resources.GetObject("_cmdJustCnvSys_1.Image"), System.Drawing.Image)
        Me.cmdJustCnvSys.SetIndex(Me._cmdJustCnvSys_1, CType(1, Short))
        Me._cmdJustCnvSys_1.Location = New System.Drawing.Point(124, 19)
        Me._cmdJustCnvSys_1.Name = "_cmdJustCnvSys_1"
        Me._cmdJustCnvSys_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustCnvSys_1.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustCnvSys_1.TabIndex = 3
        Me._cmdJustCnvSys_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustCnvSys_1, "Center Justify")
        Me._cmdJustCnvSys_1.UseVisualStyleBackColor = True
        '
        '_cmdJustCnvSys_2
        '
        Me._cmdJustCnvSys_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustCnvSys_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustCnvSys_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustCnvSys_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustCnvSys_2.Image = CType(resources.GetObject("_cmdJustCnvSys_2.Image"), System.Drawing.Image)
        Me.cmdJustCnvSys.SetIndex(Me._cmdJustCnvSys_2, CType(2, Short))
        Me._cmdJustCnvSys_2.Location = New System.Drawing.Point(144, 19)
        Me._cmdJustCnvSys_2.Name = "_cmdJustCnvSys_2"
        Me._cmdJustCnvSys_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustCnvSys_2.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustCnvSys_2.TabIndex = 4
        Me._cmdJustCnvSys_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustCnvSys_2, "Right Justify")
        Me._cmdJustCnvSys_2.UseVisualStyleBackColor = True
        '
        'cmbConvDelayTime
        '
        Me.cmbConvDelayTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbConvDelayTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbConvDelayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConvDelayTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConvDelayTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConvDelayTime.Location = New System.Drawing.Point(320, 92)
        Me.cmbConvDelayTime.Name = "cmbConvDelayTime"
        Me.cmbConvDelayTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbConvDelayTime.Size = New System.Drawing.Size(65, 22)
        Me.cmbConvDelayTime.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.cmbConvDelayTime, "How long the scanner should wait after channel activety before resuming scanning")
        '
        'cmbConvHoldTime
        '
        Me.cmbConvHoldTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbConvHoldTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbConvHoldTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConvHoldTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConvHoldTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConvHoldTime.Location = New System.Drawing.Point(168, 92)
        Me.cmbConvHoldTime.Name = "cmbConvHoldTime"
        Me.cmbConvHoldTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbConvHoldTime.Size = New System.Drawing.Size(65, 22)
        Me.cmbConvHoldTime.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.cmbConvHoldTime, "Minimum amount of time the scanner will spend scanning the system before moving o" & _
        "n to the next")
        '
        'chkMotDigEndCode
        '
        Me.chkMotDigEndCode.BackColor = System.Drawing.SystemColors.Control
        Me.chkMotDigEndCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMotDigEndCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMotDigEndCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMotDigEndCode.Location = New System.Drawing.Point(10, 57)
        Me.chkMotDigEndCode.Name = "chkMotDigEndCode"
        Me.chkMotDigEndCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMotDigEndCode.Size = New System.Drawing.Size(191, 17)
        Me.chkMotDigEndCode.TabIndex = 267
        Me.chkMotDigEndCode.Text = "U&se Digital  Motorola End Code"
        Me.ToolTip1.SetToolTip(Me.chkMotDigEndCode, "Applies to 396/996 with firmware 3.0+ only.")
        Me.chkMotDigEndCode.UseVisualStyleBackColor = True
        '
        'cmdMoveDownTGID
        '
        Me.cmdMoveDownTGID.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoveDownTGID.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoveDownTGID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveDownTGID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoveDownTGID.Image = CType(resources.GetObject("cmdMoveDownTGID.Image"), System.Drawing.Image)
        Me.cmdMoveDownTGID.Location = New System.Drawing.Point(316, 83)
        Me.cmdMoveDownTGID.Name = "cmdMoveDownTGID"
        Me.cmdMoveDownTGID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoveDownTGID.Size = New System.Drawing.Size(29, 27)
        Me.cmdMoveDownTGID.TabIndex = 48
        Me.cmdMoveDownTGID.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdMoveDownTGID, "Move Down")
        Me.cmdMoveDownTGID.UseVisualStyleBackColor = True
        '
        'cmdMoveUpTGID
        '
        Me.cmdMoveUpTGID.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoveUpTGID.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoveUpTGID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveUpTGID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoveUpTGID.Image = CType(resources.GetObject("cmdMoveUpTGID.Image"), System.Drawing.Image)
        Me.cmdMoveUpTGID.Location = New System.Drawing.Point(283, 83)
        Me.cmdMoveUpTGID.Name = "cmdMoveUpTGID"
        Me.cmdMoveUpTGID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoveUpTGID.Size = New System.Drawing.Size(29, 27)
        Me.cmdMoveUpTGID.TabIndex = 47
        Me.cmdMoveUpTGID.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdMoveUpTGID, "Move Up")
        Me.cmdMoveUpTGID.UseVisualStyleBackColor = True
        '
        'cmdNewTGID
        '
        Me.cmdNewTGID.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewTGID.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewTGID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewTGID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewTGID.Image = CType(resources.GetObject("cmdNewTGID.Image"), System.Drawing.Image)
        Me.cmdNewTGID.Location = New System.Drawing.Point(209, 83)
        Me.cmdNewTGID.Name = "cmdNewTGID"
        Me.cmdNewTGID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewTGID.Size = New System.Drawing.Size(29, 27)
        Me.cmdNewTGID.TabIndex = 45
        Me.cmdNewTGID.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdNewTGID, "New TGID")
        Me.cmdNewTGID.UseVisualStyleBackColor = True
        '
        'cmdDelTGID
        '
        Me.cmdDelTGID.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelTGID.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelTGID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelTGID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelTGID.Image = CType(resources.GetObject("cmdDelTGID.Image"), System.Drawing.Image)
        Me.cmdDelTGID.Location = New System.Drawing.Point(242, 83)
        Me.cmdDelTGID.Name = "cmdDelTGID"
        Me.cmdDelTGID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelTGID.Size = New System.Drawing.Size(29, 27)
        Me.cmdDelTGID.TabIndex = 46
        Me.cmdDelTGID.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdDelTGID, "Delete TGID")
        Me.cmdDelTGID.UseVisualStyleBackColor = True
        '
        'cmdDeleteConvChan
        '
        Me.cmdDeleteConvChan.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteConvChan.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteConvChan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteConvChan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteConvChan.Image = CType(resources.GetObject("cmdDeleteConvChan.Image"), System.Drawing.Image)
        Me.cmdDeleteConvChan.Location = New System.Drawing.Point(227, 90)
        Me.cmdDeleteConvChan.Name = "cmdDeleteConvChan"
        Me.cmdDeleteConvChan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteConvChan.Size = New System.Drawing.Size(29, 27)
        Me.cmdDeleteConvChan.TabIndex = 237
        Me.cmdDeleteConvChan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdDeleteConvChan, "Delete Channel")
        Me.cmdDeleteConvChan.UseVisualStyleBackColor = True
        '
        'cmdNewConvChannel
        '
        Me.cmdNewConvChannel.AccessibleDescription = "Add new channel ACCess"
        Me.cmdNewConvChannel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewConvChannel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewConvChannel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewConvChannel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewConvChannel.Image = CType(resources.GetObject("cmdNewConvChannel.Image"), System.Drawing.Image)
        Me.cmdNewConvChannel.Location = New System.Drawing.Point(194, 90)
        Me.cmdNewConvChannel.Name = "cmdNewConvChannel"
        Me.cmdNewConvChannel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewConvChannel.Size = New System.Drawing.Size(29, 27)
        Me.cmdNewConvChannel.TabIndex = 236
        Me.cmdNewConvChannel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdNewConvChannel, "New Channel")
        Me.cmdNewConvChannel.UseVisualStyleBackColor = True
        '
        'cmdConvChanMoveUp
        '
        Me.cmdConvChanMoveUp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvChanMoveUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConvChanMoveUp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvChanMoveUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConvChanMoveUp.Image = CType(resources.GetObject("cmdConvChanMoveUp.Image"), System.Drawing.Image)
        Me.cmdConvChanMoveUp.Location = New System.Drawing.Point(284, 90)
        Me.cmdConvChanMoveUp.Name = "cmdConvChanMoveUp"
        Me.cmdConvChanMoveUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConvChanMoveUp.Size = New System.Drawing.Size(29, 27)
        Me.cmdConvChanMoveUp.TabIndex = 238
        Me.cmdConvChanMoveUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdConvChanMoveUp, "Move Channel Up")
        Me.cmdConvChanMoveUp.UseVisualStyleBackColor = True
        '
        'cmdConvChannelMoveDown
        '
        Me.cmdConvChannelMoveDown.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvChannelMoveDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConvChannelMoveDown.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvChannelMoveDown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConvChannelMoveDown.Image = CType(resources.GetObject("cmdConvChannelMoveDown.Image"), System.Drawing.Image)
        Me.cmdConvChannelMoveDown.Location = New System.Drawing.Point(317, 90)
        Me.cmdConvChannelMoveDown.Name = "cmdConvChannelMoveDown"
        Me.cmdConvChannelMoveDown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConvChannelMoveDown.Size = New System.Drawing.Size(29, 27)
        Me.cmdConvChannelMoveDown.TabIndex = 239
        Me.cmdConvChannelMoveDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdConvChannelMoveDown, "Move Channel Down")
        Me.cmdConvChannelMoveDown.UseVisualStyleBackColor = True
        '
        'chkCnvPic
        '
        Me.chkCnvPic.BackColor = System.Drawing.SystemColors.Control
        Me.chkCnvPic.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCnvPic.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCnvPic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCnvPic.Location = New System.Drawing.Point(490, 470)
        Me.chkCnvPic.Name = "chkCnvPic"
        Me.chkCnvPic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCnvPic.Size = New System.Drawing.Size(62, 17)
        Me.chkCnvPic.TabIndex = 226
        Me.chkCnvPic.Text = "Use &Pic"
        Me.ToolTip1.SetToolTip(Me.chkCnvPic, "When in Virtaul Control Mode, this pic will be automatically displayed")
        Me.chkCnvPic.UseVisualStyleBackColor = True
        Me.chkCnvPic.Visible = False
        '
        'chkCnvSysProtect
        '
        Me.chkCnvSysProtect.AutoSize = True
        Me.chkCnvSysProtect.ForeColor = System.Drawing.Color.Red
        Me.chkCnvSysProtect.Location = New System.Drawing.Point(16, 111)
        Me.chkCnvSysProtect.Name = "chkCnvSysProtect"
        Me.chkCnvSysProtect.Size = New System.Drawing.Size(147, 18)
        Me.chkCnvSysProtect.TabIndex = 384
        Me.chkCnvSysProtect.Text = "Enable System Protect (!)"
        Me.ToolTip1.SetToolTip(Me.chkCnvSysProtect, "This will prevent users from being able to make any changes to the system. CAUTIO" & _
        "N: Once enabled, this system cannot be accessed by the user or software.")
        Me.chkCnvSysProtect.UseVisualStyleBackColor = True
        '
        'cmbTrnSiteHoldTime
        '
        Me.cmbTrnSiteHoldTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnSiteHoldTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnSiteHoldTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnSiteHoldTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnSiteHoldTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnSiteHoldTime.Location = New System.Drawing.Point(301, 69)
        Me.cmbTrnSiteHoldTime.Name = "cmbTrnSiteHoldTime"
        Me.cmbTrnSiteHoldTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnSiteHoldTime.Size = New System.Drawing.Size(65, 22)
        Me.cmbTrnSiteHoldTime.TabIndex = 149
        Me.ToolTip1.SetToolTip(Me.cmbTrnSiteHoldTime, "Sets the hold time for a trunk site")
        '
        'cmbTrnSysQK
        '
        Me.cmbTrnSysQK.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnSysQK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnSysQK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnSysQK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnSysQK.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnSysQK.Location = New System.Drawing.Point(241, 37)
        Me.cmbTrnSysQK.Name = "cmbTrnSysQK"
        Me.cmbTrnSysQK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnSysQK.Size = New System.Drawing.Size(64, 22)
        Me.cmbTrnSysQK.TabIndex = 268
        Me.ToolTip1.SetToolTip(Me.cmbTrnSysQK, "Sets the same quickkey for sites in the system")
        '
        'cmbTrunkSysDelay
        '
        Me.cmbTrunkSysDelay.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrunkSysDelay.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrunkSysDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrunkSysDelay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrunkSysDelay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrunkSysDelay.Location = New System.Drawing.Point(175, 37)
        Me.cmbTrunkSysDelay.Name = "cmbTrunkSysDelay"
        Me.cmbTrunkSysDelay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrunkSysDelay.Size = New System.Drawing.Size(57, 22)
        Me.cmbTrunkSysDelay.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.cmbTrunkSysDelay, "Delay Time")
        '
        'cmbConvState
        '
        Me.cmbConvState.BackColor = System.Drawing.SystemColors.Window
        Me.cmbConvState.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbConvState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConvState.DropDownWidth = 125
        Me.cmbConvState.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConvState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConvState.Location = New System.Drawing.Point(407, 92)
        Me.cmbConvState.Name = "cmbConvState"
        Me.cmbConvState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbConvState.Size = New System.Drawing.Size(120, 22)
        Me.cmbConvState.TabIndex = 386
        Me.ToolTip1.SetToolTip(Me.cmbConvState, "State selection for BCT15(X) only")
        '
        'cmbConvStartupKey
        '
        Me.cmbConvStartupKey.BackColor = System.Drawing.SystemColors.Window
        Me.cmbConvStartupKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbConvStartupKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConvStartupKey.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConvStartupKey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConvStartupKey.Location = New System.Drawing.Point(320, 40)
        Me.cmbConvStartupKey.Name = "cmbConvStartupKey"
        Me.cmbConvStartupKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbConvStartupKey.Size = New System.Drawing.Size(65, 22)
        Me.cmbConvStartupKey.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cmbConvStartupKey, "Startup key")
        '
        'cmbQuickKey
        '
        Me.cmbQuickKey.BackColor = System.Drawing.SystemColors.Window
        Me.cmbQuickKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbQuickKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuickKey.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbQuickKey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbQuickKey.Location = New System.Drawing.Point(168, 40)
        Me.cmbQuickKey.Name = "cmbQuickKey"
        Me.cmbQuickKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbQuickKey.Size = New System.Drawing.Size(65, 22)
        Me.cmbQuickKey.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cmbQuickKey, "Conventional system quick key")
        '
        '_cmdJustTGID_2
        '
        Me._cmdJustTGID_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTGID_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTGID_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTGID_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTGID_2.Image = CType(resources.GetObject("_cmdJustTGID_2.Image"), System.Drawing.Image)
        Me.cmdJustTGID.SetIndex(Me._cmdJustTGID_2, CType(2, Short))
        Me._cmdJustTGID_2.Location = New System.Drawing.Point(161, 22)
        Me._cmdJustTGID_2.Name = "_cmdJustTGID_2"
        Me._cmdJustTGID_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTGID_2.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustTGID_2.TabIndex = 37
        Me._cmdJustTGID_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustTGID_2, "Justify Right")
        Me._cmdJustTGID_2.UseVisualStyleBackColor = True
        '
        '_cmdJustTGID_1
        '
        Me._cmdJustTGID_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTGID_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTGID_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTGID_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTGID_1.Image = CType(resources.GetObject("_cmdJustTGID_1.Image"), System.Drawing.Image)
        Me.cmdJustTGID.SetIndex(Me._cmdJustTGID_1, CType(1, Short))
        Me._cmdJustTGID_1.Location = New System.Drawing.Point(141, 22)
        Me._cmdJustTGID_1.Name = "_cmdJustTGID_1"
        Me._cmdJustTGID_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTGID_1.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustTGID_1.TabIndex = 36
        Me._cmdJustTGID_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustTGID_1, "Justify Center")
        Me._cmdJustTGID_1.UseVisualStyleBackColor = True
        '
        '_cmdJustTGID_0
        '
        Me._cmdJustTGID_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTGID_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTGID_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTGID_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTGID_0.Image = CType(resources.GetObject("_cmdJustTGID_0.Image"), System.Drawing.Image)
        Me.cmdJustTGID.SetIndex(Me._cmdJustTGID_0, CType(0, Short))
        Me._cmdJustTGID_0.Location = New System.Drawing.Point(121, 22)
        Me._cmdJustTGID_0.Name = "_cmdJustTGID_0"
        Me._cmdJustTGID_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTGID_0.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustTGID_0.TabIndex = 35
        Me._cmdJustTGID_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustTGID_0, "Justify Left")
        Me._cmdJustTGID_0.UseVisualStyleBackColor = True
        '
        '_cmdJustTGIDChan_2
        '
        Me._cmdJustTGIDChan_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTGIDChan_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTGIDChan_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTGIDChan_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTGIDChan_2.Image = CType(resources.GetObject("_cmdJustTGIDChan_2.Image"), System.Drawing.Image)
        Me.cmdJustTGIDChan.SetIndex(Me._cmdJustTGIDChan_2, CType(2, Short))
        Me._cmdJustTGIDChan_2.Location = New System.Drawing.Point(93, 95)
        Me._cmdJustTGIDChan_2.Name = "_cmdJustTGIDChan_2"
        Me._cmdJustTGIDChan_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTGIDChan_2.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustTGIDChan_2.TabIndex = 44
        Me._cmdJustTGIDChan_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustTGIDChan_2, "Justify Right")
        Me._cmdJustTGIDChan_2.UseVisualStyleBackColor = True
        '
        'cmbTGIDGroupQuickkey
        '
        Me.cmbTGIDGroupQuickkey.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTGIDGroupQuickkey.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTGIDGroupQuickkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTGIDGroupQuickkey.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTGIDGroupQuickkey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTGIDGroupQuickkey.Location = New System.Drawing.Point(201, 38)
        Me.cmbTGIDGroupQuickkey.Name = "cmbTGIDGroupQuickkey"
        Me.cmbTGIDGroupQuickkey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTGIDGroupQuickkey.Size = New System.Drawing.Size(57, 22)
        Me.cmbTGIDGroupQuickkey.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.cmbTGIDGroupQuickkey, "System-wide quick key")
        '
        '_cmdJustTGIDChan_1
        '
        Me._cmdJustTGIDChan_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTGIDChan_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTGIDChan_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTGIDChan_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTGIDChan_1.Image = CType(resources.GetObject("_cmdJustTGIDChan_1.Image"), System.Drawing.Image)
        Me.cmdJustTGIDChan.SetIndex(Me._cmdJustTGIDChan_1, CType(1, Short))
        Me._cmdJustTGIDChan_1.Location = New System.Drawing.Point(73, 95)
        Me._cmdJustTGIDChan_1.Name = "_cmdJustTGIDChan_1"
        Me._cmdJustTGIDChan_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTGIDChan_1.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustTGIDChan_1.TabIndex = 43
        Me._cmdJustTGIDChan_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustTGIDChan_1, "Justify Center")
        Me._cmdJustTGIDChan_1.UseVisualStyleBackColor = True
        '
        '_cmdJustTGIDChan_0
        '
        Me._cmdJustTGIDChan_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTGIDChan_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTGIDChan_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTGIDChan_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTGIDChan_0.Image = CType(resources.GetObject("_cmdJustTGIDChan_0.Image"), System.Drawing.Image)
        Me.cmdJustTGIDChan.SetIndex(Me._cmdJustTGIDChan_0, CType(0, Short))
        Me._cmdJustTGIDChan_0.Location = New System.Drawing.Point(53, 95)
        Me._cmdJustTGIDChan_0.Name = "_cmdJustTGIDChan_0"
        Me._cmdJustTGIDChan_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTGIDChan_0.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustTGIDChan_0.TabIndex = 42
        Me._cmdJustTGIDChan_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustTGIDChan_0, "Justify Left")
        Me._cmdJustTGIDChan_0.UseVisualStyleBackColor = True
        '
        'chkSimpleView
        '
        Me.chkSimpleView.BackColor = System.Drawing.SystemColors.Control
        Me.chkSimpleView.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSimpleView.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSimpleView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSimpleView.Location = New System.Drawing.Point(13, 84)
        Me.chkSimpleView.Name = "chkSimpleView"
        Me.chkSimpleView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSimpleView.Size = New System.Drawing.Size(89, 19)
        Me.chkSimpleView.TabIndex = 268
        Me.chkSimpleView.Text = "Simple View"
        Me.ToolTip1.SetToolTip(Me.chkSimpleView, "Selecting this will reduce the number of columns shown in the channel grid")
        Me.chkSimpleView.UseVisualStyleBackColor = True
        '
        '_cmdJustCnvGrp_2
        '
        Me._cmdJustCnvGrp_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustCnvGrp_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustCnvGrp_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustCnvGrp_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustCnvGrp_2.Image = CType(resources.GetObject("_cmdJustCnvGrp_2.Image"), System.Drawing.Image)
        Me.cmdJustCnvGrp.SetIndex(Me._cmdJustCnvGrp_2, CType(2, Short))
        Me._cmdJustCnvGrp_2.Location = New System.Drawing.Point(163, 20)
        Me._cmdJustCnvGrp_2.Name = "_cmdJustCnvGrp_2"
        Me._cmdJustCnvGrp_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustCnvGrp_2.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustCnvGrp_2.TabIndex = 223
        Me._cmdJustCnvGrp_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustCnvGrp_2, "Justify Right")
        Me._cmdJustCnvGrp_2.UseVisualStyleBackColor = True
        '
        '_cmdJustCnvGrp_1
        '
        Me._cmdJustCnvGrp_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustCnvGrp_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustCnvGrp_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustCnvGrp_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustCnvGrp_1.Image = CType(resources.GetObject("_cmdJustCnvGrp_1.Image"), System.Drawing.Image)
        Me.cmdJustCnvGrp.SetIndex(Me._cmdJustCnvGrp_1, CType(1, Short))
        Me._cmdJustCnvGrp_1.Location = New System.Drawing.Point(143, 20)
        Me._cmdJustCnvGrp_1.Name = "_cmdJustCnvGrp_1"
        Me._cmdJustCnvGrp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustCnvGrp_1.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustCnvGrp_1.TabIndex = 221
        Me._cmdJustCnvGrp_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustCnvGrp_1, "Justify Center")
        Me._cmdJustCnvGrp_1.UseVisualStyleBackColor = True
        '
        '_cmdJustCnvGrp_0
        '
        Me._cmdJustCnvGrp_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustCnvGrp_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustCnvGrp_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustCnvGrp_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustCnvGrp_0.Image = CType(resources.GetObject("_cmdJustCnvGrp_0.Image"), System.Drawing.Image)
        Me.cmdJustCnvGrp.SetIndex(Me._cmdJustCnvGrp_0, CType(0, Short))
        Me._cmdJustCnvGrp_0.Location = New System.Drawing.Point(123, 20)
        Me._cmdJustCnvGrp_0.Name = "_cmdJustCnvGrp_0"
        Me._cmdJustCnvGrp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustCnvGrp_0.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustCnvGrp_0.TabIndex = 219
        Me._cmdJustCnvGrp_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJustCnvGrp_0, "Justify Left")
        Me._cmdJustCnvGrp_0.UseVisualStyleBackColor = True
        '
        'cmbConvGroupQuickKey
        '
        Me.cmbConvGroupQuickKey.BackColor = System.Drawing.SystemColors.Window
        Me.cmbConvGroupQuickKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbConvGroupQuickKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConvGroupQuickKey.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConvGroupQuickKey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConvGroupQuickKey.Location = New System.Drawing.Point(203, 35)
        Me.cmbConvGroupQuickKey.Name = "cmbConvGroupQuickKey"
        Me.cmbConvGroupQuickKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbConvGroupQuickKey.Size = New System.Drawing.Size(57, 22)
        Me.cmbConvGroupQuickKey.TabIndex = 227
        Me.ToolTip1.SetToolTip(Me.cmbConvGroupQuickKey, "Group quick key")
        '
        '_cmdJust_0
        '
        Me._cmdJust_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJust_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJust_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJust_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJust_0.Image = CType(resources.GetObject("_cmdJust_0.Image"), System.Drawing.Image)
        Me.cmdJust.SetIndex(Me._cmdJust_0, CType(0, Short))
        Me._cmdJust_0.Location = New System.Drawing.Point(52, 105)
        Me._cmdJust_0.Name = "_cmdJust_0"
        Me._cmdJust_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJust_0.Size = New System.Drawing.Size(17, 15)
        Me._cmdJust_0.TabIndex = 232
        Me._cmdJust_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJust_0, "Justify Left")
        Me._cmdJust_0.UseVisualStyleBackColor = True
        '
        '_cmdJust_1
        '
        Me._cmdJust_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJust_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJust_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJust_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJust_1.Image = CType(resources.GetObject("_cmdJust_1.Image"), System.Drawing.Image)
        Me.cmdJust.SetIndex(Me._cmdJust_1, CType(1, Short))
        Me._cmdJust_1.Location = New System.Drawing.Point(72, 105)
        Me._cmdJust_1.Name = "_cmdJust_1"
        Me._cmdJust_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJust_1.Size = New System.Drawing.Size(17, 15)
        Me._cmdJust_1.TabIndex = 233
        Me._cmdJust_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJust_1, "Justify Center")
        Me._cmdJust_1.UseVisualStyleBackColor = True
        '
        '_cmdJust_2
        '
        Me._cmdJust_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJust_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJust_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJust_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJust_2.Image = CType(resources.GetObject("_cmdJust_2.Image"), System.Drawing.Image)
        Me.cmdJust.SetIndex(Me._cmdJust_2, CType(2, Short))
        Me._cmdJust_2.Location = New System.Drawing.Point(92, 105)
        Me._cmdJust_2.Name = "_cmdJust_2"
        Me._cmdJust_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJust_2.Size = New System.Drawing.Size(17, 15)
        Me._cmdJust_2.TabIndex = 234
        Me._cmdJust_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me._cmdJust_2, "Justify Right")
        Me._cmdJust_2.UseVisualStyleBackColor = True
        '
        'tabTrunkSite
        '
        Me.tabTrunkSite.AllowDrop = True
        Me.tabTrunkSite.Controls.Add(Me._tabTrunkSite_TabPage0)
        Me.tabTrunkSite.Controls.Add(Me._tabTrunkSite_TabPage1)
        Me.tabTrunkSite.Controls.Add(Me._tabTrunkSite_TabPage2)
        Me.tabTrunkSite.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTrunkSite.HotTrack = True
        Me.tabTrunkSite.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.tabTrunkSite.ItemSize = New System.Drawing.Size(42, 18)
        Me.tabTrunkSite.Location = New System.Drawing.Point(16, 145)
        Me.tabTrunkSite.Name = "tabTrunkSite"
        Me.tabTrunkSite.SelectedIndex = 0
        Me.tabTrunkSite.Size = New System.Drawing.Size(120, 55)
        Me.tabTrunkSite.TabIndex = 121
        Me.tabTrunkSite.Visible = False
        '
        '_tabTrunkSite_TabPage0
        '
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.cmbSiteState)
        Me._tabTrunkSite_TabPage0.Controls.Add(Label1)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.lblSiteNote1)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.cmbTrnP25Wait)
        Me._tabTrunkSite_TabPage0.Controls.Add(Label5)
        Me._tabTrunkSite_TabPage0.Controls.Add(_Label28_18)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.Frame9)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.Frame12)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.txtTrunkSiteName)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.cmbSiteQK)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.chkTrnSiteLO)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.cmbTrnModMode)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.chkTrnSiteAtt)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.chkControlChanOnly)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.cmbTrnSiteType)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.cmbTrnSiteHoldTime)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me.cmbTrnSiteStartupKey)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me._cmdJustTrnSite_2)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me._cmdJustTrnSite_1)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me._cmdJustTrnSite_0)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me._cmdFreeGQK_4)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me._cmbAPCO_2)
        Me._tabTrunkSite_TabPage0.Controls.Add(Me._cmbAPCO_3)
        Me._tabTrunkSite_TabPage0.Controls.Add(_Label28_17)
        Me._tabTrunkSite_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._tabTrunkSite_TabPage0.Name = "_tabTrunkSite_TabPage0"
        Me._tabTrunkSite_TabPage0.Size = New System.Drawing.Size(112, 29)
        Me._tabTrunkSite_TabPage0.TabIndex = 0
        Me._tabTrunkSite_TabPage0.Text = "Site Setup"
        '
        'cmbSiteState
        '
        Me.cmbSiteState.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSiteState.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSiteState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSiteState.DropDownWidth = 125
        Me.cmbSiteState.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSiteState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSiteState.Location = New System.Drawing.Point(547, 29)
        Me.cmbSiteState.Name = "cmbSiteState"
        Me.cmbSiteState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSiteState.Size = New System.Drawing.Size(87, 22)
        Me.cmbSiteState.TabIndex = 276
        '
        'cmbTrnP25Wait
        '
        Me.cmbTrnP25Wait.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnP25Wait.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnP25Wait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnP25Wait.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnP25Wait.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnP25Wait.Location = New System.Drawing.Point(467, 69)
        Me.cmbTrnP25Wait.Name = "cmbTrnP25Wait"
        Me.cmbTrnP25Wait.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnP25Wait.Size = New System.Drawing.Size(73, 22)
        Me.cmbTrnP25Wait.TabIndex = 273
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.SystemColors.Control
        Me.Frame9.Controls.Add(Me.grdReband)
        Me.Frame9.Controls.Add(Me.cmdAutoCalcBP)
        Me.Frame9.Controls.Add(_Label28_6)
        Me.Frame9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(13, 281)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame9.Size = New System.Drawing.Size(549, 199)
        Me.Frame9.TabIndex = 130
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "System Band Plan"
        '
        'grdReband
        '
        Me.grdReband.AllowUserToAddRows = False
        Me.grdReband.AllowUserToDeleteRows = False
        Me.grdReband.AllowUserToResizeColumns = False
        Me.grdReband.AllowUserToResizeRows = False
        Me.grdReband.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdReband.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdReband.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdReband_LowFreq, Me.grdReband_UpperFreq, Me.grdReband_Step, Me.grdReband_Offset})
        Me.grdReband.Location = New System.Drawing.Point(19, 24)
        Me.grdReband.Name = "grdReband"
        Me.grdReband.RowHeadersVisible = False
        Me.grdReband.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.grdReband.Size = New System.Drawing.Size(345, 160)
        Me.grdReband.TabIndex = 277
        '
        'grdReband_LowFreq
        '
        Me.grdReband_LowFreq.HeaderText = "Lower Freq"
        Me.grdReband_LowFreq.MaxInputLength = 9
        Me.grdReband_LowFreq.Name = "grdReband_LowFreq"
        Me.grdReband_LowFreq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdReband_LowFreq.Width = 90
        '
        'grdReband_UpperFreq
        '
        Me.grdReband_UpperFreq.HeaderText = "Upper Freq"
        Me.grdReband_UpperFreq.MaxInputLength = 9
        Me.grdReband_UpperFreq.Name = "grdReband_UpperFreq"
        Me.grdReband_UpperFreq.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdReband_UpperFreq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdReband_UpperFreq.Width = 90
        '
        'grdReband_Step
        '
        Me.grdReband_Step.FillWeight = 40.0!
        Me.grdReband_Step.HeaderText = "Step"
        Me.grdReband_Step.Name = "grdReband_Step"
        Me.grdReband_Step.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdReband_Step.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdReband_Step.Width = 60
        '
        'grdReband_Offset
        '
        Me.grdReband_Offset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.grdReband_Offset.HeaderText = "Offset"
        Me.grdReband_Offset.Name = "grdReband_Offset"
        Me.grdReband_Offset.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Frame12
        '
        Me.Frame12.BackColor = System.Drawing.SystemColors.Control
        Me.Frame12.Controls.Add(Me.chkTrnGPSEnable)
        Me.Frame12.Controls.Add(Me.cmdTrnSiteEditGPS)
        Me.Frame12.Controls.Add(_Label28_5)
        Me.Frame12.Controls.Add(_Label28_4)
        Me.Frame12.Controls.Add(_Label28_3)
        Me.Frame12.Controls.Add(Me.lblTrnRange)
        Me.Frame12.Controls.Add(Me.lblTrnLong)
        Me.Frame12.Controls.Add(Me.lblTrnLat)
        Me.Frame12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame12.Location = New System.Drawing.Point(12, 159)
        Me.Frame12.Name = "Frame12"
        Me.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame12.Size = New System.Drawing.Size(551, 121)
        Me.Frame12.TabIndex = 133
        Me.Frame12.TabStop = False
        Me.Frame12.Text = "GPS"
        '
        'chkTrnGPSEnable
        '
        Me.chkTrnGPSEnable.BackColor = System.Drawing.SystemColors.Control
        Me.chkTrnGPSEnable.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTrnGPSEnable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTrnGPSEnable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTrnGPSEnable.Location = New System.Drawing.Point(12, 16)
        Me.chkTrnGPSEnable.Name = "chkTrnGPSEnable"
        Me.chkTrnGPSEnable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTrnGPSEnable.Size = New System.Drawing.Size(137, 17)
        Me.chkTrnGPSEnable.TabIndex = 135
        Me.chkTrnGPSEnable.Text = "&Use GPS with this site"
        Me.chkTrnGPSEnable.UseVisualStyleBackColor = True
        '
        'cmdTrnSiteEditGPS
        '
        Me.cmdTrnSiteEditGPS.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTrnSiteEditGPS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTrnSiteEditGPS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTrnSiteEditGPS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTrnSiteEditGPS.Location = New System.Drawing.Point(380, 84)
        Me.cmdTrnSiteEditGPS.Name = "cmdTrnSiteEditGPS"
        Me.cmdTrnSiteEditGPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTrnSiteEditGPS.Size = New System.Drawing.Size(105, 25)
        Me.cmdTrnSiteEditGPS.TabIndex = 134
        Me.cmdTrnSiteEditGPS.Text = "&Edit Loc && Range"
        Me.cmdTrnSiteEditGPS.UseVisualStyleBackColor = True
        '
        'lblTrnRange
        '
        Me.lblTrnRange.AutoSize = True
        Me.lblTrnRange.BackColor = System.Drawing.SystemColors.Control
        Me.lblTrnRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTrnRange.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrnRange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTrnRange.Location = New System.Drawing.Point(118, 73)
        Me.lblTrnRange.Name = "lblTrnRange"
        Me.lblTrnRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTrnRange.Size = New System.Drawing.Size(64, 14)
        Me.lblTrnRange.TabIndex = 138
        Me.lblTrnRange.Text = "lblTrnRange"
        '
        'lblTrnLong
        '
        Me.lblTrnLong.AutoSize = True
        Me.lblTrnLong.BackColor = System.Drawing.SystemColors.Control
        Me.lblTrnLong.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTrnLong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrnLong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTrnLong.Location = New System.Drawing.Point(118, 57)
        Me.lblTrnLong.Name = "lblTrnLong"
        Me.lblTrnLong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTrnLong.Size = New System.Drawing.Size(57, 14)
        Me.lblTrnLong.TabIndex = 137
        Me.lblTrnLong.Text = "lblTrnLong"
        '
        'lblTrnLat
        '
        Me.lblTrnLat.AutoSize = True
        Me.lblTrnLat.BackColor = System.Drawing.SystemColors.Control
        Me.lblTrnLat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTrnLat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrnLat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTrnLat.Location = New System.Drawing.Point(118, 41)
        Me.lblTrnLat.Name = "lblTrnLat"
        Me.lblTrnLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTrnLat.Size = New System.Drawing.Size(48, 14)
        Me.lblTrnLat.TabIndex = 136
        Me.lblTrnLat.Text = "lblTrnLat"
        '
        'txtTrunkSiteName
        '
        Me.txtTrunkSiteName.AcceptsReturn = True
        Me.txtTrunkSiteName.BackColor = System.Drawing.SystemColors.Window
        Me.txtTrunkSiteName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTrunkSiteName.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrunkSiteName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTrunkSiteName.Location = New System.Drawing.Point(12, 31)
        Me.txtTrunkSiteName.MaxLength = 16
        Me.txtTrunkSiteName.Name = "txtTrunkSiteName"
        Me.txtTrunkSiteName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTrunkSiteName.Size = New System.Drawing.Size(145, 18)
        Me.txtTrunkSiteName.TabIndex = 142
        Me.txtTrunkSiteName.Text = "txtTrunkSiteName"
        '
        'cmbSiteQK
        '
        Me.cmbSiteQK.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSiteQK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSiteQK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSiteQK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSiteQK.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSiteQK.Location = New System.Drawing.Point(165, 29)
        Me.cmbSiteQK.Name = "cmbSiteQK"
        Me.cmbSiteQK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSiteQK.Size = New System.Drawing.Size(65, 22)
        Me.cmbSiteQK.TabIndex = 143
        '
        'chkTrnSiteLO
        '
        Me.chkTrnSiteLO.BackColor = System.Drawing.SystemColors.Control
        Me.chkTrnSiteLO.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTrnSiteLO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTrnSiteLO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkTrnSiteLO.Location = New System.Drawing.Point(12, 103)
        Me.chkTrnSiteLO.Name = "chkTrnSiteLO"
        Me.chkTrnSiteLO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTrnSiteLO.Size = New System.Drawing.Size(105, 17)
        Me.chkTrnSiteLO.TabIndex = 144
        Me.chkTrnSiteLO.Text = "Locked Out"
        Me.chkTrnSiteLO.UseVisualStyleBackColor = True
        '
        'cmbTrnModMode
        '
        Me.cmbTrnModMode.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnModMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnModMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnModMode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnModMode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnModMode.Location = New System.Drawing.Point(381, 69)
        Me.cmbTrnModMode.Name = "cmbTrnModMode"
        Me.cmbTrnModMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnModMode.Size = New System.Drawing.Size(73, 22)
        Me.cmbTrnModMode.TabIndex = 145
        '
        'chkTrnSiteAtt
        '
        Me.chkTrnSiteAtt.BackColor = System.Drawing.SystemColors.Control
        Me.chkTrnSiteAtt.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTrnSiteAtt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTrnSiteAtt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTrnSiteAtt.Location = New System.Drawing.Point(12, 119)
        Me.chkTrnSiteAtt.Name = "chkTrnSiteAtt"
        Me.chkTrnSiteAtt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTrnSiteAtt.Size = New System.Drawing.Size(113, 17)
        Me.chkTrnSiteAtt.TabIndex = 146
        Me.chkTrnSiteAtt.Text = "&20dB Attenuation"
        Me.chkTrnSiteAtt.UseVisualStyleBackColor = True
        '
        'chkControlChanOnly
        '
        Me.chkControlChanOnly.BackColor = System.Drawing.SystemColors.Control
        Me.chkControlChanOnly.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkControlChanOnly.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkControlChanOnly.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkControlChanOnly.Location = New System.Drawing.Point(12, 135)
        Me.chkControlChanOnly.Name = "chkControlChanOnly"
        Me.chkControlChanOnly.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkControlChanOnly.Size = New System.Drawing.Size(129, 17)
        Me.chkControlChanOnly.TabIndex = 147
        Me.chkControlChanOnly.Text = "C&ontrol Channel Only"
        Me.chkControlChanOnly.UseVisualStyleBackColor = True
        '
        'cmbTrnSiteType
        '
        Me.cmbTrnSiteType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnSiteType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnSiteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnSiteType.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnSiteType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnSiteType.Location = New System.Drawing.Point(13, 69)
        Me.cmbTrnSiteType.Name = "cmbTrnSiteType"
        Me.cmbTrnSiteType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnSiteType.Size = New System.Drawing.Size(225, 22)
        Me.cmbTrnSiteType.TabIndex = 148
        '
        'cmbTrnSiteStartupKey
        '
        Me.cmbTrnSiteStartupKey.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnSiteStartupKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnSiteStartupKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnSiteStartupKey.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnSiteStartupKey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnSiteStartupKey.Location = New System.Drawing.Point(300, 29)
        Me.cmbTrnSiteStartupKey.Name = "cmbTrnSiteStartupKey"
        Me.cmbTrnSiteStartupKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnSiteStartupKey.Size = New System.Drawing.Size(65, 22)
        Me.cmbTrnSiteStartupKey.TabIndex = 150
        '
        '_cmdFreeGQK_4
        '
        Me._cmdFreeGQK_4.BackColor = System.Drawing.SystemColors.Control
        Me._cmdFreeGQK_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdFreeGQK_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdFreeGQK_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFreeGQK.SetIndex(Me._cmdFreeGQK_4, CType(4, Short))
        Me._cmdFreeGQK_4.Location = New System.Drawing.Point(233, 28)
        Me._cmdFreeGQK_4.Name = "_cmdFreeGQK_4"
        Me._cmdFreeGQK_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdFreeGQK_4.Size = New System.Drawing.Size(64, 23)
        Me._cmdFreeGQK_4.TabIndex = 154
        Me._cmdFreeGQK_4.Text = "Fi&nd Free"
        Me._cmdFreeGQK_4.UseVisualStyleBackColor = True
        '
        '_cmbAPCO_2
        '
        Me._cmbAPCO_2.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAPCO_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAPCO_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAPCO_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAPCO_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAPCO.SetIndex(Me._cmbAPCO_2, CType(2, Short))
        Me._cmbAPCO_2.Location = New System.Drawing.Point(380, 29)
        Me._cmbAPCO_2.Name = "_cmbAPCO_2"
        Me._cmbAPCO_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAPCO_2.Size = New System.Drawing.Size(73, 22)
        Me._cmbAPCO_2.TabIndex = 270
        '
        '_cmbAPCO_3
        '
        Me._cmbAPCO_3.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAPCO_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAPCO_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAPCO_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAPCO_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAPCO.SetIndex(Me._cmbAPCO_3, CType(3, Short))
        Me._cmbAPCO_3.Location = New System.Drawing.Point(466, 29)
        Me._cmbAPCO_3.Name = "_cmbAPCO_3"
        Me._cmbAPCO_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAPCO_3.Size = New System.Drawing.Size(73, 22)
        Me._cmbAPCO_3.TabIndex = 271
        '
        '_tabTrunkSite_TabPage1
        '
        Me._tabTrunkSite_TabPage1.Controls.Add(Me.grdTrunkFreq)
        Me._tabTrunkSite_TabPage1.Controls.Add(Me.cmdEZGrabTrunk)
        Me._tabTrunkSite_TabPage1.Controls.Add(Me.cmdDeleteTrunkFreq)
        Me._tabTrunkSite_TabPage1.Controls.Add(Me.cmdNewTrunkFreq)
        Me._tabTrunkSite_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._tabTrunkSite_TabPage1.Name = "_tabTrunkSite_TabPage1"
        Me._tabTrunkSite_TabPage1.Size = New System.Drawing.Size(112, 29)
        Me._tabTrunkSite_TabPage1.TabIndex = 1
        Me._tabTrunkSite_TabPage1.Text = "Trunk Frequencies"
        '
        'grdTrunkFreq
        '
        Me.grdTrunkFreq.AccessibleDescription = "This grid contains every TGID channel programmied into this group"
        Me.grdTrunkFreq.AccessibleName = "TGID Channels"
        Me.grdTrunkFreq.AllowUserToAddRows = False
        Me.grdTrunkFreq.AllowUserToResizeRows = False
        Me.grdTrunkFreq.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdTrunkFreq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTrunkFreq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdTrunkFreq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTrunkFreq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdTrunkFreq_Freq, Me.grdTrunkFreq_LCN, Me.grdTrunkFreq_LO, Me.grdTrunkFreq_VolOffset, Me.grdTrunkFreq_NumTag})
        Me.grdTrunkFreq.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.grdTrunkFreq.Location = New System.Drawing.Point(47, 36)
        Me.grdTrunkFreq.Name = "grdTrunkFreq"
        Me.grdTrunkFreq.RowHeadersVisible = False
        Me.grdTrunkFreq.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdTrunkFreq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTrunkFreq.ShowCellToolTips = False
        Me.grdTrunkFreq.Size = New System.Drawing.Size(378, 301)
        Me.grdTrunkFreq.TabIndex = 267
        '
        'grdTrunkFreq_Freq
        '
        Me.grdTrunkFreq_Freq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.grdTrunkFreq_Freq.HeaderText = "Frequency"
        Me.grdTrunkFreq_Freq.MaxInputLength = 15
        Me.grdTrunkFreq_Freq.Name = "grdTrunkFreq_Freq"
        '
        'grdTrunkFreq_LCN
        '
        DataGridViewCellStyle2.Format = "##"
        DataGridViewCellStyle2.NullValue = "0"
        Me.grdTrunkFreq_LCN.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdTrunkFreq_LCN.HeaderText = "LCN"
        Me.grdTrunkFreq_LCN.MaxInputLength = 2
        Me.grdTrunkFreq_LCN.Name = "grdTrunkFreq_LCN"
        Me.grdTrunkFreq_LCN.Width = 50
        '
        'grdTrunkFreq_LO
        '
        Me.grdTrunkFreq_LO.HeaderText = "L/O"
        Me.grdTrunkFreq_LO.Name = "grdTrunkFreq_LO"
        Me.grdTrunkFreq_LO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdTrunkFreq_LO.Width = 40
        '
        'grdTrunkFreq_VolOffset
        '
        Me.grdTrunkFreq_VolOffset.HeaderText = "Vol Adj"
        Me.grdTrunkFreq_VolOffset.Name = "grdTrunkFreq_VolOffset"
        Me.grdTrunkFreq_VolOffset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdTrunkFreq_VolOffset.Width = 60
        '
        'grdTrunkFreq_NumTag
        '
        Me.grdTrunkFreq_NumTag.HeaderText = "Num Tag"
        Me.grdTrunkFreq_NumTag.MaxInputLength = 4
        Me.grdTrunkFreq_NumTag.Name = "grdTrunkFreq_NumTag"
        Me.grdTrunkFreq_NumTag.Width = 65
        '
        'cmdEZGrabTrunk
        '
        Me.cmdEZGrabTrunk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEZGrabTrunk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEZGrabTrunk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEZGrabTrunk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEZGrabTrunk.Location = New System.Drawing.Point(47, 5)
        Me.cmdEZGrabTrunk.Name = "cmdEZGrabTrunk"
        Me.cmdEZGrabTrunk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEZGrabTrunk.Size = New System.Drawing.Size(86, 26)
        Me.cmdEZGrabTrunk.TabIndex = 129
        Me.cmdEZGrabTrunk.Text = "EZ-Grab!"
        Me.cmdEZGrabTrunk.UseVisualStyleBackColor = True
        '
        'cmdDeleteTrunkFreq
        '
        Me.cmdDeleteTrunkFreq.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteTrunkFreq.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteTrunkFreq.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteTrunkFreq.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteTrunkFreq.Image = CType(resources.GetObject("cmdDeleteTrunkFreq.Image"), System.Drawing.Image)
        Me.cmdDeleteTrunkFreq.Location = New System.Drawing.Point(6, 82)
        Me.cmdDeleteTrunkFreq.Name = "cmdDeleteTrunkFreq"
        Me.cmdDeleteTrunkFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteTrunkFreq.Size = New System.Drawing.Size(29, 29)
        Me.cmdDeleteTrunkFreq.TabIndex = 123
        Me.cmdDeleteTrunkFreq.UseVisualStyleBackColor = True
        '
        'cmdNewTrunkFreq
        '
        Me.cmdNewTrunkFreq.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewTrunkFreq.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewTrunkFreq.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewTrunkFreq.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewTrunkFreq.Image = CType(resources.GetObject("cmdNewTrunkFreq.Image"), System.Drawing.Image)
        Me.cmdNewTrunkFreq.Location = New System.Drawing.Point(6, 51)
        Me.cmdNewTrunkFreq.Name = "cmdNewTrunkFreq"
        Me.cmdNewTrunkFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewTrunkFreq.Size = New System.Drawing.Size(29, 29)
        Me.cmdNewTrunkFreq.TabIndex = 122
        Me.cmdNewTrunkFreq.UseVisualStyleBackColor = True
        '
        '_tabTrunkSite_TabPage2
        '
        Me._tabTrunkSite_TabPage2.Controls.Add(Me.grdAPCO)
        Me._tabTrunkSite_TabPage2.Controls.Add(Me._Label59_16)
        Me._tabTrunkSite_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._tabTrunkSite_TabPage2.Name = "_tabTrunkSite_TabPage2"
        Me._tabTrunkSite_TabPage2.Size = New System.Drawing.Size(112, 29)
        Me._tabTrunkSite_TabPage2.TabIndex = 2
        Me._tabTrunkSite_TabPage2.Text = "APCO Band Plan"
        '
        'grdAPCO
        '
        Me.grdAPCO.AllowUserToAddRows = False
        Me.grdAPCO.AllowUserToDeleteRows = False
        Me.grdAPCO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAPCO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdAPCO_Num, Me.grdAPCOFreq, Me.grdAPCO_Step})
        Me.grdAPCO.Location = New System.Drawing.Point(13, 37)
        Me.grdAPCO.Name = "grdAPCO"
        Me.grdAPCO.RowHeadersVisible = False
        Me.grdAPCO.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.grdAPCO.Size = New System.Drawing.Size(234, 425)
        Me.grdAPCO.TabIndex = 192
        '
        'grdAPCO_Num
        '
        Me.grdAPCO_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.grdAPCO_Num.HeaderText = "Position"
        Me.grdAPCO_Num.Name = "grdAPCO_Num"
        Me.grdAPCO_Num.ReadOnly = True
        Me.grdAPCO_Num.Width = 69
        '
        'grdAPCOFreq
        '
        Me.grdAPCOFreq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.grdAPCOFreq.HeaderText = "Frequency (MHz)"
        Me.grdAPCOFreq.MaxInputLength = 9
        Me.grdAPCOFreq.Name = "grdAPCOFreq"
        Me.grdAPCOFreq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdAPCOFreq.Width = 87
        '
        'grdAPCO_Step
        '
        Me.grdAPCO_Step.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.grdAPCO_Step.HeaderText = "Spacing (Khz)"
        Me.grdAPCO_Step.MaxInputLength = 9
        Me.grdAPCO_Step.Name = "grdAPCO_Step"
        Me.grdAPCO_Step.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdAPCO_Step.Width = 74
        '
        '_Label59_16
        '
        Me._Label59_16.AutoSize = True
        Me._Label59_16.BackColor = System.Drawing.SystemColors.Control
        Me._Label59_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label59_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label59_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.SetIndex(Me._Label59_16, CType(16, Short))
        Me._Label59_16.Location = New System.Drawing.Point(7, 16)
        Me._Label59_16.Name = "_Label59_16"
        Me._Label59_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label59_16.Size = New System.Drawing.Size(306, 14)
        Me._Label59_16.TabIndex = 191
        Me._Label59_16.Text = "Applicable to full P25 systems && digital capable scanners only."
        Me._Label59_16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmTrunkSys
        '
        Me.frmTrunkSys.BackColor = System.Drawing.SystemColors.Control
        Me.frmTrunkSys.Controls.Add(Me.cmbTrnSysQK)
        Me.frmTrunkSys.Controls.Add(Label13)
        Me.frmTrunkSys.Controls.Add(GroupBox1)
        Me.frmTrunkSys.Controls.Add(Me.cmbTrnSysType)
        Me.frmTrunkSys.Controls.Add(Me._cmdJustTrnSys_0)
        Me.frmTrunkSys.Controls.Add(Me._cmdJustTrnSys_1)
        Me.frmTrunkSys.Controls.Add(Me._cmdJustTrnSys_2)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_10)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_9)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_8)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_7)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_6)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_5)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_4)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_3)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_2)
        Me.frmTrunkSys.Controls.Add(Me._chkQGLTrn_1)
        Me.frmTrunkSys.Controls.Add(Me.Frame14)
        Me.frmTrunkSys.Controls.Add(Me.Frame6)
        Me.frmTrunkSys.Controls.Add(Me.cmbTrunkSysDelay)
        Me.frmTrunkSys.Controls.Add(Me.txtTrunkSysName)
        Me.frmTrunkSys.Controls.Add(Me.cmdEditFleetMap)
        Me.frmTrunkSys.Controls.Add(Me.Frame8)
        Me.frmTrunkSys.Controls.Add(Me.Frame7)
        Me.frmTrunkSys.Controls.Add(Me.lblTGIDStat)
        Me.frmTrunkSys.Controls.Add(_Label28_38)
        Me.frmTrunkSys.Controls.Add(_Label28_36)
        Me.frmTrunkSys.Controls.Add(Me._Label28_21)
        Me.frmTrunkSys.Controls.Add(_Label28_19)
        Me.frmTrunkSys.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmTrunkSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmTrunkSys.Location = New System.Drawing.Point(31, 410)
        Me.frmTrunkSys.Name = "frmTrunkSys"
        Me.frmTrunkSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmTrunkSys.Size = New System.Drawing.Size(103, 81)
        Me.frmTrunkSys.TabIndex = 56
        Me.frmTrunkSys.TabStop = False
        Me.frmTrunkSys.Text = "Trunked System Setup"
        Me.frmTrunkSys.Visible = False
        '
        'cmbTrnSysType
        '
        Me.cmbTrnSysType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnSysType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnSysType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnSysType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnSysType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnSysType.Location = New System.Drawing.Point(24, 89)
        Me.cmbTrnSysType.Name = "cmbTrnSysType"
        Me.cmbTrnSysType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnSysType.Size = New System.Drawing.Size(232, 22)
        Me.cmbTrnSysType.TabIndex = 266
        '
        '_cmdJustTrnSys_0
        '
        Me._cmdJustTrnSys_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTrnSys_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTrnSys_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTrnSys_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTrnSys_0.Image = CType(resources.GetObject("_cmdJustTrnSys_0.Image"), System.Drawing.Image)
        Me.cmdJustTrnSys.SetIndex(Me._cmdJustTrnSys_0, CType(0, Short))
        Me._cmdJustTrnSys_0.Location = New System.Drawing.Point(112, 19)
        Me._cmdJustTrnSys_0.Name = "_cmdJustTrnSys_0"
        Me._cmdJustTrnSys_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTrnSys_0.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustTrnSys_0.TabIndex = 113
        Me._cmdJustTrnSys_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdJustTrnSys_0.UseVisualStyleBackColor = True
        '
        '_cmdJustTrnSys_1
        '
        Me._cmdJustTrnSys_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTrnSys_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTrnSys_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTrnSys_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTrnSys_1.Image = CType(resources.GetObject("_cmdJustTrnSys_1.Image"), System.Drawing.Image)
        Me.cmdJustTrnSys.SetIndex(Me._cmdJustTrnSys_1, CType(1, Short))
        Me._cmdJustTrnSys_1.Location = New System.Drawing.Point(132, 19)
        Me._cmdJustTrnSys_1.Name = "_cmdJustTrnSys_1"
        Me._cmdJustTrnSys_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTrnSys_1.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustTrnSys_1.TabIndex = 112
        Me._cmdJustTrnSys_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdJustTrnSys_1.UseVisualStyleBackColor = True
        '
        '_cmdJustTrnSys_2
        '
        Me._cmdJustTrnSys_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdJustTrnSys_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdJustTrnSys_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdJustTrnSys_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdJustTrnSys_2.Image = CType(resources.GetObject("_cmdJustTrnSys_2.Image"), System.Drawing.Image)
        Me.cmdJustTrnSys.SetIndex(Me._cmdJustTrnSys_2, CType(2, Short))
        Me._cmdJustTrnSys_2.Location = New System.Drawing.Point(152, 19)
        Me._cmdJustTrnSys_2.Name = "_cmdJustTrnSys_2"
        Me._cmdJustTrnSys_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdJustTrnSys_2.Size = New System.Drawing.Size(17, 15)
        Me._cmdJustTrnSys_2.TabIndex = 111
        Me._cmdJustTrnSys_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._cmdJustTrnSys_2.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_10
        '
        Me._chkQGLTrn_10.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_10, CType(10, Short))
        Me._chkQGLTrn_10.Location = New System.Drawing.Point(461, 67)
        Me._chkQGLTrn_10.Name = "_chkQGLTrn_10"
        Me._chkQGLTrn_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_10.Size = New System.Drawing.Size(36, 21)
        Me._chkQGLTrn_10.TabIndex = 109
        Me._chkQGLTrn_10.Text = "&0"
        Me._chkQGLTrn_10.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_9
        '
        Me._chkQGLTrn_9.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_9, CType(9, Short))
        Me._chkQGLTrn_9.Location = New System.Drawing.Point(427, 67)
        Me._chkQGLTrn_9.Name = "_chkQGLTrn_9"
        Me._chkQGLTrn_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_9.Size = New System.Drawing.Size(54, 21)
        Me._chkQGLTrn_9.TabIndex = 108
        Me._chkQGLTrn_9.Text = "&9"
        Me._chkQGLTrn_9.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_8
        '
        Me._chkQGLTrn_8.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_8, CType(8, Short))
        Me._chkQGLTrn_8.Location = New System.Drawing.Point(389, 67)
        Me._chkQGLTrn_8.Name = "_chkQGLTrn_8"
        Me._chkQGLTrn_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_8.Size = New System.Drawing.Size(54, 21)
        Me._chkQGLTrn_8.TabIndex = 107
        Me._chkQGLTrn_8.Text = "&8"
        Me._chkQGLTrn_8.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_7
        '
        Me._chkQGLTrn_7.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_7, CType(7, Short))
        Me._chkQGLTrn_7.Location = New System.Drawing.Point(351, 67)
        Me._chkQGLTrn_7.Name = "_chkQGLTrn_7"
        Me._chkQGLTrn_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_7.Size = New System.Drawing.Size(54, 21)
        Me._chkQGLTrn_7.TabIndex = 106
        Me._chkQGLTrn_7.Text = "&7"
        Me._chkQGLTrn_7.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_6
        '
        Me._chkQGLTrn_6.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_6, CType(6, Short))
        Me._chkQGLTrn_6.Location = New System.Drawing.Point(313, 67)
        Me._chkQGLTrn_6.Name = "_chkQGLTrn_6"
        Me._chkQGLTrn_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_6.Size = New System.Drawing.Size(54, 21)
        Me._chkQGLTrn_6.TabIndex = 105
        Me._chkQGLTrn_6.Text = "&6"
        Me._chkQGLTrn_6.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_5
        '
        Me._chkQGLTrn_5.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_5, CType(5, Short))
        Me._chkQGLTrn_5.Location = New System.Drawing.Point(460, 40)
        Me._chkQGLTrn_5.Name = "_chkQGLTrn_5"
        Me._chkQGLTrn_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_5.Size = New System.Drawing.Size(34, 21)
        Me._chkQGLTrn_5.TabIndex = 104
        Me._chkQGLTrn_5.Text = "&5"
        Me._chkQGLTrn_5.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_4
        '
        Me._chkQGLTrn_4.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_4, CType(4, Short))
        Me._chkQGLTrn_4.Location = New System.Drawing.Point(426, 40)
        Me._chkQGLTrn_4.Name = "_chkQGLTrn_4"
        Me._chkQGLTrn_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_4.Size = New System.Drawing.Size(59, 21)
        Me._chkQGLTrn_4.TabIndex = 103
        Me._chkQGLTrn_4.Text = "&4"
        Me._chkQGLTrn_4.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_3
        '
        Me._chkQGLTrn_3.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_3, CType(3, Short))
        Me._chkQGLTrn_3.Location = New System.Drawing.Point(388, 40)
        Me._chkQGLTrn_3.Name = "_chkQGLTrn_3"
        Me._chkQGLTrn_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_3.Size = New System.Drawing.Size(59, 21)
        Me._chkQGLTrn_3.TabIndex = 102
        Me._chkQGLTrn_3.Text = "&3"
        Me._chkQGLTrn_3.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_2
        '
        Me._chkQGLTrn_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_2, CType(2, Short))
        Me._chkQGLTrn_2.Location = New System.Drawing.Point(350, 40)
        Me._chkQGLTrn_2.Name = "_chkQGLTrn_2"
        Me._chkQGLTrn_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_2.Size = New System.Drawing.Size(59, 21)
        Me._chkQGLTrn_2.TabIndex = 101
        Me._chkQGLTrn_2.Text = "&2"
        Me._chkQGLTrn_2.UseVisualStyleBackColor = True
        '
        '_chkQGLTrn_1
        '
        Me._chkQGLTrn_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLTrn_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLTrn_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLTrn_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLTrn.SetIndex(Me._chkQGLTrn_1, CType(1, Short))
        Me._chkQGLTrn_1.Location = New System.Drawing.Point(312, 40)
        Me._chkQGLTrn_1.Name = "_chkQGLTrn_1"
        Me._chkQGLTrn_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLTrn_1.Size = New System.Drawing.Size(59, 21)
        Me._chkQGLTrn_1.TabIndex = 100
        Me._chkQGLTrn_1.Text = "&1"
        Me._chkQGLTrn_1.UseVisualStyleBackColor = True
        '
        'Frame14
        '
        Me.Frame14.BackColor = System.Drawing.SystemColors.Control
        Me.Frame14.Controls.Add(Me._optTrnRecord_2)
        Me.Frame14.Controls.Add(Me._optTrnRecord_1)
        Me.Frame14.Controls.Add(Me._optTrnRecord_0)
        Me.Frame14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame14.Location = New System.Drawing.Point(328, 224)
        Me.Frame14.Name = "Frame14"
        Me.Frame14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame14.Size = New System.Drawing.Size(153, 89)
        Me.Frame14.TabIndex = 69
        Me.Frame14.TabStop = False
        Me.Frame14.Text = "Tape Out"
        '
        '_optTrnRecord_2
        '
        Me._optTrnRecord_2.BackColor = System.Drawing.SystemColors.Control
        Me._optTrnRecord_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optTrnRecord_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optTrnRecord_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTrnRecord.SetIndex(Me._optTrnRecord_2, CType(2, Short))
        Me._optTrnRecord_2.Location = New System.Drawing.Point(8, 56)
        Me._optTrnRecord_2.Name = "_optTrnRecord_2"
        Me._optTrnRecord_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optTrnRecord_2.Size = New System.Drawing.Size(97, 17)
        Me._optTrnRecord_2.TabIndex = 83
        Me._optTrnRecord_2.TabStop = True
        Me._optTrnRecord_2.Text = "All Channels"
        Me._optTrnRecord_2.UseVisualStyleBackColor = True
        '
        '_optTrnRecord_1
        '
        Me._optTrnRecord_1.BackColor = System.Drawing.SystemColors.Control
        Me._optTrnRecord_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optTrnRecord_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optTrnRecord_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTrnRecord.SetIndex(Me._optTrnRecord_1, CType(1, Short))
        Me._optTrnRecord_1.Location = New System.Drawing.Point(8, 36)
        Me._optTrnRecord_1.Name = "_optTrnRecord_1"
        Me._optTrnRecord_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optTrnRecord_1.Size = New System.Drawing.Size(129, 17)
        Me._optTrnRecord_1.TabIndex = 82
        Me._optTrnRecord_1.TabStop = True
        Me._optTrnRecord_1.Text = "Marked Channels Only"
        Me._optTrnRecord_1.UseVisualStyleBackColor = True
        '
        '_optTrnRecord_0
        '
        Me._optTrnRecord_0.BackColor = System.Drawing.SystemColors.Control
        Me._optTrnRecord_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optTrnRecord_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optTrnRecord_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTrnRecord.SetIndex(Me._optTrnRecord_0, CType(0, Short))
        Me._optTrnRecord_0.Location = New System.Drawing.Point(8, 16)
        Me._optTrnRecord_0.Name = "_optTrnRecord_0"
        Me._optTrnRecord_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optTrnRecord_0.Size = New System.Drawing.Size(97, 17)
        Me._optTrnRecord_0.TabIndex = 81
        Me._optTrnRecord_0.TabStop = True
        Me._optTrnRecord_0.Text = "&Off"
        Me._optTrnRecord_0.UseVisualStyleBackColor = True
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.optIDSearch)
        Me.Frame6.Controls.Add(Me.optIDScan)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(172, 224)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(149, 89)
        Me.Frame6.TabIndex = 67
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "ID Mode"
        '
        'optIDSearch
        '
        Me.optIDSearch.BackColor = System.Drawing.SystemColors.Control
        Me.optIDSearch.Checked = True
        Me.optIDSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.optIDSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optIDSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optIDSearch.Location = New System.Drawing.Point(8, 16)
        Me.optIDSearch.Name = "optIDSearch"
        Me.optIDSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optIDSearch.Size = New System.Drawing.Size(73, 17)
        Me.optIDSearch.TabIndex = 31
        Me.optIDSearch.TabStop = True
        Me.optIDSearch.Text = "ID Sea&rch"
        Me.optIDSearch.UseVisualStyleBackColor = True
        '
        'optIDScan
        '
        Me.optIDScan.BackColor = System.Drawing.SystemColors.Control
        Me.optIDScan.Cursor = System.Windows.Forms.Cursors.Default
        Me.optIDScan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optIDScan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optIDScan.Location = New System.Drawing.Point(8, 40)
        Me.optIDScan.Name = "optIDScan"
        Me.optIDScan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optIDScan.Size = New System.Drawing.Size(81, 25)
        Me.optIDScan.TabIndex = 32
        Me.optIDScan.TabStop = True
        Me.optIDScan.Text = "ID S&can"
        Me.optIDScan.UseVisualStyleBackColor = True
        '
        'txtTrunkSysName
        '
        Me.txtTrunkSysName.AcceptsReturn = True
        Me.txtTrunkSysName.BackColor = System.Drawing.SystemColors.Window
        Me.txtTrunkSysName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTrunkSysName.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrunkSysName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTrunkSysName.Location = New System.Drawing.Point(24, 39)
        Me.txtTrunkSysName.MaxLength = 16
        Me.txtTrunkSysName.Name = "txtTrunkSysName"
        Me.txtTrunkSysName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTrunkSysName.Size = New System.Drawing.Size(145, 18)
        Me.txtTrunkSysName.TabIndex = 22
        Me.txtTrunkSysName.Text = "txtTrunkSysName"
        '
        'cmdEditFleetMap
        '
        Me.cmdEditFleetMap.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEditFleetMap.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEditFleetMap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditFleetMap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEditFleetMap.Location = New System.Drawing.Point(328, 329)
        Me.cmdEditFleetMap.Name = "cmdEditFleetMap"
        Me.cmdEditFleetMap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEditFleetMap.Size = New System.Drawing.Size(137, 25)
        Me.cmdEditFleetMap.TabIndex = 33
        Me.cmdEditFleetMap.Text = "Edit Fleet Ma&p..."
        Me.cmdEditFleetMap.UseVisualStyleBackColor = True
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me.optEDACSIDDec)
        Me.Frame8.Controls.Add(Me.optEDACSIDAFS)
        Me.Frame8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(24, 224)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(137, 89)
        Me.Frame8.TabIndex = 58
        Me.Frame8.TabStop = False
        Me.Frame8.Text = "EDACS ID Format"
        '
        'optEDACSIDDec
        '
        Me.optEDACSIDDec.BackColor = System.Drawing.SystemColors.Control
        Me.optEDACSIDDec.Cursor = System.Windows.Forms.Cursors.Default
        Me.optEDACSIDDec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optEDACSIDDec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optEDACSIDDec.Location = New System.Drawing.Point(8, 16)
        Me.optEDACSIDDec.Name = "optEDACSIDDec"
        Me.optEDACSIDDec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optEDACSIDDec.Size = New System.Drawing.Size(73, 17)
        Me.optEDACSIDDec.TabIndex = 29
        Me.optEDACSIDDec.TabStop = True
        Me.optEDACSIDDec.Text = "Decimal"
        Me.optEDACSIDDec.UseVisualStyleBackColor = True
        '
        'optEDACSIDAFS
        '
        Me.optEDACSIDAFS.BackColor = System.Drawing.SystemColors.Control
        Me.optEDACSIDAFS.Checked = True
        Me.optEDACSIDAFS.Cursor = System.Windows.Forms.Cursors.Default
        Me.optEDACSIDAFS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optEDACSIDAFS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optEDACSIDAFS.Location = New System.Drawing.Point(8, 48)
        Me.optEDACSIDAFS.Name = "optEDACSIDAFS"
        Me.optEDACSIDAFS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optEDACSIDAFS.Size = New System.Drawing.Size(81, 17)
        Me.optEDACSIDAFS.TabIndex = 30
        Me.optEDACSIDAFS.TabStop = True
        Me.optEDACSIDAFS.Text = "AFS"
        Me.optEDACSIDAFS.UseVisualStyleBackColor = True
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.SystemColors.Control
        Me.Frame7.Controls.Add(Me.chkMotDigEndCode)
        Me.Frame7.Controls.Add(Me.cmbTrnEmergAlertLevel)
        Me.Frame7.Controls.Add(Me.cmbTrnEmergAlertType)
        Me.Frame7.Controls.Add(Me.chkMotStatusBit)
        Me.Frame7.Controls.Add(Me.chkUseMotEndCode)
        Me.Frame7.Controls.Add(Me.chkICall)
        Me.Frame7.Controls.Add(Me._Label28_23)
        Me.Frame7.Controls.Add(Me._Label28_22)
        Me.Frame7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(24, 120)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(457, 97)
        Me.Frame7.TabIndex = 57
        Me.Frame7.TabStop = False
        Me.Frame7.Text = "General Options"
        '
        'cmbTrnEmergAlertLevel
        '
        Me.cmbTrnEmergAlertLevel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnEmergAlertLevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnEmergAlertLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnEmergAlertLevel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnEmergAlertLevel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnEmergAlertLevel.Location = New System.Drawing.Point(373, 51)
        Me.cmbTrnEmergAlertLevel.Name = "cmbTrnEmergAlertLevel"
        Me.cmbTrnEmergAlertLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnEmergAlertLevel.Size = New System.Drawing.Size(57, 22)
        Me.cmbTrnEmergAlertLevel.TabIndex = 28
        '
        'cmbTrnEmergAlertType
        '
        Me.cmbTrnEmergAlertType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTrnEmergAlertType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTrnEmergAlertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrnEmergAlertType.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrnEmergAlertType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTrnEmergAlertType.Location = New System.Drawing.Point(263, 51)
        Me.cmbTrnEmergAlertType.Name = "cmbTrnEmergAlertType"
        Me.cmbTrnEmergAlertType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTrnEmergAlertType.Size = New System.Drawing.Size(57, 22)
        Me.cmbTrnEmergAlertType.TabIndex = 27
        '
        'chkMotStatusBit
        '
        Me.chkMotStatusBit.BackColor = System.Drawing.SystemColors.Control
        Me.chkMotStatusBit.Checked = True
        Me.chkMotStatusBit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMotStatusBit.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMotStatusBit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMotStatusBit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMotStatusBit.Location = New System.Drawing.Point(10, 21)
        Me.chkMotStatusBit.Name = "chkMotStatusBit"
        Me.chkMotStatusBit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMotStatusBit.Size = New System.Drawing.Size(242, 19)
        Me.chkMotStatusBit.TabIndex = 24
        Me.chkMotStatusBit.Text = "Use Motorola Status Bit (recommended Off)"
        Me.chkMotStatusBit.UseVisualStyleBackColor = True
        '
        'chkUseMotEndCode
        '
        Me.chkUseMotEndCode.BackColor = System.Drawing.SystemColors.Control
        Me.chkUseMotEndCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUseMotEndCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseMotEndCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUseMotEndCode.Location = New System.Drawing.Point(10, 40)
        Me.chkUseMotEndCode.Name = "chkUseMotEndCode"
        Me.chkUseMotEndCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUseMotEndCode.Size = New System.Drawing.Size(161, 17)
        Me.chkUseMotEndCode.TabIndex = 25
        Me.chkUseMotEndCode.Text = "&Use Motorola End Code"
        Me.chkUseMotEndCode.UseVisualStyleBackColor = True
        '
        'chkICall
        '
        Me.chkICall.BackColor = System.Drawing.SystemColors.Control
        Me.chkICall.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkICall.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkICall.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkICall.Location = New System.Drawing.Point(10, 74)
        Me.chkICall.Name = "chkICall"
        Me.chkICall.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkICall.Size = New System.Drawing.Size(89, 17)
        Me.chkICall.TabIndex = 26
        Me.chkICall.Text = "E&nable I-Call"
        Me.chkICall.UseVisualStyleBackColor = True
        '
        '_Label28_23
        '
        Me._Label28_23.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_23, CType(23, Short))
        Me._Label28_23.Location = New System.Drawing.Point(373, 15)
        Me._Label28_23.Name = "_Label28_23"
        Me._Label28_23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_23.Size = New System.Drawing.Size(72, 29)
        Me._Label28_23.TabIndex = 95
        Me._Label28_23.Text = "Emergency Alert Level"
        '
        '_Label28_22
        '
        Me._Label28_22.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_22, CType(22, Short))
        Me._Label28_22.Location = New System.Drawing.Point(261, 19)
        Me._Label28_22.Name = "_Label28_22"
        Me._Label28_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_22.Size = New System.Drawing.Size(77, 29)
        Me._Label28_22.TabIndex = 94
        Me._Label28_22.Text = "Emergency Alert Type (0=Off)"
        '
        'lblTGIDStat
        '
        Me.lblTGIDStat.BackColor = System.Drawing.SystemColors.Control
        Me.lblTGIDStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTGIDStat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTGIDStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTGIDStat.Location = New System.Drawing.Point(332, 361)
        Me.lblTGIDStat.Name = "lblTGIDStat"
        Me.lblTGIDStat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTGIDStat.Size = New System.Drawing.Size(185, 41)
        Me.lblTGIDStat.TabIndex = 210
        Me.lblTGIDStat.Text = "This system contains 0 TGIDs"
        '
        '_Label28_21
        '
        Me._Label28_21.AutoSize = True
        Me._Label28_21.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_21, CType(21, Short))
        Me._Label28_21.Location = New System.Drawing.Point(24, 72)
        Me._Label28_21.Name = "_Label28_21"
        Me._Label28_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_21.Size = New System.Drawing.Size(30, 14)
        Me._Label28_21.TabIndex = 93
        Me._Label28_21.Text = "Type"
        '
        '_frmSiteOptConv_0
        '
        Me._frmSiteOptConv_0.BackColor = System.Drawing.SystemColors.Control
        Me._frmSiteOptConv_0.Controls.Add(Me.cmbConvState)
        Me._frmSiteOptConv_0.Controls.Add(Label14)
        Me._frmSiteOptConv_0.Controls.Add(Me.chkCnvSysProtect)
        Me._frmSiteOptConv_0.Controls.Add(GroupBox2)
        Me._frmSiteOptConv_0.Controls.Add(Me._cmbAPCO_1)
        Me._frmSiteOptConv_0.Controls.Add(Me._cmbAPCO_0)
        Me._frmSiteOptConv_0.Controls.Add(Me._cmdFreeGQK_2)
        Me._frmSiteOptConv_0.Controls.Add(Me.chkDataSkip)
        Me._frmSiteOptConv_0.Controls.Add(Me.chkSiteLockedOut)
        Me._frmSiteOptConv_0.Controls.Add(Me._cmdJustCnvSys_0)
        Me._frmSiteOptConv_0.Controls.Add(Me._cmdJustCnvSys_1)
        Me._frmSiteOptConv_0.Controls.Add(Me._cmdJustCnvSys_2)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_1)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_2)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_3)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_4)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_5)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_6)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_7)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_8)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_9)
        Me._frmSiteOptConv_0.Controls.Add(Me._chkQGLCnv_10)
        Me._frmSiteOptConv_0.Controls.Add(Me.Frame13)
        Me._frmSiteOptConv_0.Controls.Add(Me.cmbConvStartupKey)
        Me._frmSiteOptConv_0.Controls.Add(Me.cmbConvDelayTime)
        Me._frmSiteOptConv_0.Controls.Add(Me.cmbConvHoldTime)
        Me._frmSiteOptConv_0.Controls.Add(Me.Frame3)
        Me._frmSiteOptConv_0.Controls.Add(Me.cmbQuickKey)
        Me._frmSiteOptConv_0.Controls.Add(Me.txtSiteName)
        Me._frmSiteOptConv_0.Controls.Add(Me._Label28_25)
        Me._frmSiteOptConv_0.Controls.Add(Me._Label28_35)
        Me._frmSiteOptConv_0.Controls.Add(Me._Label28_34)
        Me._frmSiteOptConv_0.Controls.Add(Me._Label28_24)
        Me._frmSiteOptConv_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmSiteOptConv_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmSiteOptConv.SetIndex(Me._frmSiteOptConv_0, CType(0, Short))
        Me._frmSiteOptConv_0.Location = New System.Drawing.Point(16, 81)
        Me._frmSiteOptConv_0.Name = "_frmSiteOptConv_0"
        Me._frmSiteOptConv_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._frmSiteOptConv_0.Size = New System.Drawing.Size(65, 57)
        Me._frmSiteOptConv_0.TabIndex = 37
        Me._frmSiteOptConv_0.TabStop = False
        Me._frmSiteOptConv_0.Text = "Conventional System"
        Me._frmSiteOptConv_0.Visible = False
        '
        '_cmbAPCO_1
        '
        Me._cmbAPCO_1.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAPCO_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAPCO_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAPCO_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAPCO_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAPCO.SetIndex(Me._cmbAPCO_1, CType(1, Short))
        Me._cmbAPCO_1.Location = New System.Drawing.Point(483, 39)
        Me._cmbAPCO_1.Name = "_cmbAPCO_1"
        Me._cmbAPCO_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAPCO_1.Size = New System.Drawing.Size(67, 22)
        Me._cmbAPCO_1.TabIndex = 9
        '
        '_cmbAPCO_0
        '
        Me._cmbAPCO_0.BackColor = System.Drawing.SystemColors.Window
        Me._cmbAPCO_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbAPCO_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbAPCO_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbAPCO_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAPCO.SetIndex(Me._cmbAPCO_0, CType(0, Short))
        Me._cmbAPCO_0.Location = New System.Drawing.Point(407, 39)
        Me._cmbAPCO_0.Name = "_cmbAPCO_0"
        Me._cmbAPCO_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbAPCO_0.Size = New System.Drawing.Size(67, 22)
        Me._cmbAPCO_0.TabIndex = 8
        '
        '_cmdFreeGQK_2
        '
        Me._cmdFreeGQK_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdFreeGQK_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdFreeGQK_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdFreeGQK_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFreeGQK.SetIndex(Me._cmdFreeGQK_2, CType(2, Short))
        Me._cmdFreeGQK_2.Location = New System.Drawing.Point(236, 40)
        Me._cmdFreeGQK_2.Name = "_cmdFreeGQK_2"
        Me._cmdFreeGQK_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdFreeGQK_2.Size = New System.Drawing.Size(66, 21)
        Me._cmdFreeGQK_2.TabIndex = 6
        Me._cmdFreeGQK_2.Text = "Fi&nd Free"
        Me._cmdFreeGQK_2.UseVisualStyleBackColor = True
        '
        'chkDataSkip
        '
        Me.chkDataSkip.BackColor = System.Drawing.SystemColors.Control
        Me.chkDataSkip.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDataSkip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDataSkip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDataSkip.Location = New System.Drawing.Point(16, 92)
        Me.chkDataSkip.Name = "chkDataSkip"
        Me.chkDataSkip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDataSkip.Size = New System.Drawing.Size(89, 17)
        Me.chkDataSkip.TabIndex = 11
        Me.chkDataSkip.Text = "&Data Skip"
        Me.chkDataSkip.UseVisualStyleBackColor = True
        '
        'chkSiteLockedOut
        '
        Me.chkSiteLockedOut.BackColor = System.Drawing.SystemColors.Control
        Me.chkSiteLockedOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSiteLockedOut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSiteLockedOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSiteLockedOut.Location = New System.Drawing.Point(16, 72)
        Me.chkSiteLockedOut.Name = "chkSiteLockedOut"
        Me.chkSiteLockedOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSiteLockedOut.Size = New System.Drawing.Size(105, 17)
        Me.chkSiteLockedOut.TabIndex = 10
        Me.chkSiteLockedOut.Text = "&Locked Out"
        Me.chkSiteLockedOut.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_1
        '
        Me._chkQGLCnv_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_1, CType(1, Short))
        Me._chkQGLCnv_1.Location = New System.Drawing.Point(181, 308)
        Me._chkQGLCnv_1.Name = "_chkQGLCnv_1"
        Me._chkQGLCnv_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_1.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_1.TabIndex = 22
        Me._chkQGLCnv_1.Text = "&1"
        Me._chkQGLCnv_1.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_2
        '
        Me._chkQGLCnv_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_2, CType(2, Short))
        Me._chkQGLCnv_2.Location = New System.Drawing.Point(221, 308)
        Me._chkQGLCnv_2.Name = "_chkQGLCnv_2"
        Me._chkQGLCnv_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_2.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_2.TabIndex = 72
        Me._chkQGLCnv_2.Text = "&2"
        Me._chkQGLCnv_2.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_3
        '
        Me._chkQGLCnv_3.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_3, CType(3, Short))
        Me._chkQGLCnv_3.Location = New System.Drawing.Point(261, 308)
        Me._chkQGLCnv_3.Name = "_chkQGLCnv_3"
        Me._chkQGLCnv_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_3.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_3.TabIndex = 73
        Me._chkQGLCnv_3.Text = "&3"
        Me._chkQGLCnv_3.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_4
        '
        Me._chkQGLCnv_4.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_4, CType(4, Short))
        Me._chkQGLCnv_4.Location = New System.Drawing.Point(301, 308)
        Me._chkQGLCnv_4.Name = "_chkQGLCnv_4"
        Me._chkQGLCnv_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_4.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_4.TabIndex = 74
        Me._chkQGLCnv_4.Text = "&4"
        Me._chkQGLCnv_4.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_5
        '
        Me._chkQGLCnv_5.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_5, CType(5, Short))
        Me._chkQGLCnv_5.Location = New System.Drawing.Point(341, 308)
        Me._chkQGLCnv_5.Name = "_chkQGLCnv_5"
        Me._chkQGLCnv_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_5.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_5.TabIndex = 75
        Me._chkQGLCnv_5.Text = "&5"
        Me._chkQGLCnv_5.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_6
        '
        Me._chkQGLCnv_6.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_6, CType(6, Short))
        Me._chkQGLCnv_6.Location = New System.Drawing.Point(181, 340)
        Me._chkQGLCnv_6.Name = "_chkQGLCnv_6"
        Me._chkQGLCnv_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_6.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_6.TabIndex = 76
        Me._chkQGLCnv_6.Text = "&6"
        Me._chkQGLCnv_6.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_7
        '
        Me._chkQGLCnv_7.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_7, CType(7, Short))
        Me._chkQGLCnv_7.Location = New System.Drawing.Point(221, 340)
        Me._chkQGLCnv_7.Name = "_chkQGLCnv_7"
        Me._chkQGLCnv_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_7.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_7.TabIndex = 77
        Me._chkQGLCnv_7.Text = "&7"
        Me._chkQGLCnv_7.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_8
        '
        Me._chkQGLCnv_8.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_8, CType(8, Short))
        Me._chkQGLCnv_8.Location = New System.Drawing.Point(261, 340)
        Me._chkQGLCnv_8.Name = "_chkQGLCnv_8"
        Me._chkQGLCnv_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_8.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_8.TabIndex = 78
        Me._chkQGLCnv_8.Text = "&8"
        Me._chkQGLCnv_8.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_9
        '
        Me._chkQGLCnv_9.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_9, CType(9, Short))
        Me._chkQGLCnv_9.Location = New System.Drawing.Point(301, 340)
        Me._chkQGLCnv_9.Name = "_chkQGLCnv_9"
        Me._chkQGLCnv_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_9.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_9.TabIndex = 79
        Me._chkQGLCnv_9.Text = "&9"
        Me._chkQGLCnv_9.UseVisualStyleBackColor = True
        '
        '_chkQGLCnv_10
        '
        Me._chkQGLCnv_10.BackColor = System.Drawing.SystemColors.Control
        Me._chkQGLCnv_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQGLCnv_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQGLCnv_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQGLCnv.SetIndex(Me._chkQGLCnv_10, CType(10, Short))
        Me._chkQGLCnv_10.Location = New System.Drawing.Point(341, 340)
        Me._chkQGLCnv_10.Name = "_chkQGLCnv_10"
        Me._chkQGLCnv_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQGLCnv_10.Size = New System.Drawing.Size(37, 21)
        Me._chkQGLCnv_10.TabIndex = 80
        Me._chkQGLCnv_10.Text = "&0"
        Me._chkQGLCnv_10.UseVisualStyleBackColor = True
        '
        'Frame13
        '
        Me.Frame13.BackColor = System.Drawing.SystemColors.Control
        Me.Frame13.Controls.Add(Me._optConvTapeOut_2)
        Me.Frame13.Controls.Add(Me._optConvTapeOut_1)
        Me.Frame13.Controls.Add(Me._optConvTapeOut_0)
        Me.Frame13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame13.Location = New System.Drawing.Point(15, 139)
        Me.Frame13.Name = "Frame13"
        Me.Frame13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame13.Size = New System.Drawing.Size(141, 114)
        Me.Frame13.TabIndex = 63
        Me.Frame13.TabStop = False
        Me.Frame13.Text = "Tape Out"
        '
        '_optConvTapeOut_2
        '
        Me._optConvTapeOut_2.BackColor = System.Drawing.SystemColors.Control
        Me._optConvTapeOut_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optConvTapeOut_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optConvTapeOut_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optConvTapeOut.SetIndex(Me._optConvTapeOut_2, CType(2, Short))
        Me._optConvTapeOut_2.Location = New System.Drawing.Point(16, 57)
        Me._optConvTapeOut_2.Name = "_optConvTapeOut_2"
        Me._optConvTapeOut_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optConvTapeOut_2.Size = New System.Drawing.Size(61, 17)
        Me._optConvTapeOut_2.TabIndex = 16
        Me._optConvTapeOut_2.TabStop = True
        Me._optConvTapeOut_2.Text = "&All"
        Me._optConvTapeOut_2.UseVisualStyleBackColor = True
        '
        '_optConvTapeOut_1
        '
        Me._optConvTapeOut_1.BackColor = System.Drawing.SystemColors.Control
        Me._optConvTapeOut_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optConvTapeOut_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optConvTapeOut_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optConvTapeOut.SetIndex(Me._optConvTapeOut_1, CType(1, Short))
        Me._optConvTapeOut_1.Location = New System.Drawing.Point(16, 41)
        Me._optConvTapeOut_1.Name = "_optConvTapeOut_1"
        Me._optConvTapeOut_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optConvTapeOut_1.Size = New System.Drawing.Size(65, 17)
        Me._optConvTapeOut_1.TabIndex = 15
        Me._optConvTapeOut_1.TabStop = True
        Me._optConvTapeOut_1.Text = "&Marked"
        Me._optConvTapeOut_1.UseVisualStyleBackColor = True
        '
        '_optConvTapeOut_0
        '
        Me._optConvTapeOut_0.BackColor = System.Drawing.SystemColors.Control
        Me._optConvTapeOut_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optConvTapeOut_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optConvTapeOut_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optConvTapeOut.SetIndex(Me._optConvTapeOut_0, CType(0, Short))
        Me._optConvTapeOut_0.Location = New System.Drawing.Point(16, 25)
        Me._optConvTapeOut_0.Name = "_optConvTapeOut_0"
        Me._optConvTapeOut_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optConvTapeOut_0.Size = New System.Drawing.Size(47, 17)
        Me._optConvTapeOut_0.TabIndex = 14
        Me._optConvTapeOut_0.TabStop = True
        Me._optConvTapeOut_0.Text = "O&ff"
        Me._optConvTapeOut_0.UseVisualStyleBackColor = True
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.cmdSysGPS)
        Me.Frame3.Controls.Add(Me.chkSysGPSEnable)
        Me.Frame3.Controls.Add(Me._Label27_2)
        Me.Frame3.Controls.Add(Me._Label59_18)
        Me.Frame3.Controls.Add(Me._Label59_17)
        Me.Frame3.Controls.Add(Me.lblSysLong)
        Me.Frame3.Controls.Add(Me.lblSysLat)
        Me.Frame3.Controls.Add(Me.lblSysRange)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(176, 139)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(189, 114)
        Me.Frame3.TabIndex = 59
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "GPS (15/996T Only)"
        '
        'cmdSysGPS
        '
        Me.cmdSysGPS.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSysGPS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSysGPS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSysGPS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSysGPS.Location = New System.Drawing.Point(99, 86)
        Me.cmdSysGPS.Name = "cmdSysGPS"
        Me.cmdSysGPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSysGPS.Size = New System.Drawing.Size(68, 25)
        Me.cmdSysGPS.TabIndex = 18
        Me.cmdSysGPS.Text = "Edit..."
        Me.cmdSysGPS.UseVisualStyleBackColor = True
        '
        'chkSysGPSEnable
        '
        Me.chkSysGPSEnable.BackColor = System.Drawing.SystemColors.Control
        Me.chkSysGPSEnable.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSysGPSEnable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSysGPSEnable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSysGPSEnable.Location = New System.Drawing.Point(12, 12)
        Me.chkSysGPSEnable.Name = "chkSysGPSEnable"
        Me.chkSysGPSEnable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSysGPSEnable.Size = New System.Drawing.Size(74, 17)
        Me.chkSysGPSEnable.TabIndex = 17
        Me.chkSysGPSEnable.Text = "E&nabled"
        Me.chkSysGPSEnable.UseVisualStyleBackColor = True
        '
        '_Label27_2
        '
        Me._Label27_2.AutoSize = True
        Me._Label27_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label27_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label27_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label27_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.SetIndex(Me._Label27_2, CType(2, Short))
        Me._Label27_2.Location = New System.Drawing.Point(21, 63)
        Me._Label27_2.Name = "_Label27_2"
        Me._Label27_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label27_2.Size = New System.Drawing.Size(41, 14)
        Me._Label27_2.TabIndex = 91
        Me._Label27_2.Text = "Range:"
        '
        '_Label59_18
        '
        Me._Label59_18.AutoSize = True
        Me._Label59_18.BackColor = System.Drawing.SystemColors.Control
        Me._Label59_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label59_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label59_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.SetIndex(Me._Label59_18, CType(18, Short))
        Me._Label59_18.Location = New System.Drawing.Point(15, 31)
        Me._Label59_18.Name = "_Label59_18"
        Me._Label59_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label59_18.Size = New System.Drawing.Size(45, 14)
        Me._Label59_18.TabIndex = 89
        Me._Label59_18.Text = "Latitude"
        Me._Label59_18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label59_17
        '
        Me._Label59_17.AutoSize = True
        Me._Label59_17.BackColor = System.Drawing.SystemColors.Control
        Me._Label59_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label59_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label59_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.SetIndex(Me._Label59_17, CType(17, Short))
        Me._Label59_17.Location = New System.Drawing.Point(3, 47)
        Me._Label59_17.Name = "_Label59_17"
        Me._Label59_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label59_17.Size = New System.Drawing.Size(60, 14)
        Me._Label59_17.TabIndex = 88
        Me._Label59_17.Text = "Longtitude:"
        Me._Label59_17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSysLong
        '
        Me.lblSysLong.AutoSize = True
        Me.lblSysLong.BackColor = System.Drawing.SystemColors.Control
        Me.lblSysLong.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSysLong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysLong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSysLong.Location = New System.Drawing.Point(59, 47)
        Me.lblSysLong.Name = "lblSysLong"
        Me.lblSysLong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSysLong.Size = New System.Drawing.Size(60, 14)
        Me.lblSysLong.TabIndex = 62
        Me.lblSysLong.Text = "lblSysLong"
        '
        'lblSysLat
        '
        Me.lblSysLat.AutoSize = True
        Me.lblSysLat.BackColor = System.Drawing.SystemColors.Control
        Me.lblSysLat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSysLat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysLat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSysLat.Location = New System.Drawing.Point(59, 31)
        Me.lblSysLat.Name = "lblSysLat"
        Me.lblSysLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSysLat.Size = New System.Drawing.Size(51, 14)
        Me.lblSysLat.TabIndex = 61
        Me.lblSysLat.Text = "lblSysLat"
        '
        'lblSysRange
        '
        Me.lblSysRange.AutoSize = True
        Me.lblSysRange.BackColor = System.Drawing.SystemColors.Control
        Me.lblSysRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSysRange.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysRange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSysRange.Location = New System.Drawing.Point(59, 63)
        Me.lblSysRange.Name = "lblSysRange"
        Me.lblSysRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSysRange.Size = New System.Drawing.Size(67, 14)
        Me.lblSysRange.TabIndex = 60
        Me.lblSysRange.Text = "lblSysRange"
        '
        'txtSiteName
        '
        Me.txtSiteName.AcceptsReturn = True
        Me.txtSiteName.BackColor = System.Drawing.SystemColors.Window
        Me.txtSiteName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSiteName.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSiteName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSiteName.Location = New System.Drawing.Point(16, 40)
        Me.txtSiteName.MaxLength = 16
        Me.txtSiteName.Name = "txtSiteName"
        Me.txtSiteName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSiteName.Size = New System.Drawing.Size(145, 18)
        Me.txtSiteName.TabIndex = 1
        '
        '_Label28_25
        '
        Me._Label28_25.AutoSize = True
        Me._Label28_25.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_25, CType(25, Short))
        Me._Label28_25.Location = New System.Drawing.Point(168, 76)
        Me._Label28_25.Name = "_Label28_25"
        Me._Label28_25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_25.Size = New System.Drawing.Size(216, 14)
        Me._Label28_25.TabIndex = 120
        Me._Label28_25.Text = "Hold Time                                  Delay Time   "
        '
        '_Label28_35
        '
        Me._Label28_35.AutoSize = True
        Me._Label28_35.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_35, CType(35, Short))
        Me._Label28_35.Location = New System.Drawing.Point(17, 268)
        Me._Label28_35.Name = "_Label28_35"
        Me._Label28_35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_35.Size = New System.Drawing.Size(132, 14)
        Me._Label28_35.TabIndex = 99
        Me._Label28_35.Text = "Quick Key Enable/Disable:"
        '
        '_Label28_34
        '
        Me._Label28_34.AutoSize = True
        Me._Label28_34.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_34, CType(34, Short))
        Me._Label28_34.Location = New System.Drawing.Point(29, 284)
        Me._Label28_34.Name = "_Label28_34"
        Me._Label28_34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_34.Size = New System.Drawing.Size(530, 14)
        Me._Label28_34.TabIndex = 98
        Me._Label28_34.Text = "Groups assigned the following quick keys can be enabled here. One key can be assi" & _
    "gned to multiple groups."
        '
        '_Label28_24
        '
        Me._Label28_24.AutoSize = True
        Me._Label28_24.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_24, CType(24, Short))
        Me._Label28_24.Location = New System.Drawing.Point(12, 24)
        Me._Label28_24.Name = "_Label28_24"
        Me._Label28_24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_24.Size = New System.Drawing.Size(521, 14)
        Me._Label28_24.TabIndex = 96
        Me._Label28_24.Text = "Name                                          Quick Key                          " & _
    "        Startup Key          APCO Mode      Threshold"
        '
        'frmFleetMap
        '
        Me.frmFleetMap.BackColor = System.Drawing.SystemColors.Control
        Me.frmFleetMap.Controls.Add(Me._cmbSizeCode_7)
        Me.frmFleetMap.Controls.Add(Me.cmdSaveFleetMap)
        Me.frmFleetMap.Controls.Add(Me.cmbFleetMap)
        Me.frmFleetMap.Controls.Add(Me._cmbSizeCode_6)
        Me.frmFleetMap.Controls.Add(Me._cmbSizeCode_5)
        Me.frmFleetMap.Controls.Add(Me._cmbSizeCode_4)
        Me.frmFleetMap.Controls.Add(Me._cmbSizeCode_3)
        Me.frmFleetMap.Controls.Add(Me._cmbSizeCode_2)
        Me.frmFleetMap.Controls.Add(Me._cmbSizeCode_1)
        Me.frmFleetMap.Controls.Add(Me._cmbSizeCode_0)
        Me.frmFleetMap.Controls.Add(Me.Label26)
        Me.frmFleetMap.Controls.Add(Me.Label31)
        Me.frmFleetMap.Controls.Add(Me._Label28_2)
        Me.frmFleetMap.Controls.Add(Me.Label30)
        Me.frmFleetMap.Controls.Add(Me.Label29)
        Me.frmFleetMap.Controls.Add(Me._Label28_13)
        Me.frmFleetMap.Controls.Add(Me._Label28_12)
        Me.frmFleetMap.Controls.Add(Me._Label28_11)
        Me.frmFleetMap.Controls.Add(Me._Label28_10)
        Me.frmFleetMap.Controls.Add(Me._Label28_9)
        Me.frmFleetMap.Controls.Add(Me._Label28_1)
        Me.frmFleetMap.Controls.Add(Me._Label28_0)
        Me.frmFleetMap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmFleetMap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmFleetMap.Location = New System.Drawing.Point(16, 9)
        Me.frmFleetMap.Name = "frmFleetMap"
        Me.frmFleetMap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmFleetMap.Size = New System.Drawing.Size(100, 58)
        Me.frmFleetMap.TabIndex = 43
        Me.frmFleetMap.TabStop = False
        Me.frmFleetMap.Text = "Custom Fleet Mapping"
        Me.frmFleetMap.Visible = False
        '
        '_cmbSizeCode_7
        '
        Me._cmbSizeCode_7.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSizeCode_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSizeCode_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSizeCode_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSizeCode_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSizeCode.SetIndex(Me._cmbSizeCode_7, CType(7, Short))
        Me._cmbSizeCode_7.Location = New System.Drawing.Point(96, 312)
        Me._cmbSizeCode_7.Name = "_cmbSizeCode_7"
        Me._cmbSizeCode_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSizeCode_7.Size = New System.Drawing.Size(49, 22)
        Me._cmbSizeCode_7.TabIndex = 20
        '
        'cmdSaveFleetMap
        '
        Me.cmdSaveFleetMap.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveFleetMap.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSaveFleetMap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveFleetMap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSaveFleetMap.Location = New System.Drawing.Point(424, 344)
        Me.cmdSaveFleetMap.Name = "cmdSaveFleetMap"
        Me.cmdSaveFleetMap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSaveFleetMap.Size = New System.Drawing.Size(89, 25)
        Me.cmdSaveFleetMap.TabIndex = 21
        Me.cmdSaveFleetMap.Text = "Save && Appl&y"
        Me.cmdSaveFleetMap.UseVisualStyleBackColor = True
        '
        'cmbFleetMap
        '
        Me.cmbFleetMap.BackColor = System.Drawing.SystemColors.Window
        Me.cmbFleetMap.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbFleetMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFleetMap.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFleetMap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbFleetMap.Location = New System.Drawing.Point(152, 72)
        Me.cmbFleetMap.Name = "cmbFleetMap"
        Me.cmbFleetMap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbFleetMap.Size = New System.Drawing.Size(105, 22)
        Me.cmbFleetMap.TabIndex = 12
        '
        '_cmbSizeCode_6
        '
        Me._cmbSizeCode_6.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSizeCode_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSizeCode_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSizeCode_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSizeCode_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSizeCode.SetIndex(Me._cmbSizeCode_6, CType(6, Short))
        Me._cmbSizeCode_6.Location = New System.Drawing.Point(96, 288)
        Me._cmbSizeCode_6.Name = "_cmbSizeCode_6"
        Me._cmbSizeCode_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSizeCode_6.Size = New System.Drawing.Size(49, 22)
        Me._cmbSizeCode_6.TabIndex = 19
        '
        '_cmbSizeCode_5
        '
        Me._cmbSizeCode_5.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSizeCode_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSizeCode_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSizeCode_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSizeCode_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSizeCode.SetIndex(Me._cmbSizeCode_5, CType(5, Short))
        Me._cmbSizeCode_5.Location = New System.Drawing.Point(96, 264)
        Me._cmbSizeCode_5.Name = "_cmbSizeCode_5"
        Me._cmbSizeCode_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSizeCode_5.Size = New System.Drawing.Size(49, 22)
        Me._cmbSizeCode_5.TabIndex = 18
        '
        '_cmbSizeCode_4
        '
        Me._cmbSizeCode_4.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSizeCode_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSizeCode_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSizeCode_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSizeCode_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSizeCode.SetIndex(Me._cmbSizeCode_4, CType(4, Short))
        Me._cmbSizeCode_4.Location = New System.Drawing.Point(96, 240)
        Me._cmbSizeCode_4.Name = "_cmbSizeCode_4"
        Me._cmbSizeCode_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSizeCode_4.Size = New System.Drawing.Size(49, 22)
        Me._cmbSizeCode_4.TabIndex = 17
        '
        '_cmbSizeCode_3
        '
        Me._cmbSizeCode_3.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSizeCode_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSizeCode_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSizeCode_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSizeCode_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSizeCode.SetIndex(Me._cmbSizeCode_3, CType(3, Short))
        Me._cmbSizeCode_3.Location = New System.Drawing.Point(96, 216)
        Me._cmbSizeCode_3.Name = "_cmbSizeCode_3"
        Me._cmbSizeCode_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSizeCode_3.Size = New System.Drawing.Size(49, 22)
        Me._cmbSizeCode_3.TabIndex = 16
        '
        '_cmbSizeCode_2
        '
        Me._cmbSizeCode_2.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSizeCode_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSizeCode_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSizeCode_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSizeCode_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSizeCode.SetIndex(Me._cmbSizeCode_2, CType(2, Short))
        Me._cmbSizeCode_2.Location = New System.Drawing.Point(96, 192)
        Me._cmbSizeCode_2.Name = "_cmbSizeCode_2"
        Me._cmbSizeCode_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSizeCode_2.Size = New System.Drawing.Size(49, 22)
        Me._cmbSizeCode_2.TabIndex = 15
        '
        '_cmbSizeCode_1
        '
        Me._cmbSizeCode_1.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSizeCode_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSizeCode_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSizeCode_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSizeCode_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSizeCode.SetIndex(Me._cmbSizeCode_1, CType(1, Short))
        Me._cmbSizeCode_1.Location = New System.Drawing.Point(96, 168)
        Me._cmbSizeCode_1.Name = "_cmbSizeCode_1"
        Me._cmbSizeCode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSizeCode_1.Size = New System.Drawing.Size(49, 22)
        Me._cmbSizeCode_1.TabIndex = 14
        '
        '_cmbSizeCode_0
        '
        Me._cmbSizeCode_0.BackColor = System.Drawing.SystemColors.Window
        Me._cmbSizeCode_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbSizeCode_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbSizeCode_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbSizeCode_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSizeCode.SetIndex(Me._cmbSizeCode_0, CType(0, Short))
        Me._cmbSizeCode_0.Location = New System.Drawing.Point(96, 144)
        Me._cmbSizeCode_0.Name = "_cmbSizeCode_0"
        Me._cmbSizeCode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbSizeCode_0.Size = New System.Drawing.Size(49, 22)
        Me._cmbSizeCode_0.TabIndex = 13
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(96, 120)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(56, 14)
        Me.Label26.TabIndex = 55
        Me.Label26.Text = "Size Code"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(24, 120)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(64, 14)
        Me.Label31.TabIndex = 54
        Me.Label31.Text = "Block Code:"
        '
        '_Label28_2
        '
        Me._Label28_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_2, CType(2, Short))
        Me._Label28_2.Location = New System.Drawing.Point(72, 312)
        Me._Label28_2.Name = "_Label28_2"
        Me._Label28_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_2.Size = New System.Drawing.Size(17, 17)
        Me._Label28_2.TabIndex = 53
        Me._Label28_2.Text = "7"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(40, 74)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(100, 15)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "Choose Fleet Map:"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(16, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(473, 25)
        Me.Label29.TabIndex = 51
        Me.Label29.Text = "Fleet mapping is applicable only to Motorola Type I and Type II Hybrids. If unsur" & _
    "e, leave default."
        '
        '_Label28_13
        '
        Me._Label28_13.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_13, CType(13, Short))
        Me._Label28_13.Location = New System.Drawing.Point(72, 192)
        Me._Label28_13.Name = "_Label28_13"
        Me._Label28_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_13.Size = New System.Drawing.Size(17, 17)
        Me._Label28_13.TabIndex = 50
        Me._Label28_13.Text = "2"
        '
        '_Label28_12
        '
        Me._Label28_12.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_12, CType(12, Short))
        Me._Label28_12.Location = New System.Drawing.Point(72, 216)
        Me._Label28_12.Name = "_Label28_12"
        Me._Label28_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_12.Size = New System.Drawing.Size(17, 17)
        Me._Label28_12.TabIndex = 49
        Me._Label28_12.Text = "3"
        '
        '_Label28_11
        '
        Me._Label28_11.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_11, CType(11, Short))
        Me._Label28_11.Location = New System.Drawing.Point(72, 240)
        Me._Label28_11.Name = "_Label28_11"
        Me._Label28_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_11.Size = New System.Drawing.Size(17, 17)
        Me._Label28_11.TabIndex = 48
        Me._Label28_11.Text = "4"
        '
        '_Label28_10
        '
        Me._Label28_10.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_10, CType(10, Short))
        Me._Label28_10.Location = New System.Drawing.Point(72, 264)
        Me._Label28_10.Name = "_Label28_10"
        Me._Label28_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_10.Size = New System.Drawing.Size(17, 17)
        Me._Label28_10.TabIndex = 47
        Me._Label28_10.Text = "5"
        '
        '_Label28_9
        '
        Me._Label28_9.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_9, CType(9, Short))
        Me._Label28_9.Location = New System.Drawing.Point(72, 288)
        Me._Label28_9.Name = "_Label28_9"
        Me._Label28_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_9.Size = New System.Drawing.Size(17, 17)
        Me._Label28_9.TabIndex = 46
        Me._Label28_9.Text = "6"
        '
        '_Label28_1
        '
        Me._Label28_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_1, CType(1, Short))
        Me._Label28_1.Location = New System.Drawing.Point(72, 168)
        Me._Label28_1.Name = "_Label28_1"
        Me._Label28_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_1.Size = New System.Drawing.Size(17, 17)
        Me._Label28_1.TabIndex = 45
        Me._Label28_1.Text = "1"
        '
        '_Label28_0
        '
        Me._Label28_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_0, CType(0, Short))
        Me._Label28_0.Location = New System.Drawing.Point(72, 144)
        Me._Label28_0.Name = "_Label28_0"
        Me._Label28_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_0.Size = New System.Drawing.Size(17, 17)
        Me._Label28_0.TabIndex = 44
        Me._Label28_0.Text = "0"
        '
        'frmGroupTrunk
        '
        Me.frmGroupTrunk.BackColor = System.Drawing.SystemColors.Control
        Me.frmGroupTrunk.Controls.Add(Me._cmdFreeGQK_1)
        Me.frmGroupTrunk.Controls.Add(Me.GroupBox3)
        Me.frmGroupTrunk.Controls.Add(Me._cmdJustTGID_2)
        Me.frmGroupTrunk.Controls.Add(Me.chkTGIDSimpleView)
        Me.frmGroupTrunk.Controls.Add(Me._cmdJustTGID_1)
        Me.frmGroupTrunk.Controls.Add(Me.grdTGID)
        Me.frmGroupTrunk.Controls.Add(Me._cmdJustTGID_0)
        Me.frmGroupTrunk.Controls.Add(Me._cmdJustTGIDChan_2)
        Me.frmGroupTrunk.Controls.Add(Me.cmbTGIDGroupQuickkey)
        Me.frmGroupTrunk.Controls.Add(Me._cmdJustTGIDChan_1)
        Me.frmGroupTrunk.Controls.Add(Me.txtTGIDGroupName)
        Me.frmGroupTrunk.Controls.Add(Me._cmdJustTGIDChan_0)
        Me.frmGroupTrunk.Controls.Add(Me.chkTGIDGroupLockout)
        Me.frmGroupTrunk.Controls.Add(Me.cmdMoveDownTGID)
        Me.frmGroupTrunk.Controls.Add(Me._Label28_26)
        Me.frmGroupTrunk.Controls.Add(Me.cmdMoveUpTGID)
        Me.frmGroupTrunk.Controls.Add(Me.cmdNewTGID)
        Me.frmGroupTrunk.Controls.Add(Me.cmdDelTGID)
        Me.frmGroupTrunk.Controls.Add(Me.cmdEZGrabTGID)
        Me.frmGroupTrunk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmGroupTrunk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmGroupTrunk.Location = New System.Drawing.Point(299, 59)
        Me.frmGroupTrunk.Name = "frmGroupTrunk"
        Me.frmGroupTrunk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGroupTrunk.Size = New System.Drawing.Size(137, 190)
        Me.frmGroupTrunk.TabIndex = 40
        Me.frmGroupTrunk.TabStop = False
        Me.frmGroupTrunk.Text = "Group && Channel Options - Trunked System"
        Me.frmGroupTrunk.Visible = False
        '
        '_cmdFreeGQK_1
        '
        Me._cmdFreeGQK_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdFreeGQK_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdFreeGQK_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdFreeGQK_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFreeGQK.SetIndex(Me._cmdFreeGQK_1, CType(1, Short))
        Me._cmdFreeGQK_1.Location = New System.Drawing.Point(268, 39)
        Me._cmdFreeGQK_1.Name = "_cmdFreeGQK_1"
        Me._cmdFreeGQK_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdFreeGQK_1.Size = New System.Drawing.Size(61, 21)
        Me._cmdFreeGQK_1.TabIndex = 39
        Me._cmdFreeGQK_1.Text = "Fi&nd Free"
        Me._cmdFreeGQK_1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.cmdTGIDGpsEdit)
        Me.GroupBox3.Controls.Add(Me.chkTGIDGpsEnabled)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lblTGIDLong)
        Me.GroupBox3.Controls.Add(Me.lblTGIDLat)
        Me.GroupBox3.Controls.Add(Me.lblTGIDRange)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(463, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(189, 100)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GPS (XT Scanners Only)"
        '
        'cmdTGIDGpsEdit
        '
        Me.cmdTGIDGpsEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTGIDGpsEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTGIDGpsEdit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTGIDGpsEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTGIDGpsEdit.Location = New System.Drawing.Point(119, 76)
        Me.cmdTGIDGpsEdit.Name = "cmdTGIDGpsEdit"
        Me.cmdTGIDGpsEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTGIDGpsEdit.Size = New System.Drawing.Size(68, 22)
        Me.cmdTGIDGpsEdit.TabIndex = 18
        Me.cmdTGIDGpsEdit.Text = "Edit..."
        Me.cmdTGIDGpsEdit.UseVisualStyleBackColor = True
        '
        'chkTGIDGpsEnabled
        '
        Me.chkTGIDGpsEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.chkTGIDGpsEnabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTGIDGpsEnabled.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTGIDGpsEnabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTGIDGpsEnabled.Location = New System.Drawing.Point(12, 12)
        Me.chkTGIDGpsEnabled.Name = "chkTGIDGpsEnabled"
        Me.chkTGIDGpsEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTGIDGpsEnabled.Size = New System.Drawing.Size(74, 17)
        Me.chkTGIDGpsEnabled.TabIndex = 17
        Me.chkTGIDGpsEnabled.Text = "E&nabled"
        Me.chkTGIDGpsEnabled.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(21, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(41, 14)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Range:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(15, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(45, 14)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Latitude"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(3, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(60, 14)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Longtitude:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTGIDLong
        '
        Me.lblTGIDLong.AutoSize = True
        Me.lblTGIDLong.BackColor = System.Drawing.SystemColors.Control
        Me.lblTGIDLong.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTGIDLong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTGIDLong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTGIDLong.Location = New System.Drawing.Point(59, 47)
        Me.lblTGIDLong.Name = "lblTGIDLong"
        Me.lblTGIDLong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTGIDLong.Size = New System.Drawing.Size(64, 14)
        Me.lblTGIDLong.TabIndex = 62
        Me.lblTGIDLong.Text = "lblTGIDLong"
        '
        'lblTGIDLat
        '
        Me.lblTGIDLat.AutoSize = True
        Me.lblTGIDLat.BackColor = System.Drawing.SystemColors.Control
        Me.lblTGIDLat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTGIDLat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTGIDLat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTGIDLat.Location = New System.Drawing.Point(59, 31)
        Me.lblTGIDLat.Name = "lblTGIDLat"
        Me.lblTGIDLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTGIDLat.Size = New System.Drawing.Size(55, 14)
        Me.lblTGIDLat.TabIndex = 61
        Me.lblTGIDLat.Text = "lblTGIDLat"
        '
        'lblTGIDRange
        '
        Me.lblTGIDRange.AutoSize = True
        Me.lblTGIDRange.BackColor = System.Drawing.SystemColors.Control
        Me.lblTGIDRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTGIDRange.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTGIDRange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTGIDRange.Location = New System.Drawing.Point(59, 63)
        Me.lblTGIDRange.Name = "lblTGIDRange"
        Me.lblTGIDRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTGIDRange.Size = New System.Drawing.Size(71, 14)
        Me.lblTGIDRange.TabIndex = 60
        Me.lblTGIDRange.Text = "lblTGIDRange"
        '
        'chkTGIDSimpleView
        '
        Me.chkTGIDSimpleView.BackColor = System.Drawing.SystemColors.Control
        Me.chkTGIDSimpleView.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTGIDSimpleView.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTGIDSimpleView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTGIDSimpleView.Location = New System.Drawing.Point(16, 76)
        Me.chkTGIDSimpleView.Name = "chkTGIDSimpleView"
        Me.chkTGIDSimpleView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTGIDSimpleView.Size = New System.Drawing.Size(89, 19)
        Me.chkTGIDSimpleView.TabIndex = 41
        Me.chkTGIDSimpleView.Text = "Simple View"
        Me.chkTGIDSimpleView.UseVisualStyleBackColor = True
        '
        'grdTGID
        '
        Me.grdTGID.AccessibleDescription = "This grid contains every TGID channel programmied into this group"
        Me.grdTGID.AccessibleName = "TGID Channels"
        Me.grdTGID.AllowUserToAddRows = False
        Me.grdTGID.AllowUserToDeleteRows = False
        Me.grdTGID.AllowUserToResizeRows = False
        Me.grdTGID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTGID.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdTGID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdTGID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTGID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtTGID, Me.colTGID, Me.colLO, Me.colTGIDPri, Me.cmbTGIDAlertTone, Me.cmbTGIDAlertLevel, Me.grdTGID_AltColor, Me.grdTGID_AltPat, Me.grdTGID_VolOffset, Me.cmbTGIDAudioType, Me.grdTGID_NumTag, Me.colTapeOut, Me.txtTGIDComment})
        Me.grdTGID.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.grdTGID.Location = New System.Drawing.Point(14, 115)
        Me.grdTGID.Name = "grdTGID"
        Me.grdTGID.RowHeadersVisible = False
        Me.grdTGID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTGID.ShowCellToolTips = False
        Me.grdTGID.ShowEditingIcon = False
        Me.grdTGID.Size = New System.Drawing.Size(118, 66)
        Me.grdTGID.TabIndex = 50
        '
        'txtTGID
        '
        Me.txtTGID.HeaderText = "Display"
        Me.txtTGID.MaxInputLength = 16
        Me.txtTGID.Name = "txtTGID"
        Me.txtTGID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.txtTGID.Width = 140
        '
        'colTGID
        '
        Me.colTGID.HeaderText = "TGID"
        Me.colTGID.MaxInputLength = 15
        Me.colTGID.Name = "colTGID"
        Me.colTGID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colLO
        '
        Me.colLO.HeaderText = "L/O"
        Me.colLO.Name = "colLO"
        Me.colLO.Width = 40
        '
        'colTGIDPri
        '
        Me.colTGIDPri.HeaderText = "Pri"
        Me.colTGIDPri.Name = "colTGIDPri"
        Me.colTGIDPri.Width = 50
        '
        'cmbTGIDAlertTone
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cmbTGIDAlertTone.DefaultCellStyle = DataGridViewCellStyle3
        Me.cmbTGIDAlertTone.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cmbTGIDAlertTone.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTGIDAlertTone.HeaderText = "Alt Tone"
        Me.cmbTGIDAlertTone.Name = "cmbTGIDAlertTone"
        Me.cmbTGIDAlertTone.Width = 60
        '
        'cmbTGIDAlertLevel
        '
        Me.cmbTGIDAlertLevel.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cmbTGIDAlertLevel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTGIDAlertLevel.HeaderText = "Alt Level"
        Me.cmbTGIDAlertLevel.Name = "cmbTGIDAlertLevel"
        Me.cmbTGIDAlertLevel.ToolTipText = "Alert tone volume level. 0 = Auto"
        Me.cmbTGIDAlertLevel.Width = 60
        '
        'grdTGID_AltColor
        '
        Me.grdTGID_AltColor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdTGID_AltColor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdTGID_AltColor.HeaderText = "Alt Color"
        Me.grdTGID_AltColor.Name = "grdTGID_AltColor"
        Me.grdTGID_AltColor.Width = 60
        '
        'grdTGID_AltPat
        '
        Me.grdTGID_AltPat.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdTGID_AltPat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdTGID_AltPat.HeaderText = "Alt Patern"
        Me.grdTGID_AltPat.Name = "grdTGID_AltPat"
        Me.grdTGID_AltPat.Width = 60
        '
        'grdTGID_VolOffset
        '
        Me.grdTGID_VolOffset.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdTGID_VolOffset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdTGID_VolOffset.HeaderText = "Vol Adj"
        Me.grdTGID_VolOffset.Name = "grdTGID_VolOffset"
        Me.grdTGID_VolOffset.Width = 60
        '
        'cmbTGIDAudioType
        '
        Me.cmbTGIDAudioType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cmbTGIDAudioType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTGIDAudioType.HeaderText = "AudioType"
        Me.cmbTGIDAudioType.Name = "cmbTGIDAudioType"
        Me.cmbTGIDAudioType.Width = 70
        '
        'grdTGID_NumTag
        '
        Me.grdTGID_NumTag.HeaderText = "Num Tag"
        Me.grdTGID_NumTag.Name = "grdTGID_NumTag"
        Me.grdTGID_NumTag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdTGID_NumTag.Width = 65
        '
        'colTapeOut
        '
        Me.colTapeOut.HeaderText = "Rec Out"
        Me.colTapeOut.Name = "colTapeOut"
        Me.colTapeOut.Width = 60
        '
        'txtTGIDComment
        '
        Me.txtTGIDComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtTGIDComment.HeaderText = "Comment"
        Me.txtTGIDComment.MaxInputLength = 255
        Me.txtTGIDComment.MinimumWidth = 100
        Me.txtTGIDComment.Name = "txtTGIDComment"
        Me.txtTGIDComment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'txtTGIDGroupName
        '
        Me.txtTGIDGroupName.AcceptsReturn = True
        Me.txtTGIDGroupName.BackColor = System.Drawing.SystemColors.Window
        Me.txtTGIDGroupName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTGIDGroupName.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTGIDGroupName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTGIDGroupName.Location = New System.Drawing.Point(14, 39)
        Me.txtTGIDGroupName.MaxLength = 16
        Me.txtTGIDGroupName.Name = "txtTGIDGroupName"
        Me.txtTGIDGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTGIDGroupName.Size = New System.Drawing.Size(169, 18)
        Me.txtTGIDGroupName.TabIndex = 34
        '
        'chkTGIDGroupLockout
        '
        Me.chkTGIDGroupLockout.BackColor = System.Drawing.SystemColors.Control
        Me.chkTGIDGroupLockout.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTGIDGroupLockout.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTGIDGroupLockout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkTGIDGroupLockout.Location = New System.Drawing.Point(345, 38)
        Me.chkTGIDGroupLockout.Name = "chkTGIDGroupLockout"
        Me.chkTGIDGroupLockout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTGIDGroupLockout.Size = New System.Drawing.Size(105, 21)
        Me.chkTGIDGroupLockout.TabIndex = 40
        Me.chkTGIDGroupLockout.Text = "Locked Out"
        Me.chkTGIDGroupLockout.UseVisualStyleBackColor = True
        '
        '_Label28_26
        '
        Me._Label28_26.AutoSize = True
        Me._Label28_26.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_26, CType(26, Short))
        Me._Label28_26.Location = New System.Drawing.Point(13, 23)
        Me._Label28_26.Name = "_Label28_26"
        Me._Label28_26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_26.Size = New System.Drawing.Size(245, 14)
        Me._Label28_26.TabIndex = 97
        Me._Label28_26.Text = "Name                                                      Quick Key"
        '
        'cmdEZGrabTGID
        '
        Me.cmdEZGrabTGID.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEZGrabTGID.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEZGrabTGID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEZGrabTGID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEZGrabTGID.Location = New System.Drawing.Point(361, 81)
        Me.cmdEZGrabTGID.Name = "cmdEZGrabTGID"
        Me.cmdEZGrabTGID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEZGrabTGID.Size = New System.Drawing.Size(97, 25)
        Me.cmdEZGrabTGID.TabIndex = 49
        Me.cmdEZGrabTGID.Text = "E&Z-Grab!"
        Me.cmdEZGrabTGID.UseVisualStyleBackColor = True
        '
        'frmGroupConv
        '
        Me.frmGroupConv.BackColor = System.Drawing.SystemColors.Control
        Me.frmGroupConv.Controls.Add(Me.GroupBox4)
        Me.frmGroupConv.Controls.Add(Me._cmdFreeGQK_0)
        Me.frmGroupConv.Controls.Add(Me.chkSimpleView)
        Me.frmGroupConv.Controls.Add(Me._cmdJustCnvGrp_2)
        Me.frmGroupConv.Controls.Add(Me.grdConvChan)
        Me.frmGroupConv.Controls.Add(Me._cmdJustCnvGrp_1)
        Me.frmGroupConv.Controls.Add(Me.cmdDeleteConvChan)
        Me.frmGroupConv.Controls.Add(Me._cmdJustCnvGrp_0)
        Me.frmGroupConv.Controls.Add(Me.cmdNewConvChannel)
        Me.frmGroupConv.Controls.Add(Me.cmbConvGroupQuickKey)
        Me.frmGroupConv.Controls.Add(Me.cmdConvChanMoveUp)
        Me.frmGroupConv.Controls.Add(Me.txtConvGroupName)
        Me.frmGroupConv.Controls.Add(Me.chkConvGroupLockout)
        Me.frmGroupConv.Controls.Add(Me.cmdConvChannelMoveDown)
        Me.frmGroupConv.Controls.Add(Me._Label28_37)
        Me.frmGroupConv.Controls.Add(Me.cmdConvGrab)
        Me.frmGroupConv.Controls.Add(Me._cmdJust_0)
        Me.frmGroupConv.Controls.Add(Me._cmdJust_1)
        Me.frmGroupConv.Controls.Add(Me._cmdJust_2)
        Me.frmGroupConv.Controls.Add(Me.cmdCnvPicPick)
        Me.frmGroupConv.Controls.Add(Me.chkCnvPic)
        Me.frmGroupConv.Controls.Add(Me._Label28_41)
        Me.frmGroupConv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmGroupConv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmGroupConv.Location = New System.Drawing.Point(167, 307)
        Me.frmGroupConv.Name = "frmGroupConv"
        Me.frmGroupConv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGroupConv.Size = New System.Drawing.Size(366, 184)
        Me.frmGroupConv.TabIndex = 38
        Me.frmGroupConv.TabStop = False
        Me.frmGroupConv.Text = "Edit Conventional Group"
        Me.frmGroupConv.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.cmdCnvGrpGPSEdit)
        Me.GroupBox4.Controls.Add(Me.chkCnvGrpGPS)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lblCnvGrpLong)
        Me.GroupBox4.Controls.Add(Me.lblCnvGrpLat)
        Me.GroupBox4.Controls.Add(Me.lblCnvGrpRange)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(471, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(189, 100)
        Me.GroupBox4.TabIndex = 269
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GPS (XT Scanners Only)"
        '
        'cmdCnvGrpGPSEdit
        '
        Me.cmdCnvGrpGPSEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCnvGrpGPSEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCnvGrpGPSEdit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCnvGrpGPSEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCnvGrpGPSEdit.Location = New System.Drawing.Point(119, 76)
        Me.cmdCnvGrpGPSEdit.Name = "cmdCnvGrpGPSEdit"
        Me.cmdCnvGrpGPSEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCnvGrpGPSEdit.Size = New System.Drawing.Size(68, 22)
        Me.cmdCnvGrpGPSEdit.TabIndex = 18
        Me.cmdCnvGrpGPSEdit.Text = "Edit..."
        Me.cmdCnvGrpGPSEdit.UseVisualStyleBackColor = True
        '
        'chkCnvGrpGPS
        '
        Me.chkCnvGrpGPS.BackColor = System.Drawing.SystemColors.Control
        Me.chkCnvGrpGPS.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCnvGrpGPS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCnvGrpGPS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCnvGrpGPS.Location = New System.Drawing.Point(12, 12)
        Me.chkCnvGrpGPS.Name = "chkCnvGrpGPS"
        Me.chkCnvGrpGPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCnvGrpGPS.Size = New System.Drawing.Size(74, 17)
        Me.chkCnvGrpGPS.TabIndex = 17
        Me.chkCnvGrpGPS.Text = "E&nabled"
        Me.chkCnvGrpGPS.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(21, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(41, 14)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Range:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(15, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(45, 14)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Latitude"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(3, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(60, 14)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Longtitude:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCnvGrpLong
        '
        Me.lblCnvGrpLong.AutoSize = True
        Me.lblCnvGrpLong.BackColor = System.Drawing.SystemColors.Control
        Me.lblCnvGrpLong.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCnvGrpLong.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnvGrpLong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCnvGrpLong.Location = New System.Drawing.Point(59, 47)
        Me.lblCnvGrpLong.Name = "lblCnvGrpLong"
        Me.lblCnvGrpLong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCnvGrpLong.Size = New System.Drawing.Size(52, 14)
        Me.lblCnvGrpLong.TabIndex = 62
        Me.lblCnvGrpLong.Text = "0.000000"
        '
        'lblCnvGrpLat
        '
        Me.lblCnvGrpLat.AutoSize = True
        Me.lblCnvGrpLat.BackColor = System.Drawing.SystemColors.Control
        Me.lblCnvGrpLat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCnvGrpLat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnvGrpLat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCnvGrpLat.Location = New System.Drawing.Point(59, 31)
        Me.lblCnvGrpLat.Name = "lblCnvGrpLat"
        Me.lblCnvGrpLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCnvGrpLat.Size = New System.Drawing.Size(52, 14)
        Me.lblCnvGrpLat.TabIndex = 61
        Me.lblCnvGrpLat.Text = "0.000000"
        '
        'lblCnvGrpRange
        '
        Me.lblCnvGrpRange.AutoSize = True
        Me.lblCnvGrpRange.BackColor = System.Drawing.SystemColors.Control
        Me.lblCnvGrpRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCnvGrpRange.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnvGrpRange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCnvGrpRange.Location = New System.Drawing.Point(59, 63)
        Me.lblCnvGrpRange.Name = "lblCnvGrpRange"
        Me.lblCnvGrpRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCnvGrpRange.Size = New System.Drawing.Size(40, 14)
        Me.lblCnvGrpRange.TabIndex = 60
        Me.lblCnvGrpRange.Text = "0 Miles"
        '
        '_cmdFreeGQK_0
        '
        Me._cmdFreeGQK_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdFreeGQK_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdFreeGQK_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdFreeGQK_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFreeGQK.SetIndex(Me._cmdFreeGQK_0, CType(0, Short))
        Me._cmdFreeGQK_0.Location = New System.Drawing.Point(270, 36)
        Me._cmdFreeGQK_0.Name = "_cmdFreeGQK_0"
        Me._cmdFreeGQK_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdFreeGQK_0.Size = New System.Drawing.Size(61, 21)
        Me._cmdFreeGQK_0.TabIndex = 229
        Me._cmdFreeGQK_0.Text = "Fi&nd Free"
        Me._cmdFreeGQK_0.UseVisualStyleBackColor = True
        '
        'grdConvChan
        '
        Me.grdConvChan.AccessibleDescription = "This grid contains every conventional channel programmed into this group"
        Me.grdConvChan.AccessibleName = "Conventional Channels"
        Me.grdConvChan.AllowUserToAddRows = False
        Me.grdConvChan.AllowUserToDeleteRows = False
        Me.grdConvChan.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grdConvChan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdConvChan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdConvChan.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdConvChan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdConvChan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdConvChan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdConvChan_Display, Me.grdConvChan_Freq, Me.grdConvChan_LO, Me.grdConvChan_Tone, Me.grdConvChan_ToneLO, Me.grdConvChan_Att, Me.grdConvChan_Pri, Me.grdConvChan_Step, Me.grdCOnvChan_MOD, Me.grdConvChan_NAC, Me.grdConvChan_AudioType, Me.grdConvChan_AltTone, Me.grdConvChan_AltLevel, Me.grdConvChan_AltColor, Me.grdConvChan_AltPattern, Me.grdConvChan_VolOffset, Me.grdConvChan_NumTag, Me.grdConvChan_RecOut, Me.grdConvChan_Comment})
        Me.grdConvChan.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdConvChan.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.grdConvChan.Location = New System.Drawing.Point(9, 126)
        Me.grdConvChan.Name = "grdConvChan"
        Me.grdConvChan.RowHeadersVisible = False
        Me.grdConvChan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdConvChan.ShowCellToolTips = False
        Me.grdConvChan.ShowEditingIcon = False
        Me.grdConvChan.Size = New System.Drawing.Size(351, 45)
        Me.grdConvChan.TabIndex = 267
        '
        'grdConvChan_Display
        '
        Me.grdConvChan_Display.HeaderText = "Display"
        Me.grdConvChan_Display.MaxInputLength = 16
        Me.grdConvChan_Display.Name = "grdConvChan_Display"
        Me.grdConvChan_Display.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.grdConvChan_Display.Width = 140
        '
        'grdConvChan_Freq
        '
        Me.grdConvChan_Freq.HeaderText = "Frequency"
        Me.grdConvChan_Freq.MaxInputLength = 15
        Me.grdConvChan_Freq.Name = "grdConvChan_Freq"
        Me.grdConvChan_Freq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdConvChan_Freq.Width = 80
        '
        'grdConvChan_LO
        '
        Me.grdConvChan_LO.HeaderText = "L/O"
        Me.grdConvChan_LO.Name = "grdConvChan_LO"
        Me.grdConvChan_LO.Width = 40
        '
        'grdConvChan_Tone
        '
        Me.grdConvChan_Tone.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdConvChan_Tone.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdConvChan_Tone.HeaderText = "Tone"
        Me.grdConvChan_Tone.Name = "grdConvChan_Tone"
        Me.grdConvChan_Tone.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdConvChan_Tone.Width = 70
        '
        'grdConvChan_ToneLO
        '
        Me.grdConvChan_ToneLO.HeaderText = "Tone LO"
        Me.grdConvChan_ToneLO.Name = "grdConvChan_ToneLO"
        Me.grdConvChan_ToneLO.Width = 60
        '
        'grdConvChan_Att
        '
        Me.grdConvChan_Att.HeaderText = "Att"
        Me.grdConvChan_Att.Name = "grdConvChan_Att"
        Me.grdConvChan_Att.Width = 40
        '
        'grdConvChan_Pri
        '
        Me.grdConvChan_Pri.HeaderText = "Pri"
        Me.grdConvChan_Pri.Name = "grdConvChan_Pri"
        Me.grdConvChan_Pri.Width = 40
        '
        'grdConvChan_Step
        '
        Me.grdConvChan_Step.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdConvChan_Step.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdConvChan_Step.HeaderText = "Step"
        Me.grdConvChan_Step.Name = "grdConvChan_Step"
        Me.grdConvChan_Step.Width = 60
        '
        'grdCOnvChan_MOD
        '
        Me.grdCOnvChan_MOD.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdCOnvChan_MOD.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdCOnvChan_MOD.HeaderText = "Mod"
        Me.grdCOnvChan_MOD.Name = "grdCOnvChan_MOD"
        Me.grdCOnvChan_MOD.Width = 55
        '
        'grdConvChan_NAC
        '
        Me.grdConvChan_NAC.HeaderText = "NAC"
        Me.grdConvChan_NAC.MaxInputLength = 4
        Me.grdConvChan_NAC.Name = "grdConvChan_NAC"
        Me.grdConvChan_NAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdConvChan_NAC.Width = 60
        '
        'grdConvChan_AudioType
        '
        Me.grdConvChan_AudioType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdConvChan_AudioType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdConvChan_AudioType.HeaderText = "AudioType"
        Me.grdConvChan_AudioType.Name = "grdConvChan_AudioType"
        Me.grdConvChan_AudioType.Width = 75
        '
        'grdConvChan_AltTone
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.grdConvChan_AltTone.DefaultCellStyle = DataGridViewCellStyle5
        Me.grdConvChan_AltTone.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdConvChan_AltTone.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdConvChan_AltTone.HeaderText = "Alt Tone"
        Me.grdConvChan_AltTone.Name = "grdConvChan_AltTone"
        Me.grdConvChan_AltTone.Width = 60
        '
        'grdConvChan_AltLevel
        '
        Me.grdConvChan_AltLevel.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdConvChan_AltLevel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdConvChan_AltLevel.HeaderText = "Alt Level"
        Me.grdConvChan_AltLevel.Name = "grdConvChan_AltLevel"
        Me.grdConvChan_AltLevel.ToolTipText = "Alert tone volume level. 0 = Auto"
        Me.grdConvChan_AltLevel.Width = 60
        '
        'grdConvChan_AltColor
        '
        Me.grdConvChan_AltColor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdConvChan_AltColor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdConvChan_AltColor.HeaderText = "Alt Color"
        Me.grdConvChan_AltColor.Name = "grdConvChan_AltColor"
        Me.grdConvChan_AltColor.Width = 60
        '
        'grdConvChan_AltPattern
        '
        Me.grdConvChan_AltPattern.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdConvChan_AltPattern.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdConvChan_AltPattern.HeaderText = "Alt Pat"
        Me.grdConvChan_AltPattern.Name = "grdConvChan_AltPattern"
        Me.grdConvChan_AltPattern.Width = 60
        '
        'grdConvChan_VolOffset
        '
        Me.grdConvChan_VolOffset.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.grdConvChan_VolOffset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grdConvChan_VolOffset.HeaderText = "Vol Adj"
        Me.grdConvChan_VolOffset.Name = "grdConvChan_VolOffset"
        Me.grdConvChan_VolOffset.Width = 60
        '
        'grdConvChan_NumTag
        '
        Me.grdConvChan_NumTag.HeaderText = "Num Tag"
        Me.grdConvChan_NumTag.MaxInputLength = 4
        Me.grdConvChan_NumTag.Name = "grdConvChan_NumTag"
        Me.grdConvChan_NumTag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdConvChan_NumTag.Width = 65
        '
        'grdConvChan_RecOut
        '
        Me.grdConvChan_RecOut.HeaderText = "Rec Out"
        Me.grdConvChan_RecOut.Name = "grdConvChan_RecOut"
        Me.grdConvChan_RecOut.Width = 60
        '
        'grdConvChan_Comment
        '
        Me.grdConvChan_Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.grdConvChan_Comment.HeaderText = "Comment"
        Me.grdConvChan_Comment.MaxInputLength = 255
        Me.grdConvChan_Comment.MinimumWidth = 100
        Me.grdConvChan_Comment.Name = "grdConvChan_Comment"
        Me.grdConvChan_Comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'txtConvGroupName
        '
        Me.txtConvGroupName.AcceptsReturn = True
        Me.txtConvGroupName.BackColor = System.Drawing.SystemColors.Window
        Me.txtConvGroupName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConvGroupName.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConvGroupName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConvGroupName.Location = New System.Drawing.Point(11, 35)
        Me.txtConvGroupName.MaxLength = 16
        Me.txtConvGroupName.Name = "txtConvGroupName"
        Me.txtConvGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConvGroupName.Size = New System.Drawing.Size(169, 18)
        Me.txtConvGroupName.TabIndex = 225
        '
        'chkConvGroupLockout
        '
        Me.chkConvGroupLockout.BackColor = System.Drawing.SystemColors.Control
        Me.chkConvGroupLockout.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkConvGroupLockout.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConvGroupLockout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkConvGroupLockout.Location = New System.Drawing.Point(347, 35)
        Me.chkConvGroupLockout.Name = "chkConvGroupLockout"
        Me.chkConvGroupLockout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkConvGroupLockout.Size = New System.Drawing.Size(89, 21)
        Me.chkConvGroupLockout.TabIndex = 231
        Me.chkConvGroupLockout.Text = "Locked Out"
        Me.chkConvGroupLockout.UseVisualStyleBackColor = True
        '
        '_Label28_37
        '
        Me._Label28_37.AutoSize = True
        Me._Label28_37.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_37, CType(37, Short))
        Me._Label28_37.Location = New System.Drawing.Point(11, 21)
        Me._Label28_37.Name = "_Label28_37"
        Me._Label28_37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_37.Size = New System.Drawing.Size(245, 14)
        Me._Label28_37.TabIndex = 114
        Me._Label28_37.Text = "Name                                                      Quick Key"
        '
        'cmdConvGrab
        '
        Me.cmdConvGrab.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvGrab.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConvGrab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvGrab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConvGrab.Location = New System.Drawing.Point(360, 89)
        Me.cmdConvGrab.Name = "cmdConvGrab"
        Me.cmdConvGrab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConvGrab.Size = New System.Drawing.Size(97, 25)
        Me.cmdConvGrab.TabIndex = 240
        Me.cmdConvGrab.Text = "E&Z-Grab!"
        Me.cmdConvGrab.UseVisualStyleBackColor = True
        '
        'cmdCnvPicPick
        '
        Me.cmdCnvPicPick.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCnvPicPick.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCnvPicPick.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCnvPicPick.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCnvPicPick.Location = New System.Drawing.Point(565, 471)
        Me.cmdCnvPicPick.Name = "cmdCnvPicPick"
        Me.cmdCnvPicPick.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCnvPicPick.Size = New System.Drawing.Size(19, 17)
        Me.cmdCnvPicPick.TabIndex = 230
        Me.cmdCnvPicPick.Text = "..."
        Me.cmdCnvPicPick.UseVisualStyleBackColor = True
        Me.cmdCnvPicPick.Visible = False
        '
        '_Label28_41
        '
        Me._Label28_41.BackColor = System.Drawing.SystemColors.Control
        Me._Label28_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label28_41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label28_41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.SetIndex(Me._Label28_41, CType(41, Short))
        Me._Label28_41.Location = New System.Drawing.Point(496, 489)
        Me._Label28_41.Name = "_Label28_41"
        Me._Label28_41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label28_41.Size = New System.Drawing.Size(92, 40)
        Me._Label28_41.TabIndex = 249
        Me._Label28_41.Text = "(Filename)"
        Me._Label28_41.Visible = False
        '
        'StatusBar
        '
        Me.StatusBar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._StatusBar_Panel1, Me._StatusBar_Panel2})
        Me.StatusBar.Location = New System.Drawing.Point(0, 721)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(837, 25)
        Me.StatusBar.TabIndex = 42
        '
        '_StatusBar_Panel1
        '
        Me._StatusBar_Panel1.AutoSize = False
        Me._StatusBar_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar_Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar_Panel1.Name = "_StatusBar_Panel1"
        Me._StatusBar_Panel1.Size = New System.Drawing.Size(516, 25)
        Me._StatusBar_Panel1.Spring = True
        Me._StatusBar_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_StatusBar_Panel2
        '
        Me._StatusBar_Panel2.AutoSize = False
        Me._StatusBar_Panel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar_Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar_Panel2.Name = "_StatusBar_Panel2"
        Me._StatusBar_Panel2.Size = New System.Drawing.Size(306, 25)
        Me._StatusBar_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'treeSystems
        '
        Me.treeSystems.AllowDrop = True
        Me.treeSystems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeSystems.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeSystems.HideSelection = False
        Me.treeSystems.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.treeSystems.Indent = 21
        Me.treeSystems.Location = New System.Drawing.Point(0, -2)
        Me.treeSystems.Name = "treeSystems"
        Me.treeSystems.Size = New System.Drawing.Size(164, 664)
        Me.treeSystems.TabIndex = 0
        '
        'mnuPopUpCon
        '
        Me.mnuPopUpCon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPopUpCon_ObjName, Me.mnuPopUpCon_Sep1, Me.mnuPopUpCon_NewSys, Me.mnuPopUpCon_NewSite, Me.mnuPopUpCon_NewGroup, Me.mnuPopUpCon_Sep2, Me.mnuPopUpCon_Cut, Me.mnuPopUpCon_Copy, Me.mnuPopUpCon_Paste, Me.mnuPopUpCon_Delete})
        Me.mnuPopUpCon.Name = "mnuPopUpCon"
        Me.mnuPopUpCon.Size = New System.Drawing.Size(140, 192)
        '
        'mnuPopUpCon_ObjName
        '
        Me.mnuPopUpCon_ObjName.Name = "mnuPopUpCon_ObjName"
        Me.mnuPopUpCon_ObjName.Size = New System.Drawing.Size(139, 22)
        Me.mnuPopUpCon_ObjName.Text = "ObjName"
        '
        'mnuPopUpCon_Sep1
        '
        Me.mnuPopUpCon_Sep1.Name = "mnuPopUpCon_Sep1"
        Me.mnuPopUpCon_Sep1.Size = New System.Drawing.Size(136, 6)
        '
        'mnuPopUpCon_NewSys
        '
        Me.mnuPopUpCon_NewSys.Name = "mnuPopUpCon_NewSys"
        Me.mnuPopUpCon_NewSys.Size = New System.Drawing.Size(139, 22)
        Me.mnuPopUpCon_NewSys.Text = "New System"
        '
        'mnuPopUpCon_NewSite
        '
        Me.mnuPopUpCon_NewSite.Name = "mnuPopUpCon_NewSite"
        Me.mnuPopUpCon_NewSite.Size = New System.Drawing.Size(139, 22)
        Me.mnuPopUpCon_NewSite.Text = "New Site"
        '
        'mnuPopUpCon_NewGroup
        '
        Me.mnuPopUpCon_NewGroup.Name = "mnuPopUpCon_NewGroup"
        Me.mnuPopUpCon_NewGroup.Size = New System.Drawing.Size(139, 22)
        Me.mnuPopUpCon_NewGroup.Text = "New Group"
        '
        'mnuPopUpCon_Sep2
        '
        Me.mnuPopUpCon_Sep2.Name = "mnuPopUpCon_Sep2"
        Me.mnuPopUpCon_Sep2.Size = New System.Drawing.Size(136, 6)
        '
        'mnuPopUpCon_Cut
        '
        Me.mnuPopUpCon_Cut.Name = "mnuPopUpCon_Cut"
        Me.mnuPopUpCon_Cut.Size = New System.Drawing.Size(139, 22)
        Me.mnuPopUpCon_Cut.Text = "Cut"
        '
        'mnuPopUpCon_Copy
        '
        Me.mnuPopUpCon_Copy.Name = "mnuPopUpCon_Copy"
        Me.mnuPopUpCon_Copy.Size = New System.Drawing.Size(139, 22)
        Me.mnuPopUpCon_Copy.Text = "Copy"
        '
        'mnuPopUpCon_Paste
        '
        Me.mnuPopUpCon_Paste.Name = "mnuPopUpCon_Paste"
        Me.mnuPopUpCon_Paste.Size = New System.Drawing.Size(139, 22)
        Me.mnuPopUpCon_Paste.Text = "Paste"
        '
        'mnuPopUpCon_Delete
        '
        Me.mnuPopUpCon_Delete.Name = "mnuPopUpCon_Delete"
        Me.mnuPopUpCon_Delete.Size = New System.Drawing.Size(139, 22)
        Me.mnuPopUpCon_Delete.Text = "Delete..."
        '
        'imgNull
        '
        Me.imgNull.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgNull.Location = New System.Drawing.Point(240, 514)
        Me.imgNull.Name = "imgNull"
        Me.imgNull.Size = New System.Drawing.Size(28, 22)
        Me.imgNull.TabIndex = 219
        Me.imgNull.TabStop = False
        Me.imgNull.Visible = False
        '
        'imgLock
        '
        Me.imgLock.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgLock.Image = CType(resources.GetObject("imgLock.Image"), System.Drawing.Image)
        Me.imgLock.Location = New System.Drawing.Point(244, 478)
        Me.imgLock.Name = "imgLock"
        Me.imgLock.Size = New System.Drawing.Size(17, 19)
        Me.imgLock.TabIndex = 220
        Me.imgLock.TabStop = False
        Me.imgLock.Visible = False
        '
        'chkQGLCnv
        '
        '
        'chkQGLTrn
        '
        '
        'cmbAPCO
        '
        '
        'cmdFreeGQK
        '
        '
        'cmdJust
        '
        '
        'cmdJustCnvGrp
        '
        '
        'cmdJustCnvSys
        '
        '
        'cmdJustTGID
        '
        '
        'cmdJustTGIDChan
        '
        '
        'cmdJustTrnSite
        '
        '
        'cmdJustTrnSys
        '
        '
        'cmdToolBar
        '
        '
        'mnuFavArray
        '
        '
        '_mnuFavArray_0
        '
        Me.mnuFavArray.SetIndex(Me._mnuFavArray_0, CType(0, Short))
        Me._mnuFavArray_0.Name = "_mnuFavArray_0"
        Me._mnuFavArray_0.Size = New System.Drawing.Size(206, 22)
        Me._mnuFavArray_0.Text = "(Blank)"
        Me._mnuFavArray_0.Visible = False
        '
        'mnuLastFile
        '
        '
        '_mnuLastFile_0
        '
        Me.mnuLastFile.SetIndex(Me._mnuLastFile_0, CType(0, Short))
        Me._mnuLastFile_0.Name = "_mnuLastFile_0"
        Me._mnuLastFile_0.Size = New System.Drawing.Size(155, 22)
        Me._mnuLastFile_0.Text = "&1"
        Me._mnuLastFile_0.Visible = False
        '
        '_mnuLastFile_1
        '
        Me.mnuLastFile.SetIndex(Me._mnuLastFile_1, CType(1, Short))
        Me._mnuLastFile_1.Name = "_mnuLastFile_1"
        Me._mnuLastFile_1.Size = New System.Drawing.Size(155, 22)
        Me._mnuLastFile_1.Text = "&2"
        Me._mnuLastFile_1.Visible = False
        '
        '_mnuLastFile_2
        '
        Me.mnuLastFile.SetIndex(Me._mnuLastFile_2, CType(2, Short))
        Me._mnuLastFile_2.Name = "_mnuLastFile_2"
        Me._mnuLastFile_2.Size = New System.Drawing.Size(155, 22)
        Me._mnuLastFile_2.Text = "&3"
        Me._mnuLastFile_2.Visible = False
        '
        '_mnuLastFile_3
        '
        Me.mnuLastFile.SetIndex(Me._mnuLastFile_3, CType(3, Short))
        Me._mnuLastFile_3.Name = "_mnuLastFile_3"
        Me._mnuLastFile_3.Size = New System.Drawing.Size(155, 22)
        Me._mnuLastFile_3.Text = "&4"
        Me._mnuLastFile_3.Visible = False
        '
        'mnuPopSel
        '
        '
        'optConvTapeOut
        '
        '
        'optTrnRecord
        '
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuProgramming, Me.ActionToolStripMenuItem, Me.mnuScanner, Me.mnuTools, Me.mnuTree, Me.mnuFav, Me.mnHelp})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(837, 24)
        Me.MainMenu1.TabIndex = 221
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuImport, Me.mnuExport, Me.mnuShowStat, Me.Sep11, Me.mnuFilePrint, Me.Sep12, Me._mnuLastFile_0, Me._mnuLastFile_1, Me._mnuLastFile_2, Me._mnuLastFile_3, Me.mnuSep2, Me.mnuExitSaveChanges})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Image = CType(resources.GetObject("mnuFileNew.Image"), System.Drawing.Image)
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(155, 22)
        Me.mnuFileNew.Text = "New..."
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Image = CType(resources.GetObject("mnuFileOpen.Image"), System.Drawing.Image)
        Me.mnuFileOpen.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(155, 22)
        Me.mnuFileOpen.Text = "Ope&n..."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Image = CType(resources.GetObject("mnuFileSave.Image"), System.Drawing.Image)
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(155, 22)
        Me.mnuFileSave.Text = "Sa&ve"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Image = CType(resources.GetObject("mnuFileSaveAs.Image"), System.Drawing.Image)
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(155, 22)
        Me.mnuFileSaveAs.Text = "Save &As..."
        '
        'mnuImport
        '
        Me.mnuImport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuImportFreeSCAN, Me.mnuImportMEM, Me.mnuImportUASD, Me.mnuImportRadRefConv, Me.mnuImportRadRefTrunk})
        Me.mnuImport.Name = "mnuImport"
        Me.mnuImport.Size = New System.Drawing.Size(155, 22)
        Me.mnuImport.Text = "&Import..."
        '
        'mnuImportFreeSCAN
        '
        Me.mnuImportFreeSCAN.Name = "mnuImportFreeSCAN"
        Me.mnuImportFreeSCAN.Size = New System.Drawing.Size(239, 22)
        Me.mnuImportFreeSCAN.Text = "From Fr&eeSCAN..."
        '
        'mnuImportMEM
        '
        Me.mnuImportMEM.Image = CType(resources.GetObject("mnuImportMEM.Image"), System.Drawing.Image)
        Me.mnuImportMEM.Name = "mnuImportMEM"
        Me.mnuImportMEM.Size = New System.Drawing.Size(239, 22)
        Me.mnuImportMEM.Text = "From .&MEM /.m96..."
        '
        'mnuImportUASD
        '
        Me.mnuImportUASD.Image = CType(resources.GetObject("mnuImportUASD.Image"), System.Drawing.Image)
        Me.mnuImportUASD.Name = "mnuImportUASD"
        Me.mnuImportUASD.Size = New System.Drawing.Size(239, 22)
        Me.mnuImportUASD.Text = "From UAS&D..."
        '
        'mnuImportRadRefConv
        '
        Me.mnuImportRadRefConv.Image = CType(resources.GetObject("mnuImportRadRefConv.Image"), System.Drawing.Image)
        Me.mnuImportRadRefConv.Name = "mnuImportRadRefConv"
        Me.mnuImportRadRefConv.Size = New System.Drawing.Size(239, 22)
        Me.mnuImportRadRefConv.Text = "RadioReference &Conventional..."
        '
        'mnuImportRadRefTrunk
        '
        Me.mnuImportRadRefTrunk.Image = CType(resources.GetObject("mnuImportRadRefTrunk.Image"), System.Drawing.Image)
        Me.mnuImportRadRefTrunk.Name = "mnuImportRadRefTrunk"
        Me.mnuImportRadRefTrunk.Size = New System.Drawing.Size(239, 22)
        Me.mnuImportRadRefTrunk.Text = "RadioReference &Trunked..."
        '
        'mnuExport
        '
        Me.mnuExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExportSngSys, Me.mnuExportAllSys})
        Me.mnuExport.Name = "mnuExport"
        Me.mnuExport.Size = New System.Drawing.Size(155, 22)
        Me.mnuExport.Text = "E&xport CSV"
        '
        'mnuExportSngSys
        '
        Me.mnuExportSngSys.Name = "mnuExportSngSys"
        Me.mnuExportSngSys.Size = New System.Drawing.Size(146, 22)
        Me.mnuExportSngSys.Text = "This System..."
        '
        'mnuExportAllSys
        '
        Me.mnuExportAllSys.Name = "mnuExportAllSys"
        Me.mnuExportAllSys.Size = New System.Drawing.Size(146, 22)
        Me.mnuExportAllSys.Text = "A&ll Systems..."
        '
        'mnuShowStat
        '
        Me.mnuShowStat.Name = "mnuShowStat"
        Me.mnuShowStat.Size = New System.Drawing.Size(155, 22)
        Me.mnuShowStat.Text = "Statistics...."
        '
        'Sep11
        '
        Me.Sep11.Name = "Sep11"
        Me.Sep11.Size = New System.Drawing.Size(152, 6)
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Image = CType(resources.GetObject("mnuFilePrint.Image"), System.Drawing.Image)
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuFilePrint.Size = New System.Drawing.Size(155, 22)
        Me.mnuFilePrint.Text = "Print..."
        '
        'Sep12
        '
        Me.Sep12.Name = "Sep12"
        Me.Sep12.Size = New System.Drawing.Size(152, 6)
        '
        'mnuSep2
        '
        Me.mnuSep2.Name = "mnuSep2"
        Me.mnuSep2.Size = New System.Drawing.Size(152, 6)
        '
        'mnuExitSaveChanges
        '
        Me.mnuExitSaveChanges.Name = "mnuExitSaveChanges"
        Me.mnuExitSaveChanges.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuExitSaveChanges.Size = New System.Drawing.Size(155, 22)
        Me.mnuExitSaveChanges.Text = "&Quit"
        '
        'mnuProgramming
        '
        Me.mnuProgramming.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDeleteSystem, Me._Sep7_0, Me.mnuCutChannel, Me.mnuPasteChannel, Me.mnuCopyChannel, Me.mnuEditSelectAll, Me.sep3, Me.mnuEditJustChan, Me.mnuSort, Me.mnuSep3, Me.mnuFind, Me.PreferencesToolStripMenuItem})
        Me.mnuProgramming.Name = "mnuProgramming"
        Me.mnuProgramming.Size = New System.Drawing.Size(39, 20)
        Me.mnuProgramming.Text = "Ed&it"
        '
        'mnuDeleteSystem
        '
        Me.mnuDeleteSystem.Image = CType(resources.GetObject("mnuDeleteSystem.Image"), System.Drawing.Image)
        Me.mnuDeleteSystem.Name = "mnuDeleteSystem"
        Me.mnuDeleteSystem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.mnuDeleteSystem.Size = New System.Drawing.Size(241, 22)
        Me.mnuDeleteSystem.Text = "&Delete"
        '
        '_Sep7_0
        '
        Me._Sep7_0.Name = "_Sep7_0"
        Me._Sep7_0.Size = New System.Drawing.Size(238, 6)
        '
        'mnuCutChannel
        '
        Me.mnuCutChannel.Image = CType(resources.GetObject("mnuCutChannel.Image"), System.Drawing.Image)
        Me.mnuCutChannel.Name = "mnuCutChannel"
        Me.mnuCutChannel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCutChannel.Size = New System.Drawing.Size(241, 22)
        Me.mnuCutChannel.Text = "Cut"
        '
        'mnuPasteChannel
        '
        Me.mnuPasteChannel.Image = CType(resources.GetObject("mnuPasteChannel.Image"), System.Drawing.Image)
        Me.mnuPasteChannel.Name = "mnuPasteChannel"
        Me.mnuPasteChannel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPasteChannel.Size = New System.Drawing.Size(241, 22)
        Me.mnuPasteChannel.Text = "Paste"
        '
        'mnuCopyChannel
        '
        Me.mnuCopyChannel.Image = CType(resources.GetObject("mnuCopyChannel.Image"), System.Drawing.Image)
        Me.mnuCopyChannel.Name = "mnuCopyChannel"
        Me.mnuCopyChannel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopyChannel.Size = New System.Drawing.Size(241, 22)
        Me.mnuCopyChannel.Text = "Copy"
        '
        'mnuEditSelectAll
        '
        Me.mnuEditSelectAll.Name = "mnuEditSelectAll"
        Me.mnuEditSelectAll.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuEditSelectAll.Size = New System.Drawing.Size(241, 22)
        Me.mnuEditSelectAll.Text = "Select &All"
        '
        'sep3
        '
        Me.sep3.Name = "sep3"
        Me.sep3.Size = New System.Drawing.Size(238, 6)
        '
        'mnuEditJustChan
        '
        Me.mnuEditJustChan.Image = CType(resources.GetObject("mnuEditJustChan.Image"), System.Drawing.Image)
        Me.mnuEditJustChan.Name = "mnuEditJustChan"
        Me.mnuEditJustChan.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.mnuEditJustChan.Size = New System.Drawing.Size(241, 22)
        Me.mnuEditJustChan.Text = "Justify Channel Names..."
        '
        'mnuSort
        '
        Me.mnuSort.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSortByName, Me.mnuSortByFreq})
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(241, 22)
        Me.mnuSort.Text = "Sort"
        '
        'mnuSortByName
        '
        Me.mnuSortByName.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSortByNameAscending, Me.mnuSortByNameDescending})
        Me.mnuSortByName.Name = "mnuSortByName"
        Me.mnuSortByName.Size = New System.Drawing.Size(175, 22)
        Me.mnuSortByName.Text = "By Name"
        '
        'mnuSortByNameAscending
        '
        Me.mnuSortByNameAscending.Image = CType(resources.GetObject("mnuSortByNameAscending.Image"), System.Drawing.Image)
        Me.mnuSortByNameAscending.Name = "mnuSortByNameAscending"
        Me.mnuSortByNameAscending.Size = New System.Drawing.Size(136, 22)
        Me.mnuSortByNameAscending.Text = "Ascending"
        '
        'mnuSortByNameDescending
        '
        Me.mnuSortByNameDescending.Image = CType(resources.GetObject("mnuSortByNameDescending.Image"), System.Drawing.Image)
        Me.mnuSortByNameDescending.Name = "mnuSortByNameDescending"
        Me.mnuSortByNameDescending.Size = New System.Drawing.Size(136, 22)
        Me.mnuSortByNameDescending.Text = "Descending"
        '
        'mnuSortByFreq
        '
        Me.mnuSortByFreq.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSortByFreqAscending, Me.mnuSortByFreqDescending})
        Me.mnuSortByFreq.Name = "mnuSortByFreq"
        Me.mnuSortByFreq.Size = New System.Drawing.Size(175, 22)
        Me.mnuSortByFreq.Text = "By Frequency/TGID"
        '
        'mnuSortByFreqAscending
        '
        Me.mnuSortByFreqAscending.Name = "mnuSortByFreqAscending"
        Me.mnuSortByFreqAscending.Size = New System.Drawing.Size(136, 22)
        Me.mnuSortByFreqAscending.Text = "Ascending"
        '
        'mnuSortByFreqDescending
        '
        Me.mnuSortByFreqDescending.Name = "mnuSortByFreqDescending"
        Me.mnuSortByFreqDescending.Size = New System.Drawing.Size(136, 22)
        Me.mnuSortByFreqDescending.Text = "Descending"
        '
        'mnuSep3
        '
        Me.mnuSep3.Name = "mnuSep3"
        Me.mnuSep3.Size = New System.Drawing.Size(238, 6)
        '
        'mnuFind
        '
        Me.mnuFind.Image = CType(resources.GetObject("mnuFind.Image"), System.Drawing.Image)
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFind.Size = New System.Drawing.Size(241, 22)
        Me.mnuFind.Text = "F&ind..."
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences..."
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSystemToolStripMenuItem, Me.NewSiteToolStripMenuItem, Me.NewGroupToolStripMenuItem, Me.InsertChannelToolStripMenuItem, Me.DeleteChannelToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ActionToolStripMenuItem.Text = "Act&ion"
        Me.ActionToolStripMenuItem.Visible = False
        '
        'NewSystemToolStripMenuItem
        '
        Me.NewSystemToolStripMenuItem.Name = "NewSystemToolStripMenuItem"
        Me.NewSystemToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.NewSystemToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.NewSystemToolStripMenuItem.Text = "New System"
        '
        'NewSiteToolStripMenuItem
        '
        Me.NewSiteToolStripMenuItem.Name = "NewSiteToolStripMenuItem"
        Me.NewSiteToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.NewSiteToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.NewSiteToolStripMenuItem.Text = "New Site"
        '
        'NewGroupToolStripMenuItem
        '
        Me.NewGroupToolStripMenuItem.Name = "NewGroupToolStripMenuItem"
        Me.NewGroupToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.NewGroupToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.NewGroupToolStripMenuItem.Text = "New Group"
        '
        'InsertChannelToolStripMenuItem
        '
        Me.InsertChannelToolStripMenuItem.Name = "InsertChannelToolStripMenuItem"
        Me.InsertChannelToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.InsertChannelToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.InsertChannelToolStripMenuItem.Text = "Insert Channel"
        '
        'DeleteChannelToolStripMenuItem
        '
        Me.DeleteChannelToolStripMenuItem.Name = "DeleteChannelToolStripMenuItem"
        Me.DeleteChannelToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteChannelToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.DeleteChannelToolStripMenuItem.Text = "Delete Channel"
        '
        'mnuScanner
        '
        Me.mnuScanner.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsUL, Me.mnuToolsDL, Me.mnuToolsControl, Me.mnuToolsSetup, Me.BandplanToolStripMenuItem})
        Me.mnuScanner.Name = "mnuScanner"
        Me.mnuScanner.Size = New System.Drawing.Size(61, 20)
        Me.mnuScanner.Text = "Scann&er"
        '
        'mnuToolsUL
        '
        Me.mnuToolsUL.Name = "mnuToolsUL"
        Me.mnuToolsUL.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuToolsUL.Size = New System.Drawing.Size(256, 22)
        Me.mnuToolsUL.Text = "U&pload Programming..."
        '
        'mnuToolsDL
        '
        Me.mnuToolsDL.Name = "mnuToolsDL"
        Me.mnuToolsDL.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuToolsDL.Size = New System.Drawing.Size(256, 22)
        Me.mnuToolsDL.Text = "&Download Programming..."
        '
        'mnuToolsControl
        '
        Me.mnuToolsControl.Name = "mnuToolsControl"
        Me.mnuToolsControl.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mnuToolsControl.Size = New System.Drawing.Size(256, 22)
        Me.mnuToolsControl.Text = "&Control Scanner"
        '
        'mnuToolsSetup
        '
        Me.mnuToolsSetup.Image = CType(resources.GetObject("mnuToolsSetup.Image"), System.Drawing.Image)
        Me.mnuToolsSetup.Name = "mnuToolsSetup"
        Me.mnuToolsSetup.Size = New System.Drawing.Size(256, 22)
        Me.mnuToolsSetup.Text = "Set&up Scanner Options..."
        '
        'BandplanToolStripMenuItem
        '
        Me.BandplanToolStripMenuItem.Name = "BandplanToolStripMenuItem"
        Me.BandplanToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.BandplanToolStripMenuItem.Text = "Open Band Plan Editor..."
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditSysQK, Me.mnuEditFreqFill, Me.mnuToolsAutoOpt, Me.mnuDupFind, Me.mnuToolsChanLockout, Me.mnuToolsScanner, Me.mnuLockoutAll, Me.mnuUnlockAll, Me.LetsDoItToolStripMenuItem})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(47, 20)
        Me.mnuTools.Text = "&Tools"
        '
        'mnuEditSysQK
        '
        Me.mnuEditSysQK.Name = "mnuEditSysQK"
        Me.mnuEditSysQK.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.mnuEditSysQK.Size = New System.Drawing.Size(268, 22)
        Me.mnuEditSysQK.Text = "S&ystem Quick Key Manager..."
        '
        'mnuEditFreqFill
        '
        Me.mnuEditFreqFill.Name = "mnuEditFreqFill"
        Me.mnuEditFreqFill.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuEditFreqFill.Size = New System.Drawing.Size(268, 22)
        Me.mnuEditFreqFill.Text = "F&requency Fill..."
        '
        'mnuToolsAutoOpt
        '
        Me.mnuToolsAutoOpt.Image = CType(resources.GetObject("mnuToolsAutoOpt.Image"), System.Drawing.Image)
        Me.mnuToolsAutoOpt.Name = "mnuToolsAutoOpt"
        Me.mnuToolsAutoOpt.Size = New System.Drawing.Size(268, 22)
        Me.mnuToolsAutoOpt.Text = "A&utomatic Scanner Optimizer..."
        '
        'mnuDupFind
        '
        Me.mnuDupFind.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFindDupSystem, Me.mnuFindDupGlobal, Me.mnuFindDupGlobalTGID})
        Me.mnuDupFind.Name = "mnuDupFind"
        Me.mnuDupFind.Size = New System.Drawing.Size(268, 22)
        Me.mnuDupFind.Text = "Duplicate Channel Finder"
        '
        'mnuFindDupSystem
        '
        Me.mnuFindDupSystem.Name = "mnuFindDupSystem"
        Me.mnuFindDupSystem.Size = New System.Drawing.Size(233, 22)
        Me.mnuFindDupSystem.Text = "&In this system..."
        '
        'mnuFindDupGlobal
        '
        Me.mnuFindDupGlobal.Name = "mnuFindDupGlobal"
        Me.mnuFindDupGlobal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.mnuFindDupGlobal.Size = New System.Drawing.Size(233, 22)
        Me.mnuFindDupGlobal.Text = "&Global Conventional..."
        '
        'mnuFindDupGlobalTGID
        '
        Me.mnuFindDupGlobalTGID.Name = "mnuFindDupGlobalTGID"
        Me.mnuFindDupGlobalTGID.Size = New System.Drawing.Size(233, 22)
        Me.mnuFindDupGlobalTGID.Text = "Glo&bal TGID..."
        '
        'mnuToolsChanLockout
        '
        Me.mnuToolsChanLockout.Image = CType(resources.GetObject("mnuToolsChanLockout.Image"), System.Drawing.Image)
        Me.mnuToolsChanLockout.Name = "mnuToolsChanLockout"
        Me.mnuToolsChanLockout.Size = New System.Drawing.Size(268, 22)
        Me.mnuToolsChanLockout.Text = "Chan&nel Lockout Manager..."
        '
        'mnuToolsScanner
        '
        Me.mnuToolsScanner.Name = "mnuToolsScanner"
        Me.mnuToolsScanner.Size = New System.Drawing.Size(265, 6)
        '
        'mnuLockoutAll
        '
        Me.mnuLockoutAll.Image = CType(resources.GetObject("mnuLockoutAll.Image"), System.Drawing.Image)
        Me.mnuLockoutAll.Name = "mnuLockoutAll"
        Me.mnuLockoutAll.Size = New System.Drawing.Size(268, 22)
        Me.mnuLockoutAll.Text = "&Lock System/Sites"
        '
        'mnuUnlockAll
        '
        Me.mnuUnlockAll.Image = CType(resources.GetObject("mnuUnlockAll.Image"), System.Drawing.Image)
        Me.mnuUnlockAll.Name = "mnuUnlockAll"
        Me.mnuUnlockAll.Size = New System.Drawing.Size(268, 22)
        Me.mnuUnlockAll.Text = "&Unlock System/Sites"
        '
        'LetsDoItToolStripMenuItem
        '
        Me.LetsDoItToolStripMenuItem.Name = "LetsDoItToolStripMenuItem"
        Me.LetsDoItToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.LetsDoItToolStripMenuItem.Text = "GPS System Plotter..."
        '
        'mnuTree
        '
        Me.mnuTree.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHighlight, Me.mnuUseQuickDraw, Me.mnuShowSysType, Me.mnuShowQK, Me.mnuTreeSort})
        Me.mnuTree.Name = "mnuTree"
        Me.mnuTree.Size = New System.Drawing.Size(44, 20)
        Me.mnuTree.Text = "&View"
        '
        'mnuHighlight
        '
        Me.mnuHighlight.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHighlightTrunkSys, Me.mnuHighlightSite, Me.mnuGroupHighlight})
        Me.mnuHighlight.Name = "mnuHighlight"
        Me.mnuHighlight.Size = New System.Drawing.Size(196, 22)
        Me.mnuHighlight.Text = "Highlight"
        '
        'mnuHighlightTrunkSys
        '
        Me.mnuHighlightTrunkSys.Name = "mnuHighlightTrunkSys"
        Me.mnuHighlightTrunkSys.Size = New System.Drawing.Size(182, 22)
        Me.mnuHighlightTrunkSys.Text = "Trunk S&ystems"
        '
        'mnuHighlightSite
        '
        Me.mnuHighlightSite.Name = "mnuHighlightSite"
        Me.mnuHighlightSite.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.mnuHighlightSite.Size = New System.Drawing.Size(182, 22)
        Me.mnuHighlightSite.Text = "&Trunk Sites"
        '
        'mnuGroupHighlight
        '
        Me.mnuGroupHighlight.Name = "mnuGroupHighlight"
        Me.mnuGroupHighlight.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuGroupHighlight.Size = New System.Drawing.Size(182, 22)
        Me.mnuGroupHighlight.Text = "&Talk Groups"
        '
        'mnuUseQuickDraw
        '
        Me.mnuUseQuickDraw.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuQuickDrawOff, Me.mnuQuickDrawOn, Me.mnuQuickDrawAUto})
        Me.mnuUseQuickDraw.Name = "mnuUseQuickDraw"
        Me.mnuUseQuickDraw.Size = New System.Drawing.Size(196, 22)
        Me.mnuUseQuickDraw.Text = "&Auto Expand Systems"
        '
        'mnuQuickDrawOff
        '
        Me.mnuQuickDrawOff.Name = "mnuQuickDrawOff"
        Me.mnuQuickDrawOff.Size = New System.Drawing.Size(100, 22)
        Me.mnuQuickDrawOff.Text = "&On"
        '
        'mnuQuickDrawOn
        '
        Me.mnuQuickDrawOn.Name = "mnuQuickDrawOn"
        Me.mnuQuickDrawOn.Size = New System.Drawing.Size(100, 22)
        Me.mnuQuickDrawOn.Text = "O&ff"
        '
        'mnuQuickDrawAUto
        '
        Me.mnuQuickDrawAUto.Name = "mnuQuickDrawAUto"
        Me.mnuQuickDrawAUto.Size = New System.Drawing.Size(100, 22)
        Me.mnuQuickDrawAUto.Text = "&Auto"
        '
        'mnuShowSysType
        '
        Me.mnuShowSysType.Name = "mnuShowSysType"
        Me.mnuShowSysType.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuShowSysType.Size = New System.Drawing.Size(196, 22)
        Me.mnuShowSysType.Text = "Show System &Types"
        '
        'mnuShowQK
        '
        Me.mnuShowQK.Name = "mnuShowQK"
        Me.mnuShowQK.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.mnuShowQK.Size = New System.Drawing.Size(196, 22)
        Me.mnuShowQK.Text = "Show &Quick Keys"
        '
        'mnuTreeSort
        '
        Me.mnuTreeSort.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTreeSortName, Me.mnuTreeSortQK, Me.mnuTreeSortType, Me.mnuTreeSortNone})
        Me.mnuTreeSort.Name = "mnuTreeSort"
        Me.mnuTreeSort.Size = New System.Drawing.Size(196, 22)
        Me.mnuTreeSort.Text = "S&ort By"
        '
        'mnuTreeSortName
        '
        Me.mnuTreeSortName.Name = "mnuTreeSortName"
        Me.mnuTreeSortName.Size = New System.Drawing.Size(127, 22)
        Me.mnuTreeSortName.Text = "&Name"
        '
        'mnuTreeSortQK
        '
        Me.mnuTreeSortQK.Name = "mnuTreeSortQK"
        Me.mnuTreeSortQK.Size = New System.Drawing.Size(127, 22)
        Me.mnuTreeSortQK.Text = "&Quick Key"
        '
        'mnuTreeSortType
        '
        Me.mnuTreeSortType.Name = "mnuTreeSortType"
        Me.mnuTreeSortType.Size = New System.Drawing.Size(127, 22)
        Me.mnuTreeSortType.Text = "&Type"
        '
        'mnuTreeSortNone
        '
        Me.mnuTreeSortNone.Name = "mnuTreeSortNone"
        Me.mnuTreeSortNone.Size = New System.Drawing.Size(127, 22)
        Me.mnuTreeSortNone.Text = "Unsorted"
        '
        'mnuFav
        '
        Me.mnuFav.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFavAdd, Me.mnuFavOrg, Me.mnuFavSep, Me._mnuFavArray_0})
        Me.mnuFav.Name = "mnuFav"
        Me.mnuFav.Size = New System.Drawing.Size(73, 20)
        Me.mnuFav.Text = "F&avourites"
        Me.mnuFav.Visible = False
        '
        'mnuFavAdd
        '
        Me.mnuFavAdd.Enabled = False
        Me.mnuFavAdd.Name = "mnuFavAdd"
        Me.mnuFavAdd.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.mnuFavAdd.Size = New System.Drawing.Size(206, 22)
        Me.mnuFavAdd.Text = "Add To Favourites"
        '
        'mnuFavOrg
        '
        Me.mnuFavOrg.Enabled = False
        Me.mnuFavOrg.Name = "mnuFavOrg"
        Me.mnuFavOrg.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.mnuFavOrg.Size = New System.Drawing.Size(206, 22)
        Me.mnuFavOrg.Text = "&Organize Favourites..."
        '
        'mnuFavSep
        '
        Me.mnuFavSep.Name = "mnuFavSep"
        Me.mnuFavSep.Size = New System.Drawing.Size(203, 6)
        '
        'mnHelp
        '
        Me.mnHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpOnline, Me.mnuAbout, Me.mnuCheckUpdate})
        Me.mnHelp.Name = "mnHelp"
        Me.mnHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnHelp.Text = "&Help"
        '
        'mnuHelpOnline
        '
        Me.mnuHelpOnline.Image = CType(resources.GetObject("mnuHelpOnline.Image"), System.Drawing.Image)
        Me.mnuHelpOnline.Name = "mnuHelpOnline"
        Me.mnuHelpOnline.Size = New System.Drawing.Size(168, 22)
        Me.mnuHelpOnline.Text = "&Online Help..."
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(168, 22)
        Me.mnuAbout.Text = "A&bout..."
        '
        'mnuCheckUpdate
        '
        Me.mnuCheckUpdate.Image = CType(resources.GetObject("mnuCheckUpdate.Image"), System.Drawing.Image)
        Me.mnuCheckUpdate.Name = "mnuCheckUpdate"
        Me.mnuCheckUpdate.Size = New System.Drawing.Size(168, 22)
        Me.mnuCheckUpdate.Text = "&Check For Update"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProfileFileSaveDlg
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(575, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 19)
        Me.Button1.TabIndex = 222
        Me.Button1.Text = "Debug"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ExportFileDlg
        '
        '
        'mnuCutCopy
        '
        Me.mnuCutCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMoveCut, Me.mnuMoveCopy, Me.ToolStripSeparator1, Me.mnuMoveCancel})
        Me.mnuCutCopy.Name = "mnuPopUpCon"
        Me.mnuCutCopy.Size = New System.Drawing.Size(111, 76)
        '
        'mnuMoveCut
        '
        Me.mnuMoveCut.Name = "mnuMoveCut"
        Me.mnuMoveCut.Size = New System.Drawing.Size(110, 22)
        Me.mnuMoveCut.Text = "M&ove"
        '
        'mnuMoveCopy
        '
        Me.mnuMoveCopy.Name = "mnuMoveCopy"
        Me.mnuMoveCopy.Size = New System.Drawing.Size(110, 22)
        Me.mnuMoveCopy.Text = "Copy"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(107, 6)
        '
        'mnuMoveCancel
        '
        Me.mnuMoveCancel.Name = "mnuMoveCancel"
        Me.mnuMoveCancel.Size = New System.Drawing.Size(110, 22)
        Me.mnuMoveCancel.Text = "C&ancel"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 6)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton1, Me.OpenToolStripButton1, Me.SaveToolStripButton1, Me.PrintToolStripButton1, Me.toolStripSeparator3, Me.NewSysToolStripButton1, Me.NewSiteToolStripButton2, Me.NewGroupToolStripButton3, Me.ToolStripSeparator5, Me.CutToolStripButton1, Me.CopyToolStripButton1, Me.PasteToolStripButton1, Me.toolStripSeparator4, Me.UploadScannerToolStripButton4, Me.DownloadScannerToolStripButton5, Me.ControlScannerToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(837, 25)
        Me.ToolStrip1.TabIndex = 223
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton1
        '
        Me.NewToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton1.Image = CType(resources.GetObject("NewToolStripButton1.Image"), System.Drawing.Image)
        Me.NewToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton1.Name = "NewToolStripButton1"
        Me.NewToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton1.Text = "&New"
        '
        'OpenToolStripButton1
        '
        Me.OpenToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton1.Image = CType(resources.GetObject("OpenToolStripButton1.Image"), System.Drawing.Image)
        Me.OpenToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton1.Name = "OpenToolStripButton1"
        Me.OpenToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton1.Text = "&Open"
        '
        'SaveToolStripButton1
        '
        Me.SaveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton1.Image = CType(resources.GetObject("SaveToolStripButton1.Image"), System.Drawing.Image)
        Me.SaveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton1.Name = "SaveToolStripButton1"
        Me.SaveToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton1.Text = "&Save"
        '
        'PrintToolStripButton1
        '
        Me.PrintToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton1.Image = CType(resources.GetObject("PrintToolStripButton1.Image"), System.Drawing.Image)
        Me.PrintToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton1.Name = "PrintToolStripButton1"
        Me.PrintToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton1.Text = "&Print"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'NewSysToolStripButton1
        '
        Me.NewSysToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewSysToolStripButton1.Image = CType(resources.GetObject("NewSysToolStripButton1.Image"), System.Drawing.Image)
        Me.NewSysToolStripButton1.ImageTransparentColor = System.Drawing.Color.White
        Me.NewSysToolStripButton1.Name = "NewSysToolStripButton1"
        Me.NewSysToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.NewSysToolStripButton1.Text = "Create new system"
        '
        'NewSiteToolStripButton2
        '
        Me.NewSiteToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewSiteToolStripButton2.Image = CType(resources.GetObject("NewSiteToolStripButton2.Image"), System.Drawing.Image)
        Me.NewSiteToolStripButton2.ImageTransparentColor = System.Drawing.Color.White
        Me.NewSiteToolStripButton2.Name = "NewSiteToolStripButton2"
        Me.NewSiteToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.NewSiteToolStripButton2.Text = "Create new site"
        '
        'NewGroupToolStripButton3
        '
        Me.NewGroupToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewGroupToolStripButton3.Image = CType(resources.GetObject("NewGroupToolStripButton3.Image"), System.Drawing.Image)
        Me.NewGroupToolStripButton3.ImageTransparentColor = System.Drawing.Color.White
        Me.NewGroupToolStripButton3.Name = "NewGroupToolStripButton3"
        Me.NewGroupToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.NewGroupToolStripButton3.Text = "Create new group"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton1
        '
        Me.CutToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton1.Image = CType(resources.GetObject("CutToolStripButton1.Image"), System.Drawing.Image)
        Me.CutToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton1.Name = "CutToolStripButton1"
        Me.CutToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton1.Text = "C&ut"
        '
        'CopyToolStripButton1
        '
        Me.CopyToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton1.Image = CType(resources.GetObject("CopyToolStripButton1.Image"), System.Drawing.Image)
        Me.CopyToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton1.Name = "CopyToolStripButton1"
        Me.CopyToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton1.Text = "&Copy"
        '
        'PasteToolStripButton1
        '
        Me.PasteToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton1.Image = CType(resources.GetObject("PasteToolStripButton1.Image"), System.Drawing.Image)
        Me.PasteToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton1.Name = "PasteToolStripButton1"
        Me.PasteToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton1.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'UploadScannerToolStripButton4
        '
        Me.UploadScannerToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UploadScannerToolStripButton4.Image = CType(resources.GetObject("UploadScannerToolStripButton4.Image"), System.Drawing.Image)
        Me.UploadScannerToolStripButton4.ImageTransparentColor = System.Drawing.Color.White
        Me.UploadScannerToolStripButton4.Name = "UploadScannerToolStripButton4"
        Me.UploadScannerToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.UploadScannerToolStripButton4.Text = "Upload to scanner"
        '
        'DownloadScannerToolStripButton5
        '
        Me.DownloadScannerToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DownloadScannerToolStripButton5.Image = CType(resources.GetObject("DownloadScannerToolStripButton5.Image"), System.Drawing.Image)
        Me.DownloadScannerToolStripButton5.ImageTransparentColor = System.Drawing.Color.White
        Me.DownloadScannerToolStripButton5.Name = "DownloadScannerToolStripButton5"
        Me.DownloadScannerToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.DownloadScannerToolStripButton5.Text = "Download from scanner"
        '
        'ControlScannerToolStripButton6
        '
        Me.ControlScannerToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ControlScannerToolStripButton6.Image = CType(resources.GetObject("ControlScannerToolStripButton6.Image"), System.Drawing.Image)
        Me.ControlScannerToolStripButton6.ImageTransparentColor = System.Drawing.Color.White
        Me.ControlScannerToolStripButton6.Name = "ControlScannerToolStripButton6"
        Me.ControlScannerToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ControlScannerToolStripButton6.Text = "Start Virtual Control"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.treeSystems)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.frmFleetMap)
        Me.SplitContainer1.Panel2.Controls.Add(Me._frmSiteOptConv_0)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tabTrunkSite)
        Me.SplitContainer1.Panel2.Controls.Add(Me.frmGroupTrunk)
        Me.SplitContainer1.Panel2.Controls.Add(Me.frmTrunkSys)
        Me.SplitContainer1.Panel2.Controls.Add(Me.frmGroupConv)
        Me.SplitContainer1.Size = New System.Drawing.Size(823, 669)
        Me.SplitContainer1.SplitterDistance = 167
        Me.SplitContainer1.TabIndex = 224
        '
        'lblSiteNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(837, 746)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.imgNull)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.imgLock)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 57)
        Me.Name = "lblSiteNote"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "FreeSCAN"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Me.tabTrunkSite.ResumeLayout(False)
        Me._tabTrunkSite_TabPage0.ResumeLayout(False)
        Me._tabTrunkSite_TabPage0.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        CType(Me.grdReband, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame12.ResumeLayout(False)
        Me.Frame12.PerformLayout()
        Me._tabTrunkSite_TabPage1.ResumeLayout(False)
        CType(Me.grdTrunkFreq, System.ComponentModel.ISupportInitialize).EndInit()
        Me._tabTrunkSite_TabPage2.ResumeLayout(False)
        Me._tabTrunkSite_TabPage2.PerformLayout()
        CType(Me.grdAPCO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmTrunkSys.ResumeLayout(False)
        Me.frmTrunkSys.PerformLayout()
        Me.Frame14.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame8.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me._frmSiteOptConv_0.ResumeLayout(False)
        Me._frmSiteOptConv_0.PerformLayout()
        Me.Frame13.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.frmFleetMap.ResumeLayout(False)
        Me.frmFleetMap.PerformLayout()
        Me.frmGroupTrunk.ResumeLayout(False)
        Me.frmGroupTrunk.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grdTGID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmGroupConv.ResumeLayout(False)
        Me.frmGroupConv.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.grdConvChan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.mnuPopUpCon.ResumeLayout(False)
        CType(Me.imgNull, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sep7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkQGLCnv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkQGLTrn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAPCO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSizeCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFreeGQK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdJust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdJustCnvGrp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdJustCnvSys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdJustTGID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdJustTGIDChan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdJustTrnSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdJustTrnSys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmSiteOptConv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuFavArray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuLastFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuPopSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optConvTapeOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optTrnRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPCOBP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPCOBPStep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.mnuCutCopy.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProfileFileSaveDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents mnuPopUpCon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuPopUpCon_ObjName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopUpCon_NewSys As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopUpCon_NewSite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopUpCon_NewGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopUpCon_Cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopUpCon_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopUpCon_Sep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPopUpCon_Sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPopUpCon_Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopUpCon_Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grdTGID As System.Windows.Forms.DataGridView
    Friend WithEvents grdConvChan As System.Windows.Forms.DataGridView
    Public WithEvents chkSimpleView As System.Windows.Forms.CheckBox
    Public WithEvents chkTGIDSimpleView As System.Windows.Forms.CheckBox
    Friend WithEvents grdTrunkFreq As System.Windows.Forms.DataGridView
    Friend WithEvents ExportFileDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chkTrnAGCD As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrnAGCA As System.Windows.Forms.CheckBox
    Friend WithEvents txtTrnNumTag As System.Windows.Forms.TextBox
    Friend WithEvents txtCnvNumTag As System.Windows.Forms.TextBox
    Friend WithEvents chkCnvAGCD As System.Windows.Forms.CheckBox
    Friend WithEvents chkCnvAGCA As System.Windows.Forms.CheckBox
    Public WithEvents cmbTrnAltCol As System.Windows.Forms.ComboBox
    Public WithEvents cmbTrnAltPat As System.Windows.Forms.ComboBox
    Public WithEvents cmbTrnP25Wait As System.Windows.Forms.ComboBox
    Public WithEvents cmbCnvP25Wait As System.Windows.Forms.ComboBox
    Friend WithEvents grdAPCO As System.Windows.Forms.DataGridView
    Friend WithEvents grdAPCO_Num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdAPCOFreq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdAPCO_Step As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents cmdTGIDGpsEdit As System.Windows.Forms.Button
    Public WithEvents chkTGIDGpsEnabled As System.Windows.Forms.CheckBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents lblTGIDLong As System.Windows.Forms.Label
    Public WithEvents lblTGIDLat As System.Windows.Forms.Label
    Public WithEvents lblTGIDRange As System.Windows.Forms.Label
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents cmdCnvGrpGPSEdit As System.Windows.Forms.Button
    Public WithEvents chkCnvGrpGPS As System.Windows.Forms.CheckBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents lblCnvGrpLong As System.Windows.Forms.Label
    Public WithEvents lblCnvGrpLat As System.Windows.Forms.Label
    Public WithEvents lblCnvGrpRange As System.Windows.Forms.Label
    Public WithEvents cmbTrnSysQK As System.Windows.Forms.ComboBox
    Friend WithEvents mnuCutCopy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuMoveCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoveCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoveCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkTrnSysProtect As System.Windows.Forms.CheckBox
    Friend WithEvents chkCnvSysProtect As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrnPriScan As System.Windows.Forms.CheckBox
    Friend WithEvents mnuTreeSortName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTreeSortQK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTreeSortType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTreeSortNone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHighlightTrunkSys As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BandplanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdReband As System.Windows.Forms.DataGridView
    Friend WithEvents lblSiteNote1 As System.Windows.Forms.Label
    Public WithEvents cmbSiteState As System.Windows.Forms.ComboBox
    Public WithEvents cmbConvState As System.Windows.Forms.ComboBox
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertChannelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteChannelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtP25NacSearch As System.Windows.Forms.TextBox
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewSysToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewSiteToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewGroupToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UploadScannerToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DownloadScannerToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ControlScannerToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdReband_LowFreq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdReband_UpperFreq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdReband_Step As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdReband_Offset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdTrunkFreq_Freq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdTrunkFreq_LCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdTrunkFreq_LO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdTrunkFreq_VolOffset As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdTrunkFreq_NumTag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTGID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTGID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colTGIDPri As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmbTGIDAlertTone As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbTGIDAlertLevel As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdTGID_AltColor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdTGID_AltPat As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdTGID_VolOffset As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbTGIDAudioType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdTGID_NumTag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTapeOut As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtTGIDComment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdConvChan_Display As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdConvChan_Freq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdConvChan_LO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdConvChan_Tone As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdConvChan_ToneLO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdConvChan_Att As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdConvChan_Pri As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdConvChan_Step As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdCOnvChan_MOD As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdConvChan_NAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdConvChan_AudioType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdConvChan_AltTone As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdConvChan_AltLevel As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdConvChan_AltColor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdConvChan_AltPattern As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdConvChan_VolOffset As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdConvChan_NumTag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdConvChan_RecOut As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdConvChan_Comment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnuEditSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LetsDoItToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
#End Region
End Class