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
    [Activity(Label = "नवग्रह चालीसा")]
    public class NavgrahChalisa : Activity
    {
        WebView NavgrahChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.NavgrahChalisa);
            NavgrahChalisaWebView = FindViewById<WebView>(Resource.Id.NavgrahChalisawebView1);
            NavgrahChalisaWebView.SetWebViewClient(new WebViewClient());
            NavgrahChalisaWebView.Settings.JavaScriptEnabled = true;
            NavgrahChalisaWebView.LoadUrl("file:///android_asset/NavgrahChalisa.htm");
        }
    }
}