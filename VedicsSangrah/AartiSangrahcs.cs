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
            Button buttonb = FindViewById<Button>(Resource.Id.ChamundaDeviAartiButton);
            buttonb.Click += delegate
            {
                StartActivity(typeof(ChamundaDeviAarti));
            };
            Button buttonc = FindViewById<Button>(Resource.Id.GaneshAartiButton);
            buttonc.Click += delegate
            {
                StartActivity(typeof(GaneshAarti));
            };
            Button buttond = FindViewById<Button>(Resource.Id.GayatriAartiButton);
            buttond.Click += delegate
            {
                StartActivity(typeof(GayatriMataAarti));
            };
            Button buttone = FindViewById<Button>(Resource.Id.HanumanAartiaButton);
            buttone.Click += delegate
            {
                StartActivity(typeof(HanumanJeeAarti));
            };
            Button buttonf = FindViewById<Button>(Resource.Id.KaliMaaAartiButton);
            buttonf.Click += delegate
            {
                StartActivity(typeof(KaaliMaaAarti));
            };
            Button buttong = FindViewById<Button>(Resource.Id.KrishnaAartiButton);
            buttong.Click += delegate
            {
                StartActivity(typeof(KrishnaAarti));
            };
            Button buttonh = FindViewById<Button>(Resource.Id.KunjBihariJeeAartiButton);
            buttonh.Click += delegate
            {
                StartActivity(typeof(KunjBihariJeeAarti));
            };
            Button buttoni = FindViewById<Button>(Resource.Id.LaxhmiMaaAartiButton);
            buttoni.Click += delegate
            {
                StartActivity(typeof(LakshmiMaaAarti));
            };
           
        }
    }
}