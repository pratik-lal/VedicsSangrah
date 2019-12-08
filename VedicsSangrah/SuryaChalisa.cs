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
    [Activity(Label = "सूर्य चालीसा")]
    public class SuryaChalisa : Activity
    {
        WebView SuryaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SuryaChalisa);
            SuryaChalisaWebView = FindViewById<WebView>(Resource.Id.SuryaChalisawebView1);
            SuryaChalisaWebView.SetWebViewClient(new WebViewClient());
            SuryaChalisaWebView.Settings.JavaScriptEnabled = true;
            SuryaChalisaWebView.LoadUrl("file:///android_asset/SuryaChalisa.htm");
        }
    }
}