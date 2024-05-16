<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplash))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelBuildDate = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.ForeColor = System.Drawing.Color.Black
        Me.LabelVersion.Location = New System.Drawing.Point(392, 268)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(57, 13)
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "{{version}}"
        '
        'LabelBuildDate
        '
        Me.LabelBuildDate.AutoSize = True
        Me.LabelBuildDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelBuildDate.ForeColor = System.Drawing.Color.Black
        Me.LabelBuildDate.Location = New System.Drawing.Point(455, 268)
        Me.LabelBuildDate.Name = "LabelBuildDate"
        Me.LabelBuildDate.Size = New System.Drawing.Size(72, 13)
        Me.LabelBuildDate.TabIndex = 1
        Me.LabelBuildDate.Text = "{{Build Date}}"
        '
        'LabelStatus
        '
        Me.LabelStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelStatus.ForeColor = System.Drawing.Color.Black
        Me.LabelStatus.Location = New System.Drawing.Point(360, 281)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(200, 18)
        Me.LabelStatus.TabIndex = 2
        Me.LabelStatus.Text = "{{Loading API}}"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(598, 363)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.LabelBuildDate)
        Me.Controls.Add(Me.LabelVersion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSplash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelBuildDate As Label
    Friend WithEvents LabelStatus As Label
End Class
