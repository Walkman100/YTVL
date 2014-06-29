﻿Public Class YTVL
    Dim dblQuote as string = Chr(34) 'Chr$(34)
    Dim Vars As String = ""
    Dim usehttps As String = "https"
    Dim openIn As String = ""
    Dim latestVer As String
    Dim CopyWhat As String
    Dim CopyWhatEntire As String = "Nothing yet"

    Private Sub LoadYTVL() Handles Me.Load, MyBase.Load
        'apply settings to where they are changed
        chkShowNotification.Checked = My.Settings.ShowNotification
        chkUpdate.Checked = My.Settings.AutoUpdateCheck
        NotificationMenuStripKeepOnTop.Checked = My.Settings.KeepOnTop
        chkKeepOnTop.Checked = My.Settings.KeepOnTop

        'apply settings to where they affect
        lblCurrentVersion.Text = "Current: v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
        NotificationIcon.Visible = My.Settings.ShowNotification
        If My.Settings.AutoUpdateCheck = True Then 'load latest version
            WebBrowserVersionCheck.Navigate("https://github.com/Walkman100/YTVL/releases/latest")
        End If
        Me.TopMost = My.Settings.KeepOnTop
    End Sub

    Private Sub CheckAgainstLatest(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserVersionCheck.DocumentCompleted
    	latestVer = Mid(WebBrowserVersionCheck.Url.ToString, 50)
    	'WebBrowserVersionCheck.InnerText = latestVer	'this is supposed to clear the contents of the browser to reduce RAM usage, but the command doesn't seem to exist
        NotificationIcon.Text = "YouTube Video Linker" & vbNewLine & "Current ver: " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & " Latest ver: " & latestVer
        If My.Settings.AutoUpdateCheck = True Then
            'check if this version is latest
            If My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build < latestVer Then
                If MsgBox("Current version: " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & " - Latest version: " & latestVer & vbNewLine & "Click OK to download the latest version", MsgBoxStyle.OkCancel, "Update found!") = MsgBoxResult.Ok Then
                    Process.Start("https://github.com/Walkman100/YTVL/releases/latest")
                End If 'yes, this entire sub could be put on one line, but that line would be incredibly long
            End If
        End If
    End Sub

    'Opening links & copying stuff

    Private Sub BuildVars()         'they are built in order of the form
        Vars = ""
        If txtTime.Text <> "" And txtTime.Text <> "Time (e.g. 1m5s)" Then
            Vars = Vars & "&t=" & txtTime.Text
        End If
        If txtList.Text <> "" And txtList.Text <> "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)" Then
            Vars = Vars & "&list=" & txtList.Text
        End If
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
        If txtComboBrowser.Text="Default link handler" Or txtComboBrowser.Text = "Browse..." Or txtComboBrowser.Text = "" Then
            openIn = ""
        ElseIf txtComboBrowser.Text = "Mozilla Firefox (%ProgramFiles%\Mozilla Firefox\firefox.exe)"
            openIn = dblQuote & "%ProgramFiles%\Mozilla Firefox\firefox.exe" & dblQuote & " "
        ElseIf txtComboBrowser.Text = "Google Chrome (%ProgramFiles%\Google\Chrome\Application\chrome.exe)"
            openIn = dblQuote & "%ProgramFiles%\Google\Chrome\Application\chrome.exe" & dblQuote & " "
        ElseIf txtComboBrowser.Text = "Opera 22 (%ProgramFiles%\Opera\launcher.exe)"
            openIn = dblQuote & "%ProgramFiles%\Opera\launcher.exe" & dblQuote & " "
        ElseIf txtComboBrowser.Text = "Opera 12 (%ProgramFiles%\Opera\opera.exe)"
            openIn = dblQuote & "%ProgramFiles%\Opera\opera.exe" & dblQuote & " "
        ElseIf txtComboBrowser.Text = "Safari (%ProgramFiles%\Safari\Safari.exe)"
            openIn = dblQuote & "%ProgramFiles%\Safari\Safari.exe" & dblQuote & " "
        ElseIf txtComboBrowser.Text = "Avant Browser (%ProgramFiles%\Avant Browser\avant.exe)"
            openIn = dblQuote & "%ProgramFiles%\Avant Browser\avant.exe" & dblQuote & " "
        ElseIf txtComboBrowser.Text = "Lunascape6 (%ProgramFiles%\Lunascape\Lunascape6\Luna.exe)"
            openIn = dblQuote & "%ProgramFiles%\Lunascape\Lunascape6\Luna.exe" & dblQuote & " "
        ElseIf txtComboBrowser.Text = "Sea Monkey (%ProgramFiles%\SeaMonkey\seamonkey.exe)"
            openIn = dblQuote & "%ProgramFiles%\SeaMonkey\seamonkey.exe" & dblQuote & " "
        ElseIf txtComboBrowser.Text = "Internet Explorer (%ProgramFiles%\Internet Explorer\iexplore.exe)"
            openIn = dblQuote & "%ProgramFiles%\Internet Explorer\iexplore.exe" & dblQuote & " "
        ElseIf txtComboBrowser.Text = "Netscape Navigator 9 (%ProgramFiles%\Netscape\Navigator 9\navigator.exe)"
            openIn = dblQuote & "%ProgramFiles%\Netscape\Navigator 9\navigator.exe" & dblQuote & " "
        Else
            openIn = dblQuote & txtComboBrowser.Text & dblQuote & " "
        End If
    End Sub

    Sub MsgNoVID()
        MsgBox("Please fill in a video ID!", MsgBoxStyle.Critical, "No Video ID entered")
        WindowState = FormWindowState.Normal
        Me.BringToFront()
        txtComboVID.SelectAll()
    End Sub

    Private Sub OpenVideo(sender As Object, e As EventArgs) Handles btnVideo.Click, NotificationMenuStripVideo.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Process.Start(openIn & usehttps & "://www.youtube.com/watch?v=" & txtComboVID.Text & Vars)
        End If
    End Sub

    Private Sub OpenComments(sender As Object, e As EventArgs) Handles btnComments.Click, NotificationMenuStripComments.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Process.Start(openIn & usehttps & "://www.youtube.com/all_comments?v=" & txtComboVID.Text & Vars)
        End If
    End Sub

    Private Sub OpenVideoInfo(sender As Object, e As EventArgs) Handles btnVideoInfo.Click, NotificationMenuStripVideoInfo.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Process.Start(openIn & usehttps & "://www.youtube.com/get_video_info?video_id=" & txtComboVID.Text & Vars & "&fmt=18")
        End If
    End Sub

    Private Sub OpenEmbeddedObject(sender As Object, e As EventArgs) Handles btnEmbed.Click, NotificationMenuStripEmbed.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Process.Start(openIn & usehttps & "://www.youtube.com/embed/" & txtComboVID.Text & "?" & Vars)
        End If
    End Sub

    Private Sub Inputs_MouseDown(sender As Object, e As MouseEventArgs) Handles btnVideo.MouseDown, btnComments.MouseDown, btnVideoInfo.MouseDown, btnEmbed.MouseDown
        CopyWhat = Mid(sender.ToString, 36)
        CopyWhatEntire = sender.ToString
        If CopyWhat = "&Embed Page Handler" Then
            ContextClipboardCopyCode.Visible = True
        Else
            ContextClipboardCopyCode.Visible = False
        End If
    End Sub

    Private Sub ContextClipboardCopyFromGenerated_Click(sender As Object, e As EventArgs) Handles ContextClipboardCopyFromGenerated.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            If CopyWhat = "&Video" Then
                Try
                    Clipboard.SetText(usehttps & "://www.youtube.com/watch?v=" & txtComboVID.Text & Vars, TextDataFormat.UnicodeText)
                    MsgBox("Video URL Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
            ElseIf CopyWhat = "&Comments" Then
                Try
                    Clipboard.SetText(usehttps & "://www.youtube.com/all_comments?v=" & txtComboVID.Text & Vars, TextDataFormat.UnicodeText)
                    MsgBox("Comments URL Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
            ElseIf CopyWhat = "Video &Info" Then
                Try
                    Clipboard.SetText(usehttps & "://www.youtube.com/get_video_info?video_id=" & txtComboVID.Text & Vars & "&fmt=18", TextDataFormat.UnicodeText)
                    MsgBox("Video Info file URL Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
            ElseIf CopyWhat = "&Embed Page Handler" Then
                Try
                    Clipboard.SetText(usehttps & "://www.youtube.com/embed/" & txtComboVID.Text & "?" & Vars, TextDataFormat.UnicodeText)
                    MsgBox("Embed Page Handler URL Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
            Else
                MsgBox("Cannot determine what was right-clicked, please try again!" & vbNewLine & "This was right-clicked: '" & CopyWhatEntire & "'", , "Error")
            End If
        End If
    End Sub

    Private Sub ContextClipboardCopyCodeHTML_Click(sender As Object, e As EventArgs) Handles ContextClipboardCopyCodeHTML.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            If ContextClipboardCopyCodeStandard.Checked = True Then
                Try 'e.g: <iframe width="560" height="315" src="//www.youtube.com/embed/gMyKNFqRyQk" frameborder="0" allowfullscreen></iframe>
                    Clipboard.SetText("<iframe src='" & "//www.youtube.com/embed/" & txtComboVID.Text & "?" & Vars & "' frameborder='0' allowfullscreen></iframe>", TextDataFormat.UnicodeText)
                    MsgBox("Standard HTML Embed Code Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
            ElseIf ContextClipboardCopyCodeOldCode.Checked = True Then
                Try 'e.g.: <object width="560" height="315"><param name="movie" value="//www.youtube.com/v/gMyKNFqRyQk?version=3&amp;hl=en_GB"></param><param name="allowFullScreen" value="true"></param><param name="allowscriptaccess" value="always"></param><embed src="//www.youtube.com/v/gMyKNFqRyQk?version=3&amp;hl=en_GB" type="application/x-shockwave-flash" width="560" height="315" allowscriptaccess="always" allowfullscreen="true"></embed></object>
                    Clipboard.SetText("<object><param name='movie' value='//www.youtube.com/v/" & txtComboVID.Text & "?version=3&amp;hl=en_GB" & Vars & "'></param><param name='allowFullScreen' value='true'></param><param name='allowscriptaccess' value='always'></param><embed src='//www.youtube.com/v/" & txtComboVID.Text & "?version=3&amp;hl=en_GB" & Vars & "' type='application/x-shockwave-flash' allowscriptaccess='always' allowfullscreen='true'></embed></object>", TextDataFormat.UnicodeText)
                    MsgBox("Old (according to YouTube) HTML Embed Code Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
            End If
        End If
    End Sub

    Private Sub ContextClipboardCopyCodeBB_Click(sender As Object, e As EventArgs) Handles ContextClipboardCopyCodeBB.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Try 'e.g.: [NEEDS RESEARCH]             \/ That code is probably not correct, but it's close.
                Clipboard.SetText("[media=youtube]" & txtComboVID.Text & "[/media]" & vbNewLine & "[youtube]" & txtComboVID.Text & "[/youtube]", TextDataFormat.UnicodeText)
                MsgBox("BB (Forum) Embed Code Copied!" & vbNewLine & "There are two lines in the clipboard, since some forums use slightly different codes to others", MsgBoxStyle.Information, "Succesfully copied!")
            Catch ex As Exception
                MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
            End Try
        End If
    End Sub

    'other buttons & commands

    Private Sub ResetForm(sender As Object, e As EventArgs) Handles btnReset.Click
        'text boxes
        txtComboVID.Text = "Video ID"
        txtTime.Text = "Time (e.g. 1m5s)"
        txtList.Text = "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)"
        txtOrigin.Text = "(e.g. http://9gag.tv)"

        'check boxes
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
        imgLoading.Visible = False
        lblVideoTitle.Text = "Enter a Video ID above"
    End Sub

    Private Sub CloseYTVL(sender As Object, e As EventArgs) Handles NotificationMenuStripClose.Click, btnExit.Click
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub ShowYTVL(sender As Object, e As EventArgs) Handles NotificationMenuStripShowYTVL.Click, NotificationIcon.DoubleClick
        WindowState = FormWindowState.Normal
        Me.BringToFront()
    End Sub

    Private Sub DEBUG(sender As Object, e As EventArgs) Handles btnDebug.Click
        WebBrowserVersionCheck.Visible = True
        WebBrowserVideoLoad.Visible = True
    End Sub

    Private Sub txtComboVID_ContentsChanged(sender As Object, e As EventArgs) Handles txtComboVID.TextChanged
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Or Len(txtComboVID.Text) < "10" Then
            imgLoading.Visible = False
            lblVideoTitle.Text = "Enter a Video ID above"
        Else
            WebBrowserVideoLoad.Navigate(usehttps & "://www.youtube.com/embed/" & txtComboVID.Text & "?autoplay=0")
            imgLoading.Visible = True
            lblVideoTitle.Text = "      Loading..."
        End If
    End Sub

    Private Sub CheckSetVideoTitle(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserVideoLoad.DocumentCompleted
        imgLoading.Visible = False
        If WebBrowserVideoLoad.DocumentTitle = "YouTube" Then
            lblVideoTitle.Text = "Not found! Please make sure you entered a valid Video ID"
        Else
            lblVideoTitle.Text = WebBrowserVideoLoad.DocumentTitle
        End If
    End Sub

    'Changes e.g. settings

    Private Sub MoreLess(sender As Object, e As EventArgs) Handles btnAdvanced.Click
        If Me.Height = 402 Then
            Me.Height = 230
            btnAdvanced.Text = "More ↓"
        Else
            Me.Height = 402
            btnAdvanced.Text = "Less ↑"
        End If
    End Sub

    Private Sub ShowNotification_Click(sender As Object, e As EventArgs) Handles chkShowNotification.Click
        My.Settings.ShowNotification = chkShowNotification.Checked
        My.Settings.Save()
        NotificationIcon.Visible = My.Settings.ShowNotification
    End Sub

    Private Sub HideIconNotificationMenuStrip_Click(sender As Object, e As EventArgs) Handles NotificationMenuStripHideIcon.Click
        My.Settings.ShowNotification = False
        My.Settings.Save()
        chkShowNotification.Checked = False
        NotificationIcon.Visible = False
    End Sub

    Private Sub chkUpdate_Click(sender As Object, e As EventArgs) Handles chkUpdate.Click
        My.Settings.AutoUpdateCheck = chkUpdate.Checked
        My.Settings.Save()
        If chkUpdate.Checked = True Then
            WebBrowserVersionCheck.Navigate("https://github.com/Walkman100/YTVL/releases/latest")
        End If
    End Sub

    Private Sub chkHttps_Click(sender As Object, e As EventArgs) Handles chkHttps.Click
        If chkHttps.Checked = True Then
            usehttps = "https"
        Else
            usehttps = "http"
        End If
    End Sub

    Private Sub KeepOnTopFromNotification(sender As Object, e As EventArgs) Handles NotificationMenuStripKeepOnTop.Click
        My.Settings.KeepOnTop = NotificationMenuStripKeepOnTop.Checked
        Me.TopMost = My.Settings.KeepOnTop
        chkKeepOnTop.Checked = My.Settings.KeepOnTop
    End Sub

    Private Sub KeepOnTopFromMain(sender As Object, e As EventArgs) Handles chkKeepOnTop.CheckedChanged
        My.Settings.KeepOnTop = chkKeepOnTop.Checked
        Me.TopMost = My.Settings.KeepOnTop
        NotificationMenuStripKeepOnTop.Checked = My.Settings.KeepOnTop
    End Sub

    Private Sub ContextClipboardCopyCodeStandard_Click(sender As Object, e As EventArgs) Handles ContextClipboardCopyCodeStandard.Click
        ContextClipboardCopyCodeOldCode.Checked = False 'since this option is automatically checked but the "old code" option isn't
    End Sub

    Private Sub ContextClipboardCopyCodeOldCode_Click(sender As Object, e As EventArgs) Handles ContextClipboardCopyCodeOldCode.Click
        ContextClipboardCopyCodeStandard.Checked = False
    End Sub

    'Links

    Private Sub OpenOriginalPage(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkOriginalPage.LinkClicked
        Process.Start(openIn & "http://walkman100.github.io/Walkman/HTML/YTVL.html") '*.github.io doesn't support https!
    End Sub

    Private Sub OpenSourceCode(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSourceCode.LinkClicked
        Process.Start(openIn & usehttps & "://github.com/Walkman100/YTVL/")
    End Sub

    Private Sub ReportProblem(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReportProblem.LinkClicked
        Process.Start(openIn & usehttps & "://github.com/Walkman100/YTVL/issues/new")
    End Sub

    Private Sub OpenReleases(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReleases.LinkClicked
        Process.Start(openIn & usehttps & "://github.com/Walkman100/YTVL/releases/latest")
    End Sub

    Private Sub OpenDeveloperPage(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDeveloper.LinkClicked
        Process.Start(openIn & usehttps & "://google.com/+MatthewCarterWalkman/about")
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

    
    Sub ComboBrowserBrowse(sender As Object, e As EventArgs) Handles txtComboBrowser.TextChanged
        If txtComboBrowser.Text = "Browse..." Then
            openFileDialogBrowser.ShowDialog
            txtComboBrowser.Text = openFileDialogBrowser.FileName
        End If
    End Sub

    Private Sub txtComboBrowser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtComboBrowser.SelectedIndexChanged

    End Sub
End Class