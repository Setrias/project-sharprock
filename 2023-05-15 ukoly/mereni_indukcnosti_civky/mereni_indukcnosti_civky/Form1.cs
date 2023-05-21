using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mereni_indukcnosti_civky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct AtributyMereni
        {
            public double napeti;
            public double proud;
            public double indukcnost;
        }

        private AtributyMereni[] zaznamMereni = new AtributyMereni[10];
        private int pocetMereni, pocetMereniNad5V;
        private double odporCivky, frekvence;

        private void buttonVypocitat_Click(object sender, EventArgs e)
        {
            try
            {
                zaznamMereni[pocetMereni].napeti = Convert.ToDouble(textBoxNapeti.Text);
                zaznamMereni[pocetMereni].proud = Convert.ToDouble(textBoxProud.Text);
                odporCivky = Convert.ToDouble(textBoxOdporCivky.Text);
                frekvence = Convert.ToDouble(textBoxFrekvence.Text);

                if (zaznamMereni[pocetMereni].napeti > 20 || zaznamMereni[pocetMereni].napeti <= 0)
                {
                    MessageBox.Show("Napětí musí být menší nebo rovno 20 V a nesmí být 0 nebo záporné.");
                    return;
                }

                if (zaznamMereni[pocetMereni].proud > 400 || zaznamMereni[pocetMereni].proud <= 0)
                {
                    MessageBox.Show("Proud musí být menší nebo rovno 400 mA a nesmí být 0 nebo záporný.");
                    return;
                }

                if (odporCivky <= 0 && frekvence <= 0)
                {
                    MessageBox.Show("Odpor a frekvence musí být větší než 0");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Zadej číselnou hodnotu.");
                return;
            }

            textBoxOdporCivky.Enabled = false;
            textBoxFrekvence.Enabled = false;


            zaznamMereni[pocetMereni].indukcnost = Math.Sqrt(Math.Pow(zaznamMereni[pocetMereni].napeti, 2) / Math.Pow(zaznamMereni[pocetMereni].proud / 1000, 2) + Math.Pow(odporCivky, 2)) / (2 * Math.PI * frekvence);
            listBoxVypocty.Items.Add($"č.m. {pocetMereni + 1}, U = {zaznamMereni[pocetMereni].napeti} V, I = {zaznamMereni[pocetMereni].proud} mA, L = {zaznamMereni[pocetMereni].indukcnost} H");

            pocetMereni++;

            // výpočet indukčnosti
            if (pocetMereni == 10)
            {
                buttonVypocitat.Enabled = false;

                double soucetIndukcnost = 0;
                double maxIndukcnost = zaznamMereni[0].indukcnost;
                for (int i = 0; i < 10; i++)
                {
                    soucetIndukcnost += zaznamMereni[i].indukcnost;

                    if (maxIndukcnost < zaznamMereni[i].indukcnost)
                    {
                        maxIndukcnost = zaznamMereni[i].indukcnost;
                    }

                    if (zaznamMereni[i].napeti > 5)
                    {
                        pocetMereniNad5V++;
                    }
                }

                textBoxPrumernaIndukcnost.Text = Convert.ToString(Math.Round(soucetIndukcnost / 10, 1));
                textBoxMaxIndukcnost.Text = Convert.ToString(maxIndukcnost);
                textBoxPocetMereniNad5V.Text = Convert.ToString(pocetMereniNad5V);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxNapeti.Text = "";
            textBoxProud.Text = "";
            textBoxFrekvence.Text = "";
            textBoxOdporCivky.Text = "";
            textBoxMaxIndukcnost.Text = "";
            textBoxPrumernaIndukcnost.Text = "";
            textBoxPocetMereniNad5V.Text = "";
            
            listBoxVypocty.Items.Clear();
            pocetMereni = 0;
            pocetMereniNad5V = 0;

            buttonVypocitat.Enabled = true;
            textBoxFrekvence.Enabled = true;
            textBoxOdporCivky.Enabled = true;
        }
    }
}