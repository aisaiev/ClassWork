using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_18_05.Animals
{
    public class Mammal
    {
        private int age;

        private int weight;

        private int foodAmount;

        public int Age
        {
            get
            {
                return age;
            }
            protected internal set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 1;
                }
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            protected internal set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    weight = 1;
                }
            }
        }

        public int FoodAmount
        {
            get
            {
                return foodAmount;
            }
            protected internal set
            {
                if (value > 0)
                {
                    foodAmount = value;
                }
                else
                {
                    foodAmount = 1;
                }
            }
        }

        public Mammal(int age)
        {
            this.Age = age;
            this.Weight = 1;
        }

        public virtual void Eat(int foodAmount)
        {
            if (age <= 1)
            {
                Console.WriteLine($"{this.GetType().Name} eat milk");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} eat other food");
            }
            this.foodAmount += foodAmount;
            if (this.foodAmount % 5 == 0)
            {
                this.Weight++;
            }
        }

        public virtual void Move()
        {
            Console.WriteLine("Mammal is moving");
        }
    }
}
