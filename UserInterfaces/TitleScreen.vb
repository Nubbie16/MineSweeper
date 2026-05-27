'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: MainForm.vb
'Description: This is the main form for the MineSweeper game. It will display
'             the start button to begin a game and high scores based on completion time.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper

Public Class TitleScreen

    Dim difficulty As String

    Private Sub TitleScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''Display scores based on difficulty selection
        DisplayHighScore()

    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Private Sub newGameBtn_Click(sender As Object, e As EventArgs) Handles newGameBtn.Click

        If (difficultyCBO.SelectedItem Is Nothing) Then

            MessageBox.Show("Please select a difficulty.", "Mine Sweeper")
            Exit Sub
        End If

        difficulty = difficultyCBO.SelectedItem.ToString()

        Dim avatarSelection As New AvatarSelection(difficulty)
        avatarSelection.Show()
        Hide()
    End Sub


    Public Sub DisplayHighScore()               ''Will pull from SQLite file from database. Beforehand, database scores will need to be sorted Ascending by time

        Dim playerScores(9) As TimeSpan         ''Will change to Player class.

        ''Test Data
        Dim testPlayer As String = "Game Testie"

        For i As Integer = 0 To playerScores.Length - 1
            playerScores(i) = New TimeSpan(0, 0, i + 1, i + 5, i + 50)
        Next

        easyHighLV.Items.Clear()
        mediumHighLV.Items.Clear()
        hardHighLV.Items.Clear()
        insaneHighLV.Items.Clear()

        For Each score As TimeSpan In playerScores
            AddScoreToListView(easyHighLV, testPlayer, score)
            AddScoreToListView(mediumHighLV, testPlayer, score)
            AddScoreToListView(hardHighLV, testPlayer, score)
            AddScoreToListView(insaneHighLV, testPlayer, score)
        Next
    End Sub

End Class
