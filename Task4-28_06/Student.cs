using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_28_06
{
    public class Student
    {
        private string firstName;

        private string lastName;

        private string group;

        private string faculty;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.lastName = value;
                }
            }
        }

        public string Group
        {
            get
            {
                return this.group;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.group = value;
                }
            }
        }

        public string Faculty
        {
            get
            {
                return this.faculty;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.faculty = value;
                }
            }
        }

        public int CourseNumber { get; private set; }

        public Queue<string> tasks;

        public Student(string firstName, string lastName, int courseNumber, string group, string faculty)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CourseNumber = courseNumber;
            this.Group = group;
            this.faculty = faculty;
            this.tasks = new Queue<string>();
        }

        public void ResolveTask()
        {
            Console.WriteLine($"Task '{tasks.Peek()}' has been done");
            tasks.Dequeue();
        }

        public void GetBookFromLibrary(Library library)
        {
            library.GiveBook();
        }
    }
}
