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
    [Activity(Label = "रुद्राष्टकम्")]
    public class Rudrastakam : Activity
    {
        WebView RudrastakamWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Rudrastakam);
            RudrastakamWebView = FindViewById<WebView>(Resource.Id.RudrastakamwebView1);
            RudrastakamWebView.SetWebViewClient(new WebViewClient());
            RudrastakamWebView.Settings.JavaScriptEnabled = true;
            RudrastakamWebView.LoadUrl("file:///android_asset/stotram/Rudrastakam.htm");
        }
    }
}