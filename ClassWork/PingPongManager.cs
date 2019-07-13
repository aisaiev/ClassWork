using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void OnPingInvoked(object sender, EventArgs e)
        {
            this.pong.DoPong();
        }

        private void OnPongInvoked(object sender, EventArgs e)
        {
            this.ping.DoPing();
        }
    }
}
