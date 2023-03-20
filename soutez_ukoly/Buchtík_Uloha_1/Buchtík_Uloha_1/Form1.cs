using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchtík_Uloha_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sourX = 25, sourY = 80;

        private void buttonGenerace_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                // deklarace listBoxu
                ListBox listBoxBase = new ListBox();

                // zkopírování z Form1.Designer.cs kvůli fontu
                listBoxBase.Font = new Font("Bahnschrift SemiCondensed", 12F,
                    FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                // poloha listBoxu v okně
                listBoxBase.Location = new Point(sourX, sourY);
                sourX += 230;

                // nastavuje polohu listBoxu, v řadě po čtyřech
                if (sourX > 900)
                {
                    sourX = 25;
                    sourY += 420;
                }

                // velikost listBoxu
                listBoxBase.Size = new Size(200, 400);

                Controls.Add(listBoxBase);

                // vypisuje jednotlivé příklady
                for (int j = 1; j < 21; j++)
                {
                    listBoxBase.Items.Add(i + " × " + j + " = " + i * j);
                }
            }
        }
    }
}