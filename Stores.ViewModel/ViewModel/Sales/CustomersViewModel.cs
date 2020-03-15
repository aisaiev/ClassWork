using Microsoft.EntityFrameworkCore;
using Store.Model.Context;
using Stores.Model.Entity.Sales;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Stores.ViewModel.ViewModel.Sales
{
    public class CustomersViewModel : INotifyPropertyChanged
    {
        private Customer selectedCustomer;

        private OrdersViewModel ordersViewModel;

        public ObservableCollection<Customer> Customers { get; private set; }

        public Customer SelectedCustomer
        {
            get
            {
                return this.selectedCustomer;
            }
            set
            {
                if (this.selectedCustomer == value)
                    return;
                this.selectedCustomer = value;
                this.OnPropertyChanged(nameof(this.selectedCustomer));
                this.OrdersViewModel = new OrdersViewModel(this.selectedCustomer.Orders);
            }
        }

        public OrdersViewModel OrdersViewModel
        {
            get
            {
                return this.ordersViewModel;
            }
            set
            {
                if (this.ordersViewModel == value)
                    return;
                this.ordersViewModel = value;
                this.OnPropertyChanged(nameof(this.ordersViewModel));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public CustomersViewModel()
        {
            this.GetAllCustomers();
        }

        private void GetAllCustomers()
        {
            using var context = new StoresDbContext();
            List<Customer> customers = context.Customers
                .Include(customer => customer.Orders)
                .ThenInclude(order => order.OrderItems)
                .ThenInclude(orderItem => orderItem.Product)
                .ToList();
            this.Customers = new ObservableCollection<Customer>(customers);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
            {
                return;
            }
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
