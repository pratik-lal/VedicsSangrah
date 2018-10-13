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

namespace VedicsSangrah.Resources.layout
{
    [Activity(Label = "ParvatiMaaAarti")]
    public class ParvatiMaaAarti : Activity
    {
        WebView ParvatiMaaAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ParvatiMaaAarti);
            ParvatiMaaAartiWebView = FindViewById<WebView>(Resource.Id.ParvatiMaaAartiwebView1);
            ParvatiMaaAartiWebView.SetWebViewClient(new WebViewClient());
            ParvatiMaaAartiWebView.Settings.JavaScriptEnabled = true;
            ParvatiMaaAartiWebView.LoadUrl("file:///android_asset/aarti/ParvatiJeeAarti.htm");
        }
    }
}