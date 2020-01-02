using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_ClassWork_28_12_Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();

            CommandBinding newCommandBinding = new CommandBinding(ApplicationCommands.New);
            newCommandBinding.Executed += NewCommandBinding_Executed;
            newCommandBinding.CanExecute += NewCommandBinding_CanExecute;

            CommandBinding deleteCommandBinding = new CommandBinding(ApplicationCommands.Delete);
            deleteCommandBinding.Executed += DeleteCommandBinding_Executed;
            deleteCommandBinding.CanExecute += ShowDeleteCommandBinding_CanExecute;

            CommandBinding showCommandBinding = new CommandBinding(MyCommand.Show);
            showCommandBinding.Executed += ShowCommandBinding_Executed;
            showCommandBinding.CanExecute += ShowDeleteCommandBinding_CanExecute;

            this.CommandBindings.Add(newCommandBinding);
            this.CommandBindings.Add(deleteCommandBinding);
            this.CommandBindings.Add(showCommandBinding);

            this.employees = new ObservableCollection<Employee>()
            {
                new Employee(1, "Steven", "Marketing", new DateTime(2003, 6, 17), false),
                new Employee(2, "Neena", "Marketing", new DateTime(2005, 9, 21), false),
                new Employee(3, "Lex", "Human Resources", new DateTime(2011, 1, 13), false),
                new Employee(4, "Alexander", "Purchasing", new DateTime(2006, 1, 3), false),
                new Employee(5, "Bruce", "Executive", new DateTime(2005, 9, 28), true),
                new Employee(6, "David", "Human Resources", new DateTime(2006, 3, 7), false),
                new Employee(7, "Valli", "Purchasing", new DateTime(2002, 2, 11), true),
                new Employee(8, "Diana", "Public Relations", new DateTime(2007, 12, 07), false),
                new Employee(9, "Nancy", "IT", new DateTime(2005, 5, 1), false),
                new Employee(10, "Daniel", "Public Relations", new DateTime(2007, 5, 5), false),
            };
            this.MyDataGrid.AutoGenerateColumns = false;
            this.MyDataGrid.ItemsSource = employees;
        }

        private void ShowDeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (this.MyDataGrid.SelectedItem == null)
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void ShowCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("ShowCommand executed");
            new EmployeeInfoWindow() { DataContext = this.MyDataGrid.SelectedItem }.Show();
        }

        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("DeleteCommand executed");
            this.employees.Remove((Employee)this.MyDataGrid.SelectedItem);
        }

        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("NewCommand executed");
            int maxId = this.employees.Max(x => x.Id);
            this.employees.Add(new Employee(++maxId, null, null, DateTime.Now, false));
            this.MyDataGrid.SelectedIndex = this.MyDataGrid.Items.Count - 1;
        }
    }
}
