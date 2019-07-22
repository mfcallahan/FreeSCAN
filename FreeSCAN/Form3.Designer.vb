<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFSSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFSSetup))
        Me.cmdOK = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.radBias1 = New System.Windows.Forms.RadioButton
        Me.radBias2 = New System.Windows.Forms.RadioButton
        Me.chkForceCCO = New System.Windows.Forms.CheckBox
        Me.chkBlind = New System.Windows.Forms.CheckBox
        Me.chkAltColor = New System.Windows.Forms.CheckBox
        Me.cmdClearFile = New System.Windows.Forms.Button
        Me.chkWarnInvalidFreq = New System.Windows.Forms.CheckBox
        Me.chkUpdateStartup = New System.Windows.Forms.CheckBox
        Me.chkSplash = New System.Windows.Forms.CheckBox
        Me.chkDelWarn = New System.Windows.Forms.CheckBox
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(354, 223)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(99, 24)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "&OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(459, 223)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(99, 24)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radBias1)
        Me.GroupBox3.Controls.Add(Me.radBias2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(155, 86)
        Me.GroupBox3.TabIndex = 393
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bias"
        '
        'radBias1
        '
        Me.radBias1.AutoSize = True
        Me.radBias1.Location = New System.Drawing.Point(17, 19)
        Me.radBias1.Name = "radBias1"
        Me.radBias1.Size = New System.Drawing.Size(114, 17)
        Me.radBias1.TabIndex = 1
        Me.radBias1.TabStop = True
        Me.radBias1.Text = "Use American Bias"
        Me.radBias1.UseVisualStyleBackColor = True
        '
        'radBias2
        '
        Me.radBias2.AutoSize = True
        Me.radBias2.Location = New System.Drawing.Point(17, 43)
        Me.radBias2.Name = "radBias2"
        Me.radBias2.Size = New System.Drawing.Size(115, 17)
        Me.radBias2.TabIndex = 0
        Me.radBias2.TabStop = True
        Me.radBias2.Text = "Use Canadian Bias"
        Me.radBias2.UseVisualStyleBackColor = True
        '
        'chkForceCCO
        '
        Me.chkForceCCO.BackColor = System.Drawing.SystemColors.Control
        Me.chkForceCCO.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkForceCCO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkForceCCO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkForceCCO.Location = New System.Drawing.Point(263, 32)
        Me.chkForceCCO.Name = "chkForceCCO"
        Me.chkForceCCO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkForceCCO.Size = New System.Drawing.Size(315, 50)
        Me.chkForceCCO.TabIndex = 392
        Me.chkForceCCO.Text = "Force Control Channel Output mode to off (recommended for reliable operation)"
        Me.chkForceCCO.UseVisualStyleBackColor = False
        '
        'chkBlind
        '
        Me.chkBlind.AutoSize = True
        Me.chkBlind.BackColor = System.Drawing.SystemColors.Control
        Me.chkBlind.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBlind.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBlind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBlind.Location = New System.Drawing.Point(262, 9)
        Me.chkBlind.Name = "chkBlind"
        Me.chkBlind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBlind.Size = New System.Drawing.Size(138, 18)
        Me.chkBlind.TabIndex = 391
        Me.chkBlind.Text = "Use blind &friendly mode"
        Me.chkBlind.UseVisualStyleBackColor = False
        '
        'chkAltColor
        '
        Me.chkAltColor.BackColor = System.Drawing.SystemColors.Control
        Me.chkAltColor.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAltColor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAltColor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAltColor.Location = New System.Drawing.Point(263, 88)
        Me.chkAltColor.Name = "chkAltColor"
        Me.chkAltColor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAltColor.Size = New System.Drawing.Size(189, 28)
        Me.chkAltColor.TabIndex = 390
        Me.chkAltColor.Text = "Alternate backcolor in grid editors"
        Me.chkAltColor.UseVisualStyleBackColor = False
        '
        'cmdClearFile
        '
        Me.cmdClearFile.Location = New System.Drawing.Point(263, 135)
        Me.cmdClearFile.Name = "cmdClearFile"
        Me.cmdClearFile.Size = New System.Drawing.Size(119, 47)
        Me.cmdClearFile.TabIndex = 389
        Me.cmdClearFile.Text = "&Clear recently used file list"
        Me.cmdClearFile.UseVisualStyleBackColor = True
        '
        'chkWarnInvalidFreq
        '
        Me.chkWarnInvalidFreq.BackColor = System.Drawing.SystemColors.Control
        Me.chkWarnInvalidFreq.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkWarnInvalidFreq.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWarnInvalidFreq.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkWarnInvalidFreq.Location = New System.Drawing.Point(12, 62)
        Me.chkWarnInvalidFreq.Name = "chkWarnInvalidFreq"
        Me.chkWarnInvalidFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkWarnInvalidFreq.Size = New System.Drawing.Size(245, 20)
        Me.chkWarnInvalidFreq.TabIndex = 385
        Me.chkWarnInvalidFreq.Text = "&Warn me about entering invalid frequencies"
        Me.chkWarnInvalidFreq.UseVisualStyleBackColor = False
        '
        'chkUpdateStartup
        '
        Me.chkUpdateStartup.BackColor = System.Drawing.SystemColors.Control
        Me.chkUpdateStartup.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUpdateStartup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUpdateStartup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUpdateStartup.Location = New System.Drawing.Point(12, 5)
        Me.chkUpdateStartup.Name = "chkUpdateStartup"
        Me.chkUpdateStartup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUpdateStartup.Size = New System.Drawing.Size(189, 26)
        Me.chkUpdateStartup.TabIndex = 386
        Me.chkUpdateStartup.Text = "&Check for update on startup"
        Me.chkUpdateStartup.UseVisualStyleBackColor = False
        '
        'chkSplash
        '
        Me.chkSplash.BackColor = System.Drawing.SystemColors.Control
        Me.chkSplash.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSplash.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSplash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSplash.Location = New System.Drawing.Point(12, 37)
        Me.chkSplash.Name = "chkSplash"
        Me.chkSplash.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSplash.Size = New System.Drawing.Size(189, 19)
        Me.chkSplash.TabIndex = 387
        Me.chkSplash.Text = "S&how splash screen on startup"
        Me.chkSplash.UseVisualStyleBackColor = False
        '
        'chkDelWarn
        '
        Me.chkDelWarn.BackColor = System.Drawing.SystemColors.Control
        Me.chkDelWarn.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDelWarn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDelWarn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDelWarn.Location = New System.Drawing.Point(12, 88)
        Me.chkDelWarn.Name = "chkDelWarn"
        Me.chkDelWarn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDelWarn.Size = New System.Drawing.Size(193, 28)
        Me.chkDelWarn.TabIndex = 388
        Me.chkDelWarn.Text = "Warn me before I &delete something"
        Me.chkDelWarn.UseVisualStyleBackColor = False
        '
        'frmFSSetup
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 257)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkForceCCO)
        Me.Controls.Add(Me.chkBlind)
        Me.Controls.Add(Me.chkAltColor)
        Me.Controls.Add(Me.cmdClearFile)
        Me.Controls.Add(Me.chkWarnInvalidFreq)
        Me.Controls.Add(Me.chkUpdateStartup)
        Me.Controls.Add(Me.chkSplash)
        Me.Controls.Add(Me.chkDelWarn)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFSSetup"
        Me.Text = "Set FreeSCAN Preferences"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radBias1 As System.Windows.Forms.RadioButton
    Friend WithEvents radBias2 As System.Windows.Forms.RadioButton
    Public WithEvents chkForceCCO As System.Windows.Forms.CheckBox
    Public WithEvents chkBlind As System.Windows.Forms.CheckBox
    Public WithEvents chkAltColor As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClearFile As System.Windows.Forms.Button
    Public WithEvents chkWarnInvalidFreq As System.Windows.Forms.CheckBox
    Public WithEvents chkUpdateStartup As System.Windows.Forms.CheckBox
    Public WithEvents chkSplash As System.Windows.Forms.CheckBox
    Public WithEvents chkDelWarn As System.Windows.Forms.CheckBox
End Class
