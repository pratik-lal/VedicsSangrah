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
    [Activity(Label = "ChitraguptaPujaKatha")]
    public class ChitraguptaPujaKatha : Activity
    {
        WebView ChitraguptaPujaKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ChitraguptaPujaKatha);
            ChitraguptaPujaKathaWebView = FindViewById<WebView>(Resource.Id.ChitraguptaPujaKathawebView1);
            ChitraguptaPujaKathaWebView.SetWebViewClient(new WebViewClient());
            ChitraguptaPujaKathaWebView.Settings.JavaScriptEnabled = true;
            ChitraguptaPujaKathaWebView.LoadUrl("file:///android_asset/katha/ChitraguptPujatKatha.htm");
        }
    }
}