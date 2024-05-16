<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGroupGrabber
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
        Me.components = New System.ComponentModel.Container()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnFetchGroups = New System.Windows.Forms.Button()
        Me.BtnFtechContacts = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.BtnAddtoList = New System.Windows.Forms.Button()
        Me.BtnSelectAll = New System.Windows.Forms.Button()
        Me.BtnDeselectAll = New System.Windows.Forms.Button()
        Me.BtnClearGroups = New System.Windows.Forms.Button()
        Me.BtnDeleteGroups = New System.Windows.Forms.Button()
        Me.BtnExportGroups = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AllGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(5, 45)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(391, 367)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Group Name"
        Me.ColumnHeader1.Width = 167
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Group ID"
        Me.ColumnHeader2.Width = 175
        '
        'BtnFetchGroups
        '
        Me.BtnFetchGroups.Location = New System.Drawing.Point(5, 4)
        Me.BtnFetchGroups.Name = "BtnFetchGroups"
        Me.BtnFetchGroups.Size = New System.Drawing.Size(391, 35)
        Me.BtnFetchGroups.TabIndex = 2
        Me.BtnFetchGroups.Text = "Fetch Groups"
        Me.BtnFetchGroups.UseVisualStyleBackColor = True
        '
        'BtnFtechContacts
        '
        Me.BtnFtechContacts.Location = New System.Drawing.Point(402, 4)
        Me.BtnFtechContacts.Name = "BtnFtechContacts"
        Me.BtnFtechContacts.Size = New System.Drawing.Size(361, 35)
        Me.BtnFtechContacts.TabIndex = 3
        Me.BtnFtechContacts.Text = "Get Contacts From selected groups "
        Me.BtnFtechContacts.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(402, 415)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(113, 26)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Clear List"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExport
        '
        Me.BtnExport.Location = New System.Drawing.Point(517, 415)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(113, 26)
        Me.BtnExport.TabIndex = 5
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'BtnAddtoList
        '
        Me.BtnAddtoList.Location = New System.Drawing.Point(632, 415)
        Me.BtnAddtoList.Name = "BtnAddtoList"
        Me.BtnAddtoList.Size = New System.Drawing.Size(131, 26)
        Me.BtnAddtoList.TabIndex = 6
        Me.BtnAddtoList.Text = "Add to sender list"
        Me.BtnAddtoList.UseVisualStyleBackColor = True
        '
        'BtnSelectAll
        '
        Me.BtnSelectAll.Location = New System.Drawing.Point(5, 415)
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.Size = New System.Drawing.Size(75, 26)
        Me.BtnSelectAll.TabIndex = 7
        Me.BtnSelectAll.Text = "Select All"
        Me.BtnSelectAll.UseVisualStyleBackColor = True
        '
        'BtnDeselectAll
        '
        Me.BtnDeselectAll.Location = New System.Drawing.Point(81, 415)
        Me.BtnDeselectAll.Name = "BtnDeselectAll"
        Me.BtnDeselectAll.Size = New System.Drawing.Size(75, 26)
        Me.BtnDeselectAll.TabIndex = 8
        Me.BtnDeselectAll.Text = "Deselect All"
        Me.BtnDeselectAll.UseVisualStyleBackColor = True
        '
        'BtnClearGroups
        '
        Me.BtnClearGroups.Location = New System.Drawing.Point(156, 415)
        Me.BtnClearGroups.Name = "BtnClearGroups"
        Me.BtnClearGroups.Size = New System.Drawing.Size(75, 26)
        Me.BtnClearGroups.TabIndex = 9
        Me.BtnClearGroups.Text = "Clear"
        Me.BtnClearGroups.UseVisualStyleBackColor = True
        '
        'BtnDeleteGroups
        '
        Me.BtnDeleteGroups.Location = New System.Drawing.Point(231, 415)
        Me.BtnDeleteGroups.Name = "BtnDeleteGroups"
        Me.BtnDeleteGroups.Size = New System.Drawing.Size(75, 26)
        Me.BtnDeleteGroups.TabIndex = 10
        Me.BtnDeleteGroups.Text = "Delete"
        Me.BtnDeleteGroups.UseVisualStyleBackColor = True
        '
        'BtnExportGroups
        '
        Me.BtnExportGroups.Location = New System.Drawing.Point(307, 415)
        Me.BtnExportGroups.Name = "BtnExportGroups"
        Me.BtnExportGroups.Size = New System.Drawing.Size(89, 26)
        Me.BtnExportGroups.TabIndex = 11
        Me.BtnExportGroups.Text = "Export Groups"
        Me.BtnExportGroups.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllGroupsToolStripMenuItem, Me.CheckedGroupsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 48)
        '
        'AllGroupsToolStripMenuItem
        '
        Me.AllGroupsToolStripMenuItem.Name = "AllGroupsToolStripMenuItem"
        Me.AllGroupsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AllGroupsToolStripMenuItem.Text = "All Groups"
        '
        'CheckedGroupsToolStripMenuItem
        '
        Me.CheckedGroupsToolStripMenuItem.Name = "CheckedGroupsToolStripMenuItem"
        Me.CheckedGroupsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CheckedGroupsToolStripMenuItem.Text = "Checked Groups"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(402, 45)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(361, 368)
        Me.ListBox1.TabIndex = 12
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 445)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(766, 24)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(58, 19)
        Me.ToolStripStatusLabel1.Text = "{Gcount}"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(58, 19)
        Me.ToolStripStatusLabel2.Text = "{Ccount}"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(4, 19)
        '
        'FrmGroupGrabber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 469)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnExportGroups)
        Me.Controls.Add(Me.BtnDeleteGroups)
        Me.Controls.Add(Me.BtnClearGroups)
        Me.Controls.Add(Me.BtnDeselectAll)
        Me.Controls.Add(Me.BtnSelectAll)
        Me.Controls.Add(Me.BtnAddtoList)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnFtechContacts)
        Me.Controls.Add(Me.BtnFetchGroups)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGroupGrabber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Grabber"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents BtnFetchGroups As Button
    Friend WithEvents BtnFtechContacts As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExport As Button
    Friend WithEvents BtnAddtoList As Button
    Friend WithEvents BtnSelectAll As Button
    Friend WithEvents BtnDeselectAll As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents BtnClearGroups As Button
    Friend WithEvents BtnDeleteGroups As Button
    Friend WithEvents BtnExportGroups As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AllGroupsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckedGroupsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
End Class
