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
    public partial class oknoOznameni : Form
    {
        public oknoOznameni()
        {
            InitializeComponent();
            labelSkore.Text = Convert.ToString(tridaPromenne.skorePosledni);
            labelTahy.Text = Convert.ToString(tridaPromenne.posledniPocetTahu);
            labelCas.Text = Convert.ToString(tridaPromenne.posledniCas);
        }

        private void tlacitkoOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tlacitkoOK_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            tlacitkoOK.FlatAppearance.BorderSize = 2;
        }

        private void tlacitkoOK_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoOK.FlatAppearance.BorderSize = 1;
        }
    }
}
