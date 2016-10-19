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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace ListBoxes
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PoblacioDetallPage : Page
    {
        public PoblacioDetallPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Aquest mètode s'executa quan naveguem vers aquesta pàgina.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            /// Important ! Recuperem el paràmetre que ens passen
            /// Estic assumint que rebo una província ( o un valor null ! )
            Provincia p = (Provincia)e.Parameter;

            if (p == null)
            {

                txkNone.Visibility = Visibility.Visible;
                txkProv.Visibility =  txbNom.Visibility = Visibility.Collapsed;
            }
            else
            {
                txkNone.Visibility = Visibility.Collapsed;
                txkProv.Visibility = txbNom.Visibility = Visibility.Visible;
                txbNom.Text = p.Nom;
            }
        }



    }
}
