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
using System.Media;

namespace Heliacal
{
    public partial class oknoHerni : Form
    {
        public oknoHerni()
        {
            InitializeComponent();
            NactiSkore();
            OdemkniDokoncene();
        }

        // vytvoření hudebního přehrávače, ke kterému je pak možno přistupovat z kteréhokoli okna.
        // Hra obsahuje dva typy hudby - pro hlavní okno a při hraní.

        public static SoundPlayer hudbaOkno = new SoundPlayer(Properties.Resources.hudba5min);
        public static SoundPlayer hudbaPriHre = new SoundPlayer(Properties.Resources.hudbaRychlejsi);

        SoundPlayer hudbaKonec = new SoundPlayer(Properties.Resources.zvukKonec);
        

        private void NactiSkore()
        {
            if (!File.Exists("skoreMerkur.txt"))
            {
                TextWriter tw = new StreamWriter("skoreMerkur.txt");
                tw.Write("0");
                tw.Close();
                
            }
            TextReader merkur = new StreamReader("skoreMerkur.txt");
            skoreMerkur.Text = merkur.ReadLine();
            Properties.Settings.Default.skoreMerkur = Convert.ToInt32(skoreMerkur.Text);
            merkur.Close();

            if (!File.Exists("skoreVenuse.txt"))
            {
                TextWriter tw = new StreamWriter("skoreVenuse.txt");
                tw.Write("0");
                tw.Close();
            }
            TextReader venuse = new StreamReader("skoreVenuse.txt");
            skoreVenuse.Text = venuse.ReadLine();
            Properties.Settings.Default.skoreVenuse = Convert.ToInt32(skoreVenuse.Text);
            venuse.Close();

            if (!File.Exists("skoreZeme.txt"))
            {
                TextWriter tw = new StreamWriter("skoreZeme.txt");
                tw.Write("0");
                tw.Close();
            }
            TextReader zeme = new StreamReader("skoreZeme.txt");
            skoreZeme.Text = zeme.ReadLine();
            Properties.Settings.Default.skoreZeme = Convert.ToInt32(skoreZeme.Text);
            zeme.Close();

            if (!File.Exists("skoreMars.txt"))
            {
                TextWriter tw = new StreamWriter("skoreMars.txt");
                tw.Write("0");
                tw.Close();
            }
            TextReader mars = new StreamReader("skoreMars.txt");
            skoreMars.Text = mars.ReadLine();
            Properties.Settings.Default.skoreMars = Convert.ToInt32(skoreMars.Text);
            mars.Close();

            if (!File.Exists("skoreJupiter.txt"))
            {
                TextWriter tw = new StreamWriter("skoreJupiter.txt");
                tw.Write("0");
                tw.Close();
            }
            TextReader jupiter = new StreamReader("skoreJupiter.txt");
            skoreJupiter.Text = jupiter.ReadLine();
            Properties.Settings.Default.skoreJupiter = Convert.ToInt32(skoreJupiter.Text);
            jupiter.Close();

            if (!File.Exists("skoreSaturn.txt"))
            {
                TextWriter tw = new StreamWriter("skoreSaturn.txt");
                tw.Write("0");
                tw.Close();
            }
            TextReader saturn = new StreamReader("skoreSaturn.txt");
            skoreSaturn.Text = saturn.ReadLine();
            Properties.Settings.Default.skoreSaturn = Convert.ToInt32(skoreSaturn.Text);
            saturn.Close();

            if (!File.Exists("skoreUran.txt"))
            {
                TextWriter tw = new StreamWriter("skoreUran.txt");
                tw.Write("0");
                tw.Close();
            }
            TextReader uran = new StreamReader("skoreUran.txt");
            skoreUran.Text = uran.ReadLine();
            Properties.Settings.Default.skoreUran = Convert.ToInt32(skoreUran.Text);
            uran.Close();

            if (!File.Exists("skoreNeptun.txt"))
            {
                TextWriter tw = new StreamWriter("skoreNeptun.txt");
                tw.Write("0");
                tw.Close();
            }
            TextReader neptun = new StreamReader("skoreNeptun.txt");
            skoreNeptun.Text = neptun.ReadLine();
            Properties.Settings.Default.skoreNeptun = Convert.ToInt32(skoreNeptun.Text);
            neptun.Close();

            int celkoveSkore = Convert.ToInt32(skoreMerkur.Text) + Convert.ToInt32(skoreVenuse.Text) +
                Convert.ToInt32(skoreZeme.Text) + Convert.ToInt32(skoreMars.Text) + Convert.ToInt32(skoreJupiter.Text) +
                Convert.ToInt32(skoreSaturn.Text) + Convert.ToInt32(skoreUran.Text) + Convert.ToInt32(skoreNeptun.Text);
            labelCelkoveSkore.Text = Convert.ToString(celkoveSkore);


           

        }

