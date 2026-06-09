'Project Name: MineSweeper
'Purpose: MineSweeper game that stores high scores(fastest completion)
'File Name: SQLite.vb
'Description: This class will handle the SQLite database for the MineSweeper game.
'             It will store the player's name and their best completion time for the game.
'             It will also retrieve the high scores from the database to display on MainForm.
'Programmer: Cody Eckard
'Creation Date: May 25, 2026
'GitHub Repository: https://github.com/Nubbie16/MineSweeper



Imports System.Data.Common
Imports System.IO
Imports Microsoft.Data.Sqlite

Public Class SQLite

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
                                    completionTime INTEGER NOT NULL,
                                    PRIMARY KEY(ID AUTOINCREMENT)     )"

            Using cmd As New SqliteCommand(sqlCreateCMD, conn)
                cmd.ExecuteNonQuery()
            End Using

        End Using


    End Sub


End Class
