Imports System.IO

Public Class NewBot
    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click

        Dim NewBot = textbox_botname.Text.ToString

        MkDir(DiscordBotMaker.botdir.ToString + "\" + textbox_botname.Text.ToString)
        Dim BotToken_Raw = textbox_bottoken.Text.ToString
        Dim BotToken_Key = NETCore.Encrypt.EncryptProvider.CreateAesKey
        Dim BotToken_Encrypted = NETCore.Encrypt.EncryptProvider.AESEncrypt(BotToken_Raw.ToString, BotToken_Key.ToString)
        Dim BotToken_Decrypted = NETCore.Encrypt.EncryptProvider.AESDecrypt(BotToken_Encrypted, BotToken_Key.ToString)

        ' Create a string array with the lines of text
        Dim lines() As String = {
            "BotName=" + NewBot,
            "BotTemplate=" + combo_bottemplate.SelectedText.ToString,
            "Author=" + textbox_author.Text.ToString,
            "BotToken=" + BotToken_Encrypted ''textbox_bottoken.Text.ToString
        }

        ' Set a variable to the My Documents path.
        Dim mydocpath As String = DiscordBotMaker.botdir

        ' Write the string array to a new file named "WriteLines.txt".
        Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\" + NewBot + "\" + NewBot + DiscordBotMaker.BotSaveFileExt))
            For Each line As String In lines
                outputFile.WriteLine(line)
            Next
        End Using

        ' Set a variable to the My Documents path.
        Dim mydocpath1 As String = DiscordBotMaker.dir

        ' Write the string array to a new file named "WriteLines.txt".
        Using outputFile As New StreamWriter(mydocpath1 & Convert.ToString("\" + "Bots" + DiscordBotMaker.BotSaveFileExt))
            outputFile.Write(NewBot.ToString)
        End Using

        ' Set a variable to the My Documents path.
        Dim mydocpath2 As String = DiscordBotMaker.dir

        ' Write the string array to a new file named "WriteLines.txt".
        Using outputFile As New StreamWriter(mydocpath2 & Convert.ToString("\" + "last_bot_edited" + DiscordBotMaker.BotSaveFileExt))
            outputFile.Write(NewBot.ToString)
        End Using

        DiscordBotMaker.list_mybots.Items.Add(NewBot)

        MsgBox("Bot Created!")
        Me.Close()
    End Sub
End Class