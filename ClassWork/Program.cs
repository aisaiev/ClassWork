using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.AddStudent(new Student("a", "b", 1, "123", "dffas"));
            manager.AddStudent(new Student("c", "a", 2, "13", "aafas"));
            var st = manager.FindUserByFirstNameAndSecondName("a", "b");
        }
    }
}
