using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxes
{
    class Provincia
    {
        public Provincia(int pCodi, string pNom, int pPoblacio, int pSuperficie, string pDesc)
        {
            Codi = pCodi;
            Nom = pNom;
            Superficie = pSuperficie;
            Poblacio = pPoblacio;
            Desc = pDesc;

        }

        //----------------------------

        private int mCodi;
   
        public int Codi
        {
            get { return mCodi; }
            set {
                if (value < 0)
                    throw new Exception("PUFFFFF");
                mCodi = value; }
        }

        private string mNom;

        public string Nom
        {
            get { return mNom; }
            set { mNom = value; }
        }


        private int mPoblacio;

        public int Poblacio
        {
            get { return mPoblacio; }
            set { mPoblacio = value; }
        }

        private int mSuperficie;

        public int Superficie
        {
            get { return mSuperficie; }
            set { mSuperficie = value; }
        }

        private string mDesc;

        public string Desc
        {
            get { return mDesc; }
            set { mDesc = value; }
        }



    }
}
