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

// La plantilla de elemento del cuadro de diálogo de contenido está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace DialegMania
{
    public sealed partial class SelectorProvincies : ContentDialog
    {
        public SelectorProvincies()
        {
            this.InitializeComponent();


            ObservableCollection<Provincia> provs = new ObservableCollection<Provincia>();
            //---------------------------------------------
            //               COMBOBOX AMB DATA BINDING
            // 1) Creació de dades
            provs.Add(new Provincia(1, "Barcelona", 2250000, 300, "Futbol Club"));
            provs.Add(new Provincia(2, "Tarrragona", 500000, 200, "Tarragona m'esborrona"));
            provs.Add(new Provincia(3, "Girona", 250000, 300, "Eooooooo!"));
            provs.Add(new Provincia(4, "Lleida", 250000, 300, "From la terra ferma!"));

            lsvProvincies.ItemsSource = provs;
            lsvProvincies.DisplayMemberPath = "Nom";            



        }



        public Provincia ProvinciaSeleccionada
        {
            get { return (Provincia)lsvProvincies.SelectedItem; }
   
        }


        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
