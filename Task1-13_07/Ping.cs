using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1_13_07;

namespace ClassWork
{
    public class Ping
    {
        public string Message { get; } = "Ping";

        public delegate void PingDelegate(object sender, MyEventArgs e);

        public event PingDelegate PingEvent;

        protected virtual void OnPing(MyEventArgs e)
        {
            this.PingEvent?.Invoke(this, e);
        }

        public void DoPing()
        {
            MyEventArgs myEventArgs = new MyEventArgs
            {
                Time = DateTime.Now
            };
            Console.WriteLine(this.Message);
            Thread.Sleep(1000);
            this.OnPing(myEventArgs);
        }
    }
}
