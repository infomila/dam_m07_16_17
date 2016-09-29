using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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

            // Validem el form incialment
            validaForm();
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
                    txbNIF.SelectionStart = posicioCursor + 1;
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

            return Regex.IsMatch(elTextQueVullEscriure, "^[0-9]{0,8}[TRWAGMYFPDXBNJZSQVHLCKE]?$");

        }

        private void txbNIF_Paste(object sender, TextControlPasteEventArgs e)
        {
            e.Handled = true;
        }

        private async void btnGo_Click(object sender, RoutedEventArgs e)
        {
           var dialog = new Windows.UI.Popups.MessageDialog(
            "Aquest client és correcte",
            "Felicitats");

            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Quit") { Id = 0 });
            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Write Another") { Id = 1 });

            // Selecció de l'opció per defecte
            dialog.DefaultCommandIndex = 0;
            // Indiquem quina és la comanda de cancel·lació.
            dialog.CancelCommandIndex = 1;

            var result = await dialog.ShowAsync();
            if((int)result.Id==1)
            {
                txbNIF.Text = "";
                txbNom.Text = "";
                txbCognom.Text = "";
            }  else
            {
                // Sortim
                Application.Current.Exit();
            }          
        }

        private void generic_TextChanged(object sender, TextChangedEventArgs e)
        {
            validaForm();
        }



#region validacions

        /// <summary>
        ///  Validacions generals
        /// </summary>          
        private void validaForm()
        {
            bool nomOk =    validaAmbRegEx(txbNom,      false, "^([A-Za-z0-9]+[ ]+)*[A-Za-z0-9]+$");
            bool cognomOk = validaAmbRegEx(txbCognom,   false, "^([A-Za-z0-9]+[ ]+)*[A-Za-z0-9]+$");
            bool NIFOk =    validaAmbRegEx(txbNIF,      false, "^[0-9]{8}[A-Z]$");
            if(NIFOk)
            {
                NIFOk = validaLletraNIF(txbNIF.Text);
                estilTextBox(txbNIF, NIFOk);
            }

            btnGo.IsEnabled = nomOk && cognomOk && NIFOk;
        }

        /// <summary>
        /// Valida la lletra del NIF
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool validaLletraNIF(string text)
        {
            // Desem la lletra
            char lletra = text.Last();
            // Eliminar la lletra del final
            text = text.Substring(0, text.Length - 1);

            int numero = Int32.Parse(text);
            int index = numero % 23;
            string lletresValides = "TRWAGMYFPDXBNJZSQVHLCKET";
            return lletresValides[index]==lletra;
        }

        /// <summary>
        /// Valida un textbox donada una expressió regular.
        /// Estilitza el textbox segons el contingut estigui bé o 
        /// malament.
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="regexp"></param>
        /// <returns></returns>
        private bool validaAmbRegEx(TextBox textbox, bool opcional, string regexp)
        {
            // Nota : fem Trim() per permetre que l'usuari pugui posar
            //        espais davant i darrera
            string text = textbox.Text.Trim();
            
            // cas en el que el camp és opcional
            if (text.Length == 0 && opcional) return true;

            bool correcte = Regex.IsMatch(text, regexp);

            estilTextBox(textbox, correcte);

            return correcte;
        }

        /// <summary>
        /// Estilitzem el textbox en funció de si el contingut és vàlid o no.
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="correcte"></param>
        private void estilTextBox(TextBox textbox, bool correcte)
        {
            Color backColor = correcte ? Colors.LawnGreen : Colors.Yellow;
            textbox.Background = new SolidColorBrush(backColor);
        }

#endregion validacions

    }
}
