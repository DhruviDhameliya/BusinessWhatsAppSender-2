Imports System.Web

Public Class FrmLicense
    Public ViewMode As Integer
    Private Sub FrmLicense_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        If ViewMode <> 3 Then
            End
            Me.Dispose()
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub FrmLicense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
        If (ordernumber <> "") Then
            Dim request As String = New System.Net.WebClient().DownloadString("http://bulkwhatsappmarketing.in/getrequestbyorder.php?ordernumber=" + ordernumber)
            If (request <> "0") Then
                TextBox1.Text = "BWMSBUS - " + ordernumber
                Show()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles LicneseTextBox.TextChanged
        Try
            'Label12.Visible = False
            'Dim _license As LicenseModel = Newtonsoft.Json.JsonConvert.DeserializeObject(Of LicenseModel)(Decrypt(TextBox2.Text))
            'LicName.Text = _license.ClientName
            'LicEmail.Text = _license.ClientEmail
            'LicCreateDate.Text = _license.CreateDate
            'LicExpiryDate.Text = _license.ExpiryDate
            'LicFilter.Text = _license.AllowFliter.ToString
            'LicSending.Text = _license.AllowSending.ToString
            'LicAutoReply.Text = _license.AllowBot.ToString


        Catch ex As Exception
            If LicneseTextBox.Text <> "" Then
                Label12.Visible = True
            Else
                Label12.Visible = False
            End If
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Application.Exit()
        Application.ExitThread()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        If LicneseTextBox.Text = "" Then
            MsgBox("Please enter your licnese", vbCritical, Application.ProductName)
            Exit Sub
        End If
        Dim srvdate As Long = Val(GetServerDate())
        Dim result As ActivationCodeResponse

        Dim lic = New System.Net.WebClient().DownloadString("http://bulkwhatsappmarketing.in/getlic.php?id=3&license=" + HttpUtility.UrlEncode(LicneseTextBox.Text))
        result = ClsLicence.ValidateLicense(lic)



        If Not IsNothing(result) Then
            If result.IsExsist Then
                If Not IsNothing(result.Response) Then
                    If srvdate <= Val(result.Response.ExpiryDate) Then
                        If result.Response.Status = 1 Then
                            ExpriyDate = result.Response.ExpiryDate
                            TotalDays = ClsLicence.GetRemianingDays(result.Response.ExpiryDate, srvdate)
                            AllowSending = result.Response.AllowSending
                            AllowAutoReply = result.Response.AllowBot
                            allowFilter = result.Response.AllowFilter
                            SaveSetting(Application.ProductName, "license", "key", LicneseTextBox.Text)
                            MsgBox("Your license is successfuly activated", MsgBoxStyle.Information, Application.ProductName)
                            FrmMain.LabelRemaning.Text = TotalDays & " Remaning days"
                            Me.Hide()
                        Else
                            MsgBox("License disabled by vendor.", vbCritical, Application.ProductName)
                        End If
                    Else
                        MsgBox("License already expired", vbCritical, Application.ProductName)
                    End If
                End If
            Else
                MsgBox("Unable to validate license check vendor", vbCritical, Application.ProductName)
            End If
        Else
            MsgBox("Unable to validate license check vendor", vbCritical, Application.ProductName)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Process.Start("http://wa.me/" & SupportPhone)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dlq As New OpenFileDialog
        dlq.Filter = "*.lic|*.lic"
        If dlq.ShowDialog = DialogResult.OK Then
            Try
                LicneseTextBox.Text = IO.File.ReadAllText(dlq.FileName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
            End Try

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Process.Start("mailto:" & SupportEmail)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        On Error Resume Next
        LicName.Text = ""
        LicCreateDate.Text = ""
        LicExpiryDate.Text = ""
        LicSending.Text = ""
        LicAutoReply.Text = ""
        LicFilter.Text = ""

        Dim result As ActivationCodeResponse
        Dim lic = New System.Net.WebClient().DownloadString("http://bulkwhatsappmarketing.in/getlic.php?id=3&license=" + HttpUtility.UrlEncode(LicneseTextBox.Text))

        result = ClsLicence.ValidateLicense(lic)

        If Not IsNothing(result) Then
            If result.IsExsist Then
                If Not IsNothing(result.Response) Then
                    If Val(GetServerDate()) <= Val(result.Response.ExpiryDate) Then
                        If result.Response.Status = 1 Then
                            LicName.Text = result.Response.Name
                            LicCreateDate.Text = result.Response.Mobile
                            LicExpiryDate.Text = ClsLicence.ResolveDate(result.Response.ExpiryDate)
                            LicSending.Text = result.Response.AllowSending
                            LicAutoReply.Text = result.Response.AllowBot
                            LicFilter.Text = result.Response.AllowFilter
                            Label12.Text = "License Validated"
                        Else
                            MsgBox("License disabled by vendor.", vbCritical, Application.ProductName)
                        End If

                    Else
                        MsgBox("License already expired.", vbCritical, Application.ProductName)
                    End If
                End If
            Else
                MsgBox("Unable to validate license check vendor.", vbCritical, Application.ProductName)
            End If
        Else
            MsgBox("Unable to validate license check vendor.", vbCritical, Application.ProductName)
        End If

    End Sub


    Private Sub Show()
        Label1.Visible = True
        TextBox1.Visible = True
        Button3.Visible = True
        Button2.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        LicneseTextBox.Visible = True
        TextBox1.Visible = True
        Button2.Visible = True
        Button6.Visible = True
        Button1.Visible = True
        Button4.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label2.Visible = True
        Label4.Visible = True
        Label9.Visible = True
        Label7.Visible = True
        ValidateButton.Visible = True
        Label8.Visible = True
        LicSending1.Visible = True
        LicName.Visible = True
        LicCreateDate.Visible = True
        LicExpiryDate.Visible = True
        LicSending.Visible = True
        LicAutoReply.Visible = True
        LicFilter.Visible = True
        GroupBox3.Visible = True
        GroupBox1.Visible = True

        Label10.Visible = True
        Label11.Visible = True

        Label6.Visible = False
        TextBox2.Visible = False
        Button5.Visible = False
        Label14.Visible = False
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mobile = Trim(TextBox2.Text).Replace("+", "")
        TextBox2.Text = mobile
        If (mobile <> "" And IsNumeric(mobile)) Then
            Dim req = GetDriveSerialNumber(mobile)
            TextBox1.Text = "BWMSBUS - " + req
            SaveSetting(ApplicationTitle, "request", "key", req)
            Show()
        Else
            Label5.Text = "Please Enter Valid Mobile Number"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start(ModuleConfig.SupportURL + "&text=My Order Number Is " + TextBox1.Text + " Please Provide license")
    End Sub
End Class