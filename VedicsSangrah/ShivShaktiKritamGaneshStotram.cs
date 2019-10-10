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
    [Activity(Label = "ShivShaktiKritamGaneshStotram")]
    public class ShivShaktiKritamGaneshStotram : Activity
    {
        WebView ShivShaktiKritamGaneshStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShivShaktiKritamGaneshStotram);
            ShivShaktiKritamGaneshStotramWebView = FindViewById<WebView>(Resource.Id.ShivShaktiKritamGaneshStotramwebView1);
            ShivShaktiKritamGaneshStotramWebView.SetWebViewClient(new WebViewClient());
            ShivShaktiKritamGaneshStotramWebView.Settings.JavaScriptEnabled = true;
            ShivShaktiKritamGaneshStotramWebView.LoadUrl("file:///android_asset/stotram/ShivShaktiKritamGaneshStotram.htm");
        }
    }
}