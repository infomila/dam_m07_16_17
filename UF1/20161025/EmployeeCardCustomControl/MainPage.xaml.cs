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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EmployeeCardCustomControl
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            /*
            <local:EmployeeCard HorizontalAlignment="Left"
                            VerticalAlignment="Top" 
                            Nom="Paco"
                            Desc="Oh my goodness !!"
                            Foto="Assets/putin.png"/>   

    */
            EmployeeCard ec = new EmployeeCard();
            ec.Nom = "Paco";
            ec.Desc = "Oh my goodness !!";
            ec.Foto = new BitmapImage( new Uri("ms-appx:///Assets/putin.png"));
            ec.HorizontalAlignment = HorizontalAlignment.Left;
            ec.Margin = new Thickness(20,-20,0,0);
            pnlEmployees.Children.Add(ec);

        }
    }
}
