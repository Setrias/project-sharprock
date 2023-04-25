﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_username
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string jmeno, prijmeni;

        string jmenoShort;
        string prijmeniShort;

        private void buttonVytvorit_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            jmeno = textBoxJmeno.Text;
            prijmeni = textBoxPrijmeni.Text;

            /////////////////////////////////////////////////////

            // 1. Možnost datumů
            // int rok = DateTime.Today.Year % 100;
            // string rokDve = rok.ToString("D2");     // 'rok.ToString("D2")' určuje že číslo bude vždy na 2 místa (např.: 01,02,05,09,23,42...)
            // int mesic = DateTime.Today.Month;

            // 1. Možnost zkrácení slov (při opětovném stisknutí tlačítka by se musel 'jmenoShort' a 'prijmeniShort' "vynulovat"(jmenoShort = "";))
            // for (int i = 0; i < 3; i++)
            // {
                // prijmeniShort += prijmeni[i];
            // }

            // for (int i = 0; i < 2; i++)
            // {
                // jmenoShort += jmeno[i];
            // }

            // textBoxUsername.Text = rokDve + mesic.ToString("D2") + prijmeniShort + jmenoShort;

            /////////////////////////////////////////////////////

            // 2. Možnost datumů (Substring = "počáteční znak, jak dlouhý bude")
            // string rokDve = DateTime.Today.Year.ToString().Substring(2, 2);

            /////////////////////////////////////////////////////

            // 3. Možnost datumů (Podobné PHP, v uvozovkách je formát)
            // Dvouciferný rok
            string rokDve = DateTime.Today.ToString("yy");

            // Dvouciferný měsíc (Při jednom "M" by to bylo např.: "April 18")
            string mesic = DateTime.Today.ToString("MM");

            /////////////////////////////////////////////////////


            // 2. Možnost zkrácení slov (Zase Substring = "od kama, jak dlouhé")
            prijmeniShort = prijmeni.Substring(0, 3);
            jmenoShort = jmeno.Substring(0, 2);


            // Výpis
            textBoxUsername.Text = rokDve + mesic + prijmeniShort + jmenoShort;
        }
    }
}