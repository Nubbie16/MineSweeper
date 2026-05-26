'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: MainForm.vb
'Description: This is the main form for the MineSweeper game. It will display
'             the start button to begin a game and high scores based on completion time.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Public Class TitleScreen

    Dim difficulty As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub newGameBtn_Click(sender As Object, e As EventArgs) Handles newGameBtn.Click

        difficulty = difficultyCBO.SelectedItem.ToString()
        Dim avatarSelection As New AvatarSelection(difficulty)
        avatarSelection.Show()
        Hide()
    End Sub

    ''Display scores based on difficulty selection

End Class
