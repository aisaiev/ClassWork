using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_18_05
{
    public class Calculator
    {
        private Operation divide;
        private Operation multiplication;
        private Operation substruction;
        private Operation sum;

        public Operation Divide
        {
            get
            {
                return this.divide;
            }
            private set
            {
                this.divide = value;
            }
        }

        public Operation Multiplication
        {
            get
            {
                return this.multiplication;
            }
            private set
            {
                this.multiplication = value;
            }
        }

        public Operation Substruction
        {
            get
            {
                return this.substruction;
            }
            private set
            {
                this.substruction = value;
            }
        }

        public Operation Sum
        {
            get
            {
                return this.sum;
            }
            private set
            {
                this.sum = value;
            }
        }

        public Calculator()
        {
            this.Divide = new DivideOperation();
            this.Multiplication = new MultiplicationOperation();
            this.Substruction = new SubstructionOperation();
            this.Sum = new SumOperation();
        }
    }
}
