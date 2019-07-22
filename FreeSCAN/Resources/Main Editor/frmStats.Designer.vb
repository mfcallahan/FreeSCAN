<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmStats
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
	Public WithEvents cmdClose As System.Windows.Forms.Button
    Public WithEvents _lblMaxChannels_1 As System.Windows.Forms.Label
    Public WithEvents _lblMaxGroups_1 As System.Windows.Forms.Label
    Public WithEvents _lblMaxSites_1 As System.Windows.Forms.Label
    Public WithEvents _lblMaxSystem_1 As System.Windows.Forms.Label
	Public WithEvents _lblMaxChannels_0 As System.Windows.Forms.Label
	Public WithEvents _lblMaxGroups_0 As System.Windows.Forms.Label
	Public WithEvents _lblMaxSites_0 As System.Windows.Forms.Label
	Public WithEvents _lblMaxSystem_0 As System.Windows.Forms.Label
	Public WithEvents Line1 As System.Windows.Forms.Label
	Public WithEvents lblUsedChannels As System.Windows.Forms.Label
	Public WithEvents lblUsedGroups As System.Windows.Forms.Label
	Public WithEvents lblSitesUsed As System.Windows.Forms.Label
	Public WithEvents lblSysUsed As System.Windows.Forms.Label
    Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Channels_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Channels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblMaxChannels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblMaxGroups As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblMaxSites As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblMaxSystem As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button
        Me._lblMaxChannels_1 = New System.Windows.Forms.Label
        Me._lblMaxGroups_1 = New System.Windows.Forms.Label
        Me._lblMaxSites_1 = New System.Windows.Forms.Label
        Me._lblMaxSystem_1 = New System.Windows.Forms.Label
        Me._lblMaxChannels_0 = New System.Windows.Forms.Label
        Me._lblMaxGroups_0 = New System.Windows.Forms.Label
        Me._lblMaxSites_0 = New System.Windows.Forms.Label
        Me._lblMaxSystem_0 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.lblUsedChannels = New System.Windows.Forms.Label
        Me.lblUsedGroups = New System.Windows.Forms.Label
        Me.lblSitesUsed = New System.Windows.Forms.Label
        Me.lblSysUsed = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Channels_2 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.Channels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblMaxChannels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblMaxGroups = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblMaxSites = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblMaxSystem = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmbModel = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Channels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMaxChannels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMaxGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMaxSites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMaxSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(271, 137)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(89, 25)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        '_lblMaxChannels_1
        '
        Me._lblMaxChannels_1.AutoSize = True
        Me._lblMaxChannels_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblMaxChannels_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblMaxChannels_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblMaxChannels_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxChannels.SetIndex(Me._lblMaxChannels_1, CType(1, Short))
        Me._lblMaxChannels_1.Location = New System.Drawing.Point(244, 104)
        Me._lblMaxChannels_1.Name = "_lblMaxChannels_1"
        Me._lblMaxChannels_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblMaxChannels_1.Size = New System.Drawing.Size(82, 14)
        Me._lblMaxChannels_1.TabIndex = 20
        Me._lblMaxChannels_1.Text = "lblMaxChannels"
        '
        '_lblMaxGroups_1
        '
        Me._lblMaxGroups_1.AutoSize = True
        Me._lblMaxGroups_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblMaxGroups_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblMaxGroups_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblMaxGroups_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxGroups.SetIndex(Me._lblMaxGroups_1, CType(1, Short))
        Me._lblMaxGroups_1.Location = New System.Drawing.Point(244, 80)
        Me._lblMaxGroups_1.Name = "_lblMaxGroups_1"
        Me._lblMaxGroups_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblMaxGroups_1.Size = New System.Drawing.Size(73, 14)
        Me._lblMaxGroups_1.TabIndex = 18
        Me._lblMaxGroups_1.Text = "lblMaxGroups"
        '
        '_lblMaxSites_1
        '
        Me._lblMaxSites_1.AutoSize = True
        Me._lblMaxSites_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblMaxSites_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblMaxSites_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblMaxSites_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxSites.SetIndex(Me._lblMaxSites_1, CType(1, Short))
        Me._lblMaxSites_1.Location = New System.Drawing.Point(244, 56)
        Me._lblMaxSites_1.Name = "_lblMaxSites_1"
        Me._lblMaxSites_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblMaxSites_1.Size = New System.Drawing.Size(61, 14)
        Me._lblMaxSites_1.TabIndex = 16
        Me._lblMaxSites_1.Text = "lblMaxSites"
        '
        '_lblMaxSystem_1
        '
        Me._lblMaxSystem_1.AutoSize = True
        Me._lblMaxSystem_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblMaxSystem_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblMaxSystem_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblMaxSystem_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxSystem.SetIndex(Me._lblMaxSystem_1, CType(1, Short))
        Me._lblMaxSystem_1.Location = New System.Drawing.Point(244, 32)
        Me._lblMaxSystem_1.Name = "_lblMaxSystem_1"
        Me._lblMaxSystem_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblMaxSystem_1.Size = New System.Drawing.Size(73, 14)
        Me._lblMaxSystem_1.TabIndex = 14
        Me._lblMaxSystem_1.Text = "lblMaxSystem"
        '
        '_lblMaxChannels_0
        '
        Me._lblMaxChannels_0.AutoSize = True
        Me._lblMaxChannels_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblMaxChannels_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblMaxChannels_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblMaxChannels_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxChannels.SetIndex(Me._lblMaxChannels_0, CType(0, Short))
        Me._lblMaxChannels_0.Location = New System.Drawing.Point(140, 104)
        Me._lblMaxChannels_0.Name = "_lblMaxChannels_0"
        Me._lblMaxChannels_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblMaxChannels_0.Size = New System.Drawing.Size(82, 14)
        Me._lblMaxChannels_0.TabIndex = 13
        Me._lblMaxChannels_0.Text = "lblMaxChannels"
        '
        '_lblMaxGroups_0
        '
        Me._lblMaxGroups_0.AutoSize = True
        Me._lblMaxGroups_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblMaxGroups_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblMaxGroups_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblMaxGroups_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxGroups.SetIndex(Me._lblMaxGroups_0, CType(0, Short))
        Me._lblMaxGroups_0.Location = New System.Drawing.Point(140, 80)
        Me._lblMaxGroups_0.Name = "_lblMaxGroups_0"
        Me._lblMaxGroups_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblMaxGroups_0.Size = New System.Drawing.Size(73, 14)
        Me._lblMaxGroups_0.TabIndex = 12
        Me._lblMaxGroups_0.Text = "lblMaxGroups"
        '
        '_lblMaxSites_0
        '
        Me._lblMaxSites_0.AutoSize = True
        Me._lblMaxSites_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblMaxSites_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblMaxSites_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblMaxSites_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxSites.SetIndex(Me._lblMaxSites_0, CType(0, Short))
        Me._lblMaxSites_0.Location = New System.Drawing.Point(140, 56)
        Me._lblMaxSites_0.Name = "_lblMaxSites_0"
        Me._lblMaxSites_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblMaxSites_0.Size = New System.Drawing.Size(61, 14)
        Me._lblMaxSites_0.TabIndex = 11
        Me._lblMaxSites_0.Text = "lblMaxSites"
        '
        '_lblMaxSystem_0
        '
        Me._lblMaxSystem_0.AutoSize = True
        Me._lblMaxSystem_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblMaxSystem_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblMaxSystem_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblMaxSystem_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxSystem.SetIndex(Me._lblMaxSystem_0, CType(0, Short))
        Me._lblMaxSystem_0.Location = New System.Drawing.Point(140, 32)
        Me._lblMaxSystem_0.Name = "_lblMaxSystem_0"
        Me._lblMaxSystem_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblMaxSystem_0.Size = New System.Drawing.Size(73, 14)
        Me._lblMaxSystem_0.TabIndex = 10
        Me._lblMaxSystem_0.Text = "lblMaxSystem"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Location = New System.Drawing.Point(68, 29)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(269, 1)
        Me.Line1.TabIndex = 34
        '
        'lblUsedChannels
        '
        Me.lblUsedChannels.AutoSize = True
        Me.lblUsedChannels.BackColor = System.Drawing.SystemColors.Control
        Me.lblUsedChannels.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUsedChannels.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsedChannels.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUsedChannels.Location = New System.Drawing.Point(68, 104)
        Me.lblUsedChannels.Name = "lblUsedChannels"
        Me.lblUsedChannels.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUsedChannels.Size = New System.Drawing.Size(61, 14)
        Me.lblUsedChannels.TabIndex = 9
        Me.lblUsedChannels.Text = "Compiling..."
        '
        'lblUsedGroups
        '
        Me.lblUsedGroups.AutoSize = True
        Me.lblUsedGroups.BackColor = System.Drawing.SystemColors.Control
        Me.lblUsedGroups.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUsedGroups.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsedGroups.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUsedGroups.Location = New System.Drawing.Point(68, 80)
        Me.lblUsedGroups.Name = "lblUsedGroups"
        Me.lblUsedGroups.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUsedGroups.Size = New System.Drawing.Size(61, 14)
        Me.lblUsedGroups.TabIndex = 8
        Me.lblUsedGroups.Text = "Compiling..."
        '
        'lblSitesUsed
        '
        Me.lblSitesUsed.AutoSize = True
        Me.lblSitesUsed.BackColor = System.Drawing.SystemColors.Control
        Me.lblSitesUsed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSitesUsed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSitesUsed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSitesUsed.Location = New System.Drawing.Point(68, 56)
        Me.lblSitesUsed.Name = "lblSitesUsed"
        Me.lblSitesUsed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSitesUsed.Size = New System.Drawing.Size(61, 14)
        Me.lblSitesUsed.TabIndex = 7
        Me.lblSitesUsed.Text = "Compiling..."
        '
        'lblSysUsed
        '
        Me.lblSysUsed.AutoSize = True
        Me.lblSysUsed.BackColor = System.Drawing.SystemColors.Control
        Me.lblSysUsed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSysUsed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysUsed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSysUsed.Location = New System.Drawing.Point(68, 32)
        Me.lblSysUsed.Name = "lblSysUsed"
        Me.lblSysUsed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSysUsed.Size = New System.Drawing.Size(61, 14)
        Me.lblSysUsed.TabIndex = 6
        Me.lblSysUsed.Text = "Compiling..."
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = True
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
        Me._Label1_4.Location = New System.Drawing.Point(20, 80)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(46, 14)
        Me._Label1_4.TabIndex = 4
        Me._Label1_4.Text = "Groups:"
        '
        '_Channels_2
        '
        Me._Channels_2.AutoSize = True
        Me._Channels_2.BackColor = System.Drawing.SystemColors.Control
        Me._Channels_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Channels_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Channels_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Channels.SetIndex(Me._Channels_2, CType(2, Short))
        Me._Channels_2.Location = New System.Drawing.Point(10, 104)
        Me._Channels_2.Name = "_Channels_2"
        Me._Channels_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Channels_2.Size = New System.Drawing.Size(55, 14)
        Me._Channels_2.TabIndex = 3
        Me._Channels_2.Text = "Channels:"
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = True
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(31, 56)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(34, 14)
        Me._Label1_1.TabIndex = 2
        Me._Label1_1.Text = "Sites:"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(15, 32)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(52, 14)
        Me._Label1_0.TabIndex = 1
        Me._Label1_0.Text = "Systems:"
        '
        'cmbModel
        '
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(239, 5)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(100, 22)
        Me.cmbModel.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 14)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Used             FreeSCAN Capacity"
        '
        'frmStats
        '
        Me.AcceptButton = Me.cmdClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(375, 172)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbModel)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me._lblMaxChannels_1)
        Me.Controls.Add(Me._lblMaxGroups_1)
        Me.Controls.Add(Me._lblMaxSites_1)
        Me.Controls.Add(Me._lblMaxSystem_1)
        Me.Controls.Add(Me._lblMaxChannels_0)
        Me.Controls.Add(Me._lblMaxGroups_0)
        Me.Controls.Add(Me._lblMaxSites_0)
        Me.Controls.Add(Me._lblMaxSystem_0)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.lblUsedChannels)
        Me.Controls.Add(Me.lblUsedGroups)
        Me.Controls.Add(Me.lblSitesUsed)
        Me.Controls.Add(Me.lblSysUsed)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Channels_2)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 32)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStats"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Statistics"
        CType(Me.Channels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMaxChannels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMaxGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMaxSites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMaxSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
#End Region 
End Class