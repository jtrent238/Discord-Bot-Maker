<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeEditor
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
        Me.button_startbot = New System.Windows.Forms.Button()
        Me.button_installdependencies = New System.Windows.Forms.Button()
        Me.button_stopbot = New System.Windows.Forms.Button()
        Me.button_console = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_startbot
        '
        Me.button_startbot.Location = New System.Drawing.Point(343, 12)
        Me.button_startbot.Name = "button_startbot"
        Me.button_startbot.Size = New System.Drawing.Size(75, 23)
        Me.button_startbot.TabIndex = 0
        Me.button_startbot.Text = "Start Bot"
        Me.button_startbot.UseVisualStyleBackColor = True
        '
        'button_installdependencies
        '
        Me.button_installdependencies.Location = New System.Drawing.Point(210, 12)
        Me.button_installdependencies.Name = "button_installdependencies"
        Me.button_installdependencies.Size = New System.Drawing.Size(127, 23)
        Me.button_installdependencies.TabIndex = 0
        Me.button_installdependencies.Text = "Install Dependencies"
        Me.button_installdependencies.UseVisualStyleBackColor = True
        '
        'button_stopbot
        '
        Me.button_stopbot.Location = New System.Drawing.Point(424, 12)
        Me.button_stopbot.Name = "button_stopbot"
        Me.button_stopbot.Size = New System.Drawing.Size(75, 23)
        Me.button_stopbot.TabIndex = 0
        Me.button_stopbot.Text = "Stop Bot"
        Me.button_stopbot.UseVisualStyleBackColor = True
        '
        'button_console
        '
        Me.button_console.Location = New System.Drawing.Point(129, 12)
        Me.button_console.Name = "button_console"
        Me.button_console.Size = New System.Drawing.Size(75, 23)
        Me.button_console.TabIndex = 3
        Me.button_console.Text = "Console"
        Me.button_console.UseVisualStyleBackColor = True
        '
        'CodeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 379)
        Me.Controls.Add(Me.button_console)
        Me.Controls.Add(Me.button_installdependencies)
        Me.Controls.Add(Me.button_stopbot)
        Me.Controls.Add(Me.button_startbot)
        Me.Name = "CodeEditor"
        Me.Text = "CodeEditor"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_startbot As Button
    Friend WithEvents button_installdependencies As Button
    Friend WithEvents button_stopbot As Button
    Friend WithEvents button_console As Button
End Class
