using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Model
{
    class Hotel
    {

        /*
	        htl_codi decimal(10) constraint PK_HOTEL  primary key,
	        htl_nom varchar(20),
	        htl_poblacio varchar(100)
         */

        public  Hotel(Int64 pCodi, string pNom, string pPoblacio)
        {
            Codi = pCodi;
            //mCodi = pCodi; // KK !!!! MORT !!!! DANGER!
            Nom = pNom;
            Poblacio = pPoblacio;
        }


        private Int64 mCodi;

        public Int64 Codi
        {
            get { return mCodi; }
            set
            {
                if (value < 0) throw new Exception("Codi erroni");
                mCodi = value; }
        }


        private string mNom;

        public string Nom
        {
            get { return mNom; }
            set {
                if (value==null || value.Length<2 || value.Length > 20) throw new Exception("Nom erroni");
                mNom = value; }
        }


        private string mPoblacio;

        public string Poblacio
        {
            get { return mPoblacio; }
            set {
                if (value == null || value.Length < 2 || value.Length > 100) throw new Exception("Població erronia");
                mPoblacio = value; }
        }


        public override string ToString()
        {
            return "HOTEL: "+Codi + "-" + Nom + "-" + Poblacio + "\n";
        }

    }
}
