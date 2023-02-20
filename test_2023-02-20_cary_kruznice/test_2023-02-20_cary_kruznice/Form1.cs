using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_2023_02_20_cary_kruznice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelTest_Paint(object sender, PaintEventArgs e)
        {
            Graphics kresPanel = e.Graphics;

            kresPanel.DrawLine(Pens.Crimson, 0, 0, 300, 200);
            kresPanel.DrawLine(Pens.Crimson, 150, 0, 150, 200);

            kresPanel.DrawEllipse(Pens.Crimson, 0, 160, 40, 40);
        }
    }
}