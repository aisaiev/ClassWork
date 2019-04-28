using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = FillTrainsArray(2);
            Train train = FindTrainByTrainNumber(trains);
            if (train != null)
            {
                train.PrintTrainInfo();
            }
            else
            {
                Console.WriteLine("Train is not found");
            }
        }

        private static Train[] FillTrainsArray(int numberOfTrains)
        {
            Train[] trains = new Train[numberOfTrains];
            for (int i = 0; i < numberOfTrains; i++)
            {
                Console.Write("Enter train number: ");
                string trainNumber = Console.ReadLine();
                Console.Write("Enter destination: ");
                string destination = Console.ReadLine();
                Console.Write("Enter departure time (yyyy-mm-dd hh:mm): ");
                string departureTime = Console.ReadLine();
                Train train = new Train(trainNumber, destination, DateTime.ParseExact(departureTime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
                trains[i] = train;
            }
            return trains.OrderBy(x => x.TrainNumber).ToArray();
        }

        private static Train FindTrainByTrainNumber(Train[] trains)
        {
            Console.Write("Enter train number to search: ");
            string trainNumber = Console.ReadLine();
            return Array.Find(trains, x => x.TrainNumber == trainNumber);
        }
    }
}
