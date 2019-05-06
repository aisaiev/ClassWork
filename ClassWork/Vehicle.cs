using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Vehicle
    {
        private int wheelCount = 1;
        private int maxSpeed = 1;
        public ConsoleColor Color { get; set; }
        public int PassengerCount { get; set; }
        public int WheelCount
        {
            get { return wheelCount; }
            set
            {
                if (value > 0)
                {
                    wheelCount = value;
                }
            }
        }
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0)
                {
                    maxSpeed = value;
                }
            }
        }

        public void Move(int meters)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"{GetType().Name} has moved {meters} meters.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public Vehicle(int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
        {
            WheelCount = wheelCount;
            Color = color;
            MaxSpeed = maxSpeed;
            PassengerCount = passengerCount;
        }
    }
}
