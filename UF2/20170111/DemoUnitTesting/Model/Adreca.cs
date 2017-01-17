using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTesting.Model
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


        public override Boolean Equals(object o)
        {
            if (o == this) return true;

            if (o == null) return false;
            if( o.GetType() !=this.GetType()) return false;
            Adreca a = (Adreca)o;
            return (
                a.TipusVia.Equals(this.TipusVia) &&
                a.Via.Equals(this.Via) &&
                a.Numero.Equals(this.Numero) &&
                a.Pis_porta.Equals(this.Pis_porta) &&
                a.Altres.Equals(this.Altres)
                );
        }


        public string TipusVia { get; set; }

        public string Via { get; set; }

        public string Numero { get; set; }

        public string  Pis_porta { get; set; }

        public string Altres { get; set; }
    }
}
