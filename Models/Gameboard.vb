'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: Game.vb
'Description: This class will represent the game for the MineSweeper game.
'             It will handle the game board and the placement of mines.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Public Class Gameboard

    Public Property horizontalSize As Integer = 11
    Public Property verticalSize As Integer = 8
    Public Property mineCount As Integer
    Public Property player As Player

    Public Property cellGrid As Button(,)
    Public Property placedMinefield As Boolean(,)
    Public Property revealedGrid As Boolean(,)
    Public Property flaggedGrid As Boolean(,)
    Public Property nearbyMineCounts As Integer(,)

    Public Sub InitializeBoard()
        ReDim placedMinefield(horizontalSize - 1, verticalSize - 1)
        ReDim revealedGrid(horizontalSize - 1, verticalSize - 1)
        ReDim flaggedGrid(horizontalSize - 1, verticalSize - 1)
        ReDim nearbyMineCounts(horizontalSize - 1, verticalSize - 1)
    End Sub

    Public Function IsInsideBoard(x As Integer, y As Integer) As Boolean
        Return x >= 0 AndAlso x < horizontalSize AndAlso y >= 0 AndAlso y < verticalSize
    End Function

End Class
