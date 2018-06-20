<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label_product_name = New System.Windows.Forms.Label()
        Me.label_copyright = New System.Windows.Forms.Label()
        Me.label_version_number = New System.Windows.Forms.Label()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.label_description = New System.Windows.Forms.Label()
        Me.linklabel_gethelp = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Discord_Bot_Maker.My.Resources.Resources.dbm_logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'label_product_name
        '
        Me.label_product_name.AutoSize = True
        Me.label_product_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_product_name.Location = New System.Drawing.Point(12, 122)
        Me.label_product_name.Name = "label_product_name"
        Me.label_product_name.Size = New System.Drawing.Size(95, 13)
        Me.label_product_name.TabIndex = 2
        Me.label_product_name.Text = "Discord Bot Maker" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'label_copyright
        '
        Me.label_copyright.AutoSize = True
        Me.label_copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_copyright.Location = New System.Drawing.Point(12, 148)
        Me.label_copyright.Name = "label_copyright"
        Me.label_copyright.Size = New System.Drawing.Size(226, 13)
        Me.label_copyright.TabIndex = 2
        Me.label_copyright.Text = "Copyright © 2018 jtrent238. All rights reserved."
        Me.label_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_version_number
        '
        Me.label_version_number.AutoSize = True
        Me.label_version_number.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_version_number.Location = New System.Drawing.Point(12, 135)
        Me.label_version_number.Name = "label_version_number"
        Me.label_version_number.Size = New System.Drawing.Size(55, 13)
        Me.label_version_number.TabIndex = 2
        Me.label_version_number.Text = "{$version}"
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(374, 188)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(75, 23)
        Me.button_ok.TabIndex = 3
        Me.button_ok.Text = "Ok"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'label_description
        '
        Me.label_description.AutoSize = True
        Me.label_description.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.label_description.Location = New System.Drawing.Point(12, 188)
        Me.label_description.Name = "label_description"
        Me.label_description.Size = New System.Drawing.Size(44, 13)
        Me.label_description.TabIndex = 2
        Me.label_description.Text = "{$desc}"
        Me.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linklabel_gethelp
        '
        Me.linklabel_gethelp.AutoSize = True
        Me.linklabel_gethelp.LinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.linklabel_gethelp.Location = New System.Drawing.Point(12, 161)
        Me.linklabel_gethelp.Name = "linklabel_gethelp"
        Me.linklabel_gethelp.Size = New System.Drawing.Size(64, 13)
        Me.linklabel_gethelp.TabIndex = 4
        Me.linklabel_gethelp.TabStop = True
        Me.linklabel_gethelp.Text = "Need Help?"
        '
        'AboutBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 223)
        Me.Controls.Add(Me.linklabel_gethelp)
        Me.Controls.Add(Me.button_ok)
        Me.Controls.Add(Me.label_description)
        Me.Controls.Add(Me.label_copyright)
        Me.Controls.Add(Me.label_version_number)
        Me.Controls.Add(Me.label_product_name)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AboutBox"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents label_product_name As Label
    Public WithEvents label_copyright As Label
    Public WithEvents label_version_number As Label
    Friend WithEvents button_ok As Button
    Public WithEvents label_description As Label
    Friend WithEvents linklabel_gethelp As LinkLabel
End Class
