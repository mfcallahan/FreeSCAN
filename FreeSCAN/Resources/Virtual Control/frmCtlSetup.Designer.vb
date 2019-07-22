<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCtlSetup
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
    Public WithEvents Timer_Renamed As System.Windows.Forms.Timer
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOpenControl As System.Windows.Forms.Button
	Public WithEvents cmdComSetup As System.Windows.Forms.Button
	Public WithEvents lblComSetting As System.Windows.Forms.Label
    Public WithEvents chkHideMain As System.Windows.Forms.CheckBox
	Public WithEvents tmrNegDelay As System.Windows.Forms.Timer
	Public WithEvents chkLog As System.Windows.Forms.CheckBox
	Public WithEvents _optInterface_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optInterface_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optInterface_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents optInterface As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtlSetup))
        Me.chkReduceCPU = New System.Windows.Forms.CheckBox()
        Me.chkHideMain = New System.Windows.Forms.CheckBox()
        Me.Timer_Renamed = New System.Windows.Forms.Timer(Me.components)
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOpenControl = New System.Windows.Forms.Button()
        Me.cmdComSetup = New System.Windows.Forms.Button()
        Me.lblComSetting = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkSpeech = New System.Windows.Forms.CheckBox()
        Me.chkLog = New System.Windows.Forms.CheckBox()
        Me._optInterface_2 = New System.Windows.Forms.RadioButton()
        Me._optInterface_1 = New System.Windows.Forms.RadioButton()
        Me._optInterface_0 = New System.Windows.Forms.RadioButton()
        Me.cmdShowRec = New System.Windows.Forms.Button()
        Me.tmrNegDelay = New System.Windows.Forms.Timer(Me.components)
        Me.optInterface = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Frame1.SuspendLayout()
        CType(Me.optInterface, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkReduceCPU
        '
        Me.chkReduceCPU.AutoSize = True
        Me.chkReduceCPU.BackColor = System.Drawing.SystemColors.Control
        Me.chkReduceCPU.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkReduceCPU.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReduceCPU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkReduceCPU.Location = New System.Drawing.Point(10, 169)
        Me.chkReduceCPU.Name = "chkReduceCPU"
        Me.chkReduceCPU.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkReduceCPU.Size = New System.Drawing.Size(96, 18)
        Me.chkReduceCPU.TabIndex = 5
        Me.chkReduceCPU.Text = "Conserve CPU"
        Me.chkReduceCPU.UseVisualStyleBackColor = False
        '
        'chkHideMain
        '
        Me.chkHideMain.AutoSize = True
        Me.chkHideMain.BackColor = System.Drawing.SystemColors.Control
        Me.chkHideMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHideMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHideMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkHideMain.Location = New System.Drawing.Point(10, 147)
        Me.chkHideMain.Name = "chkHideMain"
        Me.chkHideMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHideMain.Size = New System.Drawing.Size(158, 18)
        Me.chkHideMain.TabIndex = 4
        Me.chkHideMain.Text = "Hide Main Program Window"
        Me.chkHideMain.UseVisualStyleBackColor = False
        '
        'Timer_Renamed
        '
        Me.Timer_Renamed.Interval = 500
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(208, 104)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(126, 25)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "&Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOpenControl
        '
        Me.cmdOpenControl.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOpenControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOpenControl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOpenControl.Location = New System.Drawing.Point(208, 13)
        Me.cmdOpenControl.Name = "cmdOpenControl"
        Me.cmdOpenControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOpenControl.Size = New System.Drawing.Size(126, 25)
        Me.cmdOpenControl.TabIndex = 6
        Me.cmdOpenControl.Text = "&Start Virtual Control"
        Me.cmdOpenControl.UseVisualStyleBackColor = True
        '
        'cmdComSetup
        '
        Me.cmdComSetup.BackColor = System.Drawing.SystemColors.Control
        Me.cmdComSetup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdComSetup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComSetup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdComSetup.Location = New System.Drawing.Point(208, 73)
        Me.cmdComSetup.Name = "cmdComSetup"
        Me.cmdComSetup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdComSetup.Size = New System.Drawing.Size(126, 25)
        Me.cmdComSetup.TabIndex = 8
        Me.cmdComSetup.Text = "C&OM Port Setup..."
        Me.cmdComSetup.UseVisualStyleBackColor = True
        '
        'lblComSetting
        '
        Me.lblComSetting.AutoSize = True
        Me.lblComSetting.BackColor = System.Drawing.SystemColors.Control
        Me.lblComSetting.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComSetting.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComSetting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblComSetting.Location = New System.Drawing.Point(10, 21)
        Me.lblComSetting.Name = "lblComSetting"
        Me.lblComSetting.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComSetting.Size = New System.Drawing.Size(116, 14)
        Me.lblComSetting.TabIndex = 7
        Me.lblComSetting.Text = "COM: 1  SPEED: 57600"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkSpeech)
        Me.Frame1.Controls.Add(Me.lblComSetting)
        Me.Frame1.Controls.Add(Me.chkReduceCPU)
        Me.Frame1.Controls.Add(Me.chkHideMain)
        Me.Frame1.Controls.Add(Me.chkLog)
        Me.Frame1.Controls.Add(Me._optInterface_2)
        Me.Frame1.Controls.Add(Me._optInterface_1)
        Me.Frame1.Controls.Add(Me._optInterface_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(7, 6)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(195, 223)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Interface"
        '
        'chkSpeech
        '
        Me.chkSpeech.AutoSize = True
        Me.chkSpeech.BackColor = System.Drawing.SystemColors.Control
        Me.chkSpeech.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpeech.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpeech.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpeech.Location = New System.Drawing.Point(10, 193)
        Me.chkSpeech.Name = "chkSpeech"
        Me.chkSpeech.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpeech.Size = New System.Drawing.Size(157, 18)
        Me.chkSpeech.TabIndex = 9
        Me.chkSpeech.Text = "Speech synthesize ID Tags"
        Me.chkSpeech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkSpeech.UseVisualStyleBackColor = False
        '
        'chkLog
        '
        Me.chkLog.AutoSize = True
        Me.chkLog.BackColor = System.Drawing.SystemColors.Control
        Me.chkLog.Checked = True
        Me.chkLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLog.Location = New System.Drawing.Point(10, 126)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLog.Size = New System.Drawing.Size(77, 18)
        Me.chkLog.TabIndex = 3
        Me.chkLog.Text = "Lo&g all hits"
        Me.chkLog.UseVisualStyleBackColor = False
        '
        '_optInterface_2
        '
        Me._optInterface_2.BackColor = System.Drawing.SystemColors.Control
        Me._optInterface_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optInterface_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optInterface_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optInterface.SetIndex(Me._optInterface_2, CType(2, Short))
        Me._optInterface_2.Location = New System.Drawing.Point(11, 79)
        Me._optInterface_2.Name = "_optInterface_2"
        Me._optInterface_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optInterface_2.Size = New System.Drawing.Size(125, 17)
        Me._optInterface_2.TabIndex = 2
        Me._optInterface_2.TabStop = True
        Me._optInterface_2.Text = "&LCARS Interface"
        Me._optInterface_2.UseVisualStyleBackColor = False
        '
        '_optInterface_1
        '
        Me._optInterface_1.BackColor = System.Drawing.SystemColors.Control
        Me._optInterface_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optInterface_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optInterface_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optInterface.SetIndex(Me._optInterface_1, CType(1, Short))
        Me._optInterface_1.Location = New System.Drawing.Point(11, 40)
        Me._optInterface_1.Name = "_optInterface_1"
        Me._optInterface_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optInterface_1.Size = New System.Drawing.Size(145, 17)
        Me._optInterface_1.TabIndex = 0
        Me._optInterface_1.TabStop = True
        Me._optInterface_1.Text = "&Windows-based interface"
        Me._optInterface_1.UseVisualStyleBackColor = False
        '
        '_optInterface_0
        '
        Me._optInterface_0.BackColor = System.Drawing.SystemColors.Control
        Me._optInterface_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optInterface_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optInterface_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optInterface.SetIndex(Me._optInterface_0, CType(0, Short))
        Me._optInterface_0.Location = New System.Drawing.Point(11, 60)
        Me._optInterface_0.Name = "_optInterface_0"
        Me._optInterface_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optInterface_0.Size = New System.Drawing.Size(149, 17)
        Me._optInterface_0.TabIndex = 1
        Me._optInterface_0.TabStop = True
        Me._optInterface_0.Text = "&IPod / iSCAN"
        Me._optInterface_0.UseVisualStyleBackColor = False
        '
        'cmdShowRec
        '
        Me.cmdShowRec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdShowRec.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdShowRec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShowRec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdShowRec.Location = New System.Drawing.Point(208, 43)
        Me.cmdShowRec.Name = "cmdShowRec"
        Me.cmdShowRec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdShowRec.Size = New System.Drawing.Size(126, 25)
        Me.cmdShowRec.TabIndex = 7
        Me.cmdShowRec.Text = "Se&tup Recording..."
        Me.cmdShowRec.UseVisualStyleBackColor = True
        '
        'tmrNegDelay
        '
        Me.tmrNegDelay.Interval = 200
        '
        'frmCtlSetup
        '
        Me.AcceptButton = Me.cmdOpenControl
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(352, 238)
        Me.Controls.Add(Me.cmdComSetup)
        Me.Controls.Add(Me.cmdShowRec)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOpenControl)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCtlSetup"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Virtual Control"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.optInterface, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents chkReduceCPU As System.Windows.Forms.CheckBox
    Public WithEvents cmdShowRec As System.Windows.Forms.Button
    Public WithEvents chkSpeech As System.Windows.Forms.CheckBox
#End Region
End Class