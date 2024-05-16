Public Class FrmAutoReply
    Private Sub ButtonEmoji_Click(sender As Object, e As EventArgs) Handles ButtonEmoji.Click
        Process.Start("https://www.emojicopy.com/")
    End Sub

    Private Sub BtnBold_Click(sender As Object, e As EventArgs) Handles BtnBold.Click
        TextControl(TextBoxMessage, "*")
    End Sub
    Private Sub TextControl(ByRef txt As TextBox, ByVal TxtChar As String)
        On Error Resume Next
        Dim CurrentIndex As Integer = txt.SelectionStart
        Dim CurrentLenght As Integer = txt.SelectionLength
        txt.Text = txt.Text.Insert(CurrentIndex, TxtChar)
        txt.Text = txt.Text.Insert(CurrentIndex + CurrentLenght + 1, TxtChar)
    End Sub

    Private Sub BtnItalic_Click(sender As Object, e As EventArgs) Handles BtnItalic.Click
        TextControl(TextBoxMessage, "_")
    End Sub

    Private Sub BtnStrike_Click(sender As Object, e As EventArgs) Handles BtnStrike.Click
        TextControl(TextBoxMessage, "~")
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ListViewAttachment.Items.Clear()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click, DeleteToolStripMenuItem1.Click
        If ListViewAttachment.SelectedItems().Count > 0 Then
            If ListViewAttachment.SelectedItems(0).Text <> "" Then
                ListViewAttachment.SelectedItems(0).Remove()
            End If
        End If
    End Sub
    Private Sub ButtonAdd_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonAdd.MouseDown
        ContextMenuStripAttachFiles.Show(ButtonAdd, e.Location)
    End Sub
    Private Sub PhotosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhotosToolStripMenuItem.Click
        Dim OpenDlg As New OpenFileDialog()
        OpenDlg.Filter = "*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.ico|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.ico"
        OpenDlg.Multiselect = True
        If OpenDlg.ShowDialog() = DialogResult.OK Then
            Dim fLi As ListViewItem
            For Each _file As String In OpenDlg.FileNames
                fLi = New ListViewItem
                fLi.Tag = _file
                Dim a() As String = Split(_file, "\")
                fLi.Text = a(UBound(a))
                fLi.SubItems.Add("Photo")
                fLi.SubItems.Add("")
                fLi.ImageIndex = 1
                If IsMediaAdded(fLi) Then
                    If MsgBox("The file that you want to add its already available , do you want add it anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then
                        ListViewAttachment.Items.Add(fLi)
                    End If
                Else
                    ListViewAttachment.Items.Add(fLi)
                End If
            Next
        End If
    End Sub

    Private Sub VideosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideosToolStripMenuItem.Click
        Dim OpenDlg As New OpenFileDialog()
        OpenDlg.Filter = "*.mp4|*.mp4"
        OpenDlg.Multiselect = True
        If OpenDlg.ShowDialog() = DialogResult.OK Then
            Dim fLi As ListViewItem
            For Each _file As String In OpenDlg.FileNames
                fLi = New ListViewItem
                fLi.Tag = _file
                Dim a() As String = Split(_file, "\")
                fLi.Text = a(UBound(a))
                fLi.SubItems.Add("Video")
                fLi.SubItems.Add("")
                fLi.ImageIndex = 2
                If IsMediaAdded(fLi) Then
                    If MsgBox("The file that you want to add its already available , do you want add it anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then
                        ListViewAttachment.Items.Add(fLi)
                    End If
                Else
                    ListViewAttachment.Items.Add(fLi)
                End If
            Next
        End If
    End Sub

    Private Sub DocumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentsToolStripMenuItem.Click
        Dim OpenDlg As New OpenFileDialog()
        OpenDlg.Filter = "*.txt;*.pdf|*.txt;*.pdf"
        OpenDlg.Multiselect = True
        If OpenDlg.ShowDialog() = DialogResult.OK Then
            Dim fLi As ListViewItem
            For Each _file As String In OpenDlg.FileNames
                fLi = New ListViewItem
                fLi.Tag = _file
                Dim a() As String = Split(_file, "\")
                fLi.Text = a(UBound(a))
                fLi.SubItems.Add("Document")
                fLi.SubItems.Add("")
                fLi.ImageIndex = 0
                If IsMediaAdded(fLi) Then
                    If MsgBox("The file that you want to add its already available , do you want add it anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then
                        ListViewAttachment.Items.Add(fLi)
                    End If
                Else
                    ListViewAttachment.Items.Add(fLi)
                End If
            Next
        End If
    End Sub

    Private Sub StickersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StickersToolStripMenuItem.Click
        Dim OpenDlg As New OpenFileDialog()
        OpenDlg.Filter = "*.png|*.png"
        OpenDlg.Multiselect = True
        If OpenDlg.ShowDialog() = DialogResult.OK Then
            Dim fLi As ListViewItem
            For Each _file As String In OpenDlg.FileNames
                fLi = New ListViewItem
                fLi.Tag = _file
                Dim a() As String = Split(_file, "\")
                fLi.Text = a(UBound(a))
                fLi.SubItems.Add("Sticker")
                fLi.SubItems.Add("")
                fLi.ImageIndex = 1
                If IsMediaAdded(fLi) Then
                    If MsgBox("The file that you want to add its already available , do you want add it anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then
                        ListViewAttachment.Items.Add(fLi)
                    End If
                Else
                    ListViewAttachment.Items.Add(fLi)
                End If
            Next
        End If
    End Sub

    Private Function IsMediaAdded(ByVal li As ListViewItem) As Boolean
        For Each _li As ListViewItem In ListViewAttachment.Items
            If _li.Tag = li.Tag Then
                Return True
                Exit Function
            End If

        Next
        Return False
    End Function
    Private Sub LstMedia_DoubleClick(sender As Object, e As EventArgs) Handles ListViewAttachment.DoubleClick, OpenFileToolStripMenuItem.Click
        If ListViewAttachment.Items.Count > 0 Then
            If ListViewAttachment.SelectedItems.Count > 0 Then
                If ListViewAttachment.SelectedItems(0).Text <> "" Then
                    Process.Start(ListViewAttachment.SelectedItems(0).Tag)
                End If
            End If
        End If
    End Sub
    Private Sub SetCaptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetCaptionToolStripMenuItem.Click
        If ListViewAttachment.Items.Count > 0 Then

            If ListViewAttachment.SelectedItems.Count > 0 Then
                If ListViewAttachment.SelectedItems(0).Text <> "" Then
                    If ListViewAttachment.SelectedItems(0).SubItems(1).Text = "Photo" Or ListViewAttachment.SelectedItems(0).SubItems(1).Text = "VIDEO" Then
                        Try
                            FrmSetCaption.TxtCaption.Text = ListViewAttachment.SelectedItems(0).SubItems(2).Text
                        Catch ex As Exception
                            FrmSetCaption.TxtCaption.Text = ""
                        End Try

                        FrmSetCaption.ShowDialog()
                        If FrmSetCaption.dlgResult = DialogResult.OK Then

                            ListViewAttachment.SelectedItems(0).SubItems(2).Text = FrmSetCaption.Caption
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim _autoReplyObject As New ClsAutoReplyMessage
        _autoReplyObject.Message = TextBoxMessage.Text
        Dim _t As ClsAttachment
        Dim li As ListViewItem
        Dim lMedia As New List(Of ClsAttachment)

        For Each li In ListViewAttachment.Items
            _t = New ClsAttachment
            _t.File = li.Tag.ToString
            _t.FileName = li.Text
            _t.MediaType = li.SubItems(1).Text
            _t.Caption = li.SubItems(2).Text
            lMedia.Add(_t)
            _autoReplyObject.Attachment = lMedia
        Next

        Dim _autoreplyJson = Newtonsoft.Json.JsonConvert.SerializeObject(_autoReplyObject)

        IO.File.WriteAllText(ClsSpecialDirectories.Getdata & "autoreply.json", _autoreplyJson)
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmAutoReply_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub FrmAutoReply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists(ClsSpecialDirectories.Getdata & "autoreply.json") Then
            Try
                Dim _jsonResult As ClsAutoReplyMessage = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ClsAutoReplyMessage)(IO.File.ReadAllText(ClsSpecialDirectories.Getdata & "autoreply.json"))
                TextBoxMessage.Text = _jsonResult.Message
                Dim t As ClsAttachment
                Dim li As ListViewItem
                If Not IsNothing(_jsonResult.Attachment) Then
                    For Each t In _jsonResult.Attachment
                        li = New ListViewItem
                        li.Text = t.FileName
                        li.Tag = t.File
                        li.SubItems.Add(t.MediaType)
                        li.SubItems.Add(t.Caption)
                        ListViewAttachment.Items.Add(li)
                    Next
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class