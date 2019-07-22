<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class networkserver
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
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(networkserver))
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdStopServer = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.cmdStartServer = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GBUserInfo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSaveUserInfo = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.chkNoWrite = New System.Windows.Forms.CheckBox()
        Me.cmdDelUser = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmdAddNewUser = New System.Windows.Forms.Button()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.btnAnyUser = New System.Windows.Forms.RadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timerTxt = New System.Windows.Forms.Timer(Me.components)
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GBUserInfo.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(21, 74)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(29, 13)
        Label1.TabIndex = 3
        Label1.Text = "Port:"
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(7, 11)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(440, 55)
        Label4.TabIndex = 7
        Label4.Text = resources.GetString("Label4.Text")
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(6, 50)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(56, 13)
        Label5.TabIndex = 5
        Label5.Text = "Password:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(6, 16)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(58, 13)
        Label6.TabIndex = 8
        Label6.Text = "Username:"
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(12, 19)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(506, 48)
        Label3.TabIndex = 0
        Label3.Text = "Use FreeSCAN server to remote control your scanner using your iPhone.  Whether lo" & _
    "cally or across the world. For more information, click on the buttons below. "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(8, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(539, 362)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtLog)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(531, 336)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Configuration && Control"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(4, 166)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(458, 151)
        Me.txtLog.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.cmdStopServer)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.cmdStartServer)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listen On"
        '
        'cmdStopServer
        '
        Me.cmdStopServer.Location = New System.Drawing.Point(10, 119)
        Me.cmdStopServer.Name = "cmdStopServer"
        Me.cmdStopServer.Size = New System.Drawing.Size(136, 23)
        Me.cmdStopServer.TabIndex = 1
        Me.cmdStopServer.Text = "S&top Server"
        Me.cmdStopServer.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(49, 70)
        Me.txtPort.MaxLength = 5
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(64, 20)
        Me.txtPort.TabIndex = 4
        Me.txtPort.Text = "1300"
        Me.txtPort.WordWrap = False
        '
        'cmdStartServer
        '
        Me.cmdStartServer.Location = New System.Drawing.Point(10, 96)
        Me.cmdStartServer.Name = "cmdStartServer"
        Me.cmdStartServer.Size = New System.Drawing.Size(136, 23)
        Me.cmdStartServer.TabIndex = 0
        Me.cmdStartServer.Text = "&Start Server"
        Me.cmdStartServer.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GBUserInfo)
        Me.TabPage2.Controls.Add(Me.cmdAddNewUser)
        Me.TabPage2.Controls.Add(Me.lstUsers)
        Me.TabPage2.Controls.Add(Me.RadioButton2)
        Me.TabPage2.Controls.Add(Me.btnAnyUser)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(531, 336)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Users"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GBUserInfo
        '
        Me.GBUserInfo.Controls.Add(Me.Label2)
        Me.GBUserInfo.Controls.Add(Me.cmdSaveUserInfo)
        Me.GBUserInfo.Controls.Add(Label6)
        Me.GBUserInfo.Controls.Add(Me.txtUsername)
        Me.GBUserInfo.Controls.Add(Label5)
        Me.GBUserInfo.Controls.Add(Me.chkNoWrite)
        Me.GBUserInfo.Controls.Add(Me.cmdDelUser)
        Me.GBUserInfo.Controls.Add(Me.txtPassword)
        Me.GBUserInfo.Enabled = False
        Me.GBUserInfo.Location = New System.Drawing.Point(243, 98)
        Me.GBUserInfo.Name = "GBUserInfo"
        Me.GBUserInfo.Size = New System.Drawing.Size(268, 206)
        Me.GBUserInfo.TabIndex = 8
        Me.GBUserInfo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tip: Do not use commas or special characters"
        '
        'cmdSaveUserInfo
        '
        Me.cmdSaveUserInfo.Location = New System.Drawing.Point(9, 143)
        Me.cmdSaveUserInfo.Name = "cmdSaveUserInfo"
        Me.cmdSaveUserInfo.Size = New System.Drawing.Size(108, 23)
        Me.cmdSaveUserInfo.TabIndex = 10
        Me.cmdSaveUserInfo.Text = "&Save"
        Me.cmdSaveUserInfo.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(9, 32)
        Me.txtUsername.MaxLength = 16
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(192, 20)
        Me.txtUsername.TabIndex = 9
        '
        'chkNoWrite
        '
        Me.chkNoWrite.AutoSize = True
        Me.chkNoWrite.Location = New System.Drawing.Point(9, 92)
        Me.chkNoWrite.Name = "chkNoWrite"
        Me.chkNoWrite.Size = New System.Drawing.Size(248, 17)
        Me.chkNoWrite.TabIndex = 7
        Me.chkNoWrite.Text = "User cannot access &keypad (read only access)"
        Me.chkNoWrite.UseVisualStyleBackColor = True
        Me.chkNoWrite.Visible = False
        '
        'cmdDelUser
        '
        Me.cmdDelUser.Location = New System.Drawing.Point(9, 172)
        Me.cmdDelUser.Name = "cmdDelUser"
        Me.cmdDelUser.Size = New System.Drawing.Size(108, 23)
        Me.cmdDelUser.TabIndex = 4
        Me.cmdDelUser.Text = "&Delete User..."
        Me.cmdDelUser.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(9, 66)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtPassword.TabIndex = 6
        '
        'cmdAddNewUser
        '
        Me.cmdAddNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNewUser.Location = New System.Drawing.Point(17, 75)
        Me.cmdAddNewUser.Name = "cmdAddNewUser"
        Me.cmdAddNewUser.Size = New System.Drawing.Size(127, 24)
        Me.cmdAddNewUser.TabIndex = 3
        Me.cmdAddNewUser.Text = "+Create New User"
        Me.cmdAddNewUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.cmdAddNewUser.UseVisualStyleBackColor = True
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(17, 105)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(220, 199)
        Me.lstUsers.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(17, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(166, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Only allow the following users:"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'btnAnyUser
        '
        Me.btnAnyUser.AutoSize = True
        Me.btnAnyUser.Checked = True
        Me.btnAnyUser.Location = New System.Drawing.Point(17, 17)
        Me.btnAnyUser.Name = "btnAnyUser"
        Me.btnAnyUser.Size = New System.Drawing.Size(220, 17)
        Me.btnAnyUser.TabIndex = 0
        Me.btnAnyUser.TabStop = True
        Me.btnAnyUser.Text = "&Allow anyone to connect to this computer"
        Me.btnAnyUser.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(531, 336)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(312, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Find out more information"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.FreeSCAN.My.Resources.Resources._1375121_10151880936949421_1072291165_t
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(67, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 70)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Purchase at the Apple App Store"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'timerTxt
        '
        Me.timerTxt.Enabled = True
        Me.timerTxt.Interval = 4000
        '
        'networkserver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 384)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "networkserver"
        Me.Text = "FreeSCAN Server"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GBUserInfo.ResumeLayout(False)
        Me.GBUserInfo.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdStopServer As System.Windows.Forms.Button
    Friend WithEvents cmdStartServer As System.Windows.Forms.Button
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnyUser As System.Windows.Forms.RadioButton
    Friend WithEvents chkNoWrite As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdDelUser As System.Windows.Forms.Button
    Friend WithEvents cmdAddNewUser As System.Windows.Forms.Button
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents GBUserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSaveUserInfo As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents timerTxt As System.Windows.Forms.Timer
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
