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
    [Activity(Label = "SankatNashakGaneshStotram")]
    public class SankatNashakGaneshStotram : Activity
    {
        WebView SankatNashakGaneshStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SankatNashakGaneshStotram);
            SankatNashakGaneshStotramWebView = FindViewById<WebView>(Resource.Id.SankatNashakGaneshStotramwebView1);
            SankatNashakGaneshStotramWebView.SetWebViewClient(new WebViewClient());
            SankatNashakGaneshStotramWebView.Settings.JavaScriptEnabled = true;
            SankatNashakGaneshStotramWebView.LoadUrl("file:///android_asset/stotram/SankatNashakGaneshStotram.htm");
        }
    }
}