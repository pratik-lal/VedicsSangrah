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
    [Activity(Label = "चामुंडा देवी की आरती")]
    public class ChamundaDeviAarti : Activity
    {
        WebView ChamundaDeviAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ChamundaDeviAarti);
            ChamundaDeviAartiWebView = FindViewById<WebView>(Resource.Id.ChamundaDeviAartiwebView1);
            ChamundaDeviAartiWebView.SetWebViewClient(new WebViewClient());
            ChamundaDeviAartiWebView.Settings.JavaScriptEnabled = true;
            ChamundaDeviAartiWebView.LoadUrl("file:///android_asset/aarti/ChamundaDeviAarti.htm");


        }
    }
}