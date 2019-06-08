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
    [Activity(Label = "Dwadasa_jyotirlingam")]
    public class Dwadasa_jyotirlingam : Activity
    {
        WebView dwadasa_jyotirlingamwebview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.dwadasa_jyotirlingam);
            dwadasa_jyotirlingamwebview = FindViewById<WebView>(Resource.Id.dwadasa_jyotirlingamwebView1);
            dwadasa_jyotirlingamwebview.SetWebViewClient(new WebViewClient());
            dwadasa_jyotirlingamwebview.Settings.JavaScriptEnabled = true;
            dwadasa_jyotirlingamwebview.LoadUrl("file:///android_asset/stotram/dwadasa_jyotirlingam.htm");
        }
    }
}