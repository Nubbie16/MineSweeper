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
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        titlePic1 = New PictureBox()
        titleLbl = New Label()
        titlePic2 = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        nameLbl = New Label()
        nameText = New TextBox()
        gameStartBtn = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        avatarSelectLbl = New Label()
        maleBlondeCKB = New CheckBox()
        maleRedCKB = New CheckBox()
        maleBrownCKB = New CheckBox()
        femaleBlondeCKB = New CheckBox()
        femaleRedCKB = New CheckBox()
        femaleBrownCKB = New CheckBox()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(titlePic1, ComponentModel.ISupportInitialize).BeginInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel2, 0, 2)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 28.2442741F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 71.75572F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 56F))
        TableLayoutPanel3.Size = New Size(436, 450)
        TableLayoutPanel3.TabIndex = 6
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel1.Controls.Add(titlePic1, 0, 0)
        TableLayoutPanel1.Controls.Add(titleLbl, 1, 0)
        TableLayoutPanel1.Controls.Add(titlePic2, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(430, 100)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' titlePic1
        ' 
        titlePic1.Dock = DockStyle.Fill
        titlePic1.Image = CType(resources.GetObject("titlePic1.Image"), Image)
        titlePic1.Location = New Point(3, 3)
        titlePic1.Name = "titlePic1"
        titlePic1.Size = New Size(123, 94)
        titlePic1.SizeMode = PictureBoxSizeMode.StretchImage
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
        titlePic2.Dock = DockStyle.Fill
        titlePic2.Image = CType(resources.GetObject("titlePic2.Image"), Image)
        titlePic2.Location = New Point(304, 3)
        titlePic2.Name = "titlePic2"
        titlePic2.Size = New Size(123, 94)
        titlePic2.SizeMode = PictureBoxSizeMode.StretchImage
        titlePic2.TabIndex = 2
        titlePic2.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(nameLbl, 0, 0)
        TableLayoutPanel2.Controls.Add(nameText, 1, 0)
        TableLayoutPanel2.Controls.Add(gameStartBtn, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Bottom
        TableLayoutPanel2.Location = New Point(3, 396)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(430, 51)
        TableLayoutPanel2.TabIndex = 4
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
        ' nameText
        ' 
        nameText.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        nameText.Location = New Point(146, 14)
        nameText.Name = "nameText"
        nameText.Size = New Size(137, 23)
        nameText.TabIndex = 1
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
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel4.Controls.Add(femaleBrownCKB, 2, 2)
        TableLayoutPanel4.Controls.Add(femaleRedCKB, 1, 2)
        TableLayoutPanel4.Controls.Add(femaleBlondeCKB, 0, 2)
        TableLayoutPanel4.Controls.Add(maleBrownCKB, 2, 1)
        TableLayoutPanel4.Controls.Add(maleRedCKB, 1, 1)
        TableLayoutPanel4.Controls.Add(avatarSelectLbl, 0, 0)
        TableLayoutPanel4.Controls.Add(maleBlondeCKB, 0, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 114)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 3
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel4.Size = New Size(430, 276)
        TableLayoutPanel4.TabIndex = 5
        ' 
        ' avatarSelectLbl
        ' 
        avatarSelectLbl.AutoSize = True
        TableLayoutPanel4.SetColumnSpan(avatarSelectLbl, 3)
        avatarSelectLbl.Dock = DockStyle.Fill
        avatarSelectLbl.Font = New Font("Gill Sans Ultra Bold", 16F, FontStyle.Italic)
        avatarSelectLbl.Location = New Point(3, 0)
        avatarSelectLbl.Name = "avatarSelectLbl"
        avatarSelectLbl.Size = New Size(424, 55)
        avatarSelectLbl.TabIndex = 0
        avatarSelectLbl.Text = "Choose your Avatar"
        avatarSelectLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' maleBlondeCKB
        ' 
        maleBlondeCKB.Appearance = Appearance.Button
        maleBlondeCKB.AutoSize = True
        maleBlondeCKB.Dock = DockStyle.Fill
        maleBlondeCKB.Image = CType(resources.GetObject("maleBlondeCKB.Image"), Image)
        maleBlondeCKB.Location = New Point(3, 58)
        maleBlondeCKB.Name = "maleBlondeCKB"
        maleBlondeCKB.Size = New Size(137, 104)
        maleBlondeCKB.TabIndex = 1
        maleBlondeCKB.UseVisualStyleBackColor = True
        ' 
        ' maleRedCKB
        ' 
        maleRedCKB.Appearance = Appearance.Button
        maleRedCKB.AutoSize = True
        maleRedCKB.Dock = DockStyle.Fill
        maleRedCKB.Image = CType(resources.GetObject("maleRedCKB.Image"), Image)
        maleRedCKB.Location = New Point(146, 58)
        maleRedCKB.Name = "maleRedCKB"
        maleRedCKB.Size = New Size(137, 104)
        maleRedCKB.TabIndex = 2
        maleRedCKB.UseVisualStyleBackColor = True
        ' 
        ' maleBrownCKB
        ' 
        maleBrownCKB.Appearance = Appearance.Button
        maleBrownCKB.AutoSize = True
        maleBrownCKB.Dock = DockStyle.Fill
        maleBrownCKB.Image = CType(resources.GetObject("maleBrownCKB.Image"), Image)
        maleBrownCKB.Location = New Point(289, 58)
        maleBrownCKB.Name = "maleBrownCKB"
        maleBrownCKB.Size = New Size(138, 104)
        maleBrownCKB.TabIndex = 3
        maleBrownCKB.UseVisualStyleBackColor = True
        ' 
        ' femaleBlondeCKB
        ' 
        femaleBlondeCKB.Appearance = Appearance.Button
        femaleBlondeCKB.AutoSize = True
        femaleBlondeCKB.Dock = DockStyle.Fill
        femaleBlondeCKB.Image = CType(resources.GetObject("femaleBlondeCKB.Image"), Image)
        femaleBlondeCKB.Location = New Point(3, 168)
        femaleBlondeCKB.Name = "femaleBlondeCKB"
        femaleBlondeCKB.Size = New Size(137, 105)
        femaleBlondeCKB.TabIndex = 4
        femaleBlondeCKB.UseVisualStyleBackColor = True
        ' 
        ' femaleRedCKB
        ' 
        femaleRedCKB.Appearance = Appearance.Button
        femaleRedCKB.AutoSize = True
        femaleRedCKB.Dock = DockStyle.Fill
        femaleRedCKB.Image = CType(resources.GetObject("femaleRedCKB.Image"), Image)
        femaleRedCKB.Location = New Point(146, 168)
        femaleRedCKB.Name = "femaleRedCKB"
        femaleRedCKB.Size = New Size(137, 105)
        femaleRedCKB.TabIndex = 5
        femaleRedCKB.UseVisualStyleBackColor = True
        ' 
        ' femaleBrownCKB
        ' 
        femaleBrownCKB.Appearance = Appearance.Button
        femaleBrownCKB.AutoSize = True
        femaleBrownCKB.Dock = DockStyle.Fill
        femaleBrownCKB.Image = CType(resources.GetObject("femaleBrownCKB.Image"), Image)
        femaleBrownCKB.Location = New Point(289, 168)
        femaleBrownCKB.Name = "femaleBrownCKB"
        femaleBrownCKB.Size = New Size(138, 105)
        femaleBrownCKB.TabIndex = 6
        femaleBrownCKB.UseVisualStyleBackColor = True
        ' 
        ' AvatarSelection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 450)
        Controls.Add(TableLayoutPanel3)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(452, 489)
        MinimumSize = New Size(452, 489)
        Name = "AvatarSelection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mine Sweeper"
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        CType(titlePic1, ComponentModel.ISupportInitialize).EndInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents titlePic1 As PictureBox
    Friend WithEvents titleLbl As Label
    Friend WithEvents titlePic2 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents nameLbl As Label
    Friend WithEvents nameText As TextBox
    Friend WithEvents gameStartBtn As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents avatarSelectLbl As Label
    Friend WithEvents maleBlondeCKB As CheckBox
    Friend WithEvents femaleBrownCKB As CheckBox
    Friend WithEvents femaleRedCKB As CheckBox
    Friend WithEvents femaleBlondeCKB As CheckBox
    Friend WithEvents maleBrownCKB As CheckBox
    Friend WithEvents maleRedCKB As CheckBox
End Class
