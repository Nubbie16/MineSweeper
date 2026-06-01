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

    Public gameboard As Gameboard
    Dim cellButtons(,) As Button


    Public Sub New(currentPlayer As Player)

        InitializeComponent()

        gameboard = New Gameboard()
        gameboard.player = currentPlayer

        selectedDiffLbl.Text = Gameboard.player.difficulty
        playerLbl.Text = Gameboard.player.name
        avatarPic.Image = Gameboard.player.avatar

        Gameboard.mineCount = DetermineMineCount(Gameboard.player.difficulty)

        GenerateGrid(gameboard, cellButtons, gameboardPanel, AddressOf Cell_MouseUp)

    End Sub

    ''Timer start when first cell changes


    Private Sub quitBtn_Click(sender As Object, e As EventArgs) Handles quitBtn.Click

        TitleScreen.Show()
        Me.Close()

    End Sub

    Private Sub restartBtn_Click(sender As Object, e As EventArgs) Handles restartBtn.Click

        ''Needed

    End Sub

    Public Sub Cell_MouseUp(sender As Object, e As MouseEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim location As Point = CType(btn.Tag, Point)

        Dim row As Integer = location.X
        Dim col As Integer = location.Y

        If e.Button = MouseButtons.Left Then
            'reveal cell
        ElseIf e.Button = MouseButtons.Right Then
            'Flag Cell
        End If

    End Sub

End Class