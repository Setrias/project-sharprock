using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezistivita_vodiče
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVysledek_Click(object sender, EventArgs e)
        {
            double l, d, Al, Cu, Ag, S;
            l = Convert.ToDouble(textBoxDelka.Text);
            d = Convert.ToDouble(textBoxPrumer.Text) / 1000;
            S = Math.PI * Math.Pow(d / 2d, 2d);
            Al = Convert.ToDouble(28d / 1000000000);
            Cu = Convert.ToDouble(18d / 1000000000);
            Ag = Convert.ToDouble(17d / 1000000000);
            string nelZad = "Nelze zadat 0";

            if (radioButtonAl.Checked)
            {
                if (l == 0)
                {
                    labelVysledek.Text = nelZad;
                }
                else if (d == 0)
                {
                    labelVysledek.Text = nelZad;
                }
                else
                {
                    labelVysledek.Text = Convert.ToString(Math.Round(Al * l / S, 5));
                }
            }
            
            if (radioButtonCu.Checked)
            {
                if (l == 0)
                {
                    labelVysledek.Text = nelZad;
                }
                else if (d == 0)
                {
                    labelVysledek.Text = nelZad;
                }
                else
                {
                    labelVysledek.Text = Convert.ToString(Math.Round(Cu * l / S, 5));
                }
            }
            
            if (radioButtonAg.Checked)
            {
                if (l == 0)
                {
                    labelVysledek.Text = nelZad;
                }
                else if (d == 0)
                {
                    labelVysledek.Text = nelZad;
                }
                else
                {
                    labelVysledek.Text = Convert.ToString(Math.Round(Ag * l / S, 5));
                }
            }
        }
    }
}