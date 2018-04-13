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
        Me.button_updates = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_updates
        '
        Me.button_updates.Location = New System.Drawing.Point(372, 235)
        Me.button_updates.Name = "button_updates"
        Me.button_updates.Size = New System.Drawing.Size(66, 23)
        Me.button_updates.TabIndex = 0
        Me.button_updates.Text = "Updates"
        Me.button_updates.UseVisualStyleBackColor = True
        '
        'SettingsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 270)
        Me.Controls.Add(Me.button_updates)
        Me.Name = "SettingsMenu"
        Me.Text = "SettingsMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_updates As Button
End Class
