
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Pong
    {
        public string Message { get; } = "Pong";
        public event EventHandler PongEvent;

        protected virtual void OnPong(EventArgs e)
        {
            this.PongEvent?.Invoke(this, e);
        }

        public void DoPong()
        {
            Console.WriteLine(this.Message);
            Thread.Sleep(1000);
            this.OnPong(new EventArgs());
        }
    }
}
