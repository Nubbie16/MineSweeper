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
    Public player As New Player()

    Public aliveAvatars As New List(Of Image) From {
        My.Resources.MBlAva88, My.Resources.MRedAva88, My.Resources.MBrAva88,
        My.Resources.FBlAva88, My.Resources.FRedAva88, My.Resources.FBrAva88}

    Public deadAvatars As New List(Of Image) From {
        My.Resources.MBlDead88, My.Resources.MRedDead88, My.Resources.MBrDead88,
        My.Resources.FBlDead88, My.Resources.FRedDead88, My.Resources.FBrDead88}

    Public Sub New(selectedDifficulty As String)
        ' This call is required by the designer.
        InitializeComponent()

        difficulty = selectedDifficulty
    End Sub

    Private Sub gameStartBtn_Click(sender As Object, e As EventArgs) Handles gameStartBtn.Click

        Dim selectedAvatar As RadioButton = bodyLayout.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked)

        player.difficulty = difficulty
        player.completionTime = TimeSpan.Zero

        If playerText.Text.Trim = "" Then

            MessageBox.Show("Please enter a name.", "Mine Sweeper")
            Exit Sub
        End If

        player.name = playerText.Text

        If selectedAvatar Is Nothing Then

            MessageBox.Show("Please select an avatar.", "Mine Sweeper")
            Exit Sub
        End If

        player.avatar = selectedAvatar.Image



        Select Case selectedAvatar.Name
            Case "maleBlondeRad"
                player.deadAvatar = My.Resources.MBlDead88
            Case "maleRedRad"
                player.deadAvatar = My.Resources.MRedDead88
            Case "maleBrownRad"
                player.deadAvatar = My.Resources.MBrDead88
            Case "femaleBlondeRad"
                player.deadAvatar = My.Resources.FBlDead88
            Case "femaleRedRad"
                player.deadAvatar = My.Resources.FRedDead88
            Case "femaleBrownRad"
                player.deadAvatar = My.Resources.FBrDead88
        End Select


        Dim minefield As New Minefield(player)
        minefield.Show()
        Me.Hide()
    End Sub



End Class