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
    [Activity(Label = "RamRakshaStotram")]
    public class RamRakshaStotram : Activity
    {
        WebView RamRakshaStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RamRakshaStotram);
            RamRakshaStotramWebView = FindViewById<WebView>(Resource.Id.RamRakshaStotramwebView1);
            RamRakshaStotramWebView.SetWebViewClient(new WebViewClient());
            RamRakshaStotramWebView.Settings.JavaScriptEnabled = true;
            RamRakshaStotramWebView.LoadUrl("file:///android_asset/stotram/ram_raksha_stotram.htm");
        }
    }
}