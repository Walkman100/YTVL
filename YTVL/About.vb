Public Class About
    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "About " & My.Application.Info.ProductName
        Label4.Text = Label4.Text = My.Application.Info.Version.ToString
        WebBrowser1.Navigate("https://Walkman100.github.io/YTVL/changelog.txt")
        WebBrowser2.Navigate("https://Walkman100.github.io/YTVL/credits.txt")
        WebBrowser3.Navigate("https://Walkman100.github.io/YTVL/licenses.txt")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("https://Walkman100.github.io/YTVL/")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start("https://Walkman100.github.io/YTVL/")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        changelog_text.Text = WebBrowser1.Document.Body.InnerText.ToString
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        credits_text.Text = WebBrowser2.Document.Body.InnerText.ToString
    End Sub

    Private Sub WebBrowser3_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser3.DocumentCompleted
        licenses_text.Text = WebBrowser3.Document.Body.InnerText.ToString
    End Sub
End Class