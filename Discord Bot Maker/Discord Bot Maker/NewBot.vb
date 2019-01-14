Imports System.IO
Imports System.IO.Compression

Public Class NewBot
    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click

        Dim NewBot = textbox_botname.Text.ToString
        Dim NewBotDir = DiscordBotMaker.botdir.ToString + "\" + textbox_botname.Text.ToString
        ''Dim Template = combo_bottemplate.SelectedText.ToString + "_bot.zip"

        MkDir(NewBotDir)

        ZipFile.ExtractToDirectory("./node.zip", NewBotDir + "/bin")
        ZipFile.ExtractToDirectory("./batch_files.zip", NewBotDir)
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
            "BotToken=" + BotToken_Raw ''textbox_bottoken.Text.ToString
        }

        Dim dependenciesBat() As String = {
            "@echo off",
            "cls",
            "SET bot_directory=" + NewBotDir,
            "cd %bot_directory%",
            "echo Installing Dependencies!",
            "npm install ffmpeg --save",
            "npm install request --save",
            "npm install node-opus --save",
            "npm install opusscript --save",
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
            "SET /p bot_name=",
            "SET /p ",
            "SET bot_directory=" + NewBotDir,
            "SET bin=" + binLoc,
            "SET node_executable=%bin%" + node_executable,
            "SET /p bot_version=",
            "SET /p bot_author=",
            "cd %bot_directory%",
            "cd bin",
            "npm i npm",
            "npm install discord.js",
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
    End Sub
End Class