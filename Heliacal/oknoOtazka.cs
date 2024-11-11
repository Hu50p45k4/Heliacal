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
    public partial class oknoOtazka : Form
    {
        public oknoOtazka()
        {
            InitializeComponent();
        }

        private void tlacitkoNe_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void tlacitkoAno_Click(object sender, EventArgs e)
        {
            tridaPromenne.merkurVyplneny = false;
            tridaPromenne.venuseVyplneny = false;
            tridaPromenne.zemeVyplneny = false;
            tridaPromenne.marsVyplneny = false;
            tridaPromenne.jupiterVyplneny = false;
            tridaPromenne.saturnVyplneny = false;
            tridaPromenne.uranVyplneny = false;
            tridaPromenne.neptunVyplneny = false;

            Properties.Settings.Default.skoreMerkur = 0;
            Properties.Settings.Default.skoreVenuse = 0;
            Properties.Settings.Default.skoreZeme = 0;
            Properties.Settings.Default.skoreMars = 0;
            Properties.Settings.Default.skoreJupiter = 0;
            Properties.Settings.Default.skoreSaturn = 0;
            Properties.Settings.Default.skoreUran = 0;
            Properties.Settings.Default.skoreNeptun = 0;

            TextWriter merkur = new StreamWriter("skoreMerkur.txt");
            merkur.Write("0");
            merkur.Close();
            TextWriter venuse = new StreamWriter("skoreVenuse.txt");
            venuse.Write("0");
            venuse.Close();
            TextWriter zeme = new StreamWriter("skoreZeme.txt");
            zeme.Write("0");
            zeme.Close();
            TextWriter mars = new StreamWriter("skoreMars.txt");
            mars.Write("0");
            mars.Close();
            TextWriter jupiter = new StreamWriter("skoreJupiter.txt");
            jupiter.Write("0");
            jupiter.Close();
            TextWriter saturn = new StreamWriter("skoreSaturn.txt");
            saturn.Write("0");
            saturn.Close();
            TextWriter uran = new StreamWriter("skoreUran.txt");
            uran.Write("0");
            uran.Close();
            TextWriter neptun= new StreamWriter("skoreNeptun.txt");
            neptun.Write("0");
            neptun.Close();

            File.Delete("merkurVyplneny.txt");
            File.Delete("venuseVyplneny.txt");
            File.Delete("zemeVyplneny.txt");
            File.Delete("marsVyplneny.txt");
            File.Delete("jupiterVyplneny.txt");
            File.Delete("saturnVyplneny.txt");
            File.Delete("uranVyplneny.txt");
            File.Delete("neptunVyplneny.txt");

            Hide();
        }

        private void tlacitkoAno_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            tlacitkoAno.FlatAppearance.BorderSize = 2;
        }

        private void tlacitkoAno_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoAno.FlatAppearance.BorderSize = 1;
        }

        private void tlacitkoNe_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            tlacitkoNe.FlatAppearance.BorderSize = 2;
        }

        private void tlacitkoNe_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoNe.FlatAppearance.BorderSize = 1;
        }
    }
}
