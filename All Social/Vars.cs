using Windows.ApplicationModel;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Microsoft.VisualBasic;
using System;
using Windows.UI.Popups;

static class Vars
{
    public static string[] SocialNetworkAccessWhat = new[] { "your Facebook account", "your Facebook account", "your Twitter account", "your Instagram account" };
    // This stores which account you will access

    public static string[] SocialNetworkCompany = new[] { "Facebook, Inc.", "Facebook, Inc.", "Twitter, Inc.", "Instagram, Inc.", "Telegram Messenger LLP" };
    // This stores the company name

    public static bool sidebar_open = false;
    // Determines whether, or not, the sidebar is open

    public static string AppName = Package.Current.DisplayName;
    // This stores the application name

    public static string AccessWhat = "their Amazon account";
    // This will store the SolcialNetworkAccessWhat

    public static string Company = "Amazon, Inc.";
    // This will store the SolcialNetworkCompany

    public static string PrivacyInfo = AppName + " Privacy" + Constants.vbCrLf + Constants.vbCrLf + "----------" + Constants.vbCrLf + Constants.vbCrLf + "No personal, or private, information of either you, or your device, is collected by this app." + Constants.vbCrLf + Constants.vbCrLf + "Neither is ANY information transmitted by this app.";
    // This stores the applications' privacy information

    public static string AboutInfo = AppName + " is a UWP app for Windows 10 Mobile to allow the user to access " + AccessWhat + " from a single portal." + Constants.vbCrLf + "Small memory footprint, open source, and forever free." + Constants.vbCrLf + "This app is NOT associated in ANY way with " + Company + Constants.vbCrLf + "----------" + Constants.vbCrLf + Constants.vbCrLf + "This UWP app is currently in a BETA test mode." + Constants.vbCrLf + "Things MAY change in future versions.";
    // This stores information about the application

    public static string[] SocialNetworkURL = new[] { "https://touch.facebook.com/home.php?sk=h_chr", "http://m.me/", "https://mobile.twitter.com/", "https://www.instagram.com/", "https://web.telegram.org/" };
    // This stores the URL of the social network (optimized for mobile... I hope!)

    public static string[] RED_HEX = new[] { "59", "59", "29", "245", "86" };
    // Red colour in hex

    public static string[] GREEN_HEX = new[] { "89", "89", "161", "96", "130" };
    // Green colour in hex

    public static string[] BLUE_HEX = new[] { "152", "152", "242", "64", "163" };
    // Blue colour in hex

    public static int WhatSocialNetwork = 0;
    // Determines what network is selected

    public static string MyWebViewSource;
    // Stores the selected URL for the social network selected (see above)

    public static string MIT_License = "The MIT License (MIT)" + Constants.vbCrLf + Constants.vbCrLf + "Copyright (c) 2015 .NET Foundation" + Constants.vbCrLf + Constants.vbCrLf + "Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the \"Software\"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:" + Constants.vbCrLf + Constants.vbCrLf + "The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software." + Constants.vbCrLf + Constants.vbCrLf + "THE SOFTWARE IS PROVIDED \"As Is\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF ERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.";
    // The MIT License (d'oh!)

    public async static Task displayMessageAsync(string title, string content, string dialogType)
    {
        var messageDialog = new MessageDialog(content, title);
        if (dialogType == "notification")
        {
        }
        else
        {
            messageDialog.Commands.Add(new UICommand("Yes", null));
            messageDialog.Commands.Add(new UICommand("No", null));
            messageDialog.DefaultCommandIndex = 0;
        }
        messageDialog.CancelCommandIndex = 1;
        var cmdResult = await messageDialog.ShowAsync();
        if (cmdResult.Label == "Yes")
            Application.Current.Exit();
    }
}
