using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWPF_25_01.Model
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public Customer(string firstName, string lastName, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
