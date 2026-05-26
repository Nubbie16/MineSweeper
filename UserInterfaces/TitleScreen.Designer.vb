<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TitleScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TitleScreen))
        formLayout = New TableLayoutPanel()
        topLayout = New TableLayoutPanel()
        titlePic1 = New PictureBox()
        titleLbl = New Label()
        titlePic2 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        newGameBtn = New Button()
        difficultyLbl = New Label()
        difficultyCBO = New ComboBox()
        highScoreTC = New TabControl()
        easyTab = New TabPage()
        easyHighLV = New ListView()
        playerCol = New ColumnHeader()
        completedCol = New ColumnHeader()
        mediumTab = New TabPage()
        mediumHighLV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        hardTab = New TabPage()
        hardHighLV = New ListView()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        insaneTab = New TabPage()
        insaneHighLV = New ListView()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        formLayout.SuspendLayout()
        topLayout.SuspendLayout()
        CType(titlePic1, ComponentModel.ISupportInitialize).BeginInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        highScoreTC.SuspendLayout()
        easyTab.SuspendLayout()
        mediumTab.SuspendLayout()
        hardTab.SuspendLayout()
        insaneTab.SuspendLayout()
        SuspendLayout()
        ' 
        ' formLayout
        ' 
        formLayout.ColumnCount = 1
        formLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        formLayout.Controls.Add(topLayout, 0, 0)
        formLayout.Controls.Add(TableLayoutPanel1, 0, 2)
        formLayout.Controls.Add(highScoreTC, 0, 1)
        formLayout.Dock = DockStyle.Fill
        formLayout.Location = New Point(0, 0)
        formLayout.Name = "formLayout"
        formLayout.RowCount = 3
        formLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 28.2442741F))
        formLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 71.75572F))
        formLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 56F))
        formLayout.Size = New Size(438, 456)
        formLayout.TabIndex = 5
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
        topLayout.Size = New Size(432, 100)
        topLayout.TabIndex = 5
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
        titlePic2.Size = New Size(125, 94)
        titlePic2.SizeMode = PictureBoxSizeMode.Zoom
        titlePic2.TabIndex = 2
        titlePic2.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.8064518F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 24.6543789F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.5391731F))
        TableLayoutPanel1.Controls.Add(newGameBtn, 2, 0)
        TableLayoutPanel1.Controls.Add(difficultyLbl, 0, 0)
        TableLayoutPanel1.Controls.Add(difficultyCBO, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 402)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(432, 51)
        TableLayoutPanel1.TabIndex = 7
        ' 
        ' newGameBtn
        ' 
        newGameBtn.Anchor = AnchorStyles.None
        newGameBtn.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        newGameBtn.Location = New Point(229, 7)
        newGameBtn.Name = "newGameBtn"
        newGameBtn.Size = New Size(190, 37)
        newGameBtn.TabIndex = 1
        newGameBtn.Text = "New Game"
        newGameBtn.UseVisualStyleBackColor = True
        ' 
        ' difficultyLbl
        ' 
        difficultyLbl.Anchor = AnchorStyles.Right
        difficultyLbl.AutoSize = True
        difficultyLbl.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        difficultyLbl.Location = New Point(5, 15)
        difficultyLbl.Name = "difficultyLbl"
        difficultyLbl.Size = New Size(103, 20)
        difficultyLbl.TabIndex = 0
        difficultyLbl.Text = "Difficulty:"
        difficultyLbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' difficultyCBO
        ' 
        difficultyCBO.Anchor = AnchorStyles.Left
        difficultyCBO.Font = New Font("Gill Sans Ultra Bold", 8.25F, FontStyle.Italic)
        difficultyCBO.FormattingEnabled = True
        difficultyCBO.Items.AddRange(New Object() {"Easy", "Medium", "Hard", "Insane"})
        difficultyCBO.Location = New Point(114, 12)
        difficultyCBO.Name = "difficultyCBO"
        difficultyCBO.Size = New Size(82, 26)
        difficultyCBO.TabIndex = 1
        ' 
        ' highScoreTC
        ' 
        highScoreTC.Controls.Add(easyTab)
        highScoreTC.Controls.Add(mediumTab)
        highScoreTC.Controls.Add(hardTab)
        highScoreTC.Controls.Add(insaneTab)
        highScoreTC.Dock = DockStyle.Fill
        highScoreTC.Font = New Font("Gill Sans Ultra Bold", 13F, FontStyle.Italic)
        highScoreTC.Location = New Point(3, 115)
        highScoreTC.Name = "highScoreTC"
        highScoreTC.SelectedIndex = 0
        highScoreTC.Size = New Size(432, 281)
        highScoreTC.TabIndex = 8
        ' 
        ' easyTab
        ' 
        easyTab.Controls.Add(easyHighLV)
        easyTab.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        easyTab.Location = New Point(4, 34)
        easyTab.Name = "easyTab"
        easyTab.Size = New Size(424, 243)
        easyTab.TabIndex = 0
        easyTab.Text = "Easy"
        easyTab.UseVisualStyleBackColor = True
        ' 
        ' easyHighLV
        ' 
        easyHighLV.Columns.AddRange(New ColumnHeader() {playerCol, completedCol})
        easyHighLV.Dock = DockStyle.Fill
        easyHighLV.Location = New Point(0, 0)
        easyHighLV.Name = "easyHighLV"
        easyHighLV.Size = New Size(424, 243)
        easyHighLV.TabIndex = 0
        easyHighLV.UseCompatibleStateImageBehavior = False
        easyHighLV.View = View.Details
        ' 
        ' playerCol
        ' 
        playerCol.Text = "Player Name"
        playerCol.Width = 208
        ' 
        ' completedCol
        ' 
        completedCol.Text = "Time Completed "
        completedCol.TextAlign = HorizontalAlignment.Right
        completedCol.Width = 206
        ' 
        ' mediumTab
        ' 
        mediumTab.Controls.Add(mediumHighLV)
        mediumTab.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        mediumTab.Location = New Point(4, 34)
        mediumTab.Name = "mediumTab"
        mediumTab.Size = New Size(424, 243)
        mediumTab.TabIndex = 1
        mediumTab.Text = "Medium"
        mediumTab.UseVisualStyleBackColor = True
        ' 
        ' mediumHighLV
        ' 
        mediumHighLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        mediumHighLV.Dock = DockStyle.Fill
        mediumHighLV.Location = New Point(0, 0)
        mediumHighLV.Name = "mediumHighLV"
        mediumHighLV.Size = New Size(424, 243)
        mediumHighLV.TabIndex = 1
        mediumHighLV.UseCompatibleStateImageBehavior = False
        mediumHighLV.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Player Name"
        ColumnHeader1.Width = 208
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Time Completed "
        ColumnHeader2.TextAlign = HorizontalAlignment.Right
        ColumnHeader2.Width = 206
        ' 
        ' hardTab
        ' 
        hardTab.Controls.Add(hardHighLV)
        hardTab.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        hardTab.Location = New Point(4, 34)
        hardTab.Name = "hardTab"
        hardTab.Size = New Size(424, 243)
        hardTab.TabIndex = 2
        hardTab.Text = "Hard"
        hardTab.UseVisualStyleBackColor = True
        ' 
        ' hardHighLV
        ' 
        hardHighLV.Columns.AddRange(New ColumnHeader() {ColumnHeader3, ColumnHeader4})
        hardHighLV.Dock = DockStyle.Fill
        hardHighLV.Location = New Point(0, 0)
        hardHighLV.Name = "hardHighLV"
        hardHighLV.Size = New Size(424, 243)
        hardHighLV.TabIndex = 1
        hardHighLV.UseCompatibleStateImageBehavior = False
        hardHighLV.View = View.Details
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Player Name"
        ColumnHeader3.Width = 208
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Time Completed "
        ColumnHeader4.TextAlign = HorizontalAlignment.Right
        ColumnHeader4.Width = 206
        ' 
        ' insaneTab
        ' 
        insaneTab.Controls.Add(insaneHighLV)
        insaneTab.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        insaneTab.Location = New Point(4, 34)
        insaneTab.Name = "insaneTab"
        insaneTab.Size = New Size(424, 243)
        insaneTab.TabIndex = 3
        insaneTab.Text = "Insane"
        insaneTab.UseVisualStyleBackColor = True
        ' 
        ' insaneHighLV
        ' 
        insaneHighLV.Columns.AddRange(New ColumnHeader() {ColumnHeader5, ColumnHeader6})
        insaneHighLV.Dock = DockStyle.Fill
        insaneHighLV.Location = New Point(0, 0)
        insaneHighLV.Name = "insaneHighLV"
        insaneHighLV.Size = New Size(424, 243)
        insaneHighLV.TabIndex = 1
        insaneHighLV.UseCompatibleStateImageBehavior = False
        insaneHighLV.View = View.Details
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Player Name"
        ColumnHeader5.Width = 208
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Time Completed "
        ColumnHeader6.TextAlign = HorizontalAlignment.Right
        ColumnHeader6.Width = 206
        ' 
        ' TitleScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(438, 456)
        Controls.Add(formLayout)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(454, 495)
        MinimumSize = New Size(454, 495)
        Name = "TitleScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mine Sweeper"
        formLayout.ResumeLayout(False)
        topLayout.ResumeLayout(False)
        CType(titlePic1, ComponentModel.ISupportInitialize).EndInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        highScoreTC.ResumeLayout(False)
        easyTab.ResumeLayout(False)
        mediumTab.ResumeLayout(False)
        hardTab.ResumeLayout(False)
        insaneTab.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents formLayout As TableLayoutPanel
    Friend WithEvents topLayout As TableLayoutPanel
    Friend WithEvents titlePic1 As PictureBox
    Friend WithEvents titleLbl As Label
    Friend WithEvents titlePic2 As PictureBox
    Friend WithEvents difficultyCBO As ComboBox
    Friend WithEvents difficultyLbl As Label
    Friend WithEvents newGameBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents highScoreTC As TabControl
    Friend WithEvents easyTab As TabPage
    Friend WithEvents mediumTab As TabPage
    Friend WithEvents hardTab As TabPage
    Friend WithEvents insaneTab As TabPage
    Friend WithEvents easyHighLV As ListView
    Friend WithEvents playerCol As ColumnHeader
    Friend WithEvents completedCol As ColumnHeader
    Friend WithEvents mediumHighLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents hardHighLV As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents insaneHighLV As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader

End Class
