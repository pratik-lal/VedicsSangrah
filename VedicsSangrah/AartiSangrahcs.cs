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
    [Activity(Label = "आरती संग्रह")]
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
            Button buttonj = FindViewById<Button>(Resource.Id.ParvatiMaaAartiButton);
            buttonj.Click += delegate
            {
                StartActivity(typeof(ParvatiJeeAarti));
            };
            Button buttonk = FindViewById<Button>(Resource.Id.RadhaJeeAartiButton);
            buttonk.Click += delegate
            {
                StartActivity(typeof(RadhaJeeAarti));
            };
            Button buttonl = FindViewById<Button>(Resource.Id.RamchandraJeeAartiButton);
            buttonl.Click += delegate
            {
                StartActivity(typeof(RamchandraAarti));
            };
            Button buttonm = FindViewById<Button>(Resource.Id.MataRaniSatiAartiButton);
            buttonm.Click += delegate
            {
                StartActivity(typeof(RaniSatiDeviJee));
            };
            Button buttonn = FindViewById<Button>(Resource.Id.SaiBabaAartiButton);
            buttonn.Click += delegate
            {
                StartActivity(typeof(SaibabaAarti));
            };
            Button buttono = FindViewById<Button>(Resource.Id.SantoshiMaaAartiButton);
            buttono.Click += delegate
            {
                StartActivity(typeof(SantoshiMataAarti));
            };
            Button buttonp = FindViewById<Button>(Resource.Id.SaraswatiPrarthnaButton);
            buttonp.Click += delegate
            {
                StartActivity(typeof(SaraswatiPrarthna));
            };
            Button buttonq = FindViewById<Button>(Resource.Id.SatyaNarayanJeeAartiButton);
            buttonq.Click += delegate
            {
                StartActivity(typeof(SatyaNarayanJeeAarti));
            };
            Button buttonr = FindViewById<Button>(Resource.Id.SeetaMataAartiButton);
            buttonr.Click += delegate
            {
                StartActivity(typeof(SeetaJeeAarti));
            };
            Button buttons = FindViewById<Button>(Resource.Id.ShaniDevAartiButton);
            buttons.Click += delegate
            {
                StartActivity(typeof(ShaniDevJeeAarti));
            };
            Button buttont = FindViewById<Button>(Resource.Id.ShivJeeAartiButton);
            buttont.Click += delegate
            {
                StartActivity(typeof(ShivJeeAarti));
            };
            Button buttonu = FindViewById<Button>(Resource.Id.ShyamBabaAartiButton);
            buttonu.Click += delegate
            {
                StartActivity(typeof(ShyamBabaAarti));
            };
            Button buttonv = FindViewById<Button>(Resource.Id.SuryaDevAartiButton);
            buttonv.Click += delegate
            {
                StartActivity(typeof(SuryaDevAarti));
            };
            Button buttonw = FindViewById<Button>(Resource.Id.VishnuJeeAartiButton);
            buttonw.Click += delegate
            {
                StartActivity(typeof(VishnuJeeAarti));
            };
            Button buttonx = FindViewById<Button>(Resource.Id.VrihaspatiDevAartiButton);
            buttonx.Click += delegate
            {
                StartActivity(typeof(VrihaspatiDevAarti));
            };
        }
    }
}