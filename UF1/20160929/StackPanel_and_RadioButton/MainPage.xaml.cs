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

namespace StackPanel_and_RadioButton
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            List<string> provincies = new List<string>();
            provincies.Add("Barcelona");
            provincies.Add("Lleida");
            provincies.Add("Girona");
            provincies.Add("Tarragona");

            foreach(string provincia in provincies)
            {
                RadioButton rb = new RadioButton();
                rb.Content = provincia;
                stkProvincies.Children.Add(rb);
                rb.Checked += Rb_Checked;
            }

        }

        private void Rb_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            
            if (rb.Parent==stkUp)
            {
                txbOpcioSeleccionada.Text = rb.Content.ToString();
            } else
            {
                txbOpcioSeleccionadaDinamica.Text = rb.Content.ToString();
            }            
        }

   
        /*
        private void rdoTots_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            txbOpcioSeleccionada.Text = rb.Content.ToString();
        }*/

    }
}
