using Shop.DAL.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Shop.WPF.Tool
{
    class Base64ToBitmapImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Item)
            {
                Item item = value as Item;
                if (!string.IsNullOrWhiteSpace(item.ImageUrl))
                {
                    return this.Base64ToBitmapImage(item.ImageUrl);
                }
                else
                {
                    return new BitmapImage();
                }
            }
            return new BitmapImage();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private BitmapImage Base64ToBitmapImage(string base64String)
        {
            byte[] imgBytes = System.Convert.FromBase64String(base64String);
            BitmapImage bitmapImage = new BitmapImage();
            MemoryStream memoryStream = new MemoryStream(imgBytes);
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = memoryStream;
            bitmapImage.EndInit();
            return bitmapImage;
        }
    }
}
