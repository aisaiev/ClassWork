using ClassWork.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Fridge
    {
        public FridgeState FridgeState { get; private set; }

        public DoorState MainDoorState { get; private set; }

        public DoorState SecondaryDoorState { get; private set; }

        public string ChangedState { get; set; }

        public event EventHandler<FridgeEventArgs> FridgeEvent;

        public void ChangeFridgeState()
        {
            if (this.FridgeState == FridgeState.Off)
            {
                this.FridgeState = FridgeState.On;
            }
            else
            {
                this.FridgeState = FridgeState.Off;
            }
            this.ChangedState = this.GetFridgeState();
            this.OnFridgeEvent();
        }

        public void ChangeMainDoorState()
        {
            if (this.MainDoorState == DoorState.Closed)
            {
                this.MainDoorState = DoorState.Opened;
            }
            else
            {
                this.MainDoorState = DoorState.Closed;
            }
            this.ChangedState = this.GetFridgeMainDoorState();
            this.OnFridgeEvent();
        }

        public void ChangeSecondaryDoorState()
        {
            if (this.SecondaryDoorState == DoorState.Closed)
            {
                this.SecondaryDoorState = DoorState.Opened;
            }
            else
            {
                this.SecondaryDoorState = DoorState.Closed;
            }
            this.ChangedState = this.GetFridgeSecondaryDoorState();
            this.OnFridgeEvent();
        }

        protected virtual void OnFridgeEvent()
        {
            this.FridgeEvent?.Invoke(this, new FridgeEventArgs(this.FridgeState, this.MainDoorState, this.SecondaryDoorState, this.ChangedState));
        }

        private string GetFridgeState()
        {
            return $"FridgeState: {this.FridgeState}";
        }

        private string GetFridgeMainDoorState()
        {
            return $"MainDoorState: {this.MainDoorState}";
        }

        private string GetFridgeSecondaryDoorState()
        {
            return $"MainDoorState: {this.SecondaryDoorState}";
        }
    }
}
