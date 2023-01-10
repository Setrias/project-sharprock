using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        int i;
        int n = 20;
        int[] a = new int[20];
        Random r = new Random();

        private void buttonGenerace_Click(object sender, EventArgs e)
        {
            // 1. Generace čísel


            // Nastavení mezí
            int dolMez, horMez;
            // Výchozí hodnoty
            dolMez = 0;
            horMez = 0;
            // Hodnota zadaná uživatelem
            try
            {
                dolMez = Convert.ToInt32(textBoxDolMez.Text);
                horMez = Convert.ToInt32(textBoxHorMez.Text);

                if (dolMez < horMez)
                {
                    for (i = 0; i < n; i++)
                    {
                        a[i] = r.Next(dolMez, horMez);
                    }
                }
                else
                {
                    MessageBox.Show("Horní mez nesmí být větší než dolní mez!");
                }
            }
            catch
            {
                MessageBox.Show("Zadej horní a dolní mez! Musí obsahovat pouze čísla!");
            }
        }

        private void buttonVypis_Click(object sender, EventArgs e)
        {
            // 2. Výpis čísel do listBoxu z pole
            listBoxPole.Items.Clear();
            for (i = 0; i < n; i++)
            {
                listBoxPole.Items.Add(a[i]);
            }

            // Nastaví textBoze mezí aby nešly upravit
            textBoxDolMez.ReadOnly = true;
            textBoxHorMez.ReadOnly = true;
        }

        private void buttonVymaz_Click(object sender, EventArgs e)
        {
            // 3. Vymazání listBoxu
            listBoxPole.Items.Clear();

            // Nastaví textBoze mezí aby se daly upravit
            textBoxDolMez.ReadOnly = false;
            textBoxHorMez.ReadOnly = false;

            // Vymaže součty
            textBoxSoucet.Text = "";
            textBoxSoucetVetPad.Text = "";

            // Vymaže pole
            for (i = 0; i < n; i++)
            {
                a[i] = r.Next(0, 0);
            }
        }

        private void buttonSoucet_Click(object sender, EventArgs e)
        {
            // 4. Součet všech čísel
            int soucet = 0;
            for (i = 0; i < n; i++)
            {
                soucet = soucet + a[i];
            }

            textBoxSoucet.Text = Convert.ToString(soucet);
        }

        private void buttonSoucetVetPad_Click(object sender, EventArgs e)
        {
            // 5. Součet čísel větších než 50
            int soucet = 0;
            for (i = 0; i < n; i++)
            {
                if (a[i] > 50)
                {
                    soucet = soucet + a[i];
                }

                textBoxSoucetVetPad.Text = Convert.ToString(soucet);
            }
        }
    }
}