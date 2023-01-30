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

        struct komplexniCislo // datový typ (jako např 'int' nebo 'double')
        {
            public int realne;
            public int imaginarni;
        }

        private komplexniCislo kompCislo; // deklarace, stejně jako u např.: 'private int cislo;'

        private void buttonZadatHodnoty_Click(object sender, EventArgs e)
        {
            // přístup do jedné ze složek 'struct komplexniCislo'$
            kompCislo.realne = Convert.ToInt32(numericUpDownRealne.Value);
            kompCislo.imaginarni = Convert.ToInt32(numericUpDownImaginarni.Value);

            numericUpDownRealne.Enabled = false;
            numericUpDownImaginarni.Enabled = false;
            buttonZadatHodnoty.Enabled = false;
        }

        private void buttonVypocet_Click(object sender, EventArgs e)
        {
            // labelAlgebTvar.Text = kompCislo.realne + " + i" + kompCislo.imaginarni;   // výpis '2 + i2'
            labelAlgebTvar.Text = Convert.ToString(kompCislo.realne + kompCislo.imaginarni);


            // nefim
            labelGonioTvar.Text = Convert.ToString(Math.Cos(kompCislo.realne)+Math.Sin(kompCislo.imaginarni));



            // výpočet absolutní hodnoty
            double absolutniHodnota =
                Math.Sqrt((kompCislo.realne * kompCislo.realne) + (kompCislo.imaginarni * kompCislo.imaginarni));
            // výpočet exponenciálního tvaru
            labelExponTvar.Text = Convert.ToString(absolutniHodnota * Math.Pow(Math.E, Math.Atan(kompCislo.imaginarni)));
        }
    }
}