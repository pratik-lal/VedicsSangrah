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
    [Activity(Label = "श्री हरि नाम माला स्तोत्र")]
    public class ShriHariNaamMalaStrotram : Activity
    {
        WebView ShriHariNaamMalaStrotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShriHariNaamMalaStrotram);
            ShriHariNaamMalaStrotramWebView = FindViewById<WebView>(Resource.Id.ShriHariNaamMalaStrotramwebView1);
            ShriHariNaamMalaStrotramWebView.SetWebViewClient(new WebViewClient());
            ShriHariNaamMalaStrotramWebView.Settings.JavaScriptEnabled = true;
            ShriHariNaamMalaStrotramWebView.LoadUrl("file:///android_asset/stotram/Shri_hari_namm_mala_strotra.htm");
        }
    }
}