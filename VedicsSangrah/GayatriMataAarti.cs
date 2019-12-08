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
    [Activity(Label = "गायत्री माता की आरती")]
    public class GayatriMataAarti : Activity
    {
        WebView GayatriMataAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.GayatriMataAarti);
            GayatriMataAartiWebView = FindViewById<WebView>(Resource.Id.GayatriMataAartiwebView1);
            GayatriMataAartiWebView.SetWebViewClient(new WebViewClient());
            GayatriMataAartiWebView.Settings.JavaScriptEnabled = true;
            GayatriMataAartiWebView.LoadUrl("file:///android_asset/aarti/GayatriMataAarti.htm");
        }
    }
}