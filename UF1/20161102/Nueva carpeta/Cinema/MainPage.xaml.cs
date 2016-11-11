using Cinema.Model;
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

namespace Cinema
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private List<TipusButaca> llistaTipusButaca = new List<TipusButaca>();
  


        public MainPage()
        {
            this.InitializeComponent();


            // inicialitzar llista de butaques
            llistaTipusButaca.Add(new TipusButaca(0, "Platea", (decimal)60.45, Colors.Azure));
            llistaTipusButaca.Add(new TipusButaca(1, "Primer pis", (decimal)40.45, Colors.Chocolate));
            llistaTipusButaca.Add(new TipusButaca(2, "Lateral", (decimal)20.3, Colors.DeepPink));





            ObservableCollection<Butaca> butaques = new ObservableCollection<Butaca>();



            butaques.Add( new Butaca("Test 1", TipusOcupacio.LLIURE, llistaTipusButaca[0]) );
            butaques.Add(new Butaca("Test 2", TipusOcupacio.LLIURE, llistaTipusButaca[1]));
            butaques.Add(new Butaca("Test 3", TipusOcupacio.LLIURE, llistaTipusButaca[2]));

            lsvButaques.ItemsSource = butaques;
            //lsvButaques.DisplayMemberPath = "DescExtraSuperDuper";
            crearCine();

            Butaca bc = new Butaca("Test 1", TipusOcupacio.LLIURE, llistaTipusButaca[0]);
            laButaca.MyButaca = bc;


            bc.Ocupada = TipusOcupacio.SELECCIONADA;
        }


        public void crearCine()
        {
            /*
                    012345678901234
                    **  *** ***  **
                    **  *** ***  **       
                    **  *** ***  **
                    **  *** ***  **
                        *** ***  
             */

                                       //c, f
            Butaca[,] cine = new Butaca[15, 5];




            // Assegurem que tot estigui a null
            for (int f = 0; f < cine.GetLength(1); f++)
            {
                for (int col = 0; col < cine.GetLength(0); col++) {
                    cine[col,f]= null;
                }
            }




            // Laterals
            for(int f=0;f<4;f++)
            {
                cine[0 , f] = new Butaca("LAT F"+f+"-1", TipusOcupacio.LLIURE, llistaTipusButaca[2]);
                cine[1 , f] = new Butaca("LAT F"+f+"-2", TipusOcupacio.LLIURE, llistaTipusButaca[2]);
                cine[13, f] = new Butaca("LAT F"+f+"-3", TipusOcupacio.LLIURE, llistaTipusButaca[2]);
                cine[14, f] = new Butaca("LAT F"+f+"-4", TipusOcupacio.LLIURE, llistaTipusButaca[2]);
            }

            // Platea
            for (int f = 0; f < 2; f++)
            {
                int c = 1;
                for (int col = 4; col < 11; col++)
                {
                    if (col != 7)
                    {
                        cine[col, f] = new Butaca("PLAT F" + (f+1) + "-" + c, TipusOcupacio.LLIURE, llistaTipusButaca[0]);
                    }
                    c++;
                }
            }
            // Primer pis
            for (int f = 2; f < 5; f++)
            {
                int c = 1;
                for (int col = 4; col < 11; col++)
                {
                    if (col != 7)
                    {
                        cine[col, f] = new Butaca("PRIMER PIS F" + (f-1) + "-" + c, TipusOcupacio.LLIURE, llistaTipusButaca[1]);
                    }
                    c++;
                }
            }

            // Ocupem 3 seients.
            cine[5, 2].Ocupada = TipusOcupacio.OCUPADA;
            cine[8, 0].Ocupada = TipusOcupacio.OCUPADA;
            cine[9, 0].Ocupada = TipusOcupacio.OCUPADA;
            
        }
       


    }
}
