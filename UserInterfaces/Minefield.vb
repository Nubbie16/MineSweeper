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

    Public Sub New(currentPlayer As Player)

        InitializeComponent()

        gameboard = New Gameboard()
        gameboard.player = currentPlayer

        selectedDiffLbl.Text = Gameboard.player.difficulty
        playerLbl.Text = Gameboard.player.name
        avatarPic.Image = Gameboard.player.avatar

        gameboard.mineCount = gameboard.DetermineMineCount(gameboard.player.difficulty)
        remainingMinesLbl.Text = "Mines Left: " & gameboard.mineCount.ToString()

        InitializeMinefield()

    End Sub

    Private Sub InitializeMinefield()

        GenerateGrid(gameboard, gameboardPanel, AddressOf Cell_MouseUp)       'Creates the base grid layout
        PlaceMines(gameboard)                                     'Stores mine placement in gameboard
        DetermineFieldNumbers(gameboard)                          'Stores proximity numbers in gameboard

    End Sub


    ''Timer start when first cell changes


    Private Sub quitBtn_Click(sender As Object, e As EventArgs) Handles quitBtn.Click

        TitleScreen.Show()
        Me.Close()

    End Sub

    Private Sub restartBtn_Click(sender As Object, e As EventArgs) Handles restartBtn.Click

        InitializeMinefield()

    End Sub

    Public Sub Cell_MouseUp(sender As Object, e As MouseEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim location As Point = CType(btn.Tag, Point)

        Dim col As Integer = location.X
        Dim row As Integer = location.Y

        If e.Button = MouseButtons.Left Then
            RevealTile(gameboard, col, row)
        ElseIf e.Button = MouseButtons.Right Then
            PlaceFlag(gameboard, col, row)
        End If

    End Sub

    Public Sub DetermineFieldNumbers(board As Gameboard)

        ReDim board.placedProximityNums(board.horizontalSize - 1, board.verticalSize - 1)

        For x As Integer = 0 To board.horizontalSize - 1
            For y As Integer = 0 To board.verticalSize - 1

                Dim proximityCount As Integer = 0

                If board.placedMines(x, y) = False Then

                    proximityCount = ProximityHelper(board, x, y)
                    board.placedProximityNums(x, y) = proximityCount
                End If
            Next
        Next
    End Sub

    Private Sub Minefield_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If e.Button = MouseButtons.Right Then
            remainingMinesLbl.Text = "Mines Left: " & gameboard.remainingMines.ToString()
        End If

    End Sub
End Class