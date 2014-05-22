Public Class YTVL
    Dim Vars As String
    Dim usehttps As String = "https"

    Private Sub LoadYTVL() Handles Me.Load
        'apply settings to where they are changed
        chkShowNotification.Checked = My.Settings.ShowNotification
        chkUpdate.Checked = My.Settings.AutoUpdateCheck

        'apply settings to where they affect
        lblCurrentVersion.Text = "Current: v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        NotifyIcon.Visible = My.Settings.ShowNotification
        If My.Settings.AutoUpdateCheck = True Then
            'load latest version
            WebBrowserVersionCheck.Navigate("http://walkman100.github.io/Walkman/YTVL/ver.txt")
        End If
    End Sub

    Private Sub CheckAgainstLatest(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserVersionCheck.DocumentCompleted
        If My.Settings.AutoUpdateCheck = True Then
            'check if this version is latest
            If My.Application.Info.Version.ToString < WebBrowserVersionCheck.Document.Body.InnerText.ToString Then
                If MsgBox("Current version: " & My.Application.Info.Version.ToString & " - Latest version: " & WebBrowserVersionCheck.Document.Body.InnerText.ToString & vbNewLine & "Click OK to download the latest version", MsgBoxStyle.OkCancel, "Update found!") = MsgBoxResult.Ok Then
                    Process.Start("https://github.com/Walkman100/YTVL/releases/latest")
                End If 'yes, this entire sub could be put on one line, but that line would be incredibly long
            End If
        End If
    End Sub

    'Buttons

    Private Sub BuildVars()         'they are built in order of the form
        Vars = txtComboVID.Text
        If txtTime.Text <> "" And txtTime.Text <> "Time (e.g. 1m5s)" Then
            Vars = Vars & "&t=" & txtTime.Text
        End If
        If txtList.Text <> "" And txtList.Text <> "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)" Then
            Vars = Vars & "&list=" & txtList.Text
        End If
        If chkFeather.Checked = True Then Vars = Vars & "&noFeather=True"
        If chkHL.Checked = True Then Vars = Vars & "&hl=en"
        If optQuality360.Checked = True Then Vars = Vars & "&hd=0"
        If optQuality720.Checked = True Then Vars = Vars & "&hd=1"
        If chkFeature.Checked = True Then Vars = Vars & "&feature=player_embedded"
        If optAutoplay0.Checked = True Then Vars = Vars & "&autoplay=0"
        If optAutoplay1.Checked = True Then Vars = Vars & "&autoplay=1"
        If optFs0.Checked = True Then Vars = Vars & "&fs=0"
        If optFs1.Checked = True Then Vars = Vars & "&fs=1"
        If optAutohide0.Checked = True Then Vars = Vars & "&autohide=0"
        If optAutohide1.Checked = True Then Vars = Vars & "&autohide=1"
        If optEnableJsApi0.Checked = True Then Vars = Vars & "&enablejsapi=0"
        If optEnableJsApi1.Checked = True Then Vars = Vars & "&enablejsapi=1"
        If optIvLP.Text <> "" Then Vars = Vars & "&" & optIvLP.Text
        If optMdstBrndng0.Checked = True Then Vars = Vars & "&modestbranding=0"
        If optMdstBrndng1.Checked = True Then Vars = Vars & "&modestbranding=1"
        If optRel0.Checked = True Then Vars = Vars & "&rel=0"
        If optRel1.Checked = True Then Vars = Vars & "&rel=1"
        If optShowinfo0.Checked = True Then Vars = Vars & "&showinfo=0"
        If optShowinfo1.Checked = True Then Vars = Vars & "&showinfo=1"
        If optShowsearch0.Checked = True Then Vars = Vars & "&showsearch=0"
        If optShowsearch1.Checked = True Then Vars = Vars & "&showsearch=1"
        If chkThemeDark.Checked = True Then Vars = Vars & "&theme=dark"
        If chkWmode.Checked = True Then Vars = Vars & "&wmode=transparent"
        If chkOrigin.Checked = True And txtOrigin.Text <> "(e.g. http://9gag.tv)" Then
            Vars = Vars & "&origin=" & txtOrigin.Text
        End If
    End Sub

    Sub MsgNoVID()
        MsgBox("Please fill in a video ID!", MsgBoxStyle.Critical, "No Video ID entered")
        WindowState = FormWindowState.Normal
        Me.BringToFront()
        txtComboVID.SelectAll()
    End Sub

    Private Sub OpenVideo(sender As Object, e As EventArgs) Handles btnVideo.Click, VideoToolStripMenuItem.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Process.Start(usehttps & "://www.youtube.com/watch?v=" & Vars)
        End If
    End Sub

    Private Sub OpenComments(sender As Object, e As EventArgs) Handles btnComments.Click, CommentsToolStripMenuItem.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Process.Start(usehttps & "://www.youtube.com/all_comments?v=" & Vars)
        End If
    End Sub

    Private Sub OpenVideoInfo(sender As Object, e As EventArgs) Handles btnVideoInfo.Click, VideoInfoToolStripMenuItem.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Process.Start(usehttps & "://www.youtube.com/get_video_info?video_id=" & Vars & "&fmt=18")
        End If
    End Sub

    Private Sub OpenEmbeddedObject(sender As Object, e As EventArgs) Handles btnEmbed.Click, EmbedToolStripMenuItem.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Process.Start(usehttps & "://www.youtube.com/embed/" & Vars)
        End If
    End Sub

    Private Sub ResetForm(sender As Object, e As EventArgs) Handles btnReset.Click
        'text boxes
        txtComboVID.Text = "Video ID"
        txtTime.Text = "Time (e.g. 1m5s)"
        txtList.Text = "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)"
        txtOrigin.Text = "(e.g. http://9gag.tv)"

        'check boxes
        chkFeather.Checked = False
        chkHL.Checked = False
        chkFeature.Checked = False
        chkThemeDark.Checked = False
        chkWmode.Checked = False
        chkOrigin.Checked = False
        chkHttps.Checked = True

        'radio boxes [opt__]
        optQuality360.Checked = False
        optQuality720.Checked = False
        optAutoplay0.Checked = False
        optAutoplay1.Checked = False
        optFs0.Checked = False
        optFs1.Checked = False
        optAutohide0.Checked = False
        optAutohide1.Checked = False
        optEnableJsApi0.Checked = False
        optEnableJsApi1.Checked = False
        optIvLP.Text = ""                   'not a radio box, but still [opt__]
        optMdstBrndng0.Checked = False
        optMdstBrndng1.Checked = False
        optRel0.Checked = False
        optRel1.Checked = False
        optShowinfo0.Checked = False
        optShowinfo1.Checked = False
        optShowsearch0.Checked = False
        optShowsearch1.Checked = False


        'other
        Me.Height = 230
        Me.Width = 506
        btnAdvanced.Text = "More ↓"
    End Sub

    Private Sub CloseYTVL(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click, btnExit.Click
        Application.Exit()
    End Sub

    Private Sub ShowYTVL(sender As Object, e As EventArgs) Handles ShowYTVLToolStripMenuItem.Click, NotifyIcon.DoubleClick
        WindowState = FormWindowState.Normal
        'Me.Show()
        Me.BringToFront()
        'Me.Activate()
    End Sub

    'Changes e.g. settings

    Private Sub MoreLess(sender As Object, e As EventArgs) Handles btnAdvanced.Click
        If Me.Height = 362 Then
            Me.Height = 230
            btnAdvanced.Text = "More ↓"
        Else
            Me.Height = 362
            btnAdvanced.Text = "Less ↑"
        End If
    End Sub

    Private Sub ShowNotification_Click(sender As Object, e As EventArgs) Handles chkShowNotification.Click
        My.Settings.ShowNotification = chkShowNotification.Checked
        My.Settings.Save()
        NotifyIcon.Visible = My.Settings.ShowNotification
    End Sub

    Private Sub HideIconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideIconToolStripMenuItem.Click
        My.Settings.ShowNotification = False
        My.Settings.Save()
        chkShowNotification.Checked = False
        NotifyIcon.Visible = False
    End Sub

    Private Sub chkUpdate_Click(sender As Object, e As EventArgs) Handles chkUpdate.Click
        My.Settings.AutoUpdateCheck = chkUpdate.Checked
        My.Settings.Save()
        If chkUpdate.Checked = True Then
            WebBrowserVersionCheck.Navigate("http://walkman100.github.io/Walkman/YTVL/ver.txt")
        End If
    End Sub

    Private Sub chkHttps_Click(sender As Object, e As EventArgs) Handles chkHttps.Click
        If chkHttps.Checked = True Then
            usehttps = "https"
        Else
            usehttps = "http"
        End If
    End Sub

    'Links

    Private Sub OpenFeatherLink(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblFeather.LinkClicked
        Process.Start(usehttps & "://www.youtube.com/testtube")
    End Sub

    Private Sub OpenOriginalPage(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkOriginalPage.LinkClicked
        Process.Start("http://walkman100.github.io/Walkman/youtube-video-stuff.htm") '*.github.io doesn't support https!
    End Sub

    Private Sub OpenSourceCode(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSourceCode.LinkClicked
        Process.Start(usehttps & "://github.com/Walkman100/YTVL/")
    End Sub

    Private Sub ReportProblem(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReportProblem.LinkClicked
        Process.Start(usehttps & "://github.com/Walkman100/YTVL/issues/new")
    End Sub

    Private Sub OpenReleases(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReleases.LinkClicked
        Process.Start(usehttps & "://github.com/Walkman100/YTVL/releases/latest")
    End Sub

    Private Sub OpenDeveloperPage(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDeveloper.LinkClicked
        Process.Start(usehttps & "://twitter.com/Walkman100")
    End Sub

    'Text control

    Private Sub txtComboVID_Enter(sender As Object, e As EventArgs) Handles txtComboVID.MouseDown
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
                txtComboVID.Items.Add(txtComboVID.Text)
            End If
        End If
    End Sub

    Private Sub txtTime_Enter(sender As Object, e As EventArgs) Handles txtTime.MouseDown
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

    Private Sub txtList_Enter(sender As Object, e As EventArgs) Handles txtList.MouseDown
        If txtList.Text = "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)" Then
            txtList.Text = ""
        Else
            txtList.SelectAll()
        End If
    End Sub

    Private Sub txtList_Leave(sender As Object, e As EventArgs) Handles txtList.Leave
        If txtList.Text = "" Then
            txtList.Text = "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)"
        End If
    End Sub

    Private Sub txtOrigin_Enter(sender As Object, e As EventArgs) Handles txtOrigin.MouseDown
        If txtOrigin.Text = "(e.g. http://9gag.tv)" Then
            txtOrigin.Text = ""
        Else
            txtOrigin.SelectAll()
        End If
    End Sub

    Private Sub txtOrigin_Leave(sender As Object, e As EventArgs) Handles txtOrigin.Leave
        If txtOrigin.Text = "" Then
            txtOrigin.Text = "(e.g. http://9gag.tv)"
        End If
    End Sub

End Class
