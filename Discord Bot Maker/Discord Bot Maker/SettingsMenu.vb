Public Class SettingsMenu
    Private Sub button_updates_Click(sender As Object, e As EventArgs) Handles button_updates.Click
        MsgBox("WORK IN PROGRESS!!!")
    End Sub

    Private Sub button_about_Click(sender As Object, e As EventArgs) Handles button_about.Click
        AboutBox.Show()
    End Sub
    Private Sub button_apply_Click(sender As Object, e As EventArgs) Handles button_apply.Click
        If checkbox_console.Checked.Equals(True) Then
            Settings.Default.enable_console.Equals(True)
        End If
        If checkbox_console.Checked.Equals(False) Then
            Settings.Default.enable_console.Equals(False)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        AutoUpdater.Show()
    End Sub

    Private Sub SettingsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Settings.Default.enable_console.Equals(True) Then
            checkbox_console.Equals(True)
        End If
        If Settings.Default.Equals(False) Then
            checkbox_console.Equals(False)
        End If

    End Sub

    Private Sub SettingsMenu_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Settings.Default.Save()
    End Sub

End Class