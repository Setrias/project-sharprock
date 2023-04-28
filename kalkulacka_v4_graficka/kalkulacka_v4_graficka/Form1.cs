using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulacka_v4_graficka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void klasickáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uiClassic.Visible = true;
        }

        private void převodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uiClassic.Visible = false;
        }
    }
}