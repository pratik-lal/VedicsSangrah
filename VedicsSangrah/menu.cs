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

namespace VedicsSangrah
{
    [Activity(Label = "वैदिक संग्रह")]
    public class Menu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Menu);
            Button button1 = FindViewById<Button>(Resource.Id.contactusButton);
            button1.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://vedics.in/contact-vedicsapp");
                var i = new Intent(Intent.ActionView, uri);
                StartActivity(i);
            };
            Button button2 = FindViewById<Button>(Resource.Id.sendcorrectionsButton);
            button2.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://vedics.in/send-corrections-vedicsapp");
                var i = new Intent(Intent.ActionView, uri);
                StartActivity(i);
            };
            Button button3 = FindViewById<Button>(Resource.Id.developerButton);
            button3.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://github.com/pratik-lal/VedicsSangrah");
                var i = new Intent(Intent.ActionView, uri);
                StartActivity(i);
            };
            Button button4 = FindViewById<Button>(Resource.Id.donateButton);
            button4.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://vedics.in/contribute-to-vedicssangrahapp");
                var i = new Intent(Intent.ActionView, uri);
                StartActivity(i);
            };
            Button button5 = FindViewById<Button>(Resource.Id.requestcontentButton);
            button5.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://vedics.in/request-new-content-vedicsapp");
                var i = new Intent(Intent.ActionView, uri);
                StartActivity(i);
            };
            Button button6 = FindViewById<Button>(Resource.Id.privacypolicyButton);
            button6.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("https://vedics.in/privacy-policy-vedics-sangrahapp");
                var i = new Intent(Intent.ActionView, uri);
                StartActivity(i);
            };

        }
    }
}