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
    using static Android.Widget.TabHost;
    using static Android.Views.View;
    using Android.Views;
    using com.xamarin.example.BitChute.Activities;

    //   using BackgroundStreamingAudio.Services;

    [Activity(Label = "@string/BitChute", MainLauncher = true, Icon = "@drawable/ic_launcher",
        ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
#pragma warning disable CS0618 // Type or member is obsolete
    public class MainActivity : TabActivity
#pragma warning restore CS0618 // Type or member is obsolete, << no u!
    {
        private void CreateTab(Type activityType, string tag, string label)
        {
            var intent = new Intent(this, activityType);
            intent.AddFlags(ActivityFlags.NewTask);

            var spec = TabHost.NewTabSpec(tag);
            spec.SetIndicator(label);
            spec.SetContent(intent);

            TabHost.AddTab(spec);
        }

        protected override void OnCreate(Bundle bundle)
        {
            //bundle
            base.OnCreate(bundle);

            //set the view
            SetContentView(Resource.Layout.Main);

            TabHost tabHost = FindViewById<TabHost>(Android.Resource.Id.TabHost);

            tabHost.Setup();

            tabHost.SetBackgroundColor(Android.Graphics.Color.Black);

            ActionBar.Hide();

            //specify tabs
            CreateTab(typeof(WhatsOnActivity), "whats_on", "What's On");
            CreateTab(typeof(SubsActivity), "speakers", "Subs");
            CreateTab(typeof(PlaylistActivity), "sessions", "Play-lists");
            CreateTab(typeof(MyChannelActivity), "my_schedule", "My Channel");
            CreateTab(typeof(SettingsActivity), "settings", "Settings");

            tabHost.TabWidget.GetChildAt(0).SetOnClickListener(new WhatsOnClickListener(tabHost));

            tabHost.TabWidget.GetChildAt(1).SetOnClickListener(new SubsClickListener(tabHost));

            tabHost.TabWidget.GetChildAt(2).SetOnClickListener(new PlaylistClickListener(tabHost));

            tabHost.TabWidget.GetChildAt(3).SetOnClickListener(new MyChannelClickListener(tabHost));

            tabHost.TabWidget.GetChildAt(4).SetOnClickListener(new SettingsClickListener(tabHost));


        }

    }

    //what's on
    [Activity]
    //this class should be an aggregate subscription feed
    public class WhatsOnActivity : Activity
    {
        public override void OnBackPressed()
        {
            WebView whatsOnWebView = FindViewById<WebView>(Resource.Id.webViewWhatsOn);

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
            whatsOnWebView.LoadUrl("https://www.bitchute.com/#listing-subscribed");
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









}
