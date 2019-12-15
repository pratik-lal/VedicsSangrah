using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace VedicsSangrah
{
    [Activity(Label = "वैदिक संग्रह", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button button1 = FindViewById<Button>(Resource.Id.ChalisaSangrahButton);
            button1.Click += delegate
             {
                 StartActivity(typeof(ChalisaSangrah));
             };
            Button button2 = FindViewById<Button>(Resource.Id.AartiSangrahButton);
            button2.Click += delegate
            {
                StartActivity(typeof(AartiSangrahcs));
            };
            Button button3 = FindViewById<Button>(Resource.Id.StotraSangrahButton);
            button3.Click += delegate
            {
                StartActivity(typeof(StotraSangrah));
            };
            Button button4 = FindViewById<Button>(Resource.Id.KathaKandSangrahButton);
            button4.Click += delegate
            {
                StartActivity(typeof(KathaKaand));
            };
            ImageButton button5 = FindViewById<ImageButton>(Resource.Id.vedicsimageButton1);
            button5.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://vedics.in");
                var i = new Intent(Intent.ActionView, uri);
                StartActivity(i);
            };
            ImageButton button6 = FindViewById<ImageButton>(Resource.Id.vedicsimageButton2);
            button6.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://youtube.com/c/vedics?sub_confirmation=1");
                var i = new Intent(Intent.ActionView, uri);
                StartActivity(i);
            };


        }
    }
}

