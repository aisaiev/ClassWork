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
            Console.WriteLine(Task3.ValidatePin("1234"));
            Console.WriteLine(Task3.ValidatePin("12345"));
            Console.WriteLine(Task3.ValidatePin("a234"));
        }
    }
}
