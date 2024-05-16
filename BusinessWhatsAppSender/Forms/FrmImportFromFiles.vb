Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class FrmImportFromFiles
    Public SourceForm As Integer

    Public currentFileName As String


    Public ImportResults As New List(Of WhatsAppContact)
    Public CurrentImportContext As FileImports

    Private Sub BtnOpenDialog_Click(sender As Object, e As EventArgs) Handles BtnOpenDialog.Click
        Try
            OpenFileDlg.Filter = "Excel Files|*.xlsx|Comma-separated values files|*.csv|Text Files|*.txt"
            Dim lst As New List(Of String)
            If OpenFileDlg.ShowDialog = DialogResult.OK Then
                Dim FileName As String = OpenFileDlg.FileName
                currentFileName = FileName
                TxtFileName.Text = FileName
                Dim Extention As String = Path.GetExtension(FileName).ToLower()
                Dim Numdt As New DataTable
                Dim dt As DataTable
                If Extention = ".xlsx" Then
                    dt = DataTableFromExcel(FileName, CheckBoxFirstRow.Checked)
                    DataGridView1.DataSource = dt
                    Fillcombo(dt)
                Else
                    dt = DataTableFromText(FileName, CheckBoxFirstRow.Checked)
                    DataGridView1.DataSource = dt
                    Fillcombo(dt)
                End If
                UpdateStatus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, ApplicationTitle)
        End Try


    End Sub
    Public Function CleanNumber(ByVal Number As String) As String
        Dim num As Char
        Dim result As String = ""
        For Each num In Number
            If IsNumeric(num) Then
                result = result & num
            End If
        Next
        Return result
    End Function

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click

        Try


            If DataGridView1.RowCount = 0 Then
                MsgBox("Empty list")
                Exit Sub
            End If

            ImportResults.Clear()
            Dim _contacts As WhatsAppContact
            Dim _TempDuplicationChecklist As New List(Of String)
            _TempDuplicationChecklist.Clear()
            Dim dr As DataGridViewRow
            Dim col As New DataGridViewColumn


            For Each dr In DataGridView1.Rows



                If Not IsDBNull(dr.Cells.Item(ComboBoxNumberField.Text).Value) Then

                    If Not _TempDuplicationChecklist.Contains(dr.Cells.Item(ComboBoxNumberField.Text).Value) Then
                        If Not IsDBNull(dr.Cells.Item(ComboBoxNumberField.Text).Value) Then
                            If CleanNumber(dr.Cells.Item(ComboBoxNumberField.Text).Value) <> "" Then
                                _contacts = New WhatsAppContact
                                If ComboBoxNumberField.Text <> "" Then
                                    If Not IsDBNull(dr.Cells.Item(ComboBoxNumberField.Text).Value) Then
                                        _contacts.WhatsAppID = CleanNumber(dr.Cells.Item(ComboBoxNumberField.Text).Value) & "@c.us"
                                    End If
                                End If
                                If ComboBoxNumberField.Text <> "" Then
                                    If Not IsDBNull(dr.Cells.Item(ComboBoxNumberField.Text).Value) Then
                                        _contacts.WhatsAppContact = CleanNumber(dr.Cells.Item(ComboBoxNumberField.Text).Value)
                                    End If
                                End If
                                If ComboBoxNumberField.Text <> "" Then
                                    If Not IsDBNull(dr.Cells.Item(ComboBoxNameField.Text).Value) Then
                                        _contacts.WhatsAppName = dr.Cells.Item(ComboBoxNameField.Text).Value
                                    End If
                                End If
                                If ComboBoxVar1Field.Text <> "" Then
                                    If Not IsDBNull(dr.Cells.Item(ComboBoxVar1Field.Text).Value) Then
                                        _contacts.Var1 = dr.Cells.Item(ComboBoxVar1Field.Text).Value
                                    End If
                                End If
                                If ComboBoxVar2Field.Text <> "" Then
                                    If Not IsDBNull(dr.Cells.Item(ComboBoxVar2Field.Text).Value) Then
                                        _contacts.Var2 = dr.Cells.Item(ComboBoxVar2Field.Text).Value
                                    End If
                                End If
                                If ComboBoxVar3Field.Text <> "" Then
                                    If Not IsDBNull(dr.Cells.Item(ComboBoxVar3Field.Text).Value) Then
                                        _contacts.Var3 = dr.Cells.Item(ComboBoxVar3Field.Text).Value
                                    End If
                                End If
                                If ComboBoxVar4Field.Text <> "" Then
                                    If Not IsDBNull(dr.Cells.Item(ComboBoxVar4Field.Text).Value) Then
                                        _contacts.Var4 = dr.Cells.Item(ComboBoxVar4Field.Text).Value
                                    End If
                                End If
                                If ComboBoxVar5Field.Text <> "" Then
                                    If Not IsDBNull(dr.Cells.Item(ComboBoxVar5Field.Text).Value) Then
                                        _contacts.Var5 = dr.Cells.Item(ComboBoxVar5Field.Text).Value
                                    End If
                                End If
                                ImportResults.Add(_contacts)
                            End If
                        End If
                    End If
                End If

                If CheckBoxRemoveDuplication.Checked Then
                    If Not IsDBNull(dr.Cells.Item(ComboBoxNumberField.Text).Value) Then
                        If CleanNumber(dr.Cells.Item(ComboBoxNumberField.Text).Value) <> "" Then
                            _TempDuplicationChecklist.Add(CleanNumber(dr.Cells.Item(ComboBoxNumberField.Text).Value))
                        End If
                    End If
                End If
            Next
            CurrentImportContext.Contacts = ImportResults
            CurrentImportContext.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, Application.ProductName)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        CurrentImportContext.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FrmImportFromFiles_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub FrmImportFromFiles_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Function DataTableFromExcel(ByVal FileName As String, Optional Hedear As Boolean = False) As DataTable
        Try
            Dim std As String = ""
            If Hedear Then
                std = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""" & FileName & """;Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;"";Persist Security Info=False"
            Else
                std = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""" & FileName & """;Extended Properties=""Excel 8.0;HDR=NO;IMEX=1;"";Persist Security Info=False"
            End If

            Dim conn As New OleDb.OleDbConnection(std)
            conn.Open()
            Dim TableName As String = conn.GetSchema("Tables").Rows(0)("TABLE_NAME")
            conn.Close()
            conn.Dispose()
            Dim da As New OleDb.OleDbDataAdapter("select * from [" & TableName & "]", std)


            Dim dt As New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
                Return dt
        Catch ex As Exception
            If ex.Message.Contains("Microsoft.ACE") Then
                If MsgBox(ex.Message & vbNewLine & vbNewLine & "Microsoft Access Database Engine not insalled or 64 bit are installed in order to solve it please install Access Database Engine and if 64 bit version installed please uninstall it and install the x86 version " & vbNewLine & vbNewLine & "Do you want to install it?", vbCritical + MsgBoxStyle.YesNo, Application.ProductName) = MsgBoxResult.Yes Then
                    Process.Start(Application.StartupPath & "\AccessDatabaseEngine.exe")
                End If
            Else
                MsgBox(ex.Message, vbCritical, Application.ProductName)
            End If

            Return New DataTable
        End Try


    End Function
    Private Function DataTableFromText(ByVal fileName As String, ByVal Optional firstRowContainsFieldNames As Boolean = True) As DataTable
        Try


            Dim result As DataTable = New DataTable()

            If fileName = "" Then
                Return result
            End If

            Dim delimiters As String = ","
            If TextBoxDelimeter.Text <> "" Then
                delimiters = TextBoxDelimeter.Text
            End If
            Dim extension As String = Path.GetExtension(fileName)

            If extension.ToLower() = ".txt" Then
                delimiters = vbTab
            ElseIf extension.ToLower() = ".csv" Then
                Dim fileContent As String = File.ReadAllText(fileName)
                If fileContent.Contains(";") Then
                    delimiters = ";"
                Else
                    delimiters = ","
                End If
            End If

            Using tfp As TextFieldParser = New FileIO.TextFieldParser(fileName)
                tfp.SetDelimiters(delimiters)

                If Not tfp.EndOfData Then
                    Dim fields As String() = tfp.ReadFields()

                    For i As Integer = 0 To fields.Count() - 1

                        If firstRowContainsFieldNames Then
                            result.Columns.Add(fields(i))
                        Else
                            result.Columns.Add("Col" & i)
                        End If
                    Next

                    If Not firstRowContainsFieldNames Then result.Rows.Add(fields)
                End If

                While Not tfp.EndOfData
                    result.Rows.Add(tfp.ReadFields())
                End While
            End Using

            Return result

        Catch ex As Exception
            Return New DataTable
        End Try
    End Function
    Sub Fillcombo(ByVal dt As DataTable)
        Dim dc As DataColumn
        ComboBoxNameField.Items.Clear()
        ComboBoxNumberField.Items.Clear()
        ComboBoxVar1Field.Items.Clear()
        ComboBoxVar2Field.Items.Clear()
        ComboBoxVar3Field.Items.Clear()
        ComboBoxVar4Field.Items.Clear()
        ComboBoxVar5Field.Items.Clear()

        For Each dc In dt.Columns
            ComboBoxNameField.Items.Add(dc.ColumnName)
            ComboBoxNumberField.Items.Add(dc.ColumnName)
            ComboBoxVar1Field.Items.Add(dc.ColumnName)
            ComboBoxVar2Field.Items.Add(dc.ColumnName)
            ComboBoxVar3Field.Items.Add(dc.ColumnName)
            ComboBoxVar4Field.Items.Add(dc.ColumnName)
            ComboBoxVar5Field.Items.Add(dc.ColumnName)
        Next
        Dim CmbLst As New List(Of ComboBox)
        CmbLst.Add(ComboBoxNameField)
        CmbLst.Add(ComboBoxNumberField)
        CmbLst.Add(ComboBoxVar1Field)
        CmbLst.Add(ComboBoxVar2Field)
        CmbLst.Add(ComboBoxVar3Field)
        CmbLst.Add(ComboBoxVar4Field)
        CmbLst.Add(ComboBoxVar5Field)
        For i As Integer = 0 To dt.Columns.Count - 1
            CmbLst(i).Text = dt.Columns(i).ColumnName
        Next
    End Sub

    Private Sub FrmImportFromFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentFileName = ""
    End Sub

    Private Sub CheckBoxFirstRow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFirstRow.CheckedChanged
        On Error Resume Next
        If currentFileName <> "" Then
            Dim dt As DataTable
            If Path.GetExtension(currentFileName).ToLower = ".xlsx" Then

                dt = DataTableFromExcel(currentFileName, CheckBoxFirstRow.Checked)
                Fillcombo(dt)
            Else
                dt = DataTableFromText(currentFileName, CheckBoxFirstRow.Checked)
                Fillcombo(dt)
            End If

            DataGridView1.DataSource = dt
            UpdateStatus()

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CheckBoxDelimeter_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDelimeter.CheckedChanged
        TextBoxDelimeter.Enabled = CheckBoxDelimeter.Checked
        TextBoxDelimeter.Text = ""
    End Sub

    Private Sub TextBoxDelimeter_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDelimeter.TextChanged
        If currentFileName <> "" Then
            Dim dt As DataTable
            If Path.GetExtension(currentFileName).ToLower <> ".xlsx" Then
                dt = DataTableFromText(currentFileName, CheckBoxFirstRow.Checked)
                Fillcombo(dt)
                DataGridView1.DataSource = dt
                UpdateStatus()
            End If


        End If
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress

    End Sub

    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        If e.KeyCode = Keys.Delete Then
            If DataGridView1.Rows.Count > 0 Then
                Dim dr As DataGridViewRow
                For Each dr In DataGridView1.SelectedRows
                    DataGridView1.Rows.Remove(dr)
                    UpdateStatus()
                Next
            End If
        End If
    End Sub

    Public Sub UpdateStatus()
        LabelStatus.Text = "Total rows:" & DataGridView1.RowCount & "  Total columns:" & DataGridView1.ColumnCount
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class