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
    [Activity(Label = "ब्रह्म चालीसा")]
    public class BramhaChalisa : Activity
    {
        //Add a new webview here
        WebView BramhaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.BramhaChalisa);
            BramhaChalisaWebView = FindViewById<WebView>(Resource.Id.BramhaChalisawebView1);
            BramhaChalisaWebView.SetWebViewClient(new WebViewClient());
            BramhaChalisaWebView.Settings.JavaScriptEnabled = true;
            BramhaChalisaWebView.LoadUrl("file:///android_asset/BramhaChalisa.htm");
        }
    }
}