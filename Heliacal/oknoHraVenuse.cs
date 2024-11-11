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
    public partial class oknoHraVenuse : Form
    {
        public oknoHraVenuse()
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
            if (tlacitko5.Top == 100 && tlacitko5.Left ==0)
            {
                tlacitko5Spravne = true;
            }
            if (tlacitko6.Top == 100 && tlacitko6.Left == 100)
            {
                tlacitko6Spravne = true;
            }
            if (tlacitko7.Top == 100 && tlacitko7.Left == 200)
            {
                tlacitko7Spravne = true;
            }
            if (tlacitko8.Top == 100 && tlacitko8.Left == 300)
            {
                tlacitko8Spravne = true;
            }
            if (tlacitko9.Top == 200 && tlacitko9.Left == 0)
            {
                tlacitko9Spravne = true;
            }
            if (tlacitko10.Top == 200 && tlacitko10.Left == 100)
            {
                tlacitko10Spravne = true;
            }
            if (tlacitko11.Top == 200 && tlacitko11.Left == 200)
            {
                tlacitko11Spravne = true;
            }






            if (tlacitko1Spravne && tlacitko2Spravne && tlacitko3Spravne && tlacitko4Spravne &&
                tlacitko5Spravne && tlacitko6Spravne && tlacitko7Spravne && tlacitko8Spravne &&
                tlacitko9Spravne && tlacitko10Spravne && tlacitko11Spravne)

            {

                timerVenuse.Enabled = false;

                int pocetTahu = Convert.ToInt32(labelPocetTahu.Text);
                int casc = Convert.ToInt32(labelCas.Text);
                int skore = 20000/ (pocetTahu+ casc);
                tridaPromenne.posledniCas = casc;
                tridaPromenne.posledniPocetTahu = pocetTahu;

                if (skore > Properties.Settings.Default.skoreVenuse)
                {
                    Properties.Settings.Default.skoreVenuse = skore;
                }

                tridaPromenne.skorePosledni = skore;

                TextWriter tw = new StreamWriter("skoreVenuse.txt");
                tw.WriteLine(Convert.ToString(Properties.Settings.Default.skoreVenuse));
                tw.Close();

                TextWriter wt = new StreamWriter("venuseVyplneny.txt");
                wt.WriteLine("OK");
                wt.Close();

                if (tridaPromenne.venuseVyplneny == false)
                {
                    oknoGratulujeme gratulujeme = new oknoGratulujeme();
                    gratulujeme.Show();
                    tridaPromenne.level = 2;
                }
                else
                {
                    oknoOznameni oznameni = new oknoOznameni();
                    oznameni.Show();

                }


                tridaPromenne.venuseVyplneny = true;
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


            }
        }

        public void Zamichej()
        {
            tridaPromenne.posledniPocetTahu = Convert.ToInt32(labelPocetTahu.Text);

            for (int i = 0; i < 1000; i++)
            {




 
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






            tlacitkoDira.Enabled = true;
            tlacitkoHrat.Enabled = false;
            timerVenuse.Enabled = true;
            tlacitkoZamichat.Enabled = true;
            tlacitkoDira.Visible = true;
        }

        private void tlacitkoVzdat_Click(object sender, EventArgs e)
        {
            timerVenuse.Enabled = false;
            tridaPromenne.praveSeHraje = false;
            oknoHerni.hudbaPriHre.Stop();
            if (tridaPromenne.hudba == true)
            {
                oknoHerni.hudbaOkno.PlayLooping();
            }
            Hide();

        }

        private void timerVenuse_Tick(object sender, EventArgs e)
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
