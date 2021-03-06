﻿using System;
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
    [Activity(Label = "साईं बाबा की आरती")]
    public class SaibabaAarti : Activity
    {
        WebView SaibabaAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SaibabaAarti);
            SaibabaAartiWebView = FindViewById<WebView>(Resource.Id.SaibabaAartiwebView1);
            SaibabaAartiWebView.SetWebViewClient(new WebViewClient());
            SaibabaAartiWebView.Settings.JavaScriptEnabled = true;
            SaibabaAartiWebView.LoadUrl("file:///android_asset/aarti/SaiBabaKiAarti.htm");
        }
    }
}