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
    [Activity(Label = "SaraswatiPrarthna")]
    public class SaraswatiPrarthna : Activity
    {
        WebView SaraswatiPrarthnaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SaraswatiPrarthna);
            SaraswatiPrarthnaWebView = FindViewById<WebView>(Resource.Id.SaraswatiPrarthnawebView1);
            SaraswatiPrarthnaWebView.SetWebViewClient(new WebViewClient());
            SaraswatiPrarthnaWebView.Settings.JavaScriptEnabled = true;
            SaraswatiPrarthnaWebView.LoadUrl("file:///android_asset/aarti/SaraswatiPrarthna.htm");
        }
    }
}