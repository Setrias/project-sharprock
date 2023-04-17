using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_upravy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string veta;

        private void buttonVstup_Click(object sender, EventArgs e)
        {
            veta = textBoxVstup.Text;

            // počet znaků
            int pocetZnaku = veta.Length;
            textBoxPocetZnaku.Text = Convert.ToString(pocetZnaku);

            // počet slov oddělených mezerou
            // veta.Split(' ');
            int pocetSlov = 0;
            for (int i = 0; i < veta.Length; i++)
            {
                if (veta[i] == ' ')
                {
                    pocetSlov++;
                }

                textBoxPocetSlov.Text = Convert.ToString(pocetSlov + 1);
                // ++ protože za poslední mezerou je taky slovo
            }

            // počet Aček
            int pocetA = 0;
            for (int i = 0; i < veta.Length; i++)
            {
                if (veta[i] == 'a'|| veta[i] == 'A' || veta[i] == 'á'|| veta[i] == 'Á')
                {
                    pocetA++;
                }

                textBoxPocetA.Text = Convert.ToString(pocetA);
            }
        }

        private void buttonNahrazeni_Click(object sender, EventArgs e)
        {
            string vetaNahrazena = "";
            for (int i = 0; i < veta.Length; i++)
            {
                if (veta[i] != ' ')
                {
                    vetaNahrazena += veta[i];
                }
                else
                {
                    vetaNahrazena += ";";
                }

                textBoxNahrazeni.Text = vetaNahrazena;
            }
        }

        private void buttonVelkePrvni_Click(object sender, EventArgs e)
        {
            string vetaVelke = "";
            bool mezera = false;
            for (int i = 0; i < veta.Length; i++)
            {
                if (veta[i] != ' ')
                {
                    vetaVelke += veta[i];
                }
                else
                {
                    if (mezera)
                    {
                        vetaVelke += Char.ToUpper(veta[i]);
                        mezera = false;
                    }
                    else
                    {
                        vetaVelke += veta[i];
                    }
                    mezera = true;
                }

                textBoxVelkePrvni.Text = vetaVelke;
            }
        }
    }
}