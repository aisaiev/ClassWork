using Stores.Model.Entity.Production;
using System.Collections.Generic;

namespace Stores.Model.Entity.Sales
{
    public class Store
    {
        public int StoreId { get; set; }

        public string StoreName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }


        public ICollection<Order> Orders { get; set; }
        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}
