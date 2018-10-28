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
using com.xamarin.example.BitChute.Activities;

namespace com.xamarin.example.BitChute.Activities
{
    
    //Discover new content
    [Activity]
    //define class discover content
    public class DiscoverActivity : Activity
    {
        public override void OnBackPressed()
        {
            WebView discoverWebView = FindViewById<WebView>(Resource.Id.webViewDiscover);

            discoverWebView.GoBack();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.discover);

            //declare webview and tell our code where to find the XAML resource
            WebView discoverWebView = FindViewById<WebView>(Resource.Id.webViewDiscover);

            //discoverWebView.Settings.UserAgentString = "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.4) Gecko/20100101 Firefox/4.0";

            //set the webview client
            discoverWebView.SetWebViewClient(new WebViewClient());
            //load the subscription url
            discoverWebView.LoadUrl("https://www.bitchute.com/");
            //enable javascript in our webview
            discoverWebView.Settings.JavaScriptEnabled = true;
            //zoom control on?  This should perhaps be disabled for consistency?
            //we will leave it on for now
            discoverWebView.Settings.BuiltInZoomControls = true;
            discoverWebView.Settings.SetSupportZoom(true);
            //scrollbarsdisabled
            // subWebView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            discoverWebView.ScrollbarFadingEnabled = false;

        }
    }
}