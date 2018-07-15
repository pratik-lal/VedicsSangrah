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
    [Activity(Label = "ChalisaSangrah")]
    public class ChalisaSangrah : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ChalisaMainPage);

            Button button3 = FindViewById<Button>(Resource.Id.GaneshChalisaButton);
            button3.Click += delegate
              {
                  StartActivity(typeof(GaneshChalisa));
              };
            Button button4 = FindViewById<Button>(Resource.Id.HanumanChalisaButton);
            button4.Click += delegate
            {
                StartActivity(typeof(HanumanChalisa));
            };

            Button button5 = FindViewById<Button>(Resource.Id.ShivChalisaButton);
            button5.Click += delegate
            {
                StartActivity(typeof(ShivChalisa));
            };

            Button button6 = FindViewById<Button>(Resource.Id.KrishnaChalisaButton);
            button6.Click += delegate
             {
                 StartActivity(typeof(KrishnaChalisa));
             };

            Button button7 = FindViewById<Button>(Resource.Id.AnnapurnaChalisaButton);
            button7.Click += delegate
            {
                StartActivity(typeof(AnnapurnaChalisaa));
            };

            Button button8 = FindViewById<Button>(Resource.Id.BhairavChalisaButton);
            button8.Click += delegate
            {
                StartActivity(typeof(BhairavChalisa));
            };

            Button button9 = FindViewById<Button>(Resource.Id.BramhaChalisaButton);
            button9.Click += delegate
             {
                 StartActivity(typeof(BramhaChalisa));
             };

            Button button10 = FindViewById<Button>(Resource.Id.ChitraguptaChalisaButton);
            button10.Click += delegate
             {
                 StartActivity(typeof(ChitraguptaChalisa));
             };

            Button button11 = FindViewById<Button>(Resource.Id.DurgaChalisaButton);
            button11.Click += delegate
              {
                  StartActivity(typeof(DurgaChalisa));
              };
            Button button12 = FindViewById<Button>(Resource.Id.GayatriChalisaButton);
            button12.Click += delegate
            {
                StartActivity(typeof(GayatriChalisa));
            };

            Button button14 = FindViewById<Button>(Resource.Id.KaliMaaChalisaButton);
            button12.Click += delegate
            {
                StartActivity(typeof(KaaliMaaChalisa));
            };

            Button button15 = FindViewById<Button>(Resource.Id.KhatuShyamChalisaButton);
            button15.Click += delegate
            {
                StartActivity(typeof(KhatuShyamChalisa));
            };
        }
    }
}