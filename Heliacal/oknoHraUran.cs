using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Heliacal
{
    public partial class oknoHraUran : Form
    {
        public oknoHraUran()
        {
            InitializeComponent();
        }

        public Button tlacitko = null;
        public bool tlacitko1Spravne = false;
        public bool tlacitko2Spravne = false;
        public bool tlacitko3Spravne = false;
        public bool tlacitko4Spravne = false;
        public bool tlacitko5Spravne = false;
        public bool tlacitko6Spravne = false;
        public bool tlacitko7Spravne = false;
        public bool tlacitko8Spravne = false;
        public bool tlacitko9Spravne = false;
        public bool tlacitko10Spravne = false;
        public bool tlacitko11Spravne = false;
        public bool tlacitko12Spravne = false;
        public bool tlacitko13Spravne = false;
        public bool tlacitko14Spravne = false;
        public bool tlacitko15Spravne = false;
        public bool tlacitko16Spravne = false;
        public bool tlacitko17Spravne = false;
        public bool tlacitko18Spravne = false;
        public bool tlacitko19Spravne = false;
        public bool tlacitko20Spravne = false;
        public bool tlacitko21Spravne = false;
        public bool tlacitko22Spravne = false;
        public bool tlacitko23Spravne = false;
        public bool tlacitko24Spravne = false;
        public bool tlacitko25Spravne = false;
        public bool tlacitko26Spravne = false;
        public bool tlacitko27Spravne = false;
        public bool tlacitko28Spravne = false;
        public bool tlacitko29Spravne = false;
        public bool tlacitko30Spravne = false;
        public bool tlacitko31Spravne = false;
        public bool tlacitko32Spravne = false;
        public bool tlacitko33Spravne = false;
        public bool tlacitko34Spravne = false;
        public bool tlacitko35Spravne = false;





        Random nahoda = new Random();


        public void SpoctiTahy()
        {
            int pocetKliknuti = Convert.ToInt32(labelPocetTahu.Text);
            pocetKliknuti++;
            labelPocetTahu.Text = Convert.ToString(pocetKliknuti);

        }



        public void ZkontrolujDokonceni()
        {



            if (tlacitko1.Top == 0 && tlacitko1.Left == 0)
            {
                tlacitko1Spravne = true;
            }
            if (tlacitko2.Top == 0 && tlacitko2.Left == 100)
            {
                tlacitko2Spravne = true;
            }
            if (tlacitko3.Top == 0 && tlacitko3.Left == 200)
            {
                tlacitko3Spravne = true;
            }
            if (tlacitko4.Top == 0 && tlacitko4.Left == 300)
            {
                tlacitko4Spravne = true;
            }
            if (tlacitko5.Top == 0 && tlacitko5.Left == 400)
            {
                tlacitko5Spravne = true;
            }
            if (tlacitko6.Top == 0 && tlacitko6.Left == 500)
            {
                tlacitko6Spravne = true;
            }
            if (tlacitko7.Top == 100 && tlacitko7.Left == 0)
            {
                tlacitko7Spravne = true;
            }
            if (tlacitko8.Top == 100 && tlacitko8.Left == 100)
            {
                tlacitko8Spravne = true;
            }
            if (tlacitko9.Top == 100 && tlacitko9.Left == 200)
            {
                tlacitko9Spravne = true;
            }
            if (tlacitko10.Top == 100 && tlacitko10.Left == 300)
            {
                tlacitko10Spravne = true;
            }
            if (tlacitko11.Top == 100 && tlacitko11.Left == 400)
            {
                tlacitko11Spravne = true;
            }
            if (tlacitko12.Top == 100 && tlacitko12.Left == 500)
            {
                tlacitko12Spravne = true;
            }
            if (tlacitko13.Top == 200 && tlacitko13.Left == 0)
            {
                tlacitko13Spravne = true;
            }
            if (tlacitko14.Top == 200 && tlacitko14.Left == 100)
            {
                tlacitko14Spravne = true;
            }
            if (tlacitko15.Top == 200 && tlacitko15.Left == 200)
            {
                tlacitko15Spravne = true;
            }
            if (tlacitko16.Top == 200 && tlacitko16.Left == 300)
            {
                tlacitko16Spravne = true;
            }
            if (tlacitko17.Top == 200 && tlacitko17.Left == 400)
            {
                tlacitko17Spravne = true;
            }
            if (tlacitko18.Top == 200 && tlacitko18.Left == 500)
            {
                tlacitko18Spravne = true;
            }
            if (tlacitko19.Top == 300 && tlacitko19.Left == 0)
            {
                tlacitko19Spravne = true;
            }
            if (tlacitko20.Top == 300 && tlacitko20.Left == 100)
            {
                tlacitko20Spravne = true;
            }
            if (tlacitko21.Top == 300 && tlacitko21.Left == 200)
            {
                tlacitko21Spravne = true;
            }
            if (tlacitko22.Top == 300 && tlacitko22.Left == 300)
            {
                tlacitko22Spravne = true;
            }
            if (tlacitko23.Top == 300 && tlacitko23.Left == 400)
            {
                tlacitko23Spravne = true;
            }
            if (tlacitko24.Top == 300 && tlacitko24.Left == 500)
            {
                tlacitko24Spravne = true;
            }
            if (tlacitko25.Top == 400 && tlacitko25.Left == 0)
            {
                tlacitko25Spravne = true;
            }
            if (tlacitko26.Top == 400 && tlacitko26.Left == 100)
            {
                tlacitko26Spravne = true;
            }
            if (tlacitko27.Top == 400 && tlacitko27.Left == 200)
            {
                tlacitko27Spravne = true;
            }
            if (tlacitko28.Top == 400 && tlacitko28.Left == 300)
            {
                tlacitko28Spravne = true;
            }
            if (tlacitko29.Top == 400 && tlacitko29.Left == 400)
            {
                tlacitko29Spravne = true;
            }
            if (tlacitko30.Top == 400 && tlacitko30.Left == 500)
            {
                tlacitko30Spravne = true;
            }
            if (tlacitko31.Top == 500 && tlacitko31.Left == 0)
            {
                tlacitko31Spravne = true;
            }
            if (tlacitko32.Top == 500 && tlacitko32.Left == 100)
            {
                tlacitko32Spravne = true;
            }
            if (tlacitko33.Top == 500 && tlacitko33.Left == 200)
            {
                tlacitko33Spravne = true;
            }
            if (tlacitko34.Top == 500 && tlacitko34.Left == 300)
            {
                tlacitko34Spravne = true;
            }
            if (tlacitko35.Top == 500 && tlacitko35.Left == 400)
            {
                tlacitko35Spravne = true;
            }




            if (tlacitko1Spravne && tlacitko2Spravne && tlacitko3Spravne && tlacitko4Spravne &&
                tlacitko5Spravne && tlacitko6Spravne && tlacitko7Spravne && tlacitko8Spravne &&
                tlacitko9Spravne && tlacitko10Spravne && tlacitko11Spravne && tlacitko12Spravne &&
                tlacitko13Spravne && tlacitko14Spravne && tlacitko15Spravne && tlacitko16Spravne &&
                tlacitko17Spravne && tlacitko18Spravne && tlacitko19Spravne && tlacitko20Spravne &&
                tlacitko21Spravne && tlacitko22Spravne && tlacitko23Spravne && tlacitko24Spravne &&
                tlacitko25Spravne && tlacitko26Spravne && tlacitko27Spravne && tlacitko28Spravne &&
                tlacitko29Spravne && tlacitko30Spravne && tlacitko31Spravne && tlacitko32Spravne &&
                tlacitko33Spravne && tlacitko34Spravne && tlacitko35Spravne)

            {

                timerUran.Enabled = false;

                int pocetTahu = Convert.ToInt32(labelPocetTahu.Text);
                int casc = Convert.ToInt32(labelCas.Text);
                int skore = 70000 / (pocetTahu + casc);
                tridaPromenne.posledniCas = casc;
                tridaPromenne.posledniPocetTahu = pocetTahu;

                if (skore > Properties.Settings.Default.skoreUran)
                {
                    Properties.Settings.Default.skoreUran = skore;
                }

                tridaPromenne.skorePosledni = skore;

                TextWriter tw = new StreamWriter("skoreUran.txt");
                tw.WriteLine(Convert.ToString(Properties.Settings.Default.skoreUran));
                tw.Close();

                TextWriter wt = new StreamWriter("uranVyplneny.txt");
                wt.WriteLine("OK");
                wt.Close();

                if (tridaPromenne.uranVyplneny == false)
                {
                    oknoGratulujeme gratulujeme = new oknoGratulujeme();
                    gratulujeme.Show();
                    tridaPromenne.level = 7;
                }
                else
                {
                    oknoOznameni oznameni = new oknoOznameni();
                    oznameni.Show();

                }


                tridaPromenne.uranVyplneny = true;
                tridaPromenne.praveSeHraje = false;

                oknoHerni.hudbaPriHre.Stop();
                if (tridaPromenne.hudba == true)
                {
                    oknoHerni.hudbaOkno.PlayLooping();
                }
                Hide();



            }
            else
            {
                tlacitko1Spravne = false;
                tlacitko2Spravne = false;
                tlacitko3Spravne = false;
                tlacitko4Spravne = false;
                tlacitko5Spravne = false;
                tlacitko6Spravne = false;
                tlacitko7Spravne = false;
                tlacitko8Spravne = false;
                tlacitko9Spravne = false;
                tlacitko10Spravne = false;
                tlacitko11Spravne = false;
                tlacitko12Spravne = false;
                tlacitko13Spravne = false;
                tlacitko14Spravne = false;
                tlacitko15Spravne = false;
                tlacitko16Spravne = false;
                tlacitko17Spravne = false;
                tlacitko18Spravne = false;
                tlacitko19Spravne = false;
                tlacitko20Spravne = false;
                tlacitko21Spravne = false;
                tlacitko22Spravne = false;
                tlacitko23Spravne = false;
                tlacitko24Spravne = false;
                tlacitko25Spravne = false;
                tlacitko26Spravne = false;
                tlacitko27Spravne = false;
                tlacitko28Spravne = false;
                tlacitko29Spravne = false;
                tlacitko30Spravne = false;
                tlacitko31Spravne = false;
                tlacitko32Spravne = false;
                tlacitko33Spravne = false;
                tlacitko34Spravne = false;
                tlacitko35Spravne = false;


            }
        }

        public void Zamichej()
        {
            tridaPromenne.posledniPocetTahu = Convert.ToInt32(labelPocetTahu.Text);

            for (int i = 0; i < 1000; i++)
            {

 
                int stisknuti35 = nahoda.Next(0, 2);
                tlacitko = tlacitko35;
                if (stisknuti35 == 1)
                {
                    Stiskni();
                }
                int stisknuti34 = nahoda.Next(0, 2);
                tlacitko = tlacitko34;
                if (stisknuti34 == 1)
                {
                    Stiskni();
                }
                int stisknuti33 = nahoda.Next(0, 2);
                tlacitko = tlacitko33;
                if (stisknuti33 == 1)
                {
                    Stiskni();
                }
                int stisknuti32 = nahoda.Next(0, 2);
                tlacitko = tlacitko32;
                if (stisknuti32 == 1)
                {
                    Stiskni();
                }
                int stisknuti31 = nahoda.Next(0, 2);
                tlacitko = tlacitko31;
                if (stisknuti31 == 1)
                {
                    Stiskni();
                }
                int stisknuti30 = nahoda.Next(0, 2);
                tlacitko = tlacitko30;
                if (stisknuti30 == 1)
                {
                    Stiskni();
                }
                int stisknuti29 = nahoda.Next(0, 2);
                tlacitko = tlacitko29;
                if (stisknuti29 == 1)
                {
                    Stiskni();
                }
                int stisknuti28 = nahoda.Next(0, 2);
                tlacitko = tlacitko28;
                if (stisknuti28 == 1)
                {
                    Stiskni();
                }
                int stisknuti26 = nahoda.Next(0, 2);
                tlacitko = tlacitko26;
                if (stisknuti26 == 1)
                {
                    Stiskni();
                }
                int stisknuti25 = nahoda.Next(0, 2);
                tlacitko = tlacitko25;
                if (stisknuti25 == 1)
                {
                    Stiskni();
                }
                int stisknuti24 = nahoda.Next(0, 2);
                tlacitko = tlacitko24;
                if (stisknuti24 == 1)
                {
                    Stiskni();
                }
                int stisknuti23 = nahoda.Next(0, 2);
                tlacitko = tlacitko23;
                if (stisknuti23 == 1)
                {
                    Stiskni();
                }
                int stisknuti22 = nahoda.Next(0, 2);
                tlacitko = tlacitko22;
                if (stisknuti22 == 1)
                {
                    Stiskni();
                }
                int stisknuti21 = nahoda.Next(0, 2);
                tlacitko = tlacitko21;
                if (stisknuti21 == 1)
                {
                    Stiskni();
                }
                int stisknuti20 = nahoda.Next(0, 2);
                tlacitko = tlacitko20;
                if (stisknuti20 == 1)
                {
                    Stiskni();
                }
                int stisknuti19 = nahoda.Next(0, 2);
                tlacitko = tlacitko19;
                if (stisknuti19 == 1)
                {
                    Stiskni();
                }
                int stisknuti18 = nahoda.Next(0, 2);
                tlacitko = tlacitko18;
                if (stisknuti18 == 1)
                {
                    Stiskni();
                }
                int stisknuti17 = nahoda.Next(0, 2);
                tlacitko = tlacitko17;
                if (stisknuti17 == 1)
                {
                    Stiskni();
                }
                int stisknuti16 = nahoda.Next(0, 2);
                tlacitko = tlacitko16;
                if (stisknuti16 == 1)
                {
                    Stiskni();
                }
                int stisknuti15 = nahoda.Next(0, 2);
                tlacitko = tlacitko15;
                if (stisknuti15 == 1)
                {
                    Stiskni();
                }
                int stisknuti14 = nahoda.Next(0, 2);
                tlacitko = tlacitko14;
                if (stisknuti14 == 1)
                {
                    Stiskni();
                }
                int stisknuti13 = nahoda.Next(0, 2);
                tlacitko = tlacitko13;
                if (stisknuti13 == 1)
                {
                    Stiskni();
                }
                int stisknuti12 = nahoda.Next(0, 2);
                tlacitko = tlacitko12;
                if (stisknuti12 == 1)
                {
                    Stiskni();
                }
                int stisknuti11 = nahoda.Next(0, 2);
                tlacitko = tlacitko11;
                if (stisknuti11 == 1)
                {
                    Stiskni();
                }
                int stisknuti10 = nahoda.Next(0, 2);
                tlacitko = tlacitko10;
                if (stisknuti10 == 1)
                {
                    Stiskni();
                }
                int stisknuti9 = nahoda.Next(0, 2);
                tlacitko = tlacitko9;
                if (stisknuti9 == 1)
                {
                    Stiskni();
                }
                int stisknuti8 = nahoda.Next(0, 2);
                tlacitko = tlacitko8;
                if (stisknuti8 == 1)
                {
                    Stiskni();
                }
                int stisknuti7 = nahoda.Next(0, 2);
                tlacitko = tlacitko7;
                if (stisknuti7 == 1)
                {
                    Stiskni();
                }
                int stisknuti6 = nahoda.Next(0, 2);
                tlacitko = tlacitko6;
                if (stisknuti6 == 1)
                {
                    Stiskni();
                }
                int stisknuti5 = nahoda.Next(0, 2);
                tlacitko = tlacitko5;
                if (stisknuti5 == 1)
                {
                    Stiskni();
                }
                int stisknuti4 = nahoda.Next(0, 2);
                tlacitko = tlacitko4;
                if (stisknuti4 == 1)
                {
                    Stiskni();
                }
                int stisknuti3 = nahoda.Next(0, 2);
                tlacitko = tlacitko3;
                if (stisknuti3 == 1)
                {
                    Stiskni();
                }
                int stisknuti2 = nahoda.Next(0, 2);
                tlacitko = tlacitko2;
                if (stisknuti2 == 1)
                {
                    Stiskni();
                }
                int stisknuti1 = nahoda.Next(0, 2);
                tlacitko = tlacitko1;
                if (stisknuti1 == 1)
                {
                    Stiskni();
                }
            }

            labelPocetTahu.Text = Convert.ToString(tridaPromenne.posledniPocetTahu);

        }

        public void Stiskni()
        {
            int tlacitkoY = tlacitko.Top;
            int tlacitkoX = tlacitko.Left;
            int sirkatlacitka = tlacitko.Right - tlacitko.Left;
            int vyskatlacitka = tlacitko.Bottom - tlacitko.Top;
            int diraX = tlacitkoDira.Left;
            int diraY = tlacitkoDira.Top;

            if (tlacitkoX == diraX)
            {

                if (diraY == (tlacitkoY + vyskatlacitka))
                {
                    tlacitko.Location = new Point(tlacitkoX, tlacitkoY + vyskatlacitka);
                    tlacitkoDira.Location = new Point(diraX, diraY - vyskatlacitka);
                    SpoctiTahy();
                }
                if (diraY == (tlacitkoY - vyskatlacitka))
                {
                    tlacitko.Location = new Point(tlacitkoX, tlacitkoY - vyskatlacitka);
                    tlacitkoDira.Location = new Point(diraX, diraY + vyskatlacitka);
                    SpoctiTahy();
                }


            }

            if (tlacitkoY == diraY)
            {

                if (diraX == (tlacitkoX + sirkatlacitka))
                {
                    tlacitko.Location = new Point(tlacitkoX + sirkatlacitka, tlacitkoY);
                    tlacitkoDira.Location = new Point(diraX - sirkatlacitka, diraY);
                    SpoctiTahy();

                }
                if (diraX == (tlacitkoX - sirkatlacitka))
                {
                    tlacitko.Location = new Point(tlacitkoX - sirkatlacitka, tlacitkoY);
                    tlacitkoDira.Location = new Point(diraX + sirkatlacitka, diraY);
                    SpoctiTahy();
                }

            }
        }

        private void tlacitko1_Click(object sender, MouseEventArgs e)
        {
            tlacitko = tlacitko1;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko2_Click(object sender, MouseEventArgs e)
        {
            tlacitko = tlacitko2;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko3_Click(object sender, MouseEventArgs e)
        {
            tlacitko = tlacitko3;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko4_Click(object sender, MouseEventArgs e)
        {
            tlacitko = tlacitko4;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko5_Click(object sender, MouseEventArgs e)
        {
            tlacitko = tlacitko5;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko6_Click(object sender, MouseEventArgs e)
        {
            tlacitko = tlacitko6;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko7_Click(object sender, MouseEventArgs e)
        {
            tlacitko = tlacitko7;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko8_Click(object sender, MouseEventArgs e)
        {
            tlacitko = tlacitko8;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitkoHrat_Click(object sender, MouseEventArgs e)
        {
            Zamichej();
            labelPocetTahu.Text = "0";
            tlacitko1.Enabled = true;
            tlacitko2.Enabled = true;
            tlacitko3.Enabled = true;
            tlacitko4.Enabled = true;
            tlacitko5.Enabled = true;
            tlacitko6.Enabled = true;
            tlacitko7.Enabled = true;
            tlacitko8.Enabled = true;
            tlacitko9.Enabled = true;
            tlacitko10.Enabled = true;
            tlacitko11.Enabled = true;
            tlacitko12.Enabled = true;
            tlacitko13.Enabled = true;
            tlacitko14.Enabled = true;
            tlacitko15.Enabled = true;
            tlacitko16.Enabled = true;
            tlacitko17.Enabled = true;
            tlacitko18.Enabled = true;
            tlacitko19.Enabled = true;
            tlacitko20.Enabled = true;
            tlacitko21.Enabled = true;
            tlacitko22.Enabled = true;
            tlacitko23.Enabled = true;
            tlacitko24.Enabled = true;
            tlacitko25.Enabled = true;
            tlacitko26.Enabled = true;
            tlacitko27.Enabled = true;
            tlacitko28.Enabled = true;
            tlacitko29.Enabled = true;
            tlacitko30.Enabled = true;
            tlacitko31.Enabled = true;
            tlacitko32.Enabled = true;
            tlacitko33.Enabled = true;
            tlacitko34.Enabled = true;
            tlacitko35.Enabled = true;




            tlacitkoDira.Enabled = true;
            tlacitkoHrat.Enabled = false;
            timerUran.Enabled = true;
            tlacitkoZamichat.Enabled = true;
            tlacitkoDira.Visible = true;
        }

        private void tlacitkoVzdat_Click(object sender, EventArgs e)
        {
            timerUran.Enabled = false;
            tridaPromenne.praveSeHraje = false;
            oknoHerni.hudbaPriHre.Stop();
            if (tridaPromenne.hudba == true)
            {
                oknoHerni.hudbaOkno.PlayLooping();
            }
            Hide();

        }

        private void timerUran_Tick(object sender, EventArgs e)
        {
            int cas = Convert.ToInt32(labelCas.Text);
            cas++;
            labelCas.Text = Convert.ToString(cas);


        }

        private void tlacitkoZamichat_Click(object sender, MouseEventArgs e)
        {
            tlacitkoDira.Visible = false;
            Zamichej();
            tlacitkoDira.Visible = true;

        }

        private void tlacitko10_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko10;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko9_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko9;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko11_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko11;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko12_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko12;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko13_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko13;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko14_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko14;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko15_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko15;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko16_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko16;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko17_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko17;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko18_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko18;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko19_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko19;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko20_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko20;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko21_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko21;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko22_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko22;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko23_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko23;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko24_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko24;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko25_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko25;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko26_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko26;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko27_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko27;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko28_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko28;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko29_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko29;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko30_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko30;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko31_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko31;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko32_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko32;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko33_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko33;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko34_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko34;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko35_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko35;
            Stiskni();
            ZkontrolujDokonceni();
        }
        private void tlacitkoHrat_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            tlacitkoHrat.FlatAppearance.BorderSize = 2;
        }

        private void tlacitkoHrat_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoHrat.FlatAppearance.BorderSize = 1;
        }


        private void tlacitkoVzdat_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            tlacitkoVzdat.FlatAppearance.BorderSize = 2;
        }

        private void tlacitkoVzdat_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoVzdat.FlatAppearance.BorderSize = 1;
        }

        private void tlacitkoZamichat_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            tlacitkoZamichat.FlatAppearance.BorderSize = 2;
        }

        private void tlacitkoZamichat_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoZamichat.FlatAppearance.BorderSize = 2;
        }

    }



}
