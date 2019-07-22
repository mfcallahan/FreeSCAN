Option Strict Off
Option Explicit On
Friend Class frmSplash
	Inherits System.Windows.Forms.Form
	Dim blnRan As Boolean
	
	Private Sub frmSplash_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Me.Close()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmSplash_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call NewSlogan()
    End Sub
    Sub NewSlogan()
        Dim strSlogan(70) As String
        Dim intPick As Integer
        On Error Resume Next

        strSlogan(0) = "Have you programmed with FreeSCAN lately?"
        strSlogan(1) = "Has no use for the colour pink."
        strSlogan(2) = "Quality, since 2007."
        strSlogan(3) = "For the serious scanner enthusiast"
        strSlogan(4) = "The Canadian Solution"
        strSlogan(5) = "Better then shareware."
        strSlogan(6) = "With Automatic Scanner Optimizer"
        strSlogan(7) = "The smart choice for scanner software"
        strSlogan(8) = "Scan the friendly airwaves"
        strSlogan(9) = "Recession proof"
        strSlogan(10) = "Not your father's scanner software"
        strSlogan(11) = "It scans the Llams's ass"
        strSlogan(12) = "Scanning has never been so good"
        strSlogan(13) = "It keeps on scanning, and scanning, and scanning...."
        strSlogan(14) = "More slogans then any other scanner software on the market"
        strSlogan(15) = "Compiled to perfection"
        strSlogan(16) = "Doesn't need to be bailed out"
        strSlogan(17) = "Never stop scanning"
        strSlogan(18) = "It's scanner time"
        strSlogan(19) = "Live in your world, scan in ours"
        strSlogan(20) = "Because you love to scan"
        strSlogan(21) = "Scanner software for the discerning wog"
        strSlogan(22) = "Scanning the world... one frequency at a time"
        strSlogan(23) = "Get'er scanned"
        strSlogan(24) = "See what the airwaves have in store"
        strSlogan(25) = "FreeSCAN gets it."
        strSlogan(26) = "The Way Its Meant To Be Scanned"
        strSlogan(27) = "Can you scan it now?"
        strSlogan(28) = "What do you want to scan today?"
        strSlogan(29) = "The software that powers scanning"
        strSlogan(30) = "Scanning for the digital world"
        strSlogan(31) = "A passion to scan"
        strSlogan(32) = "The airwaves are richer then you think"
        strSlogan(33) = "So easy a caveman can scan it"
        strSlogan(34) = "I just saved a bunch of money on scanner software by switching to FreeSCAN"
        strSlogan(35) = "Can't stop scanning"
        strSlogan(36) = "Bring out FreeSCAN, and bring out the best"
        strSlogan(37) = "It's not just for scanning anymore"
        strSlogan(38) = "Live to scan, scan to live"
        strSlogan(39) = "It can only be FreeSCAN"
        strSlogan(40) = "Good. Better. FreeSCAN."
        strSlogan(41) = "America runs on FreeSCAN"
        strSlogan(42) = "FreeSCAN. The choice of the new generation"
        strSlogan(43) = "Scan out of the ordinary"
        strSlogan(44) = "Makes scanners happy"
        strSlogan(45) = "Scan it your way"
        strSlogan(46) = "Something special on the air"
        strSlogan(47) = "We know why you scan. We're scannow.org"
        strSlogan(48) = "Scannists wanted."
        strSlogan(49) = "The ultimate scanning machine"
        strSlogan(50) = "You've got scanners. We've got programming software."
        strSlogan(51) = "Scanner strong."
        strSlogan(52) = "Accelerate Your Scanning"
        strSlogan(53) = "Scan something amazing"
        strSlogan(54) = "Better then a tax bill"
        strSlogan(55) = "Let's make scanning better"
        strSlogan(56) = "Now you're scanning with power!"
        strSlogan(57) = "Make scanning better."
        strSlogan(58) = "Those who know trust FreeSCAN."
        strSlogan(59) = "Is that a scanner in your pocket?"
        strSlogan(60) = "Have a happy scan. Always."
        strSlogan(61) = "The control you want, the programming you trust. Always."
        strSlogan(62) = "The one. The only. FreeSCAN"
        strSlogan(63) = "A scanner in need deserves FreeSCAN indeed."
        strSlogan(64) = "Scanning for the digital domain"
        strSlogan(65) = "Not affected by Facebook outtages."
        strSlogan(66) = "Not a belieber"
        strSlogan(67) = "Scanning is Job #1"
        strSlogan(68) = "My Little Scanner, Scanning is Magic"
        strSlogan(69) = "Save Money. Scan better."
        strSlogan(70) = "Just scan it."
        strSlogan(71) = "Scanning never goes out of style."
        strSlogan(72) = "Scannovation."
        strSlogan(73) = "Scanning people the world over"
        strSlogan(74) = "Let your scanners do the walking"
        strSlogan(75) = "I'm scanning it"
        strSlogan(76) = "A scanner is forever."
        strSlogan(77) = "Scan fresh"
        strSlogan(78) = "Reach out and scan someone"
        strSlogan(79) = "For the ultimate scan down there"
        strSlogan(80) = "Live life. Scan free."
        strSlogan(81) = "Strong enough for a transceiver, but made for a scanner"
        strSlogan(82) = "Scan your most confident every day"
        strSlogan(83) = "Everyone scans, so why not enjoy the scan with FreeSCAN"
        strSlogan(84) = "Make scanning great again"
        strSlogan(85) = "Keep scanning great"
        strSlogan(86) = "I'm with FreeSCAN"
        strSlogan(87) = "Scan Fresh"
        strSlogan(88) = "Scan the rainbow"
        strSlogan(89) = "Maybe she's born with it, Maybe it's FreeSCAN"
        strSlogan(90) = "For everything else, there's FreeSCAN"

        Randomize()
        intPick = Int((Rnd()) * 91)
        slogan.Text = strSlogan(intPick)
        frmAbout.slogan.Text = strSlogan(intPick)
    End Sub
	
	Private Sub Frame1_Click()
		Me.Visible = False
        lblSiteNote.blnBusy = False
        Timer1.Enabled = False
        Me.Close()
        lblSiteNote.Visible = True
	End Sub
	
	Private Sub Picture1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Picture1.Click
		Call Frame1_Click()
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		If blnRan = False Then
            blnRan = True

		Else
			Call Frame1_Click()
        End If
        Me.Visible = False
        Timer1.Enabled = False
	End Sub

    Private Sub frmSplash_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

    End Sub
End Class