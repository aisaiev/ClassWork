using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_04_05
{
    public class Student : User
    {
        private int course;

        private decimal scolarship;

        public int Course
        {
            get
            {
                return this.course;
            }
            set
            {
                if (value > 0)
                {
                    this.course = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public decimal Scolarship
        {
            get
            {
                return this.scolarship;
            }
            set
            {
                if (value > 0)
                {
                    this.scolarship = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Student(string firstName, string lastName, int age, decimal cource, decimal scolarship)
            :base(firstName, lastName, age)
        {
            this.Course = course;
            this.Scolarship = scolarship;
        }
    }
}
