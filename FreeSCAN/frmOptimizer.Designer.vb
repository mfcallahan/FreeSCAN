<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOptimizer
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
	Public WithEvents cmdRefresh As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdViewBadChan As System.Windows.Forms.Button
	Public WithEvents cmdRemTGID As System.Windows.Forms.Button
	Public WithEvents cmdHoldTimeReset As System.Windows.Forms.Button
	Public WithEvents cmdAutoSort As System.Windows.Forms.Button
	Public WithEvents cmdOpenDup As System.Windows.Forms.Button
	Public WithEvents _shpStat_3 As System.Windows.Forms.Label
	Public WithEvents _shpStat_2 As System.Windows.Forms.Label
	Public WithEvents _shpStat_1 As System.Windows.Forms.Label
	Public WithEvents _shpStat_0 As System.Windows.Forms.Label
	Public WithEvents lblFreqSort As System.Windows.Forms.Label
	Public WithEvents lblTGID As System.Windows.Forms.Label
	Public WithEvents lblHoldTime As System.Windows.Forms.Label
	Public WithEvents lblDupFreq As System.Windows.Forms.Label
	Public WithEvents _Label3_3 As System.Windows.Forms.Label
	Public WithEvents _Label2_3 As System.Windows.Forms.Label
	Public WithEvents _Label3_2 As System.Windows.Forms.Label
    Public WithEvents _Label2_2 As System.Windows.Forms.Label
	Public WithEvents _Label2_1 As System.Windows.Forms.Label
	Public WithEvents _Label2_0 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label3 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents shpStat As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim _Label3_1 As System.Windows.Forms.Label
        Dim _Label3_0 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptimizer))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me._Label3_2 = New System.Windows.Forms.Label
        Me.cmdViewBadChan = New System.Windows.Forms.Button
        Me.cmdRemTGID = New System.Windows.Forms.Button
        Me.cmdHoldTimeReset = New System.Windows.Forms.Button
        Me.cmdAutoSort = New System.Windows.Forms.Button
        Me.cmdOpenDup = New System.Windows.Forms.Button
        Me._shpStat_3 = New System.Windows.Forms.Label
        Me._shpStat_2 = New System.Windows.Forms.Label
        Me._shpStat_1 = New System.Windows.Forms.Label
        Me._shpStat_0 = New System.Windows.Forms.Label
        Me.lblFreqSort = New System.Windows.Forms.Label
        Me.lblTGID = New System.Windows.Forms.Label
        Me.lblHoldTime = New System.Windows.Forms.Label
        Me.lblDupFreq = New System.Windows.Forms.Label
        Me._Label3_3 = New System.Windows.Forms.Label
        Me._Label2_3 = New System.Windows.Forms.Label
        Me._Label2_2 = New System.Windows.Forms.Label
        Me._Label2_1 = New System.Windows.Forms.Label
        Me._Label2_0 = New System.Windows.Forms.Label
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label3 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.shpStat = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        _Label3_1 = New System.Windows.Forms.Label
        _Label3_0 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shpStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Label3_1
        '
        _Label3_1.BackColor = System.Drawing.SystemColors.Control
        _Label3_1.Cursor = System.Windows.Forms.Cursors.Default
        _Label3_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label3_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.SetIndex(_Label3_1, CType(1, Short))
        _Label3_1.Location = New System.Drawing.Point(12, 189)
        _Label3_1.Name = "_Label3_1"
        _Label3_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label3_1.Size = New System.Drawing.Size(547, 28)
        _Label3_1.TabIndex = 6
        _Label3_1.Text = "Sorting frequencies gives a speed boost to scanning conventional systems. Choosin" & _
            "g this option will cause every conventional frequency in memory to be sorted."
        '
        '_Label3_0
        '
        _Label3_0.BackColor = System.Drawing.SystemColors.Control
        _Label3_0.Cursor = System.Windows.Forms.Cursors.Default
        _Label3_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Label3_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.SetIndex(_Label3_0, CType(0, Short))
        _Label3_0.Location = New System.Drawing.Point(12, 99)
        _Label3_0.Name = "_Label3_0"
        _Label3_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        _Label3_0.Size = New System.Drawing.Size(550, 31)
        _Label3_0.TabIndex = 5
        _Label3_0.Text = "Duplicate freqs slow down scanning by making the scanner scan the same thing twic" & _
            "e. Shown are frequencies with identical PL Tones."
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(12, 18)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(547, 29)
        Label4.TabIndex = 26
        Label4.Text = "The automatic scanner optimizer is like having a scanner expert carefully comb th" & _
            "rough your configuration and make sure everything is tweaked to get peak perform" & _
            "ance from your scanner. "
        Label4.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(12, 47)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(534, 33)
        Label1.TabIndex = 27
        Label1.Text = "Running the optimizer can help increase scan speed and available scanner memory. " & _
            "It is recommended that you save your file prior to making any changes, as change" & _
            "s cannot be undone."
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(351, 483)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(100, 25)
        Me.cmdRefresh.TabIndex = 19
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(462, 483)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(100, 25)
        Me.cmdClose.TabIndex = 18
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Label1)
        Me.Frame1.Controls.Add(Label4)
        Me.Frame1.Controls.Add(Me._Label3_2)
        Me.Frame1.Controls.Add(Me.cmdViewBadChan)
        Me.Frame1.Controls.Add(Me.cmdRemTGID)
        Me.Frame1.Controls.Add(Me.cmdHoldTimeReset)
        Me.Frame1.Controls.Add(Me.cmdAutoSort)
        Me.Frame1.Controls.Add(Me.cmdOpenDup)
        Me.Frame1.Controls.Add(Me._shpStat_3)
        Me.Frame1.Controls.Add(Me._shpStat_2)
        Me.Frame1.Controls.Add(Me._shpStat_1)
        Me.Frame1.Controls.Add(Me._shpStat_0)
        Me.Frame1.Controls.Add(Me.lblFreqSort)
        Me.Frame1.Controls.Add(Me.lblTGID)
        Me.Frame1.Controls.Add(Me.lblHoldTime)
        Me.Frame1.Controls.Add(Me.lblDupFreq)
        Me.Frame1.Controls.Add(Me._Label3_3)
        Me.Frame1.Controls.Add(Me._Label2_3)
        Me.Frame1.Controls.Add(_Label3_1)
        Me.Frame1.Controls.Add(_Label3_0)
        Me.Frame1.Controls.Add(Me._Label2_2)
        Me.Frame1.Controls.Add(Me._Label2_1)
        Me.Frame1.Controls.Add(Me._Label2_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(7, 7)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(569, 467)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Scanner Optimizer"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(538, 33)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Choosing this option will change all conventional systems to 0 seconds and all tr" & _
            "unked system to 2 seconds (maximum). These are the recommended settings."
        '
        '_Label3_2
        '
        Me._Label3_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.SetIndex(Me._Label3_2, CType(2, Short))
        Me._Label3_2.Location = New System.Drawing.Point(12, 282)
        Me._Label3_2.Name = "_Label3_2"
        Me._Label3_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_2.Size = New System.Drawing.Size(547, 32)
        Me._Label3_2.TabIndex = 7
        Me._Label3_2.Text = "Hold times cause a scanner to pause on a system or site for an excessive amount o" & _
            "f time and missing calls on other systems."
        '
        'cmdViewBadChan
        '
        Me.cmdViewBadChan.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewBadChan.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewBadChan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewBadChan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewBadChan.Location = New System.Drawing.Point(342, 429)
        Me.cmdViewBadChan.Name = "cmdViewBadChan"
        Me.cmdViewBadChan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewBadChan.Size = New System.Drawing.Size(100, 25)
        Me.cmdViewBadChan.TabIndex = 20
        Me.cmdViewBadChan.Text = "&View..."
        Me.cmdViewBadChan.UseVisualStyleBackColor = True
        '
        'cmdRemTGID
        '
        Me.cmdRemTGID.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRemTGID.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRemTGID.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemTGID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRemTGID.Location = New System.Drawing.Point(453, 429)
        Me.cmdRemTGID.Name = "cmdRemTGID"
        Me.cmdRemTGID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRemTGID.Size = New System.Drawing.Size(100, 25)
        Me.cmdRemTGID.TabIndex = 16
        Me.cmdRemTGID.Text = "&Remove Invalids"
        Me.cmdRemTGID.UseVisualStyleBackColor = True
        '
        'cmdHoldTimeReset
        '
        Me.cmdHoldTimeReset.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHoldTimeReset.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHoldTimeReset.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHoldTimeReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHoldTimeReset.Location = New System.Drawing.Point(453, 345)
        Me.cmdHoldTimeReset.Name = "cmdHoldTimeReset"
        Me.cmdHoldTimeReset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHoldTimeReset.Size = New System.Drawing.Size(100, 25)
        Me.cmdHoldTimeReset.TabIndex = 14
        Me.cmdHoldTimeReset.Text = "Op&timize All"
        Me.cmdHoldTimeReset.UseVisualStyleBackColor = True
        '
        'cmdAutoSort
        '
        Me.cmdAutoSort.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAutoSort.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAutoSort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAutoSort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAutoSort.Location = New System.Drawing.Point(453, 219)
        Me.cmdAutoSort.Name = "cmdAutoSort"
        Me.cmdAutoSort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAutoSort.Size = New System.Drawing.Size(100, 25)
        Me.cmdAutoSort.TabIndex = 12
        Me.cmdAutoSort.Text = "Auto &Sort Now"
        Me.cmdAutoSort.UseVisualStyleBackColor = True
        '
        'cmdOpenDup
        '
        Me.cmdOpenDup.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOpenDup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOpenDup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenDup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOpenDup.Location = New System.Drawing.Point(423, 141)
        Me.cmdOpenDup.Name = "cmdOpenDup"
        Me.cmdOpenDup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOpenDup.Size = New System.Drawing.Size(130, 25)
        Me.cmdOpenDup.TabIndex = 10
        Me.cmdOpenDup.Text = "Open &Duplicate Finder..."
        Me.cmdOpenDup.UseVisualStyleBackColor = True
        '
        '_shpStat_3
        '
        Me._shpStat_3.BackColor = System.Drawing.Color.Red
        Me._shpStat_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._shpStat_3.ForeColor = System.Drawing.Color.Black
        Me.shpStat.SetIndex(Me._shpStat_3, CType(3, Short))
        Me._shpStat_3.Location = New System.Drawing.Point(18, 425)
        Me._shpStat_3.Name = "_shpStat_3"
        Me._shpStat_3.Size = New System.Drawing.Size(10, 10)
        Me._shpStat_3.TabIndex = 21
        '
        '_shpStat_2
        '
        Me._shpStat_2.BackColor = System.Drawing.Color.Red
        Me._shpStat_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._shpStat_2.ForeColor = System.Drawing.Color.Black
        Me.shpStat.SetIndex(Me._shpStat_2, CType(2, Short))
        Me._shpStat_2.Location = New System.Drawing.Point(17, 348)
        Me._shpStat_2.Name = "_shpStat_2"
        Me._shpStat_2.Size = New System.Drawing.Size(10, 10)
        Me._shpStat_2.TabIndex = 22
        '
        '_shpStat_1
        '
        Me._shpStat_1.BackColor = System.Drawing.Color.Red
        Me._shpStat_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._shpStat_1.ForeColor = System.Drawing.Color.Black
        Me.shpStat.SetIndex(Me._shpStat_1, CType(1, Short))
        Me._shpStat_1.Location = New System.Drawing.Point(18, 227)
        Me._shpStat_1.Name = "_shpStat_1"
        Me._shpStat_1.Size = New System.Drawing.Size(10, 10)
        Me._shpStat_1.TabIndex = 23
        '
        '_shpStat_0
        '
        Me._shpStat_0.BackColor = System.Drawing.Color.Red
        Me._shpStat_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._shpStat_0.ForeColor = System.Drawing.Color.Black
        Me.shpStat.SetIndex(Me._shpStat_0, CType(0, Short))
        Me._shpStat_0.Location = New System.Drawing.Point(18, 139)
        Me._shpStat_0.Name = "_shpStat_0"
        Me._shpStat_0.Size = New System.Drawing.Size(10, 10)
        Me._shpStat_0.TabIndex = 24
        '
        'lblFreqSort
        '
        Me.lblFreqSort.AutoSize = True
        Me.lblFreqSort.BackColor = System.Drawing.SystemColors.Control
        Me.lblFreqSort.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFreqSort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreqSort.ForeColor = System.Drawing.Color.Blue
        Me.lblFreqSort.Location = New System.Drawing.Point(32, 225)
        Me.lblFreqSort.Name = "lblFreqSort"
        Me.lblFreqSort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFreqSort.Size = New System.Drawing.Size(250, 14)
        Me.lblFreqSort.TabIndex = 17
        Me.lblFreqSort.Text = "Frequencies are presently sorted at 0% efficiency"
        '
        'lblTGID
        '
        Me.lblTGID.AutoSize = True
        Me.lblTGID.BackColor = System.Drawing.SystemColors.Control
        Me.lblTGID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTGID.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTGID.ForeColor = System.Drawing.Color.Blue
        Me.lblTGID.Location = New System.Drawing.Point(32, 424)
        Me.lblTGID.Name = "lblTGID"
        Me.lblTGID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTGID.Size = New System.Drawing.Size(127, 14)
        Me.lblTGID.TabIndex = 15
        Me.lblTGID.Text = "0 invalid channels found."
        '
        'lblHoldTime
        '
        Me.lblHoldTime.AutoSize = True
        Me.lblHoldTime.BackColor = System.Drawing.SystemColors.Control
        Me.lblHoldTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHoldTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoldTime.ForeColor = System.Drawing.Color.Blue
        Me.lblHoldTime.Location = New System.Drawing.Point(31, 346)
        Me.lblHoldTime.Name = "lblHoldTime"
        Me.lblHoldTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHoldTime.Size = New System.Drawing.Size(177, 14)
        Me.lblHoldTime.TabIndex = 13
        Me.lblHoldTime.Text = "0 inefficient systems && sites found."
        '
        'lblDupFreq
        '
        Me.lblDupFreq.AutoSize = True
        Me.lblDupFreq.BackColor = System.Drawing.SystemColors.Control
        Me.lblDupFreq.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDupFreq.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDupFreq.ForeColor = System.Drawing.Color.Blue
        Me.lblDupFreq.Location = New System.Drawing.Point(32, 137)
        Me.lblDupFreq.Name = "lblDupFreq"
        Me.lblDupFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDupFreq.Size = New System.Drawing.Size(182, 14)
        Me.lblDupFreq.TabIndex = 11
        Me.lblDupFreq.Text = "0 duplicate frequencies are present."
        '
        '_Label3_3
        '
        Me._Label3_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.SetIndex(Me._Label3_3, CType(3, Short))
        Me._Label3_3.Location = New System.Drawing.Point(12, 390)
        Me._Label3_3.Name = "_Label3_3"
        Me._Label3_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_3.Size = New System.Drawing.Size(445, 34)
        Me._Label3_3.TabIndex = 9
        Me._Label3_3.Text = "These waste scanner memory that could be put to better use. Activating this will " & _
            "delete all zero, blank, and non numeric TGIDs and frequencies which the scanner " & _
            "cannot process."
        '
        '_Label2_3
        '
        Me._Label2_3.AutoSize = True
        Me._Label2_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_3, CType(3, Short))
        Me._Label2_3.Location = New System.Drawing.Point(12, 375)
        Me._Label2_3.Name = "_Label2_3"
        Me._Label2_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_3.Size = New System.Drawing.Size(97, 14)
        Me._Label2_3.TabIndex = 8
        Me._Label2_3.Text = "Invalid Channels"
        '
        '_Label2_2
        '
        Me._Label2_2.AutoSize = True
        Me._Label2_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_2, CType(2, Short))
        Me._Label2_2.Location = New System.Drawing.Point(12, 265)
        Me._Label2_2.Name = "_Label2_2"
        Me._Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_2.Size = New System.Drawing.Size(100, 14)
        Me._Label2_2.TabIndex = 4
        Me._Label2_2.Text = "Long Hold Times"
        Me._Label2_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label2_1
        '
        Me._Label2_1.AutoSize = True
        Me._Label2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_1, CType(1, Short))
        Me._Label2_1.Location = New System.Drawing.Point(12, 174)
        Me._Label2_1.Name = "_Label2_1"
        Me._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_1.Size = New System.Drawing.Size(108, 14)
        Me._Label2_1.TabIndex = 3
        Me._Label2_1.Text = "Frequency Sorting"
        Me._Label2_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label2_0
        '
        Me._Label2_0.AutoSize = True
        Me._Label2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_0, CType(0, Short))
        Me._Label2_0.Location = New System.Drawing.Point(12, 84)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_0.Size = New System.Drawing.Size(129, 14)
        Me._Label2_0.TabIndex = 2
        Me._Label2_0.Text = "Duplicate Frequencies"
        Me._Label2_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmOptimizer
        '
        Me.AcceptButton = Me.cmdClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(589, 517)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 28)
        Me.Name = "frmOptimizer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Automatic Scanner Optimizer"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shpStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
#End Region
End Class