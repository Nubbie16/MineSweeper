'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: MinefieldHelper.vb
'Description: Helper file for related minefield functions and methods.
'Programmer: Cody Eckard
'Creation Date: June 1, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Module MinefieldHelper

    ''Fixed seed for testing and debugging. DELETE/COMMENT OUT on live
    Private seed As Integer = 12345
    Private RNG As New Random(seed)

    ''Live code for RNG
    'Private RNG As New Random()

    Public Sub GenerateGrid(board As Gameboard, ByRef cellBtns(,) As Button, boardPanel As Control, mouseHandler As MouseEventHandler)

        Dim rows As Integer = board.horizontalSize
        Dim cols As Integer = board.verticalSize
        Dim cellSize As Integer = 34

        Dim boardWidth As Integer = cols * cellSize
        Dim boardHeight As Integer = rows * cellSize

        Dim startX As Integer = (boardPanel.Width - boardWidth) \ 2
        Dim startY As Integer = (boardPanel.Height - boardHeight) \ 2

        boardPanel.Controls.Clear()
        ReDim cellBtns(rows - 1, cols - 1)

        For row As Integer = 0 To rows - 1
            For col As Integer = 0 To cols - 1

                Dim btn As New Button()

                btn.Width = cellSize
                btn.Height = cellSize
                btn.Left = startX + (col * cellSize)
                btn.Top = startY + (row * cellSize)
                btn.Margin = New Padding(0)
                btn.Tag = New Point(row, col)

                btn.FlatStyle = FlatStyle.Flat
                btn.BackgroundImageLayout = ImageLayout.Zoom

                AddHandler btn.MouseUp, mouseHandler

                cellBtns(row, col) = btn
                boardPanel.Controls.Add(btn)

            Next
        Next
    End Sub

    Public Function PlaceMines(board As Gameboard) As Boolean(,)

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

        Return placedMineGrid

    End Function

End Module
