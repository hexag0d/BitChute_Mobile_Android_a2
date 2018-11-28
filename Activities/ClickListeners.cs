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
    
    public class WhatsOnClickListener : Java.Lang.Object, IOnClickListener
    {
        TabHost tabHost;

        //this int will tell the click listener whether to reload the webview or pop 2 root
        static int tbC = 0;

        public WhatsOnClickListener(TabHost tabHost)
        {
            //tell the clicklistener which tabhost to use
            this.tabHost = tabHost;

        }
        //this class handles the click event
        public void OnClick(View v)
        {

            //declare the webview and tell our object where to find the XAML resource
            WebView webViewWhatsOn = tabHost.CurrentView.FindViewById<WebView>(Resource.Id.webViewWhatsOn);

            //...if the CurrentTab != 0 ... we won't fire the Reload() or LoadUrl() 
            //..without this logic, the app will crash because our WebViews 
            //.aren't set to an instance of an object
            if (tabHost.CurrentTab == 0)
            {
                //if tbC int is 0, we will reload the page
                if (tbC == 0)
                {
                    //tell whatsOnWebView to Reload
                    webViewWhatsOn.Reload();

                    //set the int to one so next time webview will pop to root
                    tbC = 1;

                   // tabHost.TabWidget.Visibility = Android.Views.ViewStates.Gone;
                }
                //else if the int is 1, we will pop to root on tab 0
                else if (tbC == 1)
                {
                    //tell whatsOnWebView to pop to root
                    webViewWhatsOn.LoadUrl(@"https://bitchute.com/#subscriptions");

                    //set the tbC int so that next time webview will reload
                    tbC = 0;
                }
            }
            else
            {
                //if our current tab isn't zero, we need to set CurrentTab to 0
                //this line is critical or our tabs won't work when not selected
                tabHost.CurrentTab = 0;
            }
        }
    }

    public class SubsClickListener : Java.Lang.Object, IOnClickListener
    {
        TabHost tabHost1;
        
        static int tbC = 0;

        public SubsClickListener(TabHost tabHost1)
        {
            this.tabHost1 = tabHost1;
        }

        public void OnClick(View v)
        {
            if (tabHost1.CurrentTab == 1)
            {

                WebView subWebView = tabHost1.CurrentView.FindViewById<WebView>(Resource.Id.webViewSubs);

                if (tbC == 0)
                {
                    subWebView.Reload();

                    tbC = 1;
                }

                else if (tbC == 1)
                {
                    subWebView.LoadUrl(@"https://bitchute.com/subscriptions/");

                    tbC = 0;
                }
            }
            else
            {
                tabHost1.CurrentTab = 1;
            }
        }
    }

    public class PlaylistClickListener : Java.Lang.Object, IOnClickListener
    {
        TabHost tabHost2;

        static int tbC = 0;

        public PlaylistClickListener(TabHost tabHost2)
        {
            this.tabHost2 = tabHost2;
        }
        public void OnClick(View v)
        {
            if (tabHost2.CurrentTab == 2)
            {

                WebView playlistWebView = tabHost2.CurrentView.FindViewById<WebView>(Resource.Id.webViewPlaylist);

                if (tbC == 0)
                {
                    playlistWebView.Reload();

                    tbC = 1;
                }

                else if (tbC == 1)
                {
                    playlistWebView.LoadUrl(@"https://bitchute.com/playlists/");

                    tbC = 0;
                }
            }
            else
            {
                tabHost2.CurrentTab = 2;
            }
        }
    }

    public class MyChannelClickListener : Java.Lang.Object, IOnClickListener
    {
        TabHost tabHost3;

        static int tbC = 0;

        public MyChannelClickListener(TabHost tabHost3)
        {
            this.tabHost3 = tabHost3;
        }
        public void OnClick(View v)
        {
            if (tabHost3.CurrentTab == 3)
            {

                WebView myChannelWebView = tabHost3.CurrentView.FindViewById<WebView>(Resource.Id.webViewMyChannel);

                if (tbC == 0)
                {
                    myChannelWebView.Reload();

                    tbC = 1;
                }

                else if (tbC == 1)
                {
                    myChannelWebView.LoadUrl(@"https://bitchute.com/profile/");

                    tbC = 0;
                }
            }
            else
            {
                tabHost3.CurrentTab = 3;
            }
        }
    }

    public class SettingsClickListener : Java.Lang.Object, IOnClickListener
    {
        TabHost tabHost4;

        static int tbC = 0;

        public SettingsClickListener(TabHost tabHost4)
        {
            this.tabHost4 = tabHost4;
        }
        public void OnClick(View v)
        {
            if (tabHost4.CurrentTab == 4)
            {

                WebView settingsWebView = tabHost4.CurrentView.FindViewById<WebView>(Resource.Id.webViewSettings);

                if (tbC == 0)
                {
                    settingsWebView.Reload();

                    tbC = 1;
                }

                else if (tbC == 1)
                {
                    settingsWebView.LoadUrl(@"https://bitchute.com/settings/");

                    tbC = 0;
                }
            }
            else
            {
                tabHost4.CurrentTab = 4;
            }
        }
    }
}