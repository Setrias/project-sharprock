using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tvary_komplexniho_cisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelAlgebTvar.Text = "";
            labelGonioTvar.Text = "";
            labelExponTvar.Text = "";
        }

        struct komplexniCislo // datový typ (jako např 'int' nebo 'double')
        {
            public int realne;
            public int imaginarni;
        }

        private komplexniCislo komCis; // deklarace, stejně jako u např.: 'private int cislo;'

        private void buttonZadatHodnoty_Click(object sender, EventArgs e)
        {
            // přístup do jedné ze složek 'struct komplexniCislo'$
            komCis.realne = Convert.ToInt32(numericUpDownRealne.Value);
            komCis.imaginarni = Convert.ToInt32(numericUpDownImaginarni.Value);
        }

        private void buttonVypocet_Click(object sender, EventArgs e)
        {
            // absolutní hodnota
            double absolutniHodnota = Math.Sqrt((komCis.realne * komCis.realne) + (komCis.imaginarni * komCis.imaginarni));

            // úhel
            double uhel = Math.Atan(komCis.imaginarni / komCis.realne);

            // Algebraický tvar
            labelAlgebTvar.Text = Convert.ToString(komCis.realne + komCis.imaginarni);

            // Goniometrický tvar
            labelGonioTvar.Text = Convert.ToString(absolutniHodnota * (Math.Cos(uhel) + Math.Sin(uhel)));


            // Exponenciální tvar
            labelExponTvar.Text = Convert.ToString(absolutniHodnota * Math.Pow(Math.E, uhel));
        }
    }
}