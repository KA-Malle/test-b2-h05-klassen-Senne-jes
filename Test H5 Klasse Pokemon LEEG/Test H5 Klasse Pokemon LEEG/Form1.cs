using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string speler1;
        string speler2;
        int will;

        // Instantie van ons object aanmaken
        Speler _gez = new Speler();
        private void Form1_Load(object sender, EventArgs e)
        {
            _gez.Gezondheid = 100;

        }


        private void buttonValAan1_Click(object sender, EventArgs e)
        {           
                _gez.Gezondheid += decimal.Parse(labelGezondheid2.Text);
                //textBox1.Text = _rek.Uitlezen();            
        }

        private void buttonValAan2_Click(object sender, EventArgs e)
        {
            _gez.Gezondheid += decimal.Parse(labelGezondheid1.Text);

        }

        private void buttonGenees1_Click(object sender, EventArgs e)
        {
            _gez.Gezondheid -= decimal.Parse(labelGezondheid2.Text);

        }

        private void buttonGenees2_Click(object sender, EventArgs e)
        {
            _gez.Gezondheid -= decimal.Parse(labelGezondheid1.Text);

        }

        private void buttonToonPos_Click(object sender, EventArgs e)
        {
            // Instantie aanmaken
            Positie pos = new Positie("Positie speler1:" + Positie + "Positie speler2:" + Positie);
            MessageBox.Show(pos.Naam, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Instanties aanmaken
        // Speler gebr = new Speler1();
        // Speler2 gebr = new Speler2();


    }
}
