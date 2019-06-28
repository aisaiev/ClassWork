using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Manager
    {
        //
        // The first part.
        //
        private List<Student> studentsList;

        public Manager()
        {
            this.studentsList = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            this.studentsList.Add(student);
        }

        public void DisplayStudentsCount()
        {
            Console.WriteLine($"Count of students: {this.studentsList.Count}");
        }

        public void RemoveStudentByFirstNameAndSecondName(string firstName, string lastName)
        {
            int studentIndex = this.studentsList.FindIndex(x => x.FirstName == firstName && x.LastName == lastName);
            if (studentIndex != -1)
            {
                this.studentsList.RemoveAt(studentIndex);
                Console.WriteLine($"Student {firstName} {lastName} removed");
            }
            else
            {
                Console.WriteLine($"Student {firstName} {lastName} is not found");
            }
        }

        public void PrintAllStudents()
        {
            foreach (var student in studentsList)
            {
                Console.WriteLine($"First Name: {student.FirstName} Last Name: {student.LastName} Course Number: {student.CourseNumber}" +
                    $"Group: {student.Group} Faculty: {student.Faculty}");
            }
        }

        //
        // The second part.
        //
        public Student FindUserByFirstNameAndSecondName(string firstName, string lastName)
        {
            return this.studentsList.Find(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
