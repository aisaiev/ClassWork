using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class User
    {
        private Fridge fridge;

        public User(Fridge fridge)
        {
            this.fridge = fridge;
            this.fridge.FridgeEvent += this.PrintFridgeState;
        }

        private void PrintFridgeState(object sender, FridgeEventArgs e)
        {
            Console.WriteLine(e.ToString());
        }

        public void Run()
        {
            Console.WriteLine($"1 - On/Off Fridge{Environment.NewLine}2 - Open/Close Main Door{Environment.NewLine}3 - Open/Close Secondary Door");
            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            this.fridge?.ChangeFridgeState();
                        }
                        break;
                    case "2":
                        {
                            this.fridge?.ChangeMainDoorState();
                        }
                        break;
                    case "3":
                        {
                            this.fridge?.ChangeSecondaryDoorState();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Option isn't available");
                        }
                        break;
                }
            } while (true);
        }
    }
}
