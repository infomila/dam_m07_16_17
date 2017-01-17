using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTesting.Model
{
    public class Empleat : Persona
    {
        public Empleat(int pCodi, Decimal pSalari, string pNIF, string pNom, string pCognoms, DateTime pDataNaix) : base(pNIF, pNom, pCognoms, pDataNaix)
        {
            Codi = pCodi;
            Salari = pSalari;
        }

        public int Codi { get; set; }
        public Decimal Salari { get; set; }

        public Departament Dept { get; set; }
    }
}
