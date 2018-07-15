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
    [Activity(Label = "BhairavChalisa")]
    public class BhairavChalisa : Activity
    {
        WebView BhairavChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.BhairavChalisa);
            BhairavChalisaWebView = FindViewById<WebView>(Resource.Id.BhairavChalisawebView1);
            BhairavChalisaWebView.SetWebViewClient(new WebViewClient());
            BhairavChalisaWebView.Settings.JavaScriptEnabled = true;
            BhairavChalisaWebView.LoadUrl("file:///android_asset/BhairavChalisa.htm");
        }
    }
}