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
    [Activity(Label = "GayatriChalisa")]
    public class GayatriChalisa : Activity
    {
        WebView GayatriChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.GayatriChalisa);
            GayatriChalisaWebView = FindViewById<WebView>(Resource.Id.GayatriChalisawebView1);
            GayatriChalisaWebView.SetWebViewClient(new WebViewClient());
            GayatriChalisaWebView.Settings.JavaScriptEnabled = true;
            GayatriChalisaWebView.LoadUrl("file:///android_asset/GayatriChalisa.htm");

        }
    }
}