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
    [Activity(Label = "कथा एवम् कांड संग्रह")]
    public class KathaKaand : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KathaKaand);
            Button button1 = FindViewById<Button>(Resource.Id.SomvarVratKathaButton);
            button1.Click += delegate
            {
                StartActivity(typeof(SomvarVratKatha));
            };
            Button button2 = FindViewById<Button>(Resource.Id.MangalvarKathaButton);
            button2.Click += delegate
            {
                StartActivity(typeof(MangalwarVratKatha));
            };
            Button button3 = FindViewById<Button>(Resource.Id.BudhvarVratKathaButton);
            button3.Click += delegate
            {
                StartActivity(typeof(BudhwarVratKatha));
            };
            Button button4 = FindViewById<Button>(Resource.Id.VrihaspatiVarKathaButton);
            button4.Click += delegate
            {
                StartActivity(typeof(VrihaspativarVratKatha));
            };
            Button button5 = FindViewById<Button>(Resource.Id.ShukraVarVratKathaButton);
            button5.Click += delegate
            {
                StartActivity(typeof(ShukravarVratKatha));
            };
            Button button6 = FindViewById<Button>(Resource.Id.ShanivarVratKathaButton);
            button6.Click += delegate
            {
                StartActivity(typeof(ShanivarVratKatha));
            };
            Button button7 = FindViewById<Button>(Resource.Id.RavivarVratKathaButton);
            button7.Click += delegate
            {
                StartActivity(typeof(RavivarVratKatha));
            };
            Button button8 = FindViewById<Button>(Resource.Id.SundarKandButton);
            button8.Click += delegate
            {
                StartActivity(typeof(Sundarkand));
            };
            Button button9 = FindViewById<Button>(Resource.Id.JanmastamiKathaButton);
            button9.Click += delegate
            {
                StartActivity(typeof(JanmastamiVratKatha));
            };
            Button button10 = FindViewById<Button>(Resource.Id.ChhathKathaButton);
            button10.Click += delegate
            {
                StartActivity(typeof(ChhathVratKatha));
            };
            Button button11 = FindViewById<Button>(Resource.Id.MahaShivratriKathaButton);
            button11.Click += delegate
            {
                StartActivity(typeof(MahaShivratriKatha));
            };
            Button button12 = FindViewById<Button>(Resource.Id.ChitraguptaKathaButton);
            button12.Click += delegate
            {
                StartActivity(typeof(ChitraguptaPujaKatha));
            };
            Button button13 = FindViewById<Button>(Resource.Id.KarwaChauthKathaButton);
            button13.Click += delegate
            {
                StartActivity(typeof(KarwaChauthKatha));
            };
        }
    }
}