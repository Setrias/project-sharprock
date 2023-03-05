using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        // private int hodnotaX, sourX, hodnotaY, sourY, polomer;

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
                panelKresleni.Refresh();
                
                int velikost = 75; // základní velikost
                int pevnaVelikost = velikost; // operativní velikost kružnice, univerzální k různým velikostem 
                int sourX = 300 - velikost / 2; // výpočet rohu kružnice
                int sourY = 300 - velikost / 2;

                Pen pero = new Pen(Color.Crimson, 3);

                for (int i = 0; i < 5; i++)
                {
                    kresPlocha.DrawEllipse(pero, sourX, sourY, velikost, velikost);
                    sourX -= pevnaVelikost / 2; // souřadnice X - pevná velikost / 2
                    sourY -= pevnaVelikost / 2;
                    velikost += pevnaVelikost;
                }
            }

            if (comboBoxTvary.SelectedIndex == 1)
            {
                panelKresleni.Refresh();
                
                int velikost = 50;
                int operVelikost = velikost;    // statická velikost pro univerzálnost změny jako jediné proměnné
                int pocetCtvercu = 5;
                int sourX = 300 - pocetCtvercu * (velikost / 2);
                int sourY = 300 - pocetCtvercu * (velikost / 2);

                Pen pero = new Pen(Color.DeepSkyBlue, 3);

                for (int i = 0; i < pocetCtvercu; i++)
                {
                    kresPlocha.DrawRectangle(pero, sourX, sourY, velikost, velikost);
                    velikost += operVelikost;
                }
            }

            if (comboBoxTvary.SelectedIndex == 2)
            {
                panelKresleni.Refresh();

                Random randNum = new Random(); // souřadnice X

                for (int i = 0; i < 25; i++)
                {
                    int sourX = randNum.Next(-50, 500);
                    int sourY = randNum.Next(-50, 500);
                    int prumer = randNum.Next(20, 300);

                    // testovaní aby náhodné čísla nebyly stejné, jsou založené na čase
                    if (sourX == sourY)
                    {
                        sourY = randNum.Next(0, 500);
                    }
                    
                    if (prumer == sourX || prumer == sourY)
                    {
                        prumer = randNum.Next(20, 300);
                    }

                    Pen pero = new Pen(Color.Black, 2);

                    kresPlocha.DrawEllipse(pero, sourX, sourY, prumer, prumer);
                }
            }

            if (comboBoxTvary.SelectedIndex == 3)
            {
                panelKresleni.Refresh();
                Pen peroBlue = new Pen(Color.DeepSkyBlue, 2);
                Pen peroRed = new Pen(Color.Red, 2);

                int sirka = 260, vyska = 260;

                int sourX = 300 - sirka / 2; // výpočet souřadnic rohu kružnic
                int sourY = 300 - vyska / 2;

                for (int i = 0; i < 25; i++)
                {
                    kresPlocha.DrawEllipse(peroBlue, sourX, 200, sirka, 250);
                    sirka -= 10;
                }
                
                for (int i = 0; i < 25; i++)
                {
                    kresPlocha.DrawEllipse(peroRed, 200, sourY, 250, vyska);
                    vyska -= 10;
                }
            }
        }
    }
}