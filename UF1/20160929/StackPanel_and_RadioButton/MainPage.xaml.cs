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

namespace StackPanel_and_RadioButton
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        List<string> mProvinciesSeleccionades = new List<string>();
        List<CheckBox> mCheckboxesProvincies = new List<CheckBox>();


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
            //-----------------------------------
            int index = 0;
            foreach (string provincia in provincies)
            {
                CheckBox cb = new CheckBox();
                cb.Content = provincia;
                cb.Tag = index;                    
                stkOpcions.Children.Add(cb);
                cb.Checked += Cb_Checked;
                cb.Unchecked += Cb_Checked;
                index++;
            }
            //---------------------------------------
            foreach (string provincia in provincies)
            {
                CheckBox cb = new CheckBox();
                mCheckboxesProvincies.Add(cb);
                cb.Content = provincia;
                cb.Tag = index;
                stkOpcions2.Children.Add(cb);
                cb.Checked   += Cb_Checked1;
                cb.Unchecked += Cb_Checked1;
                index++;
            }
            //---------------------------------------
        }

        private void Cb_Checked1(object sender, RoutedEventArgs e)
        {
            string cadena = "";

            foreach( CheckBox c in stkOpcions2.Children)
            //foreach( CheckBox c in mCheckboxesProvincies)
            {
                if(c.IsChecked==true) {
                    cadena += " " + c.Content;
                }
            }
            txbOpcionsSeleccionades2.Text = cadena;
        }

        private void mostraLlista(List<string> mProvinciesSeleccionades)
        {
            string sortida = "";
            foreach( string provincia in mProvinciesSeleccionades)
            {
                sortida += " " + provincia;
            }
            txbOpcionsSeleccionades.Text = sortida;
        }

        private void Cb_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.IsChecked==true)
            {
                mProvinciesSeleccionades.Add(cb.Content.ToString());
            } else
            {
                mProvinciesSeleccionades.Remove(cb.Content.ToString());
            }
            mostraLlista(mProvinciesSeleccionades);
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

    }
}
