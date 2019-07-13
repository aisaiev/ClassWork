using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_13_07;

namespace ClassWork
{
    class PingPongManager
    {
        private Ping ping;
        private Pong pong;

        public PingPongManager()
        {
            this.ping = new Ping();
            this.pong = new Pong();
            this.ping.PingEvent += OnPingInvoked;
            this.pong.PongEvent += OnPongInvoked;
        }

        public void Run()
        {
            this.ping.DoPing();
        }

        private void OnPingInvoked(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.ToString());
            this.pong.DoPong();
        }

        private void OnPongInvoked(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.ToString());
            this.ping.DoPing();
        }
    }
}
