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
    [Activity(Label = "अच्युतस्याष्टकम्")]
    public class AchyutashtakamStotram : Activity
    {
        WebView AchyutashtakamStotramWebview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AchyutashtakamStotram);
            AchyutashtakamStotramWebview = FindViewById<WebView>(Resource.Id.AchyutashtakamStotramwebView1);
            AchyutashtakamStotramWebview.SetWebViewClient(new WebViewClient());
            AchyutashtakamStotramWebview.Settings.JavaScriptEnabled = true;
            AchyutashtakamStotramWebview.LoadUrl("file:///android_asset/stotram/Achyutashtakam.htm");
        }
    }
}