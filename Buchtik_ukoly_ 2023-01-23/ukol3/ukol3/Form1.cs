using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int zadCislo, pocetZadanych;
        private int[] poleCisla = new int[50];

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            try
            {
                zadCislo = Convert.ToInt32(textBoxCisla.Text);

                if (!(zadCislo < 0))    // když zadané číslo není menší než 0
                {
                    poleCisla[pocetZadanych] = zadCislo;    // uložení do pole
                    pocetZadanych++;

                    if (pocetZadanych == 50)    // po zadání posledního čísla
                    {
                        textBoxCisla.Enabled = false;
                        buttonZadat.Enabled = false;

                        for (int i = 0; i < 50; i++)
                        {
                            listBoxCisla.Items.Add(poleCisla[i]);   // vypsání pole do listBoxu
                        }
                    }
                }
                else    // vypsání do pole do listBoxu když je číslo menší než 0
                {
                    textBoxCisla.Enabled = false;
                    buttonZadat.Enabled = false;

                    for (int i = 0; i < pocetZadanych; i++)
                    {
                        listBoxCisla.Items.Add(poleCisla[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo");
            }
        }
    }
}