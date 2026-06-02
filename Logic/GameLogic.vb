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

    Public Sub RevealTile(board As Gameboard, x As Integer, y As Integer)

        Dim hor As Integer = board.horizontalSize - 1
        Dim vert As Integer = board.verticalSize - 1

        If board.IsInsideBoard(x, y) Then
            If board.placedMines(x, y) Then
                'Mine hit, game over
                GameLostSequence(board, x, y)
                End
            ElseIf board.placedProximityNums(x, y) > 0 Then
                RevealProximityFlag(board, x, y)
            Else
                RevealEmptyTile(board, x, y)
            End If
        End If

    End Sub

End Module
