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
    [Activity(Label = "श्री राम स्तुति")]
    public class RamStuti : Activity
    {
        WebView RamStutiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RamStuti);
            RamStutiWebView = FindViewById<WebView>(Resource.Id.RamStutiwebView1);
            RamStutiWebView.SetWebViewClient(new WebViewClient());
            RamStutiWebView.Settings.JavaScriptEnabled = true;
            RamStutiWebView.LoadUrl("file:///android_asset/stotram/ram_stuti.htm");
        }
    }
}