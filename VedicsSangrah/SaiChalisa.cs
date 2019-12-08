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
    [Activity(Label = "साईं चालीसा")]
    public class SaiChalisa : Activity
    {
        WebView SaiChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SaiChalisa);
            SaiChalisaWebView = FindViewById<WebView>(Resource.Id.SaiChalisawebView1);
            SaiChalisaWebView.SetWebViewClient(new WebViewClient());
            SaiChalisaWebView.Settings.JavaScriptEnabled = true;
            SaiChalisaWebView.LoadUrl("file:///android_asset/SaiChalisa.htm");


        }
    }
}