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
    [Activity(Label = "शिव तांडव स्तोत्र")]
    public class ShivTandavStotram : Activity
    {
        WebView ShivTandavStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShivTandavStotram);
            ShivTandavStotramWebView = FindViewById<WebView>(Resource.Id.ShivTandavStotramwebView1);
            ShivTandavStotramWebView.SetWebViewClient(new WebViewClient());
            ShivTandavStotramWebView.Settings.JavaScriptEnabled = true;
            ShivTandavStotramWebView.LoadUrl("file:///android_asset/stotram/ShivTandavStotram.htm");
        }
    }
}