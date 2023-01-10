using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obvod__obsah__úhlopříčka_čtverce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVysledek_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBoxA.Text);

            labelVysledekObvod.Text = Convert.ToString(a * 4);
            labelVysledekObsah.Text = Convert.ToString(a * a);
            labelVysledekUhlop.Text = Convert.ToString(Math.Round(a * Math.Sqrt(2), 5));
        }
    }
}
