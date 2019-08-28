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
        public FridgeState FridgeState { get; private set; }

        public DoorState MainDoorState { get; private set; }

        public DoorState SecondaryDoorState { get; private set; }

        public string ChangedState { get; private set; }

        public FridgeEventArgs(FridgeState fridgeState, DoorState mainDoorState, DoorState secondaryDoorState, string changedState)
        {
            this.FridgeState = fridgeState;
            this.MainDoorState = mainDoorState;
            this.SecondaryDoorState = secondaryDoorState;
            this.ChangedState = changedState;
        }

        public override string ToString()
        {
            return $"{this.ChangedState}{Environment.NewLine}FridgeState: {this.FridgeState} MainDoorState: {this.MainDoorState} SecondaryDoorState: {this.SecondaryDoorState}";
        }
    }
}
