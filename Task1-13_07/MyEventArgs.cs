using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_13_07
{
    public class MyEventArgs: EventArgs
    {
        public DateTime Time { get; set; }

        public override string ToString()
        {
            return this.Time.ToString("HH:mm:ss");
        }
    }
}
