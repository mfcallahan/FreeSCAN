<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPSSummary
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
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGPSSummary))
        Me.WebSee = New System.Windows.Forms.WebBrowser()
        Me.cmdLoadSystemList = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdReloadMap = New System.Windows.Forms.Button()
        Me.chkSysList = New System.Windows.Forms.CheckedListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.radMiles = New System.Windows.Forms.RadioButton()
        Me.radKM = New System.Windows.Forms.RadioButton()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GroupBox1.Controls.Add(Me.WebSee)
        GroupBox1.Location = New System.Drawing.Point(153, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(632, 461)
        GroupBox1.TabIndex = 31
        GroupBox1.TabStop = False
        GroupBox1.Text = "Map View"
        '
        'WebSee
        '
        Me.WebSee.AllowWebBrowserDrop = False
        Me.WebSee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebSee.CausesValidation = False
        Me.WebSee.Location = New System.Drawing.Point(6, 19)
        Me.WebSee.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebSee.Name = "WebSee"
        Me.WebSee.ScriptErrorsSuppressed = True
        Me.WebSee.Size = New System.Drawing.Size(620, 436)
        Me.WebSee.TabIndex = 23
        Me.WebSee.TabStop = False
        Me.WebSee.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        Me.WebSee.WebBrowserShortcutsEnabled = False
        '
        'cmdLoadSystemList
        '
        Me.cmdLoadSystemList.AccessibleDescription = "Reloads system list"
        Me.cmdLoadSystemList.Image = CType(resources.GetObject("cmdLoadSystemList.Image"), System.Drawing.Image)
        Me.cmdLoadSystemList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLoadSystemList.Location = New System.Drawing.Point(8, 61)
        Me.cmdLoadSystemList.Name = "cmdLoadSystemList"
        Me.cmdLoadSystemList.Size = New System.Drawing.Size(139, 23)
        Me.cmdLoadSystemList.TabIndex = 27
        Me.cmdLoadSystemList.Text = "&System List"
        Me.cmdLoadSystemList.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Reload system list"
        '
        'cmdReloadMap
        '
        Me.cmdReloadMap.Image = CType(resources.GetObject("cmdReloadMap.Image"), System.Drawing.Image)
        Me.cmdReloadMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReloadMap.Location = New System.Drawing.Point(8, 90)
        Me.cmdReloadMap.Name = "cmdReloadMap"
        Me.cmdReloadMap.Size = New System.Drawing.Size(139, 23)
        Me.cmdReloadMap.TabIndex = 28
        Me.cmdReloadMap.Text = "&Map"
        Me.cmdReloadMap.UseVisualStyleBackColor = True
        '
        'chkSysList
        '
        Me.chkSysList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkSysList.CheckOnClick = True
        Me.chkSysList.ColumnWidth = 120
        Me.chkSysList.FormattingEnabled = True
        Me.chkSysList.IntegralHeight = False
        Me.chkSysList.Items.AddRange(New Object() {"test1", "test2", "test3", "1234567890123456", "1234567890123456", "1234567890123456", "1234567890123456", "1234567890123456", "1234567890123456", "1234567890123456", "1234567890123456", "1234567890123456", "1234567890123456", "odd line"})
        Me.chkSysList.Location = New System.Drawing.Point(8, 119)
        Me.chkSysList.Name = "chkSysList"
        Me.chkSysList.Size = New System.Drawing.Size(139, 377)
        Me.chkSysList.TabIndex = 29
        Me.chkSysList.ThreeDCheckBoxes = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripMenuItem, Me.NoneToolStripMenuItem, Me.AutoToolStripMenuItem})
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SelectToolStripMenuItem.Text = "Select"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AllToolStripMenuItem.Text = "&All"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.NoneToolStripMenuItem.Text = "&None"
        '
        'AutoToolStripMenuItem
        '
        Me.AutoToolStripMenuItem.Name = "AutoToolStripMenuItem"
        Me.AutoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AutoToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AutoToolStripMenuItem.Text = "&Enabled"
        '
        'radMiles
        '
        Me.radMiles.AutoSize = True
        Me.radMiles.Checked = True
        Me.radMiles.Location = New System.Drawing.Point(22, 28)
        Me.radMiles.Name = "radMiles"
        Me.radMiles.Size = New System.Drawing.Size(49, 17)
        Me.radMiles.TabIndex = 32
        Me.radMiles.TabStop = True
        Me.radMiles.Text = "Miles"
        Me.radMiles.UseVisualStyleBackColor = True
        '
        'radKM
        '
        Me.radKM.AutoSize = True
        Me.radKM.Location = New System.Drawing.Point(77, 28)
        Me.radKM.Name = "radKM"
        Me.radKM.Size = New System.Drawing.Size(41, 17)
        Me.radKM.TabIndex = 33
        Me.radKM.Text = "KM"
        Me.radKM.UseVisualStyleBackColor = True
        '
        'frmGPSSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 508)
        Me.Controls.Add(Me.radKM)
        Me.Controls.Add(Me.radMiles)
        Me.Controls.Add(GroupBox1)
        Me.Controls.Add(Me.chkSysList)
        Me.Controls.Add(Me.cmdReloadMap)
        Me.Controls.Add(Me.cmdLoadSystemList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGPSSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GPS System Summary (Internet connection required)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebSee As System.Windows.Forms.WebBrowser
    Friend WithEvents cmdLoadSystemList As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdReloadMap As System.Windows.Forms.Button
    Friend WithEvents chkSysList As System.Windows.Forms.CheckedListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents radMiles As System.Windows.Forms.RadioButton
    Friend WithEvents radKM As System.Windows.Forms.RadioButton
End Class
