using Databinding4_ClassLibrary.Constants;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Databinding4_ClassLibrary.Converters
{
    [ValueConversion(typeof(string), typeof(string))]
    public class TextToBinaryConverter : IValueConverter
    {
        private static Key _lastBinaryKeyPressed;
        
        public static Key LastBinaryKeyPressed
        {
            get { return _lastBinaryKeyPressed; }
            set { _lastBinaryKeyPressed = value; }
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string text)
            {
                if (!((Key.Delete == _lastBinaryKeyPressed) || (Key.Back == _lastBinaryKeyPressed)))
                {
                    if (!string.IsNullOrEmpty(text))
                    {
                        return System.Convert.ToString(System.Convert.ToInt32(text), 2).PadLeft(8, '0'); // Ensure 8-bit binary string
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    // Når der slettes i binær string, skal der ikke returneres
                    // 8 cifre i denne.
                    return System.Convert.ToString(System.Convert.ToInt32(text), 2);
                }
            }
            else
            {
                return "Invalid Input";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string text)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    if (text.Length > Const.NumberOfBitsInByte)
                    {
                        return System.Convert.ToString(System.Convert.ToInt32(text.Substring(0, Const.NumberOfBitsInByte), 2));
                    }
                    else
                    {
                        return System.Convert.ToString(System.Convert.ToInt32(text, 2));
                    }
                    //return System.Convert.ToString(System.Convert.ToInt32(text, 2));
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
    }
}
