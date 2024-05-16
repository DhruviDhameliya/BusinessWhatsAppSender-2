<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetCaption
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
        Me.TxtCaption = New System.Windows.Forms.TextBox()
        Me.BtnStrike = New System.Windows.Forms.Button()
        Me.BtnItalic = New System.Windows.Forms.Button()
        Me.BtnBold = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LinkLastName = New System.Windows.Forms.LinkLabel()
        Me.LinkFirstName = New System.Windows.Forms.LinkLabel()
        Me.LinkName = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtCaption
        '
        Me.TxtCaption.Location = New System.Drawing.Point(12, 12)
        Me.TxtCaption.Multiline = True
        Me.TxtCaption.Name = "TxtCaption"
        Me.TxtCaption.Size = New System.Drawing.Size(460, 170)
        Me.TxtCaption.TabIndex = 0
        '
        'BtnStrike
        '
        Me.BtnStrike.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnStrike.FlatAppearance.BorderSize = 0
        Me.BtnStrike.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStrike.ForeColor = System.Drawing.Color.Black
        Me.BtnStrike.Location = New System.Drawing.Point(109, 188)
        Me.BtnStrike.Name = "BtnStrike"
        Me.BtnStrike.Size = New System.Drawing.Size(30, 31)
        Me.BtnStrike.TabIndex = 107
        Me.BtnStrike.Text = "S "
        Me.BtnStrike.UseVisualStyleBackColor = True
        '
        'BtnItalic
        '
        Me.BtnItalic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnItalic.FlatAppearance.BorderSize = 0
        Me.BtnItalic.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItalic.ForeColor = System.Drawing.Color.Black
        Me.BtnItalic.Location = New System.Drawing.Point(77, 188)
        Me.BtnItalic.Name = "BtnItalic"
        Me.BtnItalic.Size = New System.Drawing.Size(30, 31)
        Me.BtnItalic.TabIndex = 106
        Me.BtnItalic.Text = "I"
        Me.BtnItalic.UseVisualStyleBackColor = True
        '
        'BtnBold
        '
        Me.BtnBold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnBold.FlatAppearance.BorderSize = 0
        Me.BtnBold.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBold.ForeColor = System.Drawing.Color.Black
        Me.BtnBold.Location = New System.Drawing.Point(45, 188)
        Me.BtnBold.Name = "BtnBold"
        Me.BtnBold.Size = New System.Drawing.Size(30, 31)
        Me.BtnBold.TabIndex = 105
        Me.BtnBold.Text = "B"
        Me.BtnBold.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(364, 188)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(108, 30)
        Me.BtnOK.TabIndex = 108
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(253, 188)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(108, 30)
        Me.BtnCancel.TabIndex = 109
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LinkLastName
        '
        Me.LinkLastName.AutoSize = True
        Me.LinkLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLastName.LinkColor = System.Drawing.Color.Black
        Me.LinkLastName.Location = New System.Drawing.Point(129, 349)
        Me.LinkLastName.Name = "LinkLastName"
        Me.LinkLastName.Size = New System.Drawing.Size(58, 13)
        Me.LinkLastName.TabIndex = 112
        Me.LinkLastName.TabStop = True
        Me.LinkLastName.Text = "Last Name"
        '
        'LinkFirstName
        '
        Me.LinkFirstName.AutoSize = True
        Me.LinkFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkFirstName.LinkColor = System.Drawing.Color.Black
        Me.LinkFirstName.Location = New System.Drawing.Point(74, 349)
        Me.LinkFirstName.Name = "LinkFirstName"
        Me.LinkFirstName.Size = New System.Drawing.Size(57, 13)
        Me.LinkFirstName.TabIndex = 111
        Me.LinkFirstName.TabStop = True
        Me.LinkFirstName.Text = "First Name"
        '
        'LinkName
        '
        Me.LinkName.AutoSize = True
        Me.LinkName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkName.LinkColor = System.Drawing.Color.Black
        Me.LinkName.Location = New System.Drawing.Point(18, 349)
        Me.LinkName.Name = "LinkName"
        Me.LinkName.Size = New System.Drawing.Size(54, 13)
        Me.LinkName.TabIndex = 110
        Me.LinkName.TabStop = True
        Me.LinkName.Text = "Full Name"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(13, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 31)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "J"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmSetCaption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 228)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLastName)
        Me.Controls.Add(Me.LinkFirstName)
        Me.Controls.Add(Me.LinkName)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnStrike)
        Me.Controls.Add(Me.BtnItalic)
        Me.Controls.Add(Me.BtnBold)
        Me.Controls.Add(Me.TxtCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSetCaption"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Caption "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCaption As TextBox
    Friend WithEvents BtnStrike As Button
    Friend WithEvents BtnItalic As Button
    Friend WithEvents BtnBold As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents LinkLastName As LinkLabel
    Friend WithEvents LinkFirstName As LinkLabel
    Friend WithEvents LinkName As LinkLabel
    Friend WithEvents Button1 As Button
End Class
