using System.Collections.Generic;

namespace Stores.Model.Entity.Production
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }


        public ICollection<Product> Products { get; set; }
    }
}
