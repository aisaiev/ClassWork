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
                return this.age;
            }
            protected internal set
            {
                if (value > 0)
                {
                    this.age = value;
                }
                else
                {
                    this.age = 1;
                }
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            protected internal set
            {
                if (value > 0)
                {
                    this.weight = value;
                }
                else
                {
                    this.weight = 1;
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
                    this.foodAmount = value;
                }
                else
                {
                    this.foodAmount = 1;
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
