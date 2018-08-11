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
    [Activity(Label = "VashnoDeviChalisa")]
    public class VashnoDeviChalisa : Activity
    {
        WebView VashnoDeviChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VasnhoDeviChalisa);
            VashnoDeviChalisaWebView = FindViewById<WebView>(Resource.Id.VashnoDeviChalisawebView1);
            VashnoDeviChalisaWebView.SetWebViewClient(new WebViewClient());
            VashnoDeviChalisaWebView.Settings.JavaScriptEnabled = true;
            VashnoDeviChalisaWebView.LoadUrl("file:///android_asset/VashnoDeviChalisa.htm");
        }
    }
}