'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: GameLogic.vb
'Description: This module will handle the logic for the MineSweeper game. It will determine
'             if a player has won or lost the game and will also handle the logic for revealing
'             tiles, checking for mines, and determining win or lose.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Module GameLogic


    'Easy = 10 mines
    'Medium = 14 mines
    'Hard = 18 mines
    'Insane = 24 mines

    Public Function DetermineMineCount(difficulty As String) As Integer

        Dim mineCount As Integer

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



End Module
