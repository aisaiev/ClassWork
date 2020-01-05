﻿using Author_Task.Model;
using Author_Task.Tools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Author_Task.Views
{
    /// <summary>
    /// Interaction logic for AuthorWindow.xaml
    /// </summary>
    public partial class AuthorWindow : Window
    {
        public AuthorWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LanguageToColorConverter lngToColorConverter = new LanguageToColorConverter();
            this.Background = (SolidColorBrush)lngToColorConverter.Convert(this.LanguageComboBox.SelectedValue, null, null, CultureInfo.CurrentCulture);
        }

        private void LanguageComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            Author author = this.DataContext as Author;
            if (author.IsNew)
            {
                this.LanguageComboBox.SelectedIndex = -1;
            }
        }

        private void CountryComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            Author author = this.DataContext as Author;
            if (author.IsNew)
            {
                this.CountryComboBox.SelectedIndex = -1;
            }
        }
    }
}
