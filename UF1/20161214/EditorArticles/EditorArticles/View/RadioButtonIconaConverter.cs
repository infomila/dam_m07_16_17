using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace EditorArticles.View
{
    public class RadioButtonIconaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, 
            object parameter, string language)
        {
            // value és un integer que representa la icona que+
            // té l'article
            int icona = (int)value;
            int radioButtonActual = Int32.Parse(parameter.ToString());
            return radioButtonActual == icona;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            // Des de la interfície gràfica em donen si el
            // radio button està seleccionat.
            bool radioButtonActivat = (bool)value;
            if (radioButtonActivat)
            {
                return (int)parameter;
            }
            throw new Exception("El mati i la mare que el va parir");
        }
    }
}
