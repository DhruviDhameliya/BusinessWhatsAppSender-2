<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceivedMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceivedMessage))
        Me.LabelReceivedDate = New System.Windows.Forms.Label()
        Me.LabelSender = New System.Windows.Forms.Label()
        Me.LabelReceivedMessage = New System.Windows.Forms.Label()
        Me.TextBoxReceivedDate = New System.Windows.Forms.TextBox()
        Me.TextBoxSender = New System.Windows.Forms.TextBox()
        Me.TextBoxReceivedMessage = New System.Windows.Forms.TextBox()
        Me.TextBoxReplyToSender = New System.Windows.Forms.TextBox()
        Me.LabelReplytoSender = New System.Windows.Forms.Label()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelReceivedDate
        '
        Me.LabelReceivedDate.AutoSize = True
        Me.LabelReceivedDate.Location = New System.Drawing.Point(9, 11)
        Me.LabelReceivedDate.Name = "LabelReceivedDate"
        Me.LabelReceivedDate.Size = New System.Drawing.Size(82, 13)
        Me.LabelReceivedDate.TabIndex = 0
        Me.LabelReceivedDate.Text = "Received Date:"
        '
        'LabelSender
        '
        Me.LabelSender.AutoSize = True
        Me.LabelSender.Location = New System.Drawing.Point(9, 51)
        Me.LabelSender.Name = "LabelSender"
        Me.LabelSender.Size = New System.Drawing.Size(44, 13)
        Me.LabelSender.TabIndex = 1
        Me.LabelSender.Text = "Sender:"
        '
        'LabelReceivedMessage
        '
        Me.LabelReceivedMessage.AutoSize = True
        Me.LabelReceivedMessage.Location = New System.Drawing.Point(9, 94)
        Me.LabelReceivedMessage.Name = "LabelReceivedMessage"
        Me.LabelReceivedMessage.Size = New System.Drawing.Size(102, 13)
        Me.LabelReceivedMessage.TabIndex = 2
        Me.LabelReceivedMessage.Text = "Received Message:"
        '
        'TextBoxReceivedDate
        '
        Me.TextBoxReceivedDate.Location = New System.Drawing.Point(12, 27)
        Me.TextBoxReceivedDate.Name = "TextBoxReceivedDate"
        Me.TextBoxReceivedDate.ReadOnly = True
        Me.TextBoxReceivedDate.Size = New System.Drawing.Size(400, 20)
        Me.TextBoxReceivedDate.TabIndex = 3
        '
        'TextBoxSender
        '
        Me.TextBoxSender.Location = New System.Drawing.Point(12, 67)
        Me.TextBoxSender.Name = "TextBoxSender"
        Me.TextBoxSender.ReadOnly = True
        Me.TextBoxSender.Size = New System.Drawing.Size(400, 20)
        Me.TextBoxSender.TabIndex = 4
        '
        'TextBoxReceivedMessage
        '
        Me.TextBoxReceivedMessage.Location = New System.Drawing.Point(12, 110)
        Me.TextBoxReceivedMessage.Multiline = True
        Me.TextBoxReceivedMessage.Name = "TextBoxReceivedMessage"
        Me.TextBoxReceivedMessage.ReadOnly = True
        Me.TextBoxReceivedMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxReceivedMessage.Size = New System.Drawing.Size(400, 72)
        Me.TextBoxReceivedMessage.TabIndex = 5
        '
        'TextBoxReplyToSender
        '
        Me.TextBoxReplyToSender.Location = New System.Drawing.Point(11, 203)
        Me.TextBoxReplyToSender.Multiline = True
        Me.TextBoxReplyToSender.Name = "TextBoxReplyToSender"
        Me.TextBoxReplyToSender.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxReplyToSender.Size = New System.Drawing.Size(400, 60)
        Me.TextBoxReplyToSender.TabIndex = 0
        '
        'LabelReplytoSender
        '
        Me.LabelReplytoSender.AutoSize = True
        Me.LabelReplytoSender.Location = New System.Drawing.Point(8, 187)
        Me.LabelReplytoSender.Name = "LabelReplytoSender"
        Me.LabelReplytoSender.Size = New System.Drawing.Size(83, 13)
        Me.LabelReplytoSender.TabIndex = 6
        Me.LabelReplytoSender.Text = "Reply to Sender"
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(307, 272)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(104, 30)
        Me.ButtonSend.TabIndex = 8
        Me.ButtonSend.Text = "Send "
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(197, 272)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(104, 30)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FrmReceivedMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 314)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.TextBoxReplyToSender)
        Me.Controls.Add(Me.LabelReplytoSender)
        Me.Controls.Add(Me.TextBoxReceivedMessage)
        Me.Controls.Add(Me.TextBoxSender)
        Me.Controls.Add(Me.TextBoxReceivedDate)
        Me.Controls.Add(Me.LabelReceivedMessage)
        Me.Controls.Add(Me.LabelSender)
        Me.Controls.Add(Me.LabelReceivedDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmReceivedMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Received Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelReceivedDate As Label
    Friend WithEvents LabelSender As Label
    Friend WithEvents LabelReceivedMessage As Label
    Friend WithEvents TextBoxReceivedDate As TextBox
    Friend WithEvents TextBoxSender As TextBox
    Friend WithEvents TextBoxReceivedMessage As TextBox
    Friend WithEvents TextBoxReplyToSender As TextBox
    Friend WithEvents LabelReplytoSender As Label
    Friend WithEvents ButtonSend As Button
    Friend WithEvents ButtonClose As Button
End Class
