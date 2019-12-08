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
    [Activity(Label = "वृहस्पतिवार व्रत कथा")]
    public class VrihaspativarVratKatha : Activity
    {
        WebView VrihaspativarVratKathaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            // Create your application here
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.VrihaspativarVratKatha);
            VrihaspativarVratKathaWebView = FindViewById<WebView>(Resource.Id.VrihaspativarVratKathawebView1);
            VrihaspativarVratKathaWebView.SetWebViewClient(new WebViewClient());
            VrihaspativarVratKathaWebView.Settings.JavaScriptEnabled = true;
            VrihaspativarVratKathaWebView.LoadUrl("file:///android_asset/katha/vrihaspativar_vrat_katha.htm");

        }
    }
}