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
    [Activity(Label = "एक स्लोकी सुंदरकांड")]
    public class Eksloki_sundarkand : Activity
    {
        WebView Eksloki_sundarkandwebview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Eksloki_sundarkand);
            Eksloki_sundarkandwebview = FindViewById<WebView>(Resource.Id.eksloki_sundarkandwebView1);
            Eksloki_sundarkandwebview.SetWebViewClient(new WebViewClient());
            Eksloki_sundarkandwebview.Settings.JavaScriptEnabled = true;
            Eksloki_sundarkandwebview.LoadUrl("file:///android_asset/stotram/eksloki_sundarkand.htm");
        }
    }
}