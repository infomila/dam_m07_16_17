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

namespace IntroLlenguatgeCS
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

        private void btnBoto_Click(object sender, RoutedEventArgs e)
        {
    

            // Comentari monolínia
            /*
             * Comentari multilínia 
             */



            // ------------------------- TIPUS SENCERS -------
            int i = 0;
            char c='x';
            uint ui = 12;
            ui = ui - 20;
            txtMissatge.Text = "UI val " + ui + Environment.NewLine; ;
            short s;
            byte b;
            Int32 integerStandard;
            i++;
            char c1;
            c1 = c;
            //---------------------- TIPUS en COMA FLOTANT ----------
            float f0 = (float)12.2;
            float f1 = 12000.2199f;
            double d = 12000.2199;
            //txtMissatge.Text = txtMissatge.Text + "f1 val " +f1;
            txtMissatge.Text +=  "f1 val " + f1 + Environment.NewLine;

            string f1s = "HOLA";
            f1s = f1s + " MON";
            f1s = d.ToString("#######.0000000");
            txtMissatge.Text += "f1s val " + f1s + Environment.NewLine;

            // tipus decimal. Suporta fins a 28 o 29 
            decimal dec = 12000.2199M;

            bool certOFals ;
            certOFals = false;
            txtMissatge.Text += "Soc fals? " + certOFals + Environment.NewLine;
            txtMissatge.Text += "\nMés coses\nI Més";

            string dosLinies = "Primera Línia\nSegona Línia";
            string dosLinies2 = "Primera Línia"+ Environment.NewLine + "Segona Línia";

            string cadena = "Món";
            string autoreemplaç = $"Hola {cadena} ! ";
            txtMissatge.Text += Environment.NewLine;
            txtMissatge.Text += autoreemplaç;
            //Console.WriteLine(autoreemplaç);



            { // inici de l'àmbit
                int v = 3; // la variable v "viu" dins dels brackets
                v++;

                //int v = 45;  // Això no compilaria, la variable existeix.
            } // final de l'ambit ( v desapareix )
            {
                int v = 4; // aquí la puc tornar a declarar, doncs v  no existeix
                v--;
            }

            // exemple de taula amb inicialització
            int[] numeros= { 1, 6, 7, 10 };

            // podem fer taules de tipus més complexes, com cadenes
            string[] persones = { "Maria", "Berta", "Joan" };


            // Creació d'una llista dinàmica
            List<string> people = new List<string>();
            // Afegir elements a la llista
            people.Add("Maria");
            people.Add("Berta");
            people.Add("Joan");
            people.Add("Pep");
            // Accés per índex
            people[2] = "Josep";
            // Recorregut per índex
            string noms = "";
            for(int n=0;n<people.Count;n++)
            {
                noms += $" - {people[n]} \n";
            }
            // Recorregut amb foreach
            foreach( string p in people )
            {
                noms += $" - {p} \n";
            }
            


            // creació d'una taula indicant dimensions, que s'omplirà
            // amb el valor per defecte del tipus de dades ( 0 en aquest cas )
            double[] temperatures = new double[10];

            foreach( int t in numeros)
            {
                txtMissatge.Text += $" - {t}\n";
            }

            int nota = 5;
            string notaDescriptiva;
            switch (nota)
            {
                case 5:
                case 6:
                    notaDescriptiva = "Aprovat";
                    break;
                case 7:
                case 8:
                    notaDescriptiva = "Notable";
                    break;
                case 9:
                case 10:
                    notaDescriptiva = "Excel·lent";
                    break;
                default:
                    notaDescriptiva = "Insuficient";
                    break;
            }

            switch (notaDescriptiva)
            {
                case "Aprovat":
                    nota = 5;
                    break;
                case "Notable":
                    nota = 7;
                    break;
                case "Excel·lent":
                    nota = 9;
                    break;
                default:
                    nota = 4;
                    break;
            }
        }
    }
}
