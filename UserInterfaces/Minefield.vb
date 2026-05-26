'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: Minefield.vb
'Description: The UI for the gameboard. It will display the game board and handle
'             user interactions with the game. It will also display the player's
'             name, current time, and current high score.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper


Public Class Minefield

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Public Sub New(player As Player, Optional mineCount As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        Dim gameboard As New Gameboard()

        playerLbl.Text = player.name
        avatarPic.Image = player.avatar

        'gameboard.mineCount = DetermineMineCount()



        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub quitBtn_Click(sender As Object, e As EventArgs) Handles quitBtn.Click

        TitleScreen.Show()
        Me.Close()

    End Sub

    Private Sub restartBtn_Click(sender As Object, e As EventArgs) Handles restartBtn.Click
        Dim gameboard As New Gameboard()

    End Sub
End Class