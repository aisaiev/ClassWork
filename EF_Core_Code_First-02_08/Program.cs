using EF_Core_Code_First_02_08.Model;
using System;

namespace EF_Core_Code_First_02_08
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StoreContext())
            {
                Customer customer = new Customer()
                {
                    FirstName = "Bernard",
                    LastName = "Russell",
                    Email = "bernard.russell@torquentper.com"
                };

                context.Customers.Add(customer);

                context.SaveChanges();
            }
        }
    }
}
