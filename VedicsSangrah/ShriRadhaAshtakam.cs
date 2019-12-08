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
    [Activity(Label = "श्री राधा अष्टकम")]
    public class ShriRadhaAshtakam : Activity
    {
        WebView ShriRadhaAshtakamWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShriRadhaAshtakam);
            ShriRadhaAshtakamWebView = FindViewById<WebView>(Resource.Id.ShriRadhaAshtakamwebView1);
            ShriRadhaAshtakamWebView.SetWebViewClient(new WebViewClient());
            ShriRadhaAshtakamWebView.Settings.JavaScriptEnabled = true;
            ShriRadhaAshtakamWebView.LoadUrl("file:///android_asset/stotram/ShriRadhaAshtakam.htm");
        }
    }
}