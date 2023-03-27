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

namespace soubory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string jmeno;
        private FileStream fs;

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            jmeno = textBoxJmeno.Text;
            if (jmeno.Trim() != "")
            {
                using (StreamWriter sWriter = new StreamWriter("seznam.txt", true))
                    // otevře soubor; "jmeno, true" >> true povoluje 'append' textu, jinak by se pořád přepisoval
                {
                    sWriter.WriteLine(jmeno); // zapsat řádek
                    sWriter.Flush(); // forced z mezipaměti
                }
            }
            else
            {
                MessageBox.Show("Zadej jméno");
            }
        }

        private void buttonVypis_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxVypis.Items.Clear();
                using (StreamReader sReader = new StreamReader("seznam.txt"))
                {
                    string souborRadek;
                    while ((souborRadek = sReader.ReadLine()) != null)
                    {
                        listBoxVypis.Items.Add(souborRadek);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Soubor neexistuje!");
            }
        }
    }
}