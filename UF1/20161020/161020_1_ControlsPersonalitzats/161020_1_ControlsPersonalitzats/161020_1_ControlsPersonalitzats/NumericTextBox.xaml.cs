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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace _161020_1_ControlsPersonalitzats
{
    public sealed partial class NumericTextBox : UserControl
    {
        public NumericTextBox()
        {
            this.InitializeComponent();
        }
        //event que es llença quan hi ha canvis
        public event EventHandler ValorCanviat; 

        

        public int Valor
        {
            get { return int.Parse(txbNum.Text); }
            set { txbNum.Text = value.ToString(); }
        }

        private void txbNum_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            //si el què ens es escriuen NO ÉS UN NÚMERO no deixem fer-ho
            e.Handled = !(e.Key.ToString().StartsWith("Num")); 
        }

        private void txbNum_Paste(object sender, TextControlPasteEventArgs e)
        {
            e.Handled = true; //interceptem tots els pastes :D
        }

        private void txbNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            //cada cop que canvia el textBox. Cridem a l'event ValorCanviat
            //el this és el propi NumericTextBox
            ValorCanviat(this, null);
        }
    }
}
