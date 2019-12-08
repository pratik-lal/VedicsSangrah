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
    [Activity(Label = "शिव अपराध क्षमापन स्तोत्र")]
    public class ShivApradhaKshamaPrarthnaStotram : Activity
    {
        WebView ShivApradhaKshamaPrarthnaStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ShivApradhaKshamaPrarthnaStotram);
            ShivApradhaKshamaPrarthnaStotramWebView = FindViewById<WebView>(Resource.Id.ShivApradhaKshamaPrarthnaStotramwebView1);
            ShivApradhaKshamaPrarthnaStotramWebView.SetWebViewClient(new WebViewClient());
            ShivApradhaKshamaPrarthnaStotramWebView.Settings.JavaScriptEnabled = true;
            ShivApradhaKshamaPrarthnaStotramWebView.LoadUrl("file:///android_asset/stotram/shivaaparaadha_kshamapan_stotram.htm");
        }
    }
}