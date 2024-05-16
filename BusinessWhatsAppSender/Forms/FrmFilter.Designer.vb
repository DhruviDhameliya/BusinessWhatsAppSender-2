<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFilter))
        Me.TimerVerification = New System.Windows.Forms.Timer(Me.components)
        Me.ListViewNumbers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumericUpDownDelay = New System.Windows.Forms.NumericUpDown()
        Me.ButtonImportFromFile = New System.Windows.Forms.Button()
        Me.ButtonManualImport = New System.Windows.Forms.Button()
        Me.ButtonNumberGenerator = New System.Windows.Forms.Button()
        Me.ButtonExport = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStripExport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.WhatsAppOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusinessWhatsAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegularWhatsAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NonWhatsAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelWhatsApp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelBusiness = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelRegular = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProgressBarRequest = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.LabelRequestProgress = New System.Windows.Forms.Label()
        Me.LabelVerificationProgress = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonImporttosender = New System.Windows.Forms.Button()
        Me.ContextMenuStripImport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImportAllWhatsAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportRegularWhatsAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportBusinessWhatsAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripExport.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStripImport.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerVerification
        '
        Me.TimerVerification.Enabled = True
        Me.TimerVerification.Interval = 1000
        '
        'ListViewNumbers
        '
        Me.ListViewNumbers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewNumbers.FullRowSelect = True
        Me.ListViewNumbers.GridLines = True
        Me.ListViewNumbers.HideSelection = False
        Me.ListViewNumbers.Location = New System.Drawing.Point(8, 78)
        Me.ListViewNumbers.Name = "ListViewNumbers"
        Me.ListViewNumbers.Size = New System.Drawing.Size(584, 290)
        Me.ListViewNumbers.TabIndex = 0
        Me.ListViewNumbers.UseCompatibleStateImageBehavior = False
        Me.ListViewNumbers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 174
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Number"
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        Me.ColumnHeader3.Width = 69
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 76
        '
        'NumericUpDownDelay
        '
        Me.NumericUpDownDelay.Location = New System.Drawing.Point(9, 16)
        Me.NumericUpDownDelay.Name = "NumericUpDownDelay"
        Me.NumericUpDownDelay.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDownDelay.TabIndex = 0
        '
        'ButtonImportFromFile
        '
        Me.ButtonImportFromFile.FlatAppearance.BorderSize = 0
        Me.ButtonImportFromFile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonImportFromFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportFromFile.ForeColor = System.Drawing.Color.Black
        Me.ButtonImportFromFile.Location = New System.Drawing.Point(7, 20)
        Me.ButtonImportFromFile.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonImportFromFile.Name = "ButtonImportFromFile"
        Me.ButtonImportFromFile.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonImportFromFile.Size = New System.Drawing.Size(60, 30)
        Me.ButtonImportFromFile.TabIndex = 106
        Me.ButtonImportFromFile.Text = "Files"
        Me.ButtonImportFromFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonImportFromFile.UseVisualStyleBackColor = False
        '
        'ButtonManualImport
        '
        Me.ButtonManualImport.FlatAppearance.BorderSize = 0
        Me.ButtonManualImport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonManualImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManualImport.ForeColor = System.Drawing.Color.Black
        Me.ButtonManualImport.Location = New System.Drawing.Point(68, 20)
        Me.ButtonManualImport.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonManualImport.Name = "ButtonManualImport"
        Me.ButtonManualImport.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonManualImport.Size = New System.Drawing.Size(57, 30)
        Me.ButtonManualImport.TabIndex = 107
        Me.ButtonManualImport.Text = "Manual"
        Me.ButtonManualImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonManualImport.UseVisualStyleBackColor = False
        '
        'ButtonNumberGenerator
        '
        Me.ButtonNumberGenerator.FlatAppearance.BorderSize = 0
        Me.ButtonNumberGenerator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonNumberGenerator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNumberGenerator.ForeColor = System.Drawing.Color.Black
        Me.ButtonNumberGenerator.Location = New System.Drawing.Point(125, 20)
        Me.ButtonNumberGenerator.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonNumberGenerator.Name = "ButtonNumberGenerator"
        Me.ButtonNumberGenerator.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonNumberGenerator.Size = New System.Drawing.Size(108, 30)
        Me.ButtonNumberGenerator.TabIndex = 108
        Me.ButtonNumberGenerator.Text = "Numbers Generator"
        Me.ButtonNumberGenerator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonNumberGenerator.UseVisualStyleBackColor = False
        '
        'ButtonExport
        '
        Me.ButtonExport.FlatAppearance.BorderSize = 0
        Me.ButtonExport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExport.ForeColor = System.Drawing.Color.Black
        Me.ButtonExport.Location = New System.Drawing.Point(518, 35)
        Me.ButtonExport.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonExport.Size = New System.Drawing.Size(72, 30)
        Me.ButtonExport.TabIndex = 115
        Me.ButtonExport.Text = "Export"
        Me.ButtonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExport.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Total:"
        '
        'ContextMenuStripExport
        '
        Me.ContextMenuStripExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportAllToolStripMenuItem, Me.ToolStripMenuItem1, Me.WhatsAppOnlyToolStripMenuItem, Me.BusinessWhatsAppToolStripMenuItem, Me.RegularWhatsAppToolStripMenuItem, Me.ToolStripMenuItem2, Me.NonWhatsAppToolStripMenuItem})
        Me.ContextMenuStripExport.Name = "ContextMenuStripExport"
        Me.ContextMenuStripExport.Size = New System.Drawing.Size(178, 126)
        '
        'ExportAllToolStripMenuItem
        '
        Me.ExportAllToolStripMenuItem.Name = "ExportAllToolStripMenuItem"
        Me.ExportAllToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ExportAllToolStripMenuItem.Text = "Export All"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 6)
        '
        'WhatsAppOnlyToolStripMenuItem
        '
        Me.WhatsAppOnlyToolStripMenuItem.Name = "WhatsAppOnlyToolStripMenuItem"
        Me.WhatsAppOnlyToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.WhatsAppOnlyToolStripMenuItem.Text = "WhatsApp Only"
        '
        'BusinessWhatsAppToolStripMenuItem
        '
        Me.BusinessWhatsAppToolStripMenuItem.Name = "BusinessWhatsAppToolStripMenuItem"
        Me.BusinessWhatsAppToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BusinessWhatsAppToolStripMenuItem.Text = "Business WhatsApp"
        '
        'RegularWhatsAppToolStripMenuItem
        '
        Me.RegularWhatsAppToolStripMenuItem.Name = "RegularWhatsAppToolStripMenuItem"
        Me.RegularWhatsAppToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RegularWhatsAppToolStripMenuItem.Text = "Regular WhatsApp"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 6)
        '
        'NonWhatsAppToolStripMenuItem
        '
        Me.NonWhatsAppToolStripMenuItem.Name = "NonWhatsAppToolStripMenuItem"
        Me.NonWhatsAppToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NonWhatsAppToolStripMenuItem.Text = "Non WhatsApp"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(368, 455)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(2)
        Me.Button1.Size = New System.Drawing.Size(124, 32)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Start Checking"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonStop
        '
        Me.ButtonStop.Enabled = False
        Me.ButtonStop.FlatAppearance.BorderSize = 0
        Me.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStop.ForeColor = System.Drawing.Color.Black
        Me.ButtonStop.Location = New System.Drawing.Point(240, 455)
        Me.ButtonStop.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonStop.Size = New System.Drawing.Size(124, 32)
        Me.ButtonStop.TabIndex = 122
        Me.ButtonStop.Text = "Stop "
        Me.ButtonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonStop.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownDelay)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 448)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 42)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delay"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sec"
        '
        'LabelTotal
        '
        Me.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTotal.Location = New System.Drawing.Point(47, 372)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(76, 16)
        Me.LabelTotal.TabIndex = 124
        '
        'LabelWhatsApp
        '
        Me.LabelWhatsApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelWhatsApp.Location = New System.Drawing.Point(202, 372)
        Me.LabelWhatsApp.Name = "LabelWhatsApp"
        Me.LabelWhatsApp.Size = New System.Drawing.Size(76, 16)
        Me.LabelWhatsApp.TabIndex = 126
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(133, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "WhatsApp:"
        '
        'LabelBusiness
        '
        Me.LabelBusiness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBusiness.Location = New System.Drawing.Point(512, 372)
        Me.LabelBusiness.Name = "LabelBusiness"
        Me.LabelBusiness.Size = New System.Drawing.Size(80, 16)
        Me.LabelBusiness.TabIndex = 130
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(437, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 16)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "Business"
        '
        'LabelRegular
        '
        Me.LabelRegular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelRegular.Location = New System.Drawing.Point(339, 372)
        Me.LabelRegular.Name = "LabelRegular"
        Me.LabelRegular.Size = New System.Drawing.Size(78, 16)
        Me.LabelRegular.TabIndex = 128
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(289, 372)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "Normal:"
        '
        'ProgressBarRequest
        '
        Me.ProgressBarRequest.Location = New System.Drawing.Point(7, 407)
        Me.ProgressBarRequest.Name = "ProgressBarRequest"
        Me.ProgressBarRequest.Size = New System.Drawing.Size(585, 9)
        Me.ProgressBarRequest.TabIndex = 131
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(7, 432)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(585, 9)
        Me.ProgressBar2.TabIndex = 132
        '
        'LabelRequestProgress
        '
        Me.LabelRequestProgress.AutoSize = True
        Me.LabelRequestProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRequestProgress.Location = New System.Drawing.Point(7, 392)
        Me.LabelRequestProgress.Name = "LabelRequestProgress"
        Me.LabelRequestProgress.Size = New System.Drawing.Size(79, 12)
        Me.LabelRequestProgress.TabIndex = 133
        Me.LabelRequestProgress.Text = "Request Progress"
        '
        'LabelVerificationProgress
        '
        Me.LabelVerificationProgress.AutoSize = True
        Me.LabelVerificationProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerificationProgress.Location = New System.Drawing.Point(6, 418)
        Me.LabelVerificationProgress.Name = "LabelVerificationProgress"
        Me.LabelVerificationProgress.Size = New System.Drawing.Size(91, 12)
        Me.LabelVerificationProgress.TabIndex = 134
        Me.LabelVerificationProgress.Text = "Verification Progress"
        '
        'ButtonClear
        '
        Me.ButtonClear.FlatAppearance.BorderSize = 0
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.Black
        Me.ButtonClear.Location = New System.Drawing.Point(358, 35)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonClear.Size = New System.Drawing.Size(66, 30)
        Me.ButtonClear.TabIndex = 135
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.Black
        Me.ButtonClose.Location = New System.Drawing.Point(502, 454)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Size = New System.Drawing.Size(90, 32)
        Me.ButtonClose.TabIndex = 136
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonImportFromFile)
        Me.GroupBox2.Controls.Add(Me.ButtonNumberGenerator)
        Me.GroupBox2.Controls.Add(Me.ButtonManualImport)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 58)
        Me.GroupBox2.TabIndex = 137
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Import"
        '
        'ButtonImporttosender
        '
        Me.ButtonImporttosender.FlatAppearance.BorderSize = 0
        Me.ButtonImporttosender.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonImporttosender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImporttosender.ForeColor = System.Drawing.Color.Black
        Me.ButtonImporttosender.Location = New System.Drawing.Point(425, 35)
        Me.ButtonImporttosender.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ButtonImporttosender.Name = "ButtonImporttosender"
        Me.ButtonImporttosender.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonImporttosender.Size = New System.Drawing.Size(92, 30)
        Me.ButtonImporttosender.TabIndex = 138
        Me.ButtonImporttosender.Text = "Import to Sender"
        Me.ButtonImporttosender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonImporttosender.UseVisualStyleBackColor = False
        '
        'ContextMenuStripImport
        '
        Me.ContextMenuStripImport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportAllWhatsAppToolStripMenuItem, Me.ToolStripMenuItem3, Me.ImportRegularWhatsAppToolStripMenuItem, Me.ImportBusinessWhatsAppToolStripMenuItem})
        Me.ContextMenuStripImport.Name = "ContextMenuStripImport"
        Me.ContextMenuStripImport.Size = New System.Drawing.Size(238, 76)
        '
        'ImportAllWhatsAppToolStripMenuItem
        '
        Me.ImportAllWhatsAppToolStripMenuItem.Name = "ImportAllWhatsAppToolStripMenuItem"
        Me.ImportAllWhatsAppToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ImportAllWhatsAppToolStripMenuItem.Text = "Import All WhatsApp Numbers"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(234, 6)
        '
        'ImportRegularWhatsAppToolStripMenuItem
        '
        Me.ImportRegularWhatsAppToolStripMenuItem.Name = "ImportRegularWhatsAppToolStripMenuItem"
        Me.ImportRegularWhatsAppToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ImportRegularWhatsAppToolStripMenuItem.Text = "Import Regular WhatsApp"
        '
        'ImportBusinessWhatsAppToolStripMenuItem
        '
        Me.ImportBusinessWhatsAppToolStripMenuItem.Name = "ImportBusinessWhatsAppToolStripMenuItem"
        Me.ImportBusinessWhatsAppToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ImportBusinessWhatsAppToolStripMenuItem.Text = "Import Business WhatsApp"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(254, 35)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(2)
        Me.Button2.Size = New System.Drawing.Size(103, 30)
        Me.Button2.TabIndex = 139
        Me.Button2.Text = "Insert Country Code"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FrmFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonImporttosender)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.LabelVerificationProgress)
        Me.Controls.Add(Me.LabelRequestProgress)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBarRequest)
        Me.Controls.Add(Me.LabelBusiness)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabelRegular)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabelWhatsApp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonExport)
        Me.Controls.Add(Me.ListViewNumbers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WhatsApp Numbers Filter"
        CType(Me.NumericUpDownDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripExport.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStripImport.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerVerification As Timer
    Friend WithEvents ListViewNumbers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents NumericUpDownDelay As NumericUpDown
    Friend WithEvents ButtonImportFromFile As Button
    Friend WithEvents ButtonManualImport As Button
    Friend WithEvents ButtonNumberGenerator As Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ButtonExport As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStripExport As ContextMenuStrip
    Friend WithEvents ExportAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents WhatsAppOnlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusinessWhatsAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegularWhatsAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents NonWhatsAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelWhatsApp As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelBusiness As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelRegular As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ProgressBarRequest As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents LabelRequestProgress As Label
    Friend WithEvents LabelVerificationProgress As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonImporttosender As Button
    Friend WithEvents ContextMenuStripImport As ContextMenuStrip
    Friend WithEvents ImportAllWhatsAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ImportRegularWhatsAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportBusinessWhatsAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
End Class
