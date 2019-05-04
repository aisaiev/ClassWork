using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Pupil
    {
        public int age;
        public int yearOfBirth;
        public string firstName;
        public string lastName;
        public string School { get; set; }
        public string Grade { get; set; }

        public Pupil(string firstName, string lastName, int yearOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            age = CalculateAgeFromYearOfBirth(yearOfBirth);
        }

        private int CalculateAgeFromYearOfBirth(int yearOfBirth)
        {
            DateTime dateTime = DateTime.Now;
            int currentYear = dateTime.Year;
            if (currentYear > yearOfBirth)
            {
                return dateTime.Year - yearOfBirth;
            }
            else
            {
                return 0;
            }
        }

        public static void PrintPupils(Pupil[] pupils)
        {
            Console.WriteLine(string.Format("{0,10} {1,7} {2,5} {3,7} {4,7}\n\n", "Имя", "Год рожд.", "Возраст", "Школа", "Класс"));
            foreach (var item in pupils)
            {
                Console.WriteLine(string.Format("{0,10} {1,7} {2,5} {3,7} {4,7}\n\n", item.lastName + ' ' + item.firstName, item.yearOfBirth, item.age, item.School, item.Grade));
            }
        }
    }
}
