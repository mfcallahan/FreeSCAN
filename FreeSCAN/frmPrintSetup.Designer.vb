<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintSetup
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
    Public WithEvents cmdCheckAll As System.Windows.Forms.Button
	Public WithEvents cmdClearAll As System.Windows.Forms.Button
	Public WithEvents cmdCheckSel As System.Windows.Forms.Button
    Public WithEvents cmdRedrawTree As System.Windows.Forms.Button
	Public WithEvents treeSystems As System.Windows.Forms.TreeView
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdPreview As System.Windows.Forms.Button
    Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	Public CommonDialogFont As System.Windows.Forms.FontDialog
	Public CommonDialogPrint As System.Windows.Forms.PrintDialog
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents Label4 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label9 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Line1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Line2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Line3 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents cmbRange As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents lstMargin As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents mnuConvSel As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents mnuTrunkSel As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents optRange As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optSummary As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintSetup))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdResetDefaykt = New System.Windows.Forms.Button()
        Me.cmdSaveDefaultLayout = New System.Windows.Forms.Button()
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkTrunk = New System.Windows.Forms.CheckBox()
        Me.chkPrintSys = New System.Windows.Forms.CheckBox()
        Me.chkPrintSummary = New System.Windows.Forms.CheckBox()
        Me.chkPrintQKSummary = New System.Windows.Forms.CheckBox()
        Me.cmdPrintHTML = New System.Windows.Forms.Button()
        Me.cmdPageSetup = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.cmdCheckAll = New System.Windows.Forms.Button()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.cmdCheckSel = New System.Windows.Forms.Button()
        Me.cmdRedrawTree = New System.Windows.Forms.Button()
        Me.treeSystems = New System.Windows.Forms.TreeView()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.prerender = New System.Windows.Forms.WebBrowser()
        Me.lstTGID = New System.Windows.Forms.CheckedListBox()
        Me.lstConv = New System.Windows.Forms.CheckedListBox()
        Me.cmdRecallDEfault = New System.Windows.Forms.Button()
        Me.cmdFontChoose = New System.Windows.Forms.Button()
        Me.CommonDialogFont = New System.Windows.Forms.FontDialog()
        Me.CommonDialogPrint = New System.Windows.Forms.PrintDialog()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label4 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label9 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Line1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Line2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Line3 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmbRange = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.lstMargin = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.mnuConvSel = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me.mnuTrunkSel = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(Me.components)
        Me.optRange = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optSummary = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstMargin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuConvSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuTrunkSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(10, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(179, 13)
        Label1.TabIndex = 61
        Label1.Text = "Select which fields you want printed."
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(10, 37)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(161, 13)
        Label2.TabIndex = 62
        Label2.Text = "Conventional Channel Properties"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(231, 37)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(83, 13)
        Label5.TabIndex = 63
        Label5.Text = "TGID Properties"
        '
        'cmdResetDefaykt
        '
        Me.cmdResetDefaykt.BackColor = System.Drawing.SystemColors.Control
        Me.cmdResetDefaykt.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdResetDefaykt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResetDefaykt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdResetDefaykt.Location = New System.Drawing.Point(466, 102)
        Me.cmdResetDefaykt.Name = "cmdResetDefaykt"
        Me.cmdResetDefaykt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdResetDefaykt.Size = New System.Drawing.Size(102, 26)
        Me.cmdResetDefaykt.TabIndex = 34
        Me.cmdResetDefaykt.Text = "&Set Automatically"
        Me.ToolTip1.SetToolTip(Me.cmdResetDefaykt, "Choosing this option will reset field & font selection.")
        Me.cmdResetDefaykt.UseVisualStyleBackColor = True
        '
        'cmdSaveDefaultLayout
        '
        Me.cmdSaveDefaultLayout.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveDefaultLayout.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSaveDefaultLayout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveDefaultLayout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSaveDefaultLayout.Location = New System.Drawing.Point(466, 15)
        Me.cmdSaveDefaultLayout.Name = "cmdSaveDefaultLayout"
        Me.cmdSaveDefaultLayout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSaveDefaultLayout.Size = New System.Drawing.Size(101, 26)
        Me.cmdSaveDefaultLayout.TabIndex = 36
        Me.cmdSaveDefaultLayout.Text = "Save as &Default"
        Me.ToolTip1.SetToolTip(Me.cmdSaveDefaultLayout, "Save as default. Next time you load FreeSCAN, the currently selected settings wil" & _
                "l be used.")
        Me.cmdSaveDefaultLayout.UseVisualStyleBackColor = True
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(4, 7)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(593, 443)
        Me.SSTab1.TabIndex = 1
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.Frame1)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(585, 417)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Print"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkTrunk)
        Me.Frame1.Controls.Add(Me.chkPrintSys)
        Me.Frame1.Controls.Add(Me.chkPrintSummary)
        Me.Frame1.Controls.Add(Me.chkPrintQKSummary)
        Me.Frame1.Controls.Add(Me.cmdPrintHTML)
        Me.Frame1.Controls.Add(Me.cmdPageSetup)
        Me.Frame1.Controls.Add(Me.cmdPrint)
        Me.Frame1.Controls.Add(Me.cmdPreview)
        Me.Frame1.Controls.Add(Me.cmdCheckAll)
        Me.Frame1.Controls.Add(Me.cmdClearAll)
        Me.Frame1.Controls.Add(Me.cmdCheckSel)
        Me.Frame1.Controls.Add(Me.cmdRedrawTree)
        Me.Frame1.Controls.Add(Me.treeSystems)
        Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(3, 5)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(577, 398)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Select what you want to print"
        '
        'chkTrunk
        '
        Me.chkTrunk.AutoSize = True
        Me.chkTrunk.Checked = True
        Me.chkTrunk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrunk.Location = New System.Drawing.Point(286, 205)
        Me.chkTrunk.Name = "chkTrunk"
        Me.chkTrunk.Size = New System.Drawing.Size(132, 17)
        Me.chkTrunk.TabIndex = 64
        Me.chkTrunk.Text = "Print trunk frequencies"
        Me.chkTrunk.UseVisualStyleBackColor = True
        Me.chkTrunk.Visible = False
        '
        'chkPrintSys
        '
        Me.chkPrintSys.AutoSize = True
        Me.chkPrintSys.Checked = True
        Me.chkPrintSys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintSys.Location = New System.Drawing.Point(257, 182)
        Me.chkPrintSys.Name = "chkPrintSys"
        Me.chkPrintSys.Size = New System.Drawing.Size(176, 17)
        Me.chkPrintSys.TabIndex = 63
        Me.chkPrintSys.Text = "Print detailed system information"
        Me.chkPrintSys.UseVisualStyleBackColor = True
        '
        'chkPrintSummary
        '
        Me.chkPrintSummary.AutoSize = True
        Me.chkPrintSummary.Checked = True
        Me.chkPrintSummary.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintSummary.Location = New System.Drawing.Point(257, 163)
        Me.chkPrintSummary.Name = "chkPrintSummary"
        Me.chkPrintSummary.Size = New System.Drawing.Size(131, 17)
        Me.chkPrintSummary.TabIndex = 62
        Me.chkPrintSummary.Text = "Print detailed summary"
        Me.chkPrintSummary.UseVisualStyleBackColor = True
        '
        'chkPrintQKSummary
        '
        Me.chkPrintQKSummary.AutoSize = True
        Me.chkPrintQKSummary.Location = New System.Drawing.Point(257, 144)
        Me.chkPrintQKSummary.Name = "chkPrintQKSummary"
        Me.chkPrintQKSummary.Size = New System.Drawing.Size(145, 17)
        Me.chkPrintQKSummary.TabIndex = 61
        Me.chkPrintQKSummary.Text = "Print Quick Key Summary"
        Me.chkPrintQKSummary.UseVisualStyleBackColor = True
        '
        'cmdPrintHTML
        '
        Me.cmdPrintHTML.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrintHTML.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintHTML.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintHTML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrintHTML.Location = New System.Drawing.Point(451, 112)
        Me.cmdPrintHTML.Name = "cmdPrintHTML"
        Me.cmdPrintHTML.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrintHTML.Size = New System.Drawing.Size(118, 23)
        Me.cmdPrintHTML.TabIndex = 60
        Me.cmdPrintHTML.Text = "Print to &HTML..."
        Me.cmdPrintHTML.UseVisualStyleBackColor = True
        '
        'cmdPageSetup
        '
        Me.cmdPageSetup.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPageSetup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPageSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPageSetup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPageSetup.Location = New System.Drawing.Point(450, 82)
        Me.cmdPageSetup.Name = "cmdPageSetup"
        Me.cmdPageSetup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPageSetup.Size = New System.Drawing.Size(118, 23)
        Me.cmdPageSetup.TabIndex = 58
        Me.cmdPageSetup.Text = "Page Set&up..."
        Me.cmdPageSetup.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(450, 20)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(118, 23)
        Me.cmdPrint.TabIndex = 19
        Me.cmdPrint.Text = "&Show Print Dialog"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPreview.Location = New System.Drawing.Point(450, 50)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPreview.Size = New System.Drawing.Size(118, 23)
        Me.cmdPreview.TabIndex = 18
        Me.cmdPreview.Text = "Pre&view..."
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'cmdCheckAll
        '
        Me.cmdCheckAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCheckAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCheckAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCheckAll.Location = New System.Drawing.Point(256, 22)
        Me.cmdCheckAll.Name = "cmdCheckAll"
        Me.cmdCheckAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCheckAll.Size = New System.Drawing.Size(89, 23)
        Me.cmdCheckAll.TabIndex = 7
        Me.cmdCheckAll.Text = "Select &All"
        Me.cmdCheckAll.UseVisualStyleBackColor = True
        '
        'cmdClearAll
        '
        Me.cmdClearAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearAll.Location = New System.Drawing.Point(256, 52)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearAll.Size = New System.Drawing.Size(89, 23)
        Me.cmdClearAll.TabIndex = 6
        Me.cmdClearAll.Text = "Select &None"
        Me.cmdClearAll.UseVisualStyleBackColor = True
        '
        'cmdCheckSel
        '
        Me.cmdCheckSel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCheckSel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCheckSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckSel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCheckSel.Location = New System.Drawing.Point(256, 82)
        Me.cmdCheckSel.Name = "cmdCheckSel"
        Me.cmdCheckSel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCheckSel.Size = New System.Drawing.Size(89, 23)
        Me.cmdCheckSel.TabIndex = 5
        Me.cmdCheckSel.Text = "Select &Current"
        Me.cmdCheckSel.UseVisualStyleBackColor = True
        Me.cmdCheckSel.Visible = False
        '
        'cmdRedrawTree
        '
        Me.cmdRedrawTree.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRedrawTree.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRedrawTree.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRedrawTree.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRedrawTree.Location = New System.Drawing.Point(256, 111)
        Me.cmdRedrawTree.Name = "cmdRedrawTree"
        Me.cmdRedrawTree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRedrawTree.Size = New System.Drawing.Size(89, 23)
        Me.cmdRedrawTree.TabIndex = 3
        Me.cmdRedrawTree.Text = "&Refresh"
        Me.cmdRedrawTree.UseVisualStyleBackColor = True
        Me.cmdRedrawTree.Visible = False
        '
        'treeSystems
        '
        Me.treeSystems.CheckBoxes = True
        Me.treeSystems.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeSystems.HideSelection = False
        Me.treeSystems.HotTracking = True
        Me.treeSystems.Indent = 21
        Me.treeSystems.Location = New System.Drawing.Point(8, 15)
        Me.treeSystems.Name = "treeSystems"
        Me.treeSystems.Size = New System.Drawing.Size(233, 369)
        Me.treeSystems.TabIndex = 8
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.Frame2)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(585, 417)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Customize Layout"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.prerender)
        Me.Frame2.Controls.Add(Label5)
        Me.Frame2.Controls.Add(Label2)
        Me.Frame2.Controls.Add(Label1)
        Me.Frame2.Controls.Add(Me.lstTGID)
        Me.Frame2.Controls.Add(Me.lstConv)
        Me.Frame2.Controls.Add(Me.cmdSaveDefaultLayout)
        Me.Frame2.Controls.Add(Me.cmdRecallDEfault)
        Me.Frame2.Controls.Add(Me.cmdResetDefaykt)
        Me.Frame2.Controls.Add(Me.cmdFontChoose)
        Me.Frame2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(4, 5)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(576, 387)
        Me.Frame2.TabIndex = 30
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Layout Options"
        '
        'prerender
        '
        Me.prerender.Location = New System.Drawing.Point(496, 135)
        Me.prerender.MinimumSize = New System.Drawing.Size(20, 19)
        Me.prerender.Name = "prerender"
        Me.prerender.Size = New System.Drawing.Size(44, 20)
        Me.prerender.TabIndex = 0
        Me.prerender.Visible = False
        '
        'lstTGID
        '
        Me.lstTGID.FormattingEnabled = True
        Me.lstTGID.Location = New System.Drawing.Point(232, 52)
        Me.lstTGID.Name = "lstTGID"
        Me.lstTGID.Size = New System.Drawing.Size(187, 244)
        Me.lstTGID.TabIndex = 60
        Me.lstTGID.ThreeDCheckBoxes = True
        '
        'lstConv
        '
        Me.lstConv.FormattingEnabled = True
        Me.lstConv.Location = New System.Drawing.Point(10, 52)
        Me.lstConv.Name = "lstConv"
        Me.lstConv.Size = New System.Drawing.Size(187, 244)
        Me.lstConv.TabIndex = 59
        Me.lstConv.ThreeDCheckBoxes = True
        '
        'cmdRecallDEfault
        '
        Me.cmdRecallDEfault.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRecallDEfault.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRecallDEfault.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecallDEfault.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRecallDEfault.Location = New System.Drawing.Point(466, 44)
        Me.cmdRecallDEfault.Name = "cmdRecallDEfault"
        Me.cmdRecallDEfault.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRecallDEfault.Size = New System.Drawing.Size(100, 26)
        Me.cmdRecallDEfault.TabIndex = 35
        Me.cmdRecallDEfault.Text = "Load Default"
        Me.cmdRecallDEfault.UseVisualStyleBackColor = True
        '
        'cmdFontChoose
        '
        Me.cmdFontChoose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFontChoose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFontChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFontChoose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFontChoose.Location = New System.Drawing.Point(466, 73)
        Me.cmdFontChoose.Name = "cmdFontChoose"
        Me.cmdFontChoose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFontChoose.Size = New System.Drawing.Size(102, 26)
        Me.cmdFontChoose.TabIndex = 33
        Me.cmdFontChoose.Text = "&Font..."
        Me.cmdFontChoose.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(494, 455)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(97, 26)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmPrintSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(605, 487)
        Me.Controls.Add(Me.SSTab1)
        Me.Controls.Add(Me.cmdClose)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintSetup"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstMargin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuConvSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuTrunkSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents prerender As System.Windows.Forms.WebBrowser
    Public WithEvents cmdPageSetup As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTGID As System.Windows.Forms.CheckedListBox
    Friend WithEvents lstConv As System.Windows.Forms.CheckedListBox
    Public WithEvents cmdSaveDefaultLayout As System.Windows.Forms.Button
    Public WithEvents cmdRecallDEfault As System.Windows.Forms.Button
    Public WithEvents cmdResetDefaykt As System.Windows.Forms.Button
    Public WithEvents cmdFontChoose As System.Windows.Forms.Button
    Public WithEvents cmdPrintHTML As System.Windows.Forms.Button
    Friend WithEvents chkPrintSys As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrintSummary As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrintQKSummary As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrunk As System.Windows.Forms.CheckBox
#End Region 
End Class