' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

Imports Windows.Phone.UI.Input
Imports Windows.UI
Imports Windows.UI.Core

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Async Sub BackPressed(sender As Object, e As BackPressedEventArgs)
        'Handles any Back button presses.
        e.Handled = True
        Select Case WhatSocialNetwork
            Case 0
                If AllSocialFB.CanGoBack Then
                    AllSocialFB.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 1
                If AllSocialTW.CanGoBack Then
                    AllSocialTW.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 2
                If AllSocialINST.CanGoBack Then
                    AllSocialINST.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
        End Select
    End Sub

    Private Sub ABOUT_APP_Click(sender As Object, e As RoutedEventArgs) Handles ABOUT_APP.Click
        SIDEBAR.Visibility = Visibility.Collapsed
        sidebar_open = False
        AccessWhat = SocialNetworkAccessWhat(WhatSocialNetwork)
        Company = SocialNetworkCompany(WhatSocialNetwork)
        AboutInfo = AppName & " is a UWP app for Windows 10 Mobile to allow the user to access " & AccessWhat & " from a single portal." & vbCrLf & vbCrLf & "Small memory footprint, open source, and forever free." & vbCrLf & vbCrLf & "This app is NOT associated in ANY way with " & Company & vbCrLf & vbCrLf & "----------" & vbCrLf & vbCrLf & "This UWP app is currently in a BETA test mode." & vbCrLf & vbCrLf & "Things MAY change in future versions."
        SettingsSetup()
    End Sub

    Private Async Sub AllSocialFB_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles AllSocialFB.LoadCompleted
        Dim cssToApply As String = ""
        cssToApply += "#header {position: fixed; z-index: 12; top: 0px;} #root {padding-top: 44px;} .item.more {position:fixed; bottom: 0px; text-align: center !important;}"
        Dim h = ApplicationView.GetForCurrentView().VisibleBounds.Height - 44
        Dim density As Single = DisplayInformation.GetForCurrentView().LogicalDpi
        Dim barHeight As Integer = CInt((h / density))
        cssToApply += ".flyout {max-height:" & barHeight & "px; overflow-y:scroll;}"
        cssToApply += "#m_newsfeed_stream article[data-ft*=""\\""ei\\"":\\""""] {display:none !important;}"
        Await AllSocialFB.InvokeScriptAsync("eval", {"javascript:function addStyleString(str) { var node = document.createElement('style'); node.innerHTML = " & "str; document.body.appendChild(node); } addStyleString('" & cssToApply & "');"})
        iconRotation.Stop()
    End Sub

    Private Sub AllSocialFB_Loading(sender As FrameworkElement, args As Object) Handles AllSocialFB.Loading
        iconRotation.Begin()
    End Sub

    Private Async Sub AllSocialINST_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles AllSocialINST.LoadCompleted
        Dim cssToApply As String = ""
        cssToApply += "#header {position: fixed; z-index: 12; top: 0px;} #root {padding-top: 44px;} .item.more {position:fixed; bottom: 0px; text-align: center !important;}"
        Dim h = ApplicationView.GetForCurrentView().VisibleBounds.Height - 44
        Dim density As Single = DisplayInformation.GetForCurrentView().LogicalDpi
        Dim barHeight As Integer = CInt((h / density))
        cssToApply += ".flyout {max-height:" & barHeight & "px; overflow-y:scroll;}"
        cssToApply += "#m_newsfeed_stream article[data-ft*=""\\""ei\\"":\\""""] {display:none !important;}"
        Await AllSocialINST.InvokeScriptAsync("eval", {"javascript:function addStyleString(str) { var node = document.createElement('style'); node.innerHTML = " & "str; document.body.appendChild(node); } addStyleString('" & cssToApply & "');"})
        iconRotation.Stop()
    End Sub

    Private Sub AllSocialINST_Loading(sender As FrameworkElement, args As Object) Handles AllSocialINST.Loading
        iconRotation.Begin()
    End Sub

    Private Sub AllSocialTW_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles AllSocialTW.LoadCompleted
        iconRotation.Stop()
    End Sub

    Private Sub AllSocialTW_Loading(sender As FrameworkElement, args As Object) Handles AllSocialTW.Loading
        iconRotation.Begin()
    End Sub

    Private Async Sub BACK_Click(sender As Object, e As RoutedEventArgs) Handles BACK.Click
        Select Case WhatSocialNetwork
            Case 0
                If AllSocialFB.CanGoBack Then
                    AllSocialFB.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 1
                If AllSocialTW.CanGoBack Then
                    AllSocialTW.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 2
                If AllSocialINST.CanGoBack Then
                    AllSocialINST.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
        End Select
    End Sub

    Private Sub ClearSocialNetwork()
        Select Case WhatSocialNetwork
            Case 0
                FaceBook.Visibility = Visibility.Collapsed
                Twitter.Visibility = Visibility.Visible
                Instagram.Visibility = Visibility.Visible
                '
                AllSocialFB.Visibility = Visibility.Visible
                AllSocialTW.Visibility = Visibility.Collapsed
                AllSocialINST.Visibility = Visibility.Collapsed
            Case 1
                FaceBook.Visibility = Visibility.Visible
                Twitter.Visibility = Visibility.Collapsed
                Instagram.Visibility = Visibility.Visible
                '
                AllSocialFB.Visibility = Visibility.Collapsed
                AllSocialTW.Visibility = Visibility.Visible
                AllSocialINST.Visibility = Visibility.Collapsed
            Case 2
                FaceBook.Visibility = Visibility.Visible
                Twitter.Visibility = Visibility.Visible
                Instagram.Visibility = Visibility.Collapsed
                '
                AllSocialFB.Visibility = Visibility.Collapsed
                AllSocialTW.Visibility = Visibility.Collapsed
                AllSocialINST.Visibility = Visibility.Visible
        End Select
    End Sub

    Private Sub CloseGrid_Click(sender As Object, e As RoutedEventArgs) Handles CloseGrid.Click
        Info.Visibility = Visibility.Collapsed
    End Sub

    Private Sub EXIT_APP_Click(sender As Object, e As RoutedEventArgs) Handles EXIT_APP.Click
        SIDEBAR.Visibility = Visibility.Collapsed
        Application.Current.Exit()
    End Sub

    Private Sub FB_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles FB.Tapped
        SelectNetwork(0)
    End Sub

    Private Sub Go_Home()
        iconRotation.Begin()
        Dim mwv As Uri 'Contains the source URL for Facebook Touch
        mwv = New Uri(MyWebViewSource)
        Select Case WhatSocialNetwork
            Case 0
                AllSocialFB.Navigate(New Uri(MyWebViewSource))
            Case 1
                AllSocialTW.Navigate(New Uri(MyWebViewSource))
            Case 2
                AllSocialINST.Navigate(New Uri(MyWebViewSource))
        End Select
    End Sub

    Private Sub HamburgerButton_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles HamburgerButton.Tapped
        If sidebar_open Then
            SIDEBAR.Visibility = Visibility.Collapsed
            sidebar_open = False
        Else
            SIDEBAR.Visibility = Visibility.Visible
            sidebar_open = True
        End If
    End Sub

    Private Sub HOME_Click(sender As Object, e As RoutedEventArgs) Handles HOME.Click
        Go_Home()
    End Sub

    Private Async Sub hyperDev_Click(sender As Object, e As RoutedEventArgs) Handles hyperDev.Click
        Dim logoURL = New Uri("https://github.com/CelestialDoom/All-Social")
        Await Windows.System.Launcher.LaunchUriAsync(logoURL)
    End Sub

    Private Async Sub hyperLogo_Click(sender As Object, e As RoutedEventArgs) Handles hyperLogo.Click
        Dim logoURL = New Uri("https://s19.postimg.cc/kfvybyyub/All_Social_v1_inv.png")
        Await Windows.System.Launcher.LaunchUriAsync(logoURL)
    End Sub

    Private Sub INST_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles INST.Tapped
        SelectNetwork(2)
    End Sub

    Private Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        AddHandler HardwareButtons.BackPressed, AddressOf BackPressed
        iconRotation.Begin()
        AddHandler SystemNavigationManager.GetForCurrentView().BackRequested, Sub(s, a)
                                                                                  Select Case WhatSocialNetwork
                                                                                      Case 0
                                                                                          If AllSocialFB.CanGoBack Then
                                                                                              AllSocialFB.GoBack()
                                                                                              a.Handled = True
                                                                                          End If
                                                                                      Case 1
                                                                                          If AllSocialTW.CanGoBack Then
                                                                                              AllSocialTW.GoBack()
                                                                                              a.Handled = True
                                                                                          End If
                                                                                      Case 2
                                                                                          If AllSocialINST.CanGoBack Then
                                                                                              AllSocialINST.GoBack()
                                                                                              a.Handled = True
                                                                                          End If
                                                                                  End Select
                                                                              End Sub
        SelectNetwork(0)
    End Sub

    Private Sub REFRESH_Click(sender As Object, e As RoutedEventArgs) Handles REFRESH.Click
        iconRotation.Begin()
        Select Case WhatSocialNetwork
            Case 0
                AllSocialFB.Refresh()
            Case 1
                AllSocialTW.Refresh()
            Case 2
                AllSocialINST.Refresh()
            Case 3
                AllSocialVimeo.Refresh()
            Case 4
                AllSocialLink.Refresh()
        End Select
    End Sub

    Private Sub SelectNetwork(ByVal x As Integer)
        SIDEBAR.Visibility = Visibility.Collapsed
        sidebar_open = False
        SIDEBAR.Background = New SolidColorBrush(Color.FromArgb(255, RED_HEX(x), GREEN_HEX(x), BLUE_HEX(x)))
        CB.Background = New SolidColorBrush(Color.FromArgb(255, RED_HEX(x), GREEN_HEX(x), BLUE_HEX(x)))
        MyWebViewSource = SocialNetworkURL(x)
        WhatSocialNetwork = x
        iconRotation.Begin()
        ClearSocialNetwork()
        Go_Home()
    End Sub

    Private Sub SettingsSetup()
        Dim number As PackageVersion = Package.Current.Id.Version
        PivotSettingsAbout.SelectedIndex = 0
        version.Text = String.Format(" {0}.{1}.{2}" & vbCrLf, number.Major, number.Minor, number.Build)
        App_Name.Text = AppName
        privacy.Text = PrivacyInfo
        about.Text = AboutInfo
        ScrollView.ChangeView(Nothing, 0, Nothing, True)
        PivotSettingsAbout.Background = New SolidColorBrush(Color.FromArgb(255, RED_HEX(WhatSocialNetwork), GREEN_HEX(WhatSocialNetwork), BLUE_HEX(WhatSocialNetwork)))
        Info.Visibility = Visibility.Visible
    End Sub

    Private Async Sub TOP_Click(sender As Object, e As RoutedEventArgs) Handles TOP.Click
        Dim ScrollToTopString = "var int = setInterval(function(){window.scrollBy(0, -36); if( window.pageYOffset === 0 ) clearInterval(int); }, 0.1);"
        Select Case WhatSocialNetwork
            Case 0
                Await AllSocialFB.InvokeScriptAsync("eval", New String() {ScrollToTopString})
            Case 1
                Await AllSocialTW.InvokeScriptAsync("eval", New String() {ScrollToTopString})
            Case 2
                Await AllSocialINST.InvokeScriptAsync("eval", New String() {ScrollToTopString})
            Case 3
                Await AllSocialVimeo.InvokeScriptAsync("eval", New String() {ScrollToTopString})
            Case 4
                Await AllSocialLink.InvokeScriptAsync("eval", New String() {ScrollToTopString})
        End Select
    End Sub

    Private Sub TW_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles TW.Tapped
        SelectNetwork(1)
    End Sub

End Class