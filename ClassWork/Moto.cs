using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Moto : Vehicle
    {
        public Moto(int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {

        }

        public void PrintMoto(Moto moto)
        {
            Console.WriteLine(string.Format("{0,10} {1,5} {2,9} {3,14}\n\n", "WheelCount", "Color", "MaxSpeed", "PassengerCount"));
            Console.WriteLine(string.Format("{0,10} {1,5} {2,9} {3,14}\n\n", moto.WheelCount, moto.Color, moto.MaxSpeed, moto.PassengerCount));
        }
    }

    enum MotoType
    {
        Adventure,
        Chopper,
        Cruiser,
        Enduro
    }
}
