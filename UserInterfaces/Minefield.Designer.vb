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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Minefield))
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        titlePic1 = New PictureBox()
        titleLbl = New Label()
        titlePic2 = New PictureBox()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(titlePic1, ComponentModel.ISupportInitialize).BeginInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(TableLayoutPanel1, 0, 0)
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
        ' Minefield
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 450)
        Controls.Add(TableLayoutPanel3)
        MaximizeBox = False
        MaximumSize = New Size(452, 489)
        MinimumSize = New Size(452, 489)
        Name = "Minefield"
        Text = "Minefield"
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        CType(titlePic1, ComponentModel.ISupportInitialize).EndInit()
        CType(titlePic2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents titlePic1 As PictureBox
    Friend WithEvents titleLbl As Label
    Friend WithEvents titlePic2 As PictureBox
End Class
