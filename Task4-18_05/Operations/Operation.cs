using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_18_05
{
    public abstract class Operation
    {
        public virtual string Action { get; set; }

        public abstract double Calculate(double firstNumber, double secondNumber);

        public override string ToString()
        {
            return $"Вычисление происходит с помощью операции {this.Action}";
        }
    }
}
