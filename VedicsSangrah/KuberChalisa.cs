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
    [Activity(Label = "कुबेर चालीसा")]
    public class KuberChalisa : Activity
    {
        WebView KuberChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KuberChalisa);
            KuberChalisaWebView = FindViewById<WebView>(Resource.Id.KuberChalisawebView1);
            KuberChalisaWebView.SetWebViewClient(new WebViewClient());
            KuberChalisaWebView.Settings.JavaScriptEnabled = true;
            KuberChalisaWebView.LoadUrl("file:///android_asset/KuberChalisa.htm");
        }
    }
}