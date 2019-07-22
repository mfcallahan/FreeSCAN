<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmImport
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
	Public WithEvents barComplete As System.Windows.Forms.ProgressBar
	Public WithEvents cmdImportSys As System.Windows.Forms.Button
	Public WithEvents cmdImport As System.Windows.Forms.Button
	Public WithEvents _lblStat_3 As System.Windows.Forms.Label
	Public WithEvents _lblStat_2 As System.Windows.Forms.Label
	Public WithEvents _lblStat_1 As System.Windows.Forms.Label
	Public WithEvents _lblStat_0 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmdClearAll As System.Windows.Forms.Button
	Public WithEvents cmdSelectAll As System.Windows.Forms.Button
	Public WithEvents treeview As System.Windows.Forms.TreeView
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public CommonDialogOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents cmdChooseFile As System.Windows.Forms.Button
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblFileName As System.Windows.Forms.Label
	Public WithEvents label55 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblStat As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImport))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.barComplete = New System.Windows.Forms.ProgressBar
        Me.cmdImportSys = New System.Windows.Forms.Button
        Me.cmdImport = New System.Windows.Forms.Button
        Me._lblStat_3 = New System.Windows.Forms.Label
        Me._lblStat_2 = New System.Windows.Forms.Label
        Me._lblStat_1 = New System.Windows.Forms.Label
        Me._lblStat_0 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.cmdClearAll = New System.Windows.Forms.Button
        Me.cmdSelectAll = New System.Windows.Forms.Button
        Me.treeview = New System.Windows.Forms.TreeView
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdChooseFile = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblFileName = New System.Windows.Forms.Label
        Me.label55 = New System.Windows.Forms.Label
        Me.CommonDialogOpen = New System.Windows.Forms.OpenFileDialog
        Me.lblStat = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.lblStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(440, 464)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(81, 25)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.barComplete)
        Me.Frame3.Controls.Add(Me.cmdImportSys)
        Me.Frame3.Controls.Add(Me.cmdImport)
        Me.Frame3.Controls.Add(Me._lblStat_3)
        Me.Frame3.Controls.Add(Me._lblStat_2)
        Me.Frame3.Controls.Add(Me._lblStat_1)
        Me.Frame3.Controls.Add(Me._lblStat_0)
        Me.Frame3.Controls.Add(Me.Label6)
        Me.Frame3.Controls.Add(Me.Label1)
        Me.Frame3.Controls.Add(Me.Label5)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(8, 360)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(521, 89)
        Me.Frame3.TabIndex = 6
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "3. Import"
        '
        'barComplete
        '
        Me.barComplete.Location = New System.Drawing.Point(231, 40)
        Me.barComplete.Name = "barComplete"
        Me.barComplete.Size = New System.Drawing.Size(121, 17)
        Me.barComplete.TabIndex = 16
        '
        'cmdImportSys
        '
        Me.cmdImportSys.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImportSys.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImportSys.Enabled = False
        Me.cmdImportSys.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImportSys.Location = New System.Drawing.Point(432, 56)
        Me.cmdImportSys.Name = "cmdImportSys"
        Me.cmdImportSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImportSys.Size = New System.Drawing.Size(81, 25)
        Me.cmdImportSys.TabIndex = 11
        Me.cmdImportSys.Text = "&Start Import"
        Me.cmdImportSys.UseVisualStyleBackColor = True
        '
        'cmdImport
        '
        Me.cmdImport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImport.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImport.Location = New System.Drawing.Point(432, 96)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImport.Size = New System.Drawing.Size(81, 25)
        Me.cmdImport.TabIndex = 7
        Me.cmdImport.Text = "&Import"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        '_lblStat_3
        '
        Me._lblStat_3.AutoSize = True
        Me._lblStat_3.BackColor = System.Drawing.SystemColors.Control
        Me._lblStat_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblStat_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblStat_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStat.SetIndex(Me._lblStat_3, CType(3, Short))
        Me._lblStat_3.Location = New System.Drawing.Point(128, 64)
        Me._lblStat_3.Name = "_lblStat_3"
        Me._lblStat_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblStat_3.Size = New System.Drawing.Size(13, 14)
        Me._lblStat_3.TabIndex = 22
        Me._lblStat_3.Text = "0"
        '
        '_lblStat_2
        '
        Me._lblStat_2.AutoSize = True
        Me._lblStat_2.BackColor = System.Drawing.SystemColors.Control
        Me._lblStat_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblStat_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblStat_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStat.SetIndex(Me._lblStat_2, CType(2, Short))
        Me._lblStat_2.Location = New System.Drawing.Point(128, 48)
        Me._lblStat_2.Name = "_lblStat_2"
        Me._lblStat_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblStat_2.Size = New System.Drawing.Size(13, 14)
        Me._lblStat_2.TabIndex = 21
        Me._lblStat_2.Text = "0"
        '
        '_lblStat_1
        '
        Me._lblStat_1.AutoSize = True
        Me._lblStat_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblStat_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblStat_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblStat_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStat.SetIndex(Me._lblStat_1, CType(1, Short))
        Me._lblStat_1.Location = New System.Drawing.Point(128, 32)
        Me._lblStat_1.Name = "_lblStat_1"
        Me._lblStat_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblStat_1.Size = New System.Drawing.Size(13, 14)
        Me._lblStat_1.TabIndex = 20
        Me._lblStat_1.Text = "0"
        '
        '_lblStat_0
        '
        Me._lblStat_0.AutoSize = True
        Me._lblStat_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblStat_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblStat_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblStat_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStat.SetIndex(Me._lblStat_0, CType(0, Short))
        Me._lblStat_0.Location = New System.Drawing.Point(128, 16)
        Me._lblStat_0.Name = "_lblStat_0"
        Me._lblStat_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblStat_0.Size = New System.Drawing.Size(13, 14)
        Me._lblStat_0.TabIndex = 19
        Me._lblStat_0.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(264, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(64, 14)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "% Complete"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(114, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Trunking Frequencies:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(67, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(55, 14)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Channels:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(42, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Sites && Groups:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(72, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Systems:"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cmdClearAll)
        Me.Frame2.Controls.Add(Me.cmdSelectAll)
        Me.Frame2.Controls.Add(Me.treeview)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 96)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(521, 257)
        Me.Frame2.TabIndex = 4
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "2. Choose which systems, sites && groups you want to import"
        '
        'cmdClearAll
        '
        Me.cmdClearAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearAll.Location = New System.Drawing.Point(96, 224)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearAll.Size = New System.Drawing.Size(73, 25)
        Me.cmdClearAll.TabIndex = 10
        Me.cmdClearAll.Text = "Cl&ear All"
        Me.cmdClearAll.UseVisualStyleBackColor = True
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSelectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSelectAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelectAll.Location = New System.Drawing.Point(8, 224)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSelectAll.Size = New System.Drawing.Size(73, 25)
        Me.cmdSelectAll.TabIndex = 9
        Me.cmdSelectAll.Text = "Sele&ct  All"
        Me.cmdSelectAll.UseVisualStyleBackColor = True
        '
        'treeview
        '
        Me.treeview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treeview.CheckBoxes = True
        Me.treeview.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeview.HideSelection = False
        Me.treeview.HotTracking = True
        Me.treeview.Indent = 59
        Me.treeview.LabelEdit = True
        Me.treeview.Location = New System.Drawing.Point(8, 16)
        Me.treeview.Name = "treeview"
        Me.treeview.Size = New System.Drawing.Size(505, 201)
        Me.treeview.TabIndex = 12
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdChooseFile)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.lblFileName)
        Me.Frame1.Controls.Add(Me.label55)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(521, 81)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "1. Choose the file you wish to import"
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.BackColor = System.Drawing.SystemColors.Control
        Me.cmdChooseFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdChooseFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChooseFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdChooseFile.Location = New System.Drawing.Point(424, 48)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdChooseFile.Size = New System.Drawing.Size(89, 25)
        Me.cmdChooseFile.TabIndex = 3
        Me.cmdChooseFile.Text = "&Open..."
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(298, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Supported File Formats: FreeSCAN996 .03+, FreeSCAN .08+"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.BackColor = System.Drawing.SystemColors.Control
        Me.lblFileName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFileName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFileName.Location = New System.Drawing.Point(16, 32)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFileName.Size = New System.Drawing.Size(40, 14)
        Me.lblFileName.TabIndex = 2
        Me.lblFileName.Text = "(None)"
        '
        'label55
        '
        Me.label55.AutoSize = True
        Me.label55.BackColor = System.Drawing.SystemColors.Control
        Me.label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.label55.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label55.Location = New System.Drawing.Point(8, 16)
        Me.label55.Name = "label55"
        Me.label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label55.Size = New System.Drawing.Size(71, 14)
        Me.label55.TabIndex = 1
        Me.label55.Text = "Selected File:"
        '
        'CommonDialogOpen
        '
        Me.CommonDialogOpen.Title = "Open..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 502)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Import"
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.lblStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
#End Region 
End Class