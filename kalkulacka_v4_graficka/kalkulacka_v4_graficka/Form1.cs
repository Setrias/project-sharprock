using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private Panel uiClassic;

        // private Panel uiConvert;
        private bool resultClick;

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateClassic();
            TopMost = false;
        }

        private void klasickáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klasickáToolStripMenuItem.Checked = true;
            převodToolStripMenuItem.Checked = false;

            uiClassic.Visible = true;
            // velikost okna kalkulačky
            Size = new Size(260, 400);
        }

        private void převodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            převodToolStripMenuItem.Checked = true;
            klasickáToolStripMenuItem.Checked = false;

            uiClassic.Visible = false;
            // velikost okna kalkulačky
            Size = new Size(500, 400);
        }

        private void CreateClassic()
        {
            // vytvoření UI pro klasickou kalkulačku
            uiClassic = new Panel();
            uiClassic.Size = new Size(220, 350);
            uiClassic.Location = new Point(15, 25);
            Controls.Add(uiClassic);

            // vytvoření výsledkového textBoxu
            TextBox textBoxResults = new TextBox();
            textBoxResults.Size = new Size(215, 50);
            textBoxResults.Location = new Point(0, 0);
            textBoxResults.Font = new Font("Bahnschrift SemiCondensed", 27.75F, FontStyle.Regular);
            textBoxResults.TextAlign = HorizontalAlignment.Right;
            textBoxResults.ReadOnly = true;
            textBoxResults.TabStop = false;
            uiClassic.Controls.Add(textBoxResults);

            // vytvoření numPadu

            // vytvoření nuly
            Button numPadItem = new Button();
            numPadItem.Text = "0";
            numPadItem.Font = new Font("Bahnschrift SemiCondensed", 16, FontStyle.Regular);
            numPadItem.Size = new Size(50, 50);
            numPadItem.Click += new EventHandler(calcButton_Click);
            numPadItem.Location = new Point(55, 275);
            uiClassic.Controls.Add(numPadItem);

            numPadItem = new Button();
            numPadItem.Text = "00";
            numPadItem.Font = new Font("Bahnschrift SemiCondensed", 16, FontStyle.Regular);
            numPadItem.Size = new Size(50, 50);
            numPadItem.Click += new EventHandler(calcButton_Click);
            numPadItem.Location = new Point(110, 275);
            uiClassic.Controls.Add(numPadItem);

            //vytvoření 1 až 9
            int sourX = 0, sourY = 275, horizont = 0;
            for (int i = 0; i < 9; i++)
            {
                numPadItem = new Button();
                numPadItem.Text = (i + 1).ToString();
                numPadItem.Font = new Font("Bahnschrift SemiCondensed", 16, FontStyle.Regular);
                numPadItem.Size = new Size(50, 50);
                numPadItem.Click += new EventHandler(calcButton_Click);
                if (i % 3 == 0)
                {
                    horizont = 0;
                    sourX = 0;
                    sourY -= 55;
                }

                numPadItem.Location = new Point(sourX + (55 * horizont++), sourY);
                uiClassic.Controls.Add(numPadItem);
            }

            // vytvoření mazání
            numPadItem = new Button();
            numPadItem.Text = "<R";
            numPadItem.Font = new Font("Bahnschrift SemiCondensed", 16, FontStyle.Regular);
            numPadItem.Size = new Size(50, 50);
            numPadItem.Location = new Point(165, 55);
            numPadItem.Click += new EventHandler(removeLast_Click);
            uiClassic.Controls.Add(numPadItem);

            numPadItem = new Button();
            numPadItem.Text = "CL";
            numPadItem.Font = new Font("Bahnschrift SemiCondensed", 16, FontStyle.Regular);
            numPadItem.Size = new Size(50, 50);
            numPadItem.Location = new Point(0, 55);
            numPadItem.Click += new EventHandler(clearTextBox_Click);
            uiClassic.Controls.Add(numPadItem);

            // vytvoření operandů
            // =
            Button operand = new Button();
            operand.Text = "=";
            operand.Font = new Font("Bahnschrift SemiCondensed", 25, FontStyle.Regular);
            operand.Size = new Size(50, 50);
            operand.Location = new Point(0, 275);
            operand.Click += new EventHandler(getResult_Click);
            uiClassic.Controls.Add(operand);

            // +
            operand = new Button();
            operand.Text = "+";
            operand.Font = new Font("Bahnschrift SemiCondensed", 25, FontStyle.Regular);
            operand.Size = new Size(50, 50);
            operand.Location = new Point(165, 110);
            operand.Click += new EventHandler(calcButton_Click);
            uiClassic.Controls.Add(operand);

            // -
            operand = new Button();
            operand.Text = "-";
            operand.Font = new Font("Bahnschrift SemiCondensed", 25, FontStyle.Regular);
            operand.Size = new Size(50, 50);
            operand.Location = new Point(165, 165);
            operand.Click += new EventHandler(calcButton_Click);
            uiClassic.Controls.Add(operand);

            // *
            operand = new Button();
            operand.Text = "*";
            operand.Font = new Font("Bahnschrift SemiCondensed", 25, FontStyle.Regular);
            operand.Size = new Size(50, 50);
            operand.Location = new Point(165, 220);
            operand.Click += new EventHandler(calcButton_Click);
            uiClassic.Controls.Add(operand);

            // /
            operand = new Button();
            operand.Text = "/";
            operand.Font = new Font("Bahnschrift SemiCondensed", 25, FontStyle.Regular);
            operand.Size = new Size(50, 50);
            operand.Location = new Point(165, 275);
            operand.Click += new EventHandler(calcButton_Click);
            uiClassic.Controls.Add(operand);
        }

        private void getResult_Click(object sender, EventArgs e)
        {
            TextBox textBoxResults = uiClassic.Controls.OfType<TextBox>().FirstOrDefault();
            var tokens = new List<Object>();

            if (textBoxResults != null)
            {
                string priklad = textBoxResults.Text;
                Console.WriteLine(priklad);

                if (priklad.EndsWith("+") || priklad.EndsWith("-") || priklad.EndsWith("*") || priklad.EndsWith("/"))
                {
                    priklad = priklad.Substring(0, priklad.Length - 1);
                }

                string part = "";
                foreach (var t in priklad.ToCharArray())
                {
                    if (Char.IsDigit(t))
                    {
                        part += t;
                    }
                    else
                    {
                        tokens.Add(Convert.ToInt64(part));
                        tokens.Add(t);
                        part = "";
                    }
                }

                if (part != "")
                {
                    tokens.Add(Convert.ToInt64(part));
                }

                long result = Convert.ToInt64(tokens[0]);
                for (int i = 0; i < tokens.Count; i++)
                {
                    var num = tokens[i];
                    if (Convert.ToString(num) == "+")
                    {
                        result += Convert.ToInt64(tokens[i + 1]);
                    }
                    else if (Convert.ToString(num) == "-")
                    {
                        result -= Convert.ToInt64(tokens[i + 1]);
                    }
                    else if (Convert.ToString(num) == "*")
                    {
                        result *= Convert.ToInt64(tokens[i + 1]);
                    }
                    else if (Convert.ToString(num) == "/")
                    {
                        result /= Convert.ToInt64(tokens[i + 1]);
                    }
                }

                textBoxResults.Text = Convert.ToString(result);
                resultClick = true;
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            TextBox textBoxResults = uiClassic.Controls.OfType<TextBox>().FirstOrDefault();

            if (textBoxResults != null)
            {
                if (textBoxResults.Text.Length < 12)
                {
                    if (button != null)
                    {
                        if (resultClick && (button.Text == "+" || button.Text == "-" || button.Text == "*" || button.Text == "/"))
                        {
                            resultClick = false;
                        }
                        else if (resultClick)
                        {
                            resultClick = false;
                            textBoxResults.Text = "";
                        }

                        button.Focus();
                        textBoxResults.Text += button.Text;
                    }
                }
            }
        }

        private void removeLast_Click(object sender, EventArgs e)
        {
            TextBox textBoxResults = uiClassic.Controls.OfType<TextBox>().FirstOrDefault();
            if (textBoxResults != null)
            {
                string resultsText = textBoxResults.Text;

                if (resultsText != "")
                {
                    textBoxResults.Text = resultsText.Substring(0, resultsText.Length - 1);
                }
            }
        }

        private void clearTextBox_Click(object sender, EventArgs e)
        {
            TextBox textBoxResults = uiClassic.Controls.OfType<TextBox>().FirstOrDefault();
            if (textBoxResults != null)
            {
                textBoxResults.Text = "";
            }
        }

        private void AlwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AlwaysOnTopToolStripMenuItem.Checked)
            {
                AlwaysOnTopToolStripMenuItem.Checked = false;
                TopMost = false;
            }
            else
            {
                AlwaysOnTopToolStripMenuItem.Checked = true;
                TopMost = true;
            }
        }
    }
}