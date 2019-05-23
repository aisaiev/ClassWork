using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_18_05
{
    public class MultiplicationOperation : Operation
    {
        private string action;

        public override string Action
        {
            get
            {
                return this.action;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.action = value;
                }
            }
        }

        public override double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public MultiplicationOperation()
        {
            this.Action = this.GetType().Name;
        }
    }
}
