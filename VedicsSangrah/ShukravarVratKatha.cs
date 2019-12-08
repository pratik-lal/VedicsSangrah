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
    [Activity(Label = "शुक्रवार व्रत कथा")]
    public class ShukravarVratKatha : Activity
    {
        WebView ShukravarVratKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShukravarVratKatha);
            ShukravarVratKathaWebView = FindViewById<WebView>(Resource.Id.ShukravarVratKathawebView1);
            ShukravarVratKathaWebView.SetWebViewClient(new WebViewClient());
            ShukravarVratKathaWebView.Settings.JavaScriptEnabled = true;
            ShukravarVratKathaWebView.LoadUrl("file:///android_asset/katha/ShukravaarSantoshiMataVratKatha.htm");
        }
    }
}