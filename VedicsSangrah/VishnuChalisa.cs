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
    [Activity(Label = "VishnuChalisa")]
    public class VishnuChalisa : Activity
    {
        WebView VishnuChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VishnuChalisa);
            VishnuChalisaWebView = FindViewById<WebView>(Resource.Id.VishnuChalisawebView1);
            VishnuChalisaWebView.SetWebViewClient(new WebViewClient());
            VishnuChalisaWebView.Settings.JavaScriptEnabled = true;
            VishnuChalisaWebView.LoadUrl("file:///android_asset/VishnuChalisa.htm");
        }
    }
}