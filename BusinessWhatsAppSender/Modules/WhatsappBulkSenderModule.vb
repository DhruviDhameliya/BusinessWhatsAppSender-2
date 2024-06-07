Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text
Imports System.Web
Imports Newtonsoft.Json

Module WhatsappBulkSenderModule

    Public ExpriyDate As Long
    Public TotalDays As Integer

    Public AllowSending As Boolean
    Public AllowAutoReply As Boolean
    Public allowFilter As Boolean



    Public WAPIScript As String
    Public _userdetails As New UserDetails
    Public IsDemoMode As Boolean

    Public CurrentPercentage As Integer = 0
    Public MaxValue As Integer = 0

    Public IsPaused As Boolean
    Public IsStoped As Boolean
    Public IsVerificationPaused As Boolean
    Public IsVerificationStoped As Boolean

    Public CurrentLog As String
    Public LastLog As String
    Public BulkIsEnd As Boolean = False

    Public DelayBetweenSend As Integer

    Public IsSending As Boolean = False
    Public SentTillNow As String = ""

    Public total As String
    Public starttime As String
    Public endtime As String
    Public MessageSent As String
    Public Numbers As String
    Public CurrentFileName As String
    Public CurrentReportFile As String
    Public ValidNumber As String = ""
    Public InvalidNumber As String = ""

    Public Attachments As String

    Public _SAccountName As String
    Public _SAccountPath As String
    Public _SUseExsisting As Boolean
    Public _SdialogResult As Integer = 0

    Public CriticalError As String

    Public TotalSent As Integer
    Public TotalFailed As Integer
    Public NumbersSent As String
    Public DemoMode As Boolean = False

    Public TypeMode As Integer
    Public TypeLimit As Integer
    Public TypeAccount As String
    Public TypeAccounts As String


    Sub RestBulk()
        CurrentPercentage = 0
        MaxValue = 0

        IsPaused = False
        IsStoped = False

        CurrentLog = ""
        LastLog = ""
        BulkIsEnd = False

        DelayBetweenSend = 0

        IsSending = False
        SentTillNow = ""

        total = ""
        starttime = ""
        endtime = ""
        MessageSent = ""
        Numbers = ""
        CurrentFileName = ""
    End Sub

    Public Structure ValidateMobileNumberResult
        Public IsValid As Boolean
        Public MobileNumber As String
    End Structure
    Public Function ValidateMobileNumber(ByVal Number As String) As ValidateMobileNumberResult
        Dim _result As New ValidateMobileNumberResult

        If Number.StartsWith("+") Then
            Number = Number.Replace(" ", "")
            Number = Number.Replace("+", "")
            Number = Number.Replace("\", "")
            Number = Number.Replace("/", "")
            Number = Number.Replace("-", "")
            Number = Number.Replace("_", "")
            Number = Number.Replace(".", "")
        End If

        If IsNumeric(Number) Then
            If Number.Length > 5 And Number.Length < 27 Then

                _result.IsValid = True
                _result.MobileNumber = Number

                Return _result
            Else
                _result.IsValid = False
                _result.MobileNumber = Number
            End If
        Else
            _result.IsValid = False
            _result.MobileNumber = Number
        End If
        Return _result
    End Function
    Public Delegate Sub AppendTextBoxDelegate(ByVal TB As TextBox, ByVal txt As String)

    Public Sub AppendTextBox(ByVal TB As TextBox, ByVal txt As String)
        On Error Resume Next
        If TB.InvokeRequired Then
            TB.Invoke(New AppendTextBoxDelegate(AddressOf AppendTextBox), New Object() {TB, txt})
        Else
            TB.AppendText(txt)
        End If
    End Sub
    Public Function TxtID() As String
        Randomize()
        Return "MSG" & Now.ToString("yyyyMMddhhmmss") & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10)
    End Function
    Public Function GenerateReport() As String
        Dim html As String = My.Resources.Report

        html = html.Replace("{{DATE}}", starttime)
        html = html.Replace("{{TOTAL}}", total)
        html = html.Replace("{{SUCCESS}}", TotalSent)
        html = html.Replace("{{FAILED}}", TotalFailed)
        html = html.Replace("{{MESSAGES}}", MessageSent)
        html = html.Replace("{{ATTACHMENTS}}", Attachments)
        html = html.Replace("{{NUMBERS}}", NumbersSent)

        Randomize()
        CurrentFileName = Now.ToString("yyyyMMddhhmmss") & Int(Rnd() * 99999) & ".html"
        Try
            Dim sw As New IO.StreamWriter(IO.Path.GetTempPath & CurrentFileName)
            sw.Write(html)
            sw.Close()

        Catch ex As Exception

        End Try
        Return IO.Path.GetTempPath & CurrentFileName
    End Function
    Public Sub SetTheme(ByRef frm As Form)
        frm.FormBorderStyle = FormBorderStyle.None
    End Sub
    Public Function getMacAddress() As String
        Dim ret As String = GetSetting(Application.ProductName, "initiate", "initiatestart", "")
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Dim Return1 As String = nics(1).GetPhysicalAddress.ToString
        Return ret
    End Function
    Public Function ConvertMactolong(ByVal mac As String) As String
        Dim c As Char
        Dim _long As String = ""
        For Each c In mac
            _long = _long & AscW(c)
        Next
        Return _long
    End Function
    Public Function GetLongMac() As String
        Return ConvertMactolong(getMacAddress)
    End Function
    Public Function GetDate() As Long

        Dim wc As New Net.WebClient
        Try
            Return Val(ServerDecrypt(wc.DownloadString(ServerURL)))
        Catch ex As Exception
            Return Val(Now.ToString("yyyyMMdd"))
        End Try


    End Function

    Public Function Encrypt(ByVal plainText As String) As String

        Dim passPhrase As String = "hhL:WV*7<dgeKY)fjTe>'[9+`GyzS&]3;k8UGKK_&2]!"
        Dim saltValue As String = "q$3}T&qtpTJ>q\t/'/;wh!#%H77e'3AXA(*(qcL%=**)"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@Tls_India_truel"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)


        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()

        symmetricKey.Mode = CipherMode.CBC

        Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

        Dim memoryStream As New MemoryStream()
        Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherTextBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText
    End Function
    Public Function Decrypt(ByVal cipherText As String) As String
        Dim passPhrase As String = "hhL:WV*7<dgeKY)fjTe>'[9+`GyzS&]3;k8UGKK_&2]!"
        Dim saltValue As String = "q$3}T&qtpTJ>q\t/'/;wh!#%H77e'3AXA(*(qcL%=**)"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@Tls_India_truel"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)


        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)


        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)


        Dim symmetricKey As New RijndaelManaged()


        symmetricKey.Mode = CipherMode.CBC


        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

        Dim memoryStream As New MemoryStream(cipherTextBytes)

        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}


        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)


        memoryStream.Close()
        cryptoStream.Close()


        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)


        Return plainText
    End Function
    Public Function ServerDecrypt(ByVal cipherText As String) As String
        Dim passPhrase As String = "`2]3)#mY-epfM7-<t9cZE*'UMj9`cJe_ann~cpdDGp>H"
        Dim saltValue As String = ":vYb/3b4dh?;7Ud{NXErNu@]Z4yz_W5vjeKvx:6P~ucK"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@Tls_India_truel"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)

        Dim symmetricKey As New RijndaelManaged()


        symmetricKey.Mode = CipherMode.CBC


        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)


        Dim memoryStream As New MemoryStream(cipherTextBytes)
        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

        memoryStream.Close()
        cryptoStream.Close()

        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)

        Return plainText
    End Function
    Public Function GetUserSettingsFolder() As String


        Dim MainSettingsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim ApplicationFolder As String = MainSettingsFolder & "\Local Settings\" & ApplicationTitle

        If Not Directory.Exists(ApplicationFolder) Then
            Directory.CreateDirectory(ApplicationFolder)
        End If
        Return ApplicationFolder

    End Function
    Public Function GetServerDate() As String
        Try
            Dim wc As New WebClient
            ' Return ServerDecrypt(wc.DownloadString("http://bulkwhatsappmarketing.in/BusinessGetDateEX.ashx"))
            Return Now.ToString("yyyyMMdd")
        Catch ex As Exception
            Return Now
        End Try
    End Function
    Public Structure appLicense
        Public valid As Boolean
        Public Validtill As String
    End Structure
    'Public Function CheckCurrentLicence() As Boolean
    '    Try
    '        Dim mac = getMac()
    '        Dim license As String = GetSetting(Application.ProductName, "license", "key", "")
    '        If (license <> "") Then
    '            Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
    '            Dim licenseJson As String = getServerData(ServerURL + "isvalidlicense/" + ordernumber + "/" + license + "/" + appversion + "/" + mac, False)
    '            Dim licenseData = jsonParse(licenseJson)
    '            Return CBool(licenseData("status"))
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function



    Public Function CheckCurrentLicence(ByVal License As String) As Object
        Try
            Dim mac = getMac()
            If (License <> "") Then
                Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
                Dim licenseJson As String = getServerData(ServerURL + "isvalidlicense/" + ordernumber + "/" + License + "/" + appversion + "/" + mac, False)
                Dim licenseData = jsonParse(licenseJson)
                Return licenseData
            Else
                Dim licenseData As New Dictionary(Of String, String)
                licenseData("status") = "0"
                licenseData("description") = ""
                Return licenseData
            End If
        Catch ex As Exception
            Dim licenseData As New Dictionary(Of String, String)
            licenseData("status") = "0"
            licenseData("description") = ex.Message
        End Try
    End Function
    Public Sub SaveAccounts(ByVal lst As ListView)
        Try

            Dim li As ListViewItem
            Dim ds As New DataSet
            Dim dt As New DataTable
            dt.TableName = "Accounts"
            Dim AccountName As New DataColumn("AccountName", Type.GetType("System.String"))
            Dim AccountPath As New DataColumn("AccountPath", Type.GetType("System.String"))

            dt.Columns.Add(AccountName)
            dt.Columns.Add(AccountPath)
            Dim dr As DataRow
            For Each li In lst.Items
                dr = dt.NewRow
                dr("AccountName") = li.Text
                dr("AccountPath") = li.Tag
                dt.Rows.Add(dr)
            Next
            ds.DataSetName = "WhatsApp"
            ds.Tables.Add(dt)
            ds.WriteXml(GetDataProfile() & "\Accounts.xml")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, ApplicationTitle)
        End Try
    End Sub
    Public Function LoadAccount() As List(Of AccountDetails)
        Try

            Dim ds As New DataSet
            ds.ReadXml(GetDataProfile() & "\Accounts.xml")
            Dim dr As DataRow
            Dim _accDetails As AccountDetails
            Dim accList As New List(Of AccountDetails)
            For Each dr In ds.Tables(0).Rows
                _accDetails = New AccountDetails
                _accDetails.AccountName = dr("AccountName").ToString
                _accDetails.AccountPath = dr("AccountPath").ToString
                accList.Add(_accDetails)
            Next
            Return accList
        Catch ex As Exception
            '    MsgBox(ex.Message, vbCritical, ApplicationTitle)
            Return New List(Of AccountDetails)
        End Try
    End Function
    Public Structure AccountDetails
        Public AccountName As String
        Public AccountPath As String
    End Structure

    Public Structure AccountSwticherDetails
        Public AccountName As String
        Public AccountPath As String
        Public UseExsisting As Boolean
        Public dialogResult As Integer
        Public rotationList As List(Of AccountDetails)
        Public limitbetweenswitch As Integer
    End Structure

    Public Function CheckConnection() As Boolean
        Try
            Dim wc As New WebClient
            wc.DownloadString(ServerURL)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function GetDataProfile()
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, ApplicationTitle)
            End Try

        End If
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender\Accounts") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender\accounts")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, ApplicationTitle)
            End Try
        End If
        'Environment.SpecialFolder.LocalApplicationData
        Return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender"

    End Function

    Public Function GetDriveSerialNumber(mobile As String) As String
        Try
            Dim mac = getMac()
            Dim Json = getServerData(ServerURL + "insertorderdata/" + mobile + "/" + appversion + "/" + HttpUtility.UrlEncode(mac) + "/", False)
            Dim orderData = jsonParse(Json)
            If orderData("status") = "1" Then
                Return orderData("data")
            Else
                Return orderData("description")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "Something Went Wrong, Try Again"
        End Try
    End Function
    Public LoginTag As String
    Public Sub ShowDemoMessage()
        Process.Start("https://businesswhatsappsender.com/")
        MsgBox("You are using demo version, Get full version to remove those limitations", vbInformation, Application.ProductName)
    End Sub

    Public Function GetLoginTag() As String
        Try
            Return API.BUSloginTag
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Sub CheckLicense()
        Dim mac = getMac()
        On Error Resume Next
        Dim srvdate As Long = Val(GetServerDate())
        Dim result As ActivationCodeResponse
        Dim lic As String = GetSetting(Application.ProductName, "license", "key", "")
        If (lic <> "") Then
            Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
            Dim licenseJson As String = getServerData(ServerURL + "isvalidlicense/" + ordernumber + "/" + lic + "/" + appversion + "/" + mac, False)
            Dim licenseData = jsonParse(licenseJson)
            If licenseData("status").ToString() = "1" Then
                ExpriyDate = licenseData("valid_till")
                TotalDays = ClsLicence.GetRemianingDays(licenseData("valid_till"), srvdate)
                AllowSending = True
                AllowAutoReply = True
                allowFilter = True
            Else
                FrmLicense.ShowDialog()
            End If
        Else
            FrmLicense.ShowDialog()
        End If
    End Sub
    Public Function CheckLicence(ByVal License As String) As Object
        Try
            Dim mac = getMac()
            If (License <> "") Then
                Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
                Dim licenseJson As String = getServerData(ServerURL + "isvalidlicense/" + ordernumber + "/" + License + "/" + appversion + "/" + mac, False)
                Dim licenseData = jsonParse(licenseJson)
                Return licenseData
            Else
                Dim licenseData As New Dictionary(Of String, String)
                licenseData("status") = "0"
                licenseData("description") = ""
                Return licenseData
            End If
        Catch ex As Exception
            Dim licenseData As New Dictionary(Of String, String)
            licenseData("status") = "0"
            licenseData("description") = ex.Message
        End Try
    End Function
    Public Sub ApplyColor(ByRef obj As Object)
        Dim _t As Object
        If obj.backcolor = Color.FromArgb(0, 191, 165) Then
            obj.backcolor = Color.FromArgb(101, 161, 47)
        End If

        For Each _t In obj.controls
            If _t.backcolor = Color.FromArgb(0, 191, 165) Then

                _t.backcolor = Color.FromArgb(101, 161, 47)
            End If
            ApplyColor(_t)
        Next

    End Sub
    Public Sub InitiateStart()
        If GetSetting(Application.ProductName, "initiate", "initiatestart", "") = "" Then
            Dim _res As String = ""
            For i As Integer = 1 To 10
                Randomize()
                _res = _res & Int(Rnd() * 10)
            Next
            Dim PrivateKey As String = Now.ToString("yyyyMMddhhmmss") & _res
            SaveSetting(Application.ProductName, "initiate", "initiatestart", PrivateKey)
        End If
    End Sub


    Public Function SafeJavaScript(ByVal str As String) As String
        Return HttpUtility.JavaScriptStringEncode(str)
    End Function

    Public Function getMac() As String
        Try
            Dim DriveSerial As Integer
            Dim fso As Object = CreateObject("Scripting.FileSystemObject")
            Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
            With Drv
                If .IsReady Then
                    DriveSerial = .SerialNumber
                Else    '"Drive Not Ready!"
                    DriveSerial = -1
                End If
            End With
            Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
            Dim mac = nics(0).GetPhysicalAddress.ToString()
            If (mac = "") Then
                mac = DriveSerial.ToString("X2")
            End If
            Return mac
        Catch ex As Exception
            Return "Invalid Mac"
        End Try
    End Function
    Public Function getServerData(url As String, Optional concate As Boolean = True) As String
        Try
            Dim webClient As New Net.WebClient
            Console.WriteLine("url : " & url)
            Dim data = ""
            If concate Then
                data = webClient.DownloadString(url & "&l=" & Now.ToString("yyyyMMddhhmmss"))
            Else
                data = webClient.DownloadString(url & "?l=" & Now.ToString("yyyyMMddhhmmss"))
            End If
            Console.WriteLine("response : " & data)
            Return data
        Catch ex As Exception
            MsgBox("Not able to connect with Server check your Internet Connection" & ex.Message)
            Return "Something Went Wrong, Try Again"
        End Try
    End Function
    Public Function jsonParse(Json As String) As Object
        Try
            Return JsonConvert.DeserializeObject(Json)
        Catch ex As Exception
            Return "Data Parsing Error"
        End Try
    End Function
    Public Function ChackOrderNumberExist() As Boolean
        Try
            Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
            Dim orderExist As String = getServerData(ServerURL + "isorderexist/" + ordernumber, False)
            Console.WriteLine("orderExist " & orderExist)
            Return CBool(orderExist)
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
