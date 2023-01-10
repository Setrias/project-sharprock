using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // public --> lze zavolat z jiné části programu
        // string --> jaký typ dat to vyplivne
        // text --> název toho
        // text(double cislo) --> co to bude zpracovávat za typ dat
        //                    --> parametr >> může jich být víc oddělených čárkou    
        //                    --> to 'cislo' znamená název proměnné do které se uloží ty data

        // Shrnutí ----- funkce vrátí string (text), jmenuje se 'text' a sežere číslo typu 'double'
        // 'return' je to co tohle vrátí

        public string text(double cislo)
        {
            // tady se zpracuje to 'cislo', dělá se s tím co se potřebuje

            return Convert.ToString(cislo);

            // same as:...
            // textChanged = Convert.ToString(cislo);
            // return textChanged;
        }

        private double v;
        private string textVypis;

        private void radioButtonPlus_CheckedChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDownX.Value);
            int y = Convert.ToInt32(numericUpDownY.Value);

            if (radioButtonPlus.Checked)
            {
                v = x + y;
                textVypis = text(v);  // do 'textVypis' se uloží převod výsledku 'v' na string pomocí vlastní metody 'text' ^^
            }

            if (radioButtonMinus.Checked)
            {
                v = x - y;
                textVypis = text(v);
            }

            if (radioButtonKrat.Checked)
            {
                v = x * y;
                textVypis = text(v);
            }

            if (radioButtonDeleno.Checked)
            {
                if (y != 0)
                {
                    v = x / y;
                    textVypis = text(v);
                }
                else
                {
                    textVypis = "Dělení nulou";
                }
            }

            textBoxVysledek.Text = textVypis;
        }
    }
}