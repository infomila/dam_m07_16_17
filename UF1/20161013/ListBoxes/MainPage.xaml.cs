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
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ListBoxes
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ObservableCollection<Provincia> provs = new ObservableCollection<Provincia>();       
            provs.Add(new Provincia(1, "Barcelona", 2250000, 300, "Futbol Club"));
            provs.Add(new Provincia(2, "Tarrragona", 500000, 200, "Tarragona m'esborrona"));
            provs.Add(new Provincia(3, "Girona", 250000, 300, "Eooooooo!"));
            provs.Add(new Provincia(4, "Lleida", 250000, 300, "From la terra ferma!"));

            listView.ItemsSource = provs;
            //

            //listView.DisplayMemberPath = "Nom";



        }
    }
}
