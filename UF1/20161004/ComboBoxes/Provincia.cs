using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxes
{
    class Provincia
    {
        public Provincia(int pCodi, string pNom)
        {
            Codi = pCodi;
            Nom = pNom;
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



    }
}
