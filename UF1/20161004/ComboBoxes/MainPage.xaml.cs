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

namespace ComboBoxes
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            List<string> provincies = new List<string>()
                            { "Barcelona", "Lleida", "Tarragona", "Girona" };
 
            foreach( string p in provincies)
            {
                cboProvincies2.Items.Add(p);
            }
           
            //---------------------------------------------
            //               COMBOBOX AMB DATA BINDING
            // 1) Creació de dades
            Provincia pBarcelona = new Provincia(1, "Barcelona", 2250000, 300, "Futbol Club");

            List<Provincia> provs = new List<Provincia>();
            provs.Add(pBarcelona);
            provs.Add(new Provincia(2, "Tarrragona", 500000, 200, "Tarragona m'esborrona"));
            provs.Add(new Provincia(3, "Girona", 250000, 300, "Eooooooo!"));
            provs.Add(new Provincia(4, "Lleida", 250000, 300, "From la terra ferma!"));

            // 2) Binding amb el Combobox
            cboProvincies3.DataContext = provs;
            cboProvincies3.DisplayMemberPath = "Nom";
            cboProvincies3.SelectedValuePath = "Codi";


        }

    
        private void cboProvincies1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            ComboBoxItem item = (ComboBoxItem)cb.SelectedValue;
            txbProvincia1.Text = cb.SelectedIndex + " " + item.Content;
        }

        private void cboProvincies2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            txbProvincia1.Text = cb.SelectedIndex + " " + cb.SelectedValue;

        }

        private void cboProvincies3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Provincia p = (Provincia)cb.SelectedItem;
            txbProvincia1.Text = cb.SelectedIndex + " " + cb.SelectedValue
                +" " + p.Nom;


            txbCodi.Text = p.Codi.ToString();
            txbNom.Text = p.Nom;
            txbSup.Text = p.Superficie.ToString();
            txbPob.Text = p.Poblacio.ToString();
            txbDesc.Text = p.Desc;
        }

        private void txbCodi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txbCamps_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            // IMPORTANT: el desplegable conté la província seleccionada
            Provincia p = (Provincia)cboProvincies3.SelectedItem;
            switch(tb.Name)
            {
                case "txbNom":              p.Nom = tb.Text; break;
                case "txbPob":              p.Poblacio = Int32.Parse(tb.Text); break;
                case "txbSup":              p.Superficie = Int32.Parse(tb.Text); break;
                case "txbDesc":             p.Desc = tb.Text; break;

            }
        }
    }
}
