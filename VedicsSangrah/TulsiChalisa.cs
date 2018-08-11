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
    [Activity(Label = "TulsiChalisa")]
    public class TulsiChalisa : Activity
    {
        WebView TulsiChalisaWebView;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.TulsiChalisa);
            TulsiChalisaWebView = FindViewById<WebView>(Resource.Id.TulsiChalisawebView1);
            TulsiChalisaWebView.SetWebViewClient(new WebViewClient());
            TulsiChalisaWebView.Settings.JavaScriptEnabled = true;
            TulsiChalisaWebView.LoadUrl("file:///android_asset/TulsiChalisa.htm");
        }
    }
}