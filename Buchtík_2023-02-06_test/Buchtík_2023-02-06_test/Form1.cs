using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtík_2023_02_06_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct kruznice     // definování datového typu
        {
            public double polomer;
            public double obvod;
            public double obsah;

            public double x;
            public double y;
        }

        private kruznice kruz;  // deklarace proměnné

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            try
            {
                kruz.polomer = Convert.ToDouble(textBoxPolomer.Text);   // zadání poloměru

                kruz.obvod = 2 * Math.PI * kruz.polomer;    // výpočet obvodu
                kruz.obsah = Math.PI * Math.Pow(kruz.polomer, 2);   // výpočet obsahu

                textBoxObvod.Text = Convert.ToString(kruz.obvod);   // vypsání proměnných
                textBoxObsah.Text = Convert.ToString(kruz.obsah);

            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }

        private void buttonSourX_Click(object sender, EventArgs e)
        {
            try
            {
                kruz.x = Convert.ToDouble(textBoxSourX.Text);   // uložení souřadnice X
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }

        private void buttonSourY_Click(object sender, EventArgs e)
        {
            try
            {
                kruz.y = Convert.ToDouble(textBoxSourY.Text);   // uložení souřadnice Y
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }
    }
}
