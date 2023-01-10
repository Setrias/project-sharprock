using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int nahCislo, pocetPokusu = 0, zadCislo;
        private Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPocetPokusu.Text = "";
            labelNapoveda.Text = "";
            pictureBoxWin.Visible = false;

            labelNapoveda.Visible = false;
            buttonZadat.Enabled = false;
            buttonRestart.Visible = false;
            textBoxZadat.Enabled = false;
        }

        private void buttonZacit_Click(object sender, EventArgs e)
        {
            nahCislo = r.Next(0, 50);
            buttonZacit.Enabled = false;
            labelNapoveda.Visible = true;
            buttonZadat.Enabled = true;
            buttonRestart.Visible = true;
            textBoxZadat.Enabled = true;
            textBoxZadat.Focus();
        }

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            try
            {
                zadCislo = Convert.ToInt32(textBoxZadat.Text);
                pocetPokusu++;
                labelPocetPokusu.Text = Convert.ToString(pocetPokusu);

                textBoxZadat.Focus();
                textBoxZadat.SelectAll();

                if (zadCislo == nahCislo)
                {
                    pictureBoxWin.Visible = true;

                    labelNapoveda.Visible = false;
                    buttonZadat.Enabled = false;

                    textBoxZadat.Enabled = false;
                }
                else
                {
                    if (zadCislo > nahCislo)
                    {
                        labelNapoveda.Text = "Zadej menší ";
                    }
                    else
                    {
                        labelNapoveda.Text = "Zadej větší ";
                    }
                }

                if (pocetPokusu > 5)
                {
                    labelPocetPokusu.ForeColor = Color.Red;
                }

                if (pocetPokusu > 10)
                {
                    if ((nahCislo - zadCislo < 5) && (nahCislo - zadCislo + 5 > 5))
                    {
                        labelNapoveda.Text += "o +/- 4";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Zadej číslo!");
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            pocetPokusu = 0;
            labelPocetPokusu.Text = Convert.ToString(pocetPokusu);
            buttonZacit.Enabled = true;

            pictureBoxWin.Visible = false;

            labelNapoveda.Visible = false;
            buttonZadat.Enabled = false;
            textBoxZadat.Enabled = false;
            buttonRestart.Visible = false;
        }
    }
}