<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewBot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewBot))
        Me.combo_bottemplate = New System.Windows.Forms.ComboBox()
        Me.label_bottemplate = New System.Windows.Forms.Label()
        Me.label_botname = New System.Windows.Forms.Label()
        Me.textbox_botname = New System.Windows.Forms.TextBox()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.label_author = New System.Windows.Forms.Label()
        Me.textbox_author = New System.Windows.Forms.TextBox()
        Me.textbox_bottoken = New System.Windows.Forms.TextBox()
        Me.label_bottoken = New System.Windows.Forms.Label()
        Me.label_tokenwarning = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxRP = New System.Windows.Forms.GroupBox()
        Me.CheckBoxRP = New System.Windows.Forms.CheckBox()
        Me.RadioButtonRP_Playing = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRP_Watching = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRP_Streaming = New System.Windows.Forms.RadioButton()
        Me.TextBoxRP_Text = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRP.SuspendLayout()
        Me.SuspendLayout()
        '
        'combo_bottemplate
        '
        Me.combo_bottemplate.Enabled = False
        Me.combo_bottemplate.FormattingEnabled = True
        Me.combo_bottemplate.Items.AddRange(New Object() {"basic"})
        Me.combo_bottemplate.Location = New System.Drawing.Point(91, 115)
        Me.combo_bottemplate.Name = "combo_bottemplate"
        Me.combo_bottemplate.Size = New System.Drawing.Size(274, 21)
        Me.combo_bottemplate.TabIndex = 0
        Me.combo_bottemplate.Text = "basic"
        '
        'label_bottemplate
        '
        Me.label_bottemplate.AutoSize = True
        Me.label_bottemplate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_bottemplate.Location = New System.Drawing.Point(12, 118)
        Me.label_bottemplate.Name = "label_bottemplate"
        Me.label_bottemplate.Size = New System.Drawing.Size(73, 13)
        Me.label_bottemplate.TabIndex = 1
        Me.label_bottemplate.Text = "Bot Template:"
        '
        'label_botname
        '
        Me.label_botname.AutoSize = True
        Me.label_botname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_botname.Location = New System.Drawing.Point(12, 87)
        Me.label_botname.Name = "label_botname"
        Me.label_botname.Size = New System.Drawing.Size(57, 13)
        Me.label_botname.TabIndex = 1
        Me.label_botname.Text = "Bot Name:"
        '
        'textbox_botname
        '
        Me.textbox_botname.Location = New System.Drawing.Point(91, 84)
        Me.textbox_botname.Name = "textbox_botname"
        Me.textbox_botname.Size = New System.Drawing.Size(274, 20)
        Me.textbox_botname.TabIndex = 3
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(613, 339)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(75, 23)
        Me.button_ok.TabIndex = 4
        Me.button_ok.Text = "OK"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'label_author
        '
        Me.label_author.AutoSize = True
        Me.label_author.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_author.Location = New System.Drawing.Point(384, 87)
        Me.label_author.Name = "label_author"
        Me.label_author.Size = New System.Drawing.Size(41, 13)
        Me.label_author.TabIndex = 1
        Me.label_author.Text = "Author:"
        '
        'textbox_author
        '
        Me.textbox_author.Location = New System.Drawing.Point(431, 84)
        Me.textbox_author.Name = "textbox_author"
        Me.textbox_author.Size = New System.Drawing.Size(257, 20)
        Me.textbox_author.TabIndex = 3
        '
        'textbox_bottoken
        '
        Me.textbox_bottoken.Location = New System.Drawing.Point(91, 142)
        Me.textbox_bottoken.Name = "textbox_bottoken"
        Me.textbox_bottoken.Size = New System.Drawing.Size(428, 20)
        Me.textbox_bottoken.TabIndex = 6
        '
        'label_bottoken
        '
        Me.label_bottoken.AutoSize = True
        Me.label_bottoken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_bottoken.Location = New System.Drawing.Point(12, 142)
        Me.label_bottoken.Name = "label_bottoken"
        Me.label_bottoken.Size = New System.Drawing.Size(60, 13)
        Me.label_bottoken.TabIndex = 5
        Me.label_bottoken.Text = "Bot Token:"
        '
        'label_tokenwarning
        '
        Me.label_tokenwarning.AutoSize = True
        Me.label_tokenwarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_tokenwarning.Location = New System.Drawing.Point(525, 145)
        Me.label_tokenwarning.Name = "label_tokenwarning"
        Me.label_tokenwarning.Size = New System.Drawing.Size(136, 13)
        Me.label_tokenwarning.TabIndex = 5
        Me.label_tokenwarning.Text = "WARNING: Not encrypted!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Discord_Bot_Maker.My.Resources.Resources.new_bot
        Me.PictureBox1.Location = New System.Drawing.Point(264, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBoxRP
        '
        Me.GroupBoxRP.Controls.Add(Me.RadioButtonRP_Streaming)
        Me.GroupBoxRP.Controls.Add(Me.RadioButtonRP_Watching)
        Me.GroupBoxRP.Controls.Add(Me.RadioButtonRP_Playing)
        Me.GroupBoxRP.Controls.Add(Me.TextBoxRP_Text)
        Me.GroupBoxRP.Enabled = False
        Me.GroupBoxRP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.GroupBoxRP.Location = New System.Drawing.Point(15, 202)
        Me.GroupBoxRP.Name = "GroupBoxRP"
        Me.GroupBoxRP.Size = New System.Drawing.Size(453, 50)
        Me.GroupBoxRP.TabIndex = 7
        Me.GroupBoxRP.TabStop = False
        Me.GroupBoxRP.Text = "Ritch Presence"
        '
        'CheckBoxRP
        '
        Me.CheckBoxRP.AutoSize = True
        Me.CheckBoxRP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.CheckBoxRP.Location = New System.Drawing.Point(15, 176)
        Me.CheckBoxRP.Name = "CheckBoxRP"
        Me.CheckBoxRP.Size = New System.Drawing.Size(132, 17)
        Me.CheckBoxRP.TabIndex = 8
        Me.CheckBoxRP.Text = "Enable Rich Presence"
        Me.CheckBoxRP.UseVisualStyleBackColor = True
        '
        'RadioButtonRP_Playing
        '
        Me.RadioButtonRP_Playing.AutoSize = True
        Me.RadioButtonRP_Playing.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonRP_Playing.Name = "RadioButtonRP_Playing"
        Me.RadioButtonRP_Playing.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonRP_Playing.TabIndex = 9
        Me.RadioButtonRP_Playing.TabStop = True
        Me.RadioButtonRP_Playing.Text = "Playing"
        Me.RadioButtonRP_Playing.UseVisualStyleBackColor = True
        '
        'RadioButtonRP_Watching
        '
        Me.RadioButtonRP_Watching.AutoSize = True
        Me.RadioButtonRP_Watching.Location = New System.Drawing.Point(71, 19)
        Me.RadioButtonRP_Watching.Name = "RadioButtonRP_Watching"
        Me.RadioButtonRP_Watching.Size = New System.Drawing.Size(71, 17)
        Me.RadioButtonRP_Watching.TabIndex = 9
        Me.RadioButtonRP_Watching.TabStop = True
        Me.RadioButtonRP_Watching.Text = "Watching"
        Me.RadioButtonRP_Watching.UseVisualStyleBackColor = True
        '
        'RadioButtonRP_Streaming
        '
        Me.RadioButtonRP_Streaming.AutoSize = True
        Me.RadioButtonRP_Streaming.Location = New System.Drawing.Point(148, 19)
        Me.RadioButtonRP_Streaming.Name = "RadioButtonRP_Streaming"
        Me.RadioButtonRP_Streaming.Size = New System.Drawing.Size(72, 17)
        Me.RadioButtonRP_Streaming.TabIndex = 9
        Me.RadioButtonRP_Streaming.TabStop = True
        Me.RadioButtonRP_Streaming.Text = "Streaming"
        Me.RadioButtonRP_Streaming.UseVisualStyleBackColor = True
        '
        'TextBoxRP_Text
        '
        Me.TextBoxRP_Text.Location = New System.Drawing.Point(226, 19)
        Me.TextBoxRP_Text.Name = "TextBoxRP_Text"
        Me.TextBoxRP_Text.Size = New System.Drawing.Size(206, 20)
        Me.TextBoxRP_Text.TabIndex = 3
        '
        'NewBot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 374)
        Me.Controls.Add(Me.CheckBoxRP)
        Me.Controls.Add(Me.GroupBoxRP)
        Me.Controls.Add(Me.textbox_bottoken)
        Me.Controls.Add(Me.label_tokenwarning)
        Me.Controls.Add(Me.label_bottoken)
        Me.Controls.Add(Me.button_ok)
        Me.Controls.Add(Me.textbox_author)
        Me.Controls.Add(Me.textbox_botname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label_author)
        Me.Controls.Add(Me.label_botname)
        Me.Controls.Add(Me.label_bottemplate)
        Me.Controls.Add(Me.combo_bottemplate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewBot"
        Me.Text = "NewBot"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRP.ResumeLayout(False)
        Me.GroupBoxRP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combo_bottemplate As ComboBox
    Friend WithEvents label_bottemplate As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents label_botname As Label
    Friend WithEvents textbox_botname As TextBox
    Friend WithEvents button_ok As Button
    Friend WithEvents label_author As Label
    Friend WithEvents textbox_author As TextBox
    Friend WithEvents textbox_bottoken As TextBox
    Friend WithEvents label_bottoken As Label
    Friend WithEvents label_tokenwarning As Label
    Friend WithEvents GroupBoxRP As GroupBox
    Friend WithEvents CheckBoxRP As CheckBox
    Friend WithEvents RadioButtonRP_Streaming As RadioButton
    Friend WithEvents RadioButtonRP_Watching As RadioButton
    Friend WithEvents RadioButtonRP_Playing As RadioButton
    Friend WithEvents TextBoxRP_Text As TextBox
End Class
