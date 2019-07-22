<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmParse
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
	Public WithEvents _cmbField_8 As System.Windows.Forms.ComboBox
	Public WithEvents cmdClear As System.Windows.Forms.Button
    Public WithEvents chkKompress As System.Windows.Forms.CheckBox
	Public WithEvents chkNoChop As System.Windows.Forms.CheckBox
	Public WithEvents chkAutoField As System.Windows.Forms.CheckBox
	Public WithEvents chkDelete As System.Windows.Forms.CheckBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdImportToSys As System.Windows.Forms.Button
	Public WithEvents _cmbField_7 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbField_6 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbField_5 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbField_4 As System.Windows.Forms.ComboBox
	Public WithEvents _optDelimit_4 As System.Windows.Forms.RadioButton
	Public WithEvents txtDelimit As System.Windows.Forms.TextBox
	Public WithEvents _optDelimit_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optDelimit_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optDelimit_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optDelimit_0 As System.Windows.Forms.RadioButton
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
'	Public WithEvents grdField As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _cmbField_3 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbField_2 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbField_1 As System.Windows.Forms.ComboBox
	Public WithEvents _cmbField_0 As System.Windows.Forms.ComboBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdEZGrab As System.Windows.Forms.Button
	Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents cmbField As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents optDelimit As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParse))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._cmbField_8 = New System.Windows.Forms.ComboBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.chkKompress = New System.Windows.Forms.CheckBox()
        Me.chkNoChop = New System.Windows.Forms.CheckBox()
        Me.chkAutoField = New System.Windows.Forms.CheckBox()
        Me.chkDelete = New System.Windows.Forms.CheckBox()
        Me.cmdImportToSys = New System.Windows.Forms.Button()
        Me._cmbField_7 = New System.Windows.Forms.ComboBox()
        Me._cmbField_6 = New System.Windows.Forms.ComboBox()
        Me._cmbField_5 = New System.Windows.Forms.ComboBox()
        Me._cmbField_4 = New System.Windows.Forms.ComboBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._optDelimit_4 = New System.Windows.Forms.RadioButton()
        Me.txtDelimit = New System.Windows.Forms.TextBox()
        Me._optDelimit_3 = New System.Windows.Forms.RadioButton()
        Me._optDelimit_2 = New System.Windows.Forms.RadioButton()
        Me._optDelimit_1 = New System.Windows.Forms.RadioButton()
        Me._optDelimit_0 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me._cmbField_3 = New System.Windows.Forms.ComboBox()
        Me._cmbField_2 = New System.Windows.Forms.ComboBox()
        Me._cmbField_1 = New System.Windows.Forms.ComboBox()
        Me._cmbField_0 = New System.Windows.Forms.ComboBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdEZGrab = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmbField = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.optDelimit = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.grdField = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optDelimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_cmbField_8
        '
        Me._cmbField_8.BackColor = System.Drawing.SystemColors.Window
        Me._cmbField_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbField_8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbField_8.DropDownWidth = 160
        Me._cmbField_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbField_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbField.SetIndex(Me._cmbField_8, CType(8, Short))
        Me._cmbField_8.Location = New System.Drawing.Point(556, 224)
        Me._cmbField_8.Name = "_cmbField_8"
        Me._cmbField_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbField_8.Size = New System.Drawing.Size(68, 22)
        Me._cmbField_8.TabIndex = 35
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(232, 470)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(97, 25)
        Me.cmdClear.TabIndex = 21
        Me.cmdClear.Text = "&Clear All"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.chkKompress)
        Me.Frame2.Controls.Add(Me.chkNoChop)
        Me.Frame2.Controls.Add(Me.chkAutoField)
        Me.Frame2.Controls.Add(Me.chkDelete)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 56)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(345, 101)
        Me.Frame2.TabIndex = 27
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Options"
        '
        'chkKompress
        '
        Me.chkKompress.BackColor = System.Drawing.SystemColors.Control
        Me.chkKompress.Checked = True
        Me.chkKompress.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKompress.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkKompress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKompress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkKompress.Location = New System.Drawing.Point(8, 71)
        Me.chkKompress.Name = "chkKompress"
        Me.chkKompress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkKompress.Size = New System.Drawing.Size(313, 23)
        Me.chkKompress.TabIndex = 33
        Me.chkKompress.Text = "Automatically &shrink and abbreviate long channel names"
        Me.chkKompress.UseVisualStyleBackColor = False
        '
        'chkNoChop
        '
        Me.chkNoChop.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoChop.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoChop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoChop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNoChop.Location = New System.Drawing.Point(8, 52)
        Me.chkNoChop.Name = "chkNoChop"
        Me.chkNoChop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoChop.Size = New System.Drawing.Size(321, 19)
        Me.chkNoChop.TabIndex = 32
        Me.chkNoChop.Text = "If a name is longer than 16 characters, keep the last part rather than the first"
        Me.chkNoChop.UseVisualStyleBackColor = False
        '
        'chkAutoField
        '
        Me.chkAutoField.BackColor = System.Drawing.SystemColors.Control
        Me.chkAutoField.Checked = True
        Me.chkAutoField.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoField.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAutoField.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoField.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAutoField.Location = New System.Drawing.Point(8, 36)
        Me.chkAutoField.Name = "chkAutoField"
        Me.chkAutoField.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAutoField.Size = New System.Drawing.Size(305, 17)
        Me.chkAutoField.TabIndex = 2
        Me.chkAutoField.Text = "&Guess which columns are frequencies, description etc."
        Me.chkAutoField.UseVisualStyleBackColor = False
        '
        'chkDelete
        '
        Me.chkDelete.BackColor = System.Drawing.SystemColors.Control
        Me.chkDelete.Checked = True
        Me.chkDelete.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDelete.Location = New System.Drawing.Point(8, 16)
        Me.chkDelete.Name = "chkDelete"
        Me.chkDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDelete.Size = New System.Drawing.Size(281, 17)
        Me.chkDelete.TabIndex = 1
        Me.chkDelete.Text = "Clear the &list every time I click on Copy From Clipboard"
        Me.chkDelete.UseVisualStyleBackColor = False
        '
        'cmdImportToSys
        '
        Me.cmdImportToSys.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImportToSys.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImportToSys.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportToSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImportToSys.Location = New System.Drawing.Point(8, 504)
        Me.cmdImportToSys.Name = "cmdImportToSys"
        Me.cmdImportToSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImportToSys.Size = New System.Drawing.Size(132, 25)
        Me.cmdImportToSys.TabIndex = 22
        Me.cmdImportToSys.Text = "&2. Import Into FreeSCAN"
        Me.cmdImportToSys.UseVisualStyleBackColor = True
        '
        '_cmbField_7
        '
        Me._cmbField_7.BackColor = System.Drawing.SystemColors.Window
        Me._cmbField_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbField_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbField_7.DropDownWidth = 160
        Me._cmbField_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbField_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbField.SetIndex(Me._cmbField_7, CType(7, Short))
        Me._cmbField_7.Location = New System.Drawing.Point(488, 224)
        Me._cmbField_7.Name = "_cmbField_7"
        Me._cmbField_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbField_7.Size = New System.Drawing.Size(68, 22)
        Me._cmbField_7.TabIndex = 18
        '
        '_cmbField_6
        '
        Me._cmbField_6.BackColor = System.Drawing.SystemColors.Window
        Me._cmbField_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbField_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbField_6.DropDownWidth = 160
        Me._cmbField_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbField_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbField.SetIndex(Me._cmbField_6, CType(6, Short))
        Me._cmbField_6.Location = New System.Drawing.Point(420, 224)
        Me._cmbField_6.Name = "_cmbField_6"
        Me._cmbField_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbField_6.Size = New System.Drawing.Size(68, 22)
        Me._cmbField_6.TabIndex = 17
        '
        '_cmbField_5
        '
        Me._cmbField_5.BackColor = System.Drawing.SystemColors.Window
        Me._cmbField_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbField_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbField_5.DropDownWidth = 160
        Me._cmbField_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbField_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbField.SetIndex(Me._cmbField_5, CType(5, Short))
        Me._cmbField_5.Location = New System.Drawing.Point(352, 224)
        Me._cmbField_5.Name = "_cmbField_5"
        Me._cmbField_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbField_5.Size = New System.Drawing.Size(68, 22)
        Me._cmbField_5.TabIndex = 16
        '
        '_cmbField_4
        '
        Me._cmbField_4.BackColor = System.Drawing.SystemColors.Window
        Me._cmbField_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbField_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbField_4.DropDownWidth = 160
        Me._cmbField_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbField_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbField.SetIndex(Me._cmbField_4, CType(4, Short))
        Me._cmbField_4.Location = New System.Drawing.Point(284, 224)
        Me._cmbField_4.Name = "_cmbField_4"
        Me._cmbField_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbField_4.Size = New System.Drawing.Size(68, 22)
        Me._cmbField_4.TabIndex = 15
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._optDelimit_4)
        Me.Frame1.Controls.Add(Me.txtDelimit)
        Me.Frame1.Controls.Add(Me._optDelimit_3)
        Me.Frame1.Controls.Add(Me._optDelimit_2)
        Me.Frame1.Controls.Add(Me._optDelimit_1)
        Me.Frame1.Controls.Add(Me._optDelimit_0)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(368, 60)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(193, 158)
        Me.Frame1.TabIndex = 25
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Delimiter"
        '
        '_optDelimit_4
        '
        Me._optDelimit_4.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_4, CType(4, Short))
        Me._optDelimit_4.Location = New System.Drawing.Point(12, 71)
        Me._optDelimit_4.Name = "_optDelimit_4"
        Me._optDelimit_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_4.Size = New System.Drawing.Size(117, 17)
        Me._optDelimit_4.TabIndex = 34
        Me._optDelimit_4.TabStop = True
        Me._optDelimit_4.Text = "Carriage Return"
        Me._optDelimit_4.UseVisualStyleBackColor = True
        '
        'txtDelimit
        '
        Me.txtDelimit.AcceptsReturn = True
        Me.txtDelimit.BackColor = System.Drawing.SystemColors.Window
        Me.txtDelimit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDelimit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelimit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDelimit.Location = New System.Drawing.Point(72, 88)
        Me.txtDelimit.MaxLength = 8
        Me.txtDelimit.Name = "txtDelimit"
        Me.txtDelimit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDelimit.Size = New System.Drawing.Size(65, 20)
        Me.txtDelimit.TabIndex = 7
        Me.txtDelimit.Text = " "
        '
        '_optDelimit_3
        '
        Me._optDelimit_3.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_3, CType(3, Short))
        Me._optDelimit_3.Location = New System.Drawing.Point(12, 88)
        Me._optDelimit_3.Name = "_optDelimit_3"
        Me._optDelimit_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_3.Size = New System.Drawing.Size(65, 17)
        Me._optDelimit_3.TabIndex = 6
        Me._optDelimit_3.TabStop = True
        Me._optDelimit_3.Text = "Custom"
        Me._optDelimit_3.UseVisualStyleBackColor = True
        '
        '_optDelimit_2
        '
        Me._optDelimit_2.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_2, CType(2, Short))
        Me._optDelimit_2.Location = New System.Drawing.Point(12, 54)
        Me._optDelimit_2.Name = "_optDelimit_2"
        Me._optDelimit_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_2.Size = New System.Drawing.Size(57, 17)
        Me._optDelimit_2.TabIndex = 5
        Me._optDelimit_2.TabStop = True
        Me._optDelimit_2.Text = "Space"
        Me._optDelimit_2.UseVisualStyleBackColor = True
        '
        '_optDelimit_1
        '
        Me._optDelimit_1.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_1, CType(1, Short))
        Me._optDelimit_1.Location = New System.Drawing.Point(12, 37)
        Me._optDelimit_1.Name = "_optDelimit_1"
        Me._optDelimit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_1.Size = New System.Drawing.Size(65, 17)
        Me._optDelimit_1.TabIndex = 4
        Me._optDelimit_1.TabStop = True
        Me._optDelimit_1.Text = "Comma"
        Me._optDelimit_1.UseVisualStyleBackColor = True
        '
        '_optDelimit_0
        '
        Me._optDelimit_0.BackColor = System.Drawing.SystemColors.Control
        Me._optDelimit_0.Checked = True
        Me._optDelimit_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optDelimit_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optDelimit_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDelimit.SetIndex(Me._optDelimit_0, CType(0, Short))
        Me._optDelimit_0.Location = New System.Drawing.Point(12, 20)
        Me._optDelimit_0.Name = "_optDelimit_0"
        Me._optDelimit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optDelimit_0.Size = New System.Drawing.Size(89, 17)
        Me._optDelimit_0.TabIndex = 3
        Me._optDelimit_0.TabStop = True
        Me._optDelimit_0.Text = "Auto/Tab*"
        Me._optDelimit_0.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(177, 31)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "*Recommended for RadioReference.com and Firefox"
        '
        '_cmbField_3
        '
        Me._cmbField_3.BackColor = System.Drawing.SystemColors.Window
        Me._cmbField_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbField_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbField_3.DropDownWidth = 160
        Me._cmbField_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbField_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbField.SetIndex(Me._cmbField_3, CType(3, Short))
        Me._cmbField_3.Location = New System.Drawing.Point(216, 224)
        Me._cmbField_3.Name = "_cmbField_3"
        Me._cmbField_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbField_3.Size = New System.Drawing.Size(68, 22)
        Me._cmbField_3.TabIndex = 14
        '
        '_cmbField_2
        '
        Me._cmbField_2.BackColor = System.Drawing.SystemColors.Window
        Me._cmbField_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbField_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbField_2.DropDownWidth = 160
        Me._cmbField_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbField_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbField.SetIndex(Me._cmbField_2, CType(2, Short))
        Me._cmbField_2.Location = New System.Drawing.Point(148, 224)
        Me._cmbField_2.Name = "_cmbField_2"
        Me._cmbField_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbField_2.Size = New System.Drawing.Size(68, 22)
        Me._cmbField_2.TabIndex = 13
        '
        '_cmbField_1
        '
        Me._cmbField_1.BackColor = System.Drawing.SystemColors.Window
        Me._cmbField_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbField_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbField_1.DropDownWidth = 160
        Me._cmbField_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbField_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbField.SetIndex(Me._cmbField_1, CType(1, Short))
        Me._cmbField_1.Location = New System.Drawing.Point(80, 224)
        Me._cmbField_1.Name = "_cmbField_1"
        Me._cmbField_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbField_1.Size = New System.Drawing.Size(68, 22)
        Me._cmbField_1.TabIndex = 12
        '
        '_cmbField_0
        '
        Me._cmbField_0.BackColor = System.Drawing.SystemColors.Window
        Me._cmbField_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmbField_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbField_0.DropDownWidth = 160
        Me._cmbField_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmbField_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbField.SetIndex(Me._cmbField_0, CType(0, Short))
        Me._cmbField_0.Location = New System.Drawing.Point(12, 224)
        Me._cmbField_0.Name = "_cmbField_0"
        Me._cmbField_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmbField_0.Size = New System.Drawing.Size(68, 22)
        Me._cmbField_0.TabIndex = 11
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(8, 536)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(132, 25)
        Me.cmdClose.TabIndex = 23
        Me.cmdClose.Text = "3.           C&lose                "
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdEZGrab
        '
        Me.cmdEZGrab.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEZGrab.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEZGrab.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEZGrab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEZGrab.Location = New System.Drawing.Point(8, 470)
        Me.cmdEZGrab.Name = "cmdEZGrab"
        Me.cmdEZGrab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEZGrab.Size = New System.Drawing.Size(132, 25)
        Me.cmdEZGrab.TabIndex = 20
        Me.cmdEZGrab.Text = "&1. Copy From Clipboard"
        Me.cmdEZGrab.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(517, 33)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "To use it, neatly select a table from a website and copy to the clipboard. Then c" & _
    "lick on Copy From Clip Board, then click on Import Into FreeSCAN. It is recommen" & _
    "ded that you use the Firefox browser."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(4, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(155, 14)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "This field should be treated as:"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(16, 8)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(400, 14)
        Me._Label1_0.TabIndex = 0
        Me._Label1_0.Text = "EZ-Grab is designed to import frequencies from a web site quickly and painlessly." & _
    ""
        '
        'grdField
        '
        Me.grdField.AccessibleDescription = ""
        Me.grdField.AllowUserToAddRows = False
        Me.grdField.AllowUserToOrderColumns = True
        Me.grdField.AllowUserToResizeColumns = False
        Me.grdField.AllowUserToResizeRows = False
        Me.grdField.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdField.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.grdField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdField.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.grdField.Location = New System.Drawing.Point(12, 248)
        Me.grdField.Name = "grdField"
        Me.grdField.ReadOnly = True
        Me.grdField.RowHeadersVisible = False
        Me.grdField.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdField.ShowCellErrors = False
        Me.grdField.ShowEditingIcon = False
        Me.grdField.ShowRowErrors = False
        Me.grdField.Size = New System.Drawing.Size(616, 216)
        Me.grdField.TabIndex = 41
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "       1"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 40
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.ToolTipText = "1"
        Me.DataGridViewTextBoxColumn1.Width = 68
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "       2"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 68
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "       3"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 68
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "       4"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 68
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "       5"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 68
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "       6"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 68
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = "       7"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 68
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column7.HeaderText = "       8"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 68
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.HeaderText = "      9"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 68
        '
        'frmParse
        '
        Me.AcceptButton = Me.cmdClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(651, 580)
        Me.Controls.Add(Me.grdField)
        Me.Controls.Add(Me._cmbField_8)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdImportToSys)
        Me.Controls.Add(Me._cmbField_7)
        Me.Controls.Add(Me._cmbField_6)
        Me.Controls.Add(Me._cmbField_5)
        Me.Controls.Add(Me._cmbField_4)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._cmbField_3)
        Me.Controls.Add(Me._cmbField_2)
        Me.Controls.Add(Me._cmbField_1)
        Me.Controls.Add(Me._cmbField_0)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdEZGrab)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParse"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EZ-Grab"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optDelimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdField As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region 
End Class