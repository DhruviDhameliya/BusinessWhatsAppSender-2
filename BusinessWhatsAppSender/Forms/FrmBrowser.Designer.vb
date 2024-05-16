<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBrowser))
        Me.TimerEvent = New System.Windows.Forms.Timer(Me.components)
        Me.TimerInitiateWAPI = New System.Windows.Forms.Timer(Me.components)
        Me.TimerIsWhatsAppLoggedIn = New System.Windows.Forms.Timer(Me.components)
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TimerEvent
        '
        Me.TimerEvent.Enabled = True
        Me.TimerEvent.Interval = 1000
        '
        'TimerInitiateWAPI
        '
        Me.TimerInitiateWAPI.Enabled = True
        Me.TimerInitiateWAPI.Interval = 1000
        '
        'TimerIsWhatsAppLoggedIn
        '
        Me.TimerIsWhatsAppLoggedIn.Enabled = True
        Me.TimerIsWhatsAppLoggedIn.Interval = 1000
        '
        'TimerReceive
        '
        Me.TimerReceive.Interval = 1000
        '
        'FrmBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 525)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBrowser"
        Me.Text = "FrmBrowser"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TimerEvent As Timer
    Friend WithEvents TimerInitiateWAPI As Timer
    Friend WithEvents TimerIsWhatsAppLoggedIn As Timer
    Friend WithEvents TimerReceive As Timer
End Class
