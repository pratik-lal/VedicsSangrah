using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace VedicsSangrah
{
    [Activity(Label = "शनि देव चालीसा")]
    public class ShreeShaniDevChalisa : Activity
    {
        WebView ShreeShaniChalisaWebWiew;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShreeShaniDevChalisa);
            ShreeShaniChalisaWebWiew = FindViewById<WebView>(Resource.Id.ShreeShaniDevChalisawebView1);
            ShreeShaniChalisaWebWiew.SetWebViewClient(new WebViewClient());
            ShreeShaniChalisaWebWiew.Settings.JavaScriptEnabled = true;
            ShreeShaniChalisaWebWiew.LoadUrl("file:///android_asset/ShreeShaniDevChalisa.htm");
        }
    }
}