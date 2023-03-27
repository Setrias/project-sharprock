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

        private Graphics _hraciPole;

        struct ZetonyPar // deklarace datového typu
        {
            public int PoziceX;
            public int PoziceY;
            public string Barva;
        }

        private ZetonyPar[] _zetony = new ZetonyPar[6]; // inicializace datového typu

        private int _rozmer = 10, _pocetZetonu, _sourX, _sourY;
        private bool _konec;

        private Brush _point = new SolidBrush(Color.Black); // deklarace 'štětce'

        private void buttonZadat_Click(object sender, EventArgs e)
        {
            if (comboBoxBarva.Text != "") // když není v comboBoxu nic vybrané, zobrazí se MessageBox "Zadej barvu"
            {
                if (_pocetZetonu == 0) // uložení první hodnoty
                {
                    UlozeniParametru();
                }
                else
                {
                    if (!TestObsazeni()) // když se nenašel stejný bod mezi uloženými >> uloží se zadaná hodnota
                    {
                        UlozeniParametru();
                    }
                    else
                    {
                        MessageBox.Show("Tento bod už je obsazený.");
                    }
                }

                if (_pocetZetonu == 6) // poslední žeton zadán
                {
                    _konec = true;
                    buttonZadat.Enabled = false;
                    numericUpDownSourX.Enabled = false;
                    numericUpDownSourY.Enabled = false;
                    panelHraciPole.Refresh(); // znovuvykreslení po dokončení ukládání žetonů
                }
            }
            else
            {
                MessageBox.Show("Zadej barvu!");
            }
        }

        private void UlozeniParametru() // metoda pro uložení hodnot (kvůli duplicitě)
        {
            _zetony[_pocetZetonu].PoziceX = Convert.ToInt32(numericUpDownSourX.Value);
            _zetony[_pocetZetonu].PoziceY = Convert.ToInt32(numericUpDownSourY.Value);
            _zetony[_pocetZetonu].Barva = comboBoxBarva.Text;

            _pocetZetonu++;
        }

        private bool TestObsazeni() // funkce testující souřadnice žetonů, vrací Bool hodnotu
        {
            bool found = false;
            for (int i = 0; i < _pocetZetonu; i++)
            {
                if (numericUpDownSourX.Value == _zetony[i].PoziceX && numericUpDownSourY.Value == _zetony[i].PoziceY)
                {
                    found = true; // když se našel stejný bod
                }
            }

            return found;
        }

        private void buttonPozice_Click(object sender, EventArgs e)
        {
            listBoxZetony.Items.Clear(); // vymazání listBoxu
            for (int i = 0; i < _pocetZetonu; i++)
            {
                if (_zetony[i].Barva == "Černá") // vypsání souřadnic černých bodů do listBoxu
                {
                    listBoxZetony.Items.Add("Souřadnice X: " + _zetony[i].PoziceX + ", Souřadnice Y:" + _zetony[i].PoziceY);
                }
            }
        }

        private void panelHraciPole_Paint(object sender, PaintEventArgs e)
        {
            _hraciPole = panelHraciPole.CreateGraphics();

            if (_konec) // po zadání poslední hodnoty se žetony vykreslí do panelu
            {
                for (int i = 0; i < _pocetZetonu; i++)
                {
                    _sourX = _zetony[i].PoziceX * 50 - _rozmer / 2;
                    _sourY = _zetony[i].PoziceY * 50 - _rozmer / 2;
                    _hraciPole.FillEllipse(BarvaBodu(i), _sourX, _sourY, _rozmer, _rozmer);
                }
            }
        }

        private Brush BarvaBodu(int i) // funkce pro automatickou volbu barvy podle uložené hodnoty
        {
            if (_zetony[i].Barva == "Černá")
            {
                _point = new SolidBrush(Color.Black);
            }
            else
            {
                _point = new SolidBrush(Color.White);
            }

            return _point;
        }
    }
}