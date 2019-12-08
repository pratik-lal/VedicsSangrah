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
    [Activity(Label = "श्याम बाबा की आरती")]
    public class ShyamBabaAarti : Activity
    {
        WebView ShyamBabaAartiWwebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShyamBabaAarti);
            ShyamBabaAartiWwebView = FindViewById<WebView>(Resource.Id.ShyamBabaAartiwebView1);
            ShyamBabaAartiWwebView.SetWebViewClient(new WebViewClient());
            ShyamBabaAartiWwebView.Settings.JavaScriptEnabled = true;
            ShyamBabaAartiWwebView.LoadUrl("file:///android_asset/aarti/ShyamBabaAarti.htm");
        }
    }
}