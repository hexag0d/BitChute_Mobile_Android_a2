/* App by:
 

.__                                             .___
|  |__   ____ ___  ________     ____   ____   __| _/
|  |  \_/ __ \\  \/  /\__  \   / ___\ /  _ \ / __ | 
|   Y  \  ___/ >    <  / __ \_/ /_/  >  <_> ) /_/ | 
|___|  /\___  >__/\_ \(____  /\___  / \____/\____ | 
     \/     \/      \/     \//_____/             \/ 

bitchute.com/channel/hexagod
soundcloud.com/vybemasterz

twitter @vybeypantelonez
minds @hexagod
steemit @vybemasterz
gab.ai @hexagod
 
 */

namespace com.xamarin.example.BitChute
{
    using System;
    using System.Threading.Tasks;
    using Android.App;
    using Android.Content;
    using Android.Graphics.Drawables;
    using Android.OS;
    using Android.Widget;
    using Android.Webkit;

    //   using Xamarin.Forms.PlatformConfiguration;
    //   using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
    

    [Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/ic_launcher", 
        ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
#pragma warning disable CS0618 // Type or member is obsolete
    public class MainActivity : TabActivity
#pragma warning restore CS0618 // Type or member is obsolete
    {
        //CreateTab classs
        private void CreateTab(Type activityType, string tag, string label, int drawableId)
        {
            var intent = new Intent(this, activityType);
            intent.AddFlags(ActivityFlags.NewTask);

            var spec = TabHost.NewTabSpec(tag);
            var drawableIcon = Resources.GetDrawable(drawableId);
            spec.SetIndicator(label, drawableIcon);
            spec.SetContent(intent);

            TabHost.AddTab(spec);
        }
        //OnCreate class
        protected override void OnCreate(Bundle bundle)
        {
            //bundle
            base.OnCreate(bundle);

            //set the view
            SetContentView(Resource.Layout.Main);

            //declare an instance of tabHost and find the resource
            TabHost tabHost = FindViewById<TabHost>(Android.Resource.Id.TabHost);

            //setup the tabHost
            tabHost.Setup();

            //set the background color of our tabs to black
            tabHost.SetBackgroundColor(Android.Graphics.Color.Black);

            //hide the actionbar
            ActionBar.Hide();

            //specify tabs
            CreateTab(typeof(WhatsOnActivity), "whats_on", "What's On", Resource.Drawable.ic_tab_whats_on);
            CreateTab(typeof(SpeakersActivity), "speakers", "Subs", Resource.Drawable.ic_tab_speakers);
            CreateTab(typeof(SessionsActivity), "sessions", "Discover", Resource.Drawable.ic_tab_sessions);
            CreateTab(typeof(MyScheduleActivity), "my_schedule", "My Channel", Resource.Drawable.ic_tab_my_schedule);
            CreateTab(typeof(SettingsActivity), "settings", "Settings", Resource.Drawable.ic_tab_settings);


        }



    }



    //My Channel
    [Activity]
    public class MyScheduleActivity : Activity
    {


        //override the hardware back button event
        public override void OnBackPressed()
        {
            //declare our webview and tell the button where to find it
            WebView myChannelWebView = FindViewById<WebView>(Resource.Id.webViewMyChannel);
            //tell webview to goback
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

    //Discover new content
    [Activity]
    //define class discover content
    public class SessionsActivity : Activity
    {
        //override the hardware back button event
        public override void OnBackPressed()
        {
            //declare our webview and tell the button where to find it
            WebView discoverWebView = FindViewById<WebView>(Resource.Id.webViewDiscover);
            //tell webview to goback
            discoverWebView.GoBack();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            SetContentView(Resource.Layout.discover);

            //declare webview and tell our code where to find the XAML resource
            WebView discoverWebView = FindViewById<WebView>(Resource.Id.webViewDiscover);

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
    //subs
    [Activity]
    public class SpeakersActivity : Activity
    {
        //override the hardware back button event
        public override void OnBackPressed()
        {
            //declare our webview and tell the button where to find it
            WebView subWebView = FindViewById<WebView>(Resource.Id.webViewSubs);
            //tell webview to goback
            subWebView.GoBack();
        }


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

        }
    }
    //what's on
    [Activity]
    //this class should be an aggregate subscription feed
    public class WhatsOnActivity : Activity
    {
        //override the hardware back button event
        public override void OnBackPressed()
        {
            //declare our webview and tell the button where to find it
            WebView whatsOnWebView = FindViewById<WebView>(Resource.Id.webViewWhatsOn);
            //tell webview to goback
            whatsOnWebView.GoBack();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.whatsOn);

            //declare webview and tell our code where to find the XAML resource
            WebView whatsOnWebView = FindViewById<WebView>(Resource.Id.webViewWhatsOn);


            whatsOnWebView.SetBackgroundColor(Android.Graphics.Color.Green);
            //set the webview client
            whatsOnWebView.SetWebViewClient(new WebViewClient());
            //load the 'whats on' url, will need webscript for curated subscribed feed
            whatsOnWebView.LoadUrl("https://www.bitchute.com/");
            //enable javascript in our webview
            whatsOnWebView.Settings.JavaScriptEnabled = true;
            //zoom control on?  This should perhaps be disabled for consistency?
            //we will leave it on for now
            whatsOnWebView.Settings.BuiltInZoomControls = true;
            whatsOnWebView.Settings.SetSupportZoom(true);
            //scrollbarsdisabled
            // subWebView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            whatsOnWebView.ScrollbarFadingEnabled = false;
        }
    }
    //settings
   [Activity]
    public class SettingsActivity : Activity
    {
        //override the hardware back button event
        public override void OnBackPressed()
        {
            //declare our webview and tell the button where to find it
            WebView settingsWebView = FindViewById<WebView>(Resource.Id.webViewSettings);
            //tell webview to goback
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
