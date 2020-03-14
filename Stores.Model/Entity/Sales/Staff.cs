using System.Collections.Generic;

namespace Stores.Model.Entity.Sales
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Active { get; set; }


        public int ManagerId { get; set; }

        public Staff Manger { get; set; }

        public int StoreId { get; set; }

        public Store Store { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
