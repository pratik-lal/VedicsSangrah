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
    [Activity(Label = "करवा चौथ कथा")]
    public class KarwaChauthKatha : Activity
    {
        WebView KarwaChauthKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KarwaChauthKatha);
            KarwaChauthKathaWebView = FindViewById<WebView>(Resource.Id.KarwaChauthKathawebView1);
            KarwaChauthKathaWebView.SetWebViewClient(new WebViewClient());
            KarwaChauthKathaWebView.Settings.JavaScriptEnabled = true;
            KarwaChauthKathaWebView.LoadUrl("file:///android_asset/katha/KarvaChauthKatha.htm");
        }
    }
}