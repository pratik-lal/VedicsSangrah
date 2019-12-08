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
    [Activity(Label = "लक्ष्मी माता की आरती")]
    public class LakshmiMaaAarti : Activity
    {
        WebView LakshmiMaaAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.LaxhmiMaaAarti);
            LakshmiMaaAartiWebView = FindViewById<WebView>(Resource.Id.LakshmiMaaAartiwebView1);
            LakshmiMaaAartiWebView.SetWebViewClient(new WebViewClient());
            LakshmiMaaAartiWebView.Settings.JavaScriptEnabled = true;
            LakshmiMaaAartiWebView.LoadUrl("file:///android_asset/aarti/LaxhmiJeeAarti.htm");
        }
    }
}