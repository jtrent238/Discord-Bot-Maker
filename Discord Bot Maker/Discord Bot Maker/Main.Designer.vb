<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiscordBotMaker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiscordBotMaker))
        Me.label_version = New System.Windows.Forms.Label()
        Me.button_newbot = New System.Windows.Forms.Button()
        Me.list_mybots = New System.Windows.Forms.ListView()
        Me.header_botname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.header_botversion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.button_deletebot = New System.Windows.Forms.Button()
        Me.button_editbot = New System.Windows.Forms.Button()
        Me.button_botinfo = New System.Windows.Forms.Button()
        Me.label_lastboteditedlabel = New System.Windows.Forms.Label()
        Me.label_lastbotedited = New System.Windows.Forms.Label()
        Me.button_settings = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.button_codeeditor = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_version
        '
        Me.label_version.AutoSize = True
        Me.label_version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_version.Location = New System.Drawing.Point(9, 250)
        Me.label_version.Name = "label_version"
        Me.label_version.Size = New System.Drawing.Size(49, 13)
        Me.label_version.TabIndex = 1
        Me.label_version.Text = "{version}"
        '
        'button_newbot
        '
        Me.button_newbot.Location = New System.Drawing.Point(565, 240)
        Me.button_newbot.Name = "button_newbot"
        Me.button_newbot.Size = New System.Drawing.Size(75, 23)
        Me.button_newbot.TabIndex = 2
        Me.button_newbot.Text = "New Bot"
        Me.button_newbot.UseVisualStyleBackColor = True
        '
        'list_mybots
        '
        Me.list_mybots.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.header_botname, Me.header_botversion})
        Me.list_mybots.Location = New System.Drawing.Point(293, 51)
        Me.list_mybots.Name = "list_mybots"
        Me.list_mybots.Size = New System.Drawing.Size(347, 183)
        Me.list_mybots.TabIndex = 3
        Me.list_mybots.UseCompatibleStateImageBehavior = False
        Me.list_mybots.View = System.Windows.Forms.View.List
        '
        'button_deletebot
        '
        Me.button_deletebot.Location = New System.Drawing.Point(484, 240)
        Me.button_deletebot.Name = "button_deletebot"
        Me.button_deletebot.Size = New System.Drawing.Size(75, 23)
        Me.button_deletebot.TabIndex = 2
        Me.button_deletebot.Text = "Delete Bot"
        Me.button_deletebot.UseVisualStyleBackColor = True
        '
        'button_editbot
        '
        Me.button_editbot.Location = New System.Drawing.Point(403, 240)
        Me.button_editbot.Name = "button_editbot"
        Me.button_editbot.Size = New System.Drawing.Size(75, 23)
        Me.button_editbot.TabIndex = 2
        Me.button_editbot.Text = "Edit Bot"
        Me.button_editbot.UseVisualStyleBackColor = True
        '
        'button_botinfo
        '
        Me.button_botinfo.Location = New System.Drawing.Point(322, 240)
        Me.button_botinfo.Name = "button_botinfo"
        Me.button_botinfo.Size = New System.Drawing.Size(75, 23)
        Me.button_botinfo.TabIndex = 2
        Me.button_botinfo.Text = "Edit Bot Info"
        Me.button_botinfo.UseVisualStyleBackColor = True
        '
        'label_lastboteditedlabel
        '
        Me.label_lastboteditedlabel.AutoSize = True
        Me.label_lastboteditedlabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_lastboteditedlabel.Location = New System.Drawing.Point(9, 85)
        Me.label_lastboteditedlabel.Name = "label_lastboteditedlabel"
        Me.label_lastboteditedlabel.Size = New System.Drawing.Size(85, 13)
        Me.label_lastboteditedlabel.TabIndex = 1
        Me.label_lastboteditedlabel.Text = "Last Bot Edited: "
        '
        'label_lastbotedited
        '
        Me.label_lastbotedited.AutoSize = True
        Me.label_lastbotedited.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_lastbotedited.Location = New System.Drawing.Point(92, 85)
        Me.label_lastbotedited.Name = "label_lastbotedited"
        Me.label_lastbotedited.Size = New System.Drawing.Size(81, 13)
        Me.label_lastbotedited.TabIndex = 1
        Me.label_lastbotedited.Text = "{last_botedited}"
        '
        'button_settings
        '
        Me.button_settings.BackgroundImage = Global.Discord_Bot_Maker.My.Resources.Resources.gear_settings
        Me.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_settings.Location = New System.Drawing.Point(293, 240)
        Me.button_settings.Name = "button_settings"
        Me.button_settings.Size = New System.Drawing.Size(23, 23)
        Me.button_settings.TabIndex = 2
        Me.button_settings.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Discord_Bot_Maker.My.Resources.Resources.botmaker_logo
        Me.PictureBox1.Location = New System.Drawing.Point(68, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Discord_Bot_Maker.My.Resources.Resources.discord_logo
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'button_codeeditor
        '
        Me.button_codeeditor.Location = New System.Drawing.Point(212, 240)
        Me.button_codeeditor.Name = "button_codeeditor"
        Me.button_codeeditor.Size = New System.Drawing.Size(75, 23)
        Me.button_codeeditor.TabIndex = 2
        Me.button_codeeditor.Text = "Code Editor"
        Me.button_codeeditor.UseVisualStyleBackColor = True
        '
        'DiscordBotMaker
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(652, 272)
        Me.Controls.Add(Me.list_mybots)
        Me.Controls.Add(Me.button_settings)
        Me.Controls.Add(Me.button_codeeditor)
        Me.Controls.Add(Me.button_botinfo)
        Me.Controls.Add(Me.button_editbot)
        Me.Controls.Add(Me.button_deletebot)
        Me.Controls.Add(Me.button_newbot)
        Me.Controls.Add(Me.label_lastbotedited)
        Me.Controls.Add(Me.label_lastboteditedlabel)
        Me.Controls.Add(Me.label_version)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DiscordBotMaker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents label_version As Label
    Friend WithEvents button_newbot As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents list_mybots As ListView
    Friend WithEvents button_deletebot As Button
    Friend WithEvents header_botname As ColumnHeader
    Friend WithEvents header_botversion As ColumnHeader
    Friend WithEvents button_editbot As Button
    Friend WithEvents button_botinfo As Button
    Friend WithEvents label_lastboteditedlabel As Label
    Friend WithEvents label_lastbotedited As Label
    Friend WithEvents button_settings As Button
    Friend WithEvents button_codeeditor As Button
End Class
