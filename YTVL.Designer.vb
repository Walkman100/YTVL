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
        Me.lblBrowser = New System.Windows.Forms.Label()
        Me.txtComboBrowser = New System.Windows.Forms.ComboBox()
        Me.txtComboVID = New System.Windows.Forms.ComboBox()
        Me.imgLoading = New System.Windows.Forms.PictureBox()
        Me.btnAdvanced = New System.Windows.Forms.Button()
        Me.pnlRight1 = New System.Windows.Forms.Panel()
        Me.optMdstBrndng0 = New System.Windows.Forms.RadioButton()
        Me.optMdstBrndng1 = New System.Windows.Forms.RadioButton()
        Me.pnlRight2 = New System.Windows.Forms.Panel()
        Me.optRel0 = New System.Windows.Forms.RadioButton()
        Me.optRel1 = New System.Windows.Forms.RadioButton()
        Me.pnlRight3 = New System.Windows.Forms.Panel()
        Me.optShowinfo0 = New System.Windows.Forms.RadioButton()
        Me.optShowinfo1 = New System.Windows.Forms.RadioButton()
        Me.pnlRight4 = New System.Windows.Forms.Panel()
        Me.optShowsearch0 = New System.Windows.Forms.RadioButton()
        Me.optShowsearch1 = New System.Windows.Forms.RadioButton()
        Me.pnlEnableJsApi = New System.Windows.Forms.Panel()
        Me.optEnableJsApi0 = New System.Windows.Forms.RadioButton()
        Me.optEnableJsApi1 = New System.Windows.Forms.RadioButton()
        Me.pnlAutoplay = New System.Windows.Forms.Panel()
        Me.optAutoplay0 = New System.Windows.Forms.RadioButton()
        Me.optAutoplay1 = New System.Windows.Forms.RadioButton()
        Me.pnlAutohide = New System.Windows.Forms.Panel()
        Me.optAutohide0 = New System.Windows.Forms.RadioButton()
        Me.optAutohide1 = New System.Windows.Forms.RadioButton()
        Me.pnlFs = New System.Windows.Forms.Panel()
        Me.optFs0 = New System.Windows.Forms.RadioButton()
        Me.optFs1 = New System.Windows.Forms.RadioButton()
        Me.pnlQuality = New System.Windows.Forms.Panel()
        Me.optQuality360 = New System.Windows.Forms.RadioButton()
        Me.optQuality720 = New System.Windows.Forms.RadioButton()
        Me.chkHttps = New System.Windows.Forms.CheckBox()
        Me.txtOrigin = New System.Windows.Forms.TextBox()
        Me.chkOrigin = New System.Windows.Forms.CheckBox()
        Me.chkWmode = New System.Windows.Forms.CheckBox()
        Me.chkThemeDark = New System.Windows.Forms.CheckBox()
        Me.lblShowSearch = New System.Windows.Forms.Label()
        Me.lblShowinfo = New System.Windows.Forms.Label()
        Me.lblRel = New System.Windows.Forms.Label()
        Me.lblMdstBrndng = New System.Windows.Forms.Label()
        Me.optIvLP = New System.Windows.Forms.ComboBox()
        Me.lblIvLP = New System.Windows.Forms.Label()
        Me.lblEnableJsApi = New System.Windows.Forms.Label()
        Me.lblAutohide = New System.Windows.Forms.Label()
        Me.lblFs = New System.Windows.Forms.Label()
        Me.lblAutoplay = New System.Windows.Forms.Label()
        Me.chkFeature = New System.Windows.Forms.CheckBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.lblHL = New System.Windows.Forms.Label()
        Me.chkHL = New System.Windows.Forms.CheckBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblVideoTitle = New System.Windows.Forms.Label()
        Me.chkRememberBrowser = New System.Windows.Forms.CheckBox()
        Me.ContextClipboard = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextClipboardCopyFromGenerated = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextClipboardCopyCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextClipboardCopyCodeHTML = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextClipboardCopyCodeBB = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextClipboardCopyCodeSeperator = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextClipboardCopyCodeStandard = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextClipboardCopyCodeOldCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkKeepOnTop = New System.Windows.Forms.CheckBox()
        Me.grpBoxOutputs = New System.Windows.Forms.GroupBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.WebBrowserVideoLoad = New System.Windows.Forms.WebBrowser()
        Me.WebBrowserVersionCheck = New System.Windows.Forms.WebBrowser()
        Me.btnThumbnail = New System.Windows.Forms.Button()
        Me.btnDeturl = New System.Windows.Forms.Button()
        Me.ContextDownload = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextDownloadCopyFromGenerated = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextDownloadFullripVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextDownloadFullripVideoAlternate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextDownloadFullripMP3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextDownloadKeepVid = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkShowNotification = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEmbed = New System.Windows.Forms.Button()
        Me.btnVideoInfo = New System.Windows.Forms.Button()
        Me.btnComments = New System.Windows.Forms.Button()
        Me.btnVideo = New System.Windows.Forms.Button()
        Me.grpBoxAbout = New System.Windows.Forms.GroupBox()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.lnkDeveloper = New System.Windows.Forms.LinkLabel()
        Me.lnkReleases = New System.Windows.Forms.LinkLabel()
        Me.lnkReportProblem = New System.Windows.Forms.LinkLabel()
        Me.lnkSourceCode = New System.Windows.Forms.LinkLabel()
        Me.lnkOriginalPage = New System.Windows.Forms.LinkLabel()
        Me.lblCurrentVersion = New System.Windows.Forms.Label()
        Me.NotificationIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotificationMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotificationMenuStripShowYTVL = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationMenuStripKeepOnTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationMenuStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificationMenuStripVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationMenuStripComments = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationMenuStripVideoInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationMenuStripEmbed = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationMenuStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificationMenuStripHideIcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationMenuStripClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.openFileDialogBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.grpBoxInputs.SuspendLayout
        CType(Me.imgLoading,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlRight1.SuspendLayout
        Me.pnlRight2.SuspendLayout
        Me.pnlRight3.SuspendLayout
        Me.pnlRight4.SuspendLayout
        Me.pnlEnableJsApi.SuspendLayout
        Me.pnlAutoplay.SuspendLayout
        Me.pnlAutohide.SuspendLayout
        Me.pnlFs.SuspendLayout
        Me.pnlQuality.SuspendLayout
        Me.ContextClipboard.SuspendLayout
        Me.grpBoxOutputs.SuspendLayout
        Me.ContextDownload.SuspendLayout
        Me.grpBoxAbout.SuspendLayout
        Me.NotificationMenuStrip.SuspendLayout
        Me.SuspendLayout
        '
        'grpBoxInputs
        '
        Me.grpBoxInputs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpBoxInputs.Controls.Add(Me.lblBrowser)
        Me.grpBoxInputs.Controls.Add(Me.txtComboBrowser)
        Me.grpBoxInputs.Controls.Add(Me.txtComboVID)
        Me.grpBoxInputs.Controls.Add(Me.imgLoading)
        Me.grpBoxInputs.Controls.Add(Me.btnAdvanced)
        Me.grpBoxInputs.Controls.Add(Me.pnlRight1)
        Me.grpBoxInputs.Controls.Add(Me.pnlRight2)
        Me.grpBoxInputs.Controls.Add(Me.pnlRight3)
        Me.grpBoxInputs.Controls.Add(Me.pnlRight4)
        Me.grpBoxInputs.Controls.Add(Me.pnlEnableJsApi)
        Me.grpBoxInputs.Controls.Add(Me.pnlAutoplay)
        Me.grpBoxInputs.Controls.Add(Me.pnlAutohide)
        Me.grpBoxInputs.Controls.Add(Me.pnlFs)
        Me.grpBoxInputs.Controls.Add(Me.pnlQuality)
        Me.grpBoxInputs.Controls.Add(Me.chkHttps)
        Me.grpBoxInputs.Controls.Add(Me.txtOrigin)
        Me.grpBoxInputs.Controls.Add(Me.chkOrigin)
        Me.grpBoxInputs.Controls.Add(Me.chkWmode)
        Me.grpBoxInputs.Controls.Add(Me.chkThemeDark)
        Me.grpBoxInputs.Controls.Add(Me.lblShowSearch)
        Me.grpBoxInputs.Controls.Add(Me.lblShowinfo)
        Me.grpBoxInputs.Controls.Add(Me.lblRel)
        Me.grpBoxInputs.Controls.Add(Me.lblMdstBrndng)
        Me.grpBoxInputs.Controls.Add(Me.optIvLP)
        Me.grpBoxInputs.Controls.Add(Me.lblIvLP)
        Me.grpBoxInputs.Controls.Add(Me.lblEnableJsApi)
        Me.grpBoxInputs.Controls.Add(Me.lblAutohide)
        Me.grpBoxInputs.Controls.Add(Me.lblFs)
        Me.grpBoxInputs.Controls.Add(Me.lblAutoplay)
        Me.grpBoxInputs.Controls.Add(Me.chkFeature)
        Me.grpBoxInputs.Controls.Add(Me.txtList)
        Me.grpBoxInputs.Controls.Add(Me.lblHL)
        Me.grpBoxInputs.Controls.Add(Me.chkHL)
        Me.grpBoxInputs.Controls.Add(Me.txtTime)
        Me.grpBoxInputs.Controls.Add(Me.lblVideoTitle)
        Me.grpBoxInputs.Controls.Add(Me.chkRememberBrowser)
        Me.grpBoxInputs.Location = New System.Drawing.Point(12, 12)
        Me.grpBoxInputs.Name = "grpBoxInputs"
        Me.grpBoxInputs.Size = New System.Drawing.Size(466, 67)
        Me.grpBoxInputs.TabIndex = 0
        Me.grpBoxInputs.TabStop = false
        Me.grpBoxInputs.Text = "Inputs"
        Me.ToolTip.SetToolTip(Me.grpBoxInputs, "Select your options")
        '
        'lblBrowser
        '
        Me.lblBrowser.AutoSize = true
        Me.lblBrowser.Location = New System.Drawing.Point(6, 201)
        Me.lblBrowser.Name = "lblBrowser"
        Me.lblBrowser.Size = New System.Drawing.Size(123, 13)
        Me.lblBrowser.TabIndex = 50
        Me.lblBrowser.Text = "Where to open the links:"
        '
        'txtComboBrowser
        '
        Me.txtComboBrowser.AllowDrop = true
        Me.txtComboBrowser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtComboBrowser.FormattingEnabled = true
        Me.txtComboBrowser.Items.AddRange(New Object() {"Default link handler", "Mozilla Firefox (%ProgramFiles%\Mozilla Firefox\firefox.exe)", "Google Chrome (%ProgramFiles%\Google\Chrome\Application\chrome.exe)", "Vivaldi (%ProgramFiles%\Vivaldi\Application\vivaldi.exe)", "Opera 22 (%ProgramFiles%\Opera\launcher.exe)", "Opera 12 (%ProgramFiles%\Opera\opera.exe)", "Safari (%ProgramFiles%\Safari\Safari.exe)", "Avant Browser (%ProgramFiles%\Avant Browser\avant.exe)", "Lunascape6 (%ProgramFiles%\Lunascape\Lunascape6\Luna.exe)", "Sea Monkey (%ProgramFiles%\SeaMonkey\seamonkey.exe)", "Internet Explorer (%ProgramFiles%\Internet Explorer\iexplore.exe)", "Netscape Navigator 9 (%ProgramFiles%\Netscape\Navigator 9\navigator.exe)", "Send to Clipboard", "Browse..."})
        Me.txtComboBrowser.Location = New System.Drawing.Point(135, 198)
        Me.txtComboBrowser.MaxDropDownItems = 20
        Me.txtComboBrowser.Name = "txtComboBrowser"
        Me.txtComboBrowser.Size = New System.Drawing.Size(242, 21)
        Me.txtComboBrowser.TabIndex = 49
        Me.txtComboBrowser.Text = "Default link handler"
        '
        'txtComboVID
        '
        Me.txtComboVID.AllowDrop = true
        Me.txtComboVID.Items.AddRange(New Object() {"tKNhPpUR0Pg", "CqDGF0j7vpE", "z9Uz1icjwrM", "u0fk6syQ7iY"})
        Me.txtComboVID.Location = New System.Drawing.Point(6, 19)
        Me.txtComboVID.MaxDropDownItems = 50
        Me.txtComboVID.Name = "txtComboVID"
        Me.txtComboVID.Size = New System.Drawing.Size(121, 21)
        Me.txtComboVID.TabIndex = 0
        Me.txtComboVID.Text = "Video ID"
        Me.ToolTip.SetToolTip(Me.txtComboVID, "ID to be used")
        '
        'imgLoading
        '
        Me.imgLoading.Image = Global.YTVL.My.Resources.Resources.waiting_loading
        Me.imgLoading.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.imgLoading.InitialImage = Global.YTVL.My.Resources.Resources.waiting_loading
        Me.imgLoading.Location = New System.Drawing.Point(6, 44)
        Me.imgLoading.Name = "imgLoading"
        Me.imgLoading.Size = New System.Drawing.Size(17, 17)
        Me.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgLoading.TabIndex = 47
        Me.imgLoading.TabStop = false
        Me.ToolTip.SetToolTip(Me.imgLoading, "Busy loading, please wait...")
        Me.imgLoading.Visible = false
        '
        'btnAdvanced
        '
        Me.btnAdvanced.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAdvanced.AutoSize = true
        Me.btnAdvanced.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAdvanced.BackColor = System.Drawing.Color.Transparent
        Me.btnAdvanced.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdvanced.Location = New System.Drawing.Point(404, 43)
        Me.btnAdvanced.Name = "btnAdvanced"
        Me.btnAdvanced.Size = New System.Drawing.Size(56, 23)
        Me.btnAdvanced.TabIndex = 7
        Me.btnAdvanced.Text = "More ↓"
        Me.ToolTip.SetToolTip(Me.btnAdvanced, "Show More options")
        Me.btnAdvanced.UseVisualStyleBackColor = false
        '
        'pnlRight1
        '
        Me.pnlRight1.BackColor = System.Drawing.Color.Transparent
        Me.pnlRight1.Controls.Add(Me.optMdstBrndng0)
        Me.pnlRight1.Controls.Add(Me.optMdstBrndng1)
        Me.pnlRight1.Location = New System.Drawing.Point(309, 67)
        Me.pnlRight1.Name = "pnlRight1"
        Me.pnlRight1.Size = New System.Drawing.Size(72, 15)
        Me.pnlRight1.TabIndex = 44
        '
        'optMdstBrndng0
        '
        Me.optMdstBrndng0.AutoSize = true
        Me.optMdstBrndng0.BackColor = System.Drawing.Color.Transparent
        Me.optMdstBrndng0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optMdstBrndng0.Location = New System.Drawing.Point(0, 0)
        Me.optMdstBrndng0.Name = "optMdstBrndng0"
        Me.optMdstBrndng0.Size = New System.Drawing.Size(31, 17)
        Me.optMdstBrndng0.TabIndex = 26
        Me.optMdstBrndng0.Text = "0"
        Me.optMdstBrndng0.UseVisualStyleBackColor = false
        '
        'optMdstBrndng1
        '
        Me.optMdstBrndng1.AutoSize = true
        Me.optMdstBrndng1.BackColor = System.Drawing.Color.Transparent
        Me.optMdstBrndng1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optMdstBrndng1.Location = New System.Drawing.Point(31, 0)
        Me.optMdstBrndng1.Name = "optMdstBrndng1"
        Me.optMdstBrndng1.Size = New System.Drawing.Size(31, 17)
        Me.optMdstBrndng1.TabIndex = 27
        Me.optMdstBrndng1.Text = "1"
        Me.optMdstBrndng1.UseVisualStyleBackColor = false
        '
        'pnlRight2
        '
        Me.pnlRight2.BackColor = System.Drawing.Color.Transparent
        Me.pnlRight2.Controls.Add(Me.optRel0)
        Me.pnlRight2.Controls.Add(Me.optRel1)
        Me.pnlRight2.Location = New System.Drawing.Point(309, 82)
        Me.pnlRight2.Name = "pnlRight2"
        Me.pnlRight2.Size = New System.Drawing.Size(72, 15)
        Me.pnlRight2.TabIndex = 45
        '
        'optRel0
        '
        Me.optRel0.AutoSize = true
        Me.optRel0.BackColor = System.Drawing.Color.Transparent
        Me.optRel0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optRel0.Location = New System.Drawing.Point(0, 0)
        Me.optRel0.Name = "optRel0"
        Me.optRel0.Size = New System.Drawing.Size(31, 17)
        Me.optRel0.TabIndex = 29
        Me.optRel0.Text = "0"
        Me.optRel0.UseVisualStyleBackColor = false
        '
        'optRel1
        '
        Me.optRel1.AutoSize = true
        Me.optRel1.BackColor = System.Drawing.Color.Transparent
        Me.optRel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optRel1.Location = New System.Drawing.Point(31, 0)
        Me.optRel1.Name = "optRel1"
        Me.optRel1.Size = New System.Drawing.Size(31, 17)
        Me.optRel1.TabIndex = 30
        Me.optRel1.Text = "1"
        Me.optRel1.UseVisualStyleBackColor = false
        '
        'pnlRight3
        '
        Me.pnlRight3.BackColor = System.Drawing.Color.Transparent
        Me.pnlRight3.Controls.Add(Me.optShowinfo0)
        Me.pnlRight3.Controls.Add(Me.optShowinfo1)
        Me.pnlRight3.Location = New System.Drawing.Point(309, 97)
        Me.pnlRight3.Name = "pnlRight3"
        Me.pnlRight3.Size = New System.Drawing.Size(72, 15)
        Me.pnlRight3.TabIndex = 45
        '
        'optShowinfo0
        '
        Me.optShowinfo0.AutoSize = true
        Me.optShowinfo0.BackColor = System.Drawing.Color.Transparent
        Me.optShowinfo0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optShowinfo0.Location = New System.Drawing.Point(0, 0)
        Me.optShowinfo0.Name = "optShowinfo0"
        Me.optShowinfo0.Size = New System.Drawing.Size(31, 17)
        Me.optShowinfo0.TabIndex = 32
        Me.optShowinfo0.Text = "0"
        Me.optShowinfo0.UseVisualStyleBackColor = false
        '
        'optShowinfo1
        '
        Me.optShowinfo1.AutoSize = true
        Me.optShowinfo1.BackColor = System.Drawing.Color.Transparent
        Me.optShowinfo1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optShowinfo1.Location = New System.Drawing.Point(31, 0)
        Me.optShowinfo1.Name = "optShowinfo1"
        Me.optShowinfo1.Size = New System.Drawing.Size(31, 17)
        Me.optShowinfo1.TabIndex = 33
        Me.optShowinfo1.Text = "1"
        Me.optShowinfo1.UseVisualStyleBackColor = false
        '
        'pnlRight4
        '
        Me.pnlRight4.BackColor = System.Drawing.Color.Transparent
        Me.pnlRight4.Controls.Add(Me.optShowsearch0)
        Me.pnlRight4.Controls.Add(Me.optShowsearch1)
        Me.pnlRight4.Location = New System.Drawing.Point(309, 112)
        Me.pnlRight4.Name = "pnlRight4"
        Me.pnlRight4.Size = New System.Drawing.Size(72, 15)
        Me.pnlRight4.TabIndex = 45
        '
        'optShowsearch0
        '
        Me.optShowsearch0.AutoSize = true
        Me.optShowsearch0.BackColor = System.Drawing.Color.Transparent
        Me.optShowsearch0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optShowsearch0.Location = New System.Drawing.Point(0, 0)
        Me.optShowsearch0.Name = "optShowsearch0"
        Me.optShowsearch0.Size = New System.Drawing.Size(31, 17)
        Me.optShowsearch0.TabIndex = 35
        Me.optShowsearch0.Text = "0"
        Me.optShowsearch0.UseVisualStyleBackColor = false
        '
        'optShowsearch1
        '
        Me.optShowsearch1.AutoSize = true
        Me.optShowsearch1.BackColor = System.Drawing.Color.Transparent
        Me.optShowsearch1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optShowsearch1.Location = New System.Drawing.Point(31, 0)
        Me.optShowsearch1.Name = "optShowsearch1"
        Me.optShowsearch1.Size = New System.Drawing.Size(31, 17)
        Me.optShowsearch1.TabIndex = 36
        Me.optShowsearch1.Text = "1"
        Me.optShowsearch1.UseVisualStyleBackColor = false
        '
        'pnlEnableJsApi
        '
        Me.pnlEnableJsApi.BackColor = System.Drawing.Color.Transparent
        Me.pnlEnableJsApi.Controls.Add(Me.optEnableJsApi0)
        Me.pnlEnableJsApi.Controls.Add(Me.optEnableJsApi1)
        Me.pnlEnableJsApi.Location = New System.Drawing.Point(118, 156)
        Me.pnlEnableJsApi.Name = "pnlEnableJsApi"
        Me.pnlEnableJsApi.Size = New System.Drawing.Size(72, 15)
        Me.pnlEnableJsApi.TabIndex = 44
        '
        'optEnableJsApi0
        '
        Me.optEnableJsApi0.AutoSize = true
        Me.optEnableJsApi0.BackColor = System.Drawing.Color.Transparent
        Me.optEnableJsApi0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optEnableJsApi0.Location = New System.Drawing.Point(0, 0)
        Me.optEnableJsApi0.Name = "optEnableJsApi0"
        Me.optEnableJsApi0.Size = New System.Drawing.Size(31, 17)
        Me.optEnableJsApi0.TabIndex = 21
        Me.optEnableJsApi0.Text = "0"
        Me.optEnableJsApi0.UseVisualStyleBackColor = false
        '
        'optEnableJsApi1
        '
        Me.optEnableJsApi1.AutoSize = true
        Me.optEnableJsApi1.BackColor = System.Drawing.Color.Transparent
        Me.optEnableJsApi1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optEnableJsApi1.Location = New System.Drawing.Point(31, 0)
        Me.optEnableJsApi1.Name = "optEnableJsApi1"
        Me.optEnableJsApi1.Size = New System.Drawing.Size(31, 17)
        Me.optEnableJsApi1.TabIndex = 22
        Me.optEnableJsApi1.Text = "1"
        Me.optEnableJsApi1.UseVisualStyleBackColor = false
        '
        'pnlAutoplay
        '
        Me.pnlAutoplay.BackColor = System.Drawing.Color.Transparent
        Me.pnlAutoplay.Controls.Add(Me.optAutoplay0)
        Me.pnlAutoplay.Controls.Add(Me.optAutoplay1)
        Me.pnlAutoplay.Location = New System.Drawing.Point(118, 111)
        Me.pnlAutoplay.Name = "pnlAutoplay"
        Me.pnlAutoplay.Size = New System.Drawing.Size(72, 15)
        Me.pnlAutoplay.TabIndex = 45
        '
        'optAutoplay0
        '
        Me.optAutoplay0.AutoSize = true
        Me.optAutoplay0.BackColor = System.Drawing.Color.Transparent
        Me.optAutoplay0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optAutoplay0.Location = New System.Drawing.Point(0, 0)
        Me.optAutoplay0.Name = "optAutoplay0"
        Me.optAutoplay0.Size = New System.Drawing.Size(31, 17)
        Me.optAutoplay0.TabIndex = 12
        Me.optAutoplay0.Text = "0"
        Me.optAutoplay0.UseVisualStyleBackColor = false
        '
        'optAutoplay1
        '
        Me.optAutoplay1.AutoSize = true
        Me.optAutoplay1.BackColor = System.Drawing.Color.Transparent
        Me.optAutoplay1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optAutoplay1.Location = New System.Drawing.Point(31, 0)
        Me.optAutoplay1.Name = "optAutoplay1"
        Me.optAutoplay1.Size = New System.Drawing.Size(31, 17)
        Me.optAutoplay1.TabIndex = 13
        Me.optAutoplay1.Text = "1"
        Me.optAutoplay1.UseVisualStyleBackColor = false
        '
        'pnlAutohide
        '
        Me.pnlAutohide.BackColor = System.Drawing.Color.Transparent
        Me.pnlAutohide.Controls.Add(Me.optAutohide0)
        Me.pnlAutohide.Controls.Add(Me.optAutohide1)
        Me.pnlAutohide.Location = New System.Drawing.Point(118, 141)
        Me.pnlAutohide.Name = "pnlAutohide"
        Me.pnlAutohide.Size = New System.Drawing.Size(72, 15)
        Me.pnlAutohide.TabIndex = 44
        '
        'optAutohide0
        '
        Me.optAutohide0.AutoSize = true
        Me.optAutohide0.BackColor = System.Drawing.Color.Transparent
        Me.optAutohide0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optAutohide0.Location = New System.Drawing.Point(0, 0)
        Me.optAutohide0.Name = "optAutohide0"
        Me.optAutohide0.Size = New System.Drawing.Size(31, 17)
        Me.optAutohide0.TabIndex = 18
        Me.optAutohide0.Text = "0"
        Me.optAutohide0.UseVisualStyleBackColor = false
        '
        'optAutohide1
        '
        Me.optAutohide1.AutoSize = true
        Me.optAutohide1.BackColor = System.Drawing.Color.Transparent
        Me.optAutohide1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optAutohide1.Location = New System.Drawing.Point(31, 0)
        Me.optAutohide1.Name = "optAutohide1"
        Me.optAutohide1.Size = New System.Drawing.Size(31, 17)
        Me.optAutohide1.TabIndex = 19
        Me.optAutohide1.Text = "1"
        Me.optAutohide1.UseVisualStyleBackColor = false
        '
        'pnlFs
        '
        Me.pnlFs.BackColor = System.Drawing.Color.Transparent
        Me.pnlFs.Controls.Add(Me.optFs0)
        Me.pnlFs.Controls.Add(Me.optFs1)
        Me.pnlFs.Location = New System.Drawing.Point(118, 126)
        Me.pnlFs.Name = "pnlFs"
        Me.pnlFs.Size = New System.Drawing.Size(72, 15)
        Me.pnlFs.TabIndex = 43
        '
        'optFs0
        '
        Me.optFs0.AutoSize = true
        Me.optFs0.BackColor = System.Drawing.Color.Transparent
        Me.optFs0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optFs0.Location = New System.Drawing.Point(0, 0)
        Me.optFs0.Name = "optFs0"
        Me.optFs0.Size = New System.Drawing.Size(31, 17)
        Me.optFs0.TabIndex = 15
        Me.optFs0.Text = "0"
        Me.optFs0.UseVisualStyleBackColor = false
        '
        'optFs1
        '
        Me.optFs1.AutoSize = true
        Me.optFs1.BackColor = System.Drawing.Color.Transparent
        Me.optFs1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optFs1.Location = New System.Drawing.Point(31, 0)
        Me.optFs1.Name = "optFs1"
        Me.optFs1.Size = New System.Drawing.Size(31, 17)
        Me.optFs1.TabIndex = 16
        Me.optFs1.Text = "1"
        Me.optFs1.UseVisualStyleBackColor = false
        '
        'pnlQuality
        '
        Me.pnlQuality.BackColor = System.Drawing.Color.Transparent
        Me.pnlQuality.Controls.Add(Me.optQuality360)
        Me.pnlQuality.Controls.Add(Me.optQuality720)
        Me.pnlQuality.Location = New System.Drawing.Point(6, 66)
        Me.pnlQuality.Name = "pnlQuality"
        Me.pnlQuality.Size = New System.Drawing.Size(129, 29)
        Me.pnlQuality.TabIndex = 42
        '
        'optQuality360
        '
        Me.optQuality360.AutoSize = true
        Me.optQuality360.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optQuality360.Location = New System.Drawing.Point(0, 0)
        Me.optQuality360.Name = "optQuality360"
        Me.optQuality360.Size = New System.Drawing.Size(71, 17)
        Me.optQuality360.TabIndex = 8
        Me.optQuality360.Text = "Use 360p"
        Me.optQuality360.UseVisualStyleBackColor = true
        '
        'optQuality720
        '
        Me.optQuality720.AutoSize = true
        Me.optQuality720.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.optQuality720.Location = New System.Drawing.Point(0, 14)
        Me.optQuality720.Name = "optQuality720"
        Me.optQuality720.Size = New System.Drawing.Size(130, 17)
        Me.optQuality720.TabIndex = 9
        Me.optQuality720.Text = "Use 720p (if available)"
        Me.optQuality720.UseVisualStyleBackColor = true
        '
        'chkHttps
        '
        Me.chkHttps.AutoSize = true
        Me.chkHttps.BackColor = System.Drawing.Color.Transparent
        Me.chkHttps.Checked = true
        Me.chkHttps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHttps.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkHttps.Location = New System.Drawing.Point(196, 175)
        Me.chkHttps.Name = "chkHttps"
        Me.chkHttps.Size = New System.Drawing.Size(170, 17)
        Me.chkHttps.TabIndex = 41
        Me.chkHttps.Text = "Use https (Secure connection)"
        Me.ToolTip.SetToolTip(Me.chkHttps, "Use HTTPS for all links")
        Me.chkHttps.UseVisualStyleBackColor = false
        '
        'txtOrigin
        '
        Me.txtOrigin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOrigin.Location = New System.Drawing.Point(276, 154)
        Me.txtOrigin.Name = "txtOrigin"
        Me.txtOrigin.Size = New System.Drawing.Size(184, 20)
        Me.txtOrigin.TabIndex = 40
        Me.txtOrigin.Text = "(e.g. http://9gag.tv)"
        Me.ToolTip.SetToolTip(Me.txtOrigin, "What directed you to the YouTube page")
        '
        'chkOrigin
        '
        Me.chkOrigin.AutoSize = true
        Me.chkOrigin.BackColor = System.Drawing.Color.Transparent
        Me.chkOrigin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkOrigin.Location = New System.Drawing.Point(196, 154)
        Me.chkOrigin.Name = "chkOrigin"
        Me.chkOrigin.Size = New System.Drawing.Size(79, 17)
        Me.chkOrigin.TabIndex = 39
        Me.chkOrigin.Text = "Use origin="
        Me.chkOrigin.UseVisualStyleBackColor = false
        '
        'chkWmode
        '
        Me.chkWmode.AutoSize = true
        Me.chkWmode.BackColor = System.Drawing.Color.Transparent
        Me.chkWmode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkWmode.Location = New System.Drawing.Point(196, 140)
        Me.chkWmode.Name = "chkWmode"
        Me.chkWmode.Size = New System.Drawing.Size(141, 17)
        Me.chkWmode.TabIndex = 38
        Me.chkWmode.Text = "Use wmode=transparent"
        Me.chkWmode.UseVisualStyleBackColor = false
        '
        'chkThemeDark
        '
        Me.chkThemeDark.AutoSize = true
        Me.chkThemeDark.BackColor = System.Drawing.Color.Transparent
        Me.chkThemeDark.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkThemeDark.Location = New System.Drawing.Point(196, 126)
        Me.chkThemeDark.Name = "chkThemeDark"
        Me.chkThemeDark.Size = New System.Drawing.Size(104, 17)
        Me.chkThemeDark.TabIndex = 37
        Me.chkThemeDark.Text = "Use theme=dark"
        Me.chkThemeDark.UseVisualStyleBackColor = false
        '
        'lblShowSearch
        '
        Me.lblShowSearch.AutoSize = true
        Me.lblShowSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblShowSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShowSearch.Location = New System.Drawing.Point(193, 113)
        Me.lblShowSearch.Name = "lblShowSearch"
        Me.lblShowSearch.Size = New System.Drawing.Size(92, 13)
        Me.lblShowSearch.TabIndex = 34
        Me.lblShowSearch.Text = "Use showsearch="
        '
        'lblShowinfo
        '
        Me.lblShowinfo.AutoSize = true
        Me.lblShowinfo.BackColor = System.Drawing.Color.Transparent
        Me.lblShowinfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShowinfo.Location = New System.Drawing.Point(193, 98)
        Me.lblShowinfo.Name = "lblShowinfo"
        Me.lblShowinfo.Size = New System.Drawing.Size(77, 13)
        Me.lblShowinfo.TabIndex = 31
        Me.lblShowinfo.Text = "Use showinfo="
        '
        'lblRel
        '
        Me.lblRel.AutoSize = true
        Me.lblRel.BackColor = System.Drawing.Color.Transparent
        Me.lblRel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRel.Location = New System.Drawing.Point(193, 83)
        Me.lblRel.Name = "lblRel"
        Me.lblRel.Size = New System.Drawing.Size(46, 13)
        Me.lblRel.TabIndex = 28
        Me.lblRel.Text = "Use rel="
        '
        'lblMdstBrndng
        '
        Me.lblMdstBrndng.AutoSize = true
        Me.lblMdstBrndng.BackColor = System.Drawing.Color.Transparent
        Me.lblMdstBrndng.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMdstBrndng.Location = New System.Drawing.Point(193, 69)
        Me.lblMdstBrndng.Name = "lblMdstBrndng"
        Me.lblMdstBrndng.Size = New System.Drawing.Size(110, 13)
        Me.lblMdstBrndng.TabIndex = 25
        Me.lblMdstBrndng.Text = "Use modestbranding="
        '
        'optIvLP
        '
        Me.optIvLP.FormattingEnabled = true
        Me.optIvLP.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.optIvLP.Location = New System.Drawing.Point(111, 171)
        Me.optIvLP.Name = "optIvLP"
        Me.optIvLP.Size = New System.Drawing.Size(30, 21)
        Me.optIvLP.TabIndex = 24
        '
        'lblIvLP
        '
        Me.lblIvLP.AutoSize = true
        Me.lblIvLP.BackColor = System.Drawing.Color.Transparent
        Me.lblIvLP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIvLP.Location = New System.Drawing.Point(3, 174)
        Me.lblIvLP.Name = "lblIvLP"
        Me.lblIvLP.Size = New System.Drawing.Size(102, 13)
        Me.lblIvLP.TabIndex = 23
        Me.lblIvLP.Text = "Use iv_load_policy="
        '
        'lblEnableJsApi
        '
        Me.lblEnableJsApi.AutoSize = true
        Me.lblEnableJsApi.BackColor = System.Drawing.Color.Transparent
        Me.lblEnableJsApi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEnableJsApi.Location = New System.Drawing.Point(3, 158)
        Me.lblEnableJsApi.Name = "lblEnableJsApi"
        Me.lblEnableJsApi.Size = New System.Drawing.Size(88, 13)
        Me.lblEnableJsApi.TabIndex = 20
        Me.lblEnableJsApi.Text = "Use enablejsapi="
        '
        'lblAutohide
        '
        Me.lblAutohide.AutoSize = true
        Me.lblAutohide.BackColor = System.Drawing.Color.Transparent
        Me.lblAutohide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAutohide.Location = New System.Drawing.Point(3, 143)
        Me.lblAutohide.Name = "lblAutohide"
        Me.lblAutohide.Size = New System.Drawing.Size(76, 13)
        Me.lblAutohide.TabIndex = 17
        Me.lblAutohide.Text = "Use autohide="
        '
        'lblFs
        '
        Me.lblFs.AutoSize = true
        Me.lblFs.BackColor = System.Drawing.Color.Transparent
        Me.lblFs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFs.Location = New System.Drawing.Point(3, 128)
        Me.lblFs.Name = "lblFs"
        Me.lblFs.Size = New System.Drawing.Size(43, 13)
        Me.lblFs.TabIndex = 14
        Me.lblFs.Text = "Use fs="
        '
        'lblAutoplay
        '
        Me.lblAutoplay.AutoSize = true
        Me.lblAutoplay.BackColor = System.Drawing.Color.Transparent
        Me.lblAutoplay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAutoplay.Location = New System.Drawing.Point(3, 113)
        Me.lblAutoplay.Name = "lblAutoplay"
        Me.lblAutoplay.Size = New System.Drawing.Size(75, 13)
        Me.lblAutoplay.TabIndex = 11
        Me.lblAutoplay.Text = "Use autoplay="
        '
        'chkFeature
        '
        Me.chkFeature.AutoSize = true
        Me.chkFeature.BackColor = System.Drawing.Color.Transparent
        Me.chkFeature.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkFeature.Location = New System.Drawing.Point(6, 97)
        Me.chkFeature.Name = "chkFeature"
        Me.chkFeature.Size = New System.Drawing.Size(174, 17)
        Me.chkFeature.TabIndex = 10
        Me.chkFeature.Text = "Use feature=player_embedded "
        Me.chkFeature.UseVisualStyleBackColor = false
        '
        'txtList
        '
        Me.txtList.AllowDrop = true
        Me.txtList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtList.Location = New System.Drawing.Point(239, 19)
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(221, 20)
        Me.txtList.TabIndex = 2
        Me.txtList.Text = "List (e.g. LLGqoiAgPKop0NEymu9WZxkQ)"
        Me.ToolTip.SetToolTip(Me.txtList, "What playlist the video is in")
        '
        'lblHL
        '
        Me.lblHL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblHL.AutoSize = true
        Me.lblHL.BackColor = System.Drawing.Color.Transparent
        Me.lblHL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7!)
        Me.lblHL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHL.Location = New System.Drawing.Point(317, 48)
        Me.lblHL.Name = "lblHL"
        Me.lblHL.Size = New System.Drawing.Size(81, 13)
        Me.lblHL.TabIndex = 6
        Me.lblHL.Text = "(Language flag)"
        '
        'chkHL
        '
        Me.chkHL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkHL.AutoSize = true
        Me.chkHL.BackColor = System.Drawing.Color.Transparent
        Me.chkHL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkHL.Location = New System.Drawing.Point(237, 46)
        Me.chkHL.Name = "chkHL"
        Me.chkHL.Size = New System.Drawing.Size(74, 17)
        Me.chkHL.TabIndex = 5
        Me.chkHL.Text = "Use &hl=en"
        Me.chkHL.UseVisualStyleBackColor = false
        '
        'txtTime
        '
        Me.txtTime.AllowDrop = true
        Me.txtTime.Location = New System.Drawing.Point(133, 19)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 1
        Me.txtTime.Text = "Time (e.g. 1m5s)"
        Me.ToolTip.SetToolTip(Me.txtTime, "When you want the video to start")
        '
        'lblVideoTitle
        '
        Me.lblVideoTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblVideoTitle.AutoEllipsis = true
        Me.lblVideoTitle.Location = New System.Drawing.Point(6, 47)
        Me.lblVideoTitle.Name = "lblVideoTitle"
        Me.lblVideoTitle.Size = New System.Drawing.Size(225, 13)
        Me.lblVideoTitle.TabIndex = 48
        Me.lblVideoTitle.Text = "Enter a Video ID above"
        Me.ToolTip.SetToolTip(Me.lblVideoTitle, "Video Title")
        '
        'chkRememberBrowser
        '
        Me.chkRememberBrowser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkRememberBrowser.AutoSize = true
        Me.chkRememberBrowser.Location = New System.Drawing.Point(383, 200)
        Me.chkRememberBrowser.Name = "chkRememberBrowser"
        Me.chkRememberBrowser.Size = New System.Drawing.Size(77, 17)
        Me.chkRememberBrowser.TabIndex = 51
        Me.chkRememberBrowser.Text = "Remember"
        Me.chkRememberBrowser.UseVisualStyleBackColor = true
        '
        'ContextClipboard
        '
        Me.ContextClipboard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextClipboardCopyFromGenerated, Me.ContextClipboardCopyCode})
        Me.ContextClipboard.Name = "ContextClipboard"
        Me.ContextClipboard.Size = New System.Drawing.Size(215, 48)
        '
        'ContextClipboardCopyFromGenerated
        '
        Me.ContextClipboardCopyFromGenerated.Image = Global.YTVL.My.Resources.Resources.EditCopy
        Me.ContextClipboardCopyFromGenerated.Name = "ContextClipboardCopyFromGenerated"
        Me.ContextClipboardCopyFromGenerated.Size = New System.Drawing.Size(214, 22)
        Me.ContextClipboardCopyFromGenerated.Text = "Generate URL to Clipboard"
        Me.ContextClipboardCopyFromGenerated.ToolTipText = "Generate the URL and copy it to the clipboard instead of opening it in the browse"& _ 
        "r"
        '
        'ContextClipboardCopyCode
        '
        Me.ContextClipboardCopyCode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextClipboardCopyCodeHTML, Me.ContextClipboardCopyCodeBB, Me.ContextClipboardCopyCodeSeperator, Me.ContextClipboardCopyCodeStandard, Me.ContextClipboardCopyCodeOldCode})
        Me.ContextClipboardCopyCode.Image = Global.YTVL.My.Resources.Resources.page_code
        Me.ContextClipboardCopyCode.Name = "ContextClipboardCopyCode"
        Me.ContextClipboardCopyCode.Size = New System.Drawing.Size(214, 22)
        Me.ContextClipboardCopyCode.Text = "Copy code >"
        Me.ContextClipboardCopyCode.ToolTipText = "Options to copy Embed code"
        Me.ContextClipboardCopyCode.Visible = false
        '
        'ContextClipboardCopyCodeHTML
        '
        Me.ContextClipboardCopyCodeHTML.Image = Global.YTVL.My.Resources.Resources.HTML
        Me.ContextClipboardCopyCodeHTML.Name = "ContextClipboardCopyCodeHTML"
        Me.ContextClipboardCopyCodeHTML.Size = New System.Drawing.Size(264, 22)
        Me.ContextClipboardCopyCodeHTML.Text = "HTML Embed code"
        Me.ContextClipboardCopyCodeHTML.ToolTipText = "Copy HTML Embed code to clipboard"
        '
        'ContextClipboardCopyCodeBB
        '
        Me.ContextClipboardCopyCodeBB.Image = Global.YTVL.My.Resources.Resources.bbcode
        Me.ContextClipboardCopyCodeBB.Name = "ContextClipboardCopyCodeBB"
        Me.ContextClipboardCopyCodeBB.Size = New System.Drawing.Size(264, 22)
        Me.ContextClipboardCopyCodeBB.Text = "BB Embed code (for forums)"
        Me.ContextClipboardCopyCodeBB.ToolTipText = "Copy BB Embed code to clipboard"
        '
        'ContextClipboardCopyCodeSeperator
        '
        Me.ContextClipboardCopyCodeSeperator.Name = "ContextClipboardCopyCodeSeperator"
        Me.ContextClipboardCopyCodeSeperator.Size = New System.Drawing.Size(261, 6)
        '
        'ContextClipboardCopyCodeStandard
        '
        Me.ContextClipboardCopyCodeStandard.Checked = true
        Me.ContextClipboardCopyCodeStandard.CheckOnClick = true
        Me.ContextClipboardCopyCodeStandard.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ContextClipboardCopyCodeStandard.Name = "ContextClipboardCopyCodeStandard"
        Me.ContextClipboardCopyCodeStandard.Size = New System.Drawing.Size(264, 22)
        Me.ContextClipboardCopyCodeStandard.Text = "Standard Embed code"
        Me.ContextClipboardCopyCodeStandard.ToolTipText = "Use Standard (not old) HTML embed code"
        '
        'ContextClipboardCopyCodeOldCode
        '
        Me.ContextClipboardCopyCodeOldCode.CheckOnClick = true
        Me.ContextClipboardCopyCodeOldCode.Name = "ContextClipboardCopyCodeOldCode"
        Me.ContextClipboardCopyCodeOldCode.Size = New System.Drawing.Size(264, 22)
        Me.ContextClipboardCopyCodeOldCode.Text = "Old Embed code (more compatible)"
        Me.ContextClipboardCopyCodeOldCode.ToolTipText = "Use old HTML embed code"
        '
        'chkKeepOnTop
        '
        Me.chkKeepOnTop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkKeepOnTop.AutoSize = true
        Me.chkKeepOnTop.BackColor = System.Drawing.Color.Transparent
        Me.chkKeepOnTop.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chkKeepOnTop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkKeepOnTop.Location = New System.Drawing.Point(360, 0)
        Me.chkKeepOnTop.Name = "chkKeepOnTop"
        Me.chkKeepOnTop.Size = New System.Drawing.Size(123, 17)
        Me.chkKeepOnTop.TabIndex = 7
        Me.chkKeepOnTop.Text = "Keep window on &top"
        Me.chkKeepOnTop.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip.SetToolTip(Me.chkKeepOnTop, "Keep window on top of all other windows")
        Me.chkKeepOnTop.UseVisualStyleBackColor = false
        '
        'grpBoxOutputs
        '
        Me.grpBoxOutputs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpBoxOutputs.Controls.Add(Me.btnConvert)
        Me.grpBoxOutputs.Controls.Add(Me.WebBrowserVideoLoad)
        Me.grpBoxOutputs.Controls.Add(Me.WebBrowserVersionCheck)
        Me.grpBoxOutputs.Controls.Add(Me.btnThumbnail)
        Me.grpBoxOutputs.Controls.Add(Me.btnDeturl)
        Me.grpBoxOutputs.Controls.Add(Me.btnExit)
        Me.grpBoxOutputs.Controls.Add(Me.chkShowNotification)
        Me.grpBoxOutputs.Controls.Add(Me.btnReset)
        Me.grpBoxOutputs.Controls.Add(Me.btnEmbed)
        Me.grpBoxOutputs.Controls.Add(Me.btnVideoInfo)
        Me.grpBoxOutputs.Controls.Add(Me.btnComments)
        Me.grpBoxOutputs.Controls.Add(Me.btnVideo)
        Me.grpBoxOutputs.Location = New System.Drawing.Point(12, 85)
        Me.grpBoxOutputs.Name = "grpBoxOutputs"
        Me.grpBoxOutputs.Size = New System.Drawing.Size(466, 77)
        Me.grpBoxOutputs.TabIndex = 1
        Me.grpBoxOutputs.TabStop = false
        Me.grpBoxOutputs.Text = "Outputs"
        Me.ToolTip.SetToolTip(Me.grpBoxOutputs, "Ways to display your options")
        '
        'btnConvert
        '
        Me.btnConvert.AutoSize = true
        Me.btnConvert.Location = New System.Drawing.Point(267, 48)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(111, 23)
        Me.btnConvert.TabIndex = 9
        Me.btnConvert.Text = "Convert from URL..."
        Me.btnConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConvert.UseVisualStyleBackColor = true
        '
        'WebBrowserVideoLoad
        '
        Me.WebBrowserVideoLoad.AccessibleDescription = "Video Name"
        Me.WebBrowserVideoLoad.AccessibleName = "Video Name"
        Me.WebBrowserVideoLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.WebBrowserVideoLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.WebBrowserVideoLoad.Location = New System.Drawing.Point(547, 19)
        Me.WebBrowserVideoLoad.MaximumSize = New System.Drawing.Size(100, 50)
        Me.WebBrowserVideoLoad.Name = "WebBrowserVideoLoad"
        Me.WebBrowserVideoLoad.ScriptErrorsSuppressed = true
        Me.WebBrowserVideoLoad.Size = New System.Drawing.Size(100, 50)
        Me.WebBrowserVideoLoad.TabIndex = 8
        Me.WebBrowserVideoLoad.TabStop = false
        Me.ToolTip.SetToolTip(Me.WebBrowserVideoLoad, "Video Name")
        Me.WebBrowserVideoLoad.Visible = false
        '
        'WebBrowserVersionCheck
        '
        Me.WebBrowserVersionCheck.AccessibleDescription = "Version Checker"
        Me.WebBrowserVersionCheck.AccessibleName = "Version Checker"
        Me.WebBrowserVersionCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.WebBrowserVersionCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.WebBrowserVersionCheck.Location = New System.Drawing.Point(648, 19)
        Me.WebBrowserVersionCheck.MaximumSize = New System.Drawing.Size(100, 50)
        Me.WebBrowserVersionCheck.Name = "WebBrowserVersionCheck"
        Me.WebBrowserVersionCheck.ScriptErrorsSuppressed = true
        Me.WebBrowserVersionCheck.Size = New System.Drawing.Size(100, 50)
        Me.WebBrowserVersionCheck.TabIndex = 5
        Me.WebBrowserVersionCheck.TabStop = false
        Me.ToolTip.SetToolTip(Me.WebBrowserVersionCheck, "Latest Version as reported by the server")
        Me.WebBrowserVersionCheck.Visible = false
        '
        'btnThumbnail
        '
        Me.btnThumbnail.AutoSize = true
        Me.btnThumbnail.Enabled = false
        Me.btnThumbnail.Image = Global.YTVL.My.Resources.Resources._1387147104_video_display
        Me.btnThumbnail.Location = New System.Drawing.Point(149, 48)
        Me.btnThumbnail.Name = "btnThumbnail"
        Me.btnThumbnail.Size = New System.Drawing.Size(112, 23)
        Me.btnThumbnail.TabIndex = 8
        Me.btnThumbnail.Text = "Show Thumbnail"
        Me.btnThumbnail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnThumbnail.UseVisualStyleBackColor = true
        '
        'btnDeturl
        '
        Me.btnDeturl.AutoSize = true
        Me.btnDeturl.ContextMenuStrip = Me.ContextDownload
        Me.btnDeturl.Enabled = false
        Me.btnDeturl.Image = CType(resources.GetObject("btnDeturl.Image"),System.Drawing.Image)
        Me.btnDeturl.Location = New System.Drawing.Point(6, 48)
        Me.btnDeturl.Name = "btnDeturl"
        Me.btnDeturl.Size = New System.Drawing.Size(137, 23)
        Me.btnDeturl.TabIndex = 7
        Me.btnDeturl.Text = "Download from deturl"
        Me.btnDeturl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeturl.UseVisualStyleBackColor = true
        '
        'ContextDownload
        '
        Me.ContextDownload.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextDownloadCopyFromGenerated, Me.ContextDownloadFullripVideo, Me.ContextDownloadFullripVideoAlternate, Me.ContextDownloadFullripMP3, Me.ContextDownloadKeepVid})
        Me.ContextDownload.Name = "contextMenuStrip1"
        Me.ContextDownload.Size = New System.Drawing.Size(215, 114)
        '
        'ContextDownloadCopyFromGenerated
        '
        Me.ContextDownloadCopyFromGenerated.Image = Global.YTVL.My.Resources.Resources.EditCopy
        Me.ContextDownloadCopyFromGenerated.Name = "ContextDownloadCopyFromGenerated"
        Me.ContextDownloadCopyFromGenerated.Size = New System.Drawing.Size(214, 22)
        Me.ContextDownloadCopyFromGenerated.Text = "Generate URL to Clipboard"
        '
        'ContextDownloadFullripVideo
        '
        Me.ContextDownloadFullripVideo.Image = CType(resources.GetObject("ContextDownloadFullripVideo.Image"),System.Drawing.Image)
        Me.ContextDownloadFullripVideo.Name = "ContextDownloadFullripVideo"
        Me.ContextDownloadFullripVideo.Size = New System.Drawing.Size(214, 22)
        Me.ContextDownloadFullripVideo.Text = "FullRip: Video"
        '
        'ContextDownloadFullripVideoAlternate
        '
        Me.ContextDownloadFullripVideoAlternate.Image = CType(resources.GetObject("ContextDownloadFullripVideoAlternate.Image"),System.Drawing.Image)
        Me.ContextDownloadFullripVideoAlternate.Name = "ContextDownloadFullripVideoAlternate"
        Me.ContextDownloadFullripVideoAlternate.Size = New System.Drawing.Size(214, 22)
        Me.ContextDownloadFullripVideoAlternate.Text = "FullRip: Video Alternate"
        '
        'ContextDownloadFullripMP3
        '
        Me.ContextDownloadFullripMP3.Image = CType(resources.GetObject("ContextDownloadFullripMP3.Image"),System.Drawing.Image)
        Me.ContextDownloadFullripMP3.Name = "ContextDownloadFullripMP3"
        Me.ContextDownloadFullripMP3.Size = New System.Drawing.Size(214, 22)
        Me.ContextDownloadFullripMP3.Text = "FullRip: MP3"
        '
        'ContextDownloadKeepVid
        '
        Me.ContextDownloadKeepVid.Image = CType(resources.GetObject("ContextDownloadKeepVid.Image"),System.Drawing.Image)
        Me.ContextDownloadKeepVid.Name = "ContextDownloadKeepVid"
        Me.ContextDownloadKeepVid.Size = New System.Drawing.Size(214, 22)
        Me.ContextDownloadKeepVid.Text = "KeepVid"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = Global.YTVL.My.Resources.Resources.Exit2
        Me.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExit.Location = New System.Drawing.Point(466, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip.SetToolTip(Me.btnExit, "Close YTVL")
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'chkShowNotification
        '
        Me.chkShowNotification.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkShowNotification.AutoSize = true
        Me.chkShowNotification.BackColor = System.Drawing.SystemColors.Control
        Me.chkShowNotification.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkShowNotification.Location = New System.Drawing.Point(315, -1)
        Me.chkShowNotification.Name = "chkShowNotification"
        Me.chkShowNotification.Size = New System.Drawing.Size(133, 17)
        Me.chkShowNotification.TabIndex = 5
        Me.chkShowNotification.Text = "Show &Notification Icon"
        Me.ToolTip.SetToolTip(Me.chkShowNotification, "Show notification icon in System tray")
        Me.chkShowNotification.UseVisualStyleBackColor = false
        '
        'btnReset
        '
        Me.btnReset.AutoSize = true
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.Image = Global.YTVL.My.Resources.Resources._1371833577_view_refresh
        Me.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnReset.Location = New System.Drawing.Point(385, 19)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip.SetToolTip(Me.btnReset, "Resets all form objects, including the size of the form but not options.")
        Me.btnReset.UseVisualStyleBackColor = false
        '
        'btnEmbed
        '
        Me.btnEmbed.AutoSize = true
        Me.btnEmbed.BackColor = System.Drawing.Color.Transparent
        Me.btnEmbed.ContextMenuStrip = Me.ContextClipboard
        Me.btnEmbed.Enabled = false
        Me.btnEmbed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEmbed.Location = New System.Drawing.Point(258, 19)
        Me.btnEmbed.Name = "btnEmbed"
        Me.btnEmbed.Size = New System.Drawing.Size(121, 23)
        Me.btnEmbed.TabIndex = 3
        Me.btnEmbed.Text = "&Embed Page Handler"
        Me.btnEmbed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip.SetToolTip(Me.btnEmbed, "Open a page with just the Embedded video")
        Me.btnEmbed.UseVisualStyleBackColor = false
        '
        'btnVideoInfo
        '
        Me.btnVideoInfo.AutoSize = true
        Me.btnVideoInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnVideoInfo.ContextMenuStrip = Me.ContextClipboard
        Me.btnVideoInfo.Enabled = false
        Me.btnVideoInfo.Image = Global.YTVL.My.Resources.Resources.documentinfo
        Me.btnVideoInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnVideoInfo.Location = New System.Drawing.Point(171, 19)
        Me.btnVideoInfo.Name = "btnVideoInfo"
        Me.btnVideoInfo.Size = New System.Drawing.Size(81, 23)
        Me.btnVideoInfo.TabIndex = 2
        Me.btnVideoInfo.Text = "Video &Info"
        Me.btnVideoInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip.SetToolTip(Me.btnVideoInfo, "Download the Video Info file for  the chosen video")
        Me.btnVideoInfo.UseVisualStyleBackColor = false
        '
        'btnComments
        '
        Me.btnComments.BackColor = System.Drawing.Color.Transparent
        Me.btnComments.ContextMenuStrip = Me.ContextClipboard
        Me.btnComments.Enabled = false
        Me.btnComments.Image = Global.YTVL.My.Resources.Resources.facebook_messages
        Me.btnComments.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnComments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnComments.Location = New System.Drawing.Point(87, 19)
        Me.btnComments.Name = "btnComments"
        Me.btnComments.Size = New System.Drawing.Size(78, 23)
        Me.btnComments.TabIndex = 1
        Me.btnComments.Text = "&Comments"
        Me.btnComments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip.SetToolTip(Me.btnComments, "Show a page with just the comments for the specified video")
        Me.btnComments.UseVisualStyleBackColor = false
        '
        'btnVideo
        '
        Me.btnVideo.AutoSize = true
        Me.btnVideo.BackColor = System.Drawing.Color.Transparent
        Me.btnVideo.ContextMenuStrip = Me.ContextClipboard
        Me.btnVideo.Enabled = false
        Me.btnVideo.Image = Global.YTVL.My.Resources.Resources.android_app_20x14
        Me.btnVideo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnVideo.Location = New System.Drawing.Point(6, 19)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.Size = New System.Drawing.Size(75, 23)
        Me.btnVideo.TabIndex = 0
        Me.btnVideo.Text = "&Video"
        Me.btnVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip.SetToolTip(Me.btnVideo, "Open the standard video page")
        Me.btnVideo.UseVisualStyleBackColor = false
        '
        'grpBoxAbout
        '
        Me.grpBoxAbout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpBoxAbout.Controls.Add(Me.btnDebug)
        Me.grpBoxAbout.Controls.Add(Me.lnkDeveloper)
        Me.grpBoxAbout.Controls.Add(Me.lnkReleases)
        Me.grpBoxAbout.Controls.Add(Me.lnkReportProblem)
        Me.grpBoxAbout.Controls.Add(Me.lnkSourceCode)
        Me.grpBoxAbout.Controls.Add(Me.lnkOriginalPage)
        Me.grpBoxAbout.Location = New System.Drawing.Point(12, 168)
        Me.grpBoxAbout.Name = "grpBoxAbout"
        Me.grpBoxAbout.Size = New System.Drawing.Size(466, 42)
        Me.grpBoxAbout.TabIndex = 2
        Me.grpBoxAbout.TabStop = false
        Me.grpBoxAbout.Text = "About"
        Me.ToolTip.SetToolTip(Me.grpBoxAbout, "Information about this program")
        '
        'btnDebug
        '
        Me.btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnDebug.AutoSize = true
        Me.btnDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDebug.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDebug.Location = New System.Drawing.Point(577, 13)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(25, 23)
        Me.btnDebug.TabIndex = 6
        Me.btnDebug.Text = "&D"
        Me.ToolTip.SetToolTip(Me.btnDebug, "Show Debug screens")
        Me.btnDebug.UseVisualStyleBackColor = true
        '
        'lnkDeveloper
        '
        Me.lnkDeveloper.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnkDeveloper.AutoSize = true
        Me.lnkDeveloper.BackColor = System.Drawing.Color.Transparent
        Me.lnkDeveloper.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lnkDeveloper.LinkColor = System.Drawing.Color.Silver
        Me.lnkDeveloper.Location = New System.Drawing.Point(336, 20)
        Me.lnkDeveloper.Name = "lnkDeveloper"
        Me.lnkDeveloper.Size = New System.Drawing.Size(121, 13)
        Me.lnkDeveloper.TabIndex = 4
        Me.lnkDeveloper.TabStop = true
        Me.lnkDeveloper.Text = "Developed by Walkman"
        Me.ToolTip.SetToolTip(Me.lnkDeveloper, "Developer's Info")
        Me.lnkDeveloper.VisitedLinkColor = System.Drawing.Color.Gray
        '
        'lnkReleases
        '
        Me.lnkReleases.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnkReleases.AutoSize = true
        Me.lnkReleases.BackColor = System.Drawing.Color.Transparent
        Me.lnkReleases.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lnkReleases.Location = New System.Drawing.Point(252, 20)
        Me.lnkReleases.Name = "lnkReleases"
        Me.lnkReleases.Size = New System.Drawing.Size(78, 13)
        Me.lnkReleases.TabIndex = 3
        Me.lnkReleases.TabStop = true
        Me.lnkReleases.Text = "Latest Release"
        Me.ToolTip.SetToolTip(Me.lnkReleases, "Releases for YTVL")
        '
        'lnkReportProblem
        '
        Me.lnkReportProblem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnkReportProblem.AutoSize = true
        Me.lnkReportProblem.BackColor = System.Drawing.Color.Transparent
        Me.lnkReportProblem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lnkReportProblem.Location = New System.Drawing.Point(158, 20)
        Me.lnkReportProblem.Name = "lnkReportProblem"
        Me.lnkReportProblem.Size = New System.Drawing.Size(88, 13)
        Me.lnkReportProblem.TabIndex = 2
        Me.lnkReportProblem.TabStop = true
        Me.lnkReportProblem.Text = "Report a problem"
        Me.ToolTip.SetToolTip(Me.lnkReportProblem, "Report a problem/send feedback")
        '
        'lnkSourceCode
        '
        Me.lnkSourceCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnkSourceCode.AutoSize = true
        Me.lnkSourceCode.BackColor = System.Drawing.Color.Transparent
        Me.lnkSourceCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lnkSourceCode.Location = New System.Drawing.Point(83, 20)
        Me.lnkSourceCode.Name = "lnkSourceCode"
        Me.lnkSourceCode.Size = New System.Drawing.Size(69, 13)
        Me.lnkSourceCode.TabIndex = 1
        Me.lnkSourceCode.TabStop = true
        Me.lnkSourceCode.Text = "Source Code"
        Me.ToolTip.SetToolTip(Me.lnkSourceCode, "View GitHub repo with source code")
        '
        'lnkOriginalPage
        '
        Me.lnkOriginalPage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnkOriginalPage.AutoSize = true
        Me.lnkOriginalPage.BackColor = System.Drawing.Color.Transparent
        Me.lnkOriginalPage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lnkOriginalPage.Location = New System.Drawing.Point(7, 20)
        Me.lnkOriginalPage.Name = "lnkOriginalPage"
        Me.lnkOriginalPage.Size = New System.Drawing.Size(70, 13)
        Me.lnkOriginalPage.TabIndex = 0
        Me.lnkOriginalPage.TabStop = true
        Me.lnkOriginalPage.Text = "Original Page"
        Me.ToolTip.SetToolTip(Me.lnkOriginalPage, "Page this program is based off")
        '
        'lblCurrentVersion
        '
        Me.lblCurrentVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCurrentVersion.AutoSize = true
        Me.lblCurrentVersion.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurrentVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.lblCurrentVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCurrentVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCurrentVersion.Location = New System.Drawing.Point(316, 202)
        Me.lblCurrentVersion.Name = "lblCurrentVersion"
        Me.lblCurrentVersion.Size = New System.Drawing.Size(52, 12)
        Me.lblCurrentVersion.TabIndex = 3
        Me.lblCurrentVersion.Text = "Current: v1"
        '
        'NotificationIcon
        '
        Me.NotificationIcon.ContextMenuStrip = Me.NotificationMenuStrip
        Me.NotificationIcon.Icon = CType(resources.GetObject("NotificationIcon.Icon"),System.Drawing.Icon)
        Me.NotificationIcon.Text = "YouTube Video Linker"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'NotificationMenuStrip
        '
        Me.NotificationMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotificationMenuStripShowYTVL, Me.NotificationMenuStripKeepOnTop, Me.NotificationMenuStripSeparator1, Me.NotificationMenuStripVideo, Me.NotificationMenuStripComments, Me.NotificationMenuStripVideoInfo, Me.NotificationMenuStripEmbed, Me.NotificationMenuStripSeparator2, Me.NotificationMenuStripHideIcon, Me.NotificationMenuStripClose})
        Me.NotificationMenuStrip.Name = "NotificationMenuStrip"
        Me.NotificationMenuStrip.Size = New System.Drawing.Size(173, 192)
        Me.NotificationMenuStrip.Text = "YTVL Context Menu"
        '
        'NotificationMenuStripShowYTVL
        '
        Me.NotificationMenuStripShowYTVL.AutoToolTip = true
        Me.NotificationMenuStripShowYTVL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NotificationMenuStripShowYTVL.Image = Global.YTVL.My.Resources.Resources._1387147104_video_display
        Me.NotificationMenuStripShowYTVL.Name = "NotificationMenuStripShowYTVL"
        Me.NotificationMenuStripShowYTVL.Size = New System.Drawing.Size(172, 22)
        Me.NotificationMenuStripShowYTVL.Text = "&Show YTVL"
        Me.NotificationMenuStripShowYTVL.ToolTipText = "Bring YTVL to the front"
        '
        'NotificationMenuStripKeepOnTop
        '
        Me.NotificationMenuStripKeepOnTop.CheckOnClick = true
        Me.NotificationMenuStripKeepOnTop.Name = "NotificationMenuStripKeepOnTop"
        Me.NotificationMenuStripKeepOnTop.Size = New System.Drawing.Size(172, 22)
        Me.NotificationMenuStripKeepOnTop.Text = "Keep YTVL on top"
        Me.NotificationMenuStripKeepOnTop.ToolTipText = "Keep YTVL on top of all other windows"
        '
        'NotificationMenuStripSeparator1
        '
        Me.NotificationMenuStripSeparator1.Name = "NotificationMenuStripSeparator1"
        Me.NotificationMenuStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'NotificationMenuStripVideo
        '
        Me.NotificationMenuStripVideo.AutoToolTip = true
        Me.NotificationMenuStripVideo.Image = Global.YTVL.My.Resources.Resources.android_app_20x14
        Me.NotificationMenuStripVideo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NotificationMenuStripVideo.Name = "NotificationMenuStripVideo"
        Me.NotificationMenuStripVideo.Size = New System.Drawing.Size(172, 22)
        Me.NotificationMenuStripVideo.Text = "» &Video"
        Me.NotificationMenuStripVideo.ToolTipText = "Open the standard video page"
        '
        'NotificationMenuStripComments
        '
        Me.NotificationMenuStripComments.Image = Global.YTVL.My.Resources.Resources.facebook_messages
        Me.NotificationMenuStripComments.Name = "NotificationMenuStripComments"
        Me.NotificationMenuStripComments.Size = New System.Drawing.Size(172, 22)
        Me.NotificationMenuStripComments.Text = "» &Comments"
        Me.NotificationMenuStripComments.ToolTipText = "Show a page with just the comments for the specified video"
        '
        'NotificationMenuStripVideoInfo
        '
        Me.NotificationMenuStripVideoInfo.Image = Global.YTVL.My.Resources.Resources.documentinfo
        Me.NotificationMenuStripVideoInfo.Name = "NotificationMenuStripVideoInfo"
        Me.NotificationMenuStripVideoInfo.Size = New System.Drawing.Size(172, 22)
        Me.NotificationMenuStripVideoInfo.Text = "» Video &Info"
        Me.NotificationMenuStripVideoInfo.ToolTipText = "Download the Video Info file for  the chosen video"
        '
        'NotificationMenuStripEmbed
        '
        Me.NotificationMenuStripEmbed.Image = Global.YTVL.My.Resources.Resources._1387139872_window_new
        Me.NotificationMenuStripEmbed.Name = "NotificationMenuStripEmbed"
        Me.NotificationMenuStripEmbed.Size = New System.Drawing.Size(172, 22)
        Me.NotificationMenuStripEmbed.Text = "» &Embedded"
        Me.NotificationMenuStripEmbed.ToolTipText = "Open a page with just the Embedded video"
        '
        'NotificationMenuStripSeparator2
        '
        Me.NotificationMenuStripSeparator2.Name = "NotificationMenuStripSeparator2"
        Me.NotificationMenuStripSeparator2.Size = New System.Drawing.Size(169, 6)
        '
        'NotificationMenuStripHideIcon
        '
        Me.NotificationMenuStripHideIcon.Image = Global.YTVL.My.Resources.Resources.Exit2
        Me.NotificationMenuStripHideIcon.Name = "NotificationMenuStripHideIcon"
        Me.NotificationMenuStripHideIcon.Size = New System.Drawing.Size(172, 22)
        Me.NotificationMenuStripHideIcon.Text = "&Hide Icon"
        Me.NotificationMenuStripHideIcon.ToolTipText = "Hide the taskbar icon"
        '
        'NotificationMenuStripClose
        '
        Me.NotificationMenuStripClose.Image = Global.YTVL.My.Resources.Resources._1387140136_process_stop
        Me.NotificationMenuStripClose.Name = "NotificationMenuStripClose"
        Me.NotificationMenuStripClose.Size = New System.Drawing.Size(172, 22)
        Me.NotificationMenuStripClose.Text = "Cl&ose"
        Me.NotificationMenuStripClose.ToolTipText = "Quit YTVL"
        '
        'chkUpdate
        '
        Me.chkUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkUpdate.AutoSize = true
        Me.chkUpdate.BackColor = System.Drawing.Color.Transparent
        Me.chkUpdate.Checked = true
        Me.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkUpdate.Location = New System.Drawing.Point(132, 201)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(177, 17)
        Me.chkUpdate.TabIndex = 4
        Me.chkUpdate.Text = "Check for &updates automatically"
        Me.ToolTip.SetToolTip(Me.chkUpdate, "Automatically check for updates on startup")
        Me.chkUpdate.UseVisualStyleBackColor = false
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 800
        Me.ToolTip.ReshowDelay = 600
        '
        'openFileDialogBrowser
        '
        Me.openFileDialogBrowser.DefaultExt = "exe"
        Me.openFileDialogBrowser.Filter = "Browsers (*.exe)|*.exe|All Files (*.*)|*.*"
        Me.openFileDialogBrowser.InitialDirectory = "%ProgramFiles%"
        Me.openFileDialogBrowser.ReadOnlyChecked = true
        Me.openFileDialogBrowser.ShowHelp = true
        Me.openFileDialogBrowser.ShowReadOnly = true
        Me.openFileDialogBrowser.Title = "Select Browser to open link in"
        '
        'YTVL
        '
        Me.AcceptButton = Me.btnVideo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(490, 222)
        Me.Controls.Add(Me.chkKeepOnTop)
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.lblCurrentVersion)
        Me.Controls.Add(Me.grpBoxAbout)
        Me.Controls.Add(Me.grpBoxOutputs)
        Me.Controls.Add(Me.grpBoxInputs)
        Me.HelpButton = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "YTVL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube Video Linker"
        Me.grpBoxInputs.ResumeLayout(false)
        Me.grpBoxInputs.PerformLayout
        CType(Me.imgLoading,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlRight1.ResumeLayout(false)
        Me.pnlRight1.PerformLayout
        Me.pnlRight2.ResumeLayout(false)
        Me.pnlRight2.PerformLayout
        Me.pnlRight3.ResumeLayout(false)
        Me.pnlRight3.PerformLayout
        Me.pnlRight4.ResumeLayout(false)
        Me.pnlRight4.PerformLayout
        Me.pnlEnableJsApi.ResumeLayout(false)
        Me.pnlEnableJsApi.PerformLayout
        Me.pnlAutoplay.ResumeLayout(false)
        Me.pnlAutoplay.PerformLayout
        Me.pnlAutohide.ResumeLayout(false)
        Me.pnlAutohide.PerformLayout
        Me.pnlFs.ResumeLayout(false)
        Me.pnlFs.PerformLayout
        Me.pnlQuality.ResumeLayout(false)
        Me.pnlQuality.PerformLayout
        Me.ContextClipboard.ResumeLayout(false)
        Me.grpBoxOutputs.ResumeLayout(false)
        Me.grpBoxOutputs.PerformLayout
        Me.ContextDownload.ResumeLayout(false)
        Me.grpBoxAbout.ResumeLayout(false)
        Me.grpBoxAbout.PerformLayout
        Me.NotificationMenuStrip.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents ContextDownloadCopyFromGenerated As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnThumbnail As System.Windows.Forms.Button
    Friend WithEvents ContextDownloadKeepVid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextDownloadFullripMP3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextDownloadFullripVideoAlternate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextDownloadFullripVideo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextDownload As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnDeturl As System.Windows.Forms.Button
    Friend WithEvents openFileDialogBrowser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtComboBrowser As System.Windows.Forms.ComboBox
    Friend WithEvents lblBrowser As System.Windows.Forms.Label
    Friend WithEvents chkRememberBrowser As System.Windows.Forms.CheckBox
    Friend WithEvents grpBoxInputs As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxOutputs As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxAbout As System.Windows.Forms.GroupBox
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
    Friend WithEvents lnkDeveloper As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAdvanced As System.Windows.Forms.Button
    Friend WithEvents lblCurrentVersion As System.Windows.Forms.Label
    Friend WithEvents NotificationIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotificationMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NotificationMenuStripShowYTVL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationMenuStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NotificationMenuStripVideo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationMenuStripComments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationMenuStripVideoInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationMenuStripEmbed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationMenuStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NotificationMenuStripClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkShowNotification As System.Windows.Forms.CheckBox
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents NotificationMenuStripHideIcon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents WebBrowserVersionCheck As System.Windows.Forms.WebBrowser
    Friend WithEvents chkFeature As System.Windows.Forms.CheckBox
    Friend WithEvents optQuality720 As System.Windows.Forms.RadioButton
    Friend WithEvents optQuality360 As System.Windows.Forms.RadioButton
    Friend WithEvents optEnableJsApi1 As System.Windows.Forms.RadioButton
    Friend WithEvents optEnableJsApi0 As System.Windows.Forms.RadioButton
    Friend WithEvents lblEnableJsApi As System.Windows.Forms.Label
    Friend WithEvents optAutohide1 As System.Windows.Forms.RadioButton
    Friend WithEvents optAutohide0 As System.Windows.Forms.RadioButton
    Friend WithEvents lblAutohide As System.Windows.Forms.Label
    Friend WithEvents optFs1 As System.Windows.Forms.RadioButton
    Friend WithEvents optFs0 As System.Windows.Forms.RadioButton
    Friend WithEvents lblFs As System.Windows.Forms.Label
    Friend WithEvents optAutoplay1 As System.Windows.Forms.RadioButton
    Friend WithEvents optAutoplay0 As System.Windows.Forms.RadioButton
    Friend WithEvents lblAutoplay As System.Windows.Forms.Label
    Friend WithEvents optIvLP As System.Windows.Forms.ComboBox
    Friend WithEvents lblIvLP As System.Windows.Forms.Label
    Friend WithEvents optMdstBrndng1 As System.Windows.Forms.RadioButton
    Friend WithEvents optMdstBrndng0 As System.Windows.Forms.RadioButton
    Friend WithEvents lblMdstBrndng As System.Windows.Forms.Label
    Friend WithEvents optShowsearch1 As System.Windows.Forms.RadioButton
    Friend WithEvents optShowsearch0 As System.Windows.Forms.RadioButton
    Friend WithEvents lblShowSearch As System.Windows.Forms.Label
    Friend WithEvents optShowinfo1 As System.Windows.Forms.RadioButton
    Friend WithEvents optShowinfo0 As System.Windows.Forms.RadioButton
    Friend WithEvents lblShowinfo As System.Windows.Forms.Label
    Friend WithEvents optRel1 As System.Windows.Forms.RadioButton
    Friend WithEvents optRel0 As System.Windows.Forms.RadioButton
    Friend WithEvents lblRel As System.Windows.Forms.Label
    Friend WithEvents txtOrigin As System.Windows.Forms.TextBox
    Friend WithEvents chkOrigin As System.Windows.Forms.CheckBox
    Friend WithEvents chkWmode As System.Windows.Forms.CheckBox
    Friend WithEvents chkThemeDark As System.Windows.Forms.CheckBox
    Friend WithEvents chkHttps As System.Windows.Forms.CheckBox
    Friend WithEvents pnlQuality As System.Windows.Forms.Panel
    Friend WithEvents pnlEnableJsApi As System.Windows.Forms.Panel
    Friend WithEvents pnlAutoplay As System.Windows.Forms.Panel
    Friend WithEvents pnlAutohide As System.Windows.Forms.Panel
    Friend WithEvents pnlFs As System.Windows.Forms.Panel
    Friend WithEvents pnlRight1 As System.Windows.Forms.Panel
    Friend WithEvents pnlRight2 As System.Windows.Forms.Panel
    Friend WithEvents pnlRight3 As System.Windows.Forms.Panel
    Friend WithEvents pnlRight4 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents NotificationMenuStripKeepOnTop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkKeepOnTop As System.Windows.Forms.CheckBox
    Friend WithEvents ContextClipboard As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextClipboardCopyFromGenerated As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextClipboardCopyCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextClipboardCopyCodeHTML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextClipboardCopyCodeBB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextClipboardCopyCodeSeperator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextClipboardCopyCodeStandard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextClipboardCopyCodeOldCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowserVideoLoad As System.Windows.Forms.WebBrowser
    Friend WithEvents lblVideoTitle As System.Windows.Forms.Label
    Friend WithEvents imgLoading As System.Windows.Forms.PictureBox

End Class
