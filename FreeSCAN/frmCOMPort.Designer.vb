<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCOMPort
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
    Public WithEvents cmdAbortAuto As System.Windows.Forms.Button
	Public WithEvents cmdAutoDetect As System.Windows.Forms.Button
	Public WithEvents cmdRefresh As System.Windows.Forms.Button
	Public WithEvents cmbPortSpeed As System.Windows.Forms.ComboBox
	Public WithEvents cmbCOMPort As System.Windows.Forms.ComboBox
	Public WithEvents cmbApplyComPortSettings As System.Windows.Forms.Button
	Public WithEvents lblStat As System.Windows.Forms.Label
	Public WithEvents lblSpeed As System.Windows.Forms.Label
	Public WithEvents lblPort As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Line1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCOMPort))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkBeCareful = New System.Windows.Forms.CheckBox()
        Me.cmdAbortAuto = New System.Windows.Forms.Button()
        Me.cmdAutoDetect = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmbPortSpeed = New System.Windows.Forms.ComboBox()
        Me.cmbCOMPort = New System.Windows.Forms.ComboBox()
        Me.cmbApplyComPortSettings = New System.Windows.Forms.Button()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkBeCareful
        '
        Me.chkBeCareful.AccessibleDescription = "Careful download option"
        Me.chkBeCareful.BackColor = System.Drawing.SystemColors.Control
        Me.chkBeCareful.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBeCareful.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBeCareful.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBeCareful.Location = New System.Drawing.Point(184, 61)
        Me.chkBeCareful.Name = "chkBeCareful"
        Me.chkBeCareful.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBeCareful.Size = New System.Drawing.Size(145, 17)
        Me.chkBeCareful.TabIndex = 16
        Me.chkBeCareful.Text = "Use careful IO"
        Me.ToolTip1.SetToolTip(Me.chkBeCareful, "This reduces errors on less then ideal serial ports. Use this if you get errors o" & _
        "n download or upload. Clear this for max download speed. If unsure leave checked" & _
        ".")
        Me.chkBeCareful.UseVisualStyleBackColor = False
        '
        'cmdAbortAuto
        '
        Me.cmdAbortAuto.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAbortAuto.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAbortAuto.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbortAuto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAbortAuto.Location = New System.Drawing.Point(8, 278)
        Me.cmdAbortAuto.Name = "cmdAbortAuto"
        Me.cmdAbortAuto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAbortAuto.Size = New System.Drawing.Size(85, 25)
        Me.cmdAbortAuto.TabIndex = 13
        Me.cmdAbortAuto.Text = "&Abort Auto"
        Me.cmdAbortAuto.UseVisualStyleBackColor = True
        '
        'cmdAutoDetect
        '
        Me.cmdAutoDetect.AccessibleDescription = "Setup for COM settings"
        Me.cmdAutoDetect.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAutoDetect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAutoDetect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAutoDetect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAutoDetect.Location = New System.Drawing.Point(8, 246)
        Me.cmdAutoDetect.Name = "cmdAutoDetect"
        Me.cmdAutoDetect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAutoDetect.Size = New System.Drawing.Size(85, 25)
        Me.cmdAutoDetect.TabIndex = 12
        Me.cmdAutoDetect.Text = "&Start Auto"
        Me.cmdAutoDetect.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(180, 17)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(57, 21)
        Me.cmdRefresh.TabIndex = 5
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmbPortSpeed
        '
        Me.cmbPortSpeed.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPortSpeed.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPortSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPortSpeed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPortSpeed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPortSpeed.Location = New System.Drawing.Point(72, 56)
        Me.cmbPortSpeed.Name = "cmbPortSpeed"
        Me.cmbPortSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbPortSpeed.Size = New System.Drawing.Size(97, 22)
        Me.cmbPortSpeed.TabIndex = 3
        '
        'cmbCOMPort
        '
        Me.cmbCOMPort.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCOMPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCOMPort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCOMPort.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCOMPort.Location = New System.Drawing.Point(72, 16)
        Me.cmbCOMPort.Name = "cmbCOMPort"
        Me.cmbCOMPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCOMPort.Size = New System.Drawing.Size(97, 22)
        Me.cmbCOMPort.TabIndex = 2
        '
        'cmbApplyComPortSettings
        '
        Me.cmbApplyComPortSettings.BackColor = System.Drawing.SystemColors.Control
        Me.cmbApplyComPortSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbApplyComPortSettings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbApplyComPortSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbApplyComPortSettings.Location = New System.Drawing.Point(232, 308)
        Me.cmbApplyComPortSettings.Name = "cmbApplyComPortSettings"
        Me.cmbApplyComPortSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbApplyComPortSettings.Size = New System.Drawing.Size(97, 25)
        Me.cmbApplyComPortSettings.TabIndex = 1
        Me.cmbApplyComPortSettings.Text = "&Close"
        Me.cmbApplyComPortSettings.UseVisualStyleBackColor = True
        '
        'lblStat
        '
        Me.lblStat.AutoSize = True
        Me.lblStat.BackColor = System.Drawing.SystemColors.Control
        Me.lblStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStat.Location = New System.Drawing.Point(200, 218)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStat.Size = New System.Drawing.Size(52, 14)
        Me.lblStat.TabIndex = 11
        Me.lblStat.Text = "Fail at life"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.BackColor = System.Drawing.SystemColors.Control
        Me.lblSpeed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSpeed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSpeed.Location = New System.Drawing.Point(140, 218)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSpeed.Size = New System.Drawing.Size(42, 14)
        Me.lblSpeed.TabIndex = 10
        Me.lblSpeed.Text = "115200"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.BackColor = System.Drawing.SystemColors.Control
        Me.lblPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPort.Location = New System.Drawing.Point(96, 218)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPort.Size = New System.Drawing.Size(13, 14)
        Me.lblPort.TabIndex = 9
        Me.lblPort.Text = "0"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(84, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(209, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Port #          Speed         Status"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(321, 57)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Location = New System.Drawing.Point(8, 130)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(320, 1)
        Me.Line1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(74, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Autodetection"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Port #:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Port Speed:"
        '
        'cmdTest
        '
        Me.cmdTest.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTest.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTest.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTest.Location = New System.Drawing.Point(256, 17)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTest.Size = New System.Drawing.Size(57, 21)
        Me.cmdTest.TabIndex = 17
        Me.cmdTest.Text = "&Test"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'frmCOMPort
        '
        Me.AccessibleDescription = "Control serial port settings"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(338, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdTest)
        Me.Controls.Add(Me.chkBeCareful)
        Me.Controls.Add(Me.cmdAbortAuto)
        Me.Controls.Add(Me.cmdAutoDetect)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmbPortSpeed)
        Me.Controls.Add(Me.cmbCOMPort)
        Me.Controls.Add(Me.cmbApplyComPortSettings)
        Me.Controls.Add(Me.lblStat)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCOMPort"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "COM Port Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents chkBeCareful As System.Windows.Forms.CheckBox
    Public WithEvents cmdTest As System.Windows.Forms.Button
#End Region 
End Class