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
    [Activity(Label = "श्री राम चालीसा")]
    public class RamChalisa : Activity
    {
        WebView RamChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RamChalisa);
            RamChalisaWebView = FindViewById<WebView>(Resource.Id.RamChalisawebView1);
            RamChalisaWebView.SetWebViewClient(new WebViewClient());
            RamChalisaWebView.Settings.JavaScriptEnabled = true;
            RamChalisaWebView.LoadUrl("file:///android_asset/RamChalisa.htm");
        }
    }
}