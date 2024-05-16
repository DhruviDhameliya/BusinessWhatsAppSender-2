Imports System.ComponentModel

Public Class FrmSending
    Public DeliveryMode As Integer
    Private SafeMode As Boolean
    Private RightEnd As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        Me.Close()
    End Sub

    Public SendingCounter As Integer
    Public RefDate As DateTime

    Public BulkDestinations As List(Of DestinationModel)
    Public SendingItemsList As New List(Of ListViewItem)
    Public BulkAttachments As New List(Of AttachmentModel)
    Public BulkMessages As New List(Of String)
    Public BulkName As String
    Public SendingProfiles As New List(Of String)
    Dim BulkSendingDate As DateTime
    Dim bulkTotal As Integer
    Private SuccessMessages As Integer
    Dim FailedMessages As Integer


    Public Event OnBulkStart As EventHandler
    Public Event OnBulkEnd As EventHandler
    Public Event OnMessageSent As EventHandler
    Public Event OnSendingProgress As EventHandler
    Public Event OnstartResting As EventHandler
    Public Event OnStopResting As EventHandler
    Public Event OnBulkPause As EventHandler
    Public Event OnBulkUnPause As EventHandler
    Public Event OnBulkStoped As EventHandler

    Public WithEvents EventsManager As New Timer With {.Interval = 1, .Enabled = True}
    Public WithEvents EventsOnSendManager As New Timer With {.Interval = 100, .Enabled = True}

    Private Sub EventsOnSendManager_Tick(sender As Object, e As EventArgs) Handles EventsOnSendManager.Tick

        Dim LastMessageID As Long
        Dim LastMessage As MessageSentModel = Nothing
        If MessagesSentList.Count > 0 Then
            LastMessageID = MessagesSentList(MessagesSentList.Count - 1).MessageID
            LastMessage = MessagesSentList(MessagesSentList.Count - 1)
        Else
            LastMessageID = 0
        End If
        Dim LastMessageOnList As Long
        If ListViewNumbers.Items.Count > 0 Then
            LastMessageOnList = Val(ListViewNumbers.Items(ListViewNumbers.Items.Count - 1).Text)
        Else
            LastMessageOnList = 0
        End If


        If LastMessageID <> 0 And LastMessageID > LastMessageOnList Then
            Dim li As New ListViewItem

            li.Tag = LastMessage.BuLkMessageDestination
            li.Text = LastMessage.MessageID
            li.SubItems.Add(If(LastMessage.BulkMessageName = "", "No Name", LastMessage.BulkMessageName))
            li.SubItems.Add(LastMessage.BuLkMessageDestination)
            li.SubItems.Add(LastMessage.BulkMessageType)
            li.SubItems.Add(Now)
            li.SubItems.Add(If(LastMessage.BulkMessageStatus, "Sent", "Fail"))
            If LastMessage.BulkMessageStatus Then
                SuccessMessages = SuccessMessages + 1
            Else
                FailedMessages = FailedMessages + 1
            End If
            li.SubItems.Add(LastMessage.BulkMessageBody)
            li.ImageIndex = If(LastMessage.BulkMessageStatus, 0, 1)
            ListViewNumbers.Items.Add(li)
            ListViewNumbers.EnsureVisible(ListViewNumbers.Items.Count - 1)
            BulkIsMessageSent = False
        End If


    End Sub
    Private Sub EventsManager_Tick(sender As Object, e As EventArgs) Handles EventsManager.Tick
        LabelProgress.Text = $"Sending Process ({BulkCurrentProgress}/{BulkMAXProgress})"
        ProgressBarSending.Maximum = BulkMAXProgress
        ProgressBarSending.Value = BulkCurrentProgress


        If BulkIsStarted Then
            BulkIsStarted = False
            ' RaiseEvent OnBulkStart(sender, e)
        End If

        If BulkIsPaused Then
            If Label1.Visible = False Then
                Label1.Visible = True
                Label1.Text = "Paused..."
            End If
        End If

        If BulkIsUnPaused Then
            If Label1.Visible = True Then
                Label1.Visible = False
                Label1.Text = ""
            End If
        End If

        If Not BulkIsLoggedIn Then
            If Panel1.Visible = False Then
                Panel1.Visible = True
            End If
        Else
            If Panel1.Visible = True Then
                Panel1.Visible = False
            End If
        End If

        If BulkIsResting Then
            If Label1.Visible = False Then
                Label1.Visible = True
                Label1.Text = $"Resting at {Now} for {GetSetting(ApplicationTitle, "SendingConfig", "SleepFor", 5)} seconds."
            End If
        Else
            If Label1.Visible = True Then
                Label1.Visible = False
                Label1.Text = ""
            End If
        End If


        If BulkIsDone Then
            BulkIsDone = False
            RaiseEvent OnBulkEnd(sender, e)
        End If
    End Sub

    Private Sub FrmSending_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmMain.BtnSending.Enabled = False
        FrmMain.ButtonSchedule.Enabled = False

        If DeliveryMode = 1 Then
            Me.Text = "Sending Bulk - Safe Mode"
            SafeMode = True

        ElseIf DeliveryMode = 2 Then
            Me.Text = "Sending Bulk - Blind Mode"
            SafeMode = False

        Else
            Me.Text = "Sending Bulk - Multi-Channel Mode"
        End If

        If RefDate > Now Then
            PanelCountDown.Visible = True
            TimerCountDown.Enabled = True
            ButtonPause.Enabled = False
            ButtonViewLog.Enabled = False
            Exit Sub
        Else
            PanelCountDown.Visible = False
            TimerCountDown.Enabled = False
            startbulk()

        End If



    End Sub


    Private Sub startbulk()
        RightEnd = False
        ListViewNumbers.Items.Clear()
        MessagesSentList.Clear()
        SuccessMessages = 0
        FailedMessages = 0

        PanelCountDown.Visible = False
        TimerCountDown.Enabled = False

        PanelCountDown.Visible = False
        TimerCountDown.Enabled = False
        ButtonPause.Enabled = True
        ButtonViewLog.Enabled = True

        BulkSendingDate = Now

        BulkIsMessageSent = False
        If DeliveryMode <> 3 Then
            FrmBrowser.StartBulk(BulkDestinations, BulkMessages, BulkAttachments, SafeMode)
        Else
            MultiChannelSend()
            TimerMultiChannelCounter.Enabled = True
        End If
    End Sub
    Sub MultiChannelSend()
        Dim chnl As New List(Of Whatsapp)
        Dim _wa As Whatsapp
        For Each profile As String In SendingProfiles
            _wa = New Whatsapp
            _wa.BrowserProfile = profile
            _wa.Delay = 1
            _wa.Messages = BulkMessages
            chnl.Add(_wa)
        Next

        Dim channelselector As Integer = 0
        Dim _WaContact As WhatsAppContact = Nothing
        BulkMAXProgress = BulkDestinations.Count
        BulkCurrentProgress = 0
        ListViewNumbers.Items.Clear()

        For Each li As DestinationModel In BulkDestinations

            _WaContact = New WhatsAppContact
            _WaContact.WhatsAppID = li.WhatsAppID
            _WaContact.WhatsAppName = li.Fullname
            _WaContact.WhatsAppContact = li.LastName
            _WaContact.Var1 = li.Var1
            _WaContact.Var2 = li.Var2
            _WaContact.Var3 = li.Var3
            _WaContact.Var4 = li.Var4
            _WaContact.Var5 = li.Var5

            chnl(channelselector).Contacts.Add(_WaContact)

            If channelselector < chnl.Count - 1 Then
                channelselector = channelselector + 1
            Else
                channelselector = 0
            End If
        Next
        BulkIsLoggedIn = True
        For Each _wa In chnl
            _wa.Delay = GetDelay()

            _wa.RestAfter = Val(GetSetting(ApplicationTitle, "SendingConfig", "SleepAfter", 20))
            _wa.RestFor = Val(GetSetting(ApplicationTitle, "SendingConfig", "SleepFor", 5))

            _wa.MediaFiles = BulkAttachments
            _wa.Send()
        Next

    End Sub
    Private Function GetDelay() As Integer
        Dim Num1 As Integer = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayStart", "0"))
        Dim Num2 As Integer = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayEnd", "2"))

        Randomize()
        Dim a As Integer = 10
        If Num2 > 0 Then
            a = (Num1 + (Int(Rnd() * Num2))) * 1000
        Else
            a = 100
        End If
        If a = 0 Then
            a = 100
        End If
        Return a
    End Function
    Private demosendCounter As Integer
    Private refeshcounter As Long
    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        If ButtonPause.Tag = "pause" Then
            BulkIsPaused = True
            BulkIsUnPaused = False
            ButtonPause.Text = "Resume"
            ButtonPause.Tag = "resume"
        Else
            BulkIsPaused = False
            BulkIsUnPaused = True
            ButtonPause.Text = "Pause"
            ButtonPause.Tag = "pause"
        End If
    End Sub
    Private Sub ShowMessageinForm(ByVal Message As String)
        Label1.Text = Message
        Label1.Visible = True
    End Sub
    Private Sub HideMessageinForm()
        Label1.Text = ""
        Label1.Visible = False
    End Sub



    Sub Countdown()
        Dim Date1 As DateTime = Now
        Dim Date2 As DateTime = RefDate
        Dim t As Long = DateDiff(DateInterval.Second, Date1, Date2)
        Dim dayCount As Integer = DateDiff(DateInterval.Day, Date1, Date2)
        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(t)

        LabelCountDown.Text = (iSpan.Hours + (dayCount * 24)).ToString.PadLeft(2, "0"c) & ":" &
                        iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                        iSpan.Seconds.ToString.PadLeft(2, "0"c)
        If t = 0 Then

            startbulk()
        End If
    End Sub
    Private Sub TimerCountDown_Tick(sender As Object, e As EventArgs) Handles TimerCountDown.Tick
        Countdown()
    End Sub




    Private Sub FrmSending_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed


    End Sub


    Public Sub CreateReport(ByVal SendingDate As DateTime,
                            ByVal attachment As List(Of AttachmentModel),
                            ByVal destination As ListView)
        '  Try


        Dim ReportName As String = SendingDate.ToString("yyyy-MM-dd HH[mm[ss") & "_" & destination.Items.Count & ".html"

        Dim report As String = My.Resources.Report

            report = report.Replace("<!--date-->", SendingDate.ToString("yyyy-MM-dd HH:mm:ss"))
            report = report.Replace("<!--total-->", destination.Items.Count)
            report = report.Replace("<!--success-->", SuccessMessages)
            report = report.Replace("<!--failed-->", FailedMessages)

            Dim AttachmentHTML As String = ""
            AttachmentHTML = AttachmentHTML & "<tr>" & vbNewLine
            AttachmentHTML = AttachmentHTML & "<td style = 'width: 164px' >{0}</td>" & vbNewLine
            AttachmentHTML = AttachmentHTML & "<td style='width: 89px'>{1}</td>" & vbNewLine
            AttachmentHTML = AttachmentHTML & "<td style = 'width: 71px' >{2}</td>" & vbNewLine
            AttachmentHTML = AttachmentHTML & "</tr>" & vbNewLine

            Dim _attachment As String = ""
            For Each _attach As AttachmentModel In attachment
                _attachment = _attachment & String.Format(AttachmentHTML, _attach.FileName, _attach.Type, _attach.Caption)
            Next

            report = report.Replace("<!-- Attachment -->", _attachment)

            Dim recordHtml As String = ""
            Dim status As String = ""
            For Each li As ListViewItem In destination.Items
            recordHtml = recordHtml & "<tr><td Class='{{ICON}}' style='width: 15px'></td>" & vbNewLine
            recordHtml = recordHtml & "<td style ='width: 35px'><span _locid='OverviewSolutionSpan'>{{ID}}</span></td>" & vbNewLine
            recordHtml = recordHtml & "<td style ='width: 207px'><span _locid='OverviewSolutionSpan'>{{NAME}}</span></td>" & vbNewLine
            recordHtml = recordHtml & "<td style='width: 207px'><span _locid='OverviewSolutionSpan'>{{NUMBER}}</span></td>" & vbNewLine
            recordHtml = recordHtml & "<td style ='width: 207px'><span _locid='OverviewSolutionSpan'>{{TYPE}}</span></td>" & vbNewLine
            recordHtml = recordHtml & "<td style='width: 207px'><span _locid='OverviewSolutionSpan'>{{DATE}}</span></td>" & vbNewLine
            recordHtml = recordHtml & "<td style ='width: 207px'><span _locid='OverviewSolutionSpan'>{{STATUS}}</span></td>" & vbNewLine
            recordHtml = recordHtml & "<td style='width: 207px'><span _locid='OverviewSolutionSpan'>{{MESSAGE}}</span></td></tr>" & vbNewLine
            If li.ImageIndex = 0 Then
                    status = "IconSuccessEncoded"
                Else
                    status = "IconErrorEncoded"
                End If

            recordHtml = recordHtml.Replace("{{ICON}}", status)
            recordHtml = recordHtml.Replace("{{ID}}", li.SubItems(0).Text)
            recordHtml = recordHtml.Replace("{{NAME}}", li.SubItems(1).Text)
            recordHtml = recordHtml.Replace("{{NUMBER}}", li.SubItems(2).Text)
            recordHtml = recordHtml.Replace("{{TYPE}}", li.SubItems(3).Text)
            recordHtml = recordHtml.Replace("{{DATE}}", li.SubItems(4).Text)
            recordHtml = recordHtml.Replace("{{STATUS}}", li.SubItems(5).Text)
            recordHtml = recordHtml.Replace("{{MESSAGE}}", li.SubItems(6).Text)

        Next
            report = report.Replace("<!--messages-->", recordHtml)

        IO.File.WriteAllText(ClsSpecialDirectories.GetReport & ReportName.Replace(":", ""), report)
        'Catch ex As Exception
        '    MsgBox(ex.Message, vbCritical, Application.ProductName)
        'End Try
    End Sub

    Private Sub FrmSending_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '  CreateReport(BulkSendingDate, success, failed, SendingAttachment, ListViewNumbers)
    End Sub

    Private Sub ButtonViewLog_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonViewLog.MouseDown
        ContextMenuStrip1.Show(ButtonViewLog, e.Location)
    End Sub

    Public Sub Export(ByVal ExportType As Integer)
        Dim saveDlg As New SaveFileDialog
        saveDlg.Filter = "*.csv|*.csv"
        Dim result As String = ""
        If saveDlg.ShowDialog = DialogResult.OK Then
            For Each li As ListViewItem In ListViewNumbers.Items
                If ExportType = 0 Then
                    result = result & li.SubItems(0).Text & "," & li.SubItems(1).Text & "," & li.SubItems(2).Text & "," & li.SubItems(3).Text & "," & li.SubItems(4).Text & "," & li.SubItems(5).Text & "," & vbNewLine
                Else
                    If li.ImageIndex = 0 Then
                        result = result & li.SubItems(0).Text & "," & li.SubItems(1).Text & "," & li.SubItems(2).Text & "," & li.SubItems(3).Text & "," & li.SubItems(4).Text & "," & li.SubItems(5).Text & "," & vbNewLine
                    End If
                End If
            Next
            IO.File.WriteAllText(saveDlg.FileName, result)
        End If
    End Sub
    Private Sub ExportAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAllToolStripMenuItem.Click
        Export(0)
    End Sub
    Private Sub ExportSuccessfulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportSuccessfulToolStripMenuItem.Click
        Export(1)
    End Sub
    Private Sub FrmSending_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        FrmBrowser.StopBulk()
        FrmMain.BtnSending.Enabled = True
        FrmMain.ButtonSchedule.Enabled = True

        If Not RightEnd Then
            CreateReport(BulkSendingDate, BulkAttachments, ListViewNumbers)
        End If
        Me.Dispose()
    End Sub

    Private Sub FrmSending_OnBulkEnd(sender As Object, e As EventArgs) Handles Me.OnBulkEnd
        RightEnd = True
        CreateReport(BulkSendingDate, BulkAttachments, ListViewNumbers)
        MsgBox($"Your Bulk has been done successfully at {Now}", vbInformation, Application.ProductName)
    End Sub

    Private Sub FrmSending_CausesValidationChanged(sender As Object, e As EventArgs) Handles Me.CausesValidationChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FrmBrowser.Show()
    End Sub
End Class


