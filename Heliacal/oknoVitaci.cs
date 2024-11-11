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
    public partial class oknoVitaci : Form
    {
        public oknoVitaci()
        {
            InitializeComponent();
        }
        private void tlacitkoSpustit_Click(object sender, EventArgs e)
        {  
            oknoHerni oknoHerni = new oknoHerni();            
            oknoHerni.Show();
            Hide();  
        }
        private void tlacitkoUkoncit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tlacitkoSpustit_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoSpustit.FlatAppearance.BorderSize = 2;
        }
        private void tlacitkoSpustit_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoSpustit.FlatAppearance.BorderSize = 0;
        }
        private void tlacitkoUkoncit_MouseEnter(object sender, EventArgs e)
        {
            tlacitkoUkoncit.FlatAppearance.BorderSize = 2;
        }
        private void tlacitkoUkoncit_MouseLeave(object sender, EventArgs e)
        {
            tlacitkoUkoncit.FlatAppearance.BorderSize = 0;
        }
    }
}
