using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            employeeCard.Emp = new Empleat("Paco", "Super Paco Strikes Back",
                new BitmapImage(new Uri("ms-appx:///Assets/putin.png")));


            ObservableCollection<Empleat> empleats = new ObservableCollection<Empleat>();
            empleats.Add(new Empleat("Paco", "Super Paco Strikes Back", new BitmapImage(new Uri("ms-appx:///Assets/putin.png"))));
            empleats.Add(new Empleat("Paco1", "1Super Paco Strikes Back", new BitmapImage(new Uri("ms-appx:///Assets/cubix.jpg"))));
            empleats.Add(new Empleat("Paco2", "2Super Paco Strikes Back", new BitmapImage(new Uri("ms-appx:///Assets/face.jpg"))));
            empleats.Add(new Empleat("Paco3", "3Super Paco Strikes Back", new BitmapImage(new Uri("ms-appx:///Assets/obama.png"))));
            empleats.Add(new Empleat("Paco4", "4Super Paco Strikes Back", new BitmapImage(new Uri("ms-appx:///Assets/putin.png"))));
            empleats.Add(new Empleat("Paco5", "5Super Paco Strikes Back", new BitmapImage(new Uri("ms-appx:///Assets/cubix.jpg"))));

            int x = 0;
            foreach(Empleat e in empleats)
            {
                EmployeeCard ec = new EmployeeCard();
                ec.Emp = e;
                ec.HorizontalAlignment = HorizontalAlignment.Left;
               
                pnlEmployees.Children.Add(ec);
                ec.Margin = new Thickness(x,-70, 0, 0);
                x += 20;
            }
            empleats[0].Nom = "CANVIASSOO!!!!!!!!!!";

        }
    }
}
