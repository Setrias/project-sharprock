using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hra_hadani_cisel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBoxHra.Visible = false;
            labelWin.Visible = false;
            labelNapoveda.Visible = false;
            AcceptButton = buttonPlay;
        }

        private string jmeno;
        private Random nahodneCislo = new Random();
        private int hadaneCislo, zadaneCislo, pocetPokusu;
        private StreamWriter sWriter;
        private StreamReader sReader;

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            jmeno = textBoxJmeno.Text;
            hadaneCislo = nahodneCislo.Next(0, 21);
            groupBoxHra.Visible = true;
            buttonPlay.Enabled = false;
            textBoxJmeno.Enabled = false;
            AcceptButton = buttonHadat;
        }

        private void buttonHadat_Click(object sender, EventArgs e)
        {
            try
            {
                zadaneCislo = Convert.ToInt32(textBoxCislo.Text);
                pocetPokusu++;
                textBoxPocetPokusu.Text = Convert.ToString(pocetPokusu);
                if (zadaneCislo == hadaneCislo)
                {
                    labelWin.Visible = true;
                    buttonHadat.Enabled = false;
                    
                    sWriter = new StreamWriter("zapis.txt", true);
                    if (File.Exists("zapis.txt"))
                    {
                        sWriter.WriteLine("Jméno: " + jmeno + ", počet pokusů: " + pocetPokusu);
                        sWriter.Flush();
                        sWriter.Close();
                    }
                    else
                    {
                        MessageBox.Show("Výsledek nešel zapsat, soubor neexistuje.");
                    }
                }

                if (pocetPokusu > 5)
                {
                    labelNapoveda.Visible = true;
                    if (zadaneCislo > hadaneCislo)
                    {
                        labelNapoveda.Text = "Hádané číslo je menší.";
                    }
                    else
                    {
                        labelNapoveda.Text = "Hádané číslo je větší.";
                    }

                    if (pocetPokusu > 10)
                    {
                        textBoxPocetPokusu.ForeColor = Color.DarkRed;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo.");
            }

            ActiveControl = textBoxCislo;
            AcceptButton = buttonHadat;
            textBoxCislo.SelectAll();
        }

        private void buttonVysledky_Click(object sender, EventArgs e)
        {
            if (File.Exists("zapis.txt"))
            {
                listBoxVysledky.Items.Clear();
                string souborRadek;
                sReader = new StreamReader("zapis.txt");
                while ((souborRadek = sReader.ReadLine()) != null)
                {
                    listBoxVysledky.Items.Add(souborRadek);
                }

                sReader.Close();
            }
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            groupBoxHra.Visible = false;
            buttonPlay.Enabled = true;
            buttonHadat.Enabled = true;
            pocetPokusu = 0;
            labelWin.Visible = false;
            labelNapoveda.Visible = false;
            textBoxPocetPokusu.Text = "";
            textBoxPocetPokusu.ForeColor = Color.Black;
            textBoxCislo.Text = "";
            textBoxJmeno.Enabled = true;
        }
    }
}