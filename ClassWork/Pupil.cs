using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Pupil
    {
        private string firstName;

        private string lastName;

        private string school;

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

        public string School
        {
            get
            {
                return this.school;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    this.school = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Pupil(string firstName, string lastName, string school)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.School = school;
        }
    }
}
