using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hraci_pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics hraciPole;

        struct zetonyPar
        {
            public int poziceX;
            public int poziceY;
            public string barva;
        }

        private zetonyPar[] zeton = new zetonyPar[6];

        private int rozmer = 10, pocetZetonu, sourX, sourY;

        private Pen pero = new Pen(Color.Crimson, 3);
        private Brush point = new SolidBrush(Color.Black);

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            if (comboBoxBarva.Text != "")
            {
                zeton[pocetZetonu].poziceX = Convert.ToInt32(numericUpDownSourX.Value);
                zeton[pocetZetonu].poziceY = Convert.ToInt32(numericUpDownSourY.Value);
                zeton[pocetZetonu].barva = comboBoxBarva.Text;
                
                switch (zeton[pocetZetonu].barva)
                {
                    case "Černá":
                        point = new SolidBrush(Color.Black);
                        break;

                    case "Bílá":
                        point = new SolidBrush(Color.White);
                        break;
                }

                sourX = zeton[pocetZetonu].poziceX * 50 - rozmer / 2;
                sourY = zeton[pocetZetonu].poziceY * 50 - rozmer / 2;

                hraciPole.FillEllipse(point, sourX, sourY, rozmer, rozmer);

                pocetZetonu++;

                if (pocetZetonu == 6)
                {
                    buttonZadat.Enabled = false;
                    numericUpDownSourX.Enabled = false;
                    numericUpDownSourY.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Zadej barvu!");
            }
        }

        private void buttonPozice_Click(object sender, EventArgs e)
        {
            listBoxZetony.Items.Clear();
            for (int i = 0; i < pocetZetonu; i++)
            {
                if (zeton[i].barva == "Černá")
                {
                    listBoxZetony.Items.Add("Souřadnice X: " + zeton[i].poziceX + ", Souřadnice Y:" + zeton[i].poziceY);
                }
            }
        }

        private void panelHraciPole_Paint(object sender, PaintEventArgs e)
        {
            hraciPole = panelHraciPole.CreateGraphics();
        }
    }
}