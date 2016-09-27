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

namespace Posicionament
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
           // e.
        }

        private void txbNIF_KeyDown(
            object sender, 
            KeyRoutedEventArgs e)
        {
            string nomTecla = e.Key.ToString();

            //if ( e.Key != Windows.System.VirtualKey..Number0 )
            if(!nomTecla.StartsWith("Number"))
            {
                e.Handled = true;
            }
            
        }

        private void txbNIF_Paste(object sender, TextControlPasteEventArgs e)
        {
            e.Handled = true;
        }
    }
}
