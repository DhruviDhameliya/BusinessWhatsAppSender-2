<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAutoReply
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
        Me.ButtonEmoji = New System.Windows.Forms.Button()
        Me.BtnStrike = New System.Windows.Forms.Button()
        Me.BtnItalic = New System.Windows.Forms.Button()
        Me.BtnBold = New System.Windows.Forms.Button()
        Me.GroupBoxDivider = New System.Windows.Forms.GroupBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.LabelAttachment = New System.Windows.Forms.Label()
        Me.LabelMessage = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ListViewAttachment = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuMediaType = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetCaptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.ContextMenuStripAttachFiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PhotosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator()
        Me.StickersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuMediaType.SuspendLayout()
        Me.ContextMenuStripAttachFiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonEmoji
        '
        Me.ButtonEmoji.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.ButtonEmoji.FlatAppearance.BorderSize = 0
        Me.ButtonEmoji.Font = New System.Drawing.Font("Wingdings", 12.0!)
        Me.ButtonEmoji.ForeColor = System.Drawing.Color.Black
        Me.ButtonEmoji.Location = New System.Drawing.Point(341, 121)
        Me.ButtonEmoji.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEmoji.Name = "ButtonEmoji"
        Me.ButtonEmoji.Size = New System.Drawing.Size(29, 25)
        Me.ButtonEmoji.TabIndex = 128
        Me.ButtonEmoji.Text = "J"
        Me.ButtonEmoji.UseVisualStyleBackColor = False
        '
        'BtnStrike
        '
        Me.BtnStrike.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnStrike.FlatAppearance.BorderSize = 0
        Me.BtnStrike.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStrike.ForeColor = System.Drawing.Color.Black
        Me.BtnStrike.Location = New System.Drawing.Point(430, 121)
        Me.BtnStrike.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStrike.Name = "BtnStrike"
        Me.BtnStrike.Size = New System.Drawing.Size(29, 25)
        Me.BtnStrike.TabIndex = 126
        Me.BtnStrike.Text = "S "
        Me.BtnStrike.UseVisualStyleBackColor = False
        '
        'BtnItalic
        '
        Me.BtnItalic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnItalic.FlatAppearance.BorderSize = 0
        Me.BtnItalic.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItalic.ForeColor = System.Drawing.Color.Black
        Me.BtnItalic.Location = New System.Drawing.Point(400, 121)
        Me.BtnItalic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnItalic.Name = "BtnItalic"
        Me.BtnItalic.Size = New System.Drawing.Size(29, 25)
        Me.BtnItalic.TabIndex = 125
        Me.BtnItalic.Text = "I"
        Me.BtnItalic.UseVisualStyleBackColor = False
        '
        'BtnBold
        '
        Me.BtnBold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnBold.FlatAppearance.BorderSize = 0
        Me.BtnBold.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBold.ForeColor = System.Drawing.Color.Black
        Me.BtnBold.Location = New System.Drawing.Point(370, 121)
        Me.BtnBold.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBold.Name = "BtnBold"
        Me.BtnBold.Size = New System.Drawing.Size(29, 25)
        Me.BtnBold.TabIndex = 124
        Me.BtnBold.Text = "B"
        Me.BtnBold.UseVisualStyleBackColor = False
        '
        'GroupBoxDivider
        '
        Me.GroupBoxDivider.Location = New System.Drawing.Point(-15, 318)
        Me.GroupBoxDivider.Name = "GroupBoxDivider"
        Me.GroupBoxDivider.Size = New System.Drawing.Size(521, 7)
        Me.GroupBoxDivider.TabIndex = 123
        Me.GroupBoxDivider.TabStop = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(175, 283)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(80, 26)
        Me.ButtonClear.TabIndex = 122
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(92, 283)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(80, 26)
        Me.ButtonDelete.TabIndex = 121
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(9, 283)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(80, 26)
        Me.ButtonAdd.TabIndex = 119
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'LabelAttachment
        '
        Me.LabelAttachment.AutoSize = True
        Me.LabelAttachment.Location = New System.Drawing.Point(9, 137)
        Me.LabelAttachment.Name = "LabelAttachment"
        Me.LabelAttachment.Size = New System.Drawing.Size(64, 13)
        Me.LabelAttachment.TabIndex = 118
        Me.LabelAttachment.Text = "Attachment "
        '
        'LabelMessage
        '
        Me.LabelMessage.AutoSize = True
        Me.LabelMessage.Location = New System.Drawing.Point(9, 6)
        Me.LabelMessage.Name = "LabelMessage"
        Me.LabelMessage.Size = New System.Drawing.Size(50, 13)
        Me.LabelMessage.TabIndex = 117
        Me.LabelMessage.Text = "Message"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(306, 330)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 25)
        Me.ButtonCancel.TabIndex = 114
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(387, 330)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 25)
        Me.ButtonOK.TabIndex = 113
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ListViewAttachment
        '
        Me.ListViewAttachment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewAttachment.ContextMenuStrip = Me.ContextMenuMediaType
        Me.ListViewAttachment.FullRowSelect = True
        Me.ListViewAttachment.HideSelection = False
        Me.ListViewAttachment.Location = New System.Drawing.Point(9, 155)
        Me.ListViewAttachment.Name = "ListViewAttachment"
        Me.ListViewAttachment.Size = New System.Drawing.Size(450, 124)
        Me.ListViewAttachment.TabIndex = 112
        Me.ListViewAttachment.UseCompatibleStateImageBehavior = False
        Me.ListViewAttachment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name"
        Me.ColumnHeader1.Width = 226
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 84
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Caption"
        Me.ColumnHeader3.Width = 140
        '
        'ContextMenuMediaType
        '
        Me.ContextMenuMediaType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetCaptionToolStripMenuItem, Me.ToolStripMenuItem2, Me.DeleteToolStripMenuItem1, Me.ToolStripMenuItem6, Me.OpenFileToolStripMenuItem})
        Me.ContextMenuMediaType.Name = "ContextMenuMediaType"
        Me.ContextMenuMediaType.Size = New System.Drawing.Size(136, 82)
        '
        'SetCaptionToolStripMenuItem
        '
        Me.SetCaptionToolStripMenuItem.Name = "SetCaptionToolStripMenuItem"
        Me.SetCaptionToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SetCaptionToolStripMenuItem.Text = "Set Caption"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(132, 6)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete File"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(132, 6)
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'TextBoxMessage
        '
        Me.TextBoxMessage.Location = New System.Drawing.Point(9, 22)
        Me.TextBoxMessage.Multiline = True
        Me.TextBoxMessage.Name = "TextBoxMessage"
        Me.TextBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMessage.Size = New System.Drawing.Size(450, 95)
        Me.TextBoxMessage.TabIndex = 110
        '
        'ContextMenuStripAttachFiles
        '
        Me.ContextMenuStripAttachFiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhotosToolStripMenuItem, Me.VideosToolStripMenuItem, Me.DocumentsToolStripMenuItem, Me.ToolStripMenuItem20, Me.StickersToolStripMenuItem})
        Me.ContextMenuStripAttachFiles.Name = "ContextMenuStripAttachFiles"
        Me.ContextMenuStripAttachFiles.Size = New System.Drawing.Size(165, 98)
        '
        'PhotosToolStripMenuItem
        '
        Me.PhotosToolStripMenuItem.Name = "PhotosToolStripMenuItem"
        Me.PhotosToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PhotosToolStripMenuItem.Text = "Photos"
        '
        'VideosToolStripMenuItem
        '
        Me.VideosToolStripMenuItem.Name = "VideosToolStripMenuItem"
        Me.VideosToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.VideosToolStripMenuItem.Text = "Videos"
        Me.VideosToolStripMenuItem.Visible = False
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(161, 6)
        '
        'StickersToolStripMenuItem
        '
        Me.StickersToolStripMenuItem.Name = "StickersToolStripMenuItem"
        Me.StickersToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.StickersToolStripMenuItem.Text = "Image as Stickers"
        '
        'FrmAutoReply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 360)
        Me.Controls.Add(Me.ButtonEmoji)
        Me.Controls.Add(Me.BtnStrike)
        Me.Controls.Add(Me.BtnItalic)
        Me.Controls.Add(Me.BtnBold)
        Me.Controls.Add(Me.GroupBoxDivider)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.LabelAttachment)
        Me.Controls.Add(Me.LabelMessage)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ListViewAttachment)
        Me.Controls.Add(Me.TextBoxMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAutoReply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoReply Message"
        Me.ContextMenuMediaType.ResumeLayout(False)
        Me.ContextMenuStripAttachFiles.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEmoji As Button
    Friend WithEvents BtnStrike As Button
    Friend WithEvents BtnItalic As Button
    Friend WithEvents BtnBold As Button
    Friend WithEvents GroupBoxDivider As GroupBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents LabelAttachment As Label
    Friend WithEvents LabelMessage As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ListViewAttachment As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TextBoxMessage As TextBox
    Friend WithEvents ContextMenuStripAttachFiles As ContextMenuStrip
    Friend WithEvents PhotosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As ToolStripSeparator
    Friend WithEvents StickersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuMediaType As ContextMenuStrip
    Friend WithEvents SetCaptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
End Class
