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
    [Activity(Label = "सुंदरकांड")]
    public class Sundarkand : Activity
    {
        WebView SundarkandWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Sundarkaand);
            SundarkandWebView = FindViewById<WebView>(Resource.Id.SundarKaandwebView1);
            SundarkandWebView.SetWebViewClient(new WebViewClient());
            SundarkandWebView.Settings.JavaScriptEnabled = true;
            SundarkandWebView.LoadUrl("file:///android_asset/katha/sundarkand.htm");
        }
    }
}