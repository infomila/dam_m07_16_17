using EseQLite.Db;
using EseQLite.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EseQLite
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            HotelDB edb = new HotelDB();
            lsvHotels.ItemsSource = HotelDB.getHotels();
            Mode = ModeEnum.EDIT;
        }

        private void lsvHotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            ListView lsv = (ListView)sender;
            Hotel h = (Hotel)lsv.SelectedItem;
            if (h != null)
            {
                txtCodi.Text = h.Codi.ToString();
                txtName.Text = h.Nom;
                txtPoblacio.Text = h.Poblacio;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Hotel h = null;
            if (Mode == ModeEnum.MODIFIED)
            {
                HotelDB.updateData(Int32.Parse(txtCodi.Text), txtName.Text, txtPoblacio.Text);
                h = (Hotel)lsvHotels.SelectedItem;
                h.Nom = txtName.Text;
                h.Poblacio = txtPoblacio.Text;
            }
            else
            {
                HotelDB.insertData(txtName.Text, txtPoblacio.Text);

            }


            // Actualitza la llista.
            lsvHotels.ItemsSource = HotelDB.getHotels();

            if (Mode == ModeEnum.NEW)
            {
                // Selecciona l'últim de la llista ( l'acabem d'inserir )
                Hotel ultimHotel = ((List<Hotel>)lsvHotels.ItemsSource).Last<Hotel>();
                lsvHotels.SelectedItem = ultimHotel;
                
            }
            else
            {
                // Busquem l'hotel que té el codi !!
                Hotel hotelSeleccionat = ((List<Hotel>)lsvHotels.ItemsSource).Find(ht => (ht.Codi == h.Codi));
                lsvHotels.SelectedItem = hotelSeleccionat;
            }
            Mode = ModeEnum.EDIT;
        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            HotelDB.deleteData(((Hotel)lsvHotels.SelectedItem).Codi);

            lsvHotels.ItemsSource = HotelDB.getHotels();
        }

        enum ModeEnum
        {
            EDIT, MODIFIED, NEW
        }

        ModeEnum mMode;
        ModeEnum Mode
        {
            get
            {
                return mMode;
            }
            set
            {
                mMode = value;
                btnSave.IsEnabled = btnCancel.IsEnabled = (Mode== ModeEnum.NEW || Mode== ModeEnum.MODIFIED);
                btnNew.IsEnabled = btnDelete.IsEnabled = (Mode == ModeEnum.EDIT  );
                 
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Mode = ModeEnum.NEW;
            txtCodi.Text = "<new>";
            txtName.Text = "";
            txtPoblacio.Text = "";
        }

        private void common_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Mode == ModeEnum.EDIT)
            {
                Mode = ModeEnum.MODIFIED;
            }
        }


    }
}
