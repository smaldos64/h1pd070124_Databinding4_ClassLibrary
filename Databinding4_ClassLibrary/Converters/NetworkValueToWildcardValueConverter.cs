using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

using Databinding4_ClassLibrary.Constants;

namespace Databinding4_ClassLibrary.Converters
{
    [ValueConversion(typeof(string), typeof(string))]
    public class NetworkValueToWildcardValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string text)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    return System.Convert.ToString(Const.MaxOctetValue - System.Convert.ToInt32(text)); 
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "Invalid Input";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("ConvertBack is not implemented"); // Not required for this scenario
        }
    }
}
