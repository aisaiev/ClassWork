using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Plants
{
    internal class Flower : Plant
    {
        private int amountOfPetals;

        public int AmounOfPetals
        {
            get
            {
                return amountOfPetals;
            }
            set
            {
                if (value > 0)
                {
                    amountOfPetals = value;
                }
                else
                {
                    amountOfPetals = 5;
                }
            }
        }

        public Flower(string type, int height, ConsoleColor color, int amountOfPetals)
            : base(type, color, height)
        {
            this.AmounOfPetals = amountOfPetals;
        }

        public void ToSmell()
        {
            Console.WriteLine("Flower smelled");
        }
    }
}
