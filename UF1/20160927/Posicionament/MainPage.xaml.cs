using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
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


            /// Versió compacta
            /// 
            int posicioCursor = txbNIF.SelectionStart;
            string fragmentDavant = txbNIF.Text.Substring(0, posicioCursor);
            string fragmentDarrere = txbNIF.Text.Substring(posicioCursor) ;

             
            string lletresValides = "TRWAGMYFPDXBNJZSQVHLCKE";
            if (nomTecla.StartsWith("Number") ||
                lletresValides.Contains(nomTecla))
            {
                string elTextQueVullEscriure;
                if (nomTecla.StartsWith("Number") )
                {
                    char numero = nomTecla[nomTecla.Length - 1];
                    elTextQueVullEscriure = fragmentDavant + numero + fragmentDarrere;
                } else
                {
                    //la tecla és una lletra
                    elTextQueVullEscriure = fragmentDavant + nomTecla + fragmentDarrere;
                }
                e.Handled = true;
                if (validaNIFParcial(elTextQueVullEscriure))
                {
                    txbNIF.Text = elTextQueVullEscriure;
                }

            } else
            {
                e.Handled = true;
            }

            /*
            /// VERSIÓ BUNYOL

            int numero = 0;
            bool hiHaLletra = txbNIF.Text.Length > 0 &&
                                    !Int32.TryParse(txbNIF.Text, out numero);
            if (nomTecla.StartsWith("Number"))
            {
                // xifra vàlida
                
                
                if(!hiHaLletra)
                {
                    if(txbNIF.Text.Length>=8)
                    {
                        e.Handled = true;
                    }
                } else
                { // si hi ha lletra
                    if(txbNIF.SelectionStart==txbNIF.Text.Length) // estic al darrera
                    {
                        e.Handled = true;
                    } else
                    {
                        // estic al davant
                        if (txbNIF.Text.Length >= 9)
                        {
                            e.Handled = true;
                        }
                    }
                }

            } else // si no és número
            {
                // mirem si és lletra
                string lletresValides = "TRWAGMYFPDXBNJZSQVHLCKE";
                if ( lletresValides.Contains(e.Key.ToString()))
                {
                    if (hiHaLletra || txbNIF.Text.Length !=8) {
                        e.Handled = true;
                    }
                }
                else
                {
                    // es porqueria
                    e.Handled = true;
                }

            }
            */




        }

        private bool validaNIFParcial(string elTextQueVullEscriure)
        {

            return Regex.IsMatch(elTextQueVullEscriure, "^[0-9]{0,8}[A-Z]?$");

        }

        private void txbNIF_Paste(object sender, TextControlPasteEventArgs e)
        {
            e.Handled = true;
        }

        private async void btnGo_Click(object sender, RoutedEventArgs e)
        {
           /* var dialog = new Windows.UI.Popups.MessageDialog(
            "Aquest client és correcte",
            "Felicitats");

            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Ok") { Id = 0 });
            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Cancel") { Id = 1 });

            // Selecció de l'opció per defecte
            dialog.DefaultCommandIndex = 0;
            // Indiquem quina és la comanda de cancel·lació.
            dialog.CancelCommandIndex = 1;

            var result = await dialog.ShowAsync();
            if((int)result.Id==0)
            {
                txbNIF.Text = "";
                txbNom.Text = "";
                txtCognom.Text = "";
                Frame.Navigate(typeof(LlistaUsuaris));
            }
             */
        }
    }
}
