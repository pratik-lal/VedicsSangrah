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
    [Activity(Label = "HanumanChalisa")]
    public class HanumanChalisa : Activity
    {
        WebView HanumanChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.HanumanJeeChalisa);
            HanumanChalisaWebView = FindViewById<WebView>(Resource.Id.HanumanChalisawWebView1);
            HanumanChalisaWebView.SetWebViewClient(new WebViewClient());
            HanumanChalisaWebView.Settings.JavaScriptEnabled = true;
            HanumanChalisaWebView.LoadUrl("file:///android_asset/HanumanChalisa.htm");
        }
    }
}