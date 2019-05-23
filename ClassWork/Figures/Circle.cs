﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Figures
{
    public class Circle : Figure
    {
        private int radius;

        public int Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value > 0)
                {
                    this.radius = value;
                }
                else
                {
                    this.radius = 1;
                }
            }
        }

        public Circle(int x, int y, int radius)
            : base(x, y)
        {
            this.Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"{this.GetType().Name} was drawn with: x={this.X}, y={this.Y}, radius={this.Radius}");
        }
    }
}
