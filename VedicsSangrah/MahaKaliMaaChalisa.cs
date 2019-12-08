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
    [Activity(Label = "महाकाली चालीसा")]
    public class MahaKaliMaaChalisa : Activity
    {
        WebView MahakaliMaaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MahaKaaliMaaChalisa);
            MahakaliMaaChalisaWebView = FindViewById<WebView>(Resource.Id.MahaKaliMaaChalisawebView1);
            MahakaliMaaChalisaWebView.SetWebViewClient(new WebViewClient());
            MahakaliMaaChalisaWebView.Settings.JavaScriptEnabled = true;
            MahakaliMaaChalisaWebView.LoadUrl("file:///android_asset/MahaKaliMaaChalisa.htm");
        }
    }
}