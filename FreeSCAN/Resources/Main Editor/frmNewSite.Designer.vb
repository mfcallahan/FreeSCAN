<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNewSite
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
	Public WithEvents cmbsystype As System.Windows.Forms.ListBox
	Public WithEvents txtSysName As System.Windows.Forms.TextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdSelectSysType As System.Windows.Forms.Button
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewSite))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtSysName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbsystype = New System.Windows.Forms.ListBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSelectSysType = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSysName
        '
        Me.txtSysName.BackColor = System.Drawing.SystemColors.Window
        Me.txtSysName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSysName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSysName.Location = New System.Drawing.Point(6, 196)
        Me.txtSysName.MaxLength = 16
        Me.txtSysName.Name = "txtSysName"
        Me.txtSysName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSysName.Size = New System.Drawing.Size(136, 20)
        Me.txtSysName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtSysName, "Enter desired system name. Leaving this blank would result in a default system na" & _
        "me.")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select System Type:"
        Me.ToolTip1.SetToolTip(Me.Label1, "Tip: Double click on sys type to quickly create the system")
        '
        'cmbsystype
        '
        Me.cmbsystype.BackColor = System.Drawing.SystemColors.Window
        Me.cmbsystype.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbsystype.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsystype.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbsystype.ItemHeight = 14
        Me.cmbsystype.Location = New System.Drawing.Point(6, 24)
        Me.cmbsystype.Name = "cmbsystype"
        Me.cmbsystype.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbsystype.Size = New System.Drawing.Size(343, 144)
        Me.cmbsystype.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(192, 220)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(97, 25)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Ca&ncel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSelectSysType
        '
        Me.cmdSelectSysType.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSelectSysType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSelectSysType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectSysType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelectSysType.Location = New System.Drawing.Point(66, 220)
        Me.cmdSelectSysType.Name = "cmdSelectSysType"
        Me.cmdSelectSysType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSelectSysType.Size = New System.Drawing.Size(97, 25)
        Me.cmdSelectSysType.TabIndex = 2
        Me.cmdSelectSysType.Text = "&Create System"
        Me.cmdSelectSysType.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(102, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "New System Name:"
        '
        'frmNewSite
        '
        Me.AcceptButton = Me.cmdSelectSysType
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(360, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbsystype)
        Me.Controls.Add(Me.txtSysName)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSelectSysType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewSite"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "New System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class