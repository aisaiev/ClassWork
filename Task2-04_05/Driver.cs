using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_04_05
{
    public class Driver : Employee
    {
        private DriverCategory category;

        public DriverCategory Category
        {
            get
            {
                return this.category;
            }
            set
            {
                this.category = value;
            }
        }

        public Driver(string firstName, string lastName, int age, decimal salary, DriverCategory category)
            :base(firstName, lastName, age, salary)
        {
            this.Category = category;
        }
    }
}
