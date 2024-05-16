Public Class FrmManualImports
    Public SourceForm As Integer
    Public ImportResults As New List(Of WhatsAppContact)
    Public CurrentImportContext As ManualImport
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        CurrentImportContext.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FrmManualImports_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click

        If LstNumbers.Items.Count = 0 Then
            MsgBox("Empty list")
            Exit Sub
        End If
        CurrentImportContext.DialogResult = DialogResult.OK
        ImportResults.Clear()
        Dim _contacts As WhatsAppContact
        Dim li As ListViewItem
        Dim _TempDuplicationChecklist As New List(Of String)
        _TempDuplicationChecklist.Clear()
        For Each li In LstNumbers.Items
            If CheckBoxRemoveDuplication.Checked Then
                If Not _TempDuplicationChecklist.Contains(li.SubItems(1).Text) Then
                    _TempDuplicationChecklist.Add(li.SubItems(1).Text)
                    _contacts = New WhatsAppContact
                    _contacts.WhatsAppID = CleanNumber(li.SubItems(1).Text) & "@c.us"
                    _contacts.WhatsAppContact = li.SubItems(1).Text
                    _contacts.WhatsAppName = li.Text
                    ImportResults.Add(_contacts)
                End If
            Else
                _contacts = New WhatsAppContact
                _contacts.WhatsAppID = CleanNumber(li.SubItems(1).Text) & "@c.us"
                _contacts.WhatsAppContact = li.SubItems(1).Text
                _contacts.WhatsAppName = li.Text
                ImportResults.Add(_contacts)
            End If
        Next
        CurrentImportContext.Contacts = ImportResults
        Me.Close()
    End Sub

    Private Sub FrmManualImports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LstNumbers.Items.Clear()
        TxtNumbers.Text = ""
    End Sub
    Public Function CleanNumber(ByVal Number As String) As String
        Number = Number.Replace("+", "")
        Number = Number.Replace(" ", "")
        Number = Number.Replace("/", "")
        Number = Number.Replace("-", "")
        Number = Number.Replace("(", "")
        Number = Number.Replace(")", "")
        Return Number
    End Function
    Private Sub TxtNumbers_TextChanged(sender As Object, e As EventArgs) Handles TxtNumbers.TextChanged
        Dim _Numbers() As String = Split(TxtNumbers.Text, vbNewLine)
        Dim lst As New List(Of String)
        Dim Number As String
        Dim CountInValid As Long = 0
        Dim CountDuplicated As Long = 0
        Dim CountTotal As Long = 0
        lst.Clear()
        LstNumbers.Items.Clear()
        Dim li As ListViewItem
        Dim b() As String
        Dim DuplicationCount As Integer = 0
        For Each Number In _Numbers
            li = New ListViewItem
            Number = Number.Replace(";", ",")
            Number = Number.Replace("|", ",")
            b = Split(Number, ",")
            If UBound(b) > 0 Then
                If b(1).Length > 5 Then
                    If IsNumeric(CleanNumber(b(1))) Then
                        li.Text = b(0)
                        li.SubItems.Add(CleanNumber(b(1)))

                        If lst.Contains(CleanNumber(b(1))) Then
                            DuplicationCount = DuplicationCount + 1
                        End If

                        lst.Add(CleanNumber(b(1)))

                        LstNumbers.Items.Add(li)
                    End If
                End If
            Else
                If IsNumeric(CleanNumber(Number)) Then
                    li.Text = "N/A"
                    li.SubItems.Add(CleanNumber(Number))

                    If lst.Contains(CleanNumber(Number)) Then
                        DuplicationCount = DuplicationCount + 1
                    End If

                    lst.Add(CleanNumber(Number))

                    LstNumbers.Items.Add(li)
                End If
            End If
        Next
        LabelCount.Text = "Total:" & LstNumbers.Items.Count
        LabelDuplication.Text = "Duplication:" & DuplicationCount
        LstNumbers.Visible = True

    End Sub
End Class