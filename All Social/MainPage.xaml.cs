using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Microsoft.VisualBasic;
using Windows.UI.Xaml.Navigation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Input;
using System;
using Windows.UI.Xaml.Controls;
using Windows.Phone.UI.Input;
using Windows.UI;
using Windows.UI.Core;

/// <summary>

/// An empty page that can be used on its own or navigated to within a Frame.

/// </summary>

/// <seealso cref="Windows.UI.Xaml.Controls.Page" />

/// <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector" />

/// <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector2" />
public sealed partial class MainPage : Page
{

    /// <summary>
    /// Backs the pressed.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="BackPressedEventArgs"/> instance containing the event data.</param>
    public async void BackPressed(object sender, BackPressedEventArgs e)
    {
        // Handles any Back button presses.
        e.Handled = true;
        switch (Vars.WhatSocialNetwork)
        {
            case 0:
                {
                    if (AllSocial0.CanGoBack)
                        AllSocial0.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }

            case 1:
                {
                    if (AllSocial1.CanGoBack)
                        AllSocial1.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }

            case 2:
                {
                    if (AllSocial2.CanGoBack)
                        AllSocial2.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }

            case 3:
                {
                    if (AllSocial3.CanGoBack)
                        AllSocial3.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }

            case 4:
                {
                    if (AllSocial4.CanGoBack)
                        AllSocial4.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }
        }
    }

    /// <summary>
    /// Handles the Click event of the ABOUT_APP control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void ABOUT_APP_Click(object sender, RoutedEventArgs e)
    {
        SIDEBAR.Visibility = Visibility.Collapsed;
        Vars.sidebar_open = false;
        Vars.AccessWhat = Vars.SocialNetworkAccessWhat[Vars.WhatSocialNetwork];
        Vars.Company = Vars.SocialNetworkCompany[Vars.WhatSocialNetwork];
        Vars.AboutInfo = Vars.AppName + " is a UWP app for Windows 10 Mobile to allow the user to access " + Vars.AccessWhat + " from a single portal." + Constants.vbCrLf + Constants.vbCrLf + "Small memory footprint, open source, and forever free." + Constants.vbCrLf + Constants.vbCrLf + "This app is NOT associated in ANY way with " + Vars.Company + Constants.vbCrLf + Constants.vbCrLf + "----------" + Constants.vbCrLf + Constants.vbCrLf + "This UWP app is currently in a BETA test mode." + Constants.vbCrLf + Constants.vbCrLf + "Things MAY change in future versions.";
        SettingsSetup();
    }

    /// <summary>
    /// Handles the GotFocus event of the AllSocial0 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void AllSocial0_GotFocus(object sender, RoutedEventArgs e)
    {
        SIDEBAR.Visibility = Visibility.Collapsed;
        Vars.sidebar_open = false;
    }

    /// <summary>
    /// Handles the LoadCompleted event of the AllSocial0 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    private async void AllSocial0_LoadCompleted(object sender, NavigationEventArgs e)
    {
        string cssToApply = "";
        cssToApply += "#header {position: fixed; z-index: 12; top: 0px;} #root {padding-top: 44px;} .item.more {position:fixed; bottom: 0px; text-align: center !important;}";
        var h = ApplicationView.GetForCurrentView().VisibleBounds.Height - 44;
        float density = DisplayInformation.GetForCurrentView().LogicalDpi;
        int barHeight = System.Convert.ToInt32((h / density));
        cssToApply += ".flyout {max-height:" + barHeight + "px; overflow-y:scroll;}";
        cssToApply += @"#m_newsfeed_stream article[data-ft*=""\\""ei\\"":\\""""] {display:none !important;}";
        await AllSocial0.InvokeScriptAsync("eval",
        {
            "javascript:function addStyleString(str) { var node = document.createElement('style'); node.innerHTML = " + "str; document.body.appendChild(node); } addStyleString('" + cssToApply + "');"
        });
        iconRotation.Stop();
    }

    /// <summary>
    /// Alls the social0 loading.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="args">The arguments.</param>
    private void AllSocial0_Loading(FrameworkElement sender, object args)
    {
        iconRotation.Begin();
    }

    /// <summary>
    /// Handles the GotFocus event of the AllSocial1 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void AllSocial1_GotFocus(object sender, RoutedEventArgs e)
    {
        SIDEBAR.Visibility = Visibility.Collapsed;
        Vars.sidebar_open = false;
    }

    /// <summary>
    /// Handles the LoadCompleted event of the AllSocial1 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    private async void AllSocial1_LoadCompleted(object sender, NavigationEventArgs e)
    {
        string cssToApply = "";
        cssToApply += "#header {position: fixed; z-index: 12; top: 0px;} #root {padding-top: 44px;} .item.more {position:fixed; bottom: 0px; text-align: center !important;}";
        var h = ApplicationView.GetForCurrentView().VisibleBounds.Height - 44;
        float density = DisplayInformation.GetForCurrentView().LogicalDpi;
        int barHeight = System.Convert.ToInt32((h / density));
        cssToApply += ".flyout {max-height:" + barHeight + "px; overflow-y:scroll;}";
        cssToApply += @"#m_newsfeed_stream article[data-ft*=""\\""ei\\"":\\""""] {display:none !important;}";
        await AllSocial1.InvokeScriptAsync("eval",
        {
            "javascript:function addStyleString(str) { var node = document.createElement('style'); node.innerHTML = " + "str; document.body.appendChild(node); } addStyleString('" + cssToApply + "');"
        });
        iconRotation.Stop();
    }

