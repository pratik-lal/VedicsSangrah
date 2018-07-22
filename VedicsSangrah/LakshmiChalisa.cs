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
    [Activity(Label = "LakshmiChalisa")]
    public class LakshmiChalisa : Activity
    {
        WebView LakshmiChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.LakshmiChalisa);
            LakshmiChalisaWebView = FindViewById<WebView>(Resource.Id.LakshmiChalisawebView1);
            LakshmiChalisaWebView.SetWebViewClient(new WebViewClient());
            LakshmiChalisaWebView.Settings.JavaScriptEnabled = true;
            LakshmiChalisaWebView.LoadUrl("file:///android_asset/LakshmiChalisa.htm");

        }
    }
}