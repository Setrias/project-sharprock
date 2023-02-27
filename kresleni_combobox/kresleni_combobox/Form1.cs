using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kresleni_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics kresPlocha;
        private int hodnotaX, sourX, hodnotaY, sourY, polomer;

        private void panelKresleni_Paint(object sender, PaintEventArgs e)
        {
            kresPlocha = panelKresleni.CreateGraphics();
        }

        private void comboBoxTvary_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Soustředné kružnice
            // Čtverce
            // Náhodné kružnice
            // Vlastní tvorba

            if (comboBoxTvary.SelectedIndex == 0)
            {
                int velikost = 75; // základní velikost
                int operVelikost = velikost; // operativní velikost kružnice, univerzální k různým velikostem 
                sourX = 300 - velikost / 2;
                sourY = 300 - velikost / 2;

                for (int i = 0; i < 5; i++)
                {
                    kresPlocha.DrawEllipse(Pens.Crimson, sourX, sourY, velikost, velikost);
                    sourX -= operVelikost / 2;
                    sourY -= operVelikost / 2;
                    velikost += operVelikost;
                }
            }

            if (comboBoxTvary.SelectedIndex == 1)
            {
                int velikost = 50;
                int operVelikost = velikost;
                int pocetCtvercu = 5;
                sourX = 300 - pocetCtvercu * (velikost / 2);
                sourY = 300 - pocetCtvercu * (velikost / 2);

                for (int i = 0; i < pocetCtvercu; i++)
                {
                    kresPlocha.DrawRectangle(Pens.Crimson, sourX, sourY, velikost, velikost);
                    velikost += operVelikost;
                }
            }

            if (comboBoxTvary.SelectedIndex == 2)
            {
            }

            if (comboBoxTvary.SelectedIndex == 3)
            {
            }
        }
    }
}