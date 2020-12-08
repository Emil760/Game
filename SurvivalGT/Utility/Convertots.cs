using System;
using System.Globalization;
using System.Windows.Data;

namespace SurvivalGT.Utility
{
    class FloatToIntConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Math.Round((float)value).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

}
