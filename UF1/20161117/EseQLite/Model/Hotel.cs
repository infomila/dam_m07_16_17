using EseQLite.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                string errMsg;
                if(!valida( value, out errMsg)) throw new Exception(errMsg);
                mNom = value; }
        }

 

        private string mPoblacio;

        public string Poblacio
        {
            get { return mPoblacio; }
            set {
                string errMsg;
                if (!valida(value, out errMsg )) throw new Exception(errMsg);
                mPoblacio = value; }
        }




        public static bool validaGeneral(long? pCodiHotel, string pNom, string pPoblacio, out string missatgeError)
        {
            bool ok =( HotelDB.getNumeroHotels(pCodiHotel, pNom, pPoblacio)==0);
            if(!ok)
            {
                missatgeError = "El nom i la població de l'hotel ja existeixen.";
            } else
            {
                missatgeError = "";
            }
            return ok;
        }


        public static bool valida(string value, out string missatgeError,
                                    [CallerMemberName] string parameterName = null)
        {

            bool ok = false;
            missatgeError = "";
            if (parameterName.Equals("Nom"))
            {
                ok = !(value == null || value.Length < 2 || value.Length > 20);
                if (!ok)
                {
                    missatgeError = "El nom és obligatori i ha de tenir entre 2 i 20 caràcters.";
                }
            }
            else if (parameterName.Equals("Poblacio"))
            {
                ok = !(value == null || value.Length < 2 || value.Length > 100);
                if (!ok)
                {
                    missatgeError = "La població és obligatoria i ha de tenir entre 2 i 100 caràcters.";
                }
            }
            return ok;
        }


        public override string ToString()
        {
            return "HOTEL: "+Codi + "-" + Nom + "-" + Poblacio + "\n";
        }

    }
}
