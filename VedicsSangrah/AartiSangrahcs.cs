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
    [Activity(Label = "AartiSangrahcs")]
    public class AartiSangrahcs : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AartiMainPage);

            Button buttona = FindViewById<Button>(Resource.Id.AnnapurnaAartiButton);
            buttona.Click += delegate
             {
                 StartActivity(typeof(AnnapurnaAarti));
             };
        }
    }
}