using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL.Model
{
    public class Item
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public string ImageUrl { get; set; }

        public decimal? Cost { get; set; }

        public string Country { get; set; }

        public string Color { get; set; }

        public string Type { get; set; }
    }
}
