using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulačka_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelVysledek.Text = "";
        }

        private void buttonVysledek_Click(object sender, EventArgs e)
        {
            double a, b, v;
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
            /*
            if (radioButtonSci.Checked) {
                labelVysledek.Text = Convert.ToString(a + b);
            }
            if (radioButtonOdc.Checked) {
                labelVysledek.Text = Convert.ToString(a - b);
            }
            if (radioButtonNas.Checked) {
                labelVysledek.Text = Convert.ToString(a * b);
            }
            if (radioButtonDel.Checked) {
                 if (b == 0) {
                    labelVysledek.Text = "Dělení nulou";
                } else {
                    labelVysledek.Text = Convert.ToString(a / b);
                } */

            if (radioButtonSci.Checked) {
                v = a + b;
                labelVysledek.Text = Convert.ToString(v);
            }
            if (radioButtonOdc.Checked) {
                v = a - b;
                labelVysledek.Text = Convert.ToString(v);
            }
            if (radioButtonNas.Checked) {
                v = a * b;
                labelVysledek.Text = Convert.ToString(v);
            }
            if (radioButtonDel.Checked) {
                if (b != 0) {
                    v = a / b;
                    labelVysledek.Text = Convert.ToString(v);
                } else {
                    labelVysledek.Text = Convert.ToString("Dělení nulou");
                }
            }
        }
    }
}
