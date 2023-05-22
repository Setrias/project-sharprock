using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slunecni_soustava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string nazevTelesa;
        private double obeznaDobaLet, obeznaDobaSec, vzdalenostAu, vzdalenostKm, prumernaRychlost;
        private double astroUnit = 149597871;
        private StreamWriter sWriter;
        private StreamReader sReader;

        private void buttonVypocitat_Click(object sender, EventArgs e)
        {
            nazevTelesa = textBoxNazevPlanety.Text;
            if (nazevTelesa.Trim() == "")
            {
                MessageBox.Show("Zadej název planety.");
                return;
            }

            // když bude zadané něco jiného než číslo
            try
            {
                obeznaDobaLet = Convert.ToDouble(textBoxObeznaDoba.Text);
            }
            catch
            {
                MessageBox.Show("Zadej dobu v letech.");
                return;
            }

            // výpočet vzdálenosti od slunce
            vzdalenostAu = Math.Pow(Math.Pow(obeznaDobaLet, 2), 1.0 / 3.0);
            textBoxVzdalenostAu.Text = vzdalenostAu.ToString();

            vzdalenostKm = vzdalenostAu * astroUnit;
            textBoxVzdalenostKm.Text = vzdalenostKm.ToString();

            // výpočet průměrné rychlosti tělesa v kms-1
            obeznaDobaSec = obeznaDobaLet * 365 * 24 * 60 * 60;
            prumernaRychlost = (2 * Math.PI * vzdalenostKm) / obeznaDobaSec;
            textBoxPrumernaRychlost.Text = prumernaRychlost.ToString();

            // zápis výsledků do souboru

            sWriter = new StreamWriter("zapis_planet.txt", true);
            if (File.Exists("zapis_planet.txt"))
            {
                sWriter.WriteLine($"Planeta: {nazevTelesa}, oběžná doba [roky]: {obeznaDobaLet}, vzdálenost v AU: {vzdalenostAu}");
                sWriter.Flush();
                sWriter.Close();
            }
            else
            {
                MessageBox.Show("Soubor neexistuje");
            }
        }

        private void buttonVypis_Click(object sender, EventArgs e)
        {
            if (File.Exists("zapis_planet.txt"))
            {
                sReader = new StreamReader("zapis_planet.txt");
                string souborRadek;
                while ((souborRadek = sReader.ReadLine()) != null)
                {
                    listBoxVypis.Items.Add(souborRadek);
                }
                sReader.Close();
            }
            else
            {
                MessageBox.Show("Soubor se záznamy neexistuje.");
            }
        }
    }
}