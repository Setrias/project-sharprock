using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace priprava_soutez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelFileName.Text = "";
        }

        // zobrazení obrázku

        private void buttonZobrazit_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "../../assets/challenger.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }


        // kreslení a výplň elipsy zvolenou barvou

        private Graphics _kresPanel;
        private Pen _pero = new Pen(Color.Crimson, 3);

        private void panelKresleni_Paint(object sender, PaintEventArgs e)
        {
            _kresPanel = panelKresleni.CreateGraphics();
            _kresPanel.DrawEllipse(_pero, 20, 20, 150, 100);
        }

        Brush _vypln; // = new SolidBrush(Color.DeepSkyBlue);

        private void buttonVyplnit_Click(object sender, EventArgs e)
        {
            colorDialogVyplnit.FullOpen = true;
            colorDialogVyplnit.ShowDialog();
            _vypln = new SolidBrush(colorDialogVyplnit.Color);
            _kresPanel.FillEllipse(_vypln, 20, 20, 150, 100);
        }

        // Přečtení souboru

        private OpenFileDialog _vyberSouboru = new OpenFileDialog();
        private string _nazevSouboru;

        private void buttonVyberObrazku_Click(object sender, EventArgs e)
        {
            _vyberSouboru.Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(Všechny soubory *.*)|*.*";

            if (_vyberSouboru.ShowDialog() == DialogResult.OK)
            {
                _nazevSouboru = _vyberSouboru.FileName;

                pictureBoxVyberObrazku.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxVyberObrazku.ImageLocation = _nazevSouboru;
            }
        }

        private void buttonVybratTxt_Click(object sender, EventArgs e)
        {
            _vyberSouboru.InitialDirectory = "C:\\Users\\tomas\\Desktop";
            _vyberSouboru.Filter = "(*.txt)|*.txt";

            if (_vyberSouboru.ShowDialog() == DialogResult.OK)
            {
                _nazevSouboru = _vyberSouboru.FileName;
                string fileOpen = Convert.ToString(File.ReadAllText(_nazevSouboru));

                labelFileName.Text = _nazevSouboru;

                string[] pole = fileOpen.Split(',');

                foreach (var item in pole)
                {
                    listBoxSlova.Items.Add(item.Trim());
                }
            }
        }

        private void buttonPridatSlovo_Click(object sender, EventArgs e)
        {
            _vyberSouboru.InitialDirectory = "C:\\Users\\tomas\\Desktop";
            _vyberSouboru.Filter = "(*.txt)|*.txt";

            if (_vyberSouboru.ShowDialog() == DialogResult.OK)
            {
                _nazevSouboru = _vyberSouboru.FileName;

                string text = textBoxSlova.Text;

                File.AppendAllText(_nazevSouboru, text);
            }
        }
    }
}