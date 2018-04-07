Public Class DiscordBotMaker

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_version.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub button_newbot_Click(sender As Object, e As EventArgs) Handles button_newbot.Click
        NewBot.Show()
    End Sub


End Class
