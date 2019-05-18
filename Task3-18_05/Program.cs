using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_18_05
{
    class Program
    {
        static void Main(string[] args)
        {
            American american = new American
            {
                Name = "Bob"
            };
            american.SayHello();

            Ukrainian ukrainian = new Ukrainian
            {
                Name = "Ivan"
            };
            ukrainian.SayHello();
        }
    }
}
