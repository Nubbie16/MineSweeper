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
    Public stopwatch As Stopwatch = New Stopwatch()
    Public currentTime As TimeSpan

    Public Sub New(currentPlayer As Player)

        InitializeComponent()

        gameboard = New Gameboard()
        gameboard.player = currentPlayer

        selectedDiffLbl.Text = Gameboard.player.difficulty
        playerLbl.Text = Gameboard.player.name
        avatarPic.Image = Gameboard.player.avatar

        gameboard.mineCount = gameboard.DetermineMineCount(gameboard.player.difficulty)
        gameboard.remainingMines = gameboard.mineCount
        remainingMinesLbl.Text = "Mines Left: " & gameboard.remainingMines.ToString()

        InitializeMinefield()

    End Sub

    Private Sub InitializeMinefield()

        GenerateGrid(gameboard, gameboardPanel, AddressOf Cell_MouseUp)       'Creates the base grid layout
        PlaceMines(gameboard)                                     'Stores mine placement in gameboard
        DetermineFieldNumbers(gameboard)                          'Stores proximity numbers in gameboard

    End Sub

    Public Sub ScoreTimer_Tick(sender As Object, e As EventArgs) Handles scoreTimer.Tick
        currentTime = stopwatch.Elapsed
        timerLbl.Text = currentTime.ToString("hh\:mm\:ss\.ff")
    End Sub

    Public Sub ScoreTimerStart()
        If currentTime = TimeSpan.Zero Then
            stopwatch.Reset()
            scoreTimer.Start()
            stopwatch.Start()
        End If
    End Sub

    Public Sub ScoreTimerStop()
        scoreTimer.Stop()
        stopwatch.Stop()
    End Sub

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
            ScoreTimerStart()                                   'Starts the timer on the first click of the game
            If gameboard.revealedCells(col, row) Then           ' "disables" use of revealed cells
                Exit Sub
            End If
            RevealTile(gameboard, col, row)
            CheckWinCondition(gameboard, Me)
        ElseIf e.Button = MouseButtons.Right Then
            ScoreTimerStart()                                   'Starts the timer on the first click of the game
            If gameboard.revealedCells(col, row) Then           ' "disables" use of revealed cells
                Exit Sub
            End If
            If gameboard.flaggedGrid(col, row) = False AndAlso gameboard.cellGrid(col, row).BackgroundImage Is Nothing Then
                PlaceFlag(gameboard, col, row)
                CheckWinCondition(gameboard, Me)
            ElseIf gameboard.flaggedGrid(col, row) = True Then
                PlaceMaybeFlag(gameboard, col, row)
            Else
                gameboard.cellGrid(col, row).BackgroundImage = Nothing
            End If
        End If

    End Sub

    Public Sub PlaceFlag(board As Gameboard, x As Integer, y As Integer)
        If board.IsInsideBoard(x, y) Then
            board.flaggedGrid(x, y) = True
            board.cellGrid(x, y).BackgroundImage = My.Resources.Flag32
            board.remainingMines -= 1
            UpdateRemainingMinesLabel(board.remainingMines, remainingMinesLbl)
        End If

    End Sub

    Public Sub PlaceMaybeFlag(board As Gameboard, x As Integer, y As Integer)
        If board.IsInsideBoard(x, y) Then
            board.cellGrid(x, y).BackgroundImage = My.Resources.Maybe32
            board.flaggedGrid(x, y) = False
            board.remainingMines += 1
            UpdateRemainingMinesLabel(board.remainingMines, remainingMinesLbl)
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

    Public Sub RevealTile(board As Gameboard, x As Integer, y As Integer)

        Dim hor As Integer = board.horizontalSize - 1
        Dim vert As Integer = board.verticalSize - 1
        Dim win As Boolean = False

        If board.IsInsideBoard(x, y) Then
            If board.placedMines(x, y) Then
                'Mine hit, game over
                GameLostSequence(board, Me, x, y)
                Return
            ElseIf board.placedProximityNums(x, y) > 0 Then
                RevealProximityFlag(board, Me, x, y)
            Else
                RevealEmptyTile(board, Me, x, y)
            End If
        End If

    End Sub
End Class