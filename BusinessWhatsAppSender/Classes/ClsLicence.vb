Imports System.Net
Imports System.Web

Public Class ClsLicence
    Public Shared Function ValidateLicense(ByVal ActivationCode As String) As ActivationCodeResponse
        Try
            'Dim url As String = "http://businesswhatsappsender.mediaplus.me/api/v1/checkKey.ashx"
            'Dim _Wbclient As New WebClient
            'Dim data As Byte() = Text.Encoding.ASCII.GetBytes(ActivationCode)
            'Dim result As Byte() = _Wbclient.UploadData(url, data)
            'Dim jsonResult As String = Text.Encoding.UTF8.GetString(result)
            'Dim response As ActivationCodeResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ActivationCodeResponse)(jsonResult)
            'Return response
            Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
            Console.WriteLine("ApplicationTitle : " + ApplicationTitle)
            Console.WriteLine(GetSetting(ApplicationTitle, "request", "key", ""))

            Dim request As String = New System.Net.WebClient().DownloadString("http://bulkwhatsappmarketing.in/getrequestbyorder.php?ordernumber=" + ordernumber)
            Console.WriteLine("http://bulkwhatsappmarketing.in/getrequestbyorder.php?ordernumber=" + ordernumber)
            request = request.Split(",")(3).Split(":")(1).Replace("""", "").Replace("}", "")
            Dim jsonResult As String = New System.Net.WebClient().DownloadString("http://bulkwhatsappmarketing.in/newvalidate.php?id=3&license=" + HttpUtility.UrlEncode(ActivationCode) + "&request=" + HttpUtility.UrlEncode(request) + "&ordernumber=" + ordernumber)
            Console.WriteLine("http://bulkwhatsappmarketing.in/newvalidate.php?id=3&license=" + HttpUtility.UrlEncode(ActivationCode) + "&request=" + HttpUtility.UrlEncode(request) + "&ordernumber=" + ordernumber)
            Dim response As ActivationCodeResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ActivationCodeResponse)(jsonResult)
            Return response
        Catch ex As Exception
            Dim ErrorResponse As New ActivationCodeResponse
            ErrorResponse.IsExsist = False
            ErrorResponse.ErrorDescription = "Error unable to validate license"
            ErrorResponse.Response = Nothing
            Return ErrorResponse
        End Try

    End Function

    Private Shared Function GetServerDate() As Long
        Try
            Dim wc As New WebClient
            Return Val(ServerDecrypt(wc.DownloadString(ServerURL)))
        Catch ex As Exception
            Return Val(Now.ToString("yyyyMMdd"))
        End Try
    End Function
    Public Shared Function ResolveDate(ByVal sDate1 As Long) As String
        Dim Date1 As New Date(Mid(sDate1, 1, 4), Mid(sDate1, 5, 2), Mid(sDate1, 7, 2))
        Return Date1.ToString("dd MMMM yyyy")
    End Function
    Public Shared Function GetRemianingDays(ByVal sDate1 As Long, ByVal sDate2 As Long) As Integer
        Dim Date1 As New Date(Mid(sDate1, 1, 4), Mid(sDate1, 5, 2), Mid(sDate1, 7, 2))
        Dim Date2 As New Date(Mid(sDate2, 1, 4), Mid(sDate2, 5, 2), Mid(sDate2, 7, 2))
        Return DateDiff(DateInterval.Day, Date2, Date1)
    End Function
End Class
Public Class LicenseVerificationResult
    Public IsValid As Boolean
    Public ExpiryDate As String
    Public RemaningDays As Integer
    Public ErrorDescription As String
    Public IsFilter As Boolean
    Public IsSending As Boolean
    Public iSbOT As Boolean
End Class
Public Class ActivationCodeResponse
    Public IsExsist As Boolean
    Public ErrorDescription As String
    Public Response As ActivationCodeModel
End Class
Public Class ActivationCodeModel
    Public ExpiryDate As String
    Public Name As String
    Public Email As String
    Public Mobile As String
    Public Status As Integer
    Public AllowSending As Boolean
    Public AllowBot As Boolean
    Public AllowFilter As Boolean
    Public RequestKey As String
End Class
