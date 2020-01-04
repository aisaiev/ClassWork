using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_ClassWork_28_12_Task_2
{
    /// <summary>
    /// Interaction logic for EmployeeCreationWindow.xaml
    /// </summary>
    public partial class EmployeeCreationWindow : Window
    {
        public EmployeeCreationWindow()
        {
            InitializeComponent();
        }

        private void CreateEmployeeButtonClick(object sender, RoutedEventArgs e)
        {
            int id = (this.DataContext as ObservableCollection<Employee>).Max(x => x.Id);
            (this.DataContext as ObservableCollection<Employee>).Add(new Employee(++id, EmployeeInputControl.EmployeeNameTextBox.Text,
                EmployeeInputControl.EmployeeDepartmentTextBox.Text,
                DateTime.ParseExact(EmployeeInputControl.EmployeeHireDateTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                (bool)EmployeeInputControl.EmployeeIsManagerCheckBox.IsChecked));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeInputControl.EmployeeNameTextBox.Text = string.Empty;
            EmployeeInputControl.EmployeeDepartmentTextBox.Text = string.Empty;
            EmployeeInputControl.EmployeeHireDateTextBox.Text = string.Empty;
            EmployeeInputControl.EmployeeIsManagerCheckBox.IsChecked = false;
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
