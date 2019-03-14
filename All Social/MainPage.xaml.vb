' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

Imports Windows.ApplicationModel.Resources
Imports Windows.Phone.UI.Input
Imports Windows.UI
Imports Windows.UI.Core

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
''' <seealso cref="Windows.UI.Xaml.Controls.Page" />
''' <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector" />
''' <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector2" />
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' Backs the pressed.
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="e">The <see cref="BackPressedEventArgs"/> instance containing the event data.</param>
    Async Sub BackPressed(sender As Object, e As BackPressedEventArgs)
        'Handles any Back button presses.
        e.Handled = True
        Select Case WhatSocialNetwork
            Case 0
                If AllSocial0.CanGoBack Then
                    AllSocial0.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 1
                If AllSocial2.CanGoBack Then
                    AllSocial2.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 2
                If AllSocial3.CanGoBack Then
                    AllSocial3.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 3
                If AllSocial4.CanGoBack Then
                    AllSocial4.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
        End Select
    End Sub

    ''' <summary>
    ''' Handles the Click event of the ABOUT_APP control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub ABOUT_APP_Click(sender As Object, e As RoutedEventArgs) Handles ABOUT_APP.Click
        SIDEBAR.Visibility = Visibility.Collapsed
        sidebar_open = False
        AccessWhat = SocialNetworkAccessWhat(WhatSocialNetwork)
        Company = SocialNetworkCompany(WhatSocialNetwork)
        AboutInfo = AppName & " is a UWP app for Windows 10 Mobile to allow the user to access " & AccessWhat & " from a single portal." & vbCrLf & vbCrLf & "Small memory footprint, open source, and forever free." & vbCrLf & vbCrLf & "This app is NOT associated in ANY way with " & Company & vbCrLf & vbCrLf & "----------" & vbCrLf & vbCrLf & "This UWP app is currently in a BETA test mode." & vbCrLf & vbCrLf & "Things MAY change in future versions."
        AboutApp(0)
    End Sub

    ''' <summary>
    ''' Handles the GotFocus event of the AllSocial0 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub AllSocial0_GotFocus(sender As Object, e As RoutedEventArgs) Handles AllSocial0.GotFocus
        SIDEBAR.Visibility = Visibility.Collapsed
        sidebar_open = False
    End Sub

    ''' <summary>
    ''' Handles the LoadCompleted event of the AllSocial0 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    Private Async Sub AllSocial0_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles AllSocial0.LoadCompleted
        Dim cssToApply As String = ""
        cssToApply += "#header {position: fixed; z-index: 12; top: 0px;} #root {padding-top: 44px;} .item.more {position:fixed; bottom: 0px; text-align: center !important;}"
        cssToApply += ".flyout {max-height:" & barHeight & "px; overflow-y:scroll;}"
        cssToApply += "#m_newsfeed_stream article[data-ft*=""\\""ei\\"":\\""""] {display:none !important;}"
        Await AllSocial0.InvokeScriptAsync("eval", {"javascript:function addStyleString(str) { var node = document.createElement('style'); node.innerHTML = " & "str; document.body.appendChild(node); } addStyleString('" & cssToApply & "');"})
        iconRotation.Stop()
    End Sub

    ''' <summary>
    ''' Alls the social0 loading.
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="args">The arguments.</param>
    Private Sub AllSocial0_Loading(sender As FrameworkElement, args As Object) Handles AllSocial0.Loading
        iconRotation.Begin()
    End Sub

    ''' <summary>
    ''' Handles the GotFocus event of the AllSocial1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub AllSocial1_GotFocus(sender As Object, e As RoutedEventArgs) Handles AllSocial1.GotFocus
        SIDEBAR.Visibility = Visibility.Collapsed
        sidebar_open = False
    End Sub

    ''' <summary>
    ''' Handles the LoadCompleted event of the AllSocial1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    Private Async Sub AllSocial1_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles AllSocial1.LoadCompleted
        Dim cssToApply As String = ""
        cssToApply += "#header {position: fixed; z-index: 12; top: 0px;} #root {padding-top: 44px;} .item.more {position:fixed; bottom: 0px; text-align: center !important;}"
        cssToApply += ".flyout {max-height:" & barHeight & "px; overflow-y:scroll;}"
        cssToApply += "#m_newsfeed_stream article[data-ft*=""\\""ei\\"":\\""""] {display:none !important;}"
        Await AllSocial1.InvokeScriptAsync("eval", {"javascript:function addStyleString(str) { var node = document.createElement('style'); node.innerHTML = " & "str; document.body.appendChild(node); } addStyleString('" & cssToApply & "');"})
        iconRotation.Stop()
    End Sub

    ''' <summary>
    ''' Handles the GotFocus event of the AllSocial2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub AllSocial2_GotFocus(sender As Object, e As RoutedEventArgs) Handles AllSocial2.GotFocus
        SIDEBAR.Visibility = Visibility.Collapsed
        sidebar_open = False
    End Sub

    ''' <summary>
    ''' Handles the LoadCompleted event of the AllSocial2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    Private Sub AllSocial2_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles AllSocial2.LoadCompleted
        iconRotation.Stop()
    End Sub

    ''' <summary>
    ''' Alls the social2 loading.
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="args">The arguments.</param>
    Private Sub AllSocial2_Loading(sender As FrameworkElement, args As Object) Handles AllSocial2.Loading
        iconRotation.Begin()
    End Sub

    ''' <summary>
    ''' Handles the GotFocus event of the AllSocial3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub AllSocial3_GotFocus(sender As Object, e As RoutedEventArgs) Handles AllSocial3.GotFocus
        SIDEBAR.Visibility = Visibility.Collapsed
        sidebar_open = False
    End Sub

    ''' <summary>
    ''' Handles the LoadCompleted event of the AllSocial3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    Private Async Sub AllSocial3_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles AllSocial3.LoadCompleted
        Dim cssToApply As String = ""
        cssToApply += "#header {position: fixed; z-index: 12; top: 0px;} #root {padding-top: 44px;} .item.more {position:fixed; bottom: 0px; text-align: center !important;}"
        cssToApply += ".flyout {max-height:" & barHeight & "px; overflow-y:scroll;}"
        cssToApply += "#m_newsfeed_stream article[data-ft*=""\\""ei\\"":\\""""] {display:none !important;}"
        Await AllSocial3.InvokeScriptAsync("eval", {"javascript:function addStyleString(str) { var node = document.createElement('style'); node.innerHTML = " & "str; document.body.appendChild(node); } addStyleString('" & cssToApply & "');"})
        iconRotation.Stop()
    End Sub

    ''' <summary>
    ''' Alls the social3 loading.
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="args">The arguments.</param>
    Private Sub AllSocial3_Loading(sender As FrameworkElement, args As Object) Handles AllSocial3.Loading
        iconRotation.Begin()
    End Sub

    ''' <summary>
    ''' Handles the GotFocus event of the AllSocial4 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub AllSocial4_GotFocus(sender As Object, e As RoutedEventArgs) Handles AllSocial4.GotFocus
        SIDEBAR.Visibility = Visibility.Collapsed
        sidebar_open = False
    End Sub

    ''' <summary>
    ''' Handles the LoadCompleted event of the AllSocial4 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    Private Sub AllSocial4_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles AllSocial4.LoadCompleted
        iconRotation.Stop()
    End Sub

    ''' <summary>
    ''' Handles the Click event of the BACK control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Async Sub BACK_Click(sender As Object, e As RoutedEventArgs) Handles BACK.Click
        Select Case WhatSocialNetwork
            Case 0
                If AllSocial0.CanGoBack Then
                    AllSocial0.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 1
                If AllSocial2.CanGoBack Then
                    AllSocial2.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 2
                If AllSocial3.CanGoBack Then
                    AllSocial3.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
            Case 3
                If AllSocial4.CanGoBack Then
                    AllSocial4.GoBack()
                Else
                    Await displayMessageAsync("Quit " & AppName, "Are you sure you want to quit the app?", "")
                End If
        End Select
    End Sub

    ''' <summary>
    ''' Clears the social network.
    ''' </summary>
    Private Sub ClearSocialNetwork()
        Select Case WhatSocialNetwork
            Case 0
                FaceBook.Visibility = Visibility.Collapsed
                Twitter.Visibility = Visibility.Visible
                Instagram.Visibility = Visibility.Visible
                Telegram.Visibility = Visibility.Visible
                '
                AllSocial0.Visibility = Visibility.Visible
                AllSocial2.Visibility = Visibility.Collapsed
                AllSocial3.Visibility = Visibility.Collapsed
                AllSocial4.Visibility = Visibility.Collapsed
            Case 1
                FaceBook.Visibility = Visibility.Visible
                Twitter.Visibility = Visibility.Collapsed
                Instagram.Visibility = Visibility.Visible
                Telegram.Visibility = Visibility.Visible
                '
                AllSocial0.Visibility = Visibility.Collapsed
                AllSocial2.Visibility = Visibility.Visible
                AllSocial3.Visibility = Visibility.Collapsed
                AllSocial4.Visibility = Visibility.Collapsed
            Case 2
                FaceBook.Visibility = Visibility.Visible
                Twitter.Visibility = Visibility.Visible
                Instagram.Visibility = Visibility.Collapsed
                Telegram.Visibility = Visibility.Visible
                '
                AllSocial0.Visibility = Visibility.Collapsed
                AllSocial2.Visibility = Visibility.Collapsed
                AllSocial3.Visibility = Visibility.Visible
                AllSocial4.Visibility = Visibility.Collapsed
            Case 3
                FaceBook.Visibility = Visibility.Visible
                Twitter.Visibility = Visibility.Visible
                Instagram.Visibility = Visibility.Visible
                Telegram.Visibility = Visibility.Collapsed
                '
                AllSocial0.Visibility = Visibility.Collapsed
                AllSocial2.Visibility = Visibility.Collapsed
                AllSocial3.Visibility = Visibility.Collapsed
                AllSocial4.Visibility = Visibility.Visible
        End Select
    End Sub

    ''' <summary>
    ''' Handles the Click event of the EXIT_APP control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub EXIT_APP_Click(sender As Object, e As RoutedEventArgs) Handles EXIT_APP.Click
        SIDEBAR.Visibility = Visibility.Collapsed
        Application.Current.Exit()
    End Sub

    ''' <summary>
    ''' Handles the Tapped event of the FB control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    Private Sub FB_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles FB.Tapped
        SelectNetwork(0)
    End Sub

    ''' <summary>
    ''' Goes the home.
    ''' </summary>
    Private Sub Go_Home()
        iconRotation.Begin()
        Dim mwv As Uri 'Contains the source URL for Facebook Touch
        mwv = New Uri(MyWebViewSource)
        Select Case WhatSocialNetwork
            Case 0
                AllSocial0.Navigate(New Uri(MyWebViewSource))
            Case 1
                AllSocial2.Navigate(New Uri(MyWebViewSource))
            Case 2
                AllSocial3.Navigate(New Uri(MyWebViewSource))
            Case 3
                AllSocial4.Navigate(New Uri(MyWebViewSource))
        End Select
    End Sub

    ''' <summary>
    ''' Handles the Tapped event of the HamburgerButton control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    Private Sub HamburgerButton_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles HamburgerButton.Tapped
        If sidebar_open Then
            SIDEBAR.Visibility = Visibility.Collapsed
            sidebar_open = False
        Else
            SIDEBAR.Visibility = Visibility.Visible
            sidebar_open = True
        End If
    End Sub

    ''' <summary>
    ''' Handles the Click event of the HOME control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub HOME_Click(sender As Object, e As RoutedEventArgs) Handles HOME.Click
        Go_Home()
    End Sub

    ''' <summary>
    ''' Handles the Tapped event of the INST control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    Private Sub INST_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles INST.Tapped
        SelectNetwork(2)
    End Sub

    ''' <summary>
    ''' Handles the Loaded event of the MainPage control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        AddHandler HardwareButtons.BackPressed, AddressOf BackPressed
        'UserAgentHelper.SetDefaultUserAgent(UserAgentString(0))
        SIDEBAR.Visibility = Visibility.Collapsed
        iconRotation.Begin()
        AddHandler SystemNavigationManager.GetForCurrentView().BackRequested, Sub(s, a)
                                                                                  Select Case WhatSocialNetwork
                                                                                      Case 0
                                                                                          If AllSocial0.CanGoBack Then
                                                                                              AllSocial0.GoBack()
                                                                                              a.Handled = True
                                                                                          End If
                                                                                      Case 1
                                                                                          If AllSocial2.CanGoBack Then
                                                                                              AllSocial2.GoBack()
                                                                                              a.Handled = True
                                                                                          End If
                                                                                      Case 2
                                                                                          If AllSocial3.CanGoBack Then
                                                                                              AllSocial3.GoBack()
                                                                                              a.Handled = True
                                                                                          End If
                                                                                      Case 3
                                                                                          If AllSocial4.CanGoBack Then
                                                                                              AllSocial4.GoBack()
                                                                                              a.Handled = True
                                                                                          End If
                                                                                  End Select
                                                                              End Sub
        SelectNetwork(0)
    End Sub

    ''' <summary>
    ''' Handles the Click event of the REFRESH control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
    Private Sub REFRESH_Click(sender As Object, e As RoutedEventArgs) Handles REFRESH.Click
        iconRotation.Begin()
        Select Case WhatSocialNetwork
            Case 0
                AllSocial0.Refresh()
            Case 1
                AllSocial2.Refresh()
            Case 2
                AllSocial3.Refresh()
            Case 3
                AllSocial4.Refresh()
        End Select
    End Sub

    ''' <summary>
    ''' Selects the network.
    ''' </summary>
    ''' <param name="x">The x.</param>
    Private Sub SelectNetwork(ByVal x As Integer)
        SIDEBAR.Visibility = Visibility.Collapsed
        sidebar_open = False
        SIDEBAR.Background = New SolidColorBrush(Color.FromArgb(255, RED_HEX(x), GREEN_HEX(x), BLUE_HEX(x)))
        CB.Background = New SolidColorBrush(Color.FromArgb(255, RED_HEX(x), GREEN_HEX(x), BLUE_HEX(x)))
        MyWebViewSource = SocialNetworkURL(x)
        WhatSocialNetwork = x
        SelectUserAgent(x)
        iconRotation.Begin()
        ClearSocialNetwork()
        Go_Home()
    End Sub

    Private Sub SelectUserAgent(ByVal x As Integer)
        Select Case x
            Case 0
                UserAgentHelper.SetDefaultUserAgent(UserAgentString(0))
            Case 1
                UserAgentHelper.SetDefaultUserAgent(UserAgentString(0))
            Case 2
                UserAgentHelper.SetDefaultUserAgent(UserAgentString(0))
            Case 3
                UserAgentHelper.SetDefaultUserAgent(UserAgentString(0))
        End Select
    End Sub

    ''' <summary>
    ''' Settingse the setup.
    ''' </summary>
    Private Sub AboutApp(ByVal x As Integer)
        Dim number As PackageVersion = Package.Current.Id.Version
        Dim build As String
        build = AppName & " v." & String.Format(" {0}.{1}.{2}" & vbCrLf, number.Major, number.Minor, number.Build)
        txtInfoTitle.Text = build
        myScrollView2.ChangeView(Nothing, 0, Nothing, True)
        Select Case x
            Case 0
                txtInfoText.Text = AboutInfo
            Case 1
                txtInfoText.Text = PrivacyInfo
            Case 2
                txtInfoText.Text = MIT_License
        End Select
        HamburgerButton.Visibility = Visibility.Collapsed
        gINFO.Visibility = Visibility.Visible
    End Sub

    ''' <summary>
    ''' Handles the Tapped event of the TELE control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    Private Sub TELE_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles TELE.Tapped
        SelectNetwork(3)
    End Sub

    ''' <summary>
    ''' Handles the Click event of the TOP control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    Private Async Sub TOP_Click(sender As Object, e As RoutedEventArgs) Handles TOP.Click
        Dim ScrollToTopString = "var int = setInterval(function(){window.scrollBy(0, -36); if( window.pageYOffset === 0 ) clearInterval(int); }, 0.1);"
        Select Case WhatSocialNetwork
            Case 0
                Await AllSocial0.InvokeScriptAsync("eval", New String() {ScrollToTopString})
            Case 1
                Await AllSocial2.InvokeScriptAsync("eval", New String() {ScrollToTopString})
            Case 2
                Await AllSocial3.InvokeScriptAsync("eval", New String() {ScrollToTopString})
            Case 3
                Await AllSocial4.InvokeScriptAsync("eval", New String() {ScrollToTopString})
        End Select
    End Sub

    ''' <summary>
    ''' Handles the Tapped event of the TW control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    Private Sub TW_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles TW.Tapped
        SelectNetwork(1)
    End Sub

    Private Sub AllSocial0_NewWindowRequested(sender As WebView, args As WebViewNewWindowRequestedEventArgs) Handles AllSocial0.NewWindowRequested
        If args.Uri.AbsoluteUri.Contains(".gif") OrElse args.Uri.AbsoluteUri.Contains("video") Then
            AllSocial0.Navigate(args.Uri)
            args.Handled = True
        End If
    End Sub

    Private Sub AllSocial0_NavigationFailed(sender As Object, e As WebViewNavigationFailedEventArgs) Handles AllSocial0.NavigationFailed
        Dim loader = New ResourceLoader()
        Dim noConnection As String = loader.GetString("noConnection")
        AllSocial0.NavigateToString(noConnection)
    End Sub

    Private Sub CloseInfo_Click(sender As Object, e As RoutedEventArgs) Handles CloseInfo.Click
        HamburgerButton.Visibility = Visibility.Visible
        gINFO.Visibility = Visibility.Collapsed
    End Sub

    Private Sub PRIVACY_Click(sender As Object, e As RoutedEventArgs) Handles PRIVACY.Click
        AboutApp(1)
    End Sub

    Private Sub APP_LICENSE_Click(sender As Object, e As RoutedEventArgs) Handles APP_LICENSE.Click
        AboutApp(2)
    End Sub
End Class