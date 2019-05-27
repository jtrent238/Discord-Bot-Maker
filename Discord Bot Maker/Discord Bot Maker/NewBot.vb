Imports System.IO
Imports System.IO.Compression
Imports FxResources.System.IO.Compression
Imports SharpRaven.Data

Public Class NewBot

    'Public NewBotDir2 = DiscordBotMaker.botdir.ToString + "\" + textbox_botname.Text.ToString
    Dim ravenClient = DiscordBotMaker.ravenClient
    Dim RPTypeSelected
    Private Sub NewBot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
    Private Sub RPSelected()
        If RadioButtonRP_Playing.Enabled = True Then
            Dim RPTypeSelected As String = "Playing"
        End If
        If RadioButtonRP_Streaming.Enabled = True Then
            Dim RPTypeSelected As String = "Streaming"
        End If
        If RadioButtonRP_Watching.Enabled = True Then
            Dim RPTypeSelected As String = "Watching"
        End If
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        Try
            Dim NewBot = textbox_botname.Text.ToString
            Dim NewBotDir = DiscordBotMaker.botdir.ToString + "\" + textbox_botname.Text.ToString
            ''Dim Template = combo_bottemplate.SelectedText.ToString + "_bot.zip"

            MkDir(NewBotDir)

            ZipFile.ExtractToDirectory("./node.zip", NewBotDir + "/bin")
            ''ZipFile.ExtractToDirectory("./batch_files.zip", NewBotDir)
            ZipFile.ExtractToDirectory("./basic_bot.zip", NewBotDir)

            If combo_bottemplate.SelectedText.ToString.Equals("") Then
                combo_bottemplate.SelectedText.ToString.Equals("basic")
            End If

            Dim BotToken_Raw = textbox_bottoken.Text.ToString
            'Dim BotToken_Key = NETCore.Encrypt.EncryptProvider.CreateAesKey
            ''Dim BotToken_Encrypted = NETCore.Encrypt.EncryptProvider.AESEncrypt(BotToken_Raw.ToString, BotToken_Key.ToString)
            ''Dim BotToken_Decrypted = NETCore.Encrypt.EncryptProvider.AESDecrypt(BotToken_Encrypted, BotToken_Key.ToString)

            ' Create a string array with the lines of text
            Dim lines() As String = {
                "BotName=" + NewBot,
                "BotTemplate=" + combo_bottemplate.SelectedText.ToString,
                "Author=" + textbox_author.Text.ToString,
                "BotToken=" + BotToken_Raw, ''textbox_bottoken.Text.ToString
                "RichPresenceType=" + RPTypeSelected.ToString +
                "RichPresenceText=" + TextBoxRP_Text.ToString
            }

            Dim dependenciesBat() As String = {
                "@echo off",
                "cls",
                "echo Installing Dependencies!",
                "npm install request --save",
                "npm install discord.js --save",
                "echo Dependencies Installed!",
                "pause> nul"
            }

            Dim killBotBat() As String = {
                "@echo off",
                "cls",
                "taskkill / f / im node.exe"
            }

            Dim binLoc = "/bin"
            Dim node_executable = "/node.exe"

            Dim launchBotBat() As String = {
                "@echo off",
                "cls",
                "title Bot Console",
                "echo Please wait while Dependencies are installed...",
                "start install_dependencies.bat",
                "echo Dependencies Installed...",
                "npm start app.js",
                "pause> nul"
            }

            ' Set a variable to the My Documents path.
            Dim mydocpath As String = DiscordBotMaker.botdir

            ' Write the string array to a new file named "WriteLines.txt".
            Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\" + NewBot + "\" + NewBot + DiscordBotMaker.BotSaveFileExt))
                For Each line As String In lines
                    outputFile.WriteLine(line)
                Next
            End Using

            ' Write the string array to a new file named "WriteLines.txt".
            Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\" + NewBot + "\" + "install_dependencies.bat"))
                For Each line As String In dependenciesBat
                    outputFile.WriteLine(line)
                Next
            End Using

            ' Write the string array to a new file named "WriteLines.txt".
            Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\" + NewBot + "\" + "killbot.bat"))
                For Each line As String In killBotBat
                    outputFile.WriteLine(line)
                Next
            End Using

            ' Write the string array to a new file named "WriteLines.txt".
            Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\" + NewBot + "\" + "launch_bot.bat"))
                For Each line As String In launchBotBat
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
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub CheckBoxRP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRP.CheckedChanged
        Try
            If Me.CheckBoxRP.Checked = True Then
                GroupBoxRP.Enabled = True
            ElseIf Me.CheckBoxRP.Checked = False Then
                GroupBoxRP.Enabled = False
            End If

        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class