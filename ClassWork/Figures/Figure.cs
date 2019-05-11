using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Figure
    {
        private int x;

        private int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Draw()
        {
            Console.WriteLine($"{this.GetType().Name} was drawn with: x={this.X}, y={this.Y}");
        }
    }
}
