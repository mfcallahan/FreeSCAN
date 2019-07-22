<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FreqJump
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FreqJump))
        Me.txtFreq = New System.Windows.Forms.TextBox
        Me.cmbDelayTime = New System.Windows.Forms.ComboBox
        Me.cmbModMode = New System.Windows.Forms.ComboBox
        Me.chkDataSkip = New System.Windows.Forms.CheckBox
        Me.chkAtt = New System.Windows.Forms.CheckBox
        Me.cmbStep = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.cmdJump = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(17, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 13)
        Label1.TabIndex = 0
        Label1.Text = "Frequency"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(144, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(29, 13)
        Label2.TabIndex = 1
        Label2.Text = "Step"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(243, 9)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 13)
        Label3.TabIndex = 2
        Label3.Text = "Modulation"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(343, 9)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(34, 13)
        Label4.TabIndex = 174
        Label4.Text = "Delay"
        '
        'txtFreq
        '
        Me.txtFreq.Location = New System.Drawing.Point(20, 25)
        Me.txtFreq.MaxLength = 16
        Me.txtFreq.Name = "txtFreq"
        Me.txtFreq.Size = New System.Drawing.Size(101, 20)
        Me.txtFreq.TabIndex = 0
        '
        'cmbDelayTime
        '
        Me.cmbDelayTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDelayTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDelayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDelayTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDelayTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDelayTime.Location = New System.Drawing.Point(345, 25)
        Me.cmbDelayTime.Name = "cmbDelayTime"
        Me.cmbDelayTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDelayTime.Size = New System.Drawing.Size(65, 22)
        Me.cmbDelayTime.TabIndex = 3
        '
        'cmbModMode
        '
        Me.cmbModMode.BackColor = System.Drawing.SystemColors.Window
        Me.cmbModMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbModMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModMode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbModMode.Location = New System.Drawing.Point(246, 25)
        Me.cmbModMode.Name = "cmbModMode"
        Me.cmbModMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbModMode.Size = New System.Drawing.Size(73, 22)
        Me.cmbModMode.TabIndex = 2
        '
        'chkDataSkip
        '
        Me.chkDataSkip.BackColor = System.Drawing.SystemColors.Control
        Me.chkDataSkip.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDataSkip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDataSkip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDataSkip.Location = New System.Drawing.Point(20, 74)
        Me.chkDataSkip.Name = "chkDataSkip"
        Me.chkDataSkip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDataSkip.Size = New System.Drawing.Size(89, 17)
        Me.chkDataSkip.TabIndex = 5
        Me.chkDataSkip.Text = "Data Skip"
        Me.chkDataSkip.UseVisualStyleBackColor = False
        '
        'chkAtt
        '
        Me.chkAtt.BackColor = System.Drawing.SystemColors.Control
        Me.chkAtt.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAtt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAtt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAtt.Location = New System.Drawing.Point(20, 51)
        Me.chkAtt.Name = "chkAtt"
        Me.chkAtt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAtt.Size = New System.Drawing.Size(113, 17)
        Me.chkAtt.TabIndex = 4
        Me.chkAtt.Text = "20dB Attenuation"
        Me.chkAtt.UseVisualStyleBackColor = False
        '
        'cmbStep
        '
        Me.cmbStep.BackColor = System.Drawing.SystemColors.Window
        Me.cmbStep.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStep.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStep.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbStep.Location = New System.Drawing.Point(147, 25)
        Me.cmbStep.Name = "cmbStep"
        Me.cmbStep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStep.Size = New System.Drawing.Size(73, 22)
        Me.cmbStep.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 61)
        Me.GroupBox1.TabIndex = 176
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Mode"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(150, 24)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(161, 17)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "&P25 NAC Search (Digital XT)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(57, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "&CTCSS/DCS"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "&Off"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cmdJump
        '
        Me.cmdJump.Location = New System.Drawing.Point(288, 178)
        Me.cmdJump.Name = "cmdJump"
        Me.cmdJump.Size = New System.Drawing.Size(87, 25)
        Me.cmdJump.TabIndex = 9
        Me.cmdJump.Text = "&Jump To"
        Me.cmdJump.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(381, 178)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 25)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'FreqJump
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(478, 215)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdJump)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbStep)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.cmbModMode)
        Me.Controls.Add(Me.chkDataSkip)
        Me.Controls.Add(Me.chkAtt)
        Me.Controls.Add(Me.cmbDelayTime)
        Me.Controls.Add(Me.txtFreq)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FreqJump"
        Me.Text = "Jump To Frequency"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFreq As System.Windows.Forms.TextBox
    Public WithEvents cmbDelayTime As System.Windows.Forms.ComboBox
    Public WithEvents cmbModMode As System.Windows.Forms.ComboBox
    Public WithEvents chkDataSkip As System.Windows.Forms.CheckBox
    Public WithEvents chkAtt As System.Windows.Forms.CheckBox
    Public WithEvents cmbStep As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdJump As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
