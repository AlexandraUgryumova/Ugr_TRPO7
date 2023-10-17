using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;
using System.Windows.Data;
using System.Windows;

namespace Угрюмова_практическая_7.Converters
{
    class ImagePathConverter : IValueConverter
    {
        public object Converter(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"./../Images/{value}";
        }
        public object ConvertBack(object value, Type targetType, object patameter, CultureInfo culture)
        {
            return value.ToString().Substring(5);
        }
    }
}
