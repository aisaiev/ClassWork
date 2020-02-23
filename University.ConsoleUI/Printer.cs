using System;
using System.Collections.Generic;
using System.Text;
using University.DAL.Model;

namespace University.ConsoleUI
{
    public class Printer
    {
        public void PrintStudents(IEnumerable<Student> students)
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Id | First Name | Last Name");
            Console.WriteLine("---------------------------");
            foreach (var student in students)
            {
                Console.WriteLine(string.Format("{0, -2} | {1, -10} | {2, -10}", $"{student.StudentId}", $"{student.FirstName}", $"{student.LastName}"));
            }
            Console.WriteLine("---------------------------");
        }

        public void PrintCourses(List<Course> courses)
        {
            Console.Clear();
            Console.WriteLine("---------");
            Console.WriteLine("Id | Name");
            Console.WriteLine("---------");
            foreach (var course in courses)
            {
                Console.WriteLine(string.Format("{0, -2} | {1, -5}", $"{course.CourseId}", $"{course.Name}"));
            }
        }

        public void PrintDepartments(List<Department> departments)
        {
            Console.Clear();
            Console.WriteLine("---------");
            Console.WriteLine("Id | Name");
            Console.WriteLine("---------");
            foreach (var department in departments)
            {
                Console.WriteLine(string.Format("{0, -2} | {1, -5}", $"{department.DepartmentId}", $"{department.Name}"));
            }
        }

        public void PrintLoadingMessage()
        {
            Console.Write("Data is loading. Please wait...");
        }

        public void ClearConsole()
        {
            Console.Clear();
        }
    }
}
