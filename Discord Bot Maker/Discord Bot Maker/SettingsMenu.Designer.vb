<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsMenu))
        Me.button_updates = New System.Windows.Forms.Button()
        Me.button_about = New System.Windows.Forms.Button()
        Me.checkbox_console = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button_apply = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button_updates
        '
        Me.button_updates.Location = New System.Drawing.Point(12, 143)
        Me.button_updates.Name = "button_updates"
        Me.button_updates.Size = New System.Drawing.Size(66, 23)
        Me.button_updates.TabIndex = 0
        Me.button_updates.Text = "Updates"
        Me.button_updates.UseVisualStyleBackColor = True
        '
        'button_about
        '
        Me.button_about.Location = New System.Drawing.Point(84, 143)
        Me.button_about.Name = "button_about"
        Me.button_about.Size = New System.Drawing.Size(66, 23)
        Me.button_about.TabIndex = 0
        Me.button_about.Text = "About"
        Me.button_about.UseVisualStyleBackColor = True
        '
        'checkbox_console
        '
        Me.checkbox_console.AutoSize = True
        Me.checkbox_console.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.checkbox_console.Location = New System.Drawing.Point(12, 76)
        Me.checkbox_console.Name = "checkbox_console"
        Me.checkbox_console.Size = New System.Drawing.Size(100, 17)
        Me.checkbox_console.TabIndex = 1
        Me.checkbox_console.Text = "Enable Console"
        Me.checkbox_console.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'button_apply
        '
        Me.button_apply.Location = New System.Drawing.Point(156, 143)
        Me.button_apply.Name = "button_apply"
        Me.button_apply.Size = New System.Drawing.Size(66, 23)
        Me.button_apply.TabIndex = 0
        Me.button_apply.Text = "Apply"
        Me.button_apply.UseVisualStyleBackColor = True
        '
        'SettingsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(229, 178)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.checkbox_console)
        Me.Controls.Add(Me.button_apply)
        Me.Controls.Add(Me.button_about)
        Me.Controls.Add(Me.button_updates)
        Me.Name = "SettingsMenu"
        Me.Text = "SettingsMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_updates As Button
    Friend WithEvents button_about As Button
    Friend WithEvents checkbox_console As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents button_apply As Button
End Class
