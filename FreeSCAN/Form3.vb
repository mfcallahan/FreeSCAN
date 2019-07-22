Public Class frmFSSetup

    Private Sub _chkPref_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUpdateStartup.CheckedChanged

    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        'grid alternate backcolor
        SaveSetting("FreeSCAN", "Settings", "AltColour", CStr(chkAltColor.CheckState))

        'save preferences

        'Canadian Bias

        If radBias1.Checked Then
            UseCdnBias = False
        Else
            UseCdnBias = True
        End If
        SaveSetting("FreeSCAN", "Settings", "Canadian", CStr(MakeBinary(CStr(UseCdnBias))))
        'backlight mode for handhelds
        SaveSetting("FreeSCAN", "Settings", "DeleteWarn", CStr(chkDelWarn.CheckState))
        lblSiteNote.WarnDelete = chkDelWarn.Checked
        SaveSetting("FreeSCAN", "Settings", "Blind", CStr(chkBlind.CheckState))

        SaveSetting("FreeSCAN", "Settings", "ForceCCO", CStr(chkForceCCO.CheckState))
        SaveSetting("FreeSCAN", "Settings", "CheckUpdateStartup", CStr(chkUpdateStartup.CheckState))
        SaveSetting("FreeSCAN", "Settings", "Splash", CStr(chkSplash.CheckState))
        lblSiteNote.blnSplash = chkSplash.Checked
        SaveSetting("FreeSCAN", "Settings", "WarnInvalidFreq", CStr(chkWarnInvalidFreq.CheckState))
        lblSiteNote.blnWarnInvalidFreq = chkWarnInvalidFreq.Checked
        Me.Visible = False
        lblSiteNote.DispStat("Settings saved.")
    End Sub
    Sub LoadData()

        Dim MyString As String = Nothing
        Dim strBuff As String = Nothing

        cmdClearFile.Enabled = True
        'Save settings
        chkForceCCO.Checked = MakeBoolean(GetSetting("FreeSCAN", "Settings", "ForceCCO", "1"))
        If UseCdnBias Then
            radBias2.Checked = True
        Else
            radBias1.Checked = True
        End If
        'preferences

        chkDelWarn.Checked = lblSiteNote.WarnDelete
        chkBlind.Checked = MakeBoolean(GetSetting("FreeSCAN", "Settings", "Blind", "0"))
        'grid alternate colours
        chkAltColor.Checked = MakeBoolean(GetSetting("FreeSCAN", "Settings", "AltColour", "0"))
        chkUpdateStartup.Checked = lblSiteNote.blnCheckUpdateStartup
        chkSplash.Checked = lblSiteNote.blnSplash
        chkWarnInvalidFreq.Checked = lblSiteNote.blnWarnInvalidFreq
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'Cancel without saving any settings
        Me.Visible = False

    End Sub

    Private Sub cmdClearFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearFile.Click
        'clears the recently accessed file list

        SaveSetting("FreeSCAN", "Settings", "File0", "")

        SaveSetting("FreeSCAN", "Settings", "File1", "")

        SaveSetting("FreeSCAN", "Settings", "File2", "")

        SaveSetting("FreeSCAN", "Settings", "File3", "")
        lblSiteNote.LoadFileList()
        cmdClearFile.Enabled = False
    End Sub
End Class