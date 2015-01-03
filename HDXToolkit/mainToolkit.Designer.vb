<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainToolkit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainToolkit))
        Me.rootBtn = New System.Windows.Forms.Button()
        Me.disableOtaBtn = New System.Windows.Forms.Button()
        Me.otaGroupBox = New System.Windows.Forms.GroupBox()
        Me.enableOtaBtn = New System.Windows.Forms.Button()
        Me.superSuBtn = New System.Windows.Forms.Button()
        Me.safestrapBtn = New System.Windows.Forms.Button()
        Me.installersGroupBox = New System.Windows.Forms.GroupBox()
        Me.playStoreBtn = New System.Windows.Forms.Button()
        Me.hdxposedBtn = New System.Windows.Forms.Button()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.fileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.xdaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rootGroupBox = New System.Windows.Forms.GroupBox()
        Me.rootMethodLabel = New System.Windows.Forms.Label()
        Me.deviceGroupBox = New System.Windows.Forms.GroupBox()
        Me.codenameLabel = New System.Windows.Forms.Label()
        Me.firmwareLabel = New System.Windows.Forms.Label()
        Me.modelLabel = New System.Windows.Forms.Label()
        Me.adsGroupBox = New System.Windows.Forms.GroupBox()
        Me.enableAdsBtn = New System.Windows.Forms.Button()
        Me.disableAdsBtn = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.moreGroupBox = New System.Windows.Forms.GroupBox()
        Me.advancedUtilsBtn = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.PictureBox()
        Me.amazonLogo = New System.Windows.Forms.PictureBox()
        Me.otaGroupBox.SuspendLayout()
        Me.installersGroupBox.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.rootGroupBox.SuspendLayout()
        Me.deviceGroupBox.SuspendLayout()
        Me.adsGroupBox.SuspendLayout()
        Me.moreGroupBox.SuspendLayout()
        CType(Me.header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amazonLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rootBtn
        '
        Me.rootBtn.Location = New System.Drawing.Point(20, 25)
        Me.rootBtn.Name = "rootBtn"
        Me.rootBtn.Size = New System.Drawing.Size(165, 30)
        Me.rootBtn.TabIndex = 0
        Me.rootBtn.Text = "Root device"
        Me.rootBtn.UseVisualStyleBackColor = True
        '
        'disableOtaBtn
        '
        Me.disableOtaBtn.Location = New System.Drawing.Point(20, 25)
        Me.disableOtaBtn.Name = "disableOtaBtn"
        Me.disableOtaBtn.Size = New System.Drawing.Size(110, 30)
        Me.disableOtaBtn.TabIndex = 1
        Me.disableOtaBtn.Text = "Disable"
        Me.disableOtaBtn.UseVisualStyleBackColor = True
        '
        'otaGroupBox
        '
        Me.otaGroupBox.Controls.Add(Me.enableOtaBtn)
        Me.otaGroupBox.Controls.Add(Me.disableOtaBtn)
        Me.otaGroupBox.Location = New System.Drawing.Point(20, 268)
        Me.otaGroupBox.Name = "otaGroupBox"
        Me.otaGroupBox.Size = New System.Drawing.Size(150, 115)
        Me.otaGroupBox.TabIndex = 2
        Me.otaGroupBox.TabStop = False
        Me.otaGroupBox.Text = "OTA updates"
        '
        'enableOtaBtn
        '
        Me.enableOtaBtn.Location = New System.Drawing.Point(20, 65)
        Me.enableOtaBtn.Name = "enableOtaBtn"
        Me.enableOtaBtn.Size = New System.Drawing.Size(110, 30)
        Me.enableOtaBtn.TabIndex = 2
        Me.enableOtaBtn.Text = "Enable"
        Me.enableOtaBtn.UseVisualStyleBackColor = True
        '
        'superSuBtn
        '
        Me.superSuBtn.Location = New System.Drawing.Point(20, 85)
        Me.superSuBtn.Name = "superSuBtn"
        Me.superSuBtn.Size = New System.Drawing.Size(165, 30)
        Me.superSuBtn.TabIndex = 3
        Me.superSuBtn.Text = "Install SuperSU"
        Me.superSuBtn.UseVisualStyleBackColor = True
        '
        'safestrapBtn
        '
        Me.safestrapBtn.Location = New System.Drawing.Point(20, 25)
        Me.safestrapBtn.Name = "safestrapBtn"
        Me.safestrapBtn.Size = New System.Drawing.Size(165, 30)
        Me.safestrapBtn.TabIndex = 4
        Me.safestrapBtn.Text = "Safestrap"
        Me.toolTip.SetToolTip(Me.safestrapBtn, "Installs custom recovery.")
        Me.safestrapBtn.UseVisualStyleBackColor = True
        '
        'installersGroupBox
        '
        Me.installersGroupBox.Controls.Add(Me.playStoreBtn)
        Me.installersGroupBox.Controls.Add(Me.hdxposedBtn)
        Me.installersGroupBox.Controls.Add(Me.safestrapBtn)
        Me.installersGroupBox.Location = New System.Drawing.Point(193, 308)
        Me.installersGroupBox.Name = "installersGroupBox"
        Me.installersGroupBox.Size = New System.Drawing.Size(205, 155)
        Me.installersGroupBox.TabIndex = 5
        Me.installersGroupBox.TabStop = False
        Me.installersGroupBox.Text = "Installers"
        '
        'playStoreBtn
        '
        Me.playStoreBtn.Location = New System.Drawing.Point(20, 105)
        Me.playStoreBtn.Name = "playStoreBtn"
        Me.playStoreBtn.Size = New System.Drawing.Size(165, 30)
        Me.playStoreBtn.TabIndex = 6
        Me.playStoreBtn.Text = "Play Store"
        Me.toolTip.SetToolTip(Me.playStoreBtn, "Installs the core Google apps package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Account Manager" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Play services" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Pla" & _
        "y Store" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Services Framework")
        Me.playStoreBtn.UseVisualStyleBackColor = True
        '
        'hdxposedBtn
        '
        Me.hdxposedBtn.Location = New System.Drawing.Point(20, 65)
        Me.hdxposedBtn.Name = "hdxposedBtn"
        Me.hdxposedBtn.Size = New System.Drawing.Size(165, 30)
        Me.hdxposedBtn.TabIndex = 5
        Me.hdxposedBtn.Text = "HDXPosed"
        Me.toolTip.SetToolTip(Me.hdxposedBtn, resources.GetString("hdxposedBtn.ToolTip"))
        Me.hdxposedBtn.UseVisualStyleBackColor = True
        '
        'menuStrip
        '
        Me.menuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMenu, Me.helpMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(419, 24)
        Me.menuStrip.TabIndex = 6
        '
        'fileMenu
        '
        Me.fileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.optionsMenuItem})
        Me.fileMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fileMenu.Name = "fileMenu"
        Me.fileMenu.Size = New System.Drawing.Size(37, 20)
        Me.fileMenu.Text = "File"
        '
        'optionsMenuItem
        '
        Me.optionsMenuItem.Name = "optionsMenuItem"
        Me.optionsMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.optionsMenuItem.Text = "Options..."
        '
        'helpMenu
        '
        Me.helpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xdaMenuItem, Me.aboutMenuItem})
        Me.helpMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.helpMenu.Name = "helpMenu"
        Me.helpMenu.Size = New System.Drawing.Size(44, 20)
        Me.helpMenu.Text = "Help"
        '
        'xdaMenuItem
        '
        Me.xdaMenuItem.Name = "xdaMenuItem"
        Me.xdaMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.xdaMenuItem.Text = "XDA thread"
        '
        'aboutMenuItem
        '
        Me.aboutMenuItem.Name = "aboutMenuItem"
        Me.aboutMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.aboutMenuItem.Text = "About/credits"
        '
        'rootGroupBox
        '
        Me.rootGroupBox.Controls.Add(Me.rootMethodLabel)
        Me.rootGroupBox.Controls.Add(Me.superSuBtn)
        Me.rootGroupBox.Controls.Add(Me.rootBtn)
        Me.rootGroupBox.Location = New System.Drawing.Point(193, 152)
        Me.rootGroupBox.Name = "rootGroupBox"
        Me.rootGroupBox.Size = New System.Drawing.Size(205, 135)
        Me.rootGroupBox.TabIndex = 7
        Me.rootGroupBox.TabStop = False
        Me.rootGroupBox.Text = "Root"
        '
        'rootMethodLabel
        '
        Me.rootMethodLabel.AutoSize = True
        Me.rootMethodLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rootMethodLabel.Location = New System.Drawing.Point(50, 58)
        Me.rootMethodLabel.Name = "rootMethodLabel"
        Me.rootMethodLabel.Size = New System.Drawing.Size(0, 15)
        Me.rootMethodLabel.TabIndex = 4
        '
        'deviceGroupBox
        '
        Me.deviceGroupBox.Controls.Add(Me.codenameLabel)
        Me.deviceGroupBox.Controls.Add(Me.firmwareLabel)
        Me.deviceGroupBox.Controls.Add(Me.modelLabel)
        Me.deviceGroupBox.Location = New System.Drawing.Point(20, 152)
        Me.deviceGroupBox.Name = "deviceGroupBox"
        Me.deviceGroupBox.Size = New System.Drawing.Size(149, 99)
        Me.deviceGroupBox.TabIndex = 8
        Me.deviceGroupBox.TabStop = False
        Me.deviceGroupBox.Text = "Your model"
        '
        'codenameLabel
        '
        Me.codenameLabel.AutoSize = True
        Me.codenameLabel.Location = New System.Drawing.Point(16, 26)
        Me.codenameLabel.Name = "codenameLabel"
        Me.codenameLabel.Size = New System.Drawing.Size(0, 13)
        Me.codenameLabel.TabIndex = 10
        '
        'firmwareLabel
        '
        Me.firmwareLabel.AutoSize = True
        Me.firmwareLabel.Location = New System.Drawing.Point(16, 69)
        Me.firmwareLabel.Name = "firmwareLabel"
        Me.firmwareLabel.Size = New System.Drawing.Size(0, 13)
        Me.firmwareLabel.TabIndex = 9
        '
        'modelLabel
        '
        Me.modelLabel.AutoSize = True
        Me.modelLabel.Location = New System.Drawing.Point(16, 47)
        Me.modelLabel.Name = "modelLabel"
        Me.modelLabel.Size = New System.Drawing.Size(0, 13)
        Me.modelLabel.TabIndex = 9
        '
        'adsGroupBox
        '
        Me.adsGroupBox.Controls.Add(Me.enableAdsBtn)
        Me.adsGroupBox.Controls.Add(Me.disableAdsBtn)
        Me.adsGroupBox.Location = New System.Drawing.Point(20, 400)
        Me.adsGroupBox.Name = "adsGroupBox"
        Me.adsGroupBox.Size = New System.Drawing.Size(150, 115)
        Me.adsGroupBox.TabIndex = 10
        Me.adsGroupBox.TabStop = False
        Me.adsGroupBox.Text = "Lockscreen ads"
        '
        'enableAdsBtn
        '
        Me.enableAdsBtn.Location = New System.Drawing.Point(20, 65)
        Me.enableAdsBtn.Name = "enableAdsBtn"
        Me.enableAdsBtn.Size = New System.Drawing.Size(110, 30)
        Me.enableAdsBtn.TabIndex = 4
        Me.enableAdsBtn.Text = "Enable"
        Me.enableAdsBtn.UseVisualStyleBackColor = True
        '
        'disableAdsBtn
        '
        Me.disableAdsBtn.Location = New System.Drawing.Point(20, 25)
        Me.disableAdsBtn.Name = "disableAdsBtn"
        Me.disableAdsBtn.Size = New System.Drawing.Size(110, 30)
        Me.disableAdsBtn.TabIndex = 3
        Me.disableAdsBtn.Text = "Disable"
        Me.disableAdsBtn.UseVisualStyleBackColor = True
        '
        'moreGroupBox
        '
        Me.moreGroupBox.Controls.Add(Me.advancedUtilsBtn)
        Me.moreGroupBox.Location = New System.Drawing.Point(193, 483)
        Me.moreGroupBox.Name = "moreGroupBox"
        Me.moreGroupBox.Size = New System.Drawing.Size(205, 75)
        Me.moreGroupBox.TabIndex = 11
        Me.moreGroupBox.TabStop = False
        Me.moreGroupBox.Text = "More"
        '
        'advancedUtilsBtn
        '
        Me.advancedUtilsBtn.Enabled = False
        Me.advancedUtilsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advancedUtilsBtn.Location = New System.Drawing.Point(20, 25)
        Me.advancedUtilsBtn.Name = "advancedUtilsBtn"
        Me.advancedUtilsBtn.Size = New System.Drawing.Size(165, 30)
        Me.advancedUtilsBtn.TabIndex = 0
        Me.advancedUtilsBtn.Text = "Launch advanced utilities"
        Me.advancedUtilsBtn.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.header.Image = Global.HDXToolkit.My.Resources.Resources.header
        Me.header.Location = New System.Drawing.Point(0, 24)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(419, 103)
        Me.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.header.TabIndex = 12
        Me.header.TabStop = False
        '
        'amazonLogo
        '
        Me.amazonLogo.Location = New System.Drawing.Point(20, 31)
        Me.amazonLogo.Name = "amazonLogo"
        Me.amazonLogo.Size = New System.Drawing.Size(378, 60)
        Me.amazonLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.amazonLogo.TabIndex = 9
        Me.amazonLogo.TabStop = False
        '
        'mainToolkit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 578)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.moreGroupBox)
        Me.Controls.Add(Me.adsGroupBox)
        Me.Controls.Add(Me.amazonLogo)
        Me.Controls.Add(Me.deviceGroupBox)
        Me.Controls.Add(Me.rootGroupBox)
        Me.Controls.Add(Me.installersGroupBox)
        Me.Controls.Add(Me.otaGroupBox)
        Me.Controls.Add(Me.menuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "mainToolkit"
        Me.Text = "HDX Toolkit (1.2.1 beta)"
        Me.otaGroupBox.ResumeLayout(False)
        Me.installersGroupBox.ResumeLayout(False)
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.rootGroupBox.ResumeLayout(False)
        Me.rootGroupBox.PerformLayout()
        Me.deviceGroupBox.ResumeLayout(False)
        Me.deviceGroupBox.PerformLayout()
        Me.adsGroupBox.ResumeLayout(False)
        Me.moreGroupBox.ResumeLayout(False)
        CType(Me.header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amazonLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rootBtn As System.Windows.Forms.Button
    Friend WithEvents disableOtaBtn As System.Windows.Forms.Button
    Friend WithEvents otaGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents enableOtaBtn As System.Windows.Forms.Button
    Friend WithEvents superSuBtn As System.Windows.Forms.Button
    Friend WithEvents safestrapBtn As System.Windows.Forms.Button
    Friend WithEvents installersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents rootGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents hdxposedBtn As System.Windows.Forms.Button
    Friend WithEvents deviceGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents firmwareLabel As System.Windows.Forms.Label
    Friend WithEvents modelLabel As System.Windows.Forms.Label
    Friend WithEvents playStoreBtn As System.Windows.Forms.Button
    Friend WithEvents rootMethodLabel As System.Windows.Forms.Label
    Friend WithEvents codenameLabel As System.Windows.Forms.Label
    Friend WithEvents amazonLogo As System.Windows.Forms.PictureBox
    Friend WithEvents adsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents enableAdsBtn As System.Windows.Forms.Button
    Friend WithEvents disableAdsBtn As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents moreGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents advancedUtilsBtn As System.Windows.Forms.Button
    Friend WithEvents header As System.Windows.Forms.PictureBox
    Friend WithEvents fileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optionsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xdaMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aboutMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
