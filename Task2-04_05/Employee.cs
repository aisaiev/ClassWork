using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_04_05
{
    public class Employee : User
    {
        private decimal salary;

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value > 0)
                {
                    this.salary = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Employee(string firstName, string lastName, int age, decimal salary)
            :base(firstName, lastName, age)
        {
            this.Salary = salary;
        }
    }
}
