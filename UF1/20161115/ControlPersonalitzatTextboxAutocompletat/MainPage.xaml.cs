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

namespace ControlPersonalitzatTextboxAutocompletat
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            txtAuto.ValorsValids = new List<string> { "AAC", "AAD", "ABB", "ABBCCCCC" };


        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            txtOk.Text = txtAuto.Valid? "OK":"KK";
        }

        private void txtAuto_TextCanviat(object sender, EventArgs e)
        {
            txtOk.Text = txtAuto.Valid ? "OK" : "KK";
        }
    }
}
