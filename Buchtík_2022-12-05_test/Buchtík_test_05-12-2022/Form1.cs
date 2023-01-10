using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtík_test_05_12_2022
{
    public partial class Form1 : Form
    {
        int zadCislo, prumer = 0, pocetCisel;

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonPrumer.Enabled = false;
            labelPrumer.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZapis_Click(object sender, EventArgs e)
        {
            try
            {
                zadCislo = Convert.ToInt32(textBoxCislo.Text);
                if(pocetCisel <= 5)
                {
                    listBoxPole.Items.Add(zadCislo);
                    pocetCisel++;
                    prumer += zadCislo;
                }
                if(pocetCisel == 5)
                {
                    buttonZapis.Enabled = false;
                    buttonPrumer.Enabled = true;
                    textBoxCislo.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo, číslo musí být celé!");
            }
        }
        private void buttonPrumer_Click(object sender, EventArgs e)
        {
            prumer = prumer / pocetCisel;
            labelPrumer.Text = Convert.ToString(prumer);
        }
    }
}
