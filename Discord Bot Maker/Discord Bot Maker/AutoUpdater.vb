Imports System.IO

Public Class AutoUpdater

    Private Sub AutoUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_current_version.Text = My.Application.Info.Version.ToString

        Try
            ' Create an instance of StreamReader to read from a file.
            ' The using statement also closes the StreamReader.
            Using sr As New StreamReader(DiscordBotMaker.DiscordBotMakerDir.ToString + "/newverfile" + DiscordBotMaker.DiscordBotMakerFileExt.ToString)
                Dim line As String
                ' Read and display lines from the file until the end of
                ' the file is reached.
                Do
                    line = sr.ReadLine()
                    If Not (line Is Nothing) Then
                        Console.WriteLine(line)
                        label_new_version.Text = line
                    End If
                Loop Until line Is Nothing
            End Using
        Catch ef As Exception
            ' Let the user know what went wrong.
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(ef.Message)
        End Try
    End Sub

    Private Sub button_updatenow_Click(sender As Object, e As EventArgs) Handles button_updatenow.Click
        MsgBox("WORK IN PROGRESS!!!")
    End Sub

    Private Sub button_updatelater_Click(sender As Object, e As EventArgs) Handles button_updatelater.Click
        MsgBox("WORK IN PROGRESS!!!")
    End Sub

End Class