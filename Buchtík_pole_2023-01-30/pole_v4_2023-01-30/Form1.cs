using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole_v4_2023_01_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxCisla.Enabled = false;
            buttonZadatCisla.Enabled = false;
        }

        private int pocetCisel, zadCislo, pocetZadanych;
        private int[] poleCisel;

        private void buttonPocetCisel_Click(object sender, EventArgs e)
        {
            try
            {
                pocetCisel = Convert.ToInt32(textBoxPocetCisel.Text);

                poleCisel = new int[pocetCisel];    // vytvoření pole o požadované velikosti

                textBoxPocetCisel.Enabled = false;
                buttonPocetCisel.Enabled = false;

                textBoxCisla.Enabled = true;
                buttonZadatCisla.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }

        private void buttonZadatCisla_Click(object sender, EventArgs e)
        {
            zadCislo = Convert.ToInt32(textBoxCisla.Text);

            poleCisel[pocetZadanych] = zadCislo;    // ukládání do pole
            pocetZadanych++;

            if (pocetZadanych == pocetCisel)
            {
                textBoxCisla.Enabled = false;
                buttonZadatCisla.Enabled = false;

                for (int i = 0; i < poleCisel.Length; i++)      // výpis do listBoxu
                {
                    listBoxCisla.Items.Add(poleCisel[i]);
                }
            }
        }

    }
}
