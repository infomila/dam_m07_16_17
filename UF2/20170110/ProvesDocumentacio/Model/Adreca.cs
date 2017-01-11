using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvesDocumentacio.Model
{
    public class Adreca
    {
        public Adreca( string pTipusVia, string pVia, string pNumero, string pPis_porta, string pAltres)
        {
            TipusVia = pTipusVia;
            Via = pVia;
            Numero = pNumero;
            Pis_porta = pPis_porta;
            Altres = pAltres;
     
        }

        public string TipusVia { get; set; }

        public string Via { get; set; }

        public string Numero { get; set; }

        public string  Pis_porta { get; set; }

        public string Altres { get; set; }
    }
}
