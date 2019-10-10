
using Android.App;
using Android.OS;
using Android.Webkit;

namespace VedicsSangrah
{
    [Activity(Label = "VindhyeshwariStotram")]
    public class VindhyeshwariStotram : Activity
    {
        WebView VindhyeshwariStotramWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VindhyeshwariStotram);
            VindhyeshwariStotramWebView = FindViewById<WebView>(Resource.Id.VindhyeshwariStotramwebView1);
            VindhyeshwariStotramWebView.SetWebViewClient(new WebViewClient());
            VindhyeshwariStotramWebView.Settings.JavaScriptEnabled = true;
            VindhyeshwariStotramWebView.LoadUrl("file:///android_asset/stotram/vindhyeshvarIstotram.htm");
        }
    }
}