'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: SQLite.vb
'Description: This class will handle the SQLite database for the MineSweeper game.
'             It will store the player's name and their best completion time for the game.
'             It will also retrieve the high scores from the database to display on MainForm.
'Programmer: Cody Eckard
'Creation Date: June 9, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper


Imports System.IO
Imports Microsoft.Data.Sqlite

Public Module SQLite

    Private ReadOnly appFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                      "MineSweeper")

    Private ReadOnly dbPath As String = Path.Combine(appFolder, "MineSweeper.db")

    Private ReadOnly connString As String = "Data Source=" & dbPath



    Public Sub OpenDB()

        Directory.CreateDirectory(appFolder)

        Using conn As New SqliteConnection(connString)

            conn.Open()

            Dim sqlCreateCMD As String = "CREATE TABLE IF NOT EXISTS HighScores (
                                    ID INTEGER NOT NULL UNIQUE,
                                    name TEXT NOT NULL,
                                    difficulty TEXT NOT NULL,
                                    completionMilli INTEGER NOT NULL,
                                    PRIMARY KEY(ID AUTOINCREMENT)     )"

            Using cmd As New SqliteCommand(sqlCreateCMD, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function ReadAllScores() As List(Of Player)

        Dim playerList As New List(Of Player)

        Using conn As SqliteConnection = New SqliteConnection(connString)
            conn.Open()

            Dim sqlReadCMD As String = "SELECT
                  ID, name, difficulty, completionMilli
                  FROM HighScores
                  ORDER BY completionMilli ASC
                  LIMIT 10"

            Using cmd As New SqliteCommand(sqlReadCMD, conn)

                cmd.ExecuteNonQuery()

                Using reader As SqliteDataReader = cmd.ExecuteReader()

                    While reader.Read()


                        Dim player As Player = New Player

                        player.ID = reader.GetInt32(0)
                        player.name = reader.GetString(1)
                        player.difficulty = reader.GetString(2)
                        player.completionMilli = reader.GetInt64(3)

                        playerList.Add(player)

                    End While

                End Using
            End Using
        End Using


        Return playerList

    End Function

    Public Sub AddScore(board As Gameboard)

        Using conn As SqliteConnection = New SqliteConnection(connString)
            conn.Open()

            Dim sqlAddCMD As String = "
                        INSERT INTO HighScores (name, difficulty, completionMilli)
                        VALUES (@name, @difficulty, @completionMilli)"

            Using cmd As New SqliteCommand(sqlAddCMD, conn)

                cmd.Parameters.AddWithValue("@name", board.player.name)
                cmd.Parameters.AddWithValue("@difficulty", board.player.difficulty)
                cmd.Parameters.AddWithValue("@completionMilli", board.player.completionMilli)

                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub



End Module
