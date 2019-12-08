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
    [Activity(Label = "शिव पंचाक्षर स्तोत्र")]
    public class ShivPanchAksharStotram : Activity
    {
        WebView ShivPanchAksharStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShivPanchAksharStotram);
            ShivPanchAksharStotramWebView = FindViewById<WebView>(Resource.Id.ShivPanchAksharStotramwebView1);
            ShivPanchAksharStotramWebView.SetWebViewClient(new WebViewClient());
            ShivPanchAksharStotramWebView.Settings.JavaScriptEnabled = true;
            ShivPanchAksharStotramWebView.LoadUrl("file:///android_asset/stotram/shiva_panchakshara_stotram.htm");

        }
    }
}