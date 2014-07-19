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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel6 = New System.Windows.Forms.LinkLabel()
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(150, 100)
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = false
        '
        'linkLabel1
        '
        Me.linkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.linkLabel1.AutoSize = true
        Me.linkLabel1.Location = New System.Drawing.Point(12, 115)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(18, 13)
        Me.linkLabel1.TabIndex = 1
        Me.linkLabel1.TabStop = true
        Me.linkLabel1.Text = "s1"
        '
        'linkLabel2
        '
        Me.linkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.linkLabel2.AutoSize = true
        Me.linkLabel2.Location = New System.Drawing.Point(36, 115)
        Me.linkLabel2.Name = "linkLabel2"
        Me.linkLabel2.Size = New System.Drawing.Size(18, 13)
        Me.linkLabel2.TabIndex = 2
        Me.linkLabel2.TabStop = true
        Me.linkLabel2.Text = "s2"
        '
        'linkLabel3
        '
        Me.linkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.linkLabel3.AutoSize = true
        Me.linkLabel3.Location = New System.Drawing.Point(60, 115)
        Me.linkLabel3.Name = "linkLabel3"
        Me.linkLabel3.Size = New System.Drawing.Size(18, 13)
        Me.linkLabel3.TabIndex = 3
        Me.linkLabel3.TabStop = true
        Me.linkLabel3.Text = "s3"
        '
        'linkLabel4
        '
        Me.linkLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.linkLabel4.AutoSize = true
        Me.linkLabel4.Location = New System.Drawing.Point(84, 115)
        Me.linkLabel4.Name = "linkLabel4"
        Me.linkLabel4.Size = New System.Drawing.Size(21, 13)
        Me.linkLabel4.TabIndex = 4
        Me.linkLabel4.TabStop = true
        Me.linkLabel4.Text = "mq"
        '
        'linkLabel5
        '
        Me.linkLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.linkLabel5.AutoSize = true
        Me.linkLabel5.Location = New System.Drawing.Point(111, 115)
        Me.linkLabel5.Name = "linkLabel5"
        Me.linkLabel5.Size = New System.Drawing.Size(19, 13)
        Me.linkLabel5.TabIndex = 5
        Me.linkLabel5.TabStop = true
        Me.linkLabel5.Text = "hq"
        '
        'linkLabel6
        '
        Me.linkLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.linkLabel6.AutoSize = true
        Me.linkLabel6.Location = New System.Drawing.Point(136, 115)
        Me.linkLabel6.Name = "linkLabel6"
        Me.linkLabel6.Size = New System.Drawing.Size(26, 13)
        Me.linkLabel6.TabIndex = 6
        Me.linkLabel6.TabStop = true
        Me.linkLabel6.Text = "max"
        '
        'ThumbnailViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(174, 137)
        Me.Controls.Add(Me.linkLabel6)
        Me.Controls.Add(Me.linkLabel5)
        Me.Controls.Add(Me.linkLabel4)
        Me.Controls.Add(Me.linkLabel3)
        Me.Controls.Add(Me.linkLabel2)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.HelpButton = true
        Me.Name = "ThumbnailViewer"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thumbnail Viewer"
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private linkLabel6 As System.Windows.Forms.LinkLabel
    Private linkLabel5 As System.Windows.Forms.LinkLabel
    Private linkLabel4 As System.Windows.Forms.LinkLabel
    Private linkLabel3 As System.Windows.Forms.LinkLabel
    Private linkLabel2 As System.Windows.Forms.LinkLabel
    Private linkLabel1 As System.Windows.Forms.LinkLabel
    Private pictureBox1 As System.Windows.Forms.PictureBox

End Class
