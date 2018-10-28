using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace com.xamarin.example.BitChute.Activities
{
    //settings
    [Activity]
    public class SettingsActivity : Activity
    {

        public override void OnBackPressed()
        {
            WebView settingsWebView = FindViewById<WebView>(Resource.Id.webViewSettings);

            settingsWebView.GoBack();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.settings);

            //declare webview and tell our code where to find the XAML resource
            WebView settingsWebView = FindViewById<WebView>(Resource.Id.webViewSettings);

            //set the webview client
            settingsWebView.SetWebViewClient(new WebViewClient());
            //load the settings url ***this will need to interface with class to determineURL***
            settingsWebView.LoadUrl("https://www.bitchute.com/settings/");
            //enable javascript in our webview
            settingsWebView.Settings.JavaScriptEnabled = true;
            //zoom control on?  This should perhaps be disabled for consistency?
            //we will leave it on for now
            settingsWebView.Settings.BuiltInZoomControls = true;
            settingsWebView.Settings.SetSupportZoom(true);
            //scrollbarsdisabled
            // subWebView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            settingsWebView.ScrollbarFadingEnabled = false;
        }
    }
}