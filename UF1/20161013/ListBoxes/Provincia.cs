using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxes
{
    class Provincia : INotifyPropertyChanged
    {

        // Event per declarar que hi ha hagut canvis en les propietats
        // de la classe.
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

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
            set {
                mNom = value;
                this.OnPropertyChanged();
            }
        }


        private int mPoblacio;

        public int Poblacio
        {
            get { return mPoblacio; }
            set { mPoblacio = value; }
        }

        public int PoblacioDiv
        {
            get { return mPoblacio / 10000; }
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
        /// <summary>
        ///  Mètode per avisar a les classes de la UI que hi ha hagut
        ///  canvis en alguna propietat, i que per tant s'han d'actualitzar.
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
