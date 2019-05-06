using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle(4, ConsoleColor.Green, 100, 4);
            Vehicle vehicle2 = new Vehicle(4, ConsoleColor.Green, 100, 4);
            vehicle1.Move(100);
            vehicle2.Move(100);

            Car car1 = new Car(4, EngineType.Diesel, GearBoxType.Auto, 4, ConsoleColor.Blue, 100, 4);
            Car car2 = new Car(4, EngineType.Petrol, GearBoxType.Manual, 4, ConsoleColor.Blue, 100, 4);
            car1.Move(200);
            car2.Move(200);

            Bicycle bicycle1 = new Bicycle(2, ConsoleColor.Cyan, 40, 1);
            Bicycle bicycle2 = new Bicycle(3, ConsoleColor.Cyan, 10, 1);
            bicycle1.Move(300);
            bicycle2.Move(300);

            Moto moto1 = new Moto(2, ConsoleColor.Red, 100, 2);
            Moto moto2 = new Moto(2, ConsoleColor.Red, 100, 3);
            moto1.Move(400);
            moto2.Move(400);
        }
    }
}
