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
    [Activity(Label = "सूर्य अष्टकम")]
    public class SuryaAshtakam : Activity
    {
        WebView SuryaAshtakamWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SuryaAshtakam);
            SuryaAshtakamWebView = FindViewById<WebView>(Resource.Id.SuryaAshtakamwebView1);
            SuryaAshtakamWebView.SetWebViewClient(new WebViewClient());
            SuryaAshtakamWebView.Settings.JavaScriptEnabled = true;
            SuryaAshtakamWebView.LoadUrl("file:///android_asset/stotram/SuryashTakam.htm");
        }
    }
}