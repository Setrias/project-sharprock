using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace záznam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // deklarace struct pro uložení komplexního čísla (imaginární, reálná část)
        struct KomplexniCislo
        {
            public int realne;
            public int imaginarni;
        }

        private KomplexniCislo kompCislo;

        private void buttonVypocitat_Click(object sender, EventArgs e)
        {
            // vložení hodnot do proměnné
            kompCislo.realne = Convert.ToInt32(numericUpDownRealne.Value);
            kompCislo.imaginarni = Convert.ToInt32(numericUpDownImaginarni.Value);

            textBoxAbsolutniHodnota.Text = Convert.ToString(Math.Sqrt((kompCislo.realne * kompCislo.realne) +
                                                                      (kompCislo.imaginarni * kompCislo.imaginarni)));
        }
    }
}