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
    [Activity(Label = "सोमवार व्रत कथा")]
    public class SomvarVratKatha : Activity
    {
        WebView SomvarVratKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SomvarVratKatha);
            SomvarVratKathaWebView = FindViewById<WebView>(Resource.Id.SomvarVratKathawebView1);
            SomvarVratKathaWebView.SetWebViewClient(new WebViewClient());
            SomvarVratKathaWebView.Settings.JavaScriptEnabled = true;
            SomvarVratKathaWebView.LoadUrl("file:///android_asset/katha/SomvaarVratKatha.htm");

        }
    }
}