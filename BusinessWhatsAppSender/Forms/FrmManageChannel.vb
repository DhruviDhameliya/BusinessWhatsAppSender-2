Public Class FrmManageChannel
    Public Action As Integer

    Dim CurrentDirectory As String = ""
    Public ChannelItem As ListViewItem
    Private Sub FrmManageChannel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Action = 0 Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If


        CurrentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\"
        TextBox3.Text = CurrentDirectory & TextBox1.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox3.Text = CurrentDirectory & TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dlg As New FolderBrowserDialog
        If dlg.ShowDialog = DialogResult.OK Then
            CurrentDirectory = (dlg.SelectedPath & "\").Replace("\\", "\")
        End If
        TextBox3.Text = (CurrentDirectory & TextBox1.Text).Replace("\\", "\")
    End Sub

    Public Function ValidateText(ByVal text As String) As Boolean
        Dim str As String = "\/:*?<>|" & """"
        For Each t As Char In str
            If text.Contains(t) Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ValidateText(TextBox1.Text) Then
            MsgBox("Invalid Channel Name! Name cannot contains " & "\/:*?<>|" & """", vbCritical, Application.ProductName)
            TextBox1.SelectAll()
            TextBox1.Focus()
            Exit Sub
        End If
        Dim Channel As ClsChannelModel
        Channel = New ClsChannelModel
        Channel.ChannelName = TextBox1.Text
        Channel.ChannelDescriptionas = TextBox2.Text
        Channel.ChannelPath = TextBox3.Text

        If Action = 0 Then
            ChannelItem = New ListViewItem
            ChannelItem.Tag = Channel
            ChannelItem.Text = TextBox1.Text
            ChannelItem.SubItems.Add(TextBox2.Text)
            ChannelItem.SubItems.Add(TextBox3.Text)
            ChannelItem.SubItems.Add("")
        Else
            ChannelItem.Tag = Channel
            ChannelItem.Text = TextBox1.Text
            ChannelItem.SubItems(1).Text = TextBox2.Text
            ChannelItem.SubItems(2).Text = TextBox3.Text
        End If

        DialogResult = DialogResult.OK

    End Sub
End Class