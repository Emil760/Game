using SurvivalGT.Interfacies;
using SurvivalGT.Models;
using System;
using System.Globalization;
using System.Windows.Data;

namespace SurvivalGT.Utility
{
    class WeightCountConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var num = (float)values[0] * (int)values[1];
            if (num < 1) return String.Format(num * 1000 + " gramms");
            else if (num > 1000) return String.Format(num / 1000 + " tonns");
            else return String.Format(num + " kg");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class WeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var num = (float)value;
            if (num < 1) return String.Format(num * 1000 + " gramms");
            else if (num > 1000) return String.Format(num / 1000 + " tonns");
            else return String.Format(num + " kg");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class FloatToIntConverter : IValueConverter
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

    class CountCheckConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CraftItem item = (CraftItem)value;
            if (item.Loot.Count < item.Count) return false;
            else return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    class TimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int time = (int)value;
            if (time >= 43200) return (time / 43200) + " months";
            else if (time >= 1440) return (time / 1440) + " days";
            else if (time >= 60) return (time / 60) + " hours";
            else return time + " minutes";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    class SignConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int num = System.Convert.ToInt32(value);
            if (num > 0) return "+" + num;
            else return num;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    class BreakConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IBreakable breakable = (value as ILoot).Item as IBreakable;
            float percent = breakable.CurrentDurability * 100 / breakable.Durability;
            if (percent >= 66) return "Green";
            else if (percent >= 33) return "Yellow";
            else return "Red";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    class TimeConverter2 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int minutes = (int)value;
            string time = "";
            time += minutes / 1440 + ":";
            if (minutes / 1440 >= 1) minutes %= 1440;
            time += minutes / 60 + ":";
            if (minutes / 60 >= 1) minutes %= 60;
            time += minutes;
            return time;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
