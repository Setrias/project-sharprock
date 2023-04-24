using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_username
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string jmeno, prijmeni;
        
        string jmenoShort;
        string prijmeniShort;
        
        private void buttonVytvorit_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            jmeno = textBoxJmeno.Text;
            prijmeni = textBoxPrijmeni.Text;

            // dvouciferný rok
            int rok = DateTime.Today.Year % 100;
            string rokDve = rok.ToString("D2");
            
            // měsíc
            int mesic = DateTime.Today.Month;

            for (int i = 0; i < 3; i++)
            {
                prijmeniShort += prijmeni[i];
            }
            
            for (int i = 0; i < 2; i++)
            {
                jmenoShort += jmeno[i];
            }
            
            textBoxUsername.Text = rokDve + mesic.ToString("D2") + prijmeniShort + jmenoShort;
        }
    }
}