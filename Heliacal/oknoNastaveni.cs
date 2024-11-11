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
    public partial class oknoNastaveni : Form
    {
        public oknoNastaveni()
        {
            InitializeComponent();
            NahrajNastaveni();
        }


        private void NahrajNastaveni()
        {
            if (tridaPromenne.hudba==true)
            {
                hudba.Checked = true;
            }
            else
            {
                hudba.Checked = false;
            }

            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvukoveEfekty.Checked = true;
            }
            else
            {
                zvukoveEfekty.Checked = false;
            }
        }


        private void tlacitkoSkrytNastaveni_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void zvukoveEfekty_CheckedChanged(object sender, EventArgs e)
        {
            if (zvukoveEfekty.Checked)
            {

                tridaPromenne.zvukoveEfekty = true;
            }
            else
            {
                tridaPromenne.zvukoveEfekty = false;
            }
        }

        private void hudba_CheckedChanged(object sender, EventArgs e)
        {
            if (hudba.Checked)
            {
                if (tridaPromenne.praveSeHraje==true)
                {
                    oknoHerni.hudbaPriHre.PlayLooping();
                }
                else
                {
                    oknoHerni.hudbaOkno.PlayLooping();  
                }
                
                tridaPromenne.hudba = true;
            }
            else
            {
                oknoHerni.hudbaOkno.Stop();
                oknoHerni.hudbaPriHre.Stop();
                tridaPromenne.hudba = false;
            }
        }


        private void tlacitkoRestartovat_Click(object sender, EventArgs e)
        {
            oknoOtazka otazka = new oknoOtazka();
            otazka.Show();
        }

        private void tlacitkoRestartovat_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            
            tlacitkoRestartovat.FlatAppearance.BorderSize = 2;
        }

        private void tlacitkoRestartovat_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoRestartovat.FlatAppearance.BorderSize = 1;
        }

        private void tlacitkoSkrytNastaveni_MouseEnter(object sender, EventArgs e)
        {
            if (tridaPromenne.zvukoveEfekty == true)
            {
                zvuk.URL = "zvukCvak.wav";
                zvuk.Ctlcontrols.play();
            }
            tlacitkoSkrytNastaveni.FlatAppearance.BorderSize = 2;
        }

        private void tlacitkoSkrytNastaveni_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoSkrytNastaveni.FlatAppearance.BorderSize = 1;
        }



    }
}
