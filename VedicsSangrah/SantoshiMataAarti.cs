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
    [Activity(Label = "SantoshiMataAarti")]
    public class SantoshiMataAarti : Activity
    {
        WebView SantoshiMataWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SantoshiMataAarti);
            SantoshiMataWebView = FindViewById<WebView>(Resource.Id.SantoshiMaaChalisawebView1);
            SantoshiMataWebView.SetWebViewClient(new WebViewClient());
            SantoshiMataWebView.Settings.JavaScriptEnabled = true;
            SantoshiMataWebView.LoadUrl("file:///android_asset/aarti/SantoshiMataAarti.htm");
        }
    }
}