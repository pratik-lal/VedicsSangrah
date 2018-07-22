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
    [Activity(Label = "ParvatiChalisa")]
    public class ParvatiChalisa : Activity
    {
        WebView ParvatiChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ParvatiChalisa);
            ParvatiChalisaWebView = FindViewById<WebView>(Resource.Id.ParvatiChalisawebView1);
            ParvatiChalisaWebView.SetWebViewClient(new WebViewClient());
            ParvatiChalisaWebView.Settings.JavaScriptEnabled = true;
            ParvatiChalisaWebView.LoadUrl("file:///android_asset/ParvatiChalisa.htm");

        }
    }
}