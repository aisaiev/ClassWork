using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_ClassWork_28_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void My_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"MouseEnter: source {e.Source} sender {sender}");
        }

        private void My_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine($"MouseDown: source {e.Source} sender {sender}");
        }

        private void MyBorder_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Click: source {e.Source} sender {sender}");
            if (!(e.Source is CheckBox))
            {
                for (int i = 1; i <= 3; i++)
                {
                    Button btn = new Button()
                    {
                        Content = $"Button {i}",
                        Margin = new Thickness(20, 5, 20, 0)
                    };
                    btn.Click += Btn_Click;
                    MyStackPanel.Children.Add(btn);
                }
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Background = Brushes.GreenYellow;
            e.Handled = true;
        }
    }
}
