using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace EmployeeCardCustomControl
{
    public class Empleat : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;



        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        public Empleat() { }

        public Empleat(string pNom, string pDesc, ImageSource pFoto)
        {
            
            this.Nom = pNom;
            this.Desc = pDesc;
            this.Foto = pFoto;

        }
        #region Propietats de la classe

        private string mNom;

        public string Nom
        {
            get { return mNom; }
            set { mNom = value;
                NotifyPropertyChanged();
            }
        }
        //-------------------------------------------------------
        private string mDesc;

        public string Desc
        {
            get { return mDesc; }
            set { mDesc = value;
                NotifyPropertyChanged();
            }
        }
        //-------------------------------------------------------
        private ImageSource mFoto;



        public ImageSource Foto
        {
            get { return mFoto; }
            set { mFoto = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

    }
}
