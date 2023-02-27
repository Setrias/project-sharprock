using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtík_2023_02_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelUrceni.Text = "";
        }

        private Graphics kresPlocha;    // deklarace grafické plochy

        struct paramCtyr    // deklarace proměných ve struct
        {
            public int sirka;
            public int vyska;
        }

        private paramCtyr parametry;    // inicializace struct

        private void panelKresleni_Paint(object sender, PaintEventArgs e)
        {
            kresPlocha = panelKresleni.CreateGraphics();    // inicializace kreslící plochy
        }

        private void buttonNakreslit_Click(object sender, EventArgs e)
        {
            parametry.sirka = Convert.ToInt32(numericUpDownSirka.Value);    // uložení hodnot do proměnných
            parametry.vyska = Convert.ToInt32(numericUpDownVyska.Value);

            if (parametry.sirka == parametry.vyska)     // určení čtverec / obdelník
            {
                labelUrceni.Text = "Čtverec";
            }
            else
            {
                labelUrceni.Text = "Obdelník";
            }

            kresPlocha.DrawRectangle(Pens.Crimson, 80, 120, parametry.sirka, parametry.vyska);  // nakreslení čtyřúhelníku
        }

    }
}
