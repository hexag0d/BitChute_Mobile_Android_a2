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
    //My Channel
    [Activity]
    public class MyChannelActivity : Activity
    {
        public override void OnBackPressed()
        {
            WebView myChannelWebView = FindViewById<WebView>(Resource.Id.webViewMyChannel);

            myChannelWebView.GoBack();
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.myChannel);


            //declare webview and tell our code where to find the XAML resource
            WebView myChannelWebView = FindViewById<WebView>(Resource.Id.webViewMyChannel);

            //set the webview client
            myChannelWebView.SetWebViewClient(new WebViewClient());
            //load the mychannel url
            myChannelWebView.LoadUrl("https://www.bitchute.com/profile/");
            //enable javascript in our webview
            myChannelWebView.Settings.JavaScriptEnabled = true;
            //zoom control on?  This should perhaps be disabled for consistency?
            //we will leave it on for now
            myChannelWebView.Settings.BuiltInZoomControls = true;
            myChannelWebView.Settings.SetSupportZoom(true);
            //scrollbarsdisabled
            // subWebView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            myChannelWebView.ScrollbarFadingEnabled = false;


        }
    }
}