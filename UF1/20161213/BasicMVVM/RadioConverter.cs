using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace BasicMVVM
{
    class RadioConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (parameter.Equals(value.ToString()));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return Int32.Parse(parameter.ToString());
        }
    }
}
