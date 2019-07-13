using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
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
                new Employee("Oleg", "Smith", 25, Gender.MALE, "IBM"),
            };
        }

        private static void PrintAllEmployeesInAlphabeticalOrderByName(List<Employee> employees)
        {
            foreach (var item in employees.OrderBy(x => x.FirstName).ToList())
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void PrintAllEmployeesWithAgeMoreThanThirty(List<Employee> employees)
        {
            foreach (var item in employees.Where(x => x.Age > 30).ToList())
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void PrintAllEmployeesByGender(List<Employee> employees, Gender gender)
        {
            foreach (var item in employees.Where(x => x.Gender == gender))
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void PrintAllEmployeesFirstNameAndSecondName(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"FirstName: {item.FirstName} SecondName: {item.LastName}");
            }
        }

        private static void PrintAllEmployeesFemaleWithNameStartingWitOAndAgeMoreTwenty(List<Employee> employees)
        {
            foreach (var item in employees.Where(x => x.Gender == Gender.FEMALE && x.FirstName.StartsWith("O") && x.Age > 20))
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void PrintEmployeesCountByCompany(List<Employee> employees)
        {
            foreach (var item in employees.Select(x => x.Company).Distinct())
            {
                Console.WriteLine($"{item} : {employees.Count(x => x.Company == item)}");
            }
        }

        private static void PrintFirstEmployee(List<Employee> employees)
        {
            Console.WriteLine(employees.First());
        }

        private static void PrintLastEmployee(List<Employee> employees)
        {
            Console.WriteLine(employees.Last());
        }

        private static void PrintFirstEmployeeWithAgeMoreTwentyFive(List<Employee> employees)
        {
            Console.WriteLine(employees.Where(x => x.Age > 25).First());
        }

        private static List<Pupil> CreatePupilFromEmployeesByFirstName(List<Employee> employees, string firstName, string school)
        {
            return employees.Where(x => x.FirstName == firstName).Select(x => new Pupil(x.FirstName, x.LastName, school)).ToList();
        }
    }
}
