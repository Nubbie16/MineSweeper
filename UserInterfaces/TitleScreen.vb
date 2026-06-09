'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: TitleScreen.vb
'Description: This is the main form for the MineSweeper game. It will display
'             the start button to begin a game and high scores based on completion time.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper


Public Class TitleScreen

    Dim difficulty As String


    Private Sub TitleScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''Display scores based on difficulty selection

        DisplayHighScore(SQLite.ReadAllScores())

    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        SQLite.OpenDB()

    End Sub

    Private Sub newGameBtn_Click(sender As Object, e As EventArgs) Handles newGameBtn.Click

        If (difficultyCBO.SelectedItem Is Nothing) Then

            MessageBox.Show("Please select a difficulty.", "Mine Sweeper")
            Exit Sub
        End If

        difficulty = difficultyCBO.SelectedItem.ToString().ToLower()


        Dim avatarSelection As New AvatarSelection(difficulty)
        avatarSelection.Show()
        Hide()
    End Sub


    Public Sub DisplayHighScore(playerScores As List(Of Player))              
        easyHighLV.Items.Clear()
        mediumHighLV.Items.Clear()
        hardHighLV.Items.Clear()
        insaneHighLV.Items.Clear()



        For Each player As Player In playerScores
            Select Case player.difficulty
                Case "easy"
                    AddScoreToListView(easyHighLV, player)
                Case "medium"
                    AddScoreToListView(mediumHighLV, player)
                Case "hard"
                    AddScoreToListView(hardHighLV, player)
                Case "insane"
                    AddScoreToListView(insaneHighLV, player)
            End Select
        Next
    End Sub

End Class