    /// <summary>
    /// Handles the GotFocus event of the AllSocial2 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void AllSocial2_GotFocus(object sender, RoutedEventArgs e)
    {
        SIDEBAR.Visibility = Visibility.Collapsed;
        Vars.sidebar_open = false;
    }

    /// <summary>
    /// Handles the LoadCompleted event of the AllSocial2 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    private void AllSocial2_LoadCompleted(object sender, NavigationEventArgs e)
    {
        iconRotation.Stop();
    }

    /// <summary>
    /// Alls the social2 loading.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="args">The arguments.</param>
    private void AllSocial2_Loading(FrameworkElement sender, object args)
    {
        iconRotation.Begin();
    }

    /// <summary>
    /// Handles the GotFocus event of the AllSocial3 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void AllSocial3_GotFocus(object sender, RoutedEventArgs e)
    {
        SIDEBAR.Visibility = Visibility.Collapsed;
        Vars.sidebar_open = false;
    }

    /// <summary>
    /// Handles the LoadCompleted event of the AllSocial3 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    private async void AllSocial3_LoadCompleted(object sender, NavigationEventArgs e)
    {
        string cssToApply = "";
        cssToApply += "#header {position: fixed; z-index: 12; top: 0px;} #root {padding-top: 44px;} .item.more {position:fixed; bottom: 0px; text-align: center !important;}";
        var h = ApplicationView.GetForCurrentView().VisibleBounds.Height - 44;
        float density = DisplayInformation.GetForCurrentView().LogicalDpi;
        int barHeight = System.Convert.ToInt32((h / density));
        cssToApply += ".flyout {max-height:" + barHeight + "px; overflow-y:scroll;}";
        cssToApply += @"#m_newsfeed_stream article[data-ft*=""\\""ei\\"":\\""""] {display:none !important;}";
        await AllSocial3.InvokeScriptAsync("eval",
        {
            "javascript:function addStyleString(str) { var node = document.createElement('style'); node.innerHTML = " + "str; document.body.appendChild(node); } addStyleString('" + cssToApply + "');"
        });
        iconRotation.Stop();
    }

    /// <summary>
    /// Alls the social3 loading.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="args">The arguments.</param>
    private void AllSocial3_Loading(FrameworkElement sender, object args)
    {
        iconRotation.Begin();
    }

    /// <summary>
    /// Handles the GotFocus event of the AllSocial4 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void AllSocial4_GotFocus(object sender, RoutedEventArgs e)
    {
        SIDEBAR.Visibility = Visibility.Collapsed;
        Vars.sidebar_open = false;
    }

    /// <summary>
    /// Handles the LoadCompleted event of the AllSocial4 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="NavigationEventArgs"/> instance containing the event data.</param>
    private void AllSocial4_LoadCompleted(object sender, NavigationEventArgs e)
    {
        iconRotation.Stop();
    }

    /// <summary>
    /// Handles the Click event of the BACK control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private async void BACK_Click(object sender, RoutedEventArgs e)
    {
        switch (Vars.WhatSocialNetwork)
        {
            case 0:
                {
                    if (AllSocial0.CanGoBack)
                        AllSocial0.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }

            case 1:
                {
                    if (AllSocial1.CanGoBack)
                        AllSocial1.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }

            case 2:
                {
                    if (AllSocial2.CanGoBack)
                        AllSocial2.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }

            case 3:
                {
                    if (AllSocial3.CanGoBack)
                        AllSocial3.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }

            case 4:
                {
                    if (AllSocial4.CanGoBack)
                        AllSocial4.GoBack();
                    else
                        await Vars.displayMessageAsync("Quit " + Vars.AppName, "Are you sure you want to quit the app?", "");
                    break;
                }
        }
    }

    /// <summary>
    /// Clears the social network.
    /// </summary>
    private void ClearSocialNetwork()
    {
        switch (Vars.WhatSocialNetwork)
        {
            case 0:
                {
                    FaceBook.Visibility = Visibility.Collapsed;
                    FaceBookMess.Visibility = Visibility.Visible;
                    Twitter.Visibility = Visibility.Visible;
                    Instagram.Visibility = Visibility.Visible;
                    Telegram.Visibility = Visibility.Visible;
                    // 
                    AllSocial0.Visibility = Visibility.Visible;
                    AllSocial1.Visibility = Visibility.Collapsed;
                    AllSocial2.Visibility = Visibility.Collapsed;
                    AllSocial3.Visibility = Visibility.Collapsed;
                    AllSocial4.Visibility = Visibility.Collapsed;
                    break;
                }

            case 1:
                {
                    FaceBook.Visibility = Visibility.Visible;
                    FaceBookMess.Visibility = Visibility.Collapsed;
                    Twitter.Visibility = Visibility.Visible;
                    Instagram.Visibility = Visibility.Visible;
                    Telegram.Visibility = Visibility.Visible;
                    // 
                    AllSocial0.Visibility = Visibility.Collapsed;
                    AllSocial1.Visibility = Visibility.Visible;
                    AllSocial2.Visibility = Visibility.Collapsed;
                    AllSocial3.Visibility = Visibility.Collapsed;
                    AllSocial4.Visibility = Visibility.Collapsed;
                    break;
                }

            case 2:
                {
                    FaceBook.Visibility = Visibility.Visible;
                    FaceBookMess.Visibility = Visibility.Visible;
                    Twitter.Visibility = Visibility.Collapsed;
                    Instagram.Visibility = Visibility.Visible;
                    Telegram.Visibility = Visibility.Visible;
                    // 
                    AllSocial0.Visibility = Visibility.Collapsed;
                    AllSocial1.Visibility = Visibility.Collapsed;
                    AllSocial2.Visibility = Visibility.Visible;
                    AllSocial3.Visibility = Visibility.Collapsed;
                    AllSocial4.Visibility = Visibility.Collapsed;
                    break;
                }

            case 3:
                {
                    FaceBook.Visibility = Visibility.Visible;
                    FaceBookMess.Visibility = Visibility.Visible;
                    Twitter.Visibility = Visibility.Visible;
                    Instagram.Visibility = Visibility.Collapsed;
                    Telegram.Visibility = Visibility.Visible;
                    // 
                    AllSocial0.Visibility = Visibility.Collapsed;
                    AllSocial1.Visibility = Visibility.Collapsed;
                    AllSocial2.Visibility = Visibility.Collapsed;
                    AllSocial3.Visibility = Visibility.Visible;
                    AllSocial4.Visibility = Visibility.Collapsed;
                    break;
                }

            case 4:
                {
                    FaceBook.Visibility = Visibility.Visible;
                    FaceBookMess.Visibility = Visibility.Visible;
                    Twitter.Visibility = Visibility.Visible;
                    Instagram.Visibility = Visibility.Visible;
                    Telegram.Visibility = Visibility.Collapsed;
                    // 
                    AllSocial0.Visibility = Visibility.Collapsed;
                    AllSocial1.Visibility = Visibility.Collapsed;
                    AllSocial2.Visibility = Visibility.Collapsed;
                    AllSocial3.Visibility = Visibility.Collapsed;
                    AllSocial4.Visibility = Visibility.Visible;
                    break;
                }
        }
    }

    /// <summary>
    /// Handles the Click event of the CloseGrid control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void CloseGrid_Click(object sender, RoutedEventArgs e)
    {
        Info.Visibility = Visibility.Collapsed;
    }

    /// <summary>
    /// Handles the Click event of the EXIT_APP control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void EXIT_APP_Click(object sender, RoutedEventArgs e)
    {
        SIDEBAR.Visibility = Visibility.Collapsed;
        Application.Current.Exit();
    }

    /// <summary>
    /// Handles the Tapped event of the FB control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    private void FB_Tapped(object sender, TappedRoutedEventArgs e)
    {
        SelectNetwork(0);
    }

    /// <summary>
    /// Handles the Tapped event of the FBMESS control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    private void FBMESS_Tapped(object sender, TappedRoutedEventArgs e)
    {
        SelectNetwork(1);
    }

    /// <summary>
    /// Goes the home.
    /// </summary>
    private void Go_Home()
    {
        iconRotation.Begin();
        Uri mwv; // Contains the source URL for Facebook Touch
        mwv = new Uri(Vars.MyWebViewSource);
        switch (Vars.WhatSocialNetwork)
        {
            case 0:
                {
                    AllSocial0.Navigate(new Uri(Vars.MyWebViewSource));
                    break;
                }

            case 1:
                {
                    AllSocial1.Navigate(new Uri(Vars.MyWebViewSource));
                    break;
                }

            case 2:
                {
                    AllSocial2.Navigate(new Uri(Vars.MyWebViewSource));
                    break;
                }

            case 3:
                {
                    AllSocial3.Navigate(new Uri(Vars.MyWebViewSource));
                    break;
                }

            case 4:
                {
                    AllSocial4.Navigate(new Uri(Vars.MyWebViewSource));
                    break;
                }
        }
    }

    /// <summary>
    /// Handles the Tapped event of the HamburgerButton control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    private void HamburgerButton_Tapped(object sender, TappedRoutedEventArgs e)
    {
        if (Vars.sidebar_open)
        {
            SIDEBAR.Visibility = Visibility.Collapsed;
            Vars.sidebar_open = false;
        }
        else
        {
            SIDEBAR.Visibility = Visibility.Visible;
            Vars.sidebar_open = true;
        }
    }

    /// <summary>
    /// Handles the Click event of the HOME control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void HOME_Click(object sender, RoutedEventArgs e)
    {
        Go_Home();
    }

    /// <summary>
    /// Handles the Click event of the hyperDev control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private async void hyperDev_Click(object sender, RoutedEventArgs e)
    {
        var logoURL = new Uri("https://github.com/CelestialDoom/All-Social");
        await Windows.System.Launcher.LaunchUriAsync(logoURL);
    }

    /// <summary>
    /// Handles the Click event of the hyperLogo control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private async void hyperLogo_Click(object sender, RoutedEventArgs e)
    {
        var logoURL = new Uri("https://s19.postimg.cc/kfvybyyub/All_Social_v1_inv.png");
        await Windows.System.Launcher.LaunchUriAsync(logoURL);
    }

    /// <summary>
    /// Handles the Tapped event of the INST control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    private void INST_Tapped(object sender, TappedRoutedEventArgs e)
    {
        SelectNetwork(3);
    }

    /// <summary>
    /// Handles the Loaded event of the MainPage control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private void MainPage_Loaded(object sender, RoutedEventArgs e)
    {
        HardwareButtons.BackPressed += BackPressed;
        SIDEBAR.Visibility = Visibility.Collapsed;
        Info.Visibility = Visibility.Collapsed;
        iconRotation.Begin();
        SystemNavigationManager.GetForCurrentView().BackRequested += (s, a) =>
        {
            switch (Vars.WhatSocialNetwork)
            {
                case 0:
                    {
                        if (AllSocial0.CanGoBack)
                        {
                            AllSocial0.GoBack();
                            a.Handled = true;
                        }

                        break;
                    }

                case 1:
                    {
                        if (AllSocial1.CanGoBack)
                        {
                            AllSocial2.GoBack();
                            a.Handled = true;
                        }

                        break;
                    }

                case 2:
                    {
                        if (AllSocial2.CanGoBack)
                        {
                            AllSocial2.GoBack();
                            a.Handled = true;
                        }

                        break;
                    }

                case 3:
                    {
                        if (AllSocial3.CanGoBack)
                        {
                            AllSocial3.GoBack();
                            a.Handled = true;
                        }

                        break;
                    }

                case 4:
                    {
                        if (AllSocial4.CanGoBack)
                        {
                            AllSocial4.GoBack();
                            a.Handled = true;
                        }

                        break;
                    }
            }
        };
        SelectNetwork(0);
    }

    /// <summary>
    /// Handles the Click event of the REFRESH control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
    private void REFRESH_Click(object sender, RoutedEventArgs e)
    {
        iconRotation.Begin();
        switch (Vars.WhatSocialNetwork)
        {
            case 0:
                {
                    AllSocial0.Refresh();
                    break;
                }

            case 1:
                {
                    AllSocial1.Refresh();
                    break;
                }

            case 2:
                {
                    AllSocial2.Refresh();
                    break;
                }

            case 3:
                {
                    AllSocial3.Refresh();
                    break;
                }

            case 4:
                {
                    AllSocial4.Refresh();
                    break;
                }
        }
    }

    /// <summary>
    /// Selects the network.
    /// </summary>
    /// <param name="x">The x.</param>
    private void SelectNetwork(int x)
    {
        SIDEBAR.Visibility = Visibility.Collapsed;
        Vars.sidebar_open = false;
        SIDEBAR.Background = new SolidColorBrush(Color.FromArgb(255, Vars.RED_HEX[x], Vars.GREEN_HEX[x], Vars.BLUE_HEX[x]));
        CB.Background = new SolidColorBrush(Color.FromArgb(255, Vars.RED_HEX[x], Vars.GREEN_HEX[x], Vars.BLUE_HEX[x]));
        Vars.MyWebViewSource = Vars.SocialNetworkURL[x];
        Vars.WhatSocialNetwork = x;
        iconRotation.Begin();
        ClearSocialNetwork();
        Go_Home();
    }

    /// <summary>
    /// Settingses the setup.
    /// </summary>
    private void SettingsSetup()
    {
        PackageVersion number = Package.Current.Id.Version;
        PivotSettingsAbout.SelectedIndex = 0;
        version.Text = string.Format(" {0}.{1}.{2}" + Constants.vbCrLf, number.Major, number.Minor, number.Build);
        App_Name.Text = Vars.AppName;
        privacy.Text = Vars.PrivacyInfo;
        about.Text = Vars.AboutInfo;
        license.Text = Vars.MIT_License;
        ScrollView.ChangeView(default(Double?), 0, default(Single?), true);
        myScrollView.ChangeView(default(Double?), 0, default(Single?), true);
        myScrollViewLicense.ChangeView(default(Double?), 0, default(Single?), true);
        Info.Background = new SolidColorBrush(Color.FromArgb(255, Vars.RED_HEX[Vars.WhatSocialNetwork], Vars.GREEN_HEX[Vars.WhatSocialNetwork], Vars.BLUE_HEX[Vars.WhatSocialNetwork]));
        Info.Visibility = Visibility.Visible;
    }

    /// <summary>
    /// Handles the Tapped event of the TELE control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    private void TELE_Tapped(object sender, TappedRoutedEventArgs e)
    {
        SelectNetwork(4);
    }

    /// <summary>
    /// Handles the Click event of the TOP control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
    private async void TOP_Click(object sender, RoutedEventArgs e)
    {
        var ScrollToTopString = "var int = setInterval(function(){window.scrollBy(0, -36); if( window.pageYOffset === 0 ) clearInterval(int); }, 0.1);";
        switch (Vars.WhatSocialNetwork)
        {
            case 0:
                {
                    await AllSocial0.InvokeScriptAsync("eval", new string[] { ScrollToTopString });
                    break;
                }

            case 1:
                {
                    await AllSocial1.InvokeScriptAsync("eval", new string[] { ScrollToTopString });
                    break;
                }

            case 2:
                {
                    await AllSocial2.InvokeScriptAsync("eval", new string[] { ScrollToTopString });
                    break;
                }

            case 3:
                {
                    await AllSocial3.InvokeScriptAsync("eval", new string[] { ScrollToTopString });
                    break;
                }

            case 4:
                {
                    await AllSocial4.InvokeScriptAsync("eval", new string[] { ScrollToTopString });
                    break;
                }
        }
    }

    /// <summary>
    /// Handles the Tapped event of the TW control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="TappedRoutedEventArgs"/> instance containing the event data.</param>
    private void TW_Tapped(object sender, TappedRoutedEventArgs e)
    {
        SelectNetwork(2);
    }
}
