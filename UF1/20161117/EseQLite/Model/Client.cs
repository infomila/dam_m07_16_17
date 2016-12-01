using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Model
{
    class Client
    {
        /*
	        cli_NIF char(9) constraint PK_client primary key ,
	        cli_nom varchar(100) not null,
	        cli_poblacio varchar(100)  not null,
	        cli_data_naix date  not null         
         */

        public Client ( string pNIF, string pNom, string pPoblacio, DateTime pDataNaix)
        {
            NIF = pNIF;
            Nom = pNom;
            Poblacio = pPoblacio;
            DataNaixement = pDataNaix;
        }

        public string NIF { get; set; }
        public string Nom { get; set; }
        public string Poblacio { get; set; }
        public DateTime DataNaixement { get; set; }
    }
}
