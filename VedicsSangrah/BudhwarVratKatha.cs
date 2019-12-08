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
    [Activity(Label = "बुधवार व्रत कथा")]
    public class BudhwarVratKatha : Activity
    {
        WebView BudhwarVratKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.BudhwarVratKatha);
            BudhwarVratKathaWebView = FindViewById<WebView>(Resource.Id.BudhwarVratKathawebView1);
            BudhwarVratKathaWebView.SetWebViewClient(new WebViewClient());
            BudhwarVratKathaWebView.Settings.JavaScriptEnabled = true;
            BudhwarVratKathaWebView.LoadUrl("file:///android_asset/katha/BuddhvaarVratKatha.htm");
        }
    }
}