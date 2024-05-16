Public Class FrmGroupGrabber
    Private Sub BtnFetchGroups_Click(sender As Object, e As EventArgs) Handles BtnFetchGroups.Click
        ListView1.Items.Clear()
        Dim Groupli As ListViewItem
        For Each Groupdr As DataRow In FrmBrowser.GetAllGroups().Rows
            Try
                If Groupdr(1) <> "" Then
                    Groupli = New ListViewItem
                    Groupli.Tag = Groupdr(0)
                    Groupli.Text = Groupdr(1)
                    Groupli.SubItems.Add(Groupdr(0))
                    ListView1.Items.Add(Groupli)
                End If


            Catch ex As Exception

            End Try
        Next
        GetCount()
    End Sub

    Private Async Sub BtnFtechContacts_Click(sender As Object, e As EventArgs) Handles BtnFtechContacts.Click

        Dim li As ListViewItem
        Dim i As Integer = 0
        For Each li In ListView1.Items
            i = 0
            ToolStripStatusLabel3.Text = "Fetching From:" & li.Text
            If li.Checked Then
                GroupsParticipant = ""
                Application.DoEvents()
                GroupsParticipant = Await FrmBrowser.getGroupParticipantIDs(li.Tag)
                Console.WriteLine("GroupsParticipant : " & GroupsParticipant)
                If (GroupsParticipant IsNot "") Then
                    Application.DoEvents()
                    Dim temPart() As String = Split(GroupsParticipant, ",")
                    For Each _t As String In temPart
                        If Not ListBox1.Items.Contains(_t) Then
                            ListBox1.Items.Add(_t)
                        End If
                    Next
                End If
            End If
            GetCount()
        Next
        ToolStripStatusLabel3.Text = ""
        MsgBox("Fetching contacts from groups has been done", vbInformation, Application.ProductName)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Dim dlg As New SaveFileDialog
        dlg.Filter = "*.txt|*.txt"
        Dim result As String = ""
        If dlg.ShowDialog() = DialogResult.OK Then
            Dim t As String

            For Each t In ListBox1.Items
                result = result & t & vbNewLine
            Next
        End If
        IO.File.WriteAllText(dlg.FileName, result)
        MsgBox("Contacts has beedn exported successfully", vbInformation, Application.ProductName)
    End Sub

    Private Sub BtnSelectAll_Click(sender As Object, e As EventArgs) Handles BtnSelectAll.Click
        Dim li As ListViewItem
        For Each li In ListView1.Items
            li.Checked = True
        Next
    End Sub

    Private Sub BtnDeselectAll_Click(sender As Object, e As EventArgs) Handles BtnDeselectAll.Click
        Dim li As ListViewItem
        For Each li In ListView1.Items
            li.Checked = False
        Next
    End Sub

    Private Sub BtnClearGroups_Click(sender As Object, e As EventArgs) Handles BtnClearGroups.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub BtnDeleteGroups_Click(sender As Object, e As EventArgs) Handles BtnDeleteGroups.Click
        Dim li As ListViewItem
        For Each li In ListView1.Items
            If li.Checked Then
                li.Remove()
            End If
        Next
    End Sub
    Private Sub BtnExportGroups_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnExportGroups.MouseDown
        ContextMenuStrip1.Show(sender, e.Location)
    End Sub

    Private Sub AllGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllGroupsToolStripMenuItem.Click
        ExportGroups(0)
    End Sub
    Public Sub ExportGroups(ByVal ExportType As Integer)
        Dim dlg As New SaveFileDialog
        dlg.Filter = "*.txt|*.txt"
        If dlg.ShowDialog = DialogResult.OK Then
            Dim result As String = ""
            Dim li As ListViewItem
            For Each li In ListView1.Items
                If ExportType = 0 Then
                    result = result & li.Text & "," & li.Tag & vbNewLine
                Else
                    If li.Checked Then
                        result = result & li.Text & "," & li.Tag & vbNewLine
                    End If
                End If
            Next
            IO.File.WriteAllText(dlg.FileName, result)
        End If
    End Sub

    Private Sub CheckedGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckedGroupsToolStripMenuItem.Click
        ExportGroups(1)
    End Sub

    Private Sub FrmGroupGrabber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        GetCount()
    End Sub

    Private Sub GetCount()
        ToolStripStatusLabel1.Text = "Groups Count:" & ListView1.Items.Count
        ToolStripStatusLabel2.Text = "Contacts Count:" & ListBox1.Items.Count
    End Sub

    Private Sub BtnAddtoList_Click(sender As Object, e As EventArgs) Handles BtnAddtoList.Click
        Dim result As String = ""
        Dim li As ListViewItem
        For Each t In ListBox1.Items
            li = New ListViewItem
            li.Tag = t.ToString & "@c.us"
            li.Text = "N/A"
            li.SubItems.Add(t.ToString)
            li.SubItems.Add("")
            li.SubItems.Add("")
            li.SubItems.Add("")
            li.SubItems.Add("")
            li.SubItems.Add("")
            FrmMain.LstNumbers.Items.Add(li)
        Next
        FrmMain.Statistics()
    End Sub
End Class

Public Class GroupParticipant
    Public Property _serialized As String
    Public Property server As String
    Public Property user As String
End Class