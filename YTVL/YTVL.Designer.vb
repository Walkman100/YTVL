<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YTVL
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YTVL))
        Me.grpBoxInputs = New System.Windows.Forms.GroupBox()
        Me.btnAdvanced = New System.Windows.Forms.Button()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.lblHL = New System.Windows.Forms.Label()
        Me.chkHL = New System.Windows.Forms.CheckBox()
        Me.lblFeather = New System.Windows.Forms.LinkLabel()
        Me.chkFeather = New System.Windows.Forms.CheckBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtComboVID = New System.Windows.Forms.ComboBox()
        Me.grpBoxOutputs = New System.Windows.Forms.GroupBox()
        Me.chkShowNotification = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEmbed = New System.Windows.Forms.Button()
        Me.btnVideoInfo = New System.Windows.Forms.Button()
        Me.btnComments = New System.Windows.Forms.Button()
        Me.btnVideo = New System.Windows.Forms.Button()
        Me.grpBoxAbout = New System.Windows.Forms.GroupBox()
        Me.lnkWalkman = New System.Windows.Forms.LinkLabel()
        Me.lnkReleases = New System.Windows.Forms.LinkLabel()
        Me.lnkReportProblem = New System.Windows.Forms.LinkLabel()
        Me.lnkSourceCode = New System.Windows.Forms.LinkLabel()
        Me.lnkOriginalPage = New System.Windows.Forms.LinkLabel()
        Me.lblCurrentVersion = New System.Windows.Forms.Label()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotificationMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowYTVLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmbedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpBoxInputs.SuspendLayout()
        Me.grpBoxOutputs.SuspendLayout()
        Me.grpBoxAbout.SuspendLayout()
        Me.NotificationMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxInputs
        '
        resources.ApplyResources(Me.grpBoxInputs, "grpBoxInputs")
        Me.grpBoxInputs.Controls.Add(Me.btnAdvanced)
        Me.grpBoxInputs.Controls.Add(Me.txtList)
        Me.grpBoxInputs.Controls.Add(Me.lblHL)
        Me.grpBoxInputs.Controls.Add(Me.chkHL)
        Me.grpBoxInputs.Controls.Add(Me.lblFeather)
        Me.grpBoxInputs.Controls.Add(Me.chkFeather)
        Me.grpBoxInputs.Controls.Add(Me.txtTime)
        Me.grpBoxInputs.Controls.Add(Me.txtComboVID)
        Me.grpBoxInputs.Name = "grpBoxInputs"
        Me.grpBoxInputs.TabStop = False
        '
        'btnAdvanced
        '
        resources.ApplyResources(Me.btnAdvanced, "btnAdvanced")
        Me.btnAdvanced.Name = "btnAdvanced"
        Me.btnAdvanced.UseVisualStyleBackColor = True
        '
        'txtList
        '
        Me.txtList.AllowDrop = True
        resources.ApplyResources(Me.txtList, "txtList")
        Me.txtList.Name = "txtList"
        '
        'lblHL
        '
        resources.ApplyResources(Me.lblHL, "lblHL")
        Me.lblHL.Name = "lblHL"
        '
        'chkHL
        '
        resources.ApplyResources(Me.chkHL, "chkHL")
        Me.chkHL.Name = "chkHL"
        Me.chkHL.UseVisualStyleBackColor = True
        '
        'lblFeather
        '
        resources.ApplyResources(Me.lblFeather, "lblFeather")
        Me.lblFeather.Name = "lblFeather"
        Me.lblFeather.TabStop = True
        Me.lblFeather.UseCompatibleTextRendering = True
        '
        'chkFeather
        '
        resources.ApplyResources(Me.chkFeather, "chkFeather")
        Me.chkFeather.Name = "chkFeather"
        Me.chkFeather.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.AllowDrop = True
        resources.ApplyResources(Me.txtTime, "txtTime")
        Me.txtTime.Name = "txtTime"
        '
        'txtComboVID
        '
        Me.txtComboVID.AllowDrop = True
        Me.txtComboVID.FormattingEnabled = True
        Me.txtComboVID.Items.AddRange(New Object() {resources.GetString("txtComboVID.Items"), resources.GetString("txtComboVID.Items1")})
        resources.ApplyResources(Me.txtComboVID, "txtComboVID")
        Me.txtComboVID.Name = "txtComboVID"
        '
        'grpBoxOutputs
        '
        resources.ApplyResources(Me.grpBoxOutputs, "grpBoxOutputs")
        Me.grpBoxOutputs.Controls.Add(Me.chkShowNotification)
        Me.grpBoxOutputs.Controls.Add(Me.btnReset)
        Me.grpBoxOutputs.Controls.Add(Me.btnEmbed)
        Me.grpBoxOutputs.Controls.Add(Me.btnVideoInfo)
        Me.grpBoxOutputs.Controls.Add(Me.btnComments)
        Me.grpBoxOutputs.Controls.Add(Me.btnVideo)
        Me.grpBoxOutputs.Name = "grpBoxOutputs"
        Me.grpBoxOutputs.TabStop = False
        '
        'chkShowNotification
        '
        resources.ApplyResources(Me.chkShowNotification, "chkShowNotification")
        Me.chkShowNotification.Name = "chkShowNotification"
        Me.chkShowNotification.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        resources.ApplyResources(Me.btnReset, "btnReset")
        Me.btnReset.Image = Global.YTVL.My.Resources.Resources._1371833577_view_refresh
        Me.btnReset.Name = "btnReset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEmbed
        '
        resources.ApplyResources(Me.btnEmbed, "btnEmbed")
        Me.btnEmbed.Name = "btnEmbed"
        Me.btnEmbed.UseVisualStyleBackColor = True
        '
        'btnVideoInfo
        '
        resources.ApplyResources(Me.btnVideoInfo, "btnVideoInfo")
        Me.btnVideoInfo.Image = Global.YTVL.My.Resources.Resources.documentinfo
        Me.btnVideoInfo.Name = "btnVideoInfo"
        Me.btnVideoInfo.UseVisualStyleBackColor = True
        '
        'btnComments
        '
        Me.btnComments.Image = Global.YTVL.My.Resources.Resources.facebook_messages
        resources.ApplyResources(Me.btnComments, "btnComments")
        Me.btnComments.Name = "btnComments"
        Me.btnComments.UseVisualStyleBackColor = True
        '
        'btnVideo
        '
        resources.ApplyResources(Me.btnVideo, "btnVideo")
        Me.btnVideo.Image = Global.YTVL.My.Resources.Resources.android_app_20x14
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.UseVisualStyleBackColor = True
        '
        'grpBoxAbout
        '
        resources.ApplyResources(Me.grpBoxAbout, "grpBoxAbout")
        Me.grpBoxAbout.Controls.Add(Me.lnkWalkman)
        Me.grpBoxAbout.Controls.Add(Me.lnkReleases)
        Me.grpBoxAbout.Controls.Add(Me.lnkReportProblem)
        Me.grpBoxAbout.Controls.Add(Me.lnkSourceCode)
        Me.grpBoxAbout.Controls.Add(Me.lnkOriginalPage)
        Me.grpBoxAbout.Name = "grpBoxAbout"
        Me.grpBoxAbout.TabStop = False
        '
        'lnkWalkman
        '
        resources.ApplyResources(Me.lnkWalkman, "lnkWalkman")
        Me.lnkWalkman.LinkColor = System.Drawing.Color.Silver
        Me.lnkWalkman.Name = "lnkWalkman"
        Me.lnkWalkman.TabStop = True
        Me.lnkWalkman.VisitedLinkColor = System.Drawing.Color.Gray
        '
        'lnkReleases
        '
        resources.ApplyResources(Me.lnkReleases, "lnkReleases")
        Me.lnkReleases.Name = "lnkReleases"
        Me.lnkReleases.TabStop = True
        '
        'lnkReportProblem
        '
        resources.ApplyResources(Me.lnkReportProblem, "lnkReportProblem")
        Me.lnkReportProblem.Name = "lnkReportProblem"
        Me.lnkReportProblem.TabStop = True
        '
        'lnkSourceCode
        '
        resources.ApplyResources(Me.lnkSourceCode, "lnkSourceCode")
        Me.lnkSourceCode.Name = "lnkSourceCode"
        Me.lnkSourceCode.TabStop = True
        '
        'lnkOriginalPage
        '
        resources.ApplyResources(Me.lnkOriginalPage, "lnkOriginalPage")
        Me.lnkOriginalPage.Name = "lnkOriginalPage"
        Me.lnkOriginalPage.TabStop = True
        '
        'lblCurrentVersion
        '
        resources.ApplyResources(Me.lblCurrentVersion, "lblCurrentVersion")
        Me.lblCurrentVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCurrentVersion.Name = "lblCurrentVersion"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.NotificationMenuStrip
        resources.ApplyResources(Me.NotifyIcon, "NotifyIcon")
        '
        'NotificationMenuStrip
        '
        Me.NotificationMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowYTVLToolStripMenuItem, Me.ToolStripSeparator, Me.VideoToolStripMenuItem, Me.CommentsToolStripMenuItem, Me.VideoInfoToolStripMenuItem, Me.EmbedToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.NotificationMenuStrip.Name = "NotificationMenuStrip"
        resources.ApplyResources(Me.NotificationMenuStrip, "NotificationMenuStrip")
        '
        'ShowYTVLToolStripMenuItem
        '
        Me.ShowYTVLToolStripMenuItem.Image = Global.YTVL.My.Resources.Resources._1387147104_video_display
        Me.ShowYTVLToolStripMenuItem.Name = "ShowYTVLToolStripMenuItem"
        resources.ApplyResources(Me.ShowYTVLToolStripMenuItem, "ShowYTVLToolStripMenuItem")
        '
        'ToolStripSeparator
        '
        Me.ToolStripSeparator.Name = "ToolStripSeparator"
        resources.ApplyResources(Me.ToolStripSeparator, "ToolStripSeparator")
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.Image = Global.YTVL.My.Resources.Resources.android_app_20x14
        resources.ApplyResources(Me.VideoToolStripMenuItem, "VideoToolStripMenuItem")
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        '
        'CommentsToolStripMenuItem
        '
        Me.CommentsToolStripMenuItem.Image = Global.YTVL.My.Resources.Resources.facebook_messages
        Me.CommentsToolStripMenuItem.Name = "CommentsToolStripMenuItem"
        resources.ApplyResources(Me.CommentsToolStripMenuItem, "CommentsToolStripMenuItem")
        '
        'VideoInfoToolStripMenuItem
        '
        Me.VideoInfoToolStripMenuItem.Image = Global.YTVL.My.Resources.Resources.documentinfo
        Me.VideoInfoToolStripMenuItem.Name = "VideoInfoToolStripMenuItem"
        resources.ApplyResources(Me.VideoInfoToolStripMenuItem, "VideoInfoToolStripMenuItem")
        '
        'EmbedToolStripMenuItem
        '
        Me.EmbedToolStripMenuItem.Image = Global.YTVL.My.Resources.Resources._1387139872_window_new
        Me.EmbedToolStripMenuItem.Name = "EmbedToolStripMenuItem"
        resources.ApplyResources(Me.EmbedToolStripMenuItem, "EmbedToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = Global.YTVL.My.Resources.Resources.Exit2
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        resources.ApplyResources(Me.CloseToolStripMenuItem, "CloseToolStripMenuItem")
        '
        'YTVL
        '
        Me.AcceptButton = Me.btnVideo
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCurrentVersion)
        Me.Controls.Add(Me.grpBoxAbout)
        Me.Controls.Add(Me.grpBoxOutputs)
        Me.Controls.Add(Me.grpBoxInputs)
        Me.HelpButton = True
        Me.Name = "YTVL"
        Me.grpBoxInputs.ResumeLayout(False)
        Me.grpBoxInputs.PerformLayout()
        Me.grpBoxOutputs.ResumeLayout(False)
        Me.grpBoxOutputs.PerformLayout()
        Me.grpBoxAbout.ResumeLayout(False)
        Me.grpBoxAbout.PerformLayout()
        Me.NotificationMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBoxInputs As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxOutputs As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxAbout As System.Windows.Forms.GroupBox
    Friend WithEvents lblFeather As System.Windows.Forms.LinkLabel
    Friend WithEvents chkFeather As System.Windows.Forms.CheckBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtComboVID As System.Windows.Forms.ComboBox
    Friend WithEvents txtList As System.Windows.Forms.TextBox
    Friend WithEvents lblHL As System.Windows.Forms.Label
    Friend WithEvents chkHL As System.Windows.Forms.CheckBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnEmbed As System.Windows.Forms.Button
    Friend WithEvents btnVideoInfo As System.Windows.Forms.Button
    Friend WithEvents btnComments As System.Windows.Forms.Button
    Friend WithEvents btnVideo As System.Windows.Forms.Button
    Friend WithEvents lnkReleases As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkReportProblem As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkSourceCode As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkOriginalPage As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkWalkman As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAdvanced As System.Windows.Forms.Button
    Friend WithEvents lblCurrentVersion As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotificationMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowYTVLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmbedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkShowNotification As System.Windows.Forms.CheckBox

End Class
