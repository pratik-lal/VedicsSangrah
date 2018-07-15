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
    [Activity(Label = "DurgaChalisa")]
    public class DurgaChalisa : Activity
    {
        WebView DurgaChalisaWebView;   
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DurgaChalisa);
            DurgaChalisaWebView = FindViewById<WebView>(Resource.Id.DurgaChalisawebView1);
            DurgaChalisaWebView.SetWebViewClient(new WebViewClient());
            DurgaChalisaWebView.Settings.JavaScriptEnabled = true;
            DurgaChalisaWebView.LoadUrl("file:///android_asset/DurgaChalisa.htm");
        }
    }
}