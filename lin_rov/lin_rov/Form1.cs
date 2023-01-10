using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lin_rov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVysledek_Click(object sender, EventArgs e)
        {
            double x;
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    labelVysledek.Text = "Nekonečně řešení";
                } 
                else
                {
                    labelVysledek.Text = "Nemá řešení";
                }
            }
            else
            {
                x = -b / a;
                labelVysledek.Text = Convert.ToString(x);
            }
        }
    }
}
