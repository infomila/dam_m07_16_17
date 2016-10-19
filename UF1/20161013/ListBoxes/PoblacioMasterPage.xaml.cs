using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace ListBoxes
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PoblacioMasterPage : Page
    {
        public PoblacioMasterPage()
        {
            this.InitializeComponent();

            ObservableCollection<Provincia> provs = new ObservableCollection<Provincia>();       
            provs.Add(new Provincia(1, "Barcelona", 2250000, 300, "Futbol Club"));
            provs.Add(new Provincia(2, "Tarrragona", 500000, 200, "Tarragona m'esborrona"));
            provs.Add(new Provincia(3, "Girona", 250000, 300, "Eooooooo!"));
            provs.Add(new Provincia(4, "Lleida", 250000, 300, "From la terra ferma!"));

            listView.ItemsSource = provs;

            /// Naveguem a la pàgina de detall de població ( la que hi ha per defecte ) 
            frmPrincipal.Navigate(typeof (PoblacioDetallPage) );

            // Fem que es mostri el botó back a la barra de navegació
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            // Ens subscrivim a l'event "BackRequested", que es llança quan algú fa "Back"
            SystemNavigationManager.GetForCurrentView().BackRequested += PoblacioPage_BackRequested;
        }

        /// <summary>
        /// Gestionar quan l'usuari prem el botó "Back", ja sigui software o hardware.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PoblacioPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if(this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        /// <summary>
        /// Quan algú selecciona alguna cosa de la llista, mostre la pàgina, passant per paràmetre
        /// l'item seleccionat a la llista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            frmPrincipal.Navigate(typeof(PoblacioDetallPage), ((ListView)sender).SelectedItem);
        }
    }
}
