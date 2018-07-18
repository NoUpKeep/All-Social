Imports Windows.UI.Popups

Module Vars

    Public SocialNetworkAccessWhat As String() = {"your Facebook account", "your Twitter account", "your Instagram account"}

    Public SocialNetworkCompany As String() = {"Facebook, Inc.", "Twitter, Inc.", "Instagram, Inc.", "Telegram Messenger LLP"}

    Public sidebar_open As Boolean = False

    Public AppName As String = Package.Current.DisplayName

    Public AccessWhat As String = "their Amazon account"

    Public Company As String = "Amazon, Inc."

    Public PrivacyInfo As String = AppName & " Privacy" & vbCrLf & vbCrLf & "----------" & vbCrLf & vbCrLf & "No personal, or private, information of either you, or your device, is collected by this app." & vbCrLf & vbCrLf & "Neither is ANY information transmitted by this app."

    Public AboutInfo As String = AppName & " is a UWP app for Windows 10 Mobile to allow the user to access " & AccessWhat & " from a single portal." & vbCrLf & vbCrLf & "Small memory footprint, open source, and forever free." & vbCrLf & vbCrLf & "This app is NOT associated in ANY way with " & Company & vbCrLf & vbCrLf & "----------" & vbCrLf & vbCrLf & "This UWP app is currently in a BETA test mode." & vbCrLf & vbCrLf & "Things MAY change in future versions."

    Public SocialNetworkURL As String() = {"https://touch.facebook.com/home.php", "https://mobile.twitter.com/", "https://www.instagram.com/?hl=en", "https://web.telegram.org/"}

    Public RED_HEX As String() = {"59", "29", "245", "86"}

    Public GREEN_HEX As String() = {"89", "161", "96", "130"}

    Public BLUE_HEX As String() = {"152", "242", "64", "163"}

    Public WhatSocialNetwork As Integer = 0

    Public MyWebViewSource As String

    Public Async Function displayMessageAsync(ByVal title As String, ByVal content As String, ByVal dialogType As String) As Task
        Dim messageDialog = New MessageDialog(content, title)
        If dialogType = "notification" Then
        Else
            messageDialog.Commands.Add(New UICommand("Yes", Nothing))
            messageDialog.Commands.Add(New UICommand("No", Nothing))
            messageDialog.DefaultCommandIndex = 0
        End If
        messageDialog.CancelCommandIndex = 1
        Dim cmdResult = Await messageDialog.ShowAsync()
        If cmdResult.Label = "Yes" Then
            Application.Current.Exit()
        End If
    End Function

End Module