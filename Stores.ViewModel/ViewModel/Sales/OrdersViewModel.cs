using Stores.Model.Entity.Sales;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Stores.ViewModel.ViewModel.Sales
{
    public class OrdersViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Order> orders;

        private Order selectedOrder;

        private OrderDetailsViewModel orderDetailsViewModel;

        public ObservableCollection<Order> Orders
        {
            get
            {
                return this.orders;
            }
            private set
            {
                if (this.orders == value)
                    return;
                this.orders = value;
                this.OnPropertyChanged(nameof(this.orders));
            }
        }

        public Order SelectedOrder
        {
            get
            {
                return this.selectedOrder;
            }
            set
            {
                if (this.selectedOrder == value)
                    return;
                this.selectedOrder = value;
                this.OnPropertyChanged(nameof(this.selectedOrder));
                this.OrderDetailsViewModel = new OrderDetailsViewModel(this.selectedOrder.OrderItems);
            }
        }

        public OrderDetailsViewModel OrderDetailsViewModel
        {
            get
            {
                return this.orderDetailsViewModel;
            }
            set
            {
                if (this.orderDetailsViewModel == value)
                    return;
                this.orderDetailsViewModel = value;
                this.OnPropertyChanged(nameof(this.orderDetailsViewModel));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public OrdersViewModel(ICollection<Order> orders)
        {
            this.Orders = new ObservableCollection<Order>(orders);
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
