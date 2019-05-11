using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork.Figures;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[]
            {
                new Square(5, 5, 10),
                new Square(2, 2, 5),
                new Square(2, 1, 5),
                new Circle(2, 2, 3),
                new Circle(2, 3, 4),
                new Circle(3, 3, 8),
                new Triangle(1, 1, 1, 2, 3),
                new Triangle(2, 2, 3, 3, 3),
                new Triangle(5, 5, 3, 2, 1),
                new Triangle(1, 0 , 5, 5, 5)
            };

            foreach (var figure in figures)
            {
                if (figure is Square square)
                {
                    square.Draw();
                }
                else if (figure is Circle circle)
                {
                    circle.Draw();
                }
                else if (figure is Triangle triangle)
                {
                    triangle.Draw();
                }
            }
        }
    }
}
