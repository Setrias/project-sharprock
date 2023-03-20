using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtík_Uloha_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelVypisCisel.Text = "";
            labelAritPrumer.Text = "";
            labelMedian.Text = "";
            labelPocetPrvocisel.Text = "";
            labelDokonaleCislo.Text = "";
        }

        private OpenFileDialog _vybratSoubor = new OpenFileDialog();
        private string _nazevSouboru, _text;
        private string[] _cisla;
        private double soucet, doubleCislo;
        private int pocetCisel, pocetPrvocisel;

        private void buttonVybratSoubor_Click(object sender, EventArgs e)
        {
            // filtr aby šly vybrat jen .txt soubory
            _vybratSoubor.Filter = "(*.txt)|*.txt|(Všechny soubory *.*|*.*";

            if (_vybratSoubor.ShowDialog() == DialogResult.OK)
            {
                // název vybraného souboru, přečtení souboru a převedení na string, 
                _nazevSouboru = _vybratSoubor.FileName;
                _text = Convert.ToString(File.ReadAllText(_nazevSouboru));
                _cisla = _text.Split(' ', '\r', '\n');

                // výpis jednotlivých čísel do labelVypisCisel
                foreach (var cislo in _cisla)
                {
                    // tečka za posledním číslem
                    pocetCisel++;
                    if (pocetCisel == _cisla.Length)
                    {
                        labelVypisCisel.Text += cislo + ".";
                    }
                    else
                    {
                        labelVypisCisel.Text += cislo + " ";
                    }
                }
            }

            // aritmetický průměr

            foreach (var cislo in _cisla)
            {
                // kvůli erroru že "" na konci není číslo
                if (cislo != "")
                {
                    soucet += Convert.ToDouble(cislo);
                    labelAritPrumer.Text = Convert.ToString(Math.Round(soucet / _cisla.Length, 2));
                }
            }

            // medián
            int stredCisel, stredniCisloMin1, stredniCisloPlus1;
            // určení středu
            stredCisel = (_cisla.Length / 2) - 1;

            if (_cisla.Length / 2 == 0)
            {
                // čísla kolem středu čísel
                stredniCisloMin1 = Convert.ToInt32(_cisla[stredCisel - 1]);
                stredniCisloPlus1 = Convert.ToInt32(_cisla[stredCisel + 1]);

                labelMedian.Text = Convert.ToString((stredniCisloMin1 + stredniCisloPlus1) / 2);
            }
            else
            {
                labelMedian.Text = Convert.ToString(_cisla[stredCisel]);
            }

            // počet prvočísel

            foreach (var cislo in _cisla)
            {
                if (cislo != "")
                {
                    doubleCislo = Convert.ToDouble(cislo);

                    // největší číslo
                    double max = doubleCislo;
                    foreach (var doubleCislo in cislo)
                    {
                        if (doubleCislo > max)
                        {
                            max = doubleCislo;
                        }
                    }

                    for (int i = 0; i < max; i++)
                    {
                        if (doubleCislo % i != 0 || doubleCislo % 1 == 0 && doubleCislo % doubleCislo == 0)
                        {
                            pocetPrvocisel++;
                        }
                    }
                }
            }

            labelPocetPrvocisel.Text = Convert.ToString(pocetPrvocisel);


            // dokonalé číslo

            int soucetDelitel = 0;
            foreach (var cislo in _cisla)
            {
                if (cislo != "")
                {
                    int intCislo = Convert.ToInt32(cislo);
                    for (int i = 0; i < Convert.ToInt32(cislo) - 1; i++)
                    {
                        soucetDelitel += i;
                        if (soucetDelitel == intCislo)
                        {
                            Console.WriteLine(intCislo);
                        }
                    }
                }
            }
        }
    }
}