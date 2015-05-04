Public Class ThumbnailViewer

    Private Sub LoadViewer() Handles Me.Load, MyBase.Load
        ShowS1()
    End Sub

    Private Sub ShowS1() Handles lblS1.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/1.jpg"
        Me.Size = New Size(160, 170)
    End Sub
    
    Private Sub ShowS1InBrowser(sender As Object, e As EventArgs) Handles lblS1.DoubleClick
        YTVL.OpenLink("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/1.jpg")
    End Sub

    Private Sub ShowS2(sender As Object, e As EventArgs) Handles lblS2.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/2.jpg"
        Me.Size = New Size(160, 170)
    End Sub
    
    Private Sub ShowS2InBrowser(sender As Object, e As EventArgs) Handles lblS2.DoubleClick
        YTVL.OpenLink("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/2.jpg")
    End Sub

    Private Sub ShowS3(sender As Object, e As EventArgs) Handles lblS3.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/3.jpg"
        Me.Size = New Size(160, 170)
    End Sub
    
    Private Sub ShowS3InBrowser(sender As Object, e As EventArgs) Handles lblS3.DoubleClick
        YTVL.OpenLink("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/3.jpg")
    End Sub

    Private Sub ShowMQ(sender As Object, e As EventArgs) Handles lblMQ.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/mqdefault.jpg"
        Me.Size = New Size(370, 270)
    End Sub
    
    Private Sub ShowMQInBrowser(sender As Object, e As EventArgs) Handles lblMQ.DoubleClick
        YTVL.OpenLink("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/mqdefault.jpg")
    End Sub

    Private Sub ShowHQ(sender As Object, e As EventArgs) Handles lblHQ.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/hqdefault.jpg"
        Me.Size = New Size(530, 440)
    End Sub
    
    Private Sub ShowHQInBrowser(sender As Object, e As EventArgs) Handles lblHQ.DoubleClick
        YTVL.OpenLink("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/hqdefault.jpg")
    End Sub

    Private Sub ShowMAX(sender As Object, e As EventArgs) Handles lblMAX.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/maxresdefault.jpg"
        Me.Size = New Size(1330, 800)
    End Sub
    
    Private Sub ShowMAXInBrowser(sender As Object, e As EventArgs) Handles lblMAX.DoubleClick
        YTVL.OpenLink("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/maxresdefault.jpg")
    End Sub
End Class
