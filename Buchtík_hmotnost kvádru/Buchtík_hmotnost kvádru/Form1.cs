using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtík_hmotnost_kvádru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelVysledek.Text = "";
        }

        private void buttonVysledek_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, V = 0, m, Ro = 0;
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                c = Convert.ToDouble(textBoxC.Text);

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    //když budou čísla a, b, c záporné nebo nulové ukáže se error v msgBoxu
                    MessageBox.Show("Hodnota nemůže být nula nebo záporná"); 
                } else
                {
                    V = a * b * c;
                }
                
                if(radioButtonLed.Checked)
                {
                    Ro = 970;
                }
                if (radioButtonHlinik.Checked)
                {
                    Ro = 2700;
                }
                if (radioButtonZelezo.Checked)
                {
                    Ro = 7800;
                }

                labelVysledek.Text = Convert.ToString(V * Ro) + " Kg";
            }
            catch
            {
                MessageBox.Show("Špatně zadané hodnoty");
            }
        }
    }
}
