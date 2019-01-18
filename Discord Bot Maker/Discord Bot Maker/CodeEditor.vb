Imports SharpRaven.Data

Public Class CodeEditor

    Dim ravenClient = DiscordBotMaker.ravenClient

    Private Sub button_startbot_Click(sender As Object, e As EventArgs) Handles button_startbot.Click
        Try
            button_stopbot.Enabled.Equals(True)
            Me.Enabled.Equals(False)
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = DiscordBotMaker.SelectedBotDir + "/launch_bot.bat"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub button_stopbot_Click(sender As Object, e As EventArgs) Handles button_stopbot.Click
        Try
            button_startbot.Enabled.Equals(True)
            Me.Enabled.Equals(False)
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = DiscordBotMaker.SelectedBotDir + "/killbot.bat"
            ''startInfo.Verb = "runas"
            ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub button_installdependencies_Click(sender As Object, e As EventArgs) Handles button_installdependencies.Click
        Try
            Dim startInfo As New ProcessStartInfo()
            Dim myprocess As New Process()
            startInfo.FileName = DiscordBotMaker.SelectedBotDir + "/install_dependencies.bat"
            startInfo.Verb = "runas"
            startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
            myprocess.StartInfo = startInfo
            myprocess.Start()
        Catch Exception As Exception
            ravenClient.Capture(New SentryEvent(Exception))
        End Try
    End Sub

    Private Sub CodeEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Settings.Default.enable_console.Equals(True) Then
                button_console.Enabled = True
            End If
            If Settings.Default.enable_console.Equals(False) Then
                button_console.Enabled = False
            End If
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub button_console_Click(sender As Object, e As EventArgs) Handles button_console.Click
        Try
            ConsoleLog.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class