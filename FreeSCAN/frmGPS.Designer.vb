<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGPS
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmbRange As System.Windows.Forms.ComboBox
    Public WithEvents cmbLong As System.Windows.Forms.ComboBox
	Public WithEvents cmbLat As System.Windows.Forms.ComboBox
    Public WithEvents txtLongDMS As System.Windows.Forms.TextBox
    Public WithEvents txtLatDMS As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents _Label4_0 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancelGPS As System.Windows.Forms.Button
    Public WithEvents cmdApplyGPS As System.Windows.Forms.Button
    Public WithEvents Label4 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents txtDMS As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGPS))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdShrink = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGPS = New System.Windows.Forms.TextBox()
        Me.cmdViewDMS = New System.Windows.Forms.Button()
        Me.cmbRange = New System.Windows.Forms.ComboBox()
        Me.cmbLong = New System.Windows.Forms.ComboBox()
        Me.cmbLat = New System.Windows.Forms.ComboBox()
        Me.txtLongDMS = New System.Windows.Forms.TextBox()
        Me.txtLatDMS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._Label4_0 = New System.Windows.Forms.Label()
        Me.MiniWeb = New System.Windows.Forms.WebBrowser()
        Me.cmdCancelGPS = New System.Windows.Forms.Button()
        Me.cmdApplyGPS = New System.Windows.Forms.Button()
        Me.Label4 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.txtDMS = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGoogleAddress = New System.Windows.Forms.Label()
        Me.lblZIPLat = New System.Windows.Forms.Label()
        Me.lblZIPLong = New System.Windows.Forms.Label()
        Me.cmdViewStreetTip = New System.Windows.Forms.Button()
        Me.cmdImportStreet = New System.Windows.Forms.Button()
        Me.cmdViewStreet = New System.Windows.Forms.Button()
        Me.cmdLookUpStreet = New System.Windows.Forms.Button()
        Me.txtAdd0 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDMSLat = New System.Windows.Forms.Label()
        Me.lblDMSLong = New System.Windows.Forms.Label()
        Me.txtLongDEC = New System.Windows.Forms.TextBox()
        Me.txtLatDEC = New System.Windows.Forms.TextBox()
        Me.cmdImportDec = New System.Windows.Forms.Button()
        Me.cmdViewDeg = New System.Windows.Forms.Button()
        Me.cmdConvertToDMS = New System.Windows.Forms.Button()
        Me.WebSee = New System.Windows.Forms.WebBrowser()
        Me.TmrClose = New System.Windows.Forms.Timer(Me.components)
        Me.TmrOpen = New System.Windows.Forms.Timer(Me.components)
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Me.Frame2.SuspendLayout()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.SystemColors.Control
        Label7.Cursor = System.Windows.Forms.Cursors.Default
        Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Label7.Location = New System.Drawing.Point(9, 27)
        Label7.Name = "Label7"
        Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label7.Size = New System.Drawing.Size(167, 14)
        Label7.TabIndex = 21
        Label7.Text = "Address, Zip Code, or Land mark"
        Me.ToolTip1.SetToolTip(Label7, "Enter street address, description, or a zip or postal code")
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.SystemColors.Control
        Label6.Cursor = System.Windows.Forms.Cursors.Default
        Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Label6.Location = New System.Drawing.Point(126, 207)
        Label6.Name = "Label6"
        Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label6.Size = New System.Drawing.Size(34, 14)
        Label6.TabIndex = 30
        Label6.Text = "Long:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.SystemColors.Control
        Label11.Cursor = System.Windows.Forms.Cursors.Default
        Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Label11.Location = New System.Drawing.Point(126, 195)
        Label11.Name = "Label11"
        Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label11.Size = New System.Drawing.Size(25, 14)
        Label11.TabIndex = 29
        Label11.Text = "Lat:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.BackColor = System.Drawing.SystemColors.Control
        Label12.Cursor = System.Windows.Forms.Cursors.Default
        Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Label12.Location = New System.Drawing.Point(120, 104)
        Label12.Name = "Label12"
        Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label12.Size = New System.Drawing.Size(34, 14)
        Label12.TabIndex = 30
        Label12.Text = "Long:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.BackColor = System.Drawing.SystemColors.Control
        Label13.Cursor = System.Windows.Forms.Cursors.Default
        Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Label13.Location = New System.Drawing.Point(120, 88)
        Label13.Name = "Label13"
        Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label13.Size = New System.Drawing.Size(25, 14)
        Label13.TabIndex = 29
        Label13.Text = "Lat:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.BackColor = System.Drawing.SystemColors.Control
        Label14.Cursor = System.Windows.Forms.Cursors.Default
        Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Label14.Location = New System.Drawing.Point(17, 56)
        Label14.Name = "Label14"
        Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label14.Size = New System.Drawing.Size(57, 14)
        Label14.TabIndex = 37
        Label14.Text = "Longitude:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.BackColor = System.Drawing.SystemColors.Control
        Label15.Cursor = System.Windows.Forms.Cursors.Default
        Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Label15.Location = New System.Drawing.Point(29, 27)
        Label15.Name = "Label15"
        Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label15.Size = New System.Drawing.Size(48, 14)
        Label15.TabIndex = 36
        Label15.Text = "Latitude:"
        '
        'cmdShrink
        '
        Me.cmdShrink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdShrink.Location = New System.Drawing.Point(821, 226)
        Me.cmdShrink.Name = "cmdShrink"
        Me.cmdShrink.Size = New System.Drawing.Size(17, 27)
        Me.cmdShrink.TabIndex = 23
        Me.cmdShrink.Text = "<"
        Me.ToolTip1.SetToolTip(Me.cmdShrink, "Hide the map")
        Me.cmdShrink.UseVisualStyleBackColor = True
        Me.cmdShrink.Visible = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Controls.Add(Me.txtGPS)
        Me.Frame2.Controls.Add(Me.cmdViewDMS)
        Me.Frame2.Controls.Add(Me.cmbRange)
        Me.Frame2.Controls.Add(Me.cmbLong)
        Me.Frame2.Controls.Add(Me.cmbLat)
        Me.Frame2.Controls.Add(Me.txtLongDMS)
        Me.Frame2.Controls.Add(Me.txtLatDMS)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me._Label4_0)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 6)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(318, 147)
        Me.Frame2.TabIndex = 13
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Coordinates in Lat/Lon DEG format"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(235, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Enter latitude, then longitude in decimal degrees"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(165, 14)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Example: 47.805776, -92.427979"
        '
        'txtGPS
        '
        Me.txtGPS.Location = New System.Drawing.Point(10, 35)
        Me.txtGPS.MaxLength = 32
        Me.txtGPS.Name = "txtGPS"
        Me.txtGPS.Size = New System.Drawing.Size(277, 20)
        Me.txtGPS.TabIndex = 19
        '
        'cmdViewDMS
        '
        Me.cmdViewDMS.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewDMS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewDMS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewDMS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewDMS.Location = New System.Drawing.Point(6, 113)
        Me.cmdViewDMS.Name = "cmdViewDMS"
        Me.cmdViewDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewDMS.Size = New System.Drawing.Size(113, 25)
        Me.cmdViewDMS.TabIndex = 4
        Me.cmdViewDMS.Text = "&View in Google..."
        Me.cmdViewDMS.UseVisualStyleBackColor = True
        '
        'cmbRange
        '
        Me.cmbRange.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRange.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRange.Location = New System.Drawing.Point(240, 114)
        Me.cmbRange.Name = "cmbRange"
        Me.cmbRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbRange.Size = New System.Drawing.Size(65, 22)
        Me.cmbRange.TabIndex = 5
        '
        'cmbLong
        '
        Me.cmbLong.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLong.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbLong.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLong.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLong.Location = New System.Drawing.Point(610, 83)
        Me.cmbLong.Name = "cmbLong"
        Me.cmbLong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbLong.Size = New System.Drawing.Size(65, 22)
        Me.cmbLong.TabIndex = 3
        Me.cmbLong.Visible = False
        '
        'cmbLat
        '
        Me.cmbLat.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLat.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbLat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLat.Location = New System.Drawing.Point(611, 35)
        Me.cmbLat.MaxDropDownItems = 20
        Me.cmbLat.Name = "cmbLat"
        Me.cmbLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbLat.Size = New System.Drawing.Size(64, 22)
        Me.cmbLat.TabIndex = 1
        Me.cmbLat.Text = "Combo1"
        Me.cmbLat.Visible = False
        '
        'txtLongDMS
        '
        Me.txtLongDMS.AcceptsReturn = True
        Me.txtLongDMS.BackColor = System.Drawing.SystemColors.Window
        Me.txtLongDMS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLongDMS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongDMS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDMS.SetIndex(Me.txtLongDMS, CType(4, Short))
        Me.txtLongDMS.Location = New System.Drawing.Point(434, 85)
        Me.txtLongDMS.MaxLength = 10
        Me.txtLongDMS.Name = "txtLongDMS"
        Me.txtLongDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLongDMS.Size = New System.Drawing.Size(158, 20)
        Me.txtLongDMS.TabIndex = 2
        Me.txtLongDMS.Visible = False
        '
        'txtLatDMS
        '
        Me.txtLatDMS.AcceptsReturn = True
        Me.txtLatDMS.BackColor = System.Drawing.SystemColors.Window
        Me.txtLatDMS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLatDMS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatDMS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDMS.SetIndex(Me.txtLatDMS, CType(0, Short))
        Me.txtLatDMS.Location = New System.Drawing.Point(434, 37)
        Me.txtLatDMS.MaxLength = 9
        Me.txtLatDMS.Name = "txtLatDMS"
        Me.txtLatDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLatDMS.Size = New System.Drawing.Size(158, 20)
        Me.txtLatDMS.TabIndex = 0
        Me.txtLatDMS.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(193, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(41, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Range:"
        '
        '_Label4_0
        '
        Me._Label4_0.AutoSize = True
        Me._Label4_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.SetIndex(Me._Label4_0, CType(0, Short))
        Me._Label4_0.Location = New System.Drawing.Point(431, 16)
        Me._Label4_0.Name = "_Label4_0"
        Me._Label4_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_0.Size = New System.Drawing.Size(69, 14)
        Me._Label4_0.TabIndex = 16
        Me._Label4_0.Text = " DD.MMSSss"
        '
        'MiniWeb
        '
        Me.MiniWeb.Location = New System.Drawing.Point(8, 416)
        Me.MiniWeb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MiniWeb.Name = "MiniWeb"
        Me.MiniWeb.Size = New System.Drawing.Size(110, 37)
        Me.MiniWeb.TabIndex = 36
        Me.MiniWeb.TabStop = False
        Me.MiniWeb.Visible = False
        Me.MiniWeb.WebBrowserShortcutsEnabled = False
        '
        'cmdCancelGPS
        '
        Me.cmdCancelGPS.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelGPS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelGPS.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelGPS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelGPS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelGPS.Location = New System.Drawing.Point(248, 415)
        Me.cmdCancelGPS.Name = "cmdCancelGPS"
        Me.cmdCancelGPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelGPS.Size = New System.Drawing.Size(81, 25)
        Me.cmdCancelGPS.TabIndex = 20
        Me.cmdCancelGPS.Text = "C&ancel"
        Me.cmdCancelGPS.UseVisualStyleBackColor = True
        '
        'cmdApplyGPS
        '
        Me.cmdApplyGPS.BackColor = System.Drawing.SystemColors.Control
        Me.cmdApplyGPS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdApplyGPS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdApplyGPS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdApplyGPS.Location = New System.Drawing.Point(164, 415)
        Me.cmdApplyGPS.Name = "cmdApplyGPS"
        Me.cmdApplyGPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdApplyGPS.Size = New System.Drawing.Size(81, 25)
        Me.cmdApplyGPS.TabIndex = 21
        Me.cmdApplyGPS.Text = "&OK"
        Me.cmdApplyGPS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGoogleAddress)
        Me.GroupBox1.Controls.Add(Me.lblZIPLat)
        Me.GroupBox1.Controls.Add(Me.lblZIPLong)
        Me.GroupBox1.Controls.Add(Me.cmdViewStreetTip)
        Me.GroupBox1.Controls.Add(Me.cmdImportStreet)
        Me.GroupBox1.Controls.Add(Me.cmdViewStreet)
        Me.GroupBox1.Controls.Add(Me.cmdLookUpStreet)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.txtAdd0)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox1.Location = New System.Drawing.Point(8, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 251)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Coordinates by Geocode(Google Lookup)"
        '
        'lblGoogleAddress
        '
        Me.lblGoogleAddress.Location = New System.Drawing.Point(9, 127)
        Me.lblGoogleAddress.Name = "lblGoogleAddress"
        Me.lblGoogleAddress.Size = New System.Drawing.Size(296, 64)
        Me.lblGoogleAddress.TabIndex = 39
        Me.lblGoogleAddress.Text = "(Address)"
        '
        'lblZIPLat
        '
        Me.lblZIPLat.AutoSize = True
        Me.lblZIPLat.Location = New System.Drawing.Point(163, 194)
        Me.lblZIPLat.Name = "lblZIPLat"
        Me.lblZIPLat.Size = New System.Drawing.Size(46, 14)
        Me.lblZIPLat.TabIndex = 38
        Me.lblZIPLat.Text = "0.00000"
        '
        'lblZIPLong
        '
        Me.lblZIPLong.AutoSize = True
        Me.lblZIPLong.Location = New System.Drawing.Point(162, 208)
        Me.lblZIPLong.Name = "lblZIPLong"
        Me.lblZIPLong.Size = New System.Drawing.Size(46, 14)
        Me.lblZIPLong.TabIndex = 37
        Me.lblZIPLong.Text = "0.00000"
        '
        'cmdViewStreetTip
        '
        Me.cmdViewStreetTip.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewStreetTip.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewStreetTip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewStreetTip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewStreetTip.Location = New System.Drawing.Point(293, 8)
        Me.cmdViewStreetTip.Name = "cmdViewStreetTip"
        Me.cmdViewStreetTip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewStreetTip.Size = New System.Drawing.Size(22, 20)
        Me.cmdViewStreetTip.TabIndex = 6
        Me.cmdViewStreetTip.Text = "?"
        Me.cmdViewStreetTip.UseVisualStyleBackColor = True
        Me.cmdViewStreetTip.Visible = False
        '
        'cmdImportStreet
        '
        Me.cmdImportStreet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImportStreet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImportStreet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportStreet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImportStreet.Location = New System.Drawing.Point(226, 219)
        Me.cmdImportStreet.Name = "cmdImportStreet"
        Me.cmdImportStreet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImportStreet.Size = New System.Drawing.Size(81, 25)
        Me.cmdImportStreet.TabIndex = 14
        Me.cmdImportStreet.Text = "Copy &To"
        Me.cmdImportStreet.UseVisualStyleBackColor = True
        '
        'cmdViewStreet
        '
        Me.cmdViewStreet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewStreet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewStreet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewStreet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewStreet.Location = New System.Drawing.Point(12, 219)
        Me.cmdViewStreet.Name = "cmdViewStreet"
        Me.cmdViewStreet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewStreet.Size = New System.Drawing.Size(113, 25)
        Me.cmdViewStreet.TabIndex = 12
        Me.cmdViewStreet.Text = "V&iew in Google..."
        Me.cmdViewStreet.UseVisualStyleBackColor = True
        '
        'cmdLookUpStreet
        '
        Me.cmdLookUpStreet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLookUpStreet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLookUpStreet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLookUpStreet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLookUpStreet.Location = New System.Drawing.Point(12, 194)
        Me.cmdLookUpStreet.Name = "cmdLookUpStreet"
        Me.cmdLookUpStreet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLookUpStreet.Size = New System.Drawing.Size(113, 25)
        Me.cmdLookUpStreet.TabIndex = 13
        Me.cmdLookUpStreet.Text = "Google Look&up"
        Me.cmdLookUpStreet.UseVisualStyleBackColor = True
        '
        'txtAdd0
        '
        Me.txtAdd0.AcceptsReturn = True
        Me.txtAdd0.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdd0.CausesValidation = False
        Me.txtAdd0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdd0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAdd0.Location = New System.Drawing.Point(9, 43)
        Me.txtAdd0.MaxLength = 155
        Me.txtAdd0.Multiline = True
        Me.txtAdd0.Name = "txtAdd0"
        Me.txtAdd0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdd0.ShortcutsEnabled = False
        Me.txtAdd0.Size = New System.Drawing.Size(298, 73)
        Me.txtAdd0.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDMSLat)
        Me.GroupBox2.Controls.Add(Me.lblDMSLong)
        Me.GroupBox2.Controls.Add(Me.txtLongDEC)
        Me.GroupBox2.Controls.Add(Me.txtLatDEC)
        Me.GroupBox2.Controls.Add(Label14)
        Me.GroupBox2.Controls.Add(Label15)
        Me.GroupBox2.Controls.Add(Me.cmdImportDec)
        Me.GroupBox2.Controls.Add(Me.cmdViewDeg)
        Me.GroupBox2.Controls.Add(Me.cmdConvertToDMS)
        Me.GroupBox2.Controls.Add(Label12)
        Me.GroupBox2.Controls.Add(Label13)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox2.Location = New System.Drawing.Point(365, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 145)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Find Coordinates by Lat/Long (Enter in Decimal)"
        Me.GroupBox2.Visible = False
        '
        'lblDMSLat
        '
        Me.lblDMSLat.AutoSize = True
        Me.lblDMSLat.Location = New System.Drawing.Point(152, 89)
        Me.lblDMSLat.Name = "lblDMSLat"
        Me.lblDMSLat.Size = New System.Drawing.Size(46, 14)
        Me.lblDMSLat.TabIndex = 40
        Me.lblDMSLat.Text = "0.00000"
        '
        'lblDMSLong
        '
        Me.lblDMSLong.AutoSize = True
        Me.lblDMSLong.Location = New System.Drawing.Point(152, 103)
        Me.lblDMSLong.Name = "lblDMSLong"
        Me.lblDMSLong.Size = New System.Drawing.Size(46, 14)
        Me.lblDMSLong.TabIndex = 39
        Me.lblDMSLong.Text = "0.00000"
        '
        'txtLongDEC
        '
        Me.txtLongDEC.AcceptsReturn = True
        Me.txtLongDEC.BackColor = System.Drawing.SystemColors.Window
        Me.txtLongDEC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLongDEC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongDEC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLongDEC.Location = New System.Drawing.Point(75, 53)
        Me.txtLongDEC.MaxLength = 11
        Me.txtLongDEC.Name = "txtLongDEC"
        Me.txtLongDEC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLongDEC.Size = New System.Drawing.Size(158, 20)
        Me.txtLongDEC.TabIndex = 16
        '
        'txtLatDEC
        '
        Me.txtLatDEC.AcceptsReturn = True
        Me.txtLatDEC.BackColor = System.Drawing.SystemColors.Window
        Me.txtLatDEC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLatDEC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatDEC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLatDEC.Location = New System.Drawing.Point(76, 25)
        Me.txtLatDEC.MaxLength = 11
        Me.txtLatDEC.Name = "txtLatDEC"
        Me.txtLatDEC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLatDEC.Size = New System.Drawing.Size(158, 20)
        Me.txtLatDEC.TabIndex = 15
        '
        'cmdImportDec
        '
        Me.cmdImportDec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImportDec.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImportDec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportDec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImportDec.Location = New System.Drawing.Point(229, 115)
        Me.cmdImportDec.Name = "cmdImportDec"
        Me.cmdImportDec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImportDec.Size = New System.Drawing.Size(81, 25)
        Me.cmdImportDec.TabIndex = 19
        Me.cmdImportDec.Text = "&Copy To"
        Me.cmdImportDec.UseVisualStyleBackColor = True
        '
        'cmdViewDeg
        '
        Me.cmdViewDeg.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewDeg.Location = New System.Drawing.Point(6, 113)
        Me.cmdViewDeg.Name = "cmdViewDeg"
        Me.cmdViewDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewDeg.Size = New System.Drawing.Size(113, 25)
        Me.cmdViewDeg.TabIndex = 17
        Me.cmdViewDeg.Text = "Vie&w in Google..."
        Me.cmdViewDeg.UseVisualStyleBackColor = True
        '
        'cmdConvertToDMS
        '
        Me.cmdConvertToDMS.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvertToDMS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConvertToDMS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvertToDMS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConvertToDMS.Location = New System.Drawing.Point(6, 88)
        Me.cmdConvertToDMS.Name = "cmdConvertToDMS"
        Me.cmdConvertToDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConvertToDMS.Size = New System.Drawing.Size(113, 25)
        Me.cmdConvertToDMS.TabIndex = 18
        Me.cmdConvertToDMS.Text = "Conv&ert to DMS"
        Me.cmdConvertToDMS.UseVisualStyleBackColor = True
        '
        'WebSee
        '
        Me.WebSee.AllowWebBrowserDrop = False
        Me.WebSee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebSee.Location = New System.Drawing.Point(335, 12)
        Me.WebSee.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebSee.Name = "WebSee"
        Me.WebSee.ScriptErrorsSuppressed = True
        Me.WebSee.Size = New System.Drawing.Size(480, 427)
        Me.WebSee.TabIndex = 22
        Me.WebSee.TabStop = False
        Me.WebSee.Url = New System.Uri("http://10", System.UriKind.Absolute)
        Me.WebSee.WebBrowserShortcutsEnabled = False
        '
        'TmrClose
        '
        Me.TmrClose.Interval = 10
        '
        'TmrOpen
        '
        Me.TmrOpen.Interval = 10
        '
        'frmGPS
        '
        Me.AcceptButton = Me.cmdApplyGPS
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancelGPS
        Me.ClientSize = New System.Drawing.Size(837, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.MiniWeb)
        Me.Controls.Add(Me.cmdShrink)
        Me.Controls.Add(Me.WebSee)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdCancelGPS)
        Me.Controls.Add(Me.cmdApplyGPS)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGPS"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Location Settings"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtAdd0 As System.Windows.Forms.TextBox
    Public WithEvents cmdViewDMS As System.Windows.Forms.Button
    Public WithEvents cmdImportStreet As System.Windows.Forms.Button
    Public WithEvents cmdViewStreet As System.Windows.Forms.Button
    Public WithEvents cmdLookUpStreet As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txtLongDEC As System.Windows.Forms.TextBox
    Public WithEvents txtLatDEC As System.Windows.Forms.TextBox
    Public WithEvents cmdImportDec As System.Windows.Forms.Button
    Public WithEvents cmdViewDeg As System.Windows.Forms.Button
    Public WithEvents cmdConvertToDMS As System.Windows.Forms.Button
    Public WithEvents cmdViewStreetTip As System.Windows.Forms.Button
    Friend WithEvents MiniWeb As System.Windows.Forms.WebBrowser
    Friend WithEvents lblZIPLat As System.Windows.Forms.Label
    Friend WithEvents lblZIPLong As System.Windows.Forms.Label
    Friend WithEvents lblGoogleAddress As System.Windows.Forms.Label
    Friend WithEvents lblDMSLat As System.Windows.Forms.Label
    Friend WithEvents lblDMSLong As System.Windows.Forms.Label
    Friend WithEvents WebSee As System.Windows.Forms.WebBrowser
    Friend WithEvents cmdShrink As System.Windows.Forms.Button
    Friend WithEvents TmrClose As System.Windows.Forms.Timer
    Friend WithEvents TmrOpen As System.Windows.Forms.Timer
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGPS As System.Windows.Forms.TextBox
#End Region
End Class