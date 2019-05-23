using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Figures
{
    public class Square : Figure
    {
        private int side;

        public int Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value > 0)
                {
                    this.side = value;
                }
                else
                {
                    this.side = 1;
                }
            }
        }

        public Square(int x, int y, int side)
            : base(x, y)
        {
            this.Side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"{this.GetType().Name} was drawn with: x={this.X}, y={this.Y}, side={this.side}");
        }
    }
}
