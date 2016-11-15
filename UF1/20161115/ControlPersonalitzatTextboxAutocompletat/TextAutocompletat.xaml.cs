using System;
using System.Collections.Generic;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ControlPersonalitzatTextboxAutocompletat
{
    public sealed partial class TextAutocompletat : UserControl
    {

        public event EventHandler TextCanviat;

        public TextAutocompletat()
        {
            this.InitializeComponent();
        }

        private async void btnOpenDialog_Click(object sender, RoutedEventArgs e)
        {
            DialegSeleccioParaula dialeg = new DialegSeleccioParaula(mValorsValids, txtNom.Text);
            ContentDialogResult result = await dialeg.ShowAsync();
            if(result == ContentDialogResult.Secondary) //OK !
            {
                if(dialeg.ValorSeleccionat!=null)
                {
                    txtNom.Text = dialeg.ValorSeleccionat;
                }
            }
        }

        /*public string Valor
        {
            get { return txtNom.Text; }
            set { txtNom.Text = value; }
        }*/

        public string Valor
        {
            get { return (string)GetValue(ValorProperty); }
            set { SetValue(ValorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Valor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValorProperty =
            DependencyProperty.Register("Valor", typeof(string), 
                typeof(TextAutocompletat), new PropertyMetadata(""));




        private List<string> mValorsValids;

        public List<string> ValorsValids
        {
            get { return mValorsValids; }
            set {
                mValorsValids = value;
                validar();
            }
        }

        public bool Valid
        {
            get
            {
                return (
                    mValorsValids != null 
                    &&
                    mValorsValids.Contains(txtNom.Text));
            }
        }


        private void validar()
        {
            if (txtNom.Text.Length == 0) setIncomplet();
            else
            {
                int coincidencies = 0;
                string ultimaCoincidencia="";
                if (mValorsValids.Contains(txtNom.Text))
                {
                    setOk();
                }
                else
                {
                    foreach (string paraula in mValorsValids)
                    {

                        if (paraula.StartsWith(txtNom.Text))
                        {
                            coincidencies++;
                            ultimaCoincidencia = paraula;
                        }
                        if (coincidencies > 1) break;
                    }
                    if (coincidencies == 0)
                    {
                        setErroni();
                    }
                    else if (coincidencies == 1)
                    {
                        txtNom.Text = ultimaCoincidencia;
                    }
                    else
                    {
                        setIncomplet();
                    }
                }
            }
        }

        private void setOk()
        {
            txbMissatge.Text = "Ok";
            txbMissatge.Foreground = new SolidColorBrush(Colors.Green);
            btnOpenDialog.IsEnabled = true;
        }

        private void setErroni()
        {
            txbMissatge.Text = "ERROR";
            txbMissatge.Foreground = new SolidColorBrush(Colors.Red);
            btnOpenDialog.IsEnabled = false;
        }

        private void setIncomplet()
        {
            txbMissatge.Text = "...";
            txbMissatge.Foreground = new SolidColorBrush(Colors.YellowGreen);
            btnOpenDialog.IsEnabled = true;
        }

        private void txtNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            validar();
            TextCanviat(this, new EventArgs());
        }

        private void btnOpenDialog_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
