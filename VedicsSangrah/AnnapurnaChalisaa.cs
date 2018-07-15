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
    [Activity(Label = "AnnapurnaChalisaa")]
    public class AnnapurnaChalisaa : Activity
    {
        //Add a new webview here
        WebView AnnapurnaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AnnapurnaChalisaa);
            AnnapurnaChalisaWebView = FindViewById<WebView>(Resource.Id.AnnapurnaChalisawebView1);
            AnnapurnaChalisaWebView.SetWebViewClient(new WebViewClient());
            AnnapurnaChalisaWebView.Settings.JavaScriptEnabled = true;
            AnnapurnaChalisaWebView.LoadUrl("file:///android_asset/AnnapurnaChalisa.htm");

        }
    }
}