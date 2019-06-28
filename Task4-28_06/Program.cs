using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4_28_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Manager manager = new Manager();
            manager.AddStudent(new Student("Vasya", "Pupkin", 1, "test group", "test faculty"));
            var student = manager.FindUserByFirstNameAndSecondName("Vasya", "Pupkin");
            student.GetBookFromLibrary(library);
            Thread.Sleep(1000);
            student.GetBookFromLibrary(library);
            student.GiveBookToLibrary(library);
            student.GiveBookToLibrary(library);
        }
    }
}
