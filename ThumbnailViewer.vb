<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class ThumbnailViewer
    ''' <summary>
    ''' Designer Code
    ''' </summary>
    Inherits System.Windows.Forms.Form
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.imgThumbnail = New System.Windows.Forms.PictureBox()
        Me.lblS1 = New System.Windows.Forms.LinkLabel()
        Me.lblS2 = New System.Windows.Forms.LinkLabel()
        Me.lblS3 = New System.Windows.Forms.LinkLabel()
        Me.lblMQ = New System.Windows.Forms.LinkLabel()
        Me.lblHQ = New System.Windows.Forms.LinkLabel()
        Me.lblMAX = New System.Windows.Forms.LinkLabel()
        CType(Me.imgThumbnail,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        'imgThumbnail
        Me.imgThumbnail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
          Or System.Windows.Forms.AnchorStyles.Left) _
          Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.imgThumbnail.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgThumbnail.ErrorImage = Global.YTVL.My.Resources.Resources.image_not_found
        Me.imgThumbnail.ImageLocation = "http://walkman100.github.io/images/gif/loading1.gif"
        Me.imgThumbnail.InitialImage = Global.YTVL.My.Resources.Resources.loading6
        Me.imgThumbnail.Location = New System.Drawing.Point(12, 12)
        Me.imgThumbnail.Name = "imgThumbnail"
        Me.imgThumbnail.Size = New System.Drawing.Size(185, 100)
        Me.imgThumbnail.TabIndex = 0
        Me.imgThumbnail.TabStop = false
        'lblS1
        Me.lblS1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblS1.AutoSize = true
        Me.lblS1.Location = New System.Drawing.Point(29, 115)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(18, 13)
        Me.lblS1.TabIndex = 1
        Me.lblS1.TabStop = true
        Me.lblS1.Text = "s1"
        'lblS2
        Me.lblS2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblS2.AutoSize = true
        Me.lblS2.Location = New System.Drawing.Point(53, 115)
        Me.lblS2.Name = "lblS2"
        Me.lblS2.Size = New System.Drawing.Size(18, 13)
        Me.lblS2.TabIndex = 2
        Me.lblS2.TabStop = true
        Me.lblS2.Text = "s2"
        'lblS3
        Me.lblS3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblS3.AutoSize = true
        Me.lblS3.Location = New System.Drawing.Point(77, 115)
        Me.lblS3.Name = "lblS3"
        Me.lblS3.Size = New System.Drawing.Size(18, 13)
        Me.lblS3.TabIndex = 3
        Me.lblS3.TabStop = true
        Me.lblS3.Text = "s3"
        'lblMQ
        Me.lblMQ.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblMQ.AutoSize = true
        Me.lblMQ.Location = New System.Drawing.Point(101, 115)
        Me.lblMQ.Name = "lblMQ"
        Me.lblMQ.Size = New System.Drawing.Size(21, 13)
        Me.lblMQ.TabIndex = 4
        Me.lblMQ.TabStop = true
        Me.lblMQ.Text = "mq"
        'lblHQ
        Me.lblHQ.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblHQ.AutoSize = true
        Me.lblHQ.Location = New System.Drawing.Point(128, 115)
        Me.lblHQ.Name = "lblHQ"
        Me.lblHQ.Size = New System.Drawing.Size(19, 13)
        Me.lblHQ.TabIndex = 5
        Me.lblHQ.TabStop = true
        Me.lblHQ.Text = "hq"
        'lblMAX
        Me.lblMAX.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblMAX.AutoSize = true
        Me.lblMAX.Location = New System.Drawing.Point(153, 115)
        Me.lblMAX.Name = "lblMAX"
        Me.lblMAX.Size = New System.Drawing.Size(26, 13)
        Me.lblMAX.TabIndex = 6
        Me.lblMAX.TabStop = true
        Me.lblMAX.Text = "max"
        'ThumbnailViewer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 137)
        Me.Controls.Add(Me.lblMAX)
        Me.Controls.Add(Me.lblHQ)
        Me.Controls.Add(Me.lblMQ)
        Me.Controls.Add(Me.lblS3)
        Me.Controls.Add(Me.lblS2)
        Me.Controls.Add(Me.lblS1)
        Me.Controls.Add(Me.imgThumbnail)
        Me.Icon = Global.YTVL.My.Resources.Resources.icon_video_display
        Me.Name = "ThumbnailViewer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Thumbnail Viewer (Double-click to open in browser)"
        CType(Me.imgThumbnail,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend WithEvents lblMAX As System.Windows.Forms.LinkLabel
    Friend WithEvents lblHQ As System.Windows.Forms.LinkLabel
    Friend WithEvents lblMQ As System.Windows.Forms.LinkLabel
    Friend WithEvents lblS3 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblS2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblS1 As System.Windows.Forms.LinkLabel
    Friend WithEvents imgThumbnail As System.Windows.Forms.PictureBox
    ''' <summary>
    ''' End Designer Code
    ''' </summary>

    Private Sub LoadViewer() Handles Me.Load, MyBase.Load, Me.Shown
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
