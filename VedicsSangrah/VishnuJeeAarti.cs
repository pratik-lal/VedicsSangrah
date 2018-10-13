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
    [Activity(Label = "VishnuJeeAarti")]
    public class VishnuJeeAarti : Activity
    {
        WebView VishnuJeeAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VishnuJeeAarti);
            VishnuJeeAartiWebView = FindViewById<WebView>(Resource.Id.VishnuJeeAartiwebView1);
            VishnuJeeAartiWebView.SetWebViewClient(new WebViewClient());
            VishnuJeeAartiWebView.Settings.JavaScriptEnabled = true;
            VishnuJeeAartiWebView.LoadUrl("file:///android_asset/aarti/VishnuAarti.htm");
        }
    }
}