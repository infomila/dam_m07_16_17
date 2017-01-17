using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTesting.Model
{
    public class Departament
    {
        public Departament(int pCodi , string pNom)
        {
            Codi = pCodi;
            Nom = pNom;
        }
        public int Codi { get; set; }

        public string Nom { get; set; }
    }
}
