using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obvod_obdelníku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cisloA = Convert.ToInt32(textBoxA.Text);
            int cisloB = Convert.ToInt32(textBoxB.Text);

            labelVysledekObvod.Text = Convert.ToString(cisloA * 2 + cisloB * 2);
        }
    }
}
