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
    [Activity(Label = "चित्रगुप्त चालीसा")]
    public class ChitraguptaChalisa : Activity
    {
        WebView ChitraguptaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ChitraguptaChalisa);
            ChitraguptaChalisaWebView = FindViewById<WebView>(Resource.Id.ChitraguptaChalisawebView1);
            ChitraguptaChalisaWebView.SetWebViewClient(new WebViewClient());
            ChitraguptaChalisaWebView.Settings.JavaScriptEnabled = true;
            ChitraguptaChalisaWebView.LoadUrl("file:///android_asset/ChitraguptChalisa.htm");
            
        }
    }
}