using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ConversionsADojo
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            proves(); mesProves();
        }
        public void mesProves()
        {
            List<string> people = new List<string>();
            // Afegir elements a la llista
            people.Add("Maria");
            people.Add("Berta");
            people.Add("Joan");
            people.Add("Pep");
            // Accés per índex
            people[2] = "Josep";

            bool MariaFound = people.Contains("Maria"); // mariaFound és true
            bool mariaFound = people.Contains("maria"); // mariaFound és false
            bool kkFound = people.Contains("kk"); //kkFound false

             
            Debug.WriteLine(MariaFound);
            Debug.WriteLine(mariaFound);


            //    tipus de la clau, tipus del valor
            Dictionary<string, int> anotacions = new Dictionary<string,int>();
            // assignem valor a una clau
            anotacions["Maria"] = 10;
            anotacions["Pere"] = 8;

            // Buscar valor existent
            int anotacioMaria = anotacions["Maria"]; //anotacioMaria = 10
            Debug.WriteLine(anotacioMaria);

            // Buscar valor que potser no hi és ?¿
            try
            {
                int anotacioFantasma = anotacions["????"];

            }catch(Exception ex)
            {
                Debug.WriteLine("Persona no trobada !!");
            }
            
            if(anotacions.ContainsKey("????"))
            {
                // fer aquí la feina amb la seguretat que la clau existeix
            }

            // Primer aconseguim la col·lecció de totes les claus
            var claus = anotacions.Keys;
            // Recorrem les claus, i per cada clau demanem el valor
            foreach( string clau in claus)
            {
                Debug.WriteLine($"{clau} ha fet {anotacions[clau]} punts");
            }

            // Podem fer també un recorregut estrictament pels valors
            var valors = anotacions.Values;
            foreach(int anotacio in valors)
            {
                Debug.WriteLine($"{anotacio}");
            }

        }

        public void proves()
        {
            DateTime ara = DateTime.Now; // ARA, incloent dia i hora
            DateTime avui = DateTime.Today; // ARA, incloent dia només 
            DateTime data = new DateTime(2017, 12, 31); // constructor explícit amb data
            DateTime dataIHora = new DateTime(2017, 12, 31, 22, 30, 59); // constructor explícit amb data i hora

            int mes = dataIHora.Month;
            DateTime unMesDespres = dataIHora.AddMonths(1);
            DateTime unaQuarentenaDespres = dataIHora.AddDays(40);

            CultureInfo r = new CultureInfo("ar-DZ");
            string dataS = data.ToString("dddd, dd \\de MMMM \\de yyyy", r);


            txtMissatge.Text = dataS + "\n";
        }

        private void txtNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            double numero;
            bool conversioOk = Double.TryParse(tb.Text.Trim(), out numero);
            Windows.UI.Color colorDeFons = Windows.UI.Colors.Green;
            if (!conversioOk)
            {
                colorDeFons = Windows.UI.Colors.Red;
            }  
            tb.Background = new SolidColorBrush(colorDeFons);

            //tb.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(1, 255, 128, 34));
        }
    }
}
