using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Ping
    {
        public string Message { get; } = "Ping";
        public event EventHandler PingEvent;

        protected virtual void OnPing(EventArgs e)
        {
            this.PingEvent?.Invoke(this, e);
        }

        public void DoPing()
        {
            Console.WriteLine(this.Message);
            Thread.Sleep(1000);
            this.OnPing(new EventArgs());
        }
    }
}
