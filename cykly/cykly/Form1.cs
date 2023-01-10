using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cykly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSuda_Click(object sender, EventArgs e)
        {
            int n, i;
            labelSuda.Text = "Sudá ";
            try
            {
                n = Convert.ToInt32(textBoxA.Text);
                if (n > 0)
                {
                    for (i = 0; i <= n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            labelSuda.Text = labelSuda.Text + " " + Convert.ToString(i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("nezadal správně číslo");
                }
                
            }
            catch
            {
                MessageBox.Show("není zadáno správné číslo");
            }
        }
    }
}
