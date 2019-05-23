using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Figures
{
    public class Triangle : Figure
    {
        private int firstSide;

        private int secondSide;

        private int thirdSide;

        public int FirstSide
        {
            get
            {
                return this.firstSide;
            }
            set
            {
                this.firstSide = ValidateTriangleSide(value);
            }
        }

        public int SecondSide
        {
            get
            {
                return this.secondSide;
            }
            set
            {
                this.secondSide = ValidateTriangleSide(value);
            }
        }

        public int ThirdSide
        {
            get
            {
                return this.thirdSide;
            }
            set
            {
                this.thirdSide = ValidateTriangleSide(value);
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

        private int ValidateTriangleSide(int side)
        {
            if (side > 0)
            {
                return side;
            }
            else
            {
                return 1;
            }
        }
    }
}
