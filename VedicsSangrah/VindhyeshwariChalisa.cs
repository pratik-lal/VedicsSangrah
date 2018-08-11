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
    [Activity(Label = "VindhyeshwariChalisa")]
    public class VindhyeshwariChalisa : Activity
    {
        WebView VindhyeshwariChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VindhyeshwariChalisa);
            VindhyeshwariChalisaWebView = FindViewById<WebView>(Resource.Id.VindhyeshwariChalisawebView1);
            VindhyeshwariChalisaWebView.SetWebViewClient(new WebViewClient());
            VindhyeshwariChalisaWebView.Settings.JavaScriptEnabled = true;
            VindhyeshwariChalisaWebView.LoadUrl("file:///android_asset/VindhyeshwariChalisa.htm");
        }
    }
}