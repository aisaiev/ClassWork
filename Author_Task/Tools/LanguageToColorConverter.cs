using Author_Task.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Author_Task.Tools
{
    public class LanguageToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
            {
                return new SolidColorBrush(Colors.White);
            }
            else
            {
                string language = value.ToString();
                if (language == Language.Ukrainian.ToString())
                {
                    return new SolidColorBrush(Colors.AliceBlue);
                }
                else if (language == Language.English.ToString())
                {
                    return new SolidColorBrush(Colors.LightYellow);
                }
                else if (language == Language.Deutsch.ToString())
                {
                    return new SolidColorBrush(Colors.LightGreen);
                }
            }
            return new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
