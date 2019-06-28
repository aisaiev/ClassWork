using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_28_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.AddStudent(new Student("Vasya", "Pupkin", 1, "test group", "test faculty"));
            manager.AssignTaskForStudent(manager.FindUserByFirstNameAndSecondName("Vasya", "Pupkin"), "Do Task1");
            manager.AssignTaskForStudent(manager.FindUserByFirstNameAndSecondName("Vasya", "Pupkin"), "Do Task2");

            var student = manager.FindUserByFirstNameAndSecondName("Vasya", "Pupkin");
            student.ResolveTask();
            student.ResolveTask();
        }
    }
}
