using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botek_hraci_pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct zeton
        {
            public int sour_x;
            public int sour_y;
            public string barva;
        }

        zeton[] parametry = new zeton[10];

        int pocet = 0;

        private void buttonUloz_Click(object sender, EventArgs e)
        {
            parametry[pocet].sour_x = Convert.ToInt32(numericUpDownX.Value); //přečtení dat z formuláře
            parametry[pocet].sour_y = Convert.ToInt32(numericUpDownY.Value); //přečtení dat z formuláře
            parametry[pocet].barva = Convert.ToString(textBoxBarva.Text); //přečtení dat z formuláře
            pocet++;

            if (pocet == 6)
            {
                buttonUloz.Enabled = false;
                numericUpDownX.Enabled = false;
                numericUpDownY.Enabled = false;
                textBoxBarva.Enabled = false;
            }
        }

        private void buttonPozice_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pocet; i++)
            {
                if (parametry[i].barva == "černá") //podmínka pro vypsání
                {
                    string vypis = "souřadnice X: " + Convert.ToString(parametry[i].sour_x) + ", souřadnice Y: " +
                                   Convert.ToString(parametry[i].sour_y); //vytvoření proměnné pro výpis do listboxu
                    listBoxVypis.Items.Add(vypis);
                }
            }
        }
    }
}