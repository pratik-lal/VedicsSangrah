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
    [Activity(Label = "श्री राधा जी की आरती")]
    public class RadhaJeeAarti : Activity
    {
        WebView RadhaJeeAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RadhaJeeAarti);
            RadhaJeeAartiWebView = FindViewById<WebView>(Resource.Id.RadhaJeeAartiwebView1);
            RadhaJeeAartiWebView.SetWebViewClient(new WebViewClient());
            RadhaJeeAartiWebView.Settings.JavaScriptEnabled = true;
            RadhaJeeAartiWebView.LoadUrl("file:///android_asset/aarti/RaadhaJeeAarti.htm");

        }
    }
}