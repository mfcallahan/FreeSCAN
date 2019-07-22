<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFill
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
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdFill As System.Windows.Forms.Button
	Public WithEvents chkNameNum As System.Windows.Forms.CheckBox
	Public WithEvents chkNameFreq As System.Windows.Forms.CheckBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents cmbStepSize As System.Windows.Forms.ComboBox
	Public WithEvents txtNumFreq As System.Windows.Forms.TextBox
	Public WithEvents _optEnd_1 As System.Windows.Forms.RadioButton
	Public WithEvents txtEndFreq As System.Windows.Forms.TextBox
	Public WithEvents _optEnd_0 As System.Windows.Forms.RadioButton
	Public WithEvents txtStartFreq As System.Windows.Forms.TextBox
	Public WithEvents _Label1_5 As System.Windows.Forms.Label
	Public WithEvents _Line1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Line1_5 As System.Windows.Forms.Label
	Public WithEvents _Line1_1 As System.Windows.Forms.Label
	Public WithEvents _Line1_2 As System.Windows.Forms.Label
	Public WithEvents _Line1_0 As System.Windows.Forms.Label
	Public WithEvents _Label2_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents _Label2_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label2_0 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Line1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents optEnd As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFill))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdFill = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.chkNameNum = New System.Windows.Forms.CheckBox
        Me.chkNameFreq = New System.Windows.Forms.CheckBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.cmbStepSize = New System.Windows.Forms.ComboBox
        Me.txtNumFreq = New System.Windows.Forms.TextBox
        Me._optEnd_1 = New System.Windows.Forms.RadioButton
        Me.txtEndFreq = New System.Windows.Forms.TextBox
        Me._optEnd_0 = New System.Windows.Forms.RadioButton
        Me.txtStartFreq = New System.Windows.Forms.TextBox
        Me._Label1_5 = New System.Windows.Forms.Label
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Line1_5 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me._Label2_2 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Label2_1 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label2_0 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Line1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.optEnd = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Frame1.SuspendLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(312, 388)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(77, 25)
        Me.cmdCancel.TabIndex = 16
        Me.cmdCancel.Text = "&Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdFill
        '
        Me.cmdFill.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFill.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFill.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFill.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFill.Location = New System.Drawing.Point(224, 388)
        Me.cmdFill.Name = "cmdFill"
        Me.cmdFill.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFill.Size = New System.Drawing.Size(77, 25)
        Me.cmdFill.TabIndex = 15
        Me.cmdFill.Text = "&Fill"
        Me.cmdFill.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkNameNum)
        Me.Frame1.Controls.Add(Me.chkNameFreq)
        Me.Frame1.Controls.Add(Me.txtName)
        Me.Frame1.Controls.Add(Me.cmbStepSize)
        Me.Frame1.Controls.Add(Me.txtNumFreq)
        Me.Frame1.Controls.Add(Me._optEnd_1)
        Me.Frame1.Controls.Add(Me.txtEndFreq)
        Me.Frame1.Controls.Add(Me._optEnd_0)
        Me.Frame1.Controls.Add(Me.txtStartFreq)
        Me.Frame1.Controls.Add(Me._Label1_5)
        Me.Frame1.Controls.Add(Me._Line1_3)
        Me.Frame1.Controls.Add(Me._Label1_4)
        Me.Frame1.Controls.Add(Me._Line1_5)
        Me.Frame1.Controls.Add(Me._Line1_1)
        Me.Frame1.Controls.Add(Me._Line1_2)
        Me.Frame1.Controls.Add(Me._Line1_0)
        Me.Frame1.Controls.Add(Me._Label2_2)
        Me.Frame1.Controls.Add(Me._Label1_3)
        Me.Frame1.Controls.Add(Me._Label1_2)
        Me.Frame1.Controls.Add(Me._Label2_1)
        Me.Frame1.Controls.Add(Me._Label1_1)
        Me.Frame1.Controls.Add(Me._Label2_0)
        Me.Frame1.Controls.Add(Me._Label1_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(7, 4)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(385, 373)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Select Fill Options"
        '
        'chkNameNum
        '
        Me.chkNameNum.BackColor = System.Drawing.SystemColors.Control
        Me.chkNameNum.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNameNum.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNameNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNameNum.Location = New System.Drawing.Point(208, 316)
        Me.chkNameNum.Name = "chkNameNum"
        Me.chkNameNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNameNum.Size = New System.Drawing.Size(145, 17)
        Me.chkNameNum.TabIndex = 20
        Me.chkNameNum.Text = "Append C&hannel Number"
        Me.chkNameNum.UseVisualStyleBackColor = False
        '
        'chkNameFreq
        '
        Me.chkNameFreq.BackColor = System.Drawing.SystemColors.Control
        Me.chkNameFreq.Checked = True
        Me.chkNameFreq.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNameFreq.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNameFreq.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNameFreq.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNameFreq.Location = New System.Drawing.Point(208, 300)
        Me.chkNameFreq.Name = "chkNameFreq"
        Me.chkNameFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNameFreq.Size = New System.Drawing.Size(121, 17)
        Me.chkNameFreq.TabIndex = 19
        Me.chkNameFreq.Text = "Append &Frequency"
        Me.chkNameFreq.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtName.Location = New System.Drawing.Point(84, 300)
        Me.txtName.MaxLength = 16
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.Size = New System.Drawing.Size(105, 20)
        Me.txtName.TabIndex = 18
        '
        'cmbStepSize
        '
        Me.cmbStepSize.BackColor = System.Drawing.SystemColors.Window
        Me.cmbStepSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbStepSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStepSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbStepSize.Location = New System.Drawing.Point(84, 104)
        Me.cmbStepSize.Name = "cmbStepSize"
        Me.cmbStepSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStepSize.Size = New System.Drawing.Size(73, 22)
        Me.cmbStepSize.TabIndex = 12
        Me.cmbStepSize.Text = "Combo1"
        '
        'txtNumFreq
        '
        Me.txtNumFreq.AcceptsReturn = True
        Me.txtNumFreq.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumFreq.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumFreq.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumFreq.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumFreq.Location = New System.Drawing.Point(84, 240)
        Me.txtNumFreq.MaxLength = 4
        Me.txtNumFreq.Name = "txtNumFreq"
        Me.txtNumFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumFreq.Size = New System.Drawing.Size(69, 20)
        Me.txtNumFreq.TabIndex = 9
        '
        '_optEnd_1
        '
        Me._optEnd_1.BackColor = System.Drawing.SystemColors.Control
        Me._optEnd_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optEnd_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optEnd_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optEnd.SetIndex(Me._optEnd_1, CType(1, Short))
        Me._optEnd_1.Location = New System.Drawing.Point(48, 216)
        Me._optEnd_1.Name = "_optEnd_1"
        Me._optEnd_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optEnd_1.Size = New System.Drawing.Size(218, 17)
        Me._optEnd_1.TabIndex = 8
        Me._optEnd_1.TabStop = True
        Me._optEnd_1.Text = "After creating This Many Frequencies:"
        Me._optEnd_1.UseVisualStyleBackColor = False
        '
        'txtEndFreq
        '
        Me.txtEndFreq.AcceptsReturn = True
        Me.txtEndFreq.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndFreq.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndFreq.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndFreq.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEndFreq.Location = New System.Drawing.Point(84, 188)
        Me.txtEndFreq.MaxLength = 9
        Me.txtEndFreq.Name = "txtEndFreq"
        Me.txtEndFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEndFreq.Size = New System.Drawing.Size(69, 20)
        Me.txtEndFreq.TabIndex = 6
        '
        '_optEnd_0
        '
        Me._optEnd_0.BackColor = System.Drawing.SystemColors.Control
        Me._optEnd_0.Checked = True
        Me._optEnd_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optEnd_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optEnd_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optEnd.SetIndex(Me._optEnd_0, CType(0, Short))
        Me._optEnd_0.Location = New System.Drawing.Point(48, 168)
        Me._optEnd_0.Name = "_optEnd_0"
        Me._optEnd_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optEnd_0.Size = New System.Drawing.Size(104, 17)
        Me._optEnd_0.TabIndex = 5
        Me._optEnd_0.TabStop = True
        Me._optEnd_0.Text = "This Frequency"
        Me._optEnd_0.UseVisualStyleBackColor = False
        '
        'txtStartFreq
        '
        Me.txtStartFreq.AcceptsReturn = True
        Me.txtStartFreq.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartFreq.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartFreq.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartFreq.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartFreq.Location = New System.Drawing.Point(84, 44)
        Me.txtStartFreq.MaxLength = 9
        Me.txtStartFreq.Name = "txtStartFreq"
        Me.txtStartFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartFreq.Size = New System.Drawing.Size(69, 20)
        Me.txtStartFreq.TabIndex = 2
        '
        '_Label1_5
        '
        Me._Label1_5.AutoSize = True
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_5, CType(5, Short))
        Me._Label1_5.Location = New System.Drawing.Point(20, 300)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(59, 14)
        Me._Label1_5.TabIndex = 17
        Me._Label1_5.Text = "Alpha Tag:"
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.SetIndex(Me._Line1_3, CType(3, Short))
        Me._Line1_3.Location = New System.Drawing.Point(8, 292)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(372, 1)
        Me._Line1_3.TabIndex = 21
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = True
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
        Me._Label1_4.Location = New System.Drawing.Point(8, 280)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(94, 14)
        Me._Label1_4.TabIndex = 14
        Me._Label1_4.Text = "Additional Options"
        '
        '_Line1_5
        '
        Me._Line1_5.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.SetIndex(Me._Line1_5, CType(5, Short))
        Me._Line1_5.Location = New System.Drawing.Point(8, 160)
        Me._Line1_5.Name = "_Line1_5"
        Me._Line1_5.Size = New System.Drawing.Size(372, 1)
        Me._Line1_5.TabIndex = 22
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.SetIndex(Me._Line1_1, CType(1, Short))
        Me._Line1_1.Location = New System.Drawing.Point(8, 96)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(372, 1)
        Me._Line1_1.TabIndex = 23
        '
        '_Line1_2
        '
        Me._Line1_2.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.SetIndex(Me._Line1_2, CType(2, Short))
        Me._Line1_2.Location = New System.Drawing.Point(8, 32)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(252, 1)
        Me._Line1_2.TabIndex = 24
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.SetIndex(Me._Line1_0, CType(0, Short))
        Me._Line1_0.Location = New System.Drawing.Point(252, 32)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(124, 1)
        Me._Line1_0.TabIndex = 25
        '
        '_Label2_2
        '
        Me._Label2_2.AutoSize = True
        Me._Label2_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_2, CType(2, Short))
        Me._Label2_2.Location = New System.Drawing.Point(160, 112)
        Me._Label2_2.Name = "_Label2_2"
        Me._Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_2.Size = New System.Drawing.Size(26, 14)
        Me._Label2_2.TabIndex = 13
        Me._Label2_2.Text = "Khz"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
        Me._Label1_3.Location = New System.Drawing.Point(8, 84)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(53, 14)
        Me._Label1_3.TabIndex = 11
        Me._Label1_3.Text = "Step Size"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = True
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(160, 244)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(170, 14)
        Me._Label1_2.TabIndex = 10
        Me._Label1_2.Text = "Number of Frequencies To Create"
        '
        '_Label2_1
        '
        Me._Label2_1.AutoSize = True
        Me._Label2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_1, CType(1, Short))
        Me._Label2_1.Location = New System.Drawing.Point(160, 188)
        Me._Label2_1.Name = "_Label2_1"
        Me._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_1.Size = New System.Drawing.Size(27, 14)
        Me._Label2_1.TabIndex = 7
        Me._Label2_1.Text = "Mhz"
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = True
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(8, 148)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(39, 14)
        Me._Label1_1.TabIndex = 4
        Me._Label1_1.Text = "End At"
        '
        '_Label2_0
        '
        Me._Label2_0.AutoSize = True
        Me._Label2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_0, CType(0, Short))
        Me._Label2_0.Location = New System.Drawing.Point(160, 48)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_0.Size = New System.Drawing.Size(27, 14)
        Me._Label2_0.TabIndex = 3
        Me._Label2_0.Text = "Mhz"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(8, 20)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(113, 14)
        Me._Label1_0.TabIndex = 1
        Me._Label1_0.Text = "Enter Start Frequency"
        '
        'frmFill
        '
        Me.AcceptButton = Me.cmdFill
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(402, 420)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdFill)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFill"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Frequency Fill"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class