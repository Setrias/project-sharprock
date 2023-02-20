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

        private Graphics kresPlocha;
        private Pen barva = Pens.Crimson;

        struct kruznice
        {
            public int polomer;
            public int sourX;
            public int sourY;
            public int hodnotaX;
            public int hodnotaY;
        }

        private kruznice kruz;

        private void panelSoustava_Paint(object sender, PaintEventArgs e)
        {
            kresPlocha = e.Graphics;

            kresPlocha.DrawLine(barva, 300, 0, 300, 600);
            kresPlocha.DrawLine(barva, 0, 300, 600, 300);
        }

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            kruz.polomer = Convert.ToInt32(numericUpDownPolomer.Value);
            kruz.sourX = Convert.ToInt32(numericUpDownX.Value);
            kruz.sourY = Convert.ToInt32(numericUpDownY.Value);

            kruz.hodnotaX = Convert.ToInt32(300 + kruz.sourX - kruz.polomer);
            kruz.hodnotaY = Convert.ToInt32(300 + kruz.sourY - kruz.polomer);
            kresPlocha.DrawEllipse(barva, kruz.hodnotaX, kruz.hodnotaY, kruz.polomer, kruz.polomer);
        }
    }
}