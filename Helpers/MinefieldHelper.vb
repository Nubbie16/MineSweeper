'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: MinefieldHelper.vb
'Description: Helper file for related minefield functions and methods.
'Programmer: Cody Eckard
'Creation Date: June 1, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Module MinefieldHelper

    'Private RNG As New Random(12345)

    'Private RNG As New Random()

    Private xOffsets() As Integer = {-1, 0, 1, -1, 1, -1, 0, 1}
    Private yOffsets() As Integer = {-1, -1, -1, 0, 0, 1, 1, 1}

    Public Sub GenerateGrid(board As Gameboard, boardPanel As Control, mouseHandler As MouseEventHandler)

        Dim cols As Integer = board.horizontalSize
        Dim rows As Integer = board.verticalSize
        Dim cellSize As Integer = 34

        Dim boardWidth As Integer = rows * cellSize
        Dim boardHeight As Integer = cols * cellSize

        Dim startX As Integer = (boardPanel.Width - boardWidth) \ 2
        Dim startY As Integer = (boardPanel.Height - boardHeight) \ 2

        boardPanel.Controls.Clear()
        ReDim board.cellGrid(cols - 1, rows - 1)

        For col As Integer = 0 To cols - 1
            For row As Integer = 0 To rows - 1

                Dim btn As New Button()

                btn.Width = cellSize
                btn.Height = cellSize
                btn.Left = startX + (row * cellSize)
                btn.Top = startY + (col * cellSize)
                btn.Margin = New Padding(0)
                btn.Tag = New Point(col, row)

                btn.FlatStyle = FlatStyle.Flat
                btn.BackgroundImageLayout = ImageLayout.Zoom

                AddHandler btn.MouseUp, mouseHandler

                board.cellGrid(col, row) = btn
                boardPanel.Controls.Add(btn)

            Next
        Next

        ReDim board.revealedCells(board.horizontalSize - 1, board.verticalSize - 1)

    End Sub

    Public Sub ShowRevealedMinefield(board As Gameboard, boardPanel As Control)

        For col As Integer = 0 To board.horizontalSize - 1
            For row As Integer = 0 To board.verticalSize - 1

                Dim btn As Button = board.cellGrid(col, row)

                If btn Is Nothing Then
                    Continue For
                End If

                btn.BackgroundImage = Nothing
                btn.Text = ""

                If board.placedMines(col, row) Then

                    btn.BackgroundImage = My.Resources.Mine32
                    btn.BackgroundImageLayout = ImageLayout.Zoom

                ElseIf board.flaggedGrid(col, row) AndAlso board.placedMines(col, row) = False Then

                    btn.BackgroundImage = My.Resources.XFlag32
                    btn.BackgroundImageLayout = ImageLayout.Zoom


                ElseIf board.placedProximityNums(col, row) > 0 Then

                    btn.Text = board.placedProximityNums(col, row).ToString()
                    FormatProximityFlag(board.cellGrid, col, row)

                Else

                    btn.BackColor = Color.DarkGray

                End If

                board.revealedCells(col, row) = True

            Next
        Next

    End Sub

    Public Sub PlaceMines(board As Gameboard)

        Dim RNG As New Random(12345)
        'Dim RNG As New Random()

        Dim placedMineGrid(board.horizontalSize - 1, board.verticalSize - 1) As Boolean
        Dim minesPlaced As Integer = 0

        While minesPlaced < board.mineCount

            Dim randomX As Integer = RNG.Next(0, board.horizontalSize)
            Dim randomY As Integer = RNG.Next(0, board.verticalSize)

            If placedMineGrid(randomX, randomY) = False Then
                placedMineGrid(randomX, randomY) = True
                minesPlaced += 1
            End If

        End While

        board.placedMines = placedMineGrid

    End Sub

    ' Looks at all surrounding cells for mines and tracks the number.
    Public Function ProximityHelper(board As Gameboard, currentX As Integer, currentY As Integer) As Integer

        Dim proxCount As Integer = 0

        For subset As Integer = 0 To xOffsets.Length - 1

            Dim checkX As Integer = currentX + xOffsets(subset)
            Dim checkY As Integer = currentY + yOffsets(subset)

            If board.IsInsideBoard(checkX, checkY) Then
                If board.placedMines(checkX, checkY) Then
                    proxCount += 1
                End If
            End If

        Next

        Return proxCount

    End Function

    Public Sub GameLostSequence(board As Gameboard, minefieldForm As Minefield, x As Integer, y As Integer)

        ShowRevealedMinefield(board, board.cellGrid(0, 0).Parent)

        board.cellGrid(x, y).BackgroundImage = My.Resources.Detonated32
        board.cellGrid(x, y).BackgroundImageLayout = ImageLayout.Zoom

        If board.player IsNot Nothing AndAlso board.player.deadAvatar IsNot Nothing Then
            minefieldForm.avatarPic.Image = board.player.deadAvatar
        End If

        minefieldForm.ScoreTimerStop()
        minefieldForm.scoreTimer.Enabled = False
        minefieldForm.stopwatch.Reset()

        MessageBox.Show("You hit a mine! Game Over.", "Mine Sweeper")

    End Sub

    Public Sub RevealEmptyTile(board As Gameboard, minefieldForm As Minefield, x As Integer, y As Integer)

        If board.IsInsideBoard(x, y) = False Then
            Exit Sub
        End If

        If board.placedMines(x, y) Then
            Exit Sub
        End If

        If board.revealedCells(x, y) Then
            Exit Sub
        End If

        If board.flaggedGrid(x, y) Then
            Exit Sub
        End If

        If board.maybeGrid(x, y) Then
            Exit Sub
        End If

        board.revealedCells(x, y) = True

        If board.placedProximityNums(x, y) = 0 Then
            FormatEmptyCells(board, x, y)
        End If

        If board.placedProximityNums(x, y) > 0 Then
            RevealProximityFlag(board, minefieldForm, x, y)
            Exit Sub
        End If

        For subset As Integer = 0 To xOffsets.Length - 1

            Dim checkX As Integer = x + xOffsets(subset)
            Dim checkY As Integer = y + yOffsets(subset)

            RevealEmptyTile(board, minefieldForm, checkX, checkY)

        Next

    End Sub

    Public Sub FormatEmptyCells(board As Gameboard, x As Integer, y As Integer)

        board.cellGrid(x, y).BackColor = Color.DarkGray
        board.cellGrid(x, y).Enabled = False

    End Sub

    Public Sub RevealProximityFlag(board As Gameboard, minefieldForm As Minefield, x As Integer, y As Integer)

        board.cellGrid(x, y).Text = board.placedProximityNums(x, y).ToString()
        board.revealedCells(x, y) = True

        If board.flaggedGrid(x, y) Then
            board.flaggedGrid(x, y) = False
            board.remainingMines += 1
            UpdateRemainingMinesLabel(board.remainingMines, minefieldForm.remainingMinesLbl)
        End If

        board.cellGrid(x, y).BackgroundImage = Nothing

        FormatProximityFlag(board.cellGrid, x, y)

    End Sub

    Public Sub FormatProximityFlag(grid As Button(,), x As Integer, y As Integer)

        grid(x, y).Font = New Font("Gill Sans Ultra Bold", 9, FontStyle.Italic)

        Select Case grid(x, y).Text

            Case "1"
                grid(x, y).ForeColor = Color.Blue
            Case "2"
                grid(x, y).ForeColor = Color.Green
            Case "3"
                grid(x, y).ForeColor = Color.Red
            Case "4"
                grid(x, y).ForeColor = Color.DarkBlue
            Case "5"
                grid(x, y).ForeColor = Color.Maroon
            Case "6"
                grid(x, y).ForeColor = Color.Turquoise
            Case "7"
                grid(x, y).ForeColor = Color.Teal
            Case "8"
                grid(x, y).ForeColor = Color.Firebrick

        End Select

        grid(x, y).Tag = New Point(x, y)

    End Sub



    Public Sub UpdateRemainingMinesLabel(ByRef remainingMines As Integer, label As Label)

        label.Text = "Mines Left: " & remainingMines.ToString()

    End Sub

End Module