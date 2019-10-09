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
    [Activity(Label = "ShriGauriAshtottaraNamavali")]
    public class ShriGauriAshtottaraNamavali : Activity
    {
        WebView ShriGauriAshtottaraNamavaliWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShriGauriAshtottaraNamavali);
            ShriGauriAshtottaraNamavaliWebView = FindViewById<WebView>(Resource.Id.ShriGauriAshtottaraNamavaliwebView1);
            ShriGauriAshtottaraNamavaliWebView.SetWebViewClient(new WebViewClient());
            ShriGauriAshtottaraNamavaliWebView.Settings.JavaScriptEnabled = true;
            ShriGauriAshtottaraNamavaliWebView.LoadUrl("file:///android_asset/stotram/ShriGauriAshtottaraNamavali.htm");
        }
    }
}