Public Class ThumbnailViewer

    Private Sub LoadViewer() Handles Me.Load, MyBase.Load
        ShowS1(Nothing, Nothing)
    End Sub

    Private Sub ShowS1(sender As Object, e As EventArgs) Handles lblS1.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/1.jpg"
    End Sub
    
    Private Sub ShowS1InBrowser(sender As Object, e As EventArgs) Handles lblS1.DoubleClick
        If YTVL.UseDefaultBrowser = True Then
            Process.Start("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/1.jpg")
        Else
            YTVL.GetBrowser()
            Process.Start(YTVL.openIn, "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/1.jpg")
        End If
    End Sub

    Private Sub ShowS2(sender As Object, e As EventArgs) Handles lblS2.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/2.jpg"
    End Sub
    
    Private Sub ShowS2InBrowser(sender As Object, e As EventArgs) Handles lblS2.DoubleClick
        If YTVL.UseDefaultBrowser = True Then
            Process.Start("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/2.jpg")
        Else
            YTVL.GetBrowser()
            Process.Start(YTVL.openIn, "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/2.jpg")
        End If
    End Sub

    Private Sub ShowS3(sender As Object, e As EventArgs) Handles lblS3.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/3.jpg"
    End Sub
    
    Private Sub ShowS3InBrowser(sender As Object, e As EventArgs) Handles lblS3.DoubleClick
        If YTVL.UseDefaultBrowser = True Then
            Process.Start("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/3.jpg")
        Else
            YTVL.GetBrowser()
            Process.Start(YTVL.openIn, "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/3.jpg")
        End If
    End Sub

    Private Sub ShowMQ(sender As Object, e As EventArgs) Handles lblMQ.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/mqdefault.jpg"
    End Sub
    
    Private Sub ShowMQInBrowser(sender As Object, e As EventArgs) Handles lblMQ.DoubleClick
        If YTVL.UseDefaultBrowser = True Then
            Process.Start("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/mqdefault.jpg")
        Else
            YTVL.GetBrowser()
            Process.Start(YTVL.openIn, "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/mqdefault.jpg")
        End If
    End Sub

    Private Sub ShowHQ(sender As Object, e As EventArgs) Handles lblHQ.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/hqdefault.jpg"
    End Sub
    
    Private Sub ShowHQInBrowser(sender As Object, e As EventArgs) Handles lblHQ.DoubleClick
        If YTVL.UseDefaultBrowser = True Then
            Process.Start("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/hqdefault.jpg")
        Else
            YTVL.GetBrowser()
            Process.Start(YTVL.openIn, "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/hqdefault.jpg")
        End If
    End Sub

    Private Sub ShowMAX(sender As Object, e As EventArgs) Handles lblMAX.LinkClicked
        imgThumbnail.ImageLocation = "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/maxresdefault.jpg"
    End Sub
    
    Private Sub ShowMAXInBrowser(sender As Object, e As EventArgs) Handles lblMAX.DoubleClick
        If YTVL.UseDefaultBrowser = True Then
            Process.Start("http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/maxresdefault.jpg")
        Else
            YTVL.GetBrowser()
            Process.Start(YTVL.openIn, "http://img.youtube.com/vi/" & YTVL.txtComboVID.Text & "/maxresdefault.jpg")
        End If
    End Sub
End Class
