using Stores.Model.Entity.Sales;
using System;
using System.Collections.Generic;

namespace Stores.Model.Entity.Production
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public DateTime ModelYear { get; set; }

        public decimal ListPrice { get; set; }


        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public ICollection<Stock> Stocks { get; set; }
    }
}
