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
    End Sub

    Public Sub GenerateMinePlacement(board As Gameboard, boardPanel As Control)

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

                If board.placedMines(col, row) Then
                    btn.BackgroundImage = My.Resources.Mine
                End If

                board.cellGrid(col, row) = btn
                boardPanel.Controls.Add(btn)
            Next
        Next

    End Sub

    Public Sub GenerateProximityPlacement(board As Gameboard, boardPanel As Control)
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

                If board.placedProximityNums(col, row) > 0 Then
                    btn.Text = board.placedProximityNums(col, row).ToString()
                End If

                board.cellGrid(col, row) = btn
                boardPanel.Controls.Add(btn)
            Next
        Next
    End Sub


    Public Sub PlaceMines(board As Gameboard)

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

    'Looks at all surrounding cells for mines and tracks the number
    Public Function ProximityHelper(board As Gameboard, currentX As Integer, currentY As Integer) As Integer

        Dim proxCount As Integer = 0

        Dim xOffsets() As Integer = {-1, 0, 1, -1, 1, -1, 0, 1}
        Dim yOffsets() As Integer = {-1, -1, -1, 0, 0, 1, 1, 1}
        Dim checkX As Integer = Nothing
        Dim checkY As Integer = Nothing

        For subset As Integer = 0 To xOffsets.Length - 1
            checkX = currentX + xOffsets(subset)
            checkY = currentY + yOffsets(subset)

            If board.IsInsideBoard(checkX, checkY) Then
                If board.placedMines(checkX, checkY) Then
                    proxCount += 1
                End If
            End If
        Next

        Return proxCount

    End Function

End Module
