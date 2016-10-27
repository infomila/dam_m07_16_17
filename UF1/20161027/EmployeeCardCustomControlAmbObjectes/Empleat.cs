using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace EmployeeCardCustomControl
{
    public class Empleat
    {
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
            set { mNom = value; }
        }
        //-------------------------------------------------------
        private string mDesc;

        public string Desc
        {
            get { return mDesc; }
            set { mDesc = value; }
        }
        //-------------------------------------------------------
        private ImageSource mFoto;

        public ImageSource Foto
        {
            get { return mFoto; }
            set { mFoto = value; }
        }

        #endregion

    }
}
