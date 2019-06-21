using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_15_06
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> NextItem { get; set; }
    }
}
