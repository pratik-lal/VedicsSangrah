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
    [Activity(Label = "ShivChalisa")]
    public class ShivChalisa : Activity
    {
        WebView ShivaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShivJeeChalisa);
            ShivaChalisaWebView = FindViewById<WebView>(Resource.Id.ShivaChalisaWebView1);
            ShivaChalisaWebView.SetWebViewClient(new WebViewClient());
            ShivaChalisaWebView.Settings.JavaScriptEnabled = true;
            ShivaChalisaWebView.LoadUrl("file:///android_asset/ShivChalisa.htm");
        }
    }
}