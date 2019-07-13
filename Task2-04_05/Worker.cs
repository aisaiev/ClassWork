using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_04_05
{
    public class Worker
    {
        private string firstName;

        private string lastName;

        private int age;

        private decimal salary;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

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

        public Worker(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
    }
}
