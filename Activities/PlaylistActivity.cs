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
    //playlist 
    [Activity]
    //define class playlist content
    public class PlaylistActivity : Activity
    {
        public override void OnBackPressed()
        {
            WebView playlistWebView = FindViewById<WebView>(Resource.Id.webViewPlaylist);

            playlistWebView.GoBack();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.discover);

            //declare webview and tell our code where to find the XAML resource
            WebView playlistWebView = FindViewById<WebView>(Resource.Id.webViewPlaylist);

            //playlistWebView.Settings.UserAgentString = "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.4) Gecko/20100101 Firefox/4.0";

            //set the webview client
            playlistWebView.SetWebViewClient(new WebViewClient());
            //load the subscription url
            playlistWebView.LoadUrl("https://www.bitchute.com/playlists/");
            //enable javascript in our webview
            playlistWebView.Settings.JavaScriptEnabled = true;
            //zoom control on?  This should perhaps be disabled for consistency?
            //we will leave it on for now
            playlistWebView.Settings.BuiltInZoomControls = true;
            playlistWebView.Settings.SetSupportZoom(true);
            //scrollbarsdisabled
            // subWebView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            playlistWebView.ScrollbarFadingEnabled = false;

        }
    }
}