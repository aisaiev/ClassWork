using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    //public delegate double CalculateDelegate(double firstNumber, double secondNumber);

    public class Calculator
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Substruct(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }

    public class Helper
    {
        public void Execute(Func<double, double, double> action)
        {
            double firstNumber = 10;
            double secondNumber = 20;
            double calculationResult = action(firstNumber, secondNumber);
            Console.WriteLine(calculationResult);
        }
    }
}
