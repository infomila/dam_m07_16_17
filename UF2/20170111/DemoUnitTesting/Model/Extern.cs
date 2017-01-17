using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTesting.Model
{
    public class Extern : Persona
    {
        public Extern(string pEmpresa, string pNIF, string pNom, string pCognoms, DateTime pDataNaix) : base(pNIF, pNom, pCognoms, pDataNaix)
        {
            Empresa = pEmpresa;
        }


        public string Empresa { get; set; }
    }
}
