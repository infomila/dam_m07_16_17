using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace EseQLite.View
{
    public class DateConverter : IValueConverter
    {
        private static DateConverter s_Instance;
        public static DateConverter Instance
        {
            get
            {
                if (s_Instance == null) s_Instance = new DateConverter();
                return s_Instance;
            }
        }

         public object Convert(object value, Type targetType, object parameter, string language)
         {

             DateTime? origen = (DateTime?)value;
             string datePattern = "dd/MM/yyyy";
             if(parameter!=null)
             {
                 datePattern = (string)parameter;
             }
             return origen?.ToString(datePattern);
         }

         public object ConvertBack(object value, Type targetType, object parameter, string language)
         {
             return DateTime.Now; 
         }

    }
}
