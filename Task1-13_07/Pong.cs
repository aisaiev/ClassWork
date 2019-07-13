
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1_13_07;

namespace ClassWork
{
    public class Pong
    {
        public string Message { get; } = "Pong";

        public delegate void PongDelegate(object sender, MyEventArgs e);

        public event PongDelegate PongEvent;

        protected virtual void OnPong(MyEventArgs e)
        {
            this.PongEvent?.Invoke(this, e);
        }

        public void DoPong()
        {
            MyEventArgs myEventArgs = new MyEventArgs
            {
                Time = DateTime.Now
            };
            Console.WriteLine(this.Message);
            Thread.Sleep(1000);
            this.OnPong(myEventArgs);
        }
    }
}
