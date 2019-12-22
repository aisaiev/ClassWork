using System;
using System.Collections.Generic;
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

namespace ClassWork_21_12_Task_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            List<Worker> workers = new List<Worker>()
            {
                new Worker(1, "Steven", "Marketing", new DateTime(2003, 6, 17), false),
                new Worker(2, "Neena", "Marketing", new DateTime(2005, 9, 21), false),
                new Worker(3, "Lex", "Human Resources", new DateTime(2011, 1, 13), false),
                new Worker(4, "Alexander", "Purchasing", new DateTime(2006, 1, 3), false),
                new Worker(5, "Bruce", "Executive", new DateTime(2005, 9, 28), true),
                new Worker(6, "David", "Human Resources", new DateTime(2006, 3, 7), false),
                new Worker(7, "Valli", "Purchasing", new DateTime(2002, 2, 11), false),
                new Worker(8, "Diana", "Public Relations", new DateTime(2007, 12, 07), false),
                new Worker(9, "Nancy", "IT", new DateTime(2005, 5, 1), false),
                new Worker(10, "Daniel", "Public Relations", new DateTime(2007, 5, 5), false),
            };

            this.MyDataGrid.AutoGenerateColumns = false;
            this.MyDataGrid.ItemsSource = workers;
        }
    }
}
