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
    [Activity(Label = "मंगलवार व्रत कथा")]
    public class MangalwarVratKatha : Activity
    {
        WebView MangalwarVratKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MangalwarVratKatha);
            MangalwarVratKathaWebView = FindViewById<WebView>(Resource.Id.MangalwarVratKathawebView1);
            MangalwarVratKathaWebView.SetWebViewClient(new WebViewClient());
            MangalwarVratKathaWebView.Settings.JavaScriptEnabled = true;
            MangalwarVratKathaWebView.LoadUrl("file:///android_asset/katha/MangalvaarVratKatha.htm");
        }
    }
}