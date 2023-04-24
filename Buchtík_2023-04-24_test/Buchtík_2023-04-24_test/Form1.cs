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

namespace Buchtík_2023_04_24_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            string veta = textBoxUkol1.Text;
            using (StreamWriter sWriter = new StreamWriter("vety.txt", true))
            {
                if (File.Exists("vety.txt"))
                {
                    sWriter.WriteLine(veta);
                    sWriter.Flush();
                }
            }
        }

        string vetaUkol2;
        int pocetSlov;

        private void buttonPocetSlov_Click(object sender, EventArgs e)
        {
            vetaUkol2 = textBoxUkol2.Text;

            for (int i = 0; i < vetaUkol2.Length; i++)
            {
                if (vetaUkol2[i] == ' ')
                {
                    pocetSlov++;
                }
            }

            textBoxPocetSlov.Text = Convert.ToString(pocetSlov + 1);
        }

        private string vetaUkol3;

        private void buttonDruhVety_Click(object sender, EventArgs e)
        {
            vetaUkol3 = textBoxUkol3.Text;
            for (int i = 0; i < vetaUkol3.Length; i++)
            {
                int delkaVety = vetaUkol3.Length;
                if (vetaUkol3[delkaVety - 1] == '.')
                {
                    textBoxDruhVety.Text = "Věta oznamovací.";
                }
                else if (vetaUkol3[delkaVety - 1] == '?')
                {
                    textBoxDruhVety.Text = "Věta tázací.";
                }
                else if (vetaUkol3[delkaVety - 1] == '!')
                {
                    textBoxDruhVety.Text = "Věta rozkazovací.";
                }
                else
                {
                    textBoxDruhVety.Text = "Žádná z vět.";
                }
            }
        }

        private string vetaUkol4;

        private void buttonPrvniSlovo_Click(object sender, EventArgs e)
        {
            textBoxPrvniSlovo.Text = "";
            vetaUkol4 = textBoxUkol4.Text;
            for (int i = 0; i < vetaUkol4.Length; i++)
            {
                if (vetaUkol4[i] != ' ')
                {
                    textBoxPrvniSlovo.Text += vetaUkol4[i];
                }
                else
                {
                    break;
                }
            }
        }
    }
}