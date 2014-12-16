<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThumbnailViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThumbnailViewer))
        Me.imgThumbnail = New System.Windows.Forms.PictureBox()
        Me.lblS1 = New System.Windows.Forms.LinkLabel()
        Me.lblS2 = New System.Windows.Forms.LinkLabel()
        Me.lblS3 = New System.Windows.Forms.LinkLabel()
        Me.lblMQ = New System.Windows.Forms.LinkLabel()
        Me.lblHQ = New System.Windows.Forms.LinkLabel()
        Me.lblMAX = New System.Windows.Forms.LinkLabel()
        CType(Me.imgThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgThumbnail
        '
        Me.imgThumbnail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgThumbnail.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgThumbnail.ErrorImage = Global.YTVL.My.Resources.Resources.image_not_found
        Me.imgThumbnail.ImageLocation = "http://walkman100.github.io/Walkman/Images/loading1.gif"
        Me.imgThumbnail.InitialImage = Global.YTVL.My.Resources.Resources.loading6
        Me.imgThumbnail.Location = New System.Drawing.Point(12, 12)
        Me.imgThumbnail.Name = "imgThumbnail"
        Me.imgThumbnail.Size = New System.Drawing.Size(185, 100)
        Me.imgThumbnail.TabIndex = 0
        Me.imgThumbnail.TabStop = False
        '
        'lblS1
        '
        Me.lblS1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblS1.AutoSize = True
        Me.lblS1.Location = New System.Drawing.Point(29, 115)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(18, 13)
        Me.lblS1.TabIndex = 1
        Me.lblS1.TabStop = True
        Me.lblS1.Text = "s1"
        '
        'lblS2
        '
        Me.lblS2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblS2.AutoSize = True
        Me.lblS2.Location = New System.Drawing.Point(53, 115)
        Me.lblS2.Name = "lblS2"
        Me.lblS2.Size = New System.Drawing.Size(18, 13)
        Me.lblS2.TabIndex = 2
        Me.lblS2.TabStop = True
        Me.lblS2.Text = "s2"
        '
        'lblS3
        '
        Me.lblS3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblS3.AutoSize = True
        Me.lblS3.Location = New System.Drawing.Point(77, 115)
        Me.lblS3.Name = "lblS3"
        Me.lblS3.Size = New System.Drawing.Size(18, 13)
        Me.lblS3.TabIndex = 3
        Me.lblS3.TabStop = True
        Me.lblS3.Text = "s3"
        '
        'lblMQ
        '
        Me.lblMQ.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblMQ.AutoSize = True
        Me.lblMQ.Location = New System.Drawing.Point(101, 115)
        Me.lblMQ.Name = "lblMQ"
        Me.lblMQ.Size = New System.Drawing.Size(21, 13)
        Me.lblMQ.TabIndex = 4
        Me.lblMQ.TabStop = True
        Me.lblMQ.Text = "mq"
        '
        'lblHQ
        '
        Me.lblHQ.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblHQ.AutoSize = True
        Me.lblHQ.Location = New System.Drawing.Point(128, 115)
        Me.lblHQ.Name = "lblHQ"
        Me.lblHQ.Size = New System.Drawing.Size(19, 13)
        Me.lblHQ.TabIndex = 5
        Me.lblHQ.TabStop = True
        Me.lblHQ.Text = "hq"
        '
        'lblMAX
        '
        Me.lblMAX.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblMAX.AutoSize = True
        Me.lblMAX.Location = New System.Drawing.Point(153, 115)
        Me.lblMAX.Name = "lblMAX"
        Me.lblMAX.Size = New System.Drawing.Size(26, 13)
        Me.lblMAX.TabIndex = 6
        Me.lblMAX.TabStop = True
        Me.lblMAX.Text = "max"
        '
        'ThumbnailViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 137)
        Me.Controls.Add(Me.lblMAX)
        Me.Controls.Add(Me.lblHQ)
        Me.Controls.Add(Me.lblMQ)
        Me.Controls.Add(Me.lblS3)
        Me.Controls.Add(Me.lblS2)
        Me.Controls.Add(Me.lblS1)
        Me.Controls.Add(Me.imgThumbnail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ThumbnailViewer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Thumbnail Viewer (Double-click to open in browser)"
        CType(Me.imgThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMAX As System.Windows.Forms.LinkLabel
    Friend WithEvents lblHQ As System.Windows.Forms.LinkLabel
    Friend WithEvents lblMQ As System.Windows.Forms.LinkLabel
    Friend WithEvents lblS3 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblS2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblS1 As System.Windows.Forms.LinkLabel
    Friend WithEvents imgThumbnail As System.Windows.Forms.PictureBox

End Class
