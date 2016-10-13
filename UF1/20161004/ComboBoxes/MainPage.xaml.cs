using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace ComboBoxes
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

     

        private enum MODE_EDICIO
        {
            SENSE_CANVIS,
            AMB_CANVIS,
            NOU
        }

        private MODE_EDICIO mMode;
        ObservableCollection<Provincia> provs = new ObservableCollection<Provincia>();

        public MainPage()
        {

            mMode = MODE_EDICIO.SENSE_CANVIS;

            this.InitializeComponent();

            grdForm.Visibility = Visibility.Collapsed;

            List<string> provincies = new List<string>()
                            { "Barcelona", "Lleida", "Tarragona", "Girona" };

            foreach ( string p in provincies)
            {
                cboProvincies2.Items.Add(p);
            }
           
            //---------------------------------------------
            //               COMBOBOX AMB DATA BINDING
            // 1) Creació de dades
            Provincia pBarcelona = new Provincia(1, "Barcelona", 2250000, 300, "Futbol Club");




            
            //List<Provincia> provs = new List<Provincia>();
            provs.Add(pBarcelona);
            provs.Add(new Provincia(2, "Tarrragona", 500000, 200, "Tarragona m'esborrona"));
            provs.Add(new Provincia(3, "Girona", 250000, 300, "Eooooooo!"));
            provs.Add(new Provincia(4, "Lleida", 250000, 300, "From la terra ferma!"));

            


            // 2) Binding amb el Combobox
            cboProvincies3.DataContext = provs;
            cboProvincies3.DisplayMemberPath = "Nom";
            cboProvincies3.SelectedValuePath = "Codi";

            actualitzaBotoCancel();


        }

        private void actualitzaBotoCancel()
        {
            if (mMode == MODE_EDICIO.SENSE_CANVIS)
            {
                btnCancel.IsEnabled = cboProvincies3.SelectedIndex != -1;
            } else
            {
                btnCancel.IsEnabled = true;
            }
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

            actualitzaBotoCancel();

            ComboBox cb = (ComboBox)sender;

            if (cb.SelectedIndex == -1)
            {
                //grdForm.Visibility = Visibility.Collapsed;
            }
            else
            {
                grdForm.Visibility = Visibility.Visible;

                mostrarItemActual(cb);

                setMode(MODE_EDICIO.SENSE_CANVIS);
            }
        }

        private void mostrarItemActual(ComboBox cb)
        {
            Provincia p = (Provincia)cb.SelectedItem;
   
            desactivarTextChanged();

            txbCodi.Text = p.Codi.ToString();
            txbNom.Text = p.Nom;
            txbSup.Text = p.Superficie.ToString();
            txbPob.Text = p.Poblacio.ToString();
            txbDesc.Text = p.Desc;

            activarTextChanged();
        }

        private void activarTextChanged()
        {
            txbCodi.TextChanged += txbCamps_TextChanged;
            txbNom.TextChanged  += txbCamps_TextChanged;
            txbSup.TextChanged  += txbCamps_TextChanged;
            txbPob.TextChanged  += txbCamps_TextChanged;
            txbDesc.TextChanged += txbCamps_TextChanged;
        }

        private void desactivarTextChanged()
        {
            txbCodi.TextChanged   -= txbCamps_TextChanged;
            txbNom.TextChanged    -= txbCamps_TextChanged ;
            txbSup.TextChanged    -= txbCamps_TextChanged ;
            txbPob.TextChanged    -= txbCamps_TextChanged ;
            txbDesc.TextChanged   -= txbCamps_TextChanged;

        }

        private void setMode(MODE_EDICIO nouMode)
        {
            if(nouMode==MODE_EDICIO.SENSE_CANVIS)
            {
                actualitzaBotoCancel();
                btnCancel.Content = "Delete-";
                btnSaveOrNew.Content = "New";
                btnSaveOrNew.IsEnabled = true;
            } else if (nouMode == MODE_EDICIO.AMB_CANVIS)
            {
                btnCancel.IsEnabled = true;
                btnCancel.Content = "Cancel";
                //btnCancel.Visibility = Visibility.Visible;
                btnSaveOrNew.Content = "Save";
                //btnSaveOrNew.IsEnabled = false;
            } else
            {
                btnCancel.IsEnabled = true;
                //NOU
                btnCancel.Content = "Cancel";
                //btnCancel.Visibility = Visibility.Visible;
                btnSaveOrNew.Content = "Save";
                //btnSaveOrNew.IsEnabled = false;
            }
            // ARGH
            mMode = nouMode;
        }


        private void txbCamps_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (mMode == MODE_EDICIO.SENSE_CANVIS)
            {
                setMode(MODE_EDICIO.AMB_CANVIS);
            } 
            bool nomCorrecte = validaText(txbNom, 4);
            bool descCorrecte = validaText(txbDesc, 20);
            bool supCorrecte = validaInteger(txbSup);
            bool pobCorrecte = validaInteger(txbPob);

            btnSaveOrNew.IsEnabled =    nomCorrecte && 
                                        descCorrecte && 
                                        supCorrecte && 
                                        pobCorrecte;

            

            /*TextBox tb = (TextBox)sender;
            // IMPORTANT: el desplegable conté la província seleccionada
            Provincia p = (Provincia)cboProvincies3.SelectedItem;
            switch(tb.Name)
            {
                case "txbNom":              p.Nom = tb.Text; break;
                case "txbPob":              p.Poblacio = Int32.Parse(tb.Text); break;
                case "txbSup":              p.Superficie = Int32.Parse(tb.Text); break;
                case "txbDesc":             p.Desc = tb.Text; break;

            }*/
        }

        private bool validaInteger(TextBox txb)
        {
            int numero;
            bool esNumero = Int32.TryParse(txb.Text, out numero);
            mostraTextBox(txb, esNumero);
            return esNumero;
        }
        private bool validaText(TextBox txb, int minNumChars)
        {
            bool esTextValid = txb.Text.Trim().Length >= minNumChars;
            mostraTextBox(txb, esTextValid);
            return esTextValid;
        }
        private void mostraTextBox( TextBox txb, Boolean ok)
        {
            Color color = Colors.PaleVioletRed;
            if (ok)
            {
                color = Colors.White;
            }
            txb.Background = new SolidColorBrush(color);
        }

        private void btnSaveOrNew_Click(object sender, RoutedEventArgs e)
        {
            if (mMode == MODE_EDICIO.SENSE_CANVIS)
            {
                // NOU !!!!!
                setMode(MODE_EDICIO.NOU);
                // Deseleccionar la província actual
                cboProvincies3.SelectedIndex = -1;
                NetejarTextboxes();
                 
                txbCodi.Text = (provs.Count== 0) ? "1" : (provs.Last<Provincia>().Codi + 1).ToString();

            }
            else
            {
                // Save 
                Provincia p;
                if (mMode == MODE_EDICIO.AMB_CANVIS)
                {
                    p = (Provincia)cboProvincies3.SelectedItem;
                    p.Nom = txbNom.Text;
                    p.Poblacio = Int32.Parse(txbPob.Text);
                    p.Superficie = Int32.Parse(txbSup.Text);
                    p.Desc = txbDesc.Text;
                }
                else
                {
                    //estic desant una nova província
                    p = new Provincia(
                        Int32.Parse(txbCodi.Text), 
                        txbNom.Text,
                        Int32.Parse(txbPob.Text),
                        Int32.Parse(txbSup.Text),
                        txbDesc.Text);
                    provs.Add(p);
                    cboProvincies3.SelectedIndex = provs.Count - 1;
                }
                
                setMode(MODE_EDICIO.SENSE_CANVIS);
            }
        }

        private void NetejarTextboxes()
        {
            desactivarTextChanged();
            txbCodi.Text = "";
            txbNom.Text = "";
            txbDesc.Text = "";
            txbPob.Text = "";
            txbSup.Text = "";
            activarTextChanged();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

            if (mMode == MODE_EDICIO.SENSE_CANVIS)
            {
                // Vull esborrar
                provs.RemoveAt(cboProvincies3.SelectedIndex);

                cboProvincies3.SelectedIndex = -1;    
                NetejarTextboxes();
            }
            else
            {
                // Vull cancel·lar
                if (mMode == MODE_EDICIO.NOU)
                {
                    cboProvincies3.SelectedIndex = -1;
                    NetejarTextboxes();                    
                }
                else
                {
                    mostrarItemActual(cboProvincies3);
                }
                setMode(MODE_EDICIO.SENSE_CANVIS);

            }
        }
    }
}
