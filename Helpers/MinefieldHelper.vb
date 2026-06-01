'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: MinefieldHelper.vb
'Description: Helper file for related minefield functions and methods.
'Programmer: Cody Eckard
'Creation Date: June 1, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Module MinefieldHelper

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

End Module
