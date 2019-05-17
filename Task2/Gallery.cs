using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Plants;

namespace Task2
{
    public class Gallery
    {
        public Plant[] Plants { get; set; }

        public Worker worker;

        public Gallery(Plant[] plants)
        {
            this.Plants = plants;
            this.worker = new Worker();
        }
    }
}
