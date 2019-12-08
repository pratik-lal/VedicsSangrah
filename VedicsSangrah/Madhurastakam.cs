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
    [Activity(Label = "मधुराष्टकम्")]
    public class Madhurastakam : Activity
    {
        WebView MadhurastakamWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Madhurastakam);
            MadhurastakamWebView = FindViewById<WebView>(Resource.Id.MadhurastakamwebView1);
            MadhurastakamWebView.SetWebViewClient(new WebViewClient());
            MadhurastakamWebView.Settings.JavaScriptEnabled = true;
            MadhurastakamWebView.LoadUrl("file:///android_asset/stotram/madhurashtakam.htm");
        }
    }
}