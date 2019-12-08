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
    [Activity(Label = "शनि देव की आरती")]
    public class ShaniDevJeeAarti : Activity
    {
        WebView ShaniDevJeeAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShaniDevJeeAarti);
            ShaniDevJeeAartiWebView = FindViewById<WebView>(Resource.Id.ShaniDevJeeAartiwebView1);
            ShaniDevJeeAartiWebView.SetWebViewClient(new WebViewClient());
            ShaniDevJeeAartiWebView.Settings.JavaScriptEnabled = true;
            ShaniDevJeeAartiWebView.LoadUrl("file:///android_asset/aarti/ShaniDevJeeAarti.htm");
        }
    }
}