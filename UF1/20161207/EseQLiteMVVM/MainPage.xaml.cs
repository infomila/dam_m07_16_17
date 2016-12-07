using EseQLite.Db;
using EseQLite.Model;
using EseQLite.View;
using EseQLite.ViewModel;
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

namespace EseQLite
{
    /// <summary>
    /// Pàgina de gestió d'hotels
    /// </summary>
    public sealed partial class MainPage : Page
    {


        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        public MainPageViewModel ViewModel { get; set; }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

            MainPageViewModel mpvm = new MainPageViewModel();
            this.DataContext = mpvm;
            ViewModel = mpvm;
        }






        /*

        private void txbClientNIF_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateBotoEntrada();
        }

        private void updateBotoEntrada()
        {
            Client c = ClientDB.getClient(txbClientNIF.Text);
            if(c!=null)
            {
                txbClientName.Text = c.Nom;
            }
            bool potFerSortida = ( c!=null && dgvEntrades.SelectedItem!=null);
            btnEntrada.IsEnabled = true;// potFerSortida;
        }

        private void dgvEntrades_SelectionChanged(object sender, EventArgs e)
        {            
            updateBotoEntrada();
        }

        private void btnEntrada_Click(object sender, RoutedEventArgs e)
        {
            Habitacio h = ((Habitacio)dgvEntrades.SelectedItem);
            HabitacioDB.ocupaHabitacio(h.Codi, h.Num, txbClientNIF.Text, DateTime.Now);
            dgvEntrades.ItemSource = HabitacioDB.getHabitacions(h.Codi, true);
            dgvSortides.ItemSource = HabitacioDB.getHabitacions(h.Codi, false);
        }

        private void btnSortida_Click(object sender, RoutedEventArgs e)
        {
            Habitacio h = ((Habitacio)dgvSortides.SelectedItem);
            HabitacioDB.alliberaHabitacio(h.Codi, h.Num);
            dgvEntrades.ItemSource = HabitacioDB.getHabitacions(h.Codi, true);
            dgvSortides.ItemSource = HabitacioDB.getHabitacions(h.Codi, false);
        }*/
    }
   

}
