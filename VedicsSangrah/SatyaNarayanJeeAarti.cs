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
    [Activity(Label = "सत्य नारायण जी की आरती")]
    public class SatyaNarayanJeeAarti : Activity
    {
        WebView SatyanarayanJeeAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SatyanarayanJeeAarti);
            SatyanarayanJeeAartiWebView = FindViewById<WebView>(Resource.Id.SatyaNarayanJeeAartiwebView1);
            SatyanarayanJeeAartiWebView.SetWebViewClient(new WebViewClient());
            SatyanarayanJeeAartiWebView.Settings.JavaScriptEnabled = true;
            SatyanarayanJeeAartiWebView.LoadUrl("file:///android_asset/aarti/SatyanarayanaJeeAarti.htm");
        }
    }
}