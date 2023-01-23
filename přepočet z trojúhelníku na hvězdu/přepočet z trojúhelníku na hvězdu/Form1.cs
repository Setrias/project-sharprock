using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace přepočet_z_trojúhelníku_na_hvězdu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonTrojuhelnik_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTrojuhelnik.Checked)
            {
                labelVysledekRa.Text = vypocetHevzda();
            }
            else
            {
                
            }
        }

        public string vypocetTrojuhelnik(double r1, double r2, double r3)
        {

            return;
        }

        public string vypocetHevzda(double ra, double rb, double rc)
        {

            return;
        }
    }
}
