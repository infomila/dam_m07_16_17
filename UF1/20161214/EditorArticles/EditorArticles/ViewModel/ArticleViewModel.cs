using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace EditorArticles
{
    [ImplementPropertyChanged]

    public class ArticleViewModel
    {
        public string Nom { get; set; }

        public string Descripcio { get; set; }

        /*private string mColor;
        public string color
        {
            get { return mColor; }
            set
            {
                mColor = value;
                colorBackground = GetSolidColorBrush(color);
            }
                
        }*/
        public string Color { get; set; }

        public void OnColorChanged()
        {
            bool conversioCorrecta;
            ColorBackground = GetSolidColorBrush(Color, out conversioCorrecta);
            if(conversioCorrecta)
            {
                ColorErroniBackground = new SolidColorBrush(Colors.Transparent);
            } else
            {
                ColorErroniBackground = new SolidColorBrush(Colors.PaleVioletRed);
            }
        }

        public SolidColorBrush ColorErroniBackground { get; set; }

        public SolidColorBrush ColorBackground { get; set; }

        public int Icona { get; set; }

        
        /// <summary>
        /// Convertir un string hexadecimal que representi un color en SolidColorBrush
        /// </summary>
        /// <param name="hex">string color hex</param>
        /// <returns></returns>
        public SolidColorBrush GetSolidColorBrush(string hex, out bool conversioCorrecta)
        {
            try
            {
                hex = hex.Replace("#", string.Empty);
                byte a = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
                byte r = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
                byte g = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
                byte b = (byte)(Convert.ToUInt32(hex.Substring(6, 2), 16));
                SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(a, r, g, b));
                conversioCorrecta = true;
                return myBrush;
            }catch(Exception ex)
            {
                conversioCorrecta = false;
                return new SolidColorBrush(Colors.Transparent);
            }
        }

        override public string ToString()
        {
            return Nom + " " + Descripcio;
        }

    }
}
