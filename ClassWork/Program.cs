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
            Helper helper = new Helper();
            Calculator calculator = new Calculator();

            helper.Execute(calculator.Add);

            helper.Execute(calculator.Multiply);

            helper.Execute(calculator.Divide);

            helper.Execute(calculator.Substruct);
        }
    }
}
