<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecord
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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecord))
        Dim Label11 As System.Windows.Forms.Label
        Me.chkRecord = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.prgRecLevel = New System.Windows.Forms.ProgressBar()
        Me.cmbDevList = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.trkHangTime = New System.Windows.Forms.TrackBar()
        Me.chkSysDir = New System.Windows.Forms.CheckBox()
        Me.txtMaxRecTime = New System.Windows.Forms.TextBox()
        Me.cmdLoadFileName = New System.Windows.Forms.Button()
        Me.cmdResetFileName = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.chkDayDir = New System.Windows.Forms.CheckBox()
        Me.cmdChooseSaveDir = New System.Windows.Forms.Button()
        Me.txtDefaultDir = New System.Windows.Forms.TextBox()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ChooseDir = New System.Windows.Forms.FolderBrowserDialog()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.trkHangTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 27)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 2
        Label1.Text = "Save To:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(134, 24)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(68, 13)
        Label2.TabIndex = 4
        Label2.Text = "Record From"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(8, 99)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(88, 13)
        Label3.TabIndex = 6
        Label3.Text = "Setup File Name:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(8, 112)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(367, 13)
        Label4.TabIndex = 8
        Label4.Text = "Substitude the following: %system% %site% %name% %rssi% %chan% %nac%"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(8, 125)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(290, 13)
        Label5.TabIndex = 9
        Label5.Text = "%date%  %time%  %hit% - Hit Number. Do not add extension."
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(8, 186)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(154, 13)
        Label7.TabIndex = 14
        Label7.Text = "Max Recording Time (seconds)"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(61, 229)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(59, 13)
        Label6.TabIndex = 17
        Label6.Text = "Hang Time"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(9, 245)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(32, 13)
        Label8.TabIndex = 18
        Label8.Text = "Short"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(137, 245)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(31, 13)
        Label9.TabIndex = 19
        Label9.Text = "Long"
        '
        'Label10
        '
        Label10.Location = New System.Drawing.Point(190, 229)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(322, 73)
        Label10.TabIndex = 20
        Label10.Text = resources.GetString("Label10.Text")
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(366, 48)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(60, 13)
        Label11.TabIndex = 18
        Label11.Text = "Input Level"
        '
        'chkRecord
        '
        Me.chkRecord.AutoSize = True
        Me.chkRecord.Location = New System.Drawing.Point(9, 23)
        Me.chkRecord.Name = "chkRecord"
        Me.chkRecord.Size = New System.Drawing.Size(111, 17)
        Me.chkRecord.TabIndex = 0
        Me.chkRecord.Text = "&Enable Recording"
        Me.chkRecord.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdRefresh)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.prgRecLevel)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.cmbDevList)
        Me.GroupBox1.Controls.Add(Me.chkRecord)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 83)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Location = New System.Drawing.Point(208, 43)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(51, 23)
        Me.cmdRefresh.TabIndex = 19
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'prgRecLevel
        '
        Me.prgRecLevel.Location = New System.Drawing.Point(432, 48)
        Me.prgRecLevel.Name = "prgRecLevel"
        Me.prgRecLevel.Size = New System.Drawing.Size(104, 16)
        Me.prgRecLevel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgRecLevel.TabIndex = 5
        Me.prgRecLevel.Value = 50
        '
        'cmbDevList
        '
        Me.cmbDevList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDevList.FormattingEnabled = True
        Me.cmbDevList.Location = New System.Drawing.Point(208, 21)
        Me.cmbDevList.Name = "cmbDevList"
        Me.cmbDevList.Size = New System.Drawing.Size(328, 21)
        Me.cmbDevList.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label10)
        Me.GroupBox2.Controls.Add(Label9)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Label6)
        Me.GroupBox2.Controls.Add(Me.trkHangTime)
        Me.GroupBox2.Controls.Add(Me.chkSysDir)
        Me.GroupBox2.Controls.Add(Me.txtMaxRecTime)
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(Me.cmdLoadFileName)
        Me.GroupBox2.Controls.Add(Me.cmdResetFileName)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.txtFileName)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.chkDayDir)
        Me.GroupBox2.Controls.Add(Me.cmdChooseSaveDir)
        Me.GroupBox2.Controls.Add(Me.txtDefaultDir)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(542, 315)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Advanced Setup"
        '
        'trkHangTime
        '
        Me.trkHangTime.AccessibleDescription = "How long recording is continued after squelch has closed"
        Me.trkHangTime.LargeChange = 2
        Me.trkHangTime.Location = New System.Drawing.Point(37, 245)
        Me.trkHangTime.Name = "trkHangTime"
        Me.trkHangTime.Size = New System.Drawing.Size(104, 45)
        Me.trkHangTime.TabIndex = 16
        '
        'chkSysDir
        '
        Me.chkSysDir.AutoSize = True
        Me.chkSysDir.Location = New System.Drawing.Point(226, 69)
        Me.chkSysDir.Name = "chkSysDir"
        Me.chkSysDir.Size = New System.Drawing.Size(189, 17)
        Me.chkSysDir.TabIndex = 4
        Me.chkSysDir.Text = "&Give each system its own directory"
        Me.chkSysDir.UseVisualStyleBackColor = True
        '
        'txtMaxRecTime
        '
        Me.txtMaxRecTime.Location = New System.Drawing.Point(168, 186)
        Me.txtMaxRecTime.MaxLength = 3
        Me.txtMaxRecTime.Name = "txtMaxRecTime"
        Me.txtMaxRecTime.Size = New System.Drawing.Size(38, 20)
        Me.txtMaxRecTime.TabIndex = 15
        Me.txtMaxRecTime.Text = "999"
        '
        'cmdLoadFileName
        '
        Me.cmdLoadFileName.Location = New System.Drawing.Point(352, 179)
        Me.cmdLoadFileName.Name = "cmdLoadFileName"
        Me.cmdLoadFileName.Size = New System.Drawing.Size(77, 20)
        Me.cmdLoadFileName.TabIndex = 13
        Me.cmdLoadFileName.Text = "Rever&t"
        Me.cmdLoadFileName.UseVisualStyleBackColor = True
        '
        'cmdResetFileName
        '
        Me.cmdResetFileName.Location = New System.Drawing.Point(269, 179)
        Me.cmdResetFileName.Name = "cmdResetFileName"
        Me.cmdResetFileName.Size = New System.Drawing.Size(77, 20)
        Me.cmdResetFileName.TabIndex = 6
        Me.cmdResetFileName.Text = "&Reset"
        Me.cmdResetFileName.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(11, 153)
        Me.txtFileName.MaxLength = 255
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(418, 20)
        Me.txtFileName.TabIndex = 5
        Me.txtFileName.Text = "%hit% %time% %system% %chan% %name%"
        '
        'chkDayDir
        '
        Me.chkDayDir.AutoSize = True
        Me.chkDayDir.Location = New System.Drawing.Point(9, 69)
        Me.chkDayDir.Name = "chkDayDir"
        Me.chkDayDir.Size = New System.Drawing.Size(211, 17)
        Me.chkDayDir.TabIndex = 3
        Me.chkDayDir.Text = "C&reate a new subdirectory for each day"
        Me.chkDayDir.UseVisualStyleBackColor = True
        '
        'cmdChooseSaveDir
        '
        Me.cmdChooseSaveDir.Location = New System.Drawing.Point(435, 43)
        Me.cmdChooseSaveDir.Name = "cmdChooseSaveDir"
        Me.cmdChooseSaveDir.Size = New System.Drawing.Size(77, 20)
        Me.cmdChooseSaveDir.TabIndex = 2
        Me.cmdChooseSaveDir.Text = "Choose..."
        Me.cmdChooseSaveDir.UseVisualStyleBackColor = True
        '
        'txtDefaultDir
        '
        Me.txtDefaultDir.Location = New System.Drawing.Point(11, 43)
        Me.txtDefaultDir.Name = "txtDefaultDir"
        Me.txtDefaultDir.ReadOnly = True
        Me.txtDefaultDir.Size = New System.Drawing.Size(418, 20)
        Me.txtDefaultDir.TabIndex = 3
        Me.txtDefaultDir.TabStop = False
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(400, 422)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(77, 22)
        Me.cmdApply.TabIndex = 16
        Me.cmdApply.Text = "&Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(483, 422)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(77, 22)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'ChooseDir
        '
        Me.ChooseDir.Description = "Select a directory to which files will be saved."
        '
        'frmRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 456)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRecord"
        Me.Text = "Recording Control"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.trkHangTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDevList As System.Windows.Forms.ComboBox
    Friend WithEvents chkDayDir As System.Windows.Forms.CheckBox
    Friend WithEvents cmdChooseSaveDir As System.Windows.Forms.Button
    Friend WithEvents txtDefaultDir As System.Windows.Forms.TextBox
    Friend WithEvents cmdResetFileName As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents cmdLoadFileName As System.Windows.Forms.Button
    Friend WithEvents txtMaxRecTime As System.Windows.Forms.TextBox
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents ChooseDir As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkSysDir As System.Windows.Forms.CheckBox
    Friend WithEvents trkHangTime As System.Windows.Forms.TrackBar
    Friend WithEvents prgRecLevel As System.Windows.Forms.ProgressBar
    Public WithEvents chkRecord As System.Windows.Forms.CheckBox
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
End Class
