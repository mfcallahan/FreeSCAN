Option Strict Off
Option Explicit On
Friend Class frmStats
	Inherits System.Windows.Forms.Form
	
    Function MakeStats() As String
        'generates statistics
        MakeStats = Nothing
        If blnDebug = False Then On Error Resume Next
        Dim strWait As String
        Dim intSys, intSite As Integer
        Dim intChan As Integer
        Dim sngMaxSites As Double
        Dim staChan, staSys, staSite, staGroup As Integer
        Dim staTrn As Double
        Dim p1, p2 As Double, strModel As String
        Me.Enabled = False
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor 'hourglass

        'freescan capacity

        sngMaxSites = (Val(CStr(MaxGroups)) - 20) * Val(CStr(MaxSystems))
        lblMaxSystem(0).Text = CStr(MaxSystems)

        lblMaxSites(0).Text = CStr(sngMaxSites)
        lblMaxGroups(0).Text = CStr(20 * MaxSystems)
        p1 = 32000 + Val(CStr(MaxTrunkFreq))


        lblMaxChannels(0).Text = Str(32000)

        strWait = "Compiling..."

        For intSite = 0 To 2

            lblSysUsed.Text = strWait
            lblSitesUsed.Text = strWait
            lblUsedGroups.Text = strWait
            lblUsedChannels.Text = strWait

        Next intSite
        
        intSite = 0
        For intSys = 1 To MaxSystems
            
            If varSite(intSys, 0, 0, 6) <> "" Then
                'how many systems
                staSys = staSys + 1
                'Conventional sites are normally counted                
                If Val(varSite(intSys, 0, 0, 3)) = 1 Then 'add conventional site
                    staSite = staSite + 1
                End If
                For intSite = 1 To MaxGroups
                    If Val(varSite(intSys, intSite, 0, 5)) = 1 Or Val(varSite(intSys, intSite, 0, 5)) = 2 Then
                        'how many groups
                        staGroup = staGroup + 1
                        For intChan = 1 To MaxChan
                            'how many channels in this group                           
                            If ChanInfo(intChan, 10) = varSite(intSys, intSite, 0, 10) Then
                                staChan = staChan + 1
                            End If
                        Next intChan
                    ElseIf Val(varSite(intSys, intSite, 0, 5)) = 3 Then
                        'how many sites
                        staSite = staSite + 1
                    End If
                Next intSite
            End If
        Next intSys
        For intSys = 1 To MaxTrunkFreq
            
            If strTrunkFreq(intSys, 0) <> "" Then
                staTrn = staTrn + 1
            End If
        Next intSys
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Enabled = True
        'general stats

        lblSysUsed.Text = CStr(staSys)
        lblSitesUsed.Text = CStr(staSite)
        lblUsedGroups.Text = CStr(staGroup)
        lblUsedChannels.Text = CStr(staChan + staTrn)

        'freescan capacity
        sngMaxSites = (Val(CStr(MaxGroups)) - 20) * Val(CStr(MaxSystems))
        lblMaxSystem(0).Text = MakePretty(staSys, MaxSystems)
        lblMaxSites(0).Text = MakePretty(staSite, sngMaxSites)
        lblMaxGroups(0).Text = MakePretty(staGroup, 20 * MaxSystems)
        p1 = Val(CStr(staChan)) + Val(CStr(staTrn))
        p2 = 32000
        lblMaxChannels(0).Text = MakePretty(Str(p1), Str(p2)) 'PROBLEM HER
        strModel = cmbModel.Text
        If strModel = "BCD996XT" Then strModel = "BCD396XT"
        If strModel = "BCT15X" Then strModel = "BC346XT"
        Select Case strModel
            Case "BCD396XT"
                lblMaxSystem(1).Text = MakePretty(staSys, 500)
                lblMaxSites(1).Text = MakePretty(staSite, 1000)
                lblMaxGroups(1).Text = MakePretty(staGroup, 20 * 500)
                lblMaxChannels(1).Text = MakePretty(staTrn + staChan, 25000)
            Case "BC346XT"
                lblMaxSystem(1).Text = MakePretty(staSys, 500)
                lblMaxSites(1).Text = MakePretty(staSite, 1000)
                lblMaxGroups(1).Text = MakePretty(staGroup, 20 * 500)
                lblMaxChannels(1).Text = MakePretty(staTrn + staChan, 9000)
            Case "BCD996T"
                '996 capacity
                lblMaxSystem(1).Text = MakePretty(staSys, 500)
                lblMaxSites(1).Text = MakePretty(staSite, 1000)
                lblMaxGroups(1).Text = MakePretty(staGroup, 20 * 500)
                lblMaxChannels(1).Text = MakePretty(staTrn + staChan, 6000)
            Case "BC15T"
                '15 capacity
                lblMaxSystem(1).Text = MakePretty(staSys, 500)
                lblMaxSites(1).Text = MakePretty(staSite, 1000)
                lblMaxGroups(1).Text = MakePretty(staGroup, 20 * 500)
                lblMaxChannels(1).Text = MakePretty(staTrn + staChan, 2500)
            Case "BCD396T"
                '396 capacity
                lblMaxSystem(1).Text = MakePretty(staSite, 400)
                lblMaxSites(1).Text = MakePretty(staSite, 400)
                lblMaxGroups(1).Text = MakePretty(staGroup, 20 * 400)
                lblMaxChannels(1).Text = MakePretty(staTrn + staChan, 6000)
            Case "BR330T"
                '330 capacity
                lblMaxSystem(1).Text = MakePretty(staSite, 200)
                lblMaxSites(1).Text = MakePretty(staSite, 200)
                lblMaxGroups(1).Text = MakePretty(staGroup, 20 * 200)
                lblMaxChannels(1).Text = MakePretty(staTrn + staChan, 2500)
            Case "BC246T"
                '246 capacity
                lblMaxSystem(1).Text = MakePretty(staSite, 200)
                lblMaxSites(1).Text = MakePretty(staSite, 200)
                lblMaxGroups(1).Text = MakePretty(staGroup, 3050)
                lblMaxChannels(1).Text = MakePretty(staTrn + (staChan * 2), 2500)
        End Select





    End Function
    Function MakePretty(ByRef intCnt As Integer, ByRef intMax As Integer) As String
        If intMax = 0 Then intMax = 1
        MakePretty = Val(intMax) & " (" & Int((intCnt / intMax) * 100) & "% used)"
    End Function

    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
        Me.Visible = False

    End Sub

    Private Sub frmStats_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With cmbModel.Items
            .Clear()
            .Add("BCD996XT")
            .Add("BCT15X")
            .Add("BCD396XT")
            .Add("BC346XT")
            .Add("BCD996T")
            .Add("BC15T")
            .Add("BCD396T")
            .Add("BR330T")
            .Add("BC246T")
        End With
        cmbModel.SelectedIndex = 0
    End Sub

    Private Sub cmbModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModel.SelectedIndexChanged
        Call MakeStats()
    End Sub
End Class