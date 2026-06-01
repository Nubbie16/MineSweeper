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
    Public fullMinefield As Button(,)


    Public Sub New(currentPlayer As Player)

        InitializeComponent()

        gameboard = New Gameboard()
        gameboard.player = currentPlayer

        selectedDiffLbl.Text = Gameboard.player.difficulty
        playerLbl.Text = Gameboard.player.name
        avatarPic.Image = Gameboard.player.avatar

        gameboard.mineCount = DetermineMineCount(gameboard.player.difficulty)

        GenerateGrid(gameboard, gameboardPanel, AddressOf Cell_MouseUp)       'Creates the base grid layout

        PlaceMines(gameboard)                                     'Stores mine placement in gameboard

        DetermineFieldNumbers(gameboard)                          'Stores proximity numbers in gameboard

        GenerateRevealedMinefield(gameboard, gameboardPanel)              ' Creates revealed minefield with mines and proximity numbers

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

    Public Sub GenerateRevealedMinefield(board As Gameboard, boardPanel As Control)

        GenerateMinePlacement(board, boardPanel)
        GenerateProximityPlacement(board, boardPanel)




    End Sub

End Class