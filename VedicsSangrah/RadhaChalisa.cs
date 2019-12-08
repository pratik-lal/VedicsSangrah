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
    [Activity(Label = "राधा चालीसा")]
    public class RadhaChalisa : Activity
    {
        WebView RadhaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RadhaChalisa);
            RadhaChalisaWebView = FindViewById<WebView>(Resource.Id.RadhaChalisawebView1);
            RadhaChalisaWebView.SetWebViewClient(new WebViewClient());
            RadhaChalisaWebView.Settings.JavaScriptEnabled = true;
            RadhaChalisaWebView.LoadUrl("file:///android_asset/RadhaChalisa.htm");

        }
    }
}