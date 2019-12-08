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
    [Activity(Label = "संतोषी माँ चालीसा")]
    public class SantoshiMaaChalisa : Activity
    {
        WebView SantoshiMaaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SantoshiMaaChalisa);
            SantoshiMaaChalisaWebView = FindViewById<WebView>(Resource.Id.SantoshiMaaChalisawebView1);
            SantoshiMaaChalisaWebView.SetWebViewClient(new WebViewClient());
            SantoshiMaaChalisaWebView.Settings.JavaScriptEnabled = true;
            SantoshiMaaChalisaWebView.LoadUrl("file:///android_asset/SantoshiMaaChalisa.htm");
        }
    }
}