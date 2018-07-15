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
    [Activity(Label = "KhatuShyamChalisa")]
    public class KhatuShyamChalisa : Activity
    {
        WebView KhatuShyamChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KhatuShyamChalisa);
            KhatuShyamChalisaWebView = FindViewById<WebView>(Resource.Id.KhatuShyamChalisawebView1);
            KhatuShyamChalisaWebView.SetWebViewClient(new WebViewClient());
            KhatuShyamChalisaWebView.Settings.JavaScriptEnabled = true;
            KhatuShyamChalisaWebView.LoadUrl("file:///android_asset/KhatuShyamChalisa.htm");

        }
    }
}