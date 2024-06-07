<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSending
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSending))
        Me.ProgressBarSending = New System.Windows.Forms.ProgressBar()
        Me.ListViewNumbers = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageListWa = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.LabelProgress = New System.Windows.Forms.Label()
        Me.ButtonViewLog = New System.Windows.Forms.Button()
        Me.PanelCountDown = New System.Windows.Forms.Panel()
        Me.LabelCountDown = New System.Windows.Forms.Label()
        Me.LabelCountDownHeader = New System.Windows.Forms.Label()
        Me.TimerCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportSuccessfulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerMultiChannelCounter = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelCountDown.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBarSending
        '
        Me.ProgressBarSending.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBarSending.Location = New System.Drawing.Point(6, 28)
        Me.ProgressBarSending.Name = "ProgressBarSending"
        Me.ProgressBarSending.Size = New System.Drawing.Size(741, 20)
        Me.ProgressBarSending.TabIndex = 0
        '
        'ListViewNumbers
        '
        Me.ListViewNumbers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.ListViewNumbers.FullRowSelect = True
        Me.ListViewNumbers.GridLines = True
        Me.ListViewNumbers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewNumbers.HideSelection = False
        Me.ListViewNumbers.Location = New System.Drawing.Point(6, 55)
        Me.ListViewNumbers.MultiSelect = False
        Me.ListViewNumbers.Name = "ListViewNumbers"
        Me.ListViewNumbers.Size = New System.Drawing.Size(739, 309)
        Me.ListViewNumbers.SmallImageList = Me.ImageListWa
        Me.ListViewNumbers.StateImageList = Me.ImageListWa
        Me.ListViewNumbers.TabIndex = 1
        Me.ListViewNumbers.UseCompatibleStateImageBehavior = False
        Me.ListViewNumbers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Number"
        Me.ColumnHeader3.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sending Date"
        Me.ColumnHeader5.Width = 115
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Message"
        Me.ColumnHeader6.Width = 230
        '
        'ImageListWa
        '
        Me.ImageListWa.ImageStream = CType(resources.GetObject("ImageListWa.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListWa.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListWa.Images.SetKeyName(0, "bwa_Sent.png")
        Me.ImageListWa.Images.SetKeyName(1, "bwa_not_Sent.png")
        Me.ImageListWa.Images.SetKeyName(2, "pending.png")
        '
        'ButtonStop
        '
        Me.ButtonStop.Location = New System.Drawing.Point(643, 371)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(102, 26)
        Me.ButtonStop.TabIndex = 2
        Me.ButtonStop.Text = "Close"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ButtonPause
        '
        Me.ButtonPause.Location = New System.Drawing.Point(536, 371)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(106, 26)
        Me.ButtonPause.TabIndex = 6
        Me.ButtonPause.Tag = "pause"
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'LabelProgress
        '
        Me.LabelProgress.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelProgress.Location = New System.Drawing.Point(6, 6)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(741, 22)
        Me.LabelProgress.TabIndex = 7
        Me.LabelProgress.Text = "Sending Process (0/0)"
        Me.LabelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonViewLog
        '
        Me.ButtonViewLog.Location = New System.Drawing.Point(5, 368)
        Me.ButtonViewLog.Name = "ButtonViewLog"
        Me.ButtonViewLog.Size = New System.Drawing.Size(125, 26)
        Me.ButtonViewLog.TabIndex = 8
        Me.ButtonViewLog.Text = "Export"
        Me.ButtonViewLog.UseVisualStyleBackColor = True
        '
        'PanelCountDown
        '
        Me.PanelCountDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PanelCountDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCountDown.Controls.Add(Me.LabelCountDown)
        Me.PanelCountDown.Controls.Add(Me.LabelCountDownHeader)
        Me.PanelCountDown.Location = New System.Drawing.Point(187, 137)
        Me.PanelCountDown.Name = "PanelCountDown"
        Me.PanelCountDown.Size = New System.Drawing.Size(388, 118)
        Me.PanelCountDown.TabIndex = 10
        '
        'LabelCountDown
        '
        Me.LabelCountDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LabelCountDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountDown.ForeColor = System.Drawing.Color.White
        Me.LabelCountDown.Location = New System.Drawing.Point(0, 28)
        Me.LabelCountDown.Name = "LabelCountDown"
        Me.LabelCountDown.Size = New System.Drawing.Size(386, 88)
        Me.LabelCountDown.TabIndex = 1
        Me.LabelCountDown.Text = "00:00:00"
        Me.LabelCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCountDownHeader
        '
        Me.LabelCountDownHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LabelCountDownHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelCountDownHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountDownHeader.ForeColor = System.Drawing.Color.White
        Me.LabelCountDownHeader.Location = New System.Drawing.Point(0, 0)
        Me.LabelCountDownHeader.Name = "LabelCountDownHeader"
        Me.LabelCountDownHeader.Size = New System.Drawing.Size(386, 28)
        Me.LabelCountDownHeader.TabIndex = 0
        Me.LabelCountDownHeader.Text = "Your bulk will start after"
        Me.LabelCountDownHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerCountDown
        '
        Me.TimerCountDown.Enabled = True
        Me.TimerCountDown.Interval = 300
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(684, 56)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Wait for : 5 Second"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportSuccessfulToolStripMenuItem, Me.ExportAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(167, 48)
        '
        'ExportSuccessfulToolStripMenuItem
        '
        Me.ExportSuccessfulToolStripMenuItem.Name = "ExportSuccessfulToolStripMenuItem"
        Me.ExportSuccessfulToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExportSuccessfulToolStripMenuItem.Text = "Export Successful"
        '
        'ExportAllToolStripMenuItem
        '
        Me.ExportAllToolStripMenuItem.Name = "ExportAllToolStripMenuItem"
        Me.ExportAllToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExportAllToolStripMenuItem.Text = "Export All"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(201, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 102)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(229, 78)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(122, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click Here to login again"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 51)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "OOPS... " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "System went went wrong and system logged out please " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Login again to co" &
    "ntinue your bulk "
        '
        'FrmSending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 407)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBarSending)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelCountDown)
        Me.Controls.Add(Me.ButtonViewLog)
        Me.Controls.Add(Me.LabelProgress)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ListViewNumbers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmSending"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sending"
        Me.PanelCountDown.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBarSending As ProgressBar
    Friend WithEvents ListViewNumbers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ButtonStop As Button
    Friend WithEvents ButtonPause As Button
    Friend WithEvents LabelProgress As Label
    Friend WithEvents ButtonViewLog As Button
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ImageListWa As ImageList
    Friend WithEvents PanelCountDown As Panel
    Friend WithEvents LabelCountDown As Label
    Friend WithEvents LabelCountDownHeader As Label
    Friend WithEvents TimerCountDown As Timer
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExportSuccessfulToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerMultiChannelCounter As Timer
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
End Class
