using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Figures
{
    internal class Triangle : Figure
    {
        private int firstSide;

        private int secondSide;

        private int thirdSide;

        public int FirstSide
        {
            get
            {
                return firstSide;
            }
            set
            {
                if (value > 0)
                {
                    firstSide = value;
                }
                else
                {
                    firstSide = 1;
                }
            }
        }

        public int SecondSide
        {
            get
            {
                return secondSide;
            }
            set
            {
                if (value > 0)
                {
                    secondSide = value;
                }
                else
                {
                    secondSide = 1;
                }
            }
        }

        public int ThirdSide
        {
            get
            {
                return thirdSide;
            }
            set
            {
                if (value > 0)
                {
                    thirdSide = value;
                }
                else
                {
                    thirdSide = 1;
                }
            }
        }

        public Triangle(int x, int y, int firstSide, int secondSide, int thirdSide)
            : base(x, y)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }

        public override void Draw()
        {
            Console.WriteLine($"{this.GetType().Name} was drawn with: x={this.X}, y={this.Y}, firstSide={this.firstSide}, secondSide={this.secondSide}, thirdSide={this.thirdSide}");
        }
    }
}
