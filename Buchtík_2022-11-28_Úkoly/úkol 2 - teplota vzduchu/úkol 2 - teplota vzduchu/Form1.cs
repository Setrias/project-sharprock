using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace úkol_2___teplota_vzduchu
{
    public partial class Form1 : Form
    {
        private double hodTep;  // proměnná "hodnota teploty"
        private double[] pole = new double[7];  // pole "pole" o velikosti 7 položek
        private int pocetCisel;     // proměnná do které se ukládá počet zadaných čísel

        private double soucet = 0;  // součet pro počítání průměru (defaultně je "0" není nutno definovat
        private double min;     // proměnná na minimální číslo
        private double max;     // proměnná na max číslo

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pocetCisel = 0;     // vynulování počtu čísel při načtení programu
        }

        private void buttonZapis_Click(object sender, EventArgs e)
        {
            try     // try-catch které jistí zadání pouze čísla
            {
                hodTep = Convert.ToDouble(textBoxCislo.Text);   // převod hodnoty z textBoxCislo na "double" číslo

                if (pocetCisel <= 7)    // dokud bude počet zadaných čísel menší nebo rovno sedmi tak se bude provádět:--
                {
                    listBoxPole.Items.Add(hodTep);  // přidání zadané hodnoty do listBoxu
                    pole[pocetCisel] = hodTep;  // vložení zadané hodnoty do pole
                    soucet += hodTep;   // soucet = soucet + hodTep (hodnota teploty) || " += " znamená.. to do čeho se má příklad provést + ta hodnota co se s tím má sečíst

                    if (pocetCisel == 0)    // začátek, pocetCisel se rovná "0", zadaná hodnota se uloží do "max" i "min"
                    {
                        min = hodTep;
                        max = hodTep;
                    }
                    else    // po začátku kdy se pocetCisel rovná něčemu jinému než nule (+1) tak:..
                    {
                        if (hodTep < min)   // když je nová zadaná hodnota menší než aktuální minimální, nová hodnota se uloží do "min", jinak nic
                        {
                            min = hodTep;
                        }

                        if (hodTep > max)   // když je nová zadaná hodnota větší než aktuální maximální, nová hodnota se uloží do "max", jinak nic
                        {
                            max = hodTep;
                        }
                    }

                    pocetCisel++;   //pocetCisel se zvětší o 1 --- zadává se další hodnota
                }

                if (pocetCisel == 7)    // když se pocetCisel == 7 (poslední hodnota) tak:..
                {
                    textBoxCislo.ReadOnly = true;   // textBoxCislo bude "ReadOnly"
                    buttonZapis.Enabled = false;    // tlačítko zápis přestane fungovat

                    MessageBox.Show("Všechna čísla zadána");    // objeví se okýnko "Všechna čísla zadána

                    labelPrumer.Text = Convert.ToString(soucet / 7);    // vypočítá se průměr a vypíše se do labelu
                    labelNejmensi.Text = Convert.ToString(min);     // vypíše se minimální hodnota do labelu
                    labelNejvetsi.Text = Convert.ToString(max);     // vypíše se maximální hodnota do labelu
                }
            }
            catch   // try-catch když je zadáno něco jiného než číslo objeví se okýnko "Zadej číslo"
            {
                MessageBox.Show("Zadej číslo");
            }

            textBoxCislo.Focus();   // po kliknutí na tlačítko "Zápis" se automaticky vybere textBoxCislo
            textBoxCislo.SelectAll();   // a zároveň se vybere všechen text v textBoxCislo, tyto dva kroky jsou pro rychlejší zadávání
        }

        private void buttonReset_Click_1(object sender, EventArgs e)    // RESET tlačítko
        {
            listBoxPole.Items.Clear();  // listBox se vymaže
            pocetCisel = 0;     // počet čísel se nastaví na "0", vynuluje

            soucet = 0;     // součet se vynuluje
            labelPrumer.Text = " ";     // do labelů se vloží jen mezera (aby šlo vidět šedé pozadí a pozice labelu)
            labelNejmensi.Text = " ";
            labelNejvetsi.Text = " ";
            textBoxCislo.Clear();   // textBoxCislo se vymaže

            pole[pocetCisel] = 0;   // pole "pole" se nastaví na index 0... to znamená na začátek
            textBoxCislo.ReadOnly = false;      // textBoxCislo se nastaví aby do něj šlo zapisovat
            buttonZapis.Enabled = true;     // tlačítko půjde zmáčknout
        }
    }
}