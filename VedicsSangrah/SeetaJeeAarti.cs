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
    [Activity(Label = "SeetaJeeAarti")]
    public class SeetaJeeAarti : Activity
    {
        WebView SeetaJeeAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SeetaJeeAarti);
            SeetaJeeAartiWebView = FindViewById<WebView>(Resource.Id.SeetaJeeAartiwebView1);
            SeetaJeeAartiWebView.SetWebViewClient(new WebViewClient());
            SeetaJeeAartiWebView.Settings.JavaScriptEnabled = true;
            SeetaJeeAartiWebView.LoadUrl("file:///android_asset/aarti/SeetaJeeAarti.htm");
        }
    }
}