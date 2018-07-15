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
    [Activity(Label = "KaaliMaaChalisa")]
    public class KaaliMaaChalisa : Activity
    {
        WebView KaaliMaaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KaaliMaaChalisa);
            KaaliMaaChalisaWebView = FindViewById<WebView>(Resource.Id.KaliMaaChalisawebView1);
            KaaliMaaChalisaWebView.SetWebViewClient(new WebViewClient());
            KaaliMaaChalisaWebView.Settings.JavaScriptEnabled = true;
            KaaliMaaChalisaWebView.LoadUrl("file:///android_asset/KaliMaaChalisa.htm");
        }
    }
}