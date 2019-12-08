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
    [Activity(Label = "कृष्ण चालीसा")]
    public class KrishnaChalisa : Activity
    {
        WebView KrishnaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KrishnaJeeChalisa);
            KrishnaChalisaWebView = FindViewById<WebView>(Resource.Id.KrishnaChalisaWebView1);
            KrishnaChalisaWebView.SetWebViewClient(new WebViewClient());
            KrishnaChalisaWebView.Settings.JavaScriptEnabled = true;
            KrishnaChalisaWebView.LoadUrl("file:///android_asset/KrishnaChalisa.htm");
        }
    }
}