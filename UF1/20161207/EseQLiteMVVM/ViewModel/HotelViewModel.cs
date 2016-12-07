using EseQLite.Db;
using EseQLite.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.ViewModel
{
    [ImplementPropertyChanged]
    public class HotelViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Hotel mHotel;


        /// <summary>
        /// Constructor per dades obtingudes a una font externa ( p.ex. base de dades )
        /// </summary>
        /// <param name="pHotel"></param>
        public HotelViewModel(Hotel pHotel)
        {
            mHotel = pHotel;
            LoadHotel();
            IsNew = false;
        }

        /// <summary>
        /// Constructor per instàncies noves
        /// </summary>
        public HotelViewModel()
        {
            Codi = -1;
            Nom = "";
            Poblacio = "";
            IsNew = true;
        }

        /// <summary>
        /// Torna als valors originals de la base de dades.
        /// </summary>
        public void Revert2OriginalData()
        {
            LoadHotel();
        }

        private void LoadHotel()
        {
            Codi = mHotel.Codi;
            Nom = mHotel.Nom;
            Poblacio = mHotel.Poblacio;
        }

        /// <summary>
        /// Ens indica si la instància d'hotel és nova o 
        /// s'ha carregat d'un registre de la base de dades.
        /// </summary>
        public bool IsNew { get; set; }

        //--------------------------------------------------------------------
        // Propietats lligades amb elements de la pàgina
        //--------------------------------------------------------------------
        // Textboxes d'entrada de dades
        public Int64 Codi { get; set; }
        public string Nom { get; set; }
        public string Poblacio { get; set; }

        // Textboxes d'Error
        //--------------------------------------------------------------------
        public string ErrorNomHotel { get; set; }
        public string ErrorPoblacioHotel { get; set; }
        public string ErrorGeneral { get; set; }



        public void validaGeneral()
        {
            if (Nom != null && Nom.Length>0 && Poblacio != null && Poblacio.Length>0)
            {
                bool ok = (HotelDB.getNumeroHotels(Codi, Nom, Poblacio) == 0);
                if (!ok)
                {
                    ErrorGeneral = "El nom i la població de l'hotel ja existeixen.";
                }
                else
                {
                    ErrorGeneral = "";
                }
            }
        }

 
        public void OnNomChanged()
        {
            valida("Nom");
        }
        public void OnPoblacioChanged()
        {
            valida("Poblacio");
        }

        public void valida( [CallerMemberName] string propertyName = null)
        {

            bool ok = false;

            if (propertyName.Equals("Nom"))
            {
                ok = !(Nom == null || Nom.Length < 2 || Nom.Length > 20);
                
                if (!ok)
                {
                    ErrorNomHotel = "El nom és obligatori i ha de tenir entre 2 i 20 caràcters.";
                } else
                {
                    ErrorNomHotel = "";
                }
            }
            else if (propertyName.Equals("Poblacio"))
            {
                ok = !(Poblacio == null || Poblacio.Length < 2 || Poblacio.Length > 100);
                if (!ok)
                {
                    ErrorPoblacioHotel = "La població és obligatoria i ha de tenir entre 2 i 100 caràcters.";
                } else
                {
                    ErrorPoblacioHotel = "";
                }
            }

            if (ok && propertyName.Equals("Nom")|| propertyName.Equals("Poblacio"))
            {
                validaGeneral();
            }

         }


        internal void save()
        {

            if (!IsNew)
            {
                HotelDB.updateData(Codi, Nom, Poblacio);
            }
            else
            {
                Codi = HotelDB.insertData(Nom, Poblacio);
            }
        }
    }
}
