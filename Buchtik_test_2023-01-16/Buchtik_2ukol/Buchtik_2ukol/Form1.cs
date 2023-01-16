using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtik_2ukol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int cisloPocet, cisloZadane, pocetZadanych;
        private double cisloPrumer, cisloSoucet;
        private int[] poleCisla = new int[20];

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPopisZadat.Visible = false;
            labelPopisVysledek.Visible = false;
            labelVysledek.Visible = false;
            buttonZadatCislo.Visible = false;
            numericUpDownCislo.Visible = false;
            labelVysledek.Text = "";
        }

        private void buttonZadatPocet_Click(object sender, EventArgs e)
        {
            try
            {
                cisloPocet = Convert.ToInt32(textBoxPocet.Text);

                if (cisloPocet > 0 && cisloPocet <= 20)
                {
                    buttonZadatPocet.Enabled = false;
                    textBoxPocet.Enabled = false;

                    labelPopisZadat.Visible = true;
                    labelPopisVysledek.Visible = true;
                    labelVysledek.Visible = true;
                    buttonZadatCislo.Visible = true;
                    numericUpDownCislo.Visible = true;
                }
                else
                {
                    MessageBox.Show("Zadej číslo od 1 do 20");
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }

        private void buttonZadatCislo_Click(object sender, EventArgs e)
        {
            cisloZadane = Convert.ToInt32(numericUpDownCislo.Value);

            listBoxCisla.Items.Add(cisloZadane);
            poleCisla[pocetZadanych] = cisloZadane;
            pocetZadanych++;

            if (pocetZadanych == cisloPocet)
            {
                numericUpDownCislo.Enabled = false;
                buttonZadatCislo.Enabled = false;

                for (int i = 0; i < cisloPocet; i++)
                {
                    cisloSoucet += poleCisla[i];
                }

                cisloPrumer = cisloSoucet / cisloPocet;
                labelVysledek.Text = Convert.ToString(cisloPrumer);
            }
        }
    }
}
