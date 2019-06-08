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
    [Activity(Label = "HanumanJeeAarti")]
    public class HanumanJeeAarti : Activity
    {
        WebView HanumanJeeAartiWebview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.HanumanJeeAarti);
            HanumanJeeAartiWebview = FindViewById<WebView>(Resource.Id.HanumanJeeAartiwebView1);
            HanumanJeeAartiWebview.SetWebViewClient(new WebViewClient());
            HanumanJeeAartiWebview.Settings.JavaScriptEnabled = true;
            HanumanJeeAartiWebview.LoadUrl("file:///android_asset/aarti/HanumanJeeAarti.htm");
        }
    }
}