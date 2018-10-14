using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace com.xamarin.example.BitChute
{
    public static class App
    {
        public static Func<Task<bool?>> HardwareBackPressed
        {
            get;
            set;
        }
        public static async Task<bool?> CallHardwareBackPressed()
        {
            Func<Task<bool?>> backPressed = HardwareBackPressed;
            if (backPressed != null)
            {
                return await backPressed();
            }
            
            return true;
        }
    }
}