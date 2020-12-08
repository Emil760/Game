using System;
using System.Globalization;
using System.Windows.Data;

namespace SurvivalGT.Utility
{
    class MultConvertor : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return (float)values[0] * (int)values[1]; 
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


}
