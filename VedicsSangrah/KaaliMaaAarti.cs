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
    [Activity(Label = "KaaliMaaAarti")]
    public class KaaliMaaAarti : Activity
    {
        WebView KaaliMaaAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KaaliMaaAarti);
            KaaliMaaAartiWebView = FindViewById<WebView>(Resource.Id.KaaliMaaAartiwebView1);
            KaaliMaaAartiWebView.SetWebViewClient(new WebViewClient());
            KaaliMaaAartiWebView.Settings.JavaScriptEnabled = true;
            KaaliMaaAartiWebView.LoadUrl("file:///android_asset/aarti/KaliMataAarti.htm");
        }
    }
}