using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_18_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] arrAnimal = new Animal[8];
            arrAnimal[0] = new Dog { Name = "Шарик" };
            arrAnimal[1] = new Cat { Name = "Кусака" };
            arrAnimal[2] = new Cat { Name = "Ленивец" };
            arrAnimal[3] = new Lynx { Name = "Леснушка" };
            arrAnimal[4] = new Dog { Name = "Джек" };
            arrAnimal[5] = new Cat { Name = "Черныш" };
            arrAnimal[6] = new Dog { Name = "Арчи" };
            arrAnimal[7] = new Lynx { Name = "Рыська" };

            //
            // The first method.
            //

            foreach (Animal a in arrAnimal)
            {
                a.Bite();
                if (a is IPurr purr)
                {
                    purr.Purr();
                }
            }

            //
            // The second method.
            //

            foreach (Animal a in arrAnimal)
            {
                a.Bite();
                if (a is Cat cat)
                {
                    cat.Purr();
                }
                if (a is Lynx lynx)
                {
                    lynx.Purr();
                }
            }

            //
            // The third method.
            //

            foreach (Animal a in arrAnimal)
            {
                a.Bite();
                IPurr purr = a as IPurr;
                if (purr != null)
                {
                    purr.Purr();
                }
            }
        }

        public interface IPurr
        {
            void Purr();
        }

        public abstract class Animal
        {
            public string Name { get; set; }

            public abstract void Bite();
        }

        public class Dog : Animal
        {
            public override void Bite()
            {
                Console.WriteLine("Собака {0} кусает", Name);
            }
        }

        public class Cat : Animal, IPurr
        {
            public override void Bite()
            {
                Console.WriteLine("Кошка {0} кусает", Name);
            }

            public void Purr()
            {
                Console.WriteLine("Кошка {0} мурчит", Name);
            }
        }

        public class Lynx : Animal, IPurr
        {
            public override void Bite()
            {
                Console.WriteLine("Рысь {0} кусает", Name);
            }

            public void Purr()
            {
                Console.WriteLine("Рысь {0} мурчит", Name);
            }
        }

    }
}
