using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTarifes
{
    public class GestorTarifes
    {
        public static Decimal getTarifa(Decimal pPreuBase)
        {
            Decimal descompte = 0;
            if ( DateTime.Now>new DateTime(DateTime.Now.Year,12, 24))
            {
                descompte = 20;
            }
            return pPreuBase * (1-descompte/100);
        }
    }
}
