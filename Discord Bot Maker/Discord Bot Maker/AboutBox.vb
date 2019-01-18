Imports SharpRaven.Data

Public NotInheritable Class AboutBox

    Dim ravenClient = DiscordBotMaker.ravenClient

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Set the title of the form.
            Dim ApplicationTitle As String
            If My.Application.Info.Title <> "" Then
                ApplicationTitle = My.Application.Info.Title
            Else
                ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            End If
            Me.Text = String.Format("About {0}", ApplicationTitle)
            ' Initialize all of the text displayed on the About Box.
            ' TODO: Customize the application's assembly information in the "Application" pane of the project 
            '    properties dialog (under the "Project" menu).
            Me.label_product_name.Text = My.Application.Info.ProductName
            Me.label_version_number.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
            'Me.LabelCopyright.Text = My.Application.Info.Copyright
            'Me.LabelCompanyName.Text = My.Application.Info.CompanyName
            Me.label_description.Text = My.Application.Info.Description
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_ok.Click
        Try
            Me.Close()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub linklabel_gethelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabel_gethelp.LinkClicked
        Try
            Dim webAddress As String = DiscordBotMaker.HelpLink.ToString
            Process.Start(webAddress)
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class
