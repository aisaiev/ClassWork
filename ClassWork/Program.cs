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
            Computer computer = new Computer();
            Console.WriteLine(computer.ToString());
            computer.Switch();
            Console.WriteLine(computer.ToString());
        }
    }
}
