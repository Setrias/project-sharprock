using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezistivita_vodiče_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOdpor_Click(object sender, EventArgs e)
        {
            double l, d, S, R, Ro = 0;
            try
            {
                l = Convert.ToDouble(textBoxDelka.Text); //v metrech
                d = Convert.ToDouble(textBoxPrumer.Text) / 1000; //převod na metry
                if (radioButtonAl.Checked)
                {
                    Ro = 28d / 1000000000;
                }

                if (radioButtonCu.Checked)
                {
                    Ro = 18d / 1000000000;
                }

                if (radioButtonAg.Checked)
                {
                    Ro = 17d / 1000000000;
                }


                if ((l <= 0) || (d <= 0))
                {
                    MessageBox.Show("Číslo je záporné nebo nula");
                }
                else
                {
                    S = Math.PI * Math.Pow(d / 2d, 2d);
                    R = Ro * l / S;
                    labelVysledek.Text = Convert.ToString(R);
                }
            }
            catch
            {
                MessageBox.Show("Chyba zadání");
            }
        }
    }
}