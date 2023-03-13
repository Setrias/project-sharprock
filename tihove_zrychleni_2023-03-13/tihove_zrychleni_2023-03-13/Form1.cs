using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tihove_zrychleni_2023_03_13
{
    public partial class Form1 : Form
    {
        // Vypočítejte tíhové zrychlení s využitím volného pádu, provedeme n měření, kuličku
        // spouštíme z výšky l, měříme čas t, pro každé měření vypočítat tíhové zrychlení,
        // výsledné zrychlení je pak průměrem těchto hodnot

        public Form1()
        {
            InitializeComponent();
        }

        struct tihoveZrychleni
        {
            public double cas;
            public double vyska;
            public double tihZrych;
        }

        private tihoveZrychleni[] mereni = new tihoveZrychleni[20];

        private void buttonZadat_Click(object sender, EventArgs e)
        {

        }
    }
}
