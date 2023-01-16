using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtik_1ukol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double cisloZadane, cisloVysledek;

        private void Form1_Load(object sender, EventArgs e)
        {
            labelVysledek.Text = "";
        }

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            try
            {
                cisloZadane = Convert.ToDouble(textBoxCislo.Text);  // uložení zadaného čísla

                if (cisloZadane > 0)    // aby bylo číslo kladné
                {
                    if (radioButtonMocnina.Checked)
                    {
                        cisloVysledek = cisloZadane * cisloZadane;  //výpočet mocniny
                    }

                    if (radioButtonOdmocnina.Checked)
                    {
                        cisloVysledek = Math.Sqrt(cisloZadane); // výpočet druhé odmocniny
                    }

                    if (radioButtonLog.Checked)
                    {
                        cisloVysledek = Math.Log(cisloZadane);  // výpočet logaritmu
                    }

                    labelVysledek.Text = cisloVysledek.ToString(); // nebo Convert.ToString(cisloVysledek)
                }
                else
                {
                    MessageBox.Show("Číslo musí být kladné");
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }
    }
}