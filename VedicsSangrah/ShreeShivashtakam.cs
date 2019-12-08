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
    [Activity(Label = "शिवाष्टकं")]
    public class ShreeShivashtakam : Activity
    {
        WebView ShreeShivashtakamWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShreeShivashtakam);
            ShreeShivashtakamWebView = FindViewById<WebView>(Resource.Id.ShreeShivashtakamwebView1);
            ShreeShivashtakamWebView.SetWebViewClient(new WebViewClient());
            ShreeShivashtakamWebView.Settings.JavaScriptEnabled = true;
            ShreeShivashtakamWebView.LoadUrl("file:///android_asset/stotram/ShreeShivashtakam.htm");
        }
    }
}