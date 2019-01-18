<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelfBotInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelfBotInfo))
        Me.label_SelfbotInfo = New System.Windows.Forms.Label()
        Me.CheckBoxAgreeTOSUsage = New System.Windows.Forms.CheckBox()
        Me.linklabel_selfBotLink = New System.Windows.Forms.LinkLabel()
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label_SelfbotInfo
        '
        Me.label_SelfbotInfo.AutoSize = True
        Me.label_SelfbotInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_SelfbotInfo.Location = New System.Drawing.Point(9, 9)
        Me.label_SelfbotInfo.Name = "label_SelfbotInfo"
        Me.label_SelfbotInfo.Size = New System.Drawing.Size(383, 104)
        Me.label_SelfbotInfo.TabIndex = 2
        Me.label_SelfbotInfo.Text = resources.GetString("label_SelfbotInfo.Text")
        '
        'CheckBoxAgreeTOSUsage
        '
        Me.CheckBoxAgreeTOSUsage.AutoSize = True
        Me.CheckBoxAgreeTOSUsage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.CheckBoxAgreeTOSUsage.Location = New System.Drawing.Point(12, 116)
        Me.CheckBoxAgreeTOSUsage.Name = "CheckBoxAgreeTOSUsage"
        Me.CheckBoxAgreeTOSUsage.Size = New System.Drawing.Size(359, 17)
        Me.CheckBoxAgreeTOSUsage.TabIndex = 3
        Me.CheckBoxAgreeTOSUsage.Text = "I agree to use this program in accordance to Discord Terms of Service."
        Me.CheckBoxAgreeTOSUsage.UseVisualStyleBackColor = True
        '
        'linklabel_selfBotLink
        '
        Me.linklabel_selfBotLink.AutoSize = True
        Me.linklabel_selfBotLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.linklabel_selfBotLink.Location = New System.Drawing.Point(253, 87)
        Me.linklabel_selfBotLink.Name = "linklabel_selfBotLink"
        Me.linklabel_selfBotLink.Size = New System.Drawing.Size(59, 13)
        Me.linklabel_selfBotLink.TabIndex = 6
        Me.linklabel_selfBotLink.TabStop = True
        Me.linklabel_selfBotLink.Text = "Click Here!"
        '
        'Button_Ok
        '
        Me.Button_Ok.Location = New System.Drawing.Point(377, 116)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ok.TabIndex = 7
        Me.Button_Ok.Text = "Ok"
        Me.Button_Ok.UseVisualStyleBackColor = True
        '
        'SelfBotInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(469, 148)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.linklabel_selfBotLink)
        Me.Controls.Add(Me.CheckBoxAgreeTOSUsage)
        Me.Controls.Add(Me.label_SelfbotInfo)
        Me.Name = "SelfBotInfo"
        Me.Text = "Selfbot Agreement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_SelfbotInfo As Label
    Friend WithEvents CheckBoxAgreeTOSUsage As CheckBox
    Friend WithEvents linklabel_selfBotLink As LinkLabel
    Friend WithEvents Button_Ok As Button
End Class
