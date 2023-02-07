using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kresleni_kruznice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelKresPlocha_Paint(object sender, PaintEventArgs e)
        {
            Graphics kresPlocha = e.Graphics;

            kresPlocha.DrawLine(Pens.Black, 0,0,500,0);         // top horizontal
            kresPlocha.DrawLine(Pens.Red, 0,250,500,250);       // mid horizontal
            kresPlocha.DrawLine(Pens.Blue, 0,499,500,499);      // bottom horizontal

            kresPlocha.DrawLine(Pens.Blue, 0,0,0,500);          // left vertical
            kresPlocha.DrawLine(Pens.Green, 250,0,250,500);     // bottom vertical
            kresPlocha.DrawLine(Pens.BlueViolet, 499,0,499,500);    // right vertical

            kresPlocha.DrawEllipse(Pens.Red, 100,100,300,300);  // kružnice
        }
    }
}
