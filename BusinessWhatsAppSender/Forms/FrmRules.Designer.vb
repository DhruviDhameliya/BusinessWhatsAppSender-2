<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRules
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
        Me.TextBoxRuleName = New System.Windows.Forms.TextBox()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.TextBoxKeyword = New System.Windows.Forms.TextBox()
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
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.LabelRuleName = New System.Windows.Forms.Label()
        Me.LabelKeyword = New System.Windows.Forms.Label()
        Me.LabelMessage = New System.Windows.Forms.Label()
        Me.LabelAttachment = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.GroupBoxDivider = New System.Windows.Forms.GroupBox()
        Me.BtnStrike = New System.Windows.Forms.Button()
        Me.BtnItalic = New System.Windows.Forms.Button()
        Me.BtnBold = New System.Windows.Forms.Button()
        Me.ButtonEmoji = New System.Windows.Forms.Button()
        Me.CheckBoxEnable = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStripAttachFiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PhotosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator()
        Me.StickersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ContextMenuMediaType.SuspendLayout()
        Me.ContextMenuStripAttachFiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxRuleName
        '
        Me.TextBoxRuleName.Location = New System.Drawing.Point(12, 26)
        Me.TextBoxRuleName.Name = "TextBoxRuleName"
        Me.TextBoxRuleName.Size = New System.Drawing.Size(178, 20)
        Me.TextBoxRuleName.TabIndex = 0
        '
        'TextBoxMessage
        '
        Me.TextBoxMessage.Location = New System.Drawing.Point(12, 71)
        Me.TextBoxMessage.Multiline = True
        Me.TextBoxMessage.Name = "TextBoxMessage"
        Me.TextBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMessage.Size = New System.Drawing.Size(450, 95)
        Me.TextBoxMessage.TabIndex = 1
        '
        'TextBoxKeyword
        '
        Me.TextBoxKeyword.Location = New System.Drawing.Point(320, 26)
        Me.TextBoxKeyword.Name = "TextBoxKeyword"
        Me.TextBoxKeyword.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxKeyword.TabIndex = 2
        '
        'ListViewAttachment
        '
        Me.ListViewAttachment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListViewAttachment.ContextMenuStrip = Me.ContextMenuMediaType
        Me.ListViewAttachment.FullRowSelect = True
        Me.ListViewAttachment.HideSelection = False
        Me.ListViewAttachment.Location = New System.Drawing.Point(12, 204)
        Me.ListViewAttachment.Name = "ListViewAttachment"
        Me.ListViewAttachment.Size = New System.Drawing.Size(450, 124)
        Me.ListViewAttachment.TabIndex = 3
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
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(390, 374)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 34)
        Me.ButtonOK.TabIndex = 4
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(309, 374)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 34)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'LabelRuleName
        '
        Me.LabelRuleName.AutoSize = True
        Me.LabelRuleName.Location = New System.Drawing.Point(12, 10)
        Me.LabelRuleName.Name = "LabelRuleName"
        Me.LabelRuleName.Size = New System.Drawing.Size(60, 13)
        Me.LabelRuleName.TabIndex = 6
        Me.LabelRuleName.Text = "Rule Name"
        '
        'LabelKeyword
        '
        Me.LabelKeyword.AutoSize = True
        Me.LabelKeyword.Location = New System.Drawing.Point(192, 9)
        Me.LabelKeyword.Name = "LabelKeyword"
        Me.LabelKeyword.Size = New System.Drawing.Size(48, 13)
        Me.LabelKeyword.TabIndex = 7
        Me.LabelKeyword.Text = "Keyword"
        '
        'LabelMessage
        '
        Me.LabelMessage.AutoSize = True
        Me.LabelMessage.Location = New System.Drawing.Point(12, 55)
        Me.LabelMessage.Name = "LabelMessage"
        Me.LabelMessage.Size = New System.Drawing.Size(50, 13)
        Me.LabelMessage.TabIndex = 8
        Me.LabelMessage.Text = "Message"
        '
        'LabelAttachment
        '
        Me.LabelAttachment.AutoSize = True
        Me.LabelAttachment.Location = New System.Drawing.Point(12, 186)
        Me.LabelAttachment.Name = "LabelAttachment"
        Me.LabelAttachment.Size = New System.Drawing.Size(64, 13)
        Me.LabelAttachment.TabIndex = 9
        Me.LabelAttachment.Text = "Attachment "
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(12, 332)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(80, 26)
        Me.ButtonAdd.TabIndex = 10
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonModify
        '
        Me.ButtonModify.Location = New System.Drawing.Point(92, 332)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(80, 26)
        Me.ButtonModify.TabIndex = 11
        Me.ButtonModify.Text = "Modify"
        Me.ButtonModify.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(172, 332)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(80, 26)
        Me.ButtonDelete.TabIndex = 12
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(252, 332)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(80, 26)
        Me.ButtonClear.TabIndex = 13
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'GroupBoxDivider
        '
        Me.GroupBoxDivider.Location = New System.Drawing.Point(-12, 363)
        Me.GroupBoxDivider.Name = "GroupBoxDivider"
        Me.GroupBoxDivider.Size = New System.Drawing.Size(521, 7)
        Me.GroupBoxDivider.TabIndex = 14
        Me.GroupBoxDivider.TabStop = False
        '
        'BtnStrike
        '
        Me.BtnStrike.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnStrike.FlatAppearance.BorderSize = 0
        Me.BtnStrike.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnStrike.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStrike.ForeColor = System.Drawing.Color.Black
        Me.BtnStrike.Location = New System.Drawing.Point(431, 170)
        Me.BtnStrike.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStrike.Name = "BtnStrike"
        Me.BtnStrike.Size = New System.Drawing.Size(29, 25)
        Me.BtnStrike.TabIndex = 103
        Me.BtnStrike.Text = "S "
        Me.BtnStrike.UseVisualStyleBackColor = False
        '
        'BtnItalic
        '
        Me.BtnItalic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnItalic.FlatAppearance.BorderSize = 0
        Me.BtnItalic.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnItalic.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItalic.ForeColor = System.Drawing.Color.Black
        Me.BtnItalic.Location = New System.Drawing.Point(400, 170)
        Me.BtnItalic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnItalic.Name = "BtnItalic"
        Me.BtnItalic.Size = New System.Drawing.Size(29, 25)
        Me.BtnItalic.TabIndex = 102
        Me.BtnItalic.Text = "I"
        Me.BtnItalic.UseVisualStyleBackColor = False
        '
        'BtnBold
        '
        Me.BtnBold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnBold.FlatAppearance.BorderSize = 0
        Me.BtnBold.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnBold.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBold.ForeColor = System.Drawing.Color.Black
        Me.BtnBold.Location = New System.Drawing.Point(371, 170)
        Me.BtnBold.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBold.Name = "BtnBold"
        Me.BtnBold.Size = New System.Drawing.Size(29, 25)
        Me.BtnBold.TabIndex = 101
        Me.BtnBold.Text = "B"
        Me.BtnBold.UseVisualStyleBackColor = False
        '
        'ButtonEmoji
        '
        Me.ButtonEmoji.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.ButtonEmoji.FlatAppearance.BorderSize = 0
        Me.ButtonEmoji.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonEmoji.Font = New System.Drawing.Font("Wingdings", 12.0!)
        Me.ButtonEmoji.ForeColor = System.Drawing.Color.Black
        Me.ButtonEmoji.Location = New System.Drawing.Point(342, 170)
        Me.ButtonEmoji.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEmoji.Name = "ButtonEmoji"
        Me.ButtonEmoji.Size = New System.Drawing.Size(29, 25)
        Me.ButtonEmoji.TabIndex = 105
        Me.ButtonEmoji.Text = "J"
        Me.ButtonEmoji.UseVisualStyleBackColor = False
        '
        'CheckBoxEnable
        '
        Me.CheckBoxEnable.AutoSize = True
        Me.CheckBoxEnable.Checked = True
        Me.CheckBoxEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxEnable.Location = New System.Drawing.Point(11, 383)
        Me.CheckBoxEnable.Name = "CheckBoxEnable"
        Me.CheckBoxEnable.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxEnable.TabIndex = 108
        Me.CheckBoxEnable.Text = "Enable rule"
        Me.CheckBoxEnable.UseVisualStyleBackColor = True
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
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"=", "Like", "Start with", "End with", "Contains"})
        Me.ComboBox1.Location = New System.Drawing.Point(195, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 109
        '
        'FrmRules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 418)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBoxEnable)
        Me.Controls.Add(Me.ButtonEmoji)
        Me.Controls.Add(Me.BtnStrike)
        Me.Controls.Add(Me.BtnItalic)
        Me.Controls.Add(Me.BtnBold)
        Me.Controls.Add(Me.GroupBoxDivider)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonModify)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.LabelAttachment)
        Me.Controls.Add(Me.LabelMessage)
        Me.Controls.Add(Me.LabelKeyword)
        Me.Controls.Add(Me.LabelRuleName)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ListViewAttachment)
        Me.Controls.Add(Me.TextBoxKeyword)
        Me.Controls.Add(Me.TextBoxMessage)
        Me.Controls.Add(Me.TextBoxRuleName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rules"
        Me.ContextMenuMediaType.ResumeLayout(False)
        Me.ContextMenuStripAttachFiles.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxRuleName As TextBox
    Friend WithEvents TextBoxMessage As TextBox
    Friend WithEvents TextBoxKeyword As TextBox
    Friend WithEvents ListViewAttachment As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents LabelRuleName As Label
    Friend WithEvents LabelKeyword As Label
    Friend WithEvents LabelMessage As Label
    Friend WithEvents LabelAttachment As Label
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents GroupBoxDivider As GroupBox
    Friend WithEvents BtnStrike As Button
    Friend WithEvents BtnItalic As Button
    Friend WithEvents BtnBold As Button
    Friend WithEvents ButtonEmoji As Button
    Friend WithEvents CheckBoxEnable As CheckBox
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
    Friend WithEvents ComboBox1 As ComboBox
End Class
