using EF_Core_01_08.Model;
using System;

namespace EF_Core_01_08
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ZzaContext())
            {
                Customer customer = new Customer()
                {
                    FirstName = "Vasya",
                    LastName = "Pupkin",
                    Id = Guid.NewGuid()
                };
                
                context.Customer.Add(customer);

                context.SaveChanges();

                foreach (var item in context.Customer)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }
            }
        }
    }
}
