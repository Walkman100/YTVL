Public Class ThumbnailViewer

    Private Sub LoadViewer() Handles Me.Load, MyBase.Load
        ShowS1(Nothing, Nothing)
    End Sub

    Private Sub ShowS1(sender As Object, e As EventArgs) Handles lblS1.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/CqDGF0j7vpE/1.jpg"
    End Sub
    
    Private Sub ShowS1InBrowser(sender As Object, e As EventArgs) Handles lblS1.DoubleClick
        Process.Start("http://img.youtube.com/vi/CqDGF0j7vpE/1.jpg")
    End Sub

    Private Sub ShowS2(sender As Object, e As EventArgs) Handles lblS2.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/CqDGF0j7vpE/2.jpg"
    End Sub
    
    Private Sub ShowS2InBrowser(sender As Object, e As EventArgs) Handles lblS2.DoubleClick
        Process.Start("http://img.youtube.com/vi/CqDGF0j7vpE/2.jpg")
    End Sub

    Private Sub ShowS3(sender As Object, e As EventArgs) Handles lblS3.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/CqDGF0j7vpE/3.jpg"
    End Sub
    
    Private Sub ShowS3InBrowser(sender As Object, e As EventArgs) Handles lblS3.DoubleClick
        Process.Start("http://img.youtube.com/vi/CqDGF0j7vpE/3.jpg")
    End Sub

    Private Sub ShowMQ(sender As Object, e As EventArgs) Handles lblMQ.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/CqDGF0j7vpE/mqdefault.jpg"
    End Sub
    
    Private Sub ShowMQInBrowser(sender As Object, e As EventArgs) Handles lblMQ.DoubleClick
        Process.Start("http://img.youtube.com/vi/CqDGF0j7vpE/mqdefault.jpg")
    End Sub

    Private Sub ShowHQ(sender As Object, e As EventArgs) Handles lblHQ.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/CqDGF0j7vpE/hqdefault.jpg"
    End Sub
    
    Private Sub ShowHQInBrowser(sender As Object, e As EventArgs) Handles lblHQ.DoubleClick
        Process.Start("http://img.youtube.com/vi/CqDGF0j7vpE/hqdefault.jpg")
    End Sub

    Private Sub ShowMAX(sender As Object, e As EventArgs) Handles lblMAX.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/CqDGF0j7vpE/maxresdefault.jpg"
    End Sub
    
    Private Sub ShowMAXInBrowser(sender As Object, e As EventArgs) Handles lblMAX.DoubleClick
        Process.Start("http://img.youtube.com/vi/CqDGF0j7vpE/maxresdefault.jpg")
    End Sub
End Class