        private void OdemkniDokoncene()
        {
            // při spuštění zjistí, jaké planety byly dohrány při minulém spuštění..
            // výsledky se uloží do proměnných, které se pak mohou změnit v průběhu hry..
            // zároveň určí level hráče, který se pak využívá při vypsání planety, kterou
            // je potřeba nejprve odemknout

            if (File.Exists("merkurVyplneny.txt"))
            {
                tridaPromenne.merkurVyplneny = true;
                tridaPromenne.level = 1;
            }

            if (File.Exists("venuseVyplneny.txt"))
            {
                tridaPromenne.venuseVyplneny = true;
                tridaPromenne.level = 2;
            }

            if (File.Exists("zemeVyplneny.txt"))
            {
                tridaPromenne.zemeVyplneny = true;
                tridaPromenne.level = 3;
            }

            if (File.Exists("marsVyplneny.txt"))
            {
                tridaPromenne.marsVyplneny = true;
                tridaPromenne.level = 4;
            }

            if (File.Exists("jupiterVyplneny.txt"))
            {
                tridaPromenne.jupiterVyplneny = true;
                tridaPromenne.level = 5;
            }

            if (File.Exists("saturnVyplneny.txt"))
            {
                tridaPromenne.saturnVyplneny = true;
                tridaPromenne.level = 6;
            }

            if (File.Exists("uranVyplneny.txt"))
            {
                tridaPromenne.uranVyplneny = true;
                tridaPromenne.level = 7;
            }

            if (File.Exists("neptunVyplneny.txt"))
            {
                tridaPromenne.neptunVyplneny = true;
                tridaPromenne.level = 8;
            }



        }

        public void ZkontrolujLevel()
        {

            // zkontroluje jestli se uživatel nechce dostat do levelu, na který nemá.. ukáže upozornění pokud ano
                    switch (tridaPromenne.level)
                    {
                        case 0:
                            labelUpozorneni.Text = "Nejprve Merkur!";
                            break;
                        case 1:
                            labelUpozorneni.Text = "Nejprve Venuši!";
                            break;
                        case 2:
                            labelUpozorneni.Text = "Nejprve Zemi!";
                            break;
                        case 3:
                            labelUpozorneni.Text = "Nejprve Mars!";
                            break;
                        case 4:
                            labelUpozorneni.Text = "Nejprve Jupiter!";
                            break;
                        case 5:
                            labelUpozorneni.Text = "Neprve Saturn!";
                            break;
                        case 6:
                            labelUpozorneni.Text = "Nejprve Uran!";
                            break;

                    }
        }


        // vzhled tlačítek po najetí + spuštění plop zvuku

        private void tlacitkoMerkur_MouseEnter(object sender, EventArgs e)
        {
            labelMerkur.Visible = true;
            skoreMerkur.Visible = true;
            tlacitkoMerkur.BackgroundImage = Properties.Resources.merkurMys;
            labelVybranaPlaneta.Text = "Merkur";
            NactiSkore();
            


            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = "zvukKliknuti.wav";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }


        }
        private void tlacitkoMerkur_MouseLeave(object sender, EventArgs e)
        {

            labelMerkur.Visible = false;
            skoreMerkur.Visible = false;
            tlacitkoMerkur.BackgroundImage = Properties.Resources.merkur;
            labelVybranaPlaneta.Text = "";
            labelUpozorneni.Text = "";
        }

