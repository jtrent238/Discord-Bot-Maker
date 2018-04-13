<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AutoUpdater
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
        Me.label_current_version = New System.Windows.Forms.Label()
        Me.label_new_version = New System.Windows.Forms.Label()
        Me.label_currentversion = New System.Windows.Forms.Label()
        Me.label_latestversion = New System.Windows.Forms.Label()
        Me.label_update_abailable = New System.Windows.Forms.Label()
        Me.button_updatenow = New System.Windows.Forms.Button()
        Me.button_updatelater = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'label_current_version
        '
        Me.label_current_version.AutoSize = True
        Me.label_current_version.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_current_version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_current_version.Location = New System.Drawing.Point(194, 77)
        Me.label_current_version.Name = "label_current_version"
        Me.label_current_version.Size = New System.Drawing.Size(175, 26)
        Me.label_current_version.TabIndex = 0
        Me.label_current_version.Text = "{current_version}"
        '
        'label_new_version
        '
        Me.label_new_version.AutoSize = True
        Me.label_new_version.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_new_version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_new_version.Location = New System.Drawing.Point(194, 103)
        Me.label_new_version.Name = "label_new_version"
        Me.label_new_version.Size = New System.Drawing.Size(148, 26)
        Me.label_new_version.TabIndex = 0
        Me.label_new_version.Text = "{new_version}"
        '
        'label_currentversion
        '
        Me.label_currentversion.AutoSize = True
        Me.label_currentversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_currentversion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_currentversion.Location = New System.Drawing.Point(12, 77)
        Me.label_currentversion.Name = "label_currentversion"
        Me.label_currentversion.Size = New System.Drawing.Size(176, 26)
        Me.label_currentversion.TabIndex = 0
        Me.label_currentversion.Text = "Current Version: "
        '
        'label_latestversion
        '
        Me.label_latestversion.AutoSize = True
        Me.label_latestversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_latestversion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_latestversion.Location = New System.Drawing.Point(16, 103)
        Me.label_latestversion.Name = "label_latestversion"
        Me.label_latestversion.Size = New System.Drawing.Size(163, 26)
        Me.label_latestversion.TabIndex = 0
        Me.label_latestversion.Text = "Latest Version: "
        '
        'label_update_abailable
        '
        Me.label_update_abailable.AutoSize = True
        Me.label_update_abailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_update_abailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_update_abailable.Location = New System.Drawing.Point(12, 9)
        Me.label_update_abailable.Name = "label_update_abailable"
        Me.label_update_abailable.Size = New System.Drawing.Size(349, 51)
        Me.label_update_abailable.TabIndex = 0
        Me.label_update_abailable.Text = "Update Available"
        '
        'button_updatenow
        '
        Me.button_updatenow.Location = New System.Drawing.Point(199, 138)
        Me.button_updatenow.Name = "button_updatenow"
        Me.button_updatenow.Size = New System.Drawing.Size(75, 23)
        Me.button_updatenow.TabIndex = 1
        Me.button_updatenow.Text = "Update Now"
        Me.button_updatenow.UseVisualStyleBackColor = True
        '
        'button_updatelater
        '
        Me.button_updatelater.Location = New System.Drawing.Point(282, 138)
        Me.button_updatelater.Name = "button_updatelater"
        Me.button_updatelater.Size = New System.Drawing.Size(84, 23)
        Me.button_updatelater.TabIndex = 1
        Me.button_updatelater.Text = "Update Later"
        Me.button_updatelater.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 138)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(158, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'AutoUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(378, 173)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.button_updatelater)
        Me.Controls.Add(Me.button_updatenow)
        Me.Controls.Add(Me.label_latestversion)
        Me.Controls.Add(Me.label_new_version)
        Me.Controls.Add(Me.label_update_abailable)
        Me.Controls.Add(Me.label_currentversion)
        Me.Controls.Add(Me.label_current_version)
        Me.Name = "AutoUpdater"
        Me.Text = "AutoUpdater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_current_version As Label
    Friend WithEvents label_new_version As Label
    Friend WithEvents label_currentversion As Label
    Friend WithEvents label_latestversion As Label
    Friend WithEvents label_update_abailable As Label
    Friend WithEvents button_updatenow As Button
    Friend WithEvents button_updatelater As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
