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

     //   private void calc(string pocitej)
     //   {
     //       int cisloA = Convert.ToInt32(textBoxA.Text);
     //       int cisloB = Convert.ToInt32(textBoxB.Text);
     //       int vysledek = 0;
     //       labelKalkVypocet.Text = Convert.ToString(vysledek);
     //       if (něco = tlačítko plus) {
     //       vysledek = cisloA + cisloB;
     //       } else if (něco = tlačítko mínus) {
     //       vysledek = cisloA - cisloB;
     //       } . . .
     //   }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int cisloA = Convert.ToInt32(textBoxA.Text);
            int cisloB = Convert.ToInt32(textBoxB.Text);
            labelKalkVypocet.Text = Convert.ToString(cisloA + cisloB);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int cisloA = Convert.ToInt32(textBoxA.Text);
            int cisloB = Convert.ToInt32(textBoxB.Text);
            labelKalkVypocet.Text = Convert.ToString(cisloA - cisloB);
        }

        private void buttonNasobeni_Click(object sender, EventArgs e)
        {
            int cisloA = Convert.ToInt32(textBoxA.Text);
            int cisloB = Convert.ToInt32(textBoxB.Text);
            labelKalkVypocet.Text = Convert.ToString(cisloA * cisloB);
        }

        private void buttonDeleni_Click(object sender, EventArgs e)
        {
            int cisloA = Convert.ToInt32(textBoxA.Text);
            int cisloB = Convert.ToInt32(textBoxB.Text);
            labelKalkVypocet.Text = Convert.ToString(cisloA / cisloB);
        }
    }
}
