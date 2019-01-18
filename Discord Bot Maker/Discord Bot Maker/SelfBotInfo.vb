Public Class SelfBotInfo
    Private Sub SelfBotInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub linklabel_selfBotLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabel_selfBotLink.LinkClicked
        Dim webAddress As String = "https://support.discordapp.com/hc/en-us/articles/115002192352"
        Process.Start(webAddress)
    End Sub

    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        If CheckBoxAgreeTOSUsage.Checked Then Me.Close()
        If CheckBoxAgreeTOSUsage.Checked Then MsgBox("Thanks for agreeing!")
        If CheckBoxAgreeTOSUsage.Checked = False Then MsgBox("You must agree!")
    End Sub
End Class