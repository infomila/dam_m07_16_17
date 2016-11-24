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
        }

        private void lsvHotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lsv = (ListView)sender;
            Hotel h = (Hotel) lsv.SelectedItem;
            if (h != null)
            {
                txtCodi.Text = h.Codi.ToString();
                txtName.Text = h.Nom;
                txtPoblacio.Text = h.Poblacio;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Hotel hActualitzar = new Hotel(Int32.Parse(txtCodi.Text), txtName.Text, txtPoblacio.Text);

            HotelDB.updateData(Int32.Parse(txtCodi.Text), txtName.Text, txtPoblacio.Text);

            Hotel h = (Hotel)lsvHotels.SelectedItem;
            h.Nom = txtName.Text;
            h.Poblacio = txtPoblacio.Text;

            //lsvHotels.ItemsSource = null;
            lsvHotels.ItemsSource = HotelDB.getHotels();


        }
    }
}
