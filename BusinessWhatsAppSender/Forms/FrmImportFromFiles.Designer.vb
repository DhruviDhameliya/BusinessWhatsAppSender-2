<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportFromFiles
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
        Me.TxtFileName = New System.Windows.Forms.TextBox()
        Me.BtnOpenDialog = New System.Windows.Forms.Button()
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.OpenFileDlg = New System.Windows.Forms.OpenFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxVar5Field = New System.Windows.Forms.ComboBox()
        Me.ComboBoxNameField = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxNumberField = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxVar1Field = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxVar4Field = New System.Windows.Forms.ComboBox()
        Me.ComboBoxVar2Field = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxVar3Field = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxDelimeter = New System.Windows.Forms.TextBox()
        Me.CheckBoxDelimeter = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRemoveDuplication = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFirstRow = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtFileName
        '
        Me.TxtFileName.Location = New System.Drawing.Point(7, 35)
        Me.TxtFileName.Name = "TxtFileName"
        Me.TxtFileName.Size = New System.Drawing.Size(357, 20)
        Me.TxtFileName.TabIndex = 0
        '
        'BtnOpenDialog
        '
        Me.BtnOpenDialog.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnOpenDialog.ForeColor = System.Drawing.Color.White
        Me.BtnOpenDialog.Location = New System.Drawing.Point(370, 33)
        Me.BtnOpenDialog.Name = "BtnOpenDialog"
        Me.BtnOpenDialog.Size = New System.Drawing.Size(57, 23)
        Me.BtnOpenDialog.TabIndex = 1
        Me.BtnOpenDialog.Text = "Browse"
        Me.BtnOpenDialog.UseVisualStyleBackColor = False
        '
        'BtnImport
        '
        Me.BtnImport.Location = New System.Drawing.Point(666, 540)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(75, 23)
        Me.BtnImport.TabIndex = 3
        Me.BtnImport.Text = "Import"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(589, 540)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(841, 150)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(106, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Files Format Samples"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(835, 182)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Remove duplication"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LblCount
        '
        Me.LblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCount.Location = New System.Drawing.Point(854, 205)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(153, 16)
        Me.LblCount.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(12, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(729, 342)
        Me.DataGridView1.TabIndex = 18
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(869, 254)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "First row as header"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name field"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtFileName)
        Me.GroupBox2.Controls.Add(Me.BtnOpenDialog)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(729, 171)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Import file"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(358, 31)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "To avoid errors , please import files in right structure and format files must be" &
    " (XLSX, CSV or TXT)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBoxVar5Field)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ComboBoxNameField)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ComboBoxNumberField)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ComboBoxVar1Field)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ComboBoxVar4Field)
        Me.GroupBox3.Controls.Add(Me.ComboBoxVar2Field)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ComboBoxVar3Field)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(721, 66)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Assign fields"
        '
        'ComboBoxVar5Field
        '
        Me.ComboBoxVar5Field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVar5Field.FormattingEnabled = True
        Me.ComboBoxVar5Field.Location = New System.Drawing.Point(615, 39)
        Me.ComboBoxVar5Field.Name = "ComboBoxVar5Field"
        Me.ComboBoxVar5Field.Size = New System.Drawing.Size(98, 21)
        Me.ComboBoxVar5Field.TabIndex = 20
        '
        'ComboBoxNameField
        '
        Me.ComboBoxNameField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNameField.FormattingEnabled = True
        Me.ComboBoxNameField.Location = New System.Drawing.Point(5, 39)
        Me.ComboBoxNameField.Name = "ComboBoxNameField"
        Me.ComboBoxNameField.Size = New System.Drawing.Size(106, 21)
        Me.ComboBoxNameField.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(112, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Number field"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxNumberField
        '
        Me.ComboBoxNumberField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNumberField.FormattingEnabled = True
        Me.ComboBoxNumberField.Location = New System.Drawing.Point(112, 39)
        Me.ComboBoxNumberField.Name = "ComboBoxNumberField"
        Me.ComboBoxNumberField.Size = New System.Drawing.Size(106, 21)
        Me.ComboBoxNumberField.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(219, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Var1 field"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxVar1Field
        '
        Me.ComboBoxVar1Field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVar1Field.FormattingEnabled = True
        Me.ComboBoxVar1Field.Location = New System.Drawing.Point(219, 39)
        Me.ComboBoxVar1Field.Name = "ComboBoxVar1Field"
        Me.ComboBoxVar1Field.Size = New System.Drawing.Size(98, 21)
        Me.ComboBoxVar1Field.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(615, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Var5 field"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(318, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Var2 field"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxVar4Field
        '
        Me.ComboBoxVar4Field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVar4Field.FormattingEnabled = True
        Me.ComboBoxVar4Field.Location = New System.Drawing.Point(516, 39)
        Me.ComboBoxVar4Field.Name = "ComboBoxVar4Field"
        Me.ComboBoxVar4Field.Size = New System.Drawing.Size(98, 21)
        Me.ComboBoxVar4Field.TabIndex = 18
        '
        'ComboBoxVar2Field
        '
        Me.ComboBoxVar2Field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVar2Field.FormattingEnabled = True
        Me.ComboBoxVar2Field.Location = New System.Drawing.Point(318, 39)
        Me.ComboBoxVar2Field.Name = "ComboBoxVar2Field"
        Me.ComboBoxVar2Field.Size = New System.Drawing.Size(98, 21)
        Me.ComboBoxVar2Field.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(516, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Var4 field"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(417, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Var3 field"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxVar3Field
        '
        Me.ComboBoxVar3Field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVar3Field.FormattingEnabled = True
        Me.ComboBoxVar3Field.Location = New System.Drawing.Point(417, 39)
        Me.ComboBoxVar3Field.Name = "ComboBoxVar3Field"
        Me.ComboBoxVar3Field.Size = New System.Drawing.Size(98, 21)
        Me.ComboBoxVar3Field.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxDelimeter)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDelimeter)
        Me.GroupBox1.Controls.Add(Me.CheckBoxRemoveDuplication)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFirstRow)
        Me.GroupBox1.Location = New System.Drawing.Point(435, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 70)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'TextBoxDelimeter
        '
        Me.TextBoxDelimeter.Enabled = False
        Me.TextBoxDelimeter.Location = New System.Drawing.Point(164, 38)
        Me.TextBoxDelimeter.Name = "TextBoxDelimeter"
        Me.TextBoxDelimeter.Size = New System.Drawing.Size(106, 20)
        Me.TextBoxDelimeter.TabIndex = 3
        '
        'CheckBoxDelimeter
        '
        Me.CheckBoxDelimeter.AutoSize = True
        Me.CheckBoxDelimeter.Location = New System.Drawing.Point(164, 15)
        Me.CheckBoxDelimeter.Name = "CheckBoxDelimeter"
        Me.CheckBoxDelimeter.Size = New System.Drawing.Size(106, 17)
        Me.CheckBoxDelimeter.TabIndex = 2
        Me.CheckBoxDelimeter.Text = "Custom delimeter"
        Me.CheckBoxDelimeter.UseVisualStyleBackColor = True
        '
        'CheckBoxRemoveDuplication
        '
        Me.CheckBoxRemoveDuplication.Location = New System.Drawing.Point(8, 42)
        Me.CheckBoxRemoveDuplication.Name = "CheckBoxRemoveDuplication"
        Me.CheckBoxRemoveDuplication.Size = New System.Drawing.Size(134, 16)
        Me.CheckBoxRemoveDuplication.TabIndex = 1
        Me.CheckBoxRemoveDuplication.Text = "Remove duplications"
        Me.CheckBoxRemoveDuplication.UseVisualStyleBackColor = True
        '
        'CheckBoxFirstRow
        '
        Me.CheckBoxFirstRow.AutoSize = True
        Me.CheckBoxFirstRow.Location = New System.Drawing.Point(8, 18)
        Me.CheckBoxFirstRow.Name = "CheckBoxFirstRow"
        Me.CheckBoxFirstRow.Size = New System.Drawing.Size(134, 17)
        Me.CheckBoxFirstRow.TabIndex = 0
        Me.CheckBoxFirstRow.Text = "Use first row as header"
        Me.CheckBoxFirstRow.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Select file to import"
        '
        'LabelStatus
        '
        Me.LabelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelStatus.Location = New System.Drawing.Point(12, 535)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(259, 21)
        Me.LabelStatus.TabIndex = 20
        '
        'FrmImportFromFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(746, 572)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblCount)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnImport)
        Me.Controls.Add(Me.CheckBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportFromFiles"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From File"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFileName As TextBox
    Friend WithEvents BtnOpenDialog As Button
    Friend WithEvents BtnImport As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents OpenFileDlg As OpenFileDialog
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LblCount As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxDelimeter As TextBox
    Friend WithEvents CheckBoxDelimeter As CheckBox
    Friend WithEvents CheckBoxRemoveDuplication As CheckBox
    Friend WithEvents CheckBoxFirstRow As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxVar5Field As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxVar4Field As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxVar3Field As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxVar2Field As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxVar1Field As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxNumberField As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxNameField As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelStatus As Label
End Class