        private void tlacitkoVenuse_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoVenuse.BackgroundImage = Properties.Resources.venuseMys;
            labelVybranaPlaneta.Text = "Venuše";
            NactiSkore();
            labelVenuse.Visible = true;
            skoreVenuse.Visible = true;
            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = ("zvukKliknuti.wav");
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void tlacitkoVenuse_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoVenuse.BackgroundImage = Properties.Resources.venuse;
            labelVybranaPlaneta.Text = "";
            labelVenuse.Visible = false;
            skoreVenuse.Visible = false;
            labelUpozorneni.Text = "";
        }

        private void tlacitkoZeme_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoZeme.BackgroundImage = Properties.Resources.zemeMys;
            labelVybranaPlaneta.Text = "Zeme";
            NactiSkore();
            labelZeme.Visible = true;
            skoreZeme.Visible = true;

            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = ("zvukKliknuti.wav");
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void tlacitkoZeme_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoZeme.BackgroundImage = Properties.Resources.zeme;
            labelVybranaPlaneta.Text = "";
            labelZeme.Visible = false;
            skoreZeme.Visible = false;
            labelUpozorneni.Text = "";
        }

        private void tlacitkoMars_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoMars.BackgroundImage = Properties.Resources.marsMys;
            labelVybranaPlaneta.Text = "Mars";
            NactiSkore();
            labelMars.Visible = true;
            skoreMars.Visible = true;

            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = ("zvukKliknuti.wav");
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void tlacitkoMars_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoMars.BackgroundImage = Properties.Resources.mars;
            labelVybranaPlaneta.Text = "";
            labelMars.Visible = false;
            skoreMars.Visible = false;
            labelUpozorneni.Text = "";
        }

        private void tlacitkoJupiter_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoJupiter.BackgroundImage = Properties.Resources.jupiterMys;
            labelVybranaPlaneta.Text = "Jupiter";
            NactiSkore();
            labelJupiter.Visible = true;
            skoreJupiter.Visible = true;

            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = ("zvukKliknuti.wav");
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void tlacitkoJupiter_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoJupiter.BackgroundImage = Properties.Resources.jupiter;
            labelVybranaPlaneta.Text = "";
            labelJupiter.Visible = false;
            skoreJupiter.Visible = false;
            labelUpozorneni.Text = "";
        }

        private void tlacitkoSaturn_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoSaturn.BackgroundImage = Properties.Resources.saturnMys;
            labelVybranaPlaneta.Text = "Saturn";
            NactiSkore();
            labelSaturn.Visible = true;
            skoreSaturn.Visible = true;

            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = ("zvukKliknuti.wav");
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void tlacitkoSaturn_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoSaturn.BackgroundImage = Properties.Resources.saturn;
            labelVybranaPlaneta.Text = "";
            labelSaturn.Visible = false;
            skoreSaturn.Visible = false;
            labelUpozorneni.Text = "";
        }

        private void tlacitkoUran_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoUran.BackgroundImage = Properties.Resources.uranMys;
            labelVybranaPlaneta.Text = "Uran";
            NactiSkore();
            labelUran.Visible = true;
            skoreUran.Visible = true;

            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = ("zvukKliknuti.wav");
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void tlacitkoUran_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoUran.BackgroundImage = Properties.Resources.uran;
            labelVybranaPlaneta.Text = "";
            labelUran.Visible = false;
            skoreUran.Visible = false;
            labelUpozorneni.Text = "";
        }

        private void tlacitkoNeptun_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoNeptun.BackgroundImage = Properties.Resources.neptunMys;
            labelVybranaPlaneta.Text = "Neptun";
            NactiSkore();
            labelNeptun.Visible = true;
            skoreNeptun.Visible = true;

            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = ("zvukKliknuti.wav");
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void tlacitkoNeptun_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoNeptun.BackgroundImage = Properties.Resources.neptun;
            labelVybranaPlaneta.Text = "";
            labelNeptun.Visible = false;
            skoreNeptun.Visible = false;
            labelUpozorneni.Text = "";
        }



 

        // spouštění planet
        private void tlacitkoMerkur_Click(object sender, EventArgs e)
        {

            // zkontroluje volno.. aby se nespustily dvě hry naráz
            if (tridaPromenne.praveSeHraje == true)
            {
                return;
            }

            else
            {

                oknoHraMerkur hraMerkur = new oknoHraMerkur();
                hraMerkur.Show();
                tridaPromenne.praveSeHraje = true;
                hudbaOkno.Stop();

                
                if (tridaPromenne.hudba == true)
                {
                   hudbaPriHre.PlayLooping();
                }

            }




        }
        private void tlacitkoVenuse_Click(object sender, EventArgs e)
        {
            if (tridaPromenne.praveSeHraje == true)
            {
                return;
            }
            else
            {
                if (tridaPromenne.merkurVyplneny == true)
                {
                    oknoHraVenuse hraVenuse = new oknoHraVenuse();
                    hraVenuse.Show();
                    tridaPromenne.praveSeHraje = true;
                    hudbaOkno.Stop();
                    if (tridaPromenne.hudba == true)
                    {   
                        hudbaPriHre.PlayLooping();
                    }   
                }
                else
                {
                    ZkontrolujLevel();
                }

            }



        }
        private void tlacitkoZeme_Click(object sender, EventArgs e)
        {
            if (tridaPromenne.praveSeHraje == true)
            {
                return;
            }
            else
            {
                if (tridaPromenne.venuseVyplneny == true)
                {

                oknoHraZeme hraZeme = new oknoHraZeme();
                hraZeme.Show();
                tridaPromenne.praveSeHraje = true;
                hudbaOkno.Stop();
                if (tridaPromenne.hudba == true)
                {
                    hudbaPriHre.PlayLooping();
                }

                }
                else
                {
                    ZkontrolujLevel();
                }

            }


        }
        private void tlacitkoMars_Click(object sender, EventArgs e)
        {

            if (tridaPromenne.praveSeHraje == true)
            {
                return;
            }
            else
            {
                if (tridaPromenne.zemeVyplneny==true)
                {
                oknoHraMars hraMars = new oknoHraMars();
                hraMars.Show();
                tridaPromenne.praveSeHraje = true;
                hudbaOkno.Stop();
                if (tridaPromenne.hudba == true)
                {
                    hudbaPriHre.PlayLooping();
                }
                }
                else
                {
                    ZkontrolujLevel();
                }

            }

        }
        private void tlacitkoJupiter_Click(object sender, EventArgs e)
        {

            if (tridaPromenne.praveSeHraje == true)
            {
                return;
            }
            else
            {
                if (tridaPromenne.marsVyplneny==true)
                {
                oknoHraJupiter hraJupiter = new oknoHraJupiter();
                hraJupiter.Show();
                tridaPromenne.praveSeHraje = true;
                hudbaOkno.Stop();

                if (tridaPromenne.hudba == true)
                {
                    hudbaPriHre.PlayLooping();
                }
                }
                else
                {
                    ZkontrolujLevel();
                }


            }

        }
        private void tlacitkoSaturn_Click(object sender, EventArgs e)
        {

            if (tridaPromenne.praveSeHraje == true)
            {
                return;
            }
            else
            {
                if (tridaPromenne.jupiterVyplneny==true)
                {
                oknoHraSaturn hraSaturn = new oknoHraSaturn();
                hraSaturn.Show();
                tridaPromenne.praveSeHraje = true;
                hudbaOkno.Stop();
                if (tridaPromenne.hudba == true)
                {
                    hudbaPriHre.PlayLooping();
                }
                }
                else
                {
                    ZkontrolujLevel();
                }

            }

        }
        private void tlacitkoUran_Click(object sender, EventArgs e)
        {
            if (tridaPromenne.praveSeHraje == true)
            {
                return;
            }
            else
            {
                if (tridaPromenne.saturnVyplneny==true)
                {
                oknoHraUran hraUran = new oknoHraUran();
                hraUran.Show();
                tridaPromenne.praveSeHraje = true;
                hudbaOkno.Stop();
                if (tridaPromenne.hudba == true)
                {
                    hudbaPriHre.PlayLooping();
                }
                }
                else
                {
                    ZkontrolujLevel();
                }

            }

        }
        private void tlacitkoNeptun_Click(object sender, EventArgs e)
        {

            if (tridaPromenne.praveSeHraje == true)
            {
                return;
            }
            else
            {
                if (tridaPromenne.uranVyplneny==true)
                {
                oknoHraNeptun hraNeptun = new oknoHraNeptun();
                hraNeptun.Show();
                tridaPromenne.praveSeHraje = true;
                hudbaOkno.Stop();
                if (tridaPromenne.hudba == true)
                {
                    hudbaPriHre.PlayLooping();
                }


                }

                else
                {
                    ZkontrolujLevel();
                }
            }

        }





        private void oknoHerni_Load(object sender, EventArgs e)
        {

            hudbaOkno.PlayLooping();
            DoubleBuffered = true;
          
        }

        private void tlacitkoExit_Click_1(object sender, EventArgs e)
        {

            if (tridaPromenne.zvukoveEfekty == true)
            {
            timer.Enabled = true;
            hudbaKonec.Play();
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void tlacitkoNastaveni_Click(object sender, EventArgs e)
        {
            oknoNastaveni nastaveni = new oknoNastaveni();
            nastaveni.Show();
        }

        private void tlacitkoNapoveda_Click(object sender, EventArgs e)
        {
            oknoNapoveda napoveda = new oknoNapoveda();
            napoveda.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tlacitkoExit_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoExit.FlatAppearance.BorderSize = 2;

            if (tridaPromenne.zvukoveEfekty == true)
            {
            axWindowsMediaPlayer1.URL = ("zvukCvak.wav");
            axWindowsMediaPlayer1.Ctlcontrols.play();
            }

        }

        private void tlacitkoExit_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoExit.FlatAppearance.BorderSize = 1;
        }


        private void tlacitkoNapoveda_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoNapoveda.FlatAppearance.BorderSize = 2;
            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = ("zvukCvak.wav");
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void tlacitkoNapoveda_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoNapoveda.FlatAppearance.BorderSize = 1;
        }

        private void tlacitkoNastaveni_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoNastaveni.FlatAppearance.BorderSize = 2;
            if (tridaPromenne.zvukoveEfekty == true)
            {
                axWindowsMediaPlayer1.URL = ("zvukCvak.wav");
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void tlacitkoNastaveni_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoNastaveni.FlatAppearance.BorderSize = 1;
        }

    }
}
