Imports OpenQA.Selenium.Chrome
Public Class Jdext
    Private ChromeDrv As OpenQA.Selenium.Chrome.ChromeDriver
    Dim nextpage = True
    Dim nextitem = False
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
        Dim page = 1
        nextpage = True
        Do
            Dim chromeloaded = False
            ChromeDrv = New ChromeDriver(DriverService, New ChromeOptions())
            ChromeDrv.Manage.Window.Maximize()
            If CBool(GetSetting(ApplicationTitle, "SendingConfig", "HideChromeExtractor", "true")) Then
                ChromeDrv.Manage.Window.Position = New Point(-10000, -10000)
            End If
            ChromeDrv.Navigate.GoToUrl(query)
            Do
                Try
                    System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    chromeloaded = False
                Catch ex As Exception
                    chromeloaded = True
                End Try
            Loop While (chromeloaded)


            Dim item = 1
            nextitem = False
            'ChromeDrv.ExecuteScript(API.JDpre)
            Do
                Try
                    System.Threading.Thread.Sleep(500)
                Catch ex As Exception
                    nextpage = False
                End Try
                Dim counter = item
                Dim url = API.JDUrl + counter.ToString + "]"
                Dim nexturl = API.JDUrl + (counter + 1).ToString + "]"
                Try
                    If (ChromeDrv.FindElementsByXPath(nexturl).Count <> 0) Then
                        nextitem = True
                    Else
                        nextitem = False
                    End If
                Catch ex As Exception

                End Try
                Application.DoEvents()
                ChromeDrv.ExecuteScript("document.getElementsByClassName('shownum')[0].click()")
                Dim name = ""
                Dim number = ""
                Try
                    name = ChromeDrv.FindElementByXPath(url + API.JDCname).GetAttribute("innerHTML")
                    number = ChromeDrv.FindElementByXPath(url + API.JDCnumber).GetAttribute("innerHTML")
                    Do
                        System.Threading.Thread.Sleep(1000)
                        number = ChromeDrv.FindElementByXPath(url + API.JDCnumber).GetAttribute("innerHTML")
                    Loop While (number.Contains("Show Number"))
                    number = ChromeDrv.FindElementByXPath(url + API.JDCnumber).GetAttribute("innerHTML")
                Catch ex As Exception
                    Console.WriteLine("Catch")
                    Console.WriteLine(ex)
                End Try
                number.Replace("""", "")
                If (name <> "" And number <> "") Then
                    totalcontact = totalcontact + 1
                    Label3.Text = totalcontact.ToString
                    LstNumbers.Items.Add(New ListViewItem(New String() {Web.HttpUtility.HtmlDecode(name), Replace(number, " ", "")}))
                    LstNumbers.Refresh()
                End If
                System.Threading.Thread.Sleep(3000)
                item = item + 1
                Application.DoEvents()
            Loop While (nextitem)
            page = page + 1
            If (ChromeDrv.FindElementsByXPath(API.JDCNext).Count <> 0 And nextpage = True) Then
                Try
                    query = ChromeDrv.FindElementByXPath(API.JDCNext).GetAttribute("href")
                    nextpage = True
                    System.Threading.Thread.Sleep(2000)
                Catch ex As Exception
                    nextpage = False
                    System.Threading.Thread.Sleep(2000)
                End Try
            Else
                nextpage = False
            End If
            ChromeDrv.Quit()
        Loop While (nextpage)
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button11.Visible = True
        Button12.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nextpage = False
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

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        LstNumbers.Items.Clear()
        Label3.Text = "0"
        totalcontact = 0
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If LstNumbers.Items.Count > 0 Then
            SaveFileDialog1.Filter = "*.csv|*.csv"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim li As ListViewItem
                Dim t As String = ""
                For Each li In LstNumbers.Items
                    t = t & li.SubItems(0).Text.Replace(",", "-") & "," & li.SubItems(1).Text & vbNewLine
                Next
                Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                sw.Write(t)
                sw.Close()
                sw.Dispose()
            End If

        End If
    End Sub
End Class