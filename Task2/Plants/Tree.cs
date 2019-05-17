using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Plants
{
    internal class Tree : Plant
    {
        private int amountOfBranches;

        public int AmountOfBranches
        {
            get
            {
                return amountOfBranches;
            }
            set
            {
                if (value > 0)
                {
                    amountOfBranches = value;
                }
                else
                {
                    amountOfBranches = 1;
                }
            }
        }

        public Tree(string type, int height, ConsoleColor color, int amountOfBranches)
            : base(type, color, height)
        {
            this.AmountOfBranches = amountOfBranches;
        }

        public void ToStagger()
        {
            Console.WriteLine("Tree staggered");
        }
    }
}
