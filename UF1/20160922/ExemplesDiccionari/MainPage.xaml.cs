using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ExemplesDiccionari
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            provesDiccionaris();
        }

        

        private void provesDiccionaris()
        {
            Dictionary<string, int> gols;
            gols = new Dictionary<string, int>();
            gols["Messi"]=54;
            gols["Iniesta"] = 10;
            gols["Neymar"] = 32;
            gols["Kun Agüero"] = 32;
            gols["Ibrahimovic"] = 10;
            gols["Chuck Norris Soccer Club"] = 10;

            Dictionary<int, List<string>> jugadorsPerNombreDeGols = new Dictionary<int, List<string>>();






            Debug.WriteLine("Gols de Messi " + gols["Messi"]);
            // Versió educada
            if(gols.ContainsKey("Messixxxxxx"))
            {
                Debug.WriteLine("Gols de Messi " + gols["Messixxxxx"]);
            }
            else
            {
                Debug.WriteLine("Aquest tio no existeix");
            }
            // Versió Mourinho
            try
            {
                Debug.WriteLine("Gols de Messi " + gols["Messixxxxx"]);
            }
            catch (Exception)
            {

               Debug.WriteLine("Aquest tio no existeix");
            }

            var claus = gols.Keys;
            foreach(string jugador in claus)
            {

                Debug.WriteLine($"El jugador {jugador} ha marcat {gols[jugador]} ");
            }


            


            /*jugadorsPerNombreDeGols = new Dictionary<int, List<string>>();

            // 30  --> Messi, Aguero, Ibrahimovic
            List<string> jugadorsAmb30Gols = new List<string>();
            jugadorsAmb30Gols.Add("Messi");
            jugadorsAmb30Gols.Add("Aguero");
            jugadorsAmb30Gols.Add("Ibrahimovic");
            jugadorsPerNombreDeGols[30] = jugadorsAmb30Gols;
            //--------------------------------------------------


            jugadorsPerNombreDeGols[30].Add("Fulanito");
            List<string> x;
            x = jugadorsPerNombreDeGols[30];
            x.Add("kkkk");

            jugadorsPerNombreDeGols[25].Add("Joan Xusquerin");*/
        }
    }
}
