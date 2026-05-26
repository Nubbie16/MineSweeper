'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: Player.vb
'Description: This class will represent a player in the MineSweeper game. It will
'             store the player's name and their best completion time for the game.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Public Class Player

    Public Property name As String
    Public Property difficulty As String
    Public Property complitionTime As TimeSpan
    Public Property avatar As Image

End Class
