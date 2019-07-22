<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmQKEdit
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
	Public WithEvents cmdReadScan As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdReset As System.Windows.Forms.Button
	Public WithEvents cmdeNuke As System.Windows.Forms.Button
	Public WithEvents prgMem As System.Windows.Forms.ProgressBar
	Public WithEvents lblFreeSys As System.Windows.Forms.Label
	Public WithEvents lblMem As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lstSystems As System.Windows.Forms.CheckedListBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQKEdit))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdReadScan = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdeNuke = New System.Windows.Forms.Button()
        Me.prgMem = New System.Windows.Forms.ProgressBar()
        Me.lblFreeSys = New System.Windows.Forms.Label()
        Me.lblMem = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSystems = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdReadScan
        '
        Me.cmdReadScan.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReadScan.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReadScan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReadScan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReadScan.Location = New System.Drawing.Point(248, 228)
        Me.cmdReadScan.Name = "cmdReadScan"
        Me.cmdReadScan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReadScan.Size = New System.Drawing.Size(145, 25)
        Me.cmdReadScan.TabIndex = 9
        Me.cmdReadScan.Text = "&Read Scanner"
        Me.cmdReadScan.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdClose)
        Me.Frame1.Controls.Add(Me.cmdReset)
        Me.Frame1.Controls.Add(Me.cmdeNuke)
        Me.Frame1.Controls.Add(Me.prgMem)
        Me.Frame1.Controls.Add(Me.lblFreeSys)
        Me.Frame1.Controls.Add(Me.lblMem)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 256)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(377, 161)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Scanner Memory"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(272, 124)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(93, 25)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReset.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReset.Location = New System.Drawing.Point(12, 124)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReset.Size = New System.Drawing.Size(129, 25)
        Me.cmdReset.TabIndex = 8
        Me.cmdReset.Text = "&Reset All Memory..."
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdeNuke
        '
        Me.cmdeNuke.BackColor = System.Drawing.SystemColors.Control
        Me.cmdeNuke.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdeNuke.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdeNuke.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdeNuke.Location = New System.Drawing.Point(12, 88)
        Me.cmdeNuke.Name = "cmdeNuke"
        Me.cmdeNuke.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdeNuke.Size = New System.Drawing.Size(129, 25)
        Me.cmdeNuke.TabIndex = 7
        Me.cmdeNuke.Text = "&Nuke Selected Systems"
        Me.cmdeNuke.UseVisualStyleBackColor = True
        '
        'prgMem
        '
        Me.prgMem.Location = New System.Drawing.Point(24, 40)
        Me.prgMem.Name = "prgMem"
        Me.prgMem.Size = New System.Drawing.Size(105, 17)
        Me.prgMem.TabIndex = 4
        '
        'lblFreeSys
        '
        Me.lblFreeSys.AutoSize = True
        Me.lblFreeSys.BackColor = System.Drawing.SystemColors.Control
        Me.lblFreeSys.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFreeSys.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreeSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFreeSys.Location = New System.Drawing.Point(152, 40)
        Me.lblFreeSys.Name = "lblFreeSys"
        Me.lblFreeSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFreeSys.Size = New System.Drawing.Size(83, 14)
        Me.lblFreeSys.TabIndex = 6
        Me.lblFreeSys.Text = "0 Free Systems"
        '
        'lblMem
        '
        Me.lblMem.AutoSize = True
        Me.lblMem.BackColor = System.Drawing.SystemColors.Control
        Me.lblMem.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMem.Location = New System.Drawing.Point(56, 56)
        Me.lblMem.Name = "lblMem"
        Me.lblMem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMem.Size = New System.Drawing.Size(42, 14)
        Me.lblMem.TabIndex = 5
        Me.lblMem.Text = "0% Full"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(56, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Memory"
        '
        'lstSystems
        '
        Me.lstSystems.BackColor = System.Drawing.SystemColors.Window
        Me.lstSystems.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstSystems.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSystems.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstSystems.Location = New System.Drawing.Point(16, 24)
        Me.lstSystems.Name = "lstSystems"
        Me.lstSystems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstSystems.Size = New System.Drawing.Size(377, 199)
        Me.lstSystems.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(138, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Currently Loaded Systems:"
        '
        'frmQKEdit
        '
        Me.AcceptButton = Me.cmdReadScan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(409, 432)
        Me.Controls.Add(Me.cmdReadScan)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.lstSystems)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 27)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQKEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Scanner Quick Editor"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class