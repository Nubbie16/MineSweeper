<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minefield
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Minefield))
        formLayout = New TableLayoutPanel()
        topLayout = New TableLayoutPanel()
        playerLbl = New Label()
        avatarPic = New PictureBox()
        timerLbl = New Label()
        selectedDiffLbl = New Label()
        gameboardPanel = New Panel()
        bottomLayout = New TableLayoutPanel()
        restartBtn = New Button()
        quitBtn = New Button()
        scoreTimer = New Timer(components)
        formLayout.SuspendLayout()
        topLayout.SuspendLayout()
        CType(avatarPic, ComponentModel.ISupportInitialize).BeginInit()
        bottomLayout.SuspendLayout()
        SuspendLayout()
        ' 
        ' formLayout
        ' 
        formLayout.ColumnCount = 1
        formLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        formLayout.Controls.Add(topLayout, 0, 0)
        formLayout.Controls.Add(gameboardPanel, 0, 1)
        formLayout.Controls.Add(bottomLayout, 0, 2)
        formLayout.Dock = DockStyle.Fill
        formLayout.Location = New Point(0, 0)
        formLayout.Name = "formLayout"
        formLayout.RowCount = 3
        formLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 24.81203F))
        formLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 75.18797F))
        formLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 68F))
        formLayout.Size = New Size(436, 456)
        formLayout.TabIndex = 6
        ' 
        ' topLayout
        ' 
        topLayout.ColumnCount = 3
        topLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        topLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        topLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        topLayout.Controls.Add(playerLbl, 1, 0)
        topLayout.Controls.Add(avatarPic, 2, 0)
        topLayout.Controls.Add(timerLbl, 0, 1)
        topLayout.Controls.Add(selectedDiffLbl, 0, 0)
        topLayout.Dock = DockStyle.Top
        topLayout.Location = New Point(3, 3)
        topLayout.Name = "topLayout"
        topLayout.RowCount = 2
        topLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        topLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        topLayout.Size = New Size(430, 90)
        topLayout.TabIndex = 4
        ' 
        ' playerLbl
        ' 
        playerLbl.Dock = DockStyle.Fill
        playerLbl.Font = New Font("Gill Sans Ultra Bold", 19F, FontStyle.Italic)
        playerLbl.Location = New Point(132, 0)
        playerLbl.Name = "playerLbl"
        topLayout.SetRowSpan(playerLbl, 2)
        playerLbl.Size = New Size(166, 90)
        playerLbl.TabIndex = 0
        playerLbl.Text = "Name Avatar>>"
        playerLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' avatarPic
        ' 
        avatarPic.BackColor = Color.Transparent
        avatarPic.Dock = DockStyle.Fill
        avatarPic.Location = New Point(304, 3)
        avatarPic.Name = "avatarPic"
        topLayout.SetRowSpan(avatarPic, 2)
        avatarPic.Size = New Size(123, 84)
        avatarPic.SizeMode = PictureBoxSizeMode.Zoom
        avatarPic.TabIndex = 2
        avatarPic.TabStop = False
        ' 
        ' timerLbl
        ' 
        timerLbl.Dock = DockStyle.Fill
        timerLbl.Font = New Font("Gill Sans Ultra Bold", 9F, FontStyle.Italic)
        timerLbl.Location = New Point(3, 36)
        timerLbl.Name = "timerLbl"
        timerLbl.Size = New Size(123, 54)
        timerLbl.TabIndex = 3
        timerLbl.Text = "00:00.00"
        timerLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' selectedDiffLbl
        ' 
        selectedDiffLbl.Dock = DockStyle.Fill
        selectedDiffLbl.Font = New Font("Gill Sans Ultra Bold", 9F, FontStyle.Italic)
        selectedDiffLbl.Location = New Point(3, 0)
        selectedDiffLbl.Name = "selectedDiffLbl"
        selectedDiffLbl.Size = New Size(123, 36)
        selectedDiffLbl.TabIndex = 4
        selectedDiffLbl.Text = "[Diff Select]"
        selectedDiffLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' gameboardPanel
        ' 
        gameboardPanel.BackgroundImageLayout = ImageLayout.Zoom
        gameboardPanel.Dock = DockStyle.Fill
        gameboardPanel.Location = New Point(3, 99)
        gameboardPanel.Name = "gameboardPanel"
        gameboardPanel.Size = New Size(430, 285)
        gameboardPanel.TabIndex = 6
        ' 
        ' bottomLayout
        ' 
        bottomLayout.ColumnCount = 2
        bottomLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        bottomLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        bottomLayout.Controls.Add(restartBtn, 0, 0)
        bottomLayout.Controls.Add(quitBtn, 1, 0)
        bottomLayout.Dock = DockStyle.Fill
        bottomLayout.Location = New Point(3, 390)
        bottomLayout.Name = "bottomLayout"
        bottomLayout.RowCount = 1
        bottomLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        bottomLayout.Size = New Size(430, 63)
        bottomLayout.TabIndex = 7
        ' 
        ' restartBtn
        ' 
        restartBtn.Dock = DockStyle.Fill
        restartBtn.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        restartBtn.Location = New Point(3, 3)
        restartBtn.Name = "restartBtn"
        restartBtn.Size = New Size(209, 57)
        restartBtn.TabIndex = 0
        restartBtn.Text = "Restart"
        restartBtn.UseVisualStyleBackColor = True
        ' 
        ' quitBtn
        ' 
        quitBtn.Dock = DockStyle.Fill
        quitBtn.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic)
        quitBtn.Image = CType(resources.GetObject("quitBtn.Image"), Image)
        quitBtn.Location = New Point(218, 3)
        quitBtn.Name = "quitBtn"
        quitBtn.Size = New Size(209, 57)
        quitBtn.TabIndex = 1
        quitBtn.Text = "Give Up!"
        quitBtn.TextAlign = ContentAlignment.MiddleRight
        quitBtn.TextImageRelation = TextImageRelation.TextBeforeImage
        quitBtn.UseVisualStyleBackColor = True
        ' 
        ' scoreTimer
        ' 
        scoreTimer.Interval = 1000
        ' 
        ' Minefield
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 456)
        Controls.Add(formLayout)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(452, 495)
        MinimumSize = New Size(452, 495)
        Name = "Minefield"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mine Sweeper"
        formLayout.ResumeLayout(False)
        topLayout.ResumeLayout(False)
        CType(avatarPic, ComponentModel.ISupportInitialize).EndInit()
        bottomLayout.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents formLayout As TableLayoutPanel
    Friend WithEvents topLayout As TableLayoutPanel
    Friend WithEvents playerLbl As Label
    Friend WithEvents avatarPic As PictureBox
    Friend WithEvents timerLbl As Label
    Friend WithEvents restartBtn As Button
    Friend WithEvents quitBtn As Button
    Friend WithEvents gameboardPanel As Panel
    Friend WithEvents bottomLayout As TableLayoutPanel
    Friend WithEvents selectedDiffLbl As Label
    Friend WithEvents scoreTimer As Timer
End Class
