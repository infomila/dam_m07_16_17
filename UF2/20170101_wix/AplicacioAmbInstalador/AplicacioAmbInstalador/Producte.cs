using LibTarifes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacioAmbInstalador
{
    class Producte
    {
        static List<Producte> _productes;
        public static List<Producte> getProductes()
        {
            if(_productes==null)
            {
                _productes = new List<Producte>();
                _productes.Add(new Producte(1, "Col", 3.3m));
                _productes.Add(new Producte(2, "Patata",1.4m));
                _productes.Add(new Producte(3, "Pastanaga",3.4m));
                _productes.Add(new Producte(4, "Bròquil", 6.54m));
            }
            return _productes;
        }

        public Producte( int pCodi, string pNom, decimal pPreuBase)
        {
            Codi = pCodi;
            Nom = pNom;
            PreuBase = pPreuBase;
        }
        public int Codi { get; set; }
 
        public decimal PreuVenda
        {
            get { return  GestorTarifes.getTarifa(PreuBase); }
        }

        public string Nom { get; set; }
        public decimal PreuBase { get; set; }
    }
}
