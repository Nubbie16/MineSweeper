'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: Game.vb
'Description: This class will represent the game for the MineSweeper game.
'             It will handle the game board and the placement of mines.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Public Class Gameboard

    Public Property verticalSize As Integer = 11
    Public Property horizontalSize As Integer = 8
    Public Property mineCount As Integer
    Public Property player As Player

    'Will be used to store the buttons for the gameboard.
    'Used as the open grid for the game. When a cell is revealed,
    'the button will be hidden and the revealed grid will be shown.
    Public Property cellGrid As Button(,)

    'Will be used to store the boolean values for the placement of mines.
    Public Property placedMines As Boolean(,)
    'Will be used to store the buttons for the revealed grid. When a cell is revealed,
    Public Property placedMineGrid As Button(,)

    'Will be used to store the boolean values for the placement of flags.
    Public Property flaggedGrid As Boolean(,)
    'Will be used to store the buttons for the revealed grid. This is the "master
    'grid that will be revealed when a cell is clicked. It will show the proximity numbers and mines.
    Public Property revealedGrid As Button(,)

    'Will be used to store the integer values for the proximity numbers. This will be
    'used to determine what number to display on the revealed grid when a cell is clicked.
    Public Property placedProximityNums As Integer(,)
    'Will be used to store the buttons for the proximity numbers. This will be
    'used to display the proximity numbers on the revealed grid when a cell is clicked.
    Public Property proximityGrid As Button(,)


    Public Function IsInsideBoard(x As Integer, y As Integer) As Boolean
        Return x >= 0 AndAlso x < horizontalSize AndAlso y >= 0 AndAlso y < verticalSize
    End Function

End Class
