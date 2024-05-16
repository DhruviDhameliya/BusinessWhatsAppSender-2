<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmManualImports
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
        Me.TxtNumbers = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstNumbers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.CheckBoxRemoveDuplication = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelDuplication = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtNumbers
        '
        Me.TxtNumbers.Location = New System.Drawing.Point(12, 29)
        Me.TxtNumbers.Multiline = True
        Me.TxtNumbers.Name = "TxtNumbers"
        Me.TxtNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNumbers.Size = New System.Drawing.Size(403, 126)
        Me.TxtNumbers.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(253, 403)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnImport
        '
        Me.BtnImport.Location = New System.Drawing.Point(334, 403)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(75, 23)
        Me.BtnImport.TabIndex = 10
        Me.BtnImport.Text = "Import"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Enter contacts"
        '
        'LstNumbers
        '
        Me.LstNumbers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LstNumbers.FullRowSelect = True
        Me.LstNumbers.GridLines = True
        Me.LstNumbers.HideSelection = False
        Me.LstNumbers.Location = New System.Drawing.Point(8, 208)
        Me.LstNumbers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LstNumbers.Name = "LstNumbers"
        Me.LstNumbers.Size = New System.Drawing.Size(401, 163)
        Me.LstNumbers.TabIndex = 14
        Me.LstNumbers.UseCompatibleStateImageBehavior = False
        Me.LstNumbers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Numbers"
        Me.ColumnHeader2.Width = 180
        '
        'LabelCount
        '
        Me.LabelCount.Location = New System.Drawing.Point(8, 375)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(156, 18)
        Me.LabelCount.TabIndex = 17
        Me.LabelCount.Text = "Total:"
        '
        'CheckBoxRemoveDuplication
        '
        Me.CheckBoxRemoveDuplication.AutoSize = True
        Me.CheckBoxRemoveDuplication.Checked = True
        Me.CheckBoxRemoveDuplication.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRemoveDuplication.Location = New System.Drawing.Point(8, 406)
        Me.CheckBoxRemoveDuplication.Name = "CheckBoxRemoveDuplication"
        Me.CheckBoxRemoveDuplication.Size = New System.Drawing.Size(120, 17)
        Me.CheckBoxRemoveDuplication.TabIndex = 18
        Me.CheckBoxRemoveDuplication.Text = "Remove duplication"
        Me.CheckBoxRemoveDuplication.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Line per number , you can name by enter name comma then mobile (name,number)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Validated contacts"
        '
        'LabelDuplication
        '
        Me.LabelDuplication.Location = New System.Drawing.Point(170, 375)
        Me.LabelDuplication.Name = "LabelDuplication"
        Me.LabelDuplication.Size = New System.Drawing.Size(156, 18)
        Me.LabelDuplication.TabIndex = 21
        Me.LabelDuplication.Text = "Duplication:"
        '
        'FrmManualImports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 431)
        Me.Controls.Add(Me.LabelDuplication)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxRemoveDuplication)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.LstNumbers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnImport)
        Me.Controls.Add(Me.TxtNumbers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmManualImports"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual Import"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNumbers As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnImport As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LstNumbers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents LabelCount As Label
    Friend WithEvents CheckBoxRemoveDuplication As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelDuplication As Label
End Class
