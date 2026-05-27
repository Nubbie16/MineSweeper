'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: HighScoreHelper.vb
'Description: Helper file for related High Score functions and methods.
'Programmer: Cody Eckard
'Creation Date: May 27, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Module HighScoreHelper

    Public Sub AddScoreToListView(scoreList As ListView, playerName As String, score As TimeSpan)
        Dim item As New ListViewItem(playerName)
        item.SubItems.Add(score.ToString("hh\:mm\:ss\.ff"))

        item.Font = New Font(scoreList.Font.FontFamily, 9)      'sets only the names and times to size 9

        scoreList.Items.Add(item)
    End Sub

End Module
