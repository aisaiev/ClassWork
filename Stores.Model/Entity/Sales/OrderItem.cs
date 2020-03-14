using Stores.Model.Entity.Production;

namespace Stores.Model.Entity.Sales
{
    public class OrderItem
    {
        public int ItemId { get; set; }

        public int Quantity { get; set; }

        public decimal ListPrice { get; set; }

        public double Discount { get; set; }


        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
