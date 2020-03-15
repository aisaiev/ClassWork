using Stores.Model.Entity.Sales;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Stores.ViewModel.ViewModel.Sales
{
    public class OrderDetailsViewModel
    {
        public ObservableCollection<OrderItem> OrderItems { get; private set; }

        public OrderDetailsViewModel(ICollection<OrderItem> orderItems)
        {
            this.OrderItems = new ObservableCollection<OrderItem>(orderItems);
        }
    }
}
