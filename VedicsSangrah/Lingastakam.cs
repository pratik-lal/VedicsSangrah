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
    [Activity(Label = "Lingastakam")]
    public class Lingastakam : Activity
    {
        WebView LingastakamWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Lingastakam);
            LingastakamWebView = FindViewById<WebView>(Resource.Id.LingastakamwebView1);
            LingastakamWebView.SetWebViewClient(new WebViewClient());
            LingastakamWebView.Settings.JavaScriptEnabled = true;
            LingastakamWebView.LoadUrl("file:///android_asset/stotram/lingashtakam.htm");
        }
    }
}