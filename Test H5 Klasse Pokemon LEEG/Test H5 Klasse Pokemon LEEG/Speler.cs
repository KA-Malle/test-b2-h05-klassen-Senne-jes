using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    internal class Speler
    {
        // Declaratie van de instanties variabelen
        private string Naam;

        private int PositieX = (1|500);
        private int PositieY = (1|500);
        private bool IsLevend;

        private decimal _gezondheid = 100;

        public decimal Gezondheid
        {
            get { return _gezondheid; }
            set { _gezondheid = value; }
        }
        // Default constructor
        public Speler()
        {
            Naam = "Naamloos";
            Gezondheid = 100;
            PositieX = 0;
            PositieY = 0;
            IsLevend = true;
        }
        public Speler(string nm, int vn, int py, int px)
        {
            Naam = nm;
            Gezondheid = vn;
            PositieY = py;
            PositieX = px;
        }
        // Methodes

        public string OntvangSchade()
        {            
            Gezondheid--;
            if (Gezondheid <= 0)
            {
                IsLevend = false;
                MessageBox.Show(Gezondheid.ToString(), "Je bent gestorven", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        // Methodes
        public string Genees()
        {
            Gezondheid++;
            if (Gezondheid > 100)
            {
                IsLevend = false;
                MessageBox.Show(Gezondheid.ToString(), "Je kunt niet boven 100 gaan, maxium health", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       public string Verplaats()
        {
            PositieX = 122;
            PositieY = 499;
        }
        public string Toongegevens()
        {

            return Gezondheid.ToString();
        }

    }
}
