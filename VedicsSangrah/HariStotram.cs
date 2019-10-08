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
    [Activity(Label = "HariStotram")]
    public class HariStotram : Activity
    {
        WebView HariStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.HariStotram);
            HariStotramWebView = FindViewById<WebView>(Resource.Id.HariStotramwebView1);
            HariStotramWebView.SetWebViewClient(new WebViewClient());
            HariStotramWebView.Settings.JavaScriptEnabled = true;
            HariStotramWebView.LoadUrl("file:///android_asset/stotram/Hari_stotram.htm");
        }
    }
}