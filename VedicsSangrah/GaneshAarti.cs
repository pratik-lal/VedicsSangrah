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
    [Activity(Label = "गणेश जी की आरती")]
    public class GaneshAarti : Activity
    {
        WebView GaneshAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.GaneshAarti);
            GaneshAartiWebView = FindViewById<WebView>(Resource.Id.GaneshAartiwebView1);
            GaneshAartiWebView.SetWebViewClient(new WebViewClient());
            GaneshAartiWebView.Settings.JavaScriptEnabled = true;
            GaneshAartiWebView.LoadUrl("file:///android_asset/aarti/GaneshAarti.htm");
        }
    }
}