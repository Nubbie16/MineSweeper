<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvatarSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvatarSelection))
        formLayout = New TableLayoutPanel()
        topLayout = New TableLayoutPanel()
        titlePic1 = New PictureBox()
        titleLbl = New Label()
        titlePic2 = New PictureBox()
        bottomLayout = New TableLayoutPanel()
        nameLbl = New Label()
        playerText = New TextBox()
        gameStartBtn = New Button()
        Panel1 = New Panel()
        bodyLayout = New TableLayoutPanel()
        femaleBrownRad = New RadioButton()
        femaleRedRad = New RadioButton()
        femaleBlondeRad = New RadioButton()
        maleBrownRad = New RadioButton()
        maleRedRad = New RadioButton()
        avatarTitleLbl = New Label()
        maleBlondeRad = New RadioButton()
        formLayout.SuspendLayout()
        topLayout.SuspendLayout()
        CType(titlePic1, ComponentModel.ISupportInitialize).BeginInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).BeginInit()
        bottomLayout.SuspendLayout()
        Panel1.SuspendLayout()
        bodyLayout.SuspendLayout()
        SuspendLayout()
        ' 
        ' formLayout
        ' 
        formLayout.ColumnCount = 1
        formLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        formLayout.Controls.Add(topLayout, 0, 0)
        formLayout.Controls.Add(bottomLayout, 0, 2)
        formLayout.Controls.Add(Panel1, 0, 1)
        formLayout.Dock = DockStyle.Fill
        formLayout.Location = New Point(0, 0)
        formLayout.Name = "formLayout"
        formLayout.RowCount = 3
        formLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 27.2264633F))
        formLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 72.77354F))
        formLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 56F))
        formLayout.Size = New Size(436, 456)
        formLayout.TabIndex = 6
        ' 
        ' topLayout
        ' 
        topLayout.ColumnCount = 3
        topLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        topLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        topLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        topLayout.Controls.Add(titlePic1, 0, 0)
        topLayout.Controls.Add(titleLbl, 1, 0)
        topLayout.Controls.Add(titlePic2, 2, 0)
        topLayout.Dock = DockStyle.Top
        topLayout.Location = New Point(3, 3)
        topLayout.Name = "topLayout"
        topLayout.RowCount = 1
        topLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        topLayout.Size = New Size(430, 100)
        topLayout.TabIndex = 3
        ' 
        ' titlePic1
        ' 
        titlePic1.BackColor = Color.Transparent
        titlePic1.Dock = DockStyle.Fill
        titlePic1.Image = My.Resources.Resources.Flag
        titlePic1.Location = New Point(3, 3)
        titlePic1.Name = "titlePic1"
        titlePic1.Size = New Size(123, 94)
        titlePic1.SizeMode = PictureBoxSizeMode.Zoom
        titlePic1.TabIndex = 1
        titlePic1.TabStop = False
        ' 
        ' titleLbl
        ' 
        titleLbl.Dock = DockStyle.Fill
        titleLbl.Font = New Font("Gill Sans Ultra Bold", 19F, FontStyle.Italic)
        titleLbl.Location = New Point(132, 0)
        titleLbl.Name = "titleLbl"
        titleLbl.Size = New Size(166, 100)
        titleLbl.TabIndex = 0
        titleLbl.Text = "Mine Sweeper"
        titleLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' titlePic2
        ' 
        titlePic2.BackColor = Color.Transparent
        titlePic2.Dock = DockStyle.Fill
        titlePic2.Image = My.Resources.Resources.Detonated
        titlePic2.Location = New Point(304, 3)
        titlePic2.Name = "titlePic2"
        titlePic2.Size = New Size(123, 94)
        titlePic2.SizeMode = PictureBoxSizeMode.Zoom
        titlePic2.TabIndex = 2
        titlePic2.TabStop = False
        ' 
        ' bottomLayout
        ' 
        bottomLayout.ColumnCount = 3
        bottomLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        bottomLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        bottomLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        bottomLayout.Controls.Add(nameLbl, 0, 0)
        bottomLayout.Controls.Add(playerText, 1, 0)
        bottomLayout.Controls.Add(gameStartBtn, 2, 0)
        bottomLayout.Dock = DockStyle.Bottom
        bottomLayout.Location = New Point(3, 402)
        bottomLayout.Name = "bottomLayout"
        bottomLayout.RowCount = 1
        bottomLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        bottomLayout.Size = New Size(430, 51)
        bottomLayout.TabIndex = 4
        ' 
        ' nameLbl
        ' 
        nameLbl.Anchor = AnchorStyles.Right
        nameLbl.AutoSize = True
        nameLbl.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        nameLbl.Location = New Point(7, 15)
        nameLbl.Name = "nameLbl"
        nameLbl.Size = New Size(133, 20)
        nameLbl.TabIndex = 0
        nameLbl.Text = "Player Name:"
        ' 
        ' playerText
        ' 
        playerText.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        playerText.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        playerText.Location = New Point(146, 12)
        playerText.Name = "playerText"
        playerText.Size = New Size(137, 26)
        playerText.TabIndex = 1
        ' 
        ' gameStartBtn
        ' 
        gameStartBtn.Anchor = AnchorStyles.None
        gameStartBtn.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        gameStartBtn.Location = New Point(301, 11)
        gameStartBtn.Name = "gameStartBtn"
        gameStartBtn.Size = New Size(113, 28)
        gameStartBtn.TabIndex = 2
        gameStartBtn.Text = "Lets Play!"
        gameStartBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(bodyLayout)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 111)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(430, 285)
        Panel1.TabIndex = 5
        ' 
        ' bodyLayout
        ' 
        bodyLayout.ColumnCount = 3
        bodyLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        bodyLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        bodyLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        bodyLayout.Controls.Add(femaleBrownRad, 2, 2)
        bodyLayout.Controls.Add(femaleRedRad, 1, 2)
        bodyLayout.Controls.Add(femaleBlondeRad, 0, 2)
        bodyLayout.Controls.Add(maleBrownRad, 2, 1)
        bodyLayout.Controls.Add(maleRedRad, 1, 1)
        bodyLayout.Controls.Add(avatarTitleLbl, 0, 0)
        bodyLayout.Controls.Add(maleBlondeRad, 0, 1)
        bodyLayout.Dock = DockStyle.Fill
        bodyLayout.Location = New Point(0, 0)
        bodyLayout.Name = "bodyLayout"
        bodyLayout.RowCount = 3
        bodyLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2550917F))
        bodyLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 42.8724556F))
        bodyLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 42.8724556F))
        bodyLayout.Size = New Size(430, 285)
        bodyLayout.TabIndex = 0
        ' 
        ' femaleBrownRad
        ' 
        femaleBrownRad.Appearance = Appearance.Button
        femaleBrownRad.AutoSize = True
        femaleBrownRad.BackColor = SystemColors.Control
        femaleBrownRad.Dock = DockStyle.Fill
        femaleBrownRad.Image = My.Resources.Resources.FBrAva
        femaleBrownRad.Location = New Point(289, 165)
        femaleBrownRad.Name = "femaleBrownRad"
        femaleBrownRad.Size = New Size(138, 117)
        femaleBrownRad.TabIndex = 6
        femaleBrownRad.TabStop = True
        femaleBrownRad.UseVisualStyleBackColor = False
        ' 
        ' femaleRedRad
        ' 
        femaleRedRad.Appearance = Appearance.Button
        femaleRedRad.AutoSize = True
        femaleRedRad.BackColor = SystemColors.Control
        femaleRedRad.Dock = DockStyle.Fill
        femaleRedRad.Image = My.Resources.Resources.FRedAva
        femaleRedRad.Location = New Point(146, 165)
        femaleRedRad.Name = "femaleRedRad"
        femaleRedRad.Size = New Size(137, 117)
        femaleRedRad.TabIndex = 5
        femaleRedRad.TabStop = True
        femaleRedRad.UseVisualStyleBackColor = False
        ' 
        ' femaleBlondeRad
        ' 
        femaleBlondeRad.Appearance = Appearance.Button
        femaleBlondeRad.AutoSize = True
        femaleBlondeRad.BackColor = SystemColors.Control
        femaleBlondeRad.Dock = DockStyle.Fill
        femaleBlondeRad.Image = My.Resources.Resources.FBlAva
        femaleBlondeRad.Location = New Point(3, 165)
        femaleBlondeRad.Name = "femaleBlondeRad"
        femaleBlondeRad.Size = New Size(137, 117)
        femaleBlondeRad.TabIndex = 4
        femaleBlondeRad.TabStop = True
        femaleBlondeRad.UseVisualStyleBackColor = False
        ' 
        ' maleBrownRad
        ' 
        maleBrownRad.Appearance = Appearance.Button
        maleBrownRad.AutoSize = True
        maleBrownRad.BackColor = SystemColors.Control
        maleBrownRad.Dock = DockStyle.Fill
        maleBrownRad.Image = My.Resources.Resources.MBrAva
        maleBrownRad.Location = New Point(289, 43)
        maleBrownRad.Name = "maleBrownRad"
        maleBrownRad.Size = New Size(138, 116)
        maleBrownRad.TabIndex = 3
        maleBrownRad.TabStop = True
        maleBrownRad.UseVisualStyleBackColor = False
        ' 
        ' maleRedRad
        ' 
        maleRedRad.Appearance = Appearance.Button
        maleRedRad.AutoSize = True
        maleRedRad.BackColor = SystemColors.Control
        maleRedRad.Dock = DockStyle.Fill
        maleRedRad.Image = My.Resources.Resources.MRedAva
        maleRedRad.Location = New Point(146, 43)
        maleRedRad.Name = "maleRedRad"
        maleRedRad.Size = New Size(137, 116)
        maleRedRad.TabIndex = 2
        maleRedRad.TabStop = True
        maleRedRad.UseVisualStyleBackColor = False
        ' 
        ' avatarTitleLbl
        ' 
        avatarTitleLbl.AutoSize = True
        bodyLayout.SetColumnSpan(avatarTitleLbl, 3)
        avatarTitleLbl.Dock = DockStyle.Fill
        avatarTitleLbl.Font = New Font("Gill Sans Ultra Bold", 16F, FontStyle.Italic)
        avatarTitleLbl.Location = New Point(3, 0)
        avatarTitleLbl.Name = "avatarTitleLbl"
        avatarTitleLbl.Size = New Size(424, 40)
        avatarTitleLbl.TabIndex = 0
        avatarTitleLbl.Text = "Choose your Avatar"
        avatarTitleLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' maleBlondeRad
        ' 
        maleBlondeRad.Appearance = Appearance.Button
        maleBlondeRad.AutoSize = True
        maleBlondeRad.BackColor = SystemColors.Control
        maleBlondeRad.Dock = DockStyle.Fill
        maleBlondeRad.Image = CType(resources.GetObject("maleBlondeRad.Image"), Image)
        maleBlondeRad.Location = New Point(3, 43)
        maleBlondeRad.Name = "maleBlondeRad"
        maleBlondeRad.Size = New Size(137, 116)
        maleBlondeRad.TabIndex = 1
        maleBlondeRad.TabStop = True
        maleBlondeRad.UseVisualStyleBackColor = False
        ' 
        ' AvatarSelection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 456)
        Controls.Add(formLayout)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(452, 495)
        MinimumSize = New Size(452, 495)
        Name = "AvatarSelection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mine Sweeper"
        formLayout.ResumeLayout(False)
        topLayout.ResumeLayout(False)
        CType(titlePic1, ComponentModel.ISupportInitialize).EndInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).EndInit()
        bottomLayout.ResumeLayout(False)
        bottomLayout.PerformLayout()
        Panel1.ResumeLayout(False)
        bodyLayout.ResumeLayout(False)
        bodyLayout.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents formLayout As TableLayoutPanel
    Friend WithEvents topLayout As TableLayoutPanel
    Friend WithEvents titlePic1 As PictureBox
    Friend WithEvents titleLbl As Label
    Friend WithEvents titlePic2 As PictureBox
    Friend WithEvents bottomLayout As TableLayoutPanel
    Friend WithEvents nameLbl As Label
    Friend WithEvents playerText As TextBox
    Friend WithEvents gameStartBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bodyLayout As TableLayoutPanel
    Friend WithEvents avatarTitleLbl As Label
    Friend WithEvents maleBlondeRad As RadioButton
    Friend WithEvents femaleBrownRad As RadioButton
    Friend WithEvents femaleRedRad As RadioButton
    Friend WithEvents femaleBlondeRad As RadioButton
    Friend WithEvents maleBrownRad As RadioButton
    Friend WithEvents maleRedRad As RadioButton
End Class
