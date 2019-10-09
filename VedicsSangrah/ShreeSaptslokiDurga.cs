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
    [Activity(Label = "ShreeSaptslokiDurga")]
    public class ShreeSaptslokiDurga : Activity
    {
        WebView ShreeSaptslokiDurgaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShreeSaptslokiDurga);
            ShreeSaptslokiDurgaWebView = FindViewById<WebView>(Resource.Id.ShreeSaptslokiDurgawebView1);
            ShreeSaptslokiDurgaWebView.SetWebViewClient(new WebViewClient());
            ShreeSaptslokiDurgaWebView.Settings.JavaScriptEnabled = true;
            ShreeSaptslokiDurgaWebView.LoadUrl("file:///android_asset/stotram/shree_durga_saptsloki.htm");



        }
    }
}