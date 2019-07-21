using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_13_07
{
    public class Rabit
    {

        private int xPosition;

        private int yPosition;

        public int XPosition
        {
            get
            {
                return this.xPosition;
            }
            private set
            {
                this.xPosition = value;
            }
        }

        public int YPosition
        {
            get
            {
                return this.yPosition;
            }
            private set
            {
                this.yPosition = value;
            }
        }

        public delegate void EventHandler(int xPosition, int yPosition);

        public event EventHandler MoveEvent;

        public void Move()
        {
            Random rnd = new Random();
            this.XPosition = rnd.Next(-100, 100);
            this.YPosition = rnd.Next(-50, 50);
            this.MoveEvent(this.XPosition, this.YPosition);
        }
    }
}
