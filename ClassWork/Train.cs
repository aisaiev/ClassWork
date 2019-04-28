using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Train
    {
        public string TrainNumber { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }

        public Train(string TrainNumber, string Destination, DateTime DepartureTime)
        {
            this.TrainNumber = TrainNumber;
            this.Destination = Destination;
            this.DepartureTime = DepartureTime;
        }

        public void PrintTrainInfo()
        {
            Console.WriteLine($"Train Number: {TrainNumber} Destination: {Destination} Departure time: {DepartureTime}");
        }
    }
}
