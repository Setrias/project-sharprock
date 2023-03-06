using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struct_array_vazena_znamka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct hodnoceni
        {
            public double znamka;
            public int vaha;
        }

        // struct array
        private hodnoceni[] hod = new hodnoceni[50];

        private int pocetZadanych;
        private double prumer, soucet, soucetVaha;
        string vypis;

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            hod[pocetZadanych].znamka = Convert.ToDouble(numericUpDownZnamka.Value);
            hod[pocetZadanych].vaha = Convert.ToInt32(numericUpDownVaha.Value);

            pocetZadanych++;
            textBoxPocetZadanych.Text = Convert.ToString(pocetZadanych);
        }

        private void buttonKonec_Click(object sender, EventArgs e)
        {
            buttonZadat.Enabled = false;
            buttonKonec.Enabled = false;

            // výpis do listBoxu ve tvaru 'známka: , váha: '

            for (int i = 0; i < pocetZadanych; i++)
            {
                vypis = "hodnoceni: " + Convert.ToString(hod[i].znamka) + ", váha: " + Convert.ToString(hod[i].vaha);
                listBoxPrehled.Items.Add(vypis);
            }

            // vážený průměr známek

            for (int i = 0; i < pocetZadanych; i++)
            {
                soucet += hod[i].znamka * hod[i].vaha;
                soucetVaha += hod[i].vaha;
            }

            prumer = soucet / soucetVaha;
            textBoxPrumer.Text = Convert.ToString(prumer);
        }
    }
}