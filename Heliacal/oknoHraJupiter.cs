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
    public partial class oknoHraJupiter : Form
    {
        public oknoHraJupiter()
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
            if (tlacitko6.Top == 100 && tlacitko6.Left == 0)
            {
                tlacitko6Spravne = true;
            }
            if (tlacitko7.Top == 100 && tlacitko7.Left == 100)
            {
                tlacitko7Spravne = true;
            }
            if (tlacitko8.Top == 100 && tlacitko8.Left == 200)
            {
                tlacitko8Spravne = true;
            }
            if (tlacitko9.Top == 100 && tlacitko9.Left == 300)
            {
                tlacitko9Spravne = true;
            }
            if (tlacitko10.Top == 100 && tlacitko10.Left == 400)
            {
                tlacitko10Spravne = true;
            }
            if (tlacitko11.Top == 200 && tlacitko11.Left == 0)
            {
                tlacitko11Spravne = true;
            }
            if (tlacitko12.Top == 200 && tlacitko12.Left == 100)
            {
                tlacitko12Spravne = true;
            }
            if (tlacitko13.Top == 200 && tlacitko13.Left == 200)
            {
                tlacitko13Spravne = true;
            }
            if (tlacitko14.Top == 200 && tlacitko14.Left == 300)
            {
                tlacitko14Spravne = true;
            }
            if (tlacitko15.Top == 200 && tlacitko15.Left == 400)
            {
                tlacitko15Spravne = true;
            }
            if (tlacitko16.Top == 300 && tlacitko16.Left == 0)
            {
                tlacitko16Spravne = true;
            }
            if (tlacitko17.Top == 300 && tlacitko17.Left == 100)
            {
                tlacitko17Spravne = true;
            }
            if (tlacitko18.Top == 300 && tlacitko18.Left == 200)
            {
                tlacitko18Spravne = true;
            }
            if (tlacitko19.Top == 300 && tlacitko19.Left == 300)
            {
                tlacitko19Spravne = true;
            }
            if (tlacitko20.Top == 300 && tlacitko20.Left == 400)
            {
                tlacitko20Spravne = true;
            }
            if (tlacitko21.Top == 400 && tlacitko21.Left == 0)
            {
                tlacitko21Spravne = true;
            }
            if (tlacitko22.Top == 400 && tlacitko22.Left == 100)
            {
                tlacitko22Spravne = true;
            }
            if (tlacitko23.Top == 400 && tlacitko23.Left == 200)
            {
                tlacitko23Spravne = true;
            }
            if (tlacitko24.Top == 400 && tlacitko24.Left == 300)
            {
                tlacitko24Spravne = true;
            }





            if (tlacitko1Spravne && tlacitko2Spravne && tlacitko3Spravne && tlacitko4Spravne &&
                tlacitko5Spravne && tlacitko6Spravne && tlacitko7Spravne && tlacitko8Spravne &&
                tlacitko9Spravne && tlacitko10Spravne && tlacitko11Spravne && tlacitko12Spravne &&
                tlacitko13Spravne && tlacitko14Spravne && tlacitko15Spravne && tlacitko16Spravne &&
                tlacitko17Spravne && tlacitko18Spravne && tlacitko19Spravne && tlacitko20Spravne &&
                tlacitko21Spravne && tlacitko22Spravne && tlacitko23Spravne && tlacitko24Spravne)

            {

                timerJupiter.Enabled = false;

                int pocetTahu = Convert.ToInt32(labelPocetTahu.Text);
                int casc = Convert.ToInt32(labelCas.Text);
                int skore = 50000 / (pocetTahu +casc);
                tridaPromenne.posledniCas = casc;
                tridaPromenne.posledniPocetTahu = pocetTahu;

                if (skore > Properties.Settings.Default.skoreJupiter)
                {
                    Properties.Settings.Default.skoreJupiter = skore;
                }

                tridaPromenne.skorePosledni = skore;

                TextWriter tw = new StreamWriter("skoreJupiter.txt");
                tw.WriteLine(Convert.ToString(Properties.Settings.Default.skoreJupiter));
                tw.Close();

                TextWriter wt = new StreamWriter("jupiterVyplneny.txt");
                wt.WriteLine("OK");
                wt.Close();

                if (tridaPromenne.jupiterVyplneny == false)
                {
                    oknoGratulujeme gratulujeme = new oknoGratulujeme();
                    gratulujeme.Show();
                    tridaPromenne.level = 5;
                }
                else
                {
                    oknoOznameni oznameni = new oknoOznameni();
                    oznameni.Show();

                }


                tridaPromenne.jupiterVyplneny = true;
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



            }
        }

        public void Zamichej()
        {
            tridaPromenne.posledniPocetTahu = Convert.ToInt32(labelPocetTahu.Text);

            for (int i = 0; i < 1000; i++)
            {


 
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





            tlacitkoDira.Enabled = true;
            tlacitkoHrat.Enabled = false;
            timerJupiter.Enabled = true;
            tlacitkoZamichat.Enabled = true;
            tlacitkoDira.Visible = true;
        }

        private void tlacitkoVzdat_Click(object sender, EventArgs e)
        {
            timerJupiter.Enabled = false;
            tridaPromenne.praveSeHraje = false;
            oknoHerni.hudbaPriHre.Stop();
            if (tridaPromenne.hudba == true)
            {
                oknoHerni.hudbaOkno.PlayLooping();
            }
            Hide();

        }

        private void timerJupiter_Tick(object sender, EventArgs e)
        {
            int cas = Convert.ToInt32(labelCas.Text);
            cas++;
            labelCas.Text = Convert.ToString(cas);


        }

        private void tlacitkoZamichat_Click(object sender, EventArgs e)
        {
            Zamichej();
        }

        private void tlacitko10_Click(object sender, MouseEventArgs e)
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
