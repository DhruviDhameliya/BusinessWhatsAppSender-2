Public Class FrmSendingType
    Public Result As Integer
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub FrmSendingType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim channels As List(Of ClsChannelModel)
        Dim channel As ClsChannelModel
        Dim k As New frmSenders
        ListView1.Items.Clear()
        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\channel.json") Then
            channels = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of ClsChannelModel))(IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\channel.json"))
            Dim li As ListViewItem
            For Each channel In channels
                li = New ListViewItem
                li.Tag = channel.ChannelPath
                li.Text = channel.ChannelName
                li.SubItems.Add(channel.ChannelDescriptionas)
                li.SubItems.Add(channel.ChannelPath)
                ListView1.Items.Add(li)
                k = New frmSenders
                k.Profile = channel.ChannelPath
                SenderList.Add(k)
            Next

        End If


        If LicenseMode Then
            CheckLicense()
            If Not AllowSending Then
                MsgBox("Not allowed to use this option , please check your vendor.", vbInformation, ApplicationTitle)
                Me.Close()
                Exit Sub
            End If
        End If

        RadioButtonSafeMode.Checked = True
        Result = 0
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        For Each li As ListViewItem In ListView1.CheckedItems
            FrmSending.SendingProfiles.Add(li.Tag)
        Next

        If RadioButtonSafeMode.Checked Then
            Result = 1
        ElseIf RadioButtonBlindMode.Checked Then
            Result = 2
        Else
            Result = 3
        End If
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ListView1.Enabled = RadioButton1.Checked
        LinkLabel1.Enabled = RadioButton1.Checked
        LinkLabel2.Enabled = RadioButton1.Checked
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        For Each li As ListViewItem In ListView1.Items : li.Checked = True : Next
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        For Each li As ListViewItem In ListView1.Items : li.Checked = False : Next
    End Sub
End Class