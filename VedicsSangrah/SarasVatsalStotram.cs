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
    [Activity(Label = "SarasVatsalStotram")]
    public class SarasVatsalStotram : Activity
    {
        WebView SaraswatiStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SarasVatsalStotram);
            SaraswatiStotramWebView = FindViewById<WebView>(Resource.Id.SaraswatiStotramwebView1);
            SaraswatiStotramWebView.SetWebViewClient(new WebViewClient);
            SaraswatiStotramWebView.Settings.JavaScriptEnabled = true;
            SaraswatiStotramWebView.LoadUrl("file:///android_asset/stotram/sarasvatIstotram.htm");
        }
    }
}