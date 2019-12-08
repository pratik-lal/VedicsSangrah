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
    [Activity(Label = "सरस्वती चालीसा")]
    public class SaraswatiChalisa : Activity
    {
        WebView SaraswatiChalisaWebview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SaraswatiChalisa);
            SaraswatiChalisaWebview = FindViewById<WebView>(Resource.Id.SaraswatiChalisawebView1);
            SaraswatiChalisaWebview.SetWebViewClient(new WebViewClient());
            SaraswatiChalisaWebview.Settings.JavaScriptEnabled = true;
            SaraswatiChalisaWebview.LoadUrl("file:///android_asset/SaraswatiChalisa.htm");
        }
    }
}