using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public EngineType EngineType { get; set; }
        public GearBoxType GearBoxType { get; set; }

        public Car(int doorsCount, EngineType engineType, GearBoxType gearBoxType, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            DoorsCount = doorsCount;
            EngineType = engineType;
            GearBoxType = gearBoxType;
        }

        public void PrintCar(Car car)
        {
            Console.WriteLine(string.Format("{0,10} {1,5} {2,9} {3,14} {4,10} {5,6} {6,7}\n\n", "WheelCount", "Color", "MaxSpeed", "PassengerCount", "DoorsCount", "Engine", "Gearbox"));
            Console.WriteLine(string.Format("{0,10} {1,5} {2,9} {3,14} {4,10} {5,6} {6,7}\n\n", car.WheelCount, car.Color, car.MaxSpeed, car.PassengerCount, car.DoorsCount, car.EngineType, car.GearBoxType));
        }
    }

    enum EngineType
    {
        Petrol,
        Diesel,
        Electro
    }

    enum GearBoxType
    {
        Manual,
        Auto
    }
}
