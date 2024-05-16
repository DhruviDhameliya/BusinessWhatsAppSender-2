Public Class FrmChannels
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            FrmManageChannel.TextBox1.Text = ""
            FrmManageChannel.TextBox2.Text = ""
            FrmManageChannel.TextBox3.Text = ""
            If FrmManageChannel.ShowDialog() = DialogResult.OK Then
                ListView1.Items.Add(FrmManageChannel.ChannelItem)
                UpdateDate()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, Application.ProductName)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, ModifyChannelToolStripMenuItem.Click
        Try


            If Not IsNothing(ListView1.SelectedItems(0)) Then
                FrmManageChannel.ChannelItem = ListView1.SelectedItems(0)
                FrmManageChannel.Action = 1
                FrmManageChannel.TextBox1.Text = FrmManageChannel.ChannelItem.Text
                FrmManageChannel.TextBox2.Text = FrmManageChannel.ChannelItem.SubItems(1).Text
                FrmManageChannel.TextBox3.Text = FrmManageChannel.ChannelItem.SubItems(2).Text
                FrmManageChannel.ShowDialog()
                UpdateDate()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, Application.ProductName)
        End Try
    End Sub

    Private Sub FrmChannels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim channels As List(Of ClsChannelModel)
        Dim channel As ClsChannelModel
        Dim k As New frmSenders
        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\channel.json") Then
            channels = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of ClsChannelModel))(IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\channel.json"))
            Dim li As ListViewItem
            For Each channel In channels
                li = New ListViewItem
                li.Tag = channel
                li.Text = channel.ChannelName
                li.SubItems.Add(channel.ChannelDescriptionas)
                li.SubItems.Add(channel.ChannelPath)
                ListView1.Items.Add(li)
                k = New frmSenders
                k.Profile = channel.ChannelPath
                SenderList.Add(k)
            Next

        End If



    End Sub
    Private Sub UpdateDate()
        Dim channels As New List(Of ClsChannelModel)
        Dim li As ListViewItem
        For Each li In ListView1.Items
            channels.Add(li.Tag)
        Next

        Dim channelsJson As String = Newtonsoft.Json.JsonConvert.SerializeObject(channels)

        IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\channel.json", channelsJson)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, DeleteChannelToolStripMenuItem.Click
        If Not IsNothing(ListView1.SelectedItems(0)) Then
            If MsgBox("Are you sure that you want to delete this channels?", vbQuestion + MsgBoxStyle.YesNo, Application.ProductName) = vbYes Then
                ListView1.SelectedItems(0).Remove()
                UpdateDate()
            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick, LoginToWhatsAppToolStripMenuItem.Click
        If ListView1.SelectedItems.Count > 0 Then
            If ListView1.SelectedItems(0).SubItems(2).Text <> "" Then
                Dim wLogin As New ClsWhatsappChannel
                wLogin.BrowserProfile = ListView1.SelectedItems(0).SubItems(2).Text
                wLogin.Login()
            End If
        End If
    End Sub

    Private Sub FrmChannels_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class