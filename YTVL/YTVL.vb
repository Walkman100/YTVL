Public Class YTVL
    Dim Vars As String

    'Buttons

    Private Sub BuildVars()
        Vars = txtComboVID.Text
        If chkFeather.Checked = True Then
            Vars = Vars & "&noFeather=True"
        End If
        If chkHL.Checked = True Then
            Vars = Vars & "&hl=en"
        End If
        If txtTime.Text <> "" And txtTime.Text <> "Time" Then
            Vars = Vars & "&t=" & txtTime.Text
        End If
        If txtList.Text <> "" And txtList.Text <> "List" Then
            Vars = Vars & "&list=" & txtList.Text
        End If
    End Sub
    Private Sub OpenVideo(sender As Object, e As EventArgs) Handles btnVideo.Click
        BuildVars()
        Process.Start("http://www.youtube.com/watch?v=" & Vars)
    End Sub

    Private Sub OpenComments(sender As Object, e As EventArgs) Handles btnComments.Click
        BuildVars()
        Process.Start("http://www.youtube.com/all_comments?v=" & Vars)
    End Sub

    Private Sub OpenVideoInfo(sender As Object, e As EventArgs) Handles btnVideoInfo.Click
        BuildVars()
        Process.Start("http://www.youtube.com/get_video_info?video_id=" & Vars & "&fmt=18")
    End Sub

    Private Sub OpenEmbeddedObject(sender As Object, e As EventArgs) Handles btnEmbed.Click
        BuildVars()
        Process.Start("http://www.youtube.com/embed/" & Vars)
    End Sub

    Private Sub ResetForm(sender As Object, e As EventArgs) Handles btnReset.Click
        txtComboVID.Text = "Video ID"
        txtTime.Text = "Time"
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
                txtComboVID.Items.Add(txtComboVID.Text)
            End If
        End If
    End Sub

    Private Sub txtTime_Enter(sender As Object, e As EventArgs) Handles txtTime.Click
        If txtTime.Text = "Time" Then
            txtTime.Text = ""
        Else
            txtTime.SelectAll()
        End If
    End Sub

    Private Sub txtTime_Leave(sender As Object, e As EventArgs) Handles txtTime.Leave
        If txtTime.Text = "" Then
            txtTime.Text = "Time"
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
