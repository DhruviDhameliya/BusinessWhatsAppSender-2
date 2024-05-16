﻿Module ModuleConfig

    Public SupportURL As String = "https://api.whatsapp.com/send?phone=919913299862"
    Public WebsiteURL As String = "https://www.truelinesolution.com/whatsapp-business-marketing-software"
    Public SupportPhone As String = "919913299862"
    Public SupportEmail As String = "contact@truelinesolution.com"
    Public ServerURL As String = "http://bulkwhatsappmarketing.in/BusinessGetDateEX.ashx" 'you can host getlic on your server 

    Public LicenseMode As Boolean = True

    Public ApplicationTitle As String = "WHATSAPP BUSINESS MARKETING SOFTWARE"
    Public ApplicationVersion As String = "8.0 | Trueline Solution  - 122"
    Public Appv As String = "8.0"
    Public Builddate As String = "05-04-2024"
    Public version As String = "2.2"

    Public ShowAbout As Boolean = True
    Public ShowLanguageOption As Boolean = True
    Public ShowThemesOption As Boolean = False
    Public ShowHelp As Boolean = True
    Public ShowUpdateLicense As Boolean = True
    Public MessageRetriveProgress As Boolean = False



    Public Structure API
        Public Shared IsLoggedIn As String
        Public Shared InitiateSender As String
        Public Shared InvalidExist As String
        Public Shared CloseInvalidMessage As String
        Public Shared messageboxid As String
        Public Shared InitiateMessage As String
        Public Shared ClickSend As String
        Public Shared GetWAPI As String
        Public Shared messageboxidinnerText As String
        Public Shared IsCaptionLoaded As String
        Public Shared GetGroupContacts As String

        Public Shared GMBScroll As String
        Public Shared GMBname As String
        Public Shared GMBnumber As String
        Public Shared GMBback As String
        Public Shared GMBnextpage As String
        Public Shared GMBxpath As String

        Public Shared BUSloginTag As String

        Public Shared BlockNumber As String

        Public Shared JDScroll As String
        Public Shared JDUrl As String
        Public Shared JDCname As String
        Public Shared JDCnumber As String
        Public Shared JDCNext As String
        Public Shared JDpre As String
        Public Shared JDEnable As String
        Public Shared GMBEnable As String
        Public Shared VideoEnable As String
        Public Shared version As String
        Public Shared GMBScript As String

        Public Shared IsLoggedInAll As String
    End Structure

    Function allloaded()
        If (API.IsLoggedInAll IsNot vbNullString And API.GMBScript IsNot vbNullString And API.VideoEnable IsNot vbNullString And API.version IsNot vbNullString And API.JDEnable IsNot vbNullString And API.GMBEnable IsNot vbNullString And API.BlockNumber IsNot vbNullString And API.BUSloginTag IsNot vbNullString And API.GetGroupContacts IsNot vbNullString And API.GMBnextpage IsNot vbNullString And API.GMBback IsNot vbNullString And API.GMBnumber IsNot vbNullString And API.GMBname IsNot vbNullString And API.GMBScroll IsNot vbNullString And API.IsCaptionLoaded IsNot vbNullString And API.messageboxidinnerText IsNot vbNullString And API.GetWAPI IsNot vbNullString And API.ClickSend IsNot vbNullString And API.InitiateMessage IsNot vbNullString And API.messageboxid IsNot vbNullString And API.CloseInvalidMessage IsNot vbNullString And API.InvalidExist IsNot vbNullString And API.InitiateSender IsNot vbNullString And API.IsLoggedIn IsNot vbNullString) Then
            Return True
        Else
            Return False
        End If

    End Function


    Function InitAPI()
        Dim BaseUrl As String = "http://digitalbusinessbazaar.com/wp/TLSWAPIScript.php?id="
        API.IsLoggedIn = New System.Net.WebClient().DownloadString(BaseUrl & "1" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.InitiateSender = New System.Net.WebClient().DownloadString(BaseUrl & "2" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.InvalidExist = New System.Net.WebClient().DownloadString(BaseUrl & "3" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.CloseInvalidMessage = New System.Net.WebClient().DownloadString(BaseUrl & "4" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.messageboxid = New System.Net.WebClient().DownloadString(BaseUrl & "5" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.InitiateMessage = New System.Net.WebClient().DownloadString(BaseUrl & "6" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.ClickSend = New System.Net.WebClient().DownloadString(BaseUrl & "7" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GetWAPI = "http://digitalbusinessbazaar.com/wp/TlsWapiVenScript_23032024.js?" & Now.ToString("yyyyMMddhhmmss")
        API.messageboxidinnerText = New System.Net.WebClient().DownloadString(BaseUrl & "9" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.IsCaptionLoaded = New System.Net.WebClient().DownloadString(BaseUrl & "10" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GetGroupContacts = New System.Net.WebClient().DownloadString(BaseUrl & "15" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GMBScroll = New System.Net.WebClient().DownloadString(BaseUrl & "11" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GMBname = New System.Net.WebClient().DownloadString(BaseUrl & "12" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GMBnumber = New System.Net.WebClient().DownloadString(BaseUrl & "13" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GMBback = New System.Net.WebClient().DownloadString(BaseUrl & "14" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GMBnextpage = New System.Net.WebClient().DownloadString(BaseUrl & "20" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GMBxpath = New System.Net.WebClient().DownloadString(BaseUrl & "22" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.BUSloginTag = New System.Net.WebClient().DownloadString(BaseUrl & "21" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.BlockNumber = New System.Net.WebClient().DownloadString(BaseUrl & "23" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.JDScroll = New System.Net.WebClient().DownloadString(BaseUrl & "25" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.JDUrl = New System.Net.WebClient().DownloadString(BaseUrl & "26" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.JDCname = New System.Net.WebClient().DownloadString(BaseUrl & "27" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.JDCnumber = New System.Net.WebClient().DownloadString(BaseUrl & "28" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.JDCNext = New System.Net.WebClient().DownloadString(BaseUrl & "29" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.JDpre = New System.Net.WebClient().DownloadString(BaseUrl & "30" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.JDEnable = New System.Net.WebClient().DownloadString(BaseUrl & "31" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GMBEnable = New System.Net.WebClient().DownloadString(BaseUrl & "32" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.VideoEnable = New System.Net.WebClient().DownloadString(BaseUrl & "33" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.version = New System.Net.WebClient().DownloadString(BaseUrl & "40" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.GMBScript = New System.Net.WebClient().DownloadString(BaseUrl & "46" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
        API.IsLoggedInAll = New System.Net.WebClient().DownloadString(BaseUrl & "48" & "&l=" & Now.ToString("yyyyMMddhhmmss"))
    End Function

    Function StaticInitAPI()
        Dim BaseUrl As String = "https://digitalbusinessbazaar.com/wp/searchTLS.php?id="
        API.IsLoggedIn = "function IsLoggedIn(){ for( let span of document.getElementsByTagName(""span"")) { if (span.getAttribute(""data-icon"")===""default-user"") { return true ; } } return false; } return IsLoggedIn();"
        API.InitiateSender = "function InitiateSender(){ var app =document.getElementsByTagName(""header"")[0]; var a=document.createElement(""a""); a.id=""senderLink""; app.appendChild(a); }InitiateSender();"
        API.InvalidExist = "var result=false; for(let div of document.getElementsByTagName('div')){ if(div.innerText=='Phone number shared via url is invalid.'){result=true;} } return result;"
        API.CloseInvalidMessage = "document.getElementsByClassName('_20C5O')[0].click()"
        API.messageboxid = "document.querySelectorAll(""[data-tab='6']"")[0].setAttribute('id','messageboxid')"
        API.InitiateMessage = "function InitiateMessage(num,message){ var senderLink = document.getElementById(""senderLink""); senderLink.setAttribute(""href"",`https://api.whatsapp.com/send?phone=${num}&text=${message}`); senderLink.click(); }InitiateMessage(""{{NUM}}"",""{{MESSAGE}}"");"
        API.ClickSend = "for (let btnspan of document.getElementsByTagName(""span"")) { if(btnspan.getAttribute(""data-icon"")==""send"") { btnspan.click(); } }"
        API.GetWAPI = "http://digitalbusinessbazaar.com/wp/TlsWapiVenScript.js?"
        API.messageboxidinnerText = "document.getElementById(['messageboxid']).innerText=arguments[0]"
        API.IsCaptionLoaded = "_26J91"
        API.GetGroupContacts = "_2YPr_"

        API.GMBScroll = "var intervalId = null;var varName = function(){if(height < document.getElementsByClassName('section-scrollbox')[1].scrollHeight) {height=document.getElementsByClassName('section-scrollbox')[1].scrollHeight;document.getElementsByClassName('section-scrollbox')[1].scrollTo(0,99999);} else {clearInterval(intervalId);}};var height=document.getElementsByClassName('section-scrollbox')[1].scrollHeight;document.getElementsByClassName('section-scrollbox')[1].scrollTo(0,99999);intervalId = setInterval(varName, 100);"
        API.GMBname = "//*[@class='x3AX1-LfntMc-header-title-title gm2-headline-5']/span[1]"
        API.GMBnumber = "//*[@data-tooltip='Copy phone number']/div/div[2]/div[1]"
        API.GMBback = "document.getElementsByClassName('XeX5ze-a4fUwd-wcotoc-rymPhb-LgbsSe')[0].click()"
        API.GMBnextpage = "ppdPk-Ej1Yeb-LgbsSe-tJiF1e"
        API.GMBxpath = "//*[@id=""pane""]/div/div[1]/div/div/div[contains(@class, ""siAUzd-neVct-Q3DXx-BvBYQ"")]"

        API.BUSloginTag = "_3GlyB"

        API.BlockNumber = "_31enr"
        API.JDScroll = "document.getElementsByClassName('wulf')[0].scrollIntoView({block: 'end'});"
        API.JDUrl = "//*[@id=""tab-5""]/ul/li["
        API.JDCname = "/section/div/section/div/h2/span/a/span"
        API.JDCnumber = "/section/div/section/div/p[contains(@class, ""contact-info"")]/span/a/span"
        API.JDCNext = "//*[@rel=""next""][not(@class)]"
        API.JDpre = "var html=document.getElementsByTagName('HTML')[0].innerHTML;start=1;for(i=0;i<10;i++){start=html.indexOf(""before{content:"",start+2);result = html.substring(start,start+24);html = html.replace(result,'before{content:""'+i+'""}');}document.getElementsByTagName('HTML')[0].innerHTML=html;"
        API.JDEnable = "FALSE"
        API.GMBEnable = "FALSE"
        API.VideoEnable = "FALSE"
    End Function
    Public Function CantRun() As Boolean
        If Val(GetSetting("wapi", "api", "port", "0")) > 3 Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
