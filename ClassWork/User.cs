using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class User
    {
        private FridgeEventArgs fridge;

        public User(FridgeEventArgs fridge)
        {
            this.fridge = fridge;
            this.fridge.FridgeEvent += this.fridge.PrintFridgeState;
        }

        public void ChangeFridgeState()
        {
            this.fridge?.OnChangeFridgeState();
        }
        public void ChangeFridgeMainDoorState()
        {
            this.fridge?.OnChangeMainDoorState();
        }
        public void ChangeFridgeSecondaryDoorState()
        {
            this.fridge?.OnChangeSecondaryDoorState();
        }

        public void Run()
        {
            ChangeFridgeState();
            ChangeFridgeMainDoorState();
            ChangeFridgeSecondaryDoorState();
        }
    }
}
