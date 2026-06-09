'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: Player.vb
'Description: This class will represent a player in the MineSweeper game. It will
'             store the player's name and their best completion time for the game.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper


Public Class Player


    Public Property ID As Integer = 0       'placeholder for SQL PK
    Public Property name As String
    Public Property difficulty As String
    Public Property completionMilli As Long
    Public Property completionTime As TimeSpan
    Public Property avatar As Image
    Public Property deadAvatar As Image


    Public Function TimeSpanToMilliseconds(time As TimeSpan) As Long

        Return CLng(time.TotalMilliseconds)

    End Function



    Public Function MillisecondsToTimeSpan(milliseconds As Long) As TimeSpan

        Return TimeSpan.FromMilliseconds(milliseconds)

    End Function

End Class
