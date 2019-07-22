<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBandPlan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBandPlan))
        Me.grdBP = New System.Windows.Forms.DataGridView()
        Me.colLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMod = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colStep = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        CType(Me.grdBP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdBP
        '
        Me.grdBP.AllowUserToAddRows = False
        Me.grdBP.AllowUserToDeleteRows = False
        Me.grdBP.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdBP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLE, Me.colUE, Me.colMod, Me.colStep, Me.colRemark})
        Me.grdBP.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdBP.Location = New System.Drawing.Point(0, 0)
        Me.grdBP.MultiSelect = False
        Me.grdBP.Name = "grdBP"
        Me.grdBP.RowHeadersVisible = False
        Me.grdBP.ShowEditingIcon = False
        Me.grdBP.ShowRowErrors = False
        Me.grdBP.Size = New System.Drawing.Size(623, 381)
        Me.grdBP.TabIndex = 0
        '
        'colLE
        '
        Me.colLE.Frozen = True
        Me.colLE.HeaderText = "Lower Edge"
        Me.colLE.Name = "colLE"
        Me.colLE.ReadOnly = True
        '
        'colUE
        '
        Me.colUE.Frozen = True
        Me.colUE.HeaderText = "Upper Edge"
        Me.colUE.Name = "colUE"
        Me.colUE.ReadOnly = True
        '
        'colMod
        '
        Me.colMod.Frozen = True
        Me.colMod.HeaderText = "Mod"
        Me.colMod.Name = "colMod"
        '
        'colStep
        '
        Me.colStep.Frozen = True
        Me.colStep.HeaderText = "Step (kHz)"
        Me.colStep.Name = "colStep"
        '
        'colRemark
        '
        Me.colRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colRemark.Frozen = True
        Me.colRemark.HeaderText = "Remark"
        Me.colRemark.Name = "colRemark"
        Me.colRemark.ReadOnly = True
        Me.colRemark.Width = 69
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(457, 386)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 24)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "&OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(540, 386)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 24)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "C&ancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(3, 386)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(82, 24)
        Me.cmdReset.TabIndex = 3
        Me.cmdReset.Text = "&Load Default"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'frmBandPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 418)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.grdBP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBandPlan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Band Plan Editor (XT Scanners Only)"
        CType(Me.grdBP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdBP As System.Windows.Forms.DataGridView
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents colLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMod As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colStep As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colRemark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdReset As System.Windows.Forms.Button
End Class
