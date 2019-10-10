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
    [Activity(Label = "VishnuShatNamStotram")]
    public class VishnuShatNamStotram : Activity
    {
        WebView VishnuShatNamStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VishnuShatNamStotram);
            VishnuShatNamStotramWebView = FindViewById<WebView>(Resource.Id.VishnuShatNamStotramwebView1);
            VishnuShatNamStotramWebView.SetWebViewClient(new WebViewClient());
            VishnuShatNamStotramWebView.Settings.JavaScriptEnabled = true;
            VishnuShatNamStotramWebView.LoadUrl("file:///android_asset/stotram/VishnuShatanamaStotram.htm");
        }
    }
}