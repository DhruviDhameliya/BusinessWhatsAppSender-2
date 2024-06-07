<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLicense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLicense))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LicneseTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LicSending1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LicAutoReply = New System.Windows.Forms.Label()
        Me.LicSending = New System.Windows.Forms.Label()
        Me.LicExpiryDate = New System.Windows.Forms.Label()
        Me.LicCreateDate = New System.Windows.Forms.Label()
        Me.LicName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LicFilter = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ValidateButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(12, 84)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(459, 25)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request Key"
        Me.Label1.Visible = False
        '
        'LicneseTextBox
        '
        Me.LicneseTextBox.Location = New System.Drawing.Point(11, 207)
        Me.LicneseTextBox.Multiline = True
        Me.LicneseTextBox.Name = "LicneseTextBox"
        Me.LicneseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LicneseTextBox.Size = New System.Drawing.Size(459, 61)
        Me.LicneseTextBox.TabIndex = 3
        Me.LicneseTextBox.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "License Key"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(369, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Activate"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(261, 455)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 26)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(354, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 24)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Copy"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "License to:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Mobile:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Expiry Date:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'LicSending1
        '
        Me.LicSending1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LicSending1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LicSending1.ForeColor = System.Drawing.Color.White
        Me.LicSending1.Location = New System.Drawing.Point(12, 374)
        Me.LicSending1.Name = "LicSending1"
        Me.LicSending1.Size = New System.Drawing.Size(126, 18)
        Me.LicSending1.TabIndex = 13
        Me.LicSending1.Text = "Sending:"
        Me.LicSending1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LicSending1.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 394)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "AutoReply:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 414)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 18)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Filter:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Visible = False
        '
        'LicAutoReply
        '
        Me.LicAutoReply.BackColor = System.Drawing.Color.White
        Me.LicAutoReply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LicAutoReply.ForeColor = System.Drawing.Color.Black
        Me.LicAutoReply.Location = New System.Drawing.Point(139, 394)
        Me.LicAutoReply.Name = "LicAutoReply"
        Me.LicAutoReply.Size = New System.Drawing.Size(331, 18)
        Me.LicAutoReply.TabIndex = 21
        Me.LicAutoReply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LicAutoReply.Visible = False
        '
        'LicSending
        '
        Me.LicSending.BackColor = System.Drawing.Color.White
        Me.LicSending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LicSending.ForeColor = System.Drawing.Color.Black
        Me.LicSending.Location = New System.Drawing.Point(139, 374)
        Me.LicSending.Name = "LicSending"
        Me.LicSending.Size = New System.Drawing.Size(331, 18)
        Me.LicSending.TabIndex = 20
        Me.LicSending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LicSending.Visible = False
        '
        'LicExpiryDate
        '
        Me.LicExpiryDate.BackColor = System.Drawing.Color.White
        Me.LicExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LicExpiryDate.ForeColor = System.Drawing.Color.Black
        Me.LicExpiryDate.Location = New System.Drawing.Point(139, 354)
        Me.LicExpiryDate.Name = "LicExpiryDate"
        Me.LicExpiryDate.Size = New System.Drawing.Size(331, 18)
        Me.LicExpiryDate.TabIndex = 19
        Me.LicExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LicExpiryDate.Visible = False
        '
        'LicCreateDate
        '
        Me.LicCreateDate.BackColor = System.Drawing.Color.White
        Me.LicCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LicCreateDate.ForeColor = System.Drawing.Color.Black
        Me.LicCreateDate.Location = New System.Drawing.Point(139, 334)
        Me.LicCreateDate.Name = "LicCreateDate"
        Me.LicCreateDate.Size = New System.Drawing.Size(331, 18)
        Me.LicCreateDate.TabIndex = 18
        Me.LicCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LicCreateDate.Visible = False
        '
        'LicName
        '
        Me.LicName.BackColor = System.Drawing.Color.White
        Me.LicName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LicName.ForeColor = System.Drawing.Color.Black
        Me.LicName.Location = New System.Drawing.Point(139, 314)
        Me.LicName.Name = "LicName"
        Me.LicName.Size = New System.Drawing.Size(331, 18)
        Me.LicName.TabIndex = 16
        Me.LicName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LicName.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "License Details"
        Me.Label4.Visible = False
        '
        'LicFilter
        '
        Me.LicFilter.BackColor = System.Drawing.Color.White
        Me.LicFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LicFilter.ForeColor = System.Drawing.Color.Black
        Me.LicFilter.Location = New System.Drawing.Point(139, 414)
        Me.LicFilter.Name = "LicFilter"
        Me.LicFilter.Size = New System.Drawing.Size(331, 18)
        Me.LicFilter.TabIndex = 22
        Me.LicFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LicFilter.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 455)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(43, 455)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(-6, 289)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 7)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(-6, 437)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 7)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(-6, 161)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(495, 7)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(11, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(342, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "You can paste license text recived or you can load the license file (.lic)"
        Me.Label9.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(352, 183)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 22)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Load license from file"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Red
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(11, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 19)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Invalid license"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label12.Visible = False
        '
        'ValidateButton
        '
        Me.ValidateButton.Location = New System.Drawing.Point(354, 271)
        Me.ValidateButton.Name = "ValidateButton"
        Me.ValidateButton.Size = New System.Drawing.Size(115, 23)
        Me.ValidateButton.TabIndex = 32
        Me.ValidateButton.Text = "Validate "
        Me.ValidateButton.UseVisualStyleBackColor = True
        Me.ValidateButton.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please send us your request key along with your purshasing proof "
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(258, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Please Enter Your Mobile Number With Country Code"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 27)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(250, 20)
        Me.TextBox2.TabIndex = 34
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(279, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(155, 24)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Generate Order Number"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(423, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Send This Order Number Through Whatsapp At +91 99132 99862 Or  +91 99132 99806"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(12, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(416, 137)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(55, 24)
        Me.Button6.TabIndex = 38
        Me.Button6.Text = "Send"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'FrmLicense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 515)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ValidateButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LicFilter)
        Me.Controls.Add(Me.LicAutoReply)
        Me.Controls.Add(Me.LicSending)
        Me.Controls.Add(Me.LicExpiryDate)
        Me.Controls.Add(Me.LicCreateDate)
        Me.Controls.Add(Me.LicName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LicSending1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LicneseTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLicense"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activate Business WhatsApp Sender"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LicneseTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LicSending1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LicAutoReply As Label
    Friend WithEvents LicSending As Label
    Friend WithEvents LicExpiryDate As Label
    Friend WithEvents LicCreateDate As Label
    Friend WithEvents LicName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LicFilter As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents ValidateButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button6 As Button
End Class
