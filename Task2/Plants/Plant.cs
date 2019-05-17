using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Plant
    {
        private string type;

        private int height;

        public ConsoleColor Color { get; set; }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    type = value;
                }
                else
                {
                    type = "Plant";
                }
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (height > 0)
                {
                    height = value;
                }
                else
                {
                    height = 1;
                }
            }
        }

        public Plant(string type, ConsoleColor color, int height)
        {
            this.Type = type;
            this.Color = color;
            this.Height = height;
        }

        public void FluidIntake()
        {
            this.Height++;
            Console.WriteLine($"{this.GetType().Name} {this.Type} was watered 1l water");
        }

        public void MineralConsumption()
        {
            Color = ChangeColor();
            Console.WriteLine($"{this.GetType().Name} {this.Type} grew by 1cm");
        }

        public void Oxigenetion()
        {
            Console.WriteLine($"{this.GetType().Name} {this.type} allocated 0.5 liters of oxygen");
        }

        public void FluidIntakeAndMineralConsumption()
        {
            this.FluidIntake();
            this.MineralConsumption();
            this.Oxigenetion();
        }

        private ConsoleColor ChangeColor()
        {
            Random rnd = new Random();
            return (ConsoleColor)rnd.Next(0, 16);
        }
    }
}
