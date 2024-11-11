using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heliacal
{
    public partial class oknoNapoveda : Form
    {
        public oknoNapoveda()
        {
            InitializeComponent();
        }

        private void tlacitkoExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //znovu přehraje video.. jeho adresa se načítá přímo z prvku WMP v sekci URL
            video.Ctlcontrols.play();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            button1.FlatAppearance.BorderSize = 2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 1;
        }

        private void tlacitkoExit_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            tlacitkoExit.FlatAppearance.BorderSize = 2;
        }

        private void tlacitkoExit_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoExit.FlatAppearance.BorderSize = 1;
        }
    }
}
