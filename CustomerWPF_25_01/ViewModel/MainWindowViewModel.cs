using CustomerWPF_25_01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWPF_25_01.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public Customer SelectedCustomer { get; set; }

        public MainWindowViewModel()
        {
            this.Customers = new ObservableCollection<Customer>()
            {
                new Customer("Steven", "King", "New York"),
                new Customer("Neena", "Delroy", "Washington"),
                new Customer("Lex", "Smith", "Chicago"),
                new Customer("Alexander", "Gates", "Los Angeles"),
                new Customer("Bruce", "Willis", "Atlanta"),
            };
        }
    }
}
