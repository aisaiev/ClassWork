﻿using Author_Task.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Author_Task.Tools
{
    public class IsNewToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Author)
            {
                Author author = value as Author;
                if (author.IsNew)
                {
                    return "New Author";
                }
                else
                {
                    return "Edit Author";
                }
            }
            else if (value is Book)
            {
                Book book = value as Book;
                if (book.IsNew)
                {
                    return "New Book";
                }
                else
                {
                    return "Edit Book";
                }
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
