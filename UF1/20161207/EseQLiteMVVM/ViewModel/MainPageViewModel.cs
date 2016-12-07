using EseQLite.Db;
using EseQLite.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace EseQLite.ViewModel
{
    /// <summary>
    /// IMPORTANT: Les classes de vista fan servir un Nuget anomenat "Fody" que ens facilita moltíssim 
    ///            la implementació de la interfície INotifyPropertyChanged
    ///            Podeu fer un cop d'ull a:           
    ///              - https://github.com/Fody/Fody/wiki/SampleUsage
    ///              - https://github.com/Fody/PropertyChanged
    ///              - https://github.com/Fody/PropertyChanged/wiki/On_PropertyName_Changed

    /// </summary>


    [ImplementPropertyChanged]
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            setMode(ModeEnum.EMPTY);
        }

        ObservableCollection<HotelViewModel> mHotels;
        public ObservableCollection<HotelViewModel> Hotels
        {
            get
            {
                if (mHotels == null)
                {
                    mHotels = new ObservableCollection<HotelViewModel>();

                    List<Hotel> hotelsModel = HotelDB.getHotels();
                    foreach (Hotel h in hotelsModel)
                    {
                        HotelViewModel hvm = new HotelViewModel(h);
                        mHotels.Add(hvm);
                    }
                }
                return mHotels;
            }
        }

        public HotelViewModel CurrentHotel { get;set; }

        /// <summary>
        /// La funció es llançarà quan es canvia d'hotel (no de continguts)
        /// </summary>
        public void OnCurrentHotelChanged()
        {
            if (CurrentHotel != null)
            {
                if (CurrentHotel.IsNew)
                {
                    setMode(ModeEnum.NEW);
                }else
                {
                    setMode(ModeEnum.VIEW);
                }
                // ens registrem per tal que ens avisi dels canvis interns de l'hotel.
                CurrentHotel.PropertyChanged += OnHotelInnerChanged;
            } else
            {
                setMode(ModeEnum.EMPTY);
            }
        }

        /// <summary>
        /// La funció es llançarà quan hi hagi canvis DINS de les dades de l'hotel !!!!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnHotelInnerChanged( object sender, PropertyChangedEventArgs e)
        {
            setMode(ModeEnum.MODIFIED);
        }
        
        #region Modes i gestió de la botonera

        public bool CanSave { get; set; }
        public bool CanNew { get; set; }
        public bool CanCancel { get; set; }
        public bool CanDelete { get; set; }

        public enum ModeEnum
        {
            VIEW, MODIFIED, NEW, EMPTY
        }

        ModeEnum mMode;
        public void setMode(ModeEnum value)
        {
            mMode = value;
            CanSave = CanCancel = (mMode == ModeEnum.NEW || mMode == ModeEnum.MODIFIED);
            CanDelete = (mMode == ModeEnum.VIEW);
            CanNew = (mMode == ModeEnum.VIEW) ||  (mMode == ModeEnum.EMPTY);
        }
        #endregion

        //------------------------------------ ACCIONS ---------------------------------------------------
        #region Accions

        public void btnNew_Click(object sender, RoutedEventArgs e)
        {
            setMode(ModeEnum.NEW);
            CurrentHotel = new HotelViewModel();
        }


        public void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (mMode == ModeEnum.NEW)
            {
                SeleccionaPrimerHotel();
            }
            else
            {
                // refresca les dades amb les originals.
                CurrentHotel.Revert2OriginalData();
                setMode(ModeEnum.VIEW);
            }


        }



        public void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            if(CurrentHotel!=null)
            {
                CurrentHotel.save();
            }
            if(CurrentHotel.IsNew)
            {
                Hotels.Add(CurrentHotel);
                CurrentHotel.IsNew = false;
            }
            setMode(ModeEnum.VIEW);
        }


        public void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            HotelDB.deleteData(CurrentHotel.Codi);

            Hotels.Remove(CurrentHotel);
            SeleccionaPrimerHotel();
        }

    #endregion
        //----------------------------------- ALTRES ----------------------------
        private void SeleccionaPrimerHotel()
        {
            if (Hotels.Count > 0)
            {
                CurrentHotel = Hotels.First<HotelViewModel>();
            }  
        }
    }
}
