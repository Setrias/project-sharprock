using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kresleni_mrizky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelMrizka_Paint(object sender, PaintEventArgs e)
        {
            Graphics kresPlocha = e.Graphics;

            int horizontalni = 0, vertikalni = 0;

            // horizontální výpis čar
            for (int i = 0; i < 11; i++)
            {
                kresPlocha.DrawLine(Pens.DarkRed, 0, vertikalni, 600, vertikalni);
                vertikalni += 60;
            }

            // vertikální výpis čar
            for (int i = 0; i < 11; i++)
            {
                kresPlocha.DrawLine(Pens.DarkRed, horizontalni, 0, horizontalni, 600);
                horizontalni += 60;
            }
        }
    }
}