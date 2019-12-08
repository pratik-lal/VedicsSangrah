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
    [Activity(Label = "गणेश चालीसा")]
    public class GaneshChalisa : Activity
    {
        WebView GaneshChalisaWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.GaneshJeeChalisa);
            GaneshChalisaWebView = FindViewById<WebView>(Resource.Id.GaneshChalisaWebView1);
            GaneshChalisaWebView.SetWebViewClient(new WebViewClient());
            GaneshChalisaWebView.Settings.JavaScriptEnabled = true;
            GaneshChalisaWebView.LoadUrl("file:///android_asset/GaneshChalisa.htm");
        }
    }
}