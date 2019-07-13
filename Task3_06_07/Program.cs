using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_06_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] firstArray = new Employee[]
            {
                new Employee("Tessa", "Bradshaw", 20, Gender.FEMALE, "Google"),
                new Employee("Drake", "Martin", 24, Gender.MALE, "Google"),
                new Employee("Peyton", "Mcclure", 35, Gender.MALE, "Google"),
                new Employee("Colt", "Chapman", 21, Gender.MALE, "Facebook"),
                new Employee("Vincent", "Arnold", 30, Gender.MALE, "Facebook"),
                new Employee("Kendal", "Sexton", 24, Gender.MALE, "Facebook"),
                new Employee("Derek", "Gonzalez", 25, Gender.MALE, "IBM"),
                new Employee("Josephine", "Barr", 27, Gender.FEMALE, "IBM"),
                new Employee("Tiana", "Mooney", 22, Gender.FEMALE, "IBM"),
                new Employee("Oleg", "Smith", 25, Gender.MALE, "IBM")
            };

            Employee[] secondArray = new Employee[]
            {
                new Employee("Tessa", "Bradshaw", 20, Gender.FEMALE, "Google"),
                new Employee("Drake", "Martin", 24, Gender.MALE, "Google"),
                new Employee("Peyton", "Mcclure", 35, Gender.MALE, "Google"),
                new Employee("Colt", "Chapman", 21, Gender.MALE, "Facebook"),
                new Employee("Vincent", "Arnold", 30, Gender.MALE, "Facebook"),
                new Employee("Kendal", "Sexton", 24, Gender.MALE, "Facebook"),
                new Employee("Derek", "Gonzalez", 25, Gender.MALE, "IBM"),
                new Employee("Josephine", "Barr", 27, Gender.FEMALE, "IBM"),
                new Employee("Tiana", "Mooney", 22, Gender.FEMALE, "IBM"),
                new Employee("Oleg", "Smith", 25, Gender.MALE, "IBM")
            };
        }

        private static List<Employee> CombineArraysWithRepetitions(Employee[] firstArray, Employee[] secondArray)
        {
            return firstArray.Concat(secondArray).ToList();
        }

        private static List<Employee> CombineArraysWithoutRepetitions(Employee[] firstArray, Employee[] secondArray)
        {
            return firstArray.Union(secondArray, new EmployeeComparer()).ToList();
        }

        private static void PrintDuplicateEmployees(Employee[] firstArray, Employee[] secondArray)
        {
            Employee[] employees = firstArray.Join(secondArray, x => x.FirstName, y => y.FirstName, (first, second) => first).ToArray();
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static List<Employee> CreateListFromArrayAndAddOneEmployee(Employee[] employeeArray, Employee employee)
        {
            List<Employee> employees = employeeArray.ToList();
            employees.Add(employee);
            return employees;
        }
    }
}
