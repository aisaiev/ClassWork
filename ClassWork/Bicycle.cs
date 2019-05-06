using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Bicycle : Vehicle
    {
        public Bicycle(int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {

        }

        public void PrintBicycle(Bicycle bicycle)
        {
            Console.WriteLine(string.Format("{0,10} {1,5} {2,9} {3,14}\n\n", "WheelCount", "Color", "MaxSpeed", "PassengerCount"));
            Console.WriteLine(string.Format("{0,10} {1,5} {2,9} {3,14}\n\n", bicycle.WheelCount, bicycle.Color, bicycle.MaxSpeed, bicycle.PassengerCount));
        }
    }

    enum BicycleType
    {
        RoadBike,
        MountainBike,
        BMX
    }

    enum BreakType
    {
        HandBrakes,
        FootBrakes
    }
}
