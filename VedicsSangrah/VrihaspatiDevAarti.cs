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
    [Activity(Label = "VrihaspatiDevAarti")]
    public class VrihaspatiDevAarti : Activity
    {
        WebView VrihaspatiDevAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VrihaspatiDevAarti);
            VrihaspatiDevAartiWebView = FindViewById<WebView>(Resource.Id.VrihaspatiDevAartiwebView1);
            VrihaspatiDevAartiWebView.SetWebViewClient(new WebViewClient());
            VrihaspatiDevAartiWebView.Settings.JavaScriptEnabled = true;
            VrihaspatiDevAartiWebView.LoadUrl("file:///android_asset/aarti/VrihaspatiDevAarti.htm");
        }
    }
}