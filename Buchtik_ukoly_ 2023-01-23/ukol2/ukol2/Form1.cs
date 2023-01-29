using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int zadCislo, pocetZadanych;
        private int[] poleCisel = new int[50];

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = buttonZadat;     // aby program bral klávesu 'Enter' jako stisk tlačítka
        }

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            try
            {
                zadCislo = Convert.ToInt32(textBoxZadat.Text);

                if (zadCislo != 0)
                {
                    poleCisel[pocetZadanych] = zadCislo;    // uložení do pole
                    pocetZadanych++;

                    if (pocetZadanych == 50)    // po zadání posledního čísla se pole vypíše do listBoxu
                    {
                        textBoxZadat.Enabled = false;
                        buttonZadat.Enabled = false;

                        for (int i = 0; i < pocetZadanych; i++)
                        {
                            listBoxCisla.Items.Add(poleCisel[i]);   // přidat položku do listBoxu
                        }
                    }
                }
                else    // když se zadá nula, pole se vypíše do listBoxu
                {
                    textBoxZadat.Enabled = false;
                    buttonZadat.Enabled = false;

                    for (int i = 0; i < pocetZadanych; i++)
                    {
                        listBoxCisla.Items.Add(poleCisel[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }

            textBoxZadat.Focus();
            textBoxZadat.SelectAll();
        }
    }
}