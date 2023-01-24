using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace přepočet_z_trojúhelníku_na_hvězdu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxHvezda.Visible = false;
            groupBoxTrojuhelnik.Visible = false;
            groupBoxBtn.Visible = false;

            labelVysledekRa.Text = "";
            labelVysledekRb.Text = "";
            labelVysledekRc.Text = "";
            labelVysledekR1.Text = "";
            labelVysledekR2.Text = "";
            labelVysledekR3.Text = "";

            AcceptButton = buttonPrevod;
        }

        // Je možnost to počítat v celých (int) číslech nebo v reálných (double) stačí tyto dva datové typy všude zaměnit

        private int[] trojHvezda = new int[3];  // deklarace polí a proměnných k výpočtu
        private int[] hvezdaTroj = new int[3];
        private int ra, rb, rc, r1, r2, r3;

        private void checkBoxTrojuhelnikHvezda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrojuhelnikHvezda.Checked)  // když bude checkbox checked, druhý checked nebude, zviditelní se nebo zmizí groupBoxy
            {
                checkBoxHvezdaTrojuhelnik.Checked = false;

                groupBoxTrojuhelnik.Visible = true;
                groupBoxBtn.Visible = true;
            }
            else
            {
                groupBoxTrojuhelnik.Visible = false;
                groupBoxHvezda.Visible = false;
                groupBoxBtn.Visible = false;
            }
        }

        private void checkBoxHvezdaTrojuhelnik_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHvezdaTrojuhelnik.Checked)  // pro převod hvězda > trojúhelník
            {
                checkBoxTrojuhelnikHvezda.Checked = false;

                groupBoxHvezda.Visible = true;
                groupBoxTrojuhelnik.Visible = false;
                groupBoxBtn.Visible = true;
            }
            else
            {
                groupBoxHvezda.Visible = false;
                groupBoxBtn.Visible = false;
            }
        }

        private void buttonPrevod_Click(object sender, EventArgs e)
        {
            if (checkBoxTrojuhelnikHvezda.Checked)
            {
                try     // zkouška jestli jsou zadané čísla
                {
                    r1 = Convert.ToInt32(textBoxR1.Text);
                    r2 = Convert.ToInt32(textBoxR2.Text);
                    r3 = Convert.ToInt32(textBoxR3.Text);

                    if ((r1 > 0) && (r2 > 0) && (r3 > 0))   // když jsou všechny kladné
                    {
                        trojHvezda = vypocetTrojuhelnikHvezda(r1, r2, r3);  // zavolá se funkce která vypočítá převod a uloží výsledné hodnoty do pole
                                                                            // které se tady vypíšou do labelů, to samé pro druhý checkbox níže
                        labelVysledekRa.Text = trojHvezda[0].ToString();
                        labelVysledekRb.Text = trojHvezda[1].ToString();
                        labelVysledekRc.Text = trojHvezda[2].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Zadané odpory musí být kladné a větší než nula.");
                    }
                }
                catch
                {
                    MessageBox.Show("Zadej čísla.");
                }
            }
            else if (checkBoxHvezdaTrojuhelnik.Checked)
            {
                try
                {
                    ra = Convert.ToInt32(textBoxRa.Text);
                    rb = Convert.ToInt32(textBoxRb.Text);
                    rc = Convert.ToInt32(textBoxRc.Text);

                    if ((ra > 0) && (rb > 0) && (rc > 0))
                    {
                        hvezdaTroj = vypocetHvezdaTrojuhelnik(ra, rb, rc);

                        labelVysledekR1.Text = hvezdaTroj[0].ToString();
                        labelVysledekR2.Text = hvezdaTroj[1].ToString();
                        labelVysledekR3.Text = hvezdaTroj[2].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Zadané odpory musí být kladné a větší než nula.");
                    }
                }
                catch
                {
                    MessageBox.Show("Zadej čísla.");
                }
            }
        }

        public int[] vypocetTrojuhelnikHvezda(int r1, int r2, int r3)   // funkce vrací celočíselné pole
        {
            int[] poleHodnoty = new int[3];     // vytvoření lokálního pole

            ra = (r1 * r2) / (r1 + r2 + r3);    // výpočty
            rb = (r2 * r3) / (r1 + r2 + r3);
            rc = (r1 * r3) / (r1 + r2 + r3);

            poleHodnoty[0] = ra;    // na místa v poli se uloží vypočtené hodnoty
            poleHodnoty[1] = rb;
            poleHodnoty[2] = rc;

            return poleHodnoty;     // pole se vrátí na místo kde byla funkce zavolána a pole je uloženo do celočíselného pole s názvem 'trojHvezda'
        }

        public int[] vypocetHvezdaTrojuhelnik(int ra, int rb, int rc)
        {
            int[] poleHodnoty = new int[3];

            r1 = ra + rc + ((ra * rc) / rb);
            r2 = ra + rb + ((ra * rb) / rc);
            r3 = rb + rc + ((rb * rc) / ra);

            poleHodnoty[0] = r1;
            poleHodnoty[1] = r2;
            poleHodnoty[2] = r3;

            return poleHodnoty;     // pole se vrátí na místo kde byla funkce zavolána a pole je uloženo do celočíselného pole s názvem 'hvezdaTroj'
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxRa.Text = "";
            textBoxRb.Text = "";
            textBoxRc.Text = "";
            textBoxR1.Text = "";
            textBoxR2.Text = "";
            textBoxR3.Text = "";

            labelVysledekRa.Text = "";
            labelVysledekRb.Text = "";
            labelVysledekRc.Text = "";
            labelVysledekR1.Text = "";
            labelVysledekR2.Text = "";
            labelVysledekR3.Text = "";

            groupBoxHvezda.Visible = false;
            groupBoxTrojuhelnik.Visible = false;
            groupBoxBtn.Visible = false;

            checkBoxHvezdaTrojuhelnik.Checked = false;
            checkBoxTrojuhelnikHvezda.Checked = false;
        }
    }
}