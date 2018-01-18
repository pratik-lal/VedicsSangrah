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
        }
    }
}