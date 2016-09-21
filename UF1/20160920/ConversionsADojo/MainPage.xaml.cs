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
            proves();  
        } 

        public void ignoram()
        {
            int[] llistaNumeros = { 3, 3, 4, 45, 5, 5, 4, 3,7 , 3 , 54};

            for(int i=0;i< llistaNumeros.Length;i++)
            {

            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"> la data a validar</param>
        /// <returns>   1 si és una data correcta, 
        ///             2 si és un fragment vàlid de data, o 
        ///             -1 si és incorrecta.</returns>
        private int validaData(string d)
        {
            d = d.Replace('-', '/');
            try
            {
                DateTime dataParsejada = DateTime.ParseExact(d, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                return 1;
            }
            catch (Exception)
            {}
            char[] separator = { '/' };
            StringSplitOptions opcionsSplit = StringSplitOptions.RemoveEmptyEntries;
            string[] trossos = d.Split(separator, opcionsSplit);
            int dia;
            if (trossos.Length == 0)
            {
                return 2;
            }
            else if (trossos.Length >= 1)
            {                
                bool esNumero = Int32.TryParse(trossos[0], out dia);

                if (trossos[0] == "0") return 2;

                if (esNumero && dia >= 1 && dia < 32)
                {
                   if(trossos.Length==1) return 2;
                }
                else
                {
                    return -1;
                }
            }
            if (trossos.Length >= 2)
            {
                int mes;
                bool esNumero = Int32.TryParse(trossos[1], out mes);
        
                if (trossos[1] == "0") return 2;

                if (esNumero && mes >= 1 && mes < 13)
                {
                    //validar dia i mes combinats
                    string dataFaker = 
                        trossos[0].PadLeft(2,'0') +
                        "/" + 
                        trossos[1].PadLeft(2, '0') +
                        "/2004";
                    try
                    {
                        DateTime dataParsejada = DateTime.ParseExact(dataFaker, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        if (trossos.Length == 2) return 2;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }                                       
                }
                else
                {
                    return -1;
                }
            }
            if (trossos.Length == 3)
            {
                int any;
                bool esNumero = Int32.TryParse(trossos[2], out any);
                if (esNumero && any > 0 && any < 1000)
                {
                    return 2;
                }
                return -1;
            }

            return -1;
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

        private void txtData_TextChanged(object sender, TextChangedEventArgs e)
        {
            int esValida = validaData(txtData.Text);
            Windows.UI.Color colorDeFons;
            switch (esValida)
            {
                case 2:     colorDeFons = Windows.UI.Colors.Orange; break;
                case 1:     colorDeFons = Windows.UI.Colors.Green;  break;
                default:    colorDeFons = Windows.UI.Colors.Red;    break;
            }
            txtData.Background = new SolidColorBrush(colorDeFons);
        }
    }
}
