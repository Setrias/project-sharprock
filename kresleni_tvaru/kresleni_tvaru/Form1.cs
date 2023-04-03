using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kresleni_tvaru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int strana, panelSize = 200;
        private Graphics kresPlocha;
        
        private void panelTvary_Paint(object sender, PaintEventArgs e)
        {
            kresPlocha = panelTvary.CreateGraphics();
        }
        
        private void buttonVykreslit_Click(object sender, EventArgs e)
        {
            try
            {
                strana = Convert.ToInt32(textBoxStrana.Text);

                if (strana < 200)
                {
                    if (radioButtonKrizekX.Checked)
                    {
                
                    }

                    if (radioButtonTrojuhelnik.Checked)
                    {
                
                    }

                    if (radioButtonKrizekPlus.Checked)
                    {
                
                    }
                }
                else
                {
                    MessageBox.Show("Strana nesmí být větší než 200.");
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo.");
            }
        }
    }
}