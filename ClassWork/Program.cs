using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "не изменено";
            myStruct.change = "не изменено";
            Handler.ClassTaker(myClass);
            Handler.StructTaker(myStruct);
            Console.WriteLine($"myClass.change = {myClass.change}");
            Console.WriteLine($"myStruct.change = {myStruct.change}");
        }
    }
}
