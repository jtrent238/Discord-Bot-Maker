Imports SharpRaven.Data

Public Class SettingsMenu

    Dim ravenClient = DiscordBotMaker.ravenClient

    Private Sub button_updates_Click(sender As Object, e As EventArgs) Handles button_updates.Click
        Try
            MsgBox("WORK IN PROGRESS!!!")
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub button_about_Click(sender As Object, e As EventArgs) Handles button_about.Click
        Try
            AboutBox.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
    Private Sub button_apply_Click(sender As Object, e As EventArgs) Handles button_apply.Click
        Try
            If checkbox_console.Checked.Equals(True) Then
                Settings.Default.enable_console.Equals(True)
            End If
            If checkbox_console.Checked.Equals(False) Then
                Settings.Default.enable_console.Equals(False)
            End If
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            AutoUpdater.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub SettingsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If Settings.Default.enable_console.Equals(True) Then
                checkbox_console.Equals(True)
            End If
            If Settings.Default.Equals(False) Then
                checkbox_console.Equals(False)
            End If
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub SettingsMenu_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Try
            Settings.Default.Save()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

End Class