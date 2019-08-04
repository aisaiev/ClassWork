using ClassWork.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class FridgeEventArgs : EventArgs
    {
        public FridgeState FridgeState { get; set; }

        public MainDoorState MainDoorState { get; set; }

        public SecondaryDoorState SecondaryDoorState { get; set; }

        public string State { get; set; }

        public FridgeEventArgs(string state)
        {
            this.State = state;
        }
    }
}
