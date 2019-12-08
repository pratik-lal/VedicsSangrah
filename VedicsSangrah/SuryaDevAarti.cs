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
    [Activity(Label = "सूर्य देव की आरती")]
    public class SuryaDevAarti : Activity
    {
        WebView SuryaDevAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SuryaDevAarti);
            SuryaDevAartiWebView = FindViewById<WebView>(Resource.Id.SuryaDevAartiwebView1);
            SuryaDevAartiWebView.SetWebViewClient(new WebViewClient());
            SuryaDevAartiWebView.Settings.JavaScriptEnabled = true;
            SuryaDevAartiWebView.LoadUrl("file:///android_asset/aarti/SuryaAarti.htm");
        }
    }
}