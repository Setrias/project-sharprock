using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace david_01
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
            double a = Convert.ToInt32(textBoxA.Text);
            double b = Convert.ToInt32(textBoxB.Text);
            double c = Convert.ToInt32(textBoxC.Text);

            if (a == 0)
            {
                if (b == 0)
                {
                    labelVysledekA.Text = "Nekonečně mnoho řešení";
                } else
                {
                    labelVysledekA.Text = "Nemá řešení";
                }
            } else
            {
                x = -b / a;
                labelVysledekA.Text = Convert.ToString(x);
            }

            {
                x = (a + b) / c;
                labelVysledekB.Text = Convert.ToString(x);
            }

            {
                x = b * c - a;
                labelVysledekC.Text = Convert.ToString(x);
            }
        }
    }
}
