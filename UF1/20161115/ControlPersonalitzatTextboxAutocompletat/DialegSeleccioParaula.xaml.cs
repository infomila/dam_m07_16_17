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

// La plantilla de elemento del cuadro de diálogo de contenido está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace ControlPersonalitzatTextboxAutocompletat
{
    public sealed partial class DialegSeleccioParaula : ContentDialog
    {
        

        public DialegSeleccioParaula(List<string> pValorsValids, string valorActual)
        {
            this.InitializeComponent();

            /*List<string> pValorsValidsFiltrats = new List<string>();
            foreach(string valor in pValorsValids)
            {
                if(valor.StartsWith(valorActual))
                {
                    pValorsValidsFiltrats.Add(valor);
                }
            }*/
            /*List<string> pValorsValidsFiltrats = new List<string> (
                pValorsValids.Where(valor => valor.StartsWith(valorActual)));
                */
            List<string> pValorsValidsFiltrats = new List<string>();
            pValorsValids.ForEach(valor => {
                if (valor.StartsWith(valorActual))
                    pValorsValidsFiltrats.Add(valor) ;
            });



            lsvValors.ItemsSource = pValorsValidsFiltrats;

        }

        public string ValorSeleccionat
        {
            get
            {
                return lsvValors.SelectedItem.ToString();
            }
        }


    }
}
