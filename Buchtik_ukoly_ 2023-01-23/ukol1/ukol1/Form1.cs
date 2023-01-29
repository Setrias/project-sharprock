using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxZadCislo.Enabled = false;
            buttonZadatCislo.Enabled = false;
        }

        private int zadCislo, pocetZadCisel, pocetAktZadanych; 
        // 'pocetZadCisel' je kolik chci zadávat ---- 'pocetAktZadanych' je použitý při ukládání do pole
        private int[] poleCisel;    // deklarace pole

        private void buttonZadatPocetCisel_Click(object sender, EventArgs e)
        {
            try
            {
                pocetZadCisel = Convert.ToInt32(textBoxPocetZadanychCisel.Text);

                if (pocetZadCisel > 0)
                {
                    poleCisel = new int[pocetZadCisel];     // vytvoření pole

                    textBoxPocetZadanychCisel.Enabled = false;
                    buttonZadatPocetCisel.Enabled = false;

                    textBoxZadCislo.Enabled = true;
                    buttonZadatCislo.Enabled = true;

                    AcceptButton = buttonZadatCislo;
                }
                else
                {
                    MessageBox.Show("Zadej kladné číslo");
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }

        private void buttonZadatCislo_Click(object sender, EventArgs e)
        {
            try
            {
                zadCislo = Convert.ToInt32(textBoxZadCislo.Text);

                poleCisel[pocetAktZadanych] = zadCislo;     // do pole se uloží zadaná hodnota
                pocetAktZadanych++;

                if (pocetAktZadanych == pocetZadCisel)      // když se počet požadovaných rovná počtu aktuálně zadaných, pole se vypíše do listboxu
                {
                    for (int i = 0; i < pocetZadCisel; i++)
                    {
                        listBoxCisla.Items.Add(poleCisel[i]);
                    }

                    textBoxZadCislo.Enabled = false;
                    buttonZadatCislo.Enabled = false;
                }

                textBoxZadCislo.Focus();
                textBoxZadCislo.SelectAll();
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }
    }
}