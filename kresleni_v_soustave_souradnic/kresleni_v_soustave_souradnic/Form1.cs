using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kresleni_v_soustave_souradnic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics kresPlocha;    // deklarace proměnné
        private Pen barva = Pens.Crimson;   // do proměnné 'barva' se uloží karmínová (crimson) barva

        struct kruznice     // deklarace proměnných potřebných pro kreslení kružnice ve 'struct'
        {
            public int polomer;
            public int sourX;   // zadané souřadnice X a Y
            public int sourY;
            public int hodnotaX;   // kde se vykreslí roh kružnice 
            public int hodnotaY;
        }

        private kruznice kruz;  // inicializace proměnné

        private void panelSoustava_Paint(object sender, PaintEventArgs e)
        {
            kresPlocha = panelSoustava.CreateGraphics();    // inicializace kreslící plochy

            kresPlocha.DrawLine(barva, 300, 0, 300, 600);   // nakreslení os
            kresPlocha.DrawLine(barva, 0, 300, 600, 300);
        }

        private void buttonZadat_Click(object sender, EventArgs e)      // po kliknutí na tlačítko...
        {
            kruz.polomer = Convert.ToInt32(numericUpDownPolomer.Value);
            kruz.sourX = Convert.ToInt32(numericUpDownX.Value);
            kruz.sourY = Convert.ToInt32(numericUpDownY.Value);

            kruz.hodnotaX = Convert.ToInt32(600 / 2 + kruz.sourX - kruz.polomer);   // vypočítá se hodnota X 'rohu' kružnice
            kruz.hodnotaY = Convert.ToInt32(600 / 2 - kruz.sourY - kruz.polomer);   // vypočítá se hodnota Y 'rohu' kružnice
            kresPlocha.DrawEllipse(barva, kruz.hodnotaX, kruz.hodnotaY, 2 * kruz.polomer, 2 * kruz.polomer);
        }
    }
}