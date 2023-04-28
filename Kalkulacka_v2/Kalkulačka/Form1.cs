using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulačka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            double cisloA = Convert.ToInt32(textBoxA.Text);
            double cisloB = Convert.ToInt32(textBoxB.Text);
            labelKalkVypocet.Text = Convert.ToString(cisloA + cisloB);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            double cisloA = Convert.ToInt32(textBoxA.Text);
            double cisloB = Convert.ToInt32(textBoxB.Text);
            labelKalkVypocet.Text = Convert.ToString(cisloA - cisloB);
        }

        private void buttonNasobeni_Click(object sender, EventArgs e)
        {
            double cisloA = Convert.ToInt32(textBoxA.Text);
            double cisloB = Convert.ToInt32(textBoxB.Text);
            labelKalkVypocet.Text = Convert.ToString(cisloA * cisloB);
        }

        private void buttonDeleni_Click(object sender, EventArgs e)
        {
            double cisloA = Convert.ToInt32(textBoxA.Text);
            double cisloB = Convert.ToInt32(textBoxB.Text);
            if (cisloB == 0)
            {
                labelKalkVypocet.Text = "Dělení nulou";
            } else
            {
                labelKalkVypocet.Text = Convert.ToString(cisloA / cisloB);
            }
        }
    }
}
