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
    [Activity(Label = "अन्नपूर्णा माता की आरती")]
    public class AnnapurnaAarti : Activity
    {

        WebView AnnapurnaAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AnnapurnaAarti);
            AnnapurnaAartiWebView = FindViewById<WebView>(Resource.Id.AnnapurnaAartiwebView1);
            AnnapurnaAartiWebView.SetWebViewClient(new WebViewClient());
            AnnapurnaAartiWebView.Settings.JavaScriptEnabled = true;
            AnnapurnaAartiWebView.LoadUrl("file:///android_asset/aarti/AnnapurnaAarti.htm");

        }
    }
}