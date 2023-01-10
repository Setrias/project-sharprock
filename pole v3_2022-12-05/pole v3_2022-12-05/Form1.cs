using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole_v3_2022_12_05
{
    public partial class Form1 : Form
    {
        int pocet = 0, i;
        int[] a = new int[5];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxVypis.Visible = false;
            buttonMin.Visible = false;
            buttonMax.Visible = false;
            buttonPocetKladnych.Visible = false;

            labelMin.Text = "";
            labelMax.Text = "";
            labelPocetKladnych.Text = "";
        }

        private void buttonZapis_Click(object sender, EventArgs e)
        {
            a[pocet] = Convert.ToInt32(textBoxCislo.Text);
            pocet++;
            textBoxCislo.Focus();
            textBoxCislo.SelectAll();
            if(pocet == 5)
            {
                buttonZapis.Enabled = false;
                textBoxCislo.Enabled = false;
                listBoxVypis.Visible = true;
                buttonMin.Visible = true;
                buttonMax.Visible = true;
                buttonPocetKladnych.Visible = true;

                for (i = 0; i < pocet; i++) {
                    listBoxVypis.Items.Add(Convert.ToString(a[i]));
                }
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            // Nejmenší číslo

            int min = a[0];
            for(i = 1; i < pocet; i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            labelMin.Text = Convert.ToString(min);

        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            // Největší číslo

            int max = a[0];
            for (i = 0; i < pocet; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            labelMax.Text = Convert.ToString(max);
        }

        private void buttonPocetKladnych_Click(object sender, EventArgs e)
        {
            // Počet kladných
            int kladne = 0;
            for (i = 0; i < pocet; i++)
            {
                if (a[i] > 0)
                {
                    kladne++;
                }
            }
            labelPocetKladnych.Text = Convert.ToString(kladne);
        }
    }
}
