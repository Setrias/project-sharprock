using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace čtverec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonObvod_Click(object sender, EventArgs e)
        {
            int strana = Convert.ToInt32(textBoxObvod.Text);
            int o = strana * 4;
            labelVysledekObvod.Text = labelVysledekObvod.Text = Convert.ToString(o);
        }

        private void buttonObsah_Click(object sender, EventArgs e)
        {
            int strana = Convert.ToInt32(textBoxObsah.Text);
            int s = strana * strana;
            labelVysledekObsah.Text = "obsah je " + Convert.ToString(s);
        }
    }
}
