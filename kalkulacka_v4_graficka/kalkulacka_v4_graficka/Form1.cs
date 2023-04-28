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

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateClassic();
        }

        private Panel uiClassic;

        private void klasickáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uiClassic.Visible = true;
        }

        private void převodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uiClassic.Visible = false;
        }

        private void CreateClassic()
        {
            // vytvoření UI pro klasickou kalkulačku
            uiClassic = new Panel();
            uiClassic.Size = new Size(220, 300);
            uiClassic.Location = new Point(15, 25);
            Controls.Add(uiClassic);

            // vytvoření výsledkového textBoxu
            TextBox results = new TextBox();
            results.Size = new Size(200, 50);
            results.Location = new Point(0, 0);
            results.Font = new Font("Bahnschrift SemiCondensed", 27.75F, FontStyle.Regular);
            results.TextAlign = HorizontalAlignment.Right;
            results.ReadOnly = true;
            uiClassic.Controls.Add(results);

            // vytvoření numPadu
            int sourX = 0, sourY = 230, horizont = 0;
            for (int i = 0; i < 9; i++)
            {
                Button numPadItem = new Button();
                numPadItem.Name = "num" + i + 1;
                numPadItem.Text = (i + 1).ToString();
                numPadItem.Font = new Font("Bahnschrift SemiCondensed", 16, FontStyle.Regular);
                numPadItem.Size = new Size(50, 50);
                if (i % 3 == 0)
                {
                    horizont = 0;
                    sourX = 0;
                    sourY -= 55;
                }

                numPadItem.Location = new Point(sourX + (55 * horizont++), sourY);
                uiClassic.Controls.Add(numPadItem);
            }
            
            // vytvoření operandů
            // =
            Button operand = new Button();
            operand.Name = "vypocet";
            operand.Text = "=";
            operand.Font = new Font("Bahnschrift SemiCondensed", 25, FontStyle.Regular);
            operand.Size = new Size(105, 50);
            operand.Location = new Point(0, 230);
            uiClassic.Controls.Add(operand);
        }
    }
}