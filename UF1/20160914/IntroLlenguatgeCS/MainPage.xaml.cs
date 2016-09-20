using System;
using System.Collections.Generic;
using System.Globalization;
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
        int id;

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





            //exemple de restricció d'àmbit
            {
                int b1 = 0;
                b1++;
            }

            {
                int b1 = 0;
                b1++;
            }


            // Exemple d'utilització de variables 
            // locals sense inicialitza
            int kk;
            kk = 0;
            kk++;

            id++; //modificació d'un atribut no inicialitzat

            //
            string nomBuscat = "Paco";
            string consultaClient = "select * from client where name = 'Paco' ";

            string consultaClient1 = "select * from client where name = '" + nomBuscat +"' ";
            string consultaClient2 = $"select * from client where name = '{nomBuscat}' ";

            // funcions de les cadenes
            string missatge = "Manel";
            missatge = missatge.PadLeft(10, '_');
            txtMissatge.Text += "\n Exemple de padding:" + missatge + ":";

            string nom = "    Josep Maria ";
            nom = nom.Trim();
            txtMissatge.Text += $"\n Exemple de trimming:{nom}:";

            string nomHacker = "  _  Josep    Maria De La oOOOOOOOOO   @# ";
            char[] caracters = { ' ','_','@','#'};
            nomHacker = nomHacker.Trim(caracters);
 
            txtMissatge.Text += $"\n Exemple de trimming++:{nomHacker}:";
            //               01234567890
            /// nomHacker = "Josep   Maria"
            /// 
            int posicioEspai;
            string resultat = "";
            do
            {
                nomHacker = nomHacker.Trim();
                posicioEspai = nomHacker.IndexOf(' ');
                if (posicioEspai >= 0)
                {
                    resultat += nomHacker.Substring(0, posicioEspai) + " ";
                    nomHacker = nomHacker.Substring(posicioEspai);
                }
            } while (posicioEspai >= 0);
            resultat += nomHacker;     

        }
    }
}
