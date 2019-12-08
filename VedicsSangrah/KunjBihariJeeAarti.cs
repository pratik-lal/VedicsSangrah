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
    [Activity(Label = "श्री कुंज बिहारी जी की आरती")]
    public class KunjBihariJeeAarti : Activity
    {
        WebView KunjBihariJeeAartiWwebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KunjBihariJeeAarti);
            KunjBihariJeeAartiWwebView = FindViewById<WebView>(Resource.Id.KunjBihariJeeAartiwebView1);
            KunjBihariJeeAartiWwebView.SetWebViewClient(new WebViewClient());
            KunjBihariJeeAartiWwebView.Settings.JavaScriptEnabled = true;
            KunjBihariJeeAartiWwebView.LoadUrl("file:///android_asset/aarti/KunjBihariJeeAarti.htm");
        }
    }
}