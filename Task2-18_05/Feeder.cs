using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_18_05.Animals;

namespace Task2_18_05
{
    public class Feeder
    {
        public void Feed(Mammal[] mammals)
        {
            Random rnd = new Random();
            foreach (var mammal in mammals)
            {
                mammal.Eat(rnd.Next(1, 11));
                Console.WriteLine($"{mammal.GetType().Name} weight is {mammal.Weight}");
            }
        }
    }
}
