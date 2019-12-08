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
    [Activity(Label = "रविवार व्रत कथा")]
    public class RavivarVratKatha : Activity
    {
        WebView RavivarVratKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RavivarVratKatha);
            RavivarVratKathaWebView = FindViewById<WebView>(Resource.Id.RavivarVratKathawebView1);
            RavivarVratKathaWebView.SetWebViewClient(new WebViewClient());
            RavivarVratKathaWebView.Settings.JavaScriptEnabled = true;
            RavivarVratKathaWebView.LoadUrl("file:///android_asset/katha/RavivaarVratKatha.htm");
        }
    }
}