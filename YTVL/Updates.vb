Public Class Updates

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Done_button.Click
        Me.Close()
    End Sub

    Private Sub Start()
        WebBrowser1.Navigate("https://Walkman100.github.io/YTVL/current_version.txt")
    End Sub
    Private Sub Updates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        your_version_text.Text = "Your version: v" & My.Application.Info.Version.ToString
        Start()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'This is probably bad
        WebBrowser1.Refresh(WebBrowserRefreshOption.Completely)
        ReadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CheckForUpdates_button.Click
        If CheckForUpdates_button.Text = "&Check for updates" Then
            Start()
        Else
            Downloader.RunWorkerAsync()
        End If
    End Sub

    Public updatestatus As String = "False"

    Private Sub ReadData()
        your_version_text.Text = "Your version: v" & My.Application.Info.Version.ToString
        online_version_text.Text = "Online version: v" & WebBrowser1.Document.Body.InnerText.ToString
        If WebBrowser1.Document.Body.InnerText.ToString > My.Application.Info.Version.ToString Then
            MsgBox("Update available!", MsgBoxStyle.Information)
            CheckForUpdates_button.Text = "&Install updates"
            updatestatus = "True"
        Else
            MsgBox("No updates available!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Downloader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Downloader.DoWork
        My.Computer.Network.DownloadFile("https://Walkman100.github.io/YTVL/YTVL-Updater.exe", "YTVL-Updater.exe", False, False, False, connectionTimeout:=My.Settings.Updates_DownloadUpdaterConnectionTimeout, overwrite:=True)
    End Sub

    Private Sub Downloader_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Downloader.RunWorkerCompleted
        MsgBox("Click Ok to download and install the updates.")
        Process.Start("YTVL-Updater.exe")
        Application.Exit()
    End Sub
End Class