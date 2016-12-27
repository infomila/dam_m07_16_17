using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TreeView
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


            List<Categoria> cats = Categoria.getCategories();
            Node arrel = ConversorArbre.ConvertirArbre(cats);
            Debug.WriteLine(arrel.ToString());
            arbre.Arrel = arrel;

            arbre.SelectedItem = arrel.Fills[1];
            arbre.SelectionChanged += Arbre_SelectionChanged;

            //Loaded += MainPage_Loaded;

        }

        private void Arbre_SelectionChanged(object sender, EventArgs e)
        {
            txtNodeSeleccionat.Text = arbre.SelectedItem.Valor;
        }

        async private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
           // txtDownload.Text = await Downloader.httpGET("http://www.google.com");
        }
    }
}
