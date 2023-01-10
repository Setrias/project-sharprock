using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace úkol_1___přepočet_jednotek
{
    public partial class Form1 : Form
    {
        double cislo, mili, cent, deci, kilo;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrevod_Click(object sender, EventArgs e)
        {

            try
            {
                cislo = Convert.ToDouble(textBoxCislo.Text);

                if (cislo > 0)
                {
                    mili = Convert.ToDouble(cislo * 1000);
                    cent = Convert.ToDouble(cislo * 100);
                    deci = Convert.ToDouble(cislo * 10);
                    kilo = Convert.ToDouble(cislo / 1000);
                }
                else
                {
                    MessageBox.Show("Číslo nesmí být záporné");
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }


            if (radioButtonMili.Checked)
            {
                textBoxCislo.Text = Convert.ToString(mili);
            }

            if (radioButtonCent.Checked)
            {
                textBoxCislo.Text = Convert.ToString(cent);
            }

            if (radioButtonDeci.Checked)
            {
                textBoxCislo.Text = Convert.ToString(deci);
            }

            if (radioButtonKilo.Checked)
            {
                textBoxCislo.Text = Convert.ToString(kilo);
            }
        }
    }
}