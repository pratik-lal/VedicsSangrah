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
    [Activity(Label = "आदित्य हृदय स्तोत्र")]
    public class AdityahRidayastotra : Activity
    {
        WebView AdityahRidayastotraWebview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AdityahRidayastotra);
            AdityahRidayastotraWebview = FindViewById<WebView>(Resource.Id.AdityahRidayastotrawebView1);
            AdityahRidayastotraWebview.SetWebViewClient(new WebViewClient());
            AdityahRidayastotraWebview.Settings.JavaScriptEnabled = true;
            AdityahRidayastotraWebview.LoadUrl("file:///android_asset/stotram/AdityahRidayastotra.htm");
        }
    }
}