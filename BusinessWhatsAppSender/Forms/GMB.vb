Imports Newtonsoft.Json
Imports OpenQA.Selenium.Chrome

Public Class GMB
    Private ChromeDrv As OpenQA.Selenium.Chrome.ChromeDriver

    Dim nextitem = True
    Dim totalcontact = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Getdata()
    End Sub
    Private Sub Getdata()
        Application.DoEvents()
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Dim query = TextBox1.Text
        Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
        DriverService.HideCommandPromptWindow = True
        ChromeDrv = New ChromeDriver(DriverService, New ChromeOptions())
        ChromeDrv.Navigate.GoToUrl("https://www.google.com/maps/search/" + query + "?hl=en")
        ChromeDrv.Manage.Window.Maximize()
        System.Threading.Thread.Sleep(2000)
        If CBool(GetSetting(ApplicationTitle, "SendingConfig", "HideChromeExtractor", "true")) Then
            ChromeDrv.Manage.Window.Position = New Point(-10000, -10000)
        End If
        Dim myList As ArrayList = New ArrayList()
        myList.Add("One")
        Application.DoEvents()
        System.Threading.Thread.Sleep(1000)
        Dim item = 1
        Try
            ChromeDrv.ExecuteScript(API.GMBScroll)
            System.Threading.Thread.Sleep(2000)
        Catch ex As Exception
            nextitem = False
        End Try
        Try
            ChromeDrv.ExecuteScript(API.GMBScript)
            System.Threading.Thread.Sleep(2000)
        Catch ex As Exception
            nextitem = False
        End Try
        Do
            ChromeDrv.ExecuteScript("window.fnum='null';window.extractMap('" & item & "').then((e)=>{window.fnum = e;});")
            System.Threading.Thread.Sleep(100)
            Dim result = ChromeDrv.ExecuteScript("return window.fnum;")
            Do
                System.Threading.Thread.Sleep(100)
                result = ChromeDrv.ExecuteScript("return window.fnum;")
            Loop While (result.ToString() = "null")
            Dim status = ChromeDrv.ExecuteScript("return window.fnum.status;")
            If status = 1 Then
                Dim name = ChromeDrv.ExecuteScript("return window.fnum.name;")
                Dim Number = ChromeDrv.ExecuteScript("return window.fnum.number;")
                Dim website = ChromeDrv.ExecuteScript("return window.fnum.website;")
                myList.Add(name)
                totalcontact = totalcontact + 1
                Label3.Text = totalcontact.ToString
                LstNumbers.Items.Add(New ListViewItem(New String() {Web.HttpUtility.HtmlDecode(name), Replace(Number, " ", ""), website}))

                LstNumbers.Refresh()
            ElseIf status = -1 Then
                nextitem = False
            End If

            Application.DoEvents()
            item = item + 1
        Loop While (nextitem)
        ChromeDrv.Quit()
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button11.Visible = True
        Button12.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nextitem = False
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As ListViewItem
        Dim li As ListViewItem
        FrmMain.LstNumbers.Visible = False
        For Each a In LstNumbers.Items
            li = New ListViewItem
            li.Tag = TxtID()
            li.Text = a.SubItems.Item(0).Text
            li.SubItems.Add(a.SubItems.Item(1).Text)
            li.SubItems.Add("Pending")
            li.ImageIndex = 0
            FrmMain.LstNumbers.Items.Add(li)
        Next
        FrmMain.LblNumbers.Text = "Whatsapp Numbers (" + LstNumbers.Items.Count().ToString + ")"
        FrmMain.LstNumbers.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If LstNumbers.Items.Count > 0 Then
            SaveFileDialog1.Filter = "*.csv|*.csv"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim li As ListViewItem
                Dim t As String = ""
                For Each li In LstNumbers.Items
                    t = t & li.SubItems(0).Text.Replace(",", "-") & "," & li.SubItems(1).Text & li.SubItems(2).Text & vbNewLine
                Next
                Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                sw.Write(t)
                sw.Close()
                sw.Dispose()
            End If

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        LstNumbers.Items.Clear()
        Label3.Text = "0"
        totalcontact = 0
    End Sub
End Class