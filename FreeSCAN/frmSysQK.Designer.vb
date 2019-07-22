<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSysQK
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
	Public WithEvents cmdAutoSel As System.Windows.Forms.Button
	Public WithEvents lstQK As System.Windows.Forms.ListBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdAllOff As System.Windows.Forms.Button
	Public WithEvents cmdAllOn As System.Windows.Forms.Button
	Public WithEvents _chkQK_16 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_6 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_86 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_96 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_95 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_94 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_85 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_84 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_76 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_75 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_74 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_66 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_65 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_64 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_56 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_55 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_54 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_46 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_45 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_44 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_36 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_35 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_34 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_26 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_25 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_24 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_15 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_14 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_97 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_87 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_77 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_67 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_57 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_47 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_37 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_27 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_99 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_98 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_93 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_92 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_91 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_90 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_89 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_88 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_83 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_82 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_81 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_80 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_79 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_78 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_73 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_72 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_71 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_70 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_69 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_68 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_63 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_62 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_61 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_60 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_59 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_58 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_53 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_52 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_51 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_50 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_49 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_48 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_43 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_42 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_41 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_40 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_39 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_38 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_33 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_32 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_31 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_30 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_29 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_28 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_23 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_22 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_21 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_20 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_19 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_18 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_17 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_13 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_12 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_11 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_10 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_9 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_8 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_7 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkQK_0 As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents lblQK As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents chkQK As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysQK))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdAutoSel = New System.Windows.Forms.Button()
        Me.lstQK = New System.Windows.Forms.ListBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdAllOff = New System.Windows.Forms.Button()
        Me.cmdAllOn = New System.Windows.Forms.Button()
        Me._chkQK_16 = New System.Windows.Forms.CheckBox()
        Me._chkQK_6 = New System.Windows.Forms.CheckBox()
        Me._chkQK_86 = New System.Windows.Forms.CheckBox()
        Me._chkQK_96 = New System.Windows.Forms.CheckBox()
        Me._chkQK_95 = New System.Windows.Forms.CheckBox()
        Me._chkQK_94 = New System.Windows.Forms.CheckBox()
        Me._chkQK_85 = New System.Windows.Forms.CheckBox()
        Me._chkQK_84 = New System.Windows.Forms.CheckBox()
        Me._chkQK_76 = New System.Windows.Forms.CheckBox()
        Me._chkQK_75 = New System.Windows.Forms.CheckBox()
        Me._chkQK_74 = New System.Windows.Forms.CheckBox()
        Me._chkQK_66 = New System.Windows.Forms.CheckBox()
        Me._chkQK_65 = New System.Windows.Forms.CheckBox()
        Me._chkQK_64 = New System.Windows.Forms.CheckBox()
        Me._chkQK_56 = New System.Windows.Forms.CheckBox()
        Me._chkQK_55 = New System.Windows.Forms.CheckBox()
        Me._chkQK_54 = New System.Windows.Forms.CheckBox()
        Me._chkQK_46 = New System.Windows.Forms.CheckBox()
        Me._chkQK_45 = New System.Windows.Forms.CheckBox()
        Me._chkQK_44 = New System.Windows.Forms.CheckBox()
        Me._chkQK_36 = New System.Windows.Forms.CheckBox()
        Me._chkQK_35 = New System.Windows.Forms.CheckBox()
        Me._chkQK_34 = New System.Windows.Forms.CheckBox()
        Me._chkQK_26 = New System.Windows.Forms.CheckBox()
        Me._chkQK_25 = New System.Windows.Forms.CheckBox()
        Me._chkQK_24 = New System.Windows.Forms.CheckBox()
        Me._chkQK_15 = New System.Windows.Forms.CheckBox()
        Me._chkQK_14 = New System.Windows.Forms.CheckBox()
        Me._chkQK_5 = New System.Windows.Forms.CheckBox()
        Me._chkQK_4 = New System.Windows.Forms.CheckBox()
        Me._chkQK_97 = New System.Windows.Forms.CheckBox()
        Me._chkQK_87 = New System.Windows.Forms.CheckBox()
        Me._chkQK_77 = New System.Windows.Forms.CheckBox()
        Me._chkQK_67 = New System.Windows.Forms.CheckBox()
        Me._chkQK_57 = New System.Windows.Forms.CheckBox()
        Me._chkQK_47 = New System.Windows.Forms.CheckBox()
        Me._chkQK_37 = New System.Windows.Forms.CheckBox()
        Me._chkQK_27 = New System.Windows.Forms.CheckBox()
        Me._chkQK_99 = New System.Windows.Forms.CheckBox()
        Me._chkQK_98 = New System.Windows.Forms.CheckBox()
        Me._chkQK_93 = New System.Windows.Forms.CheckBox()
        Me._chkQK_92 = New System.Windows.Forms.CheckBox()
        Me._chkQK_91 = New System.Windows.Forms.CheckBox()
        Me._chkQK_90 = New System.Windows.Forms.CheckBox()
        Me._chkQK_89 = New System.Windows.Forms.CheckBox()
        Me._chkQK_88 = New System.Windows.Forms.CheckBox()
        Me._chkQK_83 = New System.Windows.Forms.CheckBox()
        Me._chkQK_82 = New System.Windows.Forms.CheckBox()
        Me._chkQK_81 = New System.Windows.Forms.CheckBox()
        Me._chkQK_80 = New System.Windows.Forms.CheckBox()
        Me._chkQK_79 = New System.Windows.Forms.CheckBox()
        Me._chkQK_78 = New System.Windows.Forms.CheckBox()
        Me._chkQK_73 = New System.Windows.Forms.CheckBox()
        Me._chkQK_72 = New System.Windows.Forms.CheckBox()
        Me._chkQK_71 = New System.Windows.Forms.CheckBox()
        Me._chkQK_70 = New System.Windows.Forms.CheckBox()
        Me._chkQK_69 = New System.Windows.Forms.CheckBox()
        Me._chkQK_68 = New System.Windows.Forms.CheckBox()
        Me._chkQK_63 = New System.Windows.Forms.CheckBox()
        Me._chkQK_62 = New System.Windows.Forms.CheckBox()
        Me._chkQK_61 = New System.Windows.Forms.CheckBox()
        Me._chkQK_60 = New System.Windows.Forms.CheckBox()
        Me._chkQK_59 = New System.Windows.Forms.CheckBox()
        Me._chkQK_58 = New System.Windows.Forms.CheckBox()
        Me._chkQK_53 = New System.Windows.Forms.CheckBox()
        Me._chkQK_52 = New System.Windows.Forms.CheckBox()
        Me._chkQK_51 = New System.Windows.Forms.CheckBox()
        Me._chkQK_50 = New System.Windows.Forms.CheckBox()
        Me._chkQK_49 = New System.Windows.Forms.CheckBox()
        Me._chkQK_48 = New System.Windows.Forms.CheckBox()
        Me._chkQK_43 = New System.Windows.Forms.CheckBox()
        Me._chkQK_42 = New System.Windows.Forms.CheckBox()
        Me._chkQK_41 = New System.Windows.Forms.CheckBox()
        Me._chkQK_40 = New System.Windows.Forms.CheckBox()
        Me._chkQK_39 = New System.Windows.Forms.CheckBox()
        Me._chkQK_38 = New System.Windows.Forms.CheckBox()
        Me._chkQK_33 = New System.Windows.Forms.CheckBox()
        Me._chkQK_32 = New System.Windows.Forms.CheckBox()
        Me._chkQK_31 = New System.Windows.Forms.CheckBox()
        Me._chkQK_30 = New System.Windows.Forms.CheckBox()
        Me._chkQK_29 = New System.Windows.Forms.CheckBox()
        Me._chkQK_28 = New System.Windows.Forms.CheckBox()
        Me._chkQK_23 = New System.Windows.Forms.CheckBox()
        Me._chkQK_22 = New System.Windows.Forms.CheckBox()
        Me._chkQK_21 = New System.Windows.Forms.CheckBox()
        Me._chkQK_20 = New System.Windows.Forms.CheckBox()
        Me._chkQK_19 = New System.Windows.Forms.CheckBox()
        Me._chkQK_18 = New System.Windows.Forms.CheckBox()
        Me._chkQK_17 = New System.Windows.Forms.CheckBox()
        Me._chkQK_13 = New System.Windows.Forms.CheckBox()
        Me._chkQK_12 = New System.Windows.Forms.CheckBox()
        Me._chkQK_11 = New System.Windows.Forms.CheckBox()
        Me._chkQK_10 = New System.Windows.Forms.CheckBox()
        Me._chkQK_9 = New System.Windows.Forms.CheckBox()
        Me._chkQK_8 = New System.Windows.Forms.CheckBox()
        Me._chkQK_7 = New System.Windows.Forms.CheckBox()
        Me._chkQK_3 = New System.Windows.Forms.CheckBox()
        Me._chkQK_2 = New System.Windows.Forms.CheckBox()
        Me._chkQK_1 = New System.Windows.Forms.CheckBox()
        Me._chkQK_0 = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblQK = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkQK = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        CType(Me.chkQK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAutoSel
        '
        Me.cmdAutoSel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAutoSel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAutoSel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAutoSel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAutoSel.Location = New System.Drawing.Point(208, 412)
        Me.cmdAutoSel.Name = "cmdAutoSel"
        Me.cmdAutoSel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAutoSel.Size = New System.Drawing.Size(93, 25)
        Me.cmdAutoSel.TabIndex = 108
        Me.cmdAutoSel.Text = "&Auto Select"
        Me.cmdAutoSel.UseVisualStyleBackColor = True
        '
        'lstQK
        '
        Me.lstQK.BackColor = System.Drawing.SystemColors.Window
        Me.lstQK.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstQK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstQK.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstQK.ItemHeight = 14
        Me.lstQK.Location = New System.Drawing.Point(475, 72)
        Me.lstQK.Name = "lstQK"
        Me.lstQK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstQK.Size = New System.Drawing.Size(185, 298)
        Me.lstQK.Sorted = True
        Me.lstQK.TabIndex = 107
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(548, 412)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 104
        Me.cmdOK.Text = "O&K"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdAllOff
        '
        Me.cmdAllOff.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAllOff.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAllOff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAllOff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAllOff.Location = New System.Drawing.Point(108, 412)
        Me.cmdAllOff.Name = "cmdAllOff"
        Me.cmdAllOff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAllOff.Size = New System.Drawing.Size(93, 25)
        Me.cmdAllOff.TabIndex = 103
        Me.cmdAllOff.Text = "All &Off"
        Me.cmdAllOff.UseVisualStyleBackColor = True
        '
        'cmdAllOn
        '
        Me.cmdAllOn.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAllOn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAllOn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAllOn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAllOn.Location = New System.Drawing.Point(8, 412)
        Me.cmdAllOn.Name = "cmdAllOn"
        Me.cmdAllOn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAllOn.Size = New System.Drawing.Size(93, 25)
        Me.cmdAllOn.TabIndex = 102
        Me.cmdAllOn.Text = "&All On"
        Me.cmdAllOn.UseVisualStyleBackColor = True
        '
        '_chkQK_16
        '
        Me._chkQK_16.AutoSize = True
        Me._chkQK_16.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_16, CType(16, Short))
        Me._chkQK_16.Location = New System.Drawing.Point(294, 91)
        Me._chkQK_16.Name = "_chkQK_16"
        Me._chkQK_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_16.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_16.TabIndex = 101
        Me._chkQK_16.Text = "1"
        Me._chkQK_16.UseVisualStyleBackColor = False
        '
        '_chkQK_6
        '
        Me._chkQK_6.AutoSize = True
        Me._chkQK_6.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_6, CType(6, Short))
        Me._chkQK_6.Location = New System.Drawing.Point(294, 57)
        Me._chkQK_6.Name = "_chkQK_6"
        Me._chkQK_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_6.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_6.TabIndex = 100
        Me._chkQK_6.Text = "1"
        Me._chkQK_6.UseVisualStyleBackColor = False
        '
        '_chkQK_86
        '
        Me._chkQK_86.AutoSize = True
        Me._chkQK_86.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_86.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_86.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_86.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_86, CType(86, Short))
        Me._chkQK_86.Location = New System.Drawing.Point(294, 331)
        Me._chkQK_86.Name = "_chkQK_86"
        Me._chkQK_86.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_86.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_86.TabIndex = 99
        Me._chkQK_86.Text = "1"
        Me._chkQK_86.UseVisualStyleBackColor = False
        '
        '_chkQK_96
        '
        Me._chkQK_96.AutoSize = True
        Me._chkQK_96.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_96.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_96.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_96.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_96, CType(96, Short))
        Me._chkQK_96.Location = New System.Drawing.Point(294, 365)
        Me._chkQK_96.Name = "_chkQK_96"
        Me._chkQK_96.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_96.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_96.TabIndex = 98
        Me._chkQK_96.Text = "1"
        Me._chkQK_96.UseVisualStyleBackColor = False
        '
        '_chkQK_95
        '
        Me._chkQK_95.AutoSize = True
        Me._chkQK_95.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_95.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_95.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_95.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_95, CType(95, Short))
        Me._chkQK_95.Location = New System.Drawing.Point(248, 365)
        Me._chkQK_95.Name = "_chkQK_95"
        Me._chkQK_95.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_95.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_95.TabIndex = 97
        Me._chkQK_95.Text = "1"
        Me._chkQK_95.UseVisualStyleBackColor = False
        '
        '_chkQK_94
        '
        Me._chkQK_94.AutoSize = True
        Me._chkQK_94.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_94.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_94.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_94.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_94, CType(94, Short))
        Me._chkQK_94.Location = New System.Drawing.Point(202, 365)
        Me._chkQK_94.Name = "_chkQK_94"
        Me._chkQK_94.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_94.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_94.TabIndex = 96
        Me._chkQK_94.Text = "1"
        Me._chkQK_94.UseVisualStyleBackColor = False
        '
        '_chkQK_85
        '
        Me._chkQK_85.AutoSize = True
        Me._chkQK_85.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_85.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_85.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_85.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_85, CType(85, Short))
        Me._chkQK_85.Location = New System.Drawing.Point(248, 331)
        Me._chkQK_85.Name = "_chkQK_85"
        Me._chkQK_85.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_85.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_85.TabIndex = 95
        Me._chkQK_85.Text = "1"
        Me._chkQK_85.UseVisualStyleBackColor = False
        '
        '_chkQK_84
        '
        Me._chkQK_84.AutoSize = True
        Me._chkQK_84.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_84.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_84.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_84.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_84, CType(84, Short))
        Me._chkQK_84.Location = New System.Drawing.Point(202, 331)
        Me._chkQK_84.Name = "_chkQK_84"
        Me._chkQK_84.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_84.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_84.TabIndex = 94
        Me._chkQK_84.Text = "1"
        Me._chkQK_84.UseVisualStyleBackColor = False
        '
        '_chkQK_76
        '
        Me._chkQK_76.AutoSize = True
        Me._chkQK_76.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_76.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_76.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_76.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_76, CType(76, Short))
        Me._chkQK_76.Location = New System.Drawing.Point(294, 296)
        Me._chkQK_76.Name = "_chkQK_76"
        Me._chkQK_76.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_76.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_76.TabIndex = 93
        Me._chkQK_76.Text = "1"
        Me._chkQK_76.UseVisualStyleBackColor = False
        '
        '_chkQK_75
        '
        Me._chkQK_75.AutoSize = True
        Me._chkQK_75.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_75.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_75.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_75.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_75, CType(75, Short))
        Me._chkQK_75.Location = New System.Drawing.Point(248, 296)
        Me._chkQK_75.Name = "_chkQK_75"
        Me._chkQK_75.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_75.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_75.TabIndex = 92
        Me._chkQK_75.Text = "1"
        Me._chkQK_75.UseVisualStyleBackColor = False
        '
        '_chkQK_74
        '
        Me._chkQK_74.AutoSize = True
        Me._chkQK_74.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_74.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_74.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_74.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_74, CType(74, Short))
        Me._chkQK_74.Location = New System.Drawing.Point(202, 296)
        Me._chkQK_74.Name = "_chkQK_74"
        Me._chkQK_74.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_74.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_74.TabIndex = 91
        Me._chkQK_74.Text = "1"
        Me._chkQK_74.UseVisualStyleBackColor = False
        '
        '_chkQK_66
        '
        Me._chkQK_66.AutoSize = True
        Me._chkQK_66.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_66.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_66.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_66, CType(66, Short))
        Me._chkQK_66.Location = New System.Drawing.Point(294, 262)
        Me._chkQK_66.Name = "_chkQK_66"
        Me._chkQK_66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_66.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_66.TabIndex = 90
        Me._chkQK_66.Text = "1"
        Me._chkQK_66.UseVisualStyleBackColor = False
        '
        '_chkQK_65
        '
        Me._chkQK_65.AutoSize = True
        Me._chkQK_65.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_65.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_65.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_65, CType(65, Short))
        Me._chkQK_65.Location = New System.Drawing.Point(248, 262)
        Me._chkQK_65.Name = "_chkQK_65"
        Me._chkQK_65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_65.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_65.TabIndex = 89
        Me._chkQK_65.Text = "1"
        Me._chkQK_65.UseVisualStyleBackColor = False
        '
        '_chkQK_64
        '
        Me._chkQK_64.AutoSize = True
        Me._chkQK_64.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_64.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_64.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_64, CType(64, Short))
        Me._chkQK_64.Location = New System.Drawing.Point(202, 262)
        Me._chkQK_64.Name = "_chkQK_64"
        Me._chkQK_64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_64.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_64.TabIndex = 88
        Me._chkQK_64.Text = "1"
        Me._chkQK_64.UseVisualStyleBackColor = False
        '
        '_chkQK_56
        '
        Me._chkQK_56.AutoSize = True
        Me._chkQK_56.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_56.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_56.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_56.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_56, CType(56, Short))
        Me._chkQK_56.Location = New System.Drawing.Point(294, 228)
        Me._chkQK_56.Name = "_chkQK_56"
        Me._chkQK_56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_56.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_56.TabIndex = 87
        Me._chkQK_56.Text = "1"
        Me._chkQK_56.UseVisualStyleBackColor = False
        '
        '_chkQK_55
        '
        Me._chkQK_55.AutoSize = True
        Me._chkQK_55.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_55.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_55.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_55, CType(55, Short))
        Me._chkQK_55.Location = New System.Drawing.Point(248, 228)
        Me._chkQK_55.Name = "_chkQK_55"
        Me._chkQK_55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_55.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_55.TabIndex = 86
        Me._chkQK_55.Text = "1"
        Me._chkQK_55.UseVisualStyleBackColor = False
        '
        '_chkQK_54
        '
        Me._chkQK_54.AutoSize = True
        Me._chkQK_54.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_54.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_54.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_54.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_54, CType(54, Short))
        Me._chkQK_54.Location = New System.Drawing.Point(202, 228)
        Me._chkQK_54.Name = "_chkQK_54"
        Me._chkQK_54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_54.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_54.TabIndex = 85
        Me._chkQK_54.Text = "1"
        Me._chkQK_54.UseVisualStyleBackColor = False
        '
        '_chkQK_46
        '
        Me._chkQK_46.AutoSize = True
        Me._chkQK_46.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_46.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_46.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_46, CType(46, Short))
        Me._chkQK_46.Location = New System.Drawing.Point(294, 194)
        Me._chkQK_46.Name = "_chkQK_46"
        Me._chkQK_46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_46.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_46.TabIndex = 84
        Me._chkQK_46.Text = "1"
        Me._chkQK_46.UseVisualStyleBackColor = False
        '
        '_chkQK_45
        '
        Me._chkQK_45.AutoSize = True
        Me._chkQK_45.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_45.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_45, CType(45, Short))
        Me._chkQK_45.Location = New System.Drawing.Point(248, 194)
        Me._chkQK_45.Name = "_chkQK_45"
        Me._chkQK_45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_45.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_45.TabIndex = 83
        Me._chkQK_45.Text = "1"
        Me._chkQK_45.UseVisualStyleBackColor = False
        '
        '_chkQK_44
        '
        Me._chkQK_44.AutoSize = True
        Me._chkQK_44.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_44.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_44.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_44, CType(44, Short))
        Me._chkQK_44.Location = New System.Drawing.Point(202, 194)
        Me._chkQK_44.Name = "_chkQK_44"
        Me._chkQK_44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_44.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_44.TabIndex = 82
        Me._chkQK_44.Text = "1"
        Me._chkQK_44.UseVisualStyleBackColor = False
        '
        '_chkQK_36
        '
        Me._chkQK_36.AutoSize = True
        Me._chkQK_36.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_36.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_36, CType(36, Short))
        Me._chkQK_36.Location = New System.Drawing.Point(294, 160)
        Me._chkQK_36.Name = "_chkQK_36"
        Me._chkQK_36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_36.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_36.TabIndex = 81
        Me._chkQK_36.Text = "1"
        Me._chkQK_36.UseVisualStyleBackColor = False
        '
        '_chkQK_35
        '
        Me._chkQK_35.AutoSize = True
        Me._chkQK_35.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_35, CType(35, Short))
        Me._chkQK_35.Location = New System.Drawing.Point(248, 160)
        Me._chkQK_35.Name = "_chkQK_35"
        Me._chkQK_35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_35.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_35.TabIndex = 80
        Me._chkQK_35.Text = "1"
        Me._chkQK_35.UseVisualStyleBackColor = False
        '
        '_chkQK_34
        '
        Me._chkQK_34.AutoSize = True
        Me._chkQK_34.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_34.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_34, CType(34, Short))
        Me._chkQK_34.Location = New System.Drawing.Point(202, 160)
        Me._chkQK_34.Name = "_chkQK_34"
        Me._chkQK_34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_34.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_34.TabIndex = 79
        Me._chkQK_34.Text = "1"
        Me._chkQK_34.UseVisualStyleBackColor = False
        '
        '_chkQK_26
        '
        Me._chkQK_26.AutoSize = True
        Me._chkQK_26.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_26.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_26, CType(26, Short))
        Me._chkQK_26.Location = New System.Drawing.Point(294, 125)
        Me._chkQK_26.Name = "_chkQK_26"
        Me._chkQK_26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_26.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_26.TabIndex = 78
        Me._chkQK_26.Text = "1"
        Me._chkQK_26.UseVisualStyleBackColor = False
        '
        '_chkQK_25
        '
        Me._chkQK_25.AutoSize = True
        Me._chkQK_25.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_25, CType(25, Short))
        Me._chkQK_25.Location = New System.Drawing.Point(248, 125)
        Me._chkQK_25.Name = "_chkQK_25"
        Me._chkQK_25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_25.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_25.TabIndex = 77
        Me._chkQK_25.Text = "1"
        Me._chkQK_25.UseVisualStyleBackColor = False
        '
        '_chkQK_24
        '
        Me._chkQK_24.AutoSize = True
        Me._chkQK_24.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_24, CType(24, Short))
        Me._chkQK_24.Location = New System.Drawing.Point(202, 125)
        Me._chkQK_24.Name = "_chkQK_24"
        Me._chkQK_24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_24.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_24.TabIndex = 76
        Me._chkQK_24.Text = "1"
        Me._chkQK_24.UseVisualStyleBackColor = False
        '
        '_chkQK_15
        '
        Me._chkQK_15.AutoSize = True
        Me._chkQK_15.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_15, CType(15, Short))
        Me._chkQK_15.Location = New System.Drawing.Point(248, 91)
        Me._chkQK_15.Name = "_chkQK_15"
        Me._chkQK_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_15.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_15.TabIndex = 75
        Me._chkQK_15.Text = "1"
        Me._chkQK_15.UseVisualStyleBackColor = False
        '
        '_chkQK_14
        '
        Me._chkQK_14.AutoSize = True
        Me._chkQK_14.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_14, CType(14, Short))
        Me._chkQK_14.Location = New System.Drawing.Point(202, 91)
        Me._chkQK_14.Name = "_chkQK_14"
        Me._chkQK_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_14.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_14.TabIndex = 74
        Me._chkQK_14.Text = "1"
        Me._chkQK_14.UseVisualStyleBackColor = False
        '
        '_chkQK_5
        '
        Me._chkQK_5.AutoSize = True
        Me._chkQK_5.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_5, CType(5, Short))
        Me._chkQK_5.Location = New System.Drawing.Point(248, 57)
        Me._chkQK_5.Name = "_chkQK_5"
        Me._chkQK_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_5.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_5.TabIndex = 73
        Me._chkQK_5.Text = "1"
        Me._chkQK_5.UseVisualStyleBackColor = False
        '
        '_chkQK_4
        '
        Me._chkQK_4.AutoSize = True
        Me._chkQK_4.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_4, CType(4, Short))
        Me._chkQK_4.Location = New System.Drawing.Point(202, 57)
        Me._chkQK_4.Name = "_chkQK_4"
        Me._chkQK_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_4.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_4.TabIndex = 72
        Me._chkQK_4.Text = "1"
        Me._chkQK_4.UseVisualStyleBackColor = False
        '
        '_chkQK_97
        '
        Me._chkQK_97.AutoSize = True
        Me._chkQK_97.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_97.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_97.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_97.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_97, CType(97, Short))
        Me._chkQK_97.Location = New System.Drawing.Point(340, 365)
        Me._chkQK_97.Name = "_chkQK_97"
        Me._chkQK_97.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_97.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_97.TabIndex = 71
        Me._chkQK_97.Text = "1"
        Me._chkQK_97.UseVisualStyleBackColor = False
        '
        '_chkQK_87
        '
        Me._chkQK_87.AutoSize = True
        Me._chkQK_87.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_87.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_87.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_87.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_87, CType(87, Short))
        Me._chkQK_87.Location = New System.Drawing.Point(340, 331)
        Me._chkQK_87.Name = "_chkQK_87"
        Me._chkQK_87.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_87.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_87.TabIndex = 70
        Me._chkQK_87.Text = "1"
        Me._chkQK_87.UseVisualStyleBackColor = False
        '
        '_chkQK_77
        '
        Me._chkQK_77.AutoSize = True
        Me._chkQK_77.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_77.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_77.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_77.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_77, CType(77, Short))
        Me._chkQK_77.Location = New System.Drawing.Point(340, 296)
        Me._chkQK_77.Name = "_chkQK_77"
        Me._chkQK_77.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_77.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_77.TabIndex = 69
        Me._chkQK_77.Text = "1"
        Me._chkQK_77.UseVisualStyleBackColor = False
        '
        '_chkQK_67
        '
        Me._chkQK_67.AutoSize = True
        Me._chkQK_67.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_67.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_67.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_67, CType(67, Short))
        Me._chkQK_67.Location = New System.Drawing.Point(340, 262)
        Me._chkQK_67.Name = "_chkQK_67"
        Me._chkQK_67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_67.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_67.TabIndex = 68
        Me._chkQK_67.Text = "1"
        Me._chkQK_67.UseVisualStyleBackColor = False
        '
        '_chkQK_57
        '
        Me._chkQK_57.AutoSize = True
        Me._chkQK_57.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_57.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_57.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_57.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_57, CType(57, Short))
        Me._chkQK_57.Location = New System.Drawing.Point(340, 228)
        Me._chkQK_57.Name = "_chkQK_57"
        Me._chkQK_57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_57.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_57.TabIndex = 67
        Me._chkQK_57.Text = "1"
        Me._chkQK_57.UseVisualStyleBackColor = False
        '
        '_chkQK_47
        '
        Me._chkQK_47.AutoSize = True
        Me._chkQK_47.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_47.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_47.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_47, CType(47, Short))
        Me._chkQK_47.Location = New System.Drawing.Point(340, 194)
        Me._chkQK_47.Name = "_chkQK_47"
        Me._chkQK_47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_47.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_47.TabIndex = 66
        Me._chkQK_47.Text = "1"
        Me._chkQK_47.UseVisualStyleBackColor = False
        '
        '_chkQK_37
        '
        Me._chkQK_37.AutoSize = True
        Me._chkQK_37.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_37.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_37, CType(37, Short))
        Me._chkQK_37.Location = New System.Drawing.Point(340, 160)
        Me._chkQK_37.Name = "_chkQK_37"
        Me._chkQK_37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_37.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_37.TabIndex = 65
        Me._chkQK_37.Text = "1"
        Me._chkQK_37.UseVisualStyleBackColor = False
        '
        '_chkQK_27
        '
        Me._chkQK_27.AutoSize = True
        Me._chkQK_27.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_27, CType(27, Short))
        Me._chkQK_27.Location = New System.Drawing.Point(340, 125)
        Me._chkQK_27.Name = "_chkQK_27"
        Me._chkQK_27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_27.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_27.TabIndex = 64
        Me._chkQK_27.Text = "1"
        Me._chkQK_27.UseVisualStyleBackColor = False
        '
        '_chkQK_99
        '
        Me._chkQK_99.AutoSize = True
        Me._chkQK_99.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_99.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_99.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_99.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_99, CType(99, Short))
        Me._chkQK_99.Location = New System.Drawing.Point(432, 365)
        Me._chkQK_99.Name = "_chkQK_99"
        Me._chkQK_99.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_99.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_99.TabIndex = 63
        Me._chkQK_99.Text = "1"
        Me._chkQK_99.UseVisualStyleBackColor = False
        '
        '_chkQK_98
        '
        Me._chkQK_98.AutoSize = True
        Me._chkQK_98.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_98.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_98.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_98.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_98, CType(98, Short))
        Me._chkQK_98.Location = New System.Drawing.Point(386, 365)
        Me._chkQK_98.Name = "_chkQK_98"
        Me._chkQK_98.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_98.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_98.TabIndex = 62
        Me._chkQK_98.Text = "1"
        Me._chkQK_98.UseVisualStyleBackColor = False
        '
        '_chkQK_93
        '
        Me._chkQK_93.AutoSize = True
        Me._chkQK_93.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_93.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_93.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_93.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_93, CType(93, Short))
        Me._chkQK_93.Location = New System.Drawing.Point(156, 365)
        Me._chkQK_93.Name = "_chkQK_93"
        Me._chkQK_93.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_93.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_93.TabIndex = 61
        Me._chkQK_93.Text = "1"
        Me._chkQK_93.UseVisualStyleBackColor = False
        '
        '_chkQK_92
        '
        Me._chkQK_92.AutoSize = True
        Me._chkQK_92.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_92.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_92.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_92.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_92, CType(92, Short))
        Me._chkQK_92.Location = New System.Drawing.Point(110, 365)
        Me._chkQK_92.Name = "_chkQK_92"
        Me._chkQK_92.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_92.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_92.TabIndex = 60
        Me._chkQK_92.Text = "1"
        Me._chkQK_92.UseVisualStyleBackColor = False
        '
        '_chkQK_91
        '
        Me._chkQK_91.AutoSize = True
        Me._chkQK_91.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_91.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_91.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_91.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_91, CType(91, Short))
        Me._chkQK_91.Location = New System.Drawing.Point(64, 365)
        Me._chkQK_91.Name = "_chkQK_91"
        Me._chkQK_91.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_91.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_91.TabIndex = 59
        Me._chkQK_91.Text = "1"
        Me._chkQK_91.UseVisualStyleBackColor = False
        '
        '_chkQK_90
        '
        Me._chkQK_90.AutoSize = True
        Me._chkQK_90.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_90.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_90.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_90, CType(90, Short))
        Me._chkQK_90.Location = New System.Drawing.Point(18, 365)
        Me._chkQK_90.Name = "_chkQK_90"
        Me._chkQK_90.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_90.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_90.TabIndex = 58
        Me._chkQK_90.Text = "1"
        Me._chkQK_90.UseVisualStyleBackColor = False
        '
        '_chkQK_89
        '
        Me._chkQK_89.AutoSize = True
        Me._chkQK_89.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_89.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_89.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_89.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_89, CType(89, Short))
        Me._chkQK_89.Location = New System.Drawing.Point(432, 330)
        Me._chkQK_89.Name = "_chkQK_89"
        Me._chkQK_89.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_89.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_89.TabIndex = 57
        Me._chkQK_89.Text = "1"
        Me._chkQK_89.UseVisualStyleBackColor = False
        '
        '_chkQK_88
        '
        Me._chkQK_88.AutoSize = True
        Me._chkQK_88.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_88.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_88.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_88.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_88, CType(88, Short))
        Me._chkQK_88.Location = New System.Drawing.Point(386, 331)
        Me._chkQK_88.Name = "_chkQK_88"
        Me._chkQK_88.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_88.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_88.TabIndex = 56
        Me._chkQK_88.Text = "1"
        Me._chkQK_88.UseVisualStyleBackColor = False
        '
        '_chkQK_83
        '
        Me._chkQK_83.AutoSize = True
        Me._chkQK_83.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_83.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_83.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_83.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_83, CType(83, Short))
        Me._chkQK_83.Location = New System.Drawing.Point(156, 331)
        Me._chkQK_83.Name = "_chkQK_83"
        Me._chkQK_83.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_83.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_83.TabIndex = 55
        Me._chkQK_83.Text = "1"
        Me._chkQK_83.UseVisualStyleBackColor = False
        '
        '_chkQK_82
        '
        Me._chkQK_82.AutoSize = True
        Me._chkQK_82.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_82.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_82.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_82.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_82, CType(82, Short))
        Me._chkQK_82.Location = New System.Drawing.Point(110, 331)
        Me._chkQK_82.Name = "_chkQK_82"
        Me._chkQK_82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_82.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_82.TabIndex = 54
        Me._chkQK_82.Text = "1"
        Me._chkQK_82.UseVisualStyleBackColor = False
        '
        '_chkQK_81
        '
        Me._chkQK_81.AutoSize = True
        Me._chkQK_81.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_81.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_81.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_81.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_81, CType(81, Short))
        Me._chkQK_81.Location = New System.Drawing.Point(64, 331)
        Me._chkQK_81.Name = "_chkQK_81"
        Me._chkQK_81.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_81.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_81.TabIndex = 53
        Me._chkQK_81.Text = "1"
        Me._chkQK_81.UseVisualStyleBackColor = False
        '
        '_chkQK_80
        '
        Me._chkQK_80.AutoSize = True
        Me._chkQK_80.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_80.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_80.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_80.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_80, CType(80, Short))
        Me._chkQK_80.Location = New System.Drawing.Point(18, 331)
        Me._chkQK_80.Name = "_chkQK_80"
        Me._chkQK_80.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_80.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_80.TabIndex = 52
        Me._chkQK_80.Text = "1"
        Me._chkQK_80.UseVisualStyleBackColor = False
        '
        '_chkQK_79
        '
        Me._chkQK_79.AutoSize = True
        Me._chkQK_79.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_79.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_79.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_79.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_79, CType(79, Short))
        Me._chkQK_79.Location = New System.Drawing.Point(432, 295)
        Me._chkQK_79.Name = "_chkQK_79"
        Me._chkQK_79.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_79.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_79.TabIndex = 51
        Me._chkQK_79.Text = "1"
        Me._chkQK_79.UseVisualStyleBackColor = False
        '
        '_chkQK_78
        '
        Me._chkQK_78.AutoSize = True
        Me._chkQK_78.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_78.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_78.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_78.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_78, CType(78, Short))
        Me._chkQK_78.Location = New System.Drawing.Point(386, 296)
        Me._chkQK_78.Name = "_chkQK_78"
        Me._chkQK_78.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_78.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_78.TabIndex = 50
        Me._chkQK_78.Text = "1"
        Me._chkQK_78.UseVisualStyleBackColor = False
        '
        '_chkQK_73
        '
        Me._chkQK_73.AutoSize = True
        Me._chkQK_73.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_73.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_73.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_73.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_73, CType(73, Short))
        Me._chkQK_73.Location = New System.Drawing.Point(156, 296)
        Me._chkQK_73.Name = "_chkQK_73"
        Me._chkQK_73.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_73.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_73.TabIndex = 49
        Me._chkQK_73.Text = "1"
        Me._chkQK_73.UseVisualStyleBackColor = False
        '
        '_chkQK_72
        '
        Me._chkQK_72.AutoSize = True
        Me._chkQK_72.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_72.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_72.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_72.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_72, CType(72, Short))
        Me._chkQK_72.Location = New System.Drawing.Point(110, 296)
        Me._chkQK_72.Name = "_chkQK_72"
        Me._chkQK_72.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_72.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_72.TabIndex = 48
        Me._chkQK_72.Text = "1"
        Me._chkQK_72.UseVisualStyleBackColor = False
        '
        '_chkQK_71
        '
        Me._chkQK_71.AutoSize = True
        Me._chkQK_71.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_71.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_71.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_71.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_71, CType(71, Short))
        Me._chkQK_71.Location = New System.Drawing.Point(64, 296)
        Me._chkQK_71.Name = "_chkQK_71"
        Me._chkQK_71.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_71.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_71.TabIndex = 47
        Me._chkQK_71.Text = "1"
        Me._chkQK_71.UseVisualStyleBackColor = False
        '
        '_chkQK_70
        '
        Me._chkQK_70.AutoSize = True
        Me._chkQK_70.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_70.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_70.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_70.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_70, CType(70, Short))
        Me._chkQK_70.Location = New System.Drawing.Point(18, 296)
        Me._chkQK_70.Name = "_chkQK_70"
        Me._chkQK_70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_70.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_70.TabIndex = 46
        Me._chkQK_70.Text = "1"
        Me._chkQK_70.UseVisualStyleBackColor = False
        '
        '_chkQK_69
        '
        Me._chkQK_69.AutoSize = True
        Me._chkQK_69.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_69.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_69.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_69.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_69, CType(69, Short))
        Me._chkQK_69.Location = New System.Drawing.Point(432, 261)
        Me._chkQK_69.Name = "_chkQK_69"
        Me._chkQK_69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_69.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_69.TabIndex = 45
        Me._chkQK_69.Text = "1"
        Me._chkQK_69.UseVisualStyleBackColor = False
        '
        '_chkQK_68
        '
        Me._chkQK_68.AutoSize = True
        Me._chkQK_68.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_68.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_68.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_68.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_68, CType(68, Short))
        Me._chkQK_68.Location = New System.Drawing.Point(386, 262)
        Me._chkQK_68.Name = "_chkQK_68"
        Me._chkQK_68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_68.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_68.TabIndex = 44
        Me._chkQK_68.Text = "1"
        Me._chkQK_68.UseVisualStyleBackColor = False
        '
        '_chkQK_63
        '
        Me._chkQK_63.AutoSize = True
        Me._chkQK_63.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_63.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_63.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_63, CType(63, Short))
        Me._chkQK_63.Location = New System.Drawing.Point(156, 262)
        Me._chkQK_63.Name = "_chkQK_63"
        Me._chkQK_63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_63.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_63.TabIndex = 43
        Me._chkQK_63.Text = "1"
        Me._chkQK_63.UseVisualStyleBackColor = False
        '
        '_chkQK_62
        '
        Me._chkQK_62.AutoSize = True
        Me._chkQK_62.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_62.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_62.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_62, CType(62, Short))
        Me._chkQK_62.Location = New System.Drawing.Point(110, 262)
        Me._chkQK_62.Name = "_chkQK_62"
        Me._chkQK_62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_62.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_62.TabIndex = 42
        Me._chkQK_62.Text = "1"
        Me._chkQK_62.UseVisualStyleBackColor = False
        '
        '_chkQK_61
        '
        Me._chkQK_61.AutoSize = True
        Me._chkQK_61.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_61.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_61.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_61, CType(61, Short))
        Me._chkQK_61.Location = New System.Drawing.Point(64, 262)
        Me._chkQK_61.Name = "_chkQK_61"
        Me._chkQK_61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_61.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_61.TabIndex = 41
        Me._chkQK_61.Text = "1"
        Me._chkQK_61.UseVisualStyleBackColor = False
        '
        '_chkQK_60
        '
        Me._chkQK_60.AutoSize = True
        Me._chkQK_60.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_60.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_60.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_60, CType(60, Short))
        Me._chkQK_60.Location = New System.Drawing.Point(18, 262)
        Me._chkQK_60.Name = "_chkQK_60"
        Me._chkQK_60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_60.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_60.TabIndex = 40
        Me._chkQK_60.Text = "1"
        Me._chkQK_60.UseVisualStyleBackColor = False
        '
        '_chkQK_59
        '
        Me._chkQK_59.AutoSize = True
        Me._chkQK_59.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_59.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_59.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_59, CType(59, Short))
        Me._chkQK_59.Location = New System.Drawing.Point(432, 227)
        Me._chkQK_59.Name = "_chkQK_59"
        Me._chkQK_59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_59.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_59.TabIndex = 39
        Me._chkQK_59.Text = "1"
        Me._chkQK_59.UseVisualStyleBackColor = False
        '
        '_chkQK_58
        '
        Me._chkQK_58.AutoSize = True
        Me._chkQK_58.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_58.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_58.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_58, CType(58, Short))
        Me._chkQK_58.Location = New System.Drawing.Point(386, 228)
        Me._chkQK_58.Name = "_chkQK_58"
        Me._chkQK_58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_58.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_58.TabIndex = 38
        Me._chkQK_58.Text = "1"
        Me._chkQK_58.UseVisualStyleBackColor = False
        '
        '_chkQK_53
        '
        Me._chkQK_53.AutoSize = True
        Me._chkQK_53.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_53.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_53.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_53, CType(53, Short))
        Me._chkQK_53.Location = New System.Drawing.Point(156, 228)
        Me._chkQK_53.Name = "_chkQK_53"
        Me._chkQK_53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_53.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_53.TabIndex = 37
        Me._chkQK_53.Text = "1"
        Me._chkQK_53.UseVisualStyleBackColor = False
        '
        '_chkQK_52
        '
        Me._chkQK_52.AutoSize = True
        Me._chkQK_52.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_52.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_52.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_52.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_52, CType(52, Short))
        Me._chkQK_52.Location = New System.Drawing.Point(110, 228)
        Me._chkQK_52.Name = "_chkQK_52"
        Me._chkQK_52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_52.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_52.TabIndex = 36
        Me._chkQK_52.Text = "1"
        Me._chkQK_52.UseVisualStyleBackColor = False
        '
        '_chkQK_51
        '
        Me._chkQK_51.AutoSize = True
        Me._chkQK_51.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_51.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_51.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_51.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_51, CType(51, Short))
        Me._chkQK_51.Location = New System.Drawing.Point(64, 228)
        Me._chkQK_51.Name = "_chkQK_51"
        Me._chkQK_51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_51.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_51.TabIndex = 35
        Me._chkQK_51.Text = "1"
        Me._chkQK_51.UseVisualStyleBackColor = False
        '
        '_chkQK_50
        '
        Me._chkQK_50.AutoSize = True
        Me._chkQK_50.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_50.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_50.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_50, CType(50, Short))
        Me._chkQK_50.Location = New System.Drawing.Point(18, 228)
        Me._chkQK_50.Name = "_chkQK_50"
        Me._chkQK_50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_50.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_50.TabIndex = 34
        Me._chkQK_50.Text = "1"
        Me._chkQK_50.UseVisualStyleBackColor = False
        '
        '_chkQK_49
        '
        Me._chkQK_49.AutoSize = True
        Me._chkQK_49.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_49.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_49.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_49, CType(49, Short))
        Me._chkQK_49.Location = New System.Drawing.Point(432, 193)
        Me._chkQK_49.Name = "_chkQK_49"
        Me._chkQK_49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_49.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_49.TabIndex = 33
        Me._chkQK_49.Text = "1"
        Me._chkQK_49.UseVisualStyleBackColor = False
        '
        '_chkQK_48
        '
        Me._chkQK_48.AutoSize = True
        Me._chkQK_48.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_48.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_48.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_48, CType(48, Short))
        Me._chkQK_48.Location = New System.Drawing.Point(386, 194)
        Me._chkQK_48.Name = "_chkQK_48"
        Me._chkQK_48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_48.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_48.TabIndex = 32
        Me._chkQK_48.Text = "1"
        Me._chkQK_48.UseVisualStyleBackColor = False
        '
        '_chkQK_43
        '
        Me._chkQK_43.AutoSize = True
        Me._chkQK_43.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_43.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_43, CType(43, Short))
        Me._chkQK_43.Location = New System.Drawing.Point(156, 194)
        Me._chkQK_43.Name = "_chkQK_43"
        Me._chkQK_43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_43.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_43.TabIndex = 31
        Me._chkQK_43.Text = "1"
        Me._chkQK_43.UseVisualStyleBackColor = False
        '
        '_chkQK_42
        '
        Me._chkQK_42.AutoSize = True
        Me._chkQK_42.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_42, CType(42, Short))
        Me._chkQK_42.Location = New System.Drawing.Point(110, 194)
        Me._chkQK_42.Name = "_chkQK_42"
        Me._chkQK_42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_42.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_42.TabIndex = 30
        Me._chkQK_42.Text = "1"
        Me._chkQK_42.UseVisualStyleBackColor = False
        '
        '_chkQK_41
        '
        Me._chkQK_41.AutoSize = True
        Me._chkQK_41.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_41, CType(41, Short))
        Me._chkQK_41.Location = New System.Drawing.Point(64, 194)
        Me._chkQK_41.Name = "_chkQK_41"
        Me._chkQK_41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_41.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_41.TabIndex = 29
        Me._chkQK_41.Text = "1"
        Me._chkQK_41.UseVisualStyleBackColor = False
        '
        '_chkQK_40
        '
        Me._chkQK_40.AutoSize = True
        Me._chkQK_40.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_40.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_40, CType(40, Short))
        Me._chkQK_40.Location = New System.Drawing.Point(18, 194)
        Me._chkQK_40.Name = "_chkQK_40"
        Me._chkQK_40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_40.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_40.TabIndex = 28
        Me._chkQK_40.Text = "1"
        Me._chkQK_40.UseVisualStyleBackColor = False
        '
        '_chkQK_39
        '
        Me._chkQK_39.AutoSize = True
        Me._chkQK_39.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_39, CType(39, Short))
        Me._chkQK_39.Location = New System.Drawing.Point(432, 160)
        Me._chkQK_39.Name = "_chkQK_39"
        Me._chkQK_39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_39.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_39.TabIndex = 27
        Me._chkQK_39.Text = "1"
        Me._chkQK_39.UseVisualStyleBackColor = False
        '
        '_chkQK_38
        '
        Me._chkQK_38.AutoSize = True
        Me._chkQK_38.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_38.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_38, CType(38, Short))
        Me._chkQK_38.Location = New System.Drawing.Point(386, 160)
        Me._chkQK_38.Name = "_chkQK_38"
        Me._chkQK_38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_38.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_38.TabIndex = 26
        Me._chkQK_38.Text = "1"
        Me._chkQK_38.UseVisualStyleBackColor = False
        '
        '_chkQK_33
        '
        Me._chkQK_33.AutoSize = True
        Me._chkQK_33.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_33.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_33, CType(33, Short))
        Me._chkQK_33.Location = New System.Drawing.Point(156, 160)
        Me._chkQK_33.Name = "_chkQK_33"
        Me._chkQK_33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_33.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_33.TabIndex = 25
        Me._chkQK_33.Text = "1"
        Me._chkQK_33.UseVisualStyleBackColor = False
        '
        '_chkQK_32
        '
        Me._chkQK_32.AutoSize = True
        Me._chkQK_32.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_32, CType(32, Short))
        Me._chkQK_32.Location = New System.Drawing.Point(110, 160)
        Me._chkQK_32.Name = "_chkQK_32"
        Me._chkQK_32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_32.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_32.TabIndex = 24
        Me._chkQK_32.Text = "1"
        Me._chkQK_32.UseVisualStyleBackColor = False
        '
        '_chkQK_31
        '
        Me._chkQK_31.AutoSize = True
        Me._chkQK_31.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_31.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_31, CType(31, Short))
        Me._chkQK_31.Location = New System.Drawing.Point(64, 160)
        Me._chkQK_31.Name = "_chkQK_31"
        Me._chkQK_31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_31.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_31.TabIndex = 23
        Me._chkQK_31.Text = "1"
        Me._chkQK_31.UseVisualStyleBackColor = False
        '
        '_chkQK_30
        '
        Me._chkQK_30.AutoSize = True
        Me._chkQK_30.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_30.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_30, CType(30, Short))
        Me._chkQK_30.Location = New System.Drawing.Point(18, 160)
        Me._chkQK_30.Name = "_chkQK_30"
        Me._chkQK_30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_30.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_30.TabIndex = 22
        Me._chkQK_30.Text = "1"
        Me._chkQK_30.UseVisualStyleBackColor = False
        '
        '_chkQK_29
        '
        Me._chkQK_29.AutoSize = True
        Me._chkQK_29.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_29, CType(29, Short))
        Me._chkQK_29.Location = New System.Drawing.Point(432, 124)
        Me._chkQK_29.Name = "_chkQK_29"
        Me._chkQK_29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_29.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_29.TabIndex = 21
        Me._chkQK_29.Text = "1"
        Me._chkQK_29.UseVisualStyleBackColor = False
        '
        '_chkQK_28
        '
        Me._chkQK_28.AutoSize = True
        Me._chkQK_28.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_28, CType(28, Short))
        Me._chkQK_28.Location = New System.Drawing.Point(386, 125)
        Me._chkQK_28.Name = "_chkQK_28"
        Me._chkQK_28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_28.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_28.TabIndex = 20
        Me._chkQK_28.Text = "1"
        Me._chkQK_28.UseVisualStyleBackColor = False
        '
        '_chkQK_23
        '
        Me._chkQK_23.AutoSize = True
        Me._chkQK_23.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_23, CType(23, Short))
        Me._chkQK_23.Location = New System.Drawing.Point(156, 125)
        Me._chkQK_23.Name = "_chkQK_23"
        Me._chkQK_23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_23.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_23.TabIndex = 19
        Me._chkQK_23.Text = "1"
        Me._chkQK_23.UseVisualStyleBackColor = False
        '
        '_chkQK_22
        '
        Me._chkQK_22.AutoSize = True
        Me._chkQK_22.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_22, CType(22, Short))
        Me._chkQK_22.Location = New System.Drawing.Point(110, 125)
        Me._chkQK_22.Name = "_chkQK_22"
        Me._chkQK_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_22.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_22.TabIndex = 18
        Me._chkQK_22.Text = "1"
        Me._chkQK_22.UseVisualStyleBackColor = False
        '
        '_chkQK_21
        '
        Me._chkQK_21.AutoSize = True
        Me._chkQK_21.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_21, CType(21, Short))
        Me._chkQK_21.Location = New System.Drawing.Point(64, 125)
        Me._chkQK_21.Name = "_chkQK_21"
        Me._chkQK_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_21.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_21.TabIndex = 17
        Me._chkQK_21.Text = "1"
        Me._chkQK_21.UseVisualStyleBackColor = False
        '
        '_chkQK_20
        '
        Me._chkQK_20.AutoSize = True
        Me._chkQK_20.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_20, CType(20, Short))
        Me._chkQK_20.Location = New System.Drawing.Point(18, 125)
        Me._chkQK_20.Name = "_chkQK_20"
        Me._chkQK_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_20.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_20.TabIndex = 16
        Me._chkQK_20.Text = "1"
        Me._chkQK_20.UseVisualStyleBackColor = False
        '
        '_chkQK_19
        '
        Me._chkQK_19.AutoSize = True
        Me._chkQK_19.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_19, CType(19, Short))
        Me._chkQK_19.Location = New System.Drawing.Point(432, 90)
        Me._chkQK_19.Name = "_chkQK_19"
        Me._chkQK_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_19.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_19.TabIndex = 15
        Me._chkQK_19.Text = "1"
        Me._chkQK_19.UseVisualStyleBackColor = False
        '
        '_chkQK_18
        '
        Me._chkQK_18.AutoSize = True
        Me._chkQK_18.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_18, CType(18, Short))
        Me._chkQK_18.Location = New System.Drawing.Point(386, 90)
        Me._chkQK_18.Name = "_chkQK_18"
        Me._chkQK_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_18.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_18.TabIndex = 14
        Me._chkQK_18.Text = "1"
        Me._chkQK_18.UseVisualStyleBackColor = False
        '
        '_chkQK_17
        '
        Me._chkQK_17.AutoSize = True
        Me._chkQK_17.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_17, CType(17, Short))
        Me._chkQK_17.Location = New System.Drawing.Point(340, 91)
        Me._chkQK_17.Name = "_chkQK_17"
        Me._chkQK_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_17.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_17.TabIndex = 13
        Me._chkQK_17.Text = "1"
        Me._chkQK_17.UseVisualStyleBackColor = False
        '
        '_chkQK_13
        '
        Me._chkQK_13.AutoSize = True
        Me._chkQK_13.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_13, CType(13, Short))
        Me._chkQK_13.Location = New System.Drawing.Point(156, 91)
        Me._chkQK_13.Name = "_chkQK_13"
        Me._chkQK_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_13.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_13.TabIndex = 12
        Me._chkQK_13.Text = "1"
        Me._chkQK_13.UseVisualStyleBackColor = False
        '
        '_chkQK_12
        '
        Me._chkQK_12.AutoSize = True
        Me._chkQK_12.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_12, CType(12, Short))
        Me._chkQK_12.Location = New System.Drawing.Point(110, 91)
        Me._chkQK_12.Name = "_chkQK_12"
        Me._chkQK_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_12.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_12.TabIndex = 11
        Me._chkQK_12.Text = "1"
        Me._chkQK_12.UseVisualStyleBackColor = False
        '
        '_chkQK_11
        '
        Me._chkQK_11.AutoSize = True
        Me._chkQK_11.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_11, CType(11, Short))
        Me._chkQK_11.Location = New System.Drawing.Point(64, 91)
        Me._chkQK_11.Name = "_chkQK_11"
        Me._chkQK_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_11.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_11.TabIndex = 10
        Me._chkQK_11.Text = "1"
        Me._chkQK_11.UseVisualStyleBackColor = False
        '
        '_chkQK_10
        '
        Me._chkQK_10.AutoSize = True
        Me._chkQK_10.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_10, CType(10, Short))
        Me._chkQK_10.Location = New System.Drawing.Point(18, 91)
        Me._chkQK_10.Name = "_chkQK_10"
        Me._chkQK_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_10.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_10.TabIndex = 9
        Me._chkQK_10.Text = "1"
        Me._chkQK_10.UseVisualStyleBackColor = False
        '
        '_chkQK_9
        '
        Me._chkQK_9.AutoSize = True
        Me._chkQK_9.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_9, CType(9, Short))
        Me._chkQK_9.Location = New System.Drawing.Point(432, 57)
        Me._chkQK_9.Name = "_chkQK_9"
        Me._chkQK_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_9.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_9.TabIndex = 8
        Me._chkQK_9.Text = "1"
        Me._chkQK_9.UseVisualStyleBackColor = False
        '
        '_chkQK_8
        '
        Me._chkQK_8.AutoSize = True
        Me._chkQK_8.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_8, CType(8, Short))
        Me._chkQK_8.Location = New System.Drawing.Point(386, 57)
        Me._chkQK_8.Name = "_chkQK_8"
        Me._chkQK_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_8.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_8.TabIndex = 7
        Me._chkQK_8.Text = "1"
        Me._chkQK_8.UseVisualStyleBackColor = False
        '
        '_chkQK_7
        '
        Me._chkQK_7.AutoSize = True
        Me._chkQK_7.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_7, CType(7, Short))
        Me._chkQK_7.Location = New System.Drawing.Point(340, 57)
        Me._chkQK_7.Name = "_chkQK_7"
        Me._chkQK_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_7.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_7.TabIndex = 6
        Me._chkQK_7.Text = "1"
        Me._chkQK_7.UseVisualStyleBackColor = False
        '
        '_chkQK_3
        '
        Me._chkQK_3.AutoSize = True
        Me._chkQK_3.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_3, CType(3, Short))
        Me._chkQK_3.Location = New System.Drawing.Point(156, 57)
        Me._chkQK_3.Name = "_chkQK_3"
        Me._chkQK_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_3.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_3.TabIndex = 5
        Me._chkQK_3.Text = "1"
        Me._chkQK_3.UseVisualStyleBackColor = False
        '
        '_chkQK_2
        '
        Me._chkQK_2.AutoSize = True
        Me._chkQK_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_2, CType(2, Short))
        Me._chkQK_2.Location = New System.Drawing.Point(110, 57)
        Me._chkQK_2.Name = "_chkQK_2"
        Me._chkQK_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_2.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_2.TabIndex = 4
        Me._chkQK_2.Text = "1"
        Me._chkQK_2.UseVisualStyleBackColor = False
        '
        '_chkQK_1
        '
        Me._chkQK_1.AutoSize = True
        Me._chkQK_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_1, CType(1, Short))
        Me._chkQK_1.Location = New System.Drawing.Point(64, 57)
        Me._chkQK_1.Name = "_chkQK_1"
        Me._chkQK_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_1.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_1.TabIndex = 3
        Me._chkQK_1.Text = "1"
        Me._chkQK_1.UseVisualStyleBackColor = False
        '
        '_chkQK_0
        '
        Me._chkQK_0.AutoSize = True
        Me._chkQK_0.BackColor = System.Drawing.SystemColors.Control
        Me._chkQK_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkQK_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkQK_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQK.SetIndex(Me._chkQK_0, CType(0, Short))
        Me._chkQK_0.Location = New System.Drawing.Point(18, 57)
        Me._chkQK_0.Name = "_chkQK_0"
        Me._chkQK_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkQK_0.Size = New System.Drawing.Size(32, 18)
        Me._chkQK_0.TabIndex = 2
        Me._chkQK_0.Text = "1"
        Me._chkQK_0.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(456, 412)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Ca&ncel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lblQK
        '
        Me.lblQK.BackColor = System.Drawing.SystemColors.Control
        Me.lblQK.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblQK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQK.Location = New System.Drawing.Point(603, 51)
        Me.lblQK.Name = "lblQK"
        Me.lblQK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQK.Size = New System.Drawing.Size(25, 17)
        Me.lblQK.TabIndex = 106
        Me.lblQK.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(475, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Systems assigned to QK:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(654, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'chkQK
        '
        '
        'frmSysQK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(670, 451)
        Me.Controls.Add(Me.cmdAutoSel)
        Me.Controls.Add(Me.lstQK)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdAllOff)
        Me.Controls.Add(Me.cmdAllOn)
        Me.Controls.Add(Me._chkQK_16)
        Me.Controls.Add(Me._chkQK_6)
        Me.Controls.Add(Me._chkQK_86)
        Me.Controls.Add(Me._chkQK_96)
        Me.Controls.Add(Me._chkQK_95)
        Me.Controls.Add(Me._chkQK_94)
        Me.Controls.Add(Me._chkQK_85)
        Me.Controls.Add(Me._chkQK_84)
        Me.Controls.Add(Me._chkQK_76)
        Me.Controls.Add(Me._chkQK_75)
        Me.Controls.Add(Me._chkQK_74)
        Me.Controls.Add(Me._chkQK_66)
        Me.Controls.Add(Me._chkQK_65)
        Me.Controls.Add(Me._chkQK_64)
        Me.Controls.Add(Me._chkQK_56)
        Me.Controls.Add(Me._chkQK_55)
        Me.Controls.Add(Me._chkQK_54)
        Me.Controls.Add(Me._chkQK_46)
        Me.Controls.Add(Me._chkQK_45)
        Me.Controls.Add(Me._chkQK_44)
        Me.Controls.Add(Me._chkQK_36)
        Me.Controls.Add(Me._chkQK_35)
        Me.Controls.Add(Me._chkQK_34)
        Me.Controls.Add(Me._chkQK_26)
        Me.Controls.Add(Me._chkQK_25)
        Me.Controls.Add(Me._chkQK_24)
        Me.Controls.Add(Me._chkQK_15)
        Me.Controls.Add(Me._chkQK_14)
        Me.Controls.Add(Me._chkQK_5)
        Me.Controls.Add(Me._chkQK_4)
        Me.Controls.Add(Me._chkQK_97)
        Me.Controls.Add(Me._chkQK_87)
        Me.Controls.Add(Me._chkQK_77)
        Me.Controls.Add(Me._chkQK_67)
        Me.Controls.Add(Me._chkQK_57)
        Me.Controls.Add(Me._chkQK_47)
        Me.Controls.Add(Me._chkQK_37)
        Me.Controls.Add(Me._chkQK_27)
        Me.Controls.Add(Me._chkQK_99)
        Me.Controls.Add(Me._chkQK_98)
        Me.Controls.Add(Me._chkQK_93)
        Me.Controls.Add(Me._chkQK_92)
        Me.Controls.Add(Me._chkQK_91)
        Me.Controls.Add(Me._chkQK_90)
        Me.Controls.Add(Me._chkQK_89)
        Me.Controls.Add(Me._chkQK_88)
        Me.Controls.Add(Me._chkQK_83)
        Me.Controls.Add(Me._chkQK_82)
        Me.Controls.Add(Me._chkQK_81)
        Me.Controls.Add(Me._chkQK_80)
        Me.Controls.Add(Me._chkQK_79)
        Me.Controls.Add(Me._chkQK_78)
        Me.Controls.Add(Me._chkQK_73)
        Me.Controls.Add(Me._chkQK_72)
        Me.Controls.Add(Me._chkQK_71)
        Me.Controls.Add(Me._chkQK_70)
        Me.Controls.Add(Me._chkQK_69)
        Me.Controls.Add(Me._chkQK_68)
        Me.Controls.Add(Me._chkQK_63)
        Me.Controls.Add(Me._chkQK_62)
        Me.Controls.Add(Me._chkQK_61)
        Me.Controls.Add(Me._chkQK_60)
        Me.Controls.Add(Me._chkQK_59)
        Me.Controls.Add(Me._chkQK_58)
        Me.Controls.Add(Me._chkQK_53)
        Me.Controls.Add(Me._chkQK_52)
        Me.Controls.Add(Me._chkQK_51)
        Me.Controls.Add(Me._chkQK_50)
        Me.Controls.Add(Me._chkQK_49)
        Me.Controls.Add(Me._chkQK_48)
        Me.Controls.Add(Me._chkQK_43)
        Me.Controls.Add(Me._chkQK_42)
        Me.Controls.Add(Me._chkQK_41)
        Me.Controls.Add(Me._chkQK_40)
        Me.Controls.Add(Me._chkQK_39)
        Me.Controls.Add(Me._chkQK_38)
        Me.Controls.Add(Me._chkQK_33)
        Me.Controls.Add(Me._chkQK_32)
        Me.Controls.Add(Me._chkQK_31)
        Me.Controls.Add(Me._chkQK_30)
        Me.Controls.Add(Me._chkQK_29)
        Me.Controls.Add(Me._chkQK_28)
        Me.Controls.Add(Me._chkQK_23)
        Me.Controls.Add(Me._chkQK_22)
        Me.Controls.Add(Me._chkQK_21)
        Me.Controls.Add(Me._chkQK_20)
        Me.Controls.Add(Me._chkQK_19)
        Me.Controls.Add(Me._chkQK_18)
        Me.Controls.Add(Me._chkQK_17)
        Me.Controls.Add(Me._chkQK_13)
        Me.Controls.Add(Me._chkQK_12)
        Me.Controls.Add(Me._chkQK_11)
        Me.Controls.Add(Me._chkQK_10)
        Me.Controls.Add(Me._chkQK_9)
        Me.Controls.Add(Me._chkQK_8)
        Me.Controls.Add(Me._chkQK_7)
        Me.Controls.Add(Me._chkQK_3)
        Me.Controls.Add(Me._chkQK_2)
        Me.Controls.Add(Me._chkQK_1)
        Me.Controls.Add(Me._chkQK_0)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lblQK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSysQK"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "System Quick Key Editor"
        CType(Me.chkQK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class