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
        titleLbl = New Label()
        titlePic1 = New PictureBox()
        titlePic2 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        newGameBtn = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        highScoreLV = New ListView()
        playerCol = New ColumnHeader()
        timeCompletedCol = New ColumnHeader()
        CType(titlePic1, ComponentModel.ISupportInitialize).BeginInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
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
        ' newGameBtn
        ' 
        newGameBtn.Anchor = AnchorStyles.None
        newGameBtn.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        newGameBtn.Location = New Point(123, 403)
        newGameBtn.Name = "newGameBtn"
        newGameBtn.Size = New Size(190, 37)
        newGameBtn.TabIndex = 0
        newGameBtn.Text = "New Game"
        newGameBtn.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(newGameBtn, 0, 2)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel3.Controls.Add(highScoreLV, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 28.2442741F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 71.75572F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 56F))
        TableLayoutPanel3.Size = New Size(436, 450)
        TableLayoutPanel3.TabIndex = 5
        ' 
        ' highScoreLV
        ' 
        highScoreLV.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        highScoreLV.Columns.AddRange(New ColumnHeader() {playerCol, timeCompletedCol})
        highScoreLV.Location = New Point(65, 114)
        highScoreLV.Name = "highScoreLV"
        highScoreLV.Size = New Size(305, 276)
        highScoreLV.TabIndex = 4
        highScoreLV.UseCompatibleStateImageBehavior = False
        highScoreLV.View = View.Details
        ' 
        ' playerCol
        ' 
        playerCol.Text = "Player Name"
        playerCol.Width = 150
        ' 
        ' timeCompletedCol
        ' 
        timeCompletedCol.Text = "Time Completed"
        timeCompletedCol.Width = 150
        ' 
        ' TitleScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 450)
        Controls.Add(TableLayoutPanel3)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(452, 489)
        MinimumSize = New Size(452, 489)
        Name = "TitleScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mine Sweeper"
        CType(titlePic1, ComponentModel.ISupportInitialize).EndInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents titleLbl As Label
    Friend WithEvents titlePic1 As PictureBox
    Friend WithEvents titlePic2 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents newGameBtn As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents highScoreLV As ListView
    Friend WithEvents playerCol As ColumnHeader
    Friend WithEvents timeCompletedCol As ColumnHeader

End Class
