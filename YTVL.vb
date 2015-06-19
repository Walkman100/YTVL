Public Class YTVL
    Dim ProgramFilesDir As String = Environment.GetEnvironmentVariable("ProgramFiles")
    Dim Vars As String = ""
    Dim usehttps As String = "https"
    Dim currentVer As String = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
    Dim VerString As String
    Dim CopyWhat As String
    Dim CopyWhatEntire As String = "Nothing yet"

    Private Sub LoadYTVL() Handles Me.Load, MyBase.Load
        'apply settings to where they are changed
        chkShowNotification.Checked = My.Settings.ShowNotification
        chkUpdate.Checked = My.Settings.AutoUpdateCheck
        NotificationMenuStripKeepOnTop.Checked = My.Settings.KeepOnTop
        chkKeepOnTop.Checked = My.Settings.KeepOnTop
        chkRememberBrowser.Checked = My.Settings.RememberBrowser

        'apply settings to where they affect
        lblCurrentVersion.Text = "Current: v" & currentVer
        NotificationIcon.Visible = My.Settings.ShowNotification
        If My.Settings.AutoUpdateCheck = True Then 'load latest version
            WebBrowserVersionCheck.Navigate("https://github.com/Walkman100/YTVL/releases/latest")
        End If
        Me.TopMost = My.Settings.KeepOnTop
        If My.Settings.RememberBrowser = True Then
            txtComboBrowser.Text = My.Settings.LastBrowser
        End If
    End Sub

    Private Sub CheckAgainstLatest() Handles WebBrowserVersionCheck.DocumentCompleted
        If My.Settings.AutoUpdateCheck Then
            If WebBrowserVersionCheck.Url.ToString = "https://github.com/Walkman100/YTVL/releases/latest" Then
                If MsgBox("Page load error:" & vbNewLine & WebBrowserVersionCheck.DocumentTitle & vbNewLine & "Retry Version check?", _
                          MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Unable to check version!") = MsgBoxResult.Yes Then
                    WebBrowserVersionCheck.Navigate("https://github.com/Walkman100/YTVL/releases/latest")
                End If
                NotificationIcon.Text = ("YouTube Video Linker" & vbNewLine & "Cur ver:" & currentVer & " Latest ver: Unable to check")
            Else
                NotificationIcon.Text = ("YouTube Video Linker" & vbNewLine & "Current ver: " & currentVer & " Latest ver: " & Mid(WebBrowserVersionCheck.Url.ToString, 50))
                If currentVer < Mid(WebBrowserVersionCheck.Url.ToString, 50) Then
                    If MsgBox("Current version: " & currentVer & " - Latest version: " & Mid(WebBrowserVersionCheck.Url.ToString, 50) & vbNewLine & _
                              "Click OK to download the latest version", MsgBoxStyle.OkCancel + MsgBoxstyle.Information, "Update found!") = MsgBoxResult.Ok Then
                        OpenLink(usehttps & "://github.com/Walkman100/YTVL/releases/latest")
                    End If
                End If
            End If
        End If
    End Sub

    'Opening links

    Private Sub BuildVars()         'they are built in order of the form
        Vars = ""
        If txtTime.Text <> "" And txtTime.Text <> "Time (e.g. 1m5s)" Then
            Vars &= "&t=" & txtTime.Text
        End If
        If txtList.Text <> "" And txtList.Text <> "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)" Then
            Vars &= "&list=" & txtList.Text
        End If
        If chkHL.Checked = True Then Vars &= "&hl=en"
        If optQuality360.Checked = True Then Vars &= "&hd=0"
        If optQuality720.Checked = True Then Vars &= "&hd=1"
        If chkFeature.Checked = True Then Vars &= "&feature=player_embedded"
        If optAutoplay0.Checked = True Then Vars &= "&autoplay=0"
        If optAutoplay1.Checked = True Then Vars &= "&autoplay=1"
        If optFs0.Checked = True Then Vars &= "&fs=0"
        If optFs1.Checked = True Then Vars &= "&fs=1"
        If optAutohide0.Checked = True Then Vars &= "&autohide=0"
        If optAutohide1.Checked = True Then Vars &= "&autohide=1"
        If optEnableJsApi0.Checked = True Then Vars &= "&enablejsapi=0"
        If optEnableJsApi1.Checked = True Then Vars &= "&enablejsapi=1"
        If optIvLP.Text <> "" Then Vars &= "&" & optIvLP.Text
        If optMdstBrndng0.Checked = True Then Vars &= "&modestbranding=0"
        If optMdstBrndng1.Checked = True Then Vars &= "&modestbranding=1"
        If optRel0.Checked = True Then Vars &= "&rel=0"
        If optRel1.Checked = True Then Vars &= "&rel=1"
        If optShowinfo0.Checked = True Then Vars &= "&showinfo=0"
        If optShowinfo1.Checked = True Then Vars &= "&showinfo=1"
        If optShowsearch0.Checked = True Then Vars &= "&showsearch=0"
        If optShowsearch1.Checked = True Then Vars &= "&showsearch=1"
        If chkThemeDark.Checked = True Then Vars &= "&theme=dark"
        If chkWmode.Checked = True Then Vars &= "&wmode=transparent"
        If chkOrigin.Checked = True And txtOrigin.Text <> "(e.g. http://9gag.tv)" Then
            Vars &= "&origin=" & txtOrigin.Text
        End If
    End Sub

    Friend Sub OpenLink(link As String)
        If txtComboBrowser.Text = "Default link handler" Or txtComboBrowser.Text = "Browse..." Or txtComboBrowser.Text = "" Then
            Process.Start(link)
        ElseIf txtComboBrowser.Text = "Send to Clipboard" Then
            Clipboard.SetText(link, TextDataFormat.UnicodeText)
            MsgBox(Clipboard.GetText & " copied successfully!", MsgBoxStyle.Information)
        ElseIf txtComboBrowser.Text = "Mozilla Firefox (%ProgramFiles%\Mozilla Firefox\firefox.exe)" Then
            Process.Start(ProgramFilesDir & "\Mozilla Firefox\firefox.exe", link)
        ElseIf txtComboBrowser.Text = "Google Chrome (%ProgramFiles%\Google\Chrome\Application\chrome.exe)" Then
            Process.Start(ProgramFilesDir & "\Google\Chrome\Application\chrome.exe", link)
        ElseIf txtComboBrowser.Text = "Opera 22 (%ProgramFiles%\Opera\launcher.exe)" Then
            Process.Start(ProgramFilesDir & "\Opera\launcher.exe", link)
        ElseIf txtComboBrowser.Text = "Opera 12 (%ProgramFiles%\Opera\opera.exe)" Then
            Process.Start(ProgramFilesDir & "\Opera\opera.exe", link)
        ElseIf txtComboBrowser.Text = "Safari (%ProgramFiles%\Safari\Safari.exe)" Then
            Process.Start(ProgramFilesDir & "\Safari\Safari.exe", link)
        ElseIf txtComboBrowser.Text = "Avant Browser (%ProgramFiles%\Avant Browser\avant.exe)" Then
            Process.Start(ProgramFilesDir & "\Avant Browser\avant.exe", link)
        ElseIf txtComboBrowser.Text = "Lunascape6 (%ProgramFiles%\Lunascape\Lunascape6\Luna.exe)" Then
            Process.Start(ProgramFilesDir & "\Lunascape\Lunascape6\Luna.exe", link)
        ElseIf txtComboBrowser.Text = "Sea Monkey (%ProgramFiles%\SeaMonkey\seamonkey.exe)" Then
            Process.Start(ProgramFilesDir & "\SeaMonkey\seamonkey.exe", link)
        ElseIf txtComboBrowser.Text = "Internet Explorer (%ProgramFiles%\Internet Explorer\iexplore.exe)" Then
            Process.Start(ProgramFilesDir & "\Internet Explorer\iexplore.exe", link)
        ElseIf txtComboBrowser.Text = "Netscape Navigator 9 (%ProgramFiles%\Netscape\Navigator 9\navigator.exe)" Then
            Process.Start(ProgramFilesDir & "\Netscape\Navigator 9\navigator.exe", link)
        ElseIf System.IO.File.Exists(txtComboBrowser.Text) Then
            Process.Start(txtComboBrowser.Text, link)
        Else
            MsgBox("File """ & txtComboBrowser.Text & """ not found! Last selected valid browser will open when you press OK...", MsgBoxStyle.Critical, "Executable not found")
        End If
    End Sub

    Private Sub MsgNoVID()
        MsgBox("Please fill in a video ID!", MsgBoxStyle.Critical, "No Video ID entered")
        WindowState = FormWindowState.Normal
        Me.BringToFront()
        txtComboVID.SelectAll()
    End Sub

    Private Sub OpenVideo() Handles btnVideo.Click, NotificationMenuStripVideo.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            OpenLink(usehttps & "://www.youtube.com/watch?v=" & txtComboVID.Text & Vars)
        End If
    End Sub

    Private Sub OpenComments() Handles btnComments.Click, NotificationMenuStripComments.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            OpenLink(usehttps & "://www.youtube.com/all_comments?v=" & txtComboVID.Text & Vars)
        End If
    End Sub

    Private Sub OpenVideoInfo() Handles btnVideoInfo.Click, NotificationMenuStripVideoInfo.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            OpenLink(usehttps & "://www.youtube.com/get_video_info?video_id=" & txtComboVID.Text & Vars & "&fmt=18")
        End If
    End Sub

    Private Sub OpenEmbeddedObject() Handles btnEmbed.Click, NotificationMenuStripEmbed.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            OpenLink(usehttps & "://www.youtube.com/embed/" & txtComboVID.Text & "?" & Vars)
        End If
    End Sub
    
    Private Sub OpenDeturl() Handles btnDeturl.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            OpenLink("http://deturl.com/www.youtube.com/watch?v=" & txtComboVID.Text)
        End If
    End Sub
    
    Private Sub OpenFullripVideo() Handles ContextDownloadFullripVideo.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            OpenLink("http://www.fullrip.net/video/" & txtComboVID.Text)
        End If
    End Sub
    
    Private Sub OpenFullripVideoAlternative() Handles ContextDownloadFullripVideoAlternate.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            OpenLink("http://www.fullrip.net/video-m/" & txtComboVID.Text)
        End If
    End Sub
    
    Private Sub OpenFullripMP3() Handles ContextDownloadFullripMP3.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            OpenLink("http://www.fullrip.net/mp3/" & txtComboVID.Text)
        End If
    End Sub
    
    Private Sub OpenKeepVid() Handles ContextDownloadKeepVid.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            OpenLink("http://keepvid.com/?url=http%3A%2F%2Fwww%2Eyoutube%2Ecom%2Fwatch%3Fv%3D" & txtComboVID.Text)
        End If
    End Sub
    
    Private Sub ShowThumbnail() Handles btnThumbnail.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            ThumbnailViewer.Show()
            ThumbnailViewer.WindowState = WindowState.Normal
            ThumbnailViewer.BringToFront()
        End If
    End Sub
    
    Dim IDIndex As Byte
    Private Sub ConvertString() Handles btnConvert.Click
        Vars = InputBox("Type full YouTube URL here:", "Full URL cleaner", Clipboard.GetText)
        If Vars <> "" Then
            If Vars.Contains("v=") Then
                IDIndex = 2
                Do Until Vars.Chars(IDIndex-2) = "v" And Vars.Chars(IDIndex-1) = "="
                    IDIndex = Vars.IndexOf("v=",IDIndex)+2
                Loop
                If Vars.Substring(IDIndex).Length < 12 Then
                    txtComboVID.Text = Vars.Substring(IDIndex)
                Else
                    txtComboVID.Text = Vars.Substring(IDIndex).Remove(11)
                End If
            ElseIf Vars.Contains("video_id=") Then
                IDIndex = 9
                Do Until Vars.Substring(IDIndex-9).Remove(9) = "video_id="
                    IDIndex = Vars.IndexOf("video_id=",IDIndex)+9
                Loop
                If Vars.Substring(IDIndex).Length < 12 Then
                    txtComboVID.Text = Vars.Substring(IDIndex)
                Else
                    txtComboVID.Text = Vars.Substring(IDIndex).Remove(11)
                End If
            Else
                MsgBox("No ""v=[Video_ID]"" or ""video_id=[Video_ID]"" string found in entered text!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If Vars.Contains("t=") Then
                IDIndex = 2
                Do Until Vars.Chars(IDIndex-2) = "t" And Vars.Chars(IDIndex-1) = "="
                    IDIndex = Vars.IndexOf("t=",IDIndex)+2
                Loop
                If Vars.Substring(IDIndex).contains("&") Then
                    txtTime.Text = Vars.Substring(IDIndex).Remove(Vars.Substring(IDIndex).IndexOf("&"))
                Else
                    txtTime.Text = Vars.Substring(IDIndex)
                End If
            End If
            If Vars.Contains("list=") Then
                IDIndex = 5
                Do Until Vars.Substring(IDIndex-5).Remove(5) = "list="
                    IDIndex = Vars.IndexOf("list=",IDIndex)+5
                Loop
                If Vars.Substring(IDIndex).Contains("&") Then
                    txtList.Text = Vars.Substring(IDIndex).Remove(Vars.Substring(IDIndex).IndexOf("&"))
                Else
                    txtList.Text = Vars.Substring(IDIndex)
                End If
            End If
        End If
    End Sub
    
        ' copying stuff
    
    Private Sub MouseDownOnAnything(sender As Object, e As MouseEventArgs) Handles chkKeepOnTop.MouseDown,grpBoxInputs.MouseDown,txtComboVID.MouseDown,txtTime.MouseDown, _
  txtList.MouseDown,imgLoading.MouseDown,lblVideoTitle.MouseDown,chkHL.MouseDown,lblHL.MouseDown,btnAdvanced.MouseDown,pnlQuality.MouseDown,optQuality360.MouseDown, _
  optQuality720.MouseDown,chkFeature.MouseDown,lblAutoplay.MouseDown,pnlAutoplay.MouseDown,optAutoplay0.MouseDown,optAutoplay1.MouseDown,lblFs.MouseDown,pnlFs.MouseDown, _
  optFs0.MouseDown,optFs1.MouseDown,lblAutohide.MouseDown,pnlAutohide.MouseDown,optAutohide0.MouseDown,optAutohide1.MouseDown,lblEnableJsApi.MouseDown, _
  pnlEnableJsApi.MouseDown,optEnableJsApi0.MouseDown,optEnableJsApi1.MouseDown,lblIvLP.MouseDown,optIvLP.MouseDown,lblMdstBrndng.MouseDown,pnlRight1.MouseDown, _
  optMdstBrndng0.MouseDown,optMdstBrndng1.MouseDown,lblRel.MouseDown,pnlRight2.MouseDown,optRel0.MouseDown,optRel1.MouseDown,lblShowinfo.MouseDown,pnlRight3.MouseDown, _
  optShowinfo0.MouseDown,optShowinfo1.MouseDown,lblShowSearch.MouseDown,pnlRight4.MouseDown,optShowsearch0.MouseDown,optShowsearch1.MouseDown, _
  chkThemeDark.MouseDown,chkWmode.MouseDown,chkOrigin.MouseDown,txtOrigin.MouseDown,chkHttps.MouseDown,lblBrowser.MouseDown,txtComboBrowser.MouseDown, _
  chkRememberBrowser.MouseDown,grpBoxOutputs.MouseDown,chkShowNotification.MouseDown,btnVideo.MouseDown,btnComments.MouseDown,btnVideoInfo.MouseDown,btnEmbed.MouseDown, _
  btnReset.MouseDown,btnExit.MouseDown,btnDeturl.MouseDown,btnThumbnail.MouseDown,btnConvert.MouseDown,btnDebug.MouseDown,grpBoxAbout.MouseDown,lnkOriginalPage.MouseDown, _
  lnkSourceCode.MouseDown,lnkReportProblem.MouseDown,lnkReleases.MouseDown,lnkDeveloper.MouseDown,chkUpdate.MouseDown,lblCurrentVersion.MouseDown
        
        If e.Button = MouseButtons.Right Then
            CopyWhat = Mid(sender.ToString, 36)
            CopyWhatEntire = sender.name
            If CopyWhat = "&Embed Page Handler" Then
                ContextClipboardCopyCode.Visible = True
            Else
                ContextClipboardCopyCode.Visible = False
            End If
        End If
    End Sub

    Private Sub ContextClipboardCopyFromGenerated_Click(sender As Object, e As EventArgs) Handles ContextClipboardCopyFromGenerated.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Select Case CopyWhat
              Case "&Video"
                Try
                    Clipboard.SetText(usehttps & "://www.youtube.com/watch?v=" & txtComboVID.Text & Vars, TextDataFormat.UnicodeText)
                    MsgBox("Video URL Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
              Case "&Comments"
                Try
                    Clipboard.SetText(usehttps & "://www.youtube.com/all_comments?v=" & txtComboVID.Text & Vars, TextDataFormat.UnicodeText)
                    MsgBox("Comments URL Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
              Case "Video &Info"
                Try
                    Clipboard.SetText(usehttps & "://www.youtube.com/get_video_info?video_id=" & txtComboVID.Text & Vars & "&fmt=18", TextDataFormat.UnicodeText)
                    MsgBox("Video Info file URL Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
              Case "&Embed Page Handler"
                Try
                    Clipboard.SetText(usehttps & "://www.youtube.com/embed/" & txtComboVID.Text & "?" & Vars, TextDataFormat.UnicodeText)
                    MsgBox("Embed Page Handler URL Copied!", MsgBoxStyle.Information, "Succesfully copied!")
                Catch ex As Exception
                    MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
                End Try
              Case Else
                MsgBox("Cannot determine what was right-clicked, please try again!" & vbNewLine & "This was right-clicked: '" _
                        & CopyWhatEntire & "'", MsgBoxStyle.Exclamation, "Error")
            End Select
        End If
    End Sub

    Private Sub ContextClipboardCopyCodeHTML_Click() Handles ContextClipboardCopyCodeHTML.Click
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

    Private Sub ContextClipboardCopyCodeBB_Click() Handles ContextClipboardCopyCodeBB.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Try '[NEEDS (more) RESEARCH]             \/ That code is probably not correct, but it's close.
                Clipboard.SetText("[media=youtube]" & txtComboVID.Text & "[/media]" & vbNewLine & "[youtube]" & txtComboVID.Text & "[/youtube]", TextDataFormat.UnicodeText)
                MsgBox("BB (Forum) Embed Code Copied!" & vbNewLine & "There are two lines in the clipboard, since some forums use slightly different codes to others", MsgBoxStyle.Information, "Succesfully copied!")
            Catch ex As Exception
                MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
            End Try
        End If
    End Sub
    
    Private Sub ContextDownloadCopyFromGenerated_Click() Handles ContextDownloadCopyFromGenerated.Click
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Then
            MsgNoVID()
        Else
            BuildVars()
            Try
                Clipboard.SetText("http://deturl.com/www.youtube.com/watch?v=" & txtComboVID.Text, TextDataFormat.UnicodeText)
                MsgBox("deturl download page link Copied!", MsgBoxStyle.Information, "Succesfully copied!")
            Catch ex As Exception
                MsgBox("Copy failed!" & vbNewLine & "Error: " & ex.ToString, MsgBoxStyle.Critical, "Copy failed!")
            End Try
        End If
    End Sub

    'Buttons & commands that make Visual changes

    Private Sub ResetForm() Handles btnReset.Click
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
        Me.Height = 260
        Me.Width = 506
        btnAdvanced.Text = "More ↓"
        imgLoading.Visible = False
        WindowState = FormWindowState.Normal
        lblVideoTitle.Text = "Enter a Video ID above"
    End Sub

    Private Sub CloseYTVL() Handles NotificationMenuStripClose.Click, btnExit.Click
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub ShowYTVL() Handles NotificationMenuStripShowYTVL.Click, NotificationIcon.DoubleClick
        WindowState = FormWindowState.Normal
        Me.BringToFront()
    End Sub

    Private Sub DEBUG() Handles btnDebug.Click
        WebBrowserVersionCheck.Visible = True
        WebBrowserVideoLoad.Visible = True
        btnDebug.Enabled = False
        btnDebug.Visible = False
    End Sub

    Private Sub txtComboVID_ContentsChanged() Handles txtComboVID.TextChanged
        If txtComboVID.Text = "Video ID" Or txtComboVID.Text = "" Or Len(txtComboVID.Text) < "11" Then
            imgLoading.Visible = False
            lblVideoTitle.Text = "Enter a Video ID above"
        Else
            WebBrowserVideoLoad.Navigate(usehttps & "://www.youtube.com/embed/" & txtComboVID.Text & "?autoplay=0")
            imgLoading.Visible = True
            lblVideoTitle.Text = "      Loading..."
            btnVideo.Enabled = True
            btnComments.Enabled = True
            btnVideoInfo.Enabled = True
            btnEmbed.Enabled = True
            btnDeturl.Enabled = True
            btnThumbnail.Enabled = True
        End If
    End Sub

    Private Sub CheckSetVideoTitle() Handles WebBrowserVideoLoad.DocumentCompleted
        imgLoading.Visible = False
        If WebBrowserVideoLoad.DocumentTitle = "YouTube" Then
            lblVideoTitle.Text = "Not found! Please make sure you entered a valid Video ID"
        Else
            lblVideoTitle.Text = WebBrowserVideoLoad.DocumentTitle
        End If
    End Sub

    ' Changes e.g. settings

    Private Sub MoreLess() Handles btnAdvanced.Click
        If Me.Height = 432 Then
            Me.Height = 260
            btnAdvanced.Text = "More ↓"
        Else
            Me.Height = 432
            btnAdvanced.Text = "Less ↑"
        End If
    End Sub

    Private Sub ShowNotification_Click() Handles chkShowNotification.Click
        My.Settings.ShowNotification = chkShowNotification.Checked
        My.Settings.Save()
        NotificationIcon.Visible = My.Settings.ShowNotification
    End Sub

    Private Sub HideIconNotificationMenuStrip_Click() Handles NotificationMenuStripHideIcon.Click
        My.Settings.ShowNotification = False
        My.Settings.Save()
        chkShowNotification.Checked = False
        NotificationIcon.Visible = False
    End Sub

    Private Sub chkUpdate_Click() Handles chkUpdate.Click
        My.Settings.AutoUpdateCheck = chkUpdate.Checked
        My.Settings.Save()
        If chkUpdate.Checked = True Then
            WebBrowserVersionCheck.Navigate("https://github.com/Walkman100/YTVL/releases/latest")
        End If
    End Sub

    Private Sub chkHttps_Click() Handles chkHttps.Click
        If chkHttps.Checked = True Then
            usehttps = "https"
        Else
            usehttps = "http"
        End If
    End Sub

    Private Sub KeepOnTopFromNotification() Handles NotificationMenuStripKeepOnTop.Click
        My.Settings.KeepOnTop = NotificationMenuStripKeepOnTop.Checked
        Me.TopMost = My.Settings.KeepOnTop
        chkKeepOnTop.Checked = My.Settings.KeepOnTop
    End Sub

    Private Sub KeepOnTopFromMain() Handles chkKeepOnTop.Click
        My.Settings.KeepOnTop = chkKeepOnTop.Checked
        Me.TopMost = My.Settings.KeepOnTop
        NotificationMenuStripKeepOnTop.Checked = My.Settings.KeepOnTop
    End Sub

    Private Sub ContextClipboardCopyCodeStandard_Select() Handles ContextClipboardCopyCodeStandard.click, ContextClipboardCopyCodeStandard.MouseUp
        ContextClipboardCopyCodeStandard.Checked = True
        ContextClipboardCopyCodeOldCode.Checked = False
    End Sub
    
    Private Sub ContextClipboardCopyCodeOldCode_Select() Handles ContextClipboardCopyCodeOldCode.click, ContextClipboardCopyCodeOldCode.MouseUp
        ContextClipboardCopyCodeStandard.Checked = False
        ContextClipboardCopyCodeOldCode.Checked = True
    End Sub
    
    Private Sub chkRememberBrowser_Click() Handles chkRememberBrowser.Click
        My.Settings.RememberBrowser = chkRememberBrowser.Checked
        If My.Settings.RememberBrowser = True Then
            My.Settings.LastBrowser = txtComboBrowser.Text
        Else
            My.Settings.LastBrowser = "Default link handler"
        End If
    End Sub

    Private Sub txtComboBrowser_SelectedIndexChanged() Handles txtComboBrowser.SelectedIndexChanged
        If txtComboBrowser.Text = "Browse..." Then
            openFileDialogBrowser.ShowDialog()
            txtComboBrowser.Items.Add(openFileDialogBrowser.FileName)
            txtComboBrowser.Text = openFileDialogBrowser.FileName
        End If
        
        If My.Settings.RememberBrowser = True Then
            My.Settings.LastBrowser = txtComboBrowser.Text
        End If
    End Sub

    ' Links

    Private Sub OpenOriginalPage() Handles lnkOriginalPage.LinkClicked
        OpenLink("http://walkman100.github.io/Walkman/HTML/YTVL.html") ' *.github.io doesn't support https!
    End Sub

    Private Sub OpenSourceCode() Handles lnkSourceCode.LinkClicked
        OpenLink(usehttps & "://github.com/Walkman100/YTVL/")
    End Sub

    Private Sub ReportProblem() Handles lnkReportProblem.LinkClicked
        OpenLink(usehttps & "://github.com/Walkman100/YTVL/issues/new")
    End Sub

    Private Sub OpenReleases() Handles lnkReleases.LinkClicked
        OpenLink(usehttps & "://github.com/Walkman100/YTVL/releases/latest")
    End Sub

    Private Sub OpenDeveloperPage() Handles lnkDeveloper.LinkClicked
        OpenLink(usehttps & "://google.com/+MatthewCarterWalkman/about")
    End Sub

    ' Text control

    Private Sub txtComboVID_Enter() Handles txtComboVID.MouseDown
        If txtComboVID.Text = "Video ID" Then
            txtComboVID.Text = ""
        Else
            txtComboVID.SelectAll()
        End If
    End Sub

    Private Sub txtComboVID_Leave() Handles txtComboVID.Leave
        If txtComboVID.Text = "" Then
            txtComboVID.Text = "Video ID"
        ElseIf txtComboVID.Text <> "Video ID" Then
            If Not txtComboVID.Items.Contains(txtComboVID.Text) Then
                txtComboVID.Items.Add(txtComboVID.Text)
            End If
        End If
    End Sub

    Private Sub txtTime_Enter() Handles txtTime.MouseDown
        If txtTime.Text = "Time (e.g. 1m5s)" Then
            txtTime.Text = ""
        Else
            txtTime.SelectAll()
        End If
    End Sub

    Private Sub txtTime_Leave() Handles txtTime.Leave
        If txtTime.Text = "" Then
            txtTime.Text = "Time (e.g. 1m5s)"
        End If
    End Sub

    Private Sub txtList_Enter() Handles txtList.MouseDown
        If txtList.Text = "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)" Then
            txtList.Text = ""
        Else
            txtList.SelectAll()
        End If
    End Sub

    Private Sub txtList_Leave() Handles txtList.Leave
        If txtList.Text = "" Then
            txtList.Text = "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)"
        End If
    End Sub

    Private Sub txtOrigin_Enter() Handles txtOrigin.MouseDown
        If txtOrigin.Text = "(e.g. http://9gag.tv)" Then
            txtOrigin.Text = ""
        Else
            txtOrigin.SelectAll()
        End If
    End Sub

    Private Sub txtOrigin_Leave() Handles txtOrigin.Leave
        If txtOrigin.Text = "" Then
            txtOrigin.Text = "(e.g. http://9gag.tv)"
        End If
    End Sub
End Class
