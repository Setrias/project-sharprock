using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vypocet_znamky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private int pocetBodu, pocetZadPrikladu;
        private double bodySoucet;
        private double[] poleBody = new double[5];

        private void buttonZadatBody_Click(object sender, EventArgs e)
        {
            pocetBodu = Convert.ToInt32(numericUpDownBody.Value);

            poleBody[pocetZadPrikladu] = pocetBodu;
            pocetZadPrikladu++;

            if (pocetZadPrikladu == 5)
            {
                numericUpDownBody.Enabled= false;
                buttonZadatBody.Enabled= false;

                for (int i = 0; i < 5; i++)
                {
                    bodySoucet += poleBody[i];
                    if (i == 4)
                    {
                        textBoxPocetBodu.Text = bodySoucet.ToString();
                    }
                }

                if ((bodySoucet >= 45))
                {
                    textBoxZnamka.Text = "1";
                }

                if ((bodySoucet < 45) && (bodySoucet >= 37.5))
                {
                    textBoxZnamka.Text = "2";
                }

                if ((bodySoucet < 37.5) && (bodySoucet >= 25))
                {
                    textBoxZnamka.Text = "3";
                }

                if ((bodySoucet < 25) && (bodySoucet >= 17.5))
                {
                    textBoxZnamka.Text = "4";
                }
                if (bodySoucet < 17.5)
                {
                    textBoxZnamka.Text = "5";
                }
            }
        }
    }
}