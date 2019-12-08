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
    [Activity(Label = "महा शिवरात्रि कथा")]
    public class MahaShivratriKatha : Activity
    {
        WebView MahaShivratriKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MahaSivratriKatha);
            MahaShivratriKathaWebView = FindViewById<WebView>(Resource.Id.MahaShivratriKathawebView1);
            MahaShivratriKathaWebView.SetWebViewClient(new WebViewClient());
            MahaShivratriKathaWebView.Settings.JavaScriptEnabled = true;
            MahaShivratriKathaWebView.LoadUrl("file:///android_asset/katha/MahaShivratriKatha.htm");

        }
    }
}