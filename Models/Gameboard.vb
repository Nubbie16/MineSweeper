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

    'The blank grid field that is associated with the provided
    'vertical and horizontal sizes(proactive for future updates on
    'selecting different diminsons)
    Public Property cellGrid As Button(,)

    Public Property placedMines As Boolean(,)
    Public Property placedMineGrid As Button(,)

    Public Property flaggedGrid As Boolean(,)

    Public Property placedProximityNums As Integer(,)
    Public Property proximityGrid As Button(,)

    Public Property revealedGrid As Button(,)

    Public Function IsInsideBoard(x As Integer, y As Integer) As Boolean
        Return x >= 0 AndAlso x < horizontalSize AndAlso y >= 0 AndAlso y < verticalSize
    End Function

End Class
