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
    [Activity(Label = "शनिवार व्रत कथा")]
    public class ShanivarVratKatha : Activity
    {
        WebView ShanivarVratKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShanikvarVratKatha);
            ShanivarVratKathaWebView = FindViewById<WebView>(Resource.Id.ShanivarVratKathawebView1);
            ShanivarVratKathaWebView.SetWebViewClient(new WebViewClient());
            ShanivarVratKathaWebView.Settings.JavaScriptEnabled = true;
            ShanivarVratKathaWebView.LoadUrl("file:///android_asset/katha/ShanivaarVratKatha.htm");
        }
    }
}