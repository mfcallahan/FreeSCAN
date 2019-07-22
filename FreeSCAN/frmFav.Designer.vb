<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFav
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
	Public WithEvents cmdDeleteConvChan As System.Windows.Forms.Button
	Public WithEvents lstFavs As System.Windows.Forms.ListBox
	Public WithEvents cmdRenameFav As System.Windows.Forms.Button
	Public WithEvents cmdMoveDown As System.Windows.Forms.Button
	Public WithEvents cmdMoveUp As System.Windows.Forms.Button
	Public WithEvents cmdSort As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCLose As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFav))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdDeleteConvChan = New System.Windows.Forms.Button
        Me.cmdMoveDown = New System.Windows.Forms.Button
        Me.cmdMoveUp = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.lstFavs = New System.Windows.Forms.ListBox
        Me.cmdRenameFav = New System.Windows.Forms.Button
        Me.cmdSort = New System.Windows.Forms.Button
        Me.cmdCLose = New System.Windows.Forms.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDeleteConvChan
        '
        Me.cmdDeleteConvChan.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteConvChan.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteConvChan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteConvChan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteConvChan.Image = CType(resources.GetObject("cmdDeleteConvChan.Image"), System.Drawing.Image)
        Me.cmdDeleteConvChan.Location = New System.Drawing.Point(332, 232)
        Me.cmdDeleteConvChan.Name = "cmdDeleteConvChan"
        Me.cmdDeleteConvChan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteConvChan.Size = New System.Drawing.Size(29, 25)
        Me.cmdDeleteConvChan.TabIndex = 7
        Me.cmdDeleteConvChan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdDeleteConvChan, "Delete Favourite")
        Me.cmdDeleteConvChan.UseVisualStyleBackColor = False
        '
        'cmdMoveDown
        '
        Me.cmdMoveDown.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoveDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoveDown.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveDown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoveDown.Image = CType(resources.GetObject("cmdMoveDown.Image"), System.Drawing.Image)
        Me.cmdMoveDown.Location = New System.Drawing.Point(372, 116)
        Me.cmdMoveDown.Name = "cmdMoveDown"
        Me.cmdMoveDown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoveDown.Size = New System.Drawing.Size(45, 41)
        Me.cmdMoveDown.TabIndex = 4
        Me.cmdMoveDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdMoveDown, "Move Down")
        Me.cmdMoveDown.UseVisualStyleBackColor = False
        '
        'cmdMoveUp
        '
        Me.cmdMoveUp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoveUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoveUp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoveUp.Image = CType(resources.GetObject("cmdMoveUp.Image"), System.Drawing.Image)
        Me.cmdMoveUp.Location = New System.Drawing.Point(372, 52)
        Me.cmdMoveUp.Name = "cmdMoveUp"
        Me.cmdMoveUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoveUp.Size = New System.Drawing.Size(45, 41)
        Me.cmdMoveUp.TabIndex = 3
        Me.cmdMoveUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdMoveUp, "Move Up")
        Me.cmdMoveUp.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdDeleteConvChan)
        Me.Frame1.Controls.Add(Me.lstFavs)
        Me.Frame1.Controls.Add(Me.cmdRenameFav)
        Me.Frame1.Controls.Add(Me.cmdMoveDown)
        Me.Frame1.Controls.Add(Me.cmdMoveUp)
        Me.Frame1.Controls.Add(Me.cmdSort)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(433, 297)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "My Favourites"
        '
        'lstFavs
        '
        Me.lstFavs.BackColor = System.Drawing.SystemColors.Window
        Me.lstFavs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstFavs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFavs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstFavs.ItemHeight = 14
        Me.lstFavs.Location = New System.Drawing.Point(8, 24)
        Me.lstFavs.Name = "lstFavs"
        Me.lstFavs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstFavs.Size = New System.Drawing.Size(349, 200)
        Me.lstFavs.TabIndex = 6
        '
        'cmdRenameFav
        '
        Me.cmdRenameFav.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRenameFav.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRenameFav.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRenameFav.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRenameFav.Location = New System.Drawing.Point(8, 232)
        Me.cmdRenameFav.Name = "cmdRenameFav"
        Me.cmdRenameFav.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRenameFav.Size = New System.Drawing.Size(85, 25)
        Me.cmdRenameFav.TabIndex = 5
        Me.cmdRenameFav.Text = "Re&name"
        Me.cmdRenameFav.UseVisualStyleBackColor = True
        '
        'cmdSort
        '
        Me.cmdSort.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSort.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSort.Location = New System.Drawing.Point(8, 260)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSort.Size = New System.Drawing.Size(85, 25)
        Me.cmdSort.TabIndex = 2
        Me.cmdSort.Text = "&Sort"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'cmdCLose
        '
        Me.cmdCLose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCLose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCLose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCLose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCLose.Location = New System.Drawing.Point(360, 320)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCLose.Size = New System.Drawing.Size(85, 25)
        Me.cmdCLose.TabIndex = 0
        Me.cmdCLose.Text = "C&lose"
        Me.cmdCLose.UseVisualStyleBackColor = True
        '
        'frmFav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(469, 352)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCLose)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFav"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Organize Favourites"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class