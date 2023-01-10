using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole
{
    public partial class Form1 : Form
    {
        int pocet = 0; //kolik je zadaných prvků
        int[] a = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVysledek_Click(object sender, EventArgs e)
        {
            pocet++; //zvýším počet o 1
            a[pocet - 1] = Convert.ToInt32(textBoxCislo.Text);
            if(pocet == 10)
            {
                buttonVysledek.Enabled = false;
            }
        }
    }
}
