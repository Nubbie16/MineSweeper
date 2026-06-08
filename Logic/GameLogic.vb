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

    Public Sub CheckWinCondition(board As Gameboard, minefieldForm As Minefield)

        If CheckAllCells(board) Then
            minefieldForm.ScoreTimerStop()
            board.player.completionTime = minefieldForm.currentTime
            MessageBox.Show("Congratulations! You cleared the minefield in " &
                 minefieldForm.currentTime.ToString("hh\:mm\:ss\.ff") & "!", "Mine Sweeper")
        End If

    End Sub

    Public Function CheckAllCells(board As Gameboard) As Boolean

        If AllMinesFlagged(board) OrElse AllNonMineCellsRevealed(board) Then
            Return True
        End If

        Return False


    End Function

    Public Function AllMinesFlagged(board As Gameboard) As Boolean

        For col As Integer = 0 To board.horizontalSize - 1
            For row As Integer = 0 To board.verticalSize - 1
                If board.flaggedGrid(col, row) <> board.placedMines(col, row) Then  'Cleaner version of: If the cell is flagged but not a mine,
                    'or if the cell is a mine but not flagged, then return False
                    Return False
                End If
            Next
        Next

        Return True

    End Function

    Public Function AllNonMineCellsRevealed(board As Gameboard) As Boolean

        For col As Integer = 0 To board.horizontalSize - 1
            For row As Integer = 0 To board.verticalSize - 1
                If Not board.placedMines(col, row) AndAlso Not board.revealedCells(col, row) Then
                    Return False
                End If
            Next
        Next

        Return True

    End Function

End Module
