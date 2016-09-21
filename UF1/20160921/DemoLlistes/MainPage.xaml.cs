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

namespace DemoLlistes
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            provesLlistes();
        }

        public void provesLlistes()
        {
            List<string> paraules = new List<string>();
            paraules.Add("Welcome"); // 0
            paraules.Add("To");      // 1
            paraules.Add("The");     // 2
            paraules.Add("Jungle");
            paraules.Add("!!!");

            foreach(string paraula in paraules)
            {
                Debug.WriteLine(">"+paraula);
            }

            Debug.WriteLine(">" + paraules[2]);  // The


        }
    }
}
