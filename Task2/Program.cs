using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Plants;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery = new Gallery(new Plant[] {
                new Tree("Oak", 10, ConsoleColor.Cyan, 5),
                new Flower("Chamomile", 5, ConsoleColor.White, 8)
            });
            gallery.worker.PourAndFeed(gallery.Plants[0]);
            gallery.worker.PourAndFeed(gallery.Plants[1]);
        }
    }
}
