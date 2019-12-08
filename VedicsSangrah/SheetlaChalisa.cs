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
    [Activity(Label = "माँ शीतला चालीसा")]
    public class SheetlaChalisa : Activity
    {
        WebView SheetlaChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SheetlaChalisa);
            SheetlaChalisaWebView = FindViewById<WebView>(Resource.Id.SheetlaChalisawebView1);
            SheetlaChalisaWebView.SetWebViewClient(new WebViewClient());
            SheetlaChalisaWebView.Settings.JavaScriptEnabled = true;
            SheetlaChalisaWebView.LoadUrl("file:///android_asset/SheetlaChalisa.htm");
        }
    }
}