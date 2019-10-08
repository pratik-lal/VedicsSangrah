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
    [Activity(Label = "HimalayakritShivStotram")]
    public class HimalayakritShivStotram : Activity
    {
        WebView HimalayakritShivStotramWebview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.HimalayakritShivStotram);
            HimalayakritShivStotramWebview = FindViewById<WebView>(Resource.Id.HimalayakritShivStotramwebView1);
            HimalayakritShivStotramWebview.SetWebViewClient(new WebViewClient());
            HimalayakritShivStotramWebview.Settings.JavaScriptEnabled = true;
            HimalayakritShivStotramWebview.LoadUrl("file:///android_asset/stotram/Himaykrit_shiv_stotram.htm");
        }
    }
}