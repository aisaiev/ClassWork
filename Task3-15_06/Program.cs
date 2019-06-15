using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_15_06
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.Add(new Car("Car1", "2019"));
            carCollection.Add(new Car("Car2", "2018"));
            carCollection.Add(new Car("Car3", "2017"));
            Console.WriteLine(carCollection.Count);
            Console.WriteLine(carCollection["Car2"].Year);
        }
    }
}
