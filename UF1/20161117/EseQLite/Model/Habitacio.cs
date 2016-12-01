

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Model
{
    class Habitacio
    {

        /*
 
	    hab_htl_codi decimal(10),
	    hab_numero decimal(10),
	    hab_cli_NIF char(9),
	    hab_data_entrada date,
	    hab_max_persones decimal(1),
	    hab_planta decimal(2),

         */

        public Habitacio(Int64 pCodi, Int64 pNum, string pNIF, string pNomClient, DateTime? pDataEntrada, int pCapacitat, int pPlanta)
        {
            Codi = pCodi;
            Num = pNum;
            NIF = pNIF;
            DataEntrada = pDataEntrada;
            Capacitat = pCapacitat;
            Planta = pPlanta;
            NomClient = pNomClient;

        }

        #region "Propietats"
        private Int64 mCodi;

        public Int64 Codi
        {
            get { return mCodi; }
            set
            {
                if (value < 0) throw new Exception("Codi erroni");
                mCodi = value;
            }
        }

        private Int64 mNum;

        public Int64 Num
        {
            get { return mNum; }
            set { mNum = value; }
        }

        private string  mNIF;

        public string  NIF
        {
            get { return mNIF; }
            set { mNIF = value; }
        }

        private string mNomClient;

        public string NomClient
        {
            get { return mNomClient; }
            set { mNomClient = value; }
        }


        private DateTime? mDataEntrada;

        public DateTime? DataEntrada
        {
            get { return mDataEntrada; }
            set { mDataEntrada = value; }
        }

        private int mCapacitat;

        public int Capacitat
        {
            get { return mCapacitat; }
            set { mCapacitat = value; }
        }

        private int mPlanta;

        public int Planta
        {
            get { return mPlanta; }
            set { mPlanta = value; }
        }
#endregion

    
        public static bool valida(string value, out string missatgeError,
                                    [CallerMemberName] string parameterName = null)
        {

            bool ok = false;
            missatgeError = "";
            
            if (parameterName.Equals("Codi") || parameterName.Equals("Capacitat")|| parameterName.Equals("Planta"))
            {
                int lCodi;
                ok = !(value == null || value.Length ==0 || !Int32.TryParse(value, out lCodi) || lCodi<0);
                if (!ok)
                {
                    string article = "La";
                    if (parameterName.Equals("Codi"))
                    {
                        article = "El";
                    }
                    
                    missatgeError = $"{article} {parameterName} ha de ser un número positiu";
                }
            }
            else if (parameterName.Equals("NIF"))
            {

                // The excess characters are deleted.
                string nif = value.Trim();

                // Check NIE length.
                ok =  System.Text.RegularExpressions.Regex.IsMatch(nif, @"\d{7}[TRWAGMYFPDXBNJZSQVHLCKET]$");
                if(!ok)
                {
                    missatgeError = $"NIF erroni.";
                    return false;
                }                    
            }
            else if (parameterName.Equals("DataEntrada"))
            {
                DateTime lDataEntrada;
                ok = DateTime.TryParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture,    DateTimeStyles.None, out lDataEntrada);
                if (!ok)
                {
                    missatgeError = "Data no vàlida";
                }
            }
            return ok;
        }


    }
}
