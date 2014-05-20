Public Class YTVL
    Dim Vars As String
    Private Sub LoadYTVL() Handles Me.Load
        chkShowNotification.Checked = My.Settings.ShowNotification.ToString
        NotifyIcon.Visible = My.Settings.ShowNotification.ToString
    End Sub

    'Buttons

    Private Sub BuildVars()
        Vars = txtComboVID.Text.ToString
        If chkFeather.Checked = True Then
            Vars = Vars & "&noFeather=True"
        End If
        If chkHL.Checked = True Then
            Vars = Vars & "&hl=en"
        End If
        If txtTime.Text.ToString <> "" And txtTime.Text.ToString <> "Time (e.g. 1m5s)" Then
            Vars = Vars & "&t=" & txtTime.Text.ToString
        End If
        If txtList.Text.ToString <> "" And txtList.Text.ToString <> "List" Then
            Vars = Vars & "&list=" & txtList.Text.ToString
        End If
    End Sub
    Private Sub OpenVideo(sender As Object, e As EventArgs) Handles btnVideo.Click, VideoToolStripMenuItem.Click
        BuildVars()
        Process.Start("http://www.youtube.com/watch?v=" & Vars.ToString)
    End Sub

    Private Sub OpenComments(sender As Object, e As EventArgs) Handles btnComments.Click, CommentsToolStripMenuItem.Click
        BuildVars()
        Process.Start("http://www.youtube.com/all_comments?v=" & Vars.ToString)
    End Sub

    Private Sub OpenVideoInfo(sender As Object, e As EventArgs) Handles btnVideoInfo.Click, VideoInfoToolStripMenuItem.Click
        BuildVars()
        Process.Start("http://www.youtube.com/get_video_info?video_id=" & Vars.ToString & "&fmt=18")
    End Sub

    Private Sub OpenEmbeddedObject(sender As Object, e As EventArgs) Handles btnEmbed.Click, EmbedToolStripMenuItem.Click
        BuildVars()
        Process.Start("http://www.youtube.com/embed/" & Vars.ToString)
    End Sub

    Private Sub ResetForm(sender As Object, e As EventArgs) Handles btnReset.Click
        txtComboVID.Text = "Video ID"
        txtTime.Text = "Time (e.g. 1m5s)"
        txtList.Text = "List"
        chkFeather.Checked = False
        chkHL.Checked = False
        Me.Height = 230
        Me.Width = 506
        btnAdvanced.Text = "More ↓"
    End Sub

    Private Sub MoreLess(sender As Object, e As EventArgs) Handles btnAdvanced.Click
        If Me.Height = 400 Then
            Me.Height = 230
            btnAdvanced.Text = "More ↓"
        Else
            Me.Height = 400
            btnAdvanced.Text = "Less ↑"
        End If
    End Sub

    Private Sub CloseYTVL(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ShowYTVL(sender As Object, e As EventArgs) Handles ShowYTVLToolStripMenuItem.Click, NotifyIcon.DoubleClick
        Me.Show()
        Me.BringToFront()
        Me.Activate()
    End Sub

    Private Sub ShowNotification_Changed(sender As Object, e As EventArgs) Handles chkShowNotification.CheckedChanged
        My.Settings.ShowNotification.ToString = chkShowNotification.Checked
        NotifyIcon.Visible = My.Settings.ShowNotification
    End Sub

    'Links

    Private Sub OpenFeatherLink(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFeather.LinkClicked
        Process.Start("https://www.youtube.com/testtube")
    End Sub

    Private Sub OpenOriginalPage(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkOriginalPage.LinkClicked
        Process.Start("http://walkman100.github.io/Walkman/youtube-video-stuff.htm")
    End Sub

    Private Sub OpenSourceCode(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSourceCode.LinkClicked
        Process.Start("https://github.com/Walkman100/YTVL/")
    End Sub

    Private Sub ReportProblem(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReportProblem.LinkClicked
        Process.Start("https://github.com/Walkman100/YTVL/issues/new")
    End Sub

    Private Sub OpenReleases(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReleases.LinkClicked
        Process.Start("https://github.com/Walkman100/YTVL/releases/latest")
    End Sub

    Private Sub OpenWalkmanPage(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkWalkman.LinkClicked
        Process.Start("http://twitter.com/Walkman100")
    End Sub

    'Text control

    Private Sub txtComboVID_Enter(sender As Object, e As EventArgs) Handles txtComboVID.Click
        If txtComboVID.Text = "Video ID" Then
            txtComboVID.Text = ""
        Else
            txtComboVID.SelectAll()
        End If
    End Sub

    Private Sub txtComboVID_Leave(sender As Object, e As EventArgs) Handles txtComboVID.Leave
        If txtComboVID.Text = "" Then
            txtComboVID.Text = "Video ID"
        ElseIf txtComboVID.Text <> "Video ID" Then
            If txtComboVID.Items.Contains(txtComboVID.Text) Then

            Else
                txtComboVID.Items.Add(txtComboVID.Text.ToString)
            End If
        End If
    End Sub

    Private Sub txtTime_Enter(sender As Object, e As EventArgs) Handles txtTime.Click
        If txtTime.Text = "Time (e.g. 1m5s)" Then
            txtTime.Text = ""
        Else
            txtTime.SelectAll()
        End If
    End Sub

    Private Sub txtTime_Leave(sender As Object, e As EventArgs) Handles txtTime.Leave
        If txtTime.Text = "" Then
            txtTime.Text = "Time (e.g. 1m5s)"
        End If
    End Sub

    Private Sub txtList_Enter(sender As Object, e As EventArgs) Handles txtList.Click
        If txtList.Text = "List" Then
            txtList.Text = ""
        Else
            txtList.SelectAll()
        End If
    End Sub

    Private Sub txtList_Leave(sender As Object, e As EventArgs) Handles txtList.Leave
        If txtList.Text = "" Then
            txtList.Text = "List"
        End If
    End Sub

End Class
