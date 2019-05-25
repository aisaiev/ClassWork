using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Computer : ISwitchable
    {
        public int State { get; private set; }

        public void SwitchOff()
        {
            this.State = 0;
            Console.WriteLine($"{this.GetType().Name} is turning off");
        }

        public void SwitchOn()
        {
            this.State = 1;
            Console.WriteLine($"{this.GetType().Name} is turning on");
        }

        public void Switch()
        {
            switch (this.State)
            {
                case 1:
                    SwitchOff();
                    break;
                case 0:
                    SwitchOn();
                    break;
            }
        }

        public override string ToString()
        {
            if (this.State == 0)
                return $"{this.GetType().Name} is off";
            else
                return $"{this.GetType().Name} is on";
        }
    }
}
