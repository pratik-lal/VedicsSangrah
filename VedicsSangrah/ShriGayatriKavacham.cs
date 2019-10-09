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
    [Activity(Label = "ShriGayatriKavacham")]
    public class ShriGayatriKavacham : Activity
    {
        WebView ShriGayatriKavachamWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShriGayatriKavacham);
            ShriGayatriKavachamWebView = FindViewById<WebView>(Resource.Id.ShriGayatriKavachamwebView1);
            ShriGayatriKavachamWebView.SetWebViewClient(new WebViewClient());
            ShriGayatriKavachamWebView.Settings.JavaScriptEnabled = true;
            ShriGayatriKavachamWebView.LoadUrl("file:///android_asset/stotram/shri_gayatri_kavacham.htm");
        }
    }
}