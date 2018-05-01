Public Class CodeEditor
    Private Sub button_startbot_Click(sender As Object, e As EventArgs) Handles button_startbot.Click
        button_stopbot.Enabled.Equals(True)
        Me.Enabled.Equals(False)
        Dim startInfo As New ProcessStartInfo()
        Dim myprocess As New Process()
        startInfo.FileName = "launch_bot.bat"
        startInfo.Verb = "runas"
        startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
        myprocess.StartInfo = startInfo
        myprocess.Start()
    End Sub

    Private Sub button_stopbot_Click(sender As Object, e As EventArgs) Handles button_stopbot.Click
        button_startbot.Enabled.Equals(True)
        Me.Enabled.Equals(False)
        Dim startInfo As New ProcessStartInfo()
        Dim myprocess As New Process()
        startInfo.FileName = "killbot.bat"
        ''startInfo.Verb = "runas"
        ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
        myprocess.StartInfo = startInfo
        myprocess.Start()
    End Sub

    Private Sub button_installdependencies_Click(sender As Object, e As EventArgs) Handles button_installdependencies.Click
        Dim startInfo As New ProcessStartInfo()
        Dim myprocess As New Process()
        startInfo.FileName = "install_dependencies.bat"
        startInfo.Verb = "runas"
        startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
        myprocess.StartInfo = startInfo
        myprocess.Start()
    End Sub
End Class