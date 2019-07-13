using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Employee
    {
        private string firstName;

        private string lastName;

        private int age;

        private Gender gender;

        private string company;

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

        public string Company
        {
            get
            {
                return this.company;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    this.company = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public Employee(string firstName, string lastName, int age, Gender gender, string company)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.Company = company;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("FirstName: " + this.FirstName + " ");
            sb.Append("LastName: " + this.LastName + " ");
            sb.Append("Age: " + this.Age + " ");
            sb.Append("Gender: " + this.Gender + " ");
            sb.Append("Company: " + this.Company + " ");
            return sb.ToString();
        }
    }
}
