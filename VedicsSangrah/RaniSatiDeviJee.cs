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
    [Activity(Label = "माता रानी सती की आरती")]
    public class RaniSatiDeviJee : Activity
    {
        WebView RaniSatiDeviJeeAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RaniSatiJeeAarti);
            RaniSatiDeviJeeAartiWebView = FindViewById<WebView>(Resource.Id.RaniSatiDeviJeewebView1);
            RaniSatiDeviJeeAartiWebView.SetWebViewClient(new WebViewClient());
            RaniSatiDeviJeeAartiWebView.Settings.JavaScriptEnabled = true;
            RaniSatiDeviJeeAartiWebView.LoadUrl("file:///android_asset/aarti/RaniSatiJeeAarti.htm");
        }
    }
}