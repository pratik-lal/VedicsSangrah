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
    [Activity(Label = "श्री राम चंद्र जी की आरती")]
    public class RamchandraAarti : Activity
    {
        WebView RamchandraWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RamChandraAarti);
            RamchandraWebView = FindViewById<WebView>(Resource.Id.RamchandraAartiwebView1);
            RamchandraWebView.SetWebViewClient(new WebViewClient());
            RamchandraWebView.Settings.JavaScriptEnabled = true;
            RamchandraWebView.LoadUrl("file:///android_asset/aarti/RamchandraAarti.htm");
        }
    }
}