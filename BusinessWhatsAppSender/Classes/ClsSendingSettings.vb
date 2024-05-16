Public Class SendingSettings
    Public Shared DelayFrom As Integer = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayStart", "1"))
    Public Shared DelayTo As Integer = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayEnd", "2"))
    Public Shared ActivateResting As Boolean = CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateSleep", "false"))
    Public Shared RestAfter As Integer = Val(GetSetting(ApplicationTitle, "SendingConfig", "SleepAfter", 20))
    Public Shared RestFor As Integer = GetSetting(ApplicationTitle, "SendingConfig", "SleepFor", 5)
End Class
