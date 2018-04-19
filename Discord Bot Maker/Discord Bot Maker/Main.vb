Imports System.IO

Public Class DiscordBotMaker

    Public DiscordBotMakerDir = dir
    Public dir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/jtrent238/Discord Bot Maker/"
    Public botdir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/jtrent238/Discord Bot Maker/bots"
    Public BotSaveFileExt = ".dbms"
    Public DiscordBotMakerFileExt = ".dbm"



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_version.Text = My.Application.Info.Version.ToString

        Dim url = "https://gist.githubusercontent.com/jtrent238/c798e2a638d6dc697a2e71c80a941004/raw/f1c854915e7761acc00e845bf3e85f3e8184e4e2/testfile"

        If File.Exists(dir + "/newverfile" + DiscordBotMakerFileExt.ToString) Then
            File.Delete(dir + "/newverfile" + DiscordBotMakerFileExt.ToString)
        Else
            My.Computer.Network.DownloadFile(url, dir + "/newverfile" + DiscordBotMakerFileExt.ToString)
        End If

        My.Computer.Network.DownloadFile(url, dir + "/newverfile" + DiscordBotMakerFileExt.ToString)

        Try
            ' Create an instance of StreamReader to read from a file.
            ' The using statement also closes the StreamReader.
            Using sr As New StreamReader(dir.ToString + "/last_bot_edited" + BotSaveFileExt.ToString)
                Dim line As String
                ' Read and display lines from the file until the end of
                ' the file is reached.
                Do
                    line = sr.ReadLine()
                    If Not (line Is Nothing) Then
                        Console.WriteLine(line)
                        label_lastbotedited.Text = line
                    End If
                Loop Until line Is Nothing
            End Using
        Catch ef As Exception
            ' Let the user know what went wrong.
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(ef.Message)
        End Try

        Try
            ' Create an instance of StreamReader to read from a file.
            ' The using statement also closes the StreamReader.
            Using sr As New StreamReader(dir.ToString + "/bots" + BotSaveFileExt.ToString)
                Dim line As String
                ' Read and display lines from the file until the end of
                ' the file is reached.
                Do
                    line = sr.ReadLine()
                    If Not (line Is Nothing) Then
                        Console.WriteLine(line)
                        list_mybots.Items.Add(line)
                    End If
                Loop Until line Is Nothing
            End Using
        Catch ef As Exception
            ' Let the user know what went wrong.
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(ef.Message)
        End Try

        Try
            Using sr As New StreamReader(DiscordBotMakerDir.ToString + "/newverfile" + DiscordBotMakerFileExt.ToString)
                Dim line As String
                ' Read and display lines from the file until the end of
                ' the file is reached.
                Do
                    line = sr.ReadLine()
                    If Not (line Is Nothing) Then
                        Console.WriteLine(line)
                        Dim newver = line
                    End If
                Loop Until line Is Nothing

                If My.Application.Info.Version.ToString = line Then
                    AutoUpdater.Show()
                Else Console.WriteLine("Error Getting update data")
                End If
            End Using
        Catch ef As Exception
            ' Let the user know what went wrong.
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(ef.Message)
        End Try


        ''Make Directories
        ''If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/jtrent238/Discord Bot Maker") Then
        ''    Console.Write("Directory """ + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/jtrent238/Discord Bot Maker" + "Already Exists")
        ''Else
        ''    MkDir(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/jtrent238/Discord Bot Maker")
        ''End If
        ''If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/jtrent238/Discord Bot Maker/saves") Then
        ''    Console.Write("Directory """ + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/jtrent238/Discord Bot Maker/saves" + " Already Exists")
        ''Else
        ''    MkDir(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/jtrent238/Discord Bot Maker/saves")
        ''End If

        Dim startInfo As New ProcessStartInfo()
        Dim myprocess As New Process()
        startInfo.FileName = ".\Node.js.5.3.0\content\.bin\node.cmd"
        ''startInfo.Verb = "runas"
        ''startInfo.Arguments = "/env /user:" + "Administrator" + " cmd"
        myprocess.StartInfo = startInfo
        myprocess.Start()

    End Sub

    Private Sub button_newbot_Click(sender As Object, e As EventArgs) Handles button_newbot.Click
        NewBot.Show()
    End Sub

    Private Sub button_settings_Click(sender As Object, e As EventArgs) Handles button_settings.Click
        SettingsMenu.Show()
    End Sub


End Class
