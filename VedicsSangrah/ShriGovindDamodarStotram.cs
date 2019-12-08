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
    [Activity(Label = "गोविंद दामोदर स्तोत्र")]
    public class ShriGovindDamodarStotram : Activity
    {
        WebView ShriGovindDamodarStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShriGovindDamodarStotram);
            ShriGovindDamodarStotramWebView = FindViewById<WebView>(Resource.Id.ShriGovindDamodarStotramwebView1);
            ShriGovindDamodarStotramWebView.SetWebViewClient(new WebViewClient());
            ShriGovindDamodarStotramWebView.Settings.JavaScriptEnabled = true;
            ShriGovindDamodarStotramWebView.LoadUrl("file:///android_asset/stotram/ShrIgovindadAmodarastotra.htm");
        }
    }
}