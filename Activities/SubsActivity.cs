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
using static Android.Views.View;

namespace com.xamarin.example.BitChute.Activities
{
    //subs
    [Activity]
    public class SubsActivity : Activity
    {
        public override void OnBackPressed()
        {
            WebView subWebView = FindViewById<WebView>(Resource.Id.webViewSubs);

            subWebView.GoBack();
        }

      //  public void SubsHideTabsClick()
       // {
            //TextView _textView169 = FindViewById<TextView>(Resource.Id.textView169);

            //   TabWidget tw = tabHost.TabWidget;

            // TextView tv1 = FindViewById<TextView>(Resource.Id.textView169);


            //_textView169.Click += delegate
          //  {
                // tw.Visibility = Android.Views.ViewStates.Gone;
           //     _textView169.Visibility = Android.Views.ViewStates.Gone;
          //  };
      //  }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //set the content view
            SetContentView(Resource.Layout.subs);

            //declare webview and tell our code where to find the XAML resource
            WebView subWebView = FindViewById<WebView>(Resource.Id.webViewSubs);

            //set the webview client
            subWebView.SetWebViewClient(new WebViewClient());
            //load the subscription url
            subWebView.LoadUrl("https://www.bitchute.com/subscriptions/");
            //enable javascript in our webview
            subWebView.Settings.JavaScriptEnabled = true;
            //zoom control on?  This should perhaps be disabled for consistency?
            //we will leave it on for now
            subWebView.Settings.BuiltInZoomControls = true;
            subWebView.Settings.SetSupportZoom(true);
            //scrollbarsdisabled
            // subWebView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            subWebView.ScrollbarFadingEnabled = false;
            
            //TextView test = FindViewById<TextView>(Resource.Id.);
        }
    }


}