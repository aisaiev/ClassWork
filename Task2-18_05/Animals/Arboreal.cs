using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_18_05.Animals
{
    public class Arboreal : Mammal
    {
        public Arboreal(int age)
            : base(age)
        {

        }

        public override void Eat(int foodAmount)
        {
            if (this.Age <= 1)
            {
                Console.WriteLine($"{this.GetType().Name} eat milk");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} eat other food");
            }
            this.FoodAmount += foodAmount;
            if (this.FoodAmount % 5 == 0)
            {
                this.Weight += 5;
            }
        }

        public override void Move()
        {
            Console.WriteLine("Arboreal is crawling");
        }
    }
}
