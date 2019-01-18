Imports SharpRaven.Data

Public Class SelfBotInfo

    Dim ravenClient = DiscordBotMaker.ravenClient

    Private Sub SelfBotInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ''code here
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub linklabel_selfBotLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabel_selfBotLink.LinkClicked
        Try
            Dim webAddress As String = "https://support.discordapp.com/hc/en-us/articles/115002192352"
            Process.Start(webAddress)
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        Try
            If CheckBoxAgreeTOSUsage.Checked Then Me.Close()
            If CheckBoxAgreeTOSUsage.Checked Then MsgBox("Thanks for agreeing!")
            If CheckBoxAgreeTOSUsage.Checked = False Then MsgBox("You must agree!")
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class