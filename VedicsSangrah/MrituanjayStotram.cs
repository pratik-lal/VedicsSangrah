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
    [Activity(Label = "MrituanjayStotram")]
    public class MrituanjayStotram : Activity
    {
        WebView MrituanjayStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MrituanjayaStotram);
            MrituanjayStotramWebView = FindViewById<WebView>(Resource.Id.MrituanjayStotramwebView1);
            MrituanjayStotramWebView.SetWebViewClient(new WebViewClient());
            MrituanjayStotramWebView.Settings.JavaScriptEnabled = true;
            MrituanjayStotramWebView.LoadUrl("file:///android_asset/stotram/shri_mrityunjaya_stotram.htm");
        }
    }
}