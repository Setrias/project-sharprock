using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fyzikální_měření
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double vyska, dobaPadu, casSoucet, casPrumer, tihovaSila;
        private int pocetMereni;
        private double[] poleCas = new double[10];
        
        private void Form1_Load(object sender, EventArgs e)
        {
            labelPrumerCas.Text = "";
            labelTihovaSila.Text = "";
            AcceptButton = buttonVyska;
            ActiveControl = textBoxVyska;
        }

        private void buttonVyska_Click(object sender, EventArgs e)
        {
            try
            {
                vyska = Convert.ToDouble(textBoxVyska.Text);
                textBoxVyska.Enabled = false;
                buttonVyska.Enabled = false;
                AcceptButton = buttonCas;
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }

        private void buttonCas_Click(object sender, EventArgs e)
        {
            try
            {
                dobaPadu = Convert.ToDouble(textBoxCas.Text);
                if (dobaPadu >= 0)
                {
                    poleCas[pocetMereni] = dobaPadu;
                    pocetMereni++;

                    if (pocetMereni == 10)
                    {
                        textBoxCas.Enabled = false;
                        buttonCas.Enabled = false;

                        for (int i = 0; i < 10; i++)
                        {
                            casSoucet += poleCas[i];
                            if (i == 9)
                            {
                                casPrumer = casSoucet / 10;
                                labelPrumerCas.Text = Convert.ToString(casPrumer);
                            }
                        }

                        tihovaSila = 2 * vyska / (casPrumer * casPrumer);
                        labelTihovaSila.Text = Convert.ToString(tihovaSila);
                    }

                    textBoxCas.Focus();
                    textBoxCas.SelectAll();
                }
                else
                {
                    MessageBox.Show("Zadej kladné číslo.");
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo.");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxCas.Text = "";
            textBoxVyska.Text = "";
            labelPrumerCas.Text = "";
            labelTihovaSila.Text = "";

            for (int i = 0; i < 10; i++)
            {
                poleCas[i] = 0;
            }
            
            pocetMereni = 0;
            casSoucet = 0;
            casPrumer = 0;

            textBoxCas.Enabled = true;
            buttonCas.Enabled = true;
            textBoxVyska.Enabled = true;
            buttonVyska.Enabled = true;

            textBoxVyska.Focus();
            AcceptButton = buttonVyska;
        }
    }
}
