<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewBot))
        Me.combo_bottemplate = New System.Windows.Forms.ComboBox()
        Me.label_bottemplate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label_botname = New System.Windows.Forms.Label()
        Me.textbox_botname = New System.Windows.Forms.TextBox()
        Me.button_ok = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'combo_bottemplate
        '
        Me.combo_bottemplate.FormattingEnabled = True
        Me.combo_bottemplate.Items.AddRange(New Object() {"Basic Bot"})
        Me.combo_bottemplate.Location = New System.Drawing.Point(91, 115)
        Me.combo_bottemplate.Name = "combo_bottemplate"
        Me.combo_bottemplate.Size = New System.Drawing.Size(257, 21)
        Me.combo_bottemplate.TabIndex = 0
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Discord_Bot_Maker.My.Resources.Resources.new_bot
        Me.PictureBox1.Location = New System.Drawing.Point(144, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
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
        Me.textbox_botname.Size = New System.Drawing.Size(257, 20)
        Me.textbox_botname.TabIndex = 3
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(378, 139)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(75, 23)
        Me.button_ok.TabIndex = 4
        Me.button_ok.Text = "OK"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'NewBot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(465, 174)
        Me.Controls.Add(Me.button_ok)
        Me.Controls.Add(Me.textbox_botname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label_botname)
        Me.Controls.Add(Me.label_bottemplate)
        Me.Controls.Add(Me.combo_bottemplate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewBot"
        Me.Text = "NewBot"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combo_bottemplate As ComboBox
    Friend WithEvents label_bottemplate As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents label_botname As Label
    Friend WithEvents textbox_botname As TextBox
    Friend WithEvents button_ok As Button
End Class
