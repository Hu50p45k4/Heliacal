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
    public partial class oknoHraMerkur : Form
    {
        public oknoHraMerkur()
        {

                InitializeComponent();

        }


        //vytvoření veřejného proměnného tlačítka--zkracuje to kód, protože pak stačí jedna
        //metoda pro obecné tlačítko a ta se pak v oběnách používá pro všechna tlačítka
        public Button tlacitko = null;

        //proměnné použité v kontrole složenosti
        public bool tlacitko1Spravne = false;
        public bool tlacitko2Spravne = false;
        public bool tlacitko3Spravne = false;
        public bool tlacitko4Spravne = false;
        public bool tlacitko5Spravne = false;
        public bool tlacitko6Spravne = false;
        public bool tlacitko7Spravne = false;
        public bool tlacitko8Spravne = false;

        Random nahoda = new Random();




        public void SpoctiTahy()
        {

            //počítá tahy..
            int pocetKliknuti = Convert.ToInt32(labelPocetTahu.Text);
            pocetKliknuti++;
            labelPocetTahu.Text = Convert.ToString(pocetKliknuti);

        }

        public void ZkontrolujDokonceni()
        {
            //zkontroluje umístění každého tlačítka.. pokud je na svém místě, změní hodnotu bool na true
            //pokud jsou všechna true, hra se ukončí, pokud ne, znovu se změní na false
            //není to úplně hezké řešení.. chtělo by to nějak zefektivnit..
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
            if (tlacitko4.Top == 100 && tlacitko4.Left == 0)
            {
                tlacitko4Spravne = true;
            }
            if (tlacitko5.Top == 100 && tlacitko5.Left == 100)
            {
                tlacitko5Spravne = true;
            }
            if (tlacitko6.Top == 100 && tlacitko6.Left == 200)
            {
                tlacitko6Spravne = true;
            }
            if (tlacitko7.Top == 200 && tlacitko7.Left == 0)
            {
                tlacitko7Spravne = true;
            }
            if (tlacitko8.Top == 200 && tlacitko8.Left == 100)
            {
                tlacitko8Spravne = true;
            }

            if (tlacitko1Spravne && tlacitko2Spravne && tlacitko3Spravne && tlacitko4Spravne && tlacitko5Spravne && tlacitko6Spravne && tlacitko7Spravne && tlacitko8Spravne)
            {
                
                timerMerkur.Enabled = false;

                int pocetTahu = Convert.ToInt32(labelPocetTahu.Text);
                int casc = Convert.ToInt32(labelCas.Text);
                tridaPromenne.posledniCas = casc;
                tridaPromenne.posledniPocetTahu = pocetTahu;
                int skore = 10000 / (pocetTahu + casc);
                
                //nahradí nejvyšší počet tahů, pokud je vyšší
                if (skore> Properties.Settings.Default.skoreMerkur)
                {
                    Properties.Settings.Default.skoreMerkur = skore;
                }

                tridaPromenne.skorePosledni = skore;


                //zapíše hodnoty do txt souboru pro další hru a načtení skóre
                TextWriter tw = new StreamWriter("skoreMerkur.txt");
                tw.WriteLine(Convert.ToString(Properties.Settings.Default.skoreMerkur));
                tw.Close();

                //kvůli určení levelu při dalším spuštění
                TextWriter wt = new StreamWriter("merkurVyplneny.txt");
                wt.WriteLine("OK");
                wt.Close();


                //pokud byl level hrán poprvé, zobrazí se okno s gratulací a uloží se level, pokud ne,
                //pouze se zobrazí dosažené skóre, čas a počet tahů
                if (tridaPromenne.merkurVyplneny==false)
                {
                    oknoGratulujeme gratulujeme = new oknoGratulujeme();
                    gratulujeme.Show();
                    tridaPromenne.level = 1;
                }
                else
                {
                    oknoOznameni oznameni = new oknoOznameni();
                    oznameni.Show();
                }

                oknoHerni.hudbaPriHre.Stop();
                if (tridaPromenne.hudba == true)
                {
                    oknoHerni.hudbaOkno.PlayLooping();
                }

                tridaPromenne.merkurVyplneny = true;
                tridaPromenne.praveSeHraje = false;
                this.Hide();

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
            }
        }

        public void Zamichej()
        {

            //uloží počet tahů před mícháním - hlavně kvůli míchání během hry
            tridaPromenne.posledniPocetTahu = Convert.ToInt32(labelPocetTahu.Text);


            //pomocí náhodně losovaného 1/0 se postiská několik tlačítek.. průměrně se
            //při takovémto opakování stiskne asi 1300x, což je, myslím, dostačující
            for (int i = 0; i < 1000; i++)
            {
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

            //vrácení počtu tahů na rozumnou hodnotu
            labelPocetTahu.Text = Convert.ToString(tridaPromenne.posledniPocetTahu);
           
        }

        public void Stiskni()
        {
            //práce s proměnným tlačítkem
            //pouze se zjistí, jestli je vedle tlačítka díra, a pokud ano, vymění si místa
            //proměnná vyskaTlacitka by v této verzi nebyla potřeba, je tu jen kvůli tomu,
            //že jsem původně chtěla velikost tlačítek měnit

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

        private void tlacitko1_Click(object sender, EventArgs e)
        {

            //obecné tlačítko se nahradí konkrétním a provede se stisknutí
            tlacitko = tlacitko1;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko2_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko2;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko3_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko3;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko4_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko4;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko5_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko5;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko6_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko6;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko7_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko7;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitko8_Click(object sender, EventArgs e)
        {
            tlacitko = tlacitko8;
            Stiskni();
            ZkontrolujDokonceni();
        }

        private void tlacitkoHrat_Click(object sender, EventArgs e)
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
            tlacitkoDira.Enabled = true;
            tlacitkoHrat.Enabled = false;
            timerMerkur.Enabled = true;
            tlacitkoZamichat.Enabled = true;

        }

        private void tlacitkoVzdat_Click(object sender, EventArgs e)
        {
            //předčasné ukončení hry.. možná by to ještě chtělo nějakou ujišťující otázku??
            timerMerkur.Enabled = false;
            tridaPromenne.praveSeHraje = false;
            oknoHerni.hudbaPriHre.Stop();
            if (tridaPromenne.hudba == true)
            {
                oknoHerni.hudbaOkno.PlayLooping();
            }
            Hide();

        }

        private void timerMerkur_Tick(object sender, EventArgs e)
        {

            //počítá to čas.. po vteřinách.. v tom by se asi dalo docela podvádět
            //nezobrazuje se to na minuty a tak.. ale takhle je to takový číselný..
            int cas = Convert.ToInt32(labelCas.Text);
            cas++;
            labelCas.Text = Convert.ToString(cas);
            
        }

        private void tlacitkoZamichat_Click(object sender, EventArgs e)
        {
            Zamichej();
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
