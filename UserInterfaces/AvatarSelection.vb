'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: AvatarSelection.vb
'Description: This is the form that will allow the player to select an avatar for their profile.
'             It will display a selection of avatars for the player to choose from and will save
'             the selected avatar to the player's game session.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper


Public Class AvatarSelection

    Public avatar As Image
    Public difficulty As String
    Public player As Player

    Public Sub New(difficulty As String)
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub gameStartBtn_Click(sender As Object, e As EventArgs) Handles gameStartBtn.Click

        player.name = playerText.Text
        player.avatar = bodyLayout.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked).Image
        player.difficulty = difficulty
        player.complitionTime = TimeSpan.Zero

        Dim minefield As New Minefield()
        minefield.Show()
        Me.Hide()
    End Sub



End Class