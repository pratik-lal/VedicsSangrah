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
    [Activity(Label = "ChhathVratKatha")]
    public class ChhathVratKatha : Activity
    {
        WebView ChhathVratKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ChhathVratKatha);
            ChhathVratKathaWebView = FindViewById<WebView>(Resource.Id.ChhathVratKathawebView1);
            ChhathVratKathaWebView.SetWebViewClient(new WebViewClient());
            ChhathVratKathaWebView.Settings.JavaScriptEnabled = true;
            ChhathVratKathaWebView.LoadUrl("file:///android_asset/katha/ChhathVratKatha.htm");
        }
    }
}