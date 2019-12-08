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
    [Activity(Label = "शिव जी की आरती")]
    public class ShivJeeAarti : Activity
    {
        WebView ShivJeeAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShivJeeAarti);
            ShivJeeAartiWebView = FindViewById<WebView>(Resource.Id.ShivJeeAartiwebView1);
            ShivJeeAartiWebView.SetWebViewClient(new WebViewClient());
            ShivJeeAartiWebView.Settings.JavaScriptEnabled = true;
            ShivJeeAartiWebView.LoadUrl("file:///android_asset/aarti/ShivJeeAarti.htm");
        }
    }
}