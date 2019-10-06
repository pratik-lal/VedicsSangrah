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
    [Activity(Label = "JanmastamiVratKatha")]
    public class JanmastamiVratKatha : Activity
    {
        WebView JanmastamiVratKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.JanmastamiVratKatha);
            JanmastamiVratKathaWebView = FindViewById<WebView>(Resource.Id.JanmastamiVratKathawebView1);
            JanmastamiVratKathaWebView.SetWebViewClient(new WebViewClient());
            JanmastamiVratKathaWebView.Settings.JavaScriptEnabled = true;
            JanmastamiVratKathaWebView.LoadUrl("file:///android_asset/katha/JanmastamiKatha.htm");
        }
    }
}