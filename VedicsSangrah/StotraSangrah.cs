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
    [Activity(Label = "StotraSangrah")]
    public class StotraSangrah : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.StotraSangrah);
            Button button1 = FindViewById<Button>(Resource.Id.Achyutashtakam);
            button1.Click += delegate
            {
                StartActivity(typeof(AchyutashtakamStotram));
            };
            Button button2 = FindViewById<Button>(Resource.Id.AdityaHridayaStotram);
            button2.Click += delegate
            {
                StartActivity(typeof(AdityahRidayastotra));
            };
            Button button3 = FindViewById<Button>(Resource.Id.AshtaLakshmiStotram);
            button3.Click += delegate
            {
                StartActivity(typeof(Aashtalaxmistotra));
            };
            Button button4 = FindViewById<Button>(Resource.Id.DwadashJyotirLingam);
            button4.Click += delegate
            {
                StartActivity(typeof(Dwadasa_jyotirlingam));
            };
            Button button5 = FindViewById<Button>(Resource.Id.EkShlokiSundarkand);
            button5.Click += delegate
            {
                StartActivity(typeof(Eksloki_sundarkand));
            };
            Button button6 = FindViewById<Button>(Resource.Id.HariStotram);
            button6.Click += delegate
            {
                StartActivity(typeof(HariStotram));
            };
            Button button7 = FindViewById<Button>(Resource.Id.HimalaykritShivStotram);
            button7.Click += delegate
            {
                StartActivity(typeof(HimalayakritShivStotram));
            };
            Button button8 = FindViewById<Button>(Resource.Id.Lingastakam);
            button8.Click += delegate
            {
                StartActivity(typeof(Lingastakam));
            };
            Button button9 = FindViewById<Button>(Resource.Id.Madhurastakam);
            button9.Click += delegate
            {
                StartActivity(typeof(Madhurastakam));
            };
            Button button10 = FindViewById<Button>(Resource.Id.RamRakshaStotram);
            button10.Click += delegate
            {
                StartActivity(typeof(RamRakshaStotram));
            };
            Button button11 = FindViewById<Button>(Resource.Id.RamStuti);
            button11.Click += delegate
            {
                StartActivity(typeof(RamStuti));
            };
            Button button12 = FindViewById<Button>(Resource.Id.Rudrastakam);
            button12.Click += delegate
            {
                StartActivity(typeof(Rudrastakam));
            };
            Button button13 = FindViewById<Button>(Resource.Id.SankatNashakGaneshStotram);
            button13.Click += delegate
            {
                StartActivity(typeof(SankatNashakGaneshStotram));
            };
            Button button14 = FindViewById<Button>(Resource.Id.SaraswatiStotram);
            button14.Click += delegate
            {
                StartActivity(typeof(SarasVatsalStotram));
            };
            Button button15 = FindViewById<Button>(Resource.Id.ShivaPanchaksharaStotram);
            button15.Click += delegate
            {
                StartActivity(typeof(ShivPanchAksharStotram));
            };
            Button button16 = FindViewById<Button>(Resource.Id.ShivaApradhKshamapanStotram);
            button16.Click += delegate
            {
                StartActivity(typeof(ShivApradhaKshamaPrarthnaStotram));
            };
            Button button17 = FindViewById<Button>(Resource.Id.ShivaShaktiKritamGaneshStotram);
            button17.Click += delegate
            {
                StartActivity(typeof(ShivShaktiKritamGaneshStotram));
            };
            Button button18 = FindViewById<Button>(Resource.Id.ShivaTandavStotram);
            button18.Click += delegate
            {
                StartActivity(typeof(ShivTandavStotram));
            };
            Button button19 = FindViewById<Button>(Resource.Id.DurgaSaptsloki);
            button19.Click += delegate
            {
                StartActivity(typeof(ShreeSaptslokiDurga));
            };
            Button button20 = FindViewById<Button>(Resource.Id.ShivaAshtakam);
            button20.Click += delegate
            {
                StartActivity(typeof(ShreeShivashtakam));
            };
            Button button21 = FindViewById<Button>(Resource.Id.GayatriKavacham);
            button21.Click += delegate
            {
                StartActivity(typeof(ShriGayatriKavacham));
            };
            Button button22 = FindViewById<Button>(Resource.Id.HariNaamMalaStotram);
            button22.Click += delegate
            {
                StartActivity(typeof(ShriHariNaamMalaStrotram));
            };
            Button button23 = FindViewById<Button>(Resource.Id.KrishnaAshtakam);
            button23.Click += delegate
            {
                StartActivity(typeof(KrishnaAshtakam));
            };
            Button button24 = FindViewById<Button>(Resource.Id.MahaMritunjayStotram);
            button24.Click += delegate
            {
                StartActivity(typeof(MrituanjayStotram));
            };
            Button button25 = FindViewById<Button>(Resource.Id.GauriAshtotraNamavali);
            button25.Click += delegate
            {
                StartActivity(typeof(ShriGauriAshtottaraNamavali));
            };
            Button button26 = FindViewById<Button>(Resource.Id.GovindDamodarStotram);
            button26.Click += delegate
            {
                StartActivity(typeof(ShriGovindDamodarStotram));
            };
            Button button27 = FindViewById<Button>(Resource.Id.RadhaAshtakam);
            button27.Click += delegate
            {
                StartActivity(typeof(ShriRadhaAshtakam));
            };
            Button button28 = FindViewById<Button>(Resource.Id.VindhyeshwariStotram);
            button28.Click += delegate
            {
                StartActivity(typeof(VindhyeshwariStotram));
            };
            Button button29 = FindViewById<Button>(Resource.Id.VishnorAshtaVinshatiNaamStotram);
            button29.Click += delegate
            {
                StartActivity(typeof(AshtaVimsathiVishniNamaStotram));
            };
            Button button30 = FindViewById<Button>(Resource.Id.VishnoShatnaamStotram);
            button30.Click += delegate
            {
                StartActivity(typeof(VishnuShatNamStotram));
            };
        }
    }
}