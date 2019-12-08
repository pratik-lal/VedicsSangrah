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
    [Activity(Label = "अष्टाविंशति विष्णु नाम स्तोत्र")]
    public class AshtaVimsathiVishniNamaStotram : Activity
    {
        WebView AshtaVimsathiVishniNamaStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AshtaVimsathiVishniNamaStotram);
            AshtaVimsathiVishniNamaStotramWebView = FindViewById<WebView>(Resource.Id.AshtaVimsathiVishniNamaStotramwebView1);
            AshtaVimsathiVishniNamaStotramWebView.SetWebViewClient(new WebViewClient());
            AshtaVimsathiVishniNamaStotramWebView.Settings.JavaScriptEnabled = true;
            AshtaVimsathiVishniNamaStotramWebView.LoadUrl("file:///android_asset/stotram/VishnuAshtaVimsathiNamaStotram.htm");
        }
    }
}