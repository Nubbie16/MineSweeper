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

    Public Property difficulty As String

    'Easy = 10 mines
    'Medium = 14 mines
    'Hard = 18 mines
    'Insane = 24 mines


    Public Function DetermineMineCount() As Integer

        Select Case difficulty
            Case "Easy"
                mineCount = 10
            Case "Medium"
                mineCount = 14
            Case "Hard"
                mineCount = 18
            Case "Insane"
                mineCount = 24
        End Select

        Return mineCount

    End Function

End Class
