'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: Game.vb
'Description: This class will represent the game for the MineSweeper game.
'             It will handle the game board and the placement of mines.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Public Class Game

    Public Property verticalSize As Integer = 11
    Public Property horizontalSize As Integer = 8
    Public Property mineCount As Integer

    Public Property easyDifficulty As Boolean = False         '10 mines
    Public Property mediumDifficulty As Boolean = False       '14 mines
    Public Property hardDifficulty As Boolean = False         '18 mines
    Public Property insaneDifficulty As Boolean = False       '24 mines


    Public Sub DetermineMineCount()
        If easyDifficulty Then
            mineCount = 10
        ElseIf mediumDifficulty Then
            mineCount = 14
        ElseIf hardDifficulty Then
            mineCount = 18
        ElseIf insaneDifficulty Then
            mineCount = 24
        End If
    End Sub

End Class
