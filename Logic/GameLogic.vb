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

    Public Sub DetermineFieldNumbers(board As Gameboard)

        ReDim board.placedProximityNums(board.horizontalSize - 1, board.verticalSize - 1)

        For x As Integer = 0 To board.horizontalSize - 1
            For y As Integer = 0 To board.verticalSize - 1

                Dim proximityCount As Integer = 0

                If board.placedMines(x, y) = False Then

                    proximityCount = ProximityHelper(board, x, y)
                    board.placedProximityNums(x, y) = proximityCount
                End If
            Next
        Next
    End Sub

End Module
