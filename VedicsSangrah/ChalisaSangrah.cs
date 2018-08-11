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
            button14.Click += delegate
            {
                StartActivity(typeof(KaaliMaaChalisa));
            };

            Button button15 = FindViewById<Button>(Resource.Id.KhatuShyamChalisaButton);
            button15.Click += delegate
            {
                StartActivity(typeof(KhatuShyamChalisa));
            };

            Button button16 = FindViewById<Button>(Resource.Id.KuberChalisaButton);
            button16.Click += delegate
            {
                StartActivity(typeof(KuberChalisa));
            };

            Button button17 = FindViewById<Button>(Resource.Id.LakshmiChalisaButton);
            button17.Click += delegate
            {
                StartActivity(typeof(LakshmiChalisa));
            };

            Button button18 = FindViewById<Button>(Resource.Id.MahaKaliMaaChalisaButton);
            button18.Click += delegate
            {
                StartActivity(typeof(MahaKaliMaaChalisa));
            };

            Button button19 = FindViewById<Button>(Resource.Id.NavgrahChalisaButton);
            button19.Click += delegate
            {
                StartActivity(typeof(NavgrahChalisa));
            };

            Button button20 = FindViewById<Button>(Resource.Id.ParvatiChalisaButton);
            button20.Click += delegate
            {
                StartActivity(typeof(ParvatiChalisa));
            };

            Button button21 = FindViewById<Button>(Resource.Id.RadhaChalisaButton);
            button21.Click += delegate
            {
                StartActivity(typeof(RadhaChalisa));
            };

            Button button22 = FindViewById<Button>(Resource.Id.RamChalisaButton);
            button22.Click += delegate
            {
                StartActivity(typeof(RamChalisa));
            };

            Button button23 = FindViewById<Button>(Resource.Id.SaiChalisaButton);
            button23.Click += delegate
            {
                StartActivity(typeof(SaiChalisa));
            };

            Button button24 = FindViewById<Button>(Resource.Id.SantoshiMaaChalisaButton);
            button24.Click += delegate
            {
                StartActivity(typeof(SantoshiMaaChalisa));
            };

            Button button25 = FindViewById<Button>(Resource.Id.ShreeShaniDevChalisaButton);
            button25.Click += delegate
            {
                StartActivity(typeof(ShreeShaniDevChalisa));
            };

            Button button26 = FindViewById<Button>(Resource.Id.SaraswatiChalisaButton);
            button26.Click += delegate
            {
                StartActivity(typeof(SaraswatiChalisa));
            };

            Button button27 = FindViewById<Button>(Resource.Id.SheetlaChalisaButton);
            button27.Click += delegate
            {
                StartActivity(typeof(SheetlaChalisa));
            };

            Button button28 = FindViewById<Button>(Resource.Id.SuryaChalisaButton);
            button28.Click += delegate
            {
                StartActivity(typeof(SuryaChalisa));
            };

            Button button29 = FindViewById<Button>(Resource.Id.TulsiChalisaButton);
            button29.Click += delegate
            {
                StartActivity(typeof(TulsiChalisa));
            };

            Button button30 = FindViewById<Button>(Resource.Id.VashnoDeviChalisaButton);
            button30.Click += delegate
            {
                StartActivity(typeof(VashnoDeviChalisa));
            };

            Button button31 = FindViewById<Button>(Resource.Id.VindhyeshwariChalisaButton);
            button31.Click += delegate
            {
                StartActivity(typeof(VindhyeshwariChalisa));
            };

            Button button32 = FindViewById<Button>(Resource.Id.VishnuChalisaButton);
            button32.Click += delegate
            {
                StartActivity(typeof(VishnuChalisa));
            };
        }
    }
}