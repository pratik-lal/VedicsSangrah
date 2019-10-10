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
    [Activity(Label = "KrishnaAshtakam")]
    public class KrishnaAshtakam : Activity
    {
        WebView KrishnaAshtakamWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KrishnaAshtakam);
            KrishnaAshtakamWebView = FindViewById<WebView>(Resource.Id.KrishnaAshtakamwebView1);
            KrishnaAshtakamWebView.SetWebViewClient(new WebViewClient());
            KrishnaAshtakamWebView.Settings.JavaScriptEnabled = true;
            KrishnaAshtakamWebView.LoadUrl("file:///android_asset/stotram/shri_krishnastakam.htm");
        }
    }
}