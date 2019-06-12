using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp_SmartCookbook.Classes
{
    public class Bool2String : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool what = (bool)value;
            if (what)
                return Properties.Settings.Default.FilledHeart;// "/Icons/star.png";
            else
                return Properties.Settings.Default.EmptyHeart;//"/Icons/emptystar.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Contains(Properties.Settings.Default.EmptyHeart))
                return value;
            else
                return true;
        }
    }
    public class Bool2StringTooltip : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool what = (bool)value;
            if (what)
                return Properties.Settings.Default.Markedfavorite;
            else
                return Properties.Settings.Default.Markfavorite;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Contains(Properties.Settings.Default.Markfavorite))
                return value;
            else
                return true;
        }
    }

    public class PathToBaseDirectory : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string currentDirectory = System.Environment.CurrentDirectory;
            if (currentDirectory.EndsWith("\\bin\\Debug"))
            {
                int index = currentDirectory.IndexOf("\\bin\\Debug");
                currentDirectory = currentDirectory.Substring(0, index);
            }
            return currentDirectory + value.ToString();
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
    //public class ComboTime2StringTooltip : IValueConverter
    //{
    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        string what = value.ToString();
    //        if (what == "")
    //            return "0";
    //        else
    //            return what;
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        if (value.ToString().Contains(Properties.Settings.Default.Markfavorite))
    //            return value;
    //        else
    //            return true;
    //    }
    //}

    //public class ComboServings2StringTooltip : IValueConverter
    //{
    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        string what = value.ToString();
    //        if (what == "")
    //            return "1";
    //        else
    //            return what;
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        if (value.ToString().Contains(Properties.Settings.Default.Markfavorite))
    //            return value;
    //        else
    //            return true;
    //    }
    //}
}
