Imports Windows.UI.Popups

Module Vars

    Public SocialNetworkAccessWhat As String() = {"your Facebook account", "your Facebook account", "your Twitter account", "your Instagram account"}
    'This stores which account you will access

    Public SocialNetworkCompany As String() = {"Facebook, Inc.", "Facebook, Inc.", "Twitter, Inc.", "Instagram, Inc.", "Telegram Messenger LLP"}
    'This stores the company name

    Public sidebar_open As Boolean = False
    'Determines whether, or not, the sidebar is open

    Public AppName As String = Package.Current.DisplayName
    'This stores the application name

    Public AccessWhat As String = "their Amazon account"
    'This will store the SolcialNetworkAccessWhat

    Public Company As String = "Amazon, Inc."
    'This will store the SolcialNetworkCompany

    Public PrivacyInfo As String = AppName & " Privacy" & vbCrLf & vbCrLf & "----------" & vbCrLf & vbCrLf & "No personal, or private, information of either you, or your device, is collected by this app." & vbCrLf & vbCrLf & "Neither is ANY information transmitted by this app."
    'This stores the applications' privacy information

    Public AboutInfo As String = AppName & " is a UWP app for Windows 10 Mobile to allow the user to access " & AccessWhat & " from a single portal." & vbCrLf & "Small memory footprint, open source, and forever free." & vbCrLf & "This app is NOT associated in ANY way with " & Company & vbCrLf & "----------" & vbCrLf & vbCrLf & "This UWP app is currently in a BETA test mode." & vbCrLf & "Things MAY change in future versions."
    'This stores information about the application

    Public SocialNetworkURL As String() = {"https://touch.facebook.com/home.php?sk=h_chr", "http://m.me/", "https://mobile.twitter.com/", "https://www.instagram.com/", "https://web.telegram.org/"}
    'This stores the URL of the social network (optimized for mobile... I hope!)

    Public RED_HEX As String() = {"59", "59", "29", "245", "86"}
    'Red colour in hex

    Public GREEN_HEX As String() = {"89", "89", "161", "96", "130"}
    'Green colour in hex

    Public BLUE_HEX As String() = {"152", "152", "242", "64", "163"}
    'Blue colour in hex

    Public WhatSocialNetwork As Integer = 0
    'Determines what network is selected

    Public MyWebViewSource As String
    'Stores the selected URL for the social network selected (see above)

    Public MIT_License As String = "The MIT License (MIT)" & vbCrLf & vbCrLf & "Copyright (c) 2015 .NET Foundation" & vbCrLf & vbCrLf & "Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:" & vbCrLf & vbCrLf & "The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software." & vbCrLf & vbCrLf & "THE SOFTWARE IS PROVIDED ""As Is"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF ERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE."
    'The MIT License (d'oh!)

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